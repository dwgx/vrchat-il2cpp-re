// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 54
// Methods: 576

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Register(){} // RVA: 0x6DDCE70
        public void .cctor(){} // RVA: 0x6DDD620
    }

    public class AnrWatchDog : Object
    {
        // ── Methods ──
        public void add_OnApplicationNotResponding(){} // RVA: 0x6DDD6F0
        public void remove_OnApplicationNotResponding(){} // RVA: 0x6DDD800
        public void get_Paused(){} // RVA: 0xB68DF0
        public void set_Paused(){} // RVA: 0xB68E00
        public void .ctor(){} // RVA: 0x6DDD910
        public void Stop(){} // RVA: 0x894750
        public void Report(){} // RVA: 0x6DDDE00
        public void <.ctor>b__11_0(){} // RVA: 0x21B8CE0
        public void <.ctor>b__11_1(){} // RVA: 0xEAFB80
        public void <.ctor>b__11_2(){} // RVA: 0x6DDDF90
    }

    public class AnrWatchDogMultiThreaded : AnrWatchDog
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DDE050
        public void Stop(){} // RVA: 0x6DDE320
        public void UpdateUiStatus(){} // RVA: 0x6DDE350
        public void Run(){} // RVA: 0x6DDE3F0
    }

    public class AnrWatchDogSingleThreaded : AnrWatchDog
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DDE900
        public void Stop(){} // RVA: 0x26B4710
        public void UpdateUiStatus(){} // RVA: 0x6DDEAE0
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x6DD8860
        public void WriteScope(){} // RVA: 0x89EC40
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ErrorTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2230E30
    }

    public class IEventCapture
    {
        // ── Methods ──
        public void Capture(){} // RVA: 0x87BF80
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x894320
        public void remove_SceneLoaded(){} // RVA: 0x894320
        public void add_SceneUnloaded(){} // RVA: 0x894320
        public void remove_SceneUnloaded(){} // RVA: 0x894320
        public void add_ActiveSceneChanged(){} // RVA: 0x894320
        public void remove_ActiveSceneChanged(){} // RVA: 0x894320
    }

    public class ISentrySystemInfo
    {
        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x87C0A0
        public void get_OperatingSystem(){} // RVA: 0x87C0A0
        public void get_ProcessorCount(){} // RVA: 0x87C0A0
        public void get_SupportsVibration(){} // RVA: 0x87C100
        public void get_DeviceType(){} // RVA: 0x87C0A0
        public void get_CpuDescription(){} // RVA: 0x87C0A0
        public void get_DeviceName(){} // RVA: 0x87C0A0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x87C0A0
        public void get_DeviceModel(){} // RVA: 0x87C0A0
        public void get_SystemMemorySize(){} // RVA: 0x87C0A0
        public void get_GraphicsDeviceId(){} // RVA: 0x87C0A0
        public void get_GraphicsDeviceName(){} // RVA: 0x87C0A0
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x87C0A0
        public void get_GraphicsDeviceVendor(){} // RVA: 0x87C0A0
        public void get_GraphicsMemorySize(){} // RVA: 0x87C0A0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x87C0A0
        public void get_NpotSupport(){} // RVA: 0x87C0A0
        public void get_GraphicsDeviceVersion(){} // RVA: 0x87C0A0
        public void get_GraphicsDeviceType(){} // RVA: 0x87C0A0
        public void get_MaxTextureSize(){} // RVA: 0x87C0A0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x87C100
        public void get_SupportsRayTracing(){} // RVA: 0x87C100
        public void get_SupportsComputeShaders(){} // RVA: 0x87C100
        public void get_SupportsGeometryShaders(){} // RVA: 0x87C100
        public void get_GraphicsShaderLevel(){} // RVA: 0x87C0A0
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x87C100
        public void get_IsDebugBuild(){} // RVA: 0x87C0A0
        public void get_EditorVersion(){} // RVA: 0x87C0A0
        public void get_InstallMode(){} // RVA: 0x87C0A0
        public void get_TargetFrameRate(){} // RVA: 0x87C0A0
        public void get_CopyTextureSupport(){} // RVA: 0x87C0A0
        public void get_RenderingThreadingMode(){} // RVA: 0x87C0A0
        public void get_StartTime(){} // RVA: 0x87C0A0
    }

    public class ISentryUnityInfo
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x87D280
        public void get_Il2CppMethods(){} // RVA: 0x87C0A0
        public void IsKnownPlatform(){} // RVA: 0x87D280
        public void IsLinux(){} // RVA: 0x87D280
        public void IsNativeSupportEnabled(){} // RVA: 0x87FE70
        public void IsSupportedBySentryNative(){} // RVA: 0x87DD20
        public void GetDebugImageType(){} // RVA: 0x87C160
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0x87D280
    }

    public class Il2CppFree : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x26E1500
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0x22335C0
        public void EndInvoke(){} // RVA: 0xB44BE0
    }

    public class Il2CppGcHandleGetTarget : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3E2DDC0
        public void Invoke(){} // RVA: 0xB9E010
        public void BeginInvoke(){} // RVA: 0x22335C0
        public void EndInvoke(){} // RVA: 0x28BB5D0
    }

    public class Il2CppMethods : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xC27FD0
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0xB5DBF0
        public void get_Il2CppNativeStackTrace(){} // RVA: 0xB465B0
        public void get_Il2CppFree(){} // RVA: 0xB700F0
    }

    public class Il2CppNativeStackTrace : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DE1BA0
        public void Invoke(){} // RVA: 0x3DCCA70
        public void BeginInvoke(){} // RVA: 0x6DE1C70
        public void EndInvoke(){} // RVA: 0x50FD460
    }

    public class LogTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2230E30
    }

    public class MainThreadData : Object
    {
        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x6DE1D30
        public void set_MainThreadId(){} // RVA: 0x6DE1D70
        public void get_OperatingSystem(){} // RVA: 0x6DE1DC0
        public void set_OperatingSystem(){} // RVA: 0x6DE1E00
        public void get_ProcessorCount(){} // RVA: 0x6DE1EA0
        public void set_ProcessorCount(){} // RVA: 0x6DE1EE0
        public void get_SupportsVibration(){} // RVA: 0x6DE1F30
        public void set_SupportsVibration(){} // RVA: 0x6DE1F70
        public void get_DeviceType(){} // RVA: 0x6DE1FC0
        public void set_DeviceType(){} // RVA: 0x6DE2000
        public void get_CpuDescription(){} // RVA: 0x6DE20A0
        public void set_CpuDescription(){} // RVA: 0x6DE20E0
        public void get_DeviceName(){} // RVA: 0x6DE2180
        public void set_DeviceName(){} // RVA: 0x6DE21C0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x6DE2260
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x6DE22A0
        public void get_DeviceModel(){} // RVA: 0x6DE2340
        public void set_DeviceModel(){} // RVA: 0x6DE2380
        public void get_SystemMemorySize(){} // RVA: 0x6DE2420
        public void set_SystemMemorySize(){} // RVA: 0x6DE2460
        public void get_GraphicsDeviceId(){} // RVA: 0x6DE24B0
        public void set_GraphicsDeviceId(){} // RVA: 0x6DE24F0
        public void get_GraphicsDeviceName(){} // RVA: 0x6DE2540
        public void set_GraphicsDeviceName(){} // RVA: 0x6DE2580
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x6DE2620
        public void set_GraphicsDeviceVendorId(){} // RVA: 0x6DE2660
        public void get_GraphicsDeviceVendor(){} // RVA: 0x6DE2700
        public void set_GraphicsDeviceVendor(){} // RVA: 0x6DE2740
        public void get_GraphicsMemorySize(){} // RVA: 0x6DE27E0
        public void set_GraphicsMemorySize(){} // RVA: 0x6DE2820
        public void get_GraphicsMultiThreaded(){} // RVA: 0x6DE2870
        public void set_GraphicsMultiThreaded(){} // RVA: 0x6DE28B0
        public void get_NpotSupport(){} // RVA: 0x6DE2900
        public void set_NpotSupport(){} // RVA: 0x6DE2940
        public void get_GraphicsDeviceVersion(){} // RVA: 0x6DE29E0
        public void set_GraphicsDeviceVersion(){} // RVA: 0x6DE2A20
        public void get_GraphicsDeviceType(){} // RVA: 0x6DE2AC0
        public void set_GraphicsDeviceType(){} // RVA: 0x6DE2B00
        public void get_MaxTextureSize(){} // RVA: 0x6DE2BA0
        public void set_MaxTextureSize(){} // RVA: 0x6DE2BE0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x6DE2C30
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x6DE2C70
        public void get_SupportsRayTracing(){} // RVA: 0x6DE2CC0
        public void set_SupportsRayTracing(){} // RVA: 0x6DE2D00
        public void get_SupportsComputeShaders(){} // RVA: 0x6DE2D50
        public void set_SupportsComputeShaders(){} // RVA: 0x6DE2D90
        public void get_SupportsGeometryShaders(){} // RVA: 0x6DE2DE0
        public void set_SupportsGeometryShaders(){} // RVA: 0x6DE2E20
        public void get_GraphicsShaderLevel(){} // RVA: 0x6DE2E70
        public void set_GraphicsShaderLevel(){} // RVA: 0x6DE2EB0
        public void get_IsDebugBuild(){} // RVA: 0x6DE2F00
        public void set_IsDebugBuild(){} // RVA: 0x6DE2F40
        public void get_EditorVersion(){} // RVA: 0x6DE2F90
        public void set_EditorVersion(){} // RVA: 0x6DE2FD0
        public void get_InstallMode(){} // RVA: 0x6DE3070
        public void set_InstallMode(){} // RVA: 0x6DE30B0
        public void get_TargetFrameRate(){} // RVA: 0x6DE3150
        public void set_TargetFrameRate(){} // RVA: 0x6DE3190
        public void get_CopyTextureSupport(){} // RVA: 0x6DE3230
        public void set_CopyTextureSupport(){} // RVA: 0x6DE3270
        public void get_RenderingThreadingMode(){} // RVA: 0x6DE3310
        public void set_RenderingThreadingMode(){} // RVA: 0x6DE3350
        public void get_StartTime(){} // RVA: 0x6DE33F0
        public void set_StartTime(){} // RVA: 0x6DE3450
        public void IsMainThread(){} // RVA: 0x6DE34B0
        public void get_SentrySystemInfo(){} // RVA: 0x6DE35D0
        public void set_SentrySystemInfo(){} // RVA: 0x6DE3610
        public void CollectData(){} // RVA: 0x6DE36B0
    }

    public class NativeStackTrace : Object
    {
        // ── Methods ──
        public void get_Frames(){} // RVA: 0xB5DBF0
        public void set_Frames(){} // RVA: 0xB44D60
        public void get_ImageUuid(){} // RVA: 0xB465B0
        public void set_ImageUuid(){} // RVA: 0xBA9BA0
        public void get_ImageName(){} // RVA: 0xB700F0
        public void set_ImageName(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x6DDCDE0
    }

    public class SceneAdapter : ValueType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x77900
        public void .ctor(){} // RVA: 0x47F10
    }

    public class SceneManagerAdapter : Object
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x6DDED80
        public void remove_SceneLoaded(){} // RVA: 0x6DDEE90
        public void add_SceneUnloaded(){} // RVA: 0x6DDEFA0
        public void remove_SceneUnloaded(){} // RVA: 0x6DDF0B0
        public void add_ActiveSceneChanged(){} // RVA: 0x6DDF1C0
        public void remove_ActiveSceneChanged(){} // RVA: 0x6DDF2D0
        public void .ctor(){} // RVA: 0x6DDF3E0
        public void .cctor(){} // RVA: 0x6DDF720
        public void <.ctor>b__10_0(){} // RVA: 0x6DDF7D0
        public void <.ctor>b__10_1(){} // RVA: 0x6DDF870
        public void <.ctor>b__10_2(){} // RVA: 0x6DDF900
    }

    public class SceneManagerTracingAPI : SceneManagerAPI
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x650AC60
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x650AD00
    }

    public class SceneManagerTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x650A970
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ScopeObserver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x67462E0
        public void AddBreadcrumb(){} // RVA: 0x6DE4950
        public void AddBreadcrumbImpl(){} // RVA: 0x894320
        public void SetExtra(){} // RVA: 0x6DE4B60
        public void SetExtraImpl(){} // RVA: 0x8943B0
        public void SetTag(){} // RVA: 0x6DE4EA0
        public void SetTagImpl(){} // RVA: 0x8943B0
        public void UnsetTag(){} // RVA: 0x6DE5080
        public void UnsetTagImpl(){} // RVA: 0x894320
        public void SetUser(){} // RVA: 0x6DE5220
        public void SetUserImpl(){} // RVA: 0x894320
        public void UnsetUserImpl(){} // RVA: 0x894290
    }

    public class ScreenshotAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DE54E0
    }

    public class ScreenshotAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetStream(){} // RVA: 0x6DE5560
        public void GetTargetResolution(){} // RVA: 0x6DE57B0
        public void CaptureScreenshot(){} // RVA: 0x6DE57D0
    }

    public class ScriptableSentryUnityOptions : ScriptableObject
    {
        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x6DE6190
        public void get_Enabled(){} // RVA: 0xB5DD50
        public void set_Enabled(){} // RVA: 0xB5DD60
        public void get_Dsn(){} // RVA: 0xB700F0
        public void set_Dsn(){} // RVA: 0xB70100
        public void get_CaptureInEditor(){} // RVA: 0xF73960
        public void set_CaptureInEditor(){} // RVA: 0xF73A60
        public void get_EnableLogDebouncing(){} // RVA: 0x14F7430
        public void set_EnableLogDebouncing(){} // RVA: 0x21CBB70
        public void get_DebounceTimeLog(){} // RVA: 0x1AE5AC0
        public void set_DebounceTimeLog(){} // RVA: 0x23E55F0
        public void get_DebounceTimeWarning(){} // RVA: 0xB9E080
        public void set_DebounceTimeWarning(){} // RVA: 0xB9E090
        public void get_DebounceTimeError(){} // RVA: 0xE9CE60
        public void set_DebounceTimeError(){} // RVA: 0xEA1260
        public void get_TracesSampleRate(){} // RVA: 0x3DE0930
        public void set_TracesSampleRate(){} // RVA: 0x3DE0940
        public void get_AutoStartupTraces(){} // RVA: 0xC02470
        public void set_AutoStartupTraces(){} // RVA: 0xC02480
        public void get_AutoSceneLoadTraces(){} // RVA: 0xEEA010
        public void set_AutoSceneLoadTraces(){} // RVA: 0xEEA000
        public void get_AutoAwakeTraces(){} // RVA: 0xEEA480
        public void set_AutoAwakeTraces(){} // RVA: 0xEEA470
        public void get_AutoSessionTracking(){} // RVA: 0x1DE3FA0
        public void set_AutoSessionTracking(){} // RVA: 0x23E2280
        public void get_AutoSessionTrackingInterval(){} // RVA: 0xBE5870
        public void set_AutoSessionTrackingInterval(){} // RVA: 0xBE5880
        public void get_ReleaseOverride(){} // RVA: 0xBBF8F0
        public void set_ReleaseOverride(){} // RVA: 0xBBF900
        public void get_EnvironmentOverride(){} // RVA: 0xBE58B0
        public void set_EnvironmentOverride(){} // RVA: 0xCA4DF0
        public void get_AttachStacktrace(){} // RVA: 0xE3F480
        public void set_AttachStacktrace(){} // RVA: 0x1546550
        public void get_AttachScreenshot(){} // RVA: 0x5C8BB10
        public void set_AttachScreenshot(){} // RVA: 0x6A92EB0
        public void get_ScreenshotQuality(){} // RVA: 0xE36310
        public void set_ScreenshotQuality(){} // RVA: 0x12BB610
        public void get_ScreenshotCompression(){} // RVA: 0xD347A0
        public void set_ScreenshotCompression(){} // RVA: 0xD34740
        public void get_AttachViewHierarchy(){} // RVA: 0x1D450E0
        public void set_AttachViewHierarchy(){} // RVA: 0x1D43780
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x2536460
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x25406E0
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x25406F0
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x2540700
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x19C6270
        public void set_MaxViewHierarchyDepth(){} // RVA: 0xCE5450
        public void get_BreadcrumbsForLogs(){} // RVA: 0x19FAC10
        public void set_BreadcrumbsForLogs(){} // RVA: 0x64A7EE0
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x1A1E0B0
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x6DE6210
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x1A1F4B0
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x6DE6220
        public void get_BreadcrumbsForErrors(){} // RVA: 0x6DE6230
        public void set_BreadcrumbsForErrors(){} // RVA: 0x6DE6240
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x1165710
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x1F749D0
        public void get_MaxBreadcrumbs(){} // RVA: 0x23A4270
        public void set_MaxBreadcrumbs(){} // RVA: 0x6CB6340
        public void get_ReportAssembliesMode(){} // RVA: 0xD34760
        public void set_ReportAssembliesMode(){} // RVA: 0xD34750
        public void get_SendDefaultPii(){} // RVA: 0xC27EB0
        public void set_SendDefaultPii(){} // RVA: 0xC27EC0
        public void get_IsEnvironmentUser(){} // RVA: 0x1A0E0B0
        public void set_IsEnvironmentUser(){} // RVA: 0x6DE6250
        public void get_EnableOfflineCaching(){} // RVA: 0x1D5BDB0
        public void set_EnableOfflineCaching(){} // RVA: 0x6DE6260
        public void get_MaxCacheItems(){} // RVA: 0x14780B0
        public void set_MaxCacheItems(){} // RVA: 0x147EE80
        public void get_InitCacheFlushTimeout(){} // RVA: 0x40A8A30
        public void set_InitCacheFlushTimeout(){} // RVA: 0x46CB6C0
        public void get_SampleRate(){} // RVA: 0xBAB510
        public void set_SampleRate(){} // RVA: 0xBAB520
        public void get_ShutdownTimeout(){} // RVA: 0xF3A940
        public void set_ShutdownTimeout(){} // RVA: 0x11A0AB0
        public void get_MaxQueueItems(){} // RVA: 0x262A930
        public void set_MaxQueueItems(){} // RVA: 0x262A900
        public void get_AnrDetectionEnabled(){} // RVA: 0x6DE6270
        public void set_AnrDetectionEnabled(){} // RVA: 0x649A3A0
        public void get_AnrTimeout(){} // RVA: 0x262A8F0
        public void set_AnrTimeout(){} // RVA: 0x262A940
        public void get_CaptureFailedRequests(){} // RVA: 0xE37D60
        public void set_CaptureFailedRequests(){} // RVA: 0xE3D080
        public void get_FailedRequestStatusCodes(){} // RVA: 0x12EB090
        public void set_FailedRequestStatusCodes(){} // RVA: 0x13B1040
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x2009180
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x20097F0
        public void get_FilterWebExceptions(){} // RVA: 0x6A8AF80
        public void set_FilterWebExceptions(){} // RVA: 0x6A8AF90
        public void get_FilterSocketExceptions(){} // RVA: 0x6C1B1C0
        public void set_FilterSocketExceptions(){} // RVA: 0x6C1B1D0
        public void get_IosNativeSupportEnabled(){} // RVA: 0x6C1B1E0
        public void set_IosNativeSupportEnabled(){} // RVA: 0x6C1B1F0
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x6C1B200
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x6C1B210
        public void get_NdkIntegrationEnabled(){} // RVA: 0x6DE6280
        public void set_NdkIntegrationEnabled(){} // RVA: 0x6DE6290
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x6DE62A0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x6DE62B0
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x215C150
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x215CA00
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x6BA2C00
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x6BA2C10
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x6DE62C0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x6DE62D0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x6DE62E0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x6DE62F0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x6DE6300
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x6DE6310
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0xBAE420
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0xBAE430
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0xCA4D80
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0xCA4D90
        public void get_OptionsConfiguration(){} // RVA: 0xC68EB0
        public void set_OptionsConfiguration(){} // RVA: 0xC68EC0
        public void get_Debug(){} // RVA: 0x11629E0
        public void set_Debug(){} // RVA: 0x1AE6E90
        public void get_DebugOnlyInEditor(){} // RVA: 0x6DE6320
        public void set_DebugOnlyInEditor(){} // RVA: 0x6DE6330
        public void get_DiagnosticLevel(){} // RVA: 0x6DE6340
        public void set_DiagnosticLevel(){} // RVA: 0x6DE6350
        public void LoadSentryUnityOptions(){} // RVA: 0x6DE6360
        public void ToSentryUnityOptions(){} // RVA: 0x6DE63E0
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x6DE7240
        public void HandleExceptionFilter(){} // RVA: 0x6DE74A0
        public void ShouldDebug(){} // RVA: 0x6DE7560
        public void .ctor(){} // RVA: 0x6DE7580
    }

    public class SentryBuildTimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x8943B0
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SentryCliOptions : ScriptableObject
    {
        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0xB5DD50
        public void set_UploadSymbols(){} // RVA: 0xB5DD60
        public void get_UploadDevelopmentSymbols(){} // RVA: 0xF43F30
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x17F4D80
        public void get_UploadSources(){} // RVA: 0x246FA20
        public void set_UploadSources(){} // RVA: 0x246E8E0
        public void get_UrlOverride(){} // RVA: 0xB700F0
        public void set_UrlOverride(){} // RVA: 0xB70100
        public void get_Auth(){} // RVA: 0xB70160
        public void set_Auth(){} // RVA: 0xB44DC0
        public void get_Organization(){} // RVA: 0xD33E60
        public void set_Organization(){} // RVA: 0xB708C0
        public void get_Project(){} // RVA: 0xD05CA0
        public void set_Project(){} // RVA: 0xD09D70
        public void get_IgnoreCliErrors(){} // RVA: 0xC02470
        public void set_IgnoreCliErrors(){} // RVA: 0xC02480
        public void get_CliOptionsConfiguration(){} // RVA: 0xBBF8F0
        public void set_CliOptionsConfiguration(){} // RVA: 0xBBF900
        public void GetConfigPath(){} // RVA: 0x6DE7B90
        public void MissingFieldWarning(){} // RVA: 0x6DE7C10
        public void IsValid(){} // RVA: 0x6DE7CD0
        public void .ctor(){} // RVA: 0x6DE7E60
    }

    public class SentryCliOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x6DE7E70
        public void Configure(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xDD1AC0
        public void .cctor(){} // RVA: 0x6DE7ED0
    }

    public class SentryInitialization : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x6508CA0
    }

    public class SentryIntegrations : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x6509CC0
    }

    public class SentryMonoBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6DE7F80
        public void StartAwakeSpan(){} // RVA: 0x6DE81A0
        public void FinishAwakeSpan(){} // RVA: 0x6DE8300
        public void add_ApplicationResuming(){} // RVA: 0x6DE8380
        public void remove_ApplicationResuming(){} // RVA: 0x6DE8470
        public void add_ApplicationPausing(){} // RVA: 0x6DE8560
        public void remove_ApplicationPausing(){} // RVA: 0x6DE8650
        public void get_Application(){} // RVA: 0x6DE8740
        public void set_Application(){} // RVA: 0xD09D70
        public void UpdatePauseStatus(){} // RVA: 0x6DE8800
        public void OnApplicationPause(){} // RVA: 0x6DE8800
        public void OnApplicationFocus(){} // RVA: 0x6DE8840
        public void OnApplicationQuit(){} // RVA: 0x6DE8880
        public void Awake(){} // RVA: 0x6DE8920
        public void .ctor(){} // RVA: 0xBF9D60
    }

    public class SentryOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x6DE8980
        public void Configure(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xDD1AC0
        public void .cctor(){} // RVA: 0x6DE89E0
    }

    public class SentryRuntimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x894320
        public void .ctor(){} // RVA: 0xDD1AC0
    }

    public class SentrySystemInfoAdapter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void get_MainThreadId(){} // RVA: 0x6DEBC20
        public void get_OperatingSystem(){} // RVA: 0x6DEBCC0
        public void get_ProcessorCount(){} // RVA: 0x6DEBCD0
        public void get_SupportsVibration(){} // RVA: 0x6DEBD50
        public void get_DeviceType(){} // RVA: 0x6DEBDD0
        public void get_CpuDescription(){} // RVA: 0x6DEBF70
        public void get_DeviceName(){} // RVA: 0x6DEBF80
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x6DEC170
        public void get_DeviceModel(){} // RVA: 0x6DEC310
        public void get_SystemMemorySize(){} // RVA: 0x6DEC4B0
        public void get_GraphicsDeviceId(){} // RVA: 0x6DEC530
        public void get_GraphicsDeviceName(){} // RVA: 0x6DEC5B0
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x6DEC5C0
        public void get_GraphicsDeviceVendor(){} // RVA: 0x6DEC760
        public void get_GraphicsMemorySize(){} // RVA: 0x6DEC770
        public void get_GraphicsMultiThreaded(){} // RVA: 0x6DEC7F0
        public void get_NpotSupport(){} // RVA: 0x6DEC980
        public void get_GraphicsDeviceVersion(){} // RVA: 0x6DECA10
        public void get_GraphicsDeviceType(){} // RVA: 0x6DECA20
        public void get_MaxTextureSize(){} // RVA: 0x6DECAB0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x6DECB30
        public void get_SupportsRayTracing(){} // RVA: 0x6DECBB0
        public void get_SupportsComputeShaders(){} // RVA: 0x6DECC30
        public void get_SupportsGeometryShaders(){} // RVA: 0x6DECCB0
        public void get_GraphicsShaderLevel(){} // RVA: 0x6DECD30
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x6DECDB0
        public void get_IsDebugBuild(){} // RVA: 0x6DECE30
        public void get_EditorVersion(){} // RVA: 0x6DECFC0
        public void get_InstallMode(){} // RVA: 0x6DED010
        public void get_TargetFrameRate(){} // RVA: 0x6DED0D0
        public void get_CopyTextureSupport(){} // RVA: 0x6DED270
        public void get_RenderingThreadingMode(){} // RVA: 0x6DED410
        public void get_StartTime(){} // RVA: 0x6DED5B0
        public void .cctor(){} // RVA: 0x6DED740
    }

    public class SentryUnity : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x6DE8B80
        public void Close(){} // RVA: 0x6DE8C80
    }

    public class SentryUnityInfo : Object
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0xC2E4C0
        public void get_Il2CppMethods(){} // RVA: 0xB5DBF0
        public void SanitizeDebugId(){} // RVA: 0x65092C0
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x6509330
        public void il2cpp_gchandle_get_target(){} // RVA: 0x6509330
        public void il2cpp_free(){} // RVA: 0x6509340
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x6509350
        public void il2cpp_native_stack_trace(){} // RVA: 0x6509570
        public void IsKnownPlatform(){} // RVA: 0x6509580
        public void IsLinux(){} // RVA: 0x6509620
        public void IsNativeSupportEnabled(){} // RVA: 0x65096B0
        public void IsSupportedBySentryNative(){} // RVA: 0x6509750
        public void GetDebugImageType(){} // RVA: 0x6509770
        public void .ctor(){} // RVA: 0x6509840
    }

    public class SentryUnityOptions : SentryOptions
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x6DE8D40
        public void set_Enabled(){} // RVA: 0x6DE8D50
        public void get_AutoStartupTraces(){} // RVA: 0x6DE8D60
        public void set_AutoStartupTraces(){} // RVA: 0x6DE8D70
        public void get_AutoSceneLoadTraces(){} // RVA: 0x6DE8D80
        public void set_AutoSceneLoadTraces(){} // RVA: 0x6DE8D90
        public void get_CaptureInEditor(){} // RVA: 0x6DE8DA0
        public void set_CaptureInEditor(){} // RVA: 0x6DE8DB0
        public void get_EnableLogDebouncing(){} // RVA: 0x6DE8DC0
        public void set_EnableLogDebouncing(){} // RVA: 0x6DE8DD0
        public void get_DebounceTimeLog(){} // RVA: 0x165EF80
        public void set_DebounceTimeLog(){} // RVA: 0x6DE8DE0
        public void get_DebounceTimeWarning(){} // RVA: 0x165D6B0
        public void set_DebounceTimeWarning(){} // RVA: 0x6DE8DF0
        public void get_DebounceTimeError(){} // RVA: 0x16543B0
        public void set_DebounceTimeError(){} // RVA: 0x6DE8E00
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x6DE8E10
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x6DE8E20
        public void get_AttachScreenshot(){} // RVA: 0x6DE8E40
        public void set_AttachScreenshot(){} // RVA: 0x6DE8E50
        public void get_AttachViewHierarchy(){} // RVA: 0x6DE8E60
        public void set_AttachViewHierarchy(){} // RVA: 0x6DE8E70
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x6DE8E80
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x6DE8E90
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x6DE8EA0
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x6DE8EB0
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x6DE8EC0
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x6DE8ED0
        public void get_ScreenshotQuality(){} // RVA: 0x6DE8EE0
        public void set_ScreenshotQuality(){} // RVA: 0x6DE8EF0
        public void get_ScreenshotCompression(){} // RVA: 0x6DE8F00
        public void set_ScreenshotCompression(){} // RVA: 0x6DE8F10
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x1657E50
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x1653200
        public void get_AnrTimeout(){} // RVA: 0x165B520
        public void set_AnrTimeout(){} // RVA: 0x6DE8F20
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x1BF7100
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x6DE8F30
        public void get_IosNativeSupportEnabled(){} // RVA: 0x6DE8F40
        public void set_IosNativeSupportEnabled(){} // RVA: 0x6DE8F50
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x6DE8F60
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x6DE8F70
        public void get_NdkIntegrationEnabled(){} // RVA: 0x6DE8F80
        public void set_NdkIntegrationEnabled(){} // RVA: 0x6DE8F90
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x6DE8FA0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x6DE8FB0
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x6DE8FC0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x6DE8FD0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x6DE8FE0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x6DE8FF0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x6DE9000
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x6DE9010
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x6DE9020
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x6DE9030
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x6DE9040
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x6DE9050
        public void get_StackTraceMode(){} // RVA: 0x6DE9060
        public void set_StackTraceMode(){} // RVA: 0x6DE9070
        public void get_DefaultUserId(){} // RVA: 0x1660AC0
        public void set_DefaultUserId(){} // RVA: 0x6DE9080
        public void get_NativeContextWriter(){} // RVA: 0x1640770
        public void set_NativeContextWriter(){} // RVA: 0x166BC10
        public void get_NativeSupportCloseCallback(){} // RVA: 0xBAE4F0
        public void set_NativeSupportCloseCallback(){} // RVA: 0xBAE500
        public void get_SdkIntegrationNames(){} // RVA: 0x166E090
        public void set_SdkIntegrationNames(){} // RVA: 0x16653A0
        public void .ctor(){} // RVA: 0x6DE9270
        public void ToString(){} // RVA: 0x6DEA070
    }

    public class SentryUnityOptionsExtensions : Object
    {
        // ── Methods ──
        public void ShouldInitializeSdk(){} // RVA: 0x6DEA350
        public void IsValid(){} // RVA: 0x6DEA580
        public void SetupLogging(){} // RVA: 0x6DEA6E0
        public void AddIl2CppExceptionProcessor(){} // RVA: 0x6DEA8D0
        public void DisableUnityApplicationLoggingIntegration(){} // RVA: 0x6DEA9D0
        public void DisableAnrIntegration(){} // RVA: 0x6DEAA20
        public void DisableBadGatewayExceptionFilter(){} // RVA: 0x6DEAA70
        public void DisableWebExceptionFilter(){} // RVA: 0x6DEAAC0
        public void DisableSocketExceptionFilter(){} // RVA: 0x6DEAB10
    }

    public class SentryUnitySdk : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Init(){} // RVA: 0x6DEAB60
        public void Close(){} // RVA: 0x6DEB160
    }

    public class StartupTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x6509DF0
        public void AfterAssembliesLoaded(){} // RVA: 0x6509ED0
        public void BeforeSplashScreen(){} // RVA: 0x650A100
        public void BeforeSceneLoad(){} // RVA: 0x650A330
        public void AfterSceneLoad(){} // RVA: 0x650A560
        public void .ctor(){} // RVA: 0xB43310
    }

    public class TagValueNormalizer : Object
    {
        // ── Methods ──
        public void ToTagValue(){} // RVA: 0x6DEE6C0
    }

    public class TimeDebounceBase : Object
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x6DEDE30
        public void Debounced(){} // RVA: 0x6DEDEE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class UnityEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Process(){} // RVA: 0x6DEE060
        public void SetEventContext(){} // RVA: 0x6DEE0D0
        public void PopulateDevice(){} // RVA: 0x6DEE2C0
        public void PopulateSdkIntegrations(){} // RVA: 0x6DEE510
    }

    public class UnityIl2CppEventExceptionProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DD97B0
        public void Process(){} // RVA: 0x6DD9AA0
        public void NormalizeUuid(){} // RVA: 0x6DDAE70
        public void FindDebugImageContainingAddress(){} // RVA: 0x6DDAF20
        public void EnumerateChainedExceptions(){} // RVA: 0x6DDB090
        public void GetNativeStackTrace(){} // RVA: 0x6DDB1A0
        public void .cctor(){} // RVA: 0x6DDB5C0
    }

    public class UnityLogger : Object
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x6DEE720
        public void .ctor(){} // RVA: 0x6DEE860
        public void Log(){} // RVA: 0x6DEE970
        public void GetUnityLogType(){} // RVA: 0x6DEEBC0
        public void ToString(){} // RVA: 0x6DEEBF0
    }

    public class UnityScopeIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void Register(){} // RVA: 0x6DDFD00
    }

    public class UnityScopeUpdater : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17C92C0
        public void ConfigureScope(){} // RVA: 0x6DDFEB0
        public void PopulateSdk(){} // RVA: 0x6DE0560
        public void PopulateApp(){} // RVA: 0x6DE0740
        public void PopulateOperatingSystem(){} // RVA: 0x6DE08A0
        public void PopulateDevice(){} // RVA: 0x6DE0940
        public void PopulateGpu(){} // RVA: 0x6DE0EA0
        public void PopulateUnity(){} // RVA: 0x6DE15B0
        public void PopulateTags(){} // RVA: 0x6DE1880
        public void PopulateUser(){} // RVA: 0x6DE1B20
    }

    public class UnitySdkInfo : Object
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x6DDFA20
        public void .cctor(){} // RVA: 0x6DDFA80
    }

    public class UnityViewHierarchyAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB44D60
        public void GetStream(){} // RVA: 0x6DEEC30
        public void CaptureViewHierarchy(){} // RVA: 0x6DEED00
        public void CreateViewHierarchy(){} // RVA: 0x6DEEF10
        public void CreateNode(){} // RVA: 0x6DEF350
    }

    public class UnityViewHierarchyNode : ViewHierarchyNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0xB700F0
        public void set_Tag(){} // RVA: 0xB70100
        public void get_Position(){} // RVA: 0xB70160
        public void set_Position(){} // RVA: 0xB44DC0
        public void get_Rotation(){} // RVA: 0xD33E60
        public void set_Rotation(){} // RVA: 0xB708C0
        public void get_Scale(){} // RVA: 0xD05CA0
        public void set_Scale(){} // RVA: 0xD09D70
        public void get_Active(){} // RVA: 0x5006610
        public void set_Active(){} // RVA: 0x6DEFD20
        public void get_Extras(){} // RVA: 0xBBF8F0
        public void set_Extras(){} // RVA: 0xBBF900
        public void .ctor(){} // RVA: 0xBA9BA0
        public void WriteAdditionalProperties(){} // RVA: 0x6DEFD30
    }

    public class UnityWebRequestTransport : HttpTransportBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF05F0
        public void SendEnvelopeAsync(){} // RVA: 0x6DF0670
        public void CreateWebRequest(){} // RVA: 0x6DF0770
        public void GetResponse(){} // RVA: 0x6DF0D10
    }

    public class WarningTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2230E30
    }

    public class WebBackgroundWorker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6DF0280
        public void EnqueueEnvelope(){} // RVA: 0x6DF0410
        public void FlushAsync(){} // RVA: 0x6DF0550
        public void get_QueuedItems(){} // RVA: 0xFEAE90
    }

}