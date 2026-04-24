// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 30
// Methods: 343

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration : Object
    {
        public object _monoBehaviour; // 0x34DD1DC0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Register(){} // RVA: 0x7ffaae528170
        public void .cctor(){} // RVA: 0x7ffaae5287b0
    }

    public class ErrorTimeDebounce : TimeDebounceBase
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e463c0
    }

    public class ISceneManager
    {
        // ── Original Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7ffaa8660d80
        public void remove_SceneLoaded(){} // RVA: 0x7ffaa8660d80
        public void add_SceneUnloaded(){} // RVA: 0x7ffaa8660d80
        public void remove_SceneUnloaded(){} // RVA: 0x7ffaa8660d80
        public void add_ActiveSceneChanged(){} // RVA: 0x7ffaa8660d80
        public void remove_ActiveSceneChanged(){} // RVA: 0x7ffaa8660d80
    }

    public class ISentryUnityInfo
    {
        // ── Original Methods ──
        public void get_IL2CPP(){} // RVA: 0x7ffaa864a040
        public void get_Il2CppMethods(){} // RVA: 0x7ffaa86491d0
        public void IsKnownPlatform(){} // RVA: 0x7ffaa864a040
        public void IsLinux(){} // RVA: 0x7ffaa864a040
        public void IsNativeSupportEnabled(){} // RVA: 0x7ffaa864cc60
        public void IsSupportedBySentryNative(){} // RVA: 0x7ffaa864a650
        // ── Binary Analysis Named ──
        public void GetDebugImageType(){} // RVA: 0x7ffaa8658120
    }

    public class IUnityLogMessageDebounce
    {
        // ── Original Methods ──
        public void Debounced(){} // RVA: 0x7ffaa864a040
    }

    public class Il2CppFree : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaa385a50
        public void Invoke(){} // RVA: 0x7ffaa898dc60
        public void EndInvoke(){} // RVA: 0x7ffaa8933cb0
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaae52d040
    }

    public class Il2CppGcHandleGetTarget : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6b86c0
        public void Invoke(){} // RVA: 0x7ffaa898dc60
        public void EndInvoke(){} // RVA: 0x7ffaaa555350
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaae52ce00
    }

    public class Il2CppMethods : Object
    {
        public object _il2CppFree; // 0x34DAA1A0, was: <Il2CppFree>k__BackingField
        public object Il2CppGcHandleGetTarget; // 0x17000016

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8a11e00
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x7ffaa894d380
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x7ffaa89357c0
        public void get_Il2CppFree(){} // RVA: 0x7ffaa89600c0
    }

    public class Il2CppNativeStackTrace : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae52ce80
        public void Invoke(){} // RVA: 0x7ffaab668e50
        public void EndInvoke(){} // RVA: 0x7ffaac873a00
        // ── Binary Analysis Named ──
        public void BeginInvoke(){} // RVA: 0x7ffaae52cf50
    }

    public class LogTimeDebounce : TimeDebounceBase
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e463c0
    }

    public class SceneManagerAdapter : Object
    {
        public object ActiveSceneChanged; // 0x34DEBA60

        // ── Original Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7ffaae529f10
        public void remove_SceneLoaded(){} // RVA: 0x7ffaae52a010
        public void add_SceneUnloaded(){} // RVA: 0x7ffaae52a110
        public void remove_SceneUnloaded(){} // RVA: 0x7ffaae52a210
        public void add_ActiveSceneChanged(){} // RVA: 0x7ffaae52a310
        public void remove_ActiveSceneChanged(){} // RVA: 0x7ffaae52a410
        public void .ctor(){} // RVA: 0x7ffaae52a510
        public void .cctor(){} // RVA: 0x7ffaae52a850
        public void <.ctor>b__10_0(){} // RVA: 0x7ffaae52a900
        public void <.ctor>b__10_1(){} // RVA: 0x7ffaae52a9f0
        public void <.ctor>b__10_2(){} // RVA: 0x7ffaae52aac0
    }

    public class ScriptableSentryUnityOptions : ScriptableObject
    {
        public object _enabled; // 0x331EAC70, was: <Enabled>k__BackingField
        public object _enableLogDebouncing; // 0x331EAC70, was: <EnableLogDebouncing>k__Backin
        public object _debounceTimeError; // 0x331EAC70, was: <DebounceTimeError>k__BackingF
        public object _autoSceneLoadTraces; // 0x331EAC70, was: <AutoSceneLoadTraces>k__Backin
        public object _autoSessionTrackingInterval; // 0x331EAC70, was: <AutoSessionTrackingInterval>k
        public object _attachStacktrace; // 0x331EAC70, was: <AttachStacktrace>k__BackingFi
        public object _screenshotCompression; // 0x331EAC70, was: <ScreenshotCompression>k__Back
        public object _maxViewHierarchyObjectChildCount; // 0x331EAC70, was: <MaxViewHierarchyObjectChildCo
        public object _breadcrumbsForWarnings; // 0x331EAC70, was: <BreadcrumbsForWarnings>k__Bac
        public object _breadcrumbsForExceptions; // 0x331EAC70, was: <BreadcrumbsForExceptions>k__B
        public object _sendDefaultPii; // 0x331EAC70, was: <SendDefaultPii>k__BackingFiel
        public object _maxCacheItems; // 0x331EAC70, was: <MaxCacheItems>k__BackingField
        public object _shutdownTimeout; // 0x331EAC70, was: <ShutdownTimeout>k__BackingFie
        public object _anrTimeout; // 0x331EAC70, was: <AnrTimeout>k__BackingField
        public object _filterBadGatewayExceptions; // 0x331EAC70, was: <FilterBadGatewayExceptions>k_
        public object _iosNativeSupportEnabled; // 0x331EAC70, was: <IosNativeSupportEnabled>k__Ba
        public object _ndkScopeSyncEnabled; // 0x331EAC70, was: <NdkScopeSyncEnabled>k__Backin
        public object _macosNativeSupportEnabled; // 0x331EAC70, was: <MacosNativeSupportEnabled>k__
        public object _runtimeOptionsConfiguration; // 0x331EAC70, was: <RuntimeOptionsConfiguration>k
        public object _debug; // 0x331EAC70, was: <Debug>k__BackingField

        // ── Original Methods ──
        public void get_Enabled(){} // RVA: 0x7ffaa894d4e0
        public void set_Enabled(){} // RVA: 0x7ffaa894d4f0
        public void get_Dsn(){} // RVA: 0x7ffaa89600c0
        public void set_Dsn(){} // RVA: 0x7ffaa89600d0
        public void get_CaptureInEditor(){} // RVA: 0x7ffaa8b0edb0
        public void set_CaptureInEditor(){} // RVA: 0x7ffaa96574d0
        public void get_EnableLogDebouncing(){} // RVA: 0x7ffaa92971f0
        public void set_EnableLogDebouncing(){} // RVA: 0x7ffaa9dde1d0
        public void get_DebounceTimeLog(){} // RVA: 0x7ffaa96cc980
        public void set_DebounceTimeLog(){} // RVA: 0x7ffaa9fdb500
        public void get_DebounceTimeWarning(){} // RVA: 0x7ffaa898dcd0
        public void set_DebounceTimeWarning(){} // RVA: 0x7ffaa898dce0
        public void get_DebounceTimeError(){} // RVA: 0x7ffaa950c6d0
        public void set_DebounceTimeError(){} // RVA: 0x7ffaa9b8cba0
        public void get_TracesSampleRate(){} // RVA: 0x7ffaab67d080
        public void set_TracesSampleRate(){} // RVA: 0x7ffaab67d090
        public void get_AutoStartupTraces(){} // RVA: 0x7ffaa89edc00
        public void set_AutoStartupTraces(){} // RVA: 0x7ffaa89edc10
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7ffaa8bfb9f0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7ffaa8bfb120
        public void get_AutoAwakeTraces(){} // RVA: 0x7ffaa8bfb090
        public void set_AutoAwakeTraces(){} // RVA: 0x7ffaa8bfb660
        public void get_AutoSessionTracking(){} // RVA: 0x7ffaa99cb620
        public void set_AutoSessionTracking(){} // RVA: 0x7ffaa9fc91a0
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7ffaa89d30a0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7ffaa89d30b0
        public void get_ReleaseOverride(){} // RVA: 0x7ffaa89ad730
        public void set_ReleaseOverride(){} // RVA: 0x7ffaa89ad740
        public void get_EnvironmentOverride(){} // RVA: 0x7ffaa89d30e0
        public void set_EnvironmentOverride(){} // RVA: 0x7ffaa8a8a4d0
        public void get_AttachStacktrace(){} // RVA: 0x7ffaa8b6c110
        public void set_AttachStacktrace(){} // RVA: 0x7ffaa92bb760
        public void get_AttachScreenshot(){} // RVA: 0x7ffaad109aa0
        public void set_AttachScreenshot(){} // RVA: 0x7ffaae1d6c30
        public void get_ScreenshotQuality(){} // RVA: 0x7ffaa8b6e710
        public void set_ScreenshotQuality(){} // RVA: 0x7ffaa905bdd0
        public void get_ScreenshotCompression(){} // RVA: 0x7ffaa8b645f0
        public void set_ScreenshotCompression(){} // RVA: 0x7ffaa8b64600
        public void get_AttachViewHierarchy(){} // RVA: 0x7ffaa9970570
        public void set_AttachViewHierarchy(){} // RVA: 0x7ffaaa1c2a30
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7ffaaa1c2a40
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7ffaaa1c2a50
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7ffaaa1c2a60
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7ffaaa1c2a70
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7ffaa95c5a20
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7ffaa8ac7670
        public void get_BreadcrumbsForLogs(){} // RVA: 0x7ffaa95facb0
        public void set_BreadcrumbsForLogs(){} // RVA: 0x7ffaadbe65b0
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x7ffaa962c550
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x7ffaae5314d0
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x7ffaa9634c70
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x7ffaae5314e0
        public void get_BreadcrumbsForErrors(){} // RVA: 0x7ffaae5314f0
        public void set_BreadcrumbsForErrors(){} // RVA: 0x7ffaae531500
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x7ffaa8e00670
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x7ffaa97510e0
        public void get_MaxBreadcrumbs(){} // RVA: 0x7ffaa9fb8830
        public void set_MaxBreadcrumbs(){} // RVA: 0x7ffaae401520
        public void get_ReportAssembliesMode(){} // RVA: 0x7ffaa8fa2c90
        public void set_ReportAssembliesMode(){} // RVA: 0x7ffaa8fa3510
        public void get_SendDefaultPii(){} // RVA: 0x7ffaa8a11ce0
        public void set_SendDefaultPii(){} // RVA: 0x7ffaa8a11cf0
        public void get_IsEnvironmentUser(){} // RVA: 0x7ffaa961ab90
        public void set_IsEnvironmentUser(){} // RVA: 0x7ffaae531510
        public void get_EnableOfflineCaching(){} // RVA: 0x7ffaa9966660
        public void set_EnableOfflineCaching(){} // RVA: 0x7ffaae531520
        public void get_MaxCacheItems(){} // RVA: 0x7ffaa9221d50
        public void set_MaxCacheItems(){} // RVA: 0x7ffaa92217c0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7ffaab965cc0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7ffaabfb3540
        public void get_SampleRate(){} // RVA: 0x7ffaa899a540
        public void set_SampleRate(){} // RVA: 0x7ffaa899a550
        public void get_ShutdownTimeout(){} // RVA: 0x7ffaa8c4abd0
        public void set_ShutdownTimeout(){} // RVA: 0x7ffaa8e5e660
        public void get_MaxQueueItems(){} // RVA: 0x7ffaaa2a8330
        public void set_MaxQueueItems(){} // RVA: 0x7ffaaa2a8340
        public void get_AnrDetectionEnabled(){} // RVA: 0x7ffaae531530
        public void set_AnrDetectionEnabled(){} // RVA: 0x7ffaadbd8740
        public void get_AnrTimeout(){} // RVA: 0x7ffaaa2a7de0
        public void set_AnrTimeout(){} // RVA: 0x7ffaaa2a7dd0
        public void get_CaptureFailedRequests(){} // RVA: 0x7ffaa8b6f1e0
        public void set_CaptureFailedRequests(){} // RVA: 0x7ffaa8b70a80
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7ffaa8f74720
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7ffaa8d71dc0
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7ffaa9c06d20
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7ffaa9c096e0
        public void get_FilterWebExceptions(){} // RVA: 0x7ffaabf46960
        public void set_FilterWebExceptions(){} // RVA: 0x7ffaabf46970
        public void get_FilterSocketExceptions(){} // RVA: 0x7ffaae360f40
        public void set_FilterSocketExceptions(){} // RVA: 0x7ffaae360f50
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7ffaae360f60
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7ffaae360f70
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7ffaae360f80
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7ffaae360f90
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7ffaae531540
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7ffaae531550
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7ffaae531560
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7ffaae531570
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7ffaa9d66e50
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7ffaa9d66790
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7ffaae2e83b0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7ffaae2e83c0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7ffaae531580
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7ffaae531590
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7ffaae5315a0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7ffaae5315b0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7ffaae5315c0
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7ffaae5315d0
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x7ffaa899d120
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x7ffaa899d130
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x7ffaa8a8a460
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x7ffaa8a8a470
        public void get_OptionsConfiguration(){} // RVA: 0x7ffaa8a4f100
        public void set_OptionsConfiguration(){} // RVA: 0x7ffaa8a4f110
        public void get_Debug(){} // RVA: 0x7ffaa97ef160
        public void set_Debug(){} // RVA: 0x7ffaae2e8420
        public void get_DebugOnlyInEditor(){} // RVA: 0x7ffaae5315e0
        public void set_DebugOnlyInEditor(){} // RVA: 0x7ffaae5315f0
        public void get_DiagnosticLevel(){} // RVA: 0x7ffaae531600
        public void set_DiagnosticLevel(){} // RVA: 0x7ffaae531610
        public void LoadSentryUnityOptions(){} // RVA: 0x7ffaae531620
        public void ToSentryUnityOptions(){} // RVA: 0x7ffaae5316a0
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x7ffaae532440
        public void HandleExceptionFilter(){} // RVA: 0x7ffaae5326a0
        public void ShouldDebug(){} // RVA: 0x7ffaae532760
        public void .ctor(){} // RVA: 0x7ffaae532780
        // ── Binary Analysis Named ──
        public void GetConfigPath(){} // RVA: 0x7ffaae531450
    }

    public class SentryBuildTimeOptionsConfiguration : ScriptableObject
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaa8669e70
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SentryCliOptions : ScriptableObject
    {
        public object _uploadSymbols; // 0x33D20E30, was: <UploadSymbols>k__BackingField
        public object _urlOverride; // 0x33D20E30, was: <UrlOverride>k__BackingField
        public object _project; // 0x33D20E30, was: <Project>k__BackingField

        // ── Original Methods ──
        public void get_UploadSymbols(){} // RVA: 0x7ffaa894d4e0
        public void set_UploadSymbols(){} // RVA: 0x7ffaa894d4f0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x7ffaa8c53420
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x7ffaa8f41f20
        public void get_UploadSources(){} // RVA: 0x7ffaaa01a540
        public void set_UploadSources(){} // RVA: 0x7ffaaa01a550
        public void get_UrlOverride(){} // RVA: 0x7ffaa89600c0
        public void set_UrlOverride(){} // RVA: 0x7ffaa89600d0
        public void get_Auth(){} // RVA: 0x7ffaa8960130
        public void set_Auth(){} // RVA: 0x7ffaa8933e90
        public void get_Organization(){} // RVA: 0x7ffaa8bfcc80
        public void set_Organization(){} // RVA: 0x7ffaa8960890
        public void get_Project(){} // RVA: 0x7ffaa8bf45b0
        public void set_Project(){} // RVA: 0x7ffaa8bf45c0
        public void get_IgnoreCliErrors(){} // RVA: 0x7ffaa89edc00
        public void set_IgnoreCliErrors(){} // RVA: 0x7ffaa89edc10
        public void get_CliOptionsConfiguration(){} // RVA: 0x7ffaa89ad730
        public void set_CliOptionsConfiguration(){} // RVA: 0x7ffaa89ad740
        public void MissingFieldWarning(){} // RVA: 0x7ffaae532e20
        public void IsValid(){} // RVA: 0x7ffaae532ee0
        public void .ctor(){} // RVA: 0x7ffaae533070
        // ── Binary Analysis Named ──
        public void GetConfigPath(){} // RVA: 0x7ffaae532da0
    }

    public class SentryCliOptionsConfiguration : ScriptableObject
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        public void .cctor(){} // RVA: 0x7ffaae5330e0
        // ── Binary Analysis Named ──
        public void GetAssetPath(){} // RVA: 0x7ffaae533080
    }

    public class SentryInitialization : Object
    {
        // ── Original Methods ──
        public void Init(){} // RVA: 0x7ffaadc46fb0
    }

    public class SentryIntegrations : Object
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaadc47fe0
    }

    public class SentryMonoBehaviour : MonoBehaviour
    {
        public object ApplicationPausing; // 0x33203D90
        public object  	00;

        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaae533190
        public void StartAwakeSpan(){} // RVA: 0x7ffaae5333b0
        public void FinishAwakeSpan(){} // RVA: 0x7ffaae533550
        public void add_ApplicationResuming(){} // RVA: 0x7ffaae5335d0
        public void remove_ApplicationResuming(){} // RVA: 0x7ffaae5336c0
        public void add_ApplicationPausing(){} // RVA: 0x7ffaae5337b0
        public void remove_ApplicationPausing(){} // RVA: 0x7ffaae5338a0
        public void get_Application(){} // RVA: 0x7ffaae533990
        public void set_Application(){} // RVA: 0x7ffaa8bf45c0
        public void UpdatePauseStatus(){} // RVA: 0x7ffaae533a50
        public void OnApplicationPause(){} // RVA: 0x7ffaae533a50
        public void OnApplicationFocus(){} // RVA: 0x7ffaae533a90
        public void OnApplicationQuit(){} // RVA: 0x7ffaae533ad0
        public void Awake(){} // RVA: 0x7ffaae533b70
        public void .ctor(){} // RVA: 0x7ffaa89e6710
    }

    public class SentryOptionsConfiguration : ScriptableObject
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
        public void .cctor(){} // RVA: 0x7ffaae533ca0
        // ── Binary Analysis Named ──
        public void GetAssetPath(){} // RVA: 0x7ffaae533c40
    }

    public class SentryRuntimeOptionsConfiguration : ScriptableObject
    {
        // ── Original Methods ──
        public void Configure(){} // RVA: 0x7ffaa8660d80
        public void .ctor(){} // RVA: 0x7ffaa8b59ae0
    }

    public class SentryUnityInfo : Object
    {
        // ── Original Methods ──
        public void get_IL2CPP(){} // RVA: 0x7ffaa8a17850
        public void get_Il2CppMethods(){} // RVA: 0x7ffaa894d380
        public void SanitizeDebugId(){} // RVA: 0x7ffaadc475d0
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x7ffaadc47640
        public void il2cpp_gchandle_get_target(){} // RVA: 0x7ffaadc47640
        public void il2cpp_free(){} // RVA: 0x7ffaadc47650
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x7ffaadc47660
        public void il2cpp_native_stack_trace(){} // RVA: 0x7ffaadc47890
        public void IsKnownPlatform(){} // RVA: 0x7ffaadc478a0
        public void IsLinux(){} // RVA: 0x7ffaadc47940
        public void IsNativeSupportEnabled(){} // RVA: 0x7ffaadc479d0
        public void IsSupportedBySentryNative(){} // RVA: 0x7ffaadc47a70
        public void .ctor(){} // RVA: 0x7ffaadc47b60
        // ── Binary Analysis Named ──
        public void GetDebugImageType(){} // RVA: 0x7ffaadc47a90
    }

    public class SentryUnityOptions : SentryOptions
    {
        public object _autoStartupTraces; // 0x34DAB140, was: <AutoStartupTraces>k__BackingF
        public object _enableLogDebouncing; // 0x34DAB140, was: <EnableLogDebouncing>k__Backin
        public object _debounceTimeError; // 0x34DAB140, was: <DebounceTimeError>k__BackingF
        public object _attachViewHierarchy; // 0x34DAB140, was: <AttachViewHierarchy>k__Backin
        public object _maxViewHierarchyDepth; // 0x34DAB140, was: <MaxViewHierarchyDepth>k__Back
        public object _addBreadcrumbsForLogType; // 0x34DAB140, was: <AddBreadcrumbsForLogType>k__B
        public object _iosNativeSupportEnabled; // 0x34DAB140, was: <IosNativeSupportEnabled>k__Ba
        public object _ndkScopeSyncEnabled; // 0x34DAB140, was: <NdkScopeSyncEnabled>k__Backin
        public object _linuxNativeSupportEnabled; // 0x34DAB140, was: <LinuxNativeSupportEnabled>k__
        public object _stackTraceMode; // 0x34DAB140, was: <StackTraceMode>k__BackingFiel
        public object _nativeContextWriter; // 0x34DAB140, was: <NativeContextWriter>k__Backin

        // ── Original Methods ──
        public void get_Enabled(){} // RVA: 0x7ffaa9b4e2a0
        public void set_Enabled(){} // RVA: 0x7ffaae534000
        public void get_AutoStartupTraces(){} // RVA: 0x7ffaae534010
        public void set_AutoStartupTraces(){} // RVA: 0x7ffaae534020
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7ffaae534030
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7ffaae534040
        public void get_CaptureInEditor(){} // RVA: 0x7ffaae534050
        public void set_CaptureInEditor(){} // RVA: 0x7ffaae534060
        public void get_EnableLogDebouncing(){} // RVA: 0x7ffaae534070
        public void set_EnableLogDebouncing(){} // RVA: 0x7ffaae534080
        public void get_DebounceTimeLog(){} // RVA: 0x7ffaa93f1b80
        public void set_DebounceTimeLog(){} // RVA: 0x7ffaae534090
        public void get_DebounceTimeWarning(){} // RVA: 0x7ffaa93d5d60
        public void set_DebounceTimeWarning(){} // RVA: 0x7ffaae5340a0
        public void get_DebounceTimeError(){} // RVA: 0x7ffaa93ea130
        public void set_DebounceTimeError(){} // RVA: 0x7ffaae5340b0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7ffaae5340c0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7ffaae5340d0
        public void get_AttachScreenshot(){} // RVA: 0x7ffaae5340f0
        public void set_AttachScreenshot(){} // RVA: 0x7ffaae534100
        public void get_AttachViewHierarchy(){} // RVA: 0x7ffaae534110
        public void set_AttachViewHierarchy(){} // RVA: 0x7ffaae534120
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7ffaae534130
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7ffaae534140
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7ffaae534150
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7ffaae534160
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7ffaae534170
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7ffaae534180
        public void get_ScreenshotQuality(){} // RVA: 0x7ffaae534190
        public void set_ScreenshotQuality(){} // RVA: 0x7ffaae5341a0
        public void get_ScreenshotCompression(){} // RVA: 0x7ffaae5341b0
        public void set_ScreenshotCompression(){} // RVA: 0x7ffaae5341c0
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x7ffaa93d8f60
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x7ffaa93f1990
        public void get_AnrTimeout(){} // RVA: 0x7ffaa93feaa0
        public void set_AnrTimeout(){} // RVA: 0x7ffaae5341d0
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7ffaae5341e0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7ffaae5341f0
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7ffaae534200
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7ffaae534210
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7ffaae534220
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7ffaae534230
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7ffaae534240
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7ffaae534250
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7ffaae534260
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7ffaae534270
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7ffaae534280
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7ffaae534290
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7ffaae5342a0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7ffaae5342b0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7ffaae5342c0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7ffaae5342d0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7ffaae5342e0
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7ffaae5342f0
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7ffaae534300
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7ffaae534310
        public void get_StackTraceMode(){} // RVA: 0x7ffaae534320
        public void set_StackTraceMode(){} // RVA: 0x7ffaae534330
        public void get_DefaultUserId(){} // RVA: 0x7ffaa93f7740
        public void set_DefaultUserId(){} // RVA: 0x7ffaae534340
        public void get_NativeContextWriter(){} // RVA: 0x7ffaa93eacc0
        public void set_NativeContextWriter(){} // RVA: 0x7ffaa93f6000
        public void get_NativeSupportCloseCallback(){} // RVA: 0x7ffaa899d1f0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x7ffaa899d200
        public void get_SdkIntegrationNames(){} // RVA: 0x7ffaa93f62a0
        public void set_SdkIntegrationNames(){} // RVA: 0x7ffaa93f1110
        public void .ctor(){} // RVA: 0x7ffaae534540
        public void .ctor(){} // RVA: 0x7ffaae534540
        public void .ctor(){} // RVA: 0x7ffaae534540
        public void ToString(){} // RVA: 0x7ffaae5352f0
    }

    public class StartupTracingIntegration : Object
    {
        public object FirstSceneLoadSpan; // 0x351952E0
        public object Logger; // 0x351952E0
        public object System; // 0x3030C4D0

        // ── Original Methods ──
        public void Register(){} // RVA: 0x7ffaadc48110
        public void AfterAssembliesLoaded(){} // RVA: 0x7ffaadc481f0
        public void BeforeSplashScreen(){} // RVA: 0x7ffaadc48420
        public void BeforeSceneLoad(){} // RVA: 0x7ffaadc48650
        public void AfterSceneLoad(){} // RVA: 0x7ffaadc48880
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class TimeDebounceBase : Object
    {
        public object hasValue; // 0x3145EE08

        // ── Original Methods ──
        public void get_Now(){} // RVA: 0x7ffaae539250
        public void Debounced(){} // RVA: 0x7ffaae539300
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class UnityEventProcessor : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Process(){} // RVA: 0x7ffaae539480
        public void Process(){} // RVA: 0x7ffaae539480
        public void PopulateDevice(){} // RVA: 0x7ffaae5396e0
        public void PopulateSdkIntegrations(){} // RVA: 0x7ffaae539930
        // ── Binary Analysis Named ──
        public void SetEventContext(){} // RVA: 0x7ffaae5394f0
    }

    public class UnityIl2CppEventExceptionProcessor : Object
    {
        public object _il2CppMethods; // 0x34E50420
        public object  	00; // 0x34E50730

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae524a80
        public void Process(){} // RVA: 0x7ffaae524d70
        public void NormalizeUuid(){} // RVA: 0x7ffaae526150
        public void FindDebugImageContainingAddress(){} // RVA: 0x7ffaae526200
        public void EnumerateChainedExceptions(){} // RVA: 0x7ffaae526370
        public void .cctor(){} // RVA: 0x7ffaae5268a0
        // ── Binary Analysis Named ──
        public void GetNativeStackTrace(){} // RVA: 0x7ffaae526480
    }

    public class UnityLogger : Object
    {
        public object _logger; // 0x34DEBD80

        // ── Original Methods ──
        public void IsEnabled(){} // RVA: 0x7ffaae539b30
        public void .ctor(){} // RVA: 0x7ffaae539c70
        public void .ctor(){} // RVA: 0x7ffaae539c70
        public void Log(){} // RVA: 0x7ffaae539d80
        public void ToString(){} // RVA: 0x7ffaae53a000
        // ── Binary Analysis Named ──
        public void GetUnityLogType(){} // RVA: 0x7ffaae539fd0
    }

    public class UnityScopeIntegration : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Register(){} // RVA: 0x7ffaae52af60
    }

    public class WarningTimeDebounce : TimeDebounceBase
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9e463c0
    }

    public class WebBackgroundWorker : Object
    {
        public object _queuedItems; // 0x34E50C20, was: <QueuedItems>k__BackingField
        public object QueuedItems; // 0x170000EB

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae53b3b0
        public void EnqueueEnvelope(){} // RVA: 0x7ffaae53b540
        public void FlushAsync(){} // RVA: 0x7ffaae53b680
        public void get_QueuedItems(){} // RVA: 0x7ffaa8aeced0
    }

}