// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Security
// Classes: 2
// Methods: 11

namespace ThirdParty.Unity.UnityEngine.Purchasing.Security
{
    public class AppleInAppPurchaseReceipt : Object
    {
        public object _productID;
        public object _transactionID;
        public object _originalTransactionIdentifier;
        public object _purchaseDate;
        public object _subscriptionExpirationDate;
        public object _cancellationDate;
        public object _isFreeTrial;
        public object _productType;
        public object _isIntroductoryPricePeriod;

        // ── Methods ──
        public void get_productID(){} // RVA: 0xB5DBF0
        public void get_transactionID(){} // RVA: 0xB465B0
        public void get_originalTransactionIdentifier(){} // RVA: 0xB700F0
        public void get_purchaseDate(){} // RVA: 0xB70160
        public void get_subscriptionExpirationDate(){} // RVA: 0xD33E60
        public void get_cancellationDate(){} // RVA: 0xD05CA0
        public void get_isFreeTrial(){} // RVA: 0xBE5850
        public void get_productType(){} // RVA: 0xBE5870
        public void get_isIntroductoryPricePeriod(){} // RVA: 0xBE5890
    }

    public class AppleReceiptParser : Object
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x7D70410
        public void .ctor(){} // RVA: 0xB43310
    }

}