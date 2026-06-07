// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x2DC60
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x24B10
        public void SendDiagnostic(){} // RVA: 0x2DC60
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x24A50
        public void StopAndSendMetric(){} // RVA: 0x24A50
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x24B10
        public void SendMetric(){}
    }

    public class ITelemetryMetricsService
    {
        // ── Methods ──
        public void ExecuteTimedAction(){}
    }

    public class IapTelemetryException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x721B2E0
    }

    public class TelemetryDiagnosticParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19B3510
    }

    public class TelemetryDiagnostics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void SendDiagnostic(){} // RVA: 0x721A7D0
    }

    public class TelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x721A8F0
        public void SetDiagnosticsInstance(){} // RVA: 0x721ABC0
        public void SendDiagnostic(){} // RVA: 0x721AD40
        public void SendDiagnosticOnMainThread(){} // RVA: 0x721B020
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x721B1B0
    }

    public class TelemetryMetricDefinition
    {
        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x19689B0
        public void get_MetricName(){} // RVA: 0x19689C0
        public void .ctor(){} // RVA: 0x721B340
        public void op_Implicit(){} // RVA: 0x721B3A0
    }

    public class TelemetryMetricDefinitions
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x721B410
    }

    public class TelemetryMetricEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x721C260
        public void StartMetric(){} // RVA: 0x721C3C0
        public void StopAndSendMetric(){} // RVA: 0x721C490
    }

    public class TelemetryMetricParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x721C6D0
    }

    public class TelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x721C730
        public void SetMetricsInstance(){} // RVA: 0x721CA00
        public void SendMetric(){} // RVA: 0x721CBB0
        public void SendMetricOnMainThread(){} // RVA: 0x721CE50
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x721CFF0
        public void SendMetricByType(){} // RVA: 0x721D1B0
    }

    public class TelemetryMetricsService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void ExecuteTimedAction(){} // RVA: 0x721D2C0
        public void CreateAndStartMetricEvent(){} // RVA: 0x721D3E0
    }

    public class TelemetryQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void QueueEvent(){} // RVA: 0x283FA0
        public void SendQueuedEvents(){} // RVA: 0x24A50
    }

}