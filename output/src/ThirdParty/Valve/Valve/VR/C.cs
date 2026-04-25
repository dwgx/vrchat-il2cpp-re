// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 31
// Methods: 398

namespace ThirdParty.Valve.Valve.VR
{
    public class COpenVRContext : ValueType
    {
        public UIntPtr m_pVRSystem; // 0x10
        public UIntPtr m_pVRChaperone; // 0x18
        public UIntPtr m_pVRChaperoneSetup; // 0x20
        public UIntPtr m_pVRCompositor; // 0x28
        public UIntPtr m_pVRHeadsetView; // 0x30
        public UIntPtr m_pVROverlay; // 0x38
        public UIntPtr m_pVROverlayView; // 0x40
        public UIntPtr m_pVRResources; // 0x48
        public UIntPtr m_pVRRenderModels; // 0x50
        public UIntPtr m_pVRExtendedDisplay; // 0x58
        public UIntPtr m_pVRSettings; // 0x60
        public UIntPtr m_pVRApplications; // 0x68
        public UIntPtr m_pVRTrackedCamera; // 0x70
        public UIntPtr m_pVRScreenshots; // 0x78
        public UIntPtr m_pVRDriverManager; // 0x80
        public UIntPtr m_pVRInput; // 0x88
        public UIntPtr m_pVRIOBuffer; // 0x90
        public UIntPtr m_pVRSpatialAnchors; // 0x98
        public UIntPtr m_pVRDebug; // 0xA0
        public UIntPtr m_pVRNotifications; // 0xA8
    }

    public class CVRApplications : Object
    {
        public Valve.VR.IVRApplications FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F78D0
        public void AddApplicationManifest(){} // RVA: 0x7FFAC97F7AE0
        public void RemoveApplicationManifest(){} // RVA: 0x7FFAC97F7BB0
        public void IsApplicationInstalled(){} // RVA: 0x7FFAC97F7C70
        public void GetApplicationCount(){} // RVA: 0x7FFAC6525400
        public void GetApplicationKeyByIndex(){} // RVA: 0x7FFAC8981110
        public void GetApplicationKeyByProcessId(){} // RVA: 0x7FFAC8981140
        public void LaunchApplication(){} // RVA: 0x7FFAC97F7D30
        public void LaunchTemplateApplication(){} // RVA: 0x7FFAC97F7DF0
        public void LaunchApplicationFromMimeType(){} // RVA: 0x7FFAC97F7EF0
        public void LaunchDashboardOverlay(){} // RVA: 0x7FFAC97F7FD0
        public void CancelApplicationLaunch(){} // RVA: 0x7FFAC97F8090
        public void IdentifyApplication(){} // RVA: 0x7FFAC97F8150
        public void GetApplicationProcessId(){} // RVA: 0x7FFAC97F8210
        public void GetApplicationsErrorNameFromEnum(){} // RVA: 0x7FFAC97F82D0
        public void GetApplicationPropertyString(){} // RVA: 0x7FFAC97F8380
        public void GetApplicationPropertyBool(){} // RVA: 0x7FFAC97F8470
        public void GetApplicationPropertyUint64(){} // RVA: 0x7FFAC97F8550
        public void SetApplicationAutoLaunch(){} // RVA: 0x7FFAC97F8630
        public void GetApplicationAutoLaunch(){} // RVA: 0x7FFAC97F8700
        public void SetDefaultApplicationForMimeType(){} // RVA: 0x7FFAC97F87C0
        public void GetDefaultApplicationForMimeType(){} // RVA: 0x7FFAC97F88A0
        public void GetApplicationSupportedMimeTypes(){} // RVA: 0x7FFAC97F8980
        public void GetApplicationsThatSupportMimeType(){} // RVA: 0x7FFAC97F8A60
        public void GetApplicationLaunchArguments(){} // RVA: 0x7FFAC897F6D0
        public void GetStartingApplication(){} // RVA: 0x7FFAC8981450
        public void GetSceneApplicationState(){} // RVA: 0x7FFAC8981480
        public void PerformApplicationPrelaunchCheck(){} // RVA: 0x7FFAC97F8B40
        public void GetSceneApplicationStateNameFromEnum(){} // RVA: 0x7FFAC97F8C00
        public void LaunchInternalProcess(){} // RVA: 0x7FFAC97F8CB0
        public void GetCurrentSceneProcessId(){} // RVA: 0x7FFAC8982600
    }

    public class CVRBlockQueue : Object
    {
        public Valve.VR.IVRBlockQueue FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FF640
        public void Create(){} // RVA: 0x7FFAC97FF800
        public void Connect(){} // RVA: 0x7FFAC97FF900
        public void Destroy(){} // RVA: 0x7FFAC64FAEC0
        public void AcquireWriteOnlyBlock(){} // RVA: 0x7FFAC97FF9D0
        public void ReleaseWriteOnlyBlock(){} // RVA: 0x7FFAC8984C50
        public void WaitAndAcquireReadOnlyBlock(){} // RVA: 0x7FFAC97FFA10
        public void AcquireReadOnlyBlock(){} // RVA: 0x7FFAC97FFA50
        public void ReleaseReadOnlyBlock(){} // RVA: 0x7FFAC77974B0
        public void QueueHasReader(){} // RVA: 0x7FFAC97FFA90
    }

