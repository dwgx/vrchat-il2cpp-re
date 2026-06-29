// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 117

namespace ThirdParty.Sentry.Sentry
{
    public class BaggageHeader : Object
    {
        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7AE086AE0
        public void set_Logger(){} // RVA: 0x7AE086B40
        public void get_Members(){} // RVA: 0x7A80F2570
        public void .ctor(){} // RVA: 0x7AE086BF0
        public void GetSentryMembers(){} // RVA: 0x7AE086D10
        public void ToString(){} // RVA: 0x7AE0873F0
        public void TryParse(){} // RVA: 0x7AE087580
        public void Create(){} // RVA: 0x7AE087A30
        public void Merge(){} // RVA: 0x7AE087D30
        public void IsValidKey(){} // RVA: 0x7AE088040
        public void .cctor(){} // RVA: 0x7AE0881C0
    }

    public class BindableSentryOptions : Object
    {
        // ── Methods ──
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7A99CD750
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7A99CDAA0
        public void get_EnableScopeSync(){} // RVA: 0x7AE0888F0
        public void set_EnableScopeSync(){} // RVA: 0x7AE088900
        public void get_TagFilters(){} // RVA: 0x7A80DA7B0
        public void set_TagFilters(){} // RVA: 0x7A813E420
        public void get_SendDefaultPii(){} // RVA: 0x7AC2A24B0
        public void set_SendDefaultPii(){} // RVA: 0x7AD8AE4B0
        public void get_IsEnvironmentUser(){} // RVA: 0x7AD8AE4C0
        public void set_IsEnvironmentUser(){} // RVA: 0x7AD8AE4D0
        public void get_ServerName(){} // RVA: 0x7A8105330
        public void set_ServerName(){} // RVA: 0x7A80D8E80
        public void get_AttachStacktrace(){} // RVA: 0x7AB9DFA00
        public void set_AttachStacktrace(){} // RVA: 0x7AD8AF090
        public void get_MaxBreadcrumbs(){} // RVA: 0x7AE088910
        public void set_MaxBreadcrumbs(){} // RVA: 0x7A8884B40
        public void get_SampleRate(){} // RVA: 0x7AE088920
        public void set_SampleRate(){} // RVA: 0x7AE088930
        public void get_Release(){} // RVA: 0x7A8152D80
        public void set_Release(){} // RVA: 0x7A8152D90
        public void get_Distribution(){} // RVA: 0x7A8178B90
        public void set_Distribution(){} // RVA: 0x7A8230620
        public void get_Environment(){} // RVA: 0x7A81A0050
        public void set_Environment(){} // RVA: 0x7A81A0060
        public void get_Dsn(){} // RVA: 0x7A8175DF0
        public void set_Dsn(){} // RVA: 0x7A8175E00
        public void get_MaxQueueItems(){} // RVA: 0x7A8153390
        public void set_MaxQueueItems(){} // RVA: 0x7A9D11620
        public void get_MaxCacheItems(){} // RVA: 0x7A81A00E0
        public void set_MaxCacheItems(){} // RVA: 0x7A9D11610
        public void get_ShutdownTimeout(){} // RVA: 0x7AE088940
        public void set_ShutdownTimeout(){} // RVA: 0x7AE088950
        public void get_FlushTimeout(){} // RVA: 0x7AD53B5F0
        public void set_FlushTimeout(){} // RVA: 0x7AD53B600
        public void get_DecompressionMethods(){} // RVA: 0x7A87D9C10
        public void set_DecompressionMethods(){} // RVA: 0x7AD543B50
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7A87C5850
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7ADDE2D30
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7ADDDCE70
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7ADDDCE80
        public void get_SendClientReports(){} // RVA: 0x7AE088960
        public void set_SendClientReports(){} // RVA: 0x7AE088970
        public void get_Debug(){} // RVA: 0x7AE088980
        public void set_Debug(){} // RVA: 0x7AE088990
        public void get_DiagnosticLevel(){} // RVA: 0x7AE0889A0
        public void set_DiagnosticLevel(){} // RVA: 0x7AE0889B0
        public void get_ReportAssembliesMode(){} // RVA: 0x7ADDDCEB0
        public void set_ReportAssembliesMode(){} // RVA: 0x7ADDDCEC0
        public void get_DeduplicateMode(){} // RVA: 0x7AE0889C0
        public void set_DeduplicateMode(){} // RVA: 0x7AE0889D0
        public void get_CacheDirectoryPath(){} // RVA: 0x7A82305B0
        public void set_CacheDirectoryPath(){} // RVA: 0x7A82305C0
        public void get_CaptureFailedRequests(){} // RVA: 0x7AE0889E0
        public void set_CaptureFailedRequests(){} // RVA: 0x7AE0889F0
        public void get_FailedRequestTargets(){} // RVA: 0x7A8854870
        public void set_FailedRequestTargets(){} // RVA: 0x7A8158EF0
        public void get_DisableFileWrite(){} // RVA: 0x7AE005390
        public void set_DisableFileWrite(){} // RVA: 0x7AE0053A0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7AE088A00
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7AE088A10
        public void get_DefaultTags(){} // RVA: 0x7A8592710
        public void set_DefaultTags(){} // RVA: 0x7A84442D0
        public void get_EnableTracing(){} // RVA: 0x7AE088A20
        public void set_EnableTracing(){} // RVA: 0x7AE088A30
        public void get_TracesSampleRate(){} // RVA: 0x7AE088A40
        public void set_TracesSampleRate(){} // RVA: 0x7AE088A50
        public void get_TracePropagationTargets(){} // RVA: 0x7A864CFF0
        public void set_TracePropagationTargets(){} // RVA: 0x7A864C880
        public void get_ProfilesSampleRate(){} // RVA: 0x7AE088A60
        public void set_ProfilesSampleRate(){} // RVA: 0x7AE088A70
        public void get_StackTraceMode(){} // RVA: 0x7A884C460
        public void set_StackTraceMode(){} // RVA: 0x7AE088A80
        public void get_MaxAttachmentSize(){} // RVA: 0x7AE088A90
        public void set_MaxAttachmentSize(){} // RVA: 0x7AE088AA0
        public void get_DetectStartupTime(){} // RVA: 0x7A8142C30
        public void set_DetectStartupTime(){} // RVA: 0x7AE088AB0
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7AE088AC0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7AE088AD0
        public void get_AutoSessionTracking(){} // RVA: 0x7AE088AE0
        public void set_AutoSessionTracking(){} // RVA: 0x7AE088AF0
        public void get_UseAsyncFileIO(){} // RVA: 0x7AE088B00
        public void set_UseAsyncFileIO(){} // RVA: 0x7AE088B10
        public void get_JsonPreserveReferences(){} // RVA: 0x7AE088B20
        public void set_JsonPreserveReferences(){} // RVA: 0x7AE088B30
        public void get_EnableSpotlight(){} // RVA: 0x7AE088B40
        public void set_EnableSpotlight(){} // RVA: 0x7AE088B50
        public void get_SpotlightUrl(){} // RVA: 0x7A8B57910
        public void set_SpotlightUrl(){} // RVA: 0x7A8B578B0
        public void ApplyTo(){} // RVA: 0x7AE088B60
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class Breadcrumb : Object
    {
        // ── Methods ──
        public void Redact(){} // RVA: 0x7AE089FA0
        public void get_Timestamp(){} // RVA: 0x7A8EDF360
        public void get_Message(){} // RVA: 0x7AE089FB0
        public void set_Message(){} // RVA: 0x7A813E420
        public void get_Type(){} // RVA: 0x7A8292C30
        public void get_Data(){} // RVA: 0x7AE08A040
        public void set_Data(){} // RVA: 0x7A80D8E20
        public void get_Category(){} // RVA: 0x7A8154D80
        public void get_Level(){} // RVA: 0x7A8178B70
        public void .ctor(){} // RVA: 0x7AE08A2A0
        public void WriteTo(){} // RVA: 0x7AE08A510
        public void FromJson(){} // RVA: 0x7AE08A8D0
    }

    public class BuiltInSystemDiagnosticsMeters : Object
    {
        // ── Methods ──
        public void get_All(){} // RVA: 0x7AE08B050
        public void .cctor(){} // RVA: 0x7AE08B0D0
    }

    public class ByteAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetStream(){} // RVA: 0x7AE08BD90
    }

}