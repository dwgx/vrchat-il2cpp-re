// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 91

namespace ThirdParty.Sentry.Sentry
{
    public class Timing : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1B4C40
        public void Dispose(){} // RVA: 0x7AE1B5120
        public void DisposeInternal(){} // RVA: 0x7AE1B5170
    }

    public class TransactionContext : SpanContext
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A8175DF0
        public void set_Name(){} // RVA: 0x7A8175E00
        public void get_NameSource(){} // RVA: 0x7A9A93870
        public void set_NameSource(){} // RVA: 0x7A9A93880
        public void get_IsParentSampled(){} // RVA: 0x7AE1B5670
        public void .ctor(){} // RVA: 0x7AE1B5780
    }

    public class TransactionNameSourceExtensions : Object
    {
        // ── Methods ──
        public void IsHighQuality(){} // RVA: 0x7AE1B59A0
    }

    public class TransactionSamplingContext : Object
    {
        // ── Methods ──
        public void get_TransactionContext(){} // RVA: 0x7A80F2570
        public void get_CustomSamplingContext(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
    }

    public class TransactionTracer : Object
    {
        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7AE1B59B0
        public void get_SpanId(){} // RVA: 0x7AE1B59C0
        public void set_SpanId(){} // RVA: 0x7AE1B5A30
        public void get_ParentSpanId(){} // RVA: 0x7ABFD09C0
        public void get_TraceId(){} // RVA: 0x7AE1B5AB0
        public void set_TraceId(){} // RVA: 0x7AE1B5B40
        public void get_Name(){} // RVA: 0x7A8175DF0
        public void set_Name(){} // RVA: 0x7A8175E00
        public void get_NameSource(){} // RVA: 0x7A9A93870
        public void set_NameSource(){} // RVA: 0x7A9A93880
        public void get_IsParentSampled(){} // RVA: 0x7AE1B5670
        public void set_IsParentSampled(){} // RVA: 0x7AE1B5BC0
        public void get_Platform(){} // RVA: 0x7A81A00E0
        public void set_Platform(){} // RVA: 0x7A81A00F0
        public void get_Release(){} // RVA: 0x7A82C2060
        public void set_Release(){} // RVA: 0x7A82C0530
        public void get_Distribution(){} // RVA: 0x7A825E100
        public void set_Distribution(){} // RVA: 0x7A825F860
        public void get_StartTimestamp(){} // RVA: 0x7AD53B5F0
        public void set_StartTimestamp(){} // RVA: 0x7AD53B600
        public void get_EndTimestamp(){} // RVA: 0x7AE1B5BD0
        public void set_EndTimestamp(){} // RVA: 0x7AE1B5BF0
        public void get_Operation(){} // RVA: 0x7AE1B5C10
        public void set_Operation(){} // RVA: 0x7AE1B5C80
        public void get_Description(){} // RVA: 0x7A8142610
        public void set_Description(){} // RVA: 0x7A8142620
        public void get_Status(){} // RVA: 0x7AE1B5D50
        public void set_Status(){} // RVA: 0x7AE1B5DC0
        public void get_IsSampled(){} // RVA: 0x7AE1B5E40
        public void set_IsSampled(){} // RVA: 0x7AE1B5EB0
        public void get_SampleRate(){} // RVA: 0x7A92AE240
        public void set_SampleRate(){} // RVA: 0x7AE1B5FE0
        public void get_Level(){} // RVA: 0x7A87BD4F0
        public void set_Level(){} // RVA: 0x7AB6D7260
        public void get_Request(){} // RVA: 0x7AE1B5FF0
        public void set_Request(){} // RVA: 0x7A81F5100
        public void get_Contexts(){} // RVA: 0x7A8854870
        public void set_Contexts(){} // RVA: 0x7AE1B6090
        public void get_User(){} // RVA: 0x7AE1B60C0
        public void set_User(){} // RVA: 0x7A8158F60
        public void get_Environment(){} // RVA: 0x7A8158FC0
        public void set_Environment(){} // RVA: 0x7A8158FD0
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7A8175DF0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7AE1B6160
        public void get_Sdk(){} // RVA: 0x7A8142870
        public void set_Sdk(){} // RVA: 0x7A8142880
        public void get_Fingerprint(){} // RVA: 0x7AE1B6210
        public void set_Fingerprint(){} // RVA: 0x7A84442D0
        public void get_Breadcrumbs(){} // RVA: 0x7A8852A30
        public void get_Extra(){} // RVA: 0x7A884DED0
        public void get_Tags(){} // RVA: 0x7A884F050
        public void get_Spans(){} // RVA: 0x7A864CFF0
        public void get_Measurements(){} // RVA: 0x7A8357A90
        public void get_MetricsSummary(){} // RVA: 0x7AE1B6260
        public void get_HasMetrics(){} // RVA: 0x7AE1B62B0
        public void get_IsFinished(){} // RVA: 0x7AE1B6310
        public void get_DynamicSamplingContext(){} // RVA: 0x7A884C460
        public void set_DynamicSamplingContext(){} // RVA: 0x7A8B68960
        public void get_TransactionProfiler(){} // RVA: 0x7A8850FF0
        public void set_TransactionProfiler(){} // RVA: 0x7A8854900
        public void get_IsSentryRequest(){} // RVA: 0x7A9A94070
        public void set_IsSentryRequest(){} // RVA: 0x7AE1B6350
        public void .ctor(){} // RVA: 0x7AE1B6C20
        public void AddBreadcrumb(){} // RVA: 0x7AE1B77B0
        public void SetExtra(){} // RVA: 0x7AE1B7810
        public void SetTag(){} // RVA: 0x7AE1B7880
        public void UnsetTag(){} // RVA: 0x7AE1B78F0
        public void SetMeasurement(){} // RVA: 0x7AE1B79C0
        public void StartChild(){} // RVA: 0x7AE1B7A90
        public void AddChildSpan(){} // RVA: 0x7AE1B7D30
        public void GetLastActiveSpan(){} // RVA: 0x7AE1B7E30
        public void Finish(){} // RVA: 0x7AE1B84F0
        public void GetTraceHeader(){} // RVA: 0x7AE1B8570
        public void get_Origin(){} // RVA: 0x7AE1B8660
        public void set_Origin(){} // RVA: 0x7AE1B86D0
        public void ReleaseSpans(){} // RVA: 0x7AE1B8760
        public void <.ctor>b__133_0(){} // RVA: 0x7AE1B8840
        public void <Finish>b__145_0(){} // RVA: 0x7AE1B8940
    }

}