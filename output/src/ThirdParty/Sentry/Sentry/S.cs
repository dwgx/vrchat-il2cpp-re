// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 44
// Methods: 986

namespace ThirdParty.Sentry.Sentry
{
    public class Scope : Object
    {
        public Sentry.SentryOptions Options; // 0x10
        public bool Locked; // 0x18
        public object LastEventId; // 0x20
        public Sentry.SentryId HasEvaluated; // 0x28
        public object ExceptionProcessors; // 0x38
        public bool EventProcessors; // 0x40
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentBag`1<Sentry.Extensibility.ISentryEventExceptionProcessor>> TransactionProcessors; // 0x48
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentBag`1<Sentry.Extensibility.ISentryEventProcessor>> Level; // 0x50
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentBag`1<Sentry.Extensibility.ISentryTransactionProcessor>> Request; // 0x58
        public System.EventHandler`1<Sentry.Scope> Contexts; // 0x60
        public System.Nullable`1<0x6B198C68> UserChanged; // 0x68
        public Sentry.SentryRequest User; // 0x70
        public Sentry.SentryContexts Release; // 0x78
        public Sentry.SentryUser Distribution; // 0x80
        public string Environment; // 0x88
        public string TransactionName; // 0x90
        public string Transaction; // 0x98
        public string PropagationContext; // 0xA0
        public Sentry.ITransactionTracer SessionUpdate; // 0xA8
        public Sentry.SentryPropagationContext Sdk; // 0xB0
        public Sentry.SessionUpdate Fingerprint; // 0xB8
        public Sentry.SdkVersion Breadcrumbs; // 0xC0
        public System.Collections.Generic.IReadOnlyList`1<string> Extra; // 0xC8
        public System.Collections.Concurrent.ConcurrentQueue`1<Sentry.Breadcrumb> Tags; // 0xD0
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> Attachments; // 0xD8
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> Span; // 0xE0
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.SentryAttachment> _attachments; // 0xE8
        public Sentry.ISpan _span; // 0xF0

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAC2F3C380
        public void get_Locked(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Locked(){} // RVA: 0x7FFAC2F3C4F0
        public void get_LastEventId(){} // RVA: 0x7FFAC8A4DB70
        public void set_LastEventId(){} // RVA: 0x7FFAC8A4DCC0
        public void get_HasEvaluated(){} // RVA: 0x7FFAC8A4DE00
        public void get_ExceptionProcessors(){} // RVA: 0x7FFAC8A4DE10
        public void get_EventProcessors(){} // RVA: 0x7FFAC8A4DE60
        public void get_TransactionProcessors(){} // RVA: 0x7FFAC8A4DEB0
        public void add_OnEvaluating(){} // RVA: 0x7FFAC8A4DF00
        public void remove_OnEvaluating(){} // RVA: 0x7FFAC8A4E000
        public void get_Level(){} // RVA: 0x7FFAC47BAB50
        public void set_Level(){} // RVA: 0x7FFAC47BAB60
        public void get_Request(){} // RVA: 0x7FFAC8A4E100
        public void set_Request(){} // RVA: 0x7FFAC2FE95A0
        public void get_Contexts(){} // RVA: 0x7FFAC30E5600
        public void set_Contexts(){} // RVA: 0x7FFAC8A4E1A0
        public void get_UserChanged(){} // RVA: 0x7FFAC8A4E1C0
        public void get_User(){} // RVA: 0x7FFAC8A4E240
        public void set_User(){} // RVA: 0x7FFAC8A4E360
        public void get_Release(){} // RVA: 0x7FFAC2F60010
        public void set_Release(){} // RVA: 0x7FFAC354E300
        public void get_Distribution(){} // RVA: 0x7FFAC32EF640
        public void set_Distribution(){} // RVA: 0x7FFAC354E360
        public void get_Environment(){} // RVA: 0x7FFAC354DFB0
        public void set_Environment(){} // RVA: 0x7FFAC354E3C0
        public void get_TransactionName(){} // RVA: 0x7FFAC8A4E430
        public void set_TransactionName(){} // RVA: 0x7FFAC8A4E490
        public void get_Transaction(){} // RVA: 0x7FFAC354B1A0
        public void set_Transaction(){} // RVA: 0x7FFAC334B370
        public void get_PropagationContext(){} // RVA: 0x7FFAC2F8C040
        public void set_PropagationContext(){} // RVA: 0x7FFAC2F8C050
        public void get_SessionUpdate(){} // RVA: 0x7FFAC2F8C0B0
        public void set_SessionUpdate(){} // RVA: 0x7FFAC2F8C0C0
        public void get_Sdk(){} // RVA: 0x7FFAC2F8C120
        public void get_Fingerprint(){} // RVA: 0x7FFAC3079460
        public void set_Fingerprint(){} // RVA: 0x7FFAC3079470
        public void get_Breadcrumbs(){} // RVA: 0x7FFAC303E100
        public void get_Extra(){} // RVA: 0x7FFAC3540F70
        public void get_Tags(){} // RVA: 0x7FFAC2FA2900
        public void get_Attachments(){} // RVA: 0x7FFAC2FA2970
        public void .ctor(){} // RVA: 0x7FFAC8A4EEA0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8A4EF80 | overloaded x2
        public void SetExtra(){} // RVA: 0x7FFAC8A4F1B0
        public void SetTag(){} // RVA: 0x7FFAC8A4F260
        public void UnsetTag(){} // RVA: 0x7FFAC8A4F410
        public void AddAttachment(){} // RVA: 0x7FFAC8A52F80 | overloaded x4
        public void Clear(){} // RVA: 0x7FFAC8A4F580
        public void ClearAttachments(){} // RVA: 0x7FFAC8A4FBC0
        public void ClearBreadcrumbs(){} // RVA: 0x7FFAC8A4FC70
        public void Apply(){} // RVA: 0x7FFAC8A51290 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAC8A51370
        public void Evaluate(){} // RVA: 0x7FFAC8A51BE0
        public void get_Span(){} // RVA: 0x7FFAC8A51E80
        public void set_Span(){} // RVA: 0x7FFAC2F8C2B0
        public void GetAllEventProcessors(){} // RVA: 0x7FFAC8A51F70
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFAC8A52020
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFAC8A520D0
        public void AddExceptionProcessor(){} // RVA: 0x7FFAC8A52180
        public void AddExceptionProcessors(){} // RVA: 0x7FFAC8A52210
        public void AddEventProcessor(){} // RVA: 0x7FFAC8A524E0 | overloaded x2
        public void AddEventProcessors(){} // RVA: 0x7FFAC8A52600
        public void AddTransactionProcessor(){} // RVA: 0x7FFAC8A528D0 | overloaded x2
        public void AddTransactionProcessors(){} // RVA: 0x7FFAC8A529F0
        public void ResetTransaction(){} // RVA: 0x7FFAC8A53100
        public void <get_UserChanged>b__41_0(){} // RVA: 0x7FFAC8A53160
    }

    public class SdkVersion : Object
    {
        public System.Lazy`1<Sentry.SdkVersion> Instance;
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.SentryPackage> InternalPackages; // 0x10
        public System.Collections.Concurrent.ConcurrentBag`1<string> Integrations; // 0x18
        public string Packages; // 0x20
        public string Name; // 0x28

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8B28EB0
        public void get_InternalPackages(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalPackages(){} // RVA: 0x7FFAC2F22E30
        public void get_Integrations(){} // RVA: 0x7FFAC2F247C0
        public void set_Integrations(){} // RVA: 0x7FFAC2F87E80
        public void get_Packages(){} // RVA: 0x7FFAC2F3C380
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Name(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Version(){} // RVA: 0x7FFAC2F4F130
        public void set_Version(){} // RVA: 0x7FFAC2F22E90
        public void AddPackage(){} // RVA: 0x7FFAC8B28FF0 | overloaded x2
        public void AddIntegration(){} // RVA: 0x7FFAC8B29050
        public void WriteTo(){} // RVA: 0x7FFAC8B290B0
        public void FromJson(){} // RVA: 0x7FFAC8B29330
        public void .ctor(){} // RVA: 0x7FFAC8B29F30
        public void .cctor(){} // RVA: 0x7FFAC8B2A090
    }

    public class SentryAttachment : Object
    {
        public 0x6B198480 Type; // 0x10
        public Sentry.IAttachmentContent Content; // 0x18
        public string FileName; // 0x20
        public string ContentType; // 0x28

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Content(){} // RVA: 0x7FFAC2F247C0
        public void get_FileName(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ContentType(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC83917D0
    }

    public class SentryCheckIn : Object
    {
        public Sentry.SentryId Id; // 0x10
        public string MonitorSlug; // 0x20
        public 0x6B198530 Status; // 0x28
        public System.Nullable`1<System.TimeSpan> Duration; // 0x30
        public string Release; // 0x40
        public string Environment; // 0x48
        public System.Nullable`1<Sentry.SentryId> TraceId; // 0x50
        public Sentry.SentryMonitorOptions MonitorOptions; // 0x68

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC4422E80
        public void get_MonitorSlug(){} // RVA: 0x7FFAC2F4F0C0
        public void get_Status(){} // RVA: 0x7FFAC32EC4C0
        public void get_Duration(){} // RVA: 0x7FFAC845FF30
        public void set_Duration(){} // RVA: 0x7FFAC845FF40
        public void get_Release(){} // RVA: 0x7FFAC2F9E740
        public void set_Release(){} // RVA: 0x7FFAC2F49200
        public void get_Environment(){} // RVA: 0x7FFAC2F9C730
        public void set_Environment(){} // RVA: 0x7FFAC2F9C740
        public void get_TraceId(){} // RVA: 0x7FFAC6AFCAA0
        public void set_TraceId(){} // RVA: 0x7FFAC8B2A500
        public void get_MonitorOptions(){} // RVA: 0x7FFAC2F9CD50
        public void set_MonitorOptions(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC8B2A510
        public void WriteTo(){} // RVA: 0x7FFAC8B2A660
        public void ToSnakeCase(){} // RVA: 0x7FFAC8B2AB60
    }

    public class SentryClient : Object
    {
        public Sentry.SentryOptions Worker; // 0x10
        public Sentry.ISessionManager Options; // 0x18
        public Sentry.Internal.RandomValuesFactory IsEnabled; // 0x20
        public Sentry.Internal.Enricher _enricher; // 0x28
        public Sentry.Extensibility.IBackgroundWorker <Worker>k__BackingField; // 0x30

        // ── Methods ──
        public void get_Worker(){} // RVA: 0x7FFAC31D95E0
        public void get_Options(){} // RVA: 0x7FFAC2F3C380
        public void get_IsEnabled(){} // RVA: 0x7FFAC3006850
        public void .ctor(){} // RVA: 0x7FFAC8B2AC90 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFAC8B2B270
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC8B2B420
        public void CaptureTransaction(){} // RVA: 0x7FFAC8B2B720 | overloaded x2
        public void BeforeSendTransaction(){} // RVA: 0x7FFAC8B2C360
        public void CaptureSession(){} // RVA: 0x7FFAC8B2C660
        public void CaptureCheckIn(){} // RVA: 0x7FFAC8B2C7F0
        public void FlushAsync(){} // RVA: 0x7FFAC8B2CDD0
        public void DoSendEvent(){} // RVA: 0x7FFAC8B2CE30
        public void ApplyExceptionFilters(){} // RVA: 0x7FFAC8B2E2A0
        public void CaptureEnvelope(){} // RVA: 0x7FFAC8B2E5D0
        public void BeforeSend(){} // RVA: 0x7FFAC8B2E7A0
        public void Dispose(){} // RVA: 0x7FFAC8B2EAA0
    }

    public class SentryClientExtensions : Object
    {
        public Sentry.SentryOptions SentryOptionsForTestingOnly;

        // ── Methods ──
        public void CaptureException(){} // RVA: 0x7FFAC8B2ED50
        public void CaptureMessage(){} // RVA: 0x7FFAC8B2EEC0
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC8B2F090
        public void Flush(){} // RVA: 0x7FFAC8B2F210 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFAC8B2F2F0
        public void get_SentryOptionsForTestingOnly(){} // RVA: 0x7FFAC8B2F390
        public void set_SentryOptionsForTestingOnly(){} // RVA: 0x7FFAC8B2F3D0
        public void GetSentryOptions(){} // RVA: 0x7FFAC8B2F470
    }

    public class SentryConstants : Object
    {
        public string DisableSdkDsnValue;
        public int DefaultMaxBreadcrumbs;
        public int ProtocolVersion;
        public string Platform;
    }

    public class SentryContexts : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> App; // 0x10

        // ── Methods ──
        public void get_App(){} // RVA: 0x7FFAC8B2F5E0
        public void get_Browser(){} // RVA: 0x7FFAC8B2F640
        public void get_Device(){} // RVA: 0x7FFAC8B2F6A0
        public void get_OperatingSystem(){} // RVA: 0x7FFAC8B2F700
        public void get_Response(){} // RVA: 0x7FFAC8B2F760
        public void get_Runtime(){} // RVA: 0x7FFAC8B2F7C0
        public void get_Gpu(){} // RVA: 0x7FFAC8B2F820
        public void get_Trace(){} // RVA: 0x7FFAC8B2F880
        public void .ctor(){} // RVA: 0x7FFAC8B2F8E0
        public void Clone(){} // RVA: 0x7FFAC8B2FA20
        public void CopyTo(){} // RVA: 0x7FFAC8B31180 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC8B2FE00
        public void FromJson(){} // RVA: 0x7FFAC8B30080
        public void ReplaceWith(){} // RVA: 0x7FFAC8B30BD0
        public void NullIfEmpty(){} // RVA: 0x7FFAC8B30E80
        public void GetEnumerator(){} // RVA: 0x7FFAC8B30EE0
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAC8B30F30
        public void Add(){} // RVA: 0x7FFAC8B313D0 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAC8B31050
        public void Contains(){} // RVA: 0x7FFAC8B310A0
        public void Remove(){} // RVA: 0x7FFAC8B314C0 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAC8B31330
        public void get_IsReadOnly(){} // RVA: 0x7FFAC8B31380
        public void ContainsKey(){} // RVA: 0x7FFAC8B31460
        public void TryGetValue(){} // RVA: 0x7FFAC8B31520
        public void get_Item(){} // RVA: 0x7FFAC8B31700
        public void set_Item(){} // RVA: 0x7FFAC8B31760
        public void get_Keys(){} // RVA: 0x7FFAC8B317D0
        public void get_Values(){} // RVA: 0x7FFAC8B31830
    }

    public class SentryEvent : Object
    {
        public System.Collections.Generic.IDictionary`2<string,string> Exception; // 0x10
        public System.Exception EventId; // 0x18
        public Sentry.SentryId Timestamp; // 0x20
        public System.DateTimeOffset Message; // 0x30
        public Sentry.SentryMessage Logger; // 0x40
        public string Platform; // 0x48
        public string ServerName; // 0x50
        public string Release; // 0x58
        public string Distribution; // 0x60
        public string SentryExceptionValues; // 0x68
        public Sentry.SentryValues`1<Sentry.Protocol.SentryException> SentryExceptions; // 0x70
        public Sentry.SentryValues`1<Sentry.SentryThread> SentryThreadValues; // 0x78
        public Sentry.Protocol.DebugMeta SentryThreads; // 0x80
        public System.Nullable`1<0x6B198C68> DebugImages; // 0x88
        public string Modules; // 0x90
        public Sentry.SentryRequest Level; // 0x98
        public Sentry.SentryContexts TransactionName; // 0xA0
        public Sentry.SentryUser Request; // 0xA8
        public string Contexts; // 0xB0
        public Sentry.SdkVersion User; // 0xB8
        public System.Collections.Generic.IReadOnlyList`1<string> Environment; // 0xC0
        public System.Collections.Generic.List`1<Sentry.Breadcrumb> Sdk; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,object> Fingerprint; // 0xD0
        public System.Collections.Generic.Dictionary`2<string,string> Breadcrumbs; // 0xD8
        public Sentry.DynamicSamplingContext Extra; // 0xE0

        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7FFAC2F247C0
        public void get_EventId(){} // RVA: 0x7FFAC4A19630
        public void get_Timestamp(){} // RVA: 0x7FFAC845FF30
        public void get_Message(){} // RVA: 0x7FFAC2F9E740
        public void set_Message(){} // RVA: 0x7FFAC2F49200
        public void get_Logger(){} // RVA: 0x7FFAC2F9C730
        public void set_Logger(){} // RVA: 0x7FFAC2F9C740
        public void get_Platform(){} // RVA: 0x7FFAC2FC20E0
        public void set_Platform(){} // RVA: 0x7FFAC30794D0
        public void get_ServerName(){} // RVA: 0x7FFAC2FE9500
        public void set_ServerName(){} // RVA: 0x7FFAC2FE9510
        public void get_Release(){} // RVA: 0x7FFAC2FBF370
        public void set_Release(){} // RVA: 0x7FFAC2FBF380
        public void get_Distribution(){} // RVA: 0x7FFAC2F9CD50
        public void set_Distribution(){} // RVA: 0x7FFAC2F9CD60
        public void get_SentryExceptionValues(){} // RVA: 0x7FFAC2FE9590
        public void set_SentryExceptionValues(){} // RVA: 0x7FFAC2FE95A0
        public void get_SentryExceptions(){} // RVA: 0x7FFAC8B31D60
        public void set_SentryExceptions(){} // RVA: 0x7FFAC8B31DD0
        public void get_SentryThreadValues(){} // RVA: 0x7FFAC30E5600
        public void set_SentryThreadValues(){} // RVA: 0x7FFAC30E06F0
        public void get_SentryThreads(){} // RVA: 0x7FFAC8B31F00
        public void set_SentryThreads(){} // RVA: 0x7FFAC8B31F70
        public void get_DebugImages(){} // RVA: 0x7FFAC8B320A0
        public void set_DebugImages(){} // RVA: 0x7FFAC8B320C0
        public void get_Modules(){} // RVA: 0x7FFAC8B321E0
        public void get_Level(){} // RVA: 0x7FFAC37EE8C0
        public void set_Level(){} // RVA: 0x7FFAC37F9DE0
        public void get_TransactionName(){} // RVA: 0x7FFAC32EF640
        public void set_TransactionName(){} // RVA: 0x7FFAC354E360
        public void get_Request(){} // RVA: 0x7FFAC8B322A0
        public void set_Request(){} // RVA: 0x7FFAC354E3C0
        public void get_Contexts(){} // RVA: 0x7FFAC3543900
        public void set_Contexts(){} // RVA: 0x7FFAC8B32340
        public void get_User(){} // RVA: 0x7FFAC8B32370
        public void set_User(){} // RVA: 0x7FFAC334B370
        public void get_Environment(){} // RVA: 0x7FFAC2F8C040
        public void set_Environment(){} // RVA: 0x7FFAC2F8C050
        public void get_Sdk(){} // RVA: 0x7FFAC2F8C0B0
        public void set_Sdk(){} // RVA: 0x7FFAC2F8C0C0
        public void get_Fingerprint(){} // RVA: 0x7FFAC8B32410
        public void set_Fingerprint(){} // RVA: 0x7FFAC2F8C130
        public void get_Breadcrumbs(){} // RVA: 0x7FFAC8B32460
        public void get_Extra(){} // RVA: 0x7FFAC8B32530
        public void get_Tags(){} // RVA: 0x7FFAC8B32600
        public void HasException(){} // RVA: 0x7FFAC8B326D0
        public void HasTerminalException(){} // RVA: 0x7FFAC8B32740
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFAC2FA2900
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFAC2FA2910
        public void .ctor(){} // RVA: 0x7FFAC8B32B60 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8B32F90
        public void SetExtra(){} // RVA: 0x7FFAC8B33090
        public void SetTag(){} // RVA: 0x7FFAC8B331C0
        public void UnsetTag(){} // RVA: 0x7FFAC8B332F0
        public void Redact(){} // RVA: 0x7FFAC8B333F0
        public void WriteTo(){} // RVA: 0x7FFAC8B33650
        public void FromJson(){} // RVA: 0x7FFAC8B33EA0 | overloaded x2
    }

