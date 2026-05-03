// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 54
// Methods: 582

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Register(){} // RVA: 0x7FFE86EB05D0
        public void .cctor(){} // RVA: 0x7FFE86EB0C10
    }

    public class AnrWatchDog : Object
    {
        public int DetectionTimeoutMs; // 0x10

        // ── Methods ──
        public void add_OnApplicationNotResponding(){} // RVA: 0x7FFE86EB0CE0
        public void remove_OnApplicationNotResponding(){} // RVA: 0x7FFE86EB0DE0
        public void get_Paused(){} // RVA: 0x7FFE81121450
        public void set_Paused(){} // RVA: 0x7FFE81121460
        public void .ctor(){} // RVA: 0x7FFE86EB0EE0
        public void Stop(){} // RVA: 0x7FFE80E466C0
        public void Report(){} // RVA: 0x7FFE86EB13D0
        public void <.ctor>b__11_0(){} // RVA: 0x7FFE825203D0
        public void <.ctor>b__11_1(){} // RVA: 0x7FFE8143BA90
        public void <.ctor>b__11_2(){} // RVA: 0x7FFE86EB1570
    }

    public class AnrWatchDogMultiThreaded : AnrWatchDog
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EB1630
        public void Stop(){} // RVA: 0x7FFE86EB1900
        public void UpdateUiStatus(){} // RVA: 0x7FFE86EB1930
        public void Run(){} // RVA: 0x7FFE86EB19D0
    }

    public class AnrWatchDogSingleThreaded : AnrWatchDog
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EB1EF0
        public void Stop(){} // RVA: 0x7FFE82BBB440
        public void UpdateUiStatus(){} // RVA: 0x7FFE86EB20D0
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFE86EABF90
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ErrorTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F2ED0
    }

    public class IEventCapture
    {
        // ── Methods ──
        public void Capture(){}
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFE80E460A0
        public void remove_SceneLoaded(){} // RVA: 0x7FFE80E460A0
        public void add_SceneUnloaded(){} // RVA: 0x7FFE80E460A0
        public void remove_SceneUnloaded(){} // RVA: 0x7FFE80E460A0
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFE80E460A0
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFE80E460A0
    }

    public class ISentrySystemInfo
    {
        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7FFE80E2E2E0
        public void get_OperatingSystem(){} // RVA: 0x7FFE80E2E2E0
        public void get_ProcessorCount(){} // RVA: 0x7FFE80E2E2E0
        public void get_SupportsVibration(){} // RVA: 0x7FFE80E2E210
        public void get_DeviceType(){} // RVA: 0x7FFE80E2E2E0
        public void get_CpuDescription(){} // RVA: 0x7FFE80E2E2E0
        public void get_DeviceName(){} // RVA: 0x7FFE80E2E2E0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFE80E2E2E0
        public void get_DeviceModel(){} // RVA: 0x7FFE80E2E2E0
        public void get_SystemMemorySize(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFE80E2E2E0
        public void get_NpotSupport(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFE80E2E2E0
        public void get_MaxTextureSize(){} // RVA: 0x7FFE80E2E2E0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFE80E2E210
        public void get_SupportsRayTracing(){} // RVA: 0x7FFE80E2E210
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFE80E2E210
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFE80E2E210
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFE80E2E2E0
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7FFE80E2E210
        public void get_IsDebugBuild(){} // RVA: 0x7FFE80E2E2E0
        public void get_EditorVersion(){} // RVA: 0x7FFE80E2E2E0
        public void get_InstallMode(){} // RVA: 0x7FFE80E2E2E0
        public void get_TargetFrameRate(){} // RVA: 0x7FFE80E2E2E0
        public void get_CopyTextureSupport(){} // RVA: 0x7FFE80E2E2E0
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFE80E2E2E0
        public void get_StartTime(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISentryUnityInfo
    {
        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFE80E2F150
        public void get_Il2CppMethods(){} // RVA: 0x7FFE80E2E2E0
        public void IsKnownPlatform(){} // RVA: 0x7FFE80E2F150
        public void IsLinux(){} // RVA: 0x7FFE80E2F150
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFE80E31D70
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFE80E2F760
        public void GetDebugImageType(){} // RVA: 0x7FFE80E3D230
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0x7FFE80E2F150
    }

    public class Il2CppFree : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82BE9AD0
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE86EB54A0
        public void EndInvoke(){} // RVA: 0x7FFE810FCCB0
    }

    public class Il2CppGcHandleGetTarget : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8400E910
        public void Invoke(){} // RVA: 0x7FFE81156C60
        public void BeginInvoke(){} // RVA: 0x7FFE86EB5260
        public void EndInvoke(){} // RVA: 0x7FFE82DC25A0
    }

    public class Il2CppMethods : Object
    {
        public Sentry.Unity.Il2CppGcHandleGetTarget _il2CppGcHandleGetTarget; // 0x10
        public Sentry.Unity.Il2CppNativeStackTrace _il2CppNativeStackTrace; // 0x18
        public Sentry.Unity.Il2CppFree _il2CppFree; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE811DAE00
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x7FFE81116380
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x7FFE810FE7C0
        public void get_Il2CppFree(){} // RVA: 0x7FFE811290C0
    }

    public class Il2CppNativeStackTrace : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EB52E0
        public void Invoke(){} // RVA: 0x7FFE83F99C10
        public void BeginInvoke(){} // RVA: 0x7FFE86EB53B0
        public void EndInvoke(){} // RVA: 0x7FFE851EC540
    }

    public class LogTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F2ED0
    }

    public class MainThreadData : Object
    {
        public System.Nullable`1<int> _mainThreadId;
        public string _operatingSystem; // 0x8
        public System.Nullable`1<int> _processorCount; // 0x10
        public System.Nullable`1<bool> _supportsVibration; // 0x18
        public string _deviceType; // 0x20
        public string _cpuDescription; // 0x28
        public string _deviceName; // 0x30
        public string _deviceUniqueIdentifier; // 0x38
        public string _deviceModel; // 0x40
        public System.Nullable`1<int> _systemMemorySize; // 0x48
        public System.Nullable`1<int> _graphicsDeviceId; // 0x50
        public string _graphicsDeviceName; // 0x58
        public string _graphicsDeviceVendorId; // 0x60
        public string _graphicsDeviceVendor; // 0x68
        public System.Nullable`1<int> _graphicsMemorySize; // 0x70
        public System.Nullable`1<bool> _graphicsMultiThreaded; // 0x78
        public string _npotSupport; // 0x80
        public string _graphicsDeviceVersion; // 0x88
        public string _graphicsDeviceType; // 0x90
        public System.Nullable`1<int> _maxTextureSize; // 0x98
        public System.Nullable`1<bool> _supportsDrawCallInstancing; // 0xA0
        public System.Nullable`1<bool> _supportsRayTracing; // 0xA2
        public System.Nullable`1<bool> _supportsComputeShaders; // 0xA4
        public System.Nullable`1<bool> _supportsGeometryShaders; // 0xA6
        public System.Nullable`1<int> _graphicsShaderLevel; // 0xA8
        public System.Nullable`1<bool> _isDebugBuild; // 0xB0
        public string _editorVersion; // 0xB8
        public string _installMode; // 0xC0
        public string _targetFrameRate; // 0xC8
        public string _copyTextureSupport; // 0xD0
        public string _renderingThreadingMode; // 0xD8
        public System.Nullable`1<System.DateTimeOffset> _startTime; // 0xE0
        public Sentry.Unity.ISentrySystemInfo _sentrySystemInfo; // 0xF8

        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7FFE86EB5520
        public void set_MainThreadId(){} // RVA: 0x7FFE86EB5560
        public void get_OperatingSystem(){} // RVA: 0x7FFE86EB55B0
        public void set_OperatingSystem(){} // RVA: 0x7FFE86EB55F0
        public void get_ProcessorCount(){} // RVA: 0x7FFE86EB5690
        public void set_ProcessorCount(){} // RVA: 0x7FFE86EB56D0
        public void get_SupportsVibration(){} // RVA: 0x7FFE86EB5720
        public void set_SupportsVibration(){} // RVA: 0x7FFE86EB5760
        public void get_DeviceType(){} // RVA: 0x7FFE86EB57B0
        public void set_DeviceType(){} // RVA: 0x7FFE86EB57F0
        public void get_CpuDescription(){} // RVA: 0x7FFE86EB5890
        public void set_CpuDescription(){} // RVA: 0x7FFE86EB58D0
        public void get_DeviceName(){} // RVA: 0x7FFE86EB5970
        public void set_DeviceName(){} // RVA: 0x7FFE86EB59B0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFE86EB5A50
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x7FFE86EB5A90
        public void get_DeviceModel(){} // RVA: 0x7FFE86EB5B30
        public void set_DeviceModel(){} // RVA: 0x7FFE86EB5B70
        public void get_SystemMemorySize(){} // RVA: 0x7FFE86EB5C10
        public void set_SystemMemorySize(){} // RVA: 0x7FFE86EB5C50
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFE86EB5CA0
        public void set_GraphicsDeviceId(){} // RVA: 0x7FFE86EB5CE0
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFE86EB5D30
        public void set_GraphicsDeviceName(){} // RVA: 0x7FFE86EB5D70
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFE86EB5E10
        public void set_GraphicsDeviceVendorId(){} // RVA: 0x7FFE86EB5E50
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFE86EB5EF0
        public void set_GraphicsDeviceVendor(){} // RVA: 0x7FFE86EB5F30
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFE86EB5FD0
        public void set_GraphicsMemorySize(){} // RVA: 0x7FFE86EB6010
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFE86EB6060
        public void set_GraphicsMultiThreaded(){} // RVA: 0x7FFE86EB60A0
        public void get_NpotSupport(){} // RVA: 0x7FFE86EB60F0
        public void set_NpotSupport(){} // RVA: 0x7FFE86EB6130
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFE86EB61D0
        public void set_GraphicsDeviceVersion(){} // RVA: 0x7FFE86EB6210
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFE86EB62B0
        public void set_GraphicsDeviceType(){} // RVA: 0x7FFE86EB62F0
        public void get_MaxTextureSize(){} // RVA: 0x7FFE86EB6390
        public void set_MaxTextureSize(){} // RVA: 0x7FFE86EB63D0
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFE86EB6420
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x7FFE86EB6460
        public void get_SupportsRayTracing(){} // RVA: 0x7FFE86EB64B0
        public void set_SupportsRayTracing(){} // RVA: 0x7FFE86EB64F0
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFE86EB6540
        public void set_SupportsComputeShaders(){} // RVA: 0x7FFE86EB6580
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFE86EB65D0
        public void set_SupportsGeometryShaders(){} // RVA: 0x7FFE86EB6610
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFE86EB6660
        public void set_GraphicsShaderLevel(){} // RVA: 0x7FFE86EB66A0
        public void get_IsDebugBuild(){} // RVA: 0x7FFE86EB66F0
        public void set_IsDebugBuild(){} // RVA: 0x7FFE86EB6730
        public void get_EditorVersion(){} // RVA: 0x7FFE86EB6780
        public void set_EditorVersion(){} // RVA: 0x7FFE86EB67C0
        public void get_InstallMode(){} // RVA: 0x7FFE86EB6860
        public void set_InstallMode(){} // RVA: 0x7FFE86EB68A0
        public void get_TargetFrameRate(){} // RVA: 0x7FFE86EB6940
        public void set_TargetFrameRate(){} // RVA: 0x7FFE86EB6980
        public void get_CopyTextureSupport(){} // RVA: 0x7FFE86EB6A20
        public void set_CopyTextureSupport(){} // RVA: 0x7FFE86EB6A60
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFE86EB6B00
        public void set_RenderingThreadingMode(){} // RVA: 0x7FFE86EB6B40
        public void get_StartTime(){} // RVA: 0x7FFE86EB6BE0
        public void set_StartTime(){} // RVA: 0x7FFE86EB6C40
        public void IsMainThread(){} // RVA: 0x7FFE86EB6CA0
        public void get_SentrySystemInfo(){} // RVA: 0x7FFE86EB6DC0
        public void set_SentrySystemInfo(){} // RVA: 0x7FFE86EB6E00
        public void CollectData(){} // RVA: 0x7FFE86EB6EA0
    }

    public class NativeStackTrace : Object
    {
        public UIntPtr[] _frames; // 0x10
        public string _imageUuid; // 0x18
        public string _imageName; // 0x20

        // ── Methods ──
        public void get_Frames(){} // RVA: 0x7FFE81116380
        public void set_Frames(){} // RVA: 0x7FFE810FCE30
        public void get_ImageUuid(){} // RVA: 0x7FFE810FE7C0
        public void set_ImageUuid(){} // RVA: 0x7FFE81161E80
        public void get_ImageName(){} // RVA: 0x7FFE811290C0
        public void set_ImageName(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE86EB0540
    }

    public class SceneAdapter : ValueType
    {
        public string _name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFE8284EF60
        public void .ctor(){} // RVA: 0x7FFE81D7E9E0
    }

    public class SceneManagerAdapter : Object
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFE86EB2370
        public void remove_SceneLoaded(){} // RVA: 0x7FFE86EB2470
        public void add_SceneUnloaded(){} // RVA: 0x7FFE86EB2570
        public void remove_SceneUnloaded(){} // RVA: 0x7FFE86EB2670
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFE86EB2770
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFE86EB2870
        public void .ctor(){} // RVA: 0x7FFE86EB2970
        public void .cctor(){} // RVA: 0x7FFE86EB2CB0
        public void <.ctor>b__10_0(){} // RVA: 0x7FFE86EB2D60
        public void <.ctor>b__10_1(){} // RVA: 0x7FFE86EB2E50
        public void <.ctor>b__10_2(){} // RVA: 0x7FFE86EB2F20
    }

    public class SceneManagerTracingAPI : SceneManagerAPI
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE865D1710
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7FFE865D17B0
    }

    public class SceneManagerTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFE865D1420
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ScopeObserver : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8680DC00
        public void AddBreadcrumb(){} // RVA: 0x7FFE86EB8140
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFE80E460A0
        public void SetExtra(){} // RVA: 0x7FFE86EB8350
        public void SetExtraImpl(){} // RVA: 0x7FFE80E4F230
        public void SetTag(){} // RVA: 0x7FFE86EB8690
        public void SetTagImpl(){} // RVA: 0x7FFE80E4F230
        public void UnsetTag(){} // RVA: 0x7FFE86EB8870
        public void UnsetTagImpl(){} // RVA: 0x7FFE80E460A0
        public void SetUser(){} // RVA: 0x7FFE86EB8A10
        public void SetUserImpl(){} // RVA: 0x7FFE80E460A0
        public void UnsetUserImpl(){} // RVA: 0x7FFE80E45FE0
    }

    public class ScreenshotAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EB8CD0
    }

    public class ScreenshotAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetStream(){} // RVA: 0x7FFE86EB8D50
        public void GetTargetResolution(){} // RVA: 0x7FFE86EB8FA0
        public void CaptureScreenshot(){} // RVA: 0x7FFE86EB8FC0
    }

    public class ScriptableSentryUnityOptions : ScriptableObject
    {
        public string ConfigRootFolder;
        public string ConfigName;
        public bool _enabled; // 0x18
        public string _dsn; // 0x20
        public bool _captureInEditor; // 0x28
        public bool _enableLogDebouncing; // 0x29
        public int _debounceTimeLog; // 0x2C
        public int _debounceTimeWarning; // 0x30
        public int _debounceTimeError; // 0x34
        public double _tracesSampleRate; // 0x38
        public bool _autoStartupTraces; // 0x40
        public bool _autoSceneLoadTraces; // 0x41
        public bool _autoAwakeTraces; // 0x42
        public bool _autoSessionTracking; // 0x43
        public int _autoSessionTrackingInterval; // 0x44
        public string _releaseOverride; // 0x48
        public string _environmentOverride; // 0x50
        public bool _attachStacktrace; // 0x58
        public bool _attachScreenshot; // 0x59
        public 0x66685974 _screenshotQuality; // 0x5C
        public int _screenshotCompression; // 0x60
        public bool _attachViewHierarchy; // 0x64
        public int _maxViewHierarchyRootObjects; // 0x68
        public int _maxViewHierarchyObjectChildCount; // 0x6C
        public int _maxViewHierarchyDepth; // 0x70
        public bool _breadcrumbsForLogs; // 0x74
        public bool _breadcrumbsForWarnings; // 0x75
        public bool _breadcrumbsForAsserts; // 0x76
        public bool _breadcrumbsForErrors; // 0x77
        public bool _breadcrumbsForExceptions; // 0x78
        public int _maxBreadcrumbs; // 0x7C
        public 0x66591A2C _reportAssembliesMode; // 0x80
        public bool _sendDefaultPii; // 0x84
        public bool _isEnvironmentUser; // 0x85
        public bool _enableOfflineCaching; // 0x86
        public int _maxCacheItems; // 0x88
        public int _initCacheFlushTimeout; // 0x8C
        public float _sampleRate; // 0x90
        public int _shutdownTimeout; // 0x94
        public int _maxQueueItems; // 0x98
        public bool _anrDetectionEnabled; // 0x9C
        public int _anrTimeout; // 0xA0
        public bool _captureFailedRequests; // 0xA4
        public System.Collections.Generic.List`1<int> _failedRequestStatusCodes; // 0xA8
        public bool _filterBadGatewayExceptions; // 0xB0
        public bool _filterWebExceptions; // 0xB1
        public bool _filterSocketExceptions; // 0xB2
        public bool _iosNativeSupportEnabled; // 0xB3
        public bool _androidNativeSupportEnabled; // 0xB4
        public bool _ndkIntegrationEnabled; // 0xB5
        public bool _ndkScopeSyncEnabled; // 0xB6
        public int _postGenerateGradleProjectCallbackOrder; // 0xB8
        public bool _windowsNativeSupportEnabled; // 0xBC
        public bool _macosNativeSupportEnabled; // 0xBD
        public bool _linuxNativeSupportEnabled; // 0xBE
        public bool _il2CppLineNumberSupportEnabled; // 0xBF
        public Sentry.Unity.SentryRuntimeOptionsConfiguration _runtimeOptionsConfiguration; // 0xC0
        public Sentry.Unity.SentryBuildTimeOptionsConfiguration _buildTimeOptionsConfiguration; // 0xC8
        public Sentry.Unity.SentryOptionsConfiguration _optionsConfiguration; // 0xD0
        public bool _debug; // 0xD8

        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x7FFE86EB98B0
        public void get_Enabled(){} // RVA: 0x7FFE811164E0
        public void set_Enabled(){} // RVA: 0x7FFE811164F0
        public void get_Dsn(){} // RVA: 0x7FFE811290C0
        public void set_Dsn(){} // RVA: 0x7FFE811290D0
        public void get_CaptureInEditor(){} // RVA: 0x7FFE815F1380
        public void set_CaptureInEditor(){} // RVA: 0x7FFE81C15740
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFE819C2EA0
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFE8268C820
        public void get_DebounceTimeLog(){} // RVA: 0x7FFE81F84A50
        public void set_DebounceTimeLog(){} // RVA: 0x7FFE82883A50
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFE81156CD0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFE81156CE0
        public void get_DebounceTimeError(){} // RVA: 0x7FFE82447220
        public void set_DebounceTimeError(){} // RVA: 0x7FFE82443340
        public void get_TracesSampleRate(){} // RVA: 0x7FFE83FADDB0
        public void set_TracesSampleRate(){} // RVA: 0x7FFE83FADDC0
        public void get_AutoStartupTraces(){} // RVA: 0x7FFE811B6C00
        public void set_AutoStartupTraces(){} // RVA: 0x7FFE811B6C10
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFE814645D0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFE814641E0
        public void get_AutoAwakeTraces(){} // RVA: 0x7FFE81463AF0
        public void set_AutoAwakeTraces(){} // RVA: 0x7FFE81463C10
        public void get_AutoSessionTracking(){} // RVA: 0x7FFE822BB340
        public void set_AutoSessionTracking(){} // RVA: 0x7FFE82876450
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFE8119C0A0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFE8119C0B0
        public void get_ReleaseOverride(){} // RVA: 0x7FFE81176730
        public void set_ReleaseOverride(){} // RVA: 0x7FFE81176740
        public void get_EnvironmentOverride(){} // RVA: 0x7FFE8119C0E0
        public void set_EnvironmentOverride(){} // RVA: 0x7FFE812534D0
        public void get_AttachStacktrace(){} // RVA: 0x7FFE813A1140
        public void set_AttachStacktrace(){} // RVA: 0x7FFE819E83C0
        public void get_AttachScreenshot(){} // RVA: 0x7FFE85BA8C00
        public void set_AttachScreenshot(){} // RVA: 0x7FFE86B5F180
        public void get_ScreenshotQuality(){} // RVA: 0x7FFE813A7A20
        public void set_ScreenshotQuality(){} // RVA: 0x7FFE8175ACA0
        public void get_ScreenshotCompression(){} // RVA: 0x7FFE8139EA30
        public void set_ScreenshotCompression(){} // RVA: 0x7FFE8139E520
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFE821FF050
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFE82A22EE0
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFE82A22EF0
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFE82A22F00
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFE82A22F10
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFE82A22F20
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFE81E60180
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFE81293CF0
        public void get_BreadcrumbsForLogs(){} // RVA: 0x7FFE81E8DCD0
        public void set_BreadcrumbsForLogs(){} // RVA: 0x7FFE8656ED40
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x7FFE81EB9540
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x7FFE86EB9930
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x7FFE81EC3960
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x7FFE86EB9940
        public void get_BreadcrumbsForErrors(){} // RVA: 0x7FFE86EB9950
        public void set_BreadcrumbsForErrors(){} // RVA: 0x7FFE86EB9960
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x7FFE816400C0
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x7FFE81FE6AC0
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFE8286B570
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFE86D89990
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFE81D30560
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFE81D307B0
        public void get_SendDefaultPii(){} // RVA: 0x7FFE811DACE0
        public void set_SendDefaultPii(){} // RVA: 0x7FFE811DACF0
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFE81EB0A70
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFE86EB9970
        public void get_EnableOfflineCaching(){} // RVA: 0x7FFE821F4D30
        public void set_EnableOfflineCaching(){} // RVA: 0x7FFE86EB9980
        public void get_MaxCacheItems(){} // RVA: 0x7FFE8194AD00
        public void set_MaxCacheItems(){} // RVA: 0x7FFE8194A400
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFE842B66B0
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFE848F07E0
        public void get_SampleRate(){} // RVA: 0x7FFE81163540
        public void set_SampleRate(){} // RVA: 0x7FFE81163550
        public void get_ShutdownTimeout(){} // RVA: 0x7FFE814AA230
        public void set_ShutdownTimeout(){} // RVA: 0x7FFE81680470
        public void get_MaxQueueItems(){} // RVA: 0x7FFE82B06A40
        public void set_MaxQueueItems(){} // RVA: 0x7FFE82B06FA0
        public void get_AnrDetectionEnabled(){} // RVA: 0x7FFE86EB9990
        public void set_AnrDetectionEnabled(){} // RVA: 0x7FFE86560ED0
        public void get_AnrTimeout(){} // RVA: 0x7FFE82B06FB0
        public void set_AnrTimeout(){} // RVA: 0x7FFE82B06FC0
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFE813A1BB0
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFE813A4B20
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFE817AB5E0
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFE81857260
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFE824A0700
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFE824A0BA0
        public void get_FilterWebExceptions(){} // RVA: 0x7FFE848BEF10
        public void set_FilterWebExceptions(){} // RVA: 0x7FFE848BEF20
        public void get_FilterSocketExceptions(){} // RVA: 0x7FFE86CE93D0
        public void set_FilterSocketExceptions(){} // RVA: 0x7FFE86CE93E0
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFE86CE93F0
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFE86CE9400
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFE86CE9410
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFE86CE9420
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFE86EB99A0
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFE86EB99B0
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFE86EB99C0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFE86EB99D0
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFE8260FFA0
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFE826140C0
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFE86C70890
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFE86C708A0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFE86EB99E0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFE86EB99F0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFE86EB9A00
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFE86EB9A10
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFE86EB9A20
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFE86EB9A30
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x7FFE81166120
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x7FFE81166130
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFE81253460
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFE81253470
        public void get_OptionsConfiguration(){} // RVA: 0x7FFE81218100
        public void set_OptionsConfiguration(){} // RVA: 0x7FFE81218110
        public void get_Debug(){} // RVA: 0x7FFE82078290
        public void set_Debug(){} // RVA: 0x7FFE86C70900
        public void get_DebugOnlyInEditor(){} // RVA: 0x7FFE86EB9A40
        public void set_DebugOnlyInEditor(){} // RVA: 0x7FFE86EB9A50
        public void get_DiagnosticLevel(){} // RVA: 0x7FFE86EB9A60
        public void set_DiagnosticLevel(){} // RVA: 0x7FFE86EB9A70
        public void LoadSentryUnityOptions(){} // RVA: 0x7FFE86EB9A80
        public void ToSentryUnityOptions(){} // RVA: 0x7FFE86EB9B00
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x7FFE86EBA8A0
        public void HandleExceptionFilter(){} // RVA: 0x7FFE86EBAB00
        public void ShouldDebug(){} // RVA: 0x7FFE86EBABC0
        public void .ctor(){} // RVA: 0x7FFE86EBABE0
    }

    public class SentryBuildTimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE80E4F230
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SentryCliOptions : ScriptableObject
    {
        public string ConfigName;
        public string EditorMenuPath;
        public bool _uploadSymbols; // 0x18
        public bool _uploadDevelopmentSymbols; // 0x19
        public bool _uploadSources; // 0x1A
        public string _urlOverride; // 0x20
        public string _auth; // 0x28
        public string _organization; // 0x30
        public string _project; // 0x38

        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0x7FFE811164E0
        public void set_UploadSymbols(){} // RVA: 0x7FFE811164F0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x7FFE814B3730
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x7FFE81CD0510
        public void get_UploadSources(){} // RVA: 0x7FFE82930110
        public void set_UploadSources(){} // RVA: 0x7FFE8292DD10
        public void get_UrlOverride(){} // RVA: 0x7FFE811290C0
        public void set_UrlOverride(){} // RVA: 0x7FFE811290D0
        public void get_Auth(){} // RVA: 0x7FFE81129130
        public void set_Auth(){} // RVA: 0x7FFE810FCE90
        public void get_Organization(){} // RVA: 0x7FFE8144E200
        public void set_Organization(){} // RVA: 0x7FFE81129890
        public void get_Project(){} // RVA: 0x7FFE8143BA80
        public void set_Project(){} // RVA: 0x7FFE81437330
        public void get_IgnoreCliErrors(){} // RVA: 0x7FFE811B6C00
        public void set_IgnoreCliErrors(){} // RVA: 0x7FFE811B6C10
        public void get_CliOptionsConfiguration(){} // RVA: 0x7FFE81176730
        public void set_CliOptionsConfiguration(){} // RVA: 0x7FFE81176740
        public void GetConfigPath(){} // RVA: 0x7FFE86EBB200
        public void MissingFieldWarning(){} // RVA: 0x7FFE86EBB280
        public void IsValid(){} // RVA: 0x7FFE86EBB340
        public void .ctor(){} // RVA: 0x7FFE86EBB4D0
    }

    public class SentryCliOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFE86EBB4E0
        public void Configure(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void .cctor(){} // RVA: 0x7FFE86EBB540
    }

    public class SentryInitialization : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE865CF740
    }

    public class SentryIntegrations : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE865D0770
    }

    public class SentryMonoBehaviour : MonoBehaviour
    {
        public Sentry.Unity.SentryMonoBehaviour _instance;
        public System.Action ApplicationResuming; // 0x20

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE86EBB5F0
        public void StartAwakeSpan(){} // RVA: 0x7FFE86EBB810
        public void FinishAwakeSpan(){} // RVA: 0x7FFE86EBB9B0
        public void add_ApplicationResuming(){} // RVA: 0x7FFE86EBBA30
        public void remove_ApplicationResuming(){} // RVA: 0x7FFE86EBBB20
        public void add_ApplicationPausing(){} // RVA: 0x7FFE86EBBC10
        public void remove_ApplicationPausing(){} // RVA: 0x7FFE86EBBD00
        public void get_Application(){} // RVA: 0x7FFE86EBBDF0
        public void set_Application(){} // RVA: 0x7FFE81437330
        public void UpdatePauseStatus(){} // RVA: 0x7FFE86EBBEB0
        public void OnApplicationPause(){} // RVA: 0x7FFE86EBBEB0
        public void OnApplicationFocus(){} // RVA: 0x7FFE86EBBEF0
        public void OnApplicationQuit(){} // RVA: 0x7FFE86EBBF30
        public void Awake(){} // RVA: 0x7FFE86EBBFD0
        public void .ctor(){} // RVA: 0x7FFE811AF710
    }

    public class SentryOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFE86EBC0A0
        public void Configure(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE81345B60
        public void .cctor(){} // RVA: 0x7FFE86EBC100
    }

    public class SentryRuntimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE81345B60
    }

    public class SentrySystemInfoAdapter : Object
    {
        public Sentry.Unity.SentrySystemInfoAdapter Instance;
        public object field_1; // 0xC3
        public object field_2; // 0xC4
        public object field_3; // 0xC5
        public object field_4; // 0xC6
        public object field_5; // 0xC7
        public object field_6; // 0xC8
        public object field_7; // 0xC9
        public object field_8; // 0xCA
        public object field_9; // 0xCB
        public object field_10; // 0xCC
        public object field_11; // 0xCD
        public object field_12; // 0xCE
        public object field_13; // 0xCF
        public object field_14; // 0xD0
        public object field_15; // 0xD1
        public object field_16; // 0xD2
        public object field_17; // 0xD3
        public object field_18; // 0xD4
        public object field_19; // 0xD5
        public object field_20; // 0xD6
        public object field_21; // 0xD7
        public object field_22; // 0xD8
        public object field_23; // 0xD9
        public object field_24; // 0xDA
        public object field_25; // 0xDB
        public object field_26; // 0xDC
        public object field_27; // 0xDD
        public object field_28; // 0xDE
        public object field_29; // 0xDF
        public object field_30; // 0xE0
        public object field_31; // 0xE1
        public object field_32; // 0xE2

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_MainThreadId(){} // RVA: 0x7FFE86EBF250
        public void get_OperatingSystem(){} // RVA: 0x7FFE86EBF2F0
        public void get_ProcessorCount(){} // RVA: 0x7FFE86EBF340
        public void get_SupportsVibration(){} // RVA: 0x7FFE86EBF3C0
        public void get_DeviceType(){} // RVA: 0x7FFE86EBF440
        public void get_CpuDescription(){} // RVA: 0x7FFE86EBF5E0
        public void get_DeviceName(){} // RVA: 0x7FFE86EBF630
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFE86EBF890
        public void get_DeviceModel(){} // RVA: 0x7FFE86EBFA30
        public void get_SystemMemorySize(){} // RVA: 0x7FFE86EBFBD0
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFE86EBFC50
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFE86EBFCD0
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFE86EBFD20
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFE86EBFEC0
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFE86EBFF10
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFE86EBFF90
        public void get_NpotSupport(){} // RVA: 0x7FFE86EC0120
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFE86EC01B0
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFE86EC0200
        public void get_MaxTextureSize(){} // RVA: 0x7FFE86EC0290
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFE86EC0310
        public void get_SupportsRayTracing(){} // RVA: 0x7FFE86EC0390
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFE86EC0410
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFE86EC0490
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFE86EC0510
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7FFE86EC0590
        public void get_IsDebugBuild(){} // RVA: 0x7FFE86EC0610
        public void get_EditorVersion(){} // RVA: 0x7FFE86EC07A0
        public void get_InstallMode(){} // RVA: 0x7FFE86EC0820
        public void get_TargetFrameRate(){} // RVA: 0x7FFE86EC08E0
        public void get_CopyTextureSupport(){} // RVA: 0x7FFE86EC0A80
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFE86EC0C20
        public void get_StartTime(){} // RVA: 0x7FFE86EC0DC0
        public void .cctor(){} // RVA: 0x7FFE86EC0F50
    }

    public class SentryUnity : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE86EBC2A0 | overloaded x2
        public void Close(){} // RVA: 0x7FFE86EBC3A0
    }

    public class SentryUnityInfo : Object
    {
        public Sentry.Unity.Il2CppMethods _il2CppMethods; // 0x10
        public object field_1; // 0x1

        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFE811E0850
        public void get_Il2CppMethods(){} // RVA: 0x7FFE81116380
        public void SanitizeDebugId(){} // RVA: 0x7FFE865CFD60
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x7FFE865CFDD0
        public void il2cpp_gchandle_get_target(){} // RVA: 0x7FFE865CFDD0
        public void il2cpp_free(){} // RVA: 0x7FFE865CFDE0
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x7FFE865CFDF0
        public void il2cpp_native_stack_trace(){} // RVA: 0x7FFE865D0020
        public void IsKnownPlatform(){} // RVA: 0x7FFE865D0030
        public void IsLinux(){} // RVA: 0x7FFE865D00D0
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFE865D0160
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFE865D0200
        public void GetDebugImageType(){} // RVA: 0x7FFE865D0220
        public void .ctor(){} // RVA: 0x7FFE865D02F0
    }

    public class SentryUnityOptions : SentryOptions
    {
        public string PackageName;
        public bool _enabled; // 0x288
        public bool _autoStartupTraces; // 0x289
        public bool _autoSceneLoadTraces; // 0x28A
        public bool _captureInEditor; // 0x28B
        public bool _enableLogDebouncing; // 0x28C
        public System.TimeSpan _debounceTimeLog; // 0x290
        public System.TimeSpan _debounceTimeWarning; // 0x298
        public System.TimeSpan _debounceTimeError; // 0x2A0
        public 0x6668591C _requestBodyCompressionLevel; // 0x2A8
        public bool _attachScreenshot; // 0x2AC
        public bool _attachViewHierarchy; // 0x2AD
        public int _maxViewHierarchyRootObjects; // 0x2B0
        public int _maxViewHierarchyObjectChildCount; // 0x2B4
        public int _maxViewHierarchyDepth; // 0x2B8
        public 0x66685974 _screenshotQuality; // 0x2BC
        public int _screenshotCompression; // 0x2C0
        public System.Collections.Generic.Dictionary`2<*,bool> _addBreadcrumbsForLogType; // 0x2C8
        public System.TimeSpan _anrTimeout; // 0x2D0
        public bool _filterBadGatewayExceptions; // 0x2D8
        public bool _iosNativeSupportEnabled; // 0x2D9
        public bool _androidNativeSupportEnabled; // 0x2DA
        public bool _ndkIntegrationEnabled; // 0x2DB
        public bool _ndkScopeSyncEnabled; // 0x2DC
        public bool _windowsNativeSupportEnabled; // 0x2DD
        public bool _macosNativeSupportEnabled; // 0x2DE
        public bool _linuxNativeSupportEnabled; // 0x2DF
        public bool _il2CppLineNumberSupportEnabled; // 0x2E0
        public bool _performanceAutoInstrumentationEnabled; // 0x2E1
        public 0x6659391C _stackTraceMode; // 0x2E4
        public string _defaultUserId; // 0x2E8
        public bool MultiThreading; // 0x2F0
        public Sentry.Unity.ContextWriter _nativeContextWriter; // 0x2F8

        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFE86EBC460
        public void set_Enabled(){} // RVA: 0x7FFE86EBC470
        public void get_AutoStartupTraces(){} // RVA: 0x7FFE86EBC480
        public void set_AutoStartupTraces(){} // RVA: 0x7FFE86EBC490
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFE86EBC4A0
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFE86EBC4B0
        public void get_CaptureInEditor(){} // RVA: 0x7FFE86EBC4C0
        public void set_CaptureInEditor(){} // RVA: 0x7FFE86EBC4D0
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFE86EBC4E0
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFE86EBC4F0
        public void get_DebounceTimeLog(){} // RVA: 0x7FFE81B2FC70
        public void set_DebounceTimeLog(){} // RVA: 0x7FFE86EBC500
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFE81B2D410
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFE86EBC510
        public void get_DebounceTimeError(){} // RVA: 0x7FFE81B20980
        public void set_DebounceTimeError(){} // RVA: 0x7FFE86EBC520
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFE86EBC530
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFE86EBC540
        public void get_AttachScreenshot(){} // RVA: 0x7FFE86EBC560
        public void set_AttachScreenshot(){} // RVA: 0x7FFE86EBC570
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFE86EBC580
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFE86EBC590
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFE86EBC5A0
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFE86EBC5B0
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFE86EBC5C0
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFE86EBC5D0
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFE86EBC5E0
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFE86EBC5F0
        public void get_ScreenshotQuality(){} // RVA: 0x7FFE86EBC600
        public void set_ScreenshotQuality(){} // RVA: 0x7FFE86EBC610
        public void get_ScreenshotCompression(){} // RVA: 0x7FFE86EBC620
        public void set_ScreenshotCompression(){} // RVA: 0x7FFE86EBC630
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x7FFE81B14AA0
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x7FFE81B26FF0
        public void get_AnrTimeout(){} // RVA: 0x7FFE81B36B70
        public void set_AnrTimeout(){} // RVA: 0x7FFE86EBC640
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFE86EBC650
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFE86EBC660
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFE86EBC670
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFE86EBC680
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFE86EBC690
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFE86EBC6A0
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFE86EBC6B0
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFE86EBC6C0
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFE86EBC6D0
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFE86EBC6E0
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFE86EBC6F0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFE86EBC700
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFE86EBC710
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFE86EBC720
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFE86EBC730
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFE86EBC740
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFE86EBC750
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFE86EBC760
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFE86EBC770
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFE86EBC780
        public void get_StackTraceMode(){} // RVA: 0x7FFE86EBC790
        public void set_StackTraceMode(){} // RVA: 0x7FFE86EBC7A0
        public void get_DefaultUserId(){} // RVA: 0x7FFE81B381B0
        public void set_DefaultUserId(){} // RVA: 0x7FFE86EBC7B0
        public void get_NativeContextWriter(){} // RVA: 0x7FFE81B30900
        public void set_NativeContextWriter(){} // RVA: 0x7FFE81B0D290
        public void get_NativeSupportCloseCallback(){} // RVA: 0x7FFE811661F0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x7FFE81166200
        public void get_SdkIntegrationNames(){} // RVA: 0x7FFE81B25780
        public void set_SdkIntegrationNames(){} // RVA: 0x7FFE81B251F0
        public void .ctor(){} // RVA: 0x7FFE86EBC9B0 | overloaded x3
        public void ToString(){} // RVA: 0x7FFE86EBD760
    }

    public class SentryUnityOptionsExtensions : Object
    {
        // ── Methods ──
        public void ShouldInitializeSdk(){} // RVA: 0x7FFE86EBDA50 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFE86EBDC30
        public void SetupLogging(){} // RVA: 0x7FFE86EBDD10
        public void AddIl2CppExceptionProcessor(){} // RVA: 0x7FFE86EBDF00
        public void DisableUnityApplicationLoggingIntegration(){} // RVA: 0x7FFE86EBE000
        public void DisableAnrIntegration(){} // RVA: 0x7FFE86EBE050
        public void DisableBadGatewayExceptionFilter(){} // RVA: 0x7FFE86EBE0A0
        public void DisableWebExceptionFilter(){} // RVA: 0x7FFE86EBE0F0
        public void DisableSocketExceptionFilter(){} // RVA: 0x7FFE86EBE140
    }

    public class SentryUnitySdk : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Init(){} // RVA: 0x7FFE86EBE190
        public void Close(){} // RVA: 0x7FFE86EBE790
    }

    public class StartupTracingIntegration : Object
    {
        // ── Methods ──
        public void Register(){} // RVA: 0x7FFE865D08A0
        public void AfterAssembliesLoaded(){} // RVA: 0x7FFE865D0980
        public void BeforeSplashScreen(){} // RVA: 0x7FFE865D0BB0
        public void BeforeSceneLoad(){} // RVA: 0x7FFE865D0DE0
        public void AfterSceneLoad(){} // RVA: 0x7FFE865D1010
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class TagValueNormalizer : Object
    {
        // ── Methods ──
        public void ToTagValue(){} // RVA: 0x7FFE86EC1F40
    }

    public class TimeDebounceBase : Object
    {
        public System.TimeSpan DebounceOffset; // 0x10

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFE86EC16C0
        public void Debounced(){} // RVA: 0x7FFE86EC1770
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class UnityEventProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Process(){} // RVA: 0x7FFE86EC18F0 | overloaded x2
        public void SetEventContext(){} // RVA: 0x7FFE86EC1960
        public void PopulateDevice(){} // RVA: 0x7FFE86EC1B50
        public void PopulateSdkIntegrations(){} // RVA: 0x7FFE86EC1DA0
    }

    public class UnityIl2CppEventExceptionProcessor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EACEE0
        public void Process(){} // RVA: 0x7FFE86EAD1D0
        public void NormalizeUuid(){} // RVA: 0x7FFE86EAE5B0
        public void FindDebugImageContainingAddress(){} // RVA: 0x7FFE86EAE660
        public void EnumerateChainedExceptions(){} // RVA: 0x7FFE86EAE7D0
        public void GetNativeStackTrace(){} // RVA: 0x7FFE86EAE8E0
        public void .cctor(){} // RVA: 0x7FFE86EAED00
    }

    public class UnityLogger : Object
    {
        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFE86EC1FA0
        public void .ctor(){} // RVA: 0x7FFE86EC20E0 | overloaded x2
        public void Log(){} // RVA: 0x7FFE86EC21F0
        public void GetUnityLogType(){} // RVA: 0x7FFE86EC2440
        public void ToString(){} // RVA: 0x7FFE86EC2470
    }

    public class UnityScopeIntegration : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void Register(){} // RVA: 0x7FFE86EB33C0
    }

    public class UnityScopeUpdater : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81CA56D0
        public void ConfigureScope(){} // RVA: 0x7FFE86EB3570
        public void PopulateSdk(){} // RVA: 0x7FFE86EB3C20
        public void PopulateApp(){} // RVA: 0x7FFE86EB3E00
        public void PopulateOperatingSystem(){} // RVA: 0x7FFE86EB3F60
        public void PopulateDevice(){} // RVA: 0x7FFE86EB4000
        public void PopulateGpu(){} // RVA: 0x7FFE86EB4560
        public void PopulateUnity(){} // RVA: 0x7FFE86EB4C70
        public void PopulateTags(){} // RVA: 0x7FFE86EB4F40
        public void PopulateUser(){} // RVA: 0x7FFE86EB51E0
    }

    public class UnitySdkInfo : Object
    {
        public string _version;

        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFE86EB30B0
        public void .cctor(){} // RVA: 0x7FFE86EB3110
    }

    public class UnityViewHierarchyAttachmentContent : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FCE30
        public void GetStream(){} // RVA: 0x7FFE86EC24B0
        public void CaptureViewHierarchy(){} // RVA: 0x7FFE86EC2580
        public void CreateViewHierarchy(){} // RVA: 0x7FFE86EC2790
        public void CreateNode(){} // RVA: 0x7FFE86EC2BB0
    }

    public class UnityViewHierarchyNode : ViewHierarchyNode
    {
        public string _tag; // 0x20
        public string _position; // 0x28
        public string _rotation; // 0x30
        public string _scale; // 0x38
        public System.Nullable`1<bool> _active; // 0x40
        public System.Collections.Generic.List`1<string> _extras; // 0x48

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFE811290C0
        public void set_Tag(){} // RVA: 0x7FFE811290D0
        public void get_Position(){} // RVA: 0x7FFE81129130
        public void set_Position(){} // RVA: 0x7FFE810FCE90
        public void get_Rotation(){} // RVA: 0x7FFE8144E200
        public void set_Rotation(){} // RVA: 0x7FFE81129890
        public void get_Scale(){} // RVA: 0x7FFE8143BA80
        public void set_Scale(){} // RVA: 0x7FFE81437330
        public void get_Active(){} // RVA: 0x7FFE851042F0
        public void set_Active(){} // RVA: 0x7FFE86EC3420
        public void get_Extras(){} // RVA: 0x7FFE81176730
        public void set_Extras(){} // RVA: 0x7FFE81176740
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void WriteAdditionalProperties(){} // RVA: 0x7FFE86EC3430
    }

    public class UnityWebRequestTransport : HttpTransportBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EC3B90
        public void SendEnvelopeAsync(){} // RVA: 0x7FFE86EC3C10
        public void CreateWebRequest(){} // RVA: 0x7FFE86EC3D10
        public void GetResponse(){} // RVA: 0x7FFE86EC42B0
    }

    public class WarningTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE826F2ED0
    }

    public class WebBackgroundWorker : Object
    {
        public Sentry.Unity.SentryMonoBehaviour _behaviour; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86EC3820
        public void EnqueueEnvelope(){} // RVA: 0x7FFE86EC39B0
        public void FlushAsync(){} // RVA: 0x7FFE86EC3AF0
        public void get_QueuedItems(){} // RVA: 0x7FFE8151D690
    }

}