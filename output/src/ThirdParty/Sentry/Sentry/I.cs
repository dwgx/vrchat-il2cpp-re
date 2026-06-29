// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 23
// Methods: 114

namespace ThirdParty.Sentry.Sentry
{
    public class IAttachmentContent
    {
        // ── Methods ──
        public void GetStream(){} // RVA: 0x7A7E00680
    }

    public class IBaseTracer
    {
        // ── Methods ──
        public void get_IsOtelInstrumenter(){} // RVA: 0x7A7E01900
    }

    public class IEventLike
    {
        // ── Methods ──
        public void get_Breadcrumbs(){} // RVA: 0x7A7E00680
        public void AddBreadcrumb(){} // RVA: 0x7A7E18800
        public void get_Distribution(){} // RVA: 0x7A7E00680
        public void set_Distribution(){} // RVA: 0x7A7E18800
        public void get_Level(){} // RVA: 0x7A7E00710
        public void set_Level(){} // RVA: 0x7A7E189D0
        public void get_Request(){} // RVA: 0x7A7E00680
        public void set_Request(){} // RVA: 0x7A7E18800
        public void get_Contexts(){} // RVA: 0x7A7E00680
        public void set_Contexts(){} // RVA: 0x7A7E18800
        public void get_User(){} // RVA: 0x7A7E00680
        public void set_User(){} // RVA: 0x7A7E18800
        public void get_Release(){} // RVA: 0x7A7E00680
        public void set_Release(){} // RVA: 0x7A7E18800
        public void get_Environment(){} // RVA: 0x7A7E00680
        public void set_Environment(){} // RVA: 0x7A7E18800
        public void get_TransactionName(){} // RVA: 0x7A7E00680
        public void set_TransactionName(){} // RVA: 0x7A7E18800
        public void get_Sdk(){} // RVA: 0x7A7E00680
        public void get_Fingerprint(){} // RVA: 0x7A7E00680
        public void set_Fingerprint(){} // RVA: 0x7A7E18800
    }

    public class IHasExtra
    {
        // ── Methods ──
        public void get_Extra(){} // RVA: 0x7A7E00680
        public void SetExtra(){} // RVA: 0x7A7E18890
    }

    public class IHasTags
    {
        // ── Methods ──
        public void get_Tags(){} // RVA: 0x7A7E00680
        public void SetTag(){} // RVA: 0x7A7E18890
        public void UnsetTag(){} // RVA: 0x7A7E18800
    }

    public class IHub
    {
        // ── Methods ──
        public void get_LastEventId(){} // RVA: 0x7A7E00490
        public void get_Metrics(){} // RVA: 0x7A7E00680
        public void StartTransaction(){} // RVA: 0x7A7E00BD0
        public void BindException(){} // RVA: 0x7A7E18890
        public void GetSpan(){} // RVA: 0x7A7E00680
        public void GetTraceHeader(){} // RVA: 0x7A7E00680
        public void GetBaggage(){} // RVA: 0x7A7E00680
        public void ContinueTrace(){} // RVA: 0x7A7E12DE0
        public void StartSession(){} // RVA: 0x7A7E18770
        public void PauseSession(){} // RVA: 0x7A7E18770
        public void ResumeSession(){} // RVA: 0x7A7E18770
        public void EndSession(){} // RVA: 0x7A7E189D0
        public void CaptureEvent(){} // RVA: 0x7A7E00630
    }

