// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.ComponentModel
// Classes: 7
// Methods: 122

namespace ThirdParty.DotNet.System.ComponentModel
{
    public class BackgroundWorker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF96FBDA0
        public void AsyncOperationCompleted(){} // RVA: 0x7FFAF96FBF20
        public void get_CancellationPending(){} // RVA: 0x7FFAF4B0EA40
        public void CancelAsync(){} // RVA: 0x7FFAF96FBFC0
        public void add_DoWork(){} // RVA: 0x7FFAF96FC030
        public void remove_DoWork(){} // RVA: 0x7FFAF96FC120
        public void get_IsBusy(){} // RVA: 0x7FFAF4B0EA50
        public void OnDoWork(){} // RVA: 0x7FFAF96FC210
        public void OnRunWorkerCompleted(){} // RVA: 0x7FFAF91A5950
        public void OnProgressChanged(){} // RVA: 0x7FFAF96FC230
        public void add_ProgressChanged(){} // RVA: 0x7FFAF96FC250
        public void remove_ProgressChanged(){} // RVA: 0x7FFAF96FC340
        public void ProgressReporter(){} // RVA: 0x7FFAF96FC430
        public void ReportProgress(){} // RVA: 0x7FFAF96FC4D0 | overloaded x2
        public void RunWorkerAsync(){} // RVA: 0x7FFAF96FC740 | overloaded x2
        public void add_RunWorkerCompleted(){} // RVA: 0x7FFAF96FCAB0
        public void remove_RunWorkerCompleted(){} // RVA: 0x7FFAF96FCBA0
        public void get_WorkerReportsProgress(){} // RVA: 0x7FFAF36E6000
        public void set_WorkerReportsProgress(){} // RVA: 0x7FFAF43BAB20
        public void get_WorkerSupportsCancellation(){} // RVA: 0x7FFAF3198A80
        public void set_WorkerSupportsCancellation(){} // RVA: 0x7FFAF3198B80
        public void WorkerThreadStart(){} // RVA: 0x7FFAF96FCC90
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void <RunWorkerAsync>b__27_0(){} // RVA: 0x7FFAF96FD040
    }

    public class BaseNumberConverter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_AllowHex(){} // RVA: 0x7FFAF2E72850
        public void get_TargetType(){} // RVA: 0x7FFAF2ABCD60
        public void FromString(){} // RVA: 0x7FFAF2ACE6A0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF2ACE6A0
        public void CanConvertFrom(){} // RVA: 0x7FFAF97028A0
        public void ConvertFrom(){} // RVA: 0x7FFAF9702990
        public void ConvertTo(){} // RVA: 0x7FFAF9702F20
        public void CanConvertTo(){} // RVA: 0x7FFAF97031D0
    }

    public class BindableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9703260 | overloaded x4
        public void get_Bindable(){} // RVA: 0x7FFAF2FF3460
        public void get_Direction(){} // RVA: 0x7FFAF335BED0
        public void Equals(){} // RVA: 0x7FFAF9703280
        public void GetHashCode(){} // RVA: 0x7FFAF9703320
        public void IsDefaultAttribute(){} // RVA: 0x7FFAF9703370
        public void .cctor(){} // RVA: 0x7FFAF97033F0
    }

    public class BindingList`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
        public void Initialize(){} // RVA: 0x7FFAF2AD4A50
        public void get_ItemTypeHasDefaultConstructor(){} // RVA: 0x7FFAF2ABDBE0
        public void add_AddingNew(){} // RVA: 0x7FFAF2AD4B10
        public void remove_AddingNew(){} // RVA: 0x7FFAF2AD4B10
        public void OnAddingNew(){} // RVA: 0x7FFAF2AD4B10
        public void FireAddingNew(){} // RVA: 0x7FFAF2ABCD60
        public void add_ListChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_ListChanged(){} // RVA: 0x7FFAF2AD4B10
        public void OnListChanged(){} // RVA: 0x7FFAF2AD4B10
        public void get_RaiseListChangedEvents(){} // RVA: 0x7FFAF2ABDBE0
        public void set_RaiseListChangedEvents(){} // RVA: 0x7FFAF2AD5130
        public void ResetBindings(){} // RVA: 0x7FFAF2AD4A50
        public void ResetItem(){} // RVA: 0x7FFAF2AD4FA0
        public void FireListChanged(){} // RVA: 0x7FFAF2AD6EE0
        public void ClearItems(){} // RVA: 0x7FFAF2AD4A50
        public void InsertItem(){} // RVA: 0x7FFAF2D33FA0
        public void RemoveItem(){} // RVA: 0x7FFAF2AD4FA0
        public void SetItem(){} // RVA: 0x7FFAF2D33FA0
        public void CancelNew(){} // RVA: 0x7FFAF2AD4FA0
        public void EndNew(){} // RVA: 0x7FFAF2AD4FA0
        public void AddNew(){} // RVA: 0x7FFAF2D33FA0
        public void System.ComponentModel.IBindingList.AddNew(){} // RVA: 0x7FFAF2ABCD60
        public void get_AddingNewHandled(){} // RVA: 0x7FFAF2ABDBE0
        public void AddNewCore(){} // RVA: 0x7FFAF2ABCD60
        public void get_AllowNew(){} // RVA: 0x7FFAF2ABDBE0
        public void set_AllowNew(){} // RVA: 0x7FFAF2AD5130
        public void System.ComponentModel.IBindingList.get_AllowNew(){} // RVA: 0x7FFAF2ABDBE0
        public void get_AllowEdit(){} // RVA: 0x7FFAF2ABDBE0
        public void set_AllowEdit(){} // RVA: 0x7FFAF2AD5130
        public void System.ComponentModel.IBindingList.get_AllowEdit(){} // RVA: 0x7FFAF2ABDBE0
        public void get_AllowRemove(){} // RVA: 0x7FFAF2ABDBE0
        public void set_AllowRemove(){} // RVA: 0x7FFAF2AD5130
        public void System.ComponentModel.IBindingList.get_AllowRemove(){} // RVA: 0x7FFAF2ABDBE0
        public void System.ComponentModel.IBindingList.get_SupportsChangeNotification(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsChangeNotificationCore(){} // RVA: 0x7FFAF2ABDBE0
        public void System.ComponentModel.IBindingList.get_SupportsSearching(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsSearchingCore(){} // RVA: 0x7FFAF2ABDBE0
        public void System.ComponentModel.IBindingList.get_SupportsSorting(){} // RVA: 0x7FFAF2ABDBE0
        public void get_SupportsSortingCore(){} // RVA: 0x7FFAF2ABDBE0
        public void System.ComponentModel.IBindingList.get_IsSorted(){} // RVA: 0x7FFAF2ABDBE0
        public void get_IsSortedCore(){} // RVA: 0x7FFAF2ABDBE0
        public void System.ComponentModel.IBindingList.get_SortProperty(){} // RVA: 0x7FFAF2ABCD60
        public void get_SortPropertyCore(){} // RVA: 0x7FFAF2ABCD60
        public void System.ComponentModel.IBindingList.get_SortDirection(){} // RVA: 0x7FFAF2ABD840
        public void get_SortDirectionCore(){} // RVA: 0x7FFAF2ABD840
        public void System.ComponentModel.IBindingList.ApplySort(){} // RVA: 0x7FFAF2ADBAA0
        public void ApplySortCore(){} // RVA: 0x7FFAF2ADBAA0
        public void System.ComponentModel.IBindingList.RemoveSort(){} // RVA: 0x7FFAF2AD4A50
        public void RemoveSortCore(){} // RVA: 0x7FFAF2AD4A50
        public void System.ComponentModel.IBindingList.Find(){} // RVA: 0x7FFAF2AC7680
        public void FindCore(){} // RVA: 0x7FFAF2AC7680
        public void System.ComponentModel.IBindingList.AddIndex(){} // RVA: 0x7FFAF2AD4B10
        public void System.ComponentModel.IBindingList.RemoveIndex(){} // RVA: 0x7FFAF2AD4B10
        public void HookPropertyChanged(){} // RVA: 0x7FFAF2D33FA0
        public void UnhookPropertyChanged(){} // RVA: 0x7FFAF2D33FA0
        public void Child_PropertyChanged(){} // RVA: 0x7FFAF2ADDC60
        public void System.ComponentModel.IRaiseItemChangedEvents.get_RaisesItemChangedEvents(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class BooleanConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAF9703590
        public void ConvertFrom(){} // RVA: 0x7FFAF9703680
        public void GetStandardValues(){} // RVA: 0x7FFAF9703840
        public void GetStandardValuesExclusive(){} // RVA: 0x7FFAF2E72850
        public void GetStandardValuesSupported(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class BrowsableAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E575F0
        public void get_Browsable(){} // RVA: 0x7FFAF2E575E0
        public void Equals(){} // RVA: 0x7FFAF96FD050
        public void GetHashCode(){} // RVA: 0x7FFAF96FD110
        public void IsDefaultAttribute(){} // RVA: 0x7FFAF96FD160
        public void .cctor(){} // RVA: 0x7FFAF96FD1D0
    }

    public class ByteConverter
    {
        // ── Methods ──
        public void get_TargetType(){} // RVA: 0x7FFAF9703AF0
        public void FromString(){} // RVA: 0x7FFAF9703C30 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF9703D00
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}