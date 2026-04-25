// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Unity
// Classes: 54
// Methods: 582

namespace ThirdParty.Sentry.Sentry.Unity
{
    public class AnrIntegration : Object
    {
        public object Lock;
        public Sentry.Unity.AnrWatchDog Watchdog; // 0x8
        public Sentry.Unity.SentryMonoBehaviour _monoBehaviour; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Register(){} // RVA: 0x7FFAC8B06F70
        public void .cctor(){} // RVA: 0x7FFAC8B075B0
    }

    public class AnrWatchDog : Object
    {
        public int Paused; // 0x10
        public int SleepIntervalMs; // 0x14
        public Sentry.Extensibility.IDiagnosticLogger Logger; // 0x18
        public Sentry.Unity.SentryMonoBehaviour MonoBehaviour; // 0x20
        public System.EventHandler`1<Sentry.Unity.Integrations.ApplicationNotRespondingException> OnApplicationNotResponding; // 0x28
        public bool <Paused>k__BackingField; // 0x30

        // ── Methods ──
        public void add_OnApplicationNotResponding(){} // RVA: 0x7FFAC8B07680
        public void remove_OnApplicationNotResponding(){} // RVA: 0x7FFAC8B07780
        public void get_Paused(){} // RVA: 0x7FFAC2F47450
        public void set_Paused(){} // RVA: 0x7FFAC2F47460
        public void .ctor(){} // RVA: 0x7FFAC8B07880
        public void Stop(){} // RVA: 0x7FFAC2C71060
        public void Report(){} // RVA: 0x7FFAC8B07D70
        public void <.ctor>b__11_0(){} // RVA: 0x7FFAC4269BA0
        public void <.ctor>b__11_1(){} // RVA: 0x7FFAC4269BB0
        public void <.ctor>b__11_2(){} // RVA: 0x7FFAC8B07F10
    }

    public class AnrWatchDogMultiThreaded : AnrWatchDog
    {
        public int _ticksSinceUiUpdate; // 0x38
        public bool _reported; // 0x3C
        public bool _stop; // 0x3D
        public System.Threading.Thread _thread; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B07FD0
        public void Stop(){} // RVA: 0x7FFAC8B082A0
        public void UpdateUiStatus(){} // RVA: 0x7FFAC8B082D0
        public void Run(){} // RVA: 0x7FFAC8B08370
    }

    public class AnrWatchDogSingleThreaded : AnrWatchDog
    {
        public System.Diagnostics.Stopwatch _watch; // 0x38
        public bool _stop; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B08890
        public void Stop(){} // RVA: 0x7FFAC37495E0
        public void UpdateUiStatus(){} // RVA: 0x7FFAC8B08A70
    }

    public class ContextWriter : Object
    {
        // ── Methods ──
        public void Write(){} // RVA: 0x7FFAC8B02930
        public void WriteScope(){}
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ErrorTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC441EFB0
    }

    public class IEventCapture
    {
        // ── Methods ──
        public void Capture(){}
    }

    public class ISceneManager
    {
        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFAC2C70A40
        public void remove_SceneLoaded(){} // RVA: 0x7FFAC2C70A40
        public void add_SceneUnloaded(){} // RVA: 0x7FFAC2C70A40
        public void remove_SceneUnloaded(){} // RVA: 0x7FFAC2C70A40
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFAC2C70A40
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISentrySystemInfo
    {
        public object MainThreadId;
        public object OperatingSystem;
        public object ProcessorCount;
        public object SupportsVibration;
        public object DeviceType;
        public object CpuDescription;
        public object DeviceName;
        public object DeviceUniqueIdentifier;
        public object DeviceModel;
        public object SystemMemorySize;
        public object GraphicsDeviceId;
        public object GraphicsDeviceName;
        public object GraphicsDeviceVendorId;
        public object GraphicsDeviceVendor;
        public object GraphicsMemorySize;
        public object GraphicsMultiThreaded;
        public object NpotSupport;
        public object GraphicsDeviceVersion;
        public object GraphicsDeviceType;
        public object MaxTextureSize;
        public object SupportsDrawCallInstancing;
        public object SupportsRayTracing;
        public object SupportsComputeShaders;
        public object SupportsGeometryShaders;
        public object GraphicsShaderLevel;
        public object GraphicsUVStartsAtTop;
        public object IsDebugBuild;
        public object EditorVersion;
        public object InstallMode;
        public object TargetFrameRate;
        public object CopyTextureSupport;
        public object RenderingThreadingMode;
        public object StartTime;

        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7FFAC2C58E90
        public void get_OperatingSystem(){} // RVA: 0x7FFAC2C58E90
        public void get_ProcessorCount(){} // RVA: 0x7FFAC2C58E90
        public void get_SupportsVibration(){} // RVA: 0x7FFAC2C58DC0
        public void get_DeviceType(){} // RVA: 0x7FFAC2C58E90
        public void get_CpuDescription(){} // RVA: 0x7FFAC2C58E90
        public void get_DeviceName(){} // RVA: 0x7FFAC2C58E90
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAC2C58E90
        public void get_DeviceModel(){} // RVA: 0x7FFAC2C58E90
        public void get_SystemMemorySize(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFAC2C58E90
        public void get_NpotSupport(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFAC2C58E90
        public void get_MaxTextureSize(){} // RVA: 0x7FFAC2C58E90
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAC2C58DC0
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAC2C58DC0
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAC2C58DC0
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAC2C58DC0
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAC2C58E90
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7FFAC2C58DC0
        public void get_IsDebugBuild(){} // RVA: 0x7FFAC2C58E90
        public void get_EditorVersion(){} // RVA: 0x7FFAC2C58E90
        public void get_InstallMode(){} // RVA: 0x7FFAC2C58E90
        public void get_TargetFrameRate(){} // RVA: 0x7FFAC2C58E90
        public void get_CopyTextureSupport(){} // RVA: 0x7FFAC2C58E90
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFAC2C58E90
        public void get_StartTime(){} // RVA: 0x7FFAC2C58E90
    }

    public class ISentryUnityInfo
    {
        public object IL2CPP;
        public object Il2CppMethods;

        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFAC2C59D00
        public void get_Il2CppMethods(){} // RVA: 0x7FFAC2C58E90
        public void IsKnownPlatform(){} // RVA: 0x7FFAC2C59D00
        public void IsLinux(){} // RVA: 0x7FFAC2C59D00
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFAC2C5C920
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFAC2C5A310
        public void GetDebugImageType(){} // RVA: 0x7FFAC2C67DE0
    }

    public class IUnityLogMessageDebounce
    {
        // ── Methods ──
        public void Debounced(){} // RVA: 0x7FFAC2C59D00
    }

    public class Il2CppFree : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC497DFD0
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC8B0BE40
        public void EndInvoke(){} // RVA: 0x7FFAC2F22CB0
    }

    public class Il2CppGcHandleGetTarget : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC5CB0690
        public void Invoke(){} // RVA: 0x7FFAC2F7CC60
        public void BeginInvoke(){} // RVA: 0x7FFAC8B0BC00
        public void EndInvoke(){} // RVA: 0x7FFAC4B58720
    }

    public class Il2CppMethods : Object
    {
        public Sentry.Unity.Il2CppGcHandleGetTarget Il2CppGcHandleGetTarget; // 0x10
        public Sentry.Unity.Il2CppNativeStackTrace Il2CppNativeStackTrace; // 0x18
        public Sentry.Unity.Il2CppFree Il2CppFree; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3000E00
        public void get_Il2CppGcHandleGetTarget(){} // RVA: 0x7FFAC2F3C380
        public void get_Il2CppNativeStackTrace(){} // RVA: 0x7FFAC2F247C0
        public void get_Il2CppFree(){} // RVA: 0x7FFAC2F4F0C0
    }

    public class Il2CppNativeStackTrace : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B0BC80
        public void Invoke(){} // RVA: 0x7FFAC5C60E20
        public void BeginInvoke(){} // RVA: 0x7FFAC8B0BD50
        public void EndInvoke(){} // RVA: 0x7FFAC6E60C00
    }

    public class LogTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC441EFB0
    }

    public class MainThreadData : Object
    {
        public System.Nullable`1<int> MainThreadId;
        public string OperatingSystem; // 0x8
        public System.Nullable`1<int> ProcessorCount; // 0x10
        public System.Nullable`1<bool> SupportsVibration; // 0x18
        public string DeviceType; // 0x20
        public string CpuDescription; // 0x28
        public string DeviceName; // 0x30
        public string DeviceUniqueIdentifier; // 0x38
        public string DeviceModel; // 0x40
        public System.Nullable`1<int> SystemMemorySize; // 0x48
        public System.Nullable`1<int> GraphicsDeviceId; // 0x50
        public string GraphicsDeviceName; // 0x58
        public string GraphicsDeviceVendorId; // 0x60
        public string GraphicsDeviceVendor; // 0x68
        public System.Nullable`1<int> GraphicsMemorySize; // 0x70
        public System.Nullable`1<bool> GraphicsMultiThreaded; // 0x78
        public string NpotSupport; // 0x80
        public string GraphicsDeviceVersion; // 0x88
        public string GraphicsDeviceType; // 0x90
        public System.Nullable`1<int> MaxTextureSize; // 0x98
        public System.Nullable`1<bool> SupportsDrawCallInstancing; // 0xA0
        public System.Nullable`1<bool> SupportsRayTracing; // 0xA2
        public System.Nullable`1<bool> SupportsComputeShaders; // 0xA4
        public System.Nullable`1<bool> SupportsGeometryShaders; // 0xA6
        public System.Nullable`1<int> GraphicsShaderLevel; // 0xA8
        public System.Nullable`1<bool> IsDebugBuild; // 0xB0
        public string EditorVersion; // 0xB8
        public string InstallMode; // 0xC0
        public string TargetFrameRate; // 0xC8
        public string CopyTextureSupport; // 0xD0
        public string RenderingThreadingMode; // 0xD8
        public System.Nullable`1<System.DateTimeOffset> StartTime; // 0xE0
        public Sentry.Unity.ISentrySystemInfo SentrySystemInfo; // 0xF8

