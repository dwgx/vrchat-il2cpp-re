// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 117

namespace ThirdParty.Sentry.Sentry
{
    public class BaggageHeader : Object
    {
        public object HttpHeaderName;
        public object SentryKeyPrefix;
        public object _logger;
        public object _members;

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x6D07B90
        public void set_Logger(){} // RVA: 0x6D07BF0
        public void get_Members(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0x6D07CA0
        public void GetSentryMembers(){} // RVA: 0x6D07DC0
        public void ToString(){} // RVA: 0x6D084A0
        public void TryParse(){} // RVA: 0x6D08630
        public void Create(){} // RVA: 0x6D08AE0
        public void Merge(){} // RVA: 0x6D08DE0
        public void IsValidKey(){} // RVA: 0x6D090F0
        public void .cctor(){} // RVA: 0x6D09270
    }

    public class BindableSentryOptions : Object
    {
        public object _isGlobalModeEnabled;
        public object _enableScopeSync;
        public object _tagFilters;
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
        public object _maxQueueItems;
        public object _maxCacheItems;
        public object _shutdownTimeout;
        public object _flushTimeout;
        public object _decompressionMethods;
        public object _requestBodyCompressionLevel;
        public object _requestBodyCompressionBuffered;
        public object _sendClientReports;
        public object _debug;
        public object _diagnosticLevel;
        public object _reportAssembliesMode;
        public object _deduplicateMode;
        public object _cacheDirectoryPath;
        public object _captureFailedRequests;
        public object _failedRequestTargets;
        public object _disableFileWrite;
        public object _initCacheFlushTimeout;
        public object _defaultTags;
        public object _enableTracing;
        public object _tracesSampleRate;
        public object _tracePropagationTargets;
        public object _profilesSampleRate;
        public object _stackTraceMode;
        public object _maxAttachmentSize;
        public object _detectStartupTime;
        public object _autoSessionTrackingInterval;
        public object _autoSessionTracking;
        public object _useAsyncFileIO;
        public object _jsonPreserveReferences;
        public object _enableSpotlight;
        public object _spotlightUrl;

