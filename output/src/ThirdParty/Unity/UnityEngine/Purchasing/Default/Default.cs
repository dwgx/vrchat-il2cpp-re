// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Default
// Classes: 4
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.Purchasing.Default
{
    public class Factory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC99EDBA0
    }

    public class IWindowsIAP
    {
        // ── Methods ──
        public void BuildDummyProducts(){} // RVA: 0x7FFAC2C70A40
        public void Initialize(){} // RVA: 0x7FFAC2C70A40
        public void RetrieveProducts(){} // RVA: 0x7FFAC2C71060
        public void Purchase(){} // RVA: 0x7FFAC2C70A40
        public void FinaliseTransaction(){} // RVA: 0x7FFAC2C70A40
    }

    public class IWindowsIAPCallback
    {
    }

    public class WinProductDescription : Object
    {
        public string platformSpecificID; // 0x10
        public string price; // 0x18
        public string title; // 0x20
        public string description; // 0x28
        public string ISOCurrencyCode; // 0x30
        public System.Decimal priceDecimal; // 0x38
        public string receipt; // 0x48
        public string transactionID; // 0x50
        public bool consumable; // 0x58

        // ── Methods ──
        public void set_platformSpecificID(){} // RVA: 0x7FFAC2F22E30
        public void set_price(){} // RVA: 0x7FFAC2F87E80
        public void set_title(){} // RVA: 0x7FFAC2F4F0D0
        public void set_description(){} // RVA: 0x7FFAC2F22E90
        public void set_ISOCurrencyCode(){} // RVA: 0x7FFAC2F4F890
        public void set_priceDecimal(){} // RVA: 0x7FFAC4A97FB0
        public void set_receipt(){} // RVA: 0x7FFAC2F9C740
        public void set_transactionID(){} // RVA: 0x7FFAC30794D0
        public void set_consumable(){} // RVA: 0x7FFAC3892770
        public void .ctor(){} // RVA: 0x7FFAC99ED940
    }

}