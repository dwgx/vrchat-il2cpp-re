// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 118

namespace ThirdParty.Sentry.Sentry
{
    public class BaggageHeader
    {
        public string HttpHeaderName;
        public string SentryKeyPrefix;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x629AD10
        public void set_Logger(){} // RVA: 0x629AD70
        public void get_Members(){} // RVA: 0x2F8380
        public void .ctor(){} // RVA: 0x629AE20
        public void GetSentryMembers(){} // RVA: 0x629AF40
        public void ToString(){} // RVA: 0x629B620
        public void TryParse(){} // RVA: 0x629B7B0
        public void Create(){} // RVA: 0x629BB90
        public void Merge(){} // RVA: 0x629BE80
        public void IsValidKey(){} // RVA: 0x629C170
        public void .cctor(){} // RVA: 0x629C2F0
    }

    public class BindableSentryOptions
    {
        public System.Nullable`1<bool> <IsGlobalModeEnabled>k__BackingField; // 0x10
        public System.Nullable`1<bool> <EnableScopeSync>k__BackingField; // 0x12
        public System.Collections.Generic.List`1<string> <TagFilters>k__BackingField; // 0x18
        public System.Nullable`1<bool> <SendDefaultPii>k__BackingField; // 0x20
        public System.Nullable`1<bool> <IsEnvironmentUser>k__BackingField; // 0x22
        public string <ServerName>k__BackingField; // 0x28
        public System.Nullable`1<bool> <AttachStacktrace>k__BackingField; // 0x30
        public System.Nullable`1<int> <MaxBreadcrumbs>k__BackingField; // 0x34
        public System.Nullable`1<float> <SampleRate>k__BackingField; // 0x3C
        public string <Release>k__BackingField; // 0x48
        public string <Distribution>k__BackingField; // 0x50
        public string <Environment>k__BackingField; // 0x58
        public string <Dsn>k__BackingField; // 0x60
        public System.Nullable`1<int> <MaxQueueItems>k__BackingField; // 0x68
        public System.Nullable`1<int> <MaxCacheItems>k__BackingField; // 0x70
        public System.Nullable`1<System.TimeSpan> <ShutdownTimeout>k__BackingField; // 0x78
        public System.Nullable`1<System.TimeSpan> <FlushTimeout>k__BackingField; // 0x88
        public System.Nullable`1<0x658579E8> <DecompressionMethods>k__BackingField; // 0x98
        public System.Nullable`1<0x65854708> <RequestBodyCompressionLevel>k__BackingField; // 0xA0
        public System.Nullable`1<bool> <RequestBodyCompressionBuffered>k__BackingField; // 0xA8
        public System.Nullable`1<bool> <SendClientReports>k__BackingField; // 0xAA
        public System.Nullable`1<bool> <Debug>k__BackingField; // 0xAC
        public System.Nullable`1<0x658B4E20> <DiagnosticLevel>k__BackingField; // 0xAE
        public System.Nullable`1<0x658B4320> <ReportAssembliesMode>k__BackingField; // 0xB4
        public System.Nullable`1<0x658B2A08> <DeduplicateMode>k__BackingField; // 0xBC
        public string <CacheDirectoryPath>k__BackingField; // 0xC8
        public System.Nullable`1<bool> <CaptureFailedRequests>k__BackingField; // 0xD0
        public System.Collections.Generic.List`1<string> <FailedRequestTargets>k__BackingField; // 0xD8
        public System.Nullable`1<bool> <DisableFileWrite>k__BackingField; // 0xE0
        public System.Nullable`1<System.TimeSpan> <InitCacheFlushTimeout>k__BackingField; // 0xE8
        public System.Collections.Generic.Dictionary`2<string,string> <DefaultTags>k__BackingField; // 0xF8
        public System.Nullable`1<bool> <EnableTracing>k__BackingField; // 0x100
        public System.Nullable`1<double> <TracesSampleRate>k__BackingField; // 0x108
        public System.Collections.Generic.List`1<string> <TracePropagationTargets>k__BackingField; // 0x118
        public System.Nullable`1<double> <ProfilesSampleRate>k__BackingField; // 0x120
        public System.Nullable`1<0x658B6210> <StackTraceMode>k__BackingField; // 0x130
        public System.Nullable`1<long> <MaxAttachmentSize>k__BackingField; // 0x138
        public System.Nullable`1<0x658B6268> <DetectStartupTime>k__BackingField; // 0x148
        public System.Nullable`1<System.TimeSpan> <AutoSessionTrackingInterval>k__BackingField; // 0x150
        public System.Nullable`1<bool> <AutoSessionTracking>k__BackingField; // 0x160
        public System.Nullable`1<bool> <UseAsyncFileIO>k__BackingField; // 0x162
        public System.Nullable`1<bool> <JsonPreserveReferences>k__BackingField; // 0x164
        public System.Nullable`1<bool> <EnableSpotlight>k__BackingField; // 0x166
        public string <SpotlightUrl>k__BackingField; // 0x168

        // ── Methods ──
        public void get_IsGlobalModeEnabled(){} // RVA: 0x1C0F720
        public void set_IsGlobalModeEnabled(){} // RVA: 0x1C0FA70
        public void get_EnableScopeSync(){} // RVA: 0x629CA20
        public void set_EnableScopeSync(){} // RVA: 0x629CA30
        public void get_TagFilters(){} // RVA: 0x2E07C0
        public void set_TagFilters(){} // RVA: 0x343E80
        public void get_SendDefaultPii(){} // RVA: 0x44B4370
        public void set_SendDefaultPii(){} // RVA: 0x5AC0F20
        public void get_IsEnvironmentUser(){} // RVA: 0x5AC0F30
        public void set_IsEnvironmentUser(){} // RVA: 0x5AC0F40
        public void get_ServerName(){} // RVA: 0x30B130
        public void set_ServerName(){} // RVA: 0x2DEE90
        public void get_AttachStacktrace(){} // RVA: 0x3BE7880
        public void set_AttachStacktrace(){} // RVA: 0x5AC1AF0
        public void get_MaxBreadcrumbs(){} // RVA: 0x629CA40
        public void set_MaxBreadcrumbs(){} // RVA: 0xAE83D0
        public void get_SampleRate(){} // RVA: 0x629CA50
        public void set_SampleRate(){} // RVA: 0x629CA60
        public void get_Release(){} // RVA: 0x358730
        public void set_Release(){} // RVA: 0x358740
        public void get_Distribution(){} // RVA: 0x37E0E0
        public void set_Distribution(){} // RVA: 0x4354D0
        public void get_Environment(){} // RVA: 0x3A5500
        public void set_Environment(){} // RVA: 0x3A5510
        public void get_Dsn(){} // RVA: 0x37B370
        public void set_Dsn(){} // RVA: 0x37B380
        public void get_MaxQueueItems(){} // RVA: 0x358D50
        public void set_MaxQueueItems(){} // RVA: 0x1F0AB90
        public void get_MaxCacheItems(){} // RVA: 0x3A5590
        public void set_MaxCacheItems(){} // RVA: 0x1F0AB80
        public void get_ShutdownTimeout(){} // RVA: 0x629CA70
        public void set_ShutdownTimeout(){} // RVA: 0x629CA80
        public void get_FlushTimeout(){} // RVA: 0x576C5E0
        public void set_FlushTimeout(){} // RVA: 0x576C5F0
        public void get_DecompressionMethods(){} // RVA: 0xA1C8C0
        public void set_DecompressionMethods(){} // RVA: 0x5774BB0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0xA085E0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x5FF62E0
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x5FF0480
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x5FF0490
        public void get_SendClientReports(){} // RVA: 0x629CA90
        public void set_SendClientReports(){} // RVA: 0x629CAA0
        public void get_Debug(){} // RVA: 0x629CAB0
        public void set_Debug(){} // RVA: 0x629CAC0
        public void get_DiagnosticLevel(){} // RVA: 0x629CAD0
        public void set_DiagnosticLevel(){} // RVA: 0x629CAE0
        public void get_ReportAssembliesMode(){} // RVA: 0x5FF04C0
        public void set_ReportAssembliesMode(){} // RVA: 0x5FF04D0
        public void get_DeduplicateMode(){} // RVA: 0x629CAF0
        public void set_DeduplicateMode(){} // RVA: 0x629CB00
        public void get_CacheDirectoryPath(){} // RVA: 0x435460
        public void set_CacheDirectoryPath(){} // RVA: 0x435470
        public void get_CaptureFailedRequests(){} // RVA: 0x629CB10
        public void set_CaptureFailedRequests(){} // RVA: 0x629CB20
        public void get_FailedRequestTargets(){} // RVA: 0xA96D30
        public void set_FailedRequestTargets(){} // RVA: 0x35E8A0
        public void get_DisableFileWrite(){} // RVA: 0x6218C60
        public void set_DisableFileWrite(){} // RVA: 0x6218C70
        public void get_InitCacheFlushTimeout(){} // RVA: 0x629CB30
        public void set_InitCacheFlushTimeout(){} // RVA: 0x629CB40
        public void get_DefaultTags(){} // RVA: 0x7F7DB0
        public void set_DefaultTags(){} // RVA: 0x63D280
        public void get_EnableTracing(){} // RVA: 0x629CB50
        public void set_EnableTracing(){} // RVA: 0x629CB60
        public void get_TracesSampleRate(){} // RVA: 0x629CB70
        public void set_TracesSampleRate(){} // RVA: 0x629CB80
        public void get_TracePropagationTargets(){} // RVA: 0x507D10
        public void set_TracePropagationTargets(){} // RVA: 0x50A8C0
        public void get_ProfilesSampleRate(){} // RVA: 0x629CB90
        public void set_ProfilesSampleRate(){} // RVA: 0x629CBA0
        public void get_StackTraceMode(){} // RVA: 0xA8E870
        public void set_StackTraceMode(){} // RVA: 0x629CBB0
        public void get_MaxAttachmentSize(){} // RVA: 0x629CBC0
        public void set_MaxAttachmentSize(){} // RVA: 0x629CBD0
        public void get_DetectStartupTime(){} // RVA: 0x348660
        public void set_DetectStartupTime(){} // RVA: 0x629CBE0
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x629CBF0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x629CC00
        public void get_AutoSessionTracking(){} // RVA: 0x629CC10
        public void set_AutoSessionTracking(){} // RVA: 0x629CC20
        public void get_UseAsyncFileIO(){} // RVA: 0x629CC30
        public void set_UseAsyncFileIO(){} // RVA: 0x629CC40
        public void get_JsonPreserveReferences(){} // RVA: 0x629CC50
        public void set_JsonPreserveReferences(){} // RVA: 0x629CC60
        public void get_EnableSpotlight(){} // RVA: 0x629CC70
        public void set_EnableSpotlight(){} // RVA: 0x629CC80
        public void get_SpotlightUrl(){} // RVA: 0xD93DD0
        public void set_SpotlightUrl(){} // RVA: 0xD93D70
        public void ApplyTo(){} // RVA: 0x629CC90
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class Breadcrumb
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> _data; // 0x10
        public string _message; // 0x18
        public bool _sendDefaultPii; // 0x20
        public System.DateTimeOffset <Timestamp>k__BackingField; // 0x28
        public string <Type>k__BackingField; // 0x38
        public string <Category>k__BackingField; // 0x40

        // ── Methods ──
        public void Redact(){} // RVA: 0x629E0D0
        public void get_Timestamp(){} // RVA: 0x111F520
        public void get_Message(){} // RVA: 0x629E0E0
        public void set_Message(){} // RVA: 0x343E80
        public void get_Type(){} // RVA: 0x4976A0
        public void get_Data(){} // RVA: 0x629E170
        public void set_Data(){} // RVA: 0x2DEE30
        public void get_Category(){} // RVA: 0x35A740
        public void get_Level(){} // RVA: 0x37E0C0
        public void .ctor(){} // RVA: 0x629E3D0 | overloaded x2
        public void WriteTo(){} // RVA: 0x629E640
        public void FromJson(){} // RVA: 0x629E9D0
    }

    public class BuiltInSystemDiagnosticsMeters
    {
        public string MicrosoftAspNetCoreHostingPattern;

        // ── Methods ──
        public void get_All(){} // RVA: 0x629F150
        public void .cctor(){} // RVA: 0x629F1D0
    }

    public class ByteAttachmentContent : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetStream(){} // RVA: 0x629FE90
    }

}