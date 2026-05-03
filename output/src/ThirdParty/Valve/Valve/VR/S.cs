// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 100
// Methods: 1820

namespace ThirdParty.Valve.Valve.VR
{
    public class SpatialAnchorPose_t : ValueType
    {
    }

    public class SteamVR : Object
    {
        public System.Nullable`1<bool> isSupported;
        public bool _enabled; // 0x2
        public Valve.VR.SteamVR _instance; // 0x8
        public 0x66603A1C initializedState; // 0x10
        public Valve.VR.SteamVR_Settings _settings; // 0x18
        public Valve.VR.CVRSystem _hmd; // 0x10
        public Valve.VR.CVRCompositor _compositor; // 0x18
        public Valve.VR.CVROverlay _overlay; // 0x20
        public bool _initializing; // 0x20
        public bool _calibrating; // 0x21
        public bool _outOfRange; // 0x22
        public bool[] connected; // 0x28
        public float _sceneWidth; // 0x28
        public float _sceneHeight; // 0x2C
        public float _aspect; // 0x30
        public float _fieldOfView; // 0x34
        public UnityEngine.Vector2 _tanHalfFov; // 0x38
        public Valve.VR.VRTextureBounds_t[] _textureBounds; // 0x40
        public RigidTransform[] _eyes; // 0x48
        public 0x6663983C textureType; // 0x50
        public bool runningTemporarySession; // 0x30
        public string defaultUnityAppKeyTemplate;
        public string defaultAppKeyTemplate;
        public object field_23; // 0x1A0
        public object field_24; // 0x1A1

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFE87038550
        public void get_enabled(){} // RVA: 0x7FFE870385B0
        public void set_enabled(){} // RVA: 0x7FFE870387E0
        public void get_instance(){} // RVA: 0x7FFE87038880
        public void Initialize(){} // RVA: 0x7FFE870389E0
        public void get_usingNativeSupport(){} // RVA: 0x7FFE87038BA0
        public void get_settings(){} // RVA: 0x7FFE87038BF0
        public void set_settings(){} // RVA: 0x7FFE87038C50
        public void ReportGeneralErrors(){} // RVA: 0x7FFE87038D10
        public void CreateInstance(){} // RVA: 0x7FFE87038DA0
        public void ReportError(){} // RVA: 0x7FFE87039440
        public void get_hmd(){} // RVA: 0x7FFE81116380
        public void set_hmd(){} // RVA: 0x7FFE810FCE30
        public void get_compositor(){} // RVA: 0x7FFE810FE7C0
        public void set_compositor(){} // RVA: 0x7FFE81161E80
        public void get_overlay(){} // RVA: 0x7FFE811290C0
        public void set_overlay(){} // RVA: 0x7FFE811290D0
        public void get_initializing(){} // RVA: 0x7FFE87039600
        public void set_initializing(){} // RVA: 0x7FFE87039660
        public void get_calibrating(){} // RVA: 0x7FFE870396C0
        public void set_calibrating(){} // RVA: 0x7FFE87039720
        public void get_outOfRange(){} // RVA: 0x7FFE87039780
        public void set_outOfRange(){} // RVA: 0x7FFE870397E0
        public void get_sceneWidth(){} // RVA: 0x7FFE811DA210
        public void set_sceneWidth(){} // RVA: 0x7FFE811DA220
        public void get_sceneHeight(){} // RVA: 0x7FFE812846C0
        public void set_sceneHeight(){} // RVA: 0x7FFE81670820
        public void get_aspect(){} // RVA: 0x7FFE81284640
        public void set_aspect(){} // RVA: 0x7FFE81308960
        public void get_fieldOfView(){} // RVA: 0x7FFE811C5630
        public void set_fieldOfView(){} // RVA: 0x7FFE811C5640
        public void get_tanHalfFov(){} // RVA: 0x7FFE822B97B0
        public void set_tanHalfFov(){} // RVA: 0x7FFE81CDDAA0
        public void get_textureBounds(){} // RVA: 0x7FFE81178740
        public void set_textureBounds(){} // RVA: 0x7FFE81123200
        public void get_eyes(){} // RVA: 0x7FFE81176730
        public void set_eyes(){} // RVA: 0x7FFE81176740
        public void get_hmd_TrackingSystemName(){} // RVA: 0x7FFE87039840
        public void get_hmd_ActualTrackingSystemName(){} // RVA: 0x7FFE87039850
        public void get_hmd_ModelNumber(){} // RVA: 0x7FFE87039860
        public void get_hmd_SerialNumber(){} // RVA: 0x7FFE87039870
        public void get_hmd_Type(){} // RVA: 0x7FFE87039880
        public void get_hmd_SecondsFromVsyncToPhotons(){} // RVA: 0x7FFE87039890
        public void get_hmd_DisplayFrequency(){} // RVA: 0x7FFE870398E0
        public void GetHeadsetActivityLevel(){} // RVA: 0x7FFE87039930
        public void GetTrackedDeviceString(){} // RVA: 0x7FFE87039980
        public void GetStringProperty(){} // RVA: 0x7FFE87039AC0
        public void GetFloatProperty(){} // RVA: 0x7FFE87039C60
        public void InitializeTemporarySession(){} // RVA: 0x7FFE87039CB0
        public void ExitTemporarySession(){} // RVA: 0x7FFE87039D70
        public void GenerateAppKey(){} // RVA: 0x7FFE87039E10
        public void GenerateCleanProductName(){} // RVA: 0x7FFE8703A030
        public void GetManifestFile(){} // RVA: 0x7FFE8703A1C0
        public void IdentifyEditorApplication(){} // RVA: 0x7FFE8703ADA0
        public void OnInitializing(){} // RVA: 0x7FFE8703B220
        public void OnCalibrating(){} // RVA: 0x7FFE8703B2C0
        public void OnOutOfRange(){} // RVA: 0x7FFE8703B360
        public void OnDeviceConnected(){} // RVA: 0x7FFE8703B400
        public void OnNewPoses(){} // RVA: 0x7FFE8703B490
        public void .ctor(){} // RVA: 0x7FFE8703B990
        public void Finalize(){} // RVA: 0x7FFE8703C7E0
        public void Dispose(){} // RVA: 0x7FFE8703C890 | overloaded x2
        public void SafeDispose(){} // RVA: 0x7FFE8703CCB0
        public void .cctor(){} // RVA: 0x7FFE8703CDA0
    }

    public class SteamVREnumEqualityComparer`1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE810A1420
        public void GetHashCode(){} // RVA: 0x7FFE810A1420
    }

    public class SteamVR_Action : Object
    {
        public string actionPath; // 0x10
        public bool needsReinit; // 0x18
        public bool startUpdatingSourceOnAccess;
        public string cachedShortName; // 0x20
        public object field_4; // 0xB
        public object field_5; // 0xC
        public object field_6; // 0xD
        public object field_7; // 0xE
        public object field_8; // 0xF

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Create(){} // RVA: 0x7FFE810A1420
        public void CreateUninitialized(){} // RVA: 0x7FFE80E4BC00 | overloaded x4
        public void GetCopy(){} // RVA: 0x7FFE810A1420
        public void TryNeedsInitData(){} // RVA: 0x7FFE80E2E2E0
        public void InitializeCopy(){} // RVA: 0x7FFE80E4F230
        public void get_fullPath(){} // RVA: 0x7FFE80E2E2E0
        public void get_handle(){} // RVA: 0x7FFE80E2E2E0
        public void get_actionSet(){} // RVA: 0x7FFE80E2E2E0
        public void get_direction(){} // RVA: 0x7FFE80E2EDB0
        public void get_setActive(){} // RVA: 0x7FFE86FE2760
        public void get_active(){} // RVA: 0x7FFE80E2F150
        public void get_activeBinding(){} // RVA: 0x7FFE80E2F150
        public void get_lastActive(){} // RVA: 0x7FFE80E2F150
        public void get_lastActiveBinding(){} // RVA: 0x7FFE80E2F150
        public void PreInitialize(){} // RVA: 0x7FFE80E460A0
        public void Initialize(){} // RVA: 0x7FFE80E46750
        public void GetTimeLastChanged(){} // RVA: 0x7FFE80E431C0
        public void GetSourceMap(){} // RVA: 0x7FFE80E2E2E0
        public void GetActive(){} // RVA: 0x7FFE80E2F760
        public void GetSetActive(){} // RVA: 0x7FFE86FE27C0
        public void GetActiveBinding(){} // RVA: 0x7FFE80E2F760
        public void GetLastActive(){} // RVA: 0x7FFE80E2F760
        public void GetLastActiveBinding(){} // RVA: 0x7FFE80E2F760
        public void GetPath(){} // RVA: 0x7FFE81116380
        public void IsUpdating(){} // RVA: 0x7FFE80E2F760
        public void GetHashCode(){} // RVA: 0x7FFE86FE2840
        public void Equals(){} // RVA: 0x7FFE86FE28C0 | overloaded x2
        public void op_Inequality(){} // RVA: 0x7FFE86FE29F0
        public void op_Equality(){} // RVA: 0x7FFE86FE2B20
        public void FindExistingActionForPartialPath(){} // RVA: 0x7FFE86FE2C20
        public void GetShortName(){} // RVA: 0x7FFE86FE2D40
        public void ShowOrigins(){} // RVA: 0x7FFE86FE2DE0
        public void HideOrigins(){} // RVA: 0x7FFE86FE2EB0
        public void .cctor(){} // RVA: 0x7FFE86FE2F00
    }

    public class SteamVR_ActionSet : Object
    {
        public string actionSetPath; // 0x10
        public Valve.VR.SteamVR_ActionSet_Data setData; // 0x18
        public bool initialized; // 0x20
        public object field_3; // 0x2B
        public object field_4; // 0x2C
        public object field_5; // 0x2D
        public object field_6; // 0x2E
        public object field_7; // 0x2F
        public object field_8; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void get_allActions(){} // RVA: 0x7FFE86FE3B40
        public void get_nonVisualInActions(){} // RVA: 0x7FFE86FE3B80
        public void get_visualActions(){} // RVA: 0x7FFE86FE3BC0
        public void get_poseActions(){} // RVA: 0x7FFE86FE3C00
        public void get_skeletonActions(){} // RVA: 0x7FFE86FE3C40
        public void get_outActionArray(){} // RVA: 0x7FFE86FE3C80
        public void get_fullPath(){} // RVA: 0x7FFE86FE3CC0
        public void get_usage(){} // RVA: 0x7FFE86FE3D00
        public void get_handle(){} // RVA: 0x7FFE86FE3D40
        public void Create(){} // RVA: 0x7FFE810A1420
        public void CreateFromName(){} // RVA: 0x7FFE810A1420
        public void PreInitialize(){} // RVA: 0x7FFE86FE3D80
        public void FinishPreInitialize(){} // RVA: 0x7FFE86FE3F00
        public void Initialize(){} // RVA: 0x7FFE86FE3F20
        public void GetPath(){} // RVA: 0x7FFE81116380
        public void IsActive(){} // RVA: 0x7FFE86FE4000
        public void GetTimeLastChanged(){} // RVA: 0x7FFE86FE4060
        public void Activate(){} // RVA: 0x7FFE86FE40B0
        public void Deactivate(){} // RVA: 0x7FFE86FE4260
        public void GetShortName(){} // RVA: 0x7FFE86FE4370
        public void ShowBindingHints(){} // RVA: 0x7FFE86FE4400
        public void ReadRawSetActive(){} // RVA: 0x7FFE86FE4540
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFE86FE4580
        public void ReadRawSetPriority(){} // RVA: 0x7FFE86FE45C0
        public void GetActionSetData(){} // RVA: 0x7FFE810FE7C0
        public void GetCopy(){} // RVA: 0x7FFE810A1420
        public void Equals(){} // RVA: 0x7FFE86FE4600 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE86FE2840
        public void op_Inequality(){} // RVA: 0x7FFE86FE4710
        public void op_Equality(){} // RVA: 0x7FFE86FE47D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE86FE4880
    }

    public class SteamVR_ActionSet_Data : Object
    {
        public Valve.VR.SteamVR_Action[] _allActions; // 0x10
        public Valve.VR.ISteamVR_Action_In[] _nonVisualInActions; // 0x18
        public Valve.VR.ISteamVR_Action_In[] _visualActions; // 0x20
        public Valve.VR.SteamVR_Action_Pose[] _poseActions; // 0x28
        public Valve.VR.SteamVR_Action_Skeleton[] _skeletonActions; // 0x30
        public Valve.VR.ISteamVR_Action_Out[] _outActionArray; // 0x38
        public string _fullPath; // 0x40
        public string _usage; // 0x48
        public ulong _handle; // 0x50

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE49A0
        public void get_allActions(){} // RVA: 0x7FFE81116380
        public void set_allActions(){} // RVA: 0x7FFE810FCE30
        public void get_nonVisualInActions(){} // RVA: 0x7FFE810FE7C0
        public void set_nonVisualInActions(){} // RVA: 0x7FFE81161E80
        public void get_visualActions(){} // RVA: 0x7FFE811290C0
        public void set_visualActions(){} // RVA: 0x7FFE811290D0
        public void get_poseActions(){} // RVA: 0x7FFE81129130
        public void set_poseActions(){} // RVA: 0x7FFE810FCE90
        public void get_skeletonActions(){} // RVA: 0x7FFE8144E200
        public void set_skeletonActions(){} // RVA: 0x7FFE81129890
        public void get_outActionArray(){} // RVA: 0x7FFE8143BA80
        public void set_outActionArray(){} // RVA: 0x7FFE81437330
        public void get_fullPath(){} // RVA: 0x7FFE81178740
        public void set_fullPath(){} // RVA: 0x7FFE81123200
        public void get_usage(){} // RVA: 0x7FFE81176730
        public void set_usage(){} // RVA: 0x7FFE81176740
        public void get_handle(){} // RVA: 0x7FFE8119C0E0
        public void set_handle(){} // RVA: 0x7FFE82506C00
        public void PreInitialize(){} // RVA: 0x7FFE810FB310
        public void FinishPreInitialize(){} // RVA: 0x7FFE86FE4B80
        public void Initialize(){} // RVA: 0x7FFE86FE55F0
        public void IsActive(){} // RVA: 0x7FFE86FE57E0
        public void GetTimeLastChanged(){} // RVA: 0x7FFE86FE5830
        public void Activate(){} // RVA: 0x7FFE86FE5870
        public void Deactivate(){} // RVA: 0x7FFE86FE5A10
        public void GetShortName(){} // RVA: 0x7FFE86FE5B20
        public void ReadRawSetActive(){} // RVA: 0x7FFE86FE5BA0
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFE86FE5BD0
        public void ReadRawSetPriority(){} // RVA: 0x7FFE86FE5C00
    }

    public class SteamVR_ActionSet_Manager : Object
    {
        public uint activeActionSetSize;

        // ── Methods ──
        public void get_rawActiveActionSetArray(){} // RVA: 0x7FFE86FE5C30
        public void Initialize(){} // RVA: 0x7FFE86FE5CB0
        public void DisableAllActionSets(){} // RVA: 0x7FFE86FE5E60
        public void UpdateActionStates(){} // RVA: 0x7FFE86FE5FA0
        public void SetChanged(){} // RVA: 0x7FFE86FE62C0
        public void GetNewArraySize(){} // RVA: 0x7FFE86FE6300
        public void UpdateActionSetsArray(){} // RVA: 0x7FFE86FE6440
        public void GetSetFromHandle(){} // RVA: 0x7FFE86FE6950
        public void UpdateDebugText(){} // RVA: 0x7FFE86FE6A70
    }

