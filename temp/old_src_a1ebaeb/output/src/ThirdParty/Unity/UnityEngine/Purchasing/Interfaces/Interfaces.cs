// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
// Classes: 17
// Methods: 53

namespace ThirdParty.Unity.UnityEngine.Purchasing.Interfaces
{
    public class IBillingClientStateListener
    {
        // ── Original Methods ──
        public void RegisterOnConnected(){} // RVA: 0x7ffaa8660d80
        public void RegisterOnDisconnected(){} // RVA: 0x7ffaa8660d80
    }

    public class IGoogleBillingClient
    {
        // ── Original Methods ──
        public void StartConnection(){} // RVA: 0x7ffaa8660d80
        public void QueryPurchasesAsync(){} // RVA: 0x7ffaa8669e70
        public void QueryProductDetailsAsync(){} // RVA: 0x7ffaa866b2a0
        public void LaunchBillingFlow(){}
        public void ConsumeAsync(){} // RVA: 0x7ffaa8669e70
        public void AcknowledgePurchase(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void GetConnectionState(){} // RVA: 0x7ffaa8649ca0
    }

    public class IGoogleFinishTransactionService
    {
        // ── Original Methods ──
        public void FinishTransaction(){} // RVA: 0x7ffaa866b2a0
    }

    public class IGoogleLastKnownProductService
    {
        // ── Original Methods ──
        public void get_LastKnownOldProductId(){} // RVA: 0x7ffaa86491d0
        public void set_LastKnownOldProductId(){} // RVA: 0x7ffaa8660d80
        public void get_LastKnownProductId(){} // RVA: 0x7ffaa86491d0
        public void set_LastKnownProductId(){} // RVA: 0x7ffaa8660d80
        public void get_LastKnownProrationMode(){} // RVA: 0x7ffaa86491d0
        public void set_LastKnownProrationMode(){}
    }

    public class IGooglePlayStoreService
    {
        // ── Original Methods ──
        public void RetrieveProducts(){} // RVA: 0x7ffaa866b2a0
        public void Purchase(){} // RVA: 0x7ffaa8660d80
        public void FinishTransaction(){} // RVA: 0x7ffaa866b2a0
        public void FetchPurchases(){} // RVA: 0x7ffaa8660d80
        public void ResumeConnection(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetPurchase(){} // RVA: 0x7ffaa865aa30
    }

    public class IGoogleProductCallback
    {
        // ── Original Methods ──
        public void NotifyQueryProductDetailsFailed(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void SetStoreConfiguration(){} // RVA: 0x7ffaa8660d80
    }

    public class IGooglePurchase
    {
        // ── Original Methods ──
        public void get_purchaseState(){} // RVA: 0x7ffaa8649ca0
        public void get_skus(){} // RVA: 0x7ffaa86491d0
        public void get_receipt(){} // RVA: 0x7ffaa86491d0
        public void get_purchaseToken(){} // RVA: 0x7ffaa86491d0
        public void get_sku(){} // RVA: 0x7ffaa86491d0
        public void IsAcknowledged(){} // RVA: 0x7ffaa864a040
        public void IsPurchased(){} // RVA: 0x7ffaa864a040
        public void IsPending(){} // RVA: 0x7ffaa864a040
    }

    public class IGooglePurchaseBuilder
    {
        // ── Original Methods ──
        public void BuildPurchases(){} // RVA: 0x7ffaa8649280
        public void BuildPurchase(){} // RVA: 0x7ffaa8649280
    }

    public class IGooglePurchaseCallback
    {
        // ── Original Methods ──
        public void OnPurchaseSuccessful(){} // RVA: 0x7ffaa866b2a0
        public void OnPurchaseFailed(){} // RVA: 0x7ffaa8660d80
        public void NotifyDeferredPurchase(){} // RVA: 0x7ffaa866b2a0
        public void NotifyDeferredProrationUpgradeDowngradeSubscription(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void SetStoreCallback(){} // RVA: 0x7ffaa8660d80
        public void SetStoreConfiguration(){} // RVA: 0x7ffaa8660d80
    }

    public class IGooglePurchaseService
    {
        // ── Original Methods ──
        public void Purchase(){}
    }

    public class IGooglePurchaseStateEnumProvider
    {
        // ── Original Methods ──
        public void Purchased(){} // RVA: 0x7ffaa8649ca0
        public void Pending(){} // RVA: 0x7ffaa8649ca0
    }

    public class IGooglePurchaseUpdatedListener
    {
    }

    public class IGoogleQueryPurchasesService
    {
        // ── Original Methods ──
        public void QueryPurchases(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetPurchaseByToken(){} // RVA: 0x7ffaa865aa30
    }

    public class IProductDetailsConverter
    {
        // ── Original Methods ──
        public void ConvertOnQueryProductDetailsResponse(){} // RVA: 0x7ffaa8649280
    }

    public class IProductDetailsQueryResponse
    {
        // ── Original Methods ──
        public void AddResponse(){} // RVA: 0x7ffaa8669e70
        public void ProductDetails(){} // RVA: 0x7ffaa86491d0
        public void IsRecoverable(){} // RVA: 0x7ffaa864a040
        // ── Binary Analysis Named ──
        public void GetGoogleBillingResult(){} // RVA: 0x7ffaa86491d0
    }

    public class IProductDetailsResponseConsolidator
    {
        // ── Original Methods ──
        public void Consolidate(){} // RVA: 0x7ffaa8669e70
    }

    public class IQueryProductDetailsService
    {
        // ── Original Methods ──
        public void QueryAsyncProduct(){} // RVA: 0x7ffaa8669e70
        public void QueryAsyncProduct(){} // RVA: 0x7ffaa8669e70
    }

}