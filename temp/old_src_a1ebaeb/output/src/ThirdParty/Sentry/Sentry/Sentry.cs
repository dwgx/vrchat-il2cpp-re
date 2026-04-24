// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 13
// Methods: 343

namespace ThirdParty.Sentry.Sentry
{
    public class DefaultSentryScopeStateProcessor : Object
    {
        // ── Original Methods ──
        public void Apply(){} // RVA: 0x7ffaae4584b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae4589b0
    }

    public class HttpStatusCodeRange : ValueType
    {
        // ── Original Methods ──
        public void get_Start(){} // RVA: 0x7ffaa9e47550
        public void set_Start(){} // RVA: 0x7ffaa8d92880
        public void get_End(){} // RVA: 0x7ffaa9e47530
        public void set_End(){} // RVA: 0x7ffaa9e475c0
        public void .ctor(){} // RVA: 0x7ffaae4601c0
        public void .ctor(){} // RVA: 0x7ffaae4601c0
        public void op_Implicit(){} // RVA: 0x7ffaae460250
        public void op_Implicit(){} // RVA: 0x7ffaae460250
        public void op_Implicit(){} // RVA: 0x7ffaae460250
        public void op_Implicit(){} // RVA: 0x7ffaae460250
        public void Contains(){} // RVA: 0x7ffaae4602f0
        public void Contains(){} // RVA: 0x7ffaae4602f0
        public void ToString(){} // RVA: 0x7ffaae460300
        public void PrintMembers(){} // RVA: 0x7ffaae460430
        public void op_Inequality(){} // RVA: 0x7ffaae4605e0
        public void op_Equality(){} // RVA: 0x7ffaae460600
        public void Equals(){} // RVA: 0x7ffaae460750
        public void Equals(){} // RVA: 0x7ffaae460750
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaae460620
    }

    public class IHasExtra
    {
        // ── Original Methods ──
        public void get_Extra(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void SetExtra(){} // RVA: 0x7ffaa8669e70
    }

    public class IHasTags
    {
        // ── Original Methods ──
        public void get_Tags(){} // RVA: 0x7ffaa86491d0
        public void UnsetTag(){} // RVA: 0x7ffaa8660d80
        // ── Binary Analysis Named ──
        public void SetTag(){} // RVA: 0x7ffaa8669e70
    }

    public class ISentryScopeManager
    {
        // ── Original Methods ──
        public void ConfigureScope(){} // RVA: 0x7ffaa8660d80
        public void ConfigureScopeAsync(){} // RVA: 0x7ffaa8649280
        public void BindClient(){} // RVA: 0x7ffaa8660d80
        public void PushScope(){} // RVA: 0x7ffaa887e5c0
        public void PushScope(){} // RVA: 0x7ffaa887e5c0
    }

    public class ISentryScopeStateProcessor
    {
        // ── Original Methods ──
        public void Apply(){} // RVA: 0x7ffaa8669e70
    }

    public class ISpan
    {
        // ── Original Methods ──
        public void get_Description(){} // RVA: 0x7ffaa86491d0
        public void set_Description(){} // RVA: 0x7ffaa8660d80
        public void get_Operation(){} // RVA: 0x7ffaa86491d0
        public void set_Operation(){} // RVA: 0x7ffaa8660d80
        public void get_Status(){} // RVA: 0x7ffaa86491d0
        public void set_Status(){}
        public void StartChild(){} // RVA: 0x7ffaa8649280
        public void Finish(){} // RVA: 0x7ffaa8660d80
        public void Finish(){} // RVA: 0x7ffaa8660d80
        public void Finish(){} // RVA: 0x7ffaa8660d80
        public void Finish(){} // RVA: 0x7ffaa8660d80
    }

