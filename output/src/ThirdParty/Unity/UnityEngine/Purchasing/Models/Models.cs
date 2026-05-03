// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions : Object
    {
        // ── Methods ──
        public void Enumerate(){} // RVA: 0x7FFE87D916B0 | overloaded x2
    }

    public class GoogleBillingClient : Object
    {
        // ── Methods ──
        public void GetProductParamsClass(){} // RVA: 0x7FFE87D916F0
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7FFE87D91800
        public void GetBillingFlowParamClass(){} // RVA: 0x7FFE87D91910
        public void GetProductDetailsParamsClass(){} // RVA: 0x7FFE87D91A20
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7FFE87D91B30
        public void GetConsumeParamsClass(){} // RVA: 0x7FFE87D91C40
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7FFE87D91D50
        public void GetBillingClientClass(){} // RVA: 0x7FFE87D91E60
        public void .ctor(){} // RVA: 0x7FFE87D91F70
        public void StartConnection(){} // RVA: 0x7FFE87D92460
        public void GetConnectionState(){} // RVA: 0x7FFE87D92530
        public void QueryPurchasesAsync(){} // RVA: 0x7FFE87D925B0
        public void QueryProductDetailsAsync(){} // RVA: 0x7FFE87D92780
        public void QueryProductDetailsParams(){} // RVA: 0x7FFE87D92AA0
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7FFE87D92E60
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7FFE87D93040
        public void LaunchBillingFlow(){} // RVA: 0x7FFE87D93430
        public void MakeBillingFlowParams(){} // RVA: 0x7FFE87D93C80
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7FFE87D94170
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7FFE87D944B0
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7FFE87D945A0
        public void ConsumeAsync(){} // RVA: 0x7FFE87D94690
        public void AcknowledgePurchase(){} // RVA: 0x7FFE87D94BE0
    }

    public class GoogleBillingResult : Object
    {
        public 0x666791BC _responseCode; // 0x10
        public string _debugMessage; // 0x18

        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7FFE811485C0
        public void get_debugMessage(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE87D95140
    }

    public class GoogleBillingStrings : Object
    {
        // ── Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x7FFE87D95260
    }

    public class GoogleProductTypeEnum : Object
    {
        // ── Methods ──
        public void InApp(){} // RVA: 0x7FFE87D952C0
        public void Sub(){} // RVA: 0x7FFE87D95300
    }

    public class GooglePurchase : Object
    {
        public bool _isAcknowledged; // 0x10
        public int _purchaseState; // 0x14
        public System.Collections.Generic.List`1<string> _skus; // 0x18
        public string _orderId; // 0x20
        public string _receipt; // 0x28
        public string _signature; // 0x30
        public string _originalJson; // 0x38
        public string _purchaseToken; // 0x40

        // ── Methods ──
        public void get_isAcknowledged(){} // RVA: 0x7FFE811C55E0
        public void get_purchaseState(){} // RVA: 0x7FFE8164B230
        public void get_skus(){} // RVA: 0x7FFE810FE7C0
        public void get_receipt(){} // RVA: 0x7FFE81129130
        public void get_signature(){} // RVA: 0x7FFE8144E200
        public void get_originalJson(){} // RVA: 0x7FFE8143BA80
        public void get_purchaseToken(){} // RVA: 0x7FFE81178740
        public void get_sku(){} // RVA: 0x7FFE87D95340
        public void .ctor(){} // RVA: 0x7FFE87D95380
        public void IsAcknowledged(){} // RVA: 0x7FFE811C55E0
        public void IsPurchased(){} // RVA: 0x7FFE87D95CE0
        public void IsPending(){} // RVA: 0x7FFE87D95D00
    }

    public class GooglePurchaseStateEnum : Object
    {
        // ── Methods ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7FFE87D95E50
        public void Purchased(){} // RVA: 0x7FFE87D95EC0
        public void Pending(){} // RVA: 0x7FFE87D96040
    }

    public class GooglePurchaseStateEnumProvider : Object
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7FFE87D961C0
        public void Pending(){} // RVA: 0x7FFE87D961D0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IGoogleBillingResult
    {
        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7FFE80E2EDB0
        public void get_debugMessage(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ProductDescriptionQuery : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
    }

}