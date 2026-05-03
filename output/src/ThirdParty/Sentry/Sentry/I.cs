// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 23
// Methods: 123

namespace ThirdParty.Sentry.Sentry
{
    public class IAttachmentContent
    {
        // ── Methods ──
        public void GetStream(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IBaseTracer
    {
        // ── Methods ──
        public void get_IsOtelInstrumenter(){} // RVA: 0x7FFE80E2F150
    }

    public class IEventLike
    {
        // ── Methods ──
        public void get_Breadcrumbs(){} // RVA: 0x7FFE80E2E2E0
        public void AddBreadcrumb(){} // RVA: 0x7FFE80E460A0
        public void get_Distribution(){} // RVA: 0x7FFE80E2E2E0
        public void set_Distribution(){} // RVA: 0x7FFE80E460A0
        public void get_Level(){}
        public void set_Level(){}
        public void get_Request(){} // RVA: 0x7FFE80E2E2E0
        public void set_Request(){} // RVA: 0x7FFE80E460A0
        public void get_Contexts(){} // RVA: 0x7FFE80E2E2E0
        public void set_Contexts(){} // RVA: 0x7FFE80E460A0
        public void get_User(){} // RVA: 0x7FFE80E2E2E0
        public void set_User(){} // RVA: 0x7FFE80E460A0
        public void get_Release(){} // RVA: 0x7FFE80E2E2E0
        public void set_Release(){} // RVA: 0x7FFE80E460A0
        public void get_Environment(){} // RVA: 0x7FFE80E2E2E0
        public void set_Environment(){} // RVA: 0x7FFE80E460A0
        public void get_TransactionName(){} // RVA: 0x7FFE80E2E2E0
        public void set_TransactionName(){} // RVA: 0x7FFE80E460A0
        public void get_Sdk(){} // RVA: 0x7FFE80E2E2E0
        public void get_Fingerprint(){} // RVA: 0x7FFE80E2E2E0
        public void set_Fingerprint(){} // RVA: 0x7FFE80E460A0
    }

    public class IHasExtra
    {
        // ── Methods ──
        public void get_Extra(){} // RVA: 0x7FFE80E2E2E0
        public void SetExtra(){} // RVA: 0x7FFE80E4F230
    }

    public class IHasTags
    {
        // ── Methods ──
        public void get_Tags(){} // RVA: 0x7FFE80E2E2E0
        public void SetTag(){} // RVA: 0x7FFE80E4F230
        public void UnsetTag(){} // RVA: 0x7FFE80E460A0
    }

    public class IHub
    {
        // ── Methods ──
        public void get_LastEventId(){} // RVA: 0x7FFE80E2DCF0
        public void get_Metrics(){} // RVA: 0x7FFE80E2E2E0
        public void StartTransaction(){} // RVA: 0x7FFE80E3FC10
        public void BindException(){} // RVA: 0x7FFE80E4F230
        public void GetSpan(){} // RVA: 0x7FFE80E2E2E0
        public void GetTraceHeader(){} // RVA: 0x7FFE80E2E2E0
        public void GetBaggage(){} // RVA: 0x7FFE80E2E2E0
        public void ContinueTrace(){} // RVA: 0x7FFE80E40660 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFE80E45FE0
        public void PauseSession(){} // RVA: 0x7FFE80E45FE0
        public void ResumeSession(){} // RVA: 0x7FFE80E45FE0
        public void EndSession(){} // RVA: 0x7FFE80E46530
        public void CaptureEvent(){} // overloaded x2
    }

    public class IMetricAggregator
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7FFE810A1420
        public void Gauge(){} // RVA: 0x7FFE810A1420
        public void Distribution(){} // RVA: 0x7FFE810A1420
        public void Set(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void Timing(){}
        public void StartTimer(){} // RVA: 0x7FFE810A1420
        public void FlushAsync(){}
    }

    public class IMetricHub
    {
        // ── Methods ──
        public void CaptureMetrics(){} // RVA: 0x7FFE80E460A0
        public void CaptureCodeLocations(){} // RVA: 0x7FFE80E460A0
        public void StartSpan(){} // RVA: 0x7FFE80E3FC10
        public void GetSpan(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IScopeObserver
    {
        // ── Methods ──
        public void AddBreadcrumb(){} // RVA: 0x7FFE80E460A0
        public void SetExtra(){} // RVA: 0x7FFE80E4F230
        public void SetTag(){} // RVA: 0x7FFE80E4F230
        public void UnsetTag(){} // RVA: 0x7FFE80E460A0
        public void SetUser(){} // RVA: 0x7FFE80E460A0
    }

    public class ISentryClient
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFE80E2F150
        public void CaptureEnvelope(){} // RVA: 0x7FFE80E2F3B0
        public void CaptureEvent(){}
        public void CaptureUserFeedback(){} // RVA: 0x7FFE80E460A0
        public void CaptureTransaction(){} // RVA: 0x7FFE80E50660 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFE80E460A0
        public void CaptureCheckIn(){}
        public void FlushAsync(){}
    }

    public class ISentryFailedRequestHandler
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7FFE80E460A0
    }

    public class ISentryJsonSerializable
    {
        // ── Methods ──
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
    }

    public class ISentryScopeManager
    {
        // ── Methods ──
        public void ConfigureScope(){} // RVA: 0x7FFE80E460A0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFE80E2E390
        public void BindClient(){} // RVA: 0x7FFE80E460A0
        public void PushScope(){} // RVA: 0x7FFE810A1420 | overloaded x2
    }

    public class ISentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFE80E4F230
    }

