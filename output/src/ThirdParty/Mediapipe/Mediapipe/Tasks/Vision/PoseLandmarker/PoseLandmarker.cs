// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
        public 0x66577BA0 _packetCallback; // 0x20
        public 0x66573000 _normalizedRect; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53710170
        public void CreateFromOptions(){} // RVA: 0x7FFD537102A0
        public void TryDetect(){} // RVA: 0x7FFD53710D50
        public void DetectInternal(){} // RVA: 0x7FFD53710F70
        public void TryDetectForVideo(){} // RVA: 0x7FFD537110D0
        public void DetectForVideoInternal(){} // RVA: 0x7FFD53711300
        public void DetectAsync(){} // RVA: 0x7FFD53711480
        public void BuildPacketsCallback(){} // RVA: 0x7FFD53711600
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x7FFD537117B0
    }

    public class PoseLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions baseOptions; // 0x10
        public 0x66575EC0 runningMode; // 0x18
        public int numPoses; // 0x1C
        public float minPoseDetectionConfidence; // 0x20
        public float minPosePresenceConfidence; // 0x24
        public float minTrackingConfidence; // 0x28
        public bool outputSegmentationMasks; // 0x2C
        public 0x66575FC8 resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFD4E35C380
        public void get_runningMode(){} // RVA: 0x7FFD4E577800
        public void get_numPoses(){} // RVA: 0x7FFD4F8557F0
        public void get_minPoseDetectionConfidence(){} // RVA: 0x7FFD4E36A080
        public void get_minPosePresenceConfidence(){} // RVA: 0x7FFD4E4AEF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFD4E420210
        public void get_outputSegmentationMasks(){} // RVA: 0x7FFD4E420230
        public void get_resultCallback(){} // RVA: 0x7FFD4E5F95E0
        public void .ctor(){} // RVA: 0x7FFD53711DE0
        public void ToProto(){} // RVA: 0x7FFD53711EF0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFD53712110
    }

    public class PoseLandmarkerResult : ValueType
    {
        public System.Collections.Generic.List`1<0x66578438> poseLandmarks; // 0x10
        public System.Collections.Generic.List`1<0x665783E0> poseWorldLandmarks; // 0x18
        public System.Collections.Generic.List`1<Mediapipe.Image> segmentationMasks; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F88FCC0
        public void Alloc(){} // RVA: 0x7FFD53712310
        public void CloneTo(){} // RVA: 0x7FFD53712460
        public void ToString(){} // RVA: 0x7FFD537129E0
    }

}