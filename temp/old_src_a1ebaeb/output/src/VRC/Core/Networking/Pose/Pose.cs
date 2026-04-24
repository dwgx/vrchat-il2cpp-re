// VRChat IL2CPP Deobfuscated Source
// Namespace: VRC.Core.Networking.Pose
// Classes: 8
// Methods: 65

namespace VRC.Core.Networking.Pose
{
    public class Configuration : Object
    {
        public object MuscleUsedCount; // 0x335E22E0
        public object FRAME_BUFFER_BONES; // 0x335E22E0
        public object PUPPET_FLAGS; // 0x335E22E0

        // ── Original Methods ──
        public void .cctor(){} // RVA: 0x7ffaaf7fe450
    }

    public class DirectQuantizedPose : PoseCodec`1
    {
        public object puppetValues; // 0x33ACD770
        public object spreadBytes; // 0x33ACD770

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf7febc0
        public void Encode(){} // RVA: 0x7ffaaf7fef70
        public void CreateFingers(){} // RVA: 0x7ffaaf7ff570
        public void CreateMuscles(){} // RVA: 0x7ffaaf7ff620
        public void Decode(){} // RVA: 0x7ffaaf7ff7b0
        public void ReadMuscles(){} // RVA: 0x7ffaaf7ffea0
        public void ReadFingers(){} // RVA: 0x7ffaaf8000e0
        public void ReadLegacyFace(){} // RVA: 0x7ffaaf800210
        public void ReadPuppet(){} // RVA: 0x7ffaaf8002f0
    }

    public class IPoseRecorder
    {
        // ── Original Methods ──
        public void get_UseDirectPoseCodec(){} // RVA: 0x7ffaa864a040
        public void set_UseDirectPoseCodec(){} // RVA: 0x7ffaa86613a0
        public void UpdatePuppetChannelTypes(){} // RVA: 0x7ffaa8660d80
        public void Decode(){} // RVA: 0x7ffaa866daf0
    }

    public class PoseCodec`1 : Object
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660d80
        public void Encode(){} // RVA: 0x7ffaa8653ae0
        public void Decode(){} // RVA: 0x7ffaa887e5c0
    }

    public class PoseCodec`1 : Object
    {
        public object h; // 0xB407F7C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Encode(){} // RVA: 0x7ffaa8653ae0
        public void Decode(){}
    }

    public class PoseCodec`1 : Object
    {
        public object h; // 0xB407F740

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8933e30
        public void Encode(){} // RVA: 0x7ffaa8653ae0
        public void Decode(){}
    }

    public class PoseEvent : TweenableValue`1
    {
        public object bodyRotation; // 0x337544B0
        public object miscFlags; // 0x337544B0
        public object handGestureIndexLeft; // 0x337544B0
        public object handGestureWeightRight; // 0x337544B0
        public object headPosition; // 0x337544B0
        public object headRotation; // 0x337544B0
        public object hipPosition; // 0x337544B0
        public object hipRotation; // 0x337544B0
        public object fingerStretch; // 0x337544B0
        public object eyeClosedAmount; // 0x337544B0
        public object puppetIsFloat; // 0x337544B0
        public object `Ǐf; // 0xB4199910
        public object h; // 0x81AD8318
        public object h; // 0x81AD8370
        public object h; // 0x81AD83D0
        public object `Ǐf; // 0xB4199910
        public object h; // 0x81AD8498

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf801150
        public void .ctor(){} // RVA: 0x7ffaaf801150
        public void Finalize(){} // RVA: 0x7ffaaf801d70
        public void get_poseContents(){} // RVA: 0x7ffaac7a05f0
        public void set_poseContents(){} // RVA: 0x7ffaae53afb0
        public void get_IsImmobilized(){} // RVA: 0x7ffaaf801f10
        public void get_IsLocomoting(){} // RVA: 0x7ffaaf801f20
        public void get_IsSeated(){} // RVA: 0x7ffaaf801f30
        public void get_InVehicle(){} // RVA: 0x7ffaaf801f40
        public void get_IsGrounded(){} // RVA: 0x7ffaaf801f50
        public void get_IsAFK(){} // RVA: 0x7ffaaf801f60
        public void get_InStation(){} // RVA: 0x7ffaaf801f70
        public void get_IsOwnerIKDisabled(){} // RVA: 0x7ffaaf801f80
        public void get_IsMutingSelf(){} // RVA: 0x7ffaaf801f90
        public void DeepCopy(){} // RVA: 0x7ffaaf801fa0
        public void PartialCopy(){} // RVA: 0x7ffaaf8020a0
        public void IsEmpty(){} // RVA: 0x7ffaaf802880
        public void Contains(){} // RVA: 0x7ffaaf802890
        public void Contains(){} // RVA: 0x7ffaaf802890
        public void Remove(){} // RVA: 0x7ffaaf8028a0
        public void Remove(){} // RVA: 0x7ffaaf8028a0
        public void Add(){} // RVA: 0x7ffaaf8028b0
        public void Add(){} // RVA: 0x7ffaaf8028b0
        public void Add(){} // RVA: 0x7ffaaf8028b0
        public void ClearFlags(){} // RVA: 0x7ffaaf8028c0
        public void get_Contents(){} // RVA: 0x7ffaaf8028d0
        public void CountOnes(){} // RVA: 0x7ffaaf802980
        public void Interpolate(){} // RVA: 0x7ffaaf8029b0
        public void Extrapolate(){} // RVA: 0x7ffaaf8029f0
        public void DecodeGestureIndexFromNetwork(){} // RVA: 0x7ffaaf802a70
        public void DecodeGestureFromNetwork(){} // RVA: 0x7ffaaf802a80
    }

    public class QuantizedPose : PoseCodec`1
    {
        public object puppetValues; // 0x337DE7D0
        public object spreadBytes; // 0x337DE7D0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf803110
        public void Encode(){} // RVA: 0x7ffaaf8034c0
        public void CreateFingers(){} // RVA: 0x7ffaaf803d50
        public void CreateMuscles(){} // RVA: 0x7ffaaf803e20
        public void Decode(){} // RVA: 0x7ffaaf803fe0
        public void ReadHandGestures(){} // RVA: 0x7ffaaf804670
        public void ReadMuscles(){} // RVA: 0x7ffaaf804830
        public void ReadFingers(){} // RVA: 0x7ffaaf804b00
        public void ReadEyes(){} // RVA: 0x7ffaaf804cd0
        public void ReadLegacyFace(){} // RVA: 0x7ffaaf804e10
        public void ReadPuppet(){} // RVA: 0x7ffaaf804f90
    }

}