// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 164

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        public _1.Index grip; // 0x1C0
        public _1.ceControlChangedValue gripPressed; // 0x1C8
        public _1.ceControlChangedValue primary; // 0x1D0
        public _1.ceControlChangedValue trackpadPressed; // 0x1D8
        public _1.ceControlChangedValue triggerPressed; // 0x1E0

        // ── Methods ──
        public void get_grip(){} // RVA: 0x7FFD4E9622B0
        public void set_grip(){} // RVA: 0x7FFD4EDCD110
        public void get_gripPressed(){} // RVA: 0x7FFD4EDECB10
        public void set_gripPressed(){} // RVA: 0x7FFD4EDEF3F0
        public void get_primary(){} // RVA: 0x7FFD4EDE1920
        public void set_primary(){} // RVA: 0x7FFD4EDC8050
        public void get_trackpadPressed(){} // RVA: 0x7FFD4EDE0A30
        public void set_trackpadPressed(){} // RVA: 0x7FFD4EDEF5C0
        public void get_triggerPressed(){} // RVA: 0x7FFD4E818150
        public void set_triggerPressed(){} // RVA: 0x7FFD4EDD1270
        public void FinishSetup(){} // RVA: 0x7FFD54937140
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class InputLayoutLoader : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD54C29FE0
        public void RegisterInputLayouts(){} // RVA: 0x7FFD54C29FF0
    }

    public class OpenVRControllerWMR : XRController
    {
        public _1.utReport deviceVelocity; // 0x1B0
        public _1.utReport deviceAngularVelocity; // 0x1B8
        public _1.ceControlChangedValue touchpadClick; // 0x1C0
        public _1.ceControlChangedValue touchpadTouch; // 0x1C8
        public _1.ceControlChangedValue gripPressed; // 0x1D0
        public _1.ceControlChangedValue triggerPressed; // 0x1D8
        public _1.ceControlChangedValue menu; // 0x1E0
        public _1.Index trigger; // 0x1E8
        public _1.Index grip; // 0x1F0
        public _1.lSenseHIDUSBInputReport touchpad; // 0x1F8
        public _1.lSenseHIDUSBInputReport joystick; // 0x200

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFD4E969F30
        public void set_deviceVelocity(){} // RVA: 0x7FFD4EDC7790
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4E964330
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4EDCC050
        public void get_touchpadClick(){} // RVA: 0x7FFD4E9622B0
        public void set_touchpadClick(){} // RVA: 0x7FFD4EDCD110
        public void get_touchpadTouch(){} // RVA: 0x7FFD4EDECB10
        public void set_touchpadTouch(){} // RVA: 0x7FFD4EDEF3F0
        public void get_gripPressed(){} // RVA: 0x7FFD4EDE1920
        public void set_gripPressed(){} // RVA: 0x7FFD4EDC8050
        public void get_triggerPressed(){} // RVA: 0x7FFD4EDE0A30
        public void set_triggerPressed(){} // RVA: 0x7FFD4EDEF5C0
        public void get_menu(){} // RVA: 0x7FFD4E818150
        public void set_menu(){} // RVA: 0x7FFD4EDD1270
        public void get_trigger(){} // RVA: 0x7FFD4EDD1060
        public void set_trigger(){} // RVA: 0x7FFD4EDCC5A0
        public void get_grip(){} // RVA: 0x7FFD4E964EF0
        public void set_grip(){} // RVA: 0x7FFD4E961400
        public void get_touchpad(){} // RVA: 0x7FFD4E961460
        public void set_touchpad(){} // RVA: 0x7FFD4E964450
        public void get_joystick(){} // RVA: 0x7FFD4E964790
        public void set_joystick(){} // RVA: 0x7FFD4E96D230
        public void FinishSetup(){} // RVA: 0x7FFD54936450
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class OpenVREvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54C27DC0
    }

    public class OpenVREvents : Object
    {
        public ueuing.reateDepthStencilStateNoWrite instance;
        public ueuing.Compositor_CreateDepthStencilStateNoWrite[] events; // 0x10
        public int[] eventIndicies; // 0x18
        public object vrEvent; // 0x20
        public uint vrEventSize; // 0x60
        public bool preloadedEvents; // 0x64
        public int maxEventsPerUpdate;
        public bool debugLogAllEvents; // 0x8
        public bool enabled; // 0x9
        public bool exiting; // 0x65

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFD54C27E50
        public void IsInitialized(){} // RVA: 0x7FFD54C27F20
        public void .ctor(){} // RVA: 0x7FFD54C27F80
        public void RegisterDefaultEvents(){} // RVA: 0x7FFD54C283B0
        public void AddListener(){} // RVA: 0x7FFD54C284B0
        public void Add(){} // RVA: 0x7FFD54C28550
        public void RemoveListener(){} // RVA: 0x7FFD54C28730
        public void Remove(){} // RVA: 0x7FFD54C28840
        public void Update(){} // RVA: 0x7FFD54C28900
        public void PollEvents(){} // RVA: 0x7FFD54C28970
        public void On_VREvent_Quit(){} // RVA: 0x7FFD54C28C00
        public void .cctor(){} // RVA: 0x7FFD54C28D00
    }

    public class OpenVRHMD : XRHMD
    {
        public _1.utReport deviceVelocity; // 0x1E0
        public _1.utReport deviceAngularVelocity; // 0x1E8
        public _1.utReport leftEyeVelocity; // 0x1F0
        public _1.utReport leftEyeAngularVelocity; // 0x1F8
        public _1.utReport rightEyeVelocity; // 0x200
        public _1.utReport rightEyeAngularVelocity; // 0x208
        public _1.utReport centerEyeVelocity; // 0x210
        public _1.utReport centerEyeAngularVelocity; // 0x218

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFD4E818150
        public void set_deviceVelocity(){} // RVA: 0x7FFD4EDD1270
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4EDD1060
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4EDCC5A0
        public void get_leftEyeVelocity(){} // RVA: 0x7FFD4E964EF0
        public void set_leftEyeVelocity(){} // RVA: 0x7FFD4E961400
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7FFD4E961460
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7FFD4E964450
        public void get_rightEyeVelocity(){} // RVA: 0x7FFD4E964790
        public void set_rightEyeVelocity(){} // RVA: 0x7FFD4E96D230
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7FFD4E964780
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7FFD4E96D290
        public void get_centerEyeVelocity(){} // RVA: 0x7FFD4E96BCB0
        public void set_centerEyeVelocity(){} // RVA: 0x7FFD4E963140
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7FFD4E961470
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7FFD4E962420
        public void FinishSetup(){} // RVA: 0x7FFD54935FE0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class OpenVRHelpers : Object
    {
        // ── Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7FFD54C28D50
        public void DoesTypeExist(){} // RVA: 0x7FFD54C28DD0
        public void GetType(){} // RVA: 0x7FFD54C28E40
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7FFD54C296D0
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7FFD54C29970
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7FFD54C29AD0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class OpenVRLoader : XRLoaderHelper
    {
        public URA.woDigitYearMax<oducts.ty.Burst.dll> displaySubsystem;
        public URA.woDigitYearMax<oducts.Handle> inputSubsystem; // 0x8
        public bool running; // 0x20
        public Inherited.ttribute watcherFile; // 0x28
        public sageKind.nVideos watcherThread; // 0x30
        public string mirrorViewPath;
        public ueuing.reateOverlayVertexBuffer settings; // 0x38
        public rScript.<GetCachedEnumData>b__2_5[] events; // 0x40

        // ── Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7FFD54C2B370
        public void get_inputSubsystem(){} // RVA: 0x7FFD54C2B400
        public void Initialize(){} // RVA: 0x7FFD54C2B490
        public void GetEscapedApplicationName(){} // RVA: 0x7FFD54C2B9F0
        public void WatchForReload(){} // RVA: 0x7FFD4E341310
        public void CleanupReloadWatcher(){} // RVA: 0x7FFD4E341310
        public void Start(){} // RVA: 0x7FFD54C2BB80
        public void SetupFileSystemWatchers(){} // RVA: 0x7FFD54C2BD40
        public void SetupFileSystemWatcher(){} // RVA: 0x7FFD54C2BD40
        public void ManualFileWatcherLoop(){} // RVA: 0x7FFD54C2BEA0
        public void DestroyMirrorModeWatcher(){} // RVA: 0x7FFD54C2BFF0
        public void OnChanged(){} // RVA: 0x7FFD54C2C0B0
        public void ReadMirrorModeConfig(){} // RVA: 0x7FFD54C2C0C0
        public void Stop(){} // RVA: 0x7FFD54C2C750
        public void Deinitialize(){} // RVA: 0x7FFD54C2C830
        public void CleanupTick(){} // RVA: 0x7FFD54C2C900
        public void SetUserDefinedSettings(){} // RVA: 0x7FFD54C2C950
        public void GetInitializationResult(){} // RVA: 0x7FFD54C2CA80
        public void RegisterTickCallback(){} // RVA: 0x7FFD54C2CAF0
        public void TickCallback(){} // RVA: 0x7FFD54C2CB80
        public void .ctor(){} // RVA: 0x7FFD54C04660
        public void .cctor(){} // RVA: 0x7FFD54C2CC20
    }

    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        public _1.lSenseHIDUSBInputReport thumbstick; // 0x1B0
        public _1.Index trigger; // 0x1B8
        public _1.Index grip; // 0x1C0
        public _1.ceControlChangedValue primaryButton; // 0x1C8
        public _1.ceControlChangedValue secondaryButton; // 0x1D0
        public _1.ceControlChangedValue gripPressed; // 0x1D8
        public _1.ceControlChangedValue triggerPressed; // 0x1E0
        public _1.ceControlChangedValue thumbstickClicked; // 0x1E8
        public _1.ceControlChangedValue thumbstickTouched; // 0x1F0
        public _1.utReport deviceVelocity; // 0x1F8
        public _1.utReport deviceAngularVelocity; // 0x200

        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7FFD4E969F30
        public void set_thumbstick(){} // RVA: 0x7FFD4EDC7790
        public void get_trigger(){} // RVA: 0x7FFD4E964330
        public void set_trigger(){} // RVA: 0x7FFD4EDCC050
        public void get_grip(){} // RVA: 0x7FFD4E9622B0
        public void set_grip(){} // RVA: 0x7FFD4EDCD110
        public void get_primaryButton(){} // RVA: 0x7FFD4EDECB10
        public void set_primaryButton(){} // RVA: 0x7FFD4EDEF3F0
        public void get_secondaryButton(){} // RVA: 0x7FFD4EDE1920
        public void set_secondaryButton(){} // RVA: 0x7FFD4EDC8050
        public void get_gripPressed(){} // RVA: 0x7FFD4EDE0A30
        public void set_gripPressed(){} // RVA: 0x7FFD4EDEF5C0
        public void get_triggerPressed(){} // RVA: 0x7FFD4E818150
        public void set_triggerPressed(){} // RVA: 0x7FFD4EDD1270
        public void get_thumbstickClicked(){} // RVA: 0x7FFD4EDD1060
        public void set_thumbstickClicked(){} // RVA: 0x7FFD4EDCC5A0
        public void get_thumbstickTouched(){} // RVA: 0x7FFD4E964EF0
        public void set_thumbstickTouched(){} // RVA: 0x7FFD4E961400
        public void get_deviceVelocity(){} // RVA: 0x7FFD4E961460
        public void set_deviceVelocity(){} // RVA: 0x7FFD4E964450
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4E964790
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4E96D230
        public void FinishSetup(){} // RVA: 0x7FFD54937550
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class OpenVRSettings : ScriptableObject
    {
        public bool PromptToUpgradePackage; // 0x18
        public bool PromptToUpgradePreviewPackages; // 0x19
        public string SkipPromptForVersion; // 0x20
        public erCreateSession StereoRenderingMode; // 0x28
        public bufferDepth InitializationType; // 0x2C
        public string EditorAppKey; // 0x30
        public string ActionManifestFileRelativeFilePath; // 0x38
        public or_CannotDRMLeaseDisplay MirrorView; // 0x40
        public bool DisableOpenVREvents; // 0x44
        public bool PreInit; // 0x45
        public string StreamingAssetsFolderName;
        public string ActionManifestFileName;
        public bool HasCopiedDefaults; // 0x46
        public ueuing.reateOverlayVertexBuffer s_Settings;

        // ── Methods ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x7FFD54C2CE40
        public void CreateDirectory(){} // RVA: 0x7FFD54C2CFE0
        public void GetStereoRenderingMode(){} // RVA: 0x7FFD5218E100
        public void GetInitializationType(){} // RVA: 0x7FFD53F72B50
        public void GetMirrorViewMode(){} // RVA: 0x7FFD4E3E2080
        public void SetMirrorViewMode(){} // RVA: 0x7FFD54C2D710 | overloaded x2
        public void GenerateEditorAppKey(){} // RVA: 0x7FFD54C2D080
        public void CleanProductName(){} // RVA: 0x7FFD54C2D1F0
        public void GetSettings(){} // RVA: 0x7FFD54C2D5F0
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7FFD54C2D790
        public void Awake(){} // RVA: 0x7FFD54C2DB10
        public void .ctor(){} // RVA: 0x7FFD54C2DBB0
    }

    public class ViveLighthouse : TrackedDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class ViveTracker : TrackedDevice
    {
        public _1.utReport deviceVelocity; // 0x1B0
        public _1.utReport deviceAngularVelocity; // 0x1B8

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFD4E969F30
        public void set_deviceVelocity(){} // RVA: 0x7FFD4EDC7790
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4E964330
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4EDCC050
        public void FinishSetup(){} // RVA: 0x7FFD54936FF0
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

    public class ViveWand : XRControllerWithRumble
    {
        public _1.Index grip; // 0x1B0
        public _1.ceControlChangedValue gripPressed; // 0x1B8
        public _1.ceControlChangedValue primary; // 0x1C0
        public _1.ceControlChangedValue trackpadPressed; // 0x1C8
        public _1.ceControlChangedValue trackpadTouched; // 0x1D0
        public _1.lSenseHIDUSBInputReport trackpad; // 0x1D8
        public _1.Index trigger; // 0x1E0
        public _1.ceControlChangedValue triggerPressed; // 0x1E8
        public _1.utReport deviceVelocity; // 0x1F0
        public _1.utReport deviceAngularVelocity; // 0x1F8

        // ── Methods ──
        public void get_grip(){} // RVA: 0x7FFD4E969F30
        public void set_grip(){} // RVA: 0x7FFD4EDC7790
        public void get_gripPressed(){} // RVA: 0x7FFD4E964330
        public void set_gripPressed(){} // RVA: 0x7FFD4EDCC050
        public void get_primary(){} // RVA: 0x7FFD4E9622B0
        public void set_primary(){} // RVA: 0x7FFD4EDCD110
        public void get_trackpadPressed(){} // RVA: 0x7FFD4EDECB10
        public void set_trackpadPressed(){} // RVA: 0x7FFD4EDEF3F0
        public void get_trackpadTouched(){} // RVA: 0x7FFD4EDE1920
        public void set_trackpadTouched(){} // RVA: 0x7FFD4EDC8050
        public void get_trackpad(){} // RVA: 0x7FFD4EDE0A30
        public void set_trackpad(){} // RVA: 0x7FFD4EDEF5C0
        public void get_trigger(){} // RVA: 0x7FFD4E818150
        public void set_trigger(){} // RVA: 0x7FFD4EDD1270
        public void get_triggerPressed(){} // RVA: 0x7FFD4EDD1060
        public void set_triggerPressed(){} // RVA: 0x7FFD4EDCC5A0
        public void get_deviceVelocity(){} // RVA: 0x7FFD4E964EF0
        public void set_deviceVelocity(){} // RVA: 0x7FFD4E961400
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFD4E961460
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFD4E964450
        public void FinishSetup(){} // RVA: 0x7FFD54936A60
        public void .ctor(){} // RVA: 0x7FFD54936440
    }

}