// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PlatformSupport.Collections.Specialized
// Classes: 4
// Methods: 33

namespace ThirdParty.Other.PlatformSupport.Collections.Specialized
{
    public class INotifyCollectionChanged
    {
        // ── Methods ──
        public void add_CollectionChanged(){} // RVA: 0x894320
        public void remove_CollectionChanged(){} // RVA: 0x894320
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public object _action;
        public object _newItems;
        public object _oldItems;
        public object _newStartingIndex;
        public object _oldStartingIndex;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA0CA500
        public void InitializeAddOrRemove(){} // RVA: 0xA0CA720
        public void InitializeAdd(){} // RVA: 0xA0CA750
        public void InitializeRemove(){} // RVA: 0xA0CA880
        public void InitializeMoveOrReplace(){} // RVA: 0xA0CA9B0
        public void get_Action(){} // RVA: 0xB8F8F0
        public void get_NewItems(){} // RVA: 0xB465B0
        public void get_OldItems(){} // RVA: 0xB700F0
        public void get_NewStartingIndex(){} // RVA: 0x1065D50
        public void get_OldStartingIndex(){} // RVA: 0x1AE5AC0
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x23E7D60
        public void Invoke(){} // RVA: 0xCA8BF0
        public void BeginInvoke(){} // RVA: 0x23E7ED0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class ReadOnlyList : Object
    {
        public object _list;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_Count(){} // RVA: 0xA0CAA10
        public void get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void get_IsFixedSize(){} // RVA: 0xC2E4C0
        public void get_IsSynchronized(){} // RVA: 0xA0CAA60
        public void get_Item(){} // RVA: 0xA0CAAB0
        public void set_Item(){} // RVA: 0xA0CAB10
        public void get_SyncRoot(){} // RVA: 0xA0CAB50
        public void Add(){} // RVA: 0xA0CABA0
        public void Clear(){} // RVA: 0xA0CABE0
        public void Contains(){} // RVA: 0xA0CAC20
        public void CopyTo(){} // RVA: 0xA0CAC80
        public void GetEnumerator(){} // RVA: 0xA0CACF0
        public void IndexOf(){} // RVA: 0xA0CAD40
        public void Insert(){} // RVA: 0xA0CADA0
        public void Remove(){} // RVA: 0xA0CADE0
        public void RemoveAt(){} // RVA: 0xA0CAE20
    }

}