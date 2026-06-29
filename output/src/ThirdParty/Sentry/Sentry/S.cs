// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 44
// Methods: 915

namespace ThirdParty.Sentry.Sentry
{
    public class Scope : Object
    {
        public object _options;
        public object _locked;
        public object _lastEventIdSync;
        public object _lastEventId;
        public object _evaluationSync;
        public object _hasEvaluated;
        public object _lazyExceptionProcessors;
        public object _lazyEventProcessors;
        public object _lazyTransactionProcessors;
        public object OnEvaluating;
        public object _level;
        public object _request;
        public object _contexts;
        public object _user;
        public object _release;
        public object _distribution;
        public object _environment;
        public object _fallbackTransactionName;
        public object _transaction;
        public object _propagationContext;
        public object _sessionUpdate;
        public object _sdk;
        public object _fingerprint;
        public object _breadcrumbs;
        public object _extra;
        public object _tags;
        public object _attachments;
        public object _span;

        // ── Methods ──
        public void get_Options(){} // RVA: 0xB5DBF0
        public void get_Locked(){} // RVA: 0xB5DD50
        public void set_Locked(){} // RVA: 0xB5DD60
        public void get_LastEventId(){} // RVA: 0x6D238D0
        public void set_LastEventId(){} // RVA: 0x6D239F0
        public void get_HasEvaluated(){} // RVA: 0x6D23B00
        public void get_ExceptionProcessors(){} // RVA: 0x6D23B10
        public void get_EventProcessors(){} // RVA: 0x6D23B60
        public void get_TransactionProcessors(){} // RVA: 0x6D23BB0
        public void add_OnEvaluating(){} // RVA: 0x6D23C00
        public void remove_OnEvaluating(){} // RVA: 0x6D23D10
        public void get_Level(){} // RVA: 0x2536460
        public void set_Level(){} // RVA: 0x25406E0
        public void get_Request(){} // RVA: 0x6D23E20
        public void set_Request(){} // RVA: 0xC10060
        public void get_Contexts(){} // RVA: 0xCD3320
        public void set_Contexts(){} // RVA: 0x6D23EC0
        public void get_UserChanged(){} // RVA: 0x6D23EE0
        public void get_User(){} // RVA: 0x6D23F60
        public void set_User(){} // RVA: 0x6D24080
        public void get_Release(){} // RVA: 0xB813B0
        public void set_Release(){} // RVA: 0xD5CBB0
        public void get_Distribution(){} // RVA: 0x1069350
        public void set_Distribution(){} // RVA: 0xD5CC10
        public void get_Environment(){} // RVA: 0x106A7D0
        public void set_Environment(){} // RVA: 0xD5CC70
        public void get_TransactionName(){} // RVA: 0x6D24150
        public void set_TransactionName(){} // RVA: 0x6D241B0
        public void get_Transaction(){} // RVA: 0x12EB090
        public void set_Transaction(){} // RVA: 0x13B1040
        public void get_PropagationContext(){} // RVA: 0xBAE340
        public void set_PropagationContext(){} // RVA: 0xBAE350
        public void get_SessionUpdate(){} // RVA: 0xBAE3B0
        public void set_SessionUpdate(){} // RVA: 0xBAE3C0
        public void get_Sdk(){} // RVA: 0xBAE420
        public void get_Fingerprint(){} // RVA: 0xCA4D80
        public void set_Fingerprint(){} // RVA: 0xCA4D90
        public void get_Breadcrumbs(){} // RVA: 0xC68EB0
        public void get_Extra(){} // RVA: 0x135D730
        public void get_Tags(){} // RVA: 0xBC5B30
        public void get_Attachments(){} // RVA: 0xBC5BA0
        public void .ctor(){} // RVA: 0x6D24C30
        public void AddBreadcrumb(){} // RVA: 0x6D24D10
        public void SetExtra(){} // RVA: 0x6D24F40
        public void SetTag(){} // RVA: 0x6D24FF0
        public void UnsetTag(){} // RVA: 0x6D251C0
        public void AddAttachment(){} // RVA: 0x6D28D20
        public void Clear(){} // RVA: 0x6D25330
        public void ClearAttachments(){} // RVA: 0x6D25940
        public void ClearBreadcrumbs(){} // RVA: 0x6D259F0
        public void Apply(){} // RVA: 0x6D27040
        public void Clone(){} // RVA: 0x6D27120
        public void Evaluate(){} // RVA: 0x6D27980
        public void get_Span(){} // RVA: 0x6D27BF0
        public void set_Span(){} // RVA: 0xBAE5B0
        public void GetAllEventProcessors(){} // RVA: 0x6D27CE0
        public void GetAllTransactionProcessors(){} // RVA: 0x6D27D90
        public void GetAllExceptionProcessors(){} // RVA: 0x6D27E40
        public void AddExceptionProcessor(){} // RVA: 0x6D27EF0
        public void AddExceptionProcessors(){} // RVA: 0x6D27F80
        public void AddEventProcessor(){} // RVA: 0x6D28260
        public void AddEventProcessors(){} // RVA: 0x6D28380
        public void AddTransactionProcessor(){} // RVA: 0x6D28660
        public void AddTransactionProcessors(){} // RVA: 0x6D28780
        public void ResetTransaction(){} // RVA: 0x6D28EA0
        public void <get_UserChanged>b__41_0(){} // RVA: 0x6D28F00
    }

    public class SdkVersion : Object
    {
        public object InstanceLazy;
        public object _internalPackages;
        public object _integrations;
        public object _name;
        public object _version;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6DFEF20
        public void get_InternalPackages(){} // RVA: 0xB5DBF0
        public void set_InternalPackages(){} // RVA: 0xB44D60
        public void get_Integrations(){} // RVA: 0xB465B0
        public void set_Integrations(){} // RVA: 0xBA9BA0
        public void get_Packages(){} // RVA: 0xB5DBF0
        public void get_Name(){} // RVA: 0xB700F0
        public void set_Name(){} // RVA: 0xB70100
        public void get_Version(){} // RVA: 0xB70160
        public void set_Version(){} // RVA: 0xB44DC0
        public void AddPackage(){} // RVA: 0x6DFF060
        public void AddIntegration(){} // RVA: 0x6DFF0C0
        public void WriteTo(){} // RVA: 0x6DFF120
        public void FromJson(){} // RVA: 0x6DFF460
        public void .ctor(){} // RVA: 0x6E00050
        public void .cctor(){} // RVA: 0x6E001B0
    }

    public class SentryAttachment : Object
    {
        public object _type;
        public object _content;
        public object _fileName;
        public object _contentType;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xB8F8F0
        public void get_Content(){} // RVA: 0xB465B0
        public void get_FileName(){} // RVA: 0xB700F0
        public void get_ContentType(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x6672C70
    }

    public class SentryCheckIn : Object
    {
        public object _id;
        public object _monitorSlug;
        public object _status;
        public object _duration;
        public object _release;
        public object _environment;
        public object _traceId;
        public object _monitorOptions;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x22343B0
        public void get_MonitorSlug(){} // RVA: 0xB700F0
        public void get_Status(){} // RVA: 0x1065D50
        public void get_Duration(){} // RVA: 0x16CD820
        public void set_Duration(){} // RVA: 0x16DCEF0
        public void get_Release(){} // RVA: 0xBC1B30
        public void set_Release(){} // RVA: 0xB6A8C0
        public void get_Environment(){} // RVA: 0xBBF8F0
        public void set_Environment(){} // RVA: 0xBBF900
        public void get_TraceId(){} // RVA: 0x4CF9E80
        public void set_TraceId(){} // RVA: 0x6E005E0
        public void get_MonitorOptions(){} // RVA: 0xBBFF90
        public void set_MonitorOptions(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0x6E005F0
        public void WriteTo(){} // RVA: 0x6E00740
        public void ToSnakeCase(){} // RVA: 0x6E00DA0
    }

    public class SentryClient : Object
    {
        public object _options;
        public object _sessionManager;
        public object _randomValuesFactory;
        public object _enricher;
        public object _worker;

        // ── Methods ──
        public void get_Worker(){} // RVA: 0xD33E60
        public void get_Options(){} // RVA: 0xB5DBF0
        public void get_IsEnabled(){} // RVA: 0xC2E4C0
        public void .ctor(){} // RVA: 0x6E00ED0
        public void CaptureEvent(){} // RVA: 0x6E014B0
        public void CaptureUserFeedback(){} // RVA: 0x6E01660
        public void CaptureTransaction(){} // RVA: 0x6E01970
        public void BeforeSendTransaction(){} // RVA: 0x6E02620
        public void CaptureSession(){} // RVA: 0x6E02920
        public void CaptureCheckIn(){} // RVA: 0x6E02AB0
        public void FlushAsync(){} // RVA: 0x6E03090
        public void DoSendEvent(){} // RVA: 0x6E030F0
        public void ApplyExceptionFilters(){} // RVA: 0x6E04550
        public void CaptureEnvelope(){} // RVA: 0x6E04880
        public void BeforeSend(){} // RVA: 0x6E04AB0
        public void Dispose(){} // RVA: 0x6E04DB0
    }

