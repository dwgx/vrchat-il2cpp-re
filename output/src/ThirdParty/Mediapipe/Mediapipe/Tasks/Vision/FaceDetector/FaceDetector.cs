// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
// Classes: 2
// Methods: 18

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.FaceDetector
{
    public class FaceDetector : BaseVisionTaskApi
    {
        public PacketsCallback _packetCallback; // 0x20
        public Mediapipe.NormalizedRect _normalizedRect; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC830EDE0
        public void CreateFromOptions(){} // RVA: 0x7FFAC830EF10
        public void TryDetect(){} // RVA: 0x7FFAC830F750
        public void DetectInternal(){} // RVA: 0x7FFAC830F970
        public void TryDetectForVideo(){} // RVA: 0x7FFAC830FAD0
        public void DetectForVideoInternal(){} // RVA: 0x7FFAC830FD00
        public void DetectAsync(){} // RVA: 0x7FFAC830FE80
        public void BuildPacketsCallback(){} // RVA: 0x7FFAC8310000
        public void TryBuildFaceDetectorResult(){} // RVA: 0x7FFAC8310190
    }

    public class FaceDetectorOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions baseOptions; // 0x10
        public 0x6B215EC0 runningMode; // 0x18
        public float minDetectionConfidence; // 0x1C
        public float minSuppressionThreshold; // 0x20
        public int numFaces; // 0x24
        public ResultCallback resultCallback; // 0x28

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAC2F3C380
        public void get_runningMode(){} // RVA: 0x7FFAC3157800
        public void get_minDetectionConfidence(){} // RVA: 0x7FFAC2FEE570
        public void get_minSuppressionThreshold(){} // RVA: 0x7FFAC2F4A080
        public void get_numFaces(){} // RVA: 0x7FFAC3921980
        public void get_resultCallback(){} // RVA: 0x7FFAC2F4F130
        public void .ctor(){} // RVA: 0x7FFAC83107F0
        public void ToProto(){} // RVA: 0x7FFAC83108C0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAC83109D0
    }

}