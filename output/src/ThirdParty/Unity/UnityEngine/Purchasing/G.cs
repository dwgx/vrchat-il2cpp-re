// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 153

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension : Object
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7AF00AD00
    }

    public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF003E50
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7AF003F10
        // ── Unresolved (hash) ──
        public void m_OnAcknowledgePurchaseResponse(){} // RVA: 0x7B2E38B90
    }

    public class GoogleCachedQueryProductDetailsService : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7AEFFDA90
        public void GetCachedQueriedProducts(){} // RVA: 0x7AEFFDC50
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7AEFFDDA0
        public void Contains(){} // RVA: 0x7AEFFE0B0
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7AEFFE130
        public void .ctor(){} // RVA: 0x7AEFFE3D0
    }

    public class GoogleConnectionRetryPolicy : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9B8CFF0
        public void Invoke(){} // RVA: 0x7AF02B180
        public void AdjustDelay(){} // RVA: 0x7AF02B4A0
    }

    public class GoogleConsumeResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF003FB0
        public void onConsumeResponse(){} // RVA: 0x7AF004070
        // ── Unresolved (hash) ──
        public void m_OnConsumeResponse(){} // RVA: 0x7B41AC7D8
    }

    public class GoogleFetchPurchases : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE247030
        public void SetStoreCallback(){} // RVA: 0x7A813E420
        public void FetchPurchases(){} // RVA: 0x7AF00C7D0
        public void FillProductsWithPurchases(){} // RVA: 0x7AF00C950
        public void BuildProductsFromPurchase(){} // RVA: 0x7AF00CA80
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7AF00CCE0
        public void OnFetchedPurchase(){} // RVA: 0x7AF00CE20
        public void PurchaseIsPurchased(){} // RVA: 0x7AF00D3A0
        public void PurchaseIsPending(){} // RVA: 0x7AF00D4E0
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7AF00D620
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7AF00D780
        public void UpdateDeferredProduct(){} // RVA: 0x7AF00DA40
    }

    public class GoogleFinishTransactionService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void FinishTransaction(){} // RVA: 0x7AEFFE530
        public void FindPurchase(){} // RVA: 0x7AEFFE810
        public void FinishTransactionForPurchase(){} // RVA: 0x7AEFFEA00
    }

    public class GoogleLastKnownProductService : Object
    {
        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7A80F2570
        public void set_LastKnownOldProductId(){} // RVA: 0x7A80D8E20
        public void get_LastKnownProductId(){} // RVA: 0x7A80DA7B0
        public void set_LastKnownProductId(){} // RVA: 0x7A813E420
        public void get_LastKnownProrationMode(){} // RVA: 0x7A81052C0
        public void set_LastKnownProrationMode(){} // RVA: 0x7A8884B10
        public void .ctor(){} // RVA: 0x7AEFFF550
    }

    public class GooglePlayConfiguration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF00AD80
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7A8429A00
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7A894F1D0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7AF00ADE0
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7ADD23CE0
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7A82A3DE0
        public void NotifyDeferredPurchase(){} // RVA: 0x7AF00AE30
    }

    public class GooglePlayProductCallback : Object
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7A80D8E20
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7AF00AFC0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GooglePlayPurchaseCallback : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81052D0
        public void SetStoreCallback(){} // RVA: 0x7A80D8E20
        public void SetStoreConfiguration(){} // RVA: 0x7A813E420
        public void OnPurchaseSuccessful(){} // RVA: 0x7AF00B020
        public void OnPurchaseFailed(){} // RVA: 0x7AF00B100
        public void NotifyDeferredPurchase(){} // RVA: 0x7AF00B160
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7AF00B3A0
    }

    public class GooglePlayStore : AbstractStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF00B6C0
        public void Initialize(){} // RVA: 0x7AF00B9C0
        public void RetrieveProducts(){} // RVA: 0x7AF00BBB0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7AF00BD10
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7AF00BD60
        public void Purchase(){} // RVA: 0x7AF00BE10
        public void FinishTransaction(){} // RVA: 0x7AF00BE70
        public void OnPause(){} // RVA: 0x7AF00BEF0
    }

    public class GooglePlayStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF00BF80
        public void SetStoreCallback(){} // RVA: 0x7A8105A90
        public void IsPurchasedProductDeferred(){} // RVA: 0x7AF00C0D0
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7AF00C230
        public void GetPurchaseState(){} // RVA: 0x7AF00C260
        public void GooglePurchaseFromProduct(){} // RVA: 0x7AF00C450
    }

    public class GooglePlayStoreFinishTransactionService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF00DEB0
        public void SetStoreCallback(){} // RVA: 0x7A81052D0
        public void FinishTransaction(){} // RVA: 0x7AF00DFD0
        public void HandleFinishTransaction(){} // RVA: 0x7AF00E180
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7AF00E6B0
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7AF00E7C0
    }

    public class GooglePlayStorePurchaseService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Purchase(){} // RVA: 0x7AF00E890
    }

    public class GooglePlayStoreRetrieveProductsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF00E8F0
        public void SetStoreCallback(){} // RVA: 0x7A81052D0
        public void RetrieveProducts(){} // RVA: 0x7AF00EA50
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7AF00EB80
        public void OnProductsRetrieved(){} // RVA: 0x7AF00EED0
        public void OnRetrieveProductsFailed(){} // RVA: 0x7AF00EFB0
        public void ResumeConnection(){} // RVA: 0x7AF00F0C0
        public void MakePurchasesIntoProducts(){} // RVA: 0x7AF00F110
        public void IsPurchasedProductDeferred(){} // RVA: 0x7AF00F5E0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7A82A20A0
    }

    public class GooglePlayStoreService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFFF5A0
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7AEFFFAE0
        public void StartConnection(){} // RVA: 0x7AEFFFCA0
        public void ResumeConnection(){} // RVA: 0x7AEFFFD00
        public void AttemptReconnection(){} // RVA: 0x7AEFFFD70
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x7A9B980C0
        public void RetryConnection(){} // RVA: 0x7AEFFFE30
        public void RetryConnectionAttempt(){} // RVA: 0x7AEFFFFC0
        public void OnConnected(){} // RVA: 0x7AF000050
        public void DequeueQueryProducts(){} // RVA: 0x7AF0000A0
        public void DequeueFetchPurchases(){} // RVA: 0x7AF000630
        public void OnDisconnected(){} // RVA: 0x7AF0007F0
        public void RetrieveProducts(){} // RVA: 0x7AF000820
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7AF0008E0
        public void Purchase(){} // RVA: 0x7AF000B10
        public void FinishTransaction(){} // RVA: 0x7AF000D00
        public void FetchPurchases(){} // RVA: 0x7AF000D80
        public void TryFetchPurchases(){} // RVA: 0x7AF000FA0
        public void GetPurchase(){} // RVA: 0x7AF0011A0
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7AEFFFE30
    }

    public class GoogleProductMetadata : ProductMetadata
    {
        // ── Methods ──
        public void get_originalJson(){} // RVA: 0x7A8154D80
        public void set_originalJson(){} // RVA: 0x7A80FF440
        public void set_subscriptionPeriod(){} // RVA: 0x7A8152D90
        public void set_freeTrialPeriod(){} // RVA: 0x7A8230620
        public void set_introductoryPrice(){} // RVA: 0x7A81A0060
        public void set_introductoryPricePeriod(){} // RVA: 0x7A8175E00
        public void set_introductoryPriceCycles(){} // RVA: 0x7A9A93880
        public void .ctor(){} // RVA: 0x7AF00C6E0
        public void <originalJson>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class GooglePurchaseService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void Purchase(){} // RVA: 0x7AF0019C0
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7AF001C20
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7AF001CE0
        public void ValidateSkus(){} // RVA: 0x7AF002080
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7AF002230
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7AF0023B0
        public void ValidateOldProduct(){} // RVA: 0x7AF002480
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7AF002510
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7AF002610
        public void HandleBillingFlowResult(){} // RVA: 0x7AF002880
    }

    public class GooglePurchaseUpdatedListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF004540
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x7A8152D90
        public void onPurchasesUpdated(){} // RVA: 0x7AF0047D0
        public void OnPurchasesUpdated(){} // RVA: 0x7AF004C00
        public void HandleResultOkCases(){} // RVA: 0x7AF004DF0
        public void HandleErrorCases(){} // RVA: 0x7AF004ED0
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7AF004FC0
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7AF005510
        public void ApplyOnPurchases(){} // RVA: 0x7AF005860
        public void OnPurchaseOk(){} // RVA: 0x7AF005AF0
        public void HandlePurchasedProduct(){} // RVA: 0x7AF005DB0
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7AF005EE0
        public void IsLastProrationModeDeferred(){} // RVA: 0x7AF0060A0
        public void OnPurchaseCancelled(){} // RVA: 0x7AF0062B0
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7AF0063A0
        public void OnPurchaseFailed(){} // RVA: 0x7AF006490
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7AF0065A0
    }

    public class GooglePurchasesResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF004110
        public void onQueryPurchasesResponse(){} // RVA: 0x7AF0041D0
        // ── Unresolved (hash) ──
        public void m_OnQueryPurchasesResponse(){} // RVA: 0x7B41AC7D8
    }

    public class GoogleQueryPurchasesService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void QueryPurchases(){} // RVA: 0x7AF002AD0
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7AF002C50
        public void GetPurchaseByToken(){} // RVA: 0x7AF002E50
        public void IsResultOk(){} // RVA: 0x7AF0030D0
    }

}