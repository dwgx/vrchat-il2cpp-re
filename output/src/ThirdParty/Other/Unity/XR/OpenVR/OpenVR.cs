// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 164

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker
    {
        // ── Methods ──
        public void get_grip(){} // RVA: 0xA57F60
        public void set_grip(){} // RVA: 0xD94790
        public void get_gripPressed(){} // RVA: 0xDA62D0
        public void set_gripPressed(){} // RVA: 0xD94E00
        public void get_primary(){} // RVA: 0xDB3D70
        public void set_primary(){} // RVA: 0xD86540
        public void get_trackpadPressed(){} // RVA: 0xD9ABC0
        public void set_trackpadPressed(){} // RVA: 0xD9A380
        public void get_triggerPressed(){} // RVA: 0x8CBA20
        public void set_triggerPressed(){} // RVA: 0xDB44F0
        public void FinishSetup(){} // RVA: 0x6D7E9E0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class InputLayoutLoader
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7071690
        public void RegisterInputLayouts(){} // RVA: 0x70716A0
    }

    public class OpenVRControllerWMR
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0xDA5040
        public void set_deviceVelocity(){} // RVA: 0xD8AAB0
        public void get_deviceAngularVelocity(){} // RVA: 0xDB2150
        public void set_deviceAngularVelocity(){} // RVA: 0xD94B20
        public void get_touchpadClick(){} // RVA: 0xA57F60
        public void set_touchpadClick(){} // RVA: 0xD94790
        public void get_touchpadTouch(){} // RVA: 0xDA62D0
        public void set_touchpadTouch(){} // RVA: 0xD94E00
        public void get_gripPressed(){} // RVA: 0xDB3D70
        public void set_gripPressed(){} // RVA: 0xD86540
        public void get_triggerPressed(){} // RVA: 0xD9ABC0
        public void set_triggerPressed(){} // RVA: 0xD9A380
        public void get_menu(){} // RVA: 0x8CBA20
        public void set_menu(){} // RVA: 0xDB44F0
        public void get_trigger(){} // RVA: 0xDB4D60
        public void set_trigger(){} // RVA: 0xD85A20
        public void get_grip(){} // RVA: 0xD92860
        public void set_grip(){} // RVA: 0xD87940
        public void get_touchpad(){} // RVA: 0xD8D540
        public void set_touchpad(){} // RVA: 0xD9D6A0
        public void get_joystick(){} // RVA: 0xD9E9A0
        public void set_joystick(){} // RVA: 0xD9F490
        public void FinishSetup(){} // RVA: 0x6D7DCF0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class OpenVREvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x706F470
    }

    public class OpenVREvents
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x706F500
        public void IsInitialized(){} // RVA: 0x706F5D0
        public void .ctor(){} // RVA: 0x706F630
        public void RegisterDefaultEvents(){} // RVA: 0x706FA60
        public void AddListener(){} // RVA: 0x706FB60
        public void Add(){} // RVA: 0x706FC00
        public void RemoveListener(){} // RVA: 0x706FDE0
        public void Remove(){} // RVA: 0x706FEF0
        public void Update(){} // RVA: 0x706FFB0
        public void PollEvents(){} // RVA: 0x7070020
        public void On_VREvent_Quit(){} // RVA: 0x70702B0
        public void .cctor(){} // RVA: 0x70703B0
    }

    public class OpenVRHMD
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x8CBA20
        public void set_deviceVelocity(){} // RVA: 0xDB44F0
        public void get_deviceAngularVelocity(){} // RVA: 0xDB4D60
        public void set_deviceAngularVelocity(){} // RVA: 0xD85A20
        public void get_leftEyeVelocity(){} // RVA: 0xD92860
        public void set_leftEyeVelocity(){} // RVA: 0xD87940
        public void get_leftEyeAngularVelocity(){} // RVA: 0xD8D540
        public void set_leftEyeAngularVelocity(){} // RVA: 0xD9D6A0
        public void get_rightEyeVelocity(){} // RVA: 0xD9E9A0
        public void set_rightEyeVelocity(){} // RVA: 0xD9F490
        public void get_rightEyeAngularVelocity(){} // RVA: 0xD971B0
        public void set_rightEyeAngularVelocity(){} // RVA: 0xD85210
        public void get_centerEyeVelocity(){} // RVA: 0xD9F7C0
        public void set_centerEyeVelocity(){} // RVA: 0xD9BA80
        public void get_centerEyeAngularVelocity(){} // RVA: 0xD88BD0
        public void set_centerEyeAngularVelocity(){} // RVA: 0xD9AC30
        public void FinishSetup(){} // RVA: 0x6D7D880
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class OpenVRHelpers
    {
        // ── Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7070400
        public void DoesTypeExist(){} // RVA: 0x7070480
        public void GetType(){} // RVA: 0x70704F0
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7070D80
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7071020
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7071180
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class OpenVRLoader
    {
        // ── Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7072A20
        public void get_inputSubsystem(){} // RVA: 0x7072AB0
        public void Initialize(){} // RVA: 0x7072B40
        public void GetEscapedApplicationName(){} // RVA: 0x70730A0
        public void WatchForReload(){} // RVA: 0x2DD310
        public void CleanupReloadWatcher(){} // RVA: 0x2DD310
        public void Start(){} // RVA: 0x7073230
        public void SetupFileSystemWatchers(){} // RVA: 0x70733F0
        public void SetupFileSystemWatcher(){} // RVA: 0x70733F0
        public void ManualFileWatcherLoop(){} // RVA: 0x7073550
        public void DestroyMirrorModeWatcher(){} // RVA: 0x70736A0
        public void OnChanged(){} // RVA: 0x7073760
        public void ReadMirrorModeConfig(){} // RVA: 0x7073770
        public void Stop(){} // RVA: 0x7073E00
        public void Deinitialize(){} // RVA: 0x7073EE0
        public void CleanupTick(){} // RVA: 0x7073FB0
        public void SetUserDefinedSettings(){} // RVA: 0x7074000
        public void GetInitializationResult(){} // RVA: 0x7074130
        public void RegisterTickCallback(){} // RVA: 0x70741A0
        public void TickCallback(){} // RVA: 0x7074230
        public void .ctor(){} // RVA: 0x704BD10
        public void .cctor(){} // RVA: 0x70742D0
    }

    public class OpenVROculusTouchController
    {
        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0xDA5040
        public void set_thumbstick(){} // RVA: 0xD8AAB0
        public void get_trigger(){} // RVA: 0xDB2150
        public void set_trigger(){} // RVA: 0xD94B20
        public void get_grip(){} // RVA: 0xA57F60
        public void set_grip(){} // RVA: 0xD94790
        public void get_primaryButton(){} // RVA: 0xDA62D0
        public void set_primaryButton(){} // RVA: 0xD94E00
        public void get_secondaryButton(){} // RVA: 0xDB3D70
        public void set_secondaryButton(){} // RVA: 0xD86540
        public void get_gripPressed(){} // RVA: 0xD9ABC0
        public void set_gripPressed(){} // RVA: 0xD9A380
        public void get_triggerPressed(){} // RVA: 0x8CBA20
        public void set_triggerPressed(){} // RVA: 0xDB44F0
        public void get_thumbstickClicked(){} // RVA: 0xDB4D60
        public void set_thumbstickClicked(){} // RVA: 0xD85A20
        public void get_thumbstickTouched(){} // RVA: 0xD92860
        public void set_thumbstickTouched(){} // RVA: 0xD87940
        public void get_deviceVelocity(){} // RVA: 0xD8D540
        public void set_deviceVelocity(){} // RVA: 0xD9D6A0
        public void get_deviceAngularVelocity(){} // RVA: 0xD9E9A0
        public void set_deviceAngularVelocity(){} // RVA: 0xD9F490
        public void FinishSetup(){} // RVA: 0x6D7EDF0
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class OpenVRSettings
    {
        // ── Methods ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x70744F0
        public void CreateDirectory(){} // RVA: 0x7074690
        public void GetStereoRenderingMode(){} // RVA: 0x44B97F0
        public void GetInitializationType(){} // RVA: 0x63BB790
        public void GetMirrorViewMode(){} // RVA: 0x37E080
        public void SetMirrorViewMode(){} // RVA: 0x7074DC0 | overloaded x2
        public void GenerateEditorAppKey(){} // RVA: 0x7074730
        public void CleanProductName(){} // RVA: 0x70748A0
        public void GetSettings(){} // RVA: 0x7074CA0
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7074E40
        public void Awake(){} // RVA: 0x70751C0
        public void .ctor(){} // RVA: 0x7075260
    }

    public class ViveLighthouse
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class ViveTracker
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0xDA5040
        public void set_deviceVelocity(){} // RVA: 0xD8AAB0
        public void get_deviceAngularVelocity(){} // RVA: 0xDB2150
        public void set_deviceAngularVelocity(){} // RVA: 0xD94B20
        public void FinishSetup(){} // RVA: 0x6D7E890
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

    public class ViveWand
    {
        // ── Methods ──
        public void get_grip(){} // RVA: 0xDA5040
        public void set_grip(){} // RVA: 0xD8AAB0
        public void get_gripPressed(){} // RVA: 0xDB2150
        public void set_gripPressed(){} // RVA: 0xD94B20
        public void get_primary(){} // RVA: 0xA57F60
        public void set_primary(){} // RVA: 0xD94790
        public void get_trackpadPressed(){} // RVA: 0xDA62D0
        public void set_trackpadPressed(){} // RVA: 0xD94E00
        public void get_trackpadTouched(){} // RVA: 0xDB3D70
        public void set_trackpadTouched(){} // RVA: 0xD86540
        public void get_trackpad(){} // RVA: 0xD9ABC0
        public void set_trackpad(){} // RVA: 0xD9A380
        public void get_trigger(){} // RVA: 0x8CBA20
        public void set_trigger(){} // RVA: 0xDB44F0
        public void get_triggerPressed(){} // RVA: 0xDB4D60
        public void set_triggerPressed(){} // RVA: 0xD85A20
        public void get_deviceVelocity(){} // RVA: 0xD92860
        public void set_deviceVelocity(){} // RVA: 0xD87940
        public void get_deviceAngularVelocity(){} // RVA: 0xD8D540
        public void set_deviceAngularVelocity(){} // RVA: 0xD9D6A0
        public void FinishSetup(){} // RVA: 0x6D7E300
        public void .ctor(){} // RVA: 0x6D7DCE0
    }

}