// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 40
// Methods: 92

namespace ThirdParty.Valve.Valve.VR
{
    public class ISteamVR_ActionSet
    {
        public object allActions;
        public object nonVisualInActions;
        public object visualActions;
        public object poseActions;
        public object skeletonActions;
        public object outActionArray;
        public object fullPath;
        public object usage;
        public object handle;

        // ── Methods ──
        public void get_allActions(){} // RVA: 0x7FFD4E078E90
        public void get_nonVisualInActions(){} // RVA: 0x7FFD4E078E90
        public void get_visualActions(){} // RVA: 0x7FFD4E078E90
        public void get_poseActions(){} // RVA: 0x7FFD4E078E90
        public void get_skeletonActions(){} // RVA: 0x7FFD4E078E90
        public void get_outActionArray(){} // RVA: 0x7FFD4E078E90
        public void get_fullPath(){} // RVA: 0x7FFD4E078E90
        public void get_usage(){} // RVA: 0x7FFD4E078E90
        public void get_handle(){} // RVA: 0x7FFD4E078E90
        public void ReadRawSetActive(){} // RVA: 0x7FFD4E07A310
        public void ReadRawSetLastChanged(){} // RVA: 0x7FFD4E08DC30
        public void ReadRawSetPriority(){} // RVA: 0x7FFD4E0800D0
        public void IsActive(){} // RVA: 0x7FFD4E07A310
        public void GetTimeLastChanged(){} // RVA: 0x7FFD4E08DC30
        public void Activate(){} // RVA: 0x7FFD4E092F60
        public void Deactivate(){} // RVA: 0x7FFD4E090ED0
        public void GetShortName(){} // RVA: 0x7FFD4E078E90
    }

    public class ISteamVR_Action_Boolean
    {
        public object state;
        public object stateDown;
        public object stateUp;
        public object lastState;
        public object lastStateDown;
        public object lastStateUp;

        // ── Methods ──
        public void get_state(){} // RVA: 0x7FFD4E079D00
        public void get_stateDown(){} // RVA: 0x7FFD4E079D00
        public void get_stateUp(){} // RVA: 0x7FFD4E079D00
        public void get_lastState(){} // RVA: 0x7FFD4E079D00
        public void get_lastStateDown(){} // RVA: 0x7FFD4E079D00
        public void get_lastStateUp(){} // RVA: 0x7FFD4E079D00
    }

