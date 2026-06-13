// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Default
// Classes: 4
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.Purchasing.Default
{
    public class Factory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x72562A0
    }

    public class IWindowsIAP
    {
        // ── Methods ──
        public void BuildDummyProducts(){} // RVA: 0x24B10
        public void Initialize(){} // RVA: 0x24B10
        public void RetrieveProducts(){} // RVA: 0x25130
        public void Purchase(){} // RVA: 0x24B10
        public void FinaliseTransaction(){} // RVA: 0x24B10
    }

    public class IWindowsIAPCallback
    {
    }

    public class WinProductDescription
    {
        public string <platformSpecificID>k__BackingField; // 0x10
        public string <price>k__BackingField; // 0x18
        public string <title>k__BackingField; // 0x20
        public string <description>k__BackingField; // 0x28
        public string <ISOCurrencyCode>k__BackingField; // 0x30
        public System.Decimal <priceDecimal>k__BackingField; // 0x38
        public string <receipt>k__BackingField; // 0x48
        public string <transactionID>k__BackingField; // 0x50
        public bool <consumable>k__BackingField; // 0x58

        // ── Methods ──
        public void set_platformSpecificID(){} // RVA: 0x2DEE30
        public void set_price(){} // RVA: 0x343E80
        public void set_title(){} // RVA: 0x30B0D0
        public void set_description(){} // RVA: 0x2DEE90
        public void set_ISOCurrencyCode(){} // RVA: 0x30B890
        public void set_priceDecimal(){} // RVA: 0x1F74CD0
        public void set_receipt(){} // RVA: 0x358740
        public void set_transactionID(){} // RVA: 0x4354D0
        public void set_consumable(){} // RVA: 0xC5F680
        public void .ctor(){} // RVA: 0x7256040
    }

}