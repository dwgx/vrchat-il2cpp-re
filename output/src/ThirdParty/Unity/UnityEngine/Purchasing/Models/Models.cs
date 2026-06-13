// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions
    {
        // ── Methods ──
        public void Enumerate(){} // RVA: 0x7251510 | overloaded x2
    }

    public class GoogleBillingClient
    {
        // ── Methods ──
        public void GetProductParamsClass(){} // RVA: 0x7251550
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7251660
        public void GetBillingFlowParamClass(){} // RVA: 0x7251770
        public void GetProductDetailsParamsClass(){} // RVA: 0x7251880
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7251990
        public void GetConsumeParamsClass(){} // RVA: 0x7251AA0
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7251BB0
        public void GetBillingClientClass(){} // RVA: 0x7251CC0
        public void .ctor(){} // RVA: 0x7251DD0
        public void StartConnection(){} // RVA: 0x72522C0
        public void GetConnectionState(){} // RVA: 0x7252390
        public void QueryPurchasesAsync(){} // RVA: 0x7252410
        public void QueryProductDetailsAsync(){} // RVA: 0x72525E0
        public void QueryProductDetailsParams(){} // RVA: 0x7252900
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7252CC0
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7252EA0
        public void LaunchBillingFlow(){} // RVA: 0x7253290
        public void MakeBillingFlowParams(){} // RVA: 0x7253AE0
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7253FD0
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7254310
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7254400
        public void ConsumeAsync(){} // RVA: 0x72544F0
        public void AcknowledgePurchase(){} // RVA: 0x7254A40
    }

    public class GoogleBillingResult
    {
        public 0x659A0D30 <responseCode>k__BackingField; // 0x10
        public string <debugMessage>k__BackingField; // 0x18

        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x32A5C0
        public void get_debugMessage(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0x7254FA0
    }

    public class GoogleBillingStrings
    {
        // ── Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x72550C0
    }

    public class GoogleProductTypeEnum
    {
        // ── Methods ──
        public void InApp(){} // RVA: 0x7255120
        public void Sub(){} // RVA: 0x7255160
    }

    public class GooglePurchase
    {
        public bool <isAcknowledged>k__BackingField; // 0x10
        public int <purchaseState>k__BackingField; // 0x14
        public System.Collections.Generic.List`1<string> <skus>k__BackingField; // 0x18
        public string <orderId>k__BackingField; // 0x20
        public string <receipt>k__BackingField; // 0x28
        public string <signature>k__BackingField; // 0x30
        public string <originalJson>k__BackingField; // 0x38
        public string <purchaseToken>k__BackingField; // 0x40

        // ── Methods ──
        public void get_isAcknowledged(){} // RVA: 0x3A75E0
        public void get_purchaseState(){} // RVA: 0x8ABED0
        public void get_skus(){} // RVA: 0x2E07C0
        public void get_receipt(){} // RVA: 0x30B130
        public void get_signature(){} // RVA: 0x6374D0
        public void get_originalJson(){} // RVA: 0x4976A0
        public void get_purchaseToken(){} // RVA: 0x35A740
        public void get_sku(){} // RVA: 0x72551A0
        public void .ctor(){} // RVA: 0x72551E0
        public void IsAcknowledged(){} // RVA: 0x3A75E0
        public void IsPurchased(){} // RVA: 0x7255B40
        public void IsPending(){} // RVA: 0x7255B60
    }

    public class GooglePurchaseStateEnum
    {
        // ── Methods ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7255CB0
        public void Purchased(){} // RVA: 0x7255D20
        public void Pending(){} // RVA: 0x7255EA0
    }

    public class GooglePurchaseStateEnumProvider
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7256020
        public void Pending(){} // RVA: 0x7256030
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IGoogleBillingResult
    {
        // ── Methods ──
        public void get_responseCode(){} // RVA: 0xD840
        public void get_debugMessage(){} // RVA: 0xCD60
    }

    public class ProductDescriptionQuery
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00
    }

}