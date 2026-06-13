// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
    }

    public class AnalyticsClient
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void OnPurchaseSucceeded(){} // RVA: 0x7212CF0
        public void OnPurchaseFailed(){} // RVA: 0x7212D80
    }

    public class AndroidJavaStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void RetrieveProducts(){} // RVA: 0x721E0B0
        public void Purchase(){} // RVA: 0x721E180
        public void FinishTransaction(){} // RVA: 0x721E290
    }

    public class AppleJsonProductDescriptionsDeserializer
    {
        // ── Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7238650
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AppleProductMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x72386F0
    }

    public class AppleStoreImpl
    {
        public System.Action`1<UnityEngine.Purchasing.Product> m_DeferredCallback; // 0x48
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>> m_RevokedCallback; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7238900
        public void SetNativeStore(){} // RVA: 0x7238B00
        public void get_appReceipt(){} // RVA: 0x7238D80
        public void get_appReceiptModificationDate(){} // RVA: 0x7238F90
        public void OnProductsRetrieved(){} // RVA: 0x7239030
        public void HasInAppPurchaseReceipts(){} // RVA: 0x72391B0
        public void EnrichProductDescriptions(){} // RVA: 0x72391D0
        public void FindMostRecentReceipt(){} // RVA: 0x72396D0
        public void FirstNonCancelledReceipt(){} // RVA: 0x7239B10
        public void OnPurchaseDeferred(){} // RVA: 0x7239C30
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7239D20
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7239E10
        public void OnTransactionsRestoredFail(){} // RVA: 0x7239E60
        public void OnAppReceiptRetrieved(){} // RVA: 0x1351CE0
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x4EC5060
        public void OnEntitlementsRevoked(){} // RVA: 0x7239EB0
        public void RevokeEntitlement(){} // RVA: 0x723A290
        public void RestoreActiveEntitlement(){} // RVA: 0x723A3C0
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x723A4A0
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x723A840
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x723A860
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x17D8B50
        public void MessageCallback(){} // RVA: 0x723AC20
        public void ProcessMessage(){} // RVA: 0x723AED0
        public void OnPurchaseSucceeded(){} // RVA: 0x723BA70
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x723BB90
        public void IsValidPurchaseState(){} // RVA: 0x723BC80
        public void IsRestored(){} // RVA: 0x723BE60
        public void IsSubscriptionRestored(){} // RVA: 0x723C220
        public void IsNonSubscriptionRestored(){} // RVA: 0x723C4B0
        public void UpdateAppleProductFields(){} // RVA: 0x723C510
    }

}