// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Telemetry.Internal
// Classes: 9
// Methods: 16

namespace ThirdParty.Other.Unity.Services.Core.Telemetry.Internal
{
    public class Diagnostics : Object
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE87AA6E40
    }

    public class DiagnosticsFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87AA6F00
        public void .ctor(){} // RVA: 0x7FFE87AA6FE0
    }

    public class IDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFE80E50660
    }

    public class IDiagnosticsComponentProvider
    {
    }

    public class IDiagnosticsFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E390
    }

    public class IMetrics
    {
        // ── Methods ──
        public void SendGaugeMetric(){}
        public void SendHistogramMetric(){}
        public void SendSumMetric(){}
    }

    public class IMetricsFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E390
    }

    public class Metrics : Object
    {
        // ── Methods ──
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(){} // RVA: 0x7FFE810FB310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(){} // RVA: 0x7FFE810FB310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE87AA70A0
    }

    public class MetricsFactory : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87AA7160
        public void .ctor(){} // RVA: 0x7FFE87AA7240
    }

}