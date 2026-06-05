// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
// Classes: 16
// Methods: 38

namespace ThirdParty.Unity.UnityEngine.Purchasing.Telemetry
{
    public class ITelemetryDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFAF2ADDC60
    }

    public class ITelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFAF2AD4B10
        public void SendDiagnostic(){} // RVA: 0x7FFAF2ADDC60
    }

    public class ITelemetryMetricEvent
    {
        // ── Methods ──
        public void StartMetric(){} // RVA: 0x7FFAF2AD4A50
        public void StopAndSendMetric(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ITelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void SetMetricsInstance(){} // RVA: 0x7FFAF2AD4B10
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
        public void .ctor(){} // RVA: 0x7FFAF9CCB2E0
    }

    public class TelemetryDiagnosticParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4463510
    }

    public class TelemetryDiagnostics
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void SendDiagnostic(){} // RVA: 0x7FFAF9CCA7D0
    }

    public class TelemetryDiagnosticsInstanceWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CCA8F0
        public void SetDiagnosticsInstance(){} // RVA: 0x7FFAF9CCABC0
        public void SendDiagnostic(){} // RVA: 0x7FFAF9CCAD40
        public void SendDiagnosticOnMainThread(){} // RVA: 0x7FFAF9CCB020
        public void SendDiagnosticAndCatchExceptions(){} // RVA: 0x7FFAF9CCB1B0
    }

    public class TelemetryMetricDefinition
    {
        // ── Methods ──
        public void get_MetricType(){} // RVA: 0x7FFAF44189B0
        public void get_MetricName(){} // RVA: 0x7FFAF44189C0
        public void .ctor(){} // RVA: 0x7FFAF9CCB340
        public void op_Implicit(){} // RVA: 0x7FFAF9CCB3A0
    }

    public class TelemetryMetricDefinitions
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF9CCB410
    }

    public class TelemetryMetricEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CCC260
        public void StartMetric(){} // RVA: 0x7FFAF9CCC3C0
        public void StopAndSendMetric(){} // RVA: 0x7FFAF9CCC490
    }

    public class TelemetryMetricParams
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CCC6D0
    }

    public class TelemetryMetricsInstanceWrapper
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9CCC730
        public void SetMetricsInstance(){} // RVA: 0x7FFAF9CCCA00
        public void SendMetric(){} // RVA: 0x7FFAF9CCCBB0
        public void SendMetricOnMainThread(){} // RVA: 0x7FFAF9CCCE50
        public void SendMetricByTypeAndCatchExceptions(){} // RVA: 0x7FFAF9CCCFF0
        public void SendMetricByType(){} // RVA: 0x7FFAF9CCD1B0
    }

    public class TelemetryMetricsService
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void ExecuteTimedAction(){} // RVA: 0x7FFAF9CCD2C0
        public void CreateAndStartMetricEvent(){} // RVA: 0x7FFAF9CCD3E0
    }

    public class TelemetryQueue`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void QueueEvent(){} // RVA: 0x7FFAF2D33FA0
        public void SendQueuedEvents(){} // RVA: 0x7FFAF2AD4A50
    }

}