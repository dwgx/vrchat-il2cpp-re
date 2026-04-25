// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions : Object
    {
        // ── Methods ──
        public void Enumerate(){} // RVA: 0x7FFD54E08E10 | overloaded x2
    }

    public class GoogleBillingClient : Object
    {
        public 0x66619290 s_AndroidProductClassName;
        public 0x66619290 s_AndroidQueryProductDetailsParamsClassName; // 0x8
        public 0x66619290 s_BillingFlowParamsClass; // 0x10
        public 0x66619290 s_ProductDetailsParamsClass; // 0x18
        public 0x66619290 s_SubscriptionUpdateParamsClass; // 0x20
        public 0x66619290 s_ConsumeParamsClass; // 0x28
        public 0x66619290 s_AcknowledgePurchaseParamsClass; // 0x30
        public 0x66619290 s_BillingClientClass; // 0x38
        public UnityEngine.AndroidJavaObject m_BillingClient; // 0x10
        public string m_ObfuscatedAccountId; // 0x18
        public string m_ObfuscatedProfileId; // 0x20
        public Uniject.IUtil m_Util; // 0x28
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

        // ── Methods ──
        public void GetProductParamsClass(){} // RVA: 0x7FFD54E08E50
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7FFD54E08F60
        public void GetBillingFlowParamClass(){} // RVA: 0x7FFD54E09070
        public void GetProductDetailsParamsClass(){} // RVA: 0x7FFD54E09180
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7FFD54E09290
        public void GetConsumeParamsClass(){} // RVA: 0x7FFD54E093A0
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7FFD54E094B0
        public void GetBillingClientClass(){} // RVA: 0x7FFD54E095C0
        public void .ctor(){} // RVA: 0x7FFD54E096D0
        public void StartConnection(){} // RVA: 0x7FFD54E09BC0
        public void GetConnectionState(){} // RVA: 0x7FFD54E09C90
        public void QueryPurchasesAsync(){} // RVA: 0x7FFD54E09D10
        public void QueryProductDetailsAsync(){} // RVA: 0x7FFD54E09EE0
        public void QueryProductDetailsParams(){} // RVA: 0x7FFD54E0A200
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7FFD54E0A5C0
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7FFD54E0A7A0
        public void LaunchBillingFlow(){} // RVA: 0x7FFD54E0AB90
        public void MakeBillingFlowParams(){} // RVA: 0x7FFD54E0B3E0
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7FFD54E0B8D0
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7FFD54E0BC10
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7FFD54E0BD00
        public void ConsumeAsync(){} // RVA: 0x7FFD54E0BDF0
        public void AcknowledgePurchase(){} // RVA: 0x7FFD54E0C340
    }

    public class GoogleBillingResult : Object
    {
        public 0x665DF3D0 responseCode; // 0x10
        public string debugMessage; // 0x18

        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7FFD4E38E5C0
        public void get_debugMessage(){} // RVA: 0x7FFD4E3447C0
        public void .ctor(){} // RVA: 0x7FFD54E0C8A0
    }

    public class GoogleBillingStrings : Object
    {
        // ── Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x7FFD54E0C9C0
    }

    public class GoogleProductTypeEnum : Object
    {
        // ── Methods ──
        public void InApp(){} // RVA: 0x7FFD54E0CA20
        public void Sub(){} // RVA: 0x7FFD54E0CA60
    }

    public class GooglePurchase : Object
    {
        public bool isAcknowledged; // 0x10
        public int purchaseState; // 0x14
        public System.Collections.Generic.List`1<string> skus; // 0x18
        public string receipt; // 0x20
        public string signature; // 0x28
        public string originalJson; // 0x30
        public string purchaseToken; // 0x38
        public string sku; // 0x40
        public string <obfuscatedAccountId>k__BackingField; // 0x48
        public string <obfuscatedProfileId>k__BackingField; // 0x50

        // ── Methods ──
        public void get_isAcknowledged(){} // RVA: 0x7FFD4E40B5E0
        public void get_purchaseState(){} // RVA: 0x7FFD4E7F5A20
        public void get_skus(){} // RVA: 0x7FFD4E3447C0
        public void get_receipt(){} // RVA: 0x7FFD4E36F130
        public void get_signature(){} // RVA: 0x7FFD4E5F95E0
        public void get_originalJson(){} // RVA: 0x7FFD4E5F0140
        public void get_purchaseToken(){} // RVA: 0x7FFD4E3BE740
        public void get_sku(){} // RVA: 0x7FFD54E0CAA0
        public void .ctor(){} // RVA: 0x7FFD54E0CAE0
        public void IsAcknowledged(){} // RVA: 0x7FFD4E40B5E0
        public void IsPurchased(){} // RVA: 0x7FFD54E0D440
        public void IsPending(){} // RVA: 0x7FFD54E0D460
    }

    public class GooglePurchaseStateEnum : Object
    {
        public System.Nullable`1<int> s_Purchased;
        public System.Nullable`1<int> s_Pending; // 0x8

        // ── Methods ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7FFD54E0D5B0
        public void Purchased(){} // RVA: 0x7FFD54E0D620
        public void Pending(){} // RVA: 0x7FFD54E0D7A0
    }

    public class GooglePurchaseStateEnumProvider : Object
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7FFD54E0D920
        public void Pending(){} // RVA: 0x7FFD54E0D930
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class IGoogleBillingResult
    {
        public <>c<T> responseCode;
        public object debugMessage;

        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7FFD4E079960
        public void get_debugMessage(){} // RVA: 0x7FFD4E078E90
    }

    public class ProductDescriptionQuery : Object
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Purchasing.ProductDefinition> products; // 0x10
        public System.Action`2<System.Collections.Generic.List`1<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived; // 0x18
        public System.Action`2<0x665DF320,0x665DF3D0> onRetrieveProductsFailed; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E420E00
    }

}