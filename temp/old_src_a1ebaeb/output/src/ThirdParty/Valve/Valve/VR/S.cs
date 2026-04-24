// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 100
// Methods: 2028

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR : Object
    {
        public object _instance; // 0x3389F020
        public object _hmd; // 0x3389F020, was: <hmd>k__BackingField
        public object _initializing; // 0x3389F020, was: <initializing>k__BackingField
        public object connected; // 0x3389F020
        public object _aspect; // 0x3389F020, was: <aspect>k__BackingField
        public object _textureBounds; // 0x3389F020, was: <textureBounds>k__BackingField
        public object runningTemporarySession; // 0x3389F020

        // ── Original Methods ──
        public void get_active(){} // RVA: 0x7ffaae6b1fc0
        public void get_enabled(){} // RVA: 0x7ffaae6b2020
        public void set_enabled(){} // RVA: 0x7ffaae6b2250
        public void get_instance(){} // RVA: 0x7ffaae6b22f0
        public void Initialize(){} // RVA: 0x7ffaae6b2450
        public void get_usingNativeSupport(){} // RVA: 0x7ffaae6b2610
        public void get_settings(){} // RVA: 0x7ffaae6b2660
        public void set_settings(){} // RVA: 0x7ffaae6b26c0
        public void ReportGeneralErrors(){} // RVA: 0x7ffaae6b2780
        public void CreateInstance(){} // RVA: 0x7ffaae6b2810
        public void ReportError(){} // RVA: 0x7ffaae6b2eb0
        public void get_hmd(){} // RVA: 0x7ffaa894d380
        public void set_hmd(){} // RVA: 0x7ffaa8933e30
        public void get_compositor(){} // RVA: 0x7ffaa89357c0
        public void set_compositor(){} // RVA: 0x7ffaa8998e80
        public void get_overlay(){} // RVA: 0x7ffaa89600c0
        public void set_overlay(){} // RVA: 0x7ffaa89600d0
        public void get_initializing(){} // RVA: 0x7ffaae6b3070
        public void set_initializing(){} // RVA: 0x7ffaae6b30d0
        public void get_calibrating(){} // RVA: 0x7ffaae6b3130
        public void set_calibrating(){} // RVA: 0x7ffaae6b3190
        public void get_outOfRange(){} // RVA: 0x7ffaae6b31f0
        public void set_outOfRange(){} // RVA: 0x7ffaae6b3250
        public void get_sceneWidth(){} // RVA: 0x7ffaa8a11210
        public void set_sceneWidth(){} // RVA: 0x7ffaa8a11220
        public void get_sceneHeight(){} // RVA: 0x7ffaa8e22440
        public void set_sceneHeight(){} // RVA: 0x7ffaa8e14fc0
        public void get_aspect(){} // RVA: 0x7ffaa9672970
        public void set_aspect(){} // RVA: 0x7ffaaa150900
        public void get_fieldOfView(){} // RVA: 0x7ffaa89fc630
        public void set_fieldOfView(){} // RVA: 0x7ffaa89fc640
        public void get_tanHalfFov(){} // RVA: 0x7ffaa99c9a50
        public void set_tanHalfFov(){} // RVA: 0x7ffaa8f4e3b0
        public void get_textureBounds(){} // RVA: 0x7ffaa89af740
        public void set_textureBounds(){} // RVA: 0x7ffaa895a200
        public void get_eyes(){} // RVA: 0x7ffaa89ad730
        public void set_eyes(){} // RVA: 0x7ffaa89ad740
        public void get_hmd_TrackingSystemName(){} // RVA: 0x7ffaae6b32b0
        public void get_hmd_ActualTrackingSystemName(){} // RVA: 0x7ffaae6b32c0
        public void get_hmd_ModelNumber(){} // RVA: 0x7ffaae6b32d0
        public void get_hmd_SerialNumber(){} // RVA: 0x7ffaae6b32e0
        public void get_hmd_Type(){} // RVA: 0x7ffaae6b32f0
        public void get_hmd_SecondsFromVsyncToPhotons(){} // RVA: 0x7ffaae6b3300
        public void get_hmd_DisplayFrequency(){} // RVA: 0x7ffaae6b3350
        public void InitializeTemporarySession(){} // RVA: 0x7ffaae6b3720
        public void ExitTemporarySession(){} // RVA: 0x7ffaae6b37e0
        public void GenerateAppKey(){} // RVA: 0x7ffaae6b3880
        public void GenerateCleanProductName(){} // RVA: 0x7ffaae6b3aa0
        public void IdentifyEditorApplication(){} // RVA: 0x7ffaae6b4810
        public void OnInitializing(){} // RVA: 0x7ffaae6b4c90
        public void OnCalibrating(){} // RVA: 0x7ffaae6b4d30
        public void OnOutOfRange(){} // RVA: 0x7ffaae6b4dd0
        public void OnDeviceConnected(){} // RVA: 0x7ffaae6b4e70
        public void OnNewPoses(){} // RVA: 0x7ffaae6b4f00
        public void .ctor(){} // RVA: 0x7ffaae6b5400
        public void Finalize(){} // RVA: 0x7ffaae6b6250
        public void Dispose(){} // RVA: 0x7ffaae6b6300
        public void Dispose(){} // RVA: 0x7ffaae6b6300
        public void SafeDispose(){} // RVA: 0x7ffaae6b6720
        public void .cctor(){} // RVA: 0x7ffaae6b6810
        // ── Binary Analysis Named ──
        public void GetHeadsetActivityLevel(){} // RVA: 0x7ffaae6b33a0
        public void GetTrackedDeviceString(){} // RVA: 0x7ffaae6b33f0
        public void GetStringProperty(){} // RVA: 0x7ffaae6b3530
        public void GetFloatProperty(){} // RVA: 0x7ffaae6b36d0
        public void GetManifestFile(){} // RVA: 0x7ffaae6b3c30
    }

    public class SteamVREnumEqualityComparer`1 : ValueType
    {
        // ── Original Methods ──
        public void Equals(){} // RVA: 0x7ffaa887e5c0
        // ── Binary Analysis Named ──
        public void GetHashCode(){} // RVA: 0x7ffaa887e5c0
    }

    public class SteamVR_Action : Object
    {
        public object startUpdatingSourceOnAccess; // 0x313CB810

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void CreateUninitialized(){} // RVA: 0x7ffaa8666840
        public void CreateUninitialized(){} // RVA: 0x7ffaa8666840
        public void TryNeedsInitData(){} // RVA: 0x7ffaa86491d0
        public void InitializeCopy(){} // RVA: 0x7ffaa8669e70
        public void get_fullPath(){} // RVA: 0x7ffaa86491d0
        public void get_handle(){} // RVA: 0x7ffaa86491d0
        public void get_actionSet(){} // RVA: 0x7ffaa86491d0
        public void get_direction(){} // RVA: 0x7ffaa8649ca0
        public void get_setActive(){} // RVA: 0x7ffaae65c1a0
        public void get_active(){} // RVA: 0x7ffaa864a040
        public void get_activeBinding(){} // RVA: 0x7ffaa864a040
        public void get_lastActive(){} // RVA: 0x7ffaa864a040
        public void get_lastActiveBinding(){} // RVA: 0x7ffaa864a040
        public void PreInitialize(){} // RVA: 0x7ffaa8660d80
        public void CreateUninitialized(){} // RVA: 0x7ffaa8666840
        public void CreateUninitialized(){} // RVA: 0x7ffaa8666840
        public void Initialize(){} // RVA: 0x7ffaa8661430
        public void IsUpdating(){} // RVA: 0x7ffaa864a650
        public void Equals(){} // RVA: 0x7ffaae65c300
        public void Equals(){} // RVA: 0x7ffaae65c300
        public void op_Inequality(){} // RVA: 0x7ffaae65c430
        public void op_Equality(){} // RVA: 0x7ffaae65c560
        public void FindExistingActionForPartialPath(){} // RVA: 0x7ffaae65c660
        public void ShowOrigins(){} // RVA: 0x7ffaae65c820
        public void HideOrigins(){} // RVA: 0x7ffaae65c8f0
        public void .cctor(){} // RVA: 0x7ffaae65c940
        // ── Binary Analysis Named ──
        public void GetCopy(){} // RVA: 0x7ffaa887e5c0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaa865df70
        public void GetSourceMap(){} // RVA: 0x7ffaa86491d0
        public void GetActive(){} // RVA: 0x7ffaa864a650
        public void GetSetActive(){} // RVA: 0x7ffaae65c200
        public void GetActiveBinding(){} // RVA: 0x7ffaa864a650
        public void GetLastActive(){} // RVA: 0x7ffaa864a650
        public void GetLastActiveBinding(){} // RVA: 0x7ffaa864a650
        public void GetPath(){} // RVA: 0x7ffaa894d380
        public void GetHashCode(){} // RVA: 0x7ffaae65c280
        public void GetShortName(){} // RVA: 0x7ffaae65c780
    }

    public class SteamVR_ActionSet : Object
    {
        public object initialized; // 0x318AA070
        public object allActions; // 0x1700002B

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void get_allActions(){} // RVA: 0x7ffaae65d580
        public void get_nonVisualInActions(){} // RVA: 0x7ffaae65d5c0
        public void get_visualActions(){} // RVA: 0x7ffaae65d600
        public void get_poseActions(){} // RVA: 0x7ffaae65d640
        public void get_skeletonActions(){} // RVA: 0x7ffaae65d680
        public void get_outActionArray(){} // RVA: 0x7ffaae65d6c0
        public void get_fullPath(){} // RVA: 0x7ffaae65d700
        public void get_usage(){} // RVA: 0x7ffaae65d740
        public void get_handle(){} // RVA: 0x7ffaae65d780
        public void Create(){} // RVA: 0x7ffaa887e5c0
        public void CreateFromName(){} // RVA: 0x7ffaa887e5c0
        public void PreInitialize(){} // RVA: 0x7ffaae65d7c0
        public void FinishPreInitialize(){} // RVA: 0x7ffaae65d940
        public void Initialize(){} // RVA: 0x7ffaae65d960
        public void IsActive(){} // RVA: 0x7ffaae65da40
        public void Activate(){} // RVA: 0x7ffaae65daf0
        public void Deactivate(){} // RVA: 0x7ffaae65dca0
        public void ShowBindingHints(){} // RVA: 0x7ffaae65de40
        public void ReadRawSetActive(){} // RVA: 0x7ffaae65df80
        public void ReadRawSetLastChanged(){} // RVA: 0x7ffaae65dfc0
        public void ReadRawSetPriority(){} // RVA: 0x7ffaae65e000
        public void Equals(){} // RVA: 0x7ffaae65e040
        public void Equals(){} // RVA: 0x7ffaae65e040
        public void op_Inequality(){} // RVA: 0x7ffaae65e150
        public void op_Equality(){} // RVA: 0x7ffaae65e210
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae65e2c0
        // ── Binary Analysis Named ──
        public void GetPath(){} // RVA: 0x7ffaa894d380
        public void GetTimeLastChanged(){} // RVA: 0x7ffaae65daa0
        public void GetShortName(){} // RVA: 0x7ffaae65ddb0
        public void GetActionSetData(){} // RVA: 0x7ffaa89357c0
        public void GetCopy(){} // RVA: 0x7ffaa887e5c0
        public void GetHashCode(){} // RVA: 0x7ffaae65c280
    }

    public class SteamVR_ActionSet_Manager : Object
    {
        public object currentArraySize; // 0x335898B0
        public object debugActiveSetListText; // 0x335898B0

        // ── Original Methods ──
        public void get_rawActiveActionSetArray(){} // RVA: 0x7ffaae65f670
        public void Initialize(){} // RVA: 0x7ffaae65f6f0
        public void DisableAllActionSets(){} // RVA: 0x7ffaae65f8a0
        public void UpdateActionStates(){} // RVA: 0x7ffaae65f9e0
        public void UpdateActionSetsArray(){} // RVA: 0x7ffaae65fe80
        public void UpdateDebugText(){} // RVA: 0x7ffaae6604b0
        // ── Binary Analysis Named ──
        public void SetChanged(){} // RVA: 0x7ffaae65fd00
        public void GetNewArraySize(){} // RVA: 0x7ffaae65fd40
        public void GetSetFromHandle(){} // RVA: 0x7ffaae660390
    }

    public class SteamVR_Action_Boolean : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void add_onChange(){} // RVA: 0x7ffaae660950
        public void remove_onChange(){} // RVA: 0x7ffaae6609d0
        public void add_onUpdate(){} // RVA: 0x7ffaae660a50
        public void remove_onUpdate(){} // RVA: 0x7ffaae660ad0
        public void add_onState(){} // RVA: 0x7ffaae660b50
        public void remove_onState(){} // RVA: 0x7ffaae660bd0
        public void add_onStateDown(){} // RVA: 0x7ffaae660c50
        public void remove_onStateDown(){} // RVA: 0x7ffaae660cd0
        public void add_onStateUp(){} // RVA: 0x7ffaae660d50
        public void remove_onStateUp(){} // RVA: 0x7ffaae660dd0
        public void add_onActiveChange(){} // RVA: 0x7ffaae660e50
        public void remove_onActiveChange(){} // RVA: 0x7ffaae660ed0
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae660f50
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae660fd0
        public void get_state(){} // RVA: 0x7ffaae661050
        public void get_stateDown(){} // RVA: 0x7ffaae6610e0
        public void get_stateUp(){} // RVA: 0x7ffaae661170
        public void get_lastState(){} // RVA: 0x7ffaae661200
        public void get_lastStateDown(){} // RVA: 0x7ffaae661260
        public void get_lastStateUp(){} // RVA: 0x7ffaae6612e0
        public void .ctor(){} // RVA: 0x7ffaae661360
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae661710
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae661790
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7ffaae661810
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7ffaae661890
        public void AddOnChangeListener(){} // RVA: 0x7ffaae661910
        public void RemoveOnChangeListener(){} // RVA: 0x7ffaae661990
        public void AddOnUpdateListener(){} // RVA: 0x7ffaae661a10
        public void RemoveOnUpdateListener(){} // RVA: 0x7ffaae661a90
        public void AddOnStateDownListener(){} // RVA: 0x7ffaae661b10
        public void RemoveOnStateDownListener(){} // RVA: 0x7ffaae661b90
        public void AddOnStateUpListener(){} // RVA: 0x7ffaae661c10
        public void RemoveOnStateUpListener(){} // RVA: 0x7ffaae661c90
        public void RemoveAllListeners(){} // RVA: 0x7ffaae661d10
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae661d80
        // ── Binary Analysis Named ──
        public void GetStateDown(){} // RVA: 0x7ffaae6613a0
        public void GetStateUp(){} // RVA: 0x7ffaae661440
        public void GetState(){} // RVA: 0x7ffaae6614e0
        public void GetLastStateDown(){} // RVA: 0x7ffaae661580
        public void GetLastStateUp(){} // RVA: 0x7ffaae661610
        public void GetLastState(){} // RVA: 0x7ffaae6616a0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Original Methods ──
        public void IsUpdating(){} // RVA: 0x7ffaac3b2720
        public void OnAccessSource(){} // RVA: 0x7ffaac3b27d0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b2860
        public void UpdateValues(){} // RVA: 0x7ffaac3b2a10
        public void .ctor(){} // RVA: 0x7ffaac3b2af0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Original Methods ──
        public void IsUpdating(){} // RVA: 0x7ffaa864a650
        public void OnAccessSource(){} // RVA: 0x7ffaa8661210
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaa8661210
        public void UpdateValues(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaa864a040
        public void get_lastChanged(){} // RVA: 0x7ffaa864a040
        public void get_changedTime(){} // RVA: 0x7ffaa865dbc0
        public void get_updateTime(){} // RVA: 0x7ffaa865dbc0
        public void get_activeOrigin(){} // RVA: 0x7ffaa86491d0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaa86491d0
        public void get_activeDevice(){} // RVA: 0x7ffaa8649ca0
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaa8649ca0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaa86491d0
        public void get_localizedOriginName(){} // RVA: 0x7ffaa86491d0
        public void UpdateValues(){} // RVA: 0x7ffaa8660cc0
        public void IsUpdating(){} // RVA: 0x7ffaa864a650
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaa8661210
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaa8658120
        public void GetActiveDevice(){} // RVA: 0x7ffaa8650410
        public void GetDeviceIndex(){} // RVA: 0x7ffaa8650410
        public void GetChanged(){} // RVA: 0x7ffaa864a650
        public void GetTimeLastChanged(){} // RVA: 0x7ffaa865df70
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaa86592d0
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaa8658120
        public void GetControllerType(){} // RVA: 0x7ffaa8658120
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaac3b2bd0
        public void get_lastChanged(){} // RVA: 0x7ffaac3b2bd0
        public void get_changedTime(){} // RVA: 0x7ffaac3b2c20
        public void get_updateTime(){} // RVA: 0x7ffaac3b2c60
        public void get_activeOrigin(){} // RVA: 0x7ffaac3b2ca0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaac3b2cf0
        public void get_activeDevice(){} // RVA: 0x7ffaac3b2d40
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaac3b2dd0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaac3b2e20
        public void get_localizedOriginName(){} // RVA: 0x7ffaac3b2e70
        public void UpdateValues(){} // RVA: 0x7ffaac3b2ec0
        public void IsUpdating(){} // RVA: 0x7ffaac3b3200
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ffaac3b32c0
        public void .ctor(){} // RVA: 0x7ffaac3b3390
        // ── Binary Analysis Named ──
        public void GetRenderModelComponentName(){} // RVA: 0x7ffaac3b2fb0
        public void GetActiveDevice(){} // RVA: 0x7ffaac3b3000
        public void GetDeviceIndex(){} // RVA: 0x7ffaac3b3090
        public void GetChanged(){} // RVA: 0x7ffaac3b30e0
        public void GetTimeLastChanged(){} // RVA: 0x7ffaac3b3130
        public void GetLocalizedOriginPart(){} // RVA: 0x7ffaac3b3170
        public void GetLocalizedOrigin(){} // RVA: 0x7ffaac3b31c0
        public void GetControllerType(){} // RVA: 0x7ffaac3b32f0
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaac3b3410
    }

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Original Methods ──
        public void add_onActiveChange(){} // RVA: 0x7ffaae664680
        public void remove_onActiveChange(){} // RVA: 0x7ffaae664700
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae664780
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae6648c0
        public void add_onChange(){} // RVA: 0x7ffaae664940
        public void remove_onChange(){} // RVA: 0x7ffaae6649c0
        public void add_onUpdate(){} // RVA: 0x7ffaae664a40
        public void remove_onUpdate(){} // RVA: 0x7ffaae664ac0
        public void add_onTrackingChanged(){} // RVA: 0x7ffaae664b40
        public void remove_onTrackingChanged(){} // RVA: 0x7ffaae664bc0
        public void add_onValidPoseChanged(){} // RVA: 0x7ffaae664c40
        public void remove_onValidPoseChanged(){} // RVA: 0x7ffaae664cc0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7ffaae664d40
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7ffaae664dc0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7ffaae664e40
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7ffaae664ec0
        public void AddOnTrackingChanged(){} // RVA: 0x7ffaae664f40
        public void RemoveOnTrackingChanged(){} // RVA: 0x7ffaae664fc0
        public void AddOnValidPoseChanged(){} // RVA: 0x7ffaae665040
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7ffaae6650c0
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae665140
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae6651c0
        public void AddOnChangeListener(){} // RVA: 0x7ffaae665240
        public void RemoveOnChangeListener(){} // RVA: 0x7ffaae6652c0
        public void AddOnUpdateListener(){} // RVA: 0x7ffaae665340
        public void RemoveOnUpdateListener(){} // RVA: 0x7ffaae6653c0
        public void RemoveAllListeners(){} // RVA: 0x7ffaae665440
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae6654c0
        public void .ctor(){} // RVA: 0x7ffaae665710
        // ── Binary Analysis Named ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7ffaae665500
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void get_localPosition(){} // RVA: 0x7ffaa8648be0
        public void get_localRotation(){} // RVA: 0x7ffaa8648be0
        public void get_trackingState(){} // RVA: 0x7ffaa8649ca0
        public void get_velocity(){} // RVA: 0x7ffaa8648be0
        public void get_angularVelocity(){} // RVA: 0x7ffaa8648be0
        public void get_poseIsValid(){} // RVA: 0x7ffaa864a040
        public void get_deviceIsConnected(){} // RVA: 0x7ffaa864a040
        public void get_lastLocalPosition(){} // RVA: 0x7ffaa8648be0
        public void get_lastLocalRotation(){} // RVA: 0x7ffaa8648be0
        public void get_lastTrackingState(){} // RVA: 0x7ffaa8649ca0
        public void get_lastVelocity(){} // RVA: 0x7ffaa8648be0
        public void get_lastAngularVelocity(){} // RVA: 0x7ffaa8648be0
        public void get_lastPoseIsValid(){} // RVA: 0x7ffaa864a040
        public void get_lastDeviceIsConnected(){} // RVA: 0x7ffaa864a040
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void UpdateValues(){} // RVA: 0x7ffaa86613a0
        public void UpdateTransform(){} // RVA: 0x7ffaa8662f00
        // ── Binary Analysis Named ──
        public void SetUniverseOrigin(){} // RVA: 0x7ffaa8662110
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7ffaa887e5c0
        public void GetPoseAtTimeOffset(){} // RVA: 0x7ffaa887e5c0
        public void GetLocalPosition(){} // RVA: 0x7ffaa8649f30
        public void GetLocalRotation(){} // RVA: 0x7ffaa8649f30
        public void GetVelocity(){} // RVA: 0x7ffaa8649f30
        public void GetAngularVelocity(){} // RVA: 0x7ffaa8649f30
        public void GetDeviceIsConnected(){} // RVA: 0x7ffaa864a650
        public void GetPoseIsValid(){} // RVA: 0x7ffaa864a650
        public void GetTrackingResult(){} // RVA: 0x7ffaa8650410
        public void GetLastLocalPosition(){} // RVA: 0x7ffaa8649f30
        public void GetLastLocalRotation(){} // RVA: 0x7ffaa8649f30
        public void GetLastVelocity(){} // RVA: 0x7ffaa8649f30
        public void GetLastAngularVelocity(){} // RVA: 0x7ffaa8649f30
        public void GetLastDeviceIsConnected(){} // RVA: 0x7ffaa864a650
        public void GetLastPoseIsValid(){} // RVA: 0x7ffaa864a650
        public void GetLastTrackingResult(){} // RVA: 0x7ffaa8650410
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void get_localPosition(){} // RVA: 0x7ffaac3b3640
        public void get_localRotation(){} // RVA: 0x7ffaac3b3690
        public void get_trackingState(){} // RVA: 0x7ffaac3b36e0
        public void get_velocity(){} // RVA: 0x7ffaac3b3720
        public void get_angularVelocity(){} // RVA: 0x7ffaac3b3770
        public void get_poseIsValid(){} // RVA: 0x7ffaac3b37c0
        public void get_deviceIsConnected(){} // RVA: 0x7ffaac3b3800
        public void get_lastLocalPosition(){} // RVA: 0x7ffaac3b3840
        public void get_lastLocalRotation(){} // RVA: 0x7ffaac3b3890
        public void get_lastTrackingState(){} // RVA: 0x7ffaac3b38e0
        public void get_lastVelocity(){} // RVA: 0x7ffaac3b3920
        public void get_lastAngularVelocity(){} // RVA: 0x7ffaac3b3970
        public void get_lastPoseIsValid(){} // RVA: 0x7ffaac3b39c0
        public void get_lastDeviceIsConnected(){} // RVA: 0x7ffaac3b3a00
        public void .ctor(){} // RVA: 0x7ffaac3b3a40
        public void UpdateValues(){} // RVA: 0x7ffaac3b3a60
        public void UpdateTransform(){} // RVA: 0x7ffaac3b3b70
        // ── Binary Analysis Named ──
        public void SetUniverseOrigin(){} // RVA: 0x7ffaac3b3490
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7ffaac3b3a90
        public void GetPoseAtTimeOffset(){} // RVA: 0x7ffaac3b3af0
        public void GetLocalPosition(){} // RVA: 0x7ffaac3b3c80
        public void GetLocalRotation(){} // RVA: 0x7ffaac3b3ce0
        public void GetVelocity(){} // RVA: 0x7ffaac3b3d30
        public void GetAngularVelocity(){} // RVA: 0x7ffaac3b3d90
        public void GetDeviceIsConnected(){} // RVA: 0x7ffaac3b3df0
        public void GetPoseIsValid(){} // RVA: 0x7ffaac3b3e30
        public void GetTrackingResult(){} // RVA: 0x7ffaac3b3e70
        public void GetLastLocalPosition(){} // RVA: 0x7ffaac3b3eb0
        public void GetLastLocalRotation(){} // RVA: 0x7ffaac3b3f10
        public void GetLastVelocity(){} // RVA: 0x7ffaac3b3f60
        public void GetLastAngularVelocity(){} // RVA: 0x7ffaac3b3fc0
        public void GetLastDeviceIsConnected(){} // RVA: 0x7ffaac3b4020
        public void GetLastPoseIsValid(){} // RVA: 0x7ffaac3b4060
        public void GetLastTrackingResult(){} // RVA: 0x7ffaac3b40a0
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void get_localPosition(){} // RVA: 0x7ffaac3b3640
        public void get_localRotation(){} // RVA: 0x7ffaac3b3690
        public void get_trackingState(){} // RVA: 0x7ffaac3b36e0
        public void get_velocity(){} // RVA: 0x7ffaac3b3720
        public void get_angularVelocity(){} // RVA: 0x7ffaac3b3770
        public void get_poseIsValid(){} // RVA: 0x7ffaac3b37c0
        public void get_deviceIsConnected(){} // RVA: 0x7ffaac3b3800
        public void get_lastLocalPosition(){} // RVA: 0x7ffaac3b3840
        public void get_lastLocalRotation(){} // RVA: 0x7ffaac3b3890
        public void get_lastTrackingState(){} // RVA: 0x7ffaac3b38e0
        public void get_lastVelocity(){} // RVA: 0x7ffaac3b3920
        public void get_lastAngularVelocity(){} // RVA: 0x7ffaac3b3970
        public void get_lastPoseIsValid(){} // RVA: 0x7ffaac3b39c0
        public void get_lastDeviceIsConnected(){} // RVA: 0x7ffaac3b3a00
        public void .ctor(){} // RVA: 0x7ffaac3b3a40
        public void UpdateValues(){} // RVA: 0x7ffaac3b3a60
        public void UpdateTransform(){} // RVA: 0x7ffaac3b3b70
        // ── Binary Analysis Named ──
        public void SetUniverseOrigin(){} // RVA: 0x7ffaac3b3490
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7ffaac3b3a90
        public void GetPoseAtTimeOffset(){} // RVA: 0x7ffaac3b3af0
        public void GetLocalPosition(){} // RVA: 0x7ffaac3b3c80
        public void GetLocalRotation(){} // RVA: 0x7ffaac3b3ce0
        public void GetVelocity(){} // RVA: 0x7ffaac3b3d30
        public void GetAngularVelocity(){} // RVA: 0x7ffaac3b3d90
        public void GetDeviceIsConnected(){} // RVA: 0x7ffaac3b3df0
        public void GetPoseIsValid(){} // RVA: 0x7ffaac3b3e30
        public void GetTrackingResult(){} // RVA: 0x7ffaac3b3e70
        public void GetLastLocalPosition(){} // RVA: 0x7ffaac3b3eb0
        public void GetLastLocalRotation(){} // RVA: 0x7ffaac3b3f10
        public void GetLastVelocity(){} // RVA: 0x7ffaac3b3f60
        public void GetLastAngularVelocity(){} // RVA: 0x7ffaac3b3fc0
        public void GetLastDeviceIsConnected(){} // RVA: 0x7ffaac3b4020
        public void GetLastPoseIsValid(){} // RVA: 0x7ffaac3b4060
        public void GetLastTrackingResult(){} // RVA: 0x7ffaac3b40a0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Original Methods ──
        public void UpdateValues(){} // RVA: 0x7ffaa86613a0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7ffaa8661210
    }

    public class SteamVR_Action_Single : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void add_onChange(){} // RVA: 0x7ffaae668b70
        public void remove_onChange(){} // RVA: 0x7ffaae668bf0
        public void add_onUpdate(){} // RVA: 0x7ffaae668c70
        public void remove_onUpdate(){} // RVA: 0x7ffaae668cf0
        public void add_onAxis(){} // RVA: 0x7ffaae668d70
        public void remove_onAxis(){} // RVA: 0x7ffaae668df0
        public void add_onActiveChange(){} // RVA: 0x7ffaae668e70
        public void remove_onActiveChange(){} // RVA: 0x7ffaae668ef0
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae668f70
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae668ff0
        public void get_axis(){} // RVA: 0x7ffaae669070
        public void get_lastAxis(){} // RVA: 0x7ffaae669100
        public void get_delta(){} // RVA: 0x7ffaae669190
        public void get_lastDelta(){} // RVA: 0x7ffaae669220
        public void .ctor(){} // RVA: 0x7ffaae6692b0
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae669570
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae6695f0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7ffaae669670
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7ffaae6696f0
        public void AddOnChangeListener(){} // RVA: 0x7ffaae669770
        public void RemoveOnChangeListener(){} // RVA: 0x7ffaae6697f0
        public void AddOnUpdateListener(){} // RVA: 0x7ffaae669870
        public void RemoveOnUpdateListener(){} // RVA: 0x7ffaae6698f0
        public void AddOnAxisListener(){} // RVA: 0x7ffaae669970
        public void RemoveOnAxisListener(){} // RVA: 0x7ffaae6699f0
        public void RemoveAllListeners(){} // RVA: 0x7ffaae669a70
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae669ae0
        // ── Binary Analysis Named ──
        public void GetAxis(){} // RVA: 0x7ffaae6692f0
        public void GetAxisDelta(){} // RVA: 0x7ffaae669390
        public void GetLastAxis(){} // RVA: 0x7ffaae669430
        public void GetLastAxisDelta(){} // RVA: 0x7ffaae6694d0
    }

    public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base`2
    {
        // ── Original Methods ──
        public void add_onActiveChange(){} // RVA: 0x7ffaae66b740
        public void remove_onActiveChange(){} // RVA: 0x7ffaae66b7c0
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae66b840
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae66b980
        public void add_onChange(){} // RVA: 0x7ffaae66ba00
        public void remove_onChange(){} // RVA: 0x7ffaae66ba80
        public void add_onUpdate(){} // RVA: 0x7ffaae66bb00
        public void remove_onUpdate(){} // RVA: 0x7ffaae66bb80
        public void add_onTrackingChanged(){} // RVA: 0x7ffaae66bc00
        public void remove_onTrackingChanged(){} // RVA: 0x7ffaae66bc80
        public void add_onValidPoseChanged(){} // RVA: 0x7ffaae66bd00
        public void remove_onValidPoseChanged(){} // RVA: 0x7ffaae66bd80
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7ffaae66be00
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7ffaae66be80
        public void .ctor(){} // RVA: 0x7ffaae66bf00
        public void UpdateValue(){} // RVA: 0x7ffaae66bf50
        public void UpdateValueWithoutEvents(){} // RVA: 0x7ffaae66bfd0
        public void UpdateTransform(){} // RVA: 0x7ffaae66c050
        public void get_bonePositions(){} // RVA: 0x7ffaae66c180
        public void get_boneRotations(){} // RVA: 0x7ffaae66c1e0
        public void get_lastBonePositions(){} // RVA: 0x7ffaae66c240
        public void get_lastBoneRotations(){} // RVA: 0x7ffaae66c2a0
        public void get_rangeOfMotion(){} // RVA: 0x7ffaae66c300
        public void set_rangeOfMotion(){} // RVA: 0x7ffaae66c360
        public void get_skeletalTransformSpace(){} // RVA: 0x7ffaae66c3d0
        public void set_skeletalTransformSpace(){} // RVA: 0x7ffaae66c430
        public void get_summaryDataType(){} // RVA: 0x7ffaae66c4a0
        public void set_summaryDataType(){} // RVA: 0x7ffaae66c500
        public void get_skeletalTrackingLevel(){} // RVA: 0x7ffaae66c570
        public void get_thumbCurl(){} // RVA: 0x7ffaae66c5e0
        public void get_indexCurl(){} // RVA: 0x7ffaae66c660
        public void get_middleCurl(){} // RVA: 0x7ffaae66c6e0
        public void get_ringCurl(){} // RVA: 0x7ffaae66c760
        public void get_pinkyCurl(){} // RVA: 0x7ffaae66c7e0
        public void get_thumbIndexSplay(){} // RVA: 0x7ffaae66c860
        public void get_indexMiddleSplay(){} // RVA: 0x7ffaae66c8e0
        public void get_middleRingSplay(){} // RVA: 0x7ffaae66c960
        public void get_ringPinkySplay(){} // RVA: 0x7ffaae66c9e0
        public void get_lastThumbCurl(){} // RVA: 0x7ffaae66ca60
        public void get_lastIndexCurl(){} // RVA: 0x7ffaae66cae0
        public void get_lastMiddleCurl(){} // RVA: 0x7ffaae66cb60
        public void get_lastRingCurl(){} // RVA: 0x7ffaae66cbe0
        public void get_lastPinkyCurl(){} // RVA: 0x7ffaae66cc60
        public void get_lastThumbIndexSplay(){} // RVA: 0x7ffaae66cce0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7ffaae66cd60
        public void get_lastMiddleRingSplay(){} // RVA: 0x7ffaae66cde0
        public void get_lastRingPinkySplay(){} // RVA: 0x7ffaae66ce60
        public void get_fingerCurls(){} // RVA: 0x7ffaae66cee0
        public void get_fingerSplays(){} // RVA: 0x7ffaae66cf40
        public void get_lastFingerCurls(){} // RVA: 0x7ffaae66cfa0
        public void get_lastFingerSplays(){} // RVA: 0x7ffaae66d000
        public void get_poseChanged(){} // RVA: 0x7ffaae66d060
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7ffaae66d0c0
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7ffaae66d120
        public void get_boneCount(){} // RVA: 0x7ffaae66d980
        public void RemoveAllListeners(){} // RVA: 0x7ffaae66e6e0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7ffaae66e760
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7ffaae66e7e0
        public void AddOnTrackingChanged(){} // RVA: 0x7ffaae66e860
        public void RemoveOnTrackingChanged(){} // RVA: 0x7ffaae66e8e0
        public void AddOnValidPoseChanged(){} // RVA: 0x7ffaae66e960
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7ffaae66e9e0
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae66ea60
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae66eae0
        public void AddOnChangeListener(){} // RVA: 0x7ffaae66eb60
        public void RemoveOnChangeListener(){} // RVA: 0x7ffaae66ebe0
        public void AddOnUpdateListener(){} // RVA: 0x7ffaae66ec60
        public void RemoveOnUpdateListener(){} // RVA: 0x7ffaae66ece0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae66ed60
        public void .cctor(){} // RVA: 0x7ffaae66eda0
        // ── Binary Analysis Named ──
        public void GetActive(){} // RVA: 0x7ffaae66d190
        public void GetSetActive(){} // RVA: 0x7ffaae65c1a0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7ffaae66d200
        public void GetPoseAtTimeOffset(){} // RVA: 0x7ffaae66d2a0
        public void GetLocalPosition(){} // RVA: 0x7ffaae66d340
        public void GetLocalRotation(){} // RVA: 0x7ffaae66d3c0
        public void GetVelocity(){} // RVA: 0x7ffaae66d440
        public void GetAngularVelocity(){} // RVA: 0x7ffaae66d4c0
        public void GetDeviceIsConnected(){} // RVA: 0x7ffaae66d540
        public void GetPoseIsValid(){} // RVA: 0x7ffaae66d5a0
        public void GetTrackingResult(){} // RVA: 0x7ffaae66d600
        public void GetLastLocalPosition(){} // RVA: 0x7ffaae66d660
        public void GetLastLocalRotation(){} // RVA: 0x7ffaae66d6e0
        public void GetLastVelocity(){} // RVA: 0x7ffaae66d760
        public void GetLastAngularVelocity(){} // RVA: 0x7ffaae66d7e0
        public void GetLastDeviceIsConnected(){} // RVA: 0x7ffaae66d860
        public void GetLastPoseIsValid(){} // RVA: 0x7ffaae66d8c0
        public void GetLastTrackingResult(){} // RVA: 0x7ffaae66d920
        public void GetBonePositions(){} // RVA: 0x7ffaae66d9f0
        public void GetBoneRotations(){} // RVA: 0x7ffaae66dae0
        public void GetLastBonePositions(){} // RVA: 0x7ffaae66dbd0
        public void GetLastBoneRotations(){} // RVA: 0x7ffaae66dcc0
        public void SetRangeOfMotion(){} // RVA: 0x7ffaae66ddb0
        public void SetSkeletalTransformSpace(){} // RVA: 0x7ffaae66de20
        public void GetBoneCount(){} // RVA: 0x7ffaae66d980
        public void GetBoneHierarchy(){} // RVA: 0x7ffaae66de90
        public void GetBoneName(){} // RVA: 0x7ffaae66df00
        public void GetReferenceTransforms(){} // RVA: 0x7ffaae66df70
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7ffaae66dff0
        public void GetFingerCurls(){} // RVA: 0x7ffaae66e060
        public void GetLastFingerCurls(){} // RVA: 0x7ffaae66e150
        public void GetFingerSplays(){} // RVA: 0x7ffaae66e240
        public void GetLastFingerSplays(){} // RVA: 0x7ffaae66e330
        public void GetFingerCurl(){} // RVA: 0x7ffaae66e420
        public void GetSplay(){} // RVA: 0x7ffaae66e4b0
        public void GetFingerCurl(){} // RVA: 0x7ffaae66e420
        public void GetSplay(){} // RVA: 0x7ffaae66e4b0
        public void GetLastFingerCurl(){} // RVA: 0x7ffaae66e540
        public void GetLastSplay(){} // RVA: 0x7ffaae66e5d0
        public void GetLastFingerCurl(){} // RVA: 0x7ffaae66e540
        public void GetLastSplay(){} // RVA: 0x7ffaae66e5d0
        public void GetLocalizedName(){} // RVA: 0x7ffaae66e660
    }

    public class SteamVR_Action_Source_Map : Object
    {
        public object _actionSet; // 0x313CAB30, was: <actionSet>k__BackingField
        public object inLowered; // 0x313CAB30
        public object sources; // 0x820DD510
        public object sources; // 0x313AE208

        // ── Original Methods ──
        public void get_fullPath(){} // RVA: 0x7ffaa894d380
        public void set_fullPath(){} // RVA: 0x7ffaa8933e30
        public void get_handle(){} // RVA: 0x7ffaa89357c0
        public void set_handle(){} // RVA: 0x7ffaa92bb750
        public void get_actionSet(){} // RVA: 0x7ffaa89600c0
        public void set_actionSet(){} // RVA: 0x7ffaa89600d0
        public void get_direction(){} // RVA: 0x7ffaa8d14570
        public void set_direction(){} // RVA: 0x7ffaa90c0cd0
        public void PreInitialize(){} // RVA: 0x7ffaae65c980
        public void PreinitializeMap(){} // RVA: 0x7ffaa8662f00
        public void Initialize(){} // RVA: 0x7ffaae65cbd0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae65d050
        // ── Binary Analysis Named ──
        public void GetActionSetPath(){} // RVA: 0x7ffaae65cdc0
        public void GetActionDirection(){} // RVA: 0x7ffaae65ce40
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4260
        public void OnAccessSource(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaac3b4280
        public void PreinitializeMap(){} // RVA: 0x7ffaac3b4310
        public void .ctor(){} // RVA: 0x7ffaac3b4400
        // ── Binary Analysis Named ──
        public void GetSourceElementForIndexer(){} // RVA: 0x7ffaac3b43b0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4260
        public void OnAccessSource(){} // RVA: 0x7ffaa8932310
        public void Initialize(){} // RVA: 0x7ffaac3b4280
        public void PreinitializeMap(){} // RVA: 0x7ffaac3b4310
        public void .ctor(){} // RVA: 0x7ffaac3b4400
        // ── Binary Analysis Named ──
        public void GetSourceElementForIndexer(){} // RVA: 0x7ffaac3b43b0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void OnAccessSource(){} // RVA: 0x7ffaa8661210
        public void Initialize(){} // RVA: 0x7ffaa8660cc0
        public void PreinitializeMap(){} // RVA: 0x7ffaa8662f00
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetSourceElementForIndexer(){} // RVA: 0x7ffaa887e5c0
    }

    public class SteamVR_Action_Vector2 : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void add_onChange(){} // RVA: 0x7ffaae673d50
        public void remove_onChange(){} // RVA: 0x7ffaae673dd0
        public void add_onUpdate(){} // RVA: 0x7ffaae673e50
        public void remove_onUpdate(){} // RVA: 0x7ffaae673ed0
        public void add_onAxis(){} // RVA: 0x7ffaae673f50
        public void remove_onAxis(){} // RVA: 0x7ffaae673fd0
        public void add_onActiveChange(){} // RVA: 0x7ffaae674050
        public void remove_onActiveChange(){} // RVA: 0x7ffaae6740d0
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae674150
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae6741d0
        public void get_axis(){} // RVA: 0x7ffaae674250
        public void get_lastAxis(){} // RVA: 0x7ffaae6742d0
        public void get_delta(){} // RVA: 0x7ffaae674350
        public void get_lastDelta(){} // RVA: 0x7ffaae6743d0
        public void .ctor(){} // RVA: 0x7ffaae674450
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae674690
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae674710
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7ffaae674790
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7ffaae674810
        public void AddOnChangeListener(){} // RVA: 0x7ffaae674890
        public void RemoveOnChangeListener(){} // RVA: 0x7ffaae674910
        public void AddOnUpdateListener(){} // RVA: 0x7ffaae674990
        public void RemoveOnUpdateListener(){} // RVA: 0x7ffaae674a10
        public void AddOnAxisListener(){} // RVA: 0x7ffaae674a90
        public void RemoveOnAxisListener(){} // RVA: 0x7ffaae674b10
        public void RemoveAllListeners(){} // RVA: 0x7ffaae674b90
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae674c00
        // ── Binary Analysis Named ──
        public void GetAxis(){} // RVA: 0x7ffaae674490
        public void GetAxisDelta(){} // RVA: 0x7ffaae674510
        public void GetLastAxis(){} // RVA: 0x7ffaae674590
        public void GetLastAxisDelta(){} // RVA: 0x7ffaae674610
    }

    public class SteamVR_Action_Vector3 : SteamVR_Action_In`2
    {
        // ── Original Methods ──
        public void add_onChange(){} // RVA: 0x7ffaae68c330
        public void remove_onChange(){} // RVA: 0x7ffaae68c3b0
        public void add_onUpdate(){} // RVA: 0x7ffaae68c430
        public void remove_onUpdate(){} // RVA: 0x7ffaae68c4b0
        public void add_onAxis(){} // RVA: 0x7ffaae68c530
        public void remove_onAxis(){} // RVA: 0x7ffaae68c5b0
        public void add_onActiveChange(){} // RVA: 0x7ffaae68c630
        public void remove_onActiveChange(){} // RVA: 0x7ffaae68c6b0
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae68c730
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae68c7b0
        public void get_axis(){} // RVA: 0x7ffaae68c830
        public void get_lastAxis(){} // RVA: 0x7ffaae68c8b0
        public void get_delta(){} // RVA: 0x7ffaae68c930
        public void get_lastDelta(){} // RVA: 0x7ffaae68c9b0
        public void .ctor(){} // RVA: 0x7ffaae68ca30
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae68ccb0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae68cd30
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7ffaae68cdb0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7ffaae68ce30
        public void AddOnChangeListener(){} // RVA: 0x7ffaae68ceb0
        public void RemoveOnChangeListener(){} // RVA: 0x7ffaae68cf30
        public void AddOnUpdateListener(){} // RVA: 0x7ffaae68cfb0
        public void RemoveOnUpdateListener(){} // RVA: 0x7ffaae68d030
        public void AddOnAxisListener(){} // RVA: 0x7ffaae68d0b0
        public void RemoveOnAxisListener(){} // RVA: 0x7ffaae68d130
        public void RemoveAllListeners(){} // RVA: 0x7ffaae68d1b0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae68d220
        // ── Binary Analysis Named ──
        public void GetAxis(){} // RVA: 0x7ffaae68ca70
        public void GetAxisDelta(){} // RVA: 0x7ffaae68cb00
        public void GetLastAxis(){} // RVA: 0x7ffaae68cb90
        public void GetLastAxisDelta(){} // RVA: 0x7ffaae68cc20
    }

    public class SteamVR_Action_Vibration : SteamVR_Action_Out`2
    {
        // ── Original Methods ──
        public void add_onActiveChange(){} // RVA: 0x7ffaae68eea0
        public void remove_onActiveChange(){} // RVA: 0x7ffaae68ef20
        public void add_onActiveBindingChange(){} // RVA: 0x7ffaae68efa0
        public void remove_onActiveBindingChange(){} // RVA: 0x7ffaae68f020
        public void add_onExecute(){} // RVA: 0x7ffaae68f0a0
        public void remove_onExecute(){} // RVA: 0x7ffaae68f120
        public void .ctor(){} // RVA: 0x7ffaae68f1a0
        public void Execute(){} // RVA: 0x7ffaae68f240
        public void AddOnActiveChangeListener(){} // RVA: 0x7ffaae68f2f0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7ffaae68f370
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7ffaae68f3f0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7ffaae68f470
        public void AddOnExecuteListener(){} // RVA: 0x7ffaae68f4f0
        public void RemoveOnExecuteListener(){} // RVA: 0x7ffaae68f570
        public void RemoveAllListeners(){} // RVA: 0x7ffaae68f5f0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7ffaa8932310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7ffaae68f6d0
        public void IsUpdating(){} // RVA: 0x7ffaae68f710
        // ── Binary Analysis Named ──
        public void GetTimeLastChanged(){} // RVA: 0x7ffaae68f660
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x313AE5C8

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x313AF1E8

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x313AFAC8

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x313CB480

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaa887e5c0
        public void get_fullPath(){} // RVA: 0x7ffaa86491d0
        public void get_handle(){} // RVA: 0x7ffaa86491d0
        public void get_actionSet(){} // RVA: 0x7ffaa86491d0
        public void get_direction(){} // RVA: 0x7ffaa8649ca0
        public void get_active(){} // RVA: 0x7ffaa864a040
        public void get_lastActive(){} // RVA: 0x7ffaa864a040
        public void get_activeBinding(){} // RVA: 0x7ffaa864a040
        public void get_lastActiveBinding(){} // RVA: 0x7ffaa864a040
        public void PreInitialize(){} // RVA: 0x7ffaa8660d80
        public void CreateUninitialized(){} // RVA: 0x7ffaa8666840
        public void CreateUninitialized(){} // RVA: 0x7ffaa8666840
        public void TryNeedsInitData(){} // RVA: 0x7ffaa86491d0
        public void Initialize(){} // RVA: 0x7ffaa8661430
        public void InitializeCopy(){} // RVA: 0x7ffaa8669e70
        public void InitAfterDeserialize(){} // RVA: 0x7ffaa8660cc0
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa86491d0
        public void GetActive(){} // RVA: 0x7ffaa864a650
        public void GetActiveBinding(){} // RVA: 0x7ffaa864a650
        public void GetLastActive(){} // RVA: 0x7ffaa864a650
        public void GetLastActiveBinding(){} // RVA: 0x7ffaa864a650
        public void GetActionBindingInfo(){} // RVA: 0x7ffaa86491d0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x3337BBD8
        public object Z,a; // 0x120084

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x335C03A8
        public object Item; // 0x17000002

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x336927B0
        public object Item; // 0x17000002

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x3377FAF0

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x33886970
        public object Za; // 0x120084
        public object Item; // 0x17000002

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x338BD4B0
        public object h3a; // 0x120084

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object inputBindingInfo_size; // 0x33C893F8
        public object Item; // 0x17000002

        // ── Original Methods ──
        public void get_Item(){} // RVA: 0x7ffaac3b4510
        public void get_fullPath(){} // RVA: 0x7ffaac3b4540
        public void get_handle(){} // RVA: 0x7ffaac3b4560
        public void get_actionSet(){} // RVA: 0x7ffaac3b4580
        public void get_direction(){} // RVA: 0x7ffaac3b45a0
        public void get_active(){} // RVA: 0x7ffaac3b45c0
        public void get_lastActive(){} // RVA: 0x7ffaac3b4610
        public void get_activeBinding(){} // RVA: 0x7ffaac3b4660
        public void get_lastActiveBinding(){} // RVA: 0x7ffaac3b46b0
        public void PreInitialize(){} // RVA: 0x7ffaac3b4700
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void CreateUninitialized(){} // RVA: 0x7ffaac3b4920
        public void TryNeedsInitData(){} // RVA: 0x7ffaac3b4b20
        public void Initialize(){} // RVA: 0x7ffaac3b4de0
        public void InitializeCopy(){} // RVA: 0x7ffaac3b4ef0
        public void InitAfterDeserialize(){} // RVA: 0x7ffaac3b5070
        public void .ctor(){} // RVA: 0x7ffaac3b58f0
        public void .cctor(){} // RVA: 0x7ffaac3b5940
        // ── Binary Analysis Named ──
        public void GetSourceMap(){} // RVA: 0x7ffaa8960130
        public void GetActive(){} // RVA: 0x7ffaac3b5120
        public void GetActiveBinding(){} // RVA: 0x7ffaac3b5170
        public void GetLastActive(){} // RVA: 0x7ffaac3b51c0
        public void GetLastActiveBinding(){} // RVA: 0x7ffaac3b5210
        public void GetActionBindingInfo(){} // RVA: 0x7ffaac3b5260
    }

    public class SteamVR_Actions : Object
    {
        public object p_global_SkeletonLeftHand; // 0x335D8CE0
        public object p_global_Menu; // 0x335D8CE0
        public object p_global_Main_Menu; // 0x335D8CE0
        public object p_global_Move; // 0x335D8CE0
        public object p_global_Mic; // 0x335D8CE0
        public object p_global_Trigger_Axis; // 0x335D8CE0
        public object p_global_Drop; // 0x335D8CE0
        public object p_global_Chatbox; // 0x335D8CE0
        public object p_global_Personal_Mirror_Lock; // 0x335D8CE0
        public object p_global_Stream_Camera; // 0x335D8CE0
        public object p_global_Confirm_FBT_Calibration; // 0x335D8CE0
        public object p_global_Continue_Move; // 0x335D8CE0
        public object p_global_No_Gesture_After_Rotate; // 0x335D8CE0
        public object p_global_Gesture_Activator_Thumb_Inner_Lower; // 0x335D8CE0
        public object p_global_Gesture_Activator_Grip; // 0x335D8CE0
        public object p_global_Gesture_Activator_Stick_Deflection; // 0x335D8CE0
        public object p_global_Gesture_Direct_Open_Left; // 0x335D8CE0
        public object p_global_Gesture_Direct_Finger_Gun_Left; // 0x335D8CE0
        public object p_global_Gesture_Direct_Neutral_Right; // 0x335D8CE0
        public object p_global_Gesture_Direct_Peace_Right; // 0x335D8CE0
        public object p_global_Gesture_Direct_Thumbs_Up_Right; // 0x335D8CE0
        public object p_global_Gesture_Wheel_Select_Left; // 0x335D8CE0
        public object p_global_Gesture_Wheel_Direct_Left; // 0x335D8CE0
        public object p_global_Gesture_Wheel_Cancel_Open_Left; // 0x335D8CE0
        public object p_global_Gesture_Wheel_Select_Right; // 0x335D8CE0
        public object p_global_Gesture_Wheel_Direct_Right; // 0x335D8CE0
        public object p_global_Gesture_Wheel_Cancel_Open_Right; // 0x335D8CE0
        public object p_global_Disable_Gesture_Wheel_Move_Left; // 0x335D8CE0
        public object p_global_Disable_Gesture_Wheel_Rotate_Right; // 0x335D8CE0
        public object p_global_Physbone_Grab_Right; // 0x335D8CE0
        public object p_global_Haptic; // 0x335D8CE0
        public object p_one_Hand_Move_Rotate; // 0x335D8CE0
        public object p_one_Hand_Gesture_Toggle; // 0x335D8CE0
        public object p_one_Hand_Grip_Axis; // 0x335D8CE0
        public object p_one_Hand_Start_Move_Rotate; // 0x335D8CE0
        public object p_one_Hand_Menu; // 0x335D8CE0
        public object p_one_Hand_Chatbox; // 0x335D8CE0
        public object p_one_Hand_Personal_Mirror_Lock; // 0x335D8CE0
        public object p_one_Hand_Stream_Camera; // 0x335D8CE0
        public object p_one_Hand_Confirm_FBT_Calibration; // 0x335D8CE0
        public object p_one_Hand_Gesture_Activator_Thumb_Inner_Lower; // 0x335D8CE0
        public object p_one_Hand_Gesture_Activator_Grip; // 0x335D8CE0
        public object p_one_Hand_Gesture_Activator_Stick_Deflection; // 0x335D8CE0
        public object p_one_Hand_Gesture_Wheel_Soft_Select_Left; // 0x335D8CE0
        public object p_one_Hand_Gesture_Wheel_Direct_Stay_Left; // 0x335D8CE0
        public object p_one_Hand_Gesture_Wheel_Held_Left; // 0x335D8CE0
        public object p_one_Hand_Gesture_Wheel_Soft_Select_Right; // 0x335D8CE0
        public object p_one_Hand_Gesture_Wheel_Direct_Stay_Right; // 0x335D8CE0
        public object p_one_Hand_Gesture_Wheel_Held_Right; // 0x335D8CE0
        public object p_one_Hand_Disable_Gesture_Wheel_Move_Right; // 0x335D8CE0
        public object p_one_Hand_Reserve_vector1; // 0x335D8CE0
        public object p_menu_Back; // 0x335D8CE0
        public object p_menu_Quick_Menu_Close; // 0x335D8CE0
        public object p_action_Menu_Select; // 0x335D8CE0
        public object p_action_Menu_Gesture_Activator_Thumb_Inner_Lower; // 0x335D8CE0
        public object p_action_Menu_Gesture_Activator_Grip; // 0x335D8CE0
        public object p_action_Menu_Gesture_Activator_Stick_Deflection; // 0x335D8CE0
        public object p_action_Menu_Gesture_Wheel_Soft_Select_Left; // 0x335D8CE0
        public object p_action_Menu_Gesture_Wheel_Direct_Stay_Left; // 0x335D8CE0
        public object p_action_Menu_Gesture_Wheel_Held_Left; // 0x335D8CE0
        public object p_action_Menu_Gesture_Wheel_Soft_Select_Right; // 0x335D8CE0
        public object p_action_Menu_Gesture_Wheel_Direct_Stay_Right; // 0x335D8CE0
        public object p_action_Menu_Gesture_Wheel_Held_Right; // 0x335D8CE0
        public object p_action_Menu_Disable_Gesture_Wheel_Move_Right; // 0x335D8CE0
        public object p_action_Menu_Reserve_vector1; // 0x335D8CE0
        public object p_action_Menu_Drop; // 0x335D8CE0
        public object p_drone_Self_Leveling_Mod; // 0x335D8CE0
        public object p_drone_Flip; // 0x335D8CE0
        public object p_drone_Toggle_Self_Leveling; // 0x335D8CE0
        public object p_drone_Select_Flight_Preset_Cinematic; // 0x335D8CE0
        public object p_Global; // 0x335D8CE0
        public object p_Action_Menu; // 0x335D8CE0

        // ── Original Methods ──
        public void get_global_Safe_Mode(){} // RVA: 0x7ffaae675af0
        public void get_global_Pose(){} // RVA: 0x7ffaae675b60
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7ffaae675bd0
        public void get_global_SkeletonRightHand(){} // RVA: 0x7ffaae675c40
        public void get_global_HeadsetOnHead(){} // RVA: 0x7ffaae675cb0
        public void get_global_Menu(){} // RVA: 0x7ffaae675d20
        public void get_global_Quick_Menu(){} // RVA: 0x7ffaae675d90
        public void get_global_Action_Menu(){} // RVA: 0x7ffaae675e00
        public void get_global_Main_Menu(){} // RVA: 0x7ffaae675e70
        public void get_global_Interact(){} // RVA: 0x7ffaae675ee0
        public void get_global_Grab(){} // RVA: 0x7ffaae675f50
        public void get_global_Move(){} // RVA: 0x7ffaae675fc0
        public void get_global_Jump(){} // RVA: 0x7ffaae676030
        public void get_global_Rotate(){} // RVA: 0x7ffaae6760a0
        public void get_global_Mic(){} // RVA: 0x7ffaae676110
        public void get_global_Gesture_Toggle(){} // RVA: 0x7ffaae676180
        public void get_global_Stick_Click(){} // RVA: 0x7ffaae6761f0
        public void get_global_Trigger_Axis(){} // RVA: 0x7ffaae676260
        public void get_global_Grip_Axis(){} // RVA: 0x7ffaae6762d0
        public void get_global_Udon_Menu(){} // RVA: 0x7ffaae676340
        public void get_global_Drop(){} // RVA: 0x7ffaae6763b0
        public void get_global_Nameplates(){} // RVA: 0x7ffaae676420
        public void get_global_HUD(){} // RVA: 0x7ffaae676490
        public void get_global_Chatbox(){} // RVA: 0x7ffaae676500
        public void get_global_Face_Mirror(){} // RVA: 0x7ffaae676570
        public void get_global_Personal_Mirror(){} // RVA: 0x7ffaae6765e0
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x7ffaae676650
        public void get_global_Earmuffs(){} // RVA: 0x7ffaae6766c0
        public void get_global_Camera(){} // RVA: 0x7ffaae676730
        public void get_global_Stream_Camera(){} // RVA: 0x7ffaae6767a0
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x7ffaae676810
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x7ffaae676880
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x7ffaae6768f0
        public void get_global_Start_Move(){} // RVA: 0x7ffaae676960
        public void get_global_Start_Rotate(){} // RVA: 0x7ffaae6769d0
        public void get_global_Continue_Move(){} // RVA: 0x7ffaae676a40
        public void get_global_Continue_Rotate(){} // RVA: 0x7ffaae676ab0
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x7ffaae676b20
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x7ffaae676b90
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x7ffaae676c00
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7ffaae676c70
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7ffaae676ce0
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7ffaae676d50
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x7ffaae676dc0
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x7ffaae676e30
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x7ffaae676ea0
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x7ffaae676f10
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7ffaae676f80
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x7ffaae676ff0
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x7ffaae677060
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x7ffaae6770d0
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x7ffaae677140
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x7ffaae6771b0
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7ffaae677220
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7ffaae677290
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x7ffaae677300
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x7ffaae677370
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x7ffaae6773e0
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x7ffaae677450
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x7ffaae6774c0
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x7ffaae677530
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7ffaae6775a0
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7ffaae677610
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x7ffaae677680
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x7ffaae6776f0
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x7ffaae677760
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7ffaae6777d0
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x7ffaae677840
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x7ffaae6778b0
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7ffaae677920
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7ffaae677990
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7ffaae677a00
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x7ffaae677a70
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x7ffaae677ae0
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x7ffaae677b50
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7ffaae677bc0
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x7ffaae677c30
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x7ffaae677ca0
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7ffaae677d10
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7ffaae677d80
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7ffaae677df0
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x7ffaae677e60
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x7ffaae677ed0
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7ffaae677f40
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7ffaae677fb0
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7ffaae678020
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7ffaae678090
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x7ffaae678100
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x7ffaae678170
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x7ffaae6781e0
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x7ffaae678250
        public void get_global_Scroll(){} // RVA: 0x7ffaae6782c0
        public void get_global_Haptic(){} // RVA: 0x7ffaae678330
        public void get_one_Hand_Interact(){} // RVA: 0x7ffaae6783a0
        public void get_one_Hand_Grab(){} // RVA: 0x7ffaae678410
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x7ffaae678480
        public void get_one_Hand_Jump(){} // RVA: 0x7ffaae6784f0
        public void get_one_Hand_Mic(){} // RVA: 0x7ffaae678560
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x7ffaae6785d0
        public void get_one_Hand_Stick_Click(){} // RVA: 0x7ffaae678640
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x7ffaae6786b0
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x7ffaae678720
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x7ffaae678790
        public void get_one_Hand_Drop(){} // RVA: 0x7ffaae678800
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x7ffaae678870
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x7ffaae6788e0
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x7ffaae678950
        public void get_one_Hand_Menu(){} // RVA: 0x7ffaae6789c0
        public void get_one_Hand_Nameplates(){} // RVA: 0x7ffaae678a30
        public void get_one_Hand_HUD(){} // RVA: 0x7ffaae678aa0
        public void get_one_Hand_Chatbox(){} // RVA: 0x7ffaae678b10
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x7ffaae678b80
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x7ffaae678bf0
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x7ffaae678c60
        public void get_one_Hand_Earmuffs(){} // RVA: 0x7ffaae678cd0
        public void get_one_Hand_Camera(){} // RVA: 0x7ffaae678d40
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x7ffaae678db0
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x7ffaae678e20
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x7ffaae678e90
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x7ffaae678f00
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x7ffaae678f70
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7ffaae678fe0
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7ffaae679050
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7ffaae6790c0
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x7ffaae679130
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7ffaae6791a0
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7ffaae679210
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x7ffaae679280
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7ffaae6792f0
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x7ffaae679360
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x7ffaae6793d0
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7ffaae679440
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x7ffaae6794b0
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x7ffaae679520
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7ffaae679590
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7ffaae679600
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7ffaae679670
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x7ffaae6796e0
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x7ffaae679750
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x7ffaae6797c0
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7ffaae679830
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x7ffaae6798a0
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7ffaae679910
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7ffaae679980
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7ffaae6799f0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7ffaae679a60
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x7ffaae679ad0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7ffaae679b40
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7ffaae679bb0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7ffaae679c20
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7ffaae679c90
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x7ffaae679d00
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x7ffaae679d70
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x7ffaae679de0
        public void get_menu_Confirm(){} // RVA: 0x7ffaae679e50
        public void get_menu_Back(){} // RVA: 0x7ffaae679ec0
        public void get_menu_Tab(){} // RVA: 0x7ffaae679f30
        public void get_menu_Scroll(){} // RVA: 0x7ffaae679fa0
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x7ffaae67a010
        public void get_menu_Drag(){} // RVA: 0x7ffaae67a080
        public void get_action_Menu_Axis(){} // RVA: 0x7ffaae67a0f0
        public void get_action_Menu_Select(){} // RVA: 0x7ffaae67a160
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x7ffaae67a1d0
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7ffaae67a240
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7ffaae67a2b0
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7ffaae67a320
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x7ffaae67a390
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x7ffaae67a400
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x7ffaae67a470
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x7ffaae67a4e0
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7ffaae67a550
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x7ffaae67a5c0
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x7ffaae67a630
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7ffaae67a6a0
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x7ffaae67a710
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x7ffaae67a780
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7ffaae67a7f0
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7ffaae67a860
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7ffaae67a8d0
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x7ffaae67a940
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x7ffaae67a9b0
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x7ffaae67aa20
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7ffaae67aa90
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x7ffaae67ab00
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x7ffaae67ab70
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7ffaae67abe0
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7ffaae67ac50
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7ffaae67acc0
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x7ffaae67ad30
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7ffaae67ada0
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7ffaae67ae10
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7ffaae67ae80
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7ffaae67aef0
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x7ffaae67af60
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x7ffaae67afd0
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x7ffaae67b040
        public void get_action_Menu_Grab(){} // RVA: 0x7ffaae67b0b0
        public void get_action_Menu_Drop(){} // RVA: 0x7ffaae67b120
        public void get_drone_Left_Joystick(){} // RVA: 0x7ffaae67b190
        public void get_drone_Right_Joystick(){} // RVA: 0x7ffaae67b200
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x7ffaae67b270
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x7ffaae67b2e0
        public void get_drone_Toggle_FPV(){} // RVA: 0x7ffaae67b350
        public void get_drone_Flip(){} // RVA: 0x7ffaae67b3c0
        public void get_drone_Take_Picture(){} // RVA: 0x7ffaae67b430
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x7ffaae67b4a0
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x7ffaae67b510
        public void get_drone_Respawn(){} // RVA: 0x7ffaae67b580
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x7ffaae67b5f0
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x7ffaae67b660
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x7ffaae67b6d0
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x7ffaae67b740
        public void InitializeActionArrays(){} // RVA: 0x7ffaae67b7b0
        public void PreInitActions(){} // RVA: 0x7ffaae684f50
        public void get_Global(){} // RVA: 0x7ffaae689d30
        public void get_One_Hand(){} // RVA: 0x7ffaae689da0
        public void get_Menu(){} // RVA: 0x7ffaae689e10
        public void get_Action_Menu(){} // RVA: 0x7ffaae689e80
        public void get_Drone(){} // RVA: 0x7ffaae689ef0
        public void StartPreInitActionSets(){} // RVA: 0x7ffaae689f60
        public void PreInitialize(){} // RVA: 0x7ffaae68a640
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_ActivateActionSetOnLoad : MonoBehaviour
    {
        public object disableAllOtherActionSets; // 0x33521730
        public object initialPriority; // 0x33521730

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae690810
        public void OnDestroy(){} // RVA: 0x7ffaae690880
        public void .ctor(){} // RVA: 0x7ffaae6908e0
    }

    public class SteamVR_Behaviour : MonoBehaviour
    {
        public object _instance; // 0x3348F860
        public object steamvr_render; // 0x3348F860
        public object initializeCoroutine; // 0x3348F860

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaae6b6910
        public void Initialize(){} // RVA: 0x7ffaae6b6a50
        public void Awake(){} // RVA: 0x7ffaae6b72f0
        public void InitializeSteamVR(){} // RVA: 0x7ffaae6b73f0
        public void XRDevice_deviceLoaded(){} // RVA: 0x7ffaae6b76e0
        public void EnableOpenVR(){} // RVA: 0x7ffaae6b77c0
        public void OnEnable(){} // RVA: 0x7ffaae6b78e0
        public void OnDisable(){} // RVA: 0x7ffaae6b7a80
        public void OnBeforeRender(){} // RVA: 0x7ffaae6b7c30
        public void PreCull(){} // RVA: 0x7ffaae6b7c40
        public void FixedUpdate(){} // RVA: 0x7ffaae6b7ec0
        public void LateUpdate(){} // RVA: 0x7ffaae6b8040
        public void Update(){} // RVA: 0x7ffaae6b81e0
        public void OnQuit(){} // RVA: 0x7ffaae6b8360
        public void .ctor(){} // RVA: 0x7ffaae6b83b0
        public void .cctor(){} // RVA: 0x7ffaae6b8400
        // ── Binary Analysis Named ──
        public void DoInitializeSteamVR(){} // RVA: 0x7ffaae6b7640
    }

    public class SteamVR_Behaviour_Boolean : MonoBehaviour
    {
        public object onChange; // 0x3345DE70
        public object onUpdateEvent; // 0x3345DE70
        public object onPressDown; // 0x3345DE70
        public object onPressUpEvent; // 0x3345DE70
        public object `;

        // ── Original Methods ──
        public void add_onChangeEvent(){} // RVA: 0x7ffaae6909e0
        public void remove_onChangeEvent(){} // RVA: 0x7ffaae690ad0
        public void add_onUpdateEvent(){} // RVA: 0x7ffaae690bc0
        public void remove_onUpdateEvent(){} // RVA: 0x7ffaae690cb0
        public void add_onPressEvent(){} // RVA: 0x7ffaae690da0
        public void remove_onPressEvent(){} // RVA: 0x7ffaae690e90
        public void add_onPressDownEvent(){} // RVA: 0x7ffaae690f80
        public void remove_onPressDownEvent(){} // RVA: 0x7ffaae691070
        public void add_onPressUpEvent(){} // RVA: 0x7ffaae691160
        public void remove_onPressUpEvent(){} // RVA: 0x7ffaae691250
        public void get_isActive(){} // RVA: 0x7ffaae691340
        public void get_actionSet(){} // RVA: 0x7ffaae691390
        public void OnEnable(){} // RVA: 0x7ffaae691490
        public void OnDisable(){} // RVA: 0x7ffaae691580
        public void AddHandlers(){} // RVA: 0x7ffaae691590
        public void RemoveHandlers(){} // RVA: 0x7ffaae691850
        public void SteamVR_Behaviour_Boolean_OnStateUp(){} // RVA: 0x7ffaae691bb0
        public void SteamVR_Behaviour_Boolean_OnStateDown(){} // RVA: 0x7ffaae691c30
        public void SteamVR_Behaviour_Boolean_OnState(){} // RVA: 0x7ffaae691cb0
        public void SteamVR_Behaviour_Boolean_OnUpdate(){} // RVA: 0x7ffaae691d30
        public void SteamVR_Behaviour_Boolean_OnChange(){} // RVA: 0x7ffaae691dd0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetLocalizedName(){} // RVA: 0x7ffaae691e70
    }

    public class SteamVR_Behaviour_BooleanEvent : UnityEvent`3
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bb70
    }

    public class SteamVR_Behaviour_Pose : MonoBehaviour
    {
        public object origin; // 0x3399C030
        public object onConnectedChanged; // 0x3399C030
        public object onTransformUpdatedEvent; // 0x3399C030
        public object onTrackingChangedEvent; // 0x3399C030
        public object deviceIndex; // 0x3399C030

        // ── Original Methods ──
        public void get_isValid(){} // RVA: 0x7ffaae692370
        public void get_isActive(){} // RVA: 0x7ffaae691340
        public void Start(){} // RVA: 0x7ffaae6923b0
        public void OnEnable(){} // RVA: 0x7ffaae692640
        public void OnDisable(){} // RVA: 0x7ffaae692930
        public void SteamVR_Behaviour_Pose_OnUpdate(){} // RVA: 0x7ffaae692ce0
        public void UpdateTransform(){} // RVA: 0x7ffaae692d80
        public void SteamVR_Behaviour_Pose_OnChange(){} // RVA: 0x7ffaae693490
        public void OnDeviceConnectedChanged(){} // RVA: 0x7ffaae693510
        public void OnTrackingChanged(){} // RVA: 0x7ffaae6935c0
        public void UpdateHistoryBuffer(){} // RVA: 0x7ffaae693b60
        public void .ctor(){} // RVA: 0x7ffaae693ec0
        // ── Binary Analysis Named ──
        public void CheckDeviceIndex(){} // RVA: 0x7ffaae693650
        public void GetDeviceIndex(){} // RVA: 0x7ffaae6938c0
        public void GetVelocity(){} // RVA: 0x7ffaae693900
        public void GetAngularVelocity(){} // RVA: 0x7ffaae693960
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7ffaae6939c0
        public void GetEstimatedPeakVelocities(){} // RVA: 0x7ffaae693a30
        public void GetLocalizedName(){} // RVA: 0x7ffaae693d80
    }

    public class SteamVR_Behaviour_PoseEvent : UnityEvent`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bc00
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bc90
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent : UnityEvent`3
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bd20
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent : UnityEvent`3
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bdb0
    }

    public class SteamVR_Behaviour_Single : MonoBehaviour
    {
        public object onChange; // 0x33914420
        public object onChangeEvent; // 0x33914420
        public object 8؏f; // 0xB41EDE30

        // ── Original Methods ──
        public void get_isActive(){} // RVA: 0x7ffaae6945a0
        public void OnEnable(){} // RVA: 0x7ffaae6945e0
        public void OnDisable(){} // RVA: 0x7ffaae6946d0
        public void AddHandlers(){} // RVA: 0x7ffaae6946e0
        public void RemoveHandlers(){} // RVA: 0x7ffaae6948a0
        public void SteamVR_Behaviour_Single_OnUpdate(){} // RVA: 0x7ffaae694b00
        public void SteamVR_Behaviour_Single_OnChange(){} // RVA: 0x7ffaae694bc0
        public void SteamVR_Behaviour_Single_OnAxis(){} // RVA: 0x7ffaae694c80
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetLocalizedName(){} // RVA: 0x7ffaae694d40
    }

    public class SteamVR_Behaviour_SingleEvent : UnityEvent`4
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65be40
    }

    public class SteamVR_Behaviour_Skeleton : MonoBehaviour
    {
        public object rangeOfMotion; // 0x33322140
        public object updatePose; // 0x33322140
        public object onBoneTransformsUpdated; // 0x33322140
        public object onConnectedChanged; // 0x33322140
        public object onTransformUpdatedEvent; // 0x33322140
        public object onTrackingChangedEvent; // 0x33322140
        public object fallbackCurlAction; // 0x33322140
        public object _proximals; // 0x33322140, was: <proximals>k__BackingField
        public object _tips; // 0x33322140, was: <tips>k__BackingField
        public object rangeOfMotionBlendRoutine; // 0x33322140
        public object temporaryRangeOfMotion; // 0x33322140

        // ── Original Methods ──
        public void get_skeletonAvailable(){} // RVA: 0x7ffaae6950f0
        public void get_isActive(){} // RVA: 0x7ffaae695120
        public void get_fingerCurls(){} // RVA: 0x7ffaae6951a0
        public void get_thumbCurl(){} // RVA: 0x7ffaae6952f0
        public void get_indexCurl(){} // RVA: 0x7ffaae695360
        public void get_middleCurl(){} // RVA: 0x7ffaae6953d0
        public void get_ringCurl(){} // RVA: 0x7ffaae695440
        public void get_pinkyCurl(){} // RVA: 0x7ffaae6954b0
        public void get_root(){} // RVA: 0x7ffaae695520
        public void get_wrist(){} // RVA: 0x7ffaae695550
        public void get_indexMetacarpal(){} // RVA: 0x7ffaae695580
        public void get_indexProximal(){} // RVA: 0x7ffaae6955b0
        public void get_indexMiddle(){} // RVA: 0x7ffaae6955e0
        public void get_indexDistal(){} // RVA: 0x7ffaae695610
        public void get_indexTip(){} // RVA: 0x7ffaae695640
        public void get_middleMetacarpal(){} // RVA: 0x7ffaae695670
        public void get_middleProximal(){} // RVA: 0x7ffaae6956a0
        public void get_middleMiddle(){} // RVA: 0x7ffaae6956d0
        public void get_middleDistal(){} // RVA: 0x7ffaae695700
        public void get_middleTip(){} // RVA: 0x7ffaae695730
        public void get_pinkyMetacarpal(){} // RVA: 0x7ffaae695760
        public void get_pinkyProximal(){} // RVA: 0x7ffaae695790
        public void get_pinkyMiddle(){} // RVA: 0x7ffaae6957c0
        public void get_pinkyDistal(){} // RVA: 0x7ffaae6957f0
        public void get_pinkyTip(){} // RVA: 0x7ffaae695820
        public void get_ringMetacarpal(){} // RVA: 0x7ffaae695850
        public void get_ringProximal(){} // RVA: 0x7ffaae695880
        public void get_ringMiddle(){} // RVA: 0x7ffaae6958b0
        public void get_ringDistal(){} // RVA: 0x7ffaae6958e0
        public void get_ringTip(){} // RVA: 0x7ffaae695910
        public void get_thumbMetacarpal(){} // RVA: 0x7ffaae695940
        public void get_thumbProximal(){} // RVA: 0x7ffaae695940
        public void get_thumbMiddle(){} // RVA: 0x7ffaae695970
        public void get_thumbDistal(){} // RVA: 0x7ffaae6959a0
        public void get_thumbTip(){} // RVA: 0x7ffaae6959d0
        public void get_thumbAux(){} // RVA: 0x7ffaae695a00
        public void get_indexAux(){} // RVA: 0x7ffaae695a30
        public void get_middleAux(){} // RVA: 0x7ffaae695a60
        public void get_ringAux(){} // RVA: 0x7ffaae695a90
        public void get_pinkyAux(){} // RVA: 0x7ffaae695ac0
        public void get_proximals(){} // RVA: 0x7ffaa899d120
        public void set_proximals(){} // RVA: 0x7ffaa899d130
        public void get_middles(){} // RVA: 0x7ffaa8a8a460
        public void set_middles(){} // RVA: 0x7ffaa8a8a470
        public void get_distals(){} // RVA: 0x7ffaa8a4f100
        public void set_distals(){} // RVA: 0x7ffaa8a4f110
        public void get_tips(){} // RVA: 0x7ffaa8f6dbf0
        public void set_tips(){} // RVA: 0x7ffaa89b38a0
        public void get_auxs(){} // RVA: 0x7ffaa89b3900
        public void set_auxs(){} // RVA: 0x7ffaa89b3910
        public void get_skeletalTrackingLevel(){} // RVA: 0x7ffaae695af0
        public void get_isBlending(){} // RVA: 0x7ffaae695b90
        public void get_actionSet(){} // RVA: 0x7ffaae65d3d0
        public void get_direction(){} // RVA: 0x7ffaae65d400
        public void Awake(){} // RVA: 0x7ffaae695ba0
        public void AssignBonesArray(){} // RVA: 0x7ffaae696960
        public void OnEnable(){} // RVA: 0x7ffaae696a40
        public void OnDisable(){} // RVA: 0x7ffaae696e00
        public void OnDeviceConnectedChanged(){} // RVA: 0x7ffaae6971d0
        public void OnTrackingChanged(){} // RVA: 0x7ffaae697270
        public void SteamVR_Input_OnSkeletonsUpdated(){} // RVA: 0x7ffaabb2c2c0
        public void UpdateSkeleton(){} // RVA: 0x7ffaae697310
        public void ResetTemporaryRangeOfMotion(){} // RVA: 0x7ffaae697630
        public void BlendToSkeleton(){} // RVA: 0x7ffaae6977c0
        public void BlendToPoser(){} // RVA: 0x7ffaae6979c0
        public void BlendToAnimation(){} // RVA: 0x7ffaae697b00
        public void BlendTo(){} // RVA: 0x7ffaae697b10
        public void RangeOfMotionBlend(){} // RVA: 0x7ffaae697dd0
        public void TemporaryRangeOfMotionBlend(){} // RVA: 0x7ffaae697f50
        public void ResetTemporaryRangeOfMotionBlend(){} // RVA: 0x7ffaae698140
        public void UpdateSkeletonTransforms(){} // RVA: 0x7ffaae698430
        public void MirrorPosition(){} // RVA: 0x7ffaae699d80
        public void MirrorRotation(){} // RVA: 0x7ffaae699e60
        public void UpdatePose(){} // RVA: 0x7ffaae69a0b0
        public void ForceToReferencePose(){} // RVA: 0x7ffaae69a980
        public void IsMetacarpal(){} // RVA: 0x7ffaae69afe0
        public void .ctor(){} // RVA: 0x7ffaae69b000
        public void .cctor(){} // RVA: 0x7ffaae69b060
        // ── Binary Analysis Named ──
        public void CheckSkeletonAction(){} // RVA: 0x7ffaae6967d0
        public void SetTemporaryRangeOfMotion(){} // RVA: 0x7ffaae6975a0
        public void SetRangeOfMotion(){} // RVA: 0x7ffaae697640
        public void DoBlendRoutine(){} // RVA: 0x7ffaae697d10
        public void DoRangeOfMotionBlend(){} // RVA: 0x7ffaae698310
        public void GetBlendPoseForBone(){} // RVA: 0x7ffaae6983e0
        public void SetBonePosition(){} // RVA: 0x7ffaae699380
        public void SetBoneRotation(){} // RVA: 0x7ffaae699420
        public void GetBone(){} // RVA: 0x7ffaae6994b0
        public void GetBonePosition(){} // RVA: 0x7ffaae699520
        public void GetBoneRotation(){} // RVA: 0x7ffaae699640
        public void GetBonePositions(){} // RVA: 0x7ffaae699750
        public void GetBoneRotations(){} // RVA: 0x7ffaae699ad0
    }

    public class SteamVR_Behaviour_SkeletonCustom : SteamVR_Behaviour_Skeleton
    {
        public object _thumbProximal; // 0x339B7760
        public object _thumbTip; // 0x339B7760
        public object _indexProximal; // 0x339B7760
        public object _indexTip; // 0x339B7760
        public object _middleProximal; // 0x339B7760
        public object _middleTip; // 0x339B7760
        public object _ringProximal; // 0x339B7760
        public object _ringTip; // 0x339B7760
        public object _pinkyProximal; // 0x339B7760
        public object _pinkyTip; // 0x339B7760
        public object Invoke; // 0xB3F6FFF0

        // ── Original Methods ──
        public void AssignBonesArray(){} // RVA: 0x7ffaae69c460
        public void .ctor(){} // RVA: 0x7ffaae69cd10
    }

    public class SteamVR_Behaviour_SkeletonEvent : UnityEvent`2
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bed0
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bf60
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent : UnityEvent`3
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65bff0
    }

    public class SteamVR_Behaviour_Vector2 : MonoBehaviour
    {
        public object onChange; // 0x338EFBD0
        public object onChangeEvent; // 0x338EFBD0

        // ── Original Methods ──
        public void get_isActive(){} // RVA: 0x7ffaae6945a0
        public void OnEnable(){} // RVA: 0x7ffaae69cdb0
        public void OnDisable(){} // RVA: 0x7ffaae69cea0
        public void AddHandlers(){} // RVA: 0x7ffaae69ceb0
        public void RemoveHandlers(){} // RVA: 0x7ffaae69d070
        public void SteamVR_Behaviour_Vector2_OnUpdate(){} // RVA: 0x7ffaae69d2d0
        public void SteamVR_Behaviour_Vector2_OnChange(){} // RVA: 0x7ffaae69d390
        public void SteamVR_Behaviour_Vector2_OnAxis(){} // RVA: 0x7ffaae69d450
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetLocalizedName(){} // RVA: 0x7ffaae69d510
    }

    public class SteamVR_Behaviour_Vector2Event : UnityEvent`4
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65c080
    }

    public class SteamVR_Behaviour_Vector3 : MonoBehaviour
    {
        public object onChange; // 0x339FC370
        public object onChangeEvent; // 0x339FC370

        // ── Original Methods ──
        public void get_isActive(){} // RVA: 0x7ffaae6945a0
        public void OnEnable(){} // RVA: 0x7ffaae69d8c0
        public void OnDisable(){} // RVA: 0x7ffaae69d9b0
        public void AddHandlers(){} // RVA: 0x7ffaae69d9c0
        public void RemoveHandlers(){} // RVA: 0x7ffaae69db80
        public void SteamVR_Behaviour_Vector3_OnUpdate(){} // RVA: 0x7ffaae69dde0
        public void SteamVR_Behaviour_Vector3_OnChange(){} // RVA: 0x7ffaae69def0
        public void SteamVR_Behaviour_Vector3_OnAxis(){} // RVA: 0x7ffaae69e000
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetLocalizedName(){} // RVA: 0x7ffaae69e110
    }

    public class SteamVR_Behaviour_Vector3Event : UnityEvent`4
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae65c110
    }

    public class SteamVR_Camera : MonoBehaviour
    {
        public object _ears; // 0x335AA510
        public object eyeSuffix; // 0x335AA510
        public object originSuffix; // 0x335AA510
        public object head; // 0x170001BC
        public object offset; // 0x170001BD
        public object origin; // 0x170001BE

        // ── Original Methods ──
        public void get_head(){} // RVA: 0x7ffaa89600c0
        public void get_offset(){} // RVA: 0x7ffaa89600c0
        public void get_origin(){} // RVA: 0x7ffaae6b88f0
        public void get_camera(){} // RVA: 0x7ffaa8960130
        public void set_camera(){} // RVA: 0x7ffaa8933e90
        public void get_ears(){} // RVA: 0x7ffaa8bfcc80
        public void get_sceneResolutionScale(){} // RVA: 0x7ffaae6b8ab0
        public void set_sceneResolutionScale(){} // RVA: 0x7ffaae6b8b00
        public void OnDisable(){} // RVA: 0x7ffaae6b8b60
        public void OnEnable(){} // RVA: 0x7ffaae6b8cc0
        public void Awake(){} // RVA: 0x7ffaae6b9750
        public void ForceLast(){} // RVA: 0x7ffaae6b97e0
        public void get_baseName(){} // RVA: 0x7ffaae6ba130
        public void Expand(){} // RVA: 0x7ffaae6ba1f0
        public void Collapse(){} // RVA: 0x7ffaae6bb8c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetRay(){} // RVA: 0x7ffaae6b8950
    }

    public class SteamVR_CameraFlip : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6bc6b0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SteamVR_CameraHelper : MonoBehaviour
    {
        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae65b9c0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SteamVR_CameraMask : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaae6bc750
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SteamVR_Ears : MonoBehaviour
    {
        public object offset; // 0x336A6520
        public object _wrapper; // 0x30DE4C60

        // ── Original Methods ──
        public void OnNewPosesApplied(){} // RVA: 0x7ffaae6bc7f0
        public void OnEnable(){} // RVA: 0x7ffaae6bcbc0
        public void OnDisable(){} // RVA: 0x7ffaae6bcf40
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class SteamVR_Events : Object
    {
        public object Fade; // 0x30CC3470
        public object Initializing; // 0x30CC3470
        public object LoadingFadeIn; // 0x30CC3470
        public object NewPosesApplied; // 0x30CC3470
        public object RenderModelLoaded; // 0x30CC3470

        // ── Original Methods ──
        public void CalibratingAction(){} // RVA: 0x7ffaae6bd040
        public void DeviceConnectedAction(){} // RVA: 0x7ffaae6bd0f0
        public void FadeAction(){} // RVA: 0x7ffaae6bd240
        public void FadeReadyAction(){} // RVA: 0x7ffaae6bd390
        public void HideRenderModelsAction(){} // RVA: 0x7ffaae6bd440
        public void InitializingAction(){} // RVA: 0x7ffaae6bd4f0
        public void InputFocusAction(){} // RVA: 0x7ffaae6bd5a0
        public void LoadingAction(){} // RVA: 0x7ffaae6bd650
        public void LoadingFadeInAction(){} // RVA: 0x7ffaae6bd700
        public void LoadingFadeOutAction(){} // RVA: 0x7ffaae6bd7b0
        public void NewPosesAction(){} // RVA: 0x7ffaae6bd860
        public void NewPosesAppliedAction(){} // RVA: 0x7ffaae6bd920
        public void InitializedAction(){} // RVA: 0x7ffaae6bd9d0
        public void OutOfRangeAction(){} // RVA: 0x7ffaae6bda80
        public void RenderModelLoadedAction(){} // RVA: 0x7ffaae6bdb30
        public void System(){} // RVA: 0x7ffaae6bdc80
        public void SystemAction(){} // RVA: 0x7ffaae6bde30
        public void .cctor(){} // RVA: 0x7ffaae6bdf70
    }

    public class SteamVR_ExternalCamera : MonoBehaviour
    {
        public object config; // 0x33AECA70
        public object watcher; // 0x33AECA70
        public object clipQuad; // 0x33AECA70
        public object activatedInputSource; // 0x33AECA70
        public object cameras; // 0x33AECA70
        public object x; // 0x82425C90
        public object rx; // 0x82425C90
        public object fov; // 0x82425C90

        // ── Original Methods ──
        public void ReadConfig(){} // RVA: 0x7ffaae6bebb0
        public void OnChanged(){} // RVA: 0x7ffaae6bf820
        public void AttachToCamera(){} // RVA: 0x7ffaae6bf830
        public void RenderNear(){} // RVA: 0x7ffaae6c12b0
        public void RenderFar(){} // RVA: 0x7ffaae6c2430
        public void OnGUI(){} // RVA: 0x7ffaa8932310
        public void OnEnable(){} // RVA: 0x7ffaae6c26f0
        public void AutoEnableActionSet(){} // RVA: 0x7ffaae6c2c20
        public void OnDisable(){} // RVA: 0x7ffaae6c2db0
        public void .ctor(){} // RVA: 0x7ffaae6c3140
        // ── Binary Analysis Named ──
        public void SetupPose(){} // RVA: 0x7ffaae6bf5f0
        public void SetupDeviceIndex(){} // RVA: 0x7ffaae6bf770
        public void GetTargetDistance(){} // RVA: 0x7ffaae6c0d60
    }

    public class SteamVR_ExternalCamera_LegacyManager : Object
    {
        // ── Original Methods ──
        public void get_hasCamera(){} // RVA: 0x7ffaae6c31a0
        public void SubscribeToNewPoses(){} // RVA: 0x7ffaae6c3200
        public void OnNewPoses(){} // RVA: 0x7ffaae6c33a0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void .cctor(){} // RVA: 0x7ffaae6c34d0
    }

    public class SteamVR_Fade : MonoBehaviour
    {
        public object deltaColor; // 0x3353B540
        public object fadeMaterialColorID; // 0x3353B540
        public object fovRight; // 0x33A4F300

        // ── Original Methods ──
        public void Start(){} // RVA: 0x7ffaae6c3580
        public void View(){} // RVA: 0x7ffaae6c3650
        public void OnStartFade(){} // RVA: 0x7ffaae6c36d0
        public void OnEnable(){} // RVA: 0x7ffaae6c3780
        public void OnDisable(){} // RVA: 0x7ffaae6c3a90
        public void OnPostRender(){} // RVA: 0x7ffaae6c3b90
        public void .ctor(){} // RVA: 0x7ffaae6c40d0
        public void .cctor(){} // RVA: 0x7ffaae6c4130
    }

    public class SteamVR_Frustum : MonoBehaviour
    {
        public object fovRight; // 0x33A4F300
        public object nearZ; // 0x33A4F300
        public object start; // 0x33C4DB30

        // ── Original Methods ──
        public void UpdateModel(){} // RVA: 0x7ffaae6c41e0
        public void OnDeviceConnected(){} // RVA: 0x7ffaae6c4c10
        public void OnEnable(){} // RVA: 0x7ffaae6c4eb0
        public void OnDisable(){} // RVA: 0x7ffaae6c5000
        public void .ctor(){} // RVA: 0x7ffaae6c5180
    }

    public class SteamVR_IK : MonoBehaviour
    {
        public object joint; // 0x33C4DB30
        public object upVector; // 0x33C4DB30
        public object jointXform; // 0x33C4DB30
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void LateUpdate(){} // RVA: 0x7ffaae6c51f0
        public void Solve(){} // RVA: 0x7ffaae6c6b20
        public void .ctor(){} // RVA: 0x7ffaae6c71c0
    }

    public class SteamVR_Input : Object
    {
        public object fileInitialized; // 0x318AA350
        public object actionFile; // 0x318AA350
        public object onPosesUpdated; // 0x318AA350
        public object startupFrame; // 0x318AA350
        public object actionsIn; // 0x318AA350
        public object actionsSingle; // 0x318AA350
        public object actionsPose; // 0x318AA350
        public object actionsNonPoseNonSkeletonIn; // 0x318AA350
        public object actionsByPath; // 0x318AA350
        public object actionsByPathCache; // 0x318AA350
        public object sizeVRActiveActionSet_t; // 0x318AA350
        public object onPosesUpdated; // 0x318A11E0
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void add_onNonVisualActionsUpdated(){} // RVA: 0x7ffaae69e4c0
        public void remove_onNonVisualActionsUpdated(){} // RVA: 0x7ffaae69e610
        public void add_onPosesUpdated(){} // RVA: 0x7ffaae69e760
        public void remove_onPosesUpdated(){} // RVA: 0x7ffaae69e8b0
        public void add_onSkeletonsUpdated(){} // RVA: 0x7ffaae69ea00
        public void remove_onSkeletonsUpdated(){} // RVA: 0x7ffaae69eb50
        public void get_isStartupFrame(){} // RVA: 0x7ffaae69eca0
        public void .cctor(){} // RVA: 0x7ffaae69edc0
        public void ForcePreinitialize(){} // RVA: 0x7ffaae69f3e0
        public void FindPreinitializeMethod(){} // RVA: 0x7ffaae69f430
        public void Initialize(){} // RVA: 0x7ffaae69f610
        public void PreinitializeFinishActionSets(){} // RVA: 0x7ffaae69fba0
        public void PreinitializeActionSetDictionaries(){} // RVA: 0x7ffaae69fc70
        public void PreinitializeActionDictionaries(){} // RVA: 0x7ffaae69ff10
        public void Update(){} // RVA: 0x7ffaae6a0180
        public void LateUpdate(){} // RVA: 0x7ffaae6a02a0
        public void FixedUpdate(){} // RVA: 0x7ffaae6a03e0
        public void OnPreCull(){} // RVA: 0x7ffaae6a0500
        public void UpdateVisualActions(){} // RVA: 0x7ffaae6a0620
        public void UpdatePoseActions(){} // RVA: 0x7ffaae6a0820
        public void UpdateSkeletonActions(){} // RVA: 0x7ffaae6a09a0
        public void UpdateNonVisualActions(){} // RVA: 0x7ffaae6a0b20
        public void ShowBindingHintsForSets(){} // RVA: 0x7ffaae6a0d40
        public void ShowBindingHints(){} // RVA: 0x7ffaae6a10a0
        public void ShowBindingHints(){} // RVA: 0x7ffaae6a10a0
        public void ShowBindingHintsForActiveActionSets(){} // RVA: 0x7ffaae6a1180
        public void HasActionPath(){} // RVA: 0x7ffaae6a1830
        public void HasAction(){} // RVA: 0x7ffaae6a1a50
        public void HasAction(){} // RVA: 0x7ffaae6a1a50
        public void CreateFakeAction(){} // RVA: 0x7ffaa887e5c0
        public void CreateFakeAction(){} // RVA: 0x7ffaa887e5c0
        public void HasActionSet(){} // RVA: 0x7ffaae6a2bb0
        public void ShouldMakeCopy(){} // RVA: 0x7ffaae6a3f90
        public void IdentifyActionsFile(){} // RVA: 0x7ffaae6a4140
        public void HasFileInMemoryBeenModified(){} // RVA: 0x7ffaae6a44d0
        public void CreateEmptyActionsFile(){} // RVA: 0x7ffaae6a46a0
        public void InitializeFile(){} // RVA: 0x7ffaae6a4db0
        public void DeleteManifestAndBindings(){} // RVA: 0x7ffaae6a55e0
        public void OpenBindingUI(){} // RVA: 0x7ffaae6a5a50
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetActionDataFromPath(){} // RVA: 0x7ffaa887e5c0
        public void GetActionSetDataFromPath(){} // RVA: 0x7ffaae6a1330
        public void GetActionFromPath(){} // RVA: 0x7ffaa887e5c0
        public void GetBaseActionFromPath(){} // RVA: 0x7ffaae6a13e0
        public void GetBooleanActionFromPath(){} // RVA: 0x7ffaae6a1b60
        public void GetSingleActionFromPath(){} // RVA: 0x7ffaae6a1be0
        public void GetVector2ActionFromPath(){} // RVA: 0x7ffaae6a1c60
        public void GetVector3ActionFromPath(){} // RVA: 0x7ffaae6a1ce0
        public void GetVibrationActionFromPath(){} // RVA: 0x7ffaae6a1d60
        public void GetPoseActionFromPath(){} // RVA: 0x7ffaae6a1de0
        public void GetSkeletonActionFromPath(){} // RVA: 0x7ffaae6a1e60
        public void GetAction(){} // RVA: 0x7ffaa887e5c0
        public void GetBaseAction(){} // RVA: 0x7ffaae6a1ee0
        public void GetAction(){} // RVA: 0x7ffaa887e5c0
        public void GetBooleanAction(){} // RVA: 0x7ffaae6a2440
        public void GetBooleanAction(){} // RVA: 0x7ffaae6a2440
        public void GetSingleAction(){} // RVA: 0x7ffaae6a2550
        public void GetSingleAction(){} // RVA: 0x7ffaae6a2550
        public void GetVector2Action(){} // RVA: 0x7ffaae6a2660
        public void GetVector2Action(){} // RVA: 0x7ffaae6a2660
        public void GetVector3Action(){} // RVA: 0x7ffaae6a2770
        public void GetVector3Action(){} // RVA: 0x7ffaae6a2770
        public void GetPoseAction(){} // RVA: 0x7ffaae6a2880
        public void GetPoseAction(){} // RVA: 0x7ffaae6a2880
        public void GetSkeletonAction(){} // RVA: 0x7ffaae6a2990
        public void GetSkeletonAction(){} // RVA: 0x7ffaae6a2990
        public void GetVibrationAction(){} // RVA: 0x7ffaae6a2aa0
        public void GetVibrationAction(){} // RVA: 0x7ffaae6a2aa0
        public void GetActionSet(){} // RVA: 0x7ffaae6a2b20
        public void GetActionSet(){} // RVA: 0x7ffaae6a2b20
        public void GetActionSetFromPath(){} // RVA: 0x7ffaae6a2c50
        public void GetActionSetFromPath(){} // RVA: 0x7ffaae6a2c50
        public void GetState(){} // RVA: 0x7ffaae6a2e30
        public void GetState(){} // RVA: 0x7ffaae6a2e30
        public void GetStateDown(){} // RVA: 0x7ffaae6a3120
        public void GetStateDown(){} // RVA: 0x7ffaae6a3120
        public void GetStateUp(){} // RVA: 0x7ffaae6a3410
        public void GetStateUp(){} // RVA: 0x7ffaae6a3410
        public void GetFloat(){} // RVA: 0x7ffaae6a3700
        public void GetFloat(){} // RVA: 0x7ffaae6a3700
        public void GetSingle(){} // RVA: 0x7ffaae6a38e0
        public void GetSingle(){} // RVA: 0x7ffaae6a38e0
        public void GetVector2(){} // RVA: 0x7ffaae6a3af0
        public void GetVector2(){} // RVA: 0x7ffaae6a3af0
        public void GetVector3(){} // RVA: 0x7ffaae6a3e90
        public void GetVector3(){} // RVA: 0x7ffaae6a3e90
        public void GetActionSets(){} // RVA: 0x7ffaae6a3f30
        public void GetActions(){} // RVA: 0x7ffaa8648dd0
        public void GetLocalizedName(){} // RVA: 0x7ffaae6a3ff0
        public void CheckOldLocation(){} // RVA: 0x7ffaa8932320
        public void DoesActionsFileExist(){} // RVA: 0x7ffaae6a4d50
        public void GetActionsFileFolder(){} // RVA: 0x7ffaae6a51d0
        public void GetActionsFilePath(){} // RVA: 0x7ffaae6a52e0
        public void GetActionsFileName(){} // RVA: 0x7ffaae6a5580
    }

    public class SteamVR_Input_ActionFile : Object
    {
        public object default_bindings; // 0x339DF170
        public object localizationHelperList; // 0x339DF170

        // ── Original Methods ──
        public void InitializeHelperLists(){} // RVA: 0x7ffaae6a5c60
        public void SaveHelperLists(){} // RVA: 0x7ffaae6a6310
        public void CopyFilesToPath(){} // RVA: 0x7ffaae6a7120
        public void RemoveAppKey(){} // RVA: 0x7ffaae6a73f0
        public void Open(){} // RVA: 0x7ffaae6a7570
        public void Save(){} // RVA: 0x7ffaae6a7670
        public void .ctor(){} // RVA: 0x7ffaae6a77f0
        // ── Binary Analysis Named ──
        public void GetShortName(){} // RVA: 0x7ffaae6a6b50
        public void GetCodeFriendlyName(){} // RVA: 0x7ffaae6a6bf0
        public void GetFilesToCopy(){} // RVA: 0x7ffaae6a6da0
    }

    public class SteamVR_Input_ActionSet_Action_Menu : SteamVR_ActionSet
    {
        // ── Original Methods ──
        public void get_Axis(){} // RVA: 0x7ffaae674db0
        public void get_Select(){} // RVA: 0x7ffaae674dc0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7ffaae674dd0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7ffaae674de0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7ffaae674df0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7ffaae674e00
        public void get_Gesture_Activator_Index(){} // RVA: 0x7ffaae674e10
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7ffaae674e20
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7ffaae674e30
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7ffaae674e40
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7ffaae674e50
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7ffaae674e60
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7ffaae674e70
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7ffaae674e80
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7ffaae674e90
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7ffaae674ea0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7ffaae674eb0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7ffaae674ec0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7ffaae674ed0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7ffaae674ee0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7ffaae674ef0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7ffaae674f00
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7ffaae674f10
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7ffaae674f20
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7ffaae674f30
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7ffaae674f40
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7ffaae674f50
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7ffaae674f60
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7ffaae674f70
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7ffaae674f80
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7ffaae674f90
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7ffaae674fa0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7ffaae674fb0
        public void get_Reserve_bool(){} // RVA: 0x7ffaae674fc0
        public void get_Reserve_vector1(){} // RVA: 0x7ffaae674fd0
        public void get_Reserve_vector2(){} // RVA: 0x7ffaae674fe0
        public void get_Grab(){} // RVA: 0x7ffaae674ff0
        public void get_Drop(){} // RVA: 0x7ffaae675000
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_Input_ActionSet_Drone : SteamVR_ActionSet
    {
        // ── Original Methods ──
        public void get_Left_Joystick(){} // RVA: 0x7ffaae675010
        public void get_Right_Joystick(){} // RVA: 0x7ffaae675020
        public void get_Self_Leveling_Mod(){} // RVA: 0x7ffaae675030
        public void get_Hold_Altitude_Mod(){} // RVA: 0x7ffaae675040
        public void get_Toggle_FPV(){} // RVA: 0x7ffaae675050
        public void get_Flip(){} // RVA: 0x7ffaae675060
        public void get_Take_Picture(){} // RVA: 0x7ffaae675070
        public void get_Cycle_Flight_Preset(){} // RVA: 0x7ffaae675080
        public void get_Toggle_Self_Leveling(){} // RVA: 0x7ffaae675090
        public void get_Respawn(){} // RVA: 0x7ffaae6750a0
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x7ffaae6750b0
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x7ffaae6750c0
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x7ffaae6750d0
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x7ffaae6750e0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_Input_ActionSet_Global : SteamVR_ActionSet
    {
        // ── Original Methods ──
        public void get_Safe_Mode(){} // RVA: 0x7ffaae6750f0
        public void get_Pose(){} // RVA: 0x7ffaae675100
        public void get_SkeletonLeftHand(){} // RVA: 0x7ffaae675110
        public void get_SkeletonRightHand(){} // RVA: 0x7ffaae675120
        public void get_HeadsetOnHead(){} // RVA: 0x7ffaae675130
        public void get_Menu(){} // RVA: 0x7ffaae675140
        public void get_Quick_Menu(){} // RVA: 0x7ffaae675150
        public void get_Action_Menu(){} // RVA: 0x7ffaae675160
        public void get_Main_Menu(){} // RVA: 0x7ffaae675170
        public void get_Interact(){} // RVA: 0x7ffaae675180
        public void get_Grab(){} // RVA: 0x7ffaae675190
        public void get_Move(){} // RVA: 0x7ffaae6751a0
        public void get_Jump(){} // RVA: 0x7ffaae6751b0
        public void get_Rotate(){} // RVA: 0x7ffaae6751c0
        public void get_Mic(){} // RVA: 0x7ffaae6751d0
        public void get_Gesture_Toggle(){} // RVA: 0x7ffaae6751e0
        public void get_Stick_Click(){} // RVA: 0x7ffaae6751f0
        public void get_Trigger_Axis(){} // RVA: 0x7ffaae675200
        public void get_Grip_Axis(){} // RVA: 0x7ffaae675210
        public void get_Udon_Menu(){} // RVA: 0x7ffaae675220
        public void get_Drop(){} // RVA: 0x7ffaae675230
        public void get_Nameplates(){} // RVA: 0x7ffaae675240
        public void get_HUD(){} // RVA: 0x7ffaae675250
        public void get_Chatbox(){} // RVA: 0x7ffaae675260
        public void get_Face_Mirror(){} // RVA: 0x7ffaae675270
        public void get_Personal_Mirror(){} // RVA: 0x7ffaae675280
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7ffaae675290
        public void get_Earmuffs(){} // RVA: 0x7ffaae6752a0
        public void get_Camera(){} // RVA: 0x7ffaae6752b0
        public void get_Stream_Camera(){} // RVA: 0x7ffaae6752c0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7ffaae6752d0
        public void get_OSC_Debug_Screen(){} // RVA: 0x7ffaae6752e0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7ffaae6752f0
        public void get_Start_Move(){} // RVA: 0x7ffaae675300
        public void get_Start_Rotate(){} // RVA: 0x7ffaae675310
        public void get_Continue_Move(){} // RVA: 0x7ffaae675320
        public void get_Continue_Rotate(){} // RVA: 0x7ffaae675330
        public void get_No_Gesture_After_Move(){} // RVA: 0x7ffaae675340
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x7ffaae675350
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7ffaae675360
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7ffaae675370
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7ffaae675380
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7ffaae675390
        public void get_Gesture_Activator_Index(){} // RVA: 0x7ffaae6753a0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7ffaae6753b0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7ffaae6753c0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7ffaae6753d0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7ffaae6753e0
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x7ffaae6753f0
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x7ffaae675400
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x7ffaae675410
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x7ffaae675420
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x7ffaae675430
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7ffaae675440
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7ffaae675450
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x7ffaae675460
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x7ffaae675470
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x7ffaae675480
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x7ffaae675490
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x7ffaae6754a0
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x7ffaae6754b0
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7ffaae6754c0
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7ffaae6754d0
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x7ffaae6754e0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7ffaae6754f0
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7ffaae675500
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7ffaae675510
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7ffaae675520
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7ffaae675530
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7ffaae675540
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7ffaae675550
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7ffaae675560
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7ffaae675570
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7ffaae675580
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7ffaae675590
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7ffaae6755a0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7ffaae6755b0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7ffaae6755c0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7ffaae6755d0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7ffaae6755e0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7ffaae6755f0
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7ffaae675600
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x7ffaae675610
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7ffaae675620
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7ffaae675630
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7ffaae675640
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7ffaae675650
        public void get_Physbone_Grab_Left(){} // RVA: 0x7ffaae675660
        public void get_Physbone_Freeze_Left(){} // RVA: 0x7ffaae675670
        public void get_Physbone_Grab_Right(){} // RVA: 0x7ffaae675680
        public void get_Physbone_Freeze_Right(){} // RVA: 0x7ffaae675690
        public void get_Scroll(){} // RVA: 0x7ffaae6756a0
        public void get_Haptic(){} // RVA: 0x7ffaae6756b0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_Input_ActionSet_Menu : SteamVR_ActionSet
    {
        // ── Original Methods ──
        public void get_Confirm(){} // RVA: 0x7ffaae6756c0
        public void get_Back(){} // RVA: 0x7ffaae6756d0
        public void get_Tab(){} // RVA: 0x7ffaae6756e0
        public void get_Scroll(){} // RVA: 0x7ffaae6756f0
        public void get_Quick_Menu_Close(){} // RVA: 0x7ffaae675700
        public void get_Drag(){} // RVA: 0x7ffaae675710
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_Input_ActionSet_One_Hand : SteamVR_ActionSet
    {
        // ── Original Methods ──
        public void get_Interact(){} // RVA: 0x7ffaae675720
        public void get_Grab(){} // RVA: 0x7ffaae675730
        public void get_Move_Rotate(){} // RVA: 0x7ffaae675740
        public void get_Jump(){} // RVA: 0x7ffaae675750
        public void get_Mic(){} // RVA: 0x7ffaae675760
        public void get_Gesture_Toggle(){} // RVA: 0x7ffaae675770
        public void get_Stick_Click(){} // RVA: 0x7ffaae675780
        public void get_Trigger_Axis(){} // RVA: 0x7ffaae675790
        public void get_Grip_Axis(){} // RVA: 0x7ffaae6757a0
        public void get_Udon_Menu(){} // RVA: 0x7ffaae6757b0
        public void get_Drop(){} // RVA: 0x7ffaae6757c0
        public void get_Start_Move_Rotate(){} // RVA: 0x7ffaae6757d0
        public void get_Continue_Move_Rotate(){} // RVA: 0x7ffaae6757e0
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x7ffaae6757f0
        public void get_Menu(){} // RVA: 0x7ffaae675800
        public void get_Nameplates(){} // RVA: 0x7ffaae675810
        public void get_HUD(){} // RVA: 0x7ffaae675820
        public void get_Chatbox(){} // RVA: 0x7ffaae675830
        public void get_Face_Mirror(){} // RVA: 0x7ffaae675840
        public void get_Personal_Mirror(){} // RVA: 0x7ffaae675850
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7ffaae675860
        public void get_Earmuffs(){} // RVA: 0x7ffaae675870
        public void get_Camera(){} // RVA: 0x7ffaae675880
        public void get_Stream_Camera(){} // RVA: 0x7ffaae675890
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7ffaae6758a0
        public void get_OSC_Debug_Screen(){} // RVA: 0x7ffaae6758b0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7ffaae6758c0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7ffaae6758d0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7ffaae6758e0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7ffaae6758f0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7ffaae675900
        public void get_Gesture_Activator_Index(){} // RVA: 0x7ffaae675910
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7ffaae675920
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7ffaae675930
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7ffaae675940
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7ffaae675950
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7ffaae675960
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7ffaae675970
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7ffaae675980
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7ffaae675990
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7ffaae6759a0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7ffaae6759b0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7ffaae6759c0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7ffaae6759d0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7ffaae6759e0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7ffaae6759f0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7ffaae675a00
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7ffaae675a10
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7ffaae675a20
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7ffaae675a30
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7ffaae675a40
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7ffaae675a50
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7ffaae675a60
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7ffaae675a70
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7ffaae675a80
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7ffaae675a90
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7ffaae675aa0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7ffaae675ab0
        public void get_Reserve_bool(){} // RVA: 0x7ffaae675ac0
        public void get_Reserve_vector1(){} // RVA: 0x7ffaae675ad0
        public void get_Reserve_vector2(){} // RVA: 0x7ffaae675ae0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_Input_BindingFile : Object
    {
        public object controller_type; // 0x33876DF0
        public object `;

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae6ab230
    }

    public class SteamVR_Input_Generator_Names : Object
    {
        public object preinitializeMethodName; // 0x3341FB90
        public object actionsOutFieldName; // 0x3341FB90
        public object actionsBooleanFieldName; // 0x3341FB90
        public object actionsVector3FieldName; // 0x3341FB90
        public object actionSetsFieldName; // 0x3341FB90

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_Input_Source : Object
    {
        public object inputSourceSourcesByHandle; // 0x33C7CD70
        public object allSources; // 0x33C7CD70
        public object .;

        // ── Original Methods ──
        public void Initialize(){} // RVA: 0x7ffaae6acfb0
        public void .cctor(){} // RVA: 0x7ffaae6ad840
        // ── Binary Analysis Named ──
        public void GetHandle(){} // RVA: 0x7ffaae6ac990
        public void GetSource(){} // RVA: 0x7ffaae6aca40
        public void GetAllSources(){} // RVA: 0x7ffaae6acbd0
        public void GetPath(){} // RVA: 0x7ffaae6ace70
    }

    public class SteamVR_LoadLevel : MonoBehaviour
    {
        public object internalProcessPath; // 0x339F5660
        public object loadAsync; // 0x339F5660
        public object progressBarFull; // 0x339F5660
        public object loadingScreenDistance; // 0x339F5660
        public object front; // 0x339F5660
        public object right; // 0x339F5660
        public object backgroundColor; // 0x339F5660
        public object fadeInTime; // 0x339F5660
        public object loadingScreenFadeOutTime; // 0x339F5660
        public object async; // 0x339F5660
        public object progressBarOverlayHandle; // 0x339F5660
        public object Action`1; // 0xB4149500

        // ── Original Methods ──
        public void get_loading(){} // RVA: 0x7ffaae6c7210
        public void get_progress(){} // RVA: 0x7ffaae6c7300
        public void get_progressTexture(){} // RVA: 0x7ffaae6c7460
        public void OnEnable(){} // RVA: 0x7ffaae6c7570
        public void Trigger(){} // RVA: 0x7ffaae6c7590
        public void OnGUI(){} // RVA: 0x7ffaae6c78a0
        public void Update(){} // RVA: 0x7ffaae6c8030
        public void LoadLevel(){} // RVA: 0x7ffaae6c8290
        public void .ctor(){} // RVA: 0x7ffaae6c8970
        // ── Binary Analysis Named ──
        public void Begin(){} // RVA: 0x7ffaae6c7730
        public void GetOverlayHandle(){} // RVA: 0x7ffaae6c8330
    }

    public class SteamVR_Menu : MonoBehaviour
    {
        public object logo; // 0x33C45A20
        public object scaleLimits; // 0x33C45A20
        public object overlayCam; // 0x33C45A20
        public object _scale; // 0x33C45A20, was: <scale>k__BackingField
        public object scaleRateText; // 0x33C45A20
        public object texture; // 0x33686EB0
        public object alpha; // 0x33686EB0

        // ── Original Methods ──
        public void get_texture(){} // RVA: 0x7ffaae6c9fd0
        public void get_scale(){} // RVA: 0x7ffaa895b0c0
        public void set_scale(){} // RVA: 0x7ffaa895b0d0
        public void Awake(){} // RVA: 0x7ffaae6ca120
        public void OnGUI(){} // RVA: 0x7ffaae6ca470
        public void ShowMenu(){} // RVA: 0x7ffaae6cbbc0
        public void HideMenu(){} // RVA: 0x7ffaae6cc2a0
        public void Update(){} // RVA: 0x7ffaae6cc560
        public void SaveCursorState(){} // RVA: 0x7ffaae6cc990
        public void RestoreCursorState(){} // RVA: 0x7ffaae6cca30
        public void .ctor(){} // RVA: 0x7ffaae6ccae0
        // ── Binary Analysis Named ──
        public void SetScale(){} // RVA: 0x7ffaae6cc800
    }

    public class SteamVR_Overlay : MonoBehaviour
    {
        public object distance; // 0x33686EB0
        public object mouseScale; // 0x33686EB0
        public object handle; // 0x33686EB0
        public object instance; // 0x170001CC
        public object key; // 0x170001CD

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaae6ccb40
        public void set_instance(){} // RVA: 0x7ffaae6ccb80
        public void get_key(){} // RVA: 0x7ffaae6ccc20
        public void OnEnable(){} // RVA: 0x7ffaae6ccd30
        public void OnDisable(){} // RVA: 0x7ffaae6ccf10
        public void UpdateOverlay(){} // RVA: 0x7ffaae6ccf70
        public void PollNextEvent(){} // RVA: 0x7ffaae6cd630
        public void ComputeIntersection(){} // RVA: 0x7ffaae6cd740
        public void .ctor(){} // RVA: 0x7ffaae6cd920
    }

    public class SteamVR_PlayArea : MonoBehaviour
    {
        public object drawWireframeWhenSelectedOnly; // 0x334D04D0
        public object color; // 0x334D04D0

        // ── Original Methods ──
        public void BuildMesh(){} // RVA: 0x7ffaae6cdcb0
        public void OnDrawGizmos(){} // RVA: 0x7ffaae6cea80
        public void OnDrawGizmosSelected(){} // RVA: 0x7ffaae6cea90
        public void DrawWireframe(){} // RVA: 0x7ffaae6ceaa0
        public void OnEnable(){} // RVA: 0x7ffaae6cf070
        public void UpdateBounds(){} // RVA: 0x7ffaae6cf280
        public void .ctor(){} // RVA: 0x7ffaae6cf320
        // ── Binary Analysis Named ──
        public void GetBounds(){} // RVA: 0x7ffaae6cd9a0
    }

    public class SteamVR_Render : MonoBehaviour
    {
        public object _eye; // 0x33C4C260, was: <eye>k__BackingField
        public object poses; // 0x33C4C260
        public object waitForEndOfFrame; // 0x33C4C260
        public object screenshotTypes; // 0x33C4C260
        public object eye; // 0x170001D0
        public object instance; // 0x170001D1
        public object pauseRendering; // 0x170001D2

        // ── Original Methods ──
        public void get_eye(){} // RVA: 0x7ffaae6cf5e0
        public void set_eye(){} // RVA: 0x7ffaae6cf620
        public void get_instance(){} // RVA: 0x7ffaae6cf660
        public void OnApplicationQuit(){} // RVA: 0x7ffaae6cf6c0
        public void Add(){} // RVA: 0x7ffaae6cf730
        public void Remove(){} // RVA: 0x7ffaae6b8b60
        public void Top(){} // RVA: 0x7ffaae6cf7e0
        public void AddInternal(){} // RVA: 0x7ffaae6cf8a0
        public void RemoveInternal(){} // RVA: 0x7ffaae6cfb30
        public void TopInternal(){} // RVA: 0x7ffaae6cfec0
        public void get_pauseRendering(){} // RVA: 0x7ffaae6cff00
        public void set_pauseRendering(){} // RVA: 0x7ffaae6cff40
        public void RenderLoop(){} // RVA: 0x7ffaae6cffd0
        public void RenderExternalCamera(){} // RVA: 0x7ffaae6d0ad0
        public void OnInputFocus(){} // RVA: 0x7ffaae6d0d20
        public void OnRequestScreenshot(){} // RVA: 0x7ffaae6d0fb0
        public void OnEnable(){} // RVA: 0x7ffaae6d1490
        public void OnSteamVRInitialized(){} // RVA: 0x7ffaae6d1a80
        public void OnDisable(){} // RVA: 0x7ffaae6d1ae0
        public void UpdatePoses(){} // RVA: 0x7ffaae6d1e80
        public void OnBeforeRender(){} // RVA: 0x7ffaae6d1fb0
        public void Update(){} // RVA: 0x7ffaae6d2080
        public void .ctor(){} // RVA: 0x7ffaae6d25e0
        // ── Binary Analysis Named ──
        public void CheckExternalCamera(){} // RVA: 0x7ffaae6d0070
        public void GetScreenshotFilename(){} // RVA: 0x7ffaae6d0e40
    }

    public class SteamVR_RenderModel : MonoBehaviour
    {
        public object modelOverrideWarning; // 0x3372D3B0
        public object verbose; // 0x3372D3B0
        public object controllerModeState; // 0x3372D3B0
        public object _initializedAttachPoints; // 0x3372D3B0, was: <initializedAttachPoints>k__Ba
        public object models; // 0x3372D3B0
        public object hideRenderModelsAction; // 0x3372D3B0
        public object None; // 0x82122AF0

        // ── Original Methods ──
        public void get_renderModelName(){} // RVA: 0x7ffaa89af740
        public void set_renderModelName(){} // RVA: 0x7ffaa895a200
        public void get_initializedAttachPoints(){} // RVA: 0x7ffaa89e9d30
        public void set_initializedAttachPoints(){} // RVA: 0x7ffaa89e9d40
        public void OnModelSkinSettingsHaveChanged(){} // RVA: 0x7ffaae6d2d10
        public void OnHideRenderModels(){} // RVA: 0x7ffaae6d2f50
        public void OnDeviceConnected(){} // RVA: 0x7ffaae6d2f60
        public void UpdateModel(){} // RVA: 0x7ffaae6d2f80
        public void LoadRenderModel(){} // RVA: 0x7ffaae6d39c0
        public void ConvertByteColorGammaExp(){} // RVA: 0x7ffaae6d5000
        public void FreeRenderModel(){} // RVA: 0x7ffaae6d5060
        public void FindTransformByName(){} // RVA: 0x7ffaae6d50b0
        public void StripMesh(){} // RVA: 0x7ffaae6d53e0
        public void LoadComponents(){} // RVA: 0x7ffaae6d55d0
        public void .ctor(){} // RVA: 0x7ffaae6d62b0
        public void OnEnable(){} // RVA: 0x7ffaae6d66d0
        public void OnDisable(){} // RVA: 0x7ffaae6d6840
        public void Update(){} // RVA: 0x7ffaae6d68b0
        public void UpdateComponents(){} // RVA: 0x7ffaae6d6900
        public void Sleep(){} // RVA: 0x7ffaae6d7440
        public void MarshalRenderModel(){} // RVA: 0x7ffaae6d7450
        public void MarshalRenderModel_TextureMap(){} // RVA: 0x7ffaae6d7680
        public void .cctor(){} // RVA: 0x7ffaae6d78b0
        // ── Binary Analysis Named ──
        public void SetMeshRendererState(){} // RVA: 0x7ffaae6d2dc0
        public void SetModelAsync(){} // RVA: 0x7ffaae6d32b0
        public void SetModel(){} // RVA: 0x7ffaae6d33b0
        public void GetComponentTransform(){} // RVA: 0x7ffaae6d52e0
        public void SetDeviceIndex(){} // RVA: 0x7ffaae6d7360
        public void SetInputSource(){} // RVA: 0x7ffaa9b8c1b0
    }

    public class SteamVR_RingBuffer`1 : Object
    {
        public object currentIndex; // 0x313D1010

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8661210
        public void Add(){} // RVA: 0x7ffaa887e5c0
        public void StepForward(){} // RVA: 0x7ffaa8660cc0
        public void Clear(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void GetAtIndex(){} // RVA: 0x7ffaa887e5c0
        public void GetLast(){} // RVA: 0x7ffaa887e5c0
        public void GetLastIndex(){} // RVA: 0x7ffaa8649ca0
    }

    public class SteamVR_Settings : ScriptableObject
    {
        public object lockPhysicsUpdateRateToRenderFrequency; // 0x33A6EB50
        public object steamVRInputPath; // 0x33A6EB50
        public object activateFirstActionSetOnStart; // 0x33A6EB50
        public object legacyMixedRealityCamera; // 0x33A6EB50
        public object mixedRealityActionSetAutoEnable; // 0x33A6EB50
        public object previewLeftDefaultAssetName; // 0x33A6EB50
        public object x64; // 0x847B7A50

        // ── Original Methods ──
        public void get_instance(){} // RVA: 0x7ffaae6d94e0
        public void get_trackingSpace(){} // RVA: 0x7ffaa9e5ac10
        public void set_trackingSpace(){} // RVA: 0x7ffaae6d9530
        public void IsInputUpdateMode(){} // RVA: 0x7ffaae6d95b0
        public void IsPoseUpdateMode(){} // RVA: 0x7ffaae6d95c0
        public void VerifyScriptableObject(){} // RVA: 0x7ffaae6d95d0
        public void LoadInstance(){} // RVA: 0x7ffaae6d95e0
        public void Save(){} // RVA: 0x7ffaa8932310
        public void FindDefaultPreviewHand(){} // RVA: 0x7ffaa8f22da0
        public void .ctor(){} // RVA: 0x7ffaae6d9ab0
        // ── Binary Analysis Named ──
        public void SetDefaultsIfNeeded(){} // RVA: 0x7ffaae6d98a0
    }

    public class SteamVR_Skeleton_Pose : ScriptableObject
    {
        public object leftHandInputSource; // 0x33C47420

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae6adc60
        // ── Binary Analysis Named ──
        public void GetHand(){} // RVA: 0x7ffaae6adc40
        public void GetHand(){} // RVA: 0x7ffaae6adc40
    }

    public class SteamVR_Skeleton_Poser : MonoBehaviour
    {
        public object poseNames; // 0x33C44BF0
        public object skeletonMainPose; // 0x33C44BF0
        public object showRightPreview; // 0x33C44BF0
        public object previewPoseSelection; // 0x33C44BF0
        public object blendedSnapshotR; // 0x33C44BF0
        public object poseUpdatedThisFrame; // 0x33C44BF0
        public object `Ǐf; // 0x673F6F2D

        // ── Original Methods ──
        public void get_blendPoseCount(){} // RVA: 0x7ffaae6ae480
        public void Awake(){} // RVA: 0x7ffaae6ae4a0
        public void FindBlendingBehaviour(){} // RVA: 0x7ffaae6aeb60
        public void UpdatePose(){} // RVA: 0x7ffaae6aeeb0
        public void ApplyBlenderBehaviours(){} // RVA: 0x7ffaae6af190
        public void LateUpdate(){} // RVA: 0x7ffaae6af450
        public void BlendVectors(){} // RVA: 0x7ffaae6af460
        public void BlendQuaternions(){} // RVA: 0x7ffaae6af560
        public void .ctor(){} // RVA: 0x7ffaae6b0510
        // ── Binary Analysis Named ──
        public void SetBlendingBehaviourValue(){} // RVA: 0x7ffaae6ae9f0
        public void GetBlendingBehaviourValue(){} // RVA: 0x7ffaae6aeac0
        public void SetBlendingBehaviourEnabled(){} // RVA: 0x7ffaae6aeaf0
        public void GetBlendingBehaviourEnabled(){} // RVA: 0x7ffaae6aeb20
        public void GetBlendingBehaviour(){} // RVA: 0x7ffaae6aeb50
        public void GetPoseByIndex(){} // RVA: 0x7ffaae6aed70
        public void GetHandSnapshot(){} // RVA: 0x7ffaae6aee00
        public void GetBlendedPose(){} // RVA: 0x7ffaae6aee60
        public void GetBlendedPose(){} // RVA: 0x7ffaae6aee60
        public void GetTargetHandPosition(){} // RVA: 0x7ffaae6af850
        public void GetTargetHandRotation(){} // RVA: 0x7ffaae6afe50
    }

    public class SteamVR_Skybox : MonoBehaviour
    {
        public object left; // 0x3343CD70
        public object bottom; // 0x3343CD70

        // ── Original Methods ──
        public void ClearOverride(){} // RVA: 0x7ffaae6da2f0
        public void OnEnable(){} // RVA: 0x7ffaae6da340
        public void OnDisable(){} // RVA: 0x7ffaae6da2f0
        public void .ctor(){} // RVA: 0x7ffaae6da380
        // ── Binary Analysis Named ──
        public void SetTextureByIndex(){} // RVA: 0x7ffaae6d9cf0
        public void GetTextureByIndex(){} // RVA: 0x7ffaae6d9d80
        public void SetOverride(){} // RVA: 0x7ffaae6d9de0
    }

    public class SteamVR_SphericalProjection : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnRenderImage(){} // RVA: 0x7ffaae6da9d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void Set(){} // RVA: 0x7ffaae6da3e0
    }

    public class SteamVR_TrackedCamera : Object
    {
        public object videostreams; // 0x3370F710
        public object index; // 0x337C5740

        // ── Original Methods ──
        public void Distorted(){} // RVA: 0x7ffaae6daa60
        public void Undistorted(){} // RVA: 0x7ffaae6dac00
        public void Source(){} // RVA: 0x7ffaae6dadb0
        public void Stream(){} // RVA: 0x7ffaae6db0f0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class SteamVR_TrackedObject : MonoBehaviour
    {
        public object _isValid; // 0x337C5740, was: <isValid>k__BackingField

        // ── Original Methods ──
        public void get_isValid(){} // RVA: 0x7ffaa8958450
        public void set_isValid(){} // RVA: 0x7ffaa8958460
        public void OnNewPoses(){} // RVA: 0x7ffaae6dbee0
        public void .ctor(){} // RVA: 0x7ffaae6dc4c0
        public void Awake(){} // RVA: 0x7ffaae6dc5e0
        public void OnEnable(){} // RVA: 0x7ffaae6dc5e0
        public void OnDisable(){} // RVA: 0x7ffaae6dc770
        // ── Binary Analysis Named ──
        public void SetDeviceIndex(){} // RVA: 0x7ffaae6dc7b0
    }

    public class SteamVR_TrackingReferenceManager : MonoBehaviour
    {
        // ── Original Methods ──
        public void OnEnable(){} // RVA: 0x7ffaae6dc970
        public void OnDisable(){} // RVA: 0x7ffaae6dca50
        public void OnNewPoses(){} // RVA: 0x7ffaae6dcb60
        public void .ctor(){} // RVA: 0x7ffaae6dcef0
    }

}