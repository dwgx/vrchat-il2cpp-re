// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 44
// Methods: 986

namespace ThirdParty.Sentry.Sentry
{
    public class Scope
    {
        // ── Methods ──
        public void get_Options(){} // RVA: 0x7FFAF2DA8380
        public void get_Locked(){} // RVA: 0x7FFAF2DA84E0
        public void set_Locked(){} // RVA: 0x7FFAF2DA84F0
        public void get_LastEventId(){} // RVA: 0x7FFAF8D667D0
        public void set_LastEventId(){} // RVA: 0x7FFAF8D66920
        public void get_HasEvaluated(){} // RVA: 0x7FFAF8D66A60
        public void get_ExceptionProcessors(){} // RVA: 0x7FFAF8D66A70
        public void get_EventProcessors(){} // RVA: 0x7FFAF8D66AC0
        public void get_TransactionProcessors(){} // RVA: 0x7FFAF8D66B10
        public void add_OnEvaluating(){} // RVA: 0x7FFAF8D66B60
        public void remove_OnEvaluating(){} // RVA: 0x7FFAF8D66C60
        public void get_Level(){} // RVA: 0x7FFAF4741440
        public void set_Level(){} // RVA: 0x7FFAF4741450
        public void get_Request(){} // RVA: 0x7FFAF8D66D60
        public void set_Request(){} // RVA: 0x7FFAF2E555A0
        public void get_Contexts(){} // RVA: 0x7FFAF2F77C50
        public void set_Contexts(){} // RVA: 0x7FFAF8D66E00
        public void get_UserChanged(){} // RVA: 0x7FFAF8D66E20
        public void get_User(){} // RVA: 0x7FFAF8D66EA0
        public void set_User(){} // RVA: 0x7FFAF8D66FC0
        public void get_Release(){} // RVA: 0x7FFAF2DCC010
        public void set_Release(){} // RVA: 0x7FFAF2F13060
        public void get_Distribution(){} // RVA: 0x7FFAF3246DE0
        public void set_Distribution(){} // RVA: 0x7FFAF3604600
        public void get_Environment(){} // RVA: 0x7FFAF34CC8C0
        public void set_Environment(){} // RVA: 0x7FFAF345A650
        public void get_TransactionName(){} // RVA: 0x7FFAF8D67090
        public void set_TransactionName(){} // RVA: 0x7FFAF8D670F0
        public void get_Transaction(){} // RVA: 0x7FFAF34CC130
        public void set_Transaction(){} // RVA: 0x7FFAF3595030
        public void get_PropagationContext(){} // RVA: 0x7FFAF2DF8040
        public void set_PropagationContext(){} // RVA: 0x7FFAF2DF8050
        public void get_SessionUpdate(){} // RVA: 0x7FFAF2DF80B0
        public void set_SessionUpdate(){} // RVA: 0x7FFAF2DF80C0
        public void get_Sdk(){} // RVA: 0x7FFAF2DF8120
        public void get_Fingerprint(){} // RVA: 0x7FFAF2EE5460
        public void set_Fingerprint(){} // RVA: 0x7FFAF2EE5470
        public void get_Breadcrumbs(){} // RVA: 0x7FFAF2EAA100
        public void get_Extra(){} // RVA: 0x7FFAF3546D30
        public void get_Tags(){} // RVA: 0x7FFAF2E0E900
        public void get_Attachments(){} // RVA: 0x7FFAF2E0E970
        public void .ctor(){} // RVA: 0x7FFAF8D67B00 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8D67BE0 | overloaded x2
        public void SetExtra(){} // RVA: 0x7FFAF8D67E10
        public void SetTag(){} // RVA: 0x7FFAF8D67EC0
        public void UnsetTag(){} // RVA: 0x7FFAF8D68070
        public void AddAttachment(){} // RVA: 0x7FFAF8D6BBE0 | overloaded x4
        public void Clear(){} // RVA: 0x7FFAF8D681E0
        public void ClearAttachments(){} // RVA: 0x7FFAF8D68820
        public void ClearBreadcrumbs(){} // RVA: 0x7FFAF8D688D0
        public void Apply(){} // RVA: 0x7FFAF8D69EF0 | overloaded x3
        public void Clone(){} // RVA: 0x7FFAF8D69FD0
        public void Evaluate(){} // RVA: 0x7FFAF8D6A840
        public void get_Span(){} // RVA: 0x7FFAF8D6AAE0
        public void set_Span(){} // RVA: 0x7FFAF2DF82B0
        public void GetAllEventProcessors(){} // RVA: 0x7FFAF8D6ABD0
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFAF8D6AC80
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFAF8D6AD30
        public void AddExceptionProcessor(){} // RVA: 0x7FFAF8D6ADE0
        public void AddExceptionProcessors(){} // RVA: 0x7FFAF8D6AE70
        public void AddEventProcessor(){} // RVA: 0x7FFAF8D6B140 | overloaded x2
        public void AddEventProcessors(){} // RVA: 0x7FFAF8D6B260
        public void AddTransactionProcessor(){} // RVA: 0x7FFAF8D6B530 | overloaded x2
        public void AddTransactionProcessors(){} // RVA: 0x7FFAF8D6B650
        public void ResetTransaction(){} // RVA: 0x7FFAF8D6BD60
        public void <get_UserChanged>b__41_0(){} // RVA: 0x7FFAF8D6BDC0
    }

