// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.CollectionsPooled.Collections.Pooled
// Classes: 8
// Methods: 107

namespace ThirdParty.CollectionsPooled.Collections.Pooled
{
    public class ClearModeUtil : Object
    {
        // ── Methods ──
        public void ShouldClear(){} // RVA: 0x7FFE80E2FBF0
    }

    public class HashHelpers : Object
    {
        // ── Methods ──
        public void IsPrime(){} // RVA: 0x7FFE82AE6650
        public void GetPrime(){} // RVA: 0x7FFE82AE6700
        public void ExpandPrime(){} // RVA: 0x7FFE82AE6920
        public void .cctor(){} // RVA: 0x7FFE82AE69A0
    }

    public class ICollectionDebugView`1 : Object
    {
    }

    public class PooledList`1 : Object
    {
        public System.Buffers.ArrayPool`1<T> _pool;
        public object _syncRoot;
        public T[] _items;
        public int _size;
        public int _version;
        public bool _clearOnFree;
        public object field_6; // 0x1
        public object field_7; // 0x2
        public object field_8; // 0x3
        public object field_9; // 0x4

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x2
        public void set_Capacity(){} // RVA: 0x7FFE80E46530
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void get_Item(){} // RVA: 0x7FFE810A1420
        public void set_Item(){} // RVA: 0x7FFE810A1420
        public void IsCompatibleObject(){} // RVA: 0x7FFE80E2F230
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFE80E3D230
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFE80E48220
        public void Add(){} // RVA: 0x7FFE810A1420
        public void AddWithResize(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.Add(){} // RVA: 0x7FFE80E33B00
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFE80E2F3B0
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void EnsureCapacity(){} // RVA: 0x7FFE80E46530
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void IndexOf(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFE80E33B00
        public void Insert(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFE80E48220
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFE80E460A0
        public void RemoveAt(){} // RVA: 0x7FFE80E46530
        public void ReturnArray(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE80E460A0
    }

    public class PooledSet`1 : Object
    {
        public System.Buffers.ArrayPool`1<int> s_bucketPool;
        public System.Buffers.ArrayPool`1<Slot<T>> s_slotPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x3
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFE810A1420
        public void Clear(){} // RVA: 0x7FFE80E45FE0
        public void Contains(){} // RVA: 0x7FFE810A1420
        public void CopyTo(){} // RVA: 0x7FFE80E460A0 | overloaded x3
        public void Remove(){} // RVA: 0x7FFE810A1420
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFE80E2F150
        public void GetEnumerator(){} // RVA: 0x7FFE810A1420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFE80E460A0
        public void Add(){} // RVA: 0x7FFE810A1420
        public void Initialize(){} // RVA: 0x7FFE80E35520
        public void IncreaseCapacity(){} // RVA: 0x7FFE80E45FE0
        public void SetCapacity(){} // RVA: 0x7FFE80E46530
        public void ReturnArrays(){} // RVA: 0x7FFE80E45FE0
        public void AddIfNotPresent(){} // RVA: 0x7FFE810A1420
        public void InternalGetHashCode(){} // RVA: 0x7FFE810A1420
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

    public class PooledStack`1 : Object
    {
        public System.Buffers.ArrayPool`1<T> _pool;
        public object _syncRoot;
        public T[] _array;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E48220 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE80E2EDB0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFE80E2F150
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFE80E4D070
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE80E2E2E0
        public void Pop(){} // RVA: 0x7FFE810A1420
        public void Push(){} // RVA: 0x7FFE810A1420
        public void PushWithResize(){} // RVA: 0x7FFE810A1420
        public void ThrowForEmptyStack(){} // RVA: 0x7FFE80E45FE0
        public void ReturnArray(){} // RVA: 0x7FFE80E460A0
        public void Dispose(){} // RVA: 0x7FFE80E466C0 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFE80E460A0
    }

    public class StackDebugView`1 : Object
    {
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7FFE82AE6A80
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x7FFE810A1420
        public void ThrowArgumentException(){} // RVA: 0x7FFE82AE6AE0 | overloaded x2
        public void GetArgumentNullException(){} // RVA: 0x7FFE82AE6B10
        public void ThrowArgumentNullException(){} // RVA: 0x7FFE82AE6BB0
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFE82AE6C40 | overloaded x2
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFE82AE6C70
        public void ThrowSerializationException(){} // RVA: 0x7FFE82AE6CA0
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x7FFE82AE6D00
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x7FFE82AE6D50
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x7FFE82AE6DA0
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x7FFE82AE6DF0
        public void GetArgumentException(){} // RVA: 0x7FFE82AE7090 | overloaded x2
        public void GetInvalidOperationException(){} // RVA: 0x7FFE82AE6EB0
        public void GetWrongValueTypeArgumentException(){} // RVA: 0x7FFE82AE6F20
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFE82AE7000
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x7FFE80E4BA70
        public void GetArgumentName(){} // RVA: 0x7FFE82AE7110
        public void GetResourceString(){} // RVA: 0x7FFE82AE7980
    }

}