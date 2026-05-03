// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 98

namespace ThirdParty.Sentry.Sentry
{
    public class Timing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F08160
        public void Dispose(){} // RVA: 0x7FFE86F08630
        public void DisposeInternal(){} // RVA: 0x7FFE86F08680
    }

    public class TransactionContext : SpanContext
    {
        public string _name; // 0x60
        public 0x66593C8C _nameSource; // 0x68
        public System.Nullable`1<bool> _isParentSampled; // 0x6C

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81199370
        public void set_Name(){} // RVA: 0x7FFE81199380
        public void get_NameSource(){} // RVA: 0x7FFE82A22EF0
        public void set_NameSource(){} // RVA: 0x7FFE82A22F00
        public void get_IsParentSampled(){} // RVA: 0x7FFE86F08BA0
        public void .ctor(){} // RVA: 0x7FFE86F08CB0 | overloaded x2
    }

    public class TransactionNameSourceExtensions : Object
    {
        // ── Methods ──
        public void IsHighQuality(){} // RVA: 0x7FFE86F08EB0
    }

    public class TransactionSamplingContext : Object
    {
        public Sentry.ITransactionContext _transactionContext; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> _customSamplingContext; // 0x18

        // ── Methods ──
        public void get_TransactionContext(){} // RVA: 0x7FFE81116380
        public void get_CustomSamplingContext(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
    }

    public class TransactionTracer : Object
    {
        public Sentry.IHub _hub; // 0x10
        public Sentry.SentryOptions _options; // 0x18
        public System.Threading.Timer _idleTimer; // 0x20
        public long _cancelIdleTimeout; // 0x28
        public Sentry.Internal.SentryStopwatch _stopwatch; // 0x30
        public 0x66590E24 _instrumenter; // 0x48
        public System.Nullable`1<Sentry.SpanId> _parentSpanId; // 0x50
        public string _name; // 0x60
        public 0x66593C8C _nameSource; // 0x68
        public System.Nullable`1<bool> _isParentSampled; // 0x6C
        public string _platform; // 0x70
        public string _release; // 0x78
        public string _distribution; // 0x80
        public System.DateTimeOffset _startTimestamp; // 0x88
        public System.Nullable`1<System.DateTimeOffset> _endTimestamp; // 0x98
        public string _description; // 0xB0
        public System.Nullable`1<double> _sampleRate; // 0xB8
        public System.Nullable`1<0x6659252C> _level; // 0xC8
        public Sentry.SentryRequest _request; // 0xD0
        public Sentry.SentryContexts _contexts; // 0xD8
        public Sentry.SentryUser _user; // 0xE0
        public string _environment; // 0xE8
        public Sentry.SdkVersion _sdk; // 0xF0
        public System.Collections.Generic.IReadOnlyList`1<string> _fingerprint; // 0xF8
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.Breadcrumb> _breadcrumbs; // 0x100
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> _extra; // 0x108
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> _tags; // 0x110
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.ISpan> _spans; // 0x118
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Sentry.Protocol.Measurement> _measurements; // 0x120
        public System.Lazy`1<Sentry.MetricsSummaryAggregator> _metricsSummary; // 0x128
        public Sentry.DynamicSamplingContext _dynamicSamplingContext; // 0x130
        public Sentry.Internal.ITransactionProfiler _transactionProfiler; // 0x138
        public bool _isSentryRequest; // 0x140
        public LastActiveSpanTracker _activeSpanTracker; // 0x148
        public object field_34; // 0x1EE
        public object field_35; // 0x1EF
        public object field_36; // 0x1F0

        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7FFE86F08EC0
        public void get_SpanId(){} // RVA: 0x7FFE86F08ED0
        public void set_SpanId(){} // RVA: 0x7FFE86F08F40
        public void get_ParentSpanId(){} // RVA: 0x7FFE84E45FD0
        public void get_TraceId(){} // RVA: 0x7FFE86F08FC0
        public void set_TraceId(){} // RVA: 0x7FFE86F09050
        public void get_Name(){} // RVA: 0x7FFE81199370
        public void set_Name(){} // RVA: 0x7FFE81199380
        public void get_NameSource(){} // RVA: 0x7FFE82A22EF0
        public void set_NameSource(){} // RVA: 0x7FFE82A22F00
        public void get_IsParentSampled(){} // RVA: 0x7FFE86F08BA0
        public void set_IsParentSampled(){} // RVA: 0x7FFE86F090D0
        public void get_Platform(){} // RVA: 0x7FFE811C3590
        public void set_Platform(){} // RVA: 0x7FFE811C35A0
        public void get_Release(){} // RVA: 0x7FFE81463AE0
        public void set_Release(){} // RVA: 0x7FFE81464570
        public void get_Distribution(){} // RVA: 0x7FFE81280C30
        public void set_Distribution(){} // RVA: 0x7FFE81282380
        public void get_StartTimestamp(){} // RVA: 0x7FFE8621CDA0
        public void set_StartTimestamp(){} // RVA: 0x7FFE8621CDB0
        public void get_EndTimestamp(){} // RVA: 0x7FFE86F090E0
        public void set_EndTimestamp(){} // RVA: 0x7FFE86F09100
        public void get_Operation(){} // RVA: 0x7FFE86F09120
        public void set_Operation(){} // RVA: 0x7FFE86F09190
        public void get_Description(){} // RVA: 0x7FFE81166040
        public void set_Description(){} // RVA: 0x7FFE81166050
        public void get_Status(){} // RVA: 0x7FFE86F09260
        public void set_Status(){} // RVA: 0x7FFE86F092D0
        public void get_IsSampled(){} // RVA: 0x7FFE86F09350
        public void set_IsSampled(){} // RVA: 0x7FFE86F093C0
        public void get_SampleRate(){} // RVA: 0x7FFE822BDD60
        public void set_SampleRate(){} // RVA: 0x7FFE86F094F0
        public void get_Level(){} // RVA: 0x7FFE81790750
        public void set_Level(){} // RVA: 0x7FFE8453D840
        public void get_Request(){} // RVA: 0x7FFE86F09500
        public void set_Request(){} // RVA: 0x7FFE81218110
        public void get_Contexts(){} // RVA: 0x7FFE8181EA80
        public void set_Contexts(){} // RVA: 0x7FFE86F095A0
        public void get_User(){} // RVA: 0x7FFE86F095D0
        public void set_User(){} // RVA: 0x7FFE8117C910
        public void get_Environment(){} // RVA: 0x7FFE8117C970
        public void set_Environment(){} // RVA: 0x7FFE8117C980
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7FFE81199370
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7FFE86F09670
        public void get_Sdk(){} // RVA: 0x7FFE811662A0
        public void set_Sdk(){} // RVA: 0x7FFE811662B0
        public void get_Fingerprint(){} // RVA: 0x7FFE86F09720
        public void set_Fingerprint(){} // RVA: 0x7FFE81B0E4B0
        public void get_Breadcrumbs(){} // RVA: 0x7FFE81828B50
        public void get_Extra(){} // RVA: 0x7FFE8181E3D0
        public void get_Tags(){} // RVA: 0x7FFE81317980
        public void get_Spans(){} // RVA: 0x7FFE81318010
        public void get_Measurements(){} // RVA: 0x7FFE813A1DA0
        public void get_MetricsSummary(){} // RVA: 0x7FFE86F09770
        public void get_HasMetrics(){} // RVA: 0x7FFE86F097C0
        public void get_IsFinished(){} // RVA: 0x7FFE86F09820
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFE81823850
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFE81B31120
        public void get_TransactionProfiler(){} // RVA: 0x7FFE8181EA70
        public void set_TransactionProfiler(){} // RVA: 0x7FFE818254E0
        public void get_IsSentryRequest(){} // RVA: 0x7FFE82A23510
        public void set_IsSentryRequest(){} // RVA: 0x7FFE86F09860
        public void .ctor(){} // RVA: 0x7FFE86F0A110 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFE86F0AC90
        public void SetExtra(){} // RVA: 0x7FFE86F0ACF0
        public void SetTag(){} // RVA: 0x7FFE86F0AD60
        public void UnsetTag(){} // RVA: 0x7FFE86F0ADD0
        public void SetMeasurement(){} // RVA: 0x7FFE86F0AEA0
        public void StartChild(){} // RVA: 0x7FFE86F0AF70 | overloaded x2
        public void AddChildSpan(){} // RVA: 0x7FFE86F0B210
        public void GetLastActiveSpan(){} // RVA: 0x7FFE86F0B310
        public void Finish(){} // RVA: 0x7FFE86F0B950 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x7FFE86F0B9D0
        public void get_Origin(){} // RVA: 0x7FFE86F0BAC0
        public void set_Origin(){} // RVA: 0x7FFE86F0BB30
        public void ReleaseSpans(){} // RVA: 0x7FFE86F0BBC0
        public void <.ctor>b__133_0(){} // RVA: 0x7FFE86F0BCA0
        public void <Finish>b__145_0(){} // RVA: 0x7FFE86F0BDC0
    }

}