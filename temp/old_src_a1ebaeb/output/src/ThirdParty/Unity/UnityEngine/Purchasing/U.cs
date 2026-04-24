// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 12
// Methods: 70

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP : Object
    {
        // ── Original Methods ──
        public void get_Name(){} // RVA: 0x7ffaaf3ec420
    }

    public class UDPBindings : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3ec4d0
        public void Initialize(){} // RVA: 0x7ffaaf3ec5f0
        public void Purchase(){} // RVA: 0x7ffaaf3ee4f0
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3ee4b0
        public void FinishTransaction(){} // RVA: 0x7ffaaf3ee530
        public void OnInventoryQueried(){} // RVA: 0x7ffaaf3ed330
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3ee4b0
        public void Purchase(){} // RVA: 0x7ffaaf3ee4f0
        public void FinishTransaction(){} // RVA: 0x7ffaaf3ee530
        public void StringPropertyToDictionary(){} // RVA: 0x7ffaaf3ee570
    }

    public class UDPImpl : JSONStore
    {
        public object m_LastInitError; // 0x3389DF00

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8933e30
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3ee7d0
        public void Purchase(){} // RVA: 0x7ffaaf3eea10
        public void OnPurchaseDeferred(){} // RVA: 0x7ffaaf3eec20
        public void FinishTransaction(){} // RVA: 0x7ffaaf3eed60
        public void DictionaryToStringProperty(){} // RVA: 0x7ffaaf3eedf0
        public void .ctor(){} // RVA: 0x7ffaaf3eefd0
        // ── Binary Analysis Named ──
        public void SetNativeStore(){} // RVA: 0x7ffaa89ad740
    }

    public class UDPReflectionUtils : Object
    {
        public object k_whiteListedAssemblies; // 0x33AE7150

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf3f07f0
        // ── Binary Analysis Named ──
        public void GetTypeByName(){} // RVA: 0x7ffaaf3eff60
        public void GetAllAssemblies(){} // RVA: 0x7ffaaf3f0650
        public void GetTypes(){} // RVA: 0x7ffaaf3f06b0
    }

    public class UIFakeStore : FakeStore
    {
        public object m_UIFakeStoreWindowObject; // 0x30BB31A0
        public object (00; // 0x30BB3020

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3f9830
        public void StartUI(){} // RVA: 0x7ffaaf3f9840
        public void StartUI(){} // RVA: 0x7ffaaf3f9840
        public void InstantiateDialog(){} // RVA: 0x7ffaaf3f9ac0
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7ffaaf3fa080
        public void EnsureEventSystemCreated(){} // RVA: 0x7ffaaf3fa180
        public void ConfigureDialogWindow(){} // RVA: 0x7ffaaf3fa290
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7ffaaf3fa430
        public void CreateEventSystem(){} // RVA: 0x7ffaaf3fa680
        public void CreatePurchaseQuestion(){} // RVA: 0x7ffaaf3fa8f0
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7ffaaf3fa960
        public void OkayButtonClicked(){} // RVA: 0x7ffaaf3fad50
        public void CancelButtonClicked(){} // RVA: 0x7ffaaf3fae00
        public void DropdownValueChanged(){} // RVA: 0x7ffaa9fb1a60
        public void CloseDialog(){} // RVA: 0x7ffaaf3fae90
        public void IsShowingDialog(){} // RVA: 0x7ffaadc0f800
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x7ffaa9ed3bb0
        // ── Binary Analysis Named ──
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7ffaaf3f9df0
    }

    public class UIFakeStoreDropdown : Object
    {
        public object scrollPosition; // 0x3370F890

        // ── Original Methods ──
        public void OnOptionSelected(){} // RVA: 0x7ffaaf3fb320
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void DoPopup(){} // RVA: 0x7ffaaf3fb080
        public void SetOptions(){} // RVA: 0x7ffaaf3fb3b0
        public void SetSelectionAction(){} // RVA: 0x7ffaa8998e80
    }

    public class UIFakeStoreWindow : MonoBehaviour
    {
        public object m_CancelText; // 0x333AB5A0
        public object m_OnCancel; // 0x333AB5A0
        public object m_DropdownEnabled; // 0x333AB5A0
        public object scrollPosition; // 0x333AB5A0
        public object OnAfterDeserialize; // 0xB3F6FFF0

        // ── Original Methods ──
        public void OnGUI(){} // RVA: 0x7ffaaf3fb480
        public void CreateCenteredWindowRect(){} // RVA: 0x7ffaaf3fb770
        public void OnOkClicked(){} // RVA: 0x7ffaad1ee010
        public void OnCancelClicked(){} // RVA: 0x7ffaaf3fbb20
        public void ConfigureMainDialogText(){} // RVA: 0x7ffaaf11a1b0
        public void ConfigureDropdownOptions(){} // RVA: 0x7ffaaf3fbb40
        public void OnDropdown(){} // RVA: 0x7ffaaf3fbd80
        public void AssignCallbacks(){} // RVA: 0x7ffaaf3fbe00
        public void .ctor(){} // RVA: 0x7ffaaf3fbf20
        // ── Binary Analysis Named ──
        public void DoMainGUI(){} // RVA: 0x7ffaaf3fb900
        public void DoDropDown(){} // RVA: 0x7ffaaf3fbb10
    }

    public class UnifiedReceipt : Object
    {
        public object TransactionID; // 0x333DCB60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnifiedReceiptFormatter : Object
    {
        // ── Original Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x7ffaaf3d3ec0
    }

    public class UnityActivity : Object
    {
        // ── Binary Analysis Named ──
        public void GetUnityPlayerClass(){} // RVA: 0x7ffaaf3d7c00
        public void GetCurrentActivity(){} // RVA: 0x7ffaaf3d7d10
    }

    public class UnityPurchasing : Object
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf3d3230
        public void GenerateUnityAnalytics(){} // RVA: 0x7ffaaf3d3140
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7ffaaf3d3180
        public void Initialize(){} // RVA: 0x7ffaaf3d3230
        public void FetchAndMergeProducts(){} // RVA: 0x7ffaaf3d3840
    }

    public class UnityServicesInitializationChecker : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void IsUninitialized(){} // RVA: 0x7ffaaf3ce040
        public void LogWarning(){} // RVA: 0x7ffaaf3ce100
        // ── Binary Analysis Named ──
        public void CheckAndLogWarning(){} // RVA: 0x7ffaaf3cdf80
    }

}