// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B778B0
        public void CreateFromOptions(){} // RVA: 0x5B779E0
        public void TryDetect(){} // RVA: 0x5B78220
        public void DetectInternal(){} // RVA: 0x5B78440
        public void TryDetectForVideo(){} // RVA: 0x5B785A0
        public void DetectForVideoInternal(){} // RVA: 0x5B787D0
        public void DetectAsync(){} // RVA: 0x5B78950
        public void BuildPacketsCallback(){} // RVA: 0x5B78AD0
        public void TryBuildFaceDetectorResult(){} // RVA: 0x5B78C60
    }

    public class FaceDetectorOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x2F8380
        public void get_runningMode(){} // RVA: 0x5BED50
        public void get_minDetectionConfidence(){} // RVA: 0x3AA570
        public void get_minSuppressionThreshold(){} // RVA: 0x306080
        public void get_numFaces(){} // RVA: 0xCEF5B0
        public void get_resultCallback(){} // RVA: 0x30B130
        public void .ctor(){} // RVA: 0x5B792C0
        public void ToProto(){} // RVA: 0x5B79390
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x5B794A0
    }

}