    public class CVRChaperone : Object
    {
        public Valve.VR.IVRChaperone FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F8DC0
        public void GetCalibrationState(){} // RVA: 0x7FFAC3D3B830
        public void GetPlayAreaSize(){} // RVA: 0x7FFAC89817C0
        public void GetPlayAreaRect(){} // RVA: 0x7FFAC64FAEC0
        public void ReloadInfo(){} // RVA: 0x7FFAC6525400
        public void SetSceneColor(){} // RVA: 0x7FFAC89817F0
        public void GetBoundsColor(){} // RVA: 0x7FFAC8981830
        public void AreBoundsVisible(){} // RVA: 0x7FFAC897F360
        public void ForceBoundsVisible(){} // RVA: 0x7FFAC8981860
        public void ResetZeroPose(){} // RVA: 0x7FFAC97F8F80
    }

    public class CVRChaperoneSetup : Object
    {
        public Valve.VR.IVRChaperoneSetup FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F8FB0
        public void CommitWorkingCopy(){} // RVA: 0x7FFAC7793490
        public void RevertWorkingCopy(){} // RVA: 0x7FFAC669D470
        public void GetWorkingPlayAreaSize(){} // RVA: 0x7FFAC8981A80
        public void GetWorkingPlayAreaRect(){} // RVA: 0x7FFAC5C6F7C0
        public void GetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAC97F91A0
        public void GetLiveCollisionBoundsInfo(){} // RVA: 0x7FFAC97F9290
        public void GetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8980DA0
        public void GetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8981860
        public void SetWorkingPlayAreaSize(){} // RVA: 0x7FFAC89811B0
        public void SetWorkingCollisionBoundsInfo(){} // RVA: 0x7FFAC8981C90
        public void SetWorkingPerimeter(){} // RVA: 0x7FFAC97F9380
        public void SetWorkingSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8981CC0
        public void SetWorkingStandingZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC8981210
        public void ReloadFromDisk(){} // RVA: 0x7FFAC8981CF0
        public void GetLiveSeatedZeroPoseToRawTrackingPose(){} // RVA: 0x7FFAC97F93B0
        public void ExportLiveToBuffer(){} // RVA: 0x7FFAC97F93E0
        public void ImportFromBufferToWorking(){} // RVA: 0x7FFAC97F9410
        public void ShowWorkingSetPreview(){} // RVA: 0x7FFAC8982420
        public void HideWorkingSetPreview(){} // RVA: 0x7FFAC8982450
        public void RoomSetupStarting(){} // RVA: 0x7FFAC8982480
    }

    public class CVRCompositor : Object
    {
        public Valve.VR.IVRCompositor FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F94E0
        public void SetTrackingSpace(){} // RVA: 0x7FFAC7793490
        public void GetTrackingSpace(){} // RVA: 0x7FFAC669D470
        public void WaitGetPoses(){} // RVA: 0x7FFAC89821D0
        public void GetLastPoses(){} // RVA: 0x7FFAC8982220
        public void GetLastPoseForTrackedDeviceIndex(){} // RVA: 0x7FFAC8981110
        public void Submit(){} // RVA: 0x7FFAC8982270
        public void SubmitWithArrayIndex(){} // RVA: 0x7FFAC97F96E0
        public void ClearLastSubmittedFrame(){} // RVA: 0x7FFAC89822A0
        public void PostPresentHandoff(){} // RVA: 0x7FFAC8983F10
        public void GetFrameTiming(){} // RVA: 0x7FFAC89822D0
        public void GetFrameTimings(){} // RVA: 0x7FFAC97F9380
        public void GetFrameTimeRemaining(){} // RVA: 0x7FFAC97F9710
        public void GetCumulativeStats(){} // RVA: 0x7FFAC97F9740
        public void FadeToColor(){} // RVA: 0x7FFAC97F9770
        public void GetCurrentFadeColor(){} // RVA: 0x7FFAC97F97C0
        public void FadeGrid(){} // RVA: 0x7FFAC8984240
        public void GetCurrentGridAlpha(){} // RVA: 0x7FFAC97F9800
        public void SetSkyboxOverride(){} // RVA: 0x7FFAC97F9830
        public void ClearSkyboxOverride(){} // RVA: 0x7FFAC8982450
        public void CompositorBringToFront(){} // RVA: 0x7FFAC8982480
        public void CompositorGoToBack(){} // RVA: 0x7FFAC89824B0
        public void CompositorQuit(){} // RVA: 0x7FFAC89824E0
        public void IsFullscreen(){} // RVA: 0x7FFAC8982510
        public void GetCurrentSceneFocusProcess(){} // RVA: 0x7FFAC8982540
        public void GetLastFrameRenderer(){} // RVA: 0x7FFAC8982570
        public void CanRenderScene(){} // RVA: 0x7FFAC8981480
        public void ShowMirrorWindow(){} // RVA: 0x7FFAC89825A0
        public void HideMirrorWindow(){} // RVA: 0x7FFAC89825D0
        public void IsMirrorWindowVisible(){} // RVA: 0x7FFAC8981590
        public void CompositorDumpImages(){} // RVA: 0x7FFAC8982600
        public void ShouldAppRenderWithLowResources(){} // RVA: 0x7FFAC89815F0
        public void ForceInterleavedReprojectionOn(){} // RVA: 0x7FFAC97F9870
        public void ForceReconnectProcess(){} // RVA: 0x7FFAC97F98A0
        public void SuspendRendering(){} // RVA: 0x7FFAC97F98D0
        public void GetMirrorTextureD3D11(){} // RVA: 0x7FFAC8983040
        public void ReleaseMirrorTextureD3D11(){} // RVA: 0x7FFAC97F9900
        public void GetMirrorTextureGL(){} // RVA: 0x7FFAC89830A0
        public void ReleaseSharedGLTexture(){} // RVA: 0x7FFAC97F9930
        public void LockGLSharedTextureForAccess(){} // RVA: 0x7FFAC89827C0
        public void UnlockGLSharedTextureForAccess(){} // RVA: 0x7FFAC97F9960
        public void GetVulkanInstanceExtensionsRequired(){} // RVA: 0x7FFAC97F9990
        public void GetVulkanDeviceExtensionsRequired(){} // RVA: 0x7FFAC97F99C0
        public void SetExplicitTimingMode(){} // RVA: 0x7FFAC8983190
        public void SubmitExplicitTimingData(){} // RVA: 0x7FFAC97F70F0
        public void IsMotionSmoothingEnabled(){} // RVA: 0x7FFAC97F99F0
        public void IsMotionSmoothingSupported(){} // RVA: 0x7FFAC89804E0
        public void IsCurrentSceneFocusAppLoading(){} // RVA: 0x7FFAC8980510
        public void SetStageOverride_Async(){} // RVA: 0x7FFAC97F9A20
        public void ClearStageOverride(){} // RVA: 0x7FFAC97F9B10
        public void GetCompositorBenchmarkResults(){} // RVA: 0x7FFAC8983510
        public void GetLastPosePredictionIDs(){} // RVA: 0x7FFAC97F9B40
        public void GetPosesForFrame(){} // RVA: 0x7FFAC97F9B70
    }

