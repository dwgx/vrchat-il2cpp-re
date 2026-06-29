// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 26
// Methods: 132

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class BaseRequestPayloadExtractor : Object
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x6EB6990
        public void IsSupported(){} // RVA: 0x87D350
        public void DoExtractPayLoad(){} // RVA: 0x87C540
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DefaultRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0xC2E4C0
        public void DoExtractPayLoad(){} // RVA: 0x6EB6C70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DiagnosticLoggerExtensions : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x6EB6EC0
        public void LogDebug(){} // RVA: 0x3056A10
        public void LogInfo(){} // RVA: 0x305FF00
        public void LogWarning(){} // RVA: 0xA94080
        public void LogError(){} // RVA: 0xA94080
        public void LogFatal(){} // RVA: 0x6EB75B0
        public void LogIfEnabled(){} // RVA: 0xA94080
    }

    public class DisabledHub : Object
    {
        public object Instance;
        public object _metrics;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0x6EB77B0
        public void ConfigureScope(){} // RVA: 0xB43310
        public void ConfigureScopeAsync(){} // RVA: 0x6EB7840
        public void PushScope(){} // RVA: 0xA94080
        public void StartTransaction(){} // RVA: 0x6EB78E0
        public void BindException(){} // RVA: 0xB43310
        public void GetSpan(){} // RVA: 0xDAC980
        public void GetTraceHeader(){} // RVA: 0xDAC980
        public void GetBaggage(){} // RVA: 0xDAC980
        public void ContinueTrace(){} // RVA: 0x6EB7B20
        public void StartSession(){} // RVA: 0xB43310
        public void PauseSession(){} // RVA: 0xB43310
        public void ResumeSession(){} // RVA: 0xB43310
        public void EndSession(){} // RVA: 0xB43310
        public void BindClient(){} // RVA: 0xB43310
        public void CaptureEnvelope(){} // RVA: 0xB43320
        public void CaptureEvent(){} // RVA: 0x6EB7D80
        public void CaptureTransaction(){} // RVA: 0xB43310
        public void CaptureSession(){} // RVA: 0xB43310
        public void CaptureCheckIn(){} // RVA: 0x6EB7DE0
        public void FlushAsync(){} // RVA: 0x6EB7E40
        public void get_Metrics(){} // RVA: 0xB5DBF0
        public void Dispose(){} // RVA: 0xB43310
        public void CaptureUserFeedback(){} // RVA: 0xB43310
        public void get_LastEventId(){} // RVA: 0x6EB7EE0
        public void .cctor(){} // RVA: 0x6EB7F40
    }

    public class FormRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        public object SupportedContentType;

        // ── Methods ──
        public void IsSupported(){} // RVA: 0x6EB8070
        public void DoExtractPayLoad(){} // RVA: 0x6EB81A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class HubAdapter : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_IsEnabled(){} // RVA: 0x6EB85C0
        public void get_LastEventId(){} // RVA: 0x6EB8670
        public void ConfigureScope(){} // RVA: 0x6EB8740
        public void ConfigureScopeAsync(){} // RVA: 0x6EB8790
        public void PushScope(){} // RVA: 0xA94080
        public void StartTransaction(){} // RVA: 0x6EB89D0
        public void BindException(){} // RVA: 0x6EB8A90
        public void GetSpan(){} // RVA: 0x6EB8B60
        public void GetTraceHeader(){} // RVA: 0x6EB8BB0
        public void GetBaggage(){} // RVA: 0x6EB8C70
        public void ContinueTrace(){} // RVA: 0x6EB8E70
        public void StartSession(){} // RVA: 0x6EB8FC0
        public void PauseSession(){} // RVA: 0x6EB9080
        public void ResumeSession(){} // RVA: 0x6EB9140
        public void EndSession(){} // RVA: 0x6EB9200
        public void BindClient(){} // RVA: 0x6EB92C0
        public void AddBreadcrumb(){} // RVA: 0x6EB9440
        public void CaptureEvent(){} // RVA: 0x6EB9820
        public void CaptureEnvelope(){} // RVA: 0x6EB9610
        public void CaptureException(){} // RVA: 0x6EB9910
        public void CaptureTransaction(){} // RVA: 0x6EB9A80
        public void CaptureSession(){} // RVA: 0x6EB9B60
        public void CaptureCheckIn(){} // RVA: 0x6EB9C10
        public void FlushAsync(){} // RVA: 0x6EB9DE0
        public void get_Metrics(){} // RVA: 0x6EB9EA0
        public void CaptureUserFeedback(){} // RVA: 0x6EB9F60
        public void .cctor(){} // RVA: 0x6EBA010
    }

    public class IBackgroundWorker
    {
        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0x87D350
        public void FlushAsync(){} // RVA: 0x881D60
        public void get_QueuedItems(){} // RVA: 0x87C130
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x87D310
        public void Log(){} // RVA: 0x896190
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x87D350
    }

    public class IExceptionFilter[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IHttpRequest
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x87BEB0
        public void get_ContentType(){} // RVA: 0x87C0A0
        public void get_Body(){} // RVA: 0x87C0A0
        public void get_Form(){} // RVA: 0x87C0A0
    }

    public class INetworkStatusListener
    {
        // ── Methods ──
        public void get_Online(){} // RVA: 0x87D280
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x881D60
    }

    public class IRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x87C540
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x8943B0
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C540
    }

    public class ISentryEventProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessEvent(){} // RVA: 0x6EBA0B0
    }

    public class ISentryEventProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C5F0
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x87C540
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C540
    }

    public class ISentryTransactionProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessTransaction(){} // RVA: 0x6EBA230
    }

    public class ISentryTransactionProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x87C5F0
    }

    public class ISentryTransactionProcessor[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ITransport
    {
        // ── Methods ──
        public void SendEnvelopeAsync(){} // RVA: 0x881FC0
    }

    public class RequestBodyExtractionDispatcher : Object
    {
        public object _options;
        public object _sizeSwitch;
        public object _extractors;

        // ── Methods ──
        public void get_Extractors(){} // RVA: 0xB700F0
        public void .ctor(){} // RVA: 0x6EBA3B0
        public void ExtractPayload(){} // RVA: 0x6EBA590
    }

    public class SentryEventExceptionProcessor`1 : Object
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x8943B0
        public void ProcessException(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class SentryStackTraceFactory : Object
    {
        public object _options;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Create(){} // RVA: 0x6EBAA70
    }

}