    public class SentryClientExtensions : Object
    {
        public object _sentryOptionsForTestingOnly;

        // ── Methods ──
        public void CaptureException(){} // RVA: 0x6E05060
        public void CaptureMessage(){} // RVA: 0x6E051D0
        public void CaptureUserFeedback(){} // RVA: 0x6E05410
        public void Flush(){} // RVA: 0x6E05590
        public void FlushAsync(){} // RVA: 0x6E05670
        public void get_SentryOptionsForTestingOnly(){} // RVA: 0x6E05710
        public void set_SentryOptionsForTestingOnly(){} // RVA: 0x6E05750
        public void GetSentryOptions(){} // RVA: 0x6E057F0
    }

    public class SentryContexts : Object
    {
        public object _innerDictionary;

        // ── Methods ──
        public void get_App(){} // RVA: 0x6E05930
        public void get_Browser(){} // RVA: 0x6E05990
        public void get_Device(){} // RVA: 0x6E059F0
        public void get_OperatingSystem(){} // RVA: 0x6E05A50
        public void get_Response(){} // RVA: 0x6E05AB0
        public void get_Runtime(){} // RVA: 0x6E05B10
        public void get_Gpu(){} // RVA: 0x6E05B70
        public void get_Trace(){} // RVA: 0x6E05BD0
        public void .ctor(){} // RVA: 0x6E05C30
        public void Clone(){} // RVA: 0x6E05D70
        public void CopyTo(){} // RVA: 0x6E074E0
        public void WriteTo(){} // RVA: 0x6E06150
        public void FromJson(){} // RVA: 0x6E063D0
        public void ReplaceWith(){} // RVA: 0x6E06F20
        public void NullIfEmpty(){} // RVA: 0x6E071D0
        public void GetEnumerator(){} // RVA: 0x6E07230
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6E07280
        public void Add(){} // RVA: 0x6E07730
        public void Clear(){} // RVA: 0x6E073A0
        public void Contains(){} // RVA: 0x6E073F0
        public void Remove(){} // RVA: 0x6E07820
        public void get_Count(){} // RVA: 0x6E07690
        public void get_IsReadOnly(){} // RVA: 0x6E076E0
        public void ContainsKey(){} // RVA: 0x6E077C0
        public void TryGetValue(){} // RVA: 0x6E07880
        public void get_Item(){} // RVA: 0x6E07A60
        public void set_Item(){} // RVA: 0x6E07AC0
        public void get_Keys(){} // RVA: 0x6E07B30
        public void get_Values(){} // RVA: 0x6E07B90
    }

    public class SentryEvent : Object
    {
        public object _modules;
        public object _exception;
        public object _eventId;
        public object _timestamp;
        public object _message;
        public object _logger;
        public object _platform;
        public object _serverName;
        public object _release;
        public object _distribution;
        public object _sentryExceptionValues;
        public object _sentryThreadValues;
        public object _debugMeta;
        public object _level;
        public object _transactionName;
        public object _request;
        public object _contexts;
        public object _user;
        public object _environment;
        public object _sdk;
        public object _fingerprint;
        public object _breadcrumbs;
        public object _extra;
        public object _tags;
        public object _dynamicSamplingContext;

        // ── Methods ──
        public void get_Exception(){} // RVA: 0xB465B0
        public void get_EventId(){} // RVA: 0x16CD810
        public void get_Timestamp(){} // RVA: 0x16CD820
        public void get_Message(){} // RVA: 0xBC1B30
        public void set_Message(){} // RVA: 0xB6A8C0
        public void get_Logger(){} // RVA: 0xBBF8F0
        public void set_Logger(){} // RVA: 0xBBF900
        public void get_Platform(){} // RVA: 0xBE58B0
        public void set_Platform(){} // RVA: 0xCA4DF0
        public void get_ServerName(){} // RVA: 0xC0FFC0
        public void set_ServerName(){} // RVA: 0xC0FFD0
        public void get_Release(){} // RVA: 0xBE2C60
        public void set_Release(){} // RVA: 0xBE2C70
        public void get_Distribution(){} // RVA: 0xBBFF90
        public void set_Distribution(){} // RVA: 0xBBFFA0
        public void get_SentryExceptionValues(){} // RVA: 0xC10050
        public void set_SentryExceptionValues(){} // RVA: 0xC10060
        public void get_SentryExceptions(){} // RVA: 0x6E080D0
        public void set_SentryExceptions(){} // RVA: 0x6E08140
        public void get_SentryThreadValues(){} // RVA: 0xCD3320
        public void set_SentryThreadValues(){} // RVA: 0xCD4740
        public void get_SentryThreads(){} // RVA: 0x6E08270
        public void set_SentryThreads(){} // RVA: 0x6E082E0
        public void get_DebugImages(){} // RVA: 0x6E08410
        public void set_DebugImages(){} // RVA: 0x6E08430
        public void get_Modules(){} // RVA: 0x6E08550
        public void get_Level(){} // RVA: 0x14780B0
        public void set_Level(){} // RVA: 0x147EE80
        public void get_TransactionName(){} // RVA: 0x1069350
        public void set_TransactionName(){} // RVA: 0xD5CC10
        public void get_Request(){} // RVA: 0x6E08610
        public void set_Request(){} // RVA: 0xD5CC70
        public void get_Contexts(){} // RVA: 0x106A050
        public void set_Contexts(){} // RVA: 0x6E086B0
        public void get_User(){} // RVA: 0x6E086E0
        public void set_User(){} // RVA: 0x13B1040
        public void get_Environment(){} // RVA: 0xBAE340
        public void set_Environment(){} // RVA: 0xBAE350
        public void get_Sdk(){} // RVA: 0xBAE3B0
        public void set_Sdk(){} // RVA: 0xBAE3C0
        public void get_Fingerprint(){} // RVA: 0x6E08780
        public void set_Fingerprint(){} // RVA: 0xBAE430
        public void get_Breadcrumbs(){} // RVA: 0x6E087D0
        public void get_Extra(){} // RVA: 0x6E088A0
        public void get_Tags(){} // RVA: 0x6E08970
        public void HasException(){} // RVA: 0x6E08A40
        public void HasTerminalException(){} // RVA: 0x6E08AB0
        public void get_DynamicSamplingContext(){} // RVA: 0xBC5B30
        public void set_DynamicSamplingContext(){} // RVA: 0xBC5B40
        public void .ctor(){} // RVA: 0x6E08EB0
        public void AddBreadcrumb(){} // RVA: 0x6E092E0
        public void SetExtra(){} // RVA: 0x6E093E0
        public void SetTag(){} // RVA: 0x6E09510
        public void UnsetTag(){} // RVA: 0x6E09640
        public void Redact(){} // RVA: 0x6E09740
        public void WriteTo(){} // RVA: 0x6E099A0
        public void FromJson(){} // RVA: 0x6E0A490
    }

    public class SentryFailedRequestHandler : Object
    {
        public object _hub;
        public object _options;

        // ── Methods ──
        public void get_Hub(){} // RVA: 0xB5DBF0
        public void get_Options(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x8943B0
        public void HandleResponse(){} // RVA: 0x6E0CD20
    }

    public class SentryGraphQLHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        public object _hub;
        public object _options;
        public object MechanismType;
        public object _httpFailedRequestHandler;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0CF30
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x6E0D0C0
    }

    public class SentryGraphQLHttpMessageHandler : SentryMessageHandler
    {
        public object _hub;
        public object _options;
        public object _failedRequestHandler;
        public object GraphQlOrigin;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0D950
        public void ProcessRequest(){} // RVA: 0x6E0DCE0
        public void HandleResponse(){} // RVA: 0x6E0E0C0
        public void GetSpanDescriptionOrDefault(){} // RVA: 0x6E0E770
        public void AddIfExists(){} // RVA: 0x6E0E960
    }

    public class SentryHint : Object
    {
        public object _options;
        public object _attachments;
        public object _items;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0EC80
        public void get_Attachments(){} // RVA: 0xB465B0
        public void get_Items(){} // RVA: 0x6E0EDB0
        public void AddAttachmentsFromScope(){} // RVA: 0x6E0EE70
        public void AddAttachment(){} // RVA: 0x6E0F070
        public void WithAttachments(){} // RVA: 0x6E0F260
    }

