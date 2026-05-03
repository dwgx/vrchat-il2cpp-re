// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.Unity.XR.OpenVR
// Classes: 13
// Methods: 164

namespace ThirdParty.Other.Unity.XR.OpenVR
{
    public class HandedViveTracker : ViveTracker
    {
        public UnityEngine.InputSystem.Controls.AxisControl _grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _gripPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _primary; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _trackpadPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x1E0

        // ── Methods ──
        public void get_grip(){} // RVA: 0x7FFE817EFE00
        public void set_grip(){} // RVA: 0x7FFE81B0C930
        public void get_gripPressed(){} // RVA: 0x7FFE81B16E90
        public void set_gripPressed(){} // RVA: 0x7FFE81B290E0
        public void get_primary(){} // RVA: 0x7FFE81B32320
        public void set_primary(){} // RVA: 0x7FFE81B31B60
        public void get_trackpadPressed(){} // RVA: 0x7FFE81B23D60
        public void set_trackpadPressed(){} // RVA: 0x7FFE81B11520
        public void get_triggerPressed(){} // RVA: 0x7FFE816611A0
        public void set_triggerPressed(){} // RVA: 0x7FFE81B31CF0
        public void FinishSetup(){} // RVA: 0x7FFE878BF880
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class InputLayoutLoader : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87BB2550
        public void RegisterInputLayouts(){} // RVA: 0x7FFE87BB2560
    }

