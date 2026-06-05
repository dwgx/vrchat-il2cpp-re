// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 37
// Methods: 152

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class IBindingList
    {
        // ── Methods ──
        public void get_AllowNew(){} // RVA: 0x7FFAF2ABDBE0
        public void AddNew(){} // RVA: 0x7FFAF2ABCD60
        public void get_AllowEdit(){} // RVA: 0x7FFAF2ABDBE0
        public void get_AllowRemove(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsChangeNotification(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsSearching(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsSorting(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsSorted(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SortProperty(){} // RVA: 0x7FFAF2ABCD60
        public void get_SortDirection(){} // RVA: 0x7FFAF2ABD840
        public void add_ListChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_ListChanged(){} // RVA: 0x7FFAF2AD4B10
        public void AddIndex(){} // RVA: 0x7FFAF2AD4B10
        public void ApplySort(){} // RVA: 0x7FFAF2ADBAA0
        public void Find(){} // RVA: 0x7FFAF2AC7680
        public void RemoveIndex(){} // RVA: 0x7FFAF2AD4B10
        public void RemoveSort(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IBindingListView
    {
        // ── Methods ──
        public void ApplySort(){} // RVA: 0x7FFAF2AD4B10
        public void get_Filter(){} // RVA: 0x7FFAF2ABCD60
        public void set_Filter(){} // RVA: 0x7FFAF2AD4B10
        public void get_SortDescriptions(){} // RVA: 0x7FFAF2ABCD60
        public void RemoveFilter(){} // RVA: 0x7FFAF2AD4A50
        public void get_SupportsAdvancedSorting(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsFiltering(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class ICancelAddNew
    {
        // ── Methods ──
        public void CancelNew(){} // RVA: 0x7FFAF2AD4FA0
        public void EndNew(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class IChangeTracking
    {
        // ── Methods ──
        public void get_IsChanged(){} // RVA: 0x7FFAF2ABDBE0
        public void AcceptChanges(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IComNativeDescriptorHandler
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAF2ABCE10
        public void GetClassName(){} // RVA: 0x7FFAF2ABCE10
        public void GetConverter(){} // RVA: 0x7FFAF2ABCE10
        public void GetDefaultEvent(){} // RVA: 0x7FFAF2ABCE10
        public void GetDefaultProperty(){} // RVA: 0x7FFAF2ABCE10
        public void GetEditor(){} // RVA: 0x7FFAF2ACE6A0
        public void GetName(){} // RVA: 0x7FFAF2ABCE10
        public void GetEvents(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFAF2ACE6A0
        public void GetPropertyValue(){} // RVA: 0x7FFAF2ACEE30 | overloaded x2
    }

    public class IComponent
    {
        // ── Methods ──
        public void get_Site(){} // RVA: 0x7FFAF2ABCD60
        public void set_Site(){} // RVA: 0x7FFAF2AD4B10
        public void add_Disposed(){} // RVA: 0x7FFAF2AD4B10
        public void remove_Disposed(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IContainer
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAF2ADDC60 | overloaded x2
        public void get_Components(){} // RVA: 0x7FFAF2ABCD60
        public void Remove(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ICustomTypeDescriptor
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAF2ABCD60
        public void GetClassName(){} // RVA: 0x7FFAF2ABCD60
        public void GetComponentName(){} // RVA: 0x7FFAF2ABCD60
        public void GetConverter(){} // RVA: 0x7FFAF2ABCD60
        public void GetDefaultEvent(){} // RVA: 0x7FFAF2ABCD60
        public void GetDefaultProperty(){} // RVA: 0x7FFAF2ABCD60
        public void GetEditor(){} // RVA: 0x7FFAF2ABCE10
        public void GetEvents(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFAF2ABCE10 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0x7FFAF2ABCE10
    }

    public class IDataErrorInfo
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAF2ABCE10
        public void get_Error(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IEditableObject
    {
        // ── Methods ──
        public void BeginEdit(){} // RVA: 0x7FFAF2AD4A50
        public void EndEdit(){} // RVA: 0x7FFAF2AD4A50
        public void CancelEdit(){} // RVA: 0x7FFAF2AD4A50
    }

    public class IExtenderProvider
    {
        // ── Methods ──
        public void CanExtend(){} // RVA: 0x7FFAF2ABDE40
    }

    public class IIntellisenseBuilder
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void Show(){}
    }

    public class IListSource
    {
        // ── Methods ──
        public void get_ContainsListCollection(){} // RVA: 0x7FFAF2ABDBE0
        public void GetList(){} // RVA: 0x7FFAF2ABCD60
    }

    public class INestedContainer
    {
        // ── Methods ──
        public void get_Owner(){} // RVA: 0x7FFAF2ABCD60
    }

    public class INestedSite
    {
        // ── Methods ──
        public void get_FullName(){} // RVA: 0x7FFAF2ABCD60
    }

    public class INotifyDataErrorInfo
    {
        // ── Methods ──
        public void get_HasErrors(){} // RVA: 0x7FFAF2ABDBE0
        public void GetErrors(){} // RVA: 0x7FFAF2ABCE10
        public void add_ErrorsChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_ErrorsChanged(){} // RVA: 0x7FFAF2AD4B10
    }

    public class INotifyPropertyChanged
    {
        // ── Methods ──
        public void add_PropertyChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_PropertyChanged(){} // RVA: 0x7FFAF2AD4B10
    }

    public class INotifyPropertyChanging
    {
        // ── Methods ──
        public void add_PropertyChanging(){} // RVA: 0x7FFAF2AD4B10
        public void remove_PropertyChanging(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IRaiseItemChangedEvents
    {
        // ── Methods ──
        public void get_RaisesItemChangedEvents(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class IRevertibleChangeTracking
    {
        // ── Methods ──
        public void RejectChanges(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ISite
    {
        // ── Methods ──
        public void get_Component(){} // RVA: 0x7FFAF2ABCD60
        public void get_Container(){} // RVA: 0x7FFAF2ABCD60
        public void get_DesignMode(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Name(){} // RVA: 0x7FFAF2ABCD60
        public void set_Name(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISupportInitialize
    {
        // ── Methods ──
        public void BeginInit(){} // RVA: 0x7FFAF2AD4A50
        public void EndInit(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ISupportInitializeNotification
    {
        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFAF2ABDBE0
        public void add_Initialized(){} // RVA: 0x7FFAF2AD4B10
        public void remove_Initialized(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISynchronizeInvoke
    {
        // ── Methods ──
        public void get_InvokeRequired(){} // RVA: 0x7FFAF2ABDBE0
        public void BeginInvoke(){} // RVA: 0x7FFAF2ACE6A0
        public void EndInvoke(){} // RVA: 0x7FFAF2ABCE10
        public void Invoke(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class ITypeDescriptorContext : ڄe
    {
        // ── Methods ──
        public void get_Container(){} // RVA: 0x7FFAF2ABCD60
        public void get_Instance(){} // RVA: 0x7FFAF2ABCD60
        public void get_PropertyDescriptor(){} // RVA: 0x7FFAF2ABCD60
        public void OnComponentChanging(){} // RVA: 0x7FFAF2ABDBE0
        public void OnComponentChanged(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ITypedList
    {
        // ── Methods ──
        public void GetListName(){} // RVA: 0x7FFAF2ABCE10
        public void GetItemProperties(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ImmutableObjectAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E575F0
        public void get_Immutable(){} // RVA: 0x7FFAF2E575E0
        public void Equals(){} // RVA: 0x7FFAF96FF160
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
        public void IsDefaultAttribute(){} // RVA: 0x7FFAF96FF220
        public void .cctor(){} // RVA: 0x7FFAF96FF290
    }

    public class InheritanceAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0 | overloaded x2
        public void get_InheritanceLevel(){} // RVA: 0x7FFAF2DDA5C0
        public void Equals(){} // RVA: 0x7FFAF970F950
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
        public void IsDefaultAttribute(){} // RVA: 0x7FFAF970F9F0
        public void ToString(){} // RVA: 0x7FFAF970FA60
        public void .cctor(){} // RVA: 0x7FFAF970FB90
    }

    public class InitializationEventAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_EventName(){} // RVA: 0x7FFAF2DA8380
    }

    public class InstallerTypeAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void get_InstallerType(){} // RVA: 0x7FFAF9715DF0
        public void Equals(){} // RVA: 0x7FFAF9715E70
        public void GetHashCode(){} // RVA: 0x7FFAF96FB080
    }

    public class InstanceCreationEditor
    {
        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFAF9715F50
        public void CreateInstance(){} // RVA: 0x7FFAF2ACE6A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Int16Converter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAF9715F90
        public void FromString(){} // RVA: 0x7FFAF97160D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF97161A0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Int32Converter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAF9716240
        public void FromString(){} // RVA: 0x7FFAF9716380 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF97163F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Int64Converter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAF9716530
        public void FromString(){} // RVA: 0x7FFAF9716670 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF97166E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class IntSecurity
    {
        // ── Methods ──
        public void UnsafeGetFullPath(){} // RVA: 0x7FFAF9737730
    }

    public class InvalidAsynchronousStateException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E95D0 | overloaded x4
    }

    public class InvalidEnumArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86E95D0 | overloaded x5
    }

}