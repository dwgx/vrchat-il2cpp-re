// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 7
// Methods: 114

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BackgroundWorker : Component
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA3AF90
        public void AsyncOperationCompleted(){} // RVA: 0x7AEA3B110
        public void get_CancellationPending(){} // RVA: 0x7A9E700C0
        public void CancelAsync(){} // RVA: 0x7AEA3B1B0
        public void add_DoWork(){} // RVA: 0x7AEA3B220
        public void remove_DoWork(){} // RVA: 0x7AEA3B310
        public void get_IsBusy(){} // RVA: 0x7A9E700D0
        public void OnDoWork(){} // RVA: 0x7AEA3B400
        public void OnRunWorkerCompleted(){} // RVA: 0x7AE4E3B20
        public void OnProgressChanged(){} // RVA: 0x7AEA3B420
        public void add_ProgressChanged(){} // RVA: 0x7AEA3B440
        public void remove_ProgressChanged(){} // RVA: 0x7AEA3B530
        public void ProgressReporter(){} // RVA: 0x7AEA3B620
        public void ReportProgress(){} // RVA: 0x7AEA3B6C0
        public void RunWorkerAsync(){} // RVA: 0x7AEA3B930
        public void add_RunWorkerCompleted(){} // RVA: 0x7AEA3BCA0
        public void remove_RunWorkerCompleted(){} // RVA: 0x7AEA3BD90
        public void get_WorkerReportsProgress(){} // RVA: 0x7A89FCA90
        public void set_WorkerReportsProgress(){} // RVA: 0x7A96C67C0
        public void get_WorkerSupportsCancellation(){} // RVA: 0x7A84A5BD0
        public void set_WorkerSupportsCancellation(){} // RVA: 0x7A84A5CD0
        public void WorkerThreadStart(){} // RVA: 0x7AEA3BE80
        public void Dispose(){} // RVA: 0x7A80D7310
        public void <RunWorkerAsync>b__27_0(){} // RVA: 0x7AEA3C250
    }

    public class BaseNumberConverter : TypeConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_AllowHex(){} // RVA: 0x7A81BD750
        public void get_TargetType(){} // RVA: 0x7A7E00680
        public void FromString(){} // RVA: 0x7A7E00BD0
        public void ToString(){} // RVA: 0x7A7E00BD0
        public void CanConvertFrom(){} // RVA: 0x7AEA41A80
        public void ConvertFrom(){} // RVA: 0x7AEA41B70
        public void ConvertTo(){} // RVA: 0x7AEA42100
        public void CanConvertTo(){} // RVA: 0x7AEA423B0
    }

    public class BindableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEA42440
        public void get_Bindable(){} // RVA: 0x7A82FBFB0
        public void get_Direction(){} // RVA: 0x7A8668BC0
        public void Equals(){} // RVA: 0x7AEA42460
        public void GetHashCode(){} // RVA: 0x7AEA42500
        public void IsDefaultAttribute(){} // RVA: 0x7AEA42550
        public void .cctor(){} // RVA: 0x7AEA425D0
    }

    public class BindingList`1 : Collection`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void Initialize(){} // RVA: 0x7A7E18770
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0x7A7E01900
        public void add_AddingNew(){} // RVA: 0x7A7E18800
        public void remove_AddingNew(){} // RVA: 0x7A7E18800
        public void OnAddingNew(){} // RVA: 0x7A7E18800
        public void FireAddingNew(){} // RVA: 0x7A7E00680
        public void add_ListChanged(){} // RVA: 0x7A7E18800
        public void remove_ListChanged(){} // RVA: 0x7A7E18800
        public void OnListChanged(){} // RVA: 0x7A7E18800
        public void get_RaiseListChangedEvents(){} // RVA: 0x7A7E01900
        public void set_RaiseListChangedEvents(){} // RVA: 0x7A7E18C30
        public void ResetBindings(){} // RVA: 0x7A7E18770
        public void ResetItem(){} // RVA: 0x7A7E189D0
        public void FireListChanged(){} // RVA: 0x7A7E1ABE0
        public void ClearItems(){} // RVA: 0x7A7E18770
        public void InsertItem(){} // RVA: 0x7A8051B10
        public void RemoveItem(){} // RVA: 0x7A7E189D0
        public void SetItem(){} // RVA: 0x7A8051B10
        public void CancelNew(){} // RVA: 0x7A7E189D0
        public void EndNew(){} // RVA: 0x7A7E189D0
        public void AddNew(){} // RVA: 0x7A8051B10
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7A7E00680
        public void get_AddingNewHandled(){} // RVA: 0x7A7E01900
        public void AddNewCore(){} // RVA: 0x7A7E00680
        public void get_AllowNew(){} // RVA: 0x7A7E01900
        public void set_AllowNew(){} // RVA: 0x7A7E18C30
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7A7E01900
        public void get_AllowEdit(){} // RVA: 0x7A7E01900
        public void set_AllowEdit(){} // RVA: 0x7A7E18C30
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7A7E01900
        public void get_AllowRemove(){} // RVA: 0x7A7E01900
        public void set_AllowRemove(){} // RVA: 0x7A7E18C30
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7A7E01900
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7A7E01900
        public void get_SupportsChangeNotificationCore(){} // RVA: 0x7A7E01900
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7A7E01900
        public void get_SupportsSearchingCore(){} // RVA: 0x7A7E01900
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7A7E01900
        public void get_SupportsSortingCore(){} // RVA: 0x7A7E01900
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7A7E01900
        public void get_IsSortedCore(){} // RVA: 0x7A7E01900
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7A7E00680
        public void get_SortPropertyCore(){} // RVA: 0x7A7E00680
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7A7E00710
        public void get_SortDirectionCore(){} // RVA: 0x7A7E00710
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7A7E1D590
        public void ApplySortCore(){} // RVA: 0x7A7E1D590
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7A7E18770
        public void RemoveSortCore(){} // RVA: 0x7A7E18770
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7A7E06320
        public void FindCore(){} // RVA: 0x7A7E06320
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7A7E18800
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7A7E18800
        public void HookPropertyChanged(){} // RVA: 0x7A8051B10
        public void UnhookPropertyChanged(){} // RVA: 0x7A8051B10
        public void Child_PropertyChanged(){} // RVA: 0x7A7E18890
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0x7A7E01900
    }

    public class BooleanConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7AEA42770
        public void ConvertFrom(){} // RVA: 0x7AEA42860
        public void GetStandardValues(){} // RVA: 0x7AEA42A20
        public void GetStandardValuesExclusive(){} // RVA: 0x7A81BD750
        public void GetStandardValuesSupported(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class BrowsableAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81A2210
        public void get_Browsable(){} // RVA: 0x7A81A2200
        public void Equals(){} // RVA: 0x7AEA3C260
        public void GetHashCode(){} // RVA: 0x7AEA3C320
        public void IsDefaultAttribute(){} // RVA: 0x7AEA3C370
        public void .cctor(){} // RVA: 0x7AEA3C3E0
    }

    public class ByteConverter : BaseNumberConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7AEA42CD0
        public void FromString(){} // RVA: 0x7AEA42E10
        public void ToString(){} // RVA: 0x7AEA42EE0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}