// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector : BaseVisionTaskApi
    {
        public object _packetCallback;
        public object _normalizedRect;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65F1790
        public void CreateFromOptions(){} // RVA: 0x65F18D0
        public void TryDetect(){} // RVA: 0x65F2090
        public void DetectInternal(){} // RVA: 0x65F22C0
        public void TryDetectForVideo(){} // RVA: 0x65F2420
        public void DetectForVideoInternal(){} // RVA: 0x65F2660
        public void DetectAsync(){} // RVA: 0x65F27E0
        public void BuildPacketsCallback(){} // RVA: 0x65F2960
        public void TryBuildFaceDetectorResult(){} // RVA: 0x65F2AF0
    }

    public class FaceDetectorOptions : Object
    {
        public object _baseOptions;
        public object _runningMode;
        public object _minDetectionConfidence;
        public object _minSuppressionThreshold;
        public object _numFaces;
        public object _resultCallback;

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0xB5DBF0
        public void get_runningMode(){} // RVA: 0xE62D00
        public void get_minDetectionConfidence(){} // RVA: 0xC152D0
        public void get_minSuppressionThreshold(){} // RVA: 0xB6B200
        public void get_numFaces(){} // RVA: 0x15AF000
        public void get_resultCallback(){} // RVA: 0xB70160
        public void .ctor(){} // RVA: 0x65F3170
        public void ToProto(){} // RVA: 0x65F3240
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x65F3350
    }

}