// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 86
// Methods: 3230

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollection`1 : Object
    {
        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x7A7E01900
        public void get_IsCompleted(){} // RVA: 0x7A7E01900
        public void get_Count(){} // RVA: 0x7A7E00710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Initialize(){} // RVA: 0x7A7E1E220
        public void Add(){} // RVA: 0x7A8051B10
        public void TryAddWithNoTimeValidation(){} // RVA: 0x7A8051B10
        public void TryTake(){} // RVA: 0x7A8051B10
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x7A8051B10
        public void CancelWaitingConsumers(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18C30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void ValidateMillisecondsTimeout(){} // RVA: 0x7A7E19BA0
        public void CheckDisposed(){} // RVA: 0x7A7E18770
    }

    public class BlockingCollection`1 : Object
    {
        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x7AD4F4AB0
        public void get_IsCompleted(){} // RVA: 0x7AD4F4AF0
        public void get_Count(){} // RVA: 0x7AD4F4B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7AD4F4BC0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void .ctor(){} // RVA: 0x7AD4F4E30
        public void Initialize(){} // RVA: 0x7AD4F4F00
        public void Add(){} // RVA: 0x7AD4F5200
        public void TryAddWithNoTimeValidation(){} // RVA: 0x7AD4F5240
        public void TryTake(){} // RVA: 0x7AD4F58F0
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x7AD4F5A20
        public void CancelWaitingConsumers(){} // RVA: 0x7AD4F6010
        public void Dispose(){} // RVA: 0x7AD4F60F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AD4F6140
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7AD4F6480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AD4F64F0
        public void ValidateMillisecondsTimeout(){} // RVA: 0x7AD4F6540
        public void CheckDisposed(){} // RVA: 0x7AD4F6640
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBFCE20
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7A8DD7270
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x7A8DD7270
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x7A8DD7270
        public void .cctor(){} // RVA: 0x7ADBFCE30
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBFCE20
        public void ConcurrentBag_TryTakeSteals(){} // RVA: 0x7A8DD7270
        public void ConcurrentBag_TryPeekSteals(){} // RVA: 0x7A8DD7270
        public void .cctor(){} // RVA: 0x7AEAAD630
    }

    public class ConcurrentBag`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Add(){} // RVA: 0x7A8051B10
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7A8051B10
        public void TryTake(){} // RVA: 0x7A7E019D0
        public void GetCurrentThreadWorkStealingQueue(){} // RVA: 0x7A7E063A0
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x7A7E00680
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x7A7E00680
        public void TrySteal(){} // RVA: 0x7A7E03AD0
        public void TryStealFromTo(){} // RVA: 0x7A8051B10
        public void CopyTo(){} // RVA: 0x7A7E1D590
        public void CopyFromEachQueueToArray(){} // RVA: 0x7A7E09FB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void ToArray(){} // RVA: 0x7A7E00680
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void get_Count(){} // RVA: 0x7A7E00710
        public void get_DangerousCount(){} // RVA: 0x7A7E00710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void get_GlobalQueuesLock(){} // RVA: 0x7A7E00680
        public void FreezeBag(){} // RVA: 0x7A7E18800
        public void UnfreezeBag(){} // RVA: 0x7A7E18C30
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA7F8010
        public void GetOrAdd(){} // RVA: 0x7AA7FACA0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA7F7990
        public void InitializeFromCollection(){} // RVA: 0x7AA7F7D00
        public void TryAdd(){} // RVA: 0x7AA7F83C0
        public void ContainsKey(){} // RVA: 0x7AA7F8510
        public void TryRemove(){} // RVA: 0x7AA7F8550
        public void TryRemoveInternal(){} // RVA: 0x7AA7F8590
        public void TryGetValue(){} // RVA: 0x7AA7F8B00
        public void TryGetValueInternal(){} // RVA: 0x7AA7F8C30
        public void TryUpdateInternal(){} // RVA: 0x7AA7F8E10
        public void Clear(){} // RVA: 0x7AA7F9360
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA7F9610
        public void ToArray(){} // RVA: 0x7AA7F9850
        public void CopyToPairs(){} // RVA: 0x7AA7F9AB0
        public void CopyToEntries(){} // RVA: 0x7AA7F9BD0
        public void CopyToObjects(){} // RVA: 0x7AA7F9D20
        public void GetEnumerator(){} // RVA: 0x7AA7F9E90
        public void TryAddInternal(){} // RVA: 0x7AA7F9F30
        public void get_Item(){} // RVA: 0x7AA7FA670
        public void set_Item(){} // RVA: 0x7AA7FA740
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA7FA960
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA7FB0F0
        public void get_IsEmpty(){} // RVA: 0x7AA7FB350
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA7FB480
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA7FB620
        public void get_Keys(){} // RVA: 0x7AA7FB680
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA7FB680
        public void get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA7FB6C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA7FB7A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA7FB840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA7FB890
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA7FB8B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA7FBAD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA7FBC00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA7FB680
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA7FBCE0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA7FBE20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA7FBF40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA7FC280
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA7FC860
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA7FD010
        public void AcquireAllLocks(){} // RVA: 0x7AA7FD060
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA7FD370
        public void GetValues(){} // RVA: 0x7AA7FD640
        public void OnSerializing(){} // RVA: 0x7AA7FD900
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA7FDA20
        public void .cctor(){} // RVA: 0x7AA7FDCF0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7A7E01960
        public void .ctor(){} // RVA: 0x7A8051B10
        public void InitializeFromCollection(){} // RVA: 0x7A7E18800
        public void TryAdd(){} // RVA: 0x7A8051B10
        public void ContainsKey(){} // RVA: 0x7A8051B10
        public void TryRemove(){} // RVA: 0x7A8051B10
        public void TryRemoveInternal(){} // RVA: 0x7A8051B10
        public void TryGetValue(){} // RVA: 0x7A8051B10
        public void TryGetValueInternal(){} // RVA: 0x7A8051B10
        public void TryUpdateInternal(){} // RVA: 0x7A8051B10
        public void Clear(){} // RVA: 0x7A7E18770
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7A7E1D590
        public void ToArray(){} // RVA: 0x7A7E00680
        public void CopyToPairs(){} // RVA: 0x7A7E1D590
        public void CopyToEntries(){} // RVA: 0x7A7E1D590
        public void CopyToObjects(){} // RVA: 0x7A7E1D590
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void TryAddInternal(){} // RVA: 0x7A8051B10
        public void get_Item(){} // RVA: 0x7A8051B10
        public void set_Item(){} // RVA: 0x7A8051B10
        public void ThrowKeyNotFoundException(){} // RVA: 0x7A7E18830
        public void ThrowKeyNullException(){} // RVA: 0x7A7E187D0
        public void get_Count(){} // RVA: 0x7A7E00710
        public void GetCountInternal(){} // RVA: 0x7A7E00710
        public void GetOrAdd(){} // RVA: 0x7A8051B10
        public void AddOrUpdate(){} // RVA: 0x7A8051B10
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7A8051B10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7A8051B10
        public void get_Keys(){} // RVA: 0x7A7E00680
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7A7E00680
        public void get_Values(){} // RVA: 0x7A7E00680
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7A7E00680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7A8051B10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7A8051B10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7A8051B10
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7A7E18890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7A7E019D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A7E01900
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A7E01900
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7A7E18800
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7A7E00680
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7A7E00B20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7A7E18890
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void GrowTable(){} // RVA: 0x7A7E18800
        public void GetBucket(){} // RVA: 0x7A7E079F0
        public void GetBucketAndLockNo(){} // RVA: 0x7A8051B10
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7A7E015C0
        public void AcquireAllLocks(){} // RVA: 0x7A7E18800
        public void AcquireLocks(){} // RVA: 0x7A7E1A4C0
        public void ReleaseLocks(){} // RVA: 0x7A7E1ABE0
        public void GetKeys(){} // RVA: 0x7A7E00680
        public void GetValues(){} // RVA: 0x7A7E00680
        public void OnSerializing(){} // RVA: 0x7A7E18800
        public void OnSerialized(){} // RVA: 0x7A7E18800
        public void OnDeserialized(){} // RVA: 0x7A7E18800
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA847AA0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA847420
        public void InitializeFromCollection(){} // RVA: 0x7AA847790
        public void TryAdd(){} // RVA: 0x7AA847E50
        public void ContainsKey(){} // RVA: 0x7AA7F8510
        public void TryRemove(){} // RVA: 0x7AA7F8550
        public void TryRemoveInternal(){} // RVA: 0x7AA7F8590
        public void TryGetValue(){} // RVA: 0x7AA7F8B00
        public void TryGetValueInternal(){} // RVA: 0x7AA7F8C30
        public void TryUpdateInternal(){} // RVA: 0x7AA7F8E10
        public void Clear(){} // RVA: 0x7AA847FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA848250
        public void ToArray(){} // RVA: 0x7AA848490
        public void CopyToPairs(){} // RVA: 0x7AA8486F0
        public void CopyToEntries(){} // RVA: 0x7AA7F9BD0
        public void CopyToObjects(){} // RVA: 0x7AA7F9D20
        public void GetEnumerator(){} // RVA: 0x7AA7F9E90
        public void TryAddInternal(){} // RVA: 0x7AA848830
        public void get_Item(){} // RVA: 0x7AA7FA670
        public void set_Item(){} // RVA: 0x7AA848F00
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA849050
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8492F0
        public void AddOrUpdate(){} // RVA: 0x7AA849740
        public void get_IsEmpty(){} // RVA: 0x7AA8499A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA849AD0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA7FB620
        public void get_Keys(){} // RVA: 0x7AA849C70
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA849C70
        public void get_Values(){} // RVA: 0x7AA849C90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA849C90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA7FB6C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA7FB7A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA7FB840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA7FB890
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA7FB8B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA7FBAD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA7FBC00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA849C70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA7FBCE0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA849C90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA7FBE20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA849CB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA849ED0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA84A4B0
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA84AC30
        public void AcquireAllLocks(){} // RVA: 0x7AA84AC80
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA84AD70
        public void GetValues(){} // RVA: 0x7AA84B040
        public void OnSerializing(){} // RVA: 0x7AA84B300
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA84B3C0
        public void .cctor(){} // RVA: 0x7AA84B690
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA847AA0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA847420
        public void InitializeFromCollection(){} // RVA: 0x7AA847790
        public void TryAdd(){} // RVA: 0x7AA847E50
        public void ContainsKey(){} // RVA: 0x7AA7F8510
        public void TryRemove(){} // RVA: 0x7AA7F8550
        public void TryRemoveInternal(){} // RVA: 0x7AA7F8590
        public void TryGetValue(){} // RVA: 0x7AA7F8B00
        public void TryGetValueInternal(){} // RVA: 0x7AA7F8C30
        public void TryUpdateInternal(){} // RVA: 0x7AA7F8E10
        public void Clear(){} // RVA: 0x7AA847FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA848250
        public void ToArray(){} // RVA: 0x7AA848490
        public void CopyToPairs(){} // RVA: 0x7AA8486F0
        public void CopyToEntries(){} // RVA: 0x7AA7F9BD0
        public void CopyToObjects(){} // RVA: 0x7AA7F9D20
        public void GetEnumerator(){} // RVA: 0x7AA7F9E90
        public void TryAddInternal(){} // RVA: 0x7AA848830
        public void get_Item(){} // RVA: 0x7AA7FA670
        public void set_Item(){} // RVA: 0x7AA848F00
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA849050
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8492F0
        public void AddOrUpdate(){} // RVA: 0x7AA849740
        public void get_IsEmpty(){} // RVA: 0x7AA8499A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA849AD0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA7FB620
        public void get_Keys(){} // RVA: 0x7AA849C70
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA849C70
        public void get_Values(){} // RVA: 0x7AA849C90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA849C90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA7FB6C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA7FB7A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA7FB840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA7FB890
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA7FB8B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA7FBAD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA7FBC00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA849C70
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA7FBCE0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA849C90
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA7FBE20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA849CB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA849ED0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA84A4B0
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA84AC30
        public void AcquireAllLocks(){} // RVA: 0x7AA84AC80
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA84AD70
        public void GetValues(){} // RVA: 0x7AA84B040
        public void OnSerializing(){} // RVA: 0x7AA84B300
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA84B3C0
        public void .cctor(){} // RVA: 0x7AA84B690
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA83ABF0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA83A4F0
        public void InitializeFromCollection(){} // RVA: 0x7AA83A860
        public void TryAdd(){} // RVA: 0x7AA83AFA0
        public void ContainsKey(){} // RVA: 0x7AA83B110
        public void TryRemove(){} // RVA: 0x7AA83B160
        public void TryRemoveInternal(){} // RVA: 0x7AA83B1B0
        public void TryGetValue(){} // RVA: 0x7AA83B6D0
        public void TryGetValueInternal(){} // RVA: 0x7AA83B810
        public void TryUpdateInternal(){} // RVA: 0x7AA83B9A0
        public void Clear(){} // RVA: 0x7AA83BED0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA83C180
        public void ToArray(){} // RVA: 0x7AA83C490
        public void CopyToPairs(){} // RVA: 0x7AA83C6F0
        public void CopyToEntries(){} // RVA: 0x7AA83C800
        public void CopyToObjects(){} // RVA: 0x7AA83C970
        public void GetEnumerator(){} // RVA: 0x7AA83CAE0
        public void TryAddInternal(){} // RVA: 0x7AA83CB80
        public void get_Item(){} // RVA: 0x7AA83D230
        public void set_Item(){} // RVA: 0x7AA83D310
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA83D480
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA83D750
        public void AddOrUpdate(){} // RVA: 0x7AA83DCA0
        public void get_IsEmpty(){} // RVA: 0x7AA83E040
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA83E170
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA83E330
        public void get_Keys(){} // RVA: 0x7AA83E3A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA83E3A0
        public void get_Values(){} // RVA: 0x7AA83E3C0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA83E3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA83E3E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA83E460
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA83E510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA83E570
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA83E590
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA83E7C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA83E900
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA83E3A0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA83E9E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA83E3C0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA83EB20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA83EC50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA83EE80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA83F460
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA83FC00
        public void AcquireAllLocks(){} // RVA: 0x7AA83FC50
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA83FD40
        public void GetValues(){} // RVA: 0x7AA840010
        public void OnSerializing(){} // RVA: 0x7AA8402D0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA840390
        public void .cctor(){} // RVA: 0x7AA840660
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x7AA18B300
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA88F960
        public void IsValueWriteAtomic(){} // RVA: 0x7AA88F280
        public void InitializeFromCollection(){} // RVA: 0x7AA88F5F0
        public void TryAdd(){} // RVA: 0x7AA88FD10
        public void ContainsKey(){} // RVA: 0x7AA88FDD0
        public void TryRemove(){} // RVA: 0x7AA88FE00
        public void TryRemoveInternal(){} // RVA: 0x7AA88FE40
        public void TryGetValue(){} // RVA: 0x7AA8902E0
        public void TryGetValueInternal(){} // RVA: 0x7AA890390
        public void TryUpdateInternal(){} // RVA: 0x7AA8904E0
        public void Clear(){} // RVA: 0x7AA8909B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA890C60
        public void ToArray(){} // RVA: 0x7AA890EA0
        public void CopyToPairs(){} // RVA: 0x7AA891100
        public void CopyToEntries(){} // RVA: 0x7AA80FAD0
        public void CopyToObjects(){} // RVA: 0x7AA891220
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA891360
        public void get_Item(){} // RVA: 0x7AA8919B0
        public void set_Item(){} // RVA: 0x7AA891A70
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA891B30
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA891D30
        public void AddOrUpdate(){} // RVA: 0x7AA892160
        public void get_IsEmpty(){} // RVA: 0x7AA892430
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA892560
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA8925D0
        public void get_Keys(){} // RVA: 0x7AA892620
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA892620
        public void get_Values(){} // RVA: 0x7AA892640
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA892640
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA892660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA8926D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA892770
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA811260
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA8927C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8929D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA8115B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA892620
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA892AF0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA892640
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA892C20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA892D30
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA892FC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA893560
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA893CD0
        public void AcquireAllLocks(){} // RVA: 0x7AA893D20
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA893E10
        public void GetValues(){} // RVA: 0x7AA8940D0
        public void OnSerializing(){} // RVA: 0x7AA894390
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA894450
        public void .cctor(){} // RVA: 0x7AA894720
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7AA81DC00
        public void .ctor(){} // RVA: 0x7AA81E320
        public void InitializeFromCollection(){} // RVA: 0x7AA81DF70
        public void TryAdd(){} // RVA: 0x7AA81E6D0
        public void ContainsKey(){} // RVA: 0x7AA81E7D0
        public void TryRemove(){} // RVA: 0x7AA81E8D0
        public void TryRemoveInternal(){} // RVA: 0x7AA81E950
        public void TryGetValue(){} // RVA: 0x7AA81EDC0
        public void TryGetValueInternal(){} // RVA: 0x7AA81EEC0
        public void TryUpdateInternal(){} // RVA: 0x7AA81F010
        public void Clear(){} // RVA: 0x7AA81F4D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA81F780
        public void ToArray(){} // RVA: 0x7AA81F9C0
        public void CopyToPairs(){} // RVA: 0x7AA81FC20
        public void CopyToEntries(){} // RVA: 0x7AA81FD50
        public void CopyToObjects(){} // RVA: 0x7AA81FED0
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA820020
        public void get_Item(){} // RVA: 0x7AA820650
        public void set_Item(){} // RVA: 0x7AA820790
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA820890
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA820AD0
        public void AddOrUpdate(){} // RVA: 0x7AA820F50
        public void get_IsEmpty(){} // RVA: 0x7AA821240
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA821370
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA8213E0
        public void get_Keys(){} // RVA: 0x7AA821470
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA821470
        public void get_Values(){} // RVA: 0x7AA821490
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA821490
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA8214B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA821520
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA821660
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA811260
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA821710
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA821930
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA8115B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA821470
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA821AB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA821490
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA821BD0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA821E40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA8220D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA822690
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA822E00
        public void AcquireAllLocks(){} // RVA: 0x7AA822E50
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA822F40
        public void GetValues(){} // RVA: 0x7AA823200
        public void OnSerializing(){} // RVA: 0x7AA8234C0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA823580
        public void .cctor(){} // RVA: 0x7AA823850
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA8089A0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA8082C0
        public void InitializeFromCollection(){} // RVA: 0x7AA808630
        public void TryAdd(){} // RVA: 0x7AA808D50
        public void ContainsKey(){} // RVA: 0x7AA808E10
        public void TryRemove(){} // RVA: 0x7AA808E40
        public void TryRemoveInternal(){} // RVA: 0x7AA808E80
        public void TryGetValue(){} // RVA: 0x7AA8092F0
        public void TryGetValueInternal(){} // RVA: 0x7AA8093A0
        public void TryUpdateInternal(){} // RVA: 0x7AA8094F0
        public void Clear(){} // RVA: 0x7AA8099B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA809C60
        public void ToArray(){} // RVA: 0x7AA809EA0
        public void CopyToPairs(){} // RVA: 0x7AA80A0B0
        public void CopyToEntries(){} // RVA: 0x7AA80A1D0
        public void CopyToObjects(){} // RVA: 0x7AA80A330
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA80A520
        public void get_Item(){} // RVA: 0x7AA80AB70
        public void set_Item(){} // RVA: 0x7AA80AC20
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA80ACE0
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA80AEE0
        public void AddOrUpdate(){} // RVA: 0x7AA80B2F0
        public void get_IsEmpty(){} // RVA: 0x7AA80B5C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA80B6F0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA80B760
        public void get_Keys(){} // RVA: 0x7AA80B7B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA80B7B0
        public void get_Values(){} // RVA: 0x7AA80B7D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA80B7D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA80B7F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA80B860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA80B900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA80B970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA80BB90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA80B7B0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA80BD90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA80B7D0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA80BEB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA80BFC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA80C1D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA80C790
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA80CF00
        public void AcquireAllLocks(){} // RVA: 0x7AA80CF50
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA80D040
        public void GetValues(){} // RVA: 0x7AA80D300
        public void OnSerializing(){} // RVA: 0x7AA80D5C0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA80D680
        public void .cctor(){} // RVA: 0x7AA80D950
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA84BEE0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA84B8A0
        public void InitializeFromCollection(){} // RVA: 0x7AA84BC10
        public void TryAdd(){} // RVA: 0x7AA84C290
        public void ContainsKey(){} // RVA: 0x7AA84C350
        public void TryRemove(){} // RVA: 0x7AA84C380
        public void TryRemoveInternal(){} // RVA: 0x7AA84C3B0
        public void TryGetValue(){} // RVA: 0x7AA84C810
        public void TryGetValueInternal(){} // RVA: 0x7AA84C8C0
        public void TryUpdateInternal(){} // RVA: 0x7AA84CA10
        public void Clear(){} // RVA: 0x7AA84CEC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA84D170
        public void ToArray(){} // RVA: 0x7AA84D430
        public void CopyToPairs(){} // RVA: 0x7AA84D740
        public void CopyToEntries(){} // RVA: 0x7AA84D7F0
        public void CopyToObjects(){} // RVA: 0x7AA84D9A0
        public void GetEnumerator(){} // RVA: 0x7AA8001A0
        public void TryAddInternal(){} // RVA: 0x7AA84DAD0
        public void get_Item(){} // RVA: 0x7AA84E100
        public void set_Item(){} // RVA: 0x7AA84E1B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA84E270
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA84E470
        public void AddOrUpdate(){} // RVA: 0x7AA84E850
        public void get_IsEmpty(){} // RVA: 0x7AA84EAF0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA84EC20
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA84ED40
        public void get_Keys(){} // RVA: 0x7AA84ED90
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA84ED90
        public void get_Values(){} // RVA: 0x7AA84EDB0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA84EDB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA84EDD0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA84EE50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA84EEE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA8016D0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA84EF30
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA84F140
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA801A20
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA84ED90
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA84F260
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA84EDB0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA84F380
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA84F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA84F780
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA84FDC0
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA850520
        public void AcquireAllLocks(){} // RVA: 0x7AA850570
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA850660
        public void GetValues(){} // RVA: 0x7AA850920
        public void OnSerializing(){} // RVA: 0x7AA850BE0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA850CA0
        public void .cctor(){} // RVA: 0x7AA850F70
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA7FE540
        public void IsValueWriteAtomic(){} // RVA: 0x7AA7FDF00
        public void InitializeFromCollection(){} // RVA: 0x7AA7FE270
        public void TryAdd(){} // RVA: 0x7AA7FE8F0
        public void ContainsKey(){} // RVA: 0x7AA7FE9B0
        public void TryRemove(){} // RVA: 0x7AA7FE9E0
        public void TryRemoveInternal(){} // RVA: 0x7AA7FEA10
        public void TryGetValue(){} // RVA: 0x7AA7FEE80
        public void TryGetValueInternal(){} // RVA: 0x7AA7FEF30
        public void TryUpdateInternal(){} // RVA: 0x7AA7FF080
        public void Clear(){} // RVA: 0x7AA7FF530
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA7FF7E0
        public void ToArray(){} // RVA: 0x7AA7FFAC0
        public void CopyToPairs(){} // RVA: 0x7AA7FFDE0
        public void CopyToEntries(){} // RVA: 0x7AA7FFEB0
        public void CopyToObjects(){} // RVA: 0x7AA800060
        public void GetEnumerator(){} // RVA: 0x7AA8001A0
        public void TryAddInternal(){} // RVA: 0x7AA800240
        public void get_Item(){} // RVA: 0x7AA800870
        public void set_Item(){} // RVA: 0x7AA800920
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA8009E0
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA800BE0
        public void AddOrUpdate(){} // RVA: 0x7AA800FE0
        public void get_IsEmpty(){} // RVA: 0x7AA801290
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA8013C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA8014E0
        public void get_Keys(){} // RVA: 0x7AA801530
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA801530
        public void get_Values(){} // RVA: 0x7AA801550
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA801550
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA801570
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA8015F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA801680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA8016D0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA8016F0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA801900
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA801A20
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA801530
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA801B00
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA801550
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA801C20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA801E10
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA802020
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA8026A0
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA802E00
        public void AcquireAllLocks(){} // RVA: 0x7AA802E50
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA802F40
        public void GetValues(){} // RVA: 0x7AA803200
        public void OnSerializing(){} // RVA: 0x7AA8034C0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA803580
        public void .cctor(){} // RVA: 0x7AA803850
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA813BB0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA8134D0
        public void InitializeFromCollection(){} // RVA: 0x7AA813840
        public void TryAdd(){} // RVA: 0x7AA813F60
        public void ContainsKey(){} // RVA: 0x7AA814020
        public void TryRemove(){} // RVA: 0x7AA80E6E0
        public void TryRemoveInternal(){} // RVA: 0x7AA80E720
        public void TryGetValue(){} // RVA: 0x7AA80EBA0
        public void TryGetValueInternal(){} // RVA: 0x7AA80EC50
        public void TryUpdateInternal(){} // RVA: 0x7AA80EDA0
        public void Clear(){} // RVA: 0x7AA814050
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA814300
        public void ToArray(){} // RVA: 0x7AA814540
        public void CopyToPairs(){} // RVA: 0x7AA80F9B0
        public void CopyToEntries(){} // RVA: 0x7AA80FAD0
        public void CopyToObjects(){} // RVA: 0x7AA80FC20
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA8147A0
        public void get_Item(){} // RVA: 0x7AA814DF0
        public void set_Item(){} // RVA: 0x7AA814EB0
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA814F70
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA815170
        public void AddOrUpdate(){} // RVA: 0x7AA815590
        public void get_IsEmpty(){} // RVA: 0x7AA815860
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA815990
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA811070
        public void get_Keys(){} // RVA: 0x7AA815A00
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA815A00
        public void get_Values(){} // RVA: 0x7AA815A20
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA815A20
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA811100
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA815A40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA811210
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA811260
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA811280
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA815AE0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA8115B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA815A00
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA811690
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA815A20
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA815C00
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA815D10
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA815FA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA816540
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA816CB0
        public void AcquireAllLocks(){} // RVA: 0x7AA816D00
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA816DF0
        public void GetValues(){} // RVA: 0x7AA8170B0
        public void OnSerializing(){} // RVA: 0x7AA817370
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA817430
        public void .cctor(){} // RVA: 0x7AA817700
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA7F8010
        public void GetOrAdd(){} // RVA: 0x7AA7FACA0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA7F7990
        public void InitializeFromCollection(){} // RVA: 0x7AA7F7D00
        public void TryAdd(){} // RVA: 0x7AA7F83C0
        public void ContainsKey(){} // RVA: 0x7AA7F8510
        public void TryRemove(){} // RVA: 0x7AA7F8550
        public void TryRemoveInternal(){} // RVA: 0x7AA7F8590
        public void TryGetValue(){} // RVA: 0x7AA7F8B00
        public void TryGetValueInternal(){} // RVA: 0x7AA7F8C30
        public void TryUpdateInternal(){} // RVA: 0x7AA7F8E10
        public void Clear(){} // RVA: 0x7AA7F9360
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA7F9610
        public void ToArray(){} // RVA: 0x7AA7F9850
        public void CopyToPairs(){} // RVA: 0x7AA7F9AB0
        public void CopyToEntries(){} // RVA: 0x7AA7F9BD0
        public void CopyToObjects(){} // RVA: 0x7AA7F9D20
        public void GetEnumerator(){} // RVA: 0x7AA7F9E90
        public void TryAddInternal(){} // RVA: 0x7AA7F9F30
        public void get_Item(){} // RVA: 0x7AA7FA670
        public void set_Item(){} // RVA: 0x7AA7FA740
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA7FA960
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA7FB0F0
        public void get_IsEmpty(){} // RVA: 0x7AA7FB350
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA7FB480
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA7FB620
        public void get_Keys(){} // RVA: 0x7AA7FB680
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA7FB680
        public void get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA7FB6C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA7FB7A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA7FB840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA7FB890
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA7FB8B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA7FBAD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA7FBC00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA7FB680
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA7FBCE0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA7FBE20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA7FBF40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA7FC280
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA7FC860
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA7FD010
        public void AcquireAllLocks(){} // RVA: 0x7AA7FD060
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA7FD370
        public void GetValues(){} // RVA: 0x7AA7FD640
        public void OnSerializing(){} // RVA: 0x7AA7FD900
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA7FDA20
        public void .cctor(){} // RVA: 0x7AA7FDCF0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA824180
        public void IsValueWriteAtomic(){} // RVA: 0x7AA823A60
        public void InitializeFromCollection(){} // RVA: 0x7AA823DD0
        public void TryAdd(){} // RVA: 0x7AA824530
        public void ContainsKey(){} // RVA: 0x7AA81E7D0
        public void TryRemove(){} // RVA: 0x7AA824630
        public void TryRemoveInternal(){} // RVA: 0x7AA8246B0
        public void TryGetValue(){} // RVA: 0x7AA81EDC0
        public void TryGetValueInternal(){} // RVA: 0x7AA81EEC0
        public void TryUpdateInternal(){} // RVA: 0x7AA824B30
        public void Clear(){} // RVA: 0x7AA824FF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA8252A0
        public void ToArray(){} // RVA: 0x7AA8254E0
        public void CopyToPairs(){} // RVA: 0x7AA81FC20
        public void CopyToEntries(){} // RVA: 0x7AA81FD50
        public void CopyToObjects(){} // RVA: 0x7AA81FED0
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA825740
        public void get_Item(){} // RVA: 0x7AA820650
        public void set_Item(){} // RVA: 0x7AA825D70
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA825E70
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8260B0
        public void AddOrUpdate(){} // RVA: 0x7AA826530
        public void get_IsEmpty(){} // RVA: 0x7AA826820
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA826950
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA8269C0
        public void get_Keys(){} // RVA: 0x7AA826A50
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA826A50
        public void get_Values(){} // RVA: 0x7AA826A70
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA826A70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA826A90
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA826B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA826C40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA811260
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA826CF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA826F10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA8115B0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA826A50
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA827020
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA826A70
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA821BD0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA827140
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA8273D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA827990
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA828100
        public void AcquireAllLocks(){} // RVA: 0x7AA828150
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA828240
        public void GetValues(){} // RVA: 0x7AA828500
        public void OnSerializing(){} // RVA: 0x7AA8287C0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA828880
        public void .cctor(){} // RVA: 0x7AA828B50
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7AA8082C0
        public void .ctor(){} // RVA: 0x7AA8089A0
        public void InitializeFromCollection(){} // RVA: 0x7AA808630
        public void TryAdd(){} // RVA: 0x7AA808D50
        public void ContainsKey(){} // RVA: 0x7AA808E10
        public void TryRemove(){} // RVA: 0x7AA808E40
        public void TryRemoveInternal(){} // RVA: 0x7AA808E80
        public void TryGetValue(){} // RVA: 0x7AA8092F0
        public void TryGetValueInternal(){} // RVA: 0x7AA8093A0
        public void TryUpdateInternal(){} // RVA: 0x7AA8094F0
        public void Clear(){} // RVA: 0x7AA8099B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA809C60
        public void ToArray(){} // RVA: 0x7AA809EA0
        public void CopyToPairs(){} // RVA: 0x7AA80A0B0
        public void CopyToEntries(){} // RVA: 0x7AA80A1D0
        public void CopyToObjects(){} // RVA: 0x7AA80A330
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA80A520
        public void get_Item(){} // RVA: 0x7AA80AB70
        public void set_Item(){} // RVA: 0x7AA80AC20
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA80ACE0
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA80AEE0
        public void AddOrUpdate(){} // RVA: 0x7AA80B2F0
        public void get_IsEmpty(){} // RVA: 0x7AA80B5C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA80B6F0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA80B760
        public void get_Keys(){} // RVA: 0x7AA80B7B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA80B7B0
        public void get_Values(){} // RVA: 0x7AA80B7D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA80B7D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA80B7F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA80B860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA80B900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA80B970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA80BB90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA80B7B0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA80BD90
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA80B7D0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA80BEB0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA80BFC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA80C1D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA80C790
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA80CF00
        public void AcquireAllLocks(){} // RVA: 0x7AA80CF50
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA80D040
        public void GetValues(){} // RVA: 0x7AA80D300
        public void OnSerializing(){} // RVA: 0x7AA80D5C0
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA80D680
        public void .cctor(){} // RVA: 0x7AA80D950
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void .ctor(){} // RVA: 0x7AA834F20
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void .ctor(){} // RVA: 0x7AA834F20
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA834F20
        public void IsValueWriteAtomic(){} // RVA: 0x7AA834890
        public void InitializeFromCollection(){} // RVA: 0x7AA834C00
        public void TryAdd(){} // RVA: 0x7AA8352D0
        public void ContainsKey(){} // RVA: 0x7AA8353D0
        public void TryRemove(){} // RVA: 0x7AA8354D0
        public void TryRemoveInternal(){} // RVA: 0x7AA835550
        public void TryGetValue(){} // RVA: 0x7AA8359D0
        public void TryGetValueInternal(){} // RVA: 0x7AA835AD0
        public void TryUpdateInternal(){} // RVA: 0x7AA835C20
        public void Clear(){} // RVA: 0x7AA8360E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA836390
        public void ToArray(){} // RVA: 0x7AA8365F0
        public void CopyToPairs(){} // RVA: 0x7AA836810
        public void CopyToEntries(){} // RVA: 0x7AA836950
        public void CopyToObjects(){} // RVA: 0x7AA836A70
        public void GetEnumerator(){} // RVA: 0x7AA80A480
        public void TryAddInternal(){} // RVA: 0x7AA836BD0
        public void get_Item(){} // RVA: 0x7AA837220
        public void set_Item(){} // RVA: 0x7AA837370
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA837470
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void GetOrAdd(){} // RVA: 0x7AA8376B0
        public void AddOrUpdate(){} // RVA: 0x7AA837B70
        public void get_IsEmpty(){} // RVA: 0x7AA837E90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA837FC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA838030
        public void get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA8380D0
        public void get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA838110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA838180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA8382D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA80B950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA838380
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA8385A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA80BCB0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA8380D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA8386B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA8380F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA8387E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA838960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA838B80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA839120
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA839890
        public void AcquireAllLocks(){} // RVA: 0x7AA8398E0
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA8399D0
        public void GetValues(){} // RVA: 0x7AA839C90
        public void OnSerializing(){} // RVA: 0x7AA839F50
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA83A010
        public void .cctor(){} // RVA: 0x7AA83A2E0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA7F8010
        public void GetOrAdd(){} // RVA: 0x7AA7FACA0
        public void IsValueWriteAtomic(){} // RVA: 0x7AA7F7990
        public void InitializeFromCollection(){} // RVA: 0x7AA7F7D00
        public void TryAdd(){} // RVA: 0x7AA7F83C0
        public void ContainsKey(){} // RVA: 0x7AA7F8510
        public void TryRemove(){} // RVA: 0x7AA7F8550
        public void TryRemoveInternal(){} // RVA: 0x7AA7F8590
        public void TryGetValue(){} // RVA: 0x7AA7F8B00
        public void TryGetValueInternal(){} // RVA: 0x7AA7F8C30
        public void TryUpdateInternal(){} // RVA: 0x7AA7F8E10
        public void Clear(){} // RVA: 0x7AA7F9360
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7AA7F9610
        public void ToArray(){} // RVA: 0x7AA7F9850
        public void CopyToPairs(){} // RVA: 0x7AA7F9AB0
        public void CopyToEntries(){} // RVA: 0x7AA7F9BD0
        public void CopyToObjects(){} // RVA: 0x7AA7F9D20
        public void GetEnumerator(){} // RVA: 0x7AA7F9E90
        public void TryAddInternal(){} // RVA: 0x7AA7F9F30
        public void get_Item(){} // RVA: 0x7AA7FA670
        public void set_Item(){} // RVA: 0x7AA7FA740
        public void ThrowKeyNotFoundException(){} // RVA: 0x7AA7FA890
        public void ThrowKeyNullException(){} // RVA: 0x7AA7FA910
        public void get_Count(){} // RVA: 0x7AA7FA960
        public void GetCountInternal(){} // RVA: 0x7AA7FAA10
        public void AddOrUpdate(){} // RVA: 0x7AA7FB0F0
        public void get_IsEmpty(){} // RVA: 0x7AA7FB350
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7AA7FB480
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7AA7FB620
        public void get_Keys(){} // RVA: 0x7AA7FB680
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7AA7FB680
        public void get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7AA7FB6C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7AA7FB7A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7AA7FB840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA7FB890
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7AA7FB8B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7AA7FBAD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7AA7FBC00
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7A80D7320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7AA7FB680
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7AA7FBCE0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7AA7FB6A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7AA7FBE20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7AA7FBF40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA7FC280
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void GrowTable(){} // RVA: 0x7AA7FC860
        public void GetBucket(){} // RVA: 0x7AA7FCFE0
        public void GetBucketAndLockNo(){} // RVA: 0x7AA7FCFF0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7AA7FD010
        public void AcquireAllLocks(){} // RVA: 0x7AA7FD060
        public void AcquireLocks(){} // RVA: 0x7AA7FD150
        public void ReleaseLocks(){} // RVA: 0x7AA7FD2B0
        public void GetKeys(){} // RVA: 0x7AA7FD370
        public void GetValues(){} // RVA: 0x7AA7FD640
        public void OnSerializing(){} // RVA: 0x7AA7FD900
        public void OnSerialized(){} // RVA: 0x7AA7FD9C0
        public void OnDeserialized(){} // RVA: 0x7AA7FDA20
        public void .cctor(){} // RVA: 0x7AA7FDCF0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7A8051B10
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7A7E019D0
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
        public void ToArray(){} // RVA: 0x7A7E00680
        public void get_Count(){} // RVA: 0x7A7E00710
        public void GetCount(){} // RVA: 0x7A8051B10
        public void CopyTo(){} // RVA: 0x7A7E1D590
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void SnapForObservation(){} // RVA: 0x7A7E1DB70
        public void GetItemWhenAvailable(){} // RVA: 0x7A8051B10
        public void Enumerate(){} // RVA: 0x7A8051B10
        public void Enqueue(){} // RVA: 0x7A8051B10
        public void EnqueueSlow(){} // RVA: 0x7A8051B10
        public void TryDequeue(){} // RVA: 0x7A7E019D0
        public void TryDequeueSlow(){} // RVA: 0x7A7E019D0
        public void TryPeek(){} // RVA: 0x7A7E03AD0
        public void Clear(){} // RVA: 0x7A7E18770
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89B630
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89B780
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89B820
        public void get_IsEmpty(){} // RVA: 0x7AA89B8C0
        public void ToArray(){} // RVA: 0x7AA89B980
        public void get_Count(){} // RVA: 0x7AA89BDF0
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA89C350
        public void GetEnumerator(){} // RVA: 0x7AA89C810
        public void SnapForObservation(){} // RVA: 0x7AA89C8B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA89CB10
        public void Enumerate(){} // RVA: 0x7AA89CC70
        public void Enqueue(){} // RVA: 0x7AA89CDF0
        public void EnqueueSlow(){} // RVA: 0x7AA89CE80
        public void TryDequeue(){} // RVA: 0x7AA89D320
        public void TryDequeueSlow(){} // RVA: 0x7AA89D3B0
        public void TryPeek(){} // RVA: 0x7AA89D5B0
        public void Clear(){} // RVA: 0x7AA89D680
        public void .ctor(){} // RVA: 0x7AA89B470
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA8AA2A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA8AA460
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA8AA560
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA8AA600
        public void get_IsEmpty(){} // RVA: 0x7AA8AA620
        public void ToArray(){} // RVA: 0x7AA8AA6E0
        public void get_Count(){} // RVA: 0x7AA8AAB50
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8AAEC0
        public void GetEnumerator(){} // RVA: 0x7AA8AB3E0
        public void SnapForObservation(){} // RVA: 0x7AA8AB480
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8AB6E0
        public void Enumerate(){} // RVA: 0x7AA89CC70
        public void Enqueue(){} // RVA: 0x7AA8AB840
        public void EnqueueSlow(){} // RVA: 0x7AA8AB8D0
        public void TryDequeue(){} // RVA: 0x7AA8ABD70
        public void TryDequeueSlow(){} // RVA: 0x7AA8ABE00
        public void TryPeek(){} // RVA: 0x7AA8AC000
        public void Clear(){} // RVA: 0x7AA8AC0D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA8A8000
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA8A81C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA8A82C0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA8A8330
        public void get_IsEmpty(){} // RVA: 0x7AA8A8350
        public void ToArray(){} // RVA: 0x7AA8A8430
        public void get_Count(){} // RVA: 0x7AA8A88E0
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A8C50
        public void GetEnumerator(){} // RVA: 0x7AA8A90E0
        public void SnapForObservation(){} // RVA: 0x7AA8A9180
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A93E0
        public void Enumerate(){} // RVA: 0x7AA8A9580
        public void Enqueue(){} // RVA: 0x7AA8A9710
        public void EnqueueSlow(){} // RVA: 0x7AA8A9810
        public void TryDequeue(){} // RVA: 0x7AA8A9CF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A9D80
        public void TryPeek(){} // RVA: 0x7AA8A9FA0
        public void Clear(){} // RVA: 0x7AA8AA080
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA89D8A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89DA60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89DB60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89DB80
        public void get_IsEmpty(){} // RVA: 0x7AA89DBA0
        public void ToArray(){} // RVA: 0x7AA89DC60
        public void get_Count(){} // RVA: 0x7AA89E060
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA89E3D0
        public void GetEnumerator(){} // RVA: 0x7AA89E800
        public void SnapForObservation(){} // RVA: 0x7AA89E8A0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA89EB00
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA89EDE0
        public void EnqueueSlow(){} // RVA: 0x7AA89EE50
        public void TryDequeue(){} // RVA: 0x7AA89F3F0
        public void TryDequeueSlow(){} // RVA: 0x7AA89F480
        public void TryPeek(){} // RVA: 0x7AA89F680
        public void Clear(){} // RVA: 0x7AA89F740
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA8AC2F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA8AC4B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA8AC5B0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA8AC5D0
        public void get_IsEmpty(){} // RVA: 0x7AA8AC5F0
        public void ToArray(){} // RVA: 0x7AA8AC6B0
        public void get_Count(){} // RVA: 0x7AA8ACB00
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8ACE70
        public void GetEnumerator(){} // RVA: 0x7AA8AD2A0
        public void SnapForObservation(){} // RVA: 0x7AA8AD340
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8AD5A0
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA8AD700
        public void EnqueueSlow(){} // RVA: 0x7AA8AD780
        public void TryDequeue(){} // RVA: 0x7AA8ADC20
        public void TryDequeueSlow(){} // RVA: 0x7AA8ADCB0
        public void TryPeek(){} // RVA: 0x7AA8ADEB0
        public void Clear(){} // RVA: 0x7AA8ADF70
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x7AA8A1280
        public void Enqueue(){} // RVA: 0x7AA8A0D70
        public void .ctor(){} // RVA: 0x7AA89F960
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA89FB20
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA89B730
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA89FC20
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA89FC40
        public void get_IsEmpty(){} // RVA: 0x7AA89FC60
        public void ToArray(){} // RVA: 0x7AA89FD20
        public void get_Count(){} // RVA: 0x7AA8A0170
        public void GetCount(){} // RVA: 0x7AA89C200
        public void CopyTo(){} // RVA: 0x7AA8A04E0
        public void GetEnumerator(){} // RVA: 0x7AA8A0910
        public void SnapForObservation(){} // RVA: 0x7AA8A09B0
        public void GetItemWhenAvailable(){} // RVA: 0x7AA8A0C10
        public void Enumerate(){} // RVA: 0x7AA89EC60
        public void EnqueueSlow(){} // RVA: 0x7AA8A0DF0
        public void TryDequeueSlow(){} // RVA: 0x7AA8A1310
        public void TryPeek(){} // RVA: 0x7AA8A1510
        public void Clear(){} // RVA: 0x7AA8A15D0
    }

    public class ConcurrentStack`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void get_Count(){} // RVA: 0x7A7E00710
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A7E01900
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7A7E00680
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7A7E1D590
        public void Push(){} // RVA: 0x7A8051B10
        public void PushCore(){} // RVA: 0x7A7E18890
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7A8051B10
        public void TryPop(){} // RVA: 0x7A7E019D0
        public void TryPopCore(){} // RVA: 0x7A7E07D80
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7A7E019D0
        public void ToArray(){} // RVA: 0x7A7E00680
        public void ToList(){} // RVA: 0x7A7E00B20
        public void GetEnumerator(){} // RVA: 0x7A7E00B20
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
    }

    public class ConcurrentStack`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_Count(){} // RVA: 0x7AA8AF540
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7A80D7320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7AA7F4E40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7AA8AF560
        public void Push(){} // RVA: 0x7AA8AF640
        public void PushCore(){} // RVA: 0x7AA8AF820
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7AA8AFA00
        public void TryPop(){} // RVA: 0x7AA8AFA20
        public void TryPopCore(){} // RVA: 0x7AA8AFC50
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7AA8B0050
        public void ToArray(){} // RVA: 0x7AA8B0070
        public void ToList(){} // RVA: 0x7AA8B0110
        public void GetEnumerator(){} // RVA: 0x7AA8B02B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AA8B0350
    }

    public class IProducerConsumerCollection`1
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7A8051B10
        public void TryTake(){} // RVA: 0x7A7E019D0
        public void ToArray(){} // RVA: 0x7A7E00680
    }

    public class IProducerConsumerCollection`1
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x7A7E019D0
        public void TryTake(){} // RVA: 0x7A7E019D0
        public void ToArray(){} // RVA: 0x7A7E00680
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18FB0
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7A7E00680
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7A7E18C30
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7A7E18C30
        public void set_KeysNormalized(){} // RVA: 0x7A7E18C30
        public void GetDynamicPartitions(){} // RVA: 0x7A7E00680
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBCF330
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7A81A2210
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7A82FBFC0
        public void set_KeysNormalized(){} // RVA: 0x7A9716BD0
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF3E0
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBCF220
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7A81A2210
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7A82FBFC0
        public void set_KeysNormalized(){} // RVA: 0x7A9716BD0
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF280
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABBCF220
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7A81A2210
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7A82FBFC0
        public void set_KeysNormalized(){} // RVA: 0x7A9716BD0
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF280
    }

    public class Partitioner : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AA55CC40
        public void GetDefaultChunkSize(){} // RVA: 0x7AA55CEA0
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7A7E01900
        public void GetDynamicPartitions(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7A80D7320
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7A80D7320
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7A80D7320
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7A80D7320
        public void GetDynamicPartitions(){} // RVA: 0x7ABBCF230
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18770
        public void Enqueue(){} // RVA: 0x7A8051B10
        public void EnqueueSlow(){} // RVA: 0x7A8051B10
        public void TryDequeue(){} // RVA: 0x7A7E019D0
        public void TryPeek(){} // RVA: 0x7A7E019D0
        public void TryDequeueSlow(){} // RVA: 0x7A8051B10
        public void get_IsEmpty(){} // RVA: 0x7A7E01900
        public void GetEnumerator(){} // RVA: 0x7A7E00680
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7A7E00680
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABE1DBB0
        public void Enqueue(){} // RVA: 0x7ABE1DCD0
        public void EnqueueSlow(){} // RVA: 0x7ABE1DD70
        public void TryDequeue(){} // RVA: 0x7ABE1E070
        public void TryPeek(){} // RVA: 0x7ABE1E190
        public void TryDequeueSlow(){} // RVA: 0x7ABE1E260
        public void get_IsEmpty(){} // RVA: 0x7ABE1E510
        public void GetEnumerator(){} // RVA: 0x7ABE1E570
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ABE1E600
    }

}