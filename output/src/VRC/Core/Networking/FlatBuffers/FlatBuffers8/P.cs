// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 16
// Methods: 163

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class PlayerDrone
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsPlayerDrone(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifyPlayerDrone(){} // RVA: 0x75E44C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Throttle(){} // RVA: 0x75E3420
        public void CreatePlayerDrone(){} // RVA: 0x75E45B0
        public void StartPlayerDrone(){} // RVA: 0x75E0EB0
        public void AddThrottle(){} // RVA: 0x75E3560
        public void EndPlayerDrone(){} // RVA: 0x75E46A0
        public void FinishPlayerDroneBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75E4730
        public void UnPackTo(){} // RVA: 0x75E3700
        public void Pack(){} // RVA: 0x75E47D0
    }

    public class PlayerDroneT
    {
        // ── Methods ──
        public void get_Throttle(){} // RVA: 0x407320
        public void set_Throttle(){} // RVA: 0x407330
        public void .ctor(){} // RVA: 0xA5D070
        public void DeserializeFromBinary(){} // RVA: 0x75E47F0
        public void SerializeToBinary(){} // RVA: 0x75E4920
    }

    public class PlayerDroneVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E39B0
    }

    public class PoseFingerData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void FingerStretch(){} // RVA: 0x75E5870
        public void FingerSpread(){} // RVA: 0x75E58A0
        public void CreatePoseFingerData(){} // RVA: 0x75E58D0
        public void UnPack(){} // RVA: 0x75E5A60
        public void UnPackTo(){} // RVA: 0x75E5AD0
        public void Pack(){} // RVA: 0x75E5C90
    }

    public class PoseFingerDataT
    {
        public object ByteBuffer;
        public object HandGestureLeft;

        // ── Methods ──
        public void get_FingerStretch(){} // RVA: 0x2F8380
        public void set_FingerStretch(){} // RVA: 0x2DEE30
        public void get_FingerSpread(){} // RVA: 0x2E07C0
        public void set_FingerSpread(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75E5CB0
    }

    public class PoseHandGestures
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_HandGestureLeft(){} // RVA: 0x75E5DC0
        public void get_HandGestureRight(){} // RVA: 0x75E5DF0
        public void CreatePoseHandGestures(){} // RVA: 0x75E5E20
        public void UnPack(){} // RVA: 0x75E5F20
        public void UnPackTo(){} // RVA: 0x75E5FB0
        public void Pack(){} // RVA: 0x75E6010
    }

    public class PoseHandGesturesT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_HandGestureLeft(){} // RVA: 0x3A75E0
        public void set_HandGestureLeft(){} // RVA: 0x3A75F0
        public void get_HandGestureRight(){} // RVA: 0x543460
        public void set_HandGestureRight(){} // RVA: 0x543470
        public void .ctor(){} // RVA: 0x570B30
    }

    public class PoseMuscleData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_BodyRotation(){} // RVA: 0x75E4E20
        public void get_HipPosition(){} // RVA: 0x75E4E60
        public void Muscles(){} // RVA: 0x75E4EA0
        public void CreatePoseMuscleData(){} // RVA: 0x75E4ED0
        public void UnPack(){} // RVA: 0x75E50D0
        public void UnPackTo(){} // RVA: 0x75E52E0
        public void Pack(){} // RVA: 0x75E5570
    }

    public class PoseMuscleDataT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_BodyRotation(){} // RVA: 0x2F8380
        public void set_BodyRotation(){} // RVA: 0x2DEE30
        public void get_HipPosition(){} // RVA: 0x2E07C0
        public void set_HipPosition(){} // RVA: 0x343E80
        public void get_Muscles(){} // RVA: 0x30B0C0
        public void set_Muscles(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x75E56C0
    }

    public class PosePositionDataUnion
    {
        public object ByteBuffer;
        public object Contents;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x3A75E0
        public void set_Type(){} // RVA: 0x3A75F0
        public void get_Value(){} // RVA: 0x2E07C0
        public void set_Value(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x75DFAD0
        public void As(){} // RVA: 0x283FA0
        public void AsPoseMuscleData(){} // RVA: 0x75E4A20
        public void FromPoseMuscleData(){} // RVA: 0x75E4AE0
        public void Pack(){} // RVA: 0x75E4BE0
    }

    public class PosePositionDataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E4DE0
    }

    public class PoseRecorder
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void ValidateVersion(){} // RVA: 0x2DD310
        public void GetRootAsPoseRecorder(){} // RVA: 0x75E0C40 | overloaded x2
        public void VerifyPoseRecorder(){} // RVA: 0x75E6360
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void get_Contents(){} // RVA: 0x75E6450
        public void get_MotionFlags(){} // RVA: 0x75E64A0
        public void get_ExtraFlags(){} // RVA: 0x75E64F0
        public void get_StandingHeight(){} // RVA: 0x75E6540
        public void get_AngVelocity(){} // RVA: 0x75E6590
        public void get_Gestures(){} // RVA: 0x75E65E0
        public void get_Fingers(){} // RVA: 0x75E66F0
        public void get_PoseType(){} // RVA: 0x75E6800
        public void Pose(){} // RVA: 0x283FA0
        public void PoseAsPoseMuscleData(){} // RVA: 0x75E6850
        public void get_Puppet(){} // RVA: 0x75E68E0
        public void get_EyeLookTargetPosition(){} // RVA: 0x75E69F0
        public void get_EyeClosedAmount(){} // RVA: 0x75E6B00
        public void get_SpineLengthFactor(){} // RVA: 0x75E6B50
        public void get_FaceTrackedVisemes(){} // RVA: 0x75E6C60
        public void CreatePoseRecorder(){} // RVA: 0x75E6D70
        public void StartPoseRecorder(){} // RVA: 0x75E7200
        public void AddContents(){} // RVA: 0x75E7220
        public void AddMotionFlags(){} // RVA: 0x75E7290
        public void AddExtraFlags(){} // RVA: 0x75E7300
        public void AddStandingHeight(){} // RVA: 0x75E7370
        public void AddAngVelocity(){} // RVA: 0x75E73E0
        public void AddGestures(){} // RVA: 0x75E7450
        public void AddFingers(){} // RVA: 0x75E7480
        public void AddPoseType(){} // RVA: 0x75E74B0
        public void AddPose(){} // RVA: 0x75E7520
        public void AddPuppet(){} // RVA: 0x75E7560
        public void AddEyeLookTargetPosition(){} // RVA: 0x75E7590
        public void AddEyeClosedAmount(){} // RVA: 0x75E75C0
        public void AddSpineLengthFactor(){} // RVA: 0x75E7630
        public void AddFaceTrackedVisemes(){} // RVA: 0x75E7660
        public void EndPoseRecorder(){} // RVA: 0x75E7690
        public void FinishPoseRecorderBuffer(){} // RVA: 0x75E2530
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x75E2590
        public void UnPack(){} // RVA: 0x75E7720
        public void UnPackTo(){} // RVA: 0x75E7790
        public void Pack(){} // RVA: 0x75E8210
    }

    public class PoseRecorderT
    {
        // ── Methods ──
        public void get_Contents(){} // RVA: 0x1C0F720
        public void set_Contents(){} // RVA: 0x1C0FA70
        public void get_MotionFlags(){} // RVA: 0x195A940
        public void set_MotionFlags(){} // RVA: 0x195A9A0
        public void get_ExtraFlags(){} // RVA: 0x195A9E0
        public void set_ExtraFlags(){} // RVA: 0x195A9B0
        public void get_StandingHeight(){} // RVA: 0x42CBD0
        public void set_StandingHeight(){} // RVA: 0x42CBE0
        public void get_AngVelocity(){} // RVA: 0x5992B0
        public void set_AngVelocity(){} // RVA: 0x195A9C0
        public void get_Gestures(){} // RVA: 0x2E07C0
        public void set_Gestures(){} // RVA: 0x343E80
        public void get_Fingers(){} // RVA: 0x30B0C0
        public void set_Fingers(){} // RVA: 0x30B0D0
        public void get_Pose(){} // RVA: 0x30B130
        public void set_Pose(){} // RVA: 0x2DEE90
        public void get_Puppet(){} // RVA: 0x6374D0
        public void set_Puppet(){} // RVA: 0x30B890
        public void get_EyeLookTargetPosition(){} // RVA: 0x4976A0
        public void set_EyeLookTargetPosition(){} // RVA: 0x49B830
        public void get_EyeClosedAmount(){} // RVA: 0x398C00
        public void set_EyeClosedAmount(){} // RVA: 0x398C10
        public void get_SpineLengthFactor(){} // RVA: 0x358730
        public void set_SpineLengthFactor(){} // RVA: 0x358740
        public void get_FaceTrackedVisemes(){} // RVA: 0x37E0E0
        public void set_FaceTrackedVisemes(){} // RVA: 0x4354D0
        public void .ctor(){} // RVA: 0x75E8330
        public void DeserializeFromBinary(){} // RVA: 0x75E86E0
        public void SerializeToBinary(){} // RVA: 0x75E87D0
    }

    public class PoseRecorderVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x75E88D0
    }

    public class PuppetData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x19689C0
        public void __init(){} // RVA: 0x75E0560
        public void __assign(){} // RVA: 0x75E0630
        public void Channels(){} // RVA: 0x75E5870
        public void CreatePuppetData(){} // RVA: 0x75EE060
        public void UnPack(){} // RVA: 0x75EE170
        public void UnPackTo(){} // RVA: 0x75EE1E0
        public void Pack(){} // RVA: 0x75EE2E0
    }

    public class PuppetDataT
    {
        public object Objects;

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x2F8380
        public void set_Channels(){} // RVA: 0x2DEE30
        public void .ctor(){} // RVA: 0x75EE300
    }

}