    public class SteamVR_Action_Boolean : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFE86FE6F10
        public void remove_onChange(){} // RVA: 0x7FFE86FE6F90
        public void add_onUpdate(){} // RVA: 0x7FFE86FE7010
        public void remove_onUpdate(){} // RVA: 0x7FFE86FE7090
        public void add_onState(){} // RVA: 0x7FFE86FE7110
        public void remove_onState(){} // RVA: 0x7FFE86FE7190
        public void add_onStateDown(){} // RVA: 0x7FFE86FE7210
        public void remove_onStateDown(){} // RVA: 0x7FFE86FE7290
        public void add_onStateUp(){} // RVA: 0x7FFE86FE7310
        public void remove_onStateUp(){} // RVA: 0x7FFE86FE7390
        public void add_onActiveChange(){} // RVA: 0x7FFE86FE7410
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FE7490
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FE7510
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FE7590
        public void get_state(){} // RVA: 0x7FFE86FE7610
        public void get_stateDown(){} // RVA: 0x7FFE86FE76A0
        public void get_stateUp(){} // RVA: 0x7FFE86FE7730
        public void get_lastState(){} // RVA: 0x7FFE86FE77C0
        public void get_lastStateDown(){} // RVA: 0x7FFE86FE7820
        public void get_lastStateUp(){} // RVA: 0x7FFE86FE78A0
        public void .ctor(){} // RVA: 0x7FFE86FE7920
        public void GetStateDown(){} // RVA: 0x7FFE86FE7960
        public void GetStateUp(){} // RVA: 0x7FFE86FE7A00
        public void GetState(){} // RVA: 0x7FFE86FE7AA0
        public void GetLastStateDown(){} // RVA: 0x7FFE86FE7B40
        public void GetLastStateUp(){} // RVA: 0x7FFE86FE7BD0
        public void GetLastState(){} // RVA: 0x7FFE86FE7C60
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE86FE7CD0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE86FE7D50
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFE86FE7DD0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFE86FE7E50
        public void AddOnChangeListener(){} // RVA: 0x7FFE86FE7ED0
        public void RemoveOnChangeListener(){} // RVA: 0x7FFE86FE7F50
        public void AddOnUpdateListener(){} // RVA: 0x7FFE86FE7FD0
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFE86FE8050
        public void AddOnStateDownListener(){} // RVA: 0x7FFE86FE80D0
        public void RemoveOnStateDownListener(){} // RVA: 0x7FFE86FE8150
        public void AddOnStateUpListener(){} // RVA: 0x7FFE86FE81D0
        public void RemoveOnStateUpListener(){} // RVA: 0x7FFE86FE8250
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FE82D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE86FE8340
    }

    public class SteamVR_Action_Boolean_Source : SteamVR_Action_In_Source
    {
        public uint actionData_size;
        public StateDownHandler onStateDown; // 0x158
        public StateUpHandler onStateUp; // 0x160
        public StateHandler onState; // 0x168
        public ActiveChangeHandler onActiveChange; // 0x170
        public ActiveChangeHandler onActiveBindingChange; // 0x178
        public ChangeHandler onChange; // 0x180
        public UpdateHandler onUpdate; // 0x188
        public bool _lastActive; // 0x190
        public Valve.VR.InputDigitalActionData_t actionData; // 0x198
        public Valve.VR.InputDigitalActionData_t lastActionData; // 0x1B0
        public Valve.VR.SteamVR_Action_Boolean booleanAction; // 0x1C8
        public object field_12; // 0x4570
        public Valve.VR.SteamVR_Action_Boolean_Source_Map field_13; // 0x1408

        // ── Methods ──
        public void add_onStateDown(){} // RVA: 0x7FFE86FE8780
        public void remove_onStateDown(){} // RVA: 0x7FFE86FE8870
        public void add_onStateUp(){} // RVA: 0x7FFE86FE8960
        public void remove_onStateUp(){} // RVA: 0x7FFE86FE8A50
        public void add_onState(){} // RVA: 0x7FFE86FE8B40
        public void remove_onState(){} // RVA: 0x7FFE86FE8C30
        public void add_onActiveChange(){} // RVA: 0x7FFE86FE8D20
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FE8E10
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FE8F00
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FE8FF0
        public void add_onChange(){} // RVA: 0x7FFE86FE90E0
        public void remove_onChange(){} // RVA: 0x7FFE86FE91D0
        public void add_onUpdate(){} // RVA: 0x7FFE86FE92C0
        public void remove_onUpdate(){} // RVA: 0x7FFE86FE93B0
        public void get_state(){} // RVA: 0x7FFE86FE94A0
        public void get_stateDown(){} // RVA: 0x7FFE86FE94E0
        public void get_stateUp(){} // RVA: 0x7FFE86FE9520
        public void get_changed(){} // RVA: 0x7FFE86FE9560
        public void set_changed(){} // RVA: 0x7FFE810FB310
        public void get_lastState(){} // RVA: 0x7FFE86FE95A0
        public void get_lastStateDown(){} // RVA: 0x7FFE86FE95B0
        public void get_lastStateUp(){} // RVA: 0x7FFE86FE95D0
        public void get_lastChanged(){} // RVA: 0x7FFE86FE95F0
        public void set_lastChanged(){} // RVA: 0x7FFE810FB310
        public void get_activeOrigin(){} // RVA: 0x7FFE86FE9600
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE81B164E0
        public void get_active(){} // RVA: 0x7FFE86FE9640
        public void get_activeBinding(){} // RVA: 0x7FFE86EE8260
        public void get_lastActive(){} // RVA: 0x7FFE86FE96E0
        public void set_lastActive(){} // RVA: 0x7FFE86FE96F0
        public void get_lastActiveBinding(){} // RVA: 0x7FFE86FE9700
        public void Preinitialize(){} // RVA: 0x7FFE86FE9710
        public void Initialize(){} // RVA: 0x7FFE86FE98A0
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FE9980
        public void UpdateValue(){} // RVA: 0x7FFE86FE9D20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Action_Boolean_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE8740
    }

    public class SteamVR_Action_In_Source : SteamVR_Action_Source
    {
        public uint inputOriginInfo_size;
        public bool _isUpdating; // 0x28
        public float _updateTime; // 0x2C
        public float _changedTime; // 0x30
        public int _lastOriginGetFrame; // 0x34
        public Valve.VR.InputOriginInfo_t inputOriginInfo; // 0x38
        public Valve.VR.InputOriginInfo_t lastInputOriginInfo; // 0xC8
        public object field_7; // 0x8CD
        public object field_8; // 0x8CE
        public object field_9; // 0x8CF
        public object field_10; // 0x8D0
        public object field_11; // 0x8D1

        // ── Methods ──
        public void get_isUpdating(){} // RVA: 0x7FFE815F1380
        public void set_isUpdating(){} // RVA: 0x7FFE81C15740
        public void get_updateTime(){} // RVA: 0x7FFE812846C0
        public void set_updateTime(){} // RVA: 0x7FFE81670820
        public void get_activeOrigin(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE80E2E2E0
        public void get_changed(){} // RVA: 0x7FFE80E2F150
        public void set_changed(){} // RVA: 0x7FFE80E466C0
        public void get_lastChanged(){} // RVA: 0x7FFE80E2F150
        public void set_lastChanged(){} // RVA: 0x7FFE80E466C0
        public void get_activeDevice(){} // RVA: 0x7FFE86FEA440
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFE86FEA4A0
        public void get_renderModelComponentName(){} // RVA: 0x7FFE86FEA4C0
        public void get_localizedOriginName(){} // RVA: 0x7FFE86FEA4E0
        public void get_changedTime(){} // RVA: 0x7FFE81284640
        public void set_changedTime(){} // RVA: 0x7FFE81308960
        public void get_lastOriginGetFrame(){} // RVA: 0x7FFE82447220
        public void set_lastOriginGetFrame(){} // RVA: 0x7FFE82443340
        public void UpdateValue(){} // RVA: 0x7FFE80E45FE0
        public void Initialize(){} // RVA: 0x7FFE86FEA500
        public void UpdateOriginTrackedDeviceInfo(){} // RVA: 0x7FFE86FEA620
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFE86FEAAA0
        public void GetLocalizedOrigin(){} // RVA: 0x7FFE86FEAB50
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x7FFE84D03770
        public void OnAccessSource(){} // RVA: 0x7FFE84D03820
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7FFE84D038B0
        public void UpdateValues(){} // RVA: 0x7FFE84D03A60
        public void .ctor(){} // RVA: 0x7FFE84D03B40
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7FFE84D03C20
        public void get_lastChanged(){} // RVA: 0x7FFE84D03C20
        public void get_changedTime(){} // RVA: 0x7FFE84D03C70
        public void get_updateTime(){} // RVA: 0x7FFE84D03CB0
        public void get_activeOrigin(){} // RVA: 0x7FFE84D03CF0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE84D03D40
        public void get_activeDevice(){} // RVA: 0x7FFE84D03D90
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFE84D03E20
        public void get_renderModelComponentName(){} // RVA: 0x7FFE84D03E70
        public void get_localizedOriginName(){} // RVA: 0x7FFE84D03EC0
        public void UpdateValues(){} // RVA: 0x7FFE84D03F10
        public void GetRenderModelComponentName(){} // RVA: 0x7FFE84D04000
        public void GetActiveDevice(){} // RVA: 0x7FFE84D04050
        public void GetDeviceIndex(){} // RVA: 0x7FFE84D040E0
        public void GetChanged(){} // RVA: 0x7FFE84D04130
        public void GetTimeLastChanged(){} // RVA: 0x7FFE84D04180
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFE84D041C0
        public void GetLocalizedOrigin(){} // RVA: 0x7FFE84D04210
        public void IsUpdating(){} // RVA: 0x7FFE84D04250
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7FFE84D04310
        public void GetControllerType(){} // RVA: 0x7FFE84D04340
        public void .ctor(){} // RVA: 0x7FFE84D043E0
    }

    public class SteamVR_Action_Out_Source : SteamVR_Action_Source
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFE86FEAC40
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FEACC0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FEAD40
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FEAE80
        public void add_onChange(){} // RVA: 0x7FFE86FEAF00
        public void remove_onChange(){} // RVA: 0x7FFE86FEAF80
        public void add_onUpdate(){} // RVA: 0x7FFE86FEB000
        public void remove_onUpdate(){} // RVA: 0x7FFE86FEB080
        public void add_onTrackingChanged(){} // RVA: 0x7FFE86FEB100
        public void remove_onTrackingChanged(){} // RVA: 0x7FFE86FEB180
        public void add_onValidPoseChanged(){} // RVA: 0x7FFE86FEB200
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFE86FEB280
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FEB300
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FEB380
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7FFE86FEB400
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7FFE86FEB480
        public void AddOnTrackingChanged(){} // RVA: 0x7FFE86FEB500
        public void RemoveOnTrackingChanged(){} // RVA: 0x7FFE86FEB580
        public void AddOnValidPoseChanged(){} // RVA: 0x7FFE86FEB600
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7FFE86FEB680
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE86FEB700
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE86FEB780
        public void AddOnChangeListener(){} // RVA: 0x7FFE86FEB800
        public void RemoveOnChangeListener(){} // RVA: 0x7FFE86FEB880
        public void AddOnUpdateListener(){} // RVA: 0x7FFE86FEB900
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFE86FEB980
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FEBA00
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE86FEBA80
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7FFE86FEBAC0
        public void .ctor(){} // RVA: 0x7FFE86FEBCD0
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x7FFE80E47430
        public void get_localPosition(){} // RVA: 0x7FFE80E2DCF0
        public void get_localRotation(){} // RVA: 0x7FFE80E2DCF0
        public void get_trackingState(){} // RVA: 0x7FFE80E2EDB0
        public void get_velocity(){} // RVA: 0x7FFE80E2DCF0
        public void get_angularVelocity(){} // RVA: 0x7FFE80E2DCF0
        public void get_poseIsValid(){} // RVA: 0x7FFE80E2F150
        public void get_deviceIsConnected(){} // RVA: 0x7FFE80E2F150
        public void get_lastLocalPosition(){} // RVA: 0x7FFE80E2DCF0
        public void get_lastLocalRotation(){} // RVA: 0x7FFE80E2DCF0
        public void get_lastTrackingState(){} // RVA: 0x7FFE80E2EDB0
        public void get_lastVelocity(){} // RVA: 0x7FFE80E2DCF0
        public void get_lastAngularVelocity(){} // RVA: 0x7FFE80E2DCF0
        public void get_lastPoseIsValid(){} // RVA: 0x7FFE80E2F150
        public void get_lastDeviceIsConnected(){} // RVA: 0x7FFE80E2F150
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void UpdateValues(){} // RVA: 0x7FFE80E466C0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFE810A1420
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFE810A1420
        public void UpdateTransform(){} // RVA: 0x7FFE80E48220
        public void GetLocalPosition(){} // RVA: 0x7FFE80E2F040
        public void GetLocalRotation(){} // RVA: 0x7FFE80E2F040
        public void GetVelocity(){} // RVA: 0x7FFE80E2F040
        public void GetAngularVelocity(){} // RVA: 0x7FFE80E2F040
        public void GetDeviceIsConnected(){} // RVA: 0x7FFE80E2F760
        public void GetPoseIsValid(){} // RVA: 0x7FFE80E2F760
        public void GetTrackingResult(){} // RVA: 0x7FFE80E35520
        public void GetLastLocalPosition(){} // RVA: 0x7FFE80E2F040
        public void GetLastLocalRotation(){} // RVA: 0x7FFE80E2F040
        public void GetLastVelocity(){} // RVA: 0x7FFE80E2F040
        public void GetLastAngularVelocity(){} // RVA: 0x7FFE80E2F040
        public void GetLastDeviceIsConnected(){} // RVA: 0x7FFE80E2F760
        public void GetLastPoseIsValid(){} // RVA: 0x7FFE80E2F760
        public void GetLastTrackingResult(){} // RVA: 0x7FFE80E35520
    }

    public class SteamVR_Action_Pose_Source : SteamVR_Action_In_Source
    {
        public 0x666399F4 universeOrigin; // 0x158
        public uint poseActionData_size;
        public float changeTolerance; // 0x15C
        public ActiveChangeHandler onActiveChange; // 0x160
        public ActiveChangeHandler onActiveBindingChange; // 0x168
        public ChangeHandler onChange; // 0x170
        public UpdateHandler onUpdate; // 0x178
        public TrackingChangeHandler onTrackingChanged; // 0x180
        public ValidPoseChangeHandler onValidPoseChanged; // 0x188
        public DeviceConnectedChangeHandler onDeviceConnectedChanged; // 0x190
        public bool _changed; // 0x198
        public bool _lastChanged; // 0x199
        public bool _lastActive; // 0x19A
        public UnityEngine.Vector3 _localPosition; // 0x19C
        public UnityEngine.Quaternion _localRotation; // 0x1A8
        public UnityEngine.Vector3 _lastLocalPosition; // 0x1B8
        public UnityEngine.Quaternion _lastLocalRotation; // 0x1C4
        public UnityEngine.Vector3 _velocity; // 0x1D4
        public UnityEngine.Vector3 _lastVelocity; // 0x1E0
        public UnityEngine.Vector3 _angularVelocity; // 0x1EC
        public UnityEngine.Vector3 _lastAngularVelocity; // 0x1F8
        public Valve.VR.InputPoseActionData_t poseActionData; // 0x208

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFE86FEC100
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FEC1F0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FEC2E0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FEC3D0
        public void add_onChange(){} // RVA: 0x7FFE86FEC4C0
        public void remove_onChange(){} // RVA: 0x7FFE86FEC5B0
        public void add_onUpdate(){} // RVA: 0x7FFE86FEC6A0
        public void remove_onUpdate(){} // RVA: 0x7FFE86FEC790
        public void add_onTrackingChanged(){} // RVA: 0x7FFE86FEC880
        public void remove_onTrackingChanged(){} // RVA: 0x7FFE86FEC970
        public void add_onValidPoseChanged(){} // RVA: 0x7FFE86FECA60
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFE86FECB50
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FECC40
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FECD30
        public void get_changed(){} // RVA: 0x7FFE86EE8260
        public void set_changed(){} // RVA: 0x7FFE86EE8270
        public void get_lastChanged(){} // RVA: 0x7FFE86FECE20
        public void set_lastChanged(){} // RVA: 0x7FFE86FECE30
        public void get_activeOrigin(){} // RVA: 0x7FFE86FECE40
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE81B2F980
        public void get_active(){} // RVA: 0x7FFE86FE9640
        public void get_activeBinding(){} // RVA: 0x7FFE86FECE80
        public void get_lastActive(){} // RVA: 0x7FFE86FECE90
        public void set_lastActive(){} // RVA: 0x7FFE86FECEA0
        public void get_lastActiveBinding(){} // RVA: 0x7FFE86EE8F90
        public void get_trackingState(){} // RVA: 0x7FFE8115B9C0
        public void get_lastTrackingState(){} // RVA: 0x7FFE86EBC620
        public void get_poseIsValid(){} // RVA: 0x7FFE86FECEB0
        public void get_lastPoseIsValid(){} // RVA: 0x7FFE86FECEC0
        public void get_deviceIsConnected(){} // RVA: 0x7FFE86FECED0
        public void get_lastDeviceIsConnected(){} // RVA: 0x7FFE86FECEE0
        public void get_localPosition(){} // RVA: 0x7FFE86FECEF0
        public void set_localPosition(){} // RVA: 0x7FFE86FECF10
        public void get_localRotation(){} // RVA: 0x7FFE86FECF30
        public void set_localRotation(){} // RVA: 0x7FFE86FECF40
        public void get_lastLocalPosition(){} // RVA: 0x7FFE86FECF50
        public void set_lastLocalPosition(){} // RVA: 0x7FFE86FECF70
        public void get_lastLocalRotation(){} // RVA: 0x7FFE86FECF90
        public void set_lastLocalRotation(){} // RVA: 0x7FFE86FECFA0
        public void get_velocity(){} // RVA: 0x7FFE86FECFB0
        public void set_velocity(){} // RVA: 0x7FFE86FECFD0
        public void get_lastVelocity(){} // RVA: 0x7FFE86FECFF0
        public void set_lastVelocity(){} // RVA: 0x7FFE86FED010
        public void get_angularVelocity(){} // RVA: 0x7FFE86FED030
        public void set_angularVelocity(){} // RVA: 0x7FFE86FED050
        public void get_lastAngularVelocity(){} // RVA: 0x7FFE86FED070
        public void set_lastAngularVelocity(){} // RVA: 0x7FFE86FED090
        public void Preinitialize(){} // RVA: 0x7FFE86FED0B0
        public void Initialize(){} // RVA: 0x7FFE86FED200
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FED310
        public void UpdateValue(){} // RVA: 0x7FFE86FED760 | overloaded x2
        public void SetCacheVariables(){} // RVA: 0x7FFE86FEDF20
        public void GetChanged(){} // RVA: 0x7FFE86FEE040
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFE86FEE310
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFE86FEE740
        public void UpdateTransform(){} // RVA: 0x7FFE86FEEC60
        public void CheckAndSendEvents(){} // RVA: 0x7FFE86FEED40
        public void GetUnityCoordinateVelocity(){} // RVA: 0x7FFE86FEF030 | overloaded x2
        public void GetUnityCoordinateAngularVelocity(){} // RVA: 0x7FFE86FEF050 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE86FEF080
        public void .cctor(){} // RVA: 0x7FFE86FEF0D0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7FFE80E46530
        public void UpdateValues(){} // RVA: 0x7FFE80E466C0
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
    }

    public class SteamVR_Action_Single : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFE86FEF130
        public void remove_onChange(){} // RVA: 0x7FFE86FEF1B0
        public void add_onUpdate(){} // RVA: 0x7FFE86FEF230
        public void remove_onUpdate(){} // RVA: 0x7FFE86FEF2B0
        public void add_onAxis(){} // RVA: 0x7FFE86FEF330
        public void remove_onAxis(){} // RVA: 0x7FFE86FEF3B0
        public void add_onActiveChange(){} // RVA: 0x7FFE86FEF430
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FEF4B0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FEF530
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FEF5B0
        public void get_axis(){} // RVA: 0x7FFE86FEF630
        public void get_lastAxis(){} // RVA: 0x7FFE86FEF6C0
        public void get_delta(){} // RVA: 0x7FFE86FEF750
        public void get_lastDelta(){} // RVA: 0x7FFE86FEF7E0
        public void .ctor(){} // RVA: 0x7FFE86FEF870
        public void GetAxis(){} // RVA: 0x7FFE86FEF8B0
        public void GetAxisDelta(){} // RVA: 0x7FFE86FEF950
        public void GetLastAxis(){} // RVA: 0x7FFE86FEF9F0
        public void GetLastAxisDelta(){} // RVA: 0x7FFE86FEFA90
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE86FEFB30
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE86FEFBB0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFE86FEFC30
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFE86FEFCB0
        public void AddOnChangeListener(){} // RVA: 0x7FFE86FEFD30
        public void RemoveOnChangeListener(){} // RVA: 0x7FFE86FEFDB0
        public void AddOnUpdateListener(){} // RVA: 0x7FFE86FEFE30
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFE86FEFEB0
        public void AddOnAxisListener(){} // RVA: 0x7FFE86FEFF30
        public void RemoveOnAxisListener(){} // RVA: 0x7FFE86FEFFB0
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FF0030
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE86FF00A0
    }

    public class SteamVR_Action_Single_Source : SteamVR_Action_In_Source
    {
        public uint actionData_size;
        public float changeTolerance; // 0x158
        public AxisHandler onAxis; // 0x160
        public ActiveChangeHandler onActiveChange; // 0x168
        public ActiveChangeHandler onActiveBindingChange; // 0x170
        public ChangeHandler onChange; // 0x178
        public UpdateHandler onUpdate; // 0x180
        public bool _changed; // 0x188
        public bool _lastChanged; // 0x189
        public bool _lastActive; // 0x18A
        public Valve.VR.InputAnalogActionData_t actionData; // 0x190
        public Valve.VR.InputAnalogActionData_t lastActionData; // 0x1C0

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7FFE86FF0440
        public void remove_onAxis(){} // RVA: 0x7FFE86FF0530
        public void add_onActiveChange(){} // RVA: 0x7FFE86FF0620
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FF0710
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FF0800
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FF08F0
        public void add_onChange(){} // RVA: 0x7FFE86FF09E0
        public void remove_onChange(){} // RVA: 0x7FFE86FF0AD0
        public void add_onUpdate(){} // RVA: 0x7FFE86FF0BC0
        public void remove_onUpdate(){} // RVA: 0x7FFE86FF0CB0
        public void get_axis(){} // RVA: 0x7FFE86FF0DA0
        public void get_lastAxis(){} // RVA: 0x7FFE86FF0DE0
        public void get_delta(){} // RVA: 0x7FFE86FF0E20
        public void get_lastDelta(){} // RVA: 0x7FFE86FF0E60
        public void get_changed(){} // RVA: 0x7FFE86FF0EA0
        public void set_changed(){} // RVA: 0x7FFE86FF0EB0
        public void get_lastChanged(){} // RVA: 0x7FFE86FF0EC0
        public void set_lastChanged(){} // RVA: 0x7FFE86FF0ED0
        public void get_activeOrigin(){} // RVA: 0x7FFE86FF0EE0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE81B16E90
        public void get_active(){} // RVA: 0x7FFE86FE9640
        public void get_activeBinding(){} // RVA: 0x7FFE86FE96E0
        public void get_lastActive(){} // RVA: 0x7FFE86FF0F20
        public void set_lastActive(){} // RVA: 0x7FFE86FF0F30
        public void get_lastActiveBinding(){} // RVA: 0x7FFE86FE95A0
        public void Preinitialize(){} // RVA: 0x7FFE86FF0F40
        public void Initialize(){} // RVA: 0x7FFE86FF10D0
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FF11B0
        public void UpdateValue(){} // RVA: 0x7FFE86FF14B0
        public void .ctor(){} // RVA: 0x7FFE86FF1CB0
    }

    public class SteamVR_Action_Single_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FF0400
    }

    public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base`2
    {
        public int numBones;
        public UnityEngine.Quaternion steamVRFixUpRotation;
        public object onActiveChange; // 0x27
        public ActiveChangeHandler onValidPoseChanged; // 0xBDC0
        public object field_4;
        public object field_5; // 0xC226
        public object field_6; // 0xA090
        public object field_7; // 0x1600
        public object field_8; // 0xBF78
        public object field_9; // 0x2C
        public DeviceConnectedChangeHandler onValidPoseChanged; // 0xC130
        public object field_11; // 0xA090
        public object field_12; // 0xA090
        public object field_13; // 0xA090
        public object field_14; // 0xA090
        public object field_15; // 0xA090
        public object field_16; // 0xA090
        public object field_17; // 0xA090
        public object field_18; // 0xA090
        public object field_19; // 0xA090
        public object field_20; // 0xA090
        public object field_21; // 0xA090
        public object field_22; // 0xA090
        public object field_23; // 0xA090
        public object field_24; // 0xA090
        public object field_25; // 0xA090
        public object field_26; // 0xA090
        public object field_27; // 0xA090
        public object field_28; // 0xA090
        public object field_29; // 0xA090
        public object field_30; // 0xA090
        public object field_31; // 0xA090
        public object field_32; // 0xA090

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFE86FF1D00
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FF1D80
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FF1E00
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FF1F40
        public void add_onChange(){} // RVA: 0x7FFE86FF1FC0
        public void remove_onChange(){} // RVA: 0x7FFE86FF2040
        public void add_onUpdate(){} // RVA: 0x7FFE86FF20C0
        public void remove_onUpdate(){} // RVA: 0x7FFE86FF2140
        public void add_onTrackingChanged(){} // RVA: 0x7FFE86FF21C0
        public void remove_onTrackingChanged(){} // RVA: 0x7FFE86FF2240
        public void add_onValidPoseChanged(){} // RVA: 0x7FFE86FF22C0
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFE86FF2340
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FF23C0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FF2440
        public void .ctor(){} // RVA: 0x7FFE86FF24C0
        public void UpdateValue(){} // RVA: 0x7FFE86FF2510
        public void UpdateValueWithoutEvents(){} // RVA: 0x7FFE86FF2590
        public void UpdateTransform(){} // RVA: 0x7FFE86FF2610
        public void get_bonePositions(){} // RVA: 0x7FFE86FF2740
        public void get_boneRotations(){} // RVA: 0x7FFE86FF27A0
        public void get_lastBonePositions(){} // RVA: 0x7FFE86FF2800
        public void get_lastBoneRotations(){} // RVA: 0x7FFE86FF2860
        public void get_rangeOfMotion(){} // RVA: 0x7FFE86FF28C0
        public void set_rangeOfMotion(){} // RVA: 0x7FFE86FF2920
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFE86FF2990
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFE86FF29F0
        public void get_summaryDataType(){} // RVA: 0x7FFE86FF2A60
        public void set_summaryDataType(){} // RVA: 0x7FFE86FF2AC0
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFE86FF2B30
        public void get_thumbCurl(){} // RVA: 0x7FFE86FF2BA0
        public void get_indexCurl(){} // RVA: 0x7FFE86FF2C20
        public void get_middleCurl(){} // RVA: 0x7FFE86FF2CA0
        public void get_ringCurl(){} // RVA: 0x7FFE86FF2D20
        public void get_pinkyCurl(){} // RVA: 0x7FFE86FF2DA0
        public void get_thumbIndexSplay(){} // RVA: 0x7FFE86FF2E20
        public void get_indexMiddleSplay(){} // RVA: 0x7FFE86FF2EA0
        public void get_middleRingSplay(){} // RVA: 0x7FFE86FF2F20
        public void get_ringPinkySplay(){} // RVA: 0x7FFE86FF2FA0
        public void get_lastThumbCurl(){} // RVA: 0x7FFE86FF3020
        public void get_lastIndexCurl(){} // RVA: 0x7FFE86FF30A0
        public void get_lastMiddleCurl(){} // RVA: 0x7FFE86FF3120
        public void get_lastRingCurl(){} // RVA: 0x7FFE86FF31A0
        public void get_lastPinkyCurl(){} // RVA: 0x7FFE86FF3220
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFE86FF32A0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFE86FF3320
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFE86FF33A0
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFE86FF3420
        public void get_fingerCurls(){} // RVA: 0x7FFE86FF34A0
        public void get_fingerSplays(){} // RVA: 0x7FFE86FF3500
        public void get_lastFingerCurls(){} // RVA: 0x7FFE86FF3560
        public void get_lastFingerSplays(){} // RVA: 0x7FFE86FF35C0
        public void get_poseChanged(){} // RVA: 0x7FFE86FF3620
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFE86FF3680
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFE86FF36E0
        public void GetActive(){} // RVA: 0x7FFE86FF3750
        public void GetSetActive(){} // RVA: 0x7FFE86FE2760
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFE86FF37C0
        public void GetPoseAtTimeOffset(){} // RVA: 0x7FFE86FF3860
        public void GetLocalPosition(){} // RVA: 0x7FFE86FF3900
        public void GetLocalRotation(){} // RVA: 0x7FFE86FF3980
        public void GetVelocity(){} // RVA: 0x7FFE86FF3A00
        public void GetAngularVelocity(){} // RVA: 0x7FFE86FF3A80
        public void GetDeviceIsConnected(){} // RVA: 0x7FFE86FF3B00
        public void GetPoseIsValid(){} // RVA: 0x7FFE86FF3B60
        public void GetTrackingResult(){} // RVA: 0x7FFE86FF3BC0
        public void GetLastLocalPosition(){} // RVA: 0x7FFE86FF3C20
        public void GetLastLocalRotation(){} // RVA: 0x7FFE86FF3CA0
        public void GetLastVelocity(){} // RVA: 0x7FFE86FF3D20
        public void GetLastAngularVelocity(){} // RVA: 0x7FFE86FF3DA0
        public void GetLastDeviceIsConnected(){} // RVA: 0x7FFE86FF3E20
        public void GetLastPoseIsValid(){} // RVA: 0x7FFE86FF3E80
        public void GetLastTrackingResult(){} // RVA: 0x7FFE86FF3EE0
        public void get_boneCount(){} // RVA: 0x7FFE86FF3F40
        public void GetBonePositions(){} // RVA: 0x7FFE86FF3FB0
        public void GetBoneRotations(){} // RVA: 0x7FFE86FF40A0
        public void GetLastBonePositions(){} // RVA: 0x7FFE86FF4190
        public void GetLastBoneRotations(){} // RVA: 0x7FFE86FF4280
        public void SetRangeOfMotion(){} // RVA: 0x7FFE86FF4370
        public void SetSkeletalTransformSpace(){} // RVA: 0x7FFE86FF43E0
        public void GetBoneCount(){} // RVA: 0x7FFE86FF3F40
        public void GetBoneHierarchy(){} // RVA: 0x7FFE86FF4450
        public void GetBoneName(){} // RVA: 0x7FFE86FF44C0
        public void GetReferenceTransforms(){} // RVA: 0x7FFE86FF4530
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFE86FF45B0
        public void GetFingerCurls(){} // RVA: 0x7FFE86FF4620
        public void GetLastFingerCurls(){} // RVA: 0x7FFE86FF4710
        public void GetFingerSplays(){} // RVA: 0x7FFE86FF4800
        public void GetLastFingerSplays(){} // RVA: 0x7FFE86FF48F0
        public void GetFingerCurl(){} // RVA: 0x7FFE86FF49E0 | overloaded x2
        public void GetSplay(){} // RVA: 0x7FFE86FF4A70 | overloaded x2
        public void GetLastFingerCurl(){} // RVA: 0x7FFE86FF4B00 | overloaded x2
        public void GetLastSplay(){} // RVA: 0x7FFE86FF4B90 | overloaded x2
        public void GetLocalizedName(){} // RVA: 0x7FFE86FF4C20
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FF4CA0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7FFE86FF4D20
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7FFE86FF4DA0
        public void AddOnTrackingChanged(){} // RVA: 0x7FFE86FF4E20
        public void RemoveOnTrackingChanged(){} // RVA: 0x7FFE86FF4EA0
        public void AddOnValidPoseChanged(){} // RVA: 0x7FFE86FF4F20
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7FFE86FF4FA0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE86FF5020
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE86FF50A0
        public void AddOnChangeListener(){} // RVA: 0x7FFE86FF5120
        public void RemoveOnChangeListener(){} // RVA: 0x7FFE86FF51A0
        public void AddOnUpdateListener(){} // RVA: 0x7FFE86FF5220
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFE86FF52A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE86FF5320
        public void .cctor(){} // RVA: 0x7FFE86FF5360
    }

    public class SteamVR_Action_Skeleton_Source : SteamVR_Action_Pose_Source
    {
        public uint skeletonActionData_size;
        public ActiveChangeHandler onActiveChange; // 0x330
        public ActiveChangeHandler onActiveBindingChange; // 0x338
        public ChangeHandler onChange; // 0x340
        public UpdateHandler onUpdate; // 0x348
        public TrackingChangeHandler onTrackingChanged; // 0x350
        public ValidPoseChangeHandler onValidPoseChanged; // 0x358
        public DeviceConnectedChangeHandler onDeviceConnectedChanged; // 0x360
        public UnityEngine.Vector3[] _bonePositions; // 0x368
        public UnityEngine.Quaternion[] _boneRotations; // 0x370
        public UnityEngine.Vector3[] _lastBonePositions; // 0x378
        public UnityEngine.Quaternion[] _lastBoneRotations; // 0x380
        public 0x6663A234 _rangeOfMotion; // 0x388
        public 0x6663AE94 _skeletalTransformSpace; // 0x38C
        public 0x6663AFF4 _summaryDataType; // 0x390
        public float[] _fingerCurls; // 0x398
        public float[] _fingerSplays; // 0x3A0
        public float[] _lastFingerCurls; // 0x3A8
        public float[] _lastFingerSplays; // 0x3B0
        public bool _poseChanged; // 0x3B8
        public bool _onlyUpdateSummaryData; // 0x3B9
        public Valve.VR.VRSkeletalSummaryData_t skeletalSummaryData; // 0x3BC
        public Valve.VR.VRSkeletalSummaryData_t lastSkeletalSummaryData; // 0x3E0
        public Valve.VR.SteamVR_Action_Skeleton skeletonAction; // 0x408
        public Valve.VR.VRBoneTransform_t[] tempBoneTransforms; // 0x410
        public Valve.VR.InputSkeletalActionData_t skeletonActionData; // 0x418
        public Valve.VR.InputSkeletalActionData_t lastSkeletonActionData; // 0x428
        public Valve.VR.InputSkeletalActionData_t tempSkeletonActionData; // 0x438
        public object field_28; // 0x4570
        public Valve.VR.SteamVR_Action_Skeleton_Source_Map field_29; // 0x9AE8
        public object field_30; // 0x7250
        public object field_31; // 0x15
        public object field_32; // 0x6658
        public object field_33; // 0x9C68
        public object field_34; // 0x9E20
        public object field_35; // 0x9FD8

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFE86FF5700
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FF57F0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FF58E0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FF59D0
        public void add_onChange(){} // RVA: 0x7FFE86FF5AC0
        public void remove_onChange(){} // RVA: 0x7FFE86FF5BB0
        public void add_onUpdate(){} // RVA: 0x7FFE86FF5CA0
        public void remove_onUpdate(){} // RVA: 0x7FFE86FF5D90
        public void add_onTrackingChanged(){} // RVA: 0x7FFE86FF5E80
        public void remove_onTrackingChanged(){} // RVA: 0x7FFE86FF5F70
        public void add_onValidPoseChanged(){} // RVA: 0x7FFE86FF6060
        public void remove_onValidPoseChanged(){} // RVA: 0x7FFE86FF6150
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FF6240
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7FFE86FF6330
        public void get_activeBinding(){} // RVA: 0x7FFE86078790
        public void get_lastActiveBinding(){} // RVA: 0x7FFE86FF6420
        public void get_bonePositions(){} // RVA: 0x7FFE81B12230
        public void set_bonePositions(){} // RVA: 0x7FFE81B33AA0
        public void get_boneRotations(){} // RVA: 0x7FFE81B16E20
        public void set_boneRotations(){} // RVA: 0x7FFE81B30620
        public void get_lastBonePositions(){} // RVA: 0x7FFE81B267A0
        public void set_lastBonePositions(){} // RVA: 0x7FFE81B353B0
        public void get_lastBoneRotations(){} // RVA: 0x7FFE81B32DA0
        public void set_lastBoneRotations(){} // RVA: 0x7FFE81B0DE60
        public void get_rangeOfMotion(){} // RVA: 0x7FFE86FF6430
        public void set_rangeOfMotion(){} // RVA: 0x7FFE86FF6440
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFE84D35B60
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFE84D35B70
        public void get_summaryDataType(){} // RVA: 0x7FFE84D35B00
        public void set_summaryDataType(){} // RVA: 0x7FFE86FF6450
        public void get_thumbCurl(){} // RVA: 0x7FFE86FF6460
        public void get_indexCurl(){} // RVA: 0x7FFE86FF6490
        public void get_middleCurl(){} // RVA: 0x7FFE86FF64C0
        public void get_ringCurl(){} // RVA: 0x7FFE86FF64F0
        public void get_pinkyCurl(){} // RVA: 0x7FFE86FF6520
        public void get_thumbIndexSplay(){} // RVA: 0x7FFE86FF6550
        public void get_indexMiddleSplay(){} // RVA: 0x7FFE86FF6580
        public void get_middleRingSplay(){} // RVA: 0x7FFE86FF65B0
        public void get_ringPinkySplay(){} // RVA: 0x7FFE86FF65E0
        public void get_lastThumbCurl(){} // RVA: 0x7FFE86FF6610
        public void get_lastIndexCurl(){} // RVA: 0x7FFE86FF6640
        public void get_lastMiddleCurl(){} // RVA: 0x7FFE86FF6670
        public void get_lastRingCurl(){} // RVA: 0x7FFE86FF66A0
        public void get_lastPinkyCurl(){} // RVA: 0x7FFE86FF66D0
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFE86FF6700
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFE86FF6730
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFE86FF6760
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFE86FF6790
        public void get_fingerCurls(){} // RVA: 0x7FFE81B13B90
        public void set_fingerCurls(){} // RVA: 0x7FFE81B07B60
        public void get_fingerSplays(){} // RVA: 0x7FFE81B08D80
        public void set_fingerSplays(){} // RVA: 0x7FFE81B31360
        public void get_lastFingerCurls(){} // RVA: 0x7FFE81B20C20
        public void set_lastFingerCurls(){} // RVA: 0x7FFE81B332D0
        public void get_lastFingerSplays(){} // RVA: 0x7FFE816544C0
        public void set_lastFingerSplays(){} // RVA: 0x7FFE81B0A7C0
        public void get_poseChanged(){} // RVA: 0x7FFE86FF67C0
        public void set_poseChanged(){} // RVA: 0x7FFE86FF67D0
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFE86FF67E0
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFE86FF67F0
        public void Preinitialize(){} // RVA: 0x7FFE86FF6800
        public void Initialize(){} // RVA: 0x7FFE86FF6ED0
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FF70A0
        public void UpdateValue(){} // RVA: 0x7FFE86FF74D0 | overloaded x2
        public void get_boneCount(){} // RVA: 0x7FFE86FF8420
        public void GetBoneCount(){} // RVA: 0x7FFE86FF8430
        public void get_boneHierarchy(){} // RVA: 0x7FFE86FF86F0
        public void GetBoneHierarchy(){} // RVA: 0x7FFE86FF8700
        public void GetBoneName(){} // RVA: 0x7FFE86FF8A00
        public void GetReferenceTransforms(){} // RVA: 0x7FFE86FF8D60
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFE86FF93C0
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFE86FF93D0
        public void GetSkeletalSummaryData(){} // RVA: 0x7FFE86FF9620
        public void UpdateSkeletalSummaryData(){} // RVA: 0x7FFE86FF9680
        public void CheckAndSendEvents(){} // RVA: 0x7FFE86FF9A30
        public void .ctor(){} // RVA: 0x7FFE86FF9C70
    }

    public class SteamVR_Action_Skeleton_Source_Map : SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void GetSourceElementForIndexer(){} // RVA: 0x7FFE86FF5680
        public void .ctor(){} // RVA: 0x7FFE86FF56B0
    }

    public class SteamVR_Action_Source : Object
    {
        public 0x6660354C _inputSource; // 0x10
        public ulong inputSourceHandle; // 0x18
        public Valve.VR.SteamVR_Action action; // 0x20
        public uint inputOriginInfo_size;
        public bool _isUpdating; // 0x28
        public float _updateTime; // 0x2C
        public float _changedTime; // 0x30
        public int _lastOriginGetFrame; // 0x34
        public Valve.VR.InputOriginInfo_t inputOriginInfo; // 0x38
        public Valve.VR.InputOriginInfo_t lastInputOriginInfo; // 0xC8

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x7FFE86FE3930
        public void get_handle(){} // RVA: 0x7FFE86FE3960
        public void get_actionSet(){} // RVA: 0x7FFE86FE3990
        public void get_direction(){} // RVA: 0x7FFE86FE39C0
        public void get_inputSource(){} // RVA: 0x7FFE811485C0
        public void set_inputSource(){} // RVA: 0x7FFE810FE0C0
        public void get_setActive(){} // RVA: 0x7FFE86FE39F0
        public void get_active(){} // RVA: 0x7FFE80E2F150
        public void get_activeBinding(){} // RVA: 0x7FFE80E2F150
        public void get_lastActive(){} // RVA: 0x7FFE80E2F150
        public void set_lastActive(){} // RVA: 0x7FFE80E466C0
        public void get_lastActiveBinding(){} // RVA: 0x7FFE80E2F150
        public void Preinitialize(){} // RVA: 0x7FFE86FE3A80
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE86FE3AE0
    }

    public class SteamVR_Action_Source_Map : Object
    {
        public string _fullPath; // 0x10
        public ulong _handle; // 0x18
        public Valve.VR.SteamVR_ActionSet _actionSet; // 0x20
        public 0x666000B4 _direction; // 0x28

        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x7FFE81116380
        public void set_fullPath(){} // RVA: 0x7FFE810FCE30
        public void get_handle(){} // RVA: 0x7FFE810FE7C0
        public void set_handle(){} // RVA: 0x7FFE819EA910
        public void get_actionSet(){} // RVA: 0x7FFE811290C0
        public void set_actionSet(){} // RVA: 0x7FFE811290D0
        public void get_direction(){} // RVA: 0x7FFE81549710
        public void set_direction(){} // RVA: 0x7FFE817E4800
        public void PreInitialize(){} // RVA: 0x7FFE86FE2F40
        public void PreinitializeMap(){} // RVA: 0x7FFE80E48220
        public void Initialize(){} // RVA: 0x7FFE86FE3190
        public void GetActionSetPath(){} // RVA: 0x7FFE86FE3380
        public void GetActionDirection(){} // RVA: 0x7FFE86FE3400
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE86FE3610
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public T[] sources; // 0x38

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE84D052B0
        public void OnAccessSource(){} // RVA: 0x7FFE810FB310
        public void Initialize(){} // RVA: 0x7FFE84D052D0
        public void PreinitializeMap(){} // RVA: 0x7FFE84D05360
        public void GetSourceElementForIndexer(){} // RVA: 0x7FFE84D05400
        public void .ctor(){} // RVA: 0x7FFE84D05450
    }

    public class SteamVR_Action_Vector2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFE86FFA310
        public void remove_onChange(){} // RVA: 0x7FFE86FFA390
        public void add_onUpdate(){} // RVA: 0x7FFE86FFA410
        public void remove_onUpdate(){} // RVA: 0x7FFE86FFA490
        public void add_onAxis(){} // RVA: 0x7FFE86FFA510
        public void remove_onAxis(){} // RVA: 0x7FFE86FFA590
        public void add_onActiveChange(){} // RVA: 0x7FFE86FFA610
        public void remove_onActiveChange(){} // RVA: 0x7FFE86FFA690
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE86FFA710
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE86FFA790
        public void get_axis(){} // RVA: 0x7FFE86FFA810
        public void get_lastAxis(){} // RVA: 0x7FFE86FFA890
        public void get_delta(){} // RVA: 0x7FFE86FFA910
        public void get_lastDelta(){} // RVA: 0x7FFE86FFA990
        public void .ctor(){} // RVA: 0x7FFE86FFAA10
        public void GetAxis(){} // RVA: 0x7FFE86FFAA50
        public void GetAxisDelta(){} // RVA: 0x7FFE86FFAAD0
        public void GetLastAxis(){} // RVA: 0x7FFE86FFAB50
        public void GetLastAxisDelta(){} // RVA: 0x7FFE86FFABD0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE86FFAC50
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE86FFACD0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFE86FFAD50
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFE86FFADD0
        public void AddOnChangeListener(){} // RVA: 0x7FFE86FFAE50
        public void RemoveOnChangeListener(){} // RVA: 0x7FFE86FFAED0
        public void AddOnUpdateListener(){} // RVA: 0x7FFE86FFAF50
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFE86FFAFD0
        public void AddOnAxisListener(){} // RVA: 0x7FFE86FFB050
        public void RemoveOnAxisListener(){} // RVA: 0x7FFE86FFB0D0
        public void RemoveAllListeners(){} // RVA: 0x7FFE86FFB150
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE86FFB1C0
    }

    public class SteamVR_Action_Vector2_Source : SteamVR_Action_In_Source
    {
        public uint actionData_size;
        public float changeTolerance; // 0x158
        public AxisHandler onAxis; // 0x160
        public ActiveChangeHandler onActiveChange; // 0x168
        public ActiveChangeHandler onActiveBindingChange; // 0x170
        public ChangeHandler onChange; // 0x178
        public UpdateHandler onUpdate; // 0x180
        public UnityEngine.Vector2 _axis; // 0x188
        public UnityEngine.Vector2 _lastAxis; // 0x190
        public UnityEngine.Vector2 _delta; // 0x198
        public UnityEngine.Vector2 _lastDelta; // 0x1A0
        public bool _changed; // 0x1A8

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7FFE87011090
        public void remove_onAxis(){} // RVA: 0x7FFE87011180
        public void add_onActiveChange(){} // RVA: 0x7FFE87011270
        public void remove_onActiveChange(){} // RVA: 0x7FFE87011360
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE87011450
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE87011540
        public void add_onChange(){} // RVA: 0x7FFE87011630
        public void remove_onChange(){} // RVA: 0x7FFE87011720
        public void add_onUpdate(){} // RVA: 0x7FFE87011810
        public void remove_onUpdate(){} // RVA: 0x7FFE87011900
        public void get_axis(){} // RVA: 0x7FFE82253620
        public void set_axis(){} // RVA: 0x7FFE870119F0
        public void get_lastAxis(){} // RVA: 0x7FFE87011A00
        public void set_lastAxis(){} // RVA: 0x7FFE87011A20
        public void get_delta(){} // RVA: 0x7FFE87011A30
        public void set_delta(){} // RVA: 0x7FFE87011A50
        public void get_lastDelta(){} // RVA: 0x7FFE87011A60
        public void set_lastDelta(){} // RVA: 0x7FFE87011A80
        public void get_changed(){} // RVA: 0x7FFE87011A90
        public void set_changed(){} // RVA: 0x7FFE87011AA0
        public void get_lastChanged(){} // RVA: 0x7FFE87011AB0
        public void set_lastChanged(){} // RVA: 0x7FFE87011AC0
        public void get_activeOrigin(){} // RVA: 0x7FFE87011AD0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE81B27D50
        public void get_active(){} // RVA: 0x7FFE86FE9640
        public void get_activeBinding(){} // RVA: 0x7FFE86FE9700
        public void get_lastActive(){} // RVA: 0x7FFE87011B10
        public void set_lastActive(){} // RVA: 0x7FFE87011B20
        public void get_lastActiveBinding(){} // RVA: 0x7FFE87011B30
        public void Preinitialize(){} // RVA: 0x7FFE87011B40
        public void Initialize(){} // RVA: 0x7FFE87011CD0
        public void RemoveAllListeners(){} // RVA: 0x7FFE87011DB0
        public void UpdateValue(){} // RVA: 0x7FFE870120B0
        public void .ctor(){} // RVA: 0x7FFE870128A0
    }

    public class SteamVR_Action_Vector2_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87011050
    }

    public class SteamVR_Action_Vector3 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7FFE870128F0
        public void remove_onChange(){} // RVA: 0x7FFE87012970
        public void add_onUpdate(){} // RVA: 0x7FFE870129F0
        public void remove_onUpdate(){} // RVA: 0x7FFE87012A70
        public void add_onAxis(){} // RVA: 0x7FFE87012AF0
        public void remove_onAxis(){} // RVA: 0x7FFE87012B70
        public void add_onActiveChange(){} // RVA: 0x7FFE87012BF0
        public void remove_onActiveChange(){} // RVA: 0x7FFE87012C70
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE87012CF0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE87012D70
        public void get_axis(){} // RVA: 0x7FFE87012DF0
        public void get_lastAxis(){} // RVA: 0x7FFE87012E70
        public void get_delta(){} // RVA: 0x7FFE87012EF0
        public void get_lastDelta(){} // RVA: 0x7FFE87012F70
        public void .ctor(){} // RVA: 0x7FFE87012FF0
        public void GetAxis(){} // RVA: 0x7FFE87013030
        public void GetAxisDelta(){} // RVA: 0x7FFE870130C0
        public void GetLastAxis(){} // RVA: 0x7FFE87013150
        public void GetLastAxisDelta(){} // RVA: 0x7FFE870131E0
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE87013270
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE870132F0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFE87013370
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFE870133F0
        public void AddOnChangeListener(){} // RVA: 0x7FFE87013470
        public void RemoveOnChangeListener(){} // RVA: 0x7FFE870134F0
        public void AddOnUpdateListener(){} // RVA: 0x7FFE87013570
        public void RemoveOnUpdateListener(){} // RVA: 0x7FFE870135F0
        public void AddOnAxisListener(){} // RVA: 0x7FFE87013670
        public void RemoveOnAxisListener(){} // RVA: 0x7FFE870136F0
        public void RemoveAllListeners(){} // RVA: 0x7FFE87013770
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE870137E0
    }

    public class SteamVR_Action_Vector3_Source : SteamVR_Action_In_Source
    {
        public uint actionData_size;
        public float changeTolerance; // 0x158
        public AxisHandler onAxis; // 0x160
        public ActiveChangeHandler onActiveChange; // 0x168
        public ActiveChangeHandler onActiveBindingChange; // 0x170
        public ChangeHandler onChange; // 0x178
        public UpdateHandler onUpdate; // 0x180
        public UnityEngine.Vector3 _axis; // 0x188
        public UnityEngine.Vector3 _lastAxis; // 0x194
        public UnityEngine.Vector3 _delta; // 0x1A0
        public UnityEngine.Vector3 _lastDelta; // 0x1AC
        public bool _changed; // 0x1B8

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7FFE87013B80
        public void remove_onAxis(){} // RVA: 0x7FFE87013C70
        public void add_onActiveChange(){} // RVA: 0x7FFE87013D60
        public void remove_onActiveChange(){} // RVA: 0x7FFE87013E50
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE87013F40
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE87014030
        public void add_onChange(){} // RVA: 0x7FFE87014120
        public void remove_onChange(){} // RVA: 0x7FFE87014210
        public void add_onUpdate(){} // RVA: 0x7FFE87014300
        public void remove_onUpdate(){} // RVA: 0x7FFE870143F0
        public void get_axis(){} // RVA: 0x7FFE870144E0
        public void set_axis(){} // RVA: 0x7FFE87014500
        public void get_lastAxis(){} // RVA: 0x7FFE87014520
        public void set_lastAxis(){} // RVA: 0x7FFE87014540
        public void get_delta(){} // RVA: 0x7FFE87014560
        public void set_delta(){} // RVA: 0x7FFE87014580
        public void get_lastDelta(){} // RVA: 0x7FFE870145A0
        public void set_lastDelta(){} // RVA: 0x7FFE870145C0
        public void get_changed(){} // RVA: 0x7FFE86EE84C0
        public void set_changed(){} // RVA: 0x7FFE86EE84D0
        public void get_lastChanged(){} // RVA: 0x7FFE870145E0
        public void set_lastChanged(){} // RVA: 0x7FFE870145F0
        public void get_activeOrigin(){} // RVA: 0x7FFE87014600
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE81B20B40
        public void get_active(){} // RVA: 0x7FFE86FE9640
        public void get_activeBinding(){} // RVA: 0x7FFE86FE95A0
        public void get_lastActive(){} // RVA: 0x7FFE87014640
        public void set_lastActive(){} // RVA: 0x7FFE87014650
        public void get_lastActiveBinding(){} // RVA: 0x7FFE87014660
        public void Preinitialize(){} // RVA: 0x7FFE87014670
        public void Initialize(){} // RVA: 0x7FFE87014800
        public void RemoveAllListeners(){} // RVA: 0x7FFE870148E0
        public void UpdateValue(){} // RVA: 0x7FFE87014BE0
        public void .ctor(){} // RVA: 0x7FFE87015410
    }

    public class SteamVR_Action_Vector3_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87013B40
    }

    public class SteamVR_Action_Vibration : SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFE87015460
        public void remove_onActiveChange(){} // RVA: 0x7FFE870154E0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE87015560
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE870155E0
        public void add_onExecute(){} // RVA: 0x7FFE87015660
        public void remove_onExecute(){} // RVA: 0x7FFE870156E0
        public void .ctor(){} // RVA: 0x7FFE87015760
        public void Execute(){} // RVA: 0x7FFE87015800
        public void AddOnActiveChangeListener(){} // RVA: 0x7FFE870158B0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7FFE87015930
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7FFE870159B0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7FFE87015A30
        public void AddOnExecuteListener(){} // RVA: 0x7FFE87015AB0
        public void RemoveOnExecuteListener(){} // RVA: 0x7FFE87015B30
        public void RemoveAllListeners(){} // RVA: 0x7FFE87015BB0
        public void GetTimeLastChanged(){} // RVA: 0x7FFE87015C20
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87015C90
        public void IsUpdating(){} // RVA: 0x7FFE87015CD0
    }

    public class SteamVR_Action_Vibration_Source : SteamVR_Action_Out_Source
    {
        public ActiveChangeHandler onActiveChange; // 0x28
        public ActiveChangeHandler onActiveBindingChange; // 0x30
        public ExecuteHandler onExecute; // 0x38
        public bool _lastActive; // 0x40
        public float _timeLastExecuted; // 0x44

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7FFE870160F0
        public void remove_onActiveChange(){} // RVA: 0x7FFE870161E0
        public void add_onActiveBindingChange(){} // RVA: 0x7FFE870162D0
        public void remove_onActiveBindingChange(){} // RVA: 0x7FFE870163C0
        public void add_onExecute(){} // RVA: 0x7FFE870164B0
        public void remove_onExecute(){} // RVA: 0x7FFE870165A0
        public void get_active(){} // RVA: 0x7FFE86FE9640
        public void get_activeBinding(){} // RVA: 0x7FFE811E0850
        public void get_lastActive(){} // RVA: 0x7FFE811B6C00
        public void set_lastActive(){} // RVA: 0x7FFE811B6C10
        public void get_lastActiveBinding(){} // RVA: 0x7FFE811E0850
        public void get_timeLastExecuted(){} // RVA: 0x7FFE81103970
        public void set_timeLastExecuted(){} // RVA: 0x7FFE81103980
        public void Initialize(){} // RVA: 0x7FFE87016690
        public void Preinitialize(){} // RVA: 0x7FFE87016710
        public void RemoveAllListeners(){} // RVA: 0x7FFE87016890
        public void Execute(){} // RVA: 0x7FFE87016A50
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Action_Vibration_Source_Map : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x7FFE87016060
        public void .ctor(){} // RVA: 0x7FFE870160B0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public T sourceMap; // 0x28
        public bool initialized; // 0x30
        public uint inputBindingInfo_size;
        public Valve.VR.InputBindingInfo_t[] zeroLengthBindingInfos; // 0x8
        public object field_4;
        public void field_5;
        public object field_6;
        public object field_7;
        public object field_8;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x7FFE84D05560
        public void get_fullPath(){} // RVA: 0x7FFE84D05590
        public void get_handle(){} // RVA: 0x7FFE84D055B0
        public void get_actionSet(){} // RVA: 0x7FFE84D055D0
        public void get_direction(){} // RVA: 0x7FFE84D055F0
        public void get_active(){} // RVA: 0x7FFE84D05610
        public void get_lastActive(){} // RVA: 0x7FFE84D05660
        public void get_activeBinding(){} // RVA: 0x7FFE84D056B0
        public void get_lastActiveBinding(){} // RVA: 0x7FFE84D05700
        public void PreInitialize(){} // RVA: 0x7FFE84D05750
        public void CreateUninitialized(){} // RVA: 0x7FFE84D05970 | overloaded x2
        public void TryNeedsInitData(){} // RVA: 0x7FFE84D05B70
        public void Initialize(){} // RVA: 0x7FFE84D05E30
        public void GetSourceMap(){} // RVA: 0x7FFE81129130
        public void InitializeCopy(){} // RVA: 0x7FFE84D05F40
        public void InitAfterDeserialize(){} // RVA: 0x7FFE84D060C0
        public void GetActive(){} // RVA: 0x7FFE84D06170
        public void GetActiveBinding(){} // RVA: 0x7FFE84D061C0
        public void GetLastActive(){} // RVA: 0x7FFE84D06210
        public void GetLastActiveBinding(){} // RVA: 0x7FFE84D06260
        public void GetActionBindingInfo(){} // RVA: 0x7FFE84D062B0
        public void .ctor(){} // RVA: 0x7FFE84D06940
        public void .cctor(){} // RVA: 0x7FFE84D06990
    }

    public class SteamVR_Actions : Object
    {
        public Valve.VR.SteamVR_Action_Boolean p_global_Safe_Mode;
        public Valve.VR.SteamVR_Action_Pose p_global_Pose; // 0x8
        public Valve.VR.SteamVR_Action_Skeleton p_global_SkeletonLeftHand; // 0x10
        public Valve.VR.SteamVR_Action_Skeleton p_global_SkeletonRightHand; // 0x18
        public Valve.VR.SteamVR_Action_Boolean p_global_HeadsetOnHead; // 0x20
        public Valve.VR.SteamVR_Action_Boolean p_global_Menu; // 0x28
        public Valve.VR.SteamVR_Action_Boolean p_global_Quick_Menu; // 0x30
        public Valve.VR.SteamVR_Action_Boolean p_global_Action_Menu; // 0x38
        public Valve.VR.SteamVR_Action_Boolean p_global_Main_Menu; // 0x40
        public Valve.VR.SteamVR_Action_Boolean p_global_Interact; // 0x48
        public Valve.VR.SteamVR_Action_Boolean p_global_Grab; // 0x50
        public Valve.VR.SteamVR_Action_Vector2 p_global_Move; // 0x58
        public Valve.VR.SteamVR_Action_Boolean p_global_Jump; // 0x60
        public Valve.VR.SteamVR_Action_Vector2 p_global_Rotate; // 0x68
        public Valve.VR.SteamVR_Action_Boolean p_global_Mic; // 0x70
        public Valve.VR.SteamVR_Action_Boolean p_global_Gesture_Toggle; // 0x78
        public Valve.VR.SteamVR_Action_Boolean p_global_Stick_Click; // 0x80
        public Valve.VR.SteamVR_Action_Single p_global_Trigger_Axis; // 0x88
        public Valve.VR.SteamVR_Action_Single p_global_Grip_Axis; // 0x90
        public Valve.VR.SteamVR_Action_Boolean p_global_Udon_Menu; // 0x98
        public Valve.VR.SteamVR_Action_Boolean p_global_Drop; // 0xA0
        public Valve.VR.SteamVR_Action_Boolean p_global_Nameplates; // 0xA8
        public Valve.VR.SteamVR_Action_Boolean p_global_HUD; // 0xB0
        public Valve.VR.SteamVR_Action_Boolean p_global_Chatbox; // 0xB8
        public Valve.VR.SteamVR_Action_Boolean p_global_Face_Mirror; // 0xC0
        public Valve.VR.SteamVR_Action_Boolean p_global_Personal_Mirror; // 0xC8
        public Valve.VR.SteamVR_Action_Boolean p_global_Personal_Mirror_Lock; // 0xD0
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
        public void get_global_Safe_Mode(){} // RVA: 0x7FFE86FFC0B0
        public void get_global_Pose(){} // RVA: 0x7FFE86FFC120
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7FFE86FFC190
        public void get_global_SkeletonRightHand(){} // RVA: 0x7FFE86FFC200
        public void get_global_HeadsetOnHead(){} // RVA: 0x7FFE86FFC270
        public void get_global_Menu(){} // RVA: 0x7FFE86FFC2E0
        public void get_global_Quick_Menu(){} // RVA: 0x7FFE86FFC350
        public void get_global_Action_Menu(){} // RVA: 0x7FFE86FFC3C0
        public void get_global_Main_Menu(){} // RVA: 0x7FFE86FFC430
        public void get_global_Interact(){} // RVA: 0x7FFE86FFC4A0
        public void get_global_Grab(){} // RVA: 0x7FFE86FFC510
        public void get_global_Move(){} // RVA: 0x7FFE86FFC580
        public void get_global_Jump(){} // RVA: 0x7FFE86FFC5F0
        public void get_global_Rotate(){} // RVA: 0x7FFE86FFC660
        public void get_global_Mic(){} // RVA: 0x7FFE86FFC6D0
        public void get_global_Gesture_Toggle(){} // RVA: 0x7FFE86FFC740
        public void get_global_Stick_Click(){} // RVA: 0x7FFE86FFC7B0
        public void get_global_Trigger_Axis(){} // RVA: 0x7FFE86FFC820
        public void get_global_Grip_Axis(){} // RVA: 0x7FFE86FFC890
        public void get_global_Udon_Menu(){} // RVA: 0x7FFE86FFC900
        public void get_global_Drop(){} // RVA: 0x7FFE86FFC970
        public void get_global_Nameplates(){} // RVA: 0x7FFE86FFC9E0
        public void get_global_HUD(){} // RVA: 0x7FFE86FFCA50
        public void get_global_Chatbox(){} // RVA: 0x7FFE86FFCAC0
        public void get_global_Face_Mirror(){} // RVA: 0x7FFE86FFCB30
        public void get_global_Personal_Mirror(){} // RVA: 0x7FFE86FFCBA0
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x7FFE86FFCC10
        public void get_global_Earmuffs(){} // RVA: 0x7FFE86FFCC80
        public void get_global_Camera(){} // RVA: 0x7FFE86FFCCF0
        public void get_global_Stream_Camera(){} // RVA: 0x7FFE86FFCD60
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x7FFE86FFCDD0
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x7FFE86FFCE40
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x7FFE86FFCEB0
        public void get_global_Start_Move(){} // RVA: 0x7FFE86FFCF20
        public void get_global_Start_Rotate(){} // RVA: 0x7FFE86FFCF90
        public void get_global_Continue_Move(){} // RVA: 0x7FFE86FFD000
        public void get_global_Continue_Rotate(){} // RVA: 0x7FFE86FFD070
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x7FFE86FFD0E0
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x7FFE86FFD150
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x7FFE86FFD1C0
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFE86FFD230
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFE86FFD2A0
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFE86FFD310
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x7FFE86FFD380
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x7FFE86FFD3F0
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x7FFE86FFD460
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x7FFE86FFD4D0
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFE86FFD540
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFE86FFD5B0
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFE86FFD620
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x7FFE86FFD690
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFE86FFD700
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFE86FFD770
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFE86FFD7E0
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFE86FFD850
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x7FFE86FFD8C0
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFE86FFD930
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFE86FFD9A0
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x7FFE86FFDA10
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFE86FFDA80
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFE86FFDAF0
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFE86FFDB60
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFE86FFDBD0
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x7FFE86FFDC40
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x7FFE86FFDCB0
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFE86FFDD20
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFE86FFDD90
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFE86FFDE00
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFE86FFDE70
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFE86FFDEE0
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFE86FFDF50
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFE86FFDFC0
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFE86FFE030
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x7FFE86FFE0A0
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFE86FFE110
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFE86FFE180
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFE86FFE1F0
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFE86FFE260
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFE86FFE2D0
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFE86FFE340
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFE86FFE3B0
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFE86FFE420
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x7FFE86FFE490
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFE86FFE500
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFE86FFE570
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFE86FFE5E0
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFE86FFE650
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x7FFE86FFE6C0
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x7FFE86FFE730
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x7FFE86FFE7A0
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x7FFE86FFE810
        public void get_global_Scroll(){} // RVA: 0x7FFE86FFE880
        public void get_global_Haptic(){} // RVA: 0x7FFE86FFE8F0
        public void get_one_Hand_Interact(){} // RVA: 0x7FFE86FFE960
        public void get_one_Hand_Grab(){} // RVA: 0x7FFE86FFE9D0
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x7FFE86FFEA40
        public void get_one_Hand_Jump(){} // RVA: 0x7FFE86FFEAB0
        public void get_one_Hand_Mic(){} // RVA: 0x7FFE86FFEB20
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x7FFE86FFEB90
        public void get_one_Hand_Stick_Click(){} // RVA: 0x7FFE86FFEC00
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x7FFE86FFEC70
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x7FFE86FFECE0
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x7FFE86FFED50
        public void get_one_Hand_Drop(){} // RVA: 0x7FFE86FFEDC0
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x7FFE86FFEE30
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x7FFE86FFEEA0
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFE86FFEF10
        public void get_one_Hand_Menu(){} // RVA: 0x7FFE86FFEF80
        public void get_one_Hand_Nameplates(){} // RVA: 0x7FFE86FFEFF0
        public void get_one_Hand_HUD(){} // RVA: 0x7FFE86FFF060
        public void get_one_Hand_Chatbox(){} // RVA: 0x7FFE86FFF0D0
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x7FFE86FFF140
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x7FFE86FFF1B0
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x7FFE86FFF220
        public void get_one_Hand_Earmuffs(){} // RVA: 0x7FFE86FFF290
        public void get_one_Hand_Camera(){} // RVA: 0x7FFE86FFF300
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x7FFE86FFF370
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x7FFE86FFF3E0
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x7FFE86FFF450
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x7FFE86FFF4C0
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x7FFE86FFF530
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFE86FFF5A0
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFE86FFF610
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFE86FFF680
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x7FFE86FFF6F0
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7FFE86FFF760
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7FFE86FFF7D0
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x7FFE86FFF840
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFE86FFF8B0
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x7FFE86FFF920
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFE86FFF990
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFE86FFFA00
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFE86FFFA70
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFE86FFFAE0
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFE86FFFB50
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFE86FFFBC0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFE86FFFC30
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFE86FFFCA0
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x7FFE86FFFD10
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFE86FFFD80
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFE86FFFDF0
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFE86FFFE60
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFE86FFFED0
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFE86FFFF40
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFE86FFFFB0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFE87000020
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFE87000090
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFE87000100
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFE87000170
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFE870001E0
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFE87000250
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x7FFE870002C0
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x7FFE87000330
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x7FFE870003A0
        public void get_menu_Confirm(){} // RVA: 0x7FFE87000410
        public void get_menu_Back(){} // RVA: 0x7FFE87000480
        public void get_menu_Tab(){} // RVA: 0x7FFE870004F0
        public void get_menu_Scroll(){} // RVA: 0x7FFE87000560
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x7FFE870005D0
        public void get_menu_Drag(){} // RVA: 0x7FFE87000640
        public void get_action_Menu_Axis(){} // RVA: 0x7FFE870006B0
        public void get_action_Menu_Select(){} // RVA: 0x7FFE87000720
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x7FFE87000790
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFE87000800
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFE87000870
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFE870008E0
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x7FFE87000950
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x7FFE870009C0
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x7FFE87000A30
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x7FFE87000AA0
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFE87000B10
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x7FFE87000B80
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFE87000BF0
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFE87000C60
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFE87000CD0
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFE87000D40
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFE87000DB0
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFE87000E20
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFE87000E90
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFE87000F00
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x7FFE87000F70
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFE87000FE0
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFE87001050
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFE870010C0
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFE87001130
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFE870011A0
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFE87001210
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFE87001280
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFE870012F0
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFE87001360
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFE870013D0
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFE87001440
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFE870014B0
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x7FFE87001520
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x7FFE87001590
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x7FFE87001600
        public void get_action_Menu_Grab(){} // RVA: 0x7FFE87001670
        public void get_action_Menu_Drop(){} // RVA: 0x7FFE870016E0
        public void get_drone_Left_Joystick(){} // RVA: 0x7FFE87001750
        public void get_drone_Right_Joystick(){} // RVA: 0x7FFE870017C0
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x7FFE87001830
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x7FFE870018A0
        public void get_drone_Toggle_FPV(){} // RVA: 0x7FFE87001910
        public void get_drone_Flip(){} // RVA: 0x7FFE87001980
        public void get_drone_Take_Picture(){} // RVA: 0x7FFE870019F0
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x7FFE87001A60
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x7FFE87001AD0
        public void get_drone_Respawn(){} // RVA: 0x7FFE87001B40
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x7FFE87001BB0
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFE87001C20
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x7FFE87001C90
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFE87001D00
        public void InitializeActionArrays(){} // RVA: 0x7FFE87001D70
        public void PreInitActions(){} // RVA: 0x7FFE8700B510
        public void get_Global(){} // RVA: 0x7FFE870102F0
        public void get_One_Hand(){} // RVA: 0x7FFE87010360
        public void get_Menu(){} // RVA: 0x7FFE870103D0
        public void get_Action_Menu(){} // RVA: 0x7FFE87010440
        public void get_Drone(){} // RVA: 0x7FFE870104B0
        public void StartPreInitActionSets(){} // RVA: 0x7FFE87010520
        public void PreInitialize(){} // RVA: 0x7FFE87010C00
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_ActivateActionSetOnLoad : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE87016DD0
        public void OnDestroy(){} // RVA: 0x7FFE87016E40
        public void .ctor(){} // RVA: 0x7FFE87016EA0
    }

    public class SteamVR_Behaviour : MonoBehaviour
    {
        public string openVRDeviceName;

        // ── Methods ──
        public void get_instance(){} // RVA: 0x7FFE8703CEA0
        public void Initialize(){} // RVA: 0x7FFE8703CFE0
        public void Awake(){} // RVA: 0x7FFE8703D880
        public void InitializeSteamVR(){} // RVA: 0x7FFE8703D980
        public void DoInitializeSteamVR(){} // RVA: 0x7FFE8703DBD0
        public void XRDevice_deviceLoaded(){} // RVA: 0x7FFE8703DC70
        public void EnableOpenVR(){} // RVA: 0x7FFE8703DD50
        public void OnEnable(){} // RVA: 0x7FFE8703DE70
        public void OnDisable(){} // RVA: 0x7FFE8703E010
        public void OnBeforeRender(){} // RVA: 0x7FFE8703E1C0
        public void PreCull(){} // RVA: 0x7FFE8703E1D0
        public void FixedUpdate(){} // RVA: 0x7FFE8703E450
        public void LateUpdate(){} // RVA: 0x7FFE8703E5D0
        public void Update(){} // RVA: 0x7FFE8703E770
        public void OnQuit(){} // RVA: 0x7FFE8703E8F0
        public void .ctor(){} // RVA: 0x7FFE8703E940
        public void .cctor(){} // RVA: 0x7FFE8703E990
    }

    public class SteamVR_Behaviour_Boolean : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Boolean booleanAction; // 0x20
        public 0x6660354C inputSource; // 0x28

        // ── Methods ──
        public void add_onChangeEvent(){} // RVA: 0x7FFE87016FA0
        public void remove_onChangeEvent(){} // RVA: 0x7FFE87017090
        public void add_onUpdateEvent(){} // RVA: 0x7FFE87017180
        public void remove_onUpdateEvent(){} // RVA: 0x7FFE87017270
        public void add_onPressEvent(){} // RVA: 0x7FFE87017360
        public void remove_onPressEvent(){} // RVA: 0x7FFE87017450
        public void add_onPressDownEvent(){} // RVA: 0x7FFE87017540
        public void remove_onPressDownEvent(){} // RVA: 0x7FFE87017630
        public void add_onPressUpEvent(){} // RVA: 0x7FFE87017720
        public void remove_onPressUpEvent(){} // RVA: 0x7FFE87017810
        public void get_isActive(){} // RVA: 0x7FFE87017900
        public void get_actionSet(){} // RVA: 0x7FFE87017950
        public void OnEnable(){} // RVA: 0x7FFE87017A50
        public void OnDisable(){} // RVA: 0x7FFE87017B40
        public void AddHandlers(){} // RVA: 0x7FFE87017B50
        public void RemoveHandlers(){} // RVA: 0x7FFE87017E10
        public void SteamVR_Behaviour_Boolean_OnStateUp(){} // RVA: 0x7FFE87018170
        public void SteamVR_Behaviour_Boolean_OnStateDown(){} // RVA: 0x7FFE870181F0
        public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x7FFE87018270
        public void SteamVR_Behaviour_Boolean_OnUpdate(){} // RVA: 0x7FFE870182F0
        public void SteamVR_Behaviour_Boolean_OnChange(){} // RVA: 0x7FFE87018390
        public void GetLocalizedName(){} // RVA: 0x7FFE87018430
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_Behaviour_BooleanEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2130
    }

    public class SteamVR_Behaviour_Pose : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Pose poseAction; // 0x20
        public 0x6660354C inputSource; // 0x28

        // ── Methods ──
        public void get_isValid(){} // RVA: 0x7FFE87018930
        public void get_isActive(){} // RVA: 0x7FFE87017900
        public void Start(){} // RVA: 0x7FFE87018970
        public void OnEnable(){} // RVA: 0x7FFE87018C00
        public void OnDisable(){} // RVA: 0x7FFE87018EF0
        public void SteamVR_Behaviour_Pose_OnUpdate(){} // RVA: 0x7FFE870192A0
        public void UpdateTransform(){} // RVA: 0x7FFE87019340
        public void SteamVR_Behaviour_Pose_OnChange(){} // RVA: 0x7FFE87019A50
        public void OnDeviceConnectedChanged(){} // RVA: 0x7FFE87019AD0
        public void OnTrackingChanged(){} // RVA: 0x7FFE87019B80
        public void CheckDeviceIndex(){} // RVA: 0x7FFE87019C10
        public void GetDeviceIndex(){} // RVA: 0x7FFE87019E80
        public void GetVelocity(){} // RVA: 0x7FFE87019EC0
        public void GetAngularVelocity(){} // RVA: 0x7FFE87019F20
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7FFE87019F80
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7FFE87019FF0
        public void UpdateHistoryBuffer(){} // RVA: 0x7FFE8701A120
        public void GetLocalizedName(){} // RVA: 0x7FFE8701A340
        public void .ctor(){} // RVA: 0x7FFE8701A480
    }

    public class SteamVR_Behaviour_PoseEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE21C0
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2250
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE22E0
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2370
    }

    public class SteamVR_Behaviour_Single : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Single singleAction; // 0x20

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFE8701AB60
        public void OnEnable(){} // RVA: 0x7FFE8701ABA0
        public void OnDisable(){} // RVA: 0x7FFE8701AC90
        public void AddHandlers(){} // RVA: 0x7FFE8701ACA0
        public void RemoveHandlers(){} // RVA: 0x7FFE8701AE60
        public void SteamVR_Behaviour_Single_OnUpdate(){} // RVA: 0x7FFE8701B0C0
        public void SteamVR_Behaviour_Single_OnChange(){} // RVA: 0x7FFE8701B180
        public void SteamVR_Behaviour_Single_OnAxis(){} // RVA: 0x7FFE8701B240
        public void GetLocalizedName(){} // RVA: 0x7FFE8701B300
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_Behaviour_SingleEvent : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2400
    }

    public class SteamVR_Behaviour_Skeleton : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Skeleton skeletonAction; // 0x20
        public 0x6660354C inputSource; // 0x28
        public 0x6663A234 rangeOfMotion; // 0x2C
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
        public 0x666023C4 mirroring; // 0x98
        public Valve.VR.SteamVR_Skeleton_Poser fallbackPoser; // 0xA0
        public Valve.VR.SteamVR_Action_Single fallbackCurlAction; // 0xA8
        public Valve.VR.SteamVR_Skeleton_Poser blendPoser; // 0xB0
        public Valve.VR.SteamVR_Skeleton_PoseSnapshot blendSnapshot; // 0xB8
        public UnityEngine.Transform[] _proximals; // 0xC0
        public UnityEngine.Transform[] _middles; // 0xC8
        public UnityEngine.Transform[] _distals; // 0xD0
        public UnityEngine.Transform[] _tips; // 0xD8
        public UnityEngine.Transform[] _auxs; // 0xE0
        public UnityEngine.Coroutine blendRoutine; // 0xE8
        public UnityEngine.Coroutine rangeOfMotionBlendRoutine; // 0xF0
        public UnityEngine.Coroutine attachRoutine; // 0xF8
        public UnityEngine.Transform[] bones; // 0x100
        public System.Nullable`1<0x6663A234> temporaryRangeOfMotion; // 0x108
        public UnityEngine.Quaternion rightFlipAngle;
        public object Nullable`1; // 0x51F0
        public object field_35;
        public object Nullable`1;
        public object field_37;
        public object field_38; // 0x3FC0
        public object field_39;
        public object field_40;
        public object field_41; // 0x2F30
        public object field_42; // 0x3D58
        public object field_43; // 0x45A
        public object field_44; // 0x45B
        public object field_45; // 0x6610
        public object field_46; // 0x6610
        public object field_47; // 0x6610
        public object field_48; // 0x6610

        // ── Methods ──
        public void get_skeletonAvailable(){} // RVA: 0x7FFE814373A0
        public void get_isActive(){} // RVA: 0x7FFE8701B6B0
        public void get_fingerCurls(){} // RVA: 0x7FFE8701B730
        public void get_thumbCurl(){} // RVA: 0x7FFE8701B880
        public void get_indexCurl(){} // RVA: 0x7FFE8701B8F0
        public void get_middleCurl(){} // RVA: 0x7FFE8701B960
        public void get_ringCurl(){} // RVA: 0x7FFE8701B9D0
        public void get_pinkyCurl(){} // RVA: 0x7FFE8701BA40
        public void get_root(){} // RVA: 0x7FFE8701BAB0
        public void get_wrist(){} // RVA: 0x7FFE8701BAE0
        public void get_indexMetacarpal(){} // RVA: 0x7FFE8701BB10
        public void get_indexProximal(){} // RVA: 0x7FFE8701BB40
        public void get_indexMiddle(){} // RVA: 0x7FFE8701BB70
        public void get_indexDistal(){} // RVA: 0x7FFE8701BBA0
        public void get_indexTip(){} // RVA: 0x7FFE8701BBD0
        public void get_middleMetacarpal(){} // RVA: 0x7FFE8701BC00
        public void get_middleProximal(){} // RVA: 0x7FFE8701BC30
        public void get_middleMiddle(){} // RVA: 0x7FFE8701BC60
        public void get_middleDistal(){} // RVA: 0x7FFE8701BC90
        public void get_middleTip(){} // RVA: 0x7FFE8701BCC0
        public void get_pinkyMetacarpal(){} // RVA: 0x7FFE8701BCF0
        public void get_pinkyProximal(){} // RVA: 0x7FFE8701BD20
        public void get_pinkyMiddle(){} // RVA: 0x7FFE8701BD50
        public void get_pinkyDistal(){} // RVA: 0x7FFE8701BD80
        public void get_pinkyTip(){} // RVA: 0x7FFE8701BDB0
        public void get_ringMetacarpal(){} // RVA: 0x7FFE8701BDE0
        public void get_ringProximal(){} // RVA: 0x7FFE8701BE10
        public void get_ringMiddle(){} // RVA: 0x7FFE8701BE40
        public void get_ringDistal(){} // RVA: 0x7FFE8701BE70
        public void get_ringTip(){} // RVA: 0x7FFE8701BEA0
        public void get_thumbMetacarpal(){} // RVA: 0x7FFE8701BED0
        public void get_thumbProximal(){} // RVA: 0x7FFE8701BED0
        public void get_thumbMiddle(){} // RVA: 0x7FFE8701BF00
        public void get_thumbDistal(){} // RVA: 0x7FFE8701BF30
        public void get_thumbTip(){} // RVA: 0x7FFE8701BF60
        public void get_thumbAux(){} // RVA: 0x7FFE8701BF90
        public void get_indexAux(){} // RVA: 0x7FFE8701BFC0
        public void get_middleAux(){} // RVA: 0x7FFE8701BFF0
        public void get_ringAux(){} // RVA: 0x7FFE8701C020
        public void get_pinkyAux(){} // RVA: 0x7FFE8701C050
        public void get_proximals(){} // RVA: 0x7FFE81166120
        public void set_proximals(){} // RVA: 0x7FFE81166130
        public void get_middles(){} // RVA: 0x7FFE81253460
        public void set_middles(){} // RVA: 0x7FFE81253470
        public void get_distals(){} // RVA: 0x7FFE81218100
        public void set_distals(){} // RVA: 0x7FFE81218110
        public void get_tips(){} // RVA: 0x7FFE8181EA80
        public void set_tips(){} // RVA: 0x7FFE8117C8A0
        public void get_auxs(){} // RVA: 0x7FFE8117C900
        public void set_auxs(){} // RVA: 0x7FFE8117C910
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFE8701C080
        public void get_isBlending(){} // RVA: 0x7FFE8701C120
        public void get_actionSet(){} // RVA: 0x7FFE86FE3990
        public void get_direction(){} // RVA: 0x7FFE86FE39C0
        public void Awake(){} // RVA: 0x7FFE8701C130
        public void CheckSkeletonAction(){} // RVA: 0x7FFE8701CD60
        public void AssignBonesArray(){} // RVA: 0x7FFE8701CEF0
        public void OnEnable(){} // RVA: 0x7FFE8701CFD0
        public void OnDisable(){} // RVA: 0x7FFE8701D390
        public void OnDeviceConnectedChanged(){} // RVA: 0x7FFE8701D760
        public void OnTrackingChanged(){} // RVA: 0x7FFE8701D800
        public void SteamVR_Input_OnSkeletonsUpdated(){} // RVA: 0x7FFE844800F0
        public void UpdateSkeleton(){} // RVA: 0x7FFE8701D8A0
        public void SetTemporaryRangeOfMotion(){} // RVA: 0x7FFE8701DB30
        public void ResetTemporaryRangeOfMotion(){} // RVA: 0x7FFE8701DBC0
        public void SetRangeOfMotion(){} // RVA: 0x7FFE8701DBD0
        public void BlendToSkeleton(){} // RVA: 0x7FFE8701DD50
        public void BlendToPoser(){} // RVA: 0x7FFE8701DF50
        public void BlendToAnimation(){} // RVA: 0x7FFE8701E090
        public void BlendTo(){} // RVA: 0x7FFE8701E0A0
        public void DoBlendRoutine(){} // RVA: 0x7FFE8701E2A0
        public void RangeOfMotionBlend(){} // RVA: 0x7FFE8701E360
        public void TemporaryRangeOfMotionBlend(){} // RVA: 0x7FFE8701E4E0
        public void ResetTemporaryRangeOfMotionBlend(){} // RVA: 0x7FFE8701E6D0
        public void DoRangeOfMotionBlend(){} // RVA: 0x7FFE8701E8A0
        public void GetBlendPoseForBone(){} // RVA: 0x7FFE8701E970
        public void UpdateSkeletonTransforms(){} // RVA: 0x7FFE8701E9C0
        public void SetBonePosition(){} // RVA: 0x7FFE8701F910
        public void SetBoneRotation(){} // RVA: 0x7FFE8701F9B0
        public void GetBone(){} // RVA: 0x7FFE8701FA40
        public void GetBonePosition(){} // RVA: 0x7FFE8701FAB0
        public void GetBoneRotation(){} // RVA: 0x7FFE8701FBD0
        public void GetBonePositions(){} // RVA: 0x7FFE8701FCE0
        public void GetBoneRotations(){} // RVA: 0x7FFE87020060
        public void MirrorPosition(){} // RVA: 0x7FFE87020310
        public void MirrorRotation(){} // RVA: 0x7FFE870203F0
        public void UpdatePose(){} // RVA: 0x7FFE87020640
        public void ForceToReferencePose(){} // RVA: 0x7FFE87020F10
        public void IsMetacarpal(){} // RVA: 0x7FFE87021570
        public void .ctor(){} // RVA: 0x7FFE87021590
        public void .cctor(){} // RVA: 0x7FFE870215F0
    }

    public class SteamVR_Behaviour_SkeletonCustom : SteamVR_Behaviour_Skeleton
    {
        // ── Methods ──
        public void AssignBonesArray(){} // RVA: 0x7FFE870229F0
        public void .ctor(){} // RVA: 0x7FFE870232A0
    }

    public class SteamVR_Behaviour_SkeletonEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2490
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2520
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE25B0
    }

    public class SteamVR_Behaviour_Vector2 : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Vector2 vector2Action; // 0x20

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFE8701AB60
        public void OnEnable(){} // RVA: 0x7FFE87023340
        public void OnDisable(){} // RVA: 0x7FFE87023430
        public void AddHandlers(){} // RVA: 0x7FFE87023440
        public void RemoveHandlers(){} // RVA: 0x7FFE87023600
        public void SteamVR_Behaviour_Vector2_OnUpdate(){} // RVA: 0x7FFE87023860
        public void SteamVR_Behaviour_Vector2_OnChange(){} // RVA: 0x7FFE87023920
        public void SteamVR_Behaviour_Vector2_OnAxis(){} // RVA: 0x7FFE870239E0
        public void GetLocalizedName(){} // RVA: 0x7FFE87023AA0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_Behaviour_Vector2Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE2640
    }

    public class SteamVR_Behaviour_Vector3 : MonoBehaviour
    {
        public Valve.VR.SteamVR_Action_Vector3 vector3Action; // 0x20

        // ── Methods ──
        public void get_isActive(){} // RVA: 0x7FFE8701AB60
        public void OnEnable(){} // RVA: 0x7FFE87023E50
        public void OnDisable(){} // RVA: 0x7FFE87023F40
        public void AddHandlers(){} // RVA: 0x7FFE87023F50
        public void RemoveHandlers(){} // RVA: 0x7FFE87024110
        public void SteamVR_Behaviour_Vector3_OnUpdate(){} // RVA: 0x7FFE87024370
        public void SteamVR_Behaviour_Vector3_OnChange(){} // RVA: 0x7FFE87024480
        public void SteamVR_Behaviour_Vector3_OnAxis(){} // RVA: 0x7FFE87024590
        public void GetLocalizedName(){} // RVA: 0x7FFE870246A0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_Behaviour_Vector3Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86FE26D0
    }

    public class SteamVR_Camera : MonoBehaviour
    {
        public UnityEngine.Transform _head; // 0x20
        public UnityEngine.Camera _camera; // 0x28
        public UnityEngine.Transform _ears; // 0x30
        public bool wireframe; // 0x38
        public System.Collections.Hashtable values;
        public string eyeSuffix;
        public string earsSuffix;

        // ── Methods ──
        public void get_head(){} // RVA: 0x7FFE811290C0
        public void get_offset(){} // RVA: 0x7FFE811290C0
        public void get_origin(){} // RVA: 0x7FFE8703EE80
        public void get_camera(){} // RVA: 0x7FFE81129130
        public void set_camera(){} // RVA: 0x7FFE810FCE90
        public void get_ears(){} // RVA: 0x7FFE8144E200
        public void GetRay(){} // RVA: 0x7FFE8703EEE0
        public void get_sceneResolutionScale(){} // RVA: 0x7FFE8703F040
        public void set_sceneResolutionScale(){} // RVA: 0x7FFE8703F090
        public void OnDisable(){} // RVA: 0x7FFE8703F0F0
        public void OnEnable(){} // RVA: 0x7FFE8703F250
        public void Awake(){} // RVA: 0x7FFE8703FCE0
        public void ForceLast(){} // RVA: 0x7FFE8703FD70
        public void get_baseName(){} // RVA: 0x7FFE870406C0
        public void Expand(){} // RVA: 0x7FFE87040780
        public void Collapse(){} // RVA: 0x7FFE87041E50
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_CameraFlip : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87042C40
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_CameraHelper : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE86FE1F80
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_CameraMask : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE87042CE0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_Ears : MonoBehaviour
    {
        // ── Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x7FFE87042D80
        public void OnEnable(){} // RVA: 0x7FFE87043150
        public void OnDisable(){} // RVA: 0x7FFE870434D0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class SteamVR_Events : Object
    {
        // ── Methods ──
        public void CalibratingAction(){} // RVA: 0x7FFE870435D0
        public void DeviceConnectedAction(){} // RVA: 0x7FFE87043680
        public void FadeAction(){} // RVA: 0x7FFE870437D0
        public void FadeReadyAction(){} // RVA: 0x7FFE87043920
        public void HideRenderModelsAction(){} // RVA: 0x7FFE870439D0
        public void InitializingAction(){} // RVA: 0x7FFE87043A80
        public void InputFocusAction(){} // RVA: 0x7FFE87043B30
        public void LoadingAction(){} // RVA: 0x7FFE87043BE0
        public void LoadingFadeInAction(){} // RVA: 0x7FFE87043C90
        public void LoadingFadeOutAction(){} // RVA: 0x7FFE87043D40
        public void NewPosesAction(){} // RVA: 0x7FFE87043DF0
        public void NewPosesAppliedAction(){} // RVA: 0x7FFE87043EB0
        public void InitializedAction(){} // RVA: 0x7FFE87043F60
        public void OutOfRangeAction(){} // RVA: 0x7FFE87044010
        public void RenderModelLoadedAction(){} // RVA: 0x7FFE870440C0
        public void System(){} // RVA: 0x7FFE87044210
        public void SystemAction(){} // RVA: 0x7FFE870443C0
        public void .cctor(){} // RVA: 0x7FFE87044500
    }

    public class SteamVR_ExternalCamera : MonoBehaviour
    {
        // ── Methods ──
        public void ReadConfig(){} // RVA: 0x7FFE87045140
        public void SetupPose(){} // RVA: 0x7FFE87045B80
        public void SetupDeviceIndex(){} // RVA: 0x7FFE87045D00
        public void OnChanged(){} // RVA: 0x7FFE87045DB0
        public void AttachToCamera(){} // RVA: 0x7FFE87045DC0
        public void GetTargetDistance(){} // RVA: 0x7FFE870472F0
        public void RenderNear(){} // RVA: 0x7FFE87047840
        public void RenderFar(){} // RVA: 0x7FFE870489C0
        public void OnGUI(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE87048C80
        public void AutoEnableActionSet(){} // RVA: 0x7FFE870491B0
        public void OnDisable(){} // RVA: 0x7FFE87049340
        public void .ctor(){} // RVA: 0x7FFE870496D0
    }

    public class SteamVR_ExternalCamera_LegacyManager : Object
    {
        public int cameraIndex;

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x7FFE87049730
        public void SubscribeToNewPoses(){} // RVA: 0x7FFE87049790
        public void OnNewPoses(){} // RVA: 0x7FFE87049930
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87049A60
    }

    public class SteamVR_Fade : MonoBehaviour
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7FFE87049B10
        public void View(){} // RVA: 0x7FFE87049BE0
        public void OnStartFade(){} // RVA: 0x7FFE87049C60
        public void OnEnable(){} // RVA: 0x7FFE87049D10
        public void OnDisable(){} // RVA: 0x7FFE8704A020
        public void OnPostRender(){} // RVA: 0x7FFE8704A120
        public void .ctor(){} // RVA: 0x7FFE8704A660
        public void .cctor(){} // RVA: 0x7FFE8704A6C0
    }

    public class SteamVR_Frustum : MonoBehaviour
    {
        // ── Methods ──
        public void UpdateModel(){} // RVA: 0x7FFE8704A770
        public void OnDeviceConnected(){} // RVA: 0x7FFE8704B1A0
        public void OnEnable(){} // RVA: 0x7FFE8704B440
        public void OnDisable(){} // RVA: 0x7FFE8704B590
        public void .ctor(){} // RVA: 0x7FFE8704B710
    }

    public class SteamVR_HistoryBuffer : SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8705F130
        public void Update(){} // RVA: 0x7FFE8705F200
        public void GetVelocityMagnitudeTrend(){} // RVA: 0x7FFE8705F570
        public void IsValid(){} // RVA: 0x7FFE8705F680
        public void GetTopVelocity(){} // RVA: 0x7FFE8705F6A0
        public void GetAverageVelocities(){} // RVA: 0x7FFE8705F790
    }

    public class SteamVR_HistoryStep : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8705FA60
    }

    public class SteamVR_IK : MonoBehaviour
    {
        // ── Methods ──
        public void LateUpdate(){} // RVA: 0x7FFE8704B780
        public void Solve(){} // RVA: 0x7FFE8704D0B0
        public void .ctor(){} // RVA: 0x7FFE8704D750
    }

    public class SteamVR_Input : Object
    {
        public string defaultInputGameObjectName;

        // ── Methods ──
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x7FFE87024A50
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x7FFE87024BA0
        public void add_onPosesUpdated(){} // RVA: 0x7FFE87024CF0
        public void remove_onPosesUpdated(){} // RVA: 0x7FFE87024E40
        public void add_onSkeletonsUpdated(){} // RVA: 0x7FFE87024F90
        public void remove_onSkeletonsUpdated(){} // RVA: 0x7FFE870250E0
        public void get_isStartupFrame(){} // RVA: 0x7FFE87025230
        public void .cctor(){} // RVA: 0x7FFE87025350
        public void ForcePreinitialize(){} // RVA: 0x7FFE87025970
        public void FindPreinitializeMethod(){} // RVA: 0x7FFE870259C0
        public void Initialize(){} // RVA: 0x7FFE87025BA0
        public void PreinitializeFinishActionSets(){} // RVA: 0x7FFE87026130
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x7FFE87026200
        public void PreinitializeActionDictionaries(){} // RVA: 0x7FFE870264A0
        public void Update(){} // RVA: 0x7FFE87026710
        public void LateUpdate(){} // RVA: 0x7FFE87026830
        public void FixedUpdate(){} // RVA: 0x7FFE87026970
        public void OnPreCull(){} // RVA: 0x7FFE87026A90
        public void UpdateVisualActions(){} // RVA: 0x7FFE87026BB0
        public void UpdatePoseActions(){} // RVA: 0x7FFE87026DB0
        public void UpdateSkeletonActions(){} // RVA: 0x7FFE87026F30
        public void UpdateNonVisualActions(){} // RVA: 0x7FFE870270B0
        public void ShowBindingHintsForSets(){} // RVA: 0x7FFE870272D0
        public void ShowBindingHints(){} // RVA: 0x7FFE87027630 | overloaded x2
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x7FFE87027710
        public void GetActionDataFromPath(){} // RVA: 0x7FFE810A1420
        public void GetActionSetDataFromPath(){} // RVA: 0x7FFE870278C0
        public void GetActionFromPath(){} // RVA: 0x7FFE810A1420
        public void GetBaseActionFromPath(){} // RVA: 0x7FFE87027970
        public void HasActionPath(){} // RVA: 0x7FFE87027DC0
        public void HasAction(){} // RVA: 0x7FFE87027FE0 | overloaded x2
        public void GetBooleanActionFromPath(){} // RVA: 0x7FFE870280F0
        public void GetSingleActionFromPath(){} // RVA: 0x7FFE87028170
        public void GetVector2ActionFromPath(){} // RVA: 0x7FFE870281F0
        public void GetVector3ActionFromPath(){} // RVA: 0x7FFE87028270
        public void GetVibrationActionFromPath(){} // RVA: 0x7FFE870282F0
        public void GetPoseActionFromPath(){} // RVA: 0x7FFE87028370
        public void GetSkeletonActionFromPath(){} // RVA: 0x7FFE870283F0
        public void GetAction(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetBaseAction(){} // RVA: 0x7FFE87028470
        public void CreateFakeAction(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetBooleanAction(){} // RVA: 0x7FFE870289D0 | overloaded x2
        public void GetSingleAction(){} // RVA: 0x7FFE87028AE0 | overloaded x2
        public void GetVector2Action(){} // RVA: 0x7FFE87028BF0 | overloaded x2
        public void GetVector3Action(){} // RVA: 0x7FFE87028D00 | overloaded x2
        public void GetPoseAction(){} // RVA: 0x7FFE87028E10 | overloaded x2
        public void GetSkeletonAction(){} // RVA: 0x7FFE87028F20 | overloaded x2
        public void GetVibrationAction(){} // RVA: 0x7FFE87029030 | overloaded x2
        public void GetActionSet(){} // RVA: 0x7FFE870290B0 | overloaded x2
        public void HasActionSet(){} // RVA: 0x7FFE87029140
        public void GetActionSetFromPath(){} // RVA: 0x7FFE870291E0 | overloaded x2
        public void GetState(){} // RVA: 0x7FFE870293C0 | overloaded x2
        public void GetStateDown(){} // RVA: 0x7FFE870296B0 | overloaded x2
        public void GetStateUp(){} // RVA: 0x7FFE870299A0 | overloaded x2
        public void GetFloat(){} // RVA: 0x7FFE87029C90 | overloaded x2
        public void GetSingle(){} // RVA: 0x7FFE87029E70 | overloaded x2
        public void GetVector2(){} // RVA: 0x7FFE8702A080 | overloaded x2
        public void GetVector3(){} // RVA: 0x7FFE8702A420 | overloaded x2
        public void GetActionSets(){} // RVA: 0x7FFE8702A4C0
        public void GetActions(){} // RVA: 0x7FFE80E2DEE0
        public void ShouldMakeCopy(){} // RVA: 0x7FFE8702A520
        public void GetLocalizedName(){} // RVA: 0x7FFE8702A580
        public void CheckOldLocation(){} // RVA: 0x7FFE810FB320
        public void IdentifyActionsFile(){} // RVA: 0x7FFE8702A6D0
        public void HasFileInMemoryBeenModified(){} // RVA: 0x7FFE8702AA60
        public void CreateEmptyActionsFile(){} // RVA: 0x7FFE8702AC30
        public void DoesActionsFileExist(){} // RVA: 0x7FFE8702B2E0
        public void InitializeFile(){} // RVA: 0x7FFE8702B340
        public void GetActionsFileFolder(){} // RVA: 0x7FFE8702B760
        public void GetActionsFilePath(){} // RVA: 0x7FFE8702B870
        public void GetActionsFileName(){} // RVA: 0x7FFE8702BB10
        public void DeleteManifestAndBindings(){} // RVA: 0x7FFE8702BB70
        public void OpenBindingUI(){} // RVA: 0x7FFE8702BFE0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionFile : Object
    {
        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x7FFE8702C1F0
        public void SaveHelperLists(){} // RVA: 0x7FFE8702C8A0
        public void GetShortName(){} // RVA: 0x7FFE8702D0E0
        public void GetCodeFriendlyName(){} // RVA: 0x7FFE8702D180
        public void GetFilesToCopy(){} // RVA: 0x7FFE8702D330
        public void CopyFilesToPath(){} // RVA: 0x7FFE8702D6B0
        public void RemoveAppKey(){} // RVA: 0x7FFE8702D980
        public void Open(){} // RVA: 0x7FFE8702DB00
        public void Save(){} // RVA: 0x7FFE8702DC00
        public void .ctor(){} // RVA: 0x7FFE8702DD80
    }

    public class SteamVR_Input_ActionFile_Action : Object
    {
        public string[] _requirementValues;
        public string name; // 0x10
        public string type; // 0x18
        public string scope; // 0x20
        public string skeleton; // 0x28
        public string requirement; // 0x30
        public string nameTemplate;

        // ── Methods ──
        public void get_requirementValues(){} // RVA: 0x7FFE8702EB50
        public void GetCopy(){} // RVA: 0x7FFE8702ED30
        public void get_requirementEnum(){} // RVA: 0x7FFE8702EF20
        public void set_requirementEnum(){} // RVA: 0x7FFE8702F060
        public void get_codeFriendlyName(){} // RVA: 0x7FFE8702E470
        public void get_shortName(){} // RVA: 0x7FFE8702F110
        public void get_path(){} // RVA: 0x7FFE8702F120
        public void CreateNewName(){} // RVA: 0x7FFE8702F250 | overloaded x2
        public void CreateNew(){} // RVA: 0x7FFE8702F340
        public void get_direction(){} // RVA: 0x7FFE8702F540
        public void get_actionSet(){} // RVA: 0x7FFE8702F600
        public void SetNewActionSet(){} // RVA: 0x7FFE8702F6B0
        public void ToString(){} // RVA: 0x7FFE8702F110
        public void Equals(){} // RVA: 0x7FFE8702F8B0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionFile_ActionSet : Object
    {
        public string actionSetInstancePrefix;
        public string name; // 0x10

        // ── Methods ──
        public void get_codeFriendlyName(){} // RVA: 0x7FFE8702E470
        public void get_shortName(){} // RVA: 0x7FFE8702E480
        public void SetNewShortName(){} // RVA: 0x7FFE8702E580
        public void CreateNewName(){} // RVA: 0x7FFE8702E5F0
        public void GetPathFromName(){} // RVA: 0x7FFE8702E630
        public void CreateNew(){} // RVA: 0x7FFE8702E6C0
        public void GetCopy(){} // RVA: 0x7FFE8702E790
        public void Equals(){} // RVA: 0x7FFE8702E8A0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE8702E9A0
    }

    public class SteamVR_Input_ActionFile_ActionSet_Usages : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE870312B0
    }

    public class SteamVR_Input_ActionFile_ActionTypes : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE870309D0
    }

    public class SteamVR_Input_ActionFile_DefaultBinding : Object
    {
        // ── Methods ──
        public void GetCopy(){} // RVA: 0x7FFE8702E370
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionFile_LocalizationItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8702FBB0 | overloaded x2
    }

    public class SteamVR_Input_ActionSet_Action_Menu : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Axis(){} // RVA: 0x7FFE86FFB370
        public void get_Select(){} // RVA: 0x7FFE86FFB380
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFE86FFB390
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFE86FFB3A0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFE86FFB3B0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFE86FFB3C0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFE86FFB3D0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFE86FFB3E0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFE86FFB3F0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFE86FFB400
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFE86FFB410
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFE86FFB420
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFE86FFB430
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFE86FFB440
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFE86FFB450
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFE86FFB460
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFE86FFB470
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFE86FFB480
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFE86FFB490
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFE86FFB4A0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFE86FFB4B0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFE86FFB4C0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFE86FFB4D0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFE86FFB4E0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFE86FFB4F0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFE86FFB500
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFE86FFB510
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFE86FFB520
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFE86FFB530
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFE86FFB540
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFE86FFB550
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFE86FFB560
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFE86FFB570
        public void get_Reserve_bool(){} // RVA: 0x7FFE86FFB580
        public void get_Reserve_vector1(){} // RVA: 0x7FFE86FFB590
        public void get_Reserve_vector2(){} // RVA: 0x7FFE86FFB5A0
        public void get_Grab(){} // RVA: 0x7FFE86FFB5B0
        public void get_Drop(){} // RVA: 0x7FFE86FFB5C0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionSet_Drone : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Left_Joystick(){} // RVA: 0x7FFE86FFB5D0
        public void get_Right_Joystick(){} // RVA: 0x7FFE86FFB5E0
        public void get_Self_Leveling_Mod(){} // RVA: 0x7FFE86FFB5F0
        public void get_Hold_Altitude_Mod(){} // RVA: 0x7FFE86FFB600
        public void get_Toggle_FPV(){} // RVA: 0x7FFE86FFB610
        public void get_Flip(){} // RVA: 0x7FFE86FFB620
        public void get_Take_Picture(){} // RVA: 0x7FFE86FFB630
        public void get_Cycle_Flight_Preset(){} // RVA: 0x7FFE86FFB640
        public void get_Toggle_Self_Leveling(){} // RVA: 0x7FFE86FFB650
        public void get_Respawn(){} // RVA: 0x7FFE86FFB660
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x7FFE86FFB670
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x7FFE86FFB680
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x7FFE86FFB690
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x7FFE86FFB6A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionSet_Global : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Safe_Mode(){} // RVA: 0x7FFE86FFB6B0
        public void get_Pose(){} // RVA: 0x7FFE86FFB6C0
        public void get_SkeletonLeftHand(){} // RVA: 0x7FFE86FFB6D0
        public void get_SkeletonRightHand(){} // RVA: 0x7FFE86FFB6E0
        public void get_HeadsetOnHead(){} // RVA: 0x7FFE86FFB6F0
        public void get_Menu(){} // RVA: 0x7FFE86FFB700
        public void get_Quick_Menu(){} // RVA: 0x7FFE86FFB710
        public void get_Action_Menu(){} // RVA: 0x7FFE86FFB720
        public void get_Main_Menu(){} // RVA: 0x7FFE86FFB730
        public void get_Interact(){} // RVA: 0x7FFE86FFB740
        public void get_Grab(){} // RVA: 0x7FFE86FFB750
        public void get_Move(){} // RVA: 0x7FFE86FFB760
        public void get_Jump(){} // RVA: 0x7FFE86FFB770
        public void get_Rotate(){} // RVA: 0x7FFE86FFB780
        public void get_Mic(){} // RVA: 0x7FFE86FFB790
        public void get_Gesture_Toggle(){} // RVA: 0x7FFE86FFB7A0
        public void get_Stick_Click(){} // RVA: 0x7FFE86FFB7B0
        public void get_Trigger_Axis(){} // RVA: 0x7FFE86FFB7C0
        public void get_Grip_Axis(){} // RVA: 0x7FFE86FFB7D0
        public void get_Udon_Menu(){} // RVA: 0x7FFE86FFB7E0
        public void get_Drop(){} // RVA: 0x7FFE86FFB7F0
        public void get_Nameplates(){} // RVA: 0x7FFE86FFB800
        public void get_HUD(){} // RVA: 0x7FFE86FFB810
        public void get_Chatbox(){} // RVA: 0x7FFE86FFB820
        public void get_Face_Mirror(){} // RVA: 0x7FFE86FFB830
        public void get_Personal_Mirror(){} // RVA: 0x7FFE86FFB840
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFE86FFB850
        public void get_Earmuffs(){} // RVA: 0x7FFE86FFB860
        public void get_Camera(){} // RVA: 0x7FFE86FFB870
        public void get_Stream_Camera(){} // RVA: 0x7FFE86FFB880
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFE86FFB890
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFE86FFB8A0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFE86FFB8B0
        public void get_Start_Move(){} // RVA: 0x7FFE86FFB8C0
        public void get_Start_Rotate(){} // RVA: 0x7FFE86FFB8D0
        public void get_Continue_Move(){} // RVA: 0x7FFE86FFB8E0
        public void get_Continue_Rotate(){} // RVA: 0x7FFE86FFB8F0
        public void get_No_Gesture_After_Move(){} // RVA: 0x7FFE86FFB900
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x7FFE86FFB910
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFE86FFB920
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFE86FFB930
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFE86FFB940
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFE86FFB950
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFE86FFB960
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFE86FFB970
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFE86FFB980
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFE86FFB990
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFE86FFB9A0
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x7FFE86FFB9B0
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x7FFE86FFB9C0
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x7FFE86FFB9D0
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x7FFE86FFB9E0
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x7FFE86FFB9F0
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7FFE86FFBA00
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7FFE86FFBA10
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x7FFE86FFBA20
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x7FFE86FFBA30
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x7FFE86FFBA40
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x7FFE86FFBA50
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x7FFE86FFBA60
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x7FFE86FFBA70
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7FFE86FFBA80
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7FFE86FFBA90
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x7FFE86FFBAA0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFE86FFBAB0
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFE86FFBAC0
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFE86FFBAD0
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFE86FFBAE0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFE86FFBAF0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFE86FFBB00
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFE86FFBB10
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFE86FFBB20
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFE86FFBB30
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFE86FFBB40
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFE86FFBB50
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFE86FFBB60
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFE86FFBB70
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFE86FFBB80
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFE86FFBB90
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFE86FFBBA0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFE86FFBBB0
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFE86FFBBC0
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x7FFE86FFBBD0
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFE86FFBBE0
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFE86FFBBF0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFE86FFBC00
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFE86FFBC10
        public void get_Physbone_Grab_Left(){} // RVA: 0x7FFE86FFBC20
        public void get_Physbone_Freeze_Left(){} // RVA: 0x7FFE86FFBC30
        public void get_Physbone_Grab_Right(){} // RVA: 0x7FFE86FFBC40
        public void get_Physbone_Freeze_Right(){} // RVA: 0x7FFE86FFBC50
        public void get_Scroll(){} // RVA: 0x7FFE86FFBC60
        public void get_Haptic(){} // RVA: 0x7FFE86FFBC70
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionSet_Menu : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Confirm(){} // RVA: 0x7FFE86FFBC80
        public void get_Back(){} // RVA: 0x7FFE86FFBC90
        public void get_Tab(){} // RVA: 0x7FFE86FFBCA0
        public void get_Scroll(){} // RVA: 0x7FFE86FFBCB0
        public void get_Quick_Menu_Close(){} // RVA: 0x7FFE86FFBCC0
        public void get_Drag(){} // RVA: 0x7FFE86FFBCD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ActionSet_One_Hand : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Interact(){} // RVA: 0x7FFE86FFBCE0
        public void get_Grab(){} // RVA: 0x7FFE86FFBCF0
        public void get_Move_Rotate(){} // RVA: 0x7FFE86FFBD00
        public void get_Jump(){} // RVA: 0x7FFE86FFBD10
        public void get_Mic(){} // RVA: 0x7FFE86FFBD20
        public void get_Gesture_Toggle(){} // RVA: 0x7FFE86FFBD30
        public void get_Stick_Click(){} // RVA: 0x7FFE86FFBD40
        public void get_Trigger_Axis(){} // RVA: 0x7FFE86FFBD50
        public void get_Grip_Axis(){} // RVA: 0x7FFE86FFBD60
        public void get_Udon_Menu(){} // RVA: 0x7FFE86FFBD70
        public void get_Drop(){} // RVA: 0x7FFE86FFBD80
        public void get_Start_Move_Rotate(){} // RVA: 0x7FFE86FFBD90
        public void get_Continue_Move_Rotate(){} // RVA: 0x7FFE86FFBDA0
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x7FFE86FFBDB0
        public void get_Menu(){} // RVA: 0x7FFE86FFBDC0
        public void get_Nameplates(){} // RVA: 0x7FFE86FFBDD0
        public void get_HUD(){} // RVA: 0x7FFE86FFBDE0
        public void get_Chatbox(){} // RVA: 0x7FFE86FFBDF0
        public void get_Face_Mirror(){} // RVA: 0x7FFE86FFBE00
        public void get_Personal_Mirror(){} // RVA: 0x7FFE86FFBE10
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7FFE86FFBE20
        public void get_Earmuffs(){} // RVA: 0x7FFE86FFBE30
        public void get_Camera(){} // RVA: 0x7FFE86FFBE40
        public void get_Stream_Camera(){} // RVA: 0x7FFE86FFBE50
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7FFE86FFBE60
        public void get_OSC_Debug_Screen(){} // RVA: 0x7FFE86FFBE70
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7FFE86FFBE80
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7FFE86FFBE90
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7FFE86FFBEA0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7FFE86FFBEB0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7FFE86FFBEC0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7FFE86FFBED0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7FFE86FFBEE0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7FFE86FFBEF0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7FFE86FFBF00
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7FFE86FFBF10
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7FFE86FFBF20
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7FFE86FFBF30
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7FFE86FFBF40
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7FFE86FFBF50
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7FFE86FFBF60
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7FFE86FFBF70
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7FFE86FFBF80
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7FFE86FFBF90
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7FFE86FFBFA0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7FFE86FFBFB0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7FFE86FFBFC0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7FFE86FFBFD0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7FFE86FFBFE0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7FFE86FFBFF0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7FFE86FFC000
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7FFE86FFC010
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7FFE86FFC020
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7FFE86FFC030
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7FFE86FFC040
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7FFE86FFC050
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7FFE86FFC060
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7FFE86FFC070
        public void get_Reserve_bool(){} // RVA: 0x7FFE86FFC080
        public void get_Reserve_vector1(){} // RVA: 0x7FFE86FFC090
        public void get_Reserve_vector2(){} // RVA: 0x7FFE86FFC0A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_BindingFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE870317C0
    }

    public class SteamVR_Input_BindingFile_ActionList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87031880
    }

    public class SteamVR_Input_BindingFile_Chord : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87031BA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE87031ED0
    }

    public class SteamVR_Input_BindingFile_Haptic : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE870320E0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_BindingFile_Pose : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87031F90
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_BindingFile_Skeleton : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87032230
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_BindingFile_Source : Object
    {
        // ── Methods ──
        public void GetOutput(){} // RVA: 0x7FFE87032380
        public void Equals(){} // RVA: 0x7FFE87032700
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE870328F0
    }

    public class SteamVR_Input_BindingFile_Source_Input : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87032A70
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE87032D60
    }

    public class SteamVR_Input_BindingFile_Source_Input_StringDictionary : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7FFE87032DA0
        public void GetHashCode(){} // RVA: 0x7FFE867A47B0
        public void .ctor(){} // RVA: 0x7FFE87032EE0
    }

    public class SteamVR_Input_Generator_Names : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ManifestFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ManifestFile_Application : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8702FF70
    }

    public class SteamVR_Input_ManifestFile_ApplicationString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding_ControllerTypes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87030390
    }

}