    public class SentryHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        public object MechanismType;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0F300
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x6E0F310
    }

    public class SentryHttpMessageHandler : SentryMessageHandler
    {
        public object _hub;
        public object _options;
        public object _failedRequestHandler;
        public object HttpClientOrigin;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E0F9F0
        public void ProcessRequest(){} // RVA: 0x6E0FC40
        public void HandleResponse(){} // RVA: 0x6E0FED0
    }

    public class SentryId : ValueType
    {
        public object _guid;
        public object Empty;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7BE90
        public void ToString(){} // RVA: 0x8F4380
        public void Equals(){} // RVA: 0x8F4420
        public void GetHashCode(){} // RVA: 0x8F4430
        public void Create(){} // RVA: 0x6E10390
        public void WriteTo(){} // RVA: 0x8F4450
        public void Parse(){} // RVA: 0x690C440
        public void FromJson(){} // RVA: 0x6E10520
        public void op_Equality(){} // RVA: 0x6E10750
        public void op_Inequality(){} // RVA: 0x6E10800
        public void op_Implicit(){} // RVA: 0xFE9840
        public void .cctor(){} // RVA: 0xB43310
    }

    public class SentryMessage : Object
    {
        public object _message;
        public object _params;
        public object _formatted;

        // ── Methods ──
        public void get_Message(){} // RVA: 0xB5DBF0
        public void set_Message(){} // RVA: 0xB44D60
        public void get_Params(){} // RVA: 0xB465B0
        public void set_Params(){} // RVA: 0xBA9BA0
        public void get_Formatted(){} // RVA: 0xB700F0
        public void set_Formatted(){} // RVA: 0xB70100
        public void op_Implicit(){} // RVA: 0x6E108E0
        public void WriteTo(){} // RVA: 0x6E10980
        public void FromJson(){} // RVA: 0x6E10BB0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SentryMessageHandler : DelegatingHandler
    {
        public object _hub;
        public object _options;
        public object _innerHandlerLock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6E115C0
        public void ProcessRequest(){} // RVA: 0x882090
        public void HandleResponse(){} // RVA: 0x899870
        public void SendAsync(){} // RVA: 0x6E117D0
        public void PropagateTraceHeaders(){} // RVA: 0x6E11A20
        public void AddSentryTraceHeader(){} // RVA: 0x6E11E10
        public void AddBaggageHeader(){} // RVA: 0x6E11F60
        public void <>n__0(){} // RVA: 0x6E125F0
    }

    public class SentryMonitorOptions : Object
    {
        public object _type;
        public object _crontab;
        public object _interval;
        public object _unit;
        public object CrontabValidationInstance;
        public object _checkInMargin;
        public object _maxRuntime;
        public object _failureIssueThreshold;
        public object _recoveryThreshold;
        public object _timeZone;
        public object _owner;

        // ── Methods ──
        public void CrontabValidation(){} // RVA: 0x6E12E80
        public void Interval(){} // RVA: 0x6E13240
        public void get_CheckInMargin(){} // RVA: 0x16CD820
        public void set_CheckInMargin(){} // RVA: 0x16DCEF0
        public void get_MaxRuntime(){} // RVA: 0x16DCC90
        public void set_MaxRuntime(){} // RVA: 0x16DCEE0
        public void get_FailureIssueThreshold(){} // RVA: 0xBE58B0
        public void set_FailureIssueThreshold(){} // RVA: 0x6E13320
        public void get_RecoveryThreshold(){} // RVA: 0xC0FFC0
        public void set_RecoveryThreshold(){} // RVA: 0x6E133D0
        public void get_TimeZone(){} // RVA: 0xBE2C60
        public void set_TimeZone(){} // RVA: 0xBE2C70
        public void get_Owner(){} // RVA: 0xBBFF90
        public void set_Owner(){} // RVA: 0xBBFFA0
        public void .ctor(){} // RVA: 0xB43310
        public void WriteTo(){} // RVA: 0x6E13480
        public void TypeToString(){} // RVA: 0x6E13E30
    }

