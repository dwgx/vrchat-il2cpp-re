// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 98

namespace ThirdParty.Sentry.Sentry
{
    public class Timing : Object
    {
        public string OperationName;
        public string MetricsOrigin;
        public Sentry.SentryOptions _options; // 0x10
        public Sentry.MetricAggregator _metricAggregator; // 0x18
        public string _key; // 0x20
        public 0x6B197BE8 _unit; // 0x28
        public System.Collections.Generic.IDictionary`2<string,string> _tags; // 0x30
        public System.Diagnostics.Stopwatch _stopwatch; // 0x38
        public Sentry.ISpan _span; // 0x40
        public System.DateTime _startTime; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B5EAF0
        public void Dispose(){} // RVA: 0x7FFAC8B5EFC0
        public void DisposeInternal(){} // RVA: 0x7FFAC8B5F010
    }

    public class TransactionContext : SpanContext
    {
        public string Name; // 0x60
        public 0x6B19A3C8 NameSource; // 0x68
        public System.Nullable`1<bool> IsParentSampled; // 0x6C

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2FBF370
        public void set_Name(){} // RVA: 0x7FFAC2FBF380
        public void get_NameSource(){} // RVA: 0x7FFAC47BAB50
        public void set_NameSource(){} // RVA: 0x7FFAC47BAB60
        public void get_IsParentSampled(){} // RVA: 0x7FFAC8B5F530
        public void .ctor(){} // RVA: 0x7FFAC8B5F640 | overloaded x2
    }

    public class TransactionNameSourceExtensions : Object
    {
        // ── Methods ──
        public void IsHighQuality(){} // RVA: 0x7FFAC8B5F840
    }

