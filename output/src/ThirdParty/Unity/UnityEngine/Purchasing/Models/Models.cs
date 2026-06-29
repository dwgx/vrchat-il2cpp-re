// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 51

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions : Object
    {
        // ── Methods ──
        public void Enumerate(){} // RVA: 0x7DA3F70
    }

    public class GoogleBillingClient : Object
    {
        // ── Methods ──
        public void GetProductParamsClass(){} // RVA: 0x7DA3FB0
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7DA40C0
        public void GetBillingFlowParamClass(){} // RVA: 0x7DA41D0
        public void GetProductDetailsParamsClass(){} // RVA: 0x7DA42E0
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7DA43F0
        public void GetConsumeParamsClass(){} // RVA: 0x7DA4500
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7DA4610
        public void GetBillingClientClass(){} // RVA: 0x7DA4720
        public void .ctor(){} // RVA: 0x7DA4830
        public void StartConnection(){} // RVA: 0x7DA4D30
        public void GetConnectionState(){} // RVA: 0x7DA4E00
        public void QueryPurchasesAsync(){} // RVA: 0x7DA4E80
        public void QueryProductDetailsAsync(){} // RVA: 0x7DA5050
        public void QueryProductDetailsParams(){} // RVA: 0x7DA5370
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7DA5740
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7DA5920
        public void LaunchBillingFlow(){} // RVA: 0x7DA5D10
        public void MakeBillingFlowParams(){} // RVA: 0x7DA6570
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7DA6A60
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7DA6D90
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7DA6E80
        public void ConsumeAsync(){} // RVA: 0x7DA6F70
        public void AcknowledgePurchase(){} // RVA: 0x7DA74C0
    }

    public class GoogleBillingResult : Object
    {
        // ── Methods ──
        public void get_responseCode(){} // RVA: 0xB8F8F0
        public void get_debugMessage(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x7DA7A20
    }

    public class GoogleBillingStrings : Object
    {
        // ── Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x7DA7B40
    }

    public class GoogleProductTypeEnum : Object
    {
        // ── Methods ──
        public void InApp(){} // RVA: 0x7DA7BA0
        public void Sub(){} // RVA: 0x7DA7BE0
    }

    public class GooglePurchase : Object
    {
        // ── Methods ──
        public void get_isAcknowledged(){} // RVA: 0xC120A0
        public void get_purchaseState(){} // RVA: 0x116A650
        public void get_skus(){} // RVA: 0xB465B0
        public void get_receipt(){} // RVA: 0xB70160
        public void get_signature(){} // RVA: 0xD33E60
        public void get_originalJson(){} // RVA: 0xD05CA0
        public void get_purchaseToken(){} // RVA: 0xBC1B30
        public void get_sku(){} // RVA: 0x7DA7C20
        public void .ctor(){} // RVA: 0x7DA7C60
        public void IsAcknowledged(){} // RVA: 0xC120A0
        public void IsPurchased(){} // RVA: 0x7DA85C0
        public void IsPending(){} // RVA: 0x7DA85E0
    }

    public class GooglePurchaseStateEnum : Object
    {
        // ── Methods ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7DA8720
        public void Purchased(){} // RVA: 0x7DA8790
        public void Pending(){} // RVA: 0x7DA8910
    }

    public class GooglePurchaseStateEnumProvider : Object
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7DA8A90
        public void Pending(){} // RVA: 0x7DA8AA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class IGoogleBillingResult
    {
        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x87C130
        public void get_debugMessage(){} // RVA: 0x87C0A0
    }

    public class ProductDescriptionQuery : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
    }

}