    public class ISpanData
    {
        // ── Original Methods ──
        public void get_StartTimestamp(){} // RVA: 0x7ffaa8648be0
        public void get_EndTimestamp(){} // RVA: 0x7ffaa8648be0
        public void get_IsFinished(){} // RVA: 0x7ffaa864a040
        public void get_Measurements(){} // RVA: 0x7ffaa86491d0
        // ── Binary Analysis Named ──
        public void GetTraceHeader(){} // RVA: 0x7ffaa86491d0
        public void SetMeasurement(){} // RVA: 0x7ffaa8669e70
    }

    public class SentryOptions : Object
    {
        public object _scopeStackContainer; // 0x30B90F10, was: <ScopeStackContainer>k__Backin
        public object _scopeObserver; // 0x30B90F10, was: <ScopeObserver>k__BackingField
        public object _clientReportRecorder; // 0x30B90F10
        public object _exceptionProcessors; // 0x30B90F10, was: <ExceptionProcessors>k__Backin
        public object _eventProcessorsProviders; // 0x30B90F10, was: <EventProcessorsProviders>k__B
        public object _defaultIntegrations; // 0x30B90F10
        public object _backgroundWorker; // 0x30B90F10, was: <BackgroundWorker>k__BackingFi
        public object _inAppExclude; // 0x30B90F10, was: <InAppExclude>k__BackingField
        public object _isEnvironmentUser; // 0x30B90F10, was: <IsEnvironmentUser>k__BackingF
        public object _maxBreadcrumbs; // 0x30B90F10, was: <MaxBreadcrumbs>k__BackingFiel
        public object _distribution; // 0x30B90F10, was: <Distribution>k__BackingField
        public object _parsedDsn; // 0x30B90F10
        public object _beforeSendTransaction; // 0x30B90F10
        public object _maxCacheItems; // 0x30B90F10
        public object _decompressionMethods; // 0x30B90F10, was: <DecompressionMethods>k__Backi
        public object _sendClientReports; // 0x30B90F10, was: <SendClientReports>k__BackingF
        public object _configureClient; // 0x30B90F10, was: <ConfigureClient>k__BackingFie
        public object _diagnosticLogger; // 0x30B90F10
        public object _cacheDirectoryPath; // 0x30B90F10, was: <CacheDirectoryPath>k__Backing
        public object _failedRequestTargets; // 0x30B90F10
        public object _initCacheFlushTimeout; // 0x30B90F10, was: <InitCacheFlushTimeout>k__Back
        public object _profilesSampleRate; // 0x30B90F10
        public object _transactionProfilerFactory; // 0x30B90F10, was: <TransactionProfilerFactory>k_
        public object _maxAttachmentSize; // 0x30B90F10, was: <MaxAttachmentSize>k__BackingF
        public object _autoSessionTracking; // 0x30B90F10, was: <AutoSessionTracking>k__Backin
        public object _instrumenter; // 0x30B90F10, was: <Instrumenter>k__BackingField
        public object _experimentalMetrics; // 0x30B90F10, was: <ExperimentalMetrics>k__Backin
        public object _settingLocator; // 0x30B90F10, was: <SettingLocator>k__BackingFiel
        public object Z; // 0x3024ED20

