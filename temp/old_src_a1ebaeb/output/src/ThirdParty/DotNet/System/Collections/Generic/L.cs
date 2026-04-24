// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5714

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class LargeArrayBuilder`1 : ValueType
    {
        public object _buffers; // 0x31137480
        public object _count; // 0x31137480
        public object _buffers; // 0x34FBABE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void AddRange(){} // RVA: 0x7ffaa8660d80
        public void AddWithBufferAllocation(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){}
        public void ToArray(){} // RVA: 0x7ffaa86491d0
        public void TryMove(){} // RVA: 0x7ffaa864a2a0
        public void AllocateBuffer(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetBuffer(){} // RVA: 0x7ffaa8658120
    }

    public class LinkedListNode`1 : Object
    {
        public object prev; // 0x3114D8D0
        public object next; // 0x36056250

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_List(){} // RVA: 0x7ffaa86491d0
        public void get_Next(){} // RVA: 0x7ffaa86491d0
        public void get_Value(){} // RVA: 0x7ffaa887e5c0
        public void set_Value(){} // RVA: 0x7ffaa887e5c0
        public void Invalidate(){} // RVA: 0x7ffaa8660cc0
    }

    public class LinkedList`1 : Object
    {
        public object version; // 0x30F26ED0
        public object VersionName; // 0x30F26ED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_First(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x7ffaa887e5c0
        public void AddFirst(){} // RVA: 0x7ffaa887e5c0
        public void AddLast(){} // RVA: 0x7ffaa8660d80
        public void AddLast(){} // RVA: 0x7ffaa8660d80
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void Find(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void Remove(){} // RVA: 0x7ffaa8660d80
        public void Remove(){} // RVA: 0x7ffaa8660d80
        public void RemoveFirst(){} // RVA: 0x7ffaa8660cc0
        public void OnDeserialization(){} // RVA: 0x7ffaa8660d80
        public void InternalInsertNodeBefore(){} // RVA: 0x7ffaa8669e70
        public void InternalInsertNodeToEmptyList(){} // RVA: 0x7ffaa8660d80
        public void InternalRemoveNode(){} // RVA: 0x7ffaa8660d80
        public void ValidateNewNode(){} // RVA: 0x7ffaa8660d80
        public void ValidateNode(){} // RVA: 0x7ffaa8660d80
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
        public void GetObjectData(){}
    }

    public class List`1 : Object
    {
        public object _size; // 0x30080130
        public object s_emptyArray; // 0x30080130

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x300B12B8
        public object s_emptyArray; // 0x300B12B8
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x300B1988
        public object s_emptyArray; // 0x300B1988
        public object `Ǐf; // 0xABB914C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x300C4E60
        public object s_emptyArray; // 0x300C4E60
        public object @S1; // 0x150000
        public object @S1; // 0x150000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabbd24f0
        public void .ctor(){} // RVA: 0x7ffaabbd24f0
        public void .ctor(){} // RVA: 0x7ffaabbd24f0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabbd2760
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaaac6a1c0
        public void AddWithResize(){} // RVA: 0x7ffaabbd2810
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbd28d0
        public void AddRange(){} // RVA: 0x7ffaabbd29d0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabbd2b00
        public void BinarySearch(){} // RVA: 0x7ffaabbd2b00
        public void BinarySearch(){} // RVA: 0x7ffaabbd2b00
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabbd2b70
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabbd2be0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabbd2db0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabbd2de0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabbd3110
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabbd2f70
        public void IndexOf(){} // RVA: 0x7ffaabbd3110
        public void IndexOf(){} // RVA: 0x7ffaabbd3110
        public void Insert(){} // RVA: 0x7ffaabbd3180
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbd32b0
        public void InsertRange(){} // RVA: 0x7ffaabbd33b0
        public void LastIndexOf(){} // RVA: 0x7ffaabbd3790
        public void LastIndexOf(){} // RVA: 0x7ffaabbd3790
        public void LastIndexOf(){} // RVA: 0x7ffaabbd3790
        public void Remove(){} // RVA: 0x7ffaabbd3850
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabbd38e0
        public void RemoveAll(){} // RVA: 0x7ffaabb93b00
        public void RemoveAt(){} // RVA: 0x7ffaabb93ca0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabbd3cc0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x300D2760
        public object s_emptyArray; // 0x300D2760
        public object PƖf; // 0x201D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3012BA58
        public object s_emptyArray; // 0x3012BA58

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc12bd0
        public void .ctor(){} // RVA: 0x7ffaabc12bd0
        public void .ctor(){} // RVA: 0x7ffaabc12bd0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc12e40
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaa8b2c8e0
        public void AddWithResize(){} // RVA: 0x7ffaabb91da0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbccb80
        public void AddRange(){} // RVA: 0x7ffaabc12ef0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc13020
        public void BinarySearch(){} // RVA: 0x7ffaabc13020
        public void BinarySearch(){} // RVA: 0x7ffaabc13020
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc13090
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc13100
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabc13270
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabc13620
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc13480
        public void IndexOf(){} // RVA: 0x7ffaabc13620
        public void IndexOf(){} // RVA: 0x7ffaabc13620
        public void Insert(){} // RVA: 0x7ffaabb930f0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabc13690
        public void InsertRange(){} // RVA: 0x7ffaabc13790
        public void LastIndexOf(){} // RVA: 0x7ffaabc13be0
        public void LastIndexOf(){} // RVA: 0x7ffaabc13be0
        public void LastIndexOf(){} // RVA: 0x7ffaabc13be0
        public void Remove(){} // RVA: 0x7ffaabc13ca0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc13dc0
        public void RemoveAll(){} // RVA: 0x7ffaabb93b00
        public void RemoveAt(){} // RVA: 0x7ffaabb93ca0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabc141f0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x30B20830
        public object s_emptyArray; // 0x30B20830
        public object Capacity; // 0x170008CD
        public object Count; // 0x170008CE

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void set_Capacity(){} // RVA: 0x7ffaa8661210
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa864a040
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa864a040
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaa86491d0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void IsCompatibleObject(){} // RVA: 0x7ffaa864a120
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaa8658120
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaa8662f00
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void AddWithResize(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaa864e9f0
        public void AddRange(){} // RVA: 0x7ffaa8660d80
        public void AsReadOnly(){} // RVA: 0x7ffaa86491d0
        public void BinarySearch(){} // RVA: 0x7ffaa887e5c0
        public void BinarySearch(){} // RVA: 0x7ffaa887e5c0
        public void BinarySearch(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaa864a2a0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void EnsureCapacity(){} // RVA: 0x7ffaa8661210
        public void Exists(){} // RVA: 0x7ffaa864a2a0
        public void Find(){} // RVA: 0x7ffaa887e5c0
        public void FindAll(){} // RVA: 0x7ffaa8649280
        public void FindIndex(){} // RVA: 0x7ffaa887e5c0
        public void FindIndex(){} // RVA: 0x7ffaa887e5c0
        public void FindLastIndex(){} // RVA: 0x7ffaa887e5c0
        public void FindLastIndex(){} // RVA: 0x7ffaa887e5c0
        public void ForEach(){} // RVA: 0x7ffaa8660d80
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaa864e9f0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaa8662f00
        public void InsertRange(){} // RVA: 0x7ffaa8662f00
        public void LastIndexOf(){} // RVA: 0x7ffaa887e5c0
        public void LastIndexOf(){} // RVA: 0x7ffaa887e5c0
        public void LastIndexOf(){} // RVA: 0x7ffaa887e5c0
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaa8660d80
        public void RemoveAll(){} // RVA: 0x7ffaa864e9f0
        public void RemoveAt(){} // RVA: 0x7ffaa8661210
        public void RemoveRange(){} // RVA: 0x7ffaa86631a0
        public void Reverse(){} // RVA: 0x7ffaa86631a0
        public void Reverse(){} // RVA: 0x7ffaa86631a0
        public void Sort(){} // RVA: 0x7ffaa8660d80
        public void Sort(){} // RVA: 0x7ffaa8660d80
        public void Sort(){} // RVA: 0x7ffaa8660d80
        public void Sort(){} // RVA: 0x7ffaa8660d80
        public void ToArray(){} // RVA: 0x7ffaa86491d0
        public void TrimExcess(){} // RVA: 0x7ffaa8660cc0
        public void TrueForAll(){} // RVA: 0x7ffaa864a2a0
        public void AddEnumerable(){} // RVA: 0x7ffaa8660d80
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaa887e5c0
        public void GetRange(){}
    }

    public class List`1 : Object
    {
        public object _size; // 0x3193C868
        public object s_emptyArray; // 0x3193C868

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x31A6B458
        public object s_emptyArray; // 0x31A6B458

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x31FD1B50
        public object s_emptyArray; // 0x31FD1B50
        public object @S1; // 0x150000
        public object @S1; // 0x150000
    }

    public class List`1 : Object
    {
        public object _size; // 0x32CB1458
        public object s_emptyArray; // 0x32CB1458

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabe80c40
        public void .ctor(){} // RVA: 0x7ffaabe80c40
        public void .ctor(){} // RVA: 0x7ffaabe80c40
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabe80eb0
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabb97520
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb975d0
        public void Add(){} // RVA: 0x7ffaa8bd1b80
        public void AddWithResize(){} // RVA: 0x7ffaabb97750
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabb97820
        public void AddRange(){} // RVA: 0x7ffaabe80f60
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabe810a0
        public void BinarySearch(){} // RVA: 0x7ffaabe810a0
        public void BinarySearch(){} // RVA: 0x7ffaabe810a0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabe81120
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabe81190
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb95250
        public void Find(){} // RVA: 0x7ffaabb95310
        public void FindAll(){} // RVA: 0x7ffaabb97ce0
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void ForEach(){} // RVA: 0x7ffaabb958e0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void IndexOf(){} // RVA: 0x7ffaabe81520
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabe81360
        public void IndexOf(){} // RVA: 0x7ffaabe81520
        public void IndexOf(){} // RVA: 0x7ffaabe81520
        public void Insert(){} // RVA: 0x7ffaabb98140
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb98270
        public void InsertRange(){} // RVA: 0x7ffaabe81590
        public void LastIndexOf(){} // RVA: 0x7ffaabe81a00
        public void LastIndexOf(){} // RVA: 0x7ffaabe81a00
        public void LastIndexOf(){} // RVA: 0x7ffaabe81a00
        public void Remove(){} // RVA: 0x7ffaabe81ad0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabe81b50
        public void RemoveAll(){} // RVA: 0x7ffaabb98c50
        public void RemoveAt(){} // RVA: 0x7ffaabb98de0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb98f30
        public void Reverse(){} // RVA: 0x7ffaabb98f30
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb96ec0
        public void AddEnumerable(){} // RVA: 0x7ffaabe81ed0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33B1CDB8
        public object s_emptyArray; // 0x33B1CDB8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33D4CB88
        public object s_emptyArray; // 0x33D4CB88

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33D62670
        public object s_emptyArray; // 0x33D62670

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33D62A30
        public object s_emptyArray; // 0x33D62A30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33DAD2A0
        public object s_emptyArray; // 0x33DAD2A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabed11e0
        public void .ctor(){} // RVA: 0x7ffaabed11e0
        public void .ctor(){} // RVA: 0x7ffaabed11e0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabed1450
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabb97520
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb975d0
        public void Add(){} // RVA: 0x7ffaa8bd1b80
        public void AddWithResize(){} // RVA: 0x7ffaabb97750
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabb97820
        public void AddRange(){} // RVA: 0x7ffaabed1500
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabed1640
        public void BinarySearch(){} // RVA: 0x7ffaabed1640
        public void BinarySearch(){} // RVA: 0x7ffaabed1640
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabed16c0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabed1730
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb95250
        public void Find(){} // RVA: 0x7ffaabb95310
        public void FindAll(){} // RVA: 0x7ffaabc3b1a0
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void ForEach(){} // RVA: 0x7ffaabb958e0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void IndexOf(){} // RVA: 0x7ffaabed1ac0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabed1900
        public void IndexOf(){} // RVA: 0x7ffaabed1ac0
        public void IndexOf(){} // RVA: 0x7ffaabed1ac0
        public void Insert(){} // RVA: 0x7ffaabb98140
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb98270
        public void InsertRange(){} // RVA: 0x7ffaabed1b30
        public void LastIndexOf(){} // RVA: 0x7ffaabed1fa0
        public void LastIndexOf(){} // RVA: 0x7ffaabed1fa0
        public void LastIndexOf(){} // RVA: 0x7ffaabed1fa0
        public void Remove(){} // RVA: 0x7ffaabed2070
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabed21c0
        public void RemoveAll(){} // RVA: 0x7ffaabb98c50
        public void RemoveAt(){} // RVA: 0x7ffaabb98de0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb98f30
        public void Reverse(){} // RVA: 0x7ffaabb98f30
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void Sort(){} // RVA: 0x7ffaabb991b0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb96ec0
        public void AddEnumerable(){} // RVA: 0x7ffaabed2610
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33DD1A98
        public object s_emptyArray; // 0x33DD1A98

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33E3DAB8
        public object s_emptyArray; // 0x33E3DAB8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabbd24f0
        public void .ctor(){} // RVA: 0x7ffaabbd24f0
        public void .ctor(){} // RVA: 0x7ffaabbd24f0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabbd2760
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaaac6a1c0
        public void AddWithResize(){} // RVA: 0x7ffaabbd2810
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbd28d0
        public void AddRange(){} // RVA: 0x7ffaabbd29d0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabbd2b00
        public void BinarySearch(){} // RVA: 0x7ffaabbd2b00
        public void BinarySearch(){} // RVA: 0x7ffaabbd2b00
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabbd2b70
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabbd2be0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabbd2db0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabbd2de0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabbd3110
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabbd2f70
        public void IndexOf(){} // RVA: 0x7ffaabbd3110
        public void IndexOf(){} // RVA: 0x7ffaabbd3110
        public void Insert(){} // RVA: 0x7ffaabbd3180
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbd32b0
        public void InsertRange(){} // RVA: 0x7ffaabbd33b0
        public void LastIndexOf(){} // RVA: 0x7ffaabbd3790
        public void LastIndexOf(){} // RVA: 0x7ffaabbd3790
        public void LastIndexOf(){} // RVA: 0x7ffaabbd3790
        public void Remove(){} // RVA: 0x7ffaabbd3850
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabbd38e0
        public void RemoveAll(){} // RVA: 0x7ffaabb93b00
        public void RemoveAt(){} // RVA: 0x7ffaabb93ca0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabbd3cc0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33E3FAA0
        public object s_emptyArray; // 0x33E3FAA0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33E3FE08
        public object s_emptyArray; // 0x33E3FE08

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33E40170
        public object s_emptyArray; // 0x33E40170

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33E404D8
        public object s_emptyArray; // 0x33E404D8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x33E40840
        public object s_emptyArray; // 0x33E40840

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x341C1098
        public object s_emptyArray; // 0x341C1098
        public object Ǐf; // 0xAB884ED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x341C90A0
        public object s_emptyArray; // 0x341C90A0
        public object `Ǐf; // 0x341C90A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x341CC5E0
        public object s_emptyArray; // 0x341CC5E0
        public object `Ǐf; // 0x341CC5E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x341D5060
        public object s_emptyArray; // 0x341D5060

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34207C08
        public object s_emptyArray; // 0x34207C08

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3427C8C0
        public object s_emptyArray; // 0x3427C8C0
        public object `Ǐf; // 0x3427C8C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3433D810
        public object s_emptyArray; // 0x3433D810
    }

    public class List`1 : Object
    {
        public object _size; // 0x34350330
        public object s_emptyArray; // 0x34350330

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3445F348
        public object s_emptyArray; // 0x3445F348

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x344794B8
        public object s_emptyArray; // 0x344794B8
        public object Ǐf; // 0xAB884ED0
    }

    public class List`1 : Object
    {
        public object _size; // 0x344BDD38
        public object s_emptyArray; // 0x344BDD38
    }

    public class List`1 : Object
    {
        public object _size; // 0x34574870
        public object s_emptyArray; // 0x34574870

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x345B8258
        public object s_emptyArray; // 0x345B8258

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x345E67A8
        public object s_emptyArray; // 0x345E67A8
    }

    public class List`1 : Object
    {
        public object _size; // 0x34601EC8
        public object s_emptyArray; // 0x34601EC8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34603918
        public object s_emptyArray; // 0x34603918

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34692250
        public object s_emptyArray; // 0x34692250

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3469BE58
        public object s_emptyArray; // 0x3469BE58

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x346ADE38
        public object s_emptyArray; // 0x346ADE38
    }

    public class List`1 : Object
    {
        public object _size; // 0x346E25C0
        public object s_emptyArray; // 0x346E25C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x346E95D8
        public object s_emptyArray; // 0x346E95D8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x346FA578
        public object s_emptyArray; // 0x346FA578

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x347014B8
        public object s_emptyArray; // 0x347014B8
    }

    public class List`1 : Object
    {
        public object _size; // 0x34721158
        public object s_emptyArray; // 0x34721158

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabdb5330
        public void .ctor(){} // RVA: 0x7ffaabdb5330
        public void .ctor(){} // RVA: 0x7ffaabdb5330
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabdb55a0
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaa8b2c8e0
        public void AddWithResize(){} // RVA: 0x7ffaabb91da0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabb91e60
        public void AddRange(){} // RVA: 0x7ffaabdb5650
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabdb5780
        public void BinarySearch(){} // RVA: 0x7ffaabdb5780
        public void BinarySearch(){} // RVA: 0x7ffaabdb5780
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabdb57f0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabdb5860
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabc6ff20
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabdb5bb0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabdb5a10
        public void IndexOf(){} // RVA: 0x7ffaabdb5bb0
        public void IndexOf(){} // RVA: 0x7ffaabdb5bb0
        public void Insert(){} // RVA: 0x7ffaabb930f0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb93220
        public void InsertRange(){} // RVA: 0x7ffaabdb5c20
        public void LastIndexOf(){} // RVA: 0x7ffaabdb6000
        public void LastIndexOf(){} // RVA: 0x7ffaabdb6000
        public void LastIndexOf(){} // RVA: 0x7ffaabdb6000
        public void Remove(){} // RVA: 0x7ffaabdb60c0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabdb61e0
        public void RemoveAll(){} // RVA: 0x7ffaabb93b00
        public void RemoveAt(){} // RVA: 0x7ffaabb93ca0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabdb6610
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3475D310
        public object s_emptyArray; // 0x3475D310

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34784040
        public object s_emptyArray; // 0x34784040
    }

    public class List`1 : Object
    {
        public object _size; // 0x34787BB8
        public object s_emptyArray; // 0x34787BB8
    }

    public class List`1 : Object
    {
        public object _size; // 0x3479AC28
        public object s_emptyArray; // 0x3479AC28

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x347C4378
        public object s_emptyArray; // 0x347C4378

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x347E3F50
        public object s_emptyArray; // 0x347E3F50
        public object `Ǐf; // 0x347E3F50

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x347FE6E8
        public object s_emptyArray; // 0x347FE6E8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34817FD0
        public object s_emptyArray; // 0x34817FD0
        public object `Ǐf; // 0x34817FD0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34826E50
        public object s_emptyArray; // 0x34826E50
    }

    public class List`1 : Object
    {
        public object _size; // 0x34853A20
        public object s_emptyArray; // 0x34853A20
        public object `Ǐf; // 0x34853A20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34861ED0
        public object s_emptyArray; // 0x34861ED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34862D98
        public object s_emptyArray; // 0x34862D98
        public object Ǐf; // 0xAB884ED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34865B28
        public object s_emptyArray; // 0x34865B28
        public object Ǐf; // 0xAB884ED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34893AB0
        public object s_emptyArray; // 0x34893AB0
        public object `Ǐf; // 0x34893AB0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x348ACB20
        public object s_emptyArray; // 0x348ACB20
        public object `Ǐf; // 0x348ACB20

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x348CDC28
        public object s_emptyArray; // 0x348CDC28
        public object `Ǐf; // 0x348CDC28

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x348E5F18
        public object s_emptyArray; // 0x348E5F18

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3491B968
        public object s_emptyArray; // 0x3491B968

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34A645F8
        public object s_emptyArray; // 0x34A645F8
    }

    public class List`1 : Object
    {
        public object _size; // 0x34A64DF8
        public object s_emptyArray; // 0x34A64DF8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34A737A8
        public object s_emptyArray; // 0x34A737A8
        public object Ǐf; // 0xAB884ED0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34A79370
        public object s_emptyArray; // 0x34A79370
        public object `Ǐf; // 0x34A79370

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34A7B278
        public object s_emptyArray; // 0x34A7B278
        public object `Ǐf; // 0x34A7B278

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34A7C358
        public object s_emptyArray; // 0x34A7C358
        public object `Ǐf; // 0x34A7C358

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34B1FA68
        public object s_emptyArray; // 0x34B1FA68
        public object `Ƨ1; // 0x67215675

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34CCA7B0
        public object s_emptyArray; // 0x34CCA7B0
        public object 0͖f; // 0x201D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabcbe840
        public void .ctor(){} // RVA: 0x7ffaabcbe840
        public void .ctor(){} // RVA: 0x7ffaabcbe840
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabcbeab0
        public void get_Item(){} // RVA: 0x7ffaabc7e470
        public void set_Item(){} // RVA: 0x7ffaabc7e4b0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabc7e4f0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabcbcbc0
        public void Add(){} // RVA: 0x7ffaa9773050
        public void AddWithResize(){} // RVA: 0x7ffaabcbccd0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabcbcd40
        public void AddRange(){} // RVA: 0x7ffaabcbeb60
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabcbed70
        public void BinarySearch(){} // RVA: 0x7ffaabcbed70
        public void BinarySearch(){} // RVA: 0x7ffaabcbed70
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabcbedb0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabcbee10
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabcbd240
        public void Find(){} // RVA: 0x7ffaabcbd2e0
        public void FindAll(){} // RVA: 0x7ffaabcbef70
        public void FindIndex(){} // RVA: 0x7ffaabcbd540
        public void FindIndex(){} // RVA: 0x7ffaabcbd540
        public void FindLastIndex(){} // RVA: 0x7ffaabcbd6c0
        public void FindLastIndex(){} // RVA: 0x7ffaabcbd6c0
        public void ForEach(){} // RVA: 0x7ffaabc7f1c0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void IndexOf(){} // RVA: 0x7ffaabcbf240
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabcbf0c0
        public void IndexOf(){} // RVA: 0x7ffaabcbf240
        public void IndexOf(){} // RVA: 0x7ffaabcbf240
        public void Insert(){} // RVA: 0x7ffaabcbd9b0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabcbda70
        public void InsertRange(){} // RVA: 0x7ffaabcbf2a0
        public void LastIndexOf(){} // RVA: 0x7ffaabcbf660
        public void LastIndexOf(){} // RVA: 0x7ffaabcbf660
        public void LastIndexOf(){} // RVA: 0x7ffaabcbf660
        public void Remove(){} // RVA: 0x7ffaabcbf710
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabcbf7b0
        public void RemoveAll(){} // RVA: 0x7ffaabcbe180
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabcbf9e0
        public void Reverse(){} // RVA: 0x7ffaabcbf9e0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabcbe570
        public void AddEnumerable(){} // RVA: 0x7ffaabcbfd40
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabc7f260
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34CE1D00
        public object s_emptyArray; // 0x34CE1D00

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34CEFBE0
        public object s_emptyArray; // 0x34CEFBE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34D39558
        public object s_emptyArray; // 0x34D39558
        public object pʖf; // 0x201D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabe634f0
        public void .ctor(){} // RVA: 0x7ffaabe634f0
        public void .ctor(){} // RVA: 0x7ffaabe634f0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabe63760
        public void get_Item(){} // RVA: 0x7ffaabc7e470
        public void set_Item(){} // RVA: 0x7ffaabc7e4b0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabc7e4f0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabc7e550
        public void Add(){} // RVA: 0x7ffaabc7e660
        public void AddWithResize(){} // RVA: 0x7ffaabc7e6c0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabc7e730
        public void AddRange(){} // RVA: 0x7ffaabe63810
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabe63a20
        public void BinarySearch(){} // RVA: 0x7ffaabe63a20
        public void BinarySearch(){} // RVA: 0x7ffaabe63a20
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabe63a60
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabe63ac0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabc7ec70
        public void Find(){} // RVA: 0x7ffaabc7ed10
        public void FindAll(){} // RVA: 0x7ffaabcc7f10
        public void FindIndex(){} // RVA: 0x7ffaabc7ef70
        public void FindIndex(){} // RVA: 0x7ffaabc7ef70
        public void FindLastIndex(){} // RVA: 0x7ffaabc7f0f0
        public void FindLastIndex(){} // RVA: 0x7ffaabc7f0f0
        public void ForEach(){} // RVA: 0x7ffaabc7f1c0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void IndexOf(){} // RVA: 0x7ffaabe63dd0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabe63c50
        public void IndexOf(){} // RVA: 0x7ffaabe63dd0
        public void IndexOf(){} // RVA: 0x7ffaabe63dd0
        public void Insert(){} // RVA: 0x7ffaabc7f5c0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabc7f680
        public void InsertRange(){} // RVA: 0x7ffaabe63e30
        public void LastIndexOf(){} // RVA: 0x7ffaabe641e0
        public void LastIndexOf(){} // RVA: 0x7ffaabe641e0
        public void LastIndexOf(){} // RVA: 0x7ffaabe641e0
        public void Remove(){} // RVA: 0x7ffaabe64290
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabe64330
        public void RemoveAll(){} // RVA: 0x7ffaabc7fe00
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabc80050
        public void Reverse(){} // RVA: 0x7ffaabc80050
        public void Sort(){} // RVA: 0x7ffaabc803b0
        public void Sort(){} // RVA: 0x7ffaabc803b0
        public void Sort(){} // RVA: 0x7ffaabc803b0
        public void Sort(){} // RVA: 0x7ffaabc803b0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabc80470
        public void AddEnumerable(){} // RVA: 0x7ffaabe646d0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabc7f260
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34D955A0
        public object s_emptyArray; // 0x34D955A0
        public object &7g;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabe2ccd0
        public void .ctor(){} // RVA: 0x7ffaabe2ccd0
        public void .ctor(){} // RVA: 0x7ffaabe2ccd0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabe2cf40
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabbec300
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbf0480
        public void Add(){} // RVA: 0x7ffaabbec570
        public void AddWithResize(){} // RVA: 0x7ffaabbec600
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbf05a0
        public void AddRange(){} // RVA: 0x7ffaabe2cff0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabe2d130
        public void BinarySearch(){} // RVA: 0x7ffaabe2d130
        public void BinarySearch(){} // RVA: 0x7ffaabe2d130
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabe2d1b0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabe2d220
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb95250
        public void Find(){} // RVA: 0x7ffaabb95310
        public void FindAll(){} // RVA: 0x7ffaabc6e870
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void ForEach(){} // RVA: 0x7ffaabb958e0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void IndexOf(){} // RVA: 0x7ffaabe2d5b0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabe2d3f0
        public void IndexOf(){} // RVA: 0x7ffaabe2d5b0
        public void IndexOf(){} // RVA: 0x7ffaabe2d5b0
        public void Insert(){} // RVA: 0x7ffaabbed140
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbf0d30
        public void InsertRange(){} // RVA: 0x7ffaabe2d620
        public void LastIndexOf(){} // RVA: 0x7ffaabe2da90
        public void LastIndexOf(){} // RVA: 0x7ffaabe2da90
        public void LastIndexOf(){} // RVA: 0x7ffaabe2da90
        public void Remove(){} // RVA: 0x7ffaabe2db60
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabe2dc10
        public void RemoveAll(){} // RVA: 0x7ffaabbedb60
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabbede30
        public void Reverse(){} // RVA: 0x7ffaabbede30
        public void Sort(){} // RVA: 0x7ffaabbee1c0
        public void Sort(){} // RVA: 0x7ffaabbee1c0
        public void Sort(){} // RVA: 0x7ffaabbee1c0
        public void Sort(){} // RVA: 0x7ffaabbee1c0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb96ec0
        public void AddEnumerable(){} // RVA: 0x7ffaabe2dfd0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DB5340
        public object s_emptyArray; // 0x34DB5340

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabcbc8a0
        public void .ctor(){} // RVA: 0x7ffaabcbc8a0
        public void .ctor(){} // RVA: 0x7ffaabcbc8a0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabcbcb10
        public void get_Item(){} // RVA: 0x7ffaabc7e470
        public void set_Item(){} // RVA: 0x7ffaabc7e4b0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabc7e4f0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabcbcbc0
        public void Add(){} // RVA: 0x7ffaa9773050
        public void AddWithResize(){} // RVA: 0x7ffaabcbccd0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabcbcd40
        public void AddRange(){} // RVA: 0x7ffaabcbce70
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabcbd080
        public void BinarySearch(){} // RVA: 0x7ffaabcbd080
        public void BinarySearch(){} // RVA: 0x7ffaabcbd080
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabcbd0c0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabcbd120
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabcbd240
        public void Find(){} // RVA: 0x7ffaabcbd2e0
        public void FindAll(){} // RVA: 0x7ffaabcbd380
        public void FindIndex(){} // RVA: 0x7ffaabcbd540
        public void FindIndex(){} // RVA: 0x7ffaabcbd540
        public void FindLastIndex(){} // RVA: 0x7ffaabcbd6c0
        public void FindLastIndex(){} // RVA: 0x7ffaabcbd6c0
        public void ForEach(){} // RVA: 0x7ffaabc7f1c0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void IndexOf(){} // RVA: 0x7ffaabcbd950
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabcbd7d0
        public void IndexOf(){} // RVA: 0x7ffaabcbd950
        public void IndexOf(){} // RVA: 0x7ffaabcbd950
        public void Insert(){} // RVA: 0x7ffaabcbd9b0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabcbda70
        public void InsertRange(){} // RVA: 0x7ffaabcbdb60
        public void LastIndexOf(){} // RVA: 0x7ffaabcbdf20
        public void LastIndexOf(){} // RVA: 0x7ffaabcbdf20
        public void LastIndexOf(){} // RVA: 0x7ffaabcbdf20
        public void Remove(){} // RVA: 0x7ffaabcbdfd0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabcbe070
        public void RemoveAll(){} // RVA: 0x7ffaabcbe180
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabcbe320
        public void Reverse(){} // RVA: 0x7ffaabcbe320
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void Sort(){} // RVA: 0x7ffaabcbe4b0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabcbe570
        public void AddEnumerable(){} // RVA: 0x7ffaabcbe600
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabc7f260
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DBACC0
        public object s_emptyArray; // 0x34DBACC0
        public object 	6g;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabcabd00
        public void .ctor(){} // RVA: 0x7ffaabcabd00
        public void .ctor(){} // RVA: 0x7ffaabcabd00
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabcabf70
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabbbd250
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd290
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbbd2f0
        public void Add(){} // RVA: 0x7ffaabbbd400
        public void AddWithResize(){} // RVA: 0x7ffaabbbd460
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbbd4d0
        public void AddRange(){} // RVA: 0x7ffaabcac020
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabcac230
        public void BinarySearch(){} // RVA: 0x7ffaabcac230
        public void BinarySearch(){} // RVA: 0x7ffaabcac230
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabcac270
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabcac2d0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbeeff0
        public void Find(){} // RVA: 0x7ffaabbbda50
        public void FindAll(){} // RVA: 0x7ffaabc04270
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabcac5f0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabcac460
        public void IndexOf(){} // RVA: 0x7ffaabcac5f0
        public void IndexOf(){} // RVA: 0x7ffaabcac5f0
        public void Insert(){} // RVA: 0x7ffaabbbe320
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbbe3e0
        public void InsertRange(){} // RVA: 0x7ffaabcac650
        public void LastIndexOf(){} // RVA: 0x7ffaabcaca00
        public void LastIndexOf(){} // RVA: 0x7ffaabcaca00
        public void LastIndexOf(){} // RVA: 0x7ffaabcaca00
        public void Remove(){} // RVA: 0x7ffaabcacab0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabcacb50
        public void RemoveAll(){} // RVA: 0x7ffaabbbeb70
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabbbeea0
        public void Reverse(){} // RVA: 0x7ffaabbbeea0
        public void Sort(){} // RVA: 0x7ffaabbbf200
        public void Sort(){} // RVA: 0x7ffaabbbf200
        public void Sort(){} // RVA: 0x7ffaabbbf200
        public void Sort(){} // RVA: 0x7ffaabbbf200
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbbf2c0
        public void AddEnumerable(){} // RVA: 0x7ffaabcacf00
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DD5470
        public object s_emptyArray; // 0x34DD5470
        public object _regex; // 0x34DD35D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDC230
        public object s_emptyArray; // 0x34DDC230

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDC5F8
        public object s_emptyArray; // 0x34DDC5F8
        public object 	6g;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDC9C0
        public object s_emptyArray; // 0x34DDC9C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc14460
        public void .ctor(){} // RVA: 0x7ffaabc14460
        public void .ctor(){} // RVA: 0x7ffaabc14460
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc146d0
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaa8b2c8e0
        public void AddWithResize(){} // RVA: 0x7ffaabb91da0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbccb80
        public void AddRange(){} // RVA: 0x7ffaabc14780
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc148b0
        public void BinarySearch(){} // RVA: 0x7ffaabc148b0
        public void BinarySearch(){} // RVA: 0x7ffaabc148b0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc14920
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc14990
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabbcd000
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabc14ce0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc14b40
        public void IndexOf(){} // RVA: 0x7ffaabc14ce0
        public void IndexOf(){} // RVA: 0x7ffaabc14ce0
        public void Insert(){} // RVA: 0x7ffaabb930f0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb93220
        public void InsertRange(){} // RVA: 0x7ffaabc14d50
        public void LastIndexOf(){} // RVA: 0x7ffaabc15130
        public void LastIndexOf(){} // RVA: 0x7ffaabc15130
        public void LastIndexOf(){} // RVA: 0x7ffaabc15130
        public void Remove(){} // RVA: 0x7ffaabc151f0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc15310
        public void RemoveAll(){} // RVA: 0x7ffaabb93b00
        public void RemoveAt(){} // RVA: 0x7ffaabb93ca0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabc15740
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDCD88
        public object s_emptyArray; // 0x34DDCD88

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDD150
        public object s_emptyArray; // 0x34DDD150

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDD518
        public object s_emptyArray; // 0x34DDD518

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc14460
        public void .ctor(){} // RVA: 0x7ffaabc14460
        public void .ctor(){} // RVA: 0x7ffaabc14460
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc146d0
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaa8b2c8e0
        public void AddWithResize(){} // RVA: 0x7ffaabb91da0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbccb80
        public void AddRange(){} // RVA: 0x7ffaabc14780
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc148b0
        public void BinarySearch(){} // RVA: 0x7ffaabc148b0
        public void BinarySearch(){} // RVA: 0x7ffaabc148b0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc14920
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc14990
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabbcd000
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabc14ce0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc14b40
        public void IndexOf(){} // RVA: 0x7ffaabc14ce0
        public void IndexOf(){} // RVA: 0x7ffaabc14ce0
        public void Insert(){} // RVA: 0x7ffaabb930f0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb93220
        public void InsertRange(){} // RVA: 0x7ffaabc14d50
        public void LastIndexOf(){} // RVA: 0x7ffaabc15130
        public void LastIndexOf(){} // RVA: 0x7ffaabc15130
        public void LastIndexOf(){} // RVA: 0x7ffaabc15130
        public void Remove(){} // RVA: 0x7ffaabc151f0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc15310
        public void RemoveAll(){} // RVA: 0x7ffaabb93b00
        public void RemoveAt(){} // RVA: 0x7ffaabb93ca0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Reverse(){} // RVA: 0x7ffaabb93e80
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void Sort(){} // RVA: 0x7ffaabb94100
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabc15740
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDD8E0
        public object s_emptyArray; // 0x34DDD8E0
        public object 	6g;
        public object Xȝf; // 0x201D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDDCA0
        public object s_emptyArray; // 0x34DDDCA0
        public object 	6g;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34DDE110
        public object s_emptyArray; // 0x34DDE110

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34E39398
        public object s_emptyArray; // 0x34E39398
        public object 	6g;
        public object ՝f; // 0x201D0000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34E43FA8
        public object s_emptyArray; // 0x34E43FA8
    }

    public class List`1 : Object
    {
        public object _size; // 0x34F063D8
        public object s_emptyArray; // 0x34F063D8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void .ctor(){} // RVA: 0x7ffaabd3df30
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3e1a0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabbee820
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd210
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd3e250
        public void Add(){} // RVA: 0x7ffaa8956d60
        public void AddWithResize(){} // RVA: 0x7ffaabd3e350
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd3e3b0
        public void AddRange(){} // RVA: 0x7ffaabd3e4e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void BinarySearch(){} // RVA: 0x7ffaabd3e5e0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3e650
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3e6b0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabbd2d50
        public void Exists(){} // RVA: 0x7ffaabd3e7e0
        public void Find(){} // RVA: 0x7ffaabcc0a60
        public void FindAll(){} // RVA: 0x7ffaabd3e810
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindIndex(){} // RVA: 0x7ffaabcc0cd0
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void FindLastIndex(){} // RVA: 0x7ffaabcc0e50
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3e970
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void IndexOf(){} // RVA: 0x7ffaabd3eb00
        public void Insert(){} // RVA: 0x7ffaabd3eb60
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd3ec20
        public void InsertRange(){} // RVA: 0x7ffaabd3ed10
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3f0d0
        public void Remove(){} // RVA: 0x7ffaabd3f180
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3f210
        public void RemoveAll(){} // RVA: 0x7ffaabd3f330
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Reverse(){} // RVA: 0x7ffaabd3f4e0
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void Sort(){} // RVA: 0x7ffaabd3f670
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabbd3c70
        public void TrueForAll(){} // RVA: 0x7ffaabcc2030
        public void AddEnumerable(){} // RVA: 0x7ffaabd3f730
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class LongEnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void Equals(){} // RVA: 0x7ffaa864a2a0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
        public void GetHashCode(){} // RVA: 0x7ffaa8649ca0
        public void GetObjectData(){}
    }

    public class LowLevelDictionary`2 : Object
    {
        public object _version; // 0x30E67400

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8662f00
        public void .ctor(){} // RVA: 0x7ffaa8662f00
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void Clear(){} // RVA: 0x7ffaa8661210
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void Find(){} // RVA: 0x7ffaa887e5c0
        public void UncheckedAdd(){} // RVA: 0x7ffaa887e5c0
        public void ExpandBuckets(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetBucket(){} // RVA: 0x7ffaa887e5c0
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa864a040
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaa86491d0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaa86491d0
    }

    public class LowLevelList`1 : Object
    {
        public object _size; // 0x30F19E28
        public object ; // 0x130000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabef61c0
        public void .ctor(){} // RVA: 0x7ffaabef61c0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabef6370
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void get_Item(){} // RVA: 0x7ffaa884bb60
        public void set_Item(){} // RVA: 0x7ffaabef7160
        public void Add(){} // RVA: 0x7ffaabef7310
        public void EnsureCapacity(){} // RVA: 0x7ffaabef74b0
        public void AddRange(){} // RVA: 0x7ffaabef7510
        public void Clear(){} // RVA: 0x7ffaabef6790
        public void Contains(){} // RVA: 0x7ffaabef7530
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void IndexOf(){} // RVA: 0x7ffaabef7740
        public void Insert(){} // RVA: 0x7ffaabef7860
        public void InsertRange(){} // RVA: 0x7ffaabef7a70
        public void Remove(){} // RVA: 0x7ffaabef7e90
        public void RemoveAll(){} // RVA: 0x7ffaabef7fb0
        public void RemoveAt(){} // RVA: 0x7ffaabef82f0
        public void .cctor(){} // RVA: 0x7ffaabb94610
    }

    public class LowLevelList`1 : Object
    {
        public object _size; // 0x30F3DE40

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void get_Capacity(){} // RVA: 0x7ffaa8649ca0
        public void set_Capacity(){} // RVA: 0x7ffaa8661210
        public void get_Count(){} // RVA: 0x7ffaa8649ca0
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void set_Item(){} // RVA: 0x7ffaa887e5c0
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void EnsureCapacity(){} // RVA: 0x7ffaa8661210
        public void AddRange(){} // RVA: 0x7ffaa8660d80
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        public void Contains(){} // RVA: 0x7ffaa887e5c0
        public void CopyTo(){} // RVA: 0x7ffaa8667cb0
        public void IndexOf(){} // RVA: 0x7ffaa887e5c0
        public void Insert(){} // RVA: 0x7ffaa887e5c0
        public void InsertRange(){} // RVA: 0x7ffaa8662f00
        public void Remove(){} // RVA: 0x7ffaa887e5c0
        public void RemoveAll(){} // RVA: 0x7ffaa864e9f0
        public void RemoveAt(){} // RVA: 0x7ffaa8661210
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
    }

}