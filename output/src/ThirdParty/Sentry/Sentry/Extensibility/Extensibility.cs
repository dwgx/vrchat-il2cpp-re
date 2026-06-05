// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 24
// Methods: 167

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7FFAF8EF5F40
        public void IsSupported(){} // RVA: 0x7FFAF2ABDE40
        public void DoExtractPayLoad(){} // RVA: 0x7FFAF2ABCE10
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DefaultRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAF2E72850
        public void DoExtractPayLoad(){} // RVA: 0x7FFAF8EF6220
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class DiagnosticLoggerExtensions
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAF8EF6460
        public void LogDebug(){} // RVA: 0x7FFAF8EF65B0 | overloaded x7
        public void LogInfo(){} // RVA: 0x7FFAF2D33FA0 | overloaded x8
        public void LogWarning(){} // RVA: 0x7FFAF2D33FA0 | overloaded x9
        public void LogError(){} // RVA: 0x7FFAF2D33FA0 | overloaded x18
        public void LogFatal(){} // RVA: 0x7FFAF8EF6B50 | overloaded x4
        public void LogIfEnabled(){} // RVA: 0x7FFAF2D33FA0 | overloaded x11
    }

    public class DisabledHub
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAF2D8D320
        public void .ctor(){} // RVA: 0x7FFAF8EF6D50
        public void ConfigureScope(){} // RVA: 0x7FFAF2D8D310
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAF8EF6DE0
        public void PushScope(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFAF8EF6E80
        public void BindException(){} // RVA: 0x7FFAF2D8D310
        public void GetSpan(){} // RVA: 0x7FFAF2FC9240
        public void GetTraceHeader(){} // RVA: 0x7FFAF2FC9240
        public void GetBaggage(){} // RVA: 0x7FFAF2FC9240
        public void ContinueTrace(){} // RVA: 0x7FFAF8EF70D0 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAF2D8D310
        public void PauseSession(){} // RVA: 0x7FFAF2D8D310
        public void ResumeSession(){} // RVA: 0x7FFAF2D8D310
        public void EndSession(){} // RVA: 0x7FFAF2D8D310
        public void BindClient(){} // RVA: 0x7FFAF2D8D310
        public void CaptureEnvelope(){} // RVA: 0x7FFAF2D8D320
        public void CaptureEvent(){} // RVA: 0x7FFAF8EF7340 | overloaded x3
        public void CaptureTransaction(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAF2D8D310
        public void CaptureCheckIn(){} // RVA: 0x7FFAF8EF73A0
        public void FlushAsync(){} // RVA: 0x7FFAF8EF7400
        public void get_Metrics(){} // RVA: 0x7FFAF2DA8380
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
        public void CaptureUserFeedback(){} // RVA: 0x7FFAF2D8D310
        public void get_LastEventId(){} // RVA: 0x7FFAF8EF74A0
        public void .cctor(){} // RVA: 0x7FFAF8EF7500
    }

    public class FormRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAF8EF7630
        public void DoExtractPayLoad(){} // RVA: 0x7FFAF8EF7760
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class HubAdapter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_IsEnabled(){} // RVA: 0x7FFAF8EF7B80
        public void get_LastEventId(){} // RVA: 0x7FFAF8EF7C30
        public void ConfigureScope(){} // RVA: 0x7FFAF8EF7D00
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAF8EF7D50
        public void PushScope(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFAF8EF7F90 | overloaded x2
        public void BindException(){} // RVA: 0x7FFAF8EF8050
        public void GetSpan(){} // RVA: 0x7FFAF8EF8120
        public void GetTraceHeader(){} // RVA: 0x7FFAF8EF8170
        public void GetBaggage(){} // RVA: 0x7FFAF8EF8230
        public void ContinueTrace(){} // RVA: 0x7FFAF8EF8430 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAF8EF8580
        public void PauseSession(){} // RVA: 0x7FFAF8EF8640
        public void ResumeSession(){} // RVA: 0x7FFAF8EF8700
        public void EndSession(){} // RVA: 0x7FFAF8EF87C0
        public void BindClient(){} // RVA: 0x7FFAF8EF8880
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8EF8A00 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFAF8EF8DE0 | overloaded x5
        public void CaptureEnvelope(){} // RVA: 0x7FFAF8EF8BD0
        public void CaptureException(){} // RVA: 0x7FFAF8EF8ED0
        public void CaptureTransaction(){} // RVA: 0x7FFAF8EF9040 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAF8EF9120
        public void CaptureCheckIn(){} // RVA: 0x7FFAF8EF91D0
        public void FlushAsync(){} // RVA: 0x7FFAF8EF93A0
        public void get_Metrics(){} // RVA: 0x7FFAF8EF9460
        public void CaptureUserFeedback(){} // RVA: 0x7FFAF8EF9520
        public void .cctor(){} // RVA: 0x7FFAF8EF95D0
    }

    public class IBackgroundWorker
    {
        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0x7FFAF2ABDE40
        public void FlushAsync(){}
        public void get_QueuedItems(){} // RVA: 0x7FFAF2ABD840
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFAF2ABEA60
        public void Log(){}
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAF2ABDE40
    }

    public class IHttpRequest
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7FFAF2ABC770
        public void get_ContentType(){} // RVA: 0x7FFAF2ABCD60
        public void get_Body(){} // RVA: 0x7FFAF2ABCD60
        public void get_Form(){} // RVA: 0x7FFAF2ABCD60
    }

    public class INetworkStatusListener
    {
        // ── Methods ──
        public void get_Online(){} // RVA: 0x7FFAF2ABDBE0
        public void WaitForNetworkOnlineAsync(){}
    }

    public class IRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAF2ADDC60
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ISentryEventProcessorExtensions
    {
        // ── Methods ──
        public void DoProcessEvent(){} // RVA: 0x7FFAF8EF9670
    }

    public class ISentryEventProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAF2ABCE10
    }

    public class ISentryTransactionProcessorExtensions
    {
        // ── Methods ──
        public void DoProcessTransaction(){} // RVA: 0x7FFAF8EF97F0
    }

    public class ISentryTransactionProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAF2ACE6A0
    }

    public class ITransport
    {
        // ── Methods ──
        public void SendEnvelopeAsync(){}
    }

    public class RequestBodyExtractionDispatcher
    {
        // ── Methods ──
        public void get_Extractors(){} // RVA: 0x7FFAF2DBB0C0
        public void .ctor(){} // RVA: 0x7FFAF8EF9970
        public void ExtractPayload(){} // RVA: 0x7FFAF8EF9B50
    }

    public class SentryEventExceptionProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAF2ADDC60
        public void ProcessException(){} // RVA: 0x7FFAF2D33FA0
        public void .ctor(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SentryStackTraceFactory : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Create(){} // RVA: 0x7FFAF8EFA040
    }

}