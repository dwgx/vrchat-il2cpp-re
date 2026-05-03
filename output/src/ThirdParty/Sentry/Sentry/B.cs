// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 118

namespace ThirdParty.Sentry.Sentry
{
    public class BaggageHeader : Object
    {
        public string HttpHeaderName;
        public string SentryKeyPrefix;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFE86DDB740
        public void set_Logger(){} // RVA: 0x7FFE86DDB7A0
        public void get_Members(){} // RVA: 0x7FFE81116380
        public void .ctor(){} // RVA: 0x7FFE86DDB850
        public void GetSentryMembers(){} // RVA: 0x7FFE86DDB970
        public void ToString(){} // RVA: 0x7FFE86DDC050
        public void TryParse(){} // RVA: 0x7FFE86DDC1E0
        public void Create(){} // RVA: 0x7FFE86DDC5C0
        public void Merge(){} // RVA: 0x7FFE86DDC8B0
        public void IsValidKey(){} // RVA: 0x7FFE86DDCBA0
        public void .cctor(){} // RVA: 0x7FFE86DDCD20
    }

    public class BindableSentryOptions : Object
    {
        public System.Nullable`1<bool> _isGlobalModeEnabled; // 0x10
        public System.Nullable`1<bool> _enableScopeSync; // 0x12
        public System.Collections.Generic.List`1<string> _tagFilters; // 0x18
        public System.Nullable`1<bool> _sendDefaultPii; // 0x20
        public System.Nullable`1<bool> _isEnvironmentUser; // 0x22
        public string _serverName; // 0x28
        public System.Nullable`1<bool> _attachStacktrace; // 0x30
        public System.Nullable`1<int> _maxBreadcrumbs; // 0x34
        public System.Nullable`1<float> _sampleRate; // 0x3C
        public string _release; // 0x48
        public string _distribution; // 0x50
        public string _environment; // 0x58
        public string _dsn; // 0x60
        public System.Nullable`1<int> _maxQueueItems; // 0x68
        public System.Nullable`1<int> _maxCacheItems; // 0x70
        public System.Nullable`1<System.TimeSpan> _shutdownTimeout; // 0x78
        public System.Nullable`1<System.TimeSpan> _flushTimeout; // 0x88
        public System.Nullable`1<0x6653598C> _decompressionMethods; // 0x98
        public System.Nullable`1<0x665326AC> _requestBodyCompressionLevel; // 0xA0
        public System.Nullable`1<bool> _requestBodyCompressionBuffered; // 0xA8
        public System.Nullable`1<bool> _sendClientReports; // 0xAA
        public System.Nullable`1<bool> _debug; // 0xAC
        public System.Nullable`1<0x6659252C> _diagnosticLevel; // 0xAE
        public System.Nullable`1<0x66591A2C> _reportAssembliesMode; // 0xB4
        public System.Nullable`1<:> _deduplicateMode; // 0xBC
        public string _cacheDirectoryPath; // 0xC8
        public System.Nullable`1<bool> _captureFailedRequests; // 0xD0
        public System.Collections.Generic.List`1<string> _failedRequestTargets; // 0xD8
        public System.Nullable`1<bool> _disableFileWrite; // 0xE0
        public System.Nullable`1<System.TimeSpan> _initCacheFlushTimeout; // 0xE8
        public System.Collections.Generic.Dictionary`2<string,string> _defaultTags; // 0xF8
        public System.Nullable`1<bool> _enableTracing; // 0x100
        public System.Nullable`1<double> _tracesSampleRate; // 0x108
        public System.Collections.Generic.List`1<string> _tracePropagationTargets; // 0x118
        public System.Nullable`1<double> _profilesSampleRate; // 0x120
        public System.Nullable`1<0x6659391C> _stackTraceMode; // 0x130
        public System.Nullable`1<long> _maxAttachmentSize; // 0x138
        public System.Nullable`1<0x66593974> _detectStartupTime; // 0x148
        public System.Nullable`1<System.TimeSpan> _autoSessionTrackingInterval; // 0x150
        public System.Nullable`1<bool> _autoSessionTracking; // 0x160
        public System.Nullable`1<bool> _useAsyncFileIO; // 0x162
        public System.Nullable`1<bool> _jsonPreserveReferences; // 0x164
        public System.Nullable`1<bool> _enableSpotlight; // 0x166
        public string _spotlightUrl; // 0x168

        // ── Methods ──
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFE8299FB40
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFE8299FB10
        public void get_EnableScopeSync(){} // RVA: 0x7FFE86DDD450
        public void set_EnableScopeSync(){} // RVA: 0x7FFE86DDD460
        public void get_TagFilters(){} // RVA: 0x7FFE810FE7C0
        public void set_TagFilters(){} // RVA: 0x7FFE81161E80
        public void get_SendDefaultPii(){} // RVA: 0x7FFE850EF1D0
        public void set_SendDefaultPii(){} // RVA: 0x7FFE86601D50
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFE86601D60
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFE86601D70
        public void get_ServerName(){} // RVA: 0x7FFE81129130
        public void set_ServerName(){} // RVA: 0x7FFE810FCE90
        public void get_AttachStacktrace(){} // RVA: 0x7FFE84870400
        public void set_AttachStacktrace(){} // RVA: 0x7FFE86602920
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFE86DDD470
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFE81859C60
        public void get_SampleRate(){} // RVA: 0x7FFE86DDD480
        public void set_SampleRate(){} // RVA: 0x7FFE86DDD490
        public void get_Release(){} // RVA: 0x7FFE81176730
        public void set_Release(){} // RVA: 0x7FFE81176740
        public void get_Distribution(){} // RVA: 0x7FFE8119C0E0
        public void set_Distribution(){} // RVA: 0x7FFE812534D0
        public void get_Environment(){} // RVA: 0x7FFE811C3500
        public void set_Environment(){} // RVA: 0x7FFE811C3510
        public void get_Dsn(){} // RVA: 0x7FFE81199370
        public void set_Dsn(){} // RVA: 0x7FFE81199380
        public void get_MaxQueueItems(){} // RVA: 0x7FFE81176D50
        public void set_MaxQueueItems(){} // RVA: 0x7FFE82C95C80
        public void get_MaxCacheItems(){} // RVA: 0x7FFE811C3590
        public void set_MaxCacheItems(){} // RVA: 0x7FFE82C95C70
        public void get_ShutdownTimeout(){} // RVA: 0x7FFE86DDD4A0
        public void set_ShutdownTimeout(){} // RVA: 0x7FFE86DDD4B0
        public void get_FlushTimeout(){} // RVA: 0x7FFE8621CDA0
        public void set_FlushTimeout(){} // RVA: 0x7FFE8621CDB0
        public void get_DecompressionMethods(){} // RVA: 0x7FFE817AE360
        public void set_DecompressionMethods(){} // RVA: 0x7FFE86225270
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFE8179C860
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFE86B370C0
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFE86B31260
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFE86B31270
        public void get_SendClientReports(){} // RVA: 0x7FFE86DDD4C0
        public void set_SendClientReports(){} // RVA: 0x7FFE86DDD4D0
        public void get_Debug(){} // RVA: 0x7FFE86DDD4E0
        public void set_Debug(){} // RVA: 0x7FFE86DDD4F0
        public void get_DiagnosticLevel(){} // RVA: 0x7FFE86DDD500
        public void set_DiagnosticLevel(){} // RVA: 0x7FFE86DDD510
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFE86B312A0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFE86B312B0
        public void get_DeduplicateMode(){} // RVA: 0x7FFE86DDD520
        public void set_DeduplicateMode(){} // RVA: 0x7FFE86DDD530
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFE81253460
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFE81253470
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFE86DDD540
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFE86DDD550
        public void get_FailedRequestTargets(){} // RVA: 0x7FFE8181EA80
        public void set_FailedRequestTargets(){} // RVA: 0x7FFE8117C8A0
        public void get_DisableFileWrite(){} // RVA: 0x7FFE86D59AE0
        public void set_DisableFileWrite(){} // RVA: 0x7FFE86D59AF0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFE86DDD560
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFE86DDD570
        public void get_DefaultTags(){} // RVA: 0x7FFE8158D5D0
        public void set_DefaultTags(){} // RVA: 0x7FFE81B0E4B0
        public void get_EnableTracing(){} // RVA: 0x7FFE86DDD580
        public void set_EnableTracing(){} // RVA: 0x7FFE86DDD590
        public void get_TracesSampleRate(){} // RVA: 0x7FFE86DDD5A0
        public void set_TracesSampleRate(){} // RVA: 0x7FFE86DDD5B0
        public void get_TracePropagationTargets(){} // RVA: 0x7FFE81318010
        public void set_TracePropagationTargets(){} // RVA: 0x7FFE81317920
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFE86DDD5C0
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFE86DDD5D0
        public void get_StackTraceMode(){} // RVA: 0x7FFE81823850
        public void set_StackTraceMode(){} // RVA: 0x7FFE86DDD5E0
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFE86DDD5F0
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFE86DDD600
        public void get_DetectStartupTime(){} // RVA: 0x7FFE81166660
        public void set_DetectStartupTime(){} // RVA: 0x7FFE86DDD610
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFE86DDD620
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFE86DDD630
        public void get_AutoSessionTracking(){} // RVA: 0x7FFE86DDD640
        public void set_AutoSessionTracking(){} // RVA: 0x7FFE86DDD650
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFE86DDD660
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFE86DDD670
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFE86DDD680
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFE86DDD690
        public void get_EnableSpotlight(){} // RVA: 0x7FFE86DDD6A0
        public void set_EnableSpotlight(){} // RVA: 0x7FFE86DDD6B0
        public void get_SpotlightUrl(){} // RVA: 0x7FFE81B2CB70
        public void set_SpotlightUrl(){} // RVA: 0x7FFE81B23F80
        public void ApplyTo(){} // RVA: 0x7FFE86DDD6C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Breadcrumb : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> _data; // 0x10
        public string _message; // 0x18
        public bool _sendDefaultPii; // 0x20
        public System.DateTimeOffset _timestamp; // 0x28
        public string _type; // 0x38
        public string _category; // 0x40

        // ── Methods ──
        public void Redact(){} // RVA: 0x7FFE86DDEB00
        public void get_Timestamp(){} // RVA: 0x7FFE81E90600
        public void get_Message(){} // RVA: 0x7FFE86DDEB10
        public void set_Message(){} // RVA: 0x7FFE81161E80
        public void get_Type(){} // RVA: 0x7FFE8143BA80
        public void get_Data(){} // RVA: 0x7FFE86DDEBA0
        public void set_Data(){} // RVA: 0x7FFE810FCE30
        public void get_Category(){} // RVA: 0x7FFE81178740
        public void get_Level(){} // RVA: 0x7FFE8119C0C0
        public void .ctor(){} // RVA: 0x7FFE86DDEE00 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFE86DDF070
        public void FromJson(){} // RVA: 0x7FFE86DDF400
    }

    public class BuiltInSystemDiagnosticsMeters : Object
    {
        public string MicrosoftAspNetCoreHostingPattern;

        // ── Methods ──
        public void get_All(){} // RVA: 0x7FFE86DDFB80
        public void .cctor(){} // RVA: 0x7FFE86DDFC00
    }

    public class ByteAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetStream(){} // RVA: 0x7FFE86DE08C0
    }

}