// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 98

namespace ThirdParty.Sentry.Sentry
{
    public class Timing
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63C7730
        public void Dispose(){} // RVA: 0x63C7C00
        public void DisposeInternal(){} // RVA: 0x63C7C50
    }

    public class TransactionContext
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x37B370
        public void set_Name(){} // RVA: 0x37B380
        public void get_NameSource(){} // RVA: 0x1C91440
        public void set_NameSource(){} // RVA: 0x1C91450
        public void get_IsParentSampled(){} // RVA: 0x63C8170
        public void .ctor(){} // RVA: 0x63C8280 | overloaded x2
    }

    public class TransactionNameSourceExtensions
    {
        // ── Methods ──
        public void IsHighQuality(){} // RVA: 0x63C8480
    }

    public class TransactionSamplingContext
    {
        public object TrackedSpans;

        // ── Methods ──
        public void get_TransactionContext(){} // RVA: 0x2F8380
        public void get_CustomSamplingContext(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
    }

    public class TransactionTracer
    {
        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x63C8490
        public void get_SpanId(){} // RVA: 0x63C84A0
        public void set_SpanId(){} // RVA: 0x63C8510
        public void get_ParentSpanId(){} // RVA: 0x41E0130
        public void get_TraceId(){} // RVA: 0x63C8590
        public void set_TraceId(){} // RVA: 0x63C8620
        public void get_Name(){} // RVA: 0x37B370
        public void set_Name(){} // RVA: 0x37B380
        public void get_NameSource(){} // RVA: 0x1C91440
        public void set_NameSource(){} // RVA: 0x1C91450
        public void get_IsParentSampled(){} // RVA: 0x63C8170
        public void set_IsParentSampled(){} // RVA: 0x63C86A0
        public void get_Platform(){} // RVA: 0x3A5590
        public void set_Platform(){} // RVA: 0x3A55A0
        public void get_Release(){} // RVA: 0x4C7C50
        public void set_Release(){} // RVA: 0x4C34F0
        public void get_Distribution(){} // RVA: 0x462D00
        public void set_Distribution(){} // RVA: 0x464450
        public void get_StartTimestamp(){} // RVA: 0x576C5E0
        public void set_StartTimestamp(){} // RVA: 0x576C5F0
        public void get_EndTimestamp(){} // RVA: 0x63C86B0
        public void set_EndTimestamp(){} // RVA: 0x63C86D0
        public void get_Operation(){} // RVA: 0x63C86F0
        public void set_Operation(){} // RVA: 0x63C8760
        public void get_Description(){} // RVA: 0x348040
        public void set_Description(){} // RVA: 0x348050
        public void get_Status(){} // RVA: 0x63C8830
        public void set_Status(){} // RVA: 0x63C88A0
        public void get_IsSampled(){} // RVA: 0x63C8920
        public void set_IsSampled(){} // RVA: 0x63C8990
        public void get_SampleRate(){} // RVA: 0x151A080
        public void set_SampleRate(){} // RVA: 0x63C8AC0
        public void get_Level(){} // RVA: 0xA002A0
        public void set_Level(){} // RVA: 0x38EED60
        public void get_Request(){} // RVA: 0x63C8AD0
        public void set_Request(){} // RVA: 0x3FA110
        public void get_Contexts(){} // RVA: 0xA96D30
        public void set_Contexts(){} // RVA: 0x63C8B70
        public void get_User(){} // RVA: 0x63C8BA0
        public void set_User(){} // RVA: 0x35E910
        public void get_Environment(){} // RVA: 0x35E970
        public void set_Environment(){} // RVA: 0x35E980
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x37B370
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x63C8C40
        public void get_Sdk(){} // RVA: 0x3482A0
        public void set_Sdk(){} // RVA: 0x3482B0
        public void get_Fingerprint(){} // RVA: 0x63C8CF0
        public void set_Fingerprint(){} // RVA: 0x63D280
        public void get_Breadcrumbs(){} // RVA: 0xA94E10
        public void get_Extra(){} // RVA: 0xA902E0
        public void get_Tags(){} // RVA: 0x507710
        public void get_Spans(){} // RVA: 0x507D10
        public void get_Measurements(){} // RVA: 0x59E660
        public void get_MetricsSummary(){} // RVA: 0x63C8D40
        public void get_HasMetrics(){} // RVA: 0x63C8D90
        public void get_IsFinished(){} // RVA: 0x63C8DF0
        public void get_DynamicSamplingContext(){} // RVA: 0xA8E870
        public void set_DynamicSamplingContext(){} // RVA: 0xDA3F70
        public void get_TransactionProfiler(){} // RVA: 0xA933D0
        public void set_TransactionProfiler(){} // RVA: 0xA96DC0
        public void get_IsSentryRequest(){} // RVA: 0x1C91A70
        public void set_IsSentryRequest(){} // RVA: 0x63C8E30
        public void .ctor(){} // RVA: 0x63C96E0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x63CA260
        public void SetExtra(){} // RVA: 0x63CA2C0
        public void SetTag(){} // RVA: 0x63CA330
        public void UnsetTag(){} // RVA: 0x63CA3A0
        public void SetMeasurement(){} // RVA: 0x63CA470
        public void StartChild(){} // RVA: 0x63CA540 | overloaded x2
        public void AddChildSpan(){} // RVA: 0x63CA7E0
        public void GetLastActiveSpan(){} // RVA: 0x63CA8E0
        public void Finish(){} // RVA: 0x63CAF20 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x63CAFA0
        public void get_Origin(){} // RVA: 0x63CB090
        public void set_Origin(){} // RVA: 0x63CB100
        public void ReleaseSpans(){} // RVA: 0x63CB190
        public void <.ctor>b__133_0(){} // RVA: 0x63CB270
        public void <Finish>b__145_0(){} // RVA: 0x63CB390
    }

}