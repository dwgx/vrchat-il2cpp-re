// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 14
// Methods: 124

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class PayoutDefinition : Object
    {
        public ing.? type; // 0x10
        public string typeString; // 0x18
        public double subtype; // 0x20
        public string quantity; // 0x28
        public int data;
        public int MaxDataLength;

        // ── Methods ──
        public void get_type(){} // RVA: 0x7FFD4E38E5C0
        public void set_type(){} // RVA: 0x7FFD4E3440C0
        public void get_typeString(){} // RVA: 0x7FFD54DCC250
        public void get_subtype(){} // RVA: 0x7FFD4E3447C0
        public void set_subtype(){} // RVA: 0x7FFD54DCC2B0
        public void get_quantity(){} // RVA: 0x7FFD4F90D560
        public void set_quantity(){} // RVA: 0x7FFD4FEA7CC0
        public void set_data(){} // RVA: 0x7FFD54DCC3B0
        public void .ctor(){} // RVA: 0x7FFD54DCC640 | overloaded x3
    }

    public class Product : Object
    {
        public ing.ÍÏÌÌÌÍÏÎÏÍÏÎÍÏÍÍÌÌÌÏ definition; // 0x10
        public ing.ÎÎÏÏÏÎÏÎÏÎÎÌÍÍÌ metadata; // 0x18
        public bool availableToPurchase; // 0x20
        public string transactionID; // 0x28
        public string appleOriginalTransactionID; // 0x30
        public bool appleProductIsRestored; // 0x38
        public string hasReceipt; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DCCA50 | overloaded x2
        public void get_definition(){} // RVA: 0x7FFD4E35C380
        public void set_definition(){} // RVA: 0x7FFD4E342E30
        public void get_metadata(){} // RVA: 0x7FFD4E3447C0
        public void set_metadata(){} // RVA: 0x7FFD4E3A7E80
        public void get_availableToPurchase(){} // RVA: 0x7FFD4E42F9D0
        public void set_availableToPurchase(){} // RVA: 0x7FFD4E42F9E0
        public void get_transactionID(){} // RVA: 0x7FFD4E36F130
        public void set_transactionID(){} // RVA: 0x7FFD4E342E90
        public void get_appleOriginalTransactionID(){} // RVA: 0x7FFD4E5F95E0
        public void set_appleOriginalTransactionID(){} // RVA: 0x7FFD4E36F890
        public void get_appleProductIsRestored(){} // RVA: 0x7FFD4E5F95D0
        public void set_appleProductIsRestored(){} // RVA: 0x7FFD4E5F95C0
        public void get_hasReceipt(){} // RVA: 0x7FFD54DCCA70
        public void get_receipt(){} // RVA: 0x7FFD4E3BE740
        public void set_receipt(){} // RVA: 0x7FFD4E369200
        public void Equals(){} // RVA: 0x7FFD54DCCA90
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB750
    }

    public class ProductCatalog : Object
    {
        public ing.h allProducts;
        public bool enableCodelessAutoInitialization; // 0x10
        public URA.woDigitYearMax<ing.eDeviceAuthorisationStatus> products; // 0x18

        // ── Methods ──
        public void get_allProducts(){} // RVA: 0x7FFD4E3447C0
        public void Initialize(){} // RVA: 0x7FFD54DFABD0 | overloaded x2
        public void Deserialize(){} // RVA: 0x7FFD54DFAC70
        public void FromTextAsset(){} // RVA: 0x7FFD54DFACB0
        public void LoadDefaultCatalog(){} // RVA: 0x7FFD54DFAD10
        public void .ctor(){} // RVA: 0x7FFD54DFAED0
    }

    public class ProductCollection : Object
    {
        public URA.DateTime<string,ing.urrable> set; // 0x10
        public URA.DateTime<string,ing.urrable> all; // 0x18
        public URA.onsDepth<ing.urrable> <set>k__BackingField; // 0x20
        public ing.urrable[] <all>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DCCB30
        public void AddProducts(){} // RVA: 0x7FFD54DCCC00
        public void get_set(){} // RVA: 0x7FFD4E36F0C0
        public void get_all(){} // RVA: 0x7FFD4E36F130
        public void set_all(){} // RVA: 0x7FFD4E342E90
        public void WithID(){} // RVA: 0x7FFD54DCD040
        public void WithStoreSpecificID(){} // RVA: 0x7FFD54DCD0B0
    }

    public class ProductDefinition : Object
    {
        public string id; // 0x10
        public string storeSpecificId; // 0x18
        public ing.t_verification_uri type; // 0x20
        public bool enabled; // 0x24
        public URA.woDigitYearMax<ing.?> payouts; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DCD740 | overloaded x4
        public void get_id(){} // RVA: 0x7FFD4E35C380
        public void set_id(){} // RVA: 0x7FFD4E342E30
        public void get_storeSpecificId(){} // RVA: 0x7FFD4E3447C0
        public void set_storeSpecificId(){} // RVA: 0x7FFD4E3A7E80
        public void get_type(){} // RVA: 0x7FFD4E4FBBE0
        public void set_type(){} // RVA: 0x7FFD4E9FB7A0
        public void get_enabled(){} // RVA: 0x7FFD4E35C7C0
        public void set_enabled(){} // RVA: 0x7FFD4F842FB0
        public void Equals(){} // RVA: 0x7FFD54DCD760
        public void GetHashCode(){} // RVA: 0x7FFD4E9FB750
        public void get_payouts(){} // RVA: 0x7FFD4E36F130
        public void SetPayouts(){} // RVA: 0x7FFD54DCD820
    }

    public class ProductDefinitionExtensions : Object
    {
        // ── Methods ──
        public void DecodeJSON(){} // RVA: 0x7FFD54E038D0
    }

    public class ProductDetailsQueryResponse : Object
    {
        public JapaneseLangName.eConverter<8BCA7B5CC287C51E0E3E<oductDetails>b__5_0.nt,URA.bbrevEraNames<?>>> m_Responses; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFD54DE0100
        public void AddResponse(){} // RVA: 0x7FFD54DE03F0
        public void ProductDetails(){} // RVA: 0x7FFD54DE0660
        public void IsRecoverable(){} // RVA: 0x7FFD54DE0F30 | overloaded x2
        public void GetGoogleBillingResult(){} // RVA: 0x7FFD54DE0C80
        public void .ctor(){} // RVA: 0x7FFD54DE0FA0
    }

    public class ProductDetailsResponseConsolidator : Object
    {
        public int m_NumberReceivedCallbacks; // 0x10
        public ileFullDirectoryInformation<B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.Details> m_OnProductDetailsResponseConsolidated; // 0x18
        public B3ABA9D7C54CD812756C7C5CE8848E6A882B240EB.Details m_Responses; // 0x20
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x28
        public ÌÍÏÏÏ.ÌÎÍÍÏÍÏÎÏÎÏÌÍÏÏÏ m_TelemetryDiagnostics; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE1280
        public void Consolidate(){} // RVA: 0x7FFD54DE1570
    }

    public class ProductDetailsResponseListener : AndroidJavaProxy
    {
        public rectoryInformation<oductDetails>b__5_0.nt,URA.woDigitYearMax<?>> m_OnProductDetailsResponse; // 0x20
        public ÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ.ÏÍÍÍÏÎÎÎÍÍÏÌÌÌÌÎÎÌÎÏ m_Util; // 0x28
        public ÌÍÏÏÏ.ÌÎÍÍÏÍÏÎÏÎÏÌÍÏÏÏ m_TelemetryDiagnostics; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDEE40
        public void onProductDetailsResponse(){} // RVA: 0x7FFD54DDEFD0
    }

    public class ProductMetadata : Object
    {
        public string localizedPriceString; // 0x10
        public string localizedTitle; // 0x18
        public string localizedDescription; // 0x20
        public string isoCurrencyCode; // 0x28
        public ltiple localizedPrice; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310 | overloaded x3
        public void get_localizedPriceString(){} // RVA: 0x7FFD4E35C380
        public void set_localizedPriceString(){} // RVA: 0x7FFD4E342E30
        public void get_localizedTitle(){} // RVA: 0x7FFD4E3447C0
        public void set_localizedTitle(){} // RVA: 0x7FFD4E3A7E80
        public void get_localizedDescription(){} // RVA: 0x7FFD4E36F0C0
        public void set_localizedDescription(){} // RVA: 0x7FFD4E36F0D0
        public void get_isoCurrencyCode(){} // RVA: 0x7FFD4E36F130
        public void set_isoCurrencyCode(){} // RVA: 0x7FFD4E342E90
        public void get_localizedPrice(){} // RVA: 0x7FFD5387FF30
        public void set_localizedPrice(){} // RVA: 0x7FFD5387FF40
    }

    public class ProductPurchaseUpdater : Object
    {
        // ── Methods ──
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFD54DD1E70
    }

    public class PurchaseEventArgs : Object
    {
        public ing.urrable purchasedProduct; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void get_purchasedProduct(){} // RVA: 0x7FFD4E35C380
        public void set_purchasedProduct(){} // RVA: 0x7FFD4E342E30
    }

    public class PurchasingFactory : Object
    {
        public URA.DateTime<?,ra.orPos>b__2> storeName; // 0x10
        public URA.DateTime<?,ing.ÍÏÌÏÏÍÍÌÏÍÍÍÍÍÎÎÍÎÌ> service; // 0x18
        public ra.orPos>b__0 m_Store; // 0x20
        public ra.rPos>b__1 m_CatalogProvider; // 0x28
        public string <storeName>k__BackingField; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DCDBC0
        public void get_storeName(){} // RVA: 0x7FFD4E5F95E0
        public void set_storeName(){} // RVA: 0x7FFD4E36F890
        public void get_service(){} // RVA: 0x7FFD54DCDE30
        public void set_service(){} // RVA: 0x7FFD4E36F0D0
        public void RegisterStore(){} // RVA: 0x7FFD54DCDEA0
        public void RegisterExtension(){} // RVA: 0x7FFD4E2ADC40
        public void RegisterConfiguration(){} // RVA: 0x7FFD4E2ADC40
        public void GetCatalogProvider(){} // RVA: 0x7FFD4E36F130
    }

    public class PurchasingManager : Object
    {
        public ra.orPos>b__0 useTransactionLog; // 0x10
        public ing.ÏÌÏÍ products; // 0x18
        public Identifiers m_Logger; // 0x20
        public ing.? m_TransactionLog; // 0x28
        public string m_StoreName; // 0x30
        public bool m_logUnavailableProducts; // 0x38
        public ing.? m_UnityServicesInitializationChecker; // 0x40
        public ÎÌÍÏÏÌÍÏ m_AdditionalProductsCallback; // 0x48
        public ileFullDirectoryInformation<ing.ÍÌÍÏÎÏÏÏÍÌÎÎÍÏÍÏ> m_AdditionalProductsFailCallback; // 0x50
        public rectoryInformation<ing.ÍÌÍÏÎÏÏÏÍÌÎÎÍÏÍÏ,string> m_AdditionalProductsDetailedFailCallback; // 0x58
        public URA.onsDepth<string> purchasesProcessedInSession; // 0x60
        public bool <useTransactionLog>k__BackingField; // 0x68
        public ing.? <products>k__BackingField; // 0x70
        public bool initialized; // 0x78

        // ── Methods ──
        public void get_useTransactionLog(){} // RVA: 0x7FFD4E409570
        public void set_useTransactionLog(){} // RVA: 0x7FFD4E409580
        public void .ctor(){} // RVA: 0x7FFD54DCDF70
        public void InitiatePurchase(){} // RVA: 0x7FFD54DCE420 | overloaded x3
        public void ConfirmPendingPurchase(){} // RVA: 0x7FFD54DCE6E0
        public void get_products(){} // RVA: 0x7FFD4E409590
        public void set_products(){} // RVA: 0x7FFD4E4095A0
        public void OnPurchaseSucceeded(){} // RVA: 0x7FFD54DCE850
        public void UpdateProductReceiptAndTransactionID(){} // RVA: 0x7FFD54DCE9D0
        public void OnAllPurchasesRetrieved(){} // RVA: 0x7FFD54DCEAC0
        public void OnEntitlementRevoked(){} // RVA: 0x7FFD54DCEC70
        public void HandlePurchaseRetrieved(){} // RVA: 0x7FFD54DCEC80
        public void WasPurchaseAlreadyProcessed(){} // RVA: 0x7FFD54DCED20
        public void ClearProductReceipt(){} // RVA: 0x7FFD54DCED80
        public void OnSetupFailed(){} // RVA: 0x7FFD54DCEE50
        public void OnPurchaseFailed(){} // RVA: 0x7FFD54DCEF10
        public void OnProductsRetrieved(){} // RVA: 0x7FFD54DCF2A0
        public void CreateUnifiedReceipt(){} // RVA: 0x7FFD54DCF750
        public void ProcessPurchaseOnStart(){} // RVA: 0x7FFD54DCF770
        public void ProcessPurchaseIfNew(){} // RVA: 0x7FFD54DCF8F0
        public void HasRecordedTransaction(){} // RVA: 0x7FFD54DCFAA0
        public void CheckForInitialization(){} // RVA: 0x7FFD54DCFAF0
        public void HasAvailableProductsToPurchase(){} // RVA: 0x7FFD54DCFBF0
        public void Initialize(){} // RVA: 0x7FFD54DCFED0
    }

}