// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFAC2C79B30
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFAC2C70A40
        public void SendDiagnostic(){} // RVA: 0x7FFAC2C79B30
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x7FFAC2C70980
        public void StopAndSendMetric(){} // RVA: 0x7FFAC2C70980
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x7FFAC2C70A40
        public void SendMetric(){}
    }

    public class ITelemetryMetricsService
    {
        // ── Methods ──
        public void ExecuteTimedAction(){}
    }

    public class IapTelemetryException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B2BE0
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        public string name; // 0x10
        public string exception; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC41AE4B0
    }

    public class TelemetryDiagnostics : Object
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnosticsInstanceWrapper m_TelemetryDiagnosticsInstanceWrapper; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void SendDiagnostic(){} // RVA: 0x7FFAC99B20D0
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        public Unity.Services.Core.Telemetry.Internal.IDiagnostics m_Instance; // 0x10
        public UnityEngine.ILogger m_Logger; // 0x18
        public Uniject.IUtil m_Util; // 0x20
        public UnityEngine.Purchasing.Telemetry.TelemetryQueue`1<UnityEngine.Purchasing.Telemetry.TelemetryDiagnosticParams> m_Queue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B21F0
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFAC99B24C0
        public void SendDiagnostic(){} // RVA: 0x7FFAC99B2640
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7FFAC99B2920
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7FFAC99B2AB0
    }

    public class TelemetryMetricDefinition : ValueType
    {
        public 0x6B2C3000 MetricType; // 0x10
        public string MetricName; // 0x18

        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x7FFAC4420210
        public void get_MetricName(){} // RVA: 0x7FFAC4420220
        public void .ctor(){} // RVA: 0x7FFAC99B2C40
        public void op_Implicit(){} // RVA: 0x7FFAC99B2CA0
    }

    public class TelemetryMetricDefinitions : Object
    {
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition confirmSubscriptionPriceChangeName;
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition continuePromotionalPurchasesName; // 0x10
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition dequeueQueryProductsTimeName; // 0x20
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition dequeueQueryPurchasesTimeName; // 0x30
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition fetchStorePromotionOrderName; // 0x40
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition fetchStorePromotionVisibilityName; // 0x50
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition initPurchaseName; // 0x60
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition packageInitTimeName; // 0x70
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition presentCodeRedemptionSheetName; // 0x80
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition refreshAppReceiptName; // 0x90
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition restoreTransactionName; // 0xA0
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition retrieveProductsName; // 0xB0
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition setStorePromotionOrderName; // 0xC0
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition setStorePromotionVisibilityName; // 0xD0
        public UnityEngine.Purchasing.Telemetry.TelemetryMetricDefinition upgradeDowngradeSubscriptionName; // 0xE0

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC99B2D10
    }

    public class TelemetryMetricEvent : Object
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10
        public 0x6B2C3000 m_MetricType; // 0x18
        public string m_MetricName; // 0x20
        public System.Diagnostics.Stopwatch m_Stopwatch; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B3B60
        public void StartMetric(){} // RVA: 0x7FFAC99B3CC0
        public void StopAndSendMetric(){} // RVA: 0x7FFAC99B3D90
    }

    public class TelemetryMetricParams : ValueType
    {
        public 0x6B2C3000 type; // 0x10
        public string name; // 0x18
        public double timeSeconds; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B3FD0
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        public Unity.Services.Core.Telemetry.Internal.IMetrics m_Instance; // 0x10
        public UnityEngine.ILogger m_Logger; // 0x18
        public Uniject.IUtil m_Util; // 0x20
        public UnityEngine.Purchasing.Telemetry.TelemetryQueue`1<UnityEngine.Purchasing.Telemetry.TelemetryMetricParams> m_Queue; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC99B4030
        public void SetMetricsInstance(){} // RVA: 0x7FFAC99B4300
        public void SendMetric(){} // RVA: 0x7FFAC99B44B0
        public void SendMetricOnMainThread(){} // RVA: 0x7FFAC99B4750
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7FFAC99B48F0
        public void SendMetricByType(){} // RVA: 0x7FFAC99B4AB0
    }

    public class TelemetryMetricsService : Object
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsInstanceWrapper m_TelemetryMetricsInstanceWrapper; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void ExecuteTimedAction(){} // RVA: 0x7FFAC99B4BC0
        public void CreateAndStartMetricEvent(){} // RVA: 0x7FFAC99B4CE0
    }

    public class TelemetryQueue`1 : Object
    {
        public System.Action`1<T> m_SendTelemetryEvent;
        public System.Collections.Concurrent.ConcurrentQueue`1<T> m_Queue;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void QueueEvent(){} // RVA: 0x7FFAC2E8DC40
        public void SendQueuedEvents(){} // RVA: 0x7FFAC2C70980
    }

}