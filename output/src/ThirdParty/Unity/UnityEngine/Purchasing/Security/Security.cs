// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Security
// Classes: 4
// Methods: 11

namespace ThirdParty.Unity.UnityEngine.Purchasing.Security
{
    public class AppleInAppPurchaseReceipt : Object
    {
        public string _productID; // 0x10
        public string _transactionID; // 0x18
        public string _originalTransactionIdentifier; // 0x20
        public System.DateTime _purchaseDate; // 0x28
        public System.DateTime _subscriptionExpirationDate; // 0x30
        public System.DateTime _cancellationDate; // 0x38
        public int _isFreeTrial; // 0x40
        public int _productType; // 0x44
        public int _isIntroductoryPricePeriod; // 0x48

        // ── Methods ──
        public void get_productID(){} // RVA: 0x7FFE81116380
        public void get_transactionID(){} // RVA: 0x7FFE810FE7C0
        public void get_originalTransactionIdentifier(){} // RVA: 0x7FFE811290C0
        public void get_purchaseDate(){} // RVA: 0x7FFE81129130
        public void get_subscriptionExpirationDate(){} // RVA: 0x7FFE8144E200
        public void get_cancellationDate(){} // RVA: 0x7FFE8143BA80
        public void get_isFreeTrial(){} // RVA: 0x7FFE8119C080
        public void get_productType(){} // RVA: 0x7FFE8119C0A0
        public void get_isIntroductoryPricePeriod(){} // RVA: 0x7FFE8119C0C0
    }

    public class AppleReceipt : Object
    {
    }

    public class AppleReceiptParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7FFE87D5DA30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IAPSecurityException : Exception
    {
    }

}