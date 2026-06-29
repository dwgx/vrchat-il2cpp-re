// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 2
// Methods: 13

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class ConfigurationBuilder : Object
    {
        public object _useCatalogProvider;
        public object _logUnavailableProducts;
        public object _products;
        public object _factory;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D66630
        public void get_useCatalogProvider(){} // RVA: 0xC120A0
        public void get_logUnavailableProducts(){} // RVA: 0xDD5C50
        public void get_products(){} // RVA: 0xB465B0
        public void get_factory(){} // RVA: 0xB700F0
        public void Instance(){} // RVA: 0x7D66760
        public void AddProduct(){} // RVA: 0x7D66B30
    }

    public class CoreServicesEnvironmentSubject : Object
    {
        public object s_Instance;
        public object m_LastKnownEnvironment;
        public object m_Observers;

        // ── Methods ──
        public void Instance(){} // RVA: 0x7D66CC0
        public void SubscribeToUpdatesAndGetCurrent(){} // RVA: 0x7D66E40
        public void UpdateCurrentEnvironment(){} // RVA: 0x7D66F70
        public void NotifyObservers(){} // RVA: 0x7D66FD0
        public void IsDefaultLiveEnvironment(){} // RVA: 0x7D671E0
        public void .ctor(){} // RVA: 0x7D67260
    }

}