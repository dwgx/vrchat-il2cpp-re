// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5B60FA0
        public void CreateFromOptions(){} // RVA: 0x5B610D0
        public void TryDetect(){} // RVA: 0x5B61B80
        public void DetectInternal(){} // RVA: 0x5B61DA0
        public void TryDetectForVideo(){} // RVA: 0x5B61F00
        public void DetectForVideoInternal(){} // RVA: 0x5B62130
        public void DetectAsync(){} // RVA: 0x5B622B0
        public void BuildPacketsCallback(){} // RVA: 0x5B62430
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x5B625E0
    }

    public class HandLandmarkerOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x2F8380
        public void get_runningMode(){} // RVA: 0x5BED50
        public void get_numHands(){} // RVA: 0x197C3B0
        public void get_minHandDetectionConfidence(){} // RVA: 0x306080
        public void get_minHandPresenceConfidence(){} // RVA: 0x44AF50
        public void get_minTrackingConfidence(){} // RVA: 0x3BC210
        public void get_resultCallback(){} // RVA: 0x6374D0
        public void .ctor(){} // RVA: 0x5B62C00
        public void ToProto(){} // RVA: 0x5B62D00
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x5B62F20
    }

    public class HandLandmarkerResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x19D8110
        public void Alloc(){} // RVA: 0x5B63010
        public void CloneTo(){} // RVA: 0x5B63150
        public void ToString(){} // RVA: 0x5B63500
    }

}