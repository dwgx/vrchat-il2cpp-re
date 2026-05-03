// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ConfigurationBuilder : Object
    {
        public bool _useCatalogProvider; // 0x10
        public bool _logUnavailableProducts; // 0x11
        public System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> _products; // 0x18
        public UnityEngine.Purchasing.PurchasingFactory _factory; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D53BE0
        public void get_useCatalogProvider(){} // RVA: 0x7FFE811C55E0
        public void get_logUnavailableProducts(){} // RVA: 0x7FFE81346E30
        public void get_products(){} // RVA: 0x7FFE810FE7C0
        public void get_factory(){} // RVA: 0x7FFE811290C0
        public void Instance(){} // RVA: 0x7FFE87D53D10
        public void AddProduct(){} // RVA: 0x7FFE87D540E0 | overloaded x2
    }

    public class CoreServicesEnvironmentSubject : Object
    {
        // ── Methods ──
        public void Instance(){} // RVA: 0x7FFE87D54270
        public void SubscribeToUpdatesAndGetCurrent(){} // RVA: 0x7FFE87D543F0
        public void UpdateCurrentEnvironment(){} // RVA: 0x7FFE87D54520
        public void NotifyObservers(){} // RVA: 0x7FFE87D54580
        public void IsDefaultLiveEnvironment(){} // RVA: 0x7FFE87D54780
        public void .ctor(){} // RVA: 0x7FFE87D54800
    }

}