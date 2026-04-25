// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 37
// Methods: 152

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class IBindingList
    {
        public object AllowNew;
        public object AllowEdit;
        public object AllowRemove;
        public object SupportsChangeNotification;
        public object SupportsSearching;
        public object SupportsSorting;
        public object IsSorted;
        public object SortProperty;
        public object SortDirection;

        // ── Methods ──
        public void get_AllowNew(){} // RVA: 0x7FFAC2C59D00
        public void AddNew(){} // RVA: 0x7FFAC2C58E90
        public void get_AllowEdit(){} // RVA: 0x7FFAC2C59D00
        public void get_AllowRemove(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsChangeNotification(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsSearching(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsSorting(){} // RVA: 0x7FFAC2C59D00
        public void get_IsSorted(){} // RVA: 0x7FFAC2C59D00
        public void get_SortProperty(){} // RVA: 0x7FFAC2C58E90
        public void get_SortDirection(){} // RVA: 0x7FFAC2C59960
        public void add_ListChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_ListChanged(){} // RVA: 0x7FFAC2C70A40
        public void AddIndex(){} // RVA: 0x7FFAC2C70A40
        public void ApplySort(){} // RVA: 0x7FFAC2C77970
        public void Find(){} // RVA: 0x7FFAC2C637A0
        public void RemoveIndex(){} // RVA: 0x7FFAC2C70A40
        public void RemoveSort(){} // RVA: 0x7FFAC2C70980
    }

    public class IBindingListView
    {
        public object Filter;
        public object SortDescriptions;
        public object SupportsAdvancedSorting;
        public object SupportsFiltering;

        // ── Methods ──
        public void ApplySort(){} // RVA: 0x7FFAC2C70A40
        public void get_Filter(){} // RVA: 0x7FFAC2C58E90
        public void set_Filter(){} // RVA: 0x7FFAC2C70A40
        public void get_SortDescriptions(){} // RVA: 0x7FFAC2C58E90
        public void RemoveFilter(){} // RVA: 0x7FFAC2C70980
        public void get_SupportsAdvancedSorting(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsFiltering(){} // RVA: 0x7FFAC2C59D00
    }

    public class ICancelAddNew
    {
        // ── Methods ──
        public void CancelNew(){} // RVA: 0x7FFAC2C70ED0
        public void EndNew(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IChangeTracking
    {
        public object IsChanged;

        // ── Methods ──
        public void get_IsChanged(){} // RVA: 0x7FFAC2C59D00
        public void AcceptChanges(){} // RVA: 0x7FFAC2C70980
    }

    public class IComNativeDescriptorHandler
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAC2C58F40
        public void GetClassName(){} // RVA: 0x7FFAC2C58F40
        public void GetConverter(){} // RVA: 0x7FFAC2C58F40
        public void GetDefaultEvent(){} // RVA: 0x7FFAC2C58F40
        public void GetDefaultProperty(){} // RVA: 0x7FFAC2C58F40
        public void GetEditor(){} // RVA: 0x7FFAC2C6A6F0
        public void GetName(){} // RVA: 0x7FFAC2C58F40
        public void GetEvents(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFAC2C6A6F0
        public void GetPropertyValue(){} // RVA: 0x7FFAC2C6AE80 | overloaded x2
    }

    public class IComponent
    {
        public object Site;

        // ── Methods ──
        public void get_Site(){} // RVA: 0x7FFAC2C58E90
        public void set_Site(){} // RVA: 0x7FFAC2C70A40
        public void add_Disposed(){} // RVA: 0x7FFAC2C70A40
        public void remove_Disposed(){} // RVA: 0x7FFAC2C70A40
    }

    public class IContainer
    {
        public object Components;

        // ── Methods ──
        public void Add(){} // RVA: 0x7FFAC2C79B30 | overloaded x2
        public void get_Components(){} // RVA: 0x7FFAC2C58E90
        public void Remove(){} // RVA: 0x7FFAC2C70A40
    }

    public class ICustomTypeDescriptor
    {
        // ── Methods ──
        public void GetAttributes(){} // RVA: 0x7FFAC2C58E90
        public void GetClassName(){} // RVA: 0x7FFAC2C58E90
        public void GetComponentName(){} // RVA: 0x7FFAC2C58E90
        public void GetConverter(){} // RVA: 0x7FFAC2C58E90
        public void GetDefaultEvent(){} // RVA: 0x7FFAC2C58E90
        public void GetDefaultProperty(){} // RVA: 0x7FFAC2C58E90
        public void GetEditor(){} // RVA: 0x7FFAC2C58F40
        public void GetEvents(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetProperties(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
        public void GetPropertyOwner(){} // RVA: 0x7FFAC2C58F40
    }

    public class IDataErrorInfo
    {
        public object Item;
        public object Error;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC2C58F40
        public void get_Error(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEditableObject
    {
        // ── Methods ──
        public void BeginEdit(){} // RVA: 0x7FFAC2C70980
        public void EndEdit(){} // RVA: 0x7FFAC2C70980
        public void CancelEdit(){} // RVA: 0x7FFAC2C70980
    }

    public class IExtenderProvider
    {
        // ── Methods ──
        public void CanExtend(){} // RVA: 0x7FFAC2C59F60
    }

    public class IIntellisenseBuilder
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void Show(){}
    }

    public class IListSource
    {
        public object ContainsListCollection;

        // ── Methods ──
        public void get_ContainsListCollection(){} // RVA: 0x7FFAC2C59D00
        public void GetList(){} // RVA: 0x7FFAC2C58E90
    }

    public class INestedContainer
    {
        public object Owner;

        // ── Methods ──
        public void get_Owner(){} // RVA: 0x7FFAC2C58E90
    }

    public class INestedSite
    {
        public object FullName;

        // ── Methods ──
        public void get_FullName(){} // RVA: 0x7FFAC2C58E90
    }

    public class INotifyDataErrorInfo
    {
        public object HasErrors;

        // ── Methods ──
        public void get_HasErrors(){} // RVA: 0x7FFAC2C59D00
        public void GetErrors(){} // RVA: 0x7FFAC2C58F40
        public void add_ErrorsChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_ErrorsChanged(){} // RVA: 0x7FFAC2C70A40
    }

    public class INotifyPropertyChanged
    {
        // ── Methods ──
        public void add_PropertyChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_PropertyChanged(){} // RVA: 0x7FFAC2C70A40
    }

    public class INotifyPropertyChanging
    {
        // ── Methods ──
        public void add_PropertyChanging(){} // RVA: 0x7FFAC2C70A40
        public void remove_PropertyChanging(){} // RVA: 0x7FFAC2C70A40
    }

    public class IRaiseItemChangedEvents
    {
        public object RaisesItemChangedEvents;

        // ── Methods ──
        public void get_RaisesItemChangedEvents(){} // RVA: 0x7FFAC2C59D00
    }

    public class IRevertibleChangeTracking
    {
        // ── Methods ──
        public void RejectChanges(){} // RVA: 0x7FFAC2C70980
    }

    public class ISite
    {
        public object Component;
        public object Container;
        public object DesignMode;
        public object Name;

        // ── Methods ──
        public void get_Component(){} // RVA: 0x7FFAC2C58E90
        public void get_Container(){} // RVA: 0x7FFAC2C58E90
        public void get_DesignMode(){} // RVA: 0x7FFAC2C59D00
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void set_Name(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISupportInitialize
    {
        // ── Methods ──
        public void BeginInit(){} // RVA: 0x7FFAC2C70980
        public void EndInit(){} // RVA: 0x7FFAC2C70980
    }

    public class ISupportInitializeNotification
    {
        public object IsInitialized;

        // ── Methods ──
        public void get_IsInitialized(){} // RVA: 0x7FFAC2C59D00
        public void add_Initialized(){} // RVA: 0x7FFAC2C70A40
        public void remove_Initialized(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISynchronizeInvoke
    {
        public object InvokeRequired;

        // ── Methods ──
        public void get_InvokeRequired(){} // RVA: 0x7FFAC2C59D00
        public void BeginInvoke(){} // RVA: 0x7FFAC2C6A6F0
        public void EndInvoke(){} // RVA: 0x7FFAC2C58F40
        public void Invoke(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ITypeDescriptorContext
    {
        public object Container;
        public object Instance;
        public object PropertyDescriptor;

        // ── Methods ──
        public void get_Container(){} // RVA: 0x7FFAC2C58E90
        public void get_Instance(){} // RVA: 0x7FFAC2C58E90
        public void get_PropertyDescriptor(){} // RVA: 0x7FFAC2C58E90
        public void OnComponentChanging(){} // RVA: 0x7FFAC2C59D00
        public void OnComponentChanged(){} // RVA: 0x7FFAC2C70980
    }

    public class ITypedList
    {
        // ── Methods ──
        public void GetListName(){} // RVA: 0x7FFAC2C58F40
        public void GetItemProperties(){} // RVA: 0x7FFAC2C58F40
    }

    public class ImmutableObjectAttribute : Attribute
    {
        public System.ComponentModel.ImmutableObjectAttribute Immutable;
        public System.ComponentModel.ImmutableObjectAttribute No; // 0x8
        public System.ComponentModel.ImmutableObjectAttribute Default; // 0x10
        public bool <Immutable>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Immutable(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93E78E0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E79A0
        public void .cctor(){} // RVA: 0x7FFAC93E7A10
    }

    public class InheritanceAttribute : Attribute
    {
        public System.ComponentModel.InheritanceAttribute InheritanceLevel;
        public System.ComponentModel.InheritanceAttribute InheritedReadOnly; // 0x8
        public System.ComponentModel.InheritanceAttribute NotInherited; // 0x10
        public System.ComponentModel.InheritanceAttribute Default; // 0x18
        public 0x6B133B68 <InheritanceLevel>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0 | overloaded x2
        public void get_InheritanceLevel(){} // RVA: 0x7FFAC2F6E5C0
        public void Equals(){} // RVA: 0x7FFAC93F80D0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93F8170
        public void ToString(){} // RVA: 0x7FFAC93F81E0
        public void .cctor(){} // RVA: 0x7FFAC93F8310
    }

    public class InitializationEventAttribute : Attribute
    {
        public string EventName; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_EventName(){} // RVA: 0x7FFAC2F3C380
    }

    public class InstallerTypeAttribute : Attribute
    {
        public string InstallerType; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void get_InstallerType(){} // RVA: 0x7FFAC93FE570
        public void Equals(){} // RVA: 0x7FFAC93FE5F0
        public void GetHashCode(){} // RVA: 0x7FFAC93E3800
    }

    public class InstanceCreationEditor : Object
    {
        public object Text;

        // ── Methods ──
        public void get_Text(){} // RVA: 0x7FFAC93FE6D0
        public void CreateInstance(){} // RVA: 0x7FFAC2C6A6F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Int16Converter : BaseNumberConverter
    {
        public object TargetType;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC93FE710
        public void FromString(){} // RVA: 0x7FFAC93FE850 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC93FE920
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Int32Converter : BaseNumberConverter
    {
        public object TargetType;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC93FE9C0
        public void FromString(){} // RVA: 0x7FFAC93FEB00 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC93FEB70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Int64Converter : BaseNumberConverter
    {
        public object TargetType;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC93FECB0
        public void FromString(){} // RVA: 0x7FFAC93FEDF0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC93FEE60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IntSecurity : Object
    {
        // ── Methods ──
        public void UnsafeGetFullPath(){} // RVA: 0x7FFAC941FEB0
    }

    public class InvalidAsynchronousStateException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D0B20 | overloaded x4
    }

    public class InvalidEnumArgumentException : ArgumentException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC83D0B20 | overloaded x5
    }

}