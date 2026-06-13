// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Concurrent
// Classes: 3
// Methods: 40

namespace ThirdParty.DotNet.System.Collections.Concurrent
{
    public class BlockingCollectionDebugView`1
    {
    }

    public class BlockingCollection`1
    {
        public System.Collections.Concurrent.IProducerConsumerCollection`1<T> _collection;
        public int _boundedCapacity;
        public int NON_BOUNDED;
        public System.Threading.SemaphoreSlim _freeNodes;
        public System.Threading.SemaphoreSlim _occupiedNodes;

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

    public class BlockingCollection`1 : System.Collections.Generic
    {
        public System.Collections.Concurrent.IProducerConsumerCollection`1<System.ValueTuple`2<...<...>,...<...>>> _collection; // 0x10
        public int _boundedCapacity; // 0x18
        public int NON_BOUNDED;
        public System.Threading.SemaphoreSlim _freeNodes; // 0x20
        public System.Threading.SemaphoreSlim _occupiedNodes; // 0x28

        // ── Methods ──
        public void get_IsAddingCompleted(){} // RVA: 0x57250C0
        public void get_IsCompleted(){} // RVA: 0x5725100
        public void get_Count(){} // RVA: 0x5725190
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x57251D0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x29F4BF0
        public void .ctor(){} // RVA: 0x5725440 | overloaded x2
        public void Initialize(){} // RVA: 0x5725510
        public void Add(){} // RVA: 0x5725800
        public void TryAddWithNoTimeValidation(){} // RVA: 0x5725840
        public void TryTake(){} // RVA: 0x5725EF0
        public void TryTakeWithNoTimeValidation(){} // RVA: 0x5726020
        public void CancelWaitingConsumers(){} // RVA: 0x5726620
        public void Dispose(){} // RVA: 0x5726700 | overloaded x2
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x5726750
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x5726A90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x5726B00
        public void ValidateMillisecondsTimeout(){} // RVA: 0x5726B50
        public void CheckDisposed(){} // RVA: 0x5726C50
    }

}