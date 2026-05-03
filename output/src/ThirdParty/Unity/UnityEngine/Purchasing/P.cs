// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 19
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition : Object
    {
        public U& m_Type; // 0x10
        public string m_Subtype; // 0x18
        public double m_Quantity; // 0x20
        public string m_Data; // 0x28
        public int MaxSubtypeLength;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFE811485C0
        public void set_type(){} // RVA: 0x7FFE810FE0C0
        public void get_typeString(){} // RVA: 0x7FFE87D54AF0
        public void get_subtype(){} // RVA: 0x7FFE810FE7C0
        public void set_subtype(){} // RVA: 0x7FFE87D54B50
        public void get_quantity(){} // RVA: 0x7FFE827BB220
        public void set_quantity(){} // RVA: 0x7FFE82CF0820
        public void set_data(){} // RVA: 0x7FFE87D54C50
        public void .ctor(){} // RVA: 0x7FFE87D54EE0 | overloaded x3
    }

    public class Price : Object
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFE87D82930
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87D82AC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Product : Object
    {
        public UnityEngine.Purchasing.ProductDefinition _definition; // 0x10
        public UnityEngine.Purchasing.ProductMetadata _metadata; // 0x18
        public bool _availableToPurchase; // 0x20
        public string _transactionID; // 0x28
        public string _appleOriginalTransactionID; // 0x30
        public bool _appleProductIsRestored; // 0x38
        public string _receipt; // 0x40
        public object field_7; // 0xC

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D552F0 | overloaded x2
        public void get_definition(){} // RVA: 0x7FFE81116380
        public void set_definition(){} // RVA: 0x7FFE810FCE30
        public void get_metadata(){} // RVA: 0x7FFE810FE7C0
        public void set_metadata(){} // RVA: 0x7FFE81161E80
        public void get_availableToPurchase(){} // RVA: 0x7FFE811E99D0
        public void set_availableToPurchase(){} // RVA: 0x7FFE811E99E0
        public void get_transactionID(){} // RVA: 0x7FFE81129130
        public void set_transactionID(){} // RVA: 0x7FFE810FCE90
        public void get_appleOriginalTransactionID(){} // RVA: 0x7FFE8144E200
        public void set_appleOriginalTransactionID(){} // RVA: 0x7FFE81129890
        public void get_appleProductIsRestored(){} // RVA: 0x7FFE812CF770
        public void set_appleProductIsRestored(){} // RVA: 0x7FFE812D0010
        public void get_hasReceipt(){} // RVA: 0x7FFE87D55310
        public void get_receipt(){} // RVA: 0x7FFE81178740
        public void set_receipt(){} // RVA: 0x7FFE81123200
        public void Equals(){} // RVA: 0x7FFE87D55330
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
    }

    public class ProductCatalog : Object
    {
        public UnityEngine.Purchasing.IProductCatalogImpl instance;

        // ── Methods ──
        public void get_allProducts(){} // RVA: 0x7FFE810FE7C0
        public void Initialize(){} // RVA: 0x7FFE87D83470 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFE87D83510
        public void FromTextAsset(){} // RVA: 0x7FFE87D83550
        public void LoadDefaultCatalog(){} // RVA: 0x7FFE87D835B0
        public void .ctor(){} // RVA: 0x7FFE87D83770
    }

    public class ProductCatalogImpl : Object
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7FFE87D83830
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ProductCatalogItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D83030
    }

    public class ProductCatalogPayout : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D82EB0
    }

    public class ProductCollection : Object
    {
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Purchasing.Product> m_IdToProduct; // 0x10
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D553D0
        public void AddProducts(){} // RVA: 0x7FFE87D554A0
        public void get_set(){} // RVA: 0x7FFE811290C0
        public void get_all(){} // RVA: 0x7FFE81129130
        public void set_all(){} // RVA: 0x7FFE810FCE90
        public void WithID(){} // RVA: 0x7FFE87D558E0
        public void WithStoreSpecificID(){} // RVA: 0x7FFE87D55950
    }

    public class ProductDefinition : Object
    {
        public string _id; // 0x10
        public string _storeSpecificId; // 0x18
        public 0x666BCFA4 _type; // 0x20
        public bool _enabled; // 0x24
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition> m_Payouts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D55FE0 | overloaded x4
        public void get_id(){} // RVA: 0x7FFE81116380
        public void set_id(){} // RVA: 0x7FFE810FCE30
        public void get_storeSpecificId(){} // RVA: 0x7FFE810FE7C0
        public void set_storeSpecificId(){} // RVA: 0x7FFE81161E80
        public void get_type(){} // RVA: 0x7FFE8151D690
        public void set_type(){} // RVA: 0x7FFE8170B670
        public void get_enabled(){} // RVA: 0x7FFE811167C0
        public void set_enabled(){} // RVA: 0x7FFE812EB1B0
        public void Equals(){} // RVA: 0x7FFE87D56000
        public void GetHashCode(){} // RVA: 0x7FFE8170B620
        public void get_payouts(){} // RVA: 0x7FFE81129130
        public void SetPayouts(){} // RVA: 0x7FFE87D560C0
    }

    public class ProductDefinitionExtensions : Object
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x7FFE87D8C170
    }

    public class ProductDetailsQueryResponse : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE87D689A0
        public void AddResponse(){} // RVA: 0x7FFE87D68C90
        public void ProductDetails(){} // RVA: 0x7FFE87D68F00
        public void IsRecoverable(){} // RVA: 0x7FFE87D697D0 | overloaded x2
        public void GetGoogleBillingResult(){} // RVA: 0x7FFE87D69520
        public void .ctor(){} // RVA: 0x7FFE87D69840
    }

    public class ProductDetailsResponseConsolidator : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D69B20
        public void Consolidate(){} // RVA: 0x7FFE87D69E10
    }

    public class ProductDetailsResponseListener : AndroidJavaProxy
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D676E0
        public void onProductDetailsResponse(){} // RVA: 0x7FFE87D67870
    }

    public class ProductInfoInterface : Object
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFE87D77830
        public void GetCurrencyProp(){} // RVA: 0x7FFE87D77970
        public void GetDescriptionProp(){} // RVA: 0x7FFE87D77A40
        public void GetPriceProp(){} // RVA: 0x7FFE87D77B10
        public void GetPriceAmountMicrosProp(){} // RVA: 0x7FFE87D77BE0
        public void GetProductIdProp(){} // RVA: 0x7FFE87D77CB0
        public void GetTitleProp(){} // RVA: 0x7FFE87D77D80
    }

    public class ProductMetadata : Object
    {
        public string _localizedPriceString; // 0x10
        public string _localizedTitle; // 0x18
        public string _localizedDescription; // 0x20
        public string _isoCurrencyCode; // 0x28
        public System.Decimal _localizedPrice; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310 | overloaded x3
        public void get_localizedPriceString(){} // RVA: 0x7FFE81116380
        public void set_localizedPriceString(){} // RVA: 0x7FFE810FCE30
        public void get_localizedTitle(){} // RVA: 0x7FFE810FE7C0
        public void set_localizedTitle(){} // RVA: 0x7FFE81161E80
        public void get_localizedDescription(){} // RVA: 0x7FFE811290C0
        public void set_localizedDescription(){} // RVA: 0x7FFE811290D0
        public void get_isoCurrencyCode(){} // RVA: 0x7FFE81129130
        public void set_isoCurrencyCode(){} // RVA: 0x7FFE810FCE90
        public void get_localizedPrice(){} // RVA: 0x7FFE86809840
        public void set_localizedPrice(){} // RVA: 0x7FFE86809850
    }

    public class ProductPurchaseUpdater : Object
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFE87D5A710
    }

    public class PurchaseEventArgs : Object
    {
        public UnityEngine.Purchasing.Product _purchasedProduct; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void get_purchasedProduct(){} // RVA: 0x7FFE81116380
        public void set_purchasedProduct(){} // RVA: 0x7FFE810FCE30
    }

    public class PurchasingFactory : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration> m_ConfigMap; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension> m_ExtensionMap; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D56460
        public void get_storeName(){} // RVA: 0x7FFE8144E200
        public void set_storeName(){} // RVA: 0x7FFE81129890
        public void get_service(){} // RVA: 0x7FFE87D566D0
        public void set_service(){} // RVA: 0x7FFE811290D0
        public void RegisterStore(){} // RVA: 0x7FFE87D56740
        public void RegisterExtension(){} // RVA: 0x7FFE810A1420
        public void RegisterConfiguration(){} // RVA: 0x7FFE810A1420
        public void GetCatalogProvider(){} // RVA: 0x7FFE81129130
    }

    public class PurchasingManager : Object
    {
        public UnityEngine.Purchasing.Extension.IStore m_Store; // 0x10
        public UnityEngine.Purchasing.IInternalStoreListener m_Listener; // 0x18

        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0x7FFE811C3570
        public void set_useTransactionLog(){} // RVA: 0x7FFE811C3580
        public void .ctor(){} // RVA: 0x7FFE87D56810
        public void InitiatePurchase(){} // RVA: 0x7FFE87D56CC0 | overloaded x3
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFE87D56F80
        public void get_products(){} // RVA: 0x7FFE811C3590
        public void set_products(){} // RVA: 0x7FFE811C35A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFE87D570F0
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFE87D57270
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFE87D57360
        public void OnEntitlementRevoked(){} // RVA: 0x7FFE87D57510
        public void HandlePurchaseRetrieved(){} // RVA: 0x7FFE87D57520
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7FFE87D575C0
        public void ClearProductReceipt(){} // RVA: 0x7FFE87D57620
        public void OnSetupFailed(){} // RVA: 0x7FFE87D576F0
        public void OnPurchaseFailed(){} // RVA: 0x7FFE87D577B0
        public void OnProductsRetrieved(){} // RVA: 0x7FFE87D57B40
        public void CreateUnifiedReceipt(){} // RVA: 0x7FFE87D57FF0
        public void ProcessPurchaseOnStart(){} // RVA: 0x7FFE87D58010
        public void ProcessPurchaseIfNew(){} // RVA: 0x7FFE87D58190
        public void HasRecordedTransaction(){} // RVA: 0x7FFE87D58340
        public void CheckForInitialization(){} // RVA: 0x7FFE87D58390
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7FFE87D58490
        public void Initialize(){} // RVA: 0x7FFE87D58770
    }

}