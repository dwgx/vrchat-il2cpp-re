// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 78
// Methods: 1548

namespace ThirdParty.Valve.Valve.VR
{
    public class SpatialAnchorPose_t : ValueType
    {
        public Valve.VR.HmdMatrix34_t mAnchorToAbsoluteTracking; // 0x10
    }

    public class SteamVR : Object
    {
        public System.Nullable`1<bool> active;
        public bool enabled; // 0x2
        public Valve.VR.SteamVR instance; // 0x8
        public 0x6656A158 usingNativeSupport; // 0x10
        public Valve.VR.SteamVR_Settings settings; // 0x18
        public Valve.VR.CVRSystem hmd; // 0x10
        public Valve.VR.CVRCompositor compositor; // 0x18
        public Valve.VR.CVROverlay overlay; // 0x20
        public bool initializing; // 0x20
        public bool calibrating; // 0x21
        public bool outOfRange; // 0x22
        public bool[] sceneWidth; // 0x28
        public float sceneHeight; // 0x28
        public float aspect; // 0x2C
        public float fieldOfView; // 0x30
        public float tanHalfFov; // 0x34
        public UnityEngine.Vector2 textureBounds; // 0x38
        public Valve.VR.VRTextureBounds_t[] eyes; // 0x40
        public 0x66565FB0[] hmd_TrackingSystemName; // 0x48
        public 0x6659FE70 hmd_ActualTrackingSystemName; // 0x50
        public bool hmd_ModelNumber; // 0x30
        public string hmd_SerialNumber;
        public string hmd_Type;

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
        public string fullPath; // 0x10
        public bool handle; // 0x18
        public bool actionSet;
        public string direction; // 0x20

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
        public string allActions; // 0x10
        public 0x665668A0 nonVisualInActions; // 0x18
        public bool visualActions; // 0x20

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
        public uint rawActiveActionSetArray;
        public bool changed; // 0x4
        public int currentArraySize; // 0x8
        public System.Collections.Generic.Dictionary`2<int,Valve.VR.VRActiveActionSet_t[]> poolActiveActionSetArrays; // 0x10
        public int lastFrameUpdated; // 0x18
        public string debugActiveSetListText; // 0x20
        public bool updateDebugTextInBuilds; // 0x28

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
        public System.Collections.Generic.List`1<int> updatingSources;

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
        public int bonePositions;
        public UnityEngine.Quaternion boneRotations;

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
        public string fullPath; // 0x10
        public ulong handle; // 0x18
        public Valve.VR.SteamVR_ActionSet actionSet; // 0x20
        public 0x665667F0 direction; // 0x28
        public Valve.VR.SteamVR_Action action; // 0x30
        public string inLowered;
        public string outLowered; // 0x8

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
        public T[] Item;

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
        public 0x66568108 Item; // 0x28
        public bool fullPath; // 0x30
        public uint handle;
        public Valve.VR.InputBindingInfo_t[] actionSet; // 0x8

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
        public Valve.VR.SteamVR_Action_Boolean global_Safe_Mode;
        public Valve.VR.SteamVR_Action_Pose global_Pose; // 0x8
        public Valve.VR.SteamVR_Action_Skeleton global_SkeletonLeftHand; // 0x10
        public Valve.VR.SteamVR_Action_Skeleton global_SkeletonRightHand; // 0x18
        public Valve.VR.SteamVR_Action_Boolean global_HeadsetOnHead; // 0x20
        public Valve.VR.SteamVR_Action_Boolean global_Menu; // 0x28
        public Valve.VR.SteamVR_Action_Boolean global_Quick_Menu; // 0x30
        public Valve.VR.SteamVR_Action_Boolean global_Action_Menu; // 0x38
        public Valve.VR.SteamVR_Action_Boolean global_Main_Menu; // 0x40
        public Valve.VR.SteamVR_Action_Boolean global_Interact; // 0x48
        public Valve.VR.SteamVR_Action_Boolean global_Grab; // 0x50
        public Valve.VR.SteamVR_Action_Vector2 global_Move; // 0x58
        public Valve.VR.SteamVR_Action_Boolean global_Jump; // 0x60
        public Valve.VR.SteamVR_Action_Vector2 global_Rotate; // 0x68
        public Valve.VR.SteamVR_Action_Boolean global_Mic; // 0x70
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Toggle; // 0x78
        public Valve.VR.SteamVR_Action_Boolean global_Stick_Click; // 0x80
        public Valve.VR.SteamVR_Action_Single global_Trigger_Axis; // 0x88
        public Valve.VR.SteamVR_Action_Single global_Grip_Axis; // 0x90
        public Valve.VR.SteamVR_Action_Boolean global_Udon_Menu; // 0x98
        public Valve.VR.SteamVR_Action_Boolean global_Drop; // 0xA0
        public Valve.VR.SteamVR_Action_Boolean global_Nameplates; // 0xA8
        public Valve.VR.SteamVR_Action_Boolean global_HUD; // 0xB0
        public Valve.VR.SteamVR_Action_Boolean global_Chatbox; // 0xB8
        public Valve.VR.SteamVR_Action_Boolean global_Face_Mirror; // 0xC0
        public Valve.VR.SteamVR_Action_Boolean global_Personal_Mirror; // 0xC8
        public Valve.VR.SteamVR_Action_Boolean global_Personal_Mirror_Lock; // 0xD0
        public Valve.VR.SteamVR_Action_Boolean global_Earmuffs; // 0xD8
        public Valve.VR.SteamVR_Action_Boolean global_Camera; // 0xE0
        public Valve.VR.SteamVR_Action_Boolean global_Stream_Camera; // 0xE8
        public Valve.VR.SteamVR_Action_Boolean global_Avatar_Debug_Screen; // 0xF0
        public Valve.VR.SteamVR_Action_Boolean global_OSC_Debug_Screen; // 0xF8
        public Valve.VR.SteamVR_Action_Boolean global_Confirm_FBT_Calibration; // 0x100
        public Valve.VR.SteamVR_Action_Boolean global_Start_Move; // 0x108
        public Valve.VR.SteamVR_Action_Boolean global_Start_Rotate; // 0x110
        public Valve.VR.SteamVR_Action_Boolean global_Continue_Move; // 0x118
        public Valve.VR.SteamVR_Action_Boolean global_Continue_Rotate; // 0x120
        public Valve.VR.SteamVR_Action_Boolean global_No_Gesture_After_Move; // 0x128
        public Valve.VR.SteamVR_Action_Boolean global_No_Gesture_After_Rotate; // 0x130
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Activator_Thumb; // 0x138
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Activator_Thumb_Inner_Upper; // 0x140
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Activator_Thumb_Inner_Lower; // 0x148
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Activator_Thumb_Outer; // 0x150
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Activator_Index; // 0x158
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Activator_Grip; // 0x160
        public Valve.VR.SteamVR_Action_Single global_Gesture_Trigger_Axis; // 0x168
        public Valve.VR.SteamVR_Action_Single global_Gesture_Grip_Axis; // 0x170
        public Valve.VR.SteamVR_Action_Vector2 global_Gesture_Activator_Stick_Deflection; // 0x178
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Neutral_Left; // 0x180
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Fist_Left; // 0x188
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Open_Left; // 0x190
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Peace_Left; // 0x198
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Horns_Left; // 0x1A0
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Finger_Gun_Left; // 0x1A8
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Thumbs_Up_Left; // 0x1B0
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Point_Left; // 0x1B8
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Neutral_Right; // 0x1C0
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Fist_Right; // 0x1C8
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Open_Right; // 0x1D0
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Peace_Right; // 0x1D8
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Horns_Right; // 0x1E0
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Finger_Gun_Right; // 0x1E8
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Thumbs_Up_Right; // 0x1F0
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Direct_Point_Right; // 0x1F8
        public Valve.VR.SteamVR_Action_Vector2 global_Gesture_Wheel_Left; // 0x200
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Select_Left; // 0x208
        public Valve.VR.SteamVR_Action_Single global_Gesture_Wheel_Soft_Select_Left; // 0x210
        public Valve.VR.SteamVR_Action_Single global_Gesture_Wheel_Weight_Left; // 0x218
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Direct_Left; // 0x220
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Direct_Stay_Left; // 0x228
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Cancel_Left; // 0x230
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Cancel_Open_Left; // 0x238
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Held_Left; // 0x240
        public Valve.VR.SteamVR_Action_Vector2 global_Gesture_Wheel_Right; // 0x248
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Select_Right; // 0x250
        public Valve.VR.SteamVR_Action_Single global_Gesture_Wheel_Soft_Select_Right; // 0x258
        public Valve.VR.SteamVR_Action_Single global_Gesture_Wheel_Weight_Right; // 0x260
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Direct_Right; // 0x268
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Direct_Stay_Right; // 0x270
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Cancel_Right; // 0x278
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Cancel_Open_Right; // 0x280
        public Valve.VR.SteamVR_Action_Boolean global_Gesture_Wheel_Held_Right; // 0x288
        public Valve.VR.SteamVR_Action_Boolean global_Disable_Gesture_Tracked; // 0x290
        public Valve.VR.SteamVR_Action_Boolean global_Disable_Gesture_Wheel_Move_Left; // 0x298
        public Valve.VR.SteamVR_Action_Boolean global_Disable_Gesture_Wheel_Rotate_Left; // 0x2A0
        public Valve.VR.SteamVR_Action_Boolean global_Disable_Gesture_Wheel_Move_Right; // 0x2A8
        public Valve.VR.SteamVR_Action_Boolean global_Disable_Gesture_Wheel_Rotate_Right; // 0x2B0
        public Valve.VR.SteamVR_Action_Boolean global_Physbone_Grab_Left; // 0x2B8
        public Valve.VR.SteamVR_Action_Boolean global_Physbone_Freeze_Left; // 0x2C0
        public Valve.VR.SteamVR_Action_Boolean global_Physbone_Grab_Right; // 0x2C8
        public Valve.VR.SteamVR_Action_Boolean global_Physbone_Freeze_Right; // 0x2D0
        public Valve.VR.SteamVR_Action_Vector2 global_Scroll; // 0x2D8
        public Valve.VR.SteamVR_Action_Vibration global_Haptic; // 0x2E0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Interact; // 0x2E8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Grab; // 0x2F0
        public Valve.VR.SteamVR_Action_Vector2 one_Hand_Move_Rotate; // 0x2F8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Jump; // 0x300
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Mic; // 0x308
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Toggle; // 0x310
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Stick_Click; // 0x318
        public Valve.VR.SteamVR_Action_Single one_Hand_Trigger_Axis; // 0x320
        public Valve.VR.SteamVR_Action_Single one_Hand_Grip_Axis; // 0x328
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Udon_Menu; // 0x330
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Drop; // 0x338
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Start_Move_Rotate; // 0x340
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Continue_Move_Rotate; // 0x348
        public Valve.VR.SteamVR_Action_Boolean one_Hand_No_Gesture_After_Move_Rotate; // 0x350
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Menu; // 0x358
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Nameplates; // 0x360
        public Valve.VR.SteamVR_Action_Boolean one_Hand_HUD; // 0x368
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Chatbox; // 0x370
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Face_Mirror; // 0x378
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Personal_Mirror; // 0x380
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Personal_Mirror_Lock; // 0x388
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Earmuffs; // 0x390
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Camera; // 0x398
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Stream_Camera; // 0x3A0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Avatar_Debug_Screen; // 0x3A8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_OSC_Debug_Screen; // 0x3B0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Confirm_FBT_Calibration; // 0x3B8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Activator_Thumb; // 0x3C0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Activator_Thumb_Inner_Upper; // 0x3C8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Activator_Thumb_Inner_Lower; // 0x3D0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Activator_Thumb_Outer; // 0x3D8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Activator_Index; // 0x3E0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Activator_Grip; // 0x3E8
        public Valve.VR.SteamVR_Action_Single one_Hand_Gesture_Trigger_Axis; // 0x3F0
        public Valve.VR.SteamVR_Action_Single one_Hand_Gesture_Grip_Axis; // 0x3F8
        public Valve.VR.SteamVR_Action_Vector2 one_Hand_Gesture_Activator_Stick_Deflection; // 0x400
        public Valve.VR.SteamVR_Action_Vector2 one_Hand_Gesture_Wheel_Left; // 0x408
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Select_Left; // 0x410
        public Valve.VR.SteamVR_Action_Single one_Hand_Gesture_Wheel_Soft_Select_Left; // 0x418
        public Valve.VR.SteamVR_Action_Single one_Hand_Gesture_Wheel_Weight_Left; // 0x420
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Direct_Left; // 0x428
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Direct_Stay_Left; // 0x430
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Cancel_Left; // 0x438
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Cancel_Open_Left; // 0x440
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Held_Left; // 0x448
        public Valve.VR.SteamVR_Action_Vector2 one_Hand_Gesture_Wheel_Right; // 0x450
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Select_Right; // 0x458
        public Valve.VR.SteamVR_Action_Single one_Hand_Gesture_Wheel_Soft_Select_Right; // 0x460
        public Valve.VR.SteamVR_Action_Single one_Hand_Gesture_Wheel_Weight_Right; // 0x468
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Direct_Right; // 0x470
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Direct_Stay_Right; // 0x478
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Cancel_Right; // 0x480
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Cancel_Open_Right; // 0x488
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Gesture_Wheel_Held_Right; // 0x490
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Disable_Gesture_Wheel_Move_Left; // 0x498
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Disable_Gesture_Wheel_Rotate_Left; // 0x4A0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Disable_Gesture_Wheel_Move_Right; // 0x4A8
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Disable_Gesture_Wheel_Rotate_Right; // 0x4B0
        public Valve.VR.SteamVR_Action_Boolean one_Hand_Reserve_bool; // 0x4B8
        public Valve.VR.SteamVR_Action_Single one_Hand_Reserve_vector1; // 0x4C0
        public Valve.VR.SteamVR_Action_Vector2 one_Hand_Reserve_vector2; // 0x4C8
        public Valve.VR.SteamVR_Action_Boolean menu_Confirm; // 0x4D0
        public Valve.VR.SteamVR_Action_Boolean menu_Back; // 0x4D8
        public Valve.VR.SteamVR_Action_Boolean menu_Tab; // 0x4E0
        public Valve.VR.SteamVR_Action_Vector2 menu_Scroll; // 0x4E8
        public Valve.VR.SteamVR_Action_Boolean menu_Quick_Menu_Close; // 0x4F0
        public Valve.VR.SteamVR_Action_Boolean menu_Drag; // 0x4F8
        public Valve.VR.SteamVR_Action_Vector2 action_Menu_Axis; // 0x500
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Select; // 0x508
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Activator_Thumb; // 0x510
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Activator_Thumb_Inner_Upper; // 0x518
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Activator_Thumb_Inner_Lower; // 0x520
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Activator_Thumb_Outer; // 0x528
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Activator_Index; // 0x530
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Activator_Grip; // 0x538
        public Valve.VR.SteamVR_Action_Single action_Menu_Gesture_Trigger_Axis; // 0x540
        public Valve.VR.SteamVR_Action_Single action_Menu_Gesture_Grip_Axis; // 0x548
        public Valve.VR.SteamVR_Action_Vector2 action_Menu_Gesture_Activator_Stick_Deflection; // 0x550
        public Valve.VR.SteamVR_Action_Vector2 action_Menu_Gesture_Wheel_Left; // 0x558
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Select_Left; // 0x560
        public Valve.VR.SteamVR_Action_Single action_Menu_Gesture_Wheel_Soft_Select_Left; // 0x568
        public Valve.VR.SteamVR_Action_Single action_Menu_Gesture_Wheel_Weight_Left; // 0x570
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Direct_Left; // 0x578
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Direct_Stay_Left; // 0x580
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Cancel_Left; // 0x588
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Cancel_Open_Left; // 0x590
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Held_Left; // 0x598
        public Valve.VR.SteamVR_Action_Vector2 action_Menu_Gesture_Wheel_Right; // 0x5A0
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Select_Right; // 0x5A8
        public Valve.VR.SteamVR_Action_Single action_Menu_Gesture_Wheel_Soft_Select_Right; // 0x5B0
        public Valve.VR.SteamVR_Action_Single action_Menu_Gesture_Wheel_Weight_Right; // 0x5B8
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Direct_Right; // 0x5C0
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Direct_Stay_Right; // 0x5C8
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Cancel_Right; // 0x5D0
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Cancel_Open_Right; // 0x5D8
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Gesture_Wheel_Held_Right; // 0x5E0
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Disable_Gesture_Wheel_Move_Left; // 0x5E8
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Disable_Gesture_Wheel_Rotate_Left; // 0x5F0
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Disable_Gesture_Wheel_Move_Right; // 0x5F8
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Disable_Gesture_Wheel_Rotate_Right; // 0x600
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Reserve_bool; // 0x608
        public Valve.VR.SteamVR_Action_Single action_Menu_Reserve_vector1; // 0x610
        public Valve.VR.SteamVR_Action_Vector2 action_Menu_Reserve_vector2; // 0x618
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Grab; // 0x620
        public Valve.VR.SteamVR_Action_Boolean action_Menu_Drop; // 0x628
        public Valve.VR.SteamVR_Action_Vector2 drone_Left_Joystick; // 0x630
        public Valve.VR.SteamVR_Action_Vector2 drone_Right_Joystick; // 0x638
        public Valve.VR.SteamVR_Action_Boolean drone_Self_Leveling_Mod; // 0x640
        public Valve.VR.SteamVR_Action_Boolean drone_Hold_Altitude_Mod; // 0x648
        public Valve.VR.SteamVR_Action_Boolean drone_Toggle_FPV; // 0x650
        public Valve.VR.SteamVR_Action_Boolean drone_Flip; // 0x658
        public Valve.VR.SteamVR_Action_Boolean drone_Take_Picture; // 0x660
        public Valve.VR.SteamVR_Action_Boolean drone_Cycle_Flight_Preset; // 0x668
        public Valve.VR.SteamVR_Action_Boolean drone_Toggle_Self_Leveling; // 0x670
        public Valve.VR.SteamVR_Action_Boolean drone_Respawn; // 0x678
        public Valve.VR.SteamVR_Action_Boolean drone_Select_Flight_Preset_Micro; // 0x680
        public Valve.VR.SteamVR_Action_Boolean drone_Select_Flight_Preset_Cinematic; // 0x688
        public Valve.VR.SteamVR_Action_Boolean drone_Select_Flight_Preset_Racing; // 0x690
        public Valve.VR.SteamVR_Action_Boolean drone_Select_Flight_Preset_Freestyle; // 0x698
        public Valve.VR.SteamVR_Input_ActionSet_Global Global; // 0x6A0
        public Valve.VR.SteamVR_Input_ActionSet_One_Hand One_Hand; // 0x6A8
        public Valve.VR.SteamVR_Input_ActionSet_Menu Menu; // 0x6B0
        public Valve.VR.SteamVR_Input_ActionSet_Action_Menu Action_Menu; // 0x6B8
        public Valve.VR.SteamVR_Input_ActionSet_Drone Drone; // 0x6C0

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
        public Valve.VR.SteamVR_ActionSet actionSet; // 0x20
        public 0x66569C88 forSources; // 0x28
        public bool disableAllOtherActionSets; // 0x2C
        public bool activateOnStart; // 0x2D
        public bool deactivateOnDestroy; // 0x2E
        public int initialPriority; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFD5408E8B0
        public void OnDestroy(){} // RVA: 0x7FFD5408E920
        public void .ctor(){} // RVA: 0x7FFD5408E980
    }

    public class SteamVR_Behaviour : MonoBehaviour
    {
        public string instance;
        public bool forcingInitialization;
        public Valve.VR.SteamVR_Behaviour _instance; // 0x8
        public bool initializeSteamVROnAwake; // 0x20
        public bool doNotDestroy; // 0x21
        public Valve.VR.SteamVR_Render steamvr_render; // 0x28
        public bool isPlaying; // 0x10
        public bool initializing; // 0x11
        public UnityEngine.Coroutine initializeCoroutine; // 0x30
        public bool loadedOpenVRDeviceSuccess; // 0x38
        public int lastFrameCount; // 0x14

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
        public Valve.VR.SteamVR_Action_Boolean isActive; // 0x20
        public 0x66569C88 actionSet; // 0x28
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onChange; // 0x30
        public 0x665685D8 onChangeEvent; // 0x38
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onUpdate; // 0x40
        public 0x66568630 onUpdateEvent; // 0x48
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onPress; // 0x50
        public 0x66568528 onPressEvent; // 0x58
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onPressDown; // 0x60
        public 0x66568478 onPressDownEvent; // 0x68
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onPressUp; // 0x70
        public 0x665684D0 onPressUpEvent; // 0x78

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
        public Valve.VR.SteamVR_Action_Pose isValid; // 0x20
        public 0x66569C88 isActive; // 0x28
        public UnityEngine.Transform origin; // 0x30
        public Valve.VR.SteamVR_Behaviour_PoseEvent onTransformUpdated; // 0x38
        public Valve.VR.SteamVR_Behaviour_PoseEvent onTransformChanged; // 0x40
        public Valve.VR.SteamVR_Behaviour_Pose_ConnectedChangedEvent onConnectedChanged; // 0x48
        public Valve.VR.SteamVR_Behaviour_Pose_TrackingChangedEvent onTrackingChanged; // 0x50
        public Valve.VR.SteamVR_Behaviour_Pose_DeviceIndexChangedEvent onDeviceIndexChanged; // 0x58
        public 0x66568790 onTransformUpdatedEvent; // 0x60
        public 0x66568738 onTransformChangedEvent; // 0x68
        public 0x66568898 onConnectedChangedEvent; // 0x70
        public 0x665687E8 onTrackingChangedEvent; // 0x78
        public 0x665688F0 onDeviceIndexChangedEvent; // 0x80
        public bool broadcastDeviceChanges; // 0x88
        public int deviceIndex; // 0x8C
        public 0x6656B020 historyBuffer; // 0x90
        public int lastFrameUpdated; // 0x98

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
        public Valve.VR.SteamVR_Action_Single isActive; // 0x20
        public 0x66569C88 inputSource; // 0x28
        public Valve.VR.SteamVR_Behaviour_SingleEvent onChange; // 0x30
        public Valve.VR.SteamVR_Behaviour_SingleEvent onUpdate; // 0x38
        public Valve.VR.SteamVR_Behaviour_SingleEvent onAxis; // 0x40
        public 0x665689F8 onChangeEvent; // 0x48
        public 0x66568A50 onUpdateEvent; // 0x50
        public 0x665689A0 onAxisEvent; // 0x58

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
        public Valve.VR.SteamVR_Action_Skeleton skeletonAvailable; // 0x20
        public 0x66569C88 isActive; // 0x28
        public 0x665A0868 fingerCurls; // 0x2C
        public UnityEngine.Transform thumbCurl; // 0x30
        public UnityEngine.Transform indexCurl; // 0x38
        public bool middleCurl; // 0x40
        public bool ringCurl; // 0x41
        public float pinkyCurl; // 0x44
        public Valve.VR.SteamVR_Behaviour_SkeletonEvent root; // 0x48
        public Valve.VR.SteamVR_Behaviour_SkeletonEvent wrist; // 0x50
        public Valve.VR.SteamVR_Behaviour_SkeletonEvent indexMetacarpal; // 0x58
        public Valve.VR.SteamVR_Behaviour_Skeleton_ConnectedChangedEvent indexProximal; // 0x60
        public Valve.VR.SteamVR_Behaviour_Skeleton_TrackingChangedEvent indexMiddle; // 0x68
        public 0x66568C08 indexDistal; // 0x70
        public 0x66568C08 indexTip; // 0x78
        public 0x66568BB0 middleMetacarpal; // 0x80
        public 0x66568D10 middleProximal; // 0x88
        public 0x66568C60 middleMiddle; // 0x90
        public 0x66568B00 middleDistal; // 0x98
        public Valve.VR.SteamVR_Skeleton_Poser middleTip; // 0xA0
        public Valve.VR.SteamVR_Action_Single pinkyMetacarpal; // 0xA8
        public Valve.VR.SteamVR_Skeleton_Poser pinkyProximal; // 0xB0
        public 0x6656A050 pinkyMiddle; // 0xB8
        public UnityEngine.Transform[] pinkyDistal; // 0xC0
        public UnityEngine.Transform[] pinkyTip; // 0xC8
        public UnityEngine.Transform[] ringMetacarpal; // 0xD0
        public UnityEngine.Transform[] ringProximal; // 0xD8
        public UnityEngine.Transform[] ringMiddle; // 0xE0
        public UnityEngine.Coroutine ringDistal; // 0xE8
        public UnityEngine.Coroutine ringTip; // 0xF0
        public UnityEngine.Coroutine thumbMetacarpal; // 0xF8
        public UnityEngine.Transform[] thumbProximal; // 0x100
        public System.Nullable`1<0x665A0868> thumbMiddle; // 0x108
        public UnityEngine.Quaternion thumbDistal;

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
        public UnityEngine.Transform _wrist; // 0x110
        public UnityEngine.Transform _thumbMetacarpal; // 0x118
        public UnityEngine.Transform _thumbProximal; // 0x120
        public UnityEngine.Transform _thumbMiddle; // 0x128
        public UnityEngine.Transform _thumbDistal; // 0x130
        public UnityEngine.Transform _thumbTip; // 0x138
        public UnityEngine.Transform _thumbAux; // 0x140
        public UnityEngine.Transform _indexMetacarpal; // 0x148
        public UnityEngine.Transform _indexProximal; // 0x150
        public UnityEngine.Transform _indexMiddle; // 0x158
        public UnityEngine.Transform _indexDistal; // 0x160
        public UnityEngine.Transform _indexTip; // 0x168
        public UnityEngine.Transform _indexAux; // 0x170
        public UnityEngine.Transform _middleMetacarpal; // 0x178
        public UnityEngine.Transform _middleProximal; // 0x180
        public UnityEngine.Transform _middleMiddle; // 0x188
        public UnityEngine.Transform _middleDistal; // 0x190
        public UnityEngine.Transform _middleTip; // 0x198
        public UnityEngine.Transform _middleAux; // 0x1A0
        public UnityEngine.Transform _ringMetacarpal; // 0x1A8
        public UnityEngine.Transform _ringProximal; // 0x1B0
        public UnityEngine.Transform _ringMiddle; // 0x1B8
        public UnityEngine.Transform _ringDistal; // 0x1C0
        public UnityEngine.Transform _ringTip; // 0x1C8
        public UnityEngine.Transform _ringAux; // 0x1D0
        public UnityEngine.Transform _pinkyMetacarpal; // 0x1D8
        public UnityEngine.Transform _pinkyProximal; // 0x1E0
        public UnityEngine.Transform _pinkyMiddle; // 0x1E8
        public UnityEngine.Transform _pinkyDistal; // 0x1F0
        public UnityEngine.Transform _pinkyTip; // 0x1F8
        public UnityEngine.Transform _pinkyAux; // 0x200

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
        public Valve.VR.SteamVR_Action_Vector2 isActive; // 0x20
        public 0x66569C88 inputSource; // 0x28
        public Valve.VR.SteamVR_Behaviour_Vector2Event onChange; // 0x30
        public Valve.VR.SteamVR_Behaviour_Vector2Event onUpdate; // 0x38
        public Valve.VR.SteamVR_Behaviour_Vector2Event onAxis; // 0x40
        public 0x66568F20 onChangeEvent; // 0x48
        public 0x66568F78 onUpdateEvent; // 0x50
        public 0x66568EC8 onAxisEvent; // 0x58

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
        public Valve.VR.SteamVR_Action_Vector3 isActive; // 0x20
        public 0x66569C88 inputSource; // 0x28
        public Valve.VR.SteamVR_Behaviour_Vector3Event onChange; // 0x30
        public Valve.VR.SteamVR_Behaviour_Vector3Event onUpdate; // 0x38
        public Valve.VR.SteamVR_Behaviour_Vector3Event onAxis; // 0x40
        public 0x66569080 onChangeEvent; // 0x48
        public 0x665690D8 onUpdateEvent; // 0x50
        public 0x66569028 onAxisEvent; // 0x58

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
        public UnityEngine.Transform head; // 0x20
        public UnityEngine.Camera offset; // 0x28
        public UnityEngine.Transform origin; // 0x30
        public bool camera; // 0x38
        public System.Collections.Hashtable ears;
        public string sceneResolutionScale;
        public string baseName;
        public string headSuffix;
        public string originSuffix;

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
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD540BA7F0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Ears : MonoBehaviour
    {
        public Valve.VR.SteamVR_Camera vrcam; // 0x20
        public bool usingSpeakers; // 0x28
        public UnityEngine.Quaternion offset; // 0x2C

        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x7FFD540BA890
        public void OnEnable(){} // RVA: 0x7FFD540BAC60
        public void OnDisable(){} // RVA: 0x7FFD540BAFE0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_Events : Object
    {
        public Event`1<bool> Calibrating;
        public Event`2<int,bool> DeviceConnected; // 0x8
        public Event`3<UnityEngine.Color,float,bool> Fade; // 0x10
        public 0x6656A6D8 FadeReady; // 0x18
        public Event`1<bool> HideRenderModels; // 0x20
        public Event`1<bool> Initializing; // 0x28
        public Event`1<bool> InputFocus; // 0x30
        public Event`1<bool> Loading; // 0x38
        public Event`1<float> LoadingFadeIn; // 0x40
        public Event`1<float> LoadingFadeOut; // 0x48
        public Event`1<Valve.VR.TrackedDevicePose_t[]> NewPoses; // 0x50
        public 0x6656A6D8 NewPosesApplied; // 0x58
        public Event`1<bool> Initialized; // 0x60
        public Event`1<bool> OutOfRange; // 0x68
        public Event`2<Valve.VR.SteamVR_RenderModel,bool> RenderModelLoaded; // 0x70
        public System.Collections.Generic.Dictionary`2<0x665A0290,Event`1<Valve.VR.VREvent_t>> systemEvents; // 0x78

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
        public Valve.VR.SteamVR_Action_Pose cameraPose; // 0x20
        public 0x66569C88 cameraInputSource; // 0x28
        public 0x6656A890 config; // 0x2C
        public string configPath; // 0x78
        public bool autoEnableDisableActionSet; // 0x80
        public 0x66499418 watcher; // 0x88
        public UnityEngine.Camera cam; // 0x90
        public UnityEngine.Transform target; // 0x98
        public UnityEngine.GameObject clipQuad; // 0xA0
        public UnityEngine.Material clipMaterial; // 0xA8
        public Valve.VR.SteamVR_ActionSet activatedActionSet; // 0xB0
        public 0x66569C88 activatedInputSource; // 0xB8
        public UnityEngine.Material colorMat; // 0xC0
        public UnityEngine.Material alphaMat; // 0xC8
        public UnityEngine.Camera[] cameras; // 0xD0
        public UnityEngine.Rect[] cameraRects; // 0xD8
        public float sceneResolutionScale; // 0xE0

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
        public int hasCamera;
        public Action newPosesAction; // 0x8

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x7FFD540C1240
        public void SubscribeToNewPoses(){} // RVA: 0x7FFD540C12A0
        public void OnNewPoses(){} // RVA: 0x7FFD540C1440
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void .cctor(){} // RVA: 0x7FFD540C1570
    }

    public class SteamVR_Fade : MonoBehaviour
    {
        public UnityEngine.Color currentColor; // 0x20
        public UnityEngine.Color targetColor; // 0x30
        public UnityEngine.Color deltaColor; // 0x40
        public bool fadeOverlay; // 0x50
        public UnityEngine.Material fadeMaterial;
        public int fadeMaterialColorID; // 0x8

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
        public 0x6656B338 index; // 0x20
        public float fovLeft; // 0x24
        public float fovRight; // 0x28
        public float fovTop; // 0x2C
        public float fovBottom; // 0x30
        public float nearZ; // 0x34
        public float farZ; // 0x38

        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x7FFD540C2280
        public void OnDeviceConnected(){} // RVA: 0x7FFD540C2CB0
        public void OnEnable(){} // RVA: 0x7FFD540C2F50
        public void OnDisable(){} // RVA: 0x7FFD540C30A0
        public void .ctor(){} // RVA: 0x7FFD540C3220
    }

    public class SteamVR_IK : MonoBehaviour
    {
        public UnityEngine.Transform target; // 0x20
        public UnityEngine.Transform start; // 0x28
        public UnityEngine.Transform joint; // 0x30
        public UnityEngine.Transform end; // 0x38
        public UnityEngine.Transform poleVector; // 0x40
        public UnityEngine.Transform upVector; // 0x48
        public float blendPct; // 0x50
        public UnityEngine.Transform startXform; // 0x58
        public UnityEngine.Transform jointXform; // 0x60
        public UnityEngine.Transform endXform; // 0x68

        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFD540C3290
        public void Solve(){} // RVA: 0x7FFD540C4BC0
        public void .ctor(){} // RVA: 0x7FFD540C5260
    }

    public class SteamVR_Input : Object
    {
        public string isStartupFrame;
        public string localizationKeyName;
        public bool fileInitialized;
        public bool initialized; // 0x1
        public bool preInitialized; // 0x2
        public Valve.VR.SteamVR_Input_ActionFile actionFile; // 0x8
        public string actionFileHash; // 0x10
        public System.Action onNonVisualActionsUpdated; // 0x18
        public 0x66569188 onPosesUpdated; // 0x20
        public 0x665691E0 onSkeletonsUpdated; // 0x28
        public bool initializing; // 0x30
        public int startupFrame; // 0x34
        public Valve.VR.SteamVR_ActionSet[] actionSets; // 0x38
        public Valve.VR.SteamVR_Action[] actions; // 0x40
        public 0x66566E20[] actionsIn; // 0x48
        public 0x66566F80[] actionsOut; // 0x50
        public Valve.VR.SteamVR_Action_Boolean[] actionsBoolean; // 0x58
        public Valve.VR.SteamVR_Action_Single[] actionsSingle; // 0x60
        public Valve.VR.SteamVR_Action_Vector2[] actionsVector2; // 0x68
        public Valve.VR.SteamVR_Action_Vector3[] actionsVector3; // 0x70
        public Valve.VR.SteamVR_Action_Pose[] actionsPose; // 0x78
        public Valve.VR.SteamVR_Action_Skeleton[] actionsSkeleton; // 0x80
        public Valve.VR.SteamVR_Action_Vibration[] actionsVibration; // 0x88
        public 0x66566E20[] actionsNonPoseNonSkeletonIn; // 0x90
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_ActionSet> actionSetsByPath; // 0x98
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_ActionSet> actionSetsByPathLowered; // 0xA0
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_Action> actionsByPath; // 0xA8
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_Action> actionsByPathLowered; // 0xB0
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_ActionSet> actionSetsByPathCache; // 0xB8
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_Action> actionsByPathCache; // 0xC0
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_Action> actionsByNameCache; // 0xC8
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_ActionSet> actionSetsByNameCache; // 0xD0
        public uint sizeVRActiveActionSet_t; // 0xD8
        public Valve.VR.VRActiveActionSet_t[] setCache; // 0xE0

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
        public System.Collections.Generic.List`1<0x665694A0> actions; // 0x10
        public System.Collections.Generic.List`1<0x665693F0> action_sets; // 0x18
        public System.Collections.Generic.List`1<0x66569398> default_bindings; // 0x20
        public System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<string,string>> localization; // 0x28
        public string filePath; // 0x30
        public System.Collections.Generic.List`1<0x665694F8> localizationHelperList; // 0x38
        public string findString_appKeyStart;
        public string findString_appKeyEnd;

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
        public string app_key; // 0x10
        public System.Collections.Generic.Dictionary`2<string,0x66569918> bindings; // 0x18
        public string controller_type; // 0x20
        public string description; // 0x28
        public string name; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD540A92D0
    }

    public class SteamVR_Input_Generator_Names : Object
    {
        public string fullActionsClassName;
        public string actionsClassName;
        public string preinitializeMethodName;
        public string actionsFieldName;
        public string actionsInFieldName;
        public string actionsOutFieldName;
        public string actionsVibrationFieldName;
        public string actionsPoseFieldName;
        public string actionsBooleanFieldName;
        public string actionsSingleFieldName;
        public string actionsVector2FieldName;
        public string actionsVector3FieldName;
        public string actionsSkeletonFieldName;
        public string actionsNonPoseNonSkeletonIn;
        public string actionSetsFieldName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_Input_Source : Object
    {
        public int numSources;
        public ulong[] inputSourceHandlesBySource; // 0x8
        public System.Collections.Generic.Dictionary`2<ulong,0x66569C88> inputSourceSourcesByHandle; // 0x10
        public System.Type enumType; // 0x18
        public System.Type descriptionType; // 0x20
        public 0x66569C88[] allSources; // 0x28

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
        public Valve.VR.SteamVR_LoadLevel loading;
        public string progress; // 0x20
        public string progressTexture; // 0x28
        public string internalProcessArgs; // 0x30
        public bool loadAdditive; // 0x38
        public bool loadAsync; // 0x39
        public UnityEngine.Texture loadingScreen; // 0x40
        public UnityEngine.Texture progressBarEmpty; // 0x48
        public UnityEngine.Texture progressBarFull; // 0x50
        public float loadingScreenWidthInMeters; // 0x58
        public float progressBarWidthInMeters; // 0x5C
        public float loadingScreenDistance; // 0x60
        public UnityEngine.Transform loadingScreenTransform; // 0x68
        public UnityEngine.Transform progressBarTransform; // 0x70
        public UnityEngine.Texture front; // 0x78
        public UnityEngine.Texture back; // 0x80
        public UnityEngine.Texture left; // 0x88
        public UnityEngine.Texture right; // 0x90
        public UnityEngine.Texture top; // 0x98
        public UnityEngine.Texture bottom; // 0xA0
        public UnityEngine.Color backgroundColor; // 0xA8
        public bool showGrid; // 0xB8
        public float fadeOutTime; // 0xBC
        public float fadeInTime; // 0xC0
        public float postLoadSettleTime; // 0xC4
        public float loadingScreenFadeInTime; // 0xC8
        public float loadingScreenFadeOutTime; // 0xCC
        public float fadeRate; // 0xD0
        public float alpha; // 0xD4
        public UnityEngine.AsyncOperation async; // 0xD8
        public UnityEngine.RenderTexture renderTexture; // 0xE0
        public ulong loadingScreenOverlayHandle; // 0xE8
        public ulong progressBarOverlayHandle; // 0xF0
        public bool autoTriggerOnEnable; // 0xF8

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
        public UnityEngine.Texture texture; // 0x20
        public UnityEngine.Texture scale; // 0x28
        public UnityEngine.Texture logo; // 0x30
        public float logoHeight; // 0x38
        public float menuOffset; // 0x3C
        public UnityEngine.Vector2 scaleLimits; // 0x40
        public float scaleRate; // 0x48
        public Valve.VR.SteamVR_Overlay overlay; // 0x50
        public UnityEngine.Camera overlayCam; // 0x58
        public UnityEngine.Vector4 uvOffset; // 0x60
        public float distance; // 0x70
        public float <scale>k__BackingField; // 0x74
        public string scaleLimitX; // 0x78
        public string scaleLimitY; // 0x80
        public string scaleRateText; // 0x88
        public 0x664DD0F8 savedCursorLockState; // 0x90
        public bool savedCursorVisible; // 0x94

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
        public UnityEngine.Texture instance; // 0x20
        public float key; // 0x28
        public float distance; // 0x2C
        public float alpha; // 0x30
        public UnityEngine.Vector4 uvOffset; // 0x34
        public UnityEngine.Vector2 mouseScale; // 0x44
        public 0x665A0F48 inputMethod; // 0x4C
        public Valve.VR.SteamVR_Overlay <instance>k__BackingField;
        public ulong handle; // 0x50

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
        public float borderThickness; // 0x20
        public float wireframeHeight; // 0x24
        public bool drawWireframeWhenSelectedOnly; // 0x28
        public bool drawInGame; // 0x29
        public 0x6656AC58 size; // 0x2C
        public UnityEngine.Color color; // 0x30
        public UnityEngine.Vector3[] vertices; // 0x40

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
        public Valve.VR.SteamVR_ExternalCamera eye; // 0x20
        public string instance; // 0x28
        public 0x6659FE18 pauseRendering;
        public bool isQuitting; // 0x4
        public Valve.VR.SteamVR_Camera[] cameras; // 0x30
        public Valve.VR.TrackedDevicePose_t[] poses; // 0x38
        public Valve.VR.TrackedDevicePose_t[] gamePoses; // 0x40
        public bool _pauseRendering; // 0x5
        public UnityEngine.WaitForEndOfFrame waitForEndOfFrame; // 0x48
        public System.Nullable`1<bool> doesPathExist; // 0x50
        public float timeScale; // 0x54
        public 0x665A0970[] screenshotTypes; // 0x58

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
        public 0x6656B338 renderModelName; // 0x20
        public 0x66569C88 initializedAttachPoints; // 0x24
        public string modelOverrideWarning;
        public string modelOverride; // 0x28
        public UnityEngine.Shader shader; // 0x30
        public bool verbose; // 0x38
        public bool createComponents; // 0x39
        public bool updateDynamically; // 0x3A
        public Valve.VR.RenderModel_ControllerMode_State_t controllerModeState; // 0x3B
        public string k_localTransformName;
        public string <renderModelName>k__BackingField; // 0x40
        public bool <initializedAttachPoints>k__BackingField; // 0x48
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.Transform> componentAttachPoints; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.MeshRenderer> meshRenderers; // 0x58
        public System.Collections.Hashtable models;
        public System.Collections.Hashtable materials; // 0x8
        public Action deviceConnectedAction; // 0x60
        public Action hideRenderModelsAction; // 0x68
        public Action modelSkinSettingsHaveChangedAction; // 0x70
        public System.Collections.Generic.Dictionary`2<int,string> nameCache; // 0x78

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
        public bool UseDateTimeForTicks;
        public T[] buffer;
        public int currentIndex;
        public T lastElement;
        public bool cleared;

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
        public Valve.VR.SteamVR_Settings instance;
        public bool trackingSpace; // 0x18
        public bool lockPhysicsUpdateRateToRenderFrequency; // 0x19
        public 0x665A0028 trackingSpaceOrigin; // 0x1C
        public string actionsFilePath; // 0x20
        public string steamVRInputPath; // 0x28
        public 0x6656A100 inputUpdateMode; // 0x30
        public 0x6656A100 poseUpdateMode; // 0x34
        public bool activateFirstActionSetOnStart; // 0x38
        public string editorAppKey; // 0x40
        public bool autoEnableVR; // 0x48
        public bool legacyMixedRealityCamera; // 0x49
        public Valve.VR.SteamVR_Action_Pose mixedRealityCameraPose; // 0x50
        public 0x66569C88 mixedRealityCameraInputSource; // 0x58
        public bool mixedRealityActionSetAutoEnable; // 0x5C
        public UnityEngine.GameObject previewHandLeft; // 0x60
        public UnityEngine.GameObject previewHandRight; // 0x68
        public string previewLeftDefaultAssetName;
        public string previewRightDefaultAssetName;
        public string defaultSettingsAssetName;

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
        public 0x66569D38 leftHand; // 0x18
        public 0x66569D38 rightHand; // 0x20
        public int leftHandInputSource;
        public int rightHandInputSource;
        public bool applyToSkeletonRoot; // 0x28

        // ── Methods ──
        public void GetHand(){} // RVA: 0x7FFD540ABCE0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFD540ABD00
    }

    public class SteamVR_Skeleton_Poser : MonoBehaviour
    {
        public bool blendPoseCount; // 0x20
        public bool blendEditorExpanded; // 0x21
        public string[] poseNames; // 0x28
        public UnityEngine.GameObject overridePreviewLeftHandPrefab; // 0x30
        public UnityEngine.GameObject overridePreviewRightHandPrefab; // 0x38
        public Valve.VR.SteamVR_Skeleton_Pose skeletonMainPose; // 0x40
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Skeleton_Pose> skeletonAdditionalPoses; // 0x48
        public bool showLeftPreview; // 0x50
        public bool showRightPreview; // 0x51
        public UnityEngine.GameObject previewLeftInstance; // 0x58
        public UnityEngine.GameObject previewRightInstance; // 0x60
        public int previewPoseSelection; // 0x68
        public System.Collections.Generic.List`1<0x66569F48> blendingBehaviours; // 0x70
        public 0x6656A050 blendedSnapshotL; // 0x78
        public 0x6656A050 blendedSnapshotR; // 0x80
        public 0x66569E98[] blendPoses; // 0x88
        public int boneCount; // 0x90
        public bool poseUpdatedThisFrame; // 0x94
        public float scale; // 0x98

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
        public UnityEngine.Texture front; // 0x20
        public UnityEngine.Texture back; // 0x28
        public UnityEngine.Texture left; // 0x30
        public UnityEngine.Texture right; // 0x38
        public UnityEngine.Texture top; // 0x40
        public UnityEngine.Texture bottom; // 0x48
        public 0x6656B128 StereoCellSize; // 0x50
        public float StereoIpdMm; // 0x54

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
        public UnityEngine.Material material;

        // ── Methods ──
        public void Set(){} // RVA: 0x7FFD540D8480
        public void OnRenderImage(){} // RVA: 0x7FFD540D8A70
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class SteamVR_TrackedCamera : Object
    {
        public 0x6656B230[] distorted;
        public 0x6656B230[] undistorted; // 0x8
        public 0x6656B288[] videostreams; // 0x10

        // ── Methods ──
        public void Distorted(){} // RVA: 0x7FFD540D8B00
        public void Undistorted(){} // RVA: 0x7FFD540D8CA0
        public void Source(){} // RVA: 0x7FFD540D8E50
        public void Stream(){} // RVA: 0x7FFD540D9190
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class SteamVR_TrackedObject : MonoBehaviour
    {
        public 0x6656B338 isValid; // 0x20
        public UnityEngine.Transform origin; // 0x28
        public bool <isValid>k__BackingField; // 0x30
        public Action newPosesAction; // 0x38

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
        public System.Collections.Generic.Dictionary`2<uint,0x6656B3E8> trackingReferences; // 0x20

        // ── Methods ──
        public void OnEnable(){} // RVA: 0x7FFD540DAA10
        public void OnDisable(){} // RVA: 0x7FFD540DAAF0
        public void OnNewPoses(){} // RVA: 0x7FFD540DAC00
        public void .ctor(){} // RVA: 0x7FFD540DAF90
    }

}