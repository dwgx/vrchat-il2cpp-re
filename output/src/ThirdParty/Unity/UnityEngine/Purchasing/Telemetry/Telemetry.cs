// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFD4E099B30
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFD4E090A40
        public void SendDiagnostic(){} // RVA: 0x7FFD4E099B30
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x7FFD4E090980
        public void StopAndSendMetric(){} // RVA: 0x7FFD4E090980
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x7FFD4E090A40
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
        public void .ctor(){} // RVA: 0x7FFD54DD2BE0
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F5CE4B0
    }

    public class TelemetryDiagnostics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void SendDiagnostic(){} // RVA: 0x7FFD54DD20D0
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD21F0
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFD54DD24C0
        public void SendDiagnostic(){} // RVA: 0x7FFD54DD2640
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7FFD54DD2920
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7FFD54DD2AB0
    }

    public class TelemetryMetricDefinition : ValueType
    {
        public object MetricType;
        public object MetricName;

        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x7FFD4F840210
        public void get_MetricName(){} // RVA: 0x7FFD4F840220
        public void .ctor(){} // RVA: 0x7FFD54DD2C40
        public void op_Implicit(){} // RVA: 0x7FFD54DD2CA0
    }

    public class TelemetryMetricDefinitions : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54DD2D10
    }

    public class TelemetryMetricEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD3B60
        public void StartMetric(){} // RVA: 0x7FFD54DD3CC0
        public void StopAndSendMetric(){} // RVA: 0x7FFD54DD3D90
    }

    public class TelemetryMetricParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD3FD0
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DD4030
        public void SetMetricsInstance(){} // RVA: 0x7FFD54DD4300
        public void SendMetric(){} // RVA: 0x7FFD54DD44B0
        public void SendMetricOnMainThread(){} // RVA: 0x7FFD54DD4750
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7FFD54DD48F0
        public void SendMetricByType(){} // RVA: 0x7FFD54DD4AB0
    }

    public class TelemetryMetricsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void ExecuteTimedAction(){} // RVA: 0x7FFD54DD4BC0
        public void CreateAndStartMetricEvent(){} // RVA: 0x7FFD54DD4CE0
    }

    public class TelemetryQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void QueueEvent(){} // RVA: 0x7FFD4E2ADC40
        public void SendQueuedEvents(){} // RVA: 0x7FFD4E090980
    }

}