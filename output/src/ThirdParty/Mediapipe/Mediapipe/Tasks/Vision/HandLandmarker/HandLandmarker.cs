// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD537184D0
        public void CreateFromOptions(){} // RVA: 0x7FFD53718600
        public void TryDetect(){} // RVA: 0x7FFD537190B0
        public void DetectInternal(){} // RVA: 0x7FFD537192D0
        public void TryDetectForVideo(){} // RVA: 0x7FFD53719430
        public void DetectForVideoInternal(){} // RVA: 0x7FFD53719660
        public void DetectAsync(){} // RVA: 0x7FFD537197E0
        public void BuildPacketsCallback(){} // RVA: 0x7FFD53719960
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x7FFD53719B10
    }

    public class HandLandmarkerOptions : Object
    {
        public object baseOptions;
        public object runningMode;
        public object numHands;
        public object minHandDetectionConfidence;
        public object minHandPresenceConfidence;
        public object minTrackingConfidence;
        public object resultCallback;

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFD4E35C380
        public void get_runningMode(){} // RVA: 0x7FFD4E577800
        public void get_numHands(){} // RVA: 0x7FFD4F8557F0
        public void get_minHandDetectionConfidence(){} // RVA: 0x7FFD4E36A080
        public void get_minHandPresenceConfidence(){} // RVA: 0x7FFD4E4AEF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFD4E420210
        public void get_resultCallback(){} // RVA: 0x7FFD4E5F95E0
        public void .ctor(){} // RVA: 0x7FFD5371A130
        public void ToProto(){} // RVA: 0x7FFD5371A230
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFD5371A450
    }

    public class HandLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F88FCC0
        public void Alloc(){} // RVA: 0x7FFD5371A540
        public void CloneTo(){} // RVA: 0x7FFD5371A680
        public void ToString(){} // RVA: 0x7FFD5371AA30
    }

}