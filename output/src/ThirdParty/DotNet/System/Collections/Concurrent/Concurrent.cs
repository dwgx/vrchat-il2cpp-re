// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 15
// Methods: 180

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollectionDebugView`1 : Object
    {
    }

    public class BlockingCollection`1 : Object
    {
        public System.Collections.Concurrent.IProducerConsumerCollection`1<T> IsAddingCompleted;
        public int IsCompleted;
        public int Count;
        public System.Threading.SemaphoreSlim System.Collections.ICollection.IsSynchronized;
        public System.Threading.SemaphoreSlim System.Collections.ICollection.SyncRoot;
        public bool _isDisposed;
        public System.Threading.CancellationTokenSource _consumersCancellationTokenSource;
        public System.Threading.CancellationTokenSource _producersCancellationTokenSource;
        public int _currentAdders;
        public int COMPLETE_ADDING_ON_MASK;

        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x7FFAC2C59D00
        public void get_IsCompleted(){} // RVA: 0x7FFAC2C59D00
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Initialize(){}
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void TryAddWithNoTimeValidation(){} // RVA: 0x7FFAC2E8DC40
        public void TryTake(){} // RVA: 0x7FFAC2E8DC40
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x7FFAC2E8DC40
        public void CancelWaitingConsumers(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void ValidateMillisecondsTimeout(){} // RVA: 0x7FFAC2C71DD0
        public void CheckDisposed(){} // RVA: 0x7FFAC2C70980
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        public System.Collections.Concurrent.CDSCollectionETWBCLProvider Log;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC85A5E30
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7FFAC35D2DD0
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x7FFAC35D2DD0
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x7FFAC35D2DD0
        public void .cctor(){} // RVA: 0x7FFAC85A5E40
    }

    public class ConcurrentBag`1 : Object
    {
        public System.Threading.ThreadLocal`1<WorkStealingQueue<T>> Count;
        public WorkStealingQueue<T> DangerousCount;
        public long System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAC2E8DC40
        public void TryTake(){} // RVA: 0x7FFAC2C59F60
        public void GetCurrentThreadWorkStealingQueue(){}
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x7FFAC2C58E90
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x7FFAC2C58E90
        public void TrySteal(){}
        public void TryStealFromTo(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C77970
        public void CopyFromEachQueueToArray(){}
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void get_DangerousCount(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void get_GlobalQueuesLock(){} // RVA: 0x7FFAC2C58E90
        public void FreezeBag(){} // RVA: 0x7FFAC2C70A40
        public void UnfreezeBag(){} // RVA: 0x7FFAC2C71060
    }

    public class ConcurrentDictionary`2 : Object
    {
        public Tables<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type> Item; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>> Count; // 0x18
        public bool IsEmpty; // 0x20
        public int Keys; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type>[] System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys; // 0x28
        public int Values; // 0x30
        public int System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values; // 0x34
        public int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly;
        public int System.Collections.IDictionary.IsFixedSize;
        public bool System.Collections.IDictionary.IsReadOnly;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFAC53ECE10
        public void .ctor(){} // RVA: 0x7FFAC53ED4E0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFAC53ED170
        public void TryAdd(){} // RVA: 0x7FFAC53ED8A0
        public void ContainsKey(){} // RVA: 0x7FFAC53ED9F0
        public void TryRemove(){} // RVA: 0x7FFAC53EDA30
        public void TryRemoveInternal(){} // RVA: 0x7FFAC53EDA70
        public void TryGetValue(){} // RVA: 0x7FFAC53EE030
        public void TryGetValueInternal(){} // RVA: 0x7FFAC53EE160
        public void TryUpdateInternal(){} // RVA: 0x7FFAC53EE340
        public void Clear(){} // RVA: 0x7FFAC53EE8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFAC53EEB60
        public void ToArray(){} // RVA: 0x7FFAC53EEE70
        public void CopyToPairs(){} // RVA: 0x7FFAC53EF0D0
        public void CopyToEntries(){} // RVA: 0x7FFAC53EF1E0
        public void CopyToObjects(){} // RVA: 0x7FFAC53EF310
        public void GetEnumerator(){} // RVA: 0x7FFAC53EF480
        public void TryAddInternal(){} // RVA: 0x7FFAC53EF520
        public void get_Item(){} // RVA: 0x7FFAC53EFCA0
        public void set_Item(){} // RVA: 0x7FFAC53EFD70
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFAC53EFEC0
        public void ThrowKeyNullException(){} // RVA: 0x7FFAC53EFF40
        public void get_Count(){} // RVA: 0x7FFAC53EFF90
        public void GetCountInternal(){} // RVA: 0x7FFAC53F0040
        public void GetOrAdd(){} // RVA: 0x7FFAC53F02C0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFAC53F06B0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFAC53F0910
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFAC53F0A40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFAC53F0BE0
        public void get_Keys(){} // RVA: 0x7FFAC53F0C40
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFAC53F0C40
        public void get_Values(){} // RVA: 0x7FFAC53F0C60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFAC53F0C60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFAC53F0C80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFAC53F0D60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFAC53F0E00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC53F0E50
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFAC53F0E70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFAC53F10A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFAC53F11D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFAC53F0C40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFAC53F12B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFAC53F0C60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFAC53F13F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFAC53F1510
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC53F1850
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC53EA0F0
        public void GrowTable(){} // RVA: 0x7FFAC53F1E30
        public void GetBucket(){} // RVA: 0x7FFAC53F25C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFAC53F25D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFAC53F25F0
        public void AcquireAllLocks(){} // RVA: 0x7FFAC53F2640
        public void AcquireLocks(){} // RVA: 0x7FFAC53F2730
        public void ReleaseLocks(){} // RVA: 0x7FFAC53F2890
        public void GetKeys(){} // RVA: 0x7FFAC53F2920
        public void GetValues(){} // RVA: 0x7FFAC53F2BF0
        public void OnSerializing(){} // RVA: 0x7FFAC53F2EB0
        public void OnSerialized(){} // RVA: 0x7FFAC53F2F70
        public void OnDeserialized(){} // RVA: 0x7FFAC53F2FD0
        public void .cctor(){} // RVA: 0x7FFAC53F32A0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object System.Collections.ICollection.IsSynchronized; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAllPromise`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,Awaiter<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,int>> System.Collections.ICollection.SyncRoot; // 0x18
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAllPromise`1<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,Awaiter<ÍÍÌÍÎÏÎÍÎÌÎÌÌÍÎÏÏÍÏÍÌÍÍ>,int>> IsEmpty; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC546C630
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC546C7F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2F21320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC53EA0F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC546A620
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAC546C8F0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAC546C910
        public void get_IsEmpty(){} // RVA: 0x7FFAC546C930
        public void ToArray(){} // RVA: 0x7FFAC546CA00
        public void get_Count(){} // RVA: 0x7FFAC546CE50
        public void GetCount(){} // RVA: 0x7FFAC546B100 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFAC546D1C0
        public void GetEnumerator(){} // RVA: 0x7FFAC546D5F0
        public void SnapForObservation(){} // RVA: 0x7FFAC546D690
        public void GetItemWhenAvailable(){} // RVA: 0x7FFAC546D930
        public void Enumerate(){} // RVA: 0x7FFAC546DA90
        public void Enqueue(){} // RVA: 0x7FFAC546DC10
        public void EnqueueSlow(){} // RVA: 0x7FFAC546DC90
        public void TryDequeue(){} // RVA: 0x7FFAC546E160
        public void TryDequeueSlow(){} // RVA: 0x7FFAC546E1F0
        public void TryPeek(){} // RVA: 0x7FFAC546E420
    }

    public class ConcurrentStack`1 : Object
    {
        public Node<T> Count;
        public int System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void Push(){} // RVA: 0x7FFAC2E8DC40
        public void PushCore(){} // RVA: 0x7FFAC2C79B30
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFAC2E8DC40
        public void TryPop(){} // RVA: 0x7FFAC2C59F60
        public void TryPopCore(){} // RVA: 0x7FFAC2C59F60 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFAC2C59F60
        public void ToArray(){} // RVA: 0x7FFAC2C58E90
        public void ToList(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

    public class IDictionaryDebugView`2 : Object
    {
    }

    public class IProducerConsumerCollectionDebugView`1 : Object
    {
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        public bool KeysOrderedInEachPartition; // 0x10
        public bool KeysOrderedAcrossPartitions; // 0x11
        public bool KeysNormalized; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC66E0530
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFAC66E0430
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7FFAC2FEB5F0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7FFAC3771D90
        public void set_KeysNormalized(){} // RVA: 0x7FFAC4411DE0
        public void GetDynamicPartitions(){} // RVA: 0x7FFAC66E05E0
    }

    public class PaddedHeadAndTail : ValueType
    {
        public int Head; // 0x90
        public int Tail; // 0x110
    }

    public class Partitioner : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C68090 | overloaded x2
        public void GetDefaultChunkSize(){} // RVA: 0x7FFAC2C59990
    }

    public class Partitioner`1 : Object
    {
        public object SupportsDynamicPartitions;

        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFAC2F21320
        public void GetDynamicPartitions(){} // RVA: 0x7FFAC66E0430
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        public Segment<T> IsEmpty;
        public Segment<T> _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void Enqueue(){} // RVA: 0x7FFAC2E8DC40
        public void EnqueueSlow(){} // RVA: 0x7FFAC2E8DC40
        public void TryDequeue(){} // RVA: 0x7FFAC2C59F60
        public void TryPeek(){} // RVA: 0x7FFAC2C59F60
        public void TryDequeueSlow(){} // RVA: 0x7FFAC2E8DC40
        public void get_IsEmpty(){} // RVA: 0x7FFAC2C59D00
        public void GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
    }

}