    public class ISteamVR_Action_In_Source
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
        public void get_changed(){} // RVA: 0x7FFD4E079D00
        public void get_lastChanged(){} // RVA: 0x7FFD4E079D00
        public void get_changedTime(){} // RVA: 0x7FFD4E08D880
        public void get_updateTime(){} // RVA: 0x7FFD4E08D880
        public void get_activeOrigin(){} // RVA: 0x7FFD4E078E90
        public void get_lastActiveOrigin(){} // RVA: 0x7FFD4E078E90
        public void get_activeDevice(){} // RVA: 0x7FFD4E079960
        public void get_trackedDeviceIndex(){} // RVA: 0x7FFD4E079960
        public void get_renderModelComponentName(){} // RVA: 0x7FFD4E078E90
        public void get_localizedOriginName(){} // RVA: 0x7FFD4E078E90
    }

    public class ISteamVR_Action_Single
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFD4E08D880
        public void get_lastAxis(){} // RVA: 0x7FFD4E08D880
        public void get_delta(){} // RVA: 0x7FFD4E08D880
        public void get_lastDelta(){} // RVA: 0x7FFD4E08D880
    }

    public class ISteamVR_Action_Skeleton_Source
    {
        public object skeletalTrackingLevel;
        public object bonePositions;
        public object boneRotations;
        public object lastBonePositions;
        public object lastBoneRotations;
        public object rangeOfMotion;
        public object skeletalTransformSpace;
        public object onlyUpdateSummaryData;
        public object thumbCurl;
        public object indexCurl;
        public object middleCurl;
        public object ringCurl;
        public object pinkyCurl;
        public object thumbIndexSplay;
        public object indexMiddleSplay;
        public object middleRingSplay;
        public object ringPinkySplay;
        public object lastThumbCurl;
        public object lastIndexCurl;
        public object lastMiddleCurl;
        public object lastRingCurl;
        public object lastPinkyCurl;
        public object lastThumbIndexSplay;
        public object lastIndexMiddleSplay;
        public object lastMiddleRingSplay;
        public object lastRingPinkySplay;
        public object fingerCurls;
        public object fingerSplays;
        public object lastFingerCurls;
        public object lastFingerSplays;

        // ── Methods ──
        public void get_skeletalTrackingLevel(){} // RVA: 0x7FFD4E079960
        public void get_bonePositions(){} // RVA: 0x7FFD4E078E90
        public void get_boneRotations(){} // RVA: 0x7FFD4E078E90
        public void get_lastBonePositions(){} // RVA: 0x7FFD4E078E90
        public void get_lastBoneRotations(){} // RVA: 0x7FFD4E078E90
        public void get_rangeOfMotion(){} // RVA: 0x7FFD4E079960
        public void set_rangeOfMotion(){} // RVA: 0x7FFD4E090ED0
        public void get_skeletalTransformSpace(){} // RVA: 0x7FFD4E079960
        public void set_skeletalTransformSpace(){} // RVA: 0x7FFD4E090ED0
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7FFD4E079D00
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7FFD4E091060
        public void get_thumbCurl(){} // RVA: 0x7FFD4E08D880
        public void get_indexCurl(){} // RVA: 0x7FFD4E08D880
        public void get_middleCurl(){} // RVA: 0x7FFD4E08D880
        public void get_ringCurl(){} // RVA: 0x7FFD4E08D880
        public void get_pinkyCurl(){} // RVA: 0x7FFD4E08D880
        public void get_thumbIndexSplay(){} // RVA: 0x7FFD4E08D880
        public void get_indexMiddleSplay(){} // RVA: 0x7FFD4E08D880
        public void get_middleRingSplay(){} // RVA: 0x7FFD4E08D880
        public void get_ringPinkySplay(){} // RVA: 0x7FFD4E08D880
        public void get_lastThumbCurl(){} // RVA: 0x7FFD4E08D880
        public void get_lastIndexCurl(){} // RVA: 0x7FFD4E08D880
        public void get_lastMiddleCurl(){} // RVA: 0x7FFD4E08D880
        public void get_lastRingCurl(){} // RVA: 0x7FFD4E08D880
        public void get_lastPinkyCurl(){} // RVA: 0x7FFD4E08D880
        public void get_lastThumbIndexSplay(){} // RVA: 0x7FFD4E08D880
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7FFD4E08D880
        public void get_lastMiddleRingSplay(){} // RVA: 0x7FFD4E08D880
        public void get_lastRingPinkySplay(){} // RVA: 0x7FFD4E08D880
        public void get_fingerCurls(){} // RVA: 0x7FFD4E078E90
        public void get_fingerSplays(){} // RVA: 0x7FFD4E078E90
        public void get_lastFingerCurls(){} // RVA: 0x7FFD4E078E90
        public void get_lastFingerSplays(){} // RVA: 0x7FFD4E078E90
    }

    public class ISteamVR_Action_Source
    {
        public object active;
        public object activeBinding;
        public object lastActive;
        public object lastActiveBinding;
        public object fullPath;
        public object handle;
        public object actionSet;
        public object direction;

        // ── Methods ──
        public void get_active(){} // RVA: 0x7FFD4E079D00
        public void get_activeBinding(){} // RVA: 0x7FFD4E079D00
        public void get_lastActive(){} // RVA: 0x7FFD4E079D00
        public void get_lastActiveBinding(){} // RVA: 0x7FFD4E079D00
        public void get_fullPath(){} // RVA: 0x7FFD4E078E90
        public void get_handle(){} // RVA: 0x7FFD4E078E90
        public void get_actionSet(){} // RVA: 0x7FFD4E078E90
        public void get_direction(){} // RVA: 0x7FFD4E079960
    }

    public class ISteamVR_Action_Vector2
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFD4E078E90
        public void get_lastAxis(){} // RVA: 0x7FFD4E078E90
        public void get_delta(){} // RVA: 0x7FFD4E078E90
        public void get_lastDelta(){} // RVA: 0x7FFD4E078E90
    }

    public class ISteamVR_Action_Vector3
    {
        public object axis;
        public object lastAxis;
        public object delta;
        public object lastDelta;

        // ── Methods ──
        public void get_axis(){} // RVA: 0x7FFD4E0788A0
        public void get_lastAxis(){} // RVA: 0x7FFD4E0788A0
        public void get_delta(){} // RVA: 0x7FFD4E0788A0
        public void get_lastDelta(){} // RVA: 0x7FFD4E0788A0
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
        public object rchDevicePathName;
        public object rchInputPathName;
        public object rchModeName;
        public object rchSlotName;
        public object rchInputSourceType;

        // ── Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x7FFD54C20E60
        public void get_rchInputPathName(){} // RVA: 0x7FFD54C218D0
        public void get_rchModeName(){} // RVA: 0x7FFD54C224C0
        public void get_rchSlotName(){} // RVA: 0x7FFD54C230B0
        public void get_rchInputSourceType(){} // RVA: 0x7FFD54C23CA0
    }

    public class InputDigitalActionData_t : ValueType
    {
    }

    public class InputOriginInfo_t : ValueType
    {
        public object rchRenderModelComponentName;

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7FFD54C203C0
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