// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension : Object
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7FFAC99C3240
    }

    public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
    {
        public System.Action`1<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnAcknowledgePurchaseResponse; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BC430
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7FFAC99BC4F0
    }

    public class GoogleCachedQueryProductDetailsService : Object
    {
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.AndroidJavaObject> m_CachedQueriedProductDetails; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC99B5F00
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFAC99B60C0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFAC99B6210 | overloaded x3
        public void Contains(){} // RVA: 0x7FFAC99B6520 | overloaded x2
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFAC99B65A0
        public void .ctor(){} // RVA: 0x7FFAC99B6840
    }

    public class GoogleConnectionRetryPolicy : Object
    {
        public int m_BaseRetryDelay; // 0x10
        public int m_MaxRetryDelay; // 0x14
        public int m_ExponentialFactor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC48B1250
        public void Invoke(){} // RVA: 0x7FFAC99E3000
        public void AdjustDelay(){} // RVA: 0x7FFAC99E3310
    }

    public class GoogleConsumeResponseListener : AndroidJavaProxy
    {
        public System.Action`1<UnityEngine.Purchasing.Models.IGoogleBillingResult> m_OnConsumeResponse; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BC590
        public void onConsumeResponse(){} // RVA: 0x7FFAC99BC650
    }

    public class GoogleFetchPurchases : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
        public UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback; // 0x18
        public Uniject.IUtil m_Util; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BF0300
        public void SetStoreCallback(){} // RVA: 0x7FFAC2F87E80
        public void FetchPurchases(){} // RVA: 0x7FFAC99C4D20 | overloaded x2
        public void FillProductsWithPurchases(){} // RVA: 0x7FFAC99C4EA0
        public void BuildProductsFromPurchase(){} // RVA: 0x7FFAC99C4FD0
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7FFAC99C5230
        public void OnFetchedPurchase(){} // RVA: 0x7FFAC99C5360
        public void PurchaseIsPurchased(){} // RVA: 0x7FFAC99C58E0
        public void PurchaseIsPending(){} // RVA: 0x7FFAC99C5A20
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7FFAC99C5B60
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7FFAC99C5CB0
        public void UpdateDeferredProduct(){} // RVA: 0x7FFAC99C5F60
    }

    public class GoogleFinishTransactionService : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient; // 0x10
        public UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void FinishTransaction(){} // RVA: 0x7FFAC99B69A0
        public void FindPurchase(){} // RVA: 0x7FFAC99B6C80
        public void FinishTransactionForPurchase(){} // RVA: 0x7FFAC99B6E70
    }

    public class GoogleLastKnownProductService : Object
    {
        public string LastKnownOldProductId; // 0x10
        public string LastKnownProductId; // 0x18
        public System.Nullable`1<0x6B27B750> LastKnownProrationMode; // 0x20

        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7FFAC2F3C380
        public void set_LastKnownOldProductId(){} // RVA: 0x7FFAC2F22E30
        public void get_LastKnownProductId(){} // RVA: 0x7FFAC2F247C0
        public void set_LastKnownProductId(){} // RVA: 0x7FFAC2F87E80
        public void get_LastKnownProrationMode(){} // RVA: 0x7FFAC2F4F0C0
        public void set_LastKnownProrationMode(){} // RVA: 0x7FFAC370BEE0
        public void .ctor(){} // RVA: 0x7FFAC99B79C0
    }

    public class GooglePlayConfiguration : Object
    {
        public System.Action m_InitializationConnectionLister; // 0x10
        public UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService; // 0x18
        public System.Action`1<UnityEngine.Purchasing.Product> m_DeferredPurchaseAction; // 0x20
        public System.Action`1<UnityEngine.Purchasing.Product> m_DeferredProrationUpgradeDowngradeSubscriptionAction; // 0x28
        public System.Action`1<int> m_QueryProductDetailsFailedListener; // 0x30
        public bool m_FetchPurchasesAtInitialize; // 0x38
        public bool m_FetchPurchasesExcludeDeferred; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C32D0
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFAC3203950
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFAC37CD440
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFAC99C3330
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFAC86CC620
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFAC33BCE50
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFAC99C3380
    }

    public class GooglePlayProductCallback : Object
    {
        public UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x10

        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7FFAC2F22E30
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFAC99C3510
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GooglePlayPurchaseCallback : Object
    {
        public UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback; // 0x10
        public UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x18
        public Uniject.IUtil m_Util; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F4F0D0
        public void SetStoreCallback(){} // RVA: 0x7FFAC2F22E30
        public void SetStoreConfiguration(){} // RVA: 0x7FFAC2F87E80
        public void OnPurchaseSuccessful(){} // RVA: 0x7FFAC99C3570
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC99C3650
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFAC99C36B0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFAC99C38F0
    }

    public class GooglePlayStore : AbstractStore
    {
        public UnityEngine.Purchasing.IGooglePlayStoreRetrieveProductsService m_RetrieveProductsService; // 0x10
        public UnityEngine.Purchasing.IGooglePlayStorePurchaseService m_StorePurchaseService; // 0x18
        public UnityEngine.Purchasing.IGoogleFetchPurchases m_FetchPurchases; // 0x20
        public UnityEngine.Purchasing.IGooglePlayStoreFinishTransactionService m_FinishTransactionService; // 0x28
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x30
        public UnityEngine.Purchasing.IGooglePlayStoreExtensionsInternal m_GooglePlayStoreExtensions; // 0x38
        public UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x40
        public Uniject.IUtil m_Util; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C3C10
        public void Initialize(){} // RVA: 0x7FFAC99C3F10
        public void RetrieveProducts(){} // RVA: 0x7FFAC99C4100
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFAC99C4260
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7FFAC99C42B0
        public void Purchase(){} // RVA: 0x7FFAC99C4360
        public void FinishTransaction(){} // RVA: 0x7FFAC99C43C0
        public void OnPause(){} // RVA: 0x7FFAC99C4440
    }

    public class GooglePlayStoreExtensions : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; // 0x18
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x20
        public UnityEngine.ILogger m_Logger; // 0x28
        public UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C44D0
        public void SetStoreCallback(){} // RVA: 0x7FFAC2F4F890
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAC99C4620
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7FFAC99C4780
        public void GetPurchaseState(){} // RVA: 0x7FFAC99C47B0
        public void GooglePurchaseFromProduct(){} // RVA: 0x7FFAC99C49A0
    }

    public class GooglePlayStoreFinishTransactionService : Object
    {
        public System.Collections.Generic.HashSet`1<string> m_ProcessedPurchaseToken; // 0x10
        public UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService; // 0x18
        public UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback; // 0x20
        public int m_RetryCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C63C0
        public void SetStoreCallback(){} // RVA: 0x7FFAC2F4F0D0
        public void FinishTransaction(){} // RVA: 0x7FFAC99C64E0
        public void HandleFinishTransaction(){} // RVA: 0x7FFAC99C6690
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7FFAC99C6BC0
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7FFAC99C6CD0
    }

    public class GooglePlayStorePurchaseService : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Purchase(){} // RVA: 0x7FFAC99C6DA0
    }

    public class GooglePlayStoreRetrieveProductsService : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGooglePlayStoreService m_GooglePlayStoreService; // 0x10
        public UnityEngine.Purchasing.IGoogleFetchPurchases m_GoogleFetchPurchases; // 0x18
        public UnityEngine.Purchasing.Extension.IStoreCallback m_StoreCallback; // 0x20
        public UnityEngine.Purchasing.IGooglePlayConfigurationInternal m_GooglePlayConfigurationInternal; // 0x28
        public UnityEngine.Purchasing.IGooglePlayStoreExtensions m_GooglePlayStoreExtensions; // 0x30
        public bool m_HasInitiallyRetrievedProducts; // 0x38
        public bool m_RetrieveProductsFailed; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C6E00
        public void SetStoreCallback(){} // RVA: 0x7FFAC2F4F0D0
        public void RetrieveProducts(){} // RVA: 0x7FFAC99C6F60
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7FFAC99C7090
        public void OnProductsRetrieved(){} // RVA: 0x7FFAC99C73E0
        public void OnRetrieveProductsFailed(){} // RVA: 0x7FFAC99C74C0
        public void ResumeConnection(){} // RVA: 0x7FFAC99C75D0
        public void MakePurchasesIntoProducts(){} // RVA: 0x7FFAC99C7620
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFAC99C7AF0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFAC31D95D0
    }

    public class GooglePlayStoreService : Object
    {
        public int m_CurrentConnectionAttempts; // 0x10
        public int m_MaxConnectionAttempts; // 0x14
        public UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient; // 0x18
        public UnityEngine.Purchasing.Interfaces.IBillingClientStateListener m_BillingClientStateListener; // 0x20
        public UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService; // 0x28
        public System.Collections.Concurrent.ConcurrentQueue`1<UnityEngine.Purchasing.Models.ProductDescriptionQuery> m_ProductsToQuery; // 0x30
        public System.Collections.Concurrent.ConcurrentQueue`1<System.Action`1<System.Collections.Generic.List`1<UnityEngine.Purchasing.Interfaces.IGooglePurchase>>> m_OnPurchaseSucceededQueue; // 0x38
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseService m_GooglePurchaseService; // 0x40
        public UnityEngine.Purchasing.Interfaces.IGoogleFinishTransactionService m_GoogleFinishTransactionService; // 0x48
        public UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x50
        public UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_GoogleLastKnownProductService; // 0x58
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x60
        public UnityEngine.ILogger m_Logger; // 0x68
        public UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy; // 0x70
        public Uniject.IUtil m_Util; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B7A10
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7FFAC99B7F50
        public void StartConnection(){} // RVA: 0x7FFAC99B8110
        public void ResumeConnection(){} // RVA: 0x7FFAC99B8170
        public void AttemptReconnection(){} // RVA: 0x7FFAC99B81E0
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x7FFAC48BD170
        public void RetryConnection(){} // RVA: 0x7FFAC99B82A0
        public void RetryConnectionAttempt(){} // RVA: 0x7FFAC99B8430
        public void OnConnected(){} // RVA: 0x7FFAC99B84C0
        public void DequeueQueryProducts(){} // RVA: 0x7FFAC99B8510
        public void DequeueFetchPurchases(){} // RVA: 0x7FFAC99B8AA0
        public void OnDisconnected(){} // RVA: 0x7FFAC99B8C60
        public void RetrieveProducts(){} // RVA: 0x7FFAC99B8C90
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7FFAC99B8D50
        public void Purchase(){} // RVA: 0x7FFAC99B8F80 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFAC99B9170
        public void FetchPurchases(){} // RVA: 0x7FFAC99B91F0
        public void TryFetchPurchases(){} // RVA: 0x7FFAC99B9410
        public void GetPurchase(){} // RVA: 0x7FFAC99B9610
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7FFAC99B9690
    }

    public class GoogleProductMetadata : ProductMetadata
    {
        public string originalJson; // 0x40
        public string subscriptionPeriod; // 0x48
        public string freeTrialPeriod; // 0x50
        public string introductoryPrice; // 0x58
        public string introductoryPricePeriod; // 0x60
        public int introductoryPriceCycles; // 0x68

        // ── Methods ──
        public void get_originalJson(){} // RVA: 0x7FFAC2F9E740
        public void set_originalJson(){} // RVA: 0x7FFAC2F49200
        public void set_subscriptionPeriod(){} // RVA: 0x7FFAC2F9C740
        public void set_freeTrialPeriod(){} // RVA: 0x7FFAC30794D0
        public void set_introductoryPrice(){} // RVA: 0x7FFAC2FE9510
        public void set_introductoryPricePeriod(){} // RVA: 0x7FFAC2FBF380
        public void set_introductoryPriceCycles(){} // RVA: 0x7FFAC47BAB60
        public void .ctor(){} // RVA: 0x7FFAC99C4C30
    }

    public class GooglePurchaseService : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient; // 0x10
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x18
        public UnityEngine.Purchasing.Interfaces.IQueryProductDetailsService m_QueryProductDetailsService; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void Purchase(){} // RVA: 0x7FFAC99B9FC0
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7FFAC99BA220
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7FFAC99BA2E0
        public void ValidateSkus(){} // RVA: 0x7FFAC99BA680
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7FFAC99BA830
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7FFAC99BA9B0
        public void ValidateOldProduct(){} // RVA: 0x7FFAC99BAA80
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7FFAC99BAB10
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7FFAC99BAC10
        public void HandleBillingFlowResult(){} // RVA: 0x7FFAC99BAE80
    }

    public class GooglePurchaseUpdatedListener : AndroidJavaProxy
    {
        public UnityEngine.Purchasing.Interfaces.IGoogleLastKnownProductService m_LastKnownProductService; // 0x20
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseCallback m_GooglePurchaseCallback; // 0x28
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder; // 0x30
        public UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService; // 0x38
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseStateEnumProvider m_GooglePurchaseStateEnumProvider; // 0x40
        public UnityEngine.Purchasing.Interfaces.IGoogleQueryPurchasesService m_GoogleQueryPurchasesService; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BCB00
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x7FFAC2F9C740
        public void onPurchasesUpdated(){} // RVA: 0x7FFAC99BCD90
        public void OnPurchasesUpdated(){} // RVA: 0x7FFAC99BD190
        public void HandleResultOkCases(){} // RVA: 0x7FFAC99BD380
        public void HandleErrorCases(){} // RVA: 0x7FFAC99BD460
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7FFAC99BD550
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7FFAC99BDAA0 | overloaded x2
        public void ApplyOnPurchases(){} // RVA: 0x7FFAC99BDDE0 | overloaded x2
        public void OnPurchaseOk(){} // RVA: 0x7FFAC99BE060
        public void HandlePurchasedProduct(){} // RVA: 0x7FFAC99BE320
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7FFAC99BE450
        public void IsLastProrationModeDeferred(){} // RVA: 0x7FFAC99BE610
        public void OnPurchaseCancelled(){} // RVA: 0x7FFAC99BE820 | overloaded x2
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7FFAC99BE910
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC99BEA00
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7FFAC99BEB10
    }

    public class GooglePurchasesResponseListener : AndroidJavaProxy
    {
        public System.Action`2<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable`1<UnityEngine.AndroidJavaObject>> m_OnQueryPurchasesResponse; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BC6F0
        public void onQueryPurchasesResponse(){} // RVA: 0x7FFAC99BC7B0
    }

    public class GoogleQueryPurchasesService : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient; // 0x10
        public UnityEngine.Purchasing.Interfaces.IGooglePurchaseBuilder m_PurchaseBuilder; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void QueryPurchases(){} // RVA: 0x7FFAC99BB0D0
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7FFAC99BB250
        public void GetPurchaseByToken(){} // RVA: 0x7FFAC99BB430
        public void IsResultOk(){} // RVA: 0x7FFAC99BB6B0
    }

}