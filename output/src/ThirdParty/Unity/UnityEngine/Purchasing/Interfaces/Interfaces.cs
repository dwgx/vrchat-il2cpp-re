// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
// Classes: 16
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
{
    public class IBillingClientStateListener
    {
        // ── Methods ──
        public void RegisterOnConnected(){} // RVA: 0x7A7E18800
        public void RegisterOnDisconnected(){} // RVA: 0x7A7E18800
    }

    public class IGoogleBillingClient
    {
        // ── Methods ──
        public void StartConnection(){} // RVA: 0x7A7E18800
        public void GetConnectionState(){} // RVA: 0x7A7E00710
        public void QueryPurchasesAsync(){} // RVA: 0x7A7E18890
        public void QueryProductDetailsAsync(){} // RVA: 0x7A7E1DDC0
        public void LaunchBillingFlow(){} // RVA: 0x7A7E12430
        public void ConsumeAsync(){} // RVA: 0x7A7E18890
        public void AcknowledgePurchase(){} // RVA: 0x7A7E18890
    }

    public class IGoogleFinishTransactionService
    {
        // ── Methods ──
        public void FinishTransaction(){} // RVA: 0x7A7E1DDC0
    }

    public class IGoogleLastKnownProductService
    {
        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7A7E00680
        public void set_LastKnownOldProductId(){} // RVA: 0x7A7E18800
        public void get_LastKnownProductId(){} // RVA: 0x7A7E00680
        public void set_LastKnownProductId(){} // RVA: 0x7A7E18800
        public void get_LastKnownProrationMode(){} // RVA: 0x7A7E00680
        public void set_LastKnownProrationMode(){} // RVA: 0x7A7E188D0
    }

    public class IGooglePlayStoreService
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7A7E1DDC0
        public void Purchase(){} // RVA: 0x7A7E18800
        public void FinishTransaction(){} // RVA: 0x7A7E1DDC0
        public void FetchPurchases(){} // RVA: 0x7A7E18800
        public void GetPurchase(){} // RVA: 0x7A7E00BD0
        public void ResumeConnection(){} // RVA: 0x7A7E18770
    }

    public class IGoogleProductCallback
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7A7E18800
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7A7E189D0
    }

    public class IGooglePurchase
    {
        // ── Methods ──
        public void get_purchaseState(){} // RVA: 0x7A7E00710
        public void get_skus(){} // RVA: 0x7A7E00680
        public void get_receipt(){} // RVA: 0x7A7E00680
        public void get_purchaseToken(){} // RVA: 0x7A7E00680
        public void get_sku(){} // RVA: 0x7A7E00680
        public void IsAcknowledged(){} // RVA: 0x7A7E01900
        public void IsPurchased(){} // RVA: 0x7A7E01900
        public void IsPending(){} // RVA: 0x7A7E01900
    }

    public class IGooglePurchaseBuilder
    {
        // ── Methods ──
        public void BuildPurchases(){} // RVA: 0x7A7E00B20
        public void BuildPurchase(){} // RVA: 0x7A7E00B20
    }

    public class IGooglePurchaseCallback
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7A7E18800
        public void SetStoreConfiguration(){} // RVA: 0x7A7E18800
        public void OnPurchaseSuccessful(){} // RVA: 0x7A7E1DDC0
        public void OnPurchaseFailed(){} // RVA: 0x7A7E18800
        public void NotifyDeferredPurchase(){} // RVA: 0x7A7E1DDC0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7A7E18800
    }

    public class IGooglePurchaseService
    {
        // ── Methods ──
        public void Purchase(){} // RVA: 0x7A7E1A0E0
    }

    public class IGooglePurchaseStateEnumProvider
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7A7E00710
        public void Pending(){} // RVA: 0x7A7E00710
    }

    public class IGoogleQueryPurchasesService
    {
        // ── Methods ──
        public void QueryPurchases(){} // RVA: 0x7A7E00680
        public void GetPurchaseByToken(){} // RVA: 0x7A7E00BD0
    }

    public class IProductDetailsConverter
    {
        // ── Methods ──
        public void ConvertOnQueryProductDetailsResponse(){} // RVA: 0x7A7E00B20
    }

    public class IProductDetailsQueryResponse
    {
        // ── Methods ──
        public void AddResponse(){} // RVA: 0x7A7E18890
        public void ProductDetails(){} // RVA: 0x7A7E00680
        public void IsRecoverable(){} // RVA: 0x7A7E01900
        public void GetGoogleBillingResult(){} // RVA: 0x7A7E00680
    }

    public class IProductDetailsResponseConsolidator
    {
        // ── Methods ──
        public void Consolidate(){} // RVA: 0x7A7E18890
    }

    public class IQueryProductDetailsService
    {
        // ── Methods ──
        public void QueryAsyncProduct(){} // RVA: 0x7A7E18890
    }

}