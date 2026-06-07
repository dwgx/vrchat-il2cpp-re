// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 7
// Methods: 122

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BackgroundWorker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C4BDA0
        public void AsyncOperationCompleted(){} // RVA: 0x6C4BF20
        public void get_CancellationPending(){} // RVA: 0x205EA40
        public void CancelAsync(){} // RVA: 0x6C4BFC0
        public void add_DoWork(){} // RVA: 0x6C4C030
        public void remove_DoWork(){} // RVA: 0x6C4C120
        public void get_IsBusy(){} // RVA: 0x205EA50
        public void OnDoWork(){} // RVA: 0x6C4C210
        public void OnRunWorkerCompleted(){} // RVA: 0x66F5950
        public void OnProgressChanged(){} // RVA: 0x6C4C230
        public void add_ProgressChanged(){} // RVA: 0x6C4C250
        public void remove_ProgressChanged(){} // RVA: 0x6C4C340
        public void ProgressReporter(){} // RVA: 0x6C4C430
        public void ReportProgress(){} // RVA: 0x6C4C4D0 | overloaded x2
        public void RunWorkerAsync(){} // RVA: 0x6C4C740 | overloaded x2
        public void add_RunWorkerCompleted(){} // RVA: 0x6C4CAB0
        public void remove_RunWorkerCompleted(){} // RVA: 0x6C4CBA0
        public void get_WorkerReportsProgress(){} // RVA: 0xC36000
        public void set_WorkerReportsProgress(){} // RVA: 0x190AB20
        public void get_WorkerSupportsCancellation(){} // RVA: 0x6E8A80
        public void set_WorkerSupportsCancellation(){} // RVA: 0x6E8B80
        public void WorkerThreadStart(){} // RVA: 0x6C4CC90
        public void Dispose(){} // RVA: 0x2DD310
        public void <RunWorkerAsync>b__27_0(){} // RVA: 0x6C4D040
    }

    public class BaseNumberConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_AllowHex(){} // RVA: 0x3C2850
        public void get_TargetType(){} // RVA: 0xCD60
        public void FromString(){} // RVA: 0x1E6A0 | overloaded x2
        public void ToString(){} // RVA: 0x1E6A0
        public void CanConvertFrom(){} // RVA: 0x6C528A0
        public void ConvertFrom(){} // RVA: 0x6C52990
        public void ConvertTo(){} // RVA: 0x6C52F20
        public void CanConvertTo(){} // RVA: 0x6C531D0
    }

    public class BindableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C53260 | overloaded x4
        public void get_Bindable(){} // RVA: 0x543460
        public void get_Direction(){} // RVA: 0x8ABED0
        public void Equals(){} // RVA: 0x6C53280
        public void GetHashCode(){} // RVA: 0x6C53320
        public void IsDefaultAttribute(){} // RVA: 0x6C53370
        public void .cctor(){} // RVA: 0x6C533F0
    }

    public class BindingList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10 | overloaded x2
        public void Initialize(){} // RVA: 0x24A50
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0xDBE0
        public void add_AddingNew(){} // RVA: 0x24B10
        public void remove_AddingNew(){} // RVA: 0x24B10
        public void OnAddingNew(){} // RVA: 0x24B10
        public void FireAddingNew(){} // RVA: 0xCD60
        public void add_ListChanged(){} // RVA: 0x24B10
        public void remove_ListChanged(){} // RVA: 0x24B10
        public void OnListChanged(){} // RVA: 0x24B10
        public void get_RaiseListChangedEvents(){} // RVA: 0xDBE0
        public void set_RaiseListChangedEvents(){} // RVA: 0x25130
        public void ResetBindings(){} // RVA: 0x24A50
        public void ResetItem(){} // RVA: 0x24FA0
        public void FireListChanged(){} // RVA: 0x26EE0
        public void ClearItems(){} // RVA: 0x24A50
        public void InsertItem(){} // RVA: 0x283FA0
        public void RemoveItem(){} // RVA: 0x24FA0
        public void SetItem(){} // RVA: 0x283FA0
        public void CancelNew(){} // RVA: 0x24FA0
        public void EndNew(){} // RVA: 0x24FA0
        public void AddNew(){} // RVA: 0x283FA0
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0xCD60
        public void get_AddingNewHandled(){} // RVA: 0xDBE0
        public void AddNewCore(){} // RVA: 0xCD60
        public void get_AllowNew(){} // RVA: 0xDBE0
        public void set_AllowNew(){} // RVA: 0x25130
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0xDBE0
        public void get_AllowEdit(){} // RVA: 0xDBE0
        public void set_AllowEdit(){} // RVA: 0x25130
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0xDBE0
        public void get_AllowRemove(){} // RVA: 0xDBE0
        public void set_AllowRemove(){} // RVA: 0x25130
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0xDBE0
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0xDBE0
        public void get_SupportsChangeNotificationCore(){} // RVA: 0xDBE0
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0xDBE0
        public void get_SupportsSearchingCore(){} // RVA: 0xDBE0
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0xDBE0
        public void get_SupportsSortingCore(){} // RVA: 0xDBE0
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0xDBE0
        public void get_IsSortedCore(){} // RVA: 0xDBE0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0xCD60
        public void get_SortPropertyCore(){} // RVA: 0xCD60
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0xD840
        public void get_SortDirectionCore(){} // RVA: 0xD840
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x2BAA0
        public void ApplySortCore(){} // RVA: 0x2BAA0
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x24A50
        public void RemoveSortCore(){} // RVA: 0x24A50
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x17680
        public void FindCore(){} // RVA: 0x17680
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x24B10
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x24B10
        public void HookPropertyChanged(){} // RVA: 0x283FA0
        public void UnhookPropertyChanged(){} // RVA: 0x283FA0
        public void Child_PropertyChanged(){} // RVA: 0x2DC60
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0xDBE0
    }

    public class BooleanConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x6C53590
        public void ConvertFrom(){} // RVA: 0x6C53680
        public void GetStandardValues(){} // RVA: 0x6C53840
        public void GetStandardValuesExclusive(){} // RVA: 0x3C2850
        public void GetStandardValuesSupported(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class BrowsableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3A75F0
        public void get_Browsable(){} // RVA: 0x3A75E0
        public void Equals(){} // RVA: 0x6C4D050
        public void GetHashCode(){} // RVA: 0x6C4D110
        public void IsDefaultAttribute(){} // RVA: 0x6C4D160
        public void .cctor(){} // RVA: 0x6C4D1D0
    }

    public class ByteConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x6C53AF0
        public void FromString(){} // RVA: 0x6C53C30 | overloaded x2
        public void ToString(){} // RVA: 0x6C53D00
        public void .ctor(){} // RVA: 0x2DD310
    }

}