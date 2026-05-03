// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 44
// Methods: 986

namespace ThirdParty.Sentry.Sentry
{
    public class Scope : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public bool _locked; // 0x18
        public object _lastEventIdSync; // 0x20
        public Sentry.SentryId _lastEventId; // 0x28
        public object _evaluationSync; // 0x38
        public bool _hasEvaluated; // 0x40
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentBag`1<Sentry.Extensibility.ISentryEventExceptionProcessor>> _lazyExceptionProcessors; // 0x48
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentBag`1<Sentry.Extensibility.ISentryEventProcessor>> _lazyEventProcessors; // 0x50
        public System.Lazy`1<System.Collections.Concurrent.ConcurrentBag`1<Sentry.Extensibility.ISentryTransactionProcessor>> _lazyTransactionProcessors; // 0x58
        public System.EventHandler`1<Sentry.Scope> OnEvaluating; // 0x60
        public System.Nullable`1<0x6659252C> _level; // 0x68
        public Sentry.SentryRequest _request; // 0x70
        public Sentry.SentryContexts _contexts; // 0x78
        public Sentry.SentryUser _user; // 0x80
        public string _release; // 0x88
        public string _distribution; // 0x90
        public string _environment; // 0x98
        public string _fallbackTransactionName; // 0xA0
        public Sentry.ITransactionTracer _transaction; // 0xA8
        public Sentry.SentryPropagationContext _propagationContext; // 0xB0
        public Sentry.SessionUpdate _sessionUpdate; // 0xB8
        public Sentry.SdkVersion _sdk; // 0xC0
        public System.Collections.Generic.IReadOnlyList`1<string> _fingerprint; // 0xC8
        public System.Collections.Concurrent.ConcurrentQueue`1<Sentry.Breadcrumb> _breadcrumbs; // 0xD0
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> _extra; // 0xD8
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> _tags; // 0xE0

        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFE81116380
        public void get_Locked(){} // RVA: 0x7FFE811164E0
        public void set_Locked(){} // RVA: 0x7FFE811164F0
        public void get_LastEventId(){} // RVA: 0x7FFE86DF7200
        public void set_LastEventId(){} // RVA: 0x7FFE86DF7350
        public void get_HasEvaluated(){} // RVA: 0x7FFE86DF7490
        public void get_ExceptionProcessors(){} // RVA: 0x7FFE86DF74A0
        public void get_EventProcessors(){} // RVA: 0x7FFE86DF74F0
        public void get_TransactionProcessors(){} // RVA: 0x7FFE86DF7540
        public void add_OnEvaluating(){} // RVA: 0x7FFE86DF7590
        public void remove_OnEvaluating(){} // RVA: 0x7FFE86DF7690
        public void get_Level(){} // RVA: 0x7FFE82A22EF0
        public void set_Level(){} // RVA: 0x7FFE82A22F00
        public void get_Request(){} // RVA: 0x7FFE86DF7790
        public void set_Request(){} // RVA: 0x7FFE811C35A0
        public void get_Contexts(){} // RVA: 0x7FFE81463AE0
        public void set_Contexts(){} // RVA: 0x7FFE86DF7830
        public void get_UserChanged(){} // RVA: 0x7FFE86DF7850
        public void get_User(){} // RVA: 0x7FFE86DF78D0
        public void set_User(){} // RVA: 0x7FFE86DF79F0
        public void get_Release(){} // RVA: 0x7FFE8113A010
        public void set_Release(){} // RVA: 0x7FFE81280F90
        public void get_Distribution(){} // RVA: 0x7FFE8154EB60
        public void set_Distribution(){} // RVA: 0x7FFE818CE320
        public void get_Environment(){} // RVA: 0x7FFE817AE360
        public void set_Environment(){} // RVA: 0x7FFE8171B470
        public void get_TransactionName(){} // RVA: 0x7FFE86DF7AC0
        public void set_TransactionName(){} // RVA: 0x7FFE86DF7B20
        public void get_Transaction(){} // RVA: 0x7FFE817AB5E0
        public void set_Transaction(){} // RVA: 0x7FFE81857260
        public void get_PropagationContext(){} // RVA: 0x7FFE81166040
        public void set_PropagationContext(){} // RVA: 0x7FFE81166050
        public void get_SessionUpdate(){} // RVA: 0x7FFE811660B0
        public void set_SessionUpdate(){} // RVA: 0x7FFE811660C0
        public void get_Sdk(){} // RVA: 0x7FFE81166120
        public void get_Fingerprint(){} // RVA: 0x7FFE81253460
        public void set_Fingerprint(){} // RVA: 0x7FFE81253470
        public void get_Breadcrumbs(){} // RVA: 0x7FFE81218100
        public void get_Extra(){} // RVA: 0x7FFE8181EA80
        public void get_Tags(){} // RVA: 0x7FFE8117C900
        public void get_Attachments(){} // RVA: 0x7FFE8117C970
        public void .ctor(){} // RVA: 0x7FFE86DF8530 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFE86DF8610 | overloaded x2
        public void SetExtra(){} // RVA: 0x7FFE86DF8840
        public void SetTag(){} // RVA: 0x7FFE86DF88F0
        public void UnsetTag(){} // RVA: 0x7FFE86DF8AA0
        public void AddAttachment(){} // RVA: 0x7FFE86DFC610 | overloaded x4
        public void Clear(){} // RVA: 0x7FFE86DF8C10
        public void ClearAttachments(){} // RVA: 0x7FFE86DF9250
        public void ClearBreadcrumbs(){} // RVA: 0x7FFE86DF9300
        public void Apply(){} // RVA: 0x7FFE86DFA920 | overloaded x3
        public void Clone(){} // RVA: 0x7FFE86DFAA00
        public void Evaluate(){} // RVA: 0x7FFE86DFB270
        public void get_Span(){} // RVA: 0x7FFE86DFB510
        public void set_Span(){} // RVA: 0x7FFE811662B0
        public void GetAllEventProcessors(){} // RVA: 0x7FFE86DFB600
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFE86DFB6B0
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFE86DFB760
        public void AddExceptionProcessor(){} // RVA: 0x7FFE86DFB810
        public void AddExceptionProcessors(){} // RVA: 0x7FFE86DFB8A0
        public void AddEventProcessor(){} // RVA: 0x7FFE86DFBB70 | overloaded x2
        public void AddEventProcessors(){} // RVA: 0x7FFE86DFBC90
        public void AddTransactionProcessor(){} // RVA: 0x7FFE86DFBF60 | overloaded x2
        public void AddTransactionProcessors(){} // RVA: 0x7FFE86DFC080
        public void ResetTransaction(){} // RVA: 0x7FFE86DFC790
        public void <get_UserChanged>b__41_0(){} // RVA: 0x7FFE86DFC7F0
    }

    public class SdkVersion : Object
    {
        public System.Lazy`1<Sentry.SdkVersion> InstanceLazy;
        public System.Collections.Concurrent.ConcurrentBag`1<Sentry.SentryPackage> _internalPackages; // 0x10
        public System.Collections.Concurrent.ConcurrentBag`1<string> _integrations; // 0x18
        public string _name; // 0x20
        public string _version; // 0x28
        public object field_5; // 0xA1

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86ED2520
        public void get_InternalPackages(){} // RVA: 0x7FFE81116380
        public void set_InternalPackages(){} // RVA: 0x7FFE810FCE30
        public void get_Integrations(){} // RVA: 0x7FFE810FE7C0
        public void set_Integrations(){} // RVA: 0x7FFE81161E80
        public void get_Packages(){} // RVA: 0x7FFE81116380
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void set_Name(){} // RVA: 0x7FFE811290D0
        public void get_Version(){} // RVA: 0x7FFE81129130
        public void set_Version(){} // RVA: 0x7FFE810FCE90
        public void AddPackage(){} // RVA: 0x7FFE86ED2660 | overloaded x2
        public void AddIntegration(){} // RVA: 0x7FFE86ED26C0
        public void WriteTo(){} // RVA: 0x7FFE86ED2720
        public void FromJson(){} // RVA: 0x7FFE86ED29A0
        public void .ctor(){} // RVA: 0x7FFE86ED35A0
        public void .cctor(){} // RVA: 0x7FFE86ED3700
    }

    public class SentryAttachment : Object
    {
        public 0x66591D44 _type; // 0x10
        public Sentry.IAttachmentContent _content; // 0x18
        public string _fileName; // 0x20
        public string _contentType; // 0x28

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811485C0
        public void get_Content(){} // RVA: 0x7FFE810FE7C0
        public void get_FileName(){} // RVA: 0x7FFE811290C0
        public void get_ContentType(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE8673B0D0
    }

    public class SentryCheckIn : Object
    {
        public Sentry.SentryId _id; // 0x10
        public string _monitorSlug; // 0x20
        public 0x66591DF4 _status; // 0x28
        public System.Nullable`1<System.TimeSpan> _duration; // 0x30
        public string _release; // 0x40
        public string _environment; // 0x48
        public System.Nullable`1<Sentry.SentryId> _traceId; // 0x50
        public Sentry.SentryMonitorOptions _monitorOptions; // 0x68

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE826F6B90
        public void get_MonitorSlug(){} // RVA: 0x7FFE811290C0
        public void get_Status(){} // RVA: 0x7FFE81549710
        public void get_Duration(){} // RVA: 0x7FFE86809840
        public void set_Duration(){} // RVA: 0x7FFE86809850
        public void get_Release(){} // RVA: 0x7FFE81178740
        public void set_Release(){} // RVA: 0x7FFE81123200
        public void get_Environment(){} // RVA: 0x7FFE81176730
        public void set_Environment(){} // RVA: 0x7FFE81176740
        public void get_TraceId(){} // RVA: 0x7FFE84E6DCE0
        public void set_TraceId(){} // RVA: 0x7FFE86ED3B70
        public void get_MonitorOptions(){} // RVA: 0x7FFE81176D50
        public void set_MonitorOptions(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE86ED3B80
        public void WriteTo(){} // RVA: 0x7FFE86ED3CD0
        public void ToSnakeCase(){} // RVA: 0x7FFE86ED41D0
    }

    public class SentryClient : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public Sentry.ISessionManager _sessionManager; // 0x18
        public Sentry.Internal.RandomValuesFactory _randomValuesFactory; // 0x20

        // ── Methods ──
        public void get_Worker(){} // RVA: 0x7FFE8144E200
        public void get_Options(){} // RVA: 0x7FFE81116380
        public void get_IsEnabled(){} // RVA: 0x7FFE811E0850
        public void .ctor(){} // RVA: 0x7FFE86ED4300 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFE86ED48E0
        public void CaptureUserFeedback(){} // RVA: 0x7FFE86ED4A90
        public void CaptureTransaction(){} // RVA: 0x7FFE86ED4D90 | overloaded x2
        public void BeforeSendTransaction(){} // RVA: 0x7FFE86ED59D0
        public void CaptureSession(){} // RVA: 0x7FFE86ED5CD0
        public void CaptureCheckIn(){} // RVA: 0x7FFE86ED5E60
        public void FlushAsync(){} // RVA: 0x7FFE86ED6440
        public void DoSendEvent(){} // RVA: 0x7FFE86ED64A0
        public void ApplyExceptionFilters(){} // RVA: 0x7FFE86ED7910
        public void CaptureEnvelope(){} // RVA: 0x7FFE86ED7C40
        public void BeforeSend(){} // RVA: 0x7FFE86ED7E10
        public void Dispose(){} // RVA: 0x7FFE86ED8110
    }

    public class SentryClientExtensions : Object
    {
        public Sentry.SentryOptions _sentryOptionsForTestingOnly;

        // ── Methods ──
        public void CaptureException(){} // RVA: 0x7FFE86ED83C0
        public void CaptureMessage(){} // RVA: 0x7FFE86ED8530
        public void CaptureUserFeedback(){} // RVA: 0x7FFE86ED8700
        public void Flush(){} // RVA: 0x7FFE86ED8880 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFE86ED8960
        public void get_SentryOptionsForTestingOnly(){} // RVA: 0x7FFE86ED8A00
        public void set_SentryOptionsForTestingOnly(){} // RVA: 0x7FFE86ED8A40
        public void GetSentryOptions(){} // RVA: 0x7FFE86ED8AE0
    }

    public class SentryConstants : Object
    {
    }

    public class SentryContexts : Object
    {
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> _innerDictionary; // 0x10
        public object field_1; // 0xB7
        public object field_2; // 0xB8
        public object field_3; // 0xB9
        public object field_4; // 0xBA
        public object field_5; // 0xBB
        public object field_6; // 0xBC
        public object field_7; // 0xBD
        public object field_8; // 0xBE
        public object field_9; // 0xBF
        public object field_10; // 0xC0
        public object field_11; // 0xC1
        public object field_12; // 0xC2

        // ── Methods ──
        public void get_App(){} // RVA: 0x7FFE86ED8C50
        public void get_Browser(){} // RVA: 0x7FFE86ED8CB0
        public void get_Device(){} // RVA: 0x7FFE86ED8D10
        public void get_OperatingSystem(){} // RVA: 0x7FFE86ED8D70
        public void get_Response(){} // RVA: 0x7FFE86ED8DD0
        public void get_Runtime(){} // RVA: 0x7FFE86ED8E30
        public void get_Gpu(){} // RVA: 0x7FFE86ED8E90
        public void get_Trace(){} // RVA: 0x7FFE86ED8EF0
        public void .ctor(){} // RVA: 0x7FFE86ED8F50
        public void Clone(){} // RVA: 0x7FFE86ED9090
        public void CopyTo(){} // RVA: 0x7FFE86EDA7F0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE86ED9470
        public void FromJson(){} // RVA: 0x7FFE86ED96F0
        public void ReplaceWith(){} // RVA: 0x7FFE86EDA240
        public void NullIfEmpty(){} // RVA: 0x7FFE86EDA4F0
        public void GetEnumerator(){} // RVA: 0x7FFE86EDA550
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFE86EDA5A0
        public void Add(){} // RVA: 0x7FFE86EDAA40 | overloaded x2
        public void Clear(){} // RVA: 0x7FFE86EDA6C0
        public void Contains(){} // RVA: 0x7FFE86EDA710
        public void Remove(){} // RVA: 0x7FFE86EDAB30 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFE86EDA9A0
        public void get_IsReadOnly(){} // RVA: 0x7FFE86EDA9F0
        public void ContainsKey(){} // RVA: 0x7FFE86EDAAD0
        public void TryGetValue(){} // RVA: 0x7FFE86EDAB90
        public void get_Item(){} // RVA: 0x7FFE86EDAD70
        public void set_Item(){} // RVA: 0x7FFE86EDADD0
        public void get_Keys(){} // RVA: 0x7FFE86EDAE40
        public void get_Values(){} // RVA: 0x7FFE86EDAEA0
    }

    public class SentryEvent : Object
    {
        public System.Collections.Generic.IDictionary`2<string,string> _modules; // 0x10
        public System.Exception _exception; // 0x18
        public Sentry.SentryId _eventId; // 0x20
        public System.DateTimeOffset _timestamp; // 0x30
        public Sentry.SentryMessage _message; // 0x40
        public string _logger; // 0x48
        public string _platform; // 0x50
        public string _serverName; // 0x58
        public string _release; // 0x60
        public string _distribution; // 0x68
        public Sentry.SentryValues`1<Sentry.Protocol.SentryException> _sentryExceptionValues; // 0x70
        public Sentry.SentryValues`1<Sentry.SentryThread> _sentryThreadValues; // 0x78
        public Sentry.Protocol.DebugMeta _debugMeta; // 0x80
        public System.Nullable`1<0x6659252C> _level; // 0x88
        public string _transactionName; // 0x90
        public Sentry.SentryRequest _request; // 0x98
        public Sentry.SentryContexts _contexts; // 0xA0
        public Sentry.SentryUser _user; // 0xA8
        public string _environment; // 0xB0
        public Sentry.SdkVersion _sdk; // 0xB8
        public System.Collections.Generic.IReadOnlyList`1<string> _fingerprint; // 0xC0
        public System.Collections.Generic.List`1<Sentry.Breadcrumb> _breadcrumbs; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,object> _extra; // 0xD0
        public System.Collections.Generic.Dictionary`2<string,string> _tags; // 0xD8
        public Sentry.DynamicSamplingContext _dynamicSamplingContext; // 0xE0
        public object field_25; // 0xC4
        public object field_26; // 0xC5

        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7FFE810FE7C0
        public void get_EventId(){} // RVA: 0x7FFE82C84C90
        public void get_Timestamp(){} // RVA: 0x7FFE86809840
        public void get_Message(){} // RVA: 0x7FFE81178740
        public void set_Message(){} // RVA: 0x7FFE81123200
        public void get_Logger(){} // RVA: 0x7FFE81176730
        public void set_Logger(){} // RVA: 0x7FFE81176740
        public void get_Platform(){} // RVA: 0x7FFE8119C0E0
        public void set_Platform(){} // RVA: 0x7FFE812534D0
        public void get_ServerName(){} // RVA: 0x7FFE811C3500
        public void set_ServerName(){} // RVA: 0x7FFE811C3510
        public void get_Release(){} // RVA: 0x7FFE81199370
        public void set_Release(){} // RVA: 0x7FFE81199380
        public void get_Distribution(){} // RVA: 0x7FFE81176D50
        public void set_Distribution(){} // RVA: 0x7FFE81176D60
        public void get_SentryExceptionValues(){} // RVA: 0x7FFE811C3590
        public void set_SentryExceptionValues(){} // RVA: 0x7FFE811C35A0
        public void get_SentryExceptions(){} // RVA: 0x7FFE86EDB3D0
        public void set_SentryExceptions(){} // RVA: 0x7FFE86EDB440
        public void get_SentryThreadValues(){} // RVA: 0x7FFE81463AE0
        public void set_SentryThreadValues(){} // RVA: 0x7FFE81464570
        public void get_SentryThreads(){} // RVA: 0x7FFE86EDB570
        public void set_SentryThreads(){} // RVA: 0x7FFE86EDB5E0
        public void get_DebugImages(){} // RVA: 0x7FFE86EDB710
        public void set_DebugImages(){} // RVA: 0x7FFE86EDB730
        public void get_Modules(){} // RVA: 0x7FFE86EDB850
        public void get_Level(){} // RVA: 0x7FFE8194AD00
        public void set_Level(){} // RVA: 0x7FFE8194A400
        public void get_TransactionName(){} // RVA: 0x7FFE8154EB60
        public void set_TransactionName(){} // RVA: 0x7FFE818CE320
        public void get_Request(){} // RVA: 0x7FFE86EDB910
        public void set_Request(){} // RVA: 0x7FFE8171B470
        public void get_Contexts(){} // RVA: 0x7FFE8179C860
        public void set_Contexts(){} // RVA: 0x7FFE86EDB9B0
        public void get_User(){} // RVA: 0x7FFE86EDB9E0
        public void set_User(){} // RVA: 0x7FFE81857260
        public void get_Environment(){} // RVA: 0x7FFE81166040
        public void set_Environment(){} // RVA: 0x7FFE81166050
        public void get_Sdk(){} // RVA: 0x7FFE811660B0
        public void set_Sdk(){} // RVA: 0x7FFE811660C0
        public void get_Fingerprint(){} // RVA: 0x7FFE86EDBA80
        public void set_Fingerprint(){} // RVA: 0x7FFE81166130
        public void get_Breadcrumbs(){} // RVA: 0x7FFE86EDBAD0
        public void get_Extra(){} // RVA: 0x7FFE86EDBBA0
        public void get_Tags(){} // RVA: 0x7FFE86EDBC70
        public void HasException(){} // RVA: 0x7FFE86EDBD40
        public void HasTerminalException(){} // RVA: 0x7FFE86EDBDB0
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFE8117C900
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFE8117C910
        public void .ctor(){} // RVA: 0x7FFE86EDC1D0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFE86EDC600
        public void SetExtra(){} // RVA: 0x7FFE86EDC700
        public void SetTag(){} // RVA: 0x7FFE86EDC830
        public void UnsetTag(){} // RVA: 0x7FFE86EDC960
        public void Redact(){} // RVA: 0x7FFE86EDCA60
        public void WriteTo(){} // RVA: 0x7FFE86EDCCC0
        public void FromJson(){} // RVA: 0x7FFE86EDD510 | overloaded x2
    }

    public class SentryFailedRequestHandler : Object
    {
        public Sentry.IHub _hub; // 0x10
        public Sentry.SentryOptions _options; // 0x18

        // ── Methods ──
        public void get_Hub(){} // RVA: 0x7FFE81116380
        public void get_Options(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFE80E4F230
        public void HandleResponse(){} // RVA: 0x7FFE86EDFDA0
    }

    public class SentryGraphQLHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EDFFC0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFE86EE0140
    }

    public class SentryGraphQLHttpMessageHandler : SentryMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE09D0 | overloaded x2
        public void ProcessRequest(){} // RVA: 0x7FFE86EE0D60
        public void HandleResponse(){} // RVA: 0x7FFE86EE1120
        public void GetSpanDescriptionOrDefault(){} // RVA: 0x7FFE86EE1800
        public void AddIfExists(){} // RVA: 0x7FFE86EE1A10
    }

    public class SentryHint : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public System.Collections.Generic.List`1<Sentry.SentryAttachment> _attachments; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE1D30 | overloaded x3
        public void get_Attachments(){} // RVA: 0x7FFE810FE7C0
        public void get_Items(){} // RVA: 0x7FFE86EE1E60
        public void AddAttachmentsFromScope(){} // RVA: 0x7FFE86EE1F20
        public void AddAttachment(){} // RVA: 0x7FFE86EE2120 | overloaded x2
        public void WithAttachments(){} // RVA: 0x7FFE86EE2300 | overloaded x2
    }

    public class SentryHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE23A0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFE86EE23B0
    }

    public class SentryHttpMessageHandler : SentryMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE2AA0 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x7FFE86EE2CF0
        public void HandleResponse(){} // RVA: 0x7FFE86EE2F20
    }

    public class SentryId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE827D9C10
        public void ToString(){} // RVA: 0x7FFE86EE3260
        public void Equals(){} // RVA: 0x7FFE86EE3300 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86EE33E0
        public void Create(){} // RVA: 0x7FFE86EE3400
        public void WriteTo(){} // RVA: 0x7FFE86EE3460
        public void Parse(){} // RVA: 0x7FFE869D3D80
        public void FromJson(){} // RVA: 0x7FFE86EE3590
        public void op_Equality(){} // RVA: 0x7FFE86EE3780
        public void op_Inequality(){} // RVA: 0x7FFE86EE3830
        public void op_Implicit(){} // RVA: 0x7FFE8151C410 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE810FB310
    }

    public class SentryMessage : Object
    {
        public string _message; // 0x10
        public System.Collections.Generic.IEnumerable`1<object> _params; // 0x18
        public string _formatted; // 0x20

        // ── Methods ──
        public void get_Message(){} // RVA: 0x7FFE81116380
        public void set_Message(){} // RVA: 0x7FFE810FCE30
        public void get_Params(){} // RVA: 0x7FFE810FE7C0
        public void set_Params(){} // RVA: 0x7FFE81161E80
        public void get_Formatted(){} // RVA: 0x7FFE811290C0
        public void set_Formatted(){} // RVA: 0x7FFE811290D0
        public void op_Implicit(){} // RVA: 0x7FFE86EE3910
        public void WriteTo(){} // RVA: 0x7FFE86EE39B0
        public void FromJson(){} // RVA: 0x7FFE86EE3B10
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SentryMessageHandler : DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EE4510 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x7FFE80E403A0
        public void HandleResponse(){} // RVA: 0x7FFE80E50FC0
        public void SendAsync(){} // RVA: 0x7FFE86EE4710
        public void PropagateTraceHeaders(){} // RVA: 0x7FFE86EE4960
        public void AddSentryTraceHeader(){} // RVA: 0x7FFE86EE4D80
        public void AddBaggageHeader(){} // RVA: 0x7FFE86EE4ED0
        public void <>n__0(){} // RVA: 0x7FFE86EE5560
    }

    public class SentryMonitorOptions : Object
    {
        public 0x6659273C _type; // 0x10
        public string _crontab; // 0x18
        public System.Nullable`1<int> _interval; // 0x20
        public System.Nullable`1<0x66592794> _unit; // 0x28
        public System.Text.RegularExpressions.Regex CrontabValidationInstance;
        public System.Nullable`1<System.TimeSpan> _checkInMargin; // 0x30

        // ── Methods ──
        public void CrontabValidation(){} // RVA: 0x7FFE86EE5E00
        public void Interval(){} // RVA: 0x7FFE86EE61C0 | overloaded x2
        public void get_CheckInMargin(){} // RVA: 0x7FFE86809840
        public void set_CheckInMargin(){} // RVA: 0x7FFE86809850
        public void get_MaxRuntime(){} // RVA: 0x7FFE82D32FA0
        public void set_MaxRuntime(){} // RVA: 0x7FFE850A4980
        public void get_FailureIssueThreshold(){} // RVA: 0x7FFE8119C0E0
        public void set_FailureIssueThreshold(){} // RVA: 0x7FFE86EE62A0
        public void get_RecoveryThreshold(){} // RVA: 0x7FFE811C3500
        public void set_RecoveryThreshold(){} // RVA: 0x7FFE86EE6350
        public void get_TimeZone(){} // RVA: 0x7FFE81199370
        public void set_TimeZone(){} // RVA: 0x7FFE81199380
        public void get_Owner(){} // RVA: 0x7FFE81176D50
        public void set_Owner(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void WriteTo(){} // RVA: 0x7FFE86EE6400
        public void TypeToString(){} // RVA: 0x7FFE86EE6C00
    }

    public class SentryOptions : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> _defaultTags; // 0x10
        public 0x66529334 DefaultRegexOptions;
        public Sentry.Internal.ScopeStack.IScopeStackContainer _scopeStackContainer; // 0x18
        public System.Lazy`1<string> _lazyInstallationId; // 0x20
        public System.Nullable`1<bool> _isGlobalModeEnabled; // 0x28
        public Sentry.IScopeObserver _scopeObserver; // 0x30
        public bool _enableScopeSync; // 0x38
        public Sentry.Extensibility.ITransport _transport; // 0x40
        public System.Lazy`1<Sentry.Internal.IClientReportRecorder> _clientReportRecorder; // 0x48
        public System.Lazy`1<Sentry.Extensibility.ISentryStackTraceFactory> _sentryStackTraceFactory; // 0x50
        public int _sentryVersion; // 0x58
        public System.Collections.Generic.List`1<System.ValueTuple`2<System.Type,System.Lazy`1<Sentry.Extensibility.ISentryEventExceptionProcessor>>> _exceptionProcessors; // 0x60
        public System.Collections.Generic.List`1<Sentry.Extensibility.ISentryTransactionProcessor> _transactionProcessors; // 0x68
        public System.Collections.Generic.List`1<System.ValueTuple`2<System.Type,System.Lazy`1<Sentry.Extensibility.ISentryEventProcessor>>> _eventProcessors; // 0x70
        public System.Collections.Generic.List`1<System.Func`1<System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.ISentryEventProcessor>>> _eventProcessorsProviders; // 0x78
        public System.Collections.Generic.List`1<System.Func`1<System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.ISentryTransactionProcessor>>> _transactionProcessorsProviders; // 0x80
        public System.Collections.Generic.List`1<System.Func`1<System.Collections.Generic.IEnumerable`1<Sentry.Extensibility.ISentryEventExceptionProcessor>>> _exceptionProcessorsProviders; // 0x88
        public 0x66592844 _defaultIntegrations; // 0x90
        public System.Collections.Generic.List`1<Sentry.Extensibility.IExceptionFilter> _exceptionFilters; // 0x98
        public System.Collections.Generic.ICollection`1<Sentry.SubstringOrRegexPattern> _tagFilters; // 0xA0
        public Sentry.Extensibility.IBackgroundWorker _backgroundWorker; // 0xA8
        public Sentry.Http.ISentryHttpClientFactory _sentryHttpClientFactory; // 0xB0
        public Sentry.ISentryScopeStateProcessor _sentryScopeStateProcessor; // 0xB8
        public System.Collections.Generic.List`1<Sentry.Internal.StringOrRegex> _inAppExclude; // 0xC0
        public System.Collections.Generic.List`1<Sentry.Internal.StringOrRegex> _inAppInclude; // 0xC8
        public bool _sendDefaultPii; // 0xD0
        public bool _isEnvironmentUser; // 0xD1
        public string _serverName; // 0xD8
        public bool _attachStacktrace; // 0xE0
        public int _maxBreadcrumbs; // 0xE4
        public System.Nullable`1<float> _sampleRate; // 0xE8
        public string _release; // 0xF0
        public string _distribution; // 0xF8
        public string _environment; // 0x100
        public string _dsn; // 0x108
        public Sentry.Dsn _parsedDsn; // 0x110
        public System.Lazy`1<string> _sentryBaseUrl; // 0x118
        public System.Func`3<Sentry.SentryEvent,Sentry.SentryHint,Sentry.SentryEvent> _beforeSend; // 0x120
        public System.Func`3<Sentry.SentryTransaction,Sentry.SentryHint,Sentry.SentryTransaction> _beforeSendTransaction; // 0x128
        public System.Func`3<Sentry.Breadcrumb,Sentry.SentryHint,Sentry.Breadcrumb> _beforeBreadcrumb; // 0x130
        public int _maxQueueItems; // 0x138
        public int _maxCacheItems; // 0x13C
        public System.TimeSpan _shutdownTimeout; // 0x140
        public System.TimeSpan _flushTimeout; // 0x148
        public 0x6653598C _decompressionMethods; // 0x150
        public 0x665326AC _requestBodyCompressionLevel; // 0x154
        public bool _requestBodyCompressionBuffered; // 0x158
        public bool _sendClientReports; // 0x159
        public System.Net.IWebProxy _httpProxy; // 0x160
        public System.Func`1<System.Net.Http.HttpMessageHandler> _createHttpMessageHandler; // 0x168
        public System.Action`1<System.Net.Http.HttpClient> _configureClient; // 0x170
        public bool _debug; // 0x178
        public 0x6659252C _diagnosticLevel; // 0x17A
        public Sentry.Extensibility.IDiagnosticLogger _diagnosticLogger; // 0x180
        public 0x66591A2C _reportAssembliesMode; // 0x188
        public : _deduplicateMode; // 0x18C
        public string _cacheDirectoryPath; // 0x190
        public bool _captureFailedRequests; // 0x198
        public System.Collections.Generic.IList`1<Sentry.HttpStatusCodeRange> _failedRequestStatusCodes; // 0x1A0
        public System.Lazy`1<System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern>> _failedRequestTargets; // 0x1A8
        public Sentry.Internal.IFileSystem _fileSystem; // 0x1B0
        public bool _disableFileWrite; // 0x1B8
        public System.TimeSpan _initCacheFlushTimeout; // 0x1C0
        public System.Nullable`1<bool> _enableTracing; // 0x1C8
        public System.Nullable`1<double> _tracesSampleRate; // 0x1D0
        public System.Nullable`1<double> _profilesSampleRate; // 0x1E0
        public System.Func`2<Sentry.TransactionSamplingContext,System.Nullable`1<double>> _tracesSampler; // 0x1F0
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> _tracePropagationTargets; // 0x1F8
        public Sentry.Internal.ITransactionProfilerFactory _transactionProfilerFactory; // 0x200
        public System.Nullable`1<0x6659391C> _stackTraceMode; // 0x208
        public System.Collections.Generic.List`1<Sentry.Integrations.ISdkIntegration> _integrations; // 0x210
        public long _maxAttachmentSize; // 0x218
        public 0x66593974 _detectStartupTime; // 0x220
        public System.TimeSpan _autoSessionTrackingInterval; // 0x228
        public bool _autoSessionTracking; // 0x230
        public bool _useAsyncFileIO; // 0x231
        public System.Func`1<bool> _crashedLastRun; // 0x238
        public 0x66590E24 _instrumenter; // 0x240
        public Sentry.Extensibility.INetworkStatusListener _networkStatusListener; // 0x248
        public System.Func`2<string,System.Reflection.PortableExecutable.PEReader> _assemblyReader; // 0x250
        public Sentry.ExperimentalMetricsOptions _experimentalMetrics; // 0x258
        public string _spotlightUrl; // 0x260
        public bool _enableSpotlight; // 0x268
        public Sentry.Internal.SettingLocator _settingLocator; // 0x270
        public bool _initNativeSdks; // 0x278
        public System.Collections.Generic.List`1<System.Action`1<Sentry.IHub>> _postInitCallbacks; // 0x280

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFE810FE7C0
        public void set_ScopeStackContainer(){} // RVA: 0x7FFE81161E80
        public void get_InstallationId(){} // RVA: 0x7FFE86EE6CF0
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFE86EE6D40
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFE86EE6E70
        public void get_ScopeObserver(){} // RVA: 0x7FFE8144E200
        public void set_ScopeObserver(){} // RVA: 0x7FFE81129890
        public void get_EnableScopeSync(){} // RVA: 0x7FFE812CF770
        public void set_EnableScopeSync(){} // RVA: 0x7FFE812D0010
        public void get_Transport(){} // RVA: 0x7FFE81178740
        public void set_Transport(){} // RVA: 0x7FFE81123200
        public void get_ClientReportRecorder(){} // RVA: 0x7FFE86EE6EC0
        public void set_ClientReportRecorder(){} // RVA: 0x7FFE86EE6F10
        public void get_SentryStackTraceFactory(){} // RVA: 0x7FFE86EE70F0
        public void set_SentryStackTraceFactory(){} // RVA: 0x7FFE86EE7140
        public void get_SentryVersion(){} // RVA: 0x7FFE8175AC90
        public void get_ExceptionProcessors(){} // RVA: 0x7FFE81199370
        public void set_ExceptionProcessors(){} // RVA: 0x7FFE81199380
        public void get_TransactionProcessors(){} // RVA: 0x7FFE81176D50
        public void set_TransactionProcessors(){} // RVA: 0x7FFE81176D60
        public void get_EventProcessors(){} // RVA: 0x7FFE811C3590
        public void set_EventProcessors(){} // RVA: 0x7FFE811C35A0
        public void get_EventProcessorsProviders(){} // RVA: 0x7FFE81463AE0
        public void set_EventProcessorsProviders(){} // RVA: 0x7FFE81464570
        public void get_TransactionProcessorsProviders(){} // RVA: 0x7FFE81280C30
        public void set_TransactionProcessorsProviders(){} // RVA: 0x7FFE81282380
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x7FFE8113A010
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x7FFE81280F90
        public void get_Integrations(){} // RVA: 0x7FFE86EE7320
        public void get_ExceptionFilters(){} // RVA: 0x7FFE817AE360
        public void set_ExceptionFilters(){} // RVA: 0x7FFE8171B470
        public void get_TagFilters(){} // RVA: 0x7FFE8179C860
        public void set_TagFilters(){} // RVA: 0x7FFE8171B4D0
        public void get_BackgroundWorker(){} // RVA: 0x7FFE817AB5E0
        public void set_BackgroundWorker(){} // RVA: 0x7FFE81857260
        public void get_SentryHttpClientFactory(){} // RVA: 0x7FFE81166040
        public void set_SentryHttpClientFactory(){} // RVA: 0x7FFE81166050
        public void GetHttpClient(){} // RVA: 0x7FFE86EE73D0
        public void get_SentryScopeStateProcessor(){} // RVA: 0x7FFE811660B0
        public void set_SentryScopeStateProcessor(){} // RVA: 0x7FFE811660C0
        public void get_InAppExclude(){} // RVA: 0x7FFE81166120
        public void set_InAppExclude(){} // RVA: 0x7FFE81166130
        public void get_InAppInclude(){} // RVA: 0x7FFE81253460
        public void set_InAppInclude(){} // RVA: 0x7FFE81253470
        public void get_SendDefaultPii(){} // RVA: 0x7FFE81644E40
        public void set_SendDefaultPii(){} // RVA: 0x7FFE82619150
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFE86EE74B0
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFE86EE74C0
        public void get_ServerName(){} // RVA: 0x7FFE8181EA80
        public void set_ServerName(){} // RVA: 0x7FFE8117C8A0
        public void get_AttachStacktrace(){} // RVA: 0x7FFE81226F80
        public void set_AttachStacktrace(){} // RVA: 0x7FFE81226F90
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFE82A3E370
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFE84A61AC0
        public void get_SampleRate(){} // RVA: 0x7FFE8117C970
        public void set_SampleRate(){} // RVA: 0x7FFE86EE74D0
        public void get_Release(){} // RVA: 0x7FFE811662A0
        public void set_Release(){} // RVA: 0x7FFE811662B0
        public void get_Distribution(){} // RVA: 0x7FFE8158D5D0
        public void set_Distribution(){} // RVA: 0x7FFE81B0E4B0
        public void get_Environment(){} // RVA: 0x7FFE81828B50
        public void set_Environment(){} // RVA: 0x7FFE81A58AB0
        public void get_Dsn(){} // RVA: 0x7FFE8181E3D0
        public void set_Dsn(){} // RVA: 0x7FFE86EE75C0
        public void get_ParsedDsn(){} // RVA: 0x7FFE86EE7690
        public void IsSentryRequest(){} // RVA: 0x7FFE86EE78E0 | overloaded x2
        public void get_BeforeSendInternal(){} // RVA: 0x7FFE813A1DA0
        public void SetBeforeSend(){} // RVA: 0x7FFE86EE7A50 | overloaded x2
        public void get_BeforeSendTransactionInternal(){} // RVA: 0x7FFE8182B890
        public void SetBeforeSendTransaction(){} // RVA: 0x7FFE86EE7BD0 | overloaded x2
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x7FFE81823850
        public void SetBeforeBreadcrumb(){} // RVA: 0x7FFE86EE7D50 | overloaded x2
        public void get_MaxQueueItems(){} // RVA: 0x7FFE81F60BB0
        public void set_MaxQueueItems(){} // RVA: 0x7FFE86EE7ED0
        public void get_MaxCacheItems(){} // RVA: 0x7FFE86C70920
        public void set_MaxCacheItems(){} // RVA: 0x7FFE86EE7F90
        public void get_ShutdownTimeout(){} // RVA: 0x7FFE811665F0
        public void set_ShutdownTimeout(){} // RVA: 0x7FFE86EE8050
        public void get_FlushTimeout(){} // RVA: 0x7FFE81166660
        public void set_FlushTimeout(){} // RVA: 0x7FFE86DDD610
        public void get_DecompressionMethods(){} // RVA: 0x7FFE81F837C0
        public void set_DecompressionMethods(){} // RVA: 0x7FFE81F7F070
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFE86EE8060
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFE86EE8070
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFE86EE8080
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFE86EE8090
        public void get_SendClientReports(){} // RVA: 0x7FFE81FEC6F0
        public void set_SendClientReports(){} // RVA: 0x7FFE81FE9EB0
        public void get_HttpProxy(){} // RVA: 0x7FFE81624E50
        public void set_HttpProxy(){} // RVA: 0x7FFE81625620
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7FFE81B2CB70
        public void set_CreateHttpMessageHandler(){} // RVA: 0x7FFE81B23F80
        public void get_ConfigureClient(){} // RVA: 0x7FFE815BB6A0
        public void set_ConfigureClient(){} // RVA: 0x7FFE81B38790
        public void get_Debug(){} // RVA: 0x7FFE86EE80A0
        public void set_Debug(){} // RVA: 0x7FFE86EE80B0
        public void get_DiagnosticLevel(){} // RVA: 0x7FFE86EE80C0
        public void set_DiagnosticLevel(){} // RVA: 0x7FFE86EE80D0
        public void get_DiagnosticLogger(){} // RVA: 0x7FFE86EE80E0
        public void set_DiagnosticLogger(){} // RVA: 0x7FFE86EE8100
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFE816216D0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFE86EE8240
        public void get_DeduplicateMode(){} // RVA: 0x7FFE86DBDB50
        public void set_DeduplicateMode(){} // RVA: 0x7FFE86EE8250
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFE81825EC0
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFE81B2A360
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFE86EE8260
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFE86EE8270
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFE81B32390
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFE81B21CA0
        public void get_FailedRequestTargets(){} // RVA: 0x7FFE86EE8280
        public void set_FailedRequestTargets(){} // RVA: 0x7FFE86EE82D0
        public void get_FileSystem(){} // RVA: 0x7FFE86EE8400
        public void set_FileSystem(){} // RVA: 0x7FFE81B2ACE0
        public void get_DisableFileWrite(){} // RVA: 0x7FFE86EE84C0
        public void set_DisableFileWrite(){} // RVA: 0x7FFE86EE84D0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFE817EFE00
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFE86EE84E0
        public void get_DefaultTags(){} // RVA: 0x7FFE86EE84F0
        public void set_DefaultTags(){} // RVA: 0x7FFE810FCE30
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x7FFE86EE85B0
        public void get_IsProfilingEnabled(){} // RVA: 0x7FFE86EE86B0
        public void get_EnableTracing(){} // RVA: 0x7FFE86EE87F0
        public void set_EnableTracing(){} // RVA: 0x7FFE86EE8800
        public void get_TracesSampleRate(){} // RVA: 0x7FFE86EE8810
        public void set_TracesSampleRate(){} // RVA: 0x7FFE86EE8820
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFE86EE8930
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFE86EE8940
        public void get_TracesSampler(){} // RVA: 0x7FFE81B21230
        public void set_TracesSampler(){} // RVA: 0x7FFE81B374B0
        public void get_TracePropagationTargets(){} // RVA: 0x7FFE81B20B40
        public void set_TracePropagationTargets(){} // RVA: 0x7FFE86EE8A50
        public void get_TransactionProfilerFactory(){} // RVA: 0x7FFE81B14500
        public void set_TransactionProfilerFactory(){} // RVA: 0x7FFE81B317A0
        public void get_StackTraceMode(){} // RVA: 0x7FFE86EE8AF0
        public void set_StackTraceMode(){} // RVA: 0x7FFE86EE8CF0
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFE81B296E0
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFE86EE8D50
        public void get_DetectStartupTime(){} // RVA: 0x7FFE86EE8D60
        public void set_DetectStartupTime(){} // RVA: 0x7FFE86EE8D70
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFE81B0D790
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFE86EE8D80
        public void get_AutoSessionTracking(){} // RVA: 0x7FFE86D9E8C0
        public void set_AutoSessionTracking(){} // RVA: 0x7FFE86D9E8D0
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFE86D9E8E0
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFE86D9E8F0
        public void get_CrashedLastRun(){} // RVA: 0x7FFE81B20B50
        public void set_CrashedLastRun(){} // RVA: 0x7FFE81B2F9F0
        public void get_Instrumenter(){} // RVA: 0x7FFE86EE8D90
        public void set_Instrumenter(){} // RVA: 0x7FFE86EE8DA0
        public void AddJsonConverter(){} // RVA: 0x7FFE86EE8DB0
        public void AddJsonSerializerContext(){} // RVA: 0x7FFE80E460A0
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFE86EE8E50
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFE86EE8EF0
        public void get_NetworkStatusListener(){} // RVA: 0x7FFE81B0DEC0
        public void set_NetworkStatusListener(){} // RVA: 0x7FFE81B27CF0
        public void get_AssemblyReader(){} // RVA: 0x7FFE81B12420
        public void set_AssemblyReader(){} // RVA: 0x7FFE81B34B40
        public void get_ExperimentalMetrics(){} // RVA: 0x7FFE81B20B30
        public void set_ExperimentalMetrics(){} // RVA: 0x7FFE815ADA20
        public void get_SpotlightUrl(){} // RVA: 0x7FFE81B2BBE0
        public void set_SpotlightUrl(){} // RVA: 0x7FFE81B26CB0
        public void get_EnableSpotlight(){} // RVA: 0x7FFE86EE8F90
        public void set_EnableSpotlight(){} // RVA: 0x7FFE86EE8FA0
        public void get_SettingLocator(){} // RVA: 0x7FFE81B2F980
        public void set_SettingLocator(){} // RVA: 0x7FFE81B0B080
        public void get_InitNativeSdks(){} // RVA: 0x7FFE86EE8FB0
        public void set_InitNativeSdks(){} // RVA: 0x7FFE86EE8FC0
        public void get_PostInitCallbacks(){} // RVA: 0x7FFE81B23FE0
        public void set_PostInitCallbacks(){} // RVA: 0x7FFE81B17450
        public void .ctor(){} // RVA: 0x7FFE86EE8FD0
        public void AddIntegration(){} // RVA: 0x7FFE86EEB0F0
        public void RemoveIntegration(){} // RVA: 0x7FFE80E45FE0
        public void AddExceptionFilter(){} // RVA: 0x7FFE86EEB190
        public void RemoveExceptionFilter(){} // RVA: 0x7FFE80E45FE0
        public void AddExceptionFilterForType(){} // RVA: 0x7FFE80E45FE0
        public void AddInAppExclude(){} // RVA: 0x7FFE86EEB460 | overloaded x2
        public void AddInAppExcludeRegex(){} // RVA: 0x7FFE86EEB610
        public void AddInAppInclude(){} // RVA: 0x7FFE86EEB9C0 | overloaded x2
        public void AddInAppIncludeRegex(){} // RVA: 0x7FFE86EEBB70
        public void AddExceptionProcessor(){} // RVA: 0x7FFE86EEBD70
        public void AddExceptionProcessors(){} // RVA: 0x7FFE86EEBF60
        public void AddEventProcessor(){} // RVA: 0x7FFE86EEC130
        public void AddEventProcessors(){} // RVA: 0x7FFE86EEC320
        public void RemoveEventProcessor(){} // RVA: 0x7FFE80E45FE0
        public void AddEventProcessorProvider(){} // RVA: 0x7FFE86EEC4F0
        public void AddTransactionProcessor(){} // RVA: 0x7FFE86EEC550
        public void AddTransactionProcessors(){} // RVA: 0x7FFE86EEC660
        public void RemoveTransactionProcessor(){} // RVA: 0x7FFE80E45FE0
        public void AddTransactionProcessorProvider(){} // RVA: 0x7FFE86EEC7D0
        public void AddExceptionProcessorProvider(){} // RVA: 0x7FFE86EEC9C0
        public void GetAllEventProcessors(){} // RVA: 0x7FFE86EECA20
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFE86EECB90
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFE86EECD00
        public void UseStackTraceFactory(){} // RVA: 0x7FFE86EECE70
        public void ApplyDefaultTags(){} // RVA: 0x7FFE86EED0A0
        public void DisableDuplicateEventDetection(){} // RVA: 0x7FFE86EED4A0
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x7FFE86EED4E0
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x7FFE86EED4F0
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x7FFE86EED500
        public void HasIntegration(){} // RVA: 0x7FFE80E2F150
        public void RemoveDefaultIntegration(){} // RVA: 0x7FFE86EED510
        public void SetupLogging(){} // RVA: 0x7FFE86EED520
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x7FFE86EED750
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x7FFE86EED9B0
        public void <.ctor>b__346_0(){} // RVA: 0x7FFE86EED9C0
        public void <.ctor>b__346_5(){} // RVA: 0x7FFE86EEDAF0
        public void <.ctor>b__346_1(){} // RVA: 0x7FFE86EEDB40
        public void <.ctor>b__346_2(){} // RVA: 0x7FFE86EEDBA0
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x7FFE86EE70F0
        public void <.ctor>b__346_6(){} // RVA: 0x7FFE86EEDC30
        public void <.ctor>b__346_7(){} // RVA: 0x7FFE86EEDD80
        public void <.ctor>b__346_8(){} // RVA: 0x7FFE86EEDF80
        public void <.ctor>b__346_10(){} // RVA: 0x7FFE86EEE0F0
        public void <.ctor>b__346_11(){} // RVA: 0x7FFE86EEE230
        public void <.ctor>b__346_4(){} // RVA: 0x7FFE86EEE3A0
    }

    public class SentryPackage : Object
    {
        public string _name; // 0x10
        public string _version; // 0x18

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE81116380
        public void get_Version(){} // RVA: 0x7FFE810FE7C0
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void WriteTo(){} // RVA: 0x7FFE86EEF0D0
        public void FromJson(){} // RVA: 0x7FFE86EEF1E0
        public void GetHashCode(){} // RVA: 0x7FFE86EEF430
        public void Equals(){} // RVA: 0x7FFE86EEF4A0
    }

    public class SentryPropagationContext : Object
    {
        public Sentry.SentryId _traceId; // 0x10
        public Sentry.SpanId _spanId; // 0x20
        public System.Nullable`1<Sentry.SpanId> _parentSpanId; // 0x28

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFE826F6B90
        public void get_SpanId(){} // RVA: 0x7FFE811290C0
        public void get_ParentSpanId(){} // RVA: 0x7FFE81E90600
        public void GetOrCreateDynamicSamplingContext(){} // RVA: 0x7FFE86EEF5C0
        public void .ctor(){} // RVA: 0x7FFE86EEF9C0 | overloaded x3
        public void CreateFromHeaders(){} // RVA: 0x7FFE86EEFB20
    }

    public class SentryRequest : Object
    {
        public System.Collections.Generic.Dictionary`2<string,string> _internalEnv; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> _internalOther; // 0x18
        public System.Collections.Generic.Dictionary`2<string,string> _internalHeaders; // 0x20
        public string _url; // 0x28
        public string _method; // 0x30
        public string _apiTarget; // 0x38
        public object _data; // 0x40
        public string _queryString; // 0x48
        public string _cookies; // 0x50
        public object field_9; // 0x149
        public object field_10; // 0x14A
        public object field_11; // 0x14B

        // ── Methods ──
        public void get_InternalEnv(){} // RVA: 0x7FFE81116380
        public void set_InternalEnv(){} // RVA: 0x7FFE810FCE30
        public void get_InternalOther(){} // RVA: 0x7FFE810FE7C0
        public void set_InternalOther(){} // RVA: 0x7FFE81161E80
        public void get_InternalHeaders(){} // RVA: 0x7FFE811290C0
        public void set_InternalHeaders(){} // RVA: 0x7FFE811290D0
        public void get_Url(){} // RVA: 0x7FFE81129130
        public void set_Url(){} // RVA: 0x7FFE810FCE90
        public void get_Method(){} // RVA: 0x7FFE8144E200
        public void set_Method(){} // RVA: 0x7FFE81129890
        public void get_ApiTarget(){} // RVA: 0x7FFE8143BA80
        public void set_ApiTarget(){} // RVA: 0x7FFE81437330
        public void get_Data(){} // RVA: 0x7FFE81178740
        public void set_Data(){} // RVA: 0x7FFE81123200
        public void get_QueryString(){} // RVA: 0x7FFE81176730
        public void set_QueryString(){} // RVA: 0x7FFE81176740
        public void get_Cookies(){} // RVA: 0x7FFE8119C0E0
        public void set_Cookies(){} // RVA: 0x7FFE812534D0
        public void get_Headers(){} // RVA: 0x7FFE86EEFD30
        public void get_Env(){} // RVA: 0x7FFE86EEFDF0
        public void get_Other(){} // RVA: 0x7FFE86EEFEB0
        public void AddHeaders(){} // RVA: 0x7FFE86EEFF70
        public void Clone(){} // RVA: 0x7FFE86EF0260
        public void CopyTo(){} // RVA: 0x7FFE86EF02C0
        public void WriteTo(){} // RVA: 0x7FFE86EF0560
        public void FromJson(){} // RVA: 0x7FFE86EF07E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SentrySdk : Object
    {
        public Sentry.IHub CurrentHub;
        public object field_1; // 0x155
        public object field_2; // 0x156
        public object field_3; // 0x157

        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x7FFE86EF10F0
        public void get_LastEventId(){} // RVA: 0x7FFE86EF1150
        public void InitHub(){} // RVA: 0x7FFE86EF11F0
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x7FFE86EF17D0
        public void Init(){} // RVA: 0x7FFE86EF1CA0 | overloaded x4
        public void UseHub(){} // RVA: 0x7FFE86EF1E40
        public void Flush(){} // RVA: 0x7FFE86EF2080 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFE86EF2140 | overloaded x2
        public void Close(){} // RVA: 0x7FFE86EF21D0
        public void get_IsEnabled(){} // RVA: 0x7FFE86EF2360
        public void PushScope(){} // RVA: 0x7FFE86EF23E0 | overloaded x2
        public void BindClient(){} // RVA: 0x7FFE86EF2460
        public void AddBreadcrumb(){} // RVA: 0x7FFE86EF2640 | overloaded x3
        public void ConfigureScope(){} // RVA: 0x7FFE86EF26B0
        public void ConfigureScopeAsync(){} // RVA: 0x7FFE86EF2730
        public void CaptureEnvelope(){} // RVA: 0x7FFE86EF27B0
        public void CaptureEvent(){} // RVA: 0x7FFE86EF29D0 | overloaded x3
        public void CaptureException(){} // RVA: 0x7FFE86EF2B10 | overloaded x2
        public void CaptureMessage(){} // RVA: 0x7FFE86EF2CF0 | overloaded x2
        public void CaptureUserFeedback(){} // RVA: 0x7FFE86EF2F60 | overloaded x2
        public void CaptureTransaction(){} // RVA: 0x7FFE86EF30E0 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFE86EF3180
        public void CaptureCheckIn(){} // RVA: 0x7FFE86EF3200
        public void StartTransaction(){} // RVA: 0x7FFE86EF36A0 | overloaded x6
        public void BindException(){} // RVA: 0x7FFE86EF3730
        public void GetSpan(){} // RVA: 0x7FFE86EF37C0
        public void GetTraceHeader(){} // RVA: 0x7FFE86EF3840
        public void GetBaggage(){} // RVA: 0x7FFE86EF38C0
        public void ContinueTrace(){} // RVA: 0x7FFE86EF3A80 | overloaded x2
        public void get_Metrics(){} // RVA: 0x7FFE86EF3BC0
        public void StartSession(){} // RVA: 0x7FFE86EF3C40
        public void EndSession(){} // RVA: 0x7FFE86EF3CC0
        public void PauseSession(){} // RVA: 0x7FFE86EF3D50
        public void ResumeSession(){} // RVA: 0x7FFE86EF3DD0
        public void CauseCrash(){} // RVA: 0x7FFE86EF3E50
        public void .cctor(){} // RVA: 0x7FFE86EF4480
    }

    public class SentrySession : Object
    {
        public Sentry.SentryId _id; // 0x10
        public string _distinctId; // 0x20
        public System.DateTimeOffset _startTimestamp; // 0x28
        public string _release; // 0x38
        public string _environment; // 0x40
        public string _ipAddress; // 0x48
        public string _userAgent; // 0x50
        public int _errorCount; // 0x58

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE826F6B90
        public void get_DistinctId(){} // RVA: 0x7FFE811290C0
        public void get_StartTimestamp(){} // RVA: 0x7FFE81E90600
        public void get_Release(){} // RVA: 0x7FFE8143BA80
        public void get_Environment(){} // RVA: 0x7FFE81178740
        public void get_IpAddress(){} // RVA: 0x7FFE81176730
        public void get_UserAgent(){} // RVA: 0x7FFE8119C0E0
        public void get_ErrorCount(){} // RVA: 0x7FFE8175AC90
        public void .ctor(){} // RVA: 0x7FFE86EF4930 | overloaded x2
        public void ReportError(){} // RVA: 0x7FFE86EF4AD0
        public void CreateUpdate(){} // RVA: 0x7FFE86EF4AE0
    }

    public class SentrySpan : Object
    {
        public Sentry.SpanId _spanId; // 0x10
        public System.Nullable`1<Sentry.SpanId> _parentSpanId; // 0x18
        public Sentry.SentryId _traceId; // 0x28
        public System.DateTimeOffset _startTimestamp; // 0x38
        public System.Nullable`1<System.DateTimeOffset> _endTimestamp; // 0x48
        public System.Collections.Generic.Dictionary`2<string,Sentry.Protocol.Measurement> _measurements; // 0x60
        public string _operation; // 0x68
        public string _description; // 0x70
        public System.Nullable`1<0x66593814> _status; // 0x78
        public System.Nullable`1<bool> _isSampled; // 0x80
        public System.Collections.Generic.Dictionary`2<string,string> _tags; // 0x88
        public System.Collections.Generic.Dictionary`2<string,object> _extra; // 0x90
        public Sentry.Protocol.Metrics.MetricsSummary _metricsSummary; // 0x98
        public string _origin; // 0xA0

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFE81116380
        public void set_SpanId(){} // RVA: 0x7FFE826F2ED0
        public void get_ParentSpanId(){} // RVA: 0x7FFE81703940
        public void set_ParentSpanId(){} // RVA: 0x7FFE817036E0
        public void get_TraceId(){} // RVA: 0x7FFE81E90600
        public void set_TraceId(){} // RVA: 0x7FFE81E8E800
        public void get_StartTimestamp(){} // RVA: 0x7FFE826F9FB0
        public void set_StartTimestamp(){} // RVA: 0x7FFE82D001B0
        public void get_EndTimestamp(){} // RVA: 0x7FFE86EF4B90
        public void set_EndTimestamp(){} // RVA: 0x7FFE86EF4BB0
        public void get_IsFinished(){} // RVA: 0x7FFE86EF4BD0
        public void get_Measurements(){} // RVA: 0x7FFE86EF4C10
        public void SetMeasurement(){} // RVA: 0x7FFE86EF4CD0
        public void get_Operation(){} // RVA: 0x7FFE81176D50
        public void set_Operation(){} // RVA: 0x7FFE81176D60
        public void get_Description(){} // RVA: 0x7FFE811C3590
        public void set_Description(){} // RVA: 0x7FFE811C35A0
        public void get_Status(){} // RVA: 0x7FFE81463AE0
        public void set_Status(){} // RVA: 0x7FFE865EFE40
        public void get_IsSampled(){} // RVA: 0x7FFE86AD9CE0
        public void set_IsSampled(){} // RVA: 0x7FFE86B57090
        public void get_Tags(){} // RVA: 0x7FFE86EF4DF0
        public void SetTag(){} // RVA: 0x7FFE86EF4EC0
        public void UnsetTag(){} // RVA: 0x7FFE86EF4FF0
        public void get_Extra(){} // RVA: 0x7FFE86EF50F0
        public void SetExtra(){} // RVA: 0x7FFE86EF51C0
        public void .ctor(){} // RVA: 0x7FFE86EF54B0 | overloaded x2
        public void GetTraceHeader(){} // RVA: 0x7FFE86EF5B20
        public void WriteTo(){} // RVA: 0x7FFE86EF5B90
        public void FromJson(){} // RVA: 0x7FFE86EF6090
        public void Redact(){} // RVA: 0x7FFE86EF7250
        public void get_Origin(){} // RVA: 0x7FFE8179C860
        public void set_Origin(){} // RVA: 0x7FFE86EF7300
    }

    public class SentryStackFrame : Object
    {
        public System.Lazy`1<Sentry.Internal.PrefixOrPatternMatcher> LazyModuleMatcher;
        public System.Lazy`1<Sentry.Internal.DelimitedPrefixOrPatternMatcher> LazyFunctionMatcher; // 0x8
        public System.Collections.Generic.List`1<string> _internalPreContext; // 0x10
        public System.Collections.Generic.List`1<string> _internalPostContext; // 0x18
        public System.Collections.Generic.Dictionary`2<string,string> _internalVars; // 0x20
        public System.Collections.Generic.List`1<int> _internalFramesOmitted; // 0x28
        public bool _isCodeLocation; // 0x30
        public string _fileName; // 0x38
        public string _function; // 0x40
        public string _module; // 0x48
        public System.Nullable`1<int> _lineNumber; // 0x50
        public System.Nullable`1<int> _columnNumber; // 0x58
        public string _absolutePath; // 0x60
        public string _contextLine; // 0x68
        public System.Nullable`1<bool> _inApp; // 0x70
        public string _package; // 0x78
        public string _platform; // 0x80
        public System.Nullable`1<long> _imageAddress; // 0x88
        public System.Nullable`1<long> _symbolAddress; // 0x98
        public System.Nullable`1<long> _instructionAddress; // 0xA8
        public string _addressMode; // 0xB8
        public System.Nullable`1<long> _functionId; // 0xC0
        public object field_22; // 0x16F
        public object field_23; // 0x170

        // ── Methods ──
        public void get_InternalPreContext(){} // RVA: 0x7FFE81116380
        public void set_InternalPreContext(){} // RVA: 0x7FFE810FCE30
        public void get_InternalPostContext(){} // RVA: 0x7FFE810FE7C0
        public void set_InternalPostContext(){} // RVA: 0x7FFE81161E80
        public void get_InternalVars(){} // RVA: 0x7FFE811290C0
        public void set_InternalVars(){} // RVA: 0x7FFE811290D0
        public void get_InternalFramesOmitted(){} // RVA: 0x7FFE81129130
        public void set_InternalFramesOmitted(){} // RVA: 0x7FFE810FCE90
        public void get_IsCodeLocation(){} // RVA: 0x7FFE81121450
        public void set_IsCodeLocation(){} // RVA: 0x7FFE81121460
        public void get_FileName(){} // RVA: 0x7FFE8143BA80
        public void set_FileName(){} // RVA: 0x7FFE81437330
        public void get_Function(){} // RVA: 0x7FFE81178740
        public void set_Function(){} // RVA: 0x7FFE81123200
        public void get_Module(){} // RVA: 0x7FFE81176730
        public void set_Module(){} // RVA: 0x7FFE81176740
        public void get_LineNumber(){} // RVA: 0x7FFE8119C0E0
        public void set_LineNumber(){} // RVA: 0x7FFE82506C00
        public void get_ColumnNumber(){} // RVA: 0x7FFE811C3500
        public void set_ColumnNumber(){} // RVA: 0x7FFE825093B0
        public void get_AbsolutePath(){} // RVA: 0x7FFE81199370
        public void set_AbsolutePath(){} // RVA: 0x7FFE81199380
        public void get_ContextLine(){} // RVA: 0x7FFE81176D50
        public void set_ContextLine(){} // RVA: 0x7FFE81176D60
        public void get_PreContext(){} // RVA: 0x7FFE86EF7400
        public void get_PostContext(){} // RVA: 0x7FFE86EF74C0
        public void get_InApp(){} // RVA: 0x7FFE86EF7580
        public void set_InApp(){} // RVA: 0x7FFE86EF7590
        public void get_Vars(){} // RVA: 0x7FFE86EF75A0
        public void get_FramesOmitted(){} // RVA: 0x7FFE86EF7660
        public void get_Package(){} // RVA: 0x7FFE81463AE0
        public void set_Package(){} // RVA: 0x7FFE81464570
        public void get_Platform(){} // RVA: 0x7FFE81280C30
        public void set_Platform(){} // RVA: 0x7FFE81282380
        public void get_ImageAddress(){} // RVA: 0x7FFE8621CDA0
        public void set_ImageAddress(){} // RVA: 0x7FFE8621CDB0
        public void get_SymbolAddress(){} // RVA: 0x7FFE82DC88E0
        public void set_SymbolAddress(){} // RVA: 0x7FFE82DC88F0
        public void get_InstructionAddress(){} // RVA: 0x7FFE86EF7720
        public void set_InstructionAddress(){} // RVA: 0x7FFE86EF7730
        public void get_AddressMode(){} // RVA: 0x7FFE811660B0
        public void set_AddressMode(){} // RVA: 0x7FFE811660C0
        public void get_FunctionId(){} // RVA: 0x7FFE86EF7740
        public void set_FunctionId(){} // RVA: 0x7FFE86EF7750
        public void WriteTo(){} // RVA: 0x7FFE86EF7760
        public void ConfigureAppFrame(){} // RVA: 0x7FFE86EF83B0 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFE86EF8460
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86EFA040
    }

    public class SentryStackTrace : Object
    {
        public System.Collections.Generic.IList`1<Sentry.SentryStackFrame> _internalFrames; // 0x10
        public System.Nullable`1<0x6659323C> _addressAdjustment; // 0x18
        public object field_2; // 0x4B70

        // ── Methods ──
        public void get_InternalFrames(){} // RVA: 0x7FFE81116380
        public void set_InternalFrames(){} // RVA: 0x7FFE810FCE30
        public void get_Frames(){} // RVA: 0x7FFE86EFA4B0
        public void set_Frames(){} // RVA: 0x7FFE810FCE30
        public void get_AddressAdjustment(){} // RVA: 0x7FFE810FE7C0
        public void set_AddressAdjustment(){} // RVA: 0x7FFE819EA910
        public void WriteTo(){} // RVA: 0x7FFE86EFA570
        public void FromJson(){} // RVA: 0x7FFE86EFA720
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SentryThread : Object
    {
        public System.Nullable`1<int> _id; // 0x10
        public string _name; // 0x18
        public System.Nullable`1<bool> _crashed; // 0x20
        public System.Nullable`1<bool> _current; // 0x22
        public Sentry.SentryStackTrace _stacktrace; // 0x28

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE81116380
        public void set_Id(){} // RVA: 0x7FFE826F2ED0
        public void get_Name(){} // RVA: 0x7FFE810FE7C0
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void get_Crashed(){} // RVA: 0x7FFE850EF1D0
        public void set_Crashed(){} // RVA: 0x7FFE86601D50
        public void get_Current(){} // RVA: 0x7FFE86601D60
        public void set_Current(){} // RVA: 0x7FFE86601D70
        public void get_Stacktrace(){} // RVA: 0x7FFE81129130
        public void set_Stacktrace(){} // RVA: 0x7FFE810FCE90
        public void WriteTo(){} // RVA: 0x7FFE86EFAC70
        public void FromJson(){} // RVA: 0x7FFE86EFAFC0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SentryTraceHeader : Object
    {
        public string HttpHeaderName;
        public Sentry.SentryTraceHeader Empty;
        public Sentry.SentryId _traceId; // 0x10

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFE826F6B90
        public void get_SpanId(){} // RVA: 0x7FFE811290C0
        public void get_IsSampled(){} // RVA: 0x7FFE850F4D50
        public void .ctor(){} // RVA: 0x7FFE86EFB6B0
        public void ToString(){} // RVA: 0x7FFE86EFB6D0
        public void Parse(){} // RVA: 0x7FFE86EFB8B0
        public void .cctor(){} // RVA: 0x7FFE86EFBC80
    }

    public class SentryTransaction : Object
    {
        public Sentry.SentryId _eventId; // 0x10
        public string _name; // 0x20
        public 0x66593C8C _nameSource; // 0x28
        public System.Nullable`1<bool> _isParentSampled; // 0x2C
        public string _platform; // 0x30
        public string _release; // 0x38
        public string _distribution; // 0x40
        public System.DateTimeOffset _startTimestamp; // 0x48
        public System.Nullable`1<System.DateTimeOffset> _endTimestamp; // 0x58
        public System.Collections.Generic.Dictionary`2<string,Sentry.Protocol.Measurement> _measurements; // 0x70
        public System.Nullable`1<double> _sampleRate; // 0x78
        public System.Nullable`1<0x6659252C> _level; // 0x88
        public Sentry.SentryRequest _request; // 0x90
        public Sentry.SentryContexts _contexts; // 0x98
        public Sentry.SentryUser _user; // 0xA0
        public string _environment; // 0xA8
        public Sentry.SdkVersion _sdk; // 0xB0
        public System.Collections.Generic.IReadOnlyList`1<string> _fingerprint; // 0xB8
        public System.Collections.Generic.List`1<Sentry.Breadcrumb> _breadcrumbs; // 0xC0
        public System.Collections.Generic.Dictionary`2<string,object> _extra; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,string> _tags; // 0xD0
        public Sentry.SentrySpan[] _spans; // 0xD8
        public Sentry.Protocol.Metrics.MetricsSummary _metricsSummary; // 0xE0
        public Sentry.DynamicSamplingContext _dynamicSamplingContext; // 0xE8
        public Sentry.Internal.ITransactionProfiler _transactionProfiler; // 0xF0
        public object field_25; // 0x192
        public object field_26; // 0x193
        public object field_27; // 0x194
        public object field_28; // 0x195
        public object field_29; // 0x196
        public object field_30; // 0x197
        public object field_31; // 0x198
        public object field_32; // 0x199
        public object field_33; // 0x19A

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFE826F6B90
        public void set_EventId(){} // RVA: 0x7FFE826F6BA0
        public void get_SpanId(){} // RVA: 0x7FFE86EFBDB0
        public void set_SpanId(){} // RVA: 0x7FFE86EFBE20
        public void get_Origin(){} // RVA: 0x7FFE86EFBEA0
        public void set_Origin(){} // RVA: 0x7FFE86EFBF10
        public void get_ParentSpanId(){} // RVA: 0x7FFE86EFBFA0
        public void set_ParentSpanId(){} // RVA: 0x7FFE86EFC030
        public void get_TraceId(){} // RVA: 0x7FFE86EFC0B0
        public void set_TraceId(){} // RVA: 0x7FFE86EFC140
        public void get_Name(){} // RVA: 0x7FFE811290C0
        public void set_Name(){} // RVA: 0x7FFE811290D0
        public void get_NameSource(){} // RVA: 0x7FFE81549710
        public void get_IsParentSampled(){} // RVA: 0x7FFE86EFC1C0
        public void set_IsParentSampled(){} // RVA: 0x7FFE86EFC1D0
        public void get_Platform(){} // RVA: 0x7FFE8144E200
        public void set_Platform(){} // RVA: 0x7FFE81129890
        public void get_Release(){} // RVA: 0x7FFE8143BA80
        public void set_Release(){} // RVA: 0x7FFE81437330
        public void get_Distribution(){} // RVA: 0x7FFE81178740
        public void set_Distribution(){} // RVA: 0x7FFE81123200
        public void get_StartTimestamp(){} // RVA: 0x7FFE81C1C440
        public void set_StartTimestamp(){} // RVA: 0x7FFE81C1C640
        public void get_EndTimestamp(){} // RVA: 0x7FFE81104E50
        public void set_EndTimestamp(){} // RVA: 0x7FFE81104E70
        public void get_Measurements(){} // RVA: 0x7FFE86EFC1E0
        public void SetMeasurement(){} // RVA: 0x7FFE86EFC2A0
        public void get_Operation(){} // RVA: 0x7FFE86EFC3C0
        public void set_Operation(){} // RVA: 0x7FFE86EFC430
        public void get_Description(){} // RVA: 0x7FFE86EFC500
        public void set_Description(){} // RVA: 0x7FFE86EFC570
        public void get_Status(){} // RVA: 0x7FFE86EFC640
        public void set_Status(){} // RVA: 0x7FFE86EFC6B0
        public void get_IsSampled(){} // RVA: 0x7FFE86EFC730
        public void set_IsSampled(){} // RVA: 0x7FFE86EFC7A0
        public void get_SampleRate(){} // RVA: 0x7FFE86DDD4A0
        public void set_SampleRate(){} // RVA: 0x7FFE86DDD4B0
        public void get_Level(){} // RVA: 0x7FFE8194AD00
        public void set_Level(){} // RVA: 0x7FFE8194A400
        public void get_Request(){} // RVA: 0x7FFE86EFC8D0
        public void set_Request(){} // RVA: 0x7FFE818CE320
        public void get_Contexts(){} // RVA: 0x7FFE817AE360
        public void set_Contexts(){} // RVA: 0x7FFE86EFC970
        public void get_User(){} // RVA: 0x7FFE86EFC9A0
        public void set_User(){} // RVA: 0x7FFE8171B4D0
        public void get_Environment(){} // RVA: 0x7FFE817AB5E0
        public void set_Environment(){} // RVA: 0x7FFE81857260
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7FFE811290C0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7FFE86EFCA40
        public void get_Sdk(){} // RVA: 0x7FFE81166040
        public void set_Sdk(){} // RVA: 0x7FFE81166050
        public void get_Fingerprint(){} // RVA: 0x7FFE86EFCAF0
        public void set_Fingerprint(){} // RVA: 0x7FFE811660C0
        public void get_Breadcrumbs(){} // RVA: 0x7FFE81166120
        public void get_Extra(){} // RVA: 0x7FFE81253460
        public void get_Tags(){} // RVA: 0x7FFE81218100
        public void get_Spans(){} // RVA: 0x7FFE8181EA80
        public void get_IsFinished(){} // RVA: 0x7FFE86EFCB40
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFE8117C970
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFE8117C980
        public void get_TransactionProfiler(){} // RVA: 0x7FFE811662A0
        public void set_TransactionProfiler(){} // RVA: 0x7FFE811662B0
        public void .ctor(){} // RVA: 0x7FFE86EFD440 | overloaded x4
        public void FromTracerSpans(){} // RVA: 0x7FFE86EFE190
        public void AddBreadcrumb(){} // RVA: 0x7FFE86EFEBA0
        public void SetExtra(){} // RVA: 0x7FFE86EFEC00
        public void SetTag(){} // RVA: 0x7FFE86EFEC90
        public void UnsetTag(){} // RVA: 0x7FFE86EFED20
        public void GetTraceHeader(){} // RVA: 0x7FFE86EFED80
        public void Redact(){} // RVA: 0x7FFE86EFEE70
        public void WriteTo(){} // RVA: 0x7FFE86EFF3A0
        public void FromJson(){} // RVA: 0x7FFE86EFFDA0
    }

    public class SentryUser : Object
    {
        public System.Action`1<Sentry.SentryUser> _propertyChanged; // 0x10
        public string _id; // 0x18
        public string _username; // 0x20
        public string _email; // 0x28
        public string _ipAddress; // 0x30
        public string _segment; // 0x38
        public System.Collections.Generic.IDictionary`2<string,string> _other; // 0x40

        // ── Methods ──
        public void get_PropertyChanged(){} // RVA: 0x7FFE81116380
        public void set_PropertyChanged(){} // RVA: 0x7FFE810FCE30
        public void get_Id(){} // RVA: 0x7FFE810FE7C0
        public void set_Id(){} // RVA: 0x7FFE86F02130
        public void get_Username(){} // RVA: 0x7FFE811290C0
        public void set_Username(){} // RVA: 0x7FFE86F021F0
        public void get_Email(){} // RVA: 0x7FFE81129130
        public void set_Email(){} // RVA: 0x7FFE86F022B0
        public void get_IpAddress(){} // RVA: 0x7FFE8144E200
        public void set_IpAddress(){} // RVA: 0x7FFE86F02370
        public void get_Segment(){} // RVA: 0x7FFE8143BA80
        public void set_Segment(){} // RVA: 0x7FFE86F02430
        public void get_Other(){} // RVA: 0x7FFE86F024F0
        public void set_Other(){} // RVA: 0x7FFE86F025B0
        public void Clone(){} // RVA: 0x7FFE86F02620
        public void CopyTo(){} // RVA: 0x7FFE86F02680
        public void HasAnyData(){} // RVA: 0x7FFE86F02930
        public void WriteTo(){} // RVA: 0x7FFE86F029B0
        public void FromJson(){} // RVA: 0x7FFE86F02BA0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SentryValues`1 : Object
    {
        public System.Collections.Generic.IEnumerable`1<T> _values;

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFE80E2E2E0
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void WriteTo(){} // RVA: 0x7FFE80E4F230
    }

    public class SessionUpdate : Object
    {
        public Sentry.SentryId _id; // 0x10
        public string _distinctId; // 0x20
        public System.DateTimeOffset _startTimestamp; // 0x28
        public string _release; // 0x38
        public string _environment; // 0x40
        public string _ipAddress; // 0x48
        public string _userAgent; // 0x50
        public int _errorCount; // 0x58
        public bool _isInitial; // 0x5C
        public System.DateTimeOffset _timestamp; // 0x60
        public int _sequenceNumber; // 0x70
        public System.Nullable`1<0x6659365C> _endStatus; // 0x74
        public object field_12; // 0x5770

        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFE826F6B90
        public void get_DistinctId(){} // RVA: 0x7FFE811290C0
        public void get_StartTimestamp(){} // RVA: 0x7FFE81E90600
        public void get_Release(){} // RVA: 0x7FFE8143BA80
        public void get_Environment(){} // RVA: 0x7FFE81178740
        public void get_IpAddress(){} // RVA: 0x7FFE81176730
        public void get_UserAgent(){} // RVA: 0x7FFE8119C0E0
        public void get_ErrorCount(){} // RVA: 0x7FFE8175AC90
        public void get_IsInitial(){} // RVA: 0x7FFE81199240
        public void get_Timestamp(){} // RVA: 0x7FFE8432FFC0
        public void get_SequenceNumber(){} // RVA: 0x7FFE81E60180
        public void get_Duration(){} // RVA: 0x7FFE86F032B0
        public void get_EndStatus(){} // RVA: 0x7FFE86F03330
        public void .ctor(){} // RVA: 0x7FFE86F03790 | overloaded x4
        public void WriteTo(){} // RVA: 0x7FFE86F037D0
        public void FromJson(){} // RVA: 0x7FFE86F03E90
    }

    public class SpanContext : Object
    {
        public Sentry.SpanId _spanId; // 0x10
        public System.Nullable`1<Sentry.SpanId> _parentSpanId; // 0x18
        public Sentry.SentryId _traceId; // 0x28
        public string _operation; // 0x38
        public string _description; // 0x40
        public System.Nullable`1<0x66593814> _status; // 0x48
        public System.Nullable`1<bool> _isSampled; // 0x50
        public 0x66590E24 _instrumenter; // 0x54
        public string _origin; // 0x58

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFE81116380
        public void get_ParentSpanId(){} // RVA: 0x7FFE81703940
        public void get_TraceId(){} // RVA: 0x7FFE81E90600
        public void get_Operation(){} // RVA: 0x7FFE8143BA80
        public void set_Operation(){} // RVA: 0x7FFE81437330
        public void get_Description(){} // RVA: 0x7FFE81178740
        public void get_Status(){} // RVA: 0x7FFE81176730
        public void get_IsSampled(){} // RVA: 0x7FFE84E49AB0
        public void get_Instrumenter(){} // RVA: 0x7FFE819EA920
        public void set_Instrumenter(){} // RVA: 0x7FFE819EA900
        public void get_Origin(){} // RVA: 0x7FFE811C3500
        public void set_Origin(){} // RVA: 0x7FFE86F05010
        public void .ctor(){} // RVA: 0x7FFE86F05110
    }

    public class SpanDataExtensions : Object
    {
        // ── Methods ──
        public void SetMeasurement(){} // RVA: 0x7FFE86DEC120 | overloaded x4
    }

    public class SpanExtensions : Object
    {
        // ── Methods ──
        public void StartChild(){} // RVA: 0x7FFE86DEB460 | overloaded x2
        public void GetTransaction(){} // RVA: 0x7FFE86DEB6B0
        public void GetDbParentSpan(){} // RVA: 0x7FFE86DEB7B0
    }

    public class SpanId : ValueType
    {
        // ── Methods ──
        public void GetValue(){} // RVA: 0x7FFE8284EF60
        public void .ctor(){} // RVA: 0x7FFE82889220 | overloaded x2
        public void Equals(){} // RVA: 0x7FFE86F053E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86F054C0
        public void ToString(){} // RVA: 0x7FFE86F05650
        public void Create(){} // RVA: 0x7FFE86F05740
        public void WriteTo(){} // RVA: 0x7FFE86F05830
        public void Parse(){} // RVA: 0x7FFE86F05BC0
        public void FromJson(){} // RVA: 0x7FFE86F05BF0
        public void op_Equality(){} // RVA: 0x7FFE86F05CF0
        public void op_Inequality(){} // RVA: 0x7FFE86F05D80
        public void op_Implicit(){} // RVA: 0x7FFE86F05DF0
        public void .cctor(){} // RVA: 0x7FFE86F05E40
    }

    public class SpanStatusConverter : Object
    {
        // ── Methods ──
        public void FromException(){} // RVA: 0x7FFE86F05FD0
        public void FromHttpStatusCode(){} // RVA: 0x7FFE86F06250 | overloaded x2
        public void FromGrpcStatusCode(){} // RVA: 0x7FFE86F06310
    }

    public class SpanTracer : Object
    {
        public Sentry.IHub _hub; // 0x10
        public Sentry.Internal.SentryStopwatch _stopwatch; // 0x18
        public 0x66590E24 _instrumenter; // 0x30
        public Sentry.TransactionTracer _transaction; // 0x38
        public System.Lazy`1<Sentry.MetricsSummaryAggregator> _metricsSummary; // 0x40
        public Sentry.SpanId _spanId; // 0x48
        public System.Nullable`1<Sentry.SpanId> _parentSpanId; // 0x50
        public Sentry.SentryId _traceId; // 0x60
        public System.DateTimeOffset _startTimestamp; // 0x70
        public System.Nullable`1<System.DateTimeOffset> _endTimestamp; // 0x80
        public System.Collections.Generic.Dictionary`2<string,Sentry.Protocol.Measurement> _internalMeasurements; // 0x98
        public string _operation; // 0xA0
        public string _description; // 0xA8
        public System.Nullable`1<0x66593814> _status; // 0xB0
        public bool _isSentryRequest; // 0xB8
        public System.Nullable`1<bool> _isSampled; // 0xB9
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,string> _internalTags; // 0xC0
        public System.Collections.Concurrent.ConcurrentDictionary`2<string,object> _data; // 0xC8
        public System.Func`1<bool> _isFiltered; // 0xD0
        public string _origin; // 0xD8
        public double StopwatchTicksPerTimeSpanTick;
        public double StopwatchTicksPerNs; // 0x8

        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7FFE86F063D0
        public void get_Transaction(){} // RVA: 0x7FFE8143BA80
        public void get_MetricsSummary(){} // RVA: 0x7FFE86F063E0
        public void get_HasMetrics(){} // RVA: 0x7FFE86F06430
        public void get_SpanId(){} // RVA: 0x7FFE81176730
        public void set_SpanId(){} // RVA: 0x7FFE82502600
        public void get_ParentSpanId(){} // RVA: 0x7FFE84E45FD0
        public void set_ParentSpanId(){} // RVA: 0x7FFE8667B700
        public void get_TraceId(){} // RVA: 0x7FFE8432FFC0
        public void get_StartTimestamp(){} // RVA: 0x7FFE86B57070
        public void set_StartTimestamp(){} // RVA: 0x7FFE86B57080
        public void get_EndTimestamp(){} // RVA: 0x7FFE81BD2660
        public void set_EndTimestamp(){} // RVA: 0x7FFE81BD0960
        public void get_IsFinished(){} // RVA: 0x7FFE86F06480
        public void get_InternalMeasurements(){} // RVA: 0x7FFE817AE360
        public void set_InternalMeasurements(){} // RVA: 0x7FFE8171B470
        public void get_Measurements(){} // RVA: 0x7FFE86F064C0
        public void SetMeasurement(){} // RVA: 0x7FFE86F06590
        public void get_Operation(){} // RVA: 0x7FFE8179C860
        public void set_Operation(){} // RVA: 0x7FFE8171B4D0
        public void get_Description(){} // RVA: 0x7FFE817AB5E0
        public void set_Description(){} // RVA: 0x7FFE81857260
        public void get_Status(){} // RVA: 0x7FFE81166040
        public void set_Status(){} // RVA: 0x7FFE82904640
        public void get_IsSentryRequest(){} // RVA: 0x7FFE824AEC00
        public void set_IsSentryRequest(){} // RVA: 0x7FFE824AD2F0
        public void get_IsSampled(){} // RVA: 0x7FFE86F066C0
        public void set_IsSampled(){} // RVA: 0x7FFE86F066D0
        public void get_InternalTags(){} // RVA: 0x7FFE81166120
        public void set_InternalTags(){} // RVA: 0x7FFE81166130
        public void get_Tags(){} // RVA: 0x7FFE86F066E0
        public void SetTag(){} // RVA: 0x7FFE86F067B0
        public void UnsetTag(){} // RVA: 0x7FFE86F068D0
        public void get_Extra(){} // RVA: 0x7FFE81253460
        public void SetExtra(){} // RVA: 0x7FFE86F06A40
        public void get_IsFiltered(){} // RVA: 0x7FFE81218100
        public void set_IsFiltered(){} // RVA: 0x7FFE81218110
        public void .ctor(){} // RVA: 0x7FFE86F06DD0 | overloaded x2
        public void StartChild(){} // RVA: 0x7FFE86F070E0
        public void Unfinish(){} // RVA: 0x7FFE86F07130
        public void Finish(){} // RVA: 0x7FFE86F07790 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x7FFE86F077D0
        public void get_Origin(){} // RVA: 0x7FFE8181EA80
        public void set_Origin(){} // RVA: 0x7FFE86F07840
    }

    public class StreamAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetStream(){} // RVA: 0x7FFE81116380
    }

    public class SubstringOrRegexPattern : Object
    {
        public System.Text.RegularExpressions.Regex _regex; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFE86F07A80 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE86F07B10
        public void Equals(){} // RVA: 0x7FFE86F07B80
        public void GetHashCode(){} // RVA: 0x7FFE82C46B00
        public void get_Regex(){} // RVA: 0x7FFE81116380
        public void IsMatch(){} // RVA: 0x7FFE86F07C80
        public void TryParseRegex(){} // RVA: 0x7FFE86F07E20
    }

    public class SubstringOrRegexPatternExtensions : Object
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x7FFE86F07ED0
        public void WithConfigBinding(){} // RVA: 0x7FFE80E2E3D0
    }

    public class SubstringOrRegexPatternTypeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFE86F07FF0
        public void ConvertFrom(){} // RVA: 0x7FFE86F080C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}