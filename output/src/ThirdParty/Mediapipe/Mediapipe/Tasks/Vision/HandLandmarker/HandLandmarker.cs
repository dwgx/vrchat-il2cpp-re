// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AD94EB80
        public void CreateFromOptions(){} // RVA: 0x7AD94ECC0
        public void TryDetect(){} // RVA: 0x7AD94F770
        public void DetectInternal(){} // RVA: 0x7AD94F9A0
        public void TryDetectForVideo(){} // RVA: 0x7AD94FB00
        public void DetectForVideoInternal(){} // RVA: 0x7AD94FD40
        public void DetectAsync(){} // RVA: 0x7AD94FEC0
        public void BuildPacketsCallback(){} // RVA: 0x7AD950040
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x7AD9501F0
    }

    public class HandLandmarkerOptions : Object
    {
        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7A80F2570
        public void get_runningMode(){} // RVA: 0x7A83782A0
        public void get_numHands(){} // RVA: 0x7A9739200
        public void get_minHandDetectionConfidence(){} // RVA: 0x7A81002C0
        public void get_minHandPresenceConfidence(){} // RVA: 0x7A82461C0
        public void get_minTrackingConfidence(){} // RVA: 0x7A81B7060
        public void get_resultCallback(){} // RVA: 0x7A83F69F0
        public void .ctor(){} // RVA: 0x7AD950820
        public void ToProto(){} // RVA: 0x7AD950920
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7AD950B40
    }

    public class HandLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7660880
        public void Alloc(){} // RVA: 0x7AD950C30
        public void CloneTo(){} // RVA: 0x7A7E2B080
        public void ToString(){} // RVA: 0x7A7E2B090
    }

}