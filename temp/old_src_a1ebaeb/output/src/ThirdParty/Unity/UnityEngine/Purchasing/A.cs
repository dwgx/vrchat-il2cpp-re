// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
    }

    public class AnalyticsClient : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8f15e70
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaaf3cc550
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3cc5e0
    }

    public class AndroidJavaStore : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void RetrieveProducts(){} // RVA: 0x7ffaaf3d7910
        public void Purchase(){} // RVA: 0x7ffaaf3d79e0
        public void FinishTransaction(){} // RVA: 0x7ffaaf3d7af0
    }

    public class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
    {
        // ── Original Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7ffaaf3f1eb0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class AppleProductMetadata : ProductMetadata
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3f1f50
    }

    public class AppleStoreImpl : JSONStore
    {
        public object m_RefreshReceiptError; // 0x33875D00
        public object m_RestoreCallback; // 0x33875D00
        public object m_PromotionalPurchaseCallback; // 0x33875D00
        public object m_Native; // 0x33875D00
        public object s_Instance; // 0x33875D00
        public object m_ProductsJson; // 0x33875D00
        public object appReceipt; // 0x1700000C
        public object appReceiptModificationDate; // 0x1700000D
        public object ޗ3; // 0x685B6120

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3f2160
        public void get_appReceipt(){} // RVA: 0x7ffaaf3f25e0
        public void get_appReceiptModificationDate(){} // RVA: 0x7ffaaf3f27f0
        public void OnProductsRetrieved(){} // RVA: 0x7ffaaf3f2890
        public void HasInAppPurchaseReceipts(){} // RVA: 0x7ffaaf3f2a10
        public void EnrichProductDescriptions(){} // RVA: 0x7ffaaf3f2a30
        public void FindMostRecentReceipt(){} // RVA: 0x7ffaaf3f2f30
        public void FirstNonCancelledReceipt(){} // RVA: 0x7ffaaf3f3370
        public void OnPurchaseDeferred(){} // RVA: 0x7ffaaf3f3490
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7ffaaf3f3580
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7ffaaf3f3670
        public void OnTransactionsRestoredFail(){} // RVA: 0x7ffaaf3f36c0
        public void OnAppReceiptRetrieved(){} // RVA: 0x7ffaa9886000
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x7ffaad0aec90
        public void OnEntitlementsRevoked(){} // RVA: 0x7ffaaf3f3710
        public void RevokeEntitlement(){} // RVA: 0x7ffaaf3f3af0
        public void RestoreActiveEntitlement(){} // RVA: 0x7ffaaf3f3c20
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x7ffaaf3f3d00
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x7ffaaf3f40a0
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x7ffaaf3f40c0
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x7ffaa9d5ca80
        public void MessageCallback(){} // RVA: 0x7ffaaf3f4480
        public void ProcessMessage(){} // RVA: 0x7ffaaf3f4730
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaaf3f52d0
        public void IsValidPurchaseState(){} // RVA: 0x7ffaaf3f54e0
        public void IsRestored(){} // RVA: 0x7ffaaf3f56c0
        public void IsSubscriptionRestored(){} // RVA: 0x7ffaaf3f5a80
        public void IsNonSubscriptionRestored(){} // RVA: 0x7ffaaf3f5d10
        public void UpdateAppleProductFields(){} // RVA: 0x7ffaaf3f5d70
        // ── Binary Analysis Named ──
        public void SetNativeStore(){} // RVA: 0x7ffaaf3f2360
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x7ffaaf3f53f0
    }

}