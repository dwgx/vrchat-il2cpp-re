// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 4
// Methods: 50

namespace ThirdParty.Sentry.Sentry
{
    public class MeasurementUnit : ValueType
    {
        public System.Enum _unit; // 0x10
        public string _name; // 0x18
        public Sentry.MeasurementUnit None;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3BB08E0 | overloaded x2
        public void Custom(){} // RVA: 0x7FFAC8A42C10
        public void Parse(){} // RVA: 0x7FFAC8A42C50
        public void ToString(){} // RVA: 0x7FFAC8A43220
        public void Equals(){} // RVA: 0x7FFAC8A43340 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8A43460
        public void op_Equality(){} // RVA: 0x7FFAC8A435C0
        public void op_Inequality(){} // RVA: 0x7FFAC8A43690
        public void op_Implicit(){} // RVA: 0x7FFAC8A43850 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC8A438C0
    }

    public class MetricAggregator : Object
    {
        public string Buckets;
        public string AlreadyDisposedMessage;
        public string CancelledMessage;
        public string ShutdownScheduledMessage;
        public string ShutdownImmediatelyMessage;
        public string FlushShutdownMessage;
        public Sentry.SentryOptions _options; // 0x10
        public Sentry.IMetricHub _metricHub; // 0x18
        public System.Threading.SemaphoreSlim _codeLocationLock; // 0x20
        public System.Threading.ReaderWriterLockSlim _bucketsLock; // 0x28
        public System.Threading.CancellationTokenSource _shutdownSource; // 0x30
        public bool _disposed; // 0x38
        public System.Lazy`1<System.Collections.Generic.Dictionary`2<long,System.Collections.Concurrent.ConcurrentDictionary`2<string,Sentry.Protocol.Metrics.Metric>>> _buckets; // 0x40
        public long _lastClearedStaleLocations; // 0x48
        public System.Collections.Concurrent.ConcurrentDictionary`2<long,System.Collections.Generic.HashSet`1<Sentry.Protocol.Metrics.MetricResourceIdentifier>> _seenLocations; // 0x50
        public System.Collections.Generic.Dictionary`2<long,System.Collections.Generic.Dictionary`2<Sentry.Protocol.Metrics.MetricResourceIdentifier,Sentry.SentryStackFrame>> _pendingLocations; // 0x58
        public System.Threading.Tasks.Task _loopTask; // 0x60
        public System.Threading.SemaphoreSlim _flushLock; // 0x68

        // ── Methods ──
        public void get_Buckets(){} // RVA: 0x7FFAC8A43990
        public void .ctor(){} // RVA: 0x7FFAC8A439E0
        public void Increment(){} // RVA: 0x7FFAC8A44390
        public void Gauge(){} // RVA: 0x7FFAC8A44410
        public void Distribution(){} // RVA: 0x7FFAC8A44490
        public void Set(){} // RVA: 0x7FFAC8A445A0 | overloaded x2
        public void Timing(){} // RVA: 0x7FFAC8A44790
        public void StartTimer(){} // RVA: 0x7FFAC8A44950
        public void Emit(){} // RVA: 0x7FFAC8A44A10
        public void GetOrAddTimeBucket(){} // RVA: 0x7FFAC8A45500
        public void RecordCodeLocation(){} // RVA: 0x7FFAC8A458F0
        public void GetCodeLocation(){} // RVA: 0x7FFAC8A46240
        public void RunLoopAsync(){} // RVA: 0x7FFAC8A46370
        public void FlushAsync(){} // RVA: 0x7FFAC8A46530
        public void GetFlushableBuckets(){} // RVA: 0x7FFAC8A46770
        public void FlushableLocations(){} // RVA: 0x7FFAC8A46830
        public void ClearStaleLocations(){} // RVA: 0x7FFAC8A46990
        public void DisposeAsync(){} // RVA: 0x7FFAC8A46C80
        public void Dispose(){} // RVA: 0x7FFAC8A46E10
    }

    public class MetricHelper : Object
    {
        public Sentry.Internal.RandomValuesFactory TagValueReplacements;
        public int RollupInSeconds;
        public string InvalidMetricKeyOrNameCharactersPattern;
        public string InvalidTagKeyCharactersPattern;
        public string InvalidMetricUnitCharactersPattern;
        public System.DateTimeOffset UnixEpoch; // 0x8
        public double FlushShift; // 0x18
        public System.Text.RegularExpressions.Regex InvalidMetricKeyOrNameCharacters; // 0x20
        public System.Text.RegularExpressions.Regex InvalidTagKeyCharacters; // 0x28
        public System.Text.RegularExpressions.Regex InvalidMetricUnitCharacters; // 0x30
        public System.Lazy`1<System.Collections.Generic.KeyValuePair`2<string,string>[]> LazyTagValueReplacements; // 0x38

        // ── Methods ──
        public void GetDayBucketKey(){} // RVA: 0x7FFAC8A4AF20
        public void GetTimeBucketKey(){} // RVA: 0x7FFAC8A4B110
        public void GetCutoff(){} // RVA: 0x7FFAC8A4B230
        public void SanitizeMetricKeyOrName(){} // RVA: 0x7FFAC8A4B410
        public void SanitizeTagKey(){} // RVA: 0x7FFAC8A4B5B0
        public void SanitizeMetricUnit(){} // RVA: 0x7FFAC8A4B750
        public void get_TagValueReplacements(){} // RVA: 0x7FFAC8A4B8F0
        public void SanitizeTagValue(){} // RVA: 0x7FFAC8A4B970
        public void GetMetricBucketKey(){} // RVA: 0x7FFAC8A4BC00
        public void GetTagsKey(){} // RVA: 0x7FFAC8A4BE40
        public void .cctor(){} // RVA: 0x7FFAC8A4C220
        public void <GetTagsKey>g__EscapeString|21_0(){} // RVA: 0x7FFAC8A4C780
    }

    public class MetricsSummaryAggregator : Object
    {
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentDictionary`2<string,Sentry.Protocol.Metrics.SpanMetric>> LazyMeasurements; // 0x10

        // ── Methods ──
        public void get_LazyMeasurements(){} // RVA: 0x7FFAC2F3C380
        public void get_Measurements(){} // RVA: 0x7FFAC8A4CD80
        public void Add(){} // RVA: 0x7FFAC8A4CDD0
        public void .ctor(){} // RVA: 0x7FFAC8A4D240
    }

}