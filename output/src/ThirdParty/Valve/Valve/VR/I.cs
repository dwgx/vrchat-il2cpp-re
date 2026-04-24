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
        public >b__4_21 AddApplicationManifest; // 0x10
        public 25 RemoveApplicationManifest; // 0x18
        public _4_27 IsApplicationInstalled; // 0x20
        public 9 GetApplicationCount; // 0x28
        public _4_4 GetApplicationKeyByIndex; // 0x30
        public 14 GetApplicationKeyByProcessId; // 0x38
        public object LaunchApplication; // 0x40
        public 0 LaunchTemplateApplication; // 0x48
        public object LaunchApplicationFromMimeType; // 0x50
        public pturePos LaunchDashboardOverlay; // 0x58
        public ggerCubemapCapture CancelApplicationLaunch; // 0x60
        public amera IdentifyApplication; // 0x68
        public erIntoCubemap GetApplicationProcessId; // 0x70
        public Capture GetApplicationsErrorNameFromEnum; // 0x78
        public oTriggerDelay GetApplicationPropertyString; // 0x80
        public omSkeleton GetApplicationPropertyBool; // 0x88
        public oneId GetApplicationPropertyUint64; // 0x90
        public Bones_V2 SetApplicationAutoLaunch; // 0x98
        public UIComponents GetApplicationAutoLaunch; // 0xA0
        public e SetDefaultApplicationForMimeType; // 0xA8
        public sentGUI GetDefaultApplicationForMimeType; // 0xB0
        public object GetApplicationSupportedMimeTypes; // 0xB8
        public tOffset GetApplicationsThatSupportMimeType; // 0xC0
        public eFPS GetApplicationLaunchArguments; // 0xC8
        public esolutionEyeTexture GetStartingApplication; // 0xD0
        public ÌÏÎÌÌÏÏÌÌÏÎÌÏ GetSceneApplicationState; // 0xD8
        public object PerformApplicationPrelaunchCheck; // 0xE0
        public object GetSceneApplicationStateNameFromEnum; // 0xE8
        public ft LaunchInternalProcess; // 0xF0
        public ze GetCurrentSceneProcessId; // 0xF8
    }

    public class IVRBlockQueue : ValueType
    {
        public passOperationBack Create; // 0x10
        public object Connect; // 0x18
        public ÏÏÏÏÎÎÎÎÎÎ Destroy; // 0x20
        public ÏÎÎÎÍÏÎÍÌÎÏÎÍÎÍÍÍÌÍÍÌÌ AcquireWriteOnlyBlock; // 0x28
        public object ReleaseWriteOnlyBlock; // 0x30
        public ÍÌÌ WaitAndAcquireReadOnlyBlock; // 0x38
        public Ì AcquireReadOnlyBlock; // 0x40
        public object ReleaseReadOnlyBlock; // 0x48
        public object QueueHasReader; // 0x50
    }

    public class IVRChaperone : ValueType
    {
        public tialAnchorCreateCompleteData GetCalibrationState; // 0x10
        public eteData GetPlayAreaSize; // 0x18
        public CompleteData GetPlayAreaRect; // 0x20
        public eSaveCompleteData ReloadInfo; // 0x28
        public eData SetSceneColor; // 0x30
        public eCompleteData GetBoundsColor; // 0x38
        public rogress AreBoundsVisible; // 0x40
        public ionProgress ForceBoundsVisible; // 0x48
        public ÏÏÎÎÍÏÏÏÎÏÎÌÌÌÏÌÌÏÎÌÌ ResetZeroPose; // 0x50
    }

    public class IVRChaperoneSetup : ValueType
    {
        public _snapOffset CommitWorkingCopy; // 0x10
        public bbedKinematic RevertWorkingCopy; // 0x18
        public bbedCollider GetWorkingPlayAreaSize; // 0x20
        public object GetWorkingPlayAreaRect; // 0x28
        public bed GetWorkingCollisionBoundsInfo; // 0x30
        public bedTransform GetLiveCollisionBoundsInfo; // 0x38
        public y GetWorkingSeatedZeroPoseToRawTrackingPose; // 0x40
        public rs GetWorkingStandingZeroPoseToRawTrackingPose; // 0x48
        public bbableRelease SetWorkingPlayAreaSize; // 0x50
        public object SetWorkingCollisionBoundsInfo; // 0x58
        public object SetWorkingPerimeter; // 0x60
        public ake>b__23_0 SetWorkingSeatedZeroPoseToRawTrackingPose; // 0x68
        public form SetWorkingStandingZeroPoseToRawTrackingPose; // 0x70
        public ot ReloadFromDisk; // 0x78
        public tRotation GetLiveSeatedZeroPoseToRawTrackingPose; // 0x80
        public ameraController ExportLiveToBuffer; // 0x88
        public teCubeGrid ImportFromBufferToWorking; // 0x90
        public object ShowWorkingSetPreview; // 0x98
        public object HideWorkingSetPreview; // 0xA0
        public ÌÍÏÎÏÌÎÌ RoomSetupStarting; // 0xA8
    }

    public class IVRCompositor : ValueType
    {
        public ld SetTrackingSpace; // 0x10
        public ackingField GetTrackingSpace; // 0x18
        public onfidence>k__BackingField WaitGetPoses; // 0x20
        public object GetLastPoses; // 0x28
        public ystemGestureInProgress GetLastPoseForTrackedDeviceIndex; // 0x30
        public ntHand Submit; // 0x38
        public object SubmitWithArrayIndex; // 0x40
        public object ClearLastSubmittedFrame; // 0x48
        public result_skel_LH PostPresentHandoff; // 0x50
        public t_skel_RH GetFrameTiming; // 0x58
        public _RH GetFrameTimings; // 0x60
        public r>b__19_0 GetFrameTimeRemaining; // 0x68
        public esh GetCumulativeStats; // 0x70
        public sh FadeToColor; // 0x78
        public object GetCurrentFadeColor; // 0x80
        public ticesV3 FadeGrid; // 0x88
        public ransformVertices GetCurrentGridAlpha; // 0x90
        public rateTrianglesFromBoundaryVertices SetSkyboxOverride; // 0x98
        public Order ClearSkyboxOverride; // 0xA0
        public object CompositorBringToFront; // 0xA8
        public rClockwise CompositorGoToBack; // 0xB0
        public bs CompositorQuit; // 0xB8
        public itySpaceJob IsFullscreen; // 0xC0
        public rtices GetCurrentSceneFocusProcess; // 0xC8
        public object GetLastFrameRenderer; // 0xD0
        public MeshNormals CanRenderScene; // 0xD8
        public UV ShowMirrorWindow; // 0xE0
        public object HideMirrorWindow; // 0xE8
        public ransformTrianglesJob IsMirrorWindowVisible; // 0xF0
        public shIndices CompositorDumpImages; // 0xF8
        public elper`1 ShouldAppRenderWithLowResources; // 0x100
        public object ForceInterleavedReprojectionOn; // 0x108
        public eMaterial ForceReconnectProcess; // 0x110
        public SystemGestureMaterial SuspendRendering; // 0x118
        public esh GetMirrorTextureD3D11; // 0x120
        public denceBehavior ReleaseMirrorTextureD3D11; // 0x128
        public aterial GetMirrorTextureGL; // 0x130
        public rer ReleaseSharedGLTexture; // 0x138
        public Field LockGLSharedTextureForAccess; // 0x140
        public terial UnlockGLSharedTextureForAccess; // 0x148
        public der GetVulkanInstanceExtensionsRequired; // 0x150
        public ata GetVulkanDeviceExtensionsRequired; // 0x158
        public Behavior SetExplicitTimingMode; // 0x160
        public tyCaptureConfiguration SubmitExplicitTimingData; // 0x168
        public ÌÌÏÎ IsMotionSmoothingEnabled; // 0x170
        public object IsMotionSmoothingSupported; // 0x178
        public object IsCurrentSceneFocusAppLoading; // 0x180
        public object SetStageOverride_Async; // 0x188
        public ÌÌÏÎÏÎÎÏÍÏÍÏÎÎÏ ClearStageOverride; // 0x190
        public ÍÏÎÎÏ GetCompositorBenchmarkResults; // 0x198
        public d GetLastPosePredictionIDs; // 0x1A0
        public object GetPosesForFrame; // 0x1A8
    }

    public class IVRDebug : ValueType
    {
        public ÌÏÏÏÏÏÌ EmitVrProfilerEvent; // 0x10
        public object BeginVrProfilerEvent; // 0x18
        public object FinishVrProfilerEvent; // 0x20
        public form DriverDebugRequest; // 0x28
    }

    public class IVRDriverManager : ValueType
    {
        public l_IsValid GetDriverCount; // 0x10
        public CpuClockLevel GetDriverName; // 0x18
        public ClockLevel_IsValid GetDriverHandle; // 0x20
        public ÌÎÎ IsEnabled; // 0x28
    }

    public class IVRExtendedDisplay : ValueType
    {
        public led GetWindowBounds; // 0x10
        public hors GetEyeOutputViewport; // 0x18
        public yAllBounded2DEnabled GetDXGIOutputInfo; // 0x20
    }

    public class IVRHeadsetView : ValueType
    {
        public ÎÌÌÏÌÎÌÌÏÌ SetHeadsetViewSize; // 0x10
        public object GetHeadsetViewSize; // 0x18
        public object SetHeadsetViewMode; // 0x20
        public ÏÍÌÏÏ GetHeadsetViewMode; // 0x28
        public object SetHeadsetViewCropped; // 0x30
        public object GetHeadsetViewCropped; // 0x38
        public object GetHeadsetViewAspectRatio; // 0x40
        public Ï SetHeadsetViewBlendRange; // 0x48
        public object GetHeadsetViewBlendRange; // 0x50
    }

    public class IVRIOBuffer : ValueType
    {
        public ctor2 Open; // 0x10
        public object Close; // 0x18
        public adQuaternion Read; // 0x20
        public ernion Write; // 0x28
        public ReadRect PropertyContainer; // 0x30
        public ÏÌ HasReaders; // 0x38
    }

    public class IVRInput : ValueType
    {
        public ty SetActionManifestPath; // 0x10
        public Ratio GetActionSetHandle; // 0x18
        public Color GetActionHandle; // 0x20
        public object GetInputSourceHandle; // 0x28
        public er UpdateActionState; // 0x30
        public terial GetDigitalActionData; // 0x38
        public eAndOffset1Property GetAnalogActionData; // 0x40
        public ÍÏÎÌÏ GetPoseActionDataRelativeToNow; // 0x48
        public object GetPoseActionDataForNextFrame; // 0x50
        public AndOffset1 GetSkeletalActionData; // 0x58
        public object GetDominantHand; // 0x60
        public object SetDominantHand; // 0x68
        public object GetBoneCount; // 0x70
        public object GetBoneHierarchy; // 0x78
        public ÎÎÌÎÎÍÌÏÌÌÎÌÎÏÌÏÏÎÎÌÎÍ GetBoneName; // 0x80
        public ÍÏÏÍÌÍÌÌÎÍÏÎÎÌÎÎÌÌÍ GetSkeletalReferenceTransforms; // 0x88
        public ÍÏÏÌÌÌÎÌÏÌÏÏÌÌÍÌÏÎÍ GetSkeletalTrackingLevel; // 0x90
        public AndOffset0 GetSkeletalBoneData; // 0x98
        public ÌÎÍÌÌÎÍÌÏÏÍÏÎÌÌÎÏÌ GetSkeletalSummaryData; // 0xA0
        public hComplexityLevel GetSkeletalBoneDataCompressed; // 0xA8
        public NodeType DecompressSkeletalBoneData; // 0xB0
        public object TriggerHapticVibrationAction; // 0xB8
        public object GetActionOrigins; // 0xC0
        public Int GetOriginLocalizedName; // 0xC8
        public AsBool GetOriginTrackedDeviceInfo; // 0xD0
        public ÌÍÏÌÏÏÏÍÍÍÍÌÏÌÌÍÏÌÏÎÌÏÏ GetActionBindingInfo; // 0xD8
        public yValue ShowActionOrigins; // 0xE0
        public ted ShowBindingsForActionSet; // 0xE8
        public ÎÌÎ GetComponentStateForBinding; // 0xF0
        public ÎÏÍÌÌÎÏÏÌÍÍÍ IsUsingLegacyInput; // 0xF8
        public ÍÍ OpenBindingUI; // 0x100
        public object GetBindingVariant; // 0x108
    }

    public class IVRNotifications : ValueType
    {
        public endererData CreateNotification; // 0x10
        public stureMat RemoveNotification; // 0x18
    }

    public class IVROverlay : ValueType
    {
        public est FindOverlay; // 0x10
        public e CreateOverlay; // 0x18
        public tFov DestroyOverlay; // 0x20
        public Network GetOverlayKey; // 0x28
        public erLength GetOverlayName; // 0x30
        public oadLength SetOverlayName; // 0x38
        public icIdentifier GetOverlayImageData; // 0x40
        public fier GetOverlayErrorNameFromEnum; // 0x48
        public VRNetworkTcpServer SetOverlayRenderingPid; // 0x50
        public rt GetOverlayRenderingPid; // 0x58
        public back SetOverlayFlag; // 0x60
        public lback GetOverlayFlag; // 0x68
        public _enablePhysicsCapsules GetOverlayFlags; // 0x70
        public ock SetOverlayColor; // 0x78
        public tworkTcpClient GetOverlayColor; // 0x80
        public eadDataCallback SetOverlayAlpha; // 0x88
        public onnectionStateChangedCallback GetOverlayAlpha; // 0x90
        public back SetOverlayTexelAspect; // 0x98
        public nt GetOverlayTexelAspect; // 0xA0
        public x SetOverlaySortOrder; // 0xA8
        public eiveDataEvent GetOverlaySortOrder; // 0xB0
        public ectionState SetOverlayWidthInMeters; // 0xB8
        public sformUpdated GetOverlayWidthInMeters; // 0xC0
        public ÏÏÎÎÏÏÌÌÎÏÍÌÍÎÌÎ SetOverlayCurvature; // 0xC8
        public object GetOverlayCurvature; // 0xD0
        public ÎÍÌÎÌÏÌ SetOverlayPreCurvePitch; // 0xD8
        public object GetOverlayPreCurvePitch; // 0xE0
        public tiplier SetOverlayTextureColorSpace; // 0xE8
        public plier GetOverlayTextureColorSpace; // 0xF0
        public tiplier SetOverlayTextureBounds; // 0xF8
        public ation GetOverlayTextureBounds; // 0x100
        public altUpdateMovement GetOverlayTransformType; // 0x108
        public g SetOverlayTransformAbsolute; // 0x110
        public oundGuardianCenter GetOverlayTransformAbsolute; // 0x118
        public HmdRotatesY SetOverlayTransformTrackedDeviceRelative; // 0x120
        public ted GetOverlayTransformTrackedDeviceRelative; // 0x128
        public tationEitherThumbstick SetOverlayTransformTrackedDeviceComponent; // 0x130
        public ialPose GetOverlayTransformTrackedDeviceComponent; // 0x138
        public object SetOverlayTransformCursor; // 0x140
        public object GetOverlayTransformCursor; // 0x148
        public object SetOverlayTransformProjection; // 0x150
        public erEnabled ShowOverlay; // 0x158
        public tialYRotation HideOverlay; // 0x160
        public object IsOverlayVisible; // 0x168
        public tor GetTransformForOverlayCoordinates; // 0x170
        public ÍÏÍÏÎÌÍÎ WaitFrameSync; // 0x178
        public heckForBlocking PollNextOverlayEvent; // 0x180
        public tPointer GetOverlayInputMethod; // 0x188
        public object SetOverlayInputMethod; // 0x190
        public ed GetOverlayMouseScale; // 0x198
        public ouse SetOverlayMouseScale; // 0x1A0
        public __16_0 ComputeOverlayIntersection; // 0x1A8
        public er IsHoverTargetOverlay; // 0x1B0
        public innableBones SetOverlayIntersectionMask; // 0x1B8
        public object TriggerLaserMouseHapticVibration; // 0x1C0
        public object SetOverlayCursor; // 0x1C8
        public object SetOverlayCursorPositionOverride; // 0x1D0
        public object ClearOverlayCursorPositionOverride; // 0x1D8
        public ionNodes SetOverlayTexture; // 0x1E0
        public trollerModel>d__16 ClearOverlayTexture; // 0x1E8
        public RSceneSampleController SetOverlayRaw; // 0x1F0
        public UpdateSpeedAndRotationScaleMultiplier SetOverlayFromFile; // 0x1F8
        public plier GetOverlayTexture; // 0x200
        public VRScreenFade ReleaseNativeOverlayHandle; // 0x208
        public a GetOverlayTextureSize; // 0x210
        public lFinishedLoading CreateDashboardOverlay; // 0x218
        public pha IsDashboardVisible; // 0x220
        public Start IsActiveDashboardOverlay; // 0x228
        public imatedFadeAlpha SetDashboardOverlaySceneProcess; // 0x230
        public enderer GetDashboardOverlaySceneProcess; // 0x238
        public Alpha ShowDashboard; // 0x240
        public __2 GetPrimaryDashboardDevice; // 0x248
        public et_Bones ShowKeyboard; // 0x250
        public SkeletonChangedCount ShowKeyboardForOverlay; // 0x258
        public tializeBones GetKeyboardText; // 0x260
        public nitializeCapsules HideKeyboard; // 0x268
        public les SetKeyboardTransformAbsolute; // 0x270
        public BoneId SetKeyboardPositionForOverlay; // 0x278
        public applyBoneTranslations ShowMessageOverlay; // 0x280
        public on CloseMessageOverlay; // 0x288
    }

    public class IVROverlayView : ValueType
    {
        public ÏÏÌÏÍÏÍÌÌÍÌÌÏÏÌÌÎ AcquireOverlayView; // 0x10
        public ÏÎÎÏÍÌÎÏ ReleaseOverlayView; // 0x18
        public object PostOverlayEvent; // 0x20
        public ÍÎÍÎÍÏÎÎ IsViewingPermitted; // 0x28
    }

    public class IVRPaths : ValueType
    {
        public ÏÌÏÎÌÌÏÎÍÎÍÍÏÎÎÍÌÍÏÎÏÎÍ ReadPathBatch; // 0x10
        public ÎÍÌÍÏÎÏÎÍ WritePathBatch; // 0x18
        public Í StringToHandle; // 0x20
        public object HandleToString; // 0x28
    }

    public class IVRProperties : ValueType
    {
        public object ReadPropertyBatch; // 0x10
        public object WritePropertyBatch; // 0x18
        public get_QueryType GetPropErrorNameFromEnum; // 0x20
        public object TrackedDeviceToPropertyContainer; // 0x28
    }

    public class IVRRenderModels : ValueType
    {
        public ackingField LoadRenderModel_Async; // 0x10
        public BoneTranslations FreeRenderModel; // 0x18
        public arentBoneIndex LoadTexture_Async; // 0x20
        public Index FreeTexture; // 0x28
        public nsform LoadTextureD3D11_Async; // 0x30
        public <Transform>k__BackingField LoadIntoTextureD3D11_Async; // 0x38
        public e FreeTextureD3D11; // 0x40
        public CapsuleRigidbody GetRenderModelName; // 0x48
        public t_CapsuleCollider GetRenderModelCount; // 0x50
        public eIndex GetComponentCount; // 0x58
        public Body GetComponentName; // 0x60
        public leRigidbody>k__BackingField GetComponentButtonMask; // 0x68
        public eld GetComponentRenderModelName; // 0x70
        public er GetComponentStateForDevicePath; // 0x78
        public faultMaterial GetComponentState; // 0x80
        public uleMaterial RenderModelHasComponent; // 0x88
        public ltMaterial GetRenderModelThumbnailURL; // 0x90
        public boneVisualizations GetRenderModelOriginalPath; // 0x98
        public capsuleRotationOffset GetRenderModelErrorNameFromEnum; // 0xA0
    }

    public class IVRResources : ValueType
    {
        public object LoadSharedResource; // 0x10
        public _IsValid GetResourceFullPath; // 0x18
    }

    public class IVRScreenshots : ValueType
    {
        public appGpuTime_IsValid RequestScreenshot; // 0x10
        public object HookScreenshot; // 0x18
        public ime GetScreenshotPropertyType; // 0x20
        public ositorDroppedFrameCount GetScreenshotPropertyFilename; // 0x28
        public aceWarpMode UpdateScreenshotProgress; // 0x30
        public sValid TakeStereoScreenshot; // 0x38
        public rcentage SubmitScreenshot; // 0x40
    }

    public class IVRSettings : ValueType
    {
        public object GetSettingsErrorNameFromEnum; // 0x10
        public leVisualization SetBool; // 0x18
        public uleScale SetInt32; // 0x20
        public atorModeDomeTest SetFloat; // 0x28
        public pdateSpectatorCameraStatus SetString; // 0x30
        public torCameraStatus GetBool; // 0x38
        public Status GetInt32; // 0x40
        public ctatorAnchorPosition GetFloat; // 0x48
        public orPosition GetString; // 0x50
        public meraDomePosition RemoveSection; // 0x58
        public n RemoveKeyInSection; // 0x60
    }

    public class IVRSpatialAnchors : ValueType
    {
        public nionContainerType CreateSpatialAnchorFromDescriptor; // 0x10
        public ect CreateSpatialAnchorFromPose; // 0x18
        public le GetSpatialAnchorPose; // 0x20
        public ect GetSpatialAnchorDescriptor; // 0x28
    }

    public class IVRSystem : ValueType
    {
        public derComparer GetRecommendedRenderTargetSize; // 0x10
        public eCaptureRequestId GetProjectionMatrix; // 0x18
        public object GetProjectionRaw; // 0x20
        public Index ComputeDistortion; // 0x28
        public me GetEyeToHeadTransform; // 0x30
        public _BackingField GetTimeSinceLastVsync; // 0x38
        public hors GetD3D9AdapterIndex; // 0x40
        public yAllBounded2DEnabled GetDXGIOutputInfo; // 0x48
        public ayoutEnabledForAllEntitiesInside GetOutputDevice; // 0x50
        public outEnabledForRoomBox IsDisplayOnDesktop; // 0x58
        public object SetDisplayVisibility; // 0x60
        public ult>g__EnabledComponents|0 GetDeviceToAbsoluteTrackingPose; // 0x68
        public ceneManager GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x70
        public del GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x78
        public oSceneModelToLoad GetSortedTrackedDeviceIndicesOfClass; // 0x80
        public tToLoadSceneModel>d__6 GetTrackedDeviceActivityLevel; // 0x88
        public imensions ApplyTransform; // 0x90
        public cenePlaneMeshFilter GetTrackedDeviceIndexForControllerRole; // 0x98
        public r GetControllerRoleForTrackedDeviceIndex; // 0xA0
        public tionCallbackReceiver.OnAfterDeserialize>g__IndexOf|4_0 GetTrackedDeviceClass; // 0xA8
        public AfterDeserialize>g__IndexOf|4_0 IsTrackedDeviceConnected; // 0xB0
        public f|4_0 GetBoolTrackedDeviceProperty; // 0xB8
        public torClassificationIndex GetFloatTrackedDeviceProperty; // 0xC0
        public Volume GetInt32TrackedDeviceProperty; // 0xC8
        public VRSemanticClassification GetUint64TrackedDeviceProperty; // 0xD0
        public els GetMatrix34TrackedDeviceProperty; // 0xD8
        public Uuid GetArrayTrackedDeviceProperty; // 0xE0
        public t_MaxResults GetStringTrackedDeviceProperty; // 0xE8
        public get_QueryType GetPropErrorNameFromEnum; // 0xF0
        public e PollNextEvent; // 0xF8
        public t_ComponentFilter PollNextEventWithPose; // 0x100
        public omponentFilter GetEventTypeNameFromEnum; // 0x108
        public t_UuidFilter GetHiddenAreaMesh; // 0x110
        public rySpaces GetControllerState; // 0x118
        public ingField GetControllerStateWithPose; // 0x120
        public ingField TriggerHapticPulse; // 0x128
        public object GetButtonIdNameFromEnum; // 0x130
        public ialAnchor GetControllerAxisTypeNameFromEnum; // 0x138
        public nitializeFromExisting IsInputAvailable; // 0x140
        public ing IsSteamVRDrawingControllers; // 0x148
        public nitializeUnchecked ShouldApplicationPause; // 0x150
        public ackingSpacePose ShouldApplicationReduceRenderingWork; // 0x158
        public omplete PerformFirmwareUpdate; // 0x160
        public lete AcknowledgeQuit_Exiting; // 0x168
        public object GetAppContainerFilePaths; // 0x170
        public ÎÍÍÌÏÌÌÍÎÍÎÏÎÏÍÌÏÏ GetRuntimeVersion; // 0x178
    }

    public class IVRTrackedCamera : ValueType
    {
        public >k__BackingField GetCameraErrorNameFromEnum; // 0x10
        public axAnchorCount HasCamera; // 0x18
        public et_Localizing GetCameraFrameSize; // 0x20
        public dTo GetCameraIntrinsics; // 0x28
        public ssage GetCameraProjection; // 0x30
        public get_isPositionTracked AcquireVideoStreamingService; // 0x38
        public se ReleaseVideoStreamingService; // 0x40
        public onTracked GetVideoStreamFrameBuffer; // 0x48
        public tion GetVideoStreamTextureSize; // 0x50
        public ializeControllerModels GetVideoStreamTextureD3D11; // 0x58
        public ontroller GetVideoStreamTextureGL; // 0x60
        public ftSRightController ReleaseVideoStreamTextureGL; // 0x68
        public object SetCameraTrackingSpace; // 0x70
        public ÎÎÏÎÏÏÎÏÏ GetCameraTrackingSpace; // 0x78
    }

    public class ImuSample_t : ValueType
    {
        public double fSampleTime; // 0x10
        public tup vAccel; // 0x18
        public tup vGyro; // 0x30
        public uint unOffScaleFlags; // 0x48
    }

    public class InputAnalogActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public float x; // 0x20
        public float y; // 0x24
        public float z; // 0x28
        public float deltaX; // 0x2C
        public float deltaY; // 0x30
        public float deltaZ; // 0x34
        public float fUpdateTime; // 0x38
    }

    public class InputBindingInfo_t : ValueType
    {
        public byte rchDevicePathName; // 0x10
        public byte rchInputPathName; // 0x11
        public byte rchModeName; // 0x12
        public byte rchSlotName; // 0x13
        public byte rchInputSourceType; // 0x14
        public byte rchDevicePathName5; // 0x15
        public byte rchDevicePathName6; // 0x16
        public byte rchDevicePathName7; // 0x17
        public byte rchDevicePathName8; // 0x18
        public byte rchDevicePathName9; // 0x19
        public byte rchDevicePathName10; // 0x1A
        public byte rchDevicePathName11; // 0x1B
        public byte rchDevicePathName12; // 0x1C
        public byte rchDevicePathName13; // 0x1D
        public byte rchDevicePathName14; // 0x1E
        public byte rchDevicePathName15; // 0x1F
        public byte rchDevicePathName16; // 0x20
        public byte rchDevicePathName17; // 0x21
        public byte rchDevicePathName18; // 0x22
        public byte rchDevicePathName19; // 0x23
        public byte rchDevicePathName20; // 0x24
        public byte rchDevicePathName21; // 0x25
        public byte rchDevicePathName22; // 0x26
        public byte rchDevicePathName23; // 0x27
        public byte rchDevicePathName24; // 0x28
        public byte rchDevicePathName25; // 0x29
        public byte rchDevicePathName26; // 0x2A
        public byte rchDevicePathName27; // 0x2B
        public byte rchDevicePathName28; // 0x2C
        public byte rchDevicePathName29; // 0x2D
        public byte rchDevicePathName30; // 0x2E
        public byte rchDevicePathName31; // 0x2F
        public byte rchDevicePathName32; // 0x30
        public byte rchDevicePathName33; // 0x31
        public byte rchDevicePathName34; // 0x32
        public byte rchDevicePathName35; // 0x33
        public byte rchDevicePathName36; // 0x34
        public byte rchDevicePathName37; // 0x35
        public byte rchDevicePathName38; // 0x36
        public byte rchDevicePathName39; // 0x37
        public byte rchDevicePathName40; // 0x38
        public byte rchDevicePathName41; // 0x39
        public byte rchDevicePathName42; // 0x3A
        public byte rchDevicePathName43; // 0x3B
        public byte rchDevicePathName44; // 0x3C
        public byte rchDevicePathName45; // 0x3D
        public byte rchDevicePathName46; // 0x3E
        public byte rchDevicePathName47; // 0x3F
        public byte rchDevicePathName48; // 0x40
        public byte rchDevicePathName49; // 0x41
        public byte rchDevicePathName50; // 0x42
        public byte rchDevicePathName51; // 0x43
        public byte rchDevicePathName52; // 0x44
        public byte rchDevicePathName53; // 0x45
        public byte rchDevicePathName54; // 0x46
        public byte rchDevicePathName55; // 0x47
        public byte rchDevicePathName56; // 0x48
        public byte rchDevicePathName57; // 0x49
        public byte rchDevicePathName58; // 0x4A
        public byte rchDevicePathName59; // 0x4B
        public byte rchDevicePathName60; // 0x4C
        public byte rchDevicePathName61; // 0x4D
        public byte rchDevicePathName62; // 0x4E
        public byte rchDevicePathName63; // 0x4F
        public byte rchDevicePathName64; // 0x50
        public byte rchDevicePathName65; // 0x51
        public byte rchDevicePathName66; // 0x52
        public byte rchDevicePathName67; // 0x53
        public byte rchDevicePathName68; // 0x54
        public byte rchDevicePathName69; // 0x55
        public byte rchDevicePathName70; // 0x56
        public byte rchDevicePathName71; // 0x57
        public byte rchDevicePathName72; // 0x58
        public byte rchDevicePathName73; // 0x59
        public byte rchDevicePathName74; // 0x5A
        public byte rchDevicePathName75; // 0x5B
        public byte rchDevicePathName76; // 0x5C
        public byte rchDevicePathName77; // 0x5D
        public byte rchDevicePathName78; // 0x5E
        public byte rchDevicePathName79; // 0x5F
        public byte rchDevicePathName80; // 0x60
        public byte rchDevicePathName81; // 0x61
        public byte rchDevicePathName82; // 0x62
        public byte rchDevicePathName83; // 0x63
        public byte rchDevicePathName84; // 0x64
        public byte rchDevicePathName85; // 0x65
        public byte rchDevicePathName86; // 0x66
        public byte rchDevicePathName87; // 0x67
        public byte rchDevicePathName88; // 0x68
        public byte rchDevicePathName89; // 0x69
        public byte rchDevicePathName90; // 0x6A
        public byte rchDevicePathName91; // 0x6B
        public byte rchDevicePathName92; // 0x6C
        public byte rchDevicePathName93; // 0x6D
        public byte rchDevicePathName94; // 0x6E
        public byte rchDevicePathName95; // 0x6F
        public byte rchDevicePathName96; // 0x70
        public byte rchDevicePathName97; // 0x71
        public byte rchDevicePathName98; // 0x72
        public byte rchDevicePathName99; // 0x73
        public byte rchDevicePathName100; // 0x74
        public byte rchDevicePathName101; // 0x75
        public byte rchDevicePathName102; // 0x76
        public byte rchDevicePathName103; // 0x77
        public byte rchDevicePathName104; // 0x78
        public byte rchDevicePathName105; // 0x79
        public byte rchDevicePathName106; // 0x7A
        public byte rchDevicePathName107; // 0x7B
        public byte rchDevicePathName108; // 0x7C
        public byte rchDevicePathName109; // 0x7D
        public byte rchDevicePathName110; // 0x7E
        public byte rchDevicePathName111; // 0x7F
        public byte rchDevicePathName112; // 0x80
        public byte rchDevicePathName113; // 0x81
        public byte rchDevicePathName114; // 0x82
        public byte rchDevicePathName115; // 0x83
        public byte rchDevicePathName116; // 0x84
        public byte rchDevicePathName117; // 0x85
        public byte rchDevicePathName118; // 0x86
        public byte rchDevicePathName119; // 0x87
        public byte rchDevicePathName120; // 0x88
        public byte rchDevicePathName121; // 0x89
        public byte rchDevicePathName122; // 0x8A
        public byte rchDevicePathName123; // 0x8B
        public byte rchDevicePathName124; // 0x8C
        public byte rchDevicePathName125; // 0x8D
        public byte rchDevicePathName126; // 0x8E
        public byte rchDevicePathName127; // 0x8F
        public byte rchInputPathName0; // 0x90
        public byte rchInputPathName1; // 0x91
        public byte rchInputPathName2; // 0x92
        public byte rchInputPathName3; // 0x93
        public byte rchInputPathName4; // 0x94
        public byte rchInputPathName5; // 0x95
        public byte rchInputPathName6; // 0x96
        public byte rchInputPathName7; // 0x97
        public byte rchInputPathName8; // 0x98
        public byte rchInputPathName9; // 0x99
        public byte rchInputPathName10; // 0x9A
        public byte rchInputPathName11; // 0x9B
        public byte rchInputPathName12; // 0x9C
        public byte rchInputPathName13; // 0x9D
        public byte rchInputPathName14; // 0x9E
        public byte rchInputPathName15; // 0x9F
        public byte rchInputPathName16; // 0xA0
        public byte rchInputPathName17; // 0xA1
        public byte rchInputPathName18; // 0xA2
        public byte rchInputPathName19; // 0xA3
        public byte rchInputPathName20; // 0xA4
        public byte rchInputPathName21; // 0xA5
        public byte rchInputPathName22; // 0xA6
        public byte rchInputPathName23; // 0xA7
        public byte rchInputPathName24; // 0xA8
        public byte rchInputPathName25; // 0xA9
        public byte rchInputPathName26; // 0xAA
        public byte rchInputPathName27; // 0xAB
        public byte rchInputPathName28; // 0xAC
        public byte rchInputPathName29; // 0xAD
        public byte rchInputPathName30; // 0xAE
        public byte rchInputPathName31; // 0xAF
        public byte rchInputPathName32; // 0xB0
        public byte rchInputPathName33; // 0xB1
        public byte rchInputPathName34; // 0xB2
        public byte rchInputPathName35; // 0xB3
        public byte rchInputPathName36; // 0xB4
        public byte rchInputPathName37; // 0xB5
        public byte rchInputPathName38; // 0xB6
        public byte rchInputPathName39; // 0xB7
        public byte rchInputPathName40; // 0xB8
        public byte rchInputPathName41; // 0xB9
        public byte rchInputPathName42; // 0xBA
        public byte rchInputPathName43; // 0xBB
        public byte rchInputPathName44; // 0xBC
        public byte rchInputPathName45; // 0xBD
        public byte rchInputPathName46; // 0xBE
        public byte rchInputPathName47; // 0xBF
        public byte rchInputPathName48; // 0xC0
        public byte rchInputPathName49; // 0xC1
        public byte rchInputPathName50; // 0xC2
        public byte rchInputPathName51; // 0xC3
        public byte rchInputPathName52; // 0xC4
        public byte rchInputPathName53; // 0xC5
        public byte rchInputPathName54; // 0xC6
        public byte rchInputPathName55; // 0xC7
        public byte rchInputPathName56; // 0xC8
        public byte rchInputPathName57; // 0xC9
        public byte rchInputPathName58; // 0xCA
        public byte rchInputPathName59; // 0xCB
        public byte rchInputPathName60; // 0xCC
        public byte rchInputPathName61; // 0xCD
        public byte rchInputPathName62; // 0xCE
        public byte rchInputPathName63; // 0xCF
        public byte rchInputPathName64; // 0xD0
        public byte rchInputPathName65; // 0xD1
        public byte rchInputPathName66; // 0xD2
        public byte rchInputPathName67; // 0xD3
        public byte rchInputPathName68; // 0xD4
        public byte rchInputPathName69; // 0xD5
        public byte rchInputPathName70; // 0xD6
        public byte rchInputPathName71; // 0xD7
        public byte rchInputPathName72; // 0xD8
        public byte rchInputPathName73; // 0xD9
        public byte rchInputPathName74; // 0xDA
        public byte rchInputPathName75; // 0xDB
        public byte rchInputPathName76; // 0xDC
        public byte rchInputPathName77; // 0xDD
        public byte rchInputPathName78; // 0xDE
        public byte rchInputPathName79; // 0xDF
        public byte rchInputPathName80; // 0xE0
        public byte rchInputPathName81; // 0xE1
        public byte rchInputPathName82; // 0xE2
        public byte rchInputPathName83; // 0xE3
        public byte rchInputPathName84; // 0xE4
        public byte rchInputPathName85; // 0xE5
        public byte rchInputPathName86; // 0xE6
        public byte rchInputPathName87; // 0xE7
        public byte rchInputPathName88; // 0xE8
        public byte rchInputPathName89; // 0xE9
        public byte rchInputPathName90; // 0xEA
        public byte rchInputPathName91; // 0xEB
        public byte rchInputPathName92; // 0xEC
        public byte rchInputPathName93; // 0xED
        public byte rchInputPathName94; // 0xEE
        public byte rchInputPathName95; // 0xEF
        public byte rchInputPathName96; // 0xF0
        public byte rchInputPathName97; // 0xF1
        public byte rchInputPathName98; // 0xF2
        public byte rchInputPathName99; // 0xF3
        public byte rchInputPathName100; // 0xF4
        public byte rchInputPathName101; // 0xF5
        public byte rchInputPathName102; // 0xF6
        public byte rchInputPathName103; // 0xF7
        public byte rchInputPathName104; // 0xF8
        public byte rchInputPathName105; // 0xF9
        public byte rchInputPathName106; // 0xFA
        public byte rchInputPathName107; // 0xFB
        public byte rchInputPathName108; // 0xFC
        public byte rchInputPathName109; // 0xFD
        public byte rchInputPathName110; // 0xFE
        public byte rchInputPathName111; // 0xFF
        public byte rchInputPathName112; // 0x100
        public byte rchInputPathName113; // 0x101
        public byte rchInputPathName114; // 0x102
        public byte rchInputPathName115; // 0x103
        public byte rchInputPathName116; // 0x104
        public byte rchInputPathName117; // 0x105
        public byte rchInputPathName118; // 0x106
        public byte rchInputPathName119; // 0x107
        public byte rchInputPathName120; // 0x108
        public byte rchInputPathName121; // 0x109
        public byte rchInputPathName122; // 0x10A
        public byte rchInputPathName123; // 0x10B
        public byte rchInputPathName124; // 0x10C
        public byte rchInputPathName125; // 0x10D
        public byte rchInputPathName126; // 0x10E
        public byte rchInputPathName127; // 0x10F
        public byte rchModeName0; // 0x110
        public byte rchModeName1; // 0x111
        public byte rchModeName2; // 0x112
        public byte rchModeName3; // 0x113
        public byte rchModeName4; // 0x114
        public byte rchModeName5; // 0x115
        public byte rchModeName6; // 0x116
        public byte rchModeName7; // 0x117
        public byte rchModeName8; // 0x118
        public byte rchModeName9; // 0x119
        public byte rchModeName10; // 0x11A
        public byte rchModeName11; // 0x11B
        public byte rchModeName12; // 0x11C
        public byte rchModeName13; // 0x11D
        public byte rchModeName14; // 0x11E
        public byte rchModeName15; // 0x11F
        public byte rchModeName16; // 0x120
        public byte rchModeName17; // 0x121
        public byte rchModeName18; // 0x122
        public byte rchModeName19; // 0x123
        public byte rchModeName20; // 0x124
        public byte rchModeName21; // 0x125
        public byte rchModeName22; // 0x126
        public byte rchModeName23; // 0x127
        public byte rchModeName24; // 0x128
        public byte rchModeName25; // 0x129
        public byte rchModeName26; // 0x12A
        public byte rchModeName27; // 0x12B
        public byte rchModeName28; // 0x12C
        public byte rchModeName29; // 0x12D
        public byte rchModeName30; // 0x12E
        public byte rchModeName31; // 0x12F
        public byte rchModeName32; // 0x130
        public byte rchModeName33; // 0x131
        public byte rchModeName34; // 0x132
        public byte rchModeName35; // 0x133
        public byte rchModeName36; // 0x134
        public byte rchModeName37; // 0x135
        public byte rchModeName38; // 0x136
        public byte rchModeName39; // 0x137
        public byte rchModeName40; // 0x138
        public byte rchModeName41; // 0x139
        public byte rchModeName42; // 0x13A
        public byte rchModeName43; // 0x13B
        public byte rchModeName44; // 0x13C
        public byte rchModeName45; // 0x13D
        public byte rchModeName46; // 0x13E
        public byte rchModeName47; // 0x13F
        public byte rchModeName48; // 0x140
        public byte rchModeName49; // 0x141
        public byte rchModeName50; // 0x142
        public byte rchModeName51; // 0x143
        public byte rchModeName52; // 0x144
        public byte rchModeName53; // 0x145
        public byte rchModeName54; // 0x146
        public byte rchModeName55; // 0x147
        public byte rchModeName56; // 0x148
        public byte rchModeName57; // 0x149
        public byte rchModeName58; // 0x14A
        public byte rchModeName59; // 0x14B
        public byte rchModeName60; // 0x14C
        public byte rchModeName61; // 0x14D
        public byte rchModeName62; // 0x14E
        public byte rchModeName63; // 0x14F
        public byte rchModeName64; // 0x150
        public byte rchModeName65; // 0x151
        public byte rchModeName66; // 0x152
        public byte rchModeName67; // 0x153
        public byte rchModeName68; // 0x154
        public byte rchModeName69; // 0x155
        public byte rchModeName70; // 0x156
        public byte rchModeName71; // 0x157
        public byte rchModeName72; // 0x158
        public byte rchModeName73; // 0x159
        public byte rchModeName74; // 0x15A
        public byte rchModeName75; // 0x15B
        public byte rchModeName76; // 0x15C
        public byte rchModeName77; // 0x15D
        public byte rchModeName78; // 0x15E
        public byte rchModeName79; // 0x15F
        public byte rchModeName80; // 0x160
        public byte rchModeName81; // 0x161
        public byte rchModeName82; // 0x162
        public byte rchModeName83; // 0x163
        public byte rchModeName84; // 0x164
        public byte rchModeName85; // 0x165
        public byte rchModeName86; // 0x166
        public byte rchModeName87; // 0x167
        public byte rchModeName88; // 0x168
        public byte rchModeName89; // 0x169
        public byte rchModeName90; // 0x16A
        public byte rchModeName91; // 0x16B
        public byte rchModeName92; // 0x16C
        public byte rchModeName93; // 0x16D
        public byte rchModeName94; // 0x16E
        public byte rchModeName95; // 0x16F
        public byte rchModeName96; // 0x170
        public byte rchModeName97; // 0x171
        public byte rchModeName98; // 0x172
        public byte rchModeName99; // 0x173
        public byte rchModeName100; // 0x174
        public byte rchModeName101; // 0x175
        public byte rchModeName102; // 0x176
        public byte rchModeName103; // 0x177
        public byte rchModeName104; // 0x178
        public byte rchModeName105; // 0x179
        public byte rchModeName106; // 0x17A
        public byte rchModeName107; // 0x17B
        public byte rchModeName108; // 0x17C
        public byte rchModeName109; // 0x17D
        public byte rchModeName110; // 0x17E
        public byte rchModeName111; // 0x17F
        public byte rchModeName112; // 0x180
        public byte rchModeName113; // 0x181
        public byte rchModeName114; // 0x182
        public byte rchModeName115; // 0x183
        public byte rchModeName116; // 0x184
        public byte rchModeName117; // 0x185
        public byte rchModeName118; // 0x186
        public byte rchModeName119; // 0x187
        public byte rchModeName120; // 0x188
        public byte rchModeName121; // 0x189
        public byte rchModeName122; // 0x18A
        public byte rchModeName123; // 0x18B
        public byte rchModeName124; // 0x18C
        public byte rchModeName125; // 0x18D
        public byte rchModeName126; // 0x18E
        public byte rchModeName127; // 0x18F
        public byte rchSlotName0; // 0x190
        public byte rchSlotName1; // 0x191
        public byte rchSlotName2; // 0x192
        public byte rchSlotName3; // 0x193
        public byte rchSlotName4; // 0x194
        public byte rchSlotName5; // 0x195
        public byte rchSlotName6; // 0x196
        public byte rchSlotName7; // 0x197
        public byte rchSlotName8; // 0x198
        public byte rchSlotName9; // 0x199
        public byte rchSlotName10; // 0x19A
        public byte rchSlotName11; // 0x19B
        public byte rchSlotName12; // 0x19C
        public byte rchSlotName13; // 0x19D
        public byte rchSlotName14; // 0x19E
        public byte rchSlotName15; // 0x19F
        public byte rchSlotName16; // 0x1A0
        public byte rchSlotName17; // 0x1A1
        public byte rchSlotName18; // 0x1A2
        public byte rchSlotName19; // 0x1A3
        public byte rchSlotName20; // 0x1A4
        public byte rchSlotName21; // 0x1A5
        public byte rchSlotName22; // 0x1A6
        public byte rchSlotName23; // 0x1A7
        public byte rchSlotName24; // 0x1A8
        public byte rchSlotName25; // 0x1A9
        public byte rchSlotName26; // 0x1AA
        public byte rchSlotName27; // 0x1AB
        public byte rchSlotName28; // 0x1AC
        public byte rchSlotName29; // 0x1AD
        public byte rchSlotName30; // 0x1AE
        public byte rchSlotName31; // 0x1AF
        public byte rchSlotName32; // 0x1B0
        public byte rchSlotName33; // 0x1B1
        public byte rchSlotName34; // 0x1B2
        public byte rchSlotName35; // 0x1B3
        public byte rchSlotName36; // 0x1B4
        public byte rchSlotName37; // 0x1B5
        public byte rchSlotName38; // 0x1B6
        public byte rchSlotName39; // 0x1B7
        public byte rchSlotName40; // 0x1B8
        public byte rchSlotName41; // 0x1B9
        public byte rchSlotName42; // 0x1BA
        public byte rchSlotName43; // 0x1BB
        public byte rchSlotName44; // 0x1BC
        public byte rchSlotName45; // 0x1BD
        public byte rchSlotName46; // 0x1BE
        public byte rchSlotName47; // 0x1BF
        public byte rchSlotName48; // 0x1C0
        public byte rchSlotName49; // 0x1C1
        public byte rchSlotName50; // 0x1C2
        public byte rchSlotName51; // 0x1C3
        public byte rchSlotName52; // 0x1C4
        public byte rchSlotName53; // 0x1C5
        public byte rchSlotName54; // 0x1C6
        public byte rchSlotName55; // 0x1C7
        public byte rchSlotName56; // 0x1C8
        public byte rchSlotName57; // 0x1C9
        public byte rchSlotName58; // 0x1CA
        public byte rchSlotName59; // 0x1CB
        public byte rchSlotName60; // 0x1CC
        public byte rchSlotName61; // 0x1CD
        public byte rchSlotName62; // 0x1CE
        public byte rchSlotName63; // 0x1CF
        public byte rchSlotName64; // 0x1D0
        public byte rchSlotName65; // 0x1D1
        public byte rchSlotName66; // 0x1D2
        public byte rchSlotName67; // 0x1D3
        public byte rchSlotName68; // 0x1D4
        public byte rchSlotName69; // 0x1D5
        public byte rchSlotName70; // 0x1D6
        public byte rchSlotName71; // 0x1D7
        public byte rchSlotName72; // 0x1D8
        public byte rchSlotName73; // 0x1D9
        public byte rchSlotName74; // 0x1DA
        public byte rchSlotName75; // 0x1DB
        public byte rchSlotName76; // 0x1DC
        public byte rchSlotName77; // 0x1DD
        public byte rchSlotName78; // 0x1DE
        public byte rchSlotName79; // 0x1DF
        public byte rchSlotName80; // 0x1E0
        public byte rchSlotName81; // 0x1E1
        public byte rchSlotName82; // 0x1E2
        public byte rchSlotName83; // 0x1E3
        public byte rchSlotName84; // 0x1E4
        public byte rchSlotName85; // 0x1E5
        public byte rchSlotName86; // 0x1E6
        public byte rchSlotName87; // 0x1E7
        public byte rchSlotName88; // 0x1E8
        public byte rchSlotName89; // 0x1E9
        public byte rchSlotName90; // 0x1EA
        public byte rchSlotName91; // 0x1EB
        public byte rchSlotName92; // 0x1EC
        public byte rchSlotName93; // 0x1ED
        public byte rchSlotName94; // 0x1EE
        public byte rchSlotName95; // 0x1EF
        public byte rchSlotName96; // 0x1F0
        public byte rchSlotName97; // 0x1F1
        public byte rchSlotName98; // 0x1F2
        public byte rchSlotName99; // 0x1F3
        public byte rchSlotName100; // 0x1F4
        public byte rchSlotName101; // 0x1F5
        public byte rchSlotName102; // 0x1F6
        public byte rchSlotName103; // 0x1F7
        public byte rchSlotName104; // 0x1F8
        public byte rchSlotName105; // 0x1F9
        public byte rchSlotName106; // 0x1FA
        public byte rchSlotName107; // 0x1FB
        public byte rchSlotName108; // 0x1FC
        public byte rchSlotName109; // 0x1FD
        public byte rchSlotName110; // 0x1FE
        public byte rchSlotName111; // 0x1FF
        public byte rchSlotName112; // 0x200
        public byte rchSlotName113; // 0x201
        public byte rchSlotName114; // 0x202
        public byte rchSlotName115; // 0x203
        public byte rchSlotName116; // 0x204
        public byte rchSlotName117; // 0x205
        public byte rchSlotName118; // 0x206
        public byte rchSlotName119; // 0x207
        public byte rchSlotName120; // 0x208
        public byte rchSlotName121; // 0x209
        public byte rchSlotName122; // 0x20A
        public byte rchSlotName123; // 0x20B
        public byte rchSlotName124; // 0x20C
        public byte rchSlotName125; // 0x20D
        public byte rchSlotName126; // 0x20E
        public byte rchSlotName127; // 0x20F
        public byte rchInputSourceType0; // 0x210
        public byte rchInputSourceType1; // 0x211
        public byte rchInputSourceType2; // 0x212
        public byte rchInputSourceType3; // 0x213
        public byte rchInputSourceType4; // 0x214
        public byte rchInputSourceType5; // 0x215
        public byte rchInputSourceType6; // 0x216
        public byte rchInputSourceType7; // 0x217
        public byte rchInputSourceType8; // 0x218
        public byte rchInputSourceType9; // 0x219
        public byte rchInputSourceType10; // 0x21A
        public byte rchInputSourceType11; // 0x21B
        public byte rchInputSourceType12; // 0x21C
        public byte rchInputSourceType13; // 0x21D
        public byte rchInputSourceType14; // 0x21E
        public byte rchInputSourceType15; // 0x21F
        public byte rchInputSourceType16; // 0x220
        public byte rchInputSourceType17; // 0x221
        public byte rchInputSourceType18; // 0x222
        public byte rchInputSourceType19; // 0x223
        public byte rchInputSourceType20; // 0x224
        public byte rchInputSourceType21; // 0x225
        public byte rchInputSourceType22; // 0x226
        public byte rchInputSourceType23; // 0x227
        public byte rchInputSourceType24; // 0x228
        public byte rchInputSourceType25; // 0x229
        public byte rchInputSourceType26; // 0x22A
        public byte rchInputSourceType27; // 0x22B
        public byte rchInputSourceType28; // 0x22C
        public byte rchInputSourceType29; // 0x22D
        public byte rchInputSourceType30; // 0x22E
        public byte rchInputSourceType31; // 0x22F

        // ── Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x7FFD54C20E60
        public void get_rchInputPathName(){} // RVA: 0x7FFD54C218D0
        public void get_rchModeName(){} // RVA: 0x7FFD54C224C0
        public void get_rchSlotName(){} // RVA: 0x7FFD54C230B0
        public void get_rchInputSourceType(){} // RVA: 0x7FFD54C23CA0
    }

    public class InputDigitalActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public bool bState; // 0x20
        public bool bChanged; // 0x21
        public float fUpdateTime; // 0x24
    }

    public class InputOriginInfo_t : ValueType
    {
        public ulong rchRenderModelComponentName; // 0x10
        public uint trackedDeviceIndex; // 0x18
        public byte rchRenderModelComponentName0; // 0x1C
        public byte rchRenderModelComponentName1; // 0x1D
        public byte rchRenderModelComponentName2; // 0x1E
        public byte rchRenderModelComponentName3; // 0x1F
        public byte rchRenderModelComponentName4; // 0x20
        public byte rchRenderModelComponentName5; // 0x21
        public byte rchRenderModelComponentName6; // 0x22
        public byte rchRenderModelComponentName7; // 0x23
        public byte rchRenderModelComponentName8; // 0x24
        public byte rchRenderModelComponentName9; // 0x25
        public byte rchRenderModelComponentName10; // 0x26
        public byte rchRenderModelComponentName11; // 0x27
        public byte rchRenderModelComponentName12; // 0x28
        public byte rchRenderModelComponentName13; // 0x29
        public byte rchRenderModelComponentName14; // 0x2A
        public byte rchRenderModelComponentName15; // 0x2B
        public byte rchRenderModelComponentName16; // 0x2C
        public byte rchRenderModelComponentName17; // 0x2D
        public byte rchRenderModelComponentName18; // 0x2E
        public byte rchRenderModelComponentName19; // 0x2F
        public byte rchRenderModelComponentName20; // 0x30
        public byte rchRenderModelComponentName21; // 0x31
        public byte rchRenderModelComponentName22; // 0x32
        public byte rchRenderModelComponentName23; // 0x33
        public byte rchRenderModelComponentName24; // 0x34
        public byte rchRenderModelComponentName25; // 0x35
        public byte rchRenderModelComponentName26; // 0x36
        public byte rchRenderModelComponentName27; // 0x37
        public byte rchRenderModelComponentName28; // 0x38
        public byte rchRenderModelComponentName29; // 0x39
        public byte rchRenderModelComponentName30; // 0x3A
        public byte rchRenderModelComponentName31; // 0x3B
        public byte rchRenderModelComponentName32; // 0x3C
        public byte rchRenderModelComponentName33; // 0x3D
        public byte rchRenderModelComponentName34; // 0x3E
        public byte rchRenderModelComponentName35; // 0x3F
        public byte rchRenderModelComponentName36; // 0x40
        public byte rchRenderModelComponentName37; // 0x41
        public byte rchRenderModelComponentName38; // 0x42
        public byte rchRenderModelComponentName39; // 0x43
        public byte rchRenderModelComponentName40; // 0x44
        public byte rchRenderModelComponentName41; // 0x45
        public byte rchRenderModelComponentName42; // 0x46
        public byte rchRenderModelComponentName43; // 0x47
        public byte rchRenderModelComponentName44; // 0x48
        public byte rchRenderModelComponentName45; // 0x49
        public byte rchRenderModelComponentName46; // 0x4A
        public byte rchRenderModelComponentName47; // 0x4B
        public byte rchRenderModelComponentName48; // 0x4C
        public byte rchRenderModelComponentName49; // 0x4D
        public byte rchRenderModelComponentName50; // 0x4E
        public byte rchRenderModelComponentName51; // 0x4F
        public byte rchRenderModelComponentName52; // 0x50
        public byte rchRenderModelComponentName53; // 0x51
        public byte rchRenderModelComponentName54; // 0x52
        public byte rchRenderModelComponentName55; // 0x53
        public byte rchRenderModelComponentName56; // 0x54
        public byte rchRenderModelComponentName57; // 0x55
        public byte rchRenderModelComponentName58; // 0x56
        public byte rchRenderModelComponentName59; // 0x57
        public byte rchRenderModelComponentName60; // 0x58
        public byte rchRenderModelComponentName61; // 0x59
        public byte rchRenderModelComponentName62; // 0x5A
        public byte rchRenderModelComponentName63; // 0x5B
        public byte rchRenderModelComponentName64; // 0x5C
        public byte rchRenderModelComponentName65; // 0x5D
        public byte rchRenderModelComponentName66; // 0x5E
        public byte rchRenderModelComponentName67; // 0x5F
        public byte rchRenderModelComponentName68; // 0x60
        public byte rchRenderModelComponentName69; // 0x61
        public byte rchRenderModelComponentName70; // 0x62
        public byte rchRenderModelComponentName71; // 0x63
        public byte rchRenderModelComponentName72; // 0x64
        public byte rchRenderModelComponentName73; // 0x65
        public byte rchRenderModelComponentName74; // 0x66
        public byte rchRenderModelComponentName75; // 0x67
        public byte rchRenderModelComponentName76; // 0x68
        public byte rchRenderModelComponentName77; // 0x69
        public byte rchRenderModelComponentName78; // 0x6A
        public byte rchRenderModelComponentName79; // 0x6B
        public byte rchRenderModelComponentName80; // 0x6C
        public byte rchRenderModelComponentName81; // 0x6D
        public byte rchRenderModelComponentName82; // 0x6E
        public byte rchRenderModelComponentName83; // 0x6F
        public byte rchRenderModelComponentName84; // 0x70
        public byte rchRenderModelComponentName85; // 0x71
        public byte rchRenderModelComponentName86; // 0x72
        public byte rchRenderModelComponentName87; // 0x73
        public byte rchRenderModelComponentName88; // 0x74
        public byte rchRenderModelComponentName89; // 0x75
        public byte rchRenderModelComponentName90; // 0x76
        public byte rchRenderModelComponentName91; // 0x77
        public byte rchRenderModelComponentName92; // 0x78
        public byte rchRenderModelComponentName93; // 0x79
        public byte rchRenderModelComponentName94; // 0x7A
        public byte rchRenderModelComponentName95; // 0x7B
        public byte rchRenderModelComponentName96; // 0x7C
        public byte rchRenderModelComponentName97; // 0x7D
        public byte rchRenderModelComponentName98; // 0x7E
        public byte rchRenderModelComponentName99; // 0x7F
        public byte rchRenderModelComponentName100; // 0x80
        public byte rchRenderModelComponentName101; // 0x81
        public byte rchRenderModelComponentName102; // 0x82
        public byte rchRenderModelComponentName103; // 0x83
        public byte rchRenderModelComponentName104; // 0x84
        public byte rchRenderModelComponentName105; // 0x85
        public byte rchRenderModelComponentName106; // 0x86
        public byte rchRenderModelComponentName107; // 0x87
        public byte rchRenderModelComponentName108; // 0x88
        public byte rchRenderModelComponentName109; // 0x89
        public byte rchRenderModelComponentName110; // 0x8A
        public byte rchRenderModelComponentName111; // 0x8B
        public byte rchRenderModelComponentName112; // 0x8C
        public byte rchRenderModelComponentName113; // 0x8D
        public byte rchRenderModelComponentName114; // 0x8E
        public byte rchRenderModelComponentName115; // 0x8F
        public byte rchRenderModelComponentName116; // 0x90
        public byte rchRenderModelComponentName117; // 0x91
        public byte rchRenderModelComponentName118; // 0x92
        public byte rchRenderModelComponentName119; // 0x93
        public byte rchRenderModelComponentName120; // 0x94
        public byte rchRenderModelComponentName121; // 0x95
        public byte rchRenderModelComponentName122; // 0x96
        public byte rchRenderModelComponentName123; // 0x97
        public byte rchRenderModelComponentName124; // 0x98
        public byte rchRenderModelComponentName125; // 0x99
        public byte rchRenderModelComponentName126; // 0x9A
        public byte rchRenderModelComponentName127; // 0x9B

        // ── Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7FFD54C203C0
    }

    public class InputPoseActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
        public fications pose; // 0x20
    }

    public class InputSkeletalActionData_t : ValueType
    {
        public bool bActive; // 0x10
        public ulong activeOrigin; // 0x18
    }

    public class IntersectionMaskCircle_t : ValueType
    {
        public float m_flCenterX; // 0x10
        public float m_flCenterY; // 0x14
        public float m_flRadius; // 0x18
    }

    public class IntersectionMaskRectangle_t : ValueType
    {
        public float m_flTopLeftX; // 0x10
        public float m_flTopLeftY; // 0x14
        public float m_flWidth; // 0x18
        public float m_flHeight; // 0x1C
    }

}