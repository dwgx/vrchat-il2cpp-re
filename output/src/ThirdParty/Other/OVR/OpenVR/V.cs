// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 44
// Methods: 5

namespace ThirdParty.Other.OVR.OpenVR
{
    public class VRActiveActionSet_t : ValueType
    {
        public ulong ulActionSet; // 0x10
        public ulong ulRestrictedToDevice; // 0x18
        public ulong ulSecondaryActionSet; // 0x20
        public uint unPadding; // 0x28
        public int nPriority; // 0x2C
    }

    public class VRBoneTransform_t : ValueType
    {
        public OVR.OpenVR.HmdVector4_t position; // 0x10
        public OVR.OpenVR.HmdQuaternionf_t orientation; // 0x20
    }

    public class VRControllerAxis_t : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
    }

    public class VRControllerState_t : ValueType
    {
        public uint unPacketNum; // 0x10
        public ulong ulButtonPressed; // 0x18
        public ulong ulButtonTouched; // 0x20
        public OVR.OpenVR.VRControllerAxis_t rAxis0; // 0x28
        public OVR.OpenVR.VRControllerAxis_t rAxis1; // 0x30
        public OVR.OpenVR.VRControllerAxis_t rAxis2; // 0x38
        public OVR.OpenVR.VRControllerAxis_t rAxis3; // 0x40
        public OVR.OpenVR.VRControllerAxis_t rAxis4; // 0x48
    }

    public class VRControllerState_t_Packed : ValueType
    {
        public uint unPacketNum; // 0x10
        public ulong ulButtonPressed; // 0x14
        public ulong ulButtonTouched; // 0x1C
        public OVR.OpenVR.VRControllerAxis_t rAxis0; // 0x24
        public OVR.OpenVR.VRControllerAxis_t rAxis1; // 0x2C
        public OVR.OpenVR.VRControllerAxis_t rAxis2; // 0x34
        public OVR.OpenVR.VRControllerAxis_t rAxis3; // 0x3C
        public OVR.OpenVR.VRControllerAxis_t rAxis4; // 0x44

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985E20
        public void Unpack(){} // RVA: 0x7FFAC8985E50
    }

    public class VREvent_ApplicationLaunch_t : ValueType
    {
        public uint pid; // 0x10
        public uint unArgsHandle; // 0x14
    }

    public class VREvent_Chaperone_t : ValueType
    {
        public ulong m_nPreviousUniverse; // 0x10
        public ulong m_nCurrentUniverse; // 0x18
    }

    public class VREvent_Controller_t : ValueType
    {
        public uint button; // 0x10
    }

    public class VREvent_Data_t : ValueType
    {
        public OVR.OpenVR.VREvent_Reserved_t reserved; // 0x10
        public OVR.OpenVR.VREvent_Controller_t controller; // 0x10
        public OVR.OpenVR.VREvent_Mouse_t mouse; // 0x10
        public OVR.OpenVR.VREvent_Scroll_t scroll; // 0x10
        public OVR.OpenVR.VREvent_Process_t process; // 0x10
        public OVR.OpenVR.VREvent_Notification_t notification; // 0x10
        public OVR.OpenVR.VREvent_Overlay_t overlay; // 0x10
        public OVR.OpenVR.VREvent_Status_t status; // 0x10
        public OVR.OpenVR.VREvent_Ipd_t ipd; // 0x10
        public OVR.OpenVR.VREvent_Chaperone_t chaperone; // 0x10
        public OVR.OpenVR.VREvent_PerformanceTest_t performanceTest; // 0x10
        public OVR.OpenVR.VREvent_TouchPadMove_t touchPadMove; // 0x10
        public OVR.OpenVR.VREvent_SeatedZeroPoseReset_t seatedZeroPoseReset; // 0x10
        public OVR.OpenVR.VREvent_Screenshot_t screenshot; // 0x10
        public OVR.OpenVR.VREvent_ScreenshotProgress_t screenshotProgress; // 0x10
        public OVR.OpenVR.VREvent_ApplicationLaunch_t applicationLaunch; // 0x10
        public OVR.OpenVR.VREvent_EditingCameraSurface_t cameraSurface; // 0x10
        public OVR.OpenVR.VREvent_MessageOverlay_t messageOverlay; // 0x10
        public OVR.OpenVR.VREvent_Property_t property; // 0x10
        public OVR.OpenVR.VREvent_DualAnalog_t dualAnalog; // 0x10
        public OVR.OpenVR.VREvent_HapticVibration_t hapticVibration; // 0x10
        public OVR.OpenVR.VREvent_WebConsole_t webConsole; // 0x10
        public OVR.OpenVR.VREvent_InputBindingLoad_t inputBinding; // 0x10
        public OVR.OpenVR.VREvent_SpatialAnchor_t spatialAnchor; // 0x10
        public OVR.OpenVR.VREvent_Keyboard_t keyboard; // 0x10
    }

    public class VREvent_DualAnalog_t : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public float transformedX; // 0x18
        public float transformedY; // 0x1C
        public 0x6B1B6040 which; // 0x20
    }

    public class VREvent_EditingCameraSurface_t : ValueType
    {
        public ulong overlayHandle; // 0x10
        public uint nVisualMode; // 0x18
    }

    public class VREvent_HapticVibration_t : ValueType
    {
        public ulong containerHandle; // 0x10
        public ulong componentHandle; // 0x18
        public float fDurationSeconds; // 0x20
        public float fFrequency; // 0x24
        public float fAmplitude; // 0x28
    }

    public class VREvent_InputActionManifestLoad_t : ValueType
    {
        public ulong pathAppKey; // 0x10
        public ulong pathMessage; // 0x18
        public ulong pathMessageParam; // 0x20
        public ulong pathManifestPath; // 0x28
    }

    public class VREvent_InputBindingLoad_t : ValueType
    {
        public ulong ulAppContainer; // 0x10
        public ulong pathMessage; // 0x18
        public ulong pathUrl; // 0x20
        public ulong pathControllerType; // 0x28
    }

    public class VREvent_Ipd_t : ValueType
    {
        public float ipdMeters; // 0x10
    }

    public class VREvent_Keyboard_t : ValueType
    {
        public byte cNewInput; // 0x10
        public byte cNewInput1; // 0x11
        public byte cNewInput2; // 0x12
        public byte cNewInput3; // 0x13
        public byte cNewInput4; // 0x14
        public byte cNewInput5; // 0x15
        public byte cNewInput6; // 0x16
        public byte cNewInput7; // 0x17
        public ulong uUserValue; // 0x18

        // ── Methods ──
        public void get_cNewInput(){} // RVA: 0x7FFAC8985C90
    }

    public class VREvent_MessageOverlay_t : ValueType
    {
        public uint unVRMessageOverlayResponse; // 0x10
    }

    public class VREvent_Mouse_t : ValueType
    {
        public float x; // 0x10
        public float y; // 0x14
        public uint button; // 0x18
    }

    public class VREvent_Notification_t : ValueType
    {
        public ulong ulUserValue; // 0x10
        public uint notificationId; // 0x18
    }

    public class VREvent_Overlay_t : ValueType
    {
        public ulong overlayHandle; // 0x10
        public ulong devicePath; // 0x18
    }

    public class VREvent_PerformanceTest_t : ValueType
    {
        public uint m_nFidelityLevel; // 0x10
    }

    public class VREvent_Process_t : ValueType
    {
        public uint pid; // 0x10
        public uint oldPid; // 0x14
        public bool bForced; // 0x18
    }

    public class VREvent_Property_t : ValueType
    {
        public ulong container; // 0x10
        public 0x6B1B5D80 prop; // 0x18
    }

    public class VREvent_Reserved_t : ValueType
    {
        public ulong reserved0; // 0x10
        public ulong reserved1; // 0x18
        public ulong reserved2; // 0x20
        public ulong reserved3; // 0x28
    }

    public class VREvent_ScreenshotProgress_t : ValueType
    {
        public float progress; // 0x10
    }

    public class VREvent_Screenshot_t : ValueType
    {
        public uint handle; // 0x10
        public uint type; // 0x14
    }

    public class VREvent_Scroll_t : ValueType
    {
        public float xdelta; // 0x10
        public float ydelta; // 0x14
        public uint repeatCount; // 0x18
    }

    public class VREvent_SeatedZeroPoseReset_t : ValueType
    {
        public bool bResetBySystemMenu; // 0x10
    }

    public class VREvent_SpatialAnchor_t : ValueType
    {
        public uint unHandle; // 0x10
    }

    public class VREvent_Status_t : ValueType
    {
        public uint statusState; // 0x10
    }

    public class VREvent_TouchPadMove_t : ValueType
    {
        public bool bFingerDown; // 0x10
        public float flSecondsFingerDown; // 0x14
        public float fValueXFirst; // 0x18
        public float fValueYFirst; // 0x1C
        public float fValueXRaw; // 0x20
        public float fValueYRaw; // 0x24
    }

    public class VREvent_WebConsole_t : ValueType
    {
        public ulong webConsoleHandle; // 0x10
    }

    public class VREvent_t : ValueType
    {
        public uint eventType; // 0x10
        public uint trackedDeviceIndex; // 0x14
        public float eventAgeSeconds; // 0x18
        public OVR.OpenVR.VREvent_Data_t data; // 0x20
    }

    public class VREvent_t_Packed : ValueType
    {
        public uint eventType; // 0x10
        public uint trackedDeviceIndex; // 0x14
        public float eventAgeSeconds; // 0x18
        public OVR.OpenVR.VREvent_Data_t data; // 0x1C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8985DC0
        public void Unpack(){} // RVA: 0x7FFAC8985DF0
    }

    public class VROverlayIntersectionMaskPrimitive_Data_t : ValueType
    {
        public OVR.OpenVR.IntersectionMaskRectangle_t m_Rectangle; // 0x10
        public OVR.OpenVR.IntersectionMaskCircle_t m_Circle; // 0x10
    }

    public class VROverlayIntersectionMaskPrimitive_t : ValueType
    {
        public 0x6B1B6CA0 m_nPrimitiveType; // 0x10
        public OVR.OpenVR.VROverlayIntersectionMaskPrimitive_Data_t m_Primitive; // 0x14
    }

    public class VROverlayIntersectionParams_t : ValueType
    {
        public OVR.OpenVR.HmdVector3_t vSource; // 0x10
        public OVR.OpenVR.HmdVector3_t vDirection; // 0x1C
        public 0x6B1B5D28 eOrigin; // 0x28
    }

    public class VROverlayIntersectionResults_t : ValueType
    {
        public OVR.OpenVR.HmdVector3_t vPoint; // 0x10
        public OVR.OpenVR.HmdVector3_t vNormal; // 0x1C
        public OVR.OpenVR.HmdVector2_t vUVs; // 0x28
        public float fDistance; // 0x30
    }

    public class VRTextureBounds_t : ValueType
    {
        public float uMin; // 0x10
        public float vMin; // 0x14
        public float uMax; // 0x18
        public float vMax; // 0x1C
    }

    public class VRTextureDepthInfo_t : ValueType
    {
        public UIntPtr handle; // 0x10
        public OVR.OpenVR.HmdMatrix44_t mProjection; // 0x18
        public OVR.OpenVR.HmdVector2_t vRange; // 0x58
    }

    public class VRTextureWithDepth_t : ValueType
    {
        public OVR.OpenVR.VRTextureDepthInfo_t depth; // 0x10
    }

    public class VRTextureWithPoseAndDepth_t : ValueType
    {
        public OVR.OpenVR.VRTextureDepthInfo_t depth; // 0x10
    }

    public class VRTextureWithPose_t : ValueType
    {
        public OVR.OpenVR.HmdMatrix34_t mDeviceToAbsoluteTracking; // 0x10
    }

    public class VRVulkanTextureData_t : ValueType
    {
        public ulong m_nImage; // 0x10
        public UIntPtr m_pDevice; // 0x18
        public UIntPtr m_pPhysicalDevice; // 0x20
        public UIntPtr m_pInstance; // 0x28
        public UIntPtr m_pQueue; // 0x30
        public uint m_nQueueFamilyIndex; // 0x38
        public uint m_nWidth; // 0x3C
        public uint m_nHeight; // 0x40
        public uint m_nFormat; // 0x44
        public uint m_nSampleCount; // 0x48
    }

}