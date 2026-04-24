// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 2
// Methods: 46

namespace ThirdParty.Valve.Valve.VR
{
    public class OpenVR : Object
    {
        public object k_unTrackedDeviceIndex_Hmd; // 0x34C250B0
        public object k_unTrackedDeviceIndexInvalid; // 0x34C250B0
        public object k_ulInvalidDriverHandle; // 0x34C250B0
        public object k_unUint64PropertyTag; // 0x34C250B0
        public object k_unErrorPropertyTag; // 0x34C250B0
        public object k_unHmdMatrix44PropertyTag; // 0x34C250B0
        public object k_unHmdVector2PropertyTag; // 0x34C250B0
        public object k_unPathHandleInfoTag; // 0x34C250B0
        public object k_unWildcardPropertyTag; // 0x34C250B0
        public object k_unSpatialAnchorPosePropertyTag; // 0x34C250B0
        public object k_unOpenVRInternalReserved_Start; // 0x34C250B0
        public object k_ulInvalidActionHandle; // 0x34C250B0
        public object k_unControllerStateAxisCount; // 0x34C250B0
        public object k_unScreenshotHandleInvalid; // 0x34C250B0
        public object IVRTrackedCamera_Version; // 0x34C250B0
        public object k_pch_MimeType_GameTheater; // 0x34C250B0
        public object IVRChaperoneSetup_Version; // 0x34C250B0
        public object k_unVROverlayMaxNameLength; // 0x34C250B0
        public object IVROverlay_Version; // 0x34C250B0
        public object k_unHeadsetViewMaxHeight; // 0x34C250B0
        public object k_pch_Controller_Component_GDC2015; // 0x34C250B0
        public object k_pch_Controller_Component_OpenXR_Aim; // 0x34C250B0
        public object k_pch_Controller_Component_OpenXR_HandModel; // 0x34C250B0
        public object k_unNotificationTextMaxSize; // 0x34C250B0
        public object IVRSettings_Version; // 0x34C250B0
        public object k_pch_SteamVR_ForcedDriverKey_String; // 0x34C250B0
        public object k_pch_SteamVR_DebugProcessPipe_String; // 0x34C250B0
        public object k_pch_SteamVR_SendSystemButtonToAllApps_Bool; // 0x34C250B0
        public object k_pch_SteamVR_Background_String; // 0x34C250B0
        public object k_pch_SteamVR_BackgroundDomeRadius_Float; // 0x34C250B0
        public object k_pch_SteamVR_TrackingLossColor_String; // 0x34C250B0
        public object k_pch_SteamVR_ActivateMultipleDrivers_Bool; // 0x34C250B0
        public object k_pch_SteamVR_BaseStationPowerManagement_Int32; // 0x34C250B0
        public object k_pch_SteamVR_SupersampleScale_Float; // 0x34C250B0
        public object k_pch_SteamVR_MotionSmoothingOverride_Int32; // 0x34C250B0
        public object k_pch_SteamVR_WorldScale_Float; // 0x34C250B0
        public object k_pch_SteamVR_DisableAsyncReprojection_Bool; // 0x34C250B0
        public object k_pch_SteamVR_ShowLegacyMirrorView_Bool; // 0x34C250B0
        public object k_pch_SteamVR_MirrorViewEye_Int32; // 0x34C250B0
        public object k_pch_SteamVR_PerfGraphVisibility_Bool; // 0x34C250B0
        public object k_pch_SteamVR_StartDashboardFromAppLaunch_Bool; // 0x34C250B0
        public object k_pch_SteamVR_CycleBackgroundImageTimeSec_Int32; // 0x34C250B0
        public object k_pch_SteamVR_AllowSupersampleFiltering_Bool; // 0x34C250B0
        public object k_pch_SteamVR_AllowDisplayLockedMode_Bool; // 0x34C250B0
        public object k_pch_SteamVR_DebugInputBinding; // 0x34C250B0
        public object k_pch_SteamVR_EnableSafeMode; // 0x34C250B0
        public object k_pch_SteamVR_LastVersionNoticeDate; // 0x34C250B0
        public object k_pch_SteamVR_HmdDisplayColorGainB_Float; // 0x34C250B0
        public object k_pch_SteamVR_CustomIconForceUpdate_String; // 0x34C250B0
        public object k_pch_SteamVR_BlockOculusSDKOnOpenVRLaunchOption_Bool; // 0x34C250B0
        public object k_pch_SteamVR_DisplayPortTrainingMode_Int; // 0x34C250B0
        public object k_pch_OpenXR_Section; // 0x34C250B0
        public object k_pch_DirectMode_Enable_Bool; // 0x34C250B0
        public object k_pch_DirectMode_EdidPid_Int32; // 0x34C250B0
        public object k_pch_Lighthouse_DisableIMUExceptHMD_Bool; // 0x34C250B0
        public object k_pch_Lighthouse_PrimaryBasestation_Int32; // 0x34C250B0
        public object k_pch_Lighthouse_PowerManagedBaseStations_String; // 0x34C250B0
        public object k_pch_Lighthouse_EnableImuFallback_Bool; // 0x34C250B0
        public object k_pch_Null_ModelNumber_String; // 0x34C250B0
        public object k_pch_Null_WindowWidth_Int32; // 0x34C250B0
        public object k_pch_Null_RenderHeight_Int32; // 0x34C250B0
        public object k_pch_WindowsMR_Section; // 0x34C250B0
        public object k_pch_UserInterface_MinimizeToTray_Bool; // 0x34C250B0
        public object k_pch_UserInterface_ScreenshotType_Int; // 0x34C250B0
        public object k_pch_Keyboard_Section; // 0x34C250B0
        public object k_pch_Keyboard_ScaleY; // 0x34C250B0
        public object k_pch_Keyboard_OffsetY; // 0x34C250B0
        public object k_pch_Perf_PerfGraphInHMD_Bool; // 0x34C250B0
        public object k_pch_Perf_TestData_Float; // 0x34C250B0
        public object k_pch_CollisionBounds_Section; // 0x34C250B0
        public object k_pch_CollisionBounds_CenterMarkerOn_Bool; // 0x34C250B0
        public object k_pch_CollisionBounds_WallHeight_Float; // 0x34C250B0
        public object k_pch_CollisionBounds_ColorGammaB_Int32; // 0x34C250B0
        public object k_pch_Camera_Section; // 0x34C250B0
        public object k_pch_Camera_EnableCameraForCollisionBounds_Bool; // 0x34C250B0
        public object k_pch_Camera_BoundsColorGammaG_Int32; // 0x34C250B0
        public object k_pch_Camera_BoundsStrength_Int32; // 0x34C250B0
        public object k_pch_audio_SetOsDefaultPlaybackDevice_Bool; // 0x34C250B0
        public object k_pch_audio_PlaybackDeviceOverrideName_String; // 0x34C250B0
        public object k_pch_audio_RecordingDeviceOverride_String; // 0x34C250B0
        public object k_pch_audio_PlaybackMirrorDevice_String; // 0x34C250B0
        public object k_pch_audio_ActiveMirrorDevice_String; // 0x34C250B0
        public object k_pch_audio_VIVEHDMIGain; // 0x34C250B0
        public object k_pch_Power_Section; // 0x34C250B0
        public object k_pch_Power_TurnOffControllersTimeout_Float; // 0x34C250B0
        public object k_pch_Power_PauseCompositorOnStandby_Bool; // 0x34C250B0
        public object k_pch_Dashboard_ArcadeMode_Bool; // 0x34C250B0
        public object k_pch_Dashboard_DashboardScale; // 0x34C250B0
        public object k_pch_Dashboard_AllowSteamOverlays_Bool; // 0x34C250B0
        public object k_pch_Dashboard_SteamMatchesHMDFramerate; // 0x34C250B0
        public object k_pch_Driver_BlockedBySafemode_Bool; // 0x34C250B0
        public object k_pch_VRWebHelper_Section; // 0x34C250B0
        public object k_pch_TrackingOverride_Section; // 0x34C250B0
        public object k_pch_App_BindingSteamVRInputAPISuffix_String; // 0x34C250B0
        public object k_pch_App_BindingPreviousURLSuffix_String; // 0x34C250B0
        public object k_pch_App_BlockOculusSDK_Bool; // 0x34C250B0
        public object k_pch_LastKnown_Section; // 0x34C250B0
        public object k_pch_LastKnown_ActualHMDDriver_String; // 0x34C250B0
        public object k_pch_Input_LeftThumbstickRotation_Float; // 0x34C250B0
        public object k_pch_GpuSpeed_Section; // 0x34C250B0
        public object IVRDriverManager_Version; // 0x34C250B0
        public object k_unMaxActionOriginCount; // 0x34C250B0
        public object k_nActionSetOverlayGlobalPriorityMax; // 0x34C250B0
        public object k_ulInvalidIOBufferHandle; // 0x34C250B0
        public object IVRSpatialAnchors_Version; // 0x34C250B0
        public object IVRProperties_Version; // 0x34C250B0
        public object k_pchPathUserHandPrimary; // 0x34C250B0
        public object k_pchPathUserGamepad; // 0x34C250B0
        public object k_pchPathDevices; // 0x34C250B0
        public object k_pchPathBoundTrackerAliasPath; // 0x34C250B0
        public object k_pchPathPoseTip; // 0x34C250B0
        public object k_pchPathProximity; // 0x34C250B0
        public object k_pchPathBindingNameSuffix; // 0x34C250B0
        public object k_pchPathActiveActionSets; // 0x34C250B0
        public object k_pchPathUserFootRight; // 0x34C250B0
        public object k_pchPathUserElbowLeft; // 0x34C250B0
        public object k_pchPathUserKneeRight; // 0x34C250B0
        public object k_pchPathUserAnkleLeft; // 0x34C250B0
        public object k_pchPathUserChest; // 0x34C250B0
        public object k_pchPathClientAppKey; // 0x34C250B0
        public object IVRBlockQueue_Version; // 0x34C250B0
        public object _OpenVRInternal_ModuleContext; // 0x34C250B0
        public object VRToken; // 0x1700000A
        public object OpenVRInternal_ModuleContext; // 0x1700000B
        public object System; // 0x1700000C
        public object Chaperone; // 0x1700000D
        public object ChaperoneSetup; // 0x1700000E
        public object Compositor; // 0x1700000F
        public object HeadsetView; // 0x17000010
        public object Overlay; // 0x17000011
        public object OverlayView; // 0x17000012
        public object RenderModels; // 0x17000013
        public object ExtendedDisplay; // 0x17000014
        public object Settings; // 0x17000015
        public object Applications; // 0x17000016
        public object Screenshots; // 0x17000017
        public object TrackedCamera; // 0x17000018
        public object Input; // 0x17000019
        public object IOBuffer; // 0x1700001A
        public object SpatialAnchors; // 0x1700001B
        public object Notifications; // 0x1700001C
        public object Debug; // 0x1700001D
        public object FindMethod_Impl; // 0xB419A630
        public object m_InvokeArray; // 0x34B79B58
        public object UnityEngine.Events; // 0x345CDA40
        public object .ctor; // 0xB3F6FFF0
        public object Update; // 0xB3F6FFF0
        public object s; // 0x6852F680
        public object events; // 0x33BE6440
        public object vrEventSize; // 0x33BE6440
        public object debugLogAllEvents; // 0x33BE6440
        public object `;
        public object <GetType>b__2_1; // 0xB2DB2388

        // ── Original Methods ──
        public void InitInternal(){} // RVA: 0x7ffaaf221a20
        public void InitInternal2(){} // RVA: 0x7ffaaf221a60
        public void ShutdownInternal(){} // RVA: 0x7ffaaf221ae0
        public void IsHmdPresent(){} // RVA: 0x7ffaaf221b10
        public void IsRuntimeInstalled(){} // RVA: 0x7ffaaf221b40
        public void RuntimePath(){} // RVA: 0x7ffaaf225f20
        public void IsInterfaceVersionValid(){} // RVA: 0x7ffaaf221d80
        public void get_VRToken(){} // RVA: 0x7ffaaf2260f0
        public void set_VRToken(){} // RVA: 0x7ffaaf226130
        public void get_OpenVRInternal_ModuleContext(){} // RVA: 0x7ffaaf226170
        public void get_System(){} // RVA: 0x7ffaaf226270
        public void get_Chaperone(){} // RVA: 0x7ffaaf2262a0
        public void get_ChaperoneSetup(){} // RVA: 0x7ffaaf2262d0
        public void get_Compositor(){} // RVA: 0x7ffaaf226300
        public void get_HeadsetView(){} // RVA: 0x7ffaaf226330
        public void get_Overlay(){} // RVA: 0x7ffaaf226360
        public void get_OverlayView(){} // RVA: 0x7ffaaf226390
        public void get_RenderModels(){} // RVA: 0x7ffaaf2263c0
        public void get_ExtendedDisplay(){} // RVA: 0x7ffaaf2263f0
        public void get_Settings(){} // RVA: 0x7ffaaf226420
        public void get_Applications(){} // RVA: 0x7ffaaf226450
        public void get_Screenshots(){} // RVA: 0x7ffaaf226480
        public void get_TrackedCamera(){} // RVA: 0x7ffaaf2264b0
        public void get_Input(){} // RVA: 0x7ffaaf2264e0
        public void get_IOBuffer(){} // RVA: 0x7ffaaf226510
        public void get_SpatialAnchors(){} // RVA: 0x7ffaaf226540
        public void get_Notifications(){} // RVA: 0x7ffaaf226570
        public void get_Debug(){} // RVA: 0x7ffaaf2265a0
        public void Init(){} // RVA: 0x7ffaaf2265d0
        public void Shutdown(){} // RVA: 0x7ffaaf221ae0
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetStringForHmdError(){} // RVA: 0x7ffaaf226060
        public void GetGenericInterface(){} // RVA: 0x7ffaaf221d20
        public void GetInitToken(){} // RVA: 0x7ffaaf221de0
    }

    public class OpenVRInterop : Object
    {
        // ── Original Methods ──
        public void InitInternal(){} // RVA: 0x7ffaaf221a20
        public void InitInternal2(){} // RVA: 0x7ffaaf221a60
        public void ShutdownInternal(){} // RVA: 0x7ffaaf221ae0
        public void IsHmdPresent(){} // RVA: 0x7ffaaf221b10
        public void IsRuntimeInstalled(){} // RVA: 0x7ffaaf221b40
        public void RuntimePath(){} // RVA: 0x7ffaaf221b70
        public void IsInterfaceVersionValid(){} // RVA: 0x7ffaaf221d80
        public void .ctor(){} // RVA: 0x7ffaa8932310
        // ── Binary Analysis Named ──
        public void GetRuntimePath(){} // RVA: 0x7ffaaf221c20
        public void GetStringForHmdError(){} // RVA: 0x7ffaaf221cf0
        public void GetGenericInterface(){} // RVA: 0x7ffaaf221d20
        public void GetInitToken(){} // RVA: 0x7ffaaf221de0
    }

}