        // ── Original Methods ──
        public void get_ScopeStackContainer(){} // RVA: 0x7ffaa89357c0
        public void set_ScopeStackContainer(){} // RVA: 0x7ffaa8998e80
        public void get_InstallationId(){} // RVA: 0x7ffaae55e880
        public void get_IsGlobalModeEnabled(){} // RVA: 0x7ffaae55e8d0
        public void set_IsGlobalModeEnabled(){} // RVA: 0x7ffaae55ea00
        public void get_ScopeObserver(){} // RVA: 0x7ffaa8bfcc80
        public void set_ScopeObserver(){} // RVA: 0x7ffaa8960890
        public void get_EnableScopeSync(){} // RVA: 0x7ffaa8bfcc70
        public void set_EnableScopeSync(){} // RVA: 0x7ffaa8bfbbe0
        public void get_Transport(){} // RVA: 0x7ffaa89af740
        public void set_Transport(){} // RVA: 0x7ffaa895a200
        public void get_ClientReportRecorder(){} // RVA: 0x7ffaae55ea50
        public void set_ClientReportRecorder(){} // RVA: 0x7ffaae55eaa0
        public void get_SentryStackTraceFactory(){} // RVA: 0x7ffaae55ec80
        public void set_SentryStackTraceFactory(){} // RVA: 0x7ffaae55ecd0
        public void get_SentryVersion(){} // RVA: 0x7ffaa905bf10
        public void get_ExceptionProcessors(){} // RVA: 0x7ffaa89d0370
        public void set_ExceptionProcessors(){} // RVA: 0x7ffaa89d0380
        public void get_TransactionProcessors(){} // RVA: 0x7ffaa89add50
        public void set_TransactionProcessors(){} // RVA: 0x7ffaa89add60
        public void get_EventProcessors(){} // RVA: 0x7ffaa89fa590
        public void set_EventProcessors(){} // RVA: 0x7ffaa89fa5a0
        public void get_EventProcessorsProviders(){} // RVA: 0x7ffaa8af68f0
        public void set_EventProcessorsProviders(){} // RVA: 0x7ffaa8af19e0
        public void get_TransactionProcessorsProviders(){} // RVA: 0x7ffaa8d1a3b0
        public void set_TransactionProcessorsProviders(){} // RVA: 0x7ffaa8efece0
        public void get_ExceptionProcessorsProviders(){} // RVA: 0x7ffaa8971010
        public void set_ExceptionProcessorsProviders(){} // RVA: 0x7ffaa8f7b010
        public void get_Integrations(){} // RVA: 0x7ffaae55eeb0
        public void get_ExceptionFilters(){} // RVA: 0x7ffaa8f75d20
        public void set_ExceptionFilters(){} // RVA: 0x7ffaa8f7b0d0
        public void get_TagFilters(){} // RVA: 0x7ffaa8f78170
        public void set_TagFilters(){} // RVA: 0x7ffaa8f7b130
        public void get_BackgroundWorker(){} // RVA: 0x7ffaa8f74720
        public void set_BackgroundWorker(){} // RVA: 0x7ffaa8d71dc0
        public void get_SentryHttpClientFactory(){} // RVA: 0x7ffaa899d040
        public void set_SentryHttpClientFactory(){} // RVA: 0x7ffaa899d050
        public void get_SentryScopeStateProcessor(){} // RVA: 0x7ffaa899d0b0
        public void set_SentryScopeStateProcessor(){} // RVA: 0x7ffaa899d0c0
        public void get_InAppExclude(){} // RVA: 0x7ffaa899d120
        public void set_InAppExclude(){} // RVA: 0x7ffaa899d130
        public void get_InAppInclude(){} // RVA: 0x7ffaa8a8a460
        public void set_InAppInclude(){} // RVA: 0x7ffaa8a8a470
        public void get_SendDefaultPii(){} // RVA: 0x7ffaa8dfbd60
        public void set_SendDefaultPii(){} // RVA: 0x7ffaa9d744d0
        public void get_IsEnvironmentUser(){} // RVA: 0x7ffaae55f040
        public void set_IsEnvironmentUser(){} // RVA: 0x7ffaae55f050
        public void get_ServerName(){} // RVA: 0x7ffaa8f6dbf0
        public void set_ServerName(){} // RVA: 0x7ffaa89b38a0
        public void get_AttachStacktrace(){} // RVA: 0x7ffaa8a5df80
        public void set_AttachStacktrace(){} // RVA: 0x7ffaa8a5df90
        public void get_MaxBreadcrumbs(){} // RVA: 0x7ffaaa1ddec0
        public void set_MaxBreadcrumbs(){} // RVA: 0x7ffaac1204b0
        public void get_SampleRate(){} // RVA: 0x7ffaa89b3970
        public void set_SampleRate(){} // RVA: 0x7ffaae55f060
        public void get_Release(){} // RVA: 0x7ffaa899d2a0
        public void set_Release(){} // RVA: 0x7ffaa899d2b0
        public void get_Distribution(){} // RVA: 0x7ffaa8d57210
        public void set_Distribution(){} // RVA: 0x7ffaa8ecd8e0
        public void get_Environment(){} // RVA: 0x7ffaa8f205f0
        public void set_Environment(){} // RVA: 0x7ffaa8f20bd0
        public void get_Dsn(){} // RVA: 0x7ffaa9102670
        public void set_Dsn(){} // RVA: 0x7ffaae55f150
        public void get_ParsedDsn(){} // RVA: 0x7ffaae55f220
        public void IsSentryRequest(){} // RVA: 0x7ffaae55f470
        public void IsSentryRequest(){} // RVA: 0x7ffaae55f470
        public void get_BeforeSendInternal(){} // RVA: 0x7ffaa8b68c40
        public void get_BeforeSendTransactionInternal(){} // RVA: 0x7ffaa8f78450
        public void get_BeforeBreadcrumbInternal(){} // RVA: 0x7ffaa8f7aa40
        public void get_MaxQueueItems(){} // RVA: 0x7ffaa96cb0d0
        public void set_MaxQueueItems(){} // RVA: 0x7ffaae55fa60
        public void get_MaxCacheItems(){} // RVA: 0x7ffaae2e8440
        public void set_MaxCacheItems(){} // RVA: 0x7ffaae55fb20
        public void get_ShutdownTimeout(){} // RVA: 0x7ffaa899d5f0
        public void set_ShutdownTimeout(){} // RVA: 0x7ffaae55fbe0
        public void get_FlushTimeout(){} // RVA: 0x7ffaa899d660
        public void set_FlushTimeout(){} // RVA: 0x7ffaae4551b0
        public void get_DecompressionMethods(){} // RVA: 0x7ffaa96c7250
        public void set_DecompressionMethods(){} // RVA: 0x7ffaa96cb1b0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7ffaae55fbf0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7ffaae55fc00
        public void get_RequestBodyCompressionBuffered(){} // RVA: 0x7ffaae55fc10
        public void set_RequestBodyCompressionBuffered(){} // RVA: 0x7ffaae55fc20
        public void get_SendClientReports(){} // RVA: 0x7ffaa975e380
        public void set_SendClientReports(){} // RVA: 0x7ffaa9759b80
        public void get_HttpProxy(){} // RVA: 0x7ffaa8dde460
        public void set_HttpProxy(){} // RVA: 0x7ffaa8dde9b0
        public void get_CreateHttpMessageHandler(){} // RVA: 0x7ffaa8f70c30
        public void set_CreateHttpMessageHandler(){} // RVA: 0x7ffaa93e3af0
        public void get_ConfigureClient(){} // RVA: 0x7ffaa8d916d0
        public void set_ConfigureClient(){} // RVA: 0x7ffaa93f45e0
        public void get_Debug(){} // RVA: 0x7ffaae55fc30
        public void set_Debug(){} // RVA: 0x7ffaae55fc40
        public void get_DiagnosticLevel(){} // RVA: 0x7ffaae55fc50
        public void set_DiagnosticLevel(){} // RVA: 0x7ffaae55fc60
        public void get_DiagnosticLogger(){} // RVA: 0x7ffaae55fc70
        public void set_DiagnosticLogger(){} // RVA: 0x7ffaae55fc90
        public void get_ReportAssembliesMode(){} // RVA: 0x7ffaa8dd3a80
        public void set_ReportAssembliesMode(){} // RVA: 0x7ffaae55fdd0
        public void get_DeduplicateMode(){} // RVA: 0x7ffaae4356f0
        public void set_DeduplicateMode(){} // RVA: 0x7ffaae55fde0
        public void get_CacheDirectoryPath(){} // RVA: 0x7ffaa8f77bc0
        public void set_CacheDirectoryPath(){} // RVA: 0x7ffaa93f5420
        public void get_CaptureFailedRequests(){} // RVA: 0x7ffaae55fdf0
        public void set_CaptureFailedRequests(){} // RVA: 0x7ffaae55fe00
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7ffaa8f74750
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7ffaa93e77a0
        public void get_FailedRequestTargets(){} // RVA: 0x7ffaae55fe10
        public void set_FailedRequestTargets(){} // RVA: 0x7ffaae55fe60
        public void get_FileSystem(){} // RVA: 0x7ffaae55ff90
        public void set_FileSystem(){} // RVA: 0x7ffaa93d9af0
        public void get_DisableFileWrite(){} // RVA: 0x7ffaae560050
        public void set_DisableFileWrite(){} // RVA: 0x7ffaae560060
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7ffaa8f73670
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7ffaae560070
        public void get_DefaultTags(){} // RVA: 0x7ffaae560080
        public void set_DefaultTags(){} // RVA: 0x7ffaa8933e30
        public void get_IsPerformanceMonitoringEnabled(){} // RVA: 0x7ffaae560140
        public void get_IsProfilingEnabled(){} // RVA: 0x7ffaae560240
        public void get_EnableTracing(){} // RVA: 0x7ffaae560380
        public void set_EnableTracing(){} // RVA: 0x7ffaae560390
        public void get_TracesSampleRate(){} // RVA: 0x7ffaae5603a0
        public void set_TracesSampleRate(){} // RVA: 0x7ffaae5603b0
        public void get_ProfilesSampleRate(){} // RVA: 0x7ffaae5604c0
        public void set_ProfilesSampleRate(){} // RVA: 0x7ffaae5604d0
        public void get_TracesSampler(){} // RVA: 0x7ffaa8f6fa20
        public void set_TracesSampler(){} // RVA: 0x7ffaa8f774b0
        public void get_TracePropagationTargets(){} // RVA: 0x7ffaa8f74aa0
        public void set_TracePropagationTargets(){} // RVA: 0x7ffaae5605e0
        public void get_TransactionProfilerFactory(){} // RVA: 0x7ffaa8f7aa00
        public void set_TransactionProfilerFactory(){} // RVA: 0x7ffaa8f77dc0
        public void get_StackTraceMode(){} // RVA: 0x7ffaae560680
        public void set_StackTraceMode(){} // RVA: 0x7ffaae560880
        public void get_MaxAttachmentSize(){} // RVA: 0x7ffaa8f70430
        public void set_MaxAttachmentSize(){} // RVA: 0x7ffaae5608e0
        public void get_DetectStartupTime(){} // RVA: 0x7ffaae5608f0
        public void set_DetectStartupTime(){} // RVA: 0x7ffaae560900
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7ffaa8f75b00
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7ffaae560910
        public void get_AutoSessionTracking(){} // RVA: 0x7ffaae416450
        public void set_AutoSessionTracking(){} // RVA: 0x7ffaae416460
        public void get_UseAsyncFileIO(){} // RVA: 0x7ffaae416470
        public void set_UseAsyncFileIO(){} // RVA: 0x7ffaae416480
        public void get_CrashedLastRun(){} // RVA: 0x7ffaa8f6ff20
        public void set_CrashedLastRun(){} // RVA: 0x7ffaa93d64a0
        public void get_Instrumenter(){} // RVA: 0x7ffaae560920
        public void set_Instrumenter(){} // RVA: 0x7ffaae560930
        public void AddJsonConverter(){} // RVA: 0x7ffaae560940
        public void AddJsonSerializerContext(){} // RVA: 0x7ffaa8660d80
        public void get_JsonPreserveReferences(){} // RVA: 0x7ffaae5609e0
        public void set_JsonPreserveReferences(){} // RVA: 0x7ffaae560a80
        public void get_NetworkStatusListener(){} // RVA: 0x7ffaa93e4a80
        public void set_NetworkStatusListener(){} // RVA: 0x7ffaa93fd280
        public void get_AssemblyReader(){} // RVA: 0x7ffaa93e7730
        public void set_AssemblyReader(){} // RVA: 0x7ffaa93ea060
        public void get_ExperimentalMetrics(){} // RVA: 0x7ffaa93d0c60
        public void set_ExperimentalMetrics(){} // RVA: 0x7ffaa8d71d60
        public void get_SpotlightUrl(){} // RVA: 0x7ffaa9403680
        public void set_SpotlightUrl(){} // RVA: 0x7ffaa93e6540
        public void get_EnableSpotlight(){} // RVA: 0x7ffaae560b20
        public void set_EnableSpotlight(){} // RVA: 0x7ffaae560b30
        public void get_SettingLocator(){} // RVA: 0x7ffaa93d3fb0
        public void set_SettingLocator(){} // RVA: 0x7ffaa93d8b60
        public void get_InitNativeSdks(){} // RVA: 0x7ffaae560b40
        public void set_InitNativeSdks(){} // RVA: 0x7ffaae560b50
        public void get_PostInitCallbacks(){} // RVA: 0x7ffaa93d75e0
        public void set_PostInitCallbacks(){} // RVA: 0x7ffaa93e4cb0
        public void .ctor(){} // RVA: 0x7ffaae560b60
        public void AddIntegration(){} // RVA: 0x7ffaae562c80
        public void RemoveIntegration(){} // RVA: 0x7ffaa8660cc0
        public void AddExceptionFilter(){} // RVA: 0x7ffaae562d20
        public void RemoveExceptionFilter(){} // RVA: 0x7ffaa8660cc0
        public void AddExceptionFilterForType(){} // RVA: 0x7ffaa8660cc0
        public void AddInAppExclude(){} // RVA: 0x7ffaae562ff0
        public void AddInAppExclude(){} // RVA: 0x7ffaae562ff0
        public void AddInAppExcludeRegex(){} // RVA: 0x7ffaae5631a0
        public void AddInAppInclude(){} // RVA: 0x7ffaae563550
        public void AddInAppInclude(){} // RVA: 0x7ffaae563550
        public void AddInAppIncludeRegex(){} // RVA: 0x7ffaae563700
        public void AddExceptionProcessor(){} // RVA: 0x7ffaae563900
        public void AddExceptionProcessors(){} // RVA: 0x7ffaae563af0
        public void AddEventProcessor(){} // RVA: 0x7ffaae563cc0
        public void AddEventProcessors(){} // RVA: 0x7ffaae563eb0
        public void RemoveEventProcessor(){} // RVA: 0x7ffaa8660cc0
        public void AddEventProcessorProvider(){} // RVA: 0x7ffaae564080
        public void AddTransactionProcessor(){} // RVA: 0x7ffaae5640e0
        public void AddTransactionProcessors(){} // RVA: 0x7ffaae5641f0
        public void RemoveTransactionProcessor(){} // RVA: 0x7ffaa8660cc0
        public void AddTransactionProcessorProvider(){} // RVA: 0x7ffaae564360
        public void AddExceptionProcessorProvider(){} // RVA: 0x7ffaae564550
        public void UseStackTraceFactory(){} // RVA: 0x7ffaae564a00
        public void ApplyDefaultTags(){} // RVA: 0x7ffaae564c30
        public void DisableDuplicateEventDetection(){} // RVA: 0x7ffaae565030
        public void DisableAppDomainUnhandledExceptionCapture(){} // RVA: 0x7ffaae565070
        public void DisableUnobservedTaskExceptionCapture(){} // RVA: 0x7ffaae565080
        public void DisableAppDomainProcessExitFlush(){} // RVA: 0x7ffaae565090
        public void HasIntegration(){} // RVA: 0x7ffaa864a040
        public void RemoveDefaultIntegration(){} // RVA: 0x7ffaae5650a0
        public void TryGetDsnSpecificCacheDirectoryPath(){} // RVA: 0x7ffaae5652e0
        public void TryGetProcessSpecificCacheDirectoryPath(){} // RVA: 0x7ffaae565540
        public void <.ctor>b__346_0(){} // RVA: 0x7ffaae565550
        public void <.ctor>b__346_5(){} // RVA: 0x7ffaae565680
        public void <.ctor>b__346_1(){} // RVA: 0x7ffaae5656d0
        public void <.ctor>b__346_2(){} // RVA: 0x7ffaae565730
        public void <.ctor>g__SentryStackTraceFactoryAccessor|346_3(){} // RVA: 0x7ffaae55ec80
        public void <.ctor>b__346_6(){} // RVA: 0x7ffaae5657c0
        public void <.ctor>b__346_7(){} // RVA: 0x7ffaae565910
        public void <.ctor>b__346_8(){} // RVA: 0x7ffaae565b10
        public void <.ctor>b__346_10(){} // RVA: 0x7ffaae565c80
        public void <.ctor>b__346_11(){} // RVA: 0x7ffaae565dc0
        public void <.ctor>b__346_4(){} // RVA: 0x7ffaae565f30
        // ── Binary Analysis Named ──
        public void GetHttpClient(){} // RVA: 0x7ffaae55ef60
        public void SetBeforeSend(){} // RVA: 0x7ffaae55f5e0
        public void SetBeforeSend(){} // RVA: 0x7ffaae55f5e0
        public void SetBeforeSendTransaction(){} // RVA: 0x7ffaae55f760
        public void SetBeforeSendTransaction(){} // RVA: 0x7ffaae55f760
        public void SetBeforeBreadcrumb(){} // RVA: 0x7ffaae55f8e0
        public void SetBeforeBreadcrumb(){} // RVA: 0x7ffaae55f8e0
        public void GetAllEventProcessors(){} // RVA: 0x7ffaae5645b0
        public void GetAllTransactionProcessors(){} // RVA: 0x7ffaae564720
        public void GetAllExceptionProcessors(){} // RVA: 0x7ffaae564890
        public void SetupLogging(){} // RVA: 0x7ffaae5650b0
    }

