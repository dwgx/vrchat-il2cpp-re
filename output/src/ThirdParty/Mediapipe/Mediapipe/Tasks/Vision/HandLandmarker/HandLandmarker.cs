// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8610FA0
        public void CreateFromOptions(){} // RVA: 0x7FFAF86110D0
        public void TryDetect(){} // RVA: 0x7FFAF8611B80
        public void DetectInternal(){} // RVA: 0x7FFAF8611DA0
        public void TryDetectForVideo(){} // RVA: 0x7FFAF8611F00
        public void DetectForVideoInternal(){} // RVA: 0x7FFAF8612130
        public void DetectAsync(){} // RVA: 0x7FFAF86122B0
        public void BuildPacketsCallback(){} // RVA: 0x7FFAF8612430
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x7FFAF86125E0
    }

    public class HandLandmarkerOptions
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFAF2DA8380
        public void get_runningMode(){} // RVA: 0x7FFAF306ED50
        public void get_numHands(){} // RVA: 0x7FFAF442C3B0
        public void get_minHandDetectionConfidence(){} // RVA: 0x7FFAF2DB6080
        public void get_minHandPresenceConfidence(){} // RVA: 0x7FFAF2EFAF50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFAF2E6C210
        public void get_resultCallback(){} // RVA: 0x7FFAF30E74D0
        public void .ctor(){} // RVA: 0x7FFAF8612C00
        public void ToProto(){} // RVA: 0x7FFAF8612D00
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFAF8612F20
    }

    public class HandLandmarkerResult
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4488110
        public void Alloc(){} // RVA: 0x7FFAF8613010
        public void CloneTo(){} // RVA: 0x7FFAF8613150
        public void ToString(){} // RVA: 0x7FFAF8613500
    }

}