    public class SentryOptions : Object
    {
        public object _defaultTags;
        public object DefaultRegexOptions;
        public object _scopeStackContainer;
        public object _lazyInstallationId;
        public object _isGlobalModeEnabled;
        public object _scopeObserver;
        public object _enableScopeSync;
        public object _transport;
        public object _clientReportRecorder;
        public object _sentryStackTraceFactory;
        public object _sentryVersion;
        public object _exceptionProcessors;
        public object _transactionProcessors;
        public object _eventProcessors;
        public object _eventProcessorsProviders;
        public object _transactionProcessorsProviders;
        public object _exceptionProcessorsProviders;
        public object _defaultIntegrations;
        public object _exceptionFilters;
        public object _tagFilters;
        public object _backgroundWorker;
        public object _sentryHttpClientFactory;
        public object _sentryScopeStateProcessor;
        public object _inAppExclude;
        public object _inAppInclude;
        public object _sendDefaultPii;
        public object _isEnvironmentUser;
        public object _serverName;
        public object _attachStacktrace;
        public object _maxBreadcrumbs;
        public object _sampleRate;
        public object _release;
        public object _distribution;
        public object _environment;
        public object _dsn;
        public object _parsedDsn;
        public object _sentryBaseUrl;
        public object _beforeSend;
        public object _beforeSendTransaction;
        public object _beforeBreadcrumb;
        public object _maxQueueItems;
        public object _maxCacheItems;
        public object _shutdownTimeout;
        public object _flushTimeout;
        public object _decompressionMethods;
        public object _requestBodyCompressionLevel;
        public object _requestBodyCompressionBuffered;
        public object _sendClientReports;
        public object _httpProxy;
        public object _createHttpMessageHandler;
        public object _configureClient;
        public object _debug;
        public object _diagnosticLevel;
        public object _diagnosticLogger;
        public object _reportAssembliesMode;
        public object _deduplicateMode;
        public object _cacheDirectoryPath;
        public object _captureFailedRequests;
        public object _failedRequestStatusCodes;
        public object _failedRequestTargets;
        public object _fileSystem;
        public object _disableFileWrite;
        public object _initCacheFlushTimeout;
        public object _enableTracing;
        public object _tracesSampleRate;
        public object _profilesSampleRate;
        public object _tracesSampler;
        public object _tracePropagationTargets;
        public object _transactionProfilerFactory;
        public object _stackTraceMode;
        public object _integrations;
        public object _maxAttachmentSize;
        public object _detectStartupTime;
        public object _autoSessionTrackingInterval;
        public object _autoSessionTracking;
        public object _useAsyncFileIO;
        public object _crashedLastRun;
        public object _instrumenter;
        public object _networkStatusListener;
        public object _assemblyReader;
        public object _experimentalMetrics;
        public object _spotlightUrl;
        public object _enableSpotlight;
        public object _settingLocator;
        public object _initNativeSdks;
        public object _postInitCallbacks;

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0xB465B0
        public void set_ScopeStackContainer(){} // RVA: 0xBA9BA0
        public void get_InstallationId(){} // RVA: 0x6E13F20
        public void get_IsGlobalModeEnabled(){} // RVA: 0x6E13F70
        public void set_IsGlobalModeEnabled(){} // RVA: 0x6E140A0
        public void get_ScopeObserver(){} // RVA: 0xD33E60
        public void set_ScopeObserver(){} // RVA: 0xB708C0
        public void get_EnableScopeSync(){} // RVA: 0xD16660
        public void set_EnableScopeSync(){} // RVA: 0xD14C10
        public void get_Transport(){} // RVA: 0xBC1B30
        public void set_Transport(){} // RVA: 0xB6A8C0
        public void get_ClientReportRecorder(){} // RVA: 0x6E140F0
        public void set_ClientReportRecorder(){} // RVA: 0x6E14140
        public void get_SentryStackTraceFactory(){} // RVA: 0x6E14320
        public void set_SentryStackTraceFactory(){} // RVA: 0x6E14370
        public void get_SentryVersion(){} // RVA: 0x12BB630
        public void get_ExceptionProcessors(){} // RVA: 0xBE2C60
        public void set_ExceptionProcessors(){} // RVA: 0xBE2C70
        public void get_TransactionProcessors(){} // RVA: 0xBBFF90
        public void set_TransactionProcessors(){} // RVA: 0xBBFFA0
        public void get_EventProcessors(){} // RVA: 0xC10050
        public void set_EventProcessors(){} // RVA: 0xC10060
        public void get_EventProcessorsProviders(){} // RVA: 0xCD3320
        public void set_EventProcessorsProviders(){} // RVA: 0xCD4740
        public void get_TransactionProcessorsProviders(){} // RVA: 0xCD48B0
        public void set_TransactionProcessorsProviders(){} // RVA: 0xCD3600
        public void get_ExceptionProcessorsProviders(){} // RVA: 0xB813B0
        public void set_ExceptionProcessorsProviders(){} // RVA: 0xD5CBB0
        public void get_Integrations(){} // RVA: 0x6E14550
        public void get_ExceptionFilters(){} // RVA: 0x106A7D0
        public void set_ExceptionFilters(){} // RVA: 0xD5CC70
        public void get_TagFilters(){} // RVA: 0x106A050
        public void set_TagFilters(){} // RVA: 0xD5CCD0
        public void get_BackgroundWorker(){} // RVA: 0x12EB090
        public void set_BackgroundWorker(){} // RVA: 0x13B1040
        public void get_SentryHttpClientFactory(){} // RVA: 0xBAE340
        public void set_SentryHttpClientFactory(){} // RVA: 0xBAE350
        public void GetHttpClient(){} // RVA: 0x6E14600
        public void get_SentryScopeStateProcessor(){} // RVA: 0xBAE3B0
        public void set_SentryScopeStateProcessor(){} // RVA: 0xBAE3C0
        public void get_InAppExclude(){} // RVA: 0xBAE420
        public void set_InAppExclude(){} // RVA: 0xBAE430
        public void get_InAppInclude(){} // RVA: 0xCA4D80
        public void set_InAppInclude(){} // RVA: 0xCA4D90
        public void get_SendDefaultPii(){} // RVA: 0x1A6FCB0
        public void set_SendDefaultPii(){} // RVA: 0x1A6FC50
        public void get_IsEnvironmentUser(){} // RVA: 0x1A70140
        public void set_IsEnvironmentUser(){} // RVA: 0x6E146E0
        public void get_ServerName(){} // RVA: 0x135D730
        public void set_ServerName(){} // RVA: 0xBC5AD0
        public void get_AttachStacktrace(){} // RVA: 0xC77E50
        public void set_AttachStacktrace(){} // RVA: 0xC77E60
        public void get_MaxBreadcrumbs(){} // RVA: 0x31178C0
        public void set_MaxBreadcrumbs(){} // RVA: 0x6CE7BB0
        public void get_SampleRate(){} // RVA: 0xBC5BA0
        public void set_SampleRate(){} // RVA: 0x6E146F0
        public void get_Release(){} // RVA: 0xBAE5A0
        public void set_Release(){} // RVA: 0xBAE5B0
        public void get_Distribution(){} // RVA: 0x135A7B0
        public void set_Distribution(){} // RVA: 0xEC0BB0
        public void get_Environment(){} // RVA: 0x10B4170
        public void set_Environment(){} // RVA: 0x15B42C0
        public void get_Dsn(){} // RVA: 0x10B9D50
        public void set_Dsn(){} // RVA: 0x6E147E0
        public void get_ParsedDsn(){} // RVA: 0x6E148B0
        public void IsSentryRequest(){} // RVA: 0x6E14AF0
        public void get_BeforeSendInternal(){} // RVA: 0x114AC20
        public void SetBeforeSend(){} // RVA: 0x6E14C60
        public void get_BeforeSendTransactionInternal(){} // RVA: 0xE3C930
        public void SetBeforeSendTransaction(){} // RVA: 0x6E14DE0
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x135EDB0
        public void SetBeforeBreadcrumb(){} // RVA: 0x6E14F60
        public void get_MaxQueueItems(){} // RVA: 0x6BA2C40
        public void set_MaxQueueItems(){} // RVA: 0x6E150E0
        public void get_MaxCacheItems(){} // RVA: 0x100D890
        public void set_MaxCacheItems(){} // RVA: 0x6E15190
        public void get_ShutdownTimeout(){} // RVA: 0xBAE8F0
        public void set_ShutdownTimeout(){} // RVA: 0x6E15240
        public void get_FlushTimeout(){} // RVA: 0xBAE960
        public void set_FlushTimeout(){} // RVA: 0x6D09B50
        public void get_DecompressionMethods(){} // RVA: 0x6E15250
        public void set_DecompressionMethods(){} // RVA: 0x6E15260
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x6E15270
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x6E15280
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x6E15290
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x6E152A0
        public void get_SendClientReports(){} // RVA: 0x6E152B0
        public void set_SendClientReports(){} // RVA: 0x6E152C0
        public void get_HttpProxy(){} // RVA: 0x1143F90
        public void set_HttpProxy(){} // RVA: 0x113E310
        public void get_CreateHttpMessageHandler(){} // RVA: 0x164B8E0
        public void set_CreateHttpMessageHandler(){} // RVA: 0x16601C0
        public void get_ConfigureClient(){} // RVA: 0x10F9C30
        public void set_ConfigureClient(){} // RVA: 0x1659C50
        public void get_Debug(){} // RVA: 0x6E152D0
        public void set_Debug(){} // RVA: 0x6E152E0
        public void get_DiagnosticLevel(){} // RVA: 0x6E152F0
        public void set_DiagnosticLevel(){} // RVA: 0x6E15300
        public void get_DiagnosticLogger(){} // RVA: 0x6E15310
        public void set_DiagnosticLogger(){} // RVA: 0x6E15330
        public void get_ReportAssembliesMode(){} // RVA: 0x1145600
        public void set_ReportAssembliesMode(){} // RVA: 0x6E15460
        public void get_DeduplicateMode(){} // RVA: 0x6CEA7F0
        public void set_DeduplicateMode(){} // RVA: 0x6E15470
        public void get_CacheDirectoryPath(){} // RVA: 0x13659D0
        public void set_CacheDirectoryPath(){} // RVA: 0x166D270
        public void get_CaptureFailedRequests(){} // RVA: 0x6E15480
        public void set_CaptureFailedRequests(){} // RVA: 0x6E15490
        public void get_FailedRequestStatusCodes(){} // RVA: 0x1664460
        public void set_FailedRequestStatusCodes(){} // RVA: 0x16679E0
        public void get_FailedRequestTargets(){} // RVA: 0x6E154A0
        public void set_FailedRequestTargets(){} // RVA: 0x6E154F0
        public void get_FileSystem(){} // RVA: 0x6E15620
        public void set_FileSystem(){} // RVA: 0x165C4D0
        public void get_DisableFileWrite(){} // RVA: 0x6E156E0
        public void set_DisableFileWrite(){} // RVA: 0x6E156F0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x1344890
        public void set_InitCacheFlushTimeout(){} // RVA: 0x6E15700
        public void get_DefaultTags(){} // RVA: 0x6E15710
        public void set_DefaultTags(){} // RVA: 0xB44D60
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x6E157D0
        public void get_IsProfilingEnabled(){} // RVA: 0x6E158D0
        public void get_EnableTracing(){} // RVA: 0x6E15A10
        public void set_EnableTracing(){} // RVA: 0x6E15A20
        public void get_TracesSampleRate(){} // RVA: 0x6E15A30
        public void set_TracesSampleRate(){} // RVA: 0x6E15A40
        public void get_ProfilesSampleRate(){} // RVA: 0x6E15B50
        public void set_ProfilesSampleRate(){} // RVA: 0x6E15B60
        public void get_TracesSampler(){} // RVA: 0x1659260
        public void set_TracesSampler(){} // RVA: 0x165DAA0
        public void get_TracePropagationTargets(){} // RVA: 0x136ECA0
        public void set_TracePropagationTargets(){} // RVA: 0x6E15C70
        public void get_TransactionProfilerFactory(){} // RVA: 0x165F4F0
        public void set_TransactionProfilerFactory(){} // RVA: 0x164A160
        public void get_StackTraceMode(){} // RVA: 0x6E15D10
        public void set_StackTraceMode(){} // RVA: 0x6E15F10
        public void get_MaxAttachmentSize(){} // RVA: 0x165F950
        public void set_MaxAttachmentSize(){} // RVA: 0x6E15F70
        public void get_DetectStartupTime(){} // RVA: 0x6E15F80
        public void set_DetectStartupTime(){} // RVA: 0x6E15F90
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x165A670
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x6E15FA0
        public void get_AutoSessionTracking(){} // RVA: 0x6CCAFC0
        public void set_AutoSessionTracking(){} // RVA: 0x6CCAFD0
        public void get_UseAsyncFileIO(){} // RVA: 0x6CCAFE0
        public void set_UseAsyncFileIO(){} // RVA: 0x6CCAFF0
        public void get_CrashedLastRun(){} // RVA: 0x163F650
        public void set_CrashedLastRun(){} // RVA: 0x1656720
        public void get_Instrumenter(){} // RVA: 0x6E15FB0
        public void set_Instrumenter(){} // RVA: 0x6E15FC0
        public void AddJsonConverter(){} // RVA: 0x6E15FD0
        public void AddJsonSerializerContext(){} // RVA: 0x894320
        public void get_JsonPreserveReferences(){} // RVA: 0x6E16070
        public void set_JsonPreserveReferences(){} // RVA: 0x6E16110
        public void get_NetworkStatusListener(){} // RVA: 0x165DF30
        public void set_NetworkStatusListener(){} // RVA: 0x164E760
        public void get_AssemblyReader(){} // RVA: 0x16565B0
        public void set_AssemblyReader(){} // RVA: 0x166D140
        public void get_ExperimentalMetrics(){} // RVA: 0x1650BF0
        public void set_ExperimentalMetrics(){} // RVA: 0x10CFD30
        public void get_SpotlightUrl(){} // RVA: 0x16591F0
        public void set_SpotlightUrl(){} // RVA: 0x1659200
        public void get_EnableSpotlight(){} // RVA: 0x1F7F9C0
        public void set_EnableSpotlight(){} // RVA: 0x6E161B0
        public void get_SettingLocator(){} // RVA: 0x166A290
        public void set_SettingLocator(){} // RVA: 0x1649580
        public void get_InitNativeSdks(){} // RVA: 0x6E161C0
        public void set_InitNativeSdks(){} // RVA: 0x6E161D0
        public void get_PostInitCallbacks(){} // RVA: 0x164B8F0
        public void set_PostInitCallbacks(){} // RVA: 0x1657130
        public void .ctor(){} // RVA: 0x6E161E0
        public void AddIntegration(){} // RVA: 0x6E18280
        public void RemoveIntegration(){} // RVA: 0x894290
        public void AddExceptionFilter(){} // RVA: 0x6E18320
        public void RemoveExceptionFilter(){} // RVA: 0x29A6DF0
        public void AddExceptionFilterForType(){} // RVA: 0x894290
        public void AddInAppExclude(){} // RVA: 0x6E185F0
        public void AddInAppExcludeRegex(){} // RVA: 0x6E187A0
        public void AddInAppInclude(){} // RVA: 0x6E18B50
        public void AddInAppIncludeRegex(){} // RVA: 0x6E18D00
        public void AddExceptionProcessor(){} // RVA: 0x6E18F00
        public void AddExceptionProcessors(){} // RVA: 0x6E190F0
        public void AddEventProcessor(){} // RVA: 0x6E192D0
        public void AddEventProcessors(){} // RVA: 0x6E194C0
        public void RemoveEventProcessor(){} // RVA: 0x894290
        public void AddEventProcessorProvider(){} // RVA: 0x6E196A0
        public void AddTransactionProcessor(){} // RVA: 0x6E19700
        public void AddTransactionProcessors(){} // RVA: 0x6E19810
        public void RemoveTransactionProcessor(){} // RVA: 0x894290
        public void AddTransactionProcessorProvider(){} // RVA: 0x6E19980
        public void AddExceptionProcessorProvider(){} // RVA: 0x6E19B80
        public void GetAllEventProcessors(){} // RVA: 0x6E19BE0
        public void GetAllTransactionProcessors(){} // RVA: 0x6E19D50
        public void GetAllExceptionProcessors(){} // RVA: 0x6E19EC0
        public void UseStackTraceFactory(){} // RVA: 0x6E1A030
        public void ApplyDefaultTags(){} // RVA: 0x6E1A260
        public void DisableDuplicateEventDetection(){} // RVA: 0x6E1A680
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x6E1A6C0
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x6E1A6D0
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x6E1A6E0
        public void HasIntegration(){} // RVA: 0x87D280
        public void RemoveDefaultIntegration(){} // RVA: 0x6E1A6F0
        public void SetupLogging(){} // RVA: 0x6E1A700
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x6E1A930
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x6E1AC40
        public void <.ctor>b__346_0(){} // RVA: 0x6E1AC50
        public void <.ctor>b__346_5(){} // RVA: 0x6E1AD80
        public void <.ctor>b__346_1(){} // RVA: 0x6E1ADD0
        public void <.ctor>b__346_2(){} // RVA: 0x6E1AE30
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x6E14320
        public void <.ctor>b__346_6(){} // RVA: 0x6E1AEC0
        public void <.ctor>b__346_7(){} // RVA: 0x6E1B010
        public void <.ctor>b__346_8(){} // RVA: 0x6E1B210
        public void <.ctor>b__346_10(){} // RVA: 0x6E1B380
        public void <.ctor>b__346_11(){} // RVA: 0x6E1B4C0
        public void <.ctor>b__346_4(){} // RVA: 0x6E1B630
    }

