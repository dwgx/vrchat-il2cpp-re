// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 100
// Methods: 1907

namespace ThirdParty.Valve.Valve.VR
{
    public class SpatialAnchorPose_t
    {
    }

    public class SteamVR
    {
        public System.Nullable`1<bool> isSupported;
        public bool _enabled; // 0x2
        public Valve.VR.SteamVR _instance; // 0x8
        public 0x65926310 initializedState; // 0x10
        public Valve.VR.SteamVR_Settings <settings>k__BackingField; // 0x18
        public Valve.VR.CVRSystem <hmd>k__BackingField; // 0x10
        public Valve.VR.CVRCompositor <compositor>k__BackingField; // 0x18
        public Valve.VR.CVROverlay <overlay>k__BackingField; // 0x20
        public bool <initializing>k__BackingField; // 0x20
        public bool <calibrating>k__BackingField; // 0x21
        public bool <outOfRange>k__BackingField; // 0x22
        public bool[] connected; // 0x28
        public float <sceneWidth>k__BackingField; // 0x28
        public float <sceneHeight>k__BackingField; // 0x2C
        public float <aspect>k__BackingField; // 0x30
        public float <fieldOfView>k__BackingField; // 0x34
        public UnityEngine.Vector2 <tanHalfFov>k__BackingField; // 0x38
        public Valve.VR.VRTextureBounds_t[] <textureBounds>k__BackingField; // 0x40
        public RigidTransform[] <eyes>k__BackingField; // 0x48
        public 0x6595C188 textureType; // 0x50
        public bool runningTemporarySession; // 0x30
        public string defaultUnityAppKeyTemplate;
        public string defaultAppKeyTemplate;

        // ── Methods ──
        public void get_active(){} // RVA: 0x64F94D0
        public void get_enabled(){} // RVA: 0x64F9530
        public void set_enabled(){} // RVA: 0x64F9760
        public void get_instance(){} // RVA: 0x64F9800
        public void Initialize(){} // RVA: 0x64F9960
        public void get_usingNativeSupport(){} // RVA: 0x64F9B20
        public void get_settings(){} // RVA: 0x64F9B70
        public void set_settings(){} // RVA: 0x64F9BD0
        public void ReportGeneralErrors(){} // RVA: 0x64F9C90
        public void CreateInstance(){} // RVA: 0x64F9D20
        public void ReportError(){} // RVA: 0x64FA3C0
        public void get_hmd(){} // RVA: 0x2F8380
        public void set_hmd(){} // RVA: 0x2DEE30
        public void get_compositor(){} // RVA: 0x2E07C0
        public void set_compositor(){} // RVA: 0x343E80
        public void get_overlay(){} // RVA: 0x30B0C0
        public void set_overlay(){} // RVA: 0x30B0D0
        public void get_initializing(){} // RVA: 0x64FA580
        public void set_initializing(){} // RVA: 0x64FA5E0
        public void get_calibrating(){} // RVA: 0x64FA640
        public void set_calibrating(){} // RVA: 0x64FA6A0
        public void get_outOfRange(){} // RVA: 0x64FA700
        public void set_outOfRange(){} // RVA: 0x64FA760
        public void get_sceneWidth(){} // RVA: 0x3BC210
        public void set_sceneWidth(){} // RVA: 0x3BC220
        public void get_sceneHeight(){} // RVA: 0x4652A0
        public void set_sceneHeight(){} // RVA: 0x8CF4F0
        public void get_aspect(){} // RVA: 0x466280
        public void set_aspect(){} // RVA: 0x4FDE90
        public void get_fieldOfView(){} // RVA: 0x3A7630
        public void set_fieldOfView(){} // RVA: 0x3A7640
        public void get_tanHalfFov(){} // RVA: 0x1514540
        public void set_tanHalfFov(){} // RVA: 0xF501D0
        public void get_textureBounds(){} // RVA: 0x35A740
        public void set_textureBounds(){} // RVA: 0x305200
        public void get_eyes(){} // RVA: 0x358730
        public void set_eyes(){} // RVA: 0x358740
        public void get_hmd_TrackingSystemName(){} // RVA: 0x64FA7C0
        public void get_hmd_ActualTrackingSystemName(){} // RVA: 0x64FA7D0
        public void get_hmd_ModelNumber(){} // RVA: 0x64FA7E0
        public void get_hmd_SerialNumber(){} // RVA: 0x64FA7F0
        public void get_hmd_Type(){} // RVA: 0x64FA800
        public void get_hmd_SecondsFromVsyncToPhotons(){} // RVA: 0x64FA810
        public void get_hmd_DisplayFrequency(){} // RVA: 0x64FA860
        public void GetHeadsetActivityLevel(){} // RVA: 0x64FA8B0
        public void GetTrackedDeviceString(){} // RVA: 0x64FA900
        public void GetStringProperty(){} // RVA: 0x64FAA40
        public void GetFloatProperty(){} // RVA: 0x64FABE0
        public void InitializeTemporarySession(){} // RVA: 0x64FAC30
        public void ExitTemporarySession(){} // RVA: 0x64FACF0
        public void GenerateAppKey(){} // RVA: 0x64FAD90
        public void GenerateCleanProductName(){} // RVA: 0x64FAFB0
        public void GetManifestFile(){} // RVA: 0x64FB140
        public void IdentifyEditorApplication(){} // RVA: 0x64FBD20
        public void OnInitializing(){} // RVA: 0x64FC1A0
        public void OnCalibrating(){} // RVA: 0x64FC240
        public void OnOutOfRange(){} // RVA: 0x64FC2E0
        public void OnDeviceConnected(){} // RVA: 0x64FC380
        public void OnNewPoses(){} // RVA: 0x64FC410
        public void .ctor(){} // RVA: 0x64FC910
        public void Finalize(){} // RVA: 0x64FD760
        public void Dispose(){} // RVA: 0x64FD810 | overloaded x2
        public void SafeDispose(){} // RVA: 0x64FDC30
        public void .cctor(){} // RVA: 0x64FDD20
    }

    public class SteamVREnumEqualityComparer`1
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x283FA0
        public void GetHashCode(){} // RVA: 0x283FA0
    }

    public class SteamVR_Action
    {
        public string actionPath; // 0x10
        public bool needsReinit; // 0x18
        public bool startUpdatingSourceOnAccess;
        public string cachedShortName; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Create(){} // RVA: 0x283FA0
        public void CreateUninitialized(){} // RVA: 0x2A620 | overloaded x4
        public void GetCopy(){} // RVA: 0x283FA0
        public void TryNeedsInitData(){} // RVA: 0xCD60
        public void InitializeCopy(){} // RVA: 0x2DC60
        public void get_fullPath(){} // RVA: 0xCD60
        public void get_handle(){} // RVA: 0xCD60
        public void get_actionSet(){} // RVA: 0xCD60
        public void get_direction(){} // RVA: 0xD840
        public void get_setActive(){} // RVA: 0x64A36B0
        public void get_active(){} // RVA: 0xDBE0
        public void get_activeBinding(){} // RVA: 0xDBE0
        public void get_lastActive(){} // RVA: 0xDBE0
        public void get_lastActiveBinding(){} // RVA: 0xDBE0
        public void PreInitialize(){} // RVA: 0x24B10
        public void Initialize(){} // RVA: 0x251C0
        public void GetTimeLastChanged(){} // RVA: 0x21C40
        public void GetSourceMap(){} // RVA: 0xCD60
        public void GetActive(){} // RVA: 0xE1F0
        public void GetSetActive(){} // RVA: 0x64A3710
        public void GetActiveBinding(){} // RVA: 0xE1F0
        public void GetLastActive(){} // RVA: 0xE1F0
        public void GetLastActiveBinding(){} // RVA: 0xE1F0
        public void GetPath(){} // RVA: 0x2F8380
        public void IsUpdating(){} // RVA: 0xE1F0
        public void GetHashCode(){} // RVA: 0x64A3790
        public void Equals(){} // RVA: 0x64A3810 | overloaded x2
        public void op_Inequality(){} // RVA: 0x64A3940
        public void op_Equality(){} // RVA: 0x64A3A70
        public void FindExistingActionForPartialPath(){} // RVA: 0x64A3B70
        public void GetShortName(){} // RVA: 0x64A3C90
        public void ShowOrigins(){} // RVA: 0x64A3D30
        public void HideOrigins(){} // RVA: 0x64A3E00
        public void .cctor(){} // RVA: 0x64A3E50
    }

    public class SteamVR_ActionSet
    {
        public string actionSetPath; // 0x10
        public Valve.VR.SteamVR_ActionSet_Data setData; // 0x18
        public bool initialized; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void get_allActions(){} // RVA: 0x64A4A90
        public void get_nonVisualInActions(){} // RVA: 0x64A4AD0
        public void get_visualActions(){} // RVA: 0x64A4B10
        public void get_poseActions(){} // RVA: 0x64A4B50
        public void get_skeletonActions(){} // RVA: 0x64A4B90
        public void get_outActionArray(){} // RVA: 0x64A4BD0
        public void get_fullPath(){} // RVA: 0x64A4C10
        public void get_usage(){} // RVA: 0x64A4C50
        public void get_handle(){} // RVA: 0x64A4C90
        public void Create(){} // RVA: 0x283FA0
        public void CreateFromName(){} // RVA: 0x283FA0
        public void PreInitialize(){} // RVA: 0x64A4CD0
        public void FinishPreInitialize(){} // RVA: 0x64A4E50
        public void Initialize(){} // RVA: 0x64A4E70
        public void GetPath(){} // RVA: 0x2F8380
        public void IsActive(){} // RVA: 0x64A4F50
        public void GetTimeLastChanged(){} // RVA: 0x64A4FB0
        public void Activate(){} // RVA: 0x64A5000
        public void Deactivate(){} // RVA: 0x64A51B0
        public void GetShortName(){} // RVA: 0x64A52C0
        public void ShowBindingHints(){} // RVA: 0x64A5350
        public void ReadRawSetActive(){} // RVA: 0x64A5490
        public void ReadRawSetLastChanged(){} // RVA: 0x64A54D0
        public void ReadRawSetPriority(){} // RVA: 0x64A5510
        public void GetActionSetData(){} // RVA: 0x2E07C0
        public void GetCopy(){} // RVA: 0x283FA0
        public void Equals(){} // RVA: 0x64A5550 | overloaded x2
        public void GetHashCode(){} // RVA: 0x64A3790
        public void op_Inequality(){} // RVA: 0x64A5660
        public void op_Equality(){} // RVA: 0x64A5720
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64A57D0
    }

    public class SteamVR_ActionSet_Data
    {
        public Valve.VR.SteamVR_Action[] <allActions>k__BackingField; // 0x10
        public Valve.VR.ISteamVR_Action_In[] <nonVisualInActions>k__BackingField; // 0x18
        public Valve.VR.ISteamVR_Action_In[] <visualActions>k__BackingField; // 0x20
        public Valve.VR.SteamVR_Action_Pose[] <poseActions>k__BackingField; // 0x28
        public Valve.VR.SteamVR_Action_Skeleton[] <skeletonActions>k__BackingField; // 0x30
        public Valve.VR.ISteamVR_Action_Out[] <outActionArray>k__BackingField; // 0x38
        public string <fullPath>k__BackingField; // 0x40
        public string <usage>k__BackingField; // 0x48
        public ulong <handle>k__BackingField; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A58F0
        public void get_allActions(){} // RVA: 0x2F8380
        public void set_allActions(){} // RVA: 0x2DEE30
        public void get_nonVisualInActions(){} // RVA: 0x2E07C0
        public void set_nonVisualInActions(){} // RVA: 0x343E80
        public void get_visualActions(){} // RVA: 0x30B0C0
        public void set_visualActions(){} // RVA: 0x30B0D0
        public void get_poseActions(){} // RVA: 0x30B130
        public void set_poseActions(){} // RVA: 0x2DEE90
        public void get_skeletonActions(){} // RVA: 0x6374D0
        public void set_skeletonActions(){} // RVA: 0x30B890
        public void get_outActionArray(){} // RVA: 0x4976A0
        public void set_outActionArray(){} // RVA: 0x49B830
        public void get_fullPath(){} // RVA: 0x35A740
        public void set_fullPath(){} // RVA: 0x305200
        public void get_usage(){} // RVA: 0x358730
        public void set_usage(){} // RVA: 0x358740
        public void get_handle(){} // RVA: 0x37E0E0
        public void set_handle(){} // RVA: 0x4C4D50
        public void PreInitialize(){} // RVA: 0x2DD310
        public void FinishPreInitialize(){} // RVA: 0x64A5AD0
        public void Initialize(){} // RVA: 0x64A6540
        public void IsActive(){} // RVA: 0x64A6730
        public void GetTimeLastChanged(){} // RVA: 0x64A6780
        public void Activate(){} // RVA: 0x64A67C0
        public void Deactivate(){} // RVA: 0x64A6960
        public void GetShortName(){} // RVA: 0x64A6A70
        public void ReadRawSetActive(){} // RVA: 0x64A6AF0
        public void ReadRawSetLastChanged(){} // RVA: 0x64A6B20
        public void ReadRawSetPriority(){} // RVA: 0x64A6B50
    }

    public class SteamVR_ActionSet_Manager
    {
        public uint UnityHandler;

        // ── Methods ──
        public void get_rawActiveActionSetArray(){} // RVA: 0x64A6B80
        public void Initialize(){} // RVA: 0x64A6C00
        public void DisableAllActionSets(){} // RVA: 0x64A6DB0
        public void UpdateActionStates(){} // RVA: 0x64A6EF0
        public void SetChanged(){} // RVA: 0x64A7210
        public void GetNewArraySize(){} // RVA: 0x64A7250
        public void UpdateActionSetsArray(){} // RVA: 0x64A7390
        public void GetSetFromHandle(){} // RVA: 0x64A78A0
        public void UpdateDebugText(){} // RVA: 0x64A79C0
    }