        // ── Methods ──
        public void get_IsGlobalModeEnabled(){} // RVA: 0x24EA1D0
        public void set_IsGlobalModeEnabled(){} // RVA: 0x24EAB10
        public void get_EnableScopeSync(){} // RVA: 0x6D099A0
        public void set_EnableScopeSync(){} // RVA: 0x6D099B0
        public void get_TagFilters(){} // RVA: 0xB465B0
        public void set_TagFilters(){} // RVA: 0xBA9BA0
        public void get_SendDefaultPii(){} // RVA: 0x4FEF950
        public void set_SendDefaultPii(){} // RVA: 0x653B850
        public void get_IsEnvironmentUser(){} // RVA: 0x653B860
        public void set_IsEnvironmentUser(){} // RVA: 0x653B870
        public void get_ServerName(){} // RVA: 0xB70160
        public void set_ServerName(){} // RVA: 0xB44DC0
        public void get_AttachStacktrace(){} // RVA: 0x4674E80
        public void set_AttachStacktrace(){} // RVA: 0x653C430
        public void get_MaxBreadcrumbs(){} // RVA: 0x6D099C0
        public void set_MaxBreadcrumbs(){} // RVA: 0x13B47B0
        public void get_SampleRate(){} // RVA: 0x25482E0
        public void set_SampleRate(){} // RVA: 0x6D099D0
        public void get_Release(){} // RVA: 0xBBF8F0
        public void set_Release(){} // RVA: 0xBBF900
        public void get_Distribution(){} // RVA: 0xBE58B0
        public void set_Distribution(){} // RVA: 0xCA4DF0
        public void get_Environment(){} // RVA: 0xC0FFC0
        public void set_Environment(){} // RVA: 0xC0FFD0
        public void get_Dsn(){} // RVA: 0xBE2C60
        public void set_Dsn(){} // RVA: 0xBE2C70
        public void get_MaxQueueItems(){} // RVA: 0xBBFF90
        public void set_MaxQueueItems(){} // RVA: 0x278E9A0
        public void get_MaxCacheItems(){} // RVA: 0xC10050
        public void set_MaxCacheItems(){} // RVA: 0x278E9C0
        public void get_ShutdownTimeout(){} // RVA: 0x6296990
        public void set_ShutdownTimeout(){} // RVA: 0x62969A0
        public void get_FlushTimeout(){} // RVA: 0x6D099E0
        public void set_FlushTimeout(){} // RVA: 0x6D099F0
        public void get_DecompressionMethods(){} // RVA: 0x106A7D0
        public void set_DecompressionMethods(){} // RVA: 0x6A6A800
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x106A050
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x6A6A810
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x6A649F0
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x6A64A00
        public void get_SendClientReports(){} // RVA: 0x6D09A00
        public void set_SendClientReports(){} // RVA: 0x6D09A10
        public void get_Debug(){} // RVA: 0x6D09A20
        public void set_Debug(){} // RVA: 0x6D09A30
        public void get_DiagnosticLevel(){} // RVA: 0x6D09A40
        public void set_DiagnosticLevel(){} // RVA: 0x6D09A50
        public void get_ReportAssembliesMode(){} // RVA: 0x6A64A30
        public void set_ReportAssembliesMode(){} // RVA: 0x6A64A40
        public void get_DeduplicateMode(){} // RVA: 0x6D09A60
        public void set_DeduplicateMode(){} // RVA: 0x6D09A70
        public void get_CacheDirectoryPath(){} // RVA: 0xCA4D80
        public void set_CacheDirectoryPath(){} // RVA: 0xCA4D90
        public void get_CaptureFailedRequests(){} // RVA: 0x6D09A80
        public void set_CaptureFailedRequests(){} // RVA: 0x6D09A90
        public void get_FailedRequestTargets(){} // RVA: 0x135D730
        public void set_FailedRequestTargets(){} // RVA: 0xBC5AD0
        public void get_DisableFileWrite(){} // RVA: 0x6C86EE0
        public void set_DisableFileWrite(){} // RVA: 0x6C86EF0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x6D09AA0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x6D09AB0
        public void get_DefaultTags(){} // RVA: 0x135A7B0
        public void set_DefaultTags(){} // RVA: 0xEC0BB0
        public void get_EnableTracing(){} // RVA: 0x6D09AC0
        public void set_EnableTracing(){} // RVA: 0x6D09AD0
        public void get_TracesSampleRate(){} // RVA: 0x6D09AE0
        public void set_TracesSampleRate(){} // RVA: 0x6D09AF0
        public void get_TracePropagationTargets(){} // RVA: 0xDA0520
        public void set_TracePropagationTargets(){} // RVA: 0xD9D570
        public void get_ProfilesSampleRate(){} // RVA: 0x6D09B00
        public void set_ProfilesSampleRate(){} // RVA: 0x6D09B10
        public void get_StackTraceMode(){} // RVA: 0x135EDB0
        public void set_StackTraceMode(){} // RVA: 0x6D09B20
        public void get_MaxAttachmentSize(){} // RVA: 0x6D09B30
        public void set_MaxAttachmentSize(){} // RVA: 0x6D09B40
        public void get_DetectStartupTime(){} // RVA: 0xBAE960
        public void set_DetectStartupTime(){} // RVA: 0x6D09B50
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x6D09B60
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x6D09B70
        public void get_AutoSessionTracking(){} // RVA: 0x6D09B80
        public void set_AutoSessionTracking(){} // RVA: 0x6D09B90
        public void get_UseAsyncFileIO(){} // RVA: 0x6D09BA0
        public void set_UseAsyncFileIO(){} // RVA: 0x6D09BB0
        public void get_JsonPreserveReferences(){} // RVA: 0x6D09BC0
        public void set_JsonPreserveReferences(){} // RVA: 0x6D09BD0
        public void get_EnableSpotlight(){} // RVA: 0x6D09BE0
        public void set_EnableSpotlight(){} // RVA: 0x6D09BF0
        public void get_SpotlightUrl(){} // RVA: 0x164B8E0
        public void set_SpotlightUrl(){} // RVA: 0x16601C0
        public void ApplyTo(){} // RVA: 0x6D09C00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class Breadcrumb : Object
    {
        public object _data;
        public object _message;
        public object _sendDefaultPii;
        public object _timestamp;
        public object _type;
        public object _category;
        public object _level;

        // ── Methods ──
        public void Redact(){} // RVA: 0x6D0B040
        public void get_Timestamp(){} // RVA: 0x19F92B0
        public void get_Message(){} // RVA: 0x6D0B050
        public void set_Message(){} // RVA: 0xBA9BA0
        public void get_Type(){} // RVA: 0xD05CA0
        public void get_Data(){} // RVA: 0x6D0B0E0
        public void set_Data(){} // RVA: 0xB44D60
        public void get_Category(){} // RVA: 0xBC1B30
        public void get_Level(){} // RVA: 0xBE5890
        public void .ctor(){} // RVA: 0x6D0B340
        public void WriteTo(){} // RVA: 0x6D0B5B0
        public void FromJson(){} // RVA: 0x6D0BAC0
    }

    public class BuiltInSystemDiagnosticsMeters : Object
    {
        public object MicrosoftAspNetCoreHostingPattern;
        public object MicrosoftAspNetCoreRoutingPattern;
        public object MicrosoftAspNetCoreDiagnosticsPattern;
        public object MicrosoftAspNetCoreRateLimitingPattern;
        public object MicrosoftAspNetCoreHeaderParsingPattern;
        public object MicrosoftAspNetCoreServerKestrelPattern;
        public object MicrosoftAspNetCoreHttpConnectionsPattern;
        public object MicrosoftExtensionsDiagnosticsHealthChecksPattern;
        public object MicrosoftExtensionsDiagnosticsResourceMonitoringPattern;
        public object OpenTelemetryInstrumentationRuntimePattern;
        public object SystemNetNameResolutionPattern;
        public object SystemNetHttpPattern;
        public object MicrosoftAspNetCoreHosting;
        public object MicrosoftAspNetCoreRouting;
        public object MicrosoftAspNetCoreDiagnostics;
        public object MicrosoftAspNetCoreRateLimiting;
        public object MicrosoftAspNetCoreHeaderParsing;
        public object MicrosoftAspNetCoreServerKestrel;
        public object MicrosoftAspNetCoreHttpConnections;
        public object MicrosoftExtensionsDiagnosticsHealthChecks;
        public object MicrosoftExtensionsDiagnosticsResourceMonitoring;
        public object OpenTelemetryInstrumentationRuntime;
        public object SystemNetNameResolution;
        public object SystemNetHttp;
        public object LazyAll;

        // ── Methods ──
        public void get_All(){} // RVA: 0x6D0C240
        public void .cctor(){} // RVA: 0x6D0C2C0
    }

    public class ByteAttachmentContent : Object
    {
        public object _bytes;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetStream(){} // RVA: 0x6D0CF80
    }

}