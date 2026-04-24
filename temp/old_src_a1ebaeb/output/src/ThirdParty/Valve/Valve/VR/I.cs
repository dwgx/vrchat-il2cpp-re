// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 40
// Methods: 92

namespace ThirdParty.Valve.Valve.VR
{
    public class ISteamVR_ActionSet
    {
        // ── Original Methods ──
        public void get_allActions(){} // RVA: 0x7ffaa86491d0
        public void get_nonVisualInActions(){} // RVA: 0x7ffaa86491d0
        public void get_visualActions(){} // RVA: 0x7ffaa86491d0
        public void get_poseActions(){} // RVA: 0x7ffaa86491d0
        public void get_skeletonActions(){} // RVA: 0x7ffaa86491d0
        public void get_outActionArray(){} // RVA: 0x7ffaa86491d0
        public void get_fullPath(){} // RVA: 0x7ffaa86491d0
        public void get_usage(){} // RVA: 0x7ffaa86491d0
        public void get_handle(){} // RVA: 0x7ffaa86491d0
        public void ReadRawSetActive(){} // RVA: 0x7ffaa864a650
        public void ReadRawSetLastChanged(){} // RVA: 0x7ffaa865df70
        public void ReadRawSetPriority(){} // RVA: 0x7ffaa8650410
        public void IsActive(){} // RVA: 0x7ffaa864a650
        public void Activate(){} // RVA: 0x7ffaa86632a0
        public void Deactivate(){} // RVA: 0x7ffaa8661210
        // ── Binary Analysis Named ──
        public void GetTimeLastChanged(){} // RVA: 0x7ffaa865df70
        public void GetShortName(){} // RVA: 0x7ffaa86491d0
    }

    public class ISteamVR_Action_Boolean
    {
        // ── Original Methods ──
        public void get_state(){} // RVA: 0x7ffaa864a040
        public void get_stateDown(){} // RVA: 0x7ffaa864a040
        public void get_stateUp(){} // RVA: 0x7ffaa864a040
        public void get_lastState(){} // RVA: 0x7ffaa864a040
        public void get_lastStateDown(){} // RVA: 0x7ffaa864a040
        public void get_lastStateUp(){} // RVA: 0x7ffaa864a040
    }

    public class ISteamVR_Action_In_Source
    {
        // ── Original Methods ──
        public void get_changed(){} // RVA: 0x7ffaa864a040
        public void get_lastChanged(){} // RVA: 0x7ffaa864a040
        public void get_changedTime(){} // RVA: 0x7ffaa865dbc0
        public void get_updateTime(){} // RVA: 0x7ffaa865dbc0
        public void get_activeOrigin(){} // RVA: 0x7ffaa86491d0
        public void get_lastActiveOrigin(){} // RVA: 0x7ffaa86491d0
        public void get_activeDevice(){} // RVA: 0x7ffaa8649ca0
        public void get_trackedDeviceIndex(){} // RVA: 0x7ffaa8649ca0
        public void get_renderModelComponentName(){} // RVA: 0x7ffaa86491d0
        public void get_localizedOriginName(){} // RVA: 0x7ffaa86491d0
    }

    public class ISteamVR_Action_Single
    {
        // ── Original Methods ──
        public void get_axis(){} // RVA: 0x7ffaa865dbc0
        public void get_lastAxis(){} // RVA: 0x7ffaa865dbc0
        public void get_delta(){} // RVA: 0x7ffaa865dbc0
        public void get_lastDelta(){} // RVA: 0x7ffaa865dbc0
    }

