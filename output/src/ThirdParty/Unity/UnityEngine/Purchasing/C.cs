// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 2
// Methods: 14

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ConfigurationBuilder : Object
    {
        public bool useCatalogProvider; // 0x10
        public bool logUnavailableProducts; // 0x11
        public System.Collections.Generic.HashSet`1<UnityEngine.Purchasing.ProductDefinition> products; // 0x18
        public UnityEngine.Purchasing.PurchasingFactory factory; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99AB340
        public void get_useCatalogProvider(){} // RVA: 0x7FFAC2FEB5E0
        public void get_logUnavailableProducts(){} // RVA: 0x7FFAC3771DA0
        public void get_products(){} // RVA: 0x7FFAC2F247C0
        public void get_factory(){} // RVA: 0x7FFAC2F4F0C0
        public void Instance(){} // RVA: 0x7FFAC99AB470
        public void AddProduct(){} // RVA: 0x7FFAC99AB840 | overloaded x2
    }

    public class CoreServicesEnvironmentSubject : Object
    {
        public UnityEngine.Purchasing.CoreServicesEnvironmentSubject s_Instance;
        public string m_LastKnownEnvironment; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Purchasing.ICoreServicesEnvironmentObserver> m_Observers; // 0x18

        // ── Methods ──
        public void Instance(){} // RVA: 0x7FFAC99AB9D0
        public void SubscribeToUpdatesAndGetCurrent(){} // RVA: 0x7FFAC99ABB50
        public void UpdateCurrentEnvironment(){} // RVA: 0x7FFAC99ABC80
        public void NotifyObservers(){} // RVA: 0x7FFAC99ABCE0
        public void IsDefaultLiveEnvironment(){} // RVA: 0x7FFAC99ABEE0
        public void .ctor(){} // RVA: 0x7FFAC99ABF60
    }

}