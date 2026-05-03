// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 31
// Methods: 398

namespace ThirdParty.Valve.Valve.VR
{
    public class COpenVRContext : ValueType
    {
    }

    public class CVRApplications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B9FE50
        public void AddApplicationManifest(){} // RVA: 0x7FFE87BA0060
        public void RemoveApplicationManifest(){} // RVA: 0x7FFE87BA0130
        public void IsApplicationInstalled(){} // RVA: 0x7FFE87BA01F0
        public void GetApplicationCount(){} // RVA: 0x7FFE848ABA00
        public void GetApplicationKeyByIndex(){} // RVA: 0x7FFE86D2A7A0
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7FFE86D2A7D0
        public void LaunchApplication(){} // RVA: 0x7FFE87BA02B0
        public void LaunchTemplateApplication(){} // RVA: 0x7FFE87BA0370
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7FFE87BA0470
        public void LaunchDashboardOverlay(){} // RVA: 0x7FFE87BA0550
        public void CancelApplicationLaunch(){} // RVA: 0x7FFE87BA0610
        public void IdentifyApplication(){} // RVA: 0x7FFE87BA06D0
        public void GetApplicationProcessId(){} // RVA: 0x7FFE87BA0790
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7FFE87BA0850
        public void GetApplicationPropertyString(){} // RVA: 0x7FFE87BA0900
        public void GetApplicationPropertyBool(){} // RVA: 0x7FFE87BA09F0
        public void GetApplicationPropertyUint64(){} // RVA: 0x7FFE87BA0AD0
        public void SetApplicationAutoLaunch(){} // RVA: 0x7FFE87BA0BB0
        public void GetApplicationAutoLaunch(){} // RVA: 0x7FFE87BA0C80
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7FFE87BA0D40
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7FFE87BA0E20
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7FFE87BA0F00
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7FFE87BA0FE0
        public void GetApplicationLaunchArguments(){} // RVA: 0x7FFE86D28D60
        public void GetStartingApplication(){} // RVA: 0x7FFE86D2AAE0
        public void GetSceneApplicationState(){} // RVA: 0x7FFE86D2AB10
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7FFE87BA10C0
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x7FFE87BA1180
        public void LaunchInternalProcess(){} // RVA: 0x7FFE87BA1230
        public void GetCurrentSceneProcessId(){} // RVA: 0x7FFE86D2BC90
    }

    public class CVRBlockQueue : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA7BC0
        public void Create(){} // RVA: 0x7FFE87BA7D80
        public void Connect(){} // RVA: 0x7FFE87BA7E80
        public void Destroy(){} // RVA: 0x7FFE8487FE20
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7FFE87BA7F50
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x7FFE86D2E2E0
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x7FFE87BA7F90
        public void AcquireReadOnlyBlock(){} // RVA: 0x7FFE87BA7FD0
        public void ReleaseReadOnlyBlock(){} // RVA: 0x7FFE85B63750
        public void QueueHasReader(){} // RVA: 0x7FFE87BA8010
    }

    public class CVRChaperone : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA1340
        public void GetCalibrationState(){} // RVA: 0x7FFE82001D60
        public void GetPlayAreaSize(){} // RVA: 0x7FFE86D2AE50
        public void GetPlayAreaRect(){} // RVA: 0x7FFE8487FE20
        public void ReloadInfo(){} // RVA: 0x7FFE848ABA00
        public void SetSceneColor(){} // RVA: 0x7FFE86D2AE80
        public void GetBoundsColor(){} // RVA: 0x7FFE86D2AEC0
        public void AreBoundsVisible(){} // RVA: 0x7FFE86D289F0
        public void ForceBoundsVisible(){} // RVA: 0x7FFE86D2AEF0
        public void ResetZeroPose(){} // RVA: 0x7FFE87BA1500
    }

    public class CVRChaperoneSetup : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA1530
        public void CommitWorkingCopy(){} // RVA: 0x7FFE85A7C5E0
        public void RevertWorkingCopy(){} // RVA: 0x7FFE84A02160
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7FFE86D2B110
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7FFE83FA8560
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFE87BA1720
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7FFE87BA1810
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2A430
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2AEF0
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7FFE86D2A840
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFE86D2B320
        public void SetWorkingPerimeter(){} // RVA: 0x7FFE87BA1900
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2B350
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE86D2A8A0
        public void ReloadFromDisk(){} // RVA: 0x7FFE86D2B380
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFE87BA1930
        public void ExportLiveToBuffer(){} // RVA: 0x7FFE87BA1960
        public void ImportFromBufferToWorking(){} // RVA: 0x7FFE87BA1990
        public void ShowWorkingSetPreview(){} // RVA: 0x7FFE86D2BAB0
        public void HideWorkingSetPreview(){} // RVA: 0x7FFE86D2BAE0
        public void RoomSetupStarting(){} // RVA: 0x7FFE86D2BB10
    }

    public class CVRCompositor : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA1A60
        public void SetTrackingSpace(){} // RVA: 0x7FFE85A7C5E0
        public void GetTrackingSpace(){} // RVA: 0x7FFE84A02160
        public void WaitGetPoses(){} // RVA: 0x7FFE86D2B860
        public void GetLastPoses(){} // RVA: 0x7FFE86D2B8B0
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7FFE86D2A7A0
        public void Submit(){} // RVA: 0x7FFE86D2B900
        public void SubmitWithArrayIndex(){} // RVA: 0x7FFE87BA1C60
        public void ClearLastSubmittedFrame(){} // RVA: 0x7FFE86D2B930
        public void PostPresentHandoff(){} // RVA: 0x7FFE86D2D5A0
        public void GetFrameTiming(){} // RVA: 0x7FFE86D2B960
        public void GetFrameTimings(){} // RVA: 0x7FFE87BA1900
        public void GetFrameTimeRemaining(){} // RVA: 0x7FFE87BA1C90
        public void GetCumulativeStats(){} // RVA: 0x7FFE87BA1CC0
        public void FadeToColor(){} // RVA: 0x7FFE87BA1CF0
        public void GetCurrentFadeColor(){} // RVA: 0x7FFE87BA1D40
        public void FadeGrid(){} // RVA: 0x7FFE86D2D8D0
        public void GetCurrentGridAlpha(){} // RVA: 0x7FFE87BA1D80
        public void SetSkyboxOverride(){} // RVA: 0x7FFE87BA1DB0
        public void ClearSkyboxOverride(){} // RVA: 0x7FFE86D2BAE0
        public void CompositorBringToFront(){} // RVA: 0x7FFE86D2BB10
        public void CompositorGoToBack(){} // RVA: 0x7FFE86D2BB40
        public void CompositorQuit(){} // RVA: 0x7FFE86D2BB70
        public void IsFullscreen(){} // RVA: 0x7FFE86D2BBA0
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7FFE86D2BBD0
        public void GetLastFrameRenderer(){} // RVA: 0x7FFE86D2BC00
        public void CanRenderScene(){} // RVA: 0x7FFE86D2AB10
        public void ShowMirrorWindow(){} // RVA: 0x7FFE86D2BC30
        public void HideMirrorWindow(){} // RVA: 0x7FFE86D2BC60
        public void IsMirrorWindowVisible(){} // RVA: 0x7FFE86D2AC20
        public void CompositorDumpImages(){} // RVA: 0x7FFE86D2BC90
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7FFE86D2AC80
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7FFE87BA1DF0
        public void ForceReconnectProcess(){} // RVA: 0x7FFE87BA1E20
        public void SuspendRendering(){} // RVA: 0x7FFE87BA1E50
        public void GetMirrorTextureD3D11(){} // RVA: 0x7FFE86D2C6D0
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7FFE87BA1E80
        public void GetMirrorTextureGL(){} // RVA: 0x7FFE86D2C730
        public void ReleaseSharedGLTexture(){} // RVA: 0x7FFE87BA1EB0
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7FFE86D2BE50
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7FFE87BA1EE0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7FFE87BA1F10
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7FFE87BA1F40
        public void SetExplicitTimingMode(){} // RVA: 0x7FFE86D2C820
        public void SubmitExplicitTimingData(){} // RVA: 0x7FFE87B9F670
        public void IsMotionSmoothingEnabled(){} // RVA: 0x7FFE87BA1F70
        public void IsMotionSmoothingSupported(){} // RVA: 0x7FFE86D29B70
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x7FFE86D29BA0
        public void SetStageOverride_Async(){} // RVA: 0x7FFE87BA1FA0
        public void ClearStageOverride(){} // RVA: 0x7FFE87BA2090
        public void GetCompositorBenchmarkResults(){} // RVA: 0x7FFE86D2CBA0
        public void GetLastPosePredictionIDs(){} // RVA: 0x7FFE87BA20C0
        public void GetPosesForFrame(){} // RVA: 0x7FFE87BA20F0
    }

    public class CVRDebug : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA72B0
        public void EmitVrProfilerEvent(){} // RVA: 0x7FFE87BA7440
        public void BeginVrProfilerEvent(){} // RVA: 0x7FFE87BA7500
        public void FinishVrProfilerEvent(){} // RVA: 0x7FFE87BA7530
        public void DriverDebugRequest(){} // RVA: 0x7FFE87BA7600
    }

    public class CVRDriverManager : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA60E0
        public void GetDriverCount(){} // RVA: 0x7FFE82001D60
        public void GetDriverName(){} // RVA: 0x7FFE86D2E6E0
        public void GetDriverHandle(){} // RVA: 0x7FFE87BA6270
        public void IsEnabled(){} // RVA: 0x7FFE83FA8560
    }

    public class CVRExtendedDisplay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B9F9E0
        public void GetWindowBounds(){} // RVA: 0x7FFE86D29FF0
        public void GetEyeOutputViewport(){} // RVA: 0x7FFE86D2A030
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFE86D2A080
    }

    public class CVRHeadsetView : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA38C0
        public void SetHeadsetViewSize(){} // RVA: 0x7FFE85CAD640
        public void GetHeadsetViewSize(){} // RVA: 0x7FFE87BA3A80
        public void SetHeadsetViewMode(){} // RVA: 0x7FFE8487FE20
        public void GetHeadsetViewMode(){} // RVA: 0x7FFE848ABA00
        public void SetHeadsetViewCropped(){} // RVA: 0x7FFE865CE920
        public void GetHeadsetViewCropped(){} // RVA: 0x7FFE87BA3AB0
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x7FFE86D289F0
        public void SetHeadsetViewBlendRange(){} // RVA: 0x7FFE85B63750
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7FFE87BA3AE0
    }

    public class CVRIOBuffer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA6DC0
        public void Open(){} // RVA: 0x7FFE87BA6F60
        public void Close(){} // RVA: 0x7FFE81717120
        public void Read(){} // RVA: 0x7FFE86D2EDD0
        public void Write(){} // RVA: 0x7FFE86D2EE10
        public void PropertyContainer(){} // RVA: 0x7FFE865CE920
        public void HasReaders(){} // RVA: 0x7FFE85B63860
    }

    public class CVRInput : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA6330
        public void SetActionManifestPath(){} // RVA: 0x7FFE87BA6520
        public void GetActionSetHandle(){} // RVA: 0x7FFE87BA65E0
        public void GetActionHandle(){} // RVA: 0x7FFE87BA66B0
        public void GetInputSourceHandle(){} // RVA: 0x7FFE87BA6780
        public void UpdateActionState(){} // RVA: 0x7FFE86D2E980
        public void GetDigitalActionData(){} // RVA: 0x7FFE86D2B900
        public void GetAnalogActionData(){} // RVA: 0x7FFE86D2C1A0
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x7FFE86D2E9C0
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7FFE87BA6850
        public void GetSkeletalActionData(){} // RVA: 0x7FFE87BA6880
        public void GetDominantHand(){} // RVA: 0x7FFE85B64520
        public void SetDominantHand(){} // RVA: 0x7FFE86D2B350
        public void GetBoneCount(){} // RVA: 0x7FFE87BA2750
        public void GetBoneHierarchy(){} // RVA: 0x7FFE87BA68B0
        public void GetBoneName(){} // RVA: 0x7FFE87BA68F0
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7FFE87BA6920
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFE86D2C380
        public void GetSkeletalBoneData(){} // RVA: 0x7FFE87BA6970
        public void GetSkeletalSummaryData(){} // RVA: 0x7FFE87BA69C0
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7FFE87BA69F0
        public void DecompressSkeletalBoneData(){} // RVA: 0x7FFE87BA6A30
        public void TriggerHapticVibrationAction(){} // RVA: 0x7FFE87BA6A80
        public void GetActionOrigins(){} // RVA: 0x7FFE87BA6AC0
        public void GetOriginLocalizedName(){} // RVA: 0x7FFE87BA6B00
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7FFE86D28D90
        public void GetActionBindingInfo(){} // RVA: 0x7FFE87BA6B30
        public void ShowActionOrigins(){} // RVA: 0x7FFE86D2C570
        public void ShowBindingsForActionSet(){} // RVA: 0x7FFE87BA6B80
        public void GetComponentStateForBinding(){} // RVA: 0x7FFE87BA6BC0
        public void IsUsingLegacyInput(){} // RVA: 0x7FFE86D2BC90
        public void OpenBindingUI(){} // RVA: 0x7FFE87BA6CD0
        public void GetBindingVariant(){} // RVA: 0x7FFE86D2C670
    }

    public class CVRNotifications : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA49F0
        public void CreateNotification(){} // RVA: 0x7FFE87BA4B80
        public void RemoveNotification(){} // RVA: 0x7FFE81717120
    }

    public class CVROverlay : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA2130
        public void FindOverlay(){} // RVA: 0x7FFE87BA2320
        public void CreateOverlay(){} // RVA: 0x7FFE87BA23F0
        public void DestroyOverlay(){} // RVA: 0x7FFE8487FE20
        public void GetOverlayKey(){} // RVA: 0x7FFE86D2A3A0
        public void GetOverlayName(){} // RVA: 0x7FFE87BA24F0
        public void SetOverlayName(){} // RVA: 0x7FFE87BA2520
        public void GetOverlayImageData(){} // RVA: 0x7FFE87BA25F0
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7FFE87BA2640
        public void SetOverlayRenderingPid(){} // RVA: 0x7FFE86D2A840
        public void GetOverlayRenderingPid(){} // RVA: 0x7FFE86D2A870
        public void SetOverlayFlag(){} // RVA: 0x7FFE87BA26F0
        public void GetOverlayFlag(){} // RVA: 0x7FFE87BA2720
        public void GetOverlayFlags(){} // RVA: 0x7FFE87BA2750
        public void SetOverlayColor(){} // RVA: 0x7FFE87BA2780
        public void GetOverlayColor(){} // RVA: 0x7FFE87BA27B0
        public void SetOverlayAlpha(){} // RVA: 0x7FFE86D2D8D0
        public void GetOverlayAlpha(){} // RVA: 0x7FFE87BA27F0
        public void SetOverlayTexelAspect(){} // RVA: 0x7FFE86D2AA20
        public void GetOverlayTexelAspect(){} // RVA: 0x7FFE87BA2820
        public void SetOverlaySortOrder(){} // RVA: 0x7FFE86D2AA50
        public void GetOverlaySortOrder(){} // RVA: 0x7FFE87BA2850
        public void SetOverlayWidthInMeters(){} // RVA: 0x7FFE87BA2880
        public void GetOverlayWidthInMeters(){} // RVA: 0x7FFE87BA28B0
        public void SetOverlayCurvature(){} // RVA: 0x7FFE87BA28E0
        public void GetOverlayCurvature(){} // RVA: 0x7FFE87BA2910
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7FFE87BA2940
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7FFE87BA2970
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7FFE86D2C5A0
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7FFE86D2C5D0
        public void SetOverlayTextureBounds(){} // RVA: 0x7FFE86D2C600
        public void GetOverlayTextureBounds(){} // RVA: 0x7FFE87BA29A0
        public void GetOverlayTransformType(){} // RVA: 0x7FFE87BA29D0
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7FFE87BA2A00
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7FFE86D2BD50
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFE86D2C6D0
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFE86D2BDB0
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFE87BA2A30
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFE87BA2B10
        public void SetOverlayTransformCursor(){} // RVA: 0x7FFE87BA2B50
        public void GetOverlayTransformCursor(){} // RVA: 0x7FFE86D2BE80
        public void SetOverlayTransformProjection(){} // RVA: 0x7FFE87BA2B80
        public void ShowOverlay(){} // RVA: 0x7FFE86D2BEE0
        public void HideOverlay(){} // RVA: 0x7FFE86D2C820
        public void IsOverlayVisible(){} // RVA: 0x7FFE86D2C850
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7FFE86D2C880
        public void WaitFrameSync(){} // RVA: 0x7FFE87BA2BC0
        public void PollNextOverlayEvent(){} // RVA: 0x7FFE87BA2BF0
        public void GetOverlayInputMethod(){} // RVA: 0x7FFE86D2CB40
        public void SetOverlayInputMethod(){} // RVA: 0x7FFE86D2CB70
        public void GetOverlayMouseScale(){} // RVA: 0x7FFE86D2CBA0
        public void SetOverlayMouseScale(){} // RVA: 0x7FFE87BA2E50
        public void ComputeOverlayIntersection(){} // RVA: 0x7FFE87BA2E80
        public void IsHoverTargetOverlay(){} // RVA: 0x7FFE87BA2EB0
        public void SetOverlayIntersectionMask(){} // RVA: 0x7FFE87BA2EE0
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7FFE87BA2F10
        public void SetOverlayCursor(){} // RVA: 0x7FFE86D2CCC0
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7FFE87BA2F40
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x7FFE87BA2F70
        public void SetOverlayTexture(){} // RVA: 0x7FFE86D2CD60
        public void ClearOverlayTexture(){} // RVA: 0x7FFE86D2CD90
        public void SetOverlayRaw(){} // RVA: 0x7FFE86D2CDC0
        public void SetOverlayFromFile(){} // RVA: 0x7FFE87BA2FA0
        public void GetOverlayTexture(){} // RVA: 0x7FFE86D2CE30
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7FFE86D2CE90
        public void GetOverlayTextureSize(){} // RVA: 0x7FFE86D2CEC0
        public void CreateDashboardOverlay(){} // RVA: 0x7FFE87BA3070
        public void IsDashboardVisible(){} // RVA: 0x7FFE86D2CF40
        public void IsActiveDashboardOverlay(){} // RVA: 0x7FFE86D2CF70
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7FFE86D2CFA0
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7FFE86D2CFD0
        public void ShowDashboard(){} // RVA: 0x7FFE87BA3180
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7FFE86D2D030
        public void ShowKeyboard(){} // RVA: 0x7FFE87BA3240
        public void ShowKeyboardForOverlay(){} // RVA: 0x7FFE87BA3370
        public void GetKeyboardText(){} // RVA: 0x7FFE86D2D0E0
        public void HideKeyboard(){} // RVA: 0x7FFE86D2D110
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7FFE86D2D140
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7FFE86D2D170
        public void ShowMessageOverlay(){} // RVA: 0x7FFE87BA34B0
        public void CloseMessageOverlay(){} // RVA: 0x7FFE87BA3630
    }

    public class CVROverlayView : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA3730
        public void AcquireOverlayView(){} // RVA: 0x7FFE871D4DB0
        public void ReleaseOverlayView(){} // RVA: 0x7FFE81717120
        public void PostOverlayEvent(){} // RVA: 0x7FFE865CE950
        public void IsViewingPermitted(){} // RVA: 0x7FFE83FA8560
    }

    public class CVRPaths : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA7920
        public void ReadPathBatch(){} // RVA: 0x7FFE86D2E4E0
        public void WritePathBatch(){} // RVA: 0x7FFE86D2E6E0
        public void StringToHandle(){} // RVA: 0x7FFE87BA7AB0
        public void HandleToString(){} // RVA: 0x7FFE87BA7B80
    }

    public class CVRProperties : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA76E0
        public void ReadPropertyBatch(){} // RVA: 0x7FFE86D2E4E0
        public void WritePropertyBatch(){} // RVA: 0x7FFE86D2E6E0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFE87BA7870
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x7FFE83FA8560
    }

    public class CVRPropertyHelpers : ValueType
    {
    }

    public class CVRRenderModels : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA3B10
        public void LoadRenderModel_Async(){} // RVA: 0x7FFE87BA3D00
        public void FreeRenderModel(){} // RVA: 0x7FFE81717120
        public void LoadTexture_Async(){} // RVA: 0x7FFE865CE950
        public void FreeTexture(){} // RVA: 0x7FFE83FA8560
        public void LoadTextureD3D11_Async(){} // RVA: 0x7FFE86D2A7A0
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7FFE86D2D540
        public void FreeTextureD3D11(){} // RVA: 0x7FFE86D2A430
        public void GetRenderModelName(){} // RVA: 0x7FFE86D2D570
        public void GetRenderModelCount(){} // RVA: 0x7FFE86D2D5A0
        public void GetComponentCount(){} // RVA: 0x7FFE87BA3DD0
        public void GetComponentName(){} // RVA: 0x7FFE87BA3E90
        public void GetComponentButtonMask(){} // RVA: 0x7FFE87BA3F70
        public void GetComponentRenderModelName(){} // RVA: 0x7FFE87BA4050
        public void GetComponentStateForDevicePath(){} // RVA: 0x7FFE87BA4150
        public void GetComponentState(){} // RVA: 0x7FFE87BA4260
        public void RenderModelHasComponent(){} // RVA: 0x7FFE87BA4560
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7FFE87BA4640
        public void GetRenderModelOriginalPath(){} // RVA: 0x7FFE87BA4730
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7FFE87BA4820
    }

    public class CVRResources : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA5D70
        public void LoadSharedResource(){} // RVA: 0x7FFE87BA5F00
        public void GetResourceFullPath(){} // RVA: 0x7FFE87BA5FE0
    }

    public class CVRScreenshots : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA58B0
        public void RequestScreenshot(){} // RVA: 0x7FFE87BA5A60
        public void HookScreenshot(){} // RVA: 0x7FFE86D2E280
        public void GetScreenshotPropertyType(){} // RVA: 0x7FFE865CE950
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7FFE86D2E2B0
        public void UpdateScreenshotProgress(){} // RVA: 0x7FFE86D2E2E0
        public void TakeStereoScreenshot(){} // RVA: 0x7FFE87BA5B70
        public void SubmitScreenshot(){} // RVA: 0x7FFE87BA5C70
    }

    public class CVRSettingHelper : ValueType
    {
    }

    public class CVRSettings : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA4CA0
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7FFE87BA4E60
        public void SetBool(){} // RVA: 0x7FFE87BA4F10
        public void SetInt32(){} // RVA: 0x7FFE87BA5010
        public void SetFloat(){} // RVA: 0x7FFE87BA5110
        public void SetString(){} // RVA: 0x7FFE87BA5210
        public void GetBool(){} // RVA: 0x7FFE87BA5320
        public void GetInt32(){} // RVA: 0x7FFE87BA5410
        public void GetFloat(){} // RVA: 0x7FFE87BA5500
        public void GetString(){} // RVA: 0x7FFE87BA5600
        public void RemoveSection(){} // RVA: 0x7FFE87BA5700
        public void RemoveKeyInSection(){} // RVA: 0x7FFE87BA57C0
    }

    public class CVRSpatialAnchors : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BA7050
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7FFE87BA71E0
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7FFE86D2F000
        public void GetSpatialAnchorPose(){} // RVA: 0x7FFE86D2F040
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7FFE86D2F070
    }

    public class CVRSystem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B9E6F0
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7FFE86D28850
        public void GetProjectionMatrix(){} // RVA: 0x7FFE86D28880
        public void GetProjectionRaw(){} // RVA: 0x7FFE86D288F0
        public void ComputeDistortion(){} // RVA: 0x7FFE86D28940
        public void GetEyeToHeadTransform(){} // RVA: 0x7FFE86D28970
        public void GetTimeSinceLastVsync(){} // RVA: 0x7FFE86D289C0
        public void GetD3D9AdapterIndex(){} // RVA: 0x7FFE86D289F0
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFE86D28A20
        public void GetOutputDevice(){} // RVA: 0x7FFE86D28A50
        public void IsDisplayOnDesktop(){} // RVA: 0x7FFE86D28A90
        public void SetDisplayVisibility(){} // RVA: 0x7FFE85B64520
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7FFE86D28AC0
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFE87B9E910
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFE86D28B30
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7FFE87B9E960
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7FFE87B9E9A0
        public void ApplyTransform(){} // RVA: 0x7FFE86D2A9F0
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7FFE87B9E9D0
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7FFE86D28C70
        public void GetTrackedDeviceClass(){} // RVA: 0x7FFE86D28CA0
        public void IsTrackedDeviceConnected(){} // RVA: 0x7FFE86D28CD0
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7FFE86D2AAB0
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7FFE86D28D30
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7FFE86D28D60
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7FFE86D28D90
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7FFE87B9EA00
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7FFE87B9EA60
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7FFE87B9EAA0
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFE87B9EAE0
        public void PollNextEvent(){} // RVA: 0x7FFE87B9EB90
        public void PollNextEventWithPose(){} // RVA: 0x7FFE87B9EDE0
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7FFE87B9EE10
        public void GetHiddenAreaMesh(){} // RVA: 0x7FFE87B9EEC0
        public void GetControllerState(){} // RVA: 0x7FFE87B9EF10
        public void GetControllerStateWithPose(){} // RVA: 0x7FFE87B9F1E0
        public void TriggerHapticPulse(){} // RVA: 0x7FFE86D2C700
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7FFE87B9F4E0
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7FFE87B9F590
        public void IsInputAvailable(){} // RVA: 0x7FFE87B9F640
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7FFE86D29A50
        public void ShouldApplicationPause(){} // RVA: 0x7FFE86D29A80
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7FFE86D29AB0
        public void PerformFirmwareUpdate(){} // RVA: 0x7FFE86D2C820
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7FFE87B9F670
        public void GetAppContainerFilePaths(){} // RVA: 0x7FFE87B9F6A0
        public void GetRuntimeVersion(){} // RVA: 0x7FFE87B9F6D0
    }

    public class CVRTrackedCamera : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87B9FB80
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7FFE87B9FD40
        public void HasCamera(){} // RVA: 0x7FFE86D2A320
        public void GetCameraFrameSize(){} // RVA: 0x7FFE86D2A350
        public void GetCameraIntrinsics(){} // RVA: 0x7FFE86D2E2B0
        public void GetCameraProjection(){} // RVA: 0x7FFE87B9FDF0
        public void AcquireVideoStreamingService(){} // RVA: 0x7FFE86D2A400
        public void ReleaseVideoStreamingService(){} // RVA: 0x7FFE86D2A430
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7FFE86D2A460
        public void GetVideoStreamTextureSize(){} // RVA: 0x7FFE86D2A490
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7FFE86D2A4E0
        public void GetVideoStreamTextureGL(){} // RVA: 0x7FFE86D2A510
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7FFE86D2A550
        public void SetCameraTrackingSpace(){} // RVA: 0x7FFE86D2A8A0
        public void GetCameraTrackingSpace(){} // RVA: 0x7FFE87B9FE20
    }

    public class CameraVideoStreamFrameHeader_t : ValueType
    {
    }

    public class Compositor_BenchmarkResults : ValueType
    {
    }

    public class Compositor_CumulativeStats : ValueType
    {
    }

    public class Compositor_FrameTiming : ValueType
    {
    }

    public class Compositor_StageRenderSettings : ValueType
    {
    }

}