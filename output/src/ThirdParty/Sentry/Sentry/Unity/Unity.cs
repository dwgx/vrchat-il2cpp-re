// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 54
// Methods: 582

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Register(){} // RVA: 0x7FFAF8E1FBB0
        public void .cctor(){} // RVA: 0x7FFAF8E201F0
    }

    public class AnrWatchDog
    {
        // ── Methods ──
        public void add_OnApplicationNotResponding(){} // RVA: 0x7FFAF8E202C0
        public void remove_OnApplicationNotResponding(){} // RVA: 0x7FFAF8E203C0
        public void get_Paused(){} // RVA: 0x7FFAF2DB3450
        public void set_Paused(){} // RVA: 0x7FFAF2DB3460
        public void .ctor(){} // RVA: 0x7FFAF8E204C0
        public void Stop(){} // RVA: 0x7FFAF2AD5130
        public void Report(){} // RVA: 0x7FFAF8E209B0
        public void <.ctor>b__11_0(){} // RVA: 0x7FFAF4265330
        public void <.ctor>b__11_1(){} // RVA: 0x7FFAF30D05A0
        public void <.ctor>b__11_2(){} // RVA: 0x7FFAF8E20B50
    }

    public class AnrWatchDogMultiThreaded
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E20C10
        public void Stop(){} // RVA: 0x7FFAF8E20EE0
        public void UpdateUiStatus(){} // RVA: 0x7FFAF8E20F10
        public void Run(){} // RVA: 0x7FFAF8E20FB0
    }

    public class AnrWatchDogSingleThreaded
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E214D0
        public void Stop(){} // RVA: 0x7FFAF35B4010
        public void UpdateUiStatus(){} // RVA: 0x7FFAF8E216B0
    }

    public class ContextWriter
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAF8E1B570
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ErrorTimeDebounce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4417700
    }

    public class IEventCapture
    {
        // ── Methods ──
        public void Capture(){}
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFAF2AD4B10
        public void remove_SceneLoaded(){} // RVA: 0x7FFAF2AD4B10
        public void add_SceneUnloaded(){} // RVA: 0x7FFAF2AD4B10
        public void remove_SceneUnloaded(){} // RVA: 0x7FFAF2AD4B10
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFAF2AD4B10
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISentrySystemInfo
    {
        public object get_SupportsVibration;
        public object get_SystemMemorySize;

        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7FFAF2ABCD60
        public void get_OperatingSystem(){} // RVA: 0x7FFAF2ABCD60
        public void get_ProcessorCount(){} // RVA: 0x7FFAF2ABCD60
        public void get_SupportsVibration(){} // RVA: 0x7FFAF2ABCC90
        public void get_DeviceType(){} // RVA: 0x7FFAF2ABCD60
        public void get_CpuDescription(){} // RVA: 0x7FFAF2ABCD60
        public void get_DeviceName(){} // RVA: 0x7FFAF2ABCD60
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAF2ABCD60
        public void get_DeviceModel(){} // RVA: 0x7FFAF2ABCD60
        public void get_SystemMemorySize(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFAF2ABCD60
        public void get_NpotSupport(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFAF2ABCD60
        public void get_MaxTextureSize(){} // RVA: 0x7FFAF2ABCD60
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAF2ABCC90
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAF2ABCC90
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAF2ABCC90
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAF2ABCC90
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAF2ABCD60
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7FFAF2ABCC90
        public void get_IsDebugBuild(){} // RVA: 0x7FFAF2ABCD60
        public void get_EditorVersion(){} // RVA: 0x7FFAF2ABCD60
        public void get_InstallMode(){} // RVA: 0x7FFAF2ABCD60
        public void get_TargetFrameRate(){} // RVA: 0x7FFAF2ABCD60
        public void get_CopyTextureSupport(){} // RVA: 0x7FFAF2ABCD60
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFAF2ABCD60
        public void get_StartTime(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISentryUnityInfo
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFAF2ABDBE0
        public void get_Il2CppMethods(){} // RVA: 0x7FFAF2ABCD60
        public void IsKnownPlatform(){} // RVA: 0x7FFAF2ABDBE0
        public void IsLinux(){} // RVA: 0x7FFAF2ABDBE0
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFAF2AC0840
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFAF2ABE1F0
        public void GetDebugImageType(){} // RVA: 0x7FFAF2ACBCC0
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class Il2CppFree
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF49104F0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
        public void BeginInvoke(){} // RVA: 0x7FFAF8E24A80
        public void EndInvoke(){} // RVA: 0x7FFAF2D8ECB0
    }

    public class Il2CppGcHandleGetTarget
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF5E1B8D0
        public void Invoke(){} // RVA: 0x7FFAF2DE8C60
        public void BeginInvoke(){} // RVA: 0x7FFAF8E24840
        public void EndInvoke(){} // RVA: 0x7FFAF4AE56F0
    }

    public class Il2CppMethods
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2E6CE00
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x7FFAF2DA8380
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x7FFAF2D907C0
        public void get_Il2CppFree(){} // RVA: 0x7FFAF2DBB0C0
    }

    public class Il2CppNativeStackTrace
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E248C0
        public void Invoke(){} // RVA: 0x7FFAF5DCB260
        public void BeginInvoke(){} // RVA: 0x7FFAF8E24990
        public void EndInvoke(){} // RVA: 0x7FFAF709E930
    }

    public class LogTimeDebounce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4417700
    }

    public class MainThreadData
    {
        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7FFAF8E24B00
        public void set_MainThreadId(){} // RVA: 0x7FFAF8E24B40
        public void get_OperatingSystem(){} // RVA: 0x7FFAF8E24B90
        public void set_OperatingSystem(){} // RVA: 0x7FFAF8E24BD0
        public void get_ProcessorCount(){} // RVA: 0x7FFAF8E24C70
        public void set_ProcessorCount(){} // RVA: 0x7FFAF8E24CB0
        public void get_SupportsVibration(){} // RVA: 0x7FFAF8E24D00
        public void set_SupportsVibration(){} // RVA: 0x7FFAF8E24D40
        public void get_DeviceType(){} // RVA: 0x7FFAF8E24D90
        public void set_DeviceType(){} // RVA: 0x7FFAF8E24DD0
        public void get_CpuDescription(){} // RVA: 0x7FFAF8E24E70
        public void set_CpuDescription(){} // RVA: 0x7FFAF8E24EB0
        public void get_DeviceName(){} // RVA: 0x7FFAF8E24F50
        public void set_DeviceName(){} // RVA: 0x7FFAF8E24F90
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAF8E25030
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x7FFAF8E25070
        public void get_DeviceModel(){} // RVA: 0x7FFAF8E25110
        public void set_DeviceModel(){} // RVA: 0x7FFAF8E25150
        public void get_SystemMemorySize(){} // RVA: 0x7FFAF8E251F0
        public void set_SystemMemorySize(){} // RVA: 0x7FFAF8E25230
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFAF8E25280
        public void set_GraphicsDeviceId(){} // RVA: 0x7FFAF8E252C0
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFAF8E25310
        public void set_GraphicsDeviceName(){} // RVA: 0x7FFAF8E25350
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFAF8E253F0
        public void set_GraphicsDeviceVendorId(){} // RVA: 0x7FFAF8E25430
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFAF8E254D0
        public void set_GraphicsDeviceVendor(){} // RVA: 0x7FFAF8E25510
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFAF8E255B0
        public void set_GraphicsMemorySize(){} // RVA: 0x7FFAF8E255F0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFAF8E25640
        public void set_GraphicsMultiThreaded(){} // RVA: 0x7FFAF8E25680
        public void get_NpotSupport(){} // RVA: 0x7FFAF8E256D0
        public void set_NpotSupport(){} // RVA: 0x7FFAF8E25710
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFAF8E257B0
        public void set_GraphicsDeviceVersion(){} // RVA: 0x7FFAF8E257F0
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFAF8E25890
        public void set_GraphicsDeviceType(){} // RVA: 0x7FFAF8E258D0
        public void get_MaxTextureSize(){} // RVA: 0x7FFAF8E25970
        public void set_MaxTextureSize(){} // RVA: 0x7FFAF8E259B0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAF8E25A00
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x7FFAF8E25A40
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAF8E25A90
        public void set_SupportsRayTracing(){} // RVA: 0x7FFAF8E25AD0
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAF8E25B20
        public void set_SupportsComputeShaders(){} // RVA: 0x7FFAF8E25B60
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAF8E25BB0
        public void set_SupportsGeometryShaders(){} // RVA: 0x7FFAF8E25BF0
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAF8E25C40
        public void set_GraphicsShaderLevel(){} // RVA: 0x7FFAF8E25C80
        public void get_IsDebugBuild(){} // RVA: 0x7FFAF8E25CD0
        public void set_IsDebugBuild(){} // RVA: 0x7FFAF8E25D10
        public void get_EditorVersion(){} // RVA: 0x7FFAF8E25D60
        public void set_EditorVersion(){} // RVA: 0x7FFAF8E25DA0
        public void get_InstallMode(){} // RVA: 0x7FFAF8E25E40
        public void set_InstallMode(){} // RVA: 0x7FFAF8E25E80
        public void get_TargetFrameRate(){} // RVA: 0x7FFAF8E25F20
        public void set_TargetFrameRate(){} // RVA: 0x7FFAF8E25F60
        public void get_CopyTextureSupport(){} // RVA: 0x7FFAF8E26000
        public void set_CopyTextureSupport(){} // RVA: 0x7FFAF8E26040
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFAF8E260E0
        public void set_RenderingThreadingMode(){} // RVA: 0x7FFAF8E26120
        public void get_StartTime(){} // RVA: 0x7FFAF8E261C0
        public void set_StartTime(){} // RVA: 0x7FFAF8E26220
        public void IsMainThread(){} // RVA: 0x7FFAF8E26280
        public void get_SentrySystemInfo(){} // RVA: 0x7FFAF8E263A0
        public void set_SentrySystemInfo(){} // RVA: 0x7FFAF8E263E0
        public void CollectData(){} // RVA: 0x7FFAF8E26480
    }

    public class NativeStackTrace
    {
        // ── Methods ──
        public void get_Frames(){} // RVA: 0x7FFAF2DA8380
        public void set_Frames(){} // RVA: 0x7FFAF2D8EE30
        public void get_ImageUuid(){} // RVA: 0x7FFAF2D907C0
        public void set_ImageUuid(){} // RVA: 0x7FFAF2DF3E80
        public void get_ImageName(){} // RVA: 0x7FFAF2DBB0C0
        public void set_ImageName(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF8E1FB20
    }

    public class SceneAdapter
    {
        public object Version;

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAF4584690
        public void .ctor(){} // RVA: 0x7FFAF3ABA2F0
    }

    public class SceneManagerAdapter
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFAF8E21950
        public void remove_SceneLoaded(){} // RVA: 0x7FFAF8E21A50
        public void add_SceneUnloaded(){} // RVA: 0x7FFAF8E21B50
        public void remove_SceneUnloaded(){} // RVA: 0x7FFAF8E21C50
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFAF8E21D50
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFAF8E21E50
        public void .ctor(){} // RVA: 0x7FFAF8E21F50
        public void .cctor(){} // RVA: 0x7FFAF8E22290
        public void <.ctor>b__10_0(){} // RVA: 0x7FFAF8E22340
        public void <.ctor>b__10_1(){} // RVA: 0x7FFAF8E22430
        public void <.ctor>b__10_2(){} // RVA: 0x7FFAF8E22500
    }

    public class SceneManagerTracingAPI
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF85409B0
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7FFAF8540A50
    }

    public class SceneManagerTracingIntegration : kA
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAF85406C0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class ScopeObserver
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF877CD00
        public void AddBreadcrumb(){} // RVA: 0x7FFAF8E27720
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFAF2AD4B10
        public void SetExtra(){} // RVA: 0x7FFAF8E27930
        public void SetExtraImpl(){} // RVA: 0x7FFAF2ADDC60
        public void SetTag(){} // RVA: 0x7FFAF8E27C70
        public void SetTagImpl(){} // RVA: 0x7FFAF2ADDC60
        public void UnsetTag(){} // RVA: 0x7FFAF8E27E50
        public void UnsetTagImpl(){} // RVA: 0x7FFAF2AD4B10
        public void SetUser(){} // RVA: 0x7FFAF8E27FF0
        public void SetUserImpl(){} // RVA: 0x7FFAF2AD4B10
        public void UnsetUserImpl(){} // RVA: 0x7FFAF2AD4A50
    }

    public class ScreenshotAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E282B0
    }

    public class ScreenshotAttachmentContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetStream(){} // RVA: 0x7FFAF8E28330
        public void GetTargetResolution(){} // RVA: 0x7FFAF8E28580
        public void CaptureScreenshot(){} // RVA: 0x7FFAF8E285A0
    }

    public class ScriptableSentryUnityOptions
    {
        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x7FFAF8E28E90
        public void get_Enabled(){} // RVA: 0x7FFAF2DA84E0
        public void set_Enabled(){} // RVA: 0x7FFAF2DA84F0
        public void get_Dsn(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Dsn(){} // RVA: 0x7FFAF2DBB0D0
        public void get_CaptureInEditor(){} // RVA: 0x7FFAF3198A80
        public void set_CaptureInEditor(){} // RVA: 0x7FFAF3198B80
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFAF36E6000
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFAF43BAB20
        public void get_DebounceTimeLog(){} // RVA: 0x7FFAF3CB9F00
        public void set_DebounceTimeLog(){} // RVA: 0x7FFAF45ACF60
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFAF2DE8CD0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFAF2DE8CE0
        public void get_DebounceTimeError(){} // RVA: 0x7FFAF2F76670
        public void set_DebounceTimeError(){} // RVA: 0x7FFAF2F75F20
        public void get_TracesSampleRate(){} // RVA: 0x7FFAF5DDF490
        public void set_TracesSampleRate(){} // RVA: 0x7FFAF5DDF4A0
        public void get_AutoStartupTraces(){} // RVA: 0x7FFAF2E48C00
        public void set_AutoStartupTraces(){} // RVA: 0x7FFAF2E48C10
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFAF310EEC0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFAF310EEB0
        public void get_AutoAwakeTraces(){} // RVA: 0x7FFAF310F560
        public void set_AutoAwakeTraces(){} // RVA: 0x7FFAF310F1B0
        public void get_AutoSessionTracking(){} // RVA: 0x7FFAF3FC4560
        public void set_AutoSessionTracking(){} // RVA: 0x7FFAF45A8C50
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFAF2E2E0A0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFAF2E2E0B0
        public void get_ReleaseOverride(){} // RVA: 0x7FFAF2E08730
        public void set_ReleaseOverride(){} // RVA: 0x7FFAF2E08740
        public void get_EnvironmentOverride(){} // RVA: 0x7FFAF2E2E0E0
        public void set_EnvironmentOverride(){} // RVA: 0x7FFAF2EE54D0
        public void get_AttachStacktrace(){} // RVA: 0x7FFAF304FF30
        public void set_AttachStacktrace(){} // RVA: 0x7FFAF370F680
        public void get_AttachScreenshot(){} // RVA: 0x7FFAF7A94B90
        public void set_AttachScreenshot(){} // RVA: 0x7FFAF8ACE3A0
        public void get_ScreenshotQuality(){} // RVA: 0x7FFAF30554D0
        public void set_ScreenshotQuality(){} // RVA: 0x7FFAF349ACA0
        public void get_ScreenshotCompression(){} // RVA: 0x7FFAF304CEC0
        public void set_ScreenshotCompression(){} // RVA: 0x7FFAF304C530
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFAF3F48640
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFAF4741430
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAF4741440
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAF4741450
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAF4741460
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAF4741470
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFAF3B95CF0
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFAF2F25080
        public void get_BreadcrumbsForLogs(){} // RVA: 0x7FFAF3BD0170
        public void set_BreadcrumbsForLogs(){} // RVA: 0x7FFAF84DDFE0
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x7FFAF3C0F200
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x7FFAF8E28F10
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x7FFAF3C10850
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x7FFAF8E28F20
        public void get_BreadcrumbsForErrors(){} // RVA: 0x7FFAF8E28F30
        public void set_BreadcrumbsForErrors(){} // RVA: 0x7FFAF8E28F40
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x7FFAF33510E0
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x7FFAF4138890
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAF4596E60
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFAF8CF8F70
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAF3A74570
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFAF3A74560
        public void get_SendDefaultPii(){} // RVA: 0x7FFAF2E6CCE0
        public void set_SendDefaultPii(){} // RVA: 0x7FFAF2E6CCF0
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFAF3BE2B00
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFAF8E28F50
        public void get_EnableOfflineCaching(){} // RVA: 0x7FFAF3F40E50
        public void set_EnableOfflineCaching(){} // RVA: 0x7FFAF8E28F60
        public void get_MaxCacheItems(){} // RVA: 0x7FFAF36690C0
        public void set_MaxCacheItems(){} // RVA: 0x7FFAF3669E60
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFAF60EA7C0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFAF672AFE0
        public void get_SampleRate(){} // RVA: 0x7FFAF2DF5540
        public void set_SampleRate(){} // RVA: 0x7FFAF2DF5550
        public void get_ShutdownTimeout(){} // RVA: 0x7FFAF315FD30
        public void set_ShutdownTimeout(){} // RVA: 0x7FFAF338F350
        public void get_MaxQueueItems(){} // RVA: 0x7FFAF4826570
        public void set_MaxQueueItems(){} // RVA: 0x7FFAF4826000
        public void get_AnrDetectionEnabled(){} // RVA: 0x7FFAF8E28F70
        public void set_AnrDetectionEnabled(){} // RVA: 0x7FFAF84D0170
        public void get_AnrTimeout(){} // RVA: 0x7FFAF4826590
        public void set_AnrTimeout(){} // RVA: 0x7FFAF4826550
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAF304FF40
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFAF3056940
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFAF34CC130
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFAF3595030
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFAF41E23D0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFAF41E5610
        public void get_FilterWebExceptions(){} // RVA: 0x7FFAF66F9C40
        public void set_FilterWebExceptions(){} // RVA: 0x7FFAF66F9C50
        public void get_FilterSocketExceptions(){} // RVA: 0x7FFAF8C585F0
        public void set_FilterSocketExceptions(){} // RVA: 0x7FFAF8C58600
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFAF8C58610
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFAF8C58620
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAF8C58630
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAF8C58640
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFAF8E28F80
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFAF8E28F90
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFAF8E28FA0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFAF8E28FB0
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFAF4346340
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFAF4346350
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAF8BDFAC0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAF8BDFAD0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFAF8E28FC0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFAF8E28FD0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAF8E28FE0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAF8E28FF0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAF8E29000
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAF8E29010
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x7FFAF2DF8120
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x7FFAF2DF8130
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFAF2EE5460
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFAF2EE5470
        public void get_OptionsConfiguration(){} // RVA: 0x7FFAF2EAA100
        public void set_OptionsConfiguration(){} // RVA: 0x7FFAF2EAA110
        public void get_Debug(){} // RVA: 0x7FFAF3DAD610
        public void set_Debug(){} // RVA: 0x7FFAF8BDFB20
        public void get_DebugOnlyInEditor(){} // RVA: 0x7FFAF8E29020
        public void set_DebugOnlyInEditor(){} // RVA: 0x7FFAF8E29030
        public void get_DiagnosticLevel(){} // RVA: 0x7FFAF8E29040
        public void set_DiagnosticLevel(){} // RVA: 0x7FFAF8E29050
        public void LoadSentryUnityOptions(){} // RVA: 0x7FFAF8E29060
        public void ToSentryUnityOptions(){} // RVA: 0x7FFAF8E290E0
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x7FFAF8E29E80
        public void HandleExceptionFilter(){} // RVA: 0x7FFAF8E2A0E0
        public void ShouldDebug(){} // RVA: 0x7FFAF8E2A1A0
        public void .ctor(){} // RVA: 0x7FFAF8E2A1C0
    }

    public class SentryBuildTimeOptionsConfiguration
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAF2ADDC60
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SentryCliOptions
    {
        public object ShouldApplyVolume;
        public object ShouldApplyPitch;
        public object ShouldApplyClip;
        public object ShouldApplyLoop;
        public object debugString;
        public object initialized;

        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0x7FFAF2DA84E0
        public void set_UploadSymbols(){} // RVA: 0x7FFAF2DA84F0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x7FFAF31693D0
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x7FFAF39F3D70
        public void get_UploadSources(){} // RVA: 0x7FFAF4648340
        public void set_UploadSources(){} // RVA: 0x7FFAF4648210
        public void get_UrlOverride(){} // RVA: 0x7FFAF2DBB0C0
        public void set_UrlOverride(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Auth(){} // RVA: 0x7FFAF2DBB130
        public void set_Auth(){} // RVA: 0x7FFAF2D8EE90
        public void get_Organization(){} // RVA: 0x7FFAF30E74D0
        public void set_Organization(){} // RVA: 0x7FFAF2DBB890
        public void get_Project(){} // RVA: 0x7FFAF2F476A0
        public void set_Project(){} // RVA: 0x7FFAF2F4B830
        public void get_IgnoreCliErrors(){} // RVA: 0x7FFAF2E48C00
        public void set_IgnoreCliErrors(){} // RVA: 0x7FFAF2E48C10
        public void get_CliOptionsConfiguration(){} // RVA: 0x7FFAF2E08730
        public void set_CliOptionsConfiguration(){} // RVA: 0x7FFAF2E08740
        public void GetConfigPath(){} // RVA: 0x7FFAF8E2A7E0
        public void MissingFieldWarning(){} // RVA: 0x7FFAF8E2A860
        public void IsValid(){} // RVA: 0x7FFAF8E2A920
        public void .ctor(){} // RVA: 0x7FFAF8E2AAB0
    }

    public class SentryCliOptionsConfiguration
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFAF8E2AAC0
        public void Configure(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
        public void .cctor(){} // RVA: 0x7FFAF8E2AB20
    }

    public class SentryInitialization
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF853E9E0
    }

    public class SentryIntegrations
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAF853FA10
    }

    public class SentryMonoBehaviour
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAF8E2ABD0
        public void StartAwakeSpan(){} // RVA: 0x7FFAF8E2ADF0
        public void FinishAwakeSpan(){} // RVA: 0x7FFAF8E2AF90
        public void add_ApplicationResuming(){} // RVA: 0x7FFAF8E2B010
        public void remove_ApplicationResuming(){} // RVA: 0x7FFAF8E2B100
        public void add_ApplicationPausing(){} // RVA: 0x7FFAF8E2B1F0
        public void remove_ApplicationPausing(){} // RVA: 0x7FFAF8E2B2E0
        public void get_Application(){} // RVA: 0x7FFAF8E2B3D0
        public void set_Application(){} // RVA: 0x7FFAF2F4B830
        public void UpdatePauseStatus(){} // RVA: 0x7FFAF8E2B490
        public void OnApplicationPause(){} // RVA: 0x7FFAF8E2B490
        public void OnApplicationFocus(){} // RVA: 0x7FFAF8E2B4D0
        public void OnApplicationQuit(){} // RVA: 0x7FFAF8E2B510
        public void Awake(){} // RVA: 0x7FFAF8E2B5B0
        public void .ctor(){} // RVA: 0x7FFAF2E41710
    }

    public class SentryOptionsConfiguration
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFAF8E2B680
        public void Configure(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
        public void .cctor(){} // RVA: 0x7FFAF8E2B6E0
    }

    public class SentryRuntimeOptionsConfiguration
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAF2AD4B10
        public void .ctor(){} // RVA: 0x7FFAF2FEBFB0
    }

    public class SentrySystemInfoAdapter
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void get_MainThreadId(){} // RVA: 0x7FFAF8E2E830
        public void get_OperatingSystem(){} // RVA: 0x7FFAF8E2E8D0
        public void get_ProcessorCount(){} // RVA: 0x7FFAF8E2E920
        public void get_SupportsVibration(){} // RVA: 0x7FFAF8E2E9A0
        public void get_DeviceType(){} // RVA: 0x7FFAF8E2EA20
        public void get_CpuDescription(){} // RVA: 0x7FFAF8E2EBC0
        public void get_DeviceName(){} // RVA: 0x7FFAF8E2EC10
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAF8E2EE70
        public void get_DeviceModel(){} // RVA: 0x7FFAF8E2F010
        public void get_SystemMemorySize(){} // RVA: 0x7FFAF8E2F1B0
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFAF8E2F230
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFAF8E2F2B0
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFAF8E2F300
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFAF8E2F4A0
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFAF8E2F4F0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFAF8E2F570
        public void get_NpotSupport(){} // RVA: 0x7FFAF8E2F700
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFAF8E2F790
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFAF8E2F7E0
        public void get_MaxTextureSize(){} // RVA: 0x7FFAF8E2F870
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAF8E2F8F0
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAF8E2F970
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAF8E2F9F0
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAF8E2FA70
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAF8E2FAF0
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7FFAF8E2FB70
        public void get_IsDebugBuild(){} // RVA: 0x7FFAF8E2FBF0
        public void get_EditorVersion(){} // RVA: 0x7FFAF8E2FD80
        public void get_InstallMode(){} // RVA: 0x7FFAF8E2FE00
        public void get_TargetFrameRate(){} // RVA: 0x7FFAF8E2FEC0
        public void get_CopyTextureSupport(){} // RVA: 0x7FFAF8E30060
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFAF8E30200
        public void get_StartTime(){} // RVA: 0x7FFAF8E303A0
        public void .cctor(){} // RVA: 0x7FFAF8E30530
    }

    public class SentryUnity
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF8E2B880 | overloaded x2
        public void Close(){} // RVA: 0x7FFAF8E2B980
    }

    public class SentryUnityInfo
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFAF2E72850
        public void get_Il2CppMethods(){} // RVA: 0x7FFAF2DA8380
        public void SanitizeDebugId(){} // RVA: 0x7FFAF853F000
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x7FFAF853F070
        public void il2cpp_gchandle_get_target(){} // RVA: 0x7FFAF853F070
        public void il2cpp_free(){} // RVA: 0x7FFAF853F080
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x7FFAF853F090
        public void il2cpp_native_stack_trace(){} // RVA: 0x7FFAF853F2C0
        public void IsKnownPlatform(){} // RVA: 0x7FFAF853F2D0
        public void IsLinux(){} // RVA: 0x7FFAF853F370
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFAF853F400
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFAF853F4A0
        public void GetDebugImageType(){} // RVA: 0x7FFAF853F4C0
        public void .ctor(){} // RVA: 0x7FFAF853F590
    }

    public class SentryUnityOptions
    {
        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFAF8E2BA40
        public void set_Enabled(){} // RVA: 0x7FFAF8E2BA50
        public void get_AutoStartupTraces(){} // RVA: 0x7FFAF8E2BA60
        public void set_AutoStartupTraces(){} // RVA: 0x7FFAF8E2BA70
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFAF8E2BA80
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFAF8E2BA90
        public void get_CaptureInEditor(){} // RVA: 0x7FFAF8E2BAA0
        public void set_CaptureInEditor(){} // RVA: 0x7FFAF8E2BAB0
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFAF8E2BAC0
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFAF8E2BAD0
        public void get_DebounceTimeLog(){} // RVA: 0x7FFAF384AA90
        public void set_DebounceTimeLog(){} // RVA: 0x7FFAF8E2BAE0
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFAF3850DF0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFAF8E2BAF0
        public void get_DebounceTimeError(){} // RVA: 0x7FFAF3844B80
        public void set_DebounceTimeError(){} // RVA: 0x7FFAF8E2BB00
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFAF8E2BB10
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFAF8E2BB20
        public void get_AttachScreenshot(){} // RVA: 0x7FFAF8E2BB40
        public void set_AttachScreenshot(){} // RVA: 0x7FFAF8E2BB50
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFAF8E2BB60
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFAF8E2BB70
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAF8E2BB80
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAF8E2BB90
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAF8E2BBA0
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAF8E2BBB0
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFAF8E2BBC0
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFAF8E2BBD0
        public void get_ScreenshotQuality(){} // RVA: 0x7FFAF8E2BBE0
        public void set_ScreenshotQuality(){} // RVA: 0x7FFAF8E2BBF0
        public void get_ScreenshotCompression(){} // RVA: 0x7FFAF8E2BC00
        public void set_ScreenshotCompression(){} // RVA: 0x7FFAF8E2BC10
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x7FFAF3858080
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x7FFAF3864D00
        public void get_AnrTimeout(){} // RVA: 0x7FFAF384E220
        public void set_AnrTimeout(){} // RVA: 0x7FFAF8E2BC20
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFAF8E2BC30
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFAF8E2BC40
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BC50
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BC60
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BC70
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BC80
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFAF8E2BC90
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFAF8E2BCA0
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFAF8E2BCB0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFAF8E2BCC0
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BCD0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BCE0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BCF0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BD00
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BD10
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAF8E2BD20
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAF8E2BD30
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAF8E2BD40
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFAF8E2BD50
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFAF8E2BD60
        public void get_StackTraceMode(){} // RVA: 0x7FFAF8E2BD70
        public void set_StackTraceMode(){} // RVA: 0x7FFAF8E2BD80
        public void get_DefaultUserId(){} // RVA: 0x7FFAF3851AE0
        public void set_DefaultUserId(){} // RVA: 0x7FFAF8E2BD90
        public void get_NativeContextWriter(){} // RVA: 0x7FFAF384BC90
        public void set_NativeContextWriter(){} // RVA: 0x7FFAF384B860
        public void get_NativeSupportCloseCallback(){} // RVA: 0x7FFAF2DF81F0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x7FFAF2DF8200
        public void get_SdkIntegrationNames(){} // RVA: 0x7FFAF3835910
        public void set_SdkIntegrationNames(){} // RVA: 0x7FFAF38393E0
        public void .ctor(){} // RVA: 0x7FFAF8E2BF90 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAF8E2CD40
    }

    public class SentryUnityOptionsExtensions
    {
        // ── Methods ──
        public void ShouldInitializeSdk(){} // RVA: 0x7FFAF8E2D030 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAF8E2D210
        public void SetupLogging(){} // RVA: 0x7FFAF8E2D2F0
        public void AddIl2CppExceptionProcessor(){} // RVA: 0x7FFAF8E2D4E0
        public void DisableUnityApplicationLoggingIntegration(){} // RVA: 0x7FFAF8E2D5E0
        public void DisableAnrIntegration(){} // RVA: 0x7FFAF8E2D630
        public void DisableBadGatewayExceptionFilter(){} // RVA: 0x7FFAF8E2D680
        public void DisableWebExceptionFilter(){} // RVA: 0x7FFAF8E2D6D0
        public void DisableSocketExceptionFilter(){} // RVA: 0x7FFAF8E2D720
    }

    public class SentryUnitySdk
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Init(){} // RVA: 0x7FFAF8E2D770
        public void Close(){} // RVA: 0x7FFAF8E2DD70
    }

    public class StartupTracingIntegration
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAF853FB40
        public void AfterAssembliesLoaded(){} // RVA: 0x7FFAF853FC20
        public void BeforeSplashScreen(){} // RVA: 0x7FFAF853FE50
        public void BeforeSceneLoad(){} // RVA: 0x7FFAF8540080
        public void AfterSceneLoad(){} // RVA: 0x7FFAF85402B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class TagValueNormalizer
    {
        // ── Methods ──
        public void ToTagValue(){} // RVA: 0x7FFAF8E31520
    }

    public class TimeDebounceBase
    {
        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFAF8E30CA0
        public void Debounced(){} // RVA: 0x7FFAF8E30D50
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class UnityEventProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Process(){} // RVA: 0x7FFAF8E30ED0 | overloaded x2
        public void SetEventContext(){} // RVA: 0x7FFAF8E30F40
        public void PopulateDevice(){} // RVA: 0x7FFAF8E31130
        public void PopulateSdkIntegrations(){} // RVA: 0x7FFAF8E31380
    }

    public class UnityIl2CppEventExceptionProcessor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E1C4C0
        public void Process(){} // RVA: 0x7FFAF8E1C7B0
        public void NormalizeUuid(){} // RVA: 0x7FFAF8E1DB90
        public void FindDebugImageContainingAddress(){} // RVA: 0x7FFAF8E1DC40
        public void EnumerateChainedExceptions(){} // RVA: 0x7FFAF8E1DDB0
        public void GetNativeStackTrace(){} // RVA: 0x7FFAF8E1DEC0
        public void .cctor(){} // RVA: 0x7FFAF8E1E2E0
    }

    public class UnityLogger : IsEnabled
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFAF8E31580
        public void .ctor(){} // RVA: 0x7FFAF8E316C0 | overloaded x2
        public void Log(){} // RVA: 0x7FFAF8E317D0
        public void GetUnityLogType(){} // RVA: 0x7FFAF8E31A20
        public void ToString(){} // RVA: 0x7FFAF8E31A50
    }

    public class UnityScopeIntegration : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Register(){} // RVA: 0x7FFAF8E229A0
    }

    public class UnityScopeUpdater
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF39C9AE0
        public void ConfigureScope(){} // RVA: 0x7FFAF8E22B50
        public void PopulateSdk(){} // RVA: 0x7FFAF8E23200
        public void PopulateApp(){} // RVA: 0x7FFAF8E233E0
        public void PopulateOperatingSystem(){} // RVA: 0x7FFAF8E23540
        public void PopulateDevice(){} // RVA: 0x7FFAF8E235E0
        public void PopulateGpu(){} // RVA: 0x7FFAF8E23B40
        public void PopulateUnity(){} // RVA: 0x7FFAF8E24250
        public void PopulateTags(){} // RVA: 0x7FFAF8E24520
        public void PopulateUser(){} // RVA: 0x7FFAF8E247C0
    }

    public class UnitySdkInfo
    {
        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFAF8E22690
        public void .cctor(){} // RVA: 0x7FFAF8E226F0
    }

    public class UnityViewHierarchyAttachmentContent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void GetStream(){} // RVA: 0x7FFAF8E31A90
        public void CaptureViewHierarchy(){} // RVA: 0x7FFAF8E31B60
        public void CreateViewHierarchy(){} // RVA: 0x7FFAF8E31D70
        public void CreateNode(){} // RVA: 0x7FFAF8E32190
    }

    public class UnityViewHierarchyNode
    {
        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Tag(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Position(){} // RVA: 0x7FFAF2DBB130
        public void set_Position(){} // RVA: 0x7FFAF2D8EE90
        public void get_Rotation(){} // RVA: 0x7FFAF30E74D0
        public void set_Rotation(){} // RVA: 0x7FFAF2DBB890
        public void get_Scale(){} // RVA: 0x7FFAF2F476A0
        public void set_Scale(){} // RVA: 0x7FFAF2F4B830
        public void get_Active(){} // RVA: 0x7FFAF6F7B950
        public void set_Active(){} // RVA: 0x7FFAF8E32A00
        public void get_Extras(){} // RVA: 0x7FFAF2E08730
        public void set_Extras(){} // RVA: 0x7FFAF2E08740
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80
        public void WriteAdditionalProperties(){} // RVA: 0x7FFAF8E32A10
    }

    public class UnityWebRequestTransport
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E33170
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAF8E331F0
        public void CreateWebRequest(){} // RVA: 0x7FFAF8E332F0
        public void GetResponse(){} // RVA: 0x7FFAF8E33890
    }

    public class WarningTimeDebounce
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4417700
    }

    public class WebBackgroundWorker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8E32E00
        public void EnqueueEnvelope(){} // RVA: 0x7FFAF8E32F90
        public void FlushAsync(){} // RVA: 0x7FFAF8E330D0
        public void get_QueuedItems(){} // RVA: 0x7FFAF3210030
    }

}