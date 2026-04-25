// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 40
// Methods: 78

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class IAmazonConfiguration
    {
    }

    public class IAmazonExtensions
    {
    }

    public class IAnalyticsAdapter
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7FFAC2C70A40
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFAC2C79B30
    }

    public class IAnalyticsClient
    {
        // ── Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAC2C70A40
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC2C79B30
    }

    public class IAndroidStoreSelection
    {
    }

    public class IAppleConfiguration
    {
    }

    public class IAppleExtensions
    {
    }

    public class ICoreServicesEnvironmentObserver
    {
        // ── Methods ──
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFAC2C70A40
    }

    public class IDetailedStoreListener
    {
        // ── Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC2C79B30
    }

    public class IDs : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> m_Dic; // 0x10

        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC99AAF00
        public void Add(){} // RVA: 0x7FFAC99AB000
        public void SpecificIDForStore(){} // RVA: 0x7FFAC99AB0C0
        public void GetEnumerator(){} // RVA: 0x7FFAC99AB180
        public void .ctor(){} // RVA: 0x7FFAC99AB280
    }

    public class IExtensionProvider
    {
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFAC2C58E90
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFAC2C58F40
        public void Contains(){} // RVA: 0x7FFAC2C59F60
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFAC2C70A40
    }

    public class IGoogleFetchPurchases
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAC2C70A40
        public void FetchPurchases(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
    }

    public class IGooglePlayConfiguration
    {
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFAC2C70980
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFAC2C7B8C0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFAC2C79B30
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFAC2C59D00
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFAC2C59D00
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAC2C59F60
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAC2C70A40
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAC2C70A40
        public void FinishTransaction(){} // RVA: 0x7FFAC2C79B30
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x7FFAC2C70A40
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAC2C70A40
        public void RetrieveProducts(){} // RVA: 0x7FFAC2C76500
        public void ResumeConnection(){} // RVA: 0x7FFAC2C70980
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFAC2C59D00
    }

    public class IInternalStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFAC2C72BC0
        public void ProcessPurchase(){} // RVA: 0x7FFAC2C5E6B0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC2C79B30
        public void OnInitialized(){} // RVA: 0x7FFAC2C70A40
        public void SendTransactionEvent(){} // RVA: 0x7FFAC2C70A40
    }

    public class ILegacyUnityAnalytics
    {
        // ── Methods ──
        public void SendTransactionEvent(){}
        public void SendCustomEvent(){} // RVA: 0x7FFAC2C79B30
    }

    public class IMicrosoftConfiguration
    {
    }

    public class IMicrosoftExtensions
    {
    }

    public class INativeAppleStore
    {
        public object appReceipt;
        public object appReceiptModificationDate;

        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFAC2C70A40
        public void AddTransactionObserver(){} // RVA: 0x7FFAC2C70980
        public void get_appReceipt(){} // RVA: 0x7FFAC2C58E90
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFAC2C5EB60
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFAC2C70980
    }

    public class INativeStore
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7FFAC2C70A40
        public void Purchase(){} // RVA: 0x7FFAC2C79B30
        public void FinishTransaction(){} // RVA: 0x7FFAC2C79B30
    }

    public class INativeStoreProvider
    {
        // ── Methods ──
        public void GetAndroidStore(){}
        public void GetStorekit(){} // RVA: 0x7FFAC2C58F40
    }

    public class INativeUDPStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC2C70A40
        public void Purchase(){} // RVA: 0x7FFAC2C7AF60
        public void RetrieveProducts(){} // RVA: 0x7FFAC2C79B30
        public void FinishTransaction(){} // RVA: 0x7FFAC2C79B30
    }

    public class IProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7FFAC2C58E90
    }

    public class IStoreController
    {
        public object products;

        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFAC2C58E90
        public void InitiatePurchase(){} // RVA: 0x7FFAC2C70A40
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFAC2C70A40
    }

    public class IStoreExtension
    {
    }

    public class IStoreInternal
    {
        // ── Methods ──
        public void SetModule(){} // RVA: 0x7FFAC2C70A40
    }

    public class IStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFAC2C72BC0
        public void ProcessPurchase(){} // RVA: 0x7FFAC2C5E6B0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC2C77970
        public void OnInitialized(){} // RVA: 0x7FFAC2C79B30
    }

    public class ITransactionHistoryExtensions
    {
    }

    public class IUDPExtensions
    {
    }

    public class IUnityCallback
    {
    }

    public class IUnityServicesInitializationChecker
    {
        // ── Methods ──
        public void CheckAndLogWarning(){} // RVA: 0x7FFAC2C70980
    }

    public class InvalidProductTypeException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99E2150
    }

    public class InventoryInterface : Object
    {
        public System.Type s_typeCache;

        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAC99CEBB0
        public void GetProductListMethod(){} // RVA: 0x7FFAC99CECF0
        public void GetPurchaseInfoMethod(){} // RVA: 0x7FFAC99CEDD0
        public void HasPurchaseMethod(){} // RVA: 0x7FFAC99CEEB0
    }

    public class iOSStoreBindings : Object
    {
        public object appReceipt;
        public object appReceiptModificationDate;

        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFAC99AA330
        public void AddTransactionObserver(){} // RVA: 0x7FFAC99AA370
        public void RetrieveProducts(){} // RVA: 0x7FFAC99AA3B0
        public void Purchase(){} // RVA: 0x7FFAC99AA3F0
        public void FinishTransaction(){} // RVA: 0x7FFAC99AA430
        public void get_appReceipt(){} // RVA: 0x7FFAC99AA470
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFAC99AA4B0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFAC99AA4F0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}