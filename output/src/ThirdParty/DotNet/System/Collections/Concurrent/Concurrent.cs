// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 12
// Methods: 180

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollection`1 : Object
    {
        public JapaneseLangName.p<T1717597424> IsAddingCompleted;
        public int IsCompleted;
        public int Count;
        public sageKind.StringComparison System.Collections.ICollection.IsSynchronized;
        public sageKind.StringComparison System.Collections.ICollection.SyncRoot;
        public bool _isDisposed;
        public sageKind._internal _consumersCancellationTokenSource;
        public sageKind._internal _producersCancellationTokenSource;
        public int _currentAdders;
        public int COMPLETE_ADDING_ON_MASK;

        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x7FFD4E079D00
        public void get_IsCompleted(){} // RVA: 0x7FFD4E079D00
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Initialize(){}
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void TryAddWithNoTimeValidation(){} // RVA: 0x7FFD4E2ADC40
        public void TryTake(){} // RVA: 0x7FFD4E2ADC40
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x7FFD4E2ADC40
        public void CancelWaitingConsumers(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void ValidateMillisecondsTimeout(){} // RVA: 0x7FFD4E091DD0
        public void CheckDisposed(){} // RVA: 0x7FFD4E090980
    }

    public class CDSCollectionETWBCLProvider : EventSource
    {
        public JapaneseLangName.? Log;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD539C5E30
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x7FFD4E9F2DD0
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x7FFD4E9F2DD0
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x7FFD4E9F2DD0
        public void .cctor(){} // RVA: 0x7FFD539C5E40
    }

    public class ConcurrentBag`1 : Object
    {
        public sageKind._id<_method<T1717597488>> Count;
        public _method<T1717597488> DangerousCount;
        public long System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40 | overloaded x2
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void TryTake(){} // RVA: 0x7FFD4E079F60
        public void GetCurrentThreadWorkStealingQueue(){}
        public void CreateWorkStealingQueueForCurrentThread(){} // RVA: 0x7FFD4E078E90
        public void GetUnownedWorkStealingQueue(){} // RVA: 0x7FFD4E078E90
        public void TrySteal(){}
        public void TryStealFromTo(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E097970
        public void CopyFromEachQueueToArray(){}
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void get_DangerousCount(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void get_GlobalQueuesLock(){} // RVA: 0x7FFD4E078E90
        public void FreezeBag(){} // RVA: 0x7FFD4E090A40
        public void UnfreezeBag(){} // RVA: 0x7FFD4E091060
    }

    public class ConcurrentDictionary`2 : Object
    {
        public 400_DQ<string,ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.ÏÎÏÌÎÍÌÍÏÌÌÎÎÎ> Item; // 0x10
        public URA.hEraNames<string> Count; // 0x18
        public bool IsEmpty; // 0x20
        public int Keys; // 0x24
        public URA.mes<string,ÏÎÏÍÍÌÏÍÌÌÍÍÌÎÎÎÌÎÌÍÎÌÍ.ÏÎÏÌÎÍÌÍÏÌÌÎÎÎ>[] System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys; // 0x28
        public int Values; // 0x30
        public int System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values; // 0x34
        public int System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly;
        public int System.Collections.IDictionary.IsFixedSize;
        public bool System.Collections.IDictionary.IsReadOnly;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x7FFD5080CE10
        public void .ctor(){} // RVA: 0x7FFD5080D4E0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x7FFD5080D170
        public void TryAdd(){} // RVA: 0x7FFD5080D8A0
        public void ContainsKey(){} // RVA: 0x7FFD5080D9F0
        public void TryRemove(){} // RVA: 0x7FFD5080DA30
        public void TryRemoveInternal(){} // RVA: 0x7FFD5080DA70
        public void TryGetValue(){} // RVA: 0x7FFD5080E030
        public void TryGetValueInternal(){} // RVA: 0x7FFD5080E160
        public void TryUpdateInternal(){} // RVA: 0x7FFD5080E340
        public void Clear(){} // RVA: 0x7FFD5080E8C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x7FFD5080EB60
        public void ToArray(){} // RVA: 0x7FFD5080EE70
        public void CopyToPairs(){} // RVA: 0x7FFD5080F0D0
        public void CopyToEntries(){} // RVA: 0x7FFD5080F1E0
        public void CopyToObjects(){} // RVA: 0x7FFD5080F310
        public void GetEnumerator(){} // RVA: 0x7FFD5080F480
        public void TryAddInternal(){} // RVA: 0x7FFD5080F520
        public void get_Item(){} // RVA: 0x7FFD5080FCA0
        public void set_Item(){} // RVA: 0x7FFD5080FD70
        public void ThrowKeyNotFoundException(){} // RVA: 0x7FFD5080FEC0
        public void ThrowKeyNullException(){} // RVA: 0x7FFD5080FF40
        public void get_Count(){} // RVA: 0x7FFD5080FF90
        public void GetCountInternal(){} // RVA: 0x7FFD50810040
        public void GetOrAdd(){} // RVA: 0x7FFD508102C0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x7FFD508106B0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x7FFD50810910
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x7FFD50810A40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x7FFD50810BE0
        public void get_Keys(){} // RVA: 0x7FFD50810C40
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x7FFD50810C40
        public void get_Values(){} // RVA: 0x7FFD50810C60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x7FFD50810C60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x7FFD50810C80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x7FFD50810D60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x7FFD50810E00
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD50810E50
        public void System.Collections.IDictionary.Add(){} // RVA: 0x7FFD50810E70
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x7FFD508110A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x7FFD508111D0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x7FFD4E341320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x7FFD50810C40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x7FFD508112B0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x7FFD50810C60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x7FFD508113F0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x7FFD50811510
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD50811850
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD5080A0F0
        public void GrowTable(){} // RVA: 0x7FFD50811E30
        public void GetBucket(){} // RVA: 0x7FFD508125C0
        public void GetBucketAndLockNo(){} // RVA: 0x7FFD508125D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x7FFD508125F0
        public void AcquireAllLocks(){} // RVA: 0x7FFD50812640
        public void AcquireLocks(){} // RVA: 0x7FFD50812730
        public void ReleaseLocks(){} // RVA: 0x7FFD50812890
        public void GetKeys(){} // RVA: 0x7FFD50812920
        public void GetValues(){} // RVA: 0x7FFD50812BF0
        public void OnSerializing(){} // RVA: 0x7FFD50812EB0
        public void OnSerialized(){} // RVA: 0x7FFD50812F70
        public void OnDeserialized(){} // RVA: 0x7FFD50812FD0
        public void .cctor(){} // RVA: 0x7FFD508132A0
    }

    public class ConcurrentQueue`1 : Object
    {
        public object System.Collections.ICollection.IsSynchronized;
        public rn<T1717590384> System.Collections.ICollection.SyncRoot;
        public rn<T1717590384> IsEmpty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5088C630
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD5088C7F0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E341320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD5080A0F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD5088A620
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFD5088C8F0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFD5088C910
        public void get_IsEmpty(){} // RVA: 0x7FFD5088C930
        public void ToArray(){} // RVA: 0x7FFD5088CA00
        public void get_Count(){} // RVA: 0x7FFD5088CE50
        public void GetCount(){} // RVA: 0x7FFD5088B100 | overloaded x2
        public void CopyTo(){} // RVA: 0x7FFD5088D1C0
        public void GetEnumerator(){} // RVA: 0x7FFD5088D5F0
        public void SnapForObservation(){} // RVA: 0x7FFD5088D690
        public void GetItemWhenAvailable(){} // RVA: 0x7FFD5088D930
        public void Enumerate(){} // RVA: 0x7FFD5088DA90
        public void Enqueue(){} // RVA: 0x7FFD5088DC10
        public void EnqueueSlow(){} // RVA: 0x7FFD5088DC90
        public void TryDequeue(){} // RVA: 0x7FFD5088E160
        public void TryDequeueSlow(){} // RVA: 0x7FFD5088E1F0
        public void TryPeek(){} // RVA: 0x7FFD5088E420
    }

    public class ConcurrentStack`1 : Object
    {
        public tyles<T1717590640> Count;
        public int System.Collections.ICollection.IsSynchronized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void PushCore(){} // RVA: 0x7FFD4E099B30
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x7FFD4E2ADC40
        public void TryPop(){} // RVA: 0x7FFD4E079F60
        public void TryPopCore(){} // RVA: 0x7FFD4E079F60 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x7FFD4E079F60
        public void ToArray(){} // RVA: 0x7FFD4E078E90
        public void ToList(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x7FFD4E078F40 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

    public class IProducerConsumerCollection`1
    {
    }

    public class OrderablePartitioner`1 : Partitioner`1
    {
        public bool KeysOrderedInEachPartition;
        public bool KeysOrderedAcrossPartitions;
        public bool KeysNormalized;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD51B00530
        public void GetOrderableDynamicPartitions(){} // RVA: 0x7FFD51B00430
        public void set_KeysOrderedInEachPartition(){} // RVA: 0x7FFD4E40B5F0
        public void set_KeysOrderedAcrossPartitions(){} // RVA: 0x7FFD4EB91D90
        public void set_KeysNormalized(){} // RVA: 0x7FFD4F831DE0
        public void GetDynamicPartitions(){} // RVA: 0x7FFD51B005E0
    }

    public class PaddedHeadAndTail : ValueType
    {
    }

    public class Partitioner : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E088090 | overloaded x2
        public void GetDefaultChunkSize(){} // RVA: 0x7FFD4E079990
    }

    public class Partitioner`1 : Object
    {
        public object SupportsDynamicPartitions;

        // ── Methods ──
        public void get_SupportsDynamicPartitions(){} // RVA: 0x7FFD4E341320
        public void GetDynamicPartitions(){} // RVA: 0x7FFD51B00430
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SingleProducerSingleConsumerQueue`1 : Object
    {
        public rn<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> IsEmpty; // 0x10
        public rn<ÎÏÍÍÍÌÎÍÏÌÎÎÌÌÏÎÏÍÏ> _tail; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void Enqueue(){} // RVA: 0x7FFD4E2ADC40
        public void EnqueueSlow(){} // RVA: 0x7FFD4E2ADC40
        public void TryDequeue(){} // RVA: 0x7FFD4E079F60
        public void TryPeek(){} // RVA: 0x7FFD4E079F60
        public void TryDequeueSlow(){} // RVA: 0x7FFD4E2ADC40
        public void get_IsEmpty(){} // RVA: 0x7FFD4E079D00
        public void GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
    }

}