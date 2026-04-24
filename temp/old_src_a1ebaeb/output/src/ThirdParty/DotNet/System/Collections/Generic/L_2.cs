// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 4678

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class LargeArrayBuilder`1 : ValueType
    {
        public object _buffers; // 0x34FBABE0
        public object _count; // 0x34FBABE0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabb12340
        public void .ctor(){} // RVA: 0x7ffaabb12340
        public void AddRange(){} // RVA: 0x7ffaabb12440
        public void AddWithBufferAllocation(){} // RVA: 0x7ffaabb126d0
        public void CopyTo(){} // RVA: 0x7ffaabb127b0
        public void ToArray(){} // RVA: 0x7ffaabb129b0
        public void TryMove(){} // RVA: 0x7ffaabb12b00
        public void AllocateBuffer(){} // RVA: 0x7ffaabb12b70
        // ── Binary Analysis Named ──
        public void GetBuffer(){} // RVA: 0x7ffaabb12910
    }

    public class List`1 : Object
    {
        public object _size; // 0x34F067A0
        public object s_emptyArray; // 0x34F067A0

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
        public object _size; // 0x34F71EA0
        public object s_emptyArray; // 0x34F71EA0
        public object ; // 0x345FD660

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
        public object _size; // 0x34F79908
        public object s_emptyArray; // 0x34F79908
        public object lyFg;

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
        public object _size; // 0x34F88730
        public object s_emptyArray; // 0x34F88730
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34F8A6F8
        public object s_emptyArray; // 0x34F8A6F8
        public object FNg;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd21dc0
        public void .ctor(){} // RVA: 0x7ffaabd21dc0
        public void .ctor(){} // RVA: 0x7ffaabd21dc0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd22030
        public void get_Item(){} // RVA: 0x7ffaabbd4250
        public void set_Item(){} // RVA: 0x7ffaabbd42a0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbd4350
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbd43c0
        public void Add(){} // RVA: 0x7ffaab265a30
        public void AddWithResize(){} // RVA: 0x7ffaabbd4540
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbd4610
        public void AddRange(){} // RVA: 0x7ffaabd220e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd22220
        public void BinarySearch(){} // RVA: 0x7ffaabd22220
        public void BinarySearch(){} // RVA: 0x7ffaabd22220
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd222a0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd22310
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbd4ad0
        public void Find(){} // RVA: 0x7ffaabbd4b90
        public void FindAll(){} // RVA: 0x7ffaabd22490
        public void FindIndex(){} // RVA: 0x7ffaabbd4f20
        public void FindIndex(){} // RVA: 0x7ffaabbd4f20
        public void FindLastIndex(){} // RVA: 0x7ffaabbd50e0
        public void FindLastIndex(){} // RVA: 0x7ffaabbd50e0
        public void ForEach(){} // RVA: 0x7ffaabbd51d0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbd5330
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbd5330
        public void IndexOf(){} // RVA: 0x7ffaabd22800
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd22640
        public void IndexOf(){} // RVA: 0x7ffaabd22800
        public void IndexOf(){} // RVA: 0x7ffaabd22800
        public void Insert(){} // RVA: 0x7ffaabbd5680
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbd57b0
        public void InsertRange(){} // RVA: 0x7ffaabd22870
        public void LastIndexOf(){} // RVA: 0x7ffaabd22ce0
        public void LastIndexOf(){} // RVA: 0x7ffaabd22ce0
        public void LastIndexOf(){} // RVA: 0x7ffaabd22ce0
        public void Remove(){} // RVA: 0x7ffaabd22db0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd22ef0
        public void RemoveAll(){} // RVA: 0x7ffaabbd6170
        public void RemoveAt(){} // RVA: 0x7ffaabbd6300
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabbd6440
        public void Reverse(){} // RVA: 0x7ffaabbd6440
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbd6780
        public void AddEnumerable(){} // RVA: 0x7ffaabd23330
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbd5290
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x34FDF000
        public object s_emptyArray; // 0x34FDF000

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
        public object _size; // 0x34FF0398
        public object s_emptyArray; // 0x34FF0398
        public object CVQg;

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
        public object _size; // 0x350154A8
        public object s_emptyArray; // 0x350154A8
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35015B78
        public object s_emptyArray; // 0x35015B78
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35035D00
        public object s_emptyArray; // 0x35035D00
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x350363D0
        public object s_emptyArray; // 0x350363D0
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35042DF0
        public object s_emptyArray; // 0x35042DF0

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
        public object _size; // 0x3505A260
        public object s_emptyArray; // 0x3505A260

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabbbf590
        public void .ctor(){} // RVA: 0x7ffaabbbf590
        public void .ctor(){} // RVA: 0x7ffaabbbf590
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabbbf800
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb99820
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb998c0
        public void Add(){} // RVA: 0x7ffaa94e1240
        public void AddWithResize(){} // RVA: 0x7ffaabb99a30
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbbf8b0
        public void AddRange(){} // RVA: 0x7ffaabbbf9b0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabbbfae0
        public void BinarySearch(){} // RVA: 0x7ffaabbbfae0
        public void BinarySearch(){} // RVA: 0x7ffaabbbfae0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabbbfb50
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabbbfbc0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabbbfd30
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabbc0060
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabbbfec0
        public void IndexOf(){} // RVA: 0x7ffaabbc0060
        public void IndexOf(){} // RVA: 0x7ffaabbc0060
        public void Insert(){} // RVA: 0x7ffaabb9a390
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb9a4c0
        public void InsertRange(){} // RVA: 0x7ffaabbc00d0
        public void LastIndexOf(){} // RVA: 0x7ffaabbc0520
        public void LastIndexOf(){} // RVA: 0x7ffaabbc0520
        public void LastIndexOf(){} // RVA: 0x7ffaabbc0520
        public void Remove(){} // RVA: 0x7ffaabbc05e0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabbc0700
        public void RemoveAll(){} // RVA: 0x7ffaabb9ae10
        public void RemoveAt(){} // RVA: 0x7ffaabb9afb0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb9b0f0
        public void Reverse(){} // RVA: 0x7ffaabb9b0f0
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabbc0b30
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3506EA98
        public object s_emptyArray; // 0x3506EA98
    }

    public class List`1 : Object
    {
        public object _size; // 0x3506F3E0
        public object s_emptyArray; // 0x3506F3E0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3506F940
        public object s_emptyArray; // 0x3506F940
        public object Pd1; // 0x150000
    }

    public class List`1 : Object
    {
        public object _size; // 0x35072470
        public object s_emptyArray; // 0x35072470
        public object @Ïf; // 0x201D0000

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
        public object _size; // 0x35075D80
        public object s_emptyArray; // 0x35075D80
    }

    public class List`1 : Object
    {
        public object _size; // 0x350766C8
        public object s_emptyArray; // 0x350766C8
    }

    public class List`1 : Object
    {
        public object _size; // 0x35076C28
        public object s_emptyArray; // 0x35076C28
        public object Pd1; // 0x150000
    }

    public class List`1 : Object
    {
        public object _size; // 0x350BE840
        public object s_emptyArray; // 0x350BE840
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x350D6A88
        public object s_emptyArray; // 0x350D6A88

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
        public object _size; // 0x350D7680
        public object s_emptyArray; // 0x350D7680

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
        public object _size; // 0x350EEA98
        public object s_emptyArray; // 0x350EEA98
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x350EF168
        public object s_emptyArray; // 0x350EF168
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35162BE8
        public object s_emptyArray; // 0x35162BE8

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
        public object _size; // 0x35176480
        public object s_emptyArray; // 0x35176480

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
        public object _size; // 0x351768A0
        public object s_emptyArray; // 0x351768A0

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
        public object _size; // 0x351A4730
        public object s_emptyArray; // 0x351A4730

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
        public object _size; // 0x351AEAE8
        public object s_emptyArray; // 0x351AEAE8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd4dd40
        public void .ctor(){} // RVA: 0x7ffaabd4dd40
        public void .ctor(){} // RVA: 0x7ffaabd4dd40
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd4dfb0
        public void get_Item(){} // RVA: 0x7ffaabbc9dd0
        public void set_Item(){} // RVA: 0x7ffaabbc9e30
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbc9ef0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd15640
        public void Add(){} // RVA: 0x7ffaabbca080
        public void AddWithResize(){} // RVA: 0x7ffaabbca170
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbca250
        public void AddRange(){} // RVA: 0x7ffaabd4e060
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd4e1c0
        public void BinarySearch(){} // RVA: 0x7ffaabd4e1c0
        public void BinarySearch(){} // RVA: 0x7ffaabd4e1c0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd4e250
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd4e2d0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabd4e460
        public void Find(){} // RVA: 0x7ffaabbca830
        public void FindAll(){} // RVA: 0x7ffaabc695c0
        public void FindIndex(){} // RVA: 0x7ffaabbcab90
        public void FindIndex(){} // RVA: 0x7ffaabbcab90
        public void FindLastIndex(){} // RVA: 0x7ffaabbcad70
        public void FindLastIndex(){} // RVA: 0x7ffaabbcad70
        public void ForEach(){} // RVA: 0x7ffaabbcae70
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbcafe0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbcafe0
        public void IndexOf(){} // RVA: 0x7ffaabd4e6b0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd4e4e0
        public void IndexOf(){} // RVA: 0x7ffaabd4e6b0
        public void IndexOf(){} // RVA: 0x7ffaabd4e6b0
        public void Insert(){} // RVA: 0x7ffaabbcb380
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbcb4c0
        public void InsertRange(){} // RVA: 0x7ffaabd4e730
        public void LastIndexOf(){} // RVA: 0x7ffaabd4eb60
        public void LastIndexOf(){} // RVA: 0x7ffaabd4eb60
        public void LastIndexOf(){} // RVA: 0x7ffaabd4eb60
        public void Remove(){} // RVA: 0x7ffaabd4ec40
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd4ecd0
        public void RemoveAll(){} // RVA: 0x7ffaabbcbe90
        public void RemoveAt(){} // RVA: 0x7ffaabbcc050
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabbcc1b0
        public void Reverse(){} // RVA: 0x7ffaabbcc1b0
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbcc4f0
        public void AddEnumerable(){} // RVA: 0x7ffaabd4f060
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbcaf30
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x351C1C68
        public object s_emptyArray; // 0x351C1C68

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
        public object _size; // 0x351D47F8
        public object s_emptyArray; // 0x351D47F8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd4f300
        public void .ctor(){} // RVA: 0x7ffaabd4f300
        public void .ctor(){} // RVA: 0x7ffaabd4f300
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd4f570
        public void get_Item(){} // RVA: 0x7ffaabbc9dd0
        public void set_Item(){} // RVA: 0x7ffaabbc9e30
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbc9ef0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabc690b0
        public void Add(){} // RVA: 0x7ffaabbca080
        public void AddWithResize(){} // RVA: 0x7ffaabbca170
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbca250
        public void AddRange(){} // RVA: 0x7ffaabd4f620
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd4f780
        public void BinarySearch(){} // RVA: 0x7ffaabd4f780
        public void BinarySearch(){} // RVA: 0x7ffaabd4f780
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd4f810
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd4f890
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbca760
        public void Find(){} // RVA: 0x7ffaabbca830
        public void FindAll(){} // RVA: 0x7ffaabc695c0
        public void FindIndex(){} // RVA: 0x7ffaabbcab90
        public void FindIndex(){} // RVA: 0x7ffaabbcab90
        public void FindLastIndex(){} // RVA: 0x7ffaabbcad70
        public void FindLastIndex(){} // RVA: 0x7ffaabbcad70
        public void ForEach(){} // RVA: 0x7ffaabbcae70
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbcafe0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbcafe0
        public void IndexOf(){} // RVA: 0x7ffaabd4fc50
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd4fa80
        public void IndexOf(){} // RVA: 0x7ffaabd4fc50
        public void IndexOf(){} // RVA: 0x7ffaabd4fc50
        public void Insert(){} // RVA: 0x7ffaabbcb380
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbcb4c0
        public void InsertRange(){} // RVA: 0x7ffaabd4fcd0
        public void LastIndexOf(){} // RVA: 0x7ffaabd50100
        public void LastIndexOf(){} // RVA: 0x7ffaabd50100
        public void LastIndexOf(){} // RVA: 0x7ffaabd50100
        public void Remove(){} // RVA: 0x7ffaabd501e0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd50340
        public void RemoveAll(){} // RVA: 0x7ffaabbcbe90
        public void RemoveAt(){} // RVA: 0x7ffaabbcc050
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabbcc1b0
        public void Reverse(){} // RVA: 0x7ffaabbcc1b0
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void Sort(){} // RVA: 0x7ffaabbcc430
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbcc4f0
        public void AddEnumerable(){} // RVA: 0x7ffaabd507a0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbcaf30
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x351F9B18
        public object s_emptyArray; // 0x351F9B18

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
        public object _size; // 0x35238568
        public object s_emptyArray; // 0x35238568
        public object `͘f; // 0x201D0000

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
    }

    public class List`1 : Object
    {
        public object _size; // 0x3524A840
        public object s_emptyArray; // 0x3524A840

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabe08000
        public void .ctor(){} // RVA: 0x7ffaabe08000
        public void .ctor(){} // RVA: 0x7ffaabe08000
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabe08270
        public void get_Item(){} // RVA: 0x7ffaabbc10d0
        public void set_Item(){} // RVA: 0x7ffaabbc1150
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbc11d0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbc1260
        public void Add(){} // RVA: 0x7ffaabbc1390
        public void AddWithResize(){} // RVA: 0x7ffaabbc1450
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbc14f0
        public void AddRange(){} // RVA: 0x7ffaabe08320
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabe08490
        public void BinarySearch(){} // RVA: 0x7ffaabe08490
        public void BinarySearch(){} // RVA: 0x7ffaabe08490
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabe08500
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabe085a0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbc1a40
        public void Find(){} // RVA: 0x7ffaabbc1b40
        public void FindAll(){} // RVA: 0x7ffaabe08740
        public void FindIndex(){} // RVA: 0x7ffaabbc1fa0
        public void FindIndex(){} // RVA: 0x7ffaabbc1fa0
        public void FindLastIndex(){} // RVA: 0x7ffaabbc21d0
        public void FindLastIndex(){} // RVA: 0x7ffaabbc21d0
        public void ForEach(){} // RVA: 0x7ffaabbc22f0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbc24a0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbc24a0
        public void IndexOf(){} // RVA: 0x7ffaabe08b60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabe08960
        public void IndexOf(){} // RVA: 0x7ffaabe08b60
        public void IndexOf(){} // RVA: 0x7ffaabe08b60
        public void Insert(){} // RVA: 0x7ffaabbc28c0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbc29b0
        public void InsertRange(){} // RVA: 0x7ffaabe08bf0
        public void LastIndexOf(){} // RVA: 0x7ffaabe09060
        public void LastIndexOf(){} // RVA: 0x7ffaabe09060
        public void LastIndexOf(){} // RVA: 0x7ffaabe09060
        public void Remove(){} // RVA: 0x7ffaabe09170
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabe09250
        public void RemoveAll(){} // RVA: 0x7ffaabbc3310
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabbc36c0
        public void Reverse(){} // RVA: 0x7ffaabbc36c0
        public void Sort(){} // RVA: 0x7ffaabbc3aa0
        public void Sort(){} // RVA: 0x7ffaabbc3aa0
        public void Sort(){} // RVA: 0x7ffaabbc3aa0
        public void Sort(){} // RVA: 0x7ffaabbc3aa0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbc3b60
        public void AddEnumerable(){} // RVA: 0x7ffaabe09630
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbc23e0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x354F69F8
        public object s_emptyArray; // 0x354F69F8
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x354F89A8
        public object s_emptyArray; // 0x354F89A8
        public object D4:g;

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
        public object _size; // 0x35506770
        public object s_emptyArray; // 0x35506770
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35516528
        public object s_emptyArray; // 0x35516528
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35653648
        public object s_emptyArray; // 0x35653648

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
        public object _size; // 0x35655DD0
        public object s_emptyArray; // 0x35655DD0

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
        public object _size; // 0x35671110
        public object s_emptyArray; // 0x35671110

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
        public object _size; // 0x3567E7C8
        public object s_emptyArray; // 0x3567E7C8

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
    }

    public class List`1 : Object
    {
        public object _size; // 0x35692758
        public object s_emptyArray; // 0x35692758

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc70e20
        public void .ctor(){} // RVA: 0x7ffaabc70e20
        public void .ctor(){} // RVA: 0x7ffaabc70e20
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc71090
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb99820
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb998c0
        public void Add(){} // RVA: 0x7ffaa94e1240
        public void AddWithResize(){} // RVA: 0x7ffaabb99a30
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabb99af0
        public void AddRange(){} // RVA: 0x7ffaabc71140
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc71270
        public void BinarySearch(){} // RVA: 0x7ffaabc71270
        public void BinarySearch(){} // RVA: 0x7ffaabc71270
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc712e0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc71350
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabc714c0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabc717f0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc71650
        public void IndexOf(){} // RVA: 0x7ffaabc717f0
        public void IndexOf(){} // RVA: 0x7ffaabc717f0
        public void Insert(){} // RVA: 0x7ffaabb9a390
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb9a4c0
        public void InsertRange(){} // RVA: 0x7ffaabc71860
        public void LastIndexOf(){} // RVA: 0x7ffaabc71cb0
        public void LastIndexOf(){} // RVA: 0x7ffaabc71cb0
        public void LastIndexOf(){} // RVA: 0x7ffaabc71cb0
        public void Remove(){} // RVA: 0x7ffaabc71d70
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc71de0
        public void RemoveAll(){} // RVA: 0x7ffaabb9ae10
        public void RemoveAt(){} // RVA: 0x7ffaabb9afb0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabb9b0f0
        public void Reverse(){} // RVA: 0x7ffaabb9b0f0
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void Sort(){} // RVA: 0x7ffaabb9b370
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb94300
        public void AddEnumerable(){} // RVA: 0x7ffaabc72150
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
    }

    public class List`1 : Object
    {
        public object _size; // 0x356A3660
        public object s_emptyArray; // 0x356A3660

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
        public object _size; // 0x3570F3F0
        public object s_emptyArray; // 0x3570F3F0

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
        public object _size; // 0x35710FE0
        public object s_emptyArray; // 0x35710FE0

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
        public object _size; // 0x3573CA30
        public object s_emptyArray; // 0x3573CA30

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
        public object _size; // 0x3577F500
        public object s_emptyArray; // 0x3577F500
        public object Қf; // 0x201D0000

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
        public object _size; // 0x35788948
        public object s_emptyArray; // 0x35788948

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
        public object _size; // 0x3578C020
        public object s_emptyArray; // 0x3578C020

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
        public object _size; // 0x357DBF98
        public object s_emptyArray; // 0x357DBF98

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
        public object _size; // 0x357E5560
        public object s_emptyArray; // 0x357E5560

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
        public object _size; // 0x357F7A78
        public object s_emptyArray; // 0x357F7A78

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
        public object _size; // 0x358100F0
        public object s_emptyArray; // 0x358100F0

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
        public object _size; // 0x35815E38
        public object s_emptyArray; // 0x35815E38

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
        public object _size; // 0x3582E500
        public object s_emptyArray; // 0x3582E500
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3582EBD0
        public object s_emptyArray; // 0x3582EBD0
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35838C10
        public object s_emptyArray; // 0x35838C10
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35842098
        public object s_emptyArray; // 0x35842098
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x358540F8
        public object s_emptyArray; // 0x358540F8
        public object D4:g;

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
        public object _size; // 0x35862258
        public object s_emptyArray; // 0x35862258
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3586F150
        public object s_emptyArray; // 0x3586F150
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35876D50
        public object s_emptyArray; // 0x35876D50
        public object D4:g;

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
        public object _size; // 0x35877118
        public object s_emptyArray; // 0x35877118
        public object D4:g;

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
        public object _size; // 0x35882370
        public object s_emptyArray; // 0x35882370
        public object @S1; // 0x150000
        public object @S1; // 0x150000
    }

    public class List`1 : Object
    {
        public object _size; // 0x35883CA0
        public object s_emptyArray; // 0x35883CA0
        public object D4:g;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabcd8d10
        public void .ctor(){} // RVA: 0x7ffaabcd8d10
        public void .ctor(){} // RVA: 0x7ffaabcd8d10
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabcd8f80
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabbe2300
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabcd9030
        public void Add(){} // RVA: 0x7ffaabb57370
        public void AddWithResize(){} // RVA: 0x7ffaabbe2530
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbe2600
        public void AddRange(){} // RVA: 0x7ffaabcd9130
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabcd9270
        public void BinarySearch(){} // RVA: 0x7ffaabcd9270
        public void BinarySearch(){} // RVA: 0x7ffaabcd9270
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabcd92f0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabcd9360
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb95250
        public void Find(){} // RVA: 0x7ffaabb95310
        public void FindAll(){} // RVA: 0x7ffaabcd94e0
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void ForEach(){} // RVA: 0x7ffaabb958e0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void IndexOf(){} // RVA: 0x7ffaabcd9850
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabcd9690
        public void IndexOf(){} // RVA: 0x7ffaabcd9850
        public void IndexOf(){} // RVA: 0x7ffaabcd9850
        public void Insert(){} // RVA: 0x7ffaabbe2f20
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbe3050
        public void InsertRange(){} // RVA: 0x7ffaabcd98c0
        public void LastIndexOf(){} // RVA: 0x7ffaabcd9d30
        public void LastIndexOf(){} // RVA: 0x7ffaabcd9d30
        public void LastIndexOf(){} // RVA: 0x7ffaabcd9d30
        public void Remove(){} // RVA: 0x7ffaabcd9e00
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabcd9e80
        public void RemoveAll(){} // RVA: 0x7ffaabbe3a40
        public void RemoveAt(){} // RVA: 0x7ffaabbe3bd0
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabbe3d30
        public void Reverse(){} // RVA: 0x7ffaabbe3d30
        public void Sort(){} // RVA: 0x7ffaabbe3fb0
        public void Sort(){} // RVA: 0x7ffaabbe3fb0
        public void Sort(){} // RVA: 0x7ffaabbe3fb0
        public void Sort(){} // RVA: 0x7ffaabbe3fb0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabb96ec0
        public void AddEnumerable(){} // RVA: 0x7ffaabcda200
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35890980
        public object s_emptyArray; // 0x35890980

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
        public object _size; // 0x35896930
        public object s_emptyArray; // 0x35896930
        public object IsNullOrEmpty; // 0xB41EFD10

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
        public object _size; // 0x3589BE18
        public object s_emptyArray; // 0x3589BE18

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
        public object _size; // 0x358FB560
        public object s_emptyArray; // 0x358FB560

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
        public object _size; // 0x35900008
        public object s_emptyArray; // 0x35900008

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
        public object _size; // 0x35904848
        public object s_emptyArray; // 0x35904848

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
        public object _size; // 0x3591DC80
        public object s_emptyArray; // 0x3591DC80

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
        public object _size; // 0x35C0B670
        public object s_emptyArray; // 0x35C0B670

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
        public object _size; // 0x35C12150
        public object s_emptyArray; // 0x35C12150
        public object l_(g;

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
        public object _size; // 0x35C177D0
        public object s_emptyArray; // 0x35C177D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc9ae10
        public void .ctor(){} // RVA: 0x7ffaabc9ae10
        public void .ctor(){} // RVA: 0x7ffaabc9ae10
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc9b080
        public void get_Item(){} // RVA: 0x7ffaabc9b130
        public void set_Item(){} // RVA: 0x7ffaabc9b170
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabc9b1b0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabc9b210
        public void Add(){} // RVA: 0x7ffaabc9b320
        public void AddWithResize(){} // RVA: 0x7ffaabc9b380
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabc9b3f0
        public void AddRange(){} // RVA: 0x7ffaabc9b520
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc9b730
        public void BinarySearch(){} // RVA: 0x7ffaabc9b730
        public void BinarySearch(){} // RVA: 0x7ffaabc9b730
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabc9b770
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc9b7d0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabc9b930
        public void Find(){} // RVA: 0x7ffaabc9b9d0
        public void FindAll(){} // RVA: 0x7ffaabc9ba80
        public void FindIndex(){} // RVA: 0x7ffaabc9bc50
        public void FindIndex(){} // RVA: 0x7ffaabc9bc50
        public void FindLastIndex(){} // RVA: 0x7ffaabc9bdd0
        public void FindLastIndex(){} // RVA: 0x7ffaabc9bdd0
        public void ForEach(){} // RVA: 0x7ffaabc9beb0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabc9c110
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc9bf80
        public void IndexOf(){} // RVA: 0x7ffaabc9c110
        public void IndexOf(){} // RVA: 0x7ffaabc9c110
        public void Insert(){} // RVA: 0x7ffaabc9c170
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabc9c240
        public void InsertRange(){} // RVA: 0x7ffaabc9c330
        public void LastIndexOf(){} // RVA: 0x7ffaabc9c6f0
        public void LastIndexOf(){} // RVA: 0x7ffaabc9c6f0
        public void LastIndexOf(){} // RVA: 0x7ffaabc9c6f0
        public void Remove(){} // RVA: 0x7ffaabc9c7a0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc9c840
        public void RemoveAll(){} // RVA: 0x7ffaabc9c9e0
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabc9cc40
        public void Reverse(){} // RVA: 0x7ffaabc9cc40
        public void Sort(){} // RVA: 0x7ffaabc9cfa0
        public void Sort(){} // RVA: 0x7ffaabc9cfa0
        public void Sort(){} // RVA: 0x7ffaabc9cfa0
        public void Sort(){} // RVA: 0x7ffaabc9cfa0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabc9d060
        public void AddEnumerable(){} // RVA: 0x7ffaabc9d0f0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35C2FAF8
        public object s_emptyArray; // 0x35C2FAF8
        public object yDg;

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
        public object _size; // 0x35C65860
        public object s_emptyArray; // 0x35C65860

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
        public object _size; // 0x35C81488
        public object s_emptyArray; // 0x35C81488
    }

    public class List`1 : Object
    {
        public object _size; // 0x35C92EC0
        public object s_emptyArray; // 0x35C92EC0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35CC1558
        public object s_emptyArray; // 0x35CC1558

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
        public object _size; // 0x35CC54E0
        public object s_emptyArray; // 0x35CC54E0
        public object x00; // 0x302FFD08
        public object ; // 0x347104A0

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
        public object _size; // 0x35CD32B8
        public object s_emptyArray; // 0x35CD32B8

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
        public object _size; // 0x35CECD28
        public object s_emptyArray; // 0x35CECD28

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
        public object _size; // 0x35CFBE78
        public object s_emptyArray; // 0x35CFBE78

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
        public object _size; // 0x35D00D80
        public object s_emptyArray; // 0x35D00D80

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabd3cad0
        public void .ctor(){} // RVA: 0x7ffaabd3cad0
        public void .ctor(){} // RVA: 0x7ffaabd3cad0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabd3cd40
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd290
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabcdec00
        public void Add(){} // RVA: 0x7ffaabcded00
        public void AddWithResize(){} // RVA: 0x7ffaabcded60
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabcdedc0
        public void AddRange(){} // RVA: 0x7ffaabd3cdf0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabd3d000
        public void BinarySearch(){} // RVA: 0x7ffaabd3d000
        public void BinarySearch(){} // RVA: 0x7ffaabd3d000
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabd3d040
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabd3d0a0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbeeff0
        public void Find(){} // RVA: 0x7ffaabbbda50
        public void FindAll(){} // RVA: 0x7ffaabcdf300
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabd3d3c0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabd3d230
        public void IndexOf(){} // RVA: 0x7ffaabd3d3c0
        public void IndexOf(){} // RVA: 0x7ffaabd3d3c0
        public void Insert(){} // RVA: 0x7ffaabcdf640
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabcdf700
        public void InsertRange(){} // RVA: 0x7ffaabd3d420
        public void LastIndexOf(){} // RVA: 0x7ffaabd3d7d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3d7d0
        public void LastIndexOf(){} // RVA: 0x7ffaabd3d7d0
        public void Remove(){} // RVA: 0x7ffaabd3d880
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabd3d940
        public void RemoveAll(){} // RVA: 0x7ffaabcdfec0
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabce00e0
        public void Reverse(){} // RVA: 0x7ffaabce00e0
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbbf2c0
        public void AddEnumerable(){} // RVA: 0x7ffaabd3dd00
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35D06928
        public object s_emptyArray; // 0x35D06928

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabcde8a0
        public void .ctor(){} // RVA: 0x7ffaabcde8a0
        public void .ctor(){} // RVA: 0x7ffaabcde8a0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabcdeb10
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabcdebc0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd290
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabcdec00
        public void Add(){} // RVA: 0x7ffaabcded00
        public void AddWithResize(){} // RVA: 0x7ffaabcded60
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabcdedc0
        public void AddRange(){} // RVA: 0x7ffaabcdeef0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabcdf100
        public void BinarySearch(){} // RVA: 0x7ffaabcdf100
        public void BinarySearch(){} // RVA: 0x7ffaabcdf100
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabcdf140
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabcdf1a0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbeeff0
        public void Find(){} // RVA: 0x7ffaabbbda50
        public void FindAll(){} // RVA: 0x7ffaabcdf300
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabcdf5e0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabcdf450
        public void IndexOf(){} // RVA: 0x7ffaabcdf5e0
        public void IndexOf(){} // RVA: 0x7ffaabcdf5e0
        public void Insert(){} // RVA: 0x7ffaabcdf640
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabcdf700
        public void InsertRange(){} // RVA: 0x7ffaabcdf7f0
        public void LastIndexOf(){} // RVA: 0x7ffaabcdfba0
        public void LastIndexOf(){} // RVA: 0x7ffaabcdfba0
        public void LastIndexOf(){} // RVA: 0x7ffaabcdfba0
        public void Remove(){} // RVA: 0x7ffaabcdfc50
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabcdfd10
        public void RemoveAll(){} // RVA: 0x7ffaabcdfec0
        public void RemoveAt(){} // RVA: 0x7ffaabce0000
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabce00e0
        public void Reverse(){} // RVA: 0x7ffaabce00e0
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void Sort(){} // RVA: 0x7ffaabce0360
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbbf2c0
        public void AddEnumerable(){} // RVA: 0x7ffaabce0420
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35D344D8
        public object s_emptyArray; // 0x35D344D8
    }

    public class List`1 : Object
    {
        public object _size; // 0x35D37368
        public object s_emptyArray; // 0x35D37368

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc95720
        public void .ctor(){} // RVA: 0x7ffaabc95720
        public void .ctor(){} // RVA: 0x7ffaabc95720
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc95990
        public void get_Item(){} // RVA: 0x7ffaabbd4250
        public void set_Item(){} // RVA: 0x7ffaabbd42a0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbd4350
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabc95a40
        public void Add(){} // RVA: 0x7ffaab265a30
        public void AddWithResize(){} // RVA: 0x7ffaabbd4540
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbd4610
        public void AddRange(){} // RVA: 0x7ffaabc95b40
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc95c80
        public void BinarySearch(){} // RVA: 0x7ffaabc95c80
        public void BinarySearch(){} // RVA: 0x7ffaabc95c80
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc95d00
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc95d70
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbd4ad0
        public void Find(){} // RVA: 0x7ffaabbd4b90
        public void FindAll(){} // RVA: 0x7ffaabbd4c80
        public void FindIndex(){} // RVA: 0x7ffaabbd4f20
        public void FindIndex(){} // RVA: 0x7ffaabbd4f20
        public void FindLastIndex(){} // RVA: 0x7ffaabbd50e0
        public void FindLastIndex(){} // RVA: 0x7ffaabbd50e0
        public void ForEach(){} // RVA: 0x7ffaabbd51d0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbd5330
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbd5330
        public void IndexOf(){} // RVA: 0x7ffaabc96100
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc95f40
        public void IndexOf(){} // RVA: 0x7ffaabc96100
        public void IndexOf(){} // RVA: 0x7ffaabc96100
        public void Insert(){} // RVA: 0x7ffaabbd5680
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbd57b0
        public void InsertRange(){} // RVA: 0x7ffaabc96170
        public void LastIndexOf(){} // RVA: 0x7ffaabc965e0
        public void LastIndexOf(){} // RVA: 0x7ffaabc965e0
        public void LastIndexOf(){} // RVA: 0x7ffaabc965e0
        public void Remove(){} // RVA: 0x7ffaabc966b0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc967f0
        public void RemoveAll(){} // RVA: 0x7ffaabbd6170
        public void RemoveAt(){} // RVA: 0x7ffaabbd6300
        public void RemoveRange(){} // RVA: 0x7ffaabb93d70
        public void Reverse(){} // RVA: 0x7ffaabbd6440
        public void Reverse(){} // RVA: 0x7ffaabbd6440
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void Sort(){} // RVA: 0x7ffaabbd66c0
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabbd6780
        public void AddEnumerable(){} // RVA: 0x7ffaabc96c30
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbd5290
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x35D3FC00
        public object s_emptyArray; // 0x35D3FC00

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
        public object _size; // 0x35D4B100
        public object s_emptyArray; // 0x35D4B100

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc2a340
        public void .ctor(){} // RVA: 0x7ffaabc2a340
        public void .ctor(){} // RVA: 0x7ffaabc2a340
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc2a5b0
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabb97520
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb975d0
        public void Add(){} // RVA: 0x7ffaa8bd1b80
        public void AddWithResize(){} // RVA: 0x7ffaabb97750
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbf48d0
        public void AddRange(){} // RVA: 0x7ffaabc2a660
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc2a7a0
        public void BinarySearch(){} // RVA: 0x7ffaabc2a7a0
        public void BinarySearch(){} // RVA: 0x7ffaabc2a7a0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc2a820
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc2a890
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb95250
        public void Find(){} // RVA: 0x7ffaabb95310
        public void FindAll(){} // RVA: 0x7ffaabbf4d90
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindIndex(){} // RVA: 0x7ffaabb95630
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void FindLastIndex(){} // RVA: 0x7ffaabb957f0
        public void ForEach(){} // RVA: 0x7ffaabb958e0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb95a30
        public void IndexOf(){} // RVA: 0x7ffaabc2ac20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc2aa60
        public void IndexOf(){} // RVA: 0x7ffaabc2ac20
        public void IndexOf(){} // RVA: 0x7ffaabc2ac20
        public void Insert(){} // RVA: 0x7ffaabb98140
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb98270
        public void InsertRange(){} // RVA: 0x7ffaabc2ac90
        public void LastIndexOf(){} // RVA: 0x7ffaabc2b100
        public void LastIndexOf(){} // RVA: 0x7ffaabc2b100
        public void LastIndexOf(){} // RVA: 0x7ffaabc2b100
        public void Remove(){} // RVA: 0x7ffaabc2b1d0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc2b320
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
        public void AddEnumerable(){} // RVA: 0x7ffaabc2b770
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class LowLevelDictionary`2 : Object
    {
        public object _version; // 0x350AA088

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabef4330
        public void .ctor(){} // RVA: 0x7ffaabef4330
        public void set_Item(){} // RVA: 0x7ffaabef4440
        public void Clear(){} // RVA: 0x7ffaabef45e0
        public void Remove(){} // RVA: 0x7ffaabef4690
        public void Find(){} // RVA: 0x7ffaabef47f0
        public void UncheckedAdd(){} // RVA: 0x7ffaabef4910
        public void ExpandBuckets(){} // RVA: 0x7ffaabef4b00
        // ── Binary Analysis Named ──
        public void GetBucket(){} // RVA: 0x7ffaabef4c90
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabef5f60
        public void .ctor(){} // RVA: 0x7ffaabef5f60
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabef5fd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabef5fd0
    }

    public class LowLevelList`1 : Object
    {
        public object _size; // 0x350D70B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabef61c0
        public void .ctor(){} // RVA: 0x7ffaabef61c0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabef6370
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void get_Item(){} // RVA: 0x7ffaabef64b0
        public void set_Item(){} // RVA: 0x7ffaabef6520
        public void Add(){} // RVA: 0x7ffaabef6590
        public void EnsureCapacity(){} // RVA: 0x7ffaabef6600
        public void AddRange(){} // RVA: 0x7ffaabef6770
        public void Clear(){} // RVA: 0x7ffaabef6790
        public void Contains(){} // RVA: 0x7ffaabef67d0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void IndexOf(){} // RVA: 0x7ffaabef6870
        public void Insert(){} // RVA: 0x7ffaabef68a0
        public void InsertRange(){} // RVA: 0x7ffaabef69a0
        public void Remove(){} // RVA: 0x7ffaabef6d40
        public void RemoveAll(){} // RVA: 0x7ffaabef6e50
        public void RemoveAt(){} // RVA: 0x7ffaabef6fc0
        public void .cctor(){} // RVA: 0x7ffaabb94610
    }

    public class LowLevelList`1 : Object
    {
        public object _size; // 0x350DCC88
        public object Capacity; // 0x170008E7

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabef61c0
        public void .ctor(){} // RVA: 0x7ffaabef61c0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabef6370
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void get_Item(){} // RVA: 0x7ffaabef64b0
        public void set_Item(){} // RVA: 0x7ffaabef6520
        public void Add(){} // RVA: 0x7ffaabef6590
        public void EnsureCapacity(){} // RVA: 0x7ffaabef6600
        public void AddRange(){} // RVA: 0x7ffaabef6770
        public void Clear(){} // RVA: 0x7ffaabef6790
        public void Contains(){} // RVA: 0x7ffaabef67d0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void IndexOf(){} // RVA: 0x7ffaabef6870
        public void Insert(){} // RVA: 0x7ffaabef68a0
        public void InsertRange(){} // RVA: 0x7ffaabef69a0
        public void Remove(){} // RVA: 0x7ffaabef6d40
        public void RemoveAll(){} // RVA: 0x7ffaabef6e50
        public void RemoveAt(){} // RVA: 0x7ffaabef6fc0
        public void .cctor(){} // RVA: 0x7ffaabb94610
    }

}