    public class ISteamVR_Action_Skeleton_Source
    {
        // ── Original Methods ──
        public void get_skeletalTrackingLevel(){} // RVA: 0x7ffaa8649ca0
        public void get_bonePositions(){} // RVA: 0x7ffaa86491d0
        public void get_boneRotations(){} // RVA: 0x7ffaa86491d0
        public void get_lastBonePositions(){} // RVA: 0x7ffaa86491d0
        public void get_lastBoneRotations(){} // RVA: 0x7ffaa86491d0
        public void get_rangeOfMotion(){} // RVA: 0x7ffaa8649ca0
        public void set_rangeOfMotion(){} // RVA: 0x7ffaa8661210
        public void get_skeletalTransformSpace(){} // RVA: 0x7ffaa8649ca0
        public void set_skeletalTransformSpace(){} // RVA: 0x7ffaa8661210
        public void get_onlyUpdateSummaryData(){} // RVA: 0x7ffaa864a040
        public void set_onlyUpdateSummaryData(){} // RVA: 0x7ffaa86613a0
        public void get_thumbCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_indexCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_middleCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_ringCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_pinkyCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_thumbIndexSplay(){} // RVA: 0x7ffaa865dbc0
        public void get_indexMiddleSplay(){} // RVA: 0x7ffaa865dbc0
        public void get_middleRingSplay(){} // RVA: 0x7ffaa865dbc0
        public void get_ringPinkySplay(){} // RVA: 0x7ffaa865dbc0
        public void get_lastThumbCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_lastIndexCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_lastMiddleCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_lastRingCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_lastPinkyCurl(){} // RVA: 0x7ffaa865dbc0
        public void get_lastThumbIndexSplay(){} // RVA: 0x7ffaa865dbc0
        public void get_lastIndexMiddleSplay(){} // RVA: 0x7ffaa865dbc0
        public void get_lastMiddleRingSplay(){} // RVA: 0x7ffaa865dbc0
        public void get_lastRingPinkySplay(){} // RVA: 0x7ffaa865dbc0
        public void get_fingerCurls(){} // RVA: 0x7ffaa86491d0
        public void get_fingerSplays(){} // RVA: 0x7ffaa86491d0
        public void get_lastFingerCurls(){} // RVA: 0x7ffaa86491d0
        public void get_lastFingerSplays(){} // RVA: 0x7ffaa86491d0
    }

    public class ISteamVR_Action_Source
    {
        // ── Original Methods ──
        public void get_active(){} // RVA: 0x7ffaa864a040
        public void get_activeBinding(){} // RVA: 0x7ffaa864a040
        public void get_lastActive(){} // RVA: 0x7ffaa864a040
        public void get_lastActiveBinding(){} // RVA: 0x7ffaa864a040
        public void get_fullPath(){} // RVA: 0x7ffaa86491d0
        public void get_handle(){} // RVA: 0x7ffaa86491d0
        public void get_actionSet(){} // RVA: 0x7ffaa86491d0
        public void get_direction(){} // RVA: 0x7ffaa8649ca0
    }

    public class ISteamVR_Action_Vector2
    {
        // ── Original Methods ──
        public void get_axis(){} // RVA: 0x7ffaa86491d0
        public void get_lastAxis(){} // RVA: 0x7ffaa86491d0
        public void get_delta(){} // RVA: 0x7ffaa86491d0
        public void get_lastDelta(){} // RVA: 0x7ffaa86491d0
    }

    public class ISteamVR_Action_Vector3
    {
        // ── Original Methods ──
        public void get_axis(){} // RVA: 0x7ffaa8648be0
        public void get_lastAxis(){} // RVA: 0x7ffaa8648be0
        public void get_delta(){} // RVA: 0x7ffaa8648be0
        public void get_lastDelta(){} // RVA: 0x7ffaa8648be0
    }

    public class IVRApplications : ValueType
    {
        public object IsApplicationInstalled; // 0x34B8F9F0
        public object GetApplicationKeyByProcessId; // 0x34B8F9F0
        public object LaunchApplicationFromMimeType; // 0x34B8F9F0
        public object IdentifyApplication; // 0x34B8F9F0
        public object GetApplicationPropertyString; // 0x34B8F9F0
        public object SetApplicationAutoLaunch; // 0x34B8F9F0
        public object GetDefaultApplicationForMimeType; // 0x34B8F9F0
        public object GetApplicationLaunchArguments; // 0x34B8F9F0
        public object PerformApplicationPrelaunchCheck; // 0x34B8F9F0
        public object GetCurrentSceneProcessId; // 0x34B8F9F0
    }

