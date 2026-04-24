// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension : Object
    {
        // ── Binary Analysis Named ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7ffaaf3e51a0
    }

    public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3de390
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7ffaaf3de450
    }

    public class GoogleCachedQueryProductDetailsService : Object
    {
        public object (00; // 0x84FA5540

        // ── Original Methods ──
        public void Finalize(){} // RVA: 0x7ffaaf3d7e60
        public void Contains(){} // RVA: 0x7ffaaf3d8480
        public void Contains(){} // RVA: 0x7ffaaf3d8480
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7ffaaf3d8500
        public void .ctor(){} // RVA: 0x7ffaaf3d87a0
        // ── Binary Analysis Named ──
        public void GetCachedQueriedProducts(){} // RVA: 0x7ffaaf3d8020
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7ffaaf3d8170
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7ffaaf3d8170
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7ffaaf3d8170
    }

    public class GoogleConnectionRetryPolicy : Object
    {
        public object m_ExponentialFactor; // 0x33AA79F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa2b9690
        public void Invoke(){} // RVA: 0x7ffaaf404f60
        public void AdjustDelay(){} // RVA: 0x7ffaaf405270
    }

    public class GoogleConsumeResponseListener : AndroidJavaProxy
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3de4f0
        public void onConsumeResponse(){} // RVA: 0x7ffaaf3de5b0
    }

    public class GoogleFetchPurchases : Object
    {
        public object m_Util; // 0x338B58D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae611500
        public void FetchPurchases(){} // RVA: 0x7ffaaf3e6c80
        public void FetchPurchases(){} // RVA: 0x7ffaaf3e6c80
        public void FillProductsWithPurchases(){} // RVA: 0x7ffaaf3e6e00
        public void BuildProductsFromPurchase(){} // RVA: 0x7ffaaf3e6f30
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7ffaaf3e7190
        public void OnFetchedPurchase(){} // RVA: 0x7ffaaf3e72c0
        public void PurchaseIsPurchased(){} // RVA: 0x7ffaaf3e7840
        public void PurchaseIsPending(){} // RVA: 0x7ffaaf3e7980
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7ffaaf3e7ac0
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7ffaaf3e7c10
        public void UpdateDeferredProduct(){} // RVA: 0x7ffaaf3e7ec0
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8998e80
    }

    public class GoogleFinishTransactionService : Object
    {
        public object (00; // 0x84F6A5F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void FinishTransaction(){} // RVA: 0x7ffaaf3d8900
        public void FindPurchase(){} // RVA: 0x7ffaaf3d8be0
        public void FinishTransactionForPurchase(){} // RVA: 0x7ffaaf3d8dd0
    }

    public class GoogleLastKnownProductService : Object
    {
        public object _lastKnownProrationMode; // 0x338EDE40, was: <LastKnownProrationMode>k__Bac

        // ── Original Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7ffaa894d380
        public void set_LastKnownOldProductId(){} // RVA: 0x7ffaa8933e30
        public void get_LastKnownProductId(){} // RVA: 0x7ffaa89357c0
        public void set_LastKnownProductId(){} // RVA: 0x7ffaa8998e80
        public void get_LastKnownProrationMode(){} // RVA: 0x7ffaa89600c0
        public void set_LastKnownProrationMode(){} // RVA: 0x7ffaa9137320
        public void .ctor(){} // RVA: 0x7ffaaf3d9920
    }

    public class GooglePlayConfiguration : Object
    {
        public object m_DeferredPurchaseAction; // 0x33AAE2A0
        public object m_FetchPurchasesAtInitialize; // 0x33AAE2A0
        public object SetStoreConfiguration; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e5230
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7ffaa8c272e0
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7ffaa91f68d0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7ffaaf3e5290
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7ffaae0ed830
        public void NotifyDeferredPurchase(){} // RVA: 0x7ffaaf3e52e0
        // ── Binary Analysis Named ──
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7ffaa8de79d0
    }

    public class GooglePlayProductCallback : Object
    {
        // ── Original Methods ──
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7ffaaf3e5470
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void SetStoreConfiguration(){} // RVA: 0x7ffaa8933e30
    }

    public class GooglePlayPurchaseCallback : Object
    {
        public object m_Util; // 0x336419E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa89600d0
        public void OnPurchaseSuccessful(){} // RVA: 0x7ffaaf3e54d0
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3e55b0
        public void NotifyDeferredPurchase(){} // RVA: 0x7ffaaf3e5610
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7ffaaf3e5850
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8933e30
        public void SetStoreConfiguration(){} // RVA: 0x7ffaa8998e80
    }

    public class GooglePlayStore : AbstractStore
    {
        public object m_FetchPurchases; // 0x333F4A80
        public object m_GooglePlayStoreExtensions; // 0x333F4A80

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e5b70
        public void Initialize(){} // RVA: 0x7ffaaf3e5e70
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3e6060
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7ffaaf3e61c0
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7ffaaf3e6210
        public void Purchase(){} // RVA: 0x7ffaaf3e62c0
        public void FinishTransaction(){} // RVA: 0x7ffaaf3e6320
        public void OnPause(){} // RVA: 0x7ffaaf3e63a0
    }

    public class GooglePlayStoreExtensions : Object
    {
        public object m_TelemetryDiagnostics; // 0x3361BA90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e6430
        public void IsPurchasedProductDeferred(){} // RVA: 0x7ffaaf3e6580
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7ffaaf3e66e0
        public void GooglePurchaseFromProduct(){} // RVA: 0x7ffaaf3e6900
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8960890
        public void GetPurchaseState(){} // RVA: 0x7ffaaf3e6710
    }

    public class GooglePlayStoreFinishTransactionService : Object
    {
        public object m_StoreCallback; // 0x3374DDD0
        public object (00; // 0x84FC9248
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e8320
        public void FinishTransaction(){} // RVA: 0x7ffaaf3e8440
        public void HandleFinishTransaction(){} // RVA: 0x7ffaaf3e85f0
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7ffaaf3e8b20
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7ffaaf3e8c30
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa89600d0
    }

    public class GooglePlayStorePurchaseService : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Purchase(){} // RVA: 0x7ffaaf3e8d00
    }

    public class GooglePlayStoreRetrieveProductsService : Object
    {
        public object m_StoreCallback; // 0x336D6A20
        public object m_HasInitiallyRetrievedProducts; // 0x336D6A20
        public object (00; // 0x84FB14E0
        public object FindProductById; // 0xB41B83E0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e8d60
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3e8ec0
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7ffaaf3e8ff0
        public void OnProductsRetrieved(){} // RVA: 0x7ffaaf3e9340
        public void OnRetrieveProductsFailed(){} // RVA: 0x7ffaaf3e9420
        public void ResumeConnection(){} // RVA: 0x7ffaaf3e9530
        public void MakePurchasesIntoProducts(){} // RVA: 0x7ffaaf3e9580
        public void IsPurchasedProductDeferred(){} // RVA: 0x7ffaaf3e9a50
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7ffaa8bfcc70
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa89600d0
    }

    public class GooglePlayStoreService : Object
    {
        public object m_BillingClient; // 0x335F90B0
        public object m_ProductsToQuery; // 0x335F90B0
        public object m_GoogleFinishTransactionService; // 0x335F90B0
        public object m_TelemetryDiagnostics; // 0x335F90B0
        public object m_Util; // 0x335F90B0
        public object (00; // 0x84FA9578

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d9970
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7ffaaf3d9eb0
        public void StartConnection(){} // RVA: 0x7ffaaf3da070
        public void ResumeConnection(){} // RVA: 0x7ffaaf3da0d0
        public void AttemptReconnection(){} // RVA: 0x7ffaaf3da140
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x7ffaaa2c64b0
        public void RetryConnection(){} // RVA: 0x7ffaaf3da200
        public void RetryConnectionAttempt(){} // RVA: 0x7ffaaf3da390
        public void OnConnected(){} // RVA: 0x7ffaaf3da420
        public void DequeueQueryProducts(){} // RVA: 0x7ffaaf3da470
        public void DequeueFetchPurchases(){} // RVA: 0x7ffaaf3daa00
        public void OnDisconnected(){} // RVA: 0x7ffaaf3dabc0
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3dabf0
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7ffaaf3dacb0
        public void Purchase(){} // RVA: 0x7ffaaf3daee0
        public void Purchase(){} // RVA: 0x7ffaaf3daee0
        public void FinishTransaction(){} // RVA: 0x7ffaaf3db0d0
        public void FetchPurchases(){} // RVA: 0x7ffaaf3db150
        public void TryFetchPurchases(){} // RVA: 0x7ffaaf3db370
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7ffaaf3db5f0
        // ── Binary Analysis Named ──
        public void GetPurchase(){} // RVA: 0x7ffaaf3db570
    }

    public class GoogleProductMetadata : ProductMetadata
    {
        public object _freeTrialPeriod; // 0x3372ED90, was: <freeTrialPeriod>k__BackingFie
        public object _introductoryPriceCycles; // 0x3372ED90, was: <introductoryPriceCycles>k__Ba
        public object originalJson; // 0x17000004
        public object subscriptionPeriod; // 0x17000005

        // ── Original Methods ──
        public void get_originalJson(){} // RVA: 0x7ffaa89af740
        public void set_originalJson(){} // RVA: 0x7ffaa895a200
        public void set_subscriptionPeriod(){} // RVA: 0x7ffaa89ad740
        public void set_freeTrialPeriod(){} // RVA: 0x7ffaa8a8a4d0
        public void set_introductoryPrice(){} // RVA: 0x7ffaa89fa510
        public void set_introductoryPricePeriod(){} // RVA: 0x7ffaa89d0380
        public void set_introductoryPriceCycles(){} // RVA: 0x7ffaaa1c2a50
        public void .ctor(){} // RVA: 0x7ffaaf3e6b90
    }

    public class GooglePurchaseService : Object
    {
        public object m_QueryProductDetailsService; // 0x33466B60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a11e00
        public void Purchase(){} // RVA: 0x7ffaaf3dbf20
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7ffaaf3dc180
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7ffaaf3dc240
        public void ValidateSkus(){} // RVA: 0x7ffaaf3dc5e0
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7ffaaf3dc790
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7ffaaf3dc910
        public void ValidateOldProduct(){} // RVA: 0x7ffaaf3dc9e0
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7ffaaf3dca70
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7ffaaf3dcb70
        public void HandleBillingFlowResult(){} // RVA: 0x7ffaaf3dcde0
    }

    public class GooglePurchaseUpdatedListener : AndroidJavaProxy
    {
        public object m_PurchaseBuilder; // 0x3366F6F0
        public object m_GoogleQueryPurchasesService; // 0x3366F6F0
        public object `;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3dea60
        public void onPurchasesUpdated(){} // RVA: 0x7ffaaf3decf0
        public void OnPurchasesUpdated(){} // RVA: 0x7ffaaf3df0f0
        public void HandleResultOkCases(){} // RVA: 0x7ffaaf3df2e0
        public void HandleErrorCases(){} // RVA: 0x7ffaaf3df3c0
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7ffaaf3df4b0
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7ffaaf3dfa00
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7ffaaf3dfa00
        public void ApplyOnPurchases(){} // RVA: 0x7ffaaf3dfd40
        public void ApplyOnPurchases(){} // RVA: 0x7ffaaf3dfd40
        public void OnPurchaseOk(){} // RVA: 0x7ffaaf3dffc0
        public void HandlePurchasedProduct(){} // RVA: 0x7ffaaf3e0280
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7ffaaf3e03b0
        public void IsLastProrationModeDeferred(){} // RVA: 0x7ffaaf3e0570
        public void OnPurchaseCancelled(){} // RVA: 0x7ffaaf3e0780
        public void OnPurchaseCancelled(){} // RVA: 0x7ffaaf3e0780
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7ffaaf3e0870
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3e0960
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7ffaaf3e0a70
        // ── Binary Analysis Named ──
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x7ffaa89ad740
    }

    public class GooglePurchasesResponseListener : AndroidJavaProxy
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3de650
        public void onQueryPurchasesResponse(){} // RVA: 0x7ffaaf3de710
    }

    public class GoogleQueryPurchasesService : Object
    {
        public object (00; // 0x84F6B250

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void QueryPurchases(){} // RVA: 0x7ffaaf3dd030
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7ffaaf3dd1b0
        public void IsResultOk(){} // RVA: 0x7ffaaf3dd610
        // ── Binary Analysis Named ──
        public void GetPurchaseByToken(){} // RVA: 0x7ffaaf3dd390
    }

}