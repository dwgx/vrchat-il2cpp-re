// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD946770
        public void CreateFromOptions(){} // RVA: 0x7AD9468B0
        public void TryDetect(){} // RVA: 0x7AD947360
        public void DetectInternal(){} // RVA: 0x7AD947590
        public void TryDetectForVideo(){} // RVA: 0x7AD9476F0
        public void DetectForVideoInternal(){} // RVA: 0x7AD947930
        public void DetectAsync(){} // RVA: 0x7AD947AB0
        public void BuildPacketsCallback(){} // RVA: 0x7AD947C30
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x7AD947DE0
    }

    public class PoseLandmarkerOptions : Object
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7A80F2570
        public void get_runningMode(){} // RVA: 0x7A83782A0
        public void get_numPoses(){} // RVA: 0x7A9739200
        public void get_minPoseDetectionConfidence(){} // RVA: 0x7A81002C0
        public void get_minPosePresenceConfidence(){} // RVA: 0x7A82461C0
        public void get_minTrackingConfidence(){} // RVA: 0x7A81B7060
        public void get_outputSegmentationMasks(){} // RVA: 0x7A81B7080
        public void get_resultCallback(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AD948410
        public void ToProto(){} // RVA: 0x7AD948520
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7AD948740
    }

    public class PoseLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7660880
        public void Alloc(){} // RVA: 0x7AD948940
        public void CloneTo(){} // RVA: 0x7A7E2AEC0
        public void ToString(){} // RVA: 0x7A7E2AED0
    }

}