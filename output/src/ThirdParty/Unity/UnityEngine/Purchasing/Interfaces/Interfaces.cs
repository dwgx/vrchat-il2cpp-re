// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
// Classes: 17
// Methods: 53

namespace ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
{
    public class IBillingClientStateListener
    {
        // ── Methods ──
        public void RegisterOnConnected(){} // RVA: 0x7FFE80E460A0
        public void RegisterOnDisconnected(){} // RVA: 0x7FFE80E460A0
    }

    public class IGoogleBillingClient
    {
        // ── Methods ──
        public void StartConnection(){} // RVA: 0x7FFE80E460A0
        public void GetConnectionState(){} // RVA: 0x7FFE80E2EDB0
        public void QueryPurchasesAsync(){} // RVA: 0x7FFE80E4F230
        public void QueryProductDetailsAsync(){} // RVA: 0x7FFE80E50660
        public void LaunchBillingFlow(){}
        public void ConsumeAsync(){} // RVA: 0x7FFE80E4F230
        public void AcknowledgePurchase(){} // RVA: 0x7FFE80E4F230
    }

    public class IGoogleFinishTransactionService
    {
        // ── Methods ──
        public void FinishTransaction(){} // RVA: 0x7FFE80E50660
    }

    public class IGoogleLastKnownProductService
    {
        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7FFE80E2E2E0
        public void set_LastKnownOldProductId(){} // RVA: 0x7FFE80E460A0
        public void get_LastKnownProductId(){} // RVA: 0x7FFE80E2E2E0
        public void set_LastKnownProductId(){} // RVA: 0x7FFE80E460A0
        public void get_LastKnownProrationMode(){} // RVA: 0x7FFE80E2E2E0
        public void set_LastKnownProrationMode(){}
    }

    public class IGooglePlayStoreService
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7FFE80E50660
        public void Purchase(){} // RVA: 0x7FFE80E460A0
        public void FinishTransaction(){} // RVA: 0x7FFE80E50660
        public void FetchPurchases(){} // RVA: 0x7FFE80E460A0
        public void GetPurchase(){} // RVA: 0x7FFE80E3FC10
        public void ResumeConnection(){} // RVA: 0x7FFE80E45FE0
    }

    public class IGoogleProductCallback
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7FFE80E460A0
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFE80E46530
    }

    public class IGooglePurchase
    {
        // ── Methods ──
        public void get_purchaseState(){} // RVA: 0x7FFE80E2EDB0
        public void get_skus(){} // RVA: 0x7FFE80E2E2E0
        public void get_receipt(){} // RVA: 0x7FFE80E2E2E0
        public void get_purchaseToken(){} // RVA: 0x7FFE80E2E2E0
        public void get_sku(){} // RVA: 0x7FFE80E2E2E0
        public void IsAcknowledged(){} // RVA: 0x7FFE80E2F150
        public void IsPurchased(){} // RVA: 0x7FFE80E2F150
        public void IsPending(){} // RVA: 0x7FFE80E2F150
    }

    public class IGooglePurchaseBuilder
    {
        // ── Methods ──
        public void BuildPurchases(){} // RVA: 0x7FFE80E2E390
        public void BuildPurchase(){} // RVA: 0x7FFE80E2E390
    }

    public class IGooglePurchaseCallback
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFE80E460A0
        public void SetStoreConfiguration(){} // RVA: 0x7FFE80E460A0
        public void OnPurchaseSuccessful(){} // RVA: 0x7FFE80E50660
        public void OnPurchaseFailed(){} // RVA: 0x7FFE80E460A0
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFE80E50660
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFE80E460A0
    }

    public class IGooglePurchaseService
    {
        // ── Methods ──
        public void Purchase(){}
    }

    public class IGooglePurchaseStateEnumProvider
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7FFE80E2EDB0
        public void Pending(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IGooglePurchaseUpdatedListener
    {
    }

    public class IGoogleQueryPurchasesService
    {
        // ── Methods ──
        public void QueryPurchases(){} // RVA: 0x7FFE80E2E2E0
        public void GetPurchaseByToken(){} // RVA: 0x7FFE80E3FC10
    }

    public class IProductDetailsConverter
    {
        // ── Methods ──
        public void ConvertOnQueryProductDetailsResponse(){} // RVA: 0x7FFE80E2E390
    }

    public class IProductDetailsQueryResponse
    {
        // ── Methods ──
        public void AddResponse(){} // RVA: 0x7FFE80E4F230
        public void ProductDetails(){} // RVA: 0x7FFE80E2E2E0
        public void IsRecoverable(){} // RVA: 0x7FFE80E2F150
        public void GetGoogleBillingResult(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IProductDetailsResponseConsolidator
    {
        // ── Methods ──
        public void Consolidate(){} // RVA: 0x7FFE80E4F230
    }

    public class IQueryProductDetailsService
    {
        // ── Methods ──
        public void QueryAsyncProduct(){} // RVA: 0x7FFE80E4F230 | overloaded x2
    }

}