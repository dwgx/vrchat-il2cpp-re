// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
// Classes: 3
// Methods: 23

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.HandLandmarker
{
    public class HandLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE866A1DD0
        public void CreateFromOptions(){} // RVA: 0x7FFE866A1F00
        public void TryDetect(){} // RVA: 0x7FFE866A29B0
        public void DetectInternal(){} // RVA: 0x7FFE866A2BD0
        public void TryDetectForVideo(){} // RVA: 0x7FFE866A2D30
        public void DetectForVideoInternal(){} // RVA: 0x7FFE866A2F60
        public void DetectAsync(){} // RVA: 0x7FFE866A30E0
        public void BuildPacketsCallback(){} // RVA: 0x7FFE866A3260
        public void TryBuildHandLandmarkerResult(){} // RVA: 0x7FFE866A3410
    }

    public class HandLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions _baseOptions; // 0x10
        public 0x6660F784 _runningMode; // 0x18
        public int _numHands; // 0x1C
        public float _minHandDetectionConfidence; // 0x20
        public float _minHandPresenceConfidence; // 0x24
        public float _minTrackingConfidence; // 0x28
        public ResultCallback _resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFE81116380
        public void get_runningMode(){} // RVA: 0x7FFE813DB630
        public void get_numHands(){} // RVA: 0x7FFE82707EE0
        public void get_minHandDetectionConfidence(){} // RVA: 0x7FFE81124080
        public void get_minHandPresenceConfidence(){} // RVA: 0x7FFE81268F50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFE811DA210
        public void get_resultCallback(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE866A3A30
        public void ToProto(){} // RVA: 0x7FFE866A3B30
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFE866A3D50
    }

    public class HandLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82760A10
        public void Alloc(){} // RVA: 0x7FFE866A3E40
        public void CloneTo(){} // RVA: 0x7FFE866A3F80
        public void ToString(){} // RVA: 0x7FFE866A4330
    }

}