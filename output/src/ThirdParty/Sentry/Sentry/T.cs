// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 98

namespace ThirdParty.Sentry.Sentry
{
    public class Timing
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E77730
        public void Dispose(){} // RVA: 0x7FFAF8E77C00
        public void DisposeInternal(){} // RVA: 0x7FFAF8E77C50
    }

    public class TransactionContext
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2E2B370
        public void set_Name(){} // RVA: 0x7FFAF2E2B380
        public void get_NameSource(){} // RVA: 0x7FFAF4741440
        public void set_NameSource(){} // RVA: 0x7FFAF4741450
        public void get_IsParentSampled(){} // RVA: 0x7FFAF8E78170
        public void .ctor(){} // RVA: 0x7FFAF8E78280 | overloaded x2
    }

    public class TransactionNameSourceExtensions
    {
        // ── Methods ──
        public void IsHighQuality(){} // RVA: 0x7FFAF8E78480
    }

    public class TransactionSamplingContext
    {
        public object TrackedSpans;

        // ── Methods ──
        public void get_TransactionContext(){} // RVA: 0x7FFAF2DA8380
        public void get_CustomSamplingContext(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
    }

    public class TransactionTracer
    {
        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7FFAF8E78490
        public void get_SpanId(){} // RVA: 0x7FFAF8E784A0
        public void set_SpanId(){} // RVA: 0x7FFAF8E78510
        public void get_ParentSpanId(){} // RVA: 0x7FFAF6C90130
        public void get_TraceId(){} // RVA: 0x7FFAF8E78590
        public void set_TraceId(){} // RVA: 0x7FFAF8E78620
        public void get_Name(){} // RVA: 0x7FFAF2E2B370
        public void set_Name(){} // RVA: 0x7FFAF2E2B380
        public void get_NameSource(){} // RVA: 0x7FFAF4741440
        public void set_NameSource(){} // RVA: 0x7FFAF4741450
        public void get_IsParentSampled(){} // RVA: 0x7FFAF8E78170
        public void set_IsParentSampled(){} // RVA: 0x7FFAF8E786A0
        public void get_Platform(){} // RVA: 0x7FFAF2E55590
        public void set_Platform(){} // RVA: 0x7FFAF2E555A0
        public void get_Release(){} // RVA: 0x7FFAF2F77C50
        public void set_Release(){} // RVA: 0x7FFAF2F734F0
        public void get_Distribution(){} // RVA: 0x7FFAF2F12D00
        public void set_Distribution(){} // RVA: 0x7FFAF2F14450
        public void get_StartTimestamp(){} // RVA: 0x7FFAF821C5E0
        public void set_StartTimestamp(){} // RVA: 0x7FFAF821C5F0
        public void get_EndTimestamp(){} // RVA: 0x7FFAF8E786B0
        public void set_EndTimestamp(){} // RVA: 0x7FFAF8E786D0
        public void get_Operation(){} // RVA: 0x7FFAF8E786F0
        public void set_Operation(){} // RVA: 0x7FFAF8E78760
        public void get_Description(){} // RVA: 0x7FFAF2DF8040
        public void set_Description(){} // RVA: 0x7FFAF2DF8050
        public void get_Status(){} // RVA: 0x7FFAF8E78830
        public void set_Status(){} // RVA: 0x7FFAF8E788A0
        public void get_IsSampled(){} // RVA: 0x7FFAF8E78920
        public void set_IsSampled(){} // RVA: 0x7FFAF8E78990
        public void get_SampleRate(){} // RVA: 0x7FFAF3FCA080
        public void set_SampleRate(){} // RVA: 0x7FFAF8E78AC0
        public void get_Level(){} // RVA: 0x7FFAF34B02A0
        public void set_Level(){} // RVA: 0x7FFAF639ED60
        public void get_Request(){} // RVA: 0x7FFAF8E78AD0
        public void set_Request(){} // RVA: 0x7FFAF2EAA110
        public void get_Contexts(){} // RVA: 0x7FFAF3546D30
        public void set_Contexts(){} // RVA: 0x7FFAF8E78B70
        public void get_User(){} // RVA: 0x7FFAF8E78BA0
        public void set_User(){} // RVA: 0x7FFAF2E0E910
        public void get_Environment(){} // RVA: 0x7FFAF2E0E970
        public void set_Environment(){} // RVA: 0x7FFAF2E0E980
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7FFAF2E2B370
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7FFAF8E78C40
        public void get_Sdk(){} // RVA: 0x7FFAF2DF82A0
        public void set_Sdk(){} // RVA: 0x7FFAF2DF82B0
        public void get_Fingerprint(){} // RVA: 0x7FFAF8E78CF0
        public void set_Fingerprint(){} // RVA: 0x7FFAF30ED280
        public void get_Breadcrumbs(){} // RVA: 0x7FFAF3544E10
        public void get_Extra(){} // RVA: 0x7FFAF35402E0
        public void get_Tags(){} // RVA: 0x7FFAF2FB7710
        public void get_Spans(){} // RVA: 0x7FFAF2FB7D10
        public void get_Measurements(){} // RVA: 0x7FFAF304E660
        public void get_MetricsSummary(){} // RVA: 0x7FFAF8E78D40
        public void get_HasMetrics(){} // RVA: 0x7FFAF8E78D90
        public void get_IsFinished(){} // RVA: 0x7FFAF8E78DF0
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFAF353E870
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFAF3853F70
        public void get_TransactionProfiler(){} // RVA: 0x7FFAF35433D0
        public void set_TransactionProfiler(){} // RVA: 0x7FFAF3546DC0
        public void get_IsSentryRequest(){} // RVA: 0x7FFAF4741A70
        public void set_IsSentryRequest(){} // RVA: 0x7FFAF8E78E30
        public void .ctor(){} // RVA: 0x7FFAF8E796E0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8E7A260
        public void SetExtra(){} // RVA: 0x7FFAF8E7A2C0
        public void SetTag(){} // RVA: 0x7FFAF8E7A330
        public void UnsetTag(){} // RVA: 0x7FFAF8E7A3A0
        public void SetMeasurement(){} // RVA: 0x7FFAF8E7A470
        public void StartChild(){} // RVA: 0x7FFAF8E7A540 | overloaded x2
        public void AddChildSpan(){} // RVA: 0x7FFAF8E7A7E0
        public void GetLastActiveSpan(){} // RVA: 0x7FFAF8E7A8E0
        public void Finish(){} // RVA: 0x7FFAF8E7AF20 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x7FFAF8E7AFA0
        public void get_Origin(){} // RVA: 0x7FFAF8E7B090
        public void set_Origin(){} // RVA: 0x7FFAF8E7B100
        public void ReleaseSpans(){} // RVA: 0x7FFAF8E7B190
        public void <.ctor>b__133_0(){} // RVA: 0x7FFAF8E7B270
        public void <Finish>b__145_0(){} // RVA: 0x7FFAF8E7B390
    }

}