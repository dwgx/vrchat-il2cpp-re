// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 23
// Methods: 123

namespace ThirdParty.Sentry.Sentry
{
    public class IAttachmentContent
    {
        // ── Methods ──
        public void GetStream(){} // RVA: 0x7FFAC2C58E90
    }

    public class IBaseTracer
    {
        public object IsOtelInstrumenter;

        // ── Methods ──
        public void get_IsOtelInstrumenter(){} // RVA: 0x7FFAC2C59D00
    }

    public class IEventLike
    {
        public object Breadcrumbs;
        public object Distribution;
        public object Level;
        public object Request;
        public object Contexts;
        public object User;
        public object Release;
        public object Environment;
        public object TransactionName;
        public object Sdk;
        public object Fingerprint;

        // ── Methods ──
        public void get_Breadcrumbs(){} // RVA: 0x7FFAC2C58E90
        public void AddBreadcrumb(){} // RVA: 0x7FFAC2C70A40
        public void get_Distribution(){} // RVA: 0x7FFAC2C58E90
        public void set_Distribution(){} // RVA: 0x7FFAC2C70A40
        public void get_Level(){}
        public void set_Level(){}
        public void get_Request(){} // RVA: 0x7FFAC2C58E90
        public void set_Request(){} // RVA: 0x7FFAC2C70A40
        public void get_Contexts(){} // RVA: 0x7FFAC2C58E90
        public void set_Contexts(){} // RVA: 0x7FFAC2C70A40
        public void get_User(){} // RVA: 0x7FFAC2C58E90
        public void set_User(){} // RVA: 0x7FFAC2C70A40
        public void get_Release(){} // RVA: 0x7FFAC2C58E90
        public void set_Release(){} // RVA: 0x7FFAC2C70A40
        public void get_Environment(){} // RVA: 0x7FFAC2C58E90
        public void set_Environment(){} // RVA: 0x7FFAC2C70A40
        public void get_TransactionName(){} // RVA: 0x7FFAC2C58E90
        public void set_TransactionName(){} // RVA: 0x7FFAC2C70A40
        public void get_Sdk(){} // RVA: 0x7FFAC2C58E90
        public void get_Fingerprint(){} // RVA: 0x7FFAC2C58E90
        public void set_Fingerprint(){} // RVA: 0x7FFAC2C70A40
    }

    public class IHasExtra
    {
        public object Extra;

        // ── Methods ──
        public void get_Extra(){} // RVA: 0x7FFAC2C58E90
        public void SetExtra(){} // RVA: 0x7FFAC2C79B30
    }

    public class IHasTags
    {
        public object Tags;

        // ── Methods ──
        public void get_Tags(){} // RVA: 0x7FFAC2C58E90
        public void SetTag(){} // RVA: 0x7FFAC2C79B30
        public void UnsetTag(){} // RVA: 0x7FFAC2C70A40
    }

    public class IHub
    {
        public object LastEventId;
        public object Metrics;

        // ── Methods ──
        public void get_LastEventId(){} // RVA: 0x7FFAC2C588A0
        public void get_Metrics(){} // RVA: 0x7FFAC2C58E90
        public void StartTransaction(){} // RVA: 0x7FFAC2C6A6F0
        public void BindException(){} // RVA: 0x7FFAC2C79B30
        public void GetSpan(){} // RVA: 0x7FFAC2C58E90
        public void GetTraceHeader(){} // RVA: 0x7FFAC2C58E90
        public void GetBaggage(){} // RVA: 0x7FFAC2C58E90
        public void ContinueTrace(){} // RVA: 0x7FFAC2C6B140 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAC2C70980
        public void PauseSession(){} // RVA: 0x7FFAC2C70980
        public void ResumeSession(){} // RVA: 0x7FFAC2C70980
        public void EndSession(){} // RVA: 0x7FFAC2C70ED0
        public void CaptureEvent(){} // overloaded x2
    }

    public class IMetricAggregator
    {
        // ── Methods ──
        public void Increment(){} // RVA: 0x7FFAC2E8DC40
        public void Gauge(){} // RVA: 0x7FFAC2E8DC40
        public void Distribution(){} // RVA: 0x7FFAC2E8DC40
        public void Set(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void Timing(){}
        public void StartTimer(){} // RVA: 0x7FFAC2E8DC40
        public void FlushAsync(){}
    }

    public class IMetricHub
    {
        // ── Methods ──
        public void CaptureMetrics(){} // RVA: 0x7FFAC2C70A40
        public void CaptureCodeLocations(){} // RVA: 0x7FFAC2C70A40
        public void StartSpan(){} // RVA: 0x7FFAC2C6A6F0
        public void GetSpan(){} // RVA: 0x7FFAC2C58E90
    }