    public class CVRDebug : Object
    {
        public Valve.VR.IVRDebug FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FED30
        public void EmitVrProfilerEvent(){} // RVA: 0x7FFAC97FEEC0
        public void BeginVrProfilerEvent(){} // RVA: 0x7FFAC97FEF80
        public void FinishVrProfilerEvent(){} // RVA: 0x7FFAC97FEFB0
        public void DriverDebugRequest(){} // RVA: 0x7FFAC97FF080
    }

    public class CVRDriverManager : Object
    {
        public Valve.VR.IVRDriverManager FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FDB60
        public void GetDriverCount(){} // RVA: 0x7FFAC3D3B830
        public void GetDriverName(){} // RVA: 0x7FFAC8985050
        public void GetDriverHandle(){} // RVA: 0x7FFAC97FDCF0
        public void IsEnabled(){} // RVA: 0x7FFAC5C6F7C0
    }

    public class CVRExtendedDisplay : Object
    {
        public Valve.VR.IVRExtendedDisplay FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F7460
        public void GetWindowBounds(){} // RVA: 0x7FFAC8980960
        public void GetEyeOutputViewport(){} // RVA: 0x7FFAC89809A0
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAC89809F0
    }

    public class CVRHeadsetView : Object
    {
        public Valve.VR.IVRHeadsetView FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FB340
        public void SetHeadsetViewSize(){} // RVA: 0x7FFAC78F7300
        public void GetHeadsetViewSize(){} // RVA: 0x7FFAC97FB500
        public void SetHeadsetViewMode(){} // RVA: 0x7FFAC64FAEC0
        public void GetHeadsetViewMode(){} // RVA: 0x7FFAC6525400
        public void SetHeadsetViewCropped(){} // RVA: 0x7FFAC8224FE0
        public void GetHeadsetViewCropped(){} // RVA: 0x7FFAC97FB530
        public void GetHeadsetViewAspectRatio(){} // RVA: 0x7FFAC897F360
        public void SetHeadsetViewBlendRange(){} // RVA: 0x7FFAC77974B0
        public void GetHeadsetViewBlendRange(){} // RVA: 0x7FFAC97FB560
    }

    public class CVRIOBuffer : Object
    {
        public Valve.VR.IVRIOBuffer FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FE840
        public void Open(){} // RVA: 0x7FFAC97FE9E0
        public void Close(){} // RVA: 0x7FFAC3584BC0
        public void Read(){} // RVA: 0x7FFAC8985740
        public void Write(){} // RVA: 0x7FFAC8985780
        public void PropertyContainer(){} // RVA: 0x7FFAC8224FE0
        public void HasReaders(){} // RVA: 0x7FFAC7798530
    }