    public class IMetricAggregator
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7A8051B10
        public void Gauge(){} // RVA: 0x7A8051B10
        public void Distribution(){} // RVA: 0x7A8051B10
        public void Set(){} // RVA: 0x7A8051B10
        public void Timing(){} // RVA: 0x7A7E1F260
        public void StartTimer(){} // RVA: 0x7A8051B10
        public void FlushAsync(){} // RVA: 0x7A7E108B0
    }

    public class IMetricHub
    {
        // ── Methods ──
        public void CaptureMetrics(){} // RVA: 0x7A7E18800
        public void CaptureCodeLocations(){} // RVA: 0x7A7E18800
        public void StartSpan(){} // RVA: 0x7A7E00BD0
        public void GetSpan(){} // RVA: 0x7A7E00680
    }

    public class IScopeObserver
    {
        // ── Methods ──
        public void AddBreadcrumb(){} // RVA: 0x7A7E18800
        public void SetExtra(){} // RVA: 0x7A7E18890
        public void SetTag(){} // RVA: 0x7A7E18890
        public void UnsetTag(){} // RVA: 0x7A7E18800
        public void SetUser(){} // RVA: 0x7A7E18800
    }

    public class ISentryClient
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7A7E01900
        public void CaptureEnvelope(){} // RVA: 0x7A7E019D0
        public void CaptureEvent(){} // RVA: 0x7A7E00630
        public void CaptureUserFeedback(){} // RVA: 0x7A7E18800
        public void CaptureTransaction(){} // RVA: 0x7A7E1DDC0
        public void CaptureSession(){} // RVA: 0x7A7E18800
        public void CaptureCheckIn(){} // RVA: 0x7A7E15530
        public void FlushAsync(){} // RVA: 0x7A7E063E0
    }

    public class ISentryFailedRequestHandler
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7A7E18800
    }

    public class ISentryJsonSerializable
    {
        // ── Methods ──
        public void WriteTo(){} // RVA: 0x7A7E18890
    }

    public class ISentryScopeManager
    {
        // ── Methods ──
        public void ConfigureScope(){} // RVA: 0x7A7E18800
        public void ConfigureScopeAsync(){} // RVA: 0x7A7E00B20
        public void BindClient(){} // RVA: 0x7A7E18800
        public void PushScope(){} // RVA: 0x7A8051B10
    }

    public class ISentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7A7E18890
    }

    public class ISentrySession
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A7E00490
        public void get_DistinctId(){} // RVA: 0x7A7E00680
        public void get_StartTimestamp(){} // RVA: 0x7A7E00490
        public void get_Release(){} // RVA: 0x7A7E00680
        public void get_Environment(){} // RVA: 0x7A7E00680
        public void get_IpAddress(){} // RVA: 0x7A7E00680
        public void get_UserAgent(){} // RVA: 0x7A7E00680
        public void get_ErrorCount(){} // RVA: 0x7A7E00710
    }

    public class ISentryUserFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00680
    }

    public class ISessionManager
    {
        // ── Methods ──
        public void get_IsSessionActive(){} // RVA: 0x7A7E01900
        public void TryRecoverPersistedSession(){} // RVA: 0x7A7E00680
        public void StartSession(){} // RVA: 0x7A7E00680
        public void EndSession(){} // RVA: 0x7A7E00740
        public void PauseSession(){} // RVA: 0x7A7E18770
        public void ResumeSession(){} // RVA: 0x7A7E00680
        public void ReportError(){} // RVA: 0x7A7E00680
    }

    public class ISpan
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7A7E00680
        public void set_Description(){} // RVA: 0x7A7E18800
        public void get_Operation(){} // RVA: 0x7A7E00680
        public void set_Operation(){} // RVA: 0x7A7E18800
        public void get_Status(){} // RVA: 0x7A7E00680
        public void set_Status(){} // RVA: 0x7A7E188D0
        public void StartChild(){} // RVA: 0x7A7E00B20
        public void Finish(){} // RVA: 0x7A7E18800
    }

    public class ISpanData
    {
        // ── Methods ──
        public void get_StartTimestamp(){} // RVA: 0x7A7E00490
        public void get_EndTimestamp(){} // RVA: 0x7A7E00490
        public void get_IsFinished(){} // RVA: 0x7A7E01900
        public void GetTraceHeader(){} // RVA: 0x7A7E00680
        public void get_Measurements(){} // RVA: 0x7A7E00680
        public void SetMeasurement(){} // RVA: 0x7A7E18890
    }

    public class ITraceContextInternal
    {
        // ── Methods ──
        public void get_Origin(){} // RVA: 0x7A7E00680
    }

    public class ITransactionContext
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void get_IsParentSampled(){} // RVA: 0x7A7E006E0
        public void get_NameSource(){} // RVA: 0x7A7E00710
    }

    public class ITransactionData
    {
        // ── Methods ──
        public void get_Platform(){} // RVA: 0x7A7E00680
        public void set_Platform(){} // RVA: 0x7A7E18800
    }

    public class ITransactionTracer
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A7E00680
        public void set_Name(){} // RVA: 0x7A7E18800
        public void get_IsParentSampled(){} // RVA: 0x7A7E006E0
        public void set_IsParentSampled(){} // RVA: 0x7A7E18950
        public void get_Spans(){} // RVA: 0x7A7E00680
        public void GetLastActiveSpan(){} // RVA: 0x7A7E00680
    }

}