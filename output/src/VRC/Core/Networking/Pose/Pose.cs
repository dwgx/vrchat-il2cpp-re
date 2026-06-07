// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 6
// Methods: 59

namespace VRC.Core.Networking.Pose
{
    public class Configuration
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7643790
    }

    public class DirectQuantizedPose
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7643F00
        public void Encode(){} // RVA: 0x76442B0
        public void CreateFingers(){} // RVA: 0x76448B0
        public void CreateMuscles(){} // RVA: 0x7644960
        public void Decode(){} // RVA: 0x7644AF0
        public void ReadMuscles(){} // RVA: 0x76451E0
        public void ReadFingers(){} // RVA: 0x7645420
        public void ReadLegacyFace(){} // RVA: 0x7645550
        public void ReadPuppet(){} // RVA: 0x7645630
    }

    public class IPoseRecorder
    {
        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0xDBE0
        public void set_UseDirectPoseCodec(){} // RVA: 0x25130
        public void UpdatePuppetChannelTypes(){} // RVA: 0x24B10
        public void Decode(){} // RVA: 0x318E0
    }

    public class PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24B10
        public void Encode(){} // RVA: 0x17680
        public void Decode(){} // RVA: 0x283FA0
    }

    public class PoseEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7646490 | overloaded x2
        public void Finalize(){} // RVA: 0x76470B0
        public void get_poseContents(){} // RVA: 0x44CB950
        public void set_poseContents(){} // RVA: 0x6382A00
        public void get_IsImmobilized(){} // RVA: 0x7647250
        public void get_IsLocomoting(){} // RVA: 0x7647260
        public void get_IsSeated(){} // RVA: 0x7647270
        public void get_InVehicle(){} // RVA: 0x7647280
        public void get_IsGrounded(){} // RVA: 0x7647290
        public void get_IsAFK(){} // RVA: 0x76472A0
        public void get_InStation(){} // RVA: 0x76472B0
        public void get_IsOwnerIKDisabled(){} // RVA: 0x76472C0
        public void get_IsMutingSelf(){} // RVA: 0x76472D0
        public void DeepCopy(){} // RVA: 0x76472E0
        public void PartialCopy(){} // RVA: 0x76473E0
        public void IsEmpty(){} // RVA: 0x7647BC0
        public void Contains(){} // RVA: 0x7647BD0 | overloaded x2
        public void Remove(){} // RVA: 0x7647BE0 | overloaded x2
        public void Add(){} // RVA: 0x7647BF0 | overloaded x3
        public void ClearFlags(){} // RVA: 0x7647C00
        public void get_Contents(){} // RVA: 0x7647C10
        public void CountOnes(){} // RVA: 0x7647CC0
        public void Interpolate(){} // RVA: 0x7647CF0
        public void Extrapolate(){} // RVA: 0x7647D30
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7647DB0
        public void DecodeGestureFromNetwork(){} // RVA: 0x7647DC0
    }

    public class QuantizedPose
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7648450
        public void Encode(){} // RVA: 0x7648800
        public void CreateFingers(){} // RVA: 0x7649090
        public void CreateMuscles(){} // RVA: 0x7649160
        public void Decode(){} // RVA: 0x7649320
        public void ReadHandGestures(){} // RVA: 0x76499B0
        public void ReadMuscles(){} // RVA: 0x7649B70
        public void ReadFingers(){} // RVA: 0x7649E40
        public void ReadEyes(){} // RVA: 0x764A010
        public void ReadLegacyFace(){} // RVA: 0x764A150
        public void ReadPuppet(){} // RVA: 0x764A2D0
    }

}