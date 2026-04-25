// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Metrics
// Classes: 10
// Methods: 100

namespace ThirdParty.Sentry.Sentry.Protocol.Metrics
{
    public class CodeLocations : Object
    {
        public long Timestamp; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<Sentry.Protocol.Metrics.MetricResourceIdentifier,Sentry.SentryStackFrame> <locations>P; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8522550
        public void get_Timestamp(){} // RVA: 0x7FFAC2F3C380
        public void WriteTo(){} // RVA: 0x7FFAC8B77070
    }

    public class CounterMetric : Metric
    {
        public double Value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B77BA0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC8B77C20
        public void set_Value(){} // RVA: 0x7FFAC8B77C30
        public void Add(){} // RVA: 0x7FFAC8B77C40
        public void WriteValues(){} // RVA: 0x7FFAC8B77C50
        public void SerializedStatsdValues(){} // RVA: 0x7FFAC8B77CB0
    }

    public class DistributionMetric : Metric
    {
        public System.Collections.Generic.List`1<double> Value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B78010 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC2FE9500
        public void Add(){} // RVA: 0x7FFAC8B781C0
        public void WriteValues(){} // RVA: 0x7FFAC8B78270
        public void SerializedStatsdValues(){} // RVA: 0x7FFAC8B78320
    }

    public class GaugeMetric : Metric
    {
        public double Value; // 0x58
        public double First; // 0x60
        public double Min; // 0x68
        public double Max; // 0x70
        public double Sum; // 0x78
        public double Count; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B783A0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC8B77C20
        public void set_Value(){} // RVA: 0x7FFAC8B77C30
        public void get_First(){} // RVA: 0x7FFAC5FDA6B0
        public void get_Min(){} // RVA: 0x7FFAC5FDA390
        public void set_Min(){} // RVA: 0x7FFAC5FDA3A0
        public void get_Max(){} // RVA: 0x7FFAC8B78440
        public void set_Max(){} // RVA: 0x7FFAC8B78450
        public void get_Sum(){} // RVA: 0x7FFAC4870390
        public void set_Sum(){} // RVA: 0x7FFAC48703A0
        public void get_Count(){} // RVA: 0x7FFAC48703B0
        public void set_Count(){} // RVA: 0x7FFAC48703C0
        public void Add(){} // RVA: 0x7FFAC8B78460
        public void WriteValues(){} // RVA: 0x7FFAC8B78540
        public void SerializedStatsdValues(){} // RVA: 0x7FFAC8B78670
    }

    public class Metric : Object
    {
        public Sentry.SentryId EventId; // 0x10
        public string Key; // 0x20
        public System.DateTimeOffset Timestamp; // 0x28
        public System.Nullable`1<Sentry.MeasurementUnit> Unit; // 0x38
        public System.Collections.Generic.IDictionary`2<string,string> Tags; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B78AD0 | overloaded x2
        public void get_EventId(){} // RVA: 0x7FFAC4422E80
        public void get_Key(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Timestamp(){} // RVA: 0x7FFAC3BCF020
        public void get_Unit(){} // RVA: 0x7FFAC8B78D60
        public void get_Tags(){} // RVA: 0x7FFAC8B78D80
        public void Add(){} // RVA: 0x7FFAC2C72080
        public void WriteValues(){} // RVA: 0x7FFAC2C79B30
        public void WriteTo(){} // RVA: 0x7FFAC8B78E40
        public void SerializedStatsdValues(){} // RVA: 0x7FFAC2C58E90
        public void SerializeAsync(){} // RVA: 0x7FFAC8B790F0
        public void Serialize(){} // RVA: 0x7FFAC8B79380
        public void get_StatsdType(){} // RVA: 0x7FFAC8B79420
    }

    public class MetricResourceIdentifier : ValueType
    {
        public 0x6B19B398 MetricType; // 0x10
        public string Key; // 0x18
        public Sentry.MeasurementUnit Unit; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B7C050
        public void get_MetricType(){} // RVA: 0x7FFAC495DDF0
        public void set_MetricType(){} // RVA: 0x7FFAC495DE00
        public void get_Key(){} // RVA: 0x7FFAC4420220
        public void set_Key(){} // RVA: 0x7FFAC4420240
        public void get_Unit(){} // RVA: 0x7FFAC4422E80
        public void set_Unit(){} // RVA: 0x7FFAC4A9B120
        public void ToString(){} // RVA: 0x7FFAC8B7C100
        public void PrintMembers(){} // RVA: 0x7FFAC8B7C210
        public void op_Inequality(){} // RVA: 0x7FFAC8B7C3E0
        public void op_Equality(){} // RVA: 0x7FFAC8B7C420
        public void GetHashCode(){} // RVA: 0x7FFAC8B7C450
        public void Equals(){} // RVA: 0x7FFAC8B7C610 | overloaded x2
        public void Deconstruct(){} // RVA: 0x7FFAC8B7C760
    }

    public class MetricTypeExtensions : Object
    {
        // ── Methods ──
        public void ToStatsdType(){} // RVA: 0x7FFAC8B7D5E0
    }

    public class MetricsSummary : Object
    {
        public System.Collections.Generic.IDictionary`2<string,System.Collections.Generic.List`1<Sentry.Protocol.Metrics.SpanMetric>> _measurements; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B7C810
        public void WriteTo(){} // RVA: 0x7FFAC8B7CD80
    }

    public class SetMetric : Metric
    {
        public System.Collections.Generic.HashSet`1<int> Value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B7D7D0 | overloaded x2
        public void get_Value(){} // RVA: 0x7FFAC2FE9500
        public void Add(){} // RVA: 0x7FFAC8B7D940
        public void WriteValues(){} // RVA: 0x7FFAC8B7D9B0
        public void SerializedStatsdValues(){} // RVA: 0x7FFAC8B7DA60
    }

