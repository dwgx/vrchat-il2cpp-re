// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 16
// Methods: 161

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class PlayerDrone : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsPlayerDrone(){} // RVA: 0x7AF3BF190
        public void VerifyPlayerDrone(){} // RVA: 0x7AF3C2A50
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Throttle(){} // RVA: 0x7A7F12A70
        public void CreatePlayerDrone(){} // RVA: 0x7AF3C2B40
        public void StartPlayerDrone(){} // RVA: 0x7AF3BF400
        public void AddThrottle(){} // RVA: 0x7AF3C1AF0
        public void EndPlayerDrone(){} // RVA: 0x7AF3C2C30
        public void FinishPlayerDroneBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F12C50
        public void UnPackTo(){} // RVA: 0x7A7F12AD0
        public void Pack(){} // RVA: 0x7AF3C2D60
    }

    public class PlayerDroneT : Object
    {
        // ── Methods ──
        public void get_Throttle(){} // RVA: 0x7A82023C0
        public void set_Throttle(){} // RVA: 0x7A82023D0
        public void .ctor(){} // RVA: 0x7A881ACE0
        public void DeserializeFromBinary(){} // RVA: 0x7AF3C2D80
        public void SerializeToBinary(){} // RVA: 0x7AF3C2EB0
    }

    public class PlayerDroneVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C1F40
    }

    public class PoseFingerData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void FingerStretch(){} // RVA: 0x7A7F12D70
        public void FingerSpread(){} // RVA: 0x7A7F12DA0
        public void CreatePoseFingerData(){} // RVA: 0x7AF3C3E60
        public void UnPack(){} // RVA: 0x7A7F12DD0
        public void UnPackTo(){} // RVA: 0x7A7F12DE0
        public void Pack(){} // RVA: 0x7AF3C4220
    }

    public class PoseFingerDataT : Object
    {
        // ── Methods ──
        public void get_FingerStretch(){} // RVA: 0x7A80F2570
        public void set_FingerStretch(){} // RVA: 0x7A80D8E20
        public void get_FingerSpread(){} // RVA: 0x7A80DA7B0
        public void set_FingerSpread(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3C4240
    }

    public class PoseHandGestures : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_HandGestureLeft(){} // RVA: 0x7A7F12E10
        public void get_HandGestureRight(){} // RVA: 0x7A7F12E40
        public void CreatePoseHandGestures(){} // RVA: 0x7AF3C43B0
        public void UnPack(){} // RVA: 0x7A7F12E70
        public void UnPackTo(){} // RVA: 0x7A7F12E80
        public void Pack(){} // RVA: 0x7AF3C45A0
    }

    public class PoseHandGesturesT : Object
    {
        // ── Methods ──
        public void get_HandGestureLeft(){} // RVA: 0x7A81A2200
        public void set_HandGestureLeft(){} // RVA: 0x7A81A2210
        public void get_HandGestureRight(){} // RVA: 0x7A82FBFB0
        public void set_HandGestureRight(){} // RVA: 0x7A82FBFC0
        public void .ctor(){} // RVA: 0x7A83299A0
    }

    public class PoseMuscleData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_BodyRotation(){} // RVA: 0x7A7F12C80
        public void get_HipPosition(){} // RVA: 0x7A7F12CC0
        public void Muscles(){} // RVA: 0x7A7F12D00
        public void CreatePoseMuscleData(){} // RVA: 0x7AF3C3460
        public void UnPack(){} // RVA: 0x7A7F12D30
        public void UnPackTo(){} // RVA: 0x7A7F12D40
        public void Pack(){} // RVA: 0x7AF3C3B10
    }

    public class PoseMuscleDataT : Object
    {
        // ── Methods ──
        public void get_BodyRotation(){} // RVA: 0x7A80F2570
        public void set_BodyRotation(){} // RVA: 0x7A80D8E20
        public void get_HipPosition(){} // RVA: 0x7A80DA7B0
        public void set_HipPosition(){} // RVA: 0x7A813E420
        public void get_Muscles(){} // RVA: 0x7A81052C0
        public void set_Muscles(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AF3C3C50
    }

    public class PosePositionDataUnion : Object
    {
        // ── Methods ──
        public void get_Type(){} // RVA: 0x7A81A2200
        public void set_Type(){} // RVA: 0x7A81A2210
        public void get_Value(){} // RVA: 0x7A80DA7B0
        public void set_Value(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7AF3BE020
        public void As(){} // RVA: 0x7A8051B10
        public void AsPoseMuscleData(){} // RVA: 0x7AF3C2FB0
        public void FromPoseMuscleData(){} // RVA: 0x7AF3C3070
        public void Pack(){} // RVA: 0x7AF3C3170
    }

    public class PosePositionDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C3370
    }

    public class PoseRecorder : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void ValidateVersion(){} // RVA: 0x7A80D7310
        public void GetRootAsPoseRecorder(){} // RVA: 0x7AF3BF190
        public void VerifyPoseRecorder(){} // RVA: 0x7AF3C4910
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void get_Contents(){} // RVA: 0x7A7F12F40
        public void get_MotionFlags(){} // RVA: 0x7A7F12F90
        public void get_ExtraFlags(){} // RVA: 0x7A7F12FE0
        public void get_StandingHeight(){} // RVA: 0x7A7F13030
        public void get_AngVelocity(){} // RVA: 0x7A7F13080
        public void get_Gestures(){} // RVA: 0x7A7F130D0
        public void get_Fingers(){} // RVA: 0x7A7F13100
        public void get_PoseType(){} // RVA: 0x7A7F13130
        public void Pose(){} // RVA: 0x7A8051B10
        public void PoseAsPoseMuscleData(){} // RVA: 0x7A7F13180
        public void get_Puppet(){} // RVA: 0x7A7F13210
        public void get_EyeLookTargetPosition(){} // RVA: 0x7A7F13240
        public void get_EyeClosedAmount(){} // RVA: 0x7A7F13270
        public void get_SpineLengthFactor(){} // RVA: 0x7A7F132C0
        public void get_FaceTrackedVisemes(){} // RVA: 0x7A7F132F0
        public void CreatePoseRecorder(){} // RVA: 0x7AF3C5380
        public void StartPoseRecorder(){} // RVA: 0x7AF3C5810
        public void AddContents(){} // RVA: 0x7AF3C5830
        public void AddMotionFlags(){} // RVA: 0x7AF3C58A0
        public void AddExtraFlags(){} // RVA: 0x7AF3C5910
        public void AddStandingHeight(){} // RVA: 0x7AF3C5980
        public void AddAngVelocity(){} // RVA: 0x7AF3C59F0
        public void AddGestures(){} // RVA: 0x7AF3C5A60
        public void AddFingers(){} // RVA: 0x7AF3C5A90
        public void AddPoseType(){} // RVA: 0x7AF3C5AC0
        public void AddPose(){} // RVA: 0x7AF3C5B30
        public void AddPuppet(){} // RVA: 0x7AF3C5B70
        public void AddEyeLookTargetPosition(){} // RVA: 0x7AF3C5BA0
        public void AddEyeClosedAmount(){} // RVA: 0x7AF3C5BD0
        public void AddSpineLengthFactor(){} // RVA: 0x7AF3C5C40
        public void AddFaceTrackedVisemes(){} // RVA: 0x7AF3C5C70
        public void EndPoseRecorder(){} // RVA: 0x7AF3C5CA0
        public void FinishPoseRecorderBuffer(){} // RVA: 0x7AF3C0AA0
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x7AF3C0B00
        public void UnPack(){} // RVA: 0x7A7F13320
        public void UnPackTo(){} // RVA: 0x7A7F13330
        public void Pack(){} // RVA: 0x7AF3C6820
    }

    public class PoseRecorderT : Object
    {
        // ── Methods ──
        public void get_Contents(){} // RVA: 0x7A99CD750
        public void set_Contents(){} // RVA: 0x7A99CDAA0
        public void get_MotionFlags(){} // RVA: 0x7A9716B70
        public void set_MotionFlags(){} // RVA: 0x7A9716BD0
        public void get_ExtraFlags(){} // RVA: 0x7A9716C10
        public void set_ExtraFlags(){} // RVA: 0x7A9716BE0
        public void get_StandingHeight(){} // RVA: 0x7A8227C00
        public void set_StandingHeight(){} // RVA: 0x7A8227C10
        public void get_AngVelocity(){} // RVA: 0x7A83525F0
        public void set_AngVelocity(){} // RVA: 0x7A9716BF0
        public void get_Gestures(){} // RVA: 0x7A80DA7B0
        public void set_Gestures(){} // RVA: 0x7A813E420
        public void get_Fingers(){} // RVA: 0x7A81052C0
        public void set_Fingers(){} // RVA: 0x7A81052D0
        public void get_Pose(){} // RVA: 0x7A8105330
        public void set_Pose(){} // RVA: 0x7A80D8E80
        public void get_Puppet(){} // RVA: 0x7A83F69F0
        public void set_Puppet(){} // RVA: 0x7A8105A90
        public void get_EyeLookTargetPosition(){} // RVA: 0x7A8292C30
        public void set_EyeLookTargetPosition(){} // RVA: 0x7A8296DE0
        public void get_EyeClosedAmount(){} // RVA: 0x7A8193790
        public void set_EyeClosedAmount(){} // RVA: 0x7A81937A0
        public void get_SpineLengthFactor(){} // RVA: 0x7A8152D80
        public void set_SpineLengthFactor(){} // RVA: 0x7A8152D90
        public void get_FaceTrackedVisemes(){} // RVA: 0x7A8178B90
        public void set_FaceTrackedVisemes(){} // RVA: 0x7A8230620
        public void .ctor(){} // RVA: 0x7AF3C6910
        public void DeserializeFromBinary(){} // RVA: 0x7AF3C6CC0
        public void SerializeToBinary(){} // RVA: 0x7AF3C6DC0
    }

    public class PoseRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7AF3C6EC0
    }

    public class PuppetData : ValueType
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7A765F080
        public void __init(){} // RVA: 0x7A7F12470
        public void __assign(){} // RVA: 0x7A7F12480
        public void Channels(){} // RVA: 0x7A7F12D70
        public void CreatePuppetData(){} // RVA: 0x7AF3CC660
        public void UnPack(){} // RVA: 0x7A7F13A00
        public void UnPackTo(){} // RVA: 0x7A7F13A10
        public void Pack(){} // RVA: 0x7AF3CC900
    }

    public class PuppetDataT : Object
    {
        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7A80F2570
        public void set_Channels(){} // RVA: 0x7A80D8E20
        public void .ctor(){} // RVA: 0x7AF3CC920
    }

}