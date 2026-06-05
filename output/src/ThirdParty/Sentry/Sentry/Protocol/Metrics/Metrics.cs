// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Metrics
// Classes: 10
// Methods: 100

namespace ThirdParty.Sentry.Sentry.Protocol.Metrics
{
    public class CodeLocations
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF883AEC0
        public void get_Timestamp(){} // RVA: 0x7FFAF2DA8380
        public void WriteTo(){} // RVA: 0x7FFAF8E8FCC0
    }

    public class CounterMetric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E907F0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF8E90870
        public void set_Value(){} // RVA: 0x7FFAF8E90880
        public void Add(){} // RVA: 0x7FFAF8E90890
        public void WriteValues(){} // RVA: 0x7FFAF8E908A0
        public void SerializedStatsdValues(){} // RVA: 0x7FFAF8E90900
    }

    public class DistributionMetric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E90C60 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF2E55500
        public void Add(){} // RVA: 0x7FFAF8E90E10
        public void WriteValues(){} // RVA: 0x7FFAF8E90EC0
        public void SerializedStatsdValues(){} // RVA: 0x7FFAF8E90F70
    }

    public class GaugeMetric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E90FF0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF8E90870
        public void set_Value(){} // RVA: 0x7FFAF8E90880
        public void get_First(){} // RVA: 0x7FFAF615DB50
        public void get_Min(){} // RVA: 0x7FFAF615D830
        public void set_Min(){} // RVA: 0x7FFAF615D840
        public void get_Max(){} // RVA: 0x7FFAF8E91090
        public void set_Max(){} // RVA: 0x7FFAF8E910A0
        public void get_Sum(){} // RVA: 0x7FFAF47FA890
        public void set_Sum(){} // RVA: 0x7FFAF47FA8A0
        public void get_Count(){} // RVA: 0x7FFAF47FA8B0
        public void set_Count(){} // RVA: 0x7FFAF47FA8C0
        public void Add(){} // RVA: 0x7FFAF8E910B0
        public void WriteValues(){} // RVA: 0x7FFAF8E91190
        public void SerializedStatsdValues(){} // RVA: 0x7FFAF8E912C0
    }

    public class Metric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E91720 | overloaded x2
        public void get_EventId(){} // RVA: 0x7FFAF441ABE0
        public void get_Key(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Timestamp(){} // RVA: 0x7FFAF3BCF520
        public void get_Unit(){} // RVA: 0x7FFAF8E919B0
        public void get_Tags(){} // RVA: 0x7FFAF8E919D0
        public void Add(){} // RVA: 0x7FFAF2AD6100
        public void WriteValues(){} // RVA: 0x7FFAF2ADDC60
        public void WriteTo(){} // RVA: 0x7FFAF8E91A90
        public void SerializedStatsdValues(){} // RVA: 0x7FFAF2ABCD60
        public void SerializeAsync(){} // RVA: 0x7FFAF8E91D40
        public void Serialize(){} // RVA: 0x7FFAF8E91FD0
        public void get_StatsdType(){} // RVA: 0x7FFAF8E92070
    }

    public class MetricResourceIdentifier
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E94CD0
        public void get_MetricType(){} // RVA: 0x7FFAF48F0360
        public void set_MetricType(){} // RVA: 0x7FFAF48F0370
        public void get_Key(){} // RVA: 0x7FFAF44189C0
        public void set_Key(){} // RVA: 0x7FFAF4418950
        public void get_Unit(){} // RVA: 0x7FFAF441ABE0
        public void set_Unit(){} // RVA: 0x7FFAF4A27B90
        public void ToString(){} // RVA: 0x7FFAF8E94D80
        public void PrintMembers(){} // RVA: 0x7FFAF8E94E90
        public void op_Inequality(){} // RVA: 0x7FFAF8E95060
        public void op_Equality(){} // RVA: 0x7FFAF8E950A0
        public void GetHashCode(){} // RVA: 0x7FFAF8E950D0
        public void Equals(){} // RVA: 0x7FFAF8E95290 | overloaded x2
        public void Deconstruct(){} // RVA: 0x7FFAF8E953E0
    }

    public class MetricTypeExtensions
    {
        // ── Methods ──
        public void ToStatsdType(){} // RVA: 0x7FFAF8E96260
    }

    public class MetricsSummary : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E95490
        public void WriteTo(){} // RVA: 0x7FFAF8E95A00
    }

    public class SetMetric
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E96450 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAF2E55500
        public void Add(){} // RVA: 0x7FFAF8E965C0
        public void WriteValues(){} // RVA: 0x7FFAF8E96630
        public void SerializedStatsdValues(){} // RVA: 0x7FFAF8E966E0
    }

    public class SpanMetric
    {
        // ── Methods ──
        public void get_EqualityContract(){} // RVA: 0x7FFAF8E96720
        public void .ctor(){} // RVA: 0x7FFAF8E97A30 | overloaded x2
        public void get_MetricType(){} // RVA: 0x7FFAF2E575E0
        public void set_MetricType(){} // RVA: 0x7FFAF2E575F0
        public void get_Key(){} // RVA: 0x7FFAF2D907C0
        public void set_Key(){} // RVA: 0x7FFAF2DF3E80
        public void get_Unit(){} // RVA: 0x7FFAF49AB630
        public void set_Unit(){} // RVA: 0x7FFAF49AB640
        public void get_Tags(){} // RVA: 0x7FFAF30E74D0
        public void set_Tags(){} // RVA: 0x7FFAF2DBB890
        public void get_Min(){} // RVA: 0x7FFAF5DDF490
        public void set_Min(){} // RVA: 0x7FFAF5DDF4A0
        public void get_Max(){} // RVA: 0x7FFAF4A15E70
        public void set_Max(){} // RVA: 0x7FFAF4A15E80
        public void get_Sum(){} // RVA: 0x7FFAF4749350
        public void set_Sum(){} // RVA: 0x7FFAF8E96900
        public void get_Count(){} // RVA: 0x7FFAF6E13CB0
        public void set_Count(){} // RVA: 0x7FFAF8E96910
        public void get_ExportKey(){} // RVA: 0x7FFAF8E96920
        public void Add(){} // RVA: 0x7FFAF8E96A00
        public void WriteTo(){} // RVA: 0x7FFAF8E96AD0
        public void ToString(){} // RVA: 0x7FFAF8E96C20
        public void PrintMembers(){} // RVA: 0x7FFAF8E96D60
        public void op_Inequality(){} // RVA: 0x7FFAF4827880
        public void op_Equality(){} // RVA: 0x7FFAF48278C0
        public void GetHashCode(){} // RVA: 0x7FFAF8E97200
        public void Equals(){} // RVA: 0x7FFAF8E975A0 | overloaded x2
        public void <Clone>$(){} // RVA: 0x7FFAF8E978B0
    }

}