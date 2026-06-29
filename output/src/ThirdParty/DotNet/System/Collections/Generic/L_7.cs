// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 5394

namespace ThirdParty.DotNet.System.Collections.Generic
{
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
        public void .ctor(){} // RVA: 0x45D3E30
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45D4090
        public void get_Item(){} // RVA: 0x43010E0
        public void set_Item(){} // RVA: 0x45D4140
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43011E0
        public void System.Collections.IList.set_Item(){} // RVA: 0x45D41B0
        public void Add(){} // RVA: 0x45D42F0
        public void AddWithResize(){} // RVA: 0x45D4380
        public void System.Collections.IList.Add(){} // RVA: 0x45D4420
        public void AddRange(){} // RVA: 0x45D4590
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x45D4820
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x45D4890
        public void System.Collections.IList.Contains(){} // RVA: 0x45D4930
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x4301B70
        public void Find(){} // RVA: 0x4301C70
        public void FindAll(){} // RVA: 0x45D4AD0
        public void FindIndex(){} // RVA: 0x4302120
        public void FindLastIndex(){} // RVA: 0x4302380
        public void ForEach(){} // RVA: 0x43024D0
        public void GetEnumerator(){} // RVA: 0x43025D0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x4302690
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x4302690
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x45D4EE0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45D4CE0
        public void Insert(){} // RVA: 0x45D4F80
        public void System.Collections.IList.Insert(){} // RVA: 0x45D5080
        public void InsertRange(){} // RVA: 0x45D51B0
        public void LastIndexOf(){} // RVA: 0x45D5620
        public void Remove(){} // RVA: 0x45D5720
        public void System.Collections.IList.Remove(){} // RVA: 0x45D5850
        public void RemoveAll(){} // RVA: 0x45D5A70
        public void RemoveAt(){} // RVA: 0x45D5C90
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x45D5DA0
        public void Sort(){} // RVA: 0x45D6020
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x4303D70
        public void AddEnumerable(){} // RVA: 0x45D60E0
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
        public void .ctor(){} // RVA: 0x43113A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4311600
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0x29DFBA0
        public void AddWithResize(){} // RVA: 0x43116B0
        public void System.Collections.IList.Add(){} // RVA: 0x4311770
        public void AddRange(){} // RVA: 0x4311860
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4311A80
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4311AC0
        public void System.Collections.IList.Contains(){} // RVA: 0x4311B30
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x4311CA0
        public void Exists(){} // RVA: 0x4311D00
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x4311D30
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x4311E60
        public void IndexOf(){} // RVA: 0x4312140
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4311FA0
        public void Insert(){} // RVA: 0x43121B0
        public void System.Collections.IList.Insert(){} // RVA: 0x43122E0
        public void InsertRange(){} // RVA: 0x43123E0
        public void LastIndexOf(){} // RVA: 0x43127C0
        public void Remove(){} // RVA: 0x4312880
        public void System.Collections.IList.Remove(){} // RVA: 0x4312910
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x4312CA0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4312CF0
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
        public void .ctor(){} // RVA: 0x462BAB0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x462BD10
        public void get_Item(){} // RVA: 0x42FD0B0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD130
        public void System.Collections.IList.set_Item(){} // RVA: 0x4449430
        public void Add(){} // RVA: 0x4449530
        public void AddWithResize(){} // RVA: 0x4449590
        public void System.Collections.IList.Add(){} // RVA: 0x44495F0
        public void AddRange(){} // RVA: 0x462BDC0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x462BFD0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x462C010
        public void System.Collections.IList.Contains(){} // RVA: 0x462C070
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x435EC50
        public void Find(){} // RVA: 0x42FD8E0
        public void FindAll(){} // RVA: 0x4449B30
        public void FindIndex(){} // RVA: 0x42FDB70
        public void FindLastIndex(){} // RVA: 0x42FDD30
        public void ForEach(){} // RVA: 0x42FDE20
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42FDF60
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42FDF60
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x462C390
        public void System.Collections.IList.IndexOf(){} // RVA: 0x462C200
        public void Insert(){} // RVA: 0x4449E70
        public void System.Collections.IList.Insert(){} // RVA: 0x4449F30
        public void InsertRange(){} // RVA: 0x462C3F0
        public void LastIndexOf(){} // RVA: 0x462C7A0
        public void Remove(){} // RVA: 0x462C850
        public void System.Collections.IList.Remove(){} // RVA: 0x462C910
        public void RemoveAll(){} // RVA: 0x444A6F0
        public void RemoveAt(){} // RVA: 0x444A870
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x444A950
        public void Sort(){} // RVA: 0x444ABD0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42FF230
        public void AddEnumerable(){} // RVA: 0x462CCD0
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
        public void .ctor(){} // RVA: 0x44C70A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44C7300
        public void get_Item(){} // RVA: 0x44C73B0
        public void set_Item(){} // RVA: 0x44C73F0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x44C7430
        public void System.Collections.IList.set_Item(){} // RVA: 0x44C7490
        public void Add(){} // RVA: 0x44C7590
        public void AddWithResize(){} // RVA: 0x44C75F0
        public void System.Collections.IList.Add(){} // RVA: 0x44C7660
        public void AddRange(){} // RVA: 0x44C7790
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x44C7890
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x44C7900
        public void System.Collections.IList.Contains(){} // RVA: 0x44C7960
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x44C7A80
        public void Find(){} // RVA: 0x44C7B40
        public void FindAll(){} // RVA: 0x44C7BF0
        public void FindIndex(){} // RVA: 0x44C7DD0
        public void FindLastIndex(){} // RVA: 0x44C7F90
        public void ForEach(){} // RVA: 0x44C8080
        public void GetEnumerator(){} // RVA: 0x43E33F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43E3480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43E3480
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x44C82F0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44C8160
        public void Insert(){} // RVA: 0x44C8350
        public void System.Collections.IList.Insert(){} // RVA: 0x44C8420
        public void InsertRange(){} // RVA: 0x44C8510
        public void LastIndexOf(){} // RVA: 0x44C88D0
        public void Remove(){} // RVA: 0x44C8980
        public void System.Collections.IList.Remove(){} // RVA: 0x44C8A20
        public void RemoveAll(){} // RVA: 0x44C8B40
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x44C8DF0
        public void Sort(){} // RVA: 0x44C9150
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x44C9210
        public void AddEnumerable(){} // RVA: 0x44C92B0
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
        public void .ctor(){} // RVA: 0x4503160
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45033C0
        public void get_Item(){} // RVA: 0x43E2550
        public void set_Item(){} // RVA: 0x43E2590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43E25D0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4427AE0
        public void Add(){} // RVA: 0x1B69DD0
        public void AddWithResize(){} // RVA: 0x4427BE0
        public void System.Collections.IList.Add(){} // RVA: 0x4427C50
        public void AddRange(){} // RVA: 0x4503470
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4503680
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x45036C0
        public void System.Collections.IList.Contains(){} // RVA: 0x4503720
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x4503880
        public void Find(){} // RVA: 0x43E2E00
        public void FindAll(){} // RVA: 0x4428150
        public void FindIndex(){} // RVA: 0x43E3090
        public void FindLastIndex(){} // RVA: 0x43E3250
        public void ForEach(){} // RVA: 0x43E3340
        public void GetEnumerator(){} // RVA: 0x43E33F0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43E3480
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43E3480
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x4503A50
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45038D0
        public void Insert(){} // RVA: 0x4428480
        public void System.Collections.IList.Insert(){} // RVA: 0x4428540
        public void InsertRange(){} // RVA: 0x4503AB0
        public void LastIndexOf(){} // RVA: 0x4503E70
        public void Remove(){} // RVA: 0x4503F20
        public void System.Collections.IList.Remove(){} // RVA: 0x4503FC0
        public void RemoveAll(){} // RVA: 0x43E3F90
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x43E4230
        public void Sort(){} // RVA: 0x4428E50
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43E4650
        public void AddEnumerable(){} // RVA: 0x4504360
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
        public void .ctor(){} // RVA: 0x440C240
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x440C4A0
        public void get_Item(){} // RVA: 0x440C550
        public void set_Item(){} // RVA: 0x440C5C0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x440C630
        public void System.Collections.IList.set_Item(){} // RVA: 0x440C6B0
        public void Add(){} // RVA: 0x440C7D0
        public void AddWithResize(){} // RVA: 0x440C880
        public void System.Collections.IList.Add(){} // RVA: 0x440C910
        public void AddRange(){} // RVA: 0x440CA30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x440CCA0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x440CD00
        public void System.Collections.IList.Contains(){} // RVA: 0x440CD80
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x440CF20
        public void Find(){} // RVA: 0x440D010
        public void FindAll(){} // RVA: 0x440D140
        public void FindIndex(){} // RVA: 0x440D3B0
        public void FindLastIndex(){} // RVA: 0x440D5E0
        public void ForEach(){} // RVA: 0x440D710
        public void GetEnumerator(){} // RVA: 0x440D7E0
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x440D890
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x440D890
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x440DBD0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x440D9F0
        public void Insert(){} // RVA: 0x440DC60
        public void System.Collections.IList.Insert(){} // RVA: 0x440DD50
        public void InsertRange(){} // RVA: 0x440DE60
        public void LastIndexOf(){} // RVA: 0x440E2A0
        public void Remove(){} // RVA: 0x440E390
        public void System.Collections.IList.Remove(){} // RVA: 0x440E450
        public void RemoveAll(){} // RVA: 0x440E610
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x440E980
        public void Sort(){} // RVA: 0x440ED30
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x440EDF0
        public void AddEnumerable(){} // RVA: 0x440EEB0
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
        public void .ctor(){} // RVA: 0x444C2F0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x444C550
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x42EB910
        public void AddRange(){} // RVA: 0x444C600
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x444C820
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x444C860
        public void System.Collections.IList.Contains(){} // RVA: 0x444C8D0
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
        public void IndexOf(){} // RVA: 0x444CC20
        public void System.Collections.IList.IndexOf(){} // RVA: 0x444CA80
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x444CC90
        public void LastIndexOf(){} // RVA: 0x444D0E0
        public void Remove(){} // RVA: 0x444D1A0
        public void System.Collections.IList.Remove(){} // RVA: 0x444D2C0
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x444D6F0
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
        public void .ctor(){} // RVA: 0x4454BC0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4454E20
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x435BE90
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4360100
        public void Add(){} // RVA: 0x435C0F0
        public void AddWithResize(){} // RVA: 0x435C180
        public void System.Collections.IList.Add(){} // RVA: 0x4360210
        public void AddRange(){} // RVA: 0x4454ED0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4455110
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4455160
        public void System.Collections.IList.Contains(){} // RVA: 0x44551D0
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
        public void IndexOf(){} // RVA: 0x4455560
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44553A0
        public void Insert(){} // RVA: 0x435CDB0
        public void System.Collections.IList.Insert(){} // RVA: 0x4360A70
        public void InsertRange(){} // RVA: 0x44555E0
        public void LastIndexOf(){} // RVA: 0x44559E0
        public void Remove(){} // RVA: 0x4455AB0
        public void System.Collections.IList.Remove(){} // RVA: 0x4455B60
        public void RemoveAll(){} // RVA: 0x435D7C0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x435DAB0
        public void Sort(){} // RVA: 0x435DE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x4455F20
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
        public void .ctor(){} // RVA: 0x44577A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4457A00
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x435BE90
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4360100
        public void Add(){} // RVA: 0x435C0F0
        public void AddWithResize(){} // RVA: 0x435C180
        public void System.Collections.IList.Add(){} // RVA: 0x4360210
        public void AddRange(){} // RVA: 0x4457AB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4457CF0
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x4457D40
        public void System.Collections.IList.Contains(){} // RVA: 0x4457DB0
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
        public void IndexOf(){} // RVA: 0x4458140
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4457F80
        public void Insert(){} // RVA: 0x435CDB0
        public void System.Collections.IList.Insert(){} // RVA: 0x4360A70
        public void InsertRange(){} // RVA: 0x44581C0
        public void LastIndexOf(){} // RVA: 0x44585C0
        public void Remove(){} // RVA: 0x4458690
        public void System.Collections.IList.Remove(){} // RVA: 0x4458740
        public void RemoveAll(){} // RVA: 0x435D7C0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x435DAB0
        public void Sort(){} // RVA: 0x435DE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x4458B00
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
        public void .ctor(){} // RVA: 0x440F160
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x440F3C0
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x4304430
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x4304480
        public void Add(){} // RVA: 0x4304590
        public void AddWithResize(){} // RVA: 0x4304600
        public void System.Collections.IList.Add(){} // RVA: 0x4304670
        public void AddRange(){} // RVA: 0x440F470
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x440F690
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x440F6D0
        public void System.Collections.IList.Contains(){} // RVA: 0x440F740
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
        public void IndexOf(){} // RVA: 0x440FA90
        public void System.Collections.IList.IndexOf(){} // RVA: 0x440F8F0
        public void Insert(){} // RVA: 0x4305070
        public void System.Collections.IList.Insert(){} // RVA: 0x4305140
        public void InsertRange(){} // RVA: 0x440FB00
        public void LastIndexOf(){} // RVA: 0x440FF50
        public void Remove(){} // RVA: 0x4410010
        public void System.Collections.IList.Remove(){} // RVA: 0x44100C0
        public void RemoveAll(){} // RVA: 0x43059A0
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x4305C70
        public void Sort(){} // RVA: 0x4305FD0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4410470
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
        public void .ctor(){} // RVA: 0x446A7A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x446AA00
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42F3690
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F3730
        public void Add(){} // RVA: 0x1735620
        public void AddWithResize(){} // RVA: 0x42F3890
        public void System.Collections.IList.Add(){} // RVA: 0x42F3950
        public void AddRange(){} // RVA: 0x446AAB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x446ACD0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x446AD10
        public void System.Collections.IList.Contains(){} // RVA: 0x446AD80
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x42F3E80
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x446B0D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x446AF30
        public void Insert(){} // RVA: 0x42F4290
        public void System.Collections.IList.Insert(){} // RVA: 0x42F43C0
        public void InsertRange(){} // RVA: 0x446B140
        public void LastIndexOf(){} // RVA: 0x446B590
        public void Remove(){} // RVA: 0x446B650
        public void System.Collections.IList.Remove(){} // RVA: 0x446B770
        public void RemoveAll(){} // RVA: 0x42F4D10
        public void RemoveAt(){} // RVA: 0x42F4EE0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F5020
        public void Sort(){} // RVA: 0x42F52A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x446BBA0
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
        public void .ctor(){} // RVA: 0x45D63C0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45D6620
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x42EB910
        public void AddRange(){} // RVA: 0x45D66D0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x45D68F0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x45D6930
        public void System.Collections.IList.Contains(){} // RVA: 0x45D69A0
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
        public void IndexOf(){} // RVA: 0x45D6CF0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45D6B50
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x45D6D60
        public void LastIndexOf(){} // RVA: 0x45D71B0
        public void Remove(){} // RVA: 0x45D7270
        public void System.Collections.IList.Remove(){} // RVA: 0x45D7390
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x45D77C0
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
        public void .ctor(){} // RVA: 0x45D17F0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45D1A50
        public void get_Item(){} // RVA: 0x43F2140
        public void set_Item(){} // RVA: 0x45D1B00
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43F2210
        public void System.Collections.IList.set_Item(){} // RVA: 0x45D1BC0
        public void Add(){} // RVA: 0x45D1D40
        public void AddWithResize(){} // RVA: 0x45D1E50
        public void System.Collections.IList.Add(){} // RVA: 0x45D1F30
        public void AddRange(){} // RVA: 0x45D2050
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x45D22D0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x45D2330
        public void System.Collections.IList.Contains(){} // RVA: 0x45D23B0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43F2B10
        public void Find(){} // RVA: 0x43F2C10
        public void FindAll(){} // RVA: 0x45D2550
        public void FindIndex(){} // RVA: 0x43F2FC0
        public void FindLastIndex(){} // RVA: 0x43F3210
        public void ForEach(){} // RVA: 0x43F3350
        public void GetEnumerator(){} // RVA: 0x43F3430
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43F34F0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43F34F0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x45D2920
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45D2740
        public void Insert(){} // RVA: 0x45D29B0
        public void System.Collections.IList.Insert(){} // RVA: 0x45D2AF0
        public void InsertRange(){} // RVA: 0x45D2C10
        public void LastIndexOf(){} // RVA: 0x45D3050
        public void Remove(){} // RVA: 0x45D3140
        public void System.Collections.IList.Remove(){} // RVA: 0x45D3290
        public void RemoveAll(){} // RVA: 0x45D34E0
        public void RemoveAt(){} // RVA: 0x45D36E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x45D3830
        public void Sort(){} // RVA: 0x45D3AB0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43F4A80
        public void AddEnumerable(){} // RVA: 0x45D3B70
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
        public void .ctor(){} // RVA: 0x45C3290
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45C34F0
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void Add(){} // RVA: 0xD5D7C0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x42F1630
        public void AddRange(){} // RVA: 0x45C35A0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x45C37E0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x45C3830
        public void System.Collections.IList.Contains(){} // RVA: 0x45C38A0
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
        public void IndexOf(){} // RVA: 0x45C3C30
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45C3A70
        public void Insert(){} // RVA: 0x42F2030
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x45C3CB0
        public void LastIndexOf(){} // RVA: 0x45C40B0
        public void Remove(){} // RVA: 0x45C4180
        public void System.Collections.IList.Remove(){} // RVA: 0x45C42C0
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x45C4710
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
        public void .ctor(){} // RVA: 0x45C49A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45C4C00
        public void get_Item(){} // RVA: 0x430A230
        public void set_Item(){} // RVA: 0x430A290
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x430A350
        public void System.Collections.IList.set_Item(){} // RVA: 0x44520F0
        public void Add(){} // RVA: 0x430A4E0
        public void AddWithResize(){} // RVA: 0x430A5D0
        public void System.Collections.IList.Add(){} // RVA: 0x430A6B0
        public void AddRange(){} // RVA: 0x45C4CB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x45C4F10
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x45C4F60
        public void System.Collections.IList.Contains(){} // RVA: 0x45C4FE0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x430AC80
        public void Find(){} // RVA: 0x430AD70
        public void FindAll(){} // RVA: 0x43B5370
        public void FindIndex(){} // RVA: 0x430B0E0
        public void FindLastIndex(){} // RVA: 0x430B300
        public void ForEach(){} // RVA: 0x430B430
        public void GetEnumerator(){} // RVA: 0x430B500
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x430B5B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x430B5B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x45C53A0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45C51D0
        public void Insert(){} // RVA: 0x430B950
        public void System.Collections.IList.Insert(){} // RVA: 0x430BA90
        public void InsertRange(){} // RVA: 0x45C5420
        public void LastIndexOf(){} // RVA: 0x45C5850
        public void Remove(){} // RVA: 0x45C5920
        public void System.Collections.IList.Remove(){} // RVA: 0x45C5A70
        public void RemoveAll(){} // RVA: 0x430C440
        public void RemoveAt(){} // RVA: 0x430C610
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x430C760
        public void Sort(){} // RVA: 0x430C9E0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x430CAA0
        public void AddEnumerable(){} // RVA: 0x45C5ED0
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
        public void .ctor(){} // RVA: 0x43BE370
        public void Add(){} // RVA: 0x43B7E90
        public void ToArray(){} // RVA: 0x42EDF00
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x43BE5D0
        public void get_Item(){} // RVA: 0x43B7CB0
        public void set_Item(){} // RVA: 0x43B7CF0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x43B7D30
        public void System.Collections.IList.set_Item(){} // RVA: 0x43B7D90
        public void AddWithResize(){} // RVA: 0x43B7EF0
        public void System.Collections.IList.Add(){} // RVA: 0x43B7F60
        public void AddRange(){} // RVA: 0x43BE680
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x43BE890
        public void Clear(){} // RVA: 0x42FD6E0
        public void Contains(){} // RVA: 0x43BE8D0
        public void System.Collections.IList.Contains(){} // RVA: 0x43BE930
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43B84A0
        public void Find(){} // RVA: 0x43B8560
        public void FindAll(){} // RVA: 0x43B8610
        public void FindIndex(){} // RVA: 0x43B87E0
        public void FindLastIndex(){} // RVA: 0x43B89A0
        public void ForEach(){} // RVA: 0x43B8A90
        public void GetEnumerator(){} // RVA: 0x43B8B40
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43B8BD0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43B8BD0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x43BEC50
        public void System.Collections.IList.IndexOf(){} // RVA: 0x43BEAC0
        public void Insert(){} // RVA: 0x43B8EB0
        public void System.Collections.IList.Insert(){} // RVA: 0x43B8F80
        public void InsertRange(){} // RVA: 0x43BECB0
        public void LastIndexOf(){} // RVA: 0x43BF070
        public void Remove(){} // RVA: 0x43BF120
        public void System.Collections.IList.Remove(){} // RVA: 0x43BF1C0
        public void RemoveAll(){} // RVA: 0x43B9720
        public void RemoveAt(){} // RVA: 0x42FEC10
        public void RemoveRange(){} // RVA: 0x42FEC60
        public void Reverse(){} // RVA: 0x43BF3D0
        public void Sort(){} // RVA: 0x43B9D10
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x43B9DD0
        public void AddEnumerable(){} // RVA: 0x43BF650
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
        public void Add(){} // RVA: 0x430A4E0
        public void .ctor(){} // RVA: 0x4451DE0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4452040
        public void get_Item(){} // RVA: 0x430A230
        public void set_Item(){} // RVA: 0x430A290
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x430A350
        public void System.Collections.IList.set_Item(){} // RVA: 0x44520F0
        public void AddWithResize(){} // RVA: 0x430A5D0
        public void System.Collections.IList.Add(){} // RVA: 0x430A6B0
        public void AddRange(){} // RVA: 0x4452260
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x44524C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4452510
        public void System.Collections.IList.Contains(){} // RVA: 0x4452590
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x430AC80
        public void Find(){} // RVA: 0x430AD70
        public void FindAll(){} // RVA: 0x43B5370
        public void FindIndex(){} // RVA: 0x430B0E0
        public void FindLastIndex(){} // RVA: 0x430B300
        public void ForEach(){} // RVA: 0x430B430
        public void GetEnumerator(){} // RVA: 0x430B500
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x430B5B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x430B5B0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4452950
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4452780
        public void Insert(){} // RVA: 0x430B950
        public void System.Collections.IList.Insert(){} // RVA: 0x430BA90
        public void InsertRange(){} // RVA: 0x44529D0
        public void LastIndexOf(){} // RVA: 0x4452E00
        public void Remove(){} // RVA: 0x4452ED0
        public void System.Collections.IList.Remove(){} // RVA: 0x4452F60
        public void RemoveAll(){} // RVA: 0x430C440
        public void RemoveAt(){} // RVA: 0x430C610
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x430C760
        public void Sort(){} // RVA: 0x430C9E0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x430CAA0
        public void AddEnumerable(){} // RVA: 0x44532F0
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
        public void .ctor(){} // RVA: 0x4308890
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4308AF0
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42F3690
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F3730
        public void Add(){} // RVA: 0x1735620
        public void AddWithResize(){} // RVA: 0x42F3890
        public void System.Collections.IList.Add(){} // RVA: 0x42FF830
        public void AddRange(){} // RVA: 0x4308BA0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4308DC0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4308E00
        public void System.Collections.IList.Contains(){} // RVA: 0x4308E70
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EC040
        public void Find(){} // RVA: 0x42EC110
        public void FindAll(){} // RVA: 0x42FFD60
        public void FindIndex(){} // RVA: 0x42EC480
        public void FindLastIndex(){} // RVA: 0x42EC660
        public void ForEach(){} // RVA: 0x42EC760
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EC8B0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EC8B0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x43091C0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4309020
        public void Insert(){} // RVA: 0x42F4290
        public void System.Collections.IList.Insert(){} // RVA: 0x42F43C0
        public void InsertRange(){} // RVA: 0x4309230
        public void LastIndexOf(){} // RVA: 0x4309680
        public void Remove(){} // RVA: 0x4309740
        public void System.Collections.IList.Remove(){} // RVA: 0x4309860
        public void RemoveAll(){} // RVA: 0x42F4D10
        public void RemoveAt(){} // RVA: 0x42F4EE0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F5020
        public void Sort(){} // RVA: 0x42F52A0
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4309C90
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
        public void .ctor(){} // RVA: 0x462E5A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x462E800
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x4320170
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4320230
        public void Add(){} // RVA: 0x429CF30
        public void AddWithResize(){} // RVA: 0x43203A0
        public void System.Collections.IList.Add(){} // RVA: 0x4320470
        public void AddRange(){} // RVA: 0x462E8B0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x462EAF0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x462EB40
        public void System.Collections.IList.Contains(){} // RVA: 0x462EBB0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EF050
        public void Find(){} // RVA: 0x42EF130
        public void FindAll(){} // RVA: 0x4443BD0
        public void FindIndex(){} // RVA: 0x42EF460
        public void FindLastIndex(){} // RVA: 0x42EF660
        public void ForEach(){} // RVA: 0x42EF770
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x462EF40
        public void System.Collections.IList.IndexOf(){} // RVA: 0x462ED80
        public void Insert(){} // RVA: 0x4320E70
        public void System.Collections.IList.Insert(){} // RVA: 0x4320FA0
        public void InsertRange(){} // RVA: 0x462EFC0
        public void LastIndexOf(){} // RVA: 0x462F3C0
        public void Remove(){} // RVA: 0x462F490
        public void System.Collections.IList.Remove(){} // RVA: 0x462F510
        public void RemoveAll(){} // RVA: 0x4321900
        public void RemoveAt(){} // RVA: 0x4321AB0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4321C00
        public void Sort(){} // RVA: 0x4321E80
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x462F890
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
        public void .ctor(){} // RVA: 0x44ACD10
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44ACF70
        public void get_Item(){} // RVA: 0x4315F60
        public void set_Item(){} // RVA: 0x4315FE0
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x4316050
        public void System.Collections.IList.set_Item(){} // RVA: 0x43160E0
        public void Add(){} // RVA: 0x4316220
        public void AddWithResize(){} // RVA: 0x43162B0
        public void System.Collections.IList.Add(){} // RVA: 0x4316340
        public void AddRange(){} // RVA: 0x44AD020
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x44AD2B0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44AD320
        public void System.Collections.IList.Contains(){} // RVA: 0x44AD3C0
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x43169F0
        public void Find(){} // RVA: 0x4316AF0
        public void FindAll(){} // RVA: 0x44AD560
        public void FindIndex(){} // RVA: 0x4316F90
        public void FindLastIndex(){} // RVA: 0x43171E0
        public void ForEach(){} // RVA: 0x4317320
        public void GetEnumerator(){} // RVA: 0x4317420
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x43174D0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x43174D0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x44AD970
        public void System.Collections.IList.IndexOf(){} // RVA: 0x44AD770
        public void Insert(){} // RVA: 0x43178F0
        public void System.Collections.IList.Insert(){} // RVA: 0x43179F0
        public void InsertRange(){} // RVA: 0x44ADA10
        public void LastIndexOf(){} // RVA: 0x44ADE80
        public void Remove(){} // RVA: 0x44ADF80
        public void System.Collections.IList.Remove(){} // RVA: 0x44AE090
        public void RemoveAll(){} // RVA: 0x43183B0
        public void RemoveAt(){} // RVA: 0x43185D0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x43186D0
        public void Sort(){} // RVA: 0x4318950
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x4318A10
        public void AddEnumerable(){} // RVA: 0x44AE4B0
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
        public void .ctor(){} // RVA: 0x4506BC0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4506E20
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x42EB910
        public void AddRange(){} // RVA: 0x4506ED0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x45070F0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4507130
        public void System.Collections.IList.Contains(){} // RVA: 0x45071A0
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
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x45074F0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4507350
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4507560
        public void LastIndexOf(){} // RVA: 0x4507940
        public void Remove(){} // RVA: 0x4507A00
        public void System.Collections.IList.Remove(){} // RVA: 0x4507B20
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4507F50
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
        public void .ctor(){} // RVA: 0x4429150
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
        public void Add(){} // RVA: 0x1B69DD0
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
        public void ToArray(){} // RVA: 0x42EDF00
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
        public void .ctor(){} // RVA: 0x4429150
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
        public void Add(){} // RVA: 0x1B69DD0
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
        public void ToArray(){} // RVA: 0x42EDF00
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
        public void .ctor(){} // RVA: 0x4429150
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
        public void Add(){} // RVA: 0x1B69DD0
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
        public void ToArray(){} // RVA: 0x42EDF00
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
        public void .ctor(){} // RVA: 0x45EEDF0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Item(){} // RVA: 0x42EE780
        public void Add(){} // RVA: 0xD5D7C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void BinarySearch(){} // RVA: 0x45EF2F0
        public void Insert(){} // RVA: 0x42F2030
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void Remove(){} // RVA: 0x45EFCE0
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x45EF050
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x42F1630
        public void AddRange(){} // RVA: 0x45EF100
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void Contains(){} // RVA: 0x45EF390
        public void System.Collections.IList.Contains(){} // RVA: 0x45EF400
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
        public void GetRange(){} // RVA: 0x42F6CE0
        public void IndexOf(){} // RVA: 0x45EF790
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45EF5D0
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x45EF810
        public void LastIndexOf(){} // RVA: 0x45EFC10
        public void System.Collections.IList.Remove(){} // RVA: 0x45EFD60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x45F00E0
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

}