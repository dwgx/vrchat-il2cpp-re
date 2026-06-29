// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 37
// Methods: 135

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class IBindingList
    {
        // ── Methods ──
        public void get_AllowNew(){} // RVA: 0x7A7E01900
        public void AddNew(){} // RVA: 0x7A7E00680
        public void get_AllowEdit(){} // RVA: 0x7A7E01900
        public void get_AllowRemove(){} // RVA: 0x7A7E01900
        public void get_SupportsChangeNotification(){} // RVA: 0x7A7E01900
        public void get_SupportsSearching(){} // RVA: 0x7A7E01900
        public void get_SupportsSorting(){} // RVA: 0x7A7E01900
        public void get_IsSorted(){} // RVA: 0x7A7E01900
        public void get_SortProperty(){} // RVA: 0x7A7E00680
        public void get_SortDirection(){} // RVA: 0x7A7E00710
        public void add_ListChanged(){} // RVA: 0x7A7E18800
        public void remove_ListChanged(){} // RVA: 0x7A7E18800
        public void AddIndex(){} // RVA: 0x7A7E18800
        public void ApplySort(){} // RVA: 0x7A7E1D590
        public void Find(){} // RVA: 0x7A7E06320
        public void RemoveIndex(){} // RVA: 0x7A7E18800
        public void RemoveSort(){} // RVA: 0x7A7E18770
    }

    public class IBindingListView
    {
        // ── Methods ──
        public void ApplySort(){} // RVA: 0x7A7E18800
        public void get_Filter(){} // RVA: 0x7A7E00680
        public void set_Filter(){} // RVA: 0x7A7E18800
        public void get_SortDescriptions(){} // RVA: 0x7A7E00680
        public void RemoveFilter(){} // RVA: 0x7A7E18770
        public void get_SupportsAdvancedSorting(){} // RVA: 0x7A7E01900
        public void get_SupportsFiltering(){} // RVA: 0x7A7E01900
    }

    public class ICancelAddNew
    {
        // ── Methods ──
        public void CancelNew(){} // RVA: 0x7A7E189D0
        public void EndNew(){} // RVA: 0x7A7E189D0
    }

    public class IChangeTracking
    {
        // ── Methods ──
        public void get_IsChanged(){} // RVA: 0x7A7E01900
        public void AcceptChanges(){} // RVA: 0x7A7E18770
    }

    public class IComNativeDescriptorHandler
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7A7E00B20
        public void GetClassName(){} // RVA: 0x7A7E00B20
        public void GetConverter(){} // RVA: 0x7A7E00B20
        public void GetDefaultEvent(){} // RVA: 0x7A7E00B20
        public void GetDefaultProperty(){} // RVA: 0x7A7E00B20
        public void GetEditor(){} // RVA: 0x7A7E00BD0
        public void GetName(){} // RVA: 0x7A7E00B20
        public void GetEvents(){} // RVA: 0x7A7E00BD0
        public void GetProperties(){} // RVA: 0x7A7E00BD0
        public void GetPropertyValue(){} // RVA: 0x7A7E066C0
    }

    public class IComponent
    {
        // ── Methods ──
        public void get_Site(){} // RVA: 0x7A7E00680
        public void set_Site(){} // RVA: 0x7A7E18800
        public void add_Disposed(){} // RVA: 0x7A7E18800
        public void remove_Disposed(){} // RVA: 0x7A7E18800
    }

    public class IContainer
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7A7E18890
        public void get_Components(){} // RVA: 0x7A7E00680
        public void Remove(){} // RVA: 0x7A7E18800
    }

    public class ICustomTypeDescriptor
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7A7E00680
        public void GetClassName(){} // RVA: 0x7A7E00680
        public void GetComponentName(){} // RVA: 0x7A7E00680
        public void GetConverter(){} // RVA: 0x7A7E00680
        public void GetDefaultEvent(){} // RVA: 0x7A7E00680
        public void GetDefaultProperty(){} // RVA: 0x7A7E00680
        public void GetEditor(){} // RVA: 0x7A7E00B20
        public void GetEvents(){} // RVA: 0x7A7E00B20
        public void GetProperties(){} // RVA: 0x7A7E00B20
        public void GetPropertyOwner(){} // RVA: 0x7A7E00B20
    }

    public class IDataErrorInfo
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7A7E00B20
        public void get_Error(){} // RVA: 0x7A7E00680
    }

    public class IEditableObject
    {
        // ── Methods ──
        public void BeginEdit(){} // RVA: 0x7A7E18770
        public void EndEdit(){} // RVA: 0x7A7E18770
        public void CancelEdit(){} // RVA: 0x7A7E18770
    }

    public class IExtenderProvider
    {
        // ── Methods ──
        public void CanExtend(){} // RVA: 0x7A7E019D0
    }

    public class IIntellisenseBuilder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void Show(){} // RVA: 0x7A7E01D90
    }

    public class IListSource
    {
        // ── Methods ──
        public void get_ContainsListCollection(){} // RVA: 0x7A7E01900
        public void GetList(){} // RVA: 0x7A7E00680
    }

    public class INestedContainer
    {
        // ── Methods ──
        public void get_Owner(){} // RVA: 0x7A7E00680
    }

    public class INestedSite
    {
        // ── Methods ──
        public void get_FullName(){} // RVA: 0x7A7E00680
    }

    public class INotifyDataErrorInfo
    {
        // ── Methods ──
        public void get_HasErrors(){} // RVA: 0x7A7E01900
        public void GetErrors(){} // RVA: 0x7A7E00B20
        public void add_ErrorsChanged(){} // RVA: 0x7A7E18800
        public void remove_ErrorsChanged(){} // RVA: 0x7A7E18800
    }

    public class INotifyPropertyChanged
    {
        // ── Methods ──
        public void add_PropertyChanged(){} // RVA: 0x7A7E18800
        public void remove_PropertyChanged(){} // RVA: 0x7A7E18800
    }

    public class INotifyPropertyChanging
    {
        // ── Methods ──
        public void add_PropertyChanging(){} // RVA: 0x7A7E18800
        public void remove_PropertyChanging(){} // RVA: 0x7A7E18800
    }

    public class IRaiseItemChangedEvents
    {
        // ── Methods ──
        public void get_RaisesItemChangedEvents(){} // RVA: 0x7A7E01900
    }

    public class IRevertibleChangeTracking
    {
        // ── Methods ──
        public void RejectChanges(){} // RVA: 0x7A7E18770
    }

    public class ISite
    {
        // ── Methods ──
        public void get_Component(){} // RVA: 0x7A7E00680
        public void get_Container(){} // RVA: 0x7A7E00680
        public void get_DesignMode(){} // RVA: 0x7A7E01900
        public void get_Name(){} // RVA: 0x7A7E00680
        public void set_Name(){} // RVA: 0x7A7E18800
    }

    public class ISupportInitialize
    {
        // ── Methods ──
        public void BeginInit(){} // RVA: 0x7A7E18770
        public void EndInit(){} // RVA: 0x7A7E18770
    }

    public class ISupportInitializeNotification
    {
        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7A7E01900
        public void add_Initialized(){} // RVA: 0x7A7E18800
        public void remove_Initialized(){} // RVA: 0x7A7E18800
    }

    public class ISynchronizeInvoke
    {
        // ── Methods ──
        public void get_InvokeRequired(){} // RVA: 0x7A7E01900
        public void BeginInvoke(){} // RVA: 0x7A7E00BD0
        public void EndInvoke(){} // RVA: 0x7A7E00B20
        public void Invoke(){} // RVA: 0x7A7E00BD0
    }

    public class ITypeDescriptorContext
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0x7A7E00680
        public void get_Instance(){} // RVA: 0x7A7E00680
        public void get_PropertyDescriptor(){} // RVA: 0x7A7E00680
        public void OnComponentChanging(){} // RVA: 0x7A7E01900
        public void OnComponentChanged(){} // RVA: 0x7A7E18770
    }

    public class ITypedList
    {
        // ── Methods ──
        public void GetListName(){} // RVA: 0x7A7E00B20
        public void GetItemProperties(){} // RVA: 0x7A7E00B20
    }

    public class ImmutableObjectAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
        public void get_Immutable(){} // RVA: 0x7A81A2200
        public void Equals(){} // RVA: 0x7AEA3E370
        public void GetHashCode(){} // RVA: 0x7AEA3A270
        public void IsDefaultAttribute(){} // RVA: 0x7AEA3E430
        public void .cctor(){} // RVA: 0x7AEA3E4A0
    }

    public class InheritanceAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void get_InheritanceLevel(){} // RVA: 0x7A8124910
        public void Equals(){} // RVA: 0x7AEA4EB10
        public void GetHashCode(){} // RVA: 0x7AEA3A270
        public void IsDefaultAttribute(){} // RVA: 0x7AEA4EBB0
        public void ToString(){} // RVA: 0x7AEA4EC20
        public void .cctor(){} // RVA: 0x7AEA4ED50
    }

    public class InitializationEventAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_EventName(){} // RVA: 0x7A80F2570
    }

    public class InstallerTypeAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_InstallerType(){} // RVA: 0x7AEA550F0
        public void Equals(){} // RVA: 0x7AEA55170
        public void GetHashCode(){} // RVA: 0x7AEA3A270
    }

    public class InstanceCreationEditor : Object
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7AEA55230
        public void CreateInstance(){} // RVA: 0x7A7E00BD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Int16Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7AEA55270
        public void FromString(){} // RVA: 0x7AEA553B0
        public void ToString(){} // RVA: 0x7AEA55480
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Int32Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7AEA55520
        public void FromString(){} // RVA: 0x7AEA55660
        public void ToString(){} // RVA: 0x7AEA556D0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Int64Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7AEA55810
        public void FromString(){} // RVA: 0x7AEA55950
        public void ToString(){} // RVA: 0x7AEA559C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IntSecurity : Object
    {
        // ── Methods ──
        public void UnsafeGetFullPath(){} // RVA: 0x7AEA77030
    }

    public class InvalidAsynchronousStateException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA27610
    }

    public class InvalidEnumArgumentException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADA27610
    }

}