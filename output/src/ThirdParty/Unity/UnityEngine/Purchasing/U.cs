// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 12
// Methods: 70

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP : Object
    {
        public object Name;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFD54DEA4C0
    }

    public class UDPBindings : Object
    {
        public object m_Bridge; // 0x10
        public System.Action`2<bool,string> m_RetrieveProductsCallbackCache; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DEA570
        public void Initialize(){} // RVA: 0x7FFD54DEA690
        public void Purchase(){} // RVA: 0x7FFD54DEC590 | overloaded x2
        public void RetrieveProducts(){} // RVA: 0x7FFD54DEC550 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFD54DEC5D0 | overloaded x2
        public void OnInventoryQueried(){} // RVA: 0x7FFD54DEB3D0
        public void StringPropertyToDictionary(){} // RVA: 0x7FFD54DEC610
    }

    public class UDPImpl : JSONStore
    {
        public UnityEngine.Purchasing.INativeUDPStore m_Bindings; // 0x48
        public object m_UserInfo; // 0x50
        public string m_LastInitError; // 0x58
        public bool m_Initialized; // 0x60
        public System.Action`1<UnityEngine.Purchasing.Product> m_DeferredCallback; // 0x68

        // ── Methods ──
        public void SetNativeStore(){} // RVA: 0x7FFD4E3BC740
        public void Initialize(){} // RVA: 0x7FFD4E342E30
        public void RetrieveProducts(){} // RVA: 0x7FFD54DEC870
        public void Purchase(){} // RVA: 0x7FFD54DECAB0
        public void OnPurchaseDeferred(){} // RVA: 0x7FFD54DECCC0
        public void FinishTransaction(){} // RVA: 0x7FFD54DECE00
        public void DictionaryToStringProperty(){} // RVA: 0x7FFD54DECE90
        public void .ctor(){} // RVA: 0x7FFD54DED070
    }

    public class UDPReflectionUtils : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Reflection.Assembly,System.Type[]> s_assemblyTypeCache;
        public System.Collections.Generic.Dictionary`2<string,System.Type> s_typeCache; // 0x8
        public string[] k_whiteListedAssemblies; // 0x10

        // ── Methods ──
        public void GetTypeByName(){} // RVA: 0x7FFD54DEE000
        public void GetAllAssemblies(){} // RVA: 0x7FFD54DEE6F0
        public void GetTypes(){} // RVA: 0x7FFD54DEE750
        public void .cctor(){} // RVA: 0x7FFD54DEE890
    }

    public class UIFakeStore : FakeStore
    {
        public UnityEngine.Purchasing.DialogRequest m_CurrentDialog; // 0x70
        public int m_LastSelectedDropdownIndex; // 0x78
        public UnityEngine.GameObject m_UIFakeStoreWindowObject; // 0x80
        public UnityEngine.GameObject m_EventSystem; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DF78D0
        public void StartUI(){} // RVA: 0x7FFD54DF78E0 | overloaded x2
        public void InstantiateDialog(){} // RVA: 0x7FFD54DF7B60
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7FFD54DF7E90
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7FFD54DF8120
        public void EnsureEventSystemCreated(){} // RVA: 0x7FFD54DF8220
        public void ConfigureDialogWindow(){} // RVA: 0x7FFD54DF8330
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7FFD54DF84D0
        public void CreateEventSystem(){} // RVA: 0x7FFD54DF8720
        public void CreatePurchaseQuestion(){} // RVA: 0x7FFD54DF8990
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7FFD54DF8A00
        public void OkayButtonClicked(){} // RVA: 0x7FFD54DF8DF0
        public void CancelButtonClicked(){} // RVA: 0x7FFD54DF8EA0
        public void DropdownValueChanged(){} // RVA: 0x7FFD4F9B63A0
        public void CloseDialog(){} // RVA: 0x7FFD54DF8F30
        public void IsShowingDialog(){} // RVA: 0x7FFD5360E650
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x7FFD4F8EB460
    }

    public class UIFakeStoreDropdown : Object
    {
        public System.Collections.Generic.List`1<string> m_Options; // 0x10
        public System.Action`2<int,string> m_OnDropdown; // 0x18
        public UnityEngine.Vector2 scrollPosition; // 0x20

        // ── Methods ──
        public void DoPopup(){} // RVA: 0x7FFD54DF9120
        public void OnOptionSelected(){} // RVA: 0x7FFD54DF93C0
        public void SetOptions(){} // RVA: 0x7FFD54DF9450
        public void SetSelectionAction(){} // RVA: 0x7FFD4E3A7E80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UIFakeStoreWindow : MonoBehaviour
    {
        public string m_QueryText; // 0x20
        public string m_OkText; // 0x28
        public string m_CancelText; // 0x30
        public string m_LastSelectedOptionText; // 0x38
        public System.Action m_OnOk; // 0x40
        public System.Action m_OnCancel; // 0x48
        public System.Action`1<int> m_OnDropdown; // 0x50
        public bool m_CancelEnabled; // 0x58
        public bool m_DropdownEnabled; // 0x59
        public bool m_DoDropdown; // 0x5A
        public UnityEngine.Purchasing.UIFakeStoreDropdown m_Dropdown; // 0x60
        public UnityEngine.Vector2 scrollPosition; // 0x68
        public float k_MenuScreenRatio;

        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFD54DF9520
        public void CreateCenteredWindowRect(){} // RVA: 0x7FFD54DF9810
        public void DoMainGUI(){} // RVA: 0x7FFD54DF99A0
        public void DoDropDown(){} // RVA: 0x7FFD54DF9BB0
        public void OnOkClicked(){} // RVA: 0x7FFD52B76580
        public void OnCancelClicked(){} // RVA: 0x7FFD54DF9BC0
        public void ConfigureMainDialogText(){} // RVA: 0x7FFD54B181D0
        public void ConfigureDropdownOptions(){} // RVA: 0x7FFD54DF9BE0
        public void OnDropdown(){} // RVA: 0x7FFD54DF9E20
        public void AssignCallbacks(){} // RVA: 0x7FFD54DF9EA0
        public void .ctor(){} // RVA: 0x7FFD54DF9FC0
    }

    public class UnifiedReceipt : Object
    {
        public string Payload; // 0x10
        public string Store; // 0x18
        public string TransactionID; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnifiedReceiptFormatter : Object
    {
        // ── Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x7FFD54DD1F60
    }

    public class UnityActivity : Object
    {
        public 0x66619290 s_UnityPlayerClass;

        // ── Methods ──
        public void GetUnityPlayerClass(){} // RVA: 0x7FFD54DD5CA0
        public void GetCurrentActivity(){} // RVA: 0x7FFD54DD5DB0
    }

    public class UnityPurchasing : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD54DD12D0 | overloaded x2
        public void GenerateUnityAnalytics(){} // RVA: 0x7FFD54DD11E0
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7FFD54DD1220
        public void FetchAndMergeProducts(){} // RVA: 0x7FFD54DD18E0
    }

    public class UnityServicesInitializationChecker : Object
    {
        public UnityEngine.ILogger m_Logger; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void CheckAndLogWarning(){} // RVA: 0x7FFD54DCC020
        public void IsUninitialized(){} // RVA: 0x7FFD54DCC0E0
        public void LogWarning(){} // RVA: 0x7FFD54DCC1A0
    }

}