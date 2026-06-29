// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
// Classes: 3
// Methods: 24

namespace ThirdParty.Mediapipe.Mediapipe.Tasks.Vision.PoseLandmarker
{
    public class PoseLandmarker : BaseVisionTaskApi
    {
        public object _packetCallback;
        public object _normalizedRect;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x65D2E20
        public void CreateFromOptions(){} // RVA: 0x65D2F60
        public void TryDetect(){} // RVA: 0x65D3950
        public void DetectInternal(){} // RVA: 0x65D3B80
        public void TryDetectForVideo(){} // RVA: 0x65D3CE0
        public void DetectForVideoInternal(){} // RVA: 0x65D3F20
        public void DetectAsync(){} // RVA: 0x65D40A0
        public void BuildPacketsCallback(){} // RVA: 0x65D4220
        public void TryBuildPoseLandmarkerResult(){} // RVA: 0x65D43D0
    }

    public class PoseLandmarkerOptions : Object
    {
        public object _baseOptions;
        public object _runningMode;
        public object _numPoses;
        public object _minPoseDetectionConfidence;
        public object _minPosePresenceConfidence;
        public object _minTrackingConfidence;
        public object _outputSegmentationMasks;
        public object _resultCallback;

        // ── Methods ──
        public void get_baseOptions(){} // RVA: 0xB5DBF0
        public void get_runningMode(){} // RVA: 0xE62D00
        public void get_numPoses(){} // RVA: 0x2244FB0
        public void get_minPoseDetectionConfidence(){} // RVA: 0xB6B200
        public void get_minPosePresenceConfidence(){} // RVA: 0xCBAD90
        public void get_minTrackingConfidence(){} // RVA: 0xC27360
        public void get_outputSegmentationMasks(){} // RVA: 0xC27380
        public void get_resultCallback(){} // RVA: 0xD33E60
        public void .ctor(){} // RVA: 0x65D4A00
        public void ToProto(){} // RVA: 0x65D4B10
        public void Mediapipe.Tasks.Core.ITaskOptions.ToCalculatorOptions(){} // RVA: 0x65D4D30
    }

    public class PoseLandmarkerResult : ValueType
    {
        public object poseLandmarks;
        public object poseWorldLandmarks;
        public object segmentationMasks;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x79C50
        public void Alloc(){} // RVA: 0x65D4F30
        public void CloneTo(){} // RVA: 0x8A6A40
        public void ToString(){} // RVA: 0x8A6A50
    }

}