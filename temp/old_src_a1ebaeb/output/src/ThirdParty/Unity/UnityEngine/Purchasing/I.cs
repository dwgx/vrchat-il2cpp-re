// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 36
// Methods: 67

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
        // ── Original Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7ffaa8660d80
        public void SendTransactionFailedEvent(){} // RVA: 0x7ffaa8669e70
    }

    public class IAnalyticsClient
    {
        // ── Original Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaa8660d80
        public void OnPurchaseFailed(){} // RVA: 0x7ffaa8669e70
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
        // ── Original Methods ──
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7ffaa8660d80
    }

    public class IDetailedStoreListener
    {
        // ── Original Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x7ffaa8669e70
    }

    public class IExtensionProvider
    {
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Original Methods ──
        public void Contains(){} // RVA: 0x7ffaa864a2a0
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7ffaa86491d0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7ffaa8649280
    }

    public class IGoogleFetchPurchases
    {
        // ── Original Methods ──
        public void FetchPurchases(){} // RVA: 0x7ffaa8660d80
        public void FetchPurchases(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8660d80
    }

    public class IGooglePlayConfiguration
    {
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Original Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7ffaa8660cc0
        public void NotifyDeferredPurchase(){} // RVA: 0x7ffaa866bc00
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7ffaa8669e70
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7ffaa864a040
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7ffaa864a040
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Original Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7ffaa864a2a0
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8660d80
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Original Methods ──
        public void FinishTransaction(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8660d80
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Original Methods ──
        public void Purchase(){} // RVA: 0x7ffaa8660d80
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Original Methods ──
        public void RetrieveProducts(){} // RVA: 0x7ffaa8666840
        public void ResumeConnection(){} // RVA: 0x7ffaa8660cc0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8660d80
    }

    public class IInternalStoreListener
    {
        // ── Original Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7ffaa8662f00
        public void ProcessPurchase(){} // RVA: 0x7ffaa864e9f0
        public void OnPurchaseFailed(){} // RVA: 0x7ffaa8669e70
        public void OnInitialized(){} // RVA: 0x7ffaa8660d80
        public void SendTransactionEvent(){} // RVA: 0x7ffaa8660d80
    }

    public class ILegacyUnityAnalytics
    {
        // ── Original Methods ──
        public void SendTransactionEvent(){}
        public void SendCustomEvent(){} // RVA: 0x7ffaa8669e70
    }

    public class IMicrosoftConfiguration
    {
    }

    public class IMicrosoftExtensions
    {
    }

    public class INativeAppleStore
    {
        // ── Original Methods ──
        public void AddTransactionObserver(){} // RVA: 0x7ffaa8660cc0
        public void get_appReceipt(){} // RVA: 0x7ffaa86491d0
        public void get_appReceiptModificationDate(){} // RVA: 0x7ffaa864eea0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7ffaa8660d80
    }

    public class INativeStore
    {
        // ── Original Methods ──
        public void RetrieveProducts(){} // RVA: 0x7ffaa8660d80
        public void Purchase(){} // RVA: 0x7ffaa8669e70
        public void FinishTransaction(){} // RVA: 0x7ffaa8669e70
    }

    public class INativeStoreProvider
    {
        // ── Binary Analysis Named ──
        public void GetAndroidStore(){}
        public void GetStorekit(){} // RVA: 0x7ffaa8649280
    }

    public class INativeUDPStore
    {
        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaa8660d80
        public void Purchase(){} // RVA: 0x7ffaa866b2a0
        public void RetrieveProducts(){} // RVA: 0x7ffaa8669e70
        public void FinishTransaction(){} // RVA: 0x7ffaa8669e70
    }

    public class IStoreController
    {
        // ── Original Methods ──
        public void get_products(){} // RVA: 0x7ffaa86491d0
        public void InitiatePurchase(){} // RVA: 0x7ffaa8660d80
        public void ConfirmPendingPurchase(){} // RVA: 0x7ffaa8660d80
    }

    public class IStoreExtension
    {
    }

    public class IStoreInternal
    {
        // ── Binary Analysis Named ──
        public void SetModule(){} // RVA: 0x7ffaa8660d80
    }

    public class IStoreListener
    {
        // ── Original Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7ffaa8662f00
        public void ProcessPurchase(){} // RVA: 0x7ffaa864e9f0
        public void OnPurchaseFailed(){} // RVA: 0x7ffaa8667cb0
        public void OnInitialized(){} // RVA: 0x7ffaa8669e70
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
        // ── Binary Analysis Named ──
        public void CheckAndLogWarning(){} // RVA: 0x7ffaa8660cc0
    }

    public class iOSStoreBindings : Object
    {
        // ── Original Methods ──
        public void AddTransactionObserver(){} // RVA: 0x7ffaaf3cc2d0
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3cc310
        public void Purchase(){} // RVA: 0x7ffaaf3cc350
        public void FinishTransaction(){} // RVA: 0x7ffaaf3cc390
        public void get_appReceipt(){} // RVA: 0x7ffaaf3cc3d0
        public void get_appReceiptModificationDate(){} // RVA: 0x7ffaaf3cc410
        public void InterceptPromotionalPurchases(){} // RVA: 0x7ffaaf3cc450
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7ffaaf3cc290
    }

}