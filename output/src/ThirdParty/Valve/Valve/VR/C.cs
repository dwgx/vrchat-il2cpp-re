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
        public void .ctor(){} // RVA: 0x705EF80
        public void AddApplicationManifest(){} // RVA: 0x705F190
        public void RemoveApplicationManifest(){} // RVA: 0x705F260
        public void IsApplicationInstalled(){} // RVA: 0x705F320
        public void GetApplicationCount(){} // RVA: 0x3C36B00
        public void GetApplicationKeyByIndex(){} // RVA: 0x61E9900
        public void GetApplicationKeyByProcessId(){} // RVA: 0x61E9930
        public void LaunchApplication(){} // RVA: 0x705F3E0
        public void LaunchTemplateApplication(){} // RVA: 0x705F4A0
        public void LaunchApplicationFromMimeType(){} // RVA: 0x705F5A0
        public void LaunchDashboardOverlay(){} // RVA: 0x705F680
        public void CancelApplicationLaunch(){} // RVA: 0x705F740
        public void IdentifyApplication(){} // RVA: 0x705F800
        public void GetApplicationProcessId(){} // RVA: 0x705F8C0
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x705F980
        public void GetApplicationPropertyString(){} // RVA: 0x705FA30
        public void GetApplicationPropertyBool(){} // RVA: 0x705FB20
        public void GetApplicationPropertyUint64(){} // RVA: 0x705FC00
        public void SetApplicationAutoLaunch(){} // RVA: 0x705FCE0
        public void GetApplicationAutoLaunch(){} // RVA: 0x705FDB0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x705FE70
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x705FF50
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7060030
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7060110
        public void GetApplicationLaunchArguments(){} // RVA: 0x61E7EC0
        public void GetStartingApplication(){} // RVA: 0x61E9C40
        public void GetSceneApplicationState(){} // RVA: 0x61E9C70
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x70601F0
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x70602B0
        public void LaunchInternalProcess(){} // RVA: 0x7060360
        public void GetCurrentSceneProcessId(){} // RVA: 0x61EADF0
    }

    public class CVRBlockQueue
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7066CF0
        public void Create(){} // RVA: 0x7066EB0
        public void Connect(){} // RVA: 0x7066FB0
        public void Destroy(){} // RVA: 0x3BF7390
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7067080
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x61ED440
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x70670C0
        public void AcquireReadOnlyBlock(){} // RVA: 0x7067100
        public void ReleaseReadOnlyBlock(){} // RVA: 0x4EC4C40
        public void QueueHasReader(){} // RVA: 0x7067140
    }

    public class CVRChaperone
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7060470
        public void GetCalibrationState(){} // RVA: 0x1281E30
        public void GetPlayAreaSize(){} // RVA: 0x61E9FB0
        public void GetPlayAreaRect(){} // RVA: 0x3BF7390
        public void ReloadInfo(){} // RVA: 0x3C36B00
        public void SetSceneColor(){} // RVA: 0x61E9FE0
        public void GetBoundsColor(){} // RVA: 0x61EA020
        public void AreBoundsVisible(){} // RVA: 0x61E7B50
        public void ForceBoundsVisible(){} // RVA: 0x61EA050
        public void ResetZeroPose(){} // RVA: 0x7060630
    }

    public class CVRChaperoneSetup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7060660
        public void CommitWorkingCopy(){} // RVA: 0x288D780
        public void RevertWorkingCopy(){} // RVA: 0x3D91AE0
        public void GetWorkingPlayAreaSize(){} // RVA: 0x61EA270
        public void GetWorkingPlayAreaRect(){} // RVA: 0x3329C00
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7060850
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7060940
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x61E9590
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x61EA050
        public void SetWorkingPlayAreaSize(){} // RVA: 0x61E99A0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x61EA480
        public void SetWorkingPerimeter(){} // RVA: 0x7060A30
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x61EA4B0
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x61E9A00
        public void ReloadFromDisk(){} // RVA: 0x61EA4E0
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7060A60
        public void ExportLiveToBuffer(){} // RVA: 0x7060A90
        public void ImportFromBufferToWorking(){} // RVA: 0x7060AC0
        public void ShowWorkingSetPreview(){} // RVA: 0x61EAC10
        public void HideWorkingSetPreview(){} // RVA: 0x61EAC40
        public void RoomSetupStarting(){} // RVA: 0x61EAC70
    }

    public class CVRCompositor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7060B90
        public void SetTrackingSpace(){} // RVA: 0x288D780
        public void GetTrackingSpace(){} // RVA: 0x3D91AE0
        public void WaitGetPoses(){} // RVA: 0x61EA9C0
        public void GetLastPoses(){} // RVA: 0x61EAA10
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x61E9900
        public void Submit(){} // RVA: 0x61EAA60
        public void SubmitWithArrayIndex(){} // RVA: 0x7060D90
        public void ClearLastSubmittedFrame(){} // RVA: 0x61EAA90
        public void PostPresentHandoff(){} // RVA: 0x61EC700
        public void GetFrameTiming(){} // RVA: 0x61EAAC0
        public void GetFrameTimings(){} // RVA: 0x7060A30
        public void GetFrameTimeRemaining(){} // RVA: 0x7060DC0
        public void GetCumulativeStats(){} // RVA: 0x7060DF0
        public void FadeToColor(){} // RVA: 0x7060E20
        public void GetCurrentFadeColor(){} // RVA: 0x7060E70
        public void FadeGrid(){} // RVA: 0x61ECA30
        public void GetCurrentGridAlpha(){} // RVA: 0x7060EB0
        public void SetSkyboxOverride(){} // RVA: 0x7060EE0
        public void ClearSkyboxOverride(){} // RVA: 0x61EAC40
        public void CompositorBringToFront(){} // RVA: 0x61EAC70
        public void CompositorGoToBack(){} // RVA: 0x61EACA0
        public void CompositorQuit(){} // RVA: 0x61EACD0
        public void IsFullscreen(){} // RVA: 0x61EAD00
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x61EAD30
        public void GetLastFrameRenderer(){} // RVA: 0x61EAD60
        public void CanRenderScene(){} // RVA: 0x61E9C70
        public void ShowMirrorWindow(){} // RVA: 0x61EAD90
        public void HideMirrorWindow(){} // RVA: 0x61EADC0
        public void IsMirrorWindowVisible(){} // RVA: 0x61E9D80
        public void CompositorDumpImages(){} // RVA: 0x61EADF0
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x61E9DE0
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7060F20
        public void ForceReconnectProcess(){} // RVA: 0x7060F50
        public void SuspendRendering(){} // RVA: 0x7060F80
        public void GetMirrorTextureD3D11(){} // RVA: 0x61EB830
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7060FB0
        public void GetMirrorTextureGL(){} // RVA: 0x61EB890
        public void ReleaseSharedGLTexture(){} // RVA: 0x7060FE0
        public void LockGLSharedTextureForAccess(){} // RVA: 0x61EAFB0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7061010
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7061040
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7061070
        public void SetExplicitTimingMode(){} // RVA: 0x61EB980
        public void SubmitExplicitTimingData(){} // RVA: 0x705E7A0
        public void IsMotionSmoothingEnabled(){} // RVA: 0x70610A0
        public void IsMotionSmoothingSupported(){} // RVA: 0x61E8CD0
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x61E8D00
        public void SetStageOverride_Async(){} // RVA: 0x70610D0
        public void ClearStageOverride(){} // RVA: 0x70611C0
        public void GetCompositorBenchmarkResults(){} // RVA: 0x61EBD00
        public void GetLastPosePredictionIDs(){} // RVA: 0x70611F0
        public void GetPosesForFrame(){} // RVA: 0x7061220
    }

    public class CVRDebug
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70663E0
        public void EmitVrProfilerEvent(){} // RVA: 0x7066570
        public void BeginVrProfilerEvent(){} // RVA: 0x7066630
        public void FinishVrProfilerEvent(){} // RVA: 0x7066660
        public void DriverDebugRequest(){} // RVA: 0x7066730
    }

    public class CVRDriverManager
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7065210
        public void GetDriverCount(){} // RVA: 0x1281E30
        public void GetDriverName(){} // RVA: 0x61ED840
        public void GetDriverHandle(){} // RVA: 0x70653A0
        public void IsEnabled(){} // RVA: 0x3329C00
    }

    public class CVRExtendedDisplay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x705EB10
        public void GetWindowBounds(){} // RVA: 0x61E9150
        public void GetEyeOutputViewport(){} // RVA: 0x61E9190
        public void GetDXGIOutputInfo(){} // RVA: 0x61E91E0
    }

    public class CVRHeadsetView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70629F0
        public void SetHeadsetViewSize(){} // RVA: 0x532B9F0
        public void GetHeadsetViewSize(){} // RVA: 0x7062BB0
        public void SetHeadsetViewMode(){} // RVA: 0x3BF7390
        public void GetHeadsetViewMode(){} // RVA: 0x3C36B00
        public void SetHeadsetViewCropped(){} // RVA: 0x5A8DBC0
        public void GetHeadsetViewCropped(){} // RVA: 0x7062BE0
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x61E7B50
        public void SetHeadsetViewBlendRange(){} // RVA: 0x4EC4C40
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7062C10
    }

    public class CVRIOBuffer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7065EF0
        public void Open(){} // RVA: 0x7066090
        public void Close(){} // RVA: 0x9A9580
        public void Read(){} // RVA: 0x61EDF30
        public void Write(){} // RVA: 0x61EDF70
        public void PropertyContainer(){} // RVA: 0x5A8DBC0
        public void HasReaders(){} // RVA: 0x4EC4C10
    }

    public class CVRInput
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7065460
        public void SetActionManifestPath(){} // RVA: 0x7065650
        public void GetActionSetHandle(){} // RVA: 0x7065710
        public void GetActionHandle(){} // RVA: 0x70657E0
        public void GetInputSourceHandle(){} // RVA: 0x70658B0
        public void UpdateActionState(){} // RVA: 0x61EDAE0
        public void GetDigitalActionData(){} // RVA: 0x61EAA60
        public void GetAnalogActionData(){} // RVA: 0x61EB300
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x61EDB20
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7065980
        public void GetSkeletalActionData(){} // RVA: 0x70659B0
        public void GetDominantHand(){} // RVA: 0x4EC4D80
        public void SetDominantHand(){} // RVA: 0x61EA4B0
        public void GetBoneCount(){} // RVA: 0x7061880
        public void GetBoneHierarchy(){} // RVA: 0x70659E0
        public void GetBoneName(){} // RVA: 0x7065A20
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7065A50
        public void GetSkeletalTrackingLevel(){} // RVA: 0x61EB4E0
        public void GetSkeletalBoneData(){} // RVA: 0x7065AA0
        public void GetSkeletalSummaryData(){} // RVA: 0x7065AF0
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7065B20
        public void DecompressSkeletalBoneData(){} // RVA: 0x7065B60
        public void TriggerHapticVibrationAction(){} // RVA: 0x7065BB0
        public void GetActionOrigins(){} // RVA: 0x7065BF0
        public void GetOriginLocalizedName(){} // RVA: 0x7065C30
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x61E7EF0
        public void GetActionBindingInfo(){} // RVA: 0x7065C60
        public void ShowActionOrigins(){} // RVA: 0x61EB6D0
        public void ShowBindingsForActionSet(){} // RVA: 0x7065CB0
        public void GetComponentStateForBinding(){} // RVA: 0x7065CF0
        public void IsUsingLegacyInput(){} // RVA: 0x61EADF0
        public void OpenBindingUI(){} // RVA: 0x7065E00
        public void GetBindingVariant(){} // RVA: 0x61EB7D0
    }

    public class CVRNotifications
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7063B20
        public void CreateNotification(){} // RVA: 0x7063CB0
        public void RemoveNotification(){} // RVA: 0x9A9580
    }

    public class CVROverlay
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7061260
        public void FindOverlay(){} // RVA: 0x7061450
        public void CreateOverlay(){} // RVA: 0x7061520
        public void DestroyOverlay(){} // RVA: 0x3BF7390
        public void GetOverlayKey(){} // RVA: 0x61E9500
        public void GetOverlayName(){} // RVA: 0x7061620
        public void SetOverlayName(){} // RVA: 0x7061650
        public void GetOverlayImageData(){} // RVA: 0x7061720
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7061770
        public void SetOverlayRenderingPid(){} // RVA: 0x61E99A0
        public void GetOverlayRenderingPid(){} // RVA: 0x61E99D0
        public void SetOverlayFlag(){} // RVA: 0x7061820
        public void GetOverlayFlag(){} // RVA: 0x7061850
        public void GetOverlayFlags(){} // RVA: 0x7061880
        public void SetOverlayColor(){} // RVA: 0x70618B0
        public void GetOverlayColor(){} // RVA: 0x70618E0
        public void SetOverlayAlpha(){} // RVA: 0x61ECA30
        public void GetOverlayAlpha(){} // RVA: 0x7061920
        public void SetOverlayTexelAspect(){} // RVA: 0x61E9B80
        public void GetOverlayTexelAspect(){} // RVA: 0x7061950
        public void SetOverlaySortOrder(){} // RVA: 0x61E9BB0
        public void GetOverlaySortOrder(){} // RVA: 0x7061980
        public void SetOverlayWidthInMeters(){} // RVA: 0x70619B0
        public void GetOverlayWidthInMeters(){} // RVA: 0x70619E0
        public void SetOverlayCurvature(){} // RVA: 0x7061A10
        public void GetOverlayCurvature(){} // RVA: 0x7061A40
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7061A70
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7061AA0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x61EB700
        public void GetOverlayTextureColorSpace(){} // RVA: 0x61EB730
        public void SetOverlayTextureBounds(){} // RVA: 0x61EB760
        public void GetOverlayTextureBounds(){} // RVA: 0x7061AD0
        public void GetOverlayTransformType(){} // RVA: 0x7061B00
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7061B30
        public void GetOverlayTransformAbsolute(){} // RVA: 0x61EAEB0
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x61EB830
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x61EAF10
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7061B60
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7061C40
        public void SetOverlayTransformCursor(){} // RVA: 0x7061C80
        public void GetOverlayTransformCursor(){} // RVA: 0x61EAFE0
        public void SetOverlayTransformProjection(){} // RVA: 0x7061CB0
        public void ShowOverlay(){} // RVA: 0x61EB040
        public void HideOverlay(){} // RVA: 0x61EB980
        public void IsOverlayVisible(){} // RVA: 0x61EB9B0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x61EB9E0
        public void WaitFrameSync(){} // RVA: 0x7061CF0
        public void PollNextOverlayEvent(){} // RVA: 0x7061D20
        public void GetOverlayInputMethod(){} // RVA: 0x61EBCA0
        public void SetOverlayInputMethod(){} // RVA: 0x61EBCD0
        public void GetOverlayMouseScale(){} // RVA: 0x61EBD00
        public void SetOverlayMouseScale(){} // RVA: 0x7061F80
        public void ComputeOverlayIntersection(){} // RVA: 0x7061FB0
        public void IsHoverTargetOverlay(){} // RVA: 0x7061FE0
        public void SetOverlayIntersectionMask(){} // RVA: 0x7062010
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7062040
        public void SetOverlayCursor(){} // RVA: 0x61EBE20
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7062070
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x70620A0
        public void SetOverlayTexture(){} // RVA: 0x61EBEC0
        public void ClearOverlayTexture(){} // RVA: 0x61EBEF0
        public void SetOverlayRaw(){} // RVA: 0x61EBF20
        public void SetOverlayFromFile(){} // RVA: 0x70620D0
        public void GetOverlayTexture(){} // RVA: 0x61EBF90
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x61EBFF0
        public void GetOverlayTextureSize(){} // RVA: 0x61EC020
        public void CreateDashboardOverlay(){} // RVA: 0x70621A0
        public void IsDashboardVisible(){} // RVA: 0x61EC0A0
        public void IsActiveDashboardOverlay(){} // RVA: 0x61EC0D0
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x61EC100
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x61EC130
        public void ShowDashboard(){} // RVA: 0x70622B0
        public void GetPrimaryDashboardDevice(){} // RVA: 0x61EC190
        public void ShowKeyboard(){} // RVA: 0x7062370
        public void ShowKeyboardForOverlay(){} // RVA: 0x70624A0
        public void GetKeyboardText(){} // RVA: 0x61EC240
        public void HideKeyboard(){} // RVA: 0x61EC270
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x61EC2A0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x61EC2D0
        public void ShowMessageOverlay(){} // RVA: 0x70625E0
        public void CloseMessageOverlay(){} // RVA: 0x7062760
    }

    public class CVROverlayView
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7062860
        public void AcquireOverlayView(){} // RVA: 0x6695EC0
        public void ReleaseOverlayView(){} // RVA: 0x9A9580
        public void PostOverlayEvent(){} // RVA: 0x5A8DBF0
        public void IsViewingPermitted(){} // RVA: 0x3329C00
    }

    public class CVRPaths
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7066A50
        public void ReadPathBatch(){} // RVA: 0x61ED640
        public void WritePathBatch(){} // RVA: 0x61ED840
        public void StringToHandle(){} // RVA: 0x7066BE0
        public void HandleToString(){} // RVA: 0x7066CB0
    }

    public class CVRProperties
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7066810
        public void ReadPropertyBatch(){} // RVA: 0x61ED640
        public void WritePropertyBatch(){} // RVA: 0x61ED840
        public void GetPropErrorNameFromEnum(){} // RVA: 0x70669A0
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x3329C00
    }

    public class CVRPropertyHelpers
    {
    }

    public class CVRRenderModels
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7062C40
        public void LoadRenderModel_Async(){} // RVA: 0x7062E30
        public void FreeRenderModel(){} // RVA: 0x9A9580
        public void LoadTexture_Async(){} // RVA: 0x5A8DBF0
        public void FreeTexture(){} // RVA: 0x3329C00
        public void LoadTextureD3D11_Async(){} // RVA: 0x61E9900
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x61EC6A0
        public void FreeTextureD3D11(){} // RVA: 0x61E9590
        public void GetRenderModelName(){} // RVA: 0x61EC6D0
        public void GetRenderModelCount(){} // RVA: 0x61EC700
        public void GetComponentCount(){} // RVA: 0x7062F00
        public void GetComponentName(){} // RVA: 0x7062FC0
        public void GetComponentButtonMask(){} // RVA: 0x70630A0
        public void GetComponentRenderModelName(){} // RVA: 0x7063180
        public void GetComponentStateForDevicePath(){} // RVA: 0x7063280
        public void GetComponentState(){} // RVA: 0x7063390
        public void RenderModelHasComponent(){} // RVA: 0x7063690
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7063770
        public void GetRenderModelOriginalPath(){} // RVA: 0x7063860
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7063950
    }

    public class CVRResources
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7064EA0
        public void LoadSharedResource(){} // RVA: 0x7065030
        public void GetResourceFullPath(){} // RVA: 0x7065110
    }

    public class CVRScreenshots
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x70649E0
        public void RequestScreenshot(){} // RVA: 0x7064B90
        public void HookScreenshot(){} // RVA: 0x61ED3E0
        public void GetScreenshotPropertyType(){} // RVA: 0x5A8DBF0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x61ED410
        public void UpdateScreenshotProgress(){} // RVA: 0x61ED440
        public void TakeStereoScreenshot(){} // RVA: 0x7064CA0
        public void SubmitScreenshot(){} // RVA: 0x7064DA0
    }

    public class CVRSettingHelper
    {
    }

    public class CVRSettings
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7063DD0
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7063F90
        public void SetBool(){} // RVA: 0x7064040
        public void SetInt32(){} // RVA: 0x7064140
        public void SetFloat(){} // RVA: 0x7064240
        public void SetString(){} // RVA: 0x7064340
        public void GetBool(){} // RVA: 0x7064450
        public void GetInt32(){} // RVA: 0x7064540
        public void GetFloat(){} // RVA: 0x7064630
        public void GetString(){} // RVA: 0x7064730
        public void RemoveSection(){} // RVA: 0x7064830
        public void RemoveKeyInSection(){} // RVA: 0x70648F0
    }

    public class CVRSpatialAnchors
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7066180
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7066310
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x61EE160
        public void GetSpatialAnchorPose(){} // RVA: 0x61EE1A0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x61EE1D0
    }

    public class CVRSystem
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x705D820
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x61E79B0
        public void GetProjectionMatrix(){} // RVA: 0x61E79E0
        public void GetProjectionRaw(){} // RVA: 0x61E7A50
        public void ComputeDistortion(){} // RVA: 0x61E7AA0
        public void GetEyeToHeadTransform(){} // RVA: 0x61E7AD0
        public void GetTimeSinceLastVsync(){} // RVA: 0x61E7B20
        public void GetD3D9AdapterIndex(){} // RVA: 0x61E7B50
        public void GetDXGIOutputInfo(){} // RVA: 0x61E7B80
        public void GetOutputDevice(){} // RVA: 0x61E7BB0
        public void IsDisplayOnDesktop(){} // RVA: 0x61E7BF0
        public void SetDisplayVisibility(){} // RVA: 0x4EC4D80
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x61E7C20
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x705DA40
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x61E7C90
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x705DA90
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x705DAD0
        public void ApplyTransform(){} // RVA: 0x61E9B50
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x705DB00
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x61E7DD0
        public void GetTrackedDeviceClass(){} // RVA: 0x61E7E00
        public void IsTrackedDeviceConnected(){} // RVA: 0x61E7E30
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x61E9C10
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x61E7E90
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x61E7EC0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x61E7EF0
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x705DB30
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x705DB90
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x705DBD0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x705DC10
        public void PollNextEvent(){} // RVA: 0x705DCC0
        public void PollNextEventWithPose(){} // RVA: 0x705DF10
        public void GetEventTypeNameFromEnum(){} // RVA: 0x705DF40
        public void GetHiddenAreaMesh(){} // RVA: 0x705DFF0
        public void GetControllerState(){} // RVA: 0x705E040
        public void GetControllerStateWithPose(){} // RVA: 0x705E310
        public void TriggerHapticPulse(){} // RVA: 0x61EB860
        public void GetButtonIdNameFromEnum(){} // RVA: 0x705E610
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x705E6C0
        public void IsInputAvailable(){} // RVA: 0x705E770
        public void IsSteamVRDrawingControllers(){} // RVA: 0x61E8BB0
        public void ShouldApplicationPause(){} // RVA: 0x61E8BE0
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x61E8C10
        public void PerformFirmwareUpdate(){} // RVA: 0x61EB980
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x705E7A0
        public void GetAppContainerFilePaths(){} // RVA: 0x705E7D0
        public void GetRuntimeVersion(){} // RVA: 0x705E800
    }

    public class CVRTrackedCamera
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x705ECB0
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x705EE70
        public void HasCamera(){} // RVA: 0x61E9480
        public void GetCameraFrameSize(){} // RVA: 0x61E94B0
        public void GetCameraIntrinsics(){} // RVA: 0x61ED410
        public void GetCameraProjection(){} // RVA: 0x705EF20
        public void AcquireVideoStreamingService(){} // RVA: 0x61E9560
        public void ReleaseVideoStreamingService(){} // RVA: 0x61E9590
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x61E95C0
        public void GetVideoStreamTextureSize(){} // RVA: 0x61E95F0
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x61E9640
        public void GetVideoStreamTextureGL(){} // RVA: 0x61E9670
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x61E96B0
        public void SetCameraTrackingSpace(){} // RVA: 0x61E9A00
        public void GetCameraTrackingSpace(){} // RVA: 0x705EF50
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