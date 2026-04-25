// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
        public PacketsCallback _packetCallback; // 0x20
        public Mediapipe.NormalizedRect _normalizedRect; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC82F0170
        public void CreateFromOptions(){} // RVA: 0x7FFAC82F02A0
        public void TryDetect(){} // RVA: 0x7FFAC82F0D50
        public void DetectInternal(){} // RVA: 0x7FFAC82F0F70
        public void TryDetectForVideo(){} // RVA: 0x7FFAC82F10D0
        public void DetectForVideoInternal(){} // RVA: 0x7FFAC82F1300
        public void DetectAsync(){} // RVA: 0x7FFAC82F1480
        public void BuildPacketsCallback(){} // RVA: 0x7FFAC82F1600
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x7FFAC82F17B0
    }

    public class PoseLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions baseOptions; // 0x10
        public 0x6B215EC0 runningMode; // 0x18
        public int numPoses; // 0x1C
        public float minPoseDetectionConfidence; // 0x20
        public float minPosePresenceConfidence; // 0x24
        public float minTrackingConfidence; // 0x28
        public bool outputSegmentationMasks; // 0x2C
        public ResultCallback resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAC2F3C380
        public void get_runningMode(){} // RVA: 0x7FFAC3157800
        public void get_numPoses(){} // RVA: 0x7FFAC44357F0
        public void get_minPoseDetectionConfidence(){} // RVA: 0x7FFAC2F4A080
        public void get_minPosePresenceConfidence(){} // RVA: 0x7FFAC308EF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFAC3000210
        public void get_outputSegmentationMasks(){} // RVA: 0x7FFAC3000230
        public void get_resultCallback(){} // RVA: 0x7FFAC31D95E0
        public void .ctor(){} // RVA: 0x7FFAC82F1DE0
        public void ToProto(){} // RVA: 0x7FFAC82F1EF0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAC82F2110
    }

    public class PoseLandmarkerResult : ValueType
    {
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.NormalizedLandmarks> poseLandmarks; // 0x10
        public System.Collections.Generic.List`1<Mediapipe.Tasks.Components.Containers.Landmarks> poseWorldLandmarks; // 0x18
        public System.Collections.Generic.List`1<Mediapipe.Image> segmentationMasks; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC446FCC0
        public void Alloc(){} // RVA: 0x7FFAC82F2310
        public void CloneTo(){} // RVA: 0x7FFAC82F2460
        public void ToString(){} // RVA: 0x7FFAC82F29E0
    }

}