    public class IVRBlockQueue : ValueType
    {
        public object Destroy; // 0x34BECF30
        public object WaitAndAcquireReadOnlyBlock; // 0x34BECF30
        public object QueueHasReader; // 0x34BECF30
    }

    public class IVRChaperone : ValueType
    {
        public object GetPlayAreaRect; // 0x34B8FDB0
        public object GetBoundsColor; // 0x34B8FDB0
        public object ResetZeroPose; // 0x34B8FDB0
        public object .ctor; // 0xB3F6FFF0
    }

    public class IVRChaperoneSetup : ValueType
    {
        public object GetWorkingPlayAreaSize; // 0x34B9D6B0
        public object GetLiveCollisionBoundsInfo; // 0x34B9D6B0
        public object SetWorkingPlayAreaSize; // 0x34B9D6B0
        public object SetWorkingSeatedZeroPoseToRawTrackingPose; // 0x34B9D6B0
        public object GetLiveSeatedZeroPoseToRawTrackingPose; // 0x34B9D6B0
        public object ShowWorkingSetPreview; // 0x34B9D6B0
        public object Invoke; // 0xB3F6FFF0
    }

    public class IVRCompositor : ValueType
    {
        public object WaitGetPoses; // 0x34BA46F0
        public object Submit; // 0x34BA46F0
        public object PostPresentHandoff; // 0x34BA46F0
        public object GetFrameTimeRemaining; // 0x34BA46F0
        public object GetCurrentFadeColor; // 0x34BA46F0
        public object SetSkyboxOverride; // 0x34BA46F0
        public object CompositorGoToBack; // 0x34BA46F0
        public object GetCurrentSceneFocusProcess; // 0x34BA46F0
        public object ShowMirrorWindow; // 0x34BA46F0
        public object CompositorDumpImages; // 0x34BA46F0
        public object ForceReconnectProcess; // 0x34BA46F0
        public object ReleaseMirrorTextureD3D11; // 0x34BA46F0
        public object LockGLSharedTextureForAccess; // 0x34BA46F0
        public object GetVulkanDeviceExtensionsRequired; // 0x34BA46F0
        public object IsMotionSmoothingEnabled; // 0x34BA46F0
        public object SetStageOverride_Async; // 0x34BA46F0
        public object GetLastPosePredictionIDs; // 0x34BA46F0
    }

    public class IVRDebug : ValueType
    {
        public object FinishVrProfilerEvent; // 0x34BE6EB0
    }

    public class IVRDriverManager : ValueType
    {
        public object GetDriverHandle; // 0x34BDC030
    }

    public class IVRExtendedDisplay : ValueType
    {
        public object GetDXGIOutputInfo; // 0x34B5FDB0
    }

    public class IVRHeadsetView : ValueType
    {
        public object SetHeadsetViewMode; // 0x34BCC4B0
        public object GetHeadsetViewCropped; // 0x34BCC4B0
        public object GetHeadsetViewBlendRange; // 0x34BCC4B0
        public object .ctor; // 0xB3F6FFF0
    }

    public class IVRIOBuffer : ValueType
    {
        public object Read; // 0x34BDFDB0
        public object HasReaders; // 0x34BDFDB0
    }

    public class IVRInput : ValueType
    {
        public object GetActionHandle; // 0x34BDCAB0
        public object GetDigitalActionData; // 0x34BDCAB0
        public object GetPoseActionDataForNextFrame; // 0x34BDCAB0
        public object SetDominantHand; // 0x34BDCAB0
        public object GetBoneName; // 0x34BDCAB0
        public object GetSkeletalBoneData; // 0x34BDCAB0
        public object DecompressSkeletalBoneData; // 0x34BDCAB0
        public object GetOriginLocalizedName; // 0x34BDCAB0
        public object ShowActionOrigins; // 0x34BDCAB0
        public object IsUsingLegacyInput; // 0x34BDCAB0
        public object Invoke; // 0xB3F59940
    }

