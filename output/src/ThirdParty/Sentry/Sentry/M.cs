// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 50

namespace ThirdParty.Sentry.Sentry
{
    public class MeasurementUnit
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3BB2780 | overloaded x2
        public void Custom(){} // RVA: 0x7FFAF8D5B870
        public void Parse(){} // RVA: 0x7FFAF8D5B8B0
        public void ToString(){} // RVA: 0x7FFAF8D5BE80
        public void Equals(){} // RVA: 0x7FFAF8D5BFA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8D5C0C0
        public void op_Equality(){} // RVA: 0x7FFAF8D5C220
        public void op_Inequality(){} // RVA: 0x7FFAF8D5C2F0
        public void op_Implicit(){} // RVA: 0x7FFAF8D5C4B0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAF8D5C520
    }

    public class MetricAggregator
    {
        // ── Methods ──
        public void get_Buckets(){} // RVA: 0x7FFAF8D5C5F0
        public void .ctor(){} // RVA: 0x7FFAF8D5C640
        public void Increment(){} // RVA: 0x7FFAF8D5CFF0
        public void Gauge(){} // RVA: 0x7FFAF8D5D070
        public void Distribution(){} // RVA: 0x7FFAF8D5D0F0
        public void Set(){} // RVA: 0x7FFAF8D5D200 | overloaded x2
        public void Timing(){} // RVA: 0x7FFAF8D5D3F0
        public void StartTimer(){} // RVA: 0x7FFAF8D5D5B0
        public void Emit(){} // RVA: 0x7FFAF8D5D670
        public void GetOrAddTimeBucket(){} // RVA: 0x7FFAF8D5E160
        public void RecordCodeLocation(){} // RVA: 0x7FFAF8D5E550
        public void GetCodeLocation(){} // RVA: 0x7FFAF8D5EEA0
        public void RunLoopAsync(){} // RVA: 0x7FFAF8D5EFD0
        public void FlushAsync(){} // RVA: 0x7FFAF8D5F190
        public void GetFlushableBuckets(){} // RVA: 0x7FFAF8D5F3D0
        public void FlushableLocations(){} // RVA: 0x7FFAF8D5F490
        public void ClearStaleLocations(){} // RVA: 0x7FFAF8D5F5F0
        public void DisposeAsync(){} // RVA: 0x7FFAF8D5F8E0
        public void Dispose(){} // RVA: 0x7FFAF8D5FA70
    }

    public class MetricHelper
    {
        // ── Methods ──
        public void GetDayBucketKey(){} // RVA: 0x7FFAF8D63B80
        public void GetTimeBucketKey(){} // RVA: 0x7FFAF8D63D70
        public void GetCutoff(){} // RVA: 0x7FFAF8D63E90
        public void SanitizeMetricKeyOrName(){} // RVA: 0x7FFAF8D64070
        public void SanitizeTagKey(){} // RVA: 0x7FFAF8D64210
        public void SanitizeMetricUnit(){} // RVA: 0x7FFAF8D643B0
        public void get_TagValueReplacements(){} // RVA: 0x7FFAF8D64550
        public void SanitizeTagValue(){} // RVA: 0x7FFAF8D645D0
        public void GetMetricBucketKey(){} // RVA: 0x7FFAF8D64860
        public void GetTagsKey(){} // RVA: 0x7FFAF8D64AA0
        public void .cctor(){} // RVA: 0x7FFAF8D64E80
        public void <GetTagsKey>g__EscapeString|21_0(){} // RVA: 0x7FFAF8D653E0
    }

    public class MetricsSummaryAggregator
    {
        public object Update;
        public object PauseTimestamp;

        // ── Methods ──
        public void get_LazyMeasurements(){} // RVA: 0x7FFAF2DA8380
        public void get_Measurements(){} // RVA: 0x7FFAF8D659E0
        public void Add(){} // RVA: 0x7FFAF8D65A30
        public void .ctor(){} // RVA: 0x7FFAF8D65EA0
    }

}