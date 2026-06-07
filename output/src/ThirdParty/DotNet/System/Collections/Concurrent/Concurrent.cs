// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 15
// Methods: 181

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollectionDebugView`1
    {
    }

    public class BlockingCollection`1
    {
        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0xDBE0
        public void get_IsCompleted(){} // RVA: 0xDBE0
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Initialize(){}
        public void Add(){} // RVA: 0x283FA0
        public void TryAddWithNoTimeValidation(){} // RVA: 0x283FA0
        public void TryTake(){} // RVA: 0x283FA0
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x283FA0
        public void CancelWaitingConsumers(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void ValidateMillisecondsTimeout(){} // RVA: 0x25E50
        public void CheckDisposed(){} // RVA: 0x24A50
    }

    public class CDSCollectionETWBCLProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x1020CE0
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x1020CE0
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x1020CE0
        public void .cctor(){} // RVA: 0x5E0E7E0
    }

    public class ConcurrentBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Add(){} // RVA: 0x283FA0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x283FA0
        public void TryTake(){} // RVA: 0xDE40
        public void GetCurrentThreadWorkStealingQueue(){}
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0xCD60
        public void GetUnownedWorkStealingQueue(){} // RVA: 0xCD60
        public void TrySteal(){}
        public void TryStealFromTo(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x2BAA0
        public void CopyFromEachQueueToArray(){}
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void ToArray(){} // RVA: 0xCD60
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void get_DangerousCount(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void get_GlobalQueuesLock(){} // RVA: 0xCD60
        public void FreezeBag(){} // RVA: 0x24B10
        public void UnfreezeBag(){} // RVA: 0x25130
    }

    public class ConcurrentDictionary`2
    {
        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x29F7910
        public void .ctor(){} // RVA: 0x29F7FE0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x29F7C70
        public void TryAdd(){} // RVA: 0x29F83A0
        public void ContainsKey(){} // RVA: 0x29F84F0
        public void TryRemove(){} // RVA: 0x29F8530
        public void TryRemoveInternal(){} // RVA: 0x29F8570
        public void TryGetValue(){} // RVA: 0x29F8B30
        public void TryGetValueInternal(){} // RVA: 0x29F8C60
        public void TryUpdateInternal(){} // RVA: 0x29F8E40
        public void Clear(){} // RVA: 0x29F93C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x29F9660
        public void ToArray(){} // RVA: 0x29F9970
        public void CopyToPairs(){} // RVA: 0x29F9BD0
        public void CopyToEntries(){} // RVA: 0x29F9CE0
        public void CopyToObjects(){} // RVA: 0x29F9E10
        public void GetEnumerator(){} // RVA: 0x29F9F80
        public void TryAddInternal(){} // RVA: 0x29FA020
        public void get_Item(){} // RVA: 0x29FA7A0
        public void set_Item(){} // RVA: 0x29FA870
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x29FAA90
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x29FADC0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x29FB1B0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x29FB410
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x29FB540
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x29FB6E0
        public void get_Keys(){} // RVA: 0x29FB740
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x29FB740
        public void get_Values(){} // RVA: 0x29FB760
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x29FB760
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x29FB780
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x29FB860
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x29FB900
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x29FB950
        public void System.Collections.IDictionary.Add(){} // RVA: 0x29FB970
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x29FBBA0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x29FBCD0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x29FB740
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x29FBDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x29FB760
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x29FBEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x29FC010
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x29FC350
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x29FC930
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x29FD0F0
        public void AcquireAllLocks(){} // RVA: 0x29FD140
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x29FD420
        public void GetValues(){} // RVA: 0x29FD6F0
        public void OnSerializing(){} // RVA: 0x29FD9B0
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x29FDAD0
        public void .cctor(){} // RVA: 0x29FDDA0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A9F570
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A9F730
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A9B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x2A9F830
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x2A9F850
        public void get_IsEmpty(){} // RVA: 0x2A9F870
        public void ToArray(){} // RVA: 0x2A9F940
        public void get_Count(){} // RVA: 0x2A9FD90
        public void GetCount(){} // RVA: 0x2A9BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x2AA0100
        public void GetEnumerator(){} // RVA: 0x2AA0530
        public void SnapForObservation(){} // RVA: 0x2AA05D0
        public void GetItemWhenAvailable(){} // RVA: 0x2AA0870
        public void Enumerate(){} // RVA: 0x2A9E7D0
        public void Enqueue(){} // RVA: 0x2AA09D0
        public void EnqueueSlow(){} // RVA: 0x2AA0A50
        public void TryDequeue(){} // RVA: 0x2AA0F20
        public void TryDequeueSlow(){} // RVA: 0x2AA0FB0
        public void TryPeek(){} // RVA: 0x2AA11E0
        public void Clear(){} // RVA: 0x2AA12A0
    }

    public class ConcurrentStack`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void Push(){} // RVA: 0x283FA0
        public void PushCore(){} // RVA: 0x2DC60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x283FA0
        public void TryPop(){} // RVA: 0xDE40
        public void TryPopCore(){} // RVA: 0xDE40 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0xDE40
        public void ToArray(){} // RVA: 0xCD60
        public void ToList(){} // RVA: 0xCE10 | overloaded x2
        public void GetEnumerator(){} // RVA: 0xCE10 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

    public class IDictionaryDebugView`2
    {
    }

    public class IProducerConsumerCollectionDebugView`1
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class OrderablePartitioner`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x252C0
        public void GetOrderableDynamicPartitions(){} // RVA: 0xCD60
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x25130
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x25130
        public void set_KeysNormalized(){} // RVA: 0x25130
        public void GetDynamicPartitions(){} // RVA: 0xCD60
    }

    public class PaddedHeadAndTail
    {
    }

    public class Partitioner
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x1BF70 | overloaded x2
        public void GetDefaultChunkSize(){} // RVA: 0xD870
    }

    public class Partitioner`1
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0xDBE0
        public void GetDynamicPartitions(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SingleProducerSingleConsumerQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void Enqueue(){} // RVA: 0x283FA0
        public void EnqueueSlow(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void TryPeek(){} // RVA: 0xDE40
        public void TryDequeueSlow(){} // RVA: 0x283FA0
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
    }

}