    public class SpanMetric : Object
    {
        public 0x6B19B398 EqualityContract; // 0x10
        public string MetricType; // 0x18
        public Sentry.MeasurementUnit Key; // 0x20
        public System.Collections.Generic.IDictionary`2<string,string> Unit; // 0x30
        public double Tags; // 0x38
        public double Min; // 0x40
        public double Max; // 0x48
        public double Sum; // 0x50

        // ── Methods ──
        public void get_EqualityContract(){} // RVA: 0x7FFAC8B7DAA0
        public void .ctor(){} // RVA: 0x7FFAC8B7EDB0 | overloaded x2
        public void get_MetricType(){} // RVA: 0x7FFAC2FEB5E0
        public void set_MetricType(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Key(){} // RVA: 0x7FFAC2F247C0
        public void set_Key(){} // RVA: 0x7FFAC2F87E80
        public void get_Unit(){} // RVA: 0x7FFAC4A19630
        public void set_Unit(){} // RVA: 0x7FFAC4A19640
        public void get_Tags(){} // RVA: 0x7FFAC31D95E0
        public void set_Tags(){} // RVA: 0x7FFAC2F4F890
        public void get_Min(){} // RVA: 0x7FFAC5C75050
        public void set_Min(){} // RVA: 0x7FFAC5C75060
        public void get_Max(){} // RVA: 0x7FFAC4A87CB0
        public void set_Max(){} // RVA: 0x7FFAC4A87CA0
        public void get_Sum(){} // RVA: 0x7FFAC47C2A50
        public void set_Sum(){} // RVA: 0x7FFAC8B7DC80
        public void get_Count(){} // RVA: 0x7FFAC6C28EF0
        public void set_Count(){} // RVA: 0x7FFAC8B7DC90
        public void get_ExportKey(){} // RVA: 0x7FFAC8B7DCA0
        public void Add(){} // RVA: 0x7FFAC8B7DD80
        public void WriteTo(){} // RVA: 0x7FFAC8B7DE50
        public void ToString(){} // RVA: 0x7FFAC8B7DFA0
        public void PrintMembers(){} // RVA: 0x7FFAC8B7E0E0
        public void op_Inequality(){} // RVA: 0x7FFAC489FA10
        public void op_Equality(){} // RVA: 0x7FFAC489FA50
        public void GetHashCode(){} // RVA: 0x7FFAC8B7E580
        public void Equals(){} // RVA: 0x7FFAC8B7E920 | overloaded x2
        public void <Clone>$(){} // RVA: 0x7FFAC8B7EC30
    }

}