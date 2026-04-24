// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 80
// Methods: 4695

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class LargeArrayBuilder`1 : ValueType
    {
        public object _buffers; // 0x37C50D90
        public object _count; // 0x37C50D90

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
        public object _size; // 0x37803B28
        public object s_emptyArray; // 0x37803B28
        public object Release; // 0xB3F6FFF0

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
        public object _size; // 0x37814828
        public object s_emptyArray; // 0x37814828

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
        public object _size; // 0x37816658
        public object s_emptyArray; // 0x37816658

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
        public object _size; // 0x3782CC30
        public object s_emptyArray; // 0x3782CC30

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc7e150
        public void .ctor(){} // RVA: 0x7ffaabc7e150
        public void .ctor(){} // RVA: 0x7ffaabc7e150
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc7e3c0
        public void get_Item(){} // RVA: 0x7ffaabc7e470
        public void set_Item(){} // RVA: 0x7ffaabc7e4b0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabc7e4f0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabc7e550
        public void Add(){} // RVA: 0x7ffaabc7e660
        public void AddWithResize(){} // RVA: 0x7ffaabc7e6c0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabc7e730
        public void AddRange(){} // RVA: 0x7ffaabc7e860
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc7ea70
        public void BinarySearch(){} // RVA: 0x7ffaabc7ea70
        public void BinarySearch(){} // RVA: 0x7ffaabc7ea70
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabc7eab0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc7eb10
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabc7ec70
        public void Find(){} // RVA: 0x7ffaabc7ed10
        public void FindAll(){} // RVA: 0x7ffaabc7edb0
        public void FindIndex(){} // RVA: 0x7ffaabc7ef70
        public void FindIndex(){} // RVA: 0x7ffaabc7ef70
        public void FindLastIndex(){} // RVA: 0x7ffaabc7f0f0
        public void FindLastIndex(){} // RVA: 0x7ffaabc7f0f0
        public void ForEach(){} // RVA: 0x7ffaabc7f1c0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabc7f2f0
        public void IndexOf(){} // RVA: 0x7ffaabc7f560
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc7f3e0
        public void IndexOf(){} // RVA: 0x7ffaabc7f560
        public void IndexOf(){} // RVA: 0x7ffaabc7f560
        public void Insert(){} // RVA: 0x7ffaabc7f5c0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabc7f680
        public void InsertRange(){} // RVA: 0x7ffaabc7f770
        public void LastIndexOf(){} // RVA: 0x7ffaabc7fb20
        public void LastIndexOf(){} // RVA: 0x7ffaabc7fb20
        public void LastIndexOf(){} // RVA: 0x7ffaabc7fb20
        public void Remove(){} // RVA: 0x7ffaabc7fbd0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc7fc70
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
        public void AddEnumerable(){} // RVA: 0x7ffaabc80500
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabc7f260
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37832528
        public object s_emptyArray; // 0x37832528

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
        public object _size; // 0x37850F08
        public object s_emptyArray; // 0x37850F08

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
        public object _size; // 0x378628C8
        public object s_emptyArray; // 0x378628C8

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
        public object _size; // 0x378706F0
        public object s_emptyArray; // 0x378706F0

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
        public object _size; // 0x3787BF68
        public object s_emptyArray; // 0x3787BF68

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
        public object _size; // 0x378817A0
        public object s_emptyArray; // 0x378817A0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc0eb50
        public void .ctor(){} // RVA: 0x7ffaabc0eb50
        public void .ctor(){} // RVA: 0x7ffaabc0eb50
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc0edc0
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaa8b2c8e0
        public void AddWithResize(){} // RVA: 0x7ffaabb91da0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbccb80
        public void AddRange(){} // RVA: 0x7ffaabc0ee70
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc0efa0
        public void BinarySearch(){} // RVA: 0x7ffaabc0efa0
        public void BinarySearch(){} // RVA: 0x7ffaabc0efa0
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabc0f010
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc0f080
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
        public void IndexOf(){} // RVA: 0x7ffaabc0f3d0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc0f230
        public void IndexOf(){} // RVA: 0x7ffaabc0f3d0
        public void IndexOf(){} // RVA: 0x7ffaabc0f3d0
        public void Insert(){} // RVA: 0x7ffaabb930f0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb93220
        public void InsertRange(){} // RVA: 0x7ffaabc0f440
        public void LastIndexOf(){} // RVA: 0x7ffaabc0f820
        public void LastIndexOf(){} // RVA: 0x7ffaabc0f820
        public void LastIndexOf(){} // RVA: 0x7ffaabc0f820
        public void Remove(){} // RVA: 0x7ffaabc0f8e0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc0fa00
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
        public void AddEnumerable(){} // RVA: 0x7ffaabc0fe30
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37882E28
        public object s_emptyArray; // 0x37882E28

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabdcd730
        public void .ctor(){} // RVA: 0x7ffaabdcd730
        public void .ctor(){} // RVA: 0x7ffaabdcd730
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabdcd9a0
        public void get_Item(){} // RVA: 0x7ffaabd2d070
        public void set_Item(){} // RVA: 0x7ffaabd2d0f0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabd2d180
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabd2d230
        public void Add(){} // RVA: 0x7ffaabd2d370
        public void AddWithResize(){} // RVA: 0x7ffaabd2d450
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabd2d4f0
        public void AddRange(){} // RVA: 0x7ffaabdcda50
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabdcdbd0
        public void BinarySearch(){} // RVA: 0x7ffaabdcdbd0
        public void BinarySearch(){} // RVA: 0x7ffaabdcdbd0
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabdcdc50
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabdcdcf0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabd2da80
        public void Find(){} // RVA: 0x7ffaabd2db90
        public void FindAll(){} // RVA: 0x7ffaabd2dcf0
        public void FindIndex(){} // RVA: 0x7ffaabd2dfc0
        public void FindIndex(){} // RVA: 0x7ffaabd2dfc0
        public void FindLastIndex(){} // RVA: 0x7ffaabd2e210
        public void FindLastIndex(){} // RVA: 0x7ffaabd2e210
        public void ForEach(){} // RVA: 0x7ffaabd2e350
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabd2e510
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabd2e510
        public void IndexOf(){} // RVA: 0x7ffaabdce130
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabdcdf10
        public void IndexOf(){} // RVA: 0x7ffaabdce130
        public void IndexOf(){} // RVA: 0x7ffaabdce130
        public void Insert(){} // RVA: 0x7ffaabd2e950
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabd2ea50
        public void InsertRange(){} // RVA: 0x7ffaabdce1e0
        public void LastIndexOf(){} // RVA: 0x7ffaabdce670
        public void LastIndexOf(){} // RVA: 0x7ffaabdce670
        public void LastIndexOf(){} // RVA: 0x7ffaabdce670
        public void Remove(){} // RVA: 0x7ffaabdce790
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabdce870
        public void RemoveAll(){} // RVA: 0x7ffaabd2f400
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabd2f810
        public void Reverse(){} // RVA: 0x7ffaabd2f810
        public void Sort(){} // RVA: 0x7ffaabd2fc40
        public void Sort(){} // RVA: 0x7ffaabd2fc40
        public void Sort(){} // RVA: 0x7ffaabd2fc40
        public void Sort(){} // RVA: 0x7ffaabd2fc40
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabd2fd00
        public void AddEnumerable(){} // RVA: 0x7ffaabdcec60
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabd2e450
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3789EED0
        public object s_emptyArray; // 0x3789EED0

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
        public object _size; // 0x379F85C0
        public object s_emptyArray; // 0x379F85C0
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x379FEC90
        public object s_emptyArray; // 0x379FEC90

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
        public object _size; // 0x37A1C3C0
        public object s_emptyArray; // 0x37A1C3C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabc77a20
        public void .ctor(){} // RVA: 0x7ffaabc77a20
        public void .ctor(){} // RVA: 0x7ffaabc77a20
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabc77c90
        public void get_Item(){} // RVA: 0x7ffaabc77d40
        public void set_Item(){} // RVA: 0x7ffaabc77d80
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabc77dc0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabc77e20
        public void Add(){} // RVA: 0x7ffaabc77f30
        public void AddWithResize(){} // RVA: 0x7ffaabc77f90
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabc78000
        public void AddRange(){} // RVA: 0x7ffaabc78130
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabc78340
        public void BinarySearch(){} // RVA: 0x7ffaabc78340
        public void BinarySearch(){} // RVA: 0x7ffaabc78340
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabc78380
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabc783e0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabc78540
        public void Find(){} // RVA: 0x7ffaabc785e0
        public void FindAll(){} // RVA: 0x7ffaabc78690
        public void FindIndex(){} // RVA: 0x7ffaabc78860
        public void FindIndex(){} // RVA: 0x7ffaabc78860
        public void FindLastIndex(){} // RVA: 0x7ffaabc789e0
        public void FindLastIndex(){} // RVA: 0x7ffaabc789e0
        public void ForEach(){} // RVA: 0x7ffaabc78ac0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabc78bf0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabc78bf0
        public void IndexOf(){} // RVA: 0x7ffaabc78e70
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabc78ce0
        public void IndexOf(){} // RVA: 0x7ffaabc78e70
        public void IndexOf(){} // RVA: 0x7ffaabc78e70
        public void Insert(){} // RVA: 0x7ffaabc78ed0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabc78fa0
        public void InsertRange(){} // RVA: 0x7ffaabc79090
        public void LastIndexOf(){} // RVA: 0x7ffaabc79450
        public void LastIndexOf(){} // RVA: 0x7ffaabc79450
        public void LastIndexOf(){} // RVA: 0x7ffaabc79450
        public void Remove(){} // RVA: 0x7ffaabc79500
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabc795a0
        public void RemoveAll(){} // RVA: 0x7ffaabc79740
        public void RemoveAt(){} // RVA: 0x7ffaabbbeca0
        public void RemoveRange(){} // RVA: 0x7ffaabbbecf0
        public void Reverse(){} // RVA: 0x7ffaabc798e0
        public void Reverse(){} // RVA: 0x7ffaabc798e0
        public void Sort(){} // RVA: 0x7ffaabc79b60
        public void Sort(){} // RVA: 0x7ffaabc79b60
        public void Sort(){} // RVA: 0x7ffaabc79b60
        public void Sort(){} // RVA: 0x7ffaabc79b60
        public void ToArray(){} // RVA: 0x7ffaabb941c0
        public void TrimExcess(){} // RVA: 0x7ffaabb942b0
        public void TrueForAll(){} // RVA: 0x7ffaabc79c20
        public void AddEnumerable(){} // RVA: 0x7ffaabc79cb0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabc78b60
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37A798D0
        public object s_emptyArray; // 0x37A798D0

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
        public object _size; // 0x37A93458
        public object s_emptyArray; // 0x37A93458

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
        public object _size; // 0x37A9E930
        public object s_emptyArray; // 0x37A9E930

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
        public object _size; // 0x37AA3F60
        public object s_emptyArray; // 0x37AA3F60

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
        public object _size; // 0x37AC1040
        public object s_emptyArray; // 0x37AC1040

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
        public object _size; // 0x37AC1408
        public object s_emptyArray; // 0x37AC1408

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
        public object _size; // 0x37ADABB8
        public object s_emptyArray; // 0x37ADABB8
        public object .ctor; // 0xB3F6FFF0

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
        public object _size; // 0x37AE61B0
        public object s_emptyArray; // 0x37AE61B0
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37AE6880
        public object s_emptyArray; // 0x37AE6880
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37AEB638
        public object s_emptyArray; // 0x37AEB638
    }

    public class List`1 : Object
    {
        public object _size; // 0x37AEDC70
        public object s_emptyArray; // 0x37AEDC70

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
        public object _size; // 0x37B1F230
        public object s_emptyArray; // 0x37B1F230

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
        public object _size; // 0x37B23D48
        public object s_emptyArray; // 0x37B23D48

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
        public object _size; // 0x37B4F198
        public object s_emptyArray; // 0x37B4F198

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
        public object _size; // 0x37B5B2A0
        public object s_emptyArray; // 0x37B5B2A0

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
        public object _size; // 0x37B7FA30
        public object s_emptyArray; // 0x37B7FA30
        public object .ctor; // 0xB3F6FFF0

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
        public object _size; // 0x37B915E0
        public object s_emptyArray; // 0x37B915E0

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
        public object _size; // 0x37B94C00
        public object s_emptyArray; // 0x37B94C00

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
        public object _size; // 0x37BBBCD8
        public object s_emptyArray; // 0x37BBBCD8

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
        public object _size; // 0x37BD9B90
        public object s_emptyArray; // 0x37BD9B90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabbf45b0
        public void .ctor(){} // RVA: 0x7ffaabbf45b0
        public void .ctor(){} // RVA: 0x7ffaabbf45b0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabbf4820
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabb97520
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb975d0
        public void Add(){} // RVA: 0x7ffaa8bd1b80
        public void AddWithResize(){} // RVA: 0x7ffaabb97750
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbf48d0
        public void AddRange(){} // RVA: 0x7ffaabbf49e0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabbf4b20
        public void BinarySearch(){} // RVA: 0x7ffaabbf4b20
        public void BinarySearch(){} // RVA: 0x7ffaabbf4b20
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabbf4ba0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabbf4c10
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
        public void IndexOf(){} // RVA: 0x7ffaabbf5100
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabbf4f40
        public void IndexOf(){} // RVA: 0x7ffaabbf5100
        public void IndexOf(){} // RVA: 0x7ffaabbf5100
        public void Insert(){} // RVA: 0x7ffaabb98140
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb98270
        public void InsertRange(){} // RVA: 0x7ffaabbf5170
        public void LastIndexOf(){} // RVA: 0x7ffaabbf5580
        public void LastIndexOf(){} // RVA: 0x7ffaabbf5580
        public void LastIndexOf(){} // RVA: 0x7ffaabbf5580
        public void Remove(){} // RVA: 0x7ffaabbf5650
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabbf57a0
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
        public void AddEnumerable(){} // RVA: 0x7ffaabbf5bf0
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37C00B78
        public object s_emptyArray; // 0x37C00B78

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
        public object _size; // 0x37C2B228
        public object s_emptyArray; // 0x37C2B228

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
        public object _size; // 0x37C5F0F0
        public object s_emptyArray; // 0x37C5F0F0

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
        public object _size; // 0x37C64338
        public object s_emptyArray; // 0x37C64338
        public object @S1; // 0x150000
        public object @S1; // 0x150000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabb97200
        public void .ctor(){} // RVA: 0x7ffaabb97200
        public void .ctor(){} // RVA: 0x7ffaabb97200
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabb97470
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabb97520
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb975d0
        public void Add(){} // RVA: 0x7ffaa8bd1b80
        public void AddWithResize(){} // RVA: 0x7ffaabb97750
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabb97820
        public void AddRange(){} // RVA: 0x7ffaabb97930
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabb97a70
        public void BinarySearch(){} // RVA: 0x7ffaabb97a70
        public void BinarySearch(){} // RVA: 0x7ffaabb97a70
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabb97af0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabb97b60
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
        public void IndexOf(){} // RVA: 0x7ffaabb980d0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabb97f10
        public void IndexOf(){} // RVA: 0x7ffaabb980d0
        public void IndexOf(){} // RVA: 0x7ffaabb980d0
        public void Insert(){} // RVA: 0x7ffaabb98140
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb98270
        public void InsertRange(){} // RVA: 0x7ffaabb98380
        public void LastIndexOf(){} // RVA: 0x7ffaabb987f0
        public void LastIndexOf(){} // RVA: 0x7ffaabb987f0
        public void LastIndexOf(){} // RVA: 0x7ffaabb987f0
        public void Remove(){} // RVA: 0x7ffaabb988c0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabb98a10
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
        public void AddEnumerable(){} // RVA: 0x7ffaabb99270
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37C76FB0
        public object s_emptyArray; // 0x37C76FB0

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
        public object _size; // 0x37CC9158
        public object s_emptyArray; // 0x37CC9158

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
        public object _size; // 0x37F58620
        public object s_emptyArray; // 0x37F58620

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabdd60f0
        public void .ctor(){} // RVA: 0x7ffaabdd60f0
        public void .ctor(){} // RVA: 0x7ffaabdd60f0
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabdd6360
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabbe2300
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbe23b0
        public void Add(){} // RVA: 0x7ffaabb57370
        public void AddWithResize(){} // RVA: 0x7ffaabbe2530
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbe2600
        public void AddRange(){} // RVA: 0x7ffaabdd6410
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabdd6550
        public void BinarySearch(){} // RVA: 0x7ffaabdd6550
        public void BinarySearch(){} // RVA: 0x7ffaabdd6550
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabdd65d0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabdd6640
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
        public void IndexOf(){} // RVA: 0x7ffaabdd69d0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabdd6810
        public void IndexOf(){} // RVA: 0x7ffaabdd69d0
        public void IndexOf(){} // RVA: 0x7ffaabdd69d0
        public void Insert(){} // RVA: 0x7ffaabbe2f20
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbe3050
        public void InsertRange(){} // RVA: 0x7ffaabdd6a40
        public void LastIndexOf(){} // RVA: 0x7ffaabdd6eb0
        public void LastIndexOf(){} // RVA: 0x7ffaabdd6eb0
        public void LastIndexOf(){} // RVA: 0x7ffaabdd6eb0
        public void Remove(){} // RVA: 0x7ffaabdd6f80
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabdd70d0
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
        public void AddEnumerable(){} // RVA: 0x7ffaabdd7530
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x37F685F0
        public object s_emptyArray; // 0x37F685F0
        public object Get; // 0x37F68D38

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
        public object _size; // 0x38616EB0
        public object s_emptyArray; // 0x38616EB0

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
        public object _size; // 0x387521F8
        public object s_emptyArray; // 0x387521F8
        public object 6iDg;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabe27530
        public void .ctor(){} // RVA: 0x7ffaabe27530
        public void .ctor(){} // RVA: 0x7ffaabe27530
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabe277a0
        public void get_Item(){} // RVA: 0x7ffaabb94a40
        public void set_Item(){} // RVA: 0x7ffaabbe2300
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb94b50
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbe23b0
        public void Add(){} // RVA: 0x7ffaabb57370
        public void AddWithResize(){} // RVA: 0x7ffaabbe2530
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbe2600
        public void AddRange(){} // RVA: 0x7ffaabe27850
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabe27990
        public void BinarySearch(){} // RVA: 0x7ffaabe27990
        public void BinarySearch(){} // RVA: 0x7ffaabe27990
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabe27a10
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabe27a80
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
        public void IndexOf(){} // RVA: 0x7ffaabe27e10
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabe27c50
        public void IndexOf(){} // RVA: 0x7ffaabe27e10
        public void IndexOf(){} // RVA: 0x7ffaabe27e10
        public void Insert(){} // RVA: 0x7ffaabbe2f20
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbe3050
        public void InsertRange(){} // RVA: 0x7ffaabe27e80
        public void LastIndexOf(){} // RVA: 0x7ffaabe282f0
        public void LastIndexOf(){} // RVA: 0x7ffaabe282f0
        public void LastIndexOf(){} // RVA: 0x7ffaabe282f0
        public void Remove(){} // RVA: 0x7ffaabe283c0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabe28510
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
        public void AddEnumerable(){} // RVA: 0x7ffaabe28970
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb959a0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x387525C8
        public object s_emptyArray; // 0x387525C8
        public object 6iDg;

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
        public object _size; // 0x387D3F30
        public object s_emptyArray; // 0x387D3F30

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
        public object _size; // 0x387DBDA8
        public object s_emptyArray; // 0x387DBDA8

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
        public object _size; // 0x38991BF0
        public object s_emptyArray; // 0x38991BF0
        public object Get; // 0x3865FEA8

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
        public object _size; // 0x38991FC0
        public object s_emptyArray; // 0x38991FC0
        public object Get; // 0x38995330

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
        public object _size; // 0x38992390
        public object s_emptyArray; // 0x38992390
        public object Get; // 0x387F7498

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
        public object _size; // 0x38992760
        public object s_emptyArray; // 0x38992760
        public object Get; // 0x389BA9A8

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
    }

    public class List`1 : Object
    {
        public object _size; // 0x389E3890
        public object s_emptyArray; // 0x389E3890
        public object Get; // 0x389E40E0

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
        public object _size; // 0x39C9B3A0
        public object s_emptyArray; // 0x39C9B3A0

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
        public object _size; // 0x39CD8448
        public object s_emptyArray; // 0x39CD8448
        public object Get; // 0x3A4ABDA8

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
        public object _size; // 0x39F20150
        public object s_emptyArray; // 0x39F20150
        public object @S1; // 0x150000
        public object @S1; // 0x150000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabbf8b10
        public void .ctor(){} // RVA: 0x7ffaabbf8b10
        public void .ctor(){} // RVA: 0x7ffaabbf8b10
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabbf8d80
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabbbd250
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd290
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbbd2f0
        public void Add(){} // RVA: 0x7ffaabbbd400
        public void AddWithResize(){} // RVA: 0x7ffaabbbd460
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbbd4d0
        public void AddRange(){} // RVA: 0x7ffaabbf8e30
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabbf9040
        public void BinarySearch(){} // RVA: 0x7ffaabbf9040
        public void BinarySearch(){} // RVA: 0x7ffaabbf9040
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabbf9080
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabbf90e0
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabbeeff0
        public void Find(){} // RVA: 0x7ffaabbbda50
        public void FindAll(){} // RVA: 0x7ffaabbef090
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindIndex(){} // RVA: 0x7ffaabbbdcb0
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void FindLastIndex(){} // RVA: 0x7ffaabbbde30
        public void ForEach(){} // RVA: 0x7ffaabbbdf10
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabbbe040
        public void IndexOf(){} // RVA: 0x7ffaabbf9400
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabbf9270
        public void IndexOf(){} // RVA: 0x7ffaabbf9400
        public void IndexOf(){} // RVA: 0x7ffaabbf9400
        public void Insert(){} // RVA: 0x7ffaabbbe320
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbbe3e0
        public void InsertRange(){} // RVA: 0x7ffaabbf9460
        public void LastIndexOf(){} // RVA: 0x7ffaabbf9820
        public void LastIndexOf(){} // RVA: 0x7ffaabbf9820
        public void LastIndexOf(){} // RVA: 0x7ffaabbf9820
        public void Remove(){} // RVA: 0x7ffaabbf98d0
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabbf9970
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
        public void AddEnumerable(){} // RVA: 0x7ffaabbf9d20
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x39F54B70
        public object s_emptyArray; // 0x39F54B70
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x39F55240
        public object s_emptyArray; // 0x39F55240
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x39F5BDB0
        public object s_emptyArray; // 0x39F5BDB0

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
        public object _size; // 0x39F67CF8
        public object s_emptyArray; // 0x39F67CF8
        public object `Ǐf; // 0xABB914C0
    }

    public class List`1 : Object
    {
        public object _size; // 0x39F69D50
        public object s_emptyArray; // 0x39F69D50

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
        public object _size; // 0x3A00CC70
        public object s_emptyArray; // 0x3A00CC70
        public object Get; // 0x3A00D3B8

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
        public object _size; // 0x3A0CF658
        public object s_emptyArray; // 0x3A0CF658

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabebfb80
        public void .ctor(){} // RVA: 0x7ffaabebfb80
        public void .ctor(){} // RVA: 0x7ffaabebfb80
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabebfdf0
        public void get_Item(){} // RVA: 0x7ffaabbbd210
        public void set_Item(){} // RVA: 0x7ffaabbbd250
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabbbd290
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabbbd2f0
        public void Add(){} // RVA: 0x7ffaabbbd400
        public void AddWithResize(){} // RVA: 0x7ffaabbbd460
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabbbd4d0
        public void AddRange(){} // RVA: 0x7ffaabebfea0
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabec00b0
        public void BinarySearch(){} // RVA: 0x7ffaabec00b0
        public void BinarySearch(){} // RVA: 0x7ffaabec00b0
        public void Clear(){} // RVA: 0x7ffaabbbd850
        public void Contains(){} // RVA: 0x7ffaabec00f0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabec0150
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
        public void IndexOf(){} // RVA: 0x7ffaabec0470
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabec02e0
        public void IndexOf(){} // RVA: 0x7ffaabec0470
        public void IndexOf(){} // RVA: 0x7ffaabec0470
        public void Insert(){} // RVA: 0x7ffaabbbe320
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabbbe3e0
        public void InsertRange(){} // RVA: 0x7ffaabec04d0
        public void LastIndexOf(){} // RVA: 0x7ffaabec0880
        public void LastIndexOf(){} // RVA: 0x7ffaabec0880
        public void LastIndexOf(){} // RVA: 0x7ffaabec0880
        public void Remove(){} // RVA: 0x7ffaabec0930
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabec09d0
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
        public void AddEnumerable(){} // RVA: 0x7ffaabec0d80
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabbbdfb0
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
        public object _size; // 0x3A0F8F78
        public object s_emptyArray; // 0x3A0F8F78
        public object Get; // 0x3A0F96C0

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
        public object _size; // 0x3A18DD28
        public object s_emptyArray; // 0x3A18DD28

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
        public object _size; // 0x3A1AFB30
        public object s_emptyArray; // 0x3A1AFB30

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
        public object _size; // 0x3A2C0200
        public object s_emptyArray; // 0x3A2C0200
        public object Get; // 0x3A2C0C08

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
        public object _size; // 0x3A584938
        public object s_emptyArray; // 0x3A584938
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
        public object _size; // 0x3A590038
        public object s_emptyArray; // 0x3A590038

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
        public object _size; // 0x3A590400
        public object s_emptyArray; // 0x3A590400

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
        public object _size; // 0x3A5AD4A8
        public object s_emptyArray; // 0x3A5AD4A8

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
        public object _size; // 0x3A5C8F78
        public object s_emptyArray; // 0x3A5C8F78

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
        public object _size; // 0x3A5DAED8
        public object s_emptyArray; // 0x3A5DAED8

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaabbcf630
        public void .ctor(){} // RVA: 0x7ffaabbcf630
        public void .ctor(){} // RVA: 0x7ffaabbcf630
        public void get_Capacity(){} // RVA: 0x7ffaa8f3de30
        public void set_Capacity(){} // RVA: 0x7ffaabb918b0
        public void get_Count(){} // RVA: 0x7ffaa8b945a0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0x7ffaa8932320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0x7ffaa8932320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x7ffaabbcf8a0
        public void get_Item(){} // RVA: 0x7ffaabb91a80
        public void set_Item(){} // RVA: 0x7ffaabb91ad0
        public void IsCompatibleObject(){} // RVA: 0x7ffaabb91b70
        public void System.Collections.IList.get_Item(){} // RVA: 0x7ffaabb91bd0
        public void System.Collections.IList.set_Item(){} // RVA: 0x7ffaabb91c30
        public void Add(){} // RVA: 0x7ffaa8b2c8e0
        public void AddWithResize(){} // RVA: 0x7ffaabb91da0
        public void System.Collections.IList.Add(){} // RVA: 0x7ffaabb91e60
        public void AddRange(){} // RVA: 0x7ffaabbcf950
        public void AsReadOnly(){} // RVA: 0x7ffaabb91f80
        public void BinarySearch(){} // RVA: 0x7ffaabbcfa80
        public void BinarySearch(){} // RVA: 0x7ffaabbcfa80
        public void BinarySearch(){} // RVA: 0x7ffaabbcfa80
        public void Clear(){} // RVA: 0x7ffaa8aa0290
        public void Contains(){} // RVA: 0x7ffaabbcfaf0
        public void System.Collections.IList.Contains(){} // RVA: 0x7ffaabbcfb60
        public void ConvertAll(){} // RVA: 0x7ffaa8649280
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x7ffaabb923b0
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void CopyTo(){} // RVA: 0x7ffaabb92450
        public void EnsureCapacity(){} // RVA: 0x7ffaabb92480
        public void Exists(){} // RVA: 0x7ffaabb924e0
        public void Find(){} // RVA: 0x7ffaabb92590
        public void FindAll(){} // RVA: 0x7ffaabb92660
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindIndex(){} // RVA: 0x7ffaabb928e0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void FindLastIndex(){} // RVA: 0x7ffaabb92aa0
        public void ForEach(){} // RVA: 0x7ffaabb92b90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7ffaabb92cd0
        public void IndexOf(){} // RVA: 0x7ffaabbcfeb0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x7ffaabbcfd10
        public void IndexOf(){} // RVA: 0x7ffaabbcfeb0
        public void IndexOf(){} // RVA: 0x7ffaabbcfeb0
        public void Insert(){} // RVA: 0x7ffaabb930f0
        public void System.Collections.IList.Insert(){} // RVA: 0x7ffaabb93220
        public void InsertRange(){} // RVA: 0x7ffaabbcff20
        public void LastIndexOf(){} // RVA: 0x7ffaabbd0370
        public void LastIndexOf(){} // RVA: 0x7ffaabbd0370
        public void LastIndexOf(){} // RVA: 0x7ffaabbd0370
        public void Remove(){} // RVA: 0x7ffaabbd0430
        public void System.Collections.IList.Remove(){} // RVA: 0x7ffaabbd0550
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
        public void AddEnumerable(){} // RVA: 0x7ffaabbd0980
        public void .cctor(){} // RVA: 0x7ffaabb94610
        // ── Binary Analysis Named ──
        public void GetEnumerator(){} // RVA: 0x7ffaabb92c40
        public void GetRange(){} // RVA: 0x7ffaabb92da0
    }

    public class List`1 : Object
    {
    }

}