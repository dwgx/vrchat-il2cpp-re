// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 23
// Methods: 114

namespace ThirdParty.Sentry.Sentry
{
    public class IAttachmentContent
    {
        // ── Methods ──
        public void GetStream(){} // RVA: 0x87C0A0
    }

    public class IBaseTracer
    {
        // ── Methods ──
        public void get_IsOtelInstrumenter(){} // RVA: 0x87D280
    }

    public class IEventLike
    {
        // ── Methods ──
        public void get_Breadcrumbs(){} // RVA: 0x87C0A0
        public void AddBreadcrumb(){} // RVA: 0x894320
        public void get_Distribution(){} // RVA: 0x87C0A0
        public void set_Distribution(){} // RVA: 0x894320
        public void get_Level(){} // RVA: 0x87C130
        public void set_Level(){} // RVA: 0x8944F0
        public void get_Request(){} // RVA: 0x87C0A0
        public void set_Request(){} // RVA: 0x894320
        public void get_Contexts(){} // RVA: 0x87C0A0
        public void set_Contexts(){} // RVA: 0x894320
        public void get_User(){} // RVA: 0x87C0A0
        public void set_User(){} // RVA: 0x894320
        public void get_Release(){} // RVA: 0x87C0A0
        public void set_Release(){} // RVA: 0x894320
        public void get_Environment(){} // RVA: 0x87C0A0
        public void set_Environment(){} // RVA: 0x894320
        public void get_TransactionName(){} // RVA: 0x87C0A0
        public void set_TransactionName(){} // RVA: 0x894320
        public void get_Sdk(){} // RVA: 0x87C0A0
        public void get_Fingerprint(){} // RVA: 0x87C0A0
        public void set_Fingerprint(){} // RVA: 0x894320
    }

    public class IHasExtra
    {
        // ── Methods ──
        public void get_Extra(){} // RVA: 0x87C0A0
        public void SetExtra(){} // RVA: 0x8943B0
    }

    public class IHasTags
    {
        // ── Methods ──
        public void get_Tags(){} // RVA: 0x87C0A0
        public void SetTag(){} // RVA: 0x8943B0
        public void UnsetTag(){} // RVA: 0x894320
    }

    public class IHub
    {
        // ── Methods ──
        public void get_LastEventId(){} // RVA: 0x87BEB0
        public void get_Metrics(){} // RVA: 0x87C0A0
        public void StartTransaction(){} // RVA: 0x87C5F0
        public void BindException(){} // RVA: 0x8943B0
        public void GetSpan(){} // RVA: 0x87C0A0
        public void GetTraceHeader(){} // RVA: 0x87C0A0
        public void GetBaggage(){} // RVA: 0x87C0A0
        public void ContinueTrace(){} // RVA: 0x88D2C0
        public void StartSession(){} // RVA: 0x894290
        public void PauseSession(){} // RVA: 0x894290
        public void ResumeSession(){} // RVA: 0x894290
        public void EndSession(){} // RVA: 0x8944F0
        public void CaptureEvent(){} // RVA: 0x87C050
    }

