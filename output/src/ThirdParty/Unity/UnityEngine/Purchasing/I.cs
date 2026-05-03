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
        public void SendTransactionEvent(){} // RVA: 0x7FFE80E460A0
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFE80E4F230
    }

    public class IAnalyticsClient
    {
        // ── Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE80E460A0
        public void OnPurchaseFailed(){} // RVA: 0x7FFE80E4F230
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
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFE80E460A0
    }

    public class IDetailedStoreListener
    {
        // ── Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x7FFE80E4F230
    }

    public class IDs : Object
    {
        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE87D537A0
        public void Add(){} // RVA: 0x7FFE87D538A0
        public void SpecificIDForStore(){} // RVA: 0x7FFE87D53960
        public void GetEnumerator(){} // RVA: 0x7FFE87D53A20
        public void .ctor(){} // RVA: 0x7FFE87D53B20
    }

    public class IExtensionProvider
    {
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFE80E2E2E0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFE80E2E390
        public void Contains(){} // RVA: 0x7FFE80E2F3B0
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFE80E460A0
    }

    public class IGoogleFetchPurchases
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFE80E460A0
        public void FetchPurchases(){} // RVA: 0x7FFE80E460A0 | overloaded x2
    }

    public class IGooglePlayConfiguration
    {
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFE80E45FE0
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFE80E50FC0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFE80E4F230
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFE80E2F150
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFE80E2F150
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFE80E46530
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFE80E460A0
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFE80E460A0
        public void FinishTransaction(){} // RVA: 0x7FFE80E4F230
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x7FFE80E460A0
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFE80E460A0
        public void RetrieveProducts(){} // RVA: 0x7FFE80E4BC00
        public void ResumeConnection(){} // RVA: 0x7FFE80E45FE0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFE80E2F150
    }

    public class IInternalStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFE80E48220
        public void ProcessPurchase(){} // RVA: 0x7FFE80E33B00
        public void OnPurchaseFailed(){} // RVA: 0x7FFE80E4F230
        public void OnInitialized(){} // RVA: 0x7FFE80E460A0
        public void SendTransactionEvent(){} // RVA: 0x7FFE80E460A0
    }

    public class ILegacyUnityAnalytics
    {
        // ── Methods ──
        public void SendTransactionEvent(){}
        public void SendCustomEvent(){} // RVA: 0x7FFE80E4F230
    }

    public class IMicrosoftConfiguration
    {
    }

    public class IMicrosoftExtensions
    {
    }

    public class INativeAppleStore
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFE80E460A0
        public void AddTransactionObserver(){} // RVA: 0x7FFE80E45FE0
        public void get_appReceipt(){} // RVA: 0x7FFE80E2E2E0
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFE80E33FB0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFE80E45FE0
    }

    public class INativeStore
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7FFE80E460A0
        public void Purchase(){} // RVA: 0x7FFE80E4F230
        public void FinishTransaction(){} // RVA: 0x7FFE80E4F230
    }

    public class INativeStoreProvider
    {
        // ── Methods ──
        public void GetAndroidStore(){}
        public void GetStorekit(){} // RVA: 0x7FFE80E2E390
    }

    public class INativeUDPStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE80E460A0
        public void Purchase(){} // RVA: 0x7FFE80E50660
        public void RetrieveProducts(){} // RVA: 0x7FFE80E4F230
        public void FinishTransaction(){} // RVA: 0x7FFE80E4F230
    }

    public class IProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IStoreController
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFE80E2E2E0
        public void InitiatePurchase(){} // RVA: 0x7FFE80E460A0
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFE80E460A0
    }

    public class IStoreExtension
    {
    }

    public class IStoreInternal
    {
        // ── Methods ──
        public void SetModule(){} // RVA: 0x7FFE80E460A0
    }

    public class IStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFE80E48220
        public void ProcessPurchase(){} // RVA: 0x7FFE80E33B00
        public void OnPurchaseFailed(){} // RVA: 0x7FFE80E4D070
        public void OnInitialized(){} // RVA: 0x7FFE80E4F230
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
        public void CheckAndLogWarning(){} // RVA: 0x7FFE80E45FE0
    }

    public class InvalidProductTypeException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D8A9F0
    }

    public class InventoryInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFE87D77450
        public void GetProductListMethod(){} // RVA: 0x7FFE87D77590
        public void GetPurchaseInfoMethod(){} // RVA: 0x7FFE87D77670
        public void HasPurchaseMethod(){} // RVA: 0x7FFE87D77750
    }

    public class iOSStoreBindings : Object
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFE87D52BD0
        public void AddTransactionObserver(){} // RVA: 0x7FFE87D52C10
        public void RetrieveProducts(){} // RVA: 0x7FFE87D52C50
        public void Purchase(){} // RVA: 0x7FFE87D52C90
        public void FinishTransaction(){} // RVA: 0x7FFE87D52CD0
        public void get_appReceipt(){} // RVA: 0x7FFE87D52D10
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFE87D52D50
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFE87D52D90
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}