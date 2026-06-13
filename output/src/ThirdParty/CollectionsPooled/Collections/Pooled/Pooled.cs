// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.CollectionsPooled.Collections.Pooled
// Classes: 11
// Methods: 187

namespace ThirdParty.CollectionsPooled.Collections.Pooled
{
    public class ClearModeUtil
    {
        // ── Methods ──
        public void ShouldClear(){} // RVA: 0xE680
    }

    public class HashHelpers
    {
        // ── Methods ──
        public void IsPrime(){} // RVA: 0x1D587D0
        public void GetPrime(){} // RVA: 0x1D58880
        public void ExpandPrime(){} // RVA: 0x1D58AA0
        public void .cctor(){} // RVA: 0x1D58B20
    }

    public class ICollectionDebugView`1
    {
    }

    public class PooledList`1
    {
        public System.Buffers.ArrayPool`1<T> _pool;
        public object _syncRoot;
        public T[] _items;
        public int _size;
        public int _version;
        public bool _clearOnFree;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x2
        public void set_Capacity(){} // RVA: 0x24FA0
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xDBE0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void get_Item(){} // RVA: 0x283FA0
        public void set_Item(){} // RVA: 0x283FA0
        public void IsCompatibleObject(){} // RVA: 0xDCC0
        public void System.Collections.IList.get_Item(){} // RVA: 0x1BCC0
        public void System.Collections.IList.set_Item(){} // RVA: 0x26C40
        public void Add(){} // RVA: 0x283FA0
        public void AddWithResize(){} // RVA: 0x283FA0
        public void System.Collections.IList.Add(){} // RVA: 0x12590
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void System.Collections.IList.Contains(){} // RVA: 0xDE40
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void EnsureCapacity(){} // RVA: 0x24FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void IndexOf(){} // RVA: 0x283FA0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x12590
        public void Insert(){} // RVA: 0x283FA0
        public void System.Collections.IList.Insert(){} // RVA: 0x26C40
        public void Remove(){} // RVA: 0x283FA0
        public void System.Collections.IList.Remove(){} // RVA: 0x24B10
        public void RemoveAt(){} // RVA: 0x24FA0
        public void ReturnArray(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x24B10
    }

    public class PooledList`1
    {
        public System.Buffers.ArrayPool`1<string> _pool; // 0x10
        public object _syncRoot; // 0x18
        public string[] _items; // 0x20
        public int _size; // 0x28
        public int _version; // 0x2C
        public bool _clearOnFree; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DF7720 | overloaded x2
        public void set_Capacity(){} // RVA: 0x3DF7870
        public void get_Count(){} // RVA: 0x791DC0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x2DD320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x791DC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3DF7960
        public void get_Item(){} // RVA: 0x3DF7A10
        public void set_Item(){} // RVA: 0x3DF7A50
        public void IsCompatibleObject(){} // RVA: 0x3DF7A90
        public void System.Collections.IList.get_Item(){} // RVA: 0x3DF7A10
        public void System.Collections.IList.set_Item(){} // RVA: 0x3DF7AF0
        public void Add(){} // RVA: 0x3DF7C00
        public void AddWithResize(){} // RVA: 0x3DF7C60
        public void System.Collections.IList.Add(){} // RVA: 0x3DF7CD0
        public void Clear(){} // RVA: 0x3DF7E10
        public void Contains(){} // RVA: 0x3DF7E40
        public void System.Collections.IList.Contains(){} // RVA: 0x3DF7EA0
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x34AF7B0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3DF7FE0
        public void EnsureCapacity(){} // RVA: 0x3DF8040
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3DF8170
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DF8170
        public void IndexOf(){} // RVA: 0x3DF8230
        public void System.Collections.IList.IndexOf(){} // RVA: 0x3DF8260
        public void Insert(){} // RVA: 0x3DF8380
        public void System.Collections.IList.Insert(){} // RVA: 0x3DF8440
        public void Remove(){} // RVA: 0x3DF85E0
        public void System.Collections.IList.Remove(){} // RVA: 0x3DF86A0
        public void RemoveAt(){} // RVA: 0x3DF8830
        public void ReturnArray(){} // RVA: 0x3DF88B0
        public void Dispose(){} // RVA: 0x3DF8A00 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x3DF8A30
    }

    public class PooledSet`1
    {
        public System.Buffers.ArrayPool`1<int> s_bucketPool;
        public System.Buffers.ArrayPool`1<Slot<T>> s_slotPool;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x3
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x283FA0
        public void Clear(){} // RVA: 0x24A50
        public void Contains(){} // RVA: 0x283FA0
        public void CopyTo(){} // RVA: 0x24B10 | overloaded x3
        public void Remove(){} // RVA: 0x283FA0
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xDBE0
        public void GetEnumerator(){} // RVA: 0x283FA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x24B10
        public void Add(){} // RVA: 0x283FA0
        public void Initialize(){} // RVA: 0x13FB0
        public void IncreaseCapacity(){} // RVA: 0x24A50
        public void SetCapacity(){} // RVA: 0x24FA0
        public void ReturnArrays(){} // RVA: 0x24A50
        public void AddIfNotPresent(){} // RVA: 0x283FA0
        public void InternalGetHashCode(){} // RVA: 0x283FA0
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void .cctor(){} // RVA: 0x24A80
    }

