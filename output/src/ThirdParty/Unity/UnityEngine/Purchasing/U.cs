// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 15
// Methods: 75

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7AF011F90
    }

    public class UDPBindings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF012040
        public void Initialize(){} // RVA: 0x7AF012160
        public void Purchase(){} // RVA: 0x7AF014070
        public void RetrieveProducts(){} // RVA: 0x7AF014030
        public void FinishTransaction(){} // RVA: 0x7AF0140B0
        public void OnInventoryQueried(){} // RVA: 0x7AF012EB0
        public void StringPropertyToDictionary(){} // RVA: 0x7AF0140F0
    }

    public class UDPImpl : JSONStore
    {
        // ── Methods ──
        public void SetNativeStore(){} // RVA: 0x7A8152D90
        public void Initialize(){} // RVA: 0x7A80D8E20
        public void RetrieveProducts(){} // RVA: 0x7AF014360
        public void Purchase(){} // RVA: 0x7AF0145A0
        public void OnPurchaseDeferred(){} // RVA: 0x7AF0147C0
        public void FinishTransaction(){} // RVA: 0x7AF014900
        public void DictionaryToStringProperty(){} // RVA: 0x7AF014990
        public void .ctor(){} // RVA: 0x7AF014B80
    }

    public class UDPReflectionUtils : Object
    {
        // ── Methods ──
        public void GetTypeByName(){} // RVA: 0x7AF015B30
        public void GetAllAssemblies(){} // RVA: 0x7AF016220
        public void GetTypes(){} // RVA: 0x7AF016280
        public void .cctor(){} // RVA: 0x7AF0163C0
        public void s_assemblyTypeCache(){} // RVA: 0x7B3FB4428
    }

    public class UIFakeStore : FakeStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF01F630
        public void StartUI(){} // RVA: 0x7AF01F640
        public void InstantiateDialog(){} // RVA: 0x7AF01F8C0
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7AF01FD50
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7AF01FFE0
        public void EnsureEventSystemCreated(){} // RVA: 0x7AF0200E0
        public void ConfigureDialogWindow(){} // RVA: 0x7AF0201F0
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7AF0203A0
        public void CreateEventSystem(){} // RVA: 0x7AF0205F0
        public void CreatePurchaseQuestion(){} // RVA: 0x7AF020860
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7AF0208D0
        public void OkayButtonClicked(){} // RVA: 0x7AF020CB0
        public void CancelButtonClicked(){} // RVA: 0x7AF020D60
        public void DropdownValueChanged(){} // RVA: 0x7A98A0B60
        public void CloseDialog(){} // RVA: 0x7AF020DF0
        public void IsShowingDialog(){} // RVA: 0x7AD843BB0
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x7AD843BC0
    }

    public class UIFakeStoreDropdown : Object
    {
        // ── Methods ──
        public void DoPopup(){} // RVA: 0x7AF020FE0
        public void OnOptionSelected(){} // RVA: 0x7AF0212A0
        public void SetOptions(){} // RVA: 0x7AF021330
        public void SetSelectionAction(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
        // ── Unresolved (hash) ──
        public void m_Options(){} // RVA: 0x7B2E3E010
    }

    public class UIFakeStoreWindow : MonoBehaviour
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7AF021400
        public void CreateCenteredWindowRect(){} // RVA: 0x7AF0216F0
        public void DoMainGUI(){} // RVA: 0x7AF021880
        public void DoDropDown(){} // RVA: 0x7AF021A90
        public void OnOkClicked(){} // RVA: 0x7ACC6FA20
        public void OnCancelClicked(){} // RVA: 0x7AF021AA0
        public void ConfigureMainDialogText(){} // RVA: 0x7AED3DDB0
        public void ConfigureDropdownOptions(){} // RVA: 0x7AF021AC0
        public void OnDropdown(){} // RVA: 0x7AF021D00
        public void AssignCallbacks(){} // RVA: 0x7AF021D80
        public void .ctor(){} // RVA: 0x7AF021EA0
    }

    public class UdpIapBridgeInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7AF017480
        public void GetInitMethod(){} // RVA: 0x7AF0175C0
        public void GetPurchaseMethod(){} // RVA: 0x7AF0176A0
        public void GetRetrieveProductsMethod(){} // RVA: 0x7AF017780
        public void GetFinishTransactionMethod(){} // RVA: 0x7AF017860
    }

    public class UnifiedReceipt : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnifiedReceiptFormatter : Object
    {
        // ── Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x7AEFF9B20
    }

    public class UnityActivity : Object
    {
        // ── Methods ──
        public void GetUnityPlayerClass(){} // RVA: 0x7AEFFD830
        public void GetCurrentActivity(){} // RVA: 0x7AEFFD940
    }

    public class UnityPurchasing : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AEFF8E50
        public void GenerateUnityAnalytics(){} // RVA: 0x7AEFF8D60
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7AEFF8DA0
        public void FetchAndMergeProducts(){} // RVA: 0x7AEFF9460
    }

    public class UnityPurchasingCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE03D150
        public void Invoke(){} // RVA: 0x7AE03D240
    }

    public class UnityServicesInitializationChecker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void CheckAndLogWarning(){} // RVA: 0x7AEFF3B80
        public void IsUninitialized(){} // RVA: 0x7AEFF3C40
        public void LogWarning(){} // RVA: 0x7AEFF3D00
    }

    public class UserInfoInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7AF017940
    }

}