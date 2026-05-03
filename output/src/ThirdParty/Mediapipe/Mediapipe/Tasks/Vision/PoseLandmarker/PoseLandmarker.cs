// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86699A70
        public void CreateFromOptions(){} // RVA: 0x7FFE86699BA0
        public void TryDetect(){} // RVA: 0x7FFE8669A650
        public void DetectInternal(){} // RVA: 0x7FFE8669A870
        public void TryDetectForVideo(){} // RVA: 0x7FFE8669A9D0
        public void DetectForVideoInternal(){} // RVA: 0x7FFE8669AC00
        public void DetectAsync(){} // RVA: 0x7FFE8669AD80
        public void BuildPacketsCallback(){} // RVA: 0x7FFE8669AF00
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x7FFE8669B0B0
    }

    public class PoseLandmarkerOptions : Object
    {
        public Mediapipe.Tasks.Core.BaseOptions _baseOptions; // 0x10
        public 0x6660F784 _runningMode; // 0x18
        public int _numPoses; // 0x1C
        public float _minPoseDetectionConfidence; // 0x20
        public float _minPosePresenceConfidence; // 0x24
        public float _minTrackingConfidence; // 0x28
        public bool _outputSegmentationMasks; // 0x2C
        public ResultCallback _resultCallback; // 0x30

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0x7FFE81116380
        public void get_runningMode(){} // RVA: 0x7FFE813DB630
        public void get_numPoses(){} // RVA: 0x7FFE82707EE0
        public void get_minPoseDetectionConfidence(){} // RVA: 0x7FFE81124080
        public void get_minPosePresenceConfidence(){} // RVA: 0x7FFE81268F50
        public void get_minTrackingConfidence(){} // RVA: 0x7FFE811DA210
        public void get_outputSegmentationMasks(){} // RVA: 0x7FFE811DA230
        public void get_resultCallback(){} // RVA: 0x7FFE8144E200
        public void .ctor(){} // RVA: 0x7FFE8669B6E0
        public void ToProto(){} // RVA: 0x7FFE8669B7F0
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x7FFE8669BA10
    }

    public class PoseLandmarkerResult : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82760A10
        public void Alloc(){} // RVA: 0x7FFE8669BC10
        public void CloneTo(){} // RVA: 0x7FFE8669BD60
        public void ToString(){} // RVA: 0x7FFE8669C2E0
    }

}