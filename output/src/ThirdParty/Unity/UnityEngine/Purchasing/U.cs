// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 15
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF9CE2BC0
    }

    public class UDPBindings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CE2C70
        public void Initialize(){} // RVA: 0x7FFAF9CE2D90
        public void Purchase(){} // RVA: 0x7FFAF9CE4C90 | overloaded x2
        public void RetrieveProducts(){} // RVA: 0x7FFAF9CE4C50 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFAF9CE4CD0 | overloaded x2
        public void OnInventoryQueried(){} // RVA: 0x7FFAF9CE3AD0
        public void StringPropertyToDictionary(){} // RVA: 0x7FFAF9CE4D10
    }

    public class UDPImpl
    {
        // ── Methods ──
        public void SetNativeStore(){} // RVA: 0x7FFAF2E08740
        public void Initialize(){} // RVA: 0x7FFAF2D8EE30
        public void RetrieveProducts(){} // RVA: 0x7FFAF9CE4F70
        public void Purchase(){} // RVA: 0x7FFAF9CE51B0
        public void OnPurchaseDeferred(){} // RVA: 0x7FFAF9CE53C0
        public void FinishTransaction(){} // RVA: 0x7FFAF9CE5500
        public void DictionaryToStringProperty(){} // RVA: 0x7FFAF9CE5590
        public void .ctor(){} // RVA: 0x7FFAF9CE5770
    }

    public class UDPReflectionUtils
    {
        // ── Methods ──
        public void GetTypeByName(){} // RVA: 0x7FFAF9CE6700
        public void GetAllAssemblies(){} // RVA: 0x7FFAF9CE6DF0
        public void GetTypes(){} // RVA: 0x7FFAF9CE6E50
        public void .cctor(){} // RVA: 0x7FFAF9CE6F90
    }

    public class UIFakeStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CEFFD0
        public void StartUI(){} // RVA: 0x7FFAF9CEFFE0 | overloaded x2
        public void InstantiateDialog(){} // RVA: 0x7FFAF9CF0260
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7FFAF9CF0590
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7FFAF9CF0820
        public void EnsureEventSystemCreated(){} // RVA: 0x7FFAF9CF0920
        public void ConfigureDialogWindow(){} // RVA: 0x7FFAF9CF0A30
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7FFAF9CF0BD0
        public void CreateEventSystem(){} // RVA: 0x7FFAF9CF0E20
        public void CreatePurchaseQuestion(){} // RVA: 0x7FFAF9CF1090
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7FFAF9CF1100
        public void OkayButtonClicked(){} // RVA: 0x7FFAF9CF14F0
        public void CancelButtonClicked(){} // RVA: 0x7FFAF9CF15A0
        public void DropdownValueChanged(){} // RVA: 0x7FFAF4596D80
        public void CloseDialog(){} // RVA: 0x7FFAF9CF1630
        public void IsShowingDialog(){} // RVA: 0x7FFAF8507230
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x7FFAF8507240
    }

    public class UIFakeStoreDropdown
    {
        // ── Methods ──
        public void DoPopup(){} // RVA: 0x7FFAF9CF1820
        public void OnOptionSelected(){} // RVA: 0x7FFAF9CF1AC0
        public void SetOptions(){} // RVA: 0x7FFAF9CF1B50
        public void SetSelectionAction(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UIFakeStoreWindow
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFAF9CF1C20
        public void CreateCenteredWindowRect(){} // RVA: 0x7FFAF9CF1F10
        public void DoMainGUI(){} // RVA: 0x7FFAF9CF20A0
        public void DoDropDown(){} // RVA: 0x7FFAF9CF22B0
        public void OnOkClicked(){} // RVA: 0x7FFAF79EF610
        public void OnCancelClicked(){} // RVA: 0x7FFAF9CF22C0
        public void ConfigureMainDialogText(){} // RVA: 0x7FFAF9A0F8B0
        public void ConfigureDropdownOptions(){} // RVA: 0x7FFAF9CF22E0
        public void OnDropdown(){} // RVA: 0x7FFAF9CF2520
        public void AssignCallbacks(){} // RVA: 0x7FFAF9CF25A0
        public void .ctor(){} // RVA: 0x7FFAF9CF26C0
    }

    public class UdpIapBridgeInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAF9CE8050
        public void GetInitMethod(){} // RVA: 0x7FFAF9CE8190
        public void GetPurchaseMethod(){} // RVA: 0x7FFAF9CE8270
        public void GetRetrieveProductsMethod(){} // RVA: 0x7FFAF9CE8350
        public void GetFinishTransactionMethod(){} // RVA: 0x7FFAF9CE8430
    }

    public class UnifiedReceipt
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnifiedReceiptFormatter
    {
        // ── Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x7FFAF9CCA660
    }

    public class UnityActivity
    {
        // ── Methods ──
        public void GetUnityPlayerClass(){} // RVA: 0x7FFAF9CCE3A0
        public void GetCurrentActivity(){} // RVA: 0x7FFAF9CCE4B0
    }

    public class UnityPurchasing
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF9CC99D0 | overloaded x2
        public void GenerateUnityAnalytics(){} // RVA: 0x7FFAF9CC98E0
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7FFAF9CC9920
        public void FetchAndMergeProducts(){} // RVA: 0x7FFAF9CC9FE0
    }

    public class UnityPurchasingCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8D01220
        public void Invoke(){} // RVA: 0x7FFAF8D01300
    }

    public class UnityServicesInitializationChecker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void CheckAndLogWarning(){} // RVA: 0x7FFAF9CC4720
        public void IsUninitialized(){} // RVA: 0x7FFAF9CC47E0
        public void LogWarning(){} // RVA: 0x7FFAF9CC48A0
    }

    public class UserInfoInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAF9CE8510
    }

}