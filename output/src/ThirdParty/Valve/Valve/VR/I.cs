// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 46
// Methods: 116

namespace ThirdParty.Valve.Valve.VR
{
    public class ISteamVR_Action : Y
    {
        // ── Methods ──
        public void GetActive(){} // RVA: 0x7FFAF2ABE1F0
        public void GetShortName(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISteamVR_ActionSet
    {
        // ── Methods ──
        public void get_allActions(){} // RVA: 0x7FFAF2ABCD60
        public void get_nonVisualInActions(){} // RVA: 0x7FFAF2ABCD60
        public void get_visualActions(){} // RVA: 0x7FFAF2ABCD60
        public void get_poseActions(){} // RVA: 0x7FFAF2ABCD60
        public void get_skeletonActions(){} // RVA: 0x7FFAF2ABCD60
        public void get_outActionArray(){} // RVA: 0x7FFAF2ABCD60
        public void get_fullPath(){} // RVA: 0x7FFAF2ABCD60
        public void get_usage(){} // RVA: 0x7FFAF2ABCD60
        public void get_handle(){} // RVA: 0x7FFAF2ABCD60
        public void ReadRawSetActive(){} // RVA: 0x7FFAF2ABE1F0
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFAF2AD1C40
        public void ReadRawSetPriority(){} // RVA: 0x7FFAF2AC3FB0
        public void IsActive(){} // RVA: 0x7FFAF2ABE1F0
        public void GetTimeLastChanged(){} // RVA: 0x7FFAF2AD1C40
        public void Activate(){} // RVA: 0x7FFAF2AD6FE0
        public void Deactivate(){} // RVA: 0x7FFAF2AD4FA0
        public void GetShortName(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISteamVR_Action_Boolean
    {
        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFAF2ABDBE0
        public void get_stateDown(){} // RVA: 0x7FFAF2ABDBE0
        public void get_stateUp(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastState(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastStateDown(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastStateUp(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class ISteamVR_Action_In
    {
        // ── Methods ──
        public void UpdateValues(){} // RVA: 0x7FFAF2AD4A50
        public void GetRenderModelComponentName(){} // RVA: 0x7FFAF2ACBCC0
        public void GetActiveDevice(){} // RVA: 0x7FFAF2AC3FB0
        public void GetDeviceIndex(){} // RVA: 0x7FFAF2AC3FB0
        public void GetChanged(){} // RVA: 0x7FFAF2ABE1F0
        public void GetLocalizedOriginPart(){} // RVA: 0x7FFAF2ACCEE0
        public void GetLocalizedOrigin(){} // RVA: 0x7FFAF2ACBCC0
    }

    public class ISteamVR_Action_In_Source
    {
        // ── Methods ──
        public void get_changed(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastChanged(){} // RVA: 0x7FFAF2ABDBE0
        public void get_changedTime(){} // RVA: 0x7FFAF2AD1890
        public void get_updateTime(){} // RVA: 0x7FFAF2AD1890
        public void get_activeOrigin(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastActiveOrigin(){} // RVA: 0x7FFAF2ABCD60
        public void get_activeDevice(){} // RVA: 0x7FFAF2ABD840
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFAF2ABD840
        public void get_renderModelComponentName(){} // RVA: 0x7FFAF2ABCD60
        public void get_localizedOriginName(){} // RVA: 0x7FFAF2ABCD60
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
        public void get_localPosition(){} // RVA: 0x7FFAF2ABC770
        public void get_localRotation(){} // RVA: 0x7FFAF2ABC770
        public void get_trackingState(){} // RVA: 0x7FFAF2ABD840
        public void get_velocity(){} // RVA: 0x7FFAF2ABC770
        public void get_angularVelocity(){} // RVA: 0x7FFAF2ABC770
        public void get_poseIsValid(){} // RVA: 0x7FFAF2ABDBE0
        public void get_deviceIsConnected(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastLocalPosition(){} // RVA: 0x7FFAF2ABC770
        public void get_lastLocalRotation(){} // RVA: 0x7FFAF2ABC770
        public void get_lastTrackingState(){} // RVA: 0x7FFAF2ABD840
        public void get_lastVelocity(){} // RVA: 0x7FFAF2ABC770
        public void get_lastAngularVelocity(){} // RVA: 0x7FFAF2ABC770
        public void get_lastPoseIsValid(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastDeviceIsConnected(){} // RVA: 0x7FFAF2ABDBE0
    }

    public class ISteamVR_Action_Single
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFAF2AD1890
        public void get_lastAxis(){} // RVA: 0x7FFAF2AD1890
        public void get_delta(){} // RVA: 0x7FFAF2AD1890
        public void get_lastDelta(){} // RVA: 0x7FFAF2AD1890
    }

    public class ISteamVR_Action_Skeleton_Source
    {
        public object MaximumBunchSize32;
        public object DistanceFactor;
        public object SlowUpdateFactorThreadhold;
        public object ViewSegmentLength;
        public object InterestRequestTimeLimit;
        public object MaxDistanceFromCentre;

        // ── Methods ──
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFAF2ABD840
        public void get_bonePositions(){} // RVA: 0x7FFAF2ABCD60
        public void get_boneRotations(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastBonePositions(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastBoneRotations(){} // RVA: 0x7FFAF2ABCD60
        public void get_rangeOfMotion(){} // RVA: 0x7FFAF2ABD840
        public void set_rangeOfMotion(){} // RVA: 0x7FFAF2AD4FA0
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFAF2ABD840
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFAF2AD4FA0
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFAF2ABDBE0
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFAF2AD5130
        public void get_thumbCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_indexCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_middleCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_ringCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_pinkyCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_thumbIndexSplay(){} // RVA: 0x7FFAF2AD1890
        public void get_indexMiddleSplay(){} // RVA: 0x7FFAF2AD1890
        public void get_middleRingSplay(){} // RVA: 0x7FFAF2AD1890
        public void get_ringPinkySplay(){} // RVA: 0x7FFAF2AD1890
        public void get_lastThumbCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_lastIndexCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_lastMiddleCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_lastRingCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_lastPinkyCurl(){} // RVA: 0x7FFAF2AD1890
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFAF2AD1890
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFAF2AD1890
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFAF2AD1890
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFAF2AD1890
        public void get_fingerCurls(){} // RVA: 0x7FFAF2ABCD60
        public void get_fingerSplays(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastFingerCurls(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastFingerSplays(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISteamVR_Action_Source
    {
        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFAF2ABDBE0
        public void get_activeBinding(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastActive(){} // RVA: 0x7FFAF2ABDBE0
        public void get_lastActiveBinding(){} // RVA: 0x7FFAF2ABDBE0
        public void get_fullPath(){} // RVA: 0x7FFAF2ABCD60
        public void get_handle(){} // RVA: 0x7FFAF2ABCD60
        public void get_actionSet(){} // RVA: 0x7FFAF2ABCD60
        public void get_direction(){} // RVA: 0x7FFAF2ABD840
    }

    public class ISteamVR_Action_Vector2
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastAxis(){} // RVA: 0x7FFAF2ABCD60
        public void get_delta(){} // RVA: 0x7FFAF2ABCD60
        public void get_lastDelta(){} // RVA: 0x7FFAF2ABCD60
    }

    public class ISteamVR_Action_Vector3
    {
        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFAF2ABC770
        public void get_lastAxis(){} // RVA: 0x7FFAF2ABC770
        public void get_delta(){} // RVA: 0x7FFAF2ABC770
        public void get_lastDelta(){} // RVA: 0x7FFAF2ABC770
    }

    public class ISteamVR_Action_Vibration
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAF2D33FA0
    }

    public class IVRApplications
    {
    }

    public class IVRBlockQueue
    {
    }

    public class IVRChaperone
    {
    }

    public class IVRChaperoneSetup
    {
    }

    public class IVRCompositor
    {
    }

    public class IVRDebug
    {
    }

    public class IVRDriverManager
    {
    }

    public class IVRExtendedDisplay
    {
    }

    public class IVRHeadsetView
    {
    }

    public class IVRIOBuffer
    {
    }

    public class IVRInput
    {
    }

    public class IVRNotifications
    {
    }

    public class IVROverlay
    {
    }

    public class IVROverlayView
    {
    }

    public class IVRPaths
    {
    }

    public class IVRProperties
    {
    }

    public class IVRRenderModels
    {
    }

    public class IVRResources
    {
    }

    public class IVRScreenshots
    {
    }

    public class IVRSettings
    {
    }

    public class IVRSpatialAnchors
    {
    }

    public class IVRSystem
    {
    }

    public class IVRTrackedCamera
    {
    }

    public class ImuSample_t
    {
    }

    public class InputAnalogActionData_t
    {
    }

    public class InputBindingInfo_t
    {
        // ── Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x7FFAF9B18510
        public void get_rchInputPathName(){} // RVA: 0x7FFAF9B18F80
        public void get_rchModeName(){} // RVA: 0x7FFAF9B19B70
        public void get_rchSlotName(){} // RVA: 0x7FFAF9B1A760
        public void get_rchInputSourceType(){} // RVA: 0x7FFAF9B1B350
    }

    public class InputDigitalActionData_t
    {
    }

    public class InputOriginInfo_t
    {
        public object rchDevicePathName;

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7FFAF9B17A70
    }

    public class InputPoseActionData_t
    {
    }

    public class InputSkeletalActionData_t
    {
    }

    public class IntersectionMaskCircle_t
    {
    }

    public class IntersectionMaskRectangle_t
    {
    }

}