    public class TransactionSamplingContext : Object
    {
        public Sentry.ITransactionContext TransactionContext; // 0x10
        public System.Collections.Generic.IReadOnlyDictionary`2<string,object> CustomSamplingContext; // 0x18

        // ── Methods ──
        public void get_TransactionContext(){} // RVA: 0x7FFAC2F3C380
        public void get_CustomSamplingContext(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC34EC240
    }

    public class TransactionTracer : Object
    {
        public Sentry.IHub Sentry.IBaseTracer.IsOtelInstrumenter; // 0x10
        public Sentry.SentryOptions SpanId; // 0x18
        public System.Threading.Timer ParentSpanId; // 0x20
        public long TraceId; // 0x28
        public Sentry.Internal.SentryStopwatch Name; // 0x30
        public 0x6B197560 NameSource; // 0x48
        public System.Nullable`1<Sentry.SpanId> IsParentSampled; // 0x50
        public string Platform; // 0x60
        public 0x6B19A3C8 Release; // 0x68
        public System.Nullable`1<bool> Distribution; // 0x6C
        public string StartTimestamp; // 0x70
        public string EndTimestamp; // 0x78
        public string Operation; // 0x80
        public System.DateTimeOffset Description; // 0x88
        public System.Nullable`1<System.DateTimeOffset> Status; // 0x98
        public string IsSampled; // 0xB0
        public System.Nullable`1<double> SampleRate; // 0xB8
        public System.Nullable`1<0x6B198C68> Level; // 0xC8
        public Sentry.SentryRequest Request; // 0xD0
        public Sentry.SentryContexts Contexts; // 0xD8
        public Sentry.SentryUser User; // 0xE0
        public string Environment; // 0xE8
        public Sentry.SdkVersion Sentry.IEventLike.TransactionName; // 0xF0
        public System.Collections.Generic.IReadOnlyList`1<string> Sdk; // 0xF8
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.Breadcrumb> Fingerprint; // 0x100
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> Breadcrumbs; // 0x108
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> Extra; // 0x110
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.ISpan> Tags; // 0x118
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,Sentry.Protocol.Measurement> Spans; // 0x120
        public System.Lazy`1<Sentry.MetricsSummaryAggregator> Measurements; // 0x128
        public Sentry.DynamicSamplingContext MetricsSummary; // 0x130
        public Sentry.Internal.ITransactionProfiler HasMetrics; // 0x138
        public bool IsFinished; // 0x140
        public LastActiveSpanTracker DynamicSamplingContext; // 0x148

        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7FFAC8B5F850
        public void get_SpanId(){} // RVA: 0x7FFAC8B5F860
        public void set_SpanId(){} // RVA: 0x7FFAC8B5F8D0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC6AD4D90
        public void get_TraceId(){} // RVA: 0x7FFAC8B5F950
        public void set_TraceId(){} // RVA: 0x7FFAC8B5F9E0
        public void get_Name(){} // RVA: 0x7FFAC2FBF370
        public void set_Name(){} // RVA: 0x7FFAC2FBF380
        public void get_NameSource(){} // RVA: 0x7FFAC47BAB50
        public void set_NameSource(){} // RVA: 0x7FFAC47BAB60
        public void get_IsParentSampled(){} // RVA: 0x7FFAC8B5F530
        public void set_IsParentSampled(){} // RVA: 0x7FFAC8B5FA60
        public void get_Platform(){} // RVA: 0x7FFAC2FE9590
        public void set_Platform(){} // RVA: 0x7FFAC2FE95A0
        public void get_Release(){} // RVA: 0x7FFAC30E5600
        public void set_Release(){} // RVA: 0x7FFAC30E06F0
        public void get_Distribution(){} // RVA: 0x7FFAC32EF410
        public void set_Distribution(){} // RVA: 0x7FFAC34D4AA0
        public void get_StartTimestamp(){} // RVA: 0x7FFAC7DF99E0
        public void set_StartTimestamp(){} // RVA: 0x7FFAC7DF99F0
        public void get_EndTimestamp(){} // RVA: 0x7FFAC8B5FA70
        public void set_EndTimestamp(){} // RVA: 0x7FFAC8B5FA90
        public void get_Operation(){} // RVA: 0x7FFAC8B5FAB0
        public void set_Operation(){} // RVA: 0x7FFAC8B5FB20
        public void get_Description(){} // RVA: 0x7FFAC2F8C040
        public void set_Description(){} // RVA: 0x7FFAC2F8C050
        public void get_Status(){} // RVA: 0x7FFAC8B5FBF0
        public void set_Status(){} // RVA: 0x7FFAC8B5FC60
        public void get_IsSampled(){} // RVA: 0x7FFAC8B5FCE0
        public void set_IsSampled(){} // RVA: 0x7FFAC8B5FD50
        public void get_SampleRate(){} // RVA: 0x7FFAC3FA4E20
        public void set_SampleRate(){} // RVA: 0x7FFAC8B5FE80
        public void get_Level(){} // RVA: 0x7FFAC3641480
        public void set_Level(){} // RVA: 0x7FFAC623E970
        public void get_Request(){} // RVA: 0x7FFAC8B5FE90
        public void set_Request(){} // RVA: 0x7FFAC303E110
        public void get_Contexts(){} // RVA: 0x7FFAC3540F70
        public void set_Contexts(){} // RVA: 0x7FFAC8B5FF30
        public void get_User(){} // RVA: 0x7FFAC8B5FF60
        public void set_User(){} // RVA: 0x7FFAC2FA2910
        public void get_Environment(){} // RVA: 0x7FFAC2FA2970
        public void set_Environment(){} // RVA: 0x7FFAC2FA2980
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7FFAC2FBF370
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7FFAC8B60000
        public void get_Sdk(){} // RVA: 0x7FFAC2F8C2A0
        public void set_Sdk(){} // RVA: 0x7FFAC2F8C2B0
        public void get_Fingerprint(){} // RVA: 0x7FFAC8B600B0
        public void set_Fingerprint(){} // RVA: 0x7FFAC34A4860
        public void get_Breadcrumbs(){} // RVA: 0x7FFAC34F6C80
        public void get_Extra(){} // RVA: 0x7FFAC36D1F40
        public void get_Tags(){} // RVA: 0x7FFAC354B170
        public void get_Spans(){} // RVA: 0x7FFAC33BC6D0
        public void get_Measurements(){} // RVA: 0x7FFAC313CBB0
        public void get_MetricsSummary(){} // RVA: 0x7FFAC8B60100
        public void get_HasMetrics(){} // RVA: 0x7FFAC8B60150
        public void get_IsFinished(){} // RVA: 0x7FFAC8B601B0
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFAC3544340
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFAC39A79B0
        public void get_TransactionProfiler(){} // RVA: 0x7FFAC35422C0
        public void set_TransactionProfiler(){} // RVA: 0x7FFAC36D84B0
        public void get_IsSentryRequest(){} // RVA: 0x7FFAC47BB170
        public void set_IsSentryRequest(){} // RVA: 0x7FFAC8B601F0
        public void .ctor(){} // RVA: 0x7FFAC8B60AA0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8B61620
        public void SetExtra(){} // RVA: 0x7FFAC8B61680
        public void SetTag(){} // RVA: 0x7FFAC8B616F0
        public void UnsetTag(){} // RVA: 0x7FFAC8B61760
        public void SetMeasurement(){} // RVA: 0x7FFAC8B61830
        public void StartChild(){} // RVA: 0x7FFAC8B61900 | overloaded x2
        public void AddChildSpan(){} // RVA: 0x7FFAC8B61BA0
        public void GetLastActiveSpan(){} // RVA: 0x7FFAC8B61CA0
        public void Finish(){} // RVA: 0x7FFAC8B622E0 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x7FFAC8B62360
        public void get_Origin(){} // RVA: 0x7FFAC8B62450
        public void set_Origin(){} // RVA: 0x7FFAC8B624C0
        public void ReleaseSpans(){} // RVA: 0x7FFAC8B62550
        public void <.ctor>b__133_0(){} // RVA: 0x7FFAC8B62630
        public void <Finish>b__145_0(){} // RVA: 0x7FFAC8B62750
    }

}