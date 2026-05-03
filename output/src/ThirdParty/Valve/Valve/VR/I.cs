// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 46
// Methods: 116

namespace ThirdParty.Valve.Valve.VR
{
    public class ISteamVR_Action
    {
        // ── Methods ──
        public void GetActive(){} // RVA: 0x7FFE80E2F760
        public void GetShortName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISteamVR_ActionSet
    {
        // ── Methods ──
        public void get_allActions(){} // RVA: 0x7FFE80E2E2E0
        public void get_nonVisualInActions(){} // RVA: 0x7FFE80E2E2E0
        public void get_visualActions(){} // RVA: 0x7FFE80E2E2E0
        public void get_poseActions(){} // RVA: 0x7FFE80E2E2E0
        public void get_skeletonActions(){} // RVA: 0x7FFE80E2E2E0
        public void get_outActionArray(){} // RVA: 0x7FFE80E2E2E0
        public void get_fullPath(){} // RVA: 0x7FFE80E2E2E0
        public void get_usage(){} // RVA: 0x7FFE80E2E2E0
        public void get_handle(){} // RVA: 0x7FFE80E2E2E0
        public void ReadRawSetActive(){} // RVA: 0x7FFE80E2F760
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFE80E431C0
        public void ReadRawSetPriority(){} // RVA: 0x7FFE80E35520
        public void IsActive(){} // RVA: 0x7FFE80E2F760
        public void GetTimeLastChanged(){} // RVA: 0x7FFE80E431C0
        public void Activate(){} // RVA: 0x7FFE80E485C0
        public void Deactivate(){} // RVA: 0x7FFE80E46530
        public void GetShortName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISteamVR_Action_Boolean
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFE80E2F150
        public void get_stateDown(){} // RVA: 0x7FFE80E2F150
        public void get_stateUp(){} // RVA: 0x7FFE80E2F150
        public void get_lastState(){} // RVA: 0x7FFE80E2F150
        public void get_lastStateDown(){} // RVA: 0x7FFE80E2F150
        public void get_lastStateUp(){} // RVA: 0x7FFE80E2F150
    }

    public class ISteamVR_Action_In
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7FFE80E45FE0
        public void GetRenderModelComponentName(){} // RVA: 0x7FFE80E3D230
        public void GetActiveDevice(){} // RVA: 0x7FFE80E35520
        public void GetDeviceIndex(){} // RVA: 0x7FFE80E35520
        public void GetChanged(){} // RVA: 0x7FFE80E2F760
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFE80E3E450
        public void GetLocalizedOrigin(){} // RVA: 0x7FFE80E3D230
    }

