// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 30
// Methods: 343

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration : Object
    {
        public object Lock;
        public hXMultiplier.njected Watchdog; // 0x8
        public hXMultiplier.Field _monoBehaviour; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void Register(){} // RVA: 0x7FFD53F26F70
        public void .cctor(){} // RVA: 0x7FFD53F275B0
    }

    public class ErrorTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F83EFB0
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFD4E090A40
        public void remove_SceneLoaded(){} // RVA: 0x7FFD4E090A40
        public void add_SceneUnloaded(){} // RVA: 0x7FFD4E090A40
        public void remove_SceneUnloaded(){} // RVA: 0x7FFD4E090A40
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFD4E090A40
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFD4E090A40
    }

    public class ISentryUnityInfo
    {
        public object IL2CPP;
        public object Il2CppMethods;

        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFD4E079D00
        public void get_Il2CppMethods(){} // RVA: 0x7FFD4E078E90
        public void IsKnownPlatform(){} // RVA: 0x7FFD4E079D00
        public void IsLinux(){} // RVA: 0x7FFD4E079D00
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFD4E07C920
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFD4E07A310
        public void GetDebugImageType(){} // RVA: 0x7FFD4E087DE0
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0x7FFD4E079D00
    }

    public class Il2CppFree : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4FD9DFD0
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
        public void BeginInvoke(){} // RVA: 0x7FFD53F2BE40
        public void EndInvoke(){} // RVA: 0x7FFD4E342CB0
    }

    public class Il2CppGcHandleGetTarget : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD510D0690
        public void Invoke(){} // RVA: 0x7FFD4E39CC60
        public void BeginInvoke(){} // RVA: 0x7FFD53F2BC00
        public void EndInvoke(){} // RVA: 0x7FFD4FF78720
    }

    public class Il2CppMethods : Object
    {
        public hXMultiplier.pace_Injected Il2CppGcHandleGetTarget; // 0x10
        public hXMultiplier.hParticles_Injected Il2CppNativeStackTrace; // 0x18
        public hXMultiplier._dieWithParticles_Injected Il2CppFree; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E420E00
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x7FFD4E35C380
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x7FFD4E3447C0
        public void get_Il2CppFree(){} // RVA: 0x7FFD4E36F0C0
    }

    public class Il2CppNativeStackTrace : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53F2BC80
        public void Invoke(){} // RVA: 0x7FFD51080E20
        public void BeginInvoke(){} // RVA: 0x7FFD53F2BD50
        public void EndInvoke(){} // RVA: 0x7FFD52280C00
    }

    public class LogTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F83EFB0
    }

    public class SceneManagerAdapter : Object
    {
        public rectoryInformation<hXMultiplier.railModule,Type.UILayout> SceneLoaded; // 0x10
        public ileFullDirectoryInformation<hXMultiplier.railModule> SceneUnloaded; // 0x18
        public rectoryInformation<hXMultiplier.railModule,hXMultiplier.railModule> ActiveSceneChanged; // 0x20
        public hXMultiplier.ectsLifetime Instance;

        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFD53F28D10
        public void remove_SceneLoaded(){} // RVA: 0x7FFD53F28E10
        public void add_SceneUnloaded(){} // RVA: 0x7FFD53F28F10
        public void remove_SceneUnloaded(){} // RVA: 0x7FFD53F29010
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFD53F29110
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFD53F29210
        public void .ctor(){} // RVA: 0x7FFD53F29310
        public void .cctor(){} // RVA: 0x7FFD53F29650
        public void <.ctor>b__10_0(){} // RVA: 0x7FFD53F29700
        public void <.ctor>b__10_1(){} // RVA: 0x7FFD53F297F0
        public void <.ctor>b__10_2(){} // RVA: 0x7FFD53F298C0
    }

    public class ScriptableSentryUnityOptions : ScriptableObject
    {
        public string Enabled;
        public string Dsn;
        public bool CaptureInEditor; // 0x18
        public string EnableLogDebouncing; // 0x20
        public bool DebounceTimeLog; // 0x28
        public bool DebounceTimeWarning; // 0x29
        public int DebounceTimeError; // 0x2C
        public int TracesSampleRate; // 0x30
        public int AutoStartupTraces; // 0x34
        public double AutoSceneLoadTraces; // 0x38
        public bool AutoAwakeTraces; // 0x40
        public bool AutoSessionTracking; // 0x41
        public bool AutoSessionTrackingInterval; // 0x42
        public bool ReleaseOverride; // 0x43
        public int EnvironmentOverride; // 0x44
        public string AttachStacktrace; // 0x48
        public string AttachScreenshot; // 0x50
        public bool ScreenshotQuality; // 0x58
        public bool ScreenshotCompression; // 0x59
        public hXMultiplier.ces AttachViewHierarchy; // 0x5C
        public int MaxViewHierarchyRootObjects; // 0x60
        public bool MaxViewHierarchyObjectChildCount; // 0x64
        public int MaxViewHierarchyDepth; // 0x68
        public int BreadcrumbsForLogs; // 0x6C
        public int BreadcrumbsForWarnings; // 0x70
        public bool BreadcrumbsForAsserts; // 0x74
        public bool BreadcrumbsForErrors; // 0x75
        public bool BreadcrumbsForExceptions; // 0x76
        public bool MaxBreadcrumbs; // 0x77
        public bool ReportAssembliesMode; // 0x78
        public int SendDefaultPii; // 0x7C
        public RGBA_ETC2_SRGB.9__318_0 IsEnvironmentUser; // 0x80
        public bool EnableOfflineCaching; // 0x84
        public bool MaxCacheItems; // 0x85
        public bool InitCacheFlushTimeout; // 0x86
        public int SampleRate; // 0x88
        public int ShutdownTimeout; // 0x8C
        public float MaxQueueItems; // 0x90
        public int AnrDetectionEnabled; // 0x94
        public int AnrTimeout; // 0x98
        public bool CaptureFailedRequests; // 0x9C
        public int FailedRequestStatusCodes; // 0xA0
        public bool FilterBadGatewayExceptions; // 0xA4
        public URA.woDigitYearMax<int> FilterWebExceptions; // 0xA8
        public bool FilterSocketExceptions; // 0xB0
        public bool IosNativeSupportEnabled; // 0xB1
        public bool AndroidNativeSupportEnabled; // 0xB2
        public bool NdkIntegrationEnabled; // 0xB3
        public bool NdkScopeSyncEnabled; // 0xB4
        public bool PostGenerateGradleProjectCallbackOrder; // 0xB5
        public bool WindowsNativeSupportEnabled; // 0xB6
        public int MacosNativeSupportEnabled; // 0xB8
        public bool LinuxNativeSupportEnabled; // 0xBC
        public bool Il2CppLineNumberSupportEnabled; // 0xBD
        public bool RuntimeOptionsConfiguration; // 0xBE
        public bool BuildTimeOptionsConfiguration; // 0xBF
        public hXMultiplier.? OptionsConfiguration; // 0xC0
        public hXMultiplier.veZone>b__0 Debug; // 0xC8
        public hXMultiplier.ocalAddresses DebugOnlyInEditor; // 0xD0
        public bool DiagnosticLevel; // 0xD8
        public bool <DebugOnlyInEditor>k__BackingField; // 0xD9
        public RGBA_ETC2_SRGB.>d__23`1 <DiagnosticLevel>k__BackingField; // 0xDA

        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x7FFD53F30250
        public void get_Enabled(){} // RVA: 0x7FFD4E35C4E0
        public void set_Enabled(){} // RVA: 0x7FFD4E35C4F0
        public void get_Dsn(){} // RVA: 0x7FFD4E36F0C0
        public void set_Dsn(){} // RVA: 0x7FFD4E36F0D0
        public void get_CaptureInEditor(){} // RVA: 0x7FFD4E516BA0
        public void set_CaptureInEditor(){} // RVA: 0x7FFD4F044F40
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFD4EC8C550
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFD4F7D4D70
        public void get_DebounceTimeLog(){} // RVA: 0x7FFD4F0A91D0
        public void set_DebounceTimeLog(){} // RVA: 0x7FFD4F9D6490
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFD4E39CCD0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFD4E39CCE0
        public void get_DebounceTimeError(){} // RVA: 0x7FFD4EEFEDC0
        public void set_DebounceTimeError(){} // RVA: 0x7FFD4F58A6E0
        public void get_TracesSampleRate(){} // RVA: 0x7FFD51095050
        public void set_TracesSampleRate(){} // RVA: 0x7FFD51095060
        public void get_AutoStartupTraces(){} // RVA: 0x7FFD4E3FCC00
        public void set_AutoStartupTraces(){} // RVA: 0x7FFD4E3FCC10
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFD4E5F8A60
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFD4E5F8A10
        public void get_AutoAwakeTraces(){} // RVA: 0x7FFD4E5F90A0
        public void set_AutoAwakeTraces(){} // RVA: 0x7FFD4E5F9200
        public void get_AutoSessionTracking(){} // RVA: 0x7FFD4F3C0E90
        public void set_AutoSessionTracking(){} // RVA: 0x7FFD4F9C8320
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFD4E3E20A0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFD4E3E20B0
        public void get_ReleaseOverride(){} // RVA: 0x7FFD4E3BC730
        public void set_ReleaseOverride(){} // RVA: 0x7FFD4E3BC740
        public void get_EnvironmentOverride(){} // RVA: 0x7FFD4E3E20E0
        public void set_EnvironmentOverride(){} // RVA: 0x7FFD4E4994D0
        public void get_AttachStacktrace(){} // RVA: 0x7FFD4E55F600
        public void set_AttachStacktrace(){} // RVA: 0x7FFD4ECB2770
        public void get_AttachScreenshot(){} // RVA: 0x7FFD52BACF40
        public void set_AttachScreenshot(){} // RVA: 0x7FFD53BD5A20
        public void get_ScreenshotQuality(){} // RVA: 0x7FFD4E55CBA0
        public void set_ScreenshotQuality(){} // RVA: 0x7FFD4EA4EB40
        public void get_ScreenshotCompression(){} // RVA: 0x7FFD4E558C20
        public void set_ScreenshotCompression(){} // RVA: 0x7FFD4E558C10
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFD4F365FE0
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFD4FBDAB40
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFD4FBDAB50
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFD4FBDAB60
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFD4FBDAB70
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFD4FBDAB80
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFD4EFB9E80
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFD4E4D6520
        public void get_BreadcrumbsForLogs(){} // RVA: 0x7FFD4EFED8B0
        public void set_BreadcrumbsForLogs(){} // RVA: 0x7FFD535E5400
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x7FFD4F025B90
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x7FFD53F302D0
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x7FFD4F023700
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x7FFD53F302E0
        public void get_BreadcrumbsForErrors(){} // RVA: 0x7FFD53F302F0
        public void set_BreadcrumbsForErrors(){} // RVA: 0x7FFD53F30300
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x7FFD4E7EE5C0
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x7FFD4F140B50
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFD4F9B8F70
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFD53E00310
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFD4E9929C0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFD4E992BF0
        public void get_SendDefaultPii(){} // RVA: 0x7FFD4E420CE0
        public void set_SendDefaultPii(){} // RVA: 0x7FFD4E420CF0
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFD4F00C620
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFD53F30310
        public void get_EnableOfflineCaching(){} // RVA: 0x7FFD4F35C7F0
        public void set_EnableOfflineCaching(){} // RVA: 0x7FFD53F30320
        public void get_MaxCacheItems(){} // RVA: 0x7FFD4EC0E8C0
        public void set_MaxCacheItems(){} // RVA: 0x7FFD4EC19DE0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFD51376E80
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFD519C0990
        public void get_SampleRate(){} // RVA: 0x7FFD4E3A9540
        public void set_SampleRate(){} // RVA: 0x7FFD4E3A9550
        public void get_ShutdownTimeout(){} // RVA: 0x7FFD4E640670
        public void set_ShutdownTimeout(){} // RVA: 0x7FFD4E84B670
        public void get_MaxQueueItems(){} // RVA: 0x7FFD4FCBE530
        public void set_MaxQueueItems(){} // RVA: 0x7FFD4FCBE540
        public void get_AnrDetectionEnabled(){} // RVA: 0x7FFD53F30330
        public void set_AnrDetectionEnabled(){} // RVA: 0x7FFD535D7590
        public void get_AnrTimeout(){} // RVA: 0x7FFD4FCBE510
        public void set_AnrTimeout(){} // RVA: 0x7FFD4FCBE550
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFD4E565120
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFD4E55EEF0
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFD4E96B1A0
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFD4E76B370
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFD4F6071E0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFD4F606D30
        public void get_FilterWebExceptions(){} // RVA: 0x7FFD519594B0
        public void set_FilterWebExceptions(){} // RVA: 0x7FFD519594C0
        public void get_FilterSocketExceptions(){} // RVA: 0x7FFD53D5FD30
        public void set_FilterSocketExceptions(){} // RVA: 0x7FFD53D5FD40
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFD53D5FD50
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFD53D5FD60
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFD53D5FD70
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFD53D5FD80
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFD53F30340
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFD53F30350
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFD53F30360
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFD53F30370
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFD4F73B350
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFD4F73A220
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFD53CE71A0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFD53CE71B0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFD53F30380
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFD53F30390
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFD53F303A0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFD53F303B0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFD53F303C0
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFD53F303D0
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x7FFD4E3AC120
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x7FFD4E3AC130
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFD4E499460
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFD4E499470
        public void get_OptionsConfiguration(){} // RVA: 0x7FFD4E45E100
        public void set_OptionsConfiguration(){} // RVA: 0x7FFD4E45E110
        public void get_Debug(){} // RVA: 0x7FFD4F1DD9E0
        public void set_Debug(){} // RVA: 0x7FFD53CE7210
        public void get_DebugOnlyInEditor(){} // RVA: 0x7FFD53F303E0
        public void set_DebugOnlyInEditor(){} // RVA: 0x7FFD53F303F0
        public void get_DiagnosticLevel(){} // RVA: 0x7FFD53F30400
        public void set_DiagnosticLevel(){} // RVA: 0x7FFD53F30410
        public void LoadSentryUnityOptions(){} // RVA: 0x7FFD53F30420
        public void ToSentryUnityOptions(){} // RVA: 0x7FFD53F304A0
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x7FFD53F31240
        public void HandleExceptionFilter(){} // RVA: 0x7FFD53F314A0
        public void ShouldDebug(){} // RVA: 0x7FFD53F31560
        public void .ctor(){} // RVA: 0x7FFD53F31580
    }

    public class SentryBuildTimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD4E099B30
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SentryCliOptions : ScriptableObject
    {
        public object UploadSymbols;
        public object UploadDevelopmentSymbols;
        public object UploadSources;
        public object UrlOverride;
        public object Auth;
        public object Organization;
        public object Project;
        public object IgnoreCliErrors;
        public object CliOptionsConfiguration;

        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0x7FFD4E35C4E0
        public void set_UploadSymbols(){} // RVA: 0x7FFD4E35C4F0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x7FFD4E648D50
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x7FFD4E935120
        public void get_UploadSources(){} // RVA: 0x7FFD4FA1A190
        public void set_UploadSources(){} // RVA: 0x7FFD4FA19AE0
        public void get_UrlOverride(){} // RVA: 0x7FFD4E36F0C0
        public void set_UrlOverride(){} // RVA: 0x7FFD4E36F0D0
        public void get_Auth(){} // RVA: 0x7FFD4E36F130
        public void set_Auth(){} // RVA: 0x7FFD4E342E90
        public void get_Organization(){} // RVA: 0x7FFD4E5F95E0
        public void set_Organization(){} // RVA: 0x7FFD4E36F890
        public void get_Project(){} // RVA: 0x7FFD4E5F0140
        public void set_Project(){} // RVA: 0x7FFD4E5F0C20
        public void get_IgnoreCliErrors(){} // RVA: 0x7FFD4E3FCC00
        public void set_IgnoreCliErrors(){} // RVA: 0x7FFD4E3FCC10
        public void get_CliOptionsConfiguration(){} // RVA: 0x7FFD4E3BC730
        public void set_CliOptionsConfiguration(){} // RVA: 0x7FFD4E3BC740
        public void GetConfigPath(){} // RVA: 0x7FFD53F31BA0
        public void MissingFieldWarning(){} // RVA: 0x7FFD53F31C20
        public void IsValid(){} // RVA: 0x7FFD53F31CE0
        public void .ctor(){} // RVA: 0x7FFD53F31E70
    }

    public class SentryCliOptionsConfiguration : ScriptableObject
    {
        public string Template;

        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFD53F31E80
        public void Configure(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void .cctor(){} // RVA: 0x7FFD53F31EE0
    }

    public class SentryInitialization : Object
    {
        public RGBA_ETC2_SRGB.waitWithCancellationAsync>d__4`1 InitSpan;
        public RGBA_ETC2_SRGB.waitWithCancellationAsync>d__4`1 SubSystemRegistrationSpan; // 0x8

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD53645E00
    }

    public class SentryIntegrations : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD53646E30
    }

    public class SentryMonoBehaviour : MonoBehaviour
    {
        public hXMultiplier.Field Instance;
        public ÎÌÍÏÏÌÍÏ Application; // 0x20
        public ÎÌÍÏÏÌÍÏ ApplicationPausing; // 0x28
        public bool _isRunning; // 0x30
        public eaMod.DNS.Model.? _application; // 0x38

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD53F31F90
        public void StartAwakeSpan(){} // RVA: 0x7FFD53F321B0
        public void FinishAwakeSpan(){} // RVA: 0x7FFD53F32350
        public void add_ApplicationResuming(){} // RVA: 0x7FFD53F323D0
        public void remove_ApplicationResuming(){} // RVA: 0x7FFD53F324C0
        public void add_ApplicationPausing(){} // RVA: 0x7FFD53F325B0
        public void remove_ApplicationPausing(){} // RVA: 0x7FFD53F326A0
        public void get_Application(){} // RVA: 0x7FFD53F32790
        public void set_Application(){} // RVA: 0x7FFD4E5F0C20
        public void UpdatePauseStatus(){} // RVA: 0x7FFD53F32850
        public void OnApplicationPause(){} // RVA: 0x7FFD53F32850
        public void OnApplicationFocus(){} // RVA: 0x7FFD53F32890
        public void OnApplicationQuit(){} // RVA: 0x7FFD53F328D0
        public void Awake(){} // RVA: 0x7FFD53F32970
        public void .ctor(){} // RVA: 0x7FFD4E3F5710
    }

    public class SentryOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFD53F32A40
        public void Configure(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
        public void .cctor(){} // RVA: 0x7FFD53F32AA0
    }

    public class SentryRuntimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFD4E090A40
        public void .ctor(){} // RVA: 0x7FFD4E54F5F0
    }

    public class SentryUnityInfo : Object
    {
        public hXMultiplier._lifetime_Injected IL2CPP; // 0x10

        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFD4E426850
        public void get_Il2CppMethods(){} // RVA: 0x7FFD4E35C380
        public void SanitizeDebugId(){} // RVA: 0x7FFD53646420
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x7FFD53646490
        public void il2cpp_gchandle_get_target(){} // RVA: 0x7FFD53646490
        public void il2cpp_free(){} // RVA: 0x7FFD536464A0
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x7FFD536464B0
        public void il2cpp_native_stack_trace(){} // RVA: 0x7FFD536466E0
        public void IsKnownPlatform(){} // RVA: 0x7FFD536466F0
        public void IsLinux(){} // RVA: 0x7FFD53646790
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFD53646820
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFD536468C0
        public void GetDebugImageType(){} // RVA: 0x7FFD536468E0
        public void .ctor(){} // RVA: 0x7FFD536469B0
    }

    public class SentryUnityOptions : SentryOptions
    {
        public string Enabled;
        public bool AutoStartupTraces; // 0x288
        public bool AutoSceneLoadTraces; // 0x289
        public bool CaptureInEditor; // 0x28A
        public bool EnableLogDebouncing; // 0x28B
        public bool DebounceTimeLog; // 0x28C
        public ializable.GetObjectData DebounceTimeWarning; // 0x290
        public ializable.GetObjectData DebounceTimeError; // 0x298
        public ializable.GetObjectData RequestBodyCompressionLevel; // 0x2A0
        public hXMultiplier.e AttachScreenshot; // 0x2A8
        public bool AttachViewHierarchy; // 0x2AC
        public bool MaxViewHierarchyRootObjects; // 0x2AD
        public int MaxViewHierarchyObjectChildCount; // 0x2B0
        public int MaxViewHierarchyDepth; // 0x2B4
        public int ScreenshotQuality; // 0x2B8
        public hXMultiplier.ces ScreenshotCompression; // 0x2BC
        public int AddBreadcrumbsForLogType; // 0x2C0
        public URA.DateTime<?,bool> AnrTimeout; // 0x2C8
        public ializable.GetObjectData FilterBadGatewayExceptions; // 0x2D0
        public bool IosNativeSupportEnabled; // 0x2D8
        public bool AndroidNativeSupportEnabled; // 0x2D9
        public bool NdkIntegrationEnabled; // 0x2DA
        public bool NdkScopeSyncEnabled; // 0x2DB
        public bool WindowsNativeSupportEnabled; // 0x2DC
        public bool MacosNativeSupportEnabled; // 0x2DD
        public bool LinuxNativeSupportEnabled; // 0x2DE
        public bool Il2CppLineNumberSupportEnabled; // 0x2DF
        public bool PerformanceAutoInstrumentationEnabled; // 0x2E0
        public bool StackTraceMode; // 0x2E1
        public RGBA_ETC2_SRGB.aitAsync>d__5`3 DefaultUserId; // 0x2E4
        public string NativeContextWriter; // 0x2E8
        public bool NativeSupportCloseCallback; // 0x2F0
        public hXMultiplier.r>b__346_7 SdkIntegrationNames; // 0x2F8
        public ÎÌÍÏÏÌÍÏ <NativeSupportCloseCallback>k__BackingField; // 0x300
        public URA.woDigitYearMax<string> <SdkIntegrationNames>k__BackingField; // 0x308

        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFD4F559B80
        public void set_Enabled(){} // RVA: 0x7FFD53F32E00
        public void get_AutoStartupTraces(){} // RVA: 0x7FFD53F32E10
        public void set_AutoStartupTraces(){} // RVA: 0x7FFD53F32E20
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFD53F32E30
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFD53F32E40
        public void get_CaptureInEditor(){} // RVA: 0x7FFD53F32E50
        public void set_CaptureInEditor(){} // RVA: 0x7FFD53F32E60
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFD53F32E70
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFD53F32E80
        public void get_DebounceTimeLog(){} // RVA: 0x7FFD4EDE6830
        public void set_DebounceTimeLog(){} // RVA: 0x7FFD53F32E90
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFD4EDCE8B0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFD53F32EA0
        public void get_DebounceTimeError(){} // RVA: 0x7FFD4EDEF020
        public void set_DebounceTimeError(){} // RVA: 0x7FFD53F32EB0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFD53F32EC0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFD53F32ED0
        public void get_AttachScreenshot(){} // RVA: 0x7FFD53F32EF0
        public void set_AttachScreenshot(){} // RVA: 0x7FFD53F32F00
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFD53F32F10
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFD53F32F20
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFD53F32F30
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFD53F32F40
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFD53F32F50
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFD53F32F60
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFD53F32F70
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFD53F32F80
        public void get_ScreenshotQuality(){} // RVA: 0x7FFD53F32F90
        public void set_ScreenshotQuality(){} // RVA: 0x7FFD53F32FA0
        public void get_ScreenshotCompression(){} // RVA: 0x7FFD53F32FB0
        public void set_ScreenshotCompression(){} // RVA: 0x7FFD53F32FC0
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x7FFD4EDDDC80
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x7FFD4EDD8FB0
        public void get_AnrTimeout(){} // RVA: 0x7FFD4EDE8FB0
        public void set_AnrTimeout(){} // RVA: 0x7FFD53F32FD0
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFD53F32FE0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFD53F32FF0
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFD53F33000
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFD53F33010
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFD53F33020
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFD53F33030
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFD53F33040
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFD53F33050
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFD53F33060
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFD53F33070
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFD53F33080
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFD53F33090
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFD53F330A0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFD53F330B0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFD53F330C0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFD53F330D0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFD53F330E0
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFD53F330F0
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFD53F33100
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFD53F33110
        public void get_StackTraceMode(){} // RVA: 0x7FFD53F33120
        public void set_StackTraceMode(){} // RVA: 0x7FFD53F33130
        public void get_DefaultUserId(){} // RVA: 0x7FFD4EDD2540
        public void set_DefaultUserId(){} // RVA: 0x7FFD53F33140
        public void get_NativeContextWriter(){} // RVA: 0x7FFD4EDE8A80
        public void set_NativeContextWriter(){} // RVA: 0x7FFD4EDCE920
        public void get_NativeSupportCloseCallback(){} // RVA: 0x7FFD4E3AC1F0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x7FFD4E3AC200
        public void get_SdkIntegrationNames(){} // RVA: 0x7FFD4EDCD170
        public void set_SdkIntegrationNames(){} // RVA: 0x7FFD4EDDF770
        public void .ctor(){} // RVA: 0x7FFD53F33340 | overloaded x3
        public void ToString(){} // RVA: 0x7FFD53F340F0
    }

    public class StartupTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFD53646F60
        public void AfterAssembliesLoaded(){} // RVA: 0x7FFD53647040
        public void BeforeSplashScreen(){} // RVA: 0x7FFD53647270
        public void BeforeSceneLoad(){} // RVA: 0x7FFD536474A0
        public void AfterSceneLoad(){} // RVA: 0x7FFD536476D0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class TimeDebounceBase : Object
    {
        public ializable.GetObjectData Now; // 0x10
        public aphy<ntent> _barrierOffset; // 0x18

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFD53F38050
        public void Debounced(){} // RVA: 0x7FFD53F38100
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class UnityEventProcessor : Object
    {
        public hXMultiplier.ssageReceived _sentryOptions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void Process(){} // RVA: 0x7FFD53F38280 | overloaded x2
        public void SetEventContext(){} // RVA: 0x7FFD53F382F0
        public void PopulateDevice(){} // RVA: 0x7FFD53F384E0
        public void PopulateSdkIntegrations(){} // RVA: 0x7FFD53F38730
    }

    public class UnityIl2CppEventExceptionProcessor : Object
    {
        public hXMultiplier.ssageReceived Options;
        public hXMultiplier._ribbonCount UnityInfo; // 0x8
        public hXMultiplier._lifetime_Injected _il2CppMethods; // 0x10
        public dle<URA.woDigitYearMax<et_light>> DebugImagesSorted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53F23880
        public void Process(){} // RVA: 0x7FFD53F23B70
        public void NormalizeUuid(){} // RVA: 0x7FFD53F24F50
        public void FindDebugImageContainingAddress(){} // RVA: 0x7FFD53F25000
        public void EnumerateChainedExceptions(){} // RVA: 0x7FFD53F25170
        public void GetNativeStackTrace(){} // RVA: 0x7FFD53F25280
        public void .cctor(){} // RVA: 0x7FFD53F256A0
    }

    public class UnityLogger : Object
    {
        public string LogTag;
        public RGBA_ETC2_SRGB.ionAsync>d__5`3 _sentryOptions; // 0x10
        public Identifiers _logger; // 0x18

        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFD53F38930
        public void .ctor(){} // RVA: 0x7FFD53F38A70 | overloaded x2
        public void Log(){} // RVA: 0x7FFD53F38B80
        public void GetUnityLogType(){} // RVA: 0x7FFD53F38DD0
        public void ToString(){} // RVA: 0x7FFD53F38E00
    }

    public class UnityScopeIntegration : Object
    {
        public eaMod.DNS.Model.? _application; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E342E30
        public void Register(){} // RVA: 0x7FFD53F29D60
    }

    public class WarningTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F83EFB0
    }

    public class WebBackgroundWorker : Object
    {
        public hXMultiplier.Field QueuedItems; // 0x10
        public hXMultiplier.n _transport; // 0x18
        public int <QueuedItems>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53F3A1B0
        public void EnqueueEnvelope(){} // RVA: 0x7FFD53F3A340
        public void FlushAsync(){} // RVA: 0x7FFD53F3A480
        public void get_QueuedItems(){} // RVA: 0x7FFD4E4FBBE0
    }

}