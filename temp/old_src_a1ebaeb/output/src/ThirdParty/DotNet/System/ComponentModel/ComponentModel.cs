// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 4
// Methods: 72

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BindingList`1 : Collection`1
    {
        public object raiseItemChangedEvents; // 0x30DCEE90
        public object _onAddingNew; // 0x30DCEE90
        public object allowNew; // 0x30DCEE90
        public object userSetAllowNew; // 0x30DCEE90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Initialize(){} // RVA: 0x7ffaa8660cc0
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0x7ffaa864a040
        public void add_AddingNew(){} // RVA: 0x7ffaa8660d80
        public void remove_AddingNew(){} // RVA: 0x7ffaa8660d80
        public void OnAddingNew(){} // RVA: 0x7ffaa8660d80
        public void FireAddingNew(){} // RVA: 0x7ffaa86491d0
        public void add_ListChanged(){} // RVA: 0x7ffaa8660d80
        public void remove_ListChanged(){} // RVA: 0x7ffaa8660d80
        public void OnListChanged(){} // RVA: 0x7ffaa8660d80
        public void get_RaiseListChangedEvents(){} // RVA: 0x7ffaa864a040
        public void set_RaiseListChangedEvents(){} // RVA: 0x7ffaa86613a0
        public void ResetBindings(){} // RVA: 0x7ffaa8660cc0
        public void ResetItem(){} // RVA: 0x7ffaa8661210
        public void FireListChanged(){} // RVA: 0x7ffaa86631a0
        public void ClearItems(){} // RVA: 0x7ffaa8660cc0
        public void InsertItem(){} // RVA: 0x7ffaa887e5c0
        public void RemoveItem(){} // RVA: 0x7ffaa8661210
        public void CancelNew(){} // RVA: 0x7ffaa8661210
        public void EndNew(){} // RVA: 0x7ffaa8661210
        public void AddNew(){} // RVA: 0x7ffaa887e5c0
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7ffaa86491d0
        public void get_AddingNewHandled(){} // RVA: 0x7ffaa864a040
        public void AddNewCore(){} // RVA: 0x7ffaa86491d0
        public void get_AllowNew(){} // RVA: 0x7ffaa864a040
        public void set_AllowNew(){} // RVA: 0x7ffaa86613a0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7ffaa864a040
        public void get_AllowEdit(){} // RVA: 0x7ffaa864a040
        public void set_AllowEdit(){} // RVA: 0x7ffaa86613a0
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7ffaa864a040
        public void get_AllowRemove(){} // RVA: 0x7ffaa864a040
        public void set_AllowRemove(){} // RVA: 0x7ffaa86613a0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7ffaa864a040
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7ffaa864a040
        public void get_SupportsChangeNotificationCore(){} // RVA: 0x7ffaa864a040
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7ffaa864a040
        public void get_SupportsSearchingCore(){} // RVA: 0x7ffaa864a040
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7ffaa864a040
        public void get_SupportsSortingCore(){} // RVA: 0x7ffaa864a040
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7ffaa864a040
        public void get_IsSortedCore(){} // RVA: 0x7ffaa864a040
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7ffaa86491d0
        public void get_SortPropertyCore(){} // RVA: 0x7ffaa86491d0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7ffaa8649ca0
        public void get_SortDirectionCore(){} // RVA: 0x7ffaa8649ca0
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7ffaa8667cb0
        public void ApplySortCore(){} // RVA: 0x7ffaa8667cb0
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7ffaa8660cc0
        public void RemoveSortCore(){} // RVA: 0x7ffaa8660cc0
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7ffaa8653ae0
        public void FindCore(){} // RVA: 0x7ffaa8653ae0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7ffaa8660d80
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7ffaa8660d80
        public void HookPropertyChanged(){} // RVA: 0x7ffaa887e5c0
        public void UnhookPropertyChanged(){} // RVA: 0x7ffaa887e5c0
        public void Child_PropertyChanged(){} // RVA: 0x7ffaa8669e70
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void SetItem(){} // RVA: 0x7ffaa887e5c0
    }

    public class IComponent
    {
        // ── Original Methods ──
        public void get_Site(){} // RVA: 0x7ffaa86491d0
        public void set_Site(){} // RVA: 0x7ffaa8660d80
        public void add_Disposed(){} // RVA: 0x7ffaa8660d80
        public void remove_Disposed(){} // RVA: 0x7ffaa8660d80
    }

    public class ISite
    {
        // ── Original Methods ──
        public void get_Component(){} // RVA: 0x7ffaa86491d0
        public void get_Container(){} // RVA: 0x7ffaa86491d0
        public void get_DesignMode(){} // RVA: 0x7ffaa864a040
        public void get_Name(){} // RVA: 0x7ffaa86491d0
        public void set_Name(){} // RVA: 0x7ffaa8660d80
    }

    public class ISynchronizeInvoke
    {
        // ── Original Methods ──
        public void get_InvokeRequired(){} // RVA: 0x7ffaa864a040
        public void EndInvoke(){} // RVA: 0x7ffaa8649280
        public void Invoke(){} // RVA: 0x7ffaa865aa30
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaa865aa30
    }

}