    public class ISteamVR_Action_In_Source
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7FFE80E2F150
        public void get_lastChanged(){} // RVA: 0x7FFE80E2F150
        public void get_changedTime(){} // RVA: 0x7FFE80E42E10
        public void get_updateTime(){} // RVA: 0x7FFE80E42E10
        public void get_activeOrigin(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastActiveOrigin(){} // RVA: 0x7FFE80E2E2E0
        public void get_activeDevice(){} // RVA: 0x7FFE80E2EDB0
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFE80E2EDB0
        public void get_renderModelComponentName(){} // RVA: 0x7FFE80E2E2E0
        public void get_localizedOriginName(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISteamVR_Action_Out
    {
    }

    public class ISteamVR_Action_Out_Source
    {
    }

    public class ISteamVR_Action_Pose
    {
        // ── Methods ──
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
    }

    public class ISteamVR_Action_Single
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFE80E42E10
        public void get_lastAxis(){} // RVA: 0x7FFE80E42E10
        public void get_delta(){} // RVA: 0x7FFE80E42E10
        public void get_lastDelta(){} // RVA: 0x7FFE80E42E10
    }

    public class ISteamVR_Action_Skeleton_Source
    {
        // ── Methods ──
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFE80E2EDB0
        public void get_bonePositions(){} // RVA: 0x7FFE80E2E2E0
        public void get_boneRotations(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastBonePositions(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastBoneRotations(){} // RVA: 0x7FFE80E2E2E0
        public void get_rangeOfMotion(){} // RVA: 0x7FFE80E2EDB0
        public void set_rangeOfMotion(){} // RVA: 0x7FFE80E46530
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFE80E2EDB0
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFE80E46530
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFE80E2F150
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFE80E466C0
        public void get_thumbCurl(){} // RVA: 0x7FFE80E42E10
        public void get_indexCurl(){} // RVA: 0x7FFE80E42E10
        public void get_middleCurl(){} // RVA: 0x7FFE80E42E10
        public void get_ringCurl(){} // RVA: 0x7FFE80E42E10
        public void get_pinkyCurl(){} // RVA: 0x7FFE80E42E10
        public void get_thumbIndexSplay(){} // RVA: 0x7FFE80E42E10
        public void get_indexMiddleSplay(){} // RVA: 0x7FFE80E42E10
        public void get_middleRingSplay(){} // RVA: 0x7FFE80E42E10
        public void get_ringPinkySplay(){} // RVA: 0x7FFE80E42E10
        public void get_lastThumbCurl(){} // RVA: 0x7FFE80E42E10
        public void get_lastIndexCurl(){} // RVA: 0x7FFE80E42E10
        public void get_lastMiddleCurl(){} // RVA: 0x7FFE80E42E10
        public void get_lastRingCurl(){} // RVA: 0x7FFE80E42E10
        public void get_lastPinkyCurl(){} // RVA: 0x7FFE80E42E10
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFE80E42E10
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFE80E42E10
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFE80E42E10
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFE80E42E10
        public void get_fingerCurls(){} // RVA: 0x7FFE80E2E2E0
        public void get_fingerSplays(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastFingerCurls(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastFingerSplays(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISteamVR_Action_Source
    {
        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFE80E2F150
        public void get_activeBinding(){} // RVA: 0x7FFE80E2F150
        public void get_lastActive(){} // RVA: 0x7FFE80E2F150
        public void get_lastActiveBinding(){} // RVA: 0x7FFE80E2F150
        public void get_fullPath(){} // RVA: 0x7FFE80E2E2E0
        public void get_handle(){} // RVA: 0x7FFE80E2E2E0
        public void get_actionSet(){} // RVA: 0x7FFE80E2E2E0
        public void get_direction(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ISteamVR_Action_Vector2
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastAxis(){} // RVA: 0x7FFE80E2E2E0
        public void get_delta(){} // RVA: 0x7FFE80E2E2E0
        public void get_lastDelta(){} // RVA: 0x7FFE80E2E2E0
    }

    public class ISteamVR_Action_Vector3
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFE80E2DCF0
        public void get_lastAxis(){} // RVA: 0x7FFE80E2DCF0
        public void get_delta(){} // RVA: 0x7FFE80E2DCF0
        public void get_lastDelta(){} // RVA: 0x7FFE80E2DCF0
    }

    public class ISteamVR_Action_Vibration
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE810A1420
    }

    public class IVRApplications : ValueType
    {
    }

    public class IVRBlockQueue : ValueType
    {
    }

    public class IVRChaperone : ValueType
    {
    }

    public class IVRChaperoneSetup : ValueType
    {
    }

    public class IVRCompositor : ValueType
    {
    }

    public class IVRDebug : ValueType
    {
    }

    public class IVRDriverManager : ValueType
    {
    }

    public class IVRExtendedDisplay : ValueType
    {
    }

    public class IVRHeadsetView : ValueType
    {
    }

    public class IVRIOBuffer : ValueType
    {
    }

    public class IVRInput : ValueType
    {
    }

    public class IVRNotifications : ValueType
    {
    }

    public class IVROverlay : ValueType
    {
    }

    public class IVROverlayView : ValueType
    {
    }

    public class IVRPaths : ValueType
    {
    }

    public class IVRProperties : ValueType
    {
    }

    public class IVRRenderModels : ValueType
    {
    }

    public class IVRResources : ValueType
    {
    }

    public class IVRScreenshots : ValueType
    {
    }

    public class IVRSettings : ValueType
    {
    }

    public class IVRSpatialAnchors : ValueType
    {
    }

    public class IVRSystem : ValueType
    {
    }

    public class IVRTrackedCamera : ValueType
    {
    }

    public class ImuSample_t : ValueType
    {
    }

    public class InputAnalogActionData_t : ValueType
    {
    }

    public class InputBindingInfo_t : ValueType
    {
        public byte rchDevicePathName0; // 0x10
        public byte rchDevicePathName1; // 0x11
        public byte rchDevicePathName2; // 0x12
        public byte rchDevicePathName3; // 0x13
        public byte rchDevicePathName4; // 0x14

        // ── Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x7FFE87BA93E0
        public void get_rchInputPathName(){} // RVA: 0x7FFE87BA9E50
        public void get_rchModeName(){} // RVA: 0x7FFE87BAAA40
        public void get_rchSlotName(){} // RVA: 0x7FFE87BAB630
        public void get_rchInputSourceType(){} // RVA: 0x7FFE87BAC220
    }

    public class InputDigitalActionData_t : ValueType
    {
    }

    public class InputOriginInfo_t : ValueType
    {
        public ulong devicePath; // 0x10

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7FFE87BA8940
    }

    public class InputPoseActionData_t : ValueType
    {
    }

    public class InputSkeletalActionData_t : ValueType
    {
    }

    public class IntersectionMaskCircle_t : ValueType
    {
    }

    public class IntersectionMaskRectangle_t : ValueType
    {
    }

}