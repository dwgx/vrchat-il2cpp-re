// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 68
// Methods: 3389

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class CDSCollectionETWBCLProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void ConcurrentStack_FastPushFailed(){} // RVA: 0x1020CE0
        public void ConcurrentStack_FastPopFailed(){} // RVA: 0x1020CE0
        public void ConcurrentDictionary_AcquiringAllLocks(){} // RVA: 0x1020CE0
        public void .cctor(){} // RVA: 0x5E0E7E0
    }

    public class CDSCollectionETWBCLProvider
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5E0E7D0
        public void ConcurrentBag_TryTakeSteals(){} // RVA: 0x1020CE0
        public void ConcurrentBag_TryPeekSteals(){} // RVA: 0x1020CE0
        public void .cctor(){} // RVA: 0x6CBE380
    }

    public class ConcurrentBag`1
    {
        public System.Threading.ThreadLocal`1<WorkStealingQueue<T>> _locals;
        public WorkStealingQueue<T> _workStealingQueues;
        public long _emptyToNonEmptyListTransitionCount;

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
        public Tables<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<string,string>,System.Type>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

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

    public class ConcurrentDictionary`2
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

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0xDC10
        public void .ctor(){} // RVA: 0x283FA0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x24B10
        public void TryAdd(){} // RVA: 0x283FA0
        public void ContainsKey(){} // RVA: 0x283FA0
        public void TryRemove(){} // RVA: 0x283FA0
        public void TryRemoveInternal(){} // RVA: 0x283FA0
        public void TryGetValue(){} // RVA: 0x283FA0
        public void TryGetValueInternal(){} // RVA: 0x283FA0
        public void TryUpdateInternal(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2BAA0
        public void ToArray(){} // RVA: 0xCD60
        public void CopyToPairs(){} // RVA: 0x2BAA0
        public void CopyToEntries(){} // RVA: 0x2BAA0
        public void CopyToObjects(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void TryAddInternal(){} // RVA: 0x283FA0
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void ThrowKeyNotFoundException(){} // RVA: 0x24AE0
        public void ThrowKeyNullException(){} // RVA: 0x24A80
        public void get_Count(){} // RVA: 0xD840
        public void GetCountInternal(){} // RVA: 0xD840
        public void GetOrAdd(){} // RVA: 0x283FA0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x283FA0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x283FA0
        public void get_Keys(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0xCD60
        public void get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0xCD60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x283FA0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x283FA0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2DC60
        public void System.Collections.IDictionary.Contains(){} // RVA: 0xDE40
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x24B10
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0xCD60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0xCE10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2DC60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void GrowTable(){} // RVA: 0x24B10
        public void GetBucket(){} // RVA: 0x13CA0
        public void GetBucketAndLockNo(){} // RVA: 0x283FA0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0xD870
        public void AcquireAllLocks(){} // RVA: 0x24B10
        public void AcquireLocks(){}
        public void ReleaseLocks(){} // RVA: 0x26EE0
        public void GetKeys(){} // RVA: 0xCD60
        public void GetValues(){} // RVA: 0xCD60
        public void OnSerializing(){} // RVA: 0x24B10
        public void OnSerialized(){} // RVA: 0x24B10
        public void OnDeserialized(){} // RVA: 0x24B10
        public void .cctor(){} // RVA: 0x24A80
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,Microsoft.Extensions.Logging.ILogger> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,Microsoft.Extensions.Logging.ILogger>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,ServiceAccessor>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A486E0
        public void .ctor(){} // RVA: 0x2A48DB0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A48A40
        public void TryAdd(){} // RVA: 0x2A49170
        public void ContainsKey(){} // RVA: 0x29F84F0
        public void TryRemove(){} // RVA: 0x29F8530
        public void TryRemoveInternal(){} // RVA: 0x29F8570
        public void TryGetValue(){} // RVA: 0x29F8B30
        public void TryGetValueInternal(){} // RVA: 0x29F8C60
        public void TryUpdateInternal(){} // RVA: 0x29F8E40
        public void Clear(){} // RVA: 0x2A492C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A49560
        public void ToArray(){} // RVA: 0x2A49880
        public void CopyToPairs(){} // RVA: 0x2A49BF0
        public void CopyToEntries(){} // RVA: 0x29F9CE0
        public void CopyToObjects(){} // RVA: 0x29F9E10
        public void GetEnumerator(){} // RVA: 0x29F9F80
        public void TryAddInternal(){} // RVA: 0x2A49D00
        public void get_Item(){} // RVA: 0x29FA7A0
        public void set_Item(){} // RVA: 0x2A4A410
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A4A560
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A4A800 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A4ABF0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A4AE50
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A4AF80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x29FB6E0
        public void get_Keys(){} // RVA: 0x2A4B120
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A4B120
        public void get_Values(){} // RVA: 0x2A4B140
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A4B140
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
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A4B120
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x29FBDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A4B140
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x29FBEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A4B160
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A4B380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A4B960
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A4C0F0
        public void AcquireAllLocks(){} // RVA: 0x2A4C140
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A4C230
        public void GetValues(){} // RVA: 0x2A4C500
        public void OnSerializing(){} // RVA: 0x2A4C7C0
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A4C880
        public void .cctor(){} // RVA: 0x2A4CB50
    }

    public class ConcurrentDictionary`2
    {
        public Tables<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,object> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceIdentifier,object>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A486E0
        public void .ctor(){} // RVA: 0x2A48DB0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A48A40
        public void TryAdd(){} // RVA: 0x2A49170
        public void ContainsKey(){} // RVA: 0x29F84F0
        public void TryRemove(){} // RVA: 0x29F8530
        public void TryRemoveInternal(){} // RVA: 0x29F8570
        public void TryGetValue(){} // RVA: 0x29F8B30
        public void TryGetValueInternal(){} // RVA: 0x29F8C60
        public void TryUpdateInternal(){} // RVA: 0x29F8E40
        public void Clear(){} // RVA: 0x2A492C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A49560
        public void ToArray(){} // RVA: 0x2A49880
        public void CopyToPairs(){} // RVA: 0x2A49BF0
        public void CopyToEntries(){} // RVA: 0x29F9CE0
        public void CopyToObjects(){} // RVA: 0x29F9E10
        public void GetEnumerator(){} // RVA: 0x29F9F80
        public void TryAddInternal(){} // RVA: 0x2A49D00
        public void get_Item(){} // RVA: 0x29FA7A0
        public void set_Item(){} // RVA: 0x2A4A410
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A4A560
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A4A800 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A4ABF0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A4AE50
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A4AF80
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x29FB6E0
        public void get_Keys(){} // RVA: 0x2A4B120
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A4B120
        public void get_Values(){} // RVA: 0x2A4B140
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A4B140
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
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A4B120
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x29FBDB0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A4B140
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x29FBEF0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A4B160
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A4B380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A4B960
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A4C0F0
        public void AcquireAllLocks(){} // RVA: 0x2A4C140
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A4C230
        public void GetValues(){} // RVA: 0x2A4C500
        public void OnSerializing(){} // RVA: 0x2A4C7C0
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A4C880
        public void .cctor(){} // RVA: 0x2A4CB50
    }

    public class ConcurrentDictionary`2
    {
        public Tables<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCacheKey,Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A3B720
        public void .ctor(){} // RVA: 0x2A3BE10 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A3BA80
        public void TryAdd(){} // RVA: 0x2A3C1D0
        public void ContainsKey(){} // RVA: 0x2A3C340
        public void TryRemove(){} // RVA: 0x2A3C390
        public void TryRemoveInternal(){} // RVA: 0x2A3C3E0
        public void TryGetValue(){} // RVA: 0x2A3C930
        public void TryGetValueInternal(){} // RVA: 0x2A3CA70
        public void TryUpdateInternal(){} // RVA: 0x2A3CC00
        public void Clear(){} // RVA: 0x2A3D170
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A3D410
        public void ToArray(){} // RVA: 0x2A3D650
        public void CopyToPairs(){} // RVA: 0x2A3D8B0
        public void CopyToEntries(){} // RVA: 0x2A3D9D0
        public void CopyToObjects(){} // RVA: 0x2A3DB10
        public void GetEnumerator(){} // RVA: 0x2A3DC90
        public void TryAddInternal(){} // RVA: 0x2A3DD30
        public void get_Item(){} // RVA: 0x2A3E430
        public void set_Item(){} // RVA: 0x2A3E510
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A3E680
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A3E950 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A3EEA0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A3F240
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A3F370
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A3F530
        public void get_Keys(){} // RVA: 0x2A3F5A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A3F5A0
        public void get_Values(){} // RVA: 0x2A3F5C0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A3F5C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A3F5E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A3F660
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A3F710
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A3F770
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A3F790
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A3F9D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A3FB10
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A3F5A0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A3FBF0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A3F5C0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A3FD30
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A3FE60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A40090
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A40680
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A40E30
        public void AcquireAllLocks(){} // RVA: 0x2A40E80
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A40F70
        public void GetValues(){} // RVA: 0x2A41240
        public void OnSerializing(){} // RVA: 0x2A41500
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A415C0
        public void .cctor(){} // RVA: 0x2A41890
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,System.Lazy`1<Microsoft.Extensions.Logging.LoggerFilterOptions>> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,System.Lazy`1<Microsoft.Extensions.Logging.LoggerFilterOptions>>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,Microsoft.Extensions.Logging.Logger> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,Microsoft.Extensions.Logging.Logger>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<SPKey,System.Net.ServicePoint> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<SPKey> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<SPKey,System.Net.ServicePoint>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,Newtonsoft.Json.Serialization.JsonContract> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,Newtonsoft.Json.Serialization.JsonContract>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,Union> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,Union>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,System.Type> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,System.Type>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,System.Type>,System.Func`2<object,object>> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,System.Type>> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,System.Type>,System.Func`2<object,object>>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

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

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,System.Func`2<object[],object>> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,System.Func`2<object[],object>>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<object,Newtonsoft.Json.JsonContainerAttribute> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<object,Newtonsoft.Json.JsonContainerAttribute>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<object,System.Runtime.Serialization.DataContractAttribute> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<object,System.Runtime.Serialization.DataContractAttribute>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<object,Newtonsoft.Json.JsonConverterAttribute> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<object,Newtonsoft.Json.JsonConverterAttribute>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<object,Newtonsoft.Json.JsonObjectAttribute> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<object> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<object,Newtonsoft.Json.JsonObjectAttribute>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,Newtonsoft.Json.Utilities.ReflectionObject> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,Newtonsoft.Json.Utilities.ReflectionObject>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<LiteralList,ZLogger.MessageSequence> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<LiteralList> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<LiteralList,ZLogger.MessageSequence>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A8DCF0
        public void .ctor(){} // RVA: 0x2A8E3B0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A8E050
        public void TryAdd(){} // RVA: 0x2A8E770
        public void ContainsKey(){} // RVA: 0x2A8E830
        public void TryRemove(){} // RVA: 0x2A8E860
        public void TryRemoveInternal(){} // RVA: 0x2A8E8A0
        public void TryGetValue(){} // RVA: 0x2A8ED60
        public void TryGetValueInternal(){} // RVA: 0x2A8EE10
        public void TryUpdateInternal(){} // RVA: 0x2A8EF60
        public void Clear(){} // RVA: 0x2A8F470
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A8F710
        public void ToArray(){} // RVA: 0x2A8FA00
        public void CopyToPairs(){} // RVA: 0x2A8FD40
        public void CopyToEntries(){} // RVA: 0x2A10060
        public void CopyToObjects(){} // RVA: 0x2A8FE30
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A8FF80
        public void get_Item(){} // RVA: 0x2A90610
        public void set_Item(){} // RVA: 0x2A906D0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A90790
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A90990 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A90DC0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A91090
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A911C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A91230
        public void get_Keys(){} // RVA: 0x2A91280
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A91280
        public void get_Values(){} // RVA: 0x2A912A0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A912A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A912C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A91330
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A913D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A11800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A91420
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A91640
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A11B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A91280
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A91760
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A912A0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A91890
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A919A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A91C30
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A92270
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A929E0
        public void AcquireAllLocks(){} // RVA: 0x2A92A30
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A92B20
        public void GetValues(){} // RVA: 0x2A92DE0
        public void OnSerializing(){} // RVA: 0x2A930A0
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A93160
        public void .cctor(){} // RVA: 0x2A93430
    }

    public class ConcurrentDictionary`2
    {
        public Tables<int,ÍÌÏÎÌÏÌÏÌÏÌÌÌÌÌÏÏÏÎÍÎÏÍ> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<int,ÍÌÏÎÌÏÌÏÌÏÌÌÌÌÌÏÏÏÎÍÎÏÍ>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A08470
        public void .ctor(){} // RVA: 0x2A08B30 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A087D0
        public void TryAdd(){} // RVA: 0x2A08EF0
        public void ContainsKey(){} // RVA: 0x2A08FB0
        public void TryRemove(){} // RVA: 0x2A08FE0
        public void TryRemoveInternal(){} // RVA: 0x2A09020
        public void TryGetValue(){} // RVA: 0x2A094D0
        public void TryGetValueInternal(){} // RVA: 0x2A09580
        public void TryUpdateInternal(){} // RVA: 0x2A096D0
        public void Clear(){} // RVA: 0x2A09BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A09E60
        public void ToArray(){} // RVA: 0x2A0A160
        public void CopyToPairs(){} // RVA: 0x2A0A450
        public void CopyToEntries(){} // RVA: 0x2A0A540
        public void CopyToObjects(){} // RVA: 0x2A0A670
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A0A870
        public void get_Item(){} // RVA: 0x2A0AEF0
        public void set_Item(){} // RVA: 0x2A0AFA0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A0B060
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A0B260 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A0B670 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A0B940
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A0BA70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A0BAE0
        public void get_Keys(){} // RVA: 0x2A0BB30
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A0BB30
        public void get_Values(){} // RVA: 0x2A0BB50
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A0BB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A0BB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A0BBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A0BC80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A0BCF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A0BF10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A0BB30
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A0C110
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A0BB50
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A0C230
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A0C340
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A0C550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A0CBB0
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A0D330
        public void AcquireAllLocks(){} // RVA: 0x2A0D380
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A0D470
        public void GetValues(){} // RVA: 0x2A0D720
        public void OnSerializing(){} // RVA: 0x2A0D9E0
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A0DAA0
        public void .cctor(){} // RVA: 0x2A0DD70
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,ÏÏÌÌÌÏÌÎÌÏÌÌÎÌÏÌÎÏÍÎÎÌÎ> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,ÏÏÌÌÌÏÌÎÌÏÌÌÎÌÏÌÎÏÍÎÎÌÎ>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<uint,int> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<uint> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<uint,int>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A4CD60
        public void .ctor(){} // RVA: 0x2A4D380 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A4D0C0
        public void TryAdd(){} // RVA: 0x2A4D740
        public void ContainsKey(){} // RVA: 0x2A4D800
        public void TryRemove(){} // RVA: 0x2A4D830
        public void TryRemoveInternal(){} // RVA: 0x2A4D860
        public void TryGetValue(){} // RVA: 0x2A4DD00
        public void TryGetValueInternal(){} // RVA: 0x2A4DDB0
        public void TryUpdateInternal(){} // RVA: 0x2A4DF00
        public void Clear(){} // RVA: 0x2A4E3E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A4E680
        public void ToArray(){} // RVA: 0x2A4E940
        public void CopyToPairs(){} // RVA: 0x2A4EC50
        public void CopyToEntries(){} // RVA: 0x2A4ECE0
        public void CopyToObjects(){} // RVA: 0x2A4EE30
        public void GetEnumerator(){} // RVA: 0x2A00200
        public void TryAddInternal(){} // RVA: 0x2A4EF50
        public void get_Item(){} // RVA: 0x2A4F5B0
        public void set_Item(){} // RVA: 0x2A4F660
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A4F720
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A4F920 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A4FD00 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A4FFA0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A500D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A501F0
        public void get_Keys(){} // RVA: 0x2A50240
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A50240
        public void get_Values(){} // RVA: 0x2A50260
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A50260
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A50280
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A50300
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A50390
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A01760
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A503E0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A505F0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A01AC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A50240
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A50710
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A50260
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A50830
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A50A20
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A50C30
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A51270
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A519E0
        public void AcquireAllLocks(){} // RVA: 0x2A51A30
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A51B20
        public void GetValues(){} // RVA: 0x2A51DD0
        public void OnSerializing(){} // RVA: 0x2A52080
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A52140
        public void .cctor(){} // RVA: 0x2A52410
    }

    public class ConcurrentDictionary`2
    {
        public Tables<byte,int> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<byte> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<byte,int>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x29FDFB0
        public void .ctor(){} // RVA: 0x29FE5D0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x29FE310
        public void TryAdd(){} // RVA: 0x29FE990
        public void ContainsKey(){} // RVA: 0x29FEA50
        public void TryRemove(){} // RVA: 0x29FEA80
        public void TryRemoveInternal(){} // RVA: 0x29FEAB0
        public void TryGetValue(){} // RVA: 0x29FEF60
        public void TryGetValueInternal(){} // RVA: 0x29FF010
        public void TryUpdateInternal(){} // RVA: 0x29FF160
        public void Clear(){} // RVA: 0x29FF650
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x29FF8F0
        public void ToArray(){} // RVA: 0x29FFBC0
        public void CopyToPairs(){} // RVA: 0x29FFEE0
        public void CopyToEntries(){} // RVA: 0x29FFF80
        public void CopyToObjects(){} // RVA: 0x2A000D0
        public void GetEnumerator(){} // RVA: 0x2A00200
        public void TryAddInternal(){} // RVA: 0x2A002A0
        public void get_Item(){} // RVA: 0x2A00900
        public void set_Item(){} // RVA: 0x2A009B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A00A70
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A00C70 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A01070 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A01320
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A01450
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A01570
        public void get_Keys(){} // RVA: 0x2A015C0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A015C0
        public void get_Values(){} // RVA: 0x2A015E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A015E0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A01600
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A01680
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A01710
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A01760
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A01780
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A019A0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A01AC0
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A015C0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A01BA0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A015E0
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A01CC0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A01EB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A020C0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A02740
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A02EB0
        public void AcquireAllLocks(){} // RVA: 0x2A02F00
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A02FF0
        public void GetValues(){} // RVA: 0x2A032B0
        public void OnSerializing(){} // RVA: 0x2A03560
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A03620
        public void .cctor(){} // RVA: 0x2A038F0
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,VRC.Udon.Common.Interfaces.IUdonComponentGetterModule> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,VRC.Udon.Common.Interfaces.IUdonComponentGetterModule>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,VRC.Udon.Common.Interfaces.IUdonWrapperModule> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,VRC.Udon.Common.Interfaces.IUdonWrapperModule>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,Handlers> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,Handlers>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<UIntPtr,SteamAudio.SteamAudioSource> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<UIntPtr> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<UIntPtr,SteamAudio.SteamAudioSource>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A13B30
        public void .ctor(){} // RVA: 0x2A141F0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A13E90
        public void TryAdd(){} // RVA: 0x2A145B0
        public void ContainsKey(){} // RVA: 0x2A14670
        public void TryRemove(){} // RVA: 0x2A0EAF0
        public void TryRemoveInternal(){} // RVA: 0x2A0EB30
        public void TryGetValue(){} // RVA: 0x2A0EFE0
        public void TryGetValueInternal(){} // RVA: 0x2A0F090
        public void TryUpdateInternal(){} // RVA: 0x2A0F1E0
        public void Clear(){} // RVA: 0x2A146A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A14940
        public void ToArray(){} // RVA: 0x2A14C20
        public void CopyToPairs(){} // RVA: 0x2A0FF80
        public void CopyToEntries(){} // RVA: 0x2A10060
        public void CopyToObjects(){} // RVA: 0x2A10190
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A14F50
        public void get_Item(){} // RVA: 0x2A155D0
        public void set_Item(){} // RVA: 0x2A15690
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A15750
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A15950 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A15D70 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A16040
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A16170
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A11610
        public void get_Keys(){} // RVA: 0x2A161E0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A161E0
        public void get_Values(){} // RVA: 0x2A16200
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A16200
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A116A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A16220
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A117B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A11800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A11820
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A162C0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A11B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A161E0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A11C40
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A16200
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A163E0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A164F0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A16780
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A16DC0
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A17540
        public void AcquireAllLocks(){} // RVA: 0x2A17590
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A17680
        public void GetValues(){} // RVA: 0x2A17940
        public void OnSerializing(){} // RVA: 0x2A17C00
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A17CC0
        public void .cctor(){} // RVA: 0x2A17F90
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,object> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,object>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Runtime.Serialization.MemberHolder> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Runtime.Serialization.MemberHolder,System.Reflection.MemberInfo[]>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<System.Type,System.Runtime.Serialization.SerializationEvents> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<System.Type> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<System.Type,System.Runtime.Serialization.SerializationEvents>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<VRC.Udon.Security.IUdonSignatureHolder,byte> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Security.IUdonSignatureHolder> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<VRC.Udon.Security.IUdonSignatureHolder,byte>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A243F0
        public void .ctor(){} // RVA: 0x2A24AF0 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A24750
        public void TryAdd(){} // RVA: 0x2A24EB0
        public void ContainsKey(){} // RVA: 0x2A1EEE0
        public void TryRemove(){} // RVA: 0x2A24FB0
        public void TryRemoveInternal(){} // RVA: 0x2A25030
        public void TryGetValue(){} // RVA: 0x2A1F500
        public void TryGetValueInternal(){} // RVA: 0x2A1F600
        public void TryUpdateInternal(){} // RVA: 0x2A254D0
        public void Clear(){} // RVA: 0x2A259C0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A25C60
        public void ToArray(){} // RVA: 0x2A25F60
        public void CopyToPairs(){} // RVA: 0x2A20530
        public void CopyToEntries(){} // RVA: 0x2A20630
        public void CopyToObjects(){} // RVA: 0x2A20760
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A262B0
        public void get_Item(){} // RVA: 0x2A20F20
        public void set_Item(){} // RVA: 0x2A26910
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A26A10
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A26C50 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A270D0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A273C0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A274F0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A27560
        public void get_Keys(){} // RVA: 0x2A275F0
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A275F0
        public void get_Values(){} // RVA: 0x2A27610
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A27610
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A27630
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A276A0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A277E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A11800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A27890
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A27AB0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A11B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A275F0
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A27BC0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A27610
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A224B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A27CE0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A27F70
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A285D0
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A28D50
        public void AcquireAllLocks(){} // RVA: 0x2A28DA0
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A28E90
        public void GetValues(){} // RVA: 0x2A29150
        public void OnSerializing(){} // RVA: 0x2A29410
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A294D0
        public void .cctor(){} // RVA: 0x2A297A0
    }

    public class ConcurrentDictionary`2
    {
        public Tables<ÏÍÏÎÌÏÎÎÌÌÏÎÍÌÏÍÎÏÎÏÍÌÎ,ÎÎÎÏÎÏÏÎÎÏÎÍÍÏÌÏÍÏÍÏÎÎÌ> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<ÏÍÏÎÌÏÎÎÌÌÏÎÍÌÏÍÎÏÎÏÍÌÎ> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<ÏÍÏÎÌÏÎÎÌÌÏÎÍÌÏÍÎÏÎÏÍÌÎ,ÎÎÎÏÎÏÏÎÎÏÎÍÍÏÌÏÍÏÍÏÎÎÌ>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<int,ÏÍÎÎÏÎÌÍÍÌÍÎÏÎÎÌÌÏÏÏÍÌÍ> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<int> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<int,ÏÍÎÎÏÎÌÍÍÌÍÎÏÎÎÌÌÏÏÏÍÌÍ>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A08470
        public void .ctor(){} // RVA: 0x2A08B30 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A087D0
        public void TryAdd(){} // RVA: 0x2A08EF0
        public void ContainsKey(){} // RVA: 0x2A08FB0
        public void TryRemove(){} // RVA: 0x2A08FE0
        public void TryRemoveInternal(){} // RVA: 0x2A09020
        public void TryGetValue(){} // RVA: 0x2A094D0
        public void TryGetValueInternal(){} // RVA: 0x2A09580
        public void TryUpdateInternal(){} // RVA: 0x2A096D0
        public void Clear(){} // RVA: 0x2A09BC0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A09E60
        public void ToArray(){} // RVA: 0x2A0A160
        public void CopyToPairs(){} // RVA: 0x2A0A450
        public void CopyToEntries(){} // RVA: 0x2A0A540
        public void CopyToObjects(){} // RVA: 0x2A0A670
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A0A870
        public void get_Item(){} // RVA: 0x2A0AEF0
        public void set_Item(){} // RVA: 0x2A0AFA0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A0B060
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A0B260 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A0B670 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A0B940
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A0BA70
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A0BAE0
        public void get_Keys(){} // RVA: 0x2A0BB30
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A0BB30
        public void get_Values(){} // RVA: 0x2A0BB50
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A0BB50
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A0BB70
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A0BBE0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A0BC80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A0BCF0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A0BF10
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A0BB30
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A0C110
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A0BB50
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A0C230
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A0C340
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A0C550
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A0CBB0
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A0D330
        public void AcquireAllLocks(){} // RVA: 0x2A0D380
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A0D470
        public void GetValues(){} // RVA: 0x2A0D720
        public void OnSerializing(){} // RVA: 0x2A0D9E0
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A0DAA0
        public void .cctor(){} // RVA: 0x2A0DD70
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,Transmtn.IAcceptMessages> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,Transmtn.IAcceptMessages>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<VRC.Udon.Security.IUdonSignatureHolder,bool> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<VRC.Udon.Security.IUdonSignatureHolder> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<VRC.Udon.Security.IUdonSignatureHolder,bool>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A1E320
        public void .ctor(){} // RVA: 0x2A1EA20 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A1E680
        public void TryAdd(){} // RVA: 0x2A1EDE0
        public void ContainsKey(){} // RVA: 0x2A1EEE0
        public void TryRemove(){} // RVA: 0x2A1EFE0
        public void TryRemoveInternal(){} // RVA: 0x2A1F060
        public void TryGetValue(){} // RVA: 0x2A1F500
        public void TryGetValueInternal(){} // RVA: 0x2A1F600
        public void TryUpdateInternal(){} // RVA: 0x2A1F750
        public void Clear(){} // RVA: 0x2A1FC40
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A1FEE0
        public void ToArray(){} // RVA: 0x2A201E0
        public void CopyToPairs(){} // RVA: 0x2A20530
        public void CopyToEntries(){} // RVA: 0x2A20630
        public void CopyToObjects(){} // RVA: 0x2A20760
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A208C0
        public void get_Item(){} // RVA: 0x2A20F20
        public void set_Item(){} // RVA: 0x2A21060
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A21160
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A213A0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A21820 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A21B10
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A21C40
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A21CB0
        public void get_Keys(){} // RVA: 0x2A21D40
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A21D40
        public void get_Values(){} // RVA: 0x2A21D60
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A21D60
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A21D80
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A21DF0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A21F30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A11800
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A21FE0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A22210
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A11B60
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A21D40
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A22390
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A21D60
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A224B0
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A22720
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A229B0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A23010
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A23790
        public void AcquireAllLocks(){} // RVA: 0x2A237E0
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A238D0
        public void GetValues(){} // RVA: 0x2A23B90
        public void OnSerializing(){} // RVA: 0x2A23E50
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A23F10
        public void .cctor(){} // RVA: 0x2A241E0
    }

    public class ConcurrentDictionary`2
    {
        public Tables<MeaMod.DNS.Model.DomainName,MeaMod.DNS.Server.Node> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<MeaMod.DNS.Model.DomainName> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<MeaMod.DNS.Model.DomainName,MeaMod.DNS.Server.Node>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<string,string> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<string,string>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

        // ── Methods ──
        public void IsValueWriteAtomic(){} // RVA: 0x2A35A90
        public void .ctor(){} // RVA: 0x2A36110 | overloaded x5
        public void InitializeFromCollection(){} // RVA: 0x2A35DF0
        public void TryAdd(){} // RVA: 0x2A364D0
        public void ContainsKey(){} // RVA: 0x2A365D0
        public void TryRemove(){} // RVA: 0x2A366D0
        public void TryRemoveInternal(){} // RVA: 0x2A36750
        public void TryGetValue(){} // RVA: 0x2A36C00
        public void TryGetValueInternal(){} // RVA: 0x2A36D00
        public void TryUpdateInternal(){} // RVA: 0x2A36E50
        public void Clear(){} // RVA: 0x2A37340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(){} // RVA: 0x2A375E0
        public void ToArray(){} // RVA: 0x2A37840
        public void CopyToPairs(){} // RVA: 0x2A37A60
        public void CopyToEntries(){} // RVA: 0x2A37B80
        public void CopyToObjects(){} // RVA: 0x2A37C80
        public void GetEnumerator(){} // RVA: 0x2A0A7D0
        public void TryAddInternal(){} // RVA: 0x2A37DE0
        public void get_Item(){} // RVA: 0x2A38460
        public void set_Item(){} // RVA: 0x2A385B0
        public void ThrowKeyNotFoundException(){} // RVA: 0x29FA9C0
        public void ThrowKeyNullException(){} // RVA: 0x29FAA40
        public void get_Count(){} // RVA: 0x2A386B0
        public void GetCountInternal(){} // RVA: 0x29FAB40
        public void GetOrAdd(){} // RVA: 0x2A388F0 | overloaded x3
        public void AddOrUpdate(){} // RVA: 0x2A38DB0 | overloaded x2
        public void get_IsEmpty(){} // RVA: 0x2A390D0
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Add(){} // RVA: 0x2A39200
        public void System.Collections.Generic.IDictionary<TKey,TValue>.Remove(){} // RVA: 0x2A39270
        public void get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys(){} // RVA: 0x2A39300
        public void get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(){} // RVA: 0x2A39340
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(){} // RVA: 0x2A393B0
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(){} // RVA: 0x2A39500
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A0BCD0
        public void System.Collections.IDictionary.Add(){} // RVA: 0x2A395B0
        public void System.Collections.IDictionary.Contains(){} // RVA: 0x2A397D0
        public void System.Collections.IDictionary.GetEnumerator(){} // RVA: 0x2A0C030
        public void System.Collections.IDictionary.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IDictionary.get_Keys(){} // RVA: 0x2A39300
        public void System.Collections.IDictionary.Remove(){} // RVA: 0x2A398E0
        public void System.Collections.IDictionary.get_Values(){} // RVA: 0x2A39320
        public void System.Collections.IDictionary.get_Item(){} // RVA: 0x2A39A10
        public void System.Collections.IDictionary.set_Item(){} // RVA: 0x2A39B90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A39DB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void GrowTable(){} // RVA: 0x2A3A340
        public void GetBucket(){} // RVA: 0x29FD0C0
        public void GetBucketAndLockNo(){} // RVA: 0x29FD0D0
        public void get_DefaultConcurrencyLevel(){} // RVA: 0x2A3AAC0
        public void AcquireAllLocks(){} // RVA: 0x2A3AB10
        public void AcquireLocks(){} // RVA: 0x29FD230
        public void ReleaseLocks(){} // RVA: 0x29FD390
        public void GetKeys(){} // RVA: 0x2A3AC00
        public void GetValues(){} // RVA: 0x2A3AEC0
        public void OnSerializing(){} // RVA: 0x2A3B180
        public void OnSerialized(){} // RVA: 0x29FDA70
        public void OnDeserialized(){} // RVA: 0x2A3B240
        public void .cctor(){} // RVA: 0x2A3B510
    }

    public class ConcurrentDictionary`2
    {
        public Tables<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo> _tables; // 0x10
        public System.Collections.Generic.IEqualityComparer`1<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>> _comparer; // 0x18
        public bool _growLockArray; // 0x20
        public int _budget; // 0x24
        public System.Collections.Generic.KeyValuePair`2<Newtonsoft.Json.Utilities.StructMultiKey`2<System.Type,Newtonsoft.Json.Serialization.NamingStrategy>,Newtonsoft.Json.Utilities.EnumInfo>[] _serializationArray; // 0x28
        public int _serializationConcurrencyLevel; // 0x30
        public int _serializationCapacity; // 0x34
        public int DefaultCapacity;
        public int MaxLockNumber;
        public bool s_isValueWriteAtomic;

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
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAllPromise`1<...>,Awaiter<...>,int>> _tail; // 0x18

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

    public class ConcurrentQueue`1
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock;
        public Segment<T> _tail;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x283FA0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0xDE40
        public void get_IsEmpty(){} // RVA: 0xDBE0
        public void ToArray(){} // RVA: 0xCD60
        public void get_Count(){} // RVA: 0xD840
        public void GetCount(){} // RVA: 0x283FA0 | overloaded x2
        public void CopyTo(){} // RVA: 0x2BAA0
        public void GetEnumerator(){} // RVA: 0xCD60
        public void SnapForObservation(){} // RVA: 0x2F9F0
        public void GetItemWhenAvailable(){} // RVA: 0x283FA0
        public void Enumerate(){} // RVA: 0x283FA0
        public void Enqueue(){} // RVA: 0x283FA0
        public void EnqueueSlow(){} // RVA: 0x283FA0
        public void TryDequeue(){} // RVA: 0xDE40
        public void TryDequeueSlow(){} // RVA: 0xDE40
        public void TryPeek(){}
        public void Clear(){} // RVA: 0x24A50
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<ÎÎÌÎÎÏÎÏÏÎÏÍÍÌÍÏÌÍÍÌÎÏÎ> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyPromise`2<...,...>,Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<DebugMessage> _tail; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2AAA560
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2AAA720
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A9B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x2AAA820
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x2AAA8C0
        public void get_IsEmpty(){} // RVA: 0x2AAA8E0
        public void ToArray(){} // RVA: 0x2AAA9B0
        public void get_Count(){} // RVA: 0x2AAAE20
        public void GetCount(){} // RVA: 0x2A9BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x2AAB190
        public void GetEnumerator(){} // RVA: 0x2AAB6B0
        public void SnapForObservation(){} // RVA: 0x2AAB750
        public void GetItemWhenAvailable(){} // RVA: 0x2AAB9F0
        public void Enumerate(){} // RVA: 0x2A9C6F0
        public void Enqueue(){} // RVA: 0x2AABB50
        public void EnqueueSlow(){} // RVA: 0x2AABBE0
        public void TryDequeue(){} // RVA: 0x2AAC0C0
        public void TryDequeueSlow(){} // RVA: 0x2AAC150
        public void TryPeek(){} // RVA: 0x2AAC380
        public void Clear(){} // RVA: 0x2AAC450
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Photon.Client.NCommand> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Replica> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAllPromise,Awaiter>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAllPromise`1<...>,Awaiter<...>,int>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<System.IDisposable> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`1<Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyPromise`2<...,...>,Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyPromise`2<...,...>,Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyLRPromise`1<...>,Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyLRPromise`1<...>,Awaiter>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`3<WhenAnyPromise,Awaiter,int>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<ÎÍÎÍÍÏÍÏÍÍÌÌÌÏÍÎÍÏÌÏÍÎÍ> _tail; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2AAC6A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2AAC860
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A9B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x2AAC960
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x2AAC980
        public void get_IsEmpty(){} // RVA: 0x2AAC9A0
        public void ToArray(){} // RVA: 0x2AACA70
        public void get_Count(){} // RVA: 0x2AACEC0
        public void GetCount(){} // RVA: 0x2A9BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x2AAD230
        public void GetEnumerator(){} // RVA: 0x2AAD660
        public void SnapForObservation(){} // RVA: 0x2AAD700
        public void GetItemWhenAvailable(){} // RVA: 0x2AAD9A0
        public void Enumerate(){} // RVA: 0x2A9E7D0
        public void Enqueue(){} // RVA: 0x2AADB00
        public void EnqueueSlow(){} // RVA: 0x2AADB80
        public void TryDequeue(){} // RVA: 0x2AAE060
        public void TryDequeueSlow(){} // RVA: 0x2AAE0F0
        public void TryPeek(){} // RVA: 0x2AAE320
        public void Clear(){} // RVA: 0x2AAE3E0
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<ÏÏÌÌÌÎÍÏÍÎÍÎÏÏÏÎÌÎÏÌÌÍÎ> _tail; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2AA81C0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2AA8380
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A9B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x2AA8480
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x2AA84F0
        public void get_IsEmpty(){} // RVA: 0x2AA8510
        public void ToArray(){} // RVA: 0x2AA85F0
        public void get_Count(){} // RVA: 0x2AA8AA0
        public void GetCount(){} // RVA: 0x2A9BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x2AA8E10
        public void GetEnumerator(){} // RVA: 0x2AA92A0
        public void SnapForObservation(){} // RVA: 0x2AA9340
        public void GetItemWhenAvailable(){} // RVA: 0x2AA95E0
        public void Enumerate(){} // RVA: 0x2AA9780
        public void Enqueue(){} // RVA: 0x2AA9910
        public void EnqueueSlow(){} // RVA: 0x2AA9A20
        public void TryDequeue(){} // RVA: 0x2AA9F50
        public void TryDequeueSlow(){} // RVA: 0x2AA9FE0
        public void TryPeek(){} // RVA: 0x2AAA220
        public void Clear(){} // RVA: 0x2AAA310
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`1<Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<System.ValueTuple`2<...<...>,...<...>>> _tail; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2A9AEA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2A9B060
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2A9B160
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x2A9B1B0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x2A9B250
        public void get_IsEmpty(){} // RVA: 0x2A9B2F0
        public void ToArray(){} // RVA: 0x2A9B3C0
        public void get_Count(){} // RVA: 0x2A9B830
        public void GetCount(){} // RVA: 0x2A9BC40 | overloaded x2
        public void CopyTo(){} // RVA: 0x2A9BD90
        public void GetEnumerator(){} // RVA: 0x2A9C250
        public void SnapForObservation(){} // RVA: 0x2A9C2F0
        public void GetItemWhenAvailable(){} // RVA: 0x2A9C590
        public void Enumerate(){} // RVA: 0x2A9C6F0
        public void Enqueue(){} // RVA: 0x2A9C870
        public void EnqueueSlow(){} // RVA: 0x2A9C900
        public void TryDequeue(){} // RVA: 0x2A9CDE0
        public void TryDequeueSlow(){} // RVA: 0x2A9CE70
        public void TryPeek(){} // RVA: 0x2A9D0A0
        public void Clear(){} // RVA: 0x2A9D170
    }

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<System.Threading.Tasks.TaskCompletionSource`1<bool>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`1<Awaiter>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyPromise`2<...,...>,Awaiter<...>>> _tail; // 0x18

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

    public class ConcurrentQueue`1 : System.Collections.Concurrent
    {
        public int InitialSegmentLength;
        public int MaxSegmentLength;
        public object _crossSegmentLock; // 0x10
        public Segment<Cysharp.Threading.Tasks.Internal.StateTuple`2<WhenAnyPromise`2<...,...>,Awaiter<...>>> _tail; // 0x18

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
        public Node<T> _head;
        public int BACKOFF_MAX_YIELDS;

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

    public class ConcurrentStack`1
    {
        public Node<System.Threading.Tasks.TaskCompletionSource`1<bool>> _head; // 0x10
        public int BACKOFF_MAX_YIELDS;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_Count(){} // RVA: 0x2AAFA10
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2AAFA30
        public void Push(){} // RVA: 0x2AAFB10
        public void PushCore(){} // RVA: 0x2AAFCF0
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryAdd(){} // RVA: 0x2AAFED0
        public void TryPop(){} // RVA: 0x2AAFEF0
        public void TryPopCore(){} // RVA: 0x2AB0120 | overloaded x2
        public void System.Collections.Concurrent.IProducerConsumerCollection<T>.TryTake(){} // RVA: 0x2AB0520
        public void ToArray(){} // RVA: 0x2AB0540
        public void ToList(){} // RVA: 0x2AB05E0 | overloaded x2
        public void GetEnumerator(){} // RVA: 0x2AB0780 | overloaded x2
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x2AB0820
    }

}