// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 8
// Methods: 65

namespace VRC.Core.Networking.Pose
{
    public class Configuration
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAFA0F3790
    }

    public class DirectQuantizedPose
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA0F3F00
        public void Encode(){} // RVA: 0x7FFAFA0F42B0
        public void CreateFingers(){} // RVA: 0x7FFAFA0F48B0
        public void CreateMuscles(){} // RVA: 0x7FFAFA0F4960
        public void Decode(){} // RVA: 0x7FFAFA0F4AF0
        public void ReadMuscles(){} // RVA: 0x7FFAFA0F51E0
        public void ReadFingers(){} // RVA: 0x7FFAFA0F5420
        public void ReadLegacyFace(){} // RVA: 0x7FFAFA0F5550
        public void ReadPuppet(){} // RVA: 0x7FFAFA0F5630
    }

    public class IPoseRecorder
    {
        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFAF2ABDBE0
        public void set_UseDirectPoseCodec(){} // RVA: 0x7FFAF2AD5130
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7FFAF2AD4B10
        public void Decode(){} // RVA: 0x7FFAF2AE18E0
    }

    public class PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2AD4B10
        public void Encode(){} // RVA: 0x7FFAF2AC7680
        public void Decode(){} // RVA: 0x7FFAF2D33FA0
    }

    public class PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Encode(){} // RVA: 0x7FFAF2AC7680
        public void Decode(){}
    }

    public class PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8EE30
        public void Encode(){} // RVA: 0x7FFAF2AC7680
        public void Decode(){}
    }

    public class PoseEvent
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA0F6490 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAFA0F70B0
        public void get_poseContents(){} // RVA: 0x7FFAF6F7B950
        public void set_poseContents(){} // RVA: 0x7FFAF8E32A00
        public void get_IsImmobilized(){} // RVA: 0x7FFAFA0F7250
        public void get_IsLocomoting(){} // RVA: 0x7FFAFA0F7260
        public void get_IsSeated(){} // RVA: 0x7FFAFA0F7270
        public void get_InVehicle(){} // RVA: 0x7FFAFA0F7280
        public void get_IsGrounded(){} // RVA: 0x7FFAFA0F7290
        public void get_IsAFK(){} // RVA: 0x7FFAFA0F72A0
        public void get_InStation(){} // RVA: 0x7FFAFA0F72B0
        public void get_IsOwnerIKDisabled(){} // RVA: 0x7FFAFA0F72C0
        public void get_IsMutingSelf(){} // RVA: 0x7FFAFA0F72D0
        public void DeepCopy(){} // RVA: 0x7FFAFA0F72E0
        public void PartialCopy(){} // RVA: 0x7FFAFA0F73E0
        public void IsEmpty(){} // RVA: 0x7FFAFA0F7BC0
        public void Contains(){} // RVA: 0x7FFAFA0F7BD0 | overloaded x2
        public void Remove(){} // RVA: 0x7FFAFA0F7BE0 | overloaded x2
        public void Add(){} // RVA: 0x7FFAFA0F7BF0 | overloaded x3
        public void ClearFlags(){} // RVA: 0x7FFAFA0F7C00
        public void get_Contents(){} // RVA: 0x7FFAFA0F7C10
        public void CountOnes(){} // RVA: 0x7FFAFA0F7CC0
        public void Interpolate(){} // RVA: 0x7FFAFA0F7CF0
        public void Extrapolate(){} // RVA: 0x7FFAFA0F7D30
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7FFAFA0F7DB0
        public void DecodeGestureFromNetwork(){} // RVA: 0x7FFAFA0F7DC0
    }

    public class QuantizedPose
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAFA0F8450
        public void Encode(){} // RVA: 0x7FFAFA0F8800
        public void CreateFingers(){} // RVA: 0x7FFAFA0F9090
        public void CreateMuscles(){} // RVA: 0x7FFAFA0F9160
        public void Decode(){} // RVA: 0x7FFAFA0F9320
        public void ReadHandGestures(){} // RVA: 0x7FFAFA0F99B0
        public void ReadMuscles(){} // RVA: 0x7FFAFA0F9B70
        public void ReadFingers(){} // RVA: 0x7FFAFA0F9E40
        public void ReadEyes(){} // RVA: 0x7FFAFA0FA010
        public void ReadLegacyFace(){} // RVA: 0x7FFAFA0FA150
        public void ReadPuppet(){} // RVA: 0x7FFAFA0FA2D0
    }

}