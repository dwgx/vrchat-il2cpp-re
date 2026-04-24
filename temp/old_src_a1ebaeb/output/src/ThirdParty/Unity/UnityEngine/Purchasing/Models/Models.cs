// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions : Object
    {
        // ── Original Methods ──
        public void Enumerate(){} // RVA: 0x7ffaaf40ad70
        public void Enumerate(){} // RVA: 0x7ffaaf40ad70
    }

    public class GoogleBillingClient : Object
    {
        public object s_BillingFlowParamsClass; // 0x33C46D60
        public object s_ConsumeParamsClass; // 0x33C46D60
        public object m_BillingClient; // 0x33C46D60
        public object m_Util; // 0x33C46D60
        public object (00; // 0x84FD9330
        public object get_debugMessage; // 0xB41F4950

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf40b630
        public void StartConnection(){} // RVA: 0x7ffaaf40bb20
        public void QueryPurchasesAsync(){} // RVA: 0x7ffaaf40bc70
        public void QueryProductDetailsAsync(){} // RVA: 0x7ffaaf40be40
        public void QueryProductDetailsParams(){} // RVA: 0x7ffaaf40c160
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7ffaaf40c520
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7ffaaf40c700
        public void LaunchBillingFlow(){} // RVA: 0x7ffaaf40caf0
        public void MakeBillingFlowParams(){} // RVA: 0x7ffaaf40d340
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7ffaaf40d830
        public void ConsumeAsync(){} // RVA: 0x7ffaaf40dd50
        public void AcknowledgePurchase(){} // RVA: 0x7ffaaf40e2a0
        // ── Binary Analysis Named ──
        public void GetProductParamsClass(){} // RVA: 0x7ffaaf40adb0
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7ffaaf40aec0
        public void GetBillingFlowParamClass(){} // RVA: 0x7ffaaf40afd0
        public void GetProductDetailsParamsClass(){} // RVA: 0x7ffaaf40b0e0
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7ffaaf40b1f0
        public void GetConsumeParamsClass(){} // RVA: 0x7ffaaf40b300
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7ffaaf40b410
        public void GetBillingClientClass(){} // RVA: 0x7ffaaf40b520
        public void GetConnectionState(){} // RVA: 0x7ffaaf40bbf0
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7ffaaf40db70
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7ffaaf40dc60
    }

    public class GoogleBillingResult : Object
    {
        // ── Original Methods ──
        public void get_responseCode(){} // RVA: 0x7ffaa897f5c0
        public void get_debugMessage(){} // RVA: 0x7ffaa89357c0
        public void .ctor(){} // RVA: 0x7ffaaf40e800
    }

    public class GoogleBillingStrings : Object
    {
        // ── Original Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x7ffaaf40e920
    }

    public class GoogleProductTypeEnum : Object
    {
        // ── Original Methods ──
        public void InApp(){} // RVA: 0x7ffaaf40e980
        public void Sub(){} // RVA: 0x7ffaaf40e9c0
    }

    public class GooglePurchase : Object
    {
        public object _skus; // 0x33C46640, was: <skus>k__BackingField
        public object _signature; // 0x33C46640, was: <signature>k__BackingField
        public object _obfuscatedAccountId; // 0x33C46640, was: <obfuscatedAccountId>k__Backin

        // ── Original Methods ──
        public void get_isAcknowledged(){} // RVA: 0x7ffaa89fc5e0
        public void get_purchaseState(){} // RVA: 0x7ffaa8e046c0
        public void get_skus(){} // RVA: 0x7ffaa89357c0
        public void get_receipt(){} // RVA: 0x7ffaa8960130
        public void get_signature(){} // RVA: 0x7ffaa8bfcc80
        public void get_originalJson(){} // RVA: 0x7ffaa8bf45b0
        public void get_purchaseToken(){} // RVA: 0x7ffaa89af740
        public void get_sku(){} // RVA: 0x7ffaaf40ea00
        public void .ctor(){} // RVA: 0x7ffaaf40ea40
        public void IsAcknowledged(){} // RVA: 0x7ffaa89fc5e0
        public void IsPurchased(){} // RVA: 0x7ffaaf40f3a0
        public void IsPending(){} // RVA: 0x7ffaaf40f3c0
    }

    public class GooglePurchaseStateEnum : Object
    {
        // ── Original Methods ──
        public void Purchased(){} // RVA: 0x7ffaaf40f580
        public void Pending(){} // RVA: 0x7ffaaf40f700
        // ── Binary Analysis Named ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7ffaaf40f510
    }

    public class GooglePurchaseStateEnumProvider : Object
    {
        // ── Original Methods ──
        public void Purchased(){} // RVA: 0x7ffaaf40f880
        public void Pending(){} // RVA: 0x7ffaaf40f890
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class IGoogleBillingResult
    {
        // ── Original Methods ──
        public void get_responseCode(){} // RVA: 0x7ffaa8649ca0
        public void get_debugMessage(){} // RVA: 0x7ffaa86491d0
    }

    public class ProductDescriptionQuery : Object
    {
        public object onRetrieveProductsFailed; // 0x33CA9430

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a11e00
    }

}