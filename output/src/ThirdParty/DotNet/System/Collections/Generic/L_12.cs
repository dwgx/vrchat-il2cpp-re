// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 46
// Methods: 1999

namespace ThirdParty.DotNet.System.Collections.Generic
{
    public class LargeArrayBuilder`1 : ValueType
    {
        public object _maxCapacity;
        public object _first;
        public object _buffers;
        public object _current;
        public object _index;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3675F0
        public void AddRange(){} // RVA: 0x367600
        public void ToArray(){} // RVA: 0x367640
        public void AddWithBufferAllocation(){} // RVA: 0x367610
        public void CopyTo(){} // RVA: 0x367620
        public void GetBuffer(){} // RVA: 0x367630
        public void TryMove(){} // RVA: 0x367650
        public void AllocateBuffer(){} // RVA: 0x367660
    }

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
        public void Add(){} // RVA: 0xB677C0
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
        public void Add(){} // RVA: 0xB677C0
        public void ToArray(){} // RVA: 0x42EDF00
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
        public void .ctor(){} // RVA: 0x42EAED0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void get_Count(){} // RVA: 0xE62D00
        public void Add(){} // RVA: 0xB677C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void IndexOf(){} // RVA: 0x4488350
        public void Insert(){} // RVA: 0x4488570
        public void Remove(){} // RVA: 0x4488B90
        public void RemoveAt(){} // RVA: 0x444A870
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42EAED0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void get_Count(){} // RVA: 0xE62D00
        public void Add(){} // RVA: 0xB677C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void IndexOf(){} // RVA: 0x4488350
        public void Insert(){} // RVA: 0x4488570
        public void Remove(){} // RVA: 0x4488B90
        public void RemoveAt(){} // RVA: 0x444A870
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42EAED0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void get_Count(){} // RVA: 0xE62D00
        public void Add(){} // RVA: 0xB677C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void IndexOf(){} // RVA: 0x4488350
        public void Insert(){} // RVA: 0x4488570
        public void Remove(){} // RVA: 0x4488B90
        public void RemoveAt(){} // RVA: 0x444A870
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42EAED0
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void get_Count(){} // RVA: 0xE62D00
        public void Add(){} // RVA: 0xE3F630
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x443E090
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void IndexOf(){} // RVA: 0x443E270
        public void Insert(){} // RVA: 0x42ECE00
        public void Remove(){} // RVA: 0x443E9D0
        public void RemoveAt(){} // RVA: 0x42ED9E0
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x42EAED0
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void get_Count(){} // RVA: 0xE62D00
        public void Add(){} // RVA: 0xB677C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44880A0
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void IndexOf(){} // RVA: 0x4488350
        public void Insert(){} // RVA: 0x4488570
        public void Remove(){} // RVA: 0x4488B90
        public void RemoveAt(){} // RVA: 0x444A870
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x45473F0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4547650
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42F3690
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F3730
        public void Add(){} // RVA: 0x1735620
        public void AddWithResize(){} // RVA: 0x42F3890
        public void System.Collections.IList.Add(){} // RVA: 0x42F3950
        public void AddRange(){} // RVA: 0x4547700
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4547920
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4547960
        public void System.Collections.IList.Contains(){} // RVA: 0x45479D0
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
        public void IndexOf(){} // RVA: 0x4547D20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4547B80
        public void Insert(){} // RVA: 0x42F4290
        public void System.Collections.IList.Insert(){} // RVA: 0x42F43C0
        public void InsertRange(){} // RVA: 0x4547D90
        public void LastIndexOf(){} // RVA: 0x45481E0
        public void Remove(){} // RVA: 0x45482A0
        public void System.Collections.IList.Remove(){} // RVA: 0x4548310
        public void RemoveAll(){} // RVA: 0x42F4D10
        public void RemoveAt(){} // RVA: 0x42F4EE0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F5020
        public void Sort(){} // RVA: 0x42F52A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4548680
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
        public void .ctor(){} // RVA: 0x43BCD20
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x43BCF80
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42F3690
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F3730
        public void Add(){} // RVA: 0x1735620
        public void AddWithResize(){} // RVA: 0x42F3890
        public void System.Collections.IList.Add(){} // RVA: 0x42F3950
        public void AddRange(){} // RVA: 0x43BD030
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x43BD250
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x43BD290
        public void System.Collections.IList.Contains(){} // RVA: 0x43BD300
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
        public void IndexOf(){} // RVA: 0x43BD780
        public void System.Collections.IList.IndexOf(){} // RVA: 0x43BD5E0
        public void Insert(){} // RVA: 0x42F4290
        public void System.Collections.IList.Insert(){} // RVA: 0x42F43C0
        public void InsertRange(){} // RVA: 0x43BD7F0
        public void LastIndexOf(){} // RVA: 0x43BDC40
        public void Remove(){} // RVA: 0x43BDD00
        public void System.Collections.IList.Remove(){} // RVA: 0x43BDD70
        public void RemoveAll(){} // RVA: 0x42F4D10
        public void RemoveAt(){} // RVA: 0x42F4EE0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F5020
        public void Sort(){} // RVA: 0x42F52A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x43BE0E0
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
        public void .ctor(){} // RVA: 0x43E7E40
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x43E80A0
        public void get_Item(){} // RVA: 0x43E8150
        public void set_Item(){} // RVA: 0x43E8190
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43E8220
        public void System.Collections.IList.set_Item(){} // RVA: 0x43E82E0
        public void Add(){} // RVA: 0x43E8430
        public void AddWithResize(){} // RVA: 0x43E8520
        public void System.Collections.IList.Add(){} // RVA: 0x43E85D0
        public void AddRange(){} // RVA: 0x43E8720
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x43E89E0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x43E8A60
        public void System.Collections.IList.Contains(){} // RVA: 0x43E8B10
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43E8CD0
        public void Find(){} // RVA: 0x43E8E10
        public void FindAll(){} // RVA: 0x43E8FB0
        public void FindIndex(){} // RVA: 0x43E92C0
        public void FindLastIndex(){} // RVA: 0x43E9560
        public void ForEach(){} // RVA: 0x43E96D0
        public void GetEnumerator(){} // RVA: 0x43E9800
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43E9840
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43E9840
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x43E9C10
        public void System.Collections.IList.IndexOf(){} // RVA: 0x43E99E0
        public void Insert(){} // RVA: 0x43E9CC0
        public void System.Collections.IList.Insert(){} // RVA: 0x43E9DD0
        public void InsertRange(){} // RVA: 0x43E9F10
        public void LastIndexOf(){} // RVA: 0x43EA3B0
        public void Remove(){} // RVA: 0x43EA4D0
        public void System.Collections.IList.Remove(){} // RVA: 0x43EA5B0
        public void RemoveAll(){} // RVA: 0x43EA7A0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x43EAC40
        public void Sort(){} // RVA: 0x43EB0A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43EB160
        public void AddEnumerable(){} // RVA: 0x43EB260
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
        public void Add(){} // RVA: 0xD5D7C0
        public void .ctor(){} // RVA: 0x4365AF0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4365D50
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x4365E00
        public void AddRange(){} // RVA: 0x4365F00
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4366140
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4366190
        public void System.Collections.IList.Contains(){} // RVA: 0x4366200
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
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x43666E0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4366520
        public void Insert(){} // RVA: 0x42F2030
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x4366760
        public void LastIndexOf(){} // RVA: 0x4366B70
        public void Remove(){} // RVA: 0x4366C40
        public void System.Collections.IList.Remove(){} // RVA: 0x4366D80
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x43671D0
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
        public void .ctor(){} // RVA: 0x430E6A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x430E900
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x42EB910
        public void AddRange(){} // RVA: 0x430E9B0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x430EBD0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x430EC10
        public void System.Collections.IList.Contains(){} // RVA: 0x430EC80
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x42EC1F0
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x430EFD0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x430EE30
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x430F040
        public void LastIndexOf(){} // RVA: 0x430F490
        public void Remove(){} // RVA: 0x430F550
        public void System.Collections.IList.Remove(){} // RVA: 0x430F670
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x430FAA0
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
        public void AddRange(){} // RVA: 0x4487F30
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
        public void .ctor(){} // RVA: 0x4501BF0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4501E50
        public void get_Item(){} // RVA: 0x43C54D0
        public void set_Item(){} // RVA: 0x43C5510
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43C5550
        public void System.Collections.IList.set_Item(){} // RVA: 0x43C55B0
        public void Add(){} // RVA: 0x43C56B0
        public void AddWithResize(){} // RVA: 0x43C5710
        public void System.Collections.IList.Add(){} // RVA: 0x43C5780
        public void AddRange(){} // RVA: 0x4501F00
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4502110
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4502150
        public void System.Collections.IList.Contains(){} // RVA: 0x45021B0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43C5CC0
        public void Find(){} // RVA: 0x43C5D80
        public void FindAll(){} // RVA: 0x4502310
        public void FindIndex(){} // RVA: 0x43C6020
        public void FindLastIndex(){} // RVA: 0x43C61E0
        public void ForEach(){} // RVA: 0x43C62D0
        public void GetEnumerator(){} // RVA: 0x43C6380
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43C6410
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43C6410
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x45025F0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4502460
        public void Insert(){} // RVA: 0x43C66F0
        public void System.Collections.IList.Insert(){} // RVA: 0x43C67C0
        public void InsertRange(){} // RVA: 0x4502650
        public void LastIndexOf(){} // RVA: 0x4502A10
        public void Remove(){} // RVA: 0x4502AC0
        public void System.Collections.IList.Remove(){} // RVA: 0x4502B60
        public void RemoveAll(){} // RVA: 0x43C6F60
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x4427220
        public void Sort(){} // RVA: 0x43C73D0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43C7490
        public void AddEnumerable(){} // RVA: 0x4502F10
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
        public void Add(){} // RVA: 0x1735620
        public void .ctor(){} // RVA: 0x451E220
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x451E480
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42F3690
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F3730
        public void AddWithResize(){} // RVA: 0x42F3890
        public void System.Collections.IList.Add(){} // RVA: 0x42F3950
        public void AddRange(){} // RVA: 0x451E530
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x451E750
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x451E790
        public void System.Collections.IList.Contains(){} // RVA: 0x451E800
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
        public void IndexOf(){} // RVA: 0x451EB50
        public void System.Collections.IList.IndexOf(){} // RVA: 0x451E9B0
        public void Insert(){} // RVA: 0x42F4290
        public void System.Collections.IList.Insert(){} // RVA: 0x42F43C0
        public void InsertRange(){} // RVA: 0x451EBC0
        public void LastIndexOf(){} // RVA: 0x451F010
        public void Remove(){} // RVA: 0x451F0D0
        public void System.Collections.IList.Remove(){} // RVA: 0x451F1F0
        public void RemoveAll(){} // RVA: 0x42F4D10
        public void RemoveAt(){} // RVA: 0x42F4EE0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F5020
        public void Sort(){} // RVA: 0x42F52A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x451F620
        public void .cctor(){} // RVA: 0x42EE360
    }

    public class List`1 : Object
    {
        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x42FDED0
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void Add(){} // RVA: 0xB677C0
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
        public void Add(){} // RVA: 0x43C56B0
        public void .ctor(){} // RVA: 0x45007A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4500A00
        public void get_Item(){} // RVA: 0x43C54D0
        public void set_Item(){} // RVA: 0x43C5510
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43C5550
        public void System.Collections.IList.set_Item(){} // RVA: 0x43C55B0
        public void AddWithResize(){} // RVA: 0x43C5710
        public void System.Collections.IList.Add(){} // RVA: 0x43C5780
        public void AddRange(){} // RVA: 0x4500AB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4500CC0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4500D00
        public void System.Collections.IList.Contains(){} // RVA: 0x4500D60
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43C5CC0
        public void Find(){} // RVA: 0x43C5D80
        public void FindAll(){} // RVA: 0x43C5E40
        public void FindIndex(){} // RVA: 0x43C6020
        public void FindLastIndex(){} // RVA: 0x43C61E0
        public void ForEach(){} // RVA: 0x43C62D0
        public void GetEnumerator(){} // RVA: 0x43C6380
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43C6410
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43C6410
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x4501080
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4500EF0
        public void Insert(){} // RVA: 0x43C66F0
        public void System.Collections.IList.Insert(){} // RVA: 0x43C67C0
        public void InsertRange(){} // RVA: 0x45010E0
        public void LastIndexOf(){} // RVA: 0x45014A0
        public void Remove(){} // RVA: 0x4501550
        public void System.Collections.IList.Remove(){} // RVA: 0x45015F0
        public void RemoveAll(){} // RVA: 0x43C6F60
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x4427220
        public void Sort(){} // RVA: 0x43C73D0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43C7490
        public void AddEnumerable(){} // RVA: 0x45019A0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void get_Count(){} // RVA: 0xE62D00
    }

    public class List`1 : Object
    {
        public object _items;
        public object _size;
        public object _version;
        public object _syncRoot;
        public object s_emptyArray;

        // ── Methods ──
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void .ctor(){} // RVA: 0x42EAF90
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

    public class List`1[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class LongEnumEqualityComparer`1 : EqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x87D350
        public void GetHashCode(){} // RVA: 0x87C130
        public void .ctor(){} // RVA: 0x8943B0
        public void GetObjectData(){} // RVA: 0x8943B0
    }

}