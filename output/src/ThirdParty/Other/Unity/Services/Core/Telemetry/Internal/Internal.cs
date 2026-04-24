// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.Services.Core.Telemetry.Internal
// Classes: 9
// Methods: 16

namespace ThirdParty.Other.Unity.Services.Core.Telemetry.Internal
{
    public class Diagnostics : Object
    {
        public System.Collections.Generic.IDictionary`2<string,string> <PackageTags>k__BackingField; // 0x10

        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD54B1E8D0
    }

    public class DiagnosticsFactory : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> <CommonTags>k__BackingField; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54B1E990
        public void .ctor(){} // RVA: 0x7FFD54B1EA70
    }

    public class IDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFD4E09AF60
    }

    public class IDiagnosticsComponentProvider
    {
    }

    public class IDiagnosticsFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E078F40
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
        public void Create(){} // RVA: 0x7FFD4E078F40
    }

    public class Metrics : Object
    {
        public System.Collections.Generic.IDictionary`2<string,string> <PackageTags>k__BackingField; // 0x10

        // ── Methods ──
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(){} // RVA: 0x7FFD4E341310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(){} // RVA: 0x7FFD4E341310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD54B1EB30
    }

    public class MetricsFactory : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> <CommonTags>k__BackingField; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD54B1EBF0
        public void .ctor(){} // RVA: 0x7FFD54B1ECD0
    }

}