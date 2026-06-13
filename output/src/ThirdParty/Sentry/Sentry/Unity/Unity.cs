// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 54
// Methods: 582

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Register(){} // RVA: 0x636FBB0
        public void .cctor(){} // RVA: 0x63701F0
    }

    public class AnrWatchDog
    {
        public int DetectionTimeoutMs; // 0x10

        // ── Methods ──
        public void add_OnApplicationNotResponding(){} // RVA: 0x63702C0
        public void remove_OnApplicationNotResponding(){} // RVA: 0x63703C0
        public void get_Paused(){} // RVA: 0x303450
        public void set_Paused(){} // RVA: 0x303460
        public void .ctor(){} // RVA: 0x63704C0
        public void Stop(){} // RVA: 0x25130
        public void Report(){} // RVA: 0x63709B0
        public void <.ctor>b__11_0(){} // RVA: 0x17B5330
        public void <.ctor>b__11_1(){} // RVA: 0x6205A0
        public void <.ctor>b__11_2(){} // RVA: 0x6370B50
    }

    public class AnrWatchDogMultiThreaded
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6370C10
        public void Stop(){} // RVA: 0x6370EE0
        public void UpdateUiStatus(){} // RVA: 0x6370F10
        public void Run(){} // RVA: 0x6370FB0
    }

    public class AnrWatchDogSingleThreaded
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63714D0
        public void Stop(){} // RVA: 0xB04010
        public void UpdateUiStatus(){} // RVA: 0x63716B0
    }

    public class ContextWriter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x636B570
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ErrorTimeDebounce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1967700
    }

    public class IEventCapture
    {
        // ── Methods ──
        public void Capture(){}
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x24B10
        public void remove_SceneLoaded(){} // RVA: 0x24B10
        public void add_SceneUnloaded(){} // RVA: 0x24B10
        public void remove_SceneUnloaded(){} // RVA: 0x24B10
        public void add_ActiveSceneChanged(){} // RVA: 0x24B10
        public void remove_ActiveSceneChanged(){} // RVA: 0x24B10
    }

    public class ISentrySystemInfo
    {
        public object get_SupportsVibration;
        public object get_SystemMemorySize;

        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0xCD60
        public void get_OperatingSystem(){} // RVA: 0xCD60
        public void get_ProcessorCount(){} // RVA: 0xCD60
        public void get_SupportsVibration(){} // RVA: 0xCC90
        public void get_DeviceType(){} // RVA: 0xCD60
        public void get_CpuDescription(){} // RVA: 0xCD60
        public void get_DeviceName(){} // RVA: 0xCD60
        public void get_DeviceUniqueIdentifier(){} // RVA: 0xCD60
        public void get_DeviceModel(){} // RVA: 0xCD60
        public void get_SystemMemorySize(){} // RVA: 0xCD60
        public void get_GraphicsDeviceId(){} // RVA: 0xCD60
        public void get_GraphicsDeviceName(){} // RVA: 0xCD60
        public void get_GraphicsDeviceVendorId(){} // RVA: 0xCD60
        public void get_GraphicsDeviceVendor(){} // RVA: 0xCD60
        public void get_GraphicsMemorySize(){} // RVA: 0xCD60
        public void get_GraphicsMultiThreaded(){} // RVA: 0xCD60
        public void get_NpotSupport(){} // RVA: 0xCD60
        public void get_GraphicsDeviceVersion(){} // RVA: 0xCD60
        public void get_GraphicsDeviceType(){} // RVA: 0xCD60
        public void get_MaxTextureSize(){} // RVA: 0xCD60
        public void get_SupportsDrawCallInstancing(){} // RVA: 0xCC90
        public void get_SupportsRayTracing(){} // RVA: 0xCC90
        public void get_SupportsComputeShaders(){} // RVA: 0xCC90
        public void get_SupportsGeometryShaders(){} // RVA: 0xCC90
        public void get_GraphicsShaderLevel(){} // RVA: 0xCD60
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0xCC90
        public void get_IsDebugBuild(){} // RVA: 0xCD60
        public void get_EditorVersion(){} // RVA: 0xCD60
        public void get_InstallMode(){} // RVA: 0xCD60
        public void get_TargetFrameRate(){} // RVA: 0xCD60
        public void get_CopyTextureSupport(){} // RVA: 0xCD60
        public void get_RenderingThreadingMode(){} // RVA: 0xCD60
        public void get_StartTime(){} // RVA: 0xCD60
    }

    public class ISentryUnityInfo
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0xDBE0
        public void get_Il2CppMethods(){} // RVA: 0xCD60
        public void IsKnownPlatform(){} // RVA: 0xDBE0
        public void IsLinux(){} // RVA: 0xDBE0
        public void IsNativeSupportEnabled(){} // RVA: 0x10840
        public void IsSupportedBySentryNative(){} // RVA: 0xE1F0
        public void GetDebugImageType(){} // RVA: 0x1BCC0
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0xDBE0
    }

    public class Il2CppFree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1E604F0
        public void Invoke(){} // RVA: 0x338C60
        public void BeginInvoke(){} // RVA: 0x6374A80
        public void EndInvoke(){} // RVA: 0x2DECB0
    }

    public class Il2CppGcHandleGetTarget
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x336B8D0
        public void Invoke(){} // RVA: 0x338C60
        public void BeginInvoke(){} // RVA: 0x6374840
        public void EndInvoke(){} // RVA: 0x20356F0
    }

    public class Il2CppMethods
    {
        public Sentry.Unity.Il2CppGcHandleGetTarget <Il2CppGcHandleGetTarget>k__BackingField; // 0x10
        public Sentry.Unity.Il2CppNativeStackTrace <Il2CppNativeStackTrace>k__BackingField; // 0x18
        public Sentry.Unity.Il2CppFree <Il2CppFree>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x3BCE00
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x2F8380
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x2E07C0
        public void get_Il2CppFree(){} // RVA: 0x30B0C0
    }

    public class Il2CppNativeStackTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63748C0
        public void Invoke(){} // RVA: 0x331B260
        public void BeginInvoke(){} // RVA: 0x6374990
        public void EndInvoke(){} // RVA: 0x45EE930
    }

    public class LogTimeDebounce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1967700
    }

    public class MainThreadData
    {
        public System.Nullable`1<int> <MainThreadId>k__BackingField;
        public string <OperatingSystem>k__BackingField; // 0x8
        public System.Nullable`1<int> <ProcessorCount>k__BackingField; // 0x10
        public System.Nullable`1<bool> <SupportsVibration>k__BackingField; // 0x18
        public string <DeviceType>k__BackingField; // 0x20
        public string <CpuDescription>k__BackingField; // 0x28
        public string <DeviceName>k__BackingField; // 0x30
        public string <DeviceUniqueIdentifier>k__BackingField; // 0x38
        public string <DeviceModel>k__BackingField; // 0x40
        public System.Nullable`1<int> <SystemMemorySize>k__BackingField; // 0x48
        public System.Nullable`1<int> <GraphicsDeviceId>k__BackingField; // 0x50
        public string <GraphicsDeviceName>k__BackingField; // 0x58
        public string <GraphicsDeviceVendorId>k__BackingField; // 0x60
        public string <GraphicsDeviceVendor>k__BackingField; // 0x68
        public System.Nullable`1<int> <GraphicsMemorySize>k__BackingField; // 0x70
        public System.Nullable`1<bool> <GraphicsMultiThreaded>k__BackingField; // 0x78
        public string <NpotSupport>k__BackingField; // 0x80
        public string <GraphicsDeviceVersion>k__BackingField; // 0x88
        public string <GraphicsDeviceType>k__BackingField; // 0x90
        public System.Nullable`1<int> <MaxTextureSize>k__BackingField; // 0x98
        public System.Nullable`1<bool> <SupportsDrawCallInstancing>k__BackingField; // 0xA0
        public System.Nullable`1<bool> <SupportsRayTracing>k__BackingField; // 0xA2
        public System.Nullable`1<bool> <SupportsComputeShaders>k__BackingField; // 0xA4
        public System.Nullable`1<bool> <SupportsGeometryShaders>k__BackingField; // 0xA6
        public System.Nullable`1<int> <GraphicsShaderLevel>k__BackingField; // 0xA8
        public System.Nullable`1<bool> <IsDebugBuild>k__BackingField; // 0xB0
        public string <EditorVersion>k__BackingField; // 0xB8
        public string <InstallMode>k__BackingField; // 0xC0
        public string <TargetFrameRate>k__BackingField; // 0xC8
        public string <CopyTextureSupport>k__BackingField; // 0xD0
        public string <RenderingThreadingMode>k__BackingField; // 0xD8
        public System.Nullable`1<System.DateTimeOffset> <StartTime>k__BackingField; // 0xE0
        public Sentry.Unity.ISentrySystemInfo <SentrySystemInfo>k__BackingField; // 0xF8

        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x6374B00
        public void set_MainThreadId(){} // RVA: 0x6374B40
        public void get_OperatingSystem(){} // RVA: 0x6374B90
        public void set_OperatingSystem(){} // RVA: 0x6374BD0
        public void get_ProcessorCount(){} // RVA: 0x6374C70
        public void set_ProcessorCount(){} // RVA: 0x6374CB0
        public void get_SupportsVibration(){} // RVA: 0x6374D00
        public void set_SupportsVibration(){} // RVA: 0x6374D40
        public void get_DeviceType(){} // RVA: 0x6374D90
        public void set_DeviceType(){} // RVA: 0x6374DD0
        public void get_CpuDescription(){} // RVA: 0x6374E70
        public void set_CpuDescription(){} // RVA: 0x6374EB0
        public void get_DeviceName(){} // RVA: 0x6374F50
        public void set_DeviceName(){} // RVA: 0x6374F90
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x6375030
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x6375070
        public void get_DeviceModel(){} // RVA: 0x6375110
        public void set_DeviceModel(){} // RVA: 0x6375150
        public void get_SystemMemorySize(){} // RVA: 0x63751F0
        public void set_SystemMemorySize(){} // RVA: 0x6375230
        public void get_GraphicsDeviceId(){} // RVA: 0x6375280
        public void set_GraphicsDeviceId(){} // RVA: 0x63752C0
        public void get_GraphicsDeviceName(){} // RVA: 0x6375310
        public void set_GraphicsDeviceName(){} // RVA: 0x6375350
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x63753F0
        public void set_GraphicsDeviceVendorId(){} // RVA: 0x6375430
        public void get_GraphicsDeviceVendor(){} // RVA: 0x63754D0
        public void set_GraphicsDeviceVendor(){} // RVA: 0x6375510
        public void get_GraphicsMemorySize(){} // RVA: 0x63755B0
        public void set_GraphicsMemorySize(){} // RVA: 0x63755F0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x6375640
        public void set_GraphicsMultiThreaded(){} // RVA: 0x6375680
        public void get_NpotSupport(){} // RVA: 0x63756D0
        public void set_NpotSupport(){} // RVA: 0x6375710
        public void get_GraphicsDeviceVersion(){} // RVA: 0x63757B0
        public void set_GraphicsDeviceVersion(){} // RVA: 0x63757F0
        public void get_GraphicsDeviceType(){} // RVA: 0x6375890
        public void set_GraphicsDeviceType(){} // RVA: 0x63758D0
        public void get_MaxTextureSize(){} // RVA: 0x6375970
        public void set_MaxTextureSize(){} // RVA: 0x63759B0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x6375A00
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x6375A40
        public void get_SupportsRayTracing(){} // RVA: 0x6375A90
        public void set_SupportsRayTracing(){} // RVA: 0x6375AD0
        public void get_SupportsComputeShaders(){} // RVA: 0x6375B20
        public void set_SupportsComputeShaders(){} // RVA: 0x6375B60
        public void get_SupportsGeometryShaders(){} // RVA: 0x6375BB0
        public void set_SupportsGeometryShaders(){} // RVA: 0x6375BF0
        public void get_GraphicsShaderLevel(){} // RVA: 0x6375C40
        public void set_GraphicsShaderLevel(){} // RVA: 0x6375C80
        public void get_IsDebugBuild(){} // RVA: 0x6375CD0
        public void set_IsDebugBuild(){} // RVA: 0x6375D10
        public void get_EditorVersion(){} // RVA: 0x6375D60
        public void set_EditorVersion(){} // RVA: 0x6375DA0
        public void get_InstallMode(){} // RVA: 0x6375E40
        public void set_InstallMode(){} // RVA: 0x6375E80
        public void get_TargetFrameRate(){} // RVA: 0x6375F20
        public void set_TargetFrameRate(){} // RVA: 0x6375F60
        public void get_CopyTextureSupport(){} // RVA: 0x6376000
        public void set_CopyTextureSupport(){} // RVA: 0x6376040
        public void get_RenderingThreadingMode(){} // RVA: 0x63760E0
        public void set_RenderingThreadingMode(){} // RVA: 0x6376120
        public void get_StartTime(){} // RVA: 0x63761C0
        public void set_StartTime(){} // RVA: 0x6376220
        public void IsMainThread(){} // RVA: 0x6376280
        public void get_SentrySystemInfo(){} // RVA: 0x63763A0
        public void set_SentrySystemInfo(){} // RVA: 0x63763E0
        public void CollectData(){} // RVA: 0x6376480
    }

    public class NativeStackTrace
    {
        public UIntPtr[] <Frames>k__BackingField; // 0x10
        public string <ImageUuid>k__BackingField; // 0x18
        public string <ImageName>k__BackingField; // 0x20

        // ── Methods ──
        public void get_Frames(){} // RVA: 0x2F8380
        public void set_Frames(){} // RVA: 0x2DEE30
        public void get_ImageUuid(){} // RVA: 0x2E07C0
        public void set_ImageUuid(){} // RVA: 0x343E80
        public void get_ImageName(){} // RVA: 0x30B0C0
        public void set_ImageName(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x636FB20
    }

    public class SceneAdapter
    {
        public string Version; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x1AD4690
        public void .ctor(){} // RVA: 0x100A2F0
    }

    public class SceneManagerAdapter
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x6371950
        public void remove_SceneLoaded(){} // RVA: 0x6371A50
        public void add_SceneUnloaded(){} // RVA: 0x6371B50
        public void remove_SceneUnloaded(){} // RVA: 0x6371C50
        public void add_ActiveSceneChanged(){} // RVA: 0x6371D50
        public void remove_ActiveSceneChanged(){} // RVA: 0x6371E50
        public void .ctor(){} // RVA: 0x6371F50
        public void .cctor(){} // RVA: 0x6372290
        public void <.ctor>b__10_0(){} // RVA: 0x6372340
        public void <.ctor>b__10_1(){} // RVA: 0x6372430
        public void <.ctor>b__10_2(){} // RVA: 0x6372500
    }

    public class SceneManagerTracingAPI
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5A909B0
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x5A90A50
    }

    public class SceneManagerTracingIntegration : kA
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x5A906C0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5CCCD00
        public void AddBreadcrumb(){} // RVA: 0x6377720
        public void AddBreadcrumbImpl(){} // RVA: 0x24B10
        public void SetExtra(){} // RVA: 0x6377930
        public void SetExtraImpl(){} // RVA: 0x2DC60
        public void SetTag(){} // RVA: 0x6377C70
        public void SetTagImpl(){} // RVA: 0x2DC60
        public void UnsetTag(){} // RVA: 0x6377E50
        public void UnsetTagImpl(){} // RVA: 0x24B10
        public void SetUser(){} // RVA: 0x6377FF0
        public void SetUserImpl(){} // RVA: 0x24B10
        public void UnsetUserImpl(){} // RVA: 0x24A50
    }

    public class ScreenshotAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x63782B0
    }

    public class ScreenshotAttachmentContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetStream(){} // RVA: 0x6378330
        public void GetTargetResolution(){} // RVA: 0x6378580
        public void CaptureScreenshot(){} // RVA: 0x63785A0
    }

    public class ScriptableSentryUnityOptions
    {
        public string ConfigRootFolder;
        public string ConfigName;
        public bool <Enabled>k__BackingField; // 0x18
        public string <Dsn>k__BackingField; // 0x20
        public bool <CaptureInEditor>k__BackingField; // 0x28
        public bool <EnableLogDebouncing>k__BackingField; // 0x29
        public int <DebounceTimeLog>k__BackingField; // 0x2C
        public int <DebounceTimeWarning>k__BackingField; // 0x30
        public int <DebounceTimeError>k__BackingField; // 0x34
        public double <TracesSampleRate>k__BackingField; // 0x38
        public bool <AutoStartupTraces>k__BackingField; // 0x40
        public bool <AutoSceneLoadTraces>k__BackingField; // 0x41
        public bool <AutoAwakeTraces>k__BackingField; // 0x42
        public bool <AutoSessionTracking>k__BackingField; // 0x43
        public int <AutoSessionTrackingInterval>k__BackingField; // 0x44
        public string <ReleaseOverride>k__BackingField; // 0x48
        public string <EnvironmentOverride>k__BackingField; // 0x50
        public bool <AttachStacktrace>k__BackingField; // 0x58
        public bool <AttachScreenshot>k__BackingField; // 0x59
        public 0x659AFAB8 <ScreenshotQuality>k__BackingField; // 0x5C
        public int <ScreenshotCompression>k__BackingField; // 0x60
        public bool <AttachViewHierarchy>k__BackingField; // 0x64
        public int <MaxViewHierarchyRootObjects>k__BackingField; // 0x68
        public int <MaxViewHierarchyObjectChildCount>k__BackingField; // 0x6C
        public int <MaxViewHierarchyDepth>k__BackingField; // 0x70
        public bool <BreadcrumbsForLogs>k__BackingField; // 0x74
        public bool <BreadcrumbsForWarnings>k__BackingField; // 0x75
        public bool <BreadcrumbsForAsserts>k__BackingField; // 0x76
        public bool <BreadcrumbsForErrors>k__BackingField; // 0x77
        public bool <BreadcrumbsForExceptions>k__BackingField; // 0x78
        public int <MaxBreadcrumbs>k__BackingField; // 0x7C
        public 0x658B4320 <ReportAssembliesMode>k__BackingField; // 0x80
        public bool <SendDefaultPii>k__BackingField; // 0x84
        public bool <IsEnvironmentUser>k__BackingField; // 0x85
        public bool <EnableOfflineCaching>k__BackingField; // 0x86
        public int <MaxCacheItems>k__BackingField; // 0x88
        public int <InitCacheFlushTimeout>k__BackingField; // 0x8C
        public float <SampleRate>k__BackingField; // 0x90
        public int <ShutdownTimeout>k__BackingField; // 0x94
        public int <MaxQueueItems>k__BackingField; // 0x98
        public bool <AnrDetectionEnabled>k__BackingField; // 0x9C
        public int <AnrTimeout>k__BackingField; // 0xA0
        public bool <CaptureFailedRequests>k__BackingField; // 0xA4
        public System.Collections.Generic.List`1<int> <FailedRequestStatusCodes>k__BackingField; // 0xA8
        public bool <FilterBadGatewayExceptions>k__BackingField; // 0xB0
        public bool <FilterWebExceptions>k__BackingField; // 0xB1
        public bool <FilterSocketExceptions>k__BackingField; // 0xB2
        public bool <IosNativeSupportEnabled>k__BackingField; // 0xB3
        public bool <AndroidNativeSupportEnabled>k__BackingField; // 0xB4
        public bool <NdkIntegrationEnabled>k__BackingField; // 0xB5
        public bool <NdkScopeSyncEnabled>k__BackingField; // 0xB6
        public int <PostGenerateGradleProjectCallbackOrder>k__BackingField; // 0xB8
        public bool <WindowsNativeSupportEnabled>k__BackingField; // 0xBC
        public bool <MacosNativeSupportEnabled>k__BackingField; // 0xBD
        public bool <LinuxNativeSupportEnabled>k__BackingField; // 0xBE
        public bool <Il2CppLineNumberSupportEnabled>k__BackingField; // 0xBF
        public Sentry.Unity.SentryRuntimeOptionsConfiguration <RuntimeOptionsConfiguration>k__BackingField; // 0xC0
        public Sentry.Unity.SentryBuildTimeOptionsConfiguration <BuildTimeOptionsConfiguration>k__BackingField; // 0xC8
        public Sentry.Unity.SentryOptionsConfiguration <OptionsConfiguration>k__BackingField; // 0xD0
        public bool <Debug>k__BackingField; // 0xD8

        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x6378E90
        public void get_Enabled(){} // RVA: 0x2F84E0
        public void set_Enabled(){} // RVA: 0x2F84F0
        public void get_Dsn(){} // RVA: 0x30B0C0
        public void set_Dsn(){} // RVA: 0x30B0D0
        public void get_CaptureInEditor(){} // RVA: 0x6E8A80
        public void set_CaptureInEditor(){} // RVA: 0x6E8B80
        public void get_EnableLogDebouncing(){} // RVA: 0xC36000
        public void set_EnableLogDebouncing(){} // RVA: 0x190AB20
        public void get_DebounceTimeLog(){} // RVA: 0x1209F00
        public void set_DebounceTimeLog(){} // RVA: 0x1AFCF60
        public void get_DebounceTimeWarning(){} // RVA: 0x338CD0
        public void set_DebounceTimeWarning(){} // RVA: 0x338CE0
        public void get_DebounceTimeError(){} // RVA: 0x4C6670
        public void set_DebounceTimeError(){} // RVA: 0x4C5F20
        public void get_TracesSampleRate(){} // RVA: 0x332F490
        public void set_TracesSampleRate(){} // RVA: 0x332F4A0
        public void get_AutoStartupTraces(){} // RVA: 0x398C00
        public void set_AutoStartupTraces(){} // RVA: 0x398C10
        public void get_AutoSceneLoadTraces(){} // RVA: 0x65EEC0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x65EEB0
        public void get_AutoAwakeTraces(){} // RVA: 0x65F560
        public void set_AutoAwakeTraces(){} // RVA: 0x65F1B0
        public void get_AutoSessionTracking(){} // RVA: 0x1514560
        public void set_AutoSessionTracking(){} // RVA: 0x1AF8C50
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x37E0A0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x37E0B0
        public void get_ReleaseOverride(){} // RVA: 0x358730
        public void set_ReleaseOverride(){} // RVA: 0x358740
        public void get_EnvironmentOverride(){} // RVA: 0x37E0E0
        public void set_EnvironmentOverride(){} // RVA: 0x4354D0
        public void get_AttachStacktrace(){} // RVA: 0x59FF30
        public void set_AttachStacktrace(){} // RVA: 0xC5F680
        public void get_AttachScreenshot(){} // RVA: 0x4FE4B90
        public void set_AttachScreenshot(){} // RVA: 0x601E3A0
        public void get_ScreenshotQuality(){} // RVA: 0x5A54D0
        public void set_ScreenshotQuality(){} // RVA: 0x9EACA0
        public void get_ScreenshotCompression(){} // RVA: 0x59CEC0
        public void set_ScreenshotCompression(){} // RVA: 0x59C530
        public void get_AttachViewHierarchy(){} // RVA: 0x1498640
        public void set_AttachViewHierarchy(){} // RVA: 0x1C91430
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x1C91440
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x1C91450
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x1C91460
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x1C91470
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x10E5CF0
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x475080
        public void get_BreadcrumbsForLogs(){} // RVA: 0x1120170
        public void set_BreadcrumbsForLogs(){} // RVA: 0x5A2DFE0
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x115F200
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x6378F10
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x1160850
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x6378F20
        public void get_BreadcrumbsForErrors(){} // RVA: 0x6378F30
        public void set_BreadcrumbsForErrors(){} // RVA: 0x6378F40
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x8A10E0
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x1688890
        public void get_MaxBreadcrumbs(){} // RVA: 0x1AE6E60
        public void set_MaxBreadcrumbs(){} // RVA: 0x6248F70
        public void get_ReportAssembliesMode(){} // RVA: 0xFC4570
        public void set_ReportAssembliesMode(){} // RVA: 0xFC4560
        public void get_SendDefaultPii(){} // RVA: 0x3BCCE0
        public void set_SendDefaultPii(){} // RVA: 0x3BCCF0
        public void get_IsEnvironmentUser(){} // RVA: 0x1132B00
        public void set_IsEnvironmentUser(){} // RVA: 0x6378F50
        public void get_EnableOfflineCaching(){} // RVA: 0x1490E50
        public void set_EnableOfflineCaching(){} // RVA: 0x6378F60
        public void get_MaxCacheItems(){} // RVA: 0xBB90C0
        public void set_MaxCacheItems(){} // RVA: 0xBB9E60
        public void get_InitCacheFlushTimeout(){} // RVA: 0x363A7C0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x3C7AFE0
        public void get_SampleRate(){} // RVA: 0x345540
        public void set_SampleRate(){} // RVA: 0x345550
        public void get_ShutdownTimeout(){} // RVA: 0x6AFD30
        public void set_ShutdownTimeout(){} // RVA: 0x8DF350
        public void get_MaxQueueItems(){} // RVA: 0x1D76570
        public void set_MaxQueueItems(){} // RVA: 0x1D76000
        public void get_AnrDetectionEnabled(){} // RVA: 0x6378F70
        public void set_AnrDetectionEnabled(){} // RVA: 0x5A20170
        public void get_AnrTimeout(){} // RVA: 0x1D76590
        public void set_AnrTimeout(){} // RVA: 0x1D76550
        public void get_CaptureFailedRequests(){} // RVA: 0x59FF40
        public void set_CaptureFailedRequests(){} // RVA: 0x5A6940
        public void get_FailedRequestStatusCodes(){} // RVA: 0xA1C130
        public void set_FailedRequestStatusCodes(){} // RVA: 0xAE5030
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x17323D0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x1735610
        public void get_FilterWebExceptions(){} // RVA: 0x3C49C40
        public void set_FilterWebExceptions(){} // RVA: 0x3C49C50
        public void get_FilterSocketExceptions(){} // RVA: 0x61A85F0
        public void set_FilterSocketExceptions(){} // RVA: 0x61A8600
        public void get_IosNativeSupportEnabled(){} // RVA: 0x61A8610
        public void set_IosNativeSupportEnabled(){} // RVA: 0x61A8620
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x61A8630
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x61A8640
        public void get_NdkIntegrationEnabled(){} // RVA: 0x6378F80
        public void set_NdkIntegrationEnabled(){} // RVA: 0x6378F90
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x6378FA0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x6378FB0
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x1896340
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x1896350
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x612FAC0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x612FAD0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x6378FC0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x6378FD0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x6378FE0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x6378FF0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x6379000
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x6379010
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x348120
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x348130
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x435460
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x435470
        public void get_OptionsConfiguration(){} // RVA: 0x3FA100
        public void set_OptionsConfiguration(){} // RVA: 0x3FA110
        public void get_Debug(){} // RVA: 0x12FD610
        public void set_Debug(){} // RVA: 0x612FB20
        public void get_DebugOnlyInEditor(){} // RVA: 0x6379020
        public void set_DebugOnlyInEditor(){} // RVA: 0x6379030
        public void get_DiagnosticLevel(){} // RVA: 0x6379040
        public void set_DiagnosticLevel(){} // RVA: 0x6379050
        public void LoadSentryUnityOptions(){} // RVA: 0x6379060
        public void ToSentryUnityOptions(){} // RVA: 0x63790E0
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x6379E80
        public void HandleExceptionFilter(){} // RVA: 0x637A0E0
        public void ShouldDebug(){} // RVA: 0x637A1A0
        public void .ctor(){} // RVA: 0x637A1C0
    }

    public class SentryBuildTimeOptionsConfiguration
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x2DC60
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SentryCliOptions
    {
        public string ShouldApplyVolume;
        public string ShouldApplyPitch;
        public bool ShouldApplyClip; // 0x18
        public bool ShouldApplyLoop; // 0x19
        public bool debugString; // 0x1A
        public string initialized; // 0x20
        public string <Auth>k__BackingField; // 0x28
        public string <Organization>k__BackingField; // 0x30
        public string <Project>k__BackingField; // 0x38

        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0x2F84E0
        public void set_UploadSymbols(){} // RVA: 0x2F84F0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x6B93D0
        public void set_UploadDevelopmentSymbols(){} // RVA: 0xF43D70
        public void get_UploadSources(){} // RVA: 0x1B98340
        public void set_UploadSources(){} // RVA: 0x1B98210
        public void get_UrlOverride(){} // RVA: 0x30B0C0
        public void set_UrlOverride(){} // RVA: 0x30B0D0
        public void get_Auth(){} // RVA: 0x30B130
        public void set_Auth(){} // RVA: 0x2DEE90
        public void get_Organization(){} // RVA: 0x6374D0
        public void set_Organization(){} // RVA: 0x30B890
        public void get_Project(){} // RVA: 0x4976A0
        public void set_Project(){} // RVA: 0x49B830
        public void get_IgnoreCliErrors(){} // RVA: 0x398C00
        public void set_IgnoreCliErrors(){} // RVA: 0x398C10
        public void get_CliOptionsConfiguration(){} // RVA: 0x358730
        public void set_CliOptionsConfiguration(){} // RVA: 0x358740
        public void GetConfigPath(){} // RVA: 0x637A7E0
        public void MissingFieldWarning(){} // RVA: 0x637A860
        public void IsValid(){} // RVA: 0x637A920
        public void .ctor(){} // RVA: 0x637AAB0
    }

    public class SentryCliOptionsConfiguration
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x637AAC0
        public void Configure(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x53BFB0
        public void .cctor(){} // RVA: 0x637AB20
    }

    public class SentryInitialization
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x5A8E9E0
    }

    public class SentryIntegrations
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x5A8FA10
    }

    public class SentryMonoBehaviour
    {
        public Sentry.Unity.SentryMonoBehaviour _instance;
        public System.Action ApplicationResuming; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x637ABD0
        public void StartAwakeSpan(){} // RVA: 0x637ADF0
        public void FinishAwakeSpan(){} // RVA: 0x637AF90
        public void add_ApplicationResuming(){} // RVA: 0x637B010
        public void remove_ApplicationResuming(){} // RVA: 0x637B100
        public void add_ApplicationPausing(){} // RVA: 0x637B1F0
        public void remove_ApplicationPausing(){} // RVA: 0x637B2E0
        public void get_Application(){} // RVA: 0x637B3D0
        public void set_Application(){} // RVA: 0x49B830
        public void UpdatePauseStatus(){} // RVA: 0x637B490
        public void OnApplicationPause(){} // RVA: 0x637B490
        public void OnApplicationFocus(){} // RVA: 0x637B4D0
        public void OnApplicationQuit(){} // RVA: 0x637B510
        public void Awake(){} // RVA: 0x637B5B0
        public void .ctor(){} // RVA: 0x391710
    }

    public class SentryOptionsConfiguration
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x637B680
        public void Configure(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x53BFB0
        public void .cctor(){} // RVA: 0x637B6E0
    }

    public class SentryRuntimeOptionsConfiguration
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x24B10
        public void .ctor(){} // RVA: 0x53BFB0
    }

    public class SentrySystemInfoAdapter
    {
        public Sentry.Unity.SentrySystemInfoAdapter Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_MainThreadId(){} // RVA: 0x637E830
        public void get_OperatingSystem(){} // RVA: 0x637E8D0
        public void get_ProcessorCount(){} // RVA: 0x637E920
        public void get_SupportsVibration(){} // RVA: 0x637E9A0
        public void get_DeviceType(){} // RVA: 0x637EA20
        public void get_CpuDescription(){} // RVA: 0x637EBC0
        public void get_DeviceName(){} // RVA: 0x637EC10
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x637EE70
        public void get_DeviceModel(){} // RVA: 0x637F010
        public void get_SystemMemorySize(){} // RVA: 0x637F1B0
        public void get_GraphicsDeviceId(){} // RVA: 0x637F230
        public void get_GraphicsDeviceName(){} // RVA: 0x637F2B0
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x637F300
        public void get_GraphicsDeviceVendor(){} // RVA: 0x637F4A0
        public void get_GraphicsMemorySize(){} // RVA: 0x637F4F0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x637F570
        public void get_NpotSupport(){} // RVA: 0x637F700
        public void get_GraphicsDeviceVersion(){} // RVA: 0x637F790
        public void get_GraphicsDeviceType(){} // RVA: 0x637F7E0
        public void get_MaxTextureSize(){} // RVA: 0x637F870
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x637F8F0
        public void get_SupportsRayTracing(){} // RVA: 0x637F970
        public void get_SupportsComputeShaders(){} // RVA: 0x637F9F0
        public void get_SupportsGeometryShaders(){} // RVA: 0x637FA70
        public void get_GraphicsShaderLevel(){} // RVA: 0x637FAF0
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x637FB70
        public void get_IsDebugBuild(){} // RVA: 0x637FBF0
        public void get_EditorVersion(){} // RVA: 0x637FD80
        public void get_InstallMode(){} // RVA: 0x637FE00
        public void get_TargetFrameRate(){} // RVA: 0x637FEC0
        public void get_CopyTextureSupport(){} // RVA: 0x6380060
        public void get_RenderingThreadingMode(){} // RVA: 0x6380200
        public void get_StartTime(){} // RVA: 0x63803A0
        public void .cctor(){} // RVA: 0x6380530
    }

    public class SentryUnity
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x637B880 | overloaded x2
        public void Close(){} // RVA: 0x637B980
    }

    public class SentryUnityInfo
    {
        public Sentry.Unity.Il2CppMethods _il2CppMethods; // 0x10

        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x3C2850
        public void get_Il2CppMethods(){} // RVA: 0x2F8380
        public void SanitizeDebugId(){} // RVA: 0x5A8F000
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x5A8F070
        public void il2cpp_gchandle_get_target(){} // RVA: 0x5A8F070
        public void il2cpp_free(){} // RVA: 0x5A8F080
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x5A8F090
        public void il2cpp_native_stack_trace(){} // RVA: 0x5A8F2C0
        public void IsKnownPlatform(){} // RVA: 0x5A8F2D0
        public void IsLinux(){} // RVA: 0x5A8F370
        public void IsNativeSupportEnabled(){} // RVA: 0x5A8F400
        public void IsSupportedBySentryNative(){} // RVA: 0x5A8F4A0
        public void GetDebugImageType(){} // RVA: 0x5A8F4C0
        public void .ctor(){} // RVA: 0x5A8F590
    }

    public class SentryUnityOptions
    {
        public string PackageName;
        public bool <Enabled>k__BackingField; // 0x288
        public bool <AutoStartupTraces>k__BackingField; // 0x289
        public bool <AutoSceneLoadTraces>k__BackingField; // 0x28A
        public bool <CaptureInEditor>k__BackingField; // 0x28B
        public bool <EnableLogDebouncing>k__BackingField; // 0x28C
        public System.TimeSpan <DebounceTimeLog>k__BackingField; // 0x290
        public System.TimeSpan <DebounceTimeWarning>k__BackingField; // 0x298
        public System.TimeSpan <DebounceTimeError>k__BackingField; // 0x2A0
        public 0x659AFA60 _requestBodyCompressionLevel; // 0x2A8
        public bool <AttachScreenshot>k__BackingField; // 0x2AC
        public bool <AttachViewHierarchy>k__BackingField; // 0x2AD
        public int <MaxViewHierarchyRootObjects>k__BackingField; // 0x2B0
        public int <MaxViewHierarchyObjectChildCount>k__BackingField; // 0x2B4
        public int <MaxViewHierarchyDepth>k__BackingField; // 0x2B8
        public 0x659AFAB8 <ScreenshotQuality>k__BackingField; // 0x2BC
        public int <ScreenshotCompression>k__BackingField; // 0x2C0
        public System.Collections.Generic.Dictionary`2<0x65895580,bool> <AddBreadcrumbsForLogType>k__BackingField; // 0x2C8
        public System.TimeSpan <AnrTimeout>k__BackingField; // 0x2D0
        public bool <FilterBadGatewayExceptions>k__BackingField; // 0x2D8
        public bool <IosNativeSupportEnabled>k__BackingField; // 0x2D9
        public bool <AndroidNativeSupportEnabled>k__BackingField; // 0x2DA
        public bool <NdkIntegrationEnabled>k__BackingField; // 0x2DB
        public bool <NdkScopeSyncEnabled>k__BackingField; // 0x2DC
        public bool <WindowsNativeSupportEnabled>k__BackingField; // 0x2DD
        public bool <MacosNativeSupportEnabled>k__BackingField; // 0x2DE
        public bool <LinuxNativeSupportEnabled>k__BackingField; // 0x2DF
        public bool <Il2CppLineNumberSupportEnabled>k__BackingField; // 0x2E0
        public bool <PerformanceAutoInstrumentationEnabled>k__BackingField; // 0x2E1
        public 0x658B6210 <StackTraceMode>k__BackingField; // 0x2E4
        public string _defaultUserId; // 0x2E8
        public bool MultiThreading; // 0x2F0
        public Sentry.Unity.ContextWriter <NativeContextWriter>k__BackingField; // 0x2F8

        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x637BA40
        public void set_Enabled(){} // RVA: 0x637BA50
        public void get_AutoStartupTraces(){} // RVA: 0x637BA60
        public void set_AutoStartupTraces(){} // RVA: 0x637BA70
        public void get_AutoSceneLoadTraces(){} // RVA: 0x637BA80
        public void set_AutoSceneLoadTraces(){} // RVA: 0x637BA90
        public void get_CaptureInEditor(){} // RVA: 0x637BAA0
        public void set_CaptureInEditor(){} // RVA: 0x637BAB0
        public void get_EnableLogDebouncing(){} // RVA: 0x637BAC0
        public void set_EnableLogDebouncing(){} // RVA: 0x637BAD0
        public void get_DebounceTimeLog(){} // RVA: 0xD9AA90
        public void set_DebounceTimeLog(){} // RVA: 0x637BAE0
        public void get_DebounceTimeWarning(){} // RVA: 0xDA0DF0
        public void set_DebounceTimeWarning(){} // RVA: 0x637BAF0
        public void get_DebounceTimeError(){} // RVA: 0xD94B80
        public void set_DebounceTimeError(){} // RVA: 0x637BB00
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x637BB10
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x637BB20
        public void get_AttachScreenshot(){} // RVA: 0x637BB40
        public void set_AttachScreenshot(){} // RVA: 0x637BB50
        public void get_AttachViewHierarchy(){} // RVA: 0x637BB60
        public void set_AttachViewHierarchy(){} // RVA: 0x637BB70
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x637BB80
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x637BB90
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x637BBA0
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x637BBB0
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x637BBC0
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x637BBD0
        public void get_ScreenshotQuality(){} // RVA: 0x637BBE0
        public void set_ScreenshotQuality(){} // RVA: 0x637BBF0
        public void get_ScreenshotCompression(){} // RVA: 0x637BC00
        public void set_ScreenshotCompression(){} // RVA: 0x637BC10
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0xDA8080
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0xDB4D00
        public void get_AnrTimeout(){} // RVA: 0xD9E220
        public void set_AnrTimeout(){} // RVA: 0x637BC20
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x637BC30
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x637BC40
        public void get_IosNativeSupportEnabled(){} // RVA: 0x637BC50
        public void set_IosNativeSupportEnabled(){} // RVA: 0x637BC60
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x637BC70
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x637BC80
        public void get_NdkIntegrationEnabled(){} // RVA: 0x637BC90
        public void set_NdkIntegrationEnabled(){} // RVA: 0x637BCA0
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x637BCB0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x637BCC0
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x637BCD0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x637BCE0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x637BCF0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x637BD00
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x637BD10
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x637BD20
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x637BD30
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x637BD40
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x637BD50
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x637BD60
        public void get_StackTraceMode(){} // RVA: 0x637BD70
        public void set_StackTraceMode(){} // RVA: 0x637BD80
        public void get_DefaultUserId(){} // RVA: 0xDA1AE0
        public void set_DefaultUserId(){} // RVA: 0x637BD90
        public void get_NativeContextWriter(){} // RVA: 0xD9BC90
        public void set_NativeContextWriter(){} // RVA: 0xD9B860
        public void get_NativeSupportCloseCallback(){} // RVA: 0x3481F0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x348200
        public void get_SdkIntegrationNames(){} // RVA: 0xD85910
        public void set_SdkIntegrationNames(){} // RVA: 0xD893E0
        public void .ctor(){} // RVA: 0x637BF90 | overloaded x3
        public void ToString(){} // RVA: 0x637CD40
    }

    public class SentryUnityOptionsExtensions
    {
        // ── Methods ──
        public void ShouldInitializeSdk(){} // RVA: 0x637D030 | overloaded x2
        public void IsValid(){} // RVA: 0x637D210
        public void SetupLogging(){} // RVA: 0x637D2F0
        public void AddIl2CppExceptionProcessor(){} // RVA: 0x637D4E0
        public void DisableUnityApplicationLoggingIntegration(){} // RVA: 0x637D5E0
        public void DisableAnrIntegration(){} // RVA: 0x637D630
        public void DisableBadGatewayExceptionFilter(){} // RVA: 0x637D680
        public void DisableWebExceptionFilter(){} // RVA: 0x637D6D0
        public void DisableSocketExceptionFilter(){} // RVA: 0x637D720
    }

    public class SentryUnitySdk
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Init(){} // RVA: 0x637D770
        public void Close(){} // RVA: 0x637DD70
    }

    public class StartupTracingIntegration
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x5A8FB40
        public void AfterAssembliesLoaded(){} // RVA: 0x5A8FC20
        public void BeforeSplashScreen(){} // RVA: 0x5A8FE50
        public void BeforeSceneLoad(){} // RVA: 0x5A90080
        public void AfterSceneLoad(){} // RVA: 0x5A902B0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class TagValueNormalizer
    {
        // ── Methods ──
        public void ToTagValue(){} // RVA: 0x6381520
    }

    public class TimeDebounceBase
    {
        public System.TimeSpan DebounceOffset; // 0x10

        // ── Methods ──
        public void get_Now(){} // RVA: 0x6380CA0
        public void Debounced(){} // RVA: 0x6380D50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class UnityEventProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Process(){} // RVA: 0x6380ED0 | overloaded x2
        public void SetEventContext(){} // RVA: 0x6380F40
        public void PopulateDevice(){} // RVA: 0x6381130
        public void PopulateSdkIntegrations(){} // RVA: 0x6381380
    }

    public class UnityIl2CppEventExceptionProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x636C4C0
        public void Process(){} // RVA: 0x636C7B0
        public void NormalizeUuid(){} // RVA: 0x636DB90
        public void FindDebugImageContainingAddress(){} // RVA: 0x636DC40
        public void EnumerateChainedExceptions(){} // RVA: 0x636DDB0
        public void GetNativeStackTrace(){} // RVA: 0x636DEC0
        public void .cctor(){} // RVA: 0x636E2E0
    }

    public class UnityLogger : IsEnabled
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x6381580
        public void .ctor(){} // RVA: 0x63816C0 | overloaded x2
        public void Log(){} // RVA: 0x63817D0
        public void GetUnityLogType(){} // RVA: 0x6381A20
        public void ToString(){} // RVA: 0x6381A50
    }

    public class UnityScopeIntegration : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void Register(){} // RVA: 0x63729A0
    }

    public class UnityScopeUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xF19AE0
        public void ConfigureScope(){} // RVA: 0x6372B50
        public void PopulateSdk(){} // RVA: 0x6373200
        public void PopulateApp(){} // RVA: 0x63733E0
        public void PopulateOperatingSystem(){} // RVA: 0x6373540
        public void PopulateDevice(){} // RVA: 0x63735E0
        public void PopulateGpu(){} // RVA: 0x6373B40
        public void PopulateUnity(){} // RVA: 0x6374250
        public void PopulateTags(){} // RVA: 0x6374520
        public void PopulateUser(){} // RVA: 0x63747C0
    }

    public class UnitySdkInfo
    {
        public string <Version>k__BackingField;

        // ── Methods ──
        public void get_Version(){} // RVA: 0x6372690
        public void .cctor(){} // RVA: 0x63726F0
    }

    public class UnityViewHierarchyAttachmentContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DEE30
        public void GetStream(){} // RVA: 0x6381A90
        public void CaptureViewHierarchy(){} // RVA: 0x6381B60
        public void CreateViewHierarchy(){} // RVA: 0x6381D70
        public void CreateNode(){} // RVA: 0x6382190
    }

    public class UnityViewHierarchyNode
    {
        public string <Tag>k__BackingField; // 0x20
        public string <Position>k__BackingField; // 0x28
        public string <Rotation>k__BackingField; // 0x30
        public string <Scale>k__BackingField; // 0x38
        public System.Nullable`1<bool> <Active>k__BackingField; // 0x40
        public System.Collections.Generic.List`1<string> <Extras>k__BackingField; // 0x48

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x30B0C0
        public void set_Tag(){} // RVA: 0x30B0D0
        public void get_Position(){} // RVA: 0x30B130
        public void set_Position(){} // RVA: 0x2DEE90
        public void get_Rotation(){} // RVA: 0x6374D0
        public void set_Rotation(){} // RVA: 0x30B890
        public void get_Scale(){} // RVA: 0x4976A0
        public void set_Scale(){} // RVA: 0x49B830
        public void get_Active(){} // RVA: 0x44CB950
        public void set_Active(){} // RVA: 0x6382A00
        public void get_Extras(){} // RVA: 0x358730
        public void set_Extras(){} // RVA: 0x358740
        public void .ctor(){} // RVA: 0x343E80
        public void WriteAdditionalProperties(){} // RVA: 0x6382A10
    }

    public class UnityWebRequestTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6383170
        public void SendEnvelopeAsync(){} // RVA: 0x63831F0
        public void CreateWebRequest(){} // RVA: 0x63832F0
        public void GetResponse(){} // RVA: 0x6383890
    }

    public class WarningTimeDebounce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1967700
    }

    public class WebBackgroundWorker
    {
        public Sentry.Unity.SentryMonoBehaviour _behaviour; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6382E00
        public void EnqueueEnvelope(){} // RVA: 0x6382F90
        public void FlushAsync(){} // RVA: 0x63830D0
        public void get_QueuedItems(){} // RVA: 0x760030
    }

}