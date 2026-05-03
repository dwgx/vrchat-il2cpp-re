// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
    }

    public class AnalyticsClient : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE87D52E90
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D52F20
    }

    public class AndroidJavaStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void RetrieveProducts(){} // RVA: 0x7FFE87D5E250
        public void Purchase(){} // RVA: 0x7FFE87D5E320
        public void FinishTransaction(){} // RVA: 0x7FFE87D5E430
    }

    public class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
    {
        // ── Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7FFE87D787F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AppleProductMetadata : ProductMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D78890
    }

    public class AppleStoreImpl : JSONStore
    {
        public System.Action`1<UnityEngine.Purchasing.Product> m_DeferredCallback; // 0x48
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>> m_RevokedCallback; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D78AA0
        public void SetNativeStore(){} // RVA: 0x7FFE87D78CA0
        public void get_appReceipt(){} // RVA: 0x7FFE87D78F20
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFE87D79130
        public void OnProductsRetrieved(){} // RVA: 0x7FFE87D791D0
        public void HasInAppPurchaseReceipts(){} // RVA: 0x7FFE87D79350
        public void EnrichProductDescriptions(){} // RVA: 0x7FFE87D79370
        public void FindMostRecentReceipt(){} // RVA: 0x7FFE87D79870
        public void FirstNonCancelledReceipt(){} // RVA: 0x7FFE87D79CB0
        public void OnPurchaseDeferred(){} // RVA: 0x7FFE87D79DD0
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7FFE87D79EC0
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7FFE87D79FB0
        public void OnTransactionsRestoredFail(){} // RVA: 0x7FFE87D7A000
        public void OnAppReceiptRetrieved(){} // RVA: 0x7FFE820D3100
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x7FFE85B63B40
        public void OnEntitlementsRevoked(){} // RVA: 0x7FFE87D7A050
        public void RevokeEntitlement(){} // RVA: 0x7FFE87D7A430
        public void RestoreActiveEntitlement(){} // RVA: 0x7FFE87D7A560
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x7FFE87D7A640
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x7FFE87D7A9E0
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x7FFE87D7AA00
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x7FFE82549330
        public void MessageCallback(){} // RVA: 0x7FFE87D7ADC0
        public void ProcessMessage(){} // RVA: 0x7FFE87D7B070
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE87D7BC10
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x7FFE87D7BD30
        public void IsValidPurchaseState(){} // RVA: 0x7FFE87D7BE20
        public void IsRestored(){} // RVA: 0x7FFE87D7C000
        public void IsSubscriptionRestored(){} // RVA: 0x7FFE87D7C3C0
        public void IsNonSubscriptionRestored(){} // RVA: 0x7FFE87D7C650
        public void UpdateAppleProductFields(){} // RVA: 0x7FFE87D7C6B0
    }

}