// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 6
// Methods: 59

namespace VRC.Core.Networking.Pose
{
    public class Configuration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE881807E0
    }

    public class DirectQuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88180F50
        public void Encode(){} // RVA: 0x7FFE88181300
        public void CreateFingers(){} // RVA: 0x7FFE88181900
        public void CreateMuscles(){} // RVA: 0x7FFE881819B0
        public void Decode(){} // RVA: 0x7FFE88181B40
        public void ReadMuscles(){} // RVA: 0x7FFE88182230
        public void ReadFingers(){} // RVA: 0x7FFE88182470
        public void ReadLegacyFace(){} // RVA: 0x7FFE881825A0
        public void ReadPuppet(){} // RVA: 0x7FFE88182680
    }

    public class IPoseRecorder
    {
        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFE80E2F150
        public void set_UseDirectPoseCodec(){} // RVA: 0x7FFE80E466C0
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7FFE80E460A0
        public void Decode(){} // RVA: 0x7FFE80E52EB0
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE80E460A0
        public void Encode(){} // RVA: 0x7FFE80E38BF0
        public void Decode(){} // RVA: 0x7FFE810A1420
    }

    public class PoseEvent : TweenableValue`1
    {
        public ushort _poseContents; // 0x40
        public float[] muscles; // 0x48
        public VRC.Core.Networking.FlatBuffers.FlatBuffers8.QuaternionT bodyRotation; // 0x50
        public byte standingHeight; // 0x58
        public byte motionFlags; // 0x59
        public byte miscFlags; // 0x5A
        public byte handGestureLeft; // 0x5B
        public byte handGestureRight; // 0x5C
        public int handGestureIndexLeft; // 0x60
        public int handGestureIndexRight; // 0x64
        public float handGestureWeightLeft; // 0x68

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881834E0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE88184100
        public void get_poseContents(){} // RVA: 0x7FFE851042F0
        public void set_poseContents(){} // RVA: 0x7FFE86EC3420
        public void get_IsImmobilized(){} // RVA: 0x7FFE881842A0
        public void get_IsLocomoting(){} // RVA: 0x7FFE881842B0
        public void get_IsSeated(){} // RVA: 0x7FFE881842C0
        public void get_InVehicle(){} // RVA: 0x7FFE881842D0
        public void get_IsGrounded(){} // RVA: 0x7FFE881842E0
        public void get_IsAFK(){} // RVA: 0x7FFE881842F0
        public void get_InStation(){} // RVA: 0x7FFE88184300
        public void get_IsOwnerIKDisabled(){} // RVA: 0x7FFE88184310
        public void get_IsMutingSelf(){} // RVA: 0x7FFE88184320
        public void DeepCopy(){} // RVA: 0x7FFE88184330
        public void PartialCopy(){} // RVA: 0x7FFE88184430
        public void IsEmpty(){} // RVA: 0x7FFE88184C10
        public void Contains(){} // RVA: 0x7FFE88184C20 | overloaded x2
        public void Remove(){} // RVA: 0x7FFE88184C30 | overloaded x2
        public void Add(){} // RVA: 0x7FFE88184C40 | overloaded x3
        public void ClearFlags(){} // RVA: 0x7FFE88184C50
        public void get_Contents(){} // RVA: 0x7FFE88184C60
        public void CountOnes(){} // RVA: 0x7FFE88184D10
        public void Interpolate(){} // RVA: 0x7FFE88184D40
        public void Extrapolate(){} // RVA: 0x7FFE88184D80
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7FFE88184E00
        public void DecodeGestureFromNetwork(){} // RVA: 0x7FFE88184E10
    }

    public class QuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE881854A0
        public void Encode(){} // RVA: 0x7FFE88185850
        public void CreateFingers(){} // RVA: 0x7FFE881860E0
        public void CreateMuscles(){} // RVA: 0x7FFE881861B0
        public void Decode(){} // RVA: 0x7FFE88186370
        public void ReadHandGestures(){} // RVA: 0x7FFE88186A00
        public void ReadMuscles(){} // RVA: 0x7FFE88186BC0
        public void ReadFingers(){} // RVA: 0x7FFE88186E90
        public void ReadEyes(){} // RVA: 0x7FFE88187060
        public void ReadLegacyFace(){} // RVA: 0x7FFE881871A0
        public void ReadPuppet(){} // RVA: 0x7FFE88187320
    }

}