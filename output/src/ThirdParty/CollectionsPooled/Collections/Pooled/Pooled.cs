// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.CollectionsPooled.Collections.Pooled
// Classes: 8
// Methods: 107

namespace ThirdParty.CollectionsPooled.Collections.Pooled
{
    public class ClearModeUtil : Object
    {
        // ── Methods ──
        public void ShouldClear(){} // RVA: 0x7FFAC2C5A7A0
    }

    public class HashHelpers : Object
    {
        public int[] Primes;

        // ── Methods ──
        public void IsPrime(){} // RVA: 0x7FFAC487E2D0
        public void GetPrime(){} // RVA: 0x7FFAC487E380
        public void ExpandPrime(){} // RVA: 0x7FFAC487E5A0
        public void .cctor(){} // RVA: 0x7FFAC487E620
    }

    public class ICollectionDebugView`1 : Object
    {
    }

    public class PooledList`1 : Object
    {
        public System.Buffers.ArrayPool`1<T> Capacity;
        public object Count;
        public T[] System.Collections.IList.IsFixedSize;
        public int System.Collections.Generic.ICollection<T>.IsReadOnly;
        public int System.Collections.IList.IsReadOnly;
        public bool System.Collections.ICollection.Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x2
        public void set_Capacity(){} // RVA: 0x7FFAC2C70ED0
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void get_Item(){} // RVA: 0x7FFAC2E8DC40
        public void set_Item(){} // RVA: 0x7FFAC2E8DC40
        public void IsCompatibleObject(){} // RVA: 0x7FFAC2C59DE0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFAC2C67DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFAC2C72BC0
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void AddWithResize(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IList.Add(){} // RVA: 0x7FFAC2C5E6B0
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFAC2C59F60
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void EnsureCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void IndexOf(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFAC2C5E6B0
        public void Insert(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFAC2C72BC0
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFAC2C70A40
        public void RemoveAt(){} // RVA: 0x7FFAC2C70ED0
        public void ReturnArray(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC2C70A40
    }

    public class PooledSet`1 : Object
    {
        public System.Buffers.ArrayPool`1<int> Count;
        public System.Buffers.ArrayPool`1<Slot<T>> System.Collections.Generic.ICollection<T>.IsReadOnly;
        public int[] _buckets;
        public Slot<T>[] _slots;
        public int _size;
        public int _count;
        public int _lastIndex;
        public int _freeList;
        public System.Collections.Generic.IEqualityComparer`1<T> _comparer;
        public int _version;
        public bool _clearOnFree;
        public System.Runtime.Serialization.SerializationInfo _siInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x3
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFAC2E8DC40
        public void Clear(){} // RVA: 0x7FFAC2C70980
        public void Contains(){} // RVA: 0x7FFAC2E8DC40
        public void CopyTo(){} // RVA: 0x7FFAC2C70A40 | overloaded x3
        public void Remove(){} // RVA: 0x7FFAC2E8DC40
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void GetEnumerator(){} // RVA: 0x7FFAC2E8DC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFAC2C70A40
        public void Add(){} // RVA: 0x7FFAC2E8DC40
        public void Initialize(){} // RVA: 0x7FFAC2C600D0
        public void IncreaseCapacity(){} // RVA: 0x7FFAC2C70980
        public void SetCapacity(){} // RVA: 0x7FFAC2C70ED0
        public void ReturnArrays(){} // RVA: 0x7FFAC2C70980
        public void AddIfNotPresent(){} // RVA: 0x7FFAC2E8DC40
        public void InternalGetHashCode(){} // RVA: 0x7FFAC2E8DC40
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

    public class PooledStack`1 : Object
    {
        public System.Buffers.ArrayPool`1<T> Count;
        public object System.Collections.ICollection.IsSynchronized;
        public T[] System.Collections.ICollection.SyncRoot;
        public int _size;
        public int _version;
        public bool _clearOnFree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C72BC0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC2C59960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFAC2C59D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFAC2C77970
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC2C58E90
        public void Pop(){} // RVA: 0x7FFAC2E8DC40
        public void Push(){} // RVA: 0x7FFAC2E8DC40
        public void PushWithResize(){} // RVA: 0x7FFAC2E8DC40
        public void ThrowForEmptyStack(){} // RVA: 0x7FFAC2C70980
        public void ReturnArray(){} // RVA: 0x7FFAC2C70A40
        public void Dispose(){} // RVA: 0x7FFAC2C71060 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFAC2C70A40
    }

    public class StackDebugView`1 : Object
    {
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7FFAC487E700
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x7FFAC2E8DC40
        public void ThrowArgumentException(){} // RVA: 0x7FFAC487E760 | overloaded x2
        public void GetArgumentNullException(){} // RVA: 0x7FFAC487E790
        public void ThrowArgumentNullException(){} // RVA: 0x7FFAC487E830
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFAC487E8C0 | overloaded x2
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFAC487E8F0
        public void ThrowSerializationException(){} // RVA: 0x7FFAC487E920
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x7FFAC487E980
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x7FFAC487E9D0
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x7FFAC487EA20
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x7FFAC487EA70
        public void GetArgumentException(){} // RVA: 0x7FFAC487ED10 | overloaded x2
        public void GetInvalidOperationException(){} // RVA: 0x7FFAC487EB30
        public void GetWrongValueTypeArgumentException(){} // RVA: 0x7FFAC487EBA0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFAC487EC80
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x7FFAC2C76370
        public void GetArgumentName(){} // RVA: 0x7FFAC487ED90
        public void GetResourceString(){} // RVA: 0x7FFAC487F600
    }

}