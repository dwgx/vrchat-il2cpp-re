// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 27
// Methods: 77

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class IAnalyticsAdapter
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7A7E18800
        public void SendTransactionFailedEvent(){} // RVA: 0x7A7E18890
    }

    public class IAnalyticsClient
    {
        // ── Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x7A7E18800
        public void OnPurchaseFailed(){} // RVA: 0x7A7E18890
    }

    public class ICoreServicesEnvironmentObserver
    {
        // ── Methods ──
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7A7E18800
    }

    public class IDetailedStoreListener
    {
        // ── Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x7A7E18890
    }

    public class IDs : Object
    {
        // ── Methods ──
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AEFF2A40
        public void Add(){} // RVA: 0x7AEFF2B40
        public void SpecificIDForStore(){} // RVA: 0x7AEFF2C10
        public void GetEnumerator(){} // RVA: 0x7AEFF2CD0
        public void .ctor(){} // RVA: 0x7AEFF2DD0
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7A7E00680
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7A7E00B20
        public void Contains(){} // RVA: 0x7A7E019D0
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7A7E18800
    }

    public class IGoogleFetchPurchases
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7A7E18800
        public void FetchPurchases(){} // RVA: 0x7A7E18800
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7A7E18770
        public void NotifyDeferredPurchase(){} // RVA: 0x7A7E1DB70
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7A7E18890
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7A7E01900
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7A7E01900
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7A7E189D0
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7A7E019D0
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7A7E18800
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7A7E18800
        public void FinishTransaction(){} // RVA: 0x7A7E18890
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x7A7E18800
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7A7E18800
        public void RetrieveProducts(){} // RVA: 0x7A7E1D550
        public void ResumeConnection(){} // RVA: 0x7A7E18770
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7A7E01900
    }

    public class IInternalStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7A7E19BE0
        public void ProcessPurchase(){} // RVA: 0x7A7E01630
        public void OnPurchaseFailed(){} // RVA: 0x7A7E18890
        public void OnInitialized(){} // RVA: 0x7A7E18800
        public void SendTransactionEvent(){} // RVA: 0x7A7E18800
    }

    public class ILegacyUnityAnalytics
    {
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7A7E1DCE0
        public void SendCustomEvent(){} // RVA: 0x7A7E18890
    }

    public class INativeAppleStore
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7A7E18800
        public void AddTransactionObserver(){} // RVA: 0x7A7E18770
        public void get_appReceipt(){} // RVA: 0x7A7E00680
        public void get_appReceiptModificationDate(){} // RVA: 0x7A7E06760
        public void InterceptPromotionalPurchases(){} // RVA: 0x7A7E18770
    }

    public class INativeStore
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7A7E18800
        public void Purchase(){} // RVA: 0x7A7E18890
        public void FinishTransaction(){} // RVA: 0x7A7E18890
    }

    public class INativeStoreProvider
    {
        // ── Methods ──
        public void GetAndroidStore(){} // RVA: 0x7A7E120C0
        public void GetStorekit(){} // RVA: 0x7A7E00B20
    }

    public class INativeUDPStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7A7E18800
        public void Purchase(){} // RVA: 0x7A7E1DDC0
        public void RetrieveProducts(){} // RVA: 0x7A7E18890
        public void FinishTransaction(){} // RVA: 0x7A7E18890
    }

    public class IProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7A7E00680
    }

    public class IStoreController
    {
        // ── Methods ──
        public void get_products(){} // RVA: 0x7A7E00680
        public void InitiatePurchase(){} // RVA: 0x7A7E18800
        public void ConfirmPendingPurchase(){} // RVA: 0x7A7E18800
    }

    public class IStoreInternal
    {
        // ── Methods ──
        public void SetModule(){} // RVA: 0x7A7E18800
    }

    public class IStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7A7E19BE0
        public void ProcessPurchase(){} // RVA: 0x7A7E01630
        public void OnPurchaseFailed(){} // RVA: 0x7A7E1D590
        public void OnInitialized(){} // RVA: 0x7A7E18890
    }

    public class IUnityServicesInitializationChecker
    {
        // ── Methods ──
        public void CheckAndLogWarning(){} // RVA: 0x7A7E18770
    }

    public class InvalidProductTypeException : ReceiptParserException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF02A2C0
    }

    public class InventoryInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7AF0166E0
        public void GetProductListMethod(){} // RVA: 0x7AF016820
        public void GetPurchaseInfoMethod(){} // RVA: 0x7AF016900
        public void HasPurchaseMethod(){} // RVA: 0x7AF0169E0
    }

    public class iOSStoreBindings : Object
    {
        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7AEFF1E60
        public void AddTransactionObserver(){} // RVA: 0x7AEFF1EA0
        public void RetrieveProducts(){} // RVA: 0x7AEFF1EE0
        public void Purchase(){} // RVA: 0x7AEFF1F20
        public void FinishTransaction(){} // RVA: 0x7AEFF1F60
        public void get_appReceipt(){} // RVA: 0x7AEFF1FA0
        public void get_appReceiptModificationDate(){} // RVA: 0x7AEFF1FE0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7AEFF2020
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}