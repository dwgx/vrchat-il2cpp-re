// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 19
// Methods: 134

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition : Object
    {
        // ── Methods ──
        public void get_type(){} // RVA: 0x7A8124910
        public void set_type(){} // RVA: 0x7A80DA0C0
        public void get_typeString(){} // RVA: 0x7AEFF3DB0
        public void get_subtype(){} // RVA: 0x7A80DA7B0
        public void set_subtype(){} // RVA: 0x7AEFF3E10
        public void get_quantity(){} // RVA: 0x7A97EDE10
        public void set_quantity(){} // RVA: 0x7A9D70460
        public void set_data(){} // RVA: 0x7AEFF3F10
        public void .ctor(){} // RVA: 0x7AEFF41A0
        // ── Unresolved (hash) ──
        public void m_Type(){} // RVA: 0x7B3FA7138
    }

    public class Price : Object
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7AF021F70
        public void OnAfterDeserialize(){} // RVA: 0x7AF022100
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Product : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFF45B0
        public void get_definition(){} // RVA: 0x7A80F2570
        public void set_definition(){} // RVA: 0x7A80D8E20
        public void get_metadata(){} // RVA: 0x7A80DA7B0
        public void set_metadata(){} // RVA: 0x7A813E420
        public void get_availableToPurchase(){} // RVA: 0x7A81C68D0
        public void set_availableToPurchase(){} // RVA: 0x7A81C68E0
        public void get_transactionID(){} // RVA: 0x7A8105330
        public void set_transactionID(){} // RVA: 0x7A80D8E80
        public void get_appleOriginalTransactionID(){} // RVA: 0x7A83F69F0
        public void set_appleOriginalTransactionID(){} // RVA: 0x7A8105A90
        public void get_appleProductIsRestored(){} // RVA: 0x7A82A20A0
        public void set_appleProductIsRestored(){} // RVA: 0x7A82A2C90
        public void get_hasReceipt(){} // RVA: 0x7AEFF45D0
        public void get_receipt(){} // RVA: 0x7A8154D80
        public void set_receipt(){} // RVA: 0x7A80FF440
        public void Equals(){} // RVA: 0x7AEFF45F0
        public void GetHashCode(){} // RVA: 0x7A8738190
        public void <definition>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class ProductCatalog : Object
    {
        // ── Methods ──
        public void get_allProducts(){} // RVA: 0x7A80DA7B0
        public void Initialize(){} // RVA: 0x7AF022AA0
        public void Deserialize(){} // RVA: 0x7AF022B40
        public void FromTextAsset(){} // RVA: 0x7AF022B80
        public void LoadDefaultCatalog(){} // RVA: 0x7AF022BE0
        public void .ctor(){} // RVA: 0x7AF022DA0
        public void instance(){} // RVA: 0x7B3FB4428
    }

    public class ProductCatalogImpl : Object
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7AF022E60
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ProductCatalogItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF022660
    }

    public class ProductCatalogPayout : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0224E0
    }

    public class ProductCollection : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFF4690
        public void AddProducts(){} // RVA: 0x7AEFF4760
        public void get_set(){} // RVA: 0x7A81052C0
        public void get_all(){} // RVA: 0x7A8105330
        public void set_all(){} // RVA: 0x7A80D8E80
        public void WithID(){} // RVA: 0x7AEFF4BA0
        public void WithStoreSpecificID(){} // RVA: 0x7AEFF4C10
        // ── Unresolved (hash) ──
        public void m_IdToProduct(){} // RVA: 0x7B3FB4428
    }

    public class ProductDefinition : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFF52B0
        public void get_id(){} // RVA: 0x7A80F2570
        public void set_id(){} // RVA: 0x7A80D8E20
        public void get_storeSpecificId(){} // RVA: 0x7A80DA7B0
        public void set_storeSpecificId(){} // RVA: 0x7A813E420
        public void get_type(){} // RVA: 0x7A851DB90
        public void set_type(){} // RVA: 0x7A8738180
        public void get_enabled(){} // RVA: 0x7A80F29B0
        public void set_enabled(){} // RVA: 0x7A9727920
        public void Equals(){} // RVA: 0x7AEFF52D0
        public void GetHashCode(){} // RVA: 0x7A8738190
        public void get_payouts(){} // RVA: 0x7A8105330
        public void SetPayouts(){} // RVA: 0x7AEFF5390
        public void <id>k__BackingField(){} // RVA: 0x7B3FAD638
    }

    public class ProductDefinitionExtensions : Object
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x7AF02BA70
    }

    public class ProductDetailsQueryResponse : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7AF007B90
        public void AddResponse(){} // RVA: 0x7AF007E80
        public void ProductDetails(){} // RVA: 0x7AF008110
        public void IsRecoverable(){} // RVA: 0x7AF008A00
        public void GetGoogleBillingResult(){} // RVA: 0x7AF008750
        public void .ctor(){} // RVA: 0x7AF008A70
    }

    public class ProductDetailsResponseConsolidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF008D50
        public void Consolidate(){} // RVA: 0x7AF009040
    }

    public class ProductDetailsResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF0068D0
        public void onProductDetailsResponse(){} // RVA: 0x7AF006A60
        // ── Unresolved (hash) ──
        public void m_OnProductDetailsResponse(){} // RVA: 0x7B41AC7D8
    }

    public class ProductInfoInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7AF016AC0
        public void GetCurrencyProp(){} // RVA: 0x7AF016C00
        public void GetDescriptionProp(){} // RVA: 0x7AF016CD0
        public void GetPriceProp(){} // RVA: 0x7AF016DA0
        public void GetPriceAmountMicrosProp(){} // RVA: 0x7AF016E70
        public void GetProductIdProp(){} // RVA: 0x7AF016F40
        public void GetTitleProp(){} // RVA: 0x7AF017010
    }

    public class ProductMetadata : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_localizedPriceString(){} // RVA: 0x7A80F2570
        public void set_localizedPriceString(){} // RVA: 0x7A80D8E20
        public void get_localizedTitle(){} // RVA: 0x7A80DA7B0
        public void set_localizedTitle(){} // RVA: 0x7A813E420
        public void get_localizedDescription(){} // RVA: 0x7A81052C0
        public void set_localizedDescription(){} // RVA: 0x7A81052D0
        public void get_isoCurrencyCode(){} // RVA: 0x7A8105330
        public void set_isoCurrencyCode(){} // RVA: 0x7A80D8E80
        public void get_localizedPrice(){} // RVA: 0x7ADAB6B40
        public void set_localizedPrice(){} // RVA: 0x7ADAB6B50
        public void <localizedPriceString>k__BackingField(){} // RVA: 0x7B3FB4428
    }

    public class ProductPurchaseUpdater : Object
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7AEFF9A30
    }

    public class PurchaseEventArgs : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void get_purchasedProduct(){} // RVA: 0x7A80F2570
        public void set_purchasedProduct(){} // RVA: 0x7A80D8E20
        public void <purchasedProduct>k__BackingField(){} // RVA: 0x7B41F1488
    }

    public class PurchasingFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFF5730
        public void get_storeName(){} // RVA: 0x7A83F69F0
        public void set_storeName(){} // RVA: 0x7A8105A90
        public void get_service(){} // RVA: 0x7AEFF5990
        public void set_service(){} // RVA: 0x7A81052D0
        public void RegisterStore(){} // RVA: 0x7AEFF5A00
        public void RegisterExtension(){} // RVA: 0x7A8051B10
        public void RegisterConfiguration(){} // RVA: 0x7A8051B10
        public void GetCatalogProvider(){} // RVA: 0x7A8105330
    }

    public class PurchasingManager : Object
    {
        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0x7A81A00C0
        public void set_useTransactionLog(){} // RVA: 0x7A81A00D0
        public void .ctor(){} // RVA: 0x7AEFF5AD0
        public void InitiatePurchase(){} // RVA: 0x7AEFF6090
        public void ConfirmPendingPurchase(){} // RVA: 0x7AEFF61C0
        public void get_products(){} // RVA: 0x7A81A00E0
        public void set_products(){} // RVA: 0x7A81A00F0
        public void OnPurchaseSucceeded(){} // RVA: 0x7AEFF6330
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7AEFF64B0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7AEFF65A0
        public void OnEntitlementRevoked(){} // RVA: 0x7AEFF6770
        public void HandlePurchaseRetrieved(){} // RVA: 0x7AEFF6780
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7AEFF6820
        public void ClearProductReceipt(){} // RVA: 0x7AEFF6880
        public void OnSetupFailed(){} // RVA: 0x7AEFF6950
        public void OnPurchaseFailed(){} // RVA: 0x7AEFF6A10
        public void OnProductsRetrieved(){} // RVA: 0x7AEFF6DA0
        public void CreateUnifiedReceipt(){} // RVA: 0x7AEFF7250
        public void ProcessPurchaseOnStart(){} // RVA: 0x7AEFF7270
        public void ProcessPurchaseIfNew(){} // RVA: 0x7AEFF7400
        public void HasRecordedTransaction(){} // RVA: 0x7AEFF75B0
        public void CheckForInitialization(){} // RVA: 0x7AEFF7600
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7AEFF7700
        public void Initialize(){} // RVA: 0x7AEFF7A00
    }

}