    public class SentryFailedRequestHandler : Object
    {
        public Sentry.IHub Hub; // 0x10
        public Sentry.SentryOptions Options; // 0x18

        // ── Methods ──
        public void get_Hub(){} // RVA: 0x7FFAC2F3C380
        public void get_Options(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFAC2C79B30
        public void HandleResponse(){} // RVA: 0x7FFAC8B36730
    }

    public class SentryGraphQLHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        public Sentry.IHub _hub; // 0x20
        public Sentry.SentryOptions _options; // 0x28
        public string MechanismType;
        public Sentry.SentryHttpFailedRequestHandler _httpFailedRequestHandler; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B36950
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFAC8B36AD0
    }

    public class SentryGraphQLHttpMessageHandler : SentryMessageHandler
    {
        public Sentry.IHub _hub; // 0x38
        public Sentry.SentryOptions _options; // 0x40
        public Sentry.ISentryFailedRequestHandler _failedRequestHandler; // 0x48
        public string GraphQlOrigin;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B37360 | overloaded x2
        public void ProcessRequest(){} // RVA: 0x7FFAC8B376F0
        public void HandleResponse(){} // RVA: 0x7FFAC8B37AB0
        public void GetSpanDescriptionOrDefault(){} // RVA: 0x7FFAC8B38190
        public void AddIfExists(){} // RVA: 0x7FFAC8B383A0
    }

    public class SentryHint : Object
    {
        public Sentry.SentryOptions Attachments; // 0x10
        public System.Collections.Generic.List`1<Sentry.SentryAttachment> Items; // 0x18
        public System.Collections.Generic.Dictionary`2<string,object> _items; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B386C0 | overloaded x3
        public void get_Attachments(){} // RVA: 0x7FFAC2F247C0
        public void get_Items(){} // RVA: 0x7FFAC8B387F0
        public void AddAttachmentsFromScope(){} // RVA: 0x7FFAC8B388B0
        public void AddAttachment(){} // RVA: 0x7FFAC8B38AB0 | overloaded x2
        public void WithAttachments(){} // RVA: 0x7FFAC8B38C90 | overloaded x2
    }

