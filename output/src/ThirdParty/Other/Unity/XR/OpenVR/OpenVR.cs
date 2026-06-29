// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 163

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        // ── Methods ──
        public void get_grip(){} // RVA: 0x1344890
        public void set_grip(){} // RVA: 0x1662780
        public void get_gripPressed(){} // RVA: 0x1655DD0
        public void set_gripPressed(){} // RVA: 0x16694D0
        public void get_primary(){} // RVA: 0x1654670
        public void set_primary(){} // RVA: 0x16612E0
        public void get_trackpadPressed(){} // RVA: 0x165AD10
        public void set_trackpadPressed(){} // RVA: 0x1667130
        public void get_triggerPressed(){} // RVA: 0x1184410
        public void set_triggerPressed(){} // RVA: 0x163ACA0
        public void FinishSetup(){} // RVA: 0x77D5C00
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class InputLayoutLoader : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AD2A00
        public void RegisterInputLayouts(){} // RVA: 0x7AD2A10
    }

    public class OpenVRControllerWMR : XRController
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x165E8F0
        public void set_deviceVelocity(){} // RVA: 0x165C4D0
        public void get_deviceAngularVelocity(){} // RVA: 0x1659CB0
        public void set_deviceAngularVelocity(){} // RVA: 0x163A980
        public void get_touchpadClick(){} // RVA: 0x1344890
        public void set_touchpadClick(){} // RVA: 0x1662780
        public void get_touchpadTouch(){} // RVA: 0x1655DD0
        public void set_touchpadTouch(){} // RVA: 0x16694D0
        public void get_gripPressed(){} // RVA: 0x1654670
        public void set_gripPressed(){} // RVA: 0x16612E0
        public void get_triggerPressed(){} // RVA: 0x165AD10
        public void set_triggerPressed(){} // RVA: 0x1667130
        public void get_menu(){} // RVA: 0x1184410
        public void set_menu(){} // RVA: 0x163ACA0
        public void get_trigger(){} // RVA: 0x164FF50
        public void set_trigger(){} // RVA: 0x16529A0
        public void get_grip(){} // RVA: 0x1659260
        public void set_grip(){} // RVA: 0x165DAA0
        public void get_touchpad(){} // RVA: 0x136ECA0
        public void set_touchpad(){} // RVA: 0x164C9D0
        public void get_joystick(){} // RVA: 0x165F4F0
        public void set_joystick(){} // RVA: 0x164A160
        public void FinishSetup(){} // RVA: 0x77D4F10
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OpenVREvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD0810
    }

    public class OpenVREvents : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7AD08A0
        public void IsInitialized(){} // RVA: 0x7AD0970
        public void .ctor(){} // RVA: 0x7AD09D0
        public void RegisterDefaultEvents(){} // RVA: 0x7AD0E60
        public void AddListener(){} // RVA: 0x7AD0F60
        public void Add(){} // RVA: 0x7AD1000
        public void RemoveListener(){} // RVA: 0x7AD11E0
        public void Remove(){} // RVA: 0x7AD12F0
        public void Update(){} // RVA: 0x7AD13B0
        public void PollEvents(){} // RVA: 0x7AD1420
        public void On_VREvent_Quit(){} // RVA: 0x7AD16A0
        public void .cctor(){} // RVA: 0x7AD17A0
    }

    public class OpenVRHMD : XRHMD
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x1184410
        public void set_deviceVelocity(){} // RVA: 0x163ACA0
        public void get_deviceAngularVelocity(){} // RVA: 0x164FF50
        public void set_deviceAngularVelocity(){} // RVA: 0x16529A0
        public void get_leftEyeVelocity(){} // RVA: 0x1659260
        public void set_leftEyeVelocity(){} // RVA: 0x165DAA0
        public void get_leftEyeAngularVelocity(){} // RVA: 0x136ECA0
        public void set_leftEyeAngularVelocity(){} // RVA: 0x164C9D0
        public void get_rightEyeVelocity(){} // RVA: 0x165F4F0
        public void set_rightEyeVelocity(){} // RVA: 0x164A160
        public void get_rightEyeAngularVelocity(){} // RVA: 0x164EDD0
        public void set_rightEyeAngularVelocity(){} // RVA: 0x1651390
        public void get_centerEyeVelocity(){} // RVA: 0x1640C90
        public void set_centerEyeVelocity(){} // RVA: 0x1668690
        public void get_centerEyeAngularVelocity(){} // RVA: 0x165F950
        public void set_centerEyeAngularVelocity(){} // RVA: 0x164BF20
        public void FinishSetup(){} // RVA: 0x77D4AA0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OpenVRHelpers : Object
    {
        // ── Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7AD17F0
        public void DoesTypeExist(){} // RVA: 0x7AD1850
        public void GetType(){} // RVA: 0x7AD1890
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7AD2130
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7AD23B0
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7AD2500
        public void .ctor(){} // RVA: 0xB43310
    }

    public class OpenVRLoader : XRLoaderHelper
    {
        // ── Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7AD3D90
        public void get_inputSubsystem(){} // RVA: 0x7AD3E20
        public void Initialize(){} // RVA: 0x7AD3EB0
        public void GetEscapedApplicationName(){} // RVA: 0x7AD4400
        public void WatchForReload(){} // RVA: 0xB43310
        public void CleanupReloadWatcher(){} // RVA: 0xB43310
        public void Start(){} // RVA: 0x7AD4510
        public void SetupFileSystemWatchers(){} // RVA: 0x7AD46D0
        public void SetupFileSystemWatcher(){} // RVA: 0x7AD46D0
        public void ManualFileWatcherLoop(){} // RVA: 0x7AD4830
        public void DestroyMirrorModeWatcher(){} // RVA: 0x7AD4980
        public void OnChanged(){} // RVA: 0x7AD4A40
        public void ReadMirrorModeConfig(){} // RVA: 0x7AD4A50
        public void Stop(){} // RVA: 0x7AD50E0
        public void Deinitialize(){} // RVA: 0x7AD51C0
        public void CleanupTick(){} // RVA: 0x7AD5290
        public void SetUserDefinedSettings(){} // RVA: 0x7AD52E0
        public void GetInitializationResult(){} // RVA: 0x7AD5410
        public void RegisterTickCallback(){} // RVA: 0x7AD5480
        public void TickCallback(){} // RVA: 0x7AD5510
        public void .ctor(){} // RVA: 0x7AB44B0
        public void .cctor(){} // RVA: 0x7AD55B0
    }

    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x165E8F0
        public void set_thumbstick(){} // RVA: 0x165C4D0
        public void get_trigger(){} // RVA: 0x1659CB0
        public void set_trigger(){} // RVA: 0x163A980
        public void get_grip(){} // RVA: 0x1344890
        public void set_grip(){} // RVA: 0x1662780
        public void get_primaryButton(){} // RVA: 0x1655DD0
        public void set_primaryButton(){} // RVA: 0x16694D0
        public void get_secondaryButton(){} // RVA: 0x1654670
        public void set_secondaryButton(){} // RVA: 0x16612E0
        public void get_gripPressed(){} // RVA: 0x165AD10
        public void set_gripPressed(){} // RVA: 0x1667130
        public void get_triggerPressed(){} // RVA: 0x1184410
        public void set_triggerPressed(){} // RVA: 0x163ACA0
        public void get_thumbstickClicked(){} // RVA: 0x164FF50
        public void set_thumbstickClicked(){} // RVA: 0x16529A0
        public void get_thumbstickTouched(){} // RVA: 0x1659260
        public void set_thumbstickTouched(){} // RVA: 0x165DAA0
        public void get_deviceVelocity(){} // RVA: 0x136ECA0
        public void set_deviceVelocity(){} // RVA: 0x164C9D0
        public void get_deviceAngularVelocity(){} // RVA: 0x165F4F0
        public void set_deviceAngularVelocity(){} // RVA: 0x164A160
        public void FinishSetup(){} // RVA: 0x77D6010
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class OpenVRSettings : ScriptableObject
    {
        // ── Methods ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x7AD5750
        public void CreateDirectory(){} // RVA: 0x7AD58B0
        public void GetStereoRenderingMode(){} // RVA: 0x4FF5720
        public void GetInitializationType(){} // RVA: 0x6E29C50
        public void GetMirrorViewMode(){} // RVA: 0xBE5850
        public void SetMirrorViewMode(){} // RVA: 0x7AD5F60
        public void GenerateEditorAppKey(){} // RVA: 0x7AD5950
        public void CleanProductName(){} // RVA: 0x7AD5AC0
        public void GetSettings(){} // RVA: 0x7AD5E40
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7AD5FE0
        public void Awake(){} // RVA: 0x7AD6350
        public void .ctor(){} // RVA: 0x7AD63F0
    }

    public class ViveLighthouse : TrackedDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class ViveTracker : TrackedDevice
    {
        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x165E8F0
        public void set_deviceVelocity(){} // RVA: 0x165C4D0
        public void get_deviceAngularVelocity(){} // RVA: 0x1659CB0
        public void set_deviceAngularVelocity(){} // RVA: 0x163A980
        public void FinishSetup(){} // RVA: 0x77D5AB0
        public void .ctor(){} // RVA: 0x77D4F00
    }

    public class ViveWand : XRControllerWithRumble
    {
        // ── Methods ──
        public void get_grip(){} // RVA: 0x165E8F0
        public void set_grip(){} // RVA: 0x165C4D0
        public void get_gripPressed(){} // RVA: 0x1659CB0
        public void set_gripPressed(){} // RVA: 0x163A980
        public void get_primary(){} // RVA: 0x1344890
        public void set_primary(){} // RVA: 0x1662780
        public void get_trackpadPressed(){} // RVA: 0x1655DD0
        public void set_trackpadPressed(){} // RVA: 0x16694D0
        public void get_trackpadTouched(){} // RVA: 0x1654670
        public void set_trackpadTouched(){} // RVA: 0x16612E0
        public void get_trackpad(){} // RVA: 0x165AD10
        public void set_trackpad(){} // RVA: 0x1667130
        public void get_trigger(){} // RVA: 0x1184410
        public void set_trigger(){} // RVA: 0x163ACA0
        public void get_triggerPressed(){} // RVA: 0x164FF50
        public void set_triggerPressed(){} // RVA: 0x16529A0
        public void get_deviceVelocity(){} // RVA: 0x1659260
        public void set_deviceVelocity(){} // RVA: 0x165DAA0
        public void get_deviceAngularVelocity(){} // RVA: 0x136ECA0
        public void set_deviceAngularVelocity(){} // RVA: 0x164C9D0
        public void FinishSetup(){} // RVA: 0x77D5520
        public void .ctor(){} // RVA: 0x77D4F00
    }

}