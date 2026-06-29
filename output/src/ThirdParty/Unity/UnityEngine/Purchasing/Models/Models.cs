// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Models
// Classes: 10
// Methods: 52

namespace ThirdParty.Unity.UnityEngine.Purchasing.Models
{
    public class AndroidJavaObjectExtensions : Object
    {
        // ── Methods ──
        public void Enumerate(){} // RVA: 0x7AF030F90
    }

    public class GoogleBillingClient : Object
    {
        // ── Methods ──
        public void GetProductParamsClass(){} // RVA: 0x7AF030FD0
        public void GetQueryProductDetailsParamsParamsClass(){} // RVA: 0x7AF0310E0
        public void GetBillingFlowParamClass(){} // RVA: 0x7AF0311F0
        public void GetProductDetailsParamsClass(){} // RVA: 0x7AF031300
        public void GetSubscriptionUpdateParamClass(){} // RVA: 0x7AF031410
        public void GetConsumeParamsClass(){} // RVA: 0x7AF031520
        public void GetAcknowledgePurchaseParamsClass(){} // RVA: 0x7AF031630
        public void GetBillingClientClass(){} // RVA: 0x7AF031740
        public void .ctor(){} // RVA: 0x7AF031850
        public void StartConnection(){} // RVA: 0x7AF031D50
        public void GetConnectionState(){} // RVA: 0x7AF031E20
        public void QueryPurchasesAsync(){} // RVA: 0x7AF031EA0
        public void QueryProductDetailsAsync(){} // RVA: 0x7AF032070
        public void QueryProductDetailsParams(){} // RVA: 0x7AF032390
        public void QueryProductDetailsParamsProductList(){} // RVA: 0x7AF032760
        public void QueryProductDetailsParamsProduct(){} // RVA: 0x7AF032940
        public void LaunchBillingFlow(){} // RVA: 0x7AF032D30
        public void MakeBillingFlowParams(){} // RVA: 0x7AF033590
        public void BuildSubscriptionUpdateParams(){} // RVA: 0x7AF033A80
        public void SetObfuscatedProfileIdIfNeeded(){} // RVA: 0x7AF033DC0
        public void SetObfuscatedAccountIdIfNeeded(){} // RVA: 0x7AF033EB0
        public void ConsumeAsync(){} // RVA: 0x7AF033FA0
        public void AcknowledgePurchase(){} // RVA: 0x7AF0344F0
    }

    public class GoogleBillingResult : Object
    {
        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7A8124910
        public void get_debugMessage(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7AF034A50
    }

    public class GoogleBillingStrings : Object
    {
        // ── Methods ──
        public void getWarningMessageMoreThanOneSkuFound(){} // RVA: 0x7AF034B70
    }

    public class GoogleProductTypeEnum : Object
    {
        // ── Methods ──
        public void InApp(){} // RVA: 0x7AF034BD0
        public void Sub(){} // RVA: 0x7AF034C10
    }

    public class GooglePurchase : Object
    {
        // ── Methods ──
        public void get_isAcknowledged(){} // RVA: 0x7A81A2200
        public void get_purchaseState(){} // RVA: 0x7A8668BC0
        public void get_skus(){} // RVA: 0x7A80DA7B0
        public void get_receipt(){} // RVA: 0x7A8105330
        public void get_signature(){} // RVA: 0x7A83F69F0
        public void get_originalJson(){} // RVA: 0x7A8292C30
        public void get_purchaseToken(){} // RVA: 0x7A8154D80
        public void get_sku(){} // RVA: 0x7AF034C50
        public void .ctor(){} // RVA: 0x7AF034C90
        public void IsAcknowledged(){} // RVA: 0x7A81A2200
        public void IsPurchased(){} // RVA: 0x7AF0355F0
        public void IsPending(){} // RVA: 0x7AF035610
    }

    public class GooglePurchaseStateEnum : Object
    {
        // ── Methods ──
        public void GetPurchaseStateJavaObject(){} // RVA: 0x7AF035750
        public void Purchased(){} // RVA: 0x7AF0357C0
        public void Pending(){} // RVA: 0x7AF035940
    }

    public class GooglePurchaseStateEnumProvider : Object
    {
        // ── Methods ──
        public void Purchased(){} // RVA: 0x7AF035AC0
        public void Pending(){} // RVA: 0x7AF035AD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IGoogleBillingResult
    {
        // ── Methods ──
        public void get_responseCode(){} // RVA: 0x7A7E00710
        public void get_debugMessage(){} // RVA: 0x7A7E00680
    }

    public class ProductDescriptionQuery : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void products(){} // RVA: 0x7B2E35E60
    }

}