    public class SentryPackage : Object
    {
        public object _name;
        public object _version;

        // ── Methods ──
        public void get_Name(){} // RVA: 0xB5DBF0
        public void get_Version(){} // RVA: 0xB465B0
        public void .ctor(){} // RVA: 0x17C92C0
        public void WriteTo(){} // RVA: 0x6E1C2E0
        public void FromJson(){} // RVA: 0x6E1C4D0
        public void GetHashCode(){} // RVA: 0x6E1C880
        public void Equals(){} // RVA: 0x6E1C8F0
    }

    public class SentryPropagationContext : Object
    {
        public object _traceId;
        public object _spanId;
        public object _parentSpanId;
        public object _dynamicSamplingContext;

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x22343B0
        public void get_SpanId(){} // RVA: 0xB700F0
        public void get_ParentSpanId(){} // RVA: 0x19F92B0
        public void GetOrCreateDynamicSamplingContext(){} // RVA: 0x6E1CA10
        public void .ctor(){} // RVA: 0x6E1CE10
        public void CreateFromHeaders(){} // RVA: 0x6E1CF70
    }

    public class SentryRequest : Object
    {
        public object _internalEnv;
        public object _internalOther;
        public object _internalHeaders;
        public object _url;
        public object _method;
        public object _apiTarget;
        public object _data;
        public object _queryString;
        public object _cookies;

        // ── Methods ──
        public void get_InternalEnv(){} // RVA: 0xB5DBF0
        public void set_InternalEnv(){} // RVA: 0xB44D60
        public void get_InternalOther(){} // RVA: 0xB465B0
        public void set_InternalOther(){} // RVA: 0xBA9BA0
        public void get_InternalHeaders(){} // RVA: 0xB700F0
        public void set_InternalHeaders(){} // RVA: 0xB70100
        public void get_Url(){} // RVA: 0xB70160
        public void set_Url(){} // RVA: 0xB44DC0
        public void get_Method(){} // RVA: 0xD33E60
        public void set_Method(){} // RVA: 0xB708C0
        public void get_ApiTarget(){} // RVA: 0xD05CA0
        public void set_ApiTarget(){} // RVA: 0xD09D70
        public void get_Data(){} // RVA: 0xBC1B30
        public void set_Data(){} // RVA: 0xB6A8C0
        public void get_QueryString(){} // RVA: 0xBBF8F0
        public void set_QueryString(){} // RVA: 0xBBF900
        public void get_Cookies(){} // RVA: 0xBE58B0
        public void set_Cookies(){} // RVA: 0xCA4DF0
        public void get_Headers(){} // RVA: 0x6E1D180
        public void get_Env(){} // RVA: 0x6E1D240
        public void get_Other(){} // RVA: 0x6E1D300
        public void AddHeaders(){} // RVA: 0x6E1D3C0
        public void Clone(){} // RVA: 0x6E1D6B0
        public void CopyTo(){} // RVA: 0x6E1D710
        public void WriteTo(){} // RVA: 0x6E1D9B0
        public void FromJson(){} // RVA: 0x6E1DDA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SentrySdk : Object
    {
        public object CurrentHub;

        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x6E1E6B0
        public void get_LastEventId(){} // RVA: 0x6E1E710
        public void InitHub(){} // RVA: 0x6E1E7B0
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x6E1EDA0
        public void Init(){} // RVA: 0x6E1F270
        public void UseHub(){} // RVA: 0x6E1F410
        public void Flush(){} // RVA: 0x6E1F650
        public void FlushAsync(){} // RVA: 0x6E1F710
        public void Close(){} // RVA: 0x6E1F7A0
        public void get_IsEnabled(){} // RVA: 0x6E1F930
        public void PushScope(){} // RVA: 0x6E1F9B0
        public void BindClient(){} // RVA: 0x6E1FA30
        public void AddBreadcrumb(){} // RVA: 0x6E1FC10
        public void ConfigureScope(){} // RVA: 0x6E1FC80
        public void ConfigureScopeAsync(){} // RVA: 0x6E1FD00
        public void CaptureEnvelope(){} // RVA: 0x6E1FD80
        public void CaptureEvent(){} // RVA: 0x6E1FFA0
        public void CaptureException(){} // RVA: 0x6E200E0
        public void CaptureMessage(){} // RVA: 0x6E202C0
        public void CaptureUserFeedback(){} // RVA: 0x6E203F0
        public void CaptureTransaction(){} // RVA: 0x6E20570
        public void CaptureSession(){} // RVA: 0x6E20610
        public void CaptureCheckIn(){} // RVA: 0x6E20690
        public void StartTransaction(){} // RVA: 0x6E20B10
        public void BindException(){} // RVA: 0x6E20BA0
        public void GetSpan(){} // RVA: 0x6E20C30
        public void GetTraceHeader(){} // RVA: 0x6E20CB0
        public void GetBaggage(){} // RVA: 0x6E20D30
        public void ContinueTrace(){} // RVA: 0x6E20EF0
        public void get_Metrics(){} // RVA: 0x6E21030
        public void StartSession(){} // RVA: 0x6E210B0
        public void EndSession(){} // RVA: 0x6E21130
        public void PauseSession(){} // RVA: 0x6E211C0
        public void ResumeSession(){} // RVA: 0x6E21240
        public void CauseCrash(){} // RVA: 0x6E212C0
        public void .cctor(){} // RVA: 0x6E218F0
    }