    public class CVRInput : Object
    {
        public Valve.VR.IVRInput FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FDDB0
        public void SetActionManifestPath(){} // RVA: 0x7FFAC97FDFA0
        public void GetActionSetHandle(){} // RVA: 0x7FFAC97FE060
        public void GetActionHandle(){} // RVA: 0x7FFAC97FE130
        public void GetInputSourceHandle(){} // RVA: 0x7FFAC97FE200
        public void UpdateActionState(){} // RVA: 0x7FFAC89852F0
        public void GetDigitalActionData(){} // RVA: 0x7FFAC8982270
        public void GetAnalogActionData(){} // RVA: 0x7FFAC8982B10
        public void GetPoseActionDataRelativeToNow(){} // RVA: 0x7FFAC8985330
        public void GetPoseActionDataForNextFrame(){} // RVA: 0x7FFAC97FE2D0
        public void GetSkeletalActionData(){} // RVA: 0x7FFAC97FE300
        public void GetDominantHand(){} // RVA: 0x7FFAC7797E00
        public void SetDominantHand(){} // RVA: 0x7FFAC8981CC0
        public void GetBoneCount(){} // RVA: 0x7FFAC97FA1D0
        public void GetBoneHierarchy(){} // RVA: 0x7FFAC97FE330
        public void GetBoneName(){} // RVA: 0x7FFAC97FE370
        public void GetSkeletalReferenceTransforms(){} // RVA: 0x7FFAC97FE3A0
        public void GetSkeletalTrackingLevel(){} // RVA: 0x7FFAC8982CF0
        public void GetSkeletalBoneData(){} // RVA: 0x7FFAC97FE3F0
        public void GetSkeletalSummaryData(){} // RVA: 0x7FFAC97FE440
        public void GetSkeletalBoneDataCompressed(){} // RVA: 0x7FFAC97FE470
        public void DecompressSkeletalBoneData(){} // RVA: 0x7FFAC97FE4B0
        public void TriggerHapticVibrationAction(){} // RVA: 0x7FFAC97FE500
        public void GetActionOrigins(){} // RVA: 0x7FFAC97FE540
        public void GetOriginLocalizedName(){} // RVA: 0x7FFAC97FE580
        public void GetOriginTrackedDeviceInfo(){} // RVA: 0x7FFAC897F700
        public void GetActionBindingInfo(){} // RVA: 0x7FFAC97FE5B0
        public void ShowActionOrigins(){} // RVA: 0x7FFAC8982EE0
        public void ShowBindingsForActionSet(){} // RVA: 0x7FFAC97FE600
        public void GetComponentStateForBinding(){} // RVA: 0x7FFAC97FE640
        public void IsUsingLegacyInput(){} // RVA: 0x7FFAC8982600
        public void OpenBindingUI(){} // RVA: 0x7FFAC97FE750
        public void GetBindingVariant(){} // RVA: 0x7FFAC8982FE0
    }

    public class CVRNotifications : Object
    {
        public Valve.VR.IVRNotifications FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FC470
        public void CreateNotification(){} // RVA: 0x7FFAC97FC600
        public void RemoveNotification(){} // RVA: 0x7FFAC3584BC0
    }