    public class IMetricAggregator
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0xA94080
        public void Gauge(){} // RVA: 0xA94080
        public void Distribution(){} // RVA: 0xA94080
        public void Set(){} // RVA: 0xA94080
        public void Timing(){} // RVA: 0x89AED0
        public void StartTimer(){} // RVA: 0xA94080
        public void FlushAsync(){} // RVA: 0x88C2D0
    }

    public class IMetricHub
    {
        // ── Methods ──
        public void CaptureMetrics(){} // RVA: 0x894320
        public void CaptureCodeLocations(){} // RVA: 0x894320
        public void StartSpan(){} // RVA: 0x87C5F0
        public void GetSpan(){} // RVA: 0x87C0A0
    }

    public class IScopeObserver
    {
        // ── Methods ──
        public void AddBreadcrumb(){} // RVA: 0x894320
        public void SetExtra(){} // RVA: 0x8943B0
        public void SetTag(){} // RVA: 0x8943B0
        public void UnsetTag(){} // RVA: 0x894320
        public void SetUser(){} // RVA: 0x894320
    }

    public class ISentryClient
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x87D280
        public void CaptureEnvelope(){} // RVA: 0x87D350
        public void CaptureEvent(){} // RVA: 0x87C050
        public void CaptureUserFeedback(){} // RVA: 0x894320
        public void CaptureTransaction(){} // RVA: 0x8954D0
        public void CaptureSession(){} // RVA: 0x894320
        public void CaptureCheckIn(){} // RVA: 0x890F10
        public void FlushAsync(){} // RVA: 0x881D60
    }

    public class ISentryFailedRequestHandler
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x894320
    }

    public class ISentryJsonSerializable
    {
        // ── Methods ──
        public void WriteTo(){} // RVA: 0x8943B0
    }

    public class ISentryScopeManager
    {
        // ── Methods ──
        public void ConfigureScope(){} // RVA: 0x894320
        public void ConfigureScopeAsync(){} // RVA: 0x87C540
        public void BindClient(){} // RVA: 0x894320
        public void PushScope(){} // RVA: 0xA94080
    }

    public class ISentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x8943B0
    }

    public class ISentrySession
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x87BEB0
        public void get_DistinctId(){} // RVA: 0x87C0A0
        public void get_StartTimestamp(){} // RVA: 0x87BEB0
        public void get_Release(){} // RVA: 0x87C0A0
        public void get_Environment(){} // RVA: 0x87C0A0
        public void get_IpAddress(){} // RVA: 0x87C0A0
        public void get_UserAgent(){} // RVA: 0x87C0A0
        public void get_ErrorCount(){} // RVA: 0x87C130
    }

    public class ISentryUserFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C0A0
    }

    public class ISessionManager
    {
        // ── Methods ──
        public void get_IsSessionActive(){} // RVA: 0x87D280
        public void TryRecoverPersistedSession(){} // RVA: 0x87C0A0
        public void StartSession(){} // RVA: 0x87C0A0
        public void EndSession(){} // RVA: 0x87C160
        public void PauseSession(){} // RVA: 0x894290
        public void ResumeSession(){} // RVA: 0x87C0A0
        public void ReportError(){} // RVA: 0x87C0A0
    }

    public class ISpan
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x87C0A0
        public void set_Description(){} // RVA: 0x894320
        public void get_Operation(){} // RVA: 0x87C0A0
        public void set_Operation(){} // RVA: 0x894320
        public void get_Status(){} // RVA: 0x87C0A0
        public void set_Status(){} // RVA: 0x8943F0
        public void StartChild(){} // RVA: 0x87C540
        public void Finish(){} // RVA: 0x894320
    }

    public class ISpanData
    {
        // ── Methods ──
        public void get_StartTimestamp(){} // RVA: 0x87BEB0
        public void get_EndTimestamp(){} // RVA: 0x87BEB0
        public void get_IsFinished(){} // RVA: 0x87D280
        public void GetTraceHeader(){} // RVA: 0x87C0A0
        public void get_Measurements(){} // RVA: 0x87C0A0
        public void SetMeasurement(){} // RVA: 0x8943B0
    }

    public class ITraceContextInternal
    {
        // ── Methods ──
        public void get_Origin(){} // RVA: 0x87C0A0
    }

    public class ITransactionContext
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void get_IsParentSampled(){} // RVA: 0x87C100
        public void get_NameSource(){} // RVA: 0x87C130
    }

    public class ITransactionData
    {
        // ── Methods ──
        public void get_Platform(){} // RVA: 0x87C0A0
        public void set_Platform(){} // RVA: 0x894320
    }

    public class ITransactionTracer
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x87C0A0
        public void set_Name(){} // RVA: 0x894320
        public void get_IsParentSampled(){} // RVA: 0x87C100
        public void set_IsParentSampled(){} // RVA: 0x894470
        public void get_Spans(){} // RVA: 0x87C0A0
        public void GetLastActiveSpan(){} // RVA: 0x87C0A0
    }

}