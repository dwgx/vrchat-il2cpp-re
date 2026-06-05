// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 118

namespace ThirdParty.Sentry.Sentry
{
    public class BaggageHeader
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFAF8D4AD10
        public void set_Logger(){} // RVA: 0x7FFAF8D4AD70
        public void get_Members(){} // RVA: 0x7FFAF2DA8380
        public void .ctor(){} // RVA: 0x7FFAF8D4AE20
        public void GetSentryMembers(){} // RVA: 0x7FFAF8D4AF40
        public void ToString(){} // RVA: 0x7FFAF8D4B620
        public void TryParse(){} // RVA: 0x7FFAF8D4B7B0
        public void Create(){} // RVA: 0x7FFAF8D4BB90
        public void Merge(){} // RVA: 0x7FFAF8D4BE80
        public void IsValidKey(){} // RVA: 0x7FFAF8D4C170
        public void .cctor(){} // RVA: 0x7FFAF8D4C2F0
    }

    public class BindableSentryOptions
    {
        // ── Methods ──
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFAF46BF720
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFAF46BFA70
        public void get_EnableScopeSync(){} // RVA: 0x7FFAF8D4CA20
        public void set_EnableScopeSync(){} // RVA: 0x7FFAF8D4CA30
        public void get_TagFilters(){} // RVA: 0x7FFAF2D907C0
        public void set_TagFilters(){} // RVA: 0x7FFAF2DF3E80
        public void get_SendDefaultPii(){} // RVA: 0x7FFAF6F64370
        public void set_SendDefaultPii(){} // RVA: 0x7FFAF8570F20
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFAF8570F30
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFAF8570F40
        public void get_ServerName(){} // RVA: 0x7FFAF2DBB130
        public void set_ServerName(){} // RVA: 0x7FFAF2D8EE90
        public void get_AttachStacktrace(){} // RVA: 0x7FFAF6697880
        public void set_AttachStacktrace(){} // RVA: 0x7FFAF8571AF0
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAF8D4CA40
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFAF35983D0
        public void get_SampleRate(){} // RVA: 0x7FFAF8D4CA50
        public void set_SampleRate(){} // RVA: 0x7FFAF8D4CA60
        public void get_Release(){} // RVA: 0x7FFAF2E08730
        public void set_Release(){} // RVA: 0x7FFAF2E08740
        public void get_Distribution(){} // RVA: 0x7FFAF2E2E0E0
        public void set_Distribution(){} // RVA: 0x7FFAF2EE54D0
        public void get_Environment(){} // RVA: 0x7FFAF2E55500
        public void set_Environment(){} // RVA: 0x7FFAF2E55510
        public void get_Dsn(){} // RVA: 0x7FFAF2E2B370
        public void set_Dsn(){} // RVA: 0x7FFAF2E2B380
        public void get_MaxQueueItems(){} // RVA: 0x7FFAF2E08D50
        public void set_MaxQueueItems(){} // RVA: 0x7FFAF49BAB90
        public void get_MaxCacheItems(){} // RVA: 0x7FFAF2E55590
        public void set_MaxCacheItems(){} // RVA: 0x7FFAF49BAB80
        public void get_ShutdownTimeout(){} // RVA: 0x7FFAF8D4CA70
        public void set_ShutdownTimeout(){} // RVA: 0x7FFAF8D4CA80
        public void get_FlushTimeout(){} // RVA: 0x7FFAF821C5E0
        public void set_FlushTimeout(){} // RVA: 0x7FFAF821C5F0
        public void get_DecompressionMethods(){} // RVA: 0x7FFAF34CC8C0
        public void set_DecompressionMethods(){} // RVA: 0x7FFAF8224BB0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFAF34B85E0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFAF8AA62E0
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAF8AA0480
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAF8AA0490
        public void get_SendClientReports(){} // RVA: 0x7FFAF8D4CA90
        public void set_SendClientReports(){} // RVA: 0x7FFAF8D4CAA0
        public void get_Debug(){} // RVA: 0x7FFAF8D4CAB0
        public void set_Debug(){} // RVA: 0x7FFAF8D4CAC0
        public void get_DiagnosticLevel(){} // RVA: 0x7FFAF8D4CAD0
        public void set_DiagnosticLevel(){} // RVA: 0x7FFAF8D4CAE0
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAF8AA04C0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFAF8AA04D0
        public void get_DeduplicateMode(){} // RVA: 0x7FFAF8D4CAF0
        public void set_DeduplicateMode(){} // RVA: 0x7FFAF8D4CB00
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFAF2EE5460
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFAF2EE5470
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAF8D4CB10
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFAF8D4CB20
        public void get_FailedRequestTargets(){} // RVA: 0x7FFAF3546D30
        public void set_FailedRequestTargets(){} // RVA: 0x7FFAF2E0E8A0
        public void get_DisableFileWrite(){} // RVA: 0x7FFAF8CC8C60
        public void set_DisableFileWrite(){} // RVA: 0x7FFAF8CC8C70
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFAF8D4CB30
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFAF8D4CB40
        public void get_DefaultTags(){} // RVA: 0x7FFAF32A7DB0
        public void set_DefaultTags(){} // RVA: 0x7FFAF30ED280
        public void get_EnableTracing(){} // RVA: 0x7FFAF8D4CB50
        public void set_EnableTracing(){} // RVA: 0x7FFAF8D4CB60
        public void get_TracesSampleRate(){} // RVA: 0x7FFAF8D4CB70
        public void set_TracesSampleRate(){} // RVA: 0x7FFAF8D4CB80
        public void get_TracePropagationTargets(){} // RVA: 0x7FFAF2FB7D10
        public void set_TracePropagationTargets(){} // RVA: 0x7FFAF2FBA8C0
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFAF8D4CB90
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFAF8D4CBA0
        public void get_StackTraceMode(){} // RVA: 0x7FFAF353E870
        public void set_StackTraceMode(){} // RVA: 0x7FFAF8D4CBB0
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFAF8D4CBC0
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFAF8D4CBD0
        public void get_DetectStartupTime(){} // RVA: 0x7FFAF2DF8660
        public void set_DetectStartupTime(){} // RVA: 0x7FFAF8D4CBE0
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFAF8D4CBF0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFAF8D4CC00
        public void get_AutoSessionTracking(){} // RVA: 0x7FFAF8D4CC10
        public void set_AutoSessionTracking(){} // RVA: 0x7FFAF8D4CC20
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFAF8D4CC30
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFAF8D4CC40
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFAF8D4CC50
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFAF8D4CC60
        public void get_EnableSpotlight(){} // RVA: 0x7FFAF8D4CC70
        public void set_EnableSpotlight(){} // RVA: 0x7FFAF8D4CC80
        public void get_SpotlightUrl(){} // RVA: 0x7FFAF3843DD0
        public void set_SpotlightUrl(){} // RVA: 0x7FFAF3843D70
        public void ApplyTo(){} // RVA: 0x7FFAF8D4CC90
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class Breadcrumb
    {
        // ── Methods ──
        public void Redact(){} // RVA: 0x7FFAF8D4E0D0
        public void get_Timestamp(){} // RVA: 0x7FFAF3BCF520
        public void get_Message(){} // RVA: 0x7FFAF8D4E0E0
        public void set_Message(){} // RVA: 0x7FFAF2DF3E80
        public void get_Type(){} // RVA: 0x7FFAF2F476A0
        public void get_Data(){} // RVA: 0x7FFAF8D4E170
        public void set_Data(){} // RVA: 0x7FFAF2D8EE30
        public void get_Category(){} // RVA: 0x7FFAF2E0A740
        public void get_Level(){} // RVA: 0x7FFAF2E2E0C0
        public void .ctor(){} // RVA: 0x7FFAF8D4E3D0 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAF8D4E640
        public void FromJson(){} // RVA: 0x7FFAF8D4E9D0
    }

    public class BuiltInSystemDiagnosticsMeters
    {
        // ── Methods ──
        public void get_All(){} // RVA: 0x7FFAF8D4F150
        public void .cctor(){} // RVA: 0x7FFAF8D4F1D0
    }

    public class ByteAttachmentContent : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetStream(){} // RVA: 0x7FFAF8D4FE90
    }

}