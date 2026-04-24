// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Valve.Valve.VR
// Classes: 55
// Methods: 5

namespace ThirdParty.Valve.Valve.VR
{
    public class VRActiveActionSet_t : ValueType
    {
        public object ulSecondaryActionSet; // 0x34C241B0
        public object 8؏f; // 0x6743CF06
    }

    public class VRBoneTransform_t : ValueType
    {
    }

    public class VRControllerAxis_t : ValueType
    {
    }

    public class VRControllerState_t : ValueType
    {
        public object ulButtonTouched; // 0x34C1CF30
        public object rAxis2; // 0x34C1CF30
    }

    public class VRControllerState_t_Packed : ValueType
    {
        public object ulButtonTouched; // 0x34C1D0B0
        public object rAxis2; // 0x34C1D0B0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3a7030
        public void Unpack(){} // RVA: 0x7ffaae3a7060
    }

    public class VREvent_ApplicationLaunch_t : ValueType
    {
        public object overlayHandle; // 0x34C171B0
    }

    public class VREvent_AudioMuteControl_t : ValueType
    {
    }

    public class VREvent_AudioVolumeControl_t : ValueType
    {
    }

    public class VREvent_Chaperone_t : ValueType
    {
        public object m_nFidelityLevel; // 0x34C16A30
    }

    public class VREvent_Controller_t : ValueType
    {
    }

    public class VREvent_Data_t : ValueType
    {
        public object mouse; // 0x34C07E00
        public object notification; // 0x34C07E00
        public object ipd; // 0x34C07E00
        public object touchPadMove; // 0x34C07E00
        public object screenshotProgress; // 0x34C07E00
        public object messageOverlay; // 0x34C07E00
        public object webConsole; // 0x34C07E00
        public object actionManifest; // 0x34C07E00
        public object showDevTools; // 0x34C07E00
        public object audioMuteControl; // 0x34C07E00
        public object reserved1; // 0x34C168B0
        public object reserved4; // 0x34C168B0
        public object x; // 0x34C159B0
        public object cursorIndex; // 0x34C159B0
        public object unused; // 0x34C15B30
    }

    public class VREvent_EditingCameraSurface_t : ValueType
    {
        public object unVRMessageOverlayResponse; // 0x34C17330
    }

    public class VREvent_HDCPError_t : ValueType
    {
    }

    public class VREvent_HapticVibration_t : ValueType
    {
        public object fDurationSeconds; // 0x34C17630
        public object webConsoleHandle; // 0x34C177B0
    }

    public class VREvent_InputActionManifestLoad_t : ValueType
    {
        public object pathMessageParam; // 0x34C17AB0
        public object pathDevice; // 0x34C17DB0
    }

    public class VREvent_InputBindingLoad_t : ValueType
    {
        public object pathUrl; // 0x34C17930
        public object pathAppKey; // 0x34C17AB0
    }

    public class VREvent_Ipd_t : ValueType
    {
    }

    public class VREvent_Keyboard_t : ValueType
    {
        public object cNewInput2; // 0x34C16430
        public object cNewInput5; // 0x34C16430
        public object uUserValue; // 0x34C16430

        // ── Original Methods ──
        public void get_cNewInput(){} // RVA: 0x7ffaaf222150
    }

    public class VREvent_MessageOverlay_t : ValueType
    {
    }

    public class VREvent_Mouse_t : ValueType
    {
        public object button; // 0x34C159B0
        public object ydelta; // 0x34C15B30
    }

    public class VREvent_Notification_t : ValueType
    {
        public object overlayHandle; // 0x34C16130
    }

    public class VREvent_Overlay_t : ValueType
    {
        public object memoryBlockId; // 0x34C16130
        public object ipdMeters; // 0x34C165B0
    }

    public class VREvent_PerformanceTest_t : ValueType
    {
    }

    public class VREvent_Process_t : ValueType
    {
        public object bForced; // 0x34C15FB0
        public object notificationId; // 0x34C15E30
    }

    public class VREvent_ProgressUpdate_t : ValueType
    {
        public object pathInputSource; // 0x34C17DB0
        public object fProgress; // 0x34C17DB0
        public object eCode; // 0x34C1C330
    }

    public class VREvent_Property_t : ValueType
    {
        public object containerHandle; // 0x34C17630
    }

    public class VREvent_Reserved_t : ValueType
    {
        public object reserved2; // 0x34C168B0
        public object reserved5; // 0x34C168B0
        public object y; // 0x34C159B0
    }

    public class VREvent_ScreenshotProgress_t : ValueType
    {
    }

    public class VREvent_Screenshot_t : ValueType
    {
        public object progress; // 0x34C16EB0
    }

    public class VREvent_Scroll_t : ValueType
    {
        public object unused; // 0x34C15B30
        public object pid; // 0x34C15FB0
    }

    public class VREvent_SeatedZeroPoseReset_t : ValueType
    {
    }

    public class VREvent_ShowDevTools_t : ValueType
    {
    }

    public class VREvent_ShowUI_t : ValueType
    {
    }

    public class VREvent_SpatialAnchor_t : ValueType
    {
    }

    public class VREvent_Status_t : ValueType
    {
    }

    public class VREvent_TouchPadMove_t : ValueType
    {
        public object fValueXFirst; // 0x34C15CB0
        public object fValueYRaw; // 0x34C15CB0
        public object type; // 0x34C16D30
    }

    public class VREvent_WebConsole_t : ValueType
    {
    }

    public class VREvent_t : ValueType
    {
        public object eventAgeSeconds; // 0x34C1C7B0
    }

    public class VREvent_t_Packed : ValueType
    {
        public object eventAgeSeconds; // 0x34C1C930

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf222260
        public void Unpack(){} // RVA: 0x7ffaaf222290
    }

    public class VRNativeDevice_t : ValueType
    {
    }

    public class VROverlayIntersectionMaskPrimitive_Data_t : ValueType
    {
        public object m_flTopLeftX; // 0x34C1E130
    }

    public class VROverlayIntersectionMaskPrimitive_t : ValueType
    {
    }

    public class VROverlayIntersectionParams_t : ValueType
    {
        public object eOrigin; // 0x34C1DE30
    }

    public class VROverlayIntersectionResults_t : ValueType
    {
        public object vUVs; // 0x34C1DFB0
    }

    public class VROverlayProjection_t : ValueType
    {
        public object fTop; // 0x34C1E5B0
    }

    public class VROverlayView_t : ValueType
    {
        public object textureBounds; // 0x34C1E730
    }

    public class VRSkeletalSummaryData_t : ValueType
    {
        public object flFingerCurl2; // 0x34C24330
        public object flFingerSplay0; // 0x34C24330
        public object flFingerSplay3; // 0x34C24330
        public object m_pVRChaperone; // 0x34C24630
    }

    public class VRTextureBounds_t : ValueType
    {
        public object uMax; // 0x34C14AB0
    }

    public class VRTextureDepthInfo_t : ValueType
    {
        public object vRange; // 0x34C14DB0
    }

    public class VRTextureWithDepth_t : ValueType
    {
        public object eColorSpace; // 0x34C14F30
    }

    public class VRTextureWithPoseAndDepth_t : ValueType
    {
        public object eColorSpace; // 0x34C150B0
    }

    public class VRTextureWithPose_t : ValueType
    {
        public object eColorSpace; // 0x34C14C30
    }

    public class VRVulkanDevice_t : ValueType
    {
        public object m_pPhysicalDevice; // 0x34C1E8B0
        public object (ۧf; // 0x673866CA
    }

    public class VRVulkanTextureArrayData_t : ValueType
    {
    }

    public class VRVulkanTextureData_t : ValueType
    {
        public object m_pPhysicalDevice; // 0x34C153B0
        public object m_nQueueFamilyIndex; // 0x34C153B0
        public object m_nFormat; // 0x34C153B0
    }

}