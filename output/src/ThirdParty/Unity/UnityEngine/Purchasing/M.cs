// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 5
// Methods: 21

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class MetricizedAppleStoreImpl : AppleStoreImpl
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0xD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99D41C0
        public void RetrieveProducts(){} // RVA: 0x7FFAC99D4230
        public void Purchase(){} // RVA: 0x7FFAC99D4460
        public void <>n__6(){} // RVA: 0x7FFAC99D4700
        public void <>n__7(){} // RVA: 0x7FFAC99D4710
    }

    public class MetricizedGooglePlayStoreExtensions : GooglePlayStoreExtensions
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99C4A80
    }

    public class MetricizedGooglePlayStoreService : GooglePlayStoreService
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0x80
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99BF580
        public void DequeueQueryProducts(){} // RVA: 0x7FFAC99BF6D0
        public void DequeueFetchPurchases(){} // RVA: 0x7FFAC99BF8B0
        public void RetrieveProducts(){} // RVA: 0x7FFAC99BFA10
        public void Purchase(){} // RVA: 0x7FFAC99BFD00
        public void <>n__0(){} // RVA: 0x7FFAC99BFFA0
        public void <>n__1(){} // RVA: 0x7FFAC99B8C90
        public void <>n__2(){} // RVA: 0x7FFAC99BFFB0
    }

    public class MetricizedJsonStore : JSONStore
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99D52D0
        public void RetrieveProducts(){} // RVA: 0x7FFAC99D5340
        public void Purchase(){} // RVA: 0x7FFAC99D5570
        public void <>n__0(){} // RVA: 0x7FFAC99D4700
        public void <>n__1(){} // RVA: 0x7FFAC99D4710
    }

    public class MiniJson : Object
    {
        // ── Methods ──
        public void JsonEncode(){} // RVA: 0x7FFAC89E86C0
        public void JsonDecode(){} // RVA: 0x7FFAC89E86D0
    }

}