    public class SentrySession : Object
    {
        public object _id;
        public object _distinctId;
        public object _startTimestamp;
        public object _release;
        public object _environment;
        public object _ipAddress;
        public object _userAgent;
        public object _errorCount;
        public object _sequenceNumber;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x22343B0
        public void get_DistinctId(){} // RVA: 0xB700F0
        public void get_StartTimestamp(){} // RVA: 0x19F92B0
        public void get_Release(){} // RVA: 0xD05CA0
        public void get_Environment(){} // RVA: 0xBC1B30
        public void get_IpAddress(){} // RVA: 0xBBF8F0
        public void get_UserAgent(){} // RVA: 0xBE58B0
        public void get_ErrorCount(){} // RVA: 0x12BB630
        public void .ctor(){} // RVA: 0x6E21DA0
        public void ReportError(){} // RVA: 0x6E21F10
        public void CreateUpdate(){} // RVA: 0x6E21F20
    }

    public class SentrySpan : Object
    {
        public object _spanId;
        public object _parentSpanId;
        public object _traceId;
        public object _startTimestamp;
        public object _endTimestamp;
        public object _measurements;
        public object _operation;
        public object _description;
        public object _status;
        public object _isSampled;
        public object _tags;
        public object _extra;
        public object _metricsSummary;
        public object _origin;

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0xB5DBF0
        public void set_SpanId(){} // RVA: 0x2230E30
        public void get_ParentSpanId(){} // RVA: 0x125EE60
        public void set_ParentSpanId(){} // RVA: 0x125D9D0
        public void get_TraceId(){} // RVA: 0x19F92B0
        public void set_TraceId(){} // RVA: 0x19F35A0
        public void get_StartTimestamp(){} // RVA: 0x2237C00
        public void set_StartTimestamp(){} // RVA: 0x27FA8A0
        public void get_EndTimestamp(){} // RVA: 0x6E21FD0
        public void set_EndTimestamp(){} // RVA: 0x6E21FF0
        public void get_IsFinished(){} // RVA: 0x6E22010
        public void get_Measurements(){} // RVA: 0x6E22050
        public void SetMeasurement(){} // RVA: 0x6E22110
        public void get_Operation(){} // RVA: 0xBBFF90
        public void set_Operation(){} // RVA: 0xBBFFA0
        public void get_Description(){} // RVA: 0xC10050
        public void set_Description(){} // RVA: 0xC10060
        public void get_Status(){} // RVA: 0xCD3320
        public void set_Status(){} // RVA: 0x6529A50
        public void get_IsSampled(){} // RVA: 0x6A0D980
        public void set_IsSampled(){} // RVA: 0x6A8AF20
        public void get_Tags(){} // RVA: 0x6E22230
        public void SetTag(){} // RVA: 0x6E22300
        public void UnsetTag(){} // RVA: 0x6E22430
        public void get_Extra(){} // RVA: 0x6E22530
        public void SetExtra(){} // RVA: 0x6E22600
        public void .ctor(){} // RVA: 0x6E228F0
        public void GetTraceHeader(){} // RVA: 0x6E22F60
        public void WriteTo(){} // RVA: 0x6E22FD0
        public void FromJson(){} // RVA: 0x6E23600
        public void Redact(){} // RVA: 0x6E24870
        public void get_Origin(){} // RVA: 0x106A050
        public void set_Origin(){} // RVA: 0x6E24920
    }

    public class SentryStackFrame : Object
    {
        public object LazyModuleMatcher;
        public object LazyFunctionMatcher;
        public object _internalPreContext;
        public object _internalPostContext;
        public object _internalVars;
        public object _internalFramesOmitted;
        public object _isCodeLocation;
        public object _fileName;
        public object _function;
        public object _module;
        public object _lineNumber;
        public object _columnNumber;
        public object _absolutePath;
        public object _contextLine;
        public object _inApp;
        public object _package;
        public object _platform;
        public object _imageAddress;
        public object _symbolAddress;
        public object _instructionAddress;
        public object _addressMode;
        public object _functionId;

        // ── Methods ──
        public void get_InternalPreContext(){} // RVA: 0xB5DBF0
        public void set_InternalPreContext(){} // RVA: 0xB44D60
        public void get_InternalPostContext(){} // RVA: 0xB465B0
        public void set_InternalPostContext(){} // RVA: 0xBA9BA0
        public void get_InternalVars(){} // RVA: 0xB700F0
        public void set_InternalVars(){} // RVA: 0xB70100
        public void get_InternalFramesOmitted(){} // RVA: 0xB70160
        public void set_InternalFramesOmitted(){} // RVA: 0xB44DC0
        public void get_IsCodeLocation(){} // RVA: 0xB68DF0
        public void set_IsCodeLocation(){} // RVA: 0xB68E00
        public void get_FileName(){} // RVA: 0xD05CA0
        public void set_FileName(){} // RVA: 0xD09D70
        public void get_Function(){} // RVA: 0xBC1B30
        public void set_Function(){} // RVA: 0xB6A8C0
        public void get_Module(){} // RVA: 0xBBF8F0
        public void set_Module(){} // RVA: 0xBBF900
        public void get_LineNumber(){} // RVA: 0xBE58B0
        public void set_LineNumber(){} // RVA: 0xE9E640
        public void get_ColumnNumber(){} // RVA: 0xC0FFC0
        public void set_ColumnNumber(){} // RVA: 0xEA1CE0
        public void get_AbsolutePath(){} // RVA: 0xBE2C60
        public void set_AbsolutePath(){} // RVA: 0xBE2C70
        public void get_ContextLine(){} // RVA: 0xBBFF90
        public void set_ContextLine(){} // RVA: 0xBBFFA0
        public void get_PreContext(){} // RVA: 0x6E24A20
        public void get_PostContext(){} // RVA: 0x6E24AE0
        public void get_InApp(){} // RVA: 0x6E24BA0
        public void set_InApp(){} // RVA: 0x6E24BB0
        public void get_Vars(){} // RVA: 0x6E24BC0
        public void get_FramesOmitted(){} // RVA: 0x6E24C80
        public void get_Package(){} // RVA: 0xCD3320
        public void set_Package(){} // RVA: 0xCD4740
        public void get_Platform(){} // RVA: 0xCD48B0
        public void set_Platform(){} // RVA: 0xCD3600
        public void get_ImageAddress(){} // RVA: 0x6D099E0
        public void set_ImageAddress(){} // RVA: 0x6D099F0
        public void get_SymbolAddress(){} // RVA: 0x28C1AE0
        public void set_SymbolAddress(){} // RVA: 0x28C1AF0
        public void get_InstructionAddress(){} // RVA: 0x6E24D40
        public void set_InstructionAddress(){} // RVA: 0x6E24D50
        public void get_AddressMode(){} // RVA: 0xBAE3B0
        public void set_AddressMode(){} // RVA: 0xBAE3C0
        public void get_FunctionId(){} // RVA: 0x6E24D60
        public void set_FunctionId(){} // RVA: 0x6E24D70
        public void WriteTo(){} // RVA: 0x6E24D80
        public void ConfigureAppFrame(){} // RVA: 0x6E25D70
        public void FromJson(){} // RVA: 0x6E25E20
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6E27A20
    }

