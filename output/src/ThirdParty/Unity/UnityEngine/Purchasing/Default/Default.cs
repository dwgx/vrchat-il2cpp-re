// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Default
// Classes: 4
// Methods: 16

namespace ThirdParty.Unity.UnityEngine.Purchasing.Default
{
    public class Factory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87D96440
    }

    public class IWindowsIAP
    {
        // ── Methods ──
        public void BuildDummyProducts(){} // RVA: 0x7FFE80E460A0
        public void Initialize(){} // RVA: 0x7FFE80E460A0
        public void RetrieveProducts(){} // RVA: 0x7FFE80E466C0
        public void Purchase(){} // RVA: 0x7FFE80E460A0
        public void FinaliseTransaction(){} // RVA: 0x7FFE80E460A0
    }

    public class IWindowsIAPCallback
    {
    }

    public class WinProductDescription : Object
    {
        public string _platformSpecificID; // 0x10
        public string _price; // 0x18
        public string _title; // 0x20
        public string _description; // 0x28
        public string _iSOCurrencyCode; // 0x30
        public System.Decimal _priceDecimal; // 0x38
        public string _receipt; // 0x48
        public string _transactionID; // 0x50
        public bool _consumable; // 0x58

        // ── Methods ──
        public void set_platformSpecificID(){} // RVA: 0x7FFE810FCE30
        public void set_price(){} // RVA: 0x7FFE81161E80
        public void set_title(){} // RVA: 0x7FFE811290D0
        public void set_description(){} // RVA: 0x7FFE810FCE90
        public void set_ISOCurrencyCode(){} // RVA: 0x7FFE81129890
        public void set_priceDecimal(){} // RVA: 0x7FFE82D001B0
        public void set_receipt(){} // RVA: 0x7FFE81176740
        public void set_transactionID(){} // RVA: 0x7FFE812534D0
        public void set_consumable(){} // RVA: 0x7FFE819E83C0
        public void .ctor(){} // RVA: 0x7FFE87D961E0
    }

}