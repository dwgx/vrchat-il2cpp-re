// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x722B940
    }

    public class GoogleAcknowledgePurchaseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7224B30
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7224BF0
    }

    public class GoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x721E600
        public void GetCachedQueriedProducts(){} // RVA: 0x721E7C0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x721E910 | overloaded x3
        public void Contains(){} // RVA: 0x721EC20 | overloaded x2
        public void AddCachedQueriedProductDetails(){} // RVA: 0x721ECA0
        public void .ctor(){} // RVA: 0x721EF40
    }

    public class GoogleConnectionRetryPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1D897D0
        public void Invoke(){} // RVA: 0x724B700
        public void AdjustDelay(){} // RVA: 0x724BA10
    }

    public class GoogleConsumeResponseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7224C90
        public void onConsumeResponse(){} // RVA: 0x7224D50
    }

    public class GoogleFetchPurchases
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6458F80
        public void SetStoreCallback(){} // RVA: 0x343E80
        public void FetchPurchases(){} // RVA: 0x722D420 | overloaded x2
        public void FillProductsWithPurchases(){} // RVA: 0x722D5A0
        public void BuildProductsFromPurchase(){} // RVA: 0x722D6D0
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x722D930
        public void OnFetchedPurchase(){} // RVA: 0x722DA60
        public void PurchaseIsPurchased(){} // RVA: 0x722DFE0
        public void PurchaseIsPending(){} // RVA: 0x722E120
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x722E260
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x722E3B0
        public void UpdateDeferredProduct(){} // RVA: 0x722E660
    }

    public class GoogleFinishTransactionService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void FinishTransaction(){} // RVA: 0x721F0A0
        public void FindPurchase(){} // RVA: 0x721F380
        public void FinishTransactionForPurchase(){} // RVA: 0x721F570
    }

    public class GoogleLastKnownProductService
    {
        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x2F8380
        public void set_LastKnownOldProductId(){} // RVA: 0x2DEE30
        public void get_LastKnownProductId(){} // RVA: 0x2E07C0
        public void set_LastKnownProductId(){} // RVA: 0x343E80
        public void get_LastKnownProrationMode(){} // RVA: 0x30B0C0
        public void set_LastKnownProrationMode(){} // RVA: 0xAE83A0
        public void .ctor(){} // RVA: 0x72200C0
    }

    public class GooglePlayConfiguration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x722B9D0
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x6242C0
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0xB89A80
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x722BA30
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x5F34FB0
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x4A7410
        public void NotifyDeferredPurchase(){} // RVA: 0x722BA80
    }

    public class GooglePlayProductCallback
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x2DEE30
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x722BC10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GooglePlayPurchaseCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x30B0D0
        public void SetStoreCallback(){} // RVA: 0x2DEE30
        public void SetStoreConfiguration(){} // RVA: 0x343E80
        public void OnPurchaseSuccessful(){} // RVA: 0x722BC70
        public void OnPurchaseFailed(){} // RVA: 0x722BD50
        public void NotifyDeferredPurchase(){} // RVA: 0x722BDB0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x722BFF0
    }

    public class GooglePlayStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x722C310
        public void Initialize(){} // RVA: 0x722C610
        public void RetrieveProducts(){} // RVA: 0x722C800
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x722C960
        public void ShouldFetchPurchasesNext(){} // RVA: 0x722C9B0
        public void Purchase(){} // RVA: 0x722CA60
        public void FinishTransaction(){} // RVA: 0x722CAC0
        public void OnPause(){} // RVA: 0x722CB40
    }

    public class GooglePlayStoreExtensions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x722CBD0
        public void SetStoreCallback(){} // RVA: 0x30B890
        public void IsPurchasedProductDeferred(){} // RVA: 0x722CD20
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x722CE80
        public void GetPurchaseState(){} // RVA: 0x722CEB0
        public void GooglePurchaseFromProduct(){} // RVA: 0x722D0A0
    }

    public class GooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x722EAC0
        public void SetStoreCallback(){} // RVA: 0x30B0D0
        public void FinishTransaction(){} // RVA: 0x722EBE0
        public void HandleFinishTransaction(){} // RVA: 0x722ED90
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x722F2C0
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x722F3D0
    }

    public class GooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Purchase(){} // RVA: 0x722F4A0
    }

    public class GooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x722F500
        public void SetStoreCallback(){} // RVA: 0x30B0D0
        public void RetrieveProducts(){} // RVA: 0x722F660
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x722F790
        public void OnProductsRetrieved(){} // RVA: 0x722FAE0
        public void OnRetrieveProductsFailed(){} // RVA: 0x722FBC0
        public void ResumeConnection(){} // RVA: 0x722FCD0
        public void MakePurchasesIntoProducts(){} // RVA: 0x722FD20
        public void IsPurchasedProductDeferred(){} // RVA: 0x72301F0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x4A6500
    }

    public class GooglePlayStoreService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7220110
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7220650
        public void StartConnection(){} // RVA: 0x7220810
        public void ResumeConnection(){} // RVA: 0x7220870
        public void AttemptReconnection(){} // RVA: 0x72208E0
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x1D94870
        public void RetryConnection(){} // RVA: 0x72209A0
        public void RetryConnectionAttempt(){} // RVA: 0x7220B30
        public void OnConnected(){} // RVA: 0x7220BC0
        public void DequeueQueryProducts(){} // RVA: 0x7220C10
        public void DequeueFetchPurchases(){} // RVA: 0x72211A0
        public void OnDisconnected(){} // RVA: 0x7221360
        public void RetrieveProducts(){} // RVA: 0x7221390
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7221450
        public void Purchase(){} // RVA: 0x7221680 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7221870
        public void FetchPurchases(){} // RVA: 0x72218F0
        public void TryFetchPurchases(){} // RVA: 0x7221B10
        public void GetPurchase(){} // RVA: 0x7221D10
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7221D90
    }

    public class GoogleProductMetadata
    {
        public object Name;
        public object .cctor;

        // ── Methods ──
        public void get_originalJson(){} // RVA: 0x35A740
        public void set_originalJson(){} // RVA: 0x305200
        public void set_subscriptionPeriod(){} // RVA: 0x358740
        public void set_freeTrialPeriod(){} // RVA: 0x4354D0
        public void set_introductoryPrice(){} // RVA: 0x3A5510
        public void set_introductoryPricePeriod(){} // RVA: 0x37B380
        public void set_introductoryPriceCycles(){} // RVA: 0x1C91450
        public void .ctor(){} // RVA: 0x722D330
    }

    public class GooglePurchaseService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00
        public void Purchase(){} // RVA: 0x72226C0
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7222920
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x72229E0
        public void ValidateSkus(){} // RVA: 0x7222D80
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7222F30
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x72230B0
        public void ValidateOldProduct(){} // RVA: 0x7223180
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7223210
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7223310
        public void HandleBillingFlowResult(){} // RVA: 0x7223580
    }

    public class GooglePurchaseUpdatedListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7225200
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x358740
        public void onPurchasesUpdated(){} // RVA: 0x7225490
        public void OnPurchasesUpdated(){} // RVA: 0x7225890
        public void HandleResultOkCases(){} // RVA: 0x7225A80
        public void HandleErrorCases(){} // RVA: 0x7225B60
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7225C50
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x72261A0 | overloaded x2
        public void ApplyOnPurchases(){} // RVA: 0x72264E0 | overloaded x2
        public void OnPurchaseOk(){} // RVA: 0x7226760
        public void HandlePurchasedProduct(){} // RVA: 0x7226A20
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7226B50
        public void IsLastProrationModeDeferred(){} // RVA: 0x7226D10
        public void OnPurchaseCancelled(){} // RVA: 0x7226F20 | overloaded x2
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7227010
        public void OnPurchaseFailed(){} // RVA: 0x7227100
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7227210
    }

    public class GooglePurchasesResponseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7224DF0
        public void onQueryPurchasesResponse(){} // RVA: 0x7224EB0
    }

    public class GoogleQueryPurchasesService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void QueryPurchases(){} // RVA: 0x72237D0
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7223950
        public void GetPurchaseByToken(){} // RVA: 0x7223B30
        public void IsResultOk(){} // RVA: 0x7223DB0
    }

}