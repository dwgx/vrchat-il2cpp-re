// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 23
// Methods: 398

namespace ThirdParty.Valve.Valve.VR
{
    public class CVRApplications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3E020
        public void AddApplicationManifest(){} // RVA: 0x7AEE3E230
        public void RemoveApplicationManifest(){} // RVA: 0x7AEE3E300
        public void IsApplicationInstalled(){} // RVA: 0x7AEE3E3C0
        public void GetApplicationCount(){} // RVA: 0x7ABA29AE0
        public void GetApplicationKeyByIndex(){} // RVA: 0x7ADFD6740
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7ADFD6770
        public void LaunchApplication(){} // RVA: 0x7AEE3E480
        public void LaunchTemplateApplication(){} // RVA: 0x7AEE3E540
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7AEE3E640
        public void LaunchDashboardOverlay(){} // RVA: 0x7AEE3E720
        public void CancelApplicationLaunch(){} // RVA: 0x7AEE3E7E0
        public void IdentifyApplication(){} // RVA: 0x7AEE3E8A0
        public void GetApplicationProcessId(){} // RVA: 0x7AEE3E960
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7AEE3EA20
        public void GetApplicationPropertyString(){} // RVA: 0x7AEE3EAD0
        public void GetApplicationPropertyBool(){} // RVA: 0x7AEE3EBC0
        public void GetApplicationPropertyUint64(){} // RVA: 0x7AEE3ECA0
        public void SetApplicationAutoLaunch(){} // RVA: 0x7AEE3ED80
        public void GetApplicationAutoLaunch(){} // RVA: 0x7AEE3EE50
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7AEE3EF10
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7AEE3EFF0
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7AEE3F0D0
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7AEE3F1B0
        public void GetApplicationLaunchArguments(){} // RVA: 0x7ADFD4CC0
        public void GetStartingApplication(){} // RVA: 0x7ADFD6A80
        public void GetSceneApplicationState(){} // RVA: 0x7ADFD6AB0
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7AEE3F290
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x7AEE3F350
        public void LaunchInternalProcess(){} // RVA: 0x7AEE3F400
        public void GetCurrentSceneProcessId(){} // RVA: 0x7ADFD7C30
    }

    public class CVRBlockQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE45D90
        public void Create(){} // RVA: 0x7AEE45F40
        public void Connect(){} // RVA: 0x7AEE46040
        public void Destroy(){} // RVA: 0x7AB9EF6F0
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7AEE46110
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x7ADFDA2B0
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x7AEE46150
        public void AcquireReadOnlyBlock(){} // RVA: 0x7AEE46190
        public void ReleaseReadOnlyBlock(){} // RVA: 0x7ACF04090
        public void QueueHasReader(){} // RVA: 0x7AEE461D0
    }

    public class CVRChaperone : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3F510
        public void GetCalibrationState(){} // RVA: 0x7A9038740
        public void GetPlayAreaSize(){} // RVA: 0x7ADFD6DF0
        public void GetPlayAreaRect(){} // RVA: 0x7AB9EF6F0
        public void ReloadInfo(){} // RVA: 0x7ABA29AE0
        public void SetSceneColor(){} // RVA: 0x7ADFD6E20
        public void GetBoundsColor(){} // RVA: 0x7ADFD6E60
        public void AreBoundsVisible(){} // RVA: 0x7ADFD4950
        public void ForceBoundsVisible(){} // RVA: 0x7ADFD6E90
        public void ResetZeroPose(){} // RVA: 0x7AEE3F6C0
    }

    public class CVRChaperoneSetup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3F6F0
        public void CommitWorkingCopy(){} // RVA: 0x7ACEFA0B0
        public void RevertWorkingCopy(){} // RVA: 0x7ABB8BE10
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7ADFD70B0
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7AB121480
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7AEE3F8E0
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7AEE3F9D0
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD63D0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD6E90
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7ADFD67E0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7ADFD72C0
        public void SetWorkingPerimeter(){} // RVA: 0x7AEE3FAC0
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD72F0
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7ADFD6840
        public void ReloadFromDisk(){} // RVA: 0x7ADFD7320
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7AEE3FAF0
        public void ExportLiveToBuffer(){} // RVA: 0x7AEE3FB20
        public void ImportFromBufferToWorking(){} // RVA: 0x7AEE3FB50
        public void ShowWorkingSetPreview(){} // RVA: 0x7ADFD7A50
        public void HideWorkingSetPreview(){} // RVA: 0x7ADFD7A80
        public void RoomSetupStarting(){} // RVA: 0x7ADFD7AB0
    }

    public class CVRCompositor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3FC20
        public void SetTrackingSpace(){} // RVA: 0x7ACEFA0B0
        public void GetTrackingSpace(){} // RVA: 0x7ABB8BE10
        public void WaitGetPoses(){} // RVA: 0x7ADFD7800
        public void GetLastPoses(){} // RVA: 0x7ADFD7850
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7ADFD6740
        public void Submit(){} // RVA: 0x7ADFD78A0
        public void SubmitWithArrayIndex(){} // RVA: 0x7AEE3FE20
        public void ClearLastSubmittedFrame(){} // RVA: 0x7ADFD78D0
        public void PostPresentHandoff(){} // RVA: 0x7ADFD9560
        public void GetFrameTiming(){} // RVA: 0x7ADFD7900
        public void GetFrameTimings(){} // RVA: 0x7AEE3FAC0
        public void GetFrameTimeRemaining(){} // RVA: 0x7AEE3FE50
        public void GetCumulativeStats(){} // RVA: 0x7AEE3FE80
        public void FadeToColor(){} // RVA: 0x7AEE3FEB0
        public void GetCurrentFadeColor(){} // RVA: 0x7AEE3FF00
        public void FadeGrid(){} // RVA: 0x7ADFD98B0
        public void GetCurrentGridAlpha(){} // RVA: 0x7AEE3FF40
        public void SetSkyboxOverride(){} // RVA: 0x7AEE3FF70
        public void ClearSkyboxOverride(){} // RVA: 0x7ADFD7A80
        public void CompositorBringToFront(){} // RVA: 0x7ADFD7AB0
        public void CompositorGoToBack(){} // RVA: 0x7ADFD7AE0
        public void CompositorQuit(){} // RVA: 0x7ADFD7B10
        public void IsFullscreen(){} // RVA: 0x7ADFD7B40
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7ADFD7B70
        public void GetLastFrameRenderer(){} // RVA: 0x7ADFD7BA0
        public void CanRenderScene(){} // RVA: 0x7ADFD6AB0
        public void ShowMirrorWindow(){} // RVA: 0x7ADFD7BD0
        public void HideMirrorWindow(){} // RVA: 0x7ADFD7C00
        public void IsMirrorWindowVisible(){} // RVA: 0x7ADFD6BC0
        public void CompositorDumpImages(){} // RVA: 0x7ADFD7C30
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7ADFD6C20
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7AEE3FFB0
        public void ForceReconnectProcess(){} // RVA: 0x7AEE3FFE0
        public void SuspendRendering(){} // RVA: 0x7AEE40010
        public void GetMirrorTextureD3D11(){} // RVA: 0x7ADFD8670
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7AEE40040
        public void GetMirrorTextureGL(){} // RVA: 0x7ADFD86D0
        public void ReleaseSharedGLTexture(){} // RVA: 0x7AEE40070
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7ADFD7DF0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7AEE400A0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7AEE400D0
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7AEE40100
        public void SetExplicitTimingMode(){} // RVA: 0x7ADFD87C0
        public void SubmitExplicitTimingData(){} // RVA: 0x7AEE3D850
        public void IsMotionSmoothingEnabled(){} // RVA: 0x7AEE40130
        public void IsMotionSmoothingSupported(){} // RVA: 0x7ADFD5B20
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x7ADFD5B50
        public void SetStageOverride_Async(){} // RVA: 0x7AEE40160
        public void ClearStageOverride(){} // RVA: 0x7AEE40250
        public void GetCompositorBenchmarkResults(){} // RVA: 0x7ADFD8B60
        public void GetLastPosePredictionIDs(){} // RVA: 0x7AEE40280
        public void GetPosesForFrame(){} // RVA: 0x7AEE402B0
    }

    public class CVRDebug : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE45480
        public void EmitVrProfilerEvent(){} // RVA: 0x7AEE45610
        public void BeginVrProfilerEvent(){} // RVA: 0x7AEE456D0
        public void FinishVrProfilerEvent(){} // RVA: 0x7AEE45700
        public void DriverDebugRequest(){} // RVA: 0x7AEE457D0
    }

    public class CVRDriverManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE442C0
        public void GetDriverCount(){} // RVA: 0x7A9038740
        public void GetDriverName(){} // RVA: 0x7ADFDA690
        public void GetDriverHandle(){} // RVA: 0x7AEE44450
        public void IsEnabled(){} // RVA: 0x7AB121480
    }

    public class CVRExtendedDisplay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3DBC0
        public void GetWindowBounds(){} // RVA: 0x7ADFD5F90
        public void GetEyeOutputViewport(){} // RVA: 0x7ADFD5FD0
        public void GetDXGIOutputInfo(){} // RVA: 0x7ADFD6020
    }

    public class CVRHeadsetView : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE41AB0
        public void SetHeadsetViewSize(){} // RVA: 0x7ACF647F0
        public void GetHeadsetViewSize(){} // RVA: 0x7AEE41C60
        public void SetHeadsetViewMode(){} // RVA: 0x7AB9EF6F0
        public void GetHeadsetViewMode(){} // RVA: 0x7ABA29AE0
        public void SetHeadsetViewCropped(){} // RVA: 0x7AD87A970
        public void GetHeadsetViewCropped(){} // RVA: 0x7AEE41C90
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x7ADFD4950
        public void SetHeadsetViewBlendRange(){} // RVA: 0x7ACF04090
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7AEE41CC0
    }

    public class CVRIOBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE44FA0
        public void Open(){} // RVA: 0x7AEE45130
        public void Close(){} // RVA: 0x7A8743650
        public void Read(){} // RVA: 0x7ADFDAD60
        public void Write(){} // RVA: 0x7ADFDADA0
        public void PropertyContainer(){} // RVA: 0x7AD87A970
        public void HasReaders(){} // RVA: 0x7ACF04A70
    }

    public class CVRInput : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE44510
        public void SetActionManifestPath(){} // RVA: 0x7AEE44700
        public void GetActionSetHandle(){} // RVA: 0x7AEE447C0
        public void GetActionHandle(){} // RVA: 0x7AEE44890
        public void GetInputSourceHandle(){} // RVA: 0x7AEE44960
        public void UpdateActionState(){} // RVA: 0x7ADFDA930
        public void GetDigitalActionData(){} // RVA: 0x7ADFD78A0
        public void GetAnalogActionData(){} // RVA: 0x7ADFD8140
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x7ADFDA970
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7AEE44A30
        public void GetSkeletalActionData(){} // RVA: 0x7AEE44A60
        public void GetDominantHand(){} // RVA: 0x7ACF04BB0
        public void SetDominantHand(){} // RVA: 0x7ADFD72F0
        public void GetBoneCount(){} // RVA: 0x7AEE40910
        public void GetBoneHierarchy(){} // RVA: 0x7AEE44A90
        public void GetBoneName(){} // RVA: 0x7AEE44AD0
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7AEE44B00
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7ADFD8320
        public void GetSkeletalBoneData(){} // RVA: 0x7AEE44B50
        public void GetSkeletalSummaryData(){} // RVA: 0x7AEE44BA0
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7AEE44BD0
        public void DecompressSkeletalBoneData(){} // RVA: 0x7AEE44C10
        public void TriggerHapticVibrationAction(){} // RVA: 0x7AEE44C60
        public void GetActionOrigins(){} // RVA: 0x7AEE44CA0
        public void GetOriginLocalizedName(){} // RVA: 0x7AEE44CE0
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7ADFD4CF0
        public void GetActionBindingInfo(){} // RVA: 0x7AEE44D10
        public void ShowActionOrigins(){} // RVA: 0x7ADFD8510
        public void ShowBindingsForActionSet(){} // RVA: 0x7AEE44D60
        public void GetComponentStateForBinding(){} // RVA: 0x7AEE44DA0
        public void IsUsingLegacyInput(){} // RVA: 0x7ADFD7C30
        public void OpenBindingUI(){} // RVA: 0x7AEE44EB0
        public void GetBindingVariant(){} // RVA: 0x7ADFD8610
    }

    public class CVRNotifications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE42BF0
        public void CreateNotification(){} // RVA: 0x7AEE42D70
        public void RemoveNotification(){} // RVA: 0x7A8743650
    }

    public class CVROverlay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE402F0
        public void FindOverlay(){} // RVA: 0x7AEE404E0
        public void CreateOverlay(){} // RVA: 0x7AEE405B0
        public void DestroyOverlay(){} // RVA: 0x7AB9EF6F0
        public void GetOverlayKey(){} // RVA: 0x7ADFD6340
        public void GetOverlayName(){} // RVA: 0x7AEE406B0
        public void SetOverlayName(){} // RVA: 0x7AEE406E0
        public void GetOverlayImageData(){} // RVA: 0x7AEE407B0
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7AEE40800
        public void SetOverlayRenderingPid(){} // RVA: 0x7ADFD67E0
        public void GetOverlayRenderingPid(){} // RVA: 0x7ADFD6810
        public void SetOverlayFlag(){} // RVA: 0x7AEE408B0
        public void GetOverlayFlag(){} // RVA: 0x7AEE408E0
        public void GetOverlayFlags(){} // RVA: 0x7AEE40910
        public void SetOverlayColor(){} // RVA: 0x7AEE40940
        public void GetOverlayColor(){} // RVA: 0x7AEE40970
        public void SetOverlayAlpha(){} // RVA: 0x7ADFD98B0
        public void GetOverlayAlpha(){} // RVA: 0x7AEE409B0
        public void SetOverlayTexelAspect(){} // RVA: 0x7ADFD69C0
        public void GetOverlayTexelAspect(){} // RVA: 0x7AEE409E0
        public void SetOverlaySortOrder(){} // RVA: 0x7ADFD69F0
        public void GetOverlaySortOrder(){} // RVA: 0x7AEE40A10
        public void SetOverlayWidthInMeters(){} // RVA: 0x7AEE40A40
        public void GetOverlayWidthInMeters(){} // RVA: 0x7AEE40A70
        public void SetOverlayCurvature(){} // RVA: 0x7AEE40AA0
        public void GetOverlayCurvature(){} // RVA: 0x7AEE40AD0
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7AEE40B00
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7AEE40B30
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7ADFD8540
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7ADFD8570
        public void SetOverlayTextureBounds(){} // RVA: 0x7ADFD85A0
        public void GetOverlayTextureBounds(){} // RVA: 0x7AEE40B60
        public void GetOverlayTransformType(){} // RVA: 0x7AEE40B90
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7AEE40BC0
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7ADFD7CF0
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7ADFD8670
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7ADFD7D50
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7AEE40BF0
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7AEE40CD0
        public void SetOverlayTransformCursor(){} // RVA: 0x7AEE40D10
        public void GetOverlayTransformCursor(){} // RVA: 0x7ADFD7E20
        public void SetOverlayTransformProjection(){} // RVA: 0x7AEE40D40
        public void ShowOverlay(){} // RVA: 0x7ADFD7E80
        public void HideOverlay(){} // RVA: 0x7ADFD87C0
        public void IsOverlayVisible(){} // RVA: 0x7ADFD87F0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7ADFD8820
        public void WaitFrameSync(){} // RVA: 0x7AEE40D80
        public void PollNextOverlayEvent(){} // RVA: 0x7AEE40DB0
        public void GetOverlayInputMethod(){} // RVA: 0x7ADFD8B00
        public void SetOverlayInputMethod(){} // RVA: 0x7ADFD8B30
        public void GetOverlayMouseScale(){} // RVA: 0x7ADFD8B60
        public void SetOverlayMouseScale(){} // RVA: 0x7AEE41040
        public void ComputeOverlayIntersection(){} // RVA: 0x7AEE41070
        public void IsHoverTargetOverlay(){} // RVA: 0x7AEE410A0
        public void SetOverlayIntersectionMask(){} // RVA: 0x7AEE410D0
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7AEE41100
        public void SetOverlayCursor(){} // RVA: 0x7ADFD8C80
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7AEE41130
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x7AEE41160
        public void SetOverlayTexture(){} // RVA: 0x7ADFD8D20
        public void ClearOverlayTexture(){} // RVA: 0x7ADFD8D50
        public void SetOverlayRaw(){} // RVA: 0x7ADFD8D80
        public void SetOverlayFromFile(){} // RVA: 0x7AEE41190
        public void GetOverlayTexture(){} // RVA: 0x7ADFD8DF0
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7ADFD8E50
        public void GetOverlayTextureSize(){} // RVA: 0x7ADFD8E80
        public void CreateDashboardOverlay(){} // RVA: 0x7AEE41260
        public void IsDashboardVisible(){} // RVA: 0x7ADFD8F00
        public void IsActiveDashboardOverlay(){} // RVA: 0x7ADFD8F30
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7ADFD8F60
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7ADFD8F90
        public void ShowDashboard(){} // RVA: 0x7AEE41370
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7ADFD8FF0
        public void ShowKeyboard(){} // RVA: 0x7AEE41430
        public void ShowKeyboardForOverlay(){} // RVA: 0x7AEE41560
        public void GetKeyboardText(){} // RVA: 0x7ADFD90A0
        public void HideKeyboard(){} // RVA: 0x7ADFD90D0
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7ADFD9100
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7ADFD9130
        public void ShowMessageOverlay(){} // RVA: 0x7AEE416A0
        public void CloseMessageOverlay(){} // RVA: 0x7AEE41820
    }

    public class CVROverlayView : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE41920
        public void AcquireOverlayView(){} // RVA: 0x7AE484360
        public void ReleaseOverlayView(){} // RVA: 0x7A8743650
        public void PostOverlayEvent(){} // RVA: 0x7AD87A9A0
        public void IsViewingPermitted(){} // RVA: 0x7AB121480
    }

    public class CVRPaths : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE45AF0
        public void ReadPathBatch(){} // RVA: 0x7ADFDA4A0
        public void WritePathBatch(){} // RVA: 0x7ADFDA690
        public void StringToHandle(){} // RVA: 0x7AEE45C80
        public void HandleToString(){} // RVA: 0x7AEE45D50
    }

    public class CVRProperties : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE458B0
        public void ReadPropertyBatch(){} // RVA: 0x7ADFDA4A0
        public void WritePropertyBatch(){} // RVA: 0x7ADFDA690
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7AEE45A40
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x7AB121480
    }

    public class CVRRenderModels : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE41CF0
        public void LoadRenderModel_Async(){} // RVA: 0x7AEE41EE0
        public void FreeRenderModel(){} // RVA: 0x7A8743650
        public void LoadTexture_Async(){} // RVA: 0x7AD87A9A0
        public void FreeTexture(){} // RVA: 0x7AB121480
        public void LoadTextureD3D11_Async(){} // RVA: 0x7ADFD6740
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7ADFD9500
        public void FreeTextureD3D11(){} // RVA: 0x7ADFD63D0
        public void GetRenderModelName(){} // RVA: 0x7ADFD9530
        public void GetRenderModelCount(){} // RVA: 0x7ADFD9560
        public void GetComponentCount(){} // RVA: 0x7AEE41FB0
        public void GetComponentName(){} // RVA: 0x7AEE42070
        public void GetComponentButtonMask(){} // RVA: 0x7AEE42150
        public void GetComponentRenderModelName(){} // RVA: 0x7AEE42230
        public void GetComponentStateForDevicePath(){} // RVA: 0x7AEE42330
        public void GetComponentState(){} // RVA: 0x7AEE42440
        public void RenderModelHasComponent(){} // RVA: 0x7AEE42760
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7AEE42840
        public void GetRenderModelOriginalPath(){} // RVA: 0x7AEE42930
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7AEE42A20
    }

    public class CVRResources : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE43F60
        public void LoadSharedResource(){} // RVA: 0x7AEE440E0
        public void GetResourceFullPath(){} // RVA: 0x7AEE441C0
    }

    public class CVRScreenshots : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE43AA0
        public void RequestScreenshot(){} // RVA: 0x7AEE43C50
        public void HookScreenshot(){} // RVA: 0x7ADFDA250
        public void GetScreenshotPropertyType(){} // RVA: 0x7AD87A9A0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7ADFDA280
        public void UpdateScreenshotProgress(){} // RVA: 0x7ADFDA2B0
        public void TakeStereoScreenshot(){} // RVA: 0x7AEE43D60
        public void SubmitScreenshot(){} // RVA: 0x7AEE43E60
    }

    public class CVRSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE42E90
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7AEE43050
        public void SetBool(){} // RVA: 0x7AEE43100
        public void SetInt32(){} // RVA: 0x7AEE43200
        public void SetFloat(){} // RVA: 0x7AEE43300
        public void SetString(){} // RVA: 0x7AEE43400
        public void GetBool(){} // RVA: 0x7AEE43510
        public void GetInt32(){} // RVA: 0x7AEE43600
        public void GetFloat(){} // RVA: 0x7AEE436F0
        public void GetString(){} // RVA: 0x7AEE437F0
        public void RemoveSection(){} // RVA: 0x7AEE438F0
        public void RemoveKeyInSection(){} // RVA: 0x7AEE439B0
    }

    public class CVRSpatialAnchors : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE45220
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7AEE453B0
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7ADFDAF90
        public void GetSpatialAnchorPose(){} // RVA: 0x7ADFDAFD0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7ADFDB000
    }

    public class CVRSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3C880
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7ADFD47B0
        public void GetProjectionMatrix(){} // RVA: 0x7ADFD47E0
        public void GetProjectionRaw(){} // RVA: 0x7ADFD4850
        public void ComputeDistortion(){} // RVA: 0x7ADFD48A0
        public void GetEyeToHeadTransform(){} // RVA: 0x7ADFD48D0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7ADFD4920
        public void GetD3D9AdapterIndex(){} // RVA: 0x7ADFD4950
        public void GetDXGIOutputInfo(){} // RVA: 0x7ADFD4980
        public void GetOutputDevice(){} // RVA: 0x7ADFD49B0
        public void IsDisplayOnDesktop(){} // RVA: 0x7ADFD49F0
        public void SetDisplayVisibility(){} // RVA: 0x7ACF04BB0
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7ADFD4A20
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7AEE3CAA0
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7ADFD4A90
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7AEE3CAF0
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7AEE3CB30
        public void ApplyTransform(){} // RVA: 0x7ADFD6990
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7AEE3CB60
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7ADFD4BD0
        public void GetTrackedDeviceClass(){} // RVA: 0x7ADFD4C00
        public void IsTrackedDeviceConnected(){} // RVA: 0x7ADFD4C30
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7ADFD6A50
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7ADFD4C90
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7ADFD4CC0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7ADFD4CF0
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7AEE3CB90
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7AEE3CBF0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7AEE3CC30
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7AEE3CC70
        public void PollNextEvent(){} // RVA: 0x7AEE3CD20
        public void PollNextEventWithPose(){} // RVA: 0x7AEE3CF90
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7AEE3CFC0
        public void GetHiddenAreaMesh(){} // RVA: 0x7AEE3D070
        public void GetControllerState(){} // RVA: 0x7AEE3D0C0
        public void GetControllerStateWithPose(){} // RVA: 0x7AEE3D3B0
        public void TriggerHapticPulse(){} // RVA: 0x7ADFD86A0
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7AEE3D6C0
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7AEE3D770
        public void IsInputAvailable(){} // RVA: 0x7AEE3D820
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7ADFD5A00
        public void ShouldApplicationPause(){} // RVA: 0x7ADFD5A30
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7ADFD5A60
        public void PerformFirmwareUpdate(){} // RVA: 0x7ADFD87C0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7AEE3D850
        public void GetAppContainerFilePaths(){} // RVA: 0x7AEE3D880
        public void GetRuntimeVersion(){} // RVA: 0x7AEE3D8B0
    }

    public class CVRTrackedCamera : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE3DD50
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7AEE3DF10
        public void HasCamera(){} // RVA: 0x7ADFD62C0
        public void GetCameraFrameSize(){} // RVA: 0x7ADFD62F0
        public void GetCameraIntrinsics(){} // RVA: 0x7ADFDA280
        public void GetCameraProjection(){} // RVA: 0x7AEE3DFC0
        public void AcquireVideoStreamingService(){} // RVA: 0x7ADFD63A0
        public void ReleaseVideoStreamingService(){} // RVA: 0x7ADFD63D0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7ADFD6400
        public void GetVideoStreamTextureSize(){} // RVA: 0x7ADFD6430
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7ADFD6480
        public void GetVideoStreamTextureGL(){} // RVA: 0x7ADFD64B0
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7ADFD64F0
        public void SetCameraTrackingSpace(){} // RVA: 0x7ADFD6840
        public void GetCameraTrackingSpace(){} // RVA: 0x7AEE3DFF0
    }

}