    public class SteamVR_Action_Boolean
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x64A7E60
        public void remove_onChange(){} // RVA: 0x64A7EE0
        public void add_onUpdate(){} // RVA: 0x64A7F60
        public void remove_onUpdate(){} // RVA: 0x64A7FE0
        public void add_onState(){} // RVA: 0x64A8060
        public void remove_onState(){} // RVA: 0x64A80E0
        public void add_onStateDown(){} // RVA: 0x64A8160
        public void remove_onStateDown(){} // RVA: 0x64A81E0
        public void add_onStateUp(){} // RVA: 0x64A8260
        public void remove_onStateUp(){} // RVA: 0x64A82E0
        public void add_onActiveChange(){} // RVA: 0x64A8360
        public void remove_onActiveChange(){} // RVA: 0x64A83E0
        public void add_onActiveBindingChange(){} // RVA: 0x64A8460
        public void remove_onActiveBindingChange(){} // RVA: 0x64A84E0
        public void get_state(){} // RVA: 0x64A8560
        public void get_stateDown(){} // RVA: 0x64A85F0
        public void get_stateUp(){} // RVA: 0x64A8680
        public void get_lastState(){} // RVA: 0x64A8710
        public void get_lastStateDown(){} // RVA: 0x64A8770
        public void get_lastStateUp(){} // RVA: 0x64A87F0
        public void .ctor(){} // RVA: 0x64A8870
        public void GetStateDown(){} // RVA: 0x64A88B0
        public void GetStateUp(){} // RVA: 0x64A8950
        public void GetState(){} // RVA: 0x64A89F0
        public void GetLastStateDown(){} // RVA: 0x64A8A90
        public void GetLastStateUp(){} // RVA: 0x64A8B20
        public void GetLastState(){} // RVA: 0x64A8BB0
        public void AddOnActiveChangeListener(){} // RVA: 0x64A8C20
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64A8CA0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x64A8D20
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x64A8DA0
        public void AddOnChangeListener(){} // RVA: 0x64A8E20
        public void RemoveOnChangeListener(){} // RVA: 0x64A8EA0
        public void AddOnUpdateListener(){} // RVA: 0x64A8F20
        public void RemoveOnUpdateListener(){} // RVA: 0x64A8FA0
        public void AddOnStateDownListener(){} // RVA: 0x64A9020
        public void RemoveOnStateDownListener(){} // RVA: 0x64A90A0
        public void AddOnStateUpListener(){} // RVA: 0x64A9120
        public void RemoveOnStateUpListener(){} // RVA: 0x64A91A0
        public void RemoveAllListeners(){} // RVA: 0x64A9220
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64A9290
    }

    public class SteamVR_Action_Boolean_Source
    {
        public uint actionData_size;
        public StateDownHandler onStateDown; // 0x158
        public StateUpHandler onStateUp; // 0x160
        public StateHandler onState; // 0x168
        public ActiveChangeHandler onActiveChange; // 0x170
        public ActiveChangeHandler onActiveBindingChange; // 0x178
        public ChangeHandler onChange; // 0x180
        public UpdateHandler onUpdate; // 0x188
        public bool <lastActive>k__BackingField; // 0x190
        public Valve.VR.InputDigitalActionData_t actionData; // 0x198
        public Valve.VR.InputDigitalActionData_t lastActionData; // 0x1B0
        public Valve.VR.SteamVR_Action_Boolean booleanAction; // 0x1C8

        // ── Methods ──
        public void add_onStateDown(){} // RVA: 0x64A96D0
        public void remove_onStateDown(){} // RVA: 0x64A97C0
        public void add_onStateUp(){} // RVA: 0x64A98B0
        public void remove_onStateUp(){} // RVA: 0x64A99A0
        public void add_onState(){} // RVA: 0x64A9A90
        public void remove_onState(){} // RVA: 0x64A9B80
        public void add_onActiveChange(){} // RVA: 0x64A9C70
        public void remove_onActiveChange(){} // RVA: 0x64A9D60
        public void add_onActiveBindingChange(){} // RVA: 0x64A9E50
        public void remove_onActiveBindingChange(){} // RVA: 0x64A9F40
        public void add_onChange(){} // RVA: 0x64AA030
        public void remove_onChange(){} // RVA: 0x64AA120
        public void add_onUpdate(){} // RVA: 0x64AA210
        public void remove_onUpdate(){} // RVA: 0x64AA300
        public void get_state(){} // RVA: 0x64AA3F0
        public void get_stateDown(){} // RVA: 0x64AA430
        public void get_stateUp(){} // RVA: 0x64AA470
        public void get_changed(){} // RVA: 0x64AA4B0
        public void set_changed(){} // RVA: 0x2DD310
        public void get_lastState(){} // RVA: 0x64AA4F0
        public void get_lastStateDown(){} // RVA: 0x64AA500
        public void get_lastStateUp(){} // RVA: 0x64AA520
        public void get_lastChanged(){} // RVA: 0x64AA540
        public void set_lastChanged(){} // RVA: 0x2DD310
        public void get_activeOrigin(){} // RVA: 0x64AA550
        public void get_lastActiveOrigin(){} // RVA: 0xDB2150
        public void get_active(){} // RVA: 0x64AA590
        public void get_activeBinding(){} // RVA: 0x63A7830
        public void get_lastActive(){} // RVA: 0x64AA630
        public void set_lastActive(){} // RVA: 0x64AA640
        public void get_lastActiveBinding(){} // RVA: 0x64AA650
        public void Preinitialize(){} // RVA: 0x64AA660
        public void Initialize(){} // RVA: 0x64AA7F0
        public void RemoveAllListeners(){} // RVA: 0x64AA8D0
        public void UpdateValue(){} // RVA: 0x64AAC70
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Action_Boolean_Source_Map
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A9690
    }

    public class SteamVR_Action_In_Source
    {
        public uint inputOriginInfo_size;
        public bool <isUpdating>k__BackingField; // 0x28
        public float <updateTime>k__BackingField; // 0x2C
        public float <changedTime>k__BackingField; // 0x30
        public int <lastOriginGetFrame>k__BackingField; // 0x34
        public Valve.VR.InputOriginInfo_t inputOriginInfo; // 0x38
        public Valve.VR.InputOriginInfo_t lastInputOriginInfo; // 0xC8

        // ── Methods ──
        public void get_isUpdating(){} // RVA: 0x6E8A80
        public void set_isUpdating(){} // RVA: 0x6E8B80
        public void get_updateTime(){} // RVA: 0x4652A0
        public void set_updateTime(){} // RVA: 0x8CF4F0
        public void get_activeOrigin(){} // RVA: 0xCD60
        public void get_lastActiveOrigin(){} // RVA: 0xCD60
        public void get_changed(){} // RVA: 0xDBE0
        public void set_changed(){} // RVA: 0x25130
        public void get_lastChanged(){} // RVA: 0xDBE0
        public void set_lastChanged(){} // RVA: 0x25130
        public void get_activeDevice(){} // RVA: 0x64AB390
        public void get_trackedDeviceIndex(){} // RVA: 0x64AB3F0
        public void get_renderModelComponentName(){} // RVA: 0x64AB410
        public void get_localizedOriginName(){} // RVA: 0x64AB430
        public void get_changedTime(){} // RVA: 0x466280
        public void set_changedTime(){} // RVA: 0x4FDE90
        public void get_lastOriginGetFrame(){} // RVA: 0x4C6670
        public void set_lastOriginGetFrame(){} // RVA: 0x4C5F20
        public void UpdateValue(){} // RVA: 0x24A50
        public void Initialize(){} // RVA: 0x64AB450
        public void UpdateOriginTrackedDeviceInfo(){} // RVA: 0x64AB570
        public void GetLocalizedOriginPart(){} // RVA: 0x64AB9F0
        public void GetLocalizedOrigin(){} // RVA: 0x64ABAA0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0xE1F0
        public void OnAccessSource(){} // RVA: 0x24FA0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x24FA0
        public void UpdateValues(){} // RVA: 0x24A50
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In_Source_Map`1
    {
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x408D4B0
        public void OnAccessSource(){} // RVA: 0x408D560
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408D5F0
        public void UpdateValues(){} // RVA: 0x408D7A0
        public void .ctor(){} // RVA: 0x408D880
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0xDBE0
        public void get_lastChanged(){} // RVA: 0xDBE0
        public void get_changedTime(){} // RVA: 0x21890
        public void get_updateTime(){} // RVA: 0x21890
        public void get_activeOrigin(){} // RVA: 0xCD60
        public void get_lastActiveOrigin(){} // RVA: 0xCD60
        public void get_activeDevice(){} // RVA: 0xD840
        public void get_trackedDeviceIndex(){} // RVA: 0xD840
        public void get_renderModelComponentName(){} // RVA: 0xCD60
        public void get_localizedOriginName(){} // RVA: 0xCD60
        public void UpdateValues(){} // RVA: 0x24A50
        public void GetRenderModelComponentName(){} // RVA: 0x1BCC0
        public void GetActiveDevice(){} // RVA: 0x13FB0
        public void GetDeviceIndex(){} // RVA: 0x13FB0
        public void GetChanged(){} // RVA: 0xE1F0
        public void GetTimeLastChanged(){} // RVA: 0x21C40
        public void GetLocalizedOriginPart(){} // RVA: 0x1CEE0
        public void GetLocalizedOrigin(){} // RVA: 0x1BCC0
        public void IsUpdating(){} // RVA: 0xE1F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x24FA0
        public void GetControllerType(){} // RVA: 0x1BCC0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_In`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x408D960
        public void get_lastChanged(){} // RVA: 0x408D960
        public void get_changedTime(){} // RVA: 0x408D9B0
        public void get_updateTime(){} // RVA: 0x408D9F0
        public void get_activeOrigin(){} // RVA: 0x408DA30
        public void get_lastActiveOrigin(){} // RVA: 0x408DA80
        public void get_activeDevice(){} // RVA: 0x408DAD0
        public void get_trackedDeviceIndex(){} // RVA: 0x408DB60
        public void get_renderModelComponentName(){} // RVA: 0x408DBB0
        public void get_localizedOriginName(){} // RVA: 0x408DC00
        public void UpdateValues(){} // RVA: 0x408DC50
        public void GetRenderModelComponentName(){} // RVA: 0x408DD40
        public void GetActiveDevice(){} // RVA: 0x408DD90
        public void GetDeviceIndex(){} // RVA: 0x408DE20
        public void GetChanged(){} // RVA: 0x408DE70
        public void GetTimeLastChanged(){} // RVA: 0x408DEC0
        public void GetLocalizedOriginPart(){} // RVA: 0x408DF00
        public void GetLocalizedOrigin(){} // RVA: 0x408DF50
        public void IsUpdating(){} // RVA: 0x408DF90
        public void ForceAddSourceToUpdateList(){} // RVA: 0x408E050
        public void GetControllerType(){} // RVA: 0x408E080
        public void .ctor(){} // RVA: 0x408E120
    }

    public class SteamVR_Action_Out_Source : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x408E1A0
    }

    public class SteamVR_Action_Pose
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x64ABB90
        public void remove_onActiveChange(){} // RVA: 0x64ABC10
        public void add_onActiveBindingChange(){} // RVA: 0x64ABC90
        public void remove_onActiveBindingChange(){} // RVA: 0x64ABDD0
        public void add_onChange(){} // RVA: 0x64ABE50
        public void remove_onChange(){} // RVA: 0x64ABED0
        public void add_onUpdate(){} // RVA: 0x64ABF50
        public void remove_onUpdate(){} // RVA: 0x64ABFD0
        public void add_onTrackingChanged(){} // RVA: 0x64AC050
        public void remove_onTrackingChanged(){} // RVA: 0x64AC0D0
        public void add_onValidPoseChanged(){} // RVA: 0x64AC150
        public void remove_onValidPoseChanged(){} // RVA: 0x64AC1D0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x64AC250
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x64AC2D0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x64AC350
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x64AC3D0
        public void AddOnTrackingChanged(){} // RVA: 0x64AC450
        public void RemoveOnTrackingChanged(){} // RVA: 0x64AC4D0
        public void AddOnValidPoseChanged(){} // RVA: 0x64AC550
        public void RemoveOnValidPoseChanged(){} // RVA: 0x64AC5D0
        public void AddOnActiveChangeListener(){} // RVA: 0x64AC650
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64AC6D0
        public void AddOnChangeListener(){} // RVA: 0x64AC750
        public void RemoveOnChangeListener(){} // RVA: 0x64AC7D0
        public void AddOnUpdateListener(){} // RVA: 0x64AC850
        public void RemoveOnUpdateListener(){} // RVA: 0x64AC8D0
        public void RemoveAllListeners(){} // RVA: 0x64AC950
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64AC9D0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x64ACA10
        public void .ctor(){} // RVA: 0x64ACC20
    }

    public class SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x25E50
        public void get_localPosition(){} // RVA: 0xC770
        public void get_localRotation(){} // RVA: 0xC770
        public void get_trackingState(){} // RVA: 0xD840
        public void get_velocity(){} // RVA: 0xC770
        public void get_angularVelocity(){} // RVA: 0xC770
        public void get_poseIsValid(){} // RVA: 0xDBE0
        public void get_deviceIsConnected(){} // RVA: 0xDBE0
        public void get_lastLocalPosition(){} // RVA: 0xC770
        public void get_lastLocalRotation(){} // RVA: 0xC770
        public void get_lastTrackingState(){} // RVA: 0xD840
        public void get_lastVelocity(){} // RVA: 0xC770
        public void get_lastAngularVelocity(){} // RVA: 0xC770
        public void get_lastPoseIsValid(){} // RVA: 0xDBE0
        public void get_lastDeviceIsConnected(){} // RVA: 0xDBE0
        public void .ctor(){} // RVA: 0x24A50
        public void UpdateValues(){} // RVA: 0x25130
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x283FA0
        public void GetPoseAtTimeOffset(){} // RVA: 0x283FA0
        public void UpdateTransform(){} // RVA: 0x26C40
        public void GetLocalPosition(){} // RVA: 0xDAD0
        public void GetLocalRotation(){} // RVA: 0xDAD0
        public void GetVelocity(){} // RVA: 0xDAD0
        public void GetAngularVelocity(){} // RVA: 0xDAD0
        public void GetDeviceIsConnected(){} // RVA: 0xE1F0
        public void GetPoseIsValid(){} // RVA: 0xE1F0
        public void GetTrackingResult(){} // RVA: 0x13FB0
        public void GetLastLocalPosition(){} // RVA: 0xDAD0
        public void GetLastLocalRotation(){} // RVA: 0xDAD0
        public void GetLastVelocity(){} // RVA: 0xDAD0
        public void GetLastAngularVelocity(){} // RVA: 0xDAD0
        public void GetLastDeviceIsConnected(){} // RVA: 0xE1F0
        public void GetLastPoseIsValid(){} // RVA: 0xE1F0
        public void GetLastTrackingResult(){} // RVA: 0x13FB0
    }

    public class SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x408E220
        public void get_localPosition(){} // RVA: 0x408E3D0
        public void get_localRotation(){} // RVA: 0x408E420
        public void get_trackingState(){} // RVA: 0x408E470
        public void get_velocity(){} // RVA: 0x408E4B0
        public void get_angularVelocity(){} // RVA: 0x408E500
        public void get_poseIsValid(){} // RVA: 0x408E550
        public void get_deviceIsConnected(){} // RVA: 0x408E590
        public void get_lastLocalPosition(){} // RVA: 0x408E5D0
        public void get_lastLocalRotation(){} // RVA: 0x408E620
        public void get_lastTrackingState(){} // RVA: 0x408E670
        public void get_lastVelocity(){} // RVA: 0x408E6B0
        public void get_lastAngularVelocity(){} // RVA: 0x408E700
        public void get_lastPoseIsValid(){} // RVA: 0x408E750
        public void get_lastDeviceIsConnected(){} // RVA: 0x408E790
        public void .ctor(){} // RVA: 0x408E7D0
        public void UpdateValues(){} // RVA: 0x408E7F0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x408E820
        public void GetPoseAtTimeOffset(){} // RVA: 0x408E880
        public void UpdateTransform(){} // RVA: 0x408E900
        public void GetLocalPosition(){} // RVA: 0x408EA10
        public void GetLocalRotation(){} // RVA: 0x408EA70
        public void GetVelocity(){} // RVA: 0x408EAC0
        public void GetAngularVelocity(){} // RVA: 0x408EB20
        public void GetDeviceIsConnected(){} // RVA: 0x408EB80
        public void GetPoseIsValid(){} // RVA: 0x408EBC0
        public void GetTrackingResult(){} // RVA: 0x408EC00
        public void GetLastLocalPosition(){} // RVA: 0x408EC40
        public void GetLastLocalRotation(){} // RVA: 0x408ECA0
        public void GetLastVelocity(){} // RVA: 0x408ECF0
        public void GetLastAngularVelocity(){} // RVA: 0x408ED50
        public void GetLastDeviceIsConnected(){} // RVA: 0x408EDB0
        public void GetLastPoseIsValid(){} // RVA: 0x408EDF0
        public void GetLastTrackingResult(){} // RVA: 0x408EE30
    }

    public class SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x408E220
        public void get_localPosition(){} // RVA: 0x408E3D0
        public void get_localRotation(){} // RVA: 0x408E420
        public void get_trackingState(){} // RVA: 0x408E470
        public void get_velocity(){} // RVA: 0x408E4B0
        public void get_angularVelocity(){} // RVA: 0x408E500
        public void get_poseIsValid(){} // RVA: 0x408E550
        public void get_deviceIsConnected(){} // RVA: 0x408E590
        public void get_lastLocalPosition(){} // RVA: 0x408E5D0
        public void get_lastLocalRotation(){} // RVA: 0x408E620
        public void get_lastTrackingState(){} // RVA: 0x408E670
        public void get_lastVelocity(){} // RVA: 0x408E6B0
        public void get_lastAngularVelocity(){} // RVA: 0x408E700
        public void get_lastPoseIsValid(){} // RVA: 0x408E750
        public void get_lastDeviceIsConnected(){} // RVA: 0x408E790
        public void .ctor(){} // RVA: 0x408E7D0
        public void UpdateValues(){} // RVA: 0x408E7F0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x408E820
        public void GetPoseAtTimeOffset(){} // RVA: 0x408E880
        public void UpdateTransform(){} // RVA: 0x408E900
        public void GetLocalPosition(){} // RVA: 0x408EA10
        public void GetLocalRotation(){} // RVA: 0x408EA70
        public void GetVelocity(){} // RVA: 0x408EAC0
        public void GetAngularVelocity(){} // RVA: 0x408EB20
        public void GetDeviceIsConnected(){} // RVA: 0x408EB80
        public void GetPoseIsValid(){} // RVA: 0x408EBC0
        public void GetTrackingResult(){} // RVA: 0x408EC00
        public void GetLastLocalPosition(){} // RVA: 0x408EC40
        public void GetLastLocalRotation(){} // RVA: 0x408ECA0
        public void GetLastVelocity(){} // RVA: 0x408ECF0
        public void GetLastAngularVelocity(){} // RVA: 0x408ED50
        public void GetLastDeviceIsConnected(){} // RVA: 0x408EDB0
        public void GetLastPoseIsValid(){} // RVA: 0x408EDF0
        public void GetLastTrackingResult(){} // RVA: 0x408EE30
    }

    public class SteamVR_Action_Pose_Source
    {
        public 0x6595C340 universeOrigin; // 0x158
        public uint poseActionData_size;
        public float changeTolerance; // 0x15C
        public ActiveChangeHandler onActiveChange; // 0x160
        public ActiveChangeHandler onActiveBindingChange; // 0x168
        public ChangeHandler onChange; // 0x170
        public UpdateHandler onUpdate; // 0x178
        public TrackingChangeHandler onTrackingChanged; // 0x180
        public ValidPoseChangeHandler onValidPoseChanged; // 0x188
        public DeviceConnectedChangeHandler onDeviceConnectedChanged; // 0x190
        public bool <changed>k__BackingField; // 0x198
        public bool <lastChanged>k__BackingField; // 0x199
        public bool <lastActive>k__BackingField; // 0x19A
        public UnityEngine.Vector3 <localPosition>k__BackingField; // 0x19C
        public UnityEngine.Quaternion <localRotation>k__BackingField; // 0x1A8
        public UnityEngine.Vector3 <lastLocalPosition>k__BackingField; // 0x1B8
        public UnityEngine.Quaternion <lastLocalRotation>k__BackingField; // 0x1C4
        public UnityEngine.Vector3 <velocity>k__BackingField; // 0x1D4
        public UnityEngine.Vector3 <lastVelocity>k__BackingField; // 0x1E0
        public UnityEngine.Vector3 <angularVelocity>k__BackingField; // 0x1EC
        public UnityEngine.Vector3 <lastAngularVelocity>k__BackingField; // 0x1F8
        public Valve.VR.InputPoseActionData_t poseActionData; // 0x208

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x64AD050
        public void remove_onActiveChange(){} // RVA: 0x64AD140
        public void add_onActiveBindingChange(){} // RVA: 0x64AD230
        public void remove_onActiveBindingChange(){} // RVA: 0x64AD320
        public void add_onChange(){} // RVA: 0x64AD410
        public void remove_onChange(){} // RVA: 0x64AD500
        public void add_onUpdate(){} // RVA: 0x64AD5F0
        public void remove_onUpdate(){} // RVA: 0x64AD6E0
        public void add_onTrackingChanged(){} // RVA: 0x64AD7D0
        public void remove_onTrackingChanged(){} // RVA: 0x64AD8C0
        public void add_onValidPoseChanged(){} // RVA: 0x64AD9B0
        public void remove_onValidPoseChanged(){} // RVA: 0x64ADAA0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x64ADB90
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x64ADC80
        public void get_changed(){} // RVA: 0x63A7830
        public void set_changed(){} // RVA: 0x63A7840
        public void get_lastChanged(){} // RVA: 0x64ADD70
        public void set_lastChanged(){} // RVA: 0x64ADD80
        public void get_activeOrigin(){} // RVA: 0x64ADD90
        public void get_lastActiveOrigin(){} // RVA: 0xD97D00
        public void get_active(){} // RVA: 0x64AA590
        public void get_activeBinding(){} // RVA: 0x64ADDD0
        public void get_lastActive(){} // RVA: 0x64ADDE0
        public void set_lastActive(){} // RVA: 0x64ADDF0
        public void get_lastActiveBinding(){} // RVA: 0x63A8560
        public void get_trackingState(){} // RVA: 0x33D9C0
        public void get_lastTrackingState(){} // RVA: 0x637BC00
        public void get_poseIsValid(){} // RVA: 0x64ADE00
        public void get_lastPoseIsValid(){} // RVA: 0x64ADE10
        public void get_deviceIsConnected(){} // RVA: 0x64ADE20
        public void get_lastDeviceIsConnected(){} // RVA: 0x64ADE30
        public void get_localPosition(){} // RVA: 0x64ADE40
        public void set_localPosition(){} // RVA: 0x64ADE60
        public void get_localRotation(){} // RVA: 0x64ADE80
        public void set_localRotation(){} // RVA: 0x64ADE90
        public void get_lastLocalPosition(){} // RVA: 0x64ADEA0
        public void set_lastLocalPosition(){} // RVA: 0x64ADEC0
        public void get_lastLocalRotation(){} // RVA: 0x64ADEE0
        public void set_lastLocalRotation(){} // RVA: 0x64ADEF0
        public void get_velocity(){} // RVA: 0x64ADF00
        public void set_velocity(){} // RVA: 0x64ADF20
        public void get_lastVelocity(){} // RVA: 0x64ADF40
        public void set_lastVelocity(){} // RVA: 0x64ADF60
        public void get_angularVelocity(){} // RVA: 0x64ADF80
        public void set_angularVelocity(){} // RVA: 0x64ADFA0
        public void get_lastAngularVelocity(){} // RVA: 0x64ADFC0
        public void set_lastAngularVelocity(){} // RVA: 0x64ADFE0
        public void Preinitialize(){} // RVA: 0x64AE000
        public void Initialize(){} // RVA: 0x64AE150
        public void RemoveAllListeners(){} // RVA: 0x64AE260
        public void UpdateValue(){} // RVA: 0x64AE6B0 | overloaded x2
        public void SetCacheVariables(){} // RVA: 0x64AEE70
        public void GetChanged(){} // RVA: 0x64AEF90
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x64AF260
        public void GetPoseAtTimeOffset(){} // RVA: 0x64AF690
        public void UpdateTransform(){} // RVA: 0x64AFBB0
        public void CheckAndSendEvents(){} // RVA: 0x64AFC90
        public void GetUnityCoordinateVelocity(){} // RVA: 0x64AFF80 | overloaded x2
        public void GetUnityCoordinateAngularVelocity(){} // RVA: 0x64AFFA0 | overloaded x2
        public void .ctor(){} // RVA: 0x64AFFD0
        public void .cctor(){} // RVA: 0x64B0020
    }

    public class SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x24FA0
        public void UpdateValues(){} // RVA: 0x25130
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x408EE70
        public void UpdateValues(){} // RVA: 0x408EEE0
        public void .ctor(){} // RVA: 0x408EFD0
    }

    public class SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x408EE70
        public void UpdateValues(){} // RVA: 0x408EEE0
        public void .ctor(){} // RVA: 0x408EFD0
    }

    public class SteamVR_Action_Single
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x64B0080
        public void remove_onChange(){} // RVA: 0x64B0100
        public void add_onUpdate(){} // RVA: 0x64B0180
        public void remove_onUpdate(){} // RVA: 0x64B0200
        public void add_onAxis(){} // RVA: 0x64B0280
        public void remove_onAxis(){} // RVA: 0x64B0300
        public void add_onActiveChange(){} // RVA: 0x64B0380
        public void remove_onActiveChange(){} // RVA: 0x64B0400
        public void add_onActiveBindingChange(){} // RVA: 0x64B0480
        public void remove_onActiveBindingChange(){} // RVA: 0x64B0500
        public void get_axis(){} // RVA: 0x64B0580
        public void get_lastAxis(){} // RVA: 0x64B0610
        public void get_delta(){} // RVA: 0x64B06A0
        public void get_lastDelta(){} // RVA: 0x64B0730
        public void .ctor(){} // RVA: 0x64B07C0
        public void GetAxis(){} // RVA: 0x64B0800
        public void GetAxisDelta(){} // RVA: 0x64B08A0
        public void GetLastAxis(){} // RVA: 0x64B0940
        public void GetLastAxisDelta(){} // RVA: 0x64B09E0
        public void AddOnActiveChangeListener(){} // RVA: 0x64B0A80
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64B0B00
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x64B0B80
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x64B0C00
        public void AddOnChangeListener(){} // RVA: 0x64B0C80
        public void RemoveOnChangeListener(){} // RVA: 0x64B0D00
        public void AddOnUpdateListener(){} // RVA: 0x64B0D80
        public void RemoveOnUpdateListener(){} // RVA: 0x64B0E00
        public void AddOnAxisListener(){} // RVA: 0x64B0E80
        public void RemoveOnAxisListener(){} // RVA: 0x64B0F00
        public void RemoveAllListeners(){} // RVA: 0x64B0F80
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64B0FF0
    }

    public class SteamVR_Action_Single_Source
    {
        public uint actionData_size;
        public float changeTolerance; // 0x158
        public AxisHandler onAxis; // 0x160
        public ActiveChangeHandler onActiveChange; // 0x168
        public ActiveChangeHandler onActiveBindingChange; // 0x170
        public ChangeHandler onChange; // 0x178
        public UpdateHandler onUpdate; // 0x180
        public bool <changed>k__BackingField; // 0x188
        public bool <lastChanged>k__BackingField; // 0x189
        public bool <lastActive>k__BackingField; // 0x18A
        public Valve.VR.InputAnalogActionData_t actionData; // 0x190
        public Valve.VR.InputAnalogActionData_t lastActionData; // 0x1C0

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x64B1390
        public void remove_onAxis(){} // RVA: 0x64B1480
        public void add_onActiveChange(){} // RVA: 0x64B1570
        public void remove_onActiveChange(){} // RVA: 0x64B1660
        public void add_onActiveBindingChange(){} // RVA: 0x64B1750
        public void remove_onActiveBindingChange(){} // RVA: 0x64B1840
        public void add_onChange(){} // RVA: 0x64B1930
        public void remove_onChange(){} // RVA: 0x64B1A20
        public void add_onUpdate(){} // RVA: 0x64B1B10
        public void remove_onUpdate(){} // RVA: 0x64B1C00
        public void get_axis(){} // RVA: 0x64B1CF0
        public void get_lastAxis(){} // RVA: 0x64B1D30
        public void get_delta(){} // RVA: 0x64B1D70
        public void get_lastDelta(){} // RVA: 0x64B1DB0
        public void get_changed(){} // RVA: 0x64B1DF0
        public void set_changed(){} // RVA: 0x64B1E00
        public void get_lastChanged(){} // RVA: 0x64B1E10
        public void set_lastChanged(){} // RVA: 0x64B1E20
        public void get_activeOrigin(){} // RVA: 0x64B1E30
        public void get_lastActiveOrigin(){} // RVA: 0xDA62D0
        public void get_active(){} // RVA: 0x64AA590
        public void get_activeBinding(){} // RVA: 0x64AA630
        public void get_lastActive(){} // RVA: 0x64B1E70
        public void set_lastActive(){} // RVA: 0x64B1E80
        public void get_lastActiveBinding(){} // RVA: 0x64AA4F0
        public void Preinitialize(){} // RVA: 0x64B1E90
        public void Initialize(){} // RVA: 0x64B2020
        public void RemoveAllListeners(){} // RVA: 0x64B2100
        public void UpdateValue(){} // RVA: 0x64B2400
        public void .ctor(){} // RVA: 0x64B2C00
    }

    public class SteamVR_Action_Single_Source_Map
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64B1350
    }

    public class SteamVR_Action_Skeleton
    {
        public int numBones;
        public UnityEngine.Quaternion steamVRFixUpRotation;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x64B2C50
        public void remove_onActiveChange(){} // RVA: 0x64B2CD0
        public void add_onActiveBindingChange(){} // RVA: 0x64B2D50
        public void remove_onActiveBindingChange(){} // RVA: 0x64B2E90
        public void add_onChange(){} // RVA: 0x64B2F10
        public void remove_onChange(){} // RVA: 0x64B2F90
        public void add_onUpdate(){} // RVA: 0x64B3010
        public void remove_onUpdate(){} // RVA: 0x64B3090
        public void add_onTrackingChanged(){} // RVA: 0x64B3110
        public void remove_onTrackingChanged(){} // RVA: 0x64B3190
        public void add_onValidPoseChanged(){} // RVA: 0x64B3210
        public void remove_onValidPoseChanged(){} // RVA: 0x64B3290
        public void add_onDeviceConnectedChanged(){} // RVA: 0x64B3310
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x64B3390
        public void .ctor(){} // RVA: 0x64B3410
        public void UpdateValue(){} // RVA: 0x64B3460
        public void UpdateValueWithoutEvents(){} // RVA: 0x64B34E0
        public void UpdateTransform(){} // RVA: 0x64B3560
        public void get_bonePositions(){} // RVA: 0x64B3690
        public void get_boneRotations(){} // RVA: 0x64B36F0
        public void get_lastBonePositions(){} // RVA: 0x64B3750
        public void get_lastBoneRotations(){} // RVA: 0x64B37B0
        public void get_rangeOfMotion(){} // RVA: 0x64B3810
        public void set_rangeOfMotion(){} // RVA: 0x64B3870
        public void get_skeletalTransformSpace(){} // RVA: 0x64B38E0
        public void set_skeletalTransformSpace(){} // RVA: 0x64B3940
        public void get_summaryDataType(){} // RVA: 0x64B39B0
        public void set_summaryDataType(){} // RVA: 0x64B3A10
        public void get_skeletalTrackingLevel(){} // RVA: 0x64B3A80
        public void get_thumbCurl(){} // RVA: 0x64B3AF0
        public void get_indexCurl(){} // RVA: 0x64B3B70
        public void get_middleCurl(){} // RVA: 0x64B3BF0
        public void get_ringCurl(){} // RVA: 0x64B3C70
        public void get_pinkyCurl(){} // RVA: 0x64B3CF0
        public void get_thumbIndexSplay(){} // RVA: 0x64B3D70
        public void get_indexMiddleSplay(){} // RVA: 0x64B3DF0
        public void get_middleRingSplay(){} // RVA: 0x64B3E70
        public void get_ringPinkySplay(){} // RVA: 0x64B3EF0
        public void get_lastThumbCurl(){} // RVA: 0x64B3F70
        public void get_lastIndexCurl(){} // RVA: 0x64B3FF0
        public void get_lastMiddleCurl(){} // RVA: 0x64B4070
        public void get_lastRingCurl(){} // RVA: 0x64B40F0
        public void get_lastPinkyCurl(){} // RVA: 0x64B4170
        public void get_lastThumbIndexSplay(){} // RVA: 0x64B41F0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x64B4270
        public void get_lastMiddleRingSplay(){} // RVA: 0x64B42F0
        public void get_lastRingPinkySplay(){} // RVA: 0x64B4370
        public void get_fingerCurls(){} // RVA: 0x64B43F0
        public void get_fingerSplays(){} // RVA: 0x64B4450
        public void get_lastFingerCurls(){} // RVA: 0x64B44B0
        public void get_lastFingerSplays(){} // RVA: 0x64B4510
        public void get_poseChanged(){} // RVA: 0x64B4570
        public void get_onlyUpdateSummaryData(){} // RVA: 0x64B45D0
        public void set_onlyUpdateSummaryData(){} // RVA: 0x64B4630
        public void GetActive(){} // RVA: 0x64B46A0
        public void GetSetActive(){} // RVA: 0x64A36B0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x64B4710
        public void GetPoseAtTimeOffset(){} // RVA: 0x64B47B0
        public void GetLocalPosition(){} // RVA: 0x64B4850
        public void GetLocalRotation(){} // RVA: 0x64B48D0
        public void GetVelocity(){} // RVA: 0x64B4950
        public void GetAngularVelocity(){} // RVA: 0x64B49D0
        public void GetDeviceIsConnected(){} // RVA: 0x64B4A50
        public void GetPoseIsValid(){} // RVA: 0x64B4AB0
        public void GetTrackingResult(){} // RVA: 0x64B4B10
        public void GetLastLocalPosition(){} // RVA: 0x64B4B70
        public void GetLastLocalRotation(){} // RVA: 0x64B4BF0
        public void GetLastVelocity(){} // RVA: 0x64B4C70
        public void GetLastAngularVelocity(){} // RVA: 0x64B4CF0
        public void GetLastDeviceIsConnected(){} // RVA: 0x64B4D70
        public void GetLastPoseIsValid(){} // RVA: 0x64B4DD0
        public void GetLastTrackingResult(){} // RVA: 0x64B4E30
        public void get_boneCount(){} // RVA: 0x64B4E90
        public void GetBonePositions(){} // RVA: 0x64B4F00
        public void GetBoneRotations(){} // RVA: 0x64B4FF0
        public void GetLastBonePositions(){} // RVA: 0x64B50E0
        public void GetLastBoneRotations(){} // RVA: 0x64B51D0
        public void SetRangeOfMotion(){} // RVA: 0x64B52C0
        public void SetSkeletalTransformSpace(){} // RVA: 0x64B5330
        public void GetBoneCount(){} // RVA: 0x64B4E90
        public void GetBoneHierarchy(){} // RVA: 0x64B53A0
        public void GetBoneName(){} // RVA: 0x64B5410
        public void GetReferenceTransforms(){} // RVA: 0x64B5480
        public void GetSkeletalTrackingLevel(){} // RVA: 0x64B5500
        public void GetFingerCurls(){} // RVA: 0x64B5570
        public void GetLastFingerCurls(){} // RVA: 0x64B5660
        public void GetFingerSplays(){} // RVA: 0x64B5750
        public void GetLastFingerSplays(){} // RVA: 0x64B5840
        public void GetFingerCurl(){} // RVA: 0x64B5930 | overloaded x2
        public void GetSplay(){} // RVA: 0x64B59C0 | overloaded x2
        public void GetLastFingerCurl(){} // RVA: 0x64B5A50 | overloaded x2
        public void GetLastSplay(){} // RVA: 0x64B5AE0 | overloaded x2
        public void GetLocalizedName(){} // RVA: 0x64B5B70
        public void RemoveAllListeners(){} // RVA: 0x64B5BF0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x64B5C70
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x64B5CF0
        public void AddOnTrackingChanged(){} // RVA: 0x64B5D70
        public void RemoveOnTrackingChanged(){} // RVA: 0x64B5DF0
        public void AddOnValidPoseChanged(){} // RVA: 0x64B5E70
        public void RemoveOnValidPoseChanged(){} // RVA: 0x64B5EF0
        public void AddOnActiveChangeListener(){} // RVA: 0x64B5F70
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64B5FF0
        public void AddOnChangeListener(){} // RVA: 0x64B6070
        public void RemoveOnChangeListener(){} // RVA: 0x64B60F0
        public void AddOnUpdateListener(){} // RVA: 0x64B6170
        public void RemoveOnUpdateListener(){} // RVA: 0x64B61F0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64B6270
        public void .cctor(){} // RVA: 0x64B62B0
    }

    public class SteamVR_Action_Skeleton_Source
    {
        public uint skeletonActionData_size;
        public ActiveChangeHandler onActiveChange; // 0x330
        public ActiveChangeHandler onActiveBindingChange; // 0x338
        public ChangeHandler onChange; // 0x340
        public UpdateHandler onUpdate; // 0x348
        public TrackingChangeHandler onTrackingChanged; // 0x350
        public ValidPoseChangeHandler onValidPoseChanged; // 0x358
        public DeviceConnectedChangeHandler onDeviceConnectedChanged; // 0x360
        public UnityEngine.Vector3[] <bonePositions>k__BackingField; // 0x368
        public UnityEngine.Quaternion[] <boneRotations>k__BackingField; // 0x370
        public UnityEngine.Vector3[] <lastBonePositions>k__BackingField; // 0x378
        public UnityEngine.Quaternion[] <lastBoneRotations>k__BackingField; // 0x380
        public 0x6595CB80 <rangeOfMotion>k__BackingField; // 0x388
        public 0x6595D7E0 <skeletalTransformSpace>k__BackingField; // 0x38C
        public 0x6595D940 <summaryDataType>k__BackingField; // 0x390
        public float[] <fingerCurls>k__BackingField; // 0x398
        public float[] <fingerSplays>k__BackingField; // 0x3A0
        public float[] <lastFingerCurls>k__BackingField; // 0x3A8
        public float[] <lastFingerSplays>k__BackingField; // 0x3B0
        public bool <poseChanged>k__BackingField; // 0x3B8
        public bool <onlyUpdateSummaryData>k__BackingField; // 0x3B9
        public Valve.VR.VRSkeletalSummaryData_t skeletalSummaryData; // 0x3BC
        public Valve.VR.VRSkeletalSummaryData_t lastSkeletalSummaryData; // 0x3E0
        public Valve.VR.SteamVR_Action_Skeleton skeletonAction; // 0x408
        public Valve.VR.VRBoneTransform_t[] tempBoneTransforms; // 0x410
        public Valve.VR.InputSkeletalActionData_t skeletonActionData; // 0x418
        public Valve.VR.InputSkeletalActionData_t lastSkeletonActionData; // 0x428
        public Valve.VR.InputSkeletalActionData_t tempSkeletonActionData; // 0x438

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x64B6650
        public void remove_onActiveChange(){} // RVA: 0x64B6740
        public void add_onActiveBindingChange(){} // RVA: 0x64B6830
        public void remove_onActiveBindingChange(){} // RVA: 0x64B6920
        public void add_onChange(){} // RVA: 0x64B6A10
        public void remove_onChange(){} // RVA: 0x64B6B00
        public void add_onUpdate(){} // RVA: 0x64B6BF0
        public void remove_onUpdate(){} // RVA: 0x64B6CE0
        public void add_onTrackingChanged(){} // RVA: 0x64B6DD0
        public void remove_onTrackingChanged(){} // RVA: 0x64B6EC0
        public void add_onValidPoseChanged(){} // RVA: 0x64B6FB0
        public void remove_onValidPoseChanged(){} // RVA: 0x64B70A0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x64B7190
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x64B7280
        public void get_activeBinding(){} // RVA: 0x55C21D0
        public void get_lastActiveBinding(){} // RVA: 0x64B7370
        public void get_bonePositions(){} // RVA: 0xDB5260
        public void set_bonePositions(){} // RVA: 0xDA3EB0
        public void get_boneRotations(){} // RVA: 0xDB4600
        public void set_boneRotations(){} // RVA: 0xD935F0
        public void get_lastBonePositions(){} // RVA: 0xDA44B0
        public void set_lastBonePositions(){} // RVA: 0xD92A30
        public void get_lastBoneRotations(){} // RVA: 0xD9D760
        public void set_lastBoneRotations(){} // RVA: 0xD9C300
        public void get_rangeOfMotion(){} // RVA: 0x64B7380
        public void set_rangeOfMotion(){} // RVA: 0x64B7390
        public void get_skeletalTransformSpace(){} // RVA: 0x40CB160
        public void set_skeletalTransformSpace(){} // RVA: 0x40CB170
        public void get_summaryDataType(){} // RVA: 0x40CB100
        public void set_summaryDataType(){} // RVA: 0x64B73A0
        public void get_thumbCurl(){} // RVA: 0x64B73B0
        public void get_indexCurl(){} // RVA: 0x64B73E0
        public void get_middleCurl(){} // RVA: 0x64B7410
        public void get_ringCurl(){} // RVA: 0x64B7440
        public void get_pinkyCurl(){} // RVA: 0x64B7470
        public void get_thumbIndexSplay(){} // RVA: 0x64B74A0
        public void get_indexMiddleSplay(){} // RVA: 0x64B74D0
        public void get_middleRingSplay(){} // RVA: 0x64B7500
        public void get_ringPinkySplay(){} // RVA: 0x64B7530
        public void get_lastThumbCurl(){} // RVA: 0x64B7560
        public void get_lastIndexCurl(){} // RVA: 0x64B7590
        public void get_lastMiddleCurl(){} // RVA: 0x64B75C0
        public void get_lastRingCurl(){} // RVA: 0x64B75F0
        public void get_lastPinkyCurl(){} // RVA: 0x64B7620
        public void get_lastThumbIndexSplay(){} // RVA: 0x64B7650
        public void get_lastIndexMiddleSplay(){} // RVA: 0x64B7680
        public void get_lastMiddleRingSplay(){} // RVA: 0x64B76B0
        public void get_lastRingPinkySplay(){} // RVA: 0x64B76E0
        public void get_fingerCurls(){} // RVA: 0xDA8A90
        public void set_fingerCurls(){} // RVA: 0xDB2B50
        public void get_fingerSplays(){} // RVA: 0xD8F130
        public void set_fingerSplays(){} // RVA: 0xD9C3C0
        public void get_lastFingerCurls(){} // RVA: 0xD8C7B0
        public void set_lastFingerCurls(){} // RVA: 0xD9F7D0
        public void get_lastFingerSplays(){} // RVA: 0x8B9050
        public void set_lastFingerSplays(){} // RVA: 0xDA2640
        public void get_poseChanged(){} // RVA: 0x64B7710
        public void set_poseChanged(){} // RVA: 0x64B7720
        public void get_onlyUpdateSummaryData(){} // RVA: 0x64B7730
        public void set_onlyUpdateSummaryData(){} // RVA: 0x64B7740
        public void Preinitialize(){} // RVA: 0x64B7750
        public void Initialize(){} // RVA: 0x64B7E20
        public void RemoveAllListeners(){} // RVA: 0x64B7FF0
        public void UpdateValue(){} // RVA: 0x64B8420 | overloaded x2
        public void get_boneCount(){} // RVA: 0x64B9370
        public void GetBoneCount(){} // RVA: 0x64B9380
        public void get_boneHierarchy(){} // RVA: 0x64B9640
        public void GetBoneHierarchy(){} // RVA: 0x64B9650
        public void GetBoneName(){} // RVA: 0x64B9950
        public void GetReferenceTransforms(){} // RVA: 0x64B9CB0
        public void get_skeletalTrackingLevel(){} // RVA: 0x64BA310
        public void GetSkeletalTrackingLevel(){} // RVA: 0x64BA320
        public void GetSkeletalSummaryData(){} // RVA: 0x64BA570
        public void UpdateSkeletalSummaryData(){} // RVA: 0x64BA5D0
        public void CheckAndSendEvents(){} // RVA: 0x64BA980
        public void .ctor(){} // RVA: 0x64BABC0
    }

    public class SteamVR_Action_Skeleton_Source_Map
    {
        // ── Methods ──
        public void GetSourceElementForIndexer(){} // RVA: 0x64B65D0
        public void .ctor(){} // RVA: 0x64B6600
    }

    public class SteamVR_Action_Source
    {
        public 0x65925E40 <inputSource>k__BackingField; // 0x10
        public ulong inputSourceHandle; // 0x18
        public Valve.VR.SteamVR_Action action; // 0x20

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x64A4880
        public void get_handle(){} // RVA: 0x64A48B0
        public void get_actionSet(){} // RVA: 0x64A48E0
        public void get_direction(){} // RVA: 0x64A4910
        public void get_inputSource(){} // RVA: 0x32A5C0
        public void set_inputSource(){} // RVA: 0x2E00C0
        public void get_setActive(){} // RVA: 0x64A4940
        public void get_active(){} // RVA: 0xDBE0
        public void get_activeBinding(){} // RVA: 0xDBE0
        public void get_lastActive(){} // RVA: 0xDBE0
        public void set_lastActive(){} // RVA: 0x25130
        public void get_lastActiveBinding(){} // RVA: 0xDBE0
        public void Preinitialize(){} // RVA: 0x64A49D0
        public void .ctor(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x64A4A30
    }

    public class SteamVR_Action_Source_Map
    {
        public string <fullPath>k__BackingField; // 0x10
        public ulong <handle>k__BackingField; // 0x18
        public Valve.VR.SteamVR_ActionSet <actionSet>k__BackingField; // 0x20
        public 0x659229A8 <direction>k__BackingField; // 0x28

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x2F8380
        public void set_fullPath(){} // RVA: 0x2DEE30
        public void get_handle(){} // RVA: 0x2E07C0
        public void set_handle(){} // RVA: 0xC5BE60
        public void get_actionSet(){} // RVA: 0x30B0C0
        public void set_actionSet(){} // RVA: 0x30B0D0
        public void get_direction(){} // RVA: 0x791DC0
        public void set_direction(){} // RVA: 0xA53440
        public void PreInitialize(){} // RVA: 0x64A3E90
        public void PreinitializeMap(){} // RVA: 0x26C40
        public void Initialize(){} // RVA: 0x64A40E0
        public void GetActionSetPath(){} // RVA: 0x64A42D0
        public void GetActionDirection(){} // RVA: 0x64A4350
        public void .ctor(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x64A4560
    }

    public class SteamVR_Action_Source_Map`1
    {
        public T[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public T[] sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x283FA0
        public void OnAccessSource(){} // RVA: 0x24FA0
        public void Initialize(){} // RVA: 0x24A50
        public void PreinitializeMap(){} // RVA: 0x26C40
        public void GetSourceElementForIndexer(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x24A50
    }

    public class SteamVR_Action_Source_Map`1
    {
        public T[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Vibration_Source[] sources; // 0x38
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Vibration_Source[] sources; // 0x38
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Skeleton_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Single_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Pose_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Boolean_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Vector2_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Vector3_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Source_Map`1
    {
        public Valve.VR.SteamVR_Action_Vibration_Source[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408EFF0
        public void OnAccessSource(){} // RVA: 0x2DD310
        public void Initialize(){} // RVA: 0x408F010
        public void PreinitializeMap(){} // RVA: 0x408F0A0
        public void GetSourceElementForIndexer(){} // RVA: 0x408F140
        public void .ctor(){} // RVA: 0x408F190
    }

    public class SteamVR_Action_Vector2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x64BB260
        public void remove_onChange(){} // RVA: 0x64BB2E0
        public void add_onUpdate(){} // RVA: 0x64BB360
        public void remove_onUpdate(){} // RVA: 0x64BB3E0
        public void add_onAxis(){} // RVA: 0x64BB460
        public void remove_onAxis(){} // RVA: 0x64BB4E0
        public void add_onActiveChange(){} // RVA: 0x64BB560
        public void remove_onActiveChange(){} // RVA: 0x64BB5E0
        public void add_onActiveBindingChange(){} // RVA: 0x64BB660
        public void remove_onActiveBindingChange(){} // RVA: 0x64BB6E0
        public void get_axis(){} // RVA: 0x64BB760
        public void get_lastAxis(){} // RVA: 0x64BB7E0
        public void get_delta(){} // RVA: 0x64BB860
        public void get_lastDelta(){} // RVA: 0x64BB8E0
        public void .ctor(){} // RVA: 0x64BB960
        public void GetAxis(){} // RVA: 0x64BB9A0
        public void GetAxisDelta(){} // RVA: 0x64BBA20
        public void GetLastAxis(){} // RVA: 0x64BBAA0
        public void GetLastAxisDelta(){} // RVA: 0x64BBB20
        public void AddOnActiveChangeListener(){} // RVA: 0x64BBBA0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64BBC20
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x64BBCA0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x64BBD20
        public void AddOnChangeListener(){} // RVA: 0x64BBDA0
        public void RemoveOnChangeListener(){} // RVA: 0x64BBE20
        public void AddOnUpdateListener(){} // RVA: 0x64BBEA0
        public void RemoveOnUpdateListener(){} // RVA: 0x64BBF20
        public void AddOnAxisListener(){} // RVA: 0x64BBFA0
        public void RemoveOnAxisListener(){} // RVA: 0x64BC020
        public void RemoveAllListeners(){} // RVA: 0x64BC0A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64BC110
    }

    public class SteamVR_Action_Vector2_Source
    {
        public uint actionData_size;
        public float changeTolerance; // 0x158
        public AxisHandler onAxis; // 0x160
        public ActiveChangeHandler onActiveChange; // 0x168
        public ActiveChangeHandler onActiveBindingChange; // 0x170
        public ChangeHandler onChange; // 0x178
        public UpdateHandler onUpdate; // 0x180
        public UnityEngine.Vector2 <axis>k__BackingField; // 0x188
        public UnityEngine.Vector2 <lastAxis>k__BackingField; // 0x190
        public UnityEngine.Vector2 <delta>k__BackingField; // 0x198
        public UnityEngine.Vector2 <lastDelta>k__BackingField; // 0x1A0
        public bool <changed>k__BackingField; // 0x1A8

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x64D1FE0
        public void remove_onAxis(){} // RVA: 0x64D20D0
        public void add_onActiveChange(){} // RVA: 0x64D21C0
        public void remove_onActiveChange(){} // RVA: 0x64D22B0
        public void add_onActiveBindingChange(){} // RVA: 0x64D23A0
        public void remove_onActiveBindingChange(){} // RVA: 0x64D2490
        public void add_onChange(){} // RVA: 0x64D2580
        public void remove_onChange(){} // RVA: 0x64D2670
        public void add_onUpdate(){} // RVA: 0x64D2760
        public void remove_onUpdate(){} // RVA: 0x64D2850
        public void get_axis(){} // RVA: 0x14E7440
        public void set_axis(){} // RVA: 0x64D2940
        public void get_lastAxis(){} // RVA: 0x64D2950
        public void set_lastAxis(){} // RVA: 0x64D2970
        public void get_delta(){} // RVA: 0x64D2980
        public void set_delta(){} // RVA: 0x64D29A0
        public void get_lastDelta(){} // RVA: 0x64D29B0
        public void set_lastDelta(){} // RVA: 0x64D29D0
        public void get_changed(){} // RVA: 0x64D29E0
        public void set_changed(){} // RVA: 0x64D29F0
        public void get_lastChanged(){} // RVA: 0x64D2A00
        public void set_lastChanged(){} // RVA: 0x64D2A10
        public void get_activeOrigin(){} // RVA: 0x64D2A20
        public void get_lastActiveOrigin(){} // RVA: 0xDB4D60
        public void get_active(){} // RVA: 0x64AA590
        public void get_activeBinding(){} // RVA: 0x64AA650
        public void get_lastActive(){} // RVA: 0x64D2A60
        public void set_lastActive(){} // RVA: 0x64D2A70
        public void get_lastActiveBinding(){} // RVA: 0x64D2A80
        public void Preinitialize(){} // RVA: 0x64D2A90
        public void Initialize(){} // RVA: 0x64D2C20
        public void RemoveAllListeners(){} // RVA: 0x64D2D00
        public void UpdateValue(){} // RVA: 0x64D3000
        public void .ctor(){} // RVA: 0x64D37F0
    }

    public class SteamVR_Action_Vector2_Source_Map
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64D1FA0
    }

    public class SteamVR_Action_Vector3
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x64D3840
        public void remove_onChange(){} // RVA: 0x64D38C0
        public void add_onUpdate(){} // RVA: 0x64D3940
        public void remove_onUpdate(){} // RVA: 0x64D39C0
        public void add_onAxis(){} // RVA: 0x64D3A40
        public void remove_onAxis(){} // RVA: 0x64D3AC0
        public void add_onActiveChange(){} // RVA: 0x64D3B40
        public void remove_onActiveChange(){} // RVA: 0x64D3BC0
        public void add_onActiveBindingChange(){} // RVA: 0x64D3C40
        public void remove_onActiveBindingChange(){} // RVA: 0x64D3CC0
        public void get_axis(){} // RVA: 0x64D3D40
        public void get_lastAxis(){} // RVA: 0x64D3DC0
        public void get_delta(){} // RVA: 0x64D3E40
        public void get_lastDelta(){} // RVA: 0x64D3EC0
        public void .ctor(){} // RVA: 0x64D3F40
        public void GetAxis(){} // RVA: 0x64D3F80
        public void GetAxisDelta(){} // RVA: 0x64D4010
        public void GetLastAxis(){} // RVA: 0x64D40A0
        public void GetLastAxisDelta(){} // RVA: 0x64D4130
        public void AddOnActiveChangeListener(){} // RVA: 0x64D41C0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64D4240
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x64D42C0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x64D4340
        public void AddOnChangeListener(){} // RVA: 0x64D43C0
        public void RemoveOnChangeListener(){} // RVA: 0x64D4440
        public void AddOnUpdateListener(){} // RVA: 0x64D44C0
        public void RemoveOnUpdateListener(){} // RVA: 0x64D4540
        public void AddOnAxisListener(){} // RVA: 0x64D45C0
        public void RemoveOnAxisListener(){} // RVA: 0x64D4640
        public void RemoveAllListeners(){} // RVA: 0x64D46C0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64D4730
    }

    public class SteamVR_Action_Vector3_Source
    {
        public uint actionData_size;
        public float changeTolerance; // 0x158
        public AxisHandler onAxis; // 0x160
        public ActiveChangeHandler onActiveChange; // 0x168
        public ActiveChangeHandler onActiveBindingChange; // 0x170
        public ChangeHandler onChange; // 0x178
        public UpdateHandler onUpdate; // 0x180
        public UnityEngine.Vector3 <axis>k__BackingField; // 0x188
        public UnityEngine.Vector3 <lastAxis>k__BackingField; // 0x194
        public UnityEngine.Vector3 <delta>k__BackingField; // 0x1A0
        public UnityEngine.Vector3 <lastDelta>k__BackingField; // 0x1AC
        public bool <changed>k__BackingField; // 0x1B8

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x64D4AD0
        public void remove_onAxis(){} // RVA: 0x64D4BC0
        public void add_onActiveChange(){} // RVA: 0x64D4CB0
        public void remove_onActiveChange(){} // RVA: 0x64D4DA0
        public void add_onActiveBindingChange(){} // RVA: 0x64D4E90
        public void remove_onActiveBindingChange(){} // RVA: 0x64D4F80
        public void add_onChange(){} // RVA: 0x64D5070
        public void remove_onChange(){} // RVA: 0x64D5160
        public void add_onUpdate(){} // RVA: 0x64D5250
        public void remove_onUpdate(){} // RVA: 0x64D5340
        public void get_axis(){} // RVA: 0x64D5430
        public void set_axis(){} // RVA: 0x64D5450
        public void get_lastAxis(){} // RVA: 0x64D5470
        public void set_lastAxis(){} // RVA: 0x64D5490
        public void get_delta(){} // RVA: 0x64D54B0
        public void set_delta(){} // RVA: 0x64D54D0
        public void get_lastDelta(){} // RVA: 0x64D54F0
        public void set_lastDelta(){} // RVA: 0x64D5510
        public void get_changed(){} // RVA: 0x63A7A90
        public void set_changed(){} // RVA: 0x63A7AA0
        public void get_lastChanged(){} // RVA: 0x64D5530
        public void set_lastChanged(){} // RVA: 0x64D5540
        public void get_activeOrigin(){} // RVA: 0x64D5550
        public void get_lastActiveOrigin(){} // RVA: 0xD8D540
        public void get_active(){} // RVA: 0x64AA590
        public void get_activeBinding(){} // RVA: 0x64AA4F0
        public void get_lastActive(){} // RVA: 0x64D5590
        public void set_lastActive(){} // RVA: 0x64D55A0
        public void get_lastActiveBinding(){} // RVA: 0x64D55B0
        public void Preinitialize(){} // RVA: 0x64D55C0
        public void Initialize(){} // RVA: 0x64D5750
        public void RemoveAllListeners(){} // RVA: 0x64D5830
        public void UpdateValue(){} // RVA: 0x64D5B30
        public void .ctor(){} // RVA: 0x64D6360
    }

    public class SteamVR_Action_Vector3_Source_Map
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64D4A90
    }

    public class SteamVR_Action_Vibration
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x64D63B0
        public void remove_onActiveChange(){} // RVA: 0x64D6430
        public void add_onActiveBindingChange(){} // RVA: 0x64D64B0
        public void remove_onActiveBindingChange(){} // RVA: 0x64D6530
        public void add_onExecute(){} // RVA: 0x64D65B0
        public void remove_onExecute(){} // RVA: 0x64D6630
        public void .ctor(){} // RVA: 0x64D66B0
        public void Execute(){} // RVA: 0x64D6750
        public void AddOnActiveChangeListener(){} // RVA: 0x64D6800
        public void RemoveOnActiveChangeListener(){} // RVA: 0x64D6880
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x64D6900
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x64D6980
        public void AddOnExecuteListener(){} // RVA: 0x64D6A00
        public void RemoveOnExecuteListener(){} // RVA: 0x64D6A80
        public void RemoveAllListeners(){} // RVA: 0x64D6B00
        public void GetTimeLastChanged(){} // RVA: 0x64D6B70
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x2DD310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x64D6BE0
        public void IsUpdating(){} // RVA: 0x64D6C20
    }

    public class SteamVR_Action_Vibration_Source
    {
        public ActiveChangeHandler onActiveChange; // 0x28
        public ActiveChangeHandler onActiveBindingChange; // 0x30
        public ExecuteHandler onExecute; // 0x38
        public bool <lastActive>k__BackingField; // 0x40
        public float <timeLastExecuted>k__BackingField; // 0x44

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x64D7040
        public void remove_onActiveChange(){} // RVA: 0x64D7130
        public void add_onActiveBindingChange(){} // RVA: 0x64D7220
        public void remove_onActiveBindingChange(){} // RVA: 0x64D7310
        public void add_onExecute(){} // RVA: 0x64D7400
        public void remove_onExecute(){} // RVA: 0x64D74F0
        public void get_active(){} // RVA: 0x64AA590
        public void get_activeBinding(){} // RVA: 0x3C2850
        public void get_lastActive(){} // RVA: 0x398C00
        public void set_lastActive(){} // RVA: 0x398C10
        public void get_lastActiveBinding(){} // RVA: 0x3C2850
        public void get_timeLastExecuted(){} // RVA: 0x2E5970
        public void set_timeLastExecuted(){} // RVA: 0x2E5980
        public void Initialize(){} // RVA: 0x64D75E0
        public void Preinitialize(){} // RVA: 0x64D7660
        public void RemoveAllListeners(){} // RVA: 0x64D77E0
        public void Execute(){} // RVA: 0x64D79A0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_Action_Vibration_Source_Map
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x64D6FB0
        public void .ctor(){} // RVA: 0x64D7000
    }

    public class SteamVR_Action`2
    {
        public T sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public T sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public T sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public T sourceMap;
        public bool initialized;
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x283FA0
        public void get_fullPath(){} // RVA: 0xCD60
        public void get_handle(){} // RVA: 0xCD60
        public void get_actionSet(){} // RVA: 0xCD60
        public void get_direction(){} // RVA: 0xD840
        public void get_active(){} // RVA: 0xDBE0
        public void get_lastActive(){} // RVA: 0xDBE0
        public void get_activeBinding(){} // RVA: 0xDBE0
        public void get_lastActiveBinding(){} // RVA: 0xDBE0
        public void PreInitialize(){} // RVA: 0x24B10
        public void CreateUninitialized(){} // RVA: 0x2A620 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0xCD60
        public void Initialize(){} // RVA: 0x251C0
        public void GetSourceMap(){} // RVA: 0xCD60
        public void InitializeCopy(){} // RVA: 0x2DC60
        public void InitAfterDeserialize(){} // RVA: 0x24A50
        public void GetActive(){} // RVA: 0xE1F0
        public void GetActiveBinding(){} // RVA: 0xE1F0
        public void GetLastActive(){} // RVA: 0xE1F0
        public void GetLastActiveBinding(){} // RVA: 0xE1F0
        public void GetActionBindingInfo(){} // RVA: 0xCD60
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Single_Source_Map sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Pose_Source_Map`1<Valve.VR.SteamVR_Action_Pose_Source> sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Vector2_Source_Map sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Vibration_Source_Map sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Boolean_Source_Map sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Skeleton_Source_Map sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Action`2
    {
        public Valve.VR.SteamVR_Action_Vector3_Source_Map sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8

        // ── Methods ──
        public void get_Item(){} // RVA: 0x408F2A0
        public void get_fullPath(){} // RVA: 0x408F2D0
        public void get_handle(){} // RVA: 0x408F2F0
        public void get_actionSet(){} // RVA: 0x408F310
        public void get_direction(){} // RVA: 0x408F330
        public void get_active(){} // RVA: 0x408F350
        public void get_lastActive(){} // RVA: 0x408F3A0
        public void get_activeBinding(){} // RVA: 0x408F3F0
        public void get_lastActiveBinding(){} // RVA: 0x408F440
        public void PreInitialize(){} // RVA: 0x408F490
        public void CreateUninitialized(){} // RVA: 0x408F6B0 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x408F8B0
        public void Initialize(){} // RVA: 0x408FB70
        public void GetSourceMap(){} // RVA: 0x30B130
        public void InitializeCopy(){} // RVA: 0x408FC80
        public void InitAfterDeserialize(){} // RVA: 0x408FE00
        public void GetActive(){} // RVA: 0x408FEB0
        public void GetActiveBinding(){} // RVA: 0x408FF00
        public void GetLastActive(){} // RVA: 0x408FF50
        public void GetLastActiveBinding(){} // RVA: 0x408FFA0
        public void GetActionBindingInfo(){} // RVA: 0x408FFF0
        public void .ctor(){} // RVA: 0x4090680
        public void .cctor(){} // RVA: 0x40906D0
    }

    public class SteamVR_Actions
    {
        public Valve.VR.SteamVR_Action_Boolean padding;
        public Valve.VR.SteamVR_Action_Pose softness; // 0x8
        public Valve.VR.SteamVR_Action_Skeleton Canvas; // 0x10
        public Valve.VR.SteamVR_Action_Skeleton canvasRect; // 0x18
        public Valve.VR.SteamVR_Action_Boolean rectTransform; // 0x20
        public Valve.VR.SteamVR_Action_Boolean rootCanvasRect; // 0x28
        public Valve.VR.SteamVR_Action_Boolean 0; // 0x30
        public Valve.VR.SteamVR_Action_Boolean _global_Safe_Mode; // 0x38
        public Valve.VR.SteamVR_Action_Boolean _global_Pose; // 0x40
        public Valve.VR.SteamVR_Action_Boolean .ctor; // 0x48
        public Valve.VR.SteamVR_Action_Boolean _global_SkeletonLeftHand; // 0x50
        public Valve.VR.SteamVR_Action_Vector2 `; // 0x58
        public Valve.VR.SteamVR_Action_Boolean _global_SkeletonRightHand; // 0x60
        public Valve.VR.SteamVR_Action_Vector2 _global_HeadsetOnHead; // 0x68
        public Valve.VR.SteamVR_Action_Boolean _global_Menu; // 0x70
        public Valve.VR.SteamVR_Action_Boolean `; // 0x78
        public Valve.VR.SteamVR_Action_Boolean _global_Quick_Menu; // 0x80
        public Valve.VR.SteamVR_Action_Single _global_Action_Menu; // 0x88
        public Valve.VR.SteamVR_Action_Single _global_Main_Menu; // 0x90
        public Valve.VR.SteamVR_Action_Boolean `; // 0x98
        public Valve.VR.SteamVR_Action_Boolean _global_Interact; // 0xA0
        public Valve.VR.SteamVR_Action_Boolean _global_Grab; // 0xA8
        public Valve.VR.SteamVR_Action_Boolean _global_Move; // 0xB0
        public Valve.VR.SteamVR_Action_Boolean `; // 0xB8
        public Valve.VR.SteamVR_Action_Boolean _global_Jump; // 0xC0
        public Valve.VR.SteamVR_Action_Boolean bV; // 0xC8
        public Valve.VR.SteamVR_Action_Boolean _global_Rotate; // 0xD0
        public Valve.VR.SteamVR_Action_Boolean p_global_Earmuffs; // 0xD8
        public Valve.VR.SteamVR_Action_Boolean p_global_Camera; // 0xE0
        public Valve.VR.SteamVR_Action_Boolean p_global_Stream_Camera; // 0xE8
        public Valve.VR.SteamVR_Action_Boolean p_global_Avatar_Debug_Screen; // 0xF0
        public Valve.VR.SteamVR_Action_Boolean p_global_OSC_Debug_Screen; // 0xF8
        public Valve.VR.SteamVR_Action_Boolean p_global_Confirm_FBT_Calibration; // 0x100
        public Valve.VR.SteamVR_Action_Boolean p_global_Start_Move; // 0x108
        public Valve.VR.SteamVR_Action_Boolean p_global_Start_Rotate; // 0x110
        public Valve.VR.SteamVR_Action_Boolean p_global_Continue_Move; // 0x118
        public Valve.VR.SteamVR_Action_Boolean p_global_Continue_Rotate; // 0x120
        public Valve.VR.SteamVR_Action_Boolean p_global_No_Gesture_After_Move; // 0x128
        public Valve.VR.SteamVR_Action_Boolean p_global_No_Gesture_After_Rotate; // 0x130
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Activator_Thumb; // 0x138
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Activator_Thumb_Inner_Upper; // 0x140
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Activator_Thumb_Inner_Lower; // 0x148
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Activator_Thumb_Outer; // 0x150
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Activator_Index; // 0x158
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Activator_Grip; // 0x160
        public Valve.VR.SteamVR_Action_Single p_global_Gesture_Trigger_Axis; // 0x168
        public Valve.VR.SteamVR_Action_Single p_global_Gesture_Grip_Axis; // 0x170
        public Valve.VR.SteamVR_Action_Vector2 p_global_Gesture_Activator_Stick_Deflection; // 0x178
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Neutral_Left; // 0x180
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Fist_Left; // 0x188
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Open_Left; // 0x190
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Peace_Left; // 0x198
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Horns_Left; // 0x1A0
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Finger_Gun_Left; // 0x1A8
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Thumbs_Up_Left; // 0x1B0
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Point_Left; // 0x1B8
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Neutral_Right; // 0x1C0
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Fist_Right; // 0x1C8
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Open_Right; // 0x1D0
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Peace_Right; // 0x1D8
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Horns_Right; // 0x1E0
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Finger_Gun_Right; // 0x1E8
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Thumbs_Up_Right; // 0x1F0
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Direct_Point_Right; // 0x1F8
        public Valve.VR.SteamVR_Action_Vector2 p_global_Gesture_Wheel_Left; // 0x200
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Select_Left; // 0x208
        public Valve.VR.SteamVR_Action_Single p_global_Gesture_Wheel_Soft_Select_Left; // 0x210
        public Valve.VR.SteamVR_Action_Single p_global_Gesture_Wheel_Weight_Left; // 0x218
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Direct_Left; // 0x220
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Direct_Stay_Left; // 0x228
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Cancel_Left; // 0x230
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Cancel_Open_Left; // 0x238
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Held_Left; // 0x240
        public Valve.VR.SteamVR_Action_Vector2 p_global_Gesture_Wheel_Right; // 0x248
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Select_Right; // 0x250
        public Valve.VR.SteamVR_Action_Single p_global_Gesture_Wheel_Soft_Select_Right; // 0x258
        public Valve.VR.SteamVR_Action_Single p_global_Gesture_Wheel_Weight_Right; // 0x260
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Direct_Right; // 0x268
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Direct_Stay_Right; // 0x270
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Cancel_Right; // 0x278
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Cancel_Open_Right; // 0x280
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Wheel_Held_Right; // 0x288
        public Valve.VR.SteamVR_Action_Boolean p_global_Disable_Gesture_Tracked; // 0x290
        public Valve.VR.SteamVR_Action_Boolean p_global_Disable_Gesture_Wheel_Move_Left; // 0x298
        public Valve.VR.SteamVR_Action_Boolean p_global_Disable_Gesture_Wheel_Rotate_Left; // 0x2A0
        public Valve.VR.SteamVR_Action_Boolean p_global_Disable_Gesture_Wheel_Move_Right; // 0x2A8
        public Valve.VR.SteamVR_Action_Boolean p_global_Disable_Gesture_Wheel_Rotate_Right; // 0x2B0
        public Valve.VR.SteamVR_Action_Boolean p_global_Physbone_Grab_Left; // 0x2B8
        public Valve.VR.SteamVR_Action_Boolean p_global_Physbone_Freeze_Left; // 0x2C0
        public Valve.VR.SteamVR_Action_Boolean p_global_Physbone_Grab_Right; // 0x2C8
        public Valve.VR.SteamVR_Action_Boolean p_global_Physbone_Freeze_Right; // 0x2D0
        public Valve.VR.SteamVR_Action_Vector2 p_global_Scroll; // 0x2D8
        public Valve.VR.SteamVR_Action_Vibration p_global_Haptic; // 0x2E0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Interact; // 0x2E8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Grab; // 0x2F0
        public Valve.VR.SteamVR_Action_Vector2 p_one_Hand_Move_Rotate; // 0x2F8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Jump; // 0x300
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Mic; // 0x308
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Toggle; // 0x310
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Stick_Click; // 0x318
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Trigger_Axis; // 0x320
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Grip_Axis; // 0x328
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Udon_Menu; // 0x330
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Drop; // 0x338
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Start_Move_Rotate; // 0x340
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Continue_Move_Rotate; // 0x348
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_No_Gesture_After_Move_Rotate; // 0x350
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Menu; // 0x358
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Nameplates; // 0x360
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_HUD; // 0x368
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Chatbox; // 0x370
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Face_Mirror; // 0x378
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Personal_Mirror; // 0x380
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Personal_Mirror_Lock; // 0x388
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Earmuffs; // 0x390
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Camera; // 0x398
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Stream_Camera; // 0x3A0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Avatar_Debug_Screen; // 0x3A8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_OSC_Debug_Screen; // 0x3B0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Confirm_FBT_Calibration; // 0x3B8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Activator_Thumb; // 0x3C0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Activator_Thumb_Inner_Upper; // 0x3C8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Activator_Thumb_Inner_Lower; // 0x3D0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Activator_Thumb_Outer; // 0x3D8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Activator_Index; // 0x3E0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Activator_Grip; // 0x3E8
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Gesture_Trigger_Axis; // 0x3F0
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Gesture_Grip_Axis; // 0x3F8
        public Valve.VR.SteamVR_Action_Vector2 p_one_Hand_Gesture_Activator_Stick_Deflection; // 0x400
        public Valve.VR.SteamVR_Action_Vector2 p_one_Hand_Gesture_Wheel_Left; // 0x408
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Select_Left; // 0x410
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Gesture_Wheel_Soft_Select_Left; // 0x418
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Gesture_Wheel_Weight_Left; // 0x420
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Direct_Left; // 0x428
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Direct_Stay_Left; // 0x430
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Cancel_Left; // 0x438
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Cancel_Open_Left; // 0x440
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Held_Left; // 0x448
        public Valve.VR.SteamVR_Action_Vector2 p_one_Hand_Gesture_Wheel_Right; // 0x450
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Select_Right; // 0x458
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Gesture_Wheel_Soft_Select_Right; // 0x460
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Gesture_Wheel_Weight_Right; // 0x468
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Direct_Right; // 0x470
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Direct_Stay_Right; // 0x478
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Cancel_Right; // 0x480
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Cancel_Open_Right; // 0x488
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Gesture_Wheel_Held_Right; // 0x490
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Disable_Gesture_Wheel_Move_Left; // 0x498
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Disable_Gesture_Wheel_Rotate_Left; // 0x4A0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Disable_Gesture_Wheel_Move_Right; // 0x4A8
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Disable_Gesture_Wheel_Rotate_Right; // 0x4B0
        public Valve.VR.SteamVR_Action_Boolean p_one_Hand_Reserve_bool; // 0x4B8
        public Valve.VR.SteamVR_Action_Single p_one_Hand_Reserve_vector1; // 0x4C0
        public Valve.VR.SteamVR_Action_Vector2 p_one_Hand_Reserve_vector2; // 0x4C8
        public Valve.VR.SteamVR_Action_Boolean p_menu_Confirm; // 0x4D0
        public Valve.VR.SteamVR_Action_Boolean p_menu_Back; // 0x4D8
        public Valve.VR.SteamVR_Action_Boolean p_menu_Tab; // 0x4E0
        public Valve.VR.SteamVR_Action_Vector2 p_menu_Scroll; // 0x4E8
        public Valve.VR.SteamVR_Action_Boolean p_menu_Quick_Menu_Close; // 0x4F0
        public Valve.VR.SteamVR_Action_Boolean p_menu_Drag; // 0x4F8
        public Valve.VR.SteamVR_Action_Vector2 p_action_Menu_Axis; // 0x500
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Select; // 0x508
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Activator_Thumb; // 0x510
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Activator_Thumb_Inner_Upper; // 0x518
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Activator_Thumb_Inner_Lower; // 0x520
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Activator_Thumb_Outer; // 0x528
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Activator_Index; // 0x530
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Activator_Grip; // 0x538
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Gesture_Trigger_Axis; // 0x540
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Gesture_Grip_Axis; // 0x548
        public Valve.VR.SteamVR_Action_Vector2 p_action_Menu_Gesture_Activator_Stick_Deflection; // 0x550
        public Valve.VR.SteamVR_Action_Vector2 p_action_Menu_Gesture_Wheel_Left; // 0x558
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Select_Left; // 0x560
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Gesture_Wheel_Soft_Select_Left; // 0x568
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Gesture_Wheel_Weight_Left; // 0x570
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Direct_Left; // 0x578
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Direct_Stay_Left; // 0x580
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Cancel_Left; // 0x588
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Cancel_Open_Left; // 0x590
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Held_Left; // 0x598
        public Valve.VR.SteamVR_Action_Vector2 p_action_Menu_Gesture_Wheel_Right; // 0x5A0
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Select_Right; // 0x5A8
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Gesture_Wheel_Soft_Select_Right; // 0x5B0
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Gesture_Wheel_Weight_Right; // 0x5B8
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Direct_Right; // 0x5C0
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Direct_Stay_Right; // 0x5C8
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Cancel_Right; // 0x5D0
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Cancel_Open_Right; // 0x5D8
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Gesture_Wheel_Held_Right; // 0x5E0
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Disable_Gesture_Wheel_Move_Left; // 0x5E8
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Disable_Gesture_Wheel_Rotate_Left; // 0x5F0
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Disable_Gesture_Wheel_Move_Right; // 0x5F8
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Disable_Gesture_Wheel_Rotate_Right; // 0x600
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Reserve_bool; // 0x608
        public Valve.VR.SteamVR_Action_Single p_action_Menu_Reserve_vector1; // 0x610
        public Valve.VR.SteamVR_Action_Vector2 p_action_Menu_Reserve_vector2; // 0x618
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Grab; // 0x620
        public Valve.VR.SteamVR_Action_Boolean p_action_Menu_Drop; // 0x628
        public Valve.VR.SteamVR_Action_Vector2 p_drone_Left_Joystick; // 0x630
        public Valve.VR.SteamVR_Action_Vector2 p_drone_Right_Joystick; // 0x638
        public Valve.VR.SteamVR_Action_Boolean p_drone_Self_Leveling_Mod; // 0x640
        public Valve.VR.SteamVR_Action_Boolean p_drone_Hold_Altitude_Mod; // 0x648
        public Valve.VR.SteamVR_Action_Boolean p_drone_Toggle_FPV; // 0x650
        public Valve.VR.SteamVR_Action_Boolean p_drone_Flip; // 0x658
        public Valve.VR.SteamVR_Action_Boolean p_drone_Take_Picture; // 0x660
        public Valve.VR.SteamVR_Action_Boolean p_drone_Cycle_Flight_Preset; // 0x668
        public Valve.VR.SteamVR_Action_Boolean p_drone_Toggle_Self_Leveling; // 0x670
        public Valve.VR.SteamVR_Action_Boolean p_drone_Respawn; // 0x678
        public Valve.VR.SteamVR_Action_Boolean p_drone_Select_Flight_Preset_Micro; // 0x680
        public Valve.VR.SteamVR_Action_Boolean p_drone_Select_Flight_Preset_Cinematic; // 0x688
        public Valve.VR.SteamVR_Action_Boolean p_drone_Select_Flight_Preset_Racing; // 0x690
        public Valve.VR.SteamVR_Action_Boolean p_drone_Select_Flight_Preset_Freestyle; // 0x698
        public Valve.VR.SteamVR_Input_ActionSet_Global p_Global; // 0x6A0
        public Valve.VR.SteamVR_Input_ActionSet_One_Hand p_One_Hand; // 0x6A8
        public Valve.VR.SteamVR_Input_ActionSet_Menu p_Menu; // 0x6B0
        public Valve.VR.SteamVR_Input_ActionSet_Action_Menu p_Action_Menu; // 0x6B8
        public Valve.VR.SteamVR_Input_ActionSet_Drone p_Drone; // 0x6C0

        // ── Methods ──
        public void get_global_Safe_Mode(){} // RVA: 0x64BD000
        public void get_global_Pose(){} // RVA: 0x64BD070
        public void get_global_SkeletonLeftHand(){} // RVA: 0x64BD0E0
        public void get_global_SkeletonRightHand(){} // RVA: 0x64BD150
        public void get_global_HeadsetOnHead(){} // RVA: 0x64BD1C0
        public void get_global_Menu(){} // RVA: 0x64BD230
        public void get_global_Quick_Menu(){} // RVA: 0x64BD2A0
        public void get_global_Action_Menu(){} // RVA: 0x64BD310
        public void get_global_Main_Menu(){} // RVA: 0x64BD380
        public void get_global_Interact(){} // RVA: 0x64BD3F0
        public void get_global_Grab(){} // RVA: 0x64BD460
        public void get_global_Move(){} // RVA: 0x64BD4D0
        public void get_global_Jump(){} // RVA: 0x64BD540
        public void get_global_Rotate(){} // RVA: 0x64BD5B0
        public void get_global_Mic(){} // RVA: 0x64BD620
        public void get_global_Gesture_Toggle(){} // RVA: 0x64BD690
        public void get_global_Stick_Click(){} // RVA: 0x64BD700
        public void get_global_Trigger_Axis(){} // RVA: 0x64BD770
        public void get_global_Grip_Axis(){} // RVA: 0x64BD7E0
        public void get_global_Udon_Menu(){} // RVA: 0x64BD850
        public void get_global_Drop(){} // RVA: 0x64BD8C0
        public void get_global_Nameplates(){} // RVA: 0x64BD930
        public void get_global_HUD(){} // RVA: 0x64BD9A0
        public void get_global_Chatbox(){} // RVA: 0x64BDA10
        public void get_global_Face_Mirror(){} // RVA: 0x64BDA80
        public void get_global_Personal_Mirror(){} // RVA: 0x64BDAF0
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x64BDB60
        public void get_global_Earmuffs(){} // RVA: 0x64BDBD0
        public void get_global_Camera(){} // RVA: 0x64BDC40
        public void get_global_Stream_Camera(){} // RVA: 0x64BDCB0
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x64BDD20
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x64BDD90
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x64BDE00
        public void get_global_Start_Move(){} // RVA: 0x64BDE70
        public void get_global_Start_Rotate(){} // RVA: 0x64BDEE0
        public void get_global_Continue_Move(){} // RVA: 0x64BDF50
        public void get_global_Continue_Rotate(){} // RVA: 0x64BDFC0
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x64BE030
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x64BE0A0
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x64BE110
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x64BE180
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x64BE1F0
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x64BE260
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x64BE2D0
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x64BE340
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x64BE3B0
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x64BE420
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x64BE490
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x64BE500
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x64BE570
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x64BE5E0
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x64BE650
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x64BE6C0
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x64BE730
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x64BE7A0
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x64BE810
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x64BE880
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x64BE8F0
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x64BE960
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x64BE9D0
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x64BEA40
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x64BEAB0
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x64BEB20
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x64BEB90
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x64BEC00
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x64BEC70
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x64BECE0
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x64BED50
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x64BEDC0
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x64BEE30
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x64BEEA0
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x64BEF10
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x64BEF80
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x64BEFF0
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x64BF060
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x64BF0D0
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x64BF140
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x64BF1B0
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x64BF220
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x64BF290
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x64BF300
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x64BF370
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x64BF3E0
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x64BF450
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x64BF4C0
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x64BF530
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x64BF5A0
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x64BF610
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x64BF680
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x64BF6F0
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x64BF760
        public void get_global_Scroll(){} // RVA: 0x64BF7D0
        public void get_global_Haptic(){} // RVA: 0x64BF840
        public void get_one_Hand_Interact(){} // RVA: 0x64BF8B0
        public void get_one_Hand_Grab(){} // RVA: 0x64BF920
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x64BF990
        public void get_one_Hand_Jump(){} // RVA: 0x64BFA00
        public void get_one_Hand_Mic(){} // RVA: 0x64BFA70
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x64BFAE0
        public void get_one_Hand_Stick_Click(){} // RVA: 0x64BFB50
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x64BFBC0
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x64BFC30
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x64BFCA0
        public void get_one_Hand_Drop(){} // RVA: 0x64BFD10
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x64BFD80
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x64BFDF0
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x64BFE60
        public void get_one_Hand_Menu(){} // RVA: 0x64BFED0
        public void get_one_Hand_Nameplates(){} // RVA: 0x64BFF40
        public void get_one_Hand_HUD(){} // RVA: 0x64BFFB0
        public void get_one_Hand_Chatbox(){} // RVA: 0x64C0020
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x64C0090
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x64C0100
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x64C0170
        public void get_one_Hand_Earmuffs(){} // RVA: 0x64C01E0
        public void get_one_Hand_Camera(){} // RVA: 0x64C0250
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x64C02C0
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x64C0330
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x64C03A0
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x64C0410
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x64C0480
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x64C04F0
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x64C0560
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x64C05D0
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x64C0640
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x64C06B0
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x64C0720
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x64C0790
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x64C0800
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x64C0870
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x64C08E0
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x64C0950
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x64C09C0
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x64C0A30
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x64C0AA0
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x64C0B10
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x64C0B80
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x64C0BF0
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x64C0C60
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x64C0CD0
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x64C0D40
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x64C0DB0
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x64C0E20
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x64C0E90
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x64C0F00
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x64C0F70
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x64C0FE0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x64C1050
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x64C10C0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x64C1130
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x64C11A0
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x64C1210
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x64C1280
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x64C12F0
        public void get_menu_Confirm(){} // RVA: 0x64C1360
        public void get_menu_Back(){} // RVA: 0x64C13D0
        public void get_menu_Tab(){} // RVA: 0x64C1440
        public void get_menu_Scroll(){} // RVA: 0x64C14B0
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x64C1520
        public void get_menu_Drag(){} // RVA: 0x64C1590
        public void get_action_Menu_Axis(){} // RVA: 0x64C1600
        public void get_action_Menu_Select(){} // RVA: 0x64C1670
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x64C16E0
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x64C1750
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x64C17C0
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x64C1830
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x64C18A0
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x64C1910
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x64C1980
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x64C19F0
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x64C1A60
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x64C1AD0
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x64C1B40
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x64C1BB0
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x64C1C20
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x64C1C90
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x64C1D00
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x64C1D70
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x64C1DE0
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x64C1E50
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x64C1EC0
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x64C1F30
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x64C1FA0
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x64C2010
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x64C2080
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x64C20F0
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x64C2160
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x64C21D0
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x64C2240
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x64C22B0
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x64C2320
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x64C2390
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x64C2400
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x64C2470
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x64C24E0
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x64C2550
        public void get_action_Menu_Grab(){} // RVA: 0x64C25C0
        public void get_action_Menu_Drop(){} // RVA: 0x64C2630
        public void get_drone_Left_Joystick(){} // RVA: 0x64C26A0
        public void get_drone_Right_Joystick(){} // RVA: 0x64C2710
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x64C2780
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x64C27F0
        public void get_drone_Toggle_FPV(){} // RVA: 0x64C2860
        public void get_drone_Flip(){} // RVA: 0x64C28D0
        public void get_drone_Take_Picture(){} // RVA: 0x64C2940
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x64C29B0
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x64C2A20
        public void get_drone_Respawn(){} // RVA: 0x64C2A90
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x64C2B00
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x64C2B70
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x64C2BE0
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x64C2C50
        public void InitializeActionArrays(){} // RVA: 0x64C2CC0
        public void PreInitActions(){} // RVA: 0x64CC460
        public void get_Global(){} // RVA: 0x64D1240
        public void get_One_Hand(){} // RVA: 0x64D12B0
        public void get_Menu(){} // RVA: 0x64D1320
        public void get_Action_Menu(){} // RVA: 0x64D1390
        public void get_Drone(){} // RVA: 0x64D1400
        public void StartPreInitActionSets(){} // RVA: 0x64D1470
        public void PreInitialize(){} // RVA: 0x64D1B50
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class SteamVR_ActivateActionSetOnLoad
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x64D7D20
        public void OnDestroy(){} // RVA: 0x64D7D90
        public void .ctor(){} // RVA: 0x64D7DF0
    }

    public class SteamVR_Behaviour
    {
        public string openVRDeviceName;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x64FDE20
        public void Initialize(){} // RVA: 0x64FDF60
        public void Awake(){} // RVA: 0x64FE800
        public void InitializeSteamVR(){} // RVA: 0x64FE900
        public void DoInitializeSteamVR(){} // RVA: 0x64FEB50
        public void XRDevice_deviceLoaded(){} // RVA: 0x64FEBF0
        public void EnableOpenVR(){} // RVA: 0x64FECD0
        public void OnEnable(){} // RVA: 0x64FEDF0
        public void OnDisable(){} // RVA: 0x64FEF90
        public void OnBeforeRender(){} // RVA: 0x64FF140
        public void PreCull(){} // RVA: 0x64FF150
        public void FixedUpdate(){} // RVA: 0x64FF3D0
        public void LateUpdate(){} // RVA: 0x64FF550
        public void Update(){} // RVA: 0x64FF6F0
        public void OnQuit(){} // RVA: 0x64FF870
        public void .ctor(){} // RVA: 0x64FF8C0
        public void .cctor(){} // RVA: 0x64FF910
    }

    public class SteamVR_Behaviour_Boolean
    {
        public Valve.VR.SteamVR_Action_Boolean booleanAction; // 0x20
        public 0x65925E40 inputSource; // 0x28

        // ── Methods ──
        public void add_onChangeEvent(){} // RVA: 0x64D7EF0
        public void remove_onChangeEvent(){} // RVA: 0x64D7FE0
        public void add_onUpdateEvent(){} // RVA: 0x64D80D0
        public void remove_onUpdateEvent(){} // RVA: 0x64D81C0
        public void add_onPressEvent(){} // RVA: 0x64D82B0
        public void remove_onPressEvent(){} // RVA: 0x64D83A0
        public void add_onPressDownEvent(){} // RVA: 0x64D8490
        public void remove_onPressDownEvent(){} // RVA: 0x64D8580
        public void add_onPressUpEvent(){} // RVA: 0x64D8670
        public void remove_onPressUpEvent(){} // RVA: 0x64D8760
        public void get_isActive(){} // RVA: 0x64D8850
        public void get_actionSet(){} // RVA: 0x64D88A0
        public void OnEnable(){} // RVA: 0x64D89A0
        public void OnDisable(){} // RVA: 0x64D8A90
        public void AddHandlers(){} // RVA: 0x64D8AA0
        public void RemoveHandlers(){} // RVA: 0x64D8D60
        public void SteamVR_Behaviour_Boolean_OnStateUp(){} // RVA: 0x64D90C0
        public void SteamVR_Behaviour_Boolean_OnStateDown(){} // RVA: 0x64D9140
        public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x64D91C0
        public void SteamVR_Behaviour_Boolean_OnUpdate(){} // RVA: 0x64D9240
        public void SteamVR_Behaviour_Boolean_OnChange(){} // RVA: 0x64D92E0
        public void GetLocalizedName(){} // RVA: 0x64D9380
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_Behaviour_BooleanEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3080
    }

    public class SteamVR_Behaviour_Pose
    {
        public Valve.VR.SteamVR_Action_Pose poseAction; // 0x20
        public 0x65925E40 inputSource; // 0x28

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x64D9880
        public void get_isActive(){} // RVA: 0x64D8850
        public void Start(){} // RVA: 0x64D98C0
        public void OnEnable(){} // RVA: 0x64D9B50
        public void OnDisable(){} // RVA: 0x64D9E40
        public void SteamVR_Behaviour_Pose_OnUpdate(){} // RVA: 0x64DA1F0
        public void UpdateTransform(){} // RVA: 0x64DA290
        public void SteamVR_Behaviour_Pose_OnChange(){} // RVA: 0x64DA9A0
        public void OnDeviceConnectedChanged(){} // RVA: 0x64DAA20
        public void OnTrackingChanged(){} // RVA: 0x64DAAD0
        public void CheckDeviceIndex(){} // RVA: 0x64DAB60
        public void GetDeviceIndex(){} // RVA: 0x64DADD0
        public void GetVelocity(){} // RVA: 0x64DAE10
        public void GetAngularVelocity(){} // RVA: 0x64DAE70
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x64DAED0
        public void GetEstimatedPeakVelocities(){} // RVA: 0x64DAF40
        public void UpdateHistoryBuffer(){} // RVA: 0x64DB070
        public void GetLocalizedName(){} // RVA: 0x64DB290
        public void .ctor(){} // RVA: 0x64DB3D0
    }

    public class SteamVR_Behaviour_PoseEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3110
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A31A0
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3230
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A32C0
    }

    public class SteamVR_Behaviour_Single
    {
        public Valve.VR.SteamVR_Action_Single singleAction; // 0x20

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x64DBAB0
        public void OnEnable(){} // RVA: 0x64DBAF0
        public void OnDisable(){} // RVA: 0x64DBBE0
        public void AddHandlers(){} // RVA: 0x64DBBF0
        public void RemoveHandlers(){} // RVA: 0x64DBDB0
        public void SteamVR_Behaviour_Single_OnUpdate(){} // RVA: 0x64DC010
        public void SteamVR_Behaviour_Single_OnChange(){} // RVA: 0x64DC0D0
        public void SteamVR_Behaviour_Single_OnAxis(){} // RVA: 0x64DC190
        public void GetLocalizedName(){} // RVA: 0x64DC250
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_Behaviour_SingleEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3350
    }

    public class SteamVR_Behaviour_Skeleton
    {
        public Valve.VR.SteamVR_Action_Skeleton skeletonAction; // 0x20
        public 0x65925E40 inputSource; // 0x28
        public 0x6595CB80 rangeOfMotion; // 0x2C
        public UnityEngine.Transform skeletonRoot; // 0x30
        public UnityEngine.Transform origin; // 0x38
        public bool updatePose; // 0x40
        public bool onlySetRotations; // 0x41
        public float skeletonBlend; // 0x44
        public Valve.VR.SteamVR_Behaviour_SkeletonEvent onBoneTransformsUpdated; // 0x48
        public Valve.VR.SteamVR_Behaviour_SkeletonEvent onTransformUpdated; // 0x50
        public Valve.VR.SteamVR_Behaviour_SkeletonEvent onTransformChanged; // 0x58
        public Valve.VR.SteamVR_Behaviour_Skeleton_ConnectedChangedEvent onConnectedChanged; // 0x60
        public Valve.VR.SteamVR_Behaviour_Skeleton_TrackingChangedEvent onTrackingChanged; // 0x68
        public UpdateHandler onBoneTransformsUpdatedEvent; // 0x70
        public UpdateHandler onTransformUpdatedEvent; // 0x78
        public ChangeHandler onTransformChangedEvent; // 0x80
        public DeviceConnectedChangeHandler onConnectedChangedEvent; // 0x88
        public TrackingChangeHandler onTrackingChangedEvent; // 0x90
        public 0x65924CB8 mirroring; // 0x98
        public Valve.VR.SteamVR_Skeleton_Poser fallbackPoser; // 0xA0
        public Valve.VR.SteamVR_Action_Single fallbackCurlAction; // 0xA8
        public Valve.VR.SteamVR_Skeleton_Poser blendPoser; // 0xB0
        public Valve.VR.SteamVR_Skeleton_PoseSnapshot blendSnapshot; // 0xB8
        public UnityEngine.Transform[] <proximals>k__BackingField; // 0xC0
        public UnityEngine.Transform[] <middles>k__BackingField; // 0xC8
        public UnityEngine.Transform[] <distals>k__BackingField; // 0xD0
        public UnityEngine.Transform[] <tips>k__BackingField; // 0xD8
        public UnityEngine.Transform[] <auxs>k__BackingField; // 0xE0
        public UnityEngine.Coroutine blendRoutine; // 0xE8
        public UnityEngine.Coroutine rangeOfMotionBlendRoutine; // 0xF0
        public UnityEngine.Coroutine attachRoutine; // 0xF8
        public UnityEngine.Transform[] bones; // 0x100
        public System.Nullable`1<0x6595CB80> temporaryRangeOfMotion; // 0x108
        public UnityEngine.Quaternion rightFlipAngle;

        // ── Methods ──
        public void get_skeletonAvailable(){} // RVA: 0x64DC600
        public void get_isActive(){} // RVA: 0x64DC630
        public void get_fingerCurls(){} // RVA: 0x64DC6B0
        public void get_thumbCurl(){} // RVA: 0x64DC800
        public void get_indexCurl(){} // RVA: 0x64DC870
        public void get_middleCurl(){} // RVA: 0x64DC8E0
        public void get_ringCurl(){} // RVA: 0x64DC950
        public void get_pinkyCurl(){} // RVA: 0x64DC9C0
        public void get_root(){} // RVA: 0x64DCA30
        public void get_wrist(){} // RVA: 0x64DCA60
        public void get_indexMetacarpal(){} // RVA: 0x64DCA90
        public void get_indexProximal(){} // RVA: 0x64DCAC0
        public void get_indexMiddle(){} // RVA: 0x64DCAF0
        public void get_indexDistal(){} // RVA: 0x64DCB20
        public void get_indexTip(){} // RVA: 0x64DCB50
        public void get_middleMetacarpal(){} // RVA: 0x64DCB80
        public void get_middleProximal(){} // RVA: 0x64DCBB0
        public void get_middleMiddle(){} // RVA: 0x64DCBE0
        public void get_middleDistal(){} // RVA: 0x64DCC10
        public void get_middleTip(){} // RVA: 0x64DCC40
        public void get_pinkyMetacarpal(){} // RVA: 0x64DCC70
        public void get_pinkyProximal(){} // RVA: 0x64DCCA0
        public void get_pinkyMiddle(){} // RVA: 0x64DCCD0
        public void get_pinkyDistal(){} // RVA: 0x64DCD00
        public void get_pinkyTip(){} // RVA: 0x64DCD30
        public void get_ringMetacarpal(){} // RVA: 0x64DCD60
        public void get_ringProximal(){} // RVA: 0x64DCD90
        public void get_ringMiddle(){} // RVA: 0x64DCDC0
        public void get_ringDistal(){} // RVA: 0x64DCDF0
        public void get_ringTip(){} // RVA: 0x64DCE20
        public void get_thumbMetacarpal(){} // RVA: 0x64DCE50
        public void get_thumbProximal(){} // RVA: 0x64DCE50
        public void get_thumbMiddle(){} // RVA: 0x64DCE80
        public void get_thumbDistal(){} // RVA: 0x64DCEB0
        public void get_thumbTip(){} // RVA: 0x64DCEE0
        public void get_thumbAux(){} // RVA: 0x64DCF10
        public void get_indexAux(){} // RVA: 0x64DCF40
        public void get_middleAux(){} // RVA: 0x64DCF70
        public void get_ringAux(){} // RVA: 0x64DCFA0
        public void get_pinkyAux(){} // RVA: 0x64DCFD0
        public void get_proximals(){} // RVA: 0x348120
        public void set_proximals(){} // RVA: 0x348130
        public void get_middles(){} // RVA: 0x435460
        public void set_middles(){} // RVA: 0x435470
        public void get_distals(){} // RVA: 0x3FA100
        public void set_distals(){} // RVA: 0x3FA110
        public void get_tips(){} // RVA: 0xA96D30
        public void set_tips(){} // RVA: 0x35E8A0
        public void get_auxs(){} // RVA: 0x35E900
        public void set_auxs(){} // RVA: 0x35E910
        public void get_skeletalTrackingLevel(){} // RVA: 0x64DD000
        public void get_isBlending(){} // RVA: 0x64DD0A0
        public void get_actionSet(){} // RVA: 0x64A48E0
        public void get_direction(){} // RVA: 0x64A4910
        public void Awake(){} // RVA: 0x64DD0B0
        public void CheckSkeletonAction(){} // RVA: 0x64DDCE0
        public void AssignBonesArray(){} // RVA: 0x64DDE70
        public void OnEnable(){} // RVA: 0x64DDF50
        public void OnDisable(){} // RVA: 0x64DE310
        public void OnDeviceConnectedChanged(){} // RVA: 0x64DE6E0
        public void OnTrackingChanged(){} // RVA: 0x64DE780
        public void SteamVR_Input_OnSkeletonsUpdated(){} // RVA: 0x37EF790
        public void UpdateSkeleton(){} // RVA: 0x64DE820
        public void SetTemporaryRangeOfMotion(){} // RVA: 0x64DEAB0
        public void ResetTemporaryRangeOfMotion(){} // RVA: 0x64DEB40
        public void SetRangeOfMotion(){} // RVA: 0x64DEB50
        public void BlendToSkeleton(){} // RVA: 0x64DECD0
        public void BlendToPoser(){} // RVA: 0x64DEED0
        public void BlendToAnimation(){} // RVA: 0x64DF010
        public void BlendTo(){} // RVA: 0x64DF020
        public void DoBlendRoutine(){} // RVA: 0x64DF220
        public void RangeOfMotionBlend(){} // RVA: 0x64DF2E0
        public void TemporaryRangeOfMotionBlend(){} // RVA: 0x64DF460
        public void ResetTemporaryRangeOfMotionBlend(){} // RVA: 0x64DF650
        public void DoRangeOfMotionBlend(){} // RVA: 0x64DF820
        public void GetBlendPoseForBone(){} // RVA: 0x64DF8F0
        public void UpdateSkeletonTransforms(){} // RVA: 0x64DF940
        public void SetBonePosition(){} // RVA: 0x64E0890
        public void SetBoneRotation(){} // RVA: 0x64E0930
        public void GetBone(){} // RVA: 0x64E09C0
        public void GetBonePosition(){} // RVA: 0x64E0A30
        public void GetBoneRotation(){} // RVA: 0x64E0B50
        public void GetBonePositions(){} // RVA: 0x64E0C60
        public void GetBoneRotations(){} // RVA: 0x64E0FE0
        public void MirrorPosition(){} // RVA: 0x64E1290
        public void MirrorRotation(){} // RVA: 0x64E1370
        public void UpdatePose(){} // RVA: 0x64E15C0
        public void ForceToReferencePose(){} // RVA: 0x64E1E90
        public void IsMetacarpal(){} // RVA: 0x64E24F0
        public void .ctor(){} // RVA: 0x64E2510
        public void .cctor(){} // RVA: 0x64E2570
    }

    public class SteamVR_Behaviour_SkeletonCustom
    {
        // ── Methods ──
        public void AssignBonesArray(){} // RVA: 0x64E3970
        public void .ctor(){} // RVA: 0x64E4220
    }

    public class SteamVR_Behaviour_SkeletonEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A33E0
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3470
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3500
    }

    public class SteamVR_Behaviour_Vector2
    {
        public Valve.VR.SteamVR_Action_Vector2 vector2Action; // 0x20

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x64DBAB0
        public void OnEnable(){} // RVA: 0x64E42C0
        public void OnDisable(){} // RVA: 0x64E43B0
        public void AddHandlers(){} // RVA: 0x64E43C0
        public void RemoveHandlers(){} // RVA: 0x64E4580
        public void SteamVR_Behaviour_Vector2_OnUpdate(){} // RVA: 0x64E47E0
        public void SteamVR_Behaviour_Vector2_OnChange(){} // RVA: 0x64E48A0
        public void SteamVR_Behaviour_Vector2_OnAxis(){} // RVA: 0x64E4960
        public void GetLocalizedName(){} // RVA: 0x64E4A20
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_Behaviour_Vector2Event
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3590
    }

    public class SteamVR_Behaviour_Vector3
    {
        public Valve.VR.SteamVR_Action_Vector3 vector3Action; // 0x20

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x64DBAB0
        public void OnEnable(){} // RVA: 0x64E4DD0
        public void OnDisable(){} // RVA: 0x64E4EC0
        public void AddHandlers(){} // RVA: 0x64E4ED0
        public void RemoveHandlers(){} // RVA: 0x64E5090
        public void SteamVR_Behaviour_Vector3_OnUpdate(){} // RVA: 0x64E52F0
        public void SteamVR_Behaviour_Vector3_OnChange(){} // RVA: 0x64E5400
        public void SteamVR_Behaviour_Vector3_OnAxis(){} // RVA: 0x64E5510
        public void GetLocalizedName(){} // RVA: 0x64E5620
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class SteamVR_Behaviour_Vector3Event
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x64A3620
    }

}