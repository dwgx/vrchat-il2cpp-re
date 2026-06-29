// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 19
// Methods: 126

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition : Object
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0xB8F8F0
        public void set_type(){} // RVA: 0xB460A0
        public void get_typeString(){} // RVA: 0x7D67550
        public void get_subtype(){} // RVA: 0xB465B0
        public void set_subtype(){} // RVA: 0x7D675B0
        public void get_quantity(){} // RVA: 0x22F9F60
        public void set_quantity(){} // RVA: 0x27EAE70
        public void set_data(){} // RVA: 0x7D676A0
        public void .ctor(){} // RVA: 0x7D67890
    }

    public class Price : Object
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7D952F0
        public void OnAfterDeserialize(){} // RVA: 0x7D95480
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Product : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D67C50
        public void get_definition(){} // RVA: 0xB5DBF0
        public void set_definition(){} // RVA: 0xB44D60
        public void get_metadata(){} // RVA: 0xB465B0
        public void set_metadata(){} // RVA: 0xBA9BA0
        public void get_availableToPurchase(){} // RVA: 0xC38360
        public void set_availableToPurchase(){} // RVA: 0xC38370
        public void get_transactionID(){} // RVA: 0xB70160
        public void set_transactionID(){} // RVA: 0xB44DC0
        public void get_appleOriginalTransactionID(){} // RVA: 0xD33E60
        public void set_appleOriginalTransactionID(){} // RVA: 0xB708C0
        public void get_appleProductIsRestored(){} // RVA: 0xD16660
        public void set_appleProductIsRestored(){} // RVA: 0xD14C10
        public void get_hasReceipt(){} // RVA: 0x7D67C70
        public void get_receipt(){} // RVA: 0xBC1B30
        public void set_receipt(){} // RVA: 0xB6A8C0
        public void Equals(){} // RVA: 0x7D67C90
        public void GetHashCode(){} // RVA: 0x1269730
    }

    public class ProductCatalog : Object
    {
        // ── Methods ──
        public void get_allProducts(){} // RVA: 0xB465B0
        public void Initialize(){} // RVA: 0x7D95DD0
        public void Deserialize(){} // RVA: 0x7D95E70
        public void FromTextAsset(){} // RVA: 0x7D95EB0
        public void LoadDefaultCatalog(){} // RVA: 0x7D95F10
        public void .ctor(){} // RVA: 0x7D960D0
    }

    public class ProductCatalogImpl : Object
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7D96190
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ProductCatalogItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D95990
    }

    public class ProductCatalogPayout : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D95820
    }

    public class ProductCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D67D30
        public void AddProducts(){} // RVA: 0x7D67E00
        public void get_set(){} // RVA: 0xB700F0
        public void get_all(){} // RVA: 0xB70160
        public void set_all(){} // RVA: 0xB44DC0
        public void WithID(){} // RVA: 0x7D68240
        public void WithStoreSpecificID(){} // RVA: 0x7D682B0
    }

    public class ProductDefinition : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D68A10
        public void get_id(){} // RVA: 0xB5DBF0
        public void set_id(){} // RVA: 0xB44D60
        public void get_storeSpecificId(){} // RVA: 0xB465B0
        public void set_storeSpecificId(){} // RVA: 0xBA9BA0
        public void get_type(){} // RVA: 0xFEAE90
        public void set_type(){} // RVA: 0x1269760
        public void get_enabled(){} // RVA: 0xB5E030
        public void set_enabled(){} // RVA: 0xD72F80
        public void Equals(){} // RVA: 0x7D68A30
        public void GetHashCode(){} // RVA: 0x1269730
        public void get_payouts(){} // RVA: 0xB70160
        public void SetPayouts(){} // RVA: 0x7D68AF0
    }

    public class ProductDefinitionExtensions : Object
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x7D9EC10
    }

    public class ProductDetailsQueryResponse : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7D7B270
        public void AddResponse(){} // RVA: 0x7D7B560
        public void ProductDetails(){} // RVA: 0x7D7B7F0
        public void IsRecoverable(){} // RVA: 0x7D7C0E0
        public void GetGoogleBillingResult(){} // RVA: 0x7D7BE30
        public void .ctor(){} // RVA: 0x7D7C150
    }

    public class ProductDetailsResponseConsolidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D7C430
        public void Consolidate(){} // RVA: 0x7D7C720
    }

    public class ProductDetailsResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D79FB0
        public void onProductDetailsResponse(){} // RVA: 0x7D7A140
    }

    public class ProductInfoInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7D89F00
        public void GetCurrencyProp(){} // RVA: 0x7D8A030
        public void GetDescriptionProp(){} // RVA: 0x7D8A100
        public void GetPriceProp(){} // RVA: 0x7D8A1D0
        public void GetPriceAmountMicrosProp(){} // RVA: 0x7D8A2A0
        public void GetProductIdProp(){} // RVA: 0x7D8A370
        public void GetTitleProp(){} // RVA: 0x7D8A440
    }

    public class ProductMetadata : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_localizedPriceString(){} // RVA: 0xB5DBF0
        public void set_localizedPriceString(){} // RVA: 0xB44D60
        public void get_localizedTitle(){} // RVA: 0xB465B0
        public void set_localizedTitle(){} // RVA: 0xBA9BA0
        public void get_localizedDescription(){} // RVA: 0xB700F0
        public void set_localizedDescription(){} // RVA: 0xB70100
        public void get_isoCurrencyCode(){} // RVA: 0xB70160
        public void set_isoCurrencyCode(){} // RVA: 0xB44DC0
        public void get_localizedPrice(){} // RVA: 0x16CD820
        public void set_localizedPrice(){} // RVA: 0x16DCEF0
    }

    public class ProductPurchaseUpdater : Object
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7D6D120
    }

    public class PurchaseEventArgs : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void get_purchasedProduct(){} // RVA: 0xB5DBF0
        public void set_purchasedProduct(){} // RVA: 0xB44D60
    }

    public class PurchasingFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D68E90
        public void get_storeName(){} // RVA: 0xD33E60
        public void set_storeName(){} // RVA: 0xB708C0
        public void get_service(){} // RVA: 0x7D690F0
        public void set_service(){} // RVA: 0xB70100
        public void RegisterStore(){} // RVA: 0x7D69160
        public void RegisterExtension(){} // RVA: 0xA94080
        public void RegisterConfiguration(){} // RVA: 0xA94080
        public void GetCatalogProvider(){} // RVA: 0xB70160
    }

    public class PurchasingManager : Object
    {
        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0xC10030
        public void set_useTransactionLog(){} // RVA: 0xC10040
        public void .ctor(){} // RVA: 0x7D69230
        public void InitiatePurchase(){} // RVA: 0x7D697D0
        public void ConfirmPendingPurchase(){} // RVA: 0x7D69900
        public void get_products(){} // RVA: 0xC10050
        public void set_products(){} // RVA: 0xC10060
        public void OnPurchaseSucceeded(){} // RVA: 0x7D69A70
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7D69BF0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7D69CE0
        public void OnEntitlementRevoked(){} // RVA: 0x7D69EB0
        public void HandlePurchaseRetrieved(){} // RVA: 0x7D69EC0
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7D69F60
        public void ClearProductReceipt(){} // RVA: 0x7D69FC0
        public void OnSetupFailed(){} // RVA: 0x7D6A090
        public void OnPurchaseFailed(){} // RVA: 0x7D6A150
        public void OnProductsRetrieved(){} // RVA: 0x7D6A4E0
        public void CreateUnifiedReceipt(){} // RVA: 0x7D6A990
        public void ProcessPurchaseOnStart(){} // RVA: 0x7D6A9B0
        public void ProcessPurchaseIfNew(){} // RVA: 0x7D6AB40
        public void HasRecordedTransaction(){} // RVA: 0x7D6ACF0
        public void CheckForInitialization(){} // RVA: 0x7D6AD40
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7D6AE40
        public void Initialize(){} // RVA: 0x7D6B140
    }

}