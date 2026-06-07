// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 50

namespace ThirdParty.Sentry.Sentry
{
    public class MeasurementUnit
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1102780 | overloaded x2
        public void Custom(){} // RVA: 0x62AB870
        public void Parse(){} // RVA: 0x62AB8B0
        public void ToString(){} // RVA: 0x62ABE80
        public void Equals(){} // RVA: 0x62ABFA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x62AC0C0
        public void op_Equality(){} // RVA: 0x62AC220
        public void op_Inequality(){} // RVA: 0x62AC2F0
        public void op_Implicit(){} // RVA: 0x62AC4B0 | overloaded x3
        public void .cctor(){} // RVA: 0x62AC520
    }

    public class MetricAggregator
    {
        // ── Methods ──
        public void get_Buckets(){} // RVA: 0x62AC5F0
        public void .ctor(){} // RVA: 0x62AC640
        public void Increment(){} // RVA: 0x62ACFF0
        public void Gauge(){} // RVA: 0x62AD070
        public void Distribution(){} // RVA: 0x62AD0F0
        public void Set(){} // RVA: 0x62AD200 | overloaded x2
        public void Timing(){} // RVA: 0x62AD3F0
        public void StartTimer(){} // RVA: 0x62AD5B0
        public void Emit(){} // RVA: 0x62AD670
        public void GetOrAddTimeBucket(){} // RVA: 0x62AE160
        public void RecordCodeLocation(){} // RVA: 0x62AE550
        public void GetCodeLocation(){} // RVA: 0x62AEEA0
        public void RunLoopAsync(){} // RVA: 0x62AEFD0
        public void FlushAsync(){} // RVA: 0x62AF190
        public void GetFlushableBuckets(){} // RVA: 0x62AF3D0
        public void FlushableLocations(){} // RVA: 0x62AF490
        public void ClearStaleLocations(){} // RVA: 0x62AF5F0
        public void DisposeAsync(){} // RVA: 0x62AF8E0
        public void Dispose(){} // RVA: 0x62AFA70
    }

    public class MetricHelper
    {
        // ── Methods ──
        public void GetDayBucketKey(){} // RVA: 0x62B3B80
        public void GetTimeBucketKey(){} // RVA: 0x62B3D70
        public void GetCutoff(){} // RVA: 0x62B3E90
        public void SanitizeMetricKeyOrName(){} // RVA: 0x62B4070
        public void SanitizeTagKey(){} // RVA: 0x62B4210
        public void SanitizeMetricUnit(){} // RVA: 0x62B43B0
        public void get_TagValueReplacements(){} // RVA: 0x62B4550
        public void SanitizeTagValue(){} // RVA: 0x62B45D0
        public void GetMetricBucketKey(){} // RVA: 0x62B4860
        public void GetTagsKey(){} // RVA: 0x62B4AA0
        public void .cctor(){} // RVA: 0x62B4E80
        public void <GetTagsKey>g__EscapeString|21_0(){} // RVA: 0x62B53E0
    }

    public class MetricsSummaryAggregator
    {
        public object Update;
        public object PauseTimestamp;

        // ── Methods ──
        public void get_LazyMeasurements(){} // RVA: 0x2F8380
        public void get_Measurements(){} // RVA: 0x62B59E0
        public void Add(){} // RVA: 0x62B5A30
        public void .ctor(){} // RVA: 0x62B5EA0
    }

}