// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 149

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension : Object
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7D7E3E0
    }

    public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D77530
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7D775F0
    }

    public class GoogleCachedQueryProductDetailsService : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7D71170
        public void GetCachedQueriedProducts(){} // RVA: 0x7D71330
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7D71480
        public void Contains(){} // RVA: 0x7D71790
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7D71810
        public void .ctor(){} // RVA: 0x7D71AB0
    }

    public class GoogleConnectionRetryPolicy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x263F900
        public void Invoke(){} // RVA: 0x7D9E320
        public void AdjustDelay(){} // RVA: 0x7D9E640
    }

    public class GoogleConsumeResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D77690
        public void onConsumeResponse(){} // RVA: 0x7D77750
    }

    public class GoogleFetchPurchases : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EC9750
        public void SetStoreCallback(){} // RVA: 0xBA9BA0
        public void FetchPurchases(){} // RVA: 0x7D7FEA0
        public void FillProductsWithPurchases(){} // RVA: 0x7D80020
        public void BuildProductsFromPurchase(){} // RVA: 0x7D80150
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7D803B0
        public void OnFetchedPurchase(){} // RVA: 0x7D804F0
        public void PurchaseIsPurchased(){} // RVA: 0x7D80A70
        public void PurchaseIsPending(){} // RVA: 0x7D80BB0
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7D80CF0
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7D80E50
        public void UpdateDeferredProduct(){} // RVA: 0x7D81110
    }

    public class GoogleFinishTransactionService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void FinishTransaction(){} // RVA: 0x7D71C10
        public void FindPurchase(){} // RVA: 0x7D71EF0
        public void FinishTransactionForPurchase(){} // RVA: 0x7D720E0
    }

    public class GoogleLastKnownProductService : Object
    {
        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0xB5DBF0
        public void set_LastKnownOldProductId(){} // RVA: 0xB44D60
        public void get_LastKnownProductId(){} // RVA: 0xB465B0
        public void set_LastKnownProductId(){} // RVA: 0xBA9BA0
        public void get_LastKnownProrationMode(){} // RVA: 0xB700F0
        public void set_LastKnownProrationMode(){} // RVA: 0x13B3F80
        public void .ctor(){} // RVA: 0x7D72C30
    }

    public class GooglePlayConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D7E460
        public void NotifyInitializationConnectionFailed(){} // RVA: 0xEB0F90
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x14558D0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7D7E4C0
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x69ACB30
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0xD15320
        public void NotifyDeferredPurchase(){} // RVA: 0x7D7E510
    }

    public class GooglePlayProductCallback : Object
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0xB44D60
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7D7E6A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GooglePlayPurchaseCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB70100
        public void SetStoreCallback(){} // RVA: 0xB44D60
        public void SetStoreConfiguration(){} // RVA: 0xBA9BA0
        public void OnPurchaseSuccessful(){} // RVA: 0x7D7E700
        public void OnPurchaseFailed(){} // RVA: 0x7D7E7D0
        public void NotifyDeferredPurchase(){} // RVA: 0x7D7E830
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7D7EA70
    }

    public class GooglePlayStore : AbstractStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D7ED90
        public void Initialize(){} // RVA: 0x7D7F090
        public void RetrieveProducts(){} // RVA: 0x7D7F280
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7D7F3E0
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7D7F430
        public void Purchase(){} // RVA: 0x7D7F4E0
        public void FinishTransaction(){} // RVA: 0x7D7F540
        public void OnPause(){} // RVA: 0x7D7F5C0
    }

    public class GooglePlayStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D7F650
        public void SetStoreCallback(){} // RVA: 0xB708C0
        public void IsPurchasedProductDeferred(){} // RVA: 0x7D7F7A0
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7D7F900
        public void GetPurchaseState(){} // RVA: 0x7D7F930
        public void GooglePurchaseFromProduct(){} // RVA: 0x7D7FB20
    }

    public class GooglePlayStoreFinishTransactionService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D81580
        public void SetStoreCallback(){} // RVA: 0xB70100
        public void FinishTransaction(){} // RVA: 0x7D816A0
        public void HandleFinishTransaction(){} // RVA: 0x7D81850
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7D81D70
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7D81E70
    }

    public class GooglePlayStorePurchaseService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Purchase(){} // RVA: 0x7D81F40
    }

    public class GooglePlayStoreRetrieveProductsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D81FA0
        public void SetStoreCallback(){} // RVA: 0xB70100
        public void RetrieveProducts(){} // RVA: 0x7D82100
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7D82230
        public void OnProductsRetrieved(){} // RVA: 0x7D82580
        public void OnRetrieveProductsFailed(){} // RVA: 0x7D82660
        public void ResumeConnection(){} // RVA: 0x7D82770
        public void MakePurchasesIntoProducts(){} // RVA: 0x7D827C0
        public void IsPurchasedProductDeferred(){} // RVA: 0x7D82C90
        public void HasInitiallyRetrievedProducts(){} // RVA: 0xD16660
    }

    public class GooglePlayStoreService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D72C80
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7D731C0
        public void StartConnection(){} // RVA: 0x7D73380
        public void ResumeConnection(){} // RVA: 0x7D733E0
        public void AttemptReconnection(){} // RVA: 0x7D73450
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x264F4C0
        public void RetryConnection(){} // RVA: 0x7D73510
        public void RetryConnectionAttempt(){} // RVA: 0x7D736A0
        public void OnConnected(){} // RVA: 0x7D73730
        public void DequeueQueryProducts(){} // RVA: 0x7D73780
        public void DequeueFetchPurchases(){} // RVA: 0x7D73D10
        public void OnDisconnected(){} // RVA: 0x7D73ED0
        public void RetrieveProducts(){} // RVA: 0x7D73F00
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7D73FC0
        public void Purchase(){} // RVA: 0x7D741F0
        public void FinishTransaction(){} // RVA: 0x7D743E0
        public void FetchPurchases(){} // RVA: 0x7D74460
        public void TryFetchPurchases(){} // RVA: 0x7D74680
        public void GetPurchase(){} // RVA: 0x7D74880
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7D73510
    }

    public class GoogleProductMetadata : ProductMetadata
    {
        // ── Methods ──
        public void get_originalJson(){} // RVA: 0xBC1B30
        public void set_originalJson(){} // RVA: 0xB6A8C0
        public void set_subscriptionPeriod(){} // RVA: 0xBBF900
        public void set_freeTrialPeriod(){} // RVA: 0xCA4DF0
        public void set_introductoryPrice(){} // RVA: 0xC0FFD0
        public void set_introductoryPricePeriod(){} // RVA: 0xBE2C70
        public void set_introductoryPriceCycles(){} // RVA: 0x25406E0
        public void .ctor(){} // RVA: 0x7D7FDB0
    }

    public class GooglePurchaseService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void Purchase(){} // RVA: 0x7D750A0
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7D75300
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7D753C0
        public void ValidateSkus(){} // RVA: 0x7D75760
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7D75910
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7D75A90
        public void ValidateOldProduct(){} // RVA: 0x7D75B60
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7D75BF0
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7D75CF0
        public void HandleBillingFlowResult(){} // RVA: 0x7D75F60
    }

    public class GooglePurchaseUpdatedListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D77C20
        public void SetGoogleQueryPurchaseService(){} // RVA: 0xBBF900
        public void onPurchasesUpdated(){} // RVA: 0x7D77EB0
        public void OnPurchasesUpdated(){} // RVA: 0x7D782E0
        public void HandleResultOkCases(){} // RVA: 0x7D784D0
        public void HandleErrorCases(){} // RVA: 0x7D785B0
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7D786A0
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7D78BF0
        public void ApplyOnPurchases(){} // RVA: 0x7D78F40
        public void OnPurchaseOk(){} // RVA: 0x7D791D0
        public void HandlePurchasedProduct(){} // RVA: 0x7D79490
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7D795C0
        public void IsLastProrationModeDeferred(){} // RVA: 0x7D79780
        public void OnPurchaseCancelled(){} // RVA: 0x7D79990
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7D79A80
        public void OnPurchaseFailed(){} // RVA: 0x7D79B70
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7D79C80
    }

    public class GooglePurchasesResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D777F0
        public void onQueryPurchasesResponse(){} // RVA: 0x7D778B0
    }

    public class GoogleQueryPurchasesService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void QueryPurchases(){} // RVA: 0x7D761B0
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7D76330
        public void GetPurchaseByToken(){} // RVA: 0x7D76530
        public void IsResultOk(){} // RVA: 0x7D767B0
    }

}