    public class IVRNotifications : ValueType
    {
    }

    public class IVROverlay : ValueType
    {
        public object DestroyOverlay; // 0x34BB4030
        public object SetOverlayName; // 0x34BB4030
        public object SetOverlayRenderingPid; // 0x34BB4030
        public object GetOverlayFlag; // 0x34BB4030
        public object GetOverlayColor; // 0x34BB4030
        public object SetOverlayTexelAspect; // 0x34BB4030
        public object GetOverlaySortOrder; // 0x34BB4030
        public object SetOverlayCurvature; // 0x34BB4030
        public object GetOverlayPreCurvePitch; // 0x34BB4030
        public object SetOverlayTextureBounds; // 0x34BB4030
        public object SetOverlayTransformAbsolute; // 0x34BB4030
        public object GetOverlayTransformTrackedDeviceRelative; // 0x34BB4030
        public object SetOverlayTransformCursor; // 0x34BB4030
        public object ShowOverlay; // 0x34BB4030
        public object GetTransformForOverlayCoordinates; // 0x34BB4030
        public object GetOverlayInputMethod; // 0x34BB4030
        public object SetOverlayMouseScale; // 0x34BB4030
        public object SetOverlayIntersectionMask; // 0x34BB4030
        public object SetOverlayCursorPositionOverride; // 0x34BB4030
        public object ClearOverlayTexture; // 0x34BB4030
        public object GetOverlayTexture; // 0x34BB4030
        public object CreateDashboardOverlay; // 0x34BB4030
        public object SetDashboardOverlaySceneProcess; // 0x34BB4030
        public object GetPrimaryDashboardDevice; // 0x34BB4030
        public object GetKeyboardText; // 0x34BB4030
        public object SetKeyboardPositionForOverlay; // 0x34BB4030
        public object Invoke; // 0xB3F81030
        public object .ctor; // 0xB3F6FFF0
    }

    public class IVROverlayView : ValueType
    {
        public object PostOverlayEvent; // 0x34BC7870
    }

    public class IVRPaths : ValueType
    {
        public object StringToHandle; // 0x34BEC4B0
    }

    public class IVRProperties : ValueType
    {
        public object GetPropErrorNameFromEnum; // 0x34BE7930
    }