    public class SentryStackTrace : Object
    {
        public object _internalFrames;
        public object _addressAdjustment;

        // ── Methods ──
        public void get_InternalFrames(){} // RVA: 0xB5DBF0
        public void set_InternalFrames(){} // RVA: 0xB44D60
        public void get_Frames(){} // RVA: 0x6E27E90
        public void set_Frames(){} // RVA: 0xB44D60
        public void get_AddressAdjustment(){} // RVA: 0xB465B0
        public void set_AddressAdjustment(){} // RVA: 0x15428E0
        public void WriteTo(){} // RVA: 0x6E27F50
        public void FromJson(){} // RVA: 0x6E28130
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SentryThread : Object
    {
        public object _id;
        public object _name;
        public object _crashed;
        public object _current;
        public object _stacktrace;

        // ── Methods ──
        public void get_Id(){} // RVA: 0xB5DBF0
        public void set_Id(){} // RVA: 0x2230E30
        public void get_Name(){} // RVA: 0xB465B0
        public void set_Name(){} // RVA: 0xBA9BA0
        public void get_Crashed(){} // RVA: 0x4FEF950
        public void set_Crashed(){} // RVA: 0x653B850
        public void get_Current(){} // RVA: 0x653B860
        public void set_Current(){} // RVA: 0x653B870
        public void get_Stacktrace(){} // RVA: 0xB70160
        public void set_Stacktrace(){} // RVA: 0xB44DC0
        public void WriteTo(){} // RVA: 0x6E28680
        public void FromJson(){} // RVA: 0x6E28A70
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SentryTraceHeader : Object
    {
        public object HttpHeaderName;
        public object Empty;
        public object _traceId;
        public object _spanId;
        public object _isSampled;

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x22343B0
        public void get_SpanId(){} // RVA: 0xB700F0
        public void get_IsSampled(){} // RVA: 0x4FF5720
        public void .ctor(){} // RVA: 0x6E29160
        public void ToString(){} // RVA: 0x6E29180
        public void Parse(){} // RVA: 0x6E29340
        public void .cctor(){} // RVA: 0x6E29710
    }

    public class SentryTransaction : Object
    {
        public object _eventId;
        public object _name;
        public object _nameSource;
        public object _isParentSampled;
        public object _platform;
        public object _release;
        public object _distribution;
        public object _startTimestamp;
        public object _endTimestamp;
        public object _measurements;
        public object _sampleRate;
        public object _level;
        public object _request;
        public object _contexts;
        public object _user;
        public object _environment;
        public object _sdk;
        public object _fingerprint;
        public object _breadcrumbs;
        public object _extra;
        public object _tags;
        public object _spans;
        public object _metricsSummary;
        public object _dynamicSamplingContext;
        public object _transactionProfiler;

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x22343B0
        public void set_EventId(){} // RVA: 0x22343C0
        public void get_SpanId(){} // RVA: 0x6E29840
        public void set_SpanId(){} // RVA: 0x6E298B0
        public void get_Origin(){} // RVA: 0x6E29930
        public void set_Origin(){} // RVA: 0x6E299A0
        public void get_ParentSpanId(){} // RVA: 0x6E29A30
        public void set_ParentSpanId(){} // RVA: 0x6E29AC0
        public void get_TraceId(){} // RVA: 0x6E29B40
        public void set_TraceId(){} // RVA: 0x6E29BD0
        public void get_Name(){} // RVA: 0xB700F0
        public void set_Name(){} // RVA: 0xB70100
        public void get_NameSource(){} // RVA: 0x1065D50
        public void get_IsParentSampled(){} // RVA: 0x6E29C50
        public void set_IsParentSampled(){} // RVA: 0x6E29C60
        public void get_Platform(){} // RVA: 0xD33E60
        public void set_Platform(){} // RVA: 0xB708C0
        public void get_Release(){} // RVA: 0xD05CA0
        public void set_Release(){} // RVA: 0xD09D70
        public void get_Distribution(){} // RVA: 0xBC1B30
        public void set_Distribution(){} // RVA: 0xB6A8C0
        public void get_StartTimestamp(){} // RVA: 0x1767370
        public void set_StartTimestamp(){} // RVA: 0x1767360
        public void get_EndTimestamp(){} // RVA: 0xB4CE00
        public void set_EndTimestamp(){} // RVA: 0xB4CE20
        public void get_Measurements(){} // RVA: 0x6E29C70
        public void SetMeasurement(){} // RVA: 0x6E29D30
        public void get_Operation(){} // RVA: 0x6E29E50
        public void set_Operation(){} // RVA: 0x6E29EC0
        public void get_Description(){} // RVA: 0x6E29F90
        public void set_Description(){} // RVA: 0x6E2A000
        public void get_Status(){} // RVA: 0x6E2A0D0
        public void set_Status(){} // RVA: 0x6E2A140
        public void get_IsSampled(){} // RVA: 0x6E2A1C0
        public void set_IsSampled(){} // RVA: 0x6E2A230
        public void get_SampleRate(){} // RVA: 0x6296990
        public void set_SampleRate(){} // RVA: 0x62969A0
        public void get_Level(){} // RVA: 0x14780B0
        public void set_Level(){} // RVA: 0x147EE80
        public void get_Request(){} // RVA: 0x6E2A360
        public void set_Request(){} // RVA: 0xD5CC10
        public void get_Contexts(){} // RVA: 0x106A7D0
        public void set_Contexts(){} // RVA: 0x6E2A400
        public void get_User(){} // RVA: 0x6E2A430
        public void set_User(){} // RVA: 0xD5CCD0
        public void get_Environment(){} // RVA: 0x12EB090
        public void set_Environment(){} // RVA: 0x13B1040
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0xB700F0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x6E2A4D0
        public void get_Sdk(){} // RVA: 0xBAE340
        public void set_Sdk(){} // RVA: 0xBAE350
        public void get_Fingerprint(){} // RVA: 0x6E2A580
        public void set_Fingerprint(){} // RVA: 0xBAE3C0
        public void get_Breadcrumbs(){} // RVA: 0xBAE420
        public void get_Extra(){} // RVA: 0xCA4D80
        public void get_Tags(){} // RVA: 0xC68EB0
        public void get_Spans(){} // RVA: 0x135D730
        public void get_IsFinished(){} // RVA: 0x6E2A5D0
        public void get_DynamicSamplingContext(){} // RVA: 0xBC5BA0
        public void set_DynamicSamplingContext(){} // RVA: 0xBC5BB0
        public void get_TransactionProfiler(){} // RVA: 0xBAE5A0
        public void set_TransactionProfiler(){} // RVA: 0xBAE5B0
        public void .ctor(){} // RVA: 0x6E2AEE0
        public void FromTracerSpans(){} // RVA: 0x6E2BC30
        public void AddBreadcrumb(){} // RVA: 0x6E2C650
        public void SetExtra(){} // RVA: 0x6E2C6B0
        public void SetTag(){} // RVA: 0x6E2C740
        public void UnsetTag(){} // RVA: 0x6E2C7D0
        public void GetTraceHeader(){} // RVA: 0x6E2C830
        public void Redact(){} // RVA: 0x6E2C920
        public void WriteTo(){} // RVA: 0x6E2CE50
        public void FromJson(){} // RVA: 0x6E2DA70
    }

    public class SentryUser : Object
    {
        public object _propertyChanged;
        public object _id;
        public object _username;
        public object _email;
        public object _ipAddress;
        public object _segment;
        public object _other;

        // ── Methods ──
        public void get_PropertyChanged(){} // RVA: 0xB5DBF0
        public void set_PropertyChanged(){} // RVA: 0xB44D60
        public void get_Id(){} // RVA: 0xB465B0
        public void set_Id(){} // RVA: 0x6E2FE00
        public void get_Username(){} // RVA: 0xB700F0
        public void set_Username(){} // RVA: 0x6E2FEC0
        public void get_Email(){} // RVA: 0xB70160
        public void set_Email(){} // RVA: 0x6E2FF80
        public void get_IpAddress(){} // RVA: 0xD33E60
        public void set_IpAddress(){} // RVA: 0x6E30040
        public void get_Segment(){} // RVA: 0xD05CA0
        public void set_Segment(){} // RVA: 0x6E30100
        public void get_Other(){} // RVA: 0x6E301C0
        public void set_Other(){} // RVA: 0x6E30280
        public void Clone(){} // RVA: 0x6E302F0
        public void CopyTo(){} // RVA: 0x6E30350
        public void HasAnyData(){} // RVA: 0x6E30610
        public void WriteTo(){} // RVA: 0x6E30690
        public void FromJson(){} // RVA: 0x6E30A30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SentryValues`1 : Object
    {
        public object _values;

        // ── Methods ──
        public void get_Values(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894320
        public void WriteTo(){} // RVA: 0x8943B0
    }

    public class SessionUpdate : Object
    {
        public object _id;
        public object _distinctId;
        public object _startTimestamp;
        public object _release;
        public object _environment;
        public object _ipAddress;
        public object _userAgent;
        public object _errorCount;
        public object _isInitial;
        public object _timestamp;
        public object _sequenceNumber;
        public object _endStatus;

        // ── Methods ──
        public void get_Id(){} // RVA: 0x22343B0
        public void get_DistinctId(){} // RVA: 0xB700F0
        public void get_StartTimestamp(){} // RVA: 0x19F92B0
        public void get_Release(){} // RVA: 0xD05CA0
        public void get_Environment(){} // RVA: 0xBC1B30
        public void get_IpAddress(){} // RVA: 0xBBF8F0
        public void get_UserAgent(){} // RVA: 0xBE58B0
        public void get_ErrorCount(){} // RVA: 0x12BB630
        public void get_IsInitial(){} // RVA: 0xBE2B30
        public void get_Timestamp(){} // RVA: 0x4127D80
        public void get_SequenceNumber(){} // RVA: 0x19C6270
        public void get_Duration(){} // RVA: 0x6E31140
        public void get_EndStatus(){} // RVA: 0x6E311C0
        public void .ctor(){} // RVA: 0x6E31620
        public void WriteTo(){} // RVA: 0x6E31660
        public void FromJson(){} // RVA: 0x6E31F00
    }

    public class SpanContext : Object
    {
        public object _spanId;
        public object _parentSpanId;
        public object _traceId;
        public object _operation;
        public object _description;
        public object _status;
        public object _isSampled;
        public object _instrumenter;
        public object _origin;

        // ── Methods ──
        public void get_SpanId(){} // RVA: 0xB5DBF0
        public void get_ParentSpanId(){} // RVA: 0x125EE60
        public void get_TraceId(){} // RVA: 0x19F92B0
        public void get_Operation(){} // RVA: 0xD05CA0
        public void set_Operation(){} // RVA: 0xD09D70
        public void get_Description(){} // RVA: 0xBC1B30
        public void get_Status(){} // RVA: 0xBBF8F0
        public void get_IsSampled(){} // RVA: 0x4CCE2D0
        public void get_Instrumenter(){} // RVA: 0x15443F0
        public void set_Instrumenter(){} // RVA: 0x15443E0
        public void get_Origin(){} // RVA: 0xC0FFC0
        public void set_Origin(){} // RVA: 0x6E33580
        public void .ctor(){} // RVA: 0x6E33680
    }

    public class SpanDataExtensions : Object
    {
        // ── Methods ──
        public void SetMeasurement(){} // RVA: 0x6D18890
    }

    public class SpanExtensions : Object
    {
        // ── Methods ──
        public void StartChild(){} // RVA: 0x6D17C50
        public void GetTransaction(){} // RVA: 0x6D17E90
        public void GetDbParentSpan(){} // RVA: 0x6D17F80
    }

    public class SpanId : ValueType
    {
        public object HexChars;
        public object Random;
        public object _value;
        public object Empty;

        // ── Methods ──
        public void GetValue(){} // RVA: 0x77900
        public void .ctor(){} // RVA: 0x93050
        public void Equals(){} // RVA: 0x8F50B0
        public void GetHashCode(){} // RVA: 0x8F50C0
        public void ToString(){} // RVA: 0x8F50D0
        public void Create(){} // RVA: 0x6E33C80
        public void WriteTo(){} // RVA: 0x8F50E0
        public void Parse(){} // RVA: 0x6E34100
        public void FromJson(){} // RVA: 0x6E34130
        public void op_Equality(){} // RVA: 0x6E342B0
        public void op_Inequality(){} // RVA: 0x6E34340
        public void op_Implicit(){} // RVA: 0x6E343B0
        public void .cctor(){} // RVA: 0x6E34400
    }

    public class SpanStatusConverter : Object
    {
        // ── Methods ──
        public void FromException(){} // RVA: 0x6E34590
        public void FromHttpStatusCode(){} // RVA: 0x6E34810
        public void FromGrpcStatusCode(){} // RVA: 0x6E348D0
    }

    public class SpanTracer : Object
    {
        public object _hub;
        public object _stopwatch;
        public object _instrumenter;
        public object _transaction;
        public object _metricsSummary;
        public object _spanId;
        public object _parentSpanId;
        public object _traceId;
        public object _startTimestamp;
        public object _endTimestamp;
        public object _internalMeasurements;
        public object _operation;
        public object _description;
        public object _status;
        public object _isSentryRequest;
        public object _isSampled;
        public object _internalTags;
        public object _data;
        public object _isFiltered;
        public object _origin;

        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x6E349A0
        public void get_Transaction(){} // RVA: 0xD05CA0
        public void get_MetricsSummary(){} // RVA: 0x6E349B0
        public void get_HasMetrics(){} // RVA: 0x6E34A00
        public void get_SpanId(){} // RVA: 0xBBF8F0
        public void set_SpanId(){} // RVA: 0x20633C0
        public void get_ParentSpanId(){} // RVA: 0x4CBDC80
        public void set_ParentSpanId(){} // RVA: 0x65B4B90
        public void get_TraceId(){} // RVA: 0x4127D80
        public void get_StartTimestamp(){} // RVA: 0x6A8AF00
        public void set_StartTimestamp(){} // RVA: 0x6A8AF10
        public void get_EndTimestamp(){} // RVA: 0x1719D00
        public void set_EndTimestamp(){} // RVA: 0x17184E0
        public void get_IsFinished(){} // RVA: 0x6E34A50
        public void get_InternalMeasurements(){} // RVA: 0x106A7D0
        public void set_InternalMeasurements(){} // RVA: 0xD5CC70
        public void get_Measurements(){} // RVA: 0x6E34A90
        public void SetMeasurement(){} // RVA: 0x6E34B60
        public void get_Operation(){} // RVA: 0x106A050
        public void set_Operation(){} // RVA: 0xD5CCD0
        public void get_Description(){} // RVA: 0x12EB090
        public void set_Description(){} // RVA: 0x13B1040
        public void get_Status(){} // RVA: 0xBAE340
        public void set_Status(){} // RVA: 0x2443FC0
        public void get_IsSentryRequest(){} // RVA: 0x20119F0
        public void set_IsSentryRequest(){} // RVA: 0x2013510
        public void get_IsSampled(){} // RVA: 0x6E34C90
        public void set_IsSampled(){} // RVA: 0x6E34CA0
        public void get_InternalTags(){} // RVA: 0xBAE420
        public void set_InternalTags(){} // RVA: 0xBAE430
        public void get_Tags(){} // RVA: 0x6E34CB0
        public void SetTag(){} // RVA: 0x6E34D80
        public void UnsetTag(){} // RVA: 0x6E34EA0
        public void get_Extra(){} // RVA: 0xCA4D80
        public void SetExtra(){} // RVA: 0x6E35010
        public void get_IsFiltered(){} // RVA: 0xC68EB0
        public void set_IsFiltered(){} // RVA: 0xC68EC0
        public void .ctor(){} // RVA: 0x6E353A0
        public void StartChild(){} // RVA: 0x6E356B0
        public void Unfinish(){} // RVA: 0x6E35700
        public void Finish(){} // RVA: 0x6E35D60
        public void GetTraceHeader(){} // RVA: 0x6E35DA0
        public void get_Origin(){} // RVA: 0x135D730
        public void set_Origin(){} // RVA: 0x6E35E10
    }

    public class StreamAttachmentContent : Object
    {
        public object _stream;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetStream(){} // RVA: 0xB5DBF0
    }

    public class SubstringOrRegexPattern : Object
    {
        public object _regex;
        public object _substring;
        public object _stringComparison;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void op_Implicit(){} // RVA: 0x6E36050
        public void ToString(){} // RVA: 0x6E360E0
        public void Equals(){} // RVA: 0x6E36150
        public void GetHashCode(){} // RVA: 0x273F540
        public void get_Regex(){} // RVA: 0xB5DBF0
        public void IsMatch(){} // RVA: 0x6E36240
        public void TryParseRegex(){} // RVA: 0x6E363E0
    }

    public class SubstringOrRegexPatternExtensions : Object
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x6E36490
        public void WithConfigBinding(){} // RVA: 0x87C5C0
    }

    public class SubstringOrRegexPatternTypeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x6E365B0
        public void ConvertFrom(){} // RVA: 0x6E36630
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SubstringOrRegexPattern[] : Array
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

}