// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 43

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
    }

    public class AnalyticsClient : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void OnPurchaseSucceeded(){} // RVA: 0x7AEFF2120
        public void OnPurchaseFailed(){} // RVA: 0x7AEFF21B0
    }

    public class AndroidJavaStore : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void RetrieveProducts(){} // RVA: 0x7AEFFD540
        public void Purchase(){} // RVA: 0x7AEFFD610
        public void FinishTransaction(){} // RVA: 0x7AEFFD720
    }

    public class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
    {
        // ── Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7AF017A80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AppleProductMetadata : ProductMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF017B20
        public void <isFamilyShareable>k__BackingField(){} // RVA: 0x7B41917E8
    }

    public class AppleStoreImpl : JSONStore
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF017D30
        public void SetNativeStore(){} // RVA: 0x7AF017F30
        public void get_appReceipt(){} // RVA: 0x7AF0181A0
        public void get_appReceiptModificationDate(){} // RVA: 0x7AF0183B0
        public void OnProductsRetrieved(){} // RVA: 0x7AF018450
        public void HasInAppPurchaseReceipts(){} // RVA: 0x7AF0185C0
        public void EnrichProductDescriptions(){} // RVA: 0x7AF0185E0
        public void FindMostRecentReceipt(){} // RVA: 0x7AF018AD0
        public void FirstNonCancelledReceipt(){} // RVA: 0x7AF018F30
        public void OnPurchaseDeferred(){} // RVA: 0x7AF019060
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7AF019150
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7AF019240
        public void OnTransactionsRestoredFail(){} // RVA: 0x7AF019290
        public void OnAppReceiptRetrieved(){} // RVA: 0x7A9140F40
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x7ACF03F90
        public void OnEntitlementsRevoked(){} // RVA: 0x7AF0192E0
        public void RevokeEntitlement(){} // RVA: 0x7AF0196C0
        public void RestoreActiveEntitlement(){} // RVA: 0x7AF0197F0
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x7AF0198D0
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x7AF019D10
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x7AF019D30
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x7A9593870
        public void MessageCallback(){} // RVA: 0x7AF01A0E0
        public void ProcessMessage(){} // RVA: 0x7AF01A3A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7AF01AF40
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x7AF01B060
        public void IsValidPurchaseState(){} // RVA: 0x7AF01B150
        public void IsRestored(){} // RVA: 0x7AF01B330
        public void IsSubscriptionRestored(){} // RVA: 0x7AF01B6F0
        public void IsNonSubscriptionRestored(){} // RVA: 0x7AF01B980
        public void UpdateAppleProductFields(){} // RVA: 0x7AF01B9E0
    }

}