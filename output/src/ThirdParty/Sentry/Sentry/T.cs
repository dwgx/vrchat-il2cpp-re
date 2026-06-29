// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 91

namespace ThirdParty.Sentry.Sentry
{
    public class Timing : Object
    {
        public object OperationName;
        public object MetricsOrigin;
        public object _options;
        public object _metricAggregator;
        public object _key;
        public object _unit;
        public object _tags;
        public object _stopwatch;
        public object _span;
        public object _startTime;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E366C0
        public void Dispose(){} // RVA: 0x6E36BA0
        public void DisposeInternal(){} // RVA: 0x6E36BF0
    }

    public class TransactionContext : SpanContext
    {
        public object _name;
        public object _nameSource;
        public object _isParentSampled;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xBE2C60
        public void set_Name(){} // RVA: 0xBE2C70
        public void get_NameSource(){} // RVA: 0x2536460
        public void set_NameSource(){} // RVA: 0x25406E0
        public void get_IsParentSampled(){} // RVA: 0x4264D60
        public void .ctor(){} // RVA: 0x6E371F0
    }

    public class TransactionNameSourceExtensions : Object
    {
        // ── Methods ──
        public void IsHighQuality(){} // RVA: 0x6E37410
    }

    public class TransactionSamplingContext : Object
    {
        public object _transactionContext;
        public object _customSamplingContext;

        // ── Methods ──
        public void get_TransactionContext(){} // RVA: 0xB5DBF0
        public void get_CustomSamplingContext(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
    }

    public class TransactionTracer : Object
    {
        public object _hub;
        public object _options;
        public object _idleTimer;
        public object _cancelIdleTimeout;
        public object _stopwatch;
        public object _instrumenter;
        public object _parentSpanId;
        public object _name;
        public object _nameSource;
        public object _isParentSampled;
        public object _platform;
        public object _release;
        public object _distribution;
        public object _startTimestamp;
        public object _endTimestamp;
        public object _description;
        public object _sampleRate;
        public object _level;
        public object _request;
        public object _contexts;
        public object _user;
        public object _environment;
        public object _sdk;
        public object _fingerprint;
        public object _breadcrumbs;
        public object _extra;
        public object _tags;
        public object _spans;
        public object _measurements;
        public object _metricsSummary;
        public object _dynamicSamplingContext;
        public object _transactionProfiler;
        public object _isSentryRequest;
        public object _activeSpanTracker;

        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x6E37420
        public void get_SpanId(){} // RVA: 0x6E37430
        public void set_SpanId(){} // RVA: 0x6E374A0
        public void get_ParentSpanId(){} // RVA: 0x4CBDC80
        public void get_TraceId(){} // RVA: 0x6E37520
        public void set_TraceId(){} // RVA: 0x6E375B0
        public void get_Name(){} // RVA: 0xBE2C60
        public void set_Name(){} // RVA: 0xBE2C70
        public void get_NameSource(){} // RVA: 0x2536460
        public void set_NameSource(){} // RVA: 0x25406E0
        public void get_IsParentSampled(){} // RVA: 0x4264D60
        public void set_IsParentSampled(){} // RVA: 0x4264D70
        public void get_Platform(){} // RVA: 0xC10050
        public void set_Platform(){} // RVA: 0xC10060
        public void get_Release(){} // RVA: 0xCD3320
        public void set_Release(){} // RVA: 0xCD4740
        public void get_Distribution(){} // RVA: 0xCD48B0
        public void set_Distribution(){} // RVA: 0xCD3600
        public void get_StartTimestamp(){} // RVA: 0x6D099E0
        public void set_StartTimestamp(){} // RVA: 0x6D099F0
        public void get_EndTimestamp(){} // RVA: 0x6E37630
        public void set_EndTimestamp(){} // RVA: 0x6E37650
        public void get_Operation(){} // RVA: 0x6E37670
        public void set_Operation(){} // RVA: 0x6E376E0
        public void get_Description(){} // RVA: 0xBAE340
        public void set_Description(){} // RVA: 0xBAE350
        public void get_Status(){} // RVA: 0x6E377B0
        public void set_Status(){} // RVA: 0x6E37820
        public void get_IsSampled(){} // RVA: 0x6E378A0
        public void set_IsSampled(){} // RVA: 0x6E37910
        public void get_SampleRate(){} // RVA: 0x1DE61C0
        public void set_SampleRate(){} // RVA: 0x6E37A40
        public void get_Level(){} // RVA: 0x12CE7D0
        public void set_Level(){} // RVA: 0x421A240
        public void get_Request(){} // RVA: 0x6E37A50
        public void set_Request(){} // RVA: 0xC68EC0
        public void get_Contexts(){} // RVA: 0x135D730
        public void set_Contexts(){} // RVA: 0x6E37AF0
        public void get_User(){} // RVA: 0x6E37B20
        public void set_User(){} // RVA: 0xBC5B40
        public void get_Environment(){} // RVA: 0xBC5BA0
        public void set_Environment(){} // RVA: 0xBC5BB0
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0xBE2C60
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x6E37BC0
        public void get_Sdk(){} // RVA: 0xBAE5A0
        public void set_Sdk(){} // RVA: 0xBAE5B0
        public void get_Fingerprint(){} // RVA: 0x6E37C70
        public void set_Fingerprint(){} // RVA: 0xEC0BB0
        public void get_Breadcrumbs(){} // RVA: 0x10B4170
        public void get_Extra(){} // RVA: 0x10B9D50
        public void get_Tags(){} // RVA: 0xD9E3D0
        public void get_Spans(){} // RVA: 0xDA0520
        public void get_Measurements(){} // RVA: 0x114AC20
        public void get_MetricsSummary(){} // RVA: 0x6E37CC0
        public void get_HasMetrics(){} // RVA: 0x6E37D10
        public void get_IsFinished(){} // RVA: 0x6E37D70
        public void get_DynamicSamplingContext(){} // RVA: 0x135EDB0
        public void set_DynamicSamplingContext(){} // RVA: 0x1658000
        public void get_TransactionProfiler(){} // RVA: 0x135A170
        public void set_TransactionProfiler(){} // RVA: 0x1365A40
        public void get_IsSentryRequest(){} // RVA: 0x6E37DB0
        public void set_IsSentryRequest(){} // RVA: 0x6E37DC0
        public void .ctor(){} // RVA: 0x6E38690
        public void AddBreadcrumb(){} // RVA: 0x6E39220
        public void SetExtra(){} // RVA: 0x6E39280
        public void SetTag(){} // RVA: 0x6E392F0
        public void UnsetTag(){} // RVA: 0x6E39360
        public void SetMeasurement(){} // RVA: 0x6E39430
        public void StartChild(){} // RVA: 0x6E39500
        public void AddChildSpan(){} // RVA: 0x6E397A0
        public void GetLastActiveSpan(){} // RVA: 0x6E398A0
        public void Finish(){} // RVA: 0x6E39F60
        public void GetTraceHeader(){} // RVA: 0x6E39FE0
        public void get_Origin(){} // RVA: 0x6E3A0D0
        public void set_Origin(){} // RVA: 0x6E3A140
        public void ReleaseSpans(){} // RVA: 0x6E3A1D0
        public void <.ctor>b__133_0(){} // RVA: 0x6E3A2B0
        public void <Finish>b__145_0(){} // RVA: 0x6E3A3B0
    }

}