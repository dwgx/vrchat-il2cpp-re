// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Telemetry.Internal
// Classes: 8
// Methods: 16

namespace ThirdParty.Other.Unity.Services.Core.Telemetry.Internal
{
    public class Diagnostics : Object
    {
        public object _packageTags;

        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x79B0F20
    }

    public class DiagnosticsFactory : Object
    {
        public object _commonTags;

        // ── Methods ──
        public void Create(){} // RVA: 0x79B0FE0
        public void .ctor(){} // RVA: 0x79B10C0
    }

    public class IDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x8954D0
    }

    public class IDiagnosticsFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C540
    }

    public class IMetrics
    {
        // ── Methods ──
        public void SendGaugeMetric(){} // RVA: 0x89AFA0
        public void SendHistogramMetric(){} // RVA: 0x89AFA0
        public void SendSumMetric(){} // RVA: 0x89AFA0
    }

    public class IMetricsFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C540
    }

    public class Metrics : Object
    {
        public object _packageTags;

        // ── Methods ──
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(){} // RVA: 0xB43310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(){} // RVA: 0xB43310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0x79B1180
    }

    public class MetricsFactory : Object
    {
        public object _commonTags;

        // ── Methods ──
        public void Create(){} // RVA: 0x79B1240
        public void .ctor(){} // RVA: 0x79B1320
    }

}