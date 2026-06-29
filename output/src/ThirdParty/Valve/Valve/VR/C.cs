// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 23
// Methods: 398

namespace ThirdParty.Valve.Valve.VR
{
    public class CVRApplications : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC0AF0
        public void AddApplicationManifest(){} // RVA: 0x7AC0CD0
        public void RemoveApplicationManifest(){} // RVA: 0x7AC0DA0
        public void IsApplicationInstalled(){} // RVA: 0x7AC0E60
        public void GetApplicationCount(){} // RVA: 0x46BE380
        public void GetApplicationKeyByIndex(){} // RVA: 0x6C58B10
        public void GetApplicationKeyByProcessId(){} // RVA: 0x6C58B40
        public void LaunchApplication(){} // RVA: 0x7AC0F20
        public void LaunchTemplateApplication(){} // RVA: 0x7AC0FE0
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7AC10E0
        public void LaunchDashboardOverlay(){} // RVA: 0x7AC11C0
        public void CancelApplicationLaunch(){} // RVA: 0x7AC1280
        public void IdentifyApplication(){} // RVA: 0x7AC1340
        public void GetApplicationProcessId(){} // RVA: 0x7AC1400
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7AC14C0
        public void GetApplicationPropertyString(){} // RVA: 0x7AC1570
        public void GetApplicationPropertyBool(){} // RVA: 0x7AC1660
        public void GetApplicationPropertyUint64(){} // RVA: 0x7AC1740
        public void SetApplicationAutoLaunch(){} // RVA: 0x7AC1820
        public void GetApplicationAutoLaunch(){} // RVA: 0x7AC18F0
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7AC19B0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7AC1A90
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7AC1B70
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7AC1C50
        public void GetApplicationLaunchArguments(){} // RVA: 0x6C57120
        public void GetStartingApplication(){} // RVA: 0x6C58E50
        public void GetSceneApplicationState(){} // RVA: 0x6C58E80
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7AC1D30
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x7AC1DF0
        public void LaunchInternalProcess(){} // RVA: 0x7AC1EA0
        public void GetCurrentSceneProcessId(){} // RVA: 0x6C59F60
    }

    public class CVRBlockQueue : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC8470
        public void Create(){} // RVA: 0x7AC85F0
        public void Connect(){} // RVA: 0x7AC86F0
        public void Destroy(){} // RVA: 0x46849E0
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7AC87C0
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x6C5C4B0
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x7AC8800
        public void AcquireReadOnlyBlock(){} // RVA: 0x7AC8840
        public void ReleaseReadOnlyBlock(){} // RVA: 0x5951730
        public void QueueHasReader(){} // RVA: 0x7AC8880
    }

    public class CVRChaperone : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC1FB0
        public void GetCalibrationState(){} // RVA: 0x1B68170
        public void GetPlayAreaSize(){} // RVA: 0x6C59190
        public void GetPlayAreaRect(){} // RVA: 0x46849E0
        public void ReloadInfo(){} // RVA: 0x46BE380
        public void SetSceneColor(){} // RVA: 0x6C591C0
        public void GetBoundsColor(){} // RVA: 0x6C59200
        public void AreBoundsVisible(){} // RVA: 0x6C56DB0
        public void ForceBoundsVisible(){} // RVA: 0x6C59230
        public void ResetZeroPose(){} // RVA: 0x7AC2130
    }

    public class CVRChaperoneSetup : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC2160
        public void CommitWorkingCopy(){} // RVA: 0x31D2090
        public void RevertWorkingCopy(){} // RVA: 0x47FD7F0
        public void GetWorkingPlayAreaSize(){} // RVA: 0x6C59420
        public void GetWorkingPlayAreaRect(){} // RVA: 0x3DDB1D0
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7AC2320
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7AC2410
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x6C587E0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x6C59230
        public void SetWorkingPlayAreaSize(){} // RVA: 0x6C58BB0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x6C59630
        public void SetWorkingPerimeter(){} // RVA: 0x7AC2500
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x6C59660
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x6C58C10
        public void ReloadFromDisk(){} // RVA: 0x6C59690
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7AC2530
        public void ExportLiveToBuffer(){} // RVA: 0x7AC2560
        public void ImportFromBufferToWorking(){} // RVA: 0x7AC2590
        public void ShowWorkingSetPreview(){} // RVA: 0x6C59D80
        public void HideWorkingSetPreview(){} // RVA: 0x6C59DB0
        public void RoomSetupStarting(){} // RVA: 0x6C59DE0
    }

    public class CVRCompositor : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC2660
        public void SetTrackingSpace(){} // RVA: 0x31D2090
        public void GetTrackingSpace(){} // RVA: 0x47FD7F0
        public void WaitGetPoses(){} // RVA: 0x6C59B30
        public void GetLastPoses(){} // RVA: 0x6C59B80
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x6C58B10
        public void Submit(){} // RVA: 0x6C59BD0
        public void SubmitWithArrayIndex(){} // RVA: 0x7AC2820
        public void ClearLastSubmittedFrame(){} // RVA: 0x6C59C00
        public void PostPresentHandoff(){} // RVA: 0x6C5B810
        public void GetFrameTiming(){} // RVA: 0x6C59C30
        public void GetFrameTimings(){} // RVA: 0x7AC2500
        public void GetFrameTimeRemaining(){} // RVA: 0x7AC2850
        public void GetCumulativeStats(){} // RVA: 0x7AC2880
        public void FadeToColor(){} // RVA: 0x7AC28B0
        public void GetCurrentFadeColor(){} // RVA: 0x7AC2900
        public void FadeGrid(){} // RVA: 0x6C5BB60
        public void GetCurrentGridAlpha(){} // RVA: 0x7AC2940
        public void SetSkyboxOverride(){} // RVA: 0x7AC2970
        public void ClearSkyboxOverride(){} // RVA: 0x6C59DB0
        public void CompositorBringToFront(){} // RVA: 0x6C59DE0
        public void CompositorGoToBack(){} // RVA: 0x6C59E10
        public void CompositorQuit(){} // RVA: 0x6C59E40
        public void IsFullscreen(){} // RVA: 0x6C59E70
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x6C59EA0
        public void GetLastFrameRenderer(){} // RVA: 0x6C59ED0
        public void CanRenderScene(){} // RVA: 0x6C58E80
        public void ShowMirrorWindow(){} // RVA: 0x6C59F00
        public void HideMirrorWindow(){} // RVA: 0x6C59F30
        public void IsMirrorWindowVisible(){} // RVA: 0x6C58F90
        public void CompositorDumpImages(){} // RVA: 0x6C59F60
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x6C58FF0
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7AC29B0
        public void ForceReconnectProcess(){} // RVA: 0x7AC29E0
        public void SuspendRendering(){} // RVA: 0x7AC2A10
        public void GetMirrorTextureD3D11(){} // RVA: 0x6C5A960
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7AC2A40
        public void GetMirrorTextureGL(){} // RVA: 0x6C5A9C0
        public void ReleaseSharedGLTexture(){} // RVA: 0x7AC2A70
        public void LockGLSharedTextureForAccess(){} // RVA: 0x6C5A120
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7AC2AA0
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7AC2AD0
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7AC2B00
        public void SetExplicitTimingMode(){} // RVA: 0x6C5AAB0
        public void SubmitExplicitTimingData(){} // RVA: 0x7AC03B0
        public void IsMotionSmoothingEnabled(){} // RVA: 0x7AC2B30
        public void IsMotionSmoothingSupported(){} // RVA: 0x6C57FD0
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x6C58000
        public void SetStageOverride_Async(){} // RVA: 0x7AC2B60
        public void ClearStageOverride(){} // RVA: 0x7AC2C50
        public void GetCompositorBenchmarkResults(){} // RVA: 0x6C5AE60
        public void GetLastPosePredictionIDs(){} // RVA: 0x7AC2C80
        public void GetPosesForFrame(){} // RVA: 0x7AC2CB0
    }

    public class CVRDebug : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC7BF0
        public void EmitVrProfilerEvent(){} // RVA: 0x7AC7D50
        public void BeginVrProfilerEvent(){} // RVA: 0x7AC7E10
        public void FinishVrProfilerEvent(){} // RVA: 0x7AC7E40
        public void DriverDebugRequest(){} // RVA: 0x7AC7F10
    }

    public class CVRDriverManager : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC6B00
        public void GetDriverCount(){} // RVA: 0x1B68170
        public void GetDriverName(){} // RVA: 0x6C5C830
        public void GetDriverHandle(){} // RVA: 0x7AC6C60
        public void IsEnabled(){} // RVA: 0x3DDB1D0
    }

    public class CVRExtendedDisplay : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC06F0
        public void GetWindowBounds(){} // RVA: 0x6C583E0
        public void GetEyeOutputViewport(){} // RVA: 0x6C58420
        public void GetDXGIOutputInfo(){} // RVA: 0x6C58470
    }

    public class CVRHeadsetView : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC4440
        public void SetHeadsetViewSize(){} // RVA: 0x5DC7240
        public void GetHeadsetViewSize(){} // RVA: 0x7AC45C0
        public void SetHeadsetViewMode(){} // RVA: 0x46849E0
        public void GetHeadsetViewMode(){} // RVA: 0x46BE380
        public void SetHeadsetViewCropped(){} // RVA: 0x6507E80
        public void GetHeadsetViewCropped(){} // RVA: 0x7AC45F0
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x6C56DB0
        public void SetHeadsetViewBlendRange(){} // RVA: 0x5951730
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7AC4620
    }

    public class CVRIOBuffer : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC7770
        public void Open(){} // RVA: 0x7AC78D0
        public void Close(){} // RVA: 0x12751C0
        public void Read(){} // RVA: 0x6C5CEA0
        public void Write(){} // RVA: 0x6C5CEE0
        public void PropertyContainer(){} // RVA: 0x6507E80
        public void HasReaders(){} // RVA: 0x5951A60
    }

    public class CVRInput : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC6D20
        public void SetActionManifestPath(){} // RVA: 0x7AC6ED0
        public void GetActionSetHandle(){} // RVA: 0x7AC6F90
        public void GetActionHandle(){} // RVA: 0x7AC7060
        public void GetInputSourceHandle(){} // RVA: 0x7AC7130
        public void UpdateActionState(){} // RVA: 0x6C5CAA0
        public void GetDigitalActionData(){} // RVA: 0x6C59BD0
        public void GetAnalogActionData(){} // RVA: 0x6C5A430
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x6C5CAE0
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7AC7200
        public void GetSkeletalActionData(){} // RVA: 0x7AC7230
        public void GetDominantHand(){} // RVA: 0x5951980
        public void SetDominantHand(){} // RVA: 0x6C59660
        public void GetBoneCount(){} // RVA: 0x7AC32D0
        public void GetBoneHierarchy(){} // RVA: 0x7AC7260
        public void GetBoneName(){} // RVA: 0x7AC72A0
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7AC72D0
        public void GetSkeletalTrackingLevel(){} // RVA: 0x6C5A610
        public void GetSkeletalBoneData(){} // RVA: 0x7AC7320
        public void GetSkeletalSummaryData(){} // RVA: 0x7AC7370
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7AC73A0
        public void DecompressSkeletalBoneData(){} // RVA: 0x7AC73E0
        public void TriggerHapticVibrationAction(){} // RVA: 0x7AC7430
        public void GetActionOrigins(){} // RVA: 0x7AC7470
        public void GetOriginLocalizedName(){} // RVA: 0x7AC74B0
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x6C57150
        public void GetActionBindingInfo(){} // RVA: 0x7AC74E0
        public void ShowActionOrigins(){} // RVA: 0x6C5A800
        public void ShowBindingsForActionSet(){} // RVA: 0x7AC7530
        public void GetComponentStateForBinding(){} // RVA: 0x7AC7570
        public void IsUsingLegacyInput(){} // RVA: 0x6C59F60
        public void OpenBindingUI(){} // RVA: 0x7AC7680
        public void GetBindingVariant(){} // RVA: 0x6C5A900
    }

    public class CVRNotifications : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC5500
        public void CreateNotification(){} // RVA: 0x7AC5650
        public void RemoveNotification(){} // RVA: 0x12751C0
    }

    public class CVROverlay : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC2CF0
        public void FindOverlay(){} // RVA: 0x7AC2EA0
        public void CreateOverlay(){} // RVA: 0x7AC2F70
        public void DestroyOverlay(){} // RVA: 0x46849E0
        public void GetOverlayKey(){} // RVA: 0x6C58750
        public void GetOverlayName(){} // RVA: 0x7AC3070
        public void SetOverlayName(){} // RVA: 0x7AC30A0
        public void GetOverlayImageData(){} // RVA: 0x7AC3170
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7AC31C0
        public void SetOverlayRenderingPid(){} // RVA: 0x6C58BB0
        public void GetOverlayRenderingPid(){} // RVA: 0x6C58BE0
        public void SetOverlayFlag(){} // RVA: 0x7AC3270
        public void GetOverlayFlag(){} // RVA: 0x7AC32A0
        public void GetOverlayFlags(){} // RVA: 0x7AC32D0
        public void SetOverlayColor(){} // RVA: 0x7AC3300
        public void GetOverlayColor(){} // RVA: 0x7AC3330
        public void SetOverlayAlpha(){} // RVA: 0x6C5BB60
        public void GetOverlayAlpha(){} // RVA: 0x7AC3370
        public void SetOverlayTexelAspect(){} // RVA: 0x6C58D90
        public void GetOverlayTexelAspect(){} // RVA: 0x7AC33A0
        public void SetOverlaySortOrder(){} // RVA: 0x6C58DC0
        public void GetOverlaySortOrder(){} // RVA: 0x7AC33D0
        public void SetOverlayWidthInMeters(){} // RVA: 0x7AC3400
        public void GetOverlayWidthInMeters(){} // RVA: 0x7AC3430
        public void SetOverlayCurvature(){} // RVA: 0x7AC3460
        public void GetOverlayCurvature(){} // RVA: 0x7AC3490
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7AC34C0
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7AC34F0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x6C5A830
        public void GetOverlayTextureColorSpace(){} // RVA: 0x6C5A860
        public void SetOverlayTextureBounds(){} // RVA: 0x6C5A890
        public void GetOverlayTextureBounds(){} // RVA: 0x7AC3520
        public void GetOverlayTransformType(){} // RVA: 0x7AC3550
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7AC3580
        public void GetOverlayTransformAbsolute(){} // RVA: 0x6C5A020
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x6C5A960
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x6C5A080
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7AC35B0
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7AC3690
        public void SetOverlayTransformCursor(){} // RVA: 0x7AC36D0
        public void GetOverlayTransformCursor(){} // RVA: 0x6C5A150
        public void SetOverlayTransformProjection(){} // RVA: 0x7AC3700
        public void ShowOverlay(){} // RVA: 0x6C5A1B0
        public void HideOverlay(){} // RVA: 0x6C5AAB0
        public void IsOverlayVisible(){} // RVA: 0x6C5AAE0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x6C5AB10
        public void WaitFrameSync(){} // RVA: 0x7AC3740
        public void PollNextOverlayEvent(){} // RVA: 0x7AC3770
        public void GetOverlayInputMethod(){} // RVA: 0x6C5AE00
        public void SetOverlayInputMethod(){} // RVA: 0x6C5AE30
        public void GetOverlayMouseScale(){} // RVA: 0x6C5AE60
        public void SetOverlayMouseScale(){} // RVA: 0x7AC3A20
        public void ComputeOverlayIntersection(){} // RVA: 0x7AC3A50
        public void IsHoverTargetOverlay(){} // RVA: 0x7AC3A80
        public void SetOverlayIntersectionMask(){} // RVA: 0x7AC3AB0
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7AC3AE0
        public void SetOverlayCursor(){} // RVA: 0x6C5AF80
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7AC3B10
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x7AC3B40
        public void SetOverlayTexture(){} // RVA: 0x6C5B020
        public void ClearOverlayTexture(){} // RVA: 0x6C5B050
        public void SetOverlayRaw(){} // RVA: 0x6C5B080
        public void SetOverlayFromFile(){} // RVA: 0x7AC3B70
        public void GetOverlayTexture(){} // RVA: 0x6C5B0F0
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x6C5B150
        public void GetOverlayTextureSize(){} // RVA: 0x6C5B180
        public void CreateDashboardOverlay(){} // RVA: 0x7AC3C40
        public void IsDashboardVisible(){} // RVA: 0x6C5B200
        public void IsActiveDashboardOverlay(){} // RVA: 0x6C5B230
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x6C5B260
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x6C5B290
        public void ShowDashboard(){} // RVA: 0x7AC3D50
        public void GetPrimaryDashboardDevice(){} // RVA: 0x6C5B2F0
        public void ShowKeyboard(){} // RVA: 0x7AC3E10
        public void ShowKeyboardForOverlay(){} // RVA: 0x7AC3F40
        public void GetKeyboardText(){} // RVA: 0x6C5B3A0
        public void HideKeyboard(){} // RVA: 0x6C5B3D0
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x6C5B400
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x6C5B430
        public void ShowMessageOverlay(){} // RVA: 0x7AC4080
        public void CloseMessageOverlay(){} // RVA: 0x7AC4200
    }

    public class CVROverlayView : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC42E0
        public void AcquireOverlayView(){} // RVA: 0x7100410
        public void ReleaseOverlayView(){} // RVA: 0x12751C0
        public void PostOverlayEvent(){} // RVA: 0x6507EB0
        public void IsViewingPermitted(){} // RVA: 0x3DDB1D0
    }

    public class CVRPaths : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC8200
        public void ReadPathBatch(){} // RVA: 0x6C5C670
        public void WritePathBatch(){} // RVA: 0x6C5C830
        public void StringToHandle(){} // RVA: 0x7AC8360
        public void HandleToString(){} // RVA: 0x7AC8430
    }

    public class CVRProperties : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC7FF0
        public void ReadPropertyBatch(){} // RVA: 0x6C5C670
        public void WritePropertyBatch(){} // RVA: 0x6C5C830
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7AC8150
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x3DDB1D0
    }

    public class CVRRenderModels : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC4650
        public void LoadRenderModel_Async(){} // RVA: 0x7AC4810
        public void FreeRenderModel(){} // RVA: 0x12751C0
        public void LoadTexture_Async(){} // RVA: 0x6507EB0
        public void FreeTexture(){} // RVA: 0x3DDB1D0
        public void LoadTextureD3D11_Async(){} // RVA: 0x6C58B10
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x6C5B7B0
        public void FreeTextureD3D11(){} // RVA: 0x6C587E0
        public void GetRenderModelName(){} // RVA: 0x6C5B7E0
        public void GetRenderModelCount(){} // RVA: 0x6C5B810
        public void GetComponentCount(){} // RVA: 0x7AC48E0
        public void GetComponentName(){} // RVA: 0x7AC49A0
        public void GetComponentButtonMask(){} // RVA: 0x7AC4A80
        public void GetComponentRenderModelName(){} // RVA: 0x7AC4B60
        public void GetComponentStateForDevicePath(){} // RVA: 0x7AC4C60
        public void GetComponentState(){} // RVA: 0x7AC4D70
        public void RenderModelHasComponent(){} // RVA: 0x7AC5090
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7AC5170
        public void GetRenderModelOriginalPath(){} // RVA: 0x7AC5260
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7AC5350
    }

    public class CVRResources : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC67D0
        public void LoadSharedResource(){} // RVA: 0x7AC6920
        public void GetResourceFullPath(){} // RVA: 0x7AC6A00
    }

    public class CVRScreenshots : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC6350
        public void RequestScreenshot(){} // RVA: 0x7AC64C0
        public void HookScreenshot(){} // RVA: 0x6C5C450
        public void GetScreenshotPropertyType(){} // RVA: 0x6507EB0
        public void GetScreenshotPropertyFilename(){} // RVA: 0x6C5C480
        public void UpdateScreenshotProgress(){} // RVA: 0x6C5C4B0
        public void TakeStereoScreenshot(){} // RVA: 0x7AC65D0
        public void SubmitScreenshot(){} // RVA: 0x7AC66D0
    }

    public class CVRSettings : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC5770
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7AC5900
        public void SetBool(){} // RVA: 0x7AC59B0
        public void SetInt32(){} // RVA: 0x7AC5AB0
        public void SetFloat(){} // RVA: 0x7AC5BB0
        public void SetString(){} // RVA: 0x7AC5CB0
        public void GetBool(){} // RVA: 0x7AC5DC0
        public void GetInt32(){} // RVA: 0x7AC5EB0
        public void GetFloat(){} // RVA: 0x7AC5FA0
        public void GetString(){} // RVA: 0x7AC60A0
        public void RemoveSection(){} // RVA: 0x7AC61A0
        public void RemoveKeyInSection(){} // RVA: 0x7AC6260
    }

    public class CVRSpatialAnchors : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC79C0
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7AC7B20
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x6C5D0A0
        public void GetSpatialAnchorPose(){} // RVA: 0x6C5D0E0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x6C5D110
    }

    public class CVRSystem : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ABF3C0
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x6C56C10
        public void GetProjectionMatrix(){} // RVA: 0x6C56C40
        public void GetProjectionRaw(){} // RVA: 0x6C56CB0
        public void ComputeDistortion(){} // RVA: 0x6C56D00
        public void GetEyeToHeadTransform(){} // RVA: 0x6C56D30
        public void GetTimeSinceLastVsync(){} // RVA: 0x6C56D80
        public void GetD3D9AdapterIndex(){} // RVA: 0x6C56DB0
        public void GetDXGIOutputInfo(){} // RVA: 0x6C56DE0
        public void GetOutputDevice(){} // RVA: 0x6C56E10
        public void IsDisplayOnDesktop(){} // RVA: 0x6C56E50
        public void SetDisplayVisibility(){} // RVA: 0x5951980
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x6C56E80
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7ABF5A0
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x6C56EF0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7ABF5F0
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7ABF630
        public void ApplyTransform(){} // RVA: 0x6C58D60
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7ABF660
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x6C57030
        public void GetTrackedDeviceClass(){} // RVA: 0x6C57060
        public void IsTrackedDeviceConnected(){} // RVA: 0x6C57090
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x6C58E20
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x6C570F0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x6C57120
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x6C57150
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7ABF690
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7ABF6F0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7ABF730
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7ABF770
        public void PollNextEvent(){} // RVA: 0x7ABF820
        public void PollNextEventWithPose(){} // RVA: 0x7ABFAB0
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7ABFAE0
        public void GetHiddenAreaMesh(){} // RVA: 0x7ABFB90
        public void GetControllerState(){} // RVA: 0x7ABFBE0
        public void GetControllerStateWithPose(){} // RVA: 0x7ABFEF0
        public void TriggerHapticPulse(){} // RVA: 0x6C5A990
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7AC0220
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7AC02D0
        public void IsInputAvailable(){} // RVA: 0x7AC0380
        public void IsSteamVRDrawingControllers(){} // RVA: 0x6C57EB0
        public void ShouldApplicationPause(){} // RVA: 0x6C57EE0
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x6C57F10
        public void PerformFirmwareUpdate(){} // RVA: 0x6C5AAB0
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7AC03B0
        public void GetAppContainerFilePaths(){} // RVA: 0x7AC03E0
        public void GetRuntimeVersion(){} // RVA: 0x7AC0410
    }

    public class CVRTrackedCamera : Object
    {
        public object FnTable;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AC0850
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7AC09E0
        public void HasCamera(){} // RVA: 0x6C586D0
        public void GetCameraFrameSize(){} // RVA: 0x6C58700
        public void GetCameraIntrinsics(){} // RVA: 0x6C5C480
        public void GetCameraProjection(){} // RVA: 0x7AC0A90
        public void AcquireVideoStreamingService(){} // RVA: 0x6C587B0
        public void ReleaseVideoStreamingService(){} // RVA: 0x6C587E0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x6C58810
        public void GetVideoStreamTextureSize(){} // RVA: 0x6C58840
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x6C58890
        public void GetVideoStreamTextureGL(){} // RVA: 0x6C588C0
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x6C58900
        public void SetCameraTrackingSpace(){} // RVA: 0x6C58C10
        public void GetCameraTrackingSpace(){} // RVA: 0x7AC0AC0
    }

}