    public class CVROverlay : Object
    {
        public Valve.VR.IVROverlay FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F9BB0
        public void FindOverlay(){} // RVA: 0x7FFAC97F9DA0
        public void CreateOverlay(){} // RVA: 0x7FFAC97F9E70
        public void DestroyOverlay(){} // RVA: 0x7FFAC64FAEC0
        public void GetOverlayKey(){} // RVA: 0x7FFAC8980D10
        public void GetOverlayName(){} // RVA: 0x7FFAC97F9F70
        public void SetOverlayName(){} // RVA: 0x7FFAC97F9FA0
        public void GetOverlayImageData(){} // RVA: 0x7FFAC97FA070
        public void GetOverlayErrorNameFromEnum(){} // RVA: 0x7FFAC97FA0C0
        public void SetOverlayRenderingPid(){} // RVA: 0x7FFAC89811B0
        public void GetOverlayRenderingPid(){} // RVA: 0x7FFAC89811E0
        public void SetOverlayFlag(){} // RVA: 0x7FFAC97FA170
        public void GetOverlayFlag(){} // RVA: 0x7FFAC97FA1A0
        public void GetOverlayFlags(){} // RVA: 0x7FFAC97FA1D0
        public void SetOverlayColor(){} // RVA: 0x7FFAC97FA200
        public void GetOverlayColor(){} // RVA: 0x7FFAC97FA230
        public void SetOverlayAlpha(){} // RVA: 0x7FFAC8984240
        public void GetOverlayAlpha(){} // RVA: 0x7FFAC97FA270
        public void SetOverlayTexelAspect(){} // RVA: 0x7FFAC8981390
        public void GetOverlayTexelAspect(){} // RVA: 0x7FFAC97FA2A0
        public void SetOverlaySortOrder(){} // RVA: 0x7FFAC89813C0
        public void GetOverlaySortOrder(){} // RVA: 0x7FFAC97FA2D0
        public void SetOverlayWidthInMeters(){} // RVA: 0x7FFAC97FA300
        public void GetOverlayWidthInMeters(){} // RVA: 0x7FFAC97FA330
        public void SetOverlayCurvature(){} // RVA: 0x7FFAC97FA360
        public void GetOverlayCurvature(){} // RVA: 0x7FFAC97FA390
        public void SetOverlayPreCurvePitch(){} // RVA: 0x7FFAC97FA3C0
        public void GetOverlayPreCurvePitch(){} // RVA: 0x7FFAC97FA3F0
        public void SetOverlayTextureColorSpace(){} // RVA: 0x7FFAC8982F10
        public void GetOverlayTextureColorSpace(){} // RVA: 0x7FFAC8982F40
        public void SetOverlayTextureBounds(){} // RVA: 0x7FFAC8982F70
        public void GetOverlayTextureBounds(){} // RVA: 0x7FFAC97FA420
        public void GetOverlayTransformType(){} // RVA: 0x7FFAC97FA450
        public void SetOverlayTransformAbsolute(){} // RVA: 0x7FFAC97FA480
        public void GetOverlayTransformAbsolute(){} // RVA: 0x7FFAC89826C0
        public void SetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAC8983040
        public void GetOverlayTransformTrackedDeviceRelative(){} // RVA: 0x7FFAC8982720
        public void SetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAC97FA4B0
        public void GetOverlayTransformTrackedDeviceComponent(){} // RVA: 0x7FFAC97FA590
        public void SetOverlayTransformCursor(){} // RVA: 0x7FFAC97FA5D0
        public void GetOverlayTransformCursor(){} // RVA: 0x7FFAC89827F0
        public void SetOverlayTransformProjection(){} // RVA: 0x7FFAC97FA600
        public void ShowOverlay(){} // RVA: 0x7FFAC8982850
        public void HideOverlay(){} // RVA: 0x7FFAC8983190
        public void IsOverlayVisible(){} // RVA: 0x7FFAC89831C0
        public void GetTransformForOverlayCoordinates(){} // RVA: 0x7FFAC89831F0
        public void WaitFrameSync(){} // RVA: 0x7FFAC97FA640
        public void PollNextOverlayEvent(){} // RVA: 0x7FFAC97FA670
        public void GetOverlayInputMethod(){} // RVA: 0x7FFAC89834B0
        public void SetOverlayInputMethod(){} // RVA: 0x7FFAC89834E0
        public void GetOverlayMouseScale(){} // RVA: 0x7FFAC8983510
        public void SetOverlayMouseScale(){} // RVA: 0x7FFAC97FA8D0
        public void ComputeOverlayIntersection(){} // RVA: 0x7FFAC97FA900
        public void IsHoverTargetOverlay(){} // RVA: 0x7FFAC97FA930
        public void SetOverlayIntersectionMask(){} // RVA: 0x7FFAC97FA960
        public void TriggerLaserMouseHapticVibration(){} // RVA: 0x7FFAC97FA990
        public void SetOverlayCursor(){} // RVA: 0x7FFAC8983630
        public void SetOverlayCursorPositionOverride(){} // RVA: 0x7FFAC97FA9C0
        public void ClearOverlayCursorPositionOverride(){} // RVA: 0x7FFAC97FA9F0
        public void SetOverlayTexture(){} // RVA: 0x7FFAC89836D0
        public void ClearOverlayTexture(){} // RVA: 0x7FFAC8983700
        public void SetOverlayRaw(){} // RVA: 0x7FFAC8983730
        public void SetOverlayFromFile(){} // RVA: 0x7FFAC97FAA20
        public void GetOverlayTexture(){} // RVA: 0x7FFAC89837A0
        public void ReleaseNativeOverlayHandle(){} // RVA: 0x7FFAC8983800
        public void GetOverlayTextureSize(){} // RVA: 0x7FFAC8983830
        public void CreateDashboardOverlay(){} // RVA: 0x7FFAC97FAAF0
        public void IsDashboardVisible(){} // RVA: 0x7FFAC89838B0
        public void IsActiveDashboardOverlay(){} // RVA: 0x7FFAC89838E0
        public void SetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAC8983910
        public void GetDashboardOverlaySceneProcess(){} // RVA: 0x7FFAC8983940
        public void ShowDashboard(){} // RVA: 0x7FFAC97FAC00
        public void GetPrimaryDashboardDevice(){} // RVA: 0x7FFAC89839A0
        public void ShowKeyboard(){} // RVA: 0x7FFAC97FACC0
        public void ShowKeyboardForOverlay(){} // RVA: 0x7FFAC97FADF0
        public void GetKeyboardText(){} // RVA: 0x7FFAC8983A50
        public void HideKeyboard(){} // RVA: 0x7FFAC8983A80
        public void SetKeyboardTransformAbsolute(){} // RVA: 0x7FFAC8983AB0
        public void SetKeyboardPositionForOverlay(){} // RVA: 0x7FFAC8983AE0
        public void ShowMessageOverlay(){} // RVA: 0x7FFAC97FAF30
        public void CloseMessageOverlay(){} // RVA: 0x7FFAC97FB0B0
    }

    public class CVROverlayView : Object
    {
        public Valve.VR.IVROverlayView FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FB1B0
        public void AcquireOverlayView(){} // RVA: 0x7FFAC8E2C980
        public void ReleaseOverlayView(){} // RVA: 0x7FFAC3584BC0
        public void PostOverlayEvent(){} // RVA: 0x7FFAC8225010
        public void IsViewingPermitted(){} // RVA: 0x7FFAC5C6F7C0
    }

