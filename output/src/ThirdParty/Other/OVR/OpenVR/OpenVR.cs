// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Other.OVR.OpenVR
// Classes: 1
// Methods: 0

namespace ThirdParty.Other.OVR.OpenVR
{
    public class IVRSystem : ValueType
    {
        public derComparer GetRecommendedRenderTargetSize; // 0x10
        public eCaptureRequestId GetProjectionMatrix; // 0x18
        public object GetProjectionRaw; // 0x20
        public Index ComputeDistortion; // 0x28
        public me GetEyeToHeadTransform; // 0x30
        public _BackingField GetTimeSinceLastVsync; // 0x38
        public hors GetD3D9AdapterIndex; // 0x40
        public yAllBounded2DEnabled GetDXGIOutputInfo; // 0x48
        public ayoutEnabledForAllEntitiesInside GetOutputDevice; // 0x50
        public outEnabledForRoomBox IsDisplayOnDesktop; // 0x58
        public object SetDisplayVisibility; // 0x60
        public ult>g__EnabledComponents|0 GetDeviceToAbsoluteTrackingPose; // 0x68
        public ceneModelLoader ResetSeatedZeroPose; // 0x70
        public ceneManager GetSeatedZeroPoseToStandingAbsoluteTrackingPose; // 0x78
        public del GetRawZeroPoseToStandingAbsoluteTrackingPose; // 0x80
        public oSceneModelToLoad GetSortedTrackedDeviceIndicesOfClass; // 0x88
        public tToLoadSceneModel>d__6 GetTrackedDeviceActivityLevel; // 0x90
        public imensions ApplyTransform; // 0x98
        public cenePlaneMeshFilter GetTrackedDeviceIndexForControllerRole; // 0xA0
        public r GetControllerRoleForTrackedDeviceIndex; // 0xA8
        public tionCallbackReceiver.OnAfterDeserialize>g__IndexOf|4_0 GetTrackedDeviceClass; // 0xB0
        public AfterDeserialize>g__IndexOf|4_0 IsTrackedDeviceConnected; // 0xB8
        public f|4_0 GetBoolTrackedDeviceProperty; // 0xC0
        public torClassificationIndex GetFloatTrackedDeviceProperty; // 0xC8
        public Volume GetInt32TrackedDeviceProperty; // 0xD0
        public VRSemanticClassification GetUint64TrackedDeviceProperty; // 0xD8
        public els GetMatrix34TrackedDeviceProperty; // 0xE0
        public Uuid GetArrayTrackedDeviceProperty; // 0xE8
        public t_MaxResults GetStringTrackedDeviceProperty; // 0xF0
        public get_QueryType GetPropErrorNameFromEnum; // 0xF8
        public e PollNextEvent; // 0x100
        public t_ComponentFilter PollNextEventWithPose; // 0x108
        public omponentFilter GetEventTypeNameFromEnum; // 0x110
        public t_UuidFilter GetHiddenAreaMesh; // 0x118
        public rySpaces GetControllerState; // 0x120
        public ingField GetControllerStateWithPose; // 0x128
        public ingField TriggerHapticPulse; // 0x130
        public object GetButtonIdNameFromEnum; // 0x138
        public ialAnchor GetControllerAxisTypeNameFromEnum; // 0x140
        public nitializeFromExisting IsInputAvailable; // 0x148
        public ing IsSteamVRDrawingControllers; // 0x150
        public nitializeUnchecked ShouldApplicationPause; // 0x158
        public ackingSpacePose ShouldApplicationReduceRenderingWork; // 0x160
        public form DriverDebugRequest; // 0x168
        public omplete PerformFirmwareUpdate; // 0x170
        public lete AcknowledgeQuit_Exiting; // 0x178
        public object AcknowledgeQuit_UserPrompt; // 0x180
    }

}