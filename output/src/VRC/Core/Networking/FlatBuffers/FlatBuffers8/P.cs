// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.FlatBuffers.FlatBuffers8
// Classes: 16
// Methods: 161

namespace VRC.Core.Networking.FlatBuffers.FlatBuffers8
{
    public class PlayerDrone : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsPlayerDrone(){} // RVA: 0x8217320
        public void VerifyPlayerDrone(){} // RVA: 0x821ABE0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Throttle(){} // RVA: 0x9B5DE0
        public void CreatePlayerDrone(){} // RVA: 0x821ACD0
        public void StartPlayerDrone(){} // RVA: 0x8217590
        public void AddThrottle(){} // RVA: 0x8219C80
        public void EndPlayerDrone(){} // RVA: 0x821ADC0
        public void FinishPlayerDroneBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedPlayerDroneBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B6100
        public void UnPackTo(){} // RVA: 0x9B5E40
        public void Pack(){} // RVA: 0x821AEF0
    }

    public class PlayerDroneT : Object
    {
        public object _throttle;

        // ── Methods ──
        public void get_Throttle(){} // RVA: 0xC763E0
        public void set_Throttle(){} // RVA: 0xC763F0
        public void .ctor(){} // RVA: 0x132A2D0
        public void DeserializeFromBinary(){} // RVA: 0x821AF10
        public void SerializeToBinary(){} // RVA: 0x821B040
    }

    public class PlayerDroneVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x821A0D0
    }

    public class PoseFingerData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void FingerStretch(){} // RVA: 0x9B6360
        public void FingerSpread(){} // RVA: 0x9B6390
        public void CreatePoseFingerData(){} // RVA: 0x821BF60
        public void UnPack(){} // RVA: 0x9B63C0
        public void UnPackTo(){} // RVA: 0x9B63D0
        public void Pack(){} // RVA: 0x821C320
    }

    public class PoseFingerDataT : Object
    {
        public object _fingerStretch;
        public object _fingerSpread;

        // ── Methods ──
        public void get_FingerStretch(){} // RVA: 0xB5DBF0
        public void set_FingerStretch(){} // RVA: 0xB44D60
        public void get_FingerSpread(){} // RVA: 0xB465B0
        public void set_FingerSpread(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x821C340
    }

    public class PoseHandGestures : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_HandGestureLeft(){} // RVA: 0x9B64A0
        public void get_HandGestureRight(){} // RVA: 0x9B64D0
        public void CreatePoseHandGestures(){} // RVA: 0x821C4B0
        public void UnPack(){} // RVA: 0x9B6500
        public void UnPackTo(){} // RVA: 0x9B6510
        public void Pack(){} // RVA: 0x821C6A0
    }

    public class PoseHandGesturesT : Object
    {
        public object _handGestureLeft;
        public object _handGestureRight;

        // ── Methods ──
        public void get_HandGestureLeft(){} // RVA: 0xC120A0
        public void set_HandGestureLeft(){} // RVA: 0xC120B0
        public void get_HandGestureRight(){} // RVA: 0xDD5C50
        public void set_HandGestureRight(){} // RVA: 0xDD7A00
        public void .ctor(){} // RVA: 0xE02D60
    }

    public class PoseMuscleData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_BodyRotation(){} // RVA: 0x9B61D0
        public void get_HipPosition(){} // RVA: 0x9B6210
        public void Muscles(){} // RVA: 0x9B6250
        public void CreatePoseMuscleData(){} // RVA: 0x821B560
        public void UnPack(){} // RVA: 0x9B6280
        public void UnPackTo(){} // RVA: 0x9B6290
        public void Pack(){} // RVA: 0x821BC10
    }

    public class PoseMuscleDataT : Object
    {
        public object _bodyRotation;
        public object _hipPosition;
        public object _muscles;

        // ── Methods ──
        public void get_BodyRotation(){} // RVA: 0xB5DBF0
        public void set_BodyRotation(){} // RVA: 0xB44D60
        public void get_HipPosition(){} // RVA: 0xB465B0
        public void set_HipPosition(){} // RVA: 0xBA9BA0
        public void get_Muscles(){} // RVA: 0xB700F0
        public void set_Muscles(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x821BD50
    }

    public class PosePositionDataUnion : Object
    {
        public object _type;
        public object _value;

        // ── Methods ──
        public void get_Type(){} // RVA: 0xC120A0
        public void set_Type(){} // RVA: 0xC120B0
        public void get_Value(){} // RVA: 0xB465B0
        public void set_Value(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0x8215F60
        public void As(){} // RVA: 0xA94080
        public void AsPoseMuscleData(){} // RVA: 0x821B140
        public void FromPoseMuscleData(){} // RVA: 0x821B1C0
        public void Pack(){} // RVA: 0x821B2C0
    }

    public class PosePositionDataVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x821B470
    }

    public class PoseRecorder : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void ValidateVersion(){} // RVA: 0xB43310
        public void GetRootAsPoseRecorder(){} // RVA: 0x8217320
        public void VerifyPoseRecorder(){} // RVA: 0x821CA10
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void get_Contents(){} // RVA: 0x9B6710
        public void get_MotionFlags(){} // RVA: 0x9B6760
        public void get_ExtraFlags(){} // RVA: 0x9B67B0
        public void get_StandingHeight(){} // RVA: 0x9B6800
        public void get_AngVelocity(){} // RVA: 0x9B6850
        public void get_Gestures(){} // RVA: 0x9B68A0
        public void get_Fingers(){} // RVA: 0x9B68D0
        public void get_PoseType(){} // RVA: 0x9B6900
        public void Pose(){} // RVA: 0xA94080
        public void PoseAsPoseMuscleData(){} // RVA: 0x9B6950
        public void get_Puppet(){} // RVA: 0x9B69E0
        public void get_EyeLookTargetPosition(){} // RVA: 0x9B6A10
        public void get_EyeClosedAmount(){} // RVA: 0x9B6A40
        public void get_SpineLengthFactor(){} // RVA: 0x9B6A90
        public void get_FaceTrackedVisemes(){} // RVA: 0x9B6AC0
        public void CreatePoseRecorder(){} // RVA: 0x821D480
        public void StartPoseRecorder(){} // RVA: 0x821D910
        public void AddContents(){} // RVA: 0x821D930
        public void AddMotionFlags(){} // RVA: 0x821D9A0
        public void AddExtraFlags(){} // RVA: 0x821DA10
        public void AddStandingHeight(){} // RVA: 0x821DA80
        public void AddAngVelocity(){} // RVA: 0x821DAF0
        public void AddGestures(){} // RVA: 0x821DB60
        public void AddFingers(){} // RVA: 0x821DB90
        public void AddPoseType(){} // RVA: 0x821DBC0
        public void AddPose(){} // RVA: 0x821DC30
        public void AddPuppet(){} // RVA: 0x821DC70
        public void AddEyeLookTargetPosition(){} // RVA: 0x821DCA0
        public void AddEyeClosedAmount(){} // RVA: 0x821DCD0
        public void AddSpineLengthFactor(){} // RVA: 0x821DD40
        public void AddFaceTrackedVisemes(){} // RVA: 0x821DD70
        public void EndPoseRecorder(){} // RVA: 0x821DDA0
        public void FinishPoseRecorderBuffer(){} // RVA: 0x8218C30
        public void FinishSizePrefixedPoseRecorderBuffer(){} // RVA: 0x8218C90
        public void UnPack(){} // RVA: 0x9B6AF0
        public void UnPackTo(){} // RVA: 0x9B6B00
        public void Pack(){} // RVA: 0x821E920
    }

    public class PoseRecorderT : Object
    {
        public object _contents;
        public object _motionFlags;
        public object _extraFlags;
        public object _standingHeight;
        public object _angVelocity;
        public object _gestures;
        public object _fingers;
        public object _pose;
        public object _puppet;
        public object _eyeLookTargetPosition;
        public object _eyeClosedAmount;
        public object _spineLengthFactor;
        public object _faceTrackedVisemes;

        // ── Methods ──
        public void get_Contents(){} // RVA: 0x24EA1D0
        public void set_Contents(){} // RVA: 0x24EAB10
        public void get_MotionFlags(){} // RVA: 0x22201E0
        public void set_MotionFlags(){} // RVA: 0x22201F0
        public void get_ExtraFlags(){} // RVA: 0x2220200
        public void set_ExtraFlags(){} // RVA: 0x2220210
        public void get_StandingHeight(){} // RVA: 0xC9C250
        public void set_StandingHeight(){} // RVA: 0xC9C260
        public void get_AngVelocity(){} // RVA: 0xE2F5E0
        public void set_AngVelocity(){} // RVA: 0x2220220
        public void get_Gestures(){} // RVA: 0xB465B0
        public void set_Gestures(){} // RVA: 0xBA9BA0
        public void get_Fingers(){} // RVA: 0xB700F0
        public void set_Fingers(){} // RVA: 0xB70100
        public void get_Pose(){} // RVA: 0xB70160
        public void set_Pose(){} // RVA: 0xB44DC0
        public void get_Puppet(){} // RVA: 0xD33E60
        public void set_Puppet(){} // RVA: 0xB708C0
        public void get_EyeLookTargetPosition(){} // RVA: 0xD05CA0
        public void set_EyeLookTargetPosition(){} // RVA: 0xD09D70
        public void get_EyeClosedAmount(){} // RVA: 0xC02470
        public void set_EyeClosedAmount(){} // RVA: 0xC02480
        public void get_SpineLengthFactor(){} // RVA: 0xBBF8F0
        public void set_SpineLengthFactor(){} // RVA: 0xBBF900
        public void get_FaceTrackedVisemes(){} // RVA: 0xBE58B0
        public void set_FaceTrackedVisemes(){} // RVA: 0xCA4DF0
        public void .ctor(){} // RVA: 0x821EA10
        public void DeserializeFromBinary(){} // RVA: 0x821EDC0
        public void SerializeToBinary(){} // RVA: 0x821EEC0
    }

    public class PoseRecorderVerify : Object
    {
        // ── Methods ──
        public void Verify(){} // RVA: 0x821EFC0
    }

    public class PuppetData : ValueType
    {
        public object __p;

        // ── Methods ──
        public void get_ByteBuffer(){} // RVA: 0x77ED0
        public void __init(){} // RVA: 0x9B5420
        public void __assign(){} // RVA: 0x9B5430
        public void Channels(){} // RVA: 0x9B6360
        public void CreatePuppetData(){} // RVA: 0x8224B40
        public void UnPack(){} // RVA: 0x9B7A90
        public void UnPackTo(){} // RVA: 0x9B7AA0
        public void Pack(){} // RVA: 0x8224DE0
    }

    public class PuppetDataT : Object
    {
        public object _channels;

        // ── Methods ──
        public void get_Channels(){} // RVA: 0xB5DBF0
        public void set_Channels(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0x8224E00
    }

}