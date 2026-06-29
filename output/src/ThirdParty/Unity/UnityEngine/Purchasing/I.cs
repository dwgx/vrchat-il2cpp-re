// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 27
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class IAnalyticsAdapter
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x894320
        public void SendTransactionFailedEvent(){} // RVA: 0x8943B0
    }

    public class IAnalyticsClient
    {
        // ── Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x894320
        public void OnPurchaseFailed(){} // RVA: 0x8943B0
    }

    public class ICoreServicesEnvironmentObserver
    {
        // ── Methods ──
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x894320
    }

    public class IDetailedStoreListener
    {
        // ── Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x8943B0
    }

    public class IDs : Object
    {
        public object m_Dic;

        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7D661E0
        public void Add(){} // RVA: 0x7D662E0
        public void SpecificIDForStore(){} // RVA: 0x7D663B0
        public void GetEnumerator(){} // RVA: 0x7D66470
        public void .ctor(){} // RVA: 0x7D66570
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void GetCachedQueriedProducts(){} // RVA: 0x87C0A0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x87C540
        public void Contains(){} // RVA: 0x87D350
        public void AddCachedQueriedProductDetails(){} // RVA: 0x894320
    }

    public class IGoogleFetchPurchases
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x894320
        public void FetchPurchases(){} // RVA: 0x894320
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x894290
        public void NotifyDeferredPurchase(){} // RVA: 0x899870
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x8943B0
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x87D280
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x87D280
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x8944F0
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x87D350
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x894320
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x894320
        public void FinishTransaction(){} // RVA: 0x8943B0
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x894320
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x894320
        public void RetrieveProducts(){} // RVA: 0x899250
        public void ResumeConnection(){} // RVA: 0x894290
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x87D280
    }

    public class IInternalStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x895750
        public void ProcessPurchase(){} // RVA: 0x87D050
        public void OnPurchaseFailed(){} // RVA: 0x8943B0
        public void OnInitialized(){} // RVA: 0x894320
        public void SendTransactionEvent(){} // RVA: 0x894320
    }

    public class ILegacyUnityAnalytics
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x8999E0
        public void SendCustomEvent(){} // RVA: 0x8943B0
    }

    public class INativeAppleStore
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x894320
        public void AddTransactionObserver(){} // RVA: 0x894290
        public void get_appReceipt(){} // RVA: 0x87C0A0
        public void get_appReceiptModificationDate(){} // RVA: 0x8820E0
        public void InterceptPromotionalPurchases(){} // RVA: 0x894290
    }

    public class INativeStore
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x894320
        public void Purchase(){} // RVA: 0x8943B0
        public void FinishTransaction(){} // RVA: 0x8943B0
    }

    public class INativeStoreProvider
    {
        // ── Methods ──
        public void GetAndroidStore(){} // RVA: 0x88DB50
        public void GetStorekit(){} // RVA: 0x87C540
    }

    public class INativeUDPStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x894320
        public void Purchase(){} // RVA: 0x8954D0
        public void RetrieveProducts(){} // RVA: 0x8943B0
        public void FinishTransaction(){} // RVA: 0x8943B0
    }

    public class IProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x87C0A0
    }

    public class IStoreController
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x87C0A0
        public void InitiatePurchase(){} // RVA: 0x894320
        public void ConfirmPendingPurchase(){} // RVA: 0x894320
    }

    public class IStoreInternal
    {
        // ── Methods ──
        public void SetModule(){} // RVA: 0x894320
    }

    public class IStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x895750
        public void ProcessPurchase(){} // RVA: 0x87D050
        public void OnPurchaseFailed(){} // RVA: 0x899290
        public void OnInitialized(){} // RVA: 0x8943B0
    }

    public class IUnityServicesInitializationChecker
    {
        // ── Methods ──
        public void CheckAndLogWarning(){} // RVA: 0x894290
    }

    public class InvalidProductTypeException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D9D460
    }

    public class InventoryInterface : Object
    {
        public object s_typeCache;

        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7D89B30
        public void GetProductListMethod(){} // RVA: 0x7D89C60
        public void GetPurchaseInfoMethod(){} // RVA: 0x7D89D40
        public void HasPurchaseMethod(){} // RVA: 0x7D89E20
    }

    public class iOSStoreBindings : Object
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7D65470
        public void AddTransactionObserver(){} // RVA: 0x7D654B0
        public void RetrieveProducts(){} // RVA: 0x7D654F0
        public void Purchase(){} // RVA: 0x7D65530
        public void FinishTransaction(){} // RVA: 0x7D65570
        public void get_appReceipt(){} // RVA: 0x7D655B0
        public void get_appReceiptModificationDate(){} // RVA: 0x7D655F0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7D65630
        public void .ctor(){} // RVA: 0xB43310
    }

}