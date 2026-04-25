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
        public void SendDiagnostic(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC96FE8D0
    }

    public class DiagnosticsFactory : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> <CommonTags>k__BackingField; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC96FE990
        public void .ctor(){} // RVA: 0x7FFAC96FEA70
    }

    public class IDiagnostics
    {
        // ── Methods ──
        public void SendDiagnostic(){} // RVA: 0x7FFAC2C7AF60
    }

    public class IDiagnosticsComponentProvider
    {
    }

    public class IDiagnosticsFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C58F40
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
        public void Create(){} // RVA: 0x7FFAC2C58F40
    }

    public class Metrics : Object
    {
        public System.Collections.Generic.IDictionary`2<string,string> <PackageTags>k__BackingField; // 0x10

        // ── Methods ──
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(){} // RVA: 0x7FFAC2F21310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(){} // RVA: 0x7FFAC2F21310
        public void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC96FEB30
    }

    public class MetricsFactory : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> <CommonTags>k__BackingField; // 0x10

        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC96FEBF0
        public void .ctor(){} // RVA: 0x7FFAC96FECD0
    }

}