// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 16
// Methods: 163

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class PlayerDrone : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0xAB

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsPlayerDrone(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifyPlayerDrone(){} // RVA: 0x7FFE88121510
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Throttle(){} // RVA: 0x7FFE88120470
        public void CreatePlayerDrone(){} // RVA: 0x7FFE88121600
        public void StartPlayerDrone(){} // RVA: 0x7FFE8811DF00
        public void AddThrottle(){} // RVA: 0x7FFE881205B0
        public void EndPlayerDrone(){} // RVA: 0x7FFE881216F0
        public void FinishPlayerDroneBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE88121780
        public void UnPackTo(){} // RVA: 0x7FFE88120750
        public void Pack(){} // RVA: 0x7FFE88121820
    }

    public class PlayerDroneT : Object
    {
        public float _throttle; // 0x10

        // ── Methods ──
        public void get_Throttle(){} // RVA: 0x7FFE81225320
        public void set_Throttle(){} // RVA: 0x7FFE81225330
        public void .ctor(){} // RVA: 0x7FFE817EE4A0
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88121840
        public void SerializeToBinary(){} // RVA: 0x7FFE88121970
    }

    public class PlayerDroneVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88120A00
    }

    public class PoseFingerData : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void FingerStretch(){} // RVA: 0x7FFE881228C0
        public void FingerSpread(){} // RVA: 0x7FFE881228F0
        public void CreatePoseFingerData(){} // RVA: 0x7FFE88122920
        public void UnPack(){} // RVA: 0x7FFE88122AB0
        public void UnPackTo(){} // RVA: 0x7FFE88122B20
        public void Pack(){} // RVA: 0x7FFE88122CE0
    }

    public class PoseFingerDataT : Object
    {
        public byte[] _fingerStretch; // 0x10
        public byte[] _fingerSpread; // 0x18

        // ── Methods ──
        public void get_FingerStretch(){} // RVA: 0x7FFE81116380
        public void set_FingerStretch(){} // RVA: 0x7FFE810FCE30
        public void get_FingerSpread(){} // RVA: 0x7FFE810FE7C0
        public void set_FingerSpread(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE88122D00
    }

    public class PoseHandGestures : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0xB9
        public object field_2; // 0xBA

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_HandGestureLeft(){} // RVA: 0x7FFE88122E10
        public void get_HandGestureRight(){} // RVA: 0x7FFE88122E40
        public void CreatePoseHandGestures(){} // RVA: 0x7FFE88122E70
        public void UnPack(){} // RVA: 0x7FFE88122F70
        public void UnPackTo(){} // RVA: 0x7FFE88123000
        public void Pack(){} // RVA: 0x7FFE88123060
    }

    public class PoseHandGesturesT : Object
    {
        public byte _handGestureLeft; // 0x10
        public byte _handGestureRight; // 0x11

        // ── Methods ──
        public void get_HandGestureLeft(){} // RVA: 0x7FFE811C55E0
        public void set_HandGestureLeft(){} // RVA: 0x7FFE811C55F0
        public void get_HandGestureRight(){} // RVA: 0x7FFE81346E30
        public void set_HandGestureRight(){} // RVA: 0x7FFE813471A0
        public void .ctor(){} // RVA: 0x7FFE818F2DB0
    }

    public class PoseMuscleData : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10
        public object field_1; // 0xB0
        public object field_2; // 0xB1

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_BodyRotation(){} // RVA: 0x7FFE88121E70
        public void get_HipPosition(){} // RVA: 0x7FFE88121EB0
        public void Muscles(){} // RVA: 0x7FFE88121EF0
        public void CreatePoseMuscleData(){} // RVA: 0x7FFE88121F20
        public void UnPack(){} // RVA: 0x7FFE88122120
        public void UnPackTo(){} // RVA: 0x7FFE88122330
        public void Pack(){} // RVA: 0x7FFE881225C0
    }

    public class PoseMuscleDataT : Object
    {
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionTenBitT _bodyRotation; // 0x10
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3HalfT _hipPosition; // 0x18
        public byte[] _muscles; // 0x20

        // ── Methods ──
        public void get_BodyRotation(){} // RVA: 0x7FFE81116380
        public void set_BodyRotation(){} // RVA: 0x7FFE810FCE30
        public void get_HipPosition(){} // RVA: 0x7FFE810FE7C0
        public void set_HipPosition(){} // RVA: 0x7FFE81161E80
        public void get_Muscles(){} // RVA: 0x7FFE811290C0
        public void set_Muscles(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE88122710
    }

    public class PosePositionDataUnion : Object
    {
        public 0x665F5844 _type; // 0x10
        public object _value; // 0x18

        // ── Methods ──
        public void get_Type(){} // RVA: 0x7FFE811C55E0
        public void set_Type(){} // RVA: 0x7FFE811C55F0
        public void get_Value(){} // RVA: 0x7FFE810FE7C0
        public void set_Value(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE8811CB20
        public void As(){} // RVA: 0x7FFE810A1420
        public void AsPoseMuscleData(){} // RVA: 0x7FFE88121A70
        public void FromPoseMuscleData(){} // RVA: 0x7FFE88121B30
        public void Pack(){} // RVA: 0x7FFE88121C30
    }

    public class PosePositionDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88121E30
    }

    public class PoseRecorder : ValueType
    {
        public Google.FlatBuffers8.Table __p; // 0x10
        public object field_1; // 0xC0
        public object field_2; // 0xC1
        public object field_3; // 0xC2
        public object field_4; // 0xC3
        public object field_5; // 0xC4
        public object field_6; // 0xC5
        public object field_7; // 0xC6
        public object field_8; // 0xC7
        public object field_9; // 0xC8
        public object field_10; // 0xC9
        public object field_11; // 0xCA
        public object field_12; // 0xCB
        public object field_13; // 0xCC

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void ValidateVersion(){} // RVA: 0x7FFE810FB310
        public void GetRootAsPoseRecorder(){} // RVA: 0x7FFE8811DC90 | overloaded x2
        public void VerifyPoseRecorder(){} // RVA: 0x7FFE881233B0
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void get_Contents(){} // RVA: 0x7FFE881234A0
        public void get_MotionFlags(){} // RVA: 0x7FFE881234F0
        public void get_ExtraFlags(){} // RVA: 0x7FFE88123540
        public void get_StandingHeight(){} // RVA: 0x7FFE88123590
        public void get_AngVelocity(){} // RVA: 0x7FFE881235E0
        public void get_Gestures(){} // RVA: 0x7FFE88123630
        public void get_Fingers(){} // RVA: 0x7FFE88123740
        public void get_PoseType(){} // RVA: 0x7FFE88123850
        public void Pose(){} // RVA: 0x7FFE810A1420
        public void PoseAsPoseMuscleData(){} // RVA: 0x7FFE881238A0
        public void get_Puppet(){} // RVA: 0x7FFE88123930
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFE88123A40
        public void get_EyeClosedAmount(){} // RVA: 0x7FFE88123B50
        public void get_SpineLengthFactor(){} // RVA: 0x7FFE88123BA0
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFE88123CB0
        public void CreatePoseRecorder(){} // RVA: 0x7FFE88123DC0
        public void StartPoseRecorder(){} // RVA: 0x7FFE88124250
        public void AddContents(){} // RVA: 0x7FFE88124270
        public void AddMotionFlags(){} // RVA: 0x7FFE881242E0
        public void AddExtraFlags(){} // RVA: 0x7FFE88124350
        public void AddStandingHeight(){} // RVA: 0x7FFE881243C0
        public void AddAngVelocity(){} // RVA: 0x7FFE88124430
        public void AddGestures(){} // RVA: 0x7FFE881244A0
        public void AddFingers(){} // RVA: 0x7FFE881244D0
        public void AddPoseType(){} // RVA: 0x7FFE88124500
        public void AddPose(){} // RVA: 0x7FFE88124570
        public void AddPuppet(){} // RVA: 0x7FFE881245B0
        public void AddEyeLookTargetPosition(){} // RVA: 0x7FFE881245E0
        public void AddEyeClosedAmount(){} // RVA: 0x7FFE88124610
        public void AddSpineLengthFactor(){} // RVA: 0x7FFE88124680
        public void AddFaceTrackedVisemes(){} // RVA: 0x7FFE881246B0
        public void EndPoseRecorder(){} // RVA: 0x7FFE881246E0
        public void FinishPoseRecorderBuffer(){} // RVA: 0x7FFE8811F580
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x7FFE8811F5E0
        public void UnPack(){} // RVA: 0x7FFE88124770
        public void UnPackTo(){} // RVA: 0x7FFE881247E0
        public void Pack(){} // RVA: 0x7FFE88125260
    }

    public class PoseRecorderT : Object
    {
        public ushort _contents; // 0x10
        public byte _motionFlags; // 0x12
        public byte _extraFlags; // 0x13
        public byte _standingHeight; // 0x14
        public byte _angVelocity; // 0x15
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PoseHandGesturesT _gestures; // 0x18
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PoseFingerDataT _fingers; // 0x20
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PosePositionDataUnion _pose; // 0x28
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.PuppetDataT _puppet; // 0x30
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3TenBitT _eyeLookTargetPosition; // 0x38
        public byte _eyeClosedAmount; // 0x40
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.FloatHalfT _spineLengthFactor; // 0x48
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.FaceTrackedVisemeDataT _faceTrackedVisemes; // 0x50

        // ── Methods ──
        public void get_Contents(){} // RVA: 0x7FFE8299FB40
        public void set_Contents(){} // RVA: 0x7FFE8299FB10
        public void get_MotionFlags(){} // RVA: 0x7FFE826E3520
        public void set_MotionFlags(){} // RVA: 0x7FFE826E34A0
        public void get_ExtraFlags(){} // RVA: 0x7FFE826E3500
        public void set_ExtraFlags(){} // RVA: 0x7FFE826E3510
        public void get_StandingHeight(){} // RVA: 0x7FFE8124ABD0
        public void set_StandingHeight(){} // RVA: 0x7FFE8124ABE0
        public void get_AngVelocity(){} // RVA: 0x7FFE8139AC40
        public void set_AngVelocity(){} // RVA: 0x7FFE826E34C0
        public void get_Gestures(){} // RVA: 0x7FFE810FE7C0
        public void set_Gestures(){} // RVA: 0x7FFE81161E80
        public void get_Fingers(){} // RVA: 0x7FFE811290C0
        public void set_Fingers(){} // RVA: 0x7FFE811290D0
        public void get_Pose(){} // RVA: 0x7FFE81129130
        public void set_Pose(){} // RVA: 0x7FFE810FCE90
        public void get_Puppet(){} // RVA: 0x7FFE8144E200
        public void set_Puppet(){} // RVA: 0x7FFE81129890
        public void get_EyeLookTargetPosition(){} // RVA: 0x7FFE8143BA80
        public void set_EyeLookTargetPosition(){} // RVA: 0x7FFE81437330
        public void get_EyeClosedAmount(){} // RVA: 0x7FFE811B6C00
        public void set_EyeClosedAmount(){} // RVA: 0x7FFE811B6C10
        public void get_SpineLengthFactor(){} // RVA: 0x7FFE81176730
        public void set_SpineLengthFactor(){} // RVA: 0x7FFE81176740
        public void get_FaceTrackedVisemes(){} // RVA: 0x7FFE8119C0E0
        public void set_FaceTrackedVisemes(){} // RVA: 0x7FFE812534D0
        public void .ctor(){} // RVA: 0x7FFE88125380
        public void DeserializeFromBinary(){} // RVA: 0x7FFE88125730
        public void SerializeToBinary(){} // RVA: 0x7FFE88125820
    }

    public class PoseRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x7FFE88125920
    }

    public class PuppetData : ValueType
    {
        public Google.FlatBuffers8.Struct __p; // 0x10

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x7FFE826F4210
        public void __init(){} // RVA: 0x7FFE8811D5B0
        public void __assign(){} // RVA: 0x7FFE8811D680
        public void Channels(){} // RVA: 0x7FFE881228C0
        public void CreatePuppetData(){} // RVA: 0x7FFE8812B0B0
        public void UnPack(){} // RVA: 0x7FFE8812B1C0
        public void UnPackTo(){} // RVA: 0x7FFE8812B230
        public void Pack(){} // RVA: 0x7FFE8812B330
    }

    public class PuppetDataT : Object
    {
        public byte[] _channels; // 0x10

        // ── Methods ──
        public void get_Channels(){} // RVA: 0x7FFE81116380
        public void set_Channels(){} // RVA: 0x7FFE810FCE30
        public void .ctor(){} // RVA: 0x7FFE8812B350
    }

}