    public class SentrySdk : Object
    {
        // ── Original Methods ──
        public void get_CurrentOptions(){} // RVA: 0x7ffaae568c80
        public void get_LastEventId(){} // RVA: 0x7ffaae568ce0
        public void InitHub(){} // RVA: 0x7ffaae568d80
        public void LogWarningIfProfilingMisconfigured(){} // RVA: 0x7ffaae569360
        public void Init(){} // RVA: 0x7ffaae569830
        public void Init(){} // RVA: 0x7ffaae569830
        public void Init(){} // RVA: 0x7ffaae569830
        public void Init(){} // RVA: 0x7ffaae569830
        public void UseHub(){} // RVA: 0x7ffaae5699d0
        public void Flush(){} // RVA: 0x7ffaae569c10
        public void Flush(){} // RVA: 0x7ffaae569c10
        public void FlushAsync(){} // RVA: 0x7ffaae569cd0
        public void FlushAsync(){} // RVA: 0x7ffaae569cd0
        public void Close(){} // RVA: 0x7ffaae569d60
        public void get_IsEnabled(){} // RVA: 0x7ffaae569ef0
        public void PushScope(){} // RVA: 0x7ffaae569f70
        public void PushScope(){} // RVA: 0x7ffaae569f70
        public void BindClient(){} // RVA: 0x7ffaae569ff0
        public void AddBreadcrumb(){} // RVA: 0x7ffaae56a1d0
        public void AddBreadcrumb(){} // RVA: 0x7ffaae56a1d0
        public void AddBreadcrumb(){} // RVA: 0x7ffaae56a1d0
        public void ConfigureScope(){} // RVA: 0x7ffaae56a240
        public void ConfigureScopeAsync(){} // RVA: 0x7ffaae56a2c0
        public void CaptureEnvelope(){} // RVA: 0x7ffaae56a340
        public void CaptureEvent(){} // RVA: 0x7ffaae56a560
        public void CaptureEvent(){} // RVA: 0x7ffaae56a560
        public void CaptureEvent(){} // RVA: 0x7ffaae56a560
        public void CaptureException(){} // RVA: 0x7ffaae56a6a0
        public void CaptureException(){} // RVA: 0x7ffaae56a6a0
        public void CaptureMessage(){} // RVA: 0x7ffaae56a880
        public void CaptureMessage(){} // RVA: 0x7ffaae56a880
        public void CaptureUserFeedback(){} // RVA: 0x7ffaae56aaf0
        public void CaptureUserFeedback(){} // RVA: 0x7ffaae56aaf0
        public void CaptureTransaction(){} // RVA: 0x7ffaae56ac70
        public void CaptureTransaction(){} // RVA: 0x7ffaae56ac70
        public void CaptureSession(){} // RVA: 0x7ffaae56ad10
        public void CaptureCheckIn(){} // RVA: 0x7ffaae56ad90
        public void StartTransaction(){} // RVA: 0x7ffaae56b230
        public void StartTransaction(){} // RVA: 0x7ffaae56b230
        public void StartTransaction(){} // RVA: 0x7ffaae56b230
        public void StartTransaction(){} // RVA: 0x7ffaae56b230
        public void StartTransaction(){} // RVA: 0x7ffaae56b230
        public void StartTransaction(){} // RVA: 0x7ffaae56b230
        public void BindException(){} // RVA: 0x7ffaae56b2c0
        public void ContinueTrace(){} // RVA: 0x7ffaae56b610
        public void ContinueTrace(){} // RVA: 0x7ffaae56b610
        public void get_Metrics(){} // RVA: 0x7ffaae56b750
        public void StartSession(){} // RVA: 0x7ffaae56b7d0
        public void EndSession(){} // RVA: 0x7ffaae56b850
        public void PauseSession(){} // RVA: 0x7ffaae56b8e0
        public void ResumeSession(){} // RVA: 0x7ffaae56b960
        public void CauseCrash(){} // RVA: 0x7ffaae56b9e0
        public void .cctor(){} // RVA: 0x7ffaae56c010
        // ── Binary Analysis Named ──
        public void GetSpan(){} // RVA: 0x7ffaae56b350
        public void GetTraceHeader(){} // RVA: 0x7ffaae56b3d0
        public void GetBaggage(){} // RVA: 0x7ffaae56b450
    }

    public class SentryValues`1 : Object
    {
        // ── Original Methods ──
        public void get_Values(){} // RVA: 0x7ffaa86491d0
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void WriteTo(){} // RVA: 0x7ffaa8669e70
    }

    public class SubstringOrRegexPattern : Object
    {
        public object _stringComparison; // 0x34DD35D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void op_Implicit(){} // RVA: 0x7ffaae57f610
        public void op_Implicit(){} // RVA: 0x7ffaae57f610
        public void ToString(){} // RVA: 0x7ffaae57f6a0
        public void Equals(){} // RVA: 0x7ffaae57f710
        public void get_Regex(){} // RVA: 0x7ffaa894d380
        public void IsMatch(){} // RVA: 0x7ffaae57f810
        public void TryParseRegex(){} // RVA: 0x7ffaae57f9b0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaaa3e25e0
    }

    public class SubstringOrRegexPatternExtensions : Object
    {
        // ── Original Methods ──
        public void ContainsMatch(){} // RVA: 0x7ffaae57fa60
        public void WithConfigBinding(){} // RVA: 0x7ffaa86492c0
    }

}