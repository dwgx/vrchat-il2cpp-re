// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 19
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAF2DDA5C0
        public void set_type(){} // RVA: 0x7FFAF2D900C0
        public void get_typeString(){} // RVA: 0x7FFAF9CC4950
        public void get_subtype(){} // RVA: 0x7FFAF2D907C0
        public void set_subtype(){} // RVA: 0x7FFAF9CC49B0
        public void get_quantity(){} // RVA: 0x7FFAF44E46F0
        public void set_quantity(){} // RVA: 0x7FFAF4A15E90
        public void set_data(){} // RVA: 0x7FFAF9CC4AB0
        public void .ctor(){} // RVA: 0x7FFAF9CC4D40 | overloaded x3
    }

    public class Price
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFAF9CF2790
        public void OnAfterDeserialize(){} // RVA: 0x7FFAF9CF2920
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Product
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CC5150 | overloaded x2
        public void get_definition(){} // RVA: 0x7FFAF2DA8380
        public void set_definition(){} // RVA: 0x7FFAF2D8EE30
        public void get_metadata(){} // RVA: 0x7FFAF2D907C0
        public void set_metadata(){} // RVA: 0x7FFAF2DF3E80
        public void get_availableToPurchase(){} // RVA: 0x7FFAF2E7B9D0
        public void set_availableToPurchase(){} // RVA: 0x7FFAF2E7B9E0
        public void get_transactionID(){} // RVA: 0x7FFAF2DBB130
        public void set_transactionID(){} // RVA: 0x7FFAF2D8EE90
        public void get_appleOriginalTransactionID(){} // RVA: 0x7FFAF30E74D0
        public void set_appleOriginalTransactionID(){} // RVA: 0x7FFAF2DBB890
        public void get_appleProductIsRestored(){} // RVA: 0x7FFAF2F56500
        public void set_appleProductIsRestored(){} // RVA: 0x7FFAF2F578C0
        public void get_hasReceipt(){} // RVA: 0x7FFAF9CC5170
        public void get_receipt(){} // RVA: 0x7FFAF2E0A740
        public void set_receipt(){} // RVA: 0x7FFAF2DB5200
        public void Equals(){} // RVA: 0x7FFAF9CC5190
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
    }

    public class ProductCatalog
    {
        // ── Methods ──
        public void get_allProducts(){} // RVA: 0x7FFAF2D907C0
        public void Initialize(){} // RVA: 0x7FFAF9CF32D0 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFAF9CF3370
        public void FromTextAsset(){} // RVA: 0x7FFAF9CF33B0
        public void LoadDefaultCatalog(){} // RVA: 0x7FFAF9CF3410
        public void .ctor(){} // RVA: 0x7FFAF9CF35D0
    }

    public class ProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7FFAF9CF3690
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ProductCatalogItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CF2E90
    }

    public class ProductCatalogPayout
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CF2D10
    }

    public class ProductCollection
    {
        public object _set;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CC5230
        public void AddProducts(){} // RVA: 0x7FFAF9CC5300
        public void get_set(){} // RVA: 0x7FFAF2DBB0C0
        public void get_all(){} // RVA: 0x7FFAF2DBB130
        public void set_all(){} // RVA: 0x7FFAF2D8EE90
        public void WithID(){} // RVA: 0x7FFAF9CC5740
        public void WithStoreSpecificID(){} // RVA: 0x7FFAF9CC57B0
    }

    public class ProductDefinition
    {
        public object _id;
        public object _storeSpecificId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CC5E40 | overloaded x4
        public void get_id(){} // RVA: 0x7FFAF2DA8380
        public void set_id(){} // RVA: 0x7FFAF2D8EE30
        public void get_storeSpecificId(){} // RVA: 0x7FFAF2D907C0
        public void set_storeSpecificId(){} // RVA: 0x7FFAF2DF3E80
        public void get_type(){} // RVA: 0x7FFAF3210030
        public void set_type(){} // RVA: 0x7FFAF344E0D0
        public void get_enabled(){} // RVA: 0x7FFAF2DA87C0
        public void set_enabled(){} // RVA: 0x7FFAF2F87670
        public void Equals(){} // RVA: 0x7FFAF9CC5E60
        public void GetHashCode(){} // RVA: 0x7FFAF344E0E0
        public void get_payouts(){} // RVA: 0x7FFAF2DBB130
        public void SetPayouts(){} // RVA: 0x7FFAF9CC5F20
    }

    public class ProductDefinitionExtensions
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x7FFAF9CFBFD0
    }

    public class ProductDetailsQueryResponse
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAF9CD8800
        public void AddResponse(){} // RVA: 0x7FFAF9CD8AF0
        public void ProductDetails(){} // RVA: 0x7FFAF9CD8D60
        public void IsRecoverable(){} // RVA: 0x7FFAF9CD9630 | overloaded x2
        public void GetGoogleBillingResult(){} // RVA: 0x7FFAF9CD9380
        public void .ctor(){} // RVA: 0x7FFAF9CD96A0
    }

    public class ProductDetailsResponseConsolidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD9980
        public void Consolidate(){} // RVA: 0x7FFAF9CD9C70
    }

    public class ProductDetailsResponseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CD7540
        public void onProductDetailsResponse(){} // RVA: 0x7FFAF9CD76D0
    }

    public class ProductInfoInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAF9CE7690
        public void GetCurrencyProp(){} // RVA: 0x7FFAF9CE77D0
        public void GetDescriptionProp(){} // RVA: 0x7FFAF9CE78A0
        public void GetPriceProp(){} // RVA: 0x7FFAF9CE7970
        public void GetPriceAmountMicrosProp(){} // RVA: 0x7FFAF9CE7A40
        public void GetProductIdProp(){} // RVA: 0x7FFAF9CE7B10
        public void GetTitleProp(){} // RVA: 0x7FFAF9CE7BE0
    }

    public class ProductMetadata
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310 | overloaded x3
        public void get_localizedPriceString(){} // RVA: 0x7FFAF2DA8380
        public void set_localizedPriceString(){} // RVA: 0x7FFAF2D8EE30
        public void get_localizedTitle(){} // RVA: 0x7FFAF2D907C0
        public void set_localizedTitle(){} // RVA: 0x7FFAF2DF3E80
        public void get_localizedDescription(){} // RVA: 0x7FFAF2DBB0C0
        public void set_localizedDescription(){} // RVA: 0x7FFAF2DBB0D0
        public void get_isoCurrencyCode(){} // RVA: 0x7FFAF2DBB130
        public void set_isoCurrencyCode(){} // RVA: 0x7FFAF2D8EE90
        public void get_localizedPrice(){} // RVA: 0x7FFAF8778940
        public void set_localizedPrice(){} // RVA: 0x7FFAF8778950
    }

    public class ProductPurchaseUpdater
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFAF9CCA570
    }

    public class PurchaseEventArgs
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void get_purchasedProduct(){} // RVA: 0x7FFAF2DA8380
        public void set_purchasedProduct(){} // RVA: 0x7FFAF2D8EE30
    }

    public class PurchasingFactory
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CC62C0
        public void get_storeName(){} // RVA: 0x7FFAF30E74D0
        public void set_storeName(){} // RVA: 0x7FFAF2DBB890
        public void get_service(){} // RVA: 0x7FFAF9CC6530
        public void set_service(){} // RVA: 0x7FFAF2DBB0D0
        public void RegisterStore(){} // RVA: 0x7FFAF9CC65A0
        public void RegisterExtension(){} // RVA: 0x7FFAF2D33FA0
        public void RegisterConfiguration(){} // RVA: 0x7FFAF2D33FA0
        public void GetCatalogProvider(){} // RVA: 0x7FFAF2DBB130
    }

    public class PurchasingManager
    {
        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0x7FFAF2E55570
        public void set_useTransactionLog(){} // RVA: 0x7FFAF2E55580
        public void .ctor(){} // RVA: 0x7FFAF9CC6670
        public void InitiatePurchase(){} // RVA: 0x7FFAF9CC6B20 | overloaded x3
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFAF9CC6DE0
        public void get_products(){} // RVA: 0x7FFAF2E55590
        public void set_products(){} // RVA: 0x7FFAF2E555A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAF9CC6F50
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFAF9CC70D0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFAF9CC71C0
        public void OnEntitlementRevoked(){} // RVA: 0x7FFAF9CC7370
        public void HandlePurchaseRetrieved(){} // RVA: 0x7FFAF9CC7380
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7FFAF9CC7420
        public void ClearProductReceipt(){} // RVA: 0x7FFAF9CC7480
        public void OnSetupFailed(){} // RVA: 0x7FFAF9CC7550
        public void OnPurchaseFailed(){} // RVA: 0x7FFAF9CC7610
        public void OnProductsRetrieved(){} // RVA: 0x7FFAF9CC79A0
        public void CreateUnifiedReceipt(){} // RVA: 0x7FFAF9CC7E50
        public void ProcessPurchaseOnStart(){} // RVA: 0x7FFAF9CC7E70
        public void ProcessPurchaseIfNew(){} // RVA: 0x7FFAF9CC7FF0
        public void HasRecordedTransaction(){} // RVA: 0x7FFAF9CC81A0
        public void CheckForInitialization(){} // RVA: 0x7FFAF9CC81F0
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7FFAF9CC82F0
        public void Initialize(){} // RVA: 0x7FFAF9CC85D0
    }

}