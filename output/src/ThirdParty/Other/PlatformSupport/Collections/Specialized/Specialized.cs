// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PlatformSupport.Collections.Specialized
// Classes: 4
// Methods: 33

namespace ThirdParty.Other.PlatformSupport.Collections.Specialized
{
    public class INotifyCollectionChanged
    {
        // ── Methods ──
        public void add_CollectionChanged(){} // RVA: 0x7A7E18800
        public void remove_CollectionChanged(){} // RVA: 0x7A7E18800
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B125E810
        public void InitializeAddOrRemove(){} // RVA: 0x7B125EA30
        public void InitializeAdd(){} // RVA: 0x7B125EA60
        public void InitializeRemove(){} // RVA: 0x7B125EB90
        public void InitializeMoveOrReplace(){} // RVA: 0x7B125ECC0
        public void get_Action(){} // RVA: 0x7A8124910
        public void get_NewItems(){} // RVA: 0x7A80DA7B0
        public void get_OldItems(){} // RVA: 0x7A81052C0
        public void get_NewStartingIndex(){} // RVA: 0x7A854FDE0
        public void get_OldStartingIndex(){} // RVA: 0x7A8F9ACE0
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A98B8320
        public void Invoke(){} // RVA: 0x7A82344F0
        public void BeginInvoke(){} // RVA: 0x7A98B8490
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class ReadOnlyList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_Count(){} // RVA: 0x7B125ED20
        public void get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void get_IsFixedSize(){} // RVA: 0x7A81BD750
        public void get_IsSynchronized(){} // RVA: 0x7B125ED70
        public void get_Item(){} // RVA: 0x7B125EDC0
        public void set_Item(){} // RVA: 0x7B125EE20
        public void get_SyncRoot(){} // RVA: 0x7B125EE60
        public void Add(){} // RVA: 0x7B125EEB0
        public void Clear(){} // RVA: 0x7B125EEF0
        public void Contains(){} // RVA: 0x7B125EF30
        public void CopyTo(){} // RVA: 0x7B125EF90
        public void GetEnumerator(){} // RVA: 0x7B125F000
        public void IndexOf(){} // RVA: 0x7B125F050
        public void Insert(){} // RVA: 0x7B125F0B0
        public void Remove(){} // RVA: 0x7B125F0F0
        public void RemoveAt(){} // RVA: 0x7B125F130
    }

}