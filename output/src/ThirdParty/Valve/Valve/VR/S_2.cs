// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 88
// Methods: 1267

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_ActionSet_Data : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE292B20
        public void get_allActions(){} // RVA: 0x7A80F2570
        public void set_allActions(){} // RVA: 0x7A80D8E20
        public void get_nonVisualInActions(){} // RVA: 0x7A80DA7B0
        public void set_nonVisualInActions(){} // RVA: 0x7A813E420
        public void get_visualActions(){} // RVA: 0x7A81052C0
        public void set_visualActions(){} // RVA: 0x7A81052D0
        public void get_poseActions(){} // RVA: 0x7A8105330
        public void set_poseActions(){} // RVA: 0x7A80D8E80
        public void get_skeletonActions(){} // RVA: 0x7A83F69F0
        public void set_skeletonActions(){} // RVA: 0x7A8105A90
        public void get_outActionArray(){} // RVA: 0x7A8292C30
        public void set_outActionArray(){} // RVA: 0x7A8296DE0
        public void get_fullPath(){} // RVA: 0x7A8154D80
        public void set_fullPath(){} // RVA: 0x7A80FF440
        public void get_usage(){} // RVA: 0x7A8152D80
        public void set_usage(){} // RVA: 0x7A8152D90
        public void get_handle(){} // RVA: 0x7A8178B90
        public void set_handle(){} // RVA: 0x7A82C1E60
        public void PreInitialize(){} // RVA: 0x7A80D7310
        public void FinishPreInitialize(){} // RVA: 0x7AE292D00
        public void Initialize(){} // RVA: 0x7AE293750
        public void IsActive(){} // RVA: 0x7AE293940
        public void GetTimeLastChanged(){} // RVA: 0x7AE293990
        public void Activate(){} // RVA: 0x7AE2939D0
        public void Deactivate(){} // RVA: 0x7AE293B70
        public void GetShortName(){} // RVA: 0x7AE293C80
        public void ReadRawSetActive(){} // RVA: 0x7AE293D00
        public void ReadRawSetLastChanged(){} // RVA: 0x7AE293D30
        public void ReadRawSetPriority(){} // RVA: 0x7AE293D60
    }

    public class SteamVR_ActionSet_Manager : Object
    {
        // ── Methods ──
        public void get_rawActiveActionSetArray(){} // RVA: 0x7AE293D90
        public void Initialize(){} // RVA: 0x7AE293E10
        public void DisableAllActionSets(){} // RVA: 0x7AE293FC0
        public void UpdateActionStates(){} // RVA: 0x7AE294110
        public void SetChanged(){} // RVA: 0x7AE294430
        public void GetNewArraySize(){} // RVA: 0x7AE294470
        public void UpdateActionSetsArray(){} // RVA: 0x7AE2945D0
        public void GetSetFromHandle(){} // RVA: 0x7AE294B50
        public void UpdateDebugText(){} // RVA: 0x7AE294C70
    }

    public class SteamVR_Action[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Action_Boolean : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7AE295150
        public void remove_onChange(){} // RVA: 0x7AE2951D0
        public void add_onUpdate(){} // RVA: 0x7AE295250
        public void remove_onUpdate(){} // RVA: 0x7AE2952D0
        public void add_onState(){} // RVA: 0x7AE295350
        public void remove_onState(){} // RVA: 0x7AE2953D0
        public void add_onStateDown(){} // RVA: 0x7AE295450
        public void remove_onStateDown(){} // RVA: 0x7AE2954D0
        public void add_onStateUp(){} // RVA: 0x7AE295550
        public void remove_onStateUp(){} // RVA: 0x7AE2955D0
        public void add_onActiveChange(){} // RVA: 0x7AE295650
        public void remove_onActiveChange(){} // RVA: 0x7AE2956D0
        public void add_onActiveBindingChange(){} // RVA: 0x7AE295750
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2957D0
        public void get_state(){} // RVA: 0x7AE295850
        public void get_stateDown(){} // RVA: 0x7AE2958E0
        public void get_stateUp(){} // RVA: 0x7AE295970
        public void get_lastState(){} // RVA: 0x7AE295A00
        public void get_lastStateDown(){} // RVA: 0x7AE295A60
        public void get_lastStateUp(){} // RVA: 0x7AE295AE0
        public void .ctor(){} // RVA: 0x7AE295B60
        public void GetStateDown(){} // RVA: 0x7AE295BA0
        public void GetStateUp(){} // RVA: 0x7AE295C40
        public void GetState(){} // RVA: 0x7AE295CE0
        public void GetLastStateDown(){} // RVA: 0x7AE295D80
        public void GetLastStateUp(){} // RVA: 0x7AE295E10
        public void GetLastState(){} // RVA: 0x7AE295EA0
        public void AddOnActiveChangeListener(){} // RVA: 0x7AE295F10
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7AE295F90
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7AE296010
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7AE296090
        public void AddOnChangeListener(){} // RVA: 0x7AE296110
        public void RemoveOnChangeListener(){} // RVA: 0x7AE296190
        public void AddOnUpdateListener(){} // RVA: 0x7AE296210
        public void RemoveOnUpdateListener(){} // RVA: 0x7AE296290
        public void AddOnStateDownListener(){} // RVA: 0x7AE296310
        public void RemoveOnStateDownListener(){} // RVA: 0x7AE296390
        public void AddOnStateUpListener(){} // RVA: 0x7AE296410
        public void RemoveOnStateUpListener(){} // RVA: 0x7AE296490
        public void RemoveAllListeners(){} // RVA: 0x7AE296510
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AE296580
    }

    public class SteamVR_Action_Boolean_Source : SteamVR_Action_In_Source
    {
        // ── Methods ──
        public void add_onStateDown(){} // RVA: 0x7AE2969C0
        public void remove_onStateDown(){} // RVA: 0x7AE296AC0
        public void add_onStateUp(){} // RVA: 0x7AE296BC0
        public void remove_onStateUp(){} // RVA: 0x7AE296CC0
        public void add_onState(){} // RVA: 0x7AE296DC0
        public void remove_onState(){} // RVA: 0x7AE296EC0
        public void add_onActiveChange(){} // RVA: 0x7AE296FC0
        public void remove_onActiveChange(){} // RVA: 0x7AE2970C0
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2971C0
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2972C0
        public void add_onChange(){} // RVA: 0x7AE2973C0
        public void remove_onChange(){} // RVA: 0x7AE2974C0
        public void add_onUpdate(){} // RVA: 0x7AE2975C0
        public void remove_onUpdate(){} // RVA: 0x7AE2976C0
        public void get_state(){} // RVA: 0x7AE2977C0
        public void get_stateDown(){} // RVA: 0x7AE297800
        public void get_stateUp(){} // RVA: 0x7AE297840
        public void get_changed(){} // RVA: 0x7AE297880
        public void set_changed(){} // RVA: 0x7A80D7310
        public void get_lastState(){} // RVA: 0x7AE2978C0
        public void get_lastStateDown(){} // RVA: 0x7AE2978D0
        public void get_lastStateUp(){} // RVA: 0x7AE2978F0
        public void get_lastChanged(){} // RVA: 0x7AE297910
        public void set_lastChanged(){} // RVA: 0x7A80D7310
        public void get_activeOrigin(){} // RVA: 0x7AE297920
        public void get_lastActiveOrigin(){} // RVA: 0x7A8B772D0
        public void get_active(){} // RVA: 0x7AE297960
        public void get_activeBinding(){} // RVA: 0x7AE194410
        public void get_lastActive(){} // RVA: 0x7AE297A00
        public void set_lastActive(){} // RVA: 0x7AE297A10
        public void get_lastActiveBinding(){} // RVA: 0x7AE297A20
        public void Preinitialize(){} // RVA: 0x7AE297A30
        public void Initialize(){} // RVA: 0x7AE297BC0
        public void RemoveAllListeners(){} // RVA: 0x7AE297CA0
        public void UpdateValue(){} // RVA: 0x7AE298050
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Action_Boolean_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Action_Boolean_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE296980
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7ABE82A70
        public void IsUpdating(){} // RVA: 0x7ABE82770
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE828C0
        public void OnAccessSource(){} // RVA: 0x7ABE82830
        public void .ctor(){} // RVA: 0x7ABE82B60
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7ABE82A70
        public void IsUpdating(){} // RVA: 0x7ABE82770
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE828C0
        public void OnAccessSource(){} // RVA: 0x7ABE82830
        public void .ctor(){} // RVA: 0x7ABE82B60
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7ABE82A70
        public void IsUpdating(){} // RVA: 0x7ABE82770
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE828C0
        public void OnAccessSource(){} // RVA: 0x7ABE82830
        public void .ctor(){} // RVA: 0x7ABE82B60
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7ABE82A70
        public void IsUpdating(){} // RVA: 0x7ABE82770
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE828C0
        public void OnAccessSource(){} // RVA: 0x7ABE82830
        public void .ctor(){} // RVA: 0x7ABE82B60
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7ABE82C40
        public void get_lastChanged(){} // RVA: 0x7ABE82C40
        public void get_changedTime(){} // RVA: 0x7ABE82C90
        public void get_updateTime(){} // RVA: 0x7ABE82CD0
        public void get_activeOrigin(){} // RVA: 0x7ABE82D10
        public void get_lastActiveOrigin(){} // RVA: 0x7ABE82D60
        public void get_activeDevice(){} // RVA: 0x7ABE82DB0
        public void get_trackedDeviceIndex(){} // RVA: 0x7ABE82E40
        public void get_renderModelComponentName(){} // RVA: 0x7ABE82E90
        public void get_localizedOriginName(){} // RVA: 0x7ABE82EE0
        public void UpdateValues(){} // RVA: 0x7ABE82F30
        public void GetRenderModelComponentName(){} // RVA: 0x7ABE83020
        public void GetActiveDevice(){} // RVA: 0x7ABE83070
        public void GetDeviceIndex(){} // RVA: 0x7ABE83100
        public void GetChanged(){} // RVA: 0x7ABE83150
        public void GetTimeLastChanged(){} // RVA: 0x7ABE831A0
        public void GetLocalizedOriginPart(){} // RVA: 0x7ABE831E0
        public void GetLocalizedOrigin(){} // RVA: 0x7ABE83230
        public void IsUpdating(){} // RVA: 0x7ABE83270
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE83330
        public void GetControllerType(){} // RVA: 0x7ABE83360
        public void .ctor(){} // RVA: 0x7ABE83400
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7ABE82C40
        public void get_lastChanged(){} // RVA: 0x7ABE82C40
        public void get_changedTime(){} // RVA: 0x7ABE82C90
        public void get_updateTime(){} // RVA: 0x7ABE82CD0
        public void get_activeOrigin(){} // RVA: 0x7ABE82D10
        public void get_lastActiveOrigin(){} // RVA: 0x7ABE82D60
        public void get_activeDevice(){} // RVA: 0x7ABE82DB0
        public void get_trackedDeviceIndex(){} // RVA: 0x7ABE82E40
        public void get_renderModelComponentName(){} // RVA: 0x7ABE82E90
        public void get_localizedOriginName(){} // RVA: 0x7ABE82EE0
        public void UpdateValues(){} // RVA: 0x7ABE82F30
        public void GetRenderModelComponentName(){} // RVA: 0x7ABE83020
        public void GetActiveDevice(){} // RVA: 0x7ABE83070
        public void GetDeviceIndex(){} // RVA: 0x7ABE83100
        public void GetChanged(){} // RVA: 0x7ABE83150
        public void GetTimeLastChanged(){} // RVA: 0x7ABE831A0
        public void GetLocalizedOriginPart(){} // RVA: 0x7ABE831E0
        public void GetLocalizedOrigin(){} // RVA: 0x7ABE83230
        public void IsUpdating(){} // RVA: 0x7ABE83270
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE83330
        public void GetControllerType(){} // RVA: 0x7ABE83360
        public void .ctor(){} // RVA: 0x7ABE83400
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7ABE82C40
        public void get_lastChanged(){} // RVA: 0x7ABE82C40
        public void get_changedTime(){} // RVA: 0x7ABE82C90
        public void get_updateTime(){} // RVA: 0x7ABE82CD0
        public void get_activeOrigin(){} // RVA: 0x7ABE82D10
        public void get_lastActiveOrigin(){} // RVA: 0x7ABE82D60
        public void get_activeDevice(){} // RVA: 0x7ABE82DB0
        public void get_trackedDeviceIndex(){} // RVA: 0x7ABE82E40
        public void get_renderModelComponentName(){} // RVA: 0x7ABE82E90
        public void get_localizedOriginName(){} // RVA: 0x7ABE82EE0
        public void UpdateValues(){} // RVA: 0x7ABE82F30
        public void GetRenderModelComponentName(){} // RVA: 0x7ABE83020
        public void GetActiveDevice(){} // RVA: 0x7ABE83070
        public void GetDeviceIndex(){} // RVA: 0x7ABE83100
        public void GetChanged(){} // RVA: 0x7ABE83150
        public void GetTimeLastChanged(){} // RVA: 0x7ABE831A0
        public void GetLocalizedOriginPart(){} // RVA: 0x7ABE831E0
        public void GetLocalizedOrigin(){} // RVA: 0x7ABE83230
        public void IsUpdating(){} // RVA: 0x7ABE83270
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE83330
        public void GetControllerType(){} // RVA: 0x7ABE83360
        public void .ctor(){} // RVA: 0x7ABE83400
    }

    public class SteamVR_Action_In`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7ABE82C40
        public void get_lastChanged(){} // RVA: 0x7ABE82C40
        public void get_changedTime(){} // RVA: 0x7ABE82C90
        public void get_updateTime(){} // RVA: 0x7ABE82CD0
        public void get_activeOrigin(){} // RVA: 0x7ABE82D10
        public void get_lastActiveOrigin(){} // RVA: 0x7ABE82D60
        public void get_activeDevice(){} // RVA: 0x7ABE82DB0
        public void get_trackedDeviceIndex(){} // RVA: 0x7ABE82E40
        public void get_renderModelComponentName(){} // RVA: 0x7ABE82E90
        public void get_localizedOriginName(){} // RVA: 0x7ABE82EE0
        public void UpdateValues(){} // RVA: 0x7ABE82F30
        public void GetRenderModelComponentName(){} // RVA: 0x7ABE83020
        public void GetActiveDevice(){} // RVA: 0x7ABE83070
        public void GetDeviceIndex(){} // RVA: 0x7ABE83100
        public void GetChanged(){} // RVA: 0x7ABE83150
        public void GetTimeLastChanged(){} // RVA: 0x7ABE831A0
        public void GetLocalizedOriginPart(){} // RVA: 0x7ABE831E0
        public void GetLocalizedOrigin(){} // RVA: 0x7ABE83230
        public void IsUpdating(){} // RVA: 0x7ABE83270
        public void ForceAddSourceToUpdateList(){} // RVA: 0x7ABE83330
        public void GetControllerType(){} // RVA: 0x7ABE83360
        public void .ctor(){} // RVA: 0x7ABE83400
    }

    public class SteamVR_Action_Out_Source : SteamVR_Action_Source
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Action_Out`2 : SteamVR_Action`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABE83480
    }

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7AE298F70
        public void remove_onActiveChange(){} // RVA: 0x7AE298FF0
        public void add_onActiveBindingChange(){} // RVA: 0x7AE299070
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2991C0
        public void add_onChange(){} // RVA: 0x7AE299240
        public void remove_onChange(){} // RVA: 0x7AE2992C0
        public void add_onUpdate(){} // RVA: 0x7AE299340
        public void remove_onUpdate(){} // RVA: 0x7AE2993C0
        public void add_onTrackingChanged(){} // RVA: 0x7AE299440
        public void remove_onTrackingChanged(){} // RVA: 0x7AE2994C0
        public void add_onValidPoseChanged(){} // RVA: 0x7AE299540
        public void remove_onValidPoseChanged(){} // RVA: 0x7AE2995C0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x7AE299640
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x7AE2996C0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x7AE299740
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x7AE2997C0
        public void AddOnTrackingChanged(){} // RVA: 0x7AE299840
        public void RemoveOnTrackingChanged(){} // RVA: 0x7AE2998C0
        public void AddOnValidPoseChanged(){} // RVA: 0x7AE299940
        public void RemoveOnValidPoseChanged(){} // RVA: 0x7AE2999C0
        public void AddOnActiveChangeListener(){} // RVA: 0x7AE299A40
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7AE299AC0
        public void AddOnChangeListener(){} // RVA: 0x7AE299B40
        public void RemoveOnChangeListener(){} // RVA: 0x7AE299BC0
        public void AddOnUpdateListener(){} // RVA: 0x7AE299C40
        public void RemoveOnUpdateListener(){} // RVA: 0x7AE299CC0
        public void RemoveAllListeners(){} // RVA: 0x7AE299D40
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AE299DC0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7AE299E00
        public void .ctor(){} // RVA: 0x7AE299E80
    }

    public class SteamVR_Action_Pose[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x7ABE83500
        public void get_localPosition(){} // RVA: 0x7ABE836D0
        public void get_localRotation(){} // RVA: 0x7ABE83720
        public void get_trackingState(){} // RVA: 0x7ABE83770
        public void get_velocity(){} // RVA: 0x7ABE837B0
        public void get_angularVelocity(){} // RVA: 0x7ABE83800
        public void get_poseIsValid(){} // RVA: 0x7ABE83850
        public void get_deviceIsConnected(){} // RVA: 0x7ABE83890
        public void get_lastLocalPosition(){} // RVA: 0x7ABE838D0
        public void get_lastLocalRotation(){} // RVA: 0x7ABE83920
        public void get_lastTrackingState(){} // RVA: 0x7ABE83970
        public void get_lastVelocity(){} // RVA: 0x7ABE839B0
        public void get_lastAngularVelocity(){} // RVA: 0x7ABE83A00
        public void get_lastPoseIsValid(){} // RVA: 0x7ABE83A50
        public void get_lastDeviceIsConnected(){} // RVA: 0x7ABE83A90
        public void .ctor(){} // RVA: 0x7ABE83AD0
        public void UpdateValues(){} // RVA: 0x7ABE83AF0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x7ABE83B20
        public void GetPoseAtTimeOffset(){} // RVA: 0x7ABE83B80
        public void UpdateTransform(){} // RVA: 0x7ABE83C00
        public void GetLocalPosition(){} // RVA: 0x7ABE83D10
        public void GetLocalRotation(){} // RVA: 0x7ABE83D70
        public void GetVelocity(){} // RVA: 0x7ABE83DC0
        public void GetAngularVelocity(){} // RVA: 0x7ABE83E20
        public void GetDeviceIsConnected(){} // RVA: 0x7ABE83E80
        public void GetPoseIsValid(){} // RVA: 0x7ABE83EC0
        public void GetTrackingResult(){} // RVA: 0x7ABE83F00
        public void GetLastLocalPosition(){} // RVA: 0x7ABE83F40
        public void GetLastLocalRotation(){} // RVA: 0x7ABE83FA0
        public void GetLastVelocity(){} // RVA: 0x7ABE83FF0
        public void GetLastAngularVelocity(){} // RVA: 0x7ABE84050
        public void GetLastDeviceIsConnected(){} // RVA: 0x7ABE840B0
        public void GetLastPoseIsValid(){} // RVA: 0x7ABE840F0
        public void GetLastTrackingResult(){} // RVA: 0x7ABE84130
    }

    public class SteamVR_Action_Pose_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7ABE841E0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x7ABE84170
        public void .ctor(){} // RVA: 0x7ABE842E0
    }

    public class SteamVR_Action_Skeleton[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE84300
        public void OnAccessSource(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7ABE84320
        public void PreinitializeMap(){} // RVA: 0x7ABE843B0
        public void GetSourceElementForIndexer(){} // RVA: 0x7ABE84450
        public void .ctor(){} // RVA: 0x7ABE844A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE84300
        public void OnAccessSource(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7ABE84320
        public void PreinitializeMap(){} // RVA: 0x7ABE843B0
        public void GetSourceElementForIndexer(){} // RVA: 0x7ABE84450
        public void .ctor(){} // RVA: 0x7ABE844A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE84300
        public void OnAccessSource(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7ABE84320
        public void PreinitializeMap(){} // RVA: 0x7ABE843B0
        public void GetSourceElementForIndexer(){} // RVA: 0x7ABE84450
        public void .ctor(){} // RVA: 0x7ABE844A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE84300
        public void OnAccessSource(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7ABE84320
        public void PreinitializeMap(){} // RVA: 0x7ABE843B0
        public void GetSourceElementForIndexer(){} // RVA: 0x7ABE84450
        public void .ctor(){} // RVA: 0x7ABE844A0
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE84300
        public void OnAccessSource(){} // RVA: 0x7A80D7310
        public void Initialize(){} // RVA: 0x7ABE84320
        public void PreinitializeMap(){} // RVA: 0x7ABE843B0
        public void GetSourceElementForIndexer(){} // RVA: 0x7ABE84450
        public void .ctor(){} // RVA: 0x7ABE844A0
    }

    public class SteamVR_Action_Vector2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7AE2A8690
        public void remove_onChange(){} // RVA: 0x7AE2A8710
        public void add_onUpdate(){} // RVA: 0x7AE2A8790
        public void remove_onUpdate(){} // RVA: 0x7AE2A8810
        public void add_onAxis(){} // RVA: 0x7AE2A8890
        public void remove_onAxis(){} // RVA: 0x7AE2A8910
        public void add_onActiveChange(){} // RVA: 0x7AE2A8990
        public void remove_onActiveChange(){} // RVA: 0x7AE2A8A10
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2A8A90
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2A8B10
        public void get_axis(){} // RVA: 0x7AE2A8B90
        public void get_lastAxis(){} // RVA: 0x7AE2A8C10
        public void get_delta(){} // RVA: 0x7AE2A8C90
        public void get_lastDelta(){} // RVA: 0x7AE2A8D10
        public void .ctor(){} // RVA: 0x7AE2A8D90
        public void GetAxis(){} // RVA: 0x7AE2A8DD0
        public void GetAxisDelta(){} // RVA: 0x7AE2A8E50
        public void GetLastAxis(){} // RVA: 0x7AE2A8ED0
        public void GetLastAxisDelta(){} // RVA: 0x7AE2A8F50
        public void AddOnActiveChangeListener(){} // RVA: 0x7AE2A8FD0
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7AE2A9050
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7AE2A90D0
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7AE2A9150
        public void AddOnChangeListener(){} // RVA: 0x7AE2A91D0
        public void RemoveOnChangeListener(){} // RVA: 0x7AE2A9250
        public void AddOnUpdateListener(){} // RVA: 0x7AE2A92D0
        public void RemoveOnUpdateListener(){} // RVA: 0x7AE2A9350
        public void AddOnAxisListener(){} // RVA: 0x7AE2A93D0
        public void RemoveOnAxisListener(){} // RVA: 0x7AE2A9450
        public void RemoveAllListeners(){} // RVA: 0x7AE2A94D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AE2A9540
    }

    public class SteamVR_Action_Vector2_Source : SteamVR_Action_In_Source
    {
        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7AE2BF410
        public void remove_onAxis(){} // RVA: 0x7AE2BF510
        public void add_onActiveChange(){} // RVA: 0x7AE2BF610
        public void remove_onActiveChange(){} // RVA: 0x7AE2BF710
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2BF810
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2BF910
        public void add_onChange(){} // RVA: 0x7AE2BFA10
        public void remove_onChange(){} // RVA: 0x7AE2BFB10
        public void add_onUpdate(){} // RVA: 0x7AE2BFC10
        public void remove_onUpdate(){} // RVA: 0x7AE2BFD10
        public void get_axis(){} // RVA: 0x7A929F640
        public void set_axis(){} // RVA: 0x7AE2BFE10
        public void get_lastAxis(){} // RVA: 0x7AE2BFE20
        public void set_lastAxis(){} // RVA: 0x7AE2BFE40
        public void get_delta(){} // RVA: 0x7AE2BFE50
        public void set_delta(){} // RVA: 0x7AE2BFE70
        public void get_lastDelta(){} // RVA: 0x7AE2BFE80
        public void set_lastDelta(){} // RVA: 0x7AE2BFEA0
        public void get_changed(){} // RVA: 0x7AE2BFEB0
        public void set_changed(){} // RVA: 0x7AE2BFEC0
        public void get_lastChanged(){} // RVA: 0x7AE2BFED0
        public void set_lastChanged(){} // RVA: 0x7AE2BFEE0
        public void get_activeOrigin(){} // RVA: 0x7AE2BFEF0
        public void get_lastActiveOrigin(){} // RVA: 0x7A8B7A210
        public void get_active(){} // RVA: 0x7AE297960
        public void get_activeBinding(){} // RVA: 0x7AE297A20
        public void get_lastActive(){} // RVA: 0x7AE2BFF30
        public void set_lastActive(){} // RVA: 0x7AE2BFF40
        public void get_lastActiveBinding(){} // RVA: 0x7AE2BFF50
        public void Preinitialize(){} // RVA: 0x7AE2BFF60
        public void Initialize(){} // RVA: 0x7AE2C00F0
        public void RemoveAllListeners(){} // RVA: 0x7AE2C01D0
        public void UpdateValue(){} // RVA: 0x7AE2C04E0
        public void .ctor(){} // RVA: 0x7AE2C0CA0
    }

    public class SteamVR_Action_Vector2_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2BF3D0
    }

    public class SteamVR_Action_Vector3 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x7AE2C0CF0
        public void remove_onChange(){} // RVA: 0x7AE2C0D70
        public void add_onUpdate(){} // RVA: 0x7AE2C0DF0
        public void remove_onUpdate(){} // RVA: 0x7AE2C0E70
        public void add_onAxis(){} // RVA: 0x7AE2C0EF0
        public void remove_onAxis(){} // RVA: 0x7AE2C0F70
        public void add_onActiveChange(){} // RVA: 0x7AE2C0FF0
        public void remove_onActiveChange(){} // RVA: 0x7AE2C1070
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2C10F0
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2C1170
        public void get_axis(){} // RVA: 0x7AE2C11F0
        public void get_lastAxis(){} // RVA: 0x7AE2C1270
        public void get_delta(){} // RVA: 0x7AE2C12F0
        public void get_lastDelta(){} // RVA: 0x7AE2C1370
        public void .ctor(){} // RVA: 0x7AE2C13F0
        public void GetAxis(){} // RVA: 0x7AE2C1430
        public void GetAxisDelta(){} // RVA: 0x7AE2C14C0
        public void GetLastAxis(){} // RVA: 0x7AE2C1550
        public void GetLastAxisDelta(){} // RVA: 0x7AE2C15E0
        public void AddOnActiveChangeListener(){} // RVA: 0x7AE2C1670
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7AE2C16F0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7AE2C1770
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7AE2C17F0
        public void AddOnChangeListener(){} // RVA: 0x7AE2C1870
        public void RemoveOnChangeListener(){} // RVA: 0x7AE2C18F0
        public void AddOnUpdateListener(){} // RVA: 0x7AE2C1970
        public void RemoveOnUpdateListener(){} // RVA: 0x7AE2C19F0
        public void AddOnAxisListener(){} // RVA: 0x7AE2C1A70
        public void RemoveOnAxisListener(){} // RVA: 0x7AE2C1AF0
        public void RemoveAllListeners(){} // RVA: 0x7AE2C1B70
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AE2C1BE0
    }

    public class SteamVR_Action_Vector3_Source : SteamVR_Action_In_Source
    {
        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x7AE2C1F80
        public void remove_onAxis(){} // RVA: 0x7AE2C2080
        public void add_onActiveChange(){} // RVA: 0x7AE2C2180
        public void remove_onActiveChange(){} // RVA: 0x7AE2C2280
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2C2380
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2C2480
        public void add_onChange(){} // RVA: 0x7AE2C2580
        public void remove_onChange(){} // RVA: 0x7AE2C2680
        public void add_onUpdate(){} // RVA: 0x7AE2C2780
        public void remove_onUpdate(){} // RVA: 0x7AE2C2880
        public void get_axis(){} // RVA: 0x7AE2C2980
        public void set_axis(){} // RVA: 0x7AE2C29A0
        public void get_lastAxis(){} // RVA: 0x7AE2C29C0
        public void set_lastAxis(){} // RVA: 0x7AE2C29E0
        public void get_delta(){} // RVA: 0x7AE2C2A00
        public void set_delta(){} // RVA: 0x7AE2C2A20
        public void get_lastDelta(){} // RVA: 0x7AE2C2A40
        public void set_lastDelta(){} // RVA: 0x7AE2C2A60
        public void get_changed(){} // RVA: 0x7AE194670
        public void set_changed(){} // RVA: 0x7AE194680
        public void get_lastChanged(){} // RVA: 0x7AE2C2A80
        public void set_lastChanged(){} // RVA: 0x7AE2C2A90
        public void get_activeOrigin(){} // RVA: 0x7AE2C2AA0
        public void get_lastActiveOrigin(){} // RVA: 0x7A8B50AF0
        public void get_active(){} // RVA: 0x7AE297960
        public void get_activeBinding(){} // RVA: 0x7AE2978C0
        public void get_lastActive(){} // RVA: 0x7AE2C2AE0
        public void set_lastActive(){} // RVA: 0x7AE2C2AF0
        public void get_lastActiveBinding(){} // RVA: 0x7AE2C2B00
        public void Preinitialize(){} // RVA: 0x7AE2C2B10
        public void Initialize(){} // RVA: 0x7AE2C2CA0
        public void RemoveAllListeners(){} // RVA: 0x7AE2C2D80
        public void UpdateValue(){} // RVA: 0x7AE2C3090
        public void .ctor(){} // RVA: 0x7AE2C38C0
    }

    public class SteamVR_Action_Vector3_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2C1F40
    }

    public class SteamVR_Action_Vibration : SteamVR_Action_Out`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7AE2C3910
        public void remove_onActiveChange(){} // RVA: 0x7AE2C3990
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2C3A10
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2C3A90
        public void add_onExecute(){} // RVA: 0x7AE2C3B10
        public void remove_onExecute(){} // RVA: 0x7AE2C3B90
        public void .ctor(){} // RVA: 0x7AE2C3C10
        public void Execute(){} // RVA: 0x7AE2C3CB0
        public void AddOnActiveChangeListener(){} // RVA: 0x7AE2C3D60
        public void RemoveOnActiveChangeListener(){} // RVA: 0x7AE2C3DE0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x7AE2C3E60
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x7AE2C3EE0
        public void AddOnExecuteListener(){} // RVA: 0x7AE2C3F60
        public void RemoveOnExecuteListener(){} // RVA: 0x7AE2C3FE0
        public void RemoveAllListeners(){} // RVA: 0x7AE2C4060
        public void GetTimeLastChanged(){} // RVA: 0x7AE2C40D0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7A80D7310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7AE2C4140
        public void IsUpdating(){} // RVA: 0x7AE2C4180
    }

    public class SteamVR_Action_Vibration_Source : SteamVR_Action_Out_Source
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x7AE2C4590
        public void remove_onActiveChange(){} // RVA: 0x7AE2C4680
        public void add_onActiveBindingChange(){} // RVA: 0x7AE2C4770
        public void remove_onActiveBindingChange(){} // RVA: 0x7AE2C4860
        public void add_onExecute(){} // RVA: 0x7AE2C4950
        public void remove_onExecute(){} // RVA: 0x7AE2C4A40
        public void get_active(){} // RVA: 0x7AE297960
        public void get_activeBinding(){} // RVA: 0x7A81BD750
        public void get_lastActive(){} // RVA: 0x7A8193790
        public void set_lastActive(){} // RVA: 0x7A81937A0
        public void get_lastActiveBinding(){} // RVA: 0x7A81BD750
        public void get_timeLastExecuted(){} // RVA: 0x7A80DF900
        public void set_timeLastExecuted(){} // RVA: 0x7A80DF910
        public void Initialize(){} // RVA: 0x7AE2C4B30
        public void Preinitialize(){} // RVA: 0x7AE2C4BB0
        public void RemoveAllListeners(){} // RVA: 0x7AE2C4D30
        public void Execute(){} // RVA: 0x7AE2C4F10
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Action_Vibration_Source[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Action_Vibration_Source_Map : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x7AE2C4500
        public void .ctor(){} // RVA: 0x7AE2C4550
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE845B0
        public void get_fullPath(){} // RVA: 0x7ABE845E0
        public void get_handle(){} // RVA: 0x7ABE84600
        public void get_actionSet(){} // RVA: 0x7ABE84620
        public void get_direction(){} // RVA: 0x7ABE84640
        public void get_active(){} // RVA: 0x7ABE84660
        public void get_lastActive(){} // RVA: 0x7ABE846B0
        public void get_activeBinding(){} // RVA: 0x7ABE84700
        public void get_lastActiveBinding(){} // RVA: 0x7ABE84750
        public void PreInitialize(){} // RVA: 0x7ABE847A0
        public void CreateUninitialized(){} // RVA: 0x7ABE849C0
        public void TryNeedsInitData(){} // RVA: 0x7ABE84BC0
        public void Initialize(){} // RVA: 0x7ABE84E80
        public void GetSourceMap(){} // RVA: 0x7A8105330
        public void InitializeCopy(){} // RVA: 0x7ABE84F90
        public void InitAfterDeserialize(){} // RVA: 0x7ABE85110
        public void GetActive(){} // RVA: 0x7ABE851C0
        public void GetActiveBinding(){} // RVA: 0x7ABE85210
        public void GetLastActive(){} // RVA: 0x7ABE85260
        public void GetLastActiveBinding(){} // RVA: 0x7ABE852B0
        public void GetActionBindingInfo(){} // RVA: 0x7ABE85300
        public void .ctor(){} // RVA: 0x7ABE859A0
        public void .cctor(){} // RVA: 0x7ABE859F0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE845B0
        public void get_fullPath(){} // RVA: 0x7ABE845E0
        public void get_handle(){} // RVA: 0x7ABE84600
        public void get_actionSet(){} // RVA: 0x7ABE84620
        public void get_direction(){} // RVA: 0x7ABE84640
        public void get_active(){} // RVA: 0x7ABE84660
        public void get_lastActive(){} // RVA: 0x7ABE846B0
        public void get_activeBinding(){} // RVA: 0x7ABE84700
        public void get_lastActiveBinding(){} // RVA: 0x7ABE84750
        public void PreInitialize(){} // RVA: 0x7ABE847A0
        public void CreateUninitialized(){} // RVA: 0x7ABE849C0
        public void TryNeedsInitData(){} // RVA: 0x7ABE84BC0
        public void Initialize(){} // RVA: 0x7ABE84E80
        public void GetSourceMap(){} // RVA: 0x7A8105330
        public void InitializeCopy(){} // RVA: 0x7ABE84F90
        public void InitAfterDeserialize(){} // RVA: 0x7ABE85110
        public void GetActive(){} // RVA: 0x7ABE851C0
        public void GetActiveBinding(){} // RVA: 0x7ABE85210
        public void GetLastActive(){} // RVA: 0x7ABE85260
        public void GetLastActiveBinding(){} // RVA: 0x7ABE852B0
        public void GetActionBindingInfo(){} // RVA: 0x7ABE85300
        public void .ctor(){} // RVA: 0x7ABE859A0
        public void .cctor(){} // RVA: 0x7ABE859F0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE845B0
        public void get_fullPath(){} // RVA: 0x7ABE845E0
        public void get_handle(){} // RVA: 0x7ABE84600
        public void get_actionSet(){} // RVA: 0x7ABE84620
        public void get_direction(){} // RVA: 0x7ABE84640
        public void get_active(){} // RVA: 0x7ABE84660
        public void get_lastActive(){} // RVA: 0x7ABE846B0
        public void get_activeBinding(){} // RVA: 0x7ABE84700
        public void get_lastActiveBinding(){} // RVA: 0x7ABE84750
        public void PreInitialize(){} // RVA: 0x7ABE847A0
        public void CreateUninitialized(){} // RVA: 0x7ABE849C0
        public void TryNeedsInitData(){} // RVA: 0x7ABE84BC0
        public void Initialize(){} // RVA: 0x7ABE84E80
        public void GetSourceMap(){} // RVA: 0x7A8105330
        public void InitializeCopy(){} // RVA: 0x7ABE84F90
        public void InitAfterDeserialize(){} // RVA: 0x7ABE85110
        public void GetActive(){} // RVA: 0x7ABE851C0
        public void GetActiveBinding(){} // RVA: 0x7ABE85210
        public void GetLastActive(){} // RVA: 0x7ABE85260
        public void GetLastActiveBinding(){} // RVA: 0x7ABE852B0
        public void GetActionBindingInfo(){} // RVA: 0x7ABE85300
        public void .ctor(){} // RVA: 0x7ABE859A0
        public void .cctor(){} // RVA: 0x7ABE859F0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE845B0
        public void get_fullPath(){} // RVA: 0x7ABE845E0
        public void get_handle(){} // RVA: 0x7ABE84600
        public void get_actionSet(){} // RVA: 0x7ABE84620
        public void get_direction(){} // RVA: 0x7ABE84640
        public void get_active(){} // RVA: 0x7ABE84660
        public void get_lastActive(){} // RVA: 0x7ABE846B0
        public void get_activeBinding(){} // RVA: 0x7ABE84700
        public void get_lastActiveBinding(){} // RVA: 0x7ABE84750
        public void PreInitialize(){} // RVA: 0x7ABE847A0
        public void CreateUninitialized(){} // RVA: 0x7ABE849C0
        public void TryNeedsInitData(){} // RVA: 0x7ABE84BC0
        public void Initialize(){} // RVA: 0x7ABE84E80
        public void GetSourceMap(){} // RVA: 0x7A8105330
        public void InitializeCopy(){} // RVA: 0x7ABE84F90
        public void InitAfterDeserialize(){} // RVA: 0x7ABE85110
        public void GetActive(){} // RVA: 0x7ABE851C0
        public void GetActiveBinding(){} // RVA: 0x7ABE85210
        public void GetLastActive(){} // RVA: 0x7ABE85260
        public void GetLastActiveBinding(){} // RVA: 0x7ABE852B0
        public void GetActionBindingInfo(){} // RVA: 0x7ABE85300
        public void .ctor(){} // RVA: 0x7ABE859A0
        public void .cctor(){} // RVA: 0x7ABE859F0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0x7ABE845B0
        public void get_fullPath(){} // RVA: 0x7ABE845E0
        public void get_handle(){} // RVA: 0x7ABE84600
        public void get_actionSet(){} // RVA: 0x7ABE84620
        public void get_direction(){} // RVA: 0x7ABE84640
        public void get_active(){} // RVA: 0x7ABE84660
        public void get_lastActive(){} // RVA: 0x7ABE846B0
        public void get_activeBinding(){} // RVA: 0x7ABE84700
        public void get_lastActiveBinding(){} // RVA: 0x7ABE84750
        public void PreInitialize(){} // RVA: 0x7ABE847A0
        public void CreateUninitialized(){} // RVA: 0x7ABE849C0
        public void TryNeedsInitData(){} // RVA: 0x7ABE84BC0
        public void Initialize(){} // RVA: 0x7ABE84E80
        public void GetSourceMap(){} // RVA: 0x7A8105330
        public void InitializeCopy(){} // RVA: 0x7ABE84F90
        public void InitAfterDeserialize(){} // RVA: 0x7ABE85110
        public void GetActive(){} // RVA: 0x7ABE851C0
        public void GetActiveBinding(){} // RVA: 0x7ABE85210
        public void GetLastActive(){} // RVA: 0x7ABE85260
        public void GetLastActiveBinding(){} // RVA: 0x7ABE852B0
        public void GetActionBindingInfo(){} // RVA: 0x7ABE85300
        public void .ctor(){} // RVA: 0x7ABE859A0
        public void .cctor(){} // RVA: 0x7ABE859F0
    }

    public class SteamVR_Actions : Object
    {
        // ── Methods ──
        public void get_global_Safe_Mode(){} // RVA: 0x7AE2AA430
        public void get_global_Pose(){} // RVA: 0x7AE2AA4A0
        public void get_global_SkeletonLeftHand(){} // RVA: 0x7AE2AA510
        public void get_global_SkeletonRightHand(){} // RVA: 0x7AE2AA580
        public void get_global_HeadsetOnHead(){} // RVA: 0x7AE2AA5F0
        public void get_global_Menu(){} // RVA: 0x7AE2AA660
        public void get_global_Quick_Menu(){} // RVA: 0x7AE2AA6D0
        public void get_global_Action_Menu(){} // RVA: 0x7AE2AA740
        public void get_global_Main_Menu(){} // RVA: 0x7AE2AA7B0
        public void get_global_Interact(){} // RVA: 0x7AE2AA820
        public void get_global_Grab(){} // RVA: 0x7AE2AA890
        public void get_global_Move(){} // RVA: 0x7AE2AA900
        public void get_global_Jump(){} // RVA: 0x7AE2AA970
        public void get_global_Rotate(){} // RVA: 0x7AE2AA9E0
        public void get_global_Mic(){} // RVA: 0x7AE2AAA50
        public void get_global_Gesture_Toggle(){} // RVA: 0x7AE2AAAC0
        public void get_global_Stick_Click(){} // RVA: 0x7AE2AAB30
        public void get_global_Trigger_Axis(){} // RVA: 0x7AE2AABA0
        public void get_global_Grip_Axis(){} // RVA: 0x7AE2AAC10
        public void get_global_Udon_Menu(){} // RVA: 0x7AE2AAC80
        public void get_global_Drop(){} // RVA: 0x7AE2AACF0
        public void get_global_Nameplates(){} // RVA: 0x7AE2AAD60
        public void get_global_HUD(){} // RVA: 0x7AE2AADD0
        public void get_global_Chatbox(){} // RVA: 0x7AE2AAE40
        public void get_global_Face_Mirror(){} // RVA: 0x7AE2AAEB0
        public void get_global_Personal_Mirror(){} // RVA: 0x7AE2AAF20
        public void get_global_Personal_Mirror_Lock(){} // RVA: 0x7AE2AAF90
        public void get_global_Earmuffs(){} // RVA: 0x7AE2AB000
        public void get_global_Camera(){} // RVA: 0x7AE2AB070
        public void get_global_Stream_Camera(){} // RVA: 0x7AE2AB0E0
        public void get_global_Avatar_Debug_Screen(){} // RVA: 0x7AE2AB150
        public void get_global_OSC_Debug_Screen(){} // RVA: 0x7AE2AB1C0
        public void get_global_Confirm_FBT_Calibration(){} // RVA: 0x7AE2AB230
        public void get_global_Start_Move(){} // RVA: 0x7AE2AB2A0
        public void get_global_Start_Rotate(){} // RVA: 0x7AE2AB310
        public void get_global_Continue_Move(){} // RVA: 0x7AE2AB380
        public void get_global_Continue_Rotate(){} // RVA: 0x7AE2AB3F0
        public void get_global_No_Gesture_After_Move(){} // RVA: 0x7AE2AB460
        public void get_global_No_Gesture_After_Rotate(){} // RVA: 0x7AE2AB4D0
        public void get_global_Gesture_Activator_Thumb(){} // RVA: 0x7AE2AB540
        public void get_global_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7AE2AB5B0
        public void get_global_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7AE2AB620
        public void get_global_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7AE2AB690
        public void get_global_Gesture_Activator_Index(){} // RVA: 0x7AE2AB700
        public void get_global_Gesture_Activator_Grip(){} // RVA: 0x7AE2AB770
        public void get_global_Gesture_Trigger_Axis(){} // RVA: 0x7AE2AB7E0
        public void get_global_Gesture_Grip_Axis(){} // RVA: 0x7AE2AB850
        public void get_global_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7AE2AB8C0
        public void get_global_Gesture_Direct_Neutral_Left(){} // RVA: 0x7AE2AB930
        public void get_global_Gesture_Direct_Fist_Left(){} // RVA: 0x7AE2AB9A0
        public void get_global_Gesture_Direct_Open_Left(){} // RVA: 0x7AE2ABA10
        public void get_global_Gesture_Direct_Peace_Left(){} // RVA: 0x7AE2ABA80
        public void get_global_Gesture_Direct_Horns_Left(){} // RVA: 0x7AE2ABAF0
        public void get_global_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7AE2ABB60
        public void get_global_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7AE2ABBD0
        public void get_global_Gesture_Direct_Point_Left(){} // RVA: 0x7AE2ABC40
        public void get_global_Gesture_Direct_Neutral_Right(){} // RVA: 0x7AE2ABCB0
        public void get_global_Gesture_Direct_Fist_Right(){} // RVA: 0x7AE2ABD20
        public void get_global_Gesture_Direct_Open_Right(){} // RVA: 0x7AE2ABD90
        public void get_global_Gesture_Direct_Peace_Right(){} // RVA: 0x7AE2ABE00
        public void get_global_Gesture_Direct_Horns_Right(){} // RVA: 0x7AE2ABE70
        public void get_global_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7AE2ABEE0
        public void get_global_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7AE2ABF50
        public void get_global_Gesture_Direct_Point_Right(){} // RVA: 0x7AE2ABFC0
        public void get_global_Gesture_Wheel_Left(){} // RVA: 0x7AE2AC030
        public void get_global_Gesture_Wheel_Select_Left(){} // RVA: 0x7AE2AC0A0
        public void get_global_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7AE2AC110
        public void get_global_Gesture_Wheel_Weight_Left(){} // RVA: 0x7AE2AC180
        public void get_global_Gesture_Wheel_Direct_Left(){} // RVA: 0x7AE2AC1F0
        public void get_global_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7AE2AC260
        public void get_global_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7AE2AC2D0
        public void get_global_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7AE2AC340
        public void get_global_Gesture_Wheel_Held_Left(){} // RVA: 0x7AE2AC3B0
        public void get_global_Gesture_Wheel_Right(){} // RVA: 0x7AE2AC420
        public void get_global_Gesture_Wheel_Select_Right(){} // RVA: 0x7AE2AC490
        public void get_global_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7AE2AC500
        public void get_global_Gesture_Wheel_Weight_Right(){} // RVA: 0x7AE2AC570
        public void get_global_Gesture_Wheel_Direct_Right(){} // RVA: 0x7AE2AC5E0
        public void get_global_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7AE2AC650
        public void get_global_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7AE2AC6C0
        public void get_global_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7AE2AC730
        public void get_global_Gesture_Wheel_Held_Right(){} // RVA: 0x7AE2AC7A0
        public void get_global_Disable_Gesture_Tracked(){} // RVA: 0x7AE2AC810
        public void get_global_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7AE2AC880
        public void get_global_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7AE2AC8F0
        public void get_global_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7AE2AC960
        public void get_global_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7AE2AC9D0
        public void get_global_Physbone_Grab_Left(){} // RVA: 0x7AE2ACA40
        public void get_global_Physbone_Freeze_Left(){} // RVA: 0x7AE2ACAB0
        public void get_global_Physbone_Grab_Right(){} // RVA: 0x7AE2ACB20
        public void get_global_Physbone_Freeze_Right(){} // RVA: 0x7AE2ACB90
        public void get_global_Scroll(){} // RVA: 0x7AE2ACC00
        public void get_global_Haptic(){} // RVA: 0x7AE2ACC70
        public void get_one_Hand_Interact(){} // RVA: 0x7AE2ACCE0
        public void get_one_Hand_Grab(){} // RVA: 0x7AE2ACD50
        public void get_one_Hand_Move_Rotate(){} // RVA: 0x7AE2ACDC0
        public void get_one_Hand_Jump(){} // RVA: 0x7AE2ACE30
        public void get_one_Hand_Mic(){} // RVA: 0x7AE2ACEA0
        public void get_one_Hand_Gesture_Toggle(){} // RVA: 0x7AE2ACF10
        public void get_one_Hand_Stick_Click(){} // RVA: 0x7AE2ACF80
        public void get_one_Hand_Trigger_Axis(){} // RVA: 0x7AE2ACFF0
        public void get_one_Hand_Grip_Axis(){} // RVA: 0x7AE2AD060
        public void get_one_Hand_Udon_Menu(){} // RVA: 0x7AE2AD0D0
        public void get_one_Hand_Drop(){} // RVA: 0x7AE2AD140
        public void get_one_Hand_Start_Move_Rotate(){} // RVA: 0x7AE2AD1B0
        public void get_one_Hand_Continue_Move_Rotate(){} // RVA: 0x7AE2AD220
        public void get_one_Hand_No_Gesture_After_Move_Rotate(){} // RVA: 0x7AE2AD290
        public void get_one_Hand_Menu(){} // RVA: 0x7AE2AD300
        public void get_one_Hand_Nameplates(){} // RVA: 0x7AE2AD370
        public void get_one_Hand_HUD(){} // RVA: 0x7AE2AD3E0
        public void get_one_Hand_Chatbox(){} // RVA: 0x7AE2AD450
        public void get_one_Hand_Face_Mirror(){} // RVA: 0x7AE2AD4C0
        public void get_one_Hand_Personal_Mirror(){} // RVA: 0x7AE2AD530
        public void get_one_Hand_Personal_Mirror_Lock(){} // RVA: 0x7AE2AD5A0
        public void get_one_Hand_Earmuffs(){} // RVA: 0x7AE2AD610
        public void get_one_Hand_Camera(){} // RVA: 0x7AE2AD680
        public void get_one_Hand_Stream_Camera(){} // RVA: 0x7AE2AD6F0
        public void get_one_Hand_Avatar_Debug_Screen(){} // RVA: 0x7AE2AD760
        public void get_one_Hand_OSC_Debug_Screen(){} // RVA: 0x7AE2AD7D0
        public void get_one_Hand_Confirm_FBT_Calibration(){} // RVA: 0x7AE2AD840
        public void get_one_Hand_Gesture_Activator_Thumb(){} // RVA: 0x7AE2AD8B0
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7AE2AD920
        public void get_one_Hand_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7AE2AD990
        public void get_one_Hand_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7AE2ADA00
        public void get_one_Hand_Gesture_Activator_Index(){} // RVA: 0x7AE2ADA70
        public void get_one_Hand_Gesture_Activator_Grip(){} // RVA: 0x7AE2ADAE0
        public void get_one_Hand_Gesture_Trigger_Axis(){} // RVA: 0x7AE2ADB50
        public void get_one_Hand_Gesture_Grip_Axis(){} // RVA: 0x7AE2ADBC0
        public void get_one_Hand_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7AE2ADC30
        public void get_one_Hand_Gesture_Wheel_Left(){} // RVA: 0x7AE2ADCA0
        public void get_one_Hand_Gesture_Wheel_Select_Left(){} // RVA: 0x7AE2ADD10
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7AE2ADD80
        public void get_one_Hand_Gesture_Wheel_Weight_Left(){} // RVA: 0x7AE2ADDF0
        public void get_one_Hand_Gesture_Wheel_Direct_Left(){} // RVA: 0x7AE2ADE60
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7AE2ADED0
        public void get_one_Hand_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7AE2ADF40
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7AE2ADFB0
        public void get_one_Hand_Gesture_Wheel_Held_Left(){} // RVA: 0x7AE2AE020
        public void get_one_Hand_Gesture_Wheel_Right(){} // RVA: 0x7AE2AE090
        public void get_one_Hand_Gesture_Wheel_Select_Right(){} // RVA: 0x7AE2AE100
        public void get_one_Hand_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7AE2AE170
        public void get_one_Hand_Gesture_Wheel_Weight_Right(){} // RVA: 0x7AE2AE1E0
        public void get_one_Hand_Gesture_Wheel_Direct_Right(){} // RVA: 0x7AE2AE250
        public void get_one_Hand_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7AE2AE2C0
        public void get_one_Hand_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7AE2AE330
        public void get_one_Hand_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7AE2AE3A0
        public void get_one_Hand_Gesture_Wheel_Held_Right(){} // RVA: 0x7AE2AE410
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7AE2AE480
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7AE2AE4F0
        public void get_one_Hand_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7AE2AE560
        public void get_one_Hand_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7AE2AE5D0
        public void get_one_Hand_Reserve_bool(){} // RVA: 0x7AE2AE640
        public void get_one_Hand_Reserve_vector1(){} // RVA: 0x7AE2AE6B0
        public void get_one_Hand_Reserve_vector2(){} // RVA: 0x7AE2AE720
        public void get_menu_Confirm(){} // RVA: 0x7AE2AE790
        public void get_menu_Back(){} // RVA: 0x7AE2AE800
        public void get_menu_Tab(){} // RVA: 0x7AE2AE870
        public void get_menu_Scroll(){} // RVA: 0x7AE2AE8E0
        public void get_menu_Quick_Menu_Close(){} // RVA: 0x7AE2AE950
        public void get_menu_Drag(){} // RVA: 0x7AE2AE9C0
        public void get_action_Menu_Axis(){} // RVA: 0x7AE2AEA30
        public void get_action_Menu_Select(){} // RVA: 0x7AE2AEAA0
        public void get_action_Menu_Gesture_Activator_Thumb(){} // RVA: 0x7AE2AEB10
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7AE2AEB80
        public void get_action_Menu_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7AE2AEBF0
        public void get_action_Menu_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7AE2AEC60
        public void get_action_Menu_Gesture_Activator_Index(){} // RVA: 0x7AE2AECD0
        public void get_action_Menu_Gesture_Activator_Grip(){} // RVA: 0x7AE2AED40
        public void get_action_Menu_Gesture_Trigger_Axis(){} // RVA: 0x7AE2AEDB0
        public void get_action_Menu_Gesture_Grip_Axis(){} // RVA: 0x7AE2AEE20
        public void get_action_Menu_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7AE2AEE90
        public void get_action_Menu_Gesture_Wheel_Left(){} // RVA: 0x7AE2AEF00
        public void get_action_Menu_Gesture_Wheel_Select_Left(){} // RVA: 0x7AE2AEF70
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7AE2AEFE0
        public void get_action_Menu_Gesture_Wheel_Weight_Left(){} // RVA: 0x7AE2AF050
        public void get_action_Menu_Gesture_Wheel_Direct_Left(){} // RVA: 0x7AE2AF0C0
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7AE2AF130
        public void get_action_Menu_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7AE2AF1A0
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7AE2AF210
        public void get_action_Menu_Gesture_Wheel_Held_Left(){} // RVA: 0x7AE2AF280
        public void get_action_Menu_Gesture_Wheel_Right(){} // RVA: 0x7AE2AF2F0
        public void get_action_Menu_Gesture_Wheel_Select_Right(){} // RVA: 0x7AE2AF360
        public void get_action_Menu_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7AE2AF3D0
        public void get_action_Menu_Gesture_Wheel_Weight_Right(){} // RVA: 0x7AE2AF440
        public void get_action_Menu_Gesture_Wheel_Direct_Right(){} // RVA: 0x7AE2AF4B0
        public void get_action_Menu_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7AE2AF520
        public void get_action_Menu_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7AE2AF590
        public void get_action_Menu_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7AE2AF600
        public void get_action_Menu_Gesture_Wheel_Held_Right(){} // RVA: 0x7AE2AF670
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7AE2AF6E0
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7AE2AF750
        public void get_action_Menu_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7AE2AF7C0
        public void get_action_Menu_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7AE2AF830
        public void get_action_Menu_Reserve_bool(){} // RVA: 0x7AE2AF8A0
        public void get_action_Menu_Reserve_vector1(){} // RVA: 0x7AE2AF910
        public void get_action_Menu_Reserve_vector2(){} // RVA: 0x7AE2AF980
        public void get_action_Menu_Grab(){} // RVA: 0x7AE2AF9F0
        public void get_action_Menu_Drop(){} // RVA: 0x7AE2AFA60
        public void get_drone_Left_Joystick(){} // RVA: 0x7AE2AFAD0
        public void get_drone_Right_Joystick(){} // RVA: 0x7AE2AFB40
        public void get_drone_Self_Leveling_Mod(){} // RVA: 0x7AE2AFBB0
        public void get_drone_Hold_Altitude_Mod(){} // RVA: 0x7AE2AFC20
        public void get_drone_Toggle_FPV(){} // RVA: 0x7AE2AFC90
        public void get_drone_Flip(){} // RVA: 0x7AE2AFD00
        public void get_drone_Take_Picture(){} // RVA: 0x7AE2AFD70
        public void get_drone_Cycle_Flight_Preset(){} // RVA: 0x7AE2AFDE0
        public void get_drone_Toggle_Self_Leveling(){} // RVA: 0x7AE2AFE50
        public void get_drone_Respawn(){} // RVA: 0x7AE2AFEC0
        public void get_drone_Select_Flight_Preset_Micro(){} // RVA: 0x7AE2AFF30
        public void get_drone_Select_Flight_Preset_Cinematic(){} // RVA: 0x7AE2AFFA0
        public void get_drone_Select_Flight_Preset_Racing(){} // RVA: 0x7AE2B0010
        public void get_drone_Select_Flight_Preset_Freestyle(){} // RVA: 0x7AE2B0080
        public void InitializeActionArrays(){} // RVA: 0x7AE2B00F0
        public void PreInitActions(){} // RVA: 0x7AE2B9890
        public void get_Global(){} // RVA: 0x7AE2BE670
        public void get_One_Hand(){} // RVA: 0x7AE2BE6E0
        public void get_Menu(){} // RVA: 0x7AE2BE750
        public void get_Action_Menu(){} // RVA: 0x7AE2BE7C0
        public void get_Drone(){} // RVA: 0x7AE2BE830
        public void StartPreInitActionSets(){} // RVA: 0x7AE2BE8A0
        public void PreInitialize(){} // RVA: 0x7AE2BEF80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Behaviour_BooleanEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE290280
    }

    public class SteamVR_Behaviour_PoseEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE290310
    }

    public class SteamVR_Behaviour_Pose_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2903A0
    }

    public class SteamVR_Behaviour_Pose_DeviceIndexChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE290430
    }

    public class SteamVR_Behaviour_Pose_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2904C0
    }

    public class SteamVR_Behaviour_SingleEvent : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE290550
    }

    public class SteamVR_Behaviour_Vector2Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE290790
    }

    public class SteamVR_Behaviour_Vector3Event : UnityEvent`4
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE290820
    }

    public class SteamVR_Camera[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class SteamVR_Input_ActionFile : Object
    {
        // ── Methods ──
        public void InitializeHelperLists(){} // RVA: 0x7AE2DAAA0
        public void SaveHelperLists(){} // RVA: 0x7AE2DB170
        public void GetShortName(){} // RVA: 0x7AE2DB9B0
        public void GetCodeFriendlyName(){} // RVA: 0x7AE2DBA50
        public void GetFilesToCopy(){} // RVA: 0x7AE2DBC00
        public void CopyFilesToPath(){} // RVA: 0x7AE2DBF90
        public void RemoveAppKey(){} // RVA: 0x7AE2DC250
        public void Open(){} // RVA: 0x7AE2DC3C0
        public void Save(){} // RVA: 0x7AE2DC4C0
        public void .ctor(){} // RVA: 0x7AE2DC690
        public void actions(){} // RVA: 0x7B3FB4428
    }

    public class SteamVR_Input_ActionFile_Action : Object
    {
        // ── Methods ──
        public void get_requirementValues(){} // RVA: 0x7AE2DD460
        public void GetCopy(){} // RVA: 0x7AE2DD640
        public void get_requirementEnum(){} // RVA: 0x7AE2DD830
        public void set_requirementEnum(){} // RVA: 0x7AE2DD980
        public void get_codeFriendlyName(){} // RVA: 0x7AE2DCD80
        public void get_shortName(){} // RVA: 0x7AE2DDA30
        public void get_path(){} // RVA: 0x7AE2DDA40
        public void CreateNewName(){} // RVA: 0x7AE2DDB70
        public void CreateNew(){} // RVA: 0x7AE2DDC60
        public void get_direction(){} // RVA: 0x7AE2DDE70
        public void get_actionSet(){} // RVA: 0x7AE2DDF30
        public void SetNewActionSet(){} // RVA: 0x7AE2DDFE0
        public void ToString(){} // RVA: 0x7AE2DDA30
        public void Equals(){} // RVA: 0x7AE2DE1E0
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ActionFile_ActionSet : Object
    {
        // ── Methods ──
        public void get_codeFriendlyName(){} // RVA: 0x7AE2DCD80
        public void get_shortName(){} // RVA: 0x7AE2DCD90
        public void SetNewShortName(){} // RVA: 0x7AE2DCE90
        public void CreateNewName(){} // RVA: 0x7AE2DCF00
        public void GetPathFromName(){} // RVA: 0x7AE2DCF40
        public void CreateNew(){} // RVA: 0x7AE2DCFD0
        public void GetCopy(){} // RVA: 0x7AE2DD0A0
        public void Equals(){} // RVA: 0x7AE2DD1B0
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7AE2DD2B0
    }

    public class SteamVR_Input_ActionFile_ActionSet_Usages : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE2DFBF0
    }

    public class SteamVR_Input_ActionFile_ActionTypes : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AE2DF310
    }

    public class SteamVR_Input_ActionFile_DefaultBinding : Object
    {
        // ── Methods ──
        public void GetCopy(){} // RVA: 0x7AE2DCC80
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ActionFile_LocalizationItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2DE4E0
    }

    public class SteamVR_Input_ActionSet_Action_Menu : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Axis(){} // RVA: 0x7AE2A96F0
        public void get_Select(){} // RVA: 0x7AE2A9700
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7AE2A9710
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7AE2A9720
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7AE2A9730
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7AE2A9740
        public void get_Gesture_Activator_Index(){} // RVA: 0x7AE2A9750
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7AE2A9760
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7AE2A9770
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7AE2A9780
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7AE2A9790
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7AE2A97A0
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7AE2A97B0
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7AE2A97C0
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7AE2A97D0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7AE2A97E0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7AE2A97F0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7AE2A9800
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7AE2A9810
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7AE2A9820
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7AE2A9830
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7AE2A9840
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7AE2A9850
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7AE2A9860
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7AE2A9870
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7AE2A9880
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7AE2A9890
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7AE2A98A0
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7AE2A98B0
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7AE2A98C0
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7AE2A98D0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7AE2A98E0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7AE2A98F0
        public void get_Reserve_bool(){} // RVA: 0x7AE2A9900
        public void get_Reserve_vector1(){} // RVA: 0x7AE2A9910
        public void get_Reserve_vector2(){} // RVA: 0x7AE2A9920
        public void get_Grab(){} // RVA: 0x7AE2A9930
        public void get_Drop(){} // RVA: 0x7AE2A9940
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ActionSet_Drone : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Left_Joystick(){} // RVA: 0x7AE2A9950
        public void get_Right_Joystick(){} // RVA: 0x7AE2A9960
        public void get_Self_Leveling_Mod(){} // RVA: 0x7AE2A9970
        public void get_Hold_Altitude_Mod(){} // RVA: 0x7AE2A9980
        public void get_Toggle_FPV(){} // RVA: 0x7AE2A9990
        public void get_Flip(){} // RVA: 0x7AE2A99A0
        public void get_Take_Picture(){} // RVA: 0x7AE2A99B0
        public void get_Cycle_Flight_Preset(){} // RVA: 0x7AE2A99C0
        public void get_Toggle_Self_Leveling(){} // RVA: 0x7AE2A99D0
        public void get_Respawn(){} // RVA: 0x7AE2A99E0
        public void get_Select_Flight_Preset_Micro(){} // RVA: 0x7AE2A99F0
        public void get_Select_Flight_Preset_Cinematic(){} // RVA: 0x7AE2A9A00
        public void get_Select_Flight_Preset_Racing(){} // RVA: 0x7AE2A9A10
        public void get_Select_Flight_Preset_Freestyle(){} // RVA: 0x7AE2A9A20
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ActionSet_Global : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Safe_Mode(){} // RVA: 0x7AE2A9A30
        public void get_Pose(){} // RVA: 0x7AE2A9A40
        public void get_SkeletonLeftHand(){} // RVA: 0x7AE2A9A50
        public void get_SkeletonRightHand(){} // RVA: 0x7AE2A9A60
        public void get_HeadsetOnHead(){} // RVA: 0x7AE2A9A70
        public void get_Menu(){} // RVA: 0x7AE2A9A80
        public void get_Quick_Menu(){} // RVA: 0x7AE2A9A90
        public void get_Action_Menu(){} // RVA: 0x7AE2A9AA0
        public void get_Main_Menu(){} // RVA: 0x7AE2A9AB0
        public void get_Interact(){} // RVA: 0x7AE2A9AC0
        public void get_Grab(){} // RVA: 0x7AE2A9AD0
        public void get_Move(){} // RVA: 0x7AE2A9AE0
        public void get_Jump(){} // RVA: 0x7AE2A9AF0
        public void get_Rotate(){} // RVA: 0x7AE2A9B00
        public void get_Mic(){} // RVA: 0x7AE2A9B10
        public void get_Gesture_Toggle(){} // RVA: 0x7AE2A9B20
        public void get_Stick_Click(){} // RVA: 0x7AE2A9B30
        public void get_Trigger_Axis(){} // RVA: 0x7AE2A9B40
        public void get_Grip_Axis(){} // RVA: 0x7AE2A9B50
        public void get_Udon_Menu(){} // RVA: 0x7AE2A9B60
        public void get_Drop(){} // RVA: 0x7AE2A9B70
        public void get_Nameplates(){} // RVA: 0x7AE2A9B80
        public void get_HUD(){} // RVA: 0x7AE2A9B90
        public void get_Chatbox(){} // RVA: 0x7AE2A9BA0
        public void get_Face_Mirror(){} // RVA: 0x7AE2A9BB0
        public void get_Personal_Mirror(){} // RVA: 0x7AE2A9BC0
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7AE2A9BD0
        public void get_Earmuffs(){} // RVA: 0x7AE2A9BE0
        public void get_Camera(){} // RVA: 0x7AE2A9BF0
        public void get_Stream_Camera(){} // RVA: 0x7AE2A9C00
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7AE2A9C10
        public void get_OSC_Debug_Screen(){} // RVA: 0x7AE2A9C20
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7AE2A9C30
        public void get_Start_Move(){} // RVA: 0x7AE2A9C40
        public void get_Start_Rotate(){} // RVA: 0x7AE2A9C50
        public void get_Continue_Move(){} // RVA: 0x7AE2A9C60
        public void get_Continue_Rotate(){} // RVA: 0x7AE2A9C70
        public void get_No_Gesture_After_Move(){} // RVA: 0x7AE2A9C80
        public void get_No_Gesture_After_Rotate(){} // RVA: 0x7AE2A9C90
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7AE2A9CA0
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7AE2A9CB0
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7AE2A9CC0
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7AE2A9CD0
        public void get_Gesture_Activator_Index(){} // RVA: 0x7AE2A9CE0
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7AE2A9CF0
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7AE2A9D00
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7AE2A9D10
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7AE2A9D20
        public void get_Gesture_Direct_Neutral_Left(){} // RVA: 0x7AE2A9D30
        public void get_Gesture_Direct_Fist_Left(){} // RVA: 0x7AE2A9D40
        public void get_Gesture_Direct_Open_Left(){} // RVA: 0x7AE2A9D50
        public void get_Gesture_Direct_Peace_Left(){} // RVA: 0x7AE2A9D60
        public void get_Gesture_Direct_Horns_Left(){} // RVA: 0x7AE2A9D70
        public void get_Gesture_Direct_Finger_Gun_Left(){} // RVA: 0x7AE2A9D80
        public void get_Gesture_Direct_Thumbs_Up_Left(){} // RVA: 0x7AE2A9D90
        public void get_Gesture_Direct_Point_Left(){} // RVA: 0x7AE2A9DA0
        public void get_Gesture_Direct_Neutral_Right(){} // RVA: 0x7AE2A9DB0
        public void get_Gesture_Direct_Fist_Right(){} // RVA: 0x7AE2A9DC0
        public void get_Gesture_Direct_Open_Right(){} // RVA: 0x7AE2A9DD0
        public void get_Gesture_Direct_Peace_Right(){} // RVA: 0x7AE2A9DE0
        public void get_Gesture_Direct_Horns_Right(){} // RVA: 0x7AE2A9DF0
        public void get_Gesture_Direct_Finger_Gun_Right(){} // RVA: 0x7AE2A9E00
        public void get_Gesture_Direct_Thumbs_Up_Right(){} // RVA: 0x7AE2A9E10
        public void get_Gesture_Direct_Point_Right(){} // RVA: 0x7AE2A9E20
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7AE2A9E30
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7AE2A9E40
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7AE2A9E50
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7AE2A9E60
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7AE2A9E70
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7AE2A9E80
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7AE2A9E90
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7AE2A9EA0
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7AE2A9EB0
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7AE2A9EC0
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7AE2A9ED0
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7AE2A9EE0
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7AE2A9EF0
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7AE2A9F00
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7AE2A9F10
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7AE2A9F20
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7AE2A9F30
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7AE2A9F40
        public void get_Disable_Gesture_Tracked(){} // RVA: 0x7AE2A9F50
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7AE2A9F60
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7AE2A9F70
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7AE2A9F80
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7AE2A9F90
        public void get_Physbone_Grab_Left(){} // RVA: 0x7AE2A9FA0
        public void get_Physbone_Freeze_Left(){} // RVA: 0x7AE2A9FB0
        public void get_Physbone_Grab_Right(){} // RVA: 0x7AE2A9FC0
        public void get_Physbone_Freeze_Right(){} // RVA: 0x7AE2A9FD0
        public void get_Scroll(){} // RVA: 0x7AE2A9FE0
        public void get_Haptic(){} // RVA: 0x7AE2A9FF0
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ActionSet_Menu : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Confirm(){} // RVA: 0x7AE2AA000
        public void get_Back(){} // RVA: 0x7AE2AA010
        public void get_Tab(){} // RVA: 0x7AE2AA020
        public void get_Scroll(){} // RVA: 0x7AE2AA030
        public void get_Quick_Menu_Close(){} // RVA: 0x7AE2AA040
        public void get_Drag(){} // RVA: 0x7AE2AA050
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ActionSet_One_Hand : SteamVR_ActionSet
    {
        // ── Methods ──
        public void get_Interact(){} // RVA: 0x7AE2AA060
        public void get_Grab(){} // RVA: 0x7AE2AA070
        public void get_Move_Rotate(){} // RVA: 0x7AE2AA080
        public void get_Jump(){} // RVA: 0x7AE2AA090
        public void get_Mic(){} // RVA: 0x7AE2AA0A0
        public void get_Gesture_Toggle(){} // RVA: 0x7AE2AA0B0
        public void get_Stick_Click(){} // RVA: 0x7AE2AA0C0
        public void get_Trigger_Axis(){} // RVA: 0x7AE2AA0D0
        public void get_Grip_Axis(){} // RVA: 0x7AE2AA0E0
        public void get_Udon_Menu(){} // RVA: 0x7AE2AA0F0
        public void get_Drop(){} // RVA: 0x7AE2AA100
        public void get_Start_Move_Rotate(){} // RVA: 0x7AE2AA110
        public void get_Continue_Move_Rotate(){} // RVA: 0x7AE2AA120
        public void get_No_Gesture_After_Move_Rotate(){} // RVA: 0x7AE2AA130
        public void get_Menu(){} // RVA: 0x7AE2AA140
        public void get_Nameplates(){} // RVA: 0x7AE2AA150
        public void get_HUD(){} // RVA: 0x7AE2AA160
        public void get_Chatbox(){} // RVA: 0x7AE2AA170
        public void get_Face_Mirror(){} // RVA: 0x7AE2AA180
        public void get_Personal_Mirror(){} // RVA: 0x7AE2AA190
        public void get_Personal_Mirror_Lock(){} // RVA: 0x7AE2AA1A0
        public void get_Earmuffs(){} // RVA: 0x7AE2AA1B0
        public void get_Camera(){} // RVA: 0x7AE2AA1C0
        public void get_Stream_Camera(){} // RVA: 0x7AE2AA1D0
        public void get_Avatar_Debug_Screen(){} // RVA: 0x7AE2AA1E0
        public void get_OSC_Debug_Screen(){} // RVA: 0x7AE2AA1F0
        public void get_Confirm_FBT_Calibration(){} // RVA: 0x7AE2AA200
        public void get_Gesture_Activator_Thumb(){} // RVA: 0x7AE2AA210
        public void get_Gesture_Activator_Thumb_Inner_Upper(){} // RVA: 0x7AE2AA220
        public void get_Gesture_Activator_Thumb_Inner_Lower(){} // RVA: 0x7AE2AA230
        public void get_Gesture_Activator_Thumb_Outer(){} // RVA: 0x7AE2AA240
        public void get_Gesture_Activator_Index(){} // RVA: 0x7AE2AA250
        public void get_Gesture_Activator_Grip(){} // RVA: 0x7AE2AA260
        public void get_Gesture_Trigger_Axis(){} // RVA: 0x7AE2AA270
        public void get_Gesture_Grip_Axis(){} // RVA: 0x7AE2AA280
        public void get_Gesture_Activator_Stick_Deflection(){} // RVA: 0x7AE2AA290
        public void get_Gesture_Wheel_Left(){} // RVA: 0x7AE2AA2A0
        public void get_Gesture_Wheel_Select_Left(){} // RVA: 0x7AE2AA2B0
        public void get_Gesture_Wheel_Soft_Select_Left(){} // RVA: 0x7AE2AA2C0
        public void get_Gesture_Wheel_Weight_Left(){} // RVA: 0x7AE2AA2D0
        public void get_Gesture_Wheel_Direct_Left(){} // RVA: 0x7AE2AA2E0
        public void get_Gesture_Wheel_Direct_Stay_Left(){} // RVA: 0x7AE2AA2F0
        public void get_Gesture_Wheel_Cancel_Left(){} // RVA: 0x7AE2AA300
        public void get_Gesture_Wheel_Cancel_Open_Left(){} // RVA: 0x7AE2AA310
        public void get_Gesture_Wheel_Held_Left(){} // RVA: 0x7AE2AA320
        public void get_Gesture_Wheel_Right(){} // RVA: 0x7AE2AA330
        public void get_Gesture_Wheel_Select_Right(){} // RVA: 0x7AE2AA340
        public void get_Gesture_Wheel_Soft_Select_Right(){} // RVA: 0x7AE2AA350
        public void get_Gesture_Wheel_Weight_Right(){} // RVA: 0x7AE2AA360
        public void get_Gesture_Wheel_Direct_Right(){} // RVA: 0x7AE2AA370
        public void get_Gesture_Wheel_Direct_Stay_Right(){} // RVA: 0x7AE2AA380
        public void get_Gesture_Wheel_Cancel_Right(){} // RVA: 0x7AE2AA390
        public void get_Gesture_Wheel_Cancel_Open_Right(){} // RVA: 0x7AE2AA3A0
        public void get_Gesture_Wheel_Held_Right(){} // RVA: 0x7AE2AA3B0
        public void get_Disable_Gesture_Wheel_Move_Left(){} // RVA: 0x7AE2AA3C0
        public void get_Disable_Gesture_Wheel_Rotate_Left(){} // RVA: 0x7AE2AA3D0
        public void get_Disable_Gesture_Wheel_Move_Right(){} // RVA: 0x7AE2AA3E0
        public void get_Disable_Gesture_Wheel_Rotate_Right(){} // RVA: 0x7AE2AA3F0
        public void get_Reserve_bool(){} // RVA: 0x7AE2AA400
        public void get_Reserve_vector1(){} // RVA: 0x7AE2AA410
        public void get_Reserve_vector2(){} // RVA: 0x7AE2AA420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_BindingFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2E0100
    }

    public class SteamVR_Input_BindingFile_ActionList : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2E01C0
    }

    public class SteamVR_Input_BindingFile_Chord : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AE2E04E0
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7AE2E0810
    }

    public class SteamVR_Input_BindingFile_Haptic : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AE2E0A20
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_BindingFile_Pose : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AE2E08D0
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_BindingFile_Skeleton : Object
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AE2E0B70
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_BindingFile_Source : Object
    {
        // ── Methods ──
        public void GetOutput(){} // RVA: 0x7AE2E0CC0
        public void Equals(){} // RVA: 0x7AE2E1070
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7AE2E1260
    }

    public class SteamVR_Input_BindingFile_Source_Input : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AE2E13E0
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7AE2E16E0
    }

    public class SteamVR_Input_BindingFile_Source_Input_StringDictionary : Dictionary`2
    {
        // ── Methods ──
        public void Equals(){} // RVA: 0x7AE2E1720
        public void GetHashCode(){} // RVA: 0x7ADA51890
        public void .ctor(){} // RVA: 0x7AE2E1860
    }

    public class SteamVR_Input_Generator_Names : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ManifestFile : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ManifestFile_Application : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2DE8B0
    }

    public class SteamVR_Input_ManifestFile_ApplicationString : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Input_ManifestFile_Application_Binding_ControllerTypes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE2DECD0
    }

    public class SteamVR_Input_Source : Object
    {
        // ── Methods ──
        public void GetHandle(){} // RVA: 0x7AE2E18A0
        public void GetSource(){} // RVA: 0x7AE2E1950
        public void GetAllSources(){} // RVA: 0x7AE2E1AE0
        public void GetPath(){} // RVA: 0x7AE2E1D80
        public void Initialize(){} // RVA: 0x7AE2E1EC0
        public void .cctor(){} // RVA: 0x7AE2E2750
    }

    public class SteamVR_Input_Unity_AssemblyFile_Definition : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE2DE970
    }

    public class SteamVR_Skeleton_FingerExtensionTypeLists : Object
    {
        // ── Methods ──
        public void get_enumList(){} // RVA: 0x7AE2E2DF0
        public void get_stringList(){} // RVA: 0x7AE2E3000
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class SteamVR_Skeleton_FingerIndexes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE2A81B0
    }

    public class SteamVR_Skeleton_FingerSplayIndexes : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void .cctor(){} // RVA: 0x7AE2A8420
    }

    public class SteamVR_Skeleton_HandMask : Object
    {
        // ── Methods ──
        public void SetFinger(){} // RVA: 0x7AE2E6BA0
        public void GetFinger(){} // RVA: 0x7AE2E6BE0
        public void .ctor(){} // RVA: 0x7AE2E6C10
        public void Reset(){} // RVA: 0x7AE2E6DD0
        public void Apply(){} // RVA: 0x7AE2E6E90
        public void .cctor(){} // RVA: 0x7AE2E6F50
    }

    public class SteamVR_Skeleton_JointIndexes : Object
    {
        // ── Methods ──
        public void GetFingerForBone(){} // RVA: 0x7AE2A80F0
        public void GetBoneForFingerTip(){} // RVA: 0x7AE2A8170
    }

    public class SteamVR_TrackedCamera : Object
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x7AE30FD80
        public void Undistorted(){} // RVA: 0x7AE30FF20
        public void Source(){} // RVA: 0x7AE3100D0
        public void Stream(){} // RVA: 0x7AE310410
        public void .ctor(){} // RVA: 0x7A80D7310
        public void distorted(){} // RVA: 0x7B3F89E08
    }

}