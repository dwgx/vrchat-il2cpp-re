// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 31
// Methods: 398

namespace ThirdParty.Valve.Valve.VR
{
    public class COpenVRContext
    {
    }

    public class CVRApplications
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B0EF80
        public void AddApplicationManifest(){} // RVA: 0x7FFAF9B0F190
        public void RemoveApplicationManifest(){} // RVA: 0x7FFAF9B0F260
        public void IsApplicationInstalled(){} // RVA: 0x7FFAF9B0F320
        public void GetApplicationCount(){} // RVA: 0x7FFAF66E6B00
        public void GetApplicationKeyByIndex(){} // RVA: 0x7FFAF8C99900
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7FFAF8C99930
        public void LaunchApplication(){} // RVA: 0x7FFAF9B0F3E0
        public void LaunchTemplateApplication(){} // RVA: 0x7FFAF9B0F4A0
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7FFAF9B0F5A0
        public void LaunchDashboardOverlay(){} // RVA: 0x7FFAF9B0F680
        public void CancelApplicationLaunch(){} // RVA: 0x7FFAF9B0F740
        public void IdentifyApplication(){} // RVA: 0x7FFAF9B0F800
        public void GetApplicationProcessId(){} // RVA: 0x7FFAF9B0F8C0
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7FFAF9B0F980
        public void GetApplicationPropertyString(){} // RVA: 0x7FFAF9B0FA30
        public void GetApplicationPropertyBool(){} // RVA: 0x7FFAF9B0FB20
        public void GetApplicationPropertyUint64(){} // RVA: 0x7FFAF9B0FC00
        public void SetApplicationAutoLaunch(){} // RVA: 0x7FFAF9B0FCE0
        public void GetApplicationAutoLaunch(){} // RVA: 0x7FFAF9B0FDB0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7FFAF9B0FE70
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7FFAF9B0FF50
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7FFAF9B10030
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7FFAF9B10110
        public void GetApplicationLaunchArguments(){} // RVA: 0x7FFAF8C97EC0
        public void GetStartingApplication(){} // RVA: 0x7FFAF8C99C40
        public void GetSceneApplicationState(){} // RVA: 0x7FFAF8C99C70
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7FFAF9B101F0
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x7FFAF9B102B0
        public void LaunchInternalProcess(){} // RVA: 0x7FFAF9B10360
        public void GetCurrentSceneProcessId(){} // RVA: 0x7FFAF8C9ADF0
    }

    public class CVRBlockQueue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B16CF0
        public void Create(){} // RVA: 0x7FFAF9B16EB0
        public void Connect(){} // RVA: 0x7FFAF9B16FB0
        public void Destroy(){} // RVA: 0x7FFAF66A7390
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7FFAF9B17080
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x7FFAF8C9D440
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x7FFAF9B170C0
        public void AcquireReadOnlyBlock(){} // RVA: 0x7FFAF9B17100
        public void ReleaseReadOnlyBlock(){} // RVA: 0x7FFAF7974C40
        public void QueueHasReader(){} // RVA: 0x7FFAF9B17140
    }

    public class CVRChaperone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B10470
        public void GetCalibrationState(){} // RVA: 0x7FFAF3D31E30
        public void GetPlayAreaSize(){} // RVA: 0x7FFAF8C99FB0
        public void GetPlayAreaRect(){} // RVA: 0x7FFAF66A7390
        public void ReloadInfo(){} // RVA: 0x7FFAF66E6B00
        public void SetSceneColor(){} // RVA: 0x7FFAF8C99FE0
        public void GetBoundsColor(){} // RVA: 0x7FFAF8C9A020
        public void AreBoundsVisible(){} // RVA: 0x7FFAF8C97B50
        public void ForceBoundsVisible(){} // RVA: 0x7FFAF8C9A050
        public void ResetZeroPose(){} // RVA: 0x7FFAF9B10630
    }

    public class CVRChaperoneSetup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B10660
        public void CommitWorkingCopy(){} // RVA: 0x7FFAF533D780
        public void RevertWorkingCopy(){} // RVA: 0x7FFAF6841AE0
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7FFAF8C9A270
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7FFAF5DD9C00
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAF9B10850
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7FFAF9B10940
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C99590
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C9A050
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7FFAF8C999A0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAF8C9A480
        public void SetWorkingPerimeter(){} // RVA: 0x7FFAF9B10A30
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C9A4B0
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF8C99A00
        public void ReloadFromDisk(){} // RVA: 0x7FFAF8C9A4E0
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAF9B10A60
        public void ExportLiveToBuffer(){} // RVA: 0x7FFAF9B10A90
        public void ImportFromBufferToWorking(){} // RVA: 0x7FFAF9B10AC0
        public void ShowWorkingSetPreview(){} // RVA: 0x7FFAF8C9AC10
        public void HideWorkingSetPreview(){} // RVA: 0x7FFAF8C9AC40
        public void RoomSetupStarting(){} // RVA: 0x7FFAF8C9AC70
    }

    public class CVRCompositor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B10B90
        public void SetTrackingSpace(){} // RVA: 0x7FFAF533D780
        public void GetTrackingSpace(){} // RVA: 0x7FFAF6841AE0
        public void WaitGetPoses(){} // RVA: 0x7FFAF8C9A9C0
        public void GetLastPoses(){} // RVA: 0x7FFAF8C9AA10
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7FFAF8C99900
        public void Submit(){} // RVA: 0x7FFAF8C9AA60
        public void SubmitWithArrayIndex(){} // RVA: 0x7FFAF9B10D90
        public void ClearLastSubmittedFrame(){} // RVA: 0x7FFAF8C9AA90
        public void PostPresentHandoff(){} // RVA: 0x7FFAF8C9C700
        public void GetFrameTiming(){} // RVA: 0x7FFAF8C9AAC0
        public void GetFrameTimings(){} // RVA: 0x7FFAF9B10A30
        public void GetFrameTimeRemaining(){} // RVA: 0x7FFAF9B10DC0
        public void GetCumulativeStats(){} // RVA: 0x7FFAF9B10DF0
        public void FadeToColor(){} // RVA: 0x7FFAF9B10E20
        public void GetCurrentFadeColor(){} // RVA: 0x7FFAF9B10E70
        public void FadeGrid(){} // RVA: 0x7FFAF8C9CA30
        public void GetCurrentGridAlpha(){} // RVA: 0x7FFAF9B10EB0
        public void SetSkyboxOverride(){} // RVA: 0x7FFAF9B10EE0
        public void ClearSkyboxOverride(){} // RVA: 0x7FFAF8C9AC40
        public void CompositorBringToFront(){} // RVA: 0x7FFAF8C9AC70
        public void CompositorGoToBack(){} // RVA: 0x7FFAF8C9ACA0
        public void CompositorQuit(){} // RVA: 0x7FFAF8C9ACD0
        public void IsFullscreen(){} // RVA: 0x7FFAF8C9AD00
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7FFAF8C9AD30
        public void GetLastFrameRenderer(){} // RVA: 0x7FFAF8C9AD60
        public void CanRenderScene(){} // RVA: 0x7FFAF8C99C70
        public void ShowMirrorWindow(){} // RVA: 0x7FFAF8C9AD90
        public void HideMirrorWindow(){} // RVA: 0x7FFAF8C9ADC0
        public void IsMirrorWindowVisible(){} // RVA: 0x7FFAF8C99D80
        public void CompositorDumpImages(){} // RVA: 0x7FFAF8C9ADF0
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7FFAF8C99DE0
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7FFAF9B10F20
        public void ForceReconnectProcess(){} // RVA: 0x7FFAF9B10F50
        public void SuspendRendering(){} // RVA: 0x7FFAF9B10F80
        public void GetMirrorTextureD3D11(){} // RVA: 0x7FFAF8C9B830
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7FFAF9B10FB0
        public void GetMirrorTextureGL(){} // RVA: 0x7FFAF8C9B890
        public void ReleaseSharedGLTexture(){} // RVA: 0x7FFAF9B10FE0
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7FFAF8C9AFB0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7FFAF9B11010
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7FFAF9B11040
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7FFAF9B11070
        public void SetExplicitTimingMode(){} // RVA: 0x7FFAF8C9B980
        public void SubmitExplicitTimingData(){} // RVA: 0x7FFAF9B0E7A0
        public void IsMotionSmoothingEnabled(){} // RVA: 0x7FFAF9B110A0
        public void IsMotionSmoothingSupported(){} // RVA: 0x7FFAF8C98CD0
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x7FFAF8C98D00
        public void SetStageOverride_Async(){} // RVA: 0x7FFAF9B110D0
        public void ClearStageOverride(){} // RVA: 0x7FFAF9B111C0
        public void GetCompositorBenchmarkResults(){} // RVA: 0x7FFAF8C9BD00
        public void GetLastPosePredictionIDs(){} // RVA: 0x7FFAF9B111F0
        public void GetPosesForFrame(){} // RVA: 0x7FFAF9B11220
    }

    public class CVRDebug
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B163E0
        public void EmitVrProfilerEvent(){} // RVA: 0x7FFAF9B16570
        public void BeginVrProfilerEvent(){} // RVA: 0x7FFAF9B16630
        public void FinishVrProfilerEvent(){} // RVA: 0x7FFAF9B16660
        public void DriverDebugRequest(){} // RVA: 0x7FFAF9B16730
    }

    public class CVRDriverManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B15210
        public void GetDriverCount(){} // RVA: 0x7FFAF3D31E30
        public void GetDriverName(){} // RVA: 0x7FFAF8C9D840
        public void GetDriverHandle(){} // RVA: 0x7FFAF9B153A0
        public void IsEnabled(){} // RVA: 0x7FFAF5DD9C00
    }

    public class CVRExtendedDisplay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B0EB10
        public void GetWindowBounds(){} // RVA: 0x7FFAF8C99150
        public void GetEyeOutputViewport(){} // RVA: 0x7FFAF8C99190
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAF8C991E0
    }

    public class CVRHeadsetView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B129F0
        public void SetHeadsetViewSize(){} // RVA: 0x7FFAF7DDB9F0
        public void GetHeadsetViewSize(){} // RVA: 0x7FFAF9B12BB0
        public void SetHeadsetViewMode(){} // RVA: 0x7FFAF66A7390
        public void GetHeadsetViewMode(){} // RVA: 0x7FFAF66E6B00
        public void SetHeadsetViewCropped(){} // RVA: 0x7FFAF853DBC0
        public void GetHeadsetViewCropped(){} // RVA: 0x7FFAF9B12BE0
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x7FFAF8C97B50
        public void SetHeadsetViewBlendRange(){} // RVA: 0x7FFAF7974C40
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7FFAF9B12C10
    }

    public class CVRIOBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B15EF0
        public void Open(){} // RVA: 0x7FFAF9B16090
        public void Close(){} // RVA: 0x7FFAF3459580
        public void Read(){} // RVA: 0x7FFAF8C9DF30
        public void Write(){} // RVA: 0x7FFAF8C9DF70
        public void PropertyContainer(){} // RVA: 0x7FFAF853DBC0
        public void HasReaders(){} // RVA: 0x7FFAF7974C10
    }

    public class CVRInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B15460
        public void SetActionManifestPath(){} // RVA: 0x7FFAF9B15650
        public void GetActionSetHandle(){} // RVA: 0x7FFAF9B15710
        public void GetActionHandle(){} // RVA: 0x7FFAF9B157E0
        public void GetInputSourceHandle(){} // RVA: 0x7FFAF9B158B0
        public void UpdateActionState(){} // RVA: 0x7FFAF8C9DAE0
        public void GetDigitalActionData(){} // RVA: 0x7FFAF8C9AA60
        public void GetAnalogActionData(){} // RVA: 0x7FFAF8C9B300
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x7FFAF8C9DB20
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7FFAF9B15980
        public void GetSkeletalActionData(){} // RVA: 0x7FFAF9B159B0
        public void GetDominantHand(){} // RVA: 0x7FFAF7974D80
        public void SetDominantHand(){} // RVA: 0x7FFAF8C9A4B0
        public void GetBoneCount(){} // RVA: 0x7FFAF9B11880
        public void GetBoneHierarchy(){} // RVA: 0x7FFAF9B159E0
        public void GetBoneName(){} // RVA: 0x7FFAF9B15A20
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7FFAF9B15A50
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFAF8C9B4E0
        public void GetSkeletalBoneData(){} // RVA: 0x7FFAF9B15AA0
        public void GetSkeletalSummaryData(){} // RVA: 0x7FFAF9B15AF0
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7FFAF9B15B20
        public void DecompressSkeletalBoneData(){} // RVA: 0x7FFAF9B15B60
        public void TriggerHapticVibrationAction(){} // RVA: 0x7FFAF9B15BB0
        public void GetActionOrigins(){} // RVA: 0x7FFAF9B15BF0
        public void GetOriginLocalizedName(){} // RVA: 0x7FFAF9B15C30
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7FFAF8C97EF0
        public void GetActionBindingInfo(){} // RVA: 0x7FFAF9B15C60
        public void ShowActionOrigins(){} // RVA: 0x7FFAF8C9B6D0
        public void ShowBindingsForActionSet(){} // RVA: 0x7FFAF9B15CB0
        public void GetComponentStateForBinding(){} // RVA: 0x7FFAF9B15CF0
        public void IsUsingLegacyInput(){} // RVA: 0x7FFAF8C9ADF0
        public void OpenBindingUI(){} // RVA: 0x7FFAF9B15E00
        public void GetBindingVariant(){} // RVA: 0x7FFAF8C9B7D0
    }

    public class CVRNotifications
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B13B20
        public void CreateNotification(){} // RVA: 0x7FFAF9B13CB0
        public void RemoveNotification(){} // RVA: 0x7FFAF3459580
    }

    public class CVROverlay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B11260
        public void FindOverlay(){} // RVA: 0x7FFAF9B11450
        public void CreateOverlay(){} // RVA: 0x7FFAF9B11520
        public void DestroyOverlay(){} // RVA: 0x7FFAF66A7390
        public void GetOverlayKey(){} // RVA: 0x7FFAF8C99500
        public void GetOverlayName(){} // RVA: 0x7FFAF9B11620
        public void SetOverlayName(){} // RVA: 0x7FFAF9B11650
        public void GetOverlayImageData(){} // RVA: 0x7FFAF9B11720
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7FFAF9B11770
        public void SetOverlayRenderingPid(){} // RVA: 0x7FFAF8C999A0
        public void GetOverlayRenderingPid(){} // RVA: 0x7FFAF8C999D0
        public void SetOverlayFlag(){} // RVA: 0x7FFAF9B11820
        public void GetOverlayFlag(){} // RVA: 0x7FFAF9B11850
        public void GetOverlayFlags(){} // RVA: 0x7FFAF9B11880
        public void SetOverlayColor(){} // RVA: 0x7FFAF9B118B0
        public void GetOverlayColor(){} // RVA: 0x7FFAF9B118E0
        public void SetOverlayAlpha(){} // RVA: 0x7FFAF8C9CA30
        public void GetOverlayAlpha(){} // RVA: 0x7FFAF9B11920
        public void SetOverlayTexelAspect(){} // RVA: 0x7FFAF8C99B80
        public void GetOverlayTexelAspect(){} // RVA: 0x7FFAF9B11950
        public void SetOverlaySortOrder(){} // RVA: 0x7FFAF8C99BB0
        public void GetOverlaySortOrder(){} // RVA: 0x7FFAF9B11980
        public void SetOverlayWidthInMeters(){} // RVA: 0x7FFAF9B119B0
        public void GetOverlayWidthInMeters(){} // RVA: 0x7FFAF9B119E0
        public void SetOverlayCurvature(){} // RVA: 0x7FFAF9B11A10
        public void GetOverlayCurvature(){} // RVA: 0x7FFAF9B11A40
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7FFAF9B11A70
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7FFAF9B11AA0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7FFAF8C9B700
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7FFAF8C9B730
        public void SetOverlayTextureBounds(){} // RVA: 0x7FFAF8C9B760
        public void GetOverlayTextureBounds(){} // RVA: 0x7FFAF9B11AD0
        public void GetOverlayTransformType(){} // RVA: 0x7FFAF9B11B00
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7FFAF9B11B30
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7FFAF8C9AEB0
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAF8C9B830
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAF8C9AF10
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAF9B11B60
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAF9B11C40
        public void SetOverlayTransformCursor(){} // RVA: 0x7FFAF9B11C80
        public void GetOverlayTransformCursor(){} // RVA: 0x7FFAF8C9AFE0
        public void SetOverlayTransformProjection(){} // RVA: 0x7FFAF9B11CB0
        public void ShowOverlay(){} // RVA: 0x7FFAF8C9B040
        public void HideOverlay(){} // RVA: 0x7FFAF8C9B980
        public void IsOverlayVisible(){} // RVA: 0x7FFAF8C9B9B0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7FFAF8C9B9E0
        public void WaitFrameSync(){} // RVA: 0x7FFAF9B11CF0
        public void PollNextOverlayEvent(){} // RVA: 0x7FFAF9B11D20
        public void GetOverlayInputMethod(){} // RVA: 0x7FFAF8C9BCA0
        public void SetOverlayInputMethod(){} // RVA: 0x7FFAF8C9BCD0
        public void GetOverlayMouseScale(){} // RVA: 0x7FFAF8C9BD00
        public void SetOverlayMouseScale(){} // RVA: 0x7FFAF9B11F80
        public void ComputeOverlayIntersection(){} // RVA: 0x7FFAF9B11FB0
        public void IsHoverTargetOverlay(){} // RVA: 0x7FFAF9B11FE0
        public void SetOverlayIntersectionMask(){} // RVA: 0x7FFAF9B12010
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7FFAF9B12040
        public void SetOverlayCursor(){} // RVA: 0x7FFAF8C9BE20
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7FFAF9B12070
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x7FFAF9B120A0
        public void SetOverlayTexture(){} // RVA: 0x7FFAF8C9BEC0
        public void ClearOverlayTexture(){} // RVA: 0x7FFAF8C9BEF0
        public void SetOverlayRaw(){} // RVA: 0x7FFAF8C9BF20
        public void SetOverlayFromFile(){} // RVA: 0x7FFAF9B120D0
        public void GetOverlayTexture(){} // RVA: 0x7FFAF8C9BF90
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7FFAF8C9BFF0
        public void GetOverlayTextureSize(){} // RVA: 0x7FFAF8C9C020
        public void CreateDashboardOverlay(){} // RVA: 0x7FFAF9B121A0
        public void IsDashboardVisible(){} // RVA: 0x7FFAF8C9C0A0
        public void IsActiveDashboardOverlay(){} // RVA: 0x7FFAF8C9C0D0
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAF8C9C100
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAF8C9C130
        public void ShowDashboard(){} // RVA: 0x7FFAF9B122B0
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7FFAF8C9C190
        public void ShowKeyboard(){} // RVA: 0x7FFAF9B12370
        public void ShowKeyboardForOverlay(){} // RVA: 0x7FFAF9B124A0
        public void GetKeyboardText(){} // RVA: 0x7FFAF8C9C240
        public void HideKeyboard(){} // RVA: 0x7FFAF8C9C270
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7FFAF8C9C2A0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7FFAF8C9C2D0
        public void ShowMessageOverlay(){} // RVA: 0x7FFAF9B125E0
        public void CloseMessageOverlay(){} // RVA: 0x7FFAF9B12760
    }

    public class CVROverlayView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B12860
        public void AcquireOverlayView(){} // RVA: 0x7FFAF9145EC0
        public void ReleaseOverlayView(){} // RVA: 0x7FFAF3459580
        public void PostOverlayEvent(){} // RVA: 0x7FFAF853DBF0
        public void IsViewingPermitted(){} // RVA: 0x7FFAF5DD9C00
    }

    public class CVRPaths
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B16A50
        public void ReadPathBatch(){} // RVA: 0x7FFAF8C9D640
        public void WritePathBatch(){} // RVA: 0x7FFAF8C9D840
        public void StringToHandle(){} // RVA: 0x7FFAF9B16BE0
        public void HandleToString(){} // RVA: 0x7FFAF9B16CB0
    }

    public class CVRProperties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B16810
        public void ReadPropertyBatch(){} // RVA: 0x7FFAF8C9D640
        public void WritePropertyBatch(){} // RVA: 0x7FFAF8C9D840
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFAF9B169A0
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x7FFAF5DD9C00
    }

    public class CVRPropertyHelpers
    {
    }

    public class CVRRenderModels
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B12C40
        public void LoadRenderModel_Async(){} // RVA: 0x7FFAF9B12E30
        public void FreeRenderModel(){} // RVA: 0x7FFAF3459580
        public void LoadTexture_Async(){} // RVA: 0x7FFAF853DBF0
        public void FreeTexture(){} // RVA: 0x7FFAF5DD9C00
        public void LoadTextureD3D11_Async(){} // RVA: 0x7FFAF8C99900
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7FFAF8C9C6A0
        public void FreeTextureD3D11(){} // RVA: 0x7FFAF8C99590
        public void GetRenderModelName(){} // RVA: 0x7FFAF8C9C6D0
        public void GetRenderModelCount(){} // RVA: 0x7FFAF8C9C700
        public void GetComponentCount(){} // RVA: 0x7FFAF9B12F00
        public void GetComponentName(){} // RVA: 0x7FFAF9B12FC0
        public void GetComponentButtonMask(){} // RVA: 0x7FFAF9B130A0
        public void GetComponentRenderModelName(){} // RVA: 0x7FFAF9B13180
        public void GetComponentStateForDevicePath(){} // RVA: 0x7FFAF9B13280
        public void GetComponentState(){} // RVA: 0x7FFAF9B13390
        public void RenderModelHasComponent(){} // RVA: 0x7FFAF9B13690
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7FFAF9B13770
        public void GetRenderModelOriginalPath(){} // RVA: 0x7FFAF9B13860
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7FFAF9B13950
    }

    public class CVRResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B14EA0
        public void LoadSharedResource(){} // RVA: 0x7FFAF9B15030
        public void GetResourceFullPath(){} // RVA: 0x7FFAF9B15110
    }

    public class CVRScreenshots
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B149E0
        public void RequestScreenshot(){} // RVA: 0x7FFAF9B14B90
        public void HookScreenshot(){} // RVA: 0x7FFAF8C9D3E0
        public void GetScreenshotPropertyType(){} // RVA: 0x7FFAF853DBF0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7FFAF8C9D410
        public void UpdateScreenshotProgress(){} // RVA: 0x7FFAF8C9D440
        public void TakeStereoScreenshot(){} // RVA: 0x7FFAF9B14CA0
        public void SubmitScreenshot(){} // RVA: 0x7FFAF9B14DA0
    }

    public class CVRSettingHelper
    {
    }

    public class CVRSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B13DD0
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7FFAF9B13F90
        public void SetBool(){} // RVA: 0x7FFAF9B14040
        public void SetInt32(){} // RVA: 0x7FFAF9B14140
        public void SetFloat(){} // RVA: 0x7FFAF9B14240
        public void SetString(){} // RVA: 0x7FFAF9B14340
        public void GetBool(){} // RVA: 0x7FFAF9B14450
        public void GetInt32(){} // RVA: 0x7FFAF9B14540
        public void GetFloat(){} // RVA: 0x7FFAF9B14630
        public void GetString(){} // RVA: 0x7FFAF9B14730
        public void RemoveSection(){} // RVA: 0x7FFAF9B14830
        public void RemoveKeyInSection(){} // RVA: 0x7FFAF9B148F0
    }

    public class CVRSpatialAnchors
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B16180
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7FFAF9B16310
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7FFAF8C9E160
        public void GetSpatialAnchorPose(){} // RVA: 0x7FFAF8C9E1A0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7FFAF8C9E1D0
    }

    public class CVRSystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B0D820
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7FFAF8C979B0
        public void GetProjectionMatrix(){} // RVA: 0x7FFAF8C979E0
        public void GetProjectionRaw(){} // RVA: 0x7FFAF8C97A50
        public void ComputeDistortion(){} // RVA: 0x7FFAF8C97AA0
        public void GetEyeToHeadTransform(){} // RVA: 0x7FFAF8C97AD0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7FFAF8C97B20
        public void GetD3D9AdapterIndex(){} // RVA: 0x7FFAF8C97B50
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAF8C97B80
        public void GetOutputDevice(){} // RVA: 0x7FFAF8C97BB0
        public void IsDisplayOnDesktop(){} // RVA: 0x7FFAF8C97BF0
        public void SetDisplayVisibility(){} // RVA: 0x7FFAF7974D80
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7FFAF8C97C20
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAF9B0DA40
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAF8C97C90
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7FFAF9B0DA90
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7FFAF9B0DAD0
        public void ApplyTransform(){} // RVA: 0x7FFAF8C99B50
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7FFAF9B0DB00
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7FFAF8C97DD0
        public void GetTrackedDeviceClass(){} // RVA: 0x7FFAF8C97E00
        public void IsTrackedDeviceConnected(){} // RVA: 0x7FFAF8C97E30
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7FFAF8C99C10
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7FFAF8C97E90
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7FFAF8C97EC0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7FFAF8C97EF0
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7FFAF9B0DB30
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7FFAF9B0DB90
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7FFAF9B0DBD0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFAF9B0DC10
        public void PollNextEvent(){} // RVA: 0x7FFAF9B0DCC0
        public void PollNextEventWithPose(){} // RVA: 0x7FFAF9B0DF10
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7FFAF9B0DF40
        public void GetHiddenAreaMesh(){} // RVA: 0x7FFAF9B0DFF0
        public void GetControllerState(){} // RVA: 0x7FFAF9B0E040
        public void GetControllerStateWithPose(){} // RVA: 0x7FFAF9B0E310
        public void TriggerHapticPulse(){} // RVA: 0x7FFAF8C9B860
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7FFAF9B0E610
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7FFAF9B0E6C0
        public void IsInputAvailable(){} // RVA: 0x7FFAF9B0E770
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7FFAF8C98BB0
        public void ShouldApplicationPause(){} // RVA: 0x7FFAF8C98BE0
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7FFAF8C98C10
        public void PerformFirmwareUpdate(){} // RVA: 0x7FFAF8C9B980
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7FFAF9B0E7A0
        public void GetAppContainerFilePaths(){} // RVA: 0x7FFAF9B0E7D0
        public void GetRuntimeVersion(){} // RVA: 0x7FFAF9B0E800
    }

    public class CVRTrackedCamera
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B0ECB0
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7FFAF9B0EE70
        public void HasCamera(){} // RVA: 0x7FFAF8C99480
        public void GetCameraFrameSize(){} // RVA: 0x7FFAF8C994B0
        public void GetCameraIntrinsics(){} // RVA: 0x7FFAF8C9D410
        public void GetCameraProjection(){} // RVA: 0x7FFAF9B0EF20
        public void AcquireVideoStreamingService(){} // RVA: 0x7FFAF8C99560
        public void ReleaseVideoStreamingService(){} // RVA: 0x7FFAF8C99590
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7FFAF8C995C0
        public void GetVideoStreamTextureSize(){} // RVA: 0x7FFAF8C995F0
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7FFAF8C99640
        public void GetVideoStreamTextureGL(){} // RVA: 0x7FFAF8C99670
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7FFAF8C996B0
        public void SetCameraTrackingSpace(){} // RVA: 0x7FFAF8C99A00
        public void GetCameraTrackingSpace(){} // RVA: 0x7FFAF9B0EF50
    }

    public class CameraVideoStreamFrameHeader_t
    {
    }

    public class Compositor_BenchmarkResults
    {
    }

    public class Compositor_CumulativeStats
    {
    }

    public class Compositor_FrameTiming
    {
    }

    public class Compositor_StageRenderSettings
    {
    }

}