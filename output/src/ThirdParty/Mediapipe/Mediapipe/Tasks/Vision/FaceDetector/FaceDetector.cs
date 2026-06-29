// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD9655F0
        public void CreateFromOptions(){} // RVA: 0x7AD965730
        public void TryDetect(){} // RVA: 0x7AD965F70
        public void DetectInternal(){} // RVA: 0x7AD9661A0
        public void TryDetectForVideo(){} // RVA: 0x7AD966300
        public void DetectForVideoInternal(){} // RVA: 0x7AD966540
        public void DetectAsync(){} // RVA: 0x7AD9666C0
        public void BuildPacketsCallback(){} // RVA: 0x7AD966840
        public void TryBuildFaceDetectorResult(){} // RVA: 0x7AD9669D0
    }

    public class FaceDetectorOptions : Object
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7A80F2570
        public void get_runningMode(){} // RVA: 0x7A83782A0
        public void get_minDetectionConfidence(){} // RVA: 0x7A81A5180
        public void get_minSuppressionThreshold(){} // RVA: 0x7A81002C0
        public void get_numFaces(){} // RVA: 0x7A8AB15F0
        public void get_resultCallback(){} // RVA: 0x7A8105330
        public void .ctor(){} // RVA: 0x7AD967050
        public void ToProto(){} // RVA: 0x7AD967120
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7AD967230
    }

}