// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7FFAF9CDB940
    }

    public class GoogleAcknowledgePurchaseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD4B30
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7FFAF9CD4BF0
    }

    public class GoogleCachedQueryProductDetailsService
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAF9CCE600
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFAF9CCE7C0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFAF9CCE910 | overloaded x3
        public void Contains(){} // RVA: 0x7FFAF9CCEC20 | overloaded x2
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFAF9CCECA0
        public void .ctor(){} // RVA: 0x7FFAF9CCEF40
    }

    public class GoogleConnectionRetryPolicy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF48397D0
        public void Invoke(){} // RVA: 0x7FFAF9CFB700
        public void AdjustDelay(){} // RVA: 0x7FFAF9CFBA10
    }

    public class GoogleConsumeResponseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD4C90
        public void onConsumeResponse(){} // RVA: 0x7FFAF9CD4D50
    }

    public class GoogleFetchPurchases
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8F08F80
        public void SetStoreCallback(){} // RVA: 0x7FFAF2DF3E80
        public void FetchPurchases(){} // RVA: 0x7FFAF9CDD420 | overloaded x2
        public void FillProductsWithPurchases(){} // RVA: 0x7FFAF9CDD5A0
        public void BuildProductsFromPurchase(){} // RVA: 0x7FFAF9CDD6D0
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7FFAF9CDD930
        public void OnFetchedPurchase(){} // RVA: 0x7FFAF9CDDA60
        public void PurchaseIsPurchased(){} // RVA: 0x7FFAF9CDDFE0
        public void PurchaseIsPending(){} // RVA: 0x7FFAF9CDE120
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7FFAF9CDE260
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7FFAF9CDE3B0
        public void UpdateDeferredProduct(){} // RVA: 0x7FFAF9CDE660
    }

    public class GoogleFinishTransactionService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void FinishTransaction(){} // RVA: 0x7FFAF9CCF0A0
        public void FindPurchase(){} // RVA: 0x7FFAF9CCF380
        public void FinishTransactionForPurchase(){} // RVA: 0x7FFAF9CCF570
    }

    public class GoogleLastKnownProductService
    {
        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7FFAF2DA8380
        public void set_LastKnownOldProductId(){} // RVA: 0x7FFAF2D8EE30
        public void get_LastKnownProductId(){} // RVA: 0x7FFAF2D907C0
        public void set_LastKnownProductId(){} // RVA: 0x7FFAF2DF3E80
        public void get_LastKnownProrationMode(){} // RVA: 0x7FFAF2DBB0C0
        public void set_LastKnownProrationMode(){} // RVA: 0x7FFAF35983A0
        public void .ctor(){} // RVA: 0x7FFAF9CD00C0
    }

    public class GooglePlayConfiguration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CDB9D0
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFAF30D42C0
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFAF3639A80
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFAF9CDBA30
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFAF89E4FB0
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFAF2F57410
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFAF9CDBA80
    }

    public class GooglePlayProductCallback
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7FFAF2D8EE30
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFAF9CDBC10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GooglePlayPurchaseCallback
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DBB0D0
        public void SetStoreCallback(){} // RVA: 0x7FFAF2D8EE30
        public void SetStoreConfiguration(){} // RVA: 0x7FFAF2DF3E80
        public void OnPurchaseSuccessful(){} // RVA: 0x7FFAF9CDBC70
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF9CDBD50
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFAF9CDBDB0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFAF9CDBFF0
    }

    public class GooglePlayStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CDC310
        public void Initialize(){} // RVA: 0x7FFAF9CDC610
        public void RetrieveProducts(){} // RVA: 0x7FFAF9CDC800
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFAF9CDC960
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7FFAF9CDC9B0
        public void Purchase(){} // RVA: 0x7FFAF9CDCA60
        public void FinishTransaction(){} // RVA: 0x7FFAF9CDCAC0
        public void OnPause(){} // RVA: 0x7FFAF9CDCB40
    }

    public class GooglePlayStoreExtensions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CDCBD0
        public void SetStoreCallback(){} // RVA: 0x7FFAF2DBB890
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAF9CDCD20
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7FFAF9CDCE80
        public void GetPurchaseState(){} // RVA: 0x7FFAF9CDCEB0
        public void GooglePurchaseFromProduct(){} // RVA: 0x7FFAF9CDD0A0
    }

    public class GooglePlayStoreFinishTransactionService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CDEAC0
        public void SetStoreCallback(){} // RVA: 0x7FFAF2DBB0D0
        public void FinishTransaction(){} // RVA: 0x7FFAF9CDEBE0
        public void HandleFinishTransaction(){} // RVA: 0x7FFAF9CDED90
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7FFAF9CDF2C0
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7FFAF9CDF3D0
    }

    public class GooglePlayStorePurchaseService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Purchase(){} // RVA: 0x7FFAF9CDF4A0
    }

    public class GooglePlayStoreRetrieveProductsService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CDF500
        public void SetStoreCallback(){} // RVA: 0x7FFAF2DBB0D0
        public void RetrieveProducts(){} // RVA: 0x7FFAF9CDF660
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7FFAF9CDF790
        public void OnProductsRetrieved(){} // RVA: 0x7FFAF9CDFAE0
        public void OnRetrieveProductsFailed(){} // RVA: 0x7FFAF9CDFBC0
        public void ResumeConnection(){} // RVA: 0x7FFAF9CDFCD0
        public void MakePurchasesIntoProducts(){} // RVA: 0x7FFAF9CDFD20
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAF9CE01F0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFAF2F56500
    }

    public class GooglePlayStoreService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD0110
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7FFAF9CD0650
        public void StartConnection(){} // RVA: 0x7FFAF9CD0810
        public void ResumeConnection(){} // RVA: 0x7FFAF9CD0870
        public void AttemptReconnection(){} // RVA: 0x7FFAF9CD08E0
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x7FFAF4844870
        public void RetryConnection(){} // RVA: 0x7FFAF9CD09A0
        public void RetryConnectionAttempt(){} // RVA: 0x7FFAF9CD0B30
        public void OnConnected(){} // RVA: 0x7FFAF9CD0BC0
        public void DequeueQueryProducts(){} // RVA: 0x7FFAF9CD0C10
        public void DequeueFetchPurchases(){} // RVA: 0x7FFAF9CD11A0
        public void OnDisconnected(){} // RVA: 0x7FFAF9CD1360
        public void RetrieveProducts(){} // RVA: 0x7FFAF9CD1390
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7FFAF9CD1450
        public void Purchase(){} // RVA: 0x7FFAF9CD1680 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFAF9CD1870
        public void FetchPurchases(){} // RVA: 0x7FFAF9CD18F0
        public void TryFetchPurchases(){} // RVA: 0x7FFAF9CD1B10
        public void GetPurchase(){} // RVA: 0x7FFAF9CD1D10
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7FFAF9CD1D90
    }

    public class GoogleProductMetadata
    {
        public object Name;
        public object .cctor;

        // ── Methods ──
        public void get_originalJson(){} // RVA: 0x7FFAF2E0A740
        public void set_originalJson(){} // RVA: 0x7FFAF2DB5200
        public void set_subscriptionPeriod(){} // RVA: 0x7FFAF2E08740
        public void set_freeTrialPeriod(){} // RVA: 0x7FFAF2EE54D0
        public void set_introductoryPrice(){} // RVA: 0x7FFAF2E55510
        public void set_introductoryPricePeriod(){} // RVA: 0x7FFAF2E2B380
        public void set_introductoryPriceCycles(){} // RVA: 0x7FFAF4741450
        public void .ctor(){} // RVA: 0x7FFAF9CDD330
    }

    public class GooglePurchaseService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00
        public void Purchase(){} // RVA: 0x7FFAF9CD26C0
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7FFAF9CD2920
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7FFAF9CD29E0
        public void ValidateSkus(){} // RVA: 0x7FFAF9CD2D80
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7FFAF9CD2F30
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7FFAF9CD30B0
        public void ValidateOldProduct(){} // RVA: 0x7FFAF9CD3180
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7FFAF9CD3210
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7FFAF9CD3310
        public void HandleBillingFlowResult(){} // RVA: 0x7FFAF9CD3580
    }

    public class GooglePurchaseUpdatedListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD5200
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x7FFAF2E08740
        public void onPurchasesUpdated(){} // RVA: 0x7FFAF9CD5490
        public void OnPurchasesUpdated(){} // RVA: 0x7FFAF9CD5890
        public void HandleResultOkCases(){} // RVA: 0x7FFAF9CD5A80
        public void HandleErrorCases(){} // RVA: 0x7FFAF9CD5B60
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7FFAF9CD5C50
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7FFAF9CD61A0 | overloaded x2
        public void ApplyOnPurchases(){} // RVA: 0x7FFAF9CD64E0 | overloaded x2
        public void OnPurchaseOk(){} // RVA: 0x7FFAF9CD6760
        public void HandlePurchasedProduct(){} // RVA: 0x7FFAF9CD6A20
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7FFAF9CD6B50
        public void IsLastProrationModeDeferred(){} // RVA: 0x7FFAF9CD6D10
        public void OnPurchaseCancelled(){} // RVA: 0x7FFAF9CD6F20 | overloaded x2
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7FFAF9CD7010
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF9CD7100
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7FFAF9CD7210
    }

    public class GooglePurchasesResponseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD4DF0
        public void onQueryPurchasesResponse(){} // RVA: 0x7FFAF9CD4EB0
    }

    public class GoogleQueryPurchasesService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void QueryPurchases(){} // RVA: 0x7FFAF9CD37D0
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7FFAF9CD3950
        public void GetPurchaseByToken(){} // RVA: 0x7FFAF9CD3B30
        public void IsResultOk(){} // RVA: 0x7FFAF9CD3DB0
    }

}