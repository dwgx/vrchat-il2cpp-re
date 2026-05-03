// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866B86E0
        public void CreateFromOptions(){} // RVA: 0x7FFE866B8810
        public void TryDetect(){} // RVA: 0x7FFE866B9050
        public void DetectInternal(){} // RVA: 0x7FFE866B9270
        public void TryDetectForVideo(){} // RVA: 0x7FFE866B93D0
        public void DetectForVideoInternal(){} // RVA: 0x7FFE866B9600
        public void DetectAsync(){} // RVA: 0x7FFE866B9780
        public void BuildPacketsCallback(){} // RVA: 0x7FFE866B9900
        public void TryBuildFaceDetectorResult(){} // RVA: 0x7FFE866B9A90
    }

    public class FaceDetectorOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions _baseOptions; // 0x10
        public 0x6660F784 _runningMode; // 0x18
        public float _minDetectionConfidence; // 0x1C
        public float _minSuppressionThreshold; // 0x20
        public int _numFaces; // 0x24
        public ResultCallback _resultCallback; // 0x28

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFE81116380
        public void get_runningMode(){} // RVA: 0x7FFE813DB630
        public void get_minDetectionConfidence(){} // RVA: 0x7FFE811C8570
        public void get_minSuppressionThreshold(){} // RVA: 0x7FFE81124080
        public void get_numFaces(){} // RVA: 0x7FFE81A56130
        public void get_resultCallback(){} // RVA: 0x7FFE81129130
        public void .ctor(){} // RVA: 0x7FFE866BA0F0
        public void ToProto(){} // RVA: 0x7FFE866BA1C0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFE866BA2D0
    }

}