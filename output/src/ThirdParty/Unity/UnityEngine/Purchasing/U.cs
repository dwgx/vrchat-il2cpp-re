// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 15
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7232BC0
    }

    public class UDPBindings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7232C70
        public void Initialize(){} // RVA: 0x7232D90
        public void Purchase(){} // RVA: 0x7234C90 | overloaded x2
        public void RetrieveProducts(){} // RVA: 0x7234C50 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7234CD0 | overloaded x2
        public void OnInventoryQueried(){} // RVA: 0x7233AD0
        public void StringPropertyToDictionary(){} // RVA: 0x7234D10
    }

    public class UDPImpl
    {
        // ── Methods ──
        public void SetNativeStore(){} // RVA: 0x358740
        public void Initialize(){} // RVA: 0x2DEE30
        public void RetrieveProducts(){} // RVA: 0x7234F70
        public void Purchase(){} // RVA: 0x72351B0
        public void OnPurchaseDeferred(){} // RVA: 0x72353C0
        public void FinishTransaction(){} // RVA: 0x7235500
        public void DictionaryToStringProperty(){} // RVA: 0x7235590
        public void .ctor(){} // RVA: 0x7235770
    }

    public class UDPReflectionUtils
    {
        // ── Methods ──
        public void GetTypeByName(){} // RVA: 0x7236700
        public void GetAllAssemblies(){} // RVA: 0x7236DF0
        public void GetTypes(){} // RVA: 0x7236E50
        public void .cctor(){} // RVA: 0x7236F90
    }

    public class UIFakeStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x723FFD0
        public void StartUI(){} // RVA: 0x723FFE0 | overloaded x2
        public void InstantiateDialog(){} // RVA: 0x7240260
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7240590
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7240820
        public void EnsureEventSystemCreated(){} // RVA: 0x7240920
        public void ConfigureDialogWindow(){} // RVA: 0x7240A30
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7240BD0
        public void CreateEventSystem(){} // RVA: 0x7240E20
        public void CreatePurchaseQuestion(){} // RVA: 0x7241090
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7241100
        public void OkayButtonClicked(){} // RVA: 0x72414F0
        public void CancelButtonClicked(){} // RVA: 0x72415A0
        public void DropdownValueChanged(){} // RVA: 0x1AE6D80
        public void CloseDialog(){} // RVA: 0x7241630
        public void IsShowingDialog(){} // RVA: 0x5A57230
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x5A57240
    }

    public class UIFakeStoreDropdown
    {
        // ── Methods ──
        public void DoPopup(){} // RVA: 0x7241820
        public void OnOptionSelected(){} // RVA: 0x7241AC0
        public void SetOptions(){} // RVA: 0x7241B50
        public void SetSelectionAction(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UIFakeStoreWindow
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7241C20
        public void CreateCenteredWindowRect(){} // RVA: 0x7241F10
        public void DoMainGUI(){} // RVA: 0x72420A0
        public void DoDropDown(){} // RVA: 0x72422B0
        public void OnOkClicked(){} // RVA: 0x4F3F610
        public void OnCancelClicked(){} // RVA: 0x72422C0
        public void ConfigureMainDialogText(){} // RVA: 0x6F5F8B0
        public void ConfigureDropdownOptions(){} // RVA: 0x72422E0
        public void OnDropdown(){} // RVA: 0x7242520
        public void AssignCallbacks(){} // RVA: 0x72425A0
        public void .ctor(){} // RVA: 0x72426C0
    }

    public class UdpIapBridgeInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7238050
        public void GetInitMethod(){} // RVA: 0x7238190
        public void GetPurchaseMethod(){} // RVA: 0x7238270
        public void GetRetrieveProductsMethod(){} // RVA: 0x7238350
        public void GetFinishTransactionMethod(){} // RVA: 0x7238430
    }

    public class UnifiedReceipt
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnifiedReceiptFormatter
    {
        // ── Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x721A660
    }

    public class UnityActivity
    {
        // ── Methods ──
        public void GetUnityPlayerClass(){} // RVA: 0x721E3A0
        public void GetCurrentActivity(){} // RVA: 0x721E4B0
    }

    public class UnityPurchasing
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x72199D0 | overloaded x2
        public void GenerateUnityAnalytics(){} // RVA: 0x72198E0
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7219920
        public void FetchAndMergeProducts(){} // RVA: 0x7219FE0
    }

    public class UnityPurchasingCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6251220
        public void Invoke(){} // RVA: 0x6251300
    }

    public class UnityServicesInitializationChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void CheckAndLogWarning(){} // RVA: 0x7214720
        public void IsUninitialized(){} // RVA: 0x72147E0
        public void LogWarning(){} // RVA: 0x72148A0
    }

    public class UserInfoInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7238510
    }

}