    public class PooledSet`1
    {
        public System.Buffers.ArrayPool`1<int> s_bucketPool;
        public System.Buffers.ArrayPool`1<Slot<string>> s_slotPool; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DFB240 | overloaded x3
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x3DFB320
        public void Clear(){} // RVA: 0x3DFB340
        public void Contains(){} // RVA: 0x3DFB390
        public void CopyTo(){} // RVA: 0x3DFC370 | overloaded x3
        public void Remove(){} // RVA: 0x3DFB560
        public void get_Count(){} // RVA: 0xCEF5B0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x2DD320
        public void GetEnumerator(){} // RVA: 0x34CCED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3DFB7E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3DFB7E0
        public void GetObjectData(){} // RVA: 0x3DFB8A0
        public void OnDeserialization(){} // RVA: 0x3DFBBD0
        public void Add(){} // RVA: 0x3DFB320
        public void Initialize(){} // RVA: 0x3DFC490
        public void IncreaseCapacity(){} // RVA: 0x3DFC6A0
        public void SetCapacity(){} // RVA: 0x3DFC740
        public void ReturnArrays(){} // RVA: 0x3DFCA40
        public void AddIfNotPresent(){} // RVA: 0x3DFCC80
        public void InternalGetHashCode(){} // RVA: 0x34FAC70
        public void Dispose(){} // RVA: 0x3DFD080 | overloaded x2
        public void .cctor(){} // RVA: 0x3DFD0C0
    }

    public class PooledStack`1
    {
        public System.Buffers.ArrayPool`1<T> _pool;
        public object _syncRoot;
        public T[] _array;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x26C40 | overloaded x2
        public void get_Count(){} // RVA: 0xD840
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xDBE0
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0xCD60
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x2BAA0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0xCD60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0xCD60
        public void Pop(){} // RVA: 0x283FA0
        public void Push(){} // RVA: 0x283FA0
        public void PushWithResize(){} // RVA: 0x283FA0
        public void ThrowForEmptyStack(){} // RVA: 0x24A50
        public void ReturnArray(){} // RVA: 0x24B10
        public void Dispose(){} // RVA: 0x25130 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x24B10
    }

    public class PooledStack`1
    {
        public System.Buffers.ArrayPool`1<System.ValueTuple`2<UnityEngine.Object,bool>> _pool; // 0x10
        public object _syncRoot; // 0x18
        public System.ValueTuple`2<UnityEngine.Object,bool>[] _array; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DFFEA0 | overloaded x2
        public void get_Count(){} // RVA: 0x791DC0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x2DD320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x3E00020
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x3E000D0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x3E001E0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x3E001E0
        public void Pop(){} // RVA: 0x3E002B0
        public void Push(){} // RVA: 0x3E003C0
        public void PushWithResize(){} // RVA: 0x3E00490
        public void ThrowForEmptyStack(){} // RVA: 0x3E005D0
        public void ReturnArray(){} // RVA: 0x3E00620
        public void Dispose(){} // RVA: 0x3E00760 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x3E007C0
    }

    public class StackDebugView`1
    {
    }

    public class ThrowHelper
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x1D58C00
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x283FA0
        public void ThrowArgumentException(){} // RVA: 0x1D58C60 | overloaded x2
        public void GetArgumentNullException(){} // RVA: 0x1D58C90
        public void ThrowArgumentNullException(){} // RVA: 0x1D58D30
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x1D58DC0 | overloaded x2
        public void ThrowInvalidOperationException(){} // RVA: 0x1D58DF0
        public void ThrowSerializationException(){} // RVA: 0x1D58E20
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x1D58E80
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x1D58ED0
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x1D58F20
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x1D58F70
        public void GetArgumentException(){} // RVA: 0x1D59210 | overloaded x2
        public void GetInvalidOperationException(){} // RVA: 0x1D59030
        public void GetWrongValueTypeArgumentException(){} // RVA: 0x1D590A0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x1D59180
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x2A490
        public void GetArgumentName(){} // RVA: 0x1D59290
        public void GetResourceString(){} // RVA: 0x1D59B00
    }

}