// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Metrics
// Classes: 10
// Methods: 100

namespace ThirdParty.Sentry.Sentry.Protocol.Metrics
{
    public class CodeLocations : Object
    {
        public long <timestamp>P; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE868CBD50
        public void get_Timestamp(){} // RVA: 0x7FFE81116380
        public void WriteTo(){} // RVA: 0x7FFE86F206F0
    }

    public class CounterMetric : Metric
    {
        public double _value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F21220 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE86F212A0
        public void set_Value(){} // RVA: 0x7FFE86F212B0
        public void Add(){} // RVA: 0x7FFE86F212C0
        public void WriteValues(){} // RVA: 0x7FFE86F212D0
        public void SerializedStatsdValues(){} // RVA: 0x7FFE86F21330
    }

    public class DistributionMetric : Metric
    {
        public System.Collections.Generic.List`1<double> _value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F21690 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE811C3500
        public void Add(){} // RVA: 0x7FFE86F21840
        public void WriteValues(){} // RVA: 0x7FFE86F218F0
        public void SerializedStatsdValues(){} // RVA: 0x7FFE86F219A0
    }

    public class GaugeMetric : Metric
    {
        public double _value; // 0x58
        public double _first; // 0x60
        public double _min; // 0x68
        public double _max; // 0x70
        public double _sum; // 0x78
        public double _count; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F21A20 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE86F212A0
        public void set_Value(){} // RVA: 0x7FFE86F212B0
        public void get_First(){} // RVA: 0x7FFE84331C10
        public void get_Min(){} // RVA: 0x7FFE843318F0
        public void set_Min(){} // RVA: 0x7FFE84331900
        public void get_Max(){} // RVA: 0x7FFE86F21AC0
        public void set_Max(){} // RVA: 0x7FFE86F21AD0
        public void get_Sum(){} // RVA: 0x7FFE82AD8710
        public void set_Sum(){} // RVA: 0x7FFE82AD8720
        public void get_Count(){} // RVA: 0x7FFE82AD8730
        public void set_Count(){} // RVA: 0x7FFE82AD8740
        public void Add(){} // RVA: 0x7FFE86F21AE0
        public void WriteValues(){} // RVA: 0x7FFE86F21BC0
        public void SerializedStatsdValues(){} // RVA: 0x7FFE86F21CF0
    }

    public class Metric : Object
    {
        public Sentry.SentryId _eventId; // 0x10
        public string _key; // 0x20
        public System.DateTimeOffset _timestamp; // 0x28
        public System.Nullable`1<Sentry.MeasurementUnit> _unit; // 0x38
        public System.Collections.Generic.IDictionary`2<string,string> _tags; // 0x50
        public object field_5; // 0x2AE

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F22150 | overloaded x2
        public void get_EventId(){} // RVA: 0x7FFE826F6B90
        public void get_Key(){} // RVA: 0x7FFE811290C0
        public void get_Timestamp(){} // RVA: 0x7FFE81E90600
        public void get_Unit(){} // RVA: 0x7FFE86F223E0
        public void get_Tags(){} // RVA: 0x7FFE86F22400
        public void Add(){} // RVA: 0x7FFE80E476E0
        public void WriteValues(){} // RVA: 0x7FFE80E4F230
        public void WriteTo(){} // RVA: 0x7FFE86F224C0
        public void SerializedStatsdValues(){} // RVA: 0x7FFE80E2E2E0
        public void SerializeAsync(){} // RVA: 0x7FFE86F22770
        public void Serialize(){} // RVA: 0x7FFE86F22A00
        public void get_StatsdType(){} // RVA: 0x7FFE86F22AA0
    }

    public class MetricResourceIdentifier : ValueType
    {
        public 0x66594C5C _metricType; // 0x10
        public string _key; // 0x18
        public Sentry.MeasurementUnit _unit; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F256D0
        public void get_MetricType(){} // RVA: 0x7FFE82BC9920
        public void set_MetricType(){} // RVA: 0x7FFE82BC9930
        public void get_Key(){} // RVA: 0x7FFE826F4210
        public void set_Key(){} // RVA: 0x7FFE826F4230
        public void get_Unit(){} // RVA: 0x7FFE826F6B90
        public void set_Unit(){} // RVA: 0x7FFE82D033D0
        public void ToString(){} // RVA: 0x7FFE86F25780
        public void PrintMembers(){} // RVA: 0x7FFE86F25890
        public void op_Inequality(){} // RVA: 0x7FFE86F25A60
        public void op_Equality(){} // RVA: 0x7FFE86F25AA0
        public void GetHashCode(){} // RVA: 0x7FFE86F25AD0
        public void Equals(){} // RVA: 0x7FFE86F25C90 | overloaded x2
        public void Deconstruct(){} // RVA: 0x7FFE86F25DE0
    }

    public class MetricTypeExtensions : Object
    {
        // ── Methods ──
        public void ToStatsdType(){} // RVA: 0x7FFE86F26C60
    }

    public class MetricsSummary : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F25E90
        public void WriteTo(){} // RVA: 0x7FFE86F26400
    }

    public class SetMetric : Metric
    {
        public System.Collections.Generic.HashSet`1<int> _value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F26E50 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFE811C3500
        public void Add(){} // RVA: 0x7FFE86F26FC0
        public void WriteValues(){} // RVA: 0x7FFE86F27030
        public void SerializedStatsdValues(){} // RVA: 0x7FFE86F270E0
    }

