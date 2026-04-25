// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Security
// Classes: 4
// Methods: 11

namespace ThirdParty.Unity.UnityEngine.Purchasing.Security
{
    public class AppleInAppPurchaseReceipt : Object
    {
        public string productID; // 0x10
        public string transactionID; // 0x18
        public string originalTransactionIdentifier; // 0x20
        public System.DateTime purchaseDate; // 0x28
        public System.DateTime subscriptionExpirationDate; // 0x30
        public System.DateTime cancellationDate; // 0x38
        public int isFreeTrial; // 0x40
        public int productType; // 0x44
        public int isIntroductoryPricePeriod; // 0x48

        // ── Methods ──
        public void get_productID(){} // RVA: 0x7FFAC2F3C380
        public void get_transactionID(){} // RVA: 0x7FFAC2F247C0
        public void get_originalTransactionIdentifier(){} // RVA: 0x7FFAC2F4F0C0
        public void get_purchaseDate(){} // RVA: 0x7FFAC2F4F130
        public void get_subscriptionExpirationDate(){} // RVA: 0x7FFAC31D95E0
        public void get_cancellationDate(){} // RVA: 0x7FFAC31D0140
        public void get_isFreeTrial(){} // RVA: 0x7FFAC2FC2080
        public void get_productType(){} // RVA: 0x7FFAC2FC20A0
        public void get_isIntroductoryPricePeriod(){} // RVA: 0x7FFAC2FC20C0
    }

    public class AppleReceipt : Object
    {
        public UnityEngine.Purchasing.Security.AppleInAppPurchaseReceipt[] inAppPurchaseReceipts; // 0x10
    }

    public class AppleReceiptParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFAC99B5190
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IAPSecurityException : Exception
    {
    }

}