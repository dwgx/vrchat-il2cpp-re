// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 24
// Methods: 167

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class BaseRequestPayloadExtractor : Object
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7FFAC8BDD2C0
        public void IsSupported(){} // RVA: 0x7FFAC2C59F60
        public void DoExtractPayLoad(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAC3006850
        public void DoExtractPayLoad(){} // RVA: 0x7FFAC8BDD5A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DiagnosticLoggerExtensions : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFAC8BDD7E0
        public void LogDebug(){} // RVA: 0x7FFAC8BDD930 | overloaded x7
        public void LogInfo(){} // RVA: 0x7FFAC2E8DC40 | overloaded x8
        public void LogWarning(){} // RVA: 0x7FFAC2E8DC40 | overloaded x9
        public void LogError(){} // RVA: 0x7FFAC2E8DC40 | overloaded x18
        public void LogFatal(){} // RVA: 0x7FFAC8BDDED0 | overloaded x4
        public void LogIfEnabled(){} // RVA: 0x7FFAC2E8DC40 | overloaded x11
    }

    public class DisabledHub : Object
    {
        public Sentry.Extensibility.DisabledHub IsEnabled;
        public Sentry.IMetricAggregator Metrics; // 0x10

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC8BDE0D0
        public void ConfigureScope(){} // RVA: 0x7FFAC2F21310
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAC8BDE160
        public void PushScope(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFAC8BDE200
        public void BindException(){} // RVA: 0x7FFAC2F21310
        public void GetSpan(){} // RVA: 0x7FFAC34F9180
        public void GetTraceHeader(){} // RVA: 0x7FFAC34F9180
        public void GetBaggage(){} // RVA: 0x7FFAC34F9180
        public void ContinueTrace(){} // RVA: 0x7FFAC8BDE450 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAC2F21310
        public void PauseSession(){} // RVA: 0x7FFAC2F21310
        public void ResumeSession(){} // RVA: 0x7FFAC2F21310
        public void EndSession(){} // RVA: 0x7FFAC2F21310
        public void BindClient(){} // RVA: 0x7FFAC2F21310
        public void CaptureEnvelope(){} // RVA: 0x7FFAC2F21320
        public void CaptureEvent(){} // RVA: 0x7FFAC8BDE6C0 | overloaded x3
        public void CaptureTransaction(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAC2F21310
        public void CaptureCheckIn(){} // RVA: 0x7FFAC8BDE720
        public void FlushAsync(){} // RVA: 0x7FFAC8BDE780
        public void get_Metrics(){} // RVA: 0x7FFAC2F3C380
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC2F21310
        public void get_LastEventId(){} // RVA: 0x7FFAC8BDE820
        public void .cctor(){} // RVA: 0x7FFAC8BDE880
    }

    public class FormRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        public string SupportedContentType;

        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7FFAC8BDE9B0
        public void DoExtractPayLoad(){} // RVA: 0x7FFAC8BDEAE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class HubAdapter : Object
    {
        public Sentry.Extensibility.HubAdapter IsEnabled;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_IsEnabled(){} // RVA: 0x7FFAC8BDEF00
        public void get_LastEventId(){} // RVA: 0x7FFAC8BDEFB0
        public void ConfigureScope(){} // RVA: 0x7FFAC8BDF080
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAC8BDF0D0
        public void PushScope(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFAC8BDF310 | overloaded x2
        public void BindException(){} // RVA: 0x7FFAC8BDF3D0
        public void GetSpan(){} // RVA: 0x7FFAC8BDF4A0
        public void GetTraceHeader(){} // RVA: 0x7FFAC8BDF4F0
        public void GetBaggage(){} // RVA: 0x7FFAC8BDF5B0
        public void ContinueTrace(){} // RVA: 0x7FFAC8BDF7B0 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFAC8BDF900
        public void PauseSession(){} // RVA: 0x7FFAC8BDF9C0
        public void ResumeSession(){} // RVA: 0x7FFAC8BDFA80
        public void EndSession(){} // RVA: 0x7FFAC8BDFB40
        public void BindClient(){} // RVA: 0x7FFAC8BDFC00
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8BDFD80 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFAC8BE0160 | overloaded x5
        public void CaptureEnvelope(){} // RVA: 0x7FFAC8BDFF50
        public void CaptureException(){} // RVA: 0x7FFAC8BE0250
        public void CaptureTransaction(){} // RVA: 0x7FFAC8BE03C0 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAC8BE04A0
        public void CaptureCheckIn(){} // RVA: 0x7FFAC8BE0550
        public void FlushAsync(){} // RVA: 0x7FFAC8BE0720
        public void get_Metrics(){} // RVA: 0x7FFAC8BE07E0
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC8BE08A0
        public void .cctor(){} // RVA: 0x7FFAC8BE0950
    }

    public class IBackgroundWorker
    {
        public object QueuedItems;

        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0x7FFAC2C59F60
        public void FlushAsync(){}
        public void get_QueuedItems(){} // RVA: 0x7FFAC2C59960
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFAC2C5AB80
        public void Log(){}
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFAC2C59F60
    }

    public class IHttpRequest
    {
        public object ContentLength;
        public object ContentType;
        public object Body;
        public object Form;

        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7FFAC2C588A0
        public void get_ContentType(){} // RVA: 0x7FFAC2C58E90
        public void get_Body(){} // RVA: 0x7FFAC2C58E90
        public void get_Form(){} // RVA: 0x7FFAC2C58E90
    }

    public class INetworkStatusListener
    {
        public object Online;

        // ── Methods ──
        public void get_Online(){} // RVA: 0x7FFAC2C59D00
        public void WaitForNetworkOnlineAsync(){}
    }

    public class IRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C79B30
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISentryEventProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessEvent(){} // RVA: 0x7FFAC8BE09F0
    }

    public class ISentryEventProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C58F40
    }

    public class ISentryTransactionProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessTransaction(){} // RVA: 0x7FFAC8BE0B70
    }

    public class ISentryTransactionProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class ITransport
    {
        // ── Methods ──
        public void SendEnvelopeAsync(){}
    }

    public class RequestBodyExtractionDispatcher : Object
    {
        public Sentry.SentryOptions Extractors; // 0x10
        public System.Func`1<0x6B1A0DA8> _sizeSwitch; // 0x18
        public System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.IRequestPayloadExtractor> <Extractors>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Extractors(){} // RVA: 0x7FFAC2F4F0C0
        public void .ctor(){} // RVA: 0x7FFAC8BE0CF0
        public void ExtractPayload(){} // RVA: 0x7FFAC8BE0ED0
    }

    public class SentryEventExceptionProcessor`1 : Object
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFAC2C79B30
        public void ProcessException(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SentryStackTraceFactory : Object
    {
        public Sentry.SentryOptions _options; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Create(){} // RVA: 0x7FFAC8BE13C0
    }

}