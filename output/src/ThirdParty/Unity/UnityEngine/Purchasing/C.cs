// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ConfigurationBuilder
    {
        public bool <useCatalogProvider>k__BackingField; // 0x10
        public bool <logUnavailableProducts>k__BackingField; // 0x11
        public System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> <products>k__BackingField; // 0x18
        public UnityEngine.Purchasing.PurchasingFactory <factory>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7213A40
        public void get_useCatalogProvider(){} // RVA: 0x3A75E0
        public void get_logUnavailableProducts(){} // RVA: 0x543460
        public void get_products(){} // RVA: 0x2E07C0
        public void get_factory(){} // RVA: 0x30B0C0
        public void Instance(){} // RVA: 0x7213B70
        public void AddProduct(){} // RVA: 0x7213F40 | overloaded x2
    }

    public class CoreServicesEnvironmentSubject
    {
        // ── Methods ──
        public void Instance(){} // RVA: 0x72140D0
        public void SubscribeToUpdatesAndGetCurrent(){} // RVA: 0x7214250
        public void UpdateCurrentEnvironment(){} // RVA: 0x7214380
        public void NotifyObservers(){} // RVA: 0x72143E0
        public void IsDefaultLiveEnvironment(){} // RVA: 0x72145E0
        public void .ctor(){} // RVA: 0x7214660
    }

}