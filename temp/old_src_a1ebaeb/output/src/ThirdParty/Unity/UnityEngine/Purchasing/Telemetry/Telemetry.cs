// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Original Methods ──
        public void SendDiagnostic(){} // RVA: 0x7ffaa8669e70
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Original Methods ──
        public void SendDiagnostic(){} // RVA: 0x7ffaa8669e70
        // ── Binary Analysis Named ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7ffaa8660d80
    }

    public class ITelemetryMetricEvent
    {
        // ── Original Methods ──
        public void StartMetric(){} // RVA: 0x7ffaa8660cc0
        public void StopAndSendMetric(){} // RVA: 0x7ffaa8660cc0
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Original Methods ──
        public void SendMetric(){}
        // ── Binary Analysis Named ──
        public void SetMetricsInstance(){} // RVA: 0x7ffaa8660d80
    }

    public class ITelemetryMetricsService
    {
        // ── Original Methods ──
        public void ExecuteTimedAction(){}
    }

    public class IapTelemetryException : Exception
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d4b40
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9bb9250
    }

    public class TelemetryDiagnostics : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void SendDiagnostic(){} // RVA: 0x7ffaaf3d4030
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        public object m_Util; // 0x3385F480

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d4150
        public void SendDiagnostic(){} // RVA: 0x7ffaaf3d45a0
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7ffaaf3d4880
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7ffaaf3d4a10
        // ── Binary Analysis Named ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7ffaaf3d4420
    }

    public class TelemetryMetricDefinition : ValueType
    {
        // ── Original Methods ──
        public void get_MetricType(){} // RVA: 0x7ffaa9e47550
        public void get_MetricName(){} // RVA: 0x7ffaa9e47540
        public void .ctor(){} // RVA: 0x7ffaaf3d4ba0
        public void op_Implicit(){} // RVA: 0x7ffaaf3d4c00
    }

    public class TelemetryMetricDefinitions : Object
    {
        public object dequeueQueryProductsTimeName; // 0x337DC630
        public object fetchStorePromotionVisibilityName; // 0x337DC630
        public object presentCodeRedemptionSheetName; // 0x337DC630
        public object retrieveProductsName; // 0x337DC630
        public object upgradeDowngradeSubscriptionName; // 0x337DC630
        public object `;
        public object StopAndSendMetric; // 0xB3F6FFF0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf3d4c70
    }

    public class TelemetryMetricEvent : Object
    {
        public object m_MetricName; // 0x33658580

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d5ac0
        public void StartMetric(){} // RVA: 0x7ffaaf3d5c20
        public void StopAndSendMetric(){} // RVA: 0x7ffaaf3d5cf0
    }

    public class TelemetryMetricParams : ValueType
    {
        public object timeSeconds; // 0x3348C170

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d5f30
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        public object m_Util; // 0x3383FD60

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf3d5f90
        public void SendMetric(){} // RVA: 0x7ffaaf3d6410
        public void SendMetricOnMainThread(){} // RVA: 0x7ffaaf3d66b0
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7ffaaf3d6850
        public void SendMetricByType(){} // RVA: 0x7ffaaf3d6a10
        // ── Binary Analysis Named ──
        public void SetMetricsInstance(){} // RVA: 0x7ffaaf3d6260
    }

    public class TelemetryMetricsService : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void ExecuteTimedAction(){} // RVA: 0x7ffaaf3d6b20
        public void CreateAndStartMetricEvent(){} // RVA: 0x7ffaaf3d6c40
    }

    public class TelemetryQueue`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void QueueEvent(){} // RVA: 0x7ffaa887e5c0
        public void SendQueuedEvents(){} // RVA: 0x7ffaa8660cc0
    }

}