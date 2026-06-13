// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 19
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition
    {
        public 0x659E5828 m_Type; // 0x10
        public string m_Subtype; // 0x18
        public double m_Quantity; // 0x20
        public string m_Data; // 0x28
        public int MaxSubtypeLength;

        // ── Methods ──
        public void get_type(){} // RVA: 0x32A5C0
        public void set_type(){} // RVA: 0x2E00C0
        public void get_typeString(){} // RVA: 0x7214950
        public void get_subtype(){} // RVA: 0x2E07C0
        public void set_subtype(){} // RVA: 0x72149B0
        public void get_quantity(){} // RVA: 0x1A346F0
        public void set_quantity(){} // RVA: 0x1F65E90
        public void set_data(){} // RVA: 0x7214AB0
        public void .ctor(){} // RVA: 0x7214D40 | overloaded x3
    }

    public class Price
    {
        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7242790
        public void OnAfterDeserialize(){} // RVA: 0x7242920
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Product
    {
        public UnityEngine.Purchasing.ProductDefinition <definition>k__BackingField; // 0x10
        public UnityEngine.Purchasing.ProductMetadata <metadata>k__BackingField; // 0x18
        public bool <availableToPurchase>k__BackingField; // 0x20
        public string <transactionID>k__BackingField; // 0x28
        public string <appleOriginalTransactionID>k__BackingField; // 0x30
        public bool <appleProductIsRestored>k__BackingField; // 0x38
        public string <receipt>k__BackingField; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7215150 | overloaded x2
        public void get_definition(){} // RVA: 0x2F8380
        public void set_definition(){} // RVA: 0x2DEE30
        public void get_metadata(){} // RVA: 0x2E07C0
        public void set_metadata(){} // RVA: 0x343E80
        public void get_availableToPurchase(){} // RVA: 0x3CB9D0
        public void set_availableToPurchase(){} // RVA: 0x3CB9E0
        public void get_transactionID(){} // RVA: 0x30B130
        public void set_transactionID(){} // RVA: 0x2DEE90
        public void get_appleOriginalTransactionID(){} // RVA: 0x6374D0
        public void set_appleOriginalTransactionID(){} // RVA: 0x30B890
        public void get_appleProductIsRestored(){} // RVA: 0x4A6500
        public void set_appleProductIsRestored(){} // RVA: 0x4A78C0
        public void get_hasReceipt(){} // RVA: 0x7215170
        public void get_receipt(){} // RVA: 0x35A740
        public void set_receipt(){} // RVA: 0x305200
        public void Equals(){} // RVA: 0x7215190
        public void GetHashCode(){} // RVA: 0x99E0E0
    }

    public class ProductCatalog
    {
        public UnityEngine.Purchasing.IProductCatalogImpl instance;

        // ── Methods ──
        public void get_allProducts(){} // RVA: 0x2E07C0
        public void Initialize(){} // RVA: 0x72432D0 | overloaded x2
        public void Deserialize(){} // RVA: 0x7243370
        public void FromTextAsset(){} // RVA: 0x72433B0
        public void LoadDefaultCatalog(){} // RVA: 0x7243410
        public void .ctor(){} // RVA: 0x72435D0
    }

    public class ProductCatalogImpl
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7243690
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ProductCatalogItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7242E90
    }

    public class ProductCatalogPayout
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7242D10
    }

    public class ProductCollection
    {
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Purchasing.Product> _set; // 0x10
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Purchasing.Product> m_StoreSpecificIdToProduct; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7215230
        public void AddProducts(){} // RVA: 0x7215300
        public void get_set(){} // RVA: 0x30B0C0
        public void get_all(){} // RVA: 0x30B130
        public void set_all(){} // RVA: 0x2DEE90
        public void WithID(){} // RVA: 0x7215740
        public void WithStoreSpecificID(){} // RVA: 0x72157B0
    }

    public class ProductDefinition
    {
        public string _id; // 0x10
        public string _storeSpecificId; // 0x18
        public 0x659E5A38 <type>k__BackingField; // 0x20
        public bool <enabled>k__BackingField; // 0x24
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition> m_Payouts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7215E40 | overloaded x4
        public void get_id(){} // RVA: 0x2F8380
        public void set_id(){} // RVA: 0x2DEE30
        public void get_storeSpecificId(){} // RVA: 0x2E07C0
        public void set_storeSpecificId(){} // RVA: 0x343E80
        public void get_type(){} // RVA: 0x760030
        public void set_type(){} // RVA: 0x99E0D0
        public void get_enabled(){} // RVA: 0x2F87C0
        public void set_enabled(){} // RVA: 0x4D7670
        public void Equals(){} // RVA: 0x7215E60
        public void GetHashCode(){} // RVA: 0x99E0E0
        public void get_payouts(){} // RVA: 0x30B130
        public void SetPayouts(){} // RVA: 0x7215F20
    }

    public class ProductDefinitionExtensions
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x724BFD0
    }

    public class ProductDetailsQueryResponse
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7228800
        public void AddResponse(){} // RVA: 0x7228AF0
        public void ProductDetails(){} // RVA: 0x7228D60
        public void IsRecoverable(){} // RVA: 0x7229630 | overloaded x2
        public void GetGoogleBillingResult(){} // RVA: 0x7229380
        public void .ctor(){} // RVA: 0x72296A0
    }

    public class ProductDetailsResponseConsolidator
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7229980
        public void Consolidate(){} // RVA: 0x7229C70
    }

    public class ProductDetailsResponseListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7227540
        public void onProductDetailsResponse(){} // RVA: 0x72276D0
    }

    public class ProductInfoInterface
    {
        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7237690
        public void GetCurrencyProp(){} // RVA: 0x72377D0
        public void GetDescriptionProp(){} // RVA: 0x72378A0
        public void GetPriceProp(){} // RVA: 0x7237970
        public void GetPriceAmountMicrosProp(){} // RVA: 0x7237A40
        public void GetProductIdProp(){} // RVA: 0x7237B10
        public void GetTitleProp(){} // RVA: 0x7237BE0
    }

    public class ProductMetadata
    {
        public string <localizedPriceString>k__BackingField; // 0x10
        public string <localizedTitle>k__BackingField; // 0x18
        public string <localizedDescription>k__BackingField; // 0x20
        public string <isoCurrencyCode>k__BackingField; // 0x28
        public System.Decimal <localizedPrice>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310 | overloaded x3
        public void get_localizedPriceString(){} // RVA: 0x2F8380
        public void set_localizedPriceString(){} // RVA: 0x2DEE30
        public void get_localizedTitle(){} // RVA: 0x2E07C0
        public void set_localizedTitle(){} // RVA: 0x343E80
        public void get_localizedDescription(){} // RVA: 0x30B0C0
        public void set_localizedDescription(){} // RVA: 0x30B0D0
        public void get_isoCurrencyCode(){} // RVA: 0x30B130
        public void set_isoCurrencyCode(){} // RVA: 0x2DEE90
        public void get_localizedPrice(){} // RVA: 0x5CC8940
        public void set_localizedPrice(){} // RVA: 0x5CC8950
    }

    public class ProductPurchaseUpdater
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x721A570
    }

    public class PurchaseEventArgs
    {
        public UnityEngine.Purchasing.Product <purchasedProduct>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void get_purchasedProduct(){} // RVA: 0x2F8380
        public void set_purchasedProduct(){} // RVA: 0x2DEE30
    }

    public class PurchasingFactory
    {
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration> m_ConfigMap; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension> m_ExtensionMap; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x72162C0
        public void get_storeName(){} // RVA: 0x6374D0
        public void set_storeName(){} // RVA: 0x30B890
        public void get_service(){} // RVA: 0x7216530
        public void set_service(){} // RVA: 0x30B0D0
        public void RegisterStore(){} // RVA: 0x72165A0
        public void RegisterExtension(){} // RVA: 0x283FA0
        public void RegisterConfiguration(){} // RVA: 0x283FA0
        public void GetCatalogProvider(){} // RVA: 0x30B130
    }

    public class PurchasingManager
    {
        public UnityEngine.Purchasing.Extension.IStore m_Store; // 0x10
        public UnityEngine.Purchasing.IInternalStoreListener m_Listener; // 0x18

        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0x3A5570
        public void set_useTransactionLog(){} // RVA: 0x3A5580
        public void .ctor(){} // RVA: 0x7216670
        public void InitiatePurchase(){} // RVA: 0x7216B20 | overloaded x3
        public void ConfirmPendingPurchase(){} // RVA: 0x7216DE0
        public void get_products(){} // RVA: 0x3A5590
        public void set_products(){} // RVA: 0x3A55A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7216F50
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x72170D0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x72171C0
        public void OnEntitlementRevoked(){} // RVA: 0x7217370
        public void HandlePurchaseRetrieved(){} // RVA: 0x7217380
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7217420
        public void ClearProductReceipt(){} // RVA: 0x7217480
        public void OnSetupFailed(){} // RVA: 0x7217550
        public void OnPurchaseFailed(){} // RVA: 0x7217610
        public void OnProductsRetrieved(){} // RVA: 0x72179A0
        public void CreateUnifiedReceipt(){} // RVA: 0x7217E50
        public void ProcessPurchaseOnStart(){} // RVA: 0x7217E70
        public void ProcessPurchaseIfNew(){} // RVA: 0x7217FF0
        public void HasRecordedTransaction(){} // RVA: 0x72181A0
        public void CheckForInitialization(){} // RVA: 0x72181F0
        public void HasAvailableProductsToPurchase(){} // RVA: 0x72182F0
        public void Initialize(){} // RVA: 0x72185D0
    }

}