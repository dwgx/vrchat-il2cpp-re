// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 16
// Methods: 163

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class PlayerDrone
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsPlayerDrone(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void VerifyPlayerDrone(){} // RVA: 0x7FFAFA0944C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Throttle(){} // RVA: 0x7FFAFA093420
        public void CreatePlayerDrone(){} // RVA: 0x7FFAFA0945B0
        public void StartPlayerDrone(){} // RVA: 0x7FFAFA090EB0
        public void AddThrottle(){} // RVA: 0x7FFAFA093560
        public void EndPlayerDrone(){} // RVA: 0x7FFAFA0946A0
        public void FinishPlayerDroneBuffer(){} // RVA: 0x7FFAFA092530
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x7FFAFA092590
        public void UnPack(){} // RVA: 0x7FFAFA094730
        public void UnPackTo(){} // RVA: 0x7FFAFA093700
        public void Pack(){} // RVA: 0x7FFAFA0947D0
    }

    public class PlayerDroneT
    {
        // ── Methods ──
        public void get_Throttle(){} // RVA: 0x7FFAF2EB7320
        public void set_Throttle(){} // RVA: 0x7FFAF2EB7330
        public void .ctor(){} // RVA: 0x7FFAF350D070
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0947F0
        public void SerializeToBinary(){} // RVA: 0x7FFAFA094920
    }

    public class PlayerDroneVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0939B0
    }

    public class PoseFingerData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void FingerStretch(){} // RVA: 0x7FFAFA095870
        public void FingerSpread(){} // RVA: 0x7FFAFA0958A0
        public void CreatePoseFingerData(){} // RVA: 0x7FFAFA0958D0
        public void UnPack(){} // RVA: 0x7FFAFA095A60
        public void UnPackTo(){} // RVA: 0x7FFAFA095AD0
        public void Pack(){} // RVA: 0x7FFAFA095C90
    }

    public class PoseFingerDataT
    {
        public object ByteBuffer;
        public object HandGestureLeft;

        // ── Methods ──
        public void get_FingerStretch(){} // RVA: 0x7FFAF2DA8380
        public void set_FingerStretch(){} // RVA: 0x7FFAF2D8EE30
        public void get_FingerSpread(){} // RVA: 0x7FFAF2D907C0
        public void set_FingerSpread(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA095CB0
    }

    public class PoseHandGestures
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_HandGestureLeft(){} // RVA: 0x7FFAFA095DC0
        public void get_HandGestureRight(){} // RVA: 0x7FFAFA095DF0
        public void CreatePoseHandGestures(){} // RVA: 0x7FFAFA095E20
        public void UnPack(){} // RVA: 0x7FFAFA095F20
        public void UnPackTo(){} // RVA: 0x7FFAFA095FB0
        public void Pack(){} // RVA: 0x7FFAFA096010
    }

    public class PoseHandGesturesT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_HandGestureLeft(){} // RVA: 0x7FFAF2E575E0
        public void set_HandGestureLeft(){} // RVA: 0x7FFAF2E575F0
        public void get_HandGestureRight(){} // RVA: 0x7FFAF2FF3460
        public void set_HandGestureRight(){} // RVA: 0x7FFAF2FF3470
        public void .ctor(){} // RVA: 0x7FFAF3020B30
    }

    public class PoseMuscleData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_BodyRotation(){} // RVA: 0x7FFAFA094E20
        public void get_HipPosition(){} // RVA: 0x7FFAFA094E60
        public void Muscles(){} // RVA: 0x7FFAFA094EA0
        public void CreatePoseMuscleData(){} // RVA: 0x7FFAFA094ED0
        public void UnPack(){} // RVA: 0x7FFAFA0950D0
        public void UnPackTo(){} // RVA: 0x7FFAFA0952E0
        public void Pack(){} // RVA: 0x7FFAFA095570
    }

    public class PoseMuscleDataT
    {
        public object ByteBuffer;

        // ── Methods ──
        public void get_BodyRotation(){} // RVA: 0x7FFAF2DA8380
        public void set_BodyRotation(){} // RVA: 0x7FFAF2D8EE30
        public void get_HipPosition(){} // RVA: 0x7FFAF2D907C0
        public void set_HipPosition(){} // RVA: 0x7FFAF2DF3E80
        public void get_Muscles(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Muscles(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAFA0956C0
    }

    public class PosePositionDataUnion
    {
        public object ByteBuffer;
        public object Contents;

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAF2E575E0
        public void set_Type(){} // RVA: 0x7FFAF2E575F0
        public void get_Value(){} // RVA: 0x7FFAF2D907C0
        public void set_Value(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAFA08FAD0
        public void As(){} // RVA: 0x7FFAF2D33FA0
        public void AsPoseMuscleData(){} // RVA: 0x7FFAFA094A20
        public void FromPoseMuscleData(){} // RVA: 0x7FFAFA094AE0
        public void Pack(){} // RVA: 0x7FFAFA094BE0
    }

    public class PosePositionDataVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA094DE0
    }

    public class PoseRecorder
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void ValidateVersion(){} // RVA: 0x7FFAF2D8D310
        public void GetRootAsPoseRecorder(){} // RVA: 0x7FFAFA090C40 | overloaded x2
        public void VerifyPoseRecorder(){} // RVA: 0x7FFAFA096360
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void get_Contents(){} // RVA: 0x7FFAFA096450
        public void get_MotionFlags(){} // RVA: 0x7FFAFA0964A0
        public void get_ExtraFlags(){} // RVA: 0x7FFAFA0964F0
        public void get_StandingHeight(){} // RVA: 0x7FFAFA096540
        public void get_AngVelocity(){} // RVA: 0x7FFAFA096590
        public void get_Gestures(){} // RVA: 0x7FFAFA0965E0
        public void get_Fingers(){} // RVA: 0x7FFAFA0966F0
        public void get_PoseType(){} // RVA: 0x7FFAFA096800
        public void Pose(){} // RVA: 0x7FFAF2D33FA0
        public void PoseAsPoseMuscleData(){} // RVA: 0x7FFAFA096850
        public void get_Puppet(){} // RVA: 0x7FFAFA0968E0
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFAFA0969F0
        public void get_EyeClosedAmount(){} // RVA: 0x7FFAFA096B00
        public void get_SpineLengthFactor(){} // RVA: 0x7FFAFA096B50
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFAFA096C60
        public void CreatePoseRecorder(){} // RVA: 0x7FFAFA096D70
        public void StartPoseRecorder(){} // RVA: 0x7FFAFA097200
        public void AddContents(){} // RVA: 0x7FFAFA097220
        public void AddMotionFlags(){} // RVA: 0x7FFAFA097290
        public void AddExtraFlags(){} // RVA: 0x7FFAFA097300
        public void AddStandingHeight(){} // RVA: 0x7FFAFA097370
        public void AddAngVelocity(){} // RVA: 0x7FFAFA0973E0
        public void AddGestures(){} // RVA: 0x7FFAFA097450
        public void AddFingers(){} // RVA: 0x7FFAFA097480
        public void AddPoseType(){} // RVA: 0x7FFAFA0974B0
        public void AddPose(){} // RVA: 0x7FFAFA097520
        public void AddPuppet(){} // RVA: 0x7FFAFA097560
        public void AddEyeLookTargetPosition(){} // RVA: 0x7FFAFA097590
        public void AddEyeClosedAmount(){} // RVA: 0x7FFAFA0975C0
        public void AddSpineLengthFactor(){} // RVA: 0x7FFAFA097630
        public void AddFaceTrackedVisemes(){} // RVA: 0x7FFAFA097660
        public void EndPoseRecorder(){} // RVA: 0x7FFAFA097690
        public void FinishPoseRecorderBuffer(){} // RVA: 0x7FFAFA092530
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x7FFAFA092590
        public void UnPack(){} // RVA: 0x7FFAFA097720
        public void UnPackTo(){} // RVA: 0x7FFAFA097790
        public void Pack(){} // RVA: 0x7FFAFA098210
    }

    public class PoseRecorderT
    {
        // ── Methods ──
        public void get_Contents(){} // RVA: 0x7FFAF46BF720
        public void set_Contents(){} // RVA: 0x7FFAF46BFA70
        public void get_MotionFlags(){} // RVA: 0x7FFAF440A940
        public void set_MotionFlags(){} // RVA: 0x7FFAF440A9A0
        public void get_ExtraFlags(){} // RVA: 0x7FFAF440A9E0
        public void set_ExtraFlags(){} // RVA: 0x7FFAF440A9B0
        public void get_StandingHeight(){} // RVA: 0x7FFAF2EDCBD0
        public void set_StandingHeight(){} // RVA: 0x7FFAF2EDCBE0
        public void get_AngVelocity(){} // RVA: 0x7FFAF30492B0
        public void set_AngVelocity(){} // RVA: 0x7FFAF440A9C0
        public void get_Gestures(){} // RVA: 0x7FFAF2D907C0
        public void set_Gestures(){} // RVA: 0x7FFAF2DF3E80
        public void get_Fingers(){} // RVA: 0x7FFAF2DBB0C0
        public void set_Fingers(){} // RVA: 0x7FFAF2DBB0D0
        public void get_Pose(){} // RVA: 0x7FFAF2DBB130
        public void set_Pose(){} // RVA: 0x7FFAF2D8EE90
        public void get_Puppet(){} // RVA: 0x7FFAF30E74D0
        public void set_Puppet(){} // RVA: 0x7FFAF2DBB890
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFAF2F476A0
        public void set_EyeLookTargetPosition(){} // RVA: 0x7FFAF2F4B830
        public void get_EyeClosedAmount(){} // RVA: 0x7FFAF2E48C00
        public void set_EyeClosedAmount(){} // RVA: 0x7FFAF2E48C10
        public void get_SpineLengthFactor(){} // RVA: 0x7FFAF2E08730
        public void set_SpineLengthFactor(){} // RVA: 0x7FFAF2E08740
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFAF2E2E0E0
        public void set_FaceTrackedVisemes(){} // RVA: 0x7FFAF2EE54D0
        public void .ctor(){} // RVA: 0x7FFAFA098330
        public void DeserializeFromBinary(){} // RVA: 0x7FFAFA0986E0
        public void SerializeToBinary(){} // RVA: 0x7FFAFA0987D0
    }

    public class PoseRecorderVerify
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAFA0988D0
    }

    public class PuppetData
    {
        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAF44189C0
        public void __init(){} // RVA: 0x7FFAFA090560
        public void __assign(){} // RVA: 0x7FFAFA090630
        public void Channels(){} // RVA: 0x7FFAFA095870
        public void CreatePuppetData(){} // RVA: 0x7FFAFA09E060
        public void UnPack(){} // RVA: 0x7FFAFA09E170
        public void UnPackTo(){} // RVA: 0x7FFAFA09E1E0
        public void Pack(){} // RVA: 0x7FFAFA09E2E0
    }

    public class PuppetDataT
    {
        public object Objects;

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7FFAF2DA8380
        public void set_Channels(){} // RVA: 0x7FFAF2D8EE30
        public void .ctor(){} // RVA: 0x7FFAFA09E300
    }

}