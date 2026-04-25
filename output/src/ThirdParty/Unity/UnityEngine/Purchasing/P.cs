// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 19
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition : Object
    {
        public 0x6B2C2240 type; // 0x10
        public string typeString; // 0x18
        public double subtype; // 0x20
        public string quantity; // 0x28
        public int data;
        public int MaxDataLength;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFAC2F6E5C0
        public void set_type(){} // RVA: 0x7FFAC2F240C0
        public void get_typeString(){} // RVA: 0x7FFAC99AC250
        public void get_subtype(){} // RVA: 0x7FFAC2F247C0
        public void set_subtype(){} // RVA: 0x7FFAC99AC2B0
        public void get_quantity(){} // RVA: 0x7FFAC44ED560
        public void set_quantity(){} // RVA: 0x7FFAC4A87CC0
        public void set_data(){} // RVA: 0x7FFAC99AC3B0
        public void .ctor(){} // RVA: 0x7FFAC99AC640 | overloaded x3
    }

    public class Price : Object
    {
        public System.Decimal value; // 0x10
        public int[] data; // 0x20
        public double num; // 0x28

        // ── Methods ──
        public void OnBeforeSerialize(){} // RVA: 0x7FFAC99DA090
        public void OnAfterDeserialize(){} // RVA: 0x7FFAC99DA220
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Product : Object
    {
        public UnityEngine.Purchasing.ProductDefinition definition; // 0x10
        public UnityEngine.Purchasing.ProductMetadata metadata; // 0x18
        public bool availableToPurchase; // 0x20
        public string transactionID; // 0x28
        public string appleOriginalTransactionID; // 0x30
        public bool appleProductIsRestored; // 0x38
        public string hasReceipt; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99ACA50 | overloaded x2
        public void get_definition(){} // RVA: 0x7FFAC2F3C380
        public void set_definition(){} // RVA: 0x7FFAC2F22E30
        public void get_metadata(){} // RVA: 0x7FFAC2F247C0
        public void set_metadata(){} // RVA: 0x7FFAC2F87E80
        public void get_availableToPurchase(){} // RVA: 0x7FFAC300F9D0
        public void set_availableToPurchase(){} // RVA: 0x7FFAC300F9E0
        public void get_transactionID(){} // RVA: 0x7FFAC2F4F130
        public void set_transactionID(){} // RVA: 0x7FFAC2F22E90
        public void get_appleOriginalTransactionID(){} // RVA: 0x7FFAC31D95E0
        public void set_appleOriginalTransactionID(){} // RVA: 0x7FFAC2F4F890
        public void get_appleProductIsRestored(){} // RVA: 0x7FFAC31D95D0
        public void set_appleProductIsRestored(){} // RVA: 0x7FFAC31D95C0
        public void get_hasReceipt(){} // RVA: 0x7FFAC99ACA70
        public void get_receipt(){} // RVA: 0x7FFAC2F9E740
        public void set_receipt(){} // RVA: 0x7FFAC2F49200
        public void Equals(){} // RVA: 0x7FFAC99ACA90
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
    }

    public class ProductCatalog : Object
    {
        public UnityEngine.Purchasing.IProductCatalogImpl allProducts;
        public bool enableCodelessAutoInitialization; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.ProductCatalogItem> products; // 0x18

        // ── Methods ──
        public void get_allProducts(){} // RVA: 0x7FFAC2F247C0
        public void Initialize(){} // RVA: 0x7FFAC99DABD0 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFAC99DAC70
        public void FromTextAsset(){} // RVA: 0x7FFAC99DACB0
        public void LoadDefaultCatalog(){} // RVA: 0x7FFAC99DAD10
        public void .ctor(){} // RVA: 0x7FFAC99DAED0
    }

    public class ProductCatalogImpl : Object
    {
        // ── Methods ──
        public void LoadDefaultCatalog(){} // RVA: 0x7FFAC99DAF90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ProductCatalogItem : Object
    {
        public string id; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.StoreID> storeIDs; // 0x18
        public UnityEngine.Purchasing.LocalizedProductDescription defaultDescription; // 0x20
        public UnityEngine.Purchasing.Price googlePrice; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.LocalizedProductDescription> descriptions; // 0x30
        public UnityEngine.Purchasing.Price udpPrice; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.ProductCatalogPayout> payouts; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99DA790
    }

    public class ProductCatalogPayout : Object
    {
        public string t; // 0x10
        public string st; // 0x18
        public string d; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99DA610
    }

    public class ProductCollection : Object
    {
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Purchasing.Product> set; // 0x10
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Purchasing.Product> all; // 0x18
        public System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.Product> <set>k__BackingField; // 0x20
        public UnityEngine.Purchasing.Product[] <all>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99ACB30
        public void AddProducts(){} // RVA: 0x7FFAC99ACC00
        public void get_set(){} // RVA: 0x7FFAC2F4F0C0
        public void get_all(){} // RVA: 0x7FFAC2F4F130
        public void set_all(){} // RVA: 0x7FFAC2F22E90
        public void WithID(){} // RVA: 0x7FFAC99AD040
        public void WithStoreSpecificID(){} // RVA: 0x7FFAC99AD0B0
    }

    public class ProductDefinition : Object
    {
        public string id; // 0x10
        public string storeSpecificId; // 0x18
        public 0x6B2C2450 type; // 0x20
        public bool enabled; // 0x24
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.PayoutDefinition> payouts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99AD740 | overloaded x4
        public void get_id(){} // RVA: 0x7FFAC2F3C380
        public void set_id(){} // RVA: 0x7FFAC2F22E30
        public void get_storeSpecificId(){} // RVA: 0x7FFAC2F247C0
        public void set_storeSpecificId(){} // RVA: 0x7FFAC2F87E80
        public void get_type(){} // RVA: 0x7FFAC30DBBE0
        public void set_type(){} // RVA: 0x7FFAC35DB7A0
        public void get_enabled(){} // RVA: 0x7FFAC2F3C7C0
        public void set_enabled(){} // RVA: 0x7FFAC4422FB0
        public void Equals(){} // RVA: 0x7FFAC99AD760
        public void GetHashCode(){} // RVA: 0x7FFAC35DB750
        public void get_payouts(){} // RVA: 0x7FFAC2F4F130
        public void SetPayouts(){} // RVA: 0x7FFAC99AD820
    }

    public class ProductDefinitionExtensions : Object
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x7FFAC99E38D0
    }

    public class ProductDetailsQueryResponse : Object
    {
        public System.Collections.Concurrent.ConcurrentBag`1<System.ValueTuple`2<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.IEnumerable`1<UnityEngine.AndroidJavaObject>>> m_Responses; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC99C0100
        public void AddResponse(){} // RVA: 0x7FFAC99C03F0
        public void ProductDetails(){} // RVA: 0x7FFAC99C0660
        public void IsRecoverable(){} // RVA: 0x7FFAC99C0F30 | overloaded x2
        public void GetGoogleBillingResult(){} // RVA: 0x7FFAC99C0C80
        public void .ctor(){} // RVA: 0x7FFAC99C0FA0
    }

    public class ProductDetailsResponseConsolidator : Object
    {
        public int m_NumberReceivedCallbacks; // 0x10
        public System.Action`1<UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse> m_OnProductDetailsResponseConsolidated; // 0x18
        public UnityEngine.Purchasing.Interfaces.IProductDetailsQueryResponse m_Responses; // 0x20
        public Uniject.IUtil m_Util; // 0x28
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C1280
        public void Consolidate(){} // RVA: 0x7FFAC99C1570
    }

    public class ProductDetailsResponseListener : AndroidJavaProxy
    {
        public System.Action`2<UnityEngine.Purchasing.Models.IGoogleBillingResult,System.Collections.Generic.List`1<UnityEngine.AndroidJavaObject>> m_OnProductDetailsResponse; // 0x20
        public Uniject.IUtil m_Util; // 0x28
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BEE40
        public void onProductDetailsResponse(){} // RVA: 0x7FFAC99BEFD0
    }

    public class ProductInfoInterface : Object
    {
        public System.Type s_typeCache;

        // ── Methods ──
        public void GetClassType(){} // RVA: 0x7FFAC99CEF90
        public void GetCurrencyProp(){} // RVA: 0x7FFAC99CF0D0
        public void GetDescriptionProp(){} // RVA: 0x7FFAC99CF1A0
        public void GetPriceProp(){} // RVA: 0x7FFAC99CF270
        public void GetPriceAmountMicrosProp(){} // RVA: 0x7FFAC99CF340
        public void GetProductIdProp(){} // RVA: 0x7FFAC99CF410
        public void GetTitleProp(){} // RVA: 0x7FFAC99CF4E0
    }

    public class ProductMetadata : Object
    {
        public string localizedPriceString; // 0x10
        public string localizedTitle; // 0x18
        public string localizedDescription; // 0x20
        public string isoCurrencyCode; // 0x28
        public System.Decimal localizedPrice; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310 | overloaded x3
        public void get_localizedPriceString(){} // RVA: 0x7FFAC2F3C380
        public void set_localizedPriceString(){} // RVA: 0x7FFAC2F22E30
        public void get_localizedTitle(){} // RVA: 0x7FFAC2F247C0
        public void set_localizedTitle(){} // RVA: 0x7FFAC2F87E80
        public void get_localizedDescription(){} // RVA: 0x7FFAC2F4F0C0
        public void set_localizedDescription(){} // RVA: 0x7FFAC2F4F0D0
        public void get_isoCurrencyCode(){} // RVA: 0x7FFAC2F4F130
        public void set_isoCurrencyCode(){} // RVA: 0x7FFAC2F22E90
        public void get_localizedPrice(){} // RVA: 0x7FFAC845FF30
        public void set_localizedPrice(){} // RVA: 0x7FFAC845FF40
    }

    public class ProductPurchaseUpdater : Object
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFAC99B1E70
    }

    public class PurchaseEventArgs : Object
    {
        public UnityEngine.Purchasing.Product purchasedProduct; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void get_purchasedProduct(){} // RVA: 0x7FFAC2F3C380
        public void set_purchasedProduct(){} // RVA: 0x7FFAC2F22E30
    }

    public class PurchasingFactory : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.Extension.IStoreConfiguration> storeName; // 0x10
        public System.Collections.Generic.Dictionary`2<System.Type,UnityEngine.Purchasing.IStoreExtension> service; // 0x18
        public UnityEngine.Purchasing.Extension.IStore m_Store; // 0x20
        public UnityEngine.Purchasing.Extension.ICatalogProvider m_CatalogProvider; // 0x28
        public string <storeName>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99ADBC0
        public void get_storeName(){} // RVA: 0x7FFAC31D95E0
        public void set_storeName(){} // RVA: 0x7FFAC2F4F890
        public void get_service(){} // RVA: 0x7FFAC99ADE30
        public void set_service(){} // RVA: 0x7FFAC2F4F0D0
        public void RegisterStore(){} // RVA: 0x7FFAC99ADEA0
        public void RegisterExtension(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterConfiguration(){} // RVA: 0x7FFAC2E8DC40
        public void GetCatalogProvider(){} // RVA: 0x7FFAC2F4F130
    }

    public class PurchasingManager : Object
    {
        public UnityEngine.Purchasing.Extension.IStore useTransactionLog; // 0x10
        public UnityEngine.Purchasing.IInternalStoreListener products; // 0x18
        public UnityEngine.ILogger m_Logger; // 0x20
        public UnityEngine.Purchasing.TransactionLog m_TransactionLog; // 0x28
        public string m_StoreName; // 0x30
        public bool m_logUnavailableProducts; // 0x38
        public UnityEngine.Purchasing.IUnityServicesInitializationChecker m_UnityServicesInitializationChecker; // 0x40
        public System.Action m_AdditionalProductsCallback; // 0x48
        public System.Action`1<0x6B2C20E0> m_AdditionalProductsFailCallback; // 0x50
        public System.Action`2<0x6B2C20E0,string> m_AdditionalProductsDetailedFailCallback; // 0x58
        public System.Collections.Generic.HashSet`1<string> purchasesProcessedInSession; // 0x60
        public bool <useTransactionLog>k__BackingField; // 0x68
        public UnityEngine.Purchasing.ProductCollection <products>k__BackingField; // 0x70
        public bool initialized; // 0x78

        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0x7FFAC2FE9570
        public void set_useTransactionLog(){} // RVA: 0x7FFAC2FE9580
        public void .ctor(){} // RVA: 0x7FFAC99ADF70
        public void InitiatePurchase(){} // RVA: 0x7FFAC99AE420 | overloaded x3
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFAC99AE6E0
        public void get_products(){} // RVA: 0x7FFAC2FE9590
        public void set_products(){} // RVA: 0x7FFAC2FE95A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFAC99AE850
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFAC99AE9D0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFAC99AEAC0
        public void OnEntitlementRevoked(){} // RVA: 0x7FFAC99AEC70
        public void HandlePurchaseRetrieved(){} // RVA: 0x7FFAC99AEC80
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7FFAC99AED20
        public void ClearProductReceipt(){} // RVA: 0x7FFAC99AED80
        public void OnSetupFailed(){} // RVA: 0x7FFAC99AEE50
        public void OnPurchaseFailed(){} // RVA: 0x7FFAC99AEF10
        public void OnProductsRetrieved(){} // RVA: 0x7FFAC99AF2A0
        public void CreateUnifiedReceipt(){} // RVA: 0x7FFAC99AF750
        public void ProcessPurchaseOnStart(){} // RVA: 0x7FFAC99AF770
        public void ProcessPurchaseIfNew(){} // RVA: 0x7FFAC99AF8F0
        public void HasRecordedTransaction(){} // RVA: 0x7FFAC99AFAA0
        public void CheckForInitialization(){} // RVA: 0x7FFAC99AFAF0
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7FFAC99AFBF0
        public void Initialize(){} // RVA: 0x7FFAC99AFED0
    }

}