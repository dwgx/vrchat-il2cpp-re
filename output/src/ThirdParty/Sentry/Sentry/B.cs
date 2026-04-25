// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 5
// Methods: 118

namespace ThirdParty.Sentry.Sentry
{
    public class BaggageHeader : Object
    {
        public string Logger;
        public string Members;
        public Sentry.Extensibility.IDiagnosticLogger <Logger>k__BackingField;
        public System.Collections.Generic.IReadOnlyList`1<System.Collections.Generic.KeyValuePair`2<string,string>> <Members>k__BackingField; // 0x10

        // ── Methods ──
        public void get_Logger(){} // RVA: 0x7FFAC8A320C0
        public void set_Logger(){} // RVA: 0x7FFAC8A32120
        public void get_Members(){} // RVA: 0x7FFAC2F3C380
        public void .ctor(){} // RVA: 0x7FFAC8A321D0
        public void GetSentryMembers(){} // RVA: 0x7FFAC8A322F0
        public void ToString(){} // RVA: 0x7FFAC8A329D0
        public void TryParse(){} // RVA: 0x7FFAC8A32B60
        public void Create(){} // RVA: 0x7FFAC8A32F40
        public void Merge(){} // RVA: 0x7FFAC8A33230
        public void IsValidKey(){} // RVA: 0x7FFAC8A33520
        public void .cctor(){} // RVA: 0x7FFAC8A336A0
    }

