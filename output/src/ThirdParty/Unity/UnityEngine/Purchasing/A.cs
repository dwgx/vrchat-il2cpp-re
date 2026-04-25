// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 6
// Methods: 42

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class AmazonAppStoreStoreExtensions : Object
    {
        public UnityEngine.AndroidJavaObject android; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class AnalyticsClient : Object
    {
        public UnityEngine.Purchasing.IAnalyticsAdapter m_Analytics; // 0x10
        public UnityEngine.Purchasing.IAnalyticsAdapter m_LegacyAnalytics; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAC99AA5F0
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC99AA680
    }

    public class AndroidJavaStore : Object
    {
        public UnityEngine.AndroidJavaObject m_Store; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void RetrieveProducts(){} // RVA: 0x7FFAC99B59B0
        public void Purchase(){} // RVA: 0x7FFAC99B5A80
        public void FinishTransaction(){} // RVA: 0x7FFAC99B5B90
    }

    public class AppleJsonProductDescriptionsDeserializer : JsonProductDescriptionsDeserializer
    {
        // ── Methods ──
        public void DeserializeMetadata(){} // RVA: 0x7FFAC99CFF50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AppleProductMetadata : ProductMetadata
    {
        public bool <isFamilyShareable>k__BackingField; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99CFFF0
    }

    public class AppleStoreImpl : JSONStore
    {
        public System.Action`1<UnityEngine.Purchasing.Product> appReceipt; // 0x48
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>> appReceiptModificationDate; // 0x50
        public System.Action`1<string> m_RefreshReceiptError; // 0x58
        public System.Action`1<string> m_RefreshReceiptSuccess; // 0x60
        public System.Action`1<bool> m_ObsoleteRestoreCallback; // 0x68
        public System.Action`2<bool,string> m_RestoreCallback; // 0x70
        public System.Action m_FetchStorePromotionOrderError; // 0x78
        public System.Action`1<System.Collections.Generic.List`1<UnityEngine.Purchasing.Product>> m_FetchStorePromotionOrderSuccess; // 0x80
        public System.Action`1<UnityEngine.Purchasing.Product> m_PromotionalPurchaseCallback; // 0x88
        public System.Action m_FetchStorePromotionVisibilityError; // 0x90
        public System.Action`2<string,0x6B27CDA8> m_FetchStorePromotionVisibilitySuccess; // 0x98
        public UnityEngine.Purchasing.INativeAppleStore m_Native; // 0xA0
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0xA8
        public Uniject.IUtil s_Util;
        public UnityEngine.Purchasing.AppleStoreImpl s_Instance; // 0x8
        public string m_CachedAppReceipt; // 0xB0
        public System.Nullable`1<double> m_CachedAppReceiptModificationDate; // 0xB8
        public string m_ProductsJson; // 0xC8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99D0200
        public void SetNativeStore(){} // RVA: 0x7FFAC99D0400
        public void get_appReceipt(){} // RVA: 0x7FFAC99D0680
        public void get_appReceiptModificationDate(){} // RVA: 0x7FFAC99D0890
        public void OnProductsRetrieved(){} // RVA: 0x7FFAC99D0930
        public void HasInAppPurchaseReceipts(){} // RVA: 0x7FFAC99D0AB0
        public void EnrichProductDescriptions(){} // RVA: 0x7FFAC99D0AD0
        public void FindMostRecentReceipt(){} // RVA: 0x7FFAC99D0FD0
        public void FirstNonCancelledReceipt(){} // RVA: 0x7FFAC99D1410
        public void OnPurchaseDeferred(){} // RVA: 0x7FFAC99D1530
        public void OnPromotionalPurchaseAttempted(){} // RVA: 0x7FFAC99D1620
        public void OnTransactionsRestoredSuccess(){} // RVA: 0x7FFAC99D1710
        public void OnTransactionsRestoredFail(){} // RVA: 0x7FFAC99D1760
        public void OnAppReceiptRetrieved(){} // RVA: 0x7FFAC3E75B70
        public void OnAppReceiptRefreshedFailed(){} // RVA: 0x7FFAC7797880
        public void OnEntitlementsRevoked(){} // RVA: 0x7FFAC99D17B0
        public void RevokeEntitlement(){} // RVA: 0x7FFAC99D1B90
        public void RestoreActiveEntitlement(){} // RVA: 0x7FFAC99D1CC0
        public void OnFetchStorePromotionOrderSucceeded(){} // RVA: 0x7FFAC99D1DA0
        public void OnFetchStorePromotionOrderFailed(){} // RVA: 0x7FFAC99D2140
        public void OnFetchStorePromotionVisibilitySucceeded(){} // RVA: 0x7FFAC99D2160
        public void OnFetchStorePromotionVisibilityFailed(){} // RVA: 0x7FFAC4310410
        public void MessageCallback(){} // RVA: 0x7FFAC99D2520
        public void ProcessMessage(){} // RVA: 0x7FFAC99D27D0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAC99D3370
        public void GetAppleReceiptFromBase64String(){} // RVA: 0x7FFAC99D3490
        public void IsValidPurchaseState(){} // RVA: 0x7FFAC99D3580
        public void IsRestored(){} // RVA: 0x7FFAC99D3760
        public void IsSubscriptionRestored(){} // RVA: 0x7FFAC99D3B20
        public void IsNonSubscriptionRestored(){} // RVA: 0x7FFAC99D3DB0
        public void UpdateAppleProductFields(){} // RVA: 0x7FFAC99D3E10
    }

}