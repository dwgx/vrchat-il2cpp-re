// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 15
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class UDP : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE87D72D60
    }

    public class UDPBindings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D72E10
        public void Initialize(){} // RVA: 0x7FFE87D72F30
        public void Purchase(){} // RVA: 0x7FFE87D74E30 | overloaded x2
        public void RetrieveProducts(){} // RVA: 0x7FFE87D74DF0 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFE87D74E70 | overloaded x2
        public void OnInventoryQueried(){} // RVA: 0x7FFE87D73C70
        public void StringPropertyToDictionary(){} // RVA: 0x7FFE87D74EB0
    }

    public class UDPImpl : JSONStore
    {
        // ── Methods ──
        public void SetNativeStore(){} // RVA: 0x7FFE81176740
        public void Initialize(){} // RVA: 0x7FFE810FCE30
        public void RetrieveProducts(){} // RVA: 0x7FFE87D75110
        public void Purchase(){} // RVA: 0x7FFE87D75350
        public void OnPurchaseDeferred(){} // RVA: 0x7FFE87D75560
        public void FinishTransaction(){} // RVA: 0x7FFE87D756A0
        public void DictionaryToStringProperty(){} // RVA: 0x7FFE87D75730
        public void .ctor(){} // RVA: 0x7FFE87D75910
    }

    public class UDPReflectionUtils : Object
    {
        // ── Methods ──
        public void GetTypeByName(){} // RVA: 0x7FFE87D768A0
        public void GetAllAssemblies(){} // RVA: 0x7FFE87D76FA0
        public void GetTypes(){} // RVA: 0x7FFE87D76FF0
        public void .cctor(){} // RVA: 0x7FFE87D77130
    }

    public class UIFakeStore : FakeStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D80170
        public void StartUI(){} // RVA: 0x7FFE87D80180 | overloaded x2
        public void InstantiateDialog(){} // RVA: 0x7FFE87D80400
        public void GetOrCreateFakeStoreWindow(){} // RVA: 0x7FFE87D80730
        public void AddLifeCycleNotifierAndSetDestroyCallback(){} // RVA: 0x7FFE87D809C0
        public void EnsureEventSystemCreated(){} // RVA: 0x7FFE87D80AC0
        public void ConfigureDialogWindow(){} // RVA: 0x7FFE87D80BD0
        public void ConfigureDialogWindowCallbacks(){} // RVA: 0x7FFE87D80D70
        public void CreateEventSystem(){} // RVA: 0x7FFE87D80FC0
        public void CreatePurchaseQuestion(){} // RVA: 0x7FFE87D81230
        public void CreateRetrieveProductsQuestion(){} // RVA: 0x7FFE87D812A0
        public void OkayButtonClicked(){} // RVA: 0x7FFE87D81690
        public void CancelButtonClicked(){} // RVA: 0x7FFE87D81740
        public void DropdownValueChanged(){} // RVA: 0x7FFE82862F10
        public void CloseDialog(){} // RVA: 0x7FFE87D817D0
        public void IsShowingDialog(){} // RVA: 0x7FFE86597F90
        public void <AddLifeCycleNotifierAndSetDestroyCallback>b__14_0(){} // RVA: 0x7FFE812D43E0
    }

    public class UIFakeStoreDropdown : Object
    {
        // ── Methods ──
        public void DoPopup(){} // RVA: 0x7FFE87D819C0
        public void OnOptionSelected(){} // RVA: 0x7FFE87D81C60
        public void SetOptions(){} // RVA: 0x7FFE87D81CF0
        public void SetSelectionAction(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UIFakeStoreWindow : MonoBehaviour
    {
        // ── Methods ──
        public void OnGUI(){} // RVA: 0x7FFE87D81DC0
        public void CreateCenteredWindowRect(){} // RVA: 0x7FFE87D820B0
        public void DoMainGUI(){} // RVA: 0x7FFE87D82240
        public void DoDropDown(){} // RVA: 0x7FFE87D82450
        public void OnOkClicked(){} // RVA: 0x7FFE85C0D3C0
        public void OnCancelClicked(){} // RVA: 0x7FFE87D82460
        public void ConfigureMainDialogText(){} // RVA: 0x7FFE87AA0740
        public void ConfigureDropdownOptions(){} // RVA: 0x7FFE87D82480
        public void OnDropdown(){} // RVA: 0x7FFE87D826C0
        public void AssignCallbacks(){} // RVA: 0x7FFE87D82740
        public void .ctor(){} // RVA: 0x7FFE87D82860
    }

    public class UdpIapBridgeInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFE87D781F0
        public void GetInitMethod(){} // RVA: 0x7FFE87D78330
        public void GetPurchaseMethod(){} // RVA: 0x7FFE87D78410
        public void GetRetrieveProductsMethod(){} // RVA: 0x7FFE87D784F0
        public void GetFinishTransactionMethod(){} // RVA: 0x7FFE87D785D0
    }

    public class UnifiedReceipt : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnifiedReceiptFormatter : Object
    {
        // ── Methods ──
        public void FormatUnifiedReceipt(){} // RVA: 0x7FFE87D5A800
    }

    public class UnityActivity : Object
    {
        // ── Methods ──
        public void GetUnityPlayerClass(){} // RVA: 0x7FFE87D5E540
        public void GetCurrentActivity(){} // RVA: 0x7FFE87D5E650
    }

    public class UnityPurchasing : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE87D59B70 | overloaded x2
        public void GenerateUnityAnalytics(){} // RVA: 0x7FFE87D59A80
        public void GenerateLegacyUnityAnalytics(){} // RVA: 0x7FFE87D59AC0
        public void FetchAndMergeProducts(){} // RVA: 0x7FFE87D5A180
    }

    public class UnityPurchasingCallback : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D91C40
        public void Invoke(){} // RVA: 0x7FFE86D91D20
    }

    public class UnityServicesInitializationChecker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void CheckAndLogWarning(){} // RVA: 0x7FFE87D548C0
        public void IsUninitialized(){} // RVA: 0x7FFE87D54980
        public void LogWarning(){} // RVA: 0x7FFE87D54A40
    }

    public class UserInfoInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFE87D786B0
    }

}