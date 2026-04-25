// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 1
// Methods: 12

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class QueryProductDetailsService : Object
    {
        public UnityEngine.Purchasing.Interfaces.IGoogleBillingClient m_BillingClient; // 0x10
        public UnityEngine.Purchasing.IGoogleCachedQueryProductDetailsService m_GoogleCachedQueryProductDetailsService; // 0x18
        public UnityEngine.Purchasing.Interfaces.IProductDetailsConverter m_ProductDetailsConverter; // 0x20
        public UnityEngine.Purchasing.Stores.Util.IRetryPolicy m_RetryPolicy; // 0x28
        public UnityEngine.Purchasing.Interfaces.IGoogleProductCallback m_GoogleProductCallback; // 0x30
        public Uniject.IUtil m_Util; // 0x38
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53230260
        public void QueryAsyncProduct(){} // RVA: 0x7FFD54DE1920 | overloaded x3
        public void QueryAsyncProductWithRetries(){} // RVA: 0x7FFD54DE1B50
        public void TryQueryAsyncProductWithRetries(){} // RVA: 0x7FFD54DE1C20
        public void ShouldRetryQuery(){} // RVA: 0x7FFD54DE1E90
        public void AreAllProductDetailsCached(){} // RVA: 0x7FFD54DE1F20
        public void GetCachedProductDetails(){} // RVA: 0x7FFD54DE2180
        public void QueryInAppsAsync(){} // RVA: 0x7FFD54DE2360
        public void QuerySubsAsync(){} // RVA: 0x7FFD54DE26F0
        public void QueryProductDetails(){} // RVA: 0x7FFD54DE2A80
    }

}