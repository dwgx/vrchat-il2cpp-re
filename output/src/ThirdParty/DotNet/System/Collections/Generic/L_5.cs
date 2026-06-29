// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Collections.Generic
// Classes: 100
// Methods: 4369

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
        public void .ctor(){} // RVA: 0x43978A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4397B00
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x430D110
        public void AddRange(){} // RVA: 0x4397BB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4397DD0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4397E10
        public void System.Collections.IList.Contains(){} // RVA: 0x4397E80
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
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x43981D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4398030
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4398240
        public void LastIndexOf(){} // RVA: 0x4398690
        public void Remove(){} // RVA: 0x4398750
        public void System.Collections.IList.Remove(){} // RVA: 0x4398870
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4398CA0
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
        public void .ctor(){} // RVA: 0x43978A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4397B00
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x430D110
        public void AddRange(){} // RVA: 0x4397BB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4397DD0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4397E10
        public void System.Collections.IList.Contains(){} // RVA: 0x4397E80
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
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x43981D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4398030
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4398240
        public void LastIndexOf(){} // RVA: 0x4398690
        public void Remove(){} // RVA: 0x4398750
        public void System.Collections.IList.Remove(){} // RVA: 0x4398870
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4398CA0
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
        public void .ctor(){} // RVA: 0x43978A0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4397B00
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x430D110
        public void AddRange(){} // RVA: 0x4397BB0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4397DD0
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4397E10
        public void System.Collections.IList.Contains(){} // RVA: 0x4397E80
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
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x43981D0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4398030
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x4398240
        public void LastIndexOf(){} // RVA: 0x4398690
        public void Remove(){} // RVA: 0x4398750
        public void System.Collections.IList.Remove(){} // RVA: 0x4398870
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4398CA0
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
        public void .ctor(){} // RVA: 0x437F930
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x437FB90
        public void get_Item(){} // RVA: 0x42EB540
        public void set_Item(){} // RVA: 0x42EB590
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EB690
        public void System.Collections.IList.set_Item(){} // RVA: 0x42EB6F0
        public void Add(){} // RVA: 0xE3F630
        public void AddWithResize(){} // RVA: 0x42EB850
        public void System.Collections.IList.Add(){} // RVA: 0x430D110
        public void AddRange(){} // RVA: 0x437FC40
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x437FE60
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x437FEA0
        public void System.Collections.IList.Contains(){} // RVA: 0x437FF10
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
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4380260
        public void System.Collections.IList.IndexOf(){} // RVA: 0x43800C0
        public void Insert(){} // RVA: 0x42ECE00
        public void System.Collections.IList.Insert(){} // RVA: 0x42ECF30
        public void InsertRange(){} // RVA: 0x43802D0
        public void LastIndexOf(){} // RVA: 0x43806B0
        public void Remove(){} // RVA: 0x4380770
        public void System.Collections.IList.Remove(){} // RVA: 0x4380890
        public void RemoveAll(){} // RVA: 0x42ED810
        public void RemoveAt(){} // RVA: 0x42ED9E0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42EDBC0
        public void Sort(){} // RVA: 0x42EDE40
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42EE040
        public void AddEnumerable(){} // RVA: 0x4380CC0
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
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
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
        public void AddRange(){} // RVA: 0x4487F30
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void .ctor(){} // RVA: 0x4487990
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
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
        public void Add(){} // RVA: 0xE3F630
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
        public void Add(){} // RVA: 0x429CF30
        public void .ctor(){} // RVA: 0x4443340
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x44435A0
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x4320170
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4443650
        public void AddWithResize(){} // RVA: 0x43203A0
        public void System.Collections.IList.Add(){} // RVA: 0x4320470
        public void AddRange(){} // RVA: 0x4443750
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4443990
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x44439E0
        public void System.Collections.IList.Contains(){} // RVA: 0x4443A50
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
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4443F30
        public void System.Collections.IList.IndexOf(){} // RVA: 0x4443D70
        public void Insert(){} // RVA: 0x4320E70
        public void System.Collections.IList.Insert(){} // RVA: 0x4320FA0
        public void InsertRange(){} // RVA: 0x4443FB0
        public void LastIndexOf(){} // RVA: 0x44443B0
        public void Remove(){} // RVA: 0x4444480
        public void System.Collections.IList.Remove(){} // RVA: 0x4444500
        public void RemoveAll(){} // RVA: 0x4321900
        public void RemoveAt(){} // RVA: 0x4321AB0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4321C00
        public void Sort(){} // RVA: 0x4321E80
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x4444880
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
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
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
        public void .ctor(){} // RVA: 0x42EAED0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void get_Item(){} // RVA: 0x42FD0B0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void Add(){} // RVA: 0xB677C0
        public void Contains(){} // RVA: 0x44880A0
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
        public void Insert(){} // RVA: 0x4488570
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
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
        public void Exists(){} // RVA: 0x42FD8B0
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
        public void Add(){} // RVA: 0xB677C0
        public void ToArray(){} // RVA: 0x42EDF00
        public void get_Count(){} // RVA: 0xE62D00
        public void .ctor(){} // RVA: 0x42EAF90
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
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
        public void .ctor(){} // RVA: 0x42EAF90
        public void Add(){} // RVA: 0xE3F630
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
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x42FD0B0
        public void Add(){} // RVA: 0xB677C0
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
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
        public void GetEnumerator(){} // RVA: 0x42EC820
        public void Add(){} // RVA: 0x29DFBA0
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
        public void Add(){} // RVA: 0x14E3690
        public void .ctor(){} // RVA: 0x437DF00
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x437E160
        public void get_Item(){} // RVA: 0x42F5900
        public void set_Item(){} // RVA: 0x42F5960
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42F5A20
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F5AA0
        public void AddWithResize(){} // RVA: 0x42F5C20
        public void System.Collections.IList.Add(){} // RVA: 0x437E210
        public void AddRange(){} // RVA: 0x437E320
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x437E580
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x437E5D0
        public void System.Collections.IList.Contains(){} // RVA: 0x437E650
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42F62D0
        public void Find(){} // RVA: 0x42F63B0
        public void FindAll(){} // RVA: 0x437E7E0
        public void FindIndex(){} // RVA: 0x42F6710
        public void FindLastIndex(){} // RVA: 0x42F6930
        public void ForEach(){} // RVA: 0x42F6A60
        public void GetEnumerator(){} // RVA: 0x42F6B30
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42F6BE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42F6BE0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x437EB70
        public void System.Collections.IList.IndexOf(){} // RVA: 0x437E9A0
        public void Insert(){} // RVA: 0x42F7080
        public void System.Collections.IList.Insert(){} // RVA: 0x42F71C0
        public void InsertRange(){} // RVA: 0x437EBF0
        public void LastIndexOf(){} // RVA: 0x437F010
        public void Remove(){} // RVA: 0x437F0E0
        public void System.Collections.IList.Remove(){} // RVA: 0x437F230
        public void RemoveAll(){} // RVA: 0x42F7B60
        public void RemoveAt(){} // RVA: 0x42F7D30
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F7E80
        public void Sort(){} // RVA: 0x42F8100
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F81C0
        public void AddEnumerable(){} // RVA: 0x437F690
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
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
        public void .ctor(){} // RVA: 0x42F1030
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x42F1290
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void Add(){} // RVA: 0xD5D7C0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x42F1630
        public void AddRange(){} // RVA: 0x42F1730
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x42F1970
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x42F19C0
        public void System.Collections.IList.Contains(){} // RVA: 0x42F1A30
        public void ConvertAll(){} // RVA: 0x87C540
        public void CopyTo(){} // RVA: 0x42EBFB0
        public void System.Collections.ICollection.CopyTo(){} // RVA: 0x42EBF10
        public void EnsureCapacity(){} // RVA: 0x42EBFE0
        public void Exists(){} // RVA: 0x42EF050
        public void Find(){} // RVA: 0x42EF130
        public void FindAll(){} // RVA: 0x42F1BB0
        public void FindIndex(){} // RVA: 0x42EF460
        public void FindLastIndex(){} // RVA: 0x42EF660
        public void ForEach(){} // RVA: 0x42EF770
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x42F1FB0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x42F1DF0
        public void Insert(){} // RVA: 0x42F2030
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x42F2260
        public void LastIndexOf(){} // RVA: 0x42F2660
        public void Remove(){} // RVA: 0x42F2730
        public void System.Collections.IList.Remove(){} // RVA: 0x42F2870
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x42F30F0
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
        public void .ctor(){} // RVA: 0x43C0E10
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void get_Count(){} // RVA: 0xE62D00
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x43C1070
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x42F1340
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x42F13F0
        public void Add(){} // RVA: 0xD5D7C0
        public void AddWithResize(){} // RVA: 0x42F1560
        public void System.Collections.IList.Add(){} // RVA: 0x42F1630
        public void AddRange(){} // RVA: 0x43C1120
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x43C1360
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x43C13B0
        public void System.Collections.IList.Contains(){} // RVA: 0x43C1420
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
        public void IndexOf(){} // RVA: 0x43C17B0
        public void System.Collections.IList.IndexOf(){} // RVA: 0x43C15F0
        public void Insert(){} // RVA: 0x42F2030
        public void System.Collections.IList.Insert(){} // RVA: 0x42F2160
        public void InsertRange(){} // RVA: 0x43C1830
        public void LastIndexOf(){} // RVA: 0x43C1C30
        public void Remove(){} // RVA: 0x43C1D00
        public void System.Collections.IList.Remove(){} // RVA: 0x43C1E40
        public void RemoveAll(){} // RVA: 0x42F2AB0
        public void RemoveAt(){} // RVA: 0x42F2C60
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x42F2DB0
        public void Sort(){} // RVA: 0x42F3030
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x43C2290
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
        public void GetEnumerator(){} // RVA: 0x42EF830
        public void get_Count(){} // RVA: 0xE62D00
        public void Add(){} // RVA: 0x429CF30
        public void RemoveAll(){} // RVA: 0x4321900
        public void .ctor(){} // RVA: 0x4590FD0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4591230
        public void get_Item(){} // RVA: 0x42EE780
        public void set_Item(){} // RVA: 0x4320170
        public void IsCompatibleObject(){} // RVA: 0x42EB630
        public void System.Collections.IList.get_Item(){} // RVA: 0x42EE890
        public void System.Collections.IList.set_Item(){} // RVA: 0x4320230
        public void AddWithResize(){} // RVA: 0x43203A0
        public void System.Collections.IList.Add(){} // RVA: 0x4320470
        public void AddRange(){} // RVA: 0x45912E0
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4591520
        public void Clear(){} // RVA: 0xCBB0D0
        public void Contains(){} // RVA: 0x4591570
        public void System.Collections.IList.Contains(){} // RVA: 0x45915E0
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
        public void System.Collections.Generic.IEnumerable<T>.GetEnumerator(){} // RVA: 0x42EF8C0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x42EF8C0
        public void GetRange(){} // RVA: 0x42EC980
        public void IndexOf(){} // RVA: 0x4591970
        public void System.Collections.IList.IndexOf(){} // RVA: 0x45917B0
        public void Insert(){} // RVA: 0x4320E70
        public void System.Collections.IList.Insert(){} // RVA: 0x4320FA0
        public void InsertRange(){} // RVA: 0x45919F0
        public void LastIndexOf(){} // RVA: 0x4591DF0
        public void Remove(){} // RVA: 0x4591EC0
        public void System.Collections.IList.Remove(){} // RVA: 0x4592010
        public void RemoveAt(){} // RVA: 0x4321AB0
        public void RemoveRange(){} // RVA: 0x42EDAB0
        public void Reverse(){} // RVA: 0x4321C00
        public void Sort(){} // RVA: 0x4321E80
        public void ToArray(){} // RVA: 0x42EDF00
        public void TrimExcess(){} // RVA: 0x42EDFF0
        public void TrueForAll(){} // RVA: 0x42F0CF0
        public void AddEnumerable(){} // RVA: 0x4592460
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
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
        public void Add(){} // RVA: 0xB677C0
        public void ToArray(){} // RVA: 0x42EDF00
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
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
        public void get_Count(){} // RVA: 0xE62D00
        public void get_Item(){} // RVA: 0x42FD0B0
        public void Add(){} // RVA: 0xB677C0
        public void Clear(){} // RVA: 0xCBB0D0
        public void RemoveAll(){} // RVA: 0x4488D40
        public void .ctor(){} // RVA: 0x4487990
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void AddRange(){} // RVA: 0x4487F30
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void AddRange(){} // RVA: 0x4487F30
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void AddRange(){} // RVA: 0x4487F30
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void AddRange(){} // RVA: 0x4487F30
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void AddRange(){} // RVA: 0x4487F30
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void .ctor(){} // RVA: 0x4487990
        public void Clear(){} // RVA: 0xCBB0D0
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
        public void Add(){} // RVA: 0xB677C0
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
        public void .ctor(){} // RVA: 0x4487990
        public void get_Item(){} // RVA: 0x42FD0B0
        public void RemoveAt(){} // RVA: 0x444A870
        public void Add(){} // RVA: 0xB677C0
        public void GetEnumerator(){} // RVA: 0x42FDED0
        public void Clear(){} // RVA: 0xCBB0D0
        public void get_Capacity(){} // RVA: 0x17F0080
        public void set_Capacity(){} // RVA: 0x42EB370
        public void System.Collections.IList.get_IsFixedSize(){} // RVA: 0xB43320
        public void System.Collections.Generic.ICollection<T>.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.IList.get_IsReadOnly(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_IsSynchronized(){} // RVA: 0xB43320
        public void System.Collections.ICollection.get_SyncRoot(){} // RVA: 0x4487BF0
        public void set_Item(){} // RVA: 0x44493F0
        public void IsCompatibleObject(){} // RVA: 0x435E4A0
        public void System.Collections.IList.get_Item(){} // RVA: 0x42FD0B0
        public void System.Collections.IList.set_Item(){} // RVA: 0x4487CA0
        public void AddWithResize(){} // RVA: 0x4487DA0
        public void System.Collections.IList.Add(){} // RVA: 0x4487E00
        public void AddRange(){} // RVA: 0x4487F30
        public void AsReadOnly(){} // RVA: 0x42EBA20
        public void BinarySearch(){} // RVA: 0x4488030
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

}