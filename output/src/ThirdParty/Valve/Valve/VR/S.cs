// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 78
// Methods: 1548

namespace ThirdParty.Valve.Valve.VR
{
    public class SpatialAnchorPose_t : ValueType
    {
    }

    public class SteamVR : Object
    {
        public object active;
        public object enabled;
        public object instance;
        public object usingNativeSupport;
        public object settings;
        public object hmd;
        public object compositor;
        public object overlay;
        public object initializing;
        public object calibrating;
        public object outOfRange;
        public object sceneWidth;
        public object sceneHeight;
        public object aspect;
        public object fieldOfView;
        public object tanHalfFov;
        public object textureBounds;
        public object eyes;
        public object hmd_TrackingSystemName;
        public object hmd_ActualTrackingSystemName;
        public object hmd_ModelNumber;
        public object hmd_SerialNumber;
        public object hmd_Type;
        public object hmd_SecondsFromVsyncToPhotons;
        public object hmd_DisplayFrequency;

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFD540B0060
        public void get_enabled(){} // RVA: 0x7FFD540B00C0
        public void set_enabled(){} // RVA: 0x7FFD540B02F0
        public void get_instance(){} // RVA: 0x7FFD540B0390
        public void Initialize(){} // RVA: 0x7FFD540B04F0
        public void get_usingNativeSupport(){} // RVA: 0x7FFD540B06B0
        public void get_settings(){} // RVA: 0x7FFD540B0700
        public void set_settings(){} // RVA: 0x7FFD540B0760
        public void ReportGeneralErrors(){} // RVA: 0x7FFD540B0820
        public void CreateInstance(){} // RVA: 0x7FFD540B08B0
        public void ReportError(){} // RVA: 0x7FFD540B0F50
        public void get_hmd(){} // RVA: 0x7FFD4E35C380
        public void set_hmd(){} // RVA: 0x7FFD4E342E30
        public void get_compositor(){} // RVA: 0x7FFD4E3447C0
        public void set_compositor(){} // RVA: 0x7FFD4E3A7E80
        public void get_overlay(){} // RVA: 0x7FFD4E36F0C0
        public void set_overlay(){} // RVA: 0x7FFD4E36F0D0
        public void get_initializing(){} // RVA: 0x7FFD540B1110
        public void set_initializing(){} // RVA: 0x7FFD540B1170
        public void get_calibrating(){} // RVA: 0x7FFD540B11D0
        public void set_calibrating(){} // RVA: 0x7FFD540B1230
        public void get_outOfRange(){} // RVA: 0x7FFD540B1290
        public void set_outOfRange(){} // RVA: 0x7FFD540B12F0
        public void get_sceneWidth(){} // RVA: 0x7FFD4E420210
        public void set_sceneWidth(){} // RVA: 0x7FFD4E420220
        public void get_sceneHeight(){} // RVA: 0x7FFD4E80AB80
        public void set_sceneHeight(){} // RVA: 0x7FFD4E80A9D0
        public void get_aspect(){} // RVA: 0x7FFD4F060670
        public void set_aspect(){} // RVA: 0x7FFD4FB594E0
        public void get_fieldOfView(){} // RVA: 0x7FFD4E40B630
        public void set_fieldOfView(){} // RVA: 0x7FFD4E40B640
        public void get_tanHalfFov(){} // RVA: 0x7FFD4F3C0C70
        public void set_tanHalfFov(){} // RVA: 0x7FFD4E9433F0
        public void get_textureBounds(){} // RVA: 0x7FFD4E3BE740
        public void set_textureBounds(){} // RVA: 0x7FFD4E369200
        public void get_eyes(){} // RVA: 0x7FFD4E3BC730
        public void set_eyes(){} // RVA: 0x7FFD4E3BC740
        public void get_hmd_TrackingSystemName(){} // RVA: 0x7FFD540B1350
        public void get_hmd_ActualTrackingSystemName(){} // RVA: 0x7FFD540B1360
        public void get_hmd_ModelNumber(){} // RVA: 0x7FFD540B1370
        public void get_hmd_SerialNumber(){} // RVA: 0x7FFD540B1380
        public void get_hmd_Type(){} // RVA: 0x7FFD540B1390
        public void get_hmd_SecondsFromVsyncToPhotons(){} // RVA: 0x7FFD540B13A0
        public void get_hmd_DisplayFrequency(){} // RVA: 0x7FFD540B13F0
        public void GetHeadsetActivityLevel(){} // RVA: 0x7FFD540B1440
        public void GetTrackedDeviceString(){} // RVA: 0x7FFD540B1490
        public void GetStringProperty(){} // RVA: 0x7FFD540B15D0
        public void GetFloatProperty(){} // RVA: 0x7FFD540B1770
        public void InitializeTemporarySession(){} // RVA: 0x7FFD540B17C0
        public void ExitTemporarySession(){} // RVA: 0x7FFD540B1880
        public void GenerateAppKey(){} // RVA: 0x7FFD540B1920
        public void GenerateCleanProductName(){} // RVA: 0x7FFD540B1B40
        public void GetManifestFile(){} // RVA: 0x7FFD540B1CD0
        public void IdentifyEditorApplication(){} // RVA: 0x7FFD540B28B0
        public void OnInitializing(){} // RVA: 0x7FFD540B2D30
        public void OnCalibrating(){} // RVA: 0x7FFD540B2DD0
        public void OnOutOfRange(){} // RVA: 0x7FFD540B2E70
        public void OnDeviceConnected(){} // RVA: 0x7FFD540B2F10
        public void OnNewPoses(){} // RVA: 0x7FFD540B2FA0
        public void .ctor(){} // RVA: 0x7FFD540B34A0
        public void Finalize(){} // RVA: 0x7FFD540B42F0
        public void Dispose(){} // RVA: 0x7FFD540B43A0 | overloaded x2
        public void SafeDispose(){} // RVA: 0x7FFD540B47C0
        public void .cctor(){} // RVA: 0x7FFD540B48B0
    }

    public class SteamVREnumEqualityComparer`1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFD4E2ADC40
        public void GetHashCode(){} // RVA: 0x7FFD4E2ADC40
    }

    public class SteamVR_Action : Object
    {
        public object fullPath;
        public object handle;
        public object actionSet;
        public object direction;
        public object setActive;
        public object active;
        public object activeBinding;
        public object lastActive;
        public object lastActiveBinding;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void CreateUninitialized(){} // RVA: 0x7FFD4E096500 | overloaded x4
        public void GetCopy(){} // RVA: 0x7FFD4E2ADC40
        public void TryNeedsInitData(){} // RVA: 0x7FFD4E078E90
        public void InitializeCopy(){} // RVA: 0x7FFD4E099B30
        public void get_fullPath(){} // RVA: 0x7FFD4E078E90
        public void get_handle(){} // RVA: 0x7FFD4E078E90
        public void get_actionSet(){} // RVA: 0x7FFD4E078E90
        public void get_direction(){} // RVA: 0x7FFD4E079960
        public void get_setActive(){} // RVA: 0x7FFD5405A240
        public void get_active(){} // RVA: 0x7FFD4E079D00
        public void get_activeBinding(){} // RVA: 0x7FFD4E079D00
        public void get_lastActive(){} // RVA: 0x7FFD4E079D00
        public void get_lastActiveBinding(){} // RVA: 0x7FFD4E079D00
        public void PreInitialize(){} // RVA: 0x7FFD4E090A40
        public void Initialize(){} // RVA: 0x7FFD4E0910F0
        public void GetTimeLastChanged(){} // RVA: 0x7FFD4E08DC30
        public void GetSourceMap(){} // RVA: 0x7FFD4E078E90
        public void GetActive(){} // RVA: 0x7FFD4E07A310
        public void GetSetActive(){} // RVA: 0x7FFD5405A2A0
        public void GetActiveBinding(){} // RVA: 0x7FFD4E07A310
        public void GetLastActive(){} // RVA: 0x7FFD4E07A310
        public void GetLastActiveBinding(){} // RVA: 0x7FFD4E07A310
        public void GetPath(){} // RVA: 0x7FFD4E35C380
        public void IsUpdating(){} // RVA: 0x7FFD4E07A310
        public void GetHashCode(){} // RVA: 0x7FFD5405A320
        public void Equals(){} // RVA: 0x7FFD5405A3A0 | overloaded x2
        public void op_Inequality(){} // RVA: 0x7FFD5405A4D0
        public void op_Equality(){} // RVA: 0x7FFD5405A600
        public void FindExistingActionForPartialPath(){} // RVA: 0x7FFD5405A700
        public void GetShortName(){} // RVA: 0x7FFD5405A820
        public void ShowOrigins(){} // RVA: 0x7FFD5405A8C0
        public void HideOrigins(){} // RVA: 0x7FFD5405A990
        public void .cctor(){} // RVA: 0x7FFD5405A9E0
    }

    public class SteamVR_ActionSet : Object
    {
        public object allActions;
        public object nonVisualInActions;
        public object visualActions;
        public object poseActions;
        public object skeletonActions;
        public object outActionArray;
        public object fullPath;
        public object usage;
        public object handle;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void get_allActions(){} // RVA: 0x7FFD5405B620
        public void get_nonVisualInActions(){} // RVA: 0x7FFD5405B660
        public void get_visualActions(){} // RVA: 0x7FFD5405B6A0
        public void get_poseActions(){} // RVA: 0x7FFD5405B6E0
        public void get_skeletonActions(){} // RVA: 0x7FFD5405B720
        public void get_outActionArray(){} // RVA: 0x7FFD5405B760
        public void get_fullPath(){} // RVA: 0x7FFD5405B7A0
        public void get_usage(){} // RVA: 0x7FFD5405B7E0
        public void get_handle(){} // RVA: 0x7FFD5405B820
        public void Create(){} // RVA: 0x7FFD4E2ADC40
        public void CreateFromName(){} // RVA: 0x7FFD4E2ADC40
        public void PreInitialize(){} // RVA: 0x7FFD5405B860
        public void FinishPreInitialize(){} // RVA: 0x7FFD5405B9E0
        public void Initialize(){} // RVA: 0x7FFD5405BA00
        public void GetPath(){} // RVA: 0x7FFD4E35C380
        public void IsActive(){} // RVA: 0x7FFD5405BAE0
        public void GetTimeLastChanged(){} // RVA: 0x7FFD5405BB40
        public void Activate(){} // RVA: 0x7FFD5405BB90
        public void Deactivate(){} // RVA: 0x7FFD5405BD40
        public void GetShortName(){} // RVA: 0x7FFD5405BE50
        public void ShowBindingHints(){} // RVA: 0x7FFD5405BEE0
        public void ReadRawSetActive(){} // RVA: 0x7FFD5405C020
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFD5405C060
        public void ReadRawSetPriority(){} // RVA: 0x7FFD5405C0A0
        public void GetActionSetData(){} // RVA: 0x7FFD4E3447C0
        public void GetCopy(){} // RVA: 0x7FFD4E2ADC40
        public void Equals(){} // RVA: 0x7FFD5405C0E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD5405A320
        public void op_Inequality(){} // RVA: 0x7FFD5405C1F0
        public void op_Equality(){} // RVA: 0x7FFD5405C2B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5405C360
    }

    public class SteamVR_ActionSet_Manager : Object
    {
        public object rawActiveActionSetArray;

        // ── Methods ──
        public void get_rawActiveActionSetArray(){} // RVA: 0x7FFD5405D710
        public void Initialize(){} // RVA: 0x7FFD5405D790
        public void DisableAllActionSets(){} // RVA: 0x7FFD5405D940
        public void UpdateActionStates(){} // RVA: 0x7FFD5405DA80
        public void SetChanged(){} // RVA: 0x7FFD5405DDA0
        public void GetNewArraySize(){} // RVA: 0x7FFD5405DDE0
        public void UpdateActionSetsArray(){} // RVA: 0x7FFD5405DF20
        public void GetSetFromHandle(){} // RVA: 0x7FFD5405E430
        public void UpdateDebugText(){} // RVA: 0x7FFD5405E550
    }

    public class SteamVR_Action_Boolean : SteamVR_Action_In`2
    {
        public object state;
        public object stateDown;
        public object stateUp;
        public object lastState;
        public object lastStateDown;
        public object lastStateUp;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFD5405E9F0
        public void remove_onChange(){} // RVA: 0x7FFD5405EA70
        public void add_onUpdate(){} // RVA: 0x7FFD5405EAF0
        public void remove_onUpdate(){} // RVA: 0x7FFD5405EB70
        public void add_onState(){} // RVA: 0x7FFD5405EBF0
        public void remove_onState(){} // RVA: 0x7FFD5405EC70
        public void add_onStateDown(){} // RVA: 0x7FFD5405ECF0
        public void remove_onStateDown(){} // RVA: 0x7FFD5405ED70
        public void add_onStateUp(){} // RVA: 0x7FFD5405EDF0
        public void remove_onStateUp(){} // RVA: 0x7FFD5405EE70
        public void add_onActiveChange(){} // RVA: 0x7FFD5405EEF0
        public void remove_onActiveChange(){} // RVA: 0x7FFD5405EF70
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD5405EFF0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD5405F070
        public void get_state(){} // RVA: 0x7FFD5405F0F0
        public void get_stateDown(){} // RVA: 0x7FFD5405F180
        public void get_stateUp(){} // RVA: 0x7FFD5405F210
        public void get_lastState(){} // RVA: 0x7FFD5405F2A0
        public void get_lastStateDown(){} // RVA: 0x7FFD5405F300
        public void get_lastStateUp(){} // RVA: 0x7FFD5405F380
        public void .ctor(){} // RVA: 0x7FFD5405F400
        public void GetStateDown(){} // RVA: 0x7FFD5405F440
        public void GetStateUp(){} // RVA: 0x7FFD5405F4E0
        public void GetState(){} // RVA: 0x7FFD5405F580
        public void GetLastStateDown(){} // RVA: 0x7FFD5405F620
        public void GetLastStateUp(){} // RVA: 0x7FFD5405F6B0
        public void GetLastState(){} // RVA: 0x7FFD5405F740
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD5405F7B0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD5405F830
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFD5405F8B0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFD5405F930
        public void AddOnChangeListener(){} // RVA: 0x7FFD5405F9B0
        public void RemoveOnChangeListener(){} // RVA: 0x7FFD5405FA30
        public void AddOnUpdateListener(){} // RVA: 0x7FFD5405FAB0
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFD5405FB30
        public void AddOnStateDownListener(){} // RVA: 0x7FFD5405FBB0
        public void RemoveOnStateDownListener(){} // RVA: 0x7FFD5405FC30
        public void AddOnStateUpListener(){} // RVA: 0x7FFD5405FCB0
        public void RemoveOnStateUpListener(){} // RVA: 0x7FFD5405FD30
        public void RemoveAllListeners(){} // RVA: 0x7FFD5405FDB0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5405FE20
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x7FFD51DC2240
        public void OnAccessSource(){} // RVA: 0x7FFD51DC22F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7FFD51DC2380
        public void UpdateValues(){} // RVA: 0x7FFD51DC2530
        public void .ctor(){} // RVA: 0x7FFD51DC2610
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        public object changed;
        public object lastChanged;
        public object changedTime;
        public object updateTime;
        public object activeOrigin;
        public object lastActiveOrigin;
        public object activeDevice;
        public object trackedDeviceIndex;
        public object renderModelComponentName;
        public object localizedOriginName;

