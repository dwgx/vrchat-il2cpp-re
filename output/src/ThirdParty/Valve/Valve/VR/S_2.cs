// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 88
// Methods: 1195

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVREnumEqualityComparer`1 : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0xA94080
        public void GetHashCode(){} // RVA: 0xA94080
    }

    public class SteamVR_ActionSet_Manager : Object
    {
        public object activeActionSetSize;
        public object changed;
        public object currentArraySize;
        public object poolActiveActionSetArrays;
        public object lastFrameUpdated;
        public object debugActiveSetListText;
        public object updateDebugTextInBuilds;

        // ── Methods ──
        public void get_rawActiveActionSetArray(){} // RVA: 0x6F12E20
        public void Initialize(){} // RVA: 0x6F12EA0
        public void DisableAllActionSets(){} // RVA: 0x6F13020
        public void UpdateActionStates(){} // RVA: 0x6F13170
        public void SetChanged(){} // RVA: 0x6F13490
        public void GetNewArraySize(){} // RVA: 0x6F134D0
        public void UpdateActionSetsArray(){} // RVA: 0x6F13630
        public void GetSetFromHandle(){} // RVA: 0x6F13BB0
        public void UpdateDebugText(){} // RVA: 0x6F13CD0
    }

    public class SteamVR_Action_Boolean : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x6F141B0
        public void remove_onChange(){} // RVA: 0x6F14230
        public void add_onUpdate(){} // RVA: 0x6F142B0
        public void remove_onUpdate(){} // RVA: 0x6F14330
        public void add_onState(){} // RVA: 0x6F143B0
        public void remove_onState(){} // RVA: 0x6F14430
        public void add_onStateDown(){} // RVA: 0x6F144B0
        public void remove_onStateDown(){} // RVA: 0x6F14530
        public void add_onStateUp(){} // RVA: 0x6F145B0
        public void remove_onStateUp(){} // RVA: 0x6F14630
        public void add_onActiveChange(){} // RVA: 0x6F146B0
        public void remove_onActiveChange(){} // RVA: 0x6F14730
        public void add_onActiveBindingChange(){} // RVA: 0x6F147B0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F14830
        public void get_state(){} // RVA: 0x6F148B0
        public void get_stateDown(){} // RVA: 0x6F14940
        public void get_stateUp(){} // RVA: 0x6F149D0
        public void get_lastState(){} // RVA: 0x6F14A60
        public void get_lastStateDown(){} // RVA: 0x6F14AC0
        public void get_lastStateUp(){} // RVA: 0x6F14B40
        public void .ctor(){} // RVA: 0x6F14BC0
        public void GetStateDown(){} // RVA: 0x6F14C00
        public void GetStateUp(){} // RVA: 0x6F14CA0
        public void GetState(){} // RVA: 0x6F14D40
        public void GetLastStateDown(){} // RVA: 0x6F14DE0
        public void GetLastStateUp(){} // RVA: 0x6F14E70
        public void GetLastState(){} // RVA: 0x6F14F00
        public void AddOnActiveChangeListener(){} // RVA: 0x6F14F70
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F14FF0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x6F15070
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x6F150F0
        public void AddOnChangeListener(){} // RVA: 0x6F15170
        public void RemoveOnChangeListener(){} // RVA: 0x6F151F0
        public void AddOnUpdateListener(){} // RVA: 0x6F15270
        public void RemoveOnUpdateListener(){} // RVA: 0x6F152F0
        public void AddOnStateDownListener(){} // RVA: 0x6F15370
        public void RemoveOnStateDownListener(){} // RVA: 0x6F153F0
        public void AddOnStateUpListener(){} // RVA: 0x6F15470
        public void RemoveOnStateUpListener(){} // RVA: 0x6F154F0
        public void RemoveAllListeners(){} // RVA: 0x6F15570
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F155E0
    }

    public class SteamVR_Action_Boolean_Source : SteamVR_Action_In_Source
    {
        public object actionData_size;
        public object onStateDown;
        public object onStateUp;
        public object onState;
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onChange;
        public object onUpdate;
        public object _lastActive;
        public object actionData;
        public object lastActionData;
        public object booleanAction;

        // ── Methods ──
        public void add_onStateDown(){} // RVA: 0x6F159F0
        public void remove_onStateDown(){} // RVA: 0x6F15AF0
        public void add_onStateUp(){} // RVA: 0x6F15BF0
        public void remove_onStateUp(){} // RVA: 0x6F15CF0
        public void add_onState(){} // RVA: 0x6F15DF0
        public void remove_onState(){} // RVA: 0x6F15EF0
        public void add_onActiveChange(){} // RVA: 0x6F15FF0
        public void remove_onActiveChange(){} // RVA: 0x6F160F0
        public void add_onActiveBindingChange(){} // RVA: 0x6F161F0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F162F0
        public void add_onChange(){} // RVA: 0x6F163F0
        public void remove_onChange(){} // RVA: 0x6F164F0
        public void add_onUpdate(){} // RVA: 0x6F165F0
        public void remove_onUpdate(){} // RVA: 0x6F166F0
        public void get_state(){} // RVA: 0x6F167F0
        public void get_stateDown(){} // RVA: 0x6F16830
        public void get_stateUp(){} // RVA: 0x6F16870
        public void get_changed(){} // RVA: 0x6F168B0
        public void set_changed(){} // RVA: 0xB43310
        public void get_lastState(){} // RVA: 0x6F168F0
        public void get_lastStateDown(){} // RVA: 0x6F16900
        public void get_lastStateUp(){} // RVA: 0x6F16920
        public void get_lastChanged(){} // RVA: 0x6F16940
        public void set_lastChanged(){} // RVA: 0xB43310
        public void get_activeOrigin(){} // RVA: 0x6F16950
        public void get_lastActiveOrigin(){} // RVA: 0x1659CB0
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6E15480
        public void get_lastActive(){} // RVA: 0x6F16A30
        public void set_lastActive(){} // RVA: 0x6F16A40
        public void get_lastActiveBinding(){} // RVA: 0x6F16A50
        public void Preinitialize(){} // RVA: 0x6F16A60
        public void Initialize(){} // RVA: 0x6F16BF0
        public void RemoveAllListeners(){} // RVA: 0x6F16CE0
        public void UpdateValue(){} // RVA: 0x6F17090
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Action_Boolean_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Boolean_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F159B0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        public object updatingSources;

        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x4B517C0
        public void get_lastChanged(){} // RVA: 0x4B517C0
        public void get_changedTime(){} // RVA: 0x4B51810
        public void get_updateTime(){} // RVA: 0x4B51850
        public void get_activeOrigin(){} // RVA: 0x4B51890
        public void get_lastActiveOrigin(){} // RVA: 0x4B518E0
        public void get_activeDevice(){} // RVA: 0x4B51930
        public void get_trackedDeviceIndex(){} // RVA: 0x4B519C0
        public void get_renderModelComponentName(){} // RVA: 0x4B51A10
        public void get_localizedOriginName(){} // RVA: 0x4B51A60
        public void UpdateValues(){} // RVA: 0x4B51AB0
        public void GetRenderModelComponentName(){} // RVA: 0x4B51BA0
        public void GetActiveDevice(){} // RVA: 0x4B51BF0
        public void GetDeviceIndex(){} // RVA: 0x4B51C80
        public void GetChanged(){} // RVA: 0x4B51CD0
        public void GetTimeLastChanged(){} // RVA: 0x4B51D20
        public void GetLocalizedOriginPart(){} // RVA: 0x4B51D60
        public void GetLocalizedOrigin(){} // RVA: 0x4B51DB0
        public void IsUpdating(){} // RVA: 0x4B51DF0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51EB0
        public void GetControllerType(){} // RVA: 0x4B51EE0
        public void .ctor(){} // RVA: 0x4B51F80
    }

    public class SteamVR_Action_Out_Source : SteamVR_Action_Source
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B52000
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        public object sources;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Vector2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x6F27540
        public void remove_onChange(){} // RVA: 0x6F275C0
        public void add_onUpdate(){} // RVA: 0x6F27640
        public void remove_onUpdate(){} // RVA: 0x6F276C0
        public void add_onAxis(){} // RVA: 0x6F27740
        public void remove_onAxis(){} // RVA: 0x6F277C0
        public void add_onActiveChange(){} // RVA: 0x6F27840
        public void remove_onActiveChange(){} // RVA: 0x6F278C0
        public void add_onActiveBindingChange(){} // RVA: 0x6F27940
        public void remove_onActiveBindingChange(){} // RVA: 0x6F279C0
        public void get_axis(){} // RVA: 0x6F27A40
        public void get_lastAxis(){} // RVA: 0x6F27AC0
        public void get_delta(){} // RVA: 0x6F27B40
        public void get_lastDelta(){} // RVA: 0x6F27BC0
        public void .ctor(){} // RVA: 0x6F27C40
        public void GetAxis(){} // RVA: 0x6F27C80
        public void GetAxisDelta(){} // RVA: 0x6F27D00
        public void GetLastAxis(){} // RVA: 0x6F27D80
        public void GetLastAxisDelta(){} // RVA: 0x6F27E00
        public void AddOnActiveChangeListener(){} // RVA: 0x6F27E80
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F27F00
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x6F27F80
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x6F28000
        public void AddOnChangeListener(){} // RVA: 0x6F28080
        public void RemoveOnChangeListener(){} // RVA: 0x6F28100
        public void AddOnUpdateListener(){} // RVA: 0x6F28180
        public void RemoveOnUpdateListener(){} // RVA: 0x6F28200
        public void AddOnAxisListener(){} // RVA: 0x6F28280
        public void RemoveOnAxisListener(){} // RVA: 0x6F28300
        public void RemoveAllListeners(){} // RVA: 0x6F28380
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F283F0
    }

    public class SteamVR_Action_Vector2_Source : SteamVR_Action_In_Source
    {
        public object actionData_size;
        public object changeTolerance;
        public object onAxis;
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onChange;
        public object onUpdate;
        public object _axis;
        public object _lastAxis;
        public object _delta;
        public object _lastDelta;
        public object _changed;
        public object _lastChanged;
        public object _lastActive;
        public object actionData;
        public object lastActionData;
        public object vector2Action;

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x6F3E2B0
        public void remove_onAxis(){} // RVA: 0x6F3E3B0
        public void add_onActiveChange(){} // RVA: 0x6F3E4B0
        public void remove_onActiveChange(){} // RVA: 0x6F3E5B0
        public void add_onActiveBindingChange(){} // RVA: 0x6F3E6B0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F3E7B0
        public void add_onChange(){} // RVA: 0x6F3E8B0
        public void remove_onChange(){} // RVA: 0x6F3E9B0
        public void add_onUpdate(){} // RVA: 0x6F3EAB0
        public void remove_onUpdate(){} // RVA: 0x6F3EBB0
        public void get_axis(){} // RVA: 0x1DD8DB0
        public void set_axis(){} // RVA: 0x6F3ECB0
        public void get_lastAxis(){} // RVA: 0x6F3ECC0
        public void set_lastAxis(){} // RVA: 0x6F3ECE0
        public void get_delta(){} // RVA: 0x6F3ECF0
        public void set_delta(){} // RVA: 0x6F3ED10
        public void get_lastDelta(){} // RVA: 0x6F3ED20
        public void set_lastDelta(){} // RVA: 0x6F3ED40
        public void get_changed(){} // RVA: 0x6F3ED50
        public void set_changed(){} // RVA: 0x6F3ED60
        public void get_lastChanged(){} // RVA: 0x6F3ED70
        public void set_lastChanged(){} // RVA: 0x6F3ED80
        public void get_activeOrigin(){} // RVA: 0x6F3ED90
        public void get_lastActiveOrigin(){} // RVA: 0x164FF50
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6F16A50
        public void get_lastActive(){} // RVA: 0x6F3EDD0
        public void set_lastActive(){} // RVA: 0x6F3EDE0
        public void get_lastActiveBinding(){} // RVA: 0x6F3EDF0
        public void Preinitialize(){} // RVA: 0x6F3EE00
        public void Initialize(){} // RVA: 0x6F3EF90
        public void RemoveAllListeners(){} // RVA: 0x6F3F080
        public void UpdateValue(){} // RVA: 0x6F3F390
        public void .ctor(){} // RVA: 0x6F3FB50
    }

    public class SteamVR_Action_Vector2_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Vector2_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F3E270
    }

    public class SteamVR_Action_Vector3 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x6F3FBA0
        public void remove_onChange(){} // RVA: 0x6F3FC20
        public void add_onUpdate(){} // RVA: 0x6F3FCA0
        public void remove_onUpdate(){} // RVA: 0x6F3FD20
        public void add_onAxis(){} // RVA: 0x6F3FDA0
        public void remove_onAxis(){} // RVA: 0x6F3FE20
        public void add_onActiveChange(){} // RVA: 0x6F3FEA0
        public void remove_onActiveChange(){} // RVA: 0x6F3FF20
        public void add_onActiveBindingChange(){} // RVA: 0x6F3FFA0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F40020
        public void get_axis(){} // RVA: 0x6F400A0
        public void get_lastAxis(){} // RVA: 0x6F40120
        public void get_delta(){} // RVA: 0x6F401A0
        public void get_lastDelta(){} // RVA: 0x6F40220
        public void .ctor(){} // RVA: 0x6F402A0
        public void GetAxis(){} // RVA: 0x6F402E0
        public void GetAxisDelta(){} // RVA: 0x6F40370
        public void GetLastAxis(){} // RVA: 0x6F40400
        public void GetLastAxisDelta(){} // RVA: 0x6F40490
        public void AddOnActiveChangeListener(){} // RVA: 0x6F40520
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F405A0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x6F40620
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x6F406A0
        public void AddOnChangeListener(){} // RVA: 0x6F40720
        public void RemoveOnChangeListener(){} // RVA: 0x6F407A0
        public void AddOnUpdateListener(){} // RVA: 0x6F40820
        public void RemoveOnUpdateListener(){} // RVA: 0x6F408A0
        public void AddOnAxisListener(){} // RVA: 0x6F40920
        public void RemoveOnAxisListener(){} // RVA: 0x6F409A0
        public void RemoveAllListeners(){} // RVA: 0x6F40A20
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F40A90
    }

    public class SteamVR_Action_Vector3_Source : SteamVR_Action_In_Source
    {
        public object actionData_size;
        public object changeTolerance;
        public object onAxis;
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onChange;
        public object onUpdate;
        public object _axis;
        public object _lastAxis;
        public object _delta;
        public object _lastDelta;
        public object _changed;
        public object _lastChanged;
        public object _lastActive;
        public object actionData;
        public object lastActionData;
        public object vector3Action;

        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x6F40E20
        public void remove_onAxis(){} // RVA: 0x6F40F20
        public void add_onActiveChange(){} // RVA: 0x6F41020
        public void remove_onActiveChange(){} // RVA: 0x6F41120
        public void add_onActiveBindingChange(){} // RVA: 0x6F41220
        public void remove_onActiveBindingChange(){} // RVA: 0x6F41320
        public void add_onChange(){} // RVA: 0x6F41420
        public void remove_onChange(){} // RVA: 0x6F41520
        public void add_onUpdate(){} // RVA: 0x6F41620
        public void remove_onUpdate(){} // RVA: 0x6F41720
        public void get_axis(){} // RVA: 0x6F41820
        public void set_axis(){} // RVA: 0x6F41840
        public void get_lastAxis(){} // RVA: 0x6F41860
        public void set_lastAxis(){} // RVA: 0x6F41880
        public void get_delta(){} // RVA: 0x6F418A0
        public void set_delta(){} // RVA: 0x6F418C0
        public void get_lastDelta(){} // RVA: 0x6F418E0
        public void set_lastDelta(){} // RVA: 0x6F41900
        public void get_changed(){} // RVA: 0x6E156E0
        public void set_changed(){} // RVA: 0x6E156F0
        public void get_lastChanged(){} // RVA: 0x6F41920
        public void set_lastChanged(){} // RVA: 0x6F41930
        public void get_activeOrigin(){} // RVA: 0x6F41940
        public void get_lastActiveOrigin(){} // RVA: 0x136ECA0
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6F168F0
        public void get_lastActive(){} // RVA: 0x6F41980
        public void set_lastActive(){} // RVA: 0x6F41990
        public void get_lastActiveBinding(){} // RVA: 0x2548D20
        public void Preinitialize(){} // RVA: 0x6F419A0
        public void Initialize(){} // RVA: 0x6F41B30
        public void RemoveAllListeners(){} // RVA: 0x6F41C20
        public void UpdateValue(){} // RVA: 0x6F41F30
        public void .ctor(){} // RVA: 0x6F42760
    }

    public class SteamVR_Action_Vector3_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Vector3_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F40DE0
    }

    public class SteamVR_Action_Vibration : SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F427B0
        public void remove_onActiveChange(){} // RVA: 0x6F42830
        public void add_onActiveBindingChange(){} // RVA: 0x6F428B0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F42930
        public void add_onExecute(){} // RVA: 0x6F429B0
        public void remove_onExecute(){} // RVA: 0x6F42A30
        public void .ctor(){} // RVA: 0x6F42AB0
        public void Execute(){} // RVA: 0x6F42B50
        public void AddOnActiveChangeListener(){} // RVA: 0x6F42C00
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F42C80
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x6F42D00
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x6F42D80
        public void AddOnExecuteListener(){} // RVA: 0x6F42E00
        public void RemoveOnExecuteListener(){} // RVA: 0x6F42E80
        public void RemoveAllListeners(){} // RVA: 0x6F42F00
        public void GetTimeLastChanged(){} // RVA: 0x6F42F70
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F42FE0
        public void IsUpdating(){} // RVA: 0x6F43020
    }

    public class SteamVR_Action_Vibration_Source : SteamVR_Action_Out_Source
    {
        public object onActiveChange;
        public object onActiveBindingChange;
        public object onExecute;
        public object _lastActive;
        public object _timeLastExecuted;
        public object vibrationAction;

        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F43410
        public void remove_onActiveChange(){} // RVA: 0x6F43500
        public void add_onActiveBindingChange(){} // RVA: 0x6F435F0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F436E0
        public void add_onExecute(){} // RVA: 0x6F437D0
        public void remove_onExecute(){} // RVA: 0x6F438C0
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0xC2E4C0
        public void get_lastActive(){} // RVA: 0xC02470
        public void set_lastActive(){} // RVA: 0xC02480
        public void get_lastActiveBinding(){} // RVA: 0xC2E4C0
        public void get_timeLastExecuted(){} // RVA: 0xB4B880
        public void set_timeLastExecuted(){} // RVA: 0xB4B890
        public void Initialize(){} // RVA: 0x6F439B0
        public void Preinitialize(){} // RVA: 0x6F43A30
        public void RemoveAllListeners(){} // RVA: 0x6F43BB0
        public void Execute(){} // RVA: 0x6F43D90
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Action_Vibration_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Action_Vibration_Source_Map : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x6F43380
        public void .ctor(){} // RVA: 0x6F433D0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        public object sourceMap;
        public object initialized;
        public object inputBindingInfo_size;
        public object zeroLengthBindingInfos;

        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B531B0
        public void get_fullPath(){} // RVA: 0x4B531E0
        public void get_handle(){} // RVA: 0x4B53200
        public void get_actionSet(){} // RVA: 0x4B53220
        public void get_direction(){} // RVA: 0x4B53240
        public void get_active(){} // RVA: 0x4B53260
        public void get_lastActive(){} // RVA: 0x4B532B0
        public void get_activeBinding(){} // RVA: 0x4B53300
        public void get_lastActiveBinding(){} // RVA: 0x4B53350
        public void PreInitialize(){} // RVA: 0x4B533A0
        public void CreateUninitialized(){} // RVA: 0x4B535C0
        public void TryNeedsInitData(){} // RVA: 0x4B537C0
        public void Initialize(){} // RVA: 0x4B53A80
        public void GetSourceMap(){} // RVA: 0xB70160
        public void InitializeCopy(){} // RVA: 0x4B53B90
        public void InitAfterDeserialize(){} // RVA: 0x4B53D10
        public void GetActive(){} // RVA: 0x4B53DC0
        public void GetActiveBinding(){} // RVA: 0x4B53E10
        public void GetLastActive(){} // RVA: 0x4B53E60
        public void GetLastActiveBinding(){} // RVA: 0x4B53EB0
        public void GetActionBindingInfo(){} // RVA: 0x4B53F00
        public void .ctor(){} // RVA: 0x4B545B0
        public void .cctor(){} // RVA: 0x4B54600
    }

    public class SteamVR_Actions : Object
    {
        public object p_global_Safe_Mode;
        public object p_global_Pose;
        public object p_global_SkeletonLeftHand;
        public object p_global_SkeletonRightHand;
        public object p_global_HeadsetOnHead;
        public object p_global_Menu;
        public object p_global_Quick_Menu;
        public object p_global_Action_Menu;
        public object p_global_Main_Menu;
        public object p_global_Interact;
        public object p_global_Grab;
        public object p_global_Move;
        public object p_global_Jump;
        public object p_global_Rotate;
        public object p_global_Mic;
        public object p_global_Gesture_Toggle;
        public object p_global_Stick_Click;
        public object p_global_Trigger_Axis;
        public object p_global_Grip_Axis;
        public object p_global_Udon_Menu;
        public object p_global_Drop;
        public object p_global_Nameplates;
        public object p_global_HUD;
        public object p_global_Chatbox;
        public object p_global_Face_Mirror;
        public object p_global_Personal_Mirror;
        public object p_global_Personal_Mirror_Lock;
        public object p_global_Earmuffs;
        public object p_global_Camera;
        public object p_global_Stream_Camera;
        public object p_global_Avatar_Debug_Screen;
        public object p_global_OSC_Debug_Screen;
        public object p_global_Confirm_FBT_Calibration;
        public object p_global_Start_Move;
        public object p_global_Start_Rotate;
        public object p_global_Continue_Move;
        public object p_global_Continue_Rotate;
        public object p_global_No_Gesture_After_Move;
        public object p_global_No_Gesture_After_Rotate;
        public object p_global_Gesture_Activator_Thumb;
        public object p_global_Gesture_Activator_Thumb_Inner_Upper;
        public object p_global_Gesture_Activator_Thumb_Inner_Lower;
        public object p_global_Gesture_Activator_Thumb_Outer;
        public object p_global_Gesture_Activator_Index;
        public object p_global_Gesture_Activator_Grip;
        public object p_global_Gesture_Trigger_Axis;
        public object p_global_Gesture_Grip_Axis;
        public object p_global_Gesture_Activator_Stick_Deflection;
        public object p_global_Gesture_Direct_Neutral_Left;
        public object p_global_Gesture_Direct_Fist_Left;
        public object p_global_Gesture_Direct_Open_Left;
        public object p_global_Gesture_Direct_Peace_Left;
        public object p_global_Gesture_Direct_Horns_Left;
        public object p_global_Gesture_Direct_Finger_Gun_Left;
        public object p_global_Gesture_Direct_Thumbs_Up_Left;
        public object p_global_Gesture_Direct_Point_Left;
        public object p_global_Gesture_Direct_Neutral_Right;
        public object p_global_Gesture_Direct_Fist_Right;
        public object p_global_Gesture_Direct_Open_Right;
        public object p_global_Gesture_Direct_Peace_Right;
        public object p_global_Gesture_Direct_Horns_Right;
        public object p_global_Gesture_Direct_Finger_Gun_Right;
        public object p_global_Gesture_Direct_Thumbs_Up_Right;
        public object p_global_Gesture_Direct_Point_Right;
        public object p_global_Gesture_Wheel_Left;
        public object p_global_Gesture_Wheel_Select_Left;
        public object p_global_Gesture_Wheel_Soft_Select_Left;
        public object p_global_Gesture_Wheel_Weight_Left;
        public object p_global_Gesture_Wheel_Direct_Left;
        public object p_global_Gesture_Wheel_Direct_Stay_Left;
        public object p_global_Gesture_Wheel_Cancel_Left;
        public object p_global_Gesture_Wheel_Cancel_Open_Left;
        public object p_global_Gesture_Wheel_Held_Left;
        public object p_global_Gesture_Wheel_Right;
        public object p_global_Gesture_Wheel_Select_Right;
        public object p_global_Gesture_Wheel_Soft_Select_Right;
        public object p_global_Gesture_Wheel_Weight_Right;
        public object p_global_Gesture_Wheel_Direct_Right;
        public object p_global_Gesture_Wheel_Direct_Stay_Right;
        public object p_global_Gesture_Wheel_Cancel_Right;
        public object p_global_Gesture_Wheel_Cancel_Open_Right;
        public object p_global_Gesture_Wheel_Held_Right;
        public object p_global_Disable_Gesture_Tracked;
        public object p_global_Disable_Gesture_Wheel_Move_Left;
        public object p_global_Disable_Gesture_Wheel_Rotate_Left;
        public object p_global_Disable_Gesture_Wheel_Move_Right;
        public object p_global_Disable_Gesture_Wheel_Rotate_Right;
        public object p_global_Physbone_Grab_Left;
        public object p_global_Physbone_Freeze_Left;
        public object p_global_Physbone_Grab_Right;
        public object p_global_Physbone_Freeze_Right;
        public object p_global_Scroll;
        public object p_global_Haptic;
        public object p_one_Hand_Interact;
        public object p_one_Hand_Grab;
        public object p_one_Hand_Move_Rotate;
        public object p_one_Hand_Jump;
        public object p_one_Hand_Mic;
        public object p_one_Hand_Gesture_Toggle;
        public object p_one_Hand_Stick_Click;
        public object p_one_Hand_Trigger_Axis;
        public object p_one_Hand_Grip_Axis;
        public object p_one_Hand_Udon_Menu;
        public object p_one_Hand_Drop;
        public object p_one_Hand_Start_Move_Rotate;
        public object p_one_Hand_Continue_Move_Rotate;
        public object p_one_Hand_No_Gesture_After_Move_Rotate;
        public object p_one_Hand_Menu;
        public object p_one_Hand_Nameplates;
        public object p_one_Hand_HUD;
        public object p_one_Hand_Chatbox;
        public object p_one_Hand_Face_Mirror;
        public object p_one_Hand_Personal_Mirror;
        public object p_one_Hand_Personal_Mirror_Lock;
        public object p_one_Hand_Earmuffs;
        public object p_one_Hand_Camera;
        public object p_one_Hand_Stream_Camera;
        public object p_one_Hand_Avatar_Debug_Screen;
        public object p_one_Hand_OSC_Debug_Screen;
        public object p_one_Hand_Confirm_FBT_Calibration;
        public object p_one_Hand_Gesture_Activator_Thumb;
        public object p_one_Hand_Gesture_Activator_Thumb_Inner_Upper;
        public object p_one_Hand_Gesture_Activator_Thumb_Inner_Lower;
        public object p_one_Hand_Gesture_Activator_Thumb_Outer;
        public object p_one_Hand_Gesture_Activator_Index;
        public object p_one_Hand_Gesture_Activator_Grip;
        public object p_one_Hand_Gesture_Trigger_Axis;
        public object p_one_Hand_Gesture_Grip_Axis;
        public object p_one_Hand_Gesture_Activator_Stick_Deflection;
        public object p_one_Hand_Gesture_Wheel_Left;
        public object p_one_Hand_Gesture_Wheel_Select_Left;
        public object p_one_Hand_Gesture_Wheel_Soft_Select_Left;
        public object p_one_Hand_Gesture_Wheel_Weight_Left;
        public object p_one_Hand_Gesture_Wheel_Direct_Left;
        public object p_one_Hand_Gesture_Wheel_Direct_Stay_Left;
        public object p_one_Hand_Gesture_Wheel_Cancel_Left;
        public object p_one_Hand_Gesture_Wheel_Cancel_Open_Left;
        public object p_one_Hand_Gesture_Wheel_Held_Left;
        public object p_one_Hand_Gesture_Wheel_Right;
        public object p_one_Hand_Gesture_Wheel_Select_Right;
        public object p_one_Hand_Gesture_Wheel_Soft_Select_Right;
        public object p_one_Hand_Gesture_Wheel_Weight_Right;
        public object p_one_Hand_Gesture_Wheel_Direct_Right;
        public object p_one_Hand_Gesture_Wheel_Direct_Stay_Right;
        public object p_one_Hand_Gesture_Wheel_Cancel_Right;
        public object p_one_Hand_Gesture_Wheel_Cancel_Open_Right;
        public object p_one_Hand_Gesture_Wheel_Held_Right;
        public object p_one_Hand_Disable_Gesture_Wheel_Move_Left;
        public object p_one_Hand_Disable_Gesture_Wheel_Rotate_Left;
        public object p_one_Hand_Disable_Gesture_Wheel_Move_Right;
        public object p_one_Hand_Disable_Gesture_Wheel_Rotate_Right;
        public object p_one_Hand_Reserve_bool;
        public object p_one_Hand_Reserve_vector1;
        public object p_one_Hand_Reserve_vector2;
        public object p_menu_Confirm;
        public object p_menu_Back;
        public object p_menu_Tab;
        public object p_menu_Scroll;
        public object p_menu_Quick_Menu_Close;
        public object p_menu_Drag;
        public object p_action_Menu_Axis;
        public object p_action_Menu_Select;
        public object p_action_Menu_Gesture_Activator_Thumb;
        public object p_action_Menu_Gesture_Activator_Thumb_Inner_Upper;
        public object p_action_Menu_Gesture_Activator_Thumb_Inner_Lower;
        public object p_action_Menu_Gesture_Activator_Thumb_Outer;
        public object p_action_Menu_Gesture_Activator_Index;
        public object p_action_Menu_Gesture_Activator_Grip;
        public object p_action_Menu_Gesture_Trigger_Axis;
        public object p_action_Menu_Gesture_Grip_Axis;
        public object p_action_Menu_Gesture_Activator_Stick_Deflection;
        public object p_action_Menu_Gesture_Wheel_Left;
        public object p_action_Menu_Gesture_Wheel_Select_Left;
        public object p_action_Menu_Gesture_Wheel_Soft_Select_Left;
        public object p_action_Menu_Gesture_Wheel_Weight_Left;
        public object p_action_Menu_Gesture_Wheel_Direct_Left;
        public object p_action_Menu_Gesture_Wheel_Direct_Stay_Left;
        public object p_action_Menu_Gesture_Wheel_Cancel_Left;
        public object p_action_Menu_Gesture_Wheel_Cancel_Open_Left;
        public object p_action_Menu_Gesture_Wheel_Held_Left;
        public object p_action_Menu_Gesture_Wheel_Right;
        public object p_action_Menu_Gesture_Wheel_Select_Right;
        public object p_action_Menu_Gesture_Wheel_Soft_Select_Right;
        public object p_action_Menu_Gesture_Wheel_Weight_Right;
        public object p_action_Menu_Gesture_Wheel_Direct_Right;
        public object p_action_Menu_Gesture_Wheel_Direct_Stay_Right;
        public object p_action_Menu_Gesture_Wheel_Cancel_Right;
        public object p_action_Menu_Gesture_Wheel_Cancel_Open_Right;
        public object p_action_Menu_Gesture_Wheel_Held_Right;
        public object p_action_Menu_Disable_Gesture_Wheel_Move_Left;
        public object p_action_Menu_Disable_Gesture_Wheel_Rotate_Left;
        public object p_action_Menu_Disable_Gesture_Wheel_Move_Right;
        public object p_action_Menu_Disable_Gesture_Wheel_Rotate_Right;
        public object p_action_Menu_Reserve_bool;
        public object p_action_Menu_Reserve_vector1;
        public object p_action_Menu_Reserve_vector2;
        public object p_action_Menu_Grab;
        public object p_action_Menu_Drop;
        public object p_drone_Left_Joystick;
        public object p_drone_Right_Joystick;
        public object p_drone_Self_Leveling_Mod;
        public object p_drone_Hold_Altitude_Mod;
        public object p_drone_Toggle_FPV;
        public object p_drone_Flip;
        public object p_drone_Take_Picture;
        public object p_drone_Cycle_Flight_Preset;
        public object p_drone_Toggle_Self_Leveling;
        public object p_drone_Respawn;
        public object p_drone_Select_Flight_Preset_Micro;
        public object p_drone_Select_Flight_Preset_Cinematic;
        public object p_drone_Select_Flight_Preset_Racing;
        public object p_drone_Select_Flight_Preset_Freestyle;
        public object p_Global;
        public object p_One_Hand;
        public object p_Menu;
        public object p_Action_Menu;
        public object p_Drone;

        // ── Methods ──
        public void get_global_Safe_Mode(){} // RVA: 0x6F292E0
        public void get_global_Pose(){} // RVA: 0x6F29350
        public void get_global_SkeletonLeftHand(){} // RVA: 0x6F293C0
        public void get_global_SkeletonRightHand(){} // RVA: 0x6F29430
        public void get_global_HeadsetOnHead(){} // RVA: 0x6F294A0
        public void get_global_Menu(){} // RVA: 0x6F29510
        public void get_global_Quick_Menu(){} // RVA: 0x6F29580
        public void get_global_Action_Menu(){} // RVA: 0x6F295F0
        public void get_global_Main_Menu(){} // RVA: 0x6F29660
        public void get_global_Interact(){} // RVA: 0x6F296D0
        public void get_global_Grab(){} // RVA: 0x6F29740
        public void get_global_Move(){} // RVA: 0x6F297B0
        public void get_global_Jump(){} // RVA: 0x6F29820
        public void get_global_Rotate(){} // RVA: 0x6F29890
        public void get_global_Mic(){} // RVA: 0x6F29900
        public void get_global_Gesture_Toggle(){} // RVA: 0x6F29970
        public void get_global_Stick_Click(){} // RVA: 0x6F299E0
        public void get_global_Trigger_Axis(){} // RVA: 0x6F29A50
        public void get_global_Grip_Axis(){} // RVA: 0x6F29AC0
        public void get_global_Udon_Menu(){} // RVA: 0x6F29B30
        public void get_global_Drop(){} // RVA: 0x6F29BA0
        public void get_global_Nameplates(){} // RVA: 0x6F29C10
        public void get_global_HUD(){} // RVA: 0x6F29C80
        public void get_global_Chatbox(){} // RVA: 0x6F29CF0
        public void get_global_Face_Mirror(){} // RVA: 0x6F29D60
        public void get_global_Personal_Mirror(){} // RVA: 0x6F29DD0
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x6F29E40
        public void get_global_Earmuffs(){} // RVA: 0x6F29EB0
        public void get_global_Camera(){} // RVA: 0x6F29F20
        public void get_global_Stream_Camera(){} // RVA: 0x6F29F90
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x6F2A000
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x6F2A070
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x6F2A0E0
        public void get_global_Start_Move(){} // RVA: 0x6F2A150
        public void get_global_Start_Rotate(){} // RVA: 0x6F2A1C0
        public void get_global_Continue_Move(){} // RVA: 0x6F2A230
        public void get_global_Continue_Rotate(){} // RVA: 0x6F2A2A0
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x6F2A310
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x6F2A380
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x6F2A3F0
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x6F2A460
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x6F2A4D0
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x6F2A540
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x6F2A5B0
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x6F2A620
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x6F2A690
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x6F2A700
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x6F2A770
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x6F2A7E0
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x6F2A850
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x6F2A8C0
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x6F2A930
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x6F2A9A0
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x6F2AA10
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x6F2AA80
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x6F2AAF0
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x6F2AB60
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x6F2ABD0
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x6F2AC40
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x6F2ACB0
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x6F2AD20
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x6F2AD90
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x6F2AE00
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x6F2AE70
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x6F2AEE0
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x6F2AF50
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x6F2AFC0
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x6F2B030
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x6F2B0A0
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x6F2B110
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x6F2B180
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x6F2B1F0
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x6F2B260
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x6F2B2D0
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x6F2B340
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x6F2B3B0
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x6F2B420
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x6F2B490
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x6F2B500
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x6F2B570
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x6F2B5E0
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x6F2B650
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x6F2B6C0
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x6F2B730
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x6F2B7A0
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x6F2B810
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x6F2B880
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x6F2B8F0
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x6F2B960
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x6F2B9D0
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x6F2BA40
        public void get_global_Scroll(){} // RVA: 0x6F2BAB0
        public void get_global_Haptic(){} // RVA: 0x6F2BB20
        public void get_one_Hand_Interact(){} // RVA: 0x6F2BB90
        public void get_one_Hand_Grab(){} // RVA: 0x6F2BC00
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x6F2BC70
        public void get_one_Hand_Jump(){} // RVA: 0x6F2BCE0
        public void get_one_Hand_Mic(){} // RVA: 0x6F2BD50
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x6F2BDC0
        public void get_one_Hand_Stick_Click(){} // RVA: 0x6F2BE30
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x6F2BEA0
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x6F2BF10
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x6F2BF80
        public void get_one_Hand_Drop(){} // RVA: 0x6F2BFF0
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x6F2C060
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x6F2C0D0
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x6F2C140
        public void get_one_Hand_Menu(){} // RVA: 0x6F2C1B0
        public void get_one_Hand_Nameplates(){} // RVA: 0x6F2C220
        public void get_one_Hand_HUD(){} // RVA: 0x6F2C290
        public void get_one_Hand_Chatbox(){} // RVA: 0x6F2C300
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x6F2C370
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x6F2C3E0
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x6F2C450
        public void get_one_Hand_Earmuffs(){} // RVA: 0x6F2C4C0
        public void get_one_Hand_Camera(){} // RVA: 0x6F2C530
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x6F2C5A0
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x6F2C610
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x6F2C680
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x6F2C6F0
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x6F2C760
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x6F2C7D0
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x6F2C840
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x6F2C8B0
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x6F2C920
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x6F2C990
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x6F2CA00
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x6F2CA70
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x6F2CAE0
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x6F2CB50
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x6F2CBC0
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x6F2CC30
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x6F2CCA0
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x6F2CD10
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x6F2CD80
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x6F2CDF0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x6F2CE60
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x6F2CED0
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x6F2CF40
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x6F2CFB0
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x6F2D020
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x6F2D090
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x6F2D100
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x6F2D170
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x6F2D1E0
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x6F2D250
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x6F2D2C0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x6F2D330
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x6F2D3A0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x6F2D410
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x6F2D480
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x6F2D4F0
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x6F2D560
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x6F2D5D0
        public void get_menu_Confirm(){} // RVA: 0x6F2D640
        public void get_menu_Back(){} // RVA: 0x6F2D6B0
        public void get_menu_Tab(){} // RVA: 0x6F2D720
        public void get_menu_Scroll(){} // RVA: 0x6F2D790
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x6F2D800
        public void get_menu_Drag(){} // RVA: 0x6F2D870
        public void get_action_Menu_Axis(){} // RVA: 0x6F2D8E0
        public void get_action_Menu_Select(){} // RVA: 0x6F2D950
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x6F2D9C0
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x6F2DA30
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x6F2DAA0
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x6F2DB10
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x6F2DB80
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x6F2DBF0
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x6F2DC60
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x6F2DCD0
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x6F2DD40
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x6F2DDB0
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x6F2DE20
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x6F2DE90
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x6F2DF00
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x6F2DF70
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x6F2DFE0
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x6F2E050
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x6F2E0C0
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x6F2E130
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x6F2E1A0
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x6F2E210
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x6F2E280
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x6F2E2F0
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x6F2E360
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x6F2E3D0
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x6F2E440
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x6F2E4B0
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x6F2E520
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x6F2E590
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x6F2E600
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x6F2E670
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x6F2E6E0
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x6F2E750
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x6F2E7C0
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x6F2E830
        public void get_action_Menu_Grab(){} // RVA: 0x6F2E8A0
        public void get_action_Menu_Drop(){} // RVA: 0x6F2E910
        public void get_drone_Left_Joystick(){} // RVA: 0x6F2E980
        public void get_drone_Right_Joystick(){} // RVA: 0x6F2E9F0
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x6F2EA60
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x6F2EAD0
        public void get_drone_Toggle_FPV(){} // RVA: 0x6F2EB40
        public void get_drone_Flip(){} // RVA: 0x6F2EBB0
        public void get_drone_Take_Picture(){} // RVA: 0x6F2EC20
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x6F2EC90
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x6F2ED00
        public void get_drone_Respawn(){} // RVA: 0x6F2ED70
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x6F2EDE0
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x6F2EE50
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x6F2EEC0
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x6F2EF30
        public void InitializeActionArrays(){} // RVA: 0x6F2EFA0
        public void PreInitActions(){} // RVA: 0x6F38740
        public void get_Global(){} // RVA: 0x6F3D520
        public void get_One_Hand(){} // RVA: 0x6F3D590
        public void get_Menu(){} // RVA: 0x6F3D600
        public void get_Action_Menu(){} // RVA: 0x6F3D670
        public void get_Drone(){} // RVA: 0x6F3D6E0
        public void StartPreInitActionSets(){} // RVA: 0x6F3D750
        public void PreInitialize(){} // RVA: 0x6F3DE30
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Behaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F4C0
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F550
    }

    public class SteamVR_Behaviour_SingleEvent : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F5E0
    }

    public class SteamVR_Behaviour_Vector2Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F820
    }

    public class SteamVR_Behaviour_Vector3Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F8B0
    }

    public class SteamVR_Events : Object
    {
        public object Calibrating;
        public object DeviceConnected;
        public object Fade;
        public object FadeReady;
        public object HideRenderModels;
        public object Initializing;
        public object InputFocus;
        public object Loading;
        public object LoadingFadeIn;
        public object LoadingFadeOut;
        public object NewPoses;
        public object NewPosesApplied;
        public object Initialized;
        public object OutOfRange;
        public object RenderModelLoaded;
        public object systemEvents;

        // ── Methods ──
        public void CalibratingAction(){} // RVA: 0x6F71420
        public void DeviceConnectedAction(){} // RVA: 0x6F714D0
        public void FadeAction(){} // RVA: 0x6F71620
        public void FadeReadyAction(){} // RVA: 0x6F71770
        public void HideRenderModelsAction(){} // RVA: 0x6F71820
        public void InitializingAction(){} // RVA: 0x6F718D0
        public void InputFocusAction(){} // RVA: 0x6F71980
        public void LoadingAction(){} // RVA: 0x6F71A30
        public void LoadingFadeInAction(){} // RVA: 0x6F71AE0
        public void LoadingFadeOutAction(){} // RVA: 0x6F71B90
        public void NewPosesAction(){} // RVA: 0x6F71C40
        public void NewPosesAppliedAction(){} // RVA: 0x6F71D00
        public void InitializedAction(){} // RVA: 0x6F71DB0
        public void OutOfRangeAction(){} // RVA: 0x6F71E60
        public void RenderModelLoadedAction(){} // RVA: 0x6F71F10
        public void System(){} // RVA: 0x6F72060
        public void SystemAction(){} // RVA: 0x6F72210
        public void .cctor(){} // RVA: 0x6F72350
    }

    public class SteamVR_ExternalCamera_LegacyManager : Object
    {
        public object cameraIndex;
        public object newPosesAction;

        // ── Methods ──
        public void get_hasCamera(){} // RVA: 0x6F77AC0
        public void SubscribeToNewPoses(){} // RVA: 0x6F77B20
        public void OnNewPoses(){} // RVA: 0x6F77CC0
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6F77E00
    }

    public class SteamVR_HistoryBuffer : SteamVR_RingBuffer`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F8DC80
        public void Update(){} // RVA: 0x6F8DD50
        public void GetVelocityMagnitudeTrend(){} // RVA: 0x6F8E0C0
        public void IsValid(){} // RVA: 0x6F8E1C0
        public void GetTopVelocity(){} // RVA: 0x6F8E1E0
        public void GetAverageVelocities(){} // RVA: 0x6F8E2E0
    }

    public class SteamVR_HistoryStep : Object
    {
        public object position;
        public object rotation;
        public object velocity;
        public object angularVelocity;
        public object timeInTicks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F8E5B0
    }

    public class SteamVR_HistoryStep[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Input_ActionFile : Object
    {
        public object actions;
        public object action_sets;
        public object default_bindings;
        public object localization;
        public object filePath;
        public object localizationHelperList;
        public object findString_appKeyStart;
        public object findString_appKeyEnd;

        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x6F59700
        public void SaveHelperLists(){} // RVA: 0x6F59DD0
        public void GetShortName(){} // RVA: 0x6F5A610
        public void GetCodeFriendlyName(){} // RVA: 0x6F5A6B0
        public void GetFilesToCopy(){} // RVA: 0x6F5A850
        public void CopyFilesToPath(){} // RVA: 0x6F5ABE0
        public void RemoveAppKey(){} // RVA: 0x6F5AEA0
        public void Open(){} // RVA: 0x6F5B010
        public void Save(){} // RVA: 0x6F5B110
        public void .ctor(){} // RVA: 0x6F5B2E0
    }

    public class SteamVR_Input_ActionFile_Action : Object
    {
        public object _requirementValues;
        public object name;
        public object type;
        public object scope;
        public object skeleton;
        public object requirement;
        public object nameTemplate;
        public object prefix;

        // ── Methods ──
        public void get_requirementValues(){} // RVA: 0x6F5C090
        public void GetCopy(){} // RVA: 0x6F5C250
        public void get_requirementEnum(){} // RVA: 0x6F5C440
        public void set_requirementEnum(){} // RVA: 0x6F5C590
        public void get_codeFriendlyName(){} // RVA: 0x6F5B9D0
        public void get_shortName(){} // RVA: 0x6F5C640
        public void get_path(){} // RVA: 0x6F5C650
        public void CreateNewName(){} // RVA: 0x6F5C780
        public void CreateNew(){} // RVA: 0x6F5C870
        public void get_direction(){} // RVA: 0x6F5CA80
        public void get_actionSet(){} // RVA: 0x6F5CB40
        public void SetNewActionSet(){} // RVA: 0x6F5CBE0
        public void ToString(){} // RVA: 0x6F5C640
        public void Equals(){} // RVA: 0x6F5CDE0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ActionFile_ActionSet : Object
    {
        public object actionSetInstancePrefix;
        public object name;
        public object usage;
        public object nameTemplate;
        public object actionsInList;
        public object actionsOutList;
        public object actionsList;

        // ── Methods ──
        public void get_codeFriendlyName(){} // RVA: 0x6F5B9D0
        public void get_shortName(){} // RVA: 0x6F5B9E0
        public void SetNewShortName(){} // RVA: 0x6F5BAC0
        public void CreateNewName(){} // RVA: 0x6F5BB30
        public void GetPathFromName(){} // RVA: 0x6F5BB70
        public void CreateNew(){} // RVA: 0x6F5BC00
        public void GetCopy(){} // RVA: 0x6F5BCD0
        public void Equals(){} // RVA: 0x6F5BDE0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0x6F5BEE0
    }

    public class SteamVR_Input_ActionFile_ActionSet_Usages : Object
    {
        public object leftright;
        public object single;
        public object hidden;
        public object leftrightDescription;
        public object singleDescription;
        public object hiddenDescription;
        public object listValues;
        public object listDescriptions;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6F5E7F0
    }

    public class SteamVR_Input_ActionFile_ActionTypes : Object
    {
        public object boolean;
        public object vector1;
        public object vector2;
        public object vector3;
        public object vibration;
        public object pose;
        public object skeleton;
        public object skeletonLeftPath;
        public object skeletonRightPath;
        public object listAll;
        public object listIn;
        public object listOut;
        public object listSkeletons;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x6F5DF10
    }

    public class SteamVR_Input_ActionFile_DefaultBinding : Object
    {
        public object controller_type;
        public object binding_url;

        // ── Methods ──
        public void GetCopy(){} // RVA: 0x6F5B8D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ActionFile_LocalizationItem : Object
    {
        public object languageTagKeyName;
        public object language;
        public object items;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5D0E0
    }

    public class SteamVR_Input_ActionSet_Action_Menu : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Axis(){} // RVA: 0x6F285A0
        public void get_Select(){} // RVA: 0x6F285B0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x6F285C0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x6F285D0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x6F285E0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x6F285F0
        public void get_Gesture_Activator_Index(){} // RVA: 0x6F28600
        public void get_Gesture_Activator_Grip(){} // RVA: 0x6F28610
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x6F28620
        public void get_Gesture_Grip_Axis(){} // RVA: 0x6F28630
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x6F28640
        public void get_Gesture_Wheel_Left(){} // RVA: 0x6F28650
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x6F28660
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x6F28670
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x6F28680
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x6F28690
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x6F286A0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x6F286B0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x6F286C0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x6F286D0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x6F286E0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x6F286F0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x6F28700
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x6F28710
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x6F28720
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x6F28730
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x6F28740
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x6F28750
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x6F28760
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x6F28770
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x6F28780
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x6F28790
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x6F287A0
        public void get_Reserve_bool(){} // RVA: 0x6F287B0
        public void get_Reserve_vector1(){} // RVA: 0x6F287C0
        public void get_Reserve_vector2(){} // RVA: 0x6F287D0
        public void get_Grab(){} // RVA: 0x6F287E0
        public void get_Drop(){} // RVA: 0x6F287F0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ActionSet_Drone : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Left_Joystick(){} // RVA: 0x6F28800
        public void get_Right_Joystick(){} // RVA: 0x6F28810
        public void get_Self_Leveling_Mod(){} // RVA: 0x6F28820
        public void get_Hold_Altitude_Mod(){} // RVA: 0x6F28830
        public void get_Toggle_FPV(){} // RVA: 0x6F28840
        public void get_Flip(){} // RVA: 0x6F28850
        public void get_Take_Picture(){} // RVA: 0x6F28860
        public void get_Cycle_Flight_Preset(){} // RVA: 0x6F28870
        public void get_Toggle_Self_Leveling(){} // RVA: 0x6F28880
        public void get_Respawn(){} // RVA: 0x6F28890
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x6F288A0
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x6F288B0
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x6F288C0
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x6F288D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ActionSet_Global : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Safe_Mode(){} // RVA: 0x6F288E0
        public void get_Pose(){} // RVA: 0x6F288F0
        public void get_SkeletonLeftHand(){} // RVA: 0x6F28900
        public void get_SkeletonRightHand(){} // RVA: 0x6F28910
        public void get_HeadsetOnHead(){} // RVA: 0x6F28920
        public void get_Menu(){} // RVA: 0x6F28930
        public void get_Quick_Menu(){} // RVA: 0x6F28940
        public void get_Action_Menu(){} // RVA: 0x6F28950
        public void get_Main_Menu(){} // RVA: 0x6F28960
        public void get_Interact(){} // RVA: 0x6F28970
        public void get_Grab(){} // RVA: 0x6F28980
        public void get_Move(){} // RVA: 0x6F28990
        public void get_Jump(){} // RVA: 0x6F289A0
        public void get_Rotate(){} // RVA: 0x6F289B0
        public void get_Mic(){} // RVA: 0x6F289C0
        public void get_Gesture_Toggle(){} // RVA: 0x6F289D0
        public void get_Stick_Click(){} // RVA: 0x6F289E0
        public void get_Trigger_Axis(){} // RVA: 0x6F289F0
        public void get_Grip_Axis(){} // RVA: 0x6F28A00
        public void get_Udon_Menu(){} // RVA: 0x6F28A10
        public void get_Drop(){} // RVA: 0x6F28A20
        public void get_Nameplates(){} // RVA: 0x6F28A30
        public void get_HUD(){} // RVA: 0x6F28A40
        public void get_Chatbox(){} // RVA: 0x6F28A50
        public void get_Face_Mirror(){} // RVA: 0x6F28A60
        public void get_Personal_Mirror(){} // RVA: 0x6F28A70
        public void get_Personal_Mirror_Lock(){} // RVA: 0x6F28A80
        public void get_Earmuffs(){} // RVA: 0x6F28A90
        public void get_Camera(){} // RVA: 0x6F28AA0
        public void get_Stream_Camera(){} // RVA: 0x6F28AB0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x6F28AC0
        public void get_OSC_Debug_Screen(){} // RVA: 0x6F28AD0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x6F28AE0
        public void get_Start_Move(){} // RVA: 0x6F28AF0
        public void get_Start_Rotate(){} // RVA: 0x6F28B00
        public void get_Continue_Move(){} // RVA: 0x6F28B10
        public void get_Continue_Rotate(){} // RVA: 0x6F28B20
        public void get_No_Gesture_After_Move(){} // RVA: 0x6F28B30
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x6F28B40
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x6F28B50
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x6F28B60
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x6F28B70
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x6F28B80
        public void get_Gesture_Activator_Index(){} // RVA: 0x6F28B90
        public void get_Gesture_Activator_Grip(){} // RVA: 0x6F28BA0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x6F28BB0
        public void get_Gesture_Grip_Axis(){} // RVA: 0x6F28BC0
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x6F28BD0
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x6F28BE0
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x6F28BF0
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x6F28C00
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x6F28C10
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x6F28C20
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x6F28C30
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x6F28C40
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x6F28C50
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x6F28C60
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x6F28C70
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x6F28C80
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x6F28C90
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x6F28CA0
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x6F28CB0
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x6F28CC0
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x6F28CD0
        public void get_Gesture_Wheel_Left(){} // RVA: 0x6F28CE0
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x6F28CF0
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x6F28D00
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x6F28D10
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x6F28D20
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x6F28D30
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x6F28D40
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x6F28D50
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x6F28D60
        public void get_Gesture_Wheel_Right(){} // RVA: 0x6F28D70
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x6F28D80
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x6F28D90
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x6F28DA0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x6F28DB0
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x6F28DC0
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x6F28DD0
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x6F28DE0
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x6F28DF0
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x6F28E00
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x6F28E10
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x6F28E20
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x6F28E30
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x6F28E40
        public void get_Physbone_Grab_Left(){} // RVA: 0x6F28E50
        public void get_Physbone_Freeze_Left(){} // RVA: 0x6F28E60
        public void get_Physbone_Grab_Right(){} // RVA: 0x6F28E70
        public void get_Physbone_Freeze_Right(){} // RVA: 0x6F28E80
        public void get_Scroll(){} // RVA: 0x6F28E90
        public void get_Haptic(){} // RVA: 0x6F28EA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ActionSet_Menu : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Confirm(){} // RVA: 0x6F28EB0
        public void get_Back(){} // RVA: 0x6F28EC0
        public void get_Tab(){} // RVA: 0x6F28ED0
        public void get_Scroll(){} // RVA: 0x6F28EE0
        public void get_Quick_Menu_Close(){} // RVA: 0x6F28EF0
        public void get_Drag(){} // RVA: 0x6F28F00
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ActionSet_One_Hand : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Interact(){} // RVA: 0x6F28F10
        public void get_Grab(){} // RVA: 0x6F28F20
        public void get_Move_Rotate(){} // RVA: 0x6F28F30
        public void get_Jump(){} // RVA: 0x6F28F40
        public void get_Mic(){} // RVA: 0x6F28F50
        public void get_Gesture_Toggle(){} // RVA: 0x6F28F60
        public void get_Stick_Click(){} // RVA: 0x6F28F70
        public void get_Trigger_Axis(){} // RVA: 0x6F28F80
        public void get_Grip_Axis(){} // RVA: 0x6F28F90
        public void get_Udon_Menu(){} // RVA: 0x6F28FA0
        public void get_Drop(){} // RVA: 0x6F28FB0
        public void get_Start_Move_Rotate(){} // RVA: 0x6F28FC0
        public void get_Continue_Move_Rotate(){} // RVA: 0x6F28FD0
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x6F28FE0
        public void get_Menu(){} // RVA: 0x6F28FF0
        public void get_Nameplates(){} // RVA: 0x6F29000
        public void get_HUD(){} // RVA: 0x6F29010
        public void get_Chatbox(){} // RVA: 0x6F29020
        public void get_Face_Mirror(){} // RVA: 0x6F29030
        public void get_Personal_Mirror(){} // RVA: 0x6F29040
        public void get_Personal_Mirror_Lock(){} // RVA: 0x6F29050
        public void get_Earmuffs(){} // RVA: 0x6F29060
        public void get_Camera(){} // RVA: 0x6F29070
        public void get_Stream_Camera(){} // RVA: 0x6F29080
        public void get_Avatar_Debug_Screen(){} // RVA: 0x6F29090
        public void get_OSC_Debug_Screen(){} // RVA: 0x6F290A0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x6F290B0
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x6F290C0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x6F290D0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x6F290E0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x6F290F0
        public void get_Gesture_Activator_Index(){} // RVA: 0x6F29100
        public void get_Gesture_Activator_Grip(){} // RVA: 0x6F29110
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x6F29120
        public void get_Gesture_Grip_Axis(){} // RVA: 0x6F29130
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x6F29140
        public void get_Gesture_Wheel_Left(){} // RVA: 0x6F29150
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x6F29160
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x6F29170
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x6F29180
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x6F29190
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x6F291A0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x6F291B0
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x6F291C0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x6F291D0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x6F291E0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x6F291F0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x6F29200
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x6F29210
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x6F29220
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x6F29230
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x6F29240
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x6F29250
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x6F29260
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x6F29270
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x6F29280
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x6F29290
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x6F292A0
        public void get_Reserve_bool(){} // RVA: 0x6F292B0
        public void get_Reserve_vector1(){} // RVA: 0x6F292C0
        public void get_Reserve_vector2(){} // RVA: 0x6F292D0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_BindingFile : Object
    {
        public object app_key;
        public object bindings;
        public object controller_type;
        public object description;
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5ED00
    }

    public class SteamVR_Input_BindingFile_ActionList : Object
    {
        public object chords;
        public object poses;
        public object haptics;
        public object sources;
        public object skeleton;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5EDC0
    }

    public class SteamVR_Input_BindingFile_Chord : Object
    {
        public object output;
        public object inputs;

        // ── Methods ──
        public void Equals(){} // RVA: 0x6F5F0E0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0x6F5F410
    }

    public class SteamVR_Input_BindingFile_Haptic : Object
    {
        public object output;
        public object path;

        // ── Methods ──
        public void Equals(){} // RVA: 0x6F5F620
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_BindingFile_Pose : Object
    {
        public object output;
        public object path;

        // ── Methods ──
        public void Equals(){} // RVA: 0x6F5F4D0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_BindingFile_Skeleton : Object
    {
        public object output;
        public object path;

        // ── Methods ──
        public void Equals(){} // RVA: 0x6F5F770
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_BindingFile_Source : Object
    {
        public object path;
        public object mode;
        public object parameters;
        public object inputs;
        public object outputKeyName;

        // ── Methods ──
        public void GetOutput(){} // RVA: 0x6F5F8C0
        public void Equals(){} // RVA: 0x6F5FC70
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0x6F5FE60
    }

    public class SteamVR_Input_BindingFile_Source_Input : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x6F5FFE0
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0x6F602E0
    }

    public class SteamVR_Input_BindingFile_Source_Input_StringDictionary : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x6F60320
        public void GetHashCode(){} // RVA: 0x66DC010
        public void .ctor(){} // RVA: 0x6F60460
    }

    public class SteamVR_Input_Generator_Names : Object
    {
        public object fullActionsClassName;
        public object actionsClassName;
        public object preinitializeMethodName;
        public object actionsFieldName;
        public object actionsInFieldName;
        public object actionsOutFieldName;
        public object actionsVibrationFieldName;
        public object actionsPoseFieldName;
        public object actionsBooleanFieldName;
        public object actionsSingleFieldName;
        public object actionsVector2FieldName;
        public object actionsVector3FieldName;
        public object actionsSkeletonFieldName;
        public object actionsNonPoseNonSkeletonIn;
        public object actionSetsFieldName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ManifestFile : Object
    {
        public object source;
        public object applications;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ManifestFile_Application : Object
    {
        public object app_key;
        public object launch_type;
        public object url;
        public object binary_path_windows;
        public object binary_path_linux;
        public object binary_path_osx;
        public object action_manifest_path;
        public object image_path;
        public object strings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5D4B0
    }

    public class SteamVR_Input_ManifestFile_ApplicationString : Object
    {
        public object name;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding : Object
    {
        public object controller_type;
        public object binding_url;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding_ControllerTypes : Object
    {
        public object oculus_touch;
        public object vive_controller;
        public object knuckles;
        public object holographic_controller;
        public object vive;
        public object vive_pro;
        public object holographic_hmd;
        public object rift;
        public object vive_tracker_camera;
        public object vive_cosmos;
        public object vive_cosmos_controller;
        public object index_hmd;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6F5D8D0
    }

    public class SteamVR_Input_Source : Object
    {
        public object numSources;
        public object inputSourceHandlesBySource;
        public object inputSourceSourcesByHandle;
        public object enumType;
        public object descriptionType;
        public object allSources;

        // ── Methods ──
        public void GetHandle(){} // RVA: 0x6F604A0
        public void GetSource(){} // RVA: 0x6F60550
        public void GetAllSources(){} // RVA: 0x6F606E0
        public void GetPath(){} // RVA: 0x6F60960
        public void Initialize(){} // RVA: 0x6F60AA0
        public void .cctor(){} // RVA: 0x6F61300
    }

    public class SteamVR_Input_Sources_Comparer : ValueType
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x8FD3E0
        public void GetHashCode(){} // RVA: 0x8FD3F0
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition : Object
    {
        public object name;
        public object references;
        public object optionalUnityReferences;
        public object includePlatforms;
        public object excludePlatforms;
        public object allowUnsafeCode;
        public object overrideReferences;
        public object precompiledReferences;
        public object autoReferenced;
        public object defineConstraints;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F5D570
    }

    public class SteamVR_RingBuffer`1 : Object
    {
        public object UseDateTimeForTicks;
        public object buffer;
        public object currentIndex;
        public object lastElement;
        public object cleared;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8944F0
        public void Add(){} // RVA: 0xA94080
        public void StepForward(){} // RVA: 0x894290
        public void GetAtIndex(){} // RVA: 0xA94080
        public void GetLast(){} // RVA: 0xA94080
        public void GetLastIndex(){} // RVA: 0x87C130
        public void Clear(){} // RVA: 0x894290
    }

    public class SteamVR_RingBuffer`1 : Object
    {
        public object UseDateTimeForTicks;
        public object buffer;
        public object currentIndex;
        public object lastElement;
        public object cleared;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B54750
        public void Add(){} // RVA: 0x4B547F0
        public void StepForward(){} // RVA: 0x4B54830
        public void GetAtIndex(){} // RVA: 0x4B548E0
        public void GetLast(){} // RVA: 0xB700F0
        public void GetLastIndex(){} // RVA: 0x4B54920
        public void Clear(){} // RVA: 0x4B54950
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists : Object
    {
        public object _enumList;
        public object _stringList;

        // ── Methods ──
        public void get_enumList(){} // RVA: 0x6F61900
        public void get_stringList(){} // RVA: 0x6F61AF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Skeleton_FingerIndexEnum[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Skeleton_FingerIndexes : Object
    {
        public object thumb;
        public object index;
        public object middle;
        public object ring;
        public object pinky;
        public object enumArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6F27140
    }

    public class SteamVR_Skeleton_FingerSplayIndexEnum[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB23C0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8440
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6D5F0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class SteamVR_Skeleton_FingerSplayIndexes : Object
    {
        public object thumbIndex;
        public object indexMiddle;
        public object middleRing;
        public object ringPinky;
        public object enumArray;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6F27340
    }

    public class SteamVR_Skeleton_HandMask : Object
    {
        public object palm;
        public object thumb;
        public object index;
        public object middle;
        public object ring;
        public object pinky;
        public object values;
        public object fullMask;

        // ── Methods ──
        public void SetFinger(){} // RVA: 0x6F65910
        public void GetFinger(){} // RVA: 0x6F65950
        public void .ctor(){} // RVA: 0x6F65980
        public void Reset(){} // RVA: 0x6F65B40
        public void Apply(){} // RVA: 0x6F65C00
        public void .cctor(){} // RVA: 0x6F65CC0
    }

    public class SteamVR_Skeleton_JointIndexes : Object
    {
        public object root;
        public object wrist;
        public object thumbMetacarpal;
        public object thumbProximal;
        public object thumbMiddle;
        public object thumbDistal;
        public object thumbTip;
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
        public object ringMetacarpal;
        public object ringProximal;
        public object ringMiddle;
        public object ringDistal;
        public object ringTip;
        public object pinkyMetacarpal;
        public object pinkyProximal;
        public object pinkyMiddle;
        public object pinkyDistal;
        public object pinkyTip;
        public object thumbAux;
        public object indexAux;
        public object middleAux;
        public object ringAux;
        public object pinkyAux;

        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x6F27080
        public void GetBoneForFingerTip(){} // RVA: 0x6F27100
    }

    public class SteamVR_TrackedCamera : Object
    {
        public object distorted;
        public object undistorted;
        public object videostreams;

        // ── Methods ──
        public void Distorted(){} // RVA: 0x6F8FB80
        public void Undistorted(){} // RVA: 0x6F8FD20
        public void Source(){} // RVA: 0x6F8FED0
        public void Stream(){} // RVA: 0x6F90210
        public void .ctor(){} // RVA: 0xB43310
    }

}