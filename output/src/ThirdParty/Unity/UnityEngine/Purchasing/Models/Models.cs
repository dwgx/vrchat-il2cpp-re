// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions : Object
    {
        // ── Methods ──
        public void Enumerate(){} // RVA: 0x7FFAC99E8E10 | overloaded x2
    }

    public class GoogleBillingClient : Object
    {
        public UnityEngine.AndroidJavaClass s_AndroidProductClassName;
        public UnityEngine.AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName; // 0x8
        public UnityEngine.AndroidJavaClass s_BillingFlowParamsClass; // 0x10
        public UnityEngine.AndroidJavaClass s_ProductDetailsParamsClass; // 0x18
        public UnityEngine.AndroidJavaClass s_SubscriptionUpdateParamsClass; // 0x20
        public UnityEngine.AndroidJavaClass s_ConsumeParamsClass; // 0x28
        public UnityEngine.AndroidJavaClass s_AcknowledgePurchaseParamsClass; // 0x30
        public UnityEngine.AndroidJavaClass s_BillingClientClass; // 0x38
        public UnityEngine.AndroidJavaObject m_BillingClient; // 0x10
        public string m_ObfuscatedAccountId; // 0x18
        public string m_ObfuscatedProfileId; // 0x20
        public Uniject.IUtil m_Util; // 0x28
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x30

        // ── Methods ──
        public void GetProductParamsClass(){} // RVA: 0x7FFAC99E8E50
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7FFAC99E8F60
        public void GetBillingFlowParamClass(){} // RVA: 0x7FFAC99E9070
        public void GetProductDetailsParamsClass(){} // RVA: 0x7FFAC99E9180
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7FFAC99E9290
        public void GetConsumeParamsClass(){} // RVA: 0x7FFAC99E93A0
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7FFAC99E94B0
        public void GetBillingClientClass(){} // RVA: 0x7FFAC99E95C0
        public void .ctor(){} // RVA: 0x7FFAC99E96D0
        public void StartConnection(){} // RVA: 0x7FFAC99E9BC0
        public void GetConnectionState(){} // RVA: 0x7FFAC99E9C90
        public void QueryPurchasesAsync(){} // RVA: 0x7FFAC99E9D10
        public void QueryProductDetailsAsync(){} // RVA: 0x7FFAC99E9EE0
        public void QueryProductDetailsParams(){} // RVA: 0x7FFAC99EA200
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7FFAC99EA5C0
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7FFAC99EA7A0
        public void LaunchBillingFlow(){} // RVA: 0x7FFAC99EAB90
        public void MakeBillingFlowParams(){} // RVA: 0x7FFAC99EB3E0
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7FFAC99EB8D0
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7FFAC99EBC10
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7FFAC99EBD00
        public void ConsumeAsync(){} // RVA: 0x7FFAC99EBDF0
        public void AcknowledgePurchase(){} // RVA: 0x7FFAC99EC340
    }

    public class GoogleBillingResult : Object
    {
        public 0x6B27F3D0 responseCode; // 0x10
        public string debugMessage; // 0x18

        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7FFAC2F6E5C0
        public void get_debugMessage(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC99EC8A0
    }

    public class GoogleBillingStrings : Object
    {
        // ── Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x7FFAC99EC9C0
    }

    public class GoogleProductTypeEnum : Object
    {
        // ── Methods ──
        public void InApp(){} // RVA: 0x7FFAC99ECA20
        public void Sub(){} // RVA: 0x7FFAC99ECA60
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
        public void get_isAcknowledged(){} // RVA: 0x7FFAC2FEB5E0
        public void get_purchaseState(){} // RVA: 0x7FFAC33D5A20
        public void get_skus(){} // RVA: 0x7FFAC2F247C0
        public void get_receipt(){} // RVA: 0x7FFAC2F4F130
        public void get_signature(){} // RVA: 0x7FFAC31D95E0
        public void get_originalJson(){} // RVA: 0x7FFAC31D0140
        public void get_purchaseToken(){} // RVA: 0x7FFAC2F9E740
        public void get_sku(){} // RVA: 0x7FFAC99ECAA0
        public void .ctor(){} // RVA: 0x7FFAC99ECAE0
        public void IsAcknowledged(){} // RVA: 0x7FFAC2FEB5E0
        public void IsPurchased(){} // RVA: 0x7FFAC99ED440
        public void IsPending(){} // RVA: 0x7FFAC99ED460
    }

    public class GooglePurchaseStateEnum : Object
    {
        public System.Nullable`1<int> s_Purchased;
        public System.Nullable`1<int> s_Pending; // 0x8

        // ── Methods ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7FFAC99ED5B0
        public void Purchased(){} // RVA: 0x7FFAC99ED620
        public void Pending(){} // RVA: 0x7FFAC99ED7A0
    }

    public class GooglePurchaseStateEnumProvider : Object
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7FFAC99ED920
        public void Pending(){} // RVA: 0x7FFAC99ED930
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IGoogleBillingResult
    {
        public object responseCode;
        public object debugMessage;

        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7FFAC2C59960
        public void get_debugMessage(){} // RVA: 0x7FFAC2C58E90
    }

    public class ProductDescriptionQuery : Object
    {
        public System.Collections.ObjectModel.ReadOnlyCollection`1<UnityEngine.Purchasing.ProductDefinition> products; // 0x10
        public System.Action`2<System.Collections.Generic.List`1<UnityEngine.Purchasing.Extension.ProductDescription>,UnityEngine.Purchasing.Models.IGoogleBillingResult> onProductsReceived; // 0x18
        public System.Action`2<0x6B27F320,0x6B27F3D0> onRetrieveProductsFailed; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
    }

}