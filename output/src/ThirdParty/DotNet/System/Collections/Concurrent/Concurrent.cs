// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 89
// Methods: 3506

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollection`1 : Object
    {
        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x87D280
        public void get_IsCompleted(){} // RVA: 0x87D280
        public void get_Count(){} // RVA: 0x87C130
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894320
        public void Initialize(){} // RVA: 0x89B9B0
        public void Add(){} // RVA: 0xA94080
        public void TryAddWithNoTimeValidation(){} // RVA: 0xA94080
        public void TryTake(){} // RVA: 0xA94080
        public void TryTakeWithNoTimeValidation(){} // RVA: 0xA94080
        public void CancelWaitingConsumers(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894750
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void ValidateMillisecondsTimeout(){} // RVA: 0x895710
        public void CheckDisposed(){} // RVA: 0x894290
    }

    public class BlockingCollection`1 : Object
    {
        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x6251B70
        public void get_IsCompleted(){} // RVA: 0x6251BB0
        public void get_Count(){} // RVA: 0x6251C40
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x6251C80
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void .ctor(){} // RVA: 0x6251EF0
        public void Initialize(){} // RVA: 0x6251FC0
        public void Add(){} // RVA: 0x62522C0
        public void TryAddWithNoTimeValidation(){} // RVA: 0x6252300
        public void TryTake(){} // RVA: 0x62529B0
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x6252AD0
        public void CancelWaitingConsumers(){} // RVA: 0x62530C0
        public void Dispose(){} // RVA: 0x62531A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x62531F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x6253520
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6253590
        public void ValidateMillisecondsTimeout(){} // RVA: 0x62535E0
        public void CheckDisposed(){} // RVA: 0x62536D0
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6888090
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x18F3EB0
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x18F3EB0
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x18F3EB0
        public void .cctor(){} // RVA: 0x68880A0
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6888090
        public void ConcurrentBag_TryTakeSteals(){} // RVA: 0x18F3EB0
        public void ConcurrentBag_TryPeekSteals(){} // RVA: 0x18F3EB0
        public void .cctor(){} // RVA: 0x771CF50
    }

    public class ConcurrentBag`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Add(){} // RVA: 0xA94080
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0xA94080
        public void TryTake(){} // RVA: 0x87D350
        public void GetCurrentThreadWorkStealingQueue(){} // RVA: 0x881D20
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x87C0A0
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x87C0A0
        public void TrySteal(){} // RVA: 0x87F360
        public void TryStealFromTo(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void CopyFromEachQueueToArray(){} // RVA: 0x885970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void ToArray(){} // RVA: 0x87C0A0
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void get_Count(){} // RVA: 0x87C130
        public void get_DangerousCount(){} // RVA: 0x87C130
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void get_GlobalQueuesLock(){} // RVA: 0x87C0A0
        public void FreezeBag(){} // RVA: 0x894320
        public void UnfreezeBag(){} // RVA: 0x894750
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x344DE30
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x344DA90
        public void TryAdd(){} // RVA: 0x344E1E0
        public void ContainsKey(){} // RVA: 0x344E2E0
        public void TryRemove(){} // RVA: 0x344E3E0
        public void TryRemoveInternal(){} // RVA: 0x344E460
        public void TryGetValue(){} // RVA: 0x344E8E0
        public void TryGetValueInternal(){} // RVA: 0x344E9E0
        public void TryUpdateInternal(){} // RVA: 0x344EB30
        public void Clear(){} // RVA: 0x344EFF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x344F2A0
        public void ToArray(){} // RVA: 0x344F4E0
        public void CopyToPairs(){} // RVA: 0x344F740
        public void CopyToEntries(){} // RVA: 0x344F870
        public void CopyToObjects(){} // RVA: 0x344F9F0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x344FB40
        public void get_Item(){} // RVA: 0x3450170
        public void set_Item(){} // RVA: 0x34502C0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x34503C0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x3450600
        public void AddOrUpdate(){} // RVA: 0x3450A90
        public void get_IsEmpty(){} // RVA: 0x3450D90
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3450EC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3450F30
        public void get_Keys(){} // RVA: 0x3450FD0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x3450FD0
        public void get_Values(){} // RVA: 0x3450FF0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3450FF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3451010
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3451080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x34511D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3436EE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3451280
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34514A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3437230
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3450FD0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3451620
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3450FF0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3451750
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3451900
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3451B90
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x3452160
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x34528D0
        public void AcquireAllLocks(){} // RVA: 0x3452920
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3452A10
        public void GetValues(){} // RVA: 0x3452CD0
        public void OnSerializing(){} // RVA: 0x3452F90
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3453050
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x87D2E0
        public void .ctor(){} // RVA: 0xA94080
        public void InitializeFromCollection(){} // RVA: 0x894320
        public void TryAdd(){} // RVA: 0xA94080
        public void ContainsKey(){} // RVA: 0xA94080
        public void TryRemove(){} // RVA: 0xA94080
        public void TryRemoveInternal(){} // RVA: 0xA94080
        public void TryGetValue(){} // RVA: 0xA94080
        public void TryGetValueInternal(){} // RVA: 0xA94080
        public void TryUpdateInternal(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x899290
        public void ToArray(){} // RVA: 0x87C0A0
        public void CopyToPairs(){} // RVA: 0x899290
        public void CopyToEntries(){} // RVA: 0x899290
        public void CopyToObjects(){} // RVA: 0x899290
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void TryAddInternal(){} // RVA: 0xA94080
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void ThrowKeyNotFoundException(){} // RVA: 0x894350
        public void ThrowKeyNullException(){} // RVA: 0x8942F0
        public void get_Count(){} // RVA: 0x87C130
        public void GetCountInternal(){} // RVA: 0x87C130
        public void GetOrAdd(){} // RVA: 0xA94080
        public void AddOrUpdate(){} // RVA: 0xA94080
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0xA94080
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0xA94080
        public void get_Keys(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x87C0A0
        public void get_Values(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x87C0A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0xA94080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0xA94080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x87D280
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0xA94080
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x8943B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x87D350
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x87D280
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x87D280
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x894320
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x87C0A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x87C540
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x8943B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void GrowTable(){} // RVA: 0x894320
        public void GetBucket(){} // RVA: 0x8833F0
        public void GetBucketAndLockNo(){} // RVA: 0xA94080
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x87CFE0
        public void AcquireAllLocks(){} // RVA: 0x894320
        public void AcquireLocks(){} // RVA: 0x896030
        public void ReleaseLocks(){} // RVA: 0x8965E0
        public void GetKeys(){} // RVA: 0x87C0A0
        public void GetValues(){} // RVA: 0x87C0A0
        public void OnSerializing(){} // RVA: 0x894320
        public void OnSerialized(){} // RVA: 0x894320
        public void OnDeserialized(){} // RVA: 0x894320
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x346B1A0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x346AE90
        public void TryAdd(){} // RVA: 0x346B550
        public void ContainsKey(){} // RVA: 0x341EEF0
        public void TryRemove(){} // RVA: 0x341EF30
        public void TryRemoveInternal(){} // RVA: 0x341EF70
        public void TryGetValue(){} // RVA: 0x341F4E0
        public void TryGetValueInternal(){} // RVA: 0x341F610
        public void TryUpdateInternal(){} // RVA: 0x341F7F0
        public void Clear(){} // RVA: 0x346B6A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x346B950
        public void ToArray(){} // RVA: 0x346BB90
        public void CopyToPairs(){} // RVA: 0x346BDF0
        public void CopyToEntries(){} // RVA: 0x34205B0
        public void CopyToObjects(){} // RVA: 0x3420700
        public void GetEnumerator(){} // RVA: 0x3420870
        public void TryAddInternal(){} // RVA: 0x346BF30
        public void get_Item(){} // RVA: 0x3421050
        public void set_Item(){} // RVA: 0x346C600
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x346C750
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x346C9F0
        public void AddOrUpdate(){} // RVA: 0x346CE40
        public void get_IsEmpty(){} // RVA: 0x346D0A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x346D1D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3422000
        public void get_Keys(){} // RVA: 0x346D370
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x346D370
        public void get_Values(){} // RVA: 0x346D390
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x346D390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x34220A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3422180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3422220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3422270
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3422290
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34224B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34225E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x346D370
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34226C0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x346D390
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3422800
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x346D3B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x346D5D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x346DBB0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x346E330
        public void AcquireAllLocks(){} // RVA: 0x346E380
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x346E470
        public void GetValues(){} // RVA: 0x346E740
        public void OnSerializing(){} // RVA: 0x346EA00
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x346EAC0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x346B1A0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x346AE90
        public void TryAdd(){} // RVA: 0x346B550
        public void ContainsKey(){} // RVA: 0x341EEF0
        public void TryRemove(){} // RVA: 0x341EF30
        public void TryRemoveInternal(){} // RVA: 0x341EF70
        public void TryGetValue(){} // RVA: 0x341F4E0
        public void TryGetValueInternal(){} // RVA: 0x341F610
        public void TryUpdateInternal(){} // RVA: 0x341F7F0
        public void Clear(){} // RVA: 0x346B6A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x346B950
        public void ToArray(){} // RVA: 0x346BB90
        public void CopyToPairs(){} // RVA: 0x346BDF0
        public void CopyToEntries(){} // RVA: 0x34205B0
        public void CopyToObjects(){} // RVA: 0x3420700
        public void GetEnumerator(){} // RVA: 0x3420870
        public void TryAddInternal(){} // RVA: 0x346BF30
        public void get_Item(){} // RVA: 0x3421050
        public void set_Item(){} // RVA: 0x346C600
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x346C750
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x346C9F0
        public void AddOrUpdate(){} // RVA: 0x346CE40
        public void get_IsEmpty(){} // RVA: 0x346D0A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x346D1D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3422000
        public void get_Keys(){} // RVA: 0x346D370
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x346D370
        public void get_Values(){} // RVA: 0x346D390
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x346D390
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x34220A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3422180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3422220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3422270
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3422290
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34224B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34225E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x346D370
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34226C0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x346D390
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3422800
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x346D3B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x346D5D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x346DBB0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x346E330
        public void AcquireAllLocks(){} // RVA: 0x346E380
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x346E470
        public void GetValues(){} // RVA: 0x346E740
        public void OnSerializing(){} // RVA: 0x346EA00
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x346EAC0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x345EA70
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x345E6E0
        public void TryAdd(){} // RVA: 0x345EE20
        public void ContainsKey(){} // RVA: 0x345EF90
        public void TryRemove(){} // RVA: 0x345EFE0
        public void TryRemoveInternal(){} // RVA: 0x345F030
        public void TryGetValue(){} // RVA: 0x345F550
        public void TryGetValueInternal(){} // RVA: 0x345F690
        public void TryUpdateInternal(){} // RVA: 0x345F820
        public void Clear(){} // RVA: 0x345FD50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3460000
        public void ToArray(){} // RVA: 0x3460310
        public void CopyToPairs(){} // RVA: 0x3460570
        public void CopyToEntries(){} // RVA: 0x3460680
        public void CopyToObjects(){} // RVA: 0x34607F0
        public void GetEnumerator(){} // RVA: 0x3460960
        public void TryAddInternal(){} // RVA: 0x3460A00
        public void get_Item(){} // RVA: 0x34610B0
        public void set_Item(){} // RVA: 0x3461190
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x3461300
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x34615D0
        public void AddOrUpdate(){} // RVA: 0x3461B20
        public void get_IsEmpty(){} // RVA: 0x3461EC0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3461FF0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x34621B0
        public void get_Keys(){} // RVA: 0x3462220
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x3462220
        public void get_Values(){} // RVA: 0x3462240
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3462240
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3462260
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x34622E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3462390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34623F0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3462410
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3462640
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3462780
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3462220
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3462860
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3462240
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x34629A0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3462AD0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3462D00
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x34632E0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x3463A80
        public void AcquireAllLocks(){} // RVA: 0x3463AD0
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3463BC0
        public void GetValues(){} // RVA: 0x3463E90
        public void OnSerializing(){} // RVA: 0x3464150
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3464210
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x2D4D6E0
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryRemove(){} // RVA: 0x3459710
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x341E9F0
        public void GetOrAdd(){} // RVA: 0x3421680
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x341E6E0
        public void TryAdd(){} // RVA: 0x341EDA0
        public void ContainsKey(){} // RVA: 0x341EEF0
        public void TryRemove(){} // RVA: 0x341EF30
        public void TryRemoveInternal(){} // RVA: 0x341EF70
        public void TryGetValue(){} // RVA: 0x341F4E0
        public void TryGetValueInternal(){} // RVA: 0x341F610
        public void TryUpdateInternal(){} // RVA: 0x341F7F0
        public void Clear(){} // RVA: 0x341FD40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x341FFF0
        public void ToArray(){} // RVA: 0x3420230
        public void CopyToPairs(){} // RVA: 0x3420490
        public void CopyToEntries(){} // RVA: 0x34205B0
        public void CopyToObjects(){} // RVA: 0x3420700
        public void GetEnumerator(){} // RVA: 0x3420870
        public void TryAddInternal(){} // RVA: 0x3420910
        public void get_Item(){} // RVA: 0x3421050
        public void set_Item(){} // RVA: 0x3421120
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x3421340
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x3421AD0
        public void get_IsEmpty(){} // RVA: 0x3421D30
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3421E60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3422000
        public void get_Keys(){} // RVA: 0x3422060
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x3422060
        public void get_Values(){} // RVA: 0x3422080
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3422080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x34220A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3422180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3422220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3422270
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3422290
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34224B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34225E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3422060
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34226C0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3422080
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3422800
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3422920
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3422C60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x3423240
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x34239F0
        public void AcquireAllLocks(){} // RVA: 0x3423A40
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3423D50
        public void GetValues(){} // RVA: 0x3424020
        public void OnSerializing(){} // RVA: 0x34242E0
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3424400
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3488AB0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3488740
        public void TryAdd(){} // RVA: 0x3488E60
        public void ContainsKey(){} // RVA: 0x3488F20
        public void TryRemove(){} // RVA: 0x3488F50
        public void TryRemoveInternal(){} // RVA: 0x3488F90
        public void TryGetValue(){} // RVA: 0x3489430
        public void TryGetValueInternal(){} // RVA: 0x34894E0
        public void TryUpdateInternal(){} // RVA: 0x3489630
        public void Clear(){} // RVA: 0x3489B00
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3489DB0
        public void ToArray(){} // RVA: 0x3489FF0
        public void CopyToPairs(){} // RVA: 0x348A250
        public void CopyToEntries(){} // RVA: 0x3435750
        public void CopyToObjects(){} // RVA: 0x348A370
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x348A4B0
        public void get_Item(){} // RVA: 0x348AB00
        public void set_Item(){} // RVA: 0x348ABC0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x348AC80
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x348AE80
        public void AddOrUpdate(){} // RVA: 0x348B2B0
        public void get_IsEmpty(){} // RVA: 0x348B580
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x348B6B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x348B720
        public void get_Keys(){} // RVA: 0x348B770
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x348B770
        public void get_Values(){} // RVA: 0x348B790
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x348B790
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x348B7B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x348B820
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x348B8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3436EE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x348B910
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x348BB20
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3437230
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x348B770
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x348BC40
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x348B790
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x348BD70
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x348BE80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x348C110
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x348C6B0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x348CE20
        public void AcquireAllLocks(){} // RVA: 0x348CE70
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x348CF60
        public void GetValues(){} // RVA: 0x348D220
        public void OnSerializing(){} // RVA: 0x348D4E0
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x348D5A0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x342E9E0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x342E670
        public void TryAdd(){} // RVA: 0x342ED90
        public void ContainsKey(){} // RVA: 0x342EE50
        public void TryRemove(){} // RVA: 0x342EE80
        public void TryRemoveInternal(){} // RVA: 0x342EEC0
        public void TryGetValue(){} // RVA: 0x342F330
        public void TryGetValueInternal(){} // RVA: 0x342F3E0
        public void TryUpdateInternal(){} // RVA: 0x342F530
        public void Clear(){} // RVA: 0x342F9F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x342FCA0
        public void ToArray(){} // RVA: 0x342FEE0
        public void CopyToPairs(){} // RVA: 0x34300F0
        public void CopyToEntries(){} // RVA: 0x3430210
        public void CopyToObjects(){} // RVA: 0x3430370
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x3430560
        public void get_Item(){} // RVA: 0x3430BB0
        public void set_Item(){} // RVA: 0x3430C60
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x3430D20
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x3430F20
        public void AddOrUpdate(){} // RVA: 0x3431330
        public void get_IsEmpty(){} // RVA: 0x3431600
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3431730
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x34317A0
        public void get_Keys(){} // RVA: 0x34317F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x34317F0
        public void get_Values(){} // RVA: 0x3431810
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3431810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3431830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x34318A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3431940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x34319B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3431BD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x34317F0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3431DD0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3431810
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3431EF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3432000
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3432210
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x34327D0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x3432F40
        public void AcquireAllLocks(){} // RVA: 0x3432F90
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3433080
        public void GetValues(){} // RVA: 0x3433340
        public void OnSerializing(){} // RVA: 0x3433600
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x34336C0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x346F220
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x346EF50
        public void TryAdd(){} // RVA: 0x346F5D0
        public void ContainsKey(){} // RVA: 0x346F690
        public void TryRemove(){} // RVA: 0x346F6C0
        public void TryRemoveInternal(){} // RVA: 0x346F6F0
        public void TryGetValue(){} // RVA: 0x346FB50
        public void TryGetValueInternal(){} // RVA: 0x346FC00
        public void TryUpdateInternal(){} // RVA: 0x346FD50
        public void Clear(){} // RVA: 0x3470200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x34704B0
        public void ToArray(){} // RVA: 0x3470770
        public void CopyToPairs(){} // RVA: 0x3470A80
        public void CopyToEntries(){} // RVA: 0x3470B30
        public void CopyToObjects(){} // RVA: 0x3470CE0
        public void GetEnumerator(){} // RVA: 0x3426960
        public void TryAddInternal(){} // RVA: 0x3470E10
        public void get_Item(){} // RVA: 0x3471440
        public void set_Item(){} // RVA: 0x34714F0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x34715B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x34717B0
        public void AddOrUpdate(){} // RVA: 0x3471B90
        public void get_IsEmpty(){} // RVA: 0x3471E30
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3471F60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3472080
        public void get_Keys(){} // RVA: 0x34720D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x34720D0
        public void get_Values(){} // RVA: 0x34720F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x34720F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3472110
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3472190
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3472220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3427E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3472270
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3472480
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34281E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x34720D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34725A0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x34720F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x34726C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x34728B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3472AC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x3473100
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x3473860
        public void AcquireAllLocks(){} // RVA: 0x34738B0
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x34739A0
        public void GetValues(){} // RVA: 0x3473C60
        public void OnSerializing(){} // RVA: 0x3473F20
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3473FE0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3424D00
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3424A30
        public void TryAdd(){} // RVA: 0x34250B0
        public void ContainsKey(){} // RVA: 0x3425170
        public void TryRemove(){} // RVA: 0x34251A0
        public void TryRemoveInternal(){} // RVA: 0x34251D0
        public void TryGetValue(){} // RVA: 0x3425640
        public void TryGetValueInternal(){} // RVA: 0x34256F0
        public void TryUpdateInternal(){} // RVA: 0x3425840
        public void Clear(){} // RVA: 0x3425CF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3425FA0
        public void ToArray(){} // RVA: 0x3426280
        public void CopyToPairs(){} // RVA: 0x34265A0
        public void CopyToEntries(){} // RVA: 0x3426670
        public void CopyToObjects(){} // RVA: 0x3426820
        public void GetEnumerator(){} // RVA: 0x3426960
        public void TryAddInternal(){} // RVA: 0x3426A00
        public void get_Item(){} // RVA: 0x3427030
        public void set_Item(){} // RVA: 0x34270E0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x34271A0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x34273A0
        public void AddOrUpdate(){} // RVA: 0x34277A0
        public void get_IsEmpty(){} // RVA: 0x3427A50
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3427B80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3427CA0
        public void get_Keys(){} // RVA: 0x3427CF0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x3427CF0
        public void get_Values(){} // RVA: 0x3427D10
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3427D10
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3427D30
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3427DB0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3427E40
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3427E90
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3427EB0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34280C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34281E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3427CF0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34282C0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3427D10
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x34283E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x34285D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x34287E0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x3428E60
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x34295C0
        public void AcquireAllLocks(){} // RVA: 0x3429610
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3429700
        public void GetValues(){} // RVA: 0x34299C0
        public void OnSerializing(){} // RVA: 0x3429C80
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3429D40
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void .ctor(){} // RVA: 0x342E9E0
        public void InitializeFromCollection(){} // RVA: 0x342E670
        public void TryAdd(){} // RVA: 0x342ED90
        public void ContainsKey(){} // RVA: 0x342EE50
        public void TryRemove(){} // RVA: 0x342EE80
        public void TryRemoveInternal(){} // RVA: 0x342EEC0
        public void TryGetValue(){} // RVA: 0x342F330
        public void TryGetValueInternal(){} // RVA: 0x342F3E0
        public void TryUpdateInternal(){} // RVA: 0x342F530
        public void Clear(){} // RVA: 0x342F9F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x342FCA0
        public void ToArray(){} // RVA: 0x342FEE0
        public void CopyToPairs(){} // RVA: 0x34300F0
        public void CopyToEntries(){} // RVA: 0x3430210
        public void CopyToObjects(){} // RVA: 0x3430370
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x3430560
        public void get_Item(){} // RVA: 0x3430BB0
        public void set_Item(){} // RVA: 0x3430C60
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x3430D20
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x3430F20
        public void AddOrUpdate(){} // RVA: 0x3431330
        public void get_IsEmpty(){} // RVA: 0x3431600
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3431730
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x34317A0
        public void get_Keys(){} // RVA: 0x34317F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x34317F0
        public void get_Values(){} // RVA: 0x3431810
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3431810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3431830
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x34318A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3431940
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x34319B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3431BD0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x34317F0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3431DD0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3431810
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3431EF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3432000
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3432210
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x34327D0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x3432F40
        public void AcquireAllLocks(){} // RVA: 0x3432F90
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3433080
        public void GetValues(){} // RVA: 0x3433340
        public void OnSerializing(){} // RVA: 0x3433600
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x34336C0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3439470
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3439100
        public void TryAdd(){} // RVA: 0x3439820
        public void ContainsKey(){} // RVA: 0x34398E0
        public void TryRemove(){} // RVA: 0x3434360
        public void TryRemoveInternal(){} // RVA: 0x34343A0
        public void TryGetValue(){} // RVA: 0x3434820
        public void TryGetValueInternal(){} // RVA: 0x34348D0
        public void TryUpdateInternal(){} // RVA: 0x3434A20
        public void Clear(){} // RVA: 0x3439910
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x3439BC0
        public void ToArray(){} // RVA: 0x3439E00
        public void CopyToPairs(){} // RVA: 0x3435630
        public void CopyToEntries(){} // RVA: 0x3435750
        public void CopyToObjects(){} // RVA: 0x34358A0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x343A060
        public void get_Item(){} // RVA: 0x343A6B0
        public void set_Item(){} // RVA: 0x343A770
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x343A830
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x343AA30
        public void AddOrUpdate(){} // RVA: 0x343AE50
        public void get_IsEmpty(){} // RVA: 0x343B120
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x343B250
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3436CF0
        public void get_Keys(){} // RVA: 0x343B2C0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x343B2C0
        public void get_Values(){} // RVA: 0x343B2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x343B2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x3436D80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x343B300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3436E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3436EE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3436F00
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x343B3A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3437230
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x343B2C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3437310
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x343B2E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x343B4C0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x343B5D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x343B860
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x343BE00
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x343C570
        public void AcquireAllLocks(){} // RVA: 0x343C5C0
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x343C6B0
        public void GetValues(){} // RVA: 0x343C970
        public void OnSerializing(){} // RVA: 0x343CC30
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x343CCF0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x3459510
        public void .ctor(){} // RVA: 0x3459160
        public void get_Keys(){} // RVA: 0x345C310
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3448F00
        public void get_Count(){} // RVA: 0x344ABF0
        public void get_IsEmpty(){} // RVA: 0x344B5A0
        public void ContainsKey(){} // RVA: 0x3443910
        public void TryAdd(){} // RVA: 0x34492B0
        public void TryRemove(){} // RVA: 0x34493B0
        public void Clear(){} // RVA: 0x3449D70
        public void get_Keys(){} // RVA: 0x344B7D0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3448B50
        public void TryRemoveInternal(){} // RVA: 0x3449430
        public void TryGetValue(){} // RVA: 0x3443F00
        public void TryGetValueInternal(){} // RVA: 0x3444000
        public void TryUpdateInternal(){} // RVA: 0x34498B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x344A020
        public void ToArray(){} // RVA: 0x344A260
        public void CopyToPairs(){} // RVA: 0x3444D60
        public void CopyToEntries(){} // RVA: 0x3444E90
        public void CopyToObjects(){} // RVA: 0x3445010
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x344A4C0
        public void get_Item(){} // RVA: 0x3445790
        public void set_Item(){} // RVA: 0x344AAF0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x344AE30
        public void AddOrUpdate(){} // RVA: 0x344B2B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x344B6D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x344B740
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x344B7D0
        public void get_Values(){} // RVA: 0x344B7F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x344B7F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x344B810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x344B880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x344B9C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3436EE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x344BA70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x344BC90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3437230
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x344B7D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x344BDA0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x344B7F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3446D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x344BEC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x344C150
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x344C710
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x344CE80
        public void AcquireAllLocks(){} // RVA: 0x344CED0
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x344CFC0
        public void GetValues(){} // RVA: 0x344D280
        public void OnSerializing(){} // RVA: 0x344D540
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x344D600
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void TryGetValue(){} // RVA: 0x3459C10
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x341E9F0
        public void GetOrAdd(){} // RVA: 0x3421680
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x341E6E0
        public void TryAdd(){} // RVA: 0x341EDA0
        public void ContainsKey(){} // RVA: 0x341EEF0
        public void TryRemove(){} // RVA: 0x341EF30
        public void TryRemoveInternal(){} // RVA: 0x341EF70
        public void TryGetValue(){} // RVA: 0x341F4E0
        public void TryGetValueInternal(){} // RVA: 0x341F610
        public void TryUpdateInternal(){} // RVA: 0x341F7F0
        public void Clear(){} // RVA: 0x341FD40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x341FFF0
        public void ToArray(){} // RVA: 0x3420230
        public void CopyToPairs(){} // RVA: 0x3420490
        public void CopyToEntries(){} // RVA: 0x34205B0
        public void CopyToObjects(){} // RVA: 0x3420700
        public void GetEnumerator(){} // RVA: 0x3420870
        public void TryAddInternal(){} // RVA: 0x3420910
        public void get_Item(){} // RVA: 0x3421050
        public void set_Item(){} // RVA: 0x3421120
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x3421340
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x3421AD0
        public void get_IsEmpty(){} // RVA: 0x3421D30
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3421E60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3422000
        public void get_Keys(){} // RVA: 0x3422060
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x3422060
        public void get_Values(){} // RVA: 0x3422080
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3422080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x34220A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3422180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3422220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3422270
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3422290
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34224B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34225E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3422060
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34226C0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3422080
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3422800
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3422920
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3422C60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x3423240
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x34239F0
        public void AcquireAllLocks(){} // RVA: 0x3423A40
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3423D50
        public void GetValues(){} // RVA: 0x3424020
        public void OnSerializing(){} // RVA: 0x34242E0
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3424400
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x341E9F0
        public void GetOrAdd(){} // RVA: 0x3421680
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x341E6E0
        public void TryAdd(){} // RVA: 0x341EDA0
        public void ContainsKey(){} // RVA: 0x341EEF0
        public void TryRemove(){} // RVA: 0x341EF30
        public void TryRemoveInternal(){} // RVA: 0x341EF70
        public void TryGetValue(){} // RVA: 0x341F4E0
        public void TryGetValueInternal(){} // RVA: 0x341F610
        public void TryUpdateInternal(){} // RVA: 0x341F7F0
        public void Clear(){} // RVA: 0x341FD40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x341FFF0
        public void ToArray(){} // RVA: 0x3420230
        public void CopyToPairs(){} // RVA: 0x3420490
        public void CopyToEntries(){} // RVA: 0x34205B0
        public void CopyToObjects(){} // RVA: 0x3420700
        public void GetEnumerator(){} // RVA: 0x3420870
        public void TryAddInternal(){} // RVA: 0x3420910
        public void get_Item(){} // RVA: 0x3421050
        public void set_Item(){} // RVA: 0x3421120
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x3421340
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void AddOrUpdate(){} // RVA: 0x3421AD0
        public void get_IsEmpty(){} // RVA: 0x3421D30
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x3421E60
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3422000
        public void get_Keys(){} // RVA: 0x3422060
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x3422060
        public void get_Values(){} // RVA: 0x3422080
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x3422080
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x34220A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3422180
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x3422220
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3422270
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3422290
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x34224B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x34225E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x3422060
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x34226C0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x3422080
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3422800
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3422920
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3422C60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x3423240
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x34239F0
        public void AcquireAllLocks(){} // RVA: 0x3423A40
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3423D50
        public void GetValues(){} // RVA: 0x3424020
        public void OnSerializing(){} // RVA: 0x34242E0
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x3424400
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3448F00
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3448B50
        public void TryAdd(){} // RVA: 0x34492B0
        public void ContainsKey(){} // RVA: 0x3443910
        public void TryRemove(){} // RVA: 0x34493B0
        public void TryRemoveInternal(){} // RVA: 0x3449430
        public void TryGetValue(){} // RVA: 0x3443F00
        public void TryGetValueInternal(){} // RVA: 0x3444000
        public void TryUpdateInternal(){} // RVA: 0x34498B0
        public void Clear(){} // RVA: 0x3449D70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x344A020
        public void ToArray(){} // RVA: 0x344A260
        public void CopyToPairs(){} // RVA: 0x3444D60
        public void CopyToEntries(){} // RVA: 0x3444E90
        public void CopyToObjects(){} // RVA: 0x3445010
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x344A4C0
        public void get_Item(){} // RVA: 0x3445790
        public void set_Item(){} // RVA: 0x344AAF0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x344ABF0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x344AE30
        public void AddOrUpdate(){} // RVA: 0x344B2B0
        public void get_IsEmpty(){} // RVA: 0x344B5A0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x344B6D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x344B740
        public void get_Keys(){} // RVA: 0x344B7D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x344B7D0
        public void get_Values(){} // RVA: 0x344B7F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x344B7F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x344B810
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x344B880
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x344B9C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3436EE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x344BA70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x344BC90
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3437230
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x344B7D0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x344BDA0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x344B7F0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3446D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x344BEC0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x344C150
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x344C710
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x344CE80
        public void AcquireAllLocks(){} // RVA: 0x344CED0
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x344CFC0
        public void GetValues(){} // RVA: 0x344D280
        public void OnSerializing(){} // RVA: 0x344D540
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x344D600
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void .ctor(){} // RVA: 0x3459160
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void .ctor(){} // RVA: 0x3443460
        public void InitializeFromCollection(){} // RVA: 0x34430B0
        public void TryAdd(){} // RVA: 0x3443810
        public void ContainsKey(){} // RVA: 0x3443910
        public void TryRemove(){} // RVA: 0x3443A10
        public void TryRemoveInternal(){} // RVA: 0x3443A90
        public void TryGetValue(){} // RVA: 0x3443F00
        public void TryGetValueInternal(){} // RVA: 0x3444000
        public void TryUpdateInternal(){} // RVA: 0x3444150
        public void Clear(){} // RVA: 0x3444610
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x34448C0
        public void ToArray(){} // RVA: 0x3444B00
        public void CopyToPairs(){} // RVA: 0x3444D60
        public void CopyToEntries(){} // RVA: 0x3444E90
        public void CopyToObjects(){} // RVA: 0x3445010
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x3445160
        public void get_Item(){} // RVA: 0x3445790
        public void set_Item(){} // RVA: 0x34458D0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x34459D0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x3445C10
        public void AddOrUpdate(){} // RVA: 0x3446090
        public void get_IsEmpty(){} // RVA: 0x3446380
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x34464B0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x3446520
        public void get_Keys(){} // RVA: 0x34465B0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x34465B0
        public void get_Values(){} // RVA: 0x34465D0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x34465D0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x34465F0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x3446660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x34467A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3436EE0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x3446850
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x3446A70
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3437230
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x34465B0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x3446BF0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x34465D0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x3446D10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x3446F80
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3447210
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x34477D0
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x3447F40
        public void AcquireAllLocks(){} // RVA: 0x3447F90
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x3448080
        public void GetValues(){} // RVA: 0x3448340
        public void OnSerializing(){} // RVA: 0x3448600
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x34486C0
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void .ctor(){} // RVA: 0x3459160
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentDictionary`2 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3459160
        public void IsValueWriteAtomic(){} // RVA: 0x341E3E0
        public void InitializeFromCollection(){} // RVA: 0x3458E40
        public void TryAdd(){} // RVA: 0x3459510
        public void ContainsKey(){} // RVA: 0x3459610
        public void TryRemove(){} // RVA: 0x3459710
        public void TryRemoveInternal(){} // RVA: 0x3459790
        public void TryGetValue(){} // RVA: 0x3459C10
        public void TryGetValueInternal(){} // RVA: 0x3459D10
        public void TryUpdateInternal(){} // RVA: 0x3459E60
        public void Clear(){} // RVA: 0x345A320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x345A5D0
        public void ToArray(){} // RVA: 0x345A830
        public void CopyToPairs(){} // RVA: 0x345AA50
        public void CopyToEntries(){} // RVA: 0x345AB90
        public void CopyToObjects(){} // RVA: 0x345ACB0
        public void GetEnumerator(){} // RVA: 0x34304C0
        public void TryAddInternal(){} // RVA: 0x345AE10
        public void get_Item(){} // RVA: 0x345B460
        public void set_Item(){} // RVA: 0x345B5B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x3421270
        public void ThrowKeyNullException(){} // RVA: 0x34212F0
        public void get_Count(){} // RVA: 0x345B6B0
        public void GetCountInternal(){} // RVA: 0x34213F0
        public void GetOrAdd(){} // RVA: 0x345B8F0
        public void AddOrUpdate(){} // RVA: 0x345BDB0
        public void get_IsEmpty(){} // RVA: 0x345C0D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x345C200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x345C270
        public void get_Keys(){} // RVA: 0x345C310
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x345C310
        public void get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x345C330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x345C350
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x345C3C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x345C510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3431990
        public void System.Collections.IDictionary.Add(){} // RVA: 0x345C5C0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x345C7E0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x3431CF0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x345C310
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x345C8F0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x345C330
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x345CA20
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x345CBA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x345CDC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void GrowTable(){} // RVA: 0x345D360
        public void GetBucket(){} // RVA: 0x34239C0
        public void GetBucketAndLockNo(){} // RVA: 0x34239D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x345DAD0
        public void AcquireAllLocks(){} // RVA: 0x345DB20
        public void AcquireLocks(){} // RVA: 0x3423B30
        public void ReleaseLocks(){} // RVA: 0x3423C90
        public void GetKeys(){} // RVA: 0x345DC10
        public void GetValues(){} // RVA: 0x345DED0
        public void OnSerializing(){} // RVA: 0x345E190
        public void OnSerialized(){} // RVA: 0x34243A0
        public void OnDeserialized(){} // RVA: 0x345E250
        public void .cctor(){} // RVA: 0x34246D0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0xA94080
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x87D350
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void ToArray(){} // RVA: 0x87C0A0
        public void get_Count(){} // RVA: 0x87C130
        public void GetCount(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x899290
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void SnapForObservation(){} // RVA: 0x899870
        public void GetItemWhenAvailable(){} // RVA: 0xA94080
        public void Enumerate(){} // RVA: 0xA94080
        public void Enqueue(){} // RVA: 0xA94080
        public void EnqueueSlow(){} // RVA: 0xA94080
        public void TryDequeue(){} // RVA: 0x87D350
        public void TryDequeueSlow(){} // RVA: 0x87D350
        public void TryPeek(){} // RVA: 0x87F360
        public void Clear(){} // RVA: 0x894290
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34A31E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x34A33A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x34A34A0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x34A3540
        public void get_IsEmpty(){} // RVA: 0x34A3560
        public void ToArray(){} // RVA: 0x34A3620
        public void get_Count(){} // RVA: 0x34A3A90
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x34A3E00
        public void GetEnumerator(){} // RVA: 0x34A4320
        public void SnapForObservation(){} // RVA: 0x34A43C0
        public void GetItemWhenAvailable(){} // RVA: 0x34A4620
        public void Enumerate(){} // RVA: 0x3495BB0
        public void Enqueue(){} // RVA: 0x34A4780
        public void EnqueueSlow(){} // RVA: 0x34A4810
        public void TryDequeue(){} // RVA: 0x34A4CB0
        public void TryDequeueSlow(){} // RVA: 0x34A4D40
        public void TryPeek(){} // RVA: 0x34A4F40
        public void Clear(){} // RVA: 0x34A5010
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34967E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x34969A0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3496AA0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3496AC0
        public void get_IsEmpty(){} // RVA: 0x3496AE0
        public void ToArray(){} // RVA: 0x3496BA0
        public void get_Count(){} // RVA: 0x3496FA0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3497310
        public void GetEnumerator(){} // RVA: 0x3497740
        public void SnapForObservation(){} // RVA: 0x34977E0
        public void GetItemWhenAvailable(){} // RVA: 0x3497A40
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x3497D20
        public void EnqueueSlow(){} // RVA: 0x3497D90
        public void TryDequeue(){} // RVA: 0x3498330
        public void TryDequeueSlow(){} // RVA: 0x34983C0
        public void TryPeek(){} // RVA: 0x34985C0
        public void Clear(){} // RVA: 0x3498680
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3494570
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x34946C0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3494760
        public void get_IsEmpty(){} // RVA: 0x3494800
        public void ToArray(){} // RVA: 0x34948C0
        public void get_Count(){} // RVA: 0x3494D30
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3495290
        public void GetEnumerator(){} // RVA: 0x3495750
        public void SnapForObservation(){} // RVA: 0x34957F0
        public void GetItemWhenAvailable(){} // RVA: 0x3495A50
        public void Enumerate(){} // RVA: 0x3495BB0
        public void Enqueue(){} // RVA: 0x3495D30
        public void EnqueueSlow(){} // RVA: 0x3495DC0
        public void TryDequeue(){} // RVA: 0x3496260
        public void TryDequeueSlow(){} // RVA: 0x34962F0
        public void TryPeek(){} // RVA: 0x34964F0
        public void Clear(){} // RVA: 0x34965C0
        public void .ctor(){} // RVA: 0x34943B0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34A5230
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x34A53F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x34A54F0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x34A5510
        public void get_IsEmpty(){} // RVA: 0x34A5530
        public void ToArray(){} // RVA: 0x34A55F0
        public void get_Count(){} // RVA: 0x34A5A40
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x34A5DB0
        public void GetEnumerator(){} // RVA: 0x34A61E0
        public void SnapForObservation(){} // RVA: 0x34A6280
        public void GetItemWhenAvailable(){} // RVA: 0x34A64E0
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x34A6640
        public void EnqueueSlow(){} // RVA: 0x34A66C0
        public void TryDequeue(){} // RVA: 0x34A6B60
        public void TryDequeueSlow(){} // RVA: 0x34A6BF0
        public void TryPeek(){} // RVA: 0x34A6DF0
        public void Clear(){} // RVA: 0x34A6EB0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34A0F40
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x34A1100
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x34A1200
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x34A1270
        public void get_IsEmpty(){} // RVA: 0x34A1290
        public void ToArray(){} // RVA: 0x34A1370
        public void get_Count(){} // RVA: 0x34A1820
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x34A1B90
        public void GetEnumerator(){} // RVA: 0x34A2020
        public void SnapForObservation(){} // RVA: 0x34A20C0
        public void GetItemWhenAvailable(){} // RVA: 0x34A2320
        public void Enumerate(){} // RVA: 0x34A24C0
        public void Enqueue(){} // RVA: 0x34A2650
        public void EnqueueSlow(){} // RVA: 0x34A2750
        public void TryDequeue(){} // RVA: 0x34A2C30
        public void TryDequeueSlow(){} // RVA: 0x34A2CC0
        public void TryPeek(){} // RVA: 0x34A2EE0
        public void Clear(){} // RVA: 0x34A2FC0
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentQueue`1 : Object
    {
        // ── Methods ──
        public void TryDequeue(){} // RVA: 0x349A1C0
        public void Enqueue(){} // RVA: 0x3499CB0
        public void .ctor(){} // RVA: 0x34988A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3498A60
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3494670
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x3498B60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x3498B80
        public void get_IsEmpty(){} // RVA: 0x3498BA0
        public void ToArray(){} // RVA: 0x3498C60
        public void get_Count(){} // RVA: 0x34990B0
        public void GetCount(){} // RVA: 0x3495140
        public void CopyTo(){} // RVA: 0x3499420
        public void GetEnumerator(){} // RVA: 0x3499850
        public void SnapForObservation(){} // RVA: 0x34998F0
        public void GetItemWhenAvailable(){} // RVA: 0x3499B50
        public void Enumerate(){} // RVA: 0x3497BA0
        public void EnqueueSlow(){} // RVA: 0x3499D30
        public void TryDequeueSlow(){} // RVA: 0x349A250
        public void TryPeek(){} // RVA: 0x349A450
        public void Clear(){} // RVA: 0x349A510
    }

    public class ConcurrentStack`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void get_Count(){} // RVA: 0x87C130
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void Push(){} // RVA: 0xA94080
        public void PushCore(){} // RVA: 0x8943B0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0xA94080
        public void TryPop(){} // RVA: 0x87D350
        public void TryPopCore(){} // RVA: 0x883740
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x87D350
        public void ToArray(){} // RVA: 0x87C0A0
        public void ToList(){} // RVA: 0x87C540
        public void GetEnumerator(){} // RVA: 0x87C540
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class ConcurrentStack`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_Count(){} // RVA: 0x34A8480
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x341B890
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x34A84A0
        public void Push(){} // RVA: 0x34A8580
        public void PushCore(){} // RVA: 0x34A8760
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x34A8940
        public void TryPop(){} // RVA: 0x34A8960
        public void TryPopCore(){} // RVA: 0x34A8B90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x34A8F90
        public void ToArray(){} // RVA: 0x34A8FB0
        public void ToList(){} // RVA: 0x34A9050
        public void GetEnumerator(){} // RVA: 0x34A91F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x34A9290
    }

    public class IProducerConsumerCollection`1
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0xA94080
        public void TryTake(){} // RVA: 0x87D350
        public void ToArray(){} // RVA: 0x87C0A0
    }

    public class IProducerConsumerCollection`1
    {
        // ── Methods ──
        public void TryAdd(){} // RVA: 0x87D350
        public void TryTake(){} // RVA: 0x87D350
        public void ToArray(){} // RVA: 0x87C0A0
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894A90
        public void GetOrderableDynamicPartitions(){} // RVA: 0x87C0A0
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x894750
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x894750
        public void set_KeysNormalized(){} // RVA: 0x894750
        public void GetDynamicPartitions(){} // RVA: 0x87C0A0
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x48419E0
        public void GetOrderableDynamicPartitions(){} // RVA: 0x48418E0
        public void set_KeysOrderedInEachPartition(){} // RVA: 0xC120B0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0xDD7A00
        public void set_KeysNormalized(){} // RVA: 0x22201F0
        public void GetDynamicPartitions(){} // RVA: 0x4841A90
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x48418D0
        public void GetOrderableDynamicPartitions(){} // RVA: 0x48418E0
        public void set_KeysOrderedInEachPartition(){} // RVA: 0xC120B0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0xDD7A00
        public void set_KeysNormalized(){} // RVA: 0x22201F0
        public void GetDynamicPartitions(){} // RVA: 0x4841930
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x48418D0
        public void GetOrderableDynamicPartitions(){} // RVA: 0x48418E0
        public void set_KeysOrderedInEachPartition(){} // RVA: 0xC120B0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0xDD7A00
        public void set_KeysNormalized(){} // RVA: 0x22201F0
        public void GetDynamicPartitions(){} // RVA: 0x4841930
    }

    public class Partitioner : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x3185930
        public void GetDefaultChunkSize(){} // RVA: 0x3185B90
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x87D280
        public void GetDynamicPartitions(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0xB43320
        public void GetDynamicPartitions(){} // RVA: 0x48418E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0xB43320
        public void GetDynamicPartitions(){} // RVA: 0x48418E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0xB43320
        public void GetDynamicPartitions(){} // RVA: 0x48418E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0xB43320
        public void GetDynamicPartitions(){} // RVA: 0x48418E0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
        public void Enqueue(){} // RVA: 0xA94080
        public void EnqueueSlow(){} // RVA: 0xA94080
        public void TryDequeue(){} // RVA: 0x87D350
        public void TryPeek(){} // RVA: 0x87D350
        public void TryDequeueSlow(){} // RVA: 0xA94080
        public void get_IsEmpty(){} // RVA: 0x87D280
        public void GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4ACF5C0
        public void Enqueue(){} // RVA: 0x4ACF6E0
        public void EnqueueSlow(){} // RVA: 0x4ACF780
        public void TryDequeue(){} // RVA: 0x4ACFA80
        public void TryPeek(){} // RVA: 0x4ACFBA0
        public void TryDequeueSlow(){} // RVA: 0x4ACFC70
        public void get_IsEmpty(){} // RVA: 0x4ACFF20
        public void GetEnumerator(){} // RVA: 0x4ACFF80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4AD0010
    }

}