    public class BindableSentryOptions : Object
    {
        public System.Nullable`1<bool> IsGlobalModeEnabled; // 0x10
        public System.Nullable`1<bool> EnableScopeSync; // 0x12
        public System.Collections.Generic.List`1<string> TagFilters; // 0x18
        public System.Nullable`1<bool> SendDefaultPii; // 0x20
        public System.Nullable`1<bool> IsEnvironmentUser; // 0x22
        public string ServerName; // 0x28
        public System.Nullable`1<bool> AttachStacktrace; // 0x30
        public System.Nullable`1<int> MaxBreadcrumbs; // 0x34
        public System.Nullable`1<float> SampleRate; // 0x3C
        public string Release; // 0x48
        public string Distribution; // 0x50
        public string Environment; // 0x58
        public string Dsn; // 0x60
        public System.Nullable`1<int> MaxQueueItems; // 0x68
        public System.Nullable`1<int> MaxCacheItems; // 0x70
        public System.Nullable`1<System.TimeSpan> ShutdownTimeout; // 0x78
        public System.Nullable`1<System.TimeSpan> FlushTimeout; // 0x88
        public System.Nullable`1<0x6B13CA68> DecompressionMethods; // 0x98
        public System.Nullable`1<0x6B139788> RequestBodyCompressionLevel; // 0xA0
        public System.Nullable`1<bool> RequestBodyCompressionBuffered; // 0xA8
        public System.Nullable`1<bool> SendClientReports; // 0xAA
        public System.Nullable`1<bool> Debug; // 0xAC
        public System.Nullable`1<0x6B198C68> DiagnosticLevel; // 0xAE
        public System.Nullable`1<0x6B198168> ReportAssembliesMode; // 0xB4
        public System.Nullable`1<0x6B196850> DeduplicateMode; // 0xBC
        public string CacheDirectoryPath; // 0xC8
        public System.Nullable`1<bool> CaptureFailedRequests; // 0xD0
        public System.Collections.Generic.List`1<string> FailedRequestTargets; // 0xD8
        public System.Nullable`1<bool> DisableFileWrite; // 0xE0
        public System.Nullable`1<System.TimeSpan> InitCacheFlushTimeout; // 0xE8
        public System.Collections.Generic.Dictionary`2<string,string> DefaultTags; // 0xF8
        public System.Nullable`1<bool> EnableTracing; // 0x100
        public System.Nullable`1<double> TracesSampleRate; // 0x108
        public System.Collections.Generic.List`1<string> TracePropagationTargets; // 0x118
        public System.Nullable`1<double> ProfilesSampleRate; // 0x120
        public System.Nullable`1<0x6B19A058> StackTraceMode; // 0x130
        public System.Nullable`1<long> MaxAttachmentSize; // 0x138
        public System.Nullable`1<0x6B19A0B0> DetectStartupTime; // 0x148
        public System.Nullable`1<System.TimeSpan> AutoSessionTrackingInterval; // 0x150
        public System.Nullable`1<bool> AutoSessionTracking; // 0x160
        public System.Nullable`1<bool> UseAsyncFileIO; // 0x162
        public System.Nullable`1<bool> JsonPreserveReferences; // 0x164
        public System.Nullable`1<bool> EnableSpotlight; // 0x166
        public string SpotlightUrl; // 0x168

        // ── Methods ──
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFAC469AEC0
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFAC469BCA0
        public void get_EnableScopeSync(){} // RVA: 0x7FFAC8A33DD0
        public void set_EnableScopeSync(){} // RVA: 0x7FFAC8A33DE0
        public void get_TagFilters(){} // RVA: 0x7FFAC2F247C0
        public void set_TagFilters(){} // RVA: 0x7FFAC2F87E80
        public void get_SendDefaultPii(){} // RVA: 0x7FFAC6D68C80
        public void set_SendDefaultPii(){} // RVA: 0x7FFAC8258410
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFAC8258420
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFAC8258430
        public void get_ServerName(){} // RVA: 0x7FFAC2F4F130
        public void set_ServerName(){} // RVA: 0x7FFAC2F22E90
        public void get_AttachStacktrace(){} // RVA: 0x7FFAC64EB3B0
        public void set_AttachStacktrace(){} // RVA: 0x7FFAC8258FE0
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAC8A33DF0
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFAC370B770
        public void get_SampleRate(){} // RVA: 0x7FFAC8A33E00
        public void set_SampleRate(){} // RVA: 0x7FFAC8A33E10
        public void get_Release(){} // RVA: 0x7FFAC2F9C730
        public void set_Release(){} // RVA: 0x7FFAC2F9C740
        public void get_Distribution(){} // RVA: 0x7FFAC2FC20E0
        public void set_Distribution(){} // RVA: 0x7FFAC30794D0
        public void get_Environment(){} // RVA: 0x7FFAC2FE9500
        public void set_Environment(){} // RVA: 0x7FFAC2FE9510
        public void get_Dsn(){} // RVA: 0x7FFAC2FBF370
        public void set_Dsn(){} // RVA: 0x7FFAC2FBF380
        public void get_MaxQueueItems(){} // RVA: 0x7FFAC2F9CD50
        public void set_MaxQueueItems(){} // RVA: 0x7FFAC4A2BA80
        public void get_MaxCacheItems(){} // RVA: 0x7FFAC2FE9590
        public void set_MaxCacheItems(){} // RVA: 0x7FFAC4A2BA60
        public void get_ShutdownTimeout(){} // RVA: 0x7FFAC8A33E20
        public void set_ShutdownTimeout(){} // RVA: 0x7FFAC8A33E30
        public void get_FlushTimeout(){} // RVA: 0x7FFAC7DF99E0
        public void set_FlushTimeout(){} // RVA: 0x7FFAC7DF99F0
        public void get_DecompressionMethods(){} // RVA: 0x7FFAC354DFB0
        public void set_DecompressionMethods(){} // RVA: 0x7FFAC7E01AA0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFAC3543900
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFAC878D950
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAC8787AF0
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFAC8787B00
        public void get_SendClientReports(){} // RVA: 0x7FFAC8A33E40
        public void set_SendClientReports(){} // RVA: 0x7FFAC8A33E50
        public void get_Debug(){} // RVA: 0x7FFAC8A33E60
        public void set_Debug(){} // RVA: 0x7FFAC8A33E70
        public void get_DiagnosticLevel(){} // RVA: 0x7FFAC8A33E80
        public void set_DiagnosticLevel(){} // RVA: 0x7FFAC8A33E90
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAC8787B30
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFAC8787B40
        public void get_DeduplicateMode(){} // RVA: 0x7FFAC8A33EA0
        public void set_DeduplicateMode(){} // RVA: 0x7FFAC8A33EB0
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFAC3079460
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFAC3079470
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAC8A33EC0
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFAC8A33ED0
        public void get_FailedRequestTargets(){} // RVA: 0x7FFAC3540F70
        public void set_FailedRequestTargets(){} // RVA: 0x7FFAC2FA28A0
        public void get_DisableFileWrite(){} // RVA: 0x7FFAC89B0460
        public void set_DisableFileWrite(){} // RVA: 0x7FFAC89B0470
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFAC8A33EE0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFAC8A33EF0
        public void get_DefaultTags(){} // RVA: 0x7FFAC3331F50
        public void set_DefaultTags(){} // RVA: 0x7FFAC34A4860
        public void get_EnableTracing(){} // RVA: 0x7FFAC8A33F00
        public void set_EnableTracing(){} // RVA: 0x7FFAC8A33F10
        public void get_TracesSampleRate(){} // RVA: 0x7FFAC8A33F20
        public void set_TracesSampleRate(){} // RVA: 0x7FFAC8A33F30
        public void get_TracePropagationTargets(){} // RVA: 0x7FFAC33BC6D0
        public void set_TracePropagationTargets(){} // RVA: 0x7FFAC33B8580
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFAC8A33F40
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFAC8A33F50
        public void get_StackTraceMode(){} // RVA: 0x7FFAC3544340
        public void set_StackTraceMode(){} // RVA: 0x7FFAC8A33F60
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFAC8A33F70
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFAC8A33F80
        public void get_DetectStartupTime(){} // RVA: 0x7FFAC2F8C660
        public void set_DetectStartupTime(){} // RVA: 0x7FFAC8A33F90
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFAC8A33FA0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFAC8A33FB0
        public void get_AutoSessionTracking(){} // RVA: 0x7FFAC8A33FC0
        public void set_AutoSessionTracking(){} // RVA: 0x7FFAC8A33FD0
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFAC8A33FE0
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFAC8A33FF0
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFAC8A34000
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFAC8A34010
        public void get_EnableSpotlight(){} // RVA: 0x7FFAC8A34020
        public void set_EnableSpotlight(){} // RVA: 0x7FFAC8A34030
        public void get_SpotlightUrl(){} // RVA: 0x7FFAC354E2F0
        public void set_SpotlightUrl(){} // RVA: 0x7FFAC39A80B0
        public void ApplyTo(){} // RVA: 0x7FFAC8A34040
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class Breadcrumb : Object
    {
        public System.Collections.Generic.IReadOnlyDictionary`2<string,string> Timestamp; // 0x10
        public string Message; // 0x18
        public bool Type; // 0x20
        public System.DateTimeOffset Data; // 0x28
        public string Category; // 0x38
        public string Level; // 0x40
        public 0x6B196698 <Level>k__BackingField; // 0x48

