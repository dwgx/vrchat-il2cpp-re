// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 31
// Methods: 398

namespace ThirdParty.Valve.Valve.VR
{
    public class COpenVRContext : ValueType
    {
        public object m_pVRChaperoneSetup; // 0x34C24630
        public object m_pVROverlay; // 0x34C24630
        public object m_pVRRenderModels; // 0x34C24630
        public object m_pVRApplications; // 0x34C24630
        public object m_pVRDriverManager; // 0x34C24630
        public object m_pVRSpatialAnchors; // 0x34C24630
    }

    public class CVRApplications : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf219830
        public void AddApplicationManifest(){} // RVA: 0x7ffaaf219a40
        public void RemoveApplicationManifest(){} // RVA: 0x7ffaaf219b10
        public void IsApplicationInstalled(){} // RVA: 0x7ffaaf219bd0
        public void LaunchApplication(){} // RVA: 0x7ffaaf219c90
        public void LaunchTemplateApplication(){} // RVA: 0x7ffaaf219d50
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7ffaaf219e50
        public void LaunchDashboardOverlay(){} // RVA: 0x7ffaaf219f30
        public void CancelApplicationLaunch(){} // RVA: 0x7ffaaf219ff0
        public void IdentifyApplication(){} // RVA: 0x7ffaaf21a0b0
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7ffaaf21aaa0
        public void LaunchInternalProcess(){} // RVA: 0x7ffaaf21ac10
        // ── Binary Analysis Named ──
        public void GetApplicationCount(){} // RVA: 0x7ffaabf36b30
        public void GetApplicationKeyByIndex(){} // RVA: 0x7ffaae3a2320
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7ffaae3a2350
        public void GetApplicationProcessId(){} // RVA: 0x7ffaaf21a170
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7ffaaf21a230
        public void GetApplicationPropertyString(){} // RVA: 0x7ffaaf21a2e0
        public void GetApplicationPropertyBool(){} // RVA: 0x7ffaaf21a3d0
        public void GetApplicationPropertyUint64(){} // RVA: 0x7ffaaf21a4b0
        public void SetApplicationAutoLaunch(){} // RVA: 0x7ffaaf21a590
        public void GetApplicationAutoLaunch(){} // RVA: 0x7ffaaf21a660
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7ffaaf21a720
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7ffaaf21a800
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7ffaaf21a8e0
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7ffaaf21a9c0
        public void GetApplicationLaunchArguments(){} // RVA: 0x7ffaae3a08e0
        public void GetStartingApplication(){} // RVA: 0x7ffaae3a2660
        public void GetSceneApplicationState(){} // RVA: 0x7ffaae3a2690
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x7ffaaf21ab60
        public void GetCurrentSceneProcessId(){} // RVA: 0x7ffaae3a3810
    }

    public class CVRBlockQueue : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2215a0
        public void Create(){} // RVA: 0x7ffaaf221760
        public void Connect(){} // RVA: 0x7ffaaf221860
        public void Destroy(){} // RVA: 0x7ffaabf08370
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7ffaaf221930
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x7ffaae3a5e60
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x7ffaaf221970
        public void AcquireReadOnlyBlock(){} // RVA: 0x7ffaaf2219b0
        public void ReleaseReadOnlyBlock(){} // RVA: 0x7ffaad0ae920
        public void QueueHasReader(){} // RVA: 0x7ffaaf2219f0
    }

    public class CVRChaperone : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21ad20
        public void ReloadInfo(){} // RVA: 0x7ffaabf36b30
        public void AreBoundsVisible(){} // RVA: 0x7ffaae3a0570
        public void ForceBoundsVisible(){} // RVA: 0x7ffaae3a2a70
        public void ResetZeroPose(){} // RVA: 0x7ffaaf21aee0
        // ── Binary Analysis Named ──
        public void GetCalibrationState(){} // RVA: 0x7ffaa976ee80
        public void GetPlayAreaSize(){} // RVA: 0x7ffaae3a29d0
        public void GetPlayAreaRect(){} // RVA: 0x7ffaabf08370
        public void SetSceneColor(){} // RVA: 0x7ffaae3a2a00
        public void GetBoundsColor(){} // RVA: 0x7ffaae3a2a40
    }

    public class CVRChaperoneSetup : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21af10
        public void CommitWorkingCopy(){} // RVA: 0x7ffaad11e050
        public void RevertWorkingCopy(){} // RVA: 0x7ffaac0ad2d0
        public void ReloadFromDisk(){} // RVA: 0x7ffaae3a2f00
        public void ExportLiveToBuffer(){} // RVA: 0x7ffaaf21b340
        public void ImportFromBufferToWorking(){} // RVA: 0x7ffaaf21b370
        public void ShowWorkingSetPreview(){} // RVA: 0x7ffaae3a3630
        public void HideWorkingSetPreview(){} // RVA: 0x7ffaae3a3660
        public void RoomSetupStarting(){} // RVA: 0x7ffaae3a3690
        // ── Binary Analysis Named ──
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7ffaae3a2c90
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7ffaab6777f0
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7ffaaf21b100
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7ffaaf21b1f0
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ffaae3a1fb0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7ffaae3a2a70
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7ffaae3a23c0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7ffaae3a2ea0
        public void SetWorkingPerimeter(){} // RVA: 0x7ffaaf21b2e0
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ffaae3a2ed0
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7ffaae3a2420
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ffaaf21b310
    }

    public class CVRCompositor : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21b440
        public void WaitGetPoses(){} // RVA: 0x7ffaae3a33e0
        public void Submit(){} // RVA: 0x7ffaae3a3480
        public void SubmitWithArrayIndex(){} // RVA: 0x7ffaaf21b640
        public void ClearLastSubmittedFrame(){} // RVA: 0x7ffaae3a34b0
        public void PostPresentHandoff(){} // RVA: 0x7ffaae3a5120
        public void FadeToColor(){} // RVA: 0x7ffaaf21b6d0
        public void FadeGrid(){} // RVA: 0x7ffaae3a5450
        public void ClearSkyboxOverride(){} // RVA: 0x7ffaae3a3660
        public void CompositorBringToFront(){} // RVA: 0x7ffaae3a3690
        public void CompositorGoToBack(){} // RVA: 0x7ffaae3a36c0
        public void CompositorQuit(){} // RVA: 0x7ffaae3a36f0
        public void IsFullscreen(){} // RVA: 0x7ffaae3a3720
        public void CanRenderScene(){} // RVA: 0x7ffaae3a2690
        public void ShowMirrorWindow(){} // RVA: 0x7ffaae3a37b0
        public void HideMirrorWindow(){} // RVA: 0x7ffaae3a37e0
        public void IsMirrorWindowVisible(){} // RVA: 0x7ffaae3a27a0
        public void CompositorDumpImages(){} // RVA: 0x7ffaae3a3810
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7ffaae3a2800
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7ffaaf21b7d0
        public void ForceReconnectProcess(){} // RVA: 0x7ffaaf21b800
        public void SuspendRendering(){} // RVA: 0x7ffaaf21b830
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7ffaaf21b860
        public void ReleaseSharedGLTexture(){} // RVA: 0x7ffaaf21b890
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7ffaae3a39d0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7ffaaf21b8c0
        public void SubmitExplicitTimingData(){} // RVA: 0x7ffaaf219050
        public void IsMotionSmoothingEnabled(){} // RVA: 0x7ffaaf21b950
        public void IsMotionSmoothingSupported(){} // RVA: 0x7ffaae3a16f0
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x7ffaae3a1720
        public void ClearStageOverride(){} // RVA: 0x7ffaaf21ba70
        // ── Binary Analysis Named ──
        public void SetTrackingSpace(){} // RVA: 0x7ffaad11e050
        public void GetTrackingSpace(){} // RVA: 0x7ffaac0ad2d0
        public void GetLastPoses(){} // RVA: 0x7ffaae3a3430
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7ffaae3a2320
        public void GetFrameTiming(){} // RVA: 0x7ffaae3a34e0
        public void GetFrameTimings(){} // RVA: 0x7ffaaf21b2e0
        public void GetFrameTimeRemaining(){} // RVA: 0x7ffaaf21b670
        public void GetCumulativeStats(){} // RVA: 0x7ffaaf21b6a0
        public void GetCurrentFadeColor(){} // RVA: 0x7ffaaf21b720
        public void GetCurrentGridAlpha(){} // RVA: 0x7ffaaf21b760
        public void SetSkyboxOverride(){} // RVA: 0x7ffaaf21b790
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7ffaae3a3750
        public void GetLastFrameRenderer(){} // RVA: 0x7ffaae3a3780
        public void GetMirrorTextureD3D11(){} // RVA: 0x7ffaae3a4250
        public void GetMirrorTextureGL(){} // RVA: 0x7ffaae3a42b0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7ffaaf21b8f0
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7ffaaf21b920
        public void SetExplicitTimingMode(){} // RVA: 0x7ffaae3a43a0
        public void SetStageOverride_Async(){} // RVA: 0x7ffaaf21b980
        public void GetCompositorBenchmarkResults(){} // RVA: 0x7ffaae3a4720
        public void GetLastPosePredictionIDs(){} // RVA: 0x7ffaaf21baa0
        public void GetPosesForFrame(){} // RVA: 0x7ffaaf21bad0
    }

    public class CVRDebug : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf220c90
        public void EmitVrProfilerEvent(){} // RVA: 0x7ffaaf220e20
        public void FinishVrProfilerEvent(){} // RVA: 0x7ffaaf220f10
        public void DriverDebugRequest(){} // RVA: 0x7ffaaf220fe0
        // ── Binary Analysis Named ──
        public void BeginVrProfilerEvent(){} // RVA: 0x7ffaaf220ee0
    }

    public class CVRDriverManager : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21fac0
        public void IsEnabled(){} // RVA: 0x7ffaab6777f0
        // ── Binary Analysis Named ──
        public void GetDriverCount(){} // RVA: 0x7ffaa976ee80
        public void GetDriverName(){} // RVA: 0x7ffaae3a6260
        public void GetDriverHandle(){} // RVA: 0x7ffaaf21fc50
    }

    public class CVRExtendedDisplay : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2193c0
        // ── Binary Analysis Named ──
        public void GetWindowBounds(){} // RVA: 0x7ffaae3a1b70
        public void GetEyeOutputViewport(){} // RVA: 0x7ffaae3a1bb0
        public void GetDXGIOutputInfo(){} // RVA: 0x7ffaae3a1c00
    }

    public class CVRHeadsetView : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21d2a0
        // ── Binary Analysis Named ──
        public void SetHeadsetViewSize(){} // RVA: 0x7ffaad31e2e0
        public void GetHeadsetViewSize(){} // RVA: 0x7ffaaf21d460
        public void SetHeadsetViewMode(){} // RVA: 0x7ffaabf08370
        public void GetHeadsetViewMode(){} // RVA: 0x7ffaabf36b30
        public void SetHeadsetViewCropped(){} // RVA: 0x7ffaadc46190
        public void GetHeadsetViewCropped(){} // RVA: 0x7ffaaf21d490
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x7ffaae3a0570
        public void SetHeadsetViewBlendRange(){} // RVA: 0x7ffaad0ae920
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7ffaaf21d4c0
    }

    public class CVRIOBuffer : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2207a0
        public void Open(){} // RVA: 0x7ffaaf220940
        public void Close(){} // RVA: 0x7ffaa8fb4260
        public void Read(){} // RVA: 0x7ffaae3a6950
        public void Write(){} // RVA: 0x7ffaae3a6990
        public void PropertyContainer(){} // RVA: 0x7ffaadc46190
        public void HasReaders(){} // RVA: 0x7ffaad0aecb0
    }

    public class CVRInput : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21fd10
        public void UpdateActionState(){} // RVA: 0x7ffaae3a6500
        public void DecompressSkeletalBoneData(){} // RVA: 0x7ffaaf220410
        public void TriggerHapticVibrationAction(){} // RVA: 0x7ffaaf220460
        public void ShowActionOrigins(){} // RVA: 0x7ffaae3a40f0
        public void ShowBindingsForActionSet(){} // RVA: 0x7ffaaf220560
        public void IsUsingLegacyInput(){} // RVA: 0x7ffaae3a3810
        public void OpenBindingUI(){} // RVA: 0x7ffaaf2206b0
        // ── Binary Analysis Named ──
        public void SetActionManifestPath(){} // RVA: 0x7ffaaf21ff00
        public void GetActionSetHandle(){} // RVA: 0x7ffaaf21ffc0
        public void GetActionHandle(){} // RVA: 0x7ffaaf220090
        public void GetInputSourceHandle(){} // RVA: 0x7ffaaf220160
        public void GetDigitalActionData(){} // RVA: 0x7ffaae3a3480
        public void GetAnalogActionData(){} // RVA: 0x7ffaae3a3d20
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x7ffaae3a6540
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7ffaaf220230
        public void GetSkeletalActionData(){} // RVA: 0x7ffaaf220260
        public void GetDominantHand(){} // RVA: 0x7ffaad0af900
        public void SetDominantHand(){} // RVA: 0x7ffaae3a2ed0
        public void GetBoneCount(){} // RVA: 0x7ffaaf21c130
        public void GetBoneHierarchy(){} // RVA: 0x7ffaaf220290
        public void GetBoneName(){} // RVA: 0x7ffaaf2202d0
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7ffaaf220300
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7ffaae3a3f00
        public void GetSkeletalBoneData(){} // RVA: 0x7ffaaf220350
        public void GetSkeletalSummaryData(){} // RVA: 0x7ffaaf2203a0
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7ffaaf2203d0
        public void GetActionOrigins(){} // RVA: 0x7ffaaf2204a0
        public void GetOriginLocalizedName(){} // RVA: 0x7ffaaf2204e0
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7ffaae3a0910
        public void GetActionBindingInfo(){} // RVA: 0x7ffaaf220510
        public void GetComponentStateForBinding(){} // RVA: 0x7ffaaf2205a0
        public void GetBindingVariant(){} // RVA: 0x7ffaae3a41f0
    }

    public class CVRNotifications : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21e3d0
        public void CreateNotification(){} // RVA: 0x7ffaaf21e560
        public void RemoveNotification(){} // RVA: 0x7ffaa8fb4260
    }

    public class CVROverlay : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21bb10
        public void FindOverlay(){} // RVA: 0x7ffaaf21bd00
        public void CreateOverlay(){} // RVA: 0x7ffaaf21bdd0
        public void DestroyOverlay(){} // RVA: 0x7ffaabf08370
        public void ShowOverlay(){} // RVA: 0x7ffaae3a3a60
        public void HideOverlay(){} // RVA: 0x7ffaae3a43a0
        public void IsOverlayVisible(){} // RVA: 0x7ffaae3a43d0
        public void WaitFrameSync(){} // RVA: 0x7ffaaf21c5a0
        public void PollNextOverlayEvent(){} // RVA: 0x7ffaaf21c5d0
        public void ComputeOverlayIntersection(){} // RVA: 0x7ffaaf21c860
        public void IsHoverTargetOverlay(){} // RVA: 0x7ffaaf21c890
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7ffaaf21c8f0
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x7ffaaf21c950
        public void ClearOverlayTexture(){} // RVA: 0x7ffaae3a4910
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7ffaae3a4a10
        public void CreateDashboardOverlay(){} // RVA: 0x7ffaaf21ca50
        public void IsDashboardVisible(){} // RVA: 0x7ffaae3a4ac0
        public void IsActiveDashboardOverlay(){} // RVA: 0x7ffaae3a4af0
        public void ShowDashboard(){} // RVA: 0x7ffaaf21cb60
        public void ShowKeyboard(){} // RVA: 0x7ffaaf21cc20
        public void ShowKeyboardForOverlay(){} // RVA: 0x7ffaaf21cd50
        public void HideKeyboard(){} // RVA: 0x7ffaae3a4c90
        public void ShowMessageOverlay(){} // RVA: 0x7ffaaf21ce90
        public void CloseMessageOverlay(){} // RVA: 0x7ffaaf21d010
        // ── Binary Analysis Named ──
        public void GetOverlayKey(){} // RVA: 0x7ffaae3a1f20
        public void GetOverlayName(){} // RVA: 0x7ffaaf21bed0
        public void SetOverlayName(){} // RVA: 0x7ffaaf21bf00
        public void GetOverlayImageData(){} // RVA: 0x7ffaaf21bfd0
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7ffaaf21c020
        public void SetOverlayRenderingPid(){} // RVA: 0x7ffaae3a23c0
        public void GetOverlayRenderingPid(){} // RVA: 0x7ffaae3a23f0
        public void SetOverlayFlag(){} // RVA: 0x7ffaaf21c0d0
        public void GetOverlayFlag(){} // RVA: 0x7ffaaf21c100
        public void GetOverlayFlags(){} // RVA: 0x7ffaaf21c130
        public void SetOverlayColor(){} // RVA: 0x7ffaaf21c160
        public void GetOverlayColor(){} // RVA: 0x7ffaaf21c190
        public void SetOverlayAlpha(){} // RVA: 0x7ffaae3a5450
        public void GetOverlayAlpha(){} // RVA: 0x7ffaaf21c1d0
        public void SetOverlayTexelAspect(){} // RVA: 0x7ffaae3a25a0
        public void GetOverlayTexelAspect(){} // RVA: 0x7ffaaf21c200
        public void SetOverlaySortOrder(){} // RVA: 0x7ffaae3a25d0
        public void GetOverlaySortOrder(){} // RVA: 0x7ffaaf21c230
        public void SetOverlayWidthInMeters(){} // RVA: 0x7ffaaf21c260
        public void GetOverlayWidthInMeters(){} // RVA: 0x7ffaaf21c290
        public void SetOverlayCurvature(){} // RVA: 0x7ffaaf21c2c0
        public void GetOverlayCurvature(){} // RVA: 0x7ffaaf21c2f0
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7ffaaf21c320
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7ffaaf21c350
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7ffaae3a4120
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7ffaae3a4150
        public void SetOverlayTextureBounds(){} // RVA: 0x7ffaae3a4180
        public void GetOverlayTextureBounds(){} // RVA: 0x7ffaaf21c380
        public void GetOverlayTransformType(){} // RVA: 0x7ffaaf21c3b0
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7ffaaf21c3e0
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7ffaae3a38d0
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7ffaae3a4250
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7ffaae3a3930
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7ffaaf21c410
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7ffaaf21c4f0
        public void SetOverlayTransformCursor(){} // RVA: 0x7ffaaf21c530
        public void GetOverlayTransformCursor(){} // RVA: 0x7ffaae3a3a00
        public void SetOverlayTransformProjection(){} // RVA: 0x7ffaaf21c560
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7ffaae3a4400
        public void GetOverlayInputMethod(){} // RVA: 0x7ffaae3a46c0
        public void SetOverlayInputMethod(){} // RVA: 0x7ffaae3a46f0
        public void GetOverlayMouseScale(){} // RVA: 0x7ffaae3a4720
        public void SetOverlayMouseScale(){} // RVA: 0x7ffaaf21c830
        public void SetOverlayIntersectionMask(){} // RVA: 0x7ffaaf21c8c0
        public void SetOverlayCursor(){} // RVA: 0x7ffaae3a4840
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7ffaaf21c920
        public void SetOverlayTexture(){} // RVA: 0x7ffaae3a48e0
        public void SetOverlayRaw(){} // RVA: 0x7ffaae3a4940
        public void SetOverlayFromFile(){} // RVA: 0x7ffaaf21c980
        public void GetOverlayTexture(){} // RVA: 0x7ffaae3a49b0
        public void GetOverlayTextureSize(){} // RVA: 0x7ffaae3a4a40
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7ffaae3a4b20
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7ffaae3a4b50
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7ffaae3a4bb0
        public void GetKeyboardText(){} // RVA: 0x7ffaae3a4c60
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7ffaae3a4cc0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7ffaae3a4cf0
    }

    public class CVROverlayView : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21d110
        public void AcquireOverlayView(){} // RVA: 0x7ffaae84e900
        public void ReleaseOverlayView(){} // RVA: 0x7ffaa8fb4260
        public void PostOverlayEvent(){} // RVA: 0x7ffaadc461c0
        public void IsViewingPermitted(){} // RVA: 0x7ffaab6777f0
    }

    public class CVRPaths : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf221300
        public void ReadPathBatch(){} // RVA: 0x7ffaae3a6060
        public void WritePathBatch(){} // RVA: 0x7ffaae3a6260
        public void StringToHandle(){} // RVA: 0x7ffaaf221490
        public void HandleToString(){} // RVA: 0x7ffaaf221560
    }

    public class CVRProperties : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2210c0
        public void ReadPropertyBatch(){} // RVA: 0x7ffaae3a6060
        public void WritePropertyBatch(){} // RVA: 0x7ffaae3a6260
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x7ffaab6777f0
        // ── Binary Analysis Named ──
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7ffaaf221250
    }

    public class CVRPropertyHelpers : ValueType
    {
    }

    public class CVRRenderModels : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21d4f0
        public void LoadRenderModel_Async(){} // RVA: 0x7ffaaf21d6e0
        public void FreeRenderModel(){} // RVA: 0x7ffaa8fb4260
        public void LoadTexture_Async(){} // RVA: 0x7ffaadc461c0
        public void FreeTexture(){} // RVA: 0x7ffaab6777f0
        public void LoadTextureD3D11_Async(){} // RVA: 0x7ffaae3a2320
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7ffaae3a50c0
        public void FreeTextureD3D11(){} // RVA: 0x7ffaae3a1fb0
        public void RenderModelHasComponent(){} // RVA: 0x7ffaaf21df40
        // ── Binary Analysis Named ──
        public void GetRenderModelName(){} // RVA: 0x7ffaae3a50f0
        public void GetRenderModelCount(){} // RVA: 0x7ffaae3a5120
        public void GetComponentCount(){} // RVA: 0x7ffaaf21d7b0
        public void GetComponentName(){} // RVA: 0x7ffaaf21d870
        public void GetComponentButtonMask(){} // RVA: 0x7ffaaf21d950
        public void GetComponentRenderModelName(){} // RVA: 0x7ffaaf21da30
        public void GetComponentStateForDevicePath(){} // RVA: 0x7ffaaf21db30
        public void GetComponentState(){} // RVA: 0x7ffaaf21dc40
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7ffaaf21e020
        public void GetRenderModelOriginalPath(){} // RVA: 0x7ffaaf21e110
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7ffaaf21e200
    }

    public class CVRResources : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21f750
        public void LoadSharedResource(){} // RVA: 0x7ffaaf21f8e0
        // ── Binary Analysis Named ──
        public void GetResourceFullPath(){} // RVA: 0x7ffaaf21f9c0
    }

    public class CVRScreenshots : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21f290
        public void RequestScreenshot(){} // RVA: 0x7ffaaf21f440
        public void HookScreenshot(){} // RVA: 0x7ffaae3a5e00
        public void UpdateScreenshotProgress(){} // RVA: 0x7ffaae3a5e60
        public void TakeStereoScreenshot(){} // RVA: 0x7ffaaf21f550
        public void SubmitScreenshot(){} // RVA: 0x7ffaaf21f650
        // ── Binary Analysis Named ──
        public void GetScreenshotPropertyType(){} // RVA: 0x7ffaadc461c0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7ffaae3a5e30
    }

    public class CVRSettingHelper : ValueType
    {
    }

    public class CVRSettings : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf21e680
        public void RemoveSection(){} // RVA: 0x7ffaaf21f0e0
        public void RemoveKeyInSection(){} // RVA: 0x7ffaaf21f1a0
        // ── Binary Analysis Named ──
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7ffaaf21e840
        public void SetBool(){} // RVA: 0x7ffaaf21e8f0
        public void SetInt32(){} // RVA: 0x7ffaaf21e9f0
        public void SetFloat(){} // RVA: 0x7ffaaf21eaf0
        public void SetString(){} // RVA: 0x7ffaaf21ebf0
        public void GetBool(){} // RVA: 0x7ffaaf21ed00
        public void GetInt32(){} // RVA: 0x7ffaaf21edf0
        public void GetFloat(){} // RVA: 0x7ffaaf21eee0
        public void GetString(){} // RVA: 0x7ffaaf21efe0
    }

    public class CVRSpatialAnchors : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf220a30
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7ffaaf220bc0
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7ffaae3a6b80
        // ── Binary Analysis Named ──
        public void GetSpatialAnchorPose(){} // RVA: 0x7ffaae3a6bc0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7ffaae3a6bf0
    }

    public class CVRSystem : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf2180d0
        public void ComputeDistortion(){} // RVA: 0x7ffaae3a04c0
        public void IsDisplayOnDesktop(){} // RVA: 0x7ffaae3a0610
        public void ApplyTransform(){} // RVA: 0x7ffaae3a2570
        public void IsTrackedDeviceConnected(){} // RVA: 0x7ffaae3a0850
        public void PollNextEvent(){} // RVA: 0x7ffaaf218570
        public void PollNextEventWithPose(){} // RVA: 0x7ffaaf2187c0
        public void TriggerHapticPulse(){} // RVA: 0x7ffaae3a4280
        public void IsInputAvailable(){} // RVA: 0x7ffaaf219020
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7ffaae3a15d0
        public void ShouldApplicationPause(){} // RVA: 0x7ffaae3a1600
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7ffaae3a1630
        public void PerformFirmwareUpdate(){} // RVA: 0x7ffaae3a43a0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7ffaaf219050
        // ── Binary Analysis Named ──
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7ffaae3a03d0
        public void GetProjectionMatrix(){} // RVA: 0x7ffaae3a0400
        public void GetProjectionRaw(){} // RVA: 0x7ffaae3a0470
        public void GetEyeToHeadTransform(){} // RVA: 0x7ffaae3a04f0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7ffaae3a0540
        public void GetD3D9AdapterIndex(){} // RVA: 0x7ffaae3a0570
        public void GetDXGIOutputInfo(){} // RVA: 0x7ffaae3a05a0
        public void GetOutputDevice(){} // RVA: 0x7ffaae3a05d0
        public void SetDisplayVisibility(){} // RVA: 0x7ffaad0af900
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7ffaae3a0640
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7ffaaf2182f0
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7ffaae3a06b0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7ffaaf218340
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7ffaaf218380
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7ffaaf2183b0
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7ffaae3a07f0
        public void GetTrackedDeviceClass(){} // RVA: 0x7ffaae3a0820
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7ffaae3a2630
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7ffaae3a08b0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7ffaae3a08e0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7ffaae3a0910
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7ffaaf2183e0
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7ffaaf218440
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7ffaaf218480
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7ffaaf2184c0
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7ffaaf2187f0
        public void GetHiddenAreaMesh(){} // RVA: 0x7ffaaf2188a0
        public void GetControllerState(){} // RVA: 0x7ffaaf2188f0
        public void GetControllerStateWithPose(){} // RVA: 0x7ffaaf218bc0
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7ffaaf218ec0
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7ffaaf218f70
        public void GetAppContainerFilePaths(){} // RVA: 0x7ffaaf219080
        public void GetRuntimeVersion(){} // RVA: 0x7ffaaf2190b0
    }

    public class CVRTrackedCamera : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf219560
        public void HasCamera(){} // RVA: 0x7ffaae3a1ea0
        public void AcquireVideoStreamingService(){} // RVA: 0x7ffaae3a1f80
        public void ReleaseVideoStreamingService(){} // RVA: 0x7ffaae3a1fb0
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7ffaae3a20d0
        // ── Binary Analysis Named ──
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7ffaaf219720
        public void GetCameraFrameSize(){} // RVA: 0x7ffaae3a1ed0
        public void GetCameraIntrinsics(){} // RVA: 0x7ffaae3a5e30
        public void GetCameraProjection(){} // RVA: 0x7ffaaf2197d0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7ffaae3a1fe0
        public void GetVideoStreamTextureSize(){} // RVA: 0x7ffaae3a2010
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7ffaae3a2060
        public void GetVideoStreamTextureGL(){} // RVA: 0x7ffaae3a2090
        public void SetCameraTrackingSpace(){} // RVA: 0x7ffaae3a2420
        public void GetCameraTrackingSpace(){} // RVA: 0x7ffaaf219800
    }

    public class CameraVideoStreamFrameHeader_t : ValueType
    {
        public object nHeight; // 0x34C1D230
        public object trackedDevicePose; // 0x34C1D230
    }

    public class Compositor_BenchmarkResults : ValueType
    {
    }

    public class Compositor_CumulativeStats : ValueType
    {
        public object m_nNumDroppedFrames; // 0x34C1DB30
        public object m_nNumDroppedFramesOnStartup; // 0x34C1DB30
        public object m_nNumFramePresentsLoading; // 0x34C1DB30
        public object m_nNumTimedOut; // 0x34C1DB30
        public object m_nNumReprojectedFramesTimedOut; // 0x34C1DB30
        public object m_flSumCompositorGPUTimeMS; // 0x34C1DB30
        public object m_flSumApplicationGPUTimeMS; // 0x34C1DB30
        public object 8؏f; // 0x6743A8CC
    }

    public class Compositor_FrameTiming : ValueType
    {
        public object m_nNumFramePresents; // 0x34C1D3B0
        public object m_nReprojectionFlags; // 0x34C1D3B0
        public object m_flPostSubmitGpuMs; // 0x34C1D3B0
        public object m_flCompositorRenderCpuMs; // 0x34C1D3B0
        public object m_flPresentCallCpuMs; // 0x34C1D3B0
        public object m_flWaitGetPosesCalledMs; // 0x34C1D3B0
        public object m_flCompositorUpdateStartMs; // 0x34C1D3B0
        public object m_HmdPose; // 0x34C1D3B0
        public object m_flTransferLatencyMs; // 0x34C1D3B0
        public object 8؏f; // 0x6743A7A0
        public object m_nSize; // 0x34C1D6B0
        public object m_nNumDroppedFrames; // 0x34C1D6B0
    }

    public class Compositor_StageRenderSettings : ValueType
    {
        public object m_flVignetteInnerRadius; // 0x34C1DCB0
        public object m_bBackfaceCulling; // 0x34C1DCB0
    }

}