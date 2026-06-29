// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 45

namespace ThirdParty.Sentry.Sentry
{
    public class MeasurementUnit : ValueType
    {
        public object _unit;
        public object _name;
        public object None;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x54A40
        public void Custom(){} // RVA: 0x6D189F0
        public void Parse(){} // RVA: 0x6D18A30
        public void ToString(){} // RVA: 0x8E6E80
        public void Equals(){} // RVA: 0x8E6F30
        public void GetHashCode(){} // RVA: 0x8E6F40
        public void op_Equality(){} // RVA: 0x6D19390
        public void op_Inequality(){} // RVA: 0x6D19460
        public void op_Implicit(){} // RVA: 0x6D19620
        public void .cctor(){} // RVA: 0x6D19690
    }

    public class MetricAggregator : Object
    {
        public object DisposingMessage;
        public object AlreadyDisposedMessage;
        public object CancelledMessage;
        public object ShutdownScheduledMessage;
        public object ShutdownImmediatelyMessage;
        public object FlushShutdownMessage;
        public object _options;
        public object _metricHub;
        public object _codeLocationLock;
        public object _bucketsLock;
        public object _shutdownSource;
        public object _disposed;
        public object _buckets;
        public object _lastClearedStaleLocations;
        public object _seenLocations;
        public object _pendingLocations;
        public object _loopTask;
        public object _flushLock;

        // ── Methods ──
        public void get_Buckets(){} // RVA: 0x6D19760
        public void .ctor(){} // RVA: 0x6D197B0
        public void Increment(){} // RVA: 0x6D1A160
        public void Gauge(){} // RVA: 0x6D1A1E0
        public void Distribution(){} // RVA: 0x6D1A260
        public void Set(){} // RVA: 0x6D1A370
        public void Timing(){} // RVA: 0x6D1A560
        public void StartTimer(){} // RVA: 0x6D1A720
        public void Emit(){} // RVA: 0x6D1A7E0
        public void GetOrAddTimeBucket(){} // RVA: 0x6D1B2B0
        public void RecordCodeLocation(){} // RVA: 0x6D1B6A0
        public void GetCodeLocation(){} // RVA: 0x6D1C020
        public void RunLoopAsync(){} // RVA: 0x6D1C150
        public void FlushAsync(){} // RVA: 0x6D1C310
        public void GetFlushableBuckets(){} // RVA: 0x6D1C550
        public void FlushableLocations(){} // RVA: 0x6D1C610
        public void ClearStaleLocations(){} // RVA: 0x6D1C770
        public void DisposeAsync(){} // RVA: 0x6D1CA70
        public void Dispose(){} // RVA: 0x6D1CC00
    }

    public class MetricHelper : Object
    {
        public object Random;
        public object RollupInSeconds;
        public object InvalidMetricKeyOrNameCharactersPattern;
        public object InvalidTagKeyCharactersPattern;
        public object InvalidMetricUnitCharactersPattern;
        public object UnixEpoch;
        public object FlushShift;
        public object InvalidMetricKeyOrNameCharacters;
        public object InvalidTagKeyCharacters;
        public object InvalidMetricUnitCharacters;
        public object LazyTagValueReplacements;

        // ── Methods ──
        public void GetDayBucketKey(){} // RVA: 0x6D20BE0
        public void GetTimeBucketKey(){} // RVA: 0x6D20DD0
        public void GetCutoff(){} // RVA: 0x6D20EF0
        public void SanitizeMetricKeyOrName(){} // RVA: 0x6D210D0
        public void SanitizeTagKey(){} // RVA: 0x6D21270
        public void SanitizeMetricUnit(){} // RVA: 0x6D21410
        public void get_TagValueReplacements(){} // RVA: 0x6D215B0
        public void SanitizeTagValue(){} // RVA: 0x6D21630
        public void GetMetricBucketKey(){} // RVA: 0x6D218D0
        public void GetTagsKey(){} // RVA: 0x6D21B10
        public void .cctor(){} // RVA: 0x6D21EE0
        public void <GetTagsKey>g__EscapeString|21_0(){} // RVA: 0x6D22440
    }

    public class MetricsSummaryAggregator : Object
    {
        public object _lazyMeasurements;

        // ── Methods ──
        public void get_LazyMeasurements(){} // RVA: 0xB5DBF0
        public void get_Measurements(){} // RVA: 0x6D22A40
        public void Add(){} // RVA: 0x6D22A90
        public void .ctor(){} // RVA: 0x6D22F00
    }

}