// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class AnalyticsClient : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void OnPurchaseSucceeded(){} // RVA: 0x7D65730
        public void OnPurchaseFailed(){} // RVA: 0x7D657C0
    }

    public class AndroidJavaStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void RetrieveProducts(){} // RVA: 0x7D70C20
        public void Purchase(){} // RVA: 0x7D70CF0
        public void FinishTransaction(){} // RVA: 0x7D70E00
    }

    public class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
    {
        // ── Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7D8B000
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AppleProductMetadata : ProductMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D8B0A0
    }

    public class AppleStoreImpl : JSONStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D8B2B0
        public void SetNativeStore(){} // RVA: 0x7D8B4B0
        public void get_appReceipt(){} // RVA: 0x7D8B720
        public void get_appReceiptModificationDate(){} // RVA: 0x7D8B930
        public void OnProductsRetrieved(){} // RVA: 0x7D8B9D0
        public void HasInAppPurchaseReceipts(){} // RVA: 0x7D8BB40
        public void EnrichProductDescriptions(){} // RVA: 0x7D8BB60
        public void FindMostRecentReceipt(){} // RVA: 0x7D8C030
        public void FirstNonCancelledReceipt(){} // RVA: 0x7D8C490
        public void OnPurchaseDeferred(){} // RVA: 0x7D8C5C0
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7D8C6B0
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7D8C7A0
        public void OnTransactionsRestoredFail(){} // RVA: 0x7D8C7F0
        public void OnAppReceiptRetrieved(){} // RVA: 0x1BF51E0
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x5951B20
        public void OnEntitlementsRevoked(){} // RVA: 0x7D8C840
        public void RevokeEntitlement(){} // RVA: 0x7D8CC10
        public void RestoreActiveEntitlement(){} // RVA: 0x7D8CD40
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x7D8CE20
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x7D8D240
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x7D8D260
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x20A5460
        public void MessageCallback(){} // RVA: 0x7D8D5F0
        public void ProcessMessage(){} // RVA: 0x7D8D8B0
        public void OnPurchaseSucceeded(){} // RVA: 0x7D8E410
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x7D8E530
        public void IsValidPurchaseState(){} // RVA: 0x7D8E620
        public void IsRestored(){} // RVA: 0x7D8E830
        public void IsSubscriptionRestored(){} // RVA: 0x7D8EBF0
        public void IsNonSubscriptionRestored(){} // RVA: 0x7D8EE80
        public void UpdateAppleProductFields(){} // RVA: 0x7D8EEE0
    }

}