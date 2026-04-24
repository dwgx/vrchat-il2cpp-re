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
        // ── Methods ──
        public void SendTransactionEvent(){} // RVA: 0x7FFD4E090A40
        public void SendTransactionFailedEvent(){} // RVA: 0x7FFD4E099B30
    }

    public class IAnalyticsClient
    {
        // ── Methods ──
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD4E090A40
        public void OnPurchaseFailed(){} // RVA: 0x7FFD4E099B30
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
        public void OnUpdatedCoreServicesEnvironment(){} // RVA: 0x7FFD4E090A40
    }

    public class IDetailedStoreListener
    {
        // ── Methods ──
        public void OnPurchaseFailed(){} // RVA: 0x7FFD4E099B30
    }

    public class IExtensionProvider
    {
    }

    public class IGoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFD4E078E90
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFD4E078F40
        public void Contains(){} // RVA: 0x7FFD4E079F60
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFD4E090A40
    }

    public class IGoogleFetchPurchases
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFD4E090A40
        public void FetchPurchases(){} // RVA: 0x7FFD4E090A40 | overloaded x2
    }

    public class IGooglePlayConfiguration
    {
    }

    public class IGooglePlayConfigurationInternal
    {
        // ── Methods ──
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFD4E090980
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFD4E09B8C0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFD4E099B30
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFD4E079D00
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFD4E079D00
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFD4E090ED0
    }

    public class IGooglePlayStoreExtensions
    {
        // ── Methods ──
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFD4E079F60
    }

    public class IGooglePlayStoreExtensionsInternal
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFD4E090A40
    }

    public class IGooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFD4E090A40
        public void FinishTransaction(){} // RVA: 0x7FFD4E099B30
    }

    public class IGooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x7FFD4E090A40
    }

    public class IGooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFD4E090A40
        public void RetrieveProducts(){} // RVA: 0x7FFD4E096500
        public void ResumeConnection(){} // RVA: 0x7FFD4E090980
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFD4E079D00
    }

    public class IInternalStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFD4E092BC0
        public void ProcessPurchase(){} // RVA: 0x7FFD4E07E6B0
        public void OnPurchaseFailed(){} // RVA: 0x7FFD4E099B30
        public void OnInitialized(){} // RVA: 0x7FFD4E090A40
        public void SendTransactionEvent(){} // RVA: 0x7FFD4E090A40
    }

    public class ILegacyUnityAnalytics
    {
        public ausedTweens.r _mediaPlayer; // 0x20
        public ePathName117.? _text; // 0x28
        public ePathName117.ÎÌÍÍÎÏÌ _backgroundImage; // 0x30
        public int _backgroundHorizontalPadding; // 0x38
        public int _backgroundVerticalPadding; // 0x3C
        public int _maxCharacters; // 0x40

        // ── Methods ──
        public void SendTransactionEvent(){}
        public void SendCustomEvent(){} // RVA: 0x7FFD4E099B30
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
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFD4E090A40
        public void AddTransactionObserver(){} // RVA: 0x7FFD4E090980
        public void get_appReceipt(){} // RVA: 0x7FFD4E078E90
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFD4E07EB60
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFD4E090980
    }

    public class INativeStore
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7FFD4E090A40
        public void Purchase(){} // RVA: 0x7FFD4E099B30
        public void FinishTransaction(){} // RVA: 0x7FFD4E099B30
    }

    public class INativeStoreProvider
    {
        // ── Methods ──
        public void GetAndroidStore(){}
        public void GetStorekit(){} // RVA: 0x7FFD4E078F40
    }

    public class INativeUDPStore
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD4E090A40
        public void Purchase(){} // RVA: 0x7FFD4E09AF60
        public void RetrieveProducts(){} // RVA: 0x7FFD4E099B30
        public void FinishTransaction(){} // RVA: 0x7FFD4E099B30
    }

    public class IStoreController
    {
        public object products;

        // ── Methods ──
        public void get_products(){} // RVA: 0x7FFD4E078E90
        public void InitiatePurchase(){} // RVA: 0x7FFD4E090A40
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFD4E090A40
    }

    public class IStoreExtension
    {
    }

    public class IStoreInternal
    {
        // ── Methods ──
        public void SetModule(){} // RVA: 0x7FFD4E090A40
    }

    public class IStoreListener
    {
        // ── Methods ──
        public void OnInitializeFailed(){} // RVA: 0x7FFD4E092BC0
        public void ProcessPurchase(){} // RVA: 0x7FFD4E07E6B0
        public void OnPurchaseFailed(){} // RVA: 0x7FFD4E097970
        public void OnInitialized(){} // RVA: 0x7FFD4E099B30
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
        public void CheckAndLogWarning(){} // RVA: 0x7FFD4E090980
    }

    public class iOSStoreBindings : Object
    {
        public object appReceipt;
        public object appReceiptModificationDate;

        // ── Methods ──
        public void SetUnityPurchasingCallback(){} // RVA: 0x7FFD54DCA330
        public void AddTransactionObserver(){} // RVA: 0x7FFD54DCA370
        public void RetrieveProducts(){} // RVA: 0x7FFD54DCA3B0
        public void Purchase(){} // RVA: 0x7FFD54DCA3F0
        public void FinishTransaction(){} // RVA: 0x7FFD54DCA430
        public void get_appReceipt(){} // RVA: 0x7FFD54DCA470
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFD54DCA4B0
        public void InterceptPromotionalPurchases(){} // RVA: 0x7FFD54DCA4F0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

}