    public class SdkVersion
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8E41B00
        public void get_InternalPackages(){} // RVA: 0x7FFAF2DA8380
        public void set_InternalPackages(){} // RVA: 0x7FFAF2D8EE30
        public void get_Integrations(){} // RVA: 0x7FFAF2D907C0
        public void set_Integrations(){} // RVA: 0x7FFAF2DF3E80
        public void get_Packages(){} // RVA: 0x7FFAF2DA8380
        public void get_Name(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Name(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Version(){} // RVA: 0x7FFAF2DBB130
        public void set_Version(){} // RVA: 0x7FFAF2D8EE90
        public void AddPackage(){} // RVA: 0x7FFAF8E41C40 | overloaded x2
        public void AddIntegration(){} // RVA: 0x7FFAF8E41CA0
        public void WriteTo(){} // RVA: 0x7FFAF8E41D00
        public void FromJson(){} // RVA: 0x7FFAF8E41F80
        public void .ctor(){} // RVA: 0x7FFAF8E42B80
        public void .cctor(){} // RVA: 0x7FFAF8E42CE0
    }

    public class SentryAttachment
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Content(){} // RVA: 0x7FFAF2D907C0
        public void get_FileName(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ContentType(){} // RVA: 0x7FFAF2DBB130
        public void .ctor(){} // RVA: 0x7FFAF86AA280
    }

    public class SentryCheckIn
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF441ABE0
        public void get_MonitorSlug(){} // RVA: 0x7FFAF2DBB0C0
        public void get_Status(){} // RVA: 0x7FFAF3241DC0
        public void get_Duration(){} // RVA: 0x7FFAF8778940
        public void set_Duration(){} // RVA: 0x7FFAF8778950
        public void get_Release(){} // RVA: 0x7FFAF2E0A740
        public void set_Release(){} // RVA: 0x7FFAF2DB5200
        public void get_Environment(){} // RVA: 0x7FFAF2E08730
        public void set_Environment(){} // RVA: 0x7FFAF2E08740
        public void get_TraceId(){} // RVA: 0x7FFAF6CC82F0
        public void set_TraceId(){} // RVA: 0x7FFAF8E43150
        public void get_MonitorOptions(){} // RVA: 0x7FFAF2E08D50
        public void set_MonitorOptions(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAF8E43160
        public void WriteTo(){} // RVA: 0x7FFAF8E432B0
        public void ToSnakeCase(){} // RVA: 0x7FFAF8E437B0
    }

    public class SentryClient
    {
        // ── Methods ──
        public void get_Worker(){} // RVA: 0x7FFAF30E74D0
        public void get_Options(){} // RVA: 0x7FFAF2DA8380
        public void get_IsEnabled(){} // RVA: 0x7FFAF2E72850
        public void .ctor(){} // RVA: 0x7FFAF8E438E0 | overloaded x2
        public void CaptureEvent(){} // RVA: 0x7FFAF8E43EC0
        public void CaptureUserFeedback(){} // RVA: 0x7FFAF8E44070
        public void CaptureTransaction(){} // RVA: 0x7FFAF8E44370 | overloaded x2
        public void BeforeSendTransaction(){} // RVA: 0x7FFAF8E44FB0
        public void CaptureSession(){} // RVA: 0x7FFAF8E452B0
        public void CaptureCheckIn(){} // RVA: 0x7FFAF8E45440
        public void FlushAsync(){} // RVA: 0x7FFAF8E45A20
        public void DoSendEvent(){} // RVA: 0x7FFAF8E45A80
        public void ApplyExceptionFilters(){} // RVA: 0x7FFAF8E46EF0
        public void CaptureEnvelope(){} // RVA: 0x7FFAF8E47220
        public void BeforeSend(){} // RVA: 0x7FFAF8E473F0
        public void Dispose(){} // RVA: 0x7FFAF8E476F0
    }

    public class SentryClientExtensions
    {
        // ── Methods ──
        public void CaptureException(){} // RVA: 0x7FFAF8E479A0
        public void CaptureMessage(){} // RVA: 0x7FFAF8E47B10
        public void CaptureUserFeedback(){} // RVA: 0x7FFAF8E47CE0
        public void Flush(){} // RVA: 0x7FFAF8E47E60 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFAF8E47F40
        public void get_SentryOptionsForTestingOnly(){} // RVA: 0x7FFAF8E47FE0
        public void set_SentryOptionsForTestingOnly(){} // RVA: 0x7FFAF8E48020
        public void GetSentryOptions(){} // RVA: 0x7FFAF8E480C0
    }

    public class SentryConstants
    {
    }

    public class SentryContexts
    {
        // ── Methods ──
        public void get_App(){} // RVA: 0x7FFAF8E48230
        public void get_Browser(){} // RVA: 0x7FFAF8E48290
        public void get_Device(){} // RVA: 0x7FFAF8E482F0
        public void get_OperatingSystem(){} // RVA: 0x7FFAF8E48350
        public void get_Response(){} // RVA: 0x7FFAF8E483B0
        public void get_Runtime(){} // RVA: 0x7FFAF8E48410
        public void get_Gpu(){} // RVA: 0x7FFAF8E48470
        public void get_Trace(){} // RVA: 0x7FFAF8E484D0
        public void .ctor(){} // RVA: 0x7FFAF8E48530
        public void Clone(){} // RVA: 0x7FFAF8E48670
        public void CopyTo(){} // RVA: 0x7FFAF8E49DD0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAF8E48A50
        public void FromJson(){} // RVA: 0x7FFAF8E48CD0
        public void ReplaceWith(){} // RVA: 0x7FFAF8E49820
        public void NullIfEmpty(){} // RVA: 0x7FFAF8E49AD0
        public void GetEnumerator(){} // RVA: 0x7FFAF8E49B30
        public void System.Collections.IEnumerable.GetEnumerator(){} // RVA: 0x7FFAF8E49B80
        public void Add(){} // RVA: 0x7FFAF8E4A020 | overloaded x2
        public void Clear(){} // RVA: 0x7FFAF8E49CA0
        public void Contains(){} // RVA: 0x7FFAF8E49CF0
        public void Remove(){} // RVA: 0x7FFAF8E4A110 | overloaded x2
        public void get_Count(){} // RVA: 0x7FFAF8E49F80
        public void get_IsReadOnly(){} // RVA: 0x7FFAF8E49FD0
        public void ContainsKey(){} // RVA: 0x7FFAF8E4A0B0
        public void TryGetValue(){} // RVA: 0x7FFAF8E4A170
        public void get_Item(){} // RVA: 0x7FFAF8E4A350
        public void set_Item(){} // RVA: 0x7FFAF8E4A3B0
        public void get_Keys(){} // RVA: 0x7FFAF8E4A420
        public void get_Values(){} // RVA: 0x7FFAF8E4A480
    }

    public class SentryEvent
    {
        // ── Methods ──
        public void get_Exception(){} // RVA: 0x7FFAF2D907C0
        public void get_EventId(){} // RVA: 0x7FFAF49AB630
        public void get_Timestamp(){} // RVA: 0x7FFAF8778940
        public void get_Message(){} // RVA: 0x7FFAF2E0A740
        public void set_Message(){} // RVA: 0x7FFAF2DB5200
        public void get_Logger(){} // RVA: 0x7FFAF2E08730
        public void set_Logger(){} // RVA: 0x7FFAF2E08740
        public void get_Platform(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Platform(){} // RVA: 0x7FFAF2EE54D0
        public void get_ServerName(){} // RVA: 0x7FFAF2E55500
        public void set_ServerName(){} // RVA: 0x7FFAF2E55510
        public void get_Release(){} // RVA: 0x7FFAF2E2B370
        public void set_Release(){} // RVA: 0x7FFAF2E2B380
        public void get_Distribution(){} // RVA: 0x7FFAF2E08D50
        public void set_Distribution(){} // RVA: 0x7FFAF2E08D60
        public void get_SentryExceptionValues(){} // RVA: 0x7FFAF2E55590
        public void set_SentryExceptionValues(){} // RVA: 0x7FFAF2E555A0
        public void get_SentryExceptions(){} // RVA: 0x7FFAF8E4A9B0
        public void set_SentryExceptions(){} // RVA: 0x7FFAF8E4AA20
        public void get_SentryThreadValues(){} // RVA: 0x7FFAF2F77C50
        public void set_SentryThreadValues(){} // RVA: 0x7FFAF2F734F0
        public void get_SentryThreads(){} // RVA: 0x7FFAF8E4AB50
        public void set_SentryThreads(){} // RVA: 0x7FFAF8E4ABC0
        public void get_DebugImages(){} // RVA: 0x7FFAF8E4ACF0
        public void set_DebugImages(){} // RVA: 0x7FFAF8E4AD10
        public void get_Modules(){} // RVA: 0x7FFAF8E4AE30
        public void get_Level(){} // RVA: 0x7FFAF36690C0
        public void set_Level(){} // RVA: 0x7FFAF3669E60
        public void get_TransactionName(){} // RVA: 0x7FFAF3246DE0
        public void set_TransactionName(){} // RVA: 0x7FFAF3604600
        public void get_Request(){} // RVA: 0x7FFAF8E4AEF0
        public void set_Request(){} // RVA: 0x7FFAF345A650
        public void get_Contexts(){} // RVA: 0x7FFAF34B85E0
        public void set_Contexts(){} // RVA: 0x7FFAF8E4AF90
        public void get_User(){} // RVA: 0x7FFAF8E4AFC0
        public void set_User(){} // RVA: 0x7FFAF3595030
        public void get_Environment(){} // RVA: 0x7FFAF2DF8040
        public void set_Environment(){} // RVA: 0x7FFAF2DF8050
        public void get_Sdk(){} // RVA: 0x7FFAF2DF80B0
        public void set_Sdk(){} // RVA: 0x7FFAF2DF80C0
        public void get_Fingerprint(){} // RVA: 0x7FFAF8E4B060
        public void set_Fingerprint(){} // RVA: 0x7FFAF2DF8130
        public void get_Breadcrumbs(){} // RVA: 0x7FFAF8E4B0B0
        public void get_Extra(){} // RVA: 0x7FFAF8E4B180
        public void get_Tags(){} // RVA: 0x7FFAF8E4B250
        public void HasException(){} // RVA: 0x7FFAF8E4B320
        public void HasTerminalException(){} // RVA: 0x7FFAF8E4B390
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFAF2E0E900
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFAF2E0E910
        public void .ctor(){} // RVA: 0x7FFAF8E4B7B0 | overloaded x3
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8E4BBE0
        public void SetExtra(){} // RVA: 0x7FFAF8E4BCE0
        public void SetTag(){} // RVA: 0x7FFAF8E4BE10
        public void UnsetTag(){} // RVA: 0x7FFAF8E4BF40
        public void Redact(){} // RVA: 0x7FFAF8E4C040
        public void WriteTo(){} // RVA: 0x7FFAF8E4C2A0
        public void FromJson(){} // RVA: 0x7FFAF8E4CAF0 | overloaded x2
    }

    public class SentryFailedRequestHandler
    {
        // ── Methods ──
        public void get_Hub(){} // RVA: 0x7FFAF2DA8380
        public void get_Options(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFAF2ADDC60
        public void HandleResponse(){} // RVA: 0x7FFAF8E4F380
    }

    public class SentryGraphQLHttpFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E4F5A0
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFAF8E4F720
    }

    public class SentryGraphQLHttpMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E4FFB0 | overloaded x2
        public void ProcessRequest(){} // RVA: 0x7FFAF8E50340
        public void HandleResponse(){} // RVA: 0x7FFAF8E50700
        public void GetSpanDescriptionOrDefault(){} // RVA: 0x7FFAF8E50DE0
        public void AddIfExists(){} // RVA: 0x7FFAF8E50FF0
    }

    public class SentryHint
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E51310 | overloaded x3
        public void get_Attachments(){} // RVA: 0x7FFAF2D907C0
        public void get_Items(){} // RVA: 0x7FFAF8E51440
        public void AddAttachmentsFromScope(){} // RVA: 0x7FFAF8E51500
        public void AddAttachment(){} // RVA: 0x7FFAF8E51700 | overloaded x2
        public void WithAttachments(){} // RVA: 0x7FFAF8E518E0 | overloaded x2
    }

    public class SentryHttpFailedRequestHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E51980
        public void DoEnsureSuccessfulResponse(){} // RVA: 0x7FFAF8E51990
    }

    public class SentryHttpMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E52080 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x7FFAF8E522D0
        public void HandleResponse(){} // RVA: 0x7FFAF8E52500
    }

    public class SentryId
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4503740
        public void ToString(){} // RVA: 0x7FFAF8E52840
        public void Equals(){} // RVA: 0x7FFAF8E528E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8E529C0
        public void Create(){} // RVA: 0x7FFAF8E529E0
        public void WriteTo(){} // RVA: 0x7FFAF8E52A40
        public void Parse(){} // RVA: 0x7FFAF8942F40
        public void FromJson(){} // RVA: 0x7FFAF8E52B70
        public void op_Equality(){} // RVA: 0x7FFAF8E52D60
        public void op_Inequality(){} // RVA: 0x7FFAF8E52E10
        public void op_Implicit(){} // RVA: 0x7FFAF320E7E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SentryMessage
    {
        // ── Methods ──
        public void get_Message(){} // RVA: 0x7FFAF2DA8380
        public void set_Message(){} // RVA: 0x7FFAF2D8EE30
        public void get_Params(){} // RVA: 0x7FFAF2D907C0
        public void set_Params(){} // RVA: 0x7FFAF2DF3E80
        public void get_Formatted(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Formatted(){} // RVA: 0x7FFAF2DBB0D0
        public void op_Implicit(){} // RVA: 0x7FFAF8E52EF0
        public void WriteTo(){} // RVA: 0x7FFAF8E52F90
        public void FromJson(){} // RVA: 0x7FFAF8E530F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SentryMessageHandler
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E53AF0 | overloaded x5
        public void ProcessRequest(){} // RVA: 0x7FFAF2ACEE30
        public void HandleResponse(){} // RVA: 0x7FFAF2ADF9F0
        public void SendAsync(){} // RVA: 0x7FFAF8E53CF0
        public void PropagateTraceHeaders(){} // RVA: 0x7FFAF8E53F40
        public void AddSentryTraceHeader(){} // RVA: 0x7FFAF8E54360
        public void AddBaggageHeader(){} // RVA: 0x7FFAF8E544B0
        public void <>n__0(){} // RVA: 0x7FFAF8E54B40
    }

    public class SentryMonitorOptions
    {
        // ── Methods ──
        public void CrontabValidation(){} // RVA: 0x7FFAF8E553E0
        public void Interval(){} // RVA: 0x7FFAF8E557A0 | overloaded x2
        public void get_CheckInMargin(){} // RVA: 0x7FFAF8778940
        public void set_CheckInMargin(){} // RVA: 0x7FFAF8778950
        public void get_MaxRuntime(){} // RVA: 0x7FFAF4A56340
        public void set_MaxRuntime(){} // RVA: 0x7FFAF6F19B20
        public void get_FailureIssueThreshold(){} // RVA: 0x7FFAF2E2E0E0
        public void set_FailureIssueThreshold(){} // RVA: 0x7FFAF8E55880
        public void get_RecoveryThreshold(){} // RVA: 0x7FFAF2E55500
        public void set_RecoveryThreshold(){} // RVA: 0x7FFAF8E55930
        public void get_TimeZone(){} // RVA: 0x7FFAF2E2B370
        public void set_TimeZone(){} // RVA: 0x7FFAF2E2B380
        public void get_Owner(){} // RVA: 0x7FFAF2E08D50
        public void set_Owner(){} // RVA: 0x7FFAF2E08D60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void WriteTo(){} // RVA: 0x7FFAF8E559E0
        public void TypeToString(){} // RVA: 0x7FFAF8E561E0
    }

    public class SentryOptions
    {
        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFAF2D907C0
        public void set_ScopeStackContainer(){} // RVA: 0x7FFAF2DF3E80
        public void get_InstallationId(){} // RVA: 0x7FFAF8E562D0
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFAF8E56320
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFAF8E56450
        public void get_ScopeObserver(){} // RVA: 0x7FFAF30E74D0
        public void set_ScopeObserver(){} // RVA: 0x7FFAF2DBB890
        public void get_EnableScopeSync(){} // RVA: 0x7FFAF2F56500
        public void set_EnableScopeSync(){} // RVA: 0x7FFAF2F578C0
        public void get_Transport(){} // RVA: 0x7FFAF2E0A740
        public void set_Transport(){} // RVA: 0x7FFAF2DB5200
        public void get_ClientReportRecorder(){} // RVA: 0x7FFAF8E564A0
        public void set_ClientReportRecorder(){} // RVA: 0x7FFAF8E564F0
        public void get_SentryStackTraceFactory(){} // RVA: 0x7FFAF8E566D0
        public void set_SentryStackTraceFactory(){} // RVA: 0x7FFAF8E56720
        public void get_SentryVersion(){} // RVA: 0x7FFAF349AB90
        public void get_ExceptionProcessors(){} // RVA: 0x7FFAF2E2B370
        public void set_ExceptionProcessors(){} // RVA: 0x7FFAF2E2B380
        public void get_TransactionProcessors(){} // RVA: 0x7FFAF2E08D50
        public void set_TransactionProcessors(){} // RVA: 0x7FFAF2E08D60
        public void get_EventProcessors(){} // RVA: 0x7FFAF2E55590
        public void set_EventProcessors(){} // RVA: 0x7FFAF2E555A0
        public void get_EventProcessorsProviders(){} // RVA: 0x7FFAF2F77C50
        public void set_EventProcessorsProviders(){} // RVA: 0x7FFAF2F734F0
        public void get_TransactionProcessorsProviders(){} // RVA: 0x7FFAF2F12D00
        public void set_TransactionProcessorsProviders(){} // RVA: 0x7FFAF2F14450
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x7FFAF2DCC010
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x7FFAF2F13060
        public void get_Integrations(){} // RVA: 0x7FFAF8E56900
        public void get_ExceptionFilters(){} // RVA: 0x7FFAF34CC8C0
        public void set_ExceptionFilters(){} // RVA: 0x7FFAF345A650
        public void get_TagFilters(){} // RVA: 0x7FFAF34B85E0
        public void set_TagFilters(){} // RVA: 0x7FFAF345A5F0
        public void get_BackgroundWorker(){} // RVA: 0x7FFAF34CC130
        public void set_BackgroundWorker(){} // RVA: 0x7FFAF3595030
        public void get_SentryHttpClientFactory(){} // RVA: 0x7FFAF2DF8040
        public void set_SentryHttpClientFactory(){} // RVA: 0x7FFAF2DF8050
        public void GetHttpClient(){} // RVA: 0x7FFAF8E569B0
        public void get_SentryScopeStateProcessor(){} // RVA: 0x7FFAF2DF80B0
        public void set_SentryScopeStateProcessor(){} // RVA: 0x7FFAF2DF80C0
        public void get_InAppExclude(){} // RVA: 0x7FFAF2DF8120
        public void set_InAppExclude(){} // RVA: 0x7FFAF2DF8130
        public void get_InAppInclude(){} // RVA: 0x7FFAF2EE5460
        public void set_InAppInclude(){} // RVA: 0x7FFAF2EE5470
        public void get_SendDefaultPii(){} // RVA: 0x7FFAF3359980
        public void set_SendDefaultPii(){} // RVA: 0x7FFAF3C7E870
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFAF3C7EE00
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFAF8E56A90
        public void get_ServerName(){} // RVA: 0x7FFAF3546D30
        public void set_ServerName(){} // RVA: 0x7FFAF2E0E8A0
        public void get_AttachStacktrace(){} // RVA: 0x7FFAF2EB8F80
        public void set_AttachStacktrace(){} // RVA: 0x7FFAF2EB8F90
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAF475C8E0
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFAF68A13F0
        public void get_SampleRate(){} // RVA: 0x7FFAF2E0E970
        public void set_SampleRate(){} // RVA: 0x7FFAF8E56AA0
        public void get_Release(){} // RVA: 0x7FFAF2DF82A0
        public void set_Release(){} // RVA: 0x7FFAF2DF82B0
        public void get_Distribution(){} // RVA: 0x7FFAF32A7DB0
        public void set_Distribution(){} // RVA: 0x7FFAF30ED280
        public void get_Environment(){} // RVA: 0x7FFAF3544E10
        public void set_Environment(){} // RVA: 0x7FFAF37A6DE0
        public void get_Dsn(){} // RVA: 0x7FFAF35402E0
        public void set_Dsn(){} // RVA: 0x7FFAF8E56B90
        public void get_ParsedDsn(){} // RVA: 0x7FFAF8E56C60
        public void IsSentryRequest(){} // RVA: 0x7FFAF8E56EB0 | overloaded x2
        public void get_BeforeSendInternal(){} // RVA: 0x7FFAF304E660
        public void SetBeforeSend(){} // RVA: 0x7FFAF8E57020 | overloaded x2
        public void get_BeforeSendTransactionInternal(){} // RVA: 0x7FFAF353EE80
        public void SetBeforeSendTransaction(){} // RVA: 0x7FFAF8E571A0 | overloaded x2
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x7FFAF353E870
        public void SetBeforeBreadcrumb(){} // RVA: 0x7FFAF8E57320 | overloaded x2
        public void get_MaxQueueItems(){} // RVA: 0x7FFAF3CBA360
        public void set_MaxQueueItems(){} // RVA: 0x7FFAF8E574A0
        public void get_MaxCacheItems(){} // RVA: 0x7FFAF8BDFB40
        public void set_MaxCacheItems(){} // RVA: 0x7FFAF8E57560
        public void get_ShutdownTimeout(){} // RVA: 0x7FFAF2DF85F0
        public void set_ShutdownTimeout(){} // RVA: 0x7FFAF8E57620
        public void get_FlushTimeout(){} // RVA: 0x7FFAF2DF8660
        public void set_FlushTimeout(){} // RVA: 0x7FFAF8D4CBE0
        public void get_DecompressionMethods(){} // RVA: 0x7FFAF3CBA160
        public void set_DecompressionMethods(){} // RVA: 0x7FFAF3CBB830
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFAF8E57630
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFAF8E57640
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAF8E57650
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAF8E57660
        public void get_SendClientReports(){} // RVA: 0x7FFAF3D1D220
        public void set_SendClientReports(){} // RVA: 0x7FFAF3D1D230
        public void get_HttpProxy(){} // RVA: 0x7FFAF3331BC0
        public void set_HttpProxy(){} // RVA: 0x7FFAF33287E0
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7FFAF3843DD0
        public void set_CreateHttpMessageHandler(){} // RVA: 0x7FFAF3843D70
        public void get_ConfigureClient(){} // RVA: 0x7FFAF32E0040
        public void set_ConfigureClient(){} // RVA: 0x7FFAF383E320
        public void get_Debug(){} // RVA: 0x7FFAF8E57670
        public void set_Debug(){} // RVA: 0x7FFAF8E57680
        public void get_DiagnosticLevel(){} // RVA: 0x7FFAF8E57690
        public void set_DiagnosticLevel(){} // RVA: 0x7FFAF8E576A0
        public void get_DiagnosticLogger(){} // RVA: 0x7FFAF8E576B0
        public void set_DiagnosticLogger(){} // RVA: 0x7FFAF8E576D0
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAF332D820
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFAF8E57810
        public void get_DeduplicateMode(){} // RVA: 0x7FFAF8D2D120
        public void set_DeduplicateMode(){} // RVA: 0x7FFAF8E57820
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFAF3540180
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFAF3846D90
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAF8E57830
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFAF8E57840
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFAF3861150
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFAF3845560
        public void get_FailedRequestTargets(){} // RVA: 0x7FFAF8E57850
        public void set_FailedRequestTargets(){} // RVA: 0x7FFAF8E578A0
        public void get_FileSystem(){} // RVA: 0x7FFAF8E579D0
        public void set_FileSystem(){} // RVA: 0x7FFAF383AAB0
        public void get_DisableFileWrite(){} // RVA: 0x7FFAF8E57A90
        public void set_DisableFileWrite(){} // RVA: 0x7FFAF8E57AA0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFAF3507F60
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFAF8E57AB0
        public void get_DefaultTags(){} // RVA: 0x7FFAF8E57AC0
        public void set_DefaultTags(){} // RVA: 0x7FFAF2D8EE30
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x7FFAF8E57B80
        public void get_IsProfilingEnabled(){} // RVA: 0x7FFAF8E57C80
        public void get_EnableTracing(){} // RVA: 0x7FFAF8E57DC0
        public void set_EnableTracing(){} // RVA: 0x7FFAF8E57DD0
        public void get_TracesSampleRate(){} // RVA: 0x7FFAF8E57DE0
        public void set_TracesSampleRate(){} // RVA: 0x7FFAF8E57DF0
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFAF8E57F00
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFAF8E57F10
        public void get_TracesSampler(){} // RVA: 0x7FFAF3842860
        public void set_TracesSampler(){} // RVA: 0x7FFAF3837940
        public void get_TracePropagationTargets(){} // RVA: 0x7FFAF383D540
        public void set_TracePropagationTargets(){} // RVA: 0x7FFAF8E58020
        public void get_TransactionProfilerFactory(){} // RVA: 0x7FFAF384E9A0
        public void set_TransactionProfilerFactory(){} // RVA: 0x7FFAF384F490
        public void get_StackTraceMode(){} // RVA: 0x7FFAF8E580C0
        public void set_StackTraceMode(){} // RVA: 0x7FFAF8E582C0
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFAF3838BD0
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFAF8E58320
        public void get_DetectStartupTime(){} // RVA: 0x7FFAF8E58330
        public void set_DetectStartupTime(){} // RVA: 0x7FFAF8E58340
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFAF3840650
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFAF8E58350
        public void get_AutoSessionTracking(){} // RVA: 0x7FFAF8D0DEA0
        public void set_AutoSessionTracking(){} // RVA: 0x7FFAF8D0DEB0
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFAF8D0DEC0
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFAF8D0DED0
        public void get_CrashedLastRun(){} // RVA: 0x7FFAF3840BA0
        public void set_CrashedLastRun(){} // RVA: 0x7FFAF3844430
        public void get_Instrumenter(){} // RVA: 0x7FFAF8E58360
        public void set_Instrumenter(){} // RVA: 0x7FFAF8E58370
        public void AddJsonConverter(){} // RVA: 0x7FFAF8E58380
        public void AddJsonSerializerContext(){} // RVA: 0x7FFAF2AD4B10
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFAF8E58420
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFAF8E584C0
        public void get_NetworkStatusListener(){} // RVA: 0x7FFAF3833050
        public void set_NetworkStatusListener(){} // RVA: 0x7FFAF3838A80
        public void get_AssemblyReader(){} // RVA: 0x7FFAF3840760
        public void set_AssemblyReader(){} // RVA: 0x7FFAF383AD50
        public void get_ExperimentalMetrics(){} // RVA: 0x7FFAF3840B00
        public void set_ExperimentalMetrics(){} // RVA: 0x7FFAF32A86C0
        public void get_SpotlightUrl(){} // RVA: 0x7FFAF38473A0
        public void set_SpotlightUrl(){} // RVA: 0x7FFAF3841360
        public void get_EnableSpotlight(){} // RVA: 0x7FFAF8E58560
        public void set_EnableSpotlight(){} // RVA: 0x7FFAF8E58570
        public void get_SettingLocator(){} // RVA: 0x7FFAF3847D00
        public void set_SettingLocator(){} // RVA: 0x7FFAF38389C0
        public void get_InitNativeSdks(){} // RVA: 0x7FFAF8E58580
        public void set_InitNativeSdks(){} // RVA: 0x7FFAF8E58590
        public void get_PostInitCallbacks(){} // RVA: 0x7FFAF3839900
        public void set_PostInitCallbacks(){} // RVA: 0x7FFAF3846B10
        public void .ctor(){} // RVA: 0x7FFAF8E585A0
        public void AddIntegration(){} // RVA: 0x7FFAF8E5A6C0
        public void RemoveIntegration(){} // RVA: 0x7FFAF2AD4A50
        public void AddExceptionFilter(){} // RVA: 0x7FFAF8E5A760
        public void RemoveExceptionFilter(){} // RVA: 0x7FFAF2AD4A50
        public void AddExceptionFilterForType(){} // RVA: 0x7FFAF2AD4A50
        public void AddInAppExclude(){} // RVA: 0x7FFAF8E5AA30 | overloaded x2
        public void AddInAppExcludeRegex(){} // RVA: 0x7FFAF8E5ABE0
        public void AddInAppInclude(){} // RVA: 0x7FFAF8E5AF90 | overloaded x2
        public void AddInAppIncludeRegex(){} // RVA: 0x7FFAF8E5B140
        public void AddExceptionProcessor(){} // RVA: 0x7FFAF8E5B340
        public void AddExceptionProcessors(){} // RVA: 0x7FFAF8E5B530
        public void AddEventProcessor(){} // RVA: 0x7FFAF8E5B700
        public void AddEventProcessors(){} // RVA: 0x7FFAF8E5B8F0
        public void RemoveEventProcessor(){} // RVA: 0x7FFAF2AD4A50
        public void AddEventProcessorProvider(){} // RVA: 0x7FFAF8E5BAC0
        public void AddTransactionProcessor(){} // RVA: 0x7FFAF8E5BB20
        public void AddTransactionProcessors(){} // RVA: 0x7FFAF8E5BC30
        public void RemoveTransactionProcessor(){} // RVA: 0x7FFAF2AD4A50
        public void AddTransactionProcessorProvider(){} // RVA: 0x7FFAF8E5BDA0
        public void AddExceptionProcessorProvider(){} // RVA: 0x7FFAF8E5BF90
        public void GetAllEventProcessors(){} // RVA: 0x7FFAF8E5BFF0
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFAF8E5C160
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFAF8E5C2D0
        public void UseStackTraceFactory(){} // RVA: 0x7FFAF8E5C440
        public void ApplyDefaultTags(){} // RVA: 0x7FFAF8E5C670
        public void DisableDuplicateEventDetection(){} // RVA: 0x7FFAF8E5CA70
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x7FFAF8E5CAB0
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x7FFAF8E5CAC0
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x7FFAF8E5CAD0
        public void HasIntegration(){} // RVA: 0x7FFAF2ABDBE0
        public void RemoveDefaultIntegration(){} // RVA: 0x7FFAF8E5CAE0
        public void SetupLogging(){} // RVA: 0x7FFAF8E5CAF0
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x7FFAF8E5CD20
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x7FFAF8E5CF80
        public void <.ctor>b__346_0(){} // RVA: 0x7FFAF8E5CF90
        public void <.ctor>b__346_5(){} // RVA: 0x7FFAF8E5D0C0
        public void <.ctor>b__346_1(){} // RVA: 0x7FFAF8E5D110
        public void <.ctor>b__346_2(){} // RVA: 0x7FFAF8E5D170
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x7FFAF8E566D0
        public void <.ctor>b__346_6(){} // RVA: 0x7FFAF8E5D200
        public void <.ctor>b__346_7(){} // RVA: 0x7FFAF8E5D350
        public void <.ctor>b__346_8(){} // RVA: 0x7FFAF8E5D550
        public void <.ctor>b__346_10(){} // RVA: 0x7FFAF8E5D6C0
        public void <.ctor>b__346_11(){} // RVA: 0x7FFAF8E5D800
        public void <.ctor>b__346_4(){} // RVA: 0x7FFAF8E5D970
    }

    public class SentryPackage
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF2DA8380
        public void get_Version(){} // RVA: 0x7FFAF2D907C0
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void WriteTo(){} // RVA: 0x7FFAF8E5E6A0
        public void FromJson(){} // RVA: 0x7FFAF8E5E7B0
        public void GetHashCode(){} // RVA: 0x7FFAF8E5EA00
        public void Equals(){} // RVA: 0x7FFAF8E5EA70
    }

    public class SentryPropagationContext
    {
        public object InternalEnv;
        public object InternalOther;
        public object InternalHeaders;

        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFAF441ABE0
        public void get_SpanId(){} // RVA: 0x7FFAF2DBB0C0
        public void get_ParentSpanId(){} // RVA: 0x7FFAF3BCF520
        public void GetOrCreateDynamicSamplingContext(){} // RVA: 0x7FFAF8E5EB90
        public void .ctor(){} // RVA: 0x7FFAF8E5EF90 | overloaded x3
        public void CreateFromHeaders(){} // RVA: 0x7FFAF8E5F0F0
    }

    public class SentryRequest
    {
        // ── Methods ──
        public void get_InternalEnv(){} // RVA: 0x7FFAF2DA8380
        public void set_InternalEnv(){} // RVA: 0x7FFAF2D8EE30
        public void get_InternalOther(){} // RVA: 0x7FFAF2D907C0
        public void set_InternalOther(){} // RVA: 0x7FFAF2DF3E80
        public void get_InternalHeaders(){} // RVA: 0x7FFAF2DBB0C0
        public void set_InternalHeaders(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Url(){} // RVA: 0x7FFAF2DBB130
        public void set_Url(){} // RVA: 0x7FFAF2D8EE90
        public void get_Method(){} // RVA: 0x7FFAF30E74D0
        public void set_Method(){} // RVA: 0x7FFAF2DBB890
        public void get_ApiTarget(){} // RVA: 0x7FFAF2F476A0
        public void set_ApiTarget(){} // RVA: 0x7FFAF2F4B830
        public void get_Data(){} // RVA: 0x7FFAF2E0A740
        public void set_Data(){} // RVA: 0x7FFAF2DB5200
        public void get_QueryString(){} // RVA: 0x7FFAF2E08730
        public void set_QueryString(){} // RVA: 0x7FFAF2E08740
        public void get_Cookies(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Cookies(){} // RVA: 0x7FFAF2EE54D0
        public void get_Headers(){} // RVA: 0x7FFAF8E5F300
        public void get_Env(){} // RVA: 0x7FFAF8E5F3C0
        public void get_Other(){} // RVA: 0x7FFAF8E5F480
        public void AddHeaders(){} // RVA: 0x7FFAF8E5F540
        public void Clone(){} // RVA: 0x7FFAF8E5F830
        public void CopyTo(){} // RVA: 0x7FFAF8E5F890
        public void WriteTo(){} // RVA: 0x7FFAF8E5FB30
        public void FromJson(){} // RVA: 0x7FFAF8E5FDB0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SentrySdk
    {
        public object IndexIsValid;
        public object Nodes;
        public object Stream;

        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x7FFAF8E606C0
        public void get_LastEventId(){} // RVA: 0x7FFAF8E60720
        public void InitHub(){} // RVA: 0x7FFAF8E607C0
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x7FFAF8E60DA0
        public void Init(){} // RVA: 0x7FFAF8E61270 | overloaded x4
        public void UseHub(){} // RVA: 0x7FFAF8E61410
        public void Flush(){} // RVA: 0x7FFAF8E61650 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFAF8E61710 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF8E617A0
        public void get_IsEnabled(){} // RVA: 0x7FFAF8E61930
        public void PushScope(){} // RVA: 0x7FFAF8E619B0 | overloaded x2
        public void BindClient(){} // RVA: 0x7FFAF8E61A30
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8E61C10 | overloaded x3
        public void ConfigureScope(){} // RVA: 0x7FFAF8E61C80
        public void ConfigureScopeAsync(){} // RVA: 0x7FFAF8E61D00
        public void CaptureEnvelope(){} // RVA: 0x7FFAF8E61D80
        public void CaptureEvent(){} // RVA: 0x7FFAF8E61FA0 | overloaded x3
        public void CaptureException(){} // RVA: 0x7FFAF8E620E0 | overloaded x2
        public void CaptureMessage(){} // RVA: 0x7FFAF8E622C0 | overloaded x2
        public void CaptureUserFeedback(){} // RVA: 0x7FFAF8E62530 | overloaded x2
        public void CaptureTransaction(){} // RVA: 0x7FFAF8E626B0 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFAF8E62750
        public void CaptureCheckIn(){} // RVA: 0x7FFAF8E627D0
        public void StartTransaction(){} // RVA: 0x7FFAF8E62C70 | overloaded x6
        public void BindException(){} // RVA: 0x7FFAF8E62D00
        public void GetSpan(){} // RVA: 0x7FFAF8E62D90
        public void GetTraceHeader(){} // RVA: 0x7FFAF8E62E10
        public void GetBaggage(){} // RVA: 0x7FFAF8E62E90
        public void ContinueTrace(){} // RVA: 0x7FFAF8E63050 | overloaded x2
        public void get_Metrics(){} // RVA: 0x7FFAF8E63190
        public void StartSession(){} // RVA: 0x7FFAF8E63210
        public void EndSession(){} // RVA: 0x7FFAF8E63290
        public void PauseSession(){} // RVA: 0x7FFAF8E63320
        public void ResumeSession(){} // RVA: 0x7FFAF8E633A0
        public void CauseCrash(){} // RVA: 0x7FFAF8E63420
        public void .cctor(){} // RVA: 0x7FFAF8E63A50
    }

    public class SentrySession
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF441ABE0
        public void get_DistinctId(){} // RVA: 0x7FFAF2DBB0C0
        public void get_StartTimestamp(){} // RVA: 0x7FFAF3BCF520
        public void get_Release(){} // RVA: 0x7FFAF2F476A0
        public void get_Environment(){} // RVA: 0x7FFAF2E0A740
        public void get_IpAddress(){} // RVA: 0x7FFAF2E08730
        public void get_UserAgent(){} // RVA: 0x7FFAF2E2E0E0
        public void get_ErrorCount(){} // RVA: 0x7FFAF349AB90
        public void .ctor(){} // RVA: 0x7FFAF8E63F00 | overloaded x2
        public void ReportError(){} // RVA: 0x7FFAF8E640A0
        public void CreateUpdate(){} // RVA: 0x7FFAF8E640B0
    }

    public class SentrySpan
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFAF2DA8380
        public void set_SpanId(){} // RVA: 0x7FFAF4417700
        public void get_ParentSpanId(){} // RVA: 0x7FFAF3444EE0
        public void set_ParentSpanId(){} // RVA: 0x7FFAF34449A0
        public void get_TraceId(){} // RVA: 0x7FFAF3BCF520
        public void set_TraceId(){} // RVA: 0x7FFAF3BCC380
        public void get_StartTimestamp(){} // RVA: 0x7FFAF441F080
        public void set_StartTimestamp(){} // RVA: 0x7FFAF4A24CD0
        public void get_EndTimestamp(){} // RVA: 0x7FFAF8E64160
        public void set_EndTimestamp(){} // RVA: 0x7FFAF8E64180
        public void get_IsFinished(){} // RVA: 0x7FFAF8E641A0
        public void get_Measurements(){} // RVA: 0x7FFAF8E641E0
        public void SetMeasurement(){} // RVA: 0x7FFAF8E642A0
        public void get_Operation(){} // RVA: 0x7FFAF2E08D50
        public void set_Operation(){} // RVA: 0x7FFAF2E08D60
        public void get_Description(){} // RVA: 0x7FFAF2E55590
        public void set_Description(){} // RVA: 0x7FFAF2E555A0
        public void get_Status(){} // RVA: 0x7FFAF2F77C50
        public void set_Status(){} // RVA: 0x7FFAF855F010
        public void get_IsSampled(){} // RVA: 0x7FFAF8A48EF0
        public void set_IsSampled(){} // RVA: 0x7FFAF8AC62B0
        public void get_Tags(){} // RVA: 0x7FFAF8E643C0
        public void SetTag(){} // RVA: 0x7FFAF8E64490
        public void UnsetTag(){} // RVA: 0x7FFAF8E645C0
        public void get_Extra(){} // RVA: 0x7FFAF8E646C0
        public void SetExtra(){} // RVA: 0x7FFAF8E64790
        public void .ctor(){} // RVA: 0x7FFAF8E64A80 | overloaded x2
        public void GetTraceHeader(){} // RVA: 0x7FFAF8E650F0
        public void WriteTo(){} // RVA: 0x7FFAF8E65160
        public void FromJson(){} // RVA: 0x7FFAF8E65660
        public void Redact(){} // RVA: 0x7FFAF8E66820
        public void get_Origin(){} // RVA: 0x7FFAF34B85E0
        public void set_Origin(){} // RVA: 0x7FFAF8E668D0
    }

    public class SentryStackFrame
    {
        // ── Methods ──
        public void get_InternalPreContext(){} // RVA: 0x7FFAF2DA8380
        public void set_InternalPreContext(){} // RVA: 0x7FFAF2D8EE30
        public void get_InternalPostContext(){} // RVA: 0x7FFAF2D907C0
        public void set_InternalPostContext(){} // RVA: 0x7FFAF2DF3E80
        public void get_InternalVars(){} // RVA: 0x7FFAF2DBB0C0
        public void set_InternalVars(){} // RVA: 0x7FFAF2DBB0D0
        public void get_InternalFramesOmitted(){} // RVA: 0x7FFAF2DBB130
        public void set_InternalFramesOmitted(){} // RVA: 0x7FFAF2D8EE90
        public void get_IsCodeLocation(){} // RVA: 0x7FFAF2DB3450
        public void set_IsCodeLocation(){} // RVA: 0x7FFAF2DB3460
        public void get_FileName(){} // RVA: 0x7FFAF2F476A0
        public void set_FileName(){} // RVA: 0x7FFAF2F4B830
        public void get_Function(){} // RVA: 0x7FFAF2E0A740
        public void set_Function(){} // RVA: 0x7FFAF2DB5200
        public void get_Module(){} // RVA: 0x7FFAF2E08730
        public void set_Module(){} // RVA: 0x7FFAF2E08740
        public void get_LineNumber(){} // RVA: 0x7FFAF2E2E0E0
        public void set_LineNumber(){} // RVA: 0x7FFAF2F74D50
        public void get_ColumnNumber(){} // RVA: 0x7FFAF2E55500
        public void set_ColumnNumber(){} // RVA: 0x7FFAF2F734E0
        public void get_AbsolutePath(){} // RVA: 0x7FFAF2E2B370
        public void set_AbsolutePath(){} // RVA: 0x7FFAF2E2B380
        public void get_ContextLine(){} // RVA: 0x7FFAF2E08D50
        public void set_ContextLine(){} // RVA: 0x7FFAF2E08D60
        public void get_PreContext(){} // RVA: 0x7FFAF8E669D0
        public void get_PostContext(){} // RVA: 0x7FFAF8E66A90
        public void get_InApp(){} // RVA: 0x7FFAF8E66B50
        public void set_InApp(){} // RVA: 0x7FFAF8E66B60
        public void get_Vars(){} // RVA: 0x7FFAF8E66B70
        public void get_FramesOmitted(){} // RVA: 0x7FFAF8E66C30
        public void get_Package(){} // RVA: 0x7FFAF2F77C50
        public void set_Package(){} // RVA: 0x7FFAF2F734F0
        public void get_Platform(){} // RVA: 0x7FFAF2F12D00
        public void set_Platform(){} // RVA: 0x7FFAF2F14450
        public void get_ImageAddress(){} // RVA: 0x7FFAF821C5E0
        public void set_ImageAddress(){} // RVA: 0x7FFAF821C5F0
        public void get_SymbolAddress(){} // RVA: 0x7FFAF4AEB2D0
        public void set_SymbolAddress(){} // RVA: 0x7FFAF4AEB2E0
        public void get_InstructionAddress(){} // RVA: 0x7FFAF8E66CF0
        public void set_InstructionAddress(){} // RVA: 0x7FFAF8E66D00
        public void get_AddressMode(){} // RVA: 0x7FFAF2DF80B0
        public void set_AddressMode(){} // RVA: 0x7FFAF2DF80C0
        public void get_FunctionId(){} // RVA: 0x7FFAF8E66D10
        public void set_FunctionId(){} // RVA: 0x7FFAF8E66D20
        public void WriteTo(){} // RVA: 0x7FFAF8E66D30
        public void ConfigureAppFrame(){} // RVA: 0x7FFAF8E67980 | overloaded x2
        public void FromJson(){} // RVA: 0x7FFAF8E67A30
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8E69610
    }

    public class SentryStackTrace
    {
        // ── Methods ──
        public void get_InternalFrames(){} // RVA: 0x7FFAF2DA8380
        public void set_InternalFrames(){} // RVA: 0x7FFAF2D8EE30
        public void get_Frames(){} // RVA: 0x7FFAF8E69A80
        public void set_Frames(){} // RVA: 0x7FFAF2D8EE30
        public void get_AddressAdjustment(){} // RVA: 0x7FFAF2D907C0
        public void set_AddressAdjustment(){} // RVA: 0x7FFAF370BE60
        public void WriteTo(){} // RVA: 0x7FFAF8E69B40
        public void FromJson(){} // RVA: 0x7FFAF8E69CF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SentryThread
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF2DA8380
        public void set_Id(){} // RVA: 0x7FFAF4417700
        public void get_Name(){} // RVA: 0x7FFAF2D907C0
        public void set_Name(){} // RVA: 0x7FFAF2DF3E80
        public void get_Crashed(){} // RVA: 0x7FFAF6F64370
        public void set_Crashed(){} // RVA: 0x7FFAF8570F20
        public void get_Current(){} // RVA: 0x7FFAF8570F30
        public void set_Current(){} // RVA: 0x7FFAF8570F40
        public void get_Stacktrace(){} // RVA: 0x7FFAF2DBB130
        public void set_Stacktrace(){} // RVA: 0x7FFAF2D8EE90
        public void WriteTo(){} // RVA: 0x7FFAF8E6A240
        public void FromJson(){} // RVA: 0x7FFAF8E6A590
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SentryTraceHeader
    {
        // ── Methods ──
        public void get_TraceId(){} // RVA: 0x7FFAF441ABE0
        public void get_SpanId(){} // RVA: 0x7FFAF2DBB0C0
        public void get_IsSampled(){} // RVA: 0x7FFAF6F697F0
        public void .ctor(){} // RVA: 0x7FFAF8E6AC80
        public void ToString(){} // RVA: 0x7FFAF8E6ACA0
        public void Parse(){} // RVA: 0x7FFAF8E6AE80
        public void .cctor(){} // RVA: 0x7FFAF8E6B250
    }

    public class SentryTransaction
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFAF441ABE0
        public void set_EventId(){} // RVA: 0x7FFAF441ABF0
        public void get_SpanId(){} // RVA: 0x7FFAF8E6B380
        public void set_SpanId(){} // RVA: 0x7FFAF8E6B3F0
        public void get_Origin(){} // RVA: 0x7FFAF8E6B470
        public void set_Origin(){} // RVA: 0x7FFAF8E6B4E0
        public void get_ParentSpanId(){} // RVA: 0x7FFAF8E6B570
        public void set_ParentSpanId(){} // RVA: 0x7FFAF8E6B600
        public void get_TraceId(){} // RVA: 0x7FFAF8E6B680
        public void set_TraceId(){} // RVA: 0x7FFAF8E6B710
        public void get_Name(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Name(){} // RVA: 0x7FFAF2DBB0D0
        public void get_NameSource(){} // RVA: 0x7FFAF3241DC0
        public void get_IsParentSampled(){} // RVA: 0x7FFAF8E6B790
        public void set_IsParentSampled(){} // RVA: 0x7FFAF8E6B7A0
        public void get_Platform(){} // RVA: 0x7FFAF30E74D0
        public void set_Platform(){} // RVA: 0x7FFAF2DBB890
        public void get_Release(){} // RVA: 0x7FFAF2F476A0
        public void set_Release(){} // RVA: 0x7FFAF2F4B830
        public void get_Distribution(){} // RVA: 0x7FFAF2E0A740
        public void set_Distribution(){} // RVA: 0x7FFAF2DB5200
        public void get_StartTimestamp(){} // RVA: 0x7FFAF396B920
        public void set_StartTimestamp(){} // RVA: 0x7FFAF396B910
        public void get_EndTimestamp(){} // RVA: 0x7FFAF2D96E50
        public void set_EndTimestamp(){} // RVA: 0x7FFAF2D96E70
        public void get_Measurements(){} // RVA: 0x7FFAF8E6B7B0
        public void SetMeasurement(){} // RVA: 0x7FFAF8E6B870
        public void get_Operation(){} // RVA: 0x7FFAF8E6B990
        public void set_Operation(){} // RVA: 0x7FFAF8E6BA00
        public void get_Description(){} // RVA: 0x7FFAF8E6BAD0
        public void set_Description(){} // RVA: 0x7FFAF8E6BB40
        public void get_Status(){} // RVA: 0x7FFAF8E6BC10
        public void set_Status(){} // RVA: 0x7FFAF8E6BC80
        public void get_IsSampled(){} // RVA: 0x7FFAF8E6BD00
        public void set_IsSampled(){} // RVA: 0x7FFAF8E6BD70
        public void get_SampleRate(){} // RVA: 0x7FFAF8D4CA70
        public void set_SampleRate(){} // RVA: 0x7FFAF8D4CA80
        public void get_Level(){} // RVA: 0x7FFAF36690C0
        public void set_Level(){} // RVA: 0x7FFAF3669E60
        public void get_Request(){} // RVA: 0x7FFAF8E6BEA0
        public void set_Request(){} // RVA: 0x7FFAF3604600
        public void get_Contexts(){} // RVA: 0x7FFAF34CC8C0
        public void set_Contexts(){} // RVA: 0x7FFAF8E6BF40
        public void get_User(){} // RVA: 0x7FFAF8E6BF70
        public void set_User(){} // RVA: 0x7FFAF345A5F0
        public void get_Environment(){} // RVA: 0x7FFAF34CC130
        public void set_Environment(){} // RVA: 0x7FFAF3595030
        public void Sentry.IEventLike.get_TransactionName(){} // RVA: 0x7FFAF2DBB0C0
        public void Sentry.IEventLike.set_TransactionName(){} // RVA: 0x7FFAF8E6C010
        public void get_Sdk(){} // RVA: 0x7FFAF2DF8040
        public void set_Sdk(){} // RVA: 0x7FFAF2DF8050
        public void get_Fingerprint(){} // RVA: 0x7FFAF8E6C0C0
        public void set_Fingerprint(){} // RVA: 0x7FFAF2DF80C0
        public void get_Breadcrumbs(){} // RVA: 0x7FFAF2DF8120
        public void get_Extra(){} // RVA: 0x7FFAF2EE5460
        public void get_Tags(){} // RVA: 0x7FFAF2EAA100
        public void get_Spans(){} // RVA: 0x7FFAF3546D30
        public void get_IsFinished(){} // RVA: 0x7FFAF8E6C110
        public void get_DynamicSamplingContext(){} // RVA: 0x7FFAF2E0E970
        public void set_DynamicSamplingContext(){} // RVA: 0x7FFAF2E0E980
        public void get_TransactionProfiler(){} // RVA: 0x7FFAF2DF82A0
        public void set_TransactionProfiler(){} // RVA: 0x7FFAF2DF82B0
        public void .ctor(){} // RVA: 0x7FFAF8E6CA10 | overloaded x4
        public void FromTracerSpans(){} // RVA: 0x7FFAF8E6D760
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8E6E170
        public void SetExtra(){} // RVA: 0x7FFAF8E6E1D0
        public void SetTag(){} // RVA: 0x7FFAF8E6E260
        public void UnsetTag(){} // RVA: 0x7FFAF8E6E2F0
        public void GetTraceHeader(){} // RVA: 0x7FFAF8E6E350
        public void Redact(){} // RVA: 0x7FFAF8E6E440
        public void WriteTo(){} // RVA: 0x7FFAF8E6E970
        public void FromJson(){} // RVA: 0x7FFAF8E6F370
    }

    public class SentryUser
    {
        // ── Methods ──
        public void get_PropertyChanged(){} // RVA: 0x7FFAF2DA8380
        public void set_PropertyChanged(){} // RVA: 0x7FFAF2D8EE30
        public void get_Id(){} // RVA: 0x7FFAF2D907C0
        public void set_Id(){} // RVA: 0x7FFAF8E71700
        public void get_Username(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Username(){} // RVA: 0x7FFAF8E717C0
        public void get_Email(){} // RVA: 0x7FFAF2DBB130
        public void set_Email(){} // RVA: 0x7FFAF8E71880
        public void get_IpAddress(){} // RVA: 0x7FFAF30E74D0
        public void set_IpAddress(){} // RVA: 0x7FFAF8E71940
        public void get_Segment(){} // RVA: 0x7FFAF2F476A0
        public void set_Segment(){} // RVA: 0x7FFAF8E71A00
        public void get_Other(){} // RVA: 0x7FFAF8E71AC0
        public void set_Other(){} // RVA: 0x7FFAF8E71B80
        public void Clone(){} // RVA: 0x7FFAF8E71BF0
        public void CopyTo(){} // RVA: 0x7FFAF8E71C50
        public void HasAnyData(){} // RVA: 0x7FFAF8E71F00
        public void WriteTo(){} // RVA: 0x7FFAF8E71F80
        public void FromJson(){} // RVA: 0x7FFAF8E72170
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SentryValues`1 : Values
    {
        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFAF2ABCD60
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void WriteTo(){} // RVA: 0x7FFAF2ADDC60
    }

    public class SessionUpdate
    {
        // ── Methods ──
        public void get_Id(){} // RVA: 0x7FFAF441ABE0
        public void get_DistinctId(){} // RVA: 0x7FFAF2DBB0C0
        public void get_StartTimestamp(){} // RVA: 0x7FFAF3BCF520
        public void get_Release(){} // RVA: 0x7FFAF2F476A0
        public void get_Environment(){} // RVA: 0x7FFAF2E0A740
        public void get_IpAddress(){} // RVA: 0x7FFAF2E08730
        public void get_UserAgent(){} // RVA: 0x7FFAF2E2E0E0
        public void get_ErrorCount(){} // RVA: 0x7FFAF349AB90
        public void get_IsInitial(){} // RVA: 0x7FFAF2E2B240
        public void get_Timestamp(){} // RVA: 0x7FFAF615BF00
        public void get_SequenceNumber(){} // RVA: 0x7FFAF3B95CF0
        public void get_Duration(){} // RVA: 0x7FFAF8E72880
        public void get_EndStatus(){} // RVA: 0x7FFAF8E72900
        public void .ctor(){} // RVA: 0x7FFAF8E72D60 | overloaded x4
        public void WriteTo(){} // RVA: 0x7FFAF8E72DA0
        public void FromJson(){} // RVA: 0x7FFAF8E73460
    }

    public class SpanContext
    {
        // ── Methods ──
        public void get_SpanId(){} // RVA: 0x7FFAF2DA8380
        public void get_ParentSpanId(){} // RVA: 0x7FFAF3444EE0
        public void get_TraceId(){} // RVA: 0x7FFAF3BCF520
        public void get_Operation(){} // RVA: 0x7FFAF2F476A0
        public void set_Operation(){} // RVA: 0x7FFAF2F4B830
        public void get_Description(){} // RVA: 0x7FFAF2E0A740
        public void get_Status(){} // RVA: 0x7FFAF2E08730
        public void get_IsSampled(){} // RVA: 0x7FFAF6C93C10
        public void get_Instrumenter(){} // RVA: 0x7FFAF370BE80
        public void set_Instrumenter(){} // RVA: 0x7FFAF370BE70
        public void get_Origin(){} // RVA: 0x7FFAF2E55500
        public void set_Origin(){} // RVA: 0x7FFAF8E745E0
        public void .ctor(){} // RVA: 0x7FFAF8E746E0
    }

    public class SpanDataExtensions
    {
        // ── Methods ──
        public void SetMeasurement(){} // RVA: 0x7FFAF8D5B6F0 | overloaded x4
    }

    public class SpanExtensions
    {
        // ── Methods ──
        public void StartChild(){} // RVA: 0x7FFAF8D5AA30 | overloaded x2
        public void GetTransaction(){} // RVA: 0x7FFAF8D5AC80
        public void GetDbParentSpan(){} // RVA: 0x7FFAF8D5AD80
    }

    public class SpanId
    {
        // ── Methods ──
        public void GetValue(){} // RVA: 0x7FFAF4584690
        public void .ctor(){} // RVA: 0x7FFAF45C2320 | overloaded x2
        public void Equals(){} // RVA: 0x7FFAF8E749B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF8E74A90
        public void ToString(){} // RVA: 0x7FFAF8E74C20
        public void Create(){} // RVA: 0x7FFAF8E74D10
        public void WriteTo(){} // RVA: 0x7FFAF8E74E00
        public void Parse(){} // RVA: 0x7FFAF8E75190
        public void FromJson(){} // RVA: 0x7FFAF8E751C0
        public void op_Equality(){} // RVA: 0x7FFAF8E752C0
        public void op_Inequality(){} // RVA: 0x7FFAF8E75350
        public void op_Implicit(){} // RVA: 0x7FFAF8E753C0
        public void .cctor(){} // RVA: 0x7FFAF8E75410
    }

    public class SpanStatusConverter
    {
        // ── Methods ──
        public void FromException(){} // RVA: 0x7FFAF8E755A0
        public void FromHttpStatusCode(){} // RVA: 0x7FFAF8E75820 | overloaded x2
        public void FromGrpcStatusCode(){} // RVA: 0x7FFAF8E758E0
    }

    public class SpanTracer
    {
        // ── Methods ──
        public void Sentry.IBaseTracer.get_IsOtelInstrumenter(){} // RVA: 0x7FFAF8E759A0
        public void get_Transaction(){} // RVA: 0x7FFAF2F476A0
        public void get_MetricsSummary(){} // RVA: 0x7FFAF8E759B0
        public void get_HasMetrics(){} // RVA: 0x7FFAF8E75A00
        public void get_SpanId(){} // RVA: 0x7FFAF2E08730
        public void set_SpanId(){} // RVA: 0x7FFAF424D760
        public void get_ParentSpanId(){} // RVA: 0x7FFAF6C90130
        public void set_ParentSpanId(){} // RVA: 0x7FFAF85EA8D0
        public void get_TraceId(){} // RVA: 0x7FFAF615BF00
        public void get_StartTimestamp(){} // RVA: 0x7FFAF8AC6290
        public void set_StartTimestamp(){} // RVA: 0x7FFAF8AC62A0
        public void get_EndTimestamp(){} // RVA: 0x7FFAF3923150
        public void set_EndTimestamp(){} // RVA: 0x7FFAF39234C0
        public void get_IsFinished(){} // RVA: 0x7FFAF8E75A50
        public void get_InternalMeasurements(){} // RVA: 0x7FFAF34CC8C0
        public void set_InternalMeasurements(){} // RVA: 0x7FFAF345A650
        public void get_Measurements(){} // RVA: 0x7FFAF8E75A90
        public void SetMeasurement(){} // RVA: 0x7FFAF8E75B60
        public void get_Operation(){} // RVA: 0x7FFAF34B85E0
        public void set_Operation(){} // RVA: 0x7FFAF345A5F0
        public void get_Description(){} // RVA: 0x7FFAF34CC130
        public void set_Description(){} // RVA: 0x7FFAF3595030
        public void get_Status(){} // RVA: 0x7FFAF2DF8040
        public void set_Status(){} // RVA: 0x7FFAF461CD00
        public void get_IsSentryRequest(){} // RVA: 0x7FFAF41EF990
        public void set_IsSentryRequest(){} // RVA: 0x7FFAF41EEC00
        public void get_IsSampled(){} // RVA: 0x7FFAF8E75C90
        public void set_IsSampled(){} // RVA: 0x7FFAF8E75CA0
        public void get_InternalTags(){} // RVA: 0x7FFAF2DF8120
        public void set_InternalTags(){} // RVA: 0x7FFAF2DF8130
        public void get_Tags(){} // RVA: 0x7FFAF8E75CB0
        public void SetTag(){} // RVA: 0x7FFAF8E75D80
        public void UnsetTag(){} // RVA: 0x7FFAF8E75EA0
        public void get_Extra(){} // RVA: 0x7FFAF2EE5460
        public void SetExtra(){} // RVA: 0x7FFAF8E76010
        public void get_IsFiltered(){} // RVA: 0x7FFAF2EAA100
        public void set_IsFiltered(){} // RVA: 0x7FFAF2EAA110
        public void .ctor(){} // RVA: 0x7FFAF8E763A0 | overloaded x2
        public void StartChild(){} // RVA: 0x7FFAF8E766B0
        public void Unfinish(){} // RVA: 0x7FFAF8E76700
        public void Finish(){} // RVA: 0x7FFAF8E76D60 | overloaded x4
        public void GetTraceHeader(){} // RVA: 0x7FFAF8E76DA0
        public void get_Origin(){} // RVA: 0x7FFAF3546D30
        public void set_Origin(){} // RVA: 0x7FFAF8E76E10
    }

    public class StreamAttachmentContent : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetStream(){} // RVA: 0x7FFAF2DA8380
    }

    public class SubstringOrRegexPattern
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFAF8E77050 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAF8E770E0
        public void Equals(){} // RVA: 0x7FFAF8E77150
        public void GetHashCode(){} // RVA: 0x7FFAF496C800
        public void get_Regex(){} // RVA: 0x7FFAF2DA8380
        public void IsMatch(){} // RVA: 0x7FFAF8E77250
        public void TryParseRegex(){} // RVA: 0x7FFAF8E773F0
    }

    public class SubstringOrRegexPatternExtensions
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x7FFAF8E774A0
        public void WithConfigBinding(){} // RVA: 0x7FFAF2ABCE50
    }

    public class SubstringOrRegexPatternTypeConverter
    {
        // ── Methods ──
        public void CanConvertFrom(){} // RVA: 0x7FFAF8E775C0
        public void ConvertFrom(){} // RVA: 0x7FFAF8E77690
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}