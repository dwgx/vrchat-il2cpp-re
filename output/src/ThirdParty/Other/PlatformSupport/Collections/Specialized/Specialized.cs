// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PlatformSupport.Collections.Specialized
// Classes: 4
// Methods: 44

namespace ThirdParty.Other.PlatformSupport.Collections.Specialized
{
    public class INotifyCollectionChanged
    {
        // ── Methods ──
        public void add_CollectionChanged(){} // RVA: 0x24B10
        public void remove_CollectionChanged(){} // RVA: 0x24B10
    }

    public class NotifyCollectionChangedEventArgs
    {
        public 0x6579D2D8 Count; // 0x10
        public System.Collections.IList IsReadOnly; // 0x18
        public System.Collections.IList IsFixedSize; // 0x20
        public int IsSynchronized; // 0x28
        public int Item; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x942AD50 | overloaded x12
        public void InitializeAddOrRemove(){} // RVA: 0x942AF50
        public void InitializeAdd(){} // RVA: 0x942AF80
        public void InitializeRemove(){} // RVA: 0x942B0B0
        public void InitializeMoveOrReplace(){} // RVA: 0x942B1E0
        public void get_Action(){} // RVA: 0x32A5C0
        public void get_NewItems(){} // RVA: 0x2E07C0
        public void get_OldItems(){} // RVA: 0x30B0C0
        public void get_NewStartingIndex(){} // RVA: 0x791DC0
        public void get_OldStartingIndex(){} // RVA: 0x1209F00
    }

    public class NotifyCollectionChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1AFE240
        public void Invoke(){} // RVA: 0x439370
        public void BeginInvoke(){} // RVA: 0x1AFE3C0
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class ReadOnlyList
    {
        public System.Collections.IList _list; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_Count(){} // RVA: 0x942B240
        public void get_IsReadOnly(){} // RVA: 0x3C2850
        public void get_IsFixedSize(){} // RVA: 0x3C2850
        public void get_IsSynchronized(){} // RVA: 0x942B290
        public void get_Item(){} // RVA: 0x942B2E0
        public void set_Item(){} // RVA: 0x942B340
        public void get_SyncRoot(){} // RVA: 0x942B380
        public void Add(){} // RVA: 0x942B3D0
        public void Clear(){} // RVA: 0x942B410
        public void Contains(){} // RVA: 0x942B450
        public void CopyTo(){} // RVA: 0x942B4B0
        public void GetEnumerator(){} // RVA: 0x942B520
        public void IndexOf(){} // RVA: 0x942B570
        public void Insert(){} // RVA: 0x942B5D0
        public void Remove(){} // RVA: 0x942B610
        public void RemoveAt(){} // RVA: 0x942B650
    }

}