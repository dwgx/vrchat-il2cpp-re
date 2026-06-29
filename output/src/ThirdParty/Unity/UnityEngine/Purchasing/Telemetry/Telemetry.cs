// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 41

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7A7E18890
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7A7E18800
        public void SendDiagnostic(){} // RVA: 0x7A7E18890
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x7A7E18770
        public void StopAndSendMetric(){} // RVA: 0x7A7E18770
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x7A7E18800
        public void SendMetric(){} // RVA: 0x7A7E1B980
    }

    public class ITelemetryMetricsService
    {
        // ── Methods ──
        public void ExecuteTimedAction(){} // RVA: 0x7A7E18890
    }

    public class IapTelemetryException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFFA790
    }

    public class TelemetryDiagnosticParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7661E00
        public void name(){} // RVA: 0x7B3FB4428
    }

    public class TelemetryDiagnostics : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void SendDiagnostic(){} // RVA: 0x7AEFF9C90
    }

    public class TelemetryDiagnosticsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFF9DB0
        public void SetDiagnosticsInstance(){} // RVA: 0x7AEFFA070
        public void SendDiagnostic(){} // RVA: 0x7AEFFA1F0
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7AEFFA4D0
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7AEFFA660
    }

    public class TelemetryMetricDefinition : ValueType
    {
        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x7A765F070
        public void get_MetricName(){} // RVA: 0x7A765F080
        public void .ctor(){} // RVA: 0x7A7EF73A0
        public void op_Implicit(){} // RVA: 0x7AEFFA850
        public void <MetricType>k__BackingField(){} // RVA: 0x7B41810B8
    }

    public class TelemetryMetricDefinitions : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AEFFA8C0
    }

    public class TelemetryMetricEvent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFFB710
        public void StartMetric(){} // RVA: 0x7AEFFB870
        public void StopAndSendMetric(){} // RVA: 0x7AEFFB940
    }

    public class TelemetryMetricParams : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EF7500
        public void type(){} // RVA: 0x7B3FB4428
    }

    public class TelemetryMetricsInstanceWrapper : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEFFBBE0
        public void SetMetricsInstance(){} // RVA: 0x7AEFFBEA0
        public void SendMetric(){} // RVA: 0x7AEFFC040
        public void SendMetricOnMainThread(){} // RVA: 0x7AEFFC2E0
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7AEFFC480
        public void SendMetricByType(){} // RVA: 0x7AEFFC640
    }

    public class TelemetryMetricsService : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void ExecuteTimedAction(){} // RVA: 0x7AEFFC750
        public void CreateAndStartMetricEvent(){} // RVA: 0x7AEFFC870
    }

    public class TelemetryQueue`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E18800
        public void QueueEvent(){} // RVA: 0x7A8051B10
        public void SendQueuedEvents(){} // RVA: 0x7A7E18770
    }

}