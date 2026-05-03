// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFE80E4F230
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFE80E460A0
        public void SendDiagnostic(){} // RVA: 0x7FFE80E4F230
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x7FFE80E45FE0
        public void StopAndSendMetric(){} // RVA: 0x7FFE80E45FE0
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x7FFE80E460A0
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
        public void .ctor(){} // RVA: 0x7FFE87D5B480
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8272BDB0
    }

    public class TelemetryDiagnostics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void SendDiagnostic(){} // RVA: 0x7FFE87D5A970
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D5AA90
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFE87D5AD60
        public void SendDiagnostic(){} // RVA: 0x7FFE87D5AEE0
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7FFE87D5B1C0
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7FFE87D5B350
    }

    public class TelemetryMetricDefinition : ValueType
    {
        public 0x666BDB54 _metricType; // 0x10
        public string _metricName; // 0x18

        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x7FFE826F4220
        public void get_MetricName(){} // RVA: 0x7FFE826F4210
        public void .ctor(){} // RVA: 0x7FFE87D5B4E0
        public void op_Implicit(){} // RVA: 0x7FFE87D5B540
    }

    public class TelemetryMetricDefinitions : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87D5B5B0
    }

    public class TelemetryMetricEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D5C400
        public void StartMetric(){} // RVA: 0x7FFE87D5C560
        public void StopAndSendMetric(){} // RVA: 0x7FFE87D5C630
    }

    public class TelemetryMetricParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D5C870
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87D5C8D0
        public void SetMetricsInstance(){} // RVA: 0x7FFE87D5CBA0
        public void SendMetric(){} // RVA: 0x7FFE87D5CD50
        public void SendMetricOnMainThread(){} // RVA: 0x7FFE87D5CFF0
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7FFE87D5D190
        public void SendMetricByType(){} // RVA: 0x7FFE87D5D350
    }

    public class TelemetryMetricsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void ExecuteTimedAction(){} // RVA: 0x7FFE87D5D460
        public void CreateAndStartMetricEvent(){} // RVA: 0x7FFE87D5D580
    }

    public class TelemetryQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void QueueEvent(){} // RVA: 0x7FFE810A1420
        public void SendQueuedEvents(){} // RVA: 0x7FFE80E45FE0
    }

}