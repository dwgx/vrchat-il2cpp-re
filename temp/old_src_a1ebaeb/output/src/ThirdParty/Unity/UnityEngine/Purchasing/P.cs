// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 14
// Methods: 124

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition : Object
    {
        public object m_Quantity; // 0x33CD0880
        public object MaxDataLength; // 0x33CD0880
        public object type; // 0x17000007
        public object typeString; // 0x17000008

        // ── Original Methods ──
        public void get_type(){} // RVA: 0x7ffaa897f5c0
        public void set_type(){} // RVA: 0x7ffaa89350c0
        public void get_typeString(){} // RVA: 0x7ffaaf3ce1b0
        public void get_subtype(){} // RVA: 0x7ffaa89357c0
        public void set_subtype(){} // RVA: 0x7ffaaf3ce210
        public void get_quantity(){} // RVA: 0x7ffaa9f10140
        public void set_quantity(){} // RVA: 0x7ffaaa48a160
        public void set_data(){} // RVA: 0x7ffaaf3ce310
        public void .ctor(){} // RVA: 0x7ffaaf3ce5a0
        public void .ctor(){} // RVA: 0x7ffaaf3ce5a0
        public void .ctor(){} // RVA: 0x7ffaaf3ce5a0
    }

    public class Product : Object
    {
        public object _availableToPurchase; // 0x338D4330, was: <availableToPurchase>k__Backin
        public object _appleProductIsRestored; // 0x338D4330, was: <appleProductIsRestored>k__Bac

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3ce9b0
        public void .ctor(){} // RVA: 0x7ffaaf3ce9b0
        public void get_definition(){} // RVA: 0x7ffaa894d380
        public void set_definition(){} // RVA: 0x7ffaa8933e30
        public void get_metadata(){} // RVA: 0x7ffaa89357c0
        public void set_metadata(){} // RVA: 0x7ffaa8998e80
        public void get_availableToPurchase(){} // RVA: 0x7ffaa8a209d0
        public void set_availableToPurchase(){} // RVA: 0x7ffaa8a209e0
        public void get_transactionID(){} // RVA: 0x7ffaa8960130
        public void set_transactionID(){} // RVA: 0x7ffaa8933e90
        public void get_appleOriginalTransactionID(){} // RVA: 0x7ffaa8bfcc80
        public void set_appleOriginalTransactionID(){} // RVA: 0x7ffaa8960890
        public void get_appleProductIsRestored(){} // RVA: 0x7ffaa8bfcc70
        public void set_appleProductIsRestored(){} // RVA: 0x7ffaa8bfbbe0
        public void get_hasReceipt(){} // RVA: 0x7ffaaf3ce9d0
        public void get_receipt(){} // RVA: 0x7ffaa89af740
        public void set_receipt(){} // RVA: 0x7ffaa895a200
        public void Equals(){} // RVA: 0x7ffaaf3ce9f0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa900a960
    }

    public class ProductCatalog : Object
    {
        public object products; // 0x337E7680
        public object allProducts; // 0x17000011

        // ── Original Methods ──
        public void get_allProducts(){} // RVA: 0x7ffaa89357c0
        public void Initialize(){} // RVA: 0x7ffaaf3fcb30
        public void Initialize(){} // RVA: 0x7ffaaf3fcb30
        public void Deserialize(){} // RVA: 0x7ffaaf3fcbd0
        public void FromTextAsset(){} // RVA: 0x7ffaaf3fcc10
        public void LoadDefaultCatalog(){} // RVA: 0x7ffaaf3fcc70
        public void .ctor(){} // RVA: 0x7ffaaf3fce30
    }

    public class ProductCollection : Object
    {
        public object _set; // 0x33D043C0, was: <set>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3cea90
        public void AddProducts(){} // RVA: 0x7ffaaf3ceb60
        public void get_set(){} // RVA: 0x7ffaa89600c0
        public void get_all(){} // RVA: 0x7ffaa8960130
        public void set_all(){} // RVA: 0x7ffaa8933e90
        public void WithID(){} // RVA: 0x7ffaaf3cefa0
        public void WithStoreSpecificID(){} // RVA: 0x7ffaaf3cf010
    }

    public class ProductDefinition : Object
    {
        public object _type; // 0x339F7750, was: <type>k__BackingField

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3cf6a0
        public void .ctor(){} // RVA: 0x7ffaaf3cf6a0
        public void .ctor(){} // RVA: 0x7ffaaf3cf6a0
        public void .ctor(){} // RVA: 0x7ffaaf3cf6a0
        public void get_id(){} // RVA: 0x7ffaa894d380
        public void set_id(){} // RVA: 0x7ffaa8933e30
        public void get_storeSpecificId(){} // RVA: 0x7ffaa89357c0
        public void set_storeSpecificId(){} // RVA: 0x7ffaa8998e80
        public void get_type(){} // RVA: 0x7ffaa8aeced0
        public void set_type(){} // RVA: 0x7ffaa900aa90
        public void get_enabled(){} // RVA: 0x7ffaa894d7c0
        public void set_enabled(){} // RVA: 0x7ffaa9e49c50
        public void Equals(){} // RVA: 0x7ffaaf3cf6c0
        public void get_payouts(){} // RVA: 0x7ffaa8960130
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa900a960
        public void SetPayouts(){} // RVA: 0x7ffaaf3cf780
    }

    public class ProductDefinitionExtensions : Object
    {
        // ── Original Methods ──
        public void DecodeJSON(){} // RVA: 0x7ffaaf405830
    }

    public class ProductDetailsQueryResponse : Object
    {
        public object (00; // 0x84FC4720

        // ── Original Methods ──
        public void Finalize(){} // RVA: 0x7ffaaf3e2060
        public void AddResponse(){} // RVA: 0x7ffaaf3e2350
        public void ProductDetails(){} // RVA: 0x7ffaaf3e25c0
        public void IsRecoverable(){} // RVA: 0x7ffaaf3e2e90
        public void IsRecoverable(){} // RVA: 0x7ffaaf3e2e90
        public void .ctor(){} // RVA: 0x7ffaaf3e2f00
        // ── Binary Analysis Named ──
        public void GetGoogleBillingResult(){} // RVA: 0x7ffaaf3e2be0
    }

    public class ProductDetailsResponseConsolidator : Object
    {
        public object m_Responses; // 0x3395E1F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e31e0
        public void Consolidate(){} // RVA: 0x7ffaaf3e34d0
    }

    public class ProductDetailsResponseListener : AndroidJavaProxy
    {
        public object m_TelemetryDiagnostics; // 0x33917520

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3e0da0
        public void onProductDetailsResponse(){} // RVA: 0x7ffaaf3e0f30
    }

    public class ProductMetadata : Object
    {
        public object _localizedDescription; // 0x33308660, was: <localizedDescription>k__Backi

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_localizedPriceString(){} // RVA: 0x7ffaa894d380
        public void set_localizedPriceString(){} // RVA: 0x7ffaa8933e30
        public void get_localizedTitle(){} // RVA: 0x7ffaa89357c0
        public void set_localizedTitle(){} // RVA: 0x7ffaa8998e80
        public void get_localizedDescription(){} // RVA: 0x7ffaa89600c0
        public void set_localizedDescription(){} // RVA: 0x7ffaa89600d0
        public void get_isoCurrencyCode(){} // RVA: 0x7ffaa8960130
        public void set_isoCurrencyCode(){} // RVA: 0x7ffaa8933e90
        public void get_localizedPrice(){} // RVA: 0x7ffaade810e0
        public void set_localizedPrice(){} // RVA: 0x7ffaade810f0
    }

    public class ProductPurchaseUpdater : Object
    {
        // ── Original Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7ffaaf3d3dd0
    }

    public class PurchaseEventArgs : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void get_purchasedProduct(){} // RVA: 0x7ffaa894d380
        public void set_purchasedProduct(){} // RVA: 0x7ffaa8933e30
    }

    public class PurchasingFactory : Object
    {
        public object m_Store; // 0x318708F0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3cfb20
        public void get_storeName(){} // RVA: 0x7ffaa8bfcc80
        public void set_storeName(){} // RVA: 0x7ffaa8960890
        public void get_service(){} // RVA: 0x7ffaaf3cfd90
        public void set_service(){} // RVA: 0x7ffaa89600d0
        public void RegisterStore(){} // RVA: 0x7ffaaf3cfe00
        public void RegisterExtension(){} // RVA: 0x7ffaa887e5c0
        public void RegisterConfiguration(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetCatalogProvider(){} // RVA: 0x7ffaa8960130
    }

    public class PurchasingManager : Object
    {
        public object m_Logger; // 0x33C7EEA0
        public object m_logUnavailableProducts; // 0x33C7EEA0
        public object m_AdditionalProductsFailCallback; // 0x33C7EEA0
        public object _useTransactionLog; // 0x33C7EEA0, was: <useTransactionLog>k__BackingF

        // ── Original Methods ──
        public void get_useTransactionLog(){} // RVA: 0x7ffaa89fa570
        public void set_useTransactionLog(){} // RVA: 0x7ffaa89fa580
        public void .ctor(){} // RVA: 0x7ffaaf3cfed0
        public void InitiatePurchase(){} // RVA: 0x7ffaaf3d0380
        public void InitiatePurchase(){} // RVA: 0x7ffaaf3d0380
        public void InitiatePurchase(){} // RVA: 0x7ffaaf3d0380
        public void ConfirmPendingPurchase(){} // RVA: 0x7ffaaf3d0640
        public void get_products(){} // RVA: 0x7ffaa89fa590
        public void set_products(){} // RVA: 0x7ffaa89fa5a0
        public void OnPurchaseSucceeded(){} // RVA: 0x7ffaaf3d07b0
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7ffaaf3d0930
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7ffaaf3d0a20
        public void OnEntitlementRevoked(){} // RVA: 0x7ffaaf3d0bd0
        public void HandlePurchaseRetrieved(){} // RVA: 0x7ffaaf3d0be0
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7ffaaf3d0c80
        public void ClearProductReceipt(){} // RVA: 0x7ffaaf3d0ce0
        public void OnSetupFailed(){} // RVA: 0x7ffaaf3d0db0
        public void OnPurchaseFailed(){} // RVA: 0x7ffaaf3d0e70
        public void OnProductsRetrieved(){} // RVA: 0x7ffaaf3d1200
        public void CreateUnifiedReceipt(){} // RVA: 0x7ffaaf3d16b0
        public void ProcessPurchaseOnStart(){} // RVA: 0x7ffaaf3d16d0
        public void ProcessPurchaseIfNew(){} // RVA: 0x7ffaaf3d1850
        public void HasRecordedTransaction(){} // RVA: 0x7ffaaf3d1a00
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7ffaaf3d1b50
        public void Initialize(){} // RVA: 0x7ffaaf3d1e30
        // ── Binary Analysis Named ──
        public void CheckForInitialization(){} // RVA: 0x7ffaaf3d1a50
    }

}