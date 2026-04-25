// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PlatformSupport.Collections.Specialized
// Classes: 4
// Methods: 44

namespace ThirdParty.Other.PlatformSupport.Collections.Specialized
{
    public class INotifyCollectionChanged
    {
        // ── Methods ──
        public void add_CollectionChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_CollectionChanged(){} // RVA: 0x7FFAC2C70A40
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public 0x6B083538 Action; // 0x10
        public System.Collections.IList NewItems; // 0x18
        public System.Collections.IList OldItems; // 0x20
        public int NewStartingIndex; // 0x28
        public int OldStartingIndex; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFACBA33B00 | overloaded x12
        public void InitializeAddOrRemove(){} // RVA: 0x7FFACBA33D00
        public void InitializeAdd(){} // RVA: 0x7FFACBA33D30
        public void InitializeRemove(){} // RVA: 0x7FFACBA33E60
        public void InitializeMoveOrReplace(){} // RVA: 0x7FFACBA33F90
        public void get_Action(){} // RVA: 0x7FFAC2F6E5C0
        public void get_NewItems(){} // RVA: 0x7FFAC2F247C0
        public void get_OldItems(){} // RVA: 0x7FFAC2F4F0C0
        public void get_NewStartingIndex(){} // RVA: 0x7FFAC32EC4C0
        public void get_OldStartingIndex(){} // RVA: 0x7FFAC3C891D0
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC45B91D0
        public void Invoke(){} // RVA: 0x7FFAC307D370
        public void BeginInvoke(){} // RVA: 0x7FFAC3AD0620
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class ReadOnlyList : Object
    {
        public System.Collections.IList Count; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_Count(){} // RVA: 0x7FFACBA33FF0
        public void get_IsReadOnly(){} // RVA: 0x7FFAC3006850
        public void get_IsFixedSize(){} // RVA: 0x7FFAC3006850
        public void get_IsSynchronized(){} // RVA: 0x7FFACBA34040
        public void get_Item(){} // RVA: 0x7FFACBA34090
        public void set_Item(){} // RVA: 0x7FFACBA340F0
        public void get_SyncRoot(){} // RVA: 0x7FFACBA34130
        public void Add(){} // RVA: 0x7FFACBA34180
        public void Clear(){} // RVA: 0x7FFACBA341C0
        public void Contains(){} // RVA: 0x7FFACBA34200
        public void CopyTo(){} // RVA: 0x7FFACBA34260
        public void GetEnumerator(){} // RVA: 0x7FFACBA342D0
        public void IndexOf(){} // RVA: 0x7FFACBA34320
        public void Insert(){} // RVA: 0x7FFACBA34380
        public void Remove(){} // RVA: 0x7FFACBA343C0
        public void RemoveAt(){} // RVA: 0x7FFACBA34400
    }

}