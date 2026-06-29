// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 45

namespace ThirdParty.Sentry.Sentry
{
    public class MeasurementUnit : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A763CB70
        public void Custom(){} // RVA: 0x7AE097710
        public void Parse(){} // RVA: 0x7AE097750
        public void ToString(){} // RVA: 0x7A7E683D0
        public void Equals(){} // RVA: 0x7A7E68480
        public void GetHashCode(){} // RVA: 0x7A7E68490
        public void op_Equality(){} // RVA: 0x7AE0980C0
        public void op_Inequality(){} // RVA: 0x7AE098190
        public void op_Implicit(){} // RVA: 0x7AE098350
        public void .cctor(){} // RVA: 0x7AE0983C0
    }

    public class MetricAggregator : Object
    {
        // ── Methods ──
        public void get_Buckets(){} // RVA: 0x7AE098490
        public void .ctor(){} // RVA: 0x7AE0984E0
        public void Increment(){} // RVA: 0x7AE098E90
        public void Gauge(){} // RVA: 0x7AE098F10
        public void Distribution(){} // RVA: 0x7AE098F90
        public void Set(){} // RVA: 0x7AE0990A0
        public void Timing(){} // RVA: 0x7AE099290
        public void StartTimer(){} // RVA: 0x7AE099450
        public void Emit(){} // RVA: 0x7AE099510
        public void GetOrAddTimeBucket(){} // RVA: 0x7AE099FE0
        public void RecordCodeLocation(){} // RVA: 0x7AE09A3D0
        public void GetCodeLocation(){} // RVA: 0x7AE09AD50
        public void RunLoopAsync(){} // RVA: 0x7AE09AE80
        public void FlushAsync(){} // RVA: 0x7AE09B040
        public void GetFlushableBuckets(){} // RVA: 0x7AE09B280
        public void FlushableLocations(){} // RVA: 0x7AE09B340
        public void ClearStaleLocations(){} // RVA: 0x7AE09B4A0
        public void DisposeAsync(){} // RVA: 0x7AE09B7A0
        public void Dispose(){} // RVA: 0x7AE09B930
    }

    public class MetricHelper : Object
    {
        // ── Methods ──
        public void GetDayBucketKey(){} // RVA: 0x7AE09FA20
        public void GetTimeBucketKey(){} // RVA: 0x7AE09FC10
        public void GetCutoff(){} // RVA: 0x7AE09FD30
        public void SanitizeMetricKeyOrName(){} // RVA: 0x7AE09FF10
        public void SanitizeTagKey(){} // RVA: 0x7AE0A00B0
        public void SanitizeMetricUnit(){} // RVA: 0x7AE0A0250
        public void get_TagValueReplacements(){} // RVA: 0x7AE0A03F0
        public void SanitizeTagValue(){} // RVA: 0x7AE0A0470
        public void GetMetricBucketKey(){} // RVA: 0x7AE0A0710
        public void GetTagsKey(){} // RVA: 0x7AE0A0950
        public void .cctor(){} // RVA: 0x7AE0A0D30
        public void <GetTagsKey>g__EscapeString|21_0(){} // RVA: 0x7AE0A1290
    }

    public class MetricsSummaryAggregator : Object
    {
        // ── Methods ──
        public void get_LazyMeasurements(){} // RVA: 0x7A80F2570
        public void get_Measurements(){} // RVA: 0x7AE0A1890
        public void Add(){} // RVA: 0x7AE0A18E0
        public void .ctor(){} // RVA: 0x7AE0A1D50
    }

}