    public class ISentrySession
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE80E2DCF0
        public void get_DistinctId(){} // RVA: 0x7FFE80E2E2E0
        public void get_StartTimestamp(){} // RVA: 0x7FFE80E2DCF0
        public void get_Release(){} // RVA: 0x7FFE80E2E2E0
        public void get_Environment(){} // RVA: 0x7FFE80E2E2E0
        public void get_IpAddress(){} // RVA: 0x7FFE80E2E2E0
        public void get_UserAgent(){} // RVA: 0x7FFE80E2E2E0
        public void get_ErrorCount(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ISentryUserFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISessionManager
    {
        // ── Methods ──
        public void get_IsSessionActive(){} // RVA: 0x7FFE80E2F150
        public void TryRecoverPersistedSession(){} // RVA: 0x7FFE80E2E2E0
        public void StartSession(){} // RVA: 0x7FFE80E2E2E0
        public void EndSession(){} // RVA: 0x7FFE80E3D230 | overloaded x2
        public void PauseSession(){} // RVA: 0x7FFE80E45FE0
        public void ResumeSession(){} // RVA: 0x7FFE80E2E2E0
        public void ReportError(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISpan
    {
        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFE80E2E2E0
        public void set_Description(){} // RVA: 0x7FFE80E460A0
        public void get_Operation(){} // RVA: 0x7FFE80E2E2E0
        public void set_Operation(){} // RVA: 0x7FFE80E460A0
        public void get_Status(){} // RVA: 0x7FFE80E2E2E0
        public void set_Status(){}
        public void StartChild(){} // RVA: 0x7FFE80E2E390
        public void Finish(){} // RVA: 0x7FFE80E460A0 | overloaded x4
    }

    public class ISpanData
    {
        // ── Methods ──
        public void get_StartTimestamp(){} // RVA: 0x7FFE80E2DCF0
        public void get_EndTimestamp(){} // RVA: 0x7FFE80E2DCF0
        public void get_IsFinished(){} // RVA: 0x7FFE80E2F150
        public void GetTraceHeader(){} // RVA: 0x7FFE80E2E2E0
        public void get_Measurements(){} // RVA: 0x7FFE80E2E2E0
        public void SetMeasurement(){} // RVA: 0x7FFE80E4F230
    }

    public class ITraceContextInternal
    {
        // ── Methods ──
        public void get_Origin(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ITransactionContext
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void get_IsParentSampled(){} // RVA: 0x7FFE80E2E210
        public void get_NameSource(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ITransactionData
    {
        // ── Methods ──
        public void get_Platform(){} // RVA: 0x7FFE80E2E2E0
        public void set_Platform(){} // RVA: 0x7FFE80E460A0
    }

    public class ITransactionTracer
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE80E2E2E0
        public void set_Name(){} // RVA: 0x7FFE80E460A0
        public void get_IsParentSampled(){} // RVA: 0x7FFE80E2E210
        public void set_IsParentSampled(){} // RVA: 0x7FFE80E461D0
        public void get_Spans(){} // RVA: 0x7FFE80E2E2E0
        public void GetLastActiveSpan(){} // RVA: 0x7FFE80E2E2E0
    }

}