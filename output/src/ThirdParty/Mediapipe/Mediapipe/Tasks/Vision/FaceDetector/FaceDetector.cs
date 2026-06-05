// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF86278B0
        public void CreateFromOptions(){} // RVA: 0x7FFAF86279E0
        public void TryDetect(){} // RVA: 0x7FFAF8628220
        public void DetectInternal(){} // RVA: 0x7FFAF8628440
        public void TryDetectForVideo(){} // RVA: 0x7FFAF86285A0
        public void DetectForVideoInternal(){} // RVA: 0x7FFAF86287D0
        public void DetectAsync(){} // RVA: 0x7FFAF8628950
        public void BuildPacketsCallback(){} // RVA: 0x7FFAF8628AD0
        public void TryBuildFaceDetectorResult(){} // RVA: 0x7FFAF8628C60
    }

    public class FaceDetectorOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAF2DA8380
        public void get_runningMode(){} // RVA: 0x7FFAF306ED50
        public void get_minDetectionConfidence(){} // RVA: 0x7FFAF2E5A570
        public void get_minSuppressionThreshold(){} // RVA: 0x7FFAF2DB6080
        public void get_numFaces(){} // RVA: 0x7FFAF379F5B0
        public void get_resultCallback(){} // RVA: 0x7FFAF2DBB130
        public void .ctor(){} // RVA: 0x7FFAF86292C0
        public void ToProto(){} // RVA: 0x7FFAF8629390
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAF86294A0
    }

}