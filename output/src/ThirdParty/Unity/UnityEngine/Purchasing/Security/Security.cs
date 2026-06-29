// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Security
// Classes: 2
// Methods: 11

namespace ThirdParty.Unity.UnityEngine.Purchasing.Security
{
    public class AppleInAppPurchaseReceipt : Object
    {
        // ── Methods ──
        public void get_productID(){} // RVA: 0x7A80F2570
        public void get_transactionID(){} // RVA: 0x7A80DA7B0
        public void get_originalTransactionIdentifier(){} // RVA: 0x7A81052C0
        public void get_purchaseDate(){} // RVA: 0x7A8105330
        public void get_subscriptionExpirationDate(){} // RVA: 0x7A83F69F0
        public void get_cancellationDate(){} // RVA: 0x7A8292C30
        public void get_isFreeTrial(){} // RVA: 0x7A8178B30
        public void get_productType(){} // RVA: 0x7A8178B50
        public void get_isIntroductoryPricePeriod(){} // RVA: 0x7A8178B70
    }

    public class AppleReceiptParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7AEFFCD20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}