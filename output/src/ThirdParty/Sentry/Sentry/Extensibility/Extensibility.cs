// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Extensibility
// Classes: 12
// Methods: 142

namespace ThirdParty.Sentry.Sentry.Extensibility
{
    public class DiagnosticLoggerExtensions : Object
    {
        // ── Methods ──
        public void Log(){} // RVA: 0x7FFD53FFD7E0
        public void LogDebug(){} // RVA: 0x7FFD53FFD930 | overloaded x7
        public void LogInfo(){} // RVA: 0x7FFD4E2ADC40 | overloaded x8
        public void LogWarning(){} // RVA: 0x7FFD4E2ADC40 | overloaded x9
        public void LogError(){} // RVA: 0x7FFD4E2ADC40 | overloaded x18
        public void LogFatal(){} // RVA: 0x7FFD53FFDED0 | overloaded x4
        public void LogIfEnabled(){} // RVA: 0x7FFD4E2ADC40 | overloaded x11
    }

    public class DisabledHub : Object
    {
        public object IsEnabled;
        public object Metrics;
        public object LastEventId;

        // ── Methods ──
        public void get_IsEnabled(){} // RVA: 0x7FFD4E341320
        public void .ctor(){} // RVA: 0x7FFD53FFE0D0
        public void ConfigureScope(){} // RVA: 0x7FFD4E341310
        public void ConfigureScopeAsync(){} // RVA: 0x7FFD53FFE160
        public void PushScope(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFD53FFE200
        public void BindException(){} // RVA: 0x7FFD4E341310
        public void GetSpan(){} // RVA: 0x7FFD4E919180
        public void GetTraceHeader(){} // RVA: 0x7FFD4E919180
        public void GetBaggage(){} // RVA: 0x7FFD4E919180
        public void ContinueTrace(){} // RVA: 0x7FFD53FFE450 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFD4E341310
        public void PauseSession(){} // RVA: 0x7FFD4E341310
        public void ResumeSession(){} // RVA: 0x7FFD4E341310
        public void EndSession(){} // RVA: 0x7FFD4E341310
        public void BindClient(){} // RVA: 0x7FFD4E341310
        public void CaptureEnvelope(){} // RVA: 0x7FFD4E341320
        public void CaptureEvent(){} // RVA: 0x7FFD53FFE6C0 | overloaded x3
        public void CaptureTransaction(){} // RVA: 0x7FFD4E341310 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFD4E341310
        public void CaptureCheckIn(){} // RVA: 0x7FFD53FFE720
        public void FlushAsync(){} // RVA: 0x7FFD53FFE780
        public void get_Metrics(){} // RVA: 0x7FFD4E35C380
        public void Dispose(){} // RVA: 0x7FFD4E341310
        public void CaptureUserFeedback(){} // RVA: 0x7FFD4E341310
        public void get_LastEventId(){} // RVA: 0x7FFD53FFE820
        public void .cctor(){} // RVA: 0x7FFD53FFE880
    }

    public class HubAdapter : Object
    {
        public object IsEnabled;
        public object LastEventId;
        public object Metrics;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_IsEnabled(){} // RVA: 0x7FFD53FFEF00
        public void get_LastEventId(){} // RVA: 0x7FFD53FFEFB0
        public void ConfigureScope(){} // RVA: 0x7FFD53FFF080
        public void ConfigureScopeAsync(){} // RVA: 0x7FFD53FFF0D0
        public void PushScope(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void StartTransaction(){} // RVA: 0x7FFD53FFF310 | overloaded x2
        public void BindException(){} // RVA: 0x7FFD53FFF3D0
        public void GetSpan(){} // RVA: 0x7FFD53FFF4A0
        public void GetTraceHeader(){} // RVA: 0x7FFD53FFF4F0
        public void GetBaggage(){} // RVA: 0x7FFD53FFF5B0
        public void ContinueTrace(){} // RVA: 0x7FFD53FFF7B0 | overloaded x2
        public void StartSession(){} // RVA: 0x7FFD53FFF900
        public void PauseSession(){} // RVA: 0x7FFD53FFF9C0
        public void ResumeSession(){} // RVA: 0x7FFD53FFFA80
        public void EndSession(){} // RVA: 0x7FFD53FFFB40
        public void BindClient(){} // RVA: 0x7FFD53FFFC00
        public void AddBreadcrumb(){} // RVA: 0x7FFD53FFFD80 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFD54000160 | overloaded x5
        public void CaptureEnvelope(){} // RVA: 0x7FFD53FFFF50
        public void CaptureException(){} // RVA: 0x7FFD54000250
        public void CaptureTransaction(){} // RVA: 0x7FFD540003C0 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFD540004A0
        public void CaptureCheckIn(){} // RVA: 0x7FFD54000550
        public void FlushAsync(){} // RVA: 0x7FFD54000720
        public void get_Metrics(){} // RVA: 0x7FFD540007E0
        public void CaptureUserFeedback(){} // RVA: 0x7FFD540008A0
        public void .cctor(){} // RVA: 0x7FFD54000950
    }

    public class IBackgroundWorker
    {
        public object QueuedItems;

        // ── Methods ──
        public void EnqueueEnvelope(){} // RVA: 0x7FFD4E079F60
        public void FlushAsync(){}
        public void get_QueuedItems(){} // RVA: 0x7FFD4E079960
    }

    public class IDiagnosticLogger
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFD4E07AB80
        public void Log(){}
    }

    public class IExceptionFilter
    {
        // ── Methods ──
        public void Filter(){} // RVA: 0x7FFD4E079F60
    }

    public class INetworkStatusListener
    {
        public object Online;

        // ── Methods ──
        public void get_Online(){} // RVA: 0x7FFD4E079D00
        public void WaitForNetworkOnlineAsync(){}
    }

    public class ISentryEventExceptionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD4E099B30
    }

    public class ISentryEventProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD4E078F40
    }

    public class ISentryStackTraceFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFD4E078F40
    }

    public class ISentryTransactionProcessor
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD4E078F40
    }

    public class SentryEventExceptionProcessor`1 : Object
    {
        // ── Methods ──
        public void Process(){} // RVA: 0x7FFD4E099B30
        public void ProcessException(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

}