// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD5372EDE0
        public void CreateFromOptions(){} // RVA: 0x7FFD5372EF10
        public void TryDetect(){} // RVA: 0x7FFD5372F750
        public void DetectInternal(){} // RVA: 0x7FFD5372F970
        public void TryDetectForVideo(){} // RVA: 0x7FFD5372FAD0
        public void DetectForVideoInternal(){} // RVA: 0x7FFD5372FD00
        public void DetectAsync(){} // RVA: 0x7FFD5372FE80
        public void BuildPacketsCallback(){} // RVA: 0x7FFD53730000
        public void TryBuildFaceDetectorResult(){} // RVA: 0x7FFD53730190
    }

    public class FaceDetectorOptions : Object
    {
        public object baseOptions;
        public object runningMode;
        public object minDetectionConfidence;
        public object minSuppressionThreshold;
        public object numFaces;
        public object resultCallback;

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFD4E35C380
        public void get_runningMode(){} // RVA: 0x7FFD4E577800
        public void get_minDetectionConfidence(){} // RVA: 0x7FFD4E40E570
        public void get_minSuppressionThreshold(){} // RVA: 0x7FFD4E36A080
        public void get_numFaces(){} // RVA: 0x7FFD4ED41980
        public void get_resultCallback(){} // RVA: 0x7FFD4E36F130
        public void .ctor(){} // RVA: 0x7FFD537307F0
        public void ToProto(){} // RVA: 0x7FFD537308C0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFD537309D0
    }

}