    public class SpanMetric : Object
    {
        public 0x66594C5C _metricType; // 0x10
        public string _key; // 0x18
        public Sentry.MeasurementUnit _unit; // 0x20
        public System.Collections.Generic.IDictionary`2<string,string> _tags; // 0x30
        public double _min; // 0x38
        public double _max; // 0x40
        public double _sum; // 0x48
        public double _count; // 0x50
        public object field_8; // 0x2B8
        public object field_9; // 0x2B9

        // ── Methods ──
        public void get_EqualityContract(){} // RVA: 0x7FFE86F27120
        public void .ctor(){} // RVA: 0x7FFE86F28430 | overloaded x2
        public void get_MetricType(){} // RVA: 0x7FFE811C55E0
        public void set_MetricType(){} // RVA: 0x7FFE811C55F0
        public void get_Key(){} // RVA: 0x7FFE810FE7C0
        public void set_Key(){} // RVA: 0x7FFE81161E80
        public void get_Unit(){} // RVA: 0x7FFE82C84C90
        public void set_Unit(){} // RVA: 0x7FFE82C84CA0
        public void get_Tags(){} // RVA: 0x7FFE8144E200
        public void set_Tags(){} // RVA: 0x7FFE81129890
        public void get_Min(){} // RVA: 0x7FFE83FADDB0
        public void set_Min(){} // RVA: 0x7FFE83FADDC0
        public void get_Max(){} // RVA: 0x7FFE82CF0830
        public void set_Max(){} // RVA: 0x7FFE82CF0840
        public void get_Sum(){} // RVA: 0x7FFE82A2ADF0
        public void set_Sum(){} // RVA: 0x7FFE86F27300
        public void get_Count(){} // RVA: 0x7FFE84FAF530
        public void set_Count(){} // RVA: 0x7FFE86F27310
        public void get_ExportKey(){} // RVA: 0x7FFE86F27320
        public void Add(){} // RVA: 0x7FFE86F27400
        public void WriteTo(){} // RVA: 0x7FFE86F274D0
        public void ToString(){} // RVA: 0x7FFE86F27620
        public void PrintMembers(){} // RVA: 0x7FFE86F27760
        public void op_Inequality(){} // RVA: 0x7FFE82B07C60
        public void op_Equality(){} // RVA: 0x7FFE82B07CA0
        public void GetHashCode(){} // RVA: 0x7FFE86F27C00
        public void Equals(){} // RVA: 0x7FFE86F27FA0 | overloaded x2
        public void <Clone>$(){} // RVA: 0x7FFE86F282B0
    }

}