        // ── Methods ──
        public void get_MainThreadId(){} // RVA: 0x7FFAC8B0BEC0
        public void set_MainThreadId(){} // RVA: 0x7FFAC8B0BF00
        public void get_OperatingSystem(){} // RVA: 0x7FFAC8B0BF50
        public void set_OperatingSystem(){} // RVA: 0x7FFAC8B0BF90
        public void get_ProcessorCount(){} // RVA: 0x7FFAC8B0C030
        public void set_ProcessorCount(){} // RVA: 0x7FFAC8B0C070
        public void get_SupportsVibration(){} // RVA: 0x7FFAC8B0C0C0
        public void set_SupportsVibration(){} // RVA: 0x7FFAC8B0C100
        public void get_DeviceType(){} // RVA: 0x7FFAC8B0C150
        public void set_DeviceType(){} // RVA: 0x7FFAC8B0C190
        public void get_CpuDescription(){} // RVA: 0x7FFAC8B0C230
        public void set_CpuDescription(){} // RVA: 0x7FFAC8B0C270
        public void get_DeviceName(){} // RVA: 0x7FFAC8B0C310
        public void set_DeviceName(){} // RVA: 0x7FFAC8B0C350
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAC8B0C3F0
        public void set_DeviceUniqueIdentifier(){} // RVA: 0x7FFAC8B0C430
        public void get_DeviceModel(){} // RVA: 0x7FFAC8B0C4D0
        public void set_DeviceModel(){} // RVA: 0x7FFAC8B0C510
        public void get_SystemMemorySize(){} // RVA: 0x7FFAC8B0C5B0
        public void set_SystemMemorySize(){} // RVA: 0x7FFAC8B0C5F0
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFAC8B0C640
        public void set_GraphicsDeviceId(){} // RVA: 0x7FFAC8B0C680
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFAC8B0C6D0
        public void set_GraphicsDeviceName(){} // RVA: 0x7FFAC8B0C710
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFAC8B0C7B0
        public void set_GraphicsDeviceVendorId(){} // RVA: 0x7FFAC8B0C7F0
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFAC8B0C890
        public void set_GraphicsDeviceVendor(){} // RVA: 0x7FFAC8B0C8D0
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFAC8B0C970
        public void set_GraphicsMemorySize(){} // RVA: 0x7FFAC8B0C9B0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFAC8B0CA00
        public void set_GraphicsMultiThreaded(){} // RVA: 0x7FFAC8B0CA40
        public void get_NpotSupport(){} // RVA: 0x7FFAC8B0CA90
        public void set_NpotSupport(){} // RVA: 0x7FFAC8B0CAD0
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFAC8B0CB70
        public void set_GraphicsDeviceVersion(){} // RVA: 0x7FFAC8B0CBB0
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFAC8B0CC50
        public void set_GraphicsDeviceType(){} // RVA: 0x7FFAC8B0CC90
        public void get_MaxTextureSize(){} // RVA: 0x7FFAC8B0CD30
        public void set_MaxTextureSize(){} // RVA: 0x7FFAC8B0CD70
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAC8B0CDC0
        public void set_SupportsDrawCallInstancing(){} // RVA: 0x7FFAC8B0CE00
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAC8B0CE50
        public void set_SupportsRayTracing(){} // RVA: 0x7FFAC8B0CE90
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAC8B0CEE0
        public void set_SupportsComputeShaders(){} // RVA: 0x7FFAC8B0CF20
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAC8B0CF70
        public void set_SupportsGeometryShaders(){} // RVA: 0x7FFAC8B0CFB0
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAC8B0D000
        public void set_GraphicsShaderLevel(){} // RVA: 0x7FFAC8B0D040
        public void get_IsDebugBuild(){} // RVA: 0x7FFAC8B0D090
        public void set_IsDebugBuild(){} // RVA: 0x7FFAC8B0D0D0
        public void get_EditorVersion(){} // RVA: 0x7FFAC8B0D120
        public void set_EditorVersion(){} // RVA: 0x7FFAC8B0D160
        public void get_InstallMode(){} // RVA: 0x7FFAC8B0D200
        public void set_InstallMode(){} // RVA: 0x7FFAC8B0D240
        public void get_TargetFrameRate(){} // RVA: 0x7FFAC8B0D2E0
        public void set_TargetFrameRate(){} // RVA: 0x7FFAC8B0D320
        public void get_CopyTextureSupport(){} // RVA: 0x7FFAC8B0D3C0
        public void set_CopyTextureSupport(){} // RVA: 0x7FFAC8B0D400
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFAC8B0D4A0
        public void set_RenderingThreadingMode(){} // RVA: 0x7FFAC8B0D4E0
        public void get_StartTime(){} // RVA: 0x7FFAC8B0D580
        public void set_StartTime(){} // RVA: 0x7FFAC8B0D5E0
        public void IsMainThread(){} // RVA: 0x7FFAC8B0D640
        public void get_SentrySystemInfo(){} // RVA: 0x7FFAC8B0D760
        public void set_SentrySystemInfo(){} // RVA: 0x7FFAC8B0D7A0
        public void CollectData(){} // RVA: 0x7FFAC8B0D840
    }