    public class IScopeObserver
    {
        // ── Methods ──
        public void AddBreadcrumb(){} // RVA: 0x7FFAC2C70A40
        public void SetExtra(){} // RVA: 0x7FFAC2C79B30
        public void SetTag(){} // RVA: 0x7FFAC2C79B30
        public void UnsetTag(){} // RVA: 0x7FFAC2C70A40
        public void SetUser(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISentryClient
    {
        public object IsEnabled;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAC2C59D00
        public void CaptureEnvelope(){} // RVA: 0x7FFAC2C59F60
        public void CaptureEvent(){}
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC2C70A40
        public void CaptureTransaction(){} // RVA: 0x7FFAC2C7AF60 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAC2C70A40
        public void CaptureCheckIn(){}
        public void FlushAsync(){}
    }

    public class ISentryFailedRequestHandler
    {
        // ── Methods ──
        public void HandleResponse(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISentryJsonSerializable
    {
        // ── Methods ──
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
    }

    public class ISentryScopeManager
    {
        // ── Methods ──
        public void ConfigureScope(){} // RVA: 0x7FFAC2C70A40
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAC2C58F40
        public void BindClient(){} // RVA: 0x7FFAC2C70A40
        public void PushScope(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
    }

    public class ISentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFAC2C79B30
    }

    public class ISentrySession
    {
        public object Id;
        public object DistinctId;
        public object StartTimestamp;
        public object Release;
        public object Environment;
        public object IpAddress;
        public object UserAgent;
        public object ErrorCount;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC2C588A0
        public void get_DistinctId(){} // RVA: 0x7FFAC2C58E90
        public void get_StartTimestamp(){} // RVA: 0x7FFAC2C588A0
        public void get_Release(){} // RVA: 0x7FFAC2C58E90
        public void get_Environment(){} // RVA: 0x7FFAC2C58E90
        public void get_IpAddress(){} // RVA: 0x7FFAC2C58E90
        public void get_UserAgent(){} // RVA: 0x7FFAC2C58E90
        public void get_ErrorCount(){} // RVA: 0x7FFAC2C59960
    }

    public class ISentryUserFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C58E90
    }

    public class ISessionManager
    {
        public object IsSessionActive;

        // ── Methods ──
        public void get_IsSessionActive(){} // RVA: 0x7FFAC2C59D00
        public void TryRecoverPersistedSession(){} // RVA: 0x7FFAC2C58E90
        public void StartSession(){} // RVA: 0x7FFAC2C58E90
        public void EndSession(){} // RVA: 0x7FFAC2C67DE0 | overloaded x2
        public void PauseSession(){} // RVA: 0x7FFAC2C70980
        public void ResumeSession(){} // RVA: 0x7FFAC2C58E90
        public void ReportError(){} // RVA: 0x7FFAC2C58E90
    }

    public class ISpan
    {
        public object Description;
        public object Operation;
        public object Status;

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFAC2C58E90
        public void set_Description(){} // RVA: 0x7FFAC2C70A40
        public void get_Operation(){} // RVA: 0x7FFAC2C58E90
        public void set_Operation(){} // RVA: 0x7FFAC2C70A40
        public void get_Status(){} // RVA: 0x7FFAC2C58E90
        public void set_Status(){}
        public void StartChild(){} // RVA: 0x7FFAC2C58F40
        public void Finish(){} // RVA: 0x7FFAC2C70A40 | overloaded x4
    }

    public class ISpanData
    {
        public object StartTimestamp;
        public object EndTimestamp;
        public object IsFinished;
        public object Measurements;

        // ── Methods ──
        public void get_StartTimestamp(){} // RVA: 0x7FFAC2C588A0
        public void get_EndTimestamp(){} // RVA: 0x7FFAC2C588A0
        public void get_IsFinished(){} // RVA: 0x7FFAC2C59D00
        public void GetTraceHeader(){} // RVA: 0x7FFAC2C58E90
        public void get_Measurements(){} // RVA: 0x7FFAC2C58E90
        public void SetMeasurement(){} // RVA: 0x7FFAC2C79B30
    }

    public class ITraceContextInternal
    {
        public object Origin;

        // ── Methods ──
        public void get_Origin(){} // RVA: 0x7FFAC2C58E90
    }

    public class ITransactionContext
    {
        public object Name;
        public object IsParentSampled;
        public object NameSource;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void get_IsParentSampled(){} // RVA: 0x7FFAC2C58DC0
        public void get_NameSource(){} // RVA: 0x7FFAC2C59960
    }

    public class ITransactionData
    {
        public object Platform;

        // ── Methods ──
        public void get_Platform(){} // RVA: 0x7FFAC2C58E90
        public void set_Platform(){} // RVA: 0x7FFAC2C70A40
    }

    public class ITransactionTracer
    {
        public object Name;
        public object IsParentSampled;
        public object Spans;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2C58E90
        public void set_Name(){} // RVA: 0x7FFAC2C70A40
        public void get_IsParentSampled(){} // RVA: 0x7FFAC2C58DC0
        public void set_IsParentSampled(){} // RVA: 0x7FFAC2C70B70
        public void get_Spans(){} // RVA: 0x7FFAC2C58E90
        public void GetLastActiveSpan(){} // RVA: 0x7FFAC2C58E90
    }

}