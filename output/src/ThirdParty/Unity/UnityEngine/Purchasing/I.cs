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
        public void SendTransactionEvent(){} // RVA: 0x7FFAF2AD4B10
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IAnalyticsClient
    {
        // ── Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAF2AD4B10
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF2ADDC60
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
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IDetailedStoreListener
    {
        // ── Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IDs : System.Collections.IEnumerable.GetEnumerator
    {
        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF9CC3600
        public void Add(){} // RVA: 0x7FFAF9CC3700
        public void SpecificIDForStore(){} // RVA: 0x7FFAF9CC37C0
        public void GetEnumerator(){} // RVA: 0x7FFAF9CC3880
        public void .ctor(){} // RVA: 0x7FFAF9CC3980
    }

    public class IExtensionProvider
    {
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFAF2ABCD60
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFAF2ABCE10
        public void Contains(){} // RVA: 0x7FFAF2ABDE40
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IGoogleFetchPurchases
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAF2AD4B10
        public void FetchPurchases(){} // RVA: 0x7FFAF2AD4B10 | overloaded x2
    }

    public class IGooglePlayConfiguration
    {
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFAF2AD4A50
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFAF2ADF9F0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFAF2ADDC60
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFAF2ABDBE0
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFAF2ABDBE0
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAF2ABDE40
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAF2AD4B10
        public void FinishTransaction(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFAF2AD4B10
        public void RetrieveProducts(){} // RVA: 0x7FFAF2ADA620
        public void ResumeConnection(){} // RVA: 0x7FFAF2AD4A50
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class IInternalStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFAF2AD6C40
        public void ProcessPurchase(){} // RVA: 0x7FFAF2AC2590
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF2ADDC60
        public void OnInitialized(){} // RVA: 0x7FFAF2AD4B10
        public void SendTransactionEvent(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ILegacyUnityAnalytics
    {
        // ── Methods ──
        public void SendTransactionEvent(){}
        public void SendCustomEvent(){} // RVA: 0x7FFAF2ADDC60
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
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFAF2AD4B10
        public void AddTransactionObserver(){} // RVA: 0x7FFAF2AD4A50
        public void get_appReceipt(){} // RVA: 0x7FFAF2ABCD60
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFAF2AC2A40
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFAF2AD4A50
    }

    public class INativeStore
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7FFAF2AD4B10
        public void Purchase(){} // RVA: 0x7FFAF2ADDC60
        public void FinishTransaction(){} // RVA: 0x7FFAF2ADDC60
    }

    public class INativeStoreProvider
    {
        // ── Methods ──
        public void GetAndroidStore(){}
        public void GetStorekit(){} // RVA: 0x7FFAF2ABCE10
    }

    public class INativeUDPStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAF2AD4B10
        public void Purchase(){} // RVA: 0x7FFAF2ADF090
        public void RetrieveProducts(){} // RVA: 0x7FFAF2ADDC60
        public void FinishTransaction(){} // RVA: 0x7FFAF2ADDC60
    }

    public class IProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7FFAF2ABCD60
    }

    public class IStoreController
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFAF2ABCD60
        public void InitiatePurchase(){} // RVA: 0x7FFAF2AD4B10
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IStoreExtension
    {
    }

    public class IStoreInternal
    {
        // ── Methods ──
        public void SetModule(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFAF2AD6C40
        public void ProcessPurchase(){} // RVA: 0x7FFAF2AC2590
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF2ADBAA0
        public void OnInitialized(){} // RVA: 0x7FFAF2ADDC60
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
        public void CheckAndLogWarning(){} // RVA: 0x7FFAF2AD4A50
    }

    public class InvalidProductTypeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CFA850
    }

    public class InventoryInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAF9CE72B0
        public void GetProductListMethod(){} // RVA: 0x7FFAF9CE73F0
        public void GetPurchaseInfoMethod(){} // RVA: 0x7FFAF9CE74D0
        public void HasPurchaseMethod(){} // RVA: 0x7FFAF9CE75B0
    }

    public class iOSStoreBindings
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFAF9CC2A30
        public void AddTransactionObserver(){} // RVA: 0x7FFAF9CC2A70
        public void RetrieveProducts(){} // RVA: 0x7FFAF9CC2AB0
        public void Purchase(){} // RVA: 0x7FFAF9CC2AF0
        public void FinishTransaction(){} // RVA: 0x7FFAF9CC2B30
        public void get_appReceipt(){} // RVA: 0x7FFAF9CC2B70
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFAF9CC2BB0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFAF9CC2BF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}