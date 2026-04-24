// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
// Classes: 17
// Methods: 53

namespace ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
{
    public class IBillingClientStateListener
    {
        // ── Methods ──
        public void RegisterOnConnected(){} // RVA: 0x7FFD4E090A40
        public void RegisterOnDisconnected(){} // RVA: 0x7FFD4E090A40
    }

    public class IGoogleBillingClient
    {
        // ── Methods ──
        public void StartConnection(){} // RVA: 0x7FFD4E090A40
        public void GetConnectionState(){} // RVA: 0x7FFD4E079960
        public void QueryPurchasesAsync(){} // RVA: 0x7FFD4E099B30
        public void QueryProductDetailsAsync(){} // RVA: 0x7FFD4E09AF60
        public void LaunchBillingFlow(){}
        public void ConsumeAsync(){} // RVA: 0x7FFD4E099B30
        public void AcknowledgePurchase(){} // RVA: 0x7FFD4E099B30
    }

    public class IGoogleFinishTransactionService
    {
        // ── Methods ──
        public void FinishTransaction(){} // RVA: 0x7FFD4E09AF60
    }

    public class IGoogleLastKnownProductService
    {
        public object LastKnownOldProductId;
        public object LastKnownProductId;
        public object LastKnownProrationMode;

        // ── Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7FFD4E078E90
        public void set_LastKnownOldProductId(){} // RVA: 0x7FFD4E090A40
        public void get_LastKnownProductId(){} // RVA: 0x7FFD4E078E90
        public void set_LastKnownProductId(){} // RVA: 0x7FFD4E090A40
        public void get_LastKnownProrationMode(){} // RVA: 0x7FFD4E078E90
        public void set_LastKnownProrationMode(){}
    }

    public class IGooglePlayStoreService
    {
        // ── Methods ──
        public void RetrieveProducts(){} // RVA: 0x7FFD4E09AF60
        public void Purchase(){} // RVA: 0x7FFD4E090A40
        public void FinishTransaction(){} // RVA: 0x7FFD4E09AF60
        public void FetchPurchases(){} // RVA: 0x7FFD4E090A40
        public void GetPurchase(){} // RVA: 0x7FFD4E08A6F0
        public void ResumeConnection(){} // RVA: 0x7FFD4E090980
    }

    public class IGoogleProductCallback
    {
        // ── Methods ──
        public void SetStoreConfiguration(){} // RVA: 0x7FFD4E090A40
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7FFD4E090ED0
    }

    public class IGooglePurchase
    {
        public object purchaseState;
        public object skus;
        public object receipt;
        public object purchaseToken;
        public object sku;

        // ── Methods ──
        public void get_purchaseState(){} // RVA: 0x7FFD4E079960
        public void get_skus(){} // RVA: 0x7FFD4E078E90
        public void get_receipt(){} // RVA: 0x7FFD4E078E90
        public void get_purchaseToken(){} // RVA: 0x7FFD4E078E90
        public void get_sku(){} // RVA: 0x7FFD4E078E90
        public void IsAcknowledged(){} // RVA: 0x7FFD4E079D00
        public void IsPurchased(){} // RVA: 0x7FFD4E079D00
        public void IsPending(){} // RVA: 0x7FFD4E079D00
    }

    public class IGooglePurchaseBuilder
    {
        // ── Methods ──
        public void BuildPurchases(){} // RVA: 0x7FFD4E078F40
        public void BuildPurchase(){} // RVA: 0x7FFD4E078F40
    }

    public class IGooglePurchaseCallback
    {
        // ── Methods ──
        public void SetStoreCallback(){} // RVA: 0x7FFD4E090A40
        public void SetStoreConfiguration(){} // RVA: 0x7FFD4E090A40
        public void OnPurchaseSuccessful(){} // RVA: 0x7FFD4E09AF60
        public void OnPurchaseFailed(){} // RVA: 0x7FFD4E090A40
        public void NotifyDeferredPurchase(){} // RVA: 0x7FFD4E09AF60
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7FFD4E090A40
    }

    public class IGooglePurchaseService
    {
        // ── Methods ──
        public void Purchase(){}
    }

    public class IGooglePurchaseStateEnumProvider
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7FFD4E079960
        public void Pending(){} // RVA: 0x7FFD4E079960
    }

    public class IGooglePurchaseUpdatedListener
    {
    }

    public class IGoogleQueryPurchasesService
    {
        // ── Methods ──
        public void QueryPurchases(){} // RVA: 0x7FFD4E078E90
        public void GetPurchaseByToken(){} // RVA: 0x7FFD4E08A6F0
    }

    public class IProductDetailsConverter
    {
        // ── Methods ──
        public void ConvertOnQueryProductDetailsResponse(){} // RVA: 0x7FFD4E078F40
    }

    public class IProductDetailsQueryResponse
    {
        // ── Methods ──
        public void AddResponse(){} // RVA: 0x7FFD4E099B30
        public void ProductDetails(){} // RVA: 0x7FFD4E078E90
        public void IsRecoverable(){} // RVA: 0x7FFD4E079D00
        public void GetGoogleBillingResult(){} // RVA: 0x7FFD4E078E90
    }

    public class IProductDetailsResponseConsolidator
    {
        // ── Methods ──
        public void Consolidate(){} // RVA: 0x7FFD4E099B30
    }

    public class IQueryProductDetailsService
    {
        // ── Methods ──
        public void QueryAsyncProduct(){} // RVA: 0x7FFD4E099B30 | overloaded x2
    }

}