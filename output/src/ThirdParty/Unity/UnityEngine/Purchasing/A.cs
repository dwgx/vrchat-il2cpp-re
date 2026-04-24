// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
    }

    public class AnalyticsClient : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E90C240
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD54DCA5F0
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DCA680
    }

    public class AndroidJavaStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void RetrieveProducts(){} // RVA: 0x7FFD54DD59B0
        public void Purchase(){} // RVA: 0x7FFD54DD5A80
        public void FinishTransaction(){} // RVA: 0x7FFD54DD5B90
    }

    public class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
    {
        // ── Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7FFD54DEFF50
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AppleProductMetadata : ProductMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DEFFF0
    }

    public class AppleStoreImpl : JSONStore
    {
        public object appReceipt;
        public object appReceiptModificationDate;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DF0200
        public void SetNativeStore(){} // RVA: 0x7FFD54DF0400
        public void get_appReceipt(){} // RVA: 0x7FFD54DF0680
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFD54DF0890
        public void OnProductsRetrieved(){} // RVA: 0x7FFD54DF0930
        public void HasInAppPurchaseReceipts(){} // RVA: 0x7FFD54DF0AB0
        public void EnrichProductDescriptions(){} // RVA: 0x7FFD54DF0AD0
        public void FindMostRecentReceipt(){} // RVA: 0x7FFD54DF0FD0
        public void FirstNonCancelledReceipt(){} // RVA: 0x7FFD54DF1410
        public void OnPurchaseDeferred(){} // RVA: 0x7FFD54DF1530
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7FFD54DF1620
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7FFD54DF1710
        public void OnTransactionsRestoredFail(){} // RVA: 0x7FFD54DF1760
        public void OnAppReceiptRetrieved(){} // RVA: 0x7FFD4F295B70
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x7FFD52BB7880
        public void OnEntitlementsRevoked(){} // RVA: 0x7FFD54DF17B0
        public void RevokeEntitlement(){} // RVA: 0x7FFD54DF1B90
        public void RestoreActiveEntitlement(){} // RVA: 0x7FFD54DF1CC0
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x7FFD54DF1DA0
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x7FFD54DF2140
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x7FFD54DF2160
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x7FFD4F730410
        public void MessageCallback(){} // RVA: 0x7FFD54DF2520
        public void ProcessMessage(){} // RVA: 0x7FFD54DF27D0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD54DF3370
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x7FFD54DF3490
        public void IsValidPurchaseState(){} // RVA: 0x7FFD54DF3580
        public void IsRestored(){} // RVA: 0x7FFD54DF3760
        public void IsSubscriptionRestored(){} // RVA: 0x7FFD54DF3B20
        public void IsNonSubscriptionRestored(){} // RVA: 0x7FFD54DF3DB0
        public void UpdateAppleProductFields(){} // RVA: 0x7FFD54DF3E10
    }

}