// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.CollectionsPooled.Collections.Pooled
// Classes: 8
// Methods: 131

namespace ThirdParty.CollectionsPooled.Collections.Pooled
{
    public class ClearModeUtil : Object
    {
        // ── Methods ──
        public void ShouldClear(){} // RVA: 0x30273E0
    }

    public class HashHelpers : Object
    {
        public object Primes;

        // ── Methods ──
        public void IsPrime(){} // RVA: 0x26071F0
        public void GetPrime(){} // RVA: 0x26072A0
        public void ExpandPrime(){} // RVA: 0x26074C0
        public void .cctor(){} // RVA: 0x2607540
    }

    public class PooledList`1 : Object
    {
        public object _pool;
        public object _syncRoot;
        public object _items;
        public object _size;
        public object _version;
        public object _clearOnFree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x895750
        public void set_Capacity(){} // RVA: 0x8944F0
        public void get_Count(){} // RVA: 0x87C130
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x87D280
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x87D280
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x87C130
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void get_Item(){} // RVA: 0xA94080
        public void set_Item(){} // RVA: 0xA94080
        public void IsCompatibleObject(){} // RVA: 0x87D390
        public void System.Collections.IList.get_Item(){} // RVA: 0x87C160
        public void System.Collections.IList.set_Item(){} // RVA: 0x895750
        public void Add(){} // RVA: 0xA94080
        public void AddWithResize(){} // RVA: 0xA94080
        public void System.Collections.IList.Add(){} // RVA: 0x87D050
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void System.Collections.IList.Contains(){} // RVA: 0x87D350
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x899290
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void EnsureCapacity(){} // RVA: 0x8944F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void IndexOf(){} // RVA: 0xA94080
        public void System.Collections.IList.IndexOf(){} // RVA: 0x87D050
        public void Insert(){} // RVA: 0xA94080
        public void System.Collections.IList.Insert(){} // RVA: 0x895750
        public void Remove(){} // RVA: 0xA94080
        public void System.Collections.IList.Remove(){} // RVA: 0x894320
        public void RemoveAt(){} // RVA: 0x8944F0
        public void ReturnArray(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894750
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x894320
    }

    public class PooledSet`1 : Object
    {
        public object s_bucketPool;
        public object s_slotPool;
        public object _buckets;
        public object _slots;
        public object _size;
        public object _count;
        public object _lastIndex;
        public object _freeList;
        public object _comparer;
        public object _version;
        public object _clearOnFree;
        public object _siInfo;

        // ── Methods ──
        public void Add(){} // RVA: 0x486A5C0
        public void Contains(){} // RVA: 0x486A630
        public void GetEnumerator(){} // RVA: 0x3F44AB0
        public void .ctor(){} // RVA: 0x486A4E0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x486A5C0
        public void Clear(){} // RVA: 0x486A5E0
        public void CopyTo(){} // RVA: 0x486B6A0
        public void Remove(){} // RVA: 0x486A800
        public void get_Count(){} // RVA: 0x15AF000
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x486AA80
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x486AA80
        public void GetObjectData(){} // RVA: 0x486AB40
        public void OnDeserialization(){} // RVA: 0x486AEB0
        public void Initialize(){} // RVA: 0x486B7C0
        public void IncreaseCapacity(){} // RVA: 0x486B9D0
        public void SetCapacity(){} // RVA: 0x486BA70
        public void ReturnArrays(){} // RVA: 0x486BD60
        public void AddIfNotPresent(){} // RVA: 0x486BFA0
        public void InternalGetHashCode(){} // RVA: 0x3F72080
        public void Dispose(){} // RVA: 0x486C3A0
        public void .cctor(){} // RVA: 0x486C3E0
    }

    public class PooledSet`1 : Object
    {
        public object s_bucketPool;
        public object s_slotPool;
        public object _buckets;
        public object _slots;
        public object _size;
        public object _count;
        public object _lastIndex;
        public object _freeList;
        public object _comparer;
        public object _version;
        public object _clearOnFree;
        public object _siInfo;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8943B0
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0xA94080
        public void Clear(){} // RVA: 0x894290
        public void Contains(){} // RVA: 0xA94080
        public void CopyTo(){} // RVA: 0x89B9B0
        public void Remove(){} // RVA: 0xA94080
        public void get_Count(){} // RVA: 0x87C130
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x87D280
        public void GetEnumerator(){} // RVA: 0xA94080
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void GetObjectData(){} // RVA: 0x8943B0
        public void OnDeserialization(){} // RVA: 0x894320
        public void Add(){} // RVA: 0xA94080
        public void Initialize(){} // RVA: 0x881C20
        public void IncreaseCapacity(){} // RVA: 0x894290
        public void SetCapacity(){} // RVA: 0x8944F0
        public void ReturnArrays(){} // RVA: 0x894290
        public void AddIfNotPresent(){} // RVA: 0xA94080
        public void InternalGetHashCode(){} // RVA: 0xA94080
        public void Dispose(){} // RVA: 0x894750
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class PooledStack`1 : Object
    {
        public object _pool;
        public object _syncRoot;
        public object _array;
        public object _size;
        public object _version;
        public object _clearOnFree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x895750
        public void get_Count(){} // RVA: 0x87C130
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x87D280
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x87C0A0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x899290
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x87C0A0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x87C0A0
        public void Pop(){} // RVA: 0xA94080
        public void Push(){} // RVA: 0xA94080
        public void PushWithResize(){} // RVA: 0xA94080
        public void ThrowForEmptyStack(){} // RVA: 0x894290
        public void ReturnArray(){} // RVA: 0x894320
        public void Dispose(){} // RVA: 0x894750
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x894320
    }

    public class PooledStack`1 : Object
    {
        public object _pool;
        public object _syncRoot;
        public object _array;
        public object _size;
        public object _version;
        public object _clearOnFree;

        // ── Methods ──
        public void Pop(){} // RVA: 0x486F8C0
        public void Push(){} // RVA: 0x486F9D0
        public void .ctor(){} // RVA: 0x486F4B0
        public void get_Count(){} // RVA: 0x1065D50
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x486F630
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x486F6E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x486F7F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x486F7F0
        public void PushWithResize(){} // RVA: 0x486FA90
        public void ThrowForEmptyStack(){} // RVA: 0x486FBD0
        public void ReturnArray(){} // RVA: 0x486FC20
        public void Dispose(){} // RVA: 0x486FD60
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x486FDC0
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x2607620
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0xA94080
        public void ThrowArgumentException(){} // RVA: 0x2607680
        public void GetArgumentNullException(){} // RVA: 0x26076B0
        public void ThrowArgumentNullException(){} // RVA: 0x2607750
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x26077E0
        public void ThrowInvalidOperationException(){} // RVA: 0x2607810
        public void ThrowSerializationException(){} // RVA: 0x2607840
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x26078A0
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x26078F0
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x2607940
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x2607990
        public void GetArgumentException(){} // RVA: 0x2607C30
        public void GetInvalidOperationException(){} // RVA: 0x2607A50
        public void GetWrongValueTypeArgumentException(){} // RVA: 0x2607AC0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x2607BA0
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x89AB50
        public void GetArgumentName(){} // RVA: 0x2607CB0
        public void GetResourceString(){} // RVA: 0x2608520
    }

}