// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 37
// Methods: 135

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class IBindingList
    {
        // ── Methods ──
        public void get_AllowNew(){} // RVA: 0x87D280
        public void AddNew(){} // RVA: 0x87C0A0
        public void get_AllowEdit(){} // RVA: 0x87D280
        public void get_AllowRemove(){} // RVA: 0x87D280
        public void get_SupportsChangeNotification(){} // RVA: 0x87D280
        public void get_SupportsSearching(){} // RVA: 0x87D280
        public void get_SupportsSorting(){} // RVA: 0x87D280
        public void get_IsSorted(){} // RVA: 0x87D280
        public void get_SortProperty(){} // RVA: 0x87C0A0
        public void get_SortDirection(){} // RVA: 0x87C130
        public void add_ListChanged(){} // RVA: 0x894320
        public void remove_ListChanged(){} // RVA: 0x894320
        public void AddIndex(){} // RVA: 0x894320
        public void ApplySort(){} // RVA: 0x899290
        public void Find(){} // RVA: 0x881CA0
        public void RemoveIndex(){} // RVA: 0x894320
        public void RemoveSort(){} // RVA: 0x894290
    }

    public class IBindingListView
    {
        // ── Methods ──
        public void ApplySort(){} // RVA: 0x894320
        public void get_Filter(){} // RVA: 0x87C0A0
        public void set_Filter(){} // RVA: 0x894320
        public void get_SortDescriptions(){} // RVA: 0x87C0A0
        public void RemoveFilter(){} // RVA: 0x894290
        public void get_SupportsAdvancedSorting(){} // RVA: 0x87D280
        public void get_SupportsFiltering(){} // RVA: 0x87D280
    }

    public class ICancelAddNew
    {
        // ── Methods ──
        public void CancelNew(){} // RVA: 0x8944F0
        public void EndNew(){} // RVA: 0x8944F0
    }

    public class IChangeTracking
    {
        // ── Methods ──
        public void get_IsChanged(){} // RVA: 0x87D280
        public void AcceptChanges(){} // RVA: 0x894290
    }

    public class IComNativeDescriptorHandler
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x87C540
        public void GetClassName(){} // RVA: 0x87C540
        public void GetConverter(){} // RVA: 0x87C540
        public void GetDefaultEvent(){} // RVA: 0x87C540
        public void GetDefaultProperty(){} // RVA: 0x87C540
        public void GetEditor(){} // RVA: 0x87C5F0
        public void GetName(){} // RVA: 0x87C540
        public void GetEvents(){} // RVA: 0x87C5F0
        public void GetProperties(){} // RVA: 0x87C5F0
        public void GetPropertyValue(){} // RVA: 0x882040
    }

    public class IComponent
    {
        // ── Methods ──
        public void get_Site(){} // RVA: 0x87C0A0
        public void set_Site(){} // RVA: 0x894320
        public void add_Disposed(){} // RVA: 0x894320
        public void remove_Disposed(){} // RVA: 0x894320
    }

    public class IContainer
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x8943B0
        public void get_Components(){} // RVA: 0x87C0A0
        public void Remove(){} // RVA: 0x894320
    }

    public class ICustomTypeDescriptor
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x87C0A0
        public void GetClassName(){} // RVA: 0x87C0A0
        public void GetComponentName(){} // RVA: 0x87C0A0
        public void GetConverter(){} // RVA: 0x87C0A0
        public void GetDefaultEvent(){} // RVA: 0x87C0A0
        public void GetDefaultProperty(){} // RVA: 0x87C0A0
        public void GetEditor(){} // RVA: 0x87C540
        public void GetEvents(){} // RVA: 0x87C540
        public void GetProperties(){} // RVA: 0x87C540
        public void GetPropertyOwner(){} // RVA: 0x87C540
    }

    public class IDataErrorInfo
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x87C540
        public void get_Error(){} // RVA: 0x87C0A0
    }

    public class IEditableObject
    {
        // ── Methods ──
        public void BeginEdit(){} // RVA: 0x894290
        public void EndEdit(){} // RVA: 0x894290
        public void CancelEdit(){} // RVA: 0x894290
    }

    public class IExtenderProvider
    {
        // ── Methods ──
        public void CanExtend(){} // RVA: 0x87D350
    }

    public class IIntellisenseBuilder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void Show(){} // RVA: 0x87D710
    }

    public class IListSource
    {
        // ── Methods ──
        public void get_ContainsListCollection(){} // RVA: 0x87D280
        public void GetList(){} // RVA: 0x87C0A0
    }

    public class INestedContainer
    {
        // ── Methods ──
        public void get_Owner(){} // RVA: 0x87C0A0
    }

    public class INestedSite
    {
        // ── Methods ──
        public void get_FullName(){} // RVA: 0x87C0A0
    }

    public class INotifyDataErrorInfo
    {
        // ── Methods ──
        public void get_HasErrors(){} // RVA: 0x87D280
        public void GetErrors(){} // RVA: 0x87C540
        public void add_ErrorsChanged(){} // RVA: 0x894320
        public void remove_ErrorsChanged(){} // RVA: 0x894320
    }

    public class INotifyPropertyChanged
    {
        // ── Methods ──
        public void add_PropertyChanged(){} // RVA: 0x894320
        public void remove_PropertyChanged(){} // RVA: 0x894320
    }

    public class INotifyPropertyChanging
    {
        // ── Methods ──
        public void add_PropertyChanging(){} // RVA: 0x894320
        public void remove_PropertyChanging(){} // RVA: 0x894320
    }

    public class IRaiseItemChangedEvents
    {
        // ── Methods ──
        public void get_RaisesItemChangedEvents(){} // RVA: 0x87D280
    }

    public class IRevertibleChangeTracking
    {
        // ── Methods ──
        public void RejectChanges(){} // RVA: 0x894290
    }

    public class ISite
    {
        // ── Methods ──
        public void get_Component(){} // RVA: 0x87C0A0
        public void get_Container(){} // RVA: 0x87C0A0
        public void get_DesignMode(){} // RVA: 0x87D280
        public void get_Name(){} // RVA: 0x87C0A0
        public void set_Name(){} // RVA: 0x894320
    }

    public class ISupportInitialize
    {
        // ── Methods ──
        public void BeginInit(){} // RVA: 0x894290
        public void EndInit(){} // RVA: 0x894290
    }

    public class ISupportInitializeNotification
    {
        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x87D280
        public void add_Initialized(){} // RVA: 0x894320
        public void remove_Initialized(){} // RVA: 0x894320
    }

    public class ISynchronizeInvoke
    {
        // ── Methods ──
        public void get_InvokeRequired(){} // RVA: 0x87D280
        public void BeginInvoke(){} // RVA: 0x87C5F0
        public void EndInvoke(){} // RVA: 0x87C540
        public void Invoke(){} // RVA: 0x87C5F0
    }

    public class ITypeDescriptorContext
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0x87C0A0
        public void get_Instance(){} // RVA: 0x87C0A0
        public void get_PropertyDescriptor(){} // RVA: 0x87C0A0
        public void OnComponentChanging(){} // RVA: 0x87D280
        public void OnComponentChanged(){} // RVA: 0x894290
    }

    public class ITypedList
    {
        // ── Methods ──
        public void GetListName(){} // RVA: 0x87C540
        public void GetItemProperties(){} // RVA: 0x87C540
    }

    public class ImmutableObjectAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _immutable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_Immutable(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76AFBC0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76AFC80
        public void .cctor(){} // RVA: 0x76AFCF0
    }

    public class InheritanceAttribute : Attribute
    {
        public object Inherited;
        public object InheritedReadOnly;
        public object NotInherited;
        public object Default;
        public object _inheritanceLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void get_InheritanceLevel(){} // RVA: 0xB8F8F0
        public void Equals(){} // RVA: 0x76BF8D0
        public void GetHashCode(){} // RVA: 0x76ABD60
        public void IsDefaultAttribute(){} // RVA: 0x76BF970
        public void ToString(){} // RVA: 0x76BF9E0
        public void .cctor(){} // RVA: 0x76BFAE0
    }

    public class InitializationEventAttribute : Attribute
    {
        public object _eventName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_EventName(){} // RVA: 0xB5DBF0
    }

    public class InstallerTypeAttribute : Attribute
    {
        public object _typeName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_InstallerType(){} // RVA: 0x76C5C10
        public void Equals(){} // RVA: 0x76C5C80
        public void GetHashCode(){} // RVA: 0x76ABD60
    }

    public class InstanceCreationEditor : Object
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x76C5D40
        public void CreateInstance(){} // RVA: 0x87C5F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Int16Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x76C5D80
        public void FromString(){} // RVA: 0x76C5E60
        public void ToString(){} // RVA: 0x76C5F10
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Int32Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x76C5FA0
        public void FromString(){} // RVA: 0x76C6080
        public void ToString(){} // RVA: 0x76C60B0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Int64Converter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x71348B0
        public void FromString(){} // RVA: 0x76C6250
        public void ToString(){} // RVA: 0x76C6280
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IntSecurity : Object
    {
        // ── Methods ──
        public void UnsafeGetFullPath(){} // RVA: 0x76E68C0
    }

    public class InvalidAsynchronousStateException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B19F0
    }

    public class InvalidEnumArgumentException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x66B19F0
    }

}