    public class NativeStackTrace : Object
    {
        public UIntPtr[] Frames; // 0x10
        public string ImageUuid; // 0x18
        public string ImageName; // 0x20

        // ── Methods ──
        public void get_Frames(){} // RVA: 0x7FFAC2F3C380
        public void set_Frames(){} // RVA: 0x7FFAC2F22E30
        public void get_ImageUuid(){} // RVA: 0x7FFAC2F247C0
        public void set_ImageUuid(){} // RVA: 0x7FFAC2F87E80
        public void get_ImageName(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ImageName(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC8B06EE0
    }

    public class SceneAdapter : ValueType
    {
        public string Name; // 0x10

        // ── Methods ──
        public void get_Name(){} // RVA: 0x7FFAC3AD9F60
        public void .ctor(){} // RVA: 0x7FFAC38DFE40
    }

    public class SceneManagerAdapter : Object
    {
        public System.Action`2<Sentry.Unity.SceneAdapter,0x6B182848> SceneLoaded; // 0x10
        public System.Action`1<Sentry.Unity.SceneAdapter> SceneUnloaded; // 0x18
        public System.Action`2<Sentry.Unity.SceneAdapter,Sentry.Unity.SceneAdapter> ActiveSceneChanged; // 0x20
        public Sentry.Unity.SceneManagerAdapter Instance;

        // ── Methods ──
        public void add_SceneLoaded(){} // RVA: 0x7FFAC8B08D10
        public void remove_SceneLoaded(){} // RVA: 0x7FFAC8B08E10
        public void add_SceneUnloaded(){} // RVA: 0x7FFAC8B08F10
        public void remove_SceneUnloaded(){} // RVA: 0x7FFAC8B09010
        public void add_ActiveSceneChanged(){} // RVA: 0x7FFAC8B09110
        public void remove_ActiveSceneChanged(){} // RVA: 0x7FFAC8B09210
        public void .ctor(){} // RVA: 0x7FFAC8B09310
        public void .cctor(){} // RVA: 0x7FFAC8B09650
        public void <.ctor>b__10_0(){} // RVA: 0x7FFAC8B09700
        public void <.ctor>b__10_1(){} // RVA: 0x7FFAC8B097F0
        public void <.ctor>b__10_2(){} // RVA: 0x7FFAC8B098C0
    }

    public class SceneManagerTracingAPI : SceneManagerAPI
    {
        public Sentry.Extensibility.IDiagnosticLogger _logger; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8227DD0
        public void LoadSceneAsyncByNameOrIndex(){} // RVA: 0x7FFAC8227E70
    }

    public class SceneManagerTracingIntegration : Object
    {
        public Sentry.Extensibility.IDiagnosticLogger Logger;

        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAC8227AE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ScopeObserver : Object
    {
        public Sentry.SentryOptions _options; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC84642F0
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8B0EAE0
        public void AddBreadcrumbImpl(){} // RVA: 0x7FFAC2C70A40
        public void SetExtra(){} // RVA: 0x7FFAC8B0ECF0
        public void SetExtraImpl(){} // RVA: 0x7FFAC2C79B30
        public void SetTag(){} // RVA: 0x7FFAC8B0F030
        public void SetTagImpl(){} // RVA: 0x7FFAC2C79B30
        public void UnsetTag(){} // RVA: 0x7FFAC8B0F210
        public void UnsetTagImpl(){} // RVA: 0x7FFAC2C70A40
        public void SetUser(){} // RVA: 0x7FFAC8B0F3B0
        public void SetUserImpl(){} // RVA: 0x7FFAC2C70A40
        public void UnsetUserImpl(){} // RVA: 0x7FFAC2C70980
    }

    public class ScreenshotAttachment : SentryAttachment
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B0F670
    }

    public class ScreenshotAttachmentContent : Object
    {
        public Sentry.Unity.SentryUnityOptions _options; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetStream(){} // RVA: 0x7FFAC8B0F6F0
        public void GetTargetResolution(){} // RVA: 0x7FFAC8B0F940
        public void CaptureScreenshot(){} // RVA: 0x7FFAC8B0F960
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
        public 0x6B28BB88 AttachViewHierarchy; // 0x5C
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
        public 0x6B198168 IsEnvironmentUser; // 0x80
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
        public System.Collections.Generic.List`1<int> FilterWebExceptions; // 0xA8
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
        public Sentry.Unity.SentryRuntimeOptionsConfiguration OptionsConfiguration; // 0xC0
        public Sentry.Unity.SentryBuildTimeOptionsConfiguration Debug; // 0xC8
        public Sentry.Unity.SentryOptionsConfiguration DebugOnlyInEditor; // 0xD0
        public bool DiagnosticLevel; // 0xD8
        public bool <DebugOnlyInEditor>k__BackingField; // 0xD9
        public 0x6B198C68 <DiagnosticLevel>k__BackingField; // 0xDA

        // ── Methods ──
        public void GetConfigPath(){} // RVA: 0x7FFAC8B10250
        public void get_Enabled(){} // RVA: 0x7FFAC2F3C4E0
        public void set_Enabled(){} // RVA: 0x7FFAC2F3C4F0
        public void get_Dsn(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Dsn(){} // RVA: 0x7FFAC2F4F0D0
        public void get_CaptureInEditor(){} // RVA: 0x7FFAC30F6BA0
        public void set_CaptureInEditor(){} // RVA: 0x7FFAC3C24F40
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFAC386C550
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFAC43B4D70
        public void get_DebounceTimeLog(){} // RVA: 0x7FFAC3C891D0
        public void set_DebounceTimeLog(){} // RVA: 0x7FFAC45B6490
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFAC2F7CCD0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFAC2F7CCE0
        public void get_DebounceTimeError(){} // RVA: 0x7FFAC3ADEDC0
        public void set_DebounceTimeError(){} // RVA: 0x7FFAC416A6E0
        public void get_TracesSampleRate(){} // RVA: 0x7FFAC5C75050
        public void set_TracesSampleRate(){} // RVA: 0x7FFAC5C75060
        public void get_AutoStartupTraces(){} // RVA: 0x7FFAC2FDCC00
        public void set_AutoStartupTraces(){} // RVA: 0x7FFAC2FDCC10
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFAC31D8A60
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFAC31D8A10
        public void get_AutoAwakeTraces(){} // RVA: 0x7FFAC31D90A0
        public void set_AutoAwakeTraces(){} // RVA: 0x7FFAC31D9200
        public void get_AutoSessionTracking(){} // RVA: 0x7FFAC3FA0E90
        public void set_AutoSessionTracking(){} // RVA: 0x7FFAC45A8320
        public void get_AutoSessionTrackingInterval(){} // RVA: 0x7FFAC2FC20A0
        public void set_AutoSessionTrackingInterval(){} // RVA: 0x7FFAC2FC20B0
        public void get_ReleaseOverride(){} // RVA: 0x7FFAC2F9C730
        public void set_ReleaseOverride(){} // RVA: 0x7FFAC2F9C740
        public void get_EnvironmentOverride(){} // RVA: 0x7FFAC2FC20E0
        public void set_EnvironmentOverride(){} // RVA: 0x7FFAC30794D0
        public void get_AttachStacktrace(){} // RVA: 0x7FFAC313F600
        public void set_AttachStacktrace(){} // RVA: 0x7FFAC3892770
        public void get_AttachScreenshot(){} // RVA: 0x7FFAC778CF40
        public void set_AttachScreenshot(){} // RVA: 0x7FFAC87B5A20
        public void get_ScreenshotQuality(){} // RVA: 0x7FFAC313CBA0
        public void set_ScreenshotQuality(){} // RVA: 0x7FFAC362EB40
        public void get_ScreenshotCompression(){} // RVA: 0x7FFAC3138C20
        public void set_ScreenshotCompression(){} // RVA: 0x7FFAC3138C10
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFAC3F45FE0
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFAC47BAB40
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAC47BAB50
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAC47BAB60
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAC47BAB70
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAC47BAB80
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFAC3B99E80
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFAC30B6520
        public void get_BreadcrumbsForLogs(){} // RVA: 0x7FFAC3BCD8B0
        public void set_BreadcrumbsForLogs(){} // RVA: 0x7FFAC81C5400
        public void get_BreadcrumbsForWarnings(){} // RVA: 0x7FFAC3C05B90
        public void set_BreadcrumbsForWarnings(){} // RVA: 0x7FFAC8B102D0
        public void get_BreadcrumbsForAsserts(){} // RVA: 0x7FFAC3C03700
        public void set_BreadcrumbsForAsserts(){} // RVA: 0x7FFAC8B102E0
        public void get_BreadcrumbsForErrors(){} // RVA: 0x7FFAC8B102F0
        public void set_BreadcrumbsForErrors(){} // RVA: 0x7FFAC8B10300
        public void get_BreadcrumbsForExceptions(){} // RVA: 0x7FFAC33CE5C0
        public void set_BreadcrumbsForExceptions(){} // RVA: 0x7FFAC3D20B50
        public void get_MaxBreadcrumbs(){} // RVA: 0x7FFAC4598F70
        public void set_MaxBreadcrumbs(){} // RVA: 0x7FFAC89E0310
        public void get_ReportAssembliesMode(){} // RVA: 0x7FFAC35729C0
        public void set_ReportAssembliesMode(){} // RVA: 0x7FFAC3572BF0
        public void get_SendDefaultPii(){} // RVA: 0x7FFAC3000CE0
        public void set_SendDefaultPii(){} // RVA: 0x7FFAC3000CF0
        public void get_IsEnvironmentUser(){} // RVA: 0x7FFAC3BEC620
        public void set_IsEnvironmentUser(){} // RVA: 0x7FFAC8B10310
        public void get_EnableOfflineCaching(){} // RVA: 0x7FFAC3F3C7F0
        public void set_EnableOfflineCaching(){} // RVA: 0x7FFAC8B10320
        public void get_MaxCacheItems(){} // RVA: 0x7FFAC37EE8C0
        public void set_MaxCacheItems(){} // RVA: 0x7FFAC37F9DE0
        public void get_InitCacheFlushTimeout(){} // RVA: 0x7FFAC5F56E80
        public void set_InitCacheFlushTimeout(){} // RVA: 0x7FFAC65A0990
        public void get_SampleRate(){} // RVA: 0x7FFAC2F89540
        public void set_SampleRate(){} // RVA: 0x7FFAC2F89550
        public void get_ShutdownTimeout(){} // RVA: 0x7FFAC3220670
        public void set_ShutdownTimeout(){} // RVA: 0x7FFAC342B670
        public void get_MaxQueueItems(){} // RVA: 0x7FFAC489E530
        public void set_MaxQueueItems(){} // RVA: 0x7FFAC489E540
        public void get_AnrDetectionEnabled(){} // RVA: 0x7FFAC8B10330
        public void set_AnrDetectionEnabled(){} // RVA: 0x7FFAC81B7590
        public void get_AnrTimeout(){} // RVA: 0x7FFAC489E510
        public void set_AnrTimeout(){} // RVA: 0x7FFAC489E550
        public void get_CaptureFailedRequests(){} // RVA: 0x7FFAC3145120
        public void set_CaptureFailedRequests(){} // RVA: 0x7FFAC313EEF0
        public void get_FailedRequestStatusCodes(){} // RVA: 0x7FFAC354B1A0
        public void set_FailedRequestStatusCodes(){} // RVA: 0x7FFAC334B370
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFAC41E71E0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFAC41E6D30
        public void get_FilterWebExceptions(){} // RVA: 0x7FFAC65394B0
        public void set_FilterWebExceptions(){} // RVA: 0x7FFAC65394C0
        public void get_FilterSocketExceptions(){} // RVA: 0x7FFAC893FD30
        public void set_FilterSocketExceptions(){} // RVA: 0x7FFAC893FD40
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFAC893FD50
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFAC893FD60
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAC893FD70
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAC893FD80
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFAC8B10340
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFAC8B10350
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFAC8B10360
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFAC8B10370
        public void get_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFAC431B350
        public void set_PostGenerateGradleProjectCallbackOrder(){} // RVA: 0x7FFAC431A220
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAC88C71A0
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAC88C71B0
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFAC8B10380
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFAC8B10390
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAC8B103A0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAC8B103B0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAC8B103C0
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAC8B103D0
        public void get_RuntimeOptionsConfiguration(){} // RVA: 0x7FFAC2F8C120
        public void set_RuntimeOptionsConfiguration(){} // RVA: 0x7FFAC2F8C130
        public void get_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFAC3079460
        public void set_BuildTimeOptionsConfiguration(){} // RVA: 0x7FFAC3079470
        public void get_OptionsConfiguration(){} // RVA: 0x7FFAC303E100
        public void set_OptionsConfiguration(){} // RVA: 0x7FFAC303E110
        public void get_Debug(){} // RVA: 0x7FFAC3DBD9E0
        public void set_Debug(){} // RVA: 0x7FFAC88C7210
        public void get_DebugOnlyInEditor(){} // RVA: 0x7FFAC8B103E0
        public void set_DebugOnlyInEditor(){} // RVA: 0x7FFAC8B103F0
        public void get_DiagnosticLevel(){} // RVA: 0x7FFAC8B10400
        public void set_DiagnosticLevel(){} // RVA: 0x7FFAC8B10410
        public void LoadSentryUnityOptions(){} // RVA: 0x7FFAC8B10420
        public void ToSentryUnityOptions(){} // RVA: 0x7FFAC8B104A0
        public void HandlePlatformRestrictedOptions(){} // RVA: 0x7FFAC8B11240
        public void HandleExceptionFilter(){} // RVA: 0x7FFAC8B114A0
        public void ShouldDebug(){} // RVA: 0x7FFAC8B11560
        public void .ctor(){} // RVA: 0x7FFAC8B11580
    }

    public class SentryBuildTimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAC2C79B30
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SentryCliOptions : ScriptableObject
    {
        public string UploadSymbols;
        public string UploadDevelopmentSymbols;
        public bool UploadSources; // 0x18
        public bool UrlOverride; // 0x19
        public bool Auth; // 0x1A
        public string Organization; // 0x20
        public string Project; // 0x28
        public string IgnoreCliErrors; // 0x30
        public string CliOptionsConfiguration; // 0x38
        public bool <IgnoreCliErrors>k__BackingField; // 0x40
        public Sentry.Unity.SentryCliOptionsConfiguration <CliOptionsConfiguration>k__BackingField; // 0x48

        // ── Methods ──
        public void get_UploadSymbols(){} // RVA: 0x7FFAC2F3C4E0
        public void set_UploadSymbols(){} // RVA: 0x7FFAC2F3C4F0
        public void get_UploadDevelopmentSymbols(){} // RVA: 0x7FFAC3228D50
        public void set_UploadDevelopmentSymbols(){} // RVA: 0x7FFAC3515120
        public void get_UploadSources(){} // RVA: 0x7FFAC45FA190
        public void set_UploadSources(){} // RVA: 0x7FFAC45F9AE0
        public void get_UrlOverride(){} // RVA: 0x7FFAC2F4F0C0
        public void set_UrlOverride(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Auth(){} // RVA: 0x7FFAC2F4F130
        public void set_Auth(){} // RVA: 0x7FFAC2F22E90
        public void get_Organization(){} // RVA: 0x7FFAC31D95E0
        public void set_Organization(){} // RVA: 0x7FFAC2F4F890
        public void get_Project(){} // RVA: 0x7FFAC31D0140
        public void set_Project(){} // RVA: 0x7FFAC31D0C20
        public void get_IgnoreCliErrors(){} // RVA: 0x7FFAC2FDCC00
        public void set_IgnoreCliErrors(){} // RVA: 0x7FFAC2FDCC10
        public void get_CliOptionsConfiguration(){} // RVA: 0x7FFAC2F9C730
        public void set_CliOptionsConfiguration(){} // RVA: 0x7FFAC2F9C740
        public void GetConfigPath(){} // RVA: 0x7FFAC8B11BA0
        public void MissingFieldWarning(){} // RVA: 0x7FFAC8B11C20
        public void IsValid(){} // RVA: 0x7FFAC8B11CE0
        public void .ctor(){} // RVA: 0x7FFAC8B11E70
    }

    public class SentryCliOptionsConfiguration : ScriptableObject
    {
        public string Template;

        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFAC8B11E80
        public void Configure(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void .cctor(){} // RVA: 0x7FFAC8B11EE0
    }

    public class SentryInitialization : Object
    {
        public Sentry.ISpan InitSpan;
        public Sentry.ISpan SubSystemRegistrationSpan; // 0x8

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8225E00
    }

    public class SentryIntegrations : Object
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAC8226E30
    }

    public class SentryMonoBehaviour : MonoBehaviour
    {
        public Sentry.Unity.SentryMonoBehaviour Instance;
        public System.Action Application; // 0x20
        public System.Action ApplicationPausing; // 0x28
        public bool _isRunning; // 0x30
        public Sentry.Unity.Integrations.IApplication _application; // 0x38

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8B11F90
        public void StartAwakeSpan(){} // RVA: 0x7FFAC8B121B0
        public void FinishAwakeSpan(){} // RVA: 0x7FFAC8B12350
        public void add_ApplicationResuming(){} // RVA: 0x7FFAC8B123D0
        public void remove_ApplicationResuming(){} // RVA: 0x7FFAC8B124C0
        public void add_ApplicationPausing(){} // RVA: 0x7FFAC8B125B0
        public void remove_ApplicationPausing(){} // RVA: 0x7FFAC8B126A0
        public void get_Application(){} // RVA: 0x7FFAC8B12790
        public void set_Application(){} // RVA: 0x7FFAC31D0C20
        public void UpdatePauseStatus(){} // RVA: 0x7FFAC8B12850
        public void OnApplicationPause(){} // RVA: 0x7FFAC8B12850
        public void OnApplicationFocus(){} // RVA: 0x7FFAC8B12890
        public void OnApplicationQuit(){} // RVA: 0x7FFAC8B128D0
        public void Awake(){} // RVA: 0x7FFAC8B12970
        public void .ctor(){} // RVA: 0x7FFAC2FD5710
    }

    public class SentryOptionsConfiguration : ScriptableObject
    {
        public string Template;

        // ── Methods ──
        public void GetAssetPath(){} // RVA: 0x7FFAC8B12A40
        public void Configure(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
        public void .cctor(){} // RVA: 0x7FFAC8B12AA0
    }

    public class SentryRuntimeOptionsConfiguration : ScriptableObject
    {
        // ── Methods ──
        public void Configure(){} // RVA: 0x7FFAC2C70A40
        public void .ctor(){} // RVA: 0x7FFAC312F5F0
    }

    public class SentrySystemInfoAdapter : Object
    {
        public Sentry.Unity.SentrySystemInfoAdapter MainThreadId;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_MainThreadId(){} // RVA: 0x7FFAC8B15BE0
        public void get_OperatingSystem(){} // RVA: 0x7FFAC8B15C80
        public void get_ProcessorCount(){} // RVA: 0x7FFAC8B15CD0
        public void get_SupportsVibration(){} // RVA: 0x7FFAC8B15D50
        public void get_DeviceType(){} // RVA: 0x7FFAC8B15DD0
        public void get_CpuDescription(){} // RVA: 0x7FFAC8B15F70
        public void get_DeviceName(){} // RVA: 0x7FFAC8B15FC0
        public void get_DeviceUniqueIdentifier(){} // RVA: 0x7FFAC8B16220
        public void get_DeviceModel(){} // RVA: 0x7FFAC8B163C0
        public void get_SystemMemorySize(){} // RVA: 0x7FFAC8B16560
        public void get_GraphicsDeviceId(){} // RVA: 0x7FFAC8B165E0
        public void get_GraphicsDeviceName(){} // RVA: 0x7FFAC8B16660
        public void get_GraphicsDeviceVendorId(){} // RVA: 0x7FFAC8B166B0
        public void get_GraphicsDeviceVendor(){} // RVA: 0x7FFAC8B16850
        public void get_GraphicsMemorySize(){} // RVA: 0x7FFAC8B168A0
        public void get_GraphicsMultiThreaded(){} // RVA: 0x7FFAC8B16920
        public void get_NpotSupport(){} // RVA: 0x7FFAC8B16AB0
        public void get_GraphicsDeviceVersion(){} // RVA: 0x7FFAC8B16B40
        public void get_GraphicsDeviceType(){} // RVA: 0x7FFAC8B16B90
        public void get_MaxTextureSize(){} // RVA: 0x7FFAC8B16C20
        public void get_SupportsDrawCallInstancing(){} // RVA: 0x7FFAC8B16CA0
        public void get_SupportsRayTracing(){} // RVA: 0x7FFAC8B16D20
        public void get_SupportsComputeShaders(){} // RVA: 0x7FFAC8B16DA0
        public void get_SupportsGeometryShaders(){} // RVA: 0x7FFAC8B16E20
        public void get_GraphicsShaderLevel(){} // RVA: 0x7FFAC8B16EA0
        public void get_GraphicsUVStartsAtTop(){} // RVA: 0x7FFAC8B16F20
        public void get_IsDebugBuild(){} // RVA: 0x7FFAC8B16FA0
        public void get_EditorVersion(){} // RVA: 0x7FFAC8B17130
        public void get_InstallMode(){} // RVA: 0x7FFAC8B171B0
        public void get_TargetFrameRate(){} // RVA: 0x7FFAC8B17270
        public void get_CopyTextureSupport(){} // RVA: 0x7FFAC8B17410
        public void get_RenderingThreadingMode(){} // RVA: 0x7FFAC8B175B0
        public void get_StartTime(){} // RVA: 0x7FFAC8B17750
        public void .cctor(){} // RVA: 0x7FFAC8B178E0
    }

    public class SentryUnity : Object
    {
        public Sentry.Unity.SentryUnitySdk UnitySdk;

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC8B12C40 | overloaded x2
        public void Close(){} // RVA: 0x7FFAC8B12D40
    }

    public class SentryUnityInfo : Object
    {
        public Sentry.Unity.Il2CppMethods IL2CPP; // 0x10

        // ── Methods ──
        public void get_IL2CPP(){} // RVA: 0x7FFAC3006850
        public void get_Il2CppMethods(){} // RVA: 0x7FFAC2F3C380
        public void SanitizeDebugId(){} // RVA: 0x7FFAC8226420
        public void Il2CppGcHandleGetTargetShim(){} // RVA: 0x7FFAC8226490
        public void il2cpp_gchandle_get_target(){} // RVA: 0x7FFAC8226490
        public void il2cpp_free(){} // RVA: 0x7FFAC82264A0
        public void Il2CppNativeStackTraceShim(){} // RVA: 0x7FFAC82264B0
        public void il2cpp_native_stack_trace(){} // RVA: 0x7FFAC82266E0
        public void IsKnownPlatform(){} // RVA: 0x7FFAC82266F0
        public void IsLinux(){} // RVA: 0x7FFAC8226790
        public void IsNativeSupportEnabled(){} // RVA: 0x7FFAC8226820
        public void IsSupportedBySentryNative(){} // RVA: 0x7FFAC82268C0
        public void GetDebugImageType(){} // RVA: 0x7FFAC82268E0
        public void .ctor(){} // RVA: 0x7FFAC82269B0
    }

    public class SentryUnityOptions : SentryOptions
    {
        public string Enabled;
        public bool AutoStartupTraces; // 0x288
        public bool AutoSceneLoadTraces; // 0x289
        public bool CaptureInEditor; // 0x28A
        public bool EnableLogDebouncing; // 0x28B
        public bool DebounceTimeLog; // 0x28C
        public System.TimeSpan DebounceTimeWarning; // 0x290
        public System.TimeSpan DebounceTimeError; // 0x298
        public System.TimeSpan RequestBodyCompressionLevel; // 0x2A0
        public 0x6B28BB30 AttachScreenshot; // 0x2A8
        public bool AttachViewHierarchy; // 0x2AC
        public bool MaxViewHierarchyRootObjects; // 0x2AD
        public int MaxViewHierarchyObjectChildCount; // 0x2B0
        public int MaxViewHierarchyDepth; // 0x2B4
        public int ScreenshotQuality; // 0x2B8
        public 0x6B28BB88 ScreenshotCompression; // 0x2BC
        public int AddBreadcrumbsForLogType; // 0x2C0
        public System.Collections.Generic.Dictionary`2<0x6B179630,bool> AnrTimeout; // 0x2C8
        public System.TimeSpan FilterBadGatewayExceptions; // 0x2D0
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
        public 0x6B19A058 DefaultUserId; // 0x2E4
        public string NativeContextWriter; // 0x2E8
        public bool NativeSupportCloseCallback; // 0x2F0
        public Sentry.Unity.ContextWriter SdkIntegrationNames; // 0x2F8
        public System.Action <NativeSupportCloseCallback>k__BackingField; // 0x300
        public System.Collections.Generic.List`1<string> <SdkIntegrationNames>k__BackingField; // 0x308

        // ── Methods ──
        public void get_Enabled(){} // RVA: 0x7FFAC4139B80
        public void set_Enabled(){} // RVA: 0x7FFAC8B12E00
        public void get_AutoStartupTraces(){} // RVA: 0x7FFAC8B12E10
        public void set_AutoStartupTraces(){} // RVA: 0x7FFAC8B12E20
        public void get_AutoSceneLoadTraces(){} // RVA: 0x7FFAC8B12E30
        public void set_AutoSceneLoadTraces(){} // RVA: 0x7FFAC8B12E40
        public void get_CaptureInEditor(){} // RVA: 0x7FFAC8B12E50
        public void set_CaptureInEditor(){} // RVA: 0x7FFAC8B12E60
        public void get_EnableLogDebouncing(){} // RVA: 0x7FFAC8B12E70
        public void set_EnableLogDebouncing(){} // RVA: 0x7FFAC8B12E80
        public void get_DebounceTimeLog(){} // RVA: 0x7FFAC39C6830
        public void set_DebounceTimeLog(){} // RVA: 0x7FFAC8B12E90
        public void get_DebounceTimeWarning(){} // RVA: 0x7FFAC39AE8B0
        public void set_DebounceTimeWarning(){} // RVA: 0x7FFAC8B12EA0
        public void get_DebounceTimeError(){} // RVA: 0x7FFAC39CF020
        public void set_DebounceTimeError(){} // RVA: 0x7FFAC8B12EB0
        public void get_RequestBodyCompressionLevel(){} // RVA: 0x7FFAC8B12EC0
        public void set_RequestBodyCompressionLevel(){} // RVA: 0x7FFAC8B12ED0
        public void get_AttachScreenshot(){} // RVA: 0x7FFAC8B12EF0
        public void set_AttachScreenshot(){} // RVA: 0x7FFAC8B12F00
        public void get_AttachViewHierarchy(){} // RVA: 0x7FFAC8B12F10
        public void set_AttachViewHierarchy(){} // RVA: 0x7FFAC8B12F20
        public void get_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAC8B12F30
        public void set_MaxViewHierarchyRootObjects(){} // RVA: 0x7FFAC8B12F40
        public void get_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAC8B12F50
        public void set_MaxViewHierarchyObjectChildCount(){} // RVA: 0x7FFAC8B12F60
        public void get_MaxViewHierarchyDepth(){} // RVA: 0x7FFAC8B12F70
        public void set_MaxViewHierarchyDepth(){} // RVA: 0x7FFAC8B12F80
        public void get_ScreenshotQuality(){} // RVA: 0x7FFAC8B12F90
        public void set_ScreenshotQuality(){} // RVA: 0x7FFAC8B12FA0
        public void get_ScreenshotCompression(){} // RVA: 0x7FFAC8B12FB0
        public void set_ScreenshotCompression(){} // RVA: 0x7FFAC8B12FC0
        public void get_AddBreadcrumbsForLogType(){} // RVA: 0x7FFAC39BDC80
        public void set_AddBreadcrumbsForLogType(){} // RVA: 0x7FFAC39B8FB0
        public void get_AnrTimeout(){} // RVA: 0x7FFAC39C8FB0
        public void set_AnrTimeout(){} // RVA: 0x7FFAC8B12FD0
        public void get_FilterBadGatewayExceptions(){} // RVA: 0x7FFAC8B12FE0
        public void set_FilterBadGatewayExceptions(){} // RVA: 0x7FFAC8B12FF0
        public void get_IosNativeSupportEnabled(){} // RVA: 0x7FFAC8B13000
        public void set_IosNativeSupportEnabled(){} // RVA: 0x7FFAC8B13010
        public void get_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAC8B13020
        public void set_AndroidNativeSupportEnabled(){} // RVA: 0x7FFAC8B13030
        public void get_NdkIntegrationEnabled(){} // RVA: 0x7FFAC8B13040
        public void set_NdkIntegrationEnabled(){} // RVA: 0x7FFAC8B13050
        public void get_NdkScopeSyncEnabled(){} // RVA: 0x7FFAC8B13060
        public void set_NdkScopeSyncEnabled(){} // RVA: 0x7FFAC8B13070
        public void get_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAC8B13080
        public void set_WindowsNativeSupportEnabled(){} // RVA: 0x7FFAC8B13090
        public void get_MacosNativeSupportEnabled(){} // RVA: 0x7FFAC8B130A0
        public void set_MacosNativeSupportEnabled(){} // RVA: 0x7FFAC8B130B0
        public void get_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAC8B130C0
        public void set_LinuxNativeSupportEnabled(){} // RVA: 0x7FFAC8B130D0
        public void get_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAC8B130E0
        public void set_Il2CppLineNumberSupportEnabled(){} // RVA: 0x7FFAC8B130F0
        public void get_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFAC8B13100
        public void set_PerformanceAutoInstrumentationEnabled(){} // RVA: 0x7FFAC8B13110
        public void get_StackTraceMode(){} // RVA: 0x7FFAC8B13120
        public void set_StackTraceMode(){} // RVA: 0x7FFAC8B13130
        public void get_DefaultUserId(){} // RVA: 0x7FFAC39B2540
        public void set_DefaultUserId(){} // RVA: 0x7FFAC8B13140
        public void get_NativeContextWriter(){} // RVA: 0x7FFAC39C8A80
        public void set_NativeContextWriter(){} // RVA: 0x7FFAC39AE920
        public void get_NativeSupportCloseCallback(){} // RVA: 0x7FFAC2F8C1F0
        public void set_NativeSupportCloseCallback(){} // RVA: 0x7FFAC2F8C200
        public void get_SdkIntegrationNames(){} // RVA: 0x7FFAC39AD170
        public void set_SdkIntegrationNames(){} // RVA: 0x7FFAC39BF770
        public void .ctor(){} // RVA: 0x7FFAC8B13340 | overloaded x3
        public void ToString(){} // RVA: 0x7FFAC8B140F0
    }

    public class SentryUnityOptionsExtensions : Object
    {
        // ── Methods ──
        public void ShouldInitializeSdk(){} // RVA: 0x7FFAC8B143E0 | overloaded x2
        public void IsValid(){} // RVA: 0x7FFAC8B145C0
        public void SetupLogging(){} // RVA: 0x7FFAC8B146A0
        public void AddIl2CppExceptionProcessor(){} // RVA: 0x7FFAC8B14890
        public void DisableUnityApplicationLoggingIntegration(){} // RVA: 0x7FFAC8B14990
        public void DisableAnrIntegration(){} // RVA: 0x7FFAC8B149E0
        public void DisableBadGatewayExceptionFilter(){} // RVA: 0x7FFAC8B14A30
        public void DisableWebExceptionFilter(){} // RVA: 0x7FFAC8B14A80
        public void DisableSocketExceptionFilter(){} // RVA: 0x7FFAC8B14AD0
    }

    public class SentryUnitySdk : Object
    {
        public Sentry.Unity.SentryUnityOptions _options; // 0x10
        public System.IDisposable _dotnetSdk; // 0x18
        public System.IO.FileStream _lockFile; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Init(){} // RVA: 0x7FFAC8B14B20
        public void Close(){} // RVA: 0x7FFAC8B15120
    }

    public class StartupTracingIntegration : Object
    {
        public Sentry.ISpan AfterAssembliesSpan;
        public Sentry.ISpan SplashScreenSpan; // 0x8
        public Sentry.ISpan FirstSceneLoadSpan; // 0x10
        public bool StartupAlreadyCaptured; // 0x18
        public bool IntegrationRegistered; // 0x19
        public Sentry.Extensibility.IDiagnosticLogger Logger; // 0x20

        // ── Methods ──
        public void Register(){} // RVA: 0x7FFAC8226F60
        public void AfterAssembliesLoaded(){} // RVA: 0x7FFAC8227040
        public void BeforeSplashScreen(){} // RVA: 0x7FFAC8227270
        public void BeforeSceneLoad(){} // RVA: 0x7FFAC82274A0
        public void AfterSceneLoad(){} // RVA: 0x7FFAC82276D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class TagValueNormalizer : Object
    {
        // ── Methods ──
        public void ToTagValue(){} // RVA: 0x7FFAC8B188D0
    }

    public class TimeDebounceBase : Object
    {
        public System.TimeSpan Now; // 0x10
        public System.Nullable`1<System.DateTimeOffset> _barrierOffset; // 0x18

        // ── Methods ──
        public void get_Now(){} // RVA: 0x7FFAC8B18050
        public void Debounced(){} // RVA: 0x7FFAC8B18100
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class UnityEventProcessor : Object
    {
        public Sentry.Unity.SentryUnityOptions _sentryOptions; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Process(){} // RVA: 0x7FFAC8B18280 | overloaded x2
        public void SetEventContext(){} // RVA: 0x7FFAC8B182F0
        public void PopulateDevice(){} // RVA: 0x7FFAC8B184E0
        public void PopulateSdkIntegrations(){} // RVA: 0x7FFAC8B18730
    }

    public class UnityIl2CppEventExceptionProcessor : Object
    {
        public Sentry.Unity.SentryUnityOptions Options;
        public Sentry.Unity.ISentryUnityInfo UnityInfo; // 0x8
        public Sentry.Unity.Il2CppMethods _il2CppMethods; // 0x10
        public System.Lazy`1<System.Collections.Generic.List`1<DebugImageInfo>> DebugImagesSorted; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B03880
        public void Process(){} // RVA: 0x7FFAC8B03B70
        public void NormalizeUuid(){} // RVA: 0x7FFAC8B04F50
        public void FindDebugImageContainingAddress(){} // RVA: 0x7FFAC8B05000
        public void EnumerateChainedExceptions(){} // RVA: 0x7FFAC8B05170
        public void GetNativeStackTrace(){} // RVA: 0x7FFAC8B05280
        public void .cctor(){} // RVA: 0x7FFAC8B056A0
    }

    public class UnityLogger : Object
    {
        public string LogTag;
        public Sentry.SentryOptions _sentryOptions; // 0x10
        public UnityEngine.ILogger _logger; // 0x18

        // ── Methods ──
        public void IsEnabled(){} // RVA: 0x7FFAC8B18930
        public void .ctor(){} // RVA: 0x7FFAC8B18A70 | overloaded x2
        public void Log(){} // RVA: 0x7FFAC8B18B80
        public void GetUnityLogType(){} // RVA: 0x7FFAC8B18DD0
        public void ToString(){} // RVA: 0x7FFAC8B18E00
    }

    public class UnityScopeIntegration : Object
    {
        public Sentry.Unity.Integrations.IApplication _application; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void Register(){} // RVA: 0x7FFAC8B09D60
    }

    public class UnityScopeUpdater : Object
    {
        public Sentry.Unity.SentryUnityOptions _options; // 0x10
        public Sentry.Unity.Integrations.IApplication _application; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC34EC240
        public void ConfigureScope(){} // RVA: 0x7FFAC8B09F10
        public void PopulateSdk(){} // RVA: 0x7FFAC8B0A5C0
        public void PopulateApp(){} // RVA: 0x7FFAC8B0A7A0
        public void PopulateOperatingSystem(){} // RVA: 0x7FFAC8B0A900
        public void PopulateDevice(){} // RVA: 0x7FFAC8B0A9A0
        public void PopulateGpu(){} // RVA: 0x7FFAC8B0AF00
        public void PopulateUnity(){} // RVA: 0x7FFAC8B0B610
        public void PopulateTags(){} // RVA: 0x7FFAC8B0B8E0
        public void PopulateUser(){} // RVA: 0x7FFAC8B0BB80
    }

    public class UnitySdkInfo : Object
    {
        public string Version;
        public string Name;
        public string PackageName;

        // ── Methods ──
        public void get_Version(){} // RVA: 0x7FFAC8B09A50
        public void .cctor(){} // RVA: 0x7FFAC8B09AB0
    }

    public class UnityViewHierarchyAttachmentContent : Object
    {
        public Sentry.Unity.SentryUnityOptions _options; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
        public void GetStream(){} // RVA: 0x7FFAC8B18E40
        public void CaptureViewHierarchy(){} // RVA: 0x7FFAC8B18F10
        public void CreateViewHierarchy(){} // RVA: 0x7FFAC8B19120
        public void CreateNode(){} // RVA: 0x7FFAC8B19540
    }

    public class UnityViewHierarchyNode : ViewHierarchyNode
    {
        public string Tag; // 0x20
        public string Position; // 0x28
        public string Rotation; // 0x30
        public string Scale; // 0x38
        public System.Nullable`1<bool> Active; // 0x40
        public System.Collections.Generic.List`1<string> Extras; // 0x48

        // ── Methods ──
        public void get_Tag(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Tag(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Position(){} // RVA: 0x7FFAC2F4F130
        public void set_Position(){} // RVA: 0x7FFAC2F22E90
        public void get_Rotation(){} // RVA: 0x7FFAC31D95E0
        public void set_Rotation(){} // RVA: 0x7FFAC2F4F890
        public void get_Scale(){} // RVA: 0x7FFAC31D0140
        public void set_Scale(){} // RVA: 0x7FFAC31D0C20
        public void get_Active(){} // RVA: 0x7FFAC6D7BEA0
        public void set_Active(){} // RVA: 0x7FFAC8B19DB0
        public void get_Extras(){} // RVA: 0x7FFAC2F9C730
        public void set_Extras(){} // RVA: 0x7FFAC2F9C740
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void WriteAdditionalProperties(){} // RVA: 0x7FFAC8B19DC0
    }

    public class UnityWebRequestTransport : HttpTransportBase
    {
        public Sentry.Unity.SentryUnityOptions _options; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B1A520
        public void SendEnvelopeAsync(){} // RVA: 0x7FFAC8B1A5A0
        public void CreateWebRequest(){} // RVA: 0x7FFAC8B1A6A0
        public void GetResponse(){} // RVA: 0x7FFAC8B1AC40
    }

    public class WarningTimeDebounce : TimeDebounceBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC441EFB0
    }

    public class WebBackgroundWorker : Object
    {
        public Sentry.Unity.SentryMonoBehaviour QueuedItems; // 0x10
        public Sentry.Unity.UnityWebRequestTransport _transport; // 0x18
        public int <QueuedItems>k__BackingField; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8B1A1B0
        public void EnqueueEnvelope(){} // RVA: 0x7FFAC8B1A340
        public void FlushAsync(){} // RVA: 0x7FFAC8B1A480
        public void get_QueuedItems(){} // RVA: 0x7FFAC30DBBE0
    }

}