    public class IVRRenderModels : ValueType
    {
        public object LoadTexture_Async; // 0x34BCDA70
        public object LoadIntoTextureD3D11_Async; // 0x34BCDA70
        public object GetRenderModelCount; // 0x34BCDA70
        public object GetComponentButtonMask; // 0x34BCDA70
        public object GetComponentState; // 0x34BCDA70
        public object GetRenderModelOriginalPath; // 0x34BCDA70
        public object `;
    }

    public class IVRResources : ValueType
    {
    }

    public class IVRScreenshots : ValueType
    {
        public object GetScreenshotPropertyType; // 0x34BD67F0
        public object TakeStereoScreenshot; // 0x34BD67F0
    }

    public class IVRSettings : ValueType
    {
        public object SetInt32; // 0x34BD4DB0
        public object GetBool; // 0x34BD4DB0
        public object GetString; // 0x34BD4DB0
    }

    public class IVRSpatialAnchors : ValueType
    {
        public object GetSpatialAnchorPose; // 0x34BE6430
    }

    public class IVRSystem : ValueType
    {
        public object GetProjectionRaw; // 0x336CD6A0
        public object GetTimeSinceLastVsync; // 0x336CD6A0
        public object GetOutputDevice; // 0x336CD6A0
        public object GetDeviceToAbsoluteTrackingPose; // 0x336CD6A0
        public object GetSortedTrackedDeviceIndicesOfClass; // 0x336CD6A0
        public object GetTrackedDeviceIndexForControllerRole; // 0x336CD6A0
        public object IsTrackedDeviceConnected; // 0x336CD6A0
        public object GetInt32TrackedDeviceProperty; // 0x336CD6A0
        public object GetArrayTrackedDeviceProperty; // 0x336CD6A0
        public object PollNextEvent; // 0x336CD6A0
        public object GetHiddenAreaMesh; // 0x336CD6A0
        public object TriggerHapticPulse; // 0x336CD6A0
        public object IsInputAvailable; // 0x336CD6A0
        public object ShouldApplicationReduceRenderingWork; // 0x336CD6A0
        public object GetAppContainerFilePaths; // 0x336CD6A0
    }

    public class IVRTrackedCamera : ValueType
    {
        public object GetCameraFrameSize; // 0x34B8D8F0
        public object AcquireVideoStreamingService; // 0x34B8D8F0
        public object GetVideoStreamTextureSize; // 0x34B8D8F0
        public object ReleaseVideoStreamTextureGL; // 0x34B8D8F0
    }

    public class ImuSample_t : ValueType
    {
        public object vGyro; // 0x34C1D830
    }

    public class InputAnalogActionData_t : ValueType
    {
        public object x; // 0x34C1F7B0
        public object deltaX; // 0x34C1F7B0
        public object fUpdateTime; // 0x34C1F7B0
    }

    public class InputBindingInfo_t : ValueType
    {
        public object rchDevicePathName2; // 0x34C24030
        public object rchDevicePathName5; // 0x34C24030
        public object rchDevicePathName8; // 0x34C24030
        public object rchDevicePathName11; // 0x34C24030
        public object rchDevicePathName14; // 0x34C24030
        public object rchDevicePathName17; // 0x34C24030
        public object rchDevicePathName20; // 0x34C24030
        public object rchDevicePathName23; // 0x34C24030
        public object rchDevicePathName26; // 0x34C24030
        public object rchDevicePathName29; // 0x34C24030
        public object rchDevicePathName32; // 0x34C24030
        public object rchDevicePathName35; // 0x34C24030
        public object rchDevicePathName38; // 0x34C24030
        public object rchDevicePathName41; // 0x34C24030
        public object rchDevicePathName44; // 0x34C24030
        public object rchDevicePathName47; // 0x34C24030
        public object rchDevicePathName50; // 0x34C24030
        public object rchDevicePathName53; // 0x34C24030
        public object rchDevicePathName56; // 0x34C24030
        public object rchDevicePathName59; // 0x34C24030
        public object rchDevicePathName62; // 0x34C24030
        public object rchDevicePathName65; // 0x34C24030
        public object rchDevicePathName68; // 0x34C24030
        public object rchDevicePathName71; // 0x34C24030
        public object rchDevicePathName74; // 0x34C24030
        public object rchDevicePathName77; // 0x34C24030
        public object rchDevicePathName80; // 0x34C24030
        public object rchDevicePathName83; // 0x34C24030
        public object rchDevicePathName86; // 0x34C24030
        public object rchDevicePathName89; // 0x34C24030
        public object rchDevicePathName92; // 0x34C24030
        public object rchDevicePathName95; // 0x34C24030
        public object rchDevicePathName98; // 0x34C24030
        public object rchDevicePathName101; // 0x34C24030
        public object rchDevicePathName104; // 0x34C24030
        public object rchDevicePathName107; // 0x34C24030
        public object rchDevicePathName110; // 0x34C24030
        public object rchDevicePathName113; // 0x34C24030
        public object rchDevicePathName116; // 0x34C24030
        public object rchDevicePathName119; // 0x34C24030
        public object rchDevicePathName122; // 0x34C24030
        public object rchDevicePathName125; // 0x34C24030
        public object rchInputPathName0; // 0x34C24030
        public object rchInputPathName3; // 0x34C24030
        public object rchInputPathName6; // 0x34C24030
        public object rchInputPathName9; // 0x34C24030
        public object rchInputPathName12; // 0x34C24030
        public object rchInputPathName15; // 0x34C24030
        public object rchInputPathName18; // 0x34C24030
        public object rchInputPathName21; // 0x34C24030
        public object rchInputPathName24; // 0x34C24030
        public object rchInputPathName27; // 0x34C24030
        public object rchInputPathName30; // 0x34C24030
        public object rchInputPathName33; // 0x34C24030
        public object rchInputPathName36; // 0x34C24030
        public object rchInputPathName39; // 0x34C24030
        public object rchInputPathName42; // 0x34C24030
        public object rchInputPathName45; // 0x34C24030
        public object rchInputPathName48; // 0x34C24030
        public object rchInputPathName51; // 0x34C24030
        public object rchInputPathName54; // 0x34C24030
        public object rchInputPathName57; // 0x34C24030
        public object rchInputPathName60; // 0x34C24030
        public object rchInputPathName63; // 0x34C24030
        public object rchInputPathName66; // 0x34C24030
        public object rchInputPathName69; // 0x34C24030
        public object rchInputPathName72; // 0x34C24030
        public object rchInputPathName75; // 0x34C24030
        public object rchInputPathName78; // 0x34C24030
        public object rchInputPathName81; // 0x34C24030
        public object rchInputPathName84; // 0x34C24030
        public object rchInputPathName87; // 0x34C24030
        public object rchInputPathName90; // 0x34C24030
        public object rchInputPathName93; // 0x34C24030
        public object rchInputPathName96; // 0x34C24030
        public object rchInputPathName99; // 0x34C24030
        public object rchInputPathName102; // 0x34C24030
        public object rchInputPathName105; // 0x34C24030
        public object rchInputPathName108; // 0x34C24030
        public object rchInputPathName111; // 0x34C24030
        public object rchInputPathName114; // 0x34C24030
        public object rchInputPathName117; // 0x34C24030
        public object rchInputPathName120; // 0x34C24030
        public object rchInputPathName123; // 0x34C24030
        public object rchInputPathName126; // 0x34C24030
        public object rchModeName1; // 0x34C24030
        public object rchModeName4; // 0x34C24030
        public object rchModeName7; // 0x34C24030
        public object rchModeName10; // 0x34C24030
        public object rchModeName13; // 0x34C24030
        public object rchModeName16; // 0x34C24030
        public object rchModeName19; // 0x34C24030
        public object rchModeName22; // 0x34C24030
        public object rchModeName25; // 0x34C24030
        public object rchModeName28; // 0x34C24030
        public object rchModeName31; // 0x34C24030
        public object rchModeName34; // 0x34C24030
        public object rchModeName37; // 0x34C24030
        public object rchModeName40; // 0x34C24030
        public object rchModeName43; // 0x34C24030
        public object rchModeName46; // 0x34C24030
        public object rchModeName49; // 0x34C24030
        public object rchModeName52; // 0x34C24030
        public object rchModeName55; // 0x34C24030
        public object rchModeName58; // 0x34C24030
        public object rchModeName61; // 0x34C24030
        public object rchModeName64; // 0x34C24030
        public object rchModeName67; // 0x34C24030
        public object rchModeName70; // 0x34C24030
        public object rchModeName73; // 0x34C24030
        public object rchModeName76; // 0x34C24030
        public object rchModeName79; // 0x34C24030
        public object rchModeName82; // 0x34C24030
        public object rchModeName85; // 0x34C24030
        public object rchModeName88; // 0x34C24030
        public object rchModeName91; // 0x34C24030
        public object rchModeName94; // 0x34C24030
        public object rchModeName97; // 0x34C24030
        public object rchModeName100; // 0x34C24030
        public object rchModeName103; // 0x34C24030
        public object rchModeName106; // 0x34C24030
        public object rchModeName109; // 0x34C24030
        public object rchModeName112; // 0x34C24030
        public object rchModeName115; // 0x34C24030
        public object rchModeName118; // 0x34C24030
        public object rchModeName121; // 0x34C24030
        public object rchModeName124; // 0x34C24030
        public object rchModeName127; // 0x34C24030
        public object rchSlotName2; // 0x34C24030
        public object rchSlotName5; // 0x34C24030
        public object rchSlotName8; // 0x34C24030
        public object rchSlotName11; // 0x34C24030
        public object rchSlotName14; // 0x34C24030
        public object rchSlotName17; // 0x34C24030
        public object rchSlotName20; // 0x34C24030
        public object rchSlotName23; // 0x34C24030
        public object rchSlotName26; // 0x34C24030
        public object rchSlotName29; // 0x34C24030
        public object rchSlotName32; // 0x34C24030
        public object rchSlotName35; // 0x34C24030
        public object rchSlotName38; // 0x34C24030
        public object rchSlotName41; // 0x34C24030
        public object rchSlotName44; // 0x34C24030
        public object rchSlotName47; // 0x34C24030
        public object rchSlotName50; // 0x34C24030
        public object rchSlotName53; // 0x34C24030
        public object rchSlotName56; // 0x34C24030
        public object rchSlotName59; // 0x34C24030
        public object rchSlotName62; // 0x34C24030
        public object rchSlotName65; // 0x34C24030
        public object rchSlotName68; // 0x34C24030
        public object rchSlotName71; // 0x34C24030
        public object rchSlotName74; // 0x34C24030
        public object rchSlotName77; // 0x34C24030
        public object rchSlotName80; // 0x34C24030
        public object rchSlotName83; // 0x34C24030
        public object rchSlotName86; // 0x34C24030
        public object rchSlotName89; // 0x34C24030
        public object rchSlotName92; // 0x34C24030
        public object rchSlotName95; // 0x34C24030
        public object rchSlotName98; // 0x34C24030
        public object rchSlotName101; // 0x34C24030
        public object rchSlotName104; // 0x34C24030
        public object rchSlotName107; // 0x34C24030
        public object rchSlotName110; // 0x34C24030
        public object rchSlotName113; // 0x34C24030
        public object rchSlotName116; // 0x34C24030
        public object rchSlotName119; // 0x34C24030
        public object rchSlotName122; // 0x34C24030
        public object rchSlotName125; // 0x34C24030
        public object rchInputSourceType0; // 0x34C24030
        public object rchInputSourceType3; // 0x34C24030
        public object rchInputSourceType6; // 0x34C24030
        public object rchInputSourceType9; // 0x34C24030
        public object rchInputSourceType12; // 0x34C24030
        public object rchInputSourceType15; // 0x34C24030
        public object rchInputSourceType18; // 0x34C24030
        public object rchInputSourceType21; // 0x34C24030
        public object rchInputSourceType24; // 0x34C24030
        public object rchInputSourceType27; // 0x34C24030
        public object rchInputSourceType30; // 0x34C24030
        public object flFingerCurl2; // 0x34C24330
        public object flFingerSplay0; // 0x34C24330
        public object flFingerSplay3; // 0x34C24330
        public object m_pVRChaperone; // 0x34C24630
        public object m_pVRHeadsetView; // 0x34C24630
        public object m_pVRResources; // 0x34C24630
        public object m_pVRSettings; // 0x34C24630
        public object m_pVRScreenshots; // 0x34C24630
        public object m_pVRIOBuffer; // 0x34C24630
        public object m_pVRNotifications; // 0x34C24630
        public object Pʧf; // 0x67389F04
        public object pvBuffer; // 0x34C24930
        public object unRequiredBufferSize; // 0x34C24930
        public object ulPath; // 0x34C24C30
        public object pvBuffer; // 0x34C24C30
        public object eError; // 0x34C24C30
        public object Pʧf; // 0x67389F04
        public object VRSystem; // 0xB3F64BE0
        public object VROverlayView; // 0xB3F64B70
        public object h§f; // 0x34C24F30
        public object +[;
        public object VRTrackedCamera; // 0xB3F64BA0
        public object xħf; // 0x34C24F30

        // ── Original Methods ──
        public void get_rchDevicePathName(){} // RVA: 0x7ffaaf222dc0
        public void get_rchInputPathName(){} // RVA: 0x7ffaaf223830
        public void get_rchModeName(){} // RVA: 0x7ffaaf224420
        public void get_rchSlotName(){} // RVA: 0x7ffaaf225010
        public void get_rchInputSourceType(){} // RVA: 0x7ffaaf225c00
    }

    public class InputDigitalActionData_t : ValueType
    {
        public object bState; // 0x34C1F930
    }

    public class InputOriginInfo_t : ValueType
    {
        public object rchRenderModelComponentName0; // 0x34C1FDB0
        public object rchRenderModelComponentName3; // 0x34C1FDB0
        public object rchRenderModelComponentName6; // 0x34C1FDB0
        public object rchRenderModelComponentName9; // 0x34C1FDB0
        public object rchRenderModelComponentName12; // 0x34C1FDB0
        public object rchRenderModelComponentName15; // 0x34C1FDB0
        public object rchRenderModelComponentName18; // 0x34C1FDB0
        public object rchRenderModelComponentName21; // 0x34C1FDB0
        public object rchRenderModelComponentName24; // 0x34C1FDB0
        public object rchRenderModelComponentName27; // 0x34C1FDB0
        public object rchRenderModelComponentName30; // 0x34C1FDB0
        public object rchRenderModelComponentName33; // 0x34C1FDB0
        public object rchRenderModelComponentName36; // 0x34C1FDB0
        public object rchRenderModelComponentName39; // 0x34C1FDB0
        public object rchRenderModelComponentName42; // 0x34C1FDB0
        public object rchRenderModelComponentName45; // 0x34C1FDB0
        public object rchRenderModelComponentName48; // 0x34C1FDB0
        public object rchRenderModelComponentName51; // 0x34C1FDB0
        public object rchRenderModelComponentName54; // 0x34C1FDB0
        public object rchRenderModelComponentName57; // 0x34C1FDB0
        public object rchRenderModelComponentName60; // 0x34C1FDB0
        public object rchRenderModelComponentName63; // 0x34C1FDB0
        public object rchRenderModelComponentName66; // 0x34C1FDB0
        public object rchRenderModelComponentName69; // 0x34C1FDB0
        public object rchRenderModelComponentName72; // 0x34C1FDB0
        public object rchRenderModelComponentName75; // 0x34C1FDB0
        public object rchRenderModelComponentName78; // 0x34C1FDB0
        public object rchRenderModelComponentName81; // 0x34C1FDB0
        public object rchRenderModelComponentName84; // 0x34C1FDB0
        public object rchRenderModelComponentName87; // 0x34C1FDB0
        public object rchRenderModelComponentName90; // 0x34C1FDB0
        public object rchRenderModelComponentName93; // 0x34C1FDB0
        public object rchRenderModelComponentName96; // 0x34C1FDB0
        public object rchRenderModelComponentName99; // 0x34C1FDB0
        public object rchRenderModelComponentName102; // 0x34C1FDB0
        public object rchRenderModelComponentName105; // 0x34C1FDB0
        public object rchRenderModelComponentName108; // 0x34C1FDB0
        public object rchRenderModelComponentName111; // 0x34C1FDB0
        public object rchRenderModelComponentName114; // 0x34C1FDB0
        public object rchRenderModelComponentName117; // 0x34C1FDB0
        public object rchRenderModelComponentName120; // 0x34C1FDB0
        public object rchRenderModelComponentName123; // 0x34C1FDB0
        public object rchRenderModelComponentName126; // 0x34C1FDB0
        public object get_rchModeName; // 0xB41F4950

        // ── Original Methods ──
        public void get_rchRenderModelComponentName(){} // RVA: 0x7ffaaf222320
    }

    public class InputPoseActionData_t : ValueType
    {
        public object pose; // 0x34C1FAB0
    }

    public class InputSkeletalActionData_t : ValueType
    {
    }

    public class IntersectionMaskCircle_t : ValueType
    {
        public object m_flRadius; // 0x34C1E2B0
    }

    public class IntersectionMaskRectangle_t : ValueType
    {
        public object m_flWidth; // 0x34C1E130
        public object m_flCenterY; // 0x34C1E2B0
    }

}