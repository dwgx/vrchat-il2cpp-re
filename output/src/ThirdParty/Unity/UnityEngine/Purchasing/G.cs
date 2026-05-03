// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension : Object
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7FFE87D6BAE0
    }

    public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D64CD0
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7FFE87D64D90
    }

    public class GoogleCachedQueryProductDetailsService : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE87D5E7A0
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFE87D5E960
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFE87D5EAB0 | overloaded x3
        public void Contains(){} // RVA: 0x7FFE87D5EDC0 | overloaded x2
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFE87D5EE40
        public void .ctor(){} // RVA: 0x7FFE87D5F0E0
    }

    public class GoogleConnectionRetryPolicy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82B1BB00
        public void Invoke(){} // RVA: 0x7FFE87D8B8A0
        public void AdjustDelay(){} // RVA: 0x7FFE87D8BBB0
    }

    public class GoogleConsumeResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D64E30
        public void onConsumeResponse(){} // RVA: 0x7FFE87D64EF0
    }

    public class GoogleFetchPurchases : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F99960
        public void SetStoreCallback(){} // RVA: 0x7FFE81161E80
        public void FetchPurchases(){} // RVA: 0x7FFE87D6D5C0 | overloaded x2
        public void FillProductsWithPurchases(){} // RVA: 0x7FFE87D6D740
        public void BuildProductsFromPurchase(){} // RVA: 0x7FFE87D6D870
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7FFE87D6DAD0
        public void OnFetchedPurchase(){} // RVA: 0x7FFE87D6DC00
        public void PurchaseIsPurchased(){} // RVA: 0x7FFE87D6E180
        public void PurchaseIsPending(){} // RVA: 0x7FFE87D6E2C0
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7FFE87D6E400
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7FFE87D6E550
        public void UpdateDeferredProduct(){} // RVA: 0x7FFE87D6E800
    }

    public class GoogleFinishTransactionService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void FinishTransaction(){} // RVA: 0x7FFE87D5F240
        public void FindPurchase(){} // RVA: 0x7FFE87D5F520
        public void FinishTransactionForPurchase(){} // RVA: 0x7FFE87D5F710
    }

    public class GoogleLastKnownProductService : Object
    {
        public string _lastKnownOldProductId; // 0x10
        public string _lastKnownProductId; // 0x18
        public System.Nullable`1<0x6667553C> _lastKnownProrationMode; // 0x20

        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7FFE81116380
        public void set_LastKnownOldProductId(){} // RVA: 0x7FFE810FCE30
        public void get_LastKnownProductId(){} // RVA: 0x7FFE810FE7C0
        public void set_LastKnownProductId(){} // RVA: 0x7FFE81161E80
        public void get_LastKnownProrationMode(){} // RVA: 0x7FFE811290C0
        public void set_LastKnownProrationMode(){} // RVA: 0x7FFE81859C50
        public void .ctor(){} // RVA: 0x7FFE87D60260
    }

    public class GooglePlayConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D6BB70
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFE8143C6A0
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFE819208B0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFE87D6BBD0
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFE86A75DD0
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFE812CF7D0
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFE87D6BC20
    }

    public class GooglePlayProductCallback : Object
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7FFE810FCE30
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFE87D6BDB0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GooglePlayPurchaseCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811290D0
        public void SetStoreCallback(){} // RVA: 0x7FFE810FCE30
        public void SetStoreConfiguration(){} // RVA: 0x7FFE81161E80
        public void OnPurchaseSuccessful(){} // RVA: 0x7FFE87D6BE10
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D6BEF0
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFE87D6BF50
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFE87D6C190
    }

    public class GooglePlayStore : AbstractStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D6C4B0
        public void Initialize(){} // RVA: 0x7FFE87D6C7B0
        public void RetrieveProducts(){} // RVA: 0x7FFE87D6C9A0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFE87D6CB00
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7FFE87D6CB50
        public void Purchase(){} // RVA: 0x7FFE87D6CC00
        public void FinishTransaction(){} // RVA: 0x7FFE87D6CC60
        public void OnPause(){} // RVA: 0x7FFE87D6CCE0
    }

    public class GooglePlayStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D6CD70
        public void SetStoreCallback(){} // RVA: 0x7FFE81129890
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFE87D6CEC0
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7FFE87D6D020
        public void GetPurchaseState(){} // RVA: 0x7FFE87D6D050
        public void GooglePurchaseFromProduct(){} // RVA: 0x7FFE87D6D240
    }

    public class GooglePlayStoreFinishTransactionService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D6EC60
        public void SetStoreCallback(){} // RVA: 0x7FFE811290D0
        public void FinishTransaction(){} // RVA: 0x7FFE87D6ED80
        public void HandleFinishTransaction(){} // RVA: 0x7FFE87D6EF30
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7FFE87D6F460
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7FFE87D6F570
    }

    public class GooglePlayStorePurchaseService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Purchase(){} // RVA: 0x7FFE87D6F640
    }

    public class GooglePlayStoreRetrieveProductsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D6F6A0
        public void SetStoreCallback(){} // RVA: 0x7FFE811290D0
        public void RetrieveProducts(){} // RVA: 0x7FFE87D6F800
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7FFE87D6F930
        public void OnProductsRetrieved(){} // RVA: 0x7FFE87D6FC80
        public void OnRetrieveProductsFailed(){} // RVA: 0x7FFE87D6FD60
        public void ResumeConnection(){} // RVA: 0x7FFE87D6FE70
        public void MakePurchasesIntoProducts(){} // RVA: 0x7FFE87D6FEC0
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFE87D70390
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFE812CF770
    }

    public class GooglePlayStoreService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D602B0
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7FFE87D607F0
        public void StartConnection(){} // RVA: 0x7FFE87D609B0
        public void ResumeConnection(){} // RVA: 0x7FFE87D60A10
        public void AttemptReconnection(){} // RVA: 0x7FFE87D60A80
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x7FFE82B27890
        public void RetryConnection(){} // RVA: 0x7FFE87D60B40
        public void RetryConnectionAttempt(){} // RVA: 0x7FFE87D60CD0
        public void OnConnected(){} // RVA: 0x7FFE87D60D60
        public void DequeueQueryProducts(){} // RVA: 0x7FFE87D60DB0
        public void DequeueFetchPurchases(){} // RVA: 0x7FFE87D61340
        public void OnDisconnected(){} // RVA: 0x7FFE87D61500
        public void RetrieveProducts(){} // RVA: 0x7FFE87D61530
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7FFE87D615F0
        public void Purchase(){} // RVA: 0x7FFE87D61820 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFE87D61A10
        public void FetchPurchases(){} // RVA: 0x7FFE87D61A90
        public void TryFetchPurchases(){} // RVA: 0x7FFE87D61CB0
        public void GetPurchase(){} // RVA: 0x7FFE87D61EB0
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7FFE87D61F30
    }

    public class GoogleProductMetadata : ProductMetadata
    {
        public string _originalJson; // 0x40
        public string _subscriptionPeriod; // 0x48
        public string _freeTrialPeriod; // 0x50
        public string _introductoryPrice; // 0x58
        public string _introductoryPricePeriod; // 0x60
        public int _introductoryPriceCycles; // 0x68

        // ── Methods ──
        public void get_originalJson(){} // RVA: 0x7FFE81178740
        public void set_originalJson(){} // RVA: 0x7FFE81123200
        public void set_subscriptionPeriod(){} // RVA: 0x7FFE81176740
        public void set_freeTrialPeriod(){} // RVA: 0x7FFE812534D0
        public void set_introductoryPrice(){} // RVA: 0x7FFE811C3510
        public void set_introductoryPricePeriod(){} // RVA: 0x7FFE81199380
        public void set_introductoryPriceCycles(){} // RVA: 0x7FFE82A22F00
        public void .ctor(){} // RVA: 0x7FFE87D6D4D0
    }

    public class GooglePurchaseService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void Purchase(){} // RVA: 0x7FFE87D62860
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7FFE87D62AC0
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7FFE87D62B80
        public void ValidateSkus(){} // RVA: 0x7FFE87D62F20
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7FFE87D630D0
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7FFE87D63250
        public void ValidateOldProduct(){} // RVA: 0x7FFE87D63320
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7FFE87D633B0
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7FFE87D634B0
        public void HandleBillingFlowResult(){} // RVA: 0x7FFE87D63720
    }

    public class GooglePurchaseUpdatedListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D653A0
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x7FFE81176740
        public void onPurchasesUpdated(){} // RVA: 0x7FFE87D65630
        public void OnPurchasesUpdated(){} // RVA: 0x7FFE87D65A30
        public void HandleResultOkCases(){} // RVA: 0x7FFE87D65C20
        public void HandleErrorCases(){} // RVA: 0x7FFE87D65D00
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7FFE87D65DF0
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7FFE87D66340 | overloaded x2
        public void ApplyOnPurchases(){} // RVA: 0x7FFE87D66680 | overloaded x2
        public void OnPurchaseOk(){} // RVA: 0x7FFE87D66900
        public void HandlePurchasedProduct(){} // RVA: 0x7FFE87D66BC0
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7FFE87D66CF0
        public void IsLastProrationModeDeferred(){} // RVA: 0x7FFE87D66EB0
        public void OnPurchaseCancelled(){} // RVA: 0x7FFE87D670C0 | overloaded x2
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7FFE87D671B0
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D672A0
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7FFE87D673B0
    }

    public class GooglePurchasesResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D64F90
        public void onQueryPurchasesResponse(){} // RVA: 0x7FFE87D65050
    }

    public class GoogleQueryPurchasesService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void QueryPurchases(){} // RVA: 0x7FFE87D63970
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7FFE87D63AF0
        public void GetPurchaseByToken(){} // RVA: 0x7FFE87D63CD0
        public void IsResultOk(){} // RVA: 0x7FFE87D63F50
    }

}