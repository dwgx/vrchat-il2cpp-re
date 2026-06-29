// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 26
// Methods: 132

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class BaseRequestPayloadExtractor : Object
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7AE233E30
        public void IsSupported(){} // RVA: 0x7A7E019D0
        public void DoExtractPayLoad(){} // RVA: 0x7A7E00B20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DefaultRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7A81BD750
        public void DoExtractPayLoad(){} // RVA: 0x7AE234110
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class DiagnosticLoggerExtensions : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7AE234360
        public void LogDebug(){} // RVA: 0x7AA42CF70
        public void LogInfo(){} // RVA: 0x7AA4362C0
        public void LogWarning(){} // RVA: 0x7A8051B10
        public void LogError(){} // RVA: 0x7A8051B10
        public void LogFatal(){} // RVA: 0x7AE234A50
        public void LogIfEnabled(){} // RVA: 0x7A8051B10
    }

    public class DisabledHub : Object
    {
        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7AE234C50
        public void ConfigureScope(){} // RVA: 0x7A80D7310
        public void ConfigureScopeAsync(){} // RVA: 0x7AE234CE0
        public void PushScope(){} // RVA: 0x7A8051B10
        public void StartTransaction(){} // RVA: 0x7AE234D80
        public void BindException(){} // RVA: 0x7A80D7310
        public void GetSpan(){} // RVA: 0x7A82D1450
        public void GetTraceHeader(){} // RVA: 0x7A82D1450
        public void GetBaggage(){} // RVA: 0x7A82D1450
        public void ContinueTrace(){} // RVA: 0x7AE234FD0
        public void StartSession(){} // RVA: 0x7A80D7310
        public void PauseSession(){} // RVA: 0x7A80D7310
        public void ResumeSession(){} // RVA: 0x7A80D7310
        public void EndSession(){} // RVA: 0x7A80D7310
        public void BindClient(){} // RVA: 0x7A80D7310
        public void CaptureEnvelope(){} // RVA: 0x7A80D7320
        public void CaptureEvent(){} // RVA: 0x7AE235240
        public void CaptureTransaction(){} // RVA: 0x7A80D7310
        public void CaptureSession(){} // RVA: 0x7A80D7310
        public void CaptureCheckIn(){} // RVA: 0x7AE2352A0
        public void FlushAsync(){} // RVA: 0x7AE235300
        public void get_Metrics(){} // RVA: 0x7A80F2570
        public void Dispose(){} // RVA: 0x7A80D7310
        public void CaptureUserFeedback(){} // RVA: 0x7A80D7310
        public void get_LastEventId(){} // RVA: 0x7AE2353A0
        public void .cctor(){} // RVA: 0x7AE235400
    }

    public class FormRequestPayloadExtractor : BaseRequestPayloadExtractor
    {
        // ── Methods ──
        public void IsSupported(){} // RVA: 0x7AE235530
        public void DoExtractPayLoad(){} // RVA: 0x7AE235660
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class HubAdapter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_IsEnabled(){} // RVA: 0x7AE235A80
        public void get_LastEventId(){} // RVA: 0x7AE235B30
        public void ConfigureScope(){} // RVA: 0x7AE235C00
        public void ConfigureScopeAsync(){} // RVA: 0x7AE235C50
        public void PushScope(){} // RVA: 0x7A8051B10
        public void StartTransaction(){} // RVA: 0x7AE235E90
        public void BindException(){} // RVA: 0x7AE235F50
        public void GetSpan(){} // RVA: 0x7AE236020
        public void GetTraceHeader(){} // RVA: 0x7AE236070
        public void GetBaggage(){} // RVA: 0x7AE236130
        public void ContinueTrace(){} // RVA: 0x7AE236330
        public void StartSession(){} // RVA: 0x7AE236480
        public void PauseSession(){} // RVA: 0x7AE236540
        public void ResumeSession(){} // RVA: 0x7AE236600
        public void EndSession(){} // RVA: 0x7AE2366C0
        public void BindClient(){} // RVA: 0x7AE236780
        public void AddBreadcrumb(){} // RVA: 0x7AE236900
        public void CaptureEvent(){} // RVA: 0x7AE236CE0
        public void CaptureEnvelope(){} // RVA: 0x7AE236AD0
        public void CaptureException(){} // RVA: 0x7AE236DD0
        public void CaptureTransaction(){} // RVA: 0x7AE236F40
        public void CaptureSession(){} // RVA: 0x7AE237020
        public void CaptureCheckIn(){} // RVA: 0x7AE2370D0
        public void FlushAsync(){} // RVA: 0x7AE2372A0
        public void get_Metrics(){} // RVA: 0x7AE237360
        public void CaptureUserFeedback(){} // RVA: 0x7AE237420
        public void .cctor(){} // RVA: 0x7AE2374D0
    }

    public class IBackgroundWorker
    {
        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0x7A7E019D0
        public void FlushAsync(){} // RVA: 0x7A7E063E0
        public void get_QueuedItems(){} // RVA: 0x7A7E00710
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7A7E01990
        public void Log(){} // RVA: 0x7A7E1A620
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7A7E019D0
    }

    public class IExceptionFilter[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IHttpRequest
    {
        // ── Methods ──
        public void get_ContentLength(){} // RVA: 0x7A7E00490
        public void get_ContentType(){} // RVA: 0x7A7E00680
        public void get_Body(){} // RVA: 0x7A7E00680
        public void get_Form(){} // RVA: 0x7A7E00680
    }

    public class INetworkStatusListener
    {
        // ── Methods ──
        public void get_Online(){} // RVA: 0x7A7E01900
        public void WaitForNetworkOnlineAsync(){} // RVA: 0x7A7E063E0
    }

    public class IRequestPayloadExtractor
    {
        // ── Methods ──
        public void ExtractPayload(){} // RVA: 0x7A7E00B20
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E18890
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00B20
    }

    public class ISentryEventProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessEvent(){} // RVA: 0x7AE237570
    }

    public class ISentryEventProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00BD0
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00B20
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00B20
    }

    public class ISentryTransactionProcessorExtensions : Object
    {
        // ── Methods ──
        public void DoProcessTransaction(){} // RVA: 0x7AE2376F0
    }

    public class ISentryTransactionProcessorWithHint
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E00BD0
    }

    public class ISentryTransactionProcessor[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ITransport
    {
        // ── Methods ──
        public void SendEnvelopeAsync(){} // RVA: 0x7A7E06640
    }

    public class RequestBodyExtractionDispatcher : Object
    {
        // ── Methods ──
        public void get_Extractors(){} // RVA: 0x7A81052C0
        public void .ctor(){} // RVA: 0x7AE237870
        public void ExtractPayload(){} // RVA: 0x7AE237A50
    }

    public class SentryEventExceptionProcessor`1 : Object
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7A7E18890
        public void ProcessException(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A7E18770
    }

    public class SentryStackTraceFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Create(){} // RVA: 0x7AE237F40
    }

}