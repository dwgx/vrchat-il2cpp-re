// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 50

namespace ThirdParty.Sentry.Sentry
{
    public class MeasurementUnit : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81E75FA0 | overloaded x2
        public void Custom(){} // RVA: 0x7FFE86DEC2A0
        public void Parse(){} // RVA: 0x7FFE86DEC2E0
        public void ToString(){} // RVA: 0x7FFE86DEC8B0
        public void Equals(){} // RVA: 0x7FFE86DEC9D0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86DECAF0
        public void op_Equality(){} // RVA: 0x7FFE86DECC50
        public void op_Inequality(){} // RVA: 0x7FFE86DECD20
        public void op_Implicit(){} // RVA: 0x7FFE86DECEE0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE86DECF50
    }

    public class MetricAggregator : Object
    {
        public string DisposingMessage;

        // ── Methods ──
        public void get_Buckets(){} // RVA: 0x7FFE86DED020
        public void .ctor(){} // RVA: 0x7FFE86DED070
        public void Increment(){} // RVA: 0x7FFE86DEDA20
        public void Gauge(){} // RVA: 0x7FFE86DEDAA0
        public void Distribution(){} // RVA: 0x7FFE86DEDB20
        public void Set(){} // RVA: 0x7FFE86DEDC30 | overloaded x2
        public void Timing(){} // RVA: 0x7FFE86DEDE20
        public void StartTimer(){} // RVA: 0x7FFE86DEDFE0
        public void Emit(){} // RVA: 0x7FFE86DEE0A0
        public void GetOrAddTimeBucket(){} // RVA: 0x7FFE86DEEB90
        public void RecordCodeLocation(){} // RVA: 0x7FFE86DEEF80
        public void GetCodeLocation(){} // RVA: 0x7FFE86DEF8D0
        public void RunLoopAsync(){} // RVA: 0x7FFE86DEFA00
        public void FlushAsync(){} // RVA: 0x7FFE86DEFBC0
        public void GetFlushableBuckets(){} // RVA: 0x7FFE86DEFE00
        public void FlushableLocations(){} // RVA: 0x7FFE86DEFEC0
        public void ClearStaleLocations(){} // RVA: 0x7FFE86DF0020
        public void DisposeAsync(){} // RVA: 0x7FFE86DF0310
        public void Dispose(){} // RVA: 0x7FFE86DF04A0
    }

    public class MetricHelper : Object
    {
        public Sentry.Internal.RandomValuesFactory Random;

        // ── Methods ──
        public void GetDayBucketKey(){} // RVA: 0x7FFE86DF45B0
        public void GetTimeBucketKey(){} // RVA: 0x7FFE86DF47A0
        public void GetCutoff(){} // RVA: 0x7FFE86DF48C0
        public void SanitizeMetricKeyOrName(){} // RVA: 0x7FFE86DF4AA0
        public void SanitizeTagKey(){} // RVA: 0x7FFE86DF4C40
        public void SanitizeMetricUnit(){} // RVA: 0x7FFE86DF4DE0
        public void get_TagValueReplacements(){} // RVA: 0x7FFE86DF4F80
        public void SanitizeTagValue(){} // RVA: 0x7FFE86DF5000
        public void GetMetricBucketKey(){} // RVA: 0x7FFE86DF5290
        public void GetTagsKey(){} // RVA: 0x7FFE86DF54D0
        public void .cctor(){} // RVA: 0x7FFE86DF58B0
        public void <GetTagsKey>g__EscapeString|21_0(){} // RVA: 0x7FFE86DF5E10
    }

    public class MetricsSummaryAggregator : Object
    {
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentDictionary`2<string,Sentry.Protocol.Metrics.SpanMetric>> _lazyMeasurements; // 0x10
        public object field_1; // 0x7D

        // ── Methods ──
        public void get_LazyMeasurements(){} // RVA: 0x7FFE81116380
        public void get_Measurements(){} // RVA: 0x7FFE86DF6410
        public void Add(){} // RVA: 0x7FFE86DF6460
        public void .ctor(){} // RVA: 0x7FFE86DF68D0
    }

}