    public class CVRPaths : Object
    {
        public Valve.VR.IVRPaths FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FF3A0
        public void ReadPathBatch(){} // RVA: 0x7FFAC8984E50
        public void WritePathBatch(){} // RVA: 0x7FFAC8985050
        public void StringToHandle(){} // RVA: 0x7FFAC97FF530
        public void HandleToString(){} // RVA: 0x7FFAC97FF600
    }

    public class CVRProperties : Object
    {
        public Valve.VR.IVRProperties FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FF160
        public void ReadPropertyBatch(){} // RVA: 0x7FFAC8984E50
        public void WritePropertyBatch(){} // RVA: 0x7FFAC8985050
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFAC97FF2F0
        public void TrackedDeviceToPropertyContainer(){} // RVA: 0x7FFAC5C6F7C0
    }

    public class CVRPropertyHelpers : ValueType
    {
        public UIntPtr m_pProperties; // 0x10
    }

    public class CVRRenderModels : Object
    {
        public Valve.VR.IVRRenderModels FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FB590
        public void LoadRenderModel_Async(){} // RVA: 0x7FFAC97FB780
        public void FreeRenderModel(){} // RVA: 0x7FFAC3584BC0
        public void LoadTexture_Async(){} // RVA: 0x7FFAC8225010
        public void FreeTexture(){} // RVA: 0x7FFAC5C6F7C0
        public void LoadTextureD3D11_Async(){} // RVA: 0x7FFAC8981110
        public void LoadIntoTextureD3D11_Async(){} // RVA: 0x7FFAC8983EB0
        public void FreeTextureD3D11(){} // RVA: 0x7FFAC8980DA0
        public void GetRenderModelName(){} // RVA: 0x7FFAC8983EE0
        public void GetRenderModelCount(){} // RVA: 0x7FFAC8983F10
        public void GetComponentCount(){} // RVA: 0x7FFAC97FB850
        public void GetComponentName(){} // RVA: 0x7FFAC97FB910
        public void GetComponentButtonMask(){} // RVA: 0x7FFAC97FB9F0
        public void GetComponentRenderModelName(){} // RVA: 0x7FFAC97FBAD0
        public void GetComponentStateForDevicePath(){} // RVA: 0x7FFAC97FBBD0
        public void GetComponentState(){} // RVA: 0x7FFAC97FBCE0
        public void RenderModelHasComponent(){} // RVA: 0x7FFAC97FBFE0
        public void GetRenderModelThumbnailURL(){} // RVA: 0x7FFAC97FC0C0
        public void GetRenderModelOriginalPath(){} // RVA: 0x7FFAC97FC1B0
        public void GetRenderModelErrorNameFromEnum(){} // RVA: 0x7FFAC97FC2A0
    }

    public class CVRResources : Object
    {
        public Valve.VR.IVRResources FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FD7F0
        public void LoadSharedResource(){} // RVA: 0x7FFAC97FD980
        public void GetResourceFullPath(){} // RVA: 0x7FFAC97FDA60
    }

    public class CVRScreenshots : Object
    {
        public Valve.VR.IVRScreenshots FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FD330
        public void RequestScreenshot(){} // RVA: 0x7FFAC97FD4E0
        public void HookScreenshot(){} // RVA: 0x7FFAC8984BF0
        public void GetScreenshotPropertyType(){} // RVA: 0x7FFAC8225010
        public void GetScreenshotPropertyFilename(){} // RVA: 0x7FFAC8984C20
        public void UpdateScreenshotProgress(){} // RVA: 0x7FFAC8984C50
        public void TakeStereoScreenshot(){} // RVA: 0x7FFAC97FD5F0
        public void SubmitScreenshot(){} // RVA: 0x7FFAC97FD6F0
    }

    public class CVRSettingHelper : ValueType
    {
        public UIntPtr m_pSettings; // 0x10
    }

    public class CVRSettings : Object
    {
        public Valve.VR.IVRSettings FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FC720
        public void GetSettingsErrorNameFromEnum(){} // RVA: 0x7FFAC97FC8E0
        public void SetBool(){} // RVA: 0x7FFAC97FC990
        public void SetInt32(){} // RVA: 0x7FFAC97FCA90
        public void SetFloat(){} // RVA: 0x7FFAC97FCB90
        public void SetString(){} // RVA: 0x7FFAC97FCC90
        public void GetBool(){} // RVA: 0x7FFAC97FCDA0
        public void GetInt32(){} // RVA: 0x7FFAC97FCE90
        public void GetFloat(){} // RVA: 0x7FFAC97FCF80
        public void GetString(){} // RVA: 0x7FFAC97FD080
        public void RemoveSection(){} // RVA: 0x7FFAC97FD180
        public void RemoveKeyInSection(){} // RVA: 0x7FFAC97FD240
    }

    public class CVRSpatialAnchors : Object
    {
        public Valve.VR.IVRSpatialAnchors FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97FEAD0
        public void CreateSpatialAnchorFromDescriptor(){} // RVA: 0x7FFAC97FEC60
        public void CreateSpatialAnchorFromPose(){} // RVA: 0x7FFAC8985970
        public void GetSpatialAnchorPose(){} // RVA: 0x7FFAC89859B0
        public void GetSpatialAnchorDescriptor(){} // RVA: 0x7FFAC89859E0
    }

