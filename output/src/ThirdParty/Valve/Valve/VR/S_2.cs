// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 88
// Methods: 1792

namespace ThirdParty.Valve.Valve.VR
{
    public class SteamVR_ActionSet_Data : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F11BB0
        public void get_allActions(){} // RVA: 0xB5DBF0
        public void set_allActions(){} // RVA: 0xB44D60
        public void get_nonVisualInActions(){} // RVA: 0xB465B0
        public void set_nonVisualInActions(){} // RVA: 0xBA9BA0
        public void get_visualActions(){} // RVA: 0xB700F0
        public void set_visualActions(){} // RVA: 0xB70100
        public void get_poseActions(){} // RVA: 0xB70160
        public void set_poseActions(){} // RVA: 0xB44DC0
        public void get_skeletonActions(){} // RVA: 0xD33E60
        public void set_skeletonActions(){} // RVA: 0xB708C0
        public void get_outActionArray(){} // RVA: 0xD05CA0
        public void set_outActionArray(){} // RVA: 0xD09D70
        public void get_fullPath(){} // RVA: 0xBC1B30
        public void set_fullPath(){} // RVA: 0xB6A8C0
        public void get_usage(){} // RVA: 0xBBF8F0
        public void set_usage(){} // RVA: 0xBBF900
        public void get_handle(){} // RVA: 0xBE58B0
        public void set_handle(){} // RVA: 0xE9E640
        public void PreInitialize(){} // RVA: 0xB43310
        public void FinishPreInitialize(){} // RVA: 0x6F11D90
        public void Initialize(){} // RVA: 0x6F127E0
        public void IsActive(){} // RVA: 0x6F129D0
        public void GetTimeLastChanged(){} // RVA: 0x6F12A20
        public void Activate(){} // RVA: 0x6F12A60
        public void Deactivate(){} // RVA: 0x6F12C00
        public void GetShortName(){} // RVA: 0x6F12D10
        public void ReadRawSetActive(){} // RVA: 0x6F12D90
        public void ReadRawSetLastChanged(){} // RVA: 0x6F12DC0
        public void ReadRawSetPriority(){} // RVA: 0x6F12DF0
    }

    public class SteamVR_Action[] : Array
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

    public class SteamVR_Action_Boolean_Source : SteamVR_Action_In_Source
    {
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

    public class SteamVR_Action_Boolean_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F159B0
    }

    public class SteamVR_Action_In_Source : SteamVR_Action_Source
    {
        // ── Methods ──
        public void get_isUpdating(){} // RVA: 0xF73960
        public void set_isUpdating(){} // RVA: 0xF73A60
        public void get_updateTime(){} // RVA: 0xCD5510
        public void set_updateTime(){} // RVA: 0x1186FB0
        public void get_activeOrigin(){} // RVA: 0x87C0A0
        public void get_lastActiveOrigin(){} // RVA: 0x87C0A0
        public void get_changed(){} // RVA: 0x87D280
        public void set_changed(){} // RVA: 0x894750
        public void get_lastChanged(){} // RVA: 0x87D280
        public void set_lastChanged(){} // RVA: 0x894750
        public void get_activeDevice(){} // RVA: 0x6F177B0
        public void get_trackedDeviceIndex(){} // RVA: 0x6F17810
        public void get_renderModelComponentName(){} // RVA: 0x6F17830
        public void get_localizedOriginName(){} // RVA: 0x6F17850
        public void get_changedTime(){} // RVA: 0xCD64A0
        public void set_changedTime(){} // RVA: 0xD96F20
        public void get_lastOriginGetFrame(){} // RVA: 0xE9CE60
        public void set_lastOriginGetFrame(){} // RVA: 0xEA1260
        public void UpdateValue(){} // RVA: 0x894290
        public void Initialize(){} // RVA: 0x6F17870
        public void UpdateOriginTrackedDeviceInfo(){} // RVA: 0x6F179A0
        public void GetLocalizedOriginPart(){} // RVA: 0x6F17E10
        public void GetLocalizedOrigin(){} // RVA: 0x6F17EC0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class SteamVR_Action_In_Source[] : Array
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

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x87DD20
        public void OnAccessSource(){} // RVA: 0x8944F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x8944F0
        public void UpdateValues(){} // RVA: 0x894290
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B515F0
        public void IsUpdating(){} // RVA: 0x4B512F0
        public void ForceAddSourceToUpdateList(){} // RVA: 0x4B51440
        public void OnAccessSource(){} // RVA: 0x4B513B0
        public void .ctor(){} // RVA: 0x4B516E0
    }

    public class SteamVR_Action_In_Source_Map`1 : SteamVR_Action_Source_Map`1
    {
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
        public void get_changed(){} // RVA: 0x87D280
        public void get_lastChanged(){} // RVA: 0x87D280
        public void get_changedTime(){} // RVA: 0x890F90
        public void get_updateTime(){} // RVA: 0x890F90
        public void get_activeOrigin(){} // RVA: 0x87C0A0
        public void get_lastActiveOrigin(){} // RVA: 0x87C0A0
        public void get_activeDevice(){} // RVA: 0x87C130
        public void get_trackedDeviceIndex(){} // RVA: 0x87C130
        public void get_renderModelComponentName(){} // RVA: 0x87C0A0
        public void get_localizedOriginName(){} // RVA: 0x87C0A0
        public void UpdateValues(){} // RVA: 0x894290
        public void GetRenderModelComponentName(){} // RVA: 0x87C160
        public void GetActiveDevice(){} // RVA: 0x881C20
        public void GetDeviceIndex(){} // RVA: 0x881C20
        public void GetChanged(){} // RVA: 0x87DD20
        public void GetTimeLastChanged(){} // RVA: 0x891330
        public void GetLocalizedOriginPart(){} // RVA: 0x88B510
        public void GetLocalizedOrigin(){} // RVA: 0x87C160
        public void IsUpdating(){} // RVA: 0x87DD20
        public void ForceAddSourceToUpdateList(){} // RVA: 0x8944F0
        public void GetControllerType(){} // RVA: 0x87C160
        public void .ctor(){} // RVA: 0x894290
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

    public class SteamVR_Action_Pose : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F17FB0
        public void remove_onActiveChange(){} // RVA: 0x6F18030
        public void add_onActiveBindingChange(){} // RVA: 0x6F180B0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F18200
        public void add_onChange(){} // RVA: 0x6F18280
        public void remove_onChange(){} // RVA: 0x6F18300
        public void add_onUpdate(){} // RVA: 0x6F18380
        public void remove_onUpdate(){} // RVA: 0x6F18400
        public void add_onTrackingChanged(){} // RVA: 0x6F18480
        public void remove_onTrackingChanged(){} // RVA: 0x6F18500
        public void add_onValidPoseChanged(){} // RVA: 0x6F18580
        public void remove_onValidPoseChanged(){} // RVA: 0x6F18600
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F18680
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F18700
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x6F18780
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x6F18800
        public void AddOnTrackingChanged(){} // RVA: 0x6F18880
        public void RemoveOnTrackingChanged(){} // RVA: 0x6F18900
        public void AddOnValidPoseChanged(){} // RVA: 0x6F18980
        public void RemoveOnValidPoseChanged(){} // RVA: 0x6F18A00
        public void AddOnActiveChangeListener(){} // RVA: 0x6F18A80
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F18B00
        public void AddOnChangeListener(){} // RVA: 0x6F18B80
        public void RemoveOnChangeListener(){} // RVA: 0x6F18C00
        public void AddOnUpdateListener(){} // RVA: 0x6F18C80
        public void RemoveOnUpdateListener(){} // RVA: 0x6F18D00
        public void RemoveAllListeners(){} // RVA: 0x6F18D80
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F18E00
        public void SetTrackingUniverseOrigin(){} // RVA: 0x6F18E40
        public void .ctor(){} // RVA: 0x6F18EC0
    }

    public class SteamVR_Action_Pose[] : Array
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

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x895710
        public void get_localPosition(){} // RVA: 0x87BEB0
        public void get_localRotation(){} // RVA: 0x87BEB0
        public void get_trackingState(){} // RVA: 0x87C130
        public void get_velocity(){} // RVA: 0x87BEB0
        public void get_angularVelocity(){} // RVA: 0x87BEB0
        public void get_poseIsValid(){} // RVA: 0x87D280
        public void get_deviceIsConnected(){} // RVA: 0x87D280
        public void get_lastLocalPosition(){} // RVA: 0x87BEB0
        public void get_lastLocalRotation(){} // RVA: 0x87BEB0
        public void get_lastTrackingState(){} // RVA: 0x87C130
        public void get_lastVelocity(){} // RVA: 0x87BEB0
        public void get_lastAngularVelocity(){} // RVA: 0x87BEB0
        public void get_lastPoseIsValid(){} // RVA: 0x87D280
        public void get_lastDeviceIsConnected(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894290
        public void UpdateValues(){} // RVA: 0x894750
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0xA94080
        public void GetPoseAtTimeOffset(){} // RVA: 0xA94080
        public void UpdateTransform(){} // RVA: 0x895750
        public void GetLocalPosition(){} // RVA: 0x87BF40
        public void GetLocalRotation(){} // RVA: 0x87BF40
        public void GetVelocity(){} // RVA: 0x87BF40
        public void GetAngularVelocity(){} // RVA: 0x87BF40
        public void GetDeviceIsConnected(){} // RVA: 0x87DD20
        public void GetPoseIsValid(){} // RVA: 0x87DD20
        public void GetTrackingResult(){} // RVA: 0x881C20
        public void GetLastLocalPosition(){} // RVA: 0x87BF40
        public void GetLastLocalRotation(){} // RVA: 0x87BF40
        public void GetLastVelocity(){} // RVA: 0x87BF40
        public void GetLastAngularVelocity(){} // RVA: 0x87BF40
        public void GetLastDeviceIsConnected(){} // RVA: 0x87DD20
        public void GetLastPoseIsValid(){} // RVA: 0x87DD20
        public void GetLastTrackingResult(){} // RVA: 0x881C20
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x4B52080
        public void get_localPosition(){} // RVA: 0x4B52250
        public void get_localRotation(){} // RVA: 0x4B522A0
        public void get_trackingState(){} // RVA: 0x4B522F0
        public void get_velocity(){} // RVA: 0x4B52330
        public void get_angularVelocity(){} // RVA: 0x4B52380
        public void get_poseIsValid(){} // RVA: 0x4B523D0
        public void get_deviceIsConnected(){} // RVA: 0x4B52410
        public void get_lastLocalPosition(){} // RVA: 0x4B52450
        public void get_lastLocalRotation(){} // RVA: 0x4B524A0
        public void get_lastTrackingState(){} // RVA: 0x4B524F0
        public void get_lastVelocity(){} // RVA: 0x4B52530
        public void get_lastAngularVelocity(){} // RVA: 0x4B52580
        public void get_lastPoseIsValid(){} // RVA: 0x4B525D0
        public void get_lastDeviceIsConnected(){} // RVA: 0x4B52610
        public void .ctor(){} // RVA: 0x4B52650
        public void UpdateValues(){} // RVA: 0x4B52670
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x4B526A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x4B52700
        public void UpdateTransform(){} // RVA: 0x4B52780
        public void GetLocalPosition(){} // RVA: 0x4B52910
        public void GetLocalRotation(){} // RVA: 0x4B52970
        public void GetVelocity(){} // RVA: 0x4B529C0
        public void GetAngularVelocity(){} // RVA: 0x4B52A20
        public void GetDeviceIsConnected(){} // RVA: 0x4B52A80
        public void GetPoseIsValid(){} // RVA: 0x4B52AC0
        public void GetTrackingResult(){} // RVA: 0x4B52B00
        public void GetLastLocalPosition(){} // RVA: 0x4B52B40
        public void GetLastLocalRotation(){} // RVA: 0x4B52BA0
        public void GetLastVelocity(){} // RVA: 0x4B52BF0
        public void GetLastAngularVelocity(){} // RVA: 0x4B52C50
        public void GetLastDeviceIsConnected(){} // RVA: 0x4B52CB0
        public void GetLastPoseIsValid(){} // RVA: 0x4B52CF0
        public void GetLastTrackingResult(){} // RVA: 0x4B52D30
    }

    public class SteamVR_Action_Pose_Base`2 : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void SetUniverseOrigin(){} // RVA: 0x4B52080
        public void get_localPosition(){} // RVA: 0x4B52250
        public void get_localRotation(){} // RVA: 0x4B522A0
        public void get_trackingState(){} // RVA: 0x4B522F0
        public void get_velocity(){} // RVA: 0x4B52330
        public void get_angularVelocity(){} // RVA: 0x4B52380
        public void get_poseIsValid(){} // RVA: 0x4B523D0
        public void get_deviceIsConnected(){} // RVA: 0x4B52410
        public void get_lastLocalPosition(){} // RVA: 0x4B52450
        public void get_lastLocalRotation(){} // RVA: 0x4B524A0
        public void get_lastTrackingState(){} // RVA: 0x4B524F0
        public void get_lastVelocity(){} // RVA: 0x4B52530
        public void get_lastAngularVelocity(){} // RVA: 0x4B52580
        public void get_lastPoseIsValid(){} // RVA: 0x4B525D0
        public void get_lastDeviceIsConnected(){} // RVA: 0x4B52610
        public void .ctor(){} // RVA: 0x4B52650
        public void UpdateValues(){} // RVA: 0x4B52670
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x4B526A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x4B52700
        public void UpdateTransform(){} // RVA: 0x4B52780
        public void GetLocalPosition(){} // RVA: 0x4B52910
        public void GetLocalRotation(){} // RVA: 0x4B52970
        public void GetVelocity(){} // RVA: 0x4B529C0
        public void GetAngularVelocity(){} // RVA: 0x4B52A20
        public void GetDeviceIsConnected(){} // RVA: 0x4B52A80
        public void GetPoseIsValid(){} // RVA: 0x4B52AC0
        public void GetTrackingResult(){} // RVA: 0x4B52B00
        public void GetLastLocalPosition(){} // RVA: 0x4B52B40
        public void GetLastLocalRotation(){} // RVA: 0x4B52BA0
        public void GetLastVelocity(){} // RVA: 0x4B52BF0
        public void GetLastAngularVelocity(){} // RVA: 0x4B52C50
        public void GetLastDeviceIsConnected(){} // RVA: 0x4B52CB0
        public void GetLastPoseIsValid(){} // RVA: 0x4B52CF0
        public void GetLastTrackingResult(){} // RVA: 0x4B52D30
    }

    public class SteamVR_Action_Pose_Source : SteamVR_Action_In_Source
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F192C0
        public void remove_onActiveChange(){} // RVA: 0x6F193C0
        public void add_onActiveBindingChange(){} // RVA: 0x6F194C0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F195C0
        public void add_onChange(){} // RVA: 0x6F196C0
        public void remove_onChange(){} // RVA: 0x6F197C0
        public void add_onUpdate(){} // RVA: 0x6F198C0
        public void remove_onUpdate(){} // RVA: 0x6F199C0
        public void add_onTrackingChanged(){} // RVA: 0x6F19AC0
        public void remove_onTrackingChanged(){} // RVA: 0x6F19BC0
        public void add_onValidPoseChanged(){} // RVA: 0x6F19CC0
        public void remove_onValidPoseChanged(){} // RVA: 0x6F19DC0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F19EC0
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F19FC0
        public void get_changed(){} // RVA: 0x6E15480
        public void set_changed(){} // RVA: 0x6E15490
        public void get_lastChanged(){} // RVA: 0x6F1A0C0
        public void set_lastChanged(){} // RVA: 0x6F1A0D0
        public void get_activeOrigin(){} // RVA: 0x6F1A0E0
        public void get_lastActiveOrigin(){} // RVA: 0x166A290
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6F1A120
        public void get_lastActive(){} // RVA: 0x6F1A130
        public void set_lastActive(){} // RVA: 0x6F1A140
        public void get_lastActiveBinding(){} // RVA: 0x1F7F9C0
        public void get_trackingState(){} // RVA: 0xBA31A0
        public void get_lastTrackingState(){} // RVA: 0x6DE8F00
        public void get_poseIsValid(){} // RVA: 0x1F7AC70
        public void get_lastPoseIsValid(){} // RVA: 0x6F1A150
        public void get_deviceIsConnected(){} // RVA: 0x1F70A60
        public void get_lastDeviceIsConnected(){} // RVA: 0x6F1A160
        public void get_localPosition(){} // RVA: 0x6F1A170
        public void set_localPosition(){} // RVA: 0x6F1A190
        public void get_localRotation(){} // RVA: 0x6F1A1B0
        public void set_localRotation(){} // RVA: 0x6F1A1C0
        public void get_lastLocalPosition(){} // RVA: 0x6F1A1D0
        public void set_lastLocalPosition(){} // RVA: 0x6F1A1F0
        public void get_lastLocalRotation(){} // RVA: 0x6F1A210
        public void set_lastLocalRotation(){} // RVA: 0x6F1A220
        public void get_velocity(){} // RVA: 0x6F1A230
        public void set_velocity(){} // RVA: 0x6F1A250
        public void get_lastVelocity(){} // RVA: 0x6F1A270
        public void set_lastVelocity(){} // RVA: 0x6F1A290
        public void get_angularVelocity(){} // RVA: 0x6F1A2B0
        public void set_angularVelocity(){} // RVA: 0x6F1A2D0
        public void get_lastAngularVelocity(){} // RVA: 0x6F1A2F0
        public void set_lastAngularVelocity(){} // RVA: 0x6F1A310
        public void Preinitialize(){} // RVA: 0x6F1A330
        public void Initialize(){} // RVA: 0x6F1A480
        public void RemoveAllListeners(){} // RVA: 0x6F1A5A0
        public void UpdateValue(){} // RVA: 0x6F1AA00
        public void SetCacheVariables(){} // RVA: 0x6F1B1B0
        public void GetChanged(){} // RVA: 0x6F1B2D0
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x6F1B5A0
        public void GetPoseAtTimeOffset(){} // RVA: 0x6F1B9C0
        public void UpdateTransform(){} // RVA: 0x6F1BED0
        public void CheckAndSendEvents(){} // RVA: 0x6F1C030
        public void GetUnityCoordinateVelocity(){} // RVA: 0x6F1C320
        public void GetUnityCoordinateAngularVelocity(){} // RVA: 0x6F1C340
        public void .ctor(){} // RVA: 0x6F1C370
        public void .cctor(){} // RVA: 0x6F1C3C0
    }

    public class SteamVR_Action_Pose_Source[] : Array
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

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void SetTrackingUniverseOrigin(){} // RVA: 0x8944F0
        public void UpdateValues(){} // RVA: 0x894750
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B52DE0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x4B52D70
        public void .ctor(){} // RVA: 0x4B52EE0
    }

    public class SteamVR_Action_Pose_Source_Map`1 : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x4B52DE0
        public void SetTrackingUniverseOrigin(){} // RVA: 0x4B52D70
        public void .ctor(){} // RVA: 0x4B52EE0
    }

    public class SteamVR_Action_Single : SteamVR_Action_In`2
    {
        // ── Methods ──
        public void add_onChange(){} // RVA: 0x6F1C420
        public void remove_onChange(){} // RVA: 0x6F1C4A0
        public void add_onUpdate(){} // RVA: 0x6F1C520
        public void remove_onUpdate(){} // RVA: 0x6F1C5A0
        public void add_onAxis(){} // RVA: 0x6F1C620
        public void remove_onAxis(){} // RVA: 0x6F1C6A0
        public void add_onActiveChange(){} // RVA: 0x6F1C720
        public void remove_onActiveChange(){} // RVA: 0x6F1C7A0
        public void add_onActiveBindingChange(){} // RVA: 0x6F1C820
        public void remove_onActiveBindingChange(){} // RVA: 0x6F1C8A0
        public void get_axis(){} // RVA: 0x6F1C920
        public void get_lastAxis(){} // RVA: 0x6F1C9B0
        public void get_delta(){} // RVA: 0x6F1CA40
        public void get_lastDelta(){} // RVA: 0x6F1CAD0
        public void .ctor(){} // RVA: 0x6F1CB60
        public void GetAxis(){} // RVA: 0x6F1CBA0
        public void GetAxisDelta(){} // RVA: 0x6F1CC40
        public void GetLastAxis(){} // RVA: 0x6F1CCE0
        public void GetLastAxisDelta(){} // RVA: 0x6F1CD80
        public void AddOnActiveChangeListener(){} // RVA: 0x6F1CE20
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F1CEA0
        public void AddOnActiveBindingChangeListener(){} // RVA: 0x6F1CF20
        public void RemoveOnActiveBindingChangeListener(){} // RVA: 0x6F1CFA0
        public void AddOnChangeListener(){} // RVA: 0x6F1D020
        public void RemoveOnChangeListener(){} // RVA: 0x6F1D0A0
        public void AddOnUpdateListener(){} // RVA: 0x6F1D120
        public void RemoveOnUpdateListener(){} // RVA: 0x6F1D1A0
        public void AddOnAxisListener(){} // RVA: 0x6F1D220
        public void RemoveOnAxisListener(){} // RVA: 0x6F1D2A0
        public void RemoveAllListeners(){} // RVA: 0x6F1D320
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F1D390
    }

    public class SteamVR_Action_Single_Source : SteamVR_Action_In_Source
    {
        // ── Methods ──
        public void add_onAxis(){} // RVA: 0x6F1D6F0
        public void remove_onAxis(){} // RVA: 0x6F1D7F0
        public void add_onActiveChange(){} // RVA: 0x6F1D8F0
        public void remove_onActiveChange(){} // RVA: 0x6F1D9F0
        public void add_onActiveBindingChange(){} // RVA: 0x6F1DAF0
        public void remove_onActiveBindingChange(){} // RVA: 0x6F1DBF0
        public void add_onChange(){} // RVA: 0x6F1DCF0
        public void remove_onChange(){} // RVA: 0x6F1DDF0
        public void add_onUpdate(){} // RVA: 0x6F1DEF0
        public void remove_onUpdate(){} // RVA: 0x6F1DFF0
        public void get_axis(){} // RVA: 0x6F1E0F0
        public void get_lastAxis(){} // RVA: 0x6F1E130
        public void get_delta(){} // RVA: 0x6F1E170
        public void get_lastDelta(){} // RVA: 0x6F1E1B0
        public void get_changed(){} // RVA: 0x6F1E1F0
        public void set_changed(){} // RVA: 0x6F1E200
        public void get_lastChanged(){} // RVA: 0x6F1E210
        public void set_lastChanged(){} // RVA: 0x6F1E220
        public void get_activeOrigin(){} // RVA: 0x6F1E230
        public void get_lastActiveOrigin(){} // RVA: 0x1655DD0
        public void get_active(){} // RVA: 0x6F16990
        public void get_activeBinding(){} // RVA: 0x6F16A30
        public void get_lastActive(){} // RVA: 0x6F1E270
        public void set_lastActive(){} // RVA: 0x6F1E280
        public void get_lastActiveBinding(){} // RVA: 0x6F168F0
        public void Preinitialize(){} // RVA: 0x6F1E290
        public void Initialize(){} // RVA: 0x6F1E420
        public void RemoveAllListeners(){} // RVA: 0x6F1E510
        public void UpdateValue(){} // RVA: 0x6F1E820
        public void .ctor(){} // RVA: 0x6F1F020
    }

    public class SteamVR_Action_Single_Source[] : Array
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

    public class SteamVR_Action_Single_Source_Map : SteamVR_Action_In_Source_Map`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F1D6B0
    }

    public class SteamVR_Action_Skeleton : SteamVR_Action_Pose_Base`2
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F1F070
        public void remove_onActiveChange(){} // RVA: 0x6F1F0F0
        public void add_onActiveBindingChange(){} // RVA: 0x6F1F170
        public void remove_onActiveBindingChange(){} // RVA: 0x6F1F2C0
        public void add_onChange(){} // RVA: 0x6F1F340
        public void remove_onChange(){} // RVA: 0x6F1F3C0
        public void add_onUpdate(){} // RVA: 0x6F1F440
        public void remove_onUpdate(){} // RVA: 0x6F1F4C0
        public void add_onTrackingChanged(){} // RVA: 0x6F1F540
        public void remove_onTrackingChanged(){} // RVA: 0x6F1F5C0
        public void add_onValidPoseChanged(){} // RVA: 0x6F1F640
        public void remove_onValidPoseChanged(){} // RVA: 0x6F1F6C0
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F1F740
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F1F7C0
        public void .ctor(){} // RVA: 0x6F1F840
        public void UpdateValue(){} // RVA: 0x6F1F890
        public void UpdateValueWithoutEvents(){} // RVA: 0x6F1F910
        public void UpdateTransform(){} // RVA: 0x6F1F990
        public void get_bonePositions(){} // RVA: 0x6F1FB40
        public void get_boneRotations(){} // RVA: 0x6F1FBA0
        public void get_lastBonePositions(){} // RVA: 0x6F1FC00
        public void get_lastBoneRotations(){} // RVA: 0x6F1FC60
        public void get_rangeOfMotion(){} // RVA: 0x6F1FCC0
        public void set_rangeOfMotion(){} // RVA: 0x6F1FD20
        public void get_skeletalTransformSpace(){} // RVA: 0x6F1FD90
        public void set_skeletalTransformSpace(){} // RVA: 0x6F1FDF0
        public void get_summaryDataType(){} // RVA: 0x6F1FE60
        public void set_summaryDataType(){} // RVA: 0x6F1FEC0
        public void get_skeletalTrackingLevel(){} // RVA: 0x6F1FF30
        public void get_thumbCurl(){} // RVA: 0x6F1FFA0
        public void get_indexCurl(){} // RVA: 0x6F20020
        public void get_middleCurl(){} // RVA: 0x6F200A0
        public void get_ringCurl(){} // RVA: 0x6F20120
        public void get_pinkyCurl(){} // RVA: 0x6F201A0
        public void get_thumbIndexSplay(){} // RVA: 0x6F20220
        public void get_indexMiddleSplay(){} // RVA: 0x6F202A0
        public void get_middleRingSplay(){} // RVA: 0x6F20320
        public void get_ringPinkySplay(){} // RVA: 0x6F203A0
        public void get_lastThumbCurl(){} // RVA: 0x6F20420
        public void get_lastIndexCurl(){} // RVA: 0x6F204A0
        public void get_lastMiddleCurl(){} // RVA: 0x6F20520
        public void get_lastRingCurl(){} // RVA: 0x6F205A0
        public void get_lastPinkyCurl(){} // RVA: 0x6F20620
        public void get_lastThumbIndexSplay(){} // RVA: 0x6F206A0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x6F20720
        public void get_lastMiddleRingSplay(){} // RVA: 0x6F207A0
        public void get_lastRingPinkySplay(){} // RVA: 0x6F20820
        public void get_fingerCurls(){} // RVA: 0x6F208A0
        public void get_fingerSplays(){} // RVA: 0x6F20900
        public void get_lastFingerCurls(){} // RVA: 0x6F20960
        public void get_lastFingerSplays(){} // RVA: 0x6F209C0
        public void get_poseChanged(){} // RVA: 0x6F20A20
        public void get_onlyUpdateSummaryData(){} // RVA: 0x6F20A80
        public void set_onlyUpdateSummaryData(){} // RVA: 0x6F20AE0
        public void GetActive(){} // RVA: 0x6F20B50
        public void GetSetActive(){} // RVA: 0x6F0F940
        public void GetVelocitiesAtTimeOffset(){} // RVA: 0x6F20BC0
        public void GetPoseAtTimeOffset(){} // RVA: 0x6F20C60
        public void GetLocalPosition(){} // RVA: 0x6F20D00
        public void GetLocalRotation(){} // RVA: 0x6F20D80
        public void GetVelocity(){} // RVA: 0x6F20E00
        public void GetAngularVelocity(){} // RVA: 0x6F20E80
        public void GetDeviceIsConnected(){} // RVA: 0x6F20F00
        public void GetPoseIsValid(){} // RVA: 0x6F20F60
        public void GetTrackingResult(){} // RVA: 0x6F20FC0
        public void GetLastLocalPosition(){} // RVA: 0x6F21020
        public void GetLastLocalRotation(){} // RVA: 0x6F210A0
        public void GetLastVelocity(){} // RVA: 0x6F21120
        public void GetLastAngularVelocity(){} // RVA: 0x6F211A0
        public void GetLastDeviceIsConnected(){} // RVA: 0x6F21220
        public void GetLastPoseIsValid(){} // RVA: 0x6F21280
        public void GetLastTrackingResult(){} // RVA: 0x6F212E0
        public void get_boneCount(){} // RVA: 0x6F21340
        public void GetBonePositions(){} // RVA: 0x6F213B0
        public void GetBoneRotations(){} // RVA: 0x6F214A0
        public void GetLastBonePositions(){} // RVA: 0x6F21590
        public void GetLastBoneRotations(){} // RVA: 0x6F21680
        public void SetRangeOfMotion(){} // RVA: 0x6F21770
        public void SetSkeletalTransformSpace(){} // RVA: 0x6F217E0
        public void GetBoneCount(){} // RVA: 0x6F21340
        public void GetBoneHierarchy(){} // RVA: 0x6F21850
        public void GetBoneName(){} // RVA: 0x6F218C0
        public void GetReferenceTransforms(){} // RVA: 0x6F21930
        public void GetSkeletalTrackingLevel(){} // RVA: 0x6F219B0
        public void GetFingerCurls(){} // RVA: 0x6F21A20
        public void GetLastFingerCurls(){} // RVA: 0x6F21B10
        public void GetFingerSplays(){} // RVA: 0x6F21C00
        public void GetLastFingerSplays(){} // RVA: 0x6F21CF0
        public void GetFingerCurl(){} // RVA: 0x6F21DE0
        public void GetSplay(){} // RVA: 0x6F21E70
        public void GetLastFingerCurl(){} // RVA: 0x6F21F00
        public void GetLastSplay(){} // RVA: 0x6F21F90
        public void GetLocalizedName(){} // RVA: 0x6F22020
        public void RemoveAllListeners(){} // RVA: 0x6F220A0
        public void AddOnDeviceConnectedChanged(){} // RVA: 0x6F22120
        public void RemoveOnDeviceConnectedChanged(){} // RVA: 0x6F221A0
        public void AddOnTrackingChanged(){} // RVA: 0x6F22220
        public void RemoveOnTrackingChanged(){} // RVA: 0x6F222A0
        public void AddOnValidPoseChanged(){} // RVA: 0x6F22320
        public void RemoveOnValidPoseChanged(){} // RVA: 0x6F223A0
        public void AddOnActiveChangeListener(){} // RVA: 0x6F22420
        public void RemoveOnActiveChangeListener(){} // RVA: 0x6F224A0
        public void AddOnChangeListener(){} // RVA: 0x6F22520
        public void RemoveOnChangeListener(){} // RVA: 0x6F225A0
        public void AddOnUpdateListener(){} // RVA: 0x6F22620
        public void RemoveOnUpdateListener(){} // RVA: 0x6F226A0
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0xB43310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x6F22720
        public void .cctor(){} // RVA: 0x6F22760
    }

    public class SteamVR_Action_Skeleton[] : Array
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

    public class SteamVR_Action_Skeleton_Source : SteamVR_Action_Pose_Source
    {
        // ── Methods ──
        public void add_onActiveChange(){} // RVA: 0x6F22950
        public void remove_onActiveChange(){} // RVA: 0x6F22A50
        public void add_onActiveBindingChange(){} // RVA: 0x6F22B50
        public void remove_onActiveBindingChange(){} // RVA: 0x6F22C50
        public void add_onChange(){} // RVA: 0x6F22D50
        public void remove_onChange(){} // RVA: 0x6F22E50
        public void add_onUpdate(){} // RVA: 0x6F22F50
        public void remove_onUpdate(){} // RVA: 0x6F23050
        public void add_onTrackingChanged(){} // RVA: 0x6F23150
        public void remove_onTrackingChanged(){} // RVA: 0x6F23250
        public void add_onValidPoseChanged(){} // RVA: 0x6F23350
        public void remove_onValidPoseChanged(){} // RVA: 0x6F23450
        public void add_onDeviceConnectedChanged(){} // RVA: 0x6F23550
        public void remove_onDeviceConnectedChanged(){} // RVA: 0x6F23650
        public void get_activeBinding(){} // RVA: 0x6F23750
        public void get_lastActiveBinding(){} // RVA: 0x6F23760
        public void get_bonePositions(){} // RVA: 0x164CA60
        public void set_bonePositions(){} // RVA: 0x163D120
        public void get_boneRotations(){} // RVA: 0x165BD90
        public void set_boneRotations(){} // RVA: 0x1654570
        public void get_lastBonePositions(){} // RVA: 0x165B400
        public void set_lastBonePositions(){} // RVA: 0x16672F0
        public void get_lastBoneRotations(){} // RVA: 0x165B7C0
        public void set_lastBoneRotations(){} // RVA: 0x1655D70
        public void get_rangeOfMotion(){} // RVA: 0x6F23770
        public void set_rangeOfMotion(){} // RVA: 0x6F23780
        public void get_skeletalTransformSpace(){} // RVA: 0x6F23790
        public void set_skeletalTransformSpace(){} // RVA: 0x6F237A0
        public void get_summaryDataType(){} // RVA: 0x6F237B0
        public void set_summaryDataType(){} // RVA: 0x6F237C0
        public void get_thumbCurl(){} // RVA: 0x6F237D0
        public void get_indexCurl(){} // RVA: 0x6F23800
        public void get_middleCurl(){} // RVA: 0x6F23830
        public void get_ringCurl(){} // RVA: 0x6F23860
        public void get_pinkyCurl(){} // RVA: 0x6F23890
        public void get_thumbIndexSplay(){} // RVA: 0x6F238C0
        public void get_indexMiddleSplay(){} // RVA: 0x6F238F0
        public void get_middleRingSplay(){} // RVA: 0x6F23920
        public void get_ringPinkySplay(){} // RVA: 0x6F23950
        public void get_lastThumbCurl(){} // RVA: 0x6F23980
        public void get_lastIndexCurl(){} // RVA: 0x6F239B0
        public void get_lastMiddleCurl(){} // RVA: 0x6F239E0
        public void get_lastRingCurl(){} // RVA: 0x6F23A10
        public void get_lastPinkyCurl(){} // RVA: 0x6F23A40
        public void get_lastThumbIndexSplay(){} // RVA: 0x6F23A70
        public void get_lastIndexMiddleSplay(){} // RVA: 0x6F23AA0
        public void get_lastMiddleRingSplay(){} // RVA: 0x6F23AD0
        public void get_lastRingPinkySplay(){} // RVA: 0x6F23B00
        public void get_fingerCurls(){} // RVA: 0x165B290
        public void set_fingerCurls(){} // RVA: 0x163AD00
        public void get_fingerSplays(){} // RVA: 0x16683A0
        public void set_fingerSplays(){} // RVA: 0x1658B20
        public void get_lastFingerCurls(){} // RVA: 0x1661B40
        public void set_lastFingerCurls(){} // RVA: 0x1664510
        public void get_lastFingerSplays(){} // RVA: 0x1175290
        public void set_lastFingerSplays(){} // RVA: 0x166AA40
        public void get_poseChanged(){} // RVA: 0x6F23B30
        public void set_poseChanged(){} // RVA: 0x6F23B40
        public void get_onlyUpdateSummaryData(){} // RVA: 0x6F23B50
        public void set_onlyUpdateSummaryData(){} // RVA: 0x6F23B60
        public void Preinitialize(){} // RVA: 0x6F23B70
        public void Initialize(){} // RVA: 0x6F24240
        public void RemoveAllListeners(){} // RVA: 0x6F24440
        public void UpdateValue(){} // RVA: 0x6F24880
        public void get_boneCount(){} // RVA: 0x6F25760
        public void GetBoneCount(){} // RVA: 0x6F25770
        public void get_boneHierarchy(){} // RVA: 0x6F25A40
        public void GetBoneHierarchy(){} // RVA: 0x6F25A50
        public void GetBoneName(){} // RVA: 0x6F25D50
        public void GetReferenceTransforms(){} // RVA: 0x6F260C0
        public void get_skeletalTrackingLevel(){} // RVA: 0x6F266D0
        public void GetSkeletalTrackingLevel(){} // RVA: 0x6F266E0
        public void GetSkeletalSummaryData(){} // RVA: 0x6F26930
        public void UpdateSkeletalSummaryData(){} // RVA: 0x6F26990
        public void CheckAndSendEvents(){} // RVA: 0x6F26D40
        public void .ctor(){} // RVA: 0x6F26F80
    }

    public class SteamVR_Action_Skeleton_Source[] : Array
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

    public class SteamVR_Action_Skeleton_Source_Map : SteamVR_Action_Pose_Source_Map`1
    {
        // ── Methods ──
        public void GetSourceElementForIndexer(){} // RVA: 0x6F228D0
        public void .ctor(){} // RVA: 0x6F22900
    }

    public class SteamVR_Action_Source : Object
    {
        // ── Methods ──
        public void get_fullPath(){} // RVA: 0x6F10B40
        public void get_handle(){} // RVA: 0x6F10B70
        public void get_actionSet(){} // RVA: 0x6F10BA0
        public void get_direction(){} // RVA: 0x6F10BD0
        public void get_inputSource(){} // RVA: 0xB8F8F0
        public void set_inputSource(){} // RVA: 0xB460A0
        public void get_setActive(){} // RVA: 0x6F10C00
        public void get_active(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void set_lastActive(){} // RVA: 0x894750
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void Preinitialize(){} // RVA: 0x6F10C90
        public void .ctor(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x6F10CF0
    }

    public class SteamVR_Action_Source_Map : Object
    {
        // ── Methods ──
        public void get_fullPath(){} // RVA: 0xB5DBF0
        public void set_fullPath(){} // RVA: 0xB44D60
        public void get_handle(){} // RVA: 0xB465B0
        public void set_handle(){} // RVA: 0x15428E0
        public void get_actionSet(){} // RVA: 0xB700F0
        public void set_actionSet(){} // RVA: 0xB70100
        public void get_direction(){} // RVA: 0x1065D50
        public void set_direction(){} // RVA: 0x13233D0
        public void PreInitialize(){} // RVA: 0x6F10120
        public void PreinitializeMap(){} // RVA: 0x895750
        public void Initialize(){} // RVA: 0x6F10390
        public void GetActionSetPath(){} // RVA: 0x6F10590
        public void GetActionDirection(){} // RVA: 0x6F10610
        public void .ctor(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6F10820
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
        // ── Methods ──
        public void get_Item(){} // RVA: 0xA94080
        public void OnAccessSource(){} // RVA: 0x8944F0
        public void Initialize(){} // RVA: 0x894290
        public void PreinitializeMap(){} // RVA: 0x895750
        public void GetSourceElementForIndexer(){} // RVA: 0xA94080
        public void .ctor(){} // RVA: 0x894290
    }

    public class SteamVR_Action_Source_Map`1 : SteamVR_Action_Source_Map
    {
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
        // ── Methods ──
        public void get_Item(){} // RVA: 0x4B52F00
        public void OnAccessSource(){} // RVA: 0xB43310
        public void Initialize(){} // RVA: 0x4B52F20
        public void PreinitializeMap(){} // RVA: 0x4B52FB0
        public void GetSourceElementForIndexer(){} // RVA: 0x4B53050
        public void .ctor(){} // RVA: 0x4B530A0
    }

    public class SteamVR_Action_Vector2_Source : SteamVR_Action_In_Source
    {
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
        // ── Methods ──
        public void get_Item(){} // RVA: 0xA94080
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void get_actionSet(){} // RVA: 0x87C0A0
        public void get_direction(){} // RVA: 0x87C130
        public void get_active(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void PreInitialize(){} // RVA: 0x894320
        public void CreateUninitialized(){} // RVA: 0x89C370
        public void TryNeedsInitData(){} // RVA: 0x87C0A0
        public void Initialize(){} // RVA: 0x8949A0
        public void GetSourceMap(){} // RVA: 0x87C0A0
        public void InitializeCopy(){} // RVA: 0x8943B0
        public void InitAfterDeserialize(){} // RVA: 0x894290
        public void GetActive(){} // RVA: 0x87DD20
        public void GetActiveBinding(){} // RVA: 0x87DD20
        public void GetLastActive(){} // RVA: 0x87DD20
        public void GetLastActiveBinding(){} // RVA: 0x87DD20
        public void GetActionBindingInfo(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class SteamVR_Action`2 : SteamVR_Action
    {
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

    public class SteamVR_Behaviour_SkeletonEvent : UnityEvent`2
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F670
    }

    public class SteamVR_Behaviour_Skeleton_ConnectedChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F700
    }

    public class SteamVR_Behaviour_Skeleton_TrackingChangedEvent : UnityEvent`3
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F0F790
    }

    public class SteamVR_Camera[] : Array
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

    public class SteamVR_ExternalCamera_LegacyManager : Object
    {
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

    public class SteamVR_RingBuffer`1 : Object
    {
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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4B54750
        public void Add(){} // RVA: 0x4B547F0
        public void StepForward(){} // RVA: 0x4B54830
        public void GetAtIndex(){} // RVA: 0x4B548E0
        public void GetLast(){} // RVA: 0xB700F0
        public void GetLastIndex(){} // RVA: 0x4B54920
        public void Clear(){} // RVA: 0x4B54950
    }

    public class SteamVR_Skeleton_PoseSnapshot : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6F65690
        public void CopyFrom(){} // RVA: 0x6F65830
    }

    public class SteamVR_Skeleton_Pose[] : Array
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

    public class SteamVR_Skeleton_Pose_Hand : Object
    {
        // ── Methods ──
        public void GetFingerExtensionType(){} // RVA: 0x6F617B0
        public void .ctor(){} // RVA: 0x6F61880
        public void GetMovementTypeForBone(){} // RVA: 0x6F61890
    }

    public class SteamVR_TrackedCamera : Object
    {
        // ── Methods ──
        public void Distorted(){} // RVA: 0x6F8FB80
        public void Undistorted(){} // RVA: 0x6F8FD20
        public void Source(){} // RVA: 0x6F8FED0
        public void Stream(){} // RVA: 0x6F90210
        public void .ctor(){} // RVA: 0xB43310
    }

}