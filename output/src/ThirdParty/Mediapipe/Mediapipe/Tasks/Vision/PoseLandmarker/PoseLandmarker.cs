// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8608C40
        public void CreateFromOptions(){} // RVA: 0x7FFAF8608D70
        public void TryDetect(){} // RVA: 0x7FFAF8609820
        public void DetectInternal(){} // RVA: 0x7FFAF8609A40
        public void TryDetectForVideo(){} // RVA: 0x7FFAF8609BA0
        public void DetectForVideoInternal(){} // RVA: 0x7FFAF8609DD0
        public void DetectAsync(){} // RVA: 0x7FFAF8609F50
        public void BuildPacketsCallback(){} // RVA: 0x7FFAF860A0D0
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x7FFAF860A280
    }

    public class PoseLandmarkerOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAF2DA8380
        public void get_runningMode(){} // RVA: 0x7FFAF306ED50
        public void get_numPoses(){} // RVA: 0x7FFAF442C3B0
        public void get_minPoseDetectionConfidence(){} // RVA: 0x7FFAF2DB6080
        public void get_minPosePresenceConfidence(){} // RVA: 0x7FFAF2EFAF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFAF2E6C210
        public void get_outputSegmentationMasks(){} // RVA: 0x7FFAF2E6C230
        public void get_resultCallback(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF860A8B0
        public void ToProto(){} // RVA: 0x7FFAF860A9C0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAF860ABE0
    }

    public class PoseLandmarkerResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4488110
        public void Alloc(){} // RVA: 0x7FFAF860ADE0
        public void CloneTo(){} // RVA: 0x7FFAF860AF30
        public void ToString(){} // RVA: 0x7FFAF860B4B0
    }

}