// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.PlatformSupport.Collections.Specialized
// Classes: 4
// Methods: 44

namespace ThirdParty.Other.PlatformSupport.Collections.Specialized
{
    public class INotifyCollectionChanged
    {
        // ── Methods ──
        public void add_CollectionChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_CollectionChanged(){} // RVA: 0x7FFE80E460A0
    }

    public class NotifyCollectionChangedEventArgs : EventArgs
    {
        public 0x6647BCCC _action; // 0x10
        public System.Collections.IList _newItems; // 0x18
        public System.Collections.IList _oldItems; // 0x20
        public int _newStartingIndex; // 0x28
        public int _oldStartingIndex; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE89E8D120 | overloaded x12
        public void InitializeAddOrRemove(){} // RVA: 0x7FFE89E8D320
        public void InitializeAdd(){} // RVA: 0x7FFE89E8D350
        public void InitializeRemove(){} // RVA: 0x7FFE89E8D480
        public void InitializeMoveOrReplace(){} // RVA: 0x7FFE89E8D5B0
        public void get_Action(){} // RVA: 0x7FFE811485C0
        public void get_NewItems(){} // RVA: 0x7FFE810FE7C0
        public void get_OldItems(){} // RVA: 0x7FFE811290C0
        public void get_NewStartingIndex(){} // RVA: 0x7FFE81549710
        public void get_OldStartingIndex(){} // RVA: 0x7FFE81F84A50
    }

    public class NotifyCollectionChangedEventHandler : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828867F0
        public void Invoke(){} // RVA: 0x7FFE81257370
        public void BeginInvoke(){} // RVA: 0x7FFE82886970
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class ReadOnlyList : Object
    {
        public System.Collections.IList _list; // 0x10
        public object field_1; // 0x9
        public object field_2; // 0xA
        public object field_3; // 0xB
        public object field_4; // 0xC
        public object field_5; // 0xD

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_Count(){} // RVA: 0x7FFE89E8D610
        public void get_IsReadOnly(){} // RVA: 0x7FFE811E0850
        public void get_IsFixedSize(){} // RVA: 0x7FFE811E0850
        public void get_IsSynchronized(){} // RVA: 0x7FFE89E8D660
        public void get_Item(){} // RVA: 0x7FFE89E8D6B0
        public void set_Item(){} // RVA: 0x7FFE89E8D710
        public void get_SyncRoot(){} // RVA: 0x7FFE89E8D750
        public void Add(){} // RVA: 0x7FFE89E8D7A0
        public void Clear(){} // RVA: 0x7FFE89E8D7E0
        public void Contains(){} // RVA: 0x7FFE89E8D820
        public void CopyTo(){} // RVA: 0x7FFE89E8D880
        public void GetEnumerator(){} // RVA: 0x7FFE89E8D8F0
        public void IndexOf(){} // RVA: 0x7FFE89E8D940
        public void Insert(){} // RVA: 0x7FFE89E8D9A0
        public void Remove(){} // RVA: 0x7FFE89E8D9E0
        public void RemoveAt(){} // RVA: 0x7FFE89E8DA20
    }

}