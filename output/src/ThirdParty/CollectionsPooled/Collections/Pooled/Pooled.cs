// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.CollectionsPooled.Collections.Pooled
// Classes: 5
// Methods: 103

namespace ThirdParty.CollectionsPooled.Collections.Pooled
{
    public class ClearModeUtil : Object
    {
        // ── Methods ──
        public void ShouldClear(){} // RVA: 0x7FFD4E07A7A0
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
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x2
        public void set_Capacity(){} // RVA: 0x7FFD4E090ED0
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void get_Item(){} // RVA: 0x7FFD4E2ADC40
        public void set_Item(){} // RVA: 0x7FFD4E2ADC40
        public void IsCompatibleObject(){} // RVA: 0x7FFD4E079DE0
        public void System.Collections.IList.get_Item(){} // RVA: 0x7FFD4E087DE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7FFD4E092BC0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void AddWithResize(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.Add(){} // RVA: 0x7FFD4E07E6B0
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.Contains(){} // RVA: 0x7FFD4E079F60
        public void System.Collections.Generic.ICollection<T>.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void EnsureCapacity(){} // RVA: 0x7FFD4E090ED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void IndexOf(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7FFD4E07E6B0
        public void Insert(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.Insert(){} // RVA: 0x7FFD4E092BC0
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.IList.Remove(){} // RVA: 0x7FFD4E090A40
        public void RemoveAt(){} // RVA: 0x7FFD4E090ED0
        public void ReturnArray(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD4E090A40
    }

    public class PooledSet`1 : Object
    {
        public System.Buffers.ArrayPool`1<int> Count;
        public System.Buffers.ArrayPool`1<0x6662E738<string>> System.Collections.Generic.ICollection<T>.IsReadOnly; // 0x8
        public int[] _buckets; // 0x10
        public 0x6662E738<string>[] _slots; // 0x18
        public int _size; // 0x20
        public int _count; // 0x24
        public int _lastIndex; // 0x28
        public int _freeList; // 0x2C
        public System.Collections.Generic.IEqualityComparer`1<string> _comparer; // 0x30
        public int _version; // 0x38
        public bool _clearOnFree; // 0x3C
        public System.Runtime.Serialization.SerializationInfo _siInfo; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x3
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7FFD4E2ADC40
        public void Clear(){} // RVA: 0x7FFD4E090980
        public void Contains(){} // RVA: 0x7FFD4E2ADC40
        public void CopyTo(){} // RVA: 0x7FFD4E090A40 | overloaded x3
        public void Remove(){} // RVA: 0x7FFD4E2ADC40
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7FFD4E079D00
        public void GetEnumerator(){} // RVA: 0x7FFD4E2ADC40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void GetObjectData(){}
        public void OnDeserialization(){} // RVA: 0x7FFD4E090A40
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void Initialize(){} // RVA: 0x7FFD4E0800D0
        public void IncreaseCapacity(){} // RVA: 0x7FFD4E090980
        public void SetCapacity(){} // RVA: 0x7FFD4E090ED0
        public void ReturnArrays(){} // RVA: 0x7FFD4E090980
        public void AddIfNotPresent(){} // RVA: 0x7FFD4E2ADC40
        public void InternalGetHashCode(){} // RVA: 0x7FFD4E2ADC40
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

    public class PooledStack`1 : Object
    {
        public System.Buffers.ArrayPool`1<System.ValueTuple`2<UnityEngine.Object,bool>> Count; // 0x10
        public object System.Collections.ICollection.IsSynchronized; // 0x18
        public System.ValueTuple`2<UnityEngine.Object,bool>[] System.Collections.ICollection.SyncRoot; // 0x20
        public int _size; // 0x28
        public int _version; // 0x2C
        public bool _clearOnFree; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E092BC0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFD4E079960
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7FFD4E079D00
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7FFD4E097970
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFD4E078E90
        public void Pop(){} // RVA: 0x7FFD4E2ADC40
        public void Push(){} // RVA: 0x7FFD4E2ADC40
        public void PushWithResize(){} // RVA: 0x7FFD4E2ADC40
        public void ThrowForEmptyStack(){} // RVA: 0x7FFD4E090980
        public void ReturnArray(){} // RVA: 0x7FFD4E090A40
        public void Dispose(){} // RVA: 0x7FFD4E091060 | overloaded x2
        public void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(){} // RVA: 0x7FFD4E090A40
    }

    public class ThrowHelper : Object
    {
        // ── Methods ──
        public void ThrowArgumentOutOfRange_IndexException(){} // RVA: 0x7FFD4FC9E700
        public void ThrowWrongValueTypeArgumentException(){} // RVA: 0x7FFD4E2ADC40
        public void ThrowArgumentException(){} // RVA: 0x7FFD4FC9E760 | overloaded x2
        public void GetArgumentNullException(){} // RVA: 0x7FFD4FC9E790
        public void ThrowArgumentNullException(){} // RVA: 0x7FFD4FC9E830
        public void ThrowArgumentOutOfRangeException(){} // RVA: 0x7FFD4FC9E8C0 | overloaded x2
        public void ThrowInvalidOperationException(){} // RVA: 0x7FFD4FC9E8F0
        public void ThrowSerializationException(){} // RVA: 0x7FFD4FC9E920
        public void ThrowArgumentException_Argument_InvalidArrayType(){} // RVA: 0x7FFD4FC9E980
        public void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(){} // RVA: 0x7FFD4FC9E9D0
        public void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen(){} // RVA: 0x7FFD4FC9EA20
        public void ThrowInvalidOperationException_ConcurrentOperationsNotSupported(){} // RVA: 0x7FFD4FC9EA70
        public void GetArgumentException(){} // RVA: 0x7FFD4FC9ED10 | overloaded x2
        public void GetInvalidOperationException(){} // RVA: 0x7FFD4FC9EB30
        public void GetWrongValueTypeArgumentException(){} // RVA: 0x7FFD4FC9EBA0
        public void GetArgumentOutOfRangeException(){} // RVA: 0x7FFD4FC9EC80
        public void IfNullAndNullsAreIllegalThenThrow(){} // RVA: 0x7FFD4E096370
        public void GetArgumentName(){} // RVA: 0x7FFD4FC9ED90
        public void GetResourceString(){} // RVA: 0x7FFD4FC9F600
    }

}