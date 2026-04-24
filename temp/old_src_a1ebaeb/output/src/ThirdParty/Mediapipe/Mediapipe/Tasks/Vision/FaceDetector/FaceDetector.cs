// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector : BaseVisionTaskApi
    {
        public object _detectionResultAnnotationController; // 0x333F61C0

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaadd2ff90
        public void CreateFromOptions(){} // RVA: 0x7ffaadd300c0
        public void TryDetect(){} // RVA: 0x7ffaadd30900
        public void DetectInternal(){} // RVA: 0x7ffaadd30b20
        public void TryDetectForVideo(){} // RVA: 0x7ffaadd30c80
        public void DetectForVideoInternal(){} // RVA: 0x7ffaadd30eb0
        public void DetectAsync(){} // RVA: 0x7ffaadd31030
        public void BuildPacketsCallback(){} // RVA: 0x7ffaadd311b0
        public void TryBuildFaceDetectorResult(){} // RVA: 0x7ffaadd31340
    }

    public class FaceDetectorOptions : Object
    {
        public object _minDetectionConfidence; // 0x33AA4640, was: <minDetectionConfidence>k__Bac
        public object _resultCallback; // 0x33AA4640, was: <resultCallback>k__BackingFiel
        public object baseOptions; // 0x170002EC
        public object runningMode; // 0x170002ED

        // ── Original Methods ──
        public void get_baseOptions(){} // RVA: 0x7ffaa894d380
        public void get_runningMode(){} // RVA: 0x7ffaa8b945a0
        public void get_minDetectionConfidence(){} // RVA: 0x7ffaa89ff570
        public void get_minSuppressionThreshold(){} // RVA: 0x7ffaa895b080
        public void get_numFaces(){} // RVA: 0x7ffaa9349010
        public void get_resultCallback(){} // RVA: 0x7ffaa8960130
        public void .ctor(){} // RVA: 0x7ffaadd319a0
        public void ToProto(){} // RVA: 0x7ffaadd31a70
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7ffaadd31b80
    }

}