// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x8943B0
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x894320
        public void SendDiagnostic(){} // RVA: 0x8943B0
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x894290
        public void StopAndSendMetric(){} // RVA: 0x894290
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x894320
        public void SendMetric(){} // RVA: 0x8975C0
    }

    public class ITelemetryMetricsService
    {
        // ── Methods ──
        public void ExecuteTimedAction(){} // RVA: 0x8943B0
    }

    public class IapTelemetryException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D6DE80
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x76310
    }

    public class TelemetryDiagnostics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void SendDiagnostic(){} // RVA: 0x7D6D380
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D6D4A0
        public void SetDiagnosticsInstance(){} // RVA: 0x7D6D760
        public void SendDiagnostic(){} // RVA: 0x7D6D8E0
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7D6DBC0
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7D6DD50
    }

    public class TelemetryMetricDefinition : ValueType
    {
        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x77E60
        public void get_MetricName(){} // RVA: 0x77ED0
        public void .ctor(){} // RVA: 0x989E80
        public void op_Implicit(){} // RVA: 0x7D6DF40
    }

    public class TelemetryMetricDefinitions : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7D6DFB0
    }

    public class TelemetryMetricEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D6EE00
        public void StartMetric(){} // RVA: 0x7D6EF60
        public void StopAndSendMetric(){} // RVA: 0x7D6F030
    }

    public class TelemetryMetricParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x989FE0
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7D6F2D0
        public void SetMetricsInstance(){} // RVA: 0x7D6F590
        public void SendMetric(){} // RVA: 0x7D6F730
        public void SendMetricOnMainThread(){} // RVA: 0x7D6F9D0
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7D6FB70
        public void SendMetricByType(){} // RVA: 0x7D6FD30
    }

    public class TelemetryMetricsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void ExecuteTimedAction(){} // RVA: 0x7D6FE40
        public void CreateAndStartMetricEvent(){} // RVA: 0x7D6FF60
    }

    public class TelemetryQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894320
        public void QueueEvent(){} // RVA: 0xA94080
        public void SendQueuedEvents(){} // RVA: 0x894290
    }

}