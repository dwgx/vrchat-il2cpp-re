// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 15
// Methods: 73

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7D855A0
    }

    public class UDPBindings : Object
    {
        public object m_Bridge;
        public object m_RetrieveProductsCallbackCache;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D855F0
        public void Initialize(){} // RVA: 0x7D856F0
        public void Purchase(){} // RVA: 0x7D875B0
        public void RetrieveProducts(){} // RVA: 0x7D87570
        public void FinishTransaction(){} // RVA: 0x7D875F0
        public void OnInventoryQueried(){} // RVA: 0x7D86440
        public void StringPropertyToDictionary(){} // RVA: 0x7D87630
    }

    public class UDPImpl : JSONStore
    {
        public object m_Bindings;
        public object m_UserInfo;
        public object m_LastInitError;
        public object m_Initialized;
        public object m_DeferredCallback;

        // ── Methods ──
        public void SetNativeStore(){} // RVA: 0xBBF900
        public void Initialize(){} // RVA: 0xB44D60
        public void RetrieveProducts(){} // RVA: 0x7D87850
        public void Purchase(){} // RVA: 0x7D87A90
        public void OnPurchaseDeferred(){} // RVA: 0x7D87CB0
        public void FinishTransaction(){} // RVA: 0x7D87DF0
        public void DictionaryToStringProperty(){} // RVA: 0x7D87E80
        public void .ctor(){} // RVA: 0x7D88030
    }

    public class UDPReflectionUtils : Object
    {
        public object s_assemblyTypeCache;
        public object s_typeCache;
        public object k_whiteListedAssemblies;

        // ── Methods ──
        public void GetTypeByName(){} // RVA: 0x7D88F80
        public void GetAllAssemblies(){} // RVA: 0x7D89670
        public void GetTypes(){} // RVA: 0x7D896D0
        public void .cctor(){} // RVA: 0x7D89810
    }

    public class UIFakeStore : FakeStore
    {
        public object m_CurrentDialog;
        public object m_LastSelectedDropdownIndex;
        public object m_UIFakeStoreWindowObject;
        public object m_EventSystem;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D92A90
        public void StartUI(){} // RVA: 0x7D92AA0
        public void InstantiateDialog(){} // RVA: 0x7D92D20
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7D93130
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7D933D0
        public void EnsureEventSystemCreated(){} // RVA: 0x7D934D0
        public void ConfigureDialogWindow(){} // RVA: 0x7D935E0
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7D93790
        public void CreateEventSystem(){} // RVA: 0x7D939E0
        public void CreatePurchaseQuestion(){} // RVA: 0x7D93BD0
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7D93C40
        public void OkayButtonClicked(){} // RVA: 0x7D94000
        public void CancelButtonClicked(){} // RVA: 0x7D940B0
        public void DropdownValueChanged(){} // RVA: 0x23B2A80
        public void CloseDialog(){} // RVA: 0x7D94140
        public void IsShowingDialog(){} // RVA: 0x64D1440
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x64D1450
    }

    public class UIFakeStoreDropdown : Object
    {
        public object m_Options;
        public object m_OnDropdown;
        public object scrollPosition;

        // ── Methods ──
        public void DoPopup(){} // RVA: 0x7D94360
        public void OnOptionSelected(){} // RVA: 0x7D94620
        public void SetOptions(){} // RVA: 0x7D946B0
        public void SetSelectionAction(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UIFakeStoreWindow : MonoBehaviour
    {
        public object m_QueryText;
        public object m_OkText;
        public object m_CancelText;
        public object m_LastSelectedOptionText;
        public object m_OnOk;
        public object m_OnCancel;
        public object m_OnDropdown;
        public object m_CancelEnabled;
        public object m_DropdownEnabled;
        public object m_DoDropdown;
        public object m_Dropdown;
        public object scrollPosition;
        public object k_MenuScreenRatio;

        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7D94780
        public void CreateCenteredWindowRect(){} // RVA: 0x7D94A70
        public void DoMainGUI(){} // RVA: 0x7D94C00
        public void DoDropDown(){} // RVA: 0x7D94E10
        public void OnOkClicked(){} // RVA: 0x593C1E0
        public void OnCancelClicked(){} // RVA: 0x7D94E20
        public void ConfigureMainDialogText(){} // RVA: 0x79AA870
        public void ConfigureDropdownOptions(){} // RVA: 0x7D94E40
        public void OnDropdown(){} // RVA: 0x7D95080
        public void AssignCallbacks(){} // RVA: 0x7D95100
        public void .ctor(){} // RVA: 0x7D95220
    }

    public class UdpIapBridgeInterface : Object
    {
        public object s_typeCache;

        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7D8AA20
        public void GetInitMethod(){} // RVA: 0x7D8AB50
        public void GetPurchaseMethod(){} // RVA: 0x7D8AC30
        public void GetRetrieveProductsMethod(){} // RVA: 0x7D8AD10
        public void GetFinishTransactionMethod(){} // RVA: 0x7D8ADF0
    }

    public class UnifiedReceipt : Object
    {
        public object Payload;
        public object Store;
        public object TransactionID;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnifiedReceiptFormatter : Object
    {
        // ── Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x7D6D210
    }

    public class UnityActivity : Object
    {
        public object s_UnityPlayerClass;

        // ── Methods ──
        public void GetUnityPlayerClass(){} // RVA: 0x7D70F10
        public void GetCurrentActivity(){} // RVA: 0x7D71020
    }

    public class UnityPurchasing : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7D6C540
        public void GenerateUnityAnalytics(){} // RVA: 0x7D6C450
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7D6C490
        public void FetchAndMergeProducts(){} // RVA: 0x7D6CB50
    }

    public class UnityPurchasingCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6CBE570
        public void Invoke(){} // RVA: 0x6CBE660
    }

    public class UnityServicesInitializationChecker : Object
    {
        public object m_Logger;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void CheckAndLogWarning(){} // RVA: 0x7D67320
        public void IsUninitialized(){} // RVA: 0x7D673E0
        public void LogWarning(){} // RVA: 0x7D674A0
    }

    public class UserInfoInterface : Object
    {
        public object s_typeCache;

        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7D8AED0
    }

}