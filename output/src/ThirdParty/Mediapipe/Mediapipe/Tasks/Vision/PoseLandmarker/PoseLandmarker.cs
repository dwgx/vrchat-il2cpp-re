// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
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
        public object baseOptions;
        public object runningMode;
        public object numPoses;
        public object minPoseDetectionConfidence;
        public object minPosePresenceConfidence;
        public object minTrackingConfidence;
        public object outputSegmentationMasks;
        public object resultCallback;

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
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F88FCC0
        public void Alloc(){} // RVA: 0x7FFD53712310
        public void CloneTo(){} // RVA: 0x7FFD53712460
        public void ToString(){} // RVA: 0x7FFD537129E0
    }

}