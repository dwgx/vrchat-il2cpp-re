// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 7
// Methods: 114

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BackgroundWorker : Component
    {
        public object _canCancelWorker;
        public object _workerReportsProgress;
        public object _cancellationPending;
        public object _isRunning;
        public object _asyncOperation;
        public object _operationCompleted;
        public object _progressReporter;
        public object DoWork;
        public object ProgressChanged;
        public object RunWorkerCompleted;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76ACA90
        public void AsyncOperationCompleted(){} // RVA: 0x76ACC10
        public void get_CancellationPending(){} // RVA: 0x28E58A0
        public void CancelAsync(){} // RVA: 0x76ACCB0
        public void add_DoWork(){} // RVA: 0x76ACD20
        public void remove_DoWork(){} // RVA: 0x76ACE10
        public void get_IsBusy(){} // RVA: 0x28E5880
        public void OnDoWork(){} // RVA: 0x76ACF00
        public void OnRunWorkerCompleted(){} // RVA: 0x715E160
        public void OnProgressChanged(){} // RVA: 0x76ACF20
        public void add_ProgressChanged(){} // RVA: 0x76ACF40
        public void remove_ProgressChanged(){} // RVA: 0x76AD030
        public void ProgressReporter(){} // RVA: 0x76AD120
        public void ReportProgress(){} // RVA: 0x76AD1C0
        public void RunWorkerAsync(){} // RVA: 0x76AD430
        public void add_RunWorkerCompleted(){} // RVA: 0x76AD7A0
        public void remove_RunWorkerCompleted(){} // RVA: 0x76AD890
        public void get_WorkerReportsProgress(){} // RVA: 0x14F7430
        public void set_WorkerReportsProgress(){} // RVA: 0x21CBB70
        public void get_WorkerSupportsCancellation(){} // RVA: 0xF73960
        public void set_WorkerSupportsCancellation(){} // RVA: 0xF73A60
        public void WorkerThreadStart(){} // RVA: 0x76AD980
        public void Dispose(){} // RVA: 0xB43310
        public void <RunWorkerAsync>b__27_0(){} // RVA: 0x76ADD50
    }

    public class BaseNumberConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_AllowHex(){} // RVA: 0xC2E4C0
        public void get_TargetType(){} // RVA: 0x87C0A0
        public void FromString(){} // RVA: 0x87C5F0
        public void ToString(){} // RVA: 0x87C5F0
        public void CanConvertFrom(){} // RVA: 0x76B2D50
        public void ConvertFrom(){} // RVA: 0x76B2E50
        public void ConvertTo(){} // RVA: 0x76B33E0
        public void CanConvertTo(){} // RVA: 0x76B36A0
    }

    public class BindableAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _isDefault;
        public object _bindable;
        public object _direction;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x76B3730
        public void get_Bindable(){} // RVA: 0xDD5C50
        public void get_Direction(){} // RVA: 0x116A650
        public void Equals(){} // RVA: 0x76B3750
        public void GetHashCode(){} // RVA: 0x76B37F0
        public void IsDefaultAttribute(){} // RVA: 0x76B3820
        public void .cctor(){} // RVA: 0x76B38A0
    }

    public class BindingList`1 : Collection`1
    {
        public object addNewPos;
        public object raiseListChangedEvents;
        public object raiseItemChangedEvents;
        public object _itemTypeProperties;
        public object _propertyChangedEventHandler;
        public object _onAddingNew;
        public object _onListChanged;
        public object _lastChangeIndex;
        public object allowNew;
        public object allowEdit;
        public object allowRemove;
        public object userSetAllowNew;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void Initialize(){} // RVA: 0x894290
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0x87D280
        public void add_AddingNew(){} // RVA: 0x894320
        public void remove_AddingNew(){} // RVA: 0x894320
        public void OnAddingNew(){} // RVA: 0x894320
        public void FireAddingNew(){} // RVA: 0x87C0A0
        public void add_ListChanged(){} // RVA: 0x894320
        public void remove_ListChanged(){} // RVA: 0x894320
        public void OnListChanged(){} // RVA: 0x894320
        public void get_RaiseListChangedEvents(){} // RVA: 0x87D280
        public void set_RaiseListChangedEvents(){} // RVA: 0x894750
        public void ResetBindings(){} // RVA: 0x894290
        public void ResetItem(){} // RVA: 0x8944F0
        public void FireListChanged(){} // RVA: 0x8965E0
        public void ClearItems(){} // RVA: 0x894290
        public void InsertItem(){} // RVA: 0xA94080
        public void RemoveItem(){} // RVA: 0x8944F0
        public void SetItem(){} // RVA: 0xA94080
        public void CancelNew(){} // RVA: 0x8944F0
        public void EndNew(){} // RVA: 0x8944F0
        public void AddNew(){} // RVA: 0xA94080
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x87C0A0
        public void get_AddingNewHandled(){} // RVA: 0x87D280
        public void AddNewCore(){} // RVA: 0x87C0A0
        public void get_AllowNew(){} // RVA: 0x87D280
        public void set_AllowNew(){} // RVA: 0x894750
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x87D280
        public void get_AllowEdit(){} // RVA: 0x87D280
        public void set_AllowEdit(){} // RVA: 0x894750
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x87D280
        public void get_AllowRemove(){} // RVA: 0x87D280
        public void set_AllowRemove(){} // RVA: 0x894750
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x87D280
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x87D280
        public void get_SupportsChangeNotificationCore(){} // RVA: 0x87D280
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x87D280
        public void get_SupportsSearchingCore(){} // RVA: 0x87D280
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x87D280
        public void get_SupportsSortingCore(){} // RVA: 0x87D280
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x87D280
        public void get_IsSortedCore(){} // RVA: 0x87D280
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x87C0A0
        public void get_SortPropertyCore(){} // RVA: 0x87C0A0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x87C130
        public void get_SortDirectionCore(){} // RVA: 0x87C130
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x899290
        public void ApplySortCore(){} // RVA: 0x899290
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x894290
        public void RemoveSortCore(){} // RVA: 0x894290
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x881CA0
        public void FindCore(){} // RVA: 0x881CA0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x894320
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x894320
        public void HookPropertyChanged(){} // RVA: 0xA94080
        public void UnhookPropertyChanged(){} // RVA: 0xA94080
        public void Child_PropertyChanged(){} // RVA: 0x8943B0
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0x87D280
    }

    public class BooleanConverter : TypeConverter
    {
        public object s_values;

        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x76B2D50
        public void ConvertFrom(){} // RVA: 0x76B3A40
        public void GetStandardValues(){} // RVA: 0x76B3BC0
        public void GetStandardValuesExclusive(){} // RVA: 0xC2E4C0
        public void GetStandardValuesSupported(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class BrowsableAttribute : Attribute
    {
        public object Yes;
        public object No;
        public object Default;
        public object _browsable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xC120B0
        public void get_Browsable(){} // RVA: 0xC120A0
        public void Equals(){} // RVA: 0x76ADD60
        public void GetHashCode(){} // RVA: 0x76ADE20
        public void IsDefaultAttribute(){} // RVA: 0x76ADE50
        public void .cctor(){} // RVA: 0x76ADEC0
    }

    public class ByteConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x76B3E60
        public void FromString(){} // RVA: 0x76B3F40
        public void ToString(){} // RVA: 0x76B3FF0
        public void .ctor(){} // RVA: 0xB43310
    }

}