    public class SentryHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        public string MechanismType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B38D30
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFAC8B38D40
    }

    public class SentryHttpMessageHandler : SentryMessageHandler
    {
        public Sentry.IHub _hub; // 0x38
        public Sentry.SentryOptions _options; // 0x40
        public Sentry.ISentryFailedRequestHandler _failedRequestHandler; // 0x48
        public string HttpClientOrigin;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B39430 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x7FFAC8B39680
        public void HandleResponse(){} // RVA: 0x7FFAC8B398B0
    }

    public class SentryId : ValueType
    {
        public System.Guid _guid; // 0x10
        public Sentry.SentryId Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC450BA60
        public void ToString(){} // RVA: 0x7FFAC8B39BF0
        public void Equals(){} // RVA: 0x7FFAC8B39C90 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8B39D70
        public void Create(){} // RVA: 0x7FFAC8B39D90
        public void WriteTo(){} // RVA: 0x7FFAC8B39DF0
        public void Parse(){} // RVA: 0x7FFAC862A5B0
        public void FromJson(){} // RVA: 0x7FFAC8B39F20
        public void op_Equality(){} // RVA: 0x7FFAC8B3A110
        public void op_Inequality(){} // RVA: 0x7FFAC8B3A1C0
        public void op_Implicit(){} // RVA: 0x7FFAC32C0590 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SentryMessage : Object
    {
        public string Message; // 0x10
        public System.Collections.Generic.IEnumerable`1<object> Params; // 0x18
        public string Formatted; // 0x20

        // ── Methods ──
        public void get_Message(){} // RVA: 0x7FFAC2F3C380
        public void set_Message(){} // RVA: 0x7FFAC2F22E30
        public void get_Params(){} // RVA: 0x7FFAC2F247C0
        public void set_Params(){} // RVA: 0x7FFAC2F87E80
        public void get_Formatted(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Formatted(){} // RVA: 0x7FFAC2F4F0D0
        public void op_Implicit(){} // RVA: 0x7FFAC8B3A2A0
        public void WriteTo(){} // RVA: 0x7FFAC8B3A340
        public void FromJson(){} // RVA: 0x7FFAC8B3A4A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SentryMessageHandler : DelegatingHandler
    {
        public Sentry.IHub _hub; // 0x20
        public Sentry.SentryOptions _options; // 0x28
        public object _innerHandlerLock; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B3AEA0 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x7FFAC2C6AE80
        public void HandleResponse(){} // RVA: 0x7FFAC2C7B8C0
        public void SendAsync(){} // RVA: 0x7FFAC8B3B0A0
        public void PropagateTraceHeaders(){} // RVA: 0x7FFAC8B3B2F0
        public void AddSentryTraceHeader(){} // RVA: 0x7FFAC8B3B710
        public void AddBaggageHeader(){} // RVA: 0x7FFAC8B3B860
        public void <>n__0(){} // RVA: 0x7FFAC8B3BEF0
    }

    public class SentryMonitorOptions : Object
    {
        public 0x6B198E78 CheckInMargin; // 0x10
        public string MaxRuntime; // 0x18
        public System.Nullable`1<int> FailureIssueThreshold; // 0x20
        public System.Nullable`1<0x6B198ED0> RecoveryThreshold; // 0x28
        public System.Text.RegularExpressions.Regex TimeZone;
        public System.Nullable`1<System.TimeSpan> Owner; // 0x30
        public System.Nullable`1<System.TimeSpan> <MaxRuntime>k__BackingField; // 0x40
        public System.Nullable`1<int> _failureIssueThreshold; // 0x50
        public System.Nullable`1<int> _recoveryThreshold; // 0x58
        public string <TimeZone>k__BackingField; // 0x60
        public string <Owner>k__BackingField; // 0x68

        // ── Methods ──
        public void CrontabValidation(){} // RVA: 0x7FFAC8B3C790
        public void Interval(){} // RVA: 0x7FFAC8B3CB50 | overloaded x2
        public void get_CheckInMargin(){} // RVA: 0x7FFAC845FF30
        public void set_CheckInMargin(){} // RVA: 0x7FFAC845FF40
        public void get_MaxRuntime(){} // RVA: 0x7FFAC4AC8580
        public void set_MaxRuntime(){} // RVA: 0x7FFAC6D1E430
        public void get_FailureIssueThreshold(){} // RVA: 0x7FFAC2FC20E0
        public void set_FailureIssueThreshold(){} // RVA: 0x7FFAC8B3CC30
        public void get_RecoveryThreshold(){} // RVA: 0x7FFAC2FE9500
        public void set_RecoveryThreshold(){} // RVA: 0x7FFAC8B3CCE0
        public void get_TimeZone(){} // RVA: 0x7FFAC2FBF370
        public void set_TimeZone(){} // RVA: 0x7FFAC2FBF380
        public void get_Owner(){} // RVA: 0x7FFAC2F9CD50
        public void set_Owner(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void WriteTo(){} // RVA: 0x7FFAC8B3CD90
        public void TypeToString(){} // RVA: 0x7FFAC8B3D590
    }

    public class SentryOptions : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> ScopeStackContainer; // 0x10
        public 0x6B130410 InstallationId;
        public Sentry.Internal.ScopeStack.IScopeStackContainer IsGlobalModeEnabled; // 0x18
        public System.Lazy`1<string> ScopeObserver; // 0x20
        public System.Nullable`1<bool> EnableScopeSync; // 0x28
        public Sentry.IScopeObserver Transport; // 0x30
        public bool ClientReportRecorder; // 0x38
        public Sentry.Extensibility.ITransport SentryStackTraceFactory; // 0x40
        public System.Lazy`1<Sentry.Internal.IClientReportRecorder> SentryVersion; // 0x48
        public System.Lazy`1<Sentry.Extensibility.ISentryStackTraceFactory> ExceptionProcessors; // 0x50
        public int TransactionProcessors; // 0x58
        public System.Collections.Generic.List`1<System.ValueTuple`2<System.Type,System.Lazy`1<Sentry.Extensibility.ISentryEventExceptionProcessor>>> EventProcessors; // 0x60
        public System.Collections.Generic.List`1<Sentry.Extensibility.ISentryTransactionProcessor> EventProcessorsProviders; // 0x68
        public System.Collections.Generic.List`1<System.ValueTuple`2<System.Type,System.Lazy`1<Sentry.Extensibility.ISentryEventProcessor>>> TransactionProcessorsProviders; // 0x70
        public System.Collections.Generic.List`1<System.Func`1<System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.ISentryEventProcessor>>> ExceptionProcessorsProviders; // 0x78
        public System.Collections.Generic.List`1<System.Func`1<System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.ISentryTransactionProcessor>>> Integrations; // 0x80
        public System.Collections.Generic.List`1<System.Func`1<System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.ISentryEventExceptionProcessor>>> ExceptionFilters; // 0x88
        public 0x6B198F80 TagFilters; // 0x90
        public System.Collections.Generic.List`1<Sentry.Extensibility.IExceptionFilter> BackgroundWorker; // 0x98
        public System.Collections.Generic.ICollection`1<Sentry.SubstringOrRegexPattern> SentryHttpClientFactory; // 0xA0
        public Sentry.Extensibility.IBackgroundWorker SentryScopeStateProcessor; // 0xA8
        public Sentry.Http.ISentryHttpClientFactory InAppExclude; // 0xB0
        public Sentry.ISentryScopeStateProcessor InAppInclude; // 0xB8
        public System.Collections.Generic.List`1<Sentry.Internal.StringOrRegex> SendDefaultPii; // 0xC0
        public System.Collections.Generic.List`1<Sentry.Internal.StringOrRegex> IsEnvironmentUser; // 0xC8
        public bool ServerName; // 0xD0
        public bool AttachStacktrace; // 0xD1
        public string MaxBreadcrumbs; // 0xD8
        public bool SampleRate; // 0xE0
        public int Release; // 0xE4
        public System.Nullable`1<float> Distribution; // 0xE8
        public string Environment; // 0xF0
        public string Dsn; // 0xF8
        public string ParsedDsn; // 0x100
        public string BeforeSendInternal; // 0x108
        public Sentry.Dsn BeforeSendTransactionInternal; // 0x110
        public System.Lazy`1<string> BeforeBreadcrumbInternal; // 0x118
        public System.Func`3<Sentry.SentryEvent,Sentry.SentryHint,Sentry.SentryEvent> MaxQueueItems; // 0x120
        public System.Func`3<Sentry.SentryTransaction,Sentry.SentryHint,Sentry.SentryTransaction> MaxCacheItems; // 0x128
        public System.Func`3<Sentry.Breadcrumb,Sentry.SentryHint,Sentry.Breadcrumb> ShutdownTimeout; // 0x130
        public int FlushTimeout; // 0x138
        public int DecompressionMethods; // 0x13C
        public System.TimeSpan RequestBodyCompressionLevel; // 0x140
        public System.TimeSpan RequestBodyCompressionBuffered; // 0x148
        public 0x6B13CA68 SendClientReports; // 0x150
        public 0x6B139788 HttpProxy; // 0x154
        public bool CreateHttpMessageHandler; // 0x158
        public bool ConfigureClient; // 0x159
        public System.Net.IWebProxy Debug; // 0x160
        public System.Func`1<System.Net.Http.HttpMessageHandler> DiagnosticLevel; // 0x168
        public System.Action`1<System.Net.Http.HttpClient> DiagnosticLogger; // 0x170
        public bool ReportAssembliesMode; // 0x178
        public 0x6B198C68 DeduplicateMode; // 0x17A
        public Sentry.Extensibility.IDiagnosticLogger CacheDirectoryPath; // 0x180
        public 0x6B198168 CaptureFailedRequests; // 0x188
        public 0x6B196850 FailedRequestStatusCodes; // 0x18C
        public string FailedRequestTargets; // 0x190
        public bool FileSystem; // 0x198
        public System.Collections.Generic.IList`1<Sentry.HttpStatusCodeRange> DisableFileWrite; // 0x1A0
        public System.Lazy`1<System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern>> InitCacheFlushTimeout; // 0x1A8
        public Sentry.Internal.IFileSystem DefaultTags; // 0x1B0
        public bool IsPerformanceMonitoringEnabled; // 0x1B8
        public System.TimeSpan IsProfilingEnabled; // 0x1C0
        public System.Nullable`1<bool> EnableTracing; // 0x1C8
        public System.Nullable`1<double> TracesSampleRate; // 0x1D0
        public System.Nullable`1<double> ProfilesSampleRate; // 0x1E0
        public System.Func`2<Sentry.TransactionSamplingContext,System.Nullable`1<double>> TracesSampler; // 0x1F0
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> TracePropagationTargets; // 0x1F8
        public Sentry.Internal.ITransactionProfilerFactory TransactionProfilerFactory; // 0x200
        public System.Nullable`1<0x6B19A058> StackTraceMode; // 0x208
        public System.Collections.Generic.List`1<Sentry.Integrations.ISdkIntegration> MaxAttachmentSize; // 0x210
        public long DetectStartupTime; // 0x218
        public 0x6B19A0B0 AutoSessionTrackingInterval; // 0x220
        public System.TimeSpan AutoSessionTracking; // 0x228
        public bool UseAsyncFileIO; // 0x230
        public bool CrashedLastRun; // 0x231
        public System.Func`1<bool> Instrumenter; // 0x238
        public 0x6B197560 JsonPreserveReferences; // 0x240
        public Sentry.Extensibility.INetworkStatusListener NetworkStatusListener; // 0x248
        public System.Func`2<string,System.Reflection.PortableExecutable.PEReader> AssemblyReader; // 0x250
        public Sentry.ExperimentalMetricsOptions ExperimentalMetrics; // 0x258
        public string SpotlightUrl; // 0x260
        public bool EnableSpotlight; // 0x268
        public Sentry.Internal.SettingLocator SettingLocator; // 0x270
        public bool InitNativeSdks; // 0x278
        public System.Collections.Generic.List`1<System.Action`1<Sentry.IHub>> PostInitCallbacks; // 0x280

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFAC2F247C0
        public void set_ScopeStackContainer(){} // RVA: 0x7FFAC2F87E80
        public void get_InstallationId(){} // RVA: 0x7FFAC8B3D680
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFAC8B3D6D0
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFAC8B3D800
        public void get_ScopeObserver(){} // RVA: 0x7FFAC31D95E0
        public void set_ScopeObserver(){} // RVA: 0x7FFAC2F4F890
        public void get_EnableScopeSync(){} // RVA: 0x7FFAC31D95D0
        public void set_EnableScopeSync(){} // RVA: 0x7FFAC31D95C0
        public void get_Transport(){} // RVA: 0x7FFAC2F9E740
        public void set_Transport(){} // RVA: 0x7FFAC2F49200
        public void get_ClientReportRecorder(){} // RVA: 0x7FFAC8B3D850
        public void set_ClientReportRecorder(){} // RVA: 0x7FFAC8B3D8A0
        public void get_SentryStackTraceFactory(){} // RVA: 0x7FFAC8B3DA80
        public void set_SentryStackTraceFactory(){} // RVA: 0x7FFAC8B3DAD0
        public void get_SentryVersion(){} // RVA: 0x7FFAC362EA40
        public void get_ExceptionProcessors(){} // RVA: 0x7FFAC2FBF370
        public void set_ExceptionProcessors(){} // RVA: 0x7FFAC2FBF380
        public void get_TransactionProcessors(){} // RVA: 0x7FFAC2F9CD50
        public void set_TransactionProcessors(){} // RVA: 0x7FFAC2F9CD60
        public void get_EventProcessors(){} // RVA: 0x7FFAC2FE9590
        public void set_EventProcessors(){} // RVA: 0x7FFAC2FE95A0
        public void get_EventProcessorsProviders(){} // RVA: 0x7FFAC30E5600
        public void set_EventProcessorsProviders(){} // RVA: 0x7FFAC30E06F0
        public void get_TransactionProcessorsProviders(){} // RVA: 0x7FFAC32EF410
        public void set_TransactionProcessorsProviders(){} // RVA: 0x7FFAC34D4AA0
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x7FFAC2F60010
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x7FFAC354E300
        public void get_Integrations(){} // RVA: 0x7FFAC8B3DCB0
        public void get_ExceptionFilters(){} // RVA: 0x7FFAC354DFB0
        public void set_ExceptionFilters(){} // RVA: 0x7FFAC354E3C0
        public void get_TagFilters(){} // RVA: 0x7FFAC3543900
        public void set_TagFilters(){} // RVA: 0x7FFAC354E420
        public void get_BackgroundWorker(){} // RVA: 0x7FFAC354B1A0
        public void set_BackgroundWorker(){} // RVA: 0x7FFAC334B370
        public void get_SentryHttpClientFactory(){} // RVA: 0x7FFAC2F8C040
        public void set_SentryHttpClientFactory(){} // RVA: 0x7FFAC2F8C050
        public void GetHttpClient(){} // RVA: 0x7FFAC8B3DD60
        public void get_SentryScopeStateProcessor(){} // RVA: 0x7FFAC2F8C0B0
        public void set_SentryScopeStateProcessor(){} // RVA: 0x7FFAC2F8C0C0
        public void get_InAppExclude(){} // RVA: 0x7FFAC2F8C120
        public void set_InAppExclude(){} // RVA: 0x7FFAC2F8C130
        public void get_InAppInclude(){} // RVA: 0x7FFAC3079460
        public void set_InAppInclude(){} // RVA: 0x7FFAC3079470
        public void get_SendDefaultPii(){} // RVA: 0x7FFAC33CFDE0
        public void set_SendDefaultPii(){} // RVA: 0x7FFAC4323510
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFAC8B3DE40
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFAC8B3DE50
        public void get_ServerName(){} // RVA: 0x7FFAC3540F70
        public void set_ServerName(){} // RVA: 0x7FFAC2FA28A0
        public void get_AttachStacktrace(){} // RVA: 0x7FFAC304CF80
        public void set_AttachStacktrace(){} // RVA: 0x7FFAC304CF90
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAC47D5FD0
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFAC67153A0
        public void get_SampleRate(){} // RVA: 0x7FFAC2FA2970
        public void set_SampleRate(){} // RVA: 0x7FFAC8B3DE60
        public void get_Release(){} // RVA: 0x7FFAC2F8C2A0
        public void set_Release(){} // RVA: 0x7FFAC2F8C2B0
        public void get_Distribution(){} // RVA: 0x7FFAC3331F50
        public void set_Distribution(){} // RVA: 0x7FFAC34A4860
        public void get_Environment(){} // RVA: 0x7FFAC34F6C80
        public void set_Environment(){} // RVA: 0x7FFAC34F6750
        public void get_Dsn(){} // RVA: 0x7FFAC36D1F40
        public void set_Dsn(){} // RVA: 0x7FFAC8B3DF50
        public void get_ParsedDsn(){} // RVA: 0x7FFAC8B3E020
        public void IsSentryRequest(){} // RVA: 0x7FFAC8B3E270 | overloaded x2
        public void get_BeforeSendInternal(){} // RVA: 0x7FFAC313CBB0
        public void SetBeforeSend(){} // RVA: 0x7FFAC8B3E3E0 | overloaded x2
        public void get_BeforeSendTransactionInternal(){} // RVA: 0x7FFAC35466F0
        public void SetBeforeSendTransaction(){} // RVA: 0x7FFAC8B3E560 | overloaded x2
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x7FFAC3544340
        public void SetBeforeBreadcrumb(){} // RVA: 0x7FFAC8B3E6E0 | overloaded x2
        public void get_MaxQueueItems(){} // RVA: 0x7FFAC3C8EC30
        public void set_MaxQueueItems(){} // RVA: 0x7FFAC8B3E860
        public void get_MaxCacheItems(){} // RVA: 0x7FFAC88C7230
        public void set_MaxCacheItems(){} // RVA: 0x7FFAC8B3E920
        public void get_ShutdownTimeout(){} // RVA: 0x7FFAC2F8C5F0
        public void set_ShutdownTimeout(){} // RVA: 0x7FFAC8B3E9E0
        public void get_FlushTimeout(){} // RVA: 0x7FFAC2F8C660
        public void set_FlushTimeout(){} // RVA: 0x7FFAC8A33F90
        public void get_DecompressionMethods(){} // RVA: 0x7FFAC3C8DCE0
        public void set_DecompressionMethods(){} // RVA: 0x7FFAC3C8EC20
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFAC8B3E9F0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFAC8B3EA00
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAC8B3EA10
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAC8B3EA20
        public void get_SendClientReports(){} // RVA: 0x7FFAC3D23ED0
        public void set_SendClientReports(){} // RVA: 0x7FFAC3D258D0
        public void get_HttpProxy(){} // RVA: 0x7FFAC33A98A0
        public void set_HttpProxy(){} // RVA: 0x7FFAC33AFA60
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7FFAC354E2F0
        public void set_CreateHttpMessageHandler(){} // RVA: 0x7FFAC39A80B0
        public void get_ConfigureClient(){} // RVA: 0x7FFAC336D850
        public void set_ConfigureClient(){} // RVA: 0x7FFAC39B5DB0
        public void get_Debug(){} // RVA: 0x7FFAC8B3EA30
        public void set_Debug(){} // RVA: 0x7FFAC8B3EA40
        public void get_DiagnosticLevel(){} // RVA: 0x7FFAC8B3EA50
        public void set_DiagnosticLevel(){} // RVA: 0x7FFAC8B3EA60
        public void get_DiagnosticLogger(){} // RVA: 0x7FFAC8B3EA70
        public void set_DiagnosticLogger(){} // RVA: 0x7FFAC8B3EA90
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAC33B23B0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFAC8B3EBD0
        public void get_DeduplicateMode(){} // RVA: 0x7FFAC8A144D0
        public void set_DeduplicateMode(){} // RVA: 0x7FFAC8B3EBE0
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFAC3540F60
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFAC39AB1D0
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAC8B3EBF0
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFAC8B3EC00
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFAC354E2E0
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFAC39A8AF0
        public void get_FailedRequestTargets(){} // RVA: 0x7FFAC8B3EC10
        public void set_FailedRequestTargets(){} // RVA: 0x7FFAC8B3EC60
        public void get_FileSystem(){} // RVA: 0x7FFAC8B3ED90
        public void set_FileSystem(){} // RVA: 0x7FFAC39A7790
        public void get_DisableFileWrite(){} // RVA: 0x7FFAC8B3EE50
        public void set_DisableFileWrite(){} // RVA: 0x7FFAC8B3EE60
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFAC35422B0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFAC8B3EE70
        public void get_DefaultTags(){} // RVA: 0x7FFAC8B3EE80
        public void set_DefaultTags(){} // RVA: 0x7FFAC2F22E30
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x7FFAC8B3EF40
        public void get_IsProfilingEnabled(){} // RVA: 0x7FFAC8B3F040
        public void get_EnableTracing(){} // RVA: 0x7FFAC8B3F180
        public void set_EnableTracing(){} // RVA: 0x7FFAC8B3F190
        public void get_TracesSampleRate(){} // RVA: 0x7FFAC8B3F1A0
        public void set_TracesSampleRate(){} // RVA: 0x7FFAC8B3F1B0
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFAC8B3F2C0
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFAC8B3F2D0
        public void get_TracesSampler(){} // RVA: 0x7FFAC3544EF0
        public void set_TracesSampler(){} // RVA: 0x7FFAC3541400
        public void get_TracePropagationTargets(){} // RVA: 0x7FFAC3541460
        public void set_TracePropagationTargets(){} // RVA: 0x7FFAC8B3F3E0
        public void get_TransactionProfilerFactory(){} // RVA: 0x7FFAC3544790
        public void set_TransactionProfilerFactory(){} // RVA: 0x7FFAC354D230
        public void get_StackTraceMode(){} // RVA: 0x7FFAC8B3F480
        public void set_StackTraceMode(){} // RVA: 0x7FFAC8B3F680
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFAC3541470
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFAC8B3F6E0
        public void get_DetectStartupTime(){} // RVA: 0x7FFAC8B3F6F0
        public void set_DetectStartupTime(){} // RVA: 0x7FFAC8B3F700
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFAC3540FB0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFAC8B3F710
        public void get_AutoSessionTracking(){} // RVA: 0x7FFAC89F5240
        public void set_AutoSessionTracking(){} // RVA: 0x7FFAC89F5250
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFAC89F5260
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFAC89F5270
        public void get_CrashedLastRun(){} // RVA: 0x7FFAC35413D0
        public void set_CrashedLastRun(){} // RVA: 0x7FFAC39AA7F0
        public void get_Instrumenter(){} // RVA: 0x7FFAC8B3F720
        public void set_Instrumenter(){} // RVA: 0x7FFAC8B3F730
        public void AddJsonConverter(){} // RVA: 0x7FFAC8B3F740
        public void AddJsonSerializerContext(){} // RVA: 0x7FFAC2C70A40
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFAC8B3F7E0
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFAC8B3F880
        public void get_NetworkStatusListener(){} // RVA: 0x7FFAC39A6830
        public void set_NetworkStatusListener(){} // RVA: 0x7FFAC39A8760
        public void get_AssemblyReader(){} // RVA: 0x7FFAC39C5D60
        public void set_AssemblyReader(){} // RVA: 0x7FFAC39B0650
        public void get_ExperimentalMetrics(){} // RVA: 0x7FFAC39BCEE0
        public void set_ExperimentalMetrics(){} // RVA: 0x7FFAC334B310
        public void get_SpotlightUrl(){} // RVA: 0x7FFAC39CABF0
        public void set_SpotlightUrl(){} // RVA: 0x7FFAC39AE8C0
        public void get_EnableSpotlight(){} // RVA: 0x7FFAC8B3F920
        public void set_EnableSpotlight(){} // RVA: 0x7FFAC8B3F930
        public void get_SettingLocator(){} // RVA: 0x7FFAC39C8960
        public void set_SettingLocator(){} // RVA: 0x7FFAC39AD8D0
        public void get_InitNativeSdks(){} // RVA: 0x7FFAC8B3F940
        public void set_InitNativeSdks(){} // RVA: 0x7FFAC8B3F950
        public void get_PostInitCallbacks(){} // RVA: 0x7FFAC39B03C0
        public void set_PostInitCallbacks(){} // RVA: 0x7FFAC39CC790
        public void .ctor(){} // RVA: 0x7FFAC8B3F960
        public void AddIntegration(){} // RVA: 0x7FFAC8B41A80
        public void RemoveIntegration(){} // RVA: 0x7FFAC2C70980
        public void AddExceptionFilter(){} // RVA: 0x7FFAC8B41B20
        public void RemoveExceptionFilter(){} // RVA: 0x7FFAC2C70980
        public void AddExceptionFilterForType(){} // RVA: 0x7FFAC2C70980
        public void AddInAppExclude(){} // RVA: 0x7FFAC8B41DF0 | overloaded x2
        public void AddInAppExcludeRegex(){} // RVA: 0x7FFAC8B41FA0
        public void AddInAppInclude(){} // RVA: 0x7FFAC8B42350 | overloaded x2
        public void AddInAppIncludeRegex(){} // RVA: 0x7FFAC8B42500
        public void AddExceptionProcessor(){} // RVA: 0x7FFAC8B42700
        public void AddExceptionProcessors(){} // RVA: 0x7FFAC8B428F0
        public void AddEventProcessor(){} // RVA: 0x7FFAC8B42AC0
        public void AddEventProcessors(){} // RVA: 0x7FFAC8B42CB0
        public void RemoveEventProcessor(){} // RVA: 0x7FFAC2C70980
        public void AddEventProcessorProvider(){} // RVA: 0x7FFAC8B42E80
        public void AddTransactionProcessor(){} // RVA: 0x7FFAC8B42EE0
        public void AddTransactionProcessors(){} // RVA: 0x7FFAC8B42FF0
        public void RemoveTransactionProcessor(){} // RVA: 0x7FFAC2C70980
        public void AddTransactionProcessorProvider(){} // RVA: 0x7FFAC8B43160
        public void AddExceptionProcessorProvider(){} // RVA: 0x7FFAC8B43350
        public void GetAllEventProcessors(){} // RVA: 0x7FFAC8B433B0
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFAC8B43520
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFAC8B43690
        public void UseStackTraceFactory(){} // RVA: 0x7FFAC8B43800
        public void ApplyDefaultTags(){} // RVA: 0x7FFAC8B43A30
        public void DisableDuplicateEventDetection(){} // RVA: 0x7FFAC8B43E30
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x7FFAC8B43E70
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x7FFAC8B43E80
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x7FFAC8B43E90
        public void HasIntegration(){} // RVA: 0x7FFAC2C59D00
        public void RemoveDefaultIntegration(){} // RVA: 0x7FFAC8B43EA0
        public void SetupLogging(){} // RVA: 0x7FFAC8B43EB0
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x7FFAC8B440E0
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x7FFAC8B44340
        public void <.ctor>b__346_0(){} // RVA: 0x7FFAC8B44350
        public void <.ctor>b__346_5(){} // RVA: 0x7FFAC8B44480
        public void <.ctor>b__346_1(){} // RVA: 0x7FFAC8B444D0
        public void <.ctor>b__346_2(){} // RVA: 0x7FFAC8B44530
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x7FFAC8B3DA80
        public void <.ctor>b__346_6(){} // RVA: 0x7FFAC8B445C0
        public void <.ctor>b__346_7(){} // RVA: 0x7FFAC8B44710
        public void <.ctor>b__346_8(){} // RVA: 0x7FFAC8B44910
        public void <.ctor>b__346_10(){} // RVA: 0x7FFAC8B44A80
        public void <.ctor>b__346_11(){} // RVA: 0x7FFAC8B44BC0
        public void <.ctor>b__346_4(){} // RVA: 0x7FFAC8B44D30
    }

    public class SentryPackage : Object
    {
        public string Name; // 0x10
        public string Version; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC2F3C380
        public void get_Version(){} // RVA: 0x7FFAC2F247C0
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void WriteTo(){} // RVA: 0x7FFAC8B45A60
        public void FromJson(){} // RVA: 0x7FFAC8B45B70
        public void GetHashCode(){} // RVA: 0x7FFAC8B45DC0
        public void Equals(){} // RVA: 0x7FFAC8B45E30
    }

    public class SentryPropagationContext : Object
    {
        public Sentry.SentryId TraceId; // 0x10
        public Sentry.SpanId SpanId; // 0x20
        public System.Nullable`1<Sentry.SpanId> ParentSpanId; // 0x28
        public Sentry.DynamicSamplingContext _dynamicSamplingContext; // 0x38

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFAC4422E80
        public void get_SpanId(){} // RVA: 0x7FFAC2F4F0C0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC3BCF020
        public void GetOrCreateDynamicSamplingContext(){} // RVA: 0x7FFAC8B45F50
        public void .ctor(){} // RVA: 0x7FFAC8B46350 | overloaded x3
        public void CreateFromHeaders(){} // RVA: 0x7FFAC8B464B0
    }

    public class SentryRequest : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> InternalEnv; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> InternalOther; // 0x18
        public System.Collections.Generic.Dictionary`2<string,string> InternalHeaders; // 0x20
        public string Url; // 0x28
        public string Method; // 0x30
        public string ApiTarget; // 0x38
        public object Data; // 0x40
        public string QueryString; // 0x48
        public string Cookies; // 0x50

        // ── Methods ──
        public void get_InternalEnv(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalEnv(){} // RVA: 0x7FFAC2F22E30
        public void get_InternalOther(){} // RVA: 0x7FFAC2F247C0
        public void set_InternalOther(){} // RVA: 0x7FFAC2F87E80
        public void get_InternalHeaders(){} // RVA: 0x7FFAC2F4F0C0
        public void set_InternalHeaders(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Url(){} // RVA: 0x7FFAC2F4F130
        public void set_Url(){} // RVA: 0x7FFAC2F22E90
        public void get_Method(){} // RVA: 0x7FFAC31D95E0
        public void set_Method(){} // RVA: 0x7FFAC2F4F890
        public void get_ApiTarget(){} // RVA: 0x7FFAC31D0140
        public void set_ApiTarget(){} // RVA: 0x7FFAC31D0C20
        public void get_Data(){} // RVA: 0x7FFAC2F9E740
        public void set_Data(){} // RVA: 0x7FFAC2F49200
        public void get_QueryString(){} // RVA: 0x7FFAC2F9C730
        public void set_QueryString(){} // RVA: 0x7FFAC2F9C740
        public void get_Cookies(){} // RVA: 0x7FFAC2FC20E0
        public void set_Cookies(){} // RVA: 0x7FFAC30794D0
        public void get_Headers(){} // RVA: 0x7FFAC8B466C0
        public void get_Env(){} // RVA: 0x7FFAC8B46780
        public void get_Other(){} // RVA: 0x7FFAC8B46840
        public void AddHeaders(){} // RVA: 0x7FFAC8B46900
        public void Clone(){} // RVA: 0x7FFAC8B46BF0
        public void CopyTo(){} // RVA: 0x7FFAC8B46C50
        public void WriteTo(){} // RVA: 0x7FFAC8B46EF0
        public void FromJson(){} // RVA: 0x7FFAC8B47170
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SentrySdk : Object
    {
        public Sentry.IHub CurrentOptions;

        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x7FFAC8B47A80
        public void get_LastEventId(){} // RVA: 0x7FFAC8B47AE0
        public void InitHub(){} // RVA: 0x7FFAC8B47B80
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x7FFAC8B48160
        public void Init(){} // RVA: 0x7FFAC8B48630 | overloaded x4
        public void UseHub(){} // RVA: 0x7FFAC8B487D0
        public void Flush(){} // RVA: 0x7FFAC8B48A10 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFAC8B48AD0 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC8B48B60
        public void get_IsEnabled(){} // RVA: 0x7FFAC8B48CF0
        public void PushScope(){} // RVA: 0x7FFAC8B48D70 | overloaded x2
        public void BindClient(){} // RVA: 0x7FFAC8B48DF0
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8B48FD0 | overloaded x3
        public void ConfigureScope(){} // RVA: 0x7FFAC8B49040
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAC8B490C0
        public void CaptureEnvelope(){} // RVA: 0x7FFAC8B49140
        public void CaptureEvent(){} // RVA: 0x7FFAC8B49360 | overloaded x3
        public void CaptureException(){} // RVA: 0x7FFAC8B494A0 | overloaded x2
        public void CaptureMessage(){} // RVA: 0x7FFAC8B49680 | overloaded x2
        public void CaptureUserFeedback(){} // RVA: 0x7FFAC8B498F0 | overloaded x2
        public void CaptureTransaction(){} // RVA: 0x7FFAC8B49A70 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAC8B49B10
        public void CaptureCheckIn(){} // RVA: 0x7FFAC8B49B90
        public void StartTransaction(){} // RVA: 0x7FFAC8B4A030 | overloaded x6
        public void BindException(){} // RVA: 0x7FFAC8B4A0C0
        public void GetSpan(){} // RVA: 0x7FFAC8B4A150
        public void GetTraceHeader(){} // RVA: 0x7FFAC8B4A1D0
        public void GetBaggage(){} // RVA: 0x7FFAC8B4A250
        public void ContinueTrace(){} // RVA: 0x7FFAC8B4A410 | overloaded x2
        public void get_Metrics(){} // RVA: 0x7FFAC8B4A550
        public void StartSession(){} // RVA: 0x7FFAC8B4A5D0
        public void EndSession(){} // RVA: 0x7FFAC8B4A650
        public void PauseSession(){} // RVA: 0x7FFAC8B4A6E0
        public void ResumeSession(){} // RVA: 0x7FFAC8B4A760
        public void CauseCrash(){} // RVA: 0x7FFAC8B4A7E0
        public void .cctor(){} // RVA: 0x7FFAC8B4AE10
    }

    public class SentrySession : Object
    {
        public Sentry.SentryId Id; // 0x10
        public string DistinctId; // 0x20
        public System.DateTimeOffset StartTimestamp; // 0x28
        public string Release; // 0x38
        public string Environment; // 0x40
        public string IpAddress; // 0x48
        public string UserAgent; // 0x50
        public int ErrorCount; // 0x58
        public int _sequenceNumber; // 0x5C

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC4422E80
        public void get_DistinctId(){} // RVA: 0x7FFAC2F4F0C0
        public void get_StartTimestamp(){} // RVA: 0x7FFAC3BCF020
        public void get_Release(){} // RVA: 0x7FFAC31D0140
        public void get_Environment(){} // RVA: 0x7FFAC2F9E740
        public void get_IpAddress(){} // RVA: 0x7FFAC2F9C730
        public void get_UserAgent(){} // RVA: 0x7FFAC2FC20E0
        public void get_ErrorCount(){} // RVA: 0x7FFAC362EA40
        public void .ctor(){} // RVA: 0x7FFAC8B4B2C0 | overloaded x2
        public void ReportError(){} // RVA: 0x7FFAC8B4B460
        public void CreateUpdate(){} // RVA: 0x7FFAC8B4B470
    }

    public class SentrySpan : Object
    {
        public Sentry.SpanId SpanId; // 0x10
        public System.Nullable`1<Sentry.SpanId> ParentSpanId; // 0x18
        public Sentry.SentryId TraceId; // 0x28
        public System.DateTimeOffset StartTimestamp; // 0x38
        public System.Nullable`1<System.DateTimeOffset> EndTimestamp; // 0x48
        public System.Collections.Generic.Dictionary`2<string,Sentry.Protocol.Measurement> IsFinished; // 0x60
        public string Measurements; // 0x68
        public string Operation; // 0x70
        public System.Nullable`1<0x6B199F50> Description; // 0x78
        public System.Nullable`1<bool> Status; // 0x80
        public System.Collections.Generic.Dictionary`2<string,string> IsSampled; // 0x88
        public System.Collections.Generic.Dictionary`2<string,object> Tags; // 0x90
        public Sentry.Protocol.Metrics.MetricsSummary Extra; // 0x98
        public string Origin; // 0xA0

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFAC2F3C380
        public void set_SpanId(){} // RVA: 0x7FFAC441EFB0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC35D3330
        public void set_ParentSpanId(){} // RVA: 0x7FFAC35D34F0
        public void get_TraceId(){} // RVA: 0x7FFAC3BCF020
        public void set_TraceId(){} // RVA: 0x7FFAC3BCC210
        public void get_StartTimestamp(){} // RVA: 0x7FFAC4426F60
        public void set_StartTimestamp(){} // RVA: 0x7FFAC4A97FB0
        public void get_EndTimestamp(){} // RVA: 0x7FFAC8B4B520
        public void set_EndTimestamp(){} // RVA: 0x7FFAC8B4B540
        public void get_IsFinished(){} // RVA: 0x7FFAC8B4B560
        public void get_Measurements(){} // RVA: 0x7FFAC8B4B5A0
        public void SetMeasurement(){} // RVA: 0x7FFAC8B4B660
        public void get_Operation(){} // RVA: 0x7FFAC2F9CD50
        public void set_Operation(){} // RVA: 0x7FFAC2F9CD60
        public void get_Description(){} // RVA: 0x7FFAC2FE9590
        public void set_Description(){} // RVA: 0x7FFAC2FE95A0
        public void get_Status(){} // RVA: 0x7FFAC30E5600
        public void set_Status(){} // RVA: 0x7FFAC8246500
        public void get_IsSampled(){} // RVA: 0x7FFAC8730560
        public void set_IsSampled(){} // RVA: 0x7FFAC87AD920
        public void get_Tags(){} // RVA: 0x7FFAC8B4B780
        public void SetTag(){} // RVA: 0x7FFAC8B4B850
        public void UnsetTag(){} // RVA: 0x7FFAC8B4B980
        public void get_Extra(){} // RVA: 0x7FFAC8B4BA80
        public void SetExtra(){} // RVA: 0x7FFAC8B4BB50
        public void .ctor(){} // RVA: 0x7FFAC8B4BE40 | overloaded x2
        public void GetTraceHeader(){} // RVA: 0x7FFAC8B4C4B0
        public void WriteTo(){} // RVA: 0x7FFAC8B4C520
        public void FromJson(){} // RVA: 0x7FFAC8B4CA20
        public void Redact(){} // RVA: 0x7FFAC8B4DBE0
        public void get_Origin(){} // RVA: 0x7FFAC3543900
        public void set_Origin(){} // RVA: 0x7FFAC8B4DC90
    }

    public class SentryStackFrame : Object
    {
        public System.Lazy`1<Sentry.Internal.PrefixOrPatternMatcher> InternalPreContext;
        public System.Lazy`1<Sentry.Internal.DelimitedPrefixOrPatternMatcher> InternalPostContext; // 0x8
        public System.Collections.Generic.List`1<string> InternalVars; // 0x10
        public System.Collections.Generic.List`1<string> InternalFramesOmitted; // 0x18
        public System.Collections.Generic.Dictionary`2<string,string> IsCodeLocation; // 0x20
        public System.Collections.Generic.List`1<int> FileName; // 0x28
        public bool Function; // 0x30
        public string Module; // 0x38
        public string LineNumber; // 0x40
        public string ColumnNumber; // 0x48
        public System.Nullable`1<int> AbsolutePath; // 0x50
        public System.Nullable`1<int> ContextLine; // 0x58
        public string PreContext; // 0x60
        public string PostContext; // 0x68
        public System.Nullable`1<bool> InApp; // 0x70
        public string Vars; // 0x78
        public string FramesOmitted; // 0x80
        public System.Nullable`1<long> Package; // 0x88
        public System.Nullable`1<long> Platform; // 0x98
        public System.Nullable`1<long> ImageAddress; // 0xA8
        public string SymbolAddress; // 0xB8
        public System.Nullable`1<long> InstructionAddress; // 0xC0

        // ── Methods ──
        public void get_InternalPreContext(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalPreContext(){} // RVA: 0x7FFAC2F22E30
        public void get_InternalPostContext(){} // RVA: 0x7FFAC2F247C0
        public void set_InternalPostContext(){} // RVA: 0x7FFAC2F87E80
        public void get_InternalVars(){} // RVA: 0x7FFAC2F4F0C0
        public void set_InternalVars(){} // RVA: 0x7FFAC2F4F0D0
        public void get_InternalFramesOmitted(){} // RVA: 0x7FFAC2F4F130
        public void set_InternalFramesOmitted(){} // RVA: 0x7FFAC2F22E90
        public void get_IsCodeLocation(){} // RVA: 0x7FFAC2F47450
        public void set_IsCodeLocation(){} // RVA: 0x7FFAC2F47460
        public void get_FileName(){} // RVA: 0x7FFAC31D0140
        public void set_FileName(){} // RVA: 0x7FFAC31D0C20
        public void get_Function(){} // RVA: 0x7FFAC2F9E740
        public void set_Function(){} // RVA: 0x7FFAC2F49200
        public void get_Module(){} // RVA: 0x7FFAC2F9C730
        public void set_Module(){} // RVA: 0x7FFAC2F9C740
        public void get_LineNumber(){} // RVA: 0x7FFAC2FC20E0
        public void set_LineNumber(){} // RVA: 0x7FFAC42499F0
        public void get_ColumnNumber(){} // RVA: 0x7FFAC2FE9500
        public void set_ColumnNumber(){} // RVA: 0x7FFAC4249140
        public void get_AbsolutePath(){} // RVA: 0x7FFAC2FBF370
        public void set_AbsolutePath(){} // RVA: 0x7FFAC2FBF380
        public void get_ContextLine(){} // RVA: 0x7FFAC2F9CD50
        public void set_ContextLine(){} // RVA: 0x7FFAC2F9CD60
        public void get_PreContext(){} // RVA: 0x7FFAC8B4DD90
        public void get_PostContext(){} // RVA: 0x7FFAC8B4DE50
        public void get_InApp(){} // RVA: 0x7FFAC8B4DF10
        public void set_InApp(){} // RVA: 0x7FFAC8B4DF20
        public void get_Vars(){} // RVA: 0x7FFAC8B4DF30
        public void get_FramesOmitted(){} // RVA: 0x7FFAC8B4DFF0
        public void get_Package(){} // RVA: 0x7FFAC30E5600
        public void set_Package(){} // RVA: 0x7FFAC30E06F0
        public void get_Platform(){} // RVA: 0x7FFAC32EF410
        public void set_Platform(){} // RVA: 0x7FFAC34D4AA0
        public void get_ImageAddress(){} // RVA: 0x7FFAC7DF99E0
        public void set_ImageAddress(){} // RVA: 0x7FFAC7DF99F0
        public void get_SymbolAddress(){} // RVA: 0x7FFAC4B5E6B0
        public void set_SymbolAddress(){} // RVA: 0x7FFAC4B5E720
        public void get_InstructionAddress(){} // RVA: 0x7FFAC8B4E0B0
        public void set_InstructionAddress(){} // RVA: 0x7FFAC8B4E0C0
        public void get_AddressMode(){} // RVA: 0x7FFAC2F8C0B0
        public void set_AddressMode(){} // RVA: 0x7FFAC2F8C0C0
        public void get_FunctionId(){} // RVA: 0x7FFAC8B4E0D0
        public void set_FunctionId(){} // RVA: 0x7FFAC8B4E0E0
        public void WriteTo(){} // RVA: 0x7FFAC8B4E0F0
        public void ConfigureAppFrame(){} // RVA: 0x7FFAC8B4ED40 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFAC8B4EDF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8B509D0
    }

    public class SentryStackTrace : Object
    {
        public System.Collections.Generic.IList`1<Sentry.SentryStackFrame> InternalFrames; // 0x10
        public System.Nullable`1<0x6B199978> Frames; // 0x18

        // ── Methods ──
        public void get_InternalFrames(){} // RVA: 0x7FFAC2F3C380
        public void set_InternalFrames(){} // RVA: 0x7FFAC2F22E30
        public void get_Frames(){} // RVA: 0x7FFAC8B50E40
        public void set_Frames(){} // RVA: 0x7FFAC2F22E30
        public void get_AddressAdjustment(){} // RVA: 0x7FFAC2F247C0
        public void set_AddressAdjustment(){} // RVA: 0x7FFAC38920D0
        public void WriteTo(){} // RVA: 0x7FFAC8B50F00
        public void FromJson(){} // RVA: 0x7FFAC8B510B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SentryThread : Object
    {
        public System.Nullable`1<int> Id; // 0x10
        public string Name; // 0x18
        public System.Nullable`1<bool> Crashed; // 0x20
        public System.Nullable`1<bool> Current; // 0x22
        public Sentry.SentryStackTrace Stacktrace; // 0x28

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC2F3C380
        public void set_Id(){} // RVA: 0x7FFAC441EFB0
        public void get_Name(){} // RVA: 0x7FFAC2F247C0
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void get_Crashed(){} // RVA: 0x7FFAC6D68C80
        public void set_Crashed(){} // RVA: 0x7FFAC8258410
        public void get_Current(){} // RVA: 0x7FFAC8258420
        public void set_Current(){} // RVA: 0x7FFAC8258430
        public void get_Stacktrace(){} // RVA: 0x7FFAC2F4F130
        public void set_Stacktrace(){} // RVA: 0x7FFAC2F22E90
        public void WriteTo(){} // RVA: 0x7FFAC8B51600
        public void FromJson(){} // RVA: 0x7FFAC8B51950
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SentryTraceHeader : Object
    {
        public string TraceId;
        public Sentry.SentryTraceHeader SpanId;
        public Sentry.SentryId IsSampled; // 0x10
        public Sentry.SpanId <SpanId>k__BackingField; // 0x20
        public System.Nullable`1<bool> <IsSampled>k__BackingField; // 0x28

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFAC4422E80
        public void get_SpanId(){} // RVA: 0x7FFAC2F4F0C0
        public void get_IsSampled(){} // RVA: 0x7FFAC6D6E100
        public void .ctor(){} // RVA: 0x7FFAC8B52040
        public void ToString(){} // RVA: 0x7FFAC8B52060
        public void Parse(){} // RVA: 0x7FFAC8B52240
        public void .cctor(){} // RVA: 0x7FFAC8B52610
    }

    public class SentryTransaction : Object
    {
        public Sentry.SentryId EventId; // 0x10
        public string SpanId; // 0x20
        public 0x6B19A3C8 Origin; // 0x28
        public System.Nullable`1<bool> ParentSpanId; // 0x2C
        public string TraceId; // 0x30
        public string Name; // 0x38
        public string NameSource; // 0x40
        public System.DateTimeOffset IsParentSampled; // 0x48
        public System.Nullable`1<System.DateTimeOffset> Platform; // 0x58
        public System.Collections.Generic.Dictionary`2<string,Sentry.Protocol.Measurement> Release; // 0x70
        public System.Nullable`1<double> Distribution; // 0x78
        public System.Nullable`1<0x6B198C68> StartTimestamp; // 0x88
        public Sentry.SentryRequest EndTimestamp; // 0x90
        public Sentry.SentryContexts Measurements; // 0x98
        public Sentry.SentryUser Operation; // 0xA0
        public string Description; // 0xA8
        public Sentry.SdkVersion Status; // 0xB0
        public System.Collections.Generic.IReadOnlyList`1<string> IsSampled; // 0xB8
        public System.Collections.Generic.List`1<Sentry.Breadcrumb> SampleRate; // 0xC0
        public System.Collections.Generic.Dictionary`2<string,object> Level; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,string> Request; // 0xD0
        public Sentry.SentrySpan[] Contexts; // 0xD8
        public Sentry.Protocol.Metrics.MetricsSummary User; // 0xE0
        public Sentry.DynamicSamplingContext Environment; // 0xE8
        public Sentry.Internal.ITransactionProfiler Sentry.IEventLike.TransactionName; // 0xF0

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFAC4422E80
        public void set_EventId(){} // RVA: 0x7FFAC4422E90
        public void get_SpanId(){} // RVA: 0x7FFAC8B52740
        public void set_SpanId(){} // RVA: 0x7FFAC8B527B0
        public void get_Origin(){} // RVA: 0x7FFAC8B52830
        public void set_Origin(){} // RVA: 0x7FFAC8B528A0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC8B52930
        public void set_ParentSpanId(){} // RVA: 0x7FFAC8B529C0
        public void get_TraceId(){} // RVA: 0x7FFAC8B52A40
        public void set_TraceId(){} // RVA: 0x7FFAC8B52AD0
        public void get_Name(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Name(){} // RVA: 0x7FFAC2F4F0D0
        public void get_NameSource(){} // RVA: 0x7FFAC32EC4C0
        public void get_IsParentSampled(){} // RVA: 0x7FFAC8B52B50
        public void set_IsParentSampled(){} // RVA: 0x7FFAC8B52B60
        public void get_Platform(){} // RVA: 0x7FFAC31D95E0
        public void set_Platform(){} // RVA: 0x7FFAC2F4F890
        public void get_Release(){} // RVA: 0x7FFAC31D0140
        public void set_Release(){} // RVA: 0x7FFAC31D0C20
        public void get_Distribution(){} // RVA: 0x7FFAC2F9E740
        public void set_Distribution(){} // RVA: 0x7FFAC2F49200
        public void get_StartTimestamp(){} // RVA: 0x7FFAC4A7F120
        public void set_StartTimestamp(){} // RVA: 0x7FFAC87B5A10
        public void get_EndTimestamp(){} // RVA: 0x7FFAC2F2AE50
        public void set_EndTimestamp(){} // RVA: 0x7FFAC2F2AE70
        public void get_Measurements(){} // RVA: 0x7FFAC8B52B70
        public void SetMeasurement(){} // RVA: 0x7FFAC8B52C30
        public void get_Operation(){} // RVA: 0x7FFAC8B52D50
        public void set_Operation(){} // RVA: 0x7FFAC8B52DC0
        public void get_Description(){} // RVA: 0x7FFAC8B52E90
        public void set_Description(){} // RVA: 0x7FFAC8B52F00
        public void get_Status(){} // RVA: 0x7FFAC8B52FD0
        public void set_Status(){} // RVA: 0x7FFAC8B53040
        public void get_IsSampled(){} // RVA: 0x7FFAC8B530C0
        public void set_IsSampled(){} // RVA: 0x7FFAC8B53130
        public void get_SampleRate(){} // RVA: 0x7FFAC8A33E20
        public void set_SampleRate(){} // RVA: 0x7FFAC8A33E30
        public void get_Level(){} // RVA: 0x7FFAC37EE8C0
        public void set_Level(){} // RVA: 0x7FFAC37F9DE0
        public void get_Request(){} // RVA: 0x7FFAC8B53260
        public void set_Request(){} // RVA: 0x7FFAC354E360
        public void get_Contexts(){} // RVA: 0x7FFAC354DFB0
        public void set_Contexts(){} // RVA: 0x7FFAC8B53300
        public void get_User(){} // RVA: 0x7FFAC8B53330
        public void set_User(){} // RVA: 0x7FFAC354E420
        public void get_Environment(){} // RVA: 0x7FFAC354B1A0
        public void set_Environment(){} // RVA: 0x7FFAC334B370
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7FFAC2F4F0C0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7FFAC8B533D0
        public void get_Sdk(){} // RVA: 0x7FFAC2F8C040
        public void set_Sdk(){} // RVA: 0x7FFAC2F8C050
        public void get_Fingerprint(){} // RVA: 0x7FFAC8B53480
        public void set_Fingerprint(){} // RVA: 0x7FFAC2F8C0C0
        public void get_Breadcrumbs(){} // RVA: 0x7FFAC2F8C120
        public void get_Extra(){} // RVA: 0x7FFAC3079460
        public void get_Tags(){} // RVA: 0x7FFAC303E100
        public void get_Spans(){} // RVA: 0x7FFAC3540F70
        public void get_IsFinished(){} // RVA: 0x7FFAC8B534D0
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFAC2FA2970
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFAC2FA2980
        public void get_TransactionProfiler(){} // RVA: 0x7FFAC2F8C2A0
        public void set_TransactionProfiler(){} // RVA: 0x7FFAC2F8C2B0
        public void .ctor(){} // RVA: 0x7FFAC8B53DD0 | overloaded x4
        public void FromTracerSpans(){} // RVA: 0x7FFAC8B54B20
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8B55530
        public void SetExtra(){} // RVA: 0x7FFAC8B55590
        public void SetTag(){} // RVA: 0x7FFAC8B55620
        public void UnsetTag(){} // RVA: 0x7FFAC8B556B0
        public void GetTraceHeader(){} // RVA: 0x7FFAC8B55710
        public void Redact(){} // RVA: 0x7FFAC8B55800
        public void WriteTo(){} // RVA: 0x7FFAC8B55D30
        public void FromJson(){} // RVA: 0x7FFAC8B56730
    }

    public class SentryUser : Object
    {
        public System.Action`1<Sentry.SentryUser> PropertyChanged; // 0x10
        public string Id; // 0x18
        public string Username; // 0x20
        public string Email; // 0x28
        public string IpAddress; // 0x30
        public string Segment; // 0x38
        public System.Collections.Generic.IDictionary`2<string,string> Other; // 0x40

        // ── Methods ──
        public void get_PropertyChanged(){} // RVA: 0x7FFAC2F3C380
        public void set_PropertyChanged(){} // RVA: 0x7FFAC2F22E30
        public void get_Id(){} // RVA: 0x7FFAC2F247C0
        public void set_Id(){} // RVA: 0x7FFAC8B58AC0
        public void get_Username(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Username(){} // RVA: 0x7FFAC8B58B80
        public void get_Email(){} // RVA: 0x7FFAC2F4F130
        public void set_Email(){} // RVA: 0x7FFAC8B58C40
        public void get_IpAddress(){} // RVA: 0x7FFAC31D95E0
        public void set_IpAddress(){} // RVA: 0x7FFAC8B58D00
        public void get_Segment(){} // RVA: 0x7FFAC31D0140
        public void set_Segment(){} // RVA: 0x7FFAC8B58DC0
        public void get_Other(){} // RVA: 0x7FFAC8B58E80
        public void set_Other(){} // RVA: 0x7FFAC8B58F40
        public void Clone(){} // RVA: 0x7FFAC8B58FB0
        public void CopyTo(){} // RVA: 0x7FFAC8B59010
        public void HasAnyData(){} // RVA: 0x7FFAC8B592C0
        public void WriteTo(){} // RVA: 0x7FFAC8B59340
        public void FromJson(){} // RVA: 0x7FFAC8B59530
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SentryValues`1 : Object
    {
        public System.Collections.Generic.IEnumerable`1<T> Values;

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void WriteTo(){} // RVA: 0x7FFAC2C79B30
    }

    public class SessionUpdate : Object
    {
        public Sentry.SentryId Id; // 0x10
        public string DistinctId; // 0x20
        public System.DateTimeOffset StartTimestamp; // 0x28
        public string Release; // 0x38
        public string Environment; // 0x40
        public string IpAddress; // 0x48
        public string UserAgent; // 0x50
        public int ErrorCount; // 0x58
        public bool IsInitial; // 0x5C
        public System.DateTimeOffset Timestamp; // 0x60
        public int SequenceNumber; // 0x70
        public System.Nullable`1<0x6B199D98> Duration; // 0x74

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAC4422E80
        public void get_DistinctId(){} // RVA: 0x7FFAC2F4F0C0
        public void get_StartTimestamp(){} // RVA: 0x7FFAC3BCF020
        public void get_Release(){} // RVA: 0x7FFAC31D0140
        public void get_Environment(){} // RVA: 0x7FFAC2F9E740
        public void get_IpAddress(){} // RVA: 0x7FFAC2F9C730
        public void get_UserAgent(){} // RVA: 0x7FFAC2FC20E0
        public void get_ErrorCount(){} // RVA: 0x7FFAC362EA40
        public void get_IsInitial(){} // RVA: 0x7FFAC2FBF240
        public void get_Timestamp(){} // RVA: 0x7FFAC5FD8A60
        public void get_SequenceNumber(){} // RVA: 0x7FFAC3B99E80
        public void get_Duration(){} // RVA: 0x7FFAC8B59C40
        public void get_EndStatus(){} // RVA: 0x7FFAC8B59CC0
        public void .ctor(){} // RVA: 0x7FFAC8B5A120 | overloaded x4
        public void WriteTo(){} // RVA: 0x7FFAC8B5A160
        public void FromJson(){} // RVA: 0x7FFAC8B5A820
    }

    public class SpanContext : Object
    {
        public Sentry.SpanId SpanId; // 0x10
        public System.Nullable`1<Sentry.SpanId> ParentSpanId; // 0x18
        public Sentry.SentryId TraceId; // 0x28
        public string Operation; // 0x38
        public string Description; // 0x40
        public System.Nullable`1<0x6B199F50> Status; // 0x48
        public System.Nullable`1<bool> IsSampled; // 0x50
        public 0x6B197560 Instrumenter; // 0x54
        public string Origin; // 0x58

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFAC2F3C380
        public void get_ParentSpanId(){} // RVA: 0x7FFAC35D3330
        public void get_TraceId(){} // RVA: 0x7FFAC3BCF020
        public void get_Operation(){} // RVA: 0x7FFAC31D0140
        public void set_Operation(){} // RVA: 0x7FFAC31D0C20
        public void get_Description(){} // RVA: 0x7FFAC2F9E740
        public void get_Status(){} // RVA: 0x7FFAC2F9C730
        public void get_IsSampled(){} // RVA: 0x7FFAC6AD8870
        public void get_Instrumenter(){} // RVA: 0x7FFAC38913D0
        public void set_Instrumenter(){} // RVA: 0x7FFAC3890750
        public void get_Origin(){} // RVA: 0x7FFAC2FE9500
        public void set_Origin(){} // RVA: 0x7FFAC8B5B9A0
        public void .ctor(){} // RVA: 0x7FFAC8B5BAA0
    }

    public class SpanDataExtensions : Object
    {
        // ── Methods ──
        public void SetMeasurement(){} // RVA: 0x7FFAC8A42A90 | overloaded x4
    }

    public class SpanExtensions : Object
    {
        // ── Methods ──
        public void StartChild(){} // RVA: 0x7FFAC8A41DD0 | overloaded x2
        public void GetTransaction(){} // RVA: 0x7FFAC8A42020
        public void GetDbParentSpan(){} // RVA: 0x7FFAC8A42120
    }

    public class SpanId : ValueType
    {
        public char[] HexChars;
        public Sentry.Internal.RandomValuesFactory Random; // 0x8
        public long _value; // 0x10
        public Sentry.SpanId Empty; // 0x10

        // ── Methods ──
        public void GetValue(){} // RVA: 0x7FFAC3AD9F60
        public void .ctor(){} // RVA: 0x7FFAC45BB120 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAC8B5BD70 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8B5BE50
        public void ToString(){} // RVA: 0x7FFAC8B5BFE0
        public void Create(){} // RVA: 0x7FFAC8B5C0D0
        public void WriteTo(){} // RVA: 0x7FFAC8B5C1C0
        public void Parse(){} // RVA: 0x7FFAC8B5C550
        public void FromJson(){} // RVA: 0x7FFAC8B5C580
        public void op_Equality(){} // RVA: 0x7FFAC8B5C680
        public void op_Inequality(){} // RVA: 0x7FFAC8B5C710
        public void op_Implicit(){} // RVA: 0x7FFAC8B5C780
        public void .cctor(){} // RVA: 0x7FFAC8B5C7D0
    }

    public class SpanStatusConverter : Object
    {
        // ── Methods ──
        public void FromException(){} // RVA: 0x7FFAC8B5C960
        public void FromHttpStatusCode(){} // RVA: 0x7FFAC8B5CBE0 | overloaded x2
        public void FromGrpcStatusCode(){} // RVA: 0x7FFAC8B5CCA0
    }

    public class SpanTracer : Object
    {
        public Sentry.IHub Sentry.IBaseTracer.IsOtelInstrumenter; // 0x10
        public Sentry.Internal.SentryStopwatch Transaction; // 0x18
        public 0x6B197560 MetricsSummary; // 0x30
        public Sentry.TransactionTracer HasMetrics; // 0x38
        public System.Lazy`1<Sentry.MetricsSummaryAggregator> SpanId; // 0x40
        public Sentry.SpanId ParentSpanId; // 0x48
        public System.Nullable`1<Sentry.SpanId> TraceId; // 0x50
        public Sentry.SentryId StartTimestamp; // 0x60
        public System.DateTimeOffset EndTimestamp; // 0x70
        public System.Nullable`1<System.DateTimeOffset> IsFinished; // 0x80
        public System.Collections.Generic.Dictionary`2<string,Sentry.Protocol.Measurement> InternalMeasurements; // 0x98
        public string Measurements; // 0xA0
        public string Operation; // 0xA8
        public System.Nullable`1<0x6B199F50> Description; // 0xB0
        public bool Status; // 0xB8
        public System.Nullable`1<bool> IsSentryRequest; // 0xB9
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> IsSampled; // 0xC0
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> InternalTags; // 0xC8
        public System.Func`1<bool> Tags; // 0xD0
        public string Extra; // 0xD8

        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7FFAC8B5CD60
        public void get_Transaction(){} // RVA: 0x7FFAC31D0140
        public void get_MetricsSummary(){} // RVA: 0x7FFAC8B5CD70
        public void get_HasMetrics(){} // RVA: 0x7FFAC8B5CDC0
        public void get_SpanId(){} // RVA: 0x7FFAC2F9C730
        public void set_SpanId(){} // RVA: 0x7FFAC4248FC0
        public void get_ParentSpanId(){} // RVA: 0x7FFAC6AD4D90
        public void set_ParentSpanId(){} // RVA: 0x7FFAC82D1E00
        public void get_TraceId(){} // RVA: 0x7FFAC5FD8A60
        public void get_StartTimestamp(){} // RVA: 0x7FFAC87AD900
        public void set_StartTimestamp(){} // RVA: 0x7FFAC87AD910
        public void get_EndTimestamp(){} // RVA: 0x7FFAC3A91CD0
        public void set_EndTimestamp(){} // RVA: 0x7FFAC3A91CB0
        public void get_IsFinished(){} // RVA: 0x7FFAC8B5CE10
        public void get_InternalMeasurements(){} // RVA: 0x7FFAC354DFB0
        public void set_InternalMeasurements(){} // RVA: 0x7FFAC354E3C0
        public void get_Measurements(){} // RVA: 0x7FFAC8B5CE50
        public void SetMeasurement(){} // RVA: 0x7FFAC8B5CF20
        public void get_Operation(){} // RVA: 0x7FFAC3543900
        public void set_Operation(){} // RVA: 0x7FFAC354E420
        public void get_Description(){} // RVA: 0x7FFAC354B1A0
        public void set_Description(){} // RVA: 0x7FFAC334B370
        public void get_Status(){} // RVA: 0x7FFAC2F8C040
        public void set_Status(){} // RVA: 0x7FFAC45CA6B0
        public void get_IsSentryRequest(){} // RVA: 0x7FFAC41F1470
        public void set_IsSentryRequest(){} // RVA: 0x7FFAC41EEB20
        public void get_IsSampled(){} // RVA: 0x7FFAC8B5D050
        public void set_IsSampled(){} // RVA: 0x7FFAC8B5D060
        public void get_InternalTags(){} // RVA: 0x7FFAC2F8C120
        public void set_InternalTags(){} // RVA: 0x7FFAC2F8C130
        public void get_Tags(){} // RVA: 0x7FFAC8B5D070
        public void SetTag(){} // RVA: 0x7FFAC8B5D140
        public void UnsetTag(){} // RVA: 0x7FFAC8B5D260
        public void get_Extra(){} // RVA: 0x7FFAC3079460
        public void SetExtra(){} // RVA: 0x7FFAC8B5D3D0
        public void get_IsFiltered(){} // RVA: 0x7FFAC303E100
        public void set_IsFiltered(){} // RVA: 0x7FFAC303E110
        public void .ctor(){} // RVA: 0x7FFAC8B5D760 | overloaded x2
        public void StartChild(){} // RVA: 0x7FFAC8B5DA70
        public void Unfinish(){} // RVA: 0x7FFAC8B5DAC0
        public void Finish(){} // RVA: 0x7FFAC8B5E120 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x7FFAC8B5E160
        public void get_Origin(){} // RVA: 0x7FFAC3540F70
        public void set_Origin(){} // RVA: 0x7FFAC8B5E1D0
    }

    public class StreamAttachmentContent : Object
    {
        public System.IO.Stream _stream; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetStream(){} // RVA: 0x7FFAC2F3C380
    }

    public class SubstringOrRegexPattern : Object
    {
        public System.Text.RegularExpressions.Regex Regex; // 0x10
        public string _substring; // 0x18
        public 0x6B0C1288 _stringComparison; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAC8B5E410 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC8B5E4A0
        public void Equals(){} // RVA: 0x7FFAC8B5E510
        public void GetHashCode(){} // RVA: 0x7FFAC49DB960
        public void get_Regex(){} // RVA: 0x7FFAC2F3C380
        public void IsMatch(){} // RVA: 0x7FFAC8B5E610
        public void TryParseRegex(){} // RVA: 0x7FFAC8B5E7B0
    }

    public class SubstringOrRegexPatternExtensions : Object
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x7FFAC8B5E860
        public void WithConfigBinding(){} // RVA: 0x7FFAC2C58F80
    }

    public class SubstringOrRegexPatternTypeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAC8B5E980
        public void ConvertFrom(){} // RVA: 0x7FFAC8B5EA50
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}