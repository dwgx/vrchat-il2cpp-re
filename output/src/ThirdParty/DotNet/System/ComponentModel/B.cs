// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 7
// Methods: 122

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BackgroundWorker : Component
    {
        public bool CancellationPending; // 0x28
        public bool IsBusy; // 0x29
        public bool WorkerReportsProgress; // 0x2A
        public bool WorkerSupportsCancellation; // 0x2B
        public System.ComponentModel.AsyncOperation _asyncOperation; // 0x30
        public System.Threading.SendOrPostCallback _operationCompleted; // 0x38
        public System.Threading.SendOrPostCallback _progressReporter; // 0x40
        public System.ComponentModel.DoWorkEventHandler DoWork; // 0x48
        public System.ComponentModel.ProgressChangedEventHandler ProgressChanged; // 0x50
        public System.ComponentModel.RunWorkerCompletedEventHandler RunWorkerCompleted; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93E4520
        public void AsyncOperationCompleted(){} // RVA: 0x7FFAC93E46A0
        public void get_CancellationPending(){} // RVA: 0x7FFAC4B82F20
        public void CancelAsync(){} // RVA: 0x7FFAC93E4740
        public void add_DoWork(){} // RVA: 0x7FFAC93E47B0
        public void remove_DoWork(){} // RVA: 0x7FFAC93E48A0
        public void get_IsBusy(){} // RVA: 0x7FFAC4B82F30
        public void OnDoWork(){} // RVA: 0x7FFAC93E4990
        public void OnRunWorkerCompleted(){} // RVA: 0x7FFAC8E8C410
        public void OnProgressChanged(){} // RVA: 0x7FFAC93E49B0
        public void add_ProgressChanged(){} // RVA: 0x7FFAC93E49D0
        public void remove_ProgressChanged(){} // RVA: 0x7FFAC93E4AC0
        public void ProgressReporter(){} // RVA: 0x7FFAC93E4BB0
        public void ReportProgress(){} // RVA: 0x7FFAC93E4C50 | overloaded x2
        public void RunWorkerAsync(){} // RVA: 0x7FFAC93E4EC0 | overloaded x2
        public void add_RunWorkerCompleted(){} // RVA: 0x7FFAC93E5230
        public void remove_RunWorkerCompleted(){} // RVA: 0x7FFAC93E5320
        public void get_WorkerReportsProgress(){} // RVA: 0x7FFAC386C550
        public void set_WorkerReportsProgress(){} // RVA: 0x7FFAC43B4D70
        public void get_WorkerSupportsCancellation(){} // RVA: 0x7FFAC30F6BA0
        public void set_WorkerSupportsCancellation(){} // RVA: 0x7FFAC3C24F40
        public void WorkerThreadStart(){} // RVA: 0x7FFAC93E5410
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void <RunWorkerAsync>b__27_0(){} // RVA: 0x7FFAC93E57C0
    }

    public class BaseNumberConverter : TypeConverter
    {
        public object AllowHex;
        public object TargetType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_AllowHex(){} // RVA: 0x7FFAC3006850
        public void get_TargetType(){} // RVA: 0x7FFAC2C58E90
        public void FromString(){} // RVA: 0x7FFAC2C6A6F0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC2C6A6F0
        public void CanConvertFrom(){} // RVA: 0x7FFAC93EB020
        public void ConvertFrom(){} // RVA: 0x7FFAC93EB110
        public void ConvertTo(){} // RVA: 0x7FFAC93EB6A0
        public void CanConvertTo(){} // RVA: 0x7FFAC93EB950
    }

    public class BindableAttribute : Attribute
    {
        public System.ComponentModel.BindableAttribute Bindable;
        public System.ComponentModel.BindableAttribute Direction; // 0x8
        public System.ComponentModel.BindableAttribute Default; // 0x10
        public bool _isDefault; // 0x10
        public bool <Bindable>k__BackingField; // 0x11
        public 0x6B133220 <Direction>k__BackingField; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC93EB9E0 | overloaded x4
        public void get_Bindable(){} // RVA: 0x7FFAC3771DA0
        public void get_Direction(){} // RVA: 0x7FFAC33D5A20
        public void Equals(){} // RVA: 0x7FFAC93EBA00
        public void GetHashCode(){} // RVA: 0x7FFAC93EBAA0
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93EBAF0
        public void .cctor(){} // RVA: 0x7FFAC93EBB70
    }

    public class BindingList`1 : Collection`1
    {
        public int ItemTypeHasDefaultConstructor;
        public bool RaiseListChangedEvents;
        public bool AddingNewHandled;
        public System.ComponentModel.PropertyDescriptorCollection AllowNew;
        public System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.IBindingList.AllowNew;
        public System.ComponentModel.AddingNewEventHandler AllowEdit;
        public System.ComponentModel.ListChangedEventHandler System.ComponentModel.IBindingList.AllowEdit;
        public int AllowRemove;
        public bool System.ComponentModel.IBindingList.AllowRemove;
        public bool System.ComponentModel.IBindingList.SupportsChangeNotification;
        public bool SupportsChangeNotificationCore;
        public bool System.ComponentModel.IBindingList.SupportsSearching;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAC2C70980
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0x7FFAC2C59D00
        public void add_AddingNew(){} // RVA: 0x7FFAC2C70A40
        public void remove_AddingNew(){} // RVA: 0x7FFAC2C70A40
        public void OnAddingNew(){} // RVA: 0x7FFAC2C70A40
        public void FireAddingNew(){} // RVA: 0x7FFAC2C58E90
        public void add_ListChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_ListChanged(){} // RVA: 0x7FFAC2C70A40
        public void OnListChanged(){} // RVA: 0x7FFAC2C70A40
        public void get_RaiseListChangedEvents(){} // RVA: 0x7FFAC2C59D00
        public void set_RaiseListChangedEvents(){} // RVA: 0x7FFAC2C71060
        public void ResetBindings(){} // RVA: 0x7FFAC2C70980
        public void ResetItem(){} // RVA: 0x7FFAC2C70ED0
        public void FireListChanged(){} // RVA: 0x7FFAC2C72E60
        public void ClearItems(){} // RVA: 0x7FFAC2C70980
        public void InsertItem(){} // RVA: 0x7FFAC2E8DC40
        public void RemoveItem(){} // RVA: 0x7FFAC2C70ED0
        public void SetItem(){} // RVA: 0x7FFAC2E8DC40
        public void CancelNew(){} // RVA: 0x7FFAC2C70ED0
        public void EndNew(){} // RVA: 0x7FFAC2C70ED0
        public void AddNew(){} // RVA: 0x7FFAC2E8DC40
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFAC2C58E90
        public void get_AddingNewHandled(){} // RVA: 0x7FFAC2C59D00
        public void AddNewCore(){} // RVA: 0x7FFAC2C58E90
        public void get_AllowNew(){} // RVA: 0x7FFAC2C59D00
        public void set_AllowNew(){} // RVA: 0x7FFAC2C71060
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFAC2C59D00
        public void get_AllowEdit(){} // RVA: 0x7FFAC2C59D00
        public void set_AllowEdit(){} // RVA: 0x7FFAC2C71060
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFAC2C59D00
        public void get_AllowRemove(){} // RVA: 0x7FFAC2C59D00
        public void set_AllowRemove(){} // RVA: 0x7FFAC2C71060
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFAC2C59D00
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsChangeNotificationCore(){} // RVA: 0x7FFAC2C59D00
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsSearchingCore(){} // RVA: 0x7FFAC2C59D00
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFAC2C59D00
        public void get_SupportsSortingCore(){} // RVA: 0x7FFAC2C59D00
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFAC2C59D00
        public void get_IsSortedCore(){} // RVA: 0x7FFAC2C59D00
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFAC2C58E90
        public void get_SortPropertyCore(){} // RVA: 0x7FFAC2C58E90
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFAC2C59960
        public void get_SortDirectionCore(){} // RVA: 0x7FFAC2C59960
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFAC2C77970
        public void ApplySortCore(){} // RVA: 0x7FFAC2C77970
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFAC2C70980
        public void RemoveSortCore(){} // RVA: 0x7FFAC2C70980
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFAC2C637A0
        public void FindCore(){} // RVA: 0x7FFAC2C637A0
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFAC2C70A40
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFAC2C70A40
        public void HookPropertyChanged(){} // RVA: 0x7FFAC2E8DC40
        public void UnhookPropertyChanged(){} // RVA: 0x7FFAC2E8DC40
        public void Child_PropertyChanged(){} // RVA: 0x7FFAC2C79B30
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0x7FFAC2C59D00
    }

    public class BooleanConverter : TypeConverter
    {
        public StandardValuesCollection s_values;

        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC93EBD10
        public void ConvertFrom(){} // RVA: 0x7FFAC93EBE00
        public void GetStandardValues(){} // RVA: 0x7FFAC93EBFC0
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAC3006850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class BrowsableAttribute : Attribute
    {
        public System.ComponentModel.BrowsableAttribute Browsable;
        public System.ComponentModel.BrowsableAttribute No; // 0x8
        public System.ComponentModel.BrowsableAttribute Default; // 0x10
        public bool <Browsable>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Browsable(){} // RVA: 0x7FFAC2FEB5E0
        public void Equals(){} // RVA: 0x7FFAC93E57D0
        public void GetHashCode(){} // RVA: 0x7FFAC93E5890
        public void IsDefaultAttribute(){} // RVA: 0x7FFAC93E58E0
        public void .cctor(){} // RVA: 0x7FFAC93E5950
    }

    public class ByteConverter : BaseNumberConverter
    {
        public object TargetType;

        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAC93EC270
        public void FromString(){} // RVA: 0x7FFAC93EC3B0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC93EC480
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}