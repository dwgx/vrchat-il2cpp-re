// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Default
// Classes: 3
// Methods: 11

namespace ThirdParty.Unity.UnityEngine.Purchasing.Default
{
    public class Factory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54E0DBA0
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
        public void set_platformSpecificID(){} // RVA: 0x7FFD4E342E30
        public void set_price(){} // RVA: 0x7FFD4E3A7E80
        public void set_title(){} // RVA: 0x7FFD4E36F0D0
        public void set_description(){} // RVA: 0x7FFD4E342E90
        public void set_ISOCurrencyCode(){} // RVA: 0x7FFD4E36F890
        public void set_priceDecimal(){} // RVA: 0x7FFD4FEB7FB0
        public void set_receipt(){} // RVA: 0x7FFD4E3BC740
        public void set_transactionID(){} // RVA: 0x7FFD4E4994D0
        public void set_consumable(){} // RVA: 0x7FFD4ECB2770
        public void .ctor(){} // RVA: 0x7FFD54E0D940
    }

}