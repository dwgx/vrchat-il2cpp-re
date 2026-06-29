// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 54
// Methods: 577

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Register(){} // RVA: 0x7AE15C300
        public void .cctor(){} // RVA: 0x7AE15CAB0
    }

    public class AnrWatchDog : Object
    {
        // ── Methods ──
        public void add_OnApplicationNotResponding(){} // RVA: 0x7AE15CB80
        public void remove_OnApplicationNotResponding(){} // RVA: 0x7AE15CC90
        public void get_Paused(){} // RVA: 0x7A80FD690
        public void set_Paused(){} // RVA: 0x7A80FD6A0
        public void .ctor(){} // RVA: 0x7AE15CDA0
        public void Stop(){} // RVA: 0x7A7E18C30
        public void Report(){} // RVA: 0x7AE15D290
        public void <.ctor>b__11_0(){} // RVA: 0x7A9570550
        public void <.ctor>b__11_1(){} // RVA: 0x7A84236E0
        public void <.ctor>b__11_2(){} // RVA: 0x7AE15D430
    }

    public class AnrWatchDogMultiThreaded : AnrWatchDog
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE15D4F0
        public void Stop(){} // RVA: 0x7AE15D7C0
        public void UpdateUiStatus(){} // RVA: 0x7AE15D7F0
        public void Run(){} // RVA: 0x7AE15D890
    }

    public class AnrWatchDogSingleThreaded : AnrWatchDog
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE15DDB0
        public void Stop(){} // RVA: 0x7A88A0900
        public void UpdateUiStatus(){} // RVA: 0x7AE15DF90
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7AE157CE0
        public void WriteScope(){} // RVA: 0x7A7E22FD0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ErrorTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97242F0
    }

    public class IEventCapture
    {
        // ── Methods ──
        public void Capture(){} // RVA: 0x7A7E00560
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7A7E18800
        public void remove_SceneLoaded(){} // RVA: 0x7A7E18800
        public void add_SceneUnloaded(){} // RVA: 0x7A7E18800
        public void remove_SceneUnloaded(){} // RVA: 0x7A7E18800
        public void add_ActiveSceneChanged(){} // RVA: 0x7A7E18800
        public void remove_ActiveSceneChanged(){} // RVA: 0x7A7E18800
    }

    public class ISentrySystemInfo
    {
        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7A7E00680
        public void get_OperatingSystem(){} // RVA: 0x7A7E00680
        public void get_ProcessorCount(){} // RVA: 0x7A7E00680
        public void get_SupportsVibration(){} // RVA: 0x7A7E006E0
        public void get_DeviceType(){} // RVA: 0x7A7E00680
        public void get_CpuDescription(){} // RVA: 0x7A7E00680
        public void get_DeviceName(){} // RVA: 0x7A7E00680
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7A7E00680
        public void get_DeviceModel(){} // RVA: 0x7A7E00680
        public void get_SystemMemorySize(){} // RVA: 0x7A7E00680
        public void get_GraphicsDeviceId(){} // RVA: 0x7A7E00680
        public void get_GraphicsDeviceName(){} // RVA: 0x7A7E00680
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7A7E00680
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7A7E00680
        public void get_GraphicsMemorySize(){} // RVA: 0x7A7E00680
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7A7E00680
        public void get_NpotSupport(){} // RVA: 0x7A7E00680
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7A7E00680
        public void get_GraphicsDeviceType(){} // RVA: 0x7A7E00680
        public void get_MaxTextureSize(){} // RVA: 0x7A7E00680
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7A7E006E0
        public void get_SupportsRayTracing(){} // RVA: 0x7A7E006E0
        public void get_SupportsComputeShaders(){} // RVA: 0x7A7E006E0
        public void get_SupportsGeometryShaders(){} // RVA: 0x7A7E006E0
        public void get_GraphicsShaderLevel(){} // RVA: 0x7A7E00680
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7A7E006E0
        public void get_IsDebugBuild(){} // RVA: 0x7A7E00680
        public void get_EditorVersion(){} // RVA: 0x7A7E00680
        public void get_InstallMode(){} // RVA: 0x7A7E00680
        public void get_TargetFrameRate(){} // RVA: 0x7A7E00680
        public void get_CopyTextureSupport(){} // RVA: 0x7A7E00680
        public void get_RenderingThreadingMode(){} // RVA: 0x7A7E00680
        public void get_StartTime(){} // RVA: 0x7A7E00680
    }

    public class ISentryUnityInfo
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7A7E01900
        public void get_Il2CppMethods(){} // RVA: 0x7A7E00680
        public void IsKnownPlatform(){} // RVA: 0x7A7E01900
        public void IsLinux(){} // RVA: 0x7A7E01900
        public void IsNativeSupportEnabled(){} // RVA: 0x7A7E039E0
        public void IsSupportedBySentryNative(){} // RVA: 0x7A7E01F00
        public void GetDebugImageType(){} // RVA: 0x7A7E00740
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0x7A7E01900
    }

    public class Il2CppFree : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9C64DA0
        public void Invoke(){} // RVA: 0x7A8133090
        public void BeginInvoke(){} // RVA: 0x7AE1613C0
        public void EndInvoke(){} // RVA: 0x7A80D8CA0
    }

    public class Il2CppGcHandleGetTarget : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AB162910
        public void Invoke(){} // RVA: 0x7A8133090
        public void BeginInvoke(){} // RVA: 0x7AE161180
        public void EndInvoke(){} // RVA: 0x7A9E46B70
    }

    public class Il2CppMethods : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81B7C50
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x7A80F2570
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x7A80DA7B0
        public void get_Il2CppFree(){} // RVA: 0x7A81052C0
    }

    public class Il2CppNativeStackTrace : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE161200
        public void Invoke(){} // RVA: 0x7AB112E00
        public void BeginInvoke(){} // RVA: 0x7AE1612D0
        public void EndInvoke(){} // RVA: 0x7AC3DBE90
    }

    public class LogTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97242F0
    }

    public class MainThreadData : Object
    {
        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7AE161440
        public void set_MainThreadId(){} // RVA: 0x7AE161480
        public void get_OperatingSystem(){} // RVA: 0x7AE1614D0
        public void set_OperatingSystem(){} // RVA: 0x7AE161510
        public void get_ProcessorCount(){} // RVA: 0x7AE1615B0
        public void set_ProcessorCount(){} // RVA: 0x7AE1615F0
        public void get_SupportsVibration(){} // RVA: 0x7AE161640
        public void set_SupportsVibration(){} // RVA: 0x7AE161680
        public void get_DeviceType(){} // RVA: 0x7AE1616D0
        public void set_DeviceType(){} // RVA: 0x7AE161710
        public void get_CpuDescription(){} // RVA: 0x7AE1617B0
        public void set_CpuDescription(){} // RVA: 0x7AE1617F0
        public void get_DeviceName(){} // RVA: 0x7AE161890
        public void set_DeviceName(){} // RVA: 0x7AE1618D0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7AE161970
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x7AE1619B0
        public void get_DeviceModel(){} // RVA: 0x7AE161A50
        public void set_DeviceModel(){} // RVA: 0x7AE161A90
        public void get_SystemMemorySize(){} // RVA: 0x7AE161B30
        public void set_SystemMemorySize(){} // RVA: 0x7AE161B70
        public void get_GraphicsDeviceId(){} // RVA: 0x7AE161BC0
        public void set_GraphicsDeviceId(){} // RVA: 0x7AE161C00
        public void get_GraphicsDeviceName(){} // RVA: 0x7AE161C50
        public void set_GraphicsDeviceName(){} // RVA: 0x7AE161C90
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7AE161D30
        public void set_GraphicsDeviceVendorId(){} // RVA: 0x7AE161D70
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7AE161E10
        public void set_GraphicsDeviceVendor(){} // RVA: 0x7AE161E50
        public void get_GraphicsMemorySize(){} // RVA: 0x7AE161EF0
        public void set_GraphicsMemorySize(){} // RVA: 0x7AE161F30
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7AE161F80
        public void set_GraphicsMultiThreaded(){} // RVA: 0x7AE161FC0
        public void get_NpotSupport(){} // RVA: 0x7AE162010
        public void set_NpotSupport(){} // RVA: 0x7AE162050
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7AE1620F0
        public void set_GraphicsDeviceVersion(){} // RVA: 0x7AE162130
        public void get_GraphicsDeviceType(){} // RVA: 0x7AE1621D0
        public void set_GraphicsDeviceType(){} // RVA: 0x7AE162210
        public void get_MaxTextureSize(){} // RVA: 0x7AE1622B0
        public void set_MaxTextureSize(){} // RVA: 0x7AE1622F0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7AE162340
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x7AE162380
        public void get_SupportsRayTracing(){} // RVA: 0x7AE1623D0
        public void set_SupportsRayTracing(){} // RVA: 0x7AE162410
        public void get_SupportsComputeShaders(){} // RVA: 0x7AE162460
        public void set_SupportsComputeShaders(){} // RVA: 0x7AE1624A0
        public void get_SupportsGeometryShaders(){} // RVA: 0x7AE1624F0
        public void set_SupportsGeometryShaders(){} // RVA: 0x7AE162530
        public void get_GraphicsShaderLevel(){} // RVA: 0x7AE162580
        public void set_GraphicsShaderLevel(){} // RVA: 0x7AE1625C0
        public void get_IsDebugBuild(){} // RVA: 0x7AE162610
        public void set_IsDebugBuild(){} // RVA: 0x7AE162650
        public void get_EditorVersion(){} // RVA: 0x7AE1626A0
        public void set_EditorVersion(){} // RVA: 0x7AE1626E0
        public void get_InstallMode(){} // RVA: 0x7AE162780
        public void set_InstallMode(){} // RVA: 0x7AE1627C0
        public void get_TargetFrameRate(){} // RVA: 0x7AE162860
        public void set_TargetFrameRate(){} // RVA: 0x7AE1628A0
        public void get_CopyTextureSupport(){} // RVA: 0x7AE162940
        public void set_CopyTextureSupport(){} // RVA: 0x7AE162980
        public void get_RenderingThreadingMode(){} // RVA: 0x7AE162A20
        public void set_RenderingThreadingMode(){} // RVA: 0x7AE162A60
        public void get_StartTime(){} // RVA: 0x7AE162B00
        public void set_StartTime(){} // RVA: 0x7AE162B60
        public void IsMainThread(){} // RVA: 0x7AE162BC0
        public void get_SentrySystemInfo(){} // RVA: 0x7AE162CE0
        public void set_SentrySystemInfo(){} // RVA: 0x7AE162D20
        public void CollectData(){} // RVA: 0x7AE162DC0
    }

    public class NativeStackTrace : Object
    {
        // ── Methods ──
        public void get_Frames(){} // RVA: 0x7A80F2570
        public void set_Frames(){} // RVA: 0x7A80D8E20
        public void get_ImageUuid(){} // RVA: 0x7A80DA7B0
        public void set_ImageUuid(){} // RVA: 0x7A813E420
        public void get_ImageName(){} // RVA: 0x7A81052C0
        public void set_ImageName(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AE15C270
    }

    public class SceneAdapter : ValueType
    {
        // ── Methods ──
        public void get_Name(){} // RVA: 0x7A765F710
        public void .ctor(){} // RVA: 0x7A7637E60
    }

    public class SceneManagerAdapter : Object
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7AE15E230
        public void remove_SceneLoaded(){} // RVA: 0x7AE15E340
        public void add_SceneUnloaded(){} // RVA: 0x7AE15E450
        public void remove_SceneUnloaded(){} // RVA: 0x7AE15E560
        public void add_ActiveSceneChanged(){} // RVA: 0x7AE15E670
        public void remove_ActiveSceneChanged(){} // RVA: 0x7AE15E780
        public void .ctor(){} // RVA: 0x7AE15E890
        public void .cctor(){} // RVA: 0x7AE15EBD0
        public void <.ctor>b__10_0(){} // RVA: 0x7AE15EC80
        public void <.ctor>b__10_1(){} // RVA: 0x7AE15ED70
        public void <.ctor>b__10_2(){} // RVA: 0x7AE15EE40
    }

    public class SceneManagerTracingAPI : SceneManagerAPI
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD87D750
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7AD87D7F0
    }

    public class SceneManagerTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7AD87D460
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ScopeObserver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADABAF10
        public void AddBreadcrumb(){} // RVA: 0x7AE164060
        public void AddBreadcrumbImpl(){} // RVA: 0x7A7E18800
        public void SetExtra(){} // RVA: 0x7AE164270
        public void SetExtraImpl(){} // RVA: 0x7A7E18890
        public void SetTag(){} // RVA: 0x7AE1645B0
        public void SetTagImpl(){} // RVA: 0x7A7E18890
        public void UnsetTag(){} // RVA: 0x7AE164790
        public void UnsetTagImpl(){} // RVA: 0x7A7E18800
        public void SetUser(){} // RVA: 0x7AE164930
        public void SetUserImpl(){} // RVA: 0x7A7E18800
        public void UnsetUserImpl(){} // RVA: 0x7A7E18770
    }

    public class ScreenshotAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE164BF0
    }

    public class ScreenshotAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetStream(){} // RVA: 0x7AE164C70
        public void GetTargetResolution(){} // RVA: 0x7AE164EC0
        public void CaptureScreenshot(){} // RVA: 0x7AE164EE0
    }

    public class ScriptableSentryUnityOptions : ScriptableObject
    {
        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x7AE1657D0
        public void get_Enabled(){} // RVA: 0x7A80F26D0
        public void set_Enabled(){} // RVA: 0x7A80F26E0
        public void get_Dsn(){} // RVA: 0x7A81052C0
        public void set_Dsn(){} // RVA: 0x7A81052D0
        public void get_CaptureInEditor(){} // RVA: 0x7A84A5BD0
        public void set_CaptureInEditor(){} // RVA: 0x7A84A5CD0
        public void get_EnableLogDebouncing(){} // RVA: 0x7A89FCA90
        public void set_EnableLogDebouncing(){} // RVA: 0x7A96C67C0
        public void get_DebounceTimeLog(){} // RVA: 0x7A8F9ACE0
        public void set_DebounceTimeLog(){} // RVA: 0x7A98B6D80
        public void get_DebounceTimeWarning(){} // RVA: 0x7A8133100
        public void set_DebounceTimeWarning(){} // RVA: 0x7A8133110
        public void get_DebounceTimeError(){} // RVA: 0x7A82C2070
        public void set_DebounceTimeError(){} // RVA: 0x7A82C0430
        public void get_TracesSampleRate(){} // RVA: 0x7AB126C30
        public void set_TracesSampleRate(){} // RVA: 0x7AB126C40
        public void get_AutoStartupTraces(){} // RVA: 0x7A8193790
        public void set_AutoStartupTraces(){} // RVA: 0x7A81937A0
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7A83F3AD0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7A83F3AC0
        public void get_AutoAwakeTraces(){} // RVA: 0x7A83F4170
        public void set_AutoAwakeTraces(){} // RVA: 0x7A83F3DC0
        public void get_AutoSessionTracking(){} // RVA: 0x7A92A8970
        public void set_AutoSessionTracking(){} // RVA: 0x7A98B2A90
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7A8178B50
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7A8178B60
        public void get_ReleaseOverride(){} // RVA: 0x7A8152D80
        public void set_ReleaseOverride(){} // RVA: 0x7A8152D90
        public void get_EnvironmentOverride(){} // RVA: 0x7A8178B90
        public void set_EnvironmentOverride(){} // RVA: 0x7A8230620
        public void get_AttachStacktrace(){} // RVA: 0x7A8359360
        public void set_AttachStacktrace(){} // RVA: 0x7A8A21900
        public void get_AttachScreenshot(){} // RVA: 0x7ACDBE8E0
        public void set_AttachScreenshot(){} // RVA: 0x7ADE0AE10
        public void get_ScreenshotQuality(){} // RVA: 0x7A835E820
        public void set_ScreenshotQuality(){} // RVA: 0x7A87A7EB0
        public void get_ScreenshotCompression(){} // RVA: 0x7A83562E0
        public void set_ScreenshotCompression(){} // RVA: 0x7A8355940
        public void get_AttachViewHierarchy(){} // RVA: 0x7A9250CD0
        public void set_AttachViewHierarchy(){} // RVA: 0x7A9A93860
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7A9A93870
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7A9A93880
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7A9A93890
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7A9A938A0
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7A8EA8210
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7A8270510
        public void get_BreadcrumbsForLogs(){} // RVA: 0x7A8EE1FF0
        public void set_BreadcrumbsForLogs(){} // RVA: 0x7AD81A310
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x7A8F12D90
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x7AE165850
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x7A8F12DA0
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x7AE165860
        public void get_BreadcrumbsForErrors(){} // RVA: 0x7AE165870
        public void set_BreadcrumbsForErrors(){} // RVA: 0x7AE165880
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x7A865DD90
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x7A9442C00
        public void get_MaxBreadcrumbs(){} // RVA: 0x7A98A0C40
        public void set_MaxBreadcrumbs(){} // RVA: 0x7AE034E90
        public void get_ReportAssembliesMode(){} // RVA: 0x7A8D6DF30
        public void set_ReportAssembliesMode(){} // RVA: 0x7A8D6DF20
        public void get_SendDefaultPii(){} // RVA: 0x7A81B7B30
        public void set_SendDefaultPii(){} // RVA: 0x7A81B7B40
        public void get_IsEnvironmentUser(){} // RVA: 0x7A8EF16D0
        public void set_IsEnvironmentUser(){} // RVA: 0x7AE165890
        public void get_EnableOfflineCaching(){} // RVA: 0x7A92494E0
        public void set_EnableOfflineCaching(){} // RVA: 0x7AE1658A0
        public void get_MaxCacheItems(){} // RVA: 0x7A897F560
        public void set_MaxCacheItems(){} // RVA: 0x7A8980300
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7AB40DAB0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7ABA6C530
        public void get_SampleRate(){} // RVA: 0x7A813FAE0
        public void set_SampleRate(){} // RVA: 0x7A813FAF0
        public void get_ShutdownTimeout(){} // RVA: 0x7A846C750
        public void set_ShutdownTimeout(){} // RVA: 0x7A869B9F0
        public void get_MaxQueueItems(){} // RVA: 0x7A9B79A20
        public void set_MaxQueueItems(){} // RVA: 0x7A9B794B0
        public void get_AnrDetectionEnabled(){} // RVA: 0x7AE1658B0
        public void set_AnrDetectionEnabled(){} // RVA: 0x7AD80C510
        public void get_AnrTimeout(){} // RVA: 0x7A9B79A40
        public void set_AnrTimeout(){} // RVA: 0x7A9B79A00
        public void get_CaptureFailedRequests(){} // RVA: 0x7A8359370
        public void set_CaptureFailedRequests(){} // RVA: 0x7A835FCA0
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7A87D9480
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7A8881790
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7A94ED040
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7A94F0290
        public void get_FilterWebExceptions(){} // RVA: 0x7ABA39120
        public void set_FilterWebExceptions(){} // RVA: 0x7ABA39130
        public void get_FilterSocketExceptions(){} // RVA: 0x7ADF94D60
        public void set_FilterSocketExceptions(){} // RVA: 0x7ADF94D70
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7ADF94D80
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7ADF94D90
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7ADF94DA0
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7ADF94DB0
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7AE1658C0
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7AE1658D0
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7AE1658E0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7AE1658F0
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7A9651770
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7A9651780
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7ADF1BDA0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7ADF1BDB0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7AE165900
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7AE165910
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7AE165920
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7AE165930
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7AE165940
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7AE165950
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x7A81426F0
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x7A8142700
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x7A82305B0
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x7A82305C0
        public void get_OptionsConfiguration(){} // RVA: 0x7A81F50F0
        public void set_OptionsConfiguration(){} // RVA: 0x7A81F5100
        public void get_Debug(){} // RVA: 0x7A90B4C50
        public void set_Debug(){} // RVA: 0x7ADF1BE00
        public void get_DebugOnlyInEditor(){} // RVA: 0x7AE165960
        public void set_DebugOnlyInEditor(){} // RVA: 0x7AE165970
        public void get_DiagnosticLevel(){} // RVA: 0x7AE165980
        public void set_DiagnosticLevel(){} // RVA: 0x7AE165990
        public void LoadSentryUnityOptions(){} // RVA: 0x7AE1659A0
        public void ToSentryUnityOptions(){} // RVA: 0x7AE165A20
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x7AE1667E0
        public void HandleExceptionFilter(){} // RVA: 0x7AE166A40
        public void ShouldDebug(){} // RVA: 0x7AE166B00
        public void .ctor(){} // RVA: 0x7AE166B20
    }

    public class SentryBuildTimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7A7E18890
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SentryCliOptions : ScriptableObject
    {
        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0x7A80F26D0
        public void set_UploadSymbols(){} // RVA: 0x7A80F26E0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x7A8475E20
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x7A8D0E640
        public void get_UploadSources(){} // RVA: 0x7A9956320
        public void set_UploadSources(){} // RVA: 0x7A99561F0
        public void get_UrlOverride(){} // RVA: 0x7A81052C0
        public void set_UrlOverride(){} // RVA: 0x7A81052D0
        public void get_Auth(){} // RVA: 0x7A8105330
        public void set_Auth(){} // RVA: 0x7A80D8E80
        public void get_Organization(){} // RVA: 0x7A83F69F0
        public void set_Organization(){} // RVA: 0x7A8105A90
        public void get_Project(){} // RVA: 0x7A8292C30
        public void set_Project(){} // RVA: 0x7A8296DE0
        public void get_IgnoreCliErrors(){} // RVA: 0x7A8193790
        public void set_IgnoreCliErrors(){} // RVA: 0x7A81937A0
        public void get_CliOptionsConfiguration(){} // RVA: 0x7A8152D80
        public void set_CliOptionsConfiguration(){} // RVA: 0x7A8152D90
        public void GetConfigPath(){} // RVA: 0x7AE167140
        public void MissingFieldWarning(){} // RVA: 0x7AE1671C0
        public void IsValid(){} // RVA: 0x7AE167280
        public void .ctor(){} // RVA: 0x7AE167410
    }

    public class SentryCliOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7AE167420
        public void Configure(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A82F4A40
        public void .cctor(){} // RVA: 0x7AE167480
    }

    public class SentryInitialization : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7AD87B790
    }

    public class SentryIntegrations : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7AD87C7B0
    }

    public class SentryMonoBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7AE167530
        public void StartAwakeSpan(){} // RVA: 0x7AE167750
        public void FinishAwakeSpan(){} // RVA: 0x7AE1678F0
        public void add_ApplicationResuming(){} // RVA: 0x7AE167970
        public void remove_ApplicationResuming(){} // RVA: 0x7AE167A60
        public void add_ApplicationPausing(){} // RVA: 0x7AE167B50
        public void remove_ApplicationPausing(){} // RVA: 0x7AE167C40
        public void get_Application(){} // RVA: 0x7AE167D30
        public void set_Application(){} // RVA: 0x7A8296DE0
        public void UpdatePauseStatus(){} // RVA: 0x7AE167DF0
        public void OnApplicationPause(){} // RVA: 0x7AE167DF0
        public void OnApplicationFocus(){} // RVA: 0x7AE167E30
        public void OnApplicationQuit(){} // RVA: 0x7AE167E70
        public void Awake(){} // RVA: 0x7AE167F10
        public void .ctor(){} // RVA: 0x7A818C250
    }

    public class SentryOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7AE167FE0
        public void Configure(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A82F4A40
        public void .cctor(){} // RVA: 0x7AE168040
        public void Template(){} // RVA: 0x7B3FB4428
    }

    public class SentryRuntimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7A7E18800
        public void .ctor(){} // RVA: 0x7A82F4A40
    }

    public class SentrySystemInfoAdapter : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void get_MainThreadId(){} // RVA: 0x7AE16B180
        public void get_OperatingSystem(){} // RVA: 0x7AE16B220
        public void get_ProcessorCount(){} // RVA: 0x7AE16B270
        public void get_SupportsVibration(){} // RVA: 0x7AE16B2F0
        public void get_DeviceType(){} // RVA: 0x7AE16B370
        public void get_CpuDescription(){} // RVA: 0x7AE16B510
        public void get_DeviceName(){} // RVA: 0x7AE16B560
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7AE16B7C0
        public void get_DeviceModel(){} // RVA: 0x7AE16B960
        public void get_SystemMemorySize(){} // RVA: 0x7AE16BB00
        public void get_GraphicsDeviceId(){} // RVA: 0x7AE16BB80
        public void get_GraphicsDeviceName(){} // RVA: 0x7AE16BC00
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7AE16BC50
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7AE16BDF0
        public void get_GraphicsMemorySize(){} // RVA: 0x7AE16BE40
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7AE16BEC0
        public void get_NpotSupport(){} // RVA: 0x7AE16C050
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7AE16C0E0
        public void get_GraphicsDeviceType(){} // RVA: 0x7AE16C130
        public void get_MaxTextureSize(){} // RVA: 0x7AE16C1C0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7AE16C240
        public void get_SupportsRayTracing(){} // RVA: 0x7AE16C2C0
        public void get_SupportsComputeShaders(){} // RVA: 0x7AE16C340
        public void get_SupportsGeometryShaders(){} // RVA: 0x7AE16C3C0
        public void get_GraphicsShaderLevel(){} // RVA: 0x7AE16C440
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7AE16C4C0
        public void get_IsDebugBuild(){} // RVA: 0x7AE16C540
        public void get_EditorVersion(){} // RVA: 0x7AE16C6D0
        public void get_InstallMode(){} // RVA: 0x7AE16C750
        public void get_TargetFrameRate(){} // RVA: 0x7AE16C810
        public void get_CopyTextureSupport(){} // RVA: 0x7AE16C9B0
        public void get_RenderingThreadingMode(){} // RVA: 0x7AE16CB50
        public void get_StartTime(){} // RVA: 0x7AE16CCF0
        public void .cctor(){} // RVA: 0x7AE16CE80
    }

    public class SentryUnity : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7AE1681E0
        public void Close(){} // RVA: 0x7AE1682E0
    }

    public class SentryUnityInfo : Object
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7A81BD750
        public void get_Il2CppMethods(){} // RVA: 0x7A80F2570
        public void SanitizeDebugId(){} // RVA: 0x7AD87BDB0
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x7AD87BE20
        public void il2cpp_gchandle_get_target(){} // RVA: 0x7AD87BE20
        public void il2cpp_free(){} // RVA: 0x7AD87BE30
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x7AD87BE40
        public void il2cpp_native_stack_trace(){} // RVA: 0x7AD87C060
        public void IsKnownPlatform(){} // RVA: 0x7AD87C070
        public void IsLinux(){} // RVA: 0x7AD87C110
        public void IsNativeSupportEnabled(){} // RVA: 0x7AD87C1A0
        public void IsSupportedBySentryNative(){} // RVA: 0x7AD87C240
        public void GetDebugImageType(){} // RVA: 0x7AD87C260
        public void .ctor(){} // RVA: 0x7AD87C330
    }

    public class SentryUnityOptions : SentryOptions
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7AE1683A0
        public void set_Enabled(){} // RVA: 0x7AE1683B0
        public void get_AutoStartupTraces(){} // RVA: 0x7AE1683C0
        public void set_AutoStartupTraces(){} // RVA: 0x7AE1683D0
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7AE1683E0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7AE1683F0
        public void get_CaptureInEditor(){} // RVA: 0x7AE168400
        public void set_CaptureInEditor(){} // RVA: 0x7AE168410
        public void get_EnableLogDebouncing(){} // RVA: 0x7AE168420
        public void set_EnableLogDebouncing(){} // RVA: 0x7AE168430
        public void get_DebounceTimeLog(){} // RVA: 0x7A8B5EC00
        public void set_DebounceTimeLog(){} // RVA: 0x7AE168440
        public void get_DebounceTimeWarning(){} // RVA: 0x7A8B65480
        public void set_DebounceTimeWarning(){} // RVA: 0x7AE168450
        public void get_DebounceTimeError(){} // RVA: 0x7A8B588B0
        public void set_DebounceTimeError(){} // RVA: 0x7AE168460
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7AE168470
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7AE168480
        public void get_AttachScreenshot(){} // RVA: 0x7AE1684A0
        public void set_AttachScreenshot(){} // RVA: 0x7AE1684B0
        public void get_AttachViewHierarchy(){} // RVA: 0x7AE1684C0
        public void set_AttachViewHierarchy(){} // RVA: 0x7AE1684D0
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7AE1684E0
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7AE1684F0
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7AE168500
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7AE168510
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7AE168520
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7AE168530
        public void get_ScreenshotQuality(){} // RVA: 0x7AE168540
        public void set_ScreenshotQuality(){} // RVA: 0x7AE168550
        public void get_ScreenshotCompression(){} // RVA: 0x7AE168560
        public void set_ScreenshotCompression(){} // RVA: 0x7AE168570
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x7A8B6CFF0
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x7A8B7A1B0
        public void get_AnrTimeout(){} // RVA: 0x7A8B625C0
        public void set_AnrTimeout(){} // RVA: 0x7AE168580
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7AE168590
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7AE1685A0
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7AE1685B0
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7AE1685C0
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7AE1685D0
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7AE1685E0
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7AE1685F0
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7AE168600
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7AE168610
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7AE168620
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7AE168630
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7AE168640
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7AE168650
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7AE168660
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7AE168670
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7AE168680
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7AE168690
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7AE1686A0
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7AE1686B0
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7AE1686C0
        public void get_StackTraceMode(){} // RVA: 0x7AE1686D0
        public void set_StackTraceMode(){} // RVA: 0x7AE1686E0
        public void get_DefaultUserId(){} // RVA: 0x7A8B66260
        public void set_DefaultUserId(){} // RVA: 0x7AE1686F0
        public void get_NativeContextWriter(){} // RVA: 0x7A8B5FD90
        public void set_NativeContextWriter(){} // RVA: 0x7A8B5F960
        public void get_NativeSupportCloseCallback(){} // RVA: 0x7A81427C0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x7A81427D0
        public void get_SdkIntegrationNames(){} // RVA: 0x7A8B48BC0
        public void set_SdkIntegrationNames(){} // RVA: 0x7A8B4C4F0
        public void .ctor(){} // RVA: 0x7AE1688E0
        public void ToString(){} // RVA: 0x7AE169690
    }

    public class SentryUnityOptionsExtensions : Object
    {
        // ── Methods ──
        public void ShouldInitializeSdk(){} // RVA: 0x7AE169980
        public void IsValid(){} // RVA: 0x7AE169B60
        public void SetupLogging(){} // RVA: 0x7AE169C40
        public void AddIl2CppExceptionProcessor(){} // RVA: 0x7AE169E30
        public void DisableUnityApplicationLoggingIntegration(){} // RVA: 0x7AE169F30
        public void DisableAnrIntegration(){} // RVA: 0x7AE169F80
        public void DisableBadGatewayExceptionFilter(){} // RVA: 0x7AE169FD0
        public void DisableWebExceptionFilter(){} // RVA: 0x7AE16A020
        public void DisableSocketExceptionFilter(){} // RVA: 0x7AE16A070
    }

    public class SentryUnitySdk : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Init(){} // RVA: 0x7AE16A0C0
        public void Close(){} // RVA: 0x7AE16A6C0
    }

    public class StartupTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7AD87C8E0
        public void AfterAssembliesLoaded(){} // RVA: 0x7AD87C9C0
        public void BeforeSplashScreen(){} // RVA: 0x7AD87CBF0
        public void BeforeSceneLoad(){} // RVA: 0x7AD87CE20
        public void AfterSceneLoad(){} // RVA: 0x7AD87D050
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class TagValueNormalizer : Object
    {
        // ── Methods ──
        public void ToTagValue(){} // RVA: 0x7AE16DE80
    }

    public class TimeDebounceBase : Object
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x7AE16D5F0
        public void Debounced(){} // RVA: 0x7AE16D6A0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class UnityEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Process(){} // RVA: 0x7AE16D820
        public void SetEventContext(){} // RVA: 0x7AE16D890
        public void PopulateDevice(){} // RVA: 0x7AE16DA80
        public void PopulateSdkIntegrations(){} // RVA: 0x7AE16DCD0
    }

    public class UnityIl2CppEventExceptionProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE158C30
        public void Process(){} // RVA: 0x7AE158F20
        public void NormalizeUuid(){} // RVA: 0x7AE15A300
        public void FindDebugImageContainingAddress(){} // RVA: 0x7AE15A3B0
        public void EnumerateChainedExceptions(){} // RVA: 0x7AE15A520
        public void GetNativeStackTrace(){} // RVA: 0x7AE15A630
        public void .cctor(){} // RVA: 0x7AE15AA50
    }

    public class UnityLogger : Object
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7AE16DEE0
        public void .ctor(){} // RVA: 0x7AE16E020
        public void Log(){} // RVA: 0x7AE16E130
        public void GetUnityLogType(){} // RVA: 0x7AE16E380
        public void ToString(){} // RVA: 0x7AE16E3B0
    }

    public class UnityScopeIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void Register(){} // RVA: 0x7AE15F2E0
    }

    public class UnityScopeUpdater : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8CE4080
        public void ConfigureScope(){} // RVA: 0x7AE15F490
        public void PopulateSdk(){} // RVA: 0x7AE15FB40
        public void PopulateApp(){} // RVA: 0x7AE15FD20
        public void PopulateOperatingSystem(){} // RVA: 0x7AE15FE80
        public void PopulateDevice(){} // RVA: 0x7AE15FF20
        public void PopulateGpu(){} // RVA: 0x7AE160480
        public void PopulateUnity(){} // RVA: 0x7AE160B90
        public void PopulateTags(){} // RVA: 0x7AE160E60
        public void PopulateUser(){} // RVA: 0x7AE161100
    }

    public class UnitySdkInfo : Object
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7AE15EFD0
        public void .cctor(){} // RVA: 0x7AE15F030
    }

    public class UnityViewHierarchyAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D8E20
        public void GetStream(){} // RVA: 0x7AE16E3F0
        public void CaptureViewHierarchy(){} // RVA: 0x7AE16E4C0
        public void CreateViewHierarchy(){} // RVA: 0x7AE16E6D0
        public void CreateNode(){} // RVA: 0x7AE16EB10
    }

    public class UnityViewHierarchyNode : ViewHierarchyNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7A81052C0
        public void set_Tag(){} // RVA: 0x7A81052D0
        public void get_Position(){} // RVA: 0x7A8105330
        public void set_Position(){} // RVA: 0x7A80D8E80
        public void get_Rotation(){} // RVA: 0x7A83F69F0
        public void set_Rotation(){} // RVA: 0x7A8105A90
        public void get_Scale(){} // RVA: 0x7A8292C30
        public void set_Scale(){} // RVA: 0x7A8296DE0
        public void get_Active(){} // RVA: 0x7AC2B74D0
        public void set_Active(){} // RVA: 0x7AE16F3A0
        public void get_Extras(){} // RVA: 0x7A8152D80
        public void set_Extras(){} // RVA: 0x7A8152D90
        public void .ctor(){} // RVA: 0x7A813E420
        public void WriteAdditionalProperties(){} // RVA: 0x7AE16F3B0
    }

    public class UnityWebRequestTransport : HttpTransportBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE16FB40
        public void SendEnvelopeAsync(){} // RVA: 0x7AE16FBC0
        public void CreateWebRequest(){} // RVA: 0x7AE16FCC0
        public void GetResponse(){} // RVA: 0x7AE170260
    }

    public class WarningTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A97242F0
    }

    public class WebBackgroundWorker : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE16F7D0
        public void EnqueueEnvelope(){} // RVA: 0x7AE16F960
        public void FlushAsync(){} // RVA: 0x7AE16FAA0
        public void get_QueuedItems(){} // RVA: 0x7A851DB90
    }

}