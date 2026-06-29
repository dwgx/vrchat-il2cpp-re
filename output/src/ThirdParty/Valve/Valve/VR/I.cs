// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 17
// Methods: 161

namespace ThirdParty.Valve.Valve.VR
{
    public class ISteamVR_Action
    {
        // ── Methods ──
        public void GetActive(){} // RVA: 0x87DD20
        public void GetShortName(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_ActionSet
    {
        // ── Methods ──
        public void get_allActions(){} // RVA: 0x87C0A0
        public void get_nonVisualInActions(){} // RVA: 0x87C0A0
        public void get_visualActions(){} // RVA: 0x87C0A0
        public void get_poseActions(){} // RVA: 0x87C0A0
        public void get_skeletonActions(){} // RVA: 0x87C0A0
        public void get_outActionArray(){} // RVA: 0x87C0A0
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_usage(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void ReadRawSetActive(){} // RVA: 0x87DD20
        public void ReadRawSetLastChanged(){} // RVA: 0x891330
        public void ReadRawSetPriority(){} // RVA: 0x881C20
        public void IsActive(){} // RVA: 0x87DD20
        public void GetTimeLastChanged(){} // RVA: 0x891330
        public void Activate(){} // RVA: 0x896840
        public void Deactivate(){} // RVA: 0x8944F0
        public void GetShortName(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_Action_Boolean
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x87D280
        public void get_stateDown(){} // RVA: 0x87D280
        public void get_stateUp(){} // RVA: 0x87D280
        public void get_lastState(){} // RVA: 0x87D280
        public void get_lastStateDown(){} // RVA: 0x87D280
        public void get_lastStateUp(){} // RVA: 0x87D280
    }

    public class ISteamVR_Action_In
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x894290
        public void GetRenderModelComponentName(){} // RVA: 0x87C160
        public void GetActiveDevice(){} // RVA: 0x881C20
        public void GetDeviceIndex(){} // RVA: 0x881C20
        public void GetChanged(){} // RVA: 0x87DD20
        public void GetLocalizedOriginPart(){} // RVA: 0x88B510
        public void GetLocalizedOrigin(){} // RVA: 0x87C160
    }

    public class ISteamVR_Action_In[] : Array
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

    public class ISteamVR_Action_In_Source
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
    }

    public class ISteamVR_Action_Out[] : Array
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

    public class ISteamVR_Action_Pose
    {
        // ── Methods ──
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
    }

    public class ISteamVR_Action_Single
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x890F90
        public void get_lastAxis(){} // RVA: 0x890F90
        public void get_delta(){} // RVA: 0x890F90
        public void get_lastDelta(){} // RVA: 0x890F90
    }

    public class ISteamVR_Action_Skeleton_Source
    {
        // ── Methods ──
        public void get_skeletalTrackingLevel(){} // RVA: 0x87C130
        public void get_bonePositions(){} // RVA: 0x87C0A0
        public void get_boneRotations(){} // RVA: 0x87C0A0
        public void get_lastBonePositions(){} // RVA: 0x87C0A0
        public void get_lastBoneRotations(){} // RVA: 0x87C0A0
        public void get_rangeOfMotion(){} // RVA: 0x87C130
        public void set_rangeOfMotion(){} // RVA: 0x8944F0
        public void get_skeletalTransformSpace(){} // RVA: 0x87C130
        public void set_skeletalTransformSpace(){} // RVA: 0x8944F0
        public void get_onlyUpdateSummaryData(){} // RVA: 0x87D280
        public void set_onlyUpdateSummaryData(){} // RVA: 0x894750
        public void get_thumbCurl(){} // RVA: 0x890F90
        public void get_indexCurl(){} // RVA: 0x890F90
        public void get_middleCurl(){} // RVA: 0x890F90
        public void get_ringCurl(){} // RVA: 0x890F90
        public void get_pinkyCurl(){} // RVA: 0x890F90
        public void get_thumbIndexSplay(){} // RVA: 0x890F90
        public void get_indexMiddleSplay(){} // RVA: 0x890F90
        public void get_middleRingSplay(){} // RVA: 0x890F90
        public void get_ringPinkySplay(){} // RVA: 0x890F90
        public void get_lastThumbCurl(){} // RVA: 0x890F90
        public void get_lastIndexCurl(){} // RVA: 0x890F90
        public void get_lastMiddleCurl(){} // RVA: 0x890F90
        public void get_lastRingCurl(){} // RVA: 0x890F90
        public void get_lastPinkyCurl(){} // RVA: 0x890F90
        public void get_lastThumbIndexSplay(){} // RVA: 0x890F90
        public void get_lastIndexMiddleSplay(){} // RVA: 0x890F90
        public void get_lastMiddleRingSplay(){} // RVA: 0x890F90
        public void get_lastRingPinkySplay(){} // RVA: 0x890F90
        public void get_fingerCurls(){} // RVA: 0x87C0A0
        public void get_fingerSplays(){} // RVA: 0x87C0A0
        public void get_lastFingerCurls(){} // RVA: 0x87C0A0
        public void get_lastFingerSplays(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_Action_Source
    {
        // ── Methods ──
        public void get_active(){} // RVA: 0x87D280
        public void get_activeBinding(){} // RVA: 0x87D280
        public void get_lastActive(){} // RVA: 0x87D280
        public void get_lastActiveBinding(){} // RVA: 0x87D280
        public void get_fullPath(){} // RVA: 0x87C0A0
        public void get_handle(){} // RVA: 0x87C0A0
        public void get_actionSet(){} // RVA: 0x87C0A0
        public void get_direction(){} // RVA: 0x87C130
    }

    public class ISteamVR_Action_Vector2
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x87C0A0
        public void get_lastAxis(){} // RVA: 0x87C0A0
        public void get_delta(){} // RVA: 0x87C0A0
        public void get_lastDelta(){} // RVA: 0x87C0A0
    }

    public class ISteamVR_Action_Vector3
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x87BEB0
        public void get_lastAxis(){} // RVA: 0x87BEB0
        public void get_delta(){} // RVA: 0x87BEB0
        public void get_lastDelta(){} // RVA: 0x87BEB0
    }

    public class ISteamVR_Action_Vibration
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0xA94080
    }

    public class InputBindingInfo_t : ValueType
    {
        // ── Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x9574C0
        public void get_rchInputPathName(){} // RVA: 0x9574D0
        public void get_rchModeName(){} // RVA: 0x9574E0
        public void get_rchSlotName(){} // RVA: 0x9574F0
        public void get_rchInputSourceType(){} // RVA: 0x957500
    }

    public class InputBindingInfo_t[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB1120
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7BD70
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC6A50
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6C840
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7BD70
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class InputOriginInfo_t : ValueType
    {
        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x9574B0
    }

}