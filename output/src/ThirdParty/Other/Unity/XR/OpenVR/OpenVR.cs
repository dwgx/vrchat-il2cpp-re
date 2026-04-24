// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 164

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        public object grip;
        public object gripPressed;
        public object primary;
        public object trackpadPressed;
        public object triggerPressed;

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
        public object deviceVelocity;
        public object deviceAngularVelocity;
        public object touchpadClick;
        public object touchpadTouch;
        public object gripPressed;
        public object triggerPressed;
        public object menu;
        public object trigger;
        public object grip;
        public object touchpad;
        public object joystick;

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
        public object deviceVelocity;
        public object deviceAngularVelocity;
        public object leftEyeVelocity;
        public object leftEyeAngularVelocity;
        public object rightEyeVelocity;
        public object rightEyeAngularVelocity;
        public object centerEyeVelocity;
        public object centerEyeAngularVelocity;

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
        public object displaySubsystem;
        public object inputSubsystem;

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
        public object thumbstick;
        public object trigger;
        public object grip;
        public object primaryButton;
        public object secondaryButton;
        public object gripPressed;
        public object triggerPressed;
        public object thumbstickClicked;
        public object thumbstickTouched;
        public object deviceVelocity;
        public object deviceAngularVelocity;

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
        public object deviceVelocity;
        public object deviceAngularVelocity;

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
        public object grip;
        public object gripPressed;
        public object primary;
        public object trackpadPressed;
        public object trackpadTouched;
        public object trackpad;
        public object trigger;
        public object triggerPressed;
        public object deviceVelocity;
        public object deviceAngularVelocity;

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