        // ── Methods ──
        public void Redact(){} // RVA: 0x7FFAC3D3C410
        public void get_Timestamp(){} // RVA: 0x7FFAC3BCF020
        public void get_Message(){} // RVA: 0x7FFAC8A35480
        public void set_Message(){} // RVA: 0x7FFAC2F87E80
        public void get_Type(){} // RVA: 0x7FFAC31D0140
        public void get_Data(){} // RVA: 0x7FFAC8A35510
        public void set_Data(){} // RVA: 0x7FFAC2F22E30
        public void get_Category(){} // RVA: 0x7FFAC2F9E740
        public void get_Level(){} // RVA: 0x7FFAC2FC20C0
        public void .ctor(){} // RVA: 0x7FFAC8A35770 | overloaded x2
        public void WriteTo(){} // RVA: 0x7FFAC8A359E0
        public void FromJson(){} // RVA: 0x7FFAC8A35D70
    }

    public class BuiltInSystemDiagnosticsMeters : Object
    {
        public string All;
        public string MicrosoftAspNetCoreRoutingPattern;
        public string MicrosoftAspNetCoreDiagnosticsPattern;
        public string MicrosoftAspNetCoreRateLimitingPattern;
        public string MicrosoftAspNetCoreHeaderParsingPattern;
        public string MicrosoftAspNetCoreServerKestrelPattern;
        public string MicrosoftAspNetCoreHttpConnectionsPattern;
        public string MicrosoftExtensionsDiagnosticsHealthChecksPattern;
        public string MicrosoftExtensionsDiagnosticsResourceMonitoringPattern;
        public string OpenTelemetryInstrumentationRuntimePattern;
        public string SystemNetNameResolutionPattern;
        public string SystemNetHttpPattern;
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreHosting;
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreRouting; // 0x8
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreDiagnostics; // 0x10
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreRateLimiting; // 0x18
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreHeaderParsing; // 0x20
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreServerKestrel; // 0x28
        public Sentry.SubstringOrRegexPattern MicrosoftAspNetCoreHttpConnections; // 0x30
        public Sentry.SubstringOrRegexPattern MicrosoftExtensionsDiagnosticsHealthChecks; // 0x38
        public Sentry.SubstringOrRegexPattern MicrosoftExtensionsDiagnosticsResourceMonitoring; // 0x40
        public Sentry.SubstringOrRegexPattern OpenTelemetryInstrumentationRuntime; // 0x48
        public Sentry.SubstringOrRegexPattern SystemNetNameResolution; // 0x50
        public Sentry.SubstringOrRegexPattern SystemNetHttp; // 0x58
        public System.Lazy`1<System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern>> LazyAll; // 0x60

        // ── Methods ──
        public void get_All(){} // RVA: 0x7FFAC8A364F0
        public void .cctor(){} // RVA: 0x7FFAC8A36570
    }

    public class ByteAttachmentContent : Object
    {
        public byte[] _bytes; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetStream(){} // RVA: 0x7FFAC8A37230
    }

}