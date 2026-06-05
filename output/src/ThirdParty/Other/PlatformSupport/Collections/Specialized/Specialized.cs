// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PlatformSupport.Collections.Specialized
// Classes: 4
// Methods: 44

namespace ThirdParty.Other.PlatformSupport.Collections.Specialized
{
    public class INotifyCollectionChanged
    {
        // ── Methods ──
        public void add_CollectionChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_CollectionChanged(){} // RVA: 0x7FFAF2AD4B10
    }

    public class NotifyCollectionChangedEventArgs
    {
        public object Count;
        public object IsReadOnly;
        public object IsFixedSize;
        public object IsSynchronized;
        public object Item;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFBEDAD50 | overloaded x12
        public void InitializeAddOrRemove(){} // RVA: 0x7FFAFBEDAF50
        public void InitializeAdd(){} // RVA: 0x7FFAFBEDAF80
        public void InitializeRemove(){} // RVA: 0x7FFAFBEDB0B0
        public void InitializeMoveOrReplace(){} // RVA: 0x7FFAFBEDB1E0
        public void get_Action(){} // RVA: 0x7FFAF2DDA5C0
        public void get_NewItems(){} // RVA: 0x7FFAF2D907C0
        public void get_OldItems(){} // RVA: 0x7FFAF2DBB0C0
        public void get_NewStartingIndex(){} // RVA: 0x7FFAF3241DC0
        public void get_OldStartingIndex(){} // RVA: 0x7FFAF3CB9F00
    }

    public class NotifyCollectionChangedEventHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF45AE240
        public void Invoke(){} // RVA: 0x7FFAF2EE9370
        public void BeginInvoke(){} // RVA: 0x7FFAF45AE3C0
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class ReadOnlyList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_Count(){} // RVA: 0x7FFAFBEDB240
        public void get_IsReadOnly(){} // RVA: 0x7FFAF2E72850
        public void get_IsFixedSize(){} // RVA: 0x7FFAF2E72850
        public void get_IsSynchronized(){} // RVA: 0x7FFAFBEDB290
        public void get_Item(){} // RVA: 0x7FFAFBEDB2E0
        public void set_Item(){} // RVA: 0x7FFAFBEDB340
        public void get_SyncRoot(){} // RVA: 0x7FFAFBEDB380
        public void Add(){} // RVA: 0x7FFAFBEDB3D0
        public void Clear(){} // RVA: 0x7FFAFBEDB410
        public void Contains(){} // RVA: 0x7FFAFBEDB450
        public void CopyTo(){} // RVA: 0x7FFAFBEDB4B0
        public void GetEnumerator(){} // RVA: 0x7FFAFBEDB520
        public void IndexOf(){} // RVA: 0x7FFAFBEDB570
        public void Insert(){} // RVA: 0x7FFAFBEDB5D0
        public void Remove(){} // RVA: 0x7FFAFBEDB610
        public void RemoveAt(){} // RVA: 0x7FFAFBEDB650
    }

}