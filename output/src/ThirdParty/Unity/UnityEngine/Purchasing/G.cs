// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 22
// Methods: 157

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class GetGoogleProductMetadataExtension : Object
    {
        // ── Methods ──
        public void GetGoogleProductMetadata(){} // RVA: 0x7FFD54DE3240
    }

    public class GoogleAcknowledgePurchaseListener : AndroidJavaProxy
    {
        public ileFullDirectoryInformation<oductDetails>b__5_0.nt> m_OnAcknowledgePurchaseResponse; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDC430
        public void onAcknowledgePurchaseResponse(){} // RVA: 0x7FFD54DDC4F0
    }

    public class GoogleCachedQueryProductDetailsService : Object
    {
        public URA.DateTime<string,?> m_CachedQueriedProductDetails; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFD54DD5F00
        public void GetCachedQueriedProducts(){} // RVA: 0x7FFD54DD60C0
        public void GetCachedQueriedProductDetails(){} // RVA: 0x7FFD54DD6210 | overloaded x3
        public void Contains(){} // RVA: 0x7FFD54DD6520 | overloaded x2
        public void AddCachedQueriedProductDetails(){} // RVA: 0x7FFD54DD65A0
        public void .ctor(){} // RVA: 0x7FFD54DD6840
    }

    public class GoogleConnectionRetryPolicy : Object
    {
        public int m_BaseRetryDelay; // 0x10
        public int m_MaxRetryDelay; // 0x14
        public int m_ExponentialFactor; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FCD1250
        public void Invoke(){} // RVA: 0x7FFD54E03000
        public void AdjustDelay(){} // RVA: 0x7FFD54E03310
    }

    public class GoogleConsumeResponseListener : AndroidJavaProxy
    {
        public ileFullDirectoryInformation<oductDetails>b__5_0.nt> m_OnConsumeResponse; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDC590
        public void onConsumeResponse(){} // RVA: 0x7FFD54DDC650
    }

    public class GoogleFetchPurchases : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.rializeProductDescriptions m_GooglePlayStoreService; // 0x10
        public ra.__0 m_StoreCallback; // 0x18
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54010300
        public void SetStoreCallback(){} // RVA: 0x7FFD4E3A7E80
        public void FetchPurchases(){} // RVA: 0x7FFD54DE4D20 | overloaded x2
        public void FillProductsWithPurchases(){} // RVA: 0x7FFD54DE4EA0
        public void BuildProductsFromPurchase(){} // RVA: 0x7FFD54DE4FD0
        public void CompleteProductInfoWithPurchase(){} // RVA: 0x7FFD54DE5230
        public void OnFetchedPurchase(){} // RVA: 0x7FFD54DE5360
        public void PurchaseIsPurchased(){} // RVA: 0x7FFD54DE58E0
        public void PurchaseIsPending(){} // RVA: 0x7FFD54DE5A20
        public void UpdateDeferredProductsByPurchases(){} // RVA: 0x7FFD54DE5B60
        public void UpdateDeferredProductsByPurchase(){} // RVA: 0x7FFD54DE5CB0
        public void UpdateDeferredProduct(){} // RVA: 0x7FFD54DE5F60
    }

    public class GoogleFinishTransactionService : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.2B240EB m_BillingClient; // 0x10
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.yProductDetailsService m_GoogleQueryPurchasesService; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void FinishTransaction(){} // RVA: 0x7FFD54DD69A0
        public void FindPurchase(){} // RVA: 0x7FFD54DD6C80
        public void FinishTransactionForPurchase(){} // RVA: 0x7FFD54DD6E70
    }

    public class GoogleLastKnownProductService : Object
    {
        public string LastKnownOldProductId; // 0x10
        public string LastKnownProductId; // 0x18
        public aphy<ing.formNames> LastKnownProrationMode; // 0x20

        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7FFD4E35C380
        public void set_LastKnownOldProductId(){} // RVA: 0x7FFD4E342E30
        public void get_LastKnownProductId(){} // RVA: 0x7FFD4E3447C0
        public void set_LastKnownProductId(){} // RVA: 0x7FFD4E3A7E80
        public void get_LastKnownProrationMode(){} // RVA: 0x7FFD4E36F0C0
        public void set_LastKnownProrationMode(){} // RVA: 0x7FFD4EB2BEE0
        public void .ctor(){} // RVA: 0x7FFD54DD79C0
    }

    public class GooglePlayConfiguration : Object
    {
        public ÎÌÍÏÏÌÍÏ m_InitializationConnectionLister; // 0x10
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.rializeProductDescriptions m_GooglePlayStoreService; // 0x18
        public ileFullDirectoryInformation<ing.urrable> m_DeferredPurchaseAction; // 0x20
        public ileFullDirectoryInformation<ing.urrable> m_DeferredProrationUpgradeDowngradeSubscriptionAction; // 0x28
        public ileFullDirectoryInformation<int> m_QueryProductDetailsFailedListener; // 0x30
        public bool m_FetchPurchasesAtInitialize; // 0x38
        public bool m_FetchPurchasesExcludeDeferred; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE32D0
        public void NotifyInitializationConnectionFailed(){} // RVA: 0x7FFD4E623950
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFD4EBED440
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFD54DE3330
        public void IsFetchPurchasesAtInitializeSkipped(){} // RVA: 0x7FFD53AEC620
        public void DoesRetrievePurchasesExcludeDeferred(){} // RVA: 0x7FFD4E7DCE50
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFD54DE3380
    }

    public class GooglePlayProductCallback : Object
    {
        public ing.TotalEncodedSeconds m_GooglePlayConfigurationInternal; // 0x10

        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7FFD4E342E30
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFD54DE3510
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class GooglePlayPurchaseCallback : Object
    {
        public ra.__0 m_StoreCallback; // 0x10
        public ing.TotalEncodedSeconds m_GooglePlayConfigurationInternal; // 0x18
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E36F0D0
        public void SetStoreCallback(){} // RVA: 0x7FFD4E342E30
        public void SetStoreConfiguration(){} // RVA: 0x7FFD4E3A7E80
        public void OnPurchaseSuccessful(){} // RVA: 0x7FFD54DE3570
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DE3650
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFD54DE36B0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFD54DE38F0
    }

    public class GooglePlayStore : AbstractStore
    {
        public ing.unt m_RetrieveProductsService; // 0x10
        public ing.nelCount m_StorePurchaseService; // 0x18
        public ing.nityAudioSampleRate m_FetchPurchases; // 0x20
        public ing.t_UnityAudioSampleRate m_FinishTransactionService; // 0x28
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.eloperPayload m_GooglePurchaseCallback; // 0x30
        public ing.Source m_GooglePlayStoreExtensions; // 0x38
        public ing.TotalEncodedSeconds m_GooglePlayConfigurationInternal; // 0x40
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE3C10
        public void Initialize(){} // RVA: 0x7FFD54DE3F10
        public void RetrieveProducts(){} // RVA: 0x7FFD54DE4100
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFD54DE4260
        public void ShouldFetchPurchasesNext(){} // RVA: 0x7FFD54DE42B0
        public void Purchase(){} // RVA: 0x7FFD54DE4360
        public void FinishTransaction(){} // RVA: 0x7FFD54DE43C0
        public void OnPause(){} // RVA: 0x7FFD54DE4440
    }

    public class GooglePlayStoreExtensions : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.rializeProductDescriptions m_GooglePlayStoreService; // 0x10
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.GetUnityPlayerClass m_GooglePurchaseStateEnumProvider; // 0x18
        public ÌÍÏÏÏ.ÌÎÍÍÏÍÏÎÏÎÏÌÍÏÏÏ m_TelemetryDiagnostics; // 0x20
        public Identifiers m_Logger; // 0x28
        public ra.__0 m_StoreCallback; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE44D0
        public void SetStoreCallback(){} // RVA: 0x7FFD4E36F890
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFD54DE4620
        public void TryIsPurchasedProductDeferred(){} // RVA: 0x7FFD54DE4780
        public void GetPurchaseState(){} // RVA: 0x7FFD54DE47B0
        public void GooglePurchaseFromProduct(){} // RVA: 0x7FFD54DE49A0
    }

    public class GooglePlayStoreFinishTransactionService : Object
    {
        public URA.onsDepth<string> m_ProcessedPurchaseToken; // 0x10
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.rializeProductDescriptions m_GooglePlayStoreService; // 0x18
        public ra.__0 m_StoreCallback; // 0x20
        public int m_RetryCount; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE63C0
        public void SetStoreCallback(){} // RVA: 0x7FFD4E36F0D0
        public void FinishTransaction(){} // RVA: 0x7FFD54DE64E0
        public void HandleFinishTransaction(){} // RVA: 0x7FFD54DE6690
        public void CallPurchaseSucceededUpdateReceipt(){} // RVA: 0x7FFD54DE6BC0
        public void IsResponseCodeInRecoverableState(){} // RVA: 0x7FFD54DE6CD0
    }

    public class GooglePlayStorePurchaseService : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.rializeProductDescriptions m_GooglePlayStoreService; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void Purchase(){} // RVA: 0x7FFD54DE6DA0
    }

    public class GooglePlayStoreRetrieveProductsService : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.rializeProductDescriptions m_GooglePlayStoreService; // 0x10
        public ing.nityAudioSampleRate m_GoogleFetchPurchases; // 0x18
        public ra.__0 m_StoreCallback; // 0x20
        public ing.TotalEncodedSeconds m_GooglePlayConfigurationInternal; // 0x28
        public ing.dedSeconds m_GooglePlayStoreExtensions; // 0x30
        public bool m_HasInitiallyRetrievedProducts; // 0x38
        public bool m_RetrieveProductsFailed; // 0x39

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE6E00
        public void SetStoreCallback(){} // RVA: 0x7FFD4E36F0D0
        public void RetrieveProducts(){} // RVA: 0x7FFD54DE6F60
        public void OnProductsRetrievedWithPurchaseFetch(){} // RVA: 0x7FFD54DE7090
        public void OnProductsRetrieved(){} // RVA: 0x7FFD54DE73E0
        public void OnRetrieveProductsFailed(){} // RVA: 0x7FFD54DE74C0
        public void ResumeConnection(){} // RVA: 0x7FFD54DE75D0
        public void MakePurchasesIntoProducts(){} // RVA: 0x7FFD54DE7620
        public void IsPurchasedProductDeferred(){} // RVA: 0x7FFD54DE7AF0
        public void HasInitiallyRetrievedProducts(){} // RVA: 0x7FFD4E5F95D0
    }

    public class GooglePlayStoreService : Object
    {
        public int m_CurrentConnectionAttempts; // 0x10
        public int m_MaxConnectionAttempts; // 0x14
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.2B240EB m_BillingClient; // 0x18
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.CCE4 m_BillingClientStateListener; // 0x20
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.ucts m_QueryProductDetailsService; // 0x28
        public JapaneseLangName.me<oductDetails>b__5_0.?> m_ProductsToQuery; // 0x30
        public JapaneseLangName.me<ileFullDirectoryInformation<URA.woDigitYearMax<B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.sions>>> m_OnPurchaseSucceededQueue; // 0x38
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.avaArray m_GooglePurchaseService; // 0x40
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.Stores.dll m_GoogleFinishTransactionService; // 0x48
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.yProductDetailsService m_GoogleQueryPurchasesService; // 0x50
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.nsDeserializer m_GoogleLastKnownProductService; // 0x58
        public ÌÍÏÏÏ.ÌÎÍÍÏÍÏÎÏÎÏÌÍÏÏÏ m_TelemetryDiagnostics; // 0x60
        public Identifiers m_Logger; // 0x68
        public ampleFormat.0 m_RetryPolicy; // 0x70
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD7A10
        public void InitConnectionWithGooglePlay(){} // RVA: 0x7FFD54DD7F50
        public void StartConnection(){} // RVA: 0x7FFD54DD8110
        public void ResumeConnection(){} // RVA: 0x7FFD54DD8170
        public void AttemptReconnection(){} // RVA: 0x7FFD54DD81E0
        public void AreConnectionAttemptsExhausted(){} // RVA: 0x7FFD4FCDD170
        public void RetryConnection(){} // RVA: 0x7FFD54DD82A0
        public void RetryConnectionAttempt(){} // RVA: 0x7FFD54DD8430
        public void OnConnected(){} // RVA: 0x7FFD54DD84C0
        public void DequeueQueryProducts(){} // RVA: 0x7FFD54DD8510
        public void DequeueFetchPurchases(){} // RVA: 0x7FFD54DD8AA0
        public void OnDisconnected(){} // RVA: 0x7FFD54DD8C60
        public void RetrieveProducts(){} // RVA: 0x7FFD54DD8C90
        public void HandleRetrieveProductsNotConnected(){} // RVA: 0x7FFD54DD8D50
        public void Purchase(){} // RVA: 0x7FFD54DD8F80 | overloaded x2
        public void FinishTransaction(){} // RVA: 0x7FFD54DD9170
        public void FetchPurchases(){} // RVA: 0x7FFD54DD91F0
        public void TryFetchPurchases(){} // RVA: 0x7FFD54DD9410
        public void GetPurchase(){} // RVA: 0x7FFD54DD9610
        public void <AttemptReconnection>b__19_0(){} // RVA: 0x7FFD54DD9690
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
        public void get_originalJson(){} // RVA: 0x7FFD4E3BE740
        public void set_originalJson(){} // RVA: 0x7FFD4E369200
        public void set_subscriptionPeriod(){} // RVA: 0x7FFD4E3BC740
        public void set_freeTrialPeriod(){} // RVA: 0x7FFD4E4994D0
        public void set_introductoryPrice(){} // RVA: 0x7FFD4E409510
        public void set_introductoryPricePeriod(){} // RVA: 0x7FFD4E3DF380
        public void set_introductoryPriceCycles(){} // RVA: 0x7FFD4FBDAB60
        public void .ctor(){} // RVA: 0x7FFD54DE4C30
    }

    public class GooglePurchaseService : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.2B240EB m_BillingClient; // 0x10
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.eloperPayload m_GooglePurchaseCallback; // 0x18
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.ucts m_QueryProductDetailsService; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E420E00
        public void Purchase(){} // RVA: 0x7FFD54DD9FC0
        public void OnQueryProductDetailsResponse(){} // RVA: 0x7FFD54DDA220
        public void ValidateQueryProductDetailsResponseParams(){} // RVA: 0x7FFD54DDA2E0
        public void ValidateSkus(){} // RVA: 0x7FFD54DDA680
        public void VerifyAndWarnIfMoreThanOneSku(){} // RVA: 0x7FFD54DDA830
        public void PurchaseFailedSkuNotFound(){} // RVA: 0x7FFD54DDA9B0
        public void ValidateOldProduct(){} // RVA: 0x7FFD54DDAA80
        public void PurchaseFailedInvalidOldProduct(){} // RVA: 0x7FFD54DDAB10
        public void LaunchGoogleBillingFlow(){} // RVA: 0x7FFD54DDAC10
        public void HandleBillingFlowResult(){} // RVA: 0x7FFD54DDAE80
    }

    public class GooglePurchaseUpdatedListener : AndroidJavaProxy
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.nsDeserializer m_LastKnownProductService; // 0x20
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.eloperPayload m_GooglePurchaseCallback; // 0x28
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.vaStore m_PurchaseBuilder; // 0x30
        public ing.set_MouseCursor m_GoogleCachedQueryProductDetailsService; // 0x38
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.GetUnityPlayerClass m_GooglePurchaseStateEnumProvider; // 0x40
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.yProductDetailsService m_GoogleQueryPurchasesService; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDCB00
        public void SetGoogleQueryPurchaseService(){} // RVA: 0x7FFD4E3BC740
        public void onPurchasesUpdated(){} // RVA: 0x7FFD54DDCD90
        public void OnPurchasesUpdated(){} // RVA: 0x7FFD54DDD190
        public void HandleResultOkCases(){} // RVA: 0x7FFD54DDD380
        public void HandleErrorCases(){} // RVA: 0x7FFD54DDD460
        public void HandleErrorGoogleBillingResult(){} // RVA: 0x7FFD54DDD550
        public void HandleUserCancelledPurchaseFailure(){} // RVA: 0x7FFD54DDDAA0 | overloaded x2
        public void ApplyOnPurchases(){} // RVA: 0x7FFD54DDDDE0 | overloaded x2
        public void OnPurchaseOk(){} // RVA: 0x7FFD54DDE060
        public void HandlePurchasedProduct(){} // RVA: 0x7FFD54DDE320
        public void IsDeferredSubscriptionChange(){} // RVA: 0x7FFD54DDE450
        public void IsLastProrationModeDeferred(){} // RVA: 0x7FFD54DDE610
        public void OnPurchaseCancelled(){} // RVA: 0x7FFD54DDE820 | overloaded x2
        public void OnPurchaseAlreadyOwned(){} // RVA: 0x7FFD54DDE910
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DDEA00
        public void <HandleUserCancelledPurchaseFailure>b__15_0(){} // RVA: 0x7FFD54DDEB10
    }

    public class GooglePurchasesResponseListener : AndroidJavaProxy
    {
        public rectoryInformation<oductDetails>b__5_0.nt,URA.bbrevEraNames<?>> m_OnQueryPurchasesResponse; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDC6F0
        public void onQueryPurchasesResponse(){} // RVA: 0x7FFD54DDC7B0
    }

    public class GoogleQueryPurchasesService : Object
    {
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.2B240EB m_BillingClient; // 0x10
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.vaStore m_PurchaseBuilder; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void QueryPurchases(){} // RVA: 0x7FFD54DDB0D0
        public void QueryPurchasesWithSkuType(){} // RVA: 0x7FFD54DDB250
        public void GetPurchaseByToken(){} // RVA: 0x7FFD54DDB430
        public void IsResultOk(){} // RVA: 0x7FFD54DDB6B0
    }

}