// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Protocol.Metrics
// Classes: 10
// Methods: 92

namespace ThirdParty.Sentry.Sentry.Protocol.Metrics
{
    public class CodeLocations : Object
    {
        public object <timestamp>P;
        public object <locations>P;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x68032D0
        public void get_Timestamp(){} // RVA: 0xB5DBF0
        public void WriteTo(){} // RVA: 0x6E50340
    }

    public class CounterMetric : Metric
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E50ED0
        public void get_Value(){} // RVA: 0x6E50F50
        public void set_Value(){} // RVA: 0x6E50F60
        public void Add(){} // RVA: 0x6E50F70
        public void WriteValues(){} // RVA: 0x6E50F80
        public void SerializedStatsdValues(){} // RVA: 0x6E50FE0
    }

    public class DistributionMetric : Metric
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E51320
        public void get_Value(){} // RVA: 0xC0FFC0
        public void Add(){} // RVA: 0x6E514D0
        public void WriteValues(){} // RVA: 0x6E51580
        public void SerializedStatsdValues(){} // RVA: 0x6E51630
    }

    public class GaugeMetric : Metric
    {
        public object _value;
        public object _first;
        public object _min;
        public object _max;
        public object _sum;
        public object _count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E516B0
        public void get_Value(){} // RVA: 0x6E50F50
        public void set_Value(){} // RVA: 0x6E50F60
        public void get_First(){} // RVA: 0x41298D0
        public void get_Min(){} // RVA: 0x41295B0
        public void set_Min(){} // RVA: 0x41295C0
        public void get_Max(){} // RVA: 0x6296740
        public void set_Max(){} // RVA: 0x4F23290
        public void get_Sum(){} // RVA: 0x25F8DD0
        public void set_Sum(){} // RVA: 0x25F8DE0
        public void get_Count(){} // RVA: 0x25F8DF0
        public void set_Count(){} // RVA: 0x25F8E00
        public void Add(){} // RVA: 0x6E51750
        public void WriteValues(){} // RVA: 0x6E51830
        public void SerializedStatsdValues(){} // RVA: 0x6E51960
    }

    public class Metric : Object
    {
        public object _eventId;
        public object _key;
        public object _timestamp;
        public object _unit;
        public object _tags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E51D70
        public void get_EventId(){} // RVA: 0x22343B0
        public void get_Key(){} // RVA: 0xB700F0
        public void get_Timestamp(){} // RVA: 0x19F92B0
        public void get_Unit(){} // RVA: 0x6E52000
        public void get_Tags(){} // RVA: 0x6E52020
        public void Add(){} // RVA: 0x895980
        public void WriteValues(){} // RVA: 0x8943B0
        public void WriteTo(){} // RVA: 0x6E520E0
        public void SerializedStatsdValues(){} // RVA: 0x87C0A0
        public void SerializeAsync(){} // RVA: 0x6E52430
        public void Serialize(){} // RVA: 0x6E526B0
        public void get_StatsdType(){} // RVA: 0x6E52750
    }

    public class MetricResourceIdentifier : ValueType
    {
        public object _metricType;
        public object _key;
        public object _unit;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8F59A0
        public void get_MetricType(){} // RVA: 0x90520
        public void set_MetricType(){} // RVA: 0x90530
        public void get_Key(){} // RVA: 0x77ED0
        public void set_Key(){} // RVA: 0x77E70
        public void get_Unit(){} // RVA: 0xD1A70
        public void set_Unit(){} // RVA: 0xD1A80
        public void ToString(){} // RVA: 0x8F59D0
        public void PrintMembers(){} // RVA: 0x8F59E0
        public void op_Inequality(){} // RVA: 0x6E556F0
        public void op_Equality(){} // RVA: 0x6E55730
        public void GetHashCode(){} // RVA: 0x8F59F0
        public void Equals(){} // RVA: 0x8F5A10
        public void Deconstruct(){} // RVA: 0x8F5A40
    }

    public class MetricTypeExtensions : Object
    {
        // ── Methods ──
        public void ToStatsdType(){} // RVA: 0x6E56910
    }

    public class MetricsSummary : Object
    {
        public object _measurements;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E55B20
        public void WriteTo(){} // RVA: 0x6E56090
    }

    public class SetMetric : Metric
    {
        public object _value;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E56B00
        public void get_Value(){} // RVA: 0xC0FFC0
        public void Add(){} // RVA: 0x6E56C70
        public void WriteValues(){} // RVA: 0x6E56CE0
        public void SerializedStatsdValues(){} // RVA: 0x6E56D90
    }

    public class SpanMetric : Object
    {
        public object _metricType;
        public object _key;
        public object _unit;
        public object _tags;
        public object _min;
        public object _max;
        public object _sum;
        public object _count;

        // ── Methods ──
        public void get_EqualityContract(){} // RVA: 0x6E56DD0
        public void .ctor(){} // RVA: 0x6E580C0
        public void get_MetricType(){} // RVA: 0xC120A0
        public void set_MetricType(){} // RVA: 0xC120B0
        public void get_Key(){} // RVA: 0xB465B0
        public void set_Key(){} // RVA: 0xBA9BA0
        public void get_Unit(){} // RVA: 0x16CD810
        public void set_Unit(){} // RVA: 0x277EE60
        public void get_Tags(){} // RVA: 0xD33E60
        public void set_Tags(){} // RVA: 0xB708C0
        public void get_Min(){} // RVA: 0x3DE0930
        public void set_Min(){} // RVA: 0x3DE0940
        public void get_Max(){} // RVA: 0x27EAE50
        public void set_Max(){} // RVA: 0x27EAE60
        public void get_Sum(){} // RVA: 0x2547D60
        public void set_Sum(){} // RVA: 0x6E56F80
        public void get_Count(){} // RVA: 0x4E418C0
        public void set_Count(){} // RVA: 0x6E56F90
        public void get_ExportKey(){} // RVA: 0x6E56FA0
        public void Add(){} // RVA: 0x6E57080
        public void WriteTo(){} // RVA: 0x6E57150
        public void ToString(){} // RVA: 0x6E572C0
        public void PrintMembers(){} // RVA: 0x6E57400
        public void op_Inequality(){} // RVA: 0x262BFC0
        public void op_Equality(){} // RVA: 0x262C000
        public void GetHashCode(){} // RVA: 0x6E578A0
        public void Equals(){} // RVA: 0x6E57C40
        public void <Clone>$(){} // RVA: 0x6E57F40
    }

}