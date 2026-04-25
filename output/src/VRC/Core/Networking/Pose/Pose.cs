// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 6
// Methods: 59

namespace VRC.Core.Networking.Pose
{
    public class Configuration : Object
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFD551FBA30
    }

    public class DirectQuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD551FC1A0
        public void Encode(){} // RVA: 0x7FFD551FC550
        public void CreateFingers(){} // RVA: 0x7FFD551FCB50
        public void CreateMuscles(){} // RVA: 0x7FFD551FCC00
        public void Decode(){} // RVA: 0x7FFD551FCD90
        public void ReadMuscles(){} // RVA: 0x7FFD551FD480
        public void ReadFingers(){} // RVA: 0x7FFD551FD6C0
        public void ReadLegacyFace(){} // RVA: 0x7FFD551FD7F0
        public void ReadPuppet(){} // RVA: 0x7FFD551FD8D0
    }

    public class IPoseRecorder
    {
        public object UseDirectPoseCodec;

        // ── Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x7FFD4E079D00
        public void set_UseDirectPoseCodec(){} // RVA: 0x7FFD4E091060
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7FFD4E090A40
        public void Decode(){} // RVA: 0x7FFD4E09D7B0
    }

    public class PoseCodec`1 : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E090A40
        public void Encode(){} // RVA: 0x7FFD4E0837A0
        public void Decode(){} // RVA: 0x7FFD4E2ADC40
    }

    public class PoseEvent : TweenableValue`1
    {
        public object poseContents;
        public object IsImmobilized;
        public object IsLocomoting;
        public object IsSeated;
        public object InVehicle;
        public object IsGrounded;
        public object IsAFK;
        public object InStation;
        public object IsOwnerIKDisabled;
        public object IsMutingSelf;
        public object Contents;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD551FE730 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD551FF350
        public void get_poseContents(){} // RVA: 0x7FFD5219BEA0
        public void set_poseContents(){} // RVA: 0x7FFD53F39DB0
        public void get_IsImmobilized(){} // RVA: 0x7FFD551FF4F0
        public void get_IsLocomoting(){} // RVA: 0x7FFD551FF500
        public void get_IsSeated(){} // RVA: 0x7FFD551FF510
        public void get_InVehicle(){} // RVA: 0x7FFD551FF520
        public void get_IsGrounded(){} // RVA: 0x7FFD551FF530
        public void get_IsAFK(){} // RVA: 0x7FFD551FF540
        public void get_InStation(){} // RVA: 0x7FFD551FF550
        public void get_IsOwnerIKDisabled(){} // RVA: 0x7FFD551FF560
        public void get_IsMutingSelf(){} // RVA: 0x7FFD551FF570
        public void DeepCopy(){} // RVA: 0x7FFD551FF580
        public void PartialCopy(){} // RVA: 0x7FFD551FF680
        public void IsEmpty(){} // RVA: 0x7FFD551FFE60
        public void Contains(){} // RVA: 0x7FFD551FFE70 | overloaded x2
        public void Remove(){} // RVA: 0x7FFD551FFE80 | overloaded x2
        public void Add(){} // RVA: 0x7FFD551FFE90 | overloaded x3
        public void ClearFlags(){} // RVA: 0x7FFD551FFEA0
        public void get_Contents(){} // RVA: 0x7FFD551FFEB0
        public void CountOnes(){} // RVA: 0x7FFD551FFF60
        public void Interpolate(){} // RVA: 0x7FFD551FFF90
        public void Extrapolate(){} // RVA: 0x7FFD551FFFD0
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7FFD55200050
        public void DecodeGestureFromNetwork(){} // RVA: 0x7FFD55200060
    }

    public class QuantizedPose : PoseCodec`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD552006F0
        public void Encode(){} // RVA: 0x7FFD55200AA0
        public void CreateFingers(){} // RVA: 0x7FFD55201330
        public void CreateMuscles(){} // RVA: 0x7FFD55201400
        public void Decode(){} // RVA: 0x7FFD552015C0
        public void ReadHandGestures(){} // RVA: 0x7FFD55201C50
        public void ReadMuscles(){} // RVA: 0x7FFD55201E10
        public void ReadFingers(){} // RVA: 0x7FFD552020E0
        public void ReadEyes(){} // RVA: 0x7FFD552022B0
        public void ReadLegacyFace(){} // RVA: 0x7FFD552023F0
        public void ReadPuppet(){} // RVA: 0x7FFD55202570
    }

}