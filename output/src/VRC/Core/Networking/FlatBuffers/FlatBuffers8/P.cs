// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 16
// Methods: 176

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class PlayerDrone : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsPlayerDrone(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifyPlayerDrone(){} // RVA: 0x7FFAC9D79000
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Throttle(){} // RVA: 0x7FFAC9D77EE0
        public void MutateThrottle(){} // RVA: 0x7FFAC9D77F30
        public void CreatePlayerDrone(){} // RVA: 0x7FFAC9D790F0
        public void StartPlayerDrone(){} // RVA: 0x7FFAC9D758E0
        public void AddThrottle(){} // RVA: 0x7FFAC9D78090
        public void EndPlayerDrone(){} // RVA: 0x7FFAC9D791F0
        public void FinishPlayerDroneBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D79280
        public void UnPackTo(){} // RVA: 0x7FFAC9D78240
        public void Pack(){} // RVA: 0x7FFAC9D79320
    }

    public class PlayerDroneT : Object
    {
        public float Throttle; // 0x10

        // ── Methods ──
        public void get_Throttle(){} // RVA: 0x7FFAC304B320
        public void set_Throttle(){} // RVA: 0x7FFAC304B330
        public void .ctor(){} // RVA: 0x7FFAC369FBB0
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D79340
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D79470
    }

    public class PlayerDroneVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D784F0
    }

    public class PoseFingerData : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void FingerStretch(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateFingerStretch(){} // RVA: 0x7FFAC9D7A420
        public void FingerSpread(){} // RVA: 0x7FFAC9D7A450
        public void MutateFingerSpread(){} // RVA: 0x7FFAC9D7A480
        public void CreatePoseFingerData(){} // RVA: 0x7FFAC9D7A4B0
        public void UnPack(){} // RVA: 0x7FFAC9D7A640
        public void UnPackTo(){} // RVA: 0x7FFAC9D7A6B0
        public void Pack(){} // RVA: 0x7FFAC9D7A870
    }

    public class PoseFingerDataT : Object
    {
        public byte[] FingerStretch; // 0x10
        public byte[] FingerSpread; // 0x18

        // ── Methods ──
        public void get_FingerStretch(){} // RVA: 0x7FFAC2F3C380
        public void set_FingerStretch(){} // RVA: 0x7FFAC2F22E30
        public void get_FingerSpread(){} // RVA: 0x7FFAC2F247C0
        public void set_FingerSpread(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D7A890
    }

    public class PoseHandGestures : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_HandGestureLeft(){} // RVA: 0x7FFAC9D7A9A0
        public void MutateHandGestureLeft(){} // RVA: 0x7FFAC9D75030
        public void get_HandGestureRight(){} // RVA: 0x7FFAC9D7A9D0
        public void MutateHandGestureRight(){} // RVA: 0x7FFAC9D7AA00
        public void CreatePoseHandGestures(){} // RVA: 0x7FFAC9D7AA30
        public void UnPack(){} // RVA: 0x7FFAC9D7AB30
        public void UnPackTo(){} // RVA: 0x7FFAC9D7ABC0
        public void Pack(){} // RVA: 0x7FFAC9D7AC20
    }

    public class PoseHandGesturesT : Object
    {
        public byte HandGestureLeft; // 0x10
        public byte HandGestureRight; // 0x11

        // ── Methods ──
        public void get_HandGestureLeft(){} // RVA: 0x7FFAC2FEB5E0
        public void set_HandGestureLeft(){} // RVA: 0x7FFAC2FEB5F0
        public void get_HandGestureRight(){} // RVA: 0x7FFAC3771DA0
        public void set_HandGestureRight(){} // RVA: 0x7FFAC3771D90
        public void .ctor(){} // RVA: 0x7FFAC9D7AC40
    }

    public class PoseMuscleData : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_BodyRotation(){} // RVA: 0x7FFAC9D79970
        public void get_HipPosition(){} // RVA: 0x7FFAC9D799B0
        public void Muscles(){} // RVA: 0x7FFAC9D799F0
        public void MutateMuscles(){} // RVA: 0x7FFAC9D79A20
        public void CreatePoseMuscleData(){} // RVA: 0x7FFAC9D79A50
        public void UnPack(){} // RVA: 0x7FFAC9D79C50
        public void UnPackTo(){} // RVA: 0x7FFAC9D79E60
        public void Pack(){} // RVA: 0x7FFAC9D7A0F0
    }

    public class PoseMuscleDataT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionTenBitT BodyRotation; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3HalfT HipPosition; // 0x18
        public byte[] Muscles; // 0x20

        // ── Methods ──
        public void get_BodyRotation(){} // RVA: 0x7FFAC2F3C380
        public void set_BodyRotation(){} // RVA: 0x7FFAC2F22E30
        public void get_HipPosition(){} // RVA: 0x7FFAC2F247C0
        public void set_HipPosition(){} // RVA: 0x7FFAC2F87E80
        public void get_Muscles(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Muscles(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9D7A240
    }

    public class PosePositionDataUnion : Object
    {
        public 0x6B1FBF80 Type; // 0x10
        public object Value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFAC2FEB5E0
        public void set_Type(){} // RVA: 0x7FFAC2FEB5F0
        public void get_Value(){} // RVA: 0x7FFAC2F247C0
        public void set_Value(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC9D74460
        public void As(){} // RVA: 0x7FFAC2E8DC40
        public void AsPoseMuscleData(){} // RVA: 0x7FFAC9D79570
        public void FromPoseMuscleData(){} // RVA: 0x7FFAC9D79630
        public void Pack(){} // RVA: 0x7FFAC9D79730
    }

    public class PosePositionDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D79930
    }

    public class PoseRecorder : ValueType
    {
        public Google.FlatBuffers8.Table ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void ValidateVersion(){} // RVA: 0x7FFAC2F21310
        public void GetRootAsPoseRecorder(){} // RVA: 0x7FFAC9D75670 | overloaded x2
        public void VerifyPoseRecorder(){} // RVA: 0x7FFAC9D7AF80
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void get_Contents(){} // RVA: 0x7FFAC9D7B070
        public void MutateContents(){} // RVA: 0x7FFAC9D7B0C0
        public void get_MotionFlags(){} // RVA: 0x7FFAC9D7B120
        public void MutateMotionFlags(){} // RVA: 0x7FFAC9D7B170
        public void get_ExtraFlags(){} // RVA: 0x7FFAC9D7B1D0
        public void MutateExtraFlags(){} // RVA: 0x7FFAC9D7B220
        public void get_StandingHeight(){} // RVA: 0x7FFAC9D7B280
        public void MutateStandingHeight(){} // RVA: 0x7FFAC9D7B2D0
        public void get_AngVelocity(){} // RVA: 0x7FFAC9D7B330
        public void MutateAngVelocity(){} // RVA: 0x7FFAC9D7B380
        public void get_Gestures(){} // RVA: 0x7FFAC9D7B3E0
        public void get_Fingers(){} // RVA: 0x7FFAC9D7B4F0
        public void get_PoseType(){} // RVA: 0x7FFAC9D7B600
        public void Pose(){} // RVA: 0x7FFAC2E8DC40
        public void PoseAsPoseMuscleData(){} // RVA: 0x7FFAC9D7B650
        public void get_Puppet(){} // RVA: 0x7FFAC9D7B6E0
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFAC9D7B7F0
        public void get_EyeClosedAmount(){} // RVA: 0x7FFAC9D7B900
        public void MutateEyeClosedAmount(){} // RVA: 0x7FFAC9D7B950
        public void get_SpineLengthFactor(){} // RVA: 0x7FFAC9D7B9B0
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFAC9D7BAC0
        public void CreatePoseRecorder(){} // RVA: 0x7FFAC9D7BBD0
        public void StartPoseRecorder(){} // RVA: 0x7FFAC9D7C060
        public void AddContents(){} // RVA: 0x7FFAC9D7C080
        public void AddMotionFlags(){} // RVA: 0x7FFAC9D7C0F0
        public void AddExtraFlags(){} // RVA: 0x7FFAC9D7C160
        public void AddStandingHeight(){} // RVA: 0x7FFAC9D7C1D0
        public void AddAngVelocity(){} // RVA: 0x7FFAC9D7C240
        public void AddGestures(){} // RVA: 0x7FFAC9D7C2B0
        public void AddFingers(){} // RVA: 0x7FFAC9D7C2E0
        public void AddPoseType(){} // RVA: 0x7FFAC9D7C310
        public void AddPose(){} // RVA: 0x7FFAC9D7C380
        public void AddPuppet(){} // RVA: 0x7FFAC9D7C3C0
        public void AddEyeLookTargetPosition(){} // RVA: 0x7FFAC9D7C3F0
        public void AddEyeClosedAmount(){} // RVA: 0x7FFAC9D7C420
        public void AddSpineLengthFactor(){} // RVA: 0x7FFAC9D7C490
        public void AddFaceTrackedVisemes(){} // RVA: 0x7FFAC9D7C4C0
        public void EndPoseRecorder(){} // RVA: 0x7FFAC9D7C4F0
        public void FinishPoseRecorderBuffer(){} // RVA: 0x7FFAC9D76FF0
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x7FFAC9D77050
        public void UnPack(){} // RVA: 0x7FFAC9D7C580
        public void UnPackTo(){} // RVA: 0x7FFAC9D7C5F0
        public void Pack(){} // RVA: 0x7FFAC9D7D070
    }

    public class PoseRecorderT : Object
    {
        public ushort Contents; // 0x10
        public byte MotionFlags; // 0x12
        public byte ExtraFlags; // 0x13
        public byte StandingHeight; // 0x14
        public byte AngVelocity; // 0x15
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PoseHandGesturesT Gestures; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PoseFingerDataT Fingers; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PosePositionDataUnion Pose; // 0x28
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PuppetDataT Puppet; // 0x30
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3TenBitT EyeLookTargetPosition; // 0x38
        public byte EyeClosedAmount; // 0x40
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.FloatHalfT SpineLengthFactor; // 0x48
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.FaceTrackedVisemeDataT FaceTrackedVisemes; // 0x50

        // ── Methods ──
        public void get_Contents(){} // RVA: 0x7FFAC469AEC0
        public void set_Contents(){} // RVA: 0x7FFAC469BCA0
        public void get_MotionFlags(){} // RVA: 0x7FFAC3AE1A90
        public void set_MotionFlags(){} // RVA: 0x7FFAC4411DE0
        public void get_ExtraFlags(){} // RVA: 0x7FFAC4411E00
        public void set_ExtraFlags(){} // RVA: 0x7FFAC4411E10
        public void get_StandingHeight(){} // RVA: 0x7FFAC3070BD0
        public void set_StandingHeight(){} // RVA: 0x7FFAC3070BE0
        public void get_AngVelocity(){} // RVA: 0x7FFAC3135090
        public void set_AngVelocity(){} // RVA: 0x7FFAC4411DF0
        public void get_Gestures(){} // RVA: 0x7FFAC2F247C0
        public void set_Gestures(){} // RVA: 0x7FFAC2F87E80
        public void get_Fingers(){} // RVA: 0x7FFAC2F4F0C0
        public void set_Fingers(){} // RVA: 0x7FFAC2F4F0D0
        public void get_Pose(){} // RVA: 0x7FFAC2F4F130
        public void set_Pose(){} // RVA: 0x7FFAC2F22E90
        public void get_Puppet(){} // RVA: 0x7FFAC31D95E0
        public void set_Puppet(){} // RVA: 0x7FFAC2F4F890
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFAC31D0140
        public void set_EyeLookTargetPosition(){} // RVA: 0x7FFAC31D0C20
        public void get_EyeClosedAmount(){} // RVA: 0x7FFAC2FDCC00
        public void set_EyeClosedAmount(){} // RVA: 0x7FFAC2FDCC10
        public void get_SpineLengthFactor(){} // RVA: 0x7FFAC2F9C730
        public void set_SpineLengthFactor(){} // RVA: 0x7FFAC2F9C740
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFAC2FC20E0
        public void set_FaceTrackedVisemes(){} // RVA: 0x7FFAC30794D0
        public void .ctor(){} // RVA: 0x7FFAC9D7D190
        public void DeserializeFromBinary(){} // RVA: 0x7FFAC9D7D540
        public void SerializeToBinary(){} // RVA: 0x7FFAC9D7D630
    }

    public class PoseRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFAC9D7D730
    }

    public class PuppetData : ValueType
    {
        public Google.FlatBuffers8.Struct ByteBuffer; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFAC4420220
        public void __init(){} // RVA: 0x7FFAC9D74EF0
        public void __assign(){} // RVA: 0x7FFAC9D74FC0
        public void Channels(){} // RVA: 0x7FFAC9D7A3F0
        public void MutateChannels(){} // RVA: 0x7FFAC9D7A420
        public void CreatePuppetData(){} // RVA: 0x7FFAC9D830F0
        public void UnPack(){} // RVA: 0x7FFAC9D83200
        public void UnPackTo(){} // RVA: 0x7FFAC9D83270
        public void Pack(){} // RVA: 0x7FFAC9D83370
    }

    public class PuppetDataT : Object
    {
        public byte[] Channels; // 0x10

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7FFAC2F3C380
        public void set_Channels(){} // RVA: 0x7FFAC2F22E30
        public void .ctor(){} // RVA: 0x7FFAC9D83390
    }

}