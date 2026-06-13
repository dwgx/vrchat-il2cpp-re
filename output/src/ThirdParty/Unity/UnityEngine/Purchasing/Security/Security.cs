// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Security
// Classes: 4
// Methods: 11

namespace ThirdParty.Unity.UnityEngine.Purchasing.Security
{
    public class AppleInAppPurchaseReceipt
    {
        public string <productID>k__BackingField; // 0x10
        public string <transactionID>k__BackingField; // 0x18
        public string <originalTransactionIdentifier>k__BackingField; // 0x20
        public System.DateTime <purchaseDate>k__BackingField; // 0x28
        public System.DateTime <subscriptionExpirationDate>k__BackingField; // 0x30
        public System.DateTime <cancellationDate>k__BackingField; // 0x38
        public int <isFreeTrial>k__BackingField; // 0x40
        public int <productType>k__BackingField; // 0x44
        public int <isIntroductoryPricePeriod>k__BackingField; // 0x48

        // ── Methods ──
        public void get_productID(){} // RVA: 0x2F8380
        public void get_transactionID(){} // RVA: 0x2E07C0
        public void get_originalTransactionIdentifier(){} // RVA: 0x30B0C0
        public void get_purchaseDate(){} // RVA: 0x30B130
        public void get_subscriptionExpirationDate(){} // RVA: 0x6374D0
        public void get_cancellationDate(){} // RVA: 0x4976A0
        public void get_isFreeTrial(){} // RVA: 0x37E080
        public void get_productType(){} // RVA: 0x37E0A0
        public void get_isIntroductoryPricePeriod(){} // RVA: 0x37E0C0
    }

    public class AppleReceipt
    {
    }

    public class AppleReceiptParser
    {
        // ── Methods ──
        public void Parse(){} // RVA: 0x721D890
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IAPSecurityException
    {
    }

}