// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 6
// Methods: 59

namespace VRC.Core.Networking.Pose
{
    public class Configuration : Object
    {
        public System.Collections.Immutable.ImmutableArray`1<bool> MuscleUsed;
        public int[] MuscleUsedIndices; // 0x8
        public int MuscleUsedCount; // 0x10
        public int MuscleCount; // 0x14
        public int MUSCLE_FLAGS;
        public int FRAME_BUFFER_BONES;
        public int FIRST_FINGER_MUSCLE;
        public int VISEME_COUNT;
        public int PUPPET_FLAGS;

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9DDBA30
    }

    public class DirectQuantizedPose : PoseCodec`1
    {
        public byte[] lastEncodedMuscles; // 0x18
        public float[] muscleCache; // 0x20
        public byte[] puppetValues; // 0x28
        public byte[] spineLengthFactorEncoded; // 0x30
        public byte[] stretchBytes; // 0x38
        public byte[] spreadBytes; // 0x40
        public int VISEME_COUNT;
        public byte[] legacyFaceBytes; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DDC1A0
        public void Encode(){} // RVA: 0x7FFAC9DDC550
        public void CreateFingers(){} // RVA: 0x7FFAC9DDCB50
        public void CreateMuscles(){} // RVA: 0x7FFAC9DDCC00
        public void Decode(){} // RVA: 0x7FFAC9DDCD90
        public void ReadMuscles(){} // RVA: 0x7FFAC9DDD480
        public void ReadFingers(){} // RVA: 0x7FFAC9DDD6C0
        public void ReadLegacyFace(){} // RVA: 0x7FFAC9DDD7F0
        public void ReadPuppet(){} // RVA: 0x7FFAC9DDD8D0
    }

    public class IPoseRecorder
    {
        public object UseDirectPoseCodec;

        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFAC2C59D00
        public void set_UseDirectPoseCodec(){} // RVA: 0x7FFAC2C71060
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7FFAC2C70A40
        public void Decode(){} // RVA: 0x7FFAC2C7D7B0
    }

    public class PoseCodec`1 : Object
    {
        public VRC.Core.Networking.Pose.IPoseRecorder poseRecorder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Encode(){} // RVA: 0x7FFAC2C637A0
        public void Decode(){} // RVA: 0x7FFAC2E8DC40
    }

    public class PoseEvent : TweenableValue`1
    {
        public ushort poseContents; // 0x40
        public float[] IsImmobilized; // 0x48
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT IsLocomoting; // 0x50
        public byte IsSeated; // 0x58
        public byte InVehicle; // 0x59
        public byte IsGrounded; // 0x5A
        public byte IsAFK; // 0x5B
        public byte InStation; // 0x5C
        public int IsOwnerIKDisabled; // 0x60
        public int IsMutingSelf; // 0x64
        public float Contents; // 0x68
        public float handGestureWeightRight; // 0x6C
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T leftHandPosition; // 0x70
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T rightHandPosition; // 0x78
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T headPosition; // 0x80
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT leftHandRotation; // 0x88
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT rightHandRotation; // 0x90
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT headRotation; // 0x98
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T leftFootPosition; // 0xA0
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T rightFootPosition; // 0xA8
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T hipPosition; // 0xB0
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT leftFootRotation; // 0xB8
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT rightFootRotation; // 0xC0
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT hipRotation; // 0xC8
        public float angVelocityY; // 0xD0
        public float spineLengthFactor; // 0xD4
        public float[] fingerStretch; // 0xD8
        public float[] fingerSpread; // 0xE0
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.Vector3T eyeTargetRelativePosition01; // 0xE8
        public byte eyeClosedAmount; // 0xF0
        public float[] faceTrackedVisemes; // 0xF8
        public float[] puppetValues; // 0x100
        public bool[] puppetIsFloat; // 0x108
        public VRC.Core.Networking.PositionEvent PositionEvent; // 0x110

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DDE730 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC9DDF350
        public void get_poseContents(){} // RVA: 0x7FFAC6D7BEA0
        public void set_poseContents(){} // RVA: 0x7FFAC8B19DB0
        public void get_IsImmobilized(){} // RVA: 0x7FFAC9DDF4F0
        public void get_IsLocomoting(){} // RVA: 0x7FFAC9DDF500
        public void get_IsSeated(){} // RVA: 0x7FFAC9DDF510
        public void get_InVehicle(){} // RVA: 0x7FFAC9DDF520
        public void get_IsGrounded(){} // RVA: 0x7FFAC9DDF530
        public void get_IsAFK(){} // RVA: 0x7FFAC9DDF540
        public void get_InStation(){} // RVA: 0x7FFAC9DDF550
        public void get_IsOwnerIKDisabled(){} // RVA: 0x7FFAC9DDF560
        public void get_IsMutingSelf(){} // RVA: 0x7FFAC9DDF570
        public void DeepCopy(){} // RVA: 0x7FFAC9DDF580
        public void PartialCopy(){} // RVA: 0x7FFAC9DDF680
        public void IsEmpty(){} // RVA: 0x7FFAC9DDFE60
        public void Contains(){} // RVA: 0x7FFAC9DDFE70 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAC9DDFE80 | overloaded x2
        public void Add(){} // RVA: 0x7FFAC9DDFE90 | overloaded x3
        public void ClearFlags(){} // RVA: 0x7FFAC9DDFEA0
        public void get_Contents(){} // RVA: 0x7FFAC9DDFEB0
        public void CountOnes(){} // RVA: 0x7FFAC9DDFF60
        public void Interpolate(){} // RVA: 0x7FFAC9DDFF90
        public void Extrapolate(){} // RVA: 0x7FFAC9DDFFD0
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7FFAC9DE0050
        public void DecodeGestureFromNetwork(){} // RVA: 0x7FFAC9DE0060
    }

    public class QuantizedPose : PoseCodec`1
    {
        public byte[] lastEncodedMuscles; // 0x18
        public float[] muscleCache; // 0x20
        public byte[] puppetValues; // 0x28
        public byte[] spineLengthFactorEncoded; // 0x30
        public byte[] stretchBytes; // 0x38
        public byte[] spreadBytes; // 0x40
        public int VISEME_COUNT;
        public byte[] legacyFaceBytes; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9DE06F0
        public void Encode(){} // RVA: 0x7FFAC9DE0AA0
        public void CreateFingers(){} // RVA: 0x7FFAC9DE1330
        public void CreateMuscles(){} // RVA: 0x7FFAC9DE1400
        public void Decode(){} // RVA: 0x7FFAC9DE15C0
        public void ReadHandGestures(){} // RVA: 0x7FFAC9DE1C50
        public void ReadMuscles(){} // RVA: 0x7FFAC9DE1E10
        public void ReadFingers(){} // RVA: 0x7FFAC9DE20E0
        public void ReadEyes(){} // RVA: 0x7FFAC9DE22B0
        public void ReadLegacyFace(){} // RVA: 0x7FFAC9DE23F0
        public void ReadPuppet(){} // RVA: 0x7FFAC9DE2570
    }

}