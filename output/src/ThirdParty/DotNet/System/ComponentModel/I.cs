// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 37
// Methods: 152

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class IBindingList
    {
        // ── Methods ──
        public void get_AllowNew(){} // RVA: 0xDBE0
        public void AddNew(){} // RVA: 0xCD60
        public void get_AllowEdit(){} // RVA: 0xDBE0
        public void get_AllowRemove(){} // RVA: 0xDBE0
        public void get_SupportsChangeNotification(){} // RVA: 0xDBE0
        public void get_SupportsSearching(){} // RVA: 0xDBE0
        public void get_SupportsSorting(){} // RVA: 0xDBE0
        public void get_IsSorted(){} // RVA: 0xDBE0
        public void get_SortProperty(){} // RVA: 0xCD60
        public void get_SortDirection(){} // RVA: 0xD840
        public void add_ListChanged(){} // RVA: 0x24B10
        public void remove_ListChanged(){} // RVA: 0x24B10
        public void AddIndex(){} // RVA: 0x24B10
        public void ApplySort(){} // RVA: 0x2BAA0
        public void Find(){} // RVA: 0x17680
        public void RemoveIndex(){} // RVA: 0x24B10
        public void RemoveSort(){} // RVA: 0x24A50
    }

    public class IBindingListView
    {
        // ── Methods ──
        public void ApplySort(){} // RVA: 0x24B10
        public void get_Filter(){} // RVA: 0xCD60
        public void set_Filter(){} // RVA: 0x24B10
        public void get_SortDescriptions(){} // RVA: 0xCD60
        public void RemoveFilter(){} // RVA: 0x24A50
        public void get_SupportsAdvancedSorting(){} // RVA: 0xDBE0
        public void get_SupportsFiltering(){} // RVA: 0xDBE0
    }

    public class ICancelAddNew
    {
        // ── Methods ──
        public void CancelNew(){} // RVA: 0x24FA0
        public void EndNew(){} // RVA: 0x24FA0
    }

    public class IChangeTracking
    {
        // ── Methods ──
        public void get_IsChanged(){} // RVA: 0xDBE0
        public void AcceptChanges(){} // RVA: 0x24A50
    }

    public class IComNativeDescriptorHandler
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0xCE10
        public void GetClassName(){} // RVA: 0xCE10
        public void GetConverter(){} // RVA: 0xCE10
        public void GetDefaultEvent(){} // RVA: 0xCE10
        public void GetDefaultProperty(){} // RVA: 0xCE10
        public void GetEditor(){} // RVA: 0x1E6A0
        public void GetName(){} // RVA: 0xCE10
        public void GetEvents(){} // RVA: 0x1E6A0 | overloaded x2
        public void GetProperties(){} // RVA: 0x1E6A0
        public void GetPropertyValue(){} // RVA: 0x1EE30 | overloaded x2
    }

    public class IComponent
    {
        // ── Methods ──
        public void get_Site(){} // RVA: 0xCD60
        public void set_Site(){} // RVA: 0x24B10
        public void add_Disposed(){} // RVA: 0x24B10
        public void remove_Disposed(){} // RVA: 0x24B10
    }

    public class IContainer
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x2DC60 | overloaded x2
        public void get_Components(){} // RVA: 0xCD60
        public void Remove(){} // RVA: 0x24B10
    }

    public class ICustomTypeDescriptor
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0xCD60
        public void GetClassName(){} // RVA: 0xCD60
        public void GetComponentName(){} // RVA: 0xCD60
        public void GetConverter(){} // RVA: 0xCD60
        public void GetDefaultEvent(){} // RVA: 0xCD60
        public void GetDefaultProperty(){} // RVA: 0xCD60
        public void GetEditor(){} // RVA: 0xCE10
        public void GetEvents(){} // RVA: 0xCE10 | overloaded x2
        public void GetProperties(){} // RVA: 0xCE10 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0xCE10
    }

    public class IDataErrorInfo
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0xCE10
        public void get_Error(){} // RVA: 0xCD60
    }

    public class IEditableObject
    {
        // ── Methods ──
        public void BeginEdit(){} // RVA: 0x24A50
        public void EndEdit(){} // RVA: 0x24A50
        public void CancelEdit(){} // RVA: 0x24A50
    }

    public class IExtenderProvider
    {
        // ── Methods ──
        public void CanExtend(){} // RVA: 0xDE40
    }

    public class IIntellisenseBuilder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0xCD60
        public void Show(){}
    }

    public class IListSource
    {
        // ── Methods ──
        public void get_ContainsListCollection(){} // RVA: 0xDBE0
        public void GetList(){} // RVA: 0xCD60
    }

    public class INestedContainer
    {
        // ── Methods ──
        public void get_Owner(){} // RVA: 0xCD60
    }

    public class INestedSite
    {
        // ── Methods ──
        public void get_FullName(){} // RVA: 0xCD60
    }

    public class INotifyDataErrorInfo
    {
        // ── Methods ──
        public void get_HasErrors(){} // RVA: 0xDBE0
        public void GetErrors(){} // RVA: 0xCE10
        public void add_ErrorsChanged(){} // RVA: 0x24B10
        public void remove_ErrorsChanged(){} // RVA: 0x24B10
    }

    public class INotifyPropertyChanged
    {
        // ── Methods ──
        public void add_PropertyChanged(){} // RVA: 0x24B10
        public void remove_PropertyChanged(){} // RVA: 0x24B10
    }

    public class INotifyPropertyChanging
    {
        // ── Methods ──
        public void add_PropertyChanging(){} // RVA: 0x24B10
        public void remove_PropertyChanging(){} // RVA: 0x24B10
    }

    public class IRaiseItemChangedEvents
    {
        // ── Methods ──
        public void get_RaisesItemChangedEvents(){} // RVA: 0xDBE0
    }

    public class IRevertibleChangeTracking
    {
        // ── Methods ──
        public void RejectChanges(){} // RVA: 0x24A50
    }

    public class ISite
    {
        // ── Methods ──
        public void get_Component(){} // RVA: 0xCD60
        public void get_Container(){} // RVA: 0xCD60
        public void get_DesignMode(){} // RVA: 0xDBE0
        public void get_Name(){} // RVA: 0xCD60
        public void set_Name(){} // RVA: 0x24B10
    }

    public class ISupportInitialize
    {
        // ── Methods ──
        public void BeginInit(){} // RVA: 0x24A50
        public void EndInit(){} // RVA: 0x24A50
    }

    public class ISupportInitializeNotification
    {
        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0xDBE0
        public void add_Initialized(){} // RVA: 0x24B10
        public void remove_Initialized(){} // RVA: 0x24B10
    }

    public class ISynchronizeInvoke
    {
        // ── Methods ──
        public void get_InvokeRequired(){} // RVA: 0xDBE0
        public void BeginInvoke(){} // RVA: 0x1E6A0
        public void EndInvoke(){} // RVA: 0xCE10
        public void Invoke(){} // RVA: 0x1E6A0
    }

    public class ITypeDescriptorContext : ڄe
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0xCD60
        public void get_Instance(){} // RVA: 0xCD60
        public void get_PropertyDescriptor(){} // RVA: 0xCD60
        public void OnComponentChanging(){} // RVA: 0xDBE0
        public void OnComponentChanged(){} // RVA: 0x24A50
    }

    public class ITypedList
    {
        // ── Methods ──
        public void GetListName(){} // RVA: 0xCE10
        public void GetItemProperties(){} // RVA: 0xCE10
    }

    public class ImmutableObjectAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
        public void get_Immutable(){} // RVA: 0x3A75E0
        public void Equals(){} // RVA: 0x6C4F160
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void IsDefaultAttribute(){} // RVA: 0x6C4F220
        public void .cctor(){} // RVA: 0x6C4F290
    }

    public class InheritanceAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0 | overloaded x2
        public void get_InheritanceLevel(){} // RVA: 0x32A5C0
        public void Equals(){} // RVA: 0x6C5F950
        public void GetHashCode(){} // RVA: 0x6C4B080
        public void IsDefaultAttribute(){} // RVA: 0x6C5F9F0
        public void ToString(){} // RVA: 0x6C5FA60
        public void .cctor(){} // RVA: 0x6C5FB90
    }

    public class InitializationEventAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_EventName(){} // RVA: 0x2F8380
    }

    public class InstallerTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void get_InstallerType(){} // RVA: 0x6C65DF0
        public void Equals(){} // RVA: 0x6C65E70
        public void GetHashCode(){} // RVA: 0x6C4B080
    }

    public class InstanceCreationEditor
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x6C65F50
        public void CreateInstance(){} // RVA: 0x1E6A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Int16Converter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x6C65F90
        public void FromString(){} // RVA: 0x6C660D0 | overloaded x2
        public void ToString(){} // RVA: 0x6C661A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Int32Converter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x6C66240
        public void FromString(){} // RVA: 0x6C66380 | overloaded x2
        public void ToString(){} // RVA: 0x6C663F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Int64Converter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x6C66530
        public void FromString(){} // RVA: 0x6C66670 | overloaded x2
        public void ToString(){} // RVA: 0x6C666E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IntSecurity
    {
        // ── Methods ──
        public void UnsafeGetFullPath(){} // RVA: 0x6C87730
    }

    public class InvalidAsynchronousStateException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C395D0 | overloaded x4
    }

    public class InvalidEnumArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5C395D0 | overloaded x5
    }

}