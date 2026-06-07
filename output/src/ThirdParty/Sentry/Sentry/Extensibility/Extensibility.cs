// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 24
// Methods: 167

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x6445F40
        public void IsSupported(){} // RVA: 0xDE40
        public void DoExtractPayLoad(){} // RVA: 0xCE10
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DefaultRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x3C2850
        public void DoExtractPayLoad(){} // RVA: 0x6446220
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class DiagnosticLoggerExtensions
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x6446460
        public void LogDebug(){} // RVA: 0x64465B0 | overloaded x7
        public void LogInfo(){} // RVA: 0x283FA0 | overloaded x8
        public void LogWarning(){} // RVA: 0x283FA0 | overloaded x9
        public void LogError(){} // RVA: 0x283FA0 | overloaded x18
        public void LogFatal(){} // RVA: 0x6446B50 | overloaded x4
        public void LogIfEnabled(){} // RVA: 0x283FA0 | overloaded x11
    }

    public class DisabledHub
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x2DD320
        public void .ctor(){} // RVA: 0x6446D50
        public void ConfigureScope(){} // RVA: 0x2DD310
        public void ConfigureScopeAsync(){} // RVA: 0x6446DE0
        public void PushScope(){} // RVA: 0x283FA0 | overloaded x2
        public void StartTransaction(){} // RVA: 0x6446E80
        public void BindException(){} // RVA: 0x2DD310
        public void GetSpan(){} // RVA: 0x519240
        public void GetTraceHeader(){} // RVA: 0x519240
        public void GetBaggage(){} // RVA: 0x519240
        public void ContinueTrace(){} // RVA: 0x64470D0 | overloaded x2
        public void StartSession(){} // RVA: 0x2DD310
        public void PauseSession(){} // RVA: 0x2DD310
        public void ResumeSession(){} // RVA: 0x2DD310
        public void EndSession(){} // RVA: 0x2DD310
        public void BindClient(){} // RVA: 0x2DD310
        public void CaptureEnvelope(){} // RVA: 0x2DD320
        public void CaptureEvent(){} // RVA: 0x6447340 | overloaded x3
        public void CaptureTransaction(){} // RVA: 0x2DD310 | overloaded x2
        public void CaptureSession(){} // RVA: 0x2DD310
        public void CaptureCheckIn(){} // RVA: 0x64473A0
        public void FlushAsync(){} // RVA: 0x6447400
        public void get_Metrics(){} // RVA: 0x2F8380
        public void Dispose(){} // RVA: 0x2DD310
        public void CaptureUserFeedback(){} // RVA: 0x2DD310
        public void get_LastEventId(){} // RVA: 0x64474A0
        public void .cctor(){} // RVA: 0x6447500
    }

    public class FormRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x6447630
        public void DoExtractPayLoad(){} // RVA: 0x6447760
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class HubAdapter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_IsEnabled(){} // RVA: 0x6447B80
        public void get_LastEventId(){} // RVA: 0x6447C30
        public void ConfigureScope(){} // RVA: 0x6447D00
        public void ConfigureScopeAsync(){} // RVA: 0x6447D50
        public void PushScope(){} // RVA: 0x283FA0 | overloaded x2
        public void StartTransaction(){} // RVA: 0x6447F90 | overloaded x2
        public void BindException(){} // RVA: 0x6448050
        public void GetSpan(){} // RVA: 0x6448120
        public void GetTraceHeader(){} // RVA: 0x6448170
        public void GetBaggage(){} // RVA: 0x6448230
        public void ContinueTrace(){} // RVA: 0x6448430 | overloaded x2
        public void StartSession(){} // RVA: 0x6448580
        public void PauseSession(){} // RVA: 0x6448640
        public void ResumeSession(){} // RVA: 0x6448700
        public void EndSession(){} // RVA: 0x64487C0
        public void BindClient(){} // RVA: 0x6448880
        public void AddBreadcrumb(){} // RVA: 0x6448A00 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x6448DE0 | overloaded x5
        public void CaptureEnvelope(){} // RVA: 0x6448BD0
        public void CaptureException(){} // RVA: 0x6448ED0
        public void CaptureTransaction(){} // RVA: 0x6449040 | overloaded x2
        public void CaptureSession(){} // RVA: 0x6449120
        public void CaptureCheckIn(){} // RVA: 0x64491D0
        public void FlushAsync(){} // RVA: 0x64493A0
        public void get_Metrics(){} // RVA: 0x6449460
        public void CaptureUserFeedback(){} // RVA: 0x6449520
        public void .cctor(){} // RVA: 0x64495D0
    }

    public class IBackgroundWorker
    {
        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0xDE40
        public void FlushAsync(){}
        public void get_QueuedItems(){} // RVA: 0xD840
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0xEA60
        public void Log(){}
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0xDE40
    }

    public class IHttpRequest
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0xC770
        public void get_ContentType(){} // RVA: 0xCD60
        public void get_Body(){} // RVA: 0xCD60
        public void get_Form(){} // RVA: 0xCD60
    }

    public class INetworkStatusListener
    {
        // ── Methods ──
        public void get_Online(){} // RVA: 0xDBE0
        public void WaitForNetworkOnlineAsync(){}
    }

    public class IRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0xCE10
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x2DC60
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0xCE10
    }

    public class ISentryEventProcessorExtensions
    {
        // ── Methods ──
        public void DoProcessEvent(){} // RVA: 0x6449670
    }

    public class ISentryEventProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x1E6A0
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0xCE10
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0xCE10
    }

    public class ISentryTransactionProcessorExtensions
    {
        // ── Methods ──
        public void DoProcessTransaction(){} // RVA: 0x64497F0
    }

    public class ISentryTransactionProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x1E6A0
    }

    public class ITransport
    {
        // ── Methods ──
        public void SendEnvelopeAsync(){}
    }

    public class RequestBodyExtractionDispatcher
    {
        // ── Methods ──
        public void get_Extractors(){} // RVA: 0x30B0C0
        public void .ctor(){} // RVA: 0x6449970
        public void ExtractPayload(){} // RVA: 0x6449B50
    }

    public class SentryEventExceptionProcessor`1
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x2DC60
        public void ProcessException(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SentryStackTraceFactory : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Create(){} // RVA: 0x644A040
    }

}