    public class OpenVRControllerWMR : XRController
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadClick; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _touchpadTouch; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _gripPressed; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _menu; // 0x1E0
        public UnityEngine.InputSystem.Controls.AxisControl _trigger; // 0x1E8
        public UnityEngine.InputSystem.Controls.AxisControl _grip; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector2Control _touchpad; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector2Control _joystick; // 0x200

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B23A60
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B2ACE0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B164E0
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B38D70
        public void get_touchpadClick(){} // RVA: 0x7FFE817EFE00
        public void set_touchpadClick(){} // RVA: 0x7FFE81B0C930
        public void get_touchpadTouch(){} // RVA: 0x7FFE81B16E90
        public void set_touchpadTouch(){} // RVA: 0x7FFE81B290E0
        public void get_gripPressed(){} // RVA: 0x7FFE81B32320
        public void set_gripPressed(){} // RVA: 0x7FFE81B31B60
        public void get_triggerPressed(){} // RVA: 0x7FFE81B23D60
        public void set_triggerPressed(){} // RVA: 0x7FFE81B11520
        public void get_menu(){} // RVA: 0x7FFE816611A0
        public void set_menu(){} // RVA: 0x7FFE81B31CF0
        public void get_trigger(){} // RVA: 0x7FFE81B27D50
        public void set_trigger(){} // RVA: 0x7FFE81B34FD0
        public void get_grip(){} // RVA: 0x7FFE81B21230
        public void set_grip(){} // RVA: 0x7FFE81B374B0
        public void get_touchpad(){} // RVA: 0x7FFE81B20B40
        public void set_touchpad(){} // RVA: 0x7FFE81B2E610
        public void get_joystick(){} // RVA: 0x7FFE81B14500
        public void set_joystick(){} // RVA: 0x7FFE81B317A0
        public void FinishSetup(){} // RVA: 0x7FFE878BEB90
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OpenVREvent : UnityEvent`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BB0340
    }

    public class OpenVREvents : Object
    {
        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE87BB03D0
        public void IsInitialized(){} // RVA: 0x7FFE87BB04A0
        public void .ctor(){} // RVA: 0x7FFE87BB0500
        public void RegisterDefaultEvents(){} // RVA: 0x7FFE87BB0930
        public void AddListener(){} // RVA: 0x7FFE87BB0A30
        public void Add(){} // RVA: 0x7FFE87BB0AD0
        public void RemoveListener(){} // RVA: 0x7FFE87BB0CB0
        public void Remove(){} // RVA: 0x7FFE87BB0DC0
        public void Update(){} // RVA: 0x7FFE87BB0E80
        public void PollEvents(){} // RVA: 0x7FFE87BB0EF0
        public void On_VREvent_Quit(){} // RVA: 0x7FFE87BB1180
        public void .cctor(){} // RVA: 0x7FFE87BB1280
    }

    public class OpenVRHMD : XRHMD
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x1E0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyeVelocity; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control _leftEyeAngularVelocity; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyeVelocity; // 0x200
        public UnityEngine.InputSystem.Controls.Vector3Control _rightEyeAngularVelocity; // 0x208
        public UnityEngine.InputSystem.Controls.Vector3Control _centerEyeVelocity; // 0x210
        public UnityEngine.InputSystem.Controls.Vector3Control _centerEyeAngularVelocity; // 0x218

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFE816611A0
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B31CF0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B27D50
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B34FD0
        public void get_leftEyeVelocity(){} // RVA: 0x7FFE81B21230
        public void set_leftEyeVelocity(){} // RVA: 0x7FFE81B374B0
        public void get_leftEyeAngularVelocity(){} // RVA: 0x7FFE81B20B40
        public void set_leftEyeAngularVelocity(){} // RVA: 0x7FFE81B2E610
        public void get_rightEyeVelocity(){} // RVA: 0x7FFE81B14500
        public void set_rightEyeVelocity(){} // RVA: 0x7FFE81B317A0
        public void get_rightEyeAngularVelocity(){} // RVA: 0x7FFE81B2DA70
        public void set_rightEyeAngularVelocity(){} // RVA: 0x7FFE81B27F80
        public void get_centerEyeVelocity(){} // RVA: 0x7FFE81B0A180
        public void set_centerEyeVelocity(){} // RVA: 0x7FFE81B13850
        public void get_centerEyeAngularVelocity(){} // RVA: 0x7FFE81B296E0
        public void set_centerEyeAngularVelocity(){} // RVA: 0x7FFE81B38350
        public void FinishSetup(){} // RVA: 0x7FFE878BE720
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OpenVRHelpers : Object
    {
        // ── Methods ──
        public void IsUsingSteamVRInput(){} // RVA: 0x7FFE87BB12D0
        public void DoesTypeExist(){} // RVA: 0x7FFE87BB1350
        public void GetType(){} // RVA: 0x7FFE87BB13C0
        public void GetActionManifestPathFromPlugin(){} // RVA: 0x7FFE87BB1C40
        public void GetActionManifestNameFromPlugin(){} // RVA: 0x7FFE87BB1EE0
        public void GetEditorAppKeyFromPlugin(){} // RVA: 0x7FFE87BB2040
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class OpenVRLoader : XRLoaderHelper
    {
        public System.Collections.Generic.List`1<UnityEngine.XR.XRDisplaySubsystemDescriptor> s_DisplaySubsystemDescriptors;
        public System.Collections.Generic.List`1<UnityEngine.XR.XRInputSubsystemDescriptor> s_InputSubsystemDescriptors; // 0x8

        // ── Methods ──
        public void get_displaySubsystem(){} // RVA: 0x7FFE87BB38E0
        public void get_inputSubsystem(){} // RVA: 0x7FFE87BB3970
        public void Initialize(){} // RVA: 0x7FFE87BB3A00
        public void GetEscapedApplicationName(){} // RVA: 0x7FFE87BB3F60
        public void WatchForReload(){} // RVA: 0x7FFE810FB310
        public void CleanupReloadWatcher(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE87BB40F0
        public void SetupFileSystemWatchers(){} // RVA: 0x7FFE87BB42B0
        public void SetupFileSystemWatcher(){} // RVA: 0x7FFE87BB42B0
        public void ManualFileWatcherLoop(){} // RVA: 0x7FFE87BB4410
        public void DestroyMirrorModeWatcher(){} // RVA: 0x7FFE87BB4560
        public void OnChanged(){} // RVA: 0x7FFE87BB4620
        public void ReadMirrorModeConfig(){} // RVA: 0x7FFE87BB4630
        public void Stop(){} // RVA: 0x7FFE87BB4CC0
        public void Deinitialize(){} // RVA: 0x7FFE87BB4DA0
        public void CleanupTick(){} // RVA: 0x7FFE87BB4E70
        public void SetUserDefinedSettings(){} // RVA: 0x7FFE87BB4EC0
        public void GetInitializationResult(){} // RVA: 0x7FFE87BB4FF0
        public void RegisterTickCallback(){} // RVA: 0x7FFE87BB5060
        public void TickCallback(){} // RVA: 0x7FFE87BB50F0
        public void .ctor(){} // RVA: 0x7FFE87B8CBE0
        public void .cctor(){} // RVA: 0x7FFE87BB5190
    }

    public class OpenVROculusTouchController : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.Vector2Control _thumbstick; // 0x1B0
        public UnityEngine.InputSystem.Controls.AxisControl _trigger; // 0x1B8
        public UnityEngine.InputSystem.Controls.AxisControl _grip; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _primaryButton; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _secondaryButton; // 0x1D0
        public UnityEngine.InputSystem.Controls.ButtonControl _gripPressed; // 0x1D8
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl _thumbstickClicked; // 0x1E8
        public UnityEngine.InputSystem.Controls.ButtonControl _thumbstickTouched; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x1F8
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x200

        // ── Methods ──
        public void get_thumbstick(){} // RVA: 0x7FFE81B23A60
        public void set_thumbstick(){} // RVA: 0x7FFE81B2ACE0
        public void get_trigger(){} // RVA: 0x7FFE81B164E0
        public void set_trigger(){} // RVA: 0x7FFE81B38D70
        public void get_grip(){} // RVA: 0x7FFE817EFE00
        public void set_grip(){} // RVA: 0x7FFE81B0C930
        public void get_primaryButton(){} // RVA: 0x7FFE81B16E90
        public void set_primaryButton(){} // RVA: 0x7FFE81B290E0
        public void get_secondaryButton(){} // RVA: 0x7FFE81B32320
        public void set_secondaryButton(){} // RVA: 0x7FFE81B31B60
        public void get_gripPressed(){} // RVA: 0x7FFE81B23D60
        public void set_gripPressed(){} // RVA: 0x7FFE81B11520
        public void get_triggerPressed(){} // RVA: 0x7FFE816611A0
        public void set_triggerPressed(){} // RVA: 0x7FFE81B31CF0
        public void get_thumbstickClicked(){} // RVA: 0x7FFE81B27D50
        public void set_thumbstickClicked(){} // RVA: 0x7FFE81B34FD0
        public void get_thumbstickTouched(){} // RVA: 0x7FFE81B21230
        public void set_thumbstickTouched(){} // RVA: 0x7FFE81B374B0
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B20B40
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B2E610
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B14500
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B317A0
        public void FinishSetup(){} // RVA: 0x7FFE878BFC90
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class OpenVRSettings : ScriptableObject
    {
        // ── Methods ──
        public void GetStreamingSteamVRPath(){} // RVA: 0x7FFE87BB53B0
        public void CreateDirectory(){} // RVA: 0x7FFE87BB5550
        public void GetStereoRenderingMode(){} // RVA: 0x7FFE850F4D50
        public void GetInitializationType(){} // RVA: 0x7FFE86EFC1C0
        public void GetMirrorViewMode(){} // RVA: 0x7FFE8119C080
        public void SetMirrorViewMode(){} // RVA: 0x7FFE87BB5C80 | overloaded x2
        public void GenerateEditorAppKey(){} // RVA: 0x7FFE87BB55F0
        public void CleanProductName(){} // RVA: 0x7FFE87BB5760
        public void GetSettings(){} // RVA: 0x7FFE87BB5B60
        public void InitializeActionManifestFileRelativeFilePath(){} // RVA: 0x7FFE87BB5D00
        public void Awake(){} // RVA: 0x7FFE87BB6080
        public void .ctor(){} // RVA: 0x7FFE87BB6120
    }

    public class ViveLighthouse : TrackedDevice
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class ViveTracker : TrackedDevice
    {
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x1B0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x1B8

        // ── Methods ──
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B23A60
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B2ACE0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B164E0
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B38D70
        public void FinishSetup(){} // RVA: 0x7FFE878BF730
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

    public class ViveWand : XRControllerWithRumble
    {
        public UnityEngine.InputSystem.Controls.AxisControl _grip; // 0x1B0
        public UnityEngine.InputSystem.Controls.ButtonControl _gripPressed; // 0x1B8
        public UnityEngine.InputSystem.Controls.ButtonControl _primary; // 0x1C0
        public UnityEngine.InputSystem.Controls.ButtonControl _trackpadPressed; // 0x1C8
        public UnityEngine.InputSystem.Controls.ButtonControl _trackpadTouched; // 0x1D0
        public UnityEngine.InputSystem.Controls.Vector2Control _trackpad; // 0x1D8
        public UnityEngine.InputSystem.Controls.AxisControl _trigger; // 0x1E0
        public UnityEngine.InputSystem.Controls.ButtonControl _triggerPressed; // 0x1E8
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceVelocity; // 0x1F0
        public UnityEngine.InputSystem.Controls.Vector3Control _deviceAngularVelocity; // 0x1F8

        // ── Methods ──
        public void get_grip(){} // RVA: 0x7FFE81B23A60
        public void set_grip(){} // RVA: 0x7FFE81B2ACE0
        public void get_gripPressed(){} // RVA: 0x7FFE81B164E0
        public void set_gripPressed(){} // RVA: 0x7FFE81B38D70
        public void get_primary(){} // RVA: 0x7FFE817EFE00
        public void set_primary(){} // RVA: 0x7FFE81B0C930
        public void get_trackpadPressed(){} // RVA: 0x7FFE81B16E90
        public void set_trackpadPressed(){} // RVA: 0x7FFE81B290E0
        public void get_trackpadTouched(){} // RVA: 0x7FFE81B32320
        public void set_trackpadTouched(){} // RVA: 0x7FFE81B31B60
        public void get_trackpad(){} // RVA: 0x7FFE81B23D60
        public void set_trackpad(){} // RVA: 0x7FFE81B11520
        public void get_trigger(){} // RVA: 0x7FFE816611A0
        public void set_trigger(){} // RVA: 0x7FFE81B31CF0
        public void get_triggerPressed(){} // RVA: 0x7FFE81B27D50
        public void set_triggerPressed(){} // RVA: 0x7FFE81B34FD0
        public void get_deviceVelocity(){} // RVA: 0x7FFE81B21230
        public void set_deviceVelocity(){} // RVA: 0x7FFE81B374B0
        public void get_deviceAngularVelocity(){} // RVA: 0x7FFE81B20B40
        public void set_deviceAngularVelocity(){} // RVA: 0x7FFE81B2E610
        public void FinishSetup(){} // RVA: 0x7FFE878BF1A0
        public void .ctor(){} // RVA: 0x7FFE878BEB80
    }

}