// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 67
// Methods: 669

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_Camera
    {
        public UnityEngine.Transform _head; // 0x20
        public UnityEngine.Camera <camera>k__BackingField; // 0x28
        public UnityEngine.Transform _ears; // 0x30
        public bool wireframe; // 0x38
        public System.Collections.Hashtable values;
        public string eyeSuffix;
        public string earsSuffix;

        // ── Methods ──
        public void get_head(){} // RVA: 0x30B0C0
        public void get_offset(){} // RVA: 0x30B0C0
        public void get_origin(){} // RVA: 0x64FFE00
        public void get_camera(){} // RVA: 0x30B130
        public void set_camera(){} // RVA: 0x2DEE90
        public void get_ears(){} // RVA: 0x6374D0
        public void GetRay(){} // RVA: 0x64FFE60
        public void get_sceneResolutionScale(){} // RVA: 0x64FFFC0
        public void set_sceneResolutionScale(){} // RVA: 0x6500010
        public void OnDisable(){} // RVA: 0x6500070
        public void OnEnable(){} // RVA: 0x65001D0
        public void Awake(){} // RVA: 0x6500C60
        public void ForceLast(){} // RVA: 0x6500CF0
        public void get_baseName(){} // RVA: 0x6501640
        public void Expand(){} // RVA: 0x6501700
        public void Collapse(){} // RVA: 0x6502DD0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_CameraFlip
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6503BC0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_CameraHelper
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x64A2ED0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_CameraMask
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x6503C60
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_Ears
    {
        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x6503D00
        public void OnEnable(){} // RVA: 0x65040D0
        public void OnDisable(){} // RVA: 0x6504450
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_Events
    {
        // ── Methods ──
        public void CalibratingAction(){} // RVA: 0x6504550
        public void DeviceConnectedAction(){} // RVA: 0x6504600
        public void FadeAction(){} // RVA: 0x6504750
        public void FadeReadyAction(){} // RVA: 0x65048A0
        public void HideRenderModelsAction(){} // RVA: 0x6504950
        public void InitializingAction(){} // RVA: 0x6504A00
        public void InputFocusAction(){} // RVA: 0x6504AB0
        public void LoadingAction(){} // RVA: 0x6504B60
        public void LoadingFadeInAction(){} // RVA: 0x6504C10
        public void LoadingFadeOutAction(){} // RVA: 0x6504CC0
        public void NewPosesAction(){} // RVA: 0x6504D70
        public void NewPosesAppliedAction(){} // RVA: 0x6504E30
        public void InitializedAction(){} // RVA: 0x6504EE0
        public void OutOfRangeAction(){} // RVA: 0x6504F90
        public void RenderModelLoadedAction(){} // RVA: 0x6505040
        public void System(){} // RVA: 0x6505190
        public void SystemAction(){} // RVA: 0x6505340
        public void .cctor(){} // RVA: 0x6505480
    }

    public class SteamVR_ExternalCamera
    {
        // ── Methods ──
        public void ReadConfig(){} // RVA: 0x65060C0
        public void SetupPose(){} // RVA: 0x6506B00
        public void SetupDeviceIndex(){} // RVA: 0x6506C80
        public void OnChanged(){} // RVA: 0x6506D30
        public void AttachToCamera(){} // RVA: 0x6506D40
        public void GetTargetDistance(){} // RVA: 0x6508270
        public void RenderNear(){} // RVA: 0x65087C0
        public void RenderFar(){} // RVA: 0x6509940
        public void OnGUI(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x6509C00
        public void AutoEnableActionSet(){} // RVA: 0x650A130
        public void OnDisable(){} // RVA: 0x650A2C0
        public void .ctor(){} // RVA: 0x650A650
    }

    public class SteamVR_ExternalCamera_LegacyManager
    {
        public int IsValid;

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x650A6B0
        public void SubscribeToNewPoses(){} // RVA: 0x650A710
        public void OnNewPoses(){} // RVA: 0x650A8B0
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x650A9E0
    }

    public class SteamVR_Fade
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x650AA90
        public void View(){} // RVA: 0x650AB60
        public void OnStartFade(){} // RVA: 0x650ABE0
        public void OnEnable(){} // RVA: 0x650AC90
        public void OnDisable(){} // RVA: 0x650AFA0
        public void OnPostRender(){} // RVA: 0x650B0A0
        public void .ctor(){} // RVA: 0x650B5E0
        public void .cctor(){} // RVA: 0x650B640
    }

    public class SteamVR_Frustum
    {
        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x650B6F0
        public void OnDeviceConnected(){} // RVA: 0x650C120
        public void OnEnable(){} // RVA: 0x650C3C0
        public void OnDisable(){} // RVA: 0x650C510
        public void .ctor(){} // RVA: 0x650C690
    }

    public class SteamVR_HistoryBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65200B0
        public void Update(){} // RVA: 0x6520180
        public void GetVelocityMagnitudeTrend(){} // RVA: 0x65204F0
        public void IsValid(){} // RVA: 0x6520600
        public void GetTopVelocity(){} // RVA: 0x6520620
        public void GetAverageVelocities(){} // RVA: 0x6520710
    }

    public class SteamVR_HistoryStep
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x65209E0
    }

    public class SteamVR_IK
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x650C700
        public void Solve(){} // RVA: 0x650E030
        public void .ctor(){} // RVA: 0x650E6D0
    }

    public class SteamVR_Input
    {
        public string defaultInputGameObjectName;

        // ── Methods ──
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x64E59D0
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x64E5B20
        public void add_onPosesUpdated(){} // RVA: 0x64E5C70
        public void remove_onPosesUpdated(){} // RVA: 0x64E5DC0
        public void add_onSkeletonsUpdated(){} // RVA: 0x64E5F10
        public void remove_onSkeletonsUpdated(){} // RVA: 0x64E6060
        public void get_isStartupFrame(){} // RVA: 0x64E61B0
        public void .cctor(){} // RVA: 0x64E62D0
        public void ForcePreinitialize(){} // RVA: 0x64E68F0
        public void FindPreinitializeMethod(){} // RVA: 0x64E6940
        public void Initialize(){} // RVA: 0x64E6B20
        public void PreinitializeFinishActionSets(){} // RVA: 0x64E70B0
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x64E7180
        public void PreinitializeActionDictionaries(){} // RVA: 0x64E7420
        public void Update(){} // RVA: 0x64E7690
        public void LateUpdate(){} // RVA: 0x64E77B0
        public void FixedUpdate(){} // RVA: 0x64E78F0
        public void OnPreCull(){} // RVA: 0x64E7A10
        public void UpdateVisualActions(){} // RVA: 0x64E7B30
        public void UpdatePoseActions(){} // RVA: 0x64E7D30
        public void UpdateSkeletonActions(){} // RVA: 0x64E7EB0
        public void UpdateNonVisualActions(){} // RVA: 0x64E8030
        public void ShowBindingHintsForSets(){} // RVA: 0x64E8250
        public void ShowBindingHints(){} // RVA: 0x64E85B0 | overloaded x2
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x64E8690
        public void GetActionDataFromPath(){} // RVA: 0x283FA0
        public void GetActionSetDataFromPath(){} // RVA: 0x64E8840
        public void GetActionFromPath(){} // RVA: 0x283FA0
        public void GetBaseActionFromPath(){} // RVA: 0x64E88F0
        public void HasActionPath(){} // RVA: 0x64E8D40
        public void HasAction(){} // RVA: 0x64E8F60 | overloaded x2
        public void GetBooleanActionFromPath(){} // RVA: 0x64E9070
        public void GetSingleActionFromPath(){} // RVA: 0x64E90F0
        public void GetVector2ActionFromPath(){} // RVA: 0x64E9170
        public void GetVector3ActionFromPath(){} // RVA: 0x64E91F0
        public void GetVibrationActionFromPath(){} // RVA: 0x64E9270
        public void GetPoseActionFromPath(){} // RVA: 0x64E92F0
        public void GetSkeletonActionFromPath(){} // RVA: 0x64E9370
        public void GetAction(){} // RVA: 0x283FA0 | overloaded x2
        public void GetBaseAction(){} // RVA: 0x64E93F0
        public void CreateFakeAction(){} // RVA: 0x283FA0 | overloaded x2
        public void GetBooleanAction(){} // RVA: 0x64E9950 | overloaded x2
        public void GetSingleAction(){} // RVA: 0x64E9A60 | overloaded x2
        public void GetVector2Action(){} // RVA: 0x64E9B70 | overloaded x2
        public void GetVector3Action(){} // RVA: 0x64E9C80 | overloaded x2
        public void GetPoseAction(){} // RVA: 0x64E9D90 | overloaded x2
        public void GetSkeletonAction(){} // RVA: 0x64E9EA0 | overloaded x2
        public void GetVibrationAction(){} // RVA: 0x64E9FB0 | overloaded x2
        public void GetActionSet(){} // RVA: 0x64EA030 | overloaded x2
        public void HasActionSet(){} // RVA: 0x64EA0C0
        public void GetActionSetFromPath(){} // RVA: 0x64EA160 | overloaded x2
        public void GetState(){} // RVA: 0x64EA340 | overloaded x2
        public void GetStateDown(){} // RVA: 0x64EA630 | overloaded x2
        public void GetStateUp(){} // RVA: 0x64EA920 | overloaded x2
        public void GetFloat(){} // RVA: 0x64EAC10 | overloaded x2
        public void GetSingle(){} // RVA: 0x64EADF0 | overloaded x2
        public void GetVector2(){} // RVA: 0x64EB000 | overloaded x2
        public void GetVector3(){} // RVA: 0x64EB3A0 | overloaded x2
        public void GetActionSets(){} // RVA: 0x64EB440
        public void GetActions(){} // RVA: 0xC960
        public void ShouldMakeCopy(){} // RVA: 0x64EB4A0
        public void GetLocalizedName(){} // RVA: 0x64EB500
        public void CheckOldLocation(){} // RVA: 0x2DD320
        public void IdentifyActionsFile(){} // RVA: 0x64EB650
        public void HasFileInMemoryBeenModified(){} // RVA: 0x64EB9E0
        public void CreateEmptyActionsFile(){} // RVA: 0x64EBBB0
        public void DoesActionsFileExist(){} // RVA: 0x64EC260
        public void InitializeFile(){} // RVA: 0x64EC2C0
        public void GetActionsFileFolder(){} // RVA: 0x64EC6E0
        public void GetActionsFilePath(){} // RVA: 0x64EC7F0
        public void GetActionsFileName(){} // RVA: 0x64ECA90
        public void DeleteManifestAndBindings(){} // RVA: 0x64ECAF0
        public void OpenBindingUI(){} // RVA: 0x64ECF60
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionFile
    {
        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x64ED170
        public void SaveHelperLists(){} // RVA: 0x64ED820
        public void GetShortName(){} // RVA: 0x64EE060
        public void GetCodeFriendlyName(){} // RVA: 0x64EE100
        public void GetFilesToCopy(){} // RVA: 0x64EE2B0
        public void CopyFilesToPath(){} // RVA: 0x64EE630
        public void RemoveAppKey(){} // RVA: 0x64EE900
        public void Open(){} // RVA: 0x64EEA80
        public void Save(){} // RVA: 0x64EEB80
        public void .ctor(){} // RVA: 0x64EED00
    }

    public class SteamVR_Input_ActionFile_Action
    {
        public string[] _requirementValues;
        public string name; // 0x10
        public string type; // 0x18
        public string scope; // 0x20
        public string skeleton; // 0x28
        public string requirement; // 0x30
        public string nameTemplate;

        // ── Methods ──
        public void get_requirementValues(){} // RVA: 0x64EFAD0
        public void GetCopy(){} // RVA: 0x64EFCB0
        public void get_requirementEnum(){} // RVA: 0x64EFEA0
        public void set_requirementEnum(){} // RVA: 0x64EFFE0
        public void get_codeFriendlyName(){} // RVA: 0x64EF3F0
        public void get_shortName(){} // RVA: 0x64F0090
        public void get_path(){} // RVA: 0x64F00A0
        public void CreateNewName(){} // RVA: 0x64F01D0 | overloaded x2
        public void CreateNew(){} // RVA: 0x64F02C0
        public void get_direction(){} // RVA: 0x64F04C0
        public void get_actionSet(){} // RVA: 0x64F0580
        public void SetNewActionSet(){} // RVA: 0x64F0630
        public void ToString(){} // RVA: 0x64F0090
        public void Equals(){} // RVA: 0x64F0830
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionFile_ActionSet
    {
        public string actionSetInstancePrefix;
        public string name; // 0x10

        // ── Methods ──
        public void get_codeFriendlyName(){} // RVA: 0x64EF3F0
        public void get_shortName(){} // RVA: 0x64EF400
        public void SetNewShortName(){} // RVA: 0x64EF500
        public void CreateNewName(){} // RVA: 0x64EF570
        public void GetPathFromName(){} // RVA: 0x64EF5B0
        public void CreateNew(){} // RVA: 0x64EF640
        public void GetCopy(){} // RVA: 0x64EF710
        public void Equals(){} // RVA: 0x64EF820
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x64EF920
    }

    public class SteamVR_Input_ActionFile_ActionSet_Usages
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x64F2230
    }

    public class SteamVR_Input_ActionFile_ActionTypes
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x64F1950
    }

    public class SteamVR_Input_ActionFile_DefaultBinding
    {
        // ── Methods ──
        public void GetCopy(){} // RVA: 0x64EF2F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionFile_LocalizationItem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F0B30 | overloaded x2
    }

    public class SteamVR_Input_ActionSet_Action_Menu
    {
        // ── Methods ──
        public void get_Axis(){} // RVA: 0x64BC2C0
        public void get_Select(){} // RVA: 0x64BC2D0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x64BC2E0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x64BC2F0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x64BC300
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x64BC310
        public void get_Gesture_Activator_Index(){} // RVA: 0x64BC320
        public void get_Gesture_Activator_Grip(){} // RVA: 0x64BC330
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x64BC340
        public void get_Gesture_Grip_Axis(){} // RVA: 0x64BC350
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x64BC360
        public void get_Gesture_Wheel_Left(){} // RVA: 0x64BC370
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x64BC380
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x64BC390
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x64BC3A0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x64BC3B0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x64BC3C0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x64BC3D0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x64BC3E0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x64BC3F0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x64BC400
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x64BC410
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x64BC420
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x64BC430
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x64BC440
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x64BC450
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x64BC460
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x64BC470
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x64BC480
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x64BC490
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x64BC4A0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x64BC4B0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x64BC4C0
        public void get_Reserve_bool(){} // RVA: 0x64BC4D0
        public void get_Reserve_vector1(){} // RVA: 0x64BC4E0
        public void get_Reserve_vector2(){} // RVA: 0x64BC4F0
        public void get_Grab(){} // RVA: 0x64BC500
        public void get_Drop(){} // RVA: 0x64BC510
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionSet_Drone
    {
        // ── Methods ──
        public void get_Left_Joystick(){} // RVA: 0x64BC520
        public void get_Right_Joystick(){} // RVA: 0x64BC530
        public void get_Self_Leveling_Mod(){} // RVA: 0x64BC540
        public void get_Hold_Altitude_Mod(){} // RVA: 0x64BC550
        public void get_Toggle_FPV(){} // RVA: 0x64BC560
        public void get_Flip(){} // RVA: 0x64BC570
        public void get_Take_Picture(){} // RVA: 0x64BC580
        public void get_Cycle_Flight_Preset(){} // RVA: 0x64BC590
        public void get_Toggle_Self_Leveling(){} // RVA: 0x64BC5A0
        public void get_Respawn(){} // RVA: 0x64BC5B0
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x64BC5C0
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x64BC5D0
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x64BC5E0
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x64BC5F0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionSet_Global
    {
        // ── Methods ──
        public void get_Safe_Mode(){} // RVA: 0x64BC600
        public void get_Pose(){} // RVA: 0x64BC610
        public void get_SkeletonLeftHand(){} // RVA: 0x64BC620
        public void get_SkeletonRightHand(){} // RVA: 0x64BC630
        public void get_HeadsetOnHead(){} // RVA: 0x64BC640
        public void get_Menu(){} // RVA: 0x64BC650
        public void get_Quick_Menu(){} // RVA: 0x64BC660
        public void get_Action_Menu(){} // RVA: 0x64BC670
        public void get_Main_Menu(){} // RVA: 0x64BC680
        public void get_Interact(){} // RVA: 0x64BC690
        public void get_Grab(){} // RVA: 0x64BC6A0
        public void get_Move(){} // RVA: 0x64BC6B0
        public void get_Jump(){} // RVA: 0x64BC6C0
        public void get_Rotate(){} // RVA: 0x64BC6D0
        public void get_Mic(){} // RVA: 0x64BC6E0
        public void get_Gesture_Toggle(){} // RVA: 0x64BC6F0
        public void get_Stick_Click(){} // RVA: 0x64BC700
        public void get_Trigger_Axis(){} // RVA: 0x64BC710
        public void get_Grip_Axis(){} // RVA: 0x64BC720
        public void get_Udon_Menu(){} // RVA: 0x64BC730
        public void get_Drop(){} // RVA: 0x64BC740
        public void get_Nameplates(){} // RVA: 0x64BC750
        public void get_HUD(){} // RVA: 0x64BC760
        public void get_Chatbox(){} // RVA: 0x64BC770
        public void get_Face_Mirror(){} // RVA: 0x64BC780
        public void get_Personal_Mirror(){} // RVA: 0x64BC790
        public void get_Personal_Mirror_Lock(){} // RVA: 0x64BC7A0
        public void get_Earmuffs(){} // RVA: 0x64BC7B0
        public void get_Camera(){} // RVA: 0x64BC7C0
        public void get_Stream_Camera(){} // RVA: 0x64BC7D0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x64BC7E0
        public void get_OSC_Debug_Screen(){} // RVA: 0x64BC7F0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x64BC800
        public void get_Start_Move(){} // RVA: 0x64BC810
        public void get_Start_Rotate(){} // RVA: 0x64BC820
        public void get_Continue_Move(){} // RVA: 0x64BC830
        public void get_Continue_Rotate(){} // RVA: 0x64BC840
        public void get_No_Gesture_After_Move(){} // RVA: 0x64BC850
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x64BC860
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x64BC870
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x64BC880
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x64BC890
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x64BC8A0
        public void get_Gesture_Activator_Index(){} // RVA: 0x64BC8B0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x64BC8C0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x64BC8D0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x64BC8E0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x64BC8F0
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x64BC900
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x64BC910
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x64BC920
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x64BC930
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x64BC940
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x64BC950
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x64BC960
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x64BC970
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x64BC980
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x64BC990
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x64BC9A0
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x64BC9B0
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x64BC9C0
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x64BC9D0
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x64BC9E0
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x64BC9F0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x64BCA00
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x64BCA10
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x64BCA20
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x64BCA30
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x64BCA40
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x64BCA50
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x64BCA60
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x64BCA70
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x64BCA80
        public void get_Gesture_Wheel_Right(){} // RVA: 0x64BCA90
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x64BCAA0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x64BCAB0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x64BCAC0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x64BCAD0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x64BCAE0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x64BCAF0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x64BCB00
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x64BCB10
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x64BCB20
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x64BCB30
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x64BCB40
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x64BCB50
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x64BCB60
        public void get_Physbone_Grab_Left(){} // RVA: 0x64BCB70
        public void get_Physbone_Freeze_Left(){} // RVA: 0x64BCB80
        public void get_Physbone_Grab_Right(){} // RVA: 0x64BCB90
        public void get_Physbone_Freeze_Right(){} // RVA: 0x64BCBA0
        public void get_Scroll(){} // RVA: 0x64BCBB0
        public void get_Haptic(){} // RVA: 0x64BCBC0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionSet_Menu
    {
        // ── Methods ──
        public void get_Confirm(){} // RVA: 0x64BCBD0
        public void get_Back(){} // RVA: 0x64BCBE0
        public void get_Tab(){} // RVA: 0x64BCBF0
        public void get_Scroll(){} // RVA: 0x64BCC00
        public void get_Quick_Menu_Close(){} // RVA: 0x64BCC10
        public void get_Drag(){} // RVA: 0x64BCC20
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ActionSet_One_Hand
    {
        // ── Methods ──
        public void get_Interact(){} // RVA: 0x64BCC30
        public void get_Grab(){} // RVA: 0x64BCC40
        public void get_Move_Rotate(){} // RVA: 0x64BCC50
        public void get_Jump(){} // RVA: 0x64BCC60
        public void get_Mic(){} // RVA: 0x64BCC70
        public void get_Gesture_Toggle(){} // RVA: 0x64BCC80
        public void get_Stick_Click(){} // RVA: 0x64BCC90
        public void get_Trigger_Axis(){} // RVA: 0x64BCCA0
        public void get_Grip_Axis(){} // RVA: 0x64BCCB0
        public void get_Udon_Menu(){} // RVA: 0x64BCCC0
        public void get_Drop(){} // RVA: 0x64BCCD0
        public void get_Start_Move_Rotate(){} // RVA: 0x64BCCE0
        public void get_Continue_Move_Rotate(){} // RVA: 0x64BCCF0
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x64BCD00
        public void get_Menu(){} // RVA: 0x64BCD10
        public void get_Nameplates(){} // RVA: 0x64BCD20
        public void get_HUD(){} // RVA: 0x64BCD30
        public void get_Chatbox(){} // RVA: 0x64BCD40
        public void get_Face_Mirror(){} // RVA: 0x64BCD50
        public void get_Personal_Mirror(){} // RVA: 0x64BCD60
        public void get_Personal_Mirror_Lock(){} // RVA: 0x64BCD70
        public void get_Earmuffs(){} // RVA: 0x64BCD80
        public void get_Camera(){} // RVA: 0x64BCD90
        public void get_Stream_Camera(){} // RVA: 0x64BCDA0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x64BCDB0
        public void get_OSC_Debug_Screen(){} // RVA: 0x64BCDC0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x64BCDD0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x64BCDE0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x64BCDF0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x64BCE00
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x64BCE10
        public void get_Gesture_Activator_Index(){} // RVA: 0x64BCE20
        public void get_Gesture_Activator_Grip(){} // RVA: 0x64BCE30
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x64BCE40
        public void get_Gesture_Grip_Axis(){} // RVA: 0x64BCE50
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x64BCE60
        public void get_Gesture_Wheel_Left(){} // RVA: 0x64BCE70
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x64BCE80
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x64BCE90
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x64BCEA0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x64BCEB0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x64BCEC0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x64BCED0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x64BCEE0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x64BCEF0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x64BCF00
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x64BCF10
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x64BCF20
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x64BCF30
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x64BCF40
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x64BCF50
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x64BCF60
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x64BCF70
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x64BCF80
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x64BCF90
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x64BCFA0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x64BCFB0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x64BCFC0
        public void get_Reserve_bool(){} // RVA: 0x64BCFD0
        public void get_Reserve_vector1(){} // RVA: 0x64BCFE0
        public void get_Reserve_vector2(){} // RVA: 0x64BCFF0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_BindingFile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F2740
    }

    public class SteamVR_Input_BindingFile_ActionList
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F2800
    }

    public class SteamVR_Input_BindingFile_Chord
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x64F2B20
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x64F2E50
    }

    public class SteamVR_Input_BindingFile_Haptic
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x64F3060
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_BindingFile_Pose
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x64F2F10
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_BindingFile_Skeleton
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x64F31B0
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_BindingFile_Source
    {
        // ── Methods ──
        public void GetOutput(){} // RVA: 0x64F3300
        public void Equals(){} // RVA: 0x64F3680
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x64F3870
    }

    public class SteamVR_Input_BindingFile_Source_Input
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x64F39F0
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x64F3CE0
    }

    public class SteamVR_Input_BindingFile_Source_Input_StringDictionary
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x64F3D20
        public void GetHashCode(){} // RVA: 0x5C63910
        public void .ctor(){} // RVA: 0x64F3E60
    }

    public class SteamVR_Input_Generator_Names
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ManifestFile
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ManifestFile_Application
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F0EF0
    }

    public class SteamVR_Input_ManifestFile_ApplicationString
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding_ControllerTypes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x64F1310
    }

    public class SteamVR_Input_Source
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x64F3EA0
        public void GetSource(){} // RVA: 0x64F3F50
        public void GetAllSources(){} // RVA: 0x64F40E0
        public void GetPath(){} // RVA: 0x64F4380
        public void Initialize(){} // RVA: 0x64F44C0
        public void .cctor(){} // RVA: 0x64F4D50
    }

    public class SteamVR_Input_Sources_Comparer
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x3471600
        public void GetHashCode(){} // RVA: 0x3B45020
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F0FB0
    }

    public class SteamVR_LoadLevel
    {
        public Valve.VR.SteamVR_LoadLevel _active;
        public string levelName; // 0x20
        public string internalProcessPath; // 0x28

        // ── Methods ──
        public void get_loading(){} // RVA: 0x650E720
        public void get_progress(){} // RVA: 0x650E810
        public void get_progressTexture(){} // RVA: 0x650E970
        public void OnEnable(){} // RVA: 0x650EA80
        public void Trigger(){} // RVA: 0x650EAA0
        public void Begin(){} // RVA: 0x650EC40
        public void OnGUI(){} // RVA: 0x650EDB0
        public void Update(){} // RVA: 0x650F540
        public void LoadLevel(){} // RVA: 0x650F7A0
        public void GetOverlayHandle(){} // RVA: 0x650F840
        public void .ctor(){} // RVA: 0x650FE80
    }

    public class SteamVR_Menu
    {
        public UnityEngine.Texture _texture; // 0x20
        public UnityEngine.Texture background; // 0x28

        // ── Methods ──
        public void get_texture(){} // RVA: 0x65114E0
        public void get_scale(){} // RVA: 0x3060C0
        public void set_scale(){} // RVA: 0x3060D0
        public void Awake(){} // RVA: 0x6511630
        public void OnGUI(){} // RVA: 0x6511980
        public void ShowMenu(){} // RVA: 0x65130D0
        public void HideMenu(){} // RVA: 0x65137B0
        public void Update(){} // RVA: 0x6513A70
        public void SetScale(){} // RVA: 0x6513D10
        public void SaveCursorState(){} // RVA: 0x6513EA0
        public void RestoreCursorState(){} // RVA: 0x6513F40
        public void .ctor(){} // RVA: 0x6513FF0
    }

    public class SteamVR_Overlay
    {
        public UnityEngine.Texture texture; // 0x20
        public float scale; // 0x28

        // ── Methods ──
        public void get_instance(){} // RVA: 0x6514050
        public void set_instance(){} // RVA: 0x6514090
        public void get_key(){} // RVA: 0x6514130
        public void OnEnable(){} // RVA: 0x6514240
        public void OnDisable(){} // RVA: 0x6514420
        public void UpdateOverlay(){} // RVA: 0x6514480
        public void PollNextEvent(){} // RVA: 0x6514B40
        public void ComputeIntersection(){} // RVA: 0x6514C50
        public void .ctor(){} // RVA: 0x6514E30
    }

    public class SteamVR_PlayArea
    {
        // ── Methods ──
        public void GetBounds(){} // RVA: 0x6514EB0
        public void BuildMesh(){} // RVA: 0x65151C0
        public void OnDrawGizmos(){} // RVA: 0x6515F90
        public void OnDrawGizmosSelected(){} // RVA: 0x6515FA0
        public void DrawWireframe(){} // RVA: 0x6515FB0
        public void OnEnable(){} // RVA: 0x6516580
        public void UpdateBounds(){} // RVA: 0x6516790
        public void .ctor(){} // RVA: 0x6516830
    }

    public class SteamVR_Render
    {
        public Valve.VR.SteamVR_ExternalCamera externalCamera; // 0x20
        public string externalCameraConfigPath; // 0x28
        public 0x6595C130 <eye>k__BackingField;

        // ── Methods ──
        public void get_eye(){} // RVA: 0x6516AF0
        public void set_eye(){} // RVA: 0x6516B30
        public void get_instance(){} // RVA: 0x6516B70
        public void OnApplicationQuit(){} // RVA: 0x6516BD0
        public void Add(){} // RVA: 0x6516C40
        public void Remove(){} // RVA: 0x6500070
        public void Top(){} // RVA: 0x6516CF0
        public void AddInternal(){} // RVA: 0x6516DB0
        public void RemoveInternal(){} // RVA: 0x6517040
        public void TopInternal(){} // RVA: 0x65173D0
        public void get_pauseRendering(){} // RVA: 0x6517410
        public void set_pauseRendering(){} // RVA: 0x6517450
        public void RenderLoop(){} // RVA: 0x65174E0
        public void CheckExternalCamera(){} // RVA: 0x6517580
        public void RenderExternalCamera(){} // RVA: 0x6517FE0
        public void OnInputFocus(){} // RVA: 0x6518230
        public void GetScreenshotFilename(){} // RVA: 0x6518350
        public void OnRequestScreenshot(){} // RVA: 0x65184C0
        public void OnEnable(){} // RVA: 0x65189A0
        public void OnSteamVRInitialized(){} // RVA: 0x6518F90
        public void OnDisable(){} // RVA: 0x6518FF0
        public void UpdatePoses(){} // RVA: 0x6519390
        public void OnBeforeRender(){} // RVA: 0x65194C0
        public void Update(){} // RVA: 0x6519590
        public void .ctor(){} // RVA: 0x6519AF0
    }

    public class SteamVR_RenderModel
    {
        public 0x659274F0 index; // 0x20
        public 0x65925E40 inputSource; // 0x24

        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0x35A740
        public void set_renderModelName(){} // RVA: 0x305200
        public void get_initializedAttachPoints(){} // RVA: 0x394D30
        public void set_initializedAttachPoints(){} // RVA: 0x394D40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x651A220
        public void SetMeshRendererState(){} // RVA: 0x651A2D0
        public void OnHideRenderModels(){} // RVA: 0x651A460
        public void OnDeviceConnected(){} // RVA: 0x651A470
        public void UpdateModel(){} // RVA: 0x651A490
        public void SetModelAsync(){} // RVA: 0x651A7C0
        public void SetModel(){} // RVA: 0x651A8C0
        public void LoadRenderModel(){} // RVA: 0x651AED0
        public void ConvertByteColorGammaExp(){} // RVA: 0x651C510
        public void FreeRenderModel(){} // RVA: 0x651C570
        public void FindTransformByName(){} // RVA: 0x651C5C0
        public void GetComponentTransform(){} // RVA: 0x651C7F0
        public void StripMesh(){} // RVA: 0x651C8F0
        public void LoadComponents(){} // RVA: 0x651CAE0
        public void .ctor(){} // RVA: 0x651D7C0
        public void OnEnable(){} // RVA: 0x651DBE0
        public void OnDisable(){} // RVA: 0x651DD50
        public void Update(){} // RVA: 0x651DDC0
        public void UpdateComponents(){} // RVA: 0x651DE10
        public void SetDeviceIndex(){} // RVA: 0x651E870
        public void SetInputSource(){} // RVA: 0x16E1F00
        public void Sleep(){} // RVA: 0x651E950
        public void MarshalRenderModel(){} // RVA: 0x651E960
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x651EB90
        public void .cctor(){} // RVA: 0x651EDC0
    }

    public class SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24FA0
        public void Add(){} // RVA: 0x283FA0
        public void StepForward(){} // RVA: 0x24A50
        public void GetAtIndex(){} // RVA: 0x283FA0
        public void GetLast(){} // RVA: 0x283FA0
        public void GetLastIndex(){} // RVA: 0xD840
        public void Clear(){} // RVA: 0x24A50
    }

    public class SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4090820
        public void Add(){} // RVA: 0x40908C0
        public void StepForward(){} // RVA: 0x4090900
        public void GetAtIndex(){} // RVA: 0x40909B0
        public void GetLast(){} // RVA: 0x30B0C0
        public void GetLastIndex(){} // RVA: 0x40909F0
        public void Clear(){} // RVA: 0x4090A20
    }

    public class SteamVR_Settings
    {
        public Valve.VR.SteamVR_Settings _instance;
        public bool pauseGameWhenDashboardVisible; // 0x18

        // ── Methods ──
        public void get_instance(){} // RVA: 0x65209F0
        public void get_trackingSpace(){} // RVA: 0x197C3B0
        public void set_trackingSpace(){} // RVA: 0x6520A40
        public void IsInputUpdateMode(){} // RVA: 0x6520AC0
        public void IsPoseUpdateMode(){} // RVA: 0x6520AD0
        public void VerifyScriptableObject(){} // RVA: 0x6520AE0
        public void LoadInstance(){} // RVA: 0x6520AF0
        public void Save(){} // RVA: 0x2DD310
        public void SetDefaultsIfNeeded(){} // RVA: 0x6520DB0
        public void FindDefaultPreviewHand(){} // RVA: 0x519240
        public void .ctor(){} // RVA: 0x6520FC0
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists
    {
        public 0x65925F48[] _enumList; // 0x10
        public string[] _stringList; // 0x18

        // ── Methods ──
        public void get_enumList(){} // RVA: 0x64F53F0
        public void get_stringList(){} // RVA: 0x64F5600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Skeleton_FingerIndexes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x64BAD80
    }

    public class SteamVR_Skeleton_FingerSplayIndexes
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x64BAFF0
    }

    public class SteamVR_Skeleton_HandMask
    {
        // ── Methods ──
        public void SetFinger(){} // RVA: 0x64F9070
        public void GetFinger(){} // RVA: 0x64F90B0
        public void .ctor(){} // RVA: 0x64F90E0
        public void Reset(){} // RVA: 0x64F92A0
        public void Apply(){} // RVA: 0x64F9360
        public void .cctor(){} // RVA: 0x64F9420
    }

    public class SteamVR_Skeleton_JointIndexes
    {
        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x64BACC0
        public void GetBoneForFingerTip(){} // RVA: 0x64BAD40
    }

    public class SteamVR_Skeleton_Pose
    {
        // ── Methods ──
        public void GetHand(){} // RVA: 0x64F5150 | overloaded x2
        public void .ctor(){} // RVA: 0x64F5170
    }

    public class SteamVR_Skeleton_PoseSnapshot
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64F8DD0
        public void CopyFrom(){} // RVA: 0x64F8F70
    }

    public class SteamVR_Skeleton_Pose_Hand
    {
        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x64F52A0
        public void .ctor(){} // RVA: 0x64F5370
        public void GetMovementTypeForBone(){} // RVA: 0x64F5380
    }

    public class SteamVR_Skeleton_Poser
    {
        public bool poseEditorExpanded; // 0x20

        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x64F5990
        public void Awake(){} // RVA: 0x64F59B0
        public void SetBlendingBehaviourValue(){} // RVA: 0x64F5F00
        public void GetBlendingBehaviourValue(){} // RVA: 0x64F5FD0
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x64F6000
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x64F6030
        public void GetBlendingBehaviour(){} // RVA: 0x64F6060
        public void FindBlendingBehaviour(){} // RVA: 0x64F6070
        public void GetPoseByIndex(){} // RVA: 0x64F6280
        public void GetHandSnapshot(){} // RVA: 0x64F6310
        public void GetBlendedPose(){} // RVA: 0x64F6370 | overloaded x2
        public void UpdatePose(){} // RVA: 0x64F63C0
        public void ApplyBlenderBehaviours(){} // RVA: 0x64F66A0
        public void LateUpdate(){} // RVA: 0x64F6960
        public void BlendVectors(){} // RVA: 0x64F6970
        public void BlendQuaternions(){} // RVA: 0x64F6A70
        public void GetTargetHandPosition(){} // RVA: 0x64F6D60
        public void GetTargetHandRotation(){} // RVA: 0x64F7360
        public void .ctor(){} // RVA: 0x64F7A20
    }

    public class SteamVR_Skybox
    {
        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x6521200
        public void GetTextureByIndex(){} // RVA: 0x6521290
        public void SetOverride(){} // RVA: 0x65212F0
        public void ClearOverride(){} // RVA: 0x6521800
        public void OnEnable(){} // RVA: 0x6521850
        public void OnDisable(){} // RVA: 0x6521800
        public void .ctor(){} // RVA: 0x6521890
    }

    public class SteamVR_SphericalProjection
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x65218F0
        public void OnRenderImage(){} // RVA: 0x6521EE0
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_TrackedCamera
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x6521F70
        public void Undistorted(){} // RVA: 0x6522110
        public void Source(){} // RVA: 0x65222C0
        public void Stream(){} // RVA: 0x6522600
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_TrackedObject
    {
        public 0x659274F0 index; // 0x20

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x303450
        public void set_isValid(){} // RVA: 0x303460
        public void OnNewPoses(){} // RVA: 0x65233F0
        public void .ctor(){} // RVA: 0x65239D0
        public void Awake(){} // RVA: 0x6523AF0
        public void OnEnable(){} // RVA: 0x6523AF0
        public void OnDisable(){} // RVA: 0x6523C80
        public void SetDeviceIndex(){} // RVA: 0x6523CC0
    }

    public class SteamVR_TrackingReferenceManager
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x6523E80
        public void OnDisable(){} // RVA: 0x6523F60
        public void OnNewPoses(){} // RVA: 0x6524070
        public void .ctor(){} // RVA: 0x6524400
    }

}