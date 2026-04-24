// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 13
// Methods: 343

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor : Object
    {
        public char[] TrimFilter;

        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFD53E57290
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD53E57790
    }

    public class HttpStatusCodeRange : ValueType
    {
        public int Start; // 0x10
        public int End; // 0x14

        // ── Methods ──
        public void get_Start(){} // RVA: 0x7FFD4F840210
        public void set_Start(){} // RVA: 0x7FFD4E78D8B0
        public void get_End(){} // RVA: 0x7FFD4F8402A0
        public void set_End(){} // RVA: 0x7FFD4F840230
        public void .ctor(){} // RVA: 0x7FFD53E5EFA0 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD53E5F030 | overloaded x4
        public void Contains(){} // RVA: 0x7FFD53E5F0D0 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD53E5F0E0
        public void PrintMembers(){} // RVA: 0x7FFD53E5F210
        public void op_Inequality(){} // RVA: 0x7FFD53E5F3C0
        public void op_Equality(){} // RVA: 0x7FFD53E5F3E0
        public void GetHashCode(){} // RVA: 0x7FFD53E5F400
        public void Equals(){} // RVA: 0x7FFD53E5F530 | overloaded x2
    }

    public class IHasExtra
    {
        public object Extra;

        // ── Methods ──
        public void get_Extra(){} // RVA: 0x7FFD4E078E90
        public void SetExtra(){} // RVA: 0x7FFD4E099B30
    }

    public class IHasTags
    {
        public object Tags;

        // ── Methods ──
        public void get_Tags(){} // RVA: 0x7FFD4E078E90
        public void SetTag(){} // RVA: 0x7FFD4E099B30
        public void UnsetTag(){} // RVA: 0x7FFD4E090A40
    }

    public class ISentryScopeManager
    {
        // ── Methods ──
        public void ConfigureScope(){} // RVA: 0x7FFD4E090A40
        public void ConfigureScopeAsync(){} // RVA: 0x7FFD4E078F40
        public void BindClient(){} // RVA: 0x7FFD4E090A40
        public void PushScope(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
    }

    public class ISentryScopeStateProcessor
    {
        // ── Methods ──
        public void Apply(){} // RVA: 0x7FFD4E099B30
    }

    public class ISpan
    {
        public object Description;
        public object Operation;
        public object Status;

        // ── Methods ──
        public void get_Description(){} // RVA: 0x7FFD4E078E90
        public void set_Description(){} // RVA: 0x7FFD4E090A40
        public void get_Operation(){} // RVA: 0x7FFD4E078E90
        public void set_Operation(){} // RVA: 0x7FFD4E090A40
        public void get_Status(){} // RVA: 0x7FFD4E078E90
        public void set_Status(){}
        public void StartChild(){} // RVA: 0x7FFD4E078F40
        public void Finish(){} // RVA: 0x7FFD4E090A40 | overloaded x4
    }

    public class ISpanData
    {
        public object StartTimestamp;
        public object EndTimestamp;
        public object IsFinished;
        public object Measurements;

        // ── Methods ──
        public void get_StartTimestamp(){} // RVA: 0x7FFD4E0788A0
        public void get_EndTimestamp(){} // RVA: 0x7FFD4E0788A0
        public void get_IsFinished(){} // RVA: 0x7FFD4E079D00
        public void GetTraceHeader(){} // RVA: 0x7FFD4E078E90
        public void get_Measurements(){} // RVA: 0x7FFD4E078E90
        public void SetMeasurement(){} // RVA: 0x7FFD4E099B30
    }

    public class SentryOptions : Object
    {
        public URA.DateTime<string,string> ScopeStackContainer; // 0x10
        public tor.F_SIGNED_CERT_IN_CHAIN InstallationId;
        public ield.ssionDenied IsGlobalModeEnabled; // 0x18
        public dle<string> ScopeObserver; // 0x20
        public aphy<bool> EnableScopeSync; // 0x28
        public RGBA_ETC2_SRGB.ChangedAwaitWithCancellation`2 Transport; // 0x30
        public bool ClientReportRecorder; // 0x38
        public k SentryStackTraceFactory; // 0x40
        public dle<IsPerformanceMonitoringEnabled.eforeSendTransaction>b__0> SentryVersion; // 0x48
        public dle<?> ExceptionProcessors; // 0x50
        public int TransactionProcessors; // 0x58
        public URA.woDigitYearMax<8BCA7B5CC287C51E0E3E<?,dle<ntract>>> EventProcessors; // 0x60
        public URA.woDigitYearMax<GetEventId> EventProcessorsProviders; // 0x68
        public URA.woDigitYearMax<8BCA7B5CC287C51E0E3E<?,dle<qualityContract>>> TransactionProcessorsProviders; // 0x70
        public URA.woDigitYearMax<ormation<URA.bbrevEraNames<qualityContract>>> ExceptionProcessorsProviders; // 0x78
        public URA.woDigitYearMax<ormation<URA.bbrevEraNames<GetEventId>>> Integrations; // 0x80
        public URA.woDigitYearMax<ormation<URA.bbrevEraNames<ntract>>> ExceptionFilters; // 0x88
        public syncFileIO TagFilters; // 0x90
        public URA.woDigitYearMax<icTypeExtensions> BackgroundWorker; // 0x98
        public URA.tCalendarData<RGBA_ETC2_SRGB.ts> SentryHttpClientFactory; // 0xA0
        public ield SentryScopeStateProcessor; // 0xA8
        public ngField.em.Collections.Generic.IEnumerator<System.IConvertible>.get_Current InAppExclude; // 0xB0
        public RGBA_ETC2_SRGB.1 InAppInclude; // 0xB8
        public URA.woDigitYearMax<IsPerformanceMonitoringEnabled.Frames> SendDefaultPii; // 0xC0
        public URA.woDigitYearMax<IsPerformanceMonitoringEnabled.Frames> IsEnvironmentUser; // 0xC8
        public bool ServerName; // 0xD0
        public bool AttachStacktrace; // 0xD1
        public string MaxBreadcrumbs; // 0xD8
        public bool SampleRate; // 0xE0
        public int Release; // 0xE4
        public aphy<float> Distribution; // 0xE8
        public string Environment; // 0xF0
        public string Dsn; // 0xF8
        public string ParsedDsn; // 0x100
        public string BeforeSendInternal; // 0x108
        public RGBA_ETC2_SRGB.electManyAwait>b__314_0 BeforeSendTransactionInternal; // 0x110
        public dle<string> BeforeBreadcrumbInternal; // 0x118
        public nalInformation<RGBA_ETC2_SRGB.?,RGBA_ETC2_SRGB.tAsync>d__38`1,RGBA_ETC2_SRGB.?> MaxQueueItems; // 0x120
        public nalInformation<RGBA_ETC2_SRGB.DiagnosticsMeters,RGBA_ETC2_SRGB.tAsync>d__38`1,RGBA_ETC2_SRGB.DiagnosticsMeters> MaxCacheItems; // 0x128
        public nalInformation<RGBA_ETC2_SRGB.<AnyAsync>d__1`1,RGBA_ETC2_SRGB.tAsync>d__38`1,RGBA_ETC2_SRGB.<AnyAsync>d__1`1> ShutdownTimeout; // 0x130
        public int FlushTimeout; // 0x138
        public int DecompressionMethods; // 0x13C
        public ializable.GetObjectData RequestBodyCompressionLevel; // 0x140
        public ializable.GetObjectData RequestBodyCompressionBuffered; // 0x148
        public ialized.tGrandParent SendClientReports; // 0x150
        public rtsAdvancedSorting.Attribute HttpProxy; // 0x154
        public bool CreateHttpMessageHandler; // 0x158
        public bool ConfigureClient; // 0x159
        public ialized.AddingCompleted Debug; // 0x160
        public ormation<eHeaderAsync>d__29.?> DiagnosticLevel; // 0x168
        public ileFullDirectoryInformation<eHeaderAsync>d__29.nContinuation> DiagnosticLogger; // 0x170
        public bool ReportAssembliesMode; // 0x178
        public RGBA_ETC2_SRGB.>d__23`1 DeduplicateMode; // 0x17A
        public riteTo>b__2_0 CacheDirectoryPath; // 0x180
        public RGBA_ETC2_SRGB.9__318_0 CaptureFailedRequests; // 0x188
        public RGBA_ETC2_SRGB.Zip>b__471_0 FailedRequestStatusCodes; // 0x18C
        public string FailedRequestTargets; // 0x190
        public bool FileSystem; // 0x198
        public URA.?<RGBA_ETC2_SRGB.107> DisableFileWrite; // 0x1A0
        public dle<URA.?<RGBA_ETC2_SRGB.ts>> InitCacheFlushTimeout; // 0x1A8
        public IsPerformanceMonitoringEnabled.ReportRecorder>b__0 DefaultTags; // 0x1B0
        public bool IsPerformanceMonitoringEnabled; // 0x1B8
        public ializable.GetObjectData IsProfilingEnabled; // 0x1C0
        public aphy<bool> EnableTracing; // 0x1C8
        public aphy<double> TracesSampleRate; // 0x1D0
        public aphy<double> ProfilesSampleRate; // 0x1E0
        public n<RGBA_ETC2_SRGB.nueTrace,aphy<double>> TracesSampler; // 0x1F0
        public URA.?<RGBA_ETC2_SRGB.ts> TracePropagationTargets; // 0x1F8
        public IsPerformanceMonitoringEnabled.rent TransactionProfilerFactory; // 0x200
        public aphy<RGBA_ETC2_SRGB.aitAsync>d__5`3> StackTraceMode; // 0x208
        public URA.woDigitYearMax<Internal.ICloneable<Sentry.Protocol.OperatingSystem>.Clone.Sentry.Internal.IUpdatable<Sentry.Protocol.OperatingSystem>.UpdateFrom> MaxAttachmentSize; // 0x210
        public long DetectStartupTime; // 0x218
        public RGBA_ETC2_SRGB.nter AutoSessionTrackingInterval; // 0x220
        public ializable.GetObjectData AutoSessionTracking; // 0x228
        public bool UseAsyncFileIO; // 0x230
        public bool CrashedLastRun; // 0x231
        public ormation<bool> Instrumenter; // 0x238
        public RGBA_ETC2_SRGB.eratorCurrent JsonPreserveReferences; // 0x240
        public ToStatsdType NetworkStatusListener; // 0x248
        public n<string,swordRequiredToKickSession.igitalHandles> AssemblyReader; // 0x250
        public RGBA_ETC2_SRGB.? ExperimentalMetrics; // 0x258
        public string SpotlightUrl; // 0x260
        public bool EnableSpotlight; // 0x268
        public IsPerformanceMonitoringEnabled._AutoSessionTracking SettingLocator; // 0x270
        public bool InitNativeSdks; // 0x278
        public URA.woDigitYearMax<ileFullDirectoryInformation<RGBA_ETC2_SRGB.`2>> PostInitCallbacks; // 0x280

        // ── Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7FFD4E3447C0
        public void set_ScopeStackContainer(){} // RVA: 0x7FFD4E3A7E80
        public void get_InstallationId(){} // RVA: 0x7FFD53F5D680
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7FFD53F5D6D0
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7FFD53F5D800
        public void get_ScopeObserver(){} // RVA: 0x7FFD4E5F95E0
        public void set_ScopeObserver(){} // RVA: 0x7FFD4E36F890
        public void get_EnableScopeSync(){} // RVA: 0x7FFD4E5F95D0
        public void set_EnableScopeSync(){} // RVA: 0x7FFD4E5F95C0
        public void get_Transport(){} // RVA: 0x7FFD4E3BE740
        public void set_Transport(){} // RVA: 0x7FFD4E369200
        public void get_ClientReportRecorder(){} // RVA: 0x7FFD53F5D850
        public void set_ClientReportRecorder(){} // RVA: 0x7FFD53F5D8A0
        public void get_SentryStackTraceFactory(){} // RVA: 0x7FFD53F5DA80
        public void set_SentryStackTraceFactory(){} // RVA: 0x7FFD53F5DAD0
        public void get_SentryVersion(){} // RVA: 0x7FFD4EA4EA40
        public void get_ExceptionProcessors(){} // RVA: 0x7FFD4E3DF370
        public void set_ExceptionProcessors(){} // RVA: 0x7FFD4E3DF380
        public void get_TransactionProcessors(){} // RVA: 0x7FFD4E3BCD50
        public void set_TransactionProcessors(){} // RVA: 0x7FFD4E3BCD60
        public void get_EventProcessors(){} // RVA: 0x7FFD4E409590
        public void set_EventProcessors(){} // RVA: 0x7FFD4E4095A0
        public void get_EventProcessorsProviders(){} // RVA: 0x7FFD4E505600
        public void set_EventProcessorsProviders(){} // RVA: 0x7FFD4E5006F0
        public void get_TransactionProcessorsProviders(){} // RVA: 0x7FFD4E70F410
        public void set_TransactionProcessorsProviders(){} // RVA: 0x7FFD4E8F4AA0
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x7FFD4E380010
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x7FFD4E96E300
        public void get_Integrations(){} // RVA: 0x7FFD53F5DCB0
        public void get_ExceptionFilters(){} // RVA: 0x7FFD4E96DFB0
        public void set_ExceptionFilters(){} // RVA: 0x7FFD4E96E3C0
        public void get_TagFilters(){} // RVA: 0x7FFD4E963900
        public void set_TagFilters(){} // RVA: 0x7FFD4E96E420
        public void get_BackgroundWorker(){} // RVA: 0x7FFD4E96B1A0
        public void set_BackgroundWorker(){} // RVA: 0x7FFD4E76B370
        public void get_SentryHttpClientFactory(){} // RVA: 0x7FFD4E3AC040
        public void set_SentryHttpClientFactory(){} // RVA: 0x7FFD4E3AC050
        public void GetHttpClient(){} // RVA: 0x7FFD53F5DD60
        public void get_SentryScopeStateProcessor(){} // RVA: 0x7FFD4E3AC0B0
        public void set_SentryScopeStateProcessor(){} // RVA: 0x7FFD4E3AC0C0
        public void get_InAppExclude(){} // RVA: 0x7FFD4E3AC120
        public void set_InAppExclude(){} // RVA: 0x7FFD4E3AC130
        public void get_InAppInclude(){} // RVA: 0x7FFD4E499460
        public void set_InAppInclude(){} // RVA: 0x7FFD4E499470
        public void get_SendDefaultPii(){} // RVA: 0x7FFD4E7EFDE0
        public void set_SendDefaultPii(){} // RVA: 0x7FFD4F743510
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFD53F5DE40
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFD53F5DE50
        public void get_ServerName(){} // RVA: 0x7FFD4E960F70
        public void set_ServerName(){} // RVA: 0x7FFD4E3C28A0
        public void get_AttachStacktrace(){} // RVA: 0x7FFD4E46CF80
        public void set_AttachStacktrace(){} // RVA: 0x7FFD4E46CF90
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFD4FBF5FD0
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFD51B353A0
        public void get_SampleRate(){} // RVA: 0x7FFD4E3C2970
        public void set_SampleRate(){} // RVA: 0x7FFD53F5DE60
        public void get_Release(){} // RVA: 0x7FFD4E3AC2A0
        public void set_Release(){} // RVA: 0x7FFD4E3AC2B0
        public void get_Distribution(){} // RVA: 0x7FFD4E751F50
        public void set_Distribution(){} // RVA: 0x7FFD4E8C4860
        public void get_Environment(){} // RVA: 0x7FFD4E916C80
        public void set_Environment(){} // RVA: 0x7FFD4E916750
        public void get_Dsn(){} // RVA: 0x7FFD4EAF1F40
        public void set_Dsn(){} // RVA: 0x7FFD53F5DF50
        public void get_ParsedDsn(){} // RVA: 0x7FFD53F5E020
        public void IsSentryRequest(){} // RVA: 0x7FFD53F5E270 | overloaded x2
        public void get_BeforeSendInternal(){} // RVA: 0x7FFD4E55CBB0
        public void SetBeforeSend(){} // RVA: 0x7FFD53F5E3E0 | overloaded x2
        public void get_BeforeSendTransactionInternal(){} // RVA: 0x7FFD4E9666F0
        public void SetBeforeSendTransaction(){} // RVA: 0x7FFD53F5E560 | overloaded x2
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x7FFD4E964340
        public void SetBeforeBreadcrumb(){} // RVA: 0x7FFD53F5E6E0 | overloaded x2
        public void get_MaxQueueItems(){} // RVA: 0x7FFD4F0AEC30
        public void set_MaxQueueItems(){} // RVA: 0x7FFD53F5E860
        public void get_MaxCacheItems(){} // RVA: 0x7FFD53CE7230
        public void set_MaxCacheItems(){} // RVA: 0x7FFD53F5E920
        public void get_ShutdownTimeout(){} // RVA: 0x7FFD4E3AC5F0
        public void set_ShutdownTimeout(){} // RVA: 0x7FFD53F5E9E0
        public void get_FlushTimeout(){} // RVA: 0x7FFD4E3AC660
        public void set_FlushTimeout(){} // RVA: 0x7FFD53E53F90
        public void get_DecompressionMethods(){} // RVA: 0x7FFD4F0ADCE0
        public void set_DecompressionMethods(){} // RVA: 0x7FFD4F0AEC20
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFD53F5E9F0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFD53F5EA00
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7FFD53F5EA10
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7FFD53F5EA20
        public void get_SendClientReports(){} // RVA: 0x7FFD4F143ED0
        public void set_SendClientReports(){} // RVA: 0x7FFD4F1458D0
        public void get_HttpProxy(){} // RVA: 0x7FFD4E7C98A0
        public void set_HttpProxy(){} // RVA: 0x7FFD4E7CFA60
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7FFD4E96E2F0
        public void set_CreateHttpMessageHandler(){} // RVA: 0x7FFD4EDC80B0
        public void get_ConfigureClient(){} // RVA: 0x7FFD4E78D850
        public void set_ConfigureClient(){} // RVA: 0x7FFD4EDD5DB0
        public void get_Debug(){} // RVA: 0x7FFD53F5EA30
        public void set_Debug(){} // RVA: 0x7FFD53F5EA40
        public void get_DiagnosticLevel(){} // RVA: 0x7FFD53F5EA50
        public void set_DiagnosticLevel(){} // RVA: 0x7FFD53F5EA60
        public void get_DiagnosticLogger(){} // RVA: 0x7FFD53F5EA70
        public void set_DiagnosticLogger(){} // RVA: 0x7FFD53F5EA90
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFD4E7D23B0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFD53F5EBD0
        public void get_DeduplicateMode(){} // RVA: 0x7FFD53E344D0
        public void set_DeduplicateMode(){} // RVA: 0x7FFD53F5EBE0
        public void get_CacheDirectoryPath(){} // RVA: 0x7FFD4E960F60
        public void set_CacheDirectoryPath(){} // RVA: 0x7FFD4EDCB1D0
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFD53F5EBF0
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFD53F5EC00
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFD4E96E2E0
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFD4EDC8AF0
        public void get_FailedRequestTargets(){} // RVA: 0x7FFD53F5EC10
        public void set_FailedRequestTargets(){} // RVA: 0x7FFD53F5EC60
        public void get_FileSystem(){} // RVA: 0x7FFD53F5ED90
        public void set_FileSystem(){} // RVA: 0x7FFD4EDC7790
        public void get_DisableFileWrite(){} // RVA: 0x7FFD53F5EE50
        public void set_DisableFileWrite(){} // RVA: 0x7FFD53F5EE60
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFD4E9622B0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFD53F5EE70
        public void get_DefaultTags(){} // RVA: 0x7FFD53F5EE80
        public void set_DefaultTags(){} // RVA: 0x7FFD4E342E30
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x7FFD53F5EF40
        public void get_IsProfilingEnabled(){} // RVA: 0x7FFD53F5F040
        public void get_EnableTracing(){} // RVA: 0x7FFD53F5F180
        public void set_EnableTracing(){} // RVA: 0x7FFD53F5F190
        public void get_TracesSampleRate(){} // RVA: 0x7FFD53F5F1A0
        public void set_TracesSampleRate(){} // RVA: 0x7FFD53F5F1B0
        public void get_ProfilesSampleRate(){} // RVA: 0x7FFD53F5F2C0
        public void set_ProfilesSampleRate(){} // RVA: 0x7FFD53F5F2D0
        public void get_TracesSampler(){} // RVA: 0x7FFD4E964EF0
        public void set_TracesSampler(){} // RVA: 0x7FFD4E961400
        public void get_TracePropagationTargets(){} // RVA: 0x7FFD4E961460
        public void set_TracePropagationTargets(){} // RVA: 0x7FFD53F5F3E0
        public void get_TransactionProfilerFactory(){} // RVA: 0x7FFD4E964790
        public void set_TransactionProfilerFactory(){} // RVA: 0x7FFD4E96D230
        public void get_StackTraceMode(){} // RVA: 0x7FFD53F5F480
        public void set_StackTraceMode(){} // RVA: 0x7FFD53F5F680
        public void get_MaxAttachmentSize(){} // RVA: 0x7FFD4E961470
        public void set_MaxAttachmentSize(){} // RVA: 0x7FFD53F5F6E0
        public void get_DetectStartupTime(){} // RVA: 0x7FFD53F5F6F0
        public void set_DetectStartupTime(){} // RVA: 0x7FFD53F5F700
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFD4E960FB0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFD53F5F710
        public void get_AutoSessionTracking(){} // RVA: 0x7FFD53E15240
        public void set_AutoSessionTracking(){} // RVA: 0x7FFD53E15250
        public void get_UseAsyncFileIO(){} // RVA: 0x7FFD53E15260
        public void set_UseAsyncFileIO(){} // RVA: 0x7FFD53E15270
        public void get_CrashedLastRun(){} // RVA: 0x7FFD4E9613D0
        public void set_CrashedLastRun(){} // RVA: 0x7FFD4EDCA7F0
        public void get_Instrumenter(){} // RVA: 0x7FFD53F5F720
        public void set_Instrumenter(){} // RVA: 0x7FFD53F5F730
        public void AddJsonConverter(){} // RVA: 0x7FFD53F5F740
        public void AddJsonSerializerContext(){} // RVA: 0x7FFD4E090A40
        public void get_JsonPreserveReferences(){} // RVA: 0x7FFD53F5F7E0
        public void set_JsonPreserveReferences(){} // RVA: 0x7FFD53F5F880
        public void get_NetworkStatusListener(){} // RVA: 0x7FFD4EDC6830
        public void set_NetworkStatusListener(){} // RVA: 0x7FFD4EDC8760
        public void get_AssemblyReader(){} // RVA: 0x7FFD4EDE5D60
        public void set_AssemblyReader(){} // RVA: 0x7FFD4EDD0650
        public void get_ExperimentalMetrics(){} // RVA: 0x7FFD4EDDCEE0
        public void set_ExperimentalMetrics(){} // RVA: 0x7FFD4E76B310
        public void get_SpotlightUrl(){} // RVA: 0x7FFD4EDEABF0
        public void set_SpotlightUrl(){} // RVA: 0x7FFD4EDCE8C0
        public void get_EnableSpotlight(){} // RVA: 0x7FFD53F5F920
        public void set_EnableSpotlight(){} // RVA: 0x7FFD53F5F930
        public void get_SettingLocator(){} // RVA: 0x7FFD4EDE8960
        public void set_SettingLocator(){} // RVA: 0x7FFD4EDCD8D0
        public void get_InitNativeSdks(){} // RVA: 0x7FFD53F5F940
        public void set_InitNativeSdks(){} // RVA: 0x7FFD53F5F950
        public void get_PostInitCallbacks(){} // RVA: 0x7FFD4EDD03C0
        public void set_PostInitCallbacks(){} // RVA: 0x7FFD4EDEC790
        public void .ctor(){} // RVA: 0x7FFD53F5F960
        public void AddIntegration(){} // RVA: 0x7FFD53F61A80
        public void RemoveIntegration(){} // RVA: 0x7FFD4E090980
        public void AddExceptionFilter(){} // RVA: 0x7FFD53F61B20
        public void RemoveExceptionFilter(){} // RVA: 0x7FFD4E090980
        public void AddExceptionFilterForType(){} // RVA: 0x7FFD4E090980
        public void AddInAppExclude(){} // RVA: 0x7FFD53F61DF0 | overloaded x2
        public void AddInAppExcludeRegex(){} // RVA: 0x7FFD53F61FA0
        public void AddInAppInclude(){} // RVA: 0x7FFD53F62350 | overloaded x2
        public void AddInAppIncludeRegex(){} // RVA: 0x7FFD53F62500
        public void AddExceptionProcessor(){} // RVA: 0x7FFD53F62700
        public void AddExceptionProcessors(){} // RVA: 0x7FFD53F628F0
        public void AddEventProcessor(){} // RVA: 0x7FFD53F62AC0
        public void AddEventProcessors(){} // RVA: 0x7FFD53F62CB0
        public void RemoveEventProcessor(){} // RVA: 0x7FFD4E090980
        public void AddEventProcessorProvider(){} // RVA: 0x7FFD53F62E80
        public void AddTransactionProcessor(){} // RVA: 0x7FFD53F62EE0
        public void AddTransactionProcessors(){} // RVA: 0x7FFD53F62FF0
        public void RemoveTransactionProcessor(){} // RVA: 0x7FFD4E090980
        public void AddTransactionProcessorProvider(){} // RVA: 0x7FFD53F63160
        public void AddExceptionProcessorProvider(){} // RVA: 0x7FFD53F63350
        public void GetAllEventProcessors(){} // RVA: 0x7FFD53F633B0
        public void GetAllTransactionProcessors(){} // RVA: 0x7FFD53F63520
        public void GetAllExceptionProcessors(){} // RVA: 0x7FFD53F63690
        public void UseStackTraceFactory(){} // RVA: 0x7FFD53F63800
        public void ApplyDefaultTags(){} // RVA: 0x7FFD53F63A30
        public void DisableDuplicateEventDetection(){} // RVA: 0x7FFD53F63E30
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x7FFD53F63E70
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x7FFD53F63E80
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x7FFD53F63E90
        public void HasIntegration(){} // RVA: 0x7FFD4E079D00
        public void RemoveDefaultIntegration(){} // RVA: 0x7FFD53F63EA0
        public void SetupLogging(){} // RVA: 0x7FFD53F63EB0
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x7FFD53F640E0
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x7FFD53F64340
        public void <.ctor>b__346_0(){} // RVA: 0x7FFD53F64350
        public void <.ctor>b__346_5(){} // RVA: 0x7FFD53F64480
        public void <.ctor>b__346_1(){} // RVA: 0x7FFD53F644D0
        public void <.ctor>b__346_2(){} // RVA: 0x7FFD53F64530
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x7FFD53F5DA80
        public void <.ctor>b__346_6(){} // RVA: 0x7FFD53F645C0
        public void <.ctor>b__346_7(){} // RVA: 0x7FFD53F64710
        public void <.ctor>b__346_8(){} // RVA: 0x7FFD53F64910
        public void <.ctor>b__346_10(){} // RVA: 0x7FFD53F64A80
        public void <.ctor>b__346_11(){} // RVA: 0x7FFD53F64BC0
        public void <.ctor>b__346_4(){} // RVA: 0x7FFD53F64D30
    }

    public class SentrySdk : Object
    {
        public RGBA_ETC2_SRGB.`2 CurrentOptions;

        // ── Methods ──
        public void get_CurrentOptions(){} // RVA: 0x7FFD53F67A80
        public void get_LastEventId(){} // RVA: 0x7FFD53F67AE0
        public void InitHub(){} // RVA: 0x7FFD53F67B80
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x7FFD53F68160
        public void Init(){} // RVA: 0x7FFD53F68630 | overloaded x4
        public void UseHub(){} // RVA: 0x7FFD53F687D0
        public void Flush(){} // RVA: 0x7FFD53F68A10 | overloaded x2
        public void FlushAsync(){} // RVA: 0x7FFD53F68AD0 | overloaded x2
        public void Close(){} // RVA: 0x7FFD53F68B60
        public void get_IsEnabled(){} // RVA: 0x7FFD53F68CF0
        public void PushScope(){} // RVA: 0x7FFD53F68D70 | overloaded x2
        public void BindClient(){} // RVA: 0x7FFD53F68DF0
        public void AddBreadcrumb(){} // RVA: 0x7FFD53F68FD0 | overloaded x3
        public void ConfigureScope(){} // RVA: 0x7FFD53F69040
        public void ConfigureScopeAsync(){} // RVA: 0x7FFD53F690C0
        public void CaptureEnvelope(){} // RVA: 0x7FFD53F69140
        public void CaptureEvent(){} // RVA: 0x7FFD53F69360 | overloaded x3
        public void CaptureException(){} // RVA: 0x7FFD53F694A0 | overloaded x2
        public void CaptureMessage(){} // RVA: 0x7FFD53F69680 | overloaded x2
        public void CaptureUserFeedback(){} // RVA: 0x7FFD53F698F0 | overloaded x2
        public void CaptureTransaction(){} // RVA: 0x7FFD53F69A70 | overloaded x2
        public void CaptureSession(){} // RVA: 0x7FFD53F69B10
        public void CaptureCheckIn(){} // RVA: 0x7FFD53F69B90
        public void StartTransaction(){} // RVA: 0x7FFD53F6A030 | overloaded x6
        public void BindException(){} // RVA: 0x7FFD53F6A0C0
        public void GetSpan(){} // RVA: 0x7FFD53F6A150
        public void GetTraceHeader(){} // RVA: 0x7FFD53F6A1D0
        public void GetBaggage(){} // RVA: 0x7FFD53F6A250
        public void ContinueTrace(){} // RVA: 0x7FFD53F6A410 | overloaded x2
        public void get_Metrics(){} // RVA: 0x7FFD53F6A550
        public void StartSession(){} // RVA: 0x7FFD53F6A5D0
        public void EndSession(){} // RVA: 0x7FFD53F6A650
        public void PauseSession(){} // RVA: 0x7FFD53F6A6E0
        public void ResumeSession(){} // RVA: 0x7FFD53F6A760
        public void CauseCrash(){} // RVA: 0x7FFD53F6A7E0
        public void .cctor(){} // RVA: 0x7FFD53F6AE10
    }

    public class SentryValues`1 : Object
    {
        public URA.bbrevEraNames<T1717641712> Values;

        // ── Methods ──
        public void get_Values(){} // RVA: 0x7FFD4E078E90
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void WriteTo(){} // RVA: 0x7FFD4E099B30
    }

    public class SubstringOrRegexPattern : Object
    {
        public tor.neStore Regex; // 0x10
        public string _substring; // 0x18
        public meZone _stringComparison; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30 | overloaded x2
        public void op_Implicit(){} // RVA: 0x7FFD53F7E410 | overloaded x2
        public void ToString(){} // RVA: 0x7FFD53F7E4A0
        public void Equals(){} // RVA: 0x7FFD53F7E510
        public void GetHashCode(){} // RVA: 0x7FFD4FDFB960
        public void get_Regex(){} // RVA: 0x7FFD4E35C380
        public void IsMatch(){} // RVA: 0x7FFD53F7E610
        public void TryParseRegex(){} // RVA: 0x7FFD53F7E7B0
    }

    public class SubstringOrRegexPatternExtensions : Object
    {
        // ── Methods ──
        public void ContainsMatch(){} // RVA: 0x7FFD53F7E860
        public void WithConfigBinding(){} // RVA: 0x7FFD4E078F80
    }

}