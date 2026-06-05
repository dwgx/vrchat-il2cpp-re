// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 67
// Methods: 669

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_Camera
    {
        public object _head;

        // ── Methods ──
        public void get_head(){} // RVA: 0x7FFAF2DBB0C0
        public void get_offset(){} // RVA: 0x7FFAF2DBB0C0
        public void get_origin(){} // RVA: 0x7FFAF8FAFE00
        public void get_camera(){} // RVA: 0x7FFAF2DBB130
        public void set_camera(){} // RVA: 0x7FFAF2D8EE90
        public void get_ears(){} // RVA: 0x7FFAF30E74D0
        public void GetRay(){} // RVA: 0x7FFAF8FAFE60
        public void get_sceneResolutionScale(){} // RVA: 0x7FFAF8FAFFC0
        public void set_sceneResolutionScale(){} // RVA: 0x7FFAF8FB0010
        public void OnDisable(){} // RVA: 0x7FFAF8FB0070
        public void OnEnable(){} // RVA: 0x7FFAF8FB01D0
        public void Awake(){} // RVA: 0x7FFAF8FB0C60
        public void ForceLast(){} // RVA: 0x7FFAF8FB0CF0
        public void get_baseName(){} // RVA: 0x7FFAF8FB1640
        public void Expand(){} // RVA: 0x7FFAF8FB1700
        public void Collapse(){} // RVA: 0x7FFAF8FB2DD0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamVR_CameraFlip
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FB3BC0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamVR_CameraHelper
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8F52ED0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamVR_CameraMask
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF8FB3C60
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamVR_Ears
    {
        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x7FFAF8FB3D00
        public void OnEnable(){} // RVA: 0x7FFAF8FB40D0
        public void OnDisable(){} // RVA: 0x7FFAF8FB4450
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamVR_Events
    {
        // ── Methods ──
        public void CalibratingAction(){} // RVA: 0x7FFAF8FB4550
        public void DeviceConnectedAction(){} // RVA: 0x7FFAF8FB4600
        public void FadeAction(){} // RVA: 0x7FFAF8FB4750
        public void FadeReadyAction(){} // RVA: 0x7FFAF8FB48A0
        public void HideRenderModelsAction(){} // RVA: 0x7FFAF8FB4950
        public void InitializingAction(){} // RVA: 0x7FFAF8FB4A00
        public void InputFocusAction(){} // RVA: 0x7FFAF8FB4AB0
        public void LoadingAction(){} // RVA: 0x7FFAF8FB4B60
        public void LoadingFadeInAction(){} // RVA: 0x7FFAF8FB4C10
        public void LoadingFadeOutAction(){} // RVA: 0x7FFAF8FB4CC0
        public void NewPosesAction(){} // RVA: 0x7FFAF8FB4D70
        public void NewPosesAppliedAction(){} // RVA: 0x7FFAF8FB4E30
        public void InitializedAction(){} // RVA: 0x7FFAF8FB4EE0
        public void OutOfRangeAction(){} // RVA: 0x7FFAF8FB4F90
        public void RenderModelLoadedAction(){} // RVA: 0x7FFAF8FB5040
        public void System(){} // RVA: 0x7FFAF8FB5190
        public void SystemAction(){} // RVA: 0x7FFAF8FB5340
        public void .cctor(){} // RVA: 0x7FFAF8FB5480
    }

    public class SteamVR_ExternalCamera
    {
        // ── Methods ──
        public void ReadConfig(){} // RVA: 0x7FFAF8FB60C0
        public void SetupPose(){} // RVA: 0x7FFAF8FB6B00
        public void SetupDeviceIndex(){} // RVA: 0x7FFAF8FB6C80
        public void OnChanged(){} // RVA: 0x7FFAF8FB6D30
        public void AttachToCamera(){} // RVA: 0x7FFAF8FB6D40
        public void GetTargetDistance(){} // RVA: 0x7FFAF8FB8270
        public void RenderNear(){} // RVA: 0x7FFAF8FB87C0
        public void RenderFar(){} // RVA: 0x7FFAF8FB9940
        public void OnGUI(){} // RVA: 0x7FFAF2D8D310
        public void OnEnable(){} // RVA: 0x7FFAF8FB9C00
        public void AutoEnableActionSet(){} // RVA: 0x7FFAF8FBA130
        public void OnDisable(){} // RVA: 0x7FFAF8FBA2C0
        public void .ctor(){} // RVA: 0x7FFAF8FBA650
    }

    public class SteamVR_ExternalCamera_LegacyManager
    {
        public object IsValid;

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x7FFAF8FBA6B0
        public void SubscribeToNewPoses(){} // RVA: 0x7FFAF8FBA710
        public void OnNewPoses(){} // RVA: 0x7FFAF8FBA8B0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8FBA9E0
    }

    public class SteamVR_Fade
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAF8FBAA90
        public void View(){} // RVA: 0x7FFAF8FBAB60
        public void OnStartFade(){} // RVA: 0x7FFAF8FBABE0
        public void OnEnable(){} // RVA: 0x7FFAF8FBAC90
        public void OnDisable(){} // RVA: 0x7FFAF8FBAFA0
        public void OnPostRender(){} // RVA: 0x7FFAF8FBB0A0
        public void .ctor(){} // RVA: 0x7FFAF8FBB5E0
        public void .cctor(){} // RVA: 0x7FFAF8FBB640
    }

    public class SteamVR_Frustum
    {
        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x7FFAF8FBB6F0
        public void OnDeviceConnected(){} // RVA: 0x7FFAF8FBC120
        public void OnEnable(){} // RVA: 0x7FFAF8FBC3C0
        public void OnDisable(){} // RVA: 0x7FFAF8FBC510
        public void .ctor(){} // RVA: 0x7FFAF8FBC690
    }

    public class SteamVR_HistoryBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FD00B0
        public void Update(){} // RVA: 0x7FFAF8FD0180
        public void GetVelocityMagnitudeTrend(){} // RVA: 0x7FFAF8FD04F0
        public void IsValid(){} // RVA: 0x7FFAF8FD0600
        public void GetTopVelocity(){} // RVA: 0x7FFAF8FD0620
        public void GetAverageVelocities(){} // RVA: 0x7FFAF8FD0710
    }

    public class SteamVR_HistoryStep
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FD09E0
    }

    public class SteamVR_IK
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFAF8FBC700
        public void Solve(){} // RVA: 0x7FFAF8FBE030
        public void .ctor(){} // RVA: 0x7FFAF8FBE6D0
    }

    public class SteamVR_Input
    {
        // ── Methods ──
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x7FFAF8F959D0
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x7FFAF8F95B20
        public void add_onPosesUpdated(){} // RVA: 0x7FFAF8F95C70
        public void remove_onPosesUpdated(){} // RVA: 0x7FFAF8F95DC0
        public void add_onSkeletonsUpdated(){} // RVA: 0x7FFAF8F95F10
        public void remove_onSkeletonsUpdated(){} // RVA: 0x7FFAF8F96060
        public void get_isStartupFrame(){} // RVA: 0x7FFAF8F961B0
        public void .cctor(){} // RVA: 0x7FFAF8F962D0
        public void ForcePreinitialize(){} // RVA: 0x7FFAF8F968F0
        public void FindPreinitializeMethod(){} // RVA: 0x7FFAF8F96940
        public void Initialize(){} // RVA: 0x7FFAF8F96B20
        public void PreinitializeFinishActionSets(){} // RVA: 0x7FFAF8F970B0
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x7FFAF8F97180
        public void PreinitializeActionDictionaries(){} // RVA: 0x7FFAF8F97420
        public void Update(){} // RVA: 0x7FFAF8F97690
        public void LateUpdate(){} // RVA: 0x7FFAF8F977B0
        public void FixedUpdate(){} // RVA: 0x7FFAF8F978F0
        public void OnPreCull(){} // RVA: 0x7FFAF8F97A10
        public void UpdateVisualActions(){} // RVA: 0x7FFAF8F97B30
        public void UpdatePoseActions(){} // RVA: 0x7FFAF8F97D30
        public void UpdateSkeletonActions(){} // RVA: 0x7FFAF8F97EB0
        public void UpdateNonVisualActions(){} // RVA: 0x7FFAF8F98030
        public void ShowBindingHintsForSets(){} // RVA: 0x7FFAF8F98250
        public void ShowBindingHints(){} // RVA: 0x7FFAF8F985B0 | overloaded x2
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x7FFAF8F98690
        public void GetActionDataFromPath(){} // RVA: 0x7FFAF2D33FA0
        public void GetActionSetDataFromPath(){} // RVA: 0x7FFAF8F98840
        public void GetActionFromPath(){} // RVA: 0x7FFAF2D33FA0
        public void GetBaseActionFromPath(){} // RVA: 0x7FFAF8F988F0
        public void HasActionPath(){} // RVA: 0x7FFAF8F98D40
        public void HasAction(){} // RVA: 0x7FFAF8F98F60 | overloaded x2
        public void GetBooleanActionFromPath(){} // RVA: 0x7FFAF8F99070
        public void GetSingleActionFromPath(){} // RVA: 0x7FFAF8F990F0
        public void GetVector2ActionFromPath(){} // RVA: 0x7FFAF8F99170
        public void GetVector3ActionFromPath(){} // RVA: 0x7FFAF8F991F0
        public void GetVibrationActionFromPath(){} // RVA: 0x7FFAF8F99270
        public void GetPoseActionFromPath(){} // RVA: 0x7FFAF8F992F0
        public void GetSkeletonActionFromPath(){} // RVA: 0x7FFAF8F99370
        public void GetAction(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetBaseAction(){} // RVA: 0x7FFAF8F993F0
        public void CreateFakeAction(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetBooleanAction(){} // RVA: 0x7FFAF8F99950 | overloaded x2
        public void GetSingleAction(){} // RVA: 0x7FFAF8F99A60 | overloaded x2
        public void GetVector2Action(){} // RVA: 0x7FFAF8F99B70 | overloaded x2
        public void GetVector3Action(){} // RVA: 0x7FFAF8F99C80 | overloaded x2
        public void GetPoseAction(){} // RVA: 0x7FFAF8F99D90 | overloaded x2
        public void GetSkeletonAction(){} // RVA: 0x7FFAF8F99EA0 | overloaded x2
        public void GetVibrationAction(){} // RVA: 0x7FFAF8F99FB0 | overloaded x2
        public void GetActionSet(){} // RVA: 0x7FFAF8F9A030 | overloaded x2
        public void HasActionSet(){} // RVA: 0x7FFAF8F9A0C0
        public void GetActionSetFromPath(){} // RVA: 0x7FFAF8F9A160 | overloaded x2
        public void GetState(){} // RVA: 0x7FFAF8F9A340 | overloaded x2
        public void GetStateDown(){} // RVA: 0x7FFAF8F9A630 | overloaded x2
        public void GetStateUp(){} // RVA: 0x7FFAF8F9A920 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFAF8F9AC10 | overloaded x2
        public void GetSingle(){} // RVA: 0x7FFAF8F9ADF0 | overloaded x2
        public void GetVector2(){} // RVA: 0x7FFAF8F9B000 | overloaded x2
        public void GetVector3(){} // RVA: 0x7FFAF8F9B3A0 | overloaded x2
        public void GetActionSets(){} // RVA: 0x7FFAF8F9B440
        public void GetActions(){} // RVA: 0x7FFAF2ABC960
        public void ShouldMakeCopy(){} // RVA: 0x7FFAF8F9B4A0
        public void GetLocalizedName(){} // RVA: 0x7FFAF8F9B500
        public void CheckOldLocation(){} // RVA: 0x7FFAF2D8D320
        public void IdentifyActionsFile(){} // RVA: 0x7FFAF8F9B650
        public void HasFileInMemoryBeenModified(){} // RVA: 0x7FFAF8F9B9E0
        public void CreateEmptyActionsFile(){} // RVA: 0x7FFAF8F9BBB0
        public void DoesActionsFileExist(){} // RVA: 0x7FFAF8F9C260
        public void InitializeFile(){} // RVA: 0x7FFAF8F9C2C0
        public void GetActionsFileFolder(){} // RVA: 0x7FFAF8F9C6E0
        public void GetActionsFilePath(){} // RVA: 0x7FFAF8F9C7F0
        public void GetActionsFileName(){} // RVA: 0x7FFAF8F9CA90
        public void DeleteManifestAndBindings(){} // RVA: 0x7FFAF8F9CAF0
        public void OpenBindingUI(){} // RVA: 0x7FFAF8F9CF60
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionFile
    {
        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x7FFAF8F9D170
        public void SaveHelperLists(){} // RVA: 0x7FFAF8F9D820
        public void GetShortName(){} // RVA: 0x7FFAF8F9E060
        public void GetCodeFriendlyName(){} // RVA: 0x7FFAF8F9E100
        public void GetFilesToCopy(){} // RVA: 0x7FFAF8F9E2B0
        public void CopyFilesToPath(){} // RVA: 0x7FFAF8F9E630
        public void RemoveAppKey(){} // RVA: 0x7FFAF8F9E900
        public void Open(){} // RVA: 0x7FFAF8F9EA80
        public void Save(){} // RVA: 0x7FFAF8F9EB80
        public void .ctor(){} // RVA: 0x7FFAF8F9ED00
    }

    public class SteamVR_Input_ActionFile_Action
    {
        // ── Methods ──
        public void get_requirementValues(){} // RVA: 0x7FFAF8F9FAD0
        public void GetCopy(){} // RVA: 0x7FFAF8F9FCB0
        public void get_requirementEnum(){} // RVA: 0x7FFAF8F9FEA0
        public void set_requirementEnum(){} // RVA: 0x7FFAF8F9FFE0
        public void get_codeFriendlyName(){} // RVA: 0x7FFAF8F9F3F0
        public void get_shortName(){} // RVA: 0x7FFAF8FA0090
        public void get_path(){} // RVA: 0x7FFAF8FA00A0
        public void CreateNewName(){} // RVA: 0x7FFAF8FA01D0 | overloaded x2
        public void CreateNew(){} // RVA: 0x7FFAF8FA02C0
        public void get_direction(){} // RVA: 0x7FFAF8FA04C0
        public void get_actionSet(){} // RVA: 0x7FFAF8FA0580
        public void SetNewActionSet(){} // RVA: 0x7FFAF8FA0630
        public void ToString(){} // RVA: 0x7FFAF8FA0090
        public void Equals(){} // RVA: 0x7FFAF8FA0830
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionFile_ActionSet
    {
        // ── Methods ──
        public void get_codeFriendlyName(){} // RVA: 0x7FFAF8F9F3F0
        public void get_shortName(){} // RVA: 0x7FFAF8F9F400
        public void SetNewShortName(){} // RVA: 0x7FFAF8F9F500
        public void CreateNewName(){} // RVA: 0x7FFAF8F9F570
        public void GetPathFromName(){} // RVA: 0x7FFAF8F9F5B0
        public void CreateNew(){} // RVA: 0x7FFAF8F9F640
        public void GetCopy(){} // RVA: 0x7FFAF8F9F710
        public void Equals(){} // RVA: 0x7FFAF8F9F820
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF8F9F920
    }

    public class SteamVR_Input_ActionFile_ActionSet_Usages
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8FA2230
    }

    public class SteamVR_Input_ActionFile_ActionTypes
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAF8FA1950
    }

    public class SteamVR_Input_ActionFile_DefaultBinding
    {
        // ── Methods ──
        public void GetCopy(){} // RVA: 0x7FFAF8F9F2F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionFile_LocalizationItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FA0B30 | overloaded x2
    }

    public class SteamVR_Input_ActionSet_Action_Menu
    {
        // ── Methods ──
        public void get_Axis(){} // RVA: 0x7FFAF8F6C2C0
        public void get_Select(){} // RVA: 0x7FFAF8F6C2D0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFAF8F6C2E0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAF8F6C2F0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAF8F6C300
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAF8F6C310
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFAF8F6C320
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFAF8F6C330
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFAF8F6C340
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFAF8F6C350
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAF8F6C360
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFAF8F6C370
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAF8F6C380
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAF8F6C390
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAF8F6C3A0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAF8F6C3B0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAF8F6C3C0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAF8F6C3D0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAF8F6C3E0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAF8F6C3F0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFAF8F6C400
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAF8F6C410
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAF8F6C420
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAF8F6C430
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAF8F6C440
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAF8F6C450
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAF8F6C460
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAF8F6C470
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAF8F6C480
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAF8F6C490
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAF8F6C4A0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAF8F6C4B0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAF8F6C4C0
        public void get_Reserve_bool(){} // RVA: 0x7FFAF8F6C4D0
        public void get_Reserve_vector1(){} // RVA: 0x7FFAF8F6C4E0
        public void get_Reserve_vector2(){} // RVA: 0x7FFAF8F6C4F0
        public void get_Grab(){} // RVA: 0x7FFAF8F6C500
        public void get_Drop(){} // RVA: 0x7FFAF8F6C510
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionSet_Drone
    {
        // ── Methods ──
        public void get_Left_Joystick(){} // RVA: 0x7FFAF8F6C520
        public void get_Right_Joystick(){} // RVA: 0x7FFAF8F6C530
        public void get_Self_Leveling_Mod(){} // RVA: 0x7FFAF8F6C540
        public void get_Hold_Altitude_Mod(){} // RVA: 0x7FFAF8F6C550
        public void get_Toggle_FPV(){} // RVA: 0x7FFAF8F6C560
        public void get_Flip(){} // RVA: 0x7FFAF8F6C570
        public void get_Take_Picture(){} // RVA: 0x7FFAF8F6C580
        public void get_Cycle_Flight_Preset(){} // RVA: 0x7FFAF8F6C590
        public void get_Toggle_Self_Leveling(){} // RVA: 0x7FFAF8F6C5A0
        public void get_Respawn(){} // RVA: 0x7FFAF8F6C5B0
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x7FFAF8F6C5C0
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFAF8F6C5D0
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x7FFAF8F6C5E0
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFAF8F6C5F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionSet_Global
    {
        // ── Methods ──
        public void get_Safe_Mode(){} // RVA: 0x7FFAF8F6C600
        public void get_Pose(){} // RVA: 0x7FFAF8F6C610
        public void get_SkeletonLeftHand(){} // RVA: 0x7FFAF8F6C620
        public void get_SkeletonRightHand(){} // RVA: 0x7FFAF8F6C630
        public void get_HeadsetOnHead(){} // RVA: 0x7FFAF8F6C640
        public void get_Menu(){} // RVA: 0x7FFAF8F6C650
        public void get_Quick_Menu(){} // RVA: 0x7FFAF8F6C660
        public void get_Action_Menu(){} // RVA: 0x7FFAF8F6C670
        public void get_Main_Menu(){} // RVA: 0x7FFAF8F6C680
        public void get_Interact(){} // RVA: 0x7FFAF8F6C690
        public void get_Grab(){} // RVA: 0x7FFAF8F6C6A0
        public void get_Move(){} // RVA: 0x7FFAF8F6C6B0
        public void get_Jump(){} // RVA: 0x7FFAF8F6C6C0
        public void get_Rotate(){} // RVA: 0x7FFAF8F6C6D0
        public void get_Mic(){} // RVA: 0x7FFAF8F6C6E0
        public void get_Gesture_Toggle(){} // RVA: 0x7FFAF8F6C6F0
        public void get_Stick_Click(){} // RVA: 0x7FFAF8F6C700
        public void get_Trigger_Axis(){} // RVA: 0x7FFAF8F6C710
        public void get_Grip_Axis(){} // RVA: 0x7FFAF8F6C720
        public void get_Udon_Menu(){} // RVA: 0x7FFAF8F6C730
        public void get_Drop(){} // RVA: 0x7FFAF8F6C740
        public void get_Nameplates(){} // RVA: 0x7FFAF8F6C750
        public void get_HUD(){} // RVA: 0x7FFAF8F6C760
        public void get_Chatbox(){} // RVA: 0x7FFAF8F6C770
        public void get_Face_Mirror(){} // RVA: 0x7FFAF8F6C780
        public void get_Personal_Mirror(){} // RVA: 0x7FFAF8F6C790
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFAF8F6C7A0
        public void get_Earmuffs(){} // RVA: 0x7FFAF8F6C7B0
        public void get_Camera(){} // RVA: 0x7FFAF8F6C7C0
        public void get_Stream_Camera(){} // RVA: 0x7FFAF8F6C7D0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFAF8F6C7E0
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFAF8F6C7F0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFAF8F6C800
        public void get_Start_Move(){} // RVA: 0x7FFAF8F6C810
        public void get_Start_Rotate(){} // RVA: 0x7FFAF8F6C820
        public void get_Continue_Move(){} // RVA: 0x7FFAF8F6C830
        public void get_Continue_Rotate(){} // RVA: 0x7FFAF8F6C840
        public void get_No_Gesture_After_Move(){} // RVA: 0x7FFAF8F6C850
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x7FFAF8F6C860
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFAF8F6C870
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAF8F6C880
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAF8F6C890
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAF8F6C8A0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFAF8F6C8B0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFAF8F6C8C0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFAF8F6C8D0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFAF8F6C8E0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAF8F6C8F0
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFAF8F6C900
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFAF8F6C910
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x7FFAF8F6C920
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFAF8F6C930
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFAF8F6C940
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFAF8F6C950
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFAF8F6C960
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x7FFAF8F6C970
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFAF8F6C980
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFAF8F6C990
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x7FFAF8F6C9A0
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFAF8F6C9B0
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFAF8F6C9C0
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFAF8F6C9D0
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFAF8F6C9E0
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x7FFAF8F6C9F0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFAF8F6CA00
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAF8F6CA10
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAF8F6CA20
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAF8F6CA30
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAF8F6CA40
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAF8F6CA50
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAF8F6CA60
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAF8F6CA70
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAF8F6CA80
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFAF8F6CA90
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAF8F6CAA0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAF8F6CAB0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAF8F6CAC0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAF8F6CAD0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAF8F6CAE0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAF8F6CAF0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAF8F6CB00
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAF8F6CB10
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x7FFAF8F6CB20
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAF8F6CB30
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAF8F6CB40
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAF8F6CB50
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAF8F6CB60
        public void get_Physbone_Grab_Left(){} // RVA: 0x7FFAF8F6CB70
        public void get_Physbone_Freeze_Left(){} // RVA: 0x7FFAF8F6CB80
        public void get_Physbone_Grab_Right(){} // RVA: 0x7FFAF8F6CB90
        public void get_Physbone_Freeze_Right(){} // RVA: 0x7FFAF8F6CBA0
        public void get_Scroll(){} // RVA: 0x7FFAF8F6CBB0
        public void get_Haptic(){} // RVA: 0x7FFAF8F6CBC0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionSet_Menu
    {
        // ── Methods ──
        public void get_Confirm(){} // RVA: 0x7FFAF8F6CBD0
        public void get_Back(){} // RVA: 0x7FFAF8F6CBE0
        public void get_Tab(){} // RVA: 0x7FFAF8F6CBF0
        public void get_Scroll(){} // RVA: 0x7FFAF8F6CC00
        public void get_Quick_Menu_Close(){} // RVA: 0x7FFAF8F6CC10
        public void get_Drag(){} // RVA: 0x7FFAF8F6CC20
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ActionSet_One_Hand
    {
        // ── Methods ──
        public void get_Interact(){} // RVA: 0x7FFAF8F6CC30
        public void get_Grab(){} // RVA: 0x7FFAF8F6CC40
        public void get_Move_Rotate(){} // RVA: 0x7FFAF8F6CC50
        public void get_Jump(){} // RVA: 0x7FFAF8F6CC60
        public void get_Mic(){} // RVA: 0x7FFAF8F6CC70
        public void get_Gesture_Toggle(){} // RVA: 0x7FFAF8F6CC80
        public void get_Stick_Click(){} // RVA: 0x7FFAF8F6CC90
        public void get_Trigger_Axis(){} // RVA: 0x7FFAF8F6CCA0
        public void get_Grip_Axis(){} // RVA: 0x7FFAF8F6CCB0
        public void get_Udon_Menu(){} // RVA: 0x7FFAF8F6CCC0
        public void get_Drop(){} // RVA: 0x7FFAF8F6CCD0
        public void get_Start_Move_Rotate(){} // RVA: 0x7FFAF8F6CCE0
        public void get_Continue_Move_Rotate(){} // RVA: 0x7FFAF8F6CCF0
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFAF8F6CD00
        public void get_Menu(){} // RVA: 0x7FFAF8F6CD10
        public void get_Nameplates(){} // RVA: 0x7FFAF8F6CD20
        public void get_HUD(){} // RVA: 0x7FFAF8F6CD30
        public void get_Chatbox(){} // RVA: 0x7FFAF8F6CD40
        public void get_Face_Mirror(){} // RVA: 0x7FFAF8F6CD50
        public void get_Personal_Mirror(){} // RVA: 0x7FFAF8F6CD60
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFAF8F6CD70
        public void get_Earmuffs(){} // RVA: 0x7FFAF8F6CD80
        public void get_Camera(){} // RVA: 0x7FFAF8F6CD90
        public void get_Stream_Camera(){} // RVA: 0x7FFAF8F6CDA0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFAF8F6CDB0
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFAF8F6CDC0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFAF8F6CDD0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFAF8F6CDE0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAF8F6CDF0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAF8F6CE00
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAF8F6CE10
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFAF8F6CE20
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFAF8F6CE30
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFAF8F6CE40
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFAF8F6CE50
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAF8F6CE60
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFAF8F6CE70
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAF8F6CE80
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAF8F6CE90
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAF8F6CEA0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAF8F6CEB0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAF8F6CEC0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAF8F6CED0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAF8F6CEE0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAF8F6CEF0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFAF8F6CF00
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAF8F6CF10
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAF8F6CF20
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAF8F6CF30
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAF8F6CF40
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAF8F6CF50
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAF8F6CF60
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAF8F6CF70
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAF8F6CF80
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAF8F6CF90
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAF8F6CFA0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAF8F6CFB0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAF8F6CFC0
        public void get_Reserve_bool(){} // RVA: 0x7FFAF8F6CFD0
        public void get_Reserve_vector1(){} // RVA: 0x7FFAF8F6CFE0
        public void get_Reserve_vector2(){} // RVA: 0x7FFAF8F6CFF0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_BindingFile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FA2740
    }

    public class SteamVR_Input_BindingFile_ActionList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FA2800
    }

    public class SteamVR_Input_BindingFile_Chord
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF8FA2B20
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF8FA2E50
    }

    public class SteamVR_Input_BindingFile_Haptic
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF8FA3060
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_BindingFile_Pose
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF8FA2F10
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_BindingFile_Skeleton
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF8FA31B0
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_BindingFile_Source
    {
        // ── Methods ──
        public void GetOutput(){} // RVA: 0x7FFAF8FA3300
        public void Equals(){} // RVA: 0x7FFAF8FA3680
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF8FA3870
    }

    public class SteamVR_Input_BindingFile_Source_Input
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF8FA39F0
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF8FA3CE0
    }

    public class SteamVR_Input_BindingFile_Source_Input_StringDictionary
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF8FA3D20
        public void GetHashCode(){} // RVA: 0x7FFAF8713910
        public void .ctor(){} // RVA: 0x7FFAF8FA3E60
    }

    public class SteamVR_Input_Generator_Names
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ManifestFile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ManifestFile_Application
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FA0EF0
    }

    public class SteamVR_Input_ManifestFile_ApplicationString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding_ControllerTypes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8FA1310
    }

    public class SteamVR_Input_Source
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFAF8FA3EA0
        public void GetSource(){} // RVA: 0x7FFAF8FA3F50
        public void GetAllSources(){} // RVA: 0x7FFAF8FA40E0
        public void GetPath(){} // RVA: 0x7FFAF8FA4380
        public void Initialize(){} // RVA: 0x7FFAF8FA44C0
        public void .cctor(){} // RVA: 0x7FFAF8FA4D50
    }

    public class SteamVR_Input_Sources_Comparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAF5F21600
        public void GetHashCode(){} // RVA: 0x7FFAF65F5020
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FA0FB0
    }

    public class SteamVR_LoadLevel
    {
        // ── Methods ──
        public void get_loading(){} // RVA: 0x7FFAF8FBE720
        public void get_progress(){} // RVA: 0x7FFAF8FBE810
        public void get_progressTexture(){} // RVA: 0x7FFAF8FBE970
        public void OnEnable(){} // RVA: 0x7FFAF8FBEA80
        public void Trigger(){} // RVA: 0x7FFAF8FBEAA0
        public void Begin(){} // RVA: 0x7FFAF8FBEC40
        public void OnGUI(){} // RVA: 0x7FFAF8FBEDB0
        public void Update(){} // RVA: 0x7FFAF8FBF540
        public void LoadLevel(){} // RVA: 0x7FFAF8FBF7A0
        public void GetOverlayHandle(){} // RVA: 0x7FFAF8FBF840
        public void .ctor(){} // RVA: 0x7FFAF8FBFE80
    }

    public class SteamVR_Menu
    {
        public object _texture;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFAF8FC14E0
        public void get_scale(){} // RVA: 0x7FFAF2DB60C0
        public void set_scale(){} // RVA: 0x7FFAF2DB60D0
        public void Awake(){} // RVA: 0x7FFAF8FC1630
        public void OnGUI(){} // RVA: 0x7FFAF8FC1980
        public void ShowMenu(){} // RVA: 0x7FFAF8FC30D0
        public void HideMenu(){} // RVA: 0x7FFAF8FC37B0
        public void Update(){} // RVA: 0x7FFAF8FC3A70
        public void SetScale(){} // RVA: 0x7FFAF8FC3D10
        public void SaveCursorState(){} // RVA: 0x7FFAF8FC3EA0
        public void RestoreCursorState(){} // RVA: 0x7FFAF8FC3F40
        public void .ctor(){} // RVA: 0x7FFAF8FC3FF0
    }

    public class SteamVR_Overlay
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF8FC4050
        public void set_instance(){} // RVA: 0x7FFAF8FC4090
        public void get_key(){} // RVA: 0x7FFAF8FC4130
        public void OnEnable(){} // RVA: 0x7FFAF8FC4240
        public void OnDisable(){} // RVA: 0x7FFAF8FC4420
        public void UpdateOverlay(){} // RVA: 0x7FFAF8FC4480
        public void PollNextEvent(){} // RVA: 0x7FFAF8FC4B40
        public void ComputeIntersection(){} // RVA: 0x7FFAF8FC4C50
        public void .ctor(){} // RVA: 0x7FFAF8FC4E30
    }

    public class SteamVR_PlayArea
    {
        // ── Methods ──
        public void GetBounds(){} // RVA: 0x7FFAF8FC4EB0
        public void BuildMesh(){} // RVA: 0x7FFAF8FC51C0
        public void OnDrawGizmos(){} // RVA: 0x7FFAF8FC5F90
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFAF8FC5FA0
        public void DrawWireframe(){} // RVA: 0x7FFAF8FC5FB0
        public void OnEnable(){} // RVA: 0x7FFAF8FC6580
        public void UpdateBounds(){} // RVA: 0x7FFAF8FC6790
        public void .ctor(){} // RVA: 0x7FFAF8FC6830
    }

    public class SteamVR_Render
    {
        // ── Methods ──
        public void get_eye(){} // RVA: 0x7FFAF8FC6AF0
        public void set_eye(){} // RVA: 0x7FFAF8FC6B30
        public void get_instance(){} // RVA: 0x7FFAF8FC6B70
        public void OnApplicationQuit(){} // RVA: 0x7FFAF8FC6BD0
        public void Add(){} // RVA: 0x7FFAF8FC6C40
        public void Remove(){} // RVA: 0x7FFAF8FB0070
        public void Top(){} // RVA: 0x7FFAF8FC6CF0
        public void AddInternal(){} // RVA: 0x7FFAF8FC6DB0
        public void RemoveInternal(){} // RVA: 0x7FFAF8FC7040
        public void TopInternal(){} // RVA: 0x7FFAF8FC73D0
        public void get_pauseRendering(){} // RVA: 0x7FFAF8FC7410
        public void set_pauseRendering(){} // RVA: 0x7FFAF8FC7450
        public void RenderLoop(){} // RVA: 0x7FFAF8FC74E0
        public void CheckExternalCamera(){} // RVA: 0x7FFAF8FC7580
        public void RenderExternalCamera(){} // RVA: 0x7FFAF8FC7FE0
        public void OnInputFocus(){} // RVA: 0x7FFAF8FC8230
        public void GetScreenshotFilename(){} // RVA: 0x7FFAF8FC8350
        public void OnRequestScreenshot(){} // RVA: 0x7FFAF8FC84C0
        public void OnEnable(){} // RVA: 0x7FFAF8FC89A0
        public void OnSteamVRInitialized(){} // RVA: 0x7FFAF8FC8F90
        public void OnDisable(){} // RVA: 0x7FFAF8FC8FF0
        public void UpdatePoses(){} // RVA: 0x7FFAF8FC9390
        public void OnBeforeRender(){} // RVA: 0x7FFAF8FC94C0
        public void Update(){} // RVA: 0x7FFAF8FC9590
        public void .ctor(){} // RVA: 0x7FFAF8FC9AF0
    }

    public class SteamVR_RenderModel
    {
        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0x7FFAF2E0A740
        public void set_renderModelName(){} // RVA: 0x7FFAF2DB5200
        public void get_initializedAttachPoints(){} // RVA: 0x7FFAF2E44D30
        public void set_initializedAttachPoints(){} // RVA: 0x7FFAF2E44D40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x7FFAF8FCA220
        public void SetMeshRendererState(){} // RVA: 0x7FFAF8FCA2D0
        public void OnHideRenderModels(){} // RVA: 0x7FFAF8FCA460
        public void OnDeviceConnected(){} // RVA: 0x7FFAF8FCA470
        public void UpdateModel(){} // RVA: 0x7FFAF8FCA490
        public void SetModelAsync(){} // RVA: 0x7FFAF8FCA7C0
        public void SetModel(){} // RVA: 0x7FFAF8FCA8C0
        public void LoadRenderModel(){} // RVA: 0x7FFAF8FCAED0
        public void ConvertByteColorGammaExp(){} // RVA: 0x7FFAF8FCC510
        public void FreeRenderModel(){} // RVA: 0x7FFAF8FCC570
        public void FindTransformByName(){} // RVA: 0x7FFAF8FCC5C0
        public void GetComponentTransform(){} // RVA: 0x7FFAF8FCC7F0
        public void StripMesh(){} // RVA: 0x7FFAF8FCC8F0
        public void LoadComponents(){} // RVA: 0x7FFAF8FCCAE0
        public void .ctor(){} // RVA: 0x7FFAF8FCD7C0
        public void OnEnable(){} // RVA: 0x7FFAF8FCDBE0
        public void OnDisable(){} // RVA: 0x7FFAF8FCDD50
        public void Update(){} // RVA: 0x7FFAF8FCDDC0
        public void UpdateComponents(){} // RVA: 0x7FFAF8FCDE10
        public void SetDeviceIndex(){} // RVA: 0x7FFAF8FCE870
        public void SetInputSource(){} // RVA: 0x7FFAF4191F00
        public void Sleep(){} // RVA: 0x7FFAF8FCE950
        public void MarshalRenderModel(){} // RVA: 0x7FFAF8FCE960
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x7FFAF8FCEB90
        public void .cctor(){} // RVA: 0x7FFAF8FCEDC0
    }

    public class SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4FA0
        public void Add(){} // RVA: 0x7FFAF2D33FA0
        public void StepForward(){} // RVA: 0x7FFAF2AD4A50
        public void GetAtIndex(){} // RVA: 0x7FFAF2D33FA0
        public void GetLast(){} // RVA: 0x7FFAF2D33FA0
        public void GetLastIndex(){} // RVA: 0x7FFAF2ABD840
        public void Clear(){} // RVA: 0x7FFAF2AD4A50
    }

    public class SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF6B40820
        public void Add(){} // RVA: 0x7FFAF6B408C0
        public void StepForward(){} // RVA: 0x7FFAF6B40900
        public void GetAtIndex(){} // RVA: 0x7FFAF6B409B0
        public void GetLast(){} // RVA: 0x7FFAF2DBB0C0
        public void GetLastIndex(){} // RVA: 0x7FFAF6B409F0
        public void Clear(){} // RVA: 0x7FFAF6B40A20
    }

    public class SteamVR_Settings
    {
        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFAF8FD09F0
        public void get_trackingSpace(){} // RVA: 0x7FFAF442C3B0
        public void set_trackingSpace(){} // RVA: 0x7FFAF8FD0A40
        public void IsInputUpdateMode(){} // RVA: 0x7FFAF8FD0AC0
        public void IsPoseUpdateMode(){} // RVA: 0x7FFAF8FD0AD0
        public void VerifyScriptableObject(){} // RVA: 0x7FFAF8FD0AE0
        public void LoadInstance(){} // RVA: 0x7FFAF8FD0AF0
        public void Save(){} // RVA: 0x7FFAF2D8D310
        public void SetDefaultsIfNeeded(){} // RVA: 0x7FFAF8FD0DB0
        public void FindDefaultPreviewHand(){} // RVA: 0x7FFAF2FC9240
        public void .ctor(){} // RVA: 0x7FFAF8FD0FC0
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists
    {
        // ── Methods ──
        public void get_enumList(){} // RVA: 0x7FFAF8FA53F0
        public void get_stringList(){} // RVA: 0x7FFAF8FA5600
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_Skeleton_FingerIndexes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8F6AD80
    }

    public class SteamVR_Skeleton_FingerSplayIndexes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void .cctor(){} // RVA: 0x7FFAF8F6AFF0
    }

    public class SteamVR_Skeleton_HandMask
    {
        // ── Methods ──
        public void SetFinger(){} // RVA: 0x7FFAF8FA9070
        public void GetFinger(){} // RVA: 0x7FFAF8FA90B0
        public void .ctor(){} // RVA: 0x7FFAF8FA90E0
        public void Reset(){} // RVA: 0x7FFAF8FA92A0
        public void Apply(){} // RVA: 0x7FFAF8FA9360
        public void .cctor(){} // RVA: 0x7FFAF8FA9420
    }

    public class SteamVR_Skeleton_JointIndexes
    {
        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x7FFAF8F6ACC0
        public void GetBoneForFingerTip(){} // RVA: 0x7FFAF8F6AD40
    }

    public class SteamVR_Skeleton_Pose
    {
        // ── Methods ──
        public void GetHand(){} // RVA: 0x7FFAF8FA5150 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF8FA5170
    }

    public class SteamVR_Skeleton_PoseSnapshot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8FA8DD0
        public void CopyFrom(){} // RVA: 0x7FFAF8FA8F70
    }

    public class SteamVR_Skeleton_Pose_Hand
    {
        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x7FFAF8FA52A0
        public void .ctor(){} // RVA: 0x7FFAF8FA5370
        public void GetMovementTypeForBone(){} // RVA: 0x7FFAF8FA5380
    }

    public class SteamVR_Skeleton_Poser
    {
        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x7FFAF8FA5990
        public void Awake(){} // RVA: 0x7FFAF8FA59B0
        public void SetBlendingBehaviourValue(){} // RVA: 0x7FFAF8FA5F00
        public void GetBlendingBehaviourValue(){} // RVA: 0x7FFAF8FA5FD0
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x7FFAF8FA6000
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x7FFAF8FA6030
        public void GetBlendingBehaviour(){} // RVA: 0x7FFAF8FA6060
        public void FindBlendingBehaviour(){} // RVA: 0x7FFAF8FA6070
        public void GetPoseByIndex(){} // RVA: 0x7FFAF8FA6280
        public void GetHandSnapshot(){} // RVA: 0x7FFAF8FA6310
        public void GetBlendedPose(){} // RVA: 0x7FFAF8FA6370 | overloaded x2
        public void UpdatePose(){} // RVA: 0x7FFAF8FA63C0
        public void ApplyBlenderBehaviours(){} // RVA: 0x7FFAF8FA66A0
        public void LateUpdate(){} // RVA: 0x7FFAF8FA6960
        public void BlendVectors(){} // RVA: 0x7FFAF8FA6970
        public void BlendQuaternions(){} // RVA: 0x7FFAF8FA6A70
        public void GetTargetHandPosition(){} // RVA: 0x7FFAF8FA6D60
        public void GetTargetHandRotation(){} // RVA: 0x7FFAF8FA7360
        public void .ctor(){} // RVA: 0x7FFAF8FA7A20
    }

    public class SteamVR_Skybox
    {
        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x7FFAF8FD1200
        public void GetTextureByIndex(){} // RVA: 0x7FFAF8FD1290
        public void SetOverride(){} // RVA: 0x7FFAF8FD12F0
        public void ClearOverride(){} // RVA: 0x7FFAF8FD1800
        public void OnEnable(){} // RVA: 0x7FFAF8FD1850
        public void OnDisable(){} // RVA: 0x7FFAF8FD1800
        public void .ctor(){} // RVA: 0x7FFAF8FD1890
    }

    public class SteamVR_SphericalProjection
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7FFAF8FD18F0
        public void OnRenderImage(){} // RVA: 0x7FFAF8FD1EE0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class SteamVR_TrackedCamera
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x7FFAF8FD1F70
        public void Undistorted(){} // RVA: 0x7FFAF8FD2110
        public void Source(){} // RVA: 0x7FFAF8FD22C0
        public void Stream(){} // RVA: 0x7FFAF8FD2600
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class SteamVR_TrackedObject
    {
        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFAF2DB3450
        public void set_isValid(){} // RVA: 0x7FFAF2DB3460
        public void OnNewPoses(){} // RVA: 0x7FFAF8FD33F0
        public void .ctor(){} // RVA: 0x7FFAF8FD39D0
        public void Awake(){} // RVA: 0x7FFAF8FD3AF0
        public void OnEnable(){} // RVA: 0x7FFAF8FD3AF0
        public void OnDisable(){} // RVA: 0x7FFAF8FD3C80
        public void SetDeviceIndex(){} // RVA: 0x7FFAF8FD3CC0
    }

    public class SteamVR_TrackingReferenceManager
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFAF8FD3E80
        public void OnDisable(){} // RVA: 0x7FFAF8FD3F60
        public void OnNewPoses(){} // RVA: 0x7FFAF8FD4070
        public void .ctor(){} // RVA: 0x7FFAF8FD4400
    }

}