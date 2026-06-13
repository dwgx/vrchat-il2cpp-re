// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B58C40
        public void CreateFromOptions(){} // RVA: 0x5B58D70
        public void TryDetect(){} // RVA: 0x5B59820
        public void DetectInternal(){} // RVA: 0x5B59A40
        public void TryDetectForVideo(){} // RVA: 0x5B59BA0
        public void DetectForVideoInternal(){} // RVA: 0x5B59DD0
        public void DetectAsync(){} // RVA: 0x5B59F50
        public void BuildPacketsCallback(){} // RVA: 0x5B5A0D0
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x5B5A280
    }

    public class PoseLandmarkerOptions
    {
        public Mediapipe.Tasks.Core.BaseOptions <baseOptions>k__BackingField; // 0x10
        public 0x65932078 <runningMode>k__BackingField; // 0x18
        public int <numPoses>k__BackingField; // 0x1C
        public float <minPoseDetectionConfidence>k__BackingField; // 0x20
        public float <minPosePresenceConfidence>k__BackingField; // 0x24
        public float <minTrackingConfidence>k__BackingField; // 0x28
        public bool <outputSegmentationMasks>k__BackingField; // 0x2C
        public ResultCallback <resultCallback>k__BackingField; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x2F8380
        public void get_runningMode(){} // RVA: 0x5BED50
        public void get_numPoses(){} // RVA: 0x197C3B0
        public void get_minPoseDetectionConfidence(){} // RVA: 0x306080
        public void get_minPosePresenceConfidence(){} // RVA: 0x44AF50
        public void get_minTrackingConfidence(){} // RVA: 0x3BC210
        public void get_outputSegmentationMasks(){} // RVA: 0x3BC230
        public void get_resultCallback(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x5B5A8B0
        public void ToProto(){} // RVA: 0x5B5A9C0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x5B5ABE0
    }

    public class PoseLandmarkerResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19D8110
        public void Alloc(){} // RVA: 0x5B5ADE0
        public void CloneTo(){} // RVA: 0x5B5AF30
        public void ToString(){} // RVA: 0x5B5B4B0
    }

}