    public class CVRSystem : Object
    {
        public Valve.VR.IVRSystem FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F6170
        public void GetRecommendedRenderTargetSize(){} // RVA: 0x7FFAC897F1C0
        public void GetProjectionMatrix(){} // RVA: 0x7FFAC897F1F0
        public void GetProjectionRaw(){} // RVA: 0x7FFAC897F260
        public void ComputeDistortion(){} // RVA: 0x7FFAC897F2B0
        public void GetEyeToHeadTransform(){} // RVA: 0x7FFAC897F2E0
        public void GetTimeSinceLastVsync(){} // RVA: 0x7FFAC897F330
        public void GetD3D9AdapterIndex(){} // RVA: 0x7FFAC897F360
        public void GetDXGIOutputInfo(){} // RVA: 0x7FFAC897F390
        public void GetOutputDevice(){} // RVA: 0x7FFAC897F3C0
        public void IsDisplayOnDesktop(){} // RVA: 0x7FFAC897F400
        public void SetDisplayVisibility(){} // RVA: 0x7FFAC7797E00
        public void GetDeviceToAbsoluteTrackingPose(){} // RVA: 0x7FFAC897F430
        public void GetSeatedZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAC97F6390
        public void GetRawZeroPoseToStandingAbsoluteTrackingPose(){} // RVA: 0x7FFAC897F4A0
        public void GetSortedTrackedDeviceIndicesOfClass(){} // RVA: 0x7FFAC97F63E0
        public void GetTrackedDeviceActivityLevel(){} // RVA: 0x7FFAC97F6420
        public void ApplyTransform(){} // RVA: 0x7FFAC8981360
        public void GetTrackedDeviceIndexForControllerRole(){} // RVA: 0x7FFAC97F6450
        public void GetControllerRoleForTrackedDeviceIndex(){} // RVA: 0x7FFAC897F5E0
        public void GetTrackedDeviceClass(){} // RVA: 0x7FFAC897F610
        public void IsTrackedDeviceConnected(){} // RVA: 0x7FFAC897F640
        public void GetBoolTrackedDeviceProperty(){} // RVA: 0x7FFAC8981420
        public void GetFloatTrackedDeviceProperty(){} // RVA: 0x7FFAC897F6A0
        public void GetInt32TrackedDeviceProperty(){} // RVA: 0x7FFAC897F6D0
        public void GetUint64TrackedDeviceProperty(){} // RVA: 0x7FFAC897F700
        public void GetMatrix34TrackedDeviceProperty(){} // RVA: 0x7FFAC97F6480
        public void GetArrayTrackedDeviceProperty(){} // RVA: 0x7FFAC97F64E0
        public void GetStringTrackedDeviceProperty(){} // RVA: 0x7FFAC97F6520
        public void GetPropErrorNameFromEnum(){} // RVA: 0x7FFAC97F6560
        public void PollNextEvent(){} // RVA: 0x7FFAC97F6610
        public void PollNextEventWithPose(){} // RVA: 0x7FFAC97F6860
        public void GetEventTypeNameFromEnum(){} // RVA: 0x7FFAC97F6890
        public void GetHiddenAreaMesh(){} // RVA: 0x7FFAC97F6940
        public void GetControllerState(){} // RVA: 0x7FFAC97F6990
        public void GetControllerStateWithPose(){} // RVA: 0x7FFAC97F6C60
        public void TriggerHapticPulse(){} // RVA: 0x7FFAC8983070
        public void GetButtonIdNameFromEnum(){} // RVA: 0x7FFAC97F6F60
        public void GetControllerAxisTypeNameFromEnum(){} // RVA: 0x7FFAC97F7010
        public void IsInputAvailable(){} // RVA: 0x7FFAC97F70C0
        public void IsSteamVRDrawingControllers(){} // RVA: 0x7FFAC89803C0
        public void ShouldApplicationPause(){} // RVA: 0x7FFAC89803F0
        public void ShouldApplicationReduceRenderingWork(){} // RVA: 0x7FFAC8980420
        public void PerformFirmwareUpdate(){} // RVA: 0x7FFAC8983190
        public void AcknowledgeQuit_Exiting(){} // RVA: 0x7FFAC97F70F0
        public void GetAppContainerFilePaths(){} // RVA: 0x7FFAC97F7120
        public void GetRuntimeVersion(){} // RVA: 0x7FFAC97F7150
    }

