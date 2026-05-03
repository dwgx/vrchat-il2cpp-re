// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 24
// Methods: 167

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class BaseRequestPayloadExtractor : Object
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7FFE86F86920
        public void IsSupported(){} // RVA: 0x7FFE80E2F3B0
        public void DoExtractPayLoad(){} // RVA: 0x7FFE80E2E390
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DefaultRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFE811E0850
        public void DoExtractPayLoad(){} // RVA: 0x7FFE86F86C00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class DiagnosticLoggerExtensions : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFE86F86E40
        public void LogDebug(){} // RVA: 0x7FFE86F86F90 | overloaded x7
        public void LogInfo(){} // RVA: 0x7FFE810A1420 | overloaded x8
        public void LogWarning(){} // RVA: 0x7FFE810A1420 | overloaded x9
        public void LogError(){} // RVA: 0x7FFE810A1420 | overloaded x18
        public void LogFatal(){} // RVA: 0x7FFE86F87530 | overloaded x4
        public void LogIfEnabled(){} // RVA: 0x7FFE810A1420 | overloaded x11
    }

    public class DisabledHub : Object
    {
        public Sentry.Extensibility.DisabledHub Instance;
        public Sentry.IMetricAggregator _metrics; // 0x10
        public object field_2; // 0x366

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE86F87730
        public void ConfigureScope(){} // RVA: 0x7FFE810FB310
        public void ConfigureScopeAsync(){} // RVA: 0x7FFE86F877C0
        public void PushScope(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFE86F87860
        public void BindException(){} // RVA: 0x7FFE810FB310
        public void GetSpan(){} // RVA: 0x7FFE813240E0
        public void GetTraceHeader(){} // RVA: 0x7FFE813240E0
        public void GetBaggage(){} // RVA: 0x7FFE813240E0
        public void ContinueTrace(){} // RVA: 0x7FFE86F87AB0 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFE810FB310
        public void PauseSession(){} // RVA: 0x7FFE810FB310
        public void ResumeSession(){} // RVA: 0x7FFE810FB310
        public void EndSession(){} // RVA: 0x7FFE810FB310
        public void BindClient(){} // RVA: 0x7FFE810FB310
        public void CaptureEnvelope(){} // RVA: 0x7FFE810FB320
        public void CaptureEvent(){} // RVA: 0x7FFE86F87D20 | overloaded x3
        public void CaptureTransaction(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFE810FB310
        public void CaptureCheckIn(){} // RVA: 0x7FFE86F87D80
        public void FlushAsync(){} // RVA: 0x7FFE86F87DE0
        public void get_Metrics(){} // RVA: 0x7FFE81116380
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void CaptureUserFeedback(){} // RVA: 0x7FFE810FB310
        public void get_LastEventId(){} // RVA: 0x7FFE86F87E80
        public void .cctor(){} // RVA: 0x7FFE86F87EE0
    }

    public class FormRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFE86F88010
        public void DoExtractPayLoad(){} // RVA: 0x7FFE86F88140
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class HubAdapter : Object
    {
        public Sentry.Extensibility.HubAdapter Instance;
        public object field_1; // 0x369
        public object field_2; // 0x36A

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_IsEnabled(){} // RVA: 0x7FFE86F88560
        public void get_LastEventId(){} // RVA: 0x7FFE86F88610
        public void ConfigureScope(){} // RVA: 0x7FFE86F886E0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFE86F88730
        public void PushScope(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFE86F88970 | overloaded x2
        public void BindException(){} // RVA: 0x7FFE86F88A30
        public void GetSpan(){} // RVA: 0x7FFE86F88B00
        public void GetTraceHeader(){} // RVA: 0x7FFE86F88B50
        public void GetBaggage(){} // RVA: 0x7FFE86F88C10
        public void ContinueTrace(){} // RVA: 0x7FFE86F88E10 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFE86F88F60
        public void PauseSession(){} // RVA: 0x7FFE86F89020
        public void ResumeSession(){} // RVA: 0x7FFE86F890E0
        public void EndSession(){} // RVA: 0x7FFE86F891A0
        public void BindClient(){} // RVA: 0x7FFE86F89260
        public void AddBreadcrumb(){} // RVA: 0x7FFE86F893E0 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFE86F897C0 | overloaded x5
        public void CaptureEnvelope(){} // RVA: 0x7FFE86F895B0
        public void CaptureException(){} // RVA: 0x7FFE86F898B0
        public void CaptureTransaction(){} // RVA: 0x7FFE86F89A20 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFE86F89B00
        public void CaptureCheckIn(){} // RVA: 0x7FFE86F89BB0
        public void FlushAsync(){} // RVA: 0x7FFE86F89D80
        public void get_Metrics(){} // RVA: 0x7FFE86F89E40
        public void CaptureUserFeedback(){} // RVA: 0x7FFE86F89F00
        public void .cctor(){} // RVA: 0x7FFE86F89FB0
    }

    public class IBackgroundWorker
    {
        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0x7FFE80E2F3B0
        public void FlushAsync(){}
        public void get_QueuedItems(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFE80E2FFD0
        public void Log(){}
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IHttpRequest
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7FFE80E2DCF0
        public void get_ContentType(){} // RVA: 0x7FFE80E2E2E0
        public void get_Body(){} // RVA: 0x7FFE80E2E2E0
        public void get_Form(){} // RVA: 0x7FFE80E2E2E0
    }

    public class INetworkStatusListener
    {
        // ── Methods ──
        public void get_Online(){} // RVA: 0x7FFE80E2F150
        public void WaitForNetworkOnlineAsync(){}
    }

    public class IRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7FFE80E2E390
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E4F230
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E2E390
    }

    public class ISentryEventProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessEvent(){} // RVA: 0x7FFE86F8A050
    }

    public class ISentryEventProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E3FC10
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE80E2E390
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E2E390
    }

    public class ISentryTransactionProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessTransaction(){} // RVA: 0x7FFE86F8A1D0
    }

    public class ISentryTransactionProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E3FC10
    }

    public class ITransport
    {
        // ── Methods ──
        public void SendEnvelopeAsync(){}
    }

    public class RequestBodyExtractionDispatcher : Object
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void get_Extractors(){} // RVA: 0x7FFE811290C0
        public void .ctor(){} // RVA: 0x7FFE86F8A350
        public void ExtractPayload(){} // RVA: 0x7FFE86F8A530
    }

    public class SentryEventExceptionProcessor`1 : Object
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFE80E4F230
        public void ProcessException(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SentryStackTraceFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Create(){} // RVA: 0x7FFE86F8AA20
    }

}