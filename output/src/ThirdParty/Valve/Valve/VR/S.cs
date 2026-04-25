// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 100
// Methods: 1820

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
        public 0x6B20A158 usingNativeSupport; // 0x10
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
        public RigidTransform[] hmd_TrackingSystemName; // 0x48
        public 0x6B23FE70 hmd_ActualTrackingSystemName; // 0x50
        public bool hmd_ModelNumber; // 0x30
        public string hmd_SerialNumber;
        public string hmd_Type;

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFAC8C90060
        public void get_enabled(){} // RVA: 0x7FFAC8C900C0
        public void set_enabled(){} // RVA: 0x7FFAC8C902F0
        public void get_instance(){} // RVA: 0x7FFAC8C90390
        public void Initialize(){} // RVA: 0x7FFAC8C904F0
        public void get_usingNativeSupport(){} // RVA: 0x7FFAC8C906B0
        public void get_settings(){} // RVA: 0x7FFAC8C90700
        public void set_settings(){} // RVA: 0x7FFAC8C90760
        public void ReportGeneralErrors(){} // RVA: 0x7FFAC8C90820
        public void CreateInstance(){} // RVA: 0x7FFAC8C908B0
        public void ReportError(){} // RVA: 0x7FFAC8C90F50
        public void get_hmd(){} // RVA: 0x7FFAC2F3C380
        public void set_hmd(){} // RVA: 0x7FFAC2F22E30
        public void get_compositor(){} // RVA: 0x7FFAC2F247C0
        public void set_compositor(){} // RVA: 0x7FFAC2F87E80
        public void get_overlay(){} // RVA: 0x7FFAC2F4F0C0
        public void set_overlay(){} // RVA: 0x7FFAC2F4F0D0
        public void get_initializing(){} // RVA: 0x7FFAC8C91110
        public void set_initializing(){} // RVA: 0x7FFAC8C91170
        public void get_calibrating(){} // RVA: 0x7FFAC8C911D0
        public void set_calibrating(){} // RVA: 0x7FFAC8C91230
        public void get_outOfRange(){} // RVA: 0x7FFAC8C91290
        public void set_outOfRange(){} // RVA: 0x7FFAC8C912F0
        public void get_sceneWidth(){} // RVA: 0x7FFAC3000210
        public void set_sceneWidth(){} // RVA: 0x7FFAC3000220
        public void get_sceneHeight(){} // RVA: 0x7FFAC33EAB80
        public void set_sceneHeight(){} // RVA: 0x7FFAC33EA9D0
        public void get_aspect(){} // RVA: 0x7FFAC3C40670
        public void set_aspect(){} // RVA: 0x7FFAC47394E0
        public void get_fieldOfView(){} // RVA: 0x7FFAC2FEB630
        public void set_fieldOfView(){} // RVA: 0x7FFAC2FEB640
        public void get_tanHalfFov(){} // RVA: 0x7FFAC3FA0C70
        public void set_tanHalfFov(){} // RVA: 0x7FFAC35233F0
        public void get_textureBounds(){} // RVA: 0x7FFAC2F9E740
        public void set_textureBounds(){} // RVA: 0x7FFAC2F49200
        public void get_eyes(){} // RVA: 0x7FFAC2F9C730
        public void set_eyes(){} // RVA: 0x7FFAC2F9C740
        public void get_hmd_TrackingSystemName(){} // RVA: 0x7FFAC8C91350
        public void get_hmd_ActualTrackingSystemName(){} // RVA: 0x7FFAC8C91360
        public void get_hmd_ModelNumber(){} // RVA: 0x7FFAC8C91370
        public void get_hmd_SerialNumber(){} // RVA: 0x7FFAC8C91380
        public void get_hmd_Type(){} // RVA: 0x7FFAC8C91390
        public void get_hmd_SecondsFromVsyncToPhotons(){} // RVA: 0x7FFAC8C913A0
        public void get_hmd_DisplayFrequency(){} // RVA: 0x7FFAC8C913F0
        public void GetHeadsetActivityLevel(){} // RVA: 0x7FFAC8C91440
        public void GetTrackedDeviceString(){} // RVA: 0x7FFAC8C91490
        public void GetStringProperty(){} // RVA: 0x7FFAC8C915D0
        public void GetFloatProperty(){} // RVA: 0x7FFAC8C91770
        public void InitializeTemporarySession(){} // RVA: 0x7FFAC8C917C0
        public void ExitTemporarySession(){} // RVA: 0x7FFAC8C91880
        public void GenerateAppKey(){} // RVA: 0x7FFAC8C91920
        public void GenerateCleanProductName(){} // RVA: 0x7FFAC8C91B40
        public void GetManifestFile(){} // RVA: 0x7FFAC8C91CD0
        public void IdentifyEditorApplication(){} // RVA: 0x7FFAC8C928B0
        public void OnInitializing(){} // RVA: 0x7FFAC8C92D30
        public void OnCalibrating(){} // RVA: 0x7FFAC8C92DD0
        public void OnOutOfRange(){} // RVA: 0x7FFAC8C92E70
        public void OnDeviceConnected(){} // RVA: 0x7FFAC8C92F10
        public void OnNewPoses(){} // RVA: 0x7FFAC8C92FA0
        public void .ctor(){} // RVA: 0x7FFAC8C934A0
        public void Finalize(){} // RVA: 0x7FFAC8C942F0
        public void Dispose(){} // RVA: 0x7FFAC8C943A0 | overloaded x2
        public void SafeDispose(){} // RVA: 0x7FFAC8C947C0
        public void .cctor(){} // RVA: 0x7FFAC8C948B0
    }

    public class SteamVREnumEqualityComparer`1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC2E8DC40
        public void GetHashCode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class SteamVR_Action : Object
    {
        public string fullPath; // 0x10
        public bool handle; // 0x18
        public bool actionSet;
        public string direction; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void CreateUninitialized(){} // RVA: 0x7FFAC2C76500 | overloaded x4
        public void GetCopy(){} // RVA: 0x7FFAC2E8DC40
        public void TryNeedsInitData(){} // RVA: 0x7FFAC2C58E90
        public void InitializeCopy(){} // RVA: 0x7FFAC2C79B30
        public void get_fullPath(){} // RVA: 0x7FFAC2C58E90
        public void get_handle(){} // RVA: 0x7FFAC2C58E90
        public void get_actionSet(){} // RVA: 0x7FFAC2C58E90
        public void get_direction(){} // RVA: 0x7FFAC2C59960
        public void get_setActive(){} // RVA: 0x7FFAC8C3A240
        public void get_active(){} // RVA: 0x7FFAC2C59D00
        public void get_activeBinding(){} // RVA: 0x7FFAC2C59D00
        public void get_lastActive(){} // RVA: 0x7FFAC2C59D00
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC2C59D00
        public void PreInitialize(){} // RVA: 0x7FFAC2C70A40
        public void Initialize(){} // RVA: 0x7FFAC2C710F0
        public void GetTimeLastChanged(){} // RVA: 0x7FFAC2C6DC30
        public void GetSourceMap(){} // RVA: 0x7FFAC2C58E90
        public void GetActive(){} // RVA: 0x7FFAC2C5A310
        public void GetSetActive(){} // RVA: 0x7FFAC8C3A2A0
        public void GetActiveBinding(){} // RVA: 0x7FFAC2C5A310
        public void GetLastActive(){} // RVA: 0x7FFAC2C5A310
        public void GetLastActiveBinding(){} // RVA: 0x7FFAC2C5A310
        public void GetPath(){} // RVA: 0x7FFAC2F3C380
        public void IsUpdating(){} // RVA: 0x7FFAC2C5A310
        public void GetHashCode(){} // RVA: 0x7FFAC8C3A320
        public void Equals(){} // RVA: 0x7FFAC8C3A3A0 | overloaded x2
        public void op_Inequality(){} // RVA: 0x7FFAC8C3A4D0
        public void op_Equality(){} // RVA: 0x7FFAC8C3A600
        public void FindExistingActionForPartialPath(){} // RVA: 0x7FFAC8C3A700
        public void GetShortName(){} // RVA: 0x7FFAC8C3A820
        public void ShowOrigins(){} // RVA: 0x7FFAC8C3A8C0
        public void HideOrigins(){} // RVA: 0x7FFAC8C3A990
        public void .cctor(){} // RVA: 0x7FFAC8C3A9E0
    }

    public class SteamVR_ActionSet : Object
    {
        public string allActions; // 0x10
        public Valve.VR.SteamVR_ActionSet_Data nonVisualInActions; // 0x18
        public bool visualActions; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void get_allActions(){} // RVA: 0x7FFAC8C3B620
        public void get_nonVisualInActions(){} // RVA: 0x7FFAC8C3B660
        public void get_visualActions(){} // RVA: 0x7FFAC8C3B6A0
        public void get_poseActions(){} // RVA: 0x7FFAC8C3B6E0
        public void get_skeletonActions(){} // RVA: 0x7FFAC8C3B720
        public void get_outActionArray(){} // RVA: 0x7FFAC8C3B760
        public void get_fullPath(){} // RVA: 0x7FFAC8C3B7A0
        public void get_usage(){} // RVA: 0x7FFAC8C3B7E0
        public void get_handle(){} // RVA: 0x7FFAC8C3B820
        public void Create(){} // RVA: 0x7FFAC2E8DC40
        public void CreateFromName(){} // RVA: 0x7FFAC2E8DC40
        public void PreInitialize(){} // RVA: 0x7FFAC8C3B860
        public void FinishPreInitialize(){} // RVA: 0x7FFAC8C3B9E0
        public void Initialize(){} // RVA: 0x7FFAC8C3BA00
        public void GetPath(){} // RVA: 0x7FFAC2F3C380
        public void IsActive(){} // RVA: 0x7FFAC8C3BAE0
        public void GetTimeLastChanged(){} // RVA: 0x7FFAC8C3BB40
        public void Activate(){} // RVA: 0x7FFAC8C3BB90
        public void Deactivate(){} // RVA: 0x7FFAC8C3BD40
        public void GetShortName(){} // RVA: 0x7FFAC8C3BE50
        public void ShowBindingHints(){} // RVA: 0x7FFAC8C3BEE0
        public void ReadRawSetActive(){} // RVA: 0x7FFAC8C3C020
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFAC8C3C060
        public void ReadRawSetPriority(){} // RVA: 0x7FFAC8C3C0A0
        public void GetActionSetData(){} // RVA: 0x7FFAC2F247C0
        public void GetCopy(){} // RVA: 0x7FFAC2E8DC40
        public void Equals(){} // RVA: 0x7FFAC8C3C0E0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC8C3A320
        public void op_Inequality(){} // RVA: 0x7FFAC8C3C1F0
        public void op_Equality(){} // RVA: 0x7FFAC8C3C2B0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C3C360
    }

    public class SteamVR_ActionSet_Data : Object
    {
        public Valve.VR.SteamVR_Action[] allActions; // 0x10
        public Valve.VR.ISteamVR_Action_In[] nonVisualInActions; // 0x18
        public Valve.VR.ISteamVR_Action_In[] visualActions; // 0x20
        public Valve.VR.SteamVR_Action_Pose[] poseActions; // 0x28
        public Valve.VR.SteamVR_Action_Skeleton[] skeletonActions; // 0x30
        public Valve.VR.ISteamVR_Action_Out[] outActionArray; // 0x38
        public string fullPath; // 0x40
        public string usage; // 0x48
        public ulong handle; // 0x50
        public bool[] rawSetActive; // 0x58
        public float[] rawSetLastChanged; // 0x60
        public int[] rawSetPriority; // 0x68
        public bool initialized; // 0x70
        public string cachedShortName; // 0x78

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C3C480
        public void get_allActions(){} // RVA: 0x7FFAC2F3C380
        public void set_allActions(){} // RVA: 0x7FFAC2F22E30
        public void get_nonVisualInActions(){} // RVA: 0x7FFAC2F247C0
        public void set_nonVisualInActions(){} // RVA: 0x7FFAC2F87E80
        public void get_visualActions(){} // RVA: 0x7FFAC2F4F0C0
        public void set_visualActions(){} // RVA: 0x7FFAC2F4F0D0
        public void get_poseActions(){} // RVA: 0x7FFAC2F4F130
        public void set_poseActions(){} // RVA: 0x7FFAC2F22E90
        public void get_skeletonActions(){} // RVA: 0x7FFAC31D95E0
        public void set_skeletonActions(){} // RVA: 0x7FFAC2F4F890
        public void get_outActionArray(){} // RVA: 0x7FFAC31D0140
        public void set_outActionArray(){} // RVA: 0x7FFAC31D0C20
        public void get_fullPath(){} // RVA: 0x7FFAC2F9E740
        public void set_fullPath(){} // RVA: 0x7FFAC2F49200
        public void get_usage(){} // RVA: 0x7FFAC2F9C730
        public void set_usage(){} // RVA: 0x7FFAC2F9C740
        public void get_handle(){} // RVA: 0x7FFAC2FC20E0
        public void set_handle(){} // RVA: 0x7FFAC42499F0
        public void PreInitialize(){} // RVA: 0x7FFAC2F21310
        public void FinishPreInitialize(){} // RVA: 0x7FFAC8C3C660
        public void Initialize(){} // RVA: 0x7FFAC8C3D0D0
        public void IsActive(){} // RVA: 0x7FFAC8C3D2C0
        public void GetTimeLastChanged(){} // RVA: 0x7FFAC8C3D310
        public void Activate(){} // RVA: 0x7FFAC8C3D350
        public void Deactivate(){} // RVA: 0x7FFAC8C3D4F0
        public void GetShortName(){} // RVA: 0x7FFAC8C3D600
        public void ReadRawSetActive(){} // RVA: 0x7FFAC8C3D680
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFAC8C3D6B0
        public void ReadRawSetPriority(){} // RVA: 0x7FFAC8C3D6E0
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
        public void get_rawActiveActionSetArray(){} // RVA: 0x7FFAC8C3D710
        public void Initialize(){} // RVA: 0x7FFAC8C3D790
        public void DisableAllActionSets(){} // RVA: 0x7FFAC8C3D940
        public void UpdateActionStates(){} // RVA: 0x7FFAC8C3DA80
        public void SetChanged(){} // RVA: 0x7FFAC8C3DDA0
        public void GetNewArraySize(){} // RVA: 0x7FFAC8C3DDE0
        public void UpdateActionSetsArray(){} // RVA: 0x7FFAC8C3DF20
        public void GetSetFromHandle(){} // RVA: 0x7FFAC8C3E430
        public void UpdateDebugText(){} // RVA: 0x7FFAC8C3E550
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
        public void add_onChange(){} // RVA: 0x7FFAC8C3E9F0
        public void remove_onChange(){} // RVA: 0x7FFAC8C3EA70
        public void add_onUpdate(){} // RVA: 0x7FFAC8C3EAF0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C3EB70
        public void add_onState(){} // RVA: 0x7FFAC8C3EBF0
        public void remove_onState(){} // RVA: 0x7FFAC8C3EC70
        public void add_onStateDown(){} // RVA: 0x7FFAC8C3ECF0
        public void remove_onStateDown(){} // RVA: 0x7FFAC8C3ED70
        public void add_onStateUp(){} // RVA: 0x7FFAC8C3EDF0
        public void remove_onStateUp(){} // RVA: 0x7FFAC8C3EE70
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C3EEF0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C3EF70
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C3EFF0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C3F070
        public void get_state(){} // RVA: 0x7FFAC8C3F0F0
        public void get_stateDown(){} // RVA: 0x7FFAC8C3F180
        public void get_stateUp(){} // RVA: 0x7FFAC8C3F210
        public void get_lastState(){} // RVA: 0x7FFAC8C3F2A0
        public void get_lastStateDown(){} // RVA: 0x7FFAC8C3F300
        public void get_lastStateUp(){} // RVA: 0x7FFAC8C3F380
        public void .ctor(){} // RVA: 0x7FFAC8C3F400
        public void GetStateDown(){} // RVA: 0x7FFAC8C3F440
        public void GetStateUp(){} // RVA: 0x7FFAC8C3F4E0
        public void GetState(){} // RVA: 0x7FFAC8C3F580
        public void GetLastStateDown(){} // RVA: 0x7FFAC8C3F620
        public void GetLastStateUp(){} // RVA: 0x7FFAC8C3F6B0
        public void GetLastState(){} // RVA: 0x7FFAC8C3F740
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C3F7B0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C3F830
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C3F8B0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C3F930
        public void AddOnChangeListener(){} // RVA: 0x7FFAC8C3F9B0
        public void RemoveOnChangeListener(){} // RVA: 0x7FFAC8C3FA30
        public void AddOnUpdateListener(){} // RVA: 0x7FFAC8C3FAB0
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFAC8C3FB30
        public void AddOnStateDownListener(){} // RVA: 0x7FFAC8C3FBB0
        public void RemoveOnStateDownListener(){} // RVA: 0x7FFAC8C3FC30
        public void AddOnStateUpListener(){} // RVA: 0x7FFAC8C3FCB0
        public void RemoveOnStateUpListener(){} // RVA: 0x7FFAC8C3FD30
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C3FDB0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C3FE20
    }

    public class SteamVR_Action_Boolean_Source : SteamVR_Action_In_Source
    {
        public uint state;
        public StateDownHandler stateDown; // 0x158
        public StateUpHandler stateUp; // 0x160
        public StateHandler changed; // 0x168
        public ActiveChangeHandler lastState; // 0x170
        public ActiveChangeHandler lastStateDown; // 0x178
        public ChangeHandler lastStateUp; // 0x180
        public UpdateHandler lastChanged; // 0x188
        public bool activeOrigin; // 0x190
        public Valve.VR.InputDigitalActionData_t lastActiveOrigin; // 0x198
        public Valve.VR.InputDigitalActionData_t active; // 0x1B0
        public Valve.VR.SteamVR_Action_Boolean activeBinding; // 0x1C8

        // ── Methods ──
        public void add_onStateDown(){} // RVA: 0x7FFAC8C40260
        public void remove_onStateDown(){} // RVA: 0x7FFAC8C40350
        public void add_onStateUp(){} // RVA: 0x7FFAC8C40440
        public void remove_onStateUp(){} // RVA: 0x7FFAC8C40530
        public void add_onState(){} // RVA: 0x7FFAC8C40620
        public void remove_onState(){} // RVA: 0x7FFAC8C40710
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C40800
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C408F0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C409E0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C40AD0
        public void add_onChange(){} // RVA: 0x7FFAC8C40BC0
        public void remove_onChange(){} // RVA: 0x7FFAC8C40CB0
        public void add_onUpdate(){} // RVA: 0x7FFAC8C40DA0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C40E90
        public void get_state(){} // RVA: 0x7FFAC8C40F80
        public void get_stateDown(){} // RVA: 0x7FFAC8C40FC0
        public void get_stateUp(){} // RVA: 0x7FFAC8C41000
        public void get_changed(){} // RVA: 0x7FFAC8C41040
        public void set_changed(){} // RVA: 0x7FFAC2F21310
        public void get_lastState(){} // RVA: 0x7FFAC8C41080
        public void get_lastStateDown(){} // RVA: 0x7FFAC8C41090
        public void get_lastStateUp(){} // RVA: 0x7FFAC8C410B0
        public void get_lastChanged(){} // RVA: 0x7FFAC8C410D0
        public void set_lastChanged(){} // RVA: 0x7FFAC2F21310
        public void get_activeOrigin(){} // RVA: 0x7FFAC8C410E0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC3544330
        public void get_active(){} // RVA: 0x7FFAC8C41120
        public void get_activeBinding(){} // RVA: 0x7FFAC8B3EBF0
        public void get_lastActive(){} // RVA: 0x7FFAC8C411C0
        public void set_lastActive(){} // RVA: 0x7FFAC8C411D0
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC8C411E0
        public void Preinitialize(){} // RVA: 0x7FFAC8C411F0
        public void Initialize(){} // RVA: 0x7FFAC8C41380
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C41460
        public void UpdateValue(){} // RVA: 0x7FFAC8C41800
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Action_Boolean_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C40220
    }

    public class SteamVR_Action_In_Source : SteamVR_Action_Source
    {
        public uint isUpdating;
        public bool updateTime; // 0x28
        public float activeOrigin; // 0x2C
        public float lastActiveOrigin; // 0x30
        public int changed; // 0x34
        public Valve.VR.InputOriginInfo_t lastChanged; // 0x38
        public Valve.VR.InputOriginInfo_t activeDevice; // 0xC8

        // ── Methods ──
        public void get_isUpdating(){} // RVA: 0x7FFAC30F6BA0
        public void set_isUpdating(){} // RVA: 0x7FFAC3C24F40
        public void get_updateTime(){} // RVA: 0x7FFAC33EAB80
        public void set_updateTime(){} // RVA: 0x7FFAC33EA9D0
        public void get_activeOrigin(){} // RVA: 0x7FFAC2C58E90
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC2C58E90
        public void get_changed(){} // RVA: 0x7FFAC2C59D00
        public void set_changed(){} // RVA: 0x7FFAC2C71060
        public void get_lastChanged(){} // RVA: 0x7FFAC2C59D00
        public void set_lastChanged(){} // RVA: 0x7FFAC2C71060
        public void get_activeDevice(){} // RVA: 0x7FFAC8C41F20
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFAC8C41F80
        public void get_renderModelComponentName(){} // RVA: 0x7FFAC8C41FA0
        public void get_localizedOriginName(){} // RVA: 0x7FFAC8C41FC0
        public void get_changedTime(){} // RVA: 0x7FFAC3C40670
        public void set_changedTime(){} // RVA: 0x7FFAC47394E0
        public void get_lastOriginGetFrame(){} // RVA: 0x7FFAC3ADEDC0
        public void set_lastOriginGetFrame(){} // RVA: 0x7FFAC416A6E0
        public void UpdateValue(){} // RVA: 0x7FFAC2C70980
        public void Initialize(){} // RVA: 0x7FFAC8C41FE0
        public void UpdateOriginTrackedDeviceInfo(){} // RVA: 0x7FFAC8C42100
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFAC8C42580
        public void GetLocalizedOrigin(){} // RVA: 0x7FFAC8C42630
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public System.Collections.Generic.List`1<int> updatingSources; // 0x40

        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x7FFAC69A2240
        public void OnAccessSource(){} // RVA: 0x7FFAC69A22F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7FFAC69A2380
        public void UpdateValues(){} // RVA: 0x7FFAC69A2530
        public void .ctor(){} // RVA: 0x7FFAC69A2610
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
        public void get_changed(){} // RVA: 0x7FFAC69A26F0
        public void get_lastChanged(){} // RVA: 0x7FFAC69A26F0
        public void get_changedTime(){} // RVA: 0x7FFAC69A2740
        public void get_updateTime(){} // RVA: 0x7FFAC69A2780
        public void get_activeOrigin(){} // RVA: 0x7FFAC69A27C0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC69A2810
        public void get_activeDevice(){} // RVA: 0x7FFAC69A2860
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFAC69A28F0
        public void get_renderModelComponentName(){} // RVA: 0x7FFAC69A2940
        public void get_localizedOriginName(){} // RVA: 0x7FFAC69A2990
        public void UpdateValues(){} // RVA: 0x7FFAC69A29E0
        public void GetRenderModelComponentName(){} // RVA: 0x7FFAC69A2AD0
        public void GetActiveDevice(){} // RVA: 0x7FFAC69A2B20
        public void GetDeviceIndex(){} // RVA: 0x7FFAC69A2BB0
        public void GetChanged(){} // RVA: 0x7FFAC69A2C00
        public void GetTimeLastChanged(){} // RVA: 0x7FFAC69A2C50
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFAC69A2C90
        public void GetLocalizedOrigin(){} // RVA: 0x7FFAC69A2CE0
        public void IsUpdating(){} // RVA: 0x7FFAC69A2D20
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7FFAC69A2DE0
        public void GetControllerType(){} // RVA: 0x7FFAC69A2E10
        public void .ctor(){} // RVA: 0x7FFAC69A2EB0
    }

    public class SteamVR_Action_Out_Source : SteamVR_Action_Source
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C42720
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C427A0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C42820
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C42960
        public void add_onChange(){} // RVA: 0x7FFAC8C429E0
        public void remove_onChange(){} // RVA: 0x7FFAC8C42A60
        public void add_onUpdate(){} // RVA: 0x7FFAC8C42AE0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C42B60
        public void add_onTrackingChanged(){} // RVA: 0x7FFAC8C42BE0
        public void remove_onTrackingChanged(){} // RVA: 0x7FFAC8C42C60
        public void add_onValidPoseChanged(){} // RVA: 0x7FFAC8C42CE0
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFAC8C42D60
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C42DE0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C42E60
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7FFAC8C42EE0
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7FFAC8C42F60
        public void AddOnTrackingChanged(){} // RVA: 0x7FFAC8C42FE0
        public void RemoveOnTrackingChanged(){} // RVA: 0x7FFAC8C43060
        public void AddOnValidPoseChanged(){} // RVA: 0x7FFAC8C430E0
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7FFAC8C43160
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C431E0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C43260
        public void AddOnChangeListener(){} // RVA: 0x7FFAC8C432E0
        public void RemoveOnChangeListener(){} // RVA: 0x7FFAC8C43360
        public void AddOnUpdateListener(){} // RVA: 0x7FFAC8C433E0
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFAC8C43460
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C434E0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C43560
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7FFAC8C435A0
        public void .ctor(){} // RVA: 0x7FFAC8C437B0
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
        public void SetUniverseOrigin(){} // RVA: 0x7FFAC2C71DD0
        public void get_localPosition(){} // RVA: 0x7FFAC2C588A0
        public void get_localRotation(){} // RVA: 0x7FFAC2C588A0
        public void get_trackingState(){} // RVA: 0x7FFAC2C59960
        public void get_velocity(){} // RVA: 0x7FFAC2C588A0
        public void get_angularVelocity(){} // RVA: 0x7FFAC2C588A0
        public void get_poseIsValid(){} // RVA: 0x7FFAC2C59D00
        public void get_deviceIsConnected(){} // RVA: 0x7FFAC2C59D00
        public void get_lastLocalPosition(){} // RVA: 0x7FFAC2C588A0
        public void get_lastLocalRotation(){} // RVA: 0x7FFAC2C588A0
        public void get_lastTrackingState(){} // RVA: 0x7FFAC2C59960
        public void get_lastVelocity(){} // RVA: 0x7FFAC2C588A0
        public void get_lastAngularVelocity(){} // RVA: 0x7FFAC2C588A0
        public void get_lastPoseIsValid(){} // RVA: 0x7FFAC2C59D00
        public void get_lastDeviceIsConnected(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void UpdateValues(){} // RVA: 0x7FFAC2C71060
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFAC2E8DC40
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateTransform(){} // RVA: 0x7FFAC2C72BC0
        public void GetLocalPosition(){} // RVA: 0x7FFAC2C59BF0
        public void GetLocalRotation(){} // RVA: 0x7FFAC2C59BF0
        public void GetVelocity(){} // RVA: 0x7FFAC2C59BF0
        public void GetAngularVelocity(){} // RVA: 0x7FFAC2C59BF0
        public void GetDeviceIsConnected(){} // RVA: 0x7FFAC2C5A310
        public void GetPoseIsValid(){} // RVA: 0x7FFAC2C5A310
        public void GetTrackingResult(){} // RVA: 0x7FFAC2C600D0
        public void GetLastLocalPosition(){} // RVA: 0x7FFAC2C59BF0
        public void GetLastLocalRotation(){} // RVA: 0x7FFAC2C59BF0
        public void GetLastVelocity(){} // RVA: 0x7FFAC2C59BF0
        public void GetLastAngularVelocity(){} // RVA: 0x7FFAC2C59BF0
        public void GetLastDeviceIsConnected(){} // RVA: 0x7FFAC2C5A310
        public void GetLastPoseIsValid(){} // RVA: 0x7FFAC2C5A310
        public void GetLastTrackingResult(){} // RVA: 0x7FFAC2C600D0
    }

    public class SteamVR_Action_Pose_Source : SteamVR_Action_In_Source
    {
        public 0x6B240028 changed; // 0x158
        public uint lastChanged;
        public float activeOrigin; // 0x15C
        public ActiveChangeHandler lastActiveOrigin; // 0x160
        public ActiveChangeHandler active; // 0x168
        public ChangeHandler activeBinding; // 0x170
        public UpdateHandler lastActive; // 0x178
        public TrackingChangeHandler lastActiveBinding; // 0x180
        public ValidPoseChangeHandler trackingState; // 0x188
        public DeviceConnectedChangeHandler lastTrackingState; // 0x190
        public bool poseIsValid; // 0x198
        public bool lastPoseIsValid; // 0x199
        public bool deviceIsConnected; // 0x19A
        public UnityEngine.Vector3 lastDeviceIsConnected; // 0x19C
        public UnityEngine.Quaternion localPosition; // 0x1A8
        public UnityEngine.Vector3 localRotation; // 0x1B8
        public UnityEngine.Quaternion lastLocalPosition; // 0x1C4
        public UnityEngine.Vector3 lastLocalRotation; // 0x1D4
        public UnityEngine.Vector3 velocity; // 0x1E0
        public UnityEngine.Vector3 lastVelocity; // 0x1EC
        public UnityEngine.Vector3 angularVelocity; // 0x1F8
        public Valve.VR.InputPoseActionData_t lastAngularVelocity; // 0x208
        public Valve.VR.InputPoseActionData_t lastPoseActionData; // 0x268
        public Valve.VR.InputPoseActionData_t tempPoseActionData; // 0x2C8
        public Valve.VR.SteamVR_Action_Pose poseAction; // 0x328
        public float framesAhead; // 0x4

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C43BE0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C43CD0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C43DC0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C43EB0
        public void add_onChange(){} // RVA: 0x7FFAC8C43FA0
        public void remove_onChange(){} // RVA: 0x7FFAC8C44090
        public void add_onUpdate(){} // RVA: 0x7FFAC8C44180
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C44270
        public void add_onTrackingChanged(){} // RVA: 0x7FFAC8C44360
        public void remove_onTrackingChanged(){} // RVA: 0x7FFAC8C44450
        public void add_onValidPoseChanged(){} // RVA: 0x7FFAC8C44540
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFAC8C44630
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C44720
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C44810
        public void get_changed(){} // RVA: 0x7FFAC8B3EBF0
        public void set_changed(){} // RVA: 0x7FFAC8B3EC00
        public void get_lastChanged(){} // RVA: 0x7FFAC8C44900
        public void set_lastChanged(){} // RVA: 0x7FFAC8C44910
        public void get_activeOrigin(){} // RVA: 0x7FFAC8C44920
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC39C8960
        public void get_active(){} // RVA: 0x7FFAC8C41120
        public void get_activeBinding(){} // RVA: 0x7FFAC8C44960
        public void get_lastActive(){} // RVA: 0x7FFAC8C44970
        public void set_lastActive(){} // RVA: 0x7FFAC8C44980
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC8B3F920
        public void get_trackingState(){} // RVA: 0x7FFAC2F819C0
        public void get_lastTrackingState(){} // RVA: 0x7FFAC8B12FB0
        public void get_poseIsValid(){} // RVA: 0x7FFAC8C44990
        public void get_lastPoseIsValid(){} // RVA: 0x7FFAC8C449A0
        public void get_deviceIsConnected(){} // RVA: 0x7FFAC8C449B0
        public void get_lastDeviceIsConnected(){} // RVA: 0x7FFAC8C449C0
        public void get_localPosition(){} // RVA: 0x7FFAC8C449D0
        public void set_localPosition(){} // RVA: 0x7FFAC8C449F0
        public void get_localRotation(){} // RVA: 0x7FFAC8C44A10
        public void set_localRotation(){} // RVA: 0x7FFAC8C44A20
        public void get_lastLocalPosition(){} // RVA: 0x7FFAC8C44A30
        public void set_lastLocalPosition(){} // RVA: 0x7FFAC8C44A50
        public void get_lastLocalRotation(){} // RVA: 0x7FFAC8C44A70
        public void set_lastLocalRotation(){} // RVA: 0x7FFAC8C44A80
        public void get_velocity(){} // RVA: 0x7FFAC8C44A90
        public void set_velocity(){} // RVA: 0x7FFAC8C44AB0
        public void get_lastVelocity(){} // RVA: 0x7FFAC8C44AD0
        public void set_lastVelocity(){} // RVA: 0x7FFAC8C44AF0
        public void get_angularVelocity(){} // RVA: 0x7FFAC8C44B10
        public void set_angularVelocity(){} // RVA: 0x7FFAC8C44B30
        public void get_lastAngularVelocity(){} // RVA: 0x7FFAC8C44B50
        public void set_lastAngularVelocity(){} // RVA: 0x7FFAC8C44B70
        public void Preinitialize(){} // RVA: 0x7FFAC8C44B90
        public void Initialize(){} // RVA: 0x7FFAC8C44CE0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C44DF0
        public void UpdateValue(){} // RVA: 0x7FFAC8C45240 | overloaded x2
        public void SetCacheVariables(){} // RVA: 0x7FFAC8C45A00
        public void GetChanged(){} // RVA: 0x7FFAC8C45B20
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFAC8C45DF0
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFAC8C46220
        public void UpdateTransform(){} // RVA: 0x7FFAC8C46740
        public void CheckAndSendEvents(){} // RVA: 0x7FFAC8C46820
        public void GetUnityCoordinateVelocity(){} // RVA: 0x7FFAC8C46B10 | overloaded x2
        public void GetUnityCoordinateAngularVelocity(){} // RVA: 0x7FFAC8C46B30 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC8C46B60
        public void .cctor(){} // RVA: 0x7FFAC8C46BB0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7FFAC2C70ED0
        public void UpdateValues(){} // RVA: 0x7FFAC2C71060
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class SteamVR_Action_Single : SteamVR_Action_In`2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFAC8C46C10
        public void remove_onChange(){} // RVA: 0x7FFAC8C46C90
        public void add_onUpdate(){} // RVA: 0x7FFAC8C46D10
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C46D90
        public void add_onAxis(){} // RVA: 0x7FFAC8C46E10
        public void remove_onAxis(){} // RVA: 0x7FFAC8C46E90
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C46F10
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C46F90
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C47010
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C47090
        public void get_axis(){} // RVA: 0x7FFAC8C47110
        public void get_lastAxis(){} // RVA: 0x7FFAC8C471A0
        public void get_delta(){} // RVA: 0x7FFAC8C47230
        public void get_lastDelta(){} // RVA: 0x7FFAC8C472C0
        public void .ctor(){} // RVA: 0x7FFAC8C47350
        public void GetAxis(){} // RVA: 0x7FFAC8C47390
        public void GetAxisDelta(){} // RVA: 0x7FFAC8C47430
        public void GetLastAxis(){} // RVA: 0x7FFAC8C474D0
        public void GetLastAxisDelta(){} // RVA: 0x7FFAC8C47570
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C47610
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C47690
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C47710
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C47790
        public void AddOnChangeListener(){} // RVA: 0x7FFAC8C47810
        public void RemoveOnChangeListener(){} // RVA: 0x7FFAC8C47890
        public void AddOnUpdateListener(){} // RVA: 0x7FFAC8C47910
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFAC8C47990
        public void AddOnAxisListener(){} // RVA: 0x7FFAC8C47A10
        public void RemoveOnAxisListener(){} // RVA: 0x7FFAC8C47A90
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C47B10
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C47B80
    }

    public class SteamVR_Action_Single_Source : SteamVR_Action_In_Source
    {
        public uint axis;
        public float lastAxis; // 0x158
        public AxisHandler delta; // 0x160
        public ActiveChangeHandler lastDelta; // 0x168
        public ActiveChangeHandler changed; // 0x170
        public ChangeHandler lastChanged; // 0x178
        public UpdateHandler activeOrigin; // 0x180
        public bool lastActiveOrigin; // 0x188
        public bool active; // 0x189
        public bool activeBinding; // 0x18A
        public Valve.VR.InputAnalogActionData_t lastActive; // 0x190
        public Valve.VR.InputAnalogActionData_t lastActiveBinding; // 0x1C0
        public Valve.VR.SteamVR_Action_Single singleAction; // 0x1F0

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7FFAC8C47F20
        public void remove_onAxis(){} // RVA: 0x7FFAC8C48010
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C48100
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C481F0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C482E0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C483D0
        public void add_onChange(){} // RVA: 0x7FFAC8C484C0
        public void remove_onChange(){} // RVA: 0x7FFAC8C485B0
        public void add_onUpdate(){} // RVA: 0x7FFAC8C486A0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C48790
        public void get_axis(){} // RVA: 0x7FFAC8C48880
        public void get_lastAxis(){} // RVA: 0x7FFAC8C488C0
        public void get_delta(){} // RVA: 0x7FFAC8C48900
        public void get_lastDelta(){} // RVA: 0x7FFAC8C48940
        public void get_changed(){} // RVA: 0x7FFAC8C48980
        public void set_changed(){} // RVA: 0x7FFAC8C48990
        public void get_lastChanged(){} // RVA: 0x7FFAC8C489A0
        public void set_lastChanged(){} // RVA: 0x7FFAC8C489B0
        public void get_activeOrigin(){} // RVA: 0x7FFAC8C489C0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC39CCB10
        public void get_active(){} // RVA: 0x7FFAC8C41120
        public void get_activeBinding(){} // RVA: 0x7FFAC8C411C0
        public void get_lastActive(){} // RVA: 0x7FFAC8C48A00
        public void set_lastActive(){} // RVA: 0x7FFAC8C48A10
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC8C41080
        public void Preinitialize(){} // RVA: 0x7FFAC8C48A20
        public void Initialize(){} // RVA: 0x7FFAC8C48BB0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C48C90
        public void UpdateValue(){} // RVA: 0x7FFAC8C48F90
        public void .ctor(){} // RVA: 0x7FFAC8C49790
    }

    public class SteamVR_Action_Single_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C47EE0
    }

    public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base`2
    {
        public int bonePositions;
        public UnityEngine.Quaternion boneRotations;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C497E0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C49860
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C498E0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C49A20
        public void add_onChange(){} // RVA: 0x7FFAC8C49AA0
        public void remove_onChange(){} // RVA: 0x7FFAC8C49B20
        public void add_onUpdate(){} // RVA: 0x7FFAC8C49BA0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C49C20
        public void add_onTrackingChanged(){} // RVA: 0x7FFAC8C49CA0
        public void remove_onTrackingChanged(){} // RVA: 0x7FFAC8C49D20
        public void add_onValidPoseChanged(){} // RVA: 0x7FFAC8C49DA0
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFAC8C49E20
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C49EA0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C49F20
        public void .ctor(){} // RVA: 0x7FFAC8C49FA0
        public void UpdateValue(){} // RVA: 0x7FFAC8C49FF0
        public void UpdateValueWithoutEvents(){} // RVA: 0x7FFAC8C4A070
        public void UpdateTransform(){} // RVA: 0x7FFAC8C4A0F0
        public void get_bonePositions(){} // RVA: 0x7FFAC8C4A220
        public void get_boneRotations(){} // RVA: 0x7FFAC8C4A280
        public void get_lastBonePositions(){} // RVA: 0x7FFAC8C4A2E0
        public void get_lastBoneRotations(){} // RVA: 0x7FFAC8C4A340
        public void get_rangeOfMotion(){} // RVA: 0x7FFAC8C4A3A0
        public void set_rangeOfMotion(){} // RVA: 0x7FFAC8C4A400
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFAC8C4A470
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFAC8C4A4D0
        public void get_summaryDataType(){} // RVA: 0x7FFAC8C4A540
        public void set_summaryDataType(){} // RVA: 0x7FFAC8C4A5A0
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFAC8C4A610
        public void get_thumbCurl(){} // RVA: 0x7FFAC8C4A680
        public void get_indexCurl(){} // RVA: 0x7FFAC8C4A700
        public void get_middleCurl(){} // RVA: 0x7FFAC8C4A780
        public void get_ringCurl(){} // RVA: 0x7FFAC8C4A800
        public void get_pinkyCurl(){} // RVA: 0x7FFAC8C4A880
        public void get_thumbIndexSplay(){} // RVA: 0x7FFAC8C4A900
        public void get_indexMiddleSplay(){} // RVA: 0x7FFAC8C4A980
        public void get_middleRingSplay(){} // RVA: 0x7FFAC8C4AA00
        public void get_ringPinkySplay(){} // RVA: 0x7FFAC8C4AA80
        public void get_lastThumbCurl(){} // RVA: 0x7FFAC8C4AB00
        public void get_lastIndexCurl(){} // RVA: 0x7FFAC8C4AB80
        public void get_lastMiddleCurl(){} // RVA: 0x7FFAC8C4AC00
        public void get_lastRingCurl(){} // RVA: 0x7FFAC8C4AC80
        public void get_lastPinkyCurl(){} // RVA: 0x7FFAC8C4AD00
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFAC8C4AD80
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFAC8C4AE00
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFAC8C4AE80
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFAC8C4AF00
        public void get_fingerCurls(){} // RVA: 0x7FFAC8C4AF80
        public void get_fingerSplays(){} // RVA: 0x7FFAC8C4AFE0
        public void get_lastFingerCurls(){} // RVA: 0x7FFAC8C4B040
        public void get_lastFingerSplays(){} // RVA: 0x7FFAC8C4B0A0
        public void get_poseChanged(){} // RVA: 0x7FFAC8C4B100
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFAC8C4B160
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFAC8C4B1C0
        public void GetActive(){} // RVA: 0x7FFAC8C4B230
        public void GetSetActive(){} // RVA: 0x7FFAC8C3A240
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFAC8C4B2A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFAC8C4B340
        public void GetLocalPosition(){} // RVA: 0x7FFAC8C4B3E0
        public void GetLocalRotation(){} // RVA: 0x7FFAC8C4B460
        public void GetVelocity(){} // RVA: 0x7FFAC8C4B4E0
        public void GetAngularVelocity(){} // RVA: 0x7FFAC8C4B560
        public void GetDeviceIsConnected(){} // RVA: 0x7FFAC8C4B5E0
        public void GetPoseIsValid(){} // RVA: 0x7FFAC8C4B640
        public void GetTrackingResult(){} // RVA: 0x7FFAC8C4B6A0
        public void GetLastLocalPosition(){} // RVA: 0x7FFAC8C4B700
        public void GetLastLocalRotation(){} // RVA: 0x7FFAC8C4B780
        public void GetLastVelocity(){} // RVA: 0x7FFAC8C4B800
        public void GetLastAngularVelocity(){} // RVA: 0x7FFAC8C4B880
        public void GetLastDeviceIsConnected(){} // RVA: 0x7FFAC8C4B900
        public void GetLastPoseIsValid(){} // RVA: 0x7FFAC8C4B960
        public void GetLastTrackingResult(){} // RVA: 0x7FFAC8C4B9C0
        public void get_boneCount(){} // RVA: 0x7FFAC8C4BA20
        public void GetBonePositions(){} // RVA: 0x7FFAC8C4BA90
        public void GetBoneRotations(){} // RVA: 0x7FFAC8C4BB80
        public void GetLastBonePositions(){} // RVA: 0x7FFAC8C4BC70
        public void GetLastBoneRotations(){} // RVA: 0x7FFAC8C4BD60
        public void SetRangeOfMotion(){} // RVA: 0x7FFAC8C4BE50
        public void SetSkeletalTransformSpace(){} // RVA: 0x7FFAC8C4BEC0
        public void GetBoneCount(){} // RVA: 0x7FFAC8C4BA20
        public void GetBoneHierarchy(){} // RVA: 0x7FFAC8C4BF30
        public void GetBoneName(){} // RVA: 0x7FFAC8C4BFA0
        public void GetReferenceTransforms(){} // RVA: 0x7FFAC8C4C010
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFAC8C4C090
        public void GetFingerCurls(){} // RVA: 0x7FFAC8C4C100
        public void GetLastFingerCurls(){} // RVA: 0x7FFAC8C4C1F0
        public void GetFingerSplays(){} // RVA: 0x7FFAC8C4C2E0
        public void GetLastFingerSplays(){} // RVA: 0x7FFAC8C4C3D0
        public void GetFingerCurl(){} // RVA: 0x7FFAC8C4C4C0 | overloaded x2
        public void GetSplay(){} // RVA: 0x7FFAC8C4C550 | overloaded x2
        public void GetLastFingerCurl(){} // RVA: 0x7FFAC8C4C5E0 | overloaded x2
        public void GetLastSplay(){} // RVA: 0x7FFAC8C4C670 | overloaded x2
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C4C700
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C4C780
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7FFAC8C4C800
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7FFAC8C4C880
        public void AddOnTrackingChanged(){} // RVA: 0x7FFAC8C4C900
        public void RemoveOnTrackingChanged(){} // RVA: 0x7FFAC8C4C980
        public void AddOnValidPoseChanged(){} // RVA: 0x7FFAC8C4CA00
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7FFAC8C4CA80
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C4CB00
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C4CB80
        public void AddOnChangeListener(){} // RVA: 0x7FFAC8C4CC00
        public void RemoveOnChangeListener(){} // RVA: 0x7FFAC8C4CC80
        public void AddOnUpdateListener(){} // RVA: 0x7FFAC8C4CD00
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFAC8C4CD80
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C4CE00
        public void .cctor(){} // RVA: 0x7FFAC8C4CE40
    }

    public class SteamVR_Action_Skeleton_Source : SteamVR_Action_Pose_Source
    {
        public uint activeBinding;
        public ActiveChangeHandler lastActiveBinding; // 0x330
        public ActiveChangeHandler bonePositions; // 0x338
        public ChangeHandler boneRotations; // 0x340
        public UpdateHandler lastBonePositions; // 0x348
        public TrackingChangeHandler lastBoneRotations; // 0x350
        public ValidPoseChangeHandler rangeOfMotion; // 0x358
        public DeviceConnectedChangeHandler skeletalTransformSpace; // 0x360
        public UnityEngine.Vector3[] summaryDataType; // 0x368
        public UnityEngine.Quaternion[] thumbCurl; // 0x370
        public UnityEngine.Vector3[] indexCurl; // 0x378
        public UnityEngine.Quaternion[] middleCurl; // 0x380
        public 0x6B240868 ringCurl; // 0x388
        public 0x6B2414C8 pinkyCurl; // 0x38C
        public 0x6B241628 thumbIndexSplay; // 0x390
        public float[] indexMiddleSplay; // 0x398
        public float[] middleRingSplay; // 0x3A0
        public float[] ringPinkySplay; // 0x3A8
        public float[] lastThumbCurl; // 0x3B0
        public bool lastIndexCurl; // 0x3B8
        public bool lastMiddleCurl; // 0x3B9
        public Valve.VR.VRSkeletalSummaryData_t lastRingCurl; // 0x3BC
        public Valve.VR.VRSkeletalSummaryData_t lastPinkyCurl; // 0x3E0
        public Valve.VR.SteamVR_Action_Skeleton lastThumbIndexSplay; // 0x408
        public Valve.VR.VRBoneTransform_t[] lastIndexMiddleSplay; // 0x410
        public Valve.VR.InputSkeletalActionData_t lastMiddleRingSplay; // 0x418
        public Valve.VR.InputSkeletalActionData_t lastRingPinkySplay; // 0x428
        public Valve.VR.InputSkeletalActionData_t fingerCurls; // 0x438

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C4D1E0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C4D2D0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C4D3C0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C4D4B0
        public void add_onChange(){} // RVA: 0x7FFAC8C4D5A0
        public void remove_onChange(){} // RVA: 0x7FFAC8C4D690
        public void add_onUpdate(){} // RVA: 0x7FFAC8C4D780
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C4D870
        public void add_onTrackingChanged(){} // RVA: 0x7FFAC8C4D960
        public void remove_onTrackingChanged(){} // RVA: 0x7FFAC8C4DA50
        public void add_onValidPoseChanged(){} // RVA: 0x7FFAC8C4DB40
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFAC8C4DC30
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C4DD20
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFAC8C4DE10
        public void get_activeBinding(){} // RVA: 0x7FFAC7C50290
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC8C4DF00
        public void get_bonePositions(){} // RVA: 0x7FFAC39B3E70
        public void set_bonePositions(){} // RVA: 0x7FFAC39CFCC0
        public void get_boneRotations(){} // RVA: 0x7FFAC39CF840
        public void set_boneRotations(){} // RVA: 0x7FFAC39B40B0
        public void get_lastBonePositions(){} // RVA: 0x7FFAC39A7A10
        public void set_lastBonePositions(){} // RVA: 0x7FFAC39CF030
        public void get_lastBoneRotations(){} // RVA: 0x7FFAC39B02F0
        public void set_lastBoneRotations(){} // RVA: 0x7FFAC39C5290
        public void get_rangeOfMotion(){} // RVA: 0x7FFAC8C4DF10
        public void set_rangeOfMotion(){} // RVA: 0x7FFAC8C4DF20
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFAC69D46E0
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFAC69D46F0
        public void get_summaryDataType(){} // RVA: 0x7FFAC69D4680
        public void set_summaryDataType(){} // RVA: 0x7FFAC8C4DF30
        public void get_thumbCurl(){} // RVA: 0x7FFAC8C4DF40
        public void get_indexCurl(){} // RVA: 0x7FFAC8C4DF70
        public void get_middleCurl(){} // RVA: 0x7FFAC8C4DFA0
        public void get_ringCurl(){} // RVA: 0x7FFAC8C4DFD0
        public void get_pinkyCurl(){} // RVA: 0x7FFAC8C4E000
        public void get_thumbIndexSplay(){} // RVA: 0x7FFAC8C4E030
        public void get_indexMiddleSplay(){} // RVA: 0x7FFAC8C4E060
        public void get_middleRingSplay(){} // RVA: 0x7FFAC8C4E090
        public void get_ringPinkySplay(){} // RVA: 0x7FFAC8C4E0C0
        public void get_lastThumbCurl(){} // RVA: 0x7FFAC8C4E0F0
        public void get_lastIndexCurl(){} // RVA: 0x7FFAC8C4E120
        public void get_lastMiddleCurl(){} // RVA: 0x7FFAC8C4E150
        public void get_lastRingCurl(){} // RVA: 0x7FFAC8C4E180
        public void get_lastPinkyCurl(){} // RVA: 0x7FFAC8C4E1B0
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFAC8C4E1E0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFAC8C4E210
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFAC8C4E240
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFAC8C4E270
        public void get_fingerCurls(){} // RVA: 0x7FFAC39C10B0
        public void set_fingerCurls(){} // RVA: 0x7FFAC39BF7F0
        public void get_fingerSplays(){} // RVA: 0x7FFAC39BD300
        public void set_fingerSplays(){} // RVA: 0x7FFAC39AF580
        public void get_lastFingerCurls(){} // RVA: 0x7FFAC39AD480
        public void set_lastFingerCurls(){} // RVA: 0x7FFAC39CEBB0
        public void get_lastFingerSplays(){} // RVA: 0x7FFAC3103FC0
        public void set_lastFingerSplays(){} // RVA: 0x7FFAC39D0EA0
        public void get_poseChanged(){} // RVA: 0x7FFAC8C4E2A0
        public void set_poseChanged(){} // RVA: 0x7FFAC8C4E2B0
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFAC8C4E2C0
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFAC8C4E2D0
        public void Preinitialize(){} // RVA: 0x7FFAC8C4E2E0
        public void Initialize(){} // RVA: 0x7FFAC8C4E9B0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C4EB80
        public void UpdateValue(){} // RVA: 0x7FFAC8C4EFB0 | overloaded x2
        public void get_boneCount(){} // RVA: 0x7FFAC8C4FF00
        public void GetBoneCount(){} // RVA: 0x7FFAC8C4FF10
        public void get_boneHierarchy(){} // RVA: 0x7FFAC8C501D0
        public void GetBoneHierarchy(){} // RVA: 0x7FFAC8C501E0
        public void GetBoneName(){} // RVA: 0x7FFAC8C504E0
        public void GetReferenceTransforms(){} // RVA: 0x7FFAC8C50840
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFAC8C50EA0
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFAC8C50EB0
        public void GetSkeletalSummaryData(){} // RVA: 0x7FFAC8C51100
        public void UpdateSkeletalSummaryData(){} // RVA: 0x7FFAC8C51160
        public void CheckAndSendEvents(){} // RVA: 0x7FFAC8C51510
        public void .ctor(){} // RVA: 0x7FFAC8C51750
    }

    public class SteamVR_Action_Skeleton_Source_Map : SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void GetSourceElementForIndexer(){} // RVA: 0x7FFAC8C4D160
        public void .ctor(){} // RVA: 0x7FFAC8C4D190
    }

    public class SteamVR_Action_Source : Object
    {
        public 0x6B209C88 fullPath; // 0x10
        public ulong handle; // 0x18
        public Valve.VR.SteamVR_Action actionSet; // 0x20

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x7FFAC8C3B410
        public void get_handle(){} // RVA: 0x7FFAC8C3B440
        public void get_actionSet(){} // RVA: 0x7FFAC8C3B470
        public void get_direction(){} // RVA: 0x7FFAC8C3B4A0
        public void get_inputSource(){} // RVA: 0x7FFAC2F6E5C0
        public void set_inputSource(){} // RVA: 0x7FFAC2F240C0
        public void get_setActive(){} // RVA: 0x7FFAC8C3B4D0
        public void get_active(){} // RVA: 0x7FFAC2C59D00
        public void get_activeBinding(){} // RVA: 0x7FFAC2C59D00
        public void get_lastActive(){} // RVA: 0x7FFAC2C59D00
        public void set_lastActive(){} // RVA: 0x7FFAC2C71060
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC2C59D00
        public void Preinitialize(){} // RVA: 0x7FFAC8C3B560
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC8C3B5C0
    }

    public class SteamVR_Action_Source_Map : Object
    {
        public string fullPath; // 0x10
        public ulong handle; // 0x18
        public Valve.VR.SteamVR_ActionSet actionSet; // 0x20
        public 0x6B2067F0 direction; // 0x28
        public Valve.VR.SteamVR_Action action; // 0x30
        public string inLowered;
        public string outLowered; // 0x8

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x7FFAC2F3C380
        public void set_fullPath(){} // RVA: 0x7FFAC2F22E30
        public void get_handle(){} // RVA: 0x7FFAC2F247C0
        public void set_handle(){} // RVA: 0x7FFAC38920D0
        public void get_actionSet(){} // RVA: 0x7FFAC2F4F0C0
        public void set_actionSet(){} // RVA: 0x7FFAC2F4F0D0
        public void get_direction(){} // RVA: 0x7FFAC32EC4C0
        public void set_direction(){} // RVA: 0x7FFAC369A6E0
        public void PreInitialize(){} // RVA: 0x7FFAC8C3AA20
        public void PreinitializeMap(){} // RVA: 0x7FFAC2C72BC0
        public void Initialize(){} // RVA: 0x7FFAC8C3AC70
        public void GetActionSetPath(){} // RVA: 0x7FFAC8C3AE60
        public void GetActionDirection(){} // RVA: 0x7FFAC8C3AEE0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8C3B0F0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public T[] Item; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC69A3D80
        public void OnAccessSource(){} // RVA: 0x7FFAC2F21310
        public void Initialize(){} // RVA: 0x7FFAC69A3DA0
        public void PreinitializeMap(){} // RVA: 0x7FFAC69A3E30
        public void GetSourceElementForIndexer(){} // RVA: 0x7FFAC69A3ED0
        public void .ctor(){} // RVA: 0x7FFAC69A3F20
    }

    public class SteamVR_Action_Vector2 : SteamVR_Action_In`2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFAC8C51DF0
        public void remove_onChange(){} // RVA: 0x7FFAC8C51E70
        public void add_onUpdate(){} // RVA: 0x7FFAC8C51EF0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C51F70
        public void add_onAxis(){} // RVA: 0x7FFAC8C51FF0
        public void remove_onAxis(){} // RVA: 0x7FFAC8C52070
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C520F0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C52170
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C521F0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C52270
        public void get_axis(){} // RVA: 0x7FFAC8C522F0
        public void get_lastAxis(){} // RVA: 0x7FFAC8C52370
        public void get_delta(){} // RVA: 0x7FFAC8C523F0
        public void get_lastDelta(){} // RVA: 0x7FFAC8C52470
        public void .ctor(){} // RVA: 0x7FFAC8C524F0
        public void GetAxis(){} // RVA: 0x7FFAC8C52530
        public void GetAxisDelta(){} // RVA: 0x7FFAC8C525B0
        public void GetLastAxis(){} // RVA: 0x7FFAC8C52630
        public void GetLastAxisDelta(){} // RVA: 0x7FFAC8C526B0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C52730
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C527B0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C52830
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C528B0
        public void AddOnChangeListener(){} // RVA: 0x7FFAC8C52930
        public void RemoveOnChangeListener(){} // RVA: 0x7FFAC8C529B0
        public void AddOnUpdateListener(){} // RVA: 0x7FFAC8C52A30
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFAC8C52AB0
        public void AddOnAxisListener(){} // RVA: 0x7FFAC8C52B30
        public void RemoveOnAxisListener(){} // RVA: 0x7FFAC8C52BB0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C52C30
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C52CA0
    }

    public class SteamVR_Action_Vector2_Source : SteamVR_Action_In_Source
    {
        public uint axis;
        public float lastAxis; // 0x158
        public AxisHandler delta; // 0x160
        public ActiveChangeHandler lastDelta; // 0x168
        public ActiveChangeHandler changed; // 0x170
        public ChangeHandler lastChanged; // 0x178
        public UpdateHandler activeOrigin; // 0x180
        public UnityEngine.Vector2 lastActiveOrigin; // 0x188
        public UnityEngine.Vector2 active; // 0x190
        public UnityEngine.Vector2 activeBinding; // 0x198
        public UnityEngine.Vector2 lastActive; // 0x1A0
        public bool lastActiveBinding; // 0x1A8
        public bool <lastChanged>k__BackingField; // 0x1A9
        public bool <lastActive>k__BackingField; // 0x1AA
        public Valve.VR.InputAnalogActionData_t actionData; // 0x1B0
        public Valve.VR.InputAnalogActionData_t lastActionData; // 0x1E0
        public Valve.VR.SteamVR_Action_Vector2 vector2Action; // 0x210

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7FFAC8C68B70
        public void remove_onAxis(){} // RVA: 0x7FFAC8C68C60
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C68D50
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C68E40
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C68F30
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C69020
        public void add_onChange(){} // RVA: 0x7FFAC8C69110
        public void remove_onChange(){} // RVA: 0x7FFAC8C69200
        public void add_onUpdate(){} // RVA: 0x7FFAC8C692F0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C693E0
        public void get_axis(){} // RVA: 0x7FFAC3F94EF0
        public void set_axis(){} // RVA: 0x7FFAC8C694D0
        public void get_lastAxis(){} // RVA: 0x7FFAC8C694E0
        public void set_lastAxis(){} // RVA: 0x7FFAC8C69500
        public void get_delta(){} // RVA: 0x7FFAC8C69510
        public void set_delta(){} // RVA: 0x7FFAC8C69530
        public void get_lastDelta(){} // RVA: 0x7FFAC8C69540
        public void set_lastDelta(){} // RVA: 0x7FFAC8C69560
        public void get_changed(){} // RVA: 0x7FFAC8C69570
        public void set_changed(){} // RVA: 0x7FFAC8C69580
        public void get_lastChanged(){} // RVA: 0x7FFAC8C69590
        public void set_lastChanged(){} // RVA: 0x7FFAC8C695A0
        public void get_activeOrigin(){} // RVA: 0x7FFAC8C695B0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC39B1060
        public void get_active(){} // RVA: 0x7FFAC8C41120
        public void get_activeBinding(){} // RVA: 0x7FFAC8C411E0
        public void get_lastActive(){} // RVA: 0x7FFAC8C695F0
        public void set_lastActive(){} // RVA: 0x7FFAC8C69600
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC8C69610
        public void Preinitialize(){} // RVA: 0x7FFAC8C69620
        public void Initialize(){} // RVA: 0x7FFAC8C697B0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C69890
        public void UpdateValue(){} // RVA: 0x7FFAC8C69B90
        public void .ctor(){} // RVA: 0x7FFAC8C6A380
    }

    public class SteamVR_Action_Vector2_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C68B30
    }

    public class SteamVR_Action_Vector3 : SteamVR_Action_In`2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFAC8C6A3D0
        public void remove_onChange(){} // RVA: 0x7FFAC8C6A450
        public void add_onUpdate(){} // RVA: 0x7FFAC8C6A4D0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C6A550
        public void add_onAxis(){} // RVA: 0x7FFAC8C6A5D0
        public void remove_onAxis(){} // RVA: 0x7FFAC8C6A650
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C6A6D0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C6A750
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C6A7D0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C6A850
        public void get_axis(){} // RVA: 0x7FFAC8C6A8D0
        public void get_lastAxis(){} // RVA: 0x7FFAC8C6A950
        public void get_delta(){} // RVA: 0x7FFAC8C6A9D0
        public void get_lastDelta(){} // RVA: 0x7FFAC8C6AA50
        public void .ctor(){} // RVA: 0x7FFAC8C6AAD0
        public void GetAxis(){} // RVA: 0x7FFAC8C6AB10
        public void GetAxisDelta(){} // RVA: 0x7FFAC8C6ABA0
        public void GetLastAxis(){} // RVA: 0x7FFAC8C6AC30
        public void GetLastAxisDelta(){} // RVA: 0x7FFAC8C6ACC0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C6AD50
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C6ADD0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C6AE50
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C6AED0
        public void AddOnChangeListener(){} // RVA: 0x7FFAC8C6AF50
        public void RemoveOnChangeListener(){} // RVA: 0x7FFAC8C6AFD0
        public void AddOnUpdateListener(){} // RVA: 0x7FFAC8C6B050
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFAC8C6B0D0
        public void AddOnAxisListener(){} // RVA: 0x7FFAC8C6B150
        public void RemoveOnAxisListener(){} // RVA: 0x7FFAC8C6B1D0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C6B250
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C6B2C0
    }

    public class SteamVR_Action_Vector3_Source : SteamVR_Action_In_Source
    {
        public uint axis;
        public float lastAxis; // 0x158
        public AxisHandler delta; // 0x160
        public ActiveChangeHandler lastDelta; // 0x168
        public ActiveChangeHandler changed; // 0x170
        public ChangeHandler lastChanged; // 0x178
        public UpdateHandler activeOrigin; // 0x180
        public UnityEngine.Vector3 lastActiveOrigin; // 0x188
        public UnityEngine.Vector3 active; // 0x194
        public UnityEngine.Vector3 activeBinding; // 0x1A0
        public UnityEngine.Vector3 lastActive; // 0x1AC
        public bool lastActiveBinding; // 0x1B8
        public bool <lastChanged>k__BackingField; // 0x1B9
        public bool <lastActive>k__BackingField; // 0x1BA
        public Valve.VR.InputAnalogActionData_t actionData; // 0x1C0
        public Valve.VR.InputAnalogActionData_t lastActionData; // 0x1F0
        public Valve.VR.SteamVR_Action_Vector3 vector3Action; // 0x220

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7FFAC8C6B660
        public void remove_onAxis(){} // RVA: 0x7FFAC8C6B750
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C6B840
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C6B930
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C6BA20
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C6BB10
        public void add_onChange(){} // RVA: 0x7FFAC8C6BC00
        public void remove_onChange(){} // RVA: 0x7FFAC8C6BCF0
        public void add_onUpdate(){} // RVA: 0x7FFAC8C6BDE0
        public void remove_onUpdate(){} // RVA: 0x7FFAC8C6BED0
        public void get_axis(){} // RVA: 0x7FFAC8C6BFC0
        public void set_axis(){} // RVA: 0x7FFAC8C6BFE0
        public void get_lastAxis(){} // RVA: 0x7FFAC8C6C000
        public void set_lastAxis(){} // RVA: 0x7FFAC8C6C020
        public void get_delta(){} // RVA: 0x7FFAC8C6C040
        public void set_delta(){} // RVA: 0x7FFAC8C6C060
        public void get_lastDelta(){} // RVA: 0x7FFAC8C6C080
        public void set_lastDelta(){} // RVA: 0x7FFAC8C6C0A0
        public void get_changed(){} // RVA: 0x7FFAC8B3EE50
        public void set_changed(){} // RVA: 0x7FFAC8B3EE60
        public void get_lastChanged(){} // RVA: 0x7FFAC8C6C0C0
        public void set_lastChanged(){} // RVA: 0x7FFAC8C6C0D0
        public void get_activeOrigin(){} // RVA: 0x7FFAC8C6C0E0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAC3541460
        public void get_active(){} // RVA: 0x7FFAC8C41120
        public void get_activeBinding(){} // RVA: 0x7FFAC8C41080
        public void get_lastActive(){} // RVA: 0x7FFAC8C6C120
        public void set_lastActive(){} // RVA: 0x7FFAC8C6C130
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC8C6C140
        public void Preinitialize(){} // RVA: 0x7FFAC8C6C150
        public void Initialize(){} // RVA: 0x7FFAC8C6C2E0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C6C3C0
        public void UpdateValue(){} // RVA: 0x7FFAC8C6C6C0
        public void .ctor(){} // RVA: 0x7FFAC8C6CEF0
    }

    public class SteamVR_Action_Vector3_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C6B620
    }

    public class SteamVR_Action_Vibration : SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C6CF40
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C6CFC0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C6D040
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C6D0C0
        public void add_onExecute(){} // RVA: 0x7FFAC8C6D140
        public void remove_onExecute(){} // RVA: 0x7FFAC8C6D1C0
        public void .ctor(){} // RVA: 0x7FFAC8C6D240
        public void Execute(){} // RVA: 0x7FFAC8C6D2E0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFAC8C6D390
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFAC8C6D410
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C6D490
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFAC8C6D510
        public void AddOnExecuteListener(){} // RVA: 0x7FFAC8C6D590
        public void RemoveOnExecuteListener(){} // RVA: 0x7FFAC8C6D610
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C6D690
        public void GetTimeLastChanged(){} // RVA: 0x7FFAC8C6D700
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFAC8C6D770
        public void IsUpdating(){} // RVA: 0x7FFAC8C6D7B0
    }

    public class SteamVR_Action_Vibration_Source : SteamVR_Action_Out_Source
    {
        public ActiveChangeHandler active; // 0x28
        public ActiveChangeHandler activeBinding; // 0x30
        public ExecuteHandler lastActive; // 0x38
        public bool lastActiveBinding; // 0x40
        public float timeLastExecuted; // 0x44
        public Valve.VR.SteamVR_Action_Vibration vibrationAction; // 0x48

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFAC8C6DBD0
        public void remove_onActiveChange(){} // RVA: 0x7FFAC8C6DCC0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFAC8C6DDB0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFAC8C6DEA0
        public void add_onExecute(){} // RVA: 0x7FFAC8C6DF90
        public void remove_onExecute(){} // RVA: 0x7FFAC8C6E080
        public void get_active(){} // RVA: 0x7FFAC8C41120
        public void get_activeBinding(){} // RVA: 0x7FFAC3006850
        public void get_lastActive(){} // RVA: 0x7FFAC2FDCC00
        public void set_lastActive(){} // RVA: 0x7FFAC2FDCC10
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC3006850
        public void get_timeLastExecuted(){} // RVA: 0x7FFAC2F29970
        public void set_timeLastExecuted(){} // RVA: 0x7FFAC2F29980
        public void Initialize(){} // RVA: 0x7FFAC8C6E170
        public void Preinitialize(){} // RVA: 0x7FFAC8C6E1F0
        public void RemoveAllListeners(){} // RVA: 0x7FFAC8C6E370
        public void Execute(){} // RVA: 0x7FFAC8C6E530
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Action_Vibration_Source_Map : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x7FFAC8C6DB40
        public void .ctor(){} // RVA: 0x7FFAC8C6DB90
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public T Item; // 0x28
        public bool fullPath; // 0x30
        public uint handle;
        public Valve.VR.InputBindingInfo_t[] actionSet; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFAC69A4030
        public void get_fullPath(){} // RVA: 0x7FFAC69A4060
        public void get_handle(){} // RVA: 0x7FFAC69A4080
        public void get_actionSet(){} // RVA: 0x7FFAC69A40A0
        public void get_direction(){} // RVA: 0x7FFAC69A40C0
        public void get_active(){} // RVA: 0x7FFAC69A40E0
        public void get_lastActive(){} // RVA: 0x7FFAC69A4130
        public void get_activeBinding(){} // RVA: 0x7FFAC69A4180
        public void get_lastActiveBinding(){} // RVA: 0x7FFAC69A41D0
        public void PreInitialize(){} // RVA: 0x7FFAC69A4220
        public void CreateUninitialized(){} // RVA: 0x7FFAC69A4440 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x7FFAC69A4640
        public void Initialize(){} // RVA: 0x7FFAC69A4900
        public void GetSourceMap(){} // RVA: 0x7FFAC2F4F130
        public void InitializeCopy(){} // RVA: 0x7FFAC69A4A10
        public void InitAfterDeserialize(){} // RVA: 0x7FFAC69A4B90
        public void GetActive(){} // RVA: 0x7FFAC69A4C40
        public void GetActiveBinding(){} // RVA: 0x7FFAC69A4C90
        public void GetLastActive(){} // RVA: 0x7FFAC69A4CE0
        public void GetLastActiveBinding(){} // RVA: 0x7FFAC69A4D30
        public void GetActionBindingInfo(){} // RVA: 0x7FFAC69A4D80
        public void .ctor(){} // RVA: 0x7FFAC69A5410
        public void .cctor(){} // RVA: 0x7FFAC69A5460
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
        public void get_global_Safe_Mode(){} // RVA: 0x7FFAC8C53B90
        public void get_global_Pose(){} // RVA: 0x7FFAC8C53C00
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7FFAC8C53C70
        public void get_global_SkeletonRightHand(){} // RVA: 0x7FFAC8C53CE0
        public void get_global_HeadsetOnHead(){} // RVA: 0x7FFAC8C53D50
        public void get_global_Menu(){} // RVA: 0x7FFAC8C53DC0
        public void get_global_Quick_Menu(){} // RVA: 0x7FFAC8C53E30
        public void get_global_Action_Menu(){} // RVA: 0x7FFAC8C53EA0
        public void get_global_Main_Menu(){} // RVA: 0x7FFAC8C53F10
        public void get_global_Interact(){} // RVA: 0x7FFAC8C53F80
        public void get_global_Grab(){} // RVA: 0x7FFAC8C53FF0
        public void get_global_Move(){} // RVA: 0x7FFAC8C54060
        public void get_global_Jump(){} // RVA: 0x7FFAC8C540D0
        public void get_global_Rotate(){} // RVA: 0x7FFAC8C54140
        public void get_global_Mic(){} // RVA: 0x7FFAC8C541B0
        public void get_global_Gesture_Toggle(){} // RVA: 0x7FFAC8C54220
        public void get_global_Stick_Click(){} // RVA: 0x7FFAC8C54290
        public void get_global_Trigger_Axis(){} // RVA: 0x7FFAC8C54300
        public void get_global_Grip_Axis(){} // RVA: 0x7FFAC8C54370
        public void get_global_Udon_Menu(){} // RVA: 0x7FFAC8C543E0
        public void get_global_Drop(){} // RVA: 0x7FFAC8C54450
        public void get_global_Nameplates(){} // RVA: 0x7FFAC8C544C0
        public void get_global_HUD(){} // RVA: 0x7FFAC8C54530
        public void get_global_Chatbox(){} // RVA: 0x7FFAC8C545A0
        public void get_global_Face_Mirror(){} // RVA: 0x7FFAC8C54610
        public void get_global_Personal_Mirror(){} // RVA: 0x7FFAC8C54680
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x7FFAC8C546F0
        public void get_global_Earmuffs(){} // RVA: 0x7FFAC8C54760
        public void get_global_Camera(){} // RVA: 0x7FFAC8C547D0
        public void get_global_Stream_Camera(){} // RVA: 0x7FFAC8C54840
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x7FFAC8C548B0
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x7FFAC8C54920
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x7FFAC8C54990
        public void get_global_Start_Move(){} // RVA: 0x7FFAC8C54A00
        public void get_global_Start_Rotate(){} // RVA: 0x7FFAC8C54A70
        public void get_global_Continue_Move(){} // RVA: 0x7FFAC8C54AE0
        public void get_global_Continue_Rotate(){} // RVA: 0x7FFAC8C54B50
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x7FFAC8C54BC0
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x7FFAC8C54C30
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x7FFAC8C54CA0
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAC8C54D10
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAC8C54D80
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAC8C54DF0
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x7FFAC8C54E60
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x7FFAC8C54ED0
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC8C54F40
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x7FFAC8C54FB0
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAC8C55020
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFAC8C55090
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFAC8C55100
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x7FFAC8C55170
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFAC8C551E0
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFAC8C55250
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFAC8C552C0
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFAC8C55330
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x7FFAC8C553A0
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFAC8C55410
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFAC8C55480
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x7FFAC8C554F0
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFAC8C55560
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFAC8C555D0
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFAC8C55640
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFAC8C556B0
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x7FFAC8C55720
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x7FFAC8C55790
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAC8C55800
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAC8C55870
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAC8C558E0
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAC8C55950
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAC8C559C0
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAC8C55A30
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAC8C55AA0
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAC8C55B10
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x7FFAC8C55B80
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAC8C55BF0
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAC8C55C60
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAC8C55CD0
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC8C55D40
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAC8C55DB0
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAC8C55E20
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAC8C55E90
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAC8C55F00
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x7FFAC8C55F70
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAC8C55FE0
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAC8C56050
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAC8C560C0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC8C56130
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x7FFAC8C561A0
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x7FFAC8C56210
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x7FFAC8C56280
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x7FFAC8C562F0
        public void get_global_Scroll(){} // RVA: 0x7FFAC8C56360
        public void get_global_Haptic(){} // RVA: 0x7FFAC8C563D0
        public void get_one_Hand_Interact(){} // RVA: 0x7FFAC8C56440
        public void get_one_Hand_Grab(){} // RVA: 0x7FFAC8C564B0
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x7FFAC8C56520
        public void get_one_Hand_Jump(){} // RVA: 0x7FFAC8C56590
        public void get_one_Hand_Mic(){} // RVA: 0x7FFAC8C56600
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x7FFAC8C56670
        public void get_one_Hand_Stick_Click(){} // RVA: 0x7FFAC8C566E0
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x7FFAC8C56750
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x7FFAC8C567C0
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x7FFAC8C56830
        public void get_one_Hand_Drop(){} // RVA: 0x7FFAC8C568A0
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x7FFAC8C56910
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x7FFAC8C56980
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFAC8C569F0
        public void get_one_Hand_Menu(){} // RVA: 0x7FFAC8C56A60
        public void get_one_Hand_Nameplates(){} // RVA: 0x7FFAC8C56AD0
        public void get_one_Hand_HUD(){} // RVA: 0x7FFAC8C56B40
        public void get_one_Hand_Chatbox(){} // RVA: 0x7FFAC8C56BB0
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x7FFAC8C56C20
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x7FFAC8C56C90
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x7FFAC8C56D00
        public void get_one_Hand_Earmuffs(){} // RVA: 0x7FFAC8C56D70
        public void get_one_Hand_Camera(){} // RVA: 0x7FFAC8C56DE0
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x7FFAC8C56E50
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x7FFAC8C56EC0
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x7FFAC8C56F30
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x7FFAC8C56FA0
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x7FFAC8C57010
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAC8C57080
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAC8C570F0
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAC8C57160
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x7FFAC8C571D0
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7FFAC8C57240
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC8C572B0
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x7FFAC8C57320
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAC8C57390
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x7FFAC8C57400
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAC8C57470
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAC8C574E0
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAC8C57550
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAC8C575C0
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAC8C57630
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAC8C576A0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAC8C57710
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAC8C57780
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x7FFAC8C577F0
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAC8C57860
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAC8C578D0
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAC8C57940
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC8C579B0
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAC8C57A20
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAC8C57A90
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAC8C57B00
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAC8C57B70
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAC8C57BE0
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAC8C57C50
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAC8C57CC0
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC8C57D30
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x7FFAC8C57DA0
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x7FFAC8C57E10
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x7FFAC8C57E80
        public void get_menu_Confirm(){} // RVA: 0x7FFAC8C57EF0
        public void get_menu_Back(){} // RVA: 0x7FFAC8C57F60
        public void get_menu_Tab(){} // RVA: 0x7FFAC8C57FD0
        public void get_menu_Scroll(){} // RVA: 0x7FFAC8C58040
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x7FFAC8C580B0
        public void get_menu_Drag(){} // RVA: 0x7FFAC8C58120
        public void get_action_Menu_Axis(){} // RVA: 0x7FFAC8C58190
        public void get_action_Menu_Select(){} // RVA: 0x7FFAC8C58200
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x7FFAC8C58270
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAC8C582E0
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAC8C58350
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAC8C583C0
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x7FFAC8C58430
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x7FFAC8C584A0
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC8C58510
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x7FFAC8C58580
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAC8C585F0
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x7FFAC8C58660
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAC8C586D0
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAC8C58740
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAC8C587B0
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAC8C58820
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAC8C58890
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAC8C58900
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAC8C58970
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAC8C589E0
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x7FFAC8C58A50
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAC8C58AC0
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAC8C58B30
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAC8C58BA0
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC8C58C10
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAC8C58C80
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAC8C58CF0
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAC8C58D60
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAC8C58DD0
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAC8C58E40
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAC8C58EB0
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAC8C58F20
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC8C58F90
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x7FFAC8C59000
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x7FFAC8C59070
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x7FFAC8C590E0
        public void get_action_Menu_Grab(){} // RVA: 0x7FFAC8C59150
        public void get_action_Menu_Drop(){} // RVA: 0x7FFAC8C591C0
        public void get_drone_Left_Joystick(){} // RVA: 0x7FFAC8C59230
        public void get_drone_Right_Joystick(){} // RVA: 0x7FFAC8C592A0
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x7FFAC8C59310
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x7FFAC8C59380
        public void get_drone_Toggle_FPV(){} // RVA: 0x7FFAC8C593F0
        public void get_drone_Flip(){} // RVA: 0x7FFAC8C59460
        public void get_drone_Take_Picture(){} // RVA: 0x7FFAC8C594D0
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x7FFAC8C59540
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x7FFAC8C595B0
        public void get_drone_Respawn(){} // RVA: 0x7FFAC8C59620
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x7FFAC8C59690
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFAC8C59700
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x7FFAC8C59770
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFAC8C597E0
        public void InitializeActionArrays(){} // RVA: 0x7FFAC8C59850
        public void PreInitActions(){} // RVA: 0x7FFAC8C62FF0
        public void get_Global(){} // RVA: 0x7FFAC8C67DD0
        public void get_One_Hand(){} // RVA: 0x7FFAC8C67E40
        public void get_Menu(){} // RVA: 0x7FFAC8C67EB0
        public void get_Action_Menu(){} // RVA: 0x7FFAC8C67F20
        public void get_Drone(){} // RVA: 0x7FFAC8C67F90
        public void StartPreInitActionSets(){} // RVA: 0x7FFAC8C68000
        public void PreInitialize(){} // RVA: 0x7FFAC8C686E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_ActivateActionSetOnLoad : MonoBehaviour
    {
        public Valve.VR.SteamVR_ActionSet actionSet; // 0x20
        public 0x6B209C88 forSources; // 0x28
        public bool disableAllOtherActionSets; // 0x2C
        public bool activateOnStart; // 0x2D
        public bool deactivateOnDestroy; // 0x2E
        public int initialPriority; // 0x30

        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8C6E8B0
        public void OnDestroy(){} // RVA: 0x7FFAC8C6E920
        public void .ctor(){} // RVA: 0x7FFAC8C6E980
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
        public void get_instance(){} // RVA: 0x7FFAC8C949B0
        public void Initialize(){} // RVA: 0x7FFAC8C94AF0
        public void Awake(){} // RVA: 0x7FFAC8C95390
        public void InitializeSteamVR(){} // RVA: 0x7FFAC8C95490
        public void DoInitializeSteamVR(){} // RVA: 0x7FFAC8C956E0
        public void XRDevice_deviceLoaded(){} // RVA: 0x7FFAC8C95780
        public void EnableOpenVR(){} // RVA: 0x7FFAC8C95860
        public void OnEnable(){} // RVA: 0x7FFAC8C95980
        public void OnDisable(){} // RVA: 0x7FFAC8C95B20
        public void OnBeforeRender(){} // RVA: 0x7FFAC8C95CD0
        public void PreCull(){} // RVA: 0x7FFAC8C95CE0
        public void FixedUpdate(){} // RVA: 0x7FFAC8C95F60
        public void LateUpdate(){} // RVA: 0x7FFAC8C960E0
        public void Update(){} // RVA: 0x7FFAC8C96280
        public void OnQuit(){} // RVA: 0x7FFAC8C96400
        public void .ctor(){} // RVA: 0x7FFAC8C96450
        public void .cctor(){} // RVA: 0x7FFAC8C964A0
    }

    public class SteamVR_Behaviour_Boolean : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Boolean isActive; // 0x20
        public 0x6B209C88 actionSet; // 0x28
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onChange; // 0x30
        public ChangeHandler onChangeEvent; // 0x38
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onUpdate; // 0x40
        public UpdateHandler onUpdateEvent; // 0x48
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onPress; // 0x50
        public StateHandler onPressEvent; // 0x58
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onPressDown; // 0x60
        public StateDownHandler onPressDownEvent; // 0x68
        public Valve.VR.SteamVR_Behaviour_BooleanEvent onPressUp; // 0x70
        public StateUpHandler onPressUpEvent; // 0x78

        // ── Methods ──
        public void add_onChangeEvent(){} // RVA: 0x7FFAC8C6EA80
        public void remove_onChangeEvent(){} // RVA: 0x7FFAC8C6EB70
        public void add_onUpdateEvent(){} // RVA: 0x7FFAC8C6EC60
        public void remove_onUpdateEvent(){} // RVA: 0x7FFAC8C6ED50
        public void add_onPressEvent(){} // RVA: 0x7FFAC8C6EE40
        public void remove_onPressEvent(){} // RVA: 0x7FFAC8C6EF30
        public void add_onPressDownEvent(){} // RVA: 0x7FFAC8C6F020
        public void remove_onPressDownEvent(){} // RVA: 0x7FFAC8C6F110
        public void add_onPressUpEvent(){} // RVA: 0x7FFAC8C6F200
        public void remove_onPressUpEvent(){} // RVA: 0x7FFAC8C6F2F0
        public void get_isActive(){} // RVA: 0x7FFAC8C6F3E0
        public void get_actionSet(){} // RVA: 0x7FFAC8C6F430
        public void OnEnable(){} // RVA: 0x7FFAC8C6F530
        public void OnDisable(){} // RVA: 0x7FFAC8C6F620
        public void AddHandlers(){} // RVA: 0x7FFAC8C6F630
        public void RemoveHandlers(){} // RVA: 0x7FFAC8C6F8F0
        public void SteamVR_Behaviour_Boolean_OnStateUp(){} // RVA: 0x7FFAC8C6FC50
        public void SteamVR_Behaviour_Boolean_OnStateDown(){} // RVA: 0x7FFAC8C6FCD0
        public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x7FFAC8C6FD50
        public void SteamVR_Behaviour_Boolean_OnUpdate(){} // RVA: 0x7FFAC8C6FDD0
        public void SteamVR_Behaviour_Boolean_OnChange(){} // RVA: 0x7FFAC8C6FE70
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C6FF10
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_Behaviour_BooleanEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39C10
    }

    public class SteamVR_Behaviour_Pose : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Pose isValid; // 0x20
        public 0x6B209C88 isActive; // 0x28
        public UnityEngine.Transform origin; // 0x30
        public Valve.VR.SteamVR_Behaviour_PoseEvent onTransformUpdated; // 0x38
        public Valve.VR.SteamVR_Behaviour_PoseEvent onTransformChanged; // 0x40
        public Valve.VR.SteamVR_Behaviour_Pose_ConnectedChangedEvent onConnectedChanged; // 0x48
        public Valve.VR.SteamVR_Behaviour_Pose_TrackingChangedEvent onTrackingChanged; // 0x50
        public Valve.VR.SteamVR_Behaviour_Pose_DeviceIndexChangedEvent onDeviceIndexChanged; // 0x58
        public UpdateHandler onTransformUpdatedEvent; // 0x60
        public ChangeHandler onTransformChangedEvent; // 0x68
        public DeviceConnectedChangeHandler onConnectedChangedEvent; // 0x70
        public TrackingChangeHandler onTrackingChangedEvent; // 0x78
        public DeviceIndexChangedHandler onDeviceIndexChangedEvent; // 0x80
        public bool broadcastDeviceChanges; // 0x88
        public int deviceIndex; // 0x8C
        public Valve.VR.SteamVR_HistoryBuffer historyBuffer; // 0x90
        public int lastFrameUpdated; // 0x98

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFAC8C70410
        public void get_isActive(){} // RVA: 0x7FFAC8C6F3E0
        public void Start(){} // RVA: 0x7FFAC8C70450
        public void OnEnable(){} // RVA: 0x7FFAC8C706E0
        public void OnDisable(){} // RVA: 0x7FFAC8C709D0
        public void SteamVR_Behaviour_Pose_OnUpdate(){} // RVA: 0x7FFAC8C70D80
        public void UpdateTransform(){} // RVA: 0x7FFAC8C70E20
        public void SteamVR_Behaviour_Pose_OnChange(){} // RVA: 0x7FFAC8C71530
        public void OnDeviceConnectedChanged(){} // RVA: 0x7FFAC8C715B0
        public void OnTrackingChanged(){} // RVA: 0x7FFAC8C71660
        public void CheckDeviceIndex(){} // RVA: 0x7FFAC8C716F0
        public void GetDeviceIndex(){} // RVA: 0x7FFAC8C71960
        public void GetVelocity(){} // RVA: 0x7FFAC8C719A0
        public void GetAngularVelocity(){} // RVA: 0x7FFAC8C71A00
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFAC8C71A60
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFAC8C71AD0
        public void UpdateHistoryBuffer(){} // RVA: 0x7FFAC8C71C00
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C71E20
        public void .ctor(){} // RVA: 0x7FFAC8C71F60
    }

    public class SteamVR_Behaviour_PoseEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39CA0
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39D30
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39DC0
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39E50
    }

    public class SteamVR_Behaviour_Single : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Single isActive; // 0x20
        public 0x6B209C88 inputSource; // 0x28
        public Valve.VR.SteamVR_Behaviour_SingleEvent onChange; // 0x30
        public Valve.VR.SteamVR_Behaviour_SingleEvent onUpdate; // 0x38
        public Valve.VR.SteamVR_Behaviour_SingleEvent onAxis; // 0x40
        public ChangeHandler onChangeEvent; // 0x48
        public UpdateHandler onUpdateEvent; // 0x50
        public AxisHandler onAxisEvent; // 0x58

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFAC8C72640
        public void OnEnable(){} // RVA: 0x7FFAC8C72680
        public void OnDisable(){} // RVA: 0x7FFAC8C72770
        public void AddHandlers(){} // RVA: 0x7FFAC8C72780
        public void RemoveHandlers(){} // RVA: 0x7FFAC8C72940
        public void SteamVR_Behaviour_Single_OnUpdate(){} // RVA: 0x7FFAC8C72BA0
        public void SteamVR_Behaviour_Single_OnChange(){} // RVA: 0x7FFAC8C72C60
        public void SteamVR_Behaviour_Single_OnAxis(){} // RVA: 0x7FFAC8C72D20
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C72DE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_Behaviour_SingleEvent : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39EE0
    }

    public class SteamVR_Behaviour_Skeleton : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Skeleton skeletonAvailable; // 0x20
        public 0x6B209C88 isActive; // 0x28
        public 0x6B240868 fingerCurls; // 0x2C
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
        public UpdateHandler indexDistal; // 0x70
        public UpdateHandler indexTip; // 0x78
        public ChangeHandler middleMetacarpal; // 0x80
        public DeviceConnectedChangeHandler middleProximal; // 0x88
        public TrackingChangeHandler middleMiddle; // 0x90
        public 0x6B208B00 middleDistal; // 0x98
        public Valve.VR.SteamVR_Skeleton_Poser middleTip; // 0xA0
        public Valve.VR.SteamVR_Action_Single pinkyMetacarpal; // 0xA8
        public Valve.VR.SteamVR_Skeleton_Poser pinkyProximal; // 0xB0
        public Valve.VR.SteamVR_Skeleton_PoseSnapshot pinkyMiddle; // 0xB8
        public UnityEngine.Transform[] pinkyDistal; // 0xC0
        public UnityEngine.Transform[] pinkyTip; // 0xC8
        public UnityEngine.Transform[] ringMetacarpal; // 0xD0
        public UnityEngine.Transform[] ringProximal; // 0xD8
        public UnityEngine.Transform[] ringMiddle; // 0xE0
        public UnityEngine.Coroutine ringDistal; // 0xE8
        public UnityEngine.Coroutine ringTip; // 0xF0
        public UnityEngine.Coroutine thumbMetacarpal; // 0xF8
        public UnityEngine.Transform[] thumbProximal; // 0x100
        public System.Nullable`1<0x6B240868> thumbMiddle; // 0x108
        public UnityEngine.Quaternion thumbDistal;

        // ── Methods ──
        public void get_skeletonAvailable(){} // RVA: 0x7FFAC8C73190
        public void get_isActive(){} // RVA: 0x7FFAC8C731C0
        public void get_fingerCurls(){} // RVA: 0x7FFAC8C73240
        public void get_thumbCurl(){} // RVA: 0x7FFAC8C73390
        public void get_indexCurl(){} // RVA: 0x7FFAC8C73400
        public void get_middleCurl(){} // RVA: 0x7FFAC8C73470
        public void get_ringCurl(){} // RVA: 0x7FFAC8C734E0
        public void get_pinkyCurl(){} // RVA: 0x7FFAC8C73550
        public void get_root(){} // RVA: 0x7FFAC8C735C0
        public void get_wrist(){} // RVA: 0x7FFAC8C735F0
        public void get_indexMetacarpal(){} // RVA: 0x7FFAC8C73620
        public void get_indexProximal(){} // RVA: 0x7FFAC8C73650
        public void get_indexMiddle(){} // RVA: 0x7FFAC8C73680
        public void get_indexDistal(){} // RVA: 0x7FFAC8C736B0
        public void get_indexTip(){} // RVA: 0x7FFAC8C736E0
        public void get_middleMetacarpal(){} // RVA: 0x7FFAC8C73710
        public void get_middleProximal(){} // RVA: 0x7FFAC8C73740
        public void get_middleMiddle(){} // RVA: 0x7FFAC8C73770
        public void get_middleDistal(){} // RVA: 0x7FFAC8C737A0
        public void get_middleTip(){} // RVA: 0x7FFAC8C737D0
        public void get_pinkyMetacarpal(){} // RVA: 0x7FFAC8C73800
        public void get_pinkyProximal(){} // RVA: 0x7FFAC8C73830
        public void get_pinkyMiddle(){} // RVA: 0x7FFAC8C73860
        public void get_pinkyDistal(){} // RVA: 0x7FFAC8C73890
        public void get_pinkyTip(){} // RVA: 0x7FFAC8C738C0
        public void get_ringMetacarpal(){} // RVA: 0x7FFAC8C738F0
        public void get_ringProximal(){} // RVA: 0x7FFAC8C73920
        public void get_ringMiddle(){} // RVA: 0x7FFAC8C73950
        public void get_ringDistal(){} // RVA: 0x7FFAC8C73980
        public void get_ringTip(){} // RVA: 0x7FFAC8C739B0
        public void get_thumbMetacarpal(){} // RVA: 0x7FFAC8C739E0
        public void get_thumbProximal(){} // RVA: 0x7FFAC8C739E0
        public void get_thumbMiddle(){} // RVA: 0x7FFAC8C73A10
        public void get_thumbDistal(){} // RVA: 0x7FFAC8C73A40
        public void get_thumbTip(){} // RVA: 0x7FFAC8C73A70
        public void get_thumbAux(){} // RVA: 0x7FFAC8C73AA0
        public void get_indexAux(){} // RVA: 0x7FFAC8C73AD0
        public void get_middleAux(){} // RVA: 0x7FFAC8C73B00
        public void get_ringAux(){} // RVA: 0x7FFAC8C73B30
        public void get_pinkyAux(){} // RVA: 0x7FFAC8C73B60
        public void get_proximals(){} // RVA: 0x7FFAC2F8C120
        public void set_proximals(){} // RVA: 0x7FFAC2F8C130
        public void get_middles(){} // RVA: 0x7FFAC3079460
        public void set_middles(){} // RVA: 0x7FFAC3079470
        public void get_distals(){} // RVA: 0x7FFAC303E100
        public void set_distals(){} // RVA: 0x7FFAC303E110
        public void get_tips(){} // RVA: 0x7FFAC3540F70
        public void set_tips(){} // RVA: 0x7FFAC2FA28A0
        public void get_auxs(){} // RVA: 0x7FFAC2FA2900
        public void set_auxs(){} // RVA: 0x7FFAC2FA2910
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFAC8C73B90
        public void get_isBlending(){} // RVA: 0x7FFAC8C73C30
        public void get_actionSet(){} // RVA: 0x7FFAC8C3B470
        public void get_direction(){} // RVA: 0x7FFAC8C3B4A0
        public void Awake(){} // RVA: 0x7FFAC8C73C40
        public void CheckSkeletonAction(){} // RVA: 0x7FFAC8C74870
        public void AssignBonesArray(){} // RVA: 0x7FFAC8C74A00
        public void OnEnable(){} // RVA: 0x7FFAC8C74AE0
        public void OnDisable(){} // RVA: 0x7FFAC8C74EA0
        public void OnDeviceConnectedChanged(){} // RVA: 0x7FFAC8C75270
        public void OnTrackingChanged(){} // RVA: 0x7FFAC8C75310
        public void SteamVR_Input_OnSkeletonsUpdated(){} // RVA: 0x7FFAC3F5BE50
        public void UpdateSkeleton(){} // RVA: 0x7FFAC8C753B0
        public void SetTemporaryRangeOfMotion(){} // RVA: 0x7FFAC8C75640
        public void ResetTemporaryRangeOfMotion(){} // RVA: 0x7FFAC8C756D0
        public void SetRangeOfMotion(){} // RVA: 0x7FFAC8C756E0
        public void BlendToSkeleton(){} // RVA: 0x7FFAC8C75860
        public void BlendToPoser(){} // RVA: 0x7FFAC8C75A60
        public void BlendToAnimation(){} // RVA: 0x7FFAC8C75BA0
        public void BlendTo(){} // RVA: 0x7FFAC8C75BB0
        public void DoBlendRoutine(){} // RVA: 0x7FFAC8C75DB0
        public void RangeOfMotionBlend(){} // RVA: 0x7FFAC8C75E70
        public void TemporaryRangeOfMotionBlend(){} // RVA: 0x7FFAC8C75FF0
        public void ResetTemporaryRangeOfMotionBlend(){} // RVA: 0x7FFAC8C761E0
        public void DoRangeOfMotionBlend(){} // RVA: 0x7FFAC8C763B0
        public void GetBlendPoseForBone(){} // RVA: 0x7FFAC8C76480
        public void UpdateSkeletonTransforms(){} // RVA: 0x7FFAC8C764D0
        public void SetBonePosition(){} // RVA: 0x7FFAC8C77420
        public void SetBoneRotation(){} // RVA: 0x7FFAC8C774C0
        public void GetBone(){} // RVA: 0x7FFAC8C77550
        public void GetBonePosition(){} // RVA: 0x7FFAC8C775C0
        public void GetBoneRotation(){} // RVA: 0x7FFAC8C776E0
        public void GetBonePositions(){} // RVA: 0x7FFAC8C777F0
        public void GetBoneRotations(){} // RVA: 0x7FFAC8C77B70
        public void MirrorPosition(){} // RVA: 0x7FFAC8C77E20
        public void MirrorRotation(){} // RVA: 0x7FFAC8C77F00
        public void UpdatePose(){} // RVA: 0x7FFAC8C78150
        public void ForceToReferencePose(){} // RVA: 0x7FFAC8C78A20
        public void IsMetacarpal(){} // RVA: 0x7FFAC8C79080
        public void .ctor(){} // RVA: 0x7FFAC8C790A0
        public void .cctor(){} // RVA: 0x7FFAC8C79100
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
        public void AssignBonesArray(){} // RVA: 0x7FFAC8C7A500
        public void .ctor(){} // RVA: 0x7FFAC8C7ADB0
    }

    public class SteamVR_Behaviour_SkeletonEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C39F70
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C3A000
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C3A090
    }

    public class SteamVR_Behaviour_Vector2 : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Vector2 isActive; // 0x20
        public 0x6B209C88 inputSource; // 0x28
        public Valve.VR.SteamVR_Behaviour_Vector2Event onChange; // 0x30
        public Valve.VR.SteamVR_Behaviour_Vector2Event onUpdate; // 0x38
        public Valve.VR.SteamVR_Behaviour_Vector2Event onAxis; // 0x40
        public ChangeHandler onChangeEvent; // 0x48
        public UpdateHandler onUpdateEvent; // 0x50
        public AxisHandler onAxisEvent; // 0x58

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFAC8C72640
        public void OnEnable(){} // RVA: 0x7FFAC8C7AE50
        public void OnDisable(){} // RVA: 0x7FFAC8C7AF40
        public void AddHandlers(){} // RVA: 0x7FFAC8C7AF50
        public void RemoveHandlers(){} // RVA: 0x7FFAC8C7B110
        public void SteamVR_Behaviour_Vector2_OnUpdate(){} // RVA: 0x7FFAC8C7B370
        public void SteamVR_Behaviour_Vector2_OnChange(){} // RVA: 0x7FFAC8C7B430
        public void SteamVR_Behaviour_Vector2_OnAxis(){} // RVA: 0x7FFAC8C7B4F0
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C7B5B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_Behaviour_Vector2Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C3A120
    }

    public class SteamVR_Behaviour_Vector3 : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Vector3 isActive; // 0x20
        public 0x6B209C88 inputSource; // 0x28
        public Valve.VR.SteamVR_Behaviour_Vector3Event onChange; // 0x30
        public Valve.VR.SteamVR_Behaviour_Vector3Event onUpdate; // 0x38
        public Valve.VR.SteamVR_Behaviour_Vector3Event onAxis; // 0x40
        public ChangeHandler onChangeEvent; // 0x48
        public UpdateHandler onUpdateEvent; // 0x50
        public AxisHandler onAxisEvent; // 0x58

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFAC8C72640
        public void OnEnable(){} // RVA: 0x7FFAC8C7B960
        public void OnDisable(){} // RVA: 0x7FFAC8C7BA50
        public void AddHandlers(){} // RVA: 0x7FFAC8C7BA60
        public void RemoveHandlers(){} // RVA: 0x7FFAC8C7BC20
        public void SteamVR_Behaviour_Vector3_OnUpdate(){} // RVA: 0x7FFAC8C7BE80
        public void SteamVR_Behaviour_Vector3_OnChange(){} // RVA: 0x7FFAC8C7BF90
        public void SteamVR_Behaviour_Vector3_OnAxis(){} // RVA: 0x7FFAC8C7C0A0
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C7C1B0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_Behaviour_Vector3Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C3A1B0
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
        public void get_head(){} // RVA: 0x7FFAC2F4F0C0
        public void get_offset(){} // RVA: 0x7FFAC2F4F0C0
        public void get_origin(){} // RVA: 0x7FFAC8C96990
        public void get_camera(){} // RVA: 0x7FFAC2F4F130
        public void set_camera(){} // RVA: 0x7FFAC2F22E90
        public void get_ears(){} // RVA: 0x7FFAC31D95E0
        public void GetRay(){} // RVA: 0x7FFAC8C969F0
        public void get_sceneResolutionScale(){} // RVA: 0x7FFAC8C96B50
        public void set_sceneResolutionScale(){} // RVA: 0x7FFAC8C96BA0
        public void OnDisable(){} // RVA: 0x7FFAC8C96C00
        public void OnEnable(){} // RVA: 0x7FFAC8C96D60
        public void Awake(){} // RVA: 0x7FFAC8C977F0
        public void ForceLast(){} // RVA: 0x7FFAC8C97880
        public void get_baseName(){} // RVA: 0x7FFAC8C981D0
        public void Expand(){} // RVA: 0x7FFAC8C98290
        public void Collapse(){} // RVA: 0x7FFAC8C99960
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_CameraFlip : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8C9A750
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_CameraHelper : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFAC8C39A60
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_CameraMask : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC8C9A7F0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_Ears : MonoBehaviour
    {
        public Valve.VR.SteamVR_Camera vrcam; // 0x20
        public bool usingSpeakers; // 0x28
        public UnityEngine.Quaternion offset; // 0x2C

        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x7FFAC8C9A890
        public void OnEnable(){} // RVA: 0x7FFAC8C9AC60
        public void OnDisable(){} // RVA: 0x7FFAC8C9AFE0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class SteamVR_Events : Object
    {
        public Event`1<bool> Calibrating;
        public Event`2<int,bool> DeviceConnected; // 0x8
        public Event`3<UnityEngine.Color,float,bool> Fade; // 0x10
        public Event FadeReady; // 0x18
        public Event`1<bool> HideRenderModels; // 0x20
        public Event`1<bool> Initializing; // 0x28
        public Event`1<bool> InputFocus; // 0x30
        public Event`1<bool> Loading; // 0x38
        public Event`1<float> LoadingFadeIn; // 0x40
        public Event`1<float> LoadingFadeOut; // 0x48
        public Event`1<Valve.VR.TrackedDevicePose_t[]> NewPoses; // 0x50
        public Event NewPosesApplied; // 0x58
        public Event`1<bool> Initialized; // 0x60
        public Event`1<bool> OutOfRange; // 0x68
        public Event`2<Valve.VR.SteamVR_RenderModel,bool> RenderModelLoaded; // 0x70
        public System.Collections.Generic.Dictionary`2<0x6B240290,Event`1<Valve.VR.VREvent_t>> systemEvents; // 0x78

        // ── Methods ──
        public void CalibratingAction(){} // RVA: 0x7FFAC8C9B0E0
        public void DeviceConnectedAction(){} // RVA: 0x7FFAC8C9B190
        public void FadeAction(){} // RVA: 0x7FFAC8C9B2E0
        public void FadeReadyAction(){} // RVA: 0x7FFAC8C9B430
        public void HideRenderModelsAction(){} // RVA: 0x7FFAC8C9B4E0
        public void InitializingAction(){} // RVA: 0x7FFAC8C9B590
        public void InputFocusAction(){} // RVA: 0x7FFAC8C9B640
        public void LoadingAction(){} // RVA: 0x7FFAC8C9B6F0
        public void LoadingFadeInAction(){} // RVA: 0x7FFAC8C9B7A0
        public void LoadingFadeOutAction(){} // RVA: 0x7FFAC8C9B850
        public void NewPosesAction(){} // RVA: 0x7FFAC8C9B900
        public void NewPosesAppliedAction(){} // RVA: 0x7FFAC8C9B9C0
        public void InitializedAction(){} // RVA: 0x7FFAC8C9BA70
        public void OutOfRangeAction(){} // RVA: 0x7FFAC8C9BB20
        public void RenderModelLoadedAction(){} // RVA: 0x7FFAC8C9BBD0
        public void System(){} // RVA: 0x7FFAC8C9BD20
        public void SystemAction(){} // RVA: 0x7FFAC8C9BED0
        public void .cctor(){} // RVA: 0x7FFAC8C9C010
    }

    public class SteamVR_ExternalCamera : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Pose cameraPose; // 0x20
        public 0x6B209C88 cameraInputSource; // 0x28
        public Config config; // 0x2C
        public string configPath; // 0x78
        public bool autoEnableDisableActionSet; // 0x80
        public System.IO.FileSystemWatcher watcher; // 0x88
        public UnityEngine.Camera cam; // 0x90
        public UnityEngine.Transform target; // 0x98
        public UnityEngine.GameObject clipQuad; // 0xA0
        public UnityEngine.Material clipMaterial; // 0xA8
        public Valve.VR.SteamVR_ActionSet activatedActionSet; // 0xB0
        public 0x6B209C88 activatedInputSource; // 0xB8
        public UnityEngine.Material colorMat; // 0xC0
        public UnityEngine.Material alphaMat; // 0xC8
        public UnityEngine.Camera[] cameras; // 0xD0
        public UnityEngine.Rect[] cameraRects; // 0xD8
        public float sceneResolutionScale; // 0xE0

        // ── Methods ──
        public void ReadConfig(){} // RVA: 0x7FFAC8C9CC50
        public void SetupPose(){} // RVA: 0x7FFAC8C9D690
        public void SetupDeviceIndex(){} // RVA: 0x7FFAC8C9D810
        public void OnChanged(){} // RVA: 0x7FFAC8C9D8C0
        public void AttachToCamera(){} // RVA: 0x7FFAC8C9D8D0
        public void GetTargetDistance(){} // RVA: 0x7FFAC8C9EE00
        public void RenderNear(){} // RVA: 0x7FFAC8C9F350
        public void RenderFar(){} // RVA: 0x7FFAC8CA04D0
        public void OnGUI(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC8CA0790
        public void AutoEnableActionSet(){} // RVA: 0x7FFAC8CA0CC0
        public void OnDisable(){} // RVA: 0x7FFAC8CA0E50
        public void .ctor(){} // RVA: 0x7FFAC8CA11E0
    }

    public class SteamVR_ExternalCamera_LegacyManager : Object
    {
        public int hasCamera;
        public Action newPosesAction; // 0x8

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x7FFAC8CA1240
        public void SubscribeToNewPoses(){} // RVA: 0x7FFAC8CA12A0
        public void OnNewPoses(){} // RVA: 0x7FFAC8CA1440
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8CA1570
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
        public void Start(){} // RVA: 0x7FFAC8CA1620
        public void View(){} // RVA: 0x7FFAC8CA16F0
        public void OnStartFade(){} // RVA: 0x7FFAC8CA1770
        public void OnEnable(){} // RVA: 0x7FFAC8CA1820
        public void OnDisable(){} // RVA: 0x7FFAC8CA1B30
        public void OnPostRender(){} // RVA: 0x7FFAC8CA1C30
        public void .ctor(){} // RVA: 0x7FFAC8CA2170
        public void .cctor(){} // RVA: 0x7FFAC8CA21D0
    }

    public class SteamVR_Frustum : MonoBehaviour
    {
        public 0x6B20B338 index; // 0x20
        public float fovLeft; // 0x24
        public float fovRight; // 0x28
        public float fovTop; // 0x2C
        public float fovBottom; // 0x30
        public float nearZ; // 0x34
        public float farZ; // 0x38

        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x7FFAC8CA2280
        public void OnDeviceConnected(){} // RVA: 0x7FFAC8CA2CB0
        public void OnEnable(){} // RVA: 0x7FFAC8CA2F50
        public void OnDisable(){} // RVA: 0x7FFAC8CA30A0
        public void .ctor(){} // RVA: 0x7FFAC8CA3220
    }

    public class SteamVR_HistoryBuffer : SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8CB6C40
        public void Update(){} // RVA: 0x7FFAC8CB6D10
        public void GetVelocityMagnitudeTrend(){} // RVA: 0x7FFAC8CB7080
        public void IsValid(){} // RVA: 0x7FFAC8CB7190
        public void GetTopVelocity(){} // RVA: 0x7FFAC8CB71B0
        public void GetAverageVelocities(){} // RVA: 0x7FFAC8CB72A0
    }

    public class SteamVR_HistoryStep : Object
    {
        public UnityEngine.Vector3 position; // 0x10
        public UnityEngine.Quaternion rotation; // 0x1C
        public UnityEngine.Vector3 velocity; // 0x2C
        public UnityEngine.Vector3 angularVelocity; // 0x38
        public long timeInTicks; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8CB7570
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
        public void LateUpdate(){} // RVA: 0x7FFAC8CA3290
        public void Solve(){} // RVA: 0x7FFAC8CA4BC0
        public void .ctor(){} // RVA: 0x7FFAC8CA5260
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
        public PosesUpdatedHandler onPosesUpdated; // 0x20
        public SkeletonsUpdatedHandler onSkeletonsUpdated; // 0x28
        public bool initializing; // 0x30
        public int startupFrame; // 0x34
        public Valve.VR.SteamVR_ActionSet[] actionSets; // 0x38
        public Valve.VR.SteamVR_Action[] actions; // 0x40
        public Valve.VR.ISteamVR_Action_In[] actionsIn; // 0x48
        public Valve.VR.ISteamVR_Action_Out[] actionsOut; // 0x50
        public Valve.VR.SteamVR_Action_Boolean[] actionsBoolean; // 0x58
        public Valve.VR.SteamVR_Action_Single[] actionsSingle; // 0x60
        public Valve.VR.SteamVR_Action_Vector2[] actionsVector2; // 0x68
        public Valve.VR.SteamVR_Action_Vector3[] actionsVector3; // 0x70
        public Valve.VR.SteamVR_Action_Pose[] actionsPose; // 0x78
        public Valve.VR.SteamVR_Action_Skeleton[] actionsSkeleton; // 0x80
        public Valve.VR.SteamVR_Action_Vibration[] actionsVibration; // 0x88
        public Valve.VR.ISteamVR_Action_In[] actionsNonPoseNonSkeletonIn; // 0x90
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
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x7FFAC8C7C560
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x7FFAC8C7C6B0
        public void add_onPosesUpdated(){} // RVA: 0x7FFAC8C7C800
        public void remove_onPosesUpdated(){} // RVA: 0x7FFAC8C7C950
        public void add_onSkeletonsUpdated(){} // RVA: 0x7FFAC8C7CAA0
        public void remove_onSkeletonsUpdated(){} // RVA: 0x7FFAC8C7CBF0
        public void get_isStartupFrame(){} // RVA: 0x7FFAC8C7CD40
        public void .cctor(){} // RVA: 0x7FFAC8C7CE60
        public void ForcePreinitialize(){} // RVA: 0x7FFAC8C7D480
        public void FindPreinitializeMethod(){} // RVA: 0x7FFAC8C7D4D0
        public void Initialize(){} // RVA: 0x7FFAC8C7D6B0
        public void PreinitializeFinishActionSets(){} // RVA: 0x7FFAC8C7DC40
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x7FFAC8C7DD10
        public void PreinitializeActionDictionaries(){} // RVA: 0x7FFAC8C7DFB0
        public void Update(){} // RVA: 0x7FFAC8C7E220
        public void LateUpdate(){} // RVA: 0x7FFAC8C7E340
        public void FixedUpdate(){} // RVA: 0x7FFAC8C7E480
        public void OnPreCull(){} // RVA: 0x7FFAC8C7E5A0
        public void UpdateVisualActions(){} // RVA: 0x7FFAC8C7E6C0
        public void UpdatePoseActions(){} // RVA: 0x7FFAC8C7E8C0
        public void UpdateSkeletonActions(){} // RVA: 0x7FFAC8C7EA40
        public void UpdateNonVisualActions(){} // RVA: 0x7FFAC8C7EBC0
        public void ShowBindingHintsForSets(){} // RVA: 0x7FFAC8C7EDE0
        public void ShowBindingHints(){} // RVA: 0x7FFAC8C7F140 | overloaded x2
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x7FFAC8C7F220
        public void GetActionDataFromPath(){} // RVA: 0x7FFAC2E8DC40
        public void GetActionSetDataFromPath(){} // RVA: 0x7FFAC8C7F3D0
        public void GetActionFromPath(){} // RVA: 0x7FFAC2E8DC40
        public void GetBaseActionFromPath(){} // RVA: 0x7FFAC8C7F480
        public void HasActionPath(){} // RVA: 0x7FFAC8C7F8D0
        public void HasAction(){} // RVA: 0x7FFAC8C7FAF0 | overloaded x2
        public void GetBooleanActionFromPath(){} // RVA: 0x7FFAC8C7FC00
        public void GetSingleActionFromPath(){} // RVA: 0x7FFAC8C7FC80
        public void GetVector2ActionFromPath(){} // RVA: 0x7FFAC8C7FD00
        public void GetVector3ActionFromPath(){} // RVA: 0x7FFAC8C7FD80
        public void GetVibrationActionFromPath(){} // RVA: 0x7FFAC8C7FE00
        public void GetPoseActionFromPath(){} // RVA: 0x7FFAC8C7FE80
        public void GetSkeletonActionFromPath(){} // RVA: 0x7FFAC8C7FF00
        public void GetAction(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetBaseAction(){} // RVA: 0x7FFAC8C7FF80
        public void CreateFakeAction(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetBooleanAction(){} // RVA: 0x7FFAC8C804E0 | overloaded x2
        public void GetSingleAction(){} // RVA: 0x7FFAC8C805F0 | overloaded x2
        public void GetVector2Action(){} // RVA: 0x7FFAC8C80700 | overloaded x2
        public void GetVector3Action(){} // RVA: 0x7FFAC8C80810 | overloaded x2
        public void GetPoseAction(){} // RVA: 0x7FFAC8C80920 | overloaded x2
        public void GetSkeletonAction(){} // RVA: 0x7FFAC8C80A30 | overloaded x2
        public void GetVibrationAction(){} // RVA: 0x7FFAC8C80B40 | overloaded x2
        public void GetActionSet(){} // RVA: 0x7FFAC8C80BC0 | overloaded x2
        public void HasActionSet(){} // RVA: 0x7FFAC8C80C50
        public void GetActionSetFromPath(){} // RVA: 0x7FFAC8C80CF0 | overloaded x2
        public void GetState(){} // RVA: 0x7FFAC8C80ED0 | overloaded x2
        public void GetStateDown(){} // RVA: 0x7FFAC8C811C0 | overloaded x2
        public void GetStateUp(){} // RVA: 0x7FFAC8C814B0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFAC8C817A0 | overloaded x2
        public void GetSingle(){} // RVA: 0x7FFAC8C81980 | overloaded x2
        public void GetVector2(){} // RVA: 0x7FFAC8C81B90 | overloaded x2
        public void GetVector3(){} // RVA: 0x7FFAC8C81F30 | overloaded x2
        public void GetActionSets(){} // RVA: 0x7FFAC8C81FD0
        public void GetActions(){} // RVA: 0x7FFAC2C58A90
        public void ShouldMakeCopy(){} // RVA: 0x7FFAC8C82030
        public void GetLocalizedName(){} // RVA: 0x7FFAC8C82090
        public void CheckOldLocation(){} // RVA: 0x7FFAC2F21320
        public void IdentifyActionsFile(){} // RVA: 0x7FFAC8C821E0
        public void HasFileInMemoryBeenModified(){} // RVA: 0x7FFAC8C82570
        public void CreateEmptyActionsFile(){} // RVA: 0x7FFAC8C82740
        public void DoesActionsFileExist(){} // RVA: 0x7FFAC8C82DF0
        public void InitializeFile(){} // RVA: 0x7FFAC8C82E50
        public void GetActionsFileFolder(){} // RVA: 0x7FFAC8C83270
        public void GetActionsFilePath(){} // RVA: 0x7FFAC8C83380
        public void GetActionsFileName(){} // RVA: 0x7FFAC8C83620
        public void DeleteManifestAndBindings(){} // RVA: 0x7FFAC8C83680
        public void OpenBindingUI(){} // RVA: 0x7FFAC8C83AF0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ActionFile : Object
    {
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_Action> actions; // 0x10
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_ActionSet> action_sets; // 0x18
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_DefaultBinding> default_bindings; // 0x20
        public System.Collections.Generic.List`1<System.Collections.Generic.Dictionary`2<string,string>> localization; // 0x28
        public string filePath; // 0x30
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_LocalizationItem> localizationHelperList; // 0x38
        public string findString_appKeyStart;
        public string findString_appKeyEnd;

        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x7FFAC8C83D00
        public void SaveHelperLists(){} // RVA: 0x7FFAC8C843B0
        public void GetShortName(){} // RVA: 0x7FFAC8C84BF0
        public void GetCodeFriendlyName(){} // RVA: 0x7FFAC8C84C90
        public void GetFilesToCopy(){} // RVA: 0x7FFAC8C84E40
        public void CopyFilesToPath(){} // RVA: 0x7FFAC8C851C0
        public void RemoveAppKey(){} // RVA: 0x7FFAC8C85490
        public void Open(){} // RVA: 0x7FFAC8C85610
        public void Save(){} // RVA: 0x7FFAC8C85710
        public void .ctor(){} // RVA: 0x7FFAC8C85890
    }

    public class SteamVR_Input_ActionFile_Action : Object
    {
        public string[] requirementValues;
        public string requirementEnum; // 0x10
        public string codeFriendlyName; // 0x18
        public string shortName; // 0x20
        public string path; // 0x28
        public string direction; // 0x30
        public string actionSet;
        public string prefix;

        // ── Methods ──
        public void get_requirementValues(){} // RVA: 0x7FFAC8C86660
        public void GetCopy(){} // RVA: 0x7FFAC8C86840
        public void get_requirementEnum(){} // RVA: 0x7FFAC8C86A30
        public void set_requirementEnum(){} // RVA: 0x7FFAC8C86B70
        public void get_codeFriendlyName(){} // RVA: 0x7FFAC8C85F80
        public void get_shortName(){} // RVA: 0x7FFAC8C86C20
        public void get_path(){} // RVA: 0x7FFAC8C86C30
        public void CreateNewName(){} // RVA: 0x7FFAC8C86D60 | overloaded x2
        public void CreateNew(){} // RVA: 0x7FFAC8C86E50
        public void get_direction(){} // RVA: 0x7FFAC8C87050
        public void get_actionSet(){} // RVA: 0x7FFAC8C87110
        public void SetNewActionSet(){} // RVA: 0x7FFAC8C871C0
        public void ToString(){} // RVA: 0x7FFAC8C86C20
        public void Equals(){} // RVA: 0x7FFAC8C873C0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ActionFile_ActionSet : Object
    {
        public string codeFriendlyName;
        public string shortName; // 0x10
        public string usage; // 0x18
        public string nameTemplate;
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_Action> actionsInList; // 0x20
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_Action> actionsOutList; // 0x28
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ActionFile_Action> actionsList; // 0x30

        // ── Methods ──
        public void get_codeFriendlyName(){} // RVA: 0x7FFAC8C85F80
        public void get_shortName(){} // RVA: 0x7FFAC8C85F90
        public void SetNewShortName(){} // RVA: 0x7FFAC8C86090
        public void CreateNewName(){} // RVA: 0x7FFAC8C86100
        public void GetPathFromName(){} // RVA: 0x7FFAC8C86140
        public void CreateNew(){} // RVA: 0x7FFAC8C861D0
        public void GetCopy(){} // RVA: 0x7FFAC8C862A0
        public void Equals(){} // RVA: 0x7FFAC8C863B0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC8C864B0
    }

    public class SteamVR_Input_ActionFile_ActionSet_Usages : Object
    {
        public string leftright;
        public string single; // 0x8
        public string hidden; // 0x10
        public string leftrightDescription; // 0x18
        public string singleDescription; // 0x20
        public string hiddenDescription; // 0x28
        public string[] listValues; // 0x30
        public string[] listDescriptions; // 0x38

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8C88DC0
    }

    public class SteamVR_Input_ActionFile_ActionTypes : Object
    {
        public string boolean;
        public string vector1; // 0x8
        public string vector2; // 0x10
        public string vector3; // 0x18
        public string vibration; // 0x20
        public string pose; // 0x28
        public string skeleton; // 0x30
        public string skeletonLeftPath; // 0x38
        public string skeletonRightPath; // 0x40
        public string[] listAll; // 0x48
        public string[] listIn; // 0x50
        public string[] listOut; // 0x58
        public string[] listSkeletons; // 0x60

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC8C884E0
    }

    public class SteamVR_Input_ActionFile_DefaultBinding : Object
    {
        public string controller_type; // 0x10
        public string binding_url; // 0x18

        // ── Methods ──
        public void GetCopy(){} // RVA: 0x7FFAC8C85E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ActionFile_LocalizationItem : Object
    {
        public string languageTagKeyName;
        public string language; // 0x10
        public System.Collections.Generic.Dictionary`2<string,string> items; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C876C0 | overloaded x2
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
        public void get_Axis(){} // RVA: 0x7FFAC8C52E50
        public void get_Select(){} // RVA: 0x7FFAC8C52E60
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFAC8C52E70
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAC8C52E80
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAC8C52E90
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAC8C52EA0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFAC8C52EB0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFAC8C52EC0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC8C52ED0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFAC8C52EE0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAC8C52EF0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFAC8C52F00
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAC8C52F10
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAC8C52F20
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAC8C52F30
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAC8C52F40
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAC8C52F50
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAC8C52F60
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAC8C52F70
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAC8C52F80
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFAC8C52F90
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAC8C52FA0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAC8C52FB0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAC8C52FC0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC8C52FD0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAC8C52FE0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAC8C52FF0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAC8C53000
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAC8C53010
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAC8C53020
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAC8C53030
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAC8C53040
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC8C53050
        public void get_Reserve_bool(){} // RVA: 0x7FFAC8C53060
        public void get_Reserve_vector1(){} // RVA: 0x7FFAC8C53070
        public void get_Reserve_vector2(){} // RVA: 0x7FFAC8C53080
        public void get_Grab(){} // RVA: 0x7FFAC8C53090
        public void get_Drop(){} // RVA: 0x7FFAC8C530A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_Left_Joystick(){} // RVA: 0x7FFAC8C530B0
        public void get_Right_Joystick(){} // RVA: 0x7FFAC8C530C0
        public void get_Self_Leveling_Mod(){} // RVA: 0x7FFAC8C530D0
        public void get_Hold_Altitude_Mod(){} // RVA: 0x7FFAC8C530E0
        public void get_Toggle_FPV(){} // RVA: 0x7FFAC8C530F0
        public void get_Flip(){} // RVA: 0x7FFAC8C53100
        public void get_Take_Picture(){} // RVA: 0x7FFAC8C53110
        public void get_Cycle_Flight_Preset(){} // RVA: 0x7FFAC8C53120
        public void get_Toggle_Self_Leveling(){} // RVA: 0x7FFAC8C53130
        public void get_Respawn(){} // RVA: 0x7FFAC8C53140
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x7FFAC8C53150
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFAC8C53160
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x7FFAC8C53170
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFAC8C53180
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_Safe_Mode(){} // RVA: 0x7FFAC8C53190
        public void get_Pose(){} // RVA: 0x7FFAC8C531A0
        public void get_SkeletonLeftHand(){} // RVA: 0x7FFAC8C531B0
        public void get_SkeletonRightHand(){} // RVA: 0x7FFAC8C531C0
        public void get_HeadsetOnHead(){} // RVA: 0x7FFAC8C531D0
        public void get_Menu(){} // RVA: 0x7FFAC8C531E0
        public void get_Quick_Menu(){} // RVA: 0x7FFAC8C531F0
        public void get_Action_Menu(){} // RVA: 0x7FFAC8C53200
        public void get_Main_Menu(){} // RVA: 0x7FFAC8C53210
        public void get_Interact(){} // RVA: 0x7FFAC8C53220
        public void get_Grab(){} // RVA: 0x7FFAC8C53230
        public void get_Move(){} // RVA: 0x7FFAC8C53240
        public void get_Jump(){} // RVA: 0x7FFAC8C53250
        public void get_Rotate(){} // RVA: 0x7FFAC8C53260
        public void get_Mic(){} // RVA: 0x7FFAC8C53270
        public void get_Gesture_Toggle(){} // RVA: 0x7FFAC8C53280
        public void get_Stick_Click(){} // RVA: 0x7FFAC8C53290
        public void get_Trigger_Axis(){} // RVA: 0x7FFAC8C532A0
        public void get_Grip_Axis(){} // RVA: 0x7FFAC8C532B0
        public void get_Udon_Menu(){} // RVA: 0x7FFAC8C532C0
        public void get_Drop(){} // RVA: 0x7FFAC8C532D0
        public void get_Nameplates(){} // RVA: 0x7FFAC8C532E0
        public void get_HUD(){} // RVA: 0x7FFAC8C532F0
        public void get_Chatbox(){} // RVA: 0x7FFAC8C53300
        public void get_Face_Mirror(){} // RVA: 0x7FFAC8C53310
        public void get_Personal_Mirror(){} // RVA: 0x7FFAC8C53320
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFAC8C53330
        public void get_Earmuffs(){} // RVA: 0x7FFAC8C53340
        public void get_Camera(){} // RVA: 0x7FFAC8C53350
        public void get_Stream_Camera(){} // RVA: 0x7FFAC8C53360
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFAC8C53370
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFAC8C53380
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFAC8C53390
        public void get_Start_Move(){} // RVA: 0x7FFAC8C533A0
        public void get_Start_Rotate(){} // RVA: 0x7FFAC8C533B0
        public void get_Continue_Move(){} // RVA: 0x7FFAC8C533C0
        public void get_Continue_Rotate(){} // RVA: 0x7FFAC8C533D0
        public void get_No_Gesture_After_Move(){} // RVA: 0x7FFAC8C533E0
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x7FFAC8C533F0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFAC8C53400
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAC8C53410
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAC8C53420
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAC8C53430
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFAC8C53440
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFAC8C53450
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC8C53460
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFAC8C53470
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAC8C53480
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFAC8C53490
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFAC8C534A0
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x7FFAC8C534B0
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFAC8C534C0
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFAC8C534D0
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFAC8C534E0
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFAC8C534F0
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x7FFAC8C53500
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFAC8C53510
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFAC8C53520
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x7FFAC8C53530
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFAC8C53540
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFAC8C53550
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFAC8C53560
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFAC8C53570
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x7FFAC8C53580
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFAC8C53590
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAC8C535A0
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAC8C535B0
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAC8C535C0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAC8C535D0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAC8C535E0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAC8C535F0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAC8C53600
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAC8C53610
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFAC8C53620
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAC8C53630
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAC8C53640
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAC8C53650
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC8C53660
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAC8C53670
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAC8C53680
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAC8C53690
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAC8C536A0
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x7FFAC8C536B0
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAC8C536C0
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAC8C536D0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAC8C536E0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC8C536F0
        public void get_Physbone_Grab_Left(){} // RVA: 0x7FFAC8C53700
        public void get_Physbone_Freeze_Left(){} // RVA: 0x7FFAC8C53710
        public void get_Physbone_Grab_Right(){} // RVA: 0x7FFAC8C53720
        public void get_Physbone_Freeze_Right(){} // RVA: 0x7FFAC8C53730
        public void get_Scroll(){} // RVA: 0x7FFAC8C53740
        public void get_Haptic(){} // RVA: 0x7FFAC8C53750
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_Confirm(){} // RVA: 0x7FFAC8C53760
        public void get_Back(){} // RVA: 0x7FFAC8C53770
        public void get_Tab(){} // RVA: 0x7FFAC8C53780
        public void get_Scroll(){} // RVA: 0x7FFAC8C53790
        public void get_Quick_Menu_Close(){} // RVA: 0x7FFAC8C537A0
        public void get_Drag(){} // RVA: 0x7FFAC8C537B0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public void get_Interact(){} // RVA: 0x7FFAC8C537C0
        public void get_Grab(){} // RVA: 0x7FFAC8C537D0
        public void get_Move_Rotate(){} // RVA: 0x7FFAC8C537E0
        public void get_Jump(){} // RVA: 0x7FFAC8C537F0
        public void get_Mic(){} // RVA: 0x7FFAC8C53800
        public void get_Gesture_Toggle(){} // RVA: 0x7FFAC8C53810
        public void get_Stick_Click(){} // RVA: 0x7FFAC8C53820
        public void get_Trigger_Axis(){} // RVA: 0x7FFAC8C53830
        public void get_Grip_Axis(){} // RVA: 0x7FFAC8C53840
        public void get_Udon_Menu(){} // RVA: 0x7FFAC8C53850
        public void get_Drop(){} // RVA: 0x7FFAC8C53860
        public void get_Start_Move_Rotate(){} // RVA: 0x7FFAC8C53870
        public void get_Continue_Move_Rotate(){} // RVA: 0x7FFAC8C53880
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFAC8C53890
        public void get_Menu(){} // RVA: 0x7FFAC8C538A0
        public void get_Nameplates(){} // RVA: 0x7FFAC8C538B0
        public void get_HUD(){} // RVA: 0x7FFAC8C538C0
        public void get_Chatbox(){} // RVA: 0x7FFAC8C538D0
        public void get_Face_Mirror(){} // RVA: 0x7FFAC8C538E0
        public void get_Personal_Mirror(){} // RVA: 0x7FFAC8C538F0
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFAC8C53900
        public void get_Earmuffs(){} // RVA: 0x7FFAC8C53910
        public void get_Camera(){} // RVA: 0x7FFAC8C53920
        public void get_Stream_Camera(){} // RVA: 0x7FFAC8C53930
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFAC8C53940
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFAC8C53950
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFAC8C53960
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFAC8C53970
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFAC8C53980
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFAC8C53990
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFAC8C539A0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFAC8C539B0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFAC8C539C0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFAC8C539D0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFAC8C539E0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFAC8C539F0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFAC8C53A00
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFAC8C53A10
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFAC8C53A20
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFAC8C53A30
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFAC8C53A40
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFAC8C53A50
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFAC8C53A60
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFAC8C53A70
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFAC8C53A80
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFAC8C53A90
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFAC8C53AA0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFAC8C53AB0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFAC8C53AC0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFAC8C53AD0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFAC8C53AE0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFAC8C53AF0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFAC8C53B00
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFAC8C53B10
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFAC8C53B20
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFAC8C53B30
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFAC8C53B40
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFAC8C53B50
        public void get_Reserve_bool(){} // RVA: 0x7FFAC8C53B60
        public void get_Reserve_vector1(){} // RVA: 0x7FFAC8C53B70
        public void get_Reserve_vector2(){} // RVA: 0x7FFAC8C53B80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_BindingFile : Object
    {
        public string app_key; // 0x10
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_Input_BindingFile_ActionList> bindings; // 0x18
        public string controller_type; // 0x20
        public string description; // 0x28
        public string name; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C892D0
    }

    public class SteamVR_Input_BindingFile_ActionList : Object
    {
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_BindingFile_Chord> chords; // 0x10
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_BindingFile_Pose> poses; // 0x18
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_BindingFile_Haptic> haptics; // 0x20
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_BindingFile_Source> sources; // 0x28
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_BindingFile_Skeleton> skeleton; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C89390
    }

    public class SteamVR_Input_BindingFile_Chord : Object
    {
        public string output; // 0x10
        public System.Collections.Generic.List`1<System.Collections.Generic.List`1<string>> inputs; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8C896B0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC8C899E0
    }

    public class SteamVR_Input_BindingFile_Haptic : Object
    {
        public string output; // 0x10
        public string path; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8C89BF0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_BindingFile_Pose : Object
    {
        public string output; // 0x10
        public string path; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8C89AA0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_BindingFile_Skeleton : Object
    {
        public string output; // 0x10
        public string path; // 0x18

        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8C89D40
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_BindingFile_Source : Object
    {
        public string path; // 0x10
        public string mode; // 0x18
        public Valve.VR.SteamVR_Input_BindingFile_Source_Input_StringDictionary parameters; // 0x20
        public Valve.VR.SteamVR_Input_BindingFile_Source_Input inputs; // 0x28
        public string outputKeyName;

        // ── Methods ──
        public void GetOutput(){} // RVA: 0x7FFAC8C89E90
        public void Equals(){} // RVA: 0x7FFAC8C8A210
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC8C8A400
    }

    public class SteamVR_Input_BindingFile_Source_Input : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8C8A580
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC8C8A870
    }

    public class SteamVR_Input_BindingFile_Source_Input_StringDictionary : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFAC8C8A8B0
        public void GetHashCode(){} // RVA: 0x7FFAC83FAE70
        public void .ctor(){} // RVA: 0x7FFAC8C8A9F0
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
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ManifestFile : Object
    {
        public string source; // 0x10
        public System.Collections.Generic.List`1<Valve.VR.SteamVR_Input_ManifestFile_Application> applications; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ManifestFile_Application : Object
    {
        public string app_key; // 0x10
        public string launch_type; // 0x18
        public string url; // 0x20
        public string binary_path_windows; // 0x28
        public string binary_path_linux; // 0x30
        public string binary_path_osx; // 0x38
        public string action_manifest_path; // 0x40
        public string image_path; // 0x48
        public System.Collections.Generic.Dictionary`2<string,Valve.VR.SteamVR_Input_ManifestFile_ApplicationString> strings; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8C87A80
    }

    public class SteamVR_Input_ManifestFile_ApplicationString : Object
    {
        public string name; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding : Object
    {
        public string controller_type; // 0x10
        public string binding_url; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding_ControllerTypes : Object
    {
        public string oculus_touch;
        public string vive_controller; // 0x8
        public string knuckles; // 0x10
        public string holographic_controller; // 0x18
        public string vive; // 0x20
        public string vive_pro; // 0x28
        public string holographic_hmd; // 0x30
        public string rift; // 0x38
        public string vive_tracker_camera; // 0x40
        public string vive_cosmos; // 0x48
        public string vive_cosmos_controller; // 0x50
        public string index_hmd; // 0x58

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8C87EA0
    }

}