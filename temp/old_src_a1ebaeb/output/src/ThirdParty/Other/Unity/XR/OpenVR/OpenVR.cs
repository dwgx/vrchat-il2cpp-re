// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 164

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        public object _primary; // 0x34D6A6E0, was: <primary>k__BackingField

        // ── Original Methods ──
        public void get_grip(){} // RVA: 0x7ffaa8f73670
        public void set_grip(){} // RVA: 0x7ffaa93e9360
        public void get_gripPressed(){} // RVA: 0x7ffaa93d5320
        public void set_gripPressed(){} // RVA: 0x7ffaa93e3d80
        public void get_primary(){} // RVA: 0x7ffaa93d4100
        public void set_primary(){} // RVA: 0x7ffaa93e7fd0
        public void get_trackpadPressed(){} // RVA: 0x7ffaa93e8b10
        public void set_trackpadPressed(){} // RVA: 0x7ffaa9400010
        public void get_triggerPressed(){} // RVA: 0x7ffaa8e19790
        public void set_triggerPressed(){} // RVA: 0x7ffaa93fdbe0
        public void FinishSetup(){} // RVA: 0x7ffaaef39110
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class InputLayoutLoader : Object
    {
        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf22bf40
        public void RegisterInputLayouts(){} // RVA: 0x7ffaaf22bf50
    }

    public class OpenVRControllerWMR : XRController
    {
        public object _touchpadClick; // 0x34D69C60, was: <touchpadClick>k__BackingField
        public object _triggerPressed; // 0x34D69C60, was: <triggerPressed>k__BackingFiel
        public object _grip; // 0x34D69C60, was: <grip>k__BackingField

        // ── Original Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7ffaa8f6f0f0
        public void set_deviceVelocity(){} // RVA: 0x7ffaa93d9af0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa8f78130
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa93e4fb0
        public void get_touchpadClick(){} // RVA: 0x7ffaa8f73670
        public void set_touchpadClick(){} // RVA: 0x7ffaa93e9360
        public void get_touchpadTouch(){} // RVA: 0x7ffaa93d5320
        public void set_touchpadTouch(){} // RVA: 0x7ffaa93e3d80
        public void get_gripPressed(){} // RVA: 0x7ffaa93d4100
        public void set_gripPressed(){} // RVA: 0x7ffaa93e7fd0
        public void get_triggerPressed(){} // RVA: 0x7ffaa93e8b10
        public void set_triggerPressed(){} // RVA: 0x7ffaa9400010
        public void get_menu(){} // RVA: 0x7ffaa8e19790
        public void set_menu(){} // RVA: 0x7ffaa93fdbe0
        public void get_trigger(){} // RVA: 0x7ffaa93d15b0
        public void set_trigger(){} // RVA: 0x7ffaa93d3cc0
        public void get_grip(){} // RVA: 0x7ffaa8f6fa20
        public void set_grip(){} // RVA: 0x7ffaa8f774b0
        public void get_touchpad(){} // RVA: 0x7ffaa8f74aa0
        public void set_touchpad(){} // RVA: 0x7ffaa8f744d0
        public void get_joystick(){} // RVA: 0x7ffaa8f7aa00
        public void set_joystick(){} // RVA: 0x7ffaa8f77dc0
        public void FinishSetup(){} // RVA: 0x7ffaaef38420
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OpenVREvent : UnityEvent`1
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf229d20
    }

    public class OpenVREvents : Object
    {
        public object eventIndicies; // 0x33BE6440
        public object preloadedEvents; // 0x33BE6440
        public object enabled; // 0x33BE6440

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaaf229db0
        public void IsInitialized(){} // RVA: 0x7ffaaf229e80
        public void .ctor(){} // RVA: 0x7ffaaf229ee0
        public void RegisterDefaultEvents(){} // RVA: 0x7ffaaf22a310
        public void AddListener(){} // RVA: 0x7ffaaf22a410
        public void Add(){} // RVA: 0x7ffaaf22a4b0
        public void RemoveListener(){} // RVA: 0x7ffaaf22a690
        public void Remove(){} // RVA: 0x7ffaaf22a7a0
        public void Update(){} // RVA: 0x7ffaaf22a860
        public void PollEvents(){} // RVA: 0x7ffaaf22a8d0
        public void On_VREvent_Quit(){} // RVA: 0x7ffaaf22ab60
        public void .cctor(){} // RVA: 0x7ffaaf22ac60
    }

    public class OpenVRHMD : XRHMD
    {
        public object _leftEyeVelocity; // 0x3390C6E0, was: <leftEyeVelocity>k__BackingFie
        public object _rightEyeAngularVelocity; // 0x3390C6E0, was: <rightEyeAngularVelocity>k__Ba

        // ── Original Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7ffaa8e19790
        public void set_deviceVelocity(){} // RVA: 0x7ffaa93fdbe0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa93d15b0
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa93d3cc0
        public void get_leftEyeVelocity(){} // RVA: 0x7ffaa8f6fa20
        public void set_leftEyeVelocity(){} // RVA: 0x7ffaa8f774b0
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7ffaa8f74aa0
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7ffaa8f744d0
        public void get_rightEyeVelocity(){} // RVA: 0x7ffaa8f7aa00
        public void set_rightEyeVelocity(){} // RVA: 0x7ffaa8f77dc0
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7ffaa8f74940
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7ffaa8f77e20
        public void get_centerEyeVelocity(){} // RVA: 0x7ffaa8f6dbe0
        public void set_centerEyeVelocity(){} // RVA: 0x7ffaa8f6f550
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7ffaa8f70430
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7ffaa8f7aac0
        public void FinishSetup(){} // RVA: 0x7ffaaef37fb0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OpenVRHelpers : Object
    {
        // ── Original Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7ffaaf22acb0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void DoesTypeExist(){} // RVA: 0x7ffaaf22ad30
        public void GetType(){} // RVA: 0x7ffaaf22ada0
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7ffaaf22b630
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7ffaaf22b8d0
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7ffaaf22ba30
    }

    public class OpenVRLoader : XRLoaderHelper
    {
        public object running; // 0x33724A10
        public object mirrorViewPath; // 0x33724A10

        // ── Original Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7ffaaf22d2d0
        public void get_inputSubsystem(){} // RVA: 0x7ffaaf22d360
        public void Initialize(){} // RVA: 0x7ffaaf22d3f0
        public void WatchForReload(){} // RVA: 0x7ffaa8932310
        public void CleanupReloadWatcher(){} // RVA: 0x7ffaa8932310
        public void Start(){} // RVA: 0x7ffaaf22dae0
        public void ManualFileWatcherLoop(){} // RVA: 0x7ffaaf22de00
        public void DestroyMirrorModeWatcher(){} // RVA: 0x7ffaaf22df50
        public void OnChanged(){} // RVA: 0x7ffaaf22e010
        public void ReadMirrorModeConfig(){} // RVA: 0x7ffaaf22e020
        public void Stop(){} // RVA: 0x7ffaaf22e6b0
        public void Deinitialize(){} // RVA: 0x7ffaaf22e790
        public void CleanupTick(){} // RVA: 0x7ffaaf22e860
        public void RegisterTickCallback(){} // RVA: 0x7ffaaf22ea50
        public void TickCallback(){} // RVA: 0x7ffaaf22eae0
        public void .ctor(){} // RVA: 0x7ffaaf2065c0
        public void .cctor(){} // RVA: 0x7ffaaf22eb80
        // ── Binary Analysis Named ──
        public void GetEscapedApplicationName(){} // RVA: 0x7ffaaf22d950
        public void SetupFileSystemWatchers(){} // RVA: 0x7ffaaf22dca0
        public void SetupFileSystemWatcher(){} // RVA: 0x7ffaaf22dca0
        public void SetUserDefinedSettings(){} // RVA: 0x7ffaaf22e8b0
        public void GetInitializationResult(){} // RVA: 0x7ffaaf22e9e0
    }

    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        public object _grip; // 0x34D6A1A0, was: <grip>k__BackingField
        public object _gripPressed; // 0x34D6A1A0, was: <gripPressed>k__BackingField
        public object _thumbstickTouched; // 0x34D6A1A0, was: <thumbstickTouched>k__BackingF

        // ── Original Methods ──
        public void get_thumbstick(){} // RVA: 0x7ffaa8f6f0f0
        public void set_thumbstick(){} // RVA: 0x7ffaa93d9af0
        public void get_trigger(){} // RVA: 0x7ffaa8f78130
        public void set_trigger(){} // RVA: 0x7ffaa93e4fb0
        public void get_grip(){} // RVA: 0x7ffaa8f73670
        public void set_grip(){} // RVA: 0x7ffaa93e9360
        public void get_primaryButton(){} // RVA: 0x7ffaa93d5320
        public void set_primaryButton(){} // RVA: 0x7ffaa93e3d80
        public void get_secondaryButton(){} // RVA: 0x7ffaa93d4100
        public void set_secondaryButton(){} // RVA: 0x7ffaa93e7fd0
        public void get_gripPressed(){} // RVA: 0x7ffaa93e8b10
        public void set_gripPressed(){} // RVA: 0x7ffaa9400010
        public void get_triggerPressed(){} // RVA: 0x7ffaa8e19790
        public void set_triggerPressed(){} // RVA: 0x7ffaa93fdbe0
        public void get_thumbstickClicked(){} // RVA: 0x7ffaa93d15b0
        public void set_thumbstickClicked(){} // RVA: 0x7ffaa93d3cc0
        public void get_thumbstickTouched(){} // RVA: 0x7ffaa8f6fa20
        public void set_thumbstickTouched(){} // RVA: 0x7ffaa8f774b0
        public void get_deviceVelocity(){} // RVA: 0x7ffaa8f74aa0
        public void set_deviceVelocity(){} // RVA: 0x7ffaa8f744d0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa8f7aa00
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa8f77dc0
        public void FinishSetup(){} // RVA: 0x7ffaaef39520
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class OpenVRSettings : ScriptableObject
    {
        public object SkipPromptForVersion; // 0x33876F70
        public object EditorAppKey; // 0x33876F70
        public object DisableOpenVREvents; // 0x33876F70
        public object ActionManifestFileName; // 0x33876F70
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void CreateDirectory(){} // RVA: 0x7ffaaf22ef40
        public void GenerateEditorAppKey(){} // RVA: 0x7ffaaf22efe0
        public void CleanProductName(){} // RVA: 0x7ffaaf22f150
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7ffaaf22f6f0
        public void Awake(){} // RVA: 0x7ffaaf22fa70
        public void .ctor(){} // RVA: 0x7ffaaf22fb10
        // ── Binary Analysis Named ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x7ffaaf22eda0
        public void GetStereoRenderingMode(){} // RVA: 0x7ffaac77f0a0
        public void GetInitializationType(){} // RVA: 0x7ffaae573d50
        public void GetMirrorViewMode(){} // RVA: 0x7ffaa89d3080
        public void SetMirrorViewMode(){} // RVA: 0x7ffaaf22f670
        public void GetSettings(){} // RVA: 0x7ffaaf22f550
        public void SetMirrorViewMode(){} // RVA: 0x7ffaaf22f670
    }

    public class ViveLighthouse : TrackedDevice
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class ViveTracker : TrackedDevice
    {
        // ── Original Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7ffaa8f6f0f0
        public void set_deviceVelocity(){} // RVA: 0x7ffaa93d9af0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa8f78130
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa93e4fb0
        public void FinishSetup(){} // RVA: 0x7ffaaef38fc0
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

    public class ViveWand : XRControllerWithRumble
    {
        public object _primary; // 0x34D69F00, was: <primary>k__BackingField
        public object _trackpad; // 0x34D69F00, was: <trackpad>k__BackingField
        public object _deviceVelocity; // 0x34D69F00, was: <deviceVelocity>k__BackingFiel

        // ── Original Methods ──
        public void get_grip(){} // RVA: 0x7ffaa8f6f0f0
        public void set_grip(){} // RVA: 0x7ffaa93d9af0
        public void get_gripPressed(){} // RVA: 0x7ffaa8f78130
        public void set_gripPressed(){} // RVA: 0x7ffaa93e4fb0
        public void get_primary(){} // RVA: 0x7ffaa8f73670
        public void set_primary(){} // RVA: 0x7ffaa93e9360
        public void get_trackpadPressed(){} // RVA: 0x7ffaa93d5320
        public void set_trackpadPressed(){} // RVA: 0x7ffaa93e3d80
        public void get_trackpadTouched(){} // RVA: 0x7ffaa93d4100
        public void set_trackpadTouched(){} // RVA: 0x7ffaa93e7fd0
        public void get_trackpad(){} // RVA: 0x7ffaa93e8b10
        public void set_trackpad(){} // RVA: 0x7ffaa9400010
        public void get_trigger(){} // RVA: 0x7ffaa8e19790
        public void set_trigger(){} // RVA: 0x7ffaa93fdbe0
        public void get_triggerPressed(){} // RVA: 0x7ffaa93d15b0
        public void set_triggerPressed(){} // RVA: 0x7ffaa93d3cc0
        public void get_deviceVelocity(){} // RVA: 0x7ffaa8f6fa20
        public void set_deviceVelocity(){} // RVA: 0x7ffaa8f774b0
        public void get_deviceAngularVelocity(){} // RVA: 0x7ffaa8f74aa0
        public void set_deviceAngularVelocity(){} // RVA: 0x7ffaa8f744d0
        public void FinishSetup(){} // RVA: 0x7ffaaef38a30
        public void .ctor(){} // RVA: 0x7ffaaef38410
    }

}