        // ── Methods ──
        public void get_changed(){} // RVA: 0x7FFD51DC26F0
        public void get_lastChanged(){} // RVA: 0x7FFD51DC26F0
        public void get_changedTime(){} // RVA: 0x7FFD51DC2740
        public void get_updateTime(){} // RVA: 0x7FFD51DC2780
        public void get_activeOrigin(){} // RVA: 0x7FFD51DC27C0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFD51DC2810
        public void get_activeDevice(){} // RVA: 0x7FFD51DC2860
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFD51DC28F0
        public void get_renderModelComponentName(){} // RVA: 0x7FFD51DC2940
        public void get_localizedOriginName(){} // RVA: 0x7FFD51DC2990
        public void UpdateValues(){} // RVA: 0x7FFD51DC29E0
        public void GetRenderModelComponentName(){} // RVA: 0x7FFD51DC2AD0
        public void GetActiveDevice(){} // RVA: 0x7FFD51DC2B20
        public void GetDeviceIndex(){} // RVA: 0x7FFD51DC2BB0
        public void GetChanged(){} // RVA: 0x7FFD51DC2C00
        public void GetTimeLastChanged(){} // RVA: 0x7FFD51DC2C50
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFD51DC2C90
        public void GetLocalizedOrigin(){} // RVA: 0x7FFD51DC2CE0
        public void IsUpdating(){} // RVA: 0x7FFD51DC2D20
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7FFD51DC2DE0
        public void GetControllerType(){} // RVA: 0x7FFD51DC2E10
        public void .ctor(){} // RVA: 0x7FFD51DC2EB0
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFD54062720
        public void remove_onActiveChange(){} // RVA: 0x7FFD540627A0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD54062820
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD54062960
        public void add_onChange(){} // RVA: 0x7FFD540629E0
        public void remove_onChange(){} // RVA: 0x7FFD54062A60
        public void add_onUpdate(){} // RVA: 0x7FFD54062AE0
        public void remove_onUpdate(){} // RVA: 0x7FFD54062B60
        public void add_onTrackingChanged(){} // RVA: 0x7FFD54062BE0
        public void remove_onTrackingChanged(){} // RVA: 0x7FFD54062C60
        public void add_onValidPoseChanged(){} // RVA: 0x7FFD54062CE0
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFD54062D60
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFD54062DE0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFD54062E60
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7FFD54062EE0
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7FFD54062F60
        public void AddOnTrackingChanged(){} // RVA: 0x7FFD54062FE0
        public void RemoveOnTrackingChanged(){} // RVA: 0x7FFD54063060
        public void AddOnValidPoseChanged(){} // RVA: 0x7FFD540630E0
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7FFD54063160
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD540631E0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD54063260
        public void AddOnChangeListener(){} // RVA: 0x7FFD540632E0
        public void RemoveOnChangeListener(){} // RVA: 0x7FFD54063360
        public void AddOnUpdateListener(){} // RVA: 0x7FFD540633E0
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFD54063460
        public void RemoveAllListeners(){} // RVA: 0x7FFD540634E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54063560
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7FFD540635A0
        public void .ctor(){} // RVA: 0x7FFD540637B0
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        public object localPosition;
        public object localRotation;
        public object trackingState;
        public object velocity;
        public object angularVelocity;
        public object poseIsValid;
        public object deviceIsConnected;
        public object lastLocalPosition;
        public object lastLocalRotation;
        public object lastTrackingState;
        public object lastVelocity;
        public object lastAngularVelocity;
        public object lastPoseIsValid;
        public object lastDeviceIsConnected;

        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x7FFD4E091DD0
        public void get_localPosition(){} // RVA: 0x7FFD4E0788A0
        public void get_localRotation(){} // RVA: 0x7FFD4E0788A0
        public void get_trackingState(){} // RVA: 0x7FFD4E079960
        public void get_velocity(){} // RVA: 0x7FFD4E0788A0
        public void get_angularVelocity(){} // RVA: 0x7FFD4E0788A0
        public void get_poseIsValid(){} // RVA: 0x7FFD4E079D00
        public void get_deviceIsConnected(){} // RVA: 0x7FFD4E079D00
        public void get_lastLocalPosition(){} // RVA: 0x7FFD4E0788A0
        public void get_lastLocalRotation(){} // RVA: 0x7FFD4E0788A0
        public void get_lastTrackingState(){} // RVA: 0x7FFD4E079960
        public void get_lastVelocity(){} // RVA: 0x7FFD4E0788A0
        public void get_lastAngularVelocity(){} // RVA: 0x7FFD4E0788A0
        public void get_lastPoseIsValid(){} // RVA: 0x7FFD4E079D00
        public void get_lastDeviceIsConnected(){} // RVA: 0x7FFD4E079D00
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void UpdateValues(){} // RVA: 0x7FFD4E091060
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFD4E2ADC40
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFD4E2ADC40
        public void UpdateTransform(){} // RVA: 0x7FFD4E092BC0
        public void GetLocalPosition(){} // RVA: 0x7FFD4E079BF0
        public void GetLocalRotation(){} // RVA: 0x7FFD4E079BF0
        public void GetVelocity(){} // RVA: 0x7FFD4E079BF0
        public void GetAngularVelocity(){} // RVA: 0x7FFD4E079BF0
        public void GetDeviceIsConnected(){} // RVA: 0x7FFD4E07A310
        public void GetPoseIsValid(){} // RVA: 0x7FFD4E07A310
        public void GetTrackingResult(){} // RVA: 0x7FFD4E0800D0
        public void GetLastLocalPosition(){} // RVA: 0x7FFD4E079BF0
        public void GetLastLocalRotation(){} // RVA: 0x7FFD4E079BF0
        public void GetLastVelocity(){} // RVA: 0x7FFD4E079BF0
        public void GetLastAngularVelocity(){} // RVA: 0x7FFD4E079BF0
        public void GetLastDeviceIsConnected(){} // RVA: 0x7FFD4E07A310
        public void GetLastPoseIsValid(){} // RVA: 0x7FFD4E07A310
        public void GetLastTrackingResult(){} // RVA: 0x7FFD4E0800D0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7FFD4E090ED0
        public void UpdateValues(){} // RVA: 0x7FFD4E091060
        public void .ctor(){} // RVA: 0x7FFD4E090980
    }

    public class SteamVR_Action_Single : SteamVR_Action_In`2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFD54066C10
        public void remove_onChange(){} // RVA: 0x7FFD54066C90
        public void add_onUpdate(){} // RVA: 0x7FFD54066D10
        public void remove_onUpdate(){} // RVA: 0x7FFD54066D90
        public void add_onAxis(){} // RVA: 0x7FFD54066E10
        public void remove_onAxis(){} // RVA: 0x7FFD54066E90
        public void add_onActiveChange(){} // RVA: 0x7FFD54066F10
        public void remove_onActiveChange(){} // RVA: 0x7FFD54066F90
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD54067010
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD54067090
        public void get_axis(){} // RVA: 0x7FFD54067110
        public void get_lastAxis(){} // RVA: 0x7FFD540671A0
        public void get_delta(){} // RVA: 0x7FFD54067230
        public void get_lastDelta(){} // RVA: 0x7FFD540672C0
        public void .ctor(){} // RVA: 0x7FFD54067350
        public void GetAxis(){} // RVA: 0x7FFD54067390
        public void GetAxisDelta(){} // RVA: 0x7FFD54067430
        public void GetLastAxis(){} // RVA: 0x7FFD540674D0
        public void GetLastAxisDelta(){} // RVA: 0x7FFD54067570
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD54067610
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD54067690
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFD54067710
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFD54067790
        public void AddOnChangeListener(){} // RVA: 0x7FFD54067810
        public void RemoveOnChangeListener(){} // RVA: 0x7FFD54067890
        public void AddOnUpdateListener(){} // RVA: 0x7FFD54067910
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFD54067990
        public void AddOnAxisListener(){} // RVA: 0x7FFD54067A10
        public void RemoveOnAxisListener(){} // RVA: 0x7FFD54067A90
        public void RemoveAllListeners(){} // RVA: 0x7FFD54067B10
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54067B80
    }

    public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base`2
    {
        public object bonePositions;
        public object boneRotations;
        public object lastBonePositions;
        public object lastBoneRotations;
        public object rangeOfMotion;
        public object skeletalTransformSpace;
        public object summaryDataType;
        public object skeletalTrackingLevel;
        public object thumbCurl;
        public object indexCurl;
        public object middleCurl;
        public object ringCurl;
        public object pinkyCurl;
        public object thumbIndexSplay;
        public object indexMiddleSplay;
        public object middleRingSplay;
        public object ringPinkySplay;
        public object lastThumbCurl;
        public object lastIndexCurl;
        public object lastMiddleCurl;
        public object lastRingCurl;
        public object lastPinkyCurl;
        public object lastThumbIndexSplay;
        public object lastIndexMiddleSplay;
        public object lastMiddleRingSplay;
        public object lastRingPinkySplay;
        public object fingerCurls;
        public object fingerSplays;
        public object lastFingerCurls;
        public object lastFingerSplays;
        public object poseChanged;
        public object onlyUpdateSummaryData;
        public object boneCount;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFD540697E0
        public void remove_onActiveChange(){} // RVA: 0x7FFD54069860
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD540698E0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD54069A20
        public void add_onChange(){} // RVA: 0x7FFD54069AA0
        public void remove_onChange(){} // RVA: 0x7FFD54069B20
        public void add_onUpdate(){} // RVA: 0x7FFD54069BA0
        public void remove_onUpdate(){} // RVA: 0x7FFD54069C20
        public void add_onTrackingChanged(){} // RVA: 0x7FFD54069CA0
        public void remove_onTrackingChanged(){} // RVA: 0x7FFD54069D20
        public void add_onValidPoseChanged(){} // RVA: 0x7FFD54069DA0
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFD54069E20
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFD54069EA0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFD54069F20
        public void .ctor(){} // RVA: 0x7FFD54069FA0
        public void UpdateValue(){} // RVA: 0x7FFD54069FF0
        public void UpdateValueWithoutEvents(){} // RVA: 0x7FFD5406A070
        public void UpdateTransform(){} // RVA: 0x7FFD5406A0F0
        public void get_bonePositions(){} // RVA: 0x7FFD5406A220
        public void get_boneRotations(){} // RVA: 0x7FFD5406A280
        public void get_lastBonePositions(){} // RVA: 0x7FFD5406A2E0
        public void get_lastBoneRotations(){} // RVA: 0x7FFD5406A340
        public void get_rangeOfMotion(){} // RVA: 0x7FFD5406A3A0
        public void set_rangeOfMotion(){} // RVA: 0x7FFD5406A400
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFD5406A470
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFD5406A4D0
        public void get_summaryDataType(){} // RVA: 0x7FFD5406A540
        public void set_summaryDataType(){} // RVA: 0x7FFD5406A5A0
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFD5406A610
        public void get_thumbCurl(){} // RVA: 0x7FFD5406A680
        public void get_indexCurl(){} // RVA: 0x7FFD5406A700
        public void get_middleCurl(){} // RVA: 0x7FFD5406A780
        public void get_ringCurl(){} // RVA: 0x7FFD5406A800
        public void get_pinkyCurl(){} // RVA: 0x7FFD5406A880
        public void get_thumbIndexSplay(){} // RVA: 0x7FFD5406A900
        public void get_indexMiddleSplay(){} // RVA: 0x7FFD5406A980
        public void get_middleRingSplay(){} // RVA: 0x7FFD5406AA00
        public void get_ringPinkySplay(){} // RVA: 0x7FFD5406AA80
        public void get_lastThumbCurl(){} // RVA: 0x7FFD5406AB00
        public void get_lastIndexCurl(){} // RVA: 0x7FFD5406AB80
        public void get_lastMiddleCurl(){} // RVA: 0x7FFD5406AC00
        public void get_lastRingCurl(){} // RVA: 0x7FFD5406AC80
        public void get_lastPinkyCurl(){} // RVA: 0x7FFD5406AD00
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFD5406AD80
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFD5406AE00
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFD5406AE80
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFD5406AF00
        public void get_fingerCurls(){} // RVA: 0x7FFD5406AF80
        public void get_fingerSplays(){} // RVA: 0x7FFD5406AFE0
        public void get_lastFingerCurls(){} // RVA: 0x7FFD5406B040
        public void get_lastFingerSplays(){} // RVA: 0x7FFD5406B0A0
        public void get_poseChanged(){} // RVA: 0x7FFD5406B100
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFD5406B160
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFD5406B1C0
        public void GetActive(){} // RVA: 0x7FFD5406B230
        public void GetSetActive(){} // RVA: 0x7FFD5405A240
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFD5406B2A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFD5406B340
        public void GetLocalPosition(){} // RVA: 0x7FFD5406B3E0
        public void GetLocalRotation(){} // RVA: 0x7FFD5406B460
        public void GetVelocity(){} // RVA: 0x7FFD5406B4E0
        public void GetAngularVelocity(){} // RVA: 0x7FFD5406B560
        public void GetDeviceIsConnected(){} // RVA: 0x7FFD5406B5E0
        public void GetPoseIsValid(){} // RVA: 0x7FFD5406B640
        public void GetTrackingResult(){} // RVA: 0x7FFD5406B6A0
        public void GetLastLocalPosition(){} // RVA: 0x7FFD5406B700
        public void GetLastLocalRotation(){} // RVA: 0x7FFD5406B780
        public void GetLastVelocity(){} // RVA: 0x7FFD5406B800
        public void GetLastAngularVelocity(){} // RVA: 0x7FFD5406B880
        public void GetLastDeviceIsConnected(){} // RVA: 0x7FFD5406B900
        public void GetLastPoseIsValid(){} // RVA: 0x7FFD5406B960
        public void GetLastTrackingResult(){} // RVA: 0x7FFD5406B9C0
        public void get_boneCount(){} // RVA: 0x7FFD5406BA20
        public void GetBonePositions(){} // RVA: 0x7FFD5406BA90
        public void GetBoneRotations(){} // RVA: 0x7FFD5406BB80
        public void GetLastBonePositions(){} // RVA: 0x7FFD5406BC70
        public void GetLastBoneRotations(){} // RVA: 0x7FFD5406BD60
        public void SetRangeOfMotion(){} // RVA: 0x7FFD5406BE50
        public void SetSkeletalTransformSpace(){} // RVA: 0x7FFD5406BEC0
        public void GetBoneCount(){} // RVA: 0x7FFD5406BA20
        public void GetBoneHierarchy(){} // RVA: 0x7FFD5406BF30
        public void GetBoneName(){} // RVA: 0x7FFD5406BFA0
        public void GetReferenceTransforms(){} // RVA: 0x7FFD5406C010
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFD5406C090
        public void GetFingerCurls(){} // RVA: 0x7FFD5406C100
        public void GetLastFingerCurls(){} // RVA: 0x7FFD5406C1F0
        public void GetFingerSplays(){} // RVA: 0x7FFD5406C2E0
        public void GetLastFingerSplays(){} // RVA: 0x7FFD5406C3D0
        public void GetFingerCurl(){} // RVA: 0x7FFD5406C4C0 | overloaded x2
        public void GetSplay(){} // RVA: 0x7FFD5406C550 | overloaded x2
        public void GetLastFingerCurl(){} // RVA: 0x7FFD5406C5E0 | overloaded x2
        public void GetLastSplay(){} // RVA: 0x7FFD5406C670 | overloaded x2
        public void GetLocalizedName(){} // RVA: 0x7FFD5406C700
        public void RemoveAllListeners(){} // RVA: 0x7FFD5406C780
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7FFD5406C800
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7FFD5406C880
        public void AddOnTrackingChanged(){} // RVA: 0x7FFD5406C900
        public void RemoveOnTrackingChanged(){} // RVA: 0x7FFD5406C980
        public void AddOnValidPoseChanged(){} // RVA: 0x7FFD5406CA00
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7FFD5406CA80
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD5406CB00
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD5406CB80
        public void AddOnChangeListener(){} // RVA: 0x7FFD5406CC00
        public void RemoveOnChangeListener(){} // RVA: 0x7FFD5406CC80
        public void AddOnUpdateListener(){} // RVA: 0x7FFD5406CD00
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFD5406CD80
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5406CE00
        public void .cctor(){} // RVA: 0x7FFD5406CE40
    }

    public class SteamVR_Action_Source_Map : Object
    {
        public object fullPath;
        public object handle;
        public object actionSet;
        public object direction;

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x7FFD4E35C380
        public void set_fullPath(){} // RVA: 0x7FFD4E342E30
        public void get_handle(){} // RVA: 0x7FFD4E3447C0
        public void set_handle(){} // RVA: 0x7FFD4ECB20D0
        public void get_actionSet(){} // RVA: 0x7FFD4E36F0C0
        public void set_actionSet(){} // RVA: 0x7FFD4E36F0D0
        public void get_direction(){} // RVA: 0x7FFD4E70C4C0
        public void set_direction(){} // RVA: 0x7FFD4EABA6E0
        public void PreInitialize(){} // RVA: 0x7FFD5405AA20
        public void PreinitializeMap(){} // RVA: 0x7FFD4E092BC0
        public void Initialize(){} // RVA: 0x7FFD5405AC70
        public void GetActionSetPath(){} // RVA: 0x7FFD5405AE60
        public void GetActionDirection(){} // RVA: 0x7FFD5405AEE0
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD5405B0F0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object Item;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD51DC3D80
        public void OnAccessSource(){} // RVA: 0x7FFD4E341310
        public void Initialize(){} // RVA: 0x7FFD51DC3DA0
        public void PreinitializeMap(){} // RVA: 0x7FFD51DC3E30
        public void GetSourceElementForIndexer(){} // RVA: 0x7FFD51DC3ED0
        public void .ctor(){} // RVA: 0x7FFD51DC3F20
    }

    public class SteamVR_Action_Vector2 : SteamVR_Action_In`2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFD54071DF0
        public void remove_onChange(){} // RVA: 0x7FFD54071E70
        public void add_onUpdate(){} // RVA: 0x7FFD54071EF0
        public void remove_onUpdate(){} // RVA: 0x7FFD54071F70
        public void add_onAxis(){} // RVA: 0x7FFD54071FF0
        public void remove_onAxis(){} // RVA: 0x7FFD54072070
        public void add_onActiveChange(){} // RVA: 0x7FFD540720F0
        public void remove_onActiveChange(){} // RVA: 0x7FFD54072170
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD540721F0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD54072270
        public void get_axis(){} // RVA: 0x7FFD540722F0
        public void get_lastAxis(){} // RVA: 0x7FFD54072370
        public void get_delta(){} // RVA: 0x7FFD540723F0
        public void get_lastDelta(){} // RVA: 0x7FFD54072470
        public void .ctor(){} // RVA: 0x7FFD540724F0
        public void GetAxis(){} // RVA: 0x7FFD54072530
        public void GetAxisDelta(){} // RVA: 0x7FFD540725B0
        public void GetLastAxis(){} // RVA: 0x7FFD54072630
        public void GetLastAxisDelta(){} // RVA: 0x7FFD540726B0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD54072730
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD540727B0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFD54072830
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFD540728B0
        public void AddOnChangeListener(){} // RVA: 0x7FFD54072930
        public void RemoveOnChangeListener(){} // RVA: 0x7FFD540729B0
        public void AddOnUpdateListener(){} // RVA: 0x7FFD54072A30
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFD54072AB0
        public void AddOnAxisListener(){} // RVA: 0x7FFD54072B30
        public void RemoveOnAxisListener(){} // RVA: 0x7FFD54072BB0
        public void RemoveAllListeners(){} // RVA: 0x7FFD54072C30
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD54072CA0
    }

    public class SteamVR_Action_Vector3 : SteamVR_Action_In`2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFD5408A3D0
        public void remove_onChange(){} // RVA: 0x7FFD5408A450
        public void add_onUpdate(){} // RVA: 0x7FFD5408A4D0
        public void remove_onUpdate(){} // RVA: 0x7FFD5408A550
        public void add_onAxis(){} // RVA: 0x7FFD5408A5D0
        public void remove_onAxis(){} // RVA: 0x7FFD5408A650
        public void add_onActiveChange(){} // RVA: 0x7FFD5408A6D0
        public void remove_onActiveChange(){} // RVA: 0x7FFD5408A750
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD5408A7D0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD5408A850
        public void get_axis(){} // RVA: 0x7FFD5408A8D0
        public void get_lastAxis(){} // RVA: 0x7FFD5408A950
        public void get_delta(){} // RVA: 0x7FFD5408A9D0
        public void get_lastDelta(){} // RVA: 0x7FFD5408AA50
        public void .ctor(){} // RVA: 0x7FFD5408AAD0
        public void GetAxis(){} // RVA: 0x7FFD5408AB10
        public void GetAxisDelta(){} // RVA: 0x7FFD5408ABA0
        public void GetLastAxis(){} // RVA: 0x7FFD5408AC30
        public void GetLastAxisDelta(){} // RVA: 0x7FFD5408ACC0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD5408AD50
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD5408ADD0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFD5408AE50
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFD5408AED0
        public void AddOnChangeListener(){} // RVA: 0x7FFD5408AF50
        public void RemoveOnChangeListener(){} // RVA: 0x7FFD5408AFD0
        public void AddOnUpdateListener(){} // RVA: 0x7FFD5408B050
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFD5408B0D0
        public void AddOnAxisListener(){} // RVA: 0x7FFD5408B150
        public void RemoveOnAxisListener(){} // RVA: 0x7FFD5408B1D0
        public void RemoveAllListeners(){} // RVA: 0x7FFD5408B250
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5408B2C0
    }

    public class SteamVR_Action_Vibration : SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFD5408CF40
        public void remove_onActiveChange(){} // RVA: 0x7FFD5408CFC0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFD5408D040
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFD5408D0C0
        public void add_onExecute(){} // RVA: 0x7FFD5408D140
        public void remove_onExecute(){} // RVA: 0x7FFD5408D1C0
        public void .ctor(){} // RVA: 0x7FFD5408D240
        public void Execute(){} // RVA: 0x7FFD5408D2E0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFD5408D390
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFD5408D410
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFD5408D490
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFD5408D510
        public void AddOnExecuteListener(){} // RVA: 0x7FFD5408D590
        public void RemoveOnExecuteListener(){} // RVA: 0x7FFD5408D610
        public void RemoveAllListeners(){} // RVA: 0x7FFD5408D690
        public void GetTimeLastChanged(){} // RVA: 0x7FFD5408D700
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFD4E341310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFD5408D770
        public void IsUpdating(){} // RVA: 0x7FFD5408D7B0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object Item;
        public object fullPath;
        public object handle;
        public object actionSet;
        public object direction;
        public object active;
        public object lastActive;
        public object activeBinding;
        public object lastActiveBinding;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFD51DC4030
        public void get_fullPath(){} // RVA: 0x7FFD51DC4060
        public void get_handle(){} // RVA: 0x7FFD51DC4080
        public void get_actionSet(){} // RVA: 0x7FFD51DC40A0
        public void get_direction(){} // RVA: 0x7FFD51DC40C0
        public void get_active(){} // RVA: 0x7FFD51DC40E0
        public void get_lastActive(){} // RVA: 0x7FFD51DC4130
        public void get_activeBinding(){} // RVA: 0x7FFD51DC4180
        public void get_lastActiveBinding(){} // RVA: 0x7FFD51DC41D0
        public void PreInitialize(){} // RVA: 0x7FFD51DC4220
        public void CreateUninitialized(){} // RVA: 0x7FFD51DC4440 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x7FFD51DC4640
        public void Initialize(){} // RVA: 0x7FFD51DC4900
        public void GetSourceMap(){} // RVA: 0x7FFD4E36F130
        public void InitializeCopy(){} // RVA: 0x7FFD51DC4A10
        public void InitAfterDeserialize(){} // RVA: 0x7FFD51DC4B90
        public void GetActive(){} // RVA: 0x7FFD51DC4C40
        public void GetActiveBinding(){} // RVA: 0x7FFD51DC4C90
        public void GetLastActive(){} // RVA: 0x7FFD51DC4CE0
        public void GetLastActiveBinding(){} // RVA: 0x7FFD51DC4D30
        public void GetActionBindingInfo(){} // RVA: 0x7FFD51DC4D80
        public void .ctor(){} // RVA: 0x7FFD51DC5410
        public void .cctor(){} // RVA: 0x7FFD51DC5460
    }

    public class SteamVR_Actions : Object
    {
        public object global_Safe_Mode;
        public object global_Pose;
        public object global_SkeletonLeftHand;
        public object global_SkeletonRightHand;
        public object global_HeadsetOnHead;
        public object global_Menu;
        public object global_Quick_Menu;
        public object global_Action_Menu;
        public object global_Main_Menu;
        public object global_Interact;
        public object global_Grab;
        public object global_Move;
        public object global_Jump;
        public object global_Rotate;
        public object global_Mic;
        public object global_Gesture_Toggle;
        public object global_Stick_Click;
        public object global_Trigger_Axis;
        public object global_Grip_Axis;
        public object global_Udon_Menu;
        public object global_Drop;
        public object global_Nameplates;
        public object global_HUD;
        public object global_Chatbox;
        public object global_Face_Mirror;
        public object global_Personal_Mirror;
        public object global_Personal_Mirror_Lock;
        public object global_Earmuffs;
        public object global_Camera;
        public object global_Stream_Camera;
        public object global_Avatar_Debug_Screen;
        public object global_OSC_Debug_Screen;
        public object global_Confirm_FBT_Calibration;
        public object global_Start_Move;
        public object global_Start_Rotate;
        public object global_Continue_Move;
        public object global_Continue_Rotate;
        public object global_No_Gesture_After_Move;
        public object global_No_Gesture_After_Rotate;
        public object global_Gesture_Activator_Thumb;
        public object global_Gesture_Activator_Thumb_Inner_Upper;
        public object global_Gesture_Activator_Thumb_Inner_Lower;
        public object global_Gesture_Activator_Thumb_Outer;
        public object global_Gesture_Activator_Index;
        public object global_Gesture_Activator_Grip;
        public object global_Gesture_Trigger_Axis;
        public object global_Gesture_Grip_Axis;
        public object global_Gesture_Activator_Stick_Deflection;
        public object global_Gesture_Direct_Neutral_Left;
        public object global_Gesture_Direct_Fist_Left;
        public object global_Gesture_Direct_Open_Left;
        public object global_Gesture_Direct_Peace_Left;
        public object global_Gesture_Direct_Horns_Left;
        public object global_Gesture_Direct_Finger_Gun_Left;
        public object global_Gesture_Direct_Thumbs_Up_Left;
        public object global_Gesture_Direct_Point_Left;
        public object global_Gesture_Direct_Neutral_Right;
        public object global_Gesture_Direct_Fist_Right;
        public object global_Gesture_Direct_Open_Right;
        public object global_Gesture_Direct_Peace_Right;
        public object global_Gesture_Direct_Horns_Right;
        public object global_Gesture_Direct_Finger_Gun_Right;
        public object global_Gesture_Direct_Thumbs_Up_Right;
        public object global_Gesture_Direct_Point_Right;
        public object global_Gesture_Wheel_Left;
        public object global_Gesture_Wheel_Select_Left;
        public object global_Gesture_Wheel_Soft_Select_Left;
        public object global_Gesture_Wheel_Weight_Left;
        public object global_Gesture_Wheel_Direct_Left;
        public object global_Gesture_Wheel_Direct_Stay_Left;
        public object global_Gesture_Wheel_Cancel_Left;
        public object global_Gesture_Wheel_Cancel_Open_Left;
        public object global_Gesture_Wheel_Held_Left;
        public object global_Gesture_Wheel_Right;
        public object global_Gesture_Wheel_Select_Right;
        public object global_Gesture_Wheel_Soft_Select_Right;
        public object global_Gesture_Wheel_Weight_Right;
        public object global_Gesture_Wheel_Direct_Right;
        public object global_Gesture_Wheel_Direct_Stay_Right;
        public object global_Gesture_Wheel_Cancel_Right;
        public object global_Gesture_Wheel_Cancel_Open_Right;
        public object global_Gesture_Wheel_Held_Right;
        public object global_Disable_Gesture_Tracked;
        public object global_Disable_Gesture_Wheel_Move_Left;
        public object global_Disable_Gesture_Wheel_Rotate_Left;
        public object global_Disable_Gesture_Wheel_Move_Right;
        public object global_Disable_Gesture_Wheel_Rotate_Right;
        public object global_Physbone_Grab_Left;
        public object global_Physbone_Freeze_Left;
        public object global_Physbone_Grab_Right;
        public object global_Physbone_Freeze_Right;
        public object global_Scroll;
        public object global_Haptic;
        public object one_Hand_Interact;
        public object one_Hand_Grab;
        public object one_Hand_Move_Rotate;
        public object one_Hand_Jump;
        public object one_Hand_Mic;
        public object one_Hand_Gesture_Toggle;
        public object one_Hand_Stick_Click;
        public object one_Hand_Trigger_Axis;
        public object one_Hand_Grip_Axis;
        public object one_Hand_Udon_Menu;
        public object one_Hand_Drop;
        public object one_Hand_Start_Move_Rotate;
        public object one_Hand_Continue_Move_Rotate;
        public object one_Hand_No_Gesture_After_Move_Rotate;
        public object one_Hand_Menu;
        public object one_Hand_Nameplates;
        public object one_Hand_HUD;
        public object one_Hand_Chatbox;
        public object one_Hand_Face_Mirror;
        public object one_Hand_Personal_Mirror;
        public object one_Hand_Personal_Mirror_Lock;
        public object one_Hand_Earmuffs;
        public object one_Hand_Camera;
        public object one_Hand_Stream_Camera;
        public object one_Hand_Avatar_Debug_Screen;
        public object one_Hand_OSC_Debug_Screen;
        public object one_Hand_Confirm_FBT_Calibration;
        public object one_Hand_Gesture_Activator_Thumb;
        public object one_Hand_Gesture_Activator_Thumb_Inner_Upper;
        public object one_Hand_Gesture_Activator_Thumb_Inner_Lower;
        public object one_Hand_Gesture_Activator_Thumb_Outer;
        public object one_Hand_Gesture_Activator_Index;
        public object one_Hand_Gesture_Activator_Grip;
        public object one_Hand_Gesture_Trigger_Axis;
        public object one_Hand_Gesture_Grip_Axis;
        public object one_Hand_Gesture_Activator_Stick_Deflection;
        public object one_Hand_Gesture_Wheel_Left;
        public object one_Hand_Gesture_Wheel_Select_Left;
        public object one_Hand_Gesture_Wheel_Soft_Select_Left;
        public object one_Hand_Gesture_Wheel_Weight_Left;
        public object one_Hand_Gesture_Wheel_Direct_Left;
        public object one_Hand_Gesture_Wheel_Direct_Stay_Left;
        public object one_Hand_Gesture_Wheel_Cancel_Left;
        public object one_Hand_Gesture_Wheel_Cancel_Open_Left;
        public object one_Hand_Gesture_Wheel_Held_Left;
        public object one_Hand_Gesture_Wheel_Right;
        public object one_Hand_Gesture_Wheel_Select_Right;
        public object one_Hand_Gesture_Wheel_Soft_Select_Right;
        public object one_Hand_Gesture_Wheel_Weight_Right;
        public object one_Hand_Gesture_Wheel_Direct_Right;
        public object one_Hand_Gesture_Wheel_Direct_Stay_Right;
        public object one_Hand_Gesture_Wheel_Cancel_Right;
        public object one_Hand_Gesture_Wheel_Cancel_Open_Right;
        public object one_Hand_Gesture_Wheel_Held_Right;
        public object one_Hand_Disable_Gesture_Wheel_Move_Left;
        public object one_Hand_Disable_Gesture_Wheel_Rotate_Left;
        public object one_Hand_Disable_Gesture_Wheel_Move_Right;
        public object one_Hand_Disable_Gesture_Wheel_Rotate_Right;
        public object one_Hand_Reserve_bool;
        public object one_Hand_Reserve_vector1;
        public object one_Hand_Reserve_vector2;
        public object menu_Confirm;
        public object menu_Back;
        public object menu_Tab;
        public object menu_Scroll;
        public object menu_Quick_Menu_Close;
        public object menu_Drag;
        public object action_Menu_Axis;
        public object action_Menu_Select;
        public object action_Menu_Gesture_Activator_Thumb;
        public object action_Menu_Gesture_Activator_Thumb_Inner_Upper;
        public object action_Menu_Gesture_Activator_Thumb_Inner_Lower;
        public object action_Menu_Gesture_Activator_Thumb_Outer;
        public object action_Menu_Gesture_Activator_Index;
        public object action_Menu_Gesture_Activator_Grip;
        public object action_Menu_Gesture_Trigger_Axis;
        public object action_Menu_Gesture_Grip_Axis;
        public object action_Menu_Gesture_Activator_Stick_Deflection;
        public object action_Menu_Gesture_Wheel_Left;
        public object action_Menu_Gesture_Wheel_Select_Left;
        public object action_Menu_Gesture_Wheel_Soft_Select_Left;
        public object action_Menu_Gesture_Wheel_Weight_Left;
        public object action_Menu_Gesture_Wheel_Direct_Left;
        public object action_Menu_Gesture_Wheel_Direct_Stay_Left;
        public object action_Menu_Gesture_Wheel_Cancel_Left;
        public object action_Menu_Gesture_Wheel_Cancel_Open_Left;
        public object action_Menu_Gesture_Wheel_Held_Left;
        public object action_Menu_Gesture_Wheel_Right;
        public object action_Menu_Gesture_Wheel_Select_Right;
        public object action_Menu_Gesture_Wheel_Soft_Select_Right;
        public object action_Menu_Gesture_Wheel_Weight_Right;
        public object action_Menu_Gesture_Wheel_Direct_Right;
        public object action_Menu_Gesture_Wheel_Direct_Stay_Right;
        public object action_Menu_Gesture_Wheel_Cancel_Right;
        public object action_Menu_Gesture_Wheel_Cancel_Open_Right;
        public object action_Menu_Gesture_Wheel_Held_Right;
        public object action_Menu_Disable_Gesture_Wheel_Move_Left;
        public object action_Menu_Disable_Gesture_Wheel_Rotate_Left;
        public object action_Menu_Disable_Gesture_Wheel_Move_Right;
        public object action_Menu_Disable_Gesture_Wheel_Rotate_Right;
        public object action_Menu_Reserve_bool;
        public object action_Menu_Reserve_vector1;
        public object action_Menu_Reserve_vector2;
        public object action_Menu_Grab;
        public object action_Menu_Drop;
        public object drone_Left_Joystick;
        public object drone_Right_Joystick;
        public object drone_Self_Leveling_Mod;
        public object drone_Hold_Altitude_Mod;
        public object drone_Toggle_FPV;
        public object drone_Flip;
        public object drone_Take_Picture;
        public object drone_Cycle_Flight_Preset;
        public object drone_Toggle_Self_Leveling;
        public object drone_Respawn;
        public object drone_Select_Flight_Preset_Micro;
        public object drone_Select_Flight_Preset_Cinematic;
        public object drone_Select_Flight_Preset_Racing;
        public object drone_Select_Flight_Preset_Freestyle;
        public object Global;
        public object One_Hand;
        public object Menu;
        public object Action_Menu;
        public object Drone;

        // ── Methods ──
        public void get_global_Safe_Mode(){} // RVA: 0x7FFD54073B90
        public void get_global_Pose(){} // RVA: 0x7FFD54073C00
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7FFD54073C70
        public void get_global_SkeletonRightHand(){} // RVA: 0x7FFD54073CE0
        public void get_global_HeadsetOnHead(){} // RVA: 0x7FFD54073D50
        public void get_global_Menu(){} // RVA: 0x7FFD54073DC0
        public void get_global_Quick_Menu(){} // RVA: 0x7FFD54073E30
        public void get_global_Action_Menu(){} // RVA: 0x7FFD54073EA0
        public void get_global_Main_Menu(){} // RVA: 0x7FFD54073F10
        public void get_global_Interact(){} // RVA: 0x7FFD54073F80
        public void get_global_Grab(){} // RVA: 0x7FFD54073FF0
        public void get_global_Move(){} // RVA: 0x7FFD54074060
        public void get_global_Jump(){} // RVA: 0x7FFD540740D0
        public void get_global_Rotate(){} // RVA: 0x7FFD54074140
        public void get_global_Mic(){} // RVA: 0x7FFD540741B0
        public void get_global_Gesture_Toggle(){} // RVA: 0x7FFD54074220
        public void get_global_Stick_Click(){} // RVA: 0x7FFD54074290
        public void get_global_Trigger_Axis(){} // RVA: 0x7FFD54074300
        public void get_global_Grip_Axis(){} // RVA: 0x7FFD54074370
        public void get_global_Udon_Menu(){} // RVA: 0x7FFD540743E0
        public void get_global_Drop(){} // RVA: 0x7FFD54074450
        public void get_global_Nameplates(){} // RVA: 0x7FFD540744C0
        public void get_global_HUD(){} // RVA: 0x7FFD54074530
        public void get_global_Chatbox(){} // RVA: 0x7FFD540745A0
        public void get_global_Face_Mirror(){} // RVA: 0x7FFD54074610
        public void get_global_Personal_Mirror(){} // RVA: 0x7FFD54074680
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x7FFD540746F0
        public void get_global_Earmuffs(){} // RVA: 0x7FFD54074760
        public void get_global_Camera(){} // RVA: 0x7FFD540747D0
        public void get_global_Stream_Camera(){} // RVA: 0x7FFD54074840
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x7FFD540748B0
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x7FFD54074920
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x7FFD54074990
        public void get_global_Start_Move(){} // RVA: 0x7FFD54074A00
        public void get_global_Start_Rotate(){} // RVA: 0x7FFD54074A70
        public void get_global_Continue_Move(){} // RVA: 0x7FFD54074AE0
        public void get_global_Continue_Rotate(){} // RVA: 0x7FFD54074B50
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x7FFD54074BC0
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x7FFD54074C30
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x7FFD54074CA0
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFD54074D10
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFD54074D80
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFD54074DF0
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x7FFD54074E60
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x7FFD54074ED0
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x7FFD54074F40
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x7FFD54074FB0
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFD54075020
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFD54075090
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFD54075100
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x7FFD54075170
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFD540751E0
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFD54075250
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFD540752C0
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFD54075330
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x7FFD540753A0
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFD54075410
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFD54075480
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x7FFD540754F0
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFD54075560
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFD540755D0
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFD54075640
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFD540756B0
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x7FFD54075720
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x7FFD54075790
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFD54075800
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFD54075870
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFD540758E0
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFD54075950
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFD540759C0
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFD54075A30
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFD54075AA0
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFD54075B10
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x7FFD54075B80
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFD54075BF0
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFD54075C60
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFD54075CD0
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD54075D40
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFD54075DB0
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFD54075E20
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFD54075E90
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFD54075F00
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x7FFD54075F70
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFD54075FE0
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFD54076050
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFD540760C0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD54076130
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x7FFD540761A0
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x7FFD54076210
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x7FFD54076280
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x7FFD540762F0
        public void get_global_Scroll(){} // RVA: 0x7FFD54076360
        public void get_global_Haptic(){} // RVA: 0x7FFD540763D0
        public void get_one_Hand_Interact(){} // RVA: 0x7FFD54076440
        public void get_one_Hand_Grab(){} // RVA: 0x7FFD540764B0
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x7FFD54076520
        public void get_one_Hand_Jump(){} // RVA: 0x7FFD54076590
        public void get_one_Hand_Mic(){} // RVA: 0x7FFD54076600
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x7FFD54076670
        public void get_one_Hand_Stick_Click(){} // RVA: 0x7FFD540766E0
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x7FFD54076750
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x7FFD540767C0
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x7FFD54076830
        public void get_one_Hand_Drop(){} // RVA: 0x7FFD540768A0
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x7FFD54076910
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x7FFD54076980
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFD540769F0
        public void get_one_Hand_Menu(){} // RVA: 0x7FFD54076A60
        public void get_one_Hand_Nameplates(){} // RVA: 0x7FFD54076AD0
        public void get_one_Hand_HUD(){} // RVA: 0x7FFD54076B40
        public void get_one_Hand_Chatbox(){} // RVA: 0x7FFD54076BB0
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x7FFD54076C20
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x7FFD54076C90
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x7FFD54076D00
        public void get_one_Hand_Earmuffs(){} // RVA: 0x7FFD54076D70
        public void get_one_Hand_Camera(){} // RVA: 0x7FFD54076DE0
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x7FFD54076E50
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x7FFD54076EC0
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x7FFD54076F30
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x7FFD54076FA0
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x7FFD54077010
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFD54077080
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFD540770F0
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFD54077160
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x7FFD540771D0
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7FFD54077240
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7FFD540772B0
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x7FFD54077320
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFD54077390
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x7FFD54077400
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFD54077470
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFD540774E0
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFD54077550
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFD540775C0
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFD54077630
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFD540776A0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFD54077710
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFD54077780
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x7FFD540777F0
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFD54077860
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFD540778D0
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFD54077940
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD540779B0
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFD54077A20
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFD54077A90
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFD54077B00
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFD54077B70
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFD54077BE0
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFD54077C50
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFD54077CC0
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD54077D30
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x7FFD54077DA0
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x7FFD54077E10
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x7FFD54077E80
        public void get_menu_Confirm(){} // RVA: 0x7FFD54077EF0
        public void get_menu_Back(){} // RVA: 0x7FFD54077F60
        public void get_menu_Tab(){} // RVA: 0x7FFD54077FD0
        public void get_menu_Scroll(){} // RVA: 0x7FFD54078040
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x7FFD540780B0
        public void get_menu_Drag(){} // RVA: 0x7FFD54078120
        public void get_action_Menu_Axis(){} // RVA: 0x7FFD54078190
        public void get_action_Menu_Select(){} // RVA: 0x7FFD54078200
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x7FFD54078270
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFD540782E0
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFD54078350
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFD540783C0
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x7FFD54078430
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x7FFD540784A0
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x7FFD54078510
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x7FFD54078580
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFD540785F0
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x7FFD54078660
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFD540786D0
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFD54078740
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFD540787B0
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFD54078820
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFD54078890
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFD54078900
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFD54078970
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFD540789E0
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x7FFD54078A50
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFD54078AC0
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFD54078B30
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFD54078BA0
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD54078C10
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFD54078C80
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFD54078CF0
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFD54078D60
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFD54078DD0
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFD54078E40
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFD54078EB0
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFD54078F20
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD54078F90
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x7FFD54079000
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x7FFD54079070
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x7FFD540790E0
        public void get_action_Menu_Grab(){} // RVA: 0x7FFD54079150
        public void get_action_Menu_Drop(){} // RVA: 0x7FFD540791C0
        public void get_drone_Left_Joystick(){} // RVA: 0x7FFD54079230
        public void get_drone_Right_Joystick(){} // RVA: 0x7FFD540792A0
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x7FFD54079310
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x7FFD54079380
        public void get_drone_Toggle_FPV(){} // RVA: 0x7FFD540793F0
        public void get_drone_Flip(){} // RVA: 0x7FFD54079460
        public void get_drone_Take_Picture(){} // RVA: 0x7FFD540794D0
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x7FFD54079540
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x7FFD540795B0
        public void get_drone_Respawn(){} // RVA: 0x7FFD54079620
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x7FFD54079690
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFD54079700
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x7FFD54079770
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFD540797E0
        public void InitializeActionArrays(){} // RVA: 0x7FFD54079850
        public void PreInitActions(){} // RVA: 0x7FFD54082FF0
        public void get_Global(){} // RVA: 0x7FFD54087DD0
        public void get_One_Hand(){} // RVA: 0x7FFD54087E40
        public void get_Menu(){} // RVA: 0x7FFD54087EB0
        public void get_Action_Menu(){} // RVA: 0x7FFD54087F20
        public void get_Drone(){} // RVA: 0x7FFD54087F90
        public void StartPreInitActionSets(){} // RVA: 0x7FFD54088000
        public void PreInitialize(){} // RVA: 0x7FFD540886E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_ActivateActionSetOnLoad : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5408E8B0
        public void OnDestroy(){} // RVA: 0x7FFD5408E920
        public void .ctor(){} // RVA: 0x7FFD5408E980
    }

    public class SteamVR_Behaviour : MonoBehaviour
    {
        public object instance;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD540B49B0
        public void Initialize(){} // RVA: 0x7FFD540B4AF0
        public void Awake(){} // RVA: 0x7FFD540B5390
        public void InitializeSteamVR(){} // RVA: 0x7FFD540B5490
        public void DoInitializeSteamVR(){} // RVA: 0x7FFD540B56E0
        public void XRDevice_deviceLoaded(){} // RVA: 0x7FFD540B5780
        public void EnableOpenVR(){} // RVA: 0x7FFD540B5860
        public void OnEnable(){} // RVA: 0x7FFD540B5980
        public void OnDisable(){} // RVA: 0x7FFD540B5B20
        public void OnBeforeRender(){} // RVA: 0x7FFD540B5CD0
        public void PreCull(){} // RVA: 0x7FFD540B5CE0
        public void FixedUpdate(){} // RVA: 0x7FFD540B5F60
        public void LateUpdate(){} // RVA: 0x7FFD540B60E0
        public void Update(){} // RVA: 0x7FFD540B6280
        public void OnQuit(){} // RVA: 0x7FFD540B6400
        public void .ctor(){} // RVA: 0x7FFD540B6450
        public void .cctor(){} // RVA: 0x7FFD540B64A0
    }

    public class SteamVR_Behaviour_Boolean : MonoBehaviour
    {
        public object isActive;
        public object actionSet;

        // ── Methods ──
        public void add_onChangeEvent(){} // RVA: 0x7FFD5408EA80
        public void remove_onChangeEvent(){} // RVA: 0x7FFD5408EB70
        public void add_onUpdateEvent(){} // RVA: 0x7FFD5408EC60
        public void remove_onUpdateEvent(){} // RVA: 0x7FFD5408ED50
        public void add_onPressEvent(){} // RVA: 0x7FFD5408EE40
        public void remove_onPressEvent(){} // RVA: 0x7FFD5408EF30
        public void add_onPressDownEvent(){} // RVA: 0x7FFD5408F020
        public void remove_onPressDownEvent(){} // RVA: 0x7FFD5408F110
        public void add_onPressUpEvent(){} // RVA: 0x7FFD5408F200
        public void remove_onPressUpEvent(){} // RVA: 0x7FFD5408F2F0
        public void get_isActive(){} // RVA: 0x7FFD5408F3E0
        public void get_actionSet(){} // RVA: 0x7FFD5408F430
        public void OnEnable(){} // RVA: 0x7FFD5408F530
        public void OnDisable(){} // RVA: 0x7FFD5408F620
        public void AddHandlers(){} // RVA: 0x7FFD5408F630
        public void RemoveHandlers(){} // RVA: 0x7FFD5408F8F0
        public void SteamVR_Behaviour_Boolean_OnStateUp(){} // RVA: 0x7FFD5408FC50
        public void SteamVR_Behaviour_Boolean_OnStateDown(){} // RVA: 0x7FFD5408FCD0
        public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x7FFD5408FD50
        public void SteamVR_Behaviour_Boolean_OnUpdate(){} // RVA: 0x7FFD5408FDD0
        public void SteamVR_Behaviour_Boolean_OnChange(){} // RVA: 0x7FFD5408FE70
        public void GetLocalizedName(){} // RVA: 0x7FFD5408FF10
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Behaviour_BooleanEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059C10
    }

    public class SteamVR_Behaviour_Pose : MonoBehaviour
    {
        public object isValid;
        public object isActive;

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFD54090410
        public void get_isActive(){} // RVA: 0x7FFD5408F3E0
        public void Start(){} // RVA: 0x7FFD54090450
        public void OnEnable(){} // RVA: 0x7FFD540906E0
        public void OnDisable(){} // RVA: 0x7FFD540909D0
        public void SteamVR_Behaviour_Pose_OnUpdate(){} // RVA: 0x7FFD54090D80
        public void UpdateTransform(){} // RVA: 0x7FFD54090E20
        public void SteamVR_Behaviour_Pose_OnChange(){} // RVA: 0x7FFD54091530
        public void OnDeviceConnectedChanged(){} // RVA: 0x7FFD540915B0
        public void OnTrackingChanged(){} // RVA: 0x7FFD54091660
        public void CheckDeviceIndex(){} // RVA: 0x7FFD540916F0
        public void GetDeviceIndex(){} // RVA: 0x7FFD54091960
        public void GetVelocity(){} // RVA: 0x7FFD540919A0
        public void GetAngularVelocity(){} // RVA: 0x7FFD54091A00
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFD54091A60
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFD54091AD0
        public void UpdateHistoryBuffer(){} // RVA: 0x7FFD54091C00
        public void GetLocalizedName(){} // RVA: 0x7FFD54091E20
        public void .ctor(){} // RVA: 0x7FFD54091F60
    }

    public class SteamVR_Behaviour_PoseEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059CA0
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059D30
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059DC0
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059E50
    }

    public class SteamVR_Behaviour_Single : MonoBehaviour
    {
        public object isActive;

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFD54092640
        public void OnEnable(){} // RVA: 0x7FFD54092680
        public void OnDisable(){} // RVA: 0x7FFD54092770
        public void AddHandlers(){} // RVA: 0x7FFD54092780
        public void RemoveHandlers(){} // RVA: 0x7FFD54092940
        public void SteamVR_Behaviour_Single_OnUpdate(){} // RVA: 0x7FFD54092BA0
        public void SteamVR_Behaviour_Single_OnChange(){} // RVA: 0x7FFD54092C60
        public void SteamVR_Behaviour_Single_OnAxis(){} // RVA: 0x7FFD54092D20
        public void GetLocalizedName(){} // RVA: 0x7FFD54092DE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Behaviour_SingleEvent : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059EE0
    }

    public class SteamVR_Behaviour_Skeleton : MonoBehaviour
    {
        public object skeletonAvailable;
        public object isActive;
        public object fingerCurls;
        public object thumbCurl;
        public object indexCurl;
        public object middleCurl;
        public object ringCurl;
        public object pinkyCurl;
        public object root;
        public object wrist;
        public object indexMetacarpal;
        public object indexProximal;
        public object indexMiddle;
        public object indexDistal;
        public object indexTip;
        public object middleMetacarpal;
        public object middleProximal;
        public object middleMiddle;
        public object middleDistal;
        public object middleTip;
        public object pinkyMetacarpal;
        public object pinkyProximal;
        public object pinkyMiddle;
        public object pinkyDistal;
        public object pinkyTip;
        public object ringMetacarpal;
        public object ringProximal;
        public object ringMiddle;
        public object ringDistal;
        public object ringTip;
        public object thumbMetacarpal;
        public object thumbProximal;
        public object thumbMiddle;
        public object thumbDistal;
        public object thumbTip;
        public object thumbAux;
        public object indexAux;
        public object middleAux;
        public object ringAux;
        public object pinkyAux;
        public object proximals;
        public object middles;
        public object distals;
        public object tips;
        public object auxs;
        public object skeletalTrackingLevel;
        public object isBlending;
        public object actionSet;
        public object direction;

        // ── Methods ──
        public void get_skeletonAvailable(){} // RVA: 0x7FFD54093190
        public void get_isActive(){} // RVA: 0x7FFD540931C0
        public void get_fingerCurls(){} // RVA: 0x7FFD54093240
        public void get_thumbCurl(){} // RVA: 0x7FFD54093390
        public void get_indexCurl(){} // RVA: 0x7FFD54093400
        public void get_middleCurl(){} // RVA: 0x7FFD54093470
        public void get_ringCurl(){} // RVA: 0x7FFD540934E0
        public void get_pinkyCurl(){} // RVA: 0x7FFD54093550
        public void get_root(){} // RVA: 0x7FFD540935C0
        public void get_wrist(){} // RVA: 0x7FFD540935F0
        public void get_indexMetacarpal(){} // RVA: 0x7FFD54093620
        public void get_indexProximal(){} // RVA: 0x7FFD54093650
        public void get_indexMiddle(){} // RVA: 0x7FFD54093680
        public void get_indexDistal(){} // RVA: 0x7FFD540936B0
        public void get_indexTip(){} // RVA: 0x7FFD540936E0
        public void get_middleMetacarpal(){} // RVA: 0x7FFD54093710
        public void get_middleProximal(){} // RVA: 0x7FFD54093740
        public void get_middleMiddle(){} // RVA: 0x7FFD54093770
        public void get_middleDistal(){} // RVA: 0x7FFD540937A0
        public void get_middleTip(){} // RVA: 0x7FFD540937D0
        public void get_pinkyMetacarpal(){} // RVA: 0x7FFD54093800
        public void get_pinkyProximal(){} // RVA: 0x7FFD54093830
        public void get_pinkyMiddle(){} // RVA: 0x7FFD54093860
        public void get_pinkyDistal(){} // RVA: 0x7FFD54093890
        public void get_pinkyTip(){} // RVA: 0x7FFD540938C0
        public void get_ringMetacarpal(){} // RVA: 0x7FFD540938F0
        public void get_ringProximal(){} // RVA: 0x7FFD54093920
        public void get_ringMiddle(){} // RVA: 0x7FFD54093950
        public void get_ringDistal(){} // RVA: 0x7FFD54093980
        public void get_ringTip(){} // RVA: 0x7FFD540939B0
        public void get_thumbMetacarpal(){} // RVA: 0x7FFD540939E0
        public void get_thumbProximal(){} // RVA: 0x7FFD540939E0
        public void get_thumbMiddle(){} // RVA: 0x7FFD54093A10
        public void get_thumbDistal(){} // RVA: 0x7FFD54093A40
        public void get_thumbTip(){} // RVA: 0x7FFD54093A70
        public void get_thumbAux(){} // RVA: 0x7FFD54093AA0
        public void get_indexAux(){} // RVA: 0x7FFD54093AD0
        public void get_middleAux(){} // RVA: 0x7FFD54093B00
        public void get_ringAux(){} // RVA: 0x7FFD54093B30
        public void get_pinkyAux(){} // RVA: 0x7FFD54093B60
        public void get_proximals(){} // RVA: 0x7FFD4E3AC120
        public void set_proximals(){} // RVA: 0x7FFD4E3AC130
        public void get_middles(){} // RVA: 0x7FFD4E499460
        public void set_middles(){} // RVA: 0x7FFD4E499470
        public void get_distals(){} // RVA: 0x7FFD4E45E100
        public void set_distals(){} // RVA: 0x7FFD4E45E110
        public void get_tips(){} // RVA: 0x7FFD4E960F70
        public void set_tips(){} // RVA: 0x7FFD4E3C28A0
        public void get_auxs(){} // RVA: 0x7FFD4E3C2900
        public void set_auxs(){} // RVA: 0x7FFD4E3C2910
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFD54093B90
        public void get_isBlending(){} // RVA: 0x7FFD54093C30
        public void get_actionSet(){} // RVA: 0x7FFD5405B470
        public void get_direction(){} // RVA: 0x7FFD5405B4A0
        public void Awake(){} // RVA: 0x7FFD54093C40
        public void CheckSkeletonAction(){} // RVA: 0x7FFD54094870
        public void AssignBonesArray(){} // RVA: 0x7FFD54094A00
        public void OnEnable(){} // RVA: 0x7FFD54094AE0
        public void OnDisable(){} // RVA: 0x7FFD54094EA0
        public void OnDeviceConnectedChanged(){} // RVA: 0x7FFD54095270
        public void OnTrackingChanged(){} // RVA: 0x7FFD54095310
        public void SteamVR_Input_OnSkeletonsUpdated(){} // RVA: 0x7FFD4F37BE50
        public void UpdateSkeleton(){} // RVA: 0x7FFD540953B0
        public void SetTemporaryRangeOfMotion(){} // RVA: 0x7FFD54095640
        public void ResetTemporaryRangeOfMotion(){} // RVA: 0x7FFD540956D0
        public void SetRangeOfMotion(){} // RVA: 0x7FFD540956E0
        public void BlendToSkeleton(){} // RVA: 0x7FFD54095860
        public void BlendToPoser(){} // RVA: 0x7FFD54095A60
        public void BlendToAnimation(){} // RVA: 0x7FFD54095BA0
        public void BlendTo(){} // RVA: 0x7FFD54095BB0
        public void DoBlendRoutine(){} // RVA: 0x7FFD54095DB0
        public void RangeOfMotionBlend(){} // RVA: 0x7FFD54095E70
        public void TemporaryRangeOfMotionBlend(){} // RVA: 0x7FFD54095FF0
        public void ResetTemporaryRangeOfMotionBlend(){} // RVA: 0x7FFD540961E0
        public void DoRangeOfMotionBlend(){} // RVA: 0x7FFD540963B0
        public void GetBlendPoseForBone(){} // RVA: 0x7FFD54096480
        public void UpdateSkeletonTransforms(){} // RVA: 0x7FFD540964D0
        public void SetBonePosition(){} // RVA: 0x7FFD54097420
        public void SetBoneRotation(){} // RVA: 0x7FFD540974C0
        public void GetBone(){} // RVA: 0x7FFD54097550
        public void GetBonePosition(){} // RVA: 0x7FFD540975C0
        public void GetBoneRotation(){} // RVA: 0x7FFD540976E0
        public void GetBonePositions(){} // RVA: 0x7FFD540977F0
        public void GetBoneRotations(){} // RVA: 0x7FFD54097B70
        public void MirrorPosition(){} // RVA: 0x7FFD54097E20
        public void MirrorRotation(){} // RVA: 0x7FFD54097F00
        public void UpdatePose(){} // RVA: 0x7FFD54098150
        public void ForceToReferencePose(){} // RVA: 0x7FFD54098A20
        public void IsMetacarpal(){} // RVA: 0x7FFD54099080
        public void .ctor(){} // RVA: 0x7FFD540990A0
        public void .cctor(){} // RVA: 0x7FFD54099100
    }

    public class SteamVR_Behaviour_SkeletonCustom : SteamVR_Behaviour_Skeleton
    {
        // ── Methods ──
        public void AssignBonesArray(){} // RVA: 0x7FFD5409A500
        public void .ctor(){} // RVA: 0x7FFD5409ADB0
    }

    public class SteamVR_Behaviour_SkeletonEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54059F70
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5405A000
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5405A090
    }

    public class SteamVR_Behaviour_Vector2 : MonoBehaviour
    {
        public object isActive;

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFD54092640
        public void OnEnable(){} // RVA: 0x7FFD5409AE50
        public void OnDisable(){} // RVA: 0x7FFD5409AF40
        public void AddHandlers(){} // RVA: 0x7FFD5409AF50
        public void RemoveHandlers(){} // RVA: 0x7FFD5409B110
        public void SteamVR_Behaviour_Vector2_OnUpdate(){} // RVA: 0x7FFD5409B370
        public void SteamVR_Behaviour_Vector2_OnChange(){} // RVA: 0x7FFD5409B430
        public void SteamVR_Behaviour_Vector2_OnAxis(){} // RVA: 0x7FFD5409B4F0
        public void GetLocalizedName(){} // RVA: 0x7FFD5409B5B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Behaviour_Vector2Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5405A120
    }

    public class SteamVR_Behaviour_Vector3 : MonoBehaviour
    {
        public object isActive;

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFD54092640
        public void OnEnable(){} // RVA: 0x7FFD5409B960
        public void OnDisable(){} // RVA: 0x7FFD5409BA50
        public void AddHandlers(){} // RVA: 0x7FFD5409BA60
        public void RemoveHandlers(){} // RVA: 0x7FFD5409BC20
        public void SteamVR_Behaviour_Vector3_OnUpdate(){} // RVA: 0x7FFD5409BE80
        public void SteamVR_Behaviour_Vector3_OnChange(){} // RVA: 0x7FFD5409BF90
        public void SteamVR_Behaviour_Vector3_OnAxis(){} // RVA: 0x7FFD5409C0A0
        public void GetLocalizedName(){} // RVA: 0x7FFD5409C1B0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Behaviour_Vector3Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5405A1B0
    }

    public class SteamVR_Camera : MonoBehaviour
    {
        public object head;
        public object offset;
        public object origin;
        public object camera;
        public object ears;
        public object sceneResolutionScale;
        public object baseName;

        // ── Methods ──
        public void get_head(){} // RVA: 0x7FFD4E36F0C0
        public void get_offset(){} // RVA: 0x7FFD4E36F0C0
        public void get_origin(){} // RVA: 0x7FFD540B6990
        public void get_camera(){} // RVA: 0x7FFD4E36F130
        public void set_camera(){} // RVA: 0x7FFD4E342E90
        public void get_ears(){} // RVA: 0x7FFD4E5F95E0
        public void GetRay(){} // RVA: 0x7FFD540B69F0
        public void get_sceneResolutionScale(){} // RVA: 0x7FFD540B6B50
        public void set_sceneResolutionScale(){} // RVA: 0x7FFD540B6BA0
        public void OnDisable(){} // RVA: 0x7FFD540B6C00
        public void OnEnable(){} // RVA: 0x7FFD540B6D60
        public void Awake(){} // RVA: 0x7FFD540B77F0
        public void ForceLast(){} // RVA: 0x7FFD540B7880
        public void get_baseName(){} // RVA: 0x7FFD540B81D0
        public void Expand(){} // RVA: 0x7FFD540B8290
        public void Collapse(){} // RVA: 0x7FFD540B9960
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_CameraFlip : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540BA750
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_CameraHelper : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD54059A60
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_CameraMask : MonoBehaviour
    {
        public ePathName117.? ÏÎÎÌÌÎÎÏÏÎÍÎÌÌÌÌÏÌÍÌÏÏÍ; // 0x20
        public ePathName117.? ÎÏÏÌÍÏÌÍÌÎÎÏÌÎÍÍÌÎÎÎÏÍÌ; // 0x28
        public ePathName117.? ÏÍÎÍÍÏÌÌÎÎÌÏÎÎÎÍÏÍÏÌÍÏÎ; // 0x30
        public gField.ldKeyboardOverride ÏÎÏÌÎÌÎÏÌÌÍÏÏÍÏÍÌÏÌÏÍÍÏ; // 0x38
        public gField.ldKeyboardOverride ÍÍÎÌÍÎÍÏÍÌÏÍÌÍÎÌÎÌÏÎÏÌÎ; // 0x40
        public object ÎÌÌÍÍÏÌÎÌÍÌÍÏÏÌÌÍÍÎÏÏÏÌ; // 0x48

        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540BA7F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Ears : MonoBehaviour
    {
        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x7FFD540BA890
        public void OnEnable(){} // RVA: 0x7FFD540BAC60
        public void OnDisable(){} // RVA: 0x7FFD540BAFE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Events : Object
    {
        // ── Methods ──
        public void CalibratingAction(){} // RVA: 0x7FFD540BB0E0
        public void DeviceConnectedAction(){} // RVA: 0x7FFD540BB190
        public void FadeAction(){} // RVA: 0x7FFD540BB2E0
        public void FadeReadyAction(){} // RVA: 0x7FFD540BB430
        public void HideRenderModelsAction(){} // RVA: 0x7FFD540BB4E0
        public void InitializingAction(){} // RVA: 0x7FFD540BB590
        public void InputFocusAction(){} // RVA: 0x7FFD540BB640
        public void LoadingAction(){} // RVA: 0x7FFD540BB6F0
        public void LoadingFadeInAction(){} // RVA: 0x7FFD540BB7A0
        public void LoadingFadeOutAction(){} // RVA: 0x7FFD540BB850
        public void NewPosesAction(){} // RVA: 0x7FFD540BB900
        public void NewPosesAppliedAction(){} // RVA: 0x7FFD540BB9C0
        public void InitializedAction(){} // RVA: 0x7FFD540BBA70
        public void OutOfRangeAction(){} // RVA: 0x7FFD540BBB20
        public void RenderModelLoadedAction(){} // RVA: 0x7FFD540BBBD0
        public void System(){} // RVA: 0x7FFD540BBD20
        public void SystemAction(){} // RVA: 0x7FFD540BBED0
        public void .cctor(){} // RVA: 0x7FFD540BC010
    }

    public class SteamVR_ExternalCamera : MonoBehaviour
    {
        // ── Methods ──
        public void ReadConfig(){} // RVA: 0x7FFD540BCC50
        public void SetupPose(){} // RVA: 0x7FFD540BD690
        public void SetupDeviceIndex(){} // RVA: 0x7FFD540BD810
        public void OnChanged(){} // RVA: 0x7FFD540BD8C0
        public void AttachToCamera(){} // RVA: 0x7FFD540BD8D0
        public void GetTargetDistance(){} // RVA: 0x7FFD540BEE00
        public void RenderNear(){} // RVA: 0x7FFD540BF350
        public void RenderFar(){} // RVA: 0x7FFD540C04D0
        public void OnGUI(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD540C0790
        public void AutoEnableActionSet(){} // RVA: 0x7FFD540C0CC0
        public void OnDisable(){} // RVA: 0x7FFD540C0E50
        public void .ctor(){} // RVA: 0x7FFD540C11E0
    }

    public class SteamVR_ExternalCamera_LegacyManager : Object
    {
        public object hasCamera;

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x7FFD540C1240
        public void SubscribeToNewPoses(){} // RVA: 0x7FFD540C12A0
        public void OnNewPoses(){} // RVA: 0x7FFD540C1440
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD540C1570
    }

    public class SteamVR_Fade : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD540C1620
        public void View(){} // RVA: 0x7FFD540C16F0
        public void OnStartFade(){} // RVA: 0x7FFD540C1770
        public void OnEnable(){} // RVA: 0x7FFD540C1820
        public void OnDisable(){} // RVA: 0x7FFD540C1B30
        public void OnPostRender(){} // RVA: 0x7FFD540C1C30
        public void .ctor(){} // RVA: 0x7FFD540C2170
        public void .cctor(){} // RVA: 0x7FFD540C21D0
    }

    public class SteamVR_Frustum : MonoBehaviour
    {
        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x7FFD540C2280
        public void OnDeviceConnected(){} // RVA: 0x7FFD540C2CB0
        public void OnEnable(){} // RVA: 0x7FFD540C2F50
        public void OnDisable(){} // RVA: 0x7FFD540C30A0
        public void .ctor(){} // RVA: 0x7FFD540C3220
    }

    public class SteamVR_IK : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFD540C3290
        public void Solve(){} // RVA: 0x7FFD540C4BC0
        public void .ctor(){} // RVA: 0x7FFD540C5260
    }

    public class SteamVR_Input : Object
    {
        public object isStartupFrame;

        // ── Methods ──
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x7FFD5409C560
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x7FFD5409C6B0
        public void add_onPosesUpdated(){} // RVA: 0x7FFD5409C800
        public void remove_onPosesUpdated(){} // RVA: 0x7FFD5409C950
        public void add_onSkeletonsUpdated(){} // RVA: 0x7FFD5409CAA0
        public void remove_onSkeletonsUpdated(){} // RVA: 0x7FFD5409CBF0
        public void get_isStartupFrame(){} // RVA: 0x7FFD5409CD40
        public void .cctor(){} // RVA: 0x7FFD5409CE60
        public void ForcePreinitialize(){} // RVA: 0x7FFD5409D480
        public void FindPreinitializeMethod(){} // RVA: 0x7FFD5409D4D0
        public void Initialize(){} // RVA: 0x7FFD5409D6B0
        public void PreinitializeFinishActionSets(){} // RVA: 0x7FFD5409DC40
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x7FFD5409DD10
        public void PreinitializeActionDictionaries(){} // RVA: 0x7FFD5409DFB0
        public void Update(){} // RVA: 0x7FFD5409E220
        public void LateUpdate(){} // RVA: 0x7FFD5409E340
        public void FixedUpdate(){} // RVA: 0x7FFD5409E480
        public void OnPreCull(){} // RVA: 0x7FFD5409E5A0
        public void UpdateVisualActions(){} // RVA: 0x7FFD5409E6C0
        public void UpdatePoseActions(){} // RVA: 0x7FFD5409E8C0
        public void UpdateSkeletonActions(){} // RVA: 0x7FFD5409EA40
        public void UpdateNonVisualActions(){} // RVA: 0x7FFD5409EBC0
        public void ShowBindingHintsForSets(){} // RVA: 0x7FFD5409EDE0
        public void ShowBindingHints(){} // RVA: 0x7FFD5409F140 | overloaded x2
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x7FFD5409F220
        public void GetActionDataFromPath(){} // RVA: 0x7FFD4E2ADC40
        public void GetActionSetDataFromPath(){} // RVA: 0x7FFD5409F3D0
        public void GetActionFromPath(){} // RVA: 0x7FFD4E2ADC40
        public void GetBaseActionFromPath(){} // RVA: 0x7FFD5409F480
        public void HasActionPath(){} // RVA: 0x7FFD5409F8D0
        public void HasAction(){} // RVA: 0x7FFD5409FAF0 | overloaded x2
        public void GetBooleanActionFromPath(){} // RVA: 0x7FFD5409FC00
        public void GetSingleActionFromPath(){} // RVA: 0x7FFD5409FC80
        public void GetVector2ActionFromPath(){} // RVA: 0x7FFD5409FD00
        public void GetVector3ActionFromPath(){} // RVA: 0x7FFD5409FD80
        public void GetVibrationActionFromPath(){} // RVA: 0x7FFD5409FE00
        public void GetPoseActionFromPath(){} // RVA: 0x7FFD5409FE80
        public void GetSkeletonActionFromPath(){} // RVA: 0x7FFD5409FF00
        public void GetAction(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetBaseAction(){} // RVA: 0x7FFD5409FF80
        public void CreateFakeAction(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetBooleanAction(){} // RVA: 0x7FFD540A04E0 | overloaded x2
        public void GetSingleAction(){} // RVA: 0x7FFD540A05F0 | overloaded x2
        public void GetVector2Action(){} // RVA: 0x7FFD540A0700 | overloaded x2
        public void GetVector3Action(){} // RVA: 0x7FFD540A0810 | overloaded x2
        public void GetPoseAction(){} // RVA: 0x7FFD540A0920 | overloaded x2
        public void GetSkeletonAction(){} // RVA: 0x7FFD540A0A30 | overloaded x2
        public void GetVibrationAction(){} // RVA: 0x7FFD540A0B40 | overloaded x2
        public void GetActionSet(){} // RVA: 0x7FFD540A0BC0 | overloaded x2
        public void HasActionSet(){} // RVA: 0x7FFD540A0C50
        public void GetActionSetFromPath(){} // RVA: 0x7FFD540A0CF0 | overloaded x2
        public void GetState(){} // RVA: 0x7FFD540A0ED0 | overloaded x2
        public void GetStateDown(){} // RVA: 0x7FFD540A11C0 | overloaded x2
        public void GetStateUp(){} // RVA: 0x7FFD540A14B0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFD540A17A0 | overloaded x2
        public void GetSingle(){} // RVA: 0x7FFD540A1980 | overloaded x2
        public void GetVector2(){} // RVA: 0x7FFD540A1B90 | overloaded x2
        public void GetVector3(){} // RVA: 0x7FFD540A1F30 | overloaded x2
        public void GetActionSets(){} // RVA: 0x7FFD540A1FD0
        public void GetActions(){} // RVA: 0x7FFD4E078A90
        public void ShouldMakeCopy(){} // RVA: 0x7FFD540A2030
        public void GetLocalizedName(){} // RVA: 0x7FFD540A2090
        public void CheckOldLocation(){} // RVA: 0x7FFD4E341320
        public void IdentifyActionsFile(){} // RVA: 0x7FFD540A21E0
        public void HasFileInMemoryBeenModified(){} // RVA: 0x7FFD540A2570
        public void CreateEmptyActionsFile(){} // RVA: 0x7FFD540A2740
        public void DoesActionsFileExist(){} // RVA: 0x7FFD540A2DF0
        public void InitializeFile(){} // RVA: 0x7FFD540A2E50
        public void GetActionsFileFolder(){} // RVA: 0x7FFD540A3270
        public void GetActionsFilePath(){} // RVA: 0x7FFD540A3380
        public void GetActionsFileName(){} // RVA: 0x7FFD540A3620
        public void DeleteManifestAndBindings(){} // RVA: 0x7FFD540A3680
        public void OpenBindingUI(){} // RVA: 0x7FFD540A3AF0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_ActionFile : Object
    {
        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x7FFD540A3D00
        public void SaveHelperLists(){} // RVA: 0x7FFD540A43B0
        public void GetShortName(){} // RVA: 0x7FFD540A4BF0
        public void GetCodeFriendlyName(){} // RVA: 0x7FFD540A4C90
        public void GetFilesToCopy(){} // RVA: 0x7FFD540A4E40
        public void CopyFilesToPath(){} // RVA: 0x7FFD540A51C0
        public void RemoveAppKey(){} // RVA: 0x7FFD540A5490
        public void Open(){} // RVA: 0x7FFD540A5610
        public void Save(){} // RVA: 0x7FFD540A5710
        public void .ctor(){} // RVA: 0x7FFD540A5890
    }

    public class SteamVR_Input_ActionSet_Action_Menu : SteamVR_ActionSet
    {
        public object Axis;
        public object Select;
        public object Gesture_Activator_Thumb;
        public object Gesture_Activator_Thumb_Inner_Upper;
        public object Gesture_Activator_Thumb_Inner_Lower;
        public object Gesture_Activator_Thumb_Outer;
        public object Gesture_Activator_Index;
        public object Gesture_Activator_Grip;
        public object Gesture_Trigger_Axis;
        public object Gesture_Grip_Axis;
        public object Gesture_Activator_Stick_Deflection;
        public object Gesture_Wheel_Left;
        public object Gesture_Wheel_Select_Left;
        public object Gesture_Wheel_Soft_Select_Left;
        public object Gesture_Wheel_Weight_Left;
        public object Gesture_Wheel_Direct_Left;
        public object Gesture_Wheel_Direct_Stay_Left;
        public object Gesture_Wheel_Cancel_Left;
        public object Gesture_Wheel_Cancel_Open_Left;
        public object Gesture_Wheel_Held_Left;
        public object Gesture_Wheel_Right;
        public object Gesture_Wheel_Select_Right;
        public object Gesture_Wheel_Soft_Select_Right;
        public object Gesture_Wheel_Weight_Right;
        public object Gesture_Wheel_Direct_Right;
        public object Gesture_Wheel_Direct_Stay_Right;
        public object Gesture_Wheel_Cancel_Right;
        public object Gesture_Wheel_Cancel_Open_Right;
        public object Gesture_Wheel_Held_Right;
        public object Disable_Gesture_Wheel_Move_Left;
        public object Disable_Gesture_Wheel_Rotate_Left;
        public object Disable_Gesture_Wheel_Move_Right;
        public object Disable_Gesture_Wheel_Rotate_Right;
        public object Reserve_bool;
        public object Reserve_vector1;
        public object Reserve_vector2;
        public object Grab;
        public object Drop;

        // ── Methods ──
        public void get_Axis(){} // RVA: 0x7FFD54072E50
        public void get_Select(){} // RVA: 0x7FFD54072E60
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFD54072E70
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFD54072E80
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFD54072E90
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFD54072EA0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFD54072EB0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFD54072EC0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFD54072ED0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFD54072EE0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFD54072EF0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFD54072F00
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFD54072F10
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFD54072F20
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFD54072F30
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFD54072F40
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFD54072F50
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFD54072F60
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFD54072F70
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFD54072F80
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFD54072F90
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFD54072FA0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFD54072FB0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFD54072FC0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD54072FD0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFD54072FE0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFD54072FF0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFD54073000
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFD54073010
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFD54073020
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFD54073030
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFD54073040
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD54073050
        public void get_Reserve_bool(){} // RVA: 0x7FFD54073060
        public void get_Reserve_vector1(){} // RVA: 0x7FFD54073070
        public void get_Reserve_vector2(){} // RVA: 0x7FFD54073080
        public void get_Grab(){} // RVA: 0x7FFD54073090
        public void get_Drop(){} // RVA: 0x7FFD540730A0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_ActionSet_Drone : SteamVR_ActionSet
    {
        public object Left_Joystick;
        public object Right_Joystick;
        public object Self_Leveling_Mod;
        public object Hold_Altitude_Mod;
        public object Toggle_FPV;
        public object Flip;
        public object Take_Picture;
        public object Cycle_Flight_Preset;
        public object Toggle_Self_Leveling;
        public object Respawn;
        public object Select_Flight_Preset_Micro;
        public object Select_Flight_Preset_Cinematic;
        public object Select_Flight_Preset_Racing;
        public object Select_Flight_Preset_Freestyle;

        // ── Methods ──
        public void get_Left_Joystick(){} // RVA: 0x7FFD540730B0
        public void get_Right_Joystick(){} // RVA: 0x7FFD540730C0
        public void get_Self_Leveling_Mod(){} // RVA: 0x7FFD540730D0
        public void get_Hold_Altitude_Mod(){} // RVA: 0x7FFD540730E0
        public void get_Toggle_FPV(){} // RVA: 0x7FFD540730F0
        public void get_Flip(){} // RVA: 0x7FFD54073100
        public void get_Take_Picture(){} // RVA: 0x7FFD54073110
        public void get_Cycle_Flight_Preset(){} // RVA: 0x7FFD54073120
        public void get_Toggle_Self_Leveling(){} // RVA: 0x7FFD54073130
        public void get_Respawn(){} // RVA: 0x7FFD54073140
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x7FFD54073150
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFD54073160
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x7FFD54073170
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFD54073180
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_ActionSet_Global : SteamVR_ActionSet
    {
        public object Safe_Mode;
        public object Pose;
        public object SkeletonLeftHand;
        public object SkeletonRightHand;
        public object HeadsetOnHead;
        public object Menu;
        public object Quick_Menu;
        public object Action_Menu;
        public object Main_Menu;
        public object Interact;
        public object Grab;
        public object Move;
        public object Jump;
        public object Rotate;
        public object Mic;
        public object Gesture_Toggle;
        public object Stick_Click;
        public object Trigger_Axis;
        public object Grip_Axis;
        public object Udon_Menu;
        public object Drop;
        public object Nameplates;
        public object HUD;
        public object Chatbox;
        public object Face_Mirror;
        public object Personal_Mirror;
        public object Personal_Mirror_Lock;
        public object Earmuffs;
        public object Camera;
        public object Stream_Camera;
        public object Avatar_Debug_Screen;
        public object OSC_Debug_Screen;
        public object Confirm_FBT_Calibration;
        public object Start_Move;
        public object Start_Rotate;
        public object Continue_Move;
        public object Continue_Rotate;
        public object No_Gesture_After_Move;
        public object No_Gesture_After_Rotate;
        public object Gesture_Activator_Thumb;
        public object Gesture_Activator_Thumb_Inner_Upper;
        public object Gesture_Activator_Thumb_Inner_Lower;
        public object Gesture_Activator_Thumb_Outer;
        public object Gesture_Activator_Index;
        public object Gesture_Activator_Grip;
        public object Gesture_Trigger_Axis;
        public object Gesture_Grip_Axis;
        public object Gesture_Activator_Stick_Deflection;
        public object Gesture_Direct_Neutral_Left;
        public object Gesture_Direct_Fist_Left;
        public object Gesture_Direct_Open_Left;
        public object Gesture_Direct_Peace_Left;
        public object Gesture_Direct_Horns_Left;
        public object Gesture_Direct_Finger_Gun_Left;
        public object Gesture_Direct_Thumbs_Up_Left;
        public object Gesture_Direct_Point_Left;
        public object Gesture_Direct_Neutral_Right;
        public object Gesture_Direct_Fist_Right;
        public object Gesture_Direct_Open_Right;
        public object Gesture_Direct_Peace_Right;
        public object Gesture_Direct_Horns_Right;
        public object Gesture_Direct_Finger_Gun_Right;
        public object Gesture_Direct_Thumbs_Up_Right;
        public object Gesture_Direct_Point_Right;
        public object Gesture_Wheel_Left;
        public object Gesture_Wheel_Select_Left;
        public object Gesture_Wheel_Soft_Select_Left;
        public object Gesture_Wheel_Weight_Left;
        public object Gesture_Wheel_Direct_Left;
        public object Gesture_Wheel_Direct_Stay_Left;
        public object Gesture_Wheel_Cancel_Left;
        public object Gesture_Wheel_Cancel_Open_Left;
        public object Gesture_Wheel_Held_Left;
        public object Gesture_Wheel_Right;
        public object Gesture_Wheel_Select_Right;
        public object Gesture_Wheel_Soft_Select_Right;
        public object Gesture_Wheel_Weight_Right;
        public object Gesture_Wheel_Direct_Right;
        public object Gesture_Wheel_Direct_Stay_Right;
        public object Gesture_Wheel_Cancel_Right;
        public object Gesture_Wheel_Cancel_Open_Right;
        public object Gesture_Wheel_Held_Right;
        public object Disable_Gesture_Tracked;
        public object Disable_Gesture_Wheel_Move_Left;
        public object Disable_Gesture_Wheel_Rotate_Left;
        public object Disable_Gesture_Wheel_Move_Right;
        public object Disable_Gesture_Wheel_Rotate_Right;
        public object Physbone_Grab_Left;
        public object Physbone_Freeze_Left;
        public object Physbone_Grab_Right;
        public object Physbone_Freeze_Right;
        public object Scroll;
        public object Haptic;

        // ── Methods ──
        public void get_Safe_Mode(){} // RVA: 0x7FFD54073190
        public void get_Pose(){} // RVA: 0x7FFD540731A0
        public void get_SkeletonLeftHand(){} // RVA: 0x7FFD540731B0
        public void get_SkeletonRightHand(){} // RVA: 0x7FFD540731C0
        public void get_HeadsetOnHead(){} // RVA: 0x7FFD540731D0
        public void get_Menu(){} // RVA: 0x7FFD540731E0
        public void get_Quick_Menu(){} // RVA: 0x7FFD540731F0
        public void get_Action_Menu(){} // RVA: 0x7FFD54073200
        public void get_Main_Menu(){} // RVA: 0x7FFD54073210
        public void get_Interact(){} // RVA: 0x7FFD54073220
        public void get_Grab(){} // RVA: 0x7FFD54073230
        public void get_Move(){} // RVA: 0x7FFD54073240
        public void get_Jump(){} // RVA: 0x7FFD54073250
        public void get_Rotate(){} // RVA: 0x7FFD54073260
        public void get_Mic(){} // RVA: 0x7FFD54073270
        public void get_Gesture_Toggle(){} // RVA: 0x7FFD54073280
        public void get_Stick_Click(){} // RVA: 0x7FFD54073290
        public void get_Trigger_Axis(){} // RVA: 0x7FFD540732A0
        public void get_Grip_Axis(){} // RVA: 0x7FFD540732B0
        public void get_Udon_Menu(){} // RVA: 0x7FFD540732C0
        public void get_Drop(){} // RVA: 0x7FFD540732D0
        public void get_Nameplates(){} // RVA: 0x7FFD540732E0
        public void get_HUD(){} // RVA: 0x7FFD540732F0
        public void get_Chatbox(){} // RVA: 0x7FFD54073300
        public void get_Face_Mirror(){} // RVA: 0x7FFD54073310
        public void get_Personal_Mirror(){} // RVA: 0x7FFD54073320
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFD54073330
        public void get_Earmuffs(){} // RVA: 0x7FFD54073340
        public void get_Camera(){} // RVA: 0x7FFD54073350
        public void get_Stream_Camera(){} // RVA: 0x7FFD54073360
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFD54073370
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFD54073380
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFD54073390
        public void get_Start_Move(){} // RVA: 0x7FFD540733A0
        public void get_Start_Rotate(){} // RVA: 0x7FFD540733B0
        public void get_Continue_Move(){} // RVA: 0x7FFD540733C0
        public void get_Continue_Rotate(){} // RVA: 0x7FFD540733D0
        public void get_No_Gesture_After_Move(){} // RVA: 0x7FFD540733E0
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x7FFD540733F0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFD54073400
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFD54073410
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFD54073420
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFD54073430
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFD54073440
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFD54073450
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFD54073460
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFD54073470
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFD54073480
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFD54073490
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFD540734A0
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x7FFD540734B0
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFD540734C0
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFD540734D0
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFD540734E0
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFD540734F0
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x7FFD54073500
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFD54073510
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFD54073520
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x7FFD54073530
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFD54073540
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFD54073550
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFD54073560
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFD54073570
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x7FFD54073580
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFD54073590
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFD540735A0
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFD540735B0
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFD540735C0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFD540735D0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFD540735E0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFD540735F0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFD54073600
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFD54073610
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFD54073620
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFD54073630
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFD54073640
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFD54073650
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD54073660
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFD54073670
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFD54073680
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFD54073690
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFD540736A0
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x7FFD540736B0
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFD540736C0
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFD540736D0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFD540736E0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD540736F0
        public void get_Physbone_Grab_Left(){} // RVA: 0x7FFD54073700
        public void get_Physbone_Freeze_Left(){} // RVA: 0x7FFD54073710
        public void get_Physbone_Grab_Right(){} // RVA: 0x7FFD54073720
        public void get_Physbone_Freeze_Right(){} // RVA: 0x7FFD54073730
        public void get_Scroll(){} // RVA: 0x7FFD54073740
        public void get_Haptic(){} // RVA: 0x7FFD54073750
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_ActionSet_Menu : SteamVR_ActionSet
    {
        public object Confirm;
        public object Back;
        public object Tab;
        public object Scroll;
        public object Quick_Menu_Close;
        public object Drag;

        // ── Methods ──
        public void get_Confirm(){} // RVA: 0x7FFD54073760
        public void get_Back(){} // RVA: 0x7FFD54073770
        public void get_Tab(){} // RVA: 0x7FFD54073780
        public void get_Scroll(){} // RVA: 0x7FFD54073790
        public void get_Quick_Menu_Close(){} // RVA: 0x7FFD540737A0
        public void get_Drag(){} // RVA: 0x7FFD540737B0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_ActionSet_One_Hand : SteamVR_ActionSet
    {
        public object Interact;
        public object Grab;
        public object Move_Rotate;
        public object Jump;
        public object Mic;
        public object Gesture_Toggle;
        public object Stick_Click;
        public object Trigger_Axis;
        public object Grip_Axis;
        public object Udon_Menu;
        public object Drop;
        public object Start_Move_Rotate;
        public object Continue_Move_Rotate;
        public object No_Gesture_After_Move_Rotate;
        public object Menu;
        public object Nameplates;
        public object HUD;
        public object Chatbox;
        public object Face_Mirror;
        public object Personal_Mirror;
        public object Personal_Mirror_Lock;
        public object Earmuffs;
        public object Camera;
        public object Stream_Camera;
        public object Avatar_Debug_Screen;
        public object OSC_Debug_Screen;
        public object Confirm_FBT_Calibration;
        public object Gesture_Activator_Thumb;
        public object Gesture_Activator_Thumb_Inner_Upper;
        public object Gesture_Activator_Thumb_Inner_Lower;
        public object Gesture_Activator_Thumb_Outer;
        public object Gesture_Activator_Index;
        public object Gesture_Activator_Grip;
        public object Gesture_Trigger_Axis;
        public object Gesture_Grip_Axis;
        public object Gesture_Activator_Stick_Deflection;
        public object Gesture_Wheel_Left;
        public object Gesture_Wheel_Select_Left;
        public object Gesture_Wheel_Soft_Select_Left;
        public object Gesture_Wheel_Weight_Left;
        public object Gesture_Wheel_Direct_Left;
        public object Gesture_Wheel_Direct_Stay_Left;
        public object Gesture_Wheel_Cancel_Left;
        public object Gesture_Wheel_Cancel_Open_Left;
        public object Gesture_Wheel_Held_Left;
        public object Gesture_Wheel_Right;
        public object Gesture_Wheel_Select_Right;
        public object Gesture_Wheel_Soft_Select_Right;
        public object Gesture_Wheel_Weight_Right;
        public object Gesture_Wheel_Direct_Right;
        public object Gesture_Wheel_Direct_Stay_Right;
        public object Gesture_Wheel_Cancel_Right;
        public object Gesture_Wheel_Cancel_Open_Right;
        public object Gesture_Wheel_Held_Right;
        public object Disable_Gesture_Wheel_Move_Left;
        public object Disable_Gesture_Wheel_Rotate_Left;
        public object Disable_Gesture_Wheel_Move_Right;
        public object Disable_Gesture_Wheel_Rotate_Right;
        public object Reserve_bool;
        public object Reserve_vector1;
        public object Reserve_vector2;

        // ── Methods ──
        public void get_Interact(){} // RVA: 0x7FFD540737C0
        public void get_Grab(){} // RVA: 0x7FFD540737D0
        public void get_Move_Rotate(){} // RVA: 0x7FFD540737E0
        public void get_Jump(){} // RVA: 0x7FFD540737F0
        public void get_Mic(){} // RVA: 0x7FFD54073800
        public void get_Gesture_Toggle(){} // RVA: 0x7FFD54073810
        public void get_Stick_Click(){} // RVA: 0x7FFD54073820
        public void get_Trigger_Axis(){} // RVA: 0x7FFD54073830
        public void get_Grip_Axis(){} // RVA: 0x7FFD54073840
        public void get_Udon_Menu(){} // RVA: 0x7FFD54073850
        public void get_Drop(){} // RVA: 0x7FFD54073860
        public void get_Start_Move_Rotate(){} // RVA: 0x7FFD54073870
        public void get_Continue_Move_Rotate(){} // RVA: 0x7FFD54073880
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFD54073890
        public void get_Menu(){} // RVA: 0x7FFD540738A0
        public void get_Nameplates(){} // RVA: 0x7FFD540738B0
        public void get_HUD(){} // RVA: 0x7FFD540738C0
        public void get_Chatbox(){} // RVA: 0x7FFD540738D0
        public void get_Face_Mirror(){} // RVA: 0x7FFD540738E0
        public void get_Personal_Mirror(){} // RVA: 0x7FFD540738F0
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFD54073900
        public void get_Earmuffs(){} // RVA: 0x7FFD54073910
        public void get_Camera(){} // RVA: 0x7FFD54073920
        public void get_Stream_Camera(){} // RVA: 0x7FFD54073930
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFD54073940
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFD54073950
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFD54073960
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFD54073970
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFD54073980
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFD54073990
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFD540739A0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFD540739B0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFD540739C0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFD540739D0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFD540739E0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFD540739F0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFD54073A00
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFD54073A10
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFD54073A20
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFD54073A30
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFD54073A40
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFD54073A50
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFD54073A60
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFD54073A70
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFD54073A80
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFD54073A90
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFD54073AA0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFD54073AB0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFD54073AC0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFD54073AD0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFD54073AE0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFD54073AF0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFD54073B00
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFD54073B10
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFD54073B20
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFD54073B30
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFD54073B40
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFD54073B50
        public void get_Reserve_bool(){} // RVA: 0x7FFD54073B60
        public void get_Reserve_vector1(){} // RVA: 0x7FFD54073B70
        public void get_Reserve_vector2(){} // RVA: 0x7FFD54073B80
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_BindingFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD540A92D0
    }

    public class SteamVR_Input_Generator_Names : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_Source : Object
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7FFD540AAA30
        public void GetSource(){} // RVA: 0x7FFD540AAAE0
        public void GetAllSources(){} // RVA: 0x7FFD540AAC70
        public void GetPath(){} // RVA: 0x7FFD540AAF10
        public void Initialize(){} // RVA: 0x7FFD540AB050
        public void .cctor(){} // RVA: 0x7FFD540AB8E0
    }

    public class SteamVR_LoadLevel : MonoBehaviour
    {
        public object loading;
        public object progress;
        public object progressTexture;

        // ── Methods ──
        public void get_loading(){} // RVA: 0x7FFD540C52B0
        public void get_progress(){} // RVA: 0x7FFD540C53A0
        public void get_progressTexture(){} // RVA: 0x7FFD540C5500
        public void OnEnable(){} // RVA: 0x7FFD540C5610
        public void Trigger(){} // RVA: 0x7FFD540C5630
        public void Begin(){} // RVA: 0x7FFD540C57D0
        public void OnGUI(){} // RVA: 0x7FFD540C5940
        public void Update(){} // RVA: 0x7FFD540C60D0
        public void LoadLevel(){} // RVA: 0x7FFD540C6330
        public void GetOverlayHandle(){} // RVA: 0x7FFD540C63D0
        public void .ctor(){} // RVA: 0x7FFD540C6A10
    }

    public class SteamVR_Menu : MonoBehaviour
    {
        public object texture;
        public object scale;

        // ── Methods ──
        public void get_texture(){} // RVA: 0x7FFD540C8070
        public void get_scale(){} // RVA: 0x7FFD4E36A0C0
        public void set_scale(){} // RVA: 0x7FFD4E36A0D0
        public void Awake(){} // RVA: 0x7FFD540C81C0
        public void OnGUI(){} // RVA: 0x7FFD540C8510
        public void ShowMenu(){} // RVA: 0x7FFD540C9C60
        public void HideMenu(){} // RVA: 0x7FFD540CA340
        public void Update(){} // RVA: 0x7FFD540CA600
        public void SetScale(){} // RVA: 0x7FFD540CA8A0
        public void SaveCursorState(){} // RVA: 0x7FFD540CAA30
        public void RestoreCursorState(){} // RVA: 0x7FFD540CAAD0
        public void .ctor(){} // RVA: 0x7FFD540CAB80
    }

    public class SteamVR_Overlay : MonoBehaviour
    {
        public object instance;
        public object key;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD540CABE0
        public void set_instance(){} // RVA: 0x7FFD540CAC20
        public void get_key(){} // RVA: 0x7FFD540CACC0
        public void OnEnable(){} // RVA: 0x7FFD540CADD0
        public void OnDisable(){} // RVA: 0x7FFD540CAFB0
        public void UpdateOverlay(){} // RVA: 0x7FFD540CB010
        public void PollNextEvent(){} // RVA: 0x7FFD540CB6D0
        public void ComputeIntersection(){} // RVA: 0x7FFD540CB7E0
        public void .ctor(){} // RVA: 0x7FFD540CB9C0
    }

    public class SteamVR_PlayArea : MonoBehaviour
    {
        // ── Methods ──
        public void GetBounds(){} // RVA: 0x7FFD540CBA40
        public void BuildMesh(){} // RVA: 0x7FFD540CBD50
        public void OnDrawGizmos(){} // RVA: 0x7FFD540CCB20
        public void OnDrawGizmosSelected(){} // RVA: 0x7FFD540CCB30
        public void DrawWireframe(){} // RVA: 0x7FFD540CCB40
        public void OnEnable(){} // RVA: 0x7FFD540CD110
        public void UpdateBounds(){} // RVA: 0x7FFD540CD320
        public void .ctor(){} // RVA: 0x7FFD540CD3C0
    }

    public class SteamVR_Render : MonoBehaviour
    {
        public object eye;
        public object instance;
        public object pauseRendering;

        // ── Methods ──
        public void get_eye(){} // RVA: 0x7FFD540CD680
        public void set_eye(){} // RVA: 0x7FFD540CD6C0
        public void get_instance(){} // RVA: 0x7FFD540CD700
        public void OnApplicationQuit(){} // RVA: 0x7FFD540CD760
        public void Add(){} // RVA: 0x7FFD540CD7D0
        public void Remove(){} // RVA: 0x7FFD540B6C00
        public void Top(){} // RVA: 0x7FFD540CD880
        public void AddInternal(){} // RVA: 0x7FFD540CD940
        public void RemoveInternal(){} // RVA: 0x7FFD540CDBD0
        public void TopInternal(){} // RVA: 0x7FFD540CDF60
        public void get_pauseRendering(){} // RVA: 0x7FFD540CDFA0
        public void set_pauseRendering(){} // RVA: 0x7FFD540CDFE0
        public void RenderLoop(){} // RVA: 0x7FFD540CE070
        public void CheckExternalCamera(){} // RVA: 0x7FFD540CE110
        public void RenderExternalCamera(){} // RVA: 0x7FFD540CEB70
        public void OnInputFocus(){} // RVA: 0x7FFD540CEDC0
        public void GetScreenshotFilename(){} // RVA: 0x7FFD540CEEE0
        public void OnRequestScreenshot(){} // RVA: 0x7FFD540CF050
        public void OnEnable(){} // RVA: 0x7FFD540CF530
        public void OnSteamVRInitialized(){} // RVA: 0x7FFD540CFB20
        public void OnDisable(){} // RVA: 0x7FFD540CFB80
        public void UpdatePoses(){} // RVA: 0x7FFD540CFF20
        public void OnBeforeRender(){} // RVA: 0x7FFD540D0050
        public void Update(){} // RVA: 0x7FFD540D0120
        public void .ctor(){} // RVA: 0x7FFD540D0680
    }

    public class SteamVR_RenderModel : MonoBehaviour
    {
        public object renderModelName;
        public object initializedAttachPoints;

        // ── Methods ──
        public void get_renderModelName(){} // RVA: 0x7FFD4E3BE740
        public void set_renderModelName(){} // RVA: 0x7FFD4E369200
        public void get_initializedAttachPoints(){} // RVA: 0x7FFD4E3F8D30
        public void set_initializedAttachPoints(){} // RVA: 0x7FFD4E3F8D40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x7FFD540D0DB0
        public void SetMeshRendererState(){} // RVA: 0x7FFD540D0E60
        public void OnHideRenderModels(){} // RVA: 0x7FFD540D0FF0
        public void OnDeviceConnected(){} // RVA: 0x7FFD540D1000
        public void UpdateModel(){} // RVA: 0x7FFD540D1020
        public void SetModelAsync(){} // RVA: 0x7FFD540D1350
        public void SetModel(){} // RVA: 0x7FFD540D1450
        public void LoadRenderModel(){} // RVA: 0x7FFD540D1A60
        public void ConvertByteColorGammaExp(){} // RVA: 0x7FFD540D30A0
        public void FreeRenderModel(){} // RVA: 0x7FFD540D3100
        public void FindTransformByName(){} // RVA: 0x7FFD540D3150
        public void GetComponentTransform(){} // RVA: 0x7FFD540D3380
        public void StripMesh(){} // RVA: 0x7FFD540D3480
        public void LoadComponents(){} // RVA: 0x7FFD540D3670
        public void .ctor(){} // RVA: 0x7FFD540D4350
        public void OnEnable(){} // RVA: 0x7FFD540D4770
        public void OnDisable(){} // RVA: 0x7FFD540D48E0
        public void Update(){} // RVA: 0x7FFD540D4950
        public void UpdateComponents(){} // RVA: 0x7FFD540D49A0
        public void SetDeviceIndex(){} // RVA: 0x7FFD540D5400
        public void SetInputSource(){} // RVA: 0x7FFD4F5874D0
        public void Sleep(){} // RVA: 0x7FFD540D54E0
        public void MarshalRenderModel(){} // RVA: 0x7FFD540D54F0
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x7FFD540D5720
        public void .cctor(){} // RVA: 0x7FFD540D5950
    }

    public class SteamVR_RingBuffer`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090ED0
        public void Add(){} // RVA: 0x7FFD4E2ADC40
        public void StepForward(){} // RVA: 0x7FFD4E090980
        public void GetAtIndex(){} // RVA: 0x7FFD4E2ADC40
        public void GetLast(){} // RVA: 0x7FFD4E2ADC40
        public void GetLastIndex(){} // RVA: 0x7FFD4E079960
        public void Clear(){} // RVA: 0x7FFD4E090980
    }

    public class SteamVR_Settings : ScriptableObject
    {
        public object instance;
        public object trackingSpace;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFD540D7580
        public void get_trackingSpace(){} // RVA: 0x7FFD4F8557F0
        public void set_trackingSpace(){} // RVA: 0x7FFD540D75D0
        public void IsInputUpdateMode(){} // RVA: 0x7FFD540D7650
        public void IsPoseUpdateMode(){} // RVA: 0x7FFD540D7660
        public void VerifyScriptableObject(){} // RVA: 0x7FFD540D7670
        public void LoadInstance(){} // RVA: 0x7FFD540D7680
        public void Save(){} // RVA: 0x7FFD4E341310
        public void SetDefaultsIfNeeded(){} // RVA: 0x7FFD540D7940
        public void FindDefaultPreviewHand(){} // RVA: 0x7FFD4E919180
        public void .ctor(){} // RVA: 0x7FFD540D7B50
    }

    public class SteamVR_Skeleton_Pose : ScriptableObject
    {
        // ── Methods ──
        public void GetHand(){} // RVA: 0x7FFD540ABCE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD540ABD00
    }

    public class SteamVR_Skeleton_Poser : MonoBehaviour
    {
        public object blendPoseCount;

        // ── Methods ──
        public void get_blendPoseCount(){} // RVA: 0x7FFD540AC520
        public void Awake(){} // RVA: 0x7FFD540AC540
        public void SetBlendingBehaviourValue(){} // RVA: 0x7FFD540ACA90
        public void GetBlendingBehaviourValue(){} // RVA: 0x7FFD540ACB60
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x7FFD540ACB90
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x7FFD540ACBC0
        public void GetBlendingBehaviour(){} // RVA: 0x7FFD540ACBF0
        public void FindBlendingBehaviour(){} // RVA: 0x7FFD540ACC00
        public void GetPoseByIndex(){} // RVA: 0x7FFD540ACE10
        public void GetHandSnapshot(){} // RVA: 0x7FFD540ACEA0
        public void GetBlendedPose(){} // RVA: 0x7FFD540ACF00 | overloaded x2
        public void UpdatePose(){} // RVA: 0x7FFD540ACF50
        public void ApplyBlenderBehaviours(){} // RVA: 0x7FFD540AD230
        public void LateUpdate(){} // RVA: 0x7FFD540AD4F0
        public void BlendVectors(){} // RVA: 0x7FFD540AD500
        public void BlendQuaternions(){} // RVA: 0x7FFD540AD600
        public void GetTargetHandPosition(){} // RVA: 0x7FFD540AD8F0
        public void GetTargetHandRotation(){} // RVA: 0x7FFD540ADEF0
        public void .ctor(){} // RVA: 0x7FFD540AE5B0
    }

    public class SteamVR_Skybox : MonoBehaviour
    {
        // ── Methods ──
        public void SetTextureByIndex(){} // RVA: 0x7FFD540D7D90
        public void GetTextureByIndex(){} // RVA: 0x7FFD540D7E20
        public void SetOverride(){} // RVA: 0x7FFD540D7E80
        public void ClearOverride(){} // RVA: 0x7FFD540D8390
        public void OnEnable(){} // RVA: 0x7FFD540D83E0
        public void OnDisable(){} // RVA: 0x7FFD540D8390
        public void .ctor(){} // RVA: 0x7FFD540D8420
    }

    public class SteamVR_SphericalProjection : MonoBehaviour
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7FFD540D8480
        public void OnRenderImage(){} // RVA: 0x7FFD540D8A70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_TrackedCamera : Object
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x7FFD540D8B00
        public void Undistorted(){} // RVA: 0x7FFD540D8CA0
        public void Source(){} // RVA: 0x7FFD540D8E50
        public void Stream(){} // RVA: 0x7FFD540D9190
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_TrackedObject : MonoBehaviour
    {
        public object isValid;

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFD4E367450
        public void set_isValid(){} // RVA: 0x7FFD4E367460
        public void OnNewPoses(){} // RVA: 0x7FFD540D9F80
        public void .ctor(){} // RVA: 0x7FFD540DA560
        public void Awake(){} // RVA: 0x7FFD540DA680
        public void OnEnable(){} // RVA: 0x7FFD540DA680
        public void OnDisable(){} // RVA: 0x7FFD540DA810
        public void SetDeviceIndex(){} // RVA: 0x7FFD540DA850
    }

    public class SteamVR_TrackingReferenceManager : MonoBehaviour
    {
        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD540DAA10
        public void OnDisable(){} // RVA: 0x7FFD540DAAF0
        public void OnNewPoses(){} // RVA: 0x7FFD540DAC00
        public void .ctor(){} // RVA: 0x7FFD540DAF90
    }

}