    public class CVRTrackedCamera : Object
    {
        public Valve.VR.IVRTrackedCamera FnTable; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC97F7600
        public void GetCameraErrorNameFromEnum(){} // RVA: 0x7FFAC97F77C0
        public void HasCamera(){} // RVA: 0x7FFAC8980C90
        public void GetCameraFrameSize(){} // RVA: 0x7FFAC8980CC0
        public void GetCameraIntrinsics(){} // RVA: 0x7FFAC8984C20
        public void GetCameraProjection(){} // RVA: 0x7FFAC97F7870
        public void AcquireVideoStreamingService(){} // RVA: 0x7FFAC8980D70
        public void ReleaseVideoStreamingService(){} // RVA: 0x7FFAC8980DA0
        public void GetVideoStreamFrameBuffer(){} // RVA: 0x7FFAC8980DD0
        public void GetVideoStreamTextureSize(){} // RVA: 0x7FFAC8980E00
        public void GetVideoStreamTextureD3D11(){} // RVA: 0x7FFAC8980E50
        public void GetVideoStreamTextureGL(){} // RVA: 0x7FFAC8980E80
        public void ReleaseVideoStreamTextureGL(){} // RVA: 0x7FFAC8980EC0
        public void SetCameraTrackingSpace(){} // RVA: 0x7FFAC8981210
        public void GetCameraTrackingSpace(){} // RVA: 0x7FFAC97F78A0
    }

    public class CameraVideoStreamFrameHeader_t : ValueType
    {
        public 0x6B240AD0 eFrameType; // 0x10
        public uint nWidth; // 0x14
        public uint nHeight; // 0x18
        public uint nBytesPerPixel; // 0x1C
        public uint nFrameSequence; // 0x20
        public Valve.VR.TrackedDevicePose_t trackedDevicePose; // 0x24
        public ulong ulFrameExposureTime; // 0x78
    }

    public class Compositor_BenchmarkResults : ValueType
    {
        public float m_flMegaPixelsPerSecond; // 0x10
        public float m_flHmdRecommendedMegaPixelsPerSecond; // 0x14
    }

    public class Compositor_CumulativeStats : ValueType
    {
        public uint m_nPid; // 0x10
        public uint m_nNumFramePresents; // 0x14
        public uint m_nNumDroppedFrames; // 0x18
        public uint m_nNumReprojectedFrames; // 0x1C
        public uint m_nNumFramePresentsOnStartup; // 0x20
        public uint m_nNumDroppedFramesOnStartup; // 0x24
        public uint m_nNumReprojectedFramesOnStartup; // 0x28
        public uint m_nNumLoading; // 0x2C
        public uint m_nNumFramePresentsLoading; // 0x30
        public uint m_nNumDroppedFramesLoading; // 0x34
        public uint m_nNumReprojectedFramesLoading; // 0x38
        public uint m_nNumTimedOut; // 0x3C
        public uint m_nNumFramePresentsTimedOut; // 0x40
        public uint m_nNumDroppedFramesTimedOut; // 0x44
        public uint m_nNumReprojectedFramesTimedOut; // 0x48
        public uint m_nNumFrameSubmits; // 0x4C
        public double m_flSumCompositorCPUTimeMS; // 0x50
        public double m_flSumCompositorGPUTimeMS; // 0x58
        public double m_flSumTargetFrameTimes; // 0x60
        public double m_flSumApplicationCPUTimeMS; // 0x68
        public double m_flSumApplicationGPUTimeMS; // 0x70
        public uint m_nNumFramesWithDepth; // 0x78
    }

    public class Compositor_FrameTiming : ValueType
    {
        public uint m_nSize; // 0x10
        public uint m_nFrameIndex; // 0x14
        public uint m_nNumFramePresents; // 0x18
        public uint m_nNumMisPresented; // 0x1C
        public uint m_nNumDroppedFrames; // 0x20
        public uint m_nReprojectionFlags; // 0x24
        public double m_flSystemTimeInSeconds; // 0x28
        public float m_flPreSubmitGpuMs; // 0x30
        public float m_flPostSubmitGpuMs; // 0x34
        public float m_flTotalRenderGpuMs; // 0x38
        public float m_flCompositorRenderGpuMs; // 0x3C
        public float m_flCompositorRenderCpuMs; // 0x40
        public float m_flCompositorIdleCpuMs; // 0x44
        public float m_flClientFrameIntervalMs; // 0x48
        public float m_flPresentCallCpuMs; // 0x4C
        public float m_flWaitForPresentCpuMs; // 0x50
        public float m_flSubmitFrameMs; // 0x54
        public float m_flWaitGetPosesCalledMs; // 0x58
        public float m_flNewPosesReadyMs; // 0x5C
        public float m_flNewFrameReadyMs; // 0x60
        public float m_flCompositorUpdateStartMs; // 0x64
        public float m_flCompositorUpdateEndMs; // 0x68
        public float m_flCompositorRenderStartMs; // 0x6C
        public Valve.VR.TrackedDevicePose_t m_HmdPose; // 0x70
        public uint m_nNumVSyncsReadyForUse; // 0xC0
        public uint m_nNumVSyncsToFirstView; // 0xC4
        public float m_flTransferLatencyMs; // 0xC8
    }

    public class Compositor_StageRenderSettings : ValueType
    {
        public Valve.VR.HmdColor_t m_PrimaryColor; // 0x10
        public Valve.VR.HmdColor_t m_SecondaryColor; // 0x20
        public float m_flVignetteInnerRadius; // 0x30
        public float m_flVignetteOuterRadius; // 0x34
        public float m_flFresnelStrength; // 0x38
        public bool m_bBackfaceCulling; // 0x3C
        public bool m_bGreyscale; // 0x3D
        public bool m_bWireframe; // 0x3E
    }

}