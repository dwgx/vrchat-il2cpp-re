// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 37
// Methods: 152

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class IBindingList
    {
        // ── Methods ──
        public void get_AllowNew(){} // RVA: 0x7FFE80E2F150
        public void AddNew(){} // RVA: 0x7FFE80E2E2E0
        public void get_AllowEdit(){} // RVA: 0x7FFE80E2F150
        public void get_AllowRemove(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsChangeNotification(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsSearching(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsSorting(){} // RVA: 0x7FFE80E2F150
        public void get_IsSorted(){} // RVA: 0x7FFE80E2F150
        public void get_SortProperty(){} // RVA: 0x7FFE80E2E2E0
        public void get_SortDirection(){} // RVA: 0x7FFE80E2EDB0
        public void add_ListChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_ListChanged(){} // RVA: 0x7FFE80E460A0
        public void AddIndex(){} // RVA: 0x7FFE80E460A0
        public void ApplySort(){} // RVA: 0x7FFE80E4D070
        public void Find(){} // RVA: 0x7FFE80E38BF0
        public void RemoveIndex(){} // RVA: 0x7FFE80E460A0
        public void RemoveSort(){} // RVA: 0x7FFE80E45FE0
    }

    public class IBindingListView
    {
        // ── Methods ──
        public void ApplySort(){} // RVA: 0x7FFE80E460A0
        public void get_Filter(){} // RVA: 0x7FFE80E2E2E0
        public void set_Filter(){} // RVA: 0x7FFE80E460A0
        public void get_SortDescriptions(){} // RVA: 0x7FFE80E2E2E0
        public void RemoveFilter(){} // RVA: 0x7FFE80E45FE0
        public void get_SupportsAdvancedSorting(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsFiltering(){} // RVA: 0x7FFE80E2F150
    }

    public class ICancelAddNew
    {
        // ── Methods ──
        public void CancelNew(){} // RVA: 0x7FFE80E46530
        public void EndNew(){} // RVA: 0x7FFE80E46530
    }

    public class IChangeTracking
    {
        // ── Methods ──
        public void get_IsChanged(){} // RVA: 0x7FFE80E2F150
        public void AcceptChanges(){} // RVA: 0x7FFE80E45FE0
    }

    public class IComNativeDescriptorHandler
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFE80E2E390
        public void GetClassName(){} // RVA: 0x7FFE80E2E390
        public void GetConverter(){} // RVA: 0x7FFE80E2E390
        public void GetDefaultEvent(){} // RVA: 0x7FFE80E2E390
        public void GetDefaultProperty(){} // RVA: 0x7FFE80E2E390
        public void GetEditor(){} // RVA: 0x7FFE80E3FC10
        public void GetName(){} // RVA: 0x7FFE80E2E390
        public void GetEvents(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFE80E3FC10
        public void GetPropertyValue(){} // RVA: 0x7FFE80E403A0 | overloaded x2
    }

    public class IComponent
    {
        // ── Methods ──
        public void get_Site(){} // RVA: 0x7FFE80E2E2E0
        public void set_Site(){} // RVA: 0x7FFE80E460A0
        public void add_Disposed(){} // RVA: 0x7FFE80E460A0
        public void remove_Disposed(){} // RVA: 0x7FFE80E460A0
    }

    public class IContainer
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE80E4F230 | overloaded x2
        public void get_Components(){} // RVA: 0x7FFE80E2E2E0
        public void Remove(){} // RVA: 0x7FFE80E460A0
    }

    public class ICustomTypeDescriptor
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFE80E2E2E0
        public void GetClassName(){} // RVA: 0x7FFE80E2E2E0
        public void GetComponentName(){} // RVA: 0x7FFE80E2E2E0
        public void GetConverter(){} // RVA: 0x7FFE80E2E2E0
        public void GetDefaultEvent(){} // RVA: 0x7FFE80E2E2E0
        public void GetDefaultProperty(){} // RVA: 0x7FFE80E2E2E0
        public void GetEditor(){} // RVA: 0x7FFE80E2E390
        public void GetEvents(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFE80E2E390 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0x7FFE80E2E390
    }

    public class IDataErrorInfo
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE80E2E390
        public void get_Error(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEditableObject
    {
        // ── Methods ──
        public void BeginEdit(){} // RVA: 0x7FFE80E45FE0
        public void EndEdit(){} // RVA: 0x7FFE80E45FE0
        public void CancelEdit(){} // RVA: 0x7FFE80E45FE0
    }

    public class IExtenderProvider
    {
        // ── Methods ──
        public void CanExtend(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IIntellisenseBuilder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void Show(){}
    }

    public class IListSource
    {
        // ── Methods ──
        public void get_ContainsListCollection(){} // RVA: 0x7FFE80E2F150
        public void GetList(){} // RVA: 0x7FFE80E2E2E0
    }

    public class INestedContainer
    {
        // ── Methods ──
        public void get_Owner(){} // RVA: 0x7FFE80E2E2E0
    }

    public class INestedSite
    {
        // ── Methods ──
        public void get_FullName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class INotifyDataErrorInfo
    {
        // ── Methods ──
        public void get_HasErrors(){} // RVA: 0x7FFE80E2F150
        public void GetErrors(){} // RVA: 0x7FFE80E2E390
        public void add_ErrorsChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_ErrorsChanged(){} // RVA: 0x7FFE80E460A0
    }

    public class INotifyPropertyChanged
    {
        // ── Methods ──
        public void add_PropertyChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_PropertyChanged(){} // RVA: 0x7FFE80E460A0
    }

    public class INotifyPropertyChanging
    {
        // ── Methods ──
        public void add_PropertyChanging(){} // RVA: 0x7FFE80E460A0
        public void remove_PropertyChanging(){} // RVA: 0x7FFE80E460A0
    }

    public class IRaiseItemChangedEvents
    {
        // ── Methods ──
        public void get_RaisesItemChangedEvents(){} // RVA: 0x7FFE80E2F150
    }

    public class IRevertibleChangeTracking
    {
        // ── Methods ──
        public void RejectChanges(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISite
    {
        // ── Methods ──
        public void get_Component(){} // RVA: 0x7FFE80E2E2E0
        public void get_Container(){} // RVA: 0x7FFE80E2E2E0
        public void get_DesignMode(){} // RVA: 0x7FFE80E2F150
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void set_Name(){} // RVA: 0x7FFE80E460A0
    }

    public class ISupportInitialize
    {
        // ── Methods ──
        public void BeginInit(){} // RVA: 0x7FFE80E45FE0
        public void EndInit(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISupportInitializeNotification
    {
        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFE80E2F150
        public void add_Initialized(){} // RVA: 0x7FFE80E460A0
        public void remove_Initialized(){} // RVA: 0x7FFE80E460A0
    }

    public class ISynchronizeInvoke
    {
        // ── Methods ──
        public void get_InvokeRequired(){} // RVA: 0x7FFE80E2F150
        public void BeginInvoke(){} // RVA: 0x7FFE80E3FC10
        public void EndInvoke(){} // RVA: 0x7FFE80E2E390
        public void Invoke(){} // RVA: 0x7FFE80E3FC10
    }

    public class ITypeDescriptorContext
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0x7FFE80E2E2E0
        public void get_Instance(){} // RVA: 0x7FFE80E2E2E0
        public void get_PropertyDescriptor(){} // RVA: 0x7FFE80E2E2E0
        public void OnComponentChanging(){} // RVA: 0x7FFE80E2F150
        public void OnComponentChanged(){} // RVA: 0x7FFE80E45FE0
    }

    public class ITypedList
    {
        // ── Methods ──
        public void GetListName(){} // RVA: 0x7FFE80E2E390
        public void GetItemProperties(){} // RVA: 0x7FFE80E2E390
    }

    public class ImmutableObjectAttribute : Attribute
    {
        public System.ComponentModel.ImmutableObjectAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_Immutable(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE87790010
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877900D0
        public void .cctor(){} // RVA: 0x7FFE87790140
    }

    public class InheritanceAttribute : Attribute
    {
        public System.ComponentModel.InheritanceAttribute Inherited;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0 | overloaded x2
        public void get_InheritanceLevel(){} // RVA: 0x7FFE811485C0
        public void Equals(){} // RVA: 0x7FFE877A0800
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
        public void IsDefaultAttribute(){} // RVA: 0x7FFE877A08A0
        public void ToString(){} // RVA: 0x7FFE877A0910
        public void .cctor(){} // RVA: 0x7FFE877A0A40
    }

    public class InitializationEventAttribute : Attribute
    {
        public string _eventName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_EventName(){} // RVA: 0x7FFE81116380
    }

    public class InstallerTypeAttribute : Attribute
    {
        public string _typeName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void get_InstallerType(){} // RVA: 0x7FFE877A6CA0
        public void Equals(){} // RVA: 0x7FFE877A6D20
        public void GetHashCode(){} // RVA: 0x7FFE8778BF30
    }

    public class InstanceCreationEditor : Object
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFE877A6E00
        public void CreateInstance(){} // RVA: 0x7FFE80E3FC10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Int16Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFE877A6E40
        public void FromString(){} // RVA: 0x7FFE877A6F80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE877A7050
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Int32Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFE877A70F0
        public void FromString(){} // RVA: 0x7FFE877A7230 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE877A72A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Int64Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFE877A73E0
        public void FromString(){} // RVA: 0x7FFE877A7520 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE877A7590
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IntSecurity : Object
    {
        // ── Methods ──
        public void UnsafeGetFullPath(){} // RVA: 0x7FFE877C85E0
    }

    public class InvalidAsynchronousStateException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677A420 | overloaded x4
    }

    public class InvalidEnumArgumentException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8677A420 | overloaded x5
    }

}