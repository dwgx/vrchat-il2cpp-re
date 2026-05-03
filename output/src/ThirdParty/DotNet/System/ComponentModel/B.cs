// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 7
// Methods: 122

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BackgroundWorker : Component
    {
        public bool _canCancelWorker; // 0x28
        public bool _workerReportsProgress; // 0x29
        public bool _cancellationPending; // 0x2A
        public bool _isRunning; // 0x2B

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8778CC50
        public void AsyncOperationCompleted(){} // RVA: 0x7FFE8778CDD0
        public void get_CancellationPending(){} // RVA: 0x7FFE82DEC5E0
        public void CancelAsync(){} // RVA: 0x7FFE8778CE70
        public void add_DoWork(){} // RVA: 0x7FFE8778CEE0
        public void remove_DoWork(){} // RVA: 0x7FFE8778CFD0
        public void get_IsBusy(){} // RVA: 0x7FFE82DEC5C0
        public void OnDoWork(){} // RVA: 0x7FFE8778D0C0
        public void OnRunWorkerCompleted(){} // RVA: 0x7FFE87234840
        public void OnProgressChanged(){} // RVA: 0x7FFE8778D0E0
        public void add_ProgressChanged(){} // RVA: 0x7FFE8778D100
        public void remove_ProgressChanged(){} // RVA: 0x7FFE8778D1F0
        public void ProgressReporter(){} // RVA: 0x7FFE8778D2E0
        public void ReportProgress(){} // RVA: 0x7FFE8778D380 | overloaded x2
        public void RunWorkerAsync(){} // RVA: 0x7FFE8778D5F0 | overloaded x2
        public void add_RunWorkerCompleted(){} // RVA: 0x7FFE8778D960
        public void remove_RunWorkerCompleted(){} // RVA: 0x7FFE8778DA50
        public void get_WorkerReportsProgress(){} // RVA: 0x7FFE819C2EA0
        public void set_WorkerReportsProgress(){} // RVA: 0x7FFE8268C820
        public void get_WorkerSupportsCancellation(){} // RVA: 0x7FFE815F1380
        public void set_WorkerSupportsCancellation(){} // RVA: 0x7FFE81C15740
        public void WorkerThreadStart(){} // RVA: 0x7FFE8778DB40
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void <RunWorkerAsync>b__27_0(){} // RVA: 0x7FFE8778DEF0
    }

    public class BaseNumberConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_AllowHex(){} // RVA: 0x7FFE811E0850
        public void get_TargetType(){} // RVA: 0x7FFE80E2E2E0
        public void FromString(){} // RVA: 0x7FFE80E3FC10 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE80E3FC10
        public void CanConvertFrom(){} // RVA: 0x7FFE87793750
        public void ConvertFrom(){} // RVA: 0x7FFE87793840
        public void ConvertTo(){} // RVA: 0x7FFE87793DD0
        public void CanConvertTo(){} // RVA: 0x7FFE87794080
    }

    public class BindableAttribute : Attribute
    {
        public System.ComponentModel.BindableAttribute Yes;
        public System.ComponentModel.BindableAttribute No; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87794110 | overloaded x4
        public void get_Bindable(){} // RVA: 0x7FFE81346E30
        public void get_Direction(){} // RVA: 0x7FFE8164B230
        public void Equals(){} // RVA: 0x7FFE87794130
        public void GetHashCode(){} // RVA: 0x7FFE877941D0
        public void IsDefaultAttribute(){} // RVA: 0x7FFE87794220
        public void .cctor(){} // RVA: 0x7FFE877942A0
    }

    public class BindingList`1 : Collection`1
    {
        public int addNewPos;
        public bool raiseListChangedEvents;
        public bool raiseItemChangedEvents;
        public System.ComponentModel.PropertyDescriptorCollection _itemTypeProperties;
        public System.ComponentModel.PropertyChangedEventHandler _propertyChangedEventHandler;
        public System.ComponentModel.AddingNewEventHandler _onAddingNew;
        public System.ComponentModel.ListChangedEventHandler _onListChanged;
        public int _lastChangeIndex;
        public bool allowNew;
        public bool allowEdit;
        public bool allowRemove;
        public bool userSetAllowNew;
        public object AddingNew; // 0x5
        public System.ComponentModel.ListChangedEventHandler AddingNew; // 0x3690
        public object field_14; // 0xF730
        public object field_15; // 0xF730
        public object field_16; // 0xF730
        public object field_17; // 0xF730
        public object field_18; // 0xF730
        public object field_19; // 0xF730
        public object field_20; // 0xF730
        public object field_21; // 0xF730

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFE80E45FE0
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0x7FFE80E2F150
        public void add_AddingNew(){} // RVA: 0x7FFE80E460A0
        public void remove_AddingNew(){} // RVA: 0x7FFE80E460A0
        public void OnAddingNew(){} // RVA: 0x7FFE80E460A0
        public void FireAddingNew(){} // RVA: 0x7FFE80E2E2E0
        public void add_ListChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_ListChanged(){} // RVA: 0x7FFE80E460A0
        public void OnListChanged(){} // RVA: 0x7FFE80E460A0
        public void get_RaiseListChangedEvents(){} // RVA: 0x7FFE80E2F150
        public void set_RaiseListChangedEvents(){} // RVA: 0x7FFE80E466C0
        public void ResetBindings(){} // RVA: 0x7FFE80E45FE0
        public void ResetItem(){} // RVA: 0x7FFE80E46530
        public void FireListChanged(){} // RVA: 0x7FFE80E484C0
        public void ClearItems(){} // RVA: 0x7FFE80E45FE0
        public void InsertItem(){} // RVA: 0x7FFE810A1420
        public void RemoveItem(){} // RVA: 0x7FFE80E46530
        public void SetItem(){} // RVA: 0x7FFE810A1420
        public void CancelNew(){} // RVA: 0x7FFE80E46530
        public void EndNew(){} // RVA: 0x7FFE80E46530
        public void AddNew(){} // RVA: 0x7FFE810A1420
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFE80E2E2E0
        public void get_AddingNewHandled(){} // RVA: 0x7FFE80E2F150
        public void AddNewCore(){} // RVA: 0x7FFE80E2E2E0
        public void get_AllowNew(){} // RVA: 0x7FFE80E2F150
        public void set_AllowNew(){} // RVA: 0x7FFE80E466C0
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFE80E2F150
        public void get_AllowEdit(){} // RVA: 0x7FFE80E2F150
        public void set_AllowEdit(){} // RVA: 0x7FFE80E466C0
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFE80E2F150
        public void get_AllowRemove(){} // RVA: 0x7FFE80E2F150
        public void set_AllowRemove(){} // RVA: 0x7FFE80E466C0
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFE80E2F150
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsChangeNotificationCore(){} // RVA: 0x7FFE80E2F150
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsSearchingCore(){} // RVA: 0x7FFE80E2F150
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFE80E2F150
        public void get_SupportsSortingCore(){} // RVA: 0x7FFE80E2F150
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFE80E2F150
        public void get_IsSortedCore(){} // RVA: 0x7FFE80E2F150
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFE80E2E2E0
        public void get_SortPropertyCore(){} // RVA: 0x7FFE80E2E2E0
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFE80E2EDB0
        public void get_SortDirectionCore(){} // RVA: 0x7FFE80E2EDB0
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFE80E4D070
        public void ApplySortCore(){} // RVA: 0x7FFE80E4D070
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFE80E45FE0
        public void RemoveSortCore(){} // RVA: 0x7FFE80E45FE0
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFE80E38BF0
        public void FindCore(){} // RVA: 0x7FFE80E38BF0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFE80E460A0
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFE80E460A0
        public void HookPropertyChanged(){} // RVA: 0x7FFE810A1420
        public void UnhookPropertyChanged(){} // RVA: 0x7FFE810A1420
        public void Child_PropertyChanged(){} // RVA: 0x7FFE80E4F230
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0x7FFE80E2F150
    }

    public class BooleanConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFE87794440
        public void ConvertFrom(){} // RVA: 0x7FFE87794530
        public void GetStandardValues(){} // RVA: 0x7FFE877946F0
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFE811E0850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class BrowsableAttribute : Attribute
    {
        public System.ComponentModel.BrowsableAttribute Yes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811C55F0
        public void get_Browsable(){} // RVA: 0x7FFE811C55E0
        public void Equals(){} // RVA: 0x7FFE8778DF00
        public void GetHashCode(){} // RVA: 0x7FFE8778DFC0
        public void IsDefaultAttribute(){} // RVA: 0x7FFE8778E010
        public void .cctor(){} // RVA: 0x7FFE8778E080
    }

    public class ByteConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFE877949A0
        public void FromString(){} // RVA: 0x7FFE87794AE0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87794BB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}