// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 44
// Methods: 915

namespace ThirdParty.Sentry.Sentry
{
    public class Scope : Object
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7A80F2570
        public void get_Locked(){} // RVA: 0x7A80F26D0
        public void set_Locked(){} // RVA: 0x7A80F26E0
        public void get_LastEventId(){} // RVA: 0x7AE0A2720
        public void set_LastEventId(){} // RVA: 0x7AE0A2840
        public void get_HasEvaluated(){} // RVA: 0x7AE0A2950
        public void get_ExceptionProcessors(){} // RVA: 0x7AE0A2960
        public void get_EventProcessors(){} // RVA: 0x7AE0A29B0
        public void get_TransactionProcessors(){} // RVA: 0x7AE0A2A00
        public void add_OnEvaluating(){} // RVA: 0x7AE0A2A50
        public void remove_OnEvaluating(){} // RVA: 0x7AE0A2B60
        public void get_Level(){} // RVA: 0x7A9A93870
        public void set_Level(){} // RVA: 0x7A9A93880
        public void get_Request(){} // RVA: 0x7AE0A2C70
        public void set_Request(){} // RVA: 0x7A81A00F0
        public void get_Contexts(){} // RVA: 0x7A82C2060
        public void set_Contexts(){} // RVA: 0x7AE0A2D10
        public void get_UserChanged(){} // RVA: 0x7AE0A2D30
        public void get_User(){} // RVA: 0x7AE0A2DB0
        public void set_User(){} // RVA: 0x7AE0A2ED0
        public void get_Release(){} // RVA: 0x7A81163D0
        public void set_Release(){} // RVA: 0x7A825E460
        public void get_Distribution(){} // RVA: 0x7A8555100
        public void set_Distribution(){} // RVA: 0x7A8919DE0
        public void get_Environment(){} // RVA: 0x7A87D9C10
        public void set_Environment(){} // RVA: 0x7A8744720
        public void get_TransactionName(){} // RVA: 0x7AE0A2FA0
        public void set_TransactionName(){} // RVA: 0x7AE0A3000
        public void get_Transaction(){} // RVA: 0x7A87D9480
        public void set_Transaction(){} // RVA: 0x7A8881790
        public void get_PropagationContext(){} // RVA: 0x7A8142610
        public void set_PropagationContext(){} // RVA: 0x7A8142620
        public void get_SessionUpdate(){} // RVA: 0x7A8142680
        public void set_SessionUpdate(){} // RVA: 0x7A8142690
        public void get_Sdk(){} // RVA: 0x7A81426F0
        public void get_Fingerprint(){} // RVA: 0x7A82305B0
        public void set_Fingerprint(){} // RVA: 0x7A82305C0
        public void get_Breadcrumbs(){} // RVA: 0x7A81F50F0
        public void get_Extra(){} // RVA: 0x7A8854870
        public void get_Tags(){} // RVA: 0x7A8158F50
        public void get_Attachments(){} // RVA: 0x7A8158FC0
        public void .ctor(){} // RVA: 0x7AE0A3A10
        public void AddBreadcrumb(){} // RVA: 0x7AE0A3AF0
        public void SetExtra(){} // RVA: 0x7AE0A3D20
        public void SetTag(){} // RVA: 0x7AE0A3DD0
        public void UnsetTag(){} // RVA: 0x7AE0A3FA0
        public void AddAttachment(){} // RVA: 0x7AE0A7B30
        public void Clear(){} // RVA: 0x7AE0A4110
        public void ClearAttachments(){} // RVA: 0x7AE0A4750
        public void ClearBreadcrumbs(){} // RVA: 0x7AE0A4800
        public void Apply(){} // RVA: 0x7AE0A5E50
        public void Clone(){} // RVA: 0x7AE0A5F30
        public void Evaluate(){} // RVA: 0x7AE0A6790
        public void get_Span(){} // RVA: 0x7AE0A6A00
        public void set_Span(){} // RVA: 0x7A8142880
        public void GetAllEventProcessors(){} // RVA: 0x7AE0A6AF0
        public void GetAllTransactionProcessors(){} // RVA: 0x7AE0A6BA0
        public void GetAllExceptionProcessors(){} // RVA: 0x7AE0A6C50
        public void AddExceptionProcessor(){} // RVA: 0x7AE0A6D00
        public void AddExceptionProcessors(){} // RVA: 0x7AE0A6D90
        public void AddEventProcessor(){} // RVA: 0x7AE0A7070
        public void AddEventProcessors(){} // RVA: 0x7AE0A7190
        public void AddTransactionProcessor(){} // RVA: 0x7AE0A7470
        public void AddTransactionProcessors(){} // RVA: 0x7AE0A7590
        public void ResetTransaction(){} // RVA: 0x7AE0A7CB0
        public void <get_UserChanged>b__41_0(){} // RVA: 0x7AE0A7D10
    }

    public class SdkVersion : Object
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE17E570
        public void get_InternalPackages(){} // RVA: 0x7A80F2570
        public void set_InternalPackages(){} // RVA: 0x7A80D8E20
        public void get_Integrations(){} // RVA: 0x7A80DA7B0
        public void set_Integrations(){} // RVA: 0x7A813E420
        public void get_Packages(){} // RVA: 0x7A80F2570
        public void get_Name(){} // RVA: 0x7A81052C0
        public void set_Name(){} // RVA: 0x7A81052D0
        public void get_Version(){} // RVA: 0x7A8105330
        public void set_Version(){} // RVA: 0x7A80D8E80
        public void AddPackage(){} // RVA: 0x7AE17E6B0
        public void AddIntegration(){} // RVA: 0x7AE17E710
        public void WriteTo(){} // RVA: 0x7AE17E770
        public void FromJson(){} // RVA: 0x7AE17EA10
        public void .ctor(){} // RVA: 0x7AE17F600
        public void .cctor(){} // RVA: 0x7AE17F760
    }

    public class SentryAttachment : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A8124910
        public void get_Content(){} // RVA: 0x7A80DA7B0
        public void get_FileName(){} // RVA: 0x7A81052C0
        public void get_ContentType(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7AD9E8080
    }

    public class SentryCheckIn : Object
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A97277F0
        public void get_MonitorSlug(){} // RVA: 0x7A81052C0
        public void get_Status(){} // RVA: 0x7A854FDE0
        public void get_Duration(){} // RVA: 0x7ADAB6B40
        public void set_Duration(){} // RVA: 0x7ADAB6B50
        public void get_Release(){} // RVA: 0x7A8154D80
        public void set_Release(){} // RVA: 0x7A80FF440
        public void get_Environment(){} // RVA: 0x7A8152D80
        public void set_Environment(){} // RVA: 0x7A8152D90
        public void get_TraceId(){} // RVA: 0x7AC0091D0
        public void set_TraceId(){} // RVA: 0x7AE17FBD0
        public void get_MonitorOptions(){} // RVA: 0x7A8153390
        public void set_MonitorOptions(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7AE17FBE0
        public void WriteTo(){} // RVA: 0x7AE17FD30
        public void ToSnakeCase(){} // RVA: 0x7AE1802A0
    }

    public class SentryClient : Object
    {
        // ── Methods ──
        public void get_Worker(){} // RVA: 0x7A83F69F0
        public void get_Options(){} // RVA: 0x7A80F2570
        public void get_IsEnabled(){} // RVA: 0x7A81BD750
        public void .ctor(){} // RVA: 0x7AE1803D0
        public void CaptureEvent(){} // RVA: 0x7AE1809B0
        public void CaptureUserFeedback(){} // RVA: 0x7AE180B60
        public void CaptureTransaction(){} // RVA: 0x7AE180E70
        public void BeforeSendTransaction(){} // RVA: 0x7AE181AB0
        public void CaptureSession(){} // RVA: 0x7AE181DB0
        public void CaptureCheckIn(){} // RVA: 0x7AE181F40
        public void FlushAsync(){} // RVA: 0x7AE182520
        public void DoSendEvent(){} // RVA: 0x7AE182580
        public void ApplyExceptionFilters(){} // RVA: 0x7AE183A00
        public void CaptureEnvelope(){} // RVA: 0x7AE183D30
        public void BeforeSend(){} // RVA: 0x7AE183F60
        public void Dispose(){} // RVA: 0x7AE184260
    }

    public class SentryClientExtensions : Object
    {
        // ── Methods ──
        public void CaptureException(){} // RVA: 0x7AE184510
        public void CaptureMessage(){} // RVA: 0x7AE184680
        public void CaptureUserFeedback(){} // RVA: 0x7AE184850
        public void Flush(){} // RVA: 0x7AE1849D0
        public void FlushAsync(){} // RVA: 0x7AE184AB0
        public void get_SentryOptionsForTestingOnly(){} // RVA: 0x7AE184B50
        public void set_SentryOptionsForTestingOnly(){} // RVA: 0x7AE184B90
        public void GetSentryOptions(){} // RVA: 0x7AE184C30
    }

    public class SentryContexts : Object
    {
        // ── Methods ──
        public void get_App(){} // RVA: 0x7AE184D70
        public void get_Browser(){} // RVA: 0x7AE184DD0
        public void get_Device(){} // RVA: 0x7AE184E30
        public void get_OperatingSystem(){} // RVA: 0x7AE184E90
        public void get_Response(){} // RVA: 0x7AE184EF0
        public void get_Runtime(){} // RVA: 0x7AE184F50
        public void get_Gpu(){} // RVA: 0x7AE184FB0
        public void get_Trace(){} // RVA: 0x7AE185010
        public void .ctor(){} // RVA: 0x7AE185070
        public void Clone(){} // RVA: 0x7AE1851B0
        public void CopyTo(){} // RVA: 0x7AE186920
        public void WriteTo(){} // RVA: 0x7AE185590
        public void FromJson(){} // RVA: 0x7AE185810
        public void ReplaceWith(){} // RVA: 0x7AE186360
        public void NullIfEmpty(){} // RVA: 0x7AE186610
        public void GetEnumerator(){} // RVA: 0x7AE186670
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7AE1866C0
        public void Add(){} // RVA: 0x7AE186B70
        public void Clear(){} // RVA: 0x7AE1867E0
        public void Contains(){} // RVA: 0x7AE186830
        public void Remove(){} // RVA: 0x7AE186C60
        public void get_Count(){} // RVA: 0x7AE186AD0
        public void get_IsReadOnly(){} // RVA: 0x7AE186B20
        public void ContainsKey(){} // RVA: 0x7AE186C00
        public void TryGetValue(){} // RVA: 0x7AE186CC0
        public void get_Item(){} // RVA: 0x7AE186EA0
        public void set_Item(){} // RVA: 0x7AE186F00
        public void get_Keys(){} // RVA: 0x7AE186F70
        public void get_Values(){} // RVA: 0x7AE186FD0
    }

    public class SentryEvent : Object
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7A80DA7B0
        public void get_EventId(){} // RVA: 0x7A9D01C90
        public void get_Timestamp(){} // RVA: 0x7ADAB6B40
        public void get_Message(){} // RVA: 0x7A8154D80
        public void set_Message(){} // RVA: 0x7A80FF440
        public void get_Logger(){} // RVA: 0x7A8152D80
        public void set_Logger(){} // RVA: 0x7A8152D90
        public void get_Platform(){} // RVA: 0x7A8178B90
        public void set_Platform(){} // RVA: 0x7A8230620
        public void get_ServerName(){} // RVA: 0x7A81A0050
        public void set_ServerName(){} // RVA: 0x7A81A0060
        public void get_Release(){} // RVA: 0x7A8175DF0
        public void set_Release(){} // RVA: 0x7A8175E00
        public void get_Distribution(){} // RVA: 0x7A8153390
        public void set_Distribution(){} // RVA: 0x7A81533A0
        public void get_SentryExceptionValues(){} // RVA: 0x7A81A00E0
        public void set_SentryExceptionValues(){} // RVA: 0x7A81A00F0
        public void get_SentryExceptions(){} // RVA: 0x7AE187510
        public void set_SentryExceptions(){} // RVA: 0x7AE187580
        public void get_SentryThreadValues(){} // RVA: 0x7A82C2060
        public void set_SentryThreadValues(){} // RVA: 0x7A82C0530
        public void get_SentryThreads(){} // RVA: 0x7AE1876B0
        public void set_SentryThreads(){} // RVA: 0x7AE187720
        public void get_DebugImages(){} // RVA: 0x7AE187850
        public void set_DebugImages(){} // RVA: 0x7AE187870
        public void get_Modules(){} // RVA: 0x7AE187990
        public void get_Level(){} // RVA: 0x7A897F560
        public void set_Level(){} // RVA: 0x7A8980300
        public void get_TransactionName(){} // RVA: 0x7A8555100
        public void set_TransactionName(){} // RVA: 0x7A8919DE0
        public void get_Request(){} // RVA: 0x7AE187A50
        public void set_Request(){} // RVA: 0x7A8744720
        public void get_Contexts(){} // RVA: 0x7A87C5850
        public void set_Contexts(){} // RVA: 0x7AE187AF0
        public void get_User(){} // RVA: 0x7AE187B20
        public void set_User(){} // RVA: 0x7A8881790
        public void get_Environment(){} // RVA: 0x7A8142610
        public void set_Environment(){} // RVA: 0x7A8142620
        public void get_Sdk(){} // RVA: 0x7A8142680
        public void set_Sdk(){} // RVA: 0x7A8142690
        public void get_Fingerprint(){} // RVA: 0x7AE187BC0
        public void set_Fingerprint(){} // RVA: 0x7A8142700
        public void get_Breadcrumbs(){} // RVA: 0x7AE187C10
        public void get_Extra(){} // RVA: 0x7AE187CE0
        public void get_Tags(){} // RVA: 0x7AE187DB0
        public void HasException(){} // RVA: 0x7AE187E80
        public void HasTerminalException(){} // RVA: 0x7AE187EF0
        public void get_DynamicSamplingContext(){} // RVA: 0x7A8158F50
        public void set_DynamicSamplingContext(){} // RVA: 0x7A8158F60
        public void .ctor(){} // RVA: 0x7AE188310
        public void AddBreadcrumb(){} // RVA: 0x7AE188740
        public void SetExtra(){} // RVA: 0x7AE188840
        public void SetTag(){} // RVA: 0x7AE188970
        public void UnsetTag(){} // RVA: 0x7AE188AA0
        public void Redact(){} // RVA: 0x7AE188BA0
        public void WriteTo(){} // RVA: 0x7AE188E00
        public void FromJson(){} // RVA: 0x7AE189670
    }

    public class SentryFailedRequestHandler : Object
    {
        // ── Methods ──
        public void get_Hub(){} // RVA: 0x7A80F2570
        public void get_Options(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7A7E18890
        public void HandleResponse(){} // RVA: 0x7AE18BF00
    }

    public class SentryGraphQLHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18C120
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7AE18C2B0
    }

    public class SentryGraphQLHttpMessageHandler : SentryMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18CB40
        public void ProcessRequest(){} // RVA: 0x7AE18CED0
        public void HandleResponse(){} // RVA: 0x7AE18D290
        public void GetSpanDescriptionOrDefault(){} // RVA: 0x7AE18D960
        public void AddIfExists(){} // RVA: 0x7AE18DB70
    }

    public class SentryHint : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18DE90
        public void get_Attachments(){} // RVA: 0x7A80DA7B0
        public void get_Items(){} // RVA: 0x7AE18DFC0
        public void AddAttachmentsFromScope(){} // RVA: 0x7AE18E080
        public void AddAttachment(){} // RVA: 0x7AE18E280
        public void WithAttachments(){} // RVA: 0x7AE18E470
    }

    public class SentryHttpFailedRequestHandler : SentryFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18E510
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7AE18E520
    }

    public class SentryHttpMessageHandler : SentryMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE18EC00
        public void ProcessRequest(){} // RVA: 0x7AE18EE50
        public void HandleResponse(){} // RVA: 0x7AE18F080
    }

    public class SentryId : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7662BD0
        public void ToString(){} // RVA: 0x7A7E74DC0
        public void Equals(){} // RVA: 0x7A7E74E60
        public void GetHashCode(){} // RVA: 0x7A7E74E70
        public void Create(){} // RVA: 0x7AE18F560
        public void WriteTo(){} // RVA: 0x7A7E74E90
        public void Parse(){} // RVA: 0x7ADC81AB0
        public void FromJson(){} // RVA: 0x7AE18F6F0
        public void op_Equality(){} // RVA: 0x7AE18F8E0
        public void op_Inequality(){} // RVA: 0x7AE18F990
        public void op_Implicit(){} // RVA: 0x7A851C340
        public void .cctor(){} // RVA: 0x7A80D7310
    }

    public class SentryMessage : Object
    {
        // ── Methods ──
        public void get_Message(){} // RVA: 0x7A80F2570
        public void set_Message(){} // RVA: 0x7A80D8E20
        public void get_Params(){} // RVA: 0x7A80DA7B0
        public void set_Params(){} // RVA: 0x7A813E420
        public void get_Formatted(){} // RVA: 0x7A81052C0
        public void set_Formatted(){} // RVA: 0x7A81052D0
        public void op_Implicit(){} // RVA: 0x7AE18FA70
        public void WriteTo(){} // RVA: 0x7AE18FB10
        public void FromJson(){} // RVA: 0x7AE18FCA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SentryMessageHandler : DelegatingHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE1906B0
        public void ProcessRequest(){} // RVA: 0x7A7E06710
        public void HandleResponse(){} // RVA: 0x7A7E1DB70
        public void SendAsync(){} // RVA: 0x7AE1908C0
        public void PropagateTraceHeaders(){} // RVA: 0x7AE190B10
        public void AddSentryTraceHeader(){} // RVA: 0x7AE190F00
        public void AddBaggageHeader(){} // RVA: 0x7AE191050
        public void <>n__0(){} // RVA: 0x7AE1916E0
    }

    public class SentryMonitorOptions : Object
    {
        // ── Methods ──
        public void CrontabValidation(){} // RVA: 0x7AE191F80
        public void Interval(){} // RVA: 0x7AE192340
        public void get_CheckInMargin(){} // RVA: 0x7ADAB6B40
        public void set_CheckInMargin(){} // RVA: 0x7ADAB6B50
        public void get_MaxRuntime(){} // RVA: 0x7A9DB2460
        public void set_MaxRuntime(){} // RVA: 0x7AC257C80
        public void get_FailureIssueThreshold(){} // RVA: 0x7A8178B90
        public void set_FailureIssueThreshold(){} // RVA: 0x7AE192420
        public void get_RecoveryThreshold(){} // RVA: 0x7A81A0050
        public void set_RecoveryThreshold(){} // RVA: 0x7AE1924D0
        public void get_TimeZone(){} // RVA: 0x7A8175DF0
        public void set_TimeZone(){} // RVA: 0x7A8175E00
        public void get_Owner(){} // RVA: 0x7A8153390
        public void set_Owner(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void WriteTo(){} // RVA: 0x7AE192580
        public void TypeToString(){} // RVA: 0x7AE192DD0
    }

    public class SentryOptions : Object
    {
        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7A80DA7B0
        public void set_ScopeStackContainer(){} // RVA: 0x7A813E420
        public void get_InstallationId(){} // RVA: 0x7AE192EC0
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7AE192F10
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7AE193040
        public void get_ScopeObserver(){} // RVA: 0x7A83F69F0
        public void set_ScopeObserver(){} // RVA: 0x7A8105A90
        public void get_EnableScopeSync(){} // RVA: 0x7A82A20A0
        public void set_EnableScopeSync(){} // RVA: 0x7A82A2C90
        public void get_Transport(){} // RVA: 0x7A8154D80
        public void set_Transport(){} // RVA: 0x7A80FF440
        public void get_ClientReportRecorder(){} // RVA: 0x7AE193090
        public void set_ClientReportRecorder(){} // RVA: 0x7AE1930E0
        public void get_SentryStackTraceFactory(){} // RVA: 0x7AE1932C0
        public void set_SentryStackTraceFactory(){} // RVA: 0x7AE193310
        public void get_SentryVersion(){} // RVA: 0x7A87A7DA0
        public void get_ExceptionProcessors(){} // RVA: 0x7A8175DF0
        public void set_ExceptionProcessors(){} // RVA: 0x7A8175E00
        public void get_TransactionProcessors(){} // RVA: 0x7A8153390
        public void set_TransactionProcessors(){} // RVA: 0x7A81533A0
        public void get_EventProcessors(){} // RVA: 0x7A81A00E0
        public void set_EventProcessors(){} // RVA: 0x7A81A00F0
        public void get_EventProcessorsProviders(){} // RVA: 0x7A82C2060
        public void set_EventProcessorsProviders(){} // RVA: 0x7A82C0530
        public void get_TransactionProcessorsProviders(){} // RVA: 0x7A825E100
        public void set_TransactionProcessorsProviders(){} // RVA: 0x7A825F860
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x7A81163D0
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x7A825E460
        public void get_Integrations(){} // RVA: 0x7AE1934F0
        public void get_ExceptionFilters(){} // RVA: 0x7A87D9C10
        public void set_ExceptionFilters(){} // RVA: 0x7A8744720
        public void get_TagFilters(){} // RVA: 0x7A87C5850
        public void set_TagFilters(){} // RVA: 0x7A87446C0
        public void get_BackgroundWorker(){} // RVA: 0x7A87D9480
        public void set_BackgroundWorker(){} // RVA: 0x7A8881790
        public void get_SentryHttpClientFactory(){} // RVA: 0x7A8142610
        public void set_SentryHttpClientFactory(){} // RVA: 0x7A8142620
        public void GetHttpClient(){} // RVA: 0x7AE1935A0
        public void get_SentryScopeStateProcessor(){} // RVA: 0x7A8142680
        public void set_SentryScopeStateProcessor(){} // RVA: 0x7A8142690
        public void get_InAppExclude(){} // RVA: 0x7A81426F0
        public void set_InAppExclude(){} // RVA: 0x7A8142700
        public void get_InAppInclude(){} // RVA: 0x7A82305B0
        public void set_InAppInclude(){} // RVA: 0x7A82305C0
        public void get_SendDefaultPii(){} // RVA: 0x7A86665A0
        public void set_SendDefaultPii(){} // RVA: 0x7A8FB8F70
        public void get_IsEnvironmentUser(){} // RVA: 0x7A8FB9510
        public void set_IsEnvironmentUser(){} // RVA: 0x7AE193680
        public void get_ServerName(){} // RVA: 0x7A8854870
        public void set_ServerName(){} // RVA: 0x7A8158EF0
        public void get_AttachStacktrace(){} // RVA: 0x7A8203E30
        public void set_AttachStacktrace(){} // RVA: 0x7A8203E40
        public void get_MaxBreadcrumbs(){} // RVA: 0x7A9AAEF60
        public void set_MaxBreadcrumbs(){} // RVA: 0x7ABBEC9C0
        public void get_SampleRate(){} // RVA: 0x7A8158FC0
        public void set_SampleRate(){} // RVA: 0x7AE193690
        public void get_Release(){} // RVA: 0x7A8142870
        public void set_Release(){} // RVA: 0x7A8142880
        public void get_Distribution(){} // RVA: 0x7A8592710
        public void set_Distribution(){} // RVA: 0x7A84442D0
        public void get_Environment(){} // RVA: 0x7A8852A30
        public void set_Environment(){} // RVA: 0x7A8AB8FD0
        public void get_Dsn(){} // RVA: 0x7A884DED0
        public void set_Dsn(){} // RVA: 0x7AE193780
        public void get_ParsedDsn(){} // RVA: 0x7AE193850
        public void IsSentryRequest(){} // RVA: 0x7AE193AA0
        public void get_BeforeSendInternal(){} // RVA: 0x7A8357A90
        public void SetBeforeSend(){} // RVA: 0x7AE193C10
        public void get_BeforeSendTransactionInternal(){} // RVA: 0x7A884CA70
        public void SetBeforeSendTransaction(){} // RVA: 0x7AE193D90
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x7A884C460
        public void SetBeforeBreadcrumb(){} // RVA: 0x7AE193F10
        public void get_MaxQueueItems(){} // RVA: 0x7A8F9BFE0
        public void set_MaxQueueItems(){} // RVA: 0x7AE194090
        public void get_MaxCacheItems(){} // RVA: 0x7ADF1BE20
        public void set_MaxCacheItems(){} // RVA: 0x7AE194150
        public void get_ShutdownTimeout(){} // RVA: 0x7A8142BC0
        public void set_ShutdownTimeout(){} // RVA: 0x7AE194210
        public void get_FlushTimeout(){} // RVA: 0x7A8142C30
        public void set_FlushTimeout(){} // RVA: 0x7AE088AB0
        public void get_DecompressionMethods(){} // RVA: 0x7A8F98B60
        public void set_DecompressionMethods(){} // RVA: 0x7A8F9B560
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7AE194220
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7AE194230
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7AE194240
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7AE194250
        public void get_SendClientReports(){} // RVA: 0x7A9023A40
        public void set_SendClientReports(){} // RVA: 0x7A9023A50
        public void get_HttpProxy(){} // RVA: 0x7A863E8E0
        public void set_HttpProxy(){} // RVA: 0x7A86357B0
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7A8B57910
        public void set_CreateHttpMessageHandler(){} // RVA: 0x7A8B578B0
        public void get_ConfigureClient(){} // RVA: 0x7A85ECF50
        public void set_ConfigureClient(){} // RVA: 0x7A8B51A20
        public void get_Debug(){} // RVA: 0x7AE194260
        public void set_Debug(){} // RVA: 0x7AE194270
        public void get_DiagnosticLevel(){} // RVA: 0x7AE194280
        public void set_DiagnosticLevel(){} // RVA: 0x7AE194290
        public void get_DiagnosticLogger(){} // RVA: 0x7AE1942A0
        public void set_DiagnosticLogger(){} // RVA: 0x7AE1942C0
        public void get_ReportAssembliesMode(){} // RVA: 0x7A863A6A0
        public void set_ReportAssembliesMode(){} // RVA: 0x7AE1943F0
        public void get_DeduplicateMode(){} // RVA: 0x7AE068FC0
        public void set_DeduplicateMode(){} // RVA: 0x7AE194400
        public void get_CacheDirectoryPath(){} // RVA: 0x7A884DD70
        public void set_CacheDirectoryPath(){} // RVA: 0x7A8B5ADA0
        public void get_CaptureFailedRequests(){} // RVA: 0x7AE194410
        public void set_CaptureFailedRequests(){} // RVA: 0x7AE194420
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7A8B76160
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7A8B592F0
        public void get_FailedRequestTargets(){} // RVA: 0x7AE194430
        public void set_FailedRequestTargets(){} // RVA: 0x7AE194480
        public void get_FileSystem(){} // RVA: 0x7AE1945B0
        public void set_FileSystem(){} // RVA: 0x7A8B4DC50
        public void get_DisableFileWrite(){} // RVA: 0x7AE194670
        public void set_DisableFileWrite(){} // RVA: 0x7AE194680
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7A8815B70
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7AE194690
        public void get_DefaultTags(){} // RVA: 0x7AE1946A0
        public void set_DefaultTags(){} // RVA: 0x7A80D8E20
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x7AE194760
        public void get_IsProfilingEnabled(){} // RVA: 0x7AE194860
        public void get_EnableTracing(){} // RVA: 0x7AE1949A0
        public void set_EnableTracing(){} // RVA: 0x7AE1949B0
        public void get_TracesSampleRate(){} // RVA: 0x7AE1949C0
        public void set_TracesSampleRate(){} // RVA: 0x7AE1949D0
        public void get_ProfilesSampleRate(){} // RVA: 0x7AE194AE0
        public void set_ProfilesSampleRate(){} // RVA: 0x7AE194AF0
        public void get_TracesSampler(){} // RVA: 0x7A8B562C0
        public void set_TracesSampler(){} // RVA: 0x7A8B4A930
        public void get_TracePropagationTargets(){} // RVA: 0x7A8B50AF0
        public void set_TracePropagationTargets(){} // RVA: 0x7AE194C00
        public void get_TransactionProfilerFactory(){} // RVA: 0x7A8B62DA0
        public void set_TransactionProfilerFactory(){} // RVA: 0x7A8B63900
        public void get_StackTraceMode(){} // RVA: 0x7AE194CA0
        public void set_StackTraceMode(){} // RVA: 0x7AE194EA0
        public void get_MaxAttachmentSize(){} // RVA: 0x7A8B4BD50
        public void set_MaxAttachmentSize(){} // RVA: 0x7AE194F00
        public void get_DetectStartupTime(){} // RVA: 0x7AE194F10
        public void set_DetectStartupTime(){} // RVA: 0x7AE194F20
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7A8B53E80
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7AE194F30
        public void get_AutoSessionTracking(){} // RVA: 0x7AE049B40
        public void set_AutoSessionTracking(){} // RVA: 0x7AE049B50
        public void get_UseAsyncFileIO(){} // RVA: 0x7AE049B60
        public void set_UseAsyncFileIO(){} // RVA: 0x7AE049B70
        public void get_CrashedLastRun(){} // RVA: 0x7A8B54430
        public void set_CrashedLastRun(){} // RVA: 0x7A8B580C0
        public void get_Instrumenter(){} // RVA: 0x7AE194F40
        public void set_Instrumenter(){} // RVA: 0x7AE194F50
        public void AddJsonConverter(){} // RVA: 0x7AE194F60
        public void AddJsonSerializerContext(){} // RVA: 0x7A7E18800
        public void get_JsonPreserveReferences(){} // RVA: 0x7AE195000
        public void set_JsonPreserveReferences(){} // RVA: 0x7AE1950A0
        public void get_NetworkStatusListener(){} // RVA: 0x7A8B45F80
        public void set_NetworkStatusListener(){} // RVA: 0x7A8B4BC00
        public void get_AssemblyReader(){} // RVA: 0x7A8B53F90
        public void set_AssemblyReader(){} // RVA: 0x7A8B4DEF0
        public void get_ExperimentalMetrics(){} // RVA: 0x7A8B54390
        public void set_ExperimentalMetrics(){} // RVA: 0x7A8593010
        public void get_SpotlightUrl(){} // RVA: 0x7A8B5B230
        public void set_SpotlightUrl(){} // RVA: 0x7A8B54C90
        public void get_EnableSpotlight(){} // RVA: 0x7AE195140
        public void set_EnableSpotlight(){} // RVA: 0x7AE195150
        public void get_SettingLocator(){} // RVA: 0x7A8B5BC30
        public void set_SettingLocator(){} // RVA: 0x7A8B4BB40
        public void get_InitNativeSdks(){} // RVA: 0x7AE195160
        public void set_InitNativeSdks(){} // RVA: 0x7AE195170
        public void get_PostInitCallbacks(){} // RVA: 0x7A8B4CA10
        public void set_PostInitCallbacks(){} // RVA: 0x7A8B5AB20
        public void .ctor(){} // RVA: 0x7AE195180
        public void AddIntegration(){} // RVA: 0x7AE1972A0
        public void RemoveIntegration(){} // RVA: 0x7A7E18770
        public void AddExceptionFilter(){} // RVA: 0x7AE197340
        public void RemoveExceptionFilter(){} // RVA: 0x7AA57D690
        public void AddExceptionFilterForType(){} // RVA: 0x7A7E18770
        public void AddInAppExclude(){} // RVA: 0x7AE197610
        public void AddInAppExcludeRegex(){} // RVA: 0x7AE1977C0
        public void AddInAppInclude(){} // RVA: 0x7AE197B70
        public void AddInAppIncludeRegex(){} // RVA: 0x7AE197D20
        public void AddExceptionProcessor(){} // RVA: 0x7AE197F20
        public void AddExceptionProcessors(){} // RVA: 0x7AE198110
        public void AddEventProcessor(){} // RVA: 0x7AE1982F0
        public void AddEventProcessors(){} // RVA: 0x7AE1984E0
        public void RemoveEventProcessor(){} // RVA: 0x7A7E18770
        public void AddEventProcessorProvider(){} // RVA: 0x7AE1986C0
        public void AddTransactionProcessor(){} // RVA: 0x7AE198720
        public void AddTransactionProcessors(){} // RVA: 0x7AE198830
        public void RemoveTransactionProcessor(){} // RVA: 0x7A7E18770
        public void AddTransactionProcessorProvider(){} // RVA: 0x7AE1989A0
        public void AddExceptionProcessorProvider(){} // RVA: 0x7AE198BA0
        public void GetAllEventProcessors(){} // RVA: 0x7AE198C00
        public void GetAllTransactionProcessors(){} // RVA: 0x7AE198D70
        public void GetAllExceptionProcessors(){} // RVA: 0x7AE198EE0
        public void UseStackTraceFactory(){} // RVA: 0x7AE199050
        public void ApplyDefaultTags(){} // RVA: 0x7AE199280
        public void DisableDuplicateEventDetection(){} // RVA: 0x7AE1996A0
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x7AE1996E0
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x7AE1996F0
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x7AE199700
        public void HasIntegration(){} // RVA: 0x7A7E01900
        public void RemoveDefaultIntegration(){} // RVA: 0x7AE199710
        public void SetupLogging(){} // RVA: 0x7AE199720
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x7AE199950
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x7AE199BB0
        public void <.ctor>b__346_0(){} // RVA: 0x7AE199BC0
        public void <.ctor>b__346_5(){} // RVA: 0x7AE199CF0
        public void <.ctor>b__346_1(){} // RVA: 0x7AE199D40
        public void <.ctor>b__346_2(){} // RVA: 0x7AE199DA0
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x7AE1932C0
        public void <.ctor>b__346_6(){} // RVA: 0x7AE199E30
        public void <.ctor>b__346_7(){} // RVA: 0x7AE199F80
        public void <.ctor>b__346_8(){} // RVA: 0x7AE19A180
        public void <.ctor>b__346_10(){} // RVA: 0x7AE19A2F0
        public void <.ctor>b__346_11(){} // RVA: 0x7AE19A430
        public void <.ctor>b__346_4(){} // RVA: 0x7AE19A5A0
    }

    public class SentryPackage : Object
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A80F2570
        public void get_Version(){} // RVA: 0x7A80DA7B0
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void WriteTo(){} // RVA: 0x7AE19B2D0
        public void FromJson(){} // RVA: 0x7AE19B400
        public void GetHashCode(){} // RVA: 0x7AE19B7B0
        public void Equals(){} // RVA: 0x7AE19B820
    }

    public class SentryPropagationContext : Object
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7A97277F0
        public void get_SpanId(){} // RVA: 0x7A81052C0
        public void get_ParentSpanId(){} // RVA: 0x7A8EDF360
        public void GetOrCreateDynamicSamplingContext(){} // RVA: 0x7AE19B940
        public void .ctor(){} // RVA: 0x7AE19BD40
        public void CreateFromHeaders(){} // RVA: 0x7AE19BEA0
    }

    public class SentryRequest : Object
    {
        // ── Methods ──
        public void get_InternalEnv(){} // RVA: 0x7A80F2570
        public void set_InternalEnv(){} // RVA: 0x7A80D8E20
        public void get_InternalOther(){} // RVA: 0x7A80DA7B0
        public void set_InternalOther(){} // RVA: 0x7A813E420
        public void get_InternalHeaders(){} // RVA: 0x7A81052C0
        public void set_InternalHeaders(){} // RVA: 0x7A81052D0
        public void get_Url(){} // RVA: 0x7A8105330
        public void set_Url(){} // RVA: 0x7A80D8E80
        public void get_Method(){} // RVA: 0x7A83F69F0
        public void set_Method(){} // RVA: 0x7A8105A90
        public void get_ApiTarget(){} // RVA: 0x7A8292C30
        public void set_ApiTarget(){} // RVA: 0x7A8296DE0
        public void get_Data(){} // RVA: 0x7A8154D80
        public void set_Data(){} // RVA: 0x7A80FF440
        public void get_QueryString(){} // RVA: 0x7A8152D80
        public void set_QueryString(){} // RVA: 0x7A8152D90
        public void get_Cookies(){} // RVA: 0x7A8178B90
        public void set_Cookies(){} // RVA: 0x7A8230620
        public void get_Headers(){} // RVA: 0x7AE19C0B0
        public void get_Env(){} // RVA: 0x7AE19C170
        public void get_Other(){} // RVA: 0x7AE19C230
        public void AddHeaders(){} // RVA: 0x7AE19C2F0
        public void Clone(){} // RVA: 0x7AE19C5E0
        public void CopyTo(){} // RVA: 0x7AE19C640
        public void WriteTo(){} // RVA: 0x7AE19C8E0
        public void FromJson(){} // RVA: 0x7AE19CB90
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SentrySdk : Object
    {
        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x7AE19D4A0
        public void get_LastEventId(){} // RVA: 0x7AE19D500
        public void InitHub(){} // RVA: 0x7AE19D5A0
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x7AE19DB90
        public void Init(){} // RVA: 0x7AE19E060
        public void UseHub(){} // RVA: 0x7AE19E200
        public void Flush(){} // RVA: 0x7AE19E440
        public void FlushAsync(){} // RVA: 0x7AE19E500
        public void Close(){} // RVA: 0x7AE19E590
        public void get_IsEnabled(){} // RVA: 0x7AE19E720
        public void PushScope(){} // RVA: 0x7AE19E7A0
        public void BindClient(){} // RVA: 0x7AE19E820
        public void AddBreadcrumb(){} // RVA: 0x7AE19EA00
        public void ConfigureScope(){} // RVA: 0x7AE19EA70
        public void ConfigureScopeAsync(){} // RVA: 0x7AE19EAF0
        public void CaptureEnvelope(){} // RVA: 0x7AE19EB70
        public void CaptureEvent(){} // RVA: 0x7AE19ED90
        public void CaptureException(){} // RVA: 0x7AE19EED0
        public void CaptureMessage(){} // RVA: 0x7AE19F0B0
        public void CaptureUserFeedback(){} // RVA: 0x7AE19F320
        public void CaptureTransaction(){} // RVA: 0x7AE19F4A0
        public void CaptureSession(){} // RVA: 0x7AE19F540
        public void CaptureCheckIn(){} // RVA: 0x7AE19F5C0
        public void StartTransaction(){} // RVA: 0x7AE19FA40
        public void BindException(){} // RVA: 0x7AE19FAD0
        public void GetSpan(){} // RVA: 0x7AE19FB60
        public void GetTraceHeader(){} // RVA: 0x7AE19FBE0
        public void GetBaggage(){} // RVA: 0x7AE19FC60
        public void ContinueTrace(){} // RVA: 0x7AE19FE20
        public void get_Metrics(){} // RVA: 0x7AE19FF60
        public void StartSession(){} // RVA: 0x7AE19FFE0
        public void EndSession(){} // RVA: 0x7AE1A0060
        public void PauseSession(){} // RVA: 0x7AE1A00F0
        public void ResumeSession(){} // RVA: 0x7AE1A0170
        public void CauseCrash(){} // RVA: 0x7AE1A01F0
        public void .cctor(){} // RVA: 0x7AE1A0820
    }

    public class SentrySession : Object
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A97277F0
        public void get_DistinctId(){} // RVA: 0x7A81052C0
        public void get_StartTimestamp(){} // RVA: 0x7A8EDF360
        public void get_Release(){} // RVA: 0x7A8292C30
        public void get_Environment(){} // RVA: 0x7A8154D80
        public void get_IpAddress(){} // RVA: 0x7A8152D80
        public void get_UserAgent(){} // RVA: 0x7A8178B90
        public void get_ErrorCount(){} // RVA: 0x7A87A7DA0
        public void .ctor(){} // RVA: 0x7AE1A0CD0
        public void ReportError(){} // RVA: 0x7AE1A0E40
        public void CreateUpdate(){} // RVA: 0x7AE1A0E50
    }

    public class SentrySpan : Object
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7A80F2570
        public void set_SpanId(){} // RVA: 0x7A97242F0
        public void get_ParentSpanId(){} // RVA: 0x7A872EEF0
        public void set_ParentSpanId(){} // RVA: 0x7A872E9B0
        public void get_TraceId(){} // RVA: 0x7A8EDF360
        public void set_TraceId(){} // RVA: 0x7A8EDB600
        public void get_StartTimestamp(){} // RVA: 0x7A972BD20
        public void set_StartTimestamp(){} // RVA: 0x7A9D7F7E0
        public void get_EndTimestamp(){} // RVA: 0x7AE1A0F00
        public void set_EndTimestamp(){} // RVA: 0x7AE1A0F20
        public void get_IsFinished(){} // RVA: 0x7AE1A0F40
        public void get_Measurements(){} // RVA: 0x7AE1A0F80
        public void SetMeasurement(){} // RVA: 0x7AE1A1040
        public void get_Operation(){} // RVA: 0x7A8153390
        public void set_Operation(){} // RVA: 0x7A81533A0
        public void get_Description(){} // RVA: 0x7A81A00E0
        public void set_Description(){} // RVA: 0x7A81A00F0
        public void get_Status(){} // RVA: 0x7A82C2060
        public void set_Status(){} // RVA: 0x7AD89C580
        public void get_IsSampled(){} // RVA: 0x7ADD851D0
        public void set_IsSampled(){} // RVA: 0x7ADE02E30
        public void get_Tags(){} // RVA: 0x7AE1A1160
        public void SetTag(){} // RVA: 0x7AE1A1230
        public void UnsetTag(){} // RVA: 0x7AE1A1360
        public void get_Extra(){} // RVA: 0x7AE1A1460
        public void SetExtra(){} // RVA: 0x7AE1A1530
        public void .ctor(){} // RVA: 0x7AE1A1820
        public void GetTraceHeader(){} // RVA: 0x7AE1A1E90
        public void WriteTo(){} // RVA: 0x7AE1A1F00
        public void FromJson(){} // RVA: 0x7AE1A2430
        public void Redact(){} // RVA: 0x7AE1A36A0
        public void get_Origin(){} // RVA: 0x7A87C5850
        public void set_Origin(){} // RVA: 0x7AE1A3750
    }

    public class SentryStackFrame : Object
    {
        // ── Methods ──
        public void get_InternalPreContext(){} // RVA: 0x7A80F2570
        public void set_InternalPreContext(){} // RVA: 0x7A80D8E20
        public void get_InternalPostContext(){} // RVA: 0x7A80DA7B0
        public void set_InternalPostContext(){} // RVA: 0x7A813E420
        public void get_InternalVars(){} // RVA: 0x7A81052C0
        public void set_InternalVars(){} // RVA: 0x7A81052D0
        public void get_InternalFramesOmitted(){} // RVA: 0x7A8105330
        public void set_InternalFramesOmitted(){} // RVA: 0x7A80D8E80
        public void get_IsCodeLocation(){} // RVA: 0x7A80FD690
        public void set_IsCodeLocation(){} // RVA: 0x7A80FD6A0
        public void get_FileName(){} // RVA: 0x7A8292C30
        public void set_FileName(){} // RVA: 0x7A8296DE0
        public void get_Function(){} // RVA: 0x7A8154D80
        public void set_Function(){} // RVA: 0x7A80FF440
        public void get_Module(){} // RVA: 0x7A8152D80
        public void set_Module(){} // RVA: 0x7A8152D90
        public void get_LineNumber(){} // RVA: 0x7A8178B90
        public void set_LineNumber(){} // RVA: 0x7A82C1E60
        public void get_ColumnNumber(){} // RVA: 0x7A81A0050
        public void set_ColumnNumber(){} // RVA: 0x7A82C2080
        public void get_AbsolutePath(){} // RVA: 0x7A8175DF0
        public void set_AbsolutePath(){} // RVA: 0x7A8175E00
        public void get_ContextLine(){} // RVA: 0x7A8153390
        public void set_ContextLine(){} // RVA: 0x7A81533A0
        public void get_PreContext(){} // RVA: 0x7AE1A3850
        public void get_PostContext(){} // RVA: 0x7AE1A3910
        public void get_InApp(){} // RVA: 0x7AE1A39D0
        public void set_InApp(){} // RVA: 0x7AE1A39E0
        public void get_Vars(){} // RVA: 0x7AE1A39F0
        public void get_FramesOmitted(){} // RVA: 0x7AE1A3AB0
        public void get_Package(){} // RVA: 0x7A82C2060
        public void set_Package(){} // RVA: 0x7A82C0530
        public void get_Platform(){} // RVA: 0x7A825E100
        public void set_Platform(){} // RVA: 0x7A825F860
        public void get_ImageAddress(){} // RVA: 0x7AD53B5F0
        public void set_ImageAddress(){} // RVA: 0x7AD53B600
        public void get_SymbolAddress(){} // RVA: 0x7A9E4C610
        public void set_SymbolAddress(){} // RVA: 0x7A9E4C620
        public void get_InstructionAddress(){} // RVA: 0x7AE1A3B70
        public void set_InstructionAddress(){} // RVA: 0x7AE1A3B80
        public void get_AddressMode(){} // RVA: 0x7A8142680
        public void set_AddressMode(){} // RVA: 0x7A8142690
        public void get_FunctionId(){} // RVA: 0x7AE1A3B90
        public void set_FunctionId(){} // RVA: 0x7AE1A3BA0
        public void WriteTo(){} // RVA: 0x7AE1A3BB0
        public void ConfigureAppFrame(){} // RVA: 0x7AE1A4830
        public void FromJson(){} // RVA: 0x7AE1A48E0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE1A64E0
    }

    public class SentryStackTrace : Object
    {
        // ── Methods ──
        public void get_InternalFrames(){} // RVA: 0x7A80F2570
        public void set_InternalFrames(){} // RVA: 0x7A80D8E20
        public void get_Frames(){} // RVA: 0x7AE1A6950
        public void set_Frames(){} // RVA: 0x7A80D8E20
        public void get_AddressAdjustment(){} // RVA: 0x7A80DA7B0
        public void set_AddressAdjustment(){} // RVA: 0x7A8A224D0
        public void WriteTo(){} // RVA: 0x7AE1A6A10
        public void FromJson(){} // RVA: 0x7AE1A6BF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SentryThread : Object
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A80F2570
        public void set_Id(){} // RVA: 0x7A97242F0
        public void get_Name(){} // RVA: 0x7A80DA7B0
        public void set_Name(){} // RVA: 0x7A813E420
        public void get_Crashed(){} // RVA: 0x7AC2A24B0
        public void set_Crashed(){} // RVA: 0x7AD8AE4B0
        public void get_Current(){} // RVA: 0x7AD8AE4C0
        public void set_Current(){} // RVA: 0x7AD8AE4D0
        public void get_Stacktrace(){} // RVA: 0x7A8105330
        public void set_Stacktrace(){} // RVA: 0x7A80D8E80
        public void WriteTo(){} // RVA: 0x7AE1A7140
        public void FromJson(){} // RVA: 0x7AE1A74C0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SentryTraceHeader : Object
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7A97277F0
        public void get_SpanId(){} // RVA: 0x7A81052C0
        public void get_IsSampled(){} // RVA: 0x7AC2A83C0
        public void .ctor(){} // RVA: 0x7AE1A7BB0
        public void ToString(){} // RVA: 0x7AE1A7BD0
        public void Parse(){} // RVA: 0x7AE1A7DB0
        public void .cctor(){} // RVA: 0x7AE1A8180
    }

    public class SentryTransaction : Object
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7A97277F0
        public void set_EventId(){} // RVA: 0x7A9727800
        public void get_SpanId(){} // RVA: 0x7AE1A82B0
        public void set_SpanId(){} // RVA: 0x7AE1A8320
        public void get_Origin(){} // RVA: 0x7AE1A83A0
        public void set_Origin(){} // RVA: 0x7AE1A8410
        public void get_ParentSpanId(){} // RVA: 0x7AE1A84A0
        public void set_ParentSpanId(){} // RVA: 0x7AE1A8530
        public void get_TraceId(){} // RVA: 0x7AE1A85B0
        public void set_TraceId(){} // RVA: 0x7AE1A8640
        public void get_Name(){} // RVA: 0x7A81052C0
        public void set_Name(){} // RVA: 0x7A81052D0
        public void get_NameSource(){} // RVA: 0x7A854FDE0
        public void get_IsParentSampled(){} // RVA: 0x7AE1A86C0
        public void set_IsParentSampled(){} // RVA: 0x7AE1A86D0
        public void get_Platform(){} // RVA: 0x7A83F69F0
        public void set_Platform(){} // RVA: 0x7A8105A90
        public void get_Release(){} // RVA: 0x7A8292C30
        public void set_Release(){} // RVA: 0x7A8296DE0
        public void get_Distribution(){} // RVA: 0x7A8154D80
        public void set_Distribution(){} // RVA: 0x7A80FF440
        public void get_StartTimestamp(){} // RVA: 0x7A8C859A0
        public void set_StartTimestamp(){} // RVA: 0x7A8C85990
        public void get_EndTimestamp(){} // RVA: 0x7A80E0E70
        public void set_EndTimestamp(){} // RVA: 0x7A80E0E90
        public void get_Measurements(){} // RVA: 0x7AE1A86E0
        public void SetMeasurement(){} // RVA: 0x7AE1A87A0
        public void get_Operation(){} // RVA: 0x7AE1A88C0
        public void set_Operation(){} // RVA: 0x7AE1A8930
        public void get_Description(){} // RVA: 0x7AE1A8A00
        public void set_Description(){} // RVA: 0x7AE1A8A70
        public void get_Status(){} // RVA: 0x7AE1A8B40
        public void set_Status(){} // RVA: 0x7AE1A8BB0
        public void get_IsSampled(){} // RVA: 0x7AE1A8C30
        public void set_IsSampled(){} // RVA: 0x7AE1A8CA0
        public void get_SampleRate(){} // RVA: 0x7AE088940
        public void set_SampleRate(){} // RVA: 0x7AE088950
        public void get_Level(){} // RVA: 0x7A897F560
        public void set_Level(){} // RVA: 0x7A8980300
        public void get_Request(){} // RVA: 0x7AE1A8DD0
        public void set_Request(){} // RVA: 0x7A8919DE0
        public void get_Contexts(){} // RVA: 0x7A87D9C10
        public void set_Contexts(){} // RVA: 0x7AE1A8E70
        public void get_User(){} // RVA: 0x7AE1A8EA0
        public void set_User(){} // RVA: 0x7A87446C0
        public void get_Environment(){} // RVA: 0x7A87D9480
        public void set_Environment(){} // RVA: 0x7A8881790
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7A81052C0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7AE1A8F40
        public void get_Sdk(){} // RVA: 0x7A8142610
        public void set_Sdk(){} // RVA: 0x7A8142620
        public void get_Fingerprint(){} // RVA: 0x7AE1A8FF0
        public void set_Fingerprint(){} // RVA: 0x7A8142690
        public void get_Breadcrumbs(){} // RVA: 0x7A81426F0
        public void get_Extra(){} // RVA: 0x7A82305B0
        public void get_Tags(){} // RVA: 0x7A81F50F0
        public void get_Spans(){} // RVA: 0x7A8854870
        public void get_IsFinished(){} // RVA: 0x7AE1A9040
        public void get_DynamicSamplingContext(){} // RVA: 0x7A8158FC0
        public void set_DynamicSamplingContext(){} // RVA: 0x7A8158FD0
        public void get_TransactionProfiler(){} // RVA: 0x7A8142870
        public void set_TransactionProfiler(){} // RVA: 0x7A8142880
        public void .ctor(){} // RVA: 0x7AE1A9950
        public void FromTracerSpans(){} // RVA: 0x7AE1AA6A0
        public void AddBreadcrumb(){} // RVA: 0x7AE1AB0C0
        public void SetExtra(){} // RVA: 0x7AE1AB120
        public void SetTag(){} // RVA: 0x7AE1AB1B0
        public void UnsetTag(){} // RVA: 0x7AE1AB240
        public void GetTraceHeader(){} // RVA: 0x7AE1AB2A0
        public void Redact(){} // RVA: 0x7AE1AB390
        public void WriteTo(){} // RVA: 0x7AE1AB8C0
        public void FromJson(){} // RVA: 0x7AE1AC300
    }

    public class SentryUser : Object
    {
        // ── Methods ──
        public void get_PropertyChanged(){} // RVA: 0x7A80F2570
        public void set_PropertyChanged(){} // RVA: 0x7A80D8E20
        public void get_Id(){} // RVA: 0x7A80DA7B0
        public void set_Id(){} // RVA: 0x7AE1AE690
        public void get_Username(){} // RVA: 0x7A81052C0
        public void set_Username(){} // RVA: 0x7AE1AE750
        public void get_Email(){} // RVA: 0x7A8105330
        public void set_Email(){} // RVA: 0x7AE1AE810
        public void get_IpAddress(){} // RVA: 0x7A83F69F0
        public void set_IpAddress(){} // RVA: 0x7AE1AE8D0
        public void get_Segment(){} // RVA: 0x7A8292C30
        public void set_Segment(){} // RVA: 0x7AE1AE990
        public void get_Other(){} // RVA: 0x7AE1AEA50
        public void set_Other(){} // RVA: 0x7AE1AEB10
        public void Clone(){} // RVA: 0x7AE1AEB80
        public void CopyTo(){} // RVA: 0x7AE1AEBE0
        public void HasAnyData(){} // RVA: 0x7AE1AEEA0
        public void WriteTo(){} // RVA: 0x7AE1AEF20
        public void FromJson(){} // RVA: 0x7AE1AF130
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SentryValues`1 : Object
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0x7A7E00680
        public void .ctor(){} // RVA: 0x7A7E18800
        public void WriteTo(){} // RVA: 0x7A7E18890
    }

    public class SessionUpdate : Object
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7A97277F0
        public void get_DistinctId(){} // RVA: 0x7A81052C0
        public void get_StartTimestamp(){} // RVA: 0x7A8EDF360
        public void get_Release(){} // RVA: 0x7A8292C30
        public void get_Environment(){} // RVA: 0x7A8154D80
        public void get_IpAddress(){} // RVA: 0x7A8152D80
        public void get_UserAgent(){} // RVA: 0x7A8178B90
        public void get_ErrorCount(){} // RVA: 0x7A87A7DA0
        public void get_IsInitial(){} // RVA: 0x7A8175CC0
        public void get_Timestamp(){} // RVA: 0x7AB491250
        public void get_SequenceNumber(){} // RVA: 0x7A8EA8210
        public void get_Duration(){} // RVA: 0x7AE1AF840
        public void get_EndStatus(){} // RVA: 0x7AE1AF8C0
        public void .ctor(){} // RVA: 0x7AE1AFD20
        public void WriteTo(){} // RVA: 0x7AE1AFD60
        public void FromJson(){} // RVA: 0x7AE1B0470
    }

    public class SpanContext : Object
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7A80F2570
        public void get_ParentSpanId(){} // RVA: 0x7A872EEF0
        public void get_TraceId(){} // RVA: 0x7A8EDF360
        public void get_Operation(){} // RVA: 0x7A8292C30
        public void set_Operation(){} // RVA: 0x7A8296DE0
        public void get_Description(){} // RVA: 0x7A8154D80
        public void get_Status(){} // RVA: 0x7A8152D80
        public void get_IsSampled(){} // RVA: 0x7ABFD44A0
        public void get_Instrumenter(){} // RVA: 0x7A8A22410
        public void set_Instrumenter(){} // RVA: 0x7A8A25530
        public void get_Origin(){} // RVA: 0x7A81A0050
        public void set_Origin(){} // RVA: 0x7AE1B1AF0
        public void .ctor(){} // RVA: 0x7AE1B1BF0
    }

    public class SpanDataExtensions : Object
    {
        // ── Methods ──
        public void SetMeasurement(){} // RVA: 0x7AE097590
    }

    public class SpanExtensions : Object
    {
        // ── Methods ──
        public void StartChild(){} // RVA: 0x7AE0968F0
        public void GetTransaction(){} // RVA: 0x7AE096B30
        public void GetDbParentSpan(){} // RVA: 0x7AE096C20
    }

    public class SpanId : ValueType
    {
        // ── Methods ──
        public void GetValue(){} // RVA: 0x7A765F710
        public void .ctor(){} // RVA: 0x7A767FEF0
        public void Equals(){} // RVA: 0x7A7E75AF0
        public void GetHashCode(){} // RVA: 0x7A7E75B00
        public void ToString(){} // RVA: 0x7A7E75B10
        public void Create(){} // RVA: 0x7AE1B2220
        public void WriteTo(){} // RVA: 0x7A7E75B20
        public void Parse(){} // RVA: 0x7AE1B26A0
        public void FromJson(){} // RVA: 0x7AE1B26D0
        public void op_Equality(){} // RVA: 0x7AE1B27D0
        public void op_Inequality(){} // RVA: 0x7AE1B2860
        public void op_Implicit(){} // RVA: 0x7AE1B28D0
        public void .cctor(){} // RVA: 0x7AE1B2920
    }

    public class SpanStatusConverter : Object
    {
        // ── Methods ──
        public void FromException(){} // RVA: 0x7AE1B2AB0
        public void FromHttpStatusCode(){} // RVA: 0x7AE1B2D30
        public void FromGrpcStatusCode(){} // RVA: 0x7AE1B2DF0
    }

    public class SpanTracer : Object
    {
        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7AE1B2EC0
        public void get_Transaction(){} // RVA: 0x7A8292C30
        public void get_MetricsSummary(){} // RVA: 0x7AE1B2ED0
        public void get_HasMetrics(){} // RVA: 0x7AE1B2F20
        public void get_SpanId(){} // RVA: 0x7A8152D80
        public void set_SpanId(){} // RVA: 0x7A9558880
        public void get_ParentSpanId(){} // RVA: 0x7ABFD09C0
        public void set_ParentSpanId(){} // RVA: 0x7AD927FD0
        public void get_TraceId(){} // RVA: 0x7AB491250
        public void get_StartTimestamp(){} // RVA: 0x7ADE02E10
        public void set_StartTimestamp(){} // RVA: 0x7ADE02E20
        public void get_EndTimestamp(){} // RVA: 0x7A8C11B00
        public void set_EndTimestamp(){} // RVA: 0x7A8C11E80
        public void get_IsFinished(){} // RVA: 0x7AE1B2F70
        public void get_InternalMeasurements(){} // RVA: 0x7A87D9C10
        public void set_InternalMeasurements(){} // RVA: 0x7A8744720
        public void get_Measurements(){} // RVA: 0x7AE1B2FB0
        public void SetMeasurement(){} // RVA: 0x7AE1B3080
        public void get_Operation(){} // RVA: 0x7A87C5850
        public void set_Operation(){} // RVA: 0x7A87446C0
        public void get_Description(){} // RVA: 0x7A87D9480
        public void set_Description(){} // RVA: 0x7A8881790
        public void get_Status(){} // RVA: 0x7A8142610
        public void set_Status(){} // RVA: 0x7A9905F10
        public void get_IsSentryRequest(){} // RVA: 0x7A94FA690
        public void set_IsSentryRequest(){} // RVA: 0x7A94F9900
        public void get_IsSampled(){} // RVA: 0x7AE1B31B0
        public void set_IsSampled(){} // RVA: 0x7AE1B31C0
        public void get_InternalTags(){} // RVA: 0x7A81426F0
        public void set_InternalTags(){} // RVA: 0x7A8142700
        public void get_Tags(){} // RVA: 0x7AE1B31D0
        public void SetTag(){} // RVA: 0x7AE1B32A0
        public void UnsetTag(){} // RVA: 0x7AE1B33C0
        public void get_Extra(){} // RVA: 0x7A82305B0
        public void SetExtra(){} // RVA: 0x7AE1B3530
        public void get_IsFiltered(){} // RVA: 0x7A81F50F0
        public void set_IsFiltered(){} // RVA: 0x7A81F5100
        public void .ctor(){} // RVA: 0x7AE1B38C0
        public void StartChild(){} // RVA: 0x7AE1B3BD0
        public void Unfinish(){} // RVA: 0x7AE1B3C20
        public void Finish(){} // RVA: 0x7AE1B4280
        public void GetTraceHeader(){} // RVA: 0x7AE1B42C0
        public void get_Origin(){} // RVA: 0x7A8854870
        public void set_Origin(){} // RVA: 0x7AE1B4330
    }

    public class StreamAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetStream(){} // RVA: 0x7A80F2570
    }

    public class SubstringOrRegexPattern : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void op_Implicit(){} // RVA: 0x7AE1B4570
        public void ToString(){} // RVA: 0x7AE1B4600
        public void Equals(){} // RVA: 0x7AE1B4670
        public void GetHashCode(){} // RVA: 0x7A9CC18D0
        public void get_Regex(){} // RVA: 0x7A80F2570
        public void IsMatch(){} // RVA: 0x7AE1B4760
        public void TryParseRegex(){} // RVA: 0x7AE1B4900
    }

    public class SubstringOrRegexPatternExtensions : Object
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x7AE1B49B0
        public void WithConfigBinding(){} // RVA: 0x7A7E00BA0
    }

    public class SubstringOrRegexPatternTypeConverter : TypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7AE1B4AD0
        public void ConvertFrom(){} // RVA: 0x7AE1B4BA0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SubstringOrRegexPattern[] : Array
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

}