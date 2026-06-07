// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 44
// Methods: 986

namespace ThirdParty.Sentry.Sentry
{
    public class Scope
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x2F8380
        public void get_Locked(){} // RVA: 0x2F84E0
        public void set_Locked(){} // RVA: 0x2F84F0
        public void get_LastEventId(){} // RVA: 0x62B67D0
        public void set_LastEventId(){} // RVA: 0x62B6920
        public void get_HasEvaluated(){} // RVA: 0x62B6A60
        public void get_ExceptionProcessors(){} // RVA: 0x62B6A70
        public void get_EventProcessors(){} // RVA: 0x62B6AC0
        public void get_TransactionProcessors(){} // RVA: 0x62B6B10
        public void add_OnEvaluating(){} // RVA: 0x62B6B60
        public void remove_OnEvaluating(){} // RVA: 0x62B6C60
        public void get_Level(){} // RVA: 0x1C91440
        public void set_Level(){} // RVA: 0x1C91450
        public void get_Request(){} // RVA: 0x62B6D60
        public void set_Request(){} // RVA: 0x3A55A0
        public void get_Contexts(){} // RVA: 0x4C7C50
        public void set_Contexts(){} // RVA: 0x62B6E00
        public void get_UserChanged(){} // RVA: 0x62B6E20
        public void get_User(){} // RVA: 0x62B6EA0
        public void set_User(){} // RVA: 0x62B6FC0
        public void get_Release(){} // RVA: 0x31C010
        public void set_Release(){} // RVA: 0x463060
        public void get_Distribution(){} // RVA: 0x796DE0
        public void set_Distribution(){} // RVA: 0xB54600
        public void get_Environment(){} // RVA: 0xA1C8C0
        public void set_Environment(){} // RVA: 0x9AA650
        public void get_TransactionName(){} // RVA: 0x62B7090
        public void set_TransactionName(){} // RVA: 0x62B70F0
        public void get_Transaction(){} // RVA: 0xA1C130
        public void set_Transaction(){} // RVA: 0xAE5030
        public void get_PropagationContext(){} // RVA: 0x348040
        public void set_PropagationContext(){} // RVA: 0x348050
        public void get_SessionUpdate(){} // RVA: 0x3480B0
        public void set_SessionUpdate(){} // RVA: 0x3480C0
        public void get_Sdk(){} // RVA: 0x348120
        public void get_Fingerprint(){} // RVA: 0x435460
        public void set_Fingerprint(){} // RVA: 0x435470
        public void get_Breadcrumbs(){} // RVA: 0x3FA100
        public void get_Extra(){} // RVA: 0xA96D30
        public void get_Tags(){} // RVA: 0x35E900
        public void get_Attachments(){} // RVA: 0x35E970
        public void .ctor(){} // RVA: 0x62B7B00 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x62B7BE0 | overloaded x2
        public void SetExtra(){} // RVA: 0x62B7E10
        public void SetTag(){} // RVA: 0x62B7EC0
        public void UnsetTag(){} // RVA: 0x62B8070
        public void AddAttachment(){} // RVA: 0x62BBBE0 | overloaded x4
        public void Clear(){} // RVA: 0x62B81E0
        public void ClearAttachments(){} // RVA: 0x62B8820
        public void ClearBreadcrumbs(){} // RVA: 0x62B88D0
        public void Apply(){} // RVA: 0x62B9EF0 | overloaded x3
        public void Clone(){} // RVA: 0x62B9FD0
        public void Evaluate(){} // RVA: 0x62BA840
        public void get_Span(){} // RVA: 0x62BAAE0
        public void set_Span(){} // RVA: 0x3482B0
        public void GetAllEventProcessors(){} // RVA: 0x62BABD0
        public void GetAllTransactionProcessors(){} // RVA: 0x62BAC80
        public void GetAllExceptionProcessors(){} // RVA: 0x62BAD30
        public void AddExceptionProcessor(){} // RVA: 0x62BADE0
        public void AddExceptionProcessors(){} // RVA: 0x62BAE70
        public void AddEventProcessor(){} // RVA: 0x62BB140 | overloaded x2
        public void AddEventProcessors(){} // RVA: 0x62BB260
        public void AddTransactionProcessor(){} // RVA: 0x62BB530 | overloaded x2
        public void AddTransactionProcessors(){} // RVA: 0x62BB650
        public void ResetTransaction(){} // RVA: 0x62BBD60
        public void <get_UserChanged>b__41_0(){} // RVA: 0x62BBDC0
    }

    public class SdkVersion
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6391B00
        public void get_InternalPackages(){} // RVA: 0x2F8380
        public void set_InternalPackages(){} // RVA: 0x2DEE30
        public void get_Integrations(){} // RVA: 0x2E07C0
        public void set_Integrations(){} // RVA: 0x343E80
        public void get_Packages(){} // RVA: 0x2F8380
        public void get_Name(){} // RVA: 0x30B0C0
        public void set_Name(){} // RVA: 0x30B0D0
        public void get_Version(){} // RVA: 0x30B130
        public void set_Version(){} // RVA: 0x2DEE90
        public void AddPackage(){} // RVA: 0x6391C40 | overloaded x2
        public void AddIntegration(){} // RVA: 0x6391CA0
        public void WriteTo(){} // RVA: 0x6391D00
        public void FromJson(){} // RVA: 0x6391F80
        public void .ctor(){} // RVA: 0x6392B80
        public void .cctor(){} // RVA: 0x6392CE0
    }

    public class SentryAttachment
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x32A5C0
        public void get_Content(){} // RVA: 0x2E07C0
        public void get_FileName(){} // RVA: 0x30B0C0
        public void get_ContentType(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x5BFA280
    }

    public class SentryCheckIn
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x196ABE0
        public void get_MonitorSlug(){} // RVA: 0x30B0C0
        public void get_Status(){} // RVA: 0x791DC0
        public void get_Duration(){} // RVA: 0x5CC8940
        public void set_Duration(){} // RVA: 0x5CC8950
        public void get_Release(){} // RVA: 0x35A740
        public void set_Release(){} // RVA: 0x305200
        public void get_Environment(){} // RVA: 0x358730
        public void set_Environment(){} // RVA: 0x358740
        public void get_TraceId(){} // RVA: 0x42182F0
        public void set_TraceId(){} // RVA: 0x6393150
        public void get_MonitorOptions(){} // RVA: 0x358D50
        public void set_MonitorOptions(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x6393160
        public void WriteTo(){} // RVA: 0x63932B0
        public void ToSnakeCase(){} // RVA: 0x63937B0
    }

    public class SentryClient
    {
        // ── Methods ──
        public void get_Worker(){} // RVA: 0x6374D0
        public void get_Options(){} // RVA: 0x2F8380
        public void get_IsEnabled(){} // RVA: 0x3C2850
        public void .ctor(){} // RVA: 0x63938E0 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x6393EC0
        public void CaptureUserFeedback(){} // RVA: 0x6394070
        public void CaptureTransaction(){} // RVA: 0x6394370 | overloaded x2
        public void BeforeSendTransaction(){} // RVA: 0x6394FB0
        public void CaptureSession(){} // RVA: 0x63952B0
        public void CaptureCheckIn(){} // RVA: 0x6395440
        public void FlushAsync(){} // RVA: 0x6395A20
        public void DoSendEvent(){} // RVA: 0x6395A80
        public void ApplyExceptionFilters(){} // RVA: 0x6396EF0
        public void CaptureEnvelope(){} // RVA: 0x6397220
        public void BeforeSend(){} // RVA: 0x63973F0
        public void Dispose(){} // RVA: 0x63976F0
    }

    public class SentryClientExtensions
    {
        // ── Methods ──
        public void CaptureException(){} // RVA: 0x63979A0
        public void CaptureMessage(){} // RVA: 0x6397B10
        public void CaptureUserFeedback(){} // RVA: 0x6397CE0
        public void Flush(){} // RVA: 0x6397E60 | overloaded x2
        public void FlushAsync(){} // RVA: 0x6397F40
        public void get_SentryOptionsForTestingOnly(){} // RVA: 0x6397FE0
        public void set_SentryOptionsForTestingOnly(){} // RVA: 0x6398020
        public void GetSentryOptions(){} // RVA: 0x63980C0
    }

    public class SentryConstants
    {
    }

    public class SentryContexts
    {
        // ── Methods ──
        public void get_App(){} // RVA: 0x6398230
        public void get_Browser(){} // RVA: 0x6398290
        public void get_Device(){} // RVA: 0x63982F0
        public void get_OperatingSystem(){} // RVA: 0x6398350
        public void get_Response(){} // RVA: 0x63983B0
        public void get_Runtime(){} // RVA: 0x6398410
        public void get_Gpu(){} // RVA: 0x6398470
        public void get_Trace(){} // RVA: 0x63984D0
        public void .ctor(){} // RVA: 0x6398530
        public void Clone(){} // RVA: 0x6398670
        public void CopyTo(){} // RVA: 0x6399DD0 | overloaded x2
        public void WriteTo(){} // RVA: 0x6398A50
        public void FromJson(){} // RVA: 0x6398CD0
        public void ReplaceWith(){} // RVA: 0x6399820
        public void NullIfEmpty(){} // RVA: 0x6399AD0
        public void GetEnumerator(){} // RVA: 0x6399B30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x6399B80
        public void Add(){} // RVA: 0x639A020 | overloaded x2
        public void Clear(){} // RVA: 0x6399CA0
        public void Contains(){} // RVA: 0x6399CF0
        public void Remove(){} // RVA: 0x639A110 | overloaded x2
        public void get_Count(){} // RVA: 0x6399F80
        public void get_IsReadOnly(){} // RVA: 0x6399FD0
        public void ContainsKey(){} // RVA: 0x639A0B0
        public void TryGetValue(){} // RVA: 0x639A170
        public void get_Item(){} // RVA: 0x639A350
        public void set_Item(){} // RVA: 0x639A3B0
        public void get_Keys(){} // RVA: 0x639A420
        public void get_Values(){} // RVA: 0x639A480
    }

    public class SentryEvent
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x2E07C0
        public void get_EventId(){} // RVA: 0x1EFB630
        public void get_Timestamp(){} // RVA: 0x5CC8940
        public void get_Message(){} // RVA: 0x35A740
        public void set_Message(){} // RVA: 0x305200
        public void get_Logger(){} // RVA: 0x358730
        public void set_Logger(){} // RVA: 0x358740
        public void get_Platform(){} // RVA: 0x37E0E0
        public void set_Platform(){} // RVA: 0x4354D0
        public void get_ServerName(){} // RVA: 0x3A5500
        public void set_ServerName(){} // RVA: 0x3A5510
        public void get_Release(){} // RVA: 0x37B370
        public void set_Release(){} // RVA: 0x37B380
        public void get_Distribution(){} // RVA: 0x358D50
        public void set_Distribution(){} // RVA: 0x358D60
        public void get_SentryExceptionValues(){} // RVA: 0x3A5590
        public void set_SentryExceptionValues(){} // RVA: 0x3A55A0
        public void get_SentryExceptions(){} // RVA: 0x639A9B0
        public void set_SentryExceptions(){} // RVA: 0x639AA20
        public void get_SentryThreadValues(){} // RVA: 0x4C7C50
        public void set_SentryThreadValues(){} // RVA: 0x4C34F0
        public void get_SentryThreads(){} // RVA: 0x639AB50
        public void set_SentryThreads(){} // RVA: 0x639ABC0
        public void get_DebugImages(){} // RVA: 0x639ACF0
        public void set_DebugImages(){} // RVA: 0x639AD10
        public void get_Modules(){} // RVA: 0x639AE30
        public void get_Level(){} // RVA: 0xBB90C0
        public void set_Level(){} // RVA: 0xBB9E60
        public void get_TransactionName(){} // RVA: 0x796DE0
        public void set_TransactionName(){} // RVA: 0xB54600
        public void get_Request(){} // RVA: 0x639AEF0
        public void set_Request(){} // RVA: 0x9AA650
        public void get_Contexts(){} // RVA: 0xA085E0
        public void set_Contexts(){} // RVA: 0x639AF90
        public void get_User(){} // RVA: 0x639AFC0
        public void set_User(){} // RVA: 0xAE5030
        public void get_Environment(){} // RVA: 0x348040
        public void set_Environment(){} // RVA: 0x348050
        public void get_Sdk(){} // RVA: 0x3480B0
        public void set_Sdk(){} // RVA: 0x3480C0
        public void get_Fingerprint(){} // RVA: 0x639B060
        public void set_Fingerprint(){} // RVA: 0x348130
        public void get_Breadcrumbs(){} // RVA: 0x639B0B0
        public void get_Extra(){} // RVA: 0x639B180
        public void get_Tags(){} // RVA: 0x639B250
        public void HasException(){} // RVA: 0x639B320
        public void HasTerminalException(){} // RVA: 0x639B390
        public void get_DynamicSamplingContext(){} // RVA: 0x35E900
        public void set_DynamicSamplingContext(){} // RVA: 0x35E910
        public void .ctor(){} // RVA: 0x639B7B0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x639BBE0
        public void SetExtra(){} // RVA: 0x639BCE0
        public void SetTag(){} // RVA: 0x639BE10
        public void UnsetTag(){} // RVA: 0x639BF40
        public void Redact(){} // RVA: 0x639C040
        public void WriteTo(){} // RVA: 0x639C2A0
        public void FromJson(){} // RVA: 0x639CAF0 | overloaded x2
    }

    public class SentryFailedRequestHandler
    {
        // ── Methods ──
        public void get_Hub(){} // RVA: 0x2F8380
        public void get_Options(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x2DC60
        public void HandleResponse(){} // RVA: 0x639F380
    }

    public class SentryGraphQLHttpFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x639F5A0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x639F720
    }

    public class SentryGraphQLHttpMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x639FFB0 | overloaded x2
        public void ProcessRequest(){} // RVA: 0x63A0340
        public void HandleResponse(){} // RVA: 0x63A0700
        public void GetSpanDescriptionOrDefault(){} // RVA: 0x63A0DE0
        public void AddIfExists(){} // RVA: 0x63A0FF0
    }

    public class SentryHint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63A1310 | overloaded x3
        public void get_Attachments(){} // RVA: 0x2E07C0
        public void get_Items(){} // RVA: 0x63A1440
        public void AddAttachmentsFromScope(){} // RVA: 0x63A1500
        public void AddAttachment(){} // RVA: 0x63A1700 | overloaded x2
        public void WithAttachments(){} // RVA: 0x63A18E0 | overloaded x2
    }

    public class SentryHttpFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63A1980
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x63A1990
    }

    public class SentryHttpMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63A2080 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x63A22D0
        public void HandleResponse(){} // RVA: 0x63A2500
    }

    public class SentryId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1A53740
        public void ToString(){} // RVA: 0x63A2840
        public void Equals(){} // RVA: 0x63A28E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x63A29C0
        public void Create(){} // RVA: 0x63A29E0
        public void WriteTo(){} // RVA: 0x63A2A40
        public void Parse(){} // RVA: 0x5E92F40
        public void FromJson(){} // RVA: 0x63A2B70
        public void op_Equality(){} // RVA: 0x63A2D60
        public void op_Inequality(){} // RVA: 0x63A2E10
        public void op_Implicit(){} // RVA: 0x75E7E0 | overloaded x2
        public void .cctor(){} // RVA: 0x2DD310
    }

    public class SentryMessage
    {
        // ── Methods ──
        public void get_Message(){} // RVA: 0x2F8380
        public void set_Message(){} // RVA: 0x2DEE30
        public void get_Params(){} // RVA: 0x2E07C0
        public void set_Params(){} // RVA: 0x343E80
        public void get_Formatted(){} // RVA: 0x30B0C0
        public void set_Formatted(){} // RVA: 0x30B0D0
        public void op_Implicit(){} // RVA: 0x63A2EF0
        public void WriteTo(){} // RVA: 0x63A2F90
        public void FromJson(){} // RVA: 0x63A30F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SentryMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63A3AF0 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x1EE30
        public void HandleResponse(){} // RVA: 0x2F9F0
        public void SendAsync(){} // RVA: 0x63A3CF0
        public void PropagateTraceHeaders(){} // RVA: 0x63A3F40
        public void AddSentryTraceHeader(){} // RVA: 0x63A4360
        public void AddBaggageHeader(){} // RVA: 0x63A44B0
        public void <>n__0(){} // RVA: 0x63A4B40
    }

    public class SentryMonitorOptions
    {
        // ── Methods ──
        public void CrontabValidation(){} // RVA: 0x63A53E0
        public void Interval(){} // RVA: 0x63A57A0 | overloaded x2
        public void get_CheckInMargin(){} // RVA: 0x5CC8940
        public void set_CheckInMargin(){} // RVA: 0x5CC8950
        public void get_MaxRuntime(){} // RVA: 0x1FA6340
        public void set_MaxRuntime(){} // RVA: 0x4469B20
        public void get_FailureIssueThreshold(){} // RVA: 0x37E0E0
        public void set_FailureIssueThreshold(){} // RVA: 0x63A5880
        public void get_RecoveryThreshold(){} // RVA: 0x3A5500
        public void set_RecoveryThreshold(){} // RVA: 0x63A5930
        public void get_TimeZone(){} // RVA: 0x37B370
        public void set_TimeZone(){} // RVA: 0x37B380
        public void get_Owner(){} // RVA: 0x358D50
        public void set_Owner(){} // RVA: 0x358D60
        public void .ctor(){} // RVA: 0x2DD310
        public void WriteTo(){} // RVA: 0x63A59E0
        public void TypeToString(){} // RVA: 0x63A61E0
    }

    public class SentryOptions
    {
        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x2E07C0
        public void set_ScopeStackContainer(){} // RVA: 0x343E80
        public void get_InstallationId(){} // RVA: 0x63A62D0
        public void get_IsGlobalModeEnabled(){} // RVA: 0x63A6320
        public void set_IsGlobalModeEnabled(){} // RVA: 0x63A6450
        public void get_ScopeObserver(){} // RVA: 0x6374D0
        public void set_ScopeObserver(){} // RVA: 0x30B890
        public void get_EnableScopeSync(){} // RVA: 0x4A6500
        public void set_EnableScopeSync(){} // RVA: 0x4A78C0
        public void get_Transport(){} // RVA: 0x35A740
        public void set_Transport(){} // RVA: 0x305200
        public void get_ClientReportRecorder(){} // RVA: 0x63A64A0
        public void set_ClientReportRecorder(){} // RVA: 0x63A64F0
        public void get_SentryStackTraceFactory(){} // RVA: 0x63A66D0
        public void set_SentryStackTraceFactory(){} // RVA: 0x63A6720
        public void get_SentryVersion(){} // RVA: 0x9EAB90
        public void get_ExceptionProcessors(){} // RVA: 0x37B370
        public void set_ExceptionProcessors(){} // RVA: 0x37B380
        public void get_TransactionProcessors(){} // RVA: 0x358D50
        public void set_TransactionProcessors(){} // RVA: 0x358D60
        public void get_EventProcessors(){} // RVA: 0x3A5590
        public void set_EventProcessors(){} // RVA: 0x3A55A0
        public void get_EventProcessorsProviders(){} // RVA: 0x4C7C50
        public void set_EventProcessorsProviders(){} // RVA: 0x4C34F0
        public void get_TransactionProcessorsProviders(){} // RVA: 0x462D00
        public void set_TransactionProcessorsProviders(){} // RVA: 0x464450
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x31C010
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x463060
        public void get_Integrations(){} // RVA: 0x63A6900
        public void get_ExceptionFilters(){} // RVA: 0xA1C8C0
        public void set_ExceptionFilters(){} // RVA: 0x9AA650
        public void get_TagFilters(){} // RVA: 0xA085E0
        public void set_TagFilters(){} // RVA: 0x9AA5F0
        public void get_BackgroundWorker(){} // RVA: 0xA1C130
        public void set_BackgroundWorker(){} // RVA: 0xAE5030
        public void get_SentryHttpClientFactory(){} // RVA: 0x348040
        public void set_SentryHttpClientFactory(){} // RVA: 0x348050
        public void GetHttpClient(){} // RVA: 0x63A69B0
        public void get_SentryScopeStateProcessor(){} // RVA: 0x3480B0
        public void set_SentryScopeStateProcessor(){} // RVA: 0x3480C0
        public void get_InAppExclude(){} // RVA: 0x348120
        public void set_InAppExclude(){} // RVA: 0x348130
        public void get_InAppInclude(){} // RVA: 0x435460
        public void set_InAppInclude(){} // RVA: 0x435470
        public void get_SendDefaultPii(){} // RVA: 0x8A9980
        public void set_SendDefaultPii(){} // RVA: 0x11CE870
        public void get_IsEnvironmentUser(){} // RVA: 0x11CEE00
        public void set_IsEnvironmentUser(){} // RVA: 0x63A6A90
        public void get_ServerName(){} // RVA: 0xA96D30
        public void set_ServerName(){} // RVA: 0x35E8A0
        public void get_AttachStacktrace(){} // RVA: 0x408F80
        public void set_AttachStacktrace(){} // RVA: 0x408F90
        public void get_MaxBreadcrumbs(){} // RVA: 0x1CAC8E0
        public void set_MaxBreadcrumbs(){} // RVA: 0x3DF13F0
        public void get_SampleRate(){} // RVA: 0x35E970
        public void set_SampleRate(){} // RVA: 0x63A6AA0
        public void get_Release(){} // RVA: 0x3482A0
        public void set_Release(){} // RVA: 0x3482B0
        public void get_Distribution(){} // RVA: 0x7F7DB0
        public void set_Distribution(){} // RVA: 0x63D280
        public void get_Environment(){} // RVA: 0xA94E10
        public void set_Environment(){} // RVA: 0xCF6DE0
        public void get_Dsn(){} // RVA: 0xA902E0
        public void set_Dsn(){} // RVA: 0x63A6B90
        public void get_ParsedDsn(){} // RVA: 0x63A6C60
        public void IsSentryRequest(){} // RVA: 0x63A6EB0 | overloaded x2
        public void get_BeforeSendInternal(){} // RVA: 0x59E660
        public void SetBeforeSend(){} // RVA: 0x63A7020 | overloaded x2
        public void get_BeforeSendTransactionInternal(){} // RVA: 0xA8EE80
        public void SetBeforeSendTransaction(){} // RVA: 0x63A71A0 | overloaded x2
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0xA8E870
        public void SetBeforeBreadcrumb(){} // RVA: 0x63A7320 | overloaded x2
        public void get_MaxQueueItems(){} // RVA: 0x120A360
        public void set_MaxQueueItems(){} // RVA: 0x63A74A0
        public void get_MaxCacheItems(){} // RVA: 0x612FB40
        public void set_MaxCacheItems(){} // RVA: 0x63A7560
        public void get_ShutdownTimeout(){} // RVA: 0x3485F0
        public void set_ShutdownTimeout(){} // RVA: 0x63A7620
        public void get_FlushTimeout(){} // RVA: 0x348660
        public void set_FlushTimeout(){} // RVA: 0x629CBE0
        public void get_DecompressionMethods(){} // RVA: 0x120A160
        public void set_DecompressionMethods(){} // RVA: 0x120B830
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x63A7630
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x63A7640
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x63A7650
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x63A7660
        public void get_SendClientReports(){} // RVA: 0x126D220
        public void set_SendClientReports(){} // RVA: 0x126D230
        public void get_HttpProxy(){} // RVA: 0x881BC0
        public void set_HttpProxy(){} // RVA: 0x8787E0
        public void get_CreateHttpMessageHandler(){} // RVA: 0xD93DD0
        public void set_CreateHttpMessageHandler(){} // RVA: 0xD93D70
        public void get_ConfigureClient(){} // RVA: 0x830040
        public void set_ConfigureClient(){} // RVA: 0xD8E320
        public void get_Debug(){} // RVA: 0x63A7670
        public void set_Debug(){} // RVA: 0x63A7680
        public void get_DiagnosticLevel(){} // RVA: 0x63A7690
        public void set_DiagnosticLevel(){} // RVA: 0x63A76A0
        public void get_DiagnosticLogger(){} // RVA: 0x63A76B0
        public void set_DiagnosticLogger(){} // RVA: 0x63A76D0
        public void get_ReportAssembliesMode(){} // RVA: 0x87D820
        public void set_ReportAssembliesMode(){} // RVA: 0x63A7810
        public void get_DeduplicateMode(){} // RVA: 0x627D120
        public void set_DeduplicateMode(){} // RVA: 0x63A7820
        public void get_CacheDirectoryPath(){} // RVA: 0xA90180
        public void set_CacheDirectoryPath(){} // RVA: 0xD96D90
        public void get_CaptureFailedRequests(){} // RVA: 0x63A7830
        public void set_CaptureFailedRequests(){} // RVA: 0x63A7840
        public void get_FailedRequestStatusCodes(){} // RVA: 0xDB1150
        public void set_FailedRequestStatusCodes(){} // RVA: 0xD95560
        public void get_FailedRequestTargets(){} // RVA: 0x63A7850
        public void set_FailedRequestTargets(){} // RVA: 0x63A78A0
        public void get_FileSystem(){} // RVA: 0x63A79D0
        public void set_FileSystem(){} // RVA: 0xD8AAB0
        public void get_DisableFileWrite(){} // RVA: 0x63A7A90
        public void set_DisableFileWrite(){} // RVA: 0x63A7AA0
        public void get_InitCacheFlushTimeout(){} // RVA: 0xA57F60
        public void set_InitCacheFlushTimeout(){} // RVA: 0x63A7AB0
        public void get_DefaultTags(){} // RVA: 0x63A7AC0
        public void set_DefaultTags(){} // RVA: 0x2DEE30
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x63A7B80
        public void get_IsProfilingEnabled(){} // RVA: 0x63A7C80
        public void get_EnableTracing(){} // RVA: 0x63A7DC0
        public void set_EnableTracing(){} // RVA: 0x63A7DD0
        public void get_TracesSampleRate(){} // RVA: 0x63A7DE0
        public void set_TracesSampleRate(){} // RVA: 0x63A7DF0
        public void get_ProfilesSampleRate(){} // RVA: 0x63A7F00
        public void set_ProfilesSampleRate(){} // RVA: 0x63A7F10
        public void get_TracesSampler(){} // RVA: 0xD92860
        public void set_TracesSampler(){} // RVA: 0xD87940
        public void get_TracePropagationTargets(){} // RVA: 0xD8D540
        public void set_TracePropagationTargets(){} // RVA: 0x63A8020
        public void get_TransactionProfilerFactory(){} // RVA: 0xD9E9A0
        public void set_TransactionProfilerFactory(){} // RVA: 0xD9F490
        public void get_StackTraceMode(){} // RVA: 0x63A80C0
        public void set_StackTraceMode(){} // RVA: 0x63A82C0
        public void get_MaxAttachmentSize(){} // RVA: 0xD88BD0
        public void set_MaxAttachmentSize(){} // RVA: 0x63A8320
        public void get_DetectStartupTime(){} // RVA: 0x63A8330
        public void set_DetectStartupTime(){} // RVA: 0x63A8340
        public void get_AutoSessionTrackingInterval(){} // RVA: 0xD90650
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x63A8350
        public void get_AutoSessionTracking(){} // RVA: 0x625DEA0
        public void set_AutoSessionTracking(){} // RVA: 0x625DEB0
        public void get_UseAsyncFileIO(){} // RVA: 0x625DEC0
        public void set_UseAsyncFileIO(){} // RVA: 0x625DED0
        public void get_CrashedLastRun(){} // RVA: 0xD90BA0
        public void set_CrashedLastRun(){} // RVA: 0xD94430
        public void get_Instrumenter(){} // RVA: 0x63A8360
        public void set_Instrumenter(){} // RVA: 0x63A8370
        public void AddJsonConverter(){} // RVA: 0x63A8380
        public void AddJsonSerializerContext(){} // RVA: 0x24B10
        public void get_JsonPreserveReferences(){} // RVA: 0x63A8420
        public void set_JsonPreserveReferences(){} // RVA: 0x63A84C0
        public void get_NetworkStatusListener(){} // RVA: 0xD83050
        public void set_NetworkStatusListener(){} // RVA: 0xD88A80
        public void get_AssemblyReader(){} // RVA: 0xD90760
        public void set_AssemblyReader(){} // RVA: 0xD8AD50
        public void get_ExperimentalMetrics(){} // RVA: 0xD90B00
        public void set_ExperimentalMetrics(){} // RVA: 0x7F86C0
        public void get_SpotlightUrl(){} // RVA: 0xD973A0
        public void set_SpotlightUrl(){} // RVA: 0xD91360
        public void get_EnableSpotlight(){} // RVA: 0x63A8560
        public void set_EnableSpotlight(){} // RVA: 0x63A8570
        public void get_SettingLocator(){} // RVA: 0xD97D00
        public void set_SettingLocator(){} // RVA: 0xD889C0
        public void get_InitNativeSdks(){} // RVA: 0x63A8580
        public void set_InitNativeSdks(){} // RVA: 0x63A8590
        public void get_PostInitCallbacks(){} // RVA: 0xD89900
        public void set_PostInitCallbacks(){} // RVA: 0xD96B10
        public void .ctor(){} // RVA: 0x63A85A0
        public void AddIntegration(){} // RVA: 0x63AA6C0
        public void RemoveIntegration(){} // RVA: 0x24A50
        public void AddExceptionFilter(){} // RVA: 0x63AA760
        public void RemoveExceptionFilter(){} // RVA: 0x24A50
        public void AddExceptionFilterForType(){} // RVA: 0x24A50
        public void AddInAppExclude(){} // RVA: 0x63AAA30 | overloaded x2
        public void AddInAppExcludeRegex(){} // RVA: 0x63AABE0
        public void AddInAppInclude(){} // RVA: 0x63AAF90 | overloaded x2
        public void AddInAppIncludeRegex(){} // RVA: 0x63AB140
        public void AddExceptionProcessor(){} // RVA: 0x63AB340
        public void AddExceptionProcessors(){} // RVA: 0x63AB530
        public void AddEventProcessor(){} // RVA: 0x63AB700
        public void AddEventProcessors(){} // RVA: 0x63AB8F0
        public void RemoveEventProcessor(){} // RVA: 0x24A50
        public void AddEventProcessorProvider(){} // RVA: 0x63ABAC0
        public void AddTransactionProcessor(){} // RVA: 0x63ABB20
        public void AddTransactionProcessors(){} // RVA: 0x63ABC30
        public void RemoveTransactionProcessor(){} // RVA: 0x24A50
        public void AddTransactionProcessorProvider(){} // RVA: 0x63ABDA0
        public void AddExceptionProcessorProvider(){} // RVA: 0x63ABF90
        public void GetAllEventProcessors(){} // RVA: 0x63ABFF0
        public void GetAllTransactionProcessors(){} // RVA: 0x63AC160
        public void GetAllExceptionProcessors(){} // RVA: 0x63AC2D0
        public void UseStackTraceFactory(){} // RVA: 0x63AC440
        public void ApplyDefaultTags(){} // RVA: 0x63AC670
        public void DisableDuplicateEventDetection(){} // RVA: 0x63ACA70
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x63ACAB0
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x63ACAC0
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x63ACAD0
        public void HasIntegration(){} // RVA: 0xDBE0
        public void RemoveDefaultIntegration(){} // RVA: 0x63ACAE0
        public void SetupLogging(){} // RVA: 0x63ACAF0
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x63ACD20
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x63ACF80
        public void <.ctor>b__346_0(){} // RVA: 0x63ACF90
        public void <.ctor>b__346_5(){} // RVA: 0x63AD0C0
        public void <.ctor>b__346_1(){} // RVA: 0x63AD110
        public void <.ctor>b__346_2(){} // RVA: 0x63AD170
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x63A66D0
        public void <.ctor>b__346_6(){} // RVA: 0x63AD200
        public void <.ctor>b__346_7(){} // RVA: 0x63AD350
        public void <.ctor>b__346_8(){} // RVA: 0x63AD550
        public void <.ctor>b__346_10(){} // RVA: 0x63AD6C0
        public void <.ctor>b__346_11(){} // RVA: 0x63AD800
        public void <.ctor>b__346_4(){} // RVA: 0x63AD970
    }

    public class SentryPackage
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x2F8380
        public void get_Version(){} // RVA: 0x2E07C0
        public void .ctor(){} // RVA: 0xF19AE0
        public void WriteTo(){} // RVA: 0x63AE6A0
        public void FromJson(){} // RVA: 0x63AE7B0
        public void GetHashCode(){} // RVA: 0x63AEA00
        public void Equals(){} // RVA: 0x63AEA70
    }

    public class SentryPropagationContext
    {
        public object InternalEnv;
        public object InternalOther;
        public object InternalHeaders;

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x196ABE0
        public void get_SpanId(){} // RVA: 0x30B0C0
        public void get_ParentSpanId(){} // RVA: 0x111F520
        public void GetOrCreateDynamicSamplingContext(){} // RVA: 0x63AEB90
        public void .ctor(){} // RVA: 0x63AEF90 | overloaded x3
        public void CreateFromHeaders(){} // RVA: 0x63AF0F0
    }

    public class SentryRequest
    {
        // ── Methods ──
        public void get_InternalEnv(){} // RVA: 0x2F8380
        public void set_InternalEnv(){} // RVA: 0x2DEE30
        public void get_InternalOther(){} // RVA: 0x2E07C0
        public void set_InternalOther(){} // RVA: 0x343E80
        public void get_InternalHeaders(){} // RVA: 0x30B0C0
        public void set_InternalHeaders(){} // RVA: 0x30B0D0
        public void get_Url(){} // RVA: 0x30B130
        public void set_Url(){} // RVA: 0x2DEE90
        public void get_Method(){} // RVA: 0x6374D0
        public void set_Method(){} // RVA: 0x30B890
        public void get_ApiTarget(){} // RVA: 0x4976A0
        public void set_ApiTarget(){} // RVA: 0x49B830
        public void get_Data(){} // RVA: 0x35A740
        public void set_Data(){} // RVA: 0x305200
        public void get_QueryString(){} // RVA: 0x358730
        public void set_QueryString(){} // RVA: 0x358740
        public void get_Cookies(){} // RVA: 0x37E0E0
        public void set_Cookies(){} // RVA: 0x4354D0
        public void get_Headers(){} // RVA: 0x63AF300
        public void get_Env(){} // RVA: 0x63AF3C0
        public void get_Other(){} // RVA: 0x63AF480
        public void AddHeaders(){} // RVA: 0x63AF540
        public void Clone(){} // RVA: 0x63AF830
        public void CopyTo(){} // RVA: 0x63AF890
        public void WriteTo(){} // RVA: 0x63AFB30
        public void FromJson(){} // RVA: 0x63AFDB0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SentrySdk
    {
        public object IndexIsValid;
        public object Nodes;
        public object Stream;

        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x63B06C0
        public void get_LastEventId(){} // RVA: 0x63B0720
        public void InitHub(){} // RVA: 0x63B07C0
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x63B0DA0
        public void Init(){} // RVA: 0x63B1270 | overloaded x4
        public void UseHub(){} // RVA: 0x63B1410
        public void Flush(){} // RVA: 0x63B1650 | overloaded x2
        public void FlushAsync(){} // RVA: 0x63B1710 | overloaded x2
        public void Close(){} // RVA: 0x63B17A0
        public void get_IsEnabled(){} // RVA: 0x63B1930
        public void PushScope(){} // RVA: 0x63B19B0 | overloaded x2
        public void BindClient(){} // RVA: 0x63B1A30
        public void AddBreadcrumb(){} // RVA: 0x63B1C10 | overloaded x3
        public void ConfigureScope(){} // RVA: 0x63B1C80
        public void ConfigureScopeAsync(){} // RVA: 0x63B1D00
        public void CaptureEnvelope(){} // RVA: 0x63B1D80
        public void CaptureEvent(){} // RVA: 0x63B1FA0 | overloaded x3
        public void CaptureException(){} // RVA: 0x63B20E0 | overloaded x2
        public void CaptureMessage(){} // RVA: 0x63B22C0 | overloaded x2
        public void CaptureUserFeedback(){} // RVA: 0x63B2530 | overloaded x2
        public void CaptureTransaction(){} // RVA: 0x63B26B0 | overloaded x2
        public void CaptureSession(){} // RVA: 0x63B2750
        public void CaptureCheckIn(){} // RVA: 0x63B27D0
        public void StartTransaction(){} // RVA: 0x63B2C70 | overloaded x6
        public void BindException(){} // RVA: 0x63B2D00
        public void GetSpan(){} // RVA: 0x63B2D90
        public void GetTraceHeader(){} // RVA: 0x63B2E10
        public void GetBaggage(){} // RVA: 0x63B2E90
        public void ContinueTrace(){} // RVA: 0x63B3050 | overloaded x2
        public void get_Metrics(){} // RVA: 0x63B3190
        public void StartSession(){} // RVA: 0x63B3210
        public void EndSession(){} // RVA: 0x63B3290
        public void PauseSession(){} // RVA: 0x63B3320
        public void ResumeSession(){} // RVA: 0x63B33A0
        public void CauseCrash(){} // RVA: 0x63B3420
        public void .cctor(){} // RVA: 0x63B3A50
    }

    public class SentrySession
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x196ABE0
        public void get_DistinctId(){} // RVA: 0x30B0C0
        public void get_StartTimestamp(){} // RVA: 0x111F520
        public void get_Release(){} // RVA: 0x4976A0
        public void get_Environment(){} // RVA: 0x35A740
        public void get_IpAddress(){} // RVA: 0x358730
        public void get_UserAgent(){} // RVA: 0x37E0E0
        public void get_ErrorCount(){} // RVA: 0x9EAB90
        public void .ctor(){} // RVA: 0x63B3F00 | overloaded x2
        public void ReportError(){} // RVA: 0x63B40A0
        public void CreateUpdate(){} // RVA: 0x63B40B0
    }

    public class SentrySpan
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x2F8380
        public void set_SpanId(){} // RVA: 0x1967700
        public void get_ParentSpanId(){} // RVA: 0x994EE0
        public void set_ParentSpanId(){} // RVA: 0x9949A0
        public void get_TraceId(){} // RVA: 0x111F520
        public void set_TraceId(){} // RVA: 0x111C380
        public void get_StartTimestamp(){} // RVA: 0x196F080
        public void set_StartTimestamp(){} // RVA: 0x1F74CD0
        public void get_EndTimestamp(){} // RVA: 0x63B4160
        public void set_EndTimestamp(){} // RVA: 0x63B4180
        public void get_IsFinished(){} // RVA: 0x63B41A0
        public void get_Measurements(){} // RVA: 0x63B41E0
        public void SetMeasurement(){} // RVA: 0x63B42A0
        public void get_Operation(){} // RVA: 0x358D50
        public void set_Operation(){} // RVA: 0x358D60
        public void get_Description(){} // RVA: 0x3A5590
        public void set_Description(){} // RVA: 0x3A55A0
        public void get_Status(){} // RVA: 0x4C7C50
        public void set_Status(){} // RVA: 0x5AAF010
        public void get_IsSampled(){} // RVA: 0x5F98EF0
        public void set_IsSampled(){} // RVA: 0x60162B0
        public void get_Tags(){} // RVA: 0x63B43C0
        public void SetTag(){} // RVA: 0x63B4490
        public void UnsetTag(){} // RVA: 0x63B45C0
        public void get_Extra(){} // RVA: 0x63B46C0
        public void SetExtra(){} // RVA: 0x63B4790
        public void .ctor(){} // RVA: 0x63B4A80 | overloaded x2
        public void GetTraceHeader(){} // RVA: 0x63B50F0
        public void WriteTo(){} // RVA: 0x63B5160
        public void FromJson(){} // RVA: 0x63B5660
        public void Redact(){} // RVA: 0x63B6820
        public void get_Origin(){} // RVA: 0xA085E0
        public void set_Origin(){} // RVA: 0x63B68D0
    }

    public class SentryStackFrame
    {
        // ── Methods ──
        public void get_InternalPreContext(){} // RVA: 0x2F8380
        public void set_InternalPreContext(){} // RVA: 0x2DEE30
        public void get_InternalPostContext(){} // RVA: 0x2E07C0
        public void set_InternalPostContext(){} // RVA: 0x343E80
        public void get_InternalVars(){} // RVA: 0x30B0C0
        public void set_InternalVars(){} // RVA: 0x30B0D0
        public void get_InternalFramesOmitted(){} // RVA: 0x30B130
        public void set_InternalFramesOmitted(){} // RVA: 0x2DEE90
        public void get_IsCodeLocation(){} // RVA: 0x303450
        public void set_IsCodeLocation(){} // RVA: 0x303460
        public void get_FileName(){} // RVA: 0x4976A0
        public void set_FileName(){} // RVA: 0x49B830
        public void get_Function(){} // RVA: 0x35A740
        public void set_Function(){} // RVA: 0x305200
        public void get_Module(){} // RVA: 0x358730
        public void set_Module(){} // RVA: 0x358740
        public void get_LineNumber(){} // RVA: 0x37E0E0
        public void set_LineNumber(){} // RVA: 0x4C4D50
        public void get_ColumnNumber(){} // RVA: 0x3A5500
        public void set_ColumnNumber(){} // RVA: 0x4C34E0
        public void get_AbsolutePath(){} // RVA: 0x37B370
        public void set_AbsolutePath(){} // RVA: 0x37B380
        public void get_ContextLine(){} // RVA: 0x358D50
        public void set_ContextLine(){} // RVA: 0x358D60
        public void get_PreContext(){} // RVA: 0x63B69D0
        public void get_PostContext(){} // RVA: 0x63B6A90
        public void get_InApp(){} // RVA: 0x63B6B50
        public void set_InApp(){} // RVA: 0x63B6B60
        public void get_Vars(){} // RVA: 0x63B6B70
        public void get_FramesOmitted(){} // RVA: 0x63B6C30
        public void get_Package(){} // RVA: 0x4C7C50
        public void set_Package(){} // RVA: 0x4C34F0
        public void get_Platform(){} // RVA: 0x462D00
        public void set_Platform(){} // RVA: 0x464450
        public void get_ImageAddress(){} // RVA: 0x576C5E0
        public void set_ImageAddress(){} // RVA: 0x576C5F0
        public void get_SymbolAddress(){} // RVA: 0x203B2D0
        public void set_SymbolAddress(){} // RVA: 0x203B2E0
        public void get_InstructionAddress(){} // RVA: 0x63B6CF0
        public void set_InstructionAddress(){} // RVA: 0x63B6D00
        public void get_AddressMode(){} // RVA: 0x3480B0
        public void set_AddressMode(){} // RVA: 0x3480C0
        public void get_FunctionId(){} // RVA: 0x63B6D10
        public void set_FunctionId(){} // RVA: 0x63B6D20
        public void WriteTo(){} // RVA: 0x63B6D30
        public void ConfigureAppFrame(){} // RVA: 0x63B7980 | overloaded x2
        public void FromJson(){} // RVA: 0x63B7A30
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x63B9610
    }

    public class SentryStackTrace
    {
        // ── Methods ──
        public void get_InternalFrames(){} // RVA: 0x2F8380
        public void set_InternalFrames(){} // RVA: 0x2DEE30
        public void get_Frames(){} // RVA: 0x63B9A80
        public void set_Frames(){} // RVA: 0x2DEE30
        public void get_AddressAdjustment(){} // RVA: 0x2E07C0
        public void set_AddressAdjustment(){} // RVA: 0xC5BE60
        public void WriteTo(){} // RVA: 0x63B9B40
        public void FromJson(){} // RVA: 0x63B9CF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SentryThread
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x2F8380
        public void set_Id(){} // RVA: 0x1967700
        public void get_Name(){} // RVA: 0x2E07C0
        public void set_Name(){} // RVA: 0x343E80
        public void get_Crashed(){} // RVA: 0x44B4370
        public void set_Crashed(){} // RVA: 0x5AC0F20
        public void get_Current(){} // RVA: 0x5AC0F30
        public void set_Current(){} // RVA: 0x5AC0F40
        public void get_Stacktrace(){} // RVA: 0x30B130
        public void set_Stacktrace(){} // RVA: 0x2DEE90
        public void WriteTo(){} // RVA: 0x63BA240
        public void FromJson(){} // RVA: 0x63BA590
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SentryTraceHeader
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x196ABE0
        public void get_SpanId(){} // RVA: 0x30B0C0
        public void get_IsSampled(){} // RVA: 0x44B97F0
        public void .ctor(){} // RVA: 0x63BAC80
        public void ToString(){} // RVA: 0x63BACA0
        public void Parse(){} // RVA: 0x63BAE80
        public void .cctor(){} // RVA: 0x63BB250
    }

    public class SentryTransaction
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x196ABE0
        public void set_EventId(){} // RVA: 0x196ABF0
        public void get_SpanId(){} // RVA: 0x63BB380
        public void set_SpanId(){} // RVA: 0x63BB3F0
        public void get_Origin(){} // RVA: 0x63BB470
        public void set_Origin(){} // RVA: 0x63BB4E0
        public void get_ParentSpanId(){} // RVA: 0x63BB570
        public void set_ParentSpanId(){} // RVA: 0x63BB600
        public void get_TraceId(){} // RVA: 0x63BB680
        public void set_TraceId(){} // RVA: 0x63BB710
        public void get_Name(){} // RVA: 0x30B0C0
        public void set_Name(){} // RVA: 0x30B0D0
        public void get_NameSource(){} // RVA: 0x791DC0
        public void get_IsParentSampled(){} // RVA: 0x63BB790
        public void set_IsParentSampled(){} // RVA: 0x63BB7A0
        public void get_Platform(){} // RVA: 0x6374D0
        public void set_Platform(){} // RVA: 0x30B890
        public void get_Release(){} // RVA: 0x4976A0
        public void set_Release(){} // RVA: 0x49B830
        public void get_Distribution(){} // RVA: 0x35A740
        public void set_Distribution(){} // RVA: 0x305200
        public void get_StartTimestamp(){} // RVA: 0xEBB920
        public void set_StartTimestamp(){} // RVA: 0xEBB910
        public void get_EndTimestamp(){} // RVA: 0x2E6E50
        public void set_EndTimestamp(){} // RVA: 0x2E6E70
        public void get_Measurements(){} // RVA: 0x63BB7B0
        public void SetMeasurement(){} // RVA: 0x63BB870
        public void get_Operation(){} // RVA: 0x63BB990
        public void set_Operation(){} // RVA: 0x63BBA00
        public void get_Description(){} // RVA: 0x63BBAD0
        public void set_Description(){} // RVA: 0x63BBB40
        public void get_Status(){} // RVA: 0x63BBC10
        public void set_Status(){} // RVA: 0x63BBC80
        public void get_IsSampled(){} // RVA: 0x63BBD00
        public void set_IsSampled(){} // RVA: 0x63BBD70
        public void get_SampleRate(){} // RVA: 0x629CA70
        public void set_SampleRate(){} // RVA: 0x629CA80
        public void get_Level(){} // RVA: 0xBB90C0
        public void set_Level(){} // RVA: 0xBB9E60
        public void get_Request(){} // RVA: 0x63BBEA0
        public void set_Request(){} // RVA: 0xB54600
        public void get_Contexts(){} // RVA: 0xA1C8C0
        public void set_Contexts(){} // RVA: 0x63BBF40
        public void get_User(){} // RVA: 0x63BBF70
        public void set_User(){} // RVA: 0x9AA5F0
        public void get_Environment(){} // RVA: 0xA1C130
        public void set_Environment(){} // RVA: 0xAE5030
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x30B0C0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x63BC010
        public void get_Sdk(){} // RVA: 0x348040
        public void set_Sdk(){} // RVA: 0x348050
        public void get_Fingerprint(){} // RVA: 0x63BC0C0
        public void set_Fingerprint(){} // RVA: 0x3480C0
        public void get_Breadcrumbs(){} // RVA: 0x348120
        public void get_Extra(){} // RVA: 0x435460
        public void get_Tags(){} // RVA: 0x3FA100
        public void get_Spans(){} // RVA: 0xA96D30
        public void get_IsFinished(){} // RVA: 0x63BC110
        public void get_DynamicSamplingContext(){} // RVA: 0x35E970
        public void set_DynamicSamplingContext(){} // RVA: 0x35E980
        public void get_TransactionProfiler(){} // RVA: 0x3482A0
        public void set_TransactionProfiler(){} // RVA: 0x3482B0
        public void .ctor(){} // RVA: 0x63BCA10 | overloaded x4
        public void FromTracerSpans(){} // RVA: 0x63BD760
        public void AddBreadcrumb(){} // RVA: 0x63BE170
        public void SetExtra(){} // RVA: 0x63BE1D0
        public void SetTag(){} // RVA: 0x63BE260
        public void UnsetTag(){} // RVA: 0x63BE2F0
        public void GetTraceHeader(){} // RVA: 0x63BE350
        public void Redact(){} // RVA: 0x63BE440
        public void WriteTo(){} // RVA: 0x63BE970
        public void FromJson(){} // RVA: 0x63BF370
    }

    public class SentryUser
    {
        // ── Methods ──
        public void get_PropertyChanged(){} // RVA: 0x2F8380
        public void set_PropertyChanged(){} // RVA: 0x2DEE30
        public void get_Id(){} // RVA: 0x2E07C0
        public void set_Id(){} // RVA: 0x63C1700
        public void get_Username(){} // RVA: 0x30B0C0
        public void set_Username(){} // RVA: 0x63C17C0
        public void get_Email(){} // RVA: 0x30B130
        public void set_Email(){} // RVA: 0x63C1880
        public void get_IpAddress(){} // RVA: 0x6374D0
        public void set_IpAddress(){} // RVA: 0x63C1940
        public void get_Segment(){} // RVA: 0x4976A0
        public void set_Segment(){} // RVA: 0x63C1A00
        public void get_Other(){} // RVA: 0x63C1AC0
        public void set_Other(){} // RVA: 0x63C1B80
        public void Clone(){} // RVA: 0x63C1BF0
        public void CopyTo(){} // RVA: 0x63C1C50
        public void HasAnyData(){} // RVA: 0x63C1F00
        public void WriteTo(){} // RVA: 0x63C1F80
        public void FromJson(){} // RVA: 0x63C2170
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SentryValues`1 : Values
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24B10
        public void WriteTo(){} // RVA: 0x2DC60
    }

    public class SessionUpdate
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x196ABE0
        public void get_DistinctId(){} // RVA: 0x30B0C0
        public void get_StartTimestamp(){} // RVA: 0x111F520
        public void get_Release(){} // RVA: 0x4976A0
        public void get_Environment(){} // RVA: 0x35A740
        public void get_IpAddress(){} // RVA: 0x358730
        public void get_UserAgent(){} // RVA: 0x37E0E0
        public void get_ErrorCount(){} // RVA: 0x9EAB90
        public void get_IsInitial(){} // RVA: 0x37B240
        public void get_Timestamp(){} // RVA: 0x36ABF00
        public void get_SequenceNumber(){} // RVA: 0x10E5CF0
        public void get_Duration(){} // RVA: 0x63C2880
        public void get_EndStatus(){} // RVA: 0x63C2900
        public void .ctor(){} // RVA: 0x63C2D60 | overloaded x4
        public void WriteTo(){} // RVA: 0x63C2DA0
        public void FromJson(){} // RVA: 0x63C3460
    }

    public class SpanContext
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x2F8380
        public void get_ParentSpanId(){} // RVA: 0x994EE0
        public void get_TraceId(){} // RVA: 0x111F520
        public void get_Operation(){} // RVA: 0x4976A0
        public void set_Operation(){} // RVA: 0x49B830
        public void get_Description(){} // RVA: 0x35A740
        public void get_Status(){} // RVA: 0x358730
        public void get_IsSampled(){} // RVA: 0x41E3C10
        public void get_Instrumenter(){} // RVA: 0xC5BE80
        public void set_Instrumenter(){} // RVA: 0xC5BE70
        public void get_Origin(){} // RVA: 0x3A5500
        public void set_Origin(){} // RVA: 0x63C45E0
        public void .ctor(){} // RVA: 0x63C46E0
    }

    public class SpanDataExtensions
    {
        // ── Methods ──
        public void SetMeasurement(){} // RVA: 0x62AB6F0 | overloaded x4
    }

    public class SpanExtensions
    {
        // ── Methods ──
        public void StartChild(){} // RVA: 0x62AAA30 | overloaded x2
        public void GetTransaction(){} // RVA: 0x62AAC80
        public void GetDbParentSpan(){} // RVA: 0x62AAD80
    }

    public class SpanId
    {
        // ── Methods ──
        public void GetValue(){} // RVA: 0x1AD4690
        public void .ctor(){} // RVA: 0x1B12320 | overloaded x2
        public void Equals(){} // RVA: 0x63C49B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x63C4A90
        public void ToString(){} // RVA: 0x63C4C20
        public void Create(){} // RVA: 0x63C4D10
        public void WriteTo(){} // RVA: 0x63C4E00
        public void Parse(){} // RVA: 0x63C5190
        public void FromJson(){} // RVA: 0x63C51C0
        public void op_Equality(){} // RVA: 0x63C52C0
        public void op_Inequality(){} // RVA: 0x63C5350
        public void op_Implicit(){} // RVA: 0x63C53C0
        public void .cctor(){} // RVA: 0x63C5410
    }

    public class SpanStatusConverter
    {
        // ── Methods ──
        public void FromException(){} // RVA: 0x63C55A0
        public void FromHttpStatusCode(){} // RVA: 0x63C5820 | overloaded x2
        public void FromGrpcStatusCode(){} // RVA: 0x63C58E0
    }

    public class SpanTracer
    {
        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x63C59A0
        public void get_Transaction(){} // RVA: 0x4976A0
        public void get_MetricsSummary(){} // RVA: 0x63C59B0
        public void get_HasMetrics(){} // RVA: 0x63C5A00
        public void get_SpanId(){} // RVA: 0x358730
        public void set_SpanId(){} // RVA: 0x179D760
        public void get_ParentSpanId(){} // RVA: 0x41E0130
        public void set_ParentSpanId(){} // RVA: 0x5B3A8D0
        public void get_TraceId(){} // RVA: 0x36ABF00
        public void get_StartTimestamp(){} // RVA: 0x6016290
        public void set_StartTimestamp(){} // RVA: 0x60162A0
        public void get_EndTimestamp(){} // RVA: 0xE73150
        public void set_EndTimestamp(){} // RVA: 0xE734C0
        public void get_IsFinished(){} // RVA: 0x63C5A50
        public void get_InternalMeasurements(){} // RVA: 0xA1C8C0
        public void set_InternalMeasurements(){} // RVA: 0x9AA650
        public void get_Measurements(){} // RVA: 0x63C5A90
        public void SetMeasurement(){} // RVA: 0x63C5B60
        public void get_Operation(){} // RVA: 0xA085E0
        public void set_Operation(){} // RVA: 0x9AA5F0
        public void get_Description(){} // RVA: 0xA1C130
        public void set_Description(){} // RVA: 0xAE5030
        public void get_Status(){} // RVA: 0x348040
        public void set_Status(){} // RVA: 0x1B6CD00
        public void get_IsSentryRequest(){} // RVA: 0x173F990
        public void set_IsSentryRequest(){} // RVA: 0x173EC00
        public void get_IsSampled(){} // RVA: 0x63C5C90
        public void set_IsSampled(){} // RVA: 0x63C5CA0
        public void get_InternalTags(){} // RVA: 0x348120
        public void set_InternalTags(){} // RVA: 0x348130
        public void get_Tags(){} // RVA: 0x63C5CB0
        public void SetTag(){} // RVA: 0x63C5D80
        public void UnsetTag(){} // RVA: 0x63C5EA0
        public void get_Extra(){} // RVA: 0x435460
        public void SetExtra(){} // RVA: 0x63C6010
        public void get_IsFiltered(){} // RVA: 0x3FA100
        public void set_IsFiltered(){} // RVA: 0x3FA110
        public void .ctor(){} // RVA: 0x63C63A0 | overloaded x2
        public void StartChild(){} // RVA: 0x63C66B0
        public void Unfinish(){} // RVA: 0x63C6700
        public void Finish(){} // RVA: 0x63C6D60 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x63C6DA0
        public void get_Origin(){} // RVA: 0xA96D30
        public void set_Origin(){} // RVA: 0x63C6E10
    }

    public class StreamAttachmentContent : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetStream(){} // RVA: 0x2F8380
    }

    public class SubstringOrRegexPattern
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x63C7050 | overloaded x2
        public void ToString(){} // RVA: 0x63C70E0
        public void Equals(){} // RVA: 0x63C7150
        public void GetHashCode(){} // RVA: 0x1EBC800
        public void get_Regex(){} // RVA: 0x2F8380
        public void IsMatch(){} // RVA: 0x63C7250
        public void TryParseRegex(){} // RVA: 0x63C73F0
    }

    public class SubstringOrRegexPatternExtensions
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x63C74A0
        public void WithConfigBinding(){} // RVA: 0xCE50
    }

    public class SubstringOrRegexPatternTypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x63C75C0
        public void ConvertFrom(){} // RVA: 0x63C7690
        public void .ctor(){} // RVA: 0x2DD310
    }

}