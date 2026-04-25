// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 164

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        public UnityEngine.InputSystem.Controls.AxisControl grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl gripPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl primary; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl trackpadPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x1E0

        // ── Methods ──
        public void get_grip(){} // RVA: 0x7FFAC35422B0
        public void set_grip(){} // RVA: 0x7FFAC39AD110
        public void get_gripPressed(){} // RVA: 0x7FFAC39CCB10
        public void set_gripPressed(){} // RVA: 0x7FFAC39CF3F0
        public void get_primary(){} // RVA: 0x7FFAC39C1920
        public void set_primary(){} // RVA: 0x7FFAC39A8050
        public void get_trackpadPressed(){} // RVA: 0x7FFAC39C0A30
        public void set_trackpadPressed(){} // RVA: 0x7FFAC39CF5C0
        public void get_triggerPressed(){} // RVA: 0x7FFAC33F8150
        public void set_triggerPressed(){} // RVA: 0x7FFAC39B1270
        public void FinishSetup(){} // RVA: 0x7FFAC9517140
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class InputLayoutLoader : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9809FE0
        public void RegisterInputLayouts(){} // RVA: 0x7FFAC9809FF0
    }

    public class OpenVRControllerWMR : XRController
    {
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadClick; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl touchpadTouch; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl gripPressed; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl menu; // 0x1E0
        public UnityEngine.InputSystem.Controls.AxisControl trigger; // 0x1E8
        public UnityEngine.InputSystem.Controls.AxisControl grip; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector2Control touchpad; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector2Control joystick; // 0x200

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3549F30
        public void set_deviceVelocity(){} // RVA: 0x7FFAC39A7790
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC3544330
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC39AC050
        public void get_touchpadClick(){} // RVA: 0x7FFAC35422B0
        public void set_touchpadClick(){} // RVA: 0x7FFAC39AD110
        public void get_touchpadTouch(){} // RVA: 0x7FFAC39CCB10
        public void set_touchpadTouch(){} // RVA: 0x7FFAC39CF3F0
        public void get_gripPressed(){} // RVA: 0x7FFAC39C1920
        public void set_gripPressed(){} // RVA: 0x7FFAC39A8050
        public void get_triggerPressed(){} // RVA: 0x7FFAC39C0A30
        public void set_triggerPressed(){} // RVA: 0x7FFAC39CF5C0
        public void get_menu(){} // RVA: 0x7FFAC33F8150
        public void set_menu(){} // RVA: 0x7FFAC39B1270
        public void get_trigger(){} // RVA: 0x7FFAC39B1060
        public void set_trigger(){} // RVA: 0x7FFAC39AC5A0
        public void get_grip(){} // RVA: 0x7FFAC3544EF0
        public void set_grip(){} // RVA: 0x7FFAC3541400
        public void get_touchpad(){} // RVA: 0x7FFAC3541460
        public void set_touchpad(){} // RVA: 0x7FFAC3544450
        public void get_joystick(){} // RVA: 0x7FFAC3544790
        public void set_joystick(){} // RVA: 0x7FFAC354D230
        public void FinishSetup(){} // RVA: 0x7FFAC9516450
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OpenVREvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9807DC0
    }

    public class OpenVREvents : Object
    {
        public Unity.XR.OpenVR.OpenVREvents instance;
        public Unity.XR.OpenVR.OpenVREvent[] events; // 0x10
        public int[] eventIndicies; // 0x18
        public Valve.VR.VREvent_t vrEvent; // 0x20
        public uint vrEventSize; // 0x60
        public bool preloadedEvents; // 0x64
        public int maxEventsPerUpdate;
        public bool debugLogAllEvents; // 0x8
        public bool enabled; // 0x9
        public bool exiting; // 0x65

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFAC9807E50
        public void IsInitialized(){} // RVA: 0x7FFAC9807F20
        public void .ctor(){} // RVA: 0x7FFAC9807F80
        public void RegisterDefaultEvents(){} // RVA: 0x7FFAC98083B0
        public void AddListener(){} // RVA: 0x7FFAC98084B0
        public void Add(){} // RVA: 0x7FFAC9808550
        public void RemoveListener(){} // RVA: 0x7FFAC9808730
        public void Remove(){} // RVA: 0x7FFAC9808840
        public void Update(){} // RVA: 0x7FFAC9808900
        public void PollEvents(){} // RVA: 0x7FFAC9808970
        public void On_VREvent_Quit(){} // RVA: 0x7FFAC9808C00
        public void .cctor(){} // RVA: 0x7FFAC9808D00
    }

    public class OpenVRHMD : XRHMD
    {
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x1E0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyeVelocity; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control leftEyeAngularVelocity; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyeVelocity; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control rightEyeAngularVelocity; // 0x208
        public UnityEngine.InputSystem.Controls.Vector3Control centerEyeVelocity; // 0x210
        public UnityEngine.InputSystem.Controls.Vector3Control centerEyeAngularVelocity; // 0x218

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFAC33F8150
        public void set_deviceVelocity(){} // RVA: 0x7FFAC39B1270
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC39B1060
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC39AC5A0
        public void get_leftEyeVelocity(){} // RVA: 0x7FFAC3544EF0
        public void set_leftEyeVelocity(){} // RVA: 0x7FFAC3541400
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7FFAC3541460
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7FFAC3544450
        public void get_rightEyeVelocity(){} // RVA: 0x7FFAC3544790
        public void set_rightEyeVelocity(){} // RVA: 0x7FFAC354D230
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7FFAC3544780
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7FFAC354D290
        public void get_centerEyeVelocity(){} // RVA: 0x7FFAC354BCB0
        public void set_centerEyeVelocity(){} // RVA: 0x7FFAC3543140
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7FFAC3541470
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7FFAC3542420
        public void FinishSetup(){} // RVA: 0x7FFAC9515FE0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OpenVRHelpers : Object
    {
        // ── Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7FFAC9808D50
        public void DoesTypeExist(){} // RVA: 0x7FFAC9808DD0
        public void GetType(){} // RVA: 0x7FFAC9808E40
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7FFAC98096D0
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7FFAC9809970
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7FFAC9809AD0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class OpenVRLoader : XRLoaderHelper
    {
        public System.Collections.Generic.List`1<UnityEngine.XR.XRDisplaySubsystemDescriptor> displaySubsystem;
        public System.Collections.Generic.List`1<UnityEngine.XR.XRInputSubsystemDescriptor> inputSubsystem; // 0x8
        public bool running; // 0x20
        public System.IO.FileInfo watcherFile; // 0x28
        public System.Threading.Thread watcherThread; // 0x30
        public string mirrorViewPath;
        public Unity.XR.OpenVR.OpenVRSettings settings; // 0x38
        public UnityEngine.Events.UnityEvent[] events; // 0x40

        // ── Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7FFAC980B370
        public void get_inputSubsystem(){} // RVA: 0x7FFAC980B400
        public void Initialize(){} // RVA: 0x7FFAC980B490
        public void GetEscapedApplicationName(){} // RVA: 0x7FFAC980B9F0
        public void WatchForReload(){} // RVA: 0x7FFAC2F21310
        public void CleanupReloadWatcher(){} // RVA: 0x7FFAC2F21310
        public void Start(){} // RVA: 0x7FFAC980BB80
        public void SetupFileSystemWatchers(){} // RVA: 0x7FFAC980BD40
        public void SetupFileSystemWatcher(){} // RVA: 0x7FFAC980BD40
        public void ManualFileWatcherLoop(){} // RVA: 0x7FFAC980BEA0
        public void DestroyMirrorModeWatcher(){} // RVA: 0x7FFAC980BFF0
        public void OnChanged(){} // RVA: 0x7FFAC980C0B0
        public void ReadMirrorModeConfig(){} // RVA: 0x7FFAC980C0C0
        public void Stop(){} // RVA: 0x7FFAC980C750
        public void Deinitialize(){} // RVA: 0x7FFAC980C830
        public void CleanupTick(){} // RVA: 0x7FFAC980C900
        public void SetUserDefinedSettings(){} // RVA: 0x7FFAC980C950
        public void GetInitializationResult(){} // RVA: 0x7FFAC980CA80
        public void RegisterTickCallback(){} // RVA: 0x7FFAC980CAF0
        public void TickCallback(){} // RVA: 0x7FFAC980CB80
        public void .ctor(){} // RVA: 0x7FFAC97E4660
        public void .cctor(){} // RVA: 0x7FFAC980CC20
    }

    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.Vector2Control thumbstick; // 0x1B0
        public UnityEngine.InputSystem.Controls.AxisControl trigger; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl primaryButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl secondaryButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl gripPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl thumbstickClicked; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl thumbstickTouched; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x200

        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7FFAC3549F30
        public void set_thumbstick(){} // RVA: 0x7FFAC39A7790
        public void get_trigger(){} // RVA: 0x7FFAC3544330
        public void set_trigger(){} // RVA: 0x7FFAC39AC050
        public void get_grip(){} // RVA: 0x7FFAC35422B0
        public void set_grip(){} // RVA: 0x7FFAC39AD110
        public void get_primaryButton(){} // RVA: 0x7FFAC39CCB10
        public void set_primaryButton(){} // RVA: 0x7FFAC39CF3F0
        public void get_secondaryButton(){} // RVA: 0x7FFAC39C1920
        public void set_secondaryButton(){} // RVA: 0x7FFAC39A8050
        public void get_gripPressed(){} // RVA: 0x7FFAC39C0A30
        public void set_gripPressed(){} // RVA: 0x7FFAC39CF5C0
        public void get_triggerPressed(){} // RVA: 0x7FFAC33F8150
        public void set_triggerPressed(){} // RVA: 0x7FFAC39B1270
        public void get_thumbstickClicked(){} // RVA: 0x7FFAC39B1060
        public void set_thumbstickClicked(){} // RVA: 0x7FFAC39AC5A0
        public void get_thumbstickTouched(){} // RVA: 0x7FFAC3544EF0
        public void set_thumbstickTouched(){} // RVA: 0x7FFAC3541400
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3541460
        public void set_deviceVelocity(){} // RVA: 0x7FFAC3544450
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC3544790
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC354D230
        public void FinishSetup(){} // RVA: 0x7FFAC9517550
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class OpenVRSettings : ScriptableObject
    {
        public bool PromptToUpgradePackage; // 0x18
        public bool PromptToUpgradePreviewPackages; // 0x19
        public string SkipPromptForVersion; // 0x20
        public 0x6B244120 StereoRenderingMode; // 0x28
        public 0x6B244178 InitializationType; // 0x2C
        public string EditorAppKey; // 0x30
        public string ActionManifestFileRelativeFilePath; // 0x38
        public 0x6B2441D0 MirrorView; // 0x40
        public bool DisableOpenVREvents; // 0x44
        public bool PreInit; // 0x45
        public string StreamingAssetsFolderName;
        public string ActionManifestFileName;
        public bool HasCopiedDefaults; // 0x46
        public Unity.XR.OpenVR.OpenVRSettings s_Settings;

        // ── Methods ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x7FFAC980CE40
        public void CreateDirectory(){} // RVA: 0x7FFAC980CFE0
        public void GetStereoRenderingMode(){} // RVA: 0x7FFAC6D6E100
        public void GetInitializationType(){} // RVA: 0x7FFAC8B52B50
        public void GetMirrorViewMode(){} // RVA: 0x7FFAC2FC2080
        public void SetMirrorViewMode(){} // RVA: 0x7FFAC980D710 | overloaded x2
        public void GenerateEditorAppKey(){} // RVA: 0x7FFAC980D080
        public void CleanProductName(){} // RVA: 0x7FFAC980D1F0
        public void GetSettings(){} // RVA: 0x7FFAC980D5F0
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7FFAC980D790
        public void Awake(){} // RVA: 0x7FFAC980DB10
        public void .ctor(){} // RVA: 0x7FFAC980DBB0
    }

    public class ViveLighthouse : TrackedDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class ViveTracker : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x1B8

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3549F30
        public void set_deviceVelocity(){} // RVA: 0x7FFAC39A7790
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC3544330
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC39AC050
        public void FinishSetup(){} // RVA: 0x7FFAC9516FF0
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

    public class ViveWand : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.AxisControl grip; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl gripPressed; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl primary; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl trackpadPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl trackpadTouched; // 0x1D0
        public UnityEngine.InputSystem.Controls.Vector2Control trackpad; // 0x1D8
        public UnityEngine.InputSystem.Controls.AxisControl trigger; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl triggerPressed; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control deviceVelocity; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control deviceAngularVelocity; // 0x1F8

        // ── Methods ──
        public void get_grip(){} // RVA: 0x7FFAC3549F30
        public void set_grip(){} // RVA: 0x7FFAC39A7790
        public void get_gripPressed(){} // RVA: 0x7FFAC3544330
        public void set_gripPressed(){} // RVA: 0x7FFAC39AC050
        public void get_primary(){} // RVA: 0x7FFAC35422B0
        public void set_primary(){} // RVA: 0x7FFAC39AD110
        public void get_trackpadPressed(){} // RVA: 0x7FFAC39CCB10
        public void set_trackpadPressed(){} // RVA: 0x7FFAC39CF3F0
        public void get_trackpadTouched(){} // RVA: 0x7FFAC39C1920
        public void set_trackpadTouched(){} // RVA: 0x7FFAC39A8050
        public void get_trackpad(){} // RVA: 0x7FFAC39C0A30
        public void set_trackpad(){} // RVA: 0x7FFAC39CF5C0
        public void get_trigger(){} // RVA: 0x7FFAC33F8150
        public void set_trigger(){} // RVA: 0x7FFAC39B1270
        public void get_triggerPressed(){} // RVA: 0x7FFAC39B1060
        public void set_triggerPressed(){} // RVA: 0x7FFAC39AC5A0
        public void get_deviceVelocity(){} // RVA: 0x7FFAC3544EF0
        public void set_deviceVelocity(){} // RVA: 0x7FFAC3541400
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFAC3541460
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFAC3544450
        public void FinishSetup(){} // RVA: 0x7FFAC9516A60
        public void .ctor(){} // RVA: 0x7FFAC9516440
    }

}