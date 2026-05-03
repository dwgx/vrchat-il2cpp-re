// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 15
// Methods: 181

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollectionDebugView`1 : Object
    {
    }

    public class BlockingCollection`1 : Object
    {
        public System.Collections.Concurrent.IProducerConsumerCollection`1<T> _collection;
        public int _boundedCapacity;
        public int NON_BOUNDED;
        public System.Threading.SemaphoreSlim _freeNodes;
        public System.Threading.SemaphoreSlim _occupiedNodes;

        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x7FFE80E2F150
        public void get_IsCompleted(){} // RVA: 0x7FFE80E2F150
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Initialize(){}
        public void Add(){} // RVA: 0x7FFE810A1420
        public void TryAddWithNoTimeValidation(){} // RVA: 0x7FFE810A1420
        public void TryTake(){} // RVA: 0x7FFE810A1420
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x7FFE810A1420
        public void CancelWaitingConsumers(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void ValidateMillisecondsTimeout(){} // RVA: 0x7FFE80E47430
        public void CheckDisposed(){} // RVA: 0x7FFE80E45FE0
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8694F610
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7FFE81D95990
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x7FFE81D95990
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x7FFE81D95990
        public void .cctor(){} // RVA: 0x7FFE8694F620
    }

    public class ConcurrentBag`1 : Object
    {
        public System.Threading.ThreadLocal`1<WorkStealingQueue<T>> _locals;
        public WorkStealingQueue<T> _workStealingQueues;
        public long _emptyToNonEmptyListTransitionCount;
        public object field_3; // 0x369
        public object field_4; // 0x36A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFE810A1420
        public void TryTake(){} // RVA: 0x7FFE80E2F3B0
        public void GetCurrentThreadWorkStealingQueue(){}
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x7FFE80E2E2E0
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x7FFE80E2E2E0
        public void TrySteal(){}
        public void TryStealFromTo(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E4D070
        public void CopyFromEachQueueToArray(){}
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void get_DangerousCount(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void get_GlobalQueuesLock(){} // RVA: 0x7FFE80E2E2E0
        public void FreezeBag(){} // RVA: 0x7FFE80E460A0
        public void UnfreezeBag(){} // RVA: 0x7FFE80E466C0
    }

    public class ConcurrentDictionary`2 : Object
    {
        public Tables<U,T> _tables;
        public System.Collections.Generic.IEqualityComparer`1<U> _comparer;
        public bool _growLockArray;
        public int _budget;
        public System.Collections.Generic.KeyValuePair`2<U,T>[] _serializationArray;
        public int _serializationConcurrencyLevel;
        public int _serializationCapacity;
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;
        public object field_10; // 0x843
        public object field_11; // 0x844
        public object field_12; // 0x845
        public object field_13; // 0x846
        public object field_14; // 0x847
        public object field_15; // 0x848

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFE80E2F180
        public void .ctor(){} // RVA: 0x7FFE810A1420 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFE80E460A0
        public void TryAdd(){} // RVA: 0x7FFE810A1420
        public void ContainsKey(){} // RVA: 0x7FFE810A1420
        public void TryRemove(){} // RVA: 0x7FFE810A1420
        public void TryRemoveInternal(){} // RVA: 0x7FFE810A1420
        public void TryGetValue(){} // RVA: 0x7FFE810A1420
        public void TryGetValueInternal(){} // RVA: 0x7FFE810A1420
        public void TryUpdateInternal(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void CopyToPairs(){} // RVA: 0x7FFE80E4D070
        public void CopyToEntries(){} // RVA: 0x7FFE80E4D070
        public void CopyToObjects(){} // RVA: 0x7FFE80E4D070
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void TryAddInternal(){} // RVA: 0x7FFE810A1420
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFE80E46070
        public void ThrowKeyNullException(){} // RVA: 0x7FFE80E46010
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void GetCountInternal(){} // RVA: 0x7FFE80E2EDB0
        public void GetOrAdd(){} // RVA: 0x7FFE810A1420 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFE810A1420
        public void get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFE80E460A0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFE80E2E390
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void GrowTable(){} // RVA: 0x7FFE80E460A0
        public void GetBucket(){} // RVA: 0x7FFE80E35210
        public void GetBucketAndLockNo(){} // RVA: 0x7FFE810A1420
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFE80E2EDE0
        public void AcquireAllLocks(){} // RVA: 0x7FFE80E460A0
        public void AcquireLocks(){}
        public void ReleaseLocks(){} // RVA: 0x7FFE80E484C0
        public void GetKeys(){} // RVA: 0x7FFE80E2E2E0
        public void GetValues(){} // RVA: 0x7FFE80E2E2E0
        public void OnSerializing(){} // RVA: 0x7FFE80E460A0
        public void OnSerialized(){} // RVA: 0x7FFE80E460A0
        public void OnDeserialized(){} // RVA: 0x7FFE80E460A0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class ConcurrentQueue`1 : Object
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyPromise`2<System.ValueTuple`2<bool,UnityEngine.GameObject>,bool>,Awaiter<bool>>> _tail; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE837617D0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE83761990
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE810FB320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE836DF0B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE8375F570
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFE83761A90
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFE83761AB0
        public void get_IsEmpty(){} // RVA: 0x7FFE83761AD0
        public void ToArray(){} // RVA: 0x7FFE83761BA0
        public void get_Count(){} // RVA: 0x7FFE83761FF0
        public void GetCount(){} // RVA: 0x7FFE83760050 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFE83762360
        public void GetEnumerator(){} // RVA: 0x7FFE83762790
        public void SnapForObservation(){} // RVA: 0x7FFE83762830
        public void GetItemWhenAvailable(){} // RVA: 0x7FFE83762AD0
        public void Enumerate(){} // RVA: 0x7FFE83762C30
        public void Enqueue(){} // RVA: 0x7FFE83762DB0
        public void EnqueueSlow(){} // RVA: 0x7FFE83762E30
        public void TryDequeue(){} // RVA: 0x7FFE83763300
        public void TryDequeueSlow(){} // RVA: 0x7FFE83763390
        public void TryPeek(){} // RVA: 0x7FFE837635C0
        public void Clear(){} // RVA: 0x7FFE83763680
    }

    public class ConcurrentStack`1 : Object
    {
        public Node<T> _head;
        public int BACKOFF_MAX_YIELDS;
        public object field_2; // 0x859

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void Push(){} // RVA: 0x7FFE810A1420
        public void PushCore(){} // RVA: 0x7FFE80E4F230
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFE810A1420
        public void TryPop(){} // RVA: 0x7FFE80E2F3B0
        public void TryPopCore(){} // RVA: 0x7FFE80E2F3B0 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFE80E2F3B0
        public void ToArray(){} // RVA: 0x7FFE80E2E2E0
        public void ToList(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
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
        public bool _keysOrderedInEachPartition; // 0x10
        public bool _keysOrderedAcrossPartitions; // 0x11
        public bool _keysNormalized; // 0x12

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE84A45110
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFE84A45010
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7FFE811C55F0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7FFE813471A0
        public void set_KeysNormalized(){} // RVA: 0x7FFE826E34A0
        public void GetDynamicPartitions(){} // RVA: 0x7FFE84A451C0
    }

    public class PaddedHeadAndTail : ValueType
    {
    }

    public class Partitioner : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E3D4E0 | overloaded x2
        public void GetDefaultChunkSize(){} // RVA: 0x7FFE80E2EDE0
    }

    public class Partitioner`1 : Object
    {
        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFE810FB320
        public void GetDynamicPartitions(){} // RVA: 0x7FFE84A45010
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        public Segment<T> _head;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void Enqueue(){} // RVA: 0x7FFE810A1420
        public void EnqueueSlow(){} // RVA: 0x7FFE810A1420
        public void TryDequeue(){} // RVA: 0x7FFE80E2F3B0
        public void TryPeek(){} // RVA: 0x7FFE80E2F3B0
        public void TryDequeueSlow(){} // RVA: 0x7FFE810A1420
        public void get_IsEmpty(){} // RVA: 0x7FFE80E2F150
        public void GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
    }

}