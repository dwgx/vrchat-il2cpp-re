// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5181

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class LinkedListNode`1 : Object
    {
        public object list;
        public object next;
        public object prev;
        public object item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44DC0
        public void get_Next(){} // RVA: 0x427EED0
        public void Invalidate(){} // RVA: 0x427EF10
        public void get_List(){} // RVA: 0xB5DBF0
        public void get_Value(){} // RVA: 0xB70160
        public void set_Value(){} // RVA: 0xB44DC0
    }

    public class LinkedList`1 : Object
    {
        public object head;
        public object count;
        public object version;
        public object _syncRoot;
        public object _siInfo;
        public object VersionName;
        public object CountName;
        public object ValuesName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44DC0
        public void get_Count(){} // RVA: 0xE62D00
        public void get_First(){} // RVA: 0xB5DBF0
        public void get_Last(){} // RVA: 0x427F8A0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.Add(){} // RVA: 0x4283780
        public void AddFirst(){} // RVA: 0x427FA50
        public void AddLast(){} // RVA: 0x427FC80
        public void Clear(){} // RVA: 0x427FDB0
        public void Contains(){} // RVA: 0x4283920
        public void CopyTo(){} // RVA: 0x42839E0
        public void Find(){} // RVA: 0x4283BD0
        public void GetEnumerator(){} // RVA: 0x4283C90
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x4283CC0
        public void Remove(){} // RVA: 0x42804E0
        public void RemoveFirst(){} // RVA: 0x42805A0
        public void RemoveLast(){} // RVA: 0x4280620
        public void GetObjectData(){} // RVA: 0x4283EF0
        public void OnDeserialization(){} // RVA: 0x4284150
        public void InternalInsertNodeBefore(){} // RVA: 0x4280DA0
        public void InternalInsertNodeToEmptyList(){} // RVA: 0x4280F40
        public void InternalRemoveNode(){} // RVA: 0x4281060
        public void ValidateNewNode(){} // RVA: 0x4281230
        public void ValidateNode(){} // RVA: 0x42812D0
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4284600
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42846B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4283CC0
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void Add(){} // RVA: 0xB677C0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4529BE0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4529E40
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42F3690
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F3730
        public void Add(){} // RVA: 0x1735620
        public void AddWithResize(){} // RVA: 0x42F3890
        public void System.Collections.IList.Add(){} // RVA: 0x42F3950
        public void AddRange(){} // RVA: 0x4529EF0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x452A110
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x452A150
        public void System.Collections.IList.Contains(){} // RVA: 0x452A1C0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x43BD470
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x452A510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x452A370
        public void Insert(){} // RVA: 0x42F4290
        public void System.Collections.IList.Insert(){} // RVA: 0x42F43C0
        public void InsertRange(){} // RVA: 0x452A580
        public void LastIndexOf(){} // RVA: 0x452A9D0
        public void Remove(){} // RVA: 0x452AA90
        public void System.Collections.IList.Remove(){} // RVA: 0x452ABB0
        public void RemoveAll(){} // RVA: 0x42F4D10
        public void RemoveAt(){} // RVA: 0x42F4EE0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F5020
        public void Sort(){} // RVA: 0x42F52A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x452AFE0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void .ctor(){} // RVA: 0x4487990
        public void Add(){} // RVA: 0xB677C0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void GetRange(){} // RVA: 0x4311E60
        public void AddRange(){} // RVA: 0x4487F30
        public void RemoveAt(){} // RVA: 0x444A870
        public void Insert(){} // RVA: 0x4488570
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void CopyTo(){} // RVA: 0x42EBF70
        public void Remove(){} // RVA: 0x4488B90
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void IndexOf(){} // RVA: 0x4488510
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void .ctor(){} // RVA: 0x4487990
        public void Add(){} // RVA: 0xB677C0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void GetRange(){} // RVA: 0x4311E60
        public void AddRange(){} // RVA: 0x4487F30
        public void RemoveAt(){} // RVA: 0x444A870
        public void Insert(){} // RVA: 0x4488570
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void CopyTo(){} // RVA: 0x42EBF70
        public void Remove(){} // RVA: 0x4488B90
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void IndexOf(){} // RVA: 0x4488510
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42EAF90
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x431BF20
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4375720
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4375980
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x42FD0F0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD130
        public void System.Collections.IList.set_Item(){} // RVA: 0x42FD190
        public void Add(){} // RVA: 0x42FD290
        public void AddWithResize(){} // RVA: 0x42FD2F0
        public void System.Collections.IList.Add(){} // RVA: 0x42FD360
        public void AddRange(){} // RVA: 0x4375A30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4375C40
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4375C80
        public void System.Collections.IList.Contains(){} // RVA: 0x4375CE0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x435EC50
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x42FD990
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4376000
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4375E70
        public void Insert(){} // RVA: 0x42FE240
        public void System.Collections.IList.Insert(){} // RVA: 0x42FE300
        public void InsertRange(){} // RVA: 0x4376060
        public void LastIndexOf(){} // RVA: 0x4376410
        public void Remove(){} // RVA: 0x43764C0
        public void System.Collections.IList.Remove(){} // RVA: 0x4376560
        public void RemoveAll(){} // RVA: 0x42FEA90
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x42FEE10
        public void Sort(){} // RVA: 0x42FF170
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4376910
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4639790
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x46399F0
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void Add(){} // RVA: 0xD5D7C0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x42F1630
        public void AddRange(){} // RVA: 0x4639AA0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4639CE0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4639D30
        public void System.Collections.IList.Contains(){} // RVA: 0x4639DA0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EF050
        public void Find(){} // RVA: 0x42EF130
        public void FindAll(){} // RVA: 0x43AAA20
        public void FindIndex(){} // RVA: 0x42EF460
        public void FindLastIndex(){} // RVA: 0x42EF660
        public void ForEach(){} // RVA: 0x42EF770
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x463A130
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4639F70
        public void Insert(){} // RVA: 0x42F2030
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x463A1B0
        public void LastIndexOf(){} // RVA: 0x463A5B0
        public void Remove(){} // RVA: 0x463A680
        public void System.Collections.IList.Remove(){} // RVA: 0x463A7C0
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x463AC10
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4385510
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4385770
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x430D110
        public void AddRange(){} // RVA: 0x4385820
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4385A40
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4385A80
        public void System.Collections.IList.Contains(){} // RVA: 0x4385AF0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x430D640
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x4385E40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4385CA0
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4385EB0
        public void LastIndexOf(){} // RVA: 0x4386290
        public void Remove(){} // RVA: 0x4386350
        public void System.Collections.IList.Remove(){} // RVA: 0x4386470
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x43868A0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4505940
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4505BA0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x42FD0F0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD130
        public void System.Collections.IList.set_Item(){} // RVA: 0x442A920
        public void Add(){} // RVA: 0x442AA20
        public void AddWithResize(){} // RVA: 0x442AA80
        public void System.Collections.IList.Add(){} // RVA: 0x442AAF0
        public void AddRange(){} // RVA: 0x4505C50
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4505D50
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4505DC0
        public void System.Collections.IList.Contains(){} // RVA: 0x4505E20
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x435EC50
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x442B030
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x4506140
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4505FB0
        public void Insert(){} // RVA: 0x442B370
        public void System.Collections.IList.Insert(){} // RVA: 0x442B430
        public void InsertRange(){} // RVA: 0x45061A0
        public void LastIndexOf(){} // RVA: 0x4506560
        public void Remove(){} // RVA: 0x4506610
        public void System.Collections.IList.Remove(){} // RVA: 0x45066B0
        public void RemoveAll(){} // RVA: 0x42FEA90
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x42FEE10
        public void Sort(){} // RVA: 0x442BDE0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4506970
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4386B20
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4386D80
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void Add(){} // RVA: 0xD5D7C0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x4365E00
        public void AddRange(){} // RVA: 0x4386E30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4387070
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x43870C0
        public void System.Collections.IList.Contains(){} // RVA: 0x4387130
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EF050
        public void Find(){} // RVA: 0x42EF130
        public void FindAll(){} // RVA: 0x4366380
        public void FindIndex(){} // RVA: 0x42EF460
        public void FindLastIndex(){} // RVA: 0x42EF660
        public void ForEach(){} // RVA: 0x42EF770
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x43874C0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4387300
        public void Insert(){} // RVA: 0x42F2030
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x4387540
        public void LastIndexOf(){} // RVA: 0x4387940
        public void Remove(){} // RVA: 0x4387A10
        public void System.Collections.IList.Remove(){} // RVA: 0x4387B50
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x4387FA0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x463C490
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x463C6F0
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x435BE90
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4360100
        public void Add(){} // RVA: 0x435C0F0
        public void AddWithResize(){} // RVA: 0x435C180
        public void System.Collections.IList.Add(){} // RVA: 0x4360210
        public void AddRange(){} // RVA: 0x463C7A0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x463C9E0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x463CA30
        public void System.Collections.IList.Contains(){} // RVA: 0x463CAA0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EF050
        public void Find(){} // RVA: 0x42EF130
        public void FindAll(){} // RVA: 0x43BA850
        public void FindIndex(){} // RVA: 0x42EF460
        public void FindLastIndex(){} // RVA: 0x42EF660
        public void ForEach(){} // RVA: 0x42EF770
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x463CE30
        public void System.Collections.IList.IndexOf(){} // RVA: 0x463CC70
        public void Insert(){} // RVA: 0x435CDB0
        public void System.Collections.IList.Insert(){} // RVA: 0x4360A70
        public void InsertRange(){} // RVA: 0x463CEB0
        public void LastIndexOf(){} // RVA: 0x463D2B0
        public void Remove(){} // RVA: 0x463D380
        public void System.Collections.IList.Remove(){} // RVA: 0x463D430
        public void RemoveAll(){} // RVA: 0x435D7C0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x435DAB0
        public void Sort(){} // RVA: 0x435DE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x463D7F0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x463AEA0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x463B100
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x435BE90
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4360100
        public void Add(){} // RVA: 0x435C0F0
        public void AddWithResize(){} // RVA: 0x435C180
        public void System.Collections.IList.Add(){} // RVA: 0x4360210
        public void AddRange(){} // RVA: 0x463B1B0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x463B3F0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x463B440
        public void System.Collections.IList.Contains(){} // RVA: 0x463B4B0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EF050
        public void Find(){} // RVA: 0x42EF130
        public void FindAll(){} // RVA: 0x43BA850
        public void FindIndex(){} // RVA: 0x42EF460
        public void FindLastIndex(){} // RVA: 0x42EF660
        public void ForEach(){} // RVA: 0x42EF770
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x463B840
        public void System.Collections.IList.IndexOf(){} // RVA: 0x463B680
        public void Insert(){} // RVA: 0x435CDB0
        public void System.Collections.IList.Insert(){} // RVA: 0x4360A70
        public void InsertRange(){} // RVA: 0x463B8C0
        public void LastIndexOf(){} // RVA: 0x463BCC0
        public void Remove(){} // RVA: 0x463BD90
        public void System.Collections.IList.Remove(){} // RVA: 0x463BE40
        public void RemoveAll(){} // RVA: 0x435D7C0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x435DAB0
        public void Sort(){} // RVA: 0x435DE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x463C200
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4651120
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4651380
        public void get_Item(){} // RVA: 0x43A14D0
        public void set_Item(){} // RVA: 0x43A1530
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43A1590
        public void System.Collections.IList.set_Item(){} // RVA: 0x43A1610
        public void Add(){} // RVA: 0x43A1730
        public void AddWithResize(){} // RVA: 0x43A17D0
        public void System.Collections.IList.Add(){} // RVA: 0x43A1860
        public void AddRange(){} // RVA: 0x4651430
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4651690
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x46516E0
        public void System.Collections.IList.Contains(){} // RVA: 0x4651760
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43A1E80
        public void Find(){} // RVA: 0x43A1F70
        public void FindAll(){} // RVA: 0x43A2090
        public void FindIndex(){} // RVA: 0x43A22E0
        public void FindLastIndex(){} // RVA: 0x43A24E0
        public void ForEach(){} // RVA: 0x43A25F0
        public void GetEnumerator(){} // RVA: 0x43A26C0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43A2770
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43A2770
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4651B00
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4651940
        public void Insert(){} // RVA: 0x43A2AE0
        public void System.Collections.IList.Insert(){} // RVA: 0x43A2BC0
        public void InsertRange(){} // RVA: 0x4651B80
        public void LastIndexOf(){} // RVA: 0x4651FA0
        public void Remove(){} // RVA: 0x4652070
        public void System.Collections.IList.Remove(){} // RVA: 0x4652130
        public void RemoveAll(){} // RVA: 0x43A3430
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x43A3750
        public void Sort(){} // RVA: 0x43A3AF0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43A3BB0
        public void AddEnumerable(){} // RVA: 0x46524F0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4640500
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4640760
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x42EB910
        public void AddRange(){} // RVA: 0x4640810
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4640A30
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4640A70
        public void System.Collections.IList.Contains(){} // RVA: 0x4640AE0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x4364B00
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4640E30
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4640C90
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4640EA0
        public void LastIndexOf(){} // RVA: 0x46412F0
        public void Remove(){} // RVA: 0x46413B0
        public void System.Collections.IList.Remove(){} // RVA: 0x46414D0
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4641900
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4401350
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44015B0
        public void get_Item(){} // RVA: 0x4401660
        public void set_Item(){} // RVA: 0x44016A0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x44016E0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4401740
        public void Add(){} // RVA: 0x4401840
        public void AddWithResize(){} // RVA: 0x44018A0
        public void System.Collections.IList.Add(){} // RVA: 0x4401910
        public void AddRange(){} // RVA: 0x4401A40
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4401C50
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4401C90
        public void System.Collections.IList.Contains(){} // RVA: 0x4401CF0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x4401E50
        public void Find(){} // RVA: 0x4401F10
        public void FindAll(){} // RVA: 0x4401FC0
        public void FindIndex(){} // RVA: 0x44021A0
        public void FindLastIndex(){} // RVA: 0x4402360
        public void ForEach(){} // RVA: 0x4402450
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x44026C0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4402530
        public void Insert(){} // RVA: 0x4402720
        public void System.Collections.IList.Insert(){} // RVA: 0x44027F0
        public void InsertRange(){} // RVA: 0x44028E0
        public void LastIndexOf(){} // RVA: 0x4402CA0
        public void Remove(){} // RVA: 0x4402D50
        public void System.Collections.IList.Remove(){} // RVA: 0x4402DF0
        public void RemoveAll(){} // RVA: 0x4402F90
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x4403240
        public void Sort(){} // RVA: 0x44035A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x4403660
        public void AddEnumerable(){} // RVA: 0x4403700
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42FCDA0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x42FD000
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x42FD0F0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD130
        public void System.Collections.IList.set_Item(){} // RVA: 0x42FD190
        public void Add(){} // RVA: 0x42FD290
        public void AddWithResize(){} // RVA: 0x42FD2F0
        public void System.Collections.IList.Add(){} // RVA: 0x42FD360
        public void AddRange(){} // RVA: 0x42FD490
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x42FD6A0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x42FD6F0
        public void System.Collections.IList.Contains(){} // RVA: 0x42FD750
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x42FD990
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x42FE1E0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x42FE050
        public void Insert(){} // RVA: 0x42FE240
        public void System.Collections.IList.Insert(){} // RVA: 0x42FE300
        public void InsertRange(){} // RVA: 0x42FE3F0
        public void LastIndexOf(){} // RVA: 0x42FE7A0
        public void Remove(){} // RVA: 0x42FE850
        public void System.Collections.IList.Remove(){} // RVA: 0x42FE8F0
        public void RemoveAll(){} // RVA: 0x42FEA90
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x42FEE10
        public void Sort(){} // RVA: 0x42FF170
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x42FF2D0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4385510
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4385770
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x430D110
        public void AddRange(){} // RVA: 0x4385820
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4385A40
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4385A80
        public void System.Collections.IList.Contains(){} // RVA: 0x4385AF0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x430D640
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x4385E40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4385CA0
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4385EB0
        public void LastIndexOf(){} // RVA: 0x4386290
        public void Remove(){} // RVA: 0x4386350
        public void System.Collections.IList.Remove(){} // RVA: 0x4386470
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x43868A0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4631130
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4631390
        public void get_Item(){} // RVA: 0x43F2140
        public void set_Item(){} // RVA: 0x4418870
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43F2210
        public void System.Collections.IList.set_Item(){} // RVA: 0x4418930
        public void Add(){} // RVA: 0x4418AB0
        public void AddWithResize(){} // RVA: 0x4418BC0
        public void System.Collections.IList.Add(){} // RVA: 0x4418CA0
        public void AddRange(){} // RVA: 0x4631440
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x46316C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4631720
        public void System.Collections.IList.Contains(){} // RVA: 0x46317A0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x4631940
        public void Find(){} // RVA: 0x43F2C10
        public void FindAll(){} // RVA: 0x44192C0
        public void FindIndex(){} // RVA: 0x43F2FC0
        public void FindLastIndex(){} // RVA: 0x43F3210
        public void ForEach(){} // RVA: 0x43F3350
        public void GetEnumerator(){} // RVA: 0x43F3430
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43F34F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43F34F0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4631BA0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x46319C0
        public void Insert(){} // RVA: 0x4419720
        public void System.Collections.IList.Insert(){} // RVA: 0x4419870
        public void InsertRange(){} // RVA: 0x4631C30
        public void LastIndexOf(){} // RVA: 0x4632070
        public void Remove(){} // RVA: 0x4632160
        public void System.Collections.IList.Remove(){} // RVA: 0x46321F0
        public void RemoveAll(){} // RVA: 0x441A280
        public void RemoveAt(){} // RVA: 0x441A480
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x441A5D0
        public void Sort(){} // RVA: 0x441A850
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43F4A80
        public void AddEnumerable(){} // RVA: 0x4632590
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x44FED10
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44FEF70
        public void get_Item(){} // RVA: 0x44CDBB0
        public void set_Item(){} // RVA: 0x44CDBF0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x44CDCA0
        public void System.Collections.IList.set_Item(){} // RVA: 0x44CDD70
        public void Add(){} // RVA: 0x44CDEC0
        public void AddWithResize(){} // RVA: 0x44CDFD0
        public void System.Collections.IList.Add(){} // RVA: 0x44CE090
        public void AddRange(){} // RVA: 0x44FF020
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x44FF300
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x44FF390
        public void System.Collections.IList.Contains(){} // RVA: 0x44FF450
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x44CE7D0
        public void Find(){} // RVA: 0x44CE910
        public void FindAll(){} // RVA: 0x44CEAD0
        public void FindIndex(){} // RVA: 0x44CEE10
        public void FindLastIndex(){} // RVA: 0x44CF0D0
        public void ForEach(){} // RVA: 0x44CF250
        public void GetEnumerator(){} // RVA: 0x44CF390
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x44CF3D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x44CF3D0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x44FF8D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44FF6A0
        public void Insert(){} // RVA: 0x44CF870
        public void System.Collections.IList.Insert(){} // RVA: 0x44CF980
        public void InsertRange(){} // RVA: 0x44FF990
        public void LastIndexOf(){} // RVA: 0x44FFE60
        public void Remove(){} // RVA: 0x44FFF80
        public void System.Collections.IList.Remove(){} // RVA: 0x4500070
        public void RemoveAll(){} // RVA: 0x44D03B0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x44D0880
        public void Sort(){} // RVA: 0x44D0D00
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x44D0DC0
        public void AddEnumerable(){} // RVA: 0x4500480
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x44E5C10
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44E5E70
        public void get_Item(){} // RVA: 0x431BF20
        public void set_Item(){} // RVA: 0x431BF80
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x431BFE0
        public void System.Collections.IList.set_Item(){} // RVA: 0x431C050
        public void Add(){} // RVA: 0x431C160
        public void AddWithResize(){} // RVA: 0x431C1E0
        public void System.Collections.IList.Add(){} // RVA: 0x431C260
        public void AddRange(){} // RVA: 0x44E5F20
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x44E6160
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x44E61B0
        public void System.Collections.IList.Contains(){} // RVA: 0x44E6220
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x431C830
        public void Find(){} // RVA: 0x431C910
        public void FindAll(){} // RVA: 0x431CA10
        public void FindIndex(){} // RVA: 0x431CCD0
        public void FindLastIndex(){} // RVA: 0x431CED0
        public void ForEach(){} // RVA: 0x431CFE0
        public void GetEnumerator(){} // RVA: 0x431D0A0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x431D130
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x431D130
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x44E65B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44E63F0
        public void Insert(){} // RVA: 0x431D480
        public void System.Collections.IList.Insert(){} // RVA: 0x431D550
        public void InsertRange(){} // RVA: 0x44E6620
        public void LastIndexOf(){} // RVA: 0x44E6A80
        public void Remove(){} // RVA: 0x44E6B50
        public void System.Collections.IList.Remove(){} // RVA: 0x44E6C00
        public void RemoveAll(){} // RVA: 0x431DDE0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x431E0D0
        public void Sort(){} // RVA: 0x431E450
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x431E510
        public void AddEnumerable(){} // RVA: 0x44E6FC0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x44FD790
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44FD9F0
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x4304430
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x4304480
        public void Add(){} // RVA: 0x4304590
        public void AddWithResize(){} // RVA: 0x4304600
        public void System.Collections.IList.Add(){} // RVA: 0x4304670
        public void AddRange(){} // RVA: 0x44FDAA0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x44FDCC0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x44FDD00
        public void System.Collections.IList.Contains(){} // RVA: 0x44FDD70
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x4304BF0
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x44FE0C0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44FDF20
        public void Insert(){} // RVA: 0x4305070
        public void System.Collections.IList.Insert(){} // RVA: 0x4305140
        public void InsertRange(){} // RVA: 0x44FE130
        public void LastIndexOf(){} // RVA: 0x44FE580
        public void Remove(){} // RVA: 0x44FE640
        public void System.Collections.IList.Remove(){} // RVA: 0x44FE6F0
        public void RemoveAll(){} // RVA: 0x43059A0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x4305C70
        public void Sort(){} // RVA: 0x4305FD0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x44FEAA0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4523E50
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45240B0
        public void get_Item(){} // RVA: 0xAD0950
        public void set_Item(){} // RVA: 0x4524230
        public void IsCompatibleObject(){} // RVA: 0x45243A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x4524510
        public void System.Collections.IList.set_Item(){} // RVA: 0x45245E0
        public void Add(){} // RVA: 0x4524840
        public void AddWithResize(){} // RVA: 0x4524A20
        public void System.Collections.IList.Add(){} // RVA: 0x4524BA0
        public void AddRange(){} // RVA: 0x4524DF0
        public void AsReadOnly(){} // RVA: 0x4524E10
        public void BinarySearch(){} // RVA: 0x4525130
        public void Clear(){} // RVA: 0x4525270
        public void Contains(){} // RVA: 0x45252D0
        public void System.Collections.IList.Contains(){} // RVA: 0x45253C0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4525600
        public void Exists(){} // RVA: 0x4525670
        public void Find(){} // RVA: 0xAD0950
        public void FindAll(){} // RVA: 0x4525870
        public void FindIndex(){} // RVA: 0x4525AC0
        public void FindLastIndex(){} // RVA: 0x4525C90
        public void ForEach(){} // RVA: 0x4525E30
        public void GetEnumerator(){} // RVA: 0xAD0950
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x4526040
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4526040
        public void GetRange(){} // RVA: 0x45260F0
        public void IndexOf(){} // RVA: 0x4526660
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4526310
        public void Insert(){} // RVA: 0x45267A0
        public void System.Collections.IList.Insert(){} // RVA: 0x4526980
        public void InsertRange(){} // RVA: 0x4526BE0
        public void LastIndexOf(){} // RVA: 0x4527200
        public void Remove(){} // RVA: 0x45273C0
        public void System.Collections.IList.Remove(){} // RVA: 0x45274D0
        public void RemoveAll(){} // RVA: 0x45276D0
        public void RemoveAt(){} // RVA: 0x4527A30
        public void RemoveRange(){} // RVA: 0x4527C20
        public void Reverse(){} // RVA: 0x4527D50
        public void Sort(){} // RVA: 0x4527F10
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4527FD0
        public void TrueForAll(){} // RVA: 0x4528030
        public void AddEnumerable(){} // RVA: 0x4528170
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42EAF90
        public void Add(){} // RVA: 0xB677C0
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4421CE0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4421F40
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x4304430
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x4304480
        public void Add(){} // RVA: 0x4304590
        public void AddWithResize(){} // RVA: 0x4304600
        public void System.Collections.IList.Add(){} // RVA: 0x4304670
        public void AddRange(){} // RVA: 0x4421FF0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4422210
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4422250
        public void System.Collections.IList.Contains(){} // RVA: 0x44222C0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x43580C0
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4422610
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4422470
        public void Insert(){} // RVA: 0x4305070
        public void System.Collections.IList.Insert(){} // RVA: 0x4305140
        public void InsertRange(){} // RVA: 0x4422680
        public void LastIndexOf(){} // RVA: 0x4422AD0
        public void Remove(){} // RVA: 0x4422B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4422C40
        public void RemoveAll(){} // RVA: 0x43059A0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x4305C70
        public void Sort(){} // RVA: 0x4305FD0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4422FF0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void Add(){} // RVA: 0x1B69DD0
        public void ToArray(){} // RVA: 0x42EDF00
        public void .ctor(){} // RVA: 0x42EAF90
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44293B0
        public void get_Item(){} // RVA: 0x43E2550
        public void set_Item(){} // RVA: 0x43E2590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43E25D0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4427AE0
        public void AddWithResize(){} // RVA: 0x4427BE0
        public void System.Collections.IList.Add(){} // RVA: 0x4427C50
        public void AddRange(){} // RVA: 0x4429460
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4429670
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x44296B0
        public void System.Collections.IList.Contains(){} // RVA: 0x4429710
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43E2D40
        public void Find(){} // RVA: 0x43E2E00
        public void FindAll(){} // RVA: 0x4429870
        public void FindIndex(){} // RVA: 0x43E3090
        public void FindLastIndex(){} // RVA: 0x43E3250
        public void ForEach(){} // RVA: 0x43E3340
        public void GetEnumerator(){} // RVA: 0x43E33F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43E3480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43E3480
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4429B40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44299C0
        public void Insert(){} // RVA: 0x4428480
        public void System.Collections.IList.Insert(){} // RVA: 0x4428540
        public void InsertRange(){} // RVA: 0x4429BA0
        public void LastIndexOf(){} // RVA: 0x4429F60
        public void Remove(){} // RVA: 0x442A010
        public void System.Collections.IList.Remove(){} // RVA: 0x442A0B0
        public void RemoveAll(){} // RVA: 0x43E3F90
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x43E4230
        public void Sort(){} // RVA: 0x4428E50
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43E4650
        public void AddEnumerable(){} // RVA: 0x442A3D0
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void Add(){} // RVA: 0xB677C0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void System.Collections.IList.Contains(){} // RVA: 0x4488100
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x42FD8B0
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4488230
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4488510
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4488380
        public void Insert(){} // RVA: 0x4488570
        public void System.Collections.IList.Insert(){} // RVA: 0x4488630
        public void InsertRange(){} // RVA: 0x4488720
        public void LastIndexOf(){} // RVA: 0x4488AE0
        public void Remove(){} // RVA: 0x4488B90
        public void System.Collections.IList.Remove(){} // RVA: 0x4488C20
        public void RemoveAll(){} // RVA: 0x4488D40
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4488F30
        public void Sort(){} // RVA: 0x44890C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x4489180
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4671FC0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x4672030
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4672030
    }

    public class LowLevelListWithIList`1 : LowLevelList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4671FC0
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x4672030
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4672030
    }

    public class LowLevelList`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4672290
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x4672440
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x4672580
        public void set_Item(){} // RVA: 0x46725F0
        public void Add(){} // RVA: 0x4672660
        public void EnsureCapacity(){} // RVA: 0x46726D0
        public void AddRange(){} // RVA: 0x4672840
        public void Clear(){} // RVA: 0x4672860
        public void Contains(){} // RVA: 0x46728A0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void IndexOf(){} // RVA: 0x4672950
        public void Insert(){} // RVA: 0x4672980
        public void InsertRange(){} // RVA: 0x4672A80
        public void Remove(){} // RVA: 0x4672E20
        public void RemoveAll(){} // RVA: 0x4672F30
        public void RemoveAt(){} // RVA: 0x46730E0
        public void .cctor(){} // RVA: 0x42EE360
    }

}