// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Metrics
// Classes: 10
// Methods: 100

namespace ThirdParty.Sentry.Sentry.Protocol.Metrics
{
    public class CodeLocations
    {
        public long <timestamp>P; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x5D8AEC0
        public void get_Timestamp(){} // RVA: 0x2F8380
        public void WriteTo(){} // RVA: 0x63DFCC0
    }

    public class CounterMetric
    {
        public double <Value>k__BackingField; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E07F0 | overloaded x2
        public void get_Value(){} // RVA: 0x63E0870
        public void set_Value(){} // RVA: 0x63E0880
        public void Add(){} // RVA: 0x63E0890
        public void WriteValues(){} // RVA: 0x63E08A0
        public void SerializedStatsdValues(){} // RVA: 0x63E0900
    }

    public class DistributionMetric
    {
        public System.Collections.Generic.List`1<double> _value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E0C60 | overloaded x2
        public void get_Value(){} // RVA: 0x3A5500
        public void Add(){} // RVA: 0x63E0E10
        public void WriteValues(){} // RVA: 0x63E0EC0
        public void SerializedStatsdValues(){} // RVA: 0x63E0F70
    }

    public class GaugeMetric
    {
        public double <Value>k__BackingField; // 0x58
        public double <First>k__BackingField; // 0x60
        public double <Min>k__BackingField; // 0x68
        public double <Max>k__BackingField; // 0x70
        public double <Sum>k__BackingField; // 0x78
        public double <Count>k__BackingField; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E0FF0 | overloaded x2
        public void get_Value(){} // RVA: 0x63E0870
        public void set_Value(){} // RVA: 0x63E0880
        public void get_First(){} // RVA: 0x36ADB50
        public void get_Min(){} // RVA: 0x36AD830
        public void set_Min(){} // RVA: 0x36AD840
        public void get_Max(){} // RVA: 0x63E1090
        public void set_Max(){} // RVA: 0x63E10A0
        public void get_Sum(){} // RVA: 0x1D4A890
        public void set_Sum(){} // RVA: 0x1D4A8A0
        public void get_Count(){} // RVA: 0x1D4A8B0
        public void set_Count(){} // RVA: 0x1D4A8C0
        public void Add(){} // RVA: 0x63E10B0
        public void WriteValues(){} // RVA: 0x63E1190
        public void SerializedStatsdValues(){} // RVA: 0x63E12C0
    }

    public class Metric
    {
        public Sentry.SentryId <EventId>k__BackingField; // 0x10
        public string <Key>k__BackingField; // 0x20
        public System.DateTimeOffset <Timestamp>k__BackingField; // 0x28
        public System.Nullable`1<Sentry.MeasurementUnit> <Unit>k__BackingField; // 0x38
        public System.Collections.Generic.IDictionary`2<string,string> _tags; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E1720 | overloaded x2
        public void get_EventId(){} // RVA: 0x196ABE0
        public void get_Key(){} // RVA: 0x30B0C0
        public void get_Timestamp(){} // RVA: 0x111F520
        public void get_Unit(){} // RVA: 0x63E19B0
        public void get_Tags(){} // RVA: 0x63E19D0
        public void Add(){} // RVA: 0x26100
        public void WriteValues(){} // RVA: 0x2DC60
        public void WriteTo(){} // RVA: 0x63E1A90
        public void SerializedStatsdValues(){} // RVA: 0xCD60
        public void SerializeAsync(){} // RVA: 0x63E1D40
        public void Serialize(){} // RVA: 0x63E1FD0
        public void get_StatsdType(){} // RVA: 0x63E2070
    }

    public class MetricResourceIdentifier
    {
        public 0x658B7550 <MetricType>k__BackingField; // 0x10
        public string <Key>k__BackingField; // 0x18
        public Sentry.MeasurementUnit <Unit>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E4CD0
        public void get_MetricType(){} // RVA: 0x1E40360
        public void set_MetricType(){} // RVA: 0x1E40370
        public void get_Key(){} // RVA: 0x19689C0
        public void set_Key(){} // RVA: 0x1968950
        public void get_Unit(){} // RVA: 0x196ABE0
        public void set_Unit(){} // RVA: 0x1F77B90
        public void ToString(){} // RVA: 0x63E4D80
        public void PrintMembers(){} // RVA: 0x63E4E90
        public void op_Inequality(){} // RVA: 0x63E5060
        public void op_Equality(){} // RVA: 0x63E50A0
        public void GetHashCode(){} // RVA: 0x63E50D0
        public void Equals(){} // RVA: 0x63E5290 | overloaded x2
        public void Deconstruct(){} // RVA: 0x63E53E0
    }

    public class MetricTypeExtensions
    {
        // ── Methods ──
        public void ToStatsdType(){} // RVA: 0x63E6260
    }

    public class MetricsSummary : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E5490
        public void WriteTo(){} // RVA: 0x63E5A00
    }

    public class SetMetric
    {
        public System.Collections.Generic.HashSet`1<int> _value; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x63E6450 | overloaded x2
        public void get_Value(){} // RVA: 0x3A5500
        public void Add(){} // RVA: 0x63E65C0
        public void WriteValues(){} // RVA: 0x63E6630
        public void SerializedStatsdValues(){} // RVA: 0x63E66E0
    }

    public class SpanMetric
    {
        public 0x658B7550 <MetricType>k__BackingField; // 0x10
        public string <Key>k__BackingField; // 0x18
        public Sentry.MeasurementUnit <Unit>k__BackingField; // 0x20
        public System.Collections.Generic.IDictionary`2<string,string> <Tags>k__BackingField; // 0x30
        public double <Min>k__BackingField; // 0x38
        public double <Max>k__BackingField; // 0x40
        public double <Sum>k__BackingField; // 0x48
        public double <Count>k__BackingField; // 0x50

        // ── Methods ──
        public void get_EqualityContract(){} // RVA: 0x63E6720
        public void .ctor(){} // RVA: 0x63E7A30 | overloaded x2
        public void get_MetricType(){} // RVA: 0x3A75E0
        public void set_MetricType(){} // RVA: 0x3A75F0
        public void get_Key(){} // RVA: 0x2E07C0
        public void set_Key(){} // RVA: 0x343E80
        public void get_Unit(){} // RVA: 0x1EFB630
        public void set_Unit(){} // RVA: 0x1EFB640
        public void get_Tags(){} // RVA: 0x6374D0
        public void set_Tags(){} // RVA: 0x30B890
        public void get_Min(){} // RVA: 0x332F490
        public void set_Min(){} // RVA: 0x332F4A0
        public void get_Max(){} // RVA: 0x1F65E70
        public void set_Max(){} // RVA: 0x1F65E80
        public void get_Sum(){} // RVA: 0x1C99350
        public void set_Sum(){} // RVA: 0x63E6900
        public void get_Count(){} // RVA: 0x4363CB0
        public void set_Count(){} // RVA: 0x63E6910
        public void get_ExportKey(){} // RVA: 0x63E6920
        public void Add(){} // RVA: 0x63E6A00
        public void WriteTo(){} // RVA: 0x63E6AD0
        public void ToString(){} // RVA: 0x63E6C20
        public void PrintMembers(){} // RVA: 0x63E6D60
        public void op_Inequality(){} // RVA: 0x1D77880
        public void op_Equality(){} // RVA: 0x1D778C0
        public void GetHashCode(){} // RVA: 0x63E7200
        public void Equals(){} // RVA: 0x63E75A0 | overloaded x2
        public void <Clone>$(){} // RVA: 0x63E78B0
    }

}