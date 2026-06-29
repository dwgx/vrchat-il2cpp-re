// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Metrics
// Classes: 10
// Methods: 92

namespace ThirdParty.Sentry.Sentry.Protocol.Metrics
{
    public class CodeLocations : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADB78F90
        public void get_Timestamp(){} // RVA: 0x7A80F2570
        public void WriteTo(){} // RVA: 0x7AE1CD6C0
    }

    public class CounterMetric : Metric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1CE250
        public void get_Value(){} // RVA: 0x7AE1CE2D0
        public void set_Value(){} // RVA: 0x7AE1CE2E0
        public void Add(){} // RVA: 0x7AE1CE2F0
        public void WriteValues(){} // RVA: 0x7AE1CE300
        public void SerializedStatsdValues(){} // RVA: 0x7AE1CE360
    }

    public class DistributionMetric : Metric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1CE6C0
        public void get_Value(){} // RVA: 0x7A81A0050
        public void Add(){} // RVA: 0x7AE1CE870
        public void WriteValues(){} // RVA: 0x7AE1CE920
        public void SerializedStatsdValues(){} // RVA: 0x7AE1CE9D0
    }

    public class GaugeMetric : Metric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1CEA50
        public void get_Value(){} // RVA: 0x7AE1CE2D0
        public void set_Value(){} // RVA: 0x7AE1CE2E0
        public void get_First(){} // RVA: 0x7AB492F00
        public void get_Min(){} // RVA: 0x7AB492BE0
        public void set_Min(){} // RVA: 0x7AB492BF0
        public void get_Max(){} // RVA: 0x7AE1CEAF0
        public void set_Max(){} // RVA: 0x7AE1CEB00
        public void get_Sum(){} // RVA: 0x7A9B4D410
        public void set_Sum(){} // RVA: 0x7A9B4D420
        public void get_Count(){} // RVA: 0x7A9B4D430
        public void set_Count(){} // RVA: 0x7A9B4D440
        public void Add(){} // RVA: 0x7AE1CEB10
        public void WriteValues(){} // RVA: 0x7AE1CEBF0
        public void SerializedStatsdValues(){} // RVA: 0x7AE1CED20
    }

    public class Metric : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1CF180
        public void get_EventId(){} // RVA: 0x7A97277F0
        public void get_Key(){} // RVA: 0x7A81052C0
        public void get_Timestamp(){} // RVA: 0x7A8EDF360
        public void get_Unit(){} // RVA: 0x7AE1CF410
        public void get_Tags(){} // RVA: 0x7AE1CF430
        public void Add(){} // RVA: 0x7A7E19E10
        public void WriteValues(){} // RVA: 0x7A7E18890
        public void WriteTo(){} // RVA: 0x7AE1CF4F0
        public void SerializedStatsdValues(){} // RVA: 0x7A7E00680
        public void SerializeAsync(){} // RVA: 0x7AE1CF7D0
        public void Serialize(){} // RVA: 0x7AE1CFA50
        public void get_StatsdType(){} // RVA: 0x7AE1CFAF0
    }

    public class MetricResourceIdentifier : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E76400
        public void get_MetricType(){} // RVA: 0x7A767CAD0
        public void set_MetricType(){} // RVA: 0x7A767CAE0
        public void get_Key(){} // RVA: 0x7A765F080
        public void set_Key(){} // RVA: 0x7A765F010
        public void get_Unit(){} // RVA: 0x7A76B8870
        public void set_Unit(){} // RVA: 0x7A76B8880
        public void ToString(){} // RVA: 0x7A7E76430
        public void PrintMembers(){} // RVA: 0x7A7E76440
        public void op_Inequality(){} // RVA: 0x7AE1D2AE0
        public void op_Equality(){} // RVA: 0x7AE1D2B20
        public void GetHashCode(){} // RVA: 0x7A7E76450
        public void Equals(){} // RVA: 0x7A7E76470
        public void Deconstruct(){} // RVA: 0x7A7E764A0
    }

    public class MetricTypeExtensions : Object
    {
        // ── Methods ──
        public void ToStatsdType(){} // RVA: 0x7AE1D3D00
    }

    public class MetricsSummary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1D2F10
        public void WriteTo(){} // RVA: 0x7AE1D3480
    }

    public class SetMetric : Metric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1D3EF0
        public void get_Value(){} // RVA: 0x7A81A0050
        public void Add(){} // RVA: 0x7AE1D4060
        public void WriteValues(){} // RVA: 0x7AE1D40D0
        public void SerializedStatsdValues(){} // RVA: 0x7AE1D4180
    }

    public class SpanMetric : Object
    {
        // ── Methods ──
        public void get_EqualityContract(){} // RVA: 0x7AE1D41C0
        public void .ctor(){} // RVA: 0x7AE1D54F0
        public void get_MetricType(){} // RVA: 0x7A81A2200
        public void set_MetricType(){} // RVA: 0x7A81A2210
        public void get_Key(){} // RVA: 0x7A80DA7B0
        public void set_Key(){} // RVA: 0x7A813E420
        public void get_Unit(){} // RVA: 0x7A9D01C90
        public void set_Unit(){} // RVA: 0x7A9D01CA0
        public void get_Tags(){} // RVA: 0x7A83F69F0
        public void set_Tags(){} // RVA: 0x7A8105A90
        public void get_Min(){} // RVA: 0x7AB126C30
        public void set_Min(){} // RVA: 0x7AB126C40
        public void get_Max(){} // RVA: 0x7A9D70440
        public void set_Max(){} // RVA: 0x7A9D70450
        public void get_Sum(){} // RVA: 0x7A9A9B800
        public void set_Sum(){} // RVA: 0x7AE1D43A0
        public void get_Count(){} // RVA: 0x7AC154B90
        public void set_Count(){} // RVA: 0x7AE1D43B0
        public void get_ExportKey(){} // RVA: 0x7AE1D43C0
        public void Add(){} // RVA: 0x7AE1D44A0
        public void WriteTo(){} // RVA: 0x7AE1D4570
        public void ToString(){} // RVA: 0x7AE1D46E0
        public void PrintMembers(){} // RVA: 0x7AE1D4820
        public void op_Inequality(){} // RVA: 0x7A9B7AD40
        public void op_Equality(){} // RVA: 0x7A9B7AD80
        public void GetHashCode(){} // RVA: 0x7AE1D4CC0
        public void Equals(){} // RVA: 0x7AE1D5060
        public void <Clone>$(){} // RVA: 0x7AE1D5370
    }

}