// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 165

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        // ── Methods ──
        public void get_grip(){} // RVA: 0x7A8815B70
        public void set_grip(){} // RVA: 0x7A8B58420
        public void get_gripPressed(){} // RVA: 0x7A8B6AFA0
        public void set_gripPressed(){} // RVA: 0x7A8B58B30
        public void get_primary(){} // RVA: 0x7A8B79060
        public void set_primary(){} // RVA: 0x7A8B49820
        public void get_trackpadPressed(){} // RVA: 0x7A8B5ED30
        public void set_trackpadPressed(){} // RVA: 0x7A8B5E380
        public void get_triggerPressed(){} // RVA: 0x7A8688280
        public void set_triggerPressed(){} // RVA: 0x7A8B797E0
        public void FinishSetup(){} // RVA: 0x7AEB6C890
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class InputLayoutLoader : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AEE506F0
        public void RegisterInputLayouts(){} // RVA: 0x7AEE50700
    }

    public class OpenVRControllerWMR : XRController
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7A8B69B70
        public void set_deviceVelocity(){} // RVA: 0x7A8B4DC50
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B772D0
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B58850
        public void get_touchpadClick(){} // RVA: 0x7A8815B70
        public void set_touchpadClick(){} // RVA: 0x7A8B58420
        public void get_touchpadTouch(){} // RVA: 0x7A8B6AFA0
        public void set_touchpadTouch(){} // RVA: 0x7A8B58B30
        public void get_gripPressed(){} // RVA: 0x7A8B79060
        public void set_gripPressed(){} // RVA: 0x7A8B49820
        public void get_triggerPressed(){} // RVA: 0x7A8B5ED30
        public void set_triggerPressed(){} // RVA: 0x7A8B5E380
        public void get_menu(){} // RVA: 0x7A8688280
        public void set_menu(){} // RVA: 0x7A8B797E0
        public void get_trigger(){} // RVA: 0x7A8B7A210
        public void set_trigger(){} // RVA: 0x7A8B48CD0
        public void get_grip(){} // RVA: 0x7A8B562C0
        public void set_grip(){} // RVA: 0x7A8B4A930
        public void get_touchpad(){} // RVA: 0x7A8B50AF0
        public void set_touchpad(){} // RVA: 0x7A8B61940
        public void get_joystick(){} // RVA: 0x7A8B62DA0
        public void set_joystick(){} // RVA: 0x7A8B63900
        public void FinishSetup(){} // RVA: 0x7AEB6BBA0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class OpenVREvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE4E4C0
    }

    public class OpenVREvents : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AEE4E550
        public void IsInitialized(){} // RVA: 0x7AEE4E620
        public void .ctor(){} // RVA: 0x7AEE4E680
        public void RegisterDefaultEvents(){} // RVA: 0x7AEE4EAB0
        public void AddListener(){} // RVA: 0x7AEE4EBB0
        public void Add(){} // RVA: 0x7AEE4EC50
        public void RemoveListener(){} // RVA: 0x7AEE4EE30
        public void Remove(){} // RVA: 0x7AEE4EF40
        public void Update(){} // RVA: 0x7AEE4F000
        public void PollEvents(){} // RVA: 0x7AEE4F070
        public void On_VREvent_Quit(){} // RVA: 0x7AEE4F300
        public void .cctor(){} // RVA: 0x7AEE4F400
        public void instance(){} // RVA: 0x7B2E804B0
    }

    public class OpenVRHMD : XRHMD
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7A8688280
        public void set_deviceVelocity(){} // RVA: 0x7A8B797E0
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B7A210
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B48CD0
        public void get_leftEyeVelocity(){} // RVA: 0x7A8B562C0
        public void set_leftEyeVelocity(){} // RVA: 0x7A8B4A930
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7A8B50AF0
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7A8B61940
        public void get_rightEyeVelocity(){} // RVA: 0x7A8B62DA0
        public void set_rightEyeVelocity(){} // RVA: 0x7A8B63900
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7A8B5B150
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7A8B48310
        public void get_centerEyeVelocity(){} // RVA: 0x7A8B63C30
        public void set_centerEyeVelocity(){} // RVA: 0x7A8B5FB80
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7A8B4BD50
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7A8B5EDA0
        public void FinishSetup(){} // RVA: 0x7AEB6B730
        public void .ctor(){} // RVA: 0x7AEB6BB90
        public void <deviceVelocity>k__BackingField(){} // RVA: 0x7B4177678
    }

    public class OpenVRHelpers : Object
    {
        // ── Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7AEE4F450
        public void DoesTypeExist(){} // RVA: 0x7AEE4F4D0
        public void GetType(){} // RVA: 0x7AEE4F540
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7AEE4FDE0
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7AEE50080
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7AEE501E0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class OpenVRLoader : XRLoaderHelper
    {
        // ── Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7AEE51A80
        public void get_inputSubsystem(){} // RVA: 0x7AEE51B10
        public void Initialize(){} // RVA: 0x7AEE51BA0
        public void GetEscapedApplicationName(){} // RVA: 0x7AEE52100
        public void WatchForReload(){} // RVA: 0x7A80D7310
        public void CleanupReloadWatcher(){} // RVA: 0x7A80D7310
        public void Start(){} // RVA: 0x7AEE52290
        public void SetupFileSystemWatchers(){} // RVA: 0x7AEE52450
        public void SetupFileSystemWatcher(){} // RVA: 0x7AEE52450
        public void ManualFileWatcherLoop(){} // RVA: 0x7AEE525B0
        public void DestroyMirrorModeWatcher(){} // RVA: 0x7AEE52700
        public void OnChanged(){} // RVA: 0x7AEE527C0
        public void ReadMirrorModeConfig(){} // RVA: 0x7AEE527D0
        public void Stop(){} // RVA: 0x7AEE52E60
        public void Deinitialize(){} // RVA: 0x7AEE52F40
        public void CleanupTick(){} // RVA: 0x7AEE53010
        public void SetUserDefinedSettings(){} // RVA: 0x7AEE53060
        public void GetInitializationResult(){} // RVA: 0x7AEE53190
        public void RegisterTickCallback(){} // RVA: 0x7AEE53200
        public void TickCallback(){} // RVA: 0x7AEE53290
        public void .ctor(){} // RVA: 0x7AEE2AD00
        public void .cctor(){} // RVA: 0x7AEE53330
    }

    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7A8B69B70
        public void set_thumbstick(){} // RVA: 0x7A8B4DC50
        public void get_trigger(){} // RVA: 0x7A8B772D0
        public void set_trigger(){} // RVA: 0x7A8B58850
        public void get_grip(){} // RVA: 0x7A8815B70
        public void set_grip(){} // RVA: 0x7A8B58420
        public void get_primaryButton(){} // RVA: 0x7A8B6AFA0
        public void set_primaryButton(){} // RVA: 0x7A8B58B30
        public void get_secondaryButton(){} // RVA: 0x7A8B79060
        public void set_secondaryButton(){} // RVA: 0x7A8B49820
        public void get_gripPressed(){} // RVA: 0x7A8B5ED30
        public void set_gripPressed(){} // RVA: 0x7A8B5E380
        public void get_triggerPressed(){} // RVA: 0x7A8688280
        public void set_triggerPressed(){} // RVA: 0x7A8B797E0
        public void get_thumbstickClicked(){} // RVA: 0x7A8B7A210
        public void set_thumbstickClicked(){} // RVA: 0x7A8B48CD0
        public void get_thumbstickTouched(){} // RVA: 0x7A8B562C0
        public void set_thumbstickTouched(){} // RVA: 0x7A8B4A930
        public void get_deviceVelocity(){} // RVA: 0x7A8B50AF0
        public void set_deviceVelocity(){} // RVA: 0x7A8B61940
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B62DA0
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B63900
        public void FinishSetup(){} // RVA: 0x7AEB6CCA0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class OpenVRSettings : ScriptableObject
    {
        // ── Methods ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x7AEE53550
        public void CreateDirectory(){} // RVA: 0x7AEE536F0
        public void GetStereoRenderingMode(){} // RVA: 0x7AC2A83C0
        public void GetInitializationType(){} // RVA: 0x7AE1A86C0
        public void GetMirrorViewMode(){} // RVA: 0x7A8178B30
        public void SetMirrorViewMode(){} // RVA: 0x7AEE53E20
        public void GenerateEditorAppKey(){} // RVA: 0x7AEE53790
        public void CleanProductName(){} // RVA: 0x7AEE53900
        public void GetSettings(){} // RVA: 0x7AEE53D00
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7AEE53EA0
        public void Awake(){} // RVA: 0x7AEE54220
        public void .ctor(){} // RVA: 0x7AEE542C0
    }

    public class ViveLighthouse : TrackedDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class ViveTracker : TrackedDevice
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7A8B69B70
        public void set_deviceVelocity(){} // RVA: 0x7A8B4DC50
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B772D0
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B58850
        public void FinishSetup(){} // RVA: 0x7AEB6C740
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

    public class ViveWand : XRControllerWithRumble
    {
        // ── Methods ──
        public void get_grip(){} // RVA: 0x7A8B69B70
        public void set_grip(){} // RVA: 0x7A8B4DC50
        public void get_gripPressed(){} // RVA: 0x7A8B772D0
        public void set_gripPressed(){} // RVA: 0x7A8B58850
        public void get_primary(){} // RVA: 0x7A8815B70
        public void set_primary(){} // RVA: 0x7A8B58420
        public void get_trackpadPressed(){} // RVA: 0x7A8B6AFA0
        public void set_trackpadPressed(){} // RVA: 0x7A8B58B30
        public void get_trackpadTouched(){} // RVA: 0x7A8B79060
        public void set_trackpadTouched(){} // RVA: 0x7A8B49820
        public void get_trackpad(){} // RVA: 0x7A8B5ED30
        public void set_trackpad(){} // RVA: 0x7A8B5E380
        public void get_trigger(){} // RVA: 0x7A8688280
        public void set_trigger(){} // RVA: 0x7A8B797E0
        public void get_triggerPressed(){} // RVA: 0x7A8B7A210
        public void set_triggerPressed(){} // RVA: 0x7A8B48CD0
        public void get_deviceVelocity(){} // RVA: 0x7A8B562C0
        public void set_deviceVelocity(){} // RVA: 0x7A8B4A930
        public void get_deviceAngularVelocity(){} // RVA: 0x7A8B50AF0
        public void set_deviceAngularVelocity(){} // RVA: 0x7A8B61940
        public void FinishSetup(){} // RVA: 0x7AEB6C1B0
        public void .ctor(){} // RVA: 0x7AEB6BB90
    }

}