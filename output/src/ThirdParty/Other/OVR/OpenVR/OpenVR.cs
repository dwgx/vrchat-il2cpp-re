// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 1
// Methods: 0

namespace ThirdParty.Other.OVR.OpenVR
{
    public class IVRSystem : ValueType
    {
        public 0x6650DE50 GetRecommendedRenderTargetSize; // 0x10
        public 0x6650DEA8 GetProjectionMatrix; // 0x18
        public 0x6650DF00 GetProjectionRaw; // 0x20
        public 0x6650DF58 ComputeDistortion; // 0x28
        public 0x6650DFB0 GetEyeToHeadTransform; // 0x30
        public 0x6650E008 GetTimeSinceLastVsync; // 0x38
        public 0x6650E060 GetD3D9AdapterIndex; // 0x40
        public 0x6650E0B8 GetDXGIOutputInfo; // 0x48
        public 0x6650E110 GetOutputDevice; // 0x50
        public 0x6650E168 IsDisplayOnDesktop; // 0x58
        public 0x6650E1C0 SetDisplayVisibility; // 0x60
        public 0x6650E218 GetDeviceToAbsoluteTrackingPose; // 0x68
        public 0x6650E270 ResetSeatedZeroPose; // 0x70
        public 0x6650E2C8 GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x78
        public 0x6650E320 GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x80
        public 0x6650E378 GetSortedTrackedDeviceIndicesOfClass; // 0x88
        public 0x6650E3D0 GetTrackedDeviceActivityLevel; // 0x90
        public 0x6650E428 ApplyTransform; // 0x98
        public 0x6650E480 GetTrackedDeviceIndexForControllerRole; // 0xA0
        public 0x6650E4D8 GetControllerRoleForTrackedDeviceIndex; // 0xA8
        public 0x6650E530 GetTrackedDeviceClass; // 0xB0
        public 0x6650E588 IsTrackedDeviceConnected; // 0xB8
        public 0x6650E5E0 GetBoolTrackedDeviceProperty; // 0xC0
        public 0x6650E638 GetFloatTrackedDeviceProperty; // 0xC8
        public 0x6650E690 GetInt32TrackedDeviceProperty; // 0xD0
        public 0x6650E6E8 GetUint64TrackedDeviceProperty; // 0xD8
        public 0x6650E740 GetMatrix34TrackedDeviceProperty; // 0xE0
        public 0x6650E798 GetArrayTrackedDeviceProperty; // 0xE8
        public 0x6650E7F0 GetStringTrackedDeviceProperty; // 0xF0
        public 0x6650E848 GetPropErrorNameFromEnum; // 0xF8
        public 0x6650E8A0 PollNextEvent; // 0x100
        public 0x6650E8F8 PollNextEventWithPose; // 0x108
        public 0x6650E950 GetEventTypeNameFromEnum; // 0x110
        public 0x6650E9A8 GetHiddenAreaMesh; // 0x118
        public 0x6650EA00 GetControllerState; // 0x120
        public 0x6650EA58 GetControllerStateWithPose; // 0x128
        public 0x6650EAB0 TriggerHapticPulse; // 0x130
        public 0x6650EB08 GetButtonIdNameFromEnum; // 0x138
        public 0x6650EB60 GetControllerAxisTypeNameFromEnum; // 0x140
        public 0x6650EBB8 IsInputAvailable; // 0x148
        public 0x6650EC10 IsSteamVRDrawingControllers; // 0x150
        public 0x6650EC68 ShouldApplicationPause; // 0x158
        public 0x6650ECC0 ShouldApplicationReduceRenderingWork; // 0x160
        public 0x6650ED18 DriverDebugRequest; // 0x168
        public 0x6650ED70 PerformFirmwareUpdate; // 0x170
        public 0x6650EDC8 AcknowledgeQuit_Exiting; // 0x178
        public 0